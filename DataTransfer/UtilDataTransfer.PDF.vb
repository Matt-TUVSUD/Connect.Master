Imports GRC.Connect.Libraries.DataLib.razor

Partial Class UtilDataTransfer
    Public Class PDF
        Implements AppJobLib.IAppJob

        Private _InvalidPaths As New List(Of String)
        Private _IsValidating As Boolean
        Private _RunningTasks As New List(Of String)

        Public Enum Source
            ReportArchive
            LettersFolder
        End Enum

        Public Sub GatherPDFs(pDTClient As rowVwDataTransferClient, pSource As Source, ByRef pPDF As Dictionary(Of String, Byte()))
            If pSource = Source.ReportArchive Then GatherPDFsUsingReportArchive(pDTClient, pPDF)
            If pSource = Source.LettersFolder Then GatherPDFsUsingLettersFolder(pDTClient, pPDF)
        End Sub

        Private Sub GatherPDFsUsingReportArchive(pClient As rowVwDataTransferClient, ByRef pPDF As Dictionary(Of String, Byte()))

            Dim zList As List(Of rowVwDataTransferReportArchive) = GetReportArchiveFilePaths(pClient.colDataTransferRetrievalDate, pClient.colFileprefix)

            For Each zItem As rowVwDataTransferReportArchive In zList
                Try
                    If IO.File.Exists(zItem.colPDFFilePath) Then

                        ''CHECKING TO SEE IF THE FILENAME DOESNT ALREADY EXIST IN THE DICTIONARY, IF SO, APPEND INDEX AFTER FILENAME
                        Dim zFileName As String = IO.Path.GetFileName(zItem.colPDFFilePath)
                        Dim zIndex As Integer = 1
                        Do Until pPDF.ContainsKey(zFileName) = False
                            zFileName = IO.Path.GetFileNameWithoutExtension(zFileName) & "_" & zIndex & IO.Path.GetExtension(zFileName)
                            zIndex += 1
                        Loop

                        Trace.WriteLine("Adding PDF: " & IO.Path.GetFileName(zItem.colPDFFilePath))
                        pPDF.Add(zFileName, IO.File.ReadAllBytes(zItem.colPDFFilePath))

                    Else
                        Trace.WriteLine("Missing File: " & IO.Path.GetFileName(zItem.colPDFFilePath))
                    End If

                Catch ex As Exception
                    ex.Data.Add("PDF", zItem.colPDFFilePath)
                    ex.Data.Add("Archive ID", zItem.colReportArchiveId)
                    Throw
                End Try
            Next

        End Sub

        Private Sub GatherPDFsUsingLettersFolder(pDTClient As rowVwDataTransferClient, ByRef pPDF As Dictionary(Of String, Byte()))

            Dim zQ As New queryVwDataTransferClient
            zQ.SelectAll()
            zQ.Where.Add(zQ.colFileprefix.Equals(pDTClient.colFileprefix))

            Dim zDT As List(Of rowVwDataTransferClient) = VwDataTransferClient.LoadData(zQ.QueryText)
            If zDT.Count > 0 Then
                Dim zClient As rowVwDataTransferClient = zDT(0)
                Dim zRootPath As String = zClient.colClientDBRootPath
                Dim zJurisDirectories As String() = IO.Directory.GetDirectories(zRootPath, "Jurisdictional", IO.SearchOption.AllDirectories)
                Dim zLetterDirectories As New List(Of String)

                For Each zJurisDirectory As String In zJurisDirectories
                    Dim zLettersPath As String = IO.Path.Combine(zJurisDirectory, "Letters")
                    If IO.Directory.Exists(zLettersPath) Then
                        zLetterDirectories.Add(zLettersPath)
                    End If
                Next

                Dim zLastDownloadDate As Date = IIf(IsNothing(zClient.colDataTransferRetrievalDate), "1/1/1900", zClient.colDataTransferRetrievalDate)

                For Each zLetterDir As String In zLetterDirectories
                    Try
                        Dim zPDFFilePaths As String() = IO.Directory.GetFiles(zLetterDir, "*.pdf")

                        For Each zPDFFilePath As String In zPDFFilePaths
                            Try

                                Dim zFileInfo As New IO.FileInfo(zPDFFilePath)
                                If zFileInfo.LastWriteTime > zLastDownloadDate Then

                                    ''CHECKING TO SEE IF THE FILENAME DOESNT ALREADY EXIST IN THE DICTIONARY, IF SO, APPEND INDEX AFTER FILENAME
                                    Dim zFileName As String = IO.Path.GetFileName(zPDFFilePath)
                                    Dim zIndex As Integer = 1
                                    Do Until pPDF.ContainsKey(zFileName) = False
                                        zFileName = IO.Path.GetFileNameWithoutExtension(zFileName) & "_" & zIndex & IO.Path.GetExtension(zFileName)
                                        zIndex += 1
                                    Loop

                                    Trace.WriteLine("Adding PDF " & IO.Path.GetFileName(zPDFFilePath))
                                    pPDF.Add(zFileName, IO.File.ReadAllBytes(zPDFFilePath))
                                Else
                                    Trace.WriteLine("Skipping PDF " & IO.Path.GetFileName(zPDFFilePath) & " (File older than last download date)")
                                End If

                            Catch ex As Exception
                                ex.Data.Add("FilePath", zPDFFilePath)
                                Throw
                            End Try

                        Next

                    Catch ex As Exception
                        ex.Data.Add("Letter Dir.", zLetterDir)
                        Throw
                    End Try

                Next

            End If

        End Sub

        Private Function GetReportArchiveFilePaths(pDocumentDate As Nullable(Of Date), Optional pFilePrefix As String = Nothing) As List(Of rowVwDataTransferReportArchive)

            If IsNothing(pDocumentDate) Then pDocumentDate = "1/1/1900"

            Dim zQry As New queryVwDataTransferReportArchive
            zQry.SelectAll()
            zQry.Where.Add(zQry.colDocumentDate.GreaterThanEqual(pDocumentDate))

            If Not IsNothing(pFilePrefix) Then
                zQry.Where.Add(zQry.colFilePrefix.Equals(pFilePrefix))
            End If

            Return VwDataTransferReportArchive.LoadData(zQry.QueryText)

        End Function

        Public Sub ValidateReportArchivePaths()
            ValidateReportArchivePaths(True, "*")
        End Sub

        Public Sub ValidateReportArchivePaths(ByVal pInvalidOnly As Boolean, ByVal pFilePrefix As String)
            Dim zList As List(Of ValidationItem)

            If pInvalidOnly Then
                zList = VwDataTransferReportArchiveValidation.LoadData(Of ValidationItem)().FindAll(Function(x) x.colIsValid = False And x.colFilePrefix Like pFilePrefix).OrderBy(Function(x) x.colFilePrefix).ToList
            Else
                zList = VwDataTransferReportArchiveValidation.LoadData(Of ValidationItem)().FindAll(Function(X) X.colFilePrefix Like pFilePrefix).OrderBy(Function(x) x.colFilePrefix).ToList
            End If

            Dim zListID As Integer = 1

            Dim zFilePrefixes As New List(Of Integer)
            zList.ForEach(Sub(x) zFilePrefixes.Add(x.colFilePrefix))
            zFilePrefixes = zFilePrefixes.Distinct.ToList

            For Each zFP As Integer In zFilePrefixes
                _IsValidating = True
                Task.Run(Sub() ValidatePathTask(zList.FindAll(Function(x) x.colFilePrefix = zFP)))
            Next

            Do
            Loop While _IsValidating = True

        End Sub

        Private Sub ValidatePathTask(pList As List(Of ValidationItem))

            Dim zFP As String = pList(0).colFilePrefix
            _RunningTasks.Add(zFP)

            Trace.WriteLine("Started " & zFP & " (" & pList.Count & ")")

            Dim zClientDBFolderExists As Boolean = False
            Dim zFileInfos As New List(Of IO.FileInfo)

            For Each zItem As ValidationItem In pList

                Dim zValidation As New rowTblReportArchiveValidation
                If IsNothing(zItem.colValidationID) Then
                    zValidation.colFilePath = zItem.colPDFFilePath
                    zValidation.colReportArchiveID = zItem.colReportArchiveId
                    zValidation.colReportType = zItem.colColumnName
                    zValidation.colValidationDate = Today
                    zValidation.colIsValid = True
                Else
                    zValidation = TblReportArchiveValidation.LoadByPrimaryKey(zItem.colValidationID)
                    zValidation.colValidationDate = Today
                    zValidation.colIsValid = True
                End If

                If Not IO.File.Exists(zValidation.colFilePath) Then
                    zValidation.colIsValid = False

                    'LOAD ALL CLIENT PDFs TO DICTIONARY
                    If zFileInfos.Count = 0 Then
                        Dim zRootInfo As New IO.DirectoryInfo(zItem.colClientDBRootPath)
                        If IO.Directory.Exists(zRootInfo.FullName) Then
                            zClientDBFolderExists = True
                            zFileInfos = zRootInfo.GetFiles("*.pdf", IO.SearchOption.AllDirectories).ToList
                        Else
                            zValidation.colSuggestedFilePath = "Exception: " & zRootInfo.FullName & " does not exist"
                        End If
                    End If

                    'FIND IF FILE RESIDES IN ANOTHER FOLDER
                    If zClientDBFolderExists Then
                        Dim zSuggestedFilePaths As List(Of IO.FileInfo) = zFileInfos.FindAll(Function(x) x.Name = IO.Path.GetFileName(zItem.colPDFFilePath))
                        If zSuggestedFilePaths.Count = 1 Then
                            zValidation.colSuggestedFilePath = zSuggestedFilePaths(0).FullName
                            zValidation.colSuggestedFilePathCount = 1
                        ElseIf zSuggestedFilePaths.Count > 1 Then
                            Dim zSB As New Text.StringBuilder
                            zSuggestedFilePaths.ToList.ForEach(Sub(x) zSB.AppendLine(x.FullName))
                            zValidation.colSuggestedFilePath = Replace(zSB.ToString, vbNewLine, "; ")
                            zValidation.colSuggestedFilePathCount = zSuggestedFilePaths.Count
                        End If
                    End If

                End If

                TblReportArchiveValidation.Save(zValidation)
            Next

            _RunningTasks.RemoveAt(_RunningTasks.FindIndex(Function(x) x = zFP))
            If _RunningTasks.Count = 0 Then _IsValidating = False

            Trace.WriteLine("Completed " & zFP & " (Current Tasks Running: " & _RunningTasks.Count & ")")

        End Sub

        Private Class ValidationItem
            Inherits DataLib.razor.rowVwDataTransferReportArchiveValidation
        End Class


        Public Property Job As AppJobLib.razor.rowTblJob Implements IAppJob.Job
    End Class
End Class
