Public Class _Default7
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim zQueryString As String = Request.QueryString.ToString
        Dim zRedirectURL As String = "~/Home_{{VER}}/Charts/default.aspx?pBuffer=0"

        If zQueryString.Length > 0 Then
            zRedirectURL = zRedirectURL & "&" & zQueryString
        End If

        Response.Redirect(zRedirectURL, False)

    End Sub



End Class