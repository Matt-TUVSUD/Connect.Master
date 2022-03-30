Imports GRC.Connect.Libraries.CoreLib.BusinessObjects

Imports Telerik.Web.UI

Public Class ClientConnectServerLocationList
    Inherits System.Web.UI.MasterPage
    Implements IPostBackEventHandler

    ' GENERAL DECLARATIONS
    Dim zDefaultNavLinkQry As New NavLinkQuery
    Dim zLink As New NavLink
    Dim zToLevel As Integer
    Dim zCurrentPagePlaceholder As Integer

    Private Sub LoadDefaults()
        ' SET THE TREEVIEW FOR NAVIGATION
        Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Dim zCurrentPage As String = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.currentPage)
        Dim zCurrentTab As String = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.currentTab)
        Dim zCurrentLevelId As String = ""
        Dim zParentId As String = ""

        ' CLEAR LOCATION DETAIL NAVIGATION INFORMATION
        UtilGSafe.ClearLocationNavigationInformation(zGUID)


    End Sub

    Private Sub LoadData()
        Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()

        'THIS SUB IS FOR LOADING HEADER INFORMATION AND OTHER NEW DATA
        ' USE OBJECT NAME objGOCSafe
        lblCompany.Text = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.ClientName)          ' "ABC Company"
        lblLoginName.Text = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.userFullName)      ' "Gary Kidney"  
        lblTodaysDate.Text = FormatDateTime(Date.Today(), DateFormat.LongDate)
        lblPageTitle.Text = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.practiceName)      ' "Fire Program"

		' LOOK FOR FILTERS APPLIED
        If GRC.Connect.Libraries.CoreLib.UtilPreference.IsFilterApplied(zGUID) = True Then
            lblPreferencesApplied.Visible = True
        Else
            lblPreferencesApplied.Visible = False
        End If

        Dim CrumbMain As String = Libraries.CoreLib.UtilHTML.CreateCrumbtrailLink("Main", "../Gauge/Default.aspx?sid=" & zGUID)
        Dim CrumbSpacer As String = " "
        Dim CrumbPractice As String = Libraries.CoreLib.UtilHTML.CreateCrumbtrailLink( _
            GRC.Connect.Libraries.CoreLib.UtilNav.GetNavText(Val(UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.currentPage))), _
             "../" & GRC.Connect.Libraries.CoreLib.UtilPractice.GetPracticeFolderName(UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.currentTab)) & _
            "/Default.aspx?sid=" & zGUID)
        lblCrumbTrail.Text = CrumbMain & CrumbSpacer & CrumbPractice

        'DB - 'Sets the FileNo Gsafe value to empty string when user is at the gauge screen
        UtilGSafe.ClearGSafeItems(zGUID)


    End Sub

    Private Sub Page_Init(sender As Object, e As System.EventArgs) Handles Me.Init
        'SAID Checker
        Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()
        'If GRC.Connect.Libraries.CoreLib.UtilSAID.IsNotSecure(UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.SafeGUID), zGUID) Then
        If GRC.Connect.Libraries.CoreLib.UtilSAID.IsNotSecureWithCookie(UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.SafeGUID), zGUID, Me.Page) Then
            Response.Redirect("~/Home_{{VER}}/Auth/Resecure.aspx", False)
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()

        Page.Header.DataBind()

        If Not Page.IsPostBack Then
            Call LoadDefaults()
        End If
        Call LoadData()

        ' SET THE ICON TEXT LINKS
        ' hypMyPreferences.NavigateUrl = "~/Home_{{VER}}/Grids/FilterPreferences/FilterPreferences.aspx?sid=" & zGUID
        ' hypSiteMap.NavigateUrl = "~/Home_{{VER}}/Sitemap/Default.aspx?sid=" & zGUID
        ' hypAllReports.NavigateUrl = "~/Home_{{VER}}/Reports/Default.aspx?sid=" & zGUID
        ' hypAllData.NavigateUrl = "~/Home_{{VER}}/Exports/Default.aspx?sid=" & zGUID

        ' CREATE EVENTS FOR ICON CLICKS
        'icoMyPreferences.Attributes("onclick") = Me.Page.ClientScript.GetPostBackEventReference(Me, "icoMyPreferences_Click")
        'icoSiteMap.Attributes("onclick") = Me.Page.ClientScript.GetPostBackEventReference(Me, "icoSiteMap_Click")
        'icoAllReports.Attributes("onclick") = Me.Page.ClientScript.GetPostBackEventReference(Me, "icoAllReports_Click")
        'icoAllData.Attributes("onclick") = Me.Page.ClientScript.GetPostBackEventReference(Me, "icoAllData_Click")

    End Sub

    ' RAISE AN EVENT FOR THE ICON CLICKS
    Public Sub RaisePostBackEvent1(ByVal eventArgument As String) Implements IPostBackEventHandler.RaisePostBackEvent
        Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Select Case eventArgument
            Case "icoMyPreferences_Click"
                Response.Redirect("~/Home_{{VER}}/Grids/FilterPreferences/FilterPreferences.aspx?sid=" & zGUID, False)
            Case "icoSiteMap_Click"
                Response.Redirect("~/Home_{{VER}}/Sitemap/Default.aspx?sid=" & zGUID, False)
            Case "icoAllReports_Click"
                Response.Redirect("~/Home_{{VER}}/Reports/Default.aspx?sid=" & zGUID, False)
            Case "icoAllData_Click"
                Response.Redirect("~/Home_{{VER}}/Exports/Default.aspx?sid=" & zGUID, False)
        End Select

    End Sub

End Class