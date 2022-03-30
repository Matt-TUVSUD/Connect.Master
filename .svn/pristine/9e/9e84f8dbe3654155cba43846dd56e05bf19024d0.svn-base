Imports GRC.Connect.Libraries.CoreLib.UtilConstants

Public Class tab_recdatasheetfeaturesL_processsafety
    Inherits System.Web.UI.Page

    Private Sub ValidatePage()
        GRC.Connect.Libraries.CoreLib.UtilValidate.CorrectPageCheck(Request.QueryString("sid"), PageId_LocationDetails_PS, PageId_LocationListing_PS)

    End Sub

    Private Sub loadLists()

    End Sub

    Private Sub loadDefaults()
        GRC.Connect.Libraries.CoreLib.UtilPractice.SetPSPractice(Request.QueryString("sid"))
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