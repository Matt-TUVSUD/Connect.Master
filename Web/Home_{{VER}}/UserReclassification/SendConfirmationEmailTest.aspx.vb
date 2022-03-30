Public Class SendConfirmationEmailTest
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Debugger.IsAttached Then
            UtilUserReclassification.SendConfirmationEmail(UtilGSafe.GetGUIDFromQueryString)
        Else
            Response.Redirect("/Home/Auth")
        End If
    End Sub

End Class