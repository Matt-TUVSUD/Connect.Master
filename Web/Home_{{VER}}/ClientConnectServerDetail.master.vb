Imports GRC.Connect.Libraries.CoreLib.BusinessObjects

Imports Telerik.Web.UI

Public Class ClientConnectServerDetail
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

        'zDefaultNavLinkQry.Where(zDefaultNavLinkQry.NavLevelId = 1)
        'Me.RadTreeView1.DataSource = GetRadTreeViewData()
        ''Me.RadTreeView1.DataSource = zDefaultNavLinkQry.LoadDataTable
        'Me.RadTreeView1.DataTextField = zDefaultNavLinkQry.NavText
        'Me.RadTreeView1.DataValueField = zDefaultNavLinkQry.NavLinkId
        'Me.RadTreeView1.DataFieldID = zDefaultNavLinkQry.NavLinkId
        'Me.RadTreeView1.DataFieldParentID = zDefaultNavLinkQry.NavParentLinkId
        'Me.RadTreeView1.DataNavigateUrlField = zDefaultNavLinkQry.NavUrl
        'Me.DataBind()

        'SET THE BACKGROUND IMAGE OF THE NAV
        'nav_Container.Style.Add("background-image", GRC.Connect.Libraries.CoreLib.UtilPractice.GetNavPracticeImage(zCurrentTab))
        RadWindow1.BackColor = Drawing.Color.Transparent
        RadWindowManager1.BackColor = Drawing.Color.Transparent


        ' SET THE ISONDETAILPAGE VALUE 
        UtilGSafe.SetValue(zGUID, UtilGSafe.KeyName.IsOnDetailPage, True, UtilGSafe.KeyNameGroup.Navigation)


    End Sub

    Private Sub LoadData()
        Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()

        ' LOOK FOR FILTERS APPLIED
        If GRC.Connect.Libraries.CoreLib.UtilPreference.IsFilterApplied(zGUID) = True Then
            lblPreferencesApplied.Visible = True
        Else
            lblPreferencesApplied.Visible = False
        End If


        'THIS SUB IS FOR LOADING HEADER INFORMATION AND OTHER NEW DATA
        ' USE OBJECT NAME objGOCSafe
        lblCompany.Text = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.ClientName)          ' "ABC Company"
        lblLoginName.Text = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.userFullName)      ' "Gary Kidney"  
        lblTodaysDate.Text = FormatDateTime(Date.Today(), DateFormat.LongDate)
        lblPageTitle.Text = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.practiceName)      ' "Fire Program"

        ' SHOW OR HIDE ROWS OF PREFERENCES BASED ON TYPE OF USER
        Dim zSingleUser As String = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.SingleUser)
        If zSingleUser.ToLower() = "true".ToLower() Then
            divDisableIcons.Visible = True
            divEnableIcons.Visible = False
            divCrumbs.Visible = False
        Else
            divDisableIcons.Visible = False
            divEnableIcons.Visible = True
            divCrumbs.Visible = True
        End If

        Dim CrumbMain As String = Libraries.CoreLib.UtilHTML.CreateCrumbtrailLink("Main", "../Gauge/Default.aspx?sid=" & zGUID)
        Dim CrumbSpacer As String = " "
        Dim CrumbPractice As String = Libraries.CoreLib.UtilHTML.CreateCrumbtrailLink( _
            "Facility Listing", _
             "../" & GRC.Connect.Libraries.CoreLib.UtilPractice.GetPracticeFolderName(UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.currentTab)) & _
            "/Default.aspx?sid=" & zGUID)
        Dim CrumbDetail As String = GRC.Connect.Libraries.CoreLib.UtilNav.GetNavText(Val(UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.currentPage)))
        lblCrumbTrail.Text = CrumbMain & CrumbSpacer & CrumbPractice & CrumbSpacer & CrumbDetail

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
        Call ClearPageTitle()

        ' SET THE ICON TEXT LINKS
        hypMyPreferences.NavigateUrl = "~/Home_{{VER}}/Grids/FilterPreferences/FilterPreferences.aspx?sid=" & zGUID
        hypSiteMap.NavigateUrl = "~/Home_{{VER}}/Sitemap/Default.aspx?sid=" & zGUID
        hypAllReports.NavigateUrl = "~/Home_{{VER}}/Reports/Default.aspx?sid=" & zGUID
        hypAllData.NavigateUrl = "~/Home_{{VER}}/Exports/Default.aspx?sid=" & zGUID

        ' CREATE EVENTS FOR ICON CLICKS
        icoMyPreferences.Attributes("onclick") = Me.Page.ClientScript.GetPostBackEventReference(Me, "icoMyPreferences_Click")
        icoSiteMap.Attributes("onclick") = Me.Page.ClientScript.GetPostBackEventReference(Me, "icoSiteMap_Click")
        icoAllReports.Attributes("onclick") = Me.Page.ClientScript.GetPostBackEventReference(Me, "icoAllReports_Click")
        icoAllData.Attributes("onclick") = Me.Page.ClientScript.GetPostBackEventReference(Me, "icoAllData_Click")

    End Sub

    'Private Sub RadTreeView1_NodeClick(sender As Object, e As Telerik.Web.UI.RadTreeNodeEventArgs) Handles RadTreeView1.NodeClick
    '    ' DO NOTHING, LOAD NEXT PAGE
    'End Sub

    'Private Function GetRadTreeViewData() As ViewCCNavLinkCollection
    '    Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()
    '    Dim zCurrentPage As String = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.currentPage)
    '    Dim zCurrentTab As String = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.currentTab)
    '    zCurrentPagePlaceholder = Val(zCurrentPage)

    '    zLink.LoadByPrimaryKey(zCurrentPage)
    '    Dim zCurrentLevelId As Integer = zLink.NavLevelId
    '    Dim zPracticeId As Integer = zLink.NavPracticeID

    '    'Dim zLinkTable As DataTable = Libraries.CoreLib.UtilNav.GetLinks(zGUID, zPracticeId, zCurrentLevelId)
    '    'Return zLinkTable

    '    Dim zUtilNavLink As New UtilNavLink(zGUID)
    '    Dim zCol As ViewCCNavLinkCollection = zUtilNavLink.GetLinksByLocation(zCurrentLevelId, zPracticeId).ToCollection
    '    Return zCol

    'End Function

    'Private Sub RadTreeView1_NodeDataBound(sender As Object, e As Telerik.Web.UI.RadTreeNodeEventArgs) Handles RadTreeView1.NodeDataBound
    '    Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()

    '    If Not e Is Nothing Then
    '        'CORRECT THE URL AND TARGET OF THE NODE
    '        If e.Node.NavigateUrl <> "" Then
    '            Dim tempUrl = GRC.Connect.Libraries.CoreLib.UtilURL.BuildLeftNavURL(e.Node.NavigateUrl.ToString, zGUID)
    '            e.Node.NavigateUrl = tempUrl
    '            e.Node.Style.Add("text-decoration", "underline")
    '            e.Node.Style.Add("color", "#5b63b7")
    '        Else
    '            ' ADD GUID
    '            e.Node.NavigateUrl = HttpContext.Current.Request.FilePath & "?sid=" & zGUID & "#"
    '        End If

    '        'GET THE LINK
    '        zLink.LoadByPrimaryKey(e.Node.Value)

    '        ' IF EXIST, ADD TEH CHART, REPORT, GRID, AND EXTRACT IDs
    '        If Not zLink.NavGridId Is Nothing Then
    '            e.Node.NavigateUrl = e.Node.NavigateUrl & "&gridId=" & zLink.NavGridId
    '        End If
    '        If Not zLink.NavChartId Is Nothing Then
    '            e.Node.NavigateUrl = e.Node.NavigateUrl & "&chartId=" & zLink.NavChartId
    '        End If
    '        If Not zLink.NavRptCode Is Nothing Then
    '            e.Node.NavigateUrl = e.Node.NavigateUrl & "&reportId=" & zLink.NavRptCode
    '        End If
    '        If Not zLink.NavExtractId Is Nothing Then
    '            e.Node.NavigateUrl = e.Node.NavigateUrl & "&extractId=" & zLink.NavExtractId
    '        End If

    '        'EXPAND IF BY DEFALUT
    '        If zLink.NavDefaultExpanded = True Then
    '            e.Node.Expanded = True
    '            e.Node.CssClass = "selected"
    '        End If

    '        'SET THE TARGET PARM OF THE LINK
    '        If zLink.NavTarget <> "" Then
    '            e.Node.Target = zLink.NavTarget
    '        End If

    '        'SET THE NODE TARGET FOR SINGLE REPORT SERVE
    '        If Not zLink.NavUrl Is Nothing Then
    '            If zLink.NavUrl.ToLower().Contains("reports/singlereport.aspx") Then
    '                e.Node.Target = "SingleReport"
    '            End If
    '        End If

    '        'BOLD CURRENT PAGE
    '        If e.Node.Value = zCurrentPagePlaceholder Then
    '            e.Node.CssClass = "selected"
    '        End If

    '        'SMALL FONTS ON THIRD LEVEL
    '        Try
    '            If e.Node.Level > 1 Then
    '                e.Node.Style.Add("font-size", "10px") '8pt WORKS 7pt IS TOO SMALL
    '            End If
    '        Catch ex As Exception
    '            'e.Node.Level IS NOT DEFINED, SO DO NOTHING
    '        End Try

    '        'HIDE CLIENT ADMIN LINKS IF NOT LOGGED IN AS CLIENT ADMIN
    '        If zLink.NavParentLinkId = GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_ClientAdmin Then
    '            If UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.IsClientAdmin).ToLower() <> "true" Then
    '                e.Node.Remove()
    '            End If
    '        End If

    '    End If
    'End Sub

    ' RAISE AN EVENT FOR THE ICON CLICKS
    Public Sub RaisePostBackEvent1(ByVal eventArgument As String) Implements IPostBackEventHandler.RaisePostBackEvent
        Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Select Case eventArgument
            Case "icoMyPreferences_Click"
                Response.Redirect("~/Home_{{VER}}/Grids/FilterPreferences/FilterPreferences.aspx?sid=" & zSafeGUID, False)
            Case "icoSiteMap_Click"
                Response.Redirect("~/Home_{{VER}}/Sitemap/Default.aspx?sid=" & zSafeGUID, False)
            Case "icoAllReports_Click"
                Response.Redirect("~/Home_{{VER}}/Reports/Default.aspx?sid=" & zSafeGUID, False)
            Case "icoAllData_Click"
                Response.Redirect("~/Home_{{VER}}/Exports/Default.aspx?sid=" & zSafeGUID, False)
        End Select

    End Sub

    Private Sub ClearPageTitle()
        'WE ARE CLEARING THE GSAFEDETAIL PAGETITLE INFO SO AS NOT TO CONFLICT WHEN RUNNING THE TOTAL 
        'FACILITY SCORE CHART ON THE LOCATION LEVEL.'
        'SEE CODE ON PREFILTER PAGE LINE 622. 
        Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString() & ""
        UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.PageTitle, "", UtilGSafe.KeyNameGroup.PageHeader)
    End Sub
End Class
