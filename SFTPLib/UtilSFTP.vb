Imports WinSCP

Public Class UtilSFTP

    Public IsSuccess As Boolean
    Public Transfers As New List(Of String)
    Public Exceptions As New List(Of Exception)

    ''' <summary>
    ''' Uploads files to a remote FTP site using SFTP secured protocol (port 22)
    ''' </summary>
    ''' <param name="pHost">The host name (Ex: mysite.domain.com)</param>
    ''' <param name="pUserId">The username to authenticate with.</param>
    ''' <param name="pPassword">The password to authenticate with.</param>
    ''' <param name="pLocalPath">The local path of the file(s), or directory to upload to.  Use wildcards to denote multiple files in a directory. (ex: c:\pgp\*.txt, or c:\pgp\test.txt, or c:\pgp\*.*)</param>
    ''' <param name="pRemotePath">The remote path.  Default is root folder.  </param>
    ''' <remarks></remarks>
    Sub Upload(pHost As String, pUserId As String, pPassword As String, pLocalPath As String, Optional pRemotePath As String = "/")

        If IO.Directory.Exists(pLocalPath) Then
            pLocalPath = IO.Path.Combine(pLocalPath, "*.*")
        End If

        If Right(pRemotePath, 1) <> "/" Then
            pRemotePath = pRemotePath & "/"
        End If

        If IO.Path.GetExtension(pLocalPath) = "" Then Throw New Exception("pFilePath parameter is invalid.  Use wildcards to denote multiple files or directory")

        Exceptions = New List(Of Exception)
        IsSuccess = False
        Transfers.Clear()

        Dim sessionOptions As New SessionOptions
        With sessionOptions
            .Protocol = Protocol.Sftp
            .HostName = Trim(pHost)
            .UserName = Trim(pUserId)
            .Password = Trim(pPassword)
            .GiveUpSecurityAndAcceptAnySshHostKey = True
        End With

        Using session As New Session

            Dim zWinscpPath As String = IO.Path.Combine(IO.Path.GetTempPath, "winscp.exe")
            Dim zWinscIniPath As String = IO.Path.Combine(IO.Path.GetTempPath, "winscp.ini")

            If Not IO.File.Exists(zWinscpPath) Then
                IO.File.WriteAllBytes(zWinscpPath, My.Resources.WinSCPexe)
                IO.File.WriteAllBytes(zWinscIniPath, System.Text.ASCIIEncoding.Unicode.GetBytes(My.Resources.WinSCPIni))
            End If

            session.ExecutablePath = zWinscpPath
            session.Open(sessionOptions)

            ' Upload files
            Dim transferOptions As New TransferOptions
            transferOptions.TransferMode = TransferMode.Binary
            transferOptions.PreserveTimestamp = False
            transferOptions.FilePermissions = Nothing
            transferOptions.OverwriteMode = OverwriteMode.Append

            Dim result As TransferOperationResult = session.PutFiles(pLocalPath, pRemotePath, False, transferOptions)
            result.Check()

            IsSuccess = result.IsSuccess
            result.Transfers.ToList.ForEach(Sub(x) Transfers.Add(x.FileName))
            result.Failures.ToList.ForEach(Sub(x) Exceptions.Add(x))

        End Using

    End Sub

    ''' <summary>
    ''' Uploads files to a remote FTP site using SFTP secured protocol (port 22)
    ''' </summary>
    ''' <param name="pHost">The domain of the site. Do not include sftp://. (Ex: mysite.domain.com)</param>
    ''' <param name="pUserId">The username to authenticate with.</param>
    ''' <param name="pPassword">The password to authenticate with.</param>
    ''' <param name="pFiles">A dictionary containing the file name and binary file to upload.</param>
    ''' <remarks></remarks>
    Sub Upload(pHost As String, pUserId As String, pPassword As String, pFiles As Dictionary(Of String, Byte()))

        Dim zTempFilePath As String = IO.Path.Combine(IO.Path.GetTempPath, "PGP", Guid.NewGuid.ToString("N"))
        pFiles.Keys.ToList.ForEach(Sub(x) IO.File.WriteAllBytes(zTempFilePath, pFiles(x)))
        Upload(pHost, pUserId, pPassword, IO.Path.Combine(zTempFilePath, "*.*"))

    End Sub

    Public Shared Function TestConnectivity(pHost As String, pUserId As String, pPassword As String) As Boolean
        Dim sessionOptions As New SessionOptions
        With sessionOptions
            .Protocol = Protocol.Sftp
            .HostName = Trim(pHost)
            .UserName = Trim(pUserId)
            .Password = Trim(pPassword)
            .GiveUpSecurityAndAcceptAnySshHostKey = True
        End With

        Using session As New Session

            Dim zWinscpPath As String = IO.Path.Combine(IO.Path.GetTempPath, "winscp.exe")
            Dim zWinscIniPath As String = IO.Path.Combine(IO.Path.GetTempPath, "winscp.ini")

            If Not IO.File.Exists(zWinscpPath) Then
                IO.File.WriteAllBytes(zWinscpPath, My.Resources.WinSCPexe)
                IO.File.WriteAllBytes(zWinscIniPath, System.Text.ASCIIEncoding.Unicode.GetBytes(My.Resources.WinSCPIni))
            End If

            session.ExecutablePath = zWinscpPath
            Try
                session.Open(sessionOptions)
                session.Close()
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Using

    End Function

End Class
