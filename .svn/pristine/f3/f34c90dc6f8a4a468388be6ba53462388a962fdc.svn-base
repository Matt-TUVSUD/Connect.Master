Imports GRC.Connect.Libraries.CoreLib.UtilConstants

Public Class tab_recdatasheet_boiler
    Inherits System.Web.UI.Page

    Private Sub ValidatePage()
        'GRC.Connect.Libraries.CoreLib.UtilValidate.CorrectPageCheck(Request.QueryString("sid"), PageId_RecommendationTracking_Boiler, PageId_LocationListing_Boiler)
        GRC.Connect.Libraries.CoreLib.UtilValidate.CorrectPageCheck(Request.QueryString("sid"), PageId_LocationDetails_Boiler, PageId_LocationListing_Boiler)

    End Sub

    Private Sub loadLists()

    End Sub

    Private Sub loadDefaults()
        'GRC.Connect.Libraries.CoreLib.UtilPractice.SetBoilerRecommendationTracking(Request.QueryString("sid"))
        GRC.Connect.Libraries.CoreLib.UtilPractice.SetBoilerDetailsPractice(Request.QueryString("sid"))
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