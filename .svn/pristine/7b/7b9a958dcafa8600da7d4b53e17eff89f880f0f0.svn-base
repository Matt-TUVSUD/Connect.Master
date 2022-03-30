Public Class AuthIntegratedLogin
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Get ad user id from integrated login
        Dim zADUserId As String = HttpContext.Current.Request.ServerVariables("AUTH_USER")

        Response.Write("AD User=" & zADUserId)

        'Translate ad user id to email address for GRCAdministrator
        'Call the login process using email address
        'Redirect to switchintegrated page

    End Sub

End Class