
Imports GRC.Connect.Libraries.DataLib.razor

''' <summary>
''' The purpose of this class is to process a report or extract and store the file.
''' </summary>
''' <remarks></remarks>
Public Class UtilBatchProcess

    Friend Function Process(pSetId As Integer) As UtilBatchProcessResult
        Dim zSet As BatchSet = BatchSet.Load(pSetId)
        Return Process(zSet)
    End Function

    Friend Function Process(pSet As BatchSet) As UtilBatchProcessResult

        Try
            Dim zResult As UtilBatchProcessResult = ProcessSet(pSet)
            Return zResult

        Catch ex As UtilBatchProcessSetItemException

            ex.SetItem.Status = BatchSet.BatchStatus.Exception
            ex.SetItem.colFldException = ex.InnerException.GetBaseException.Message
            TblBatchProcessingSetItem.Save(ex.SetItem)

            pSet.BatchSetStatus = BatchSet.BatchStatus.Exception
            TblBatchProcessingSet.Save(pSet)

            Dim zBatchException As New rowTblBatchProcessingException
            zBatchException.colFldMessage = ex.GetBaseException.Message
            zBatchException.colFldSetId = ex.SetItem.colFldSetId
            zBatchException.colFldSetItemId = ex.SetItem.colFldId
            zBatchException.colFldStack = ex.InnerException.StackTrace
            TblBatchProcessingException.Save(zBatchException)

            WriteLog(pSet.colFldId, "Exception:" & ex.GetBaseException.Message)

            Throw

        Catch ex As Exception

            Dim zBatchException As New rowTblBatchProcessingException
            zBatchException.colFldMessage = ex.GetBaseException.Message
            zBatchException.colFldStack = ex.StackTrace
            TblBatchProcessingException.Save(zBatchException)

            WriteLog(pSet.colFldId, ex.GetBaseException.Message)

            Throw
        End Try

    End Function

    Public Sub Process()
        Try
            Queue()
            ProcessQueue()

        Catch ex As UtilBatchProcessSetItemException

            ex.SetItem.Status = BatchSet.BatchStatus.Exception
            ex.SetItem.colFldException = ex.InnerException.GetBaseException.Message
            TblBatchProcessingSetItem.Save(ex.SetItem)

            ex.BatchSet.BatchSetStatus = BatchSet.BatchStatus.Exception
            TblBatchProcessingSet.Save(ex.BatchSet)

            Dim zBatchException As New rowTblBatchProcessingException
            zBatchException.colFldMessage = ex.GetBaseException.Message
            zBatchException.colFldSetId = ex.SetItem.colFldSetId
            zBatchException.colFldSetItemId = ex.SetItem.colFldId
            zBatchException.colFldStack = ex.InnerException.StackTrace
            TblBatchProcessingException.Save(zBatchException)

            WriteLog(ex.BatchSet.colFldId, "Exception:" & ex.GetBaseException.Message)

            Throw

        Catch ex As UtilBatchProcessSetException

            ex.BatchSet.BatchSetStatus = BatchSet.BatchStatus.Exception
            TblBatchProcessingSet.Save(ex.BatchSet)

            Dim zBatchException As New rowTblBatchProcessingException
            zBatchException.colFldMessage = ex.GetBaseException.Message
            zBatchException.colFldSetId = ex.BatchSet.colFldId
            zBatchException.colFldSetItemId = 0
            zBatchException.colFldStack = ex.InnerException.StackTrace
            TblBatchProcessingException.Save(zBatchException)

            WriteLog(ex.BatchSet.colFldId, "Exception:" & ex.GetBaseException.Message)

            Throw

        Catch ex As Exception

            Dim zBatchException As New rowTblBatchProcessingException
            zBatchException.colFldSetId = 0
            zBatchException.colFldMessage = ex.GetBaseException.Message
            zBatchException.colFldStack = ex.StackTrace
            TblBatchProcessingException.Save(zBatchException)
            WriteLog(0, ex.GetBaseException.Message)

        End Try
    End Sub

    Private Sub Queue()
        Dim zDefinedSets As List(Of BatchSet) = BatchSet.LoadByStatus(BatchSet.BatchStatus.Defined)
        For Each zDefinedSet As BatchSet In zDefinedSets

            If Not zDefinedSet.colFldIsInteractive Then
                For Each zItem As BatchSetItem In zDefinedSet.BatchSetItems
                    zItem.colFldStatusId = BatchSet.BatchStatus.Queued
                    TblBatchProcessingSetItem.Save(zItem)
                Next
                zDefinedSet.BatchSetStatus = BatchSet.BatchStatus.Queued
                TblBatchProcessingSet.Save(zDefinedSet)
            End If
        Next
    End Sub

    Private Sub ProcessQueue()
        Dim zQueuedSets As List(Of BatchSet) = BatchSet.LoadByStatus(BatchSet.BatchStatus.Queued)
        For Each zQueuedSet As BatchSet In zQueuedSets
            If Not zQueuedSet.colFldIsInteractive Then
                Process(zQueuedSet)
            End If
        Next
    End Sub

    Private Function ProcessSet(pSet As BatchSet) As UtilBatchProcessResult
        Dim zSetItemsBytes As New Dictionary(Of String, Byte())

        pSet.BatchSetStatus = BatchSet.BatchStatus.Processing
        TblBatchProcessingSet.Save(pSet)

        For Each zSetItem As BatchSetItem In pSet.BatchSetItems
            Try
                zSetItem.Status = BatchSet.BatchStatus.Processing

                Select Case pSet.BatchSetTypeGroup
                    Case BatchSet.BatchTypeGroup.Extract
                        Dim zMetaGrid As rowTblMetaGrid = DirectCast(zSetItem.MetaObject, rowTblMetaGrid)

                        Select Case pSet.Type

                            Case BatchSet.BatchType.CSV
                                zMetaGrid.colFldFileName = zMetaGrid.colFldFileName & ".csv"
                            Case BatchSet.BatchType.TAB
                                zMetaGrid.colFldFileName = zMetaGrid.colFldFileName & ".txt"
                            Case Else
                                zMetaGrid.colFldFileName = zMetaGrid.colFldFileName & ".xlsx"
                        End Select

                        zSetItemsBytes.Add(zMetaGrid.colFldFileName, DoExtract(zSetItem))

                    Case BatchSet.BatchTypeGroup.Report
                        Dim zMetaReport As rowTblMetaReport = DirectCast(zSetItem.MetaObject, rowTblMetaReport)
                        zMetaReport.colFldFileName = zMetaReport.colFldFileName & ".pdf"
                        zSetItemsBytes.Add(zMetaReport.colFldFileName, DoReport(zSetItem))
                End Select
                zSetItem.Status = BatchSet.BatchStatus.Processed

            Catch ex As Exception
                Throw New UtilBatchProcessSetItemException("An exception occurred while running batchset [" & pSet.colFldId & "], setItem [" & zSetItem.colFldId & "].", zSetItem, pSet, ex)
            End Try
        Next

        pSet.BatchSetStatus = BatchSet.BatchStatus.Processed
        TblBatchProcessingSet.Save(pSet)

        If zSetItemsBytes.Count > 0 Then

            Dim zBatchProcessResult As UtilBatchProcessResult = Staple(zSetItemsBytes, pSet)
            StoreResult(zBatchProcessResult)
            SetFinalStatus(zBatchProcessResult)

            Return zBatchProcessResult
        Else
            Throw New ArgumentException("There are no items with set [" & pSet.colFldId & "].", "pSet")
        End If
    End Function

    Public Function DoExtract(pSetItem As BatchSetItem) As Byte()
        Dim zProcessExtract As New UtilBatchProcess.Extract
        Return zProcessExtract.GenerateExtract(pSetItem)
    End Function

    Public Function DoReport(pSetItem As BatchSetItem) As Byte()
        Dim zProcessReport As New UtilBatchProcess.Report
        Return zProcessReport.GenerateReport(pSetItem)
    End Function

    Private Function Staple(pFiles As Dictionary(Of String, Byte()), ByRef pSet As BatchSet) As UtilBatchProcessResult
        Dim zResult As New UtilBatchProcessResult

        Select Case pSet.BatchSetTypeGroup
            Case BatchSet.BatchTypeGroup.Extract
                If pFiles.Count > 1 Then
                    zResult.File = CreateZip(pFiles, pSet)
                    zResult.Extension = ".zip"
                    zResult.Mime = "application/zip"
                Else
                    Select Case pSet.Type
                        Case BatchSet.BatchType.CSV
                            zResult.Extension = ".csv"
                            zResult.Mime = "text/csv "
                        Case BatchSet.BatchType.TAB
                            zResult.Extension = ".txt"
                            zResult.Mime = "text/plain "
                        Case BatchSet.BatchType.XLSX
                            zResult.Extension = ".xlsx"
                            zResult.Mime = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
                    End Select
                    zResult.File = pFiles.Values.ToArray(0)
                End If

            Case BatchSet.BatchTypeGroup.Report
                If pFiles.Count > 1 Then zResult.File = CreatePDF(pFiles, pSet) Else zResult.File = pFiles.Values.ToArray(0)
                zResult.Extension = ".pdf"
                zResult.Mime = "application/pdf"
        End Select

        zResult.FileName = pSet.colFldFileName & zResult.Extension
        zResult.FileNameNoExtension = pSet.colFldFileName
        zResult.BatchSet = pSet

        zResult.BatchSet.colFldFileName = zResult.FileName
        TblBatchProcessingSet.Save(zResult.BatchSet)

        WriteLog(pSet.colFldId, "Stapling " & zResult.FileName & " [" & zResult.File.Length & " bytes]")

        Return zResult

    End Function

    Private Function CreateZip(pFiles As Dictionary(Of String, Byte()), pSet As BatchSet) As Byte()
        Dim zTempExtractsFolder As String = IO.Path.Combine(IO.Path.GetTempPath, "GRCConnectExtracts")
        If Not IO.Directory.Exists(zTempExtractsFolder) Then IO.Directory.CreateDirectory(zTempExtractsFolder)

        Dim zGuid As String = Guid.NewGuid.ToString("N")
        Dim zTempFolderXLXS As String = IO.Path.Combine(zTempExtractsFolder, zGuid)
        Dim zZipFilePath As String = IO.Path.Combine(zTempExtractsFolder, zGuid & ".zip")

        IO.Directory.CreateDirectory(zTempFolderXLXS)
        For Each zFile As String In pFiles.Keys
            IO.File.WriteAllBytes(IO.Path.Combine(zTempFolderXLXS, zFile), pFiles(zFile))
        Next

        IO.Compression.ZipFile.CreateFromDirectory(zTempFolderXLXS, zZipFilePath)

        Dim zZipBytes() As Byte = IO.File.ReadAllBytes(zZipFilePath)

        IO.File.Delete(zZipFilePath)

        Return zZipBytes

    End Function

    Private Function CreatePDF(pFiles As Dictionary(Of String, Byte()), pSet As BatchSet) As Byte()
        Dim zReturnDoc As New WebSupergoo.ABCpdf10.Doc
        Dim zTempDoc As WebSupergoo.ABCpdf10.Doc
        For Each zFileName As String In pFiles.Keys
            zTempDoc = New WebSupergoo.ABCpdf10.Doc()
            zTempDoc.Read(pFiles(zFileName))
            zReturnDoc.Append(zTempDoc)
        Next

        Return zReturnDoc.GetData()
    End Function

    Private Sub StoreResult(pResult As UtilBatchProcessResult)
        Dim zFile As New rowTblBatchProcessingFile
        With zFile
            .colFldSetId = pResult.BatchSet.colFldId
            .colFldMime = pResult.Mime
            .colFldData = pResult.File
            .colFldFileSize = pResult.File.Length
            .colFldFileName = pResult.FileNameNoExtension
            .colFldExtension = pResult.Extension
            .colFldGuid = Guid.NewGuid().ToString("N")
            .colFldCreateDate = Now
        End With
        TblBatchProcessingFile.Save(zFile)
    End Sub

    Private Sub SetFinalStatus(pResult As UtilBatchProcessResult)
        'IF THE DELIVERY MODE IS NOT EMAIL THEN SET STATUS TO DELIVERED. 
        '(THE DELIVERED STATUS OF EMAIL WILL BE SET IN THE BATCH PROCESSING CONSOLE APP WHERE IT SENDS THE ACTUAL EMAIL)
        If pResult.BatchSet.colFldIsInteractive Then
            pResult.BatchSet.BatchSetStatus = BatchSet.BatchStatus.Delivered
            TblBatchProcessingSet.Save(pResult.BatchSet)
        End If
    End Sub

    Friend Shared Sub WriteLog(pSetId As Integer, pMessage As String)
        Dim zLog As New rowTblBatchProcessingLog
        With zLog
            .colFldSetId = pSetId
            .colFldMessage = pMessage
            .colFldDate = Now
        End With
        TblBatchProcessingLog.Save(zLog)
        Trace.WriteLine(Reflection.Assembly.GetExecutingAssembly.GetName.Name & ": " & zLog.colFldMessage)
    End Sub

End Class

