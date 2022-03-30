
Imports GRC.Connect.Libraries.CoreLib.UtilConstants


Public Class DefaultLogout
    Inherits System.Web.UI.Page

    Private Sub ValidatePage()
        '***GRC.Connect.Ed - Replace with new function created by SB 7/29/2015
        'GRC.Connect.Libraries.CoreLib.UtilValidate.CorrectPageCheck(Request.QueryString("sid"), PageId_LogOut, "")
        GRC.Connect.Libraries.CoreLib.UtilValidate.CorrectPageCheck(UtilGSafe.GetGUIDFromQueryString(), PageId_LogOut, "")
    End Sub

    Private Sub loadLists()

    End Sub

    Private Sub loadDefaults()
        '***GRC.Connect.Ed - Replace with new function created by SB 7/29/2015
        'GRC.Connect.Libraries.CoreLib.UtilLogin.LogoutUser(False, Request.QueryString("sid"), Session.Timeout)
        GRC.Connect.Libraries.CoreLib.UtilLogin2.LogoutUser(False, UtilGSafe.GetGUIDFromQueryString())

        '***GRC.Connect.Ed - Replace with new function created by SB 7/29/2015
        'Dim zEmail As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(Request.QueryString("sid"), "UserEmail")
        'Dim zPassword As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(Request.QueryString("sid"), "UserPassword")
        Dim zEmail As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(UtilGSafe.GetGUIDFromQueryString(), UtilGSafe.KeyName.UserEmail)
        Dim zPassword As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(UtilGSafe.GetGUIDFromQueryString(), UtilGSafe.KeyName.UserPassword)
        If Not GRC.Connect.Libraries.CoreLib.UtilLogin2.IsGRCAdministrator(zEmail) Then
            'Client user has requested to logout
            Session.Abandon()
            hylLogin.NavigateUrl = "~/Home_{{VER}}/Auth"
        Else
            'leave the session intact if the user is a GRCAdministrator and send them back to the switch page for selecting another client
            '***GRC.Connect.Ed - Replace with new function created by SB 7/29/2015
            'hylLogin.NavigateUrl = "~/Home_{{VER}}/Switch/SwitchIntegrated.aspx?sid=" & Request.QueryString("sid")
            hylLogin.NavigateUrl = "~/Home_{{VER}}/Switch/SwitchIntegrated.aspx?sid=" & UtilGSafe.GetGUIDFromQueryString()
            hylLogin.Text = "here" 'WAS Log-In Again BUT CHANGE REQUESTED BY GARY 11/29/2012
        End If
    End Sub

    Private Sub loadData()

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call ValidatePage()

        If Not Page.IsPostBack Then
            Call loadLists()
            Call loadDefaults()
        End If

        Call loadData()
    End Sub

End Class