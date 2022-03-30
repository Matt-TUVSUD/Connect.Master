Public Class QoRRedirect
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim zQorUrl As String = UtilSetting.GetQorUrl
        zQorUrl = zQorUrl & "?buffer=1&" & Request.QueryString.ToString

        Dim zUri As New Uri(zQorUrl)
        Dim zPort As String = zUri.Port
        zQorUrl = Replace(zQorUrl, ":" & zPort, "")

        Response.Redirect(zQorUrl)

    End Sub

End Class