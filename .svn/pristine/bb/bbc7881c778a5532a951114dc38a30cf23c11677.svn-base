Public Class ClientsPGPFileForm
    Implements IUtilityForm

    Private Sub uxFilePrefix_TextChanged(sender As Object, e As EventArgs) Handles uxFilePrefix.TextChanged
        Dim zCMD As New SqlClient.SqlCommand("Select clientname FROM Clients where fileprefix=@fp")
        zCMD.Parameters.AddWithValue("@fp", Me.uxFilePrefix.Text)

        Dim zCon As SqlClient.SqlConnection = DataLib.razor.UtilSQLServer.GetConnectionObject
        zCMD.Connection = zCon

        Dim zRdr As SqlClient.SqlDataReader = zCMD.ExecuteReader
        If zRdr.HasRows Then
            zRdr.Read()
            uxClientName.Text = zRdr(0)
        Else
            uxClientName.Text = ""
        End If

        zRdr = Nothing
        zCon.Close()
        zCon = Nothing

    End Sub

    Private Sub uxBrowse_Click(sender As Object, e As EventArgs) Handles uxBrowse.Click
        OpenFileDialog1.ShowDialog()
        uxFilePath.Text = OpenFileDialog1.FileName
        uxPgpFileContent.Text = IO.File.ReadAllText(uxFilePath.Text)
    End Sub

    Private Sub uxSaveToClients_Click(sender As Object, e As EventArgs) Handles uxSaveToClients.Click
        Dim zCMD As New SqlClient.SqlCommand("UPDATE CLIENTS SET DataTransferPgpPublicKey=@File where fileprefix=@fp")
        zCMD.Parameters.AddWithValue("@fp", Me.uxFilePrefix.Text)
        zCMD.Parameters.AddWithValue("@file", IO.File.ReadAllText(Me.uxFilePath.Text))

        Dim zCon As SqlClient.SqlConnection = DataLib.razor.UtilSQLServer.GetConnectionObject
        zCMD.Connection = zCon

        Dim zRecordsAffected As Integer = zCMD.ExecuteNonQuery()

        If CBool(zRecordsAffected) Then
            MsgBox("Record saved")
        End If

        zCon.Close()
        zCon = Nothing

    End Sub

    Public ReadOnly Property ShowOnMainMenu As Boolean Implements IUtilityForm.ShowOnMainMenu
        Get
            Return True
        End Get
    End Property
End Class