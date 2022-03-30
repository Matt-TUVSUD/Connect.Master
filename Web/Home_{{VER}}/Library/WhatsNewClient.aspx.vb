Imports GRC.Connect.Libraries.CoreLib.UtilConstants
Imports GRC.Connect.Libraries.CoreLib.UtilGSafe

Public Class WhatsNewClient
    Inherits System.Web.UI.Page

    Private Sub ValidatePage()
        Libraries.CoreLib.UtilValidate.CorrectPageCheck(GetGUIDFromQueryString, PageId_WhatsNew, PageId_Gauge)

    End Sub

    Private Sub loadLists()

    End Sub

    Private Sub loadDefaults()
        Dim pSafeGUID As String = GetGUIDFromQueryString()
        SetValue(pSafeGUID, KeyName.practiceName, "What's New!", KeyNameGroup.PageHeader)
        SetValue(pSafeGUID, KeyName.currentPage, PageId_WhatsNew, KeyNameGroup.Navigation)
        SetValue(pSafeGUID, KeyName.currentTab, PageId_Gauge, KeyNameGroup.Navigation)

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