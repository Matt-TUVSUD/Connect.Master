Public Class _RecResponse_Logout
    Inherits System.Web.UI.Page

    Public ServerSide_LanguagePreference As String = ""

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            ' PRESET ENGLISH LANGUAGE TO PREVENT ERRORS
            ServerSide_LanguagePreference = "english"
            Session("RecResponse_LanguagePreference") = "english"

            ' GET THE LANGUAGE PREFERENCE
            Dim zObjLog As New GRC.Connect.Libraries.CoreLib.BusinessObjects.RRLog
            Dim zQryLog As New GRC.Connect.Libraries.CoreLib.BusinessObjects.RRLogQuery
            Dim zRRGuid As String = Session("RecResponse_RRLogGuid")
            zQryLog.Select()
            zQryLog.Where(zQryLog.RRLogGuid = zRRGuid)
            If zObjLog.Load(zQryLog) Then
                If Not zObjLog.LanguagePreference Is Nothing Then
                    If zObjLog.LanguagePreference.Length > 0 Then
                        ServerSide_LanguagePreference = zObjLog.LanguagePreference
                        Session("RecResponse_LanguagePreference") = zObjLog.LanguagePreference
                    Else
                        Session("RecResponse_LanguagePreference") = "english" '= zObjLog.LanguagePreference
                        ServerSide_LanguagePreference = "english" '= zObjLog.LanguagePreference
                    End If
                End If
            End If

            ' SEND THE LOGOUT FOLLOW UP REPORT AND EMAIL
            Dim zRR As New AutoRecLib.UtilAutoRec
            Dim zRRLogId As String = Session("RecResponse_RRLogId")
            Dim zRRClient As razor.rowVwRRClients = razor.VwRRClients.LoadData().Find(Function(x) x.colFileprefix = zObjLog.FilePrefix)
            zRR.ProcessLogOut(zRRLogId, zRRClient)

        Catch ex As Exception

        End Try


    End Sub

End Class