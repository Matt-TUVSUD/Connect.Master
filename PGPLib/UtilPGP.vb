Imports DidiSoft

Public Class UtilPGP

    Public _PublicKey As String

    Public Sub New(pPublicKey As String)
        _PublicKey = pPublicKey
    End Sub

    Public Function EncryptFile(pPath As String) As Byte()

        Dim zPGP As New Pgp.PGPLib

        Dim zEncryptFilePath As String = IO.Path.GetTempFileName
        Dim zPublicKeyFile As String = IO.Path.GetTempFileName

        Try
            IO.File.WriteAllText(zPublicKeyFile, _PublicKey)
            zPGP.AddMasterKey(New IO.FileInfo(zPublicKeyFile))

            zPGP.EncryptFile(pPath, zPublicKeyFile, zEncryptFilePath)
            Dim zByte() As Byte = IO.File.ReadAllBytes(zEncryptFilePath)
            Return zByte
        Finally
            IO.File.Delete(zEncryptFilePath)
            IO.File.Delete(zPublicKeyFile)
        End Try

    End Function

    Public Sub EncryptFiles(pPath As String)
        Dim zFilePaths As String() = IO.Directory.GetFiles(pPath)
        For Each zFilePath As String In zFilePaths
            If IO.File.Exists(zFilePath) Then
                Dim zByte() As Byte = EncryptFile(zFilePath)
                IO.File.WriteAllBytes(zFilePath, zByte)
            End If
        Next
    End Sub

End Class
