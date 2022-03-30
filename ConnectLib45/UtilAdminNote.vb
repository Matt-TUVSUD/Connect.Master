Imports GRC.Connect
Imports GRC.Connect.ConnectLib45.razor

Public Class UtilAdminNote

    Private _Extract As Byte()
    Private _AdminXLSheet As List(Of rowVwAdminViewXLSheet) = Nothing
    Private _AdminXLColumns As List(Of rowTblAdminViewXLColumn) = Nothing
    Private _AdminXLLoaded As Boolean = False

    Public Event ExtractCreated(e As ExtractCreatedEventArgs)
    Public Event OnException(e As ExceptionEventArgs)

    Public Sub New()
        If razor.UtilSQLServer.ConnectionString = "" Then
            razor.UtilSQLServer.SetConnection(UtilDB.ReadConnectionString(UtilDB.Databases.Connect))
        End If
    End Sub

    ''' <summary>
    ''' Sends all missing views with no dba email filter to specified to address.
    ''' </summary>
    ''' <param name="pToAddress"></param>
    ''' <param name="pCreateBy"></param>
    ''' <remarks></remarks>
    Public Sub QueueEmail(pToAddress As String, pCreateBy As String)
        Dim zViewIDs As String = Join(VwAdminViewXLSheet.LoadData().OrderBy(Function(x) x.colFldSheetPosition).Select(Function(x) x.colFldID.ToString).ToArray, ",")
        QueueEmail(pToAddress, pCreateBy, "%", zViewIDs)
    End Sub

    ''' <summary>
    ''' Sends all missing views with DBa email filter to specified to address.
    ''' </summary>
    ''' <param name="pToAddress"></param>
    ''' <param name="pCreateBy"></param>
    ''' <remarks></remarks>
    Public Sub QueueEmail(pToAddress As String, pCreateBy As String, pDBAFilter As String)
        Dim zViewIDs As String = Join(VwAdminViewXLSheet.LoadData().OrderBy(Function(x) x.colFldSheetPosition).Select(Function(x) x.colFldID.ToString).ToArray, ",")
        QueueEmail(pToAddress, pCreateBy, pDBAFilter, zViewIDs)
    End Sub

    ''' <summary>
    ''' Sends selected missing views with filtered dba email data
    ''' </summary>
    ''' <param name="pToAddress"></param>
    ''' <param name="pCreateBy"></param>
    ''' <param name="pDBAFilter"></param>
    ''' <param name="pViewIDs"></param>
    ''' <remarks></remarks>
    Public Sub QueueEmail(pToAddress As String, pCreateBy As String, pDBAFilter As String, ParamArray pViewIDs() As String)
        Dim zQ As New rowTblAdminQueue()
        zQ.colFldCreateBy = pCreateBy
        zQ.colFldCreateDate = Now
        zQ.colFldTo = pToAddress
        zQ.colFldDBAFilter = pDBAFilter
        zQ.colFldViewIDs = Join(pViewIDs, ",")
        zQ.colFldIsProcessed = False
        zQ.colFldStatus = "Waiting"
        TblAdminQueue.Save(zQ)
    End Sub

    Public Sub ProcessQueue()
        Dim zList As List(Of rowTblAdminQueue) = TblAdminQueue.LoadData().FindAll(Function(x) x.colFldStatus = "Waiting")
        For Each zItem As rowTblAdminQueue In zList
            Try
                zItem.colFldStatus = "Processing"
                zItem.colFldProcessedDate = Now
                TblAdminQueue.Save(zItem)

                BuildExtract(zItem)
                zItem.colFldStatus = "Processed"
                zItem.colFldProcessedDate = Now
                zItem.colFldIsProcessed = True

                TblAdminQueue.Save(zItem)
                OnExtractCreatedDelegate(zItem)

            Catch ex As Exception
                zItem.colFldException = ex.Message
                zItem.colFldProcessedDate = Now
                zItem.colFldStatus = "Exception"
                TblAdminQueue.Save(zItem)

                ex.Data.Add("Method", "ProcessQueue")
                ex.Data.Add("QueueID", zItem.colFldID)
                ex.Data.Add("QueueCreateBy", zItem.colFldCreateBy)
                ex.Data.Add("QueueCreateDateTime", zItem.colFldCreateDate)

                OnExceptionDelegate(ex)
            End Try
        Next
    End Sub

    Public ReadOnly Property Extract As Byte()
        Get
            Return _Extract
        End Get
    End Property

    Public Function BuildExtract(pQueueID As Integer) As Byte()
        Dim zRow As rowTblAdminQueue = TblAdminQueue.LoadByPrimaryKey(pQueueID)
        Return BuildExtract(zRow)
    End Function

    Public Function BuildExtract(pItem As rowTblAdminQueue) As Byte()

        If Not _AdminXLLoaded Then
            _AdminXLSheet = VwAdminViewXLSheet.LoadData().Where(Function(x) x.colFldInclude = True).OrderBy(Function(x) x.colFldSheetPosition).ToList()
            _AdminXLColumns = TblAdminViewXLColumn.LoadData().OrderBy(Function(x) x.colFldColumnPosition).ToList()
            _AdminXLLoaded = True
        End If

        Dim zList As New List(Of GRC.Excel.Extractions.XLExtractSheet)
        Dim zXL As New GRC.Excel.Extractions.XLExtractor()

        Dim zViewIDsToExtract As List(Of String) = pItem.colFldViewIDs.Split(",").ToList()
        Dim zAdminXLColumns As List(Of rowTblAdminViewXLColumn) = Nothing

        For Each zViewID As String In zViewIDsToExtract
            Dim zAdminXLSheet As rowVwAdminViewXLSheet = _AdminXLSheet.Find(Function(x) x.colFldID = zViewID)

            'GET THE COLUMNS SPECIFIED FOR THIS VIEW
            zAdminXLColumns = _AdminXLColumns.FindAll(Function(x) x.colFldAdminXLSheetID = zViewID)

            'IF THERE ARE NO SPECIFIC COLUMNS SPECIFIED FOR THIS VIEW, THE USE DEFAULT COLUMN ORDER
            If zAdminXLColumns.Count = 0 Then
                zAdminXLColumns = _AdminXLColumns.FindAll(Function(x) x.colFldAdminXLSheetID = 0)
            End If


            If Not IsNothing(zAdminXLSheet) Then
                Dim zData As DataTable = GetSheetData(zAdminXLSheet, pItem)
                Dim zColumns As New List(Of GRC.Excel.Extractions.XLExtractColumn)

                zAdminXLColumns.ForEach(Sub(x) zColumns.Add(New GRC.Excel.Extractions.XLExtractColumn(x.colFldDataMember, x.colFldHeaderText, "", "", "", x.colFdlHyperLinkMember)))

                Dim zXLS As New GRC.Excel.Extractions.XLExtractDataTableSource(zData)
                Dim zXLSt As New GRC.Excel.Extractions.XLExtractSheet(zXLS, zAdminXLSheet.colFldTabName, zColumns)
                zXL.SheetData.Add(zXLSt)
            End If

        Next

        zXL.Settings.ShowAutoFilter = True
        _Extract = zXL.Run()

        Return _Extract

    End Function

    Private Function GetSheetData(pAdminXLSheet As rowVwAdminViewXLSheet, pQueueItem As rowTblAdminQueue) As DataTable
        Dim zCon As SqlClient.SqlConnection = UtilSQLServer.GetConnectionObject()
        Dim zCmd As New SqlClient.SqlCommand(pAdminXLSheet.colFldSQL, zCon)
        zCmd.Parameters.AddWithValue("@EmailFilter", IIf(IsNothing(pQueueItem.colFldDBAFilter), "%", pQueueItem.colFldDBAFilter))

        Dim zDT As New DataTable
        If zCon.State = ConnectionState.Closed Then zCon.Open()
        Using zCon
            Using zCmd
                zDT.Load(zCmd.ExecuteReader)
            End Using
        End Using
        Return zDT
    End Function

    Public Function Find(pFileNo As String) As List(Of rowVwAdminNoteTextBox)
        Dim zQ As New queryVwAdminNoteTextBox
        zQ.SelectAll()

        If pFileNo = "" Then
            zQ.Where.Add(zQ.colFileNo.IsNull)
        Else
            zQ.Where.Add(zQ.colFileNo.Equals(pFileNo))
        End If

        Dim zList As List(Of rowVwAdminNoteTextBox) = VwAdminNoteTextBox.LoadData(zQ.QueryText)
        zList.ForEach(Sub(x) x.colFileNo = IIf(IsNothing(x.colFileNo), pFileNo, x.colFileNo))

        Return zList

    End Function

    Public Sub Save(pList As List(Of rowVwAdminNoteTextBox))
        For Each zItem As rowVwAdminNoteTextBox In pList
            Dim zRow As New rowTblAdminNote

            If IsNumeric(zItem.colFldNoteID) Then
                zRow = TblAdminNote.LoadByPrimaryKey(zItem.colFldNoteID)
                zRow.colFldUpdateBy = zItem.colFldUpdateBy
                zRow.colFldUpdateDateTime = zItem.colFldUpdateDateTime
            Else
                zRow.colFldCreateBy = zItem.colFldCreateBy
                zRow.colFldCreateDateTime = zItem.colFldUpdateDateTime
                zRow.colFldUpdateBy = zItem.colFldUpdateBy
                zRow.colFldUpdateDateTime = zItem.colFldUpdateDateTime
                zRow.colFldFileNo = zItem.colFileNo
                zRow.colFldInspectionID = zItem.colInspectionID
                zRow.colFldPracticeGroupCd = zItem.colFldPracticeGroupCd
            End If

            With zRow
                .colFldNote = zItem.colFldNote
                .colFldExcludeInXL = zItem.colFldExcludeInXL
                .colFldInspectionID = zItem.colInspectionID
                .colFldPracticeGroupCd = zItem.colFldPracticeGroupCd
            End With

            TblAdminNote.Save(zRow)
        Next
    End Sub

    Public Sub Delete(pList As List(Of rowVwAdminNoteTextBox))
        For Each zItem As rowVwAdminNoteTextBox In pList
            Dim zRow As New rowTblAdminNote

            If IsNumeric(zItem.colFldNoteID) Then
                zRow = TblAdminNote.LoadByPrimaryKey(zItem.colFldNoteID)
                TblAdminNote.Delete(zRow)
            End If

        Next
    End Sub

    Public Function GetSetting(pSetting As AdminSetting) As String
        Dim zSetting As rowTblAdminSetting = TblAdminSetting.LoadByPrimaryKey(pSetting.ToString)
        Return zSetting.colFldValue
    End Function

    Public Enum AdminSetting
        PageTitle = 1
        SendMissingAllEmailAddress = 2
    End Enum

    Public Class ExtractCreatedEventArgs
        Inherits EventArgs

        Private _Extract As Byte()
        Private _QueueItem As rowTblAdminQueue

        Public ReadOnly Property Extract As Byte()
            Get
                Return _Extract
            End Get
        End Property

        Public ReadOnly Property QueueItem As rowTblAdminQueue
            Get
                Return _QueueItem
            End Get
        End Property

        Friend Sub New(pExtract As Byte(), pQueueItem As rowTblAdminQueue)
            _Extract = pExtract
            _QueueItem = pQueueItem
        End Sub

    End Class

    Private Sub OnExtractCreatedDelegate(pItem As rowTblAdminQueue)
        Dim zEventArgs As New ExtractCreatedEventArgs(_Extract, pItem)
        RaiseEvent ExtractCreated(zEventArgs)
    End Sub

    Public Class ExceptionEventArgs
        Inherits EventArgs

        Public Property Exception As Exception
        Public Sub New(pException As Exception)
            Exception = pException
        End Sub

    End Class

    Private Sub OnExceptionDelegate(pException As Exception)
        Dim zExceptionArgs As New ExceptionEventArgs(pException)
        RaiseEvent OnException(zExceptionArgs)
    End Sub
End Class
