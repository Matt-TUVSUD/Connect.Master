Public Class Confirm
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Throw New NotImplementedException()

        'Dim zReactivateUserGUID As String = Request.QueryString("i") & ""

        'If zReactivateUserGUID.Length > 0 Then
        '    Dim zEzyUser As New GRC.Connect.Libraries.CoreLib.BusinessObjects.EzyUsers
        '    If zEzyUser.LoadByEzyUserGUID(zReactivateUserGUID) Then
        '        Dim zAM As New GRC.Connect.Libraries.CoreLib.BusinessObjects.EzyUsers.AccountManagement(zEzyUser)
        '        zAM.ReactivateUser()
        '        lblMessage.Text = zEzyUser.FullName & " has been reactivated and you will both receive an email confirmation.<br/>&nbsp;<br/>Thank you."
        '    End If
        'End If
    End Sub

End Class