Public Class UtilClient

    Public Shared Sub GenerateFDR(pUserFullName As String, pUserEmailAddress As String, pFileNo As String, pFileName As String, pPractice As FDRPractice)

        Dim zCon As New SqlClient.SqlConnection(UtilDB.ReadConnectionString(UtilDB.Databases.Connect))
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

    Public Shared Sub SubmitNotification(pTo As String, pCc As String, pBcc As String, pSubject As String, pBody As String, pNotificationType As String, pAttachments As List(Of NotificationAttachment))
        Dim zCon As New SqlClient.SqlConnection(UtilDB.ReadConnectionString(UtilDB.Databases.Connect))
        Dim zCmd As New SqlClient.SqlCommand("spGenerateNotification", zCon)
        With zCmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@To", pTo)
            .Parameters.AddWithValue("@CC", pCc)
            .Parameters.AddWithValue("@Bcc", pBcc)
            .Parameters.AddWithValue("@Subject", pSubject)
            .Parameters.AddWithValue("@Body", pBody)
            .Parameters.AddWithValue("@AttachmentData", Newtonsoft.Json.JsonConvert.SerializeObject(pAttachments))
            .Parameters.AddWithValue("@NotificationType", pNotificationType)
        End With

        zCon.Open()
        Using zCon
            Using zCmd
                zCmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub

    Public Shared Function ValidateSID(pSID As String) As ValidateSIDResult
        Dim zReturn As New ValidateSIDResult
        Dim zCon As New SqlClient.SqlConnection(UtilDB.ReadConnectionString(UtilDB.Databases.Connect))
        Dim zCmd As New SqlClient.SqlCommand("Select GsafeID, LoginID, GsafeGUID from gsafeheader where GSafeGUID=@SID", zCon)
        zCmd.Parameters.AddWithValue("@SID", pSID)
        Dim zRdr As SqlClient.SqlDataReader = Nothing
    
        zCon.Open()
        Using zCon
            Using zCmd
                zRdr = zCmd.ExecuteReader(CommandBehavior.CloseConnection)

                If zRdr.HasRows Then
                    zRdr.Read()
                    zReturn.SID = zRdr("GsafeGUID")
                    zReturn.LoginID = zRdr("LoginID")
                    zRdr.Close()

                    Dim zCmd1 As New SqlClient.SqlCommand("select LoginID,EmailAddress, FullName, ActiveFlag from ezy_login where loginid=@LoginID and activeflag=1", zCon)
                    zCmd1.Parameters.AddWithValue("@LoginID", zReturn.LoginID)
                    Dim zRdr1 As SqlClient.SqlDataReader = Nothing

                    If zCon.State = ConnectionState.Closed Then zCon.Open()
                    Using zCmd1
                        zRdr1 = zCmd1.ExecuteReader(CommandBehavior.CloseConnection)

                        If zRdr1.HasRows Then
                            zRdr1.Read()
                            zReturn.Email = zRdr1("EmailAddress")
                            zReturn.FullName = zRdr1("FullName")
                            zReturn.IsAuthenticated = True
                        End If
                    End Using
                End If
            End Using
        End Using

        Return zReturn

    End Function

    Public Shared Sub Initialize()
        razor.UtilSQLServer.SetConnection(UtilDB.ReadConnectionString(UtilDB.Databases.Connect))
    End Sub

    Public Enum FDRPractice
        Fire = 3
        BM = 2
    End Enum

End Class
