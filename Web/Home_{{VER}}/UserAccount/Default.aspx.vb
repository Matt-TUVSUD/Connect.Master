Imports GRC.Connect.Libraries.CoreLib.UtilConstants
Imports GRC.Connect.Libraries.CoreLib.UtilGSafe
Imports GRC.Connect.Libraries.CoreLib.UtilValidate
Imports GRC.Connect.Libraries.CoreLib.UtilPractice

Public Class _Default10
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim zSafeGUID As String = GetGUIDFromQueryString()
        Dim zU1 As String = ""
        If Not Request.QueryString("u1") Is Nothing Then
            zU1 = "&u1=" & Request.QueryString("u1")
        End If
        UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.currentPage, PageId_UserAccount, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.currentGridId, UtilMeta.GetMetaKey("GRCConnectUsersAccount", 194), UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.NavReturnURL, Request.Url.LocalPath, UtilGSafe.KeyNameGroup.Session)
        Response.Redirect("UserAccountForm.aspx?sid=" & zSafeGUID & zU1, True)
    End Sub

End Class