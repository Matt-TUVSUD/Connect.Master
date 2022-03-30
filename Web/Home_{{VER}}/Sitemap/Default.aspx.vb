Imports GRC.Connect.Libraries.CoreLib.BusinessObjects
Imports GRC.Connect.Libraries.CoreLib.UtilConstants

Imports Telerik.Web.UI


Public Class DefaultSitemap_OneCall
    Inherits System.Web.UI.Page

    Private Sub ValidatePage()
        Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()
        GRC.Connect.Libraries.CoreLib.UtilValidate.CorrectPageCheck(zGUID, PageId_SiteMap, "")

    End Sub

    Private Sub loadLists()

    End Sub

    Private Sub loadDefaults()
        Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Dim zSafeID As Integer = UtilGSafe.GetId(zSafeGUID)
        GRC.Connect.Libraries.CoreLib.UtilPractice.SetSiteMapTitle(zSafeGUID)
        ' CLEAR THE FILTER OBJECTS IN THE LARGE OBJECTS TABLE
        UtilSafe.ResetLargeObjectData_ByObjectName(zSafeID, UtilSafe.LargeObjectName.filter)
        UtilSafe.ResetLargeObjectData_ByObjectName(zSafeID, UtilSafe.LargeObjectName.filterChart)
        UtilSafe.ResetLargeObjectData_ByObjectName(zSafeID, UtilSafe.LargeObjectName.virtualFilter)
        UtilSafe.ResetLargeObjectData_ByObjectName(zSafeID, UtilSafe.LargeObjectName.virtualFilterChart)

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