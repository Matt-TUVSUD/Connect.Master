Imports GRC.Connect.Libraries.CoreLib.UtilConstants
Imports GRC.Connect.Libraries.CoreLib.UtilGSafe
Imports GRC.Connect.Libraries.CoreLib.UtilValidate
Imports GRC.Connect.Libraries.CoreLib.UtilPractice

Public Class tab_recdatasheetfeaturesX_nathaz
    Inherits System.Web.UI.Page

    Private Sub ValidatePage()
        CorrectPageCheck(GetGUIDFromQueryString, PageId_LocationDetails_NatHaz, PageId_LocationListing_NatHaz)

    End Sub

    Private Sub loadLists()

    End Sub

    Private Sub loadDefaults()
        SetNaturalHazardsDetailsPractice(GetGUIDFromQueryString())

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