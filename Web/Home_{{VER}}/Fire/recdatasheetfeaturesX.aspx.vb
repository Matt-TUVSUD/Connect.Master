Imports GRC.Connect.Libraries.CoreLib.UtilConstants
Imports GRC.Connect.Libraries.CoreLib.UtilGSafe

Public Class recdatasheet_fire_featuresX
    Inherits System.Web.UI.Page

    Private Sub ValidatePage()
        GRC.Connect.Libraries.CoreLib.UtilValidate.CorrectPageCheck(GetGUIDFromQueryString, PageId_RecommendationTracking_Fire_Feature_X, PageId_LocationListing_Fire)

    End Sub

    Private Sub loadLists()

    End Sub

    Private Sub loadDefaults()
        GRC.Connect.Libraries.CoreLib.UtilPractice.SetFireRecommendationTracking_FeatureX(GetGUIDFromQueryString)
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