Imports GRC.Connect.Libraries.CoreLib.UtilConstants
Imports GRC.Connect.Libraries.CoreLib.UtilGSafe

Public Class tab_recdatasheet_infared
    Inherits System.Web.UI.Page

    Private Sub ValidatePage()
        'GRC.Connect.Libraries.CoreLib.UtilValidate.CorrectPageCheck(GetGUIDFromQueryString, PageId_RecommendationTracking_Infrared, PageId_LocationListing_Infrared)
        GRC.Connect.Libraries.CoreLib.UtilValidate.CorrectPageCheck(Request.QueryString("sid"), PageId_LocationDetails_Infrared, PageId_LocationListing_Infrared)

    End Sub

    Private Sub loadLists()

    End Sub

    Private Sub loadDefaults()
        'GRC.Connect.Libraries.CoreLib.UtilPractice.SetIRRecommendationTracking(GetGUIDFromQueryString)
        GRC.Connect.Libraries.CoreLib.UtilPractice.SetIRRecommendationTracking(Request.QueryString("sid"))
    End Sub

    Private Sub loadData()

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call ValidatePage()

        If Not Page.IsPostBack Then
            Call loadLists()
            Call loadDefaults()
        End If

        Call loadData()
    End Sub

End Class