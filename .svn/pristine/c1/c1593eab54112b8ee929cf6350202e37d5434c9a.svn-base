Imports GRC.Connect.Libraries.CoreLib.BusinessObjects
Imports GRC.Connect.Libraries.CoreLib.UtilConstants

Imports Telerik.Web.UI


Public Class DefaultSitemap_MultiCall
    Inherits System.Web.UI.Page

    Private Sub ValidatePage()
        Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()
        GRC.Connect.Libraries.CoreLib.UtilValidate.CorrectPageCheck(zGUID, PageId_SiteMap, "")

    End Sub

    Private Sub loadLists()

    End Sub

    Private Sub loadDefaults()
        Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()
        GRC.Connect.Libraries.CoreLib.UtilPractice.SetSiteMapTitle(zGUID)
        'Call modConfig.SetIGConfig(zGUID)

    End Sub

    Private Sub loadData()

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' *** DELETE ME ***
        ' AUTO REDIRECT TO THE MAIN GAUGE PAGE. REMOVE WHEN SITE MAP PAGE IS READY.
        'If Not Request.QueryString("bypass") Is Nothing Then
        '    If Request.QueryString("bypass") = "true" Then
        '        ' DO NOTHING
        '    Else
        '        Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()
        '        Response.Redirect("~/Home_{{VER}}/Gauge/Default.aspx?sid=" & zGUID, True)
        '    End If
        'Else
        '    Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()
        '    Response.Redirect("~/Home_{{VER}}/Gauge/Default.aspx?sid=" & zGUID, True)
        'End If
        ' *** END DELETE ME ***

        Call ValidatePage()

        If Not Page.IsPostBack Then
            Call loadLists()
            Call loadDefaults()
        End If

        Call loadData()
    End Sub

End Class