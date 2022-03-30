Imports GRC.Connect.Libraries.CoreLib.UtilConstants
Imports GRC.Connect.Libraries.CoreLib.UtilGSafe
Imports GRC.Connect.Libraries.CoreLib.UtilValidate
Imports GRC.Connect.Libraries.CoreLib.UtilPractice

Public Class tab_rectracking_fire
    Inherits System.Web.UI.Page

    Private Sub ValidatePage()
        'CorrectPageCheck(GetGUIDFromQueryString, PageId_RecommendationTracking_Fire, PageId_LocationListing_Fire)
        CorrectPageCheck(GetGUIDFromQueryString, PageId_LocationDetails_Fire, PageId_LocationListing_Fire)

    End Sub

    Private Sub loadLists()

    End Sub

    Private Sub loadDefaults()
        Dim zGUID As String = GetGUIDFromQueryString()
        'SetFireRecommendationTracking(zGUID)
        SetFireDetailsPractice(zGUID)

        Dim zFileNo As String = ""
        If Not Request.QueryString("p1") Is Nothing Then
            If Request.QueryString("p1").Length > 0 Then
                zFileNo = Request.QueryString("p1").ToString
                If IsValidLocation(zGUID, zFileNo) Then
                    UtilGSafe.SetLocationNavigationInformation(zGUID, zFileNo)
                Else
                    Dim zErrLog As New GRC.Connect.Libraries.CoreLib.UtilErrorLog : zErrLog.CreateSimpleErrorLogRecord(GetValue(zGUID, KeyName.LoggedInUserEmail), "IsNotSecure hit in file: " & HttpContext.Current.Request.Url.AbsolutePath, HttpContext.Current.Request.Url.AbsolutePath, "SAID IsNotSecure", Request.ServerVariables("REMOTE_ADDR"))
                    Response.Redirect("~/Home_{{VER}}/Auth/Resecure.aspx", True)
                End If
            End If
        End If

        If Not Request.UrlReferrer Is Nothing Then
            If Request.UrlReferrer.ToString.Length > 0 Then
                If InStr(Request.UrlReferrer.LocalPath.ToLower, "SiteMap/Default.aspx".ToLower) > 0 Then
                    SetValue(zGUID, KeyName.currentGridId, GridId_FireLocationListings, KeyNameGroup.Navigation)
                    SetValue(zGUID, KeyName.NavReturnURL, Request.Url.LocalPath, KeyNameGroup.Session)
                    SetValue(zGUID, KeyName.NavLocationSelectionText, "Please click the Enter link below to select a location to navigate to Recommendations.", KeyNameGroup.Session)
                    Response.Redirect("~/Home_{{VER}}/Grids/LocationListings/LocationListings.aspx?sid=" & zGUID & "&pLandingPage=rectracking", False)
                End If
            End If
        End If

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