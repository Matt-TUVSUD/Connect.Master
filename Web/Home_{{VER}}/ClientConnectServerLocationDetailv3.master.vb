Imports GRC.Connect.Libraries.CoreLib.BusinessObjects

Imports Telerik.Web.UI

Public Class ClientConnectServerLocationDetail_v3
    Inherits System.Web.UI.MasterPage
    'Implements IPostBackEventHandler

    '' GENERAL DECLARATIONS
    'Dim zDefaultNavLinkQry As New NavLinkQuery
    'Dim zLink As New NavLink
    'Dim zToLevel As Integer
    'Dim zCurrentPagePlaceholder As Integer
    'Public ServerSide_AdminTab As String = ""


    Private Sub LoadDefaults()
        '' SET THE TREEVIEW FOR NAVIGATION
        'Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()
        'Dim zCurrentPage As String = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.currentPage)
        'Dim zCurrentTab As String = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.currentTab)
        'Dim zCurrentLevelId As String = ""
        'Dim zParentId As String = ""
        ''SET THE BACKGROUND IMAGE OF THE NAV
        'RadWindow1.BackColor = Drawing.Color.Transparent
        'RadWindowManager1.BackColor = Drawing.Color.Transparent
        ''SHOW OR HIDE BOTTOM BANNER BASED ON ADMIN USER
        'Dim zLoginId As Integer = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(UtilGSafe.GetGUIDFromQueryString(), UtilGSafe.KeyName.EzyLoginId)
        'Dim zAdminType = GRC.Connect.Libraries.CoreLib.UtilLogin2.GetGRCAdministrator(zLoginId)
        'If zAdminType <> "00" Then
        '    divBottomBannerAdmin.Visible = False
        '    divBottomBannerNonAdmin.Visible = True
        '    spanTopBanner.Visible = True
        '    spanTopBannerAdmin.Visible = False
        '    ServerSide_AdminTab = ""
        'Else
        '    divBottomBannerAdmin.Visible = True
        '    divBottomBannerNonAdmin.Visible = False
        '    spanTopBanner.Visible = False
        '    spanTopBannerAdmin.Visible = True
        '    ServerSide_AdminTab = "Admin"
        'End If
    End Sub

    'Private Sub LoadData()
    '    Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()
    '    'THIS SUB IS FOR LOADING HEADER INFORMATION AND OTHER NEW DATA
    '    ' USE OBJECT NAME objGOCSafe
    '    lblCompany.Text = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.ClientName)          ' "ABC Company"
    '    lblLoginName.Text = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.userFullName)      ' "Gary Kidney"  
    '    lblTodaysDate.Text = FormatDateTime(Date.Today(), DateFormat.LongDate)
    '    lblPageTitle.Text = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.practiceName)      ' "Fire Program"
    '    ' SHOW OR HIDE ROWS OF PREFERENCES BASED ON TYPE OF USER
    '    Dim zSingleUser As String = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.SingleUser)
    '    Dim CrumbMain As String = Libraries.CoreLib.UtilHTML.CreateCrumbtrailLink("Main", "../Gauge/Default.aspx?sid=" & zGUID)
    '    Dim CrumbSpacer As String = " "
    '    Dim CrumbPractice As String = Libraries.CoreLib.UtilHTML.CreateCrumbtrailLink( _
    '        "Location Listing", _
    '         "../" & GRC.Connect.Libraries.CoreLib.UtilPractice.GetPracticeFolderName(UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.currentTab)) & _
    '        "/Default.aspx?sid=" & zGUID)
    '    Dim CrumbDetail As String = "Location Details"
    '    lblCrumbTrail.Text = CrumbMain & CrumbSpacer & CrumbPractice & CrumbSpacer & CrumbDetail
    '  ' LOOK FOR FILTERS APPLIED
    'If GRC.Connect.Libraries.CoreLib.UtilPreference.IsFilterApplied(zGUID) = True Then
    '	lblPreferencesApplied.Visible = True
    'Else
    '	lblPreferencesApplied.Visible = False
    'End If

    'End Sub

    'Public Sub RaisePostBackEvent1(ByVal eventArgument As String) Implements IPostBackEventHandler.RaisePostBackEvent
    '    ' RAISE AN EVENT FOR THE ICON CLICKS
    '    Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()
    '    Select Case eventArgument
    '        Case "icoMyPreferences_Click"
    '            Response.Redirect("~/Home_{{VER}}/Grids/FilterPreferences/FilterPreferences.aspx?sid=" & zGUID, False)
    '        Case "icoSiteMap_Click"
    '            Response.Redirect("~/Home_{{VER}}/Sitemap/Default.aspx?sid=" & zGUID, False)
    '        Case "icoAllReports_Click"
    '            Response.Redirect("~/Home_{{VER}}/Reports/Default.aspx?sid=" & zGUID, False)
    '        Case "icoAllData_Click"
    '            Response.Redirect("~/Home_{{VER}}/Exports/Default.aspx?sid=" & zGUID, False)
    '    End Select
    'End Sub

    'Private Sub Page_Init(sender As Object, e As System.EventArgs) Handles Me.Init
    '    'SAID Checker
    '    Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()
    '            If GRC.Connect.Libraries.CoreLib.UtilSAID.IsNotSecureWithCookie(UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.SafeGUID), zGUID, Me.Page) Then
    '        Response.Redirect("~/Home_{{VER}}/Auth/Resecure.aspx", False)
    '    End If
    'End Sub

    'Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    Page.Header.DataBind()
    '    If Not Page.IsPostBack Then
    '        Call LoadDefaults()
    '    End If
    '    Call LoadData()
    '    Call LoadReportFileExplorer()
    '    Call LoadDiagramFileExplorer()
    '    Call LoadPlanProjectFileExplorer()
    '    Call ClearPageTitle()
    'End Sub

    'Private Sub LoadPlanProjectFileExplorer()
    '    Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString() & ""
    '    Dim zP1 As String = Request.QueryString("p1") & ""
    '    flxPlanProjectPicker.Configuration.SearchPatterns = New String() {"*.*"} '{"*.pdf"}
    '    flxPlanProjectPicker.VisibleControls = GetVisibleControls()
    '    flxPlanProjectPicker.EnableOpenFile = False
    '    flxPlanProjectPicker.DisplayUpFolderItem = True
    '    flxPlanProjectPicker.AllowPaging = False
    '    flxPlanProjectPicker.EnableCreateNewFolder = False
    '    For Each ToolBarItem As RadToolBarItem In flxPlanProjectPicker.ToolBar.Items
    '        If ToolBarItem.Value = "GridView" Then ToolBarItem.Visible = False
    '        If ToolBarItem.Value = "ThumbnailsView" Then ToolBarItem.Visible = False
    '    Next
    '    Dim zExternalPath As String = GRC.Connect.Libraries.CoreLib.UtilSystemParms.ReadExternalFilePath
    '    Dim zClientCode As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.cldbName)
    '    flxPlanProjectPicker.Configuration.ViewPaths = SetPath(TrailingChar(zExternalPath & "cldb" & zClientCode, "\"))
    '    flxPlanProjectPicker.Configuration.ContentProviderTypeName = GetType(CustomFileSystemProvider).AssemblyQualifiedName
    'End Sub

    'Private Sub LoadReportFileExplorer()
    '    Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString() & ""
    '    Dim zP1 As String = Request.QueryString("p1") & ""
    '    flxDocManager_Report.Configuration.SearchPatterns = New String() {"*.pdf"} '{"*.*"}
    '    flxDocManager_Report.VisibleControls = GetVisibleControls()
    '    flxDocManager_Report.EnableOpenFile = False
    '    flxDocManager_Report.DisplayUpFolderItem = True
    '    flxDocManager_Report.AllowPaging = False
    '    flxDocManager_Report.EnableCreateNewFolder = False
    '    For Each ToolBarItem As RadToolBarItem In flxDocManager_Report.ToolBar.Items
    '        If ToolBarItem.Value = "GridView" Then ToolBarItem.Visible = False
    '        If ToolBarItem.Value = "ThumbnailsView" Then ToolBarItem.Visible = False
    '    Next
    '    Dim zExternalPath As String = GRC.Connect.Libraries.CoreLib.UtilSystemParms.ReadExternalFilePath
    '    Dim zClientCode As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.cldbName)
    '    flxDocManager_Report.Configuration.ViewPaths = SetPath(TrailingChar(zExternalPath & "cldb" & zClientCode, "\"))
    '    flxDocManager_Report.Configuration.ContentProviderTypeName = GetType(CustomFileSystemProvider).AssemblyQualifiedName
    'End Sub

    'Private Sub LoadDiagramFileExplorer()
    '    Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString() & ""
    '    Dim zP1 As String = Request.QueryString("p1") & ""
    '    flxDocManager_Diagram.Configuration.SearchPatterns = New String() {"*.pdf"} '{"*.*"}
    '    flxDocManager_Diagram.VisibleControls = GetVisibleControls()
    '    flxDocManager_Diagram.EnableOpenFile = False
    '    flxDocManager_Diagram.DisplayUpFolderItem = True
    '    flxDocManager_Diagram.AllowPaging = False
    '    flxDocManager_Diagram.EnableCreateNewFolder = False
    '    For Each ToolBarItem As RadToolBarItem In flxDocManager_Diagram.ToolBar.Items
    '        If ToolBarItem.Value = "GridView" Then ToolBarItem.Visible = False
    '        If ToolBarItem.Value = "ThumbnailsView" Then ToolBarItem.Visible = False
    '    Next
    '    Dim zExternalPath As String = GRC.Connect.Libraries.CoreLib.UtilSystemParms.ReadExternalFilePath
    '    Dim zClientCode As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.cldbName)
    '    flxDocManager_Diagram.Configuration.ViewPaths = SetPath(TrailingChar(zExternalPath & "cldb" & zClientCode, "\"))  ', "\Diagrams\"))
    '    flxDocManager_Diagram.Configuration.ContentProviderTypeName = GetType(CustomFileSystemProvider).AssemblyQualifiedName
    'End Sub

    'Protected Function GetVisibleControls() As Telerik.Web.UI.FileExplorer.FileExplorerControls
    '    Dim explorerControls As Telerik.Web.UI.FileExplorer.FileExplorerControls = 0
    '    explorerControls = explorerControls Or Telerik.Web.UI.FileExplorer.FileExplorerControls.Grid
    '    explorerControls = explorerControls Or Telerik.Web.UI.FileExplorer.FileExplorerControls.ListView
    '    explorerControls = explorerControls Or Telerik.Web.UI.FileExplorer.FileExplorerControls.Toolbar
    '    explorerControls = explorerControls Or Telerik.Web.UI.FileExplorer.FileExplorerControls.TreeView
    '    Return explorerControls
    'End Function

    'Private Function TrailingChar(pIn As String, pLastChar As String) As String
    '    Dim zReturn As String = ""
    '    Select Case pIn.Length
    '        Case 0
    '            zReturn = pIn & pLastChar
    '        Case Else
    '            If Right(pIn, 1) = pLastChar Then
    '                zReturn = pIn
    '            Else
    '                zReturn = pIn & pLastChar
    '            End If
    '    End Select
    '    Return zReturn
    'End Function

    'Private Function SetPath(pPath As String) As String()
    '    Dim zPathArr() As String
    '    ReDim zPathArr(0)
    '    zPathArr(0) = pPath
    '    Return zPathArr
    'End Function

    'Private Sub ClearPageTitle()
    '    'WE ARE CLEARING THE GSAFEDETAIL PAGETITLE INFO SO AS NOT TO CONFLICT WHEN RUNNING THE TOTAL 
    '    'FACILITY SCORE CHART ON THE LOCATION LEVEL.'
    '    'SEE CODE ON PREFILTER PAGE LINE 622. 
    '    Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString() & ""
    '    UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.PageTitle, "", UtilGSafe.KeyNameGroup.PageHeader)
    'End Sub
End Class