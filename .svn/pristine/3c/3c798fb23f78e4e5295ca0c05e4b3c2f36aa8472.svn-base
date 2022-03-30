
Public Class UtilNotification

    Private _CS As String = ""

    Public Sub New(pGRCConnectConnectString As String)
        _CS = pGRCConnectConnectString

        AddHandler AppDomain.CurrentDomain.AssemblyLoad, AddressOf AssemblyLoad

    End Sub

    Public Sub AssemblyLoad(sender As Object, e As AssemblyLoadEventArgs)
        Trace.WriteLine(e.LoadedAssembly.FullName)
    End Sub

    Public Sub SubmitNotification(pTo As String, pCc As String, pBcc As String, pSubject As String, pBody As String, pNotificationType As String, pAttachments As List(Of NotificationAttachment))
        Dim zCon As New SqlClient.SqlConnection(_CS)
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

    <Serializable>
    Public Class NotificationAttachment
        Public FileName As String
        Public Data As Byte()

        Public Sub New(pFileName As String, pData As Byte())
            FileName = pFileName
            Data = pData
        End Sub

    End Class

End Class
