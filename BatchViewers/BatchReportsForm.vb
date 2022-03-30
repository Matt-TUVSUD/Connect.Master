Imports Telerik.WinControls.UI
Imports GRC.Connect.Libraries.DataLib.razor

Public Class BatchReportsForm
    Implements IUtilityForm

    Private _Filters As New Dictionary(Of String, Telerik.WinControls.Data.FilterDescriptor)

#Region "Events"

    Private Sub BatchReportsForm_FormClosing(sender As Object, e As Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If BackgroundWorker1.IsBusy Then
            BackgroundWorker1.CancelAsync()
        End If
    End Sub

    Private Sub Batch_vb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadBatchSets()
            BackgroundWorker1.RunWorkerAsync()
        Catch ex As Exception
            MsgBox(ex.GetBaseException.Message)
        End Try

    End Sub


    Private Sub uxFilePrefix_TextChanged(sender As Object, e As EventArgs) Handles uxFilePrefix.TextChanged, uxBatchId.TextChanged
        ApplyFilter(sender)
    End Sub

    Private Sub uxFilterCheckboxes_CheckStateChanged(sender As Object, e As EventArgs) Handles uxMyBatchSetsOnly.CheckStateChanged, uxTodaysBatchsets.CheckStateChanged, uxExceptionsOnly.CheckStateChanged
        ApplyFilter(sender)
    End Sub

    Private Sub uxBatchSetGrid_SelectionChanged(sender As Object, e As EventArgs) Handles uxBatchSetGrid.SelectionChanged
        If Not IsNothing(uxBatchSetGrid.CurrentRow) Then
            Dim zObj As rowVwBatchProcessingSet = uxBatchSetGrid.CurrentRow.DataBoundItem
            If Not IsNothing(zObj) Then
                LoadBatchSetViewItems(zObj.colFldId)
            End If
        End If

    End Sub

    Private Sub uxSearchGrid_CellValueChanged(sender As Object, e As CurrentRowChangingEventArgs)
        If Not IsNothing(e.CurrentRow) Then
            '    ApplyFilter(e.CurrentRow)
        End If
    End Sub

#End Region

    Private Sub LoadBatchSets()
        Dim zList As List(Of rowVwBatchProcessingSet) = VwBatchProcessingSet.LoadData
        zList = zList.OrderByDescending(Function(x) x.colFldId).ToList

        Dim zList100 As List(Of rowVwBatchProcessingSet) = zList.Take(100).ToList
        uxBatchSetGrid.DataSource = zList100
    End Sub

    Private Sub ApplyFilter(pSender As Telerik.WinControls.RadControl)

        Dim zQry As New queryVwBatchProcessingSet
        zQry.SelectAll()

        If uxFilePrefix.Text <> "" Then zQry.Where.Add(zQry.colFldFilePrefix.Equals(uxFilePrefix.Text))
        If uxBatchId.Text <> "" Then zQry.Where.Add(zQry.colFldId.Equals(CInt(uxBatchId.Text)))
        If uxExceptionsOnly.Checked Then zQry.Where.Add(zQry.colFldStatus.Equals("Exception"))
        If uxMyBatchSetsOnly.Checked Then zQry.Where.Add(zQry.colFldIsMyBatchReport.Equals(True))
        If uxTodaysBatchsets.Checked Then zQry.Where.Add(zQry.colFldCreateDate.GreaterThanEqual(New Date(Now.Year, Now.Month, Now.Day)))
        If uxLast50Batchsets.Checked Then
            Dim z As New queryVwBatchProcessingSet
            z.SelectAll()
            z.Top = 1
            z.OrderBy(z.colFldId.Descending)

            Dim z1 As List(Of rowVwBatchProcessingSet) = VwBatchProcessingSet.LoadData(z.QueryText)
            zQry.Where.Add(zQry.colFldId.GreaterThan(z1(0).colFldId - 50))
        End If

        uxBatchSetGrid.DataSource = VwBatchProcessingSet.LoadData(zQry.QueryText)

    End Sub

    Private Sub LoadBatchSetViewItems(pBatchSetId As Integer)
        uxBatchSetItemGrid.Rows.Clear()
        uxBatchSetItemGrid.DataSource = VwBatchProcessingSetItem.LoadData("SELECT * FROM [fv].[vwBatchProcessingSetItem] WHERE FldSetId=" & pBatchSetId)
    End Sub

    Private Sub uxLast50Batchsets_CheckStateChanged(sender As Object, e As EventArgs) Handles uxLast50Batchsets.CheckStateChanged
        ApplyFilter(sender)
    End Sub

    Delegate Sub UpdateBatchSetDataBoundItemDelegate(pRow As rowVwBatchProcessingSet)

    Sub UpdateBatchSetDataBoundItem(pRow As rowVwBatchProcessingSet)
        uxBatchSetGrid.CurrentRow.DataBoundItem.colFldStatus = pRow.colFldStatus
        uxBatchSetGrid.CurrentRow.InvalidateRow()
    End Sub

    Delegate Sub UpdateBatchSetItemsDataBoundItemDelegate(pList As List(Of rowVwBatchProcessingSetItem))

    Sub UpdateBatchSetItemsDataBoundItem(pList As List(Of rowVwBatchProcessingSetItem))
        For Each zRow As GridViewRowInfo In uxBatchSetItemGrid.Rows
            Dim zDBItem As rowVwBatchProcessingSetItem = pList.Find(Function(x) x.colFldId = zRow.DataBoundItem.colFldId)
            If Not IsNothing(zDBItem) Then
                zRow.DataBoundItem.colFldStatus = zDBItem.colFldStatus
                zRow.DataBoundItem.colFldMessage = zDBItem.colFldMessage
            End If
            zRow.InvalidateRow()
        Next
    End Sub

    Delegate Sub InsertNewBatchSetsDelegate(pList As List(Of rowVwBatchProcessingSet))

    Sub InsertNewBatchSets(pList As List(Of rowVwBatchProcessingSet))

        'uxBatchSetGrid.DataSource = Nothing
        'uxBatchSetGrid.DataSource = pList
        'uxBatchSetGrid.Refresh()
        'uxBatchSetGrid.CurrentView.UpdateView()
    End Sub


    Private Sub BackgroundWorker1_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Do Until BackgroundWorker1.CancellationPending = True
            If Not IsNothing(uxBatchSetGrid.CurrentRow) Then
                Dim zRowSet As rowVwBatchProcessingSet = uxBatchSetGrid.CurrentRow.DataBoundItem
                If zRowSet.colFldStatus = "Defined" Or zRowSet.colFldStatus = "Processing" Then
                    Dim zBatchSet As rowVwBatchProcessingSet = VwBatchProcessingSet.LoadData("SELECT * FROM [fv].[vwBatchProcessingSet] WHERE FldId=" & zRowSet.colFldId)(0)
                    Dim zItemsList As List(Of rowVwBatchProcessingSetItem) = VwBatchProcessingSetItem.LoadData("SELECT * FROM [fv].[vwBatchProcessingSetItem] WHERE FldSetId=" & zRowSet.colFldId)

                    If uxBatchSetGrid.InvokeRequired Then
                        Dim z As UpdateBatchSetDataBoundItemDelegate = New UpdateBatchSetDataBoundItemDelegate(AddressOf UpdateBatchSetDataBoundItem)
                        uxBatchSetGrid.Invoke(z, zBatchSet)
                    End If

                    If uxBatchSetItemGrid.InvokeRequired Then
                        Dim z As UpdateBatchSetItemsDataBoundItemDelegate = New UpdateBatchSetItemsDataBoundItemDelegate(AddressOf UpdateBatchSetItemsDataBoundItem)
                        uxBatchSetItemGrid.Invoke(z, zItemsList)
                    End If
                End If
            End If
            Threading.Thread.Sleep(2000)

            Dim zNewBatchSets As List(Of rowVwBatchProcessingSet) = VwBatchProcessingSet.LoadData("SELECT * FROM [fv].[vwBatchProcessingSet] WHERE FldId=(Select MIN(fldid) from [fv].[vwBatchProcessingSet])")
            If zNewBatchSets.Count > 0 Then
                Dim zInsertBatchDel As New InsertNewBatchSetsDelegate(AddressOf InsertNewBatchSets)
                uxBatchSetGrid.Invoke(zInsertBatchDel, zNewBatchSets)
            End If

        Loop
    End Sub

    Private Sub BatchReportsForm_Shown(sender As Object, e As EventArgs) Handles Me.Paint
        uxBatchSetGrid.Columns.ToList.ForEach(Sub(x) x.BestFit())
        uxBatchSetItemGrid.Columns.ToList.ForEach(Sub(x) x.BestFit())
    End Sub

    Public ReadOnly Property ShowOnMainMenu As Boolean Implements IUtilityForm.ShowOnMainMenu
        Get
            Return True
        End Get
    End Property
End Class

Public MustInherit Class BatchGrid
    Inherits RadGridView
    Private _GridButtonsAdded As Boolean = False

    Public Sub New()
    End Sub

    Protected Overrides Sub OnDataBindingComplete(sender As Object, e As GridViewBindingCompleteEventArgs)
        MyBase.OnDataBindingComplete(sender, e)

        Me.MaximumSize = New Drawing.Size(4000, 1200)
        Me.Font = New Drawing.Font("Calibri", 9)
        Me.EnableFiltering = True
        Me.ShowFilteringRow = False
        Me.AllowAddNewRow = False
        Me.ShowGroupPanel = False
        Me.ShowRowHeaderColumn = True
        Me.Anchor = Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right Or Windows.Forms.AnchorStyles.Top

        Me.Columns.ToList.ForEach(Sub(x) SetHeader(x))
        Me.Columns.ToList.ForEach(Sub(x) x.AutoSizeMode = Telerik.WinControls.UI.BestFitColumnMode.AllCells)
        Me.Columns.ToList.ForEach(Sub(x) x.ReadOnly = True)
        Me.Columns.ToList.ForEach(Sub(x) x.AllowFiltering = True)
        Me.Rows.ToList.ForEach(Sub(x) x.Height = 20)

        AddButtons()

    End Sub

    MustOverride Sub SetHeader(pColumn As GridViewColumn)

    Protected Enum Commands
        RunReport
        ViewReport
        ResetBatch
    End Enum

    Private Sub AddButtons()
        If Not _GridButtonsAdded Then
            If TypeOf Me Is BatchSetGrid Then
                Dim zButton As New Telerik.WinControls.UI.GridViewCommandColumn(rowVwBatchProcessingSet.FieldIndex.colFldId.ToString)
                zButton.Width = 50
                zButton.DefaultText = "View"
                zButton.UseDefaultText = True
                zButton.Tag = Commands.ViewReport
                zButton.HeaderText = ""
                Me.Columns.Insert(0, zButton)

                zButton = New Telerik.WinControls.UI.GridViewCommandColumn(rowVwBatchProcessingSetItem.FieldIndex.colFldId.ToString)
                zButton.Width = 50
                zButton.DefaultText = "Reset"
                zButton.UseDefaultText = True
                zButton.HeaderText = ""
                zButton.Tag = Commands.ResetBatch
                Me.Columns.Insert(1, zButton)
            End If

            If TypeOf Me Is BatchSetItemGrid Then
                Dim zButton As New Telerik.WinControls.UI.GridViewCommandColumn(rowVwBatchProcessingSetItem.FieldIndex.colFldId.ToString)
                zButton.Width = 50
                zButton.DefaultText = "Run"
                zButton.UseDefaultText = True
                zButton.HeaderText = ""
                zButton.Tag = Commands.RunReport
                Me.Columns.Insert(0, zButton)
            End If

            _GridButtonsAdded = True

        End If

    End Sub

End Class

Public Class BatchSetGrid
    Inherits BatchGrid

    Private Sub BatchMgrGrid_DataBindingComplete(sender As RadGridView, e As GridViewBindingCompleteEventArgs) Handles Me.DataBindingComplete

        'CONDITIONAL FORMATTING
        Dim zProcessedStatus As New ConditionalFormattingObject(rowVwBatchProcessingSet.FieldIndex.colFldStatus.ToString, ConditionTypes.Equal, "Processed", "", True)
        zProcessedStatus.CellBackColor = System.Drawing.ColorTranslator.FromHtml("#38FF74")

        Dim zExceptionStatus As New ConditionalFormattingObject(rowVwBatchProcessingSet.FieldIndex.colFldStatus.ToString, ConditionTypes.Equal, "Exception", "", True)
        zExceptionStatus.CellBackColor = System.Drawing.ColorTranslator.FromHtml("#FF3860")

        Dim zProcessingStatus As New ConditionalFormattingObject(rowVwBatchProcessingSet.FieldIndex.colFldStatus.ToString, ConditionTypes.Equal, "Processing", "", True)
        zProcessingStatus.CellBackColor = Drawing.Color.Yellow

        Me.Columns.ToList.Find(Function(x) x.FieldName = rowVwBatchProcessingSet.FieldIndex.colFldStatus.ToString).ConditionalFormattingObjectList.Add(zProcessedStatus)
        Me.Columns.ToList.Find(Function(x) x.FieldName = rowVwBatchProcessingSet.FieldIndex.colFldStatus.ToString).ConditionalFormattingObjectList.Add(zProcessingStatus)
        Me.Columns.ToList.Find(Function(x) x.FieldName = rowVwBatchProcessingSet.FieldIndex.colFldStatus.ToString).ConditionalFormattingObjectList.Add(zExceptionStatus)

    End Sub

    Public Overrides Sub SetHeader(pColumn As GridViewColumn)

        Dim pFieldname As String = pColumn.FieldName
        Dim zHeaderTexts As New Dictionary(Of String, String)(StringComparison.OrdinalIgnoreCase)
        With zHeaderTexts
            .Add(rowVwBatchProcessingSet.FieldIndex.colFldCreateDate.ToString, "Created")
            .Add(rowVwBatchProcessingSet.FieldIndex.colFldCreatedByGsafeUserEmail.ToString, "User")
            .Add(rowVwBatchProcessingSet.FieldIndex.colFldFilePrefix.ToString, "Fileprefix")
            .Add(rowVwBatchProcessingSet.FieldIndex.colFldGroupName.ToString, "Type")
            .Add(rowVwBatchProcessingSet.FieldIndex.colFldId.ToString, "Id")
            .Add(rowVwBatchProcessingSet.FieldIndex.colFldIsMyBatchReport.ToString, "IsMyBatch")
            .Add(rowVwBatchProcessingSet.FieldIndex.colFldStatus.ToString, "Status")
            .Add(rowVwBatchProcessingSetItem.FieldIndex.colFldMessage.ToString, "Message")
            .Add(rowVwBatchProcessingSetItem.FieldIndex.colFldName.ToString, "Name")
            .Add(rowVwBatchProcessingSetItem.FieldIndex.colFldSetId.ToString, "SetId")
        End With

        Dim zHeader As String = ""
        zHeaderTexts.TryGetValue(pFieldname, zHeader)
        If zHeader = "" Then pColumn.IsVisible = False
        pColumn.HeaderText = zHeader

    End Sub

    Private Sub uxBatchSetGrid_CommandCellClick(sender As Object, e As GridViewCellEventArgs) Handles Me.CommandCellClick

        If e.Column.Tag = Commands.ResetBatch Then  'RESET Button
            Reset(e.Row)
        End If

    End Sub

    Private Sub View()

    End Sub

    Private Sub Reset(pRow As GridViewRowInfo)

        Dim zForm As BatchReportsForm = FindForm()
        Dim zRowSet As rowVwBatchProcessingSet = pRow.DataBoundItem
        zRowSet.colFldStatus = "Defined"
        pRow.InvalidateRow()

        For Each zRow As GridViewRowInfo In zForm.uxBatchSetItemGrid.Rows
            Dim zRowItem As rowVwBatchProcessingSetItem = zRow.DataBoundItem
            zRowItem.colFldStatus = "Defined"

            Dim zItem As rowTblBatchProcessingSetItem = TblBatchProcessingSetItem.LoadByPrimaryKey(zRowItem.colFldId)
            zItem.colFldStatusId = 2
            TblBatchProcessingSetItem.Save(zItem)

            zRow.InvalidateRow()
        Next

        Dim zSet As rowTblBatchProcessingSet = TblBatchProcessingSet.LoadByPrimaryKey(zRowSet.colFldId)
        zSet.colFldStatusId = 2
        TblBatchProcessingSet.Save(zSet)

    End Sub


End Class

Public Class BatchSetItemGrid
    Inherits BatchGrid


    Private Sub BatchMgrGrid_DataBindingComplete(sender As RadGridView, e As GridViewBindingCompleteEventArgs) Handles Me.DataBindingComplete

        'CONDITIONAL FORMATTING
        Dim zProcessedStatus As New ConditionalFormattingObject(rowVwBatchProcessingSet.FieldIndex.colFldStatus.ToString, ConditionTypes.Equal, "Processed", "", True)
        zProcessedStatus.CellBackColor = System.Drawing.ColorTranslator.FromHtml("#38FF74")

        Dim zExceptionStatus As New ConditionalFormattingObject(rowVwBatchProcessingSet.FieldIndex.colFldStatus.ToString, ConditionTypes.Equal, "Exception", "", True)
        zExceptionStatus.CellBackColor = System.Drawing.ColorTranslator.FromHtml("#FF3860")

        Dim zProcessingStatus As New ConditionalFormattingObject(rowVwBatchProcessingSet.FieldIndex.colFldStatus.ToString, ConditionTypes.Equal, "Processing", "", True)
        zProcessingStatus.CellBackColor = Drawing.Color.Yellow

        Me.Columns.ToList.Find(Function(x) x.FieldName = rowVwBatchProcessingSet.FieldIndex.colFldStatus.ToString).ConditionalFormattingObjectList.Add(zProcessedStatus)
        Me.Columns.ToList.Find(Function(x) x.FieldName = rowVwBatchProcessingSet.FieldIndex.colFldStatus.ToString).ConditionalFormattingObjectList.Add(zProcessingStatus)
        Me.Columns.ToList.Find(Function(x) x.FieldName = rowVwBatchProcessingSet.FieldIndex.colFldStatus.ToString).ConditionalFormattingObjectList.Add(zExceptionStatus)

    End Sub

    Public Overrides Sub SetHeader(pColumn As GridViewColumn)

        Dim pFieldname As String = pColumn.FieldName
        Dim zHeaderTexts As New Dictionary(Of String, String)(StringComparison.OrdinalIgnoreCase)
        With zHeaderTexts
            .Add(rowVwBatchProcessingSetItem.FieldIndex.colFldGroupName.ToString, "Type")
            .Add(rowVwBatchProcessingSetItem.FieldIndex.colFldId.ToString, "Id")
            .Add(rowVwBatchProcessingSetItem.FieldIndex.colFldStatus.ToString, "Status")
            .Add(rowVwBatchProcessingSetItem.FieldIndex.colFldMessage.ToString, "Message")
            .Add(rowVwBatchProcessingSetItem.FieldIndex.colFldName.ToString, "Name")
            .Add(rowVwBatchProcessingSetItem.FieldIndex.colFldSetId.ToString, "SetId")
        End With

        Dim zHeader As String = ""
        zHeaderTexts.TryGetValue(pFieldname, zHeader)
        If zHeader = "" Then pColumn.IsVisible = False
        pColumn.HeaderText = zHeader

    End Sub

    Private Sub uxBatchSetItemGrid_CommandCellClick(sender As Object, e As GridViewCellEventArgs) Handles Me.CommandCellClick
        If e.Column.Tag = Commands.RunReport Then
            RunReport(e.Row)
        End If
    End Sub

    Private Sub RunReport(pRow As GridViewRowInfo)

        Dim zRowObject As rowVwBatchProcessingSetItem = pRow.DataBoundItem
        Dim zBatchSet As BatchSet = BatchSet.Load(zRowObject.colFldSetId)
        Dim zBatchSetItem As BatchSetItem = Nothing

        Dim zUtilBatchProcess As New UtilBatchProcess()
        If zRowObject.colFldId > 0 Then
            zBatchSetItem = zBatchSet.BatchSetItems.ToList.Find(Function(x) x.colFldId = zRowObject.colFldId)

            Dim zByte() As Byte
            Dim zPath As String = IO.Path.GetTempFileName
            If zBatchSet.BatchSetTypeGroup = BatchSet.BatchTypeGroup.Extract Then
                zByte = zUtilBatchProcess.DoExtract(zBatchSetItem)
                zPath = Replace(zPath, ".tmp", ".csv")
            Else
                zByte = zUtilBatchProcess.DoReport(zBatchSetItem)
                zPath = Replace(zPath, ".tmp", ".pdf")
            End If

            IO.File.WriteAllBytes(zPath, zByte)
            Process.Start(zPath)

        End If

    End Sub

End Class
