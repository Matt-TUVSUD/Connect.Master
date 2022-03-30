Public Class UtilFDR

    Private _CS As String = ""

    Public Sub New(pGRCConnectConnectString As String)
        _CS = pGRCConnectConnectString
    End Sub

    Public Sub GenerateFDR(pUserFullName As String, pUserEmailAddress As String, pFileNo As String, pFileName As String, pPractice As FDRPractice)
        Dim zCon As New SqlClient.SqlConnection(_CS)
        Dim zCmd As New SqlClient.SqlCommand("spGenerateFDR", zCon)
        With zCmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@UserFullName", pUserFullName)
            .Parameters.AddWithValue("@EmailAddress", pUserEmailAddress)
            .Parameters.AddWithValue("@FileNo", pFileNo)
            .Parameters.AddWithValue("@FileName", pFileName)
            .Parameters.AddWithValue("@MetaPracticeId", pPractice)
        End With

        zCon.Open()
        Using zCon
            Using zCmd
                zCmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub

    Public Enum FDRPractice
        Fire = 3
        BM = 2
    End Enum


End Class
