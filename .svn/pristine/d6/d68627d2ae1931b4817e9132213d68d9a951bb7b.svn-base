Public Class _default8
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim zQueryString As String = Request.QueryString.ToString
        Dim zRedirectURL As String = "~/Home_{{VER}}/preference/PasswordResetAuth.aspx?pBuffer=0"

        If zQueryString.Length > 0 Then
            zRedirectURL = zRedirectURL & "&" & zQueryString
        End If

        ' REDIRECT TO THE CORRECT HOME PAGE IN THE Home_{{VER}} FOLDER
        Response.Redirect(zRedirectURL, False)
    End Sub

End Class