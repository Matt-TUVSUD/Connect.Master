Imports GRC.Connect.Libraries.CoreLib.UtilConstants
Imports GRC.Connect.Libraries.CoreLib.UtilGSafe
Imports GRC.Connect.Libraries.CoreLib.UtilValidate
Imports GRC.Connect.Libraries.CoreLib.UtilPractice

Public Class tab_recdatasheetfeaturesX_fire
    Inherits System.Web.UI.Page

    Private Sub ValidatePage()
        'GRC.Connect.Libraries.CoreLib.UtilValidate.CorrectPageCheck(GetGUIDFromQueryString, PageId_RecommendationTracking_Fire_Feature_X, PageId_LocationListing_Fire)
        CorrectPageCheck(GetGUIDFromQueryString, PageId_LocationDetails_Fire, PageId_LocationListing_Fire)

    End Sub

    Private Sub loadLists()

    End Sub

    Private Sub loadDefaults()
        'GRC.Connect.Libraries.CoreLib.UtilPractice.SetFireRecommendationTracking_FeatureX(GetGUIDFromQueryString)
        SetFireDetailsPractice(GetGUIDFromQueryString())

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