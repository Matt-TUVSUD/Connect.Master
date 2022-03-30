Imports GRC.Connect.Libraries.SFTPLib
Imports GRC.Connect.Libraries.PGPLib

Public Class PGPUtilityForm
    Implements IUtilityForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Multiselect = True
        OpenFileDialog1.ShowDialog()

        Dim zSelectedFiles() As String = OpenFileDialog1.FileNames

        For Each zFile As String In zSelectedFiles
            ListBox1.Items.Add(zFile)
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Trim(uxPGPPublicKey.Text).Length = 0 Then
            MsgBox("Please enter a PGP Public Key to encrypt with.")
        End If

        Dim zPGP As New UtilPGP(Nothing)
        For Each zFile As String In ListBox1.Items
            Dim zExt As String = IO.Path.GetExtension(zFile)
            Try
                Dim zByte() As Byte = zPGP.EncryptFile(zFile)
                Dim zTempPath As String = Replace(IO.Path.GetTempFileName(), ".tmp", zExt)
                IO.File.WriteAllBytes(zTempPath, zByte)
                ListBox2.Items.Add(zTempPath)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next

    End Sub

    Private Sub uxPGPPublicKey_TextChanged(sender As Object, e As EventArgs) Handles uxPGPPublicKey.TextChanged

    End Sub

    Private Sub ListBox2_DoubleClick(sender As Object, e As EventArgs) Handles ListBox2.DoubleClick
        Process.Start(ListBox2.SelectedItem.ToString)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim zSelectedFiles As Windows.Forms.ListBox.SelectedObjectCollection = ListBox2.SelectedItems
            If zSelectedFiles.Count = 0 Then MsgBox("No files to upload are selected.")

            For Each zFile As String In zSelectedFiles
                Dim zExt As String = IO.Path.GetExtension(zFile)
                Dim zTempPath As String = Replace(IO.Path.GetTempFileName(), zExt, ".pgp")
                Dim zSFTP As New UtilSFTP()

                zSFTP.Upload(uxHost.Text, uxUser.Text, uxPassword.Text, zTempPath)
                If zSFTP.IsSuccess Then
                    Dim zFiles As New Text.StringBuilder
                    zSFTP.Transfers.ToList.ForEach(Sub(x) zFiles.AppendLine(x))
                    MsgBox("Upload Successful!" & zFiles.ToString)
                Else
                    Dim zExceptions As New Text.StringBuilder
                    zSFTP.Exceptions.ToList.ForEach(Sub(x) zExceptions.AppendLine(x.Message))
                    MsgBox("Upload Not Successful!" & zExceptions.ToString)

                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles uxHost.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles uxUser.TextChanged

    End Sub

    Private Sub uxPassword_TextChanged(sender As Object, e As EventArgs) Handles uxPassword.TextChanged

    End Sub

    Public ReadOnly Property ShowOnMainMenu As Boolean Implements IUtilityForm.ShowOnMainMenu
        Get
            Return True
        End Get
    End Property
End Class