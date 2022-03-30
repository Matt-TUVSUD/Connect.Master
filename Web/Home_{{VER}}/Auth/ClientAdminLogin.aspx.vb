
Public Class ClientAdminLogin
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'txtFullName.Text = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(Request.QueryString("sid"), "userFullName")
        lblPassword.Text = "Password"
        txtPassword.Focus()
        Page.Form.DefaultButton = btnAuthenticate.UniqueID ' BINDS ENTER KEY TO AUTHENTICATE BUTTON
        '***GRC.Connect.Ed - Replace with new function created by SB and class properties for saving session variables 7/30/2015
        'Session("IsClientAdmin") = False
        UtilGSafe.SetValue(UtilGSafe.GetGUIDFromQueryString, UtilGSafe.KeyName.IsClientAdmin, "False", UtilGSafe.KeyNameGroup.Session)


    End Sub

    Private Sub btnAuthenticate_Click(sender As Object, e As System.EventArgs) Handles btnAuthenticate.Click
        Dim zUserPassword As String = txtPassword.Text

        '***GRC.Connect.Ed - Replace with new function created by SB 7/29/2015
        'Dim zSafeGUID As String = Request.QueryString("sid")
        Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()

        If zUserPassword.ToLower() = "risk".ToLower() Then
            '***GRC.Connect.Ed - Replace with new function created by SB and class properties for saving session variables 7/30/2015
            'Session("IsClientAdmin") = True
            UtilGSafe.SetValue(UtilGSafe.GetGUIDFromQueryString, UtilGSafe.KeyName.IsClientAdmin, "True", UtilGSafe.KeyNameGroup.Session)
            Response.Redirect("~/Home_{{VER}}/Gauge/?sid=" & zSafeGUID, False)
        Else
            If zUserPassword.Length > 0 Then
                lblMessage.Text = "The password entered is incorrect."
            Else
                lblMessage.Text = "Please enter a password."
            End If
        End If

    End Sub

    Protected Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' REDIRECT TO THE MAIN GAUGE PAGE

        '***GRC.Connect.Ed - Replace with new function created by SB 7/29/2015
        'Dim zSafeGUID As String = Request.QueryString("sid")
        Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Response.Redirect("~/Home_{{VER}}/Gauge/?sid=" & zSafeGUID, False)

    End Sub

End Class