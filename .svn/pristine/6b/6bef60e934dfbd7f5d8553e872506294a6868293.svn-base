
Public Class PasswordResetAuth
    Inherits System.Web.UI.Page

    Private Sub LoadDefaults()

    End Sub

    Private Sub LoadLists()

    End Sub

    Private Sub LoadData()

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Call LoadLists()
            Call LoadDefaults()
        End If

        Call LoadData()
    End Sub

    Protected Sub btnEnterEmail_Click(sender As Object, e As EventArgs) Handles btnEnterEmail.Click
        If Not Request.QueryString("p1") Is Nothing Then
            Dim zLoginGUID As String = Request.QueryString("p1").ToString & ""
            Dim zEmailAddress As String = txtEmail.Text
            Dim zLogin As New GRC.Connect.Libraries.CoreLib.UtilLogin2

            If zLogin.EmailExists(zEmailAddress, zLoginGUID) Then
                'Match
                ' DO SOMETHING HERE
                Response.Redirect("PasswordResetForm.aspx?p1=" & zLoginGUID)
            Else
                'No match
                lblMessage.Text = "Sorry we do not recognize your email. <BR/> Please contact your Risk Management to request access to the TUV SUD GRC Connect system."
            End If
        Else
            'What should we do if we do not receive a LoginGUID value at all?
            'Redirect back to Auth
        End If
    End Sub

End Class