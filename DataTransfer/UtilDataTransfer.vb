Imports GRC.Connect.Libraries.DataLib.razor
Imports GRC.Connect.Libraries.PGPLib
Imports GRC.Connect.Libraries.SFTPLib
Imports GRC.EmailManagement.Client
Imports ICSharpCode.SharpZipLib.Core


Public Class UtilDataTransfer
    Implements AppJobLib.IAppJob

    Private _OutputPath As String = ""
    Private _LogFilePath As String = ""

    Public GridIDs As New List(Of Integer)
    Public FileNos As New List(Of String)

    Public Sub New()
        SetOutPutPath()
        SetLogFilePath()
    End Sub

    Public Sub DoWork()
        DoWork("*", -1)
    End Sub

    Public Sub DoWork(pFilePrefix As String)
        DoWork(pFilePrefix, -1)
    End Sub

    Public Sub DoWork(pFilePrefix As String, pMetaGridID As Integer)
        Log("DoWork Started(" & pFilePrefix & "," & pMetaGridID.ToString() & ")")

        ValidateOutPutPath()

        Dim zClientDataTransfers As List(Of rowVwDataTransferClient) = VwDataTransferClient.LoadData()
        zClientDataTransfers = zClientDataTransfers.FindAll(Function(x) x.colFileprefix Like pFilePrefix)

        Dim zGetPDFs As Boolean = False

        For Each zCDT As rowVwDataTransferClient In zClientDataTransfers
            Log("")
            Log("Client: " & zCDT.colFileprefix & " - " & zCDT.colClientname)

            Try

                Dim zMetaGridIDString As String = pMetaGridID.ToString
                If pMetaGridID = -1 Then zMetaGridIDString = "*"

                Dim zDataTransferGrids As List(Of rowVwDataTransferMetaGrid) = VwDataTransferMetaGrid.LoadData.FindAll(Function(x) (x.colFldFilePrefix = zCDT.colFileprefix Or x.colFldFilePrefix = 0) And x.colFldGridId Like zMetaGridIDString).ToList()

                Trace.WriteLine("Running DataTransfer for " & zCDT.colCldbname.ToUpper)

                'CLEAR OUT EXISTING FILES
                Dim zFSEs As String() = IO.Directory.GetFileSystemEntries(GetClientPath(zCDT.colFileprefix))
                For Each zFSE As String In zFSEs

                    If IO.File.Exists(zFSE) Then
                        Dim zF As New IO.FileInfo(zFSE)
                        zF.Delete()
                    Else
                        Dim zD As New IO.DirectoryInfo(zFSE)
                        zD.Delete(True)
                    End If
                Next

                'Checks the datatransfer password, if not set, then create new
                Dim zPassword As String = zCDT.colDataTransferPassword
                Dim zEncryptionKey As String = zCDT.colDataTransferEncryptionKey
                Log("Password is [" & zPassword & "]")
                Log("EncryptionKey is [" & zEncryptionKey & "]")
                If zCDT.colDataTransferEncryptionKey = "" And zCDT.colDataTransferPassword = "" Then
                    Log("Client does not have password or encryption keys.")
                    zPassword = Guid.NewGuid.ToString("N")
                    zEncryptionKey = Guid.NewGuid.ToString("N")
                    Dim zClient As rowTblClients = TblClients.LoadByPrimaryKey(zCDT.colFileprefix)
                    zClient.colDataTransferEncryptionKey = zEncryptionKey
                    zClient.colDataTransferPassword = zPassword
                    TblClients.Save(zClient)
                    Log("New Password is [" & zPassword & "]")
                    Log("New EncryptionKey is [" & zEncryptionKey & "]")
                End If

                'Get FileNos to be passed into UtilBatchSet
                Dim zLocationList As List(Of rowVwLocationFilterFileNo) = VwLocationFilterFileNo.LoadData("SELECT * FROM [jv].[vwLocationFilterFileNo] WHERE FilePrefix='" & zCDT.colFileprefix & "'")


                'EXTRACTS
                If zCDT.colDataTransferOutputOptions.ToUpper.Contains("E") Or zCDT.colDataTransferOutputOptions.ToUpper.Contains("C") Or zCDT.colDataTransferOutputOptions.ToUpper.Contains("T") Then
                    Dim zBatchSet As New BatchSet()
                    With zBatchSet

                        .Type = BatchSet.BatchType.CSV

                        'If zCDT.colDataTransferOutputOptions.ToUpper.Contains("E") Then .Type = BatchSet.BatchType.XLSX
                        'If zCDT.colDataTransferOutputOptions.ToUpper.Contains("C") Then .Type = BatchSet.BatchType.CSV
                        'If zCDT.colDataTransferOutputOptions.ToUpper.Contains("T") Then .Type = BatchSet.BatchType.TAB

                        .colFldIsInteractive = True
                        .colFldIsMyBatchReport = False
                        .colFldCreatedByGsafeUserEmail = "SYSTEM DATATRANSFER"
                        .SetParameters.FilePrefix = zCDT.colFileprefix

                        If zDataTransferGrids.Count > 1 Then
                            .colFldFileName = "GRCExtract.zip"
                        Else
                            .colFldFileName = zDataTransferGrids.First.colFldFileName
                        End If

                        If FileNos.Count = 0 Then
                            If zLocationList.Count > 0 Then
                                For Each zLocation As rowVwLocationFilterFileNo In zLocationList
                                    .AddFileNo(zLocation.colFileNo)
                                Next
                            Else
                                .AddFileNo(zCDT.colFileprefix & ".0000")  'Add corporate location if no filenos exist.
                            End If
                        Else
                            .AddFileNo(FileNos.ToArray)
                        End If


                        If GridIDs.Count = 0 Then
                            For Each zMetaDT As rowVwDataTransferMetaGrid In zDataTransferGrids
                                .AddSetItem(zMetaDT.colFldGridId)
                            Next
                        Else
                            .AddSetItem(GridIDs.ToArray())
                        End If

                    End With


                    Trace.WriteLine("Creating data extracts via batch process")
                    Log("Creating extracts")
                    Dim zResult As UtilBatchProcessResult = zBatchSet.Execute
                    Log("Created extracts")


                    'SAVE TO DEFAULT FOLDER
                    Log("Saving extracts to default folder")
                    UnzipToDefaultFolder(zCDT, zResult, zDataTransferGrids.Count)
                    Log("Saved extracts to default folder")




                    'GET PDFS
                    If zCDT.colDataTransferOutputOptions.ToUpper.Contains("G") Or zCDT.colDataTransferOutputOptions.ToUpper.Contains("J") Then

                        Dim zPDFs As New Dictionary(Of String, Byte())
                        Dim zUtilDTPDF As New PDF()
                        If zCDT.colDataTransferOutputOptions.ToUpper.Contains("G") Then zUtilDTPDF.GatherPDFs(zCDT, PDF.Source.ReportArchive, zPDFs)
                        If zCDT.colDataTransferOutputOptions.ToUpper.Contains("J") Then zUtilDTPDF.GatherPDFs(zCDT, PDF.Source.LettersFolder, zPDFs)

                        'SAVE TO DEFAULT FOLDER
                        UnzipToDefaultFolder(zCDT, zPDFs)

                    End If


                    If zCDT.colDataTransferPgpEnabled Then
                        Log("PGP is enabled")

                        'ENCRYPT TO PGP IF ENABLED
                        Log("Ecrypting extracts to PGP folder")
                        EncryptToPGPFolder(zCDT)
                        Log("Encrytped extracts")

                    End If


                    Dim zTransferDays As List(Of Integer) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of Integer))(zCDT.colDataTransferFtpDayJson)
                    Dim zTransferMonths As List(Of Integer) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of Integer))(zCDT.colDataTransferFtpMonthJson)

                    If zCDT.colDataTransferFtpEnabled AndAlso (zTransferDays.Contains(Today.Day) And zTransferMonths.Contains(Today.Month)) Then
                        Log("FTP is enabled and is a transfer day")

                        If UtilSetting.GetAppMode = UtilSetting.AppMode.Live Then
                            'UPLOAD TO REMOTE SITE
                            Dim zUri As New Uri(zCDT.colDataTransferFtpUrl)
                            Log("Uploading files to FTP site [" & zCDT.colDataTransferFtpUrl & "]")
                            UploadRemoteFTPSite(zUri.Host, zCDT.colDataTransferFtpUserName, zCDT.colDataTransferFtpPassword, GetFTPLocalFolder(zCDT.colFileprefix, zCDT.colDataTransferFtpLocalFolder), zUri.AbsolutePath)
                            Log("Uploaded files")
                        Else
                            Log("Appmode is not Live.  Cancelling FTP.")
                        End If

                    Else
                            Log("FTP is not enabled or not a transfer day.")
                    End If

                    'ENCRYPT DEFAULT FOLDER AND CREATE ZIP FILE USING WINZIP256
                    Log("Zipping up folder")
                    ZipDefaultFolder(zCDT, UtilSystemParms.ReadWebAppMode)
                    Log("Zipped up folder")
                Else

                    Throw New UtilDataTransferException(String.Format("Invalid output option '{0}'", zCDT.colDataTransferOutputOptions.ToUpper), Nothing, zCDT.colCldbname, zCDT.colFileprefix, zCDT.colDataTransferOutputOptions)

                End If

            Catch ex As Exception

                Log("Exception Occurred - " & ex.GetBaseException.Message)

                SendEmail(New UtilDataTransferException(ex.Message, ex, zCDT.colClientname, zCDT.colFileprefix, zCDT.colDataTransferOutputOptions))

            End Try

        Next

        Log("DoWork Completed")

    End Sub

    'Private Sub ZipDefaultFolder(pClient As rowVwDataTransferClient, zMode As String)

    '    Dim zDefaultFolderPath As String = IO.Path.Combine(GetClientPath(pClient.colFileprefix), "DEFAULT")
    '    Dim zZipFile As New Ionic.Zip.ZipFile
    '    AddHandler zZipFile.SaveProgress, AddressOf ZipSaveProgressHandler
    '    AddHandler zZipFile.ZipError, AddressOf ZipErrorHandler

    '    zZipFile.AddFiles(IO.Directory.GetFiles(zDefaultFolderPath), False, "")

    '    For Each zEntry As Ionic.Zip.ZipEntry In zZipFile.Entries
    '        Log("Encrypting file " & zEntry.FileName & " in zip file.")
    '        zEntry.Password = pClient.colDataTransferEncryptionKey
    '        zEntry.Encryption = Ionic.Zip.EncryptionAlgorithm.WinZipAes256
    '    Next

    '    Dim zPath As String = GetClientPath(pClient.colFileprefix)
    '    Dim zFileName As String = GetZipFileName(True)

    '    Log("Saving zip file to " & IO.Path.Combine(zPath, zFileName))
    '    zZipFile.Save(IO.Path.Combine(zPath, zFileName))
    '    Log("Saved zip file")

    '    Log("Disposing zipe file")
    '    zZipFile.Dispose()
    '    Log("Disposed zip file")


    'End Sub

    Private Sub ZipDefaultFolder(pClient As rowVwDataTransferClient, zMode As String)


        Dim zDefaultFolderPath As String = IO.Path.Combine(GetClientPath(pClient.colFileprefix), "DEFAULT")
        'Dim zDefaultFolderPath As String = IO.Path.Combine("\sfsdfsd", "DEFAULT")
        Dim zZipOutputPath As String = IO.Path.Combine(GetClientPath(pClient.colFileprefix), GetZipFileName(True))

        Dim zipperEvents As New ICSharpCode.SharpZipLib.Zip.FastZipEvents()
        zipperEvents.CompletedFile = AddressOf FastZipCompletedFile
        zipperEvents.FileFailure = AddressOf FastZipFileFailure

        Dim zipper As New ICSharpCode.SharpZipLib.Zip.FastZip(zipperEvents)
        zipper.Password = pClient.colDataTransferEncryptionKey
        zipper.EntryEncryptionMethod = ICSharpCode.SharpZipLib.Zip.ZipEncryptionMethod.AES256
        zipper.CreateZip(zZipOutputPath, zDefaultFolderPath, False, Nothing)

    End Sub

    Private Sub FastZipFileFailure(sender As Object, e As ScanFailureEventArgs)

        Log("Saving Zip file error " & e.Name & " (" & e.Exception.GetBaseException.Message & ")")

        Throw e.Exception

        e.ContinueRunning = False

    End Sub

    Private Sub FastZipCompletedFile(sender As Object, e As ScanEventArgs)
        Console.WriteLine("Saving Zip file: " & e.Name)

        Log("Saving Zip file " & e.Name)

        e.ContinueRunning = True
    End Sub

    Private Function GetClientPath(pFilePrefix As String)
        Dim zClientPath As String = ""
        zClientPath = IO.Path.Combine(_OutputPath, pFilePrefix)
        If Not IO.Directory.Exists(zClientPath) Then IO.Directory.CreateDirectory(zClientPath)
        Return zClientPath

    End Function

    Private Sub UnzipToDefaultFolder(pClient As rowVwDataTransferClient, pResult As UtilBatchProcessResult, pFileCount As Integer)

        Trace.WriteLine("Extracting data files into DEFAULT folder")
        Dim zDefaultFolderPath As String = IO.Path.Combine(GetClientPath(pClient.colFileprefix), "DEFAULT")


        If pFileCount > 1 Then
            Dim zStream As New IO.MemoryStream(pResult.File)
            Dim zZipFile As Ionic.Zip.ZipFile = Ionic.Zip.ZipFile.Read(zStream)
            Dim zFn As String = ""

            Trace.Indent()
            For Each zEntry As Ionic.Zip.ZipEntry In zZipFile.Entries
                Trace.WriteLine("Extracting..." & zEntry.FileName)
                Using zMS As New IO.MemoryStream
                    zEntry.Extract(zMS)
                    zFn = pClient.colDataTransferFileNameFormatString.ToLower.Replace("{{ExtractName}}".ToLower, IO.Path.GetFileNameWithoutExtension(zEntry.FileName)).Replace("{{Date}}".ToLower, Today.ToString("yyyyMMdd")).Replace("{{FilePrefix}}".ToLower, pClient.colFileprefix) & IO.Path.GetExtension(zEntry.FileName)
                    If Not IO.Directory.Exists(zDefaultFolderPath) Then IO.Directory.CreateDirectory(zDefaultFolderPath)
                    IO.File.WriteAllBytes(IO.Path.Combine(zDefaultFolderPath, zFn), zMS.GetBuffer())
                End Using
            Next

        Else
            Dim zFn As String = ""
            Trace.WriteLine("Extracting..." & pResult.BatchSet.colFldFileName)
            zFn = pClient.colDataTransferFileNameFormatString.ToLower.Replace("{{ExtractName}}".ToLower, IO.Path.GetFileNameWithoutExtension(pResult.BatchSet.colFldFileName)).Replace("{{Date}}".ToLower, Today.ToString("yyyyMMdd")).Replace("{{FilePrefix}}".ToLower, pClient.colFileprefix) & IO.Path.GetExtension(pResult.BatchSet.colFldFileName)
            If Not IO.Directory.Exists(zDefaultFolderPath) Then IO.Directory.CreateDirectory(zDefaultFolderPath)
            IO.File.WriteAllBytes(IO.Path.Combine(zDefaultFolderPath, zFn), pResult.File)
        End If

        Trace.Unindent()
    End Sub

    Private Sub UnzipToDefaultFolder(pClient As rowVwDataTransferClient, pPDFList As Dictionary(Of String, Byte()))

        Trace.WriteLine("Extracting PDF files into DEFAULT folder")
        Dim zDefaultFolderPath As String = IO.Path.Combine(GetClientPath(pClient.colFileprefix), "DEFAULT")
        If Not IO.Directory.Exists(zDefaultFolderPath) Then IO.Directory.CreateDirectory(zDefaultFolderPath)

        Trace.Indent()
        For Each pPDFKey As String In pPDFList.Keys
            Trace.WriteLine("Extracting..." & pPDFKey)

            IO.File.WriteAllBytes(IO.Path.Combine(zDefaultFolderPath, pPDFKey), pPDFList(pPDFKey))
        Next
        Trace.Unindent()
    End Sub

    Public Sub UploadRemoteFTPSite(pHost As String, pUserName As String, pPassword As String, pLocalFolderPath As String, pRemotePath As String)

        Dim zFilePaths As List(Of String) = IO.Directory.GetFiles(pLocalFolderPath).ToList()

        If Not zFilePaths.Contains("exception.txt") Then

            Dim zFTP As New UtilSFTP

            Trace.WriteLine("Uploading Local Folder [" & pLocalFolderPath & "]...")
            zFTP.Upload(pHost, pUserName, pPassword, IO.Path.Combine(pLocalFolderPath, "*.*"), pRemotePath)

            Trace.Indent()
            zFTP.Transfers.ForEach(Sub(x) Trace.WriteLine("Uploaded " & IO.Path.GetFileName(x)))
            Trace.Unindent()

            If zFTP.Exceptions.Count > 0 Then
                Dim zEx As New Exception("An exception occurred in uploading the data transfer files to FTP site.", zFTP.Exceptions(0))
                zEx.Data.Add("Host", pHost)
                zEx.Data.Add("User", pUserName)
                zEx.Data.Add("LocalFolder", pLocalFolderPath)
                Throw zEx
            End If

        End If

    End Sub

    Private Sub EncryptToPGPFolder(pClient As rowVwDataTransferClient)

        Trace.WriteLine("Encrypting to PGP Folder")
        Dim zDefaultFolderPath As String = IO.Path.Combine(GetClientPath(pClient.colFileprefix), "DEFAULT")
        Dim zPGPFolderPath As String = IO.Path.Combine(GetClientPath(pClient.colFileprefix), "PGP")
        IO.Directory.CreateDirectory(zPGPFolderPath)

        If Not String.IsNullOrEmpty(pClient.colDataTransferPgpPublicKey) Then
            Dim zUtilPGP As New UtilPGP(pClient.colDataTransferPgpPublicKey)
            Dim zFiles() As String = IO.Directory.GetFiles(zDefaultFolderPath)

            Trace.Indent()
            For Each zFile As String In zFiles
                Dim zExtension As String = IO.Path.GetExtension(zFile)
                If Not String.IsNullOrEmpty(pClient.colDataTransferPgpFileExtension) Then zExtension = pClient.colDataTransferPgpFileExtension

                Dim zDestFile As String = IO.Path.ChangeExtension(Replace(zFile, "DEFAULT", "PGP"), zExtension)
                IO.File.Copy(zFile, zDestFile, True)

                Dim zByte() As Byte = zUtilPGP.EncryptFile(zDestFile)
                IO.File.WriteAllBytes(zDestFile, zByte)

                Trace.WriteLine("Encrypted PGP File..." & IO.Path.GetFileName(zDestFile))
            Next
            Trace.Unindent()
        Else
            IO.File.WriteAllText(IO.Path.Combine(zPGPFolderPath, "exception.txt"), "No PGP Public Key specified for client [." & pClient.colFileprefix & "].")
        End If


    End Sub

    Private Function GetZipFileName(ByVal GetEncryptedName As Boolean) As String
        Dim zName As String = UtilSetting.GetValue(UtilSetting.Keys.DataTransferFileName)
        If GetEncryptedName Then
            zName = "e" & zName
        End If
        Return zName
    End Function

    Public Sub SetRetrievalDate(pFilePrefix As String)
        Dim zClient As List(Of rowTblClients) = TblClients.LoadByIDX_PK_clients(pFilePrefix)
        If zClient.Count > 0 Then
            zClient(0).colDataTransferRetrievalDate = Now
            TblClients.Save(zClient(0))
        End If
    End Sub

    Public Function GetEncryptedPackage(ByVal pFilePrefix As String, ByVal pDataTransferPwd As String) As Byte()
        ValidateOutPutPath()
        Dim zClient As New TblClients
        If IsAuthenticated(pFilePrefix, pDataTransferPwd) Then
            Dim zFilePath As String = IO.Path.Combine(GetClientPath(pFilePrefix), GetZipFileName(True))
            Return IO.File.ReadAllBytes(zFilePath)
        Else
            Throw New ApplicationException("The supplied file prefix (" & pFilePrefix & ") And datatransfer password (" & pDataTransferPwd & ") combination is invalid.")
        End If

    End Function

    Private Function IsAuthenticated(pFilePrefix As String, pDataTransferPassword As String) As Boolean
        Dim zClientDataTransfers As List(Of rowVwDataTransferClient) = VwDataTransferClient.LoadData()
        For Each zCDT As rowVwDataTransferClient In zClientDataTransfers
            If zCDT.colFileprefix = pFilePrefix And zCDT.colDataTransferPassword = pDataTransferPassword Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Function GetFTPLocalFolder(pFilePrefix As String, pFolderName As String) As String
        Return IO.Path.Combine(GetClientPath(pFilePrefix), pFolderName)
    End Function

    Private Sub SetOutPutPath()
        Dim zRootPath As String = UtilSetting.GetValue(UtilSetting.Keys.DataTransferRootPath)
        Dim zEnvPath As String = UtilSetting.GetValue(UtilSetting.Keys.DataTransferFolder)
        _OutputPath = IO.Path.Combine(zRootPath, zEnvPath)
    End Sub

    Private Sub SetLogFilePath()
        Dim zFileName As String = "DataTransferLog_" & Now.ToString("MMddyy_hhmmss") & ".txt"
        _LogFilePath = IO.Path.Combine(_OutputPath, zFileName)
    End Sub

    Private Sub TrimLogFiles()
        Dim zFiles As String() = IO.Directory.GetFiles(_OutputPath)
        For Each zFile As String In zFiles
            Dim zInfo As New IO.FileInfo(zFile)
            If zInfo.CreationTime < Today.AddDays(-10) Then
                zInfo.Delete()
            End If
        Next
    End Sub

    Private Sub ValidateOutPutPath()

        If Trim(_OutputPath).Length = 0 Then
            Dim zEx As New ArgumentException("DataTransfer output path is empty.", "UtilSetting.Keys.DataTransferRootPath")
            zEx.Data.Add("OutputPath", "<Empty>")
            Throw zEx
        Else
            If Not IO.Directory.Exists(_OutputPath) Then
                Dim zEx As New ArgumentException("DataTransfer output path does not exist or is not accessible due to permissions.", "UtilSetting.Keys.DataTransferRootPath")
                zEx.Data.Add("OutputPath", _OutputPath)
                Throw zEx
            End If
        End If

    End Sub

    Public Enum DataTransferGrids
        FireNatHazModeling = 41
        BMInspectionStatus = 55
        FireInspectionStatus = 56
        IRInspectionStatus = 57
        IREquipment = 59
        JurisObjectInventory = 106
        JurisRecommendations = 133
        BMFacilityRatingExtract = 136
        FireFacilityRatingExtract = 138
        BMRecommendationsAll = 169
        FireRecommendationsAll = 171
        IRRecommendationsAll = 173
        FireCOPEDataExtract = 184
        BMFacilityDataExtract = 199
        CargillCustomCope = 327
    End Enum

    Public Sub Log(pMessage As String)
        IO.File.AppendAllText(_LogFilePath, Now.ToString & " - " & pMessage & vbNewLine)
    End Sub

    Public Sub ZipSaveProgressHandler(sender As Object, args As Ionic.Zip.SaveProgressEventArgs)
        If args.EventType = Ionic.Zip.ZipProgressEventType.Saving_AfterWriteEntry Then
            Console.WriteLine("Saving Zip file " & args.CurrentEntry.FileName & " [" & args.EntriesSaved & " of " & args.EntriesTotal & "]")
            Log("Saving Zip file " & args.CurrentEntry.FileName & " [" & args.EntriesSaved & " of " & args.EntriesTotal & "]")
        End If
    End Sub

    Public Sub ZipErrorHandler(sender As Object, args As Ionic.Zip.ZipErrorEventArgs)
        Log("Saving Zip file error [" & args.CurrentEntry.FileName & "] " & args.Exception.Message)
    End Sub

    Sub SendEmail(pException As DataTransferLib.UtilDataTransferException)
        Dim zEmailCS As String = ""
        Dim zEnv As GRC.EmailManagement.Client.MailMessage.EmailMsgEnvironment = Nothing
        Dim zFromDisplay As String = "Data Transfer"

        If UtilSystemParms.InDevMode Or UtilSystemParms.InTestMode Then
            zEmailCS = "EmailManagement.Test"
            zEnv = MailMessage.EmailMsgEnvironment.Test
            zFromDisplay = zFromDisplay
        Else
            zEmailCS = "EmailManagement.Live"
            zEnv = MailMessage.EmailMsgEnvironment.Live
        End If

        Dim zSubmitter As New GRC.EmailManagement.Client.EmailSubmitter(Configuration.ConfigurationManager.ConnectionStrings(zEmailCS).ConnectionString, My.Application.Info.AssemblyName, zEnv)
        Dim zMsgProps As New GRC.EmailManagement.Client.MailMessageProcessingProperties
        With zMsgProps
            If Not String.IsNullOrEmpty(UtilSetting.GetValue(UtilSetting.Keys.TaskAgentExceptionRecipients)) Then
                zMsgProps.To.Add(UtilSetting.GetValue(UtilSetting.Keys.TaskAgentExceptionRecipients))
                zMsgProps.Subject = pException.Client & " Data Transfer Exception (" & UtilSystemParms.ReadWebAppMode & ")"
                zMsgProps.Body = GRC.Resources.ExceptionUtility.ExtractMessagesHTML(pException.Source, pException)
                zMsgProps.From = New Net.Mail.MailAddress("null@tuvsud.com", zFromDisplay)
                zMsgProps.OrigProcess = "GRC Task Agent"
                zSubmitter.Submit(zMsgProps.ToMailMessage)
            Else
                EventLog.WriteEntry("GRC Task Agent", "Could not send exception email to Task Agent Exception Recipients. No email was specified in the system parms table.")
            End If
        End With

        Log("Exception Mail Sent")

    End Sub

    Public Property Job As AppJobLib.razor.rowTblJob Implements IAppJob.Job

End Class
