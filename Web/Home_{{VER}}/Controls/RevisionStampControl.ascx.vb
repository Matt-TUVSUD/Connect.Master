

Public Class RevisionStampControl
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            '***GRC.Connect.Ed - Replace with new function created by SB 7/29/2015
            'If Not Request.QueryString("sid") Is Nothing Then
            If Not UtilGSafe.GetGUIDFromQueryString() Is Nothing Then
                If UtilGSafe.GetValue(UtilGSafe.GetGUIDFromQueryString(), UtilGSafe.KeyName.AdminUser).ToLower = "true" Then
                    lblRevisionStamp.Text = "Rev (" & Application("SYS_VersionNumber") & ") "
                End If
            End If

            If UtilSystemParms.ReadWebAppMode <> "Dev" Then
                hypRevisions.Visible = False
            End If
        End If

    End Sub

End Class