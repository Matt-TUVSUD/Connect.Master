Imports GRC.Connect.Libraries.CoreLib.UtilGSafe

Public Class DashboardRedirect
    Inherits System.Web.UI.Page

    Dim destination As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim zGSafeGuid As String = GetGUIDFromQueryString()

        Dim zUserid As Integer = UtilGSafe.GetValue(zGSafeGuid, UtilGSafe.KeyName.EzyLoginId)
        UtilDB.LogOtherActivity(zUserid, "Dashboard")

        Dim isDataInCloud As Boolean = UtilDB.DashboardDimUserUpdate(zGSafeGuid)

        'destination = UtilSystemParms.ReadDashboardUrl + "?gsid=" + zGSafeGuid
        destination = "~/Home_{{VER}}/Dashboards/Manage.aspx?sid=" + zGSafeGuid

        If isDataInCloud Then
            Response.Redirect(destination)
        End If

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Response.Redirect(destination)
    End Sub

End Class