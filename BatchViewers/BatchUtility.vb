Imports Telerik.WinControls
Imports System.ComponentModel



Public Class BatchUtility

    Private _BS As List(Of BatchSet) = Nothing
    Private _AlreadyOpenedMetaUtility As Boolean = False

    Public Sub Init()
        UtilESStart.InitEngine()
        SetBatchSetGridSettings()
        SetTimer()
        UtilSQLServer.SetConnection(UtilDB.ConnectionString)
        UtilSetting.Init()
    End Sub

    Public Sub LoadData()
        _BS = BatchSet.LoadAll
        Dim zBatchViewSets As List(Of rowVwBatchProcessingSet) = VwBatchProcessingSet.LoadData("SELECT * FROM fv.vwBatchProcessingSet ORDER BY fldID")
        '  uxBatchSetGrid.DataSource = zBatchViewSets.OrderBy(Function(x) x.colId)
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Init()
            LoadData() '
        Catch ex As Exception
            MsgBox(ex.GetBaseException.Message & vbNewLine & vbNewLine & ex.Message & vbNewLine & ex.StackTrace.ToString)
        End Try
    End Sub

    Private Sub uxBatchSetGrid_CurrentRowChanged(sender As Object, e As UI.CurrentRowChangedEventArgs) Handles uxBatchSetGrid.CurrentRowChanged
        If Not TypeOf e.CurrentRow Is Telerik.WinControls.UI.GridViewFilteringRowInfo Then
            If Not IsNothing(e.CurrentRow) Then
                LoadSetItems(e.CurrentRow.Cells(0).Value)
                LoadLog(e.CurrentRow.Cells(0).Value)
            End If
        End If
    End Sub

    Private Sub LoadSetItems(pSetId)
        Dim zBatchItems As List(Of rowVwBatchProcessingSetItem) = VwBatchProcessingSetItem.LoadData("SELECT * FROM fv.vwBatchProcessingSetItem WHERE fldSetId=" & pSetId & " ORDER BY fldid")
        Me.uxBatchSetItemGrid.DataSource = zBatchItems
    End Sub

    Private Sub LoadLog(pSetId)
        Dim zLogItems As List(Of rowTblBatchProcessingLog) = TblBatchProcessingLog.LoadData("SELECT * FROM tblBatchProcessingLog WHERE FldSetId=" & pSetId)
        Me.uxBatchLogGrid.DataSource = zLogItems
        Me.uxBatchLogGrid.TableElement.ScrollToRow(Me.uxBatchLogGrid.RowCount)
    End Sub

    Private Sub UpdateStatus()
        LoadSetItems(uxBatchLogGrid.CurrentRow.Cells(0).Value)
        LoadLog(uxBatchLogGrid.CurrentRow.Cells(0).Value)
    End Sub

    Private Sub uxBatchSetItemGrid_CommandCellClick(sender As Object, e As UI.GridViewCellEventArgs) Handles uxBatchSetItemGrid.CommandCellClick, uxBatchSetGrid.CommandCellClick
        If e.Column.Name = "colRun" Then
            Dim zSetItemId As Integer = e.Row.Cells(0).Value
            Dim zSetItem As BatchSetItem = _BS.Find(Function(x) x.colFldId = e.Row.DataBoundItem.colFldSetId).BatchSetItems.Find(Function(x) x.colFldId = zSetItemId)
            zSetItem.Status = BatchSet.BatchStatus.Queued
            TblBatchProcessingSetItem.Save(zSetItem)

            Dim zUtilBatchProcess As New UtilBatchProcess()
            Dim zByte(0) As Byte
            Dim zTempPath As String = ""
            If zSetItem.Parent.BatchSetTypeGroup = BatchSet.BatchTypeGroup.Extract Then
                zTempPath = CreateTempXLSXFilePath()
                zSetItem.MetaObject = TblMetaGrid.LoadByPrimaryKey(zSetItem.colFldMetaObjectId)
                zByte = zUtilBatchProcess.DoExtract(zSetItem)
            Else
                zTempPath = CreateTempPDFFilePath()
                zSetItem.MetaObject = TblMetaReport.LoadByPrimaryKey(zSetItem.colFldMetaObjectId)
                zByte = zUtilBatchProcess.DoReport(zSetItem)
            End If
            IO.File.WriteAllBytes(zTempPath, zByte)
            Process.Start(zTempPath)
        End If

        If e.Column.Name = "colReset" Then
            Dim zSetId As Integer = e.Row.Cells(0).Value
            Dim zSet As BatchSet = BatchSet.Load(zSetId)
            zSet.BatchSetStatus = BatchSet.BatchStatus.Defined
            TblBatchProcessingSet.Save(zSet)
        End If

        If e.Column.Name = "colFile" Then
            Dim zSetId As Integer = e.Row.Cells(0).Value
            Dim zFileRow As rowTblBatchProcessingFile = TblBatchProcessingFile.LoadByIDX_IX_fldSetId(zSetId)(0)
            Dim zPath As String = ""
            If zFileRow.colFldExtension = ".pdf" Then
                zPath = CreateTempPDFFilePath()
            Else
                zPath = CreateTempXLSXFilePath()
            End If
            IO.File.WriteAllBytes(zPath, zFileRow.colFldData)
            Process.Start(zPath)
        End If

        If e.Column.Name = "colSendEmail" Then

            Dim zEmailAddress As String = InputBox("Enter Email Address:", "Email", "daniel.barasch@globalriskconsultants.com")
            If zEmailAddress.Length > 0 Then

                Dim zSubmitter As GRC.EmailManagement.Client.EmailSubmitter = Nothing

                If UtilSystemParms.InLiveMode Then
                    zSubmitter = New GRC.EmailManagement.Client.EmailSubmitter(GetEmailConnectionString, "GRC.Connect.BatchProcessor", EmailManagement.Client.MailMessage.EmailMsgEnvironment.Live)
                Else
                    zSubmitter = New GRC.EmailManagement.Client.EmailSubmitter(GetEmailConnectionString, "GRC.Connect.BatchProcessor", EmailManagement.Client.MailMessage.EmailMsgEnvironment.Test)
                End If

                Dim zSetId As Integer = e.Row.Cells(0).Value
                Dim zFileRow As rowTblBatchProcessingFile = TblBatchProcessingFile.LoadByIDX_IX_fldSetId(zSetId)(0)
                Dim zMemStream As New IO.MemoryStream(zFileRow.colFldData)
                Dim zAttachment As New System.Net.Mail.Attachment(zMemStream, zFileRow.colFldFileName & "_MS" & zFileRow.colFldExtension, zFileRow.colFldMime)

                Dim zMsgProps As New GRC.EmailManagement.Client.MailMessageProcessingProperties
                With zMsgProps
                    zMsgProps.To.Add(zEmailAddress)
                    zMsgProps.Subject = "BatchSet # " & e.Row.DataBoundItem.colFldId & " [" & zFileRow.colFldFileName & zFileRow.colFldExtension & "]"
                    zMsgProps.Body = "See attached file from batchset."
                    zMsgProps.From = New System.Net.Mail.MailAddress("grcconnect@globalriskconsultants.com", "GRC Connect")
                    zMsgProps.OrigProcess = "Batch Utility"
                End With

                Dim zMsg As System.Net.Mail.MailMessage = zMsgProps.ToMailMessage()
                zMsg.Attachments.Add(zAttachment)

                '   zMsg.Subject = zMsg.Subject & " - SENT DIRECTLY TO TUV"
                ' SendDirectlyToTUV(zMsg)

                zMsg.Subject = zMsg.Subject & " - SENT VIA SUBMITTER"
                zSubmitter.Submit(zMsg)


            Else
                MsgBox("No email specified. Email not sent.")
            End If


        End If



    End Sub

    Public Sub SendDirectlyToTUV(pMsg As System.Net.Mail.MailMessage)
        Dim zClient As New Net.Mail.SmtpClient("10.100.3.77", "25")
        zClient.Send(pMsg)
    End Sub

    Private Function GetEmailConnectionString()
        If UtilSystemParms.InLiveMode Then
            Return Configuration.ConfigurationManager.ConnectionStrings("EmailLive").ConnectionString
        Else
            Return Configuration.ConfigurationManager.ConnectionStrings("EmailTest").ConnectionString
        End If
    End Function

    Private Function CreateTempPDFFilePath() As String
        Dim zTempPath As String = IO.Path.GetTempFileName
        zTempPath = Replace(zTempPath, ".tmp", ".pdf")
        Return zTempPath
    End Function

    Private Function CreateTempXLSXFilePath() As String
        Dim zTempPath As String = IO.Path.GetTempFileName
        zTempPath = Replace(zTempPath, ".tmp", ".xlsx")
        Return zTempPath
    End Function

    Private Sub SetBatchSetGridSettings()

        Dim zCondFormatException As New UI.ConditionalFormattingObject("Exception", UI.ConditionTypes.Equal, "Exception", "", True)
        zCondFormatException.RowBackColor = System.Drawing.ColorTranslator.FromHtml("#FF3860")
        zCondFormatException.RowForeColor = System.Drawing.Color.White

        Dim zCondFormatProcessed As New UI.ConditionalFormattingObject("Processed", UI.ConditionTypes.Equal, "Processed", "", True)
        zCondFormatProcessed.RowBackColor = System.Drawing.ColorTranslator.FromHtml("#38FF74")


        With uxBatchSetGrid
            .EnableHotTracking = False
            .Font = New System.Drawing.Font("Arial", 9)
            .AutoGenerateColumns = False
            .Columns.Add(CreateColumn(New UI.GridViewCommandColumn(), "", "colFldId", 50, "Reset", "colReset"))
            .Columns.Add(CreateColumn(New UI.GridViewCommandColumn(), "", "colFldData", 50, "File", "colFile"))
            .Columns.Add(CreateColumn(New UI.GridViewCommandColumn(), "", "colFldData", 50, "Email File", "colSendEmail"))
            .Columns.Add(CreateColumn(New UI.GridViewTextBoxColumn(), "Id", "colFldId", 50))
            .Columns.Add(CreateColumn(New UI.GridViewTextBoxColumn(), "Login Name", "colFldCreatedByGsafeUserEmail", 300))
            .Columns.Add(CreateColumn(New UI.GridViewDateTimeColumn(), "Create Date", "colFldCreateDate", 150))
            .Columns.Add(CreateColumn(New UI.GridViewTextBoxColumn(), "File Prefix", "colFldFilePrefix", 50))
            .Columns.Add(CreateColumn(New UI.GridViewTextBoxColumn(), "Client", "colClientname", 250))
            .Columns.Add(CreateColumn(New UI.GridViewTextBoxColumn(), "Set Type", "colFldTypeName", 50))
            .Columns.Add(CreateColumn(New UI.GridViewTextBoxColumn(), "Status", "colFldStatus", 75))

            AddHandler .CellFormatting, AddressOf AddToolTip
            .Columns("colFldStatus").ConditionalFormattingObjectList.Add(zCondFormatException)
            .Columns("colFldStatus").ConditionalFormattingObjectList.Add(zCondFormatProcessed)

        End With

        '---------
        With uxBatchSetItemGrid
            .EnableHotTracking = False
            .Font = New System.Drawing.Font("Arial", 9)
            .AutoGenerateColumns = False
            .Columns.Clear()
            .ShowRowHeaderColumn = False
            With .Columns
                .Add(CreateColumn(New UI.GridViewCommandColumn(), "", "colFldId", 50, "Run", "colRun"))
                .Add(CreateColumn(New UI.GridViewTextBoxColumn(), "Name", "colFldName", 400))
                ' .Add(CreateColumn(New UI.GridViewTextBoxColumn(), "Source ID", "colFldSourceId", 50))
                .Add(CreateColumn(New UI.GridViewTextBoxColumn(), "Status", "colFldStatus", 75))
                .Item("colFldStatus").ConditionalFormattingObjectList.Add(zCondFormatException)
                .Item("colFldStatus").ConditionalFormattingObjectList.Add(zCondFormatProcessed)
                '  .Add(CreateColumn(New UI.GridViewTextBoxColumn(), "Exception", "colFldException", 150))
            End With
            AddHandler .CellFormatting, AddressOf AddToolTip
        End With


        '---------
        With uxBatchLogGrid
            .Font = New System.Drawing.Font("Arial", 9)
            .AutoGenerateColumns = False
            .Columns.Clear()
            .ShowRowHeaderColumn = False
            .AutoSizeColumnsMode = UI.GridViewAutoSizeColumnsMode.Fill
            With uxBatchLogGrid.Columns
                .Add(CreateColumn(New UI.GridViewTextBoxColumn(), "Log Message", "colFldMessage", 600))
                .Add(CreateColumn(New UI.GridViewTextBoxColumn(), "SetId", "colFldSetId", 1))
            End With
            AddHandler .CellFormatting, AddressOf AddToolTip
        End With

    End Sub

    Private Sub SetTimer()
        '  AddHandler Me.Timer1.Tick, AddressOf RefreshData
        Me.Timer1.Interval = 1500
        Me.Timer1.Start()
    End Sub

    Public Sub RefreshData()
        Try
            Dim zSetId As Integer = Me.uxBatchSetGrid.CurrentRow.Cells("colFldId").Value
            Dim zId As Integer = Me.uxBatchSetItemGrid.CurrentRow.Cells("colFldId").Value

            Dim zBatchSet As BatchSet = TblBatchProcessingSet.LoadByPrimaryKey(zSetId)
            uxBatchSetGrid.CurrentRow.Cells("colFldStatus").Value = zBatchSet.BatchSetStatus.ToString

            Dim zBatchItem As rowVwBatchProcessingSetItem = VwBatchProcessingSetItem.LoadData("SELECT * FROM fv.vwBatchProcessingSetItem WHERE fldId=" & zId)(0)
            Me.uxBatchSetItemGrid.CurrentRow.Cells("colFldStatus").Value = zBatchItem.colStatus
            '        Me.uxBatchSetItemGrid.CurrentRow.Cells("colFldException").Value = zBatchItem.

            If Me.uxBatchLogGrid.Rows.Count > 0 Then
                Dim zLastLogId As Integer = Me.uxBatchLogGrid.Rows.Last.Cells("colFldId").Value
                Dim zLogItems As List(Of rowTblBatchProcessingLog) = TblBatchProcessingLog.LoadData("SELECT * FROM tblBatchProcessingLog WHERE FldSetId=" & zSetId & " AND fldID >" & zLastLogId)
                For Each zLogItem As rowTblBatchProcessingLog In zLogItems
                    uxBatchLogGrid.Rows.Add({zLogItem.colFldId, zLogItem.colFldMessage})
                Next
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub AddToolTip(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.CellFormattingEventArgs) Handles uxBatchSetGrid.CellFormatting, uxBatchSetItemGrid.CellFormatting, uxBatchLogGrid.CellFormatting
        If TypeOf e.Row Is UI.GridViewDataRowInfo Then
            e.CellElement.ToolTipText = e.CellElement.Text
        End If
    End Sub

    Public Function CreateColumn(pColumn As UI.GridViewDataColumn, pHeaderText As String, pFieldName As String, pWidth As Integer, Optional pCommandButtonText As String = "", Optional pName As String = "") As UI.GridViewDataColumn
        pColumn.HeaderText = pHeaderText
        pColumn.FieldName = pFieldName
        pColumn.Name = pFieldName
        If pName.Length > 0 Then pColumn.Name = pName
        pColumn.Width = pWidth
        pColumn.StretchVertically = True
        pColumn.WrapText = False

        If TypeOf pColumn Is UI.GridViewCommandColumn And pCommandButtonText.Length > 0 Then
            DirectCast(pColumn, UI.GridViewCommandColumn).DefaultText = pCommandButtonText
            DirectCast(pColumn, UI.GridViewCommandColumn).UseDefaultText = True
        End If
        Return pColumn
    End Function

    Private Sub uxBatchLogGrid_RowFormatting(sender As Object, e As UI.RowFormattingEventArgs) Handles uxBatchLogGrid.RowFormatting, uxBatchSetGrid.RowFormatting, uxBatchSetItemGrid.RowFormatting, uxBatchLogGrid.RowFormatting
        e.RowElement.RowInfo.Height = 20
    End Sub

    Private Sub RadRadioButtonTodayBatches_Click(sender As Object, e As EventArgs) Handles RadRadioButtonTodayBatches.Click
        Me.uxBatchSetGrid.Columns("colFldCreateDate").FilterDescriptor = New Telerik.WinControls.Data.FilterDescriptor("colFldCreateDate", Data.FilterOperator.IsGreaterThan, Today)
    End Sub

    Private Sub RadRadioButtonShowAll_Click(sender As Object, e As EventArgs) Handles RadRadioButtonShowAll.Click
        Me.uxBatchSetGrid.Columns.ToList.ForEach(Sub(x) x.FilterDescriptor = Nothing)
    End Sub

    Private Sub RadRadioButtonLast10Exceptions_Click(sender As Object, e As EventArgs) Handles RadRadioButtonShowExceptions.Click
        Me.uxBatchSetGrid.Columns("colFldStatus").FilterDescriptor = New Telerik.WinControls.Data.FilterDescriptor("colFldStatus", Data.FilterOperator.IsEqualTo, "Exception")
    End Sub

    Private Sub RadMenuMetaUtilityForm_Click(sender As Object, e As EventArgs) Handles RadMenuMetaUtilityForm.Click
        Dim zMetaUtility As New MetaUtility
        zMetaUtility.ShowDialog()
    End Sub

    Private Sub CtxMenuStrip_Opening(sender As Object, e As EventArgs) Handles CtxMenuStrip.Opened
        Dim zBatchSet As BatchSet = Nothing ' _BS.Find(Function(x) x.colFldId = DirectCast(uxBatchSetGrid.CurrentRow.DataBoundItem, rowVwBatchProcessingSet).colId)
        Dim zBatchSetItem As BatchSetItem = zBatchSet.BatchSetItems.Find(Function(x) x.colFldId = DirectCast(uxBatchSetItemGrid.CurrentRow.DataBoundItem, rowVwBatchProcessingSetItem).colId)
        Dim zMetaSource As rowTblMetaSource = Nothing

        If zBatchSetItem.Parent.Type = BatchSet.BatchType.Report Then
            Dim zMetaReport As rowTblMetaReport = TblMetaReport.LoadByPrimaryKey(zBatchSetItem.colFldMetaObjectId)
            zMetaSource = TblMetaSource.LoadByPrimaryKey(zMetaReport.colFldSourceId)

            CtxMenuShowMetaGrid.Enabled = False
            CtxMenuShowMetaReport.Enabled = True
            CtxMenuShowMetaReport.Text = "View Report Meta [" & zBatchSetItem.colFldMetaObjectId & "]..."
            CtxMenuShowMetaReport.ToolTipText = "Report Name: " & zMetaReport.colFldName & vbNewLine & "Report Type:" & zMetaReport.colFldTypeName
            CtxMenuShowMetaReport.Tag = zMetaReport
            CtxMenuShowMetaSource.Text = "View Source Meta [" & zMetaReport.colFldSourceId & "]..."

        Else
            Dim zMetaGrid As rowTblMetaGrid = TblMetaGrid.LoadByPrimaryKey(zBatchSetItem.colFldMetaObjectId)
            zMetaSource = TblMetaSource.LoadByPrimaryKey(zMetaGrid.colFldSourceId)

            CtxMenuShowMetaReport.Enabled = False
            CtxMenuShowMetaGrid.Enabled = True
            CtxMenuShowMetaGrid.Text = "View Grid Meta [" & zBatchSetItem.colFldMetaObjectId & "]..."
            CtxMenuShowMetaReport.ToolTipText = "Report Name: " & zMetaGrid.colFldGridName
            CtxMenuShowMetaGrid.Tag = zMetaGrid
            CtxMenuShowMetaSource.Text = "View Source Meta [" & zMetaGrid.colFldSourceId & "]..."

        End If

        CtxMenuShowMetaReport.ToolTipText = "Source Name: " & zMetaSource.colFldSchemaName & "." & zMetaSource.colFldObjectName
        CtxMenuShowMetaSource.Tag = zMetaSource

        'AddHandler CtxMenuShowMetaGrid.Click, AddressOf ContextMenuClick
        'AddHandler CtxMenuShowMetaReport.Click, AddressOf ContextMenuClick
        'AddHandler CtxMenuShowMetaSource.Click, AddressOf ContextMenuClick

    End Sub

    Private Sub ContextMenuClick(pSender As Windows.Forms.ToolStripMenuItem, pArg As EventArgs) Handles CtxMenuShowMetaGrid.Click, CtxMenuShowMetaReport.Click, CtxMenuShowMetaSource.Click
        Dim zMetaUtility As New MetaUtility(pSender.Tag)
        zMetaUtility.Show()
    End Sub

    Private Sub RadMenuItemNavLinkUtility_Click(sender As Object, e As EventArgs) Handles RadMenuItemNavLinkUtility.Click
        Dim zNavLinkUtil As New NavLinkUtility
        zNavLinkUtil.ShowDialog()
    End Sub

    Private Sub uxBatchSetItemGrid_SelectionChanged(sender As Object, e As EventArgs) Handles uxBatchSetItemGrid.SelectionChanged
        Dim zSetItem As rowVwBatchProcessingSetItem = uxBatchSetItemGrid.CurrentRow.DataBoundItem
        If Not IsNothing(zSetItem) Then
            Me.uxBatchLogGrid.Columns("colFldSetId").FilterDescriptor = New Telerik.WinControls.Data.FilterDescriptor("colFldSetId", Data.FilterOperator.IsEqualTo, zSetItem.colId)
        End If
    End Sub
End Class

