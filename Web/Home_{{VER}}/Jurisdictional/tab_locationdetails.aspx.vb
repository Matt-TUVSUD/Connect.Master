Imports GRC.Connect.Libraries.CoreLib.UtilConstants
Imports GRC.Connect.Libraries.CoreLib.UtilGSafe
Imports GRC.Connect.Libraries.CoreLib.UtilValidate
Imports GRC.Connect.Libraries.CoreLib.UtilPractice

Public Class tab_locationdetails_juris
    Inherits System.Web.UI.Page

    Private Sub ValidatePage()
        CorrectPageCheck(GetGUIDFromQueryString, PageId_LocationDetails_Juris, PageId_LocationListing_Juris)

    End Sub

    Private Sub loadLists()

    End Sub

    Private Sub loadDefaults()
        Dim zGUID As String = GetGUIDFromQueryString()
        SetJurisDetailsPractice(zGUID)

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
                    SetValue(zGUID, KeyName.NavReturnURL, Request.Url.LocalPath, KeyNameGroup.Session)
                    SetValue(zGUID, KeyName.currentGridId, GridId_JurisLocationListings, KeyNameGroup.Navigation)
                    SetValue(zGUID, KeyName.NavLocationSelectionText, "Please click the Enter link below to select a location to navigate to Location Details.", KeyNameGroup.Session)
                    Response.Redirect("~/Home_{{VER}}/Grids/LocationListings/LocationListings.aspx?sid=" & zGUID & "&pLandingPage=locationdetails", False)
                End If
            End If
        End If

        'SHOW OR HIDE BOTTOM BANNER BASED ON ADMIN USER
        'Dim IsAdmin As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(Request.QueryString("sid"), "AdminUser").ToLower()
        'Dim zUserEmail As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(Request.QueryString("sid"), "UserEmail")
        'Dim zUserPassword As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(Request.QueryString("sid"), "UserPassword")
        'Dim zAdminType = GRC.Connect.Libraries.CoreLib.UtilLogin.GetGRCAdministrator(zUserEmail, zUserPassword)
        'If zAdminType <> "00" Then
        '    divBottomBannerAdmin.Visible = False
        '    divBottomBannerNonAdmin.Visible = True
        'Else
        '    divBottomBannerAdmin.Visible = True
        '    divBottomBannerNonAdmin.Visible = False
        'End If

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