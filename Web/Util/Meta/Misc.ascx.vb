Public Class Misc
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub ValidateEmails_Click(sender As Object, e As EventArgs) Handles ValidateEmails.Click
        Dim zResult As List(Of String) = UtilValidate.ValidateEmailAddresses
        If zResult.Count > 0 Then
            ValidateResult.Text = Join(zResult.ToArray, "<br>")
        Else
            ValidateResult.Text = "Validation Successful!!"
        End If
    End Sub
End Class