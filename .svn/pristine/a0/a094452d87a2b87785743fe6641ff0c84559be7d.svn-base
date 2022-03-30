Public Class whatsNewRedirect
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim zGuid As String = UtilGSafe.GetGUIDFromQueryString
        UtilUpdates.SetWhatsNewLastReviewedDate(zGuid)

        Dim zUserid As Integer = UtilGSafe.GetValue(zGuid, UtilGSafe.KeyName.EzyLoginId)
        UtilDB.LogOtherActivity(zUserid, "WhatsNew")

        'Response.Redirect("index.html")
    End Sub

End Class