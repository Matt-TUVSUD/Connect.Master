Public Class PasswordErrorPage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim zUtilLogin2 As New UtilLogin2
        If Not String.IsNullOrEmpty(UtilSession.PasswordErrorMessage) Then
            lblErrorMessage1.Text = UtilSession.PasswordErrorMessage
        Else
            lblErrorMessage1.Text = ""
        End If

        If zUtilLogin2.LoadByEmail(UtilSession.ResetPasswordEmailAddress) Then
            If UtilSession.IsLockedDueToBadAttempts Then
                UtilNotification.SubmitUserLockedAccountNotification(zUtilLogin2.GetLoginIdByEmail(UtilSession.ResetPasswordEmailAddress))
            Else
                UtilNotification.SubmitUserResetPasswordNotification(zUtilLogin2.GetLoginIdByEmail(UtilSession.ResetPasswordEmailAddress))
            End If

            UtilSession.Clear()
        End If

    End Sub

End Class