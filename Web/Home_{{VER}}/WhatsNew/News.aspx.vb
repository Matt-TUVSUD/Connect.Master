Public Class News
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim GSafeID = If(Request.QueryString("sid"), String.Empty)
        ContactUsLink.NavigateUrl = "../Contact/default.aspx?sid=" & GSafeID
        GotoServices.PostBackUrl = "../Gauge/default.aspx?sid=" & GSafeID
        GotoDashboard.PostBackUrl = "../Dashboards/dashboardredirect.aspx?sid=" & GSafeID

        Dim zGuid As String = UtilGSafe.GetGUIDFromQueryString
        UtilUpdates.SetWhatsNewLastReviewedDate(zGuid)

        Dim zUserid As Integer = UtilGSafe.GetValue(zGuid, UtilGSafe.KeyName.EzyLoginId)
        UtilDB.LogOtherActivity(zUserid, "News")

    End Sub

End Class