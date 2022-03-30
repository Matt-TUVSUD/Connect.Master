Imports GRC.Connect.Libraries.CoreLib.BusinessObjects
Imports GRC.Connect.Libraries.DataLib.razor

Imports Telerik.Web.UI

Public Class ClientConnectCarousel
    Inherits System.Web.UI.MasterPage
    Implements IPostBackEventHandler

    ' GENERAL DECLARATIONS
    Dim zDefaultNavLinkQry As New NavLinkQuery
    Dim zLink As New NavLink
    Dim zToLevel As Integer
    Dim zCurrentPagePlaceholder As Integer
    'Public ServerSide_IsFullAdmin As String = "false"
    Public ServerSide_AdminTab As String = ""

    Private Sub LoadDefaults()
        ' SET THE TREEVIEW FOR NAVIGATION
        Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Dim zCurrentPage As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.currentPage)
        Dim zCurrentTab As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.currentTab)
        Dim zCurrentLevelId As String = ""
        Dim zParentId As String = ""

        'SHOW OR HIDE BOTTOM BANNER BASED ON ADMIN USER
        'Dim zUserEmail As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.UserEmail)
        'Dim zUserPassword As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.UserPassword)
        'Dim zAdminType = GRC.Connect.Libraries.CoreLib.UtilLogin.GetGRCAdministrator(zUserEmail, zUserPassword)
        Dim zLoginId As Integer = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(UtilGSafe.GetGUIDFromQueryString(), UtilGSafe.KeyName.EzyLoginId)
        Dim zAdminType = GRC.Connect.Libraries.CoreLib.UtilLogin2.GetGRCAdministrator(zLoginId)
        If zAdminType <> "00" Then
            divBottomBannerAdmin.Visible = False
            divBottomBannerNonAdmin.Visible = True
            ServerSide_AdminTab = ""
        Else
            divBottomBannerAdmin.Visible = True
            divBottomBannerNonAdmin.Visible = False
            ServerSide_AdminTab = "Admin"
        End If

        'zDefaultNavLinkQry.Where(zDefaultNavLinkQry.NavLevelId = 1)
        'Me.RadTreeView1.DataSource = GetRadTreeViewData()
        'Me.RadTreeView1.DataTextField = zDefaultNavLinkQry.NavText
        'Me.RadTreeView1.DataValueField = zDefaultNavLinkQry.NavLinkId
        'Me.RadTreeView1.DataFieldID = zDefaultNavLinkQry.NavLinkId
        'Me.RadTreeView1.DataFieldParentID = zDefaultNavLinkQry.NavParentLinkId
        'Me.RadTreeView1.DataNavigateUrlField = zDefaultNavLinkQry.NavUrl
        'Me.DataBind()


        ' CLEAR LOCATION DETAIL NAVIGATION INFORMATION
        UtilGSafe.ClearLocationNavigationInformation(zGUID)

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
        lblLoginName.Text = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.userFullName)
        lblTodaysDate.Text = FormatDateTime(Date.Today(), DateFormat.LongDate)

        'DB - 'Sets the FileNo Gsafe value to empty string when user is at the gauge screen
        GRC.Connect.Libraries.CoreLib.UtilGSafe.ClearGSafeItems(zGUID)

    End Sub

    Private Sub Page_Init(sender As Object, e As System.EventArgs) Handles Me.Init
        'SAID Checker
        Dim zGUID = UtilGSafe.GetGUIDFromQueryString()
        'If GRC.Connect.Libraries.CoreLib.UtilSAID.IsNotSecure(UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.SafeGUID), zGUID) Then
        If GRC.Connect.Libraries.CoreLib.UtilSAID.IsNotSecureWithCookie(UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.SafeGUID), zGUID, Me.Page) Then
            ' *** GRC.Connect.Scott Update 7/30/2015 UPDATED TO GSAFE
            Dim zErrLog As New GRC.Connect.Libraries.CoreLib.UtilErrorLog : zErrLog.CreateSimpleErrorLogRecord(
                UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.LoggedInUserEmail),
                "IsNotSecure hit in file: " & HttpContext.Current.Request.Url.AbsolutePath,
                HttpContext.Current.Request.Url.AbsolutePath,
                "SAID IsNotSecure",
                Request.ServerVariables("REMOTE_ADDR"))
            Response.Redirect("~/Home_{{VER}}/Auth/Resecure.aspx", True)
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Page.Header.DataBind()

        If Not Page.IsPostBack Then
            Call LoadDefaults()
        End If
        Call LoadData()
        Call LoadPlanProjectFileExplorer()

        ' SET THE ICON TEXT LINKS
        Dim zGUID = UtilGSafe.GetGUIDFromQueryString()
        'hypMyPreferences.NavigateUrl = "~/Home_{{VER}}/Grids/FilterPreferences/FilterPreferences.aspx?sid=" & zGUID
        'hypSiteMap.NavigateUrl = "~/Home_{{VER}}/Sitemap/Default.aspx?sid=" & zGUID
        'hypAllReports.NavigateUrl = "~/Home_{{VER}}/Reports/Default.aspx?sid=" & zGUID
        'hypAllData.NavigateUrl = "~/Home_{{VER}}/Exports/Default.aspx?sid=" & zGUID

        ' CREATE EVENTS FOR ICON CLICKS
        'icoMyPreferences.Attributes("onclick") = Me.Page.ClientScript.GetPostBackEventReference(Me, "icoMyPreferences_Click")
        'icoSiteMap.Attributes("onclick") = Me.Page.ClientScript.GetPostBackEventReference(Me, "icoSiteMap_Click")
        'icoAllReports.Attributes("onclick") = Me.Page.ClientScript.GetPostBackEventReference(Me, "icoAllReports_Click")
        'icoAllData.Attributes("onclick") = Me.Page.ClientScript.GetPostBackEventReference(Me, "icoAllData_Click")

    End Sub

    'Private Sub RadTreeView1_NodeClick(sender As Object, e As Telerik.Web.UI.RadTreeNodeEventArgs) Handles RadTreeView1.NodeClick
    '    ' DO NOTHING, LOAD NEXT PAGE
    'End Sub

    'Private Function GetRadTreeViewData() As ViewCCNavLinkCollection
    '    Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()
    '    Dim zCurrentPage As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.currentPage)
    '    Dim zCurrentTab As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.currentTab)
    '    zCurrentPagePlaceholder = Val(zCurrentPage)

    '    zLink.LoadByPrimaryKey(zCurrentPage)
    '    Dim zCurrentLevelId As Integer = zLink.NavLevelId
    '    Dim zPracticeId As Integer = zLink.NavPracticeID

    '    Dim zUtilNavLink As New UtilNavLink(zGUID)
    '    Dim zCol As ViewCCNavLinkCollection = zUtilNavLink.GetLinksByLocation(zCurrentLevelId, zPracticeId).ToCollection
    '    Return zCol

    '    'Return Libraries.CoreLib.UtilNav.GetLinks(zGUID, zPracticeId, zCurrentLevelId)

    'End Function

    'Private Sub RadTreeView1_NodeDataBound(sender As Object, e As Telerik.Web.UI.RadTreeNodeEventArgs) Handles RadTreeView1.NodeDataBound
    '    If Not e Is Nothing Then
    '        Dim zGUID = UtilGSafe.GetGUIDFromQueryString()
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

    '        'CORRECT THE "HOME" FOLDER TO THE REVISION STAMPED FOLDER

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

    '        'SET THE TARGET PARM OF THE LINK
    '        If zLink.NavTarget <> "" Then
    '            e.Node.Target = zLink.NavTarget
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

    '        'CHANGE URL AND COLOR OF RECENT UPDATES
    '        If zLink.NavLinkId = GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_RecentUpdates Then

    '            'ADD DATE AND TITLE URL PARM
    '            Dim zDate As Date = GRC.Connect.Libraries.CoreLib.UtilNav.GetLastRecentUpdateDate(zGUID)
    '            e.Node.NavigateUrl = e.Node.NavigateUrl & "&isrecent=1" ' 'IsR=1" + zDate.ToString("yyyyMMdd") & "&title1=" & "2"

    '            'CHANGE COLOR
    '            Dim zUpdates As Boolean = GRC.Connect.Libraries.CoreLib.UtilNav.IsRecentUpdateAvailable(zGUID, zDate)
    '            If zUpdates = True Then
    '                e.Node.CssClass = "colorRed"
    '            End If
    '        End If

    '        'CHANGE URL AND COLOR OF WHATS NEW
    '        If zLink.NavLinkId = GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_WhatsNew Then
    '            ' CHECK LAST LOGIN DATE TO THE LATEST DATED FILE IN THE FOLDER
    '            Dim zNewItem As Boolean = GRC.Connect.Libraries.CoreLib.UtilNav.IsWhatsNewAvailable(zGUID)
    '            If zNewItem = True Then
    '                e.Node.CssClass = "colorRed"
    '            End If
    '        End If


    '        'CHANGE URL AND COLOR OF MYBATCH REPORTS
    '        If zLink.NavLinkId = GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_myBatchReports Then
    '            ' CHECK LAST LOGIN DATE TO THE LATEST DATED FILE IN THE FOLDER
    '            Dim zUnAccessedCount As List(Of rowVwUnAccessedBatchReports) = VwUnAccessedBatchReports.LoadData("SELECT * FROM sv.VwUnAccessedBatchReports WHERE GSAFEGUID='" & zGUID & "'")
    '            If zUnAccessedCount.Count > 0 Then
    '                e.Node.CssClass = "colorRed"
    '            End If
    '        End If

    '        'ADD PLEASE WAIT POPUP TO THE PROGRAM STATUS LINK
    '        If zLink.NavLinkId = GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_ProgramStatusForm Then
    '            e.Node.Target = "ProgramStatus"
    '        End If

    '        'ADD PLEASE WAIT POPUP TO THE REC FOLLOW UP STATUS LINK
    '        If zLink.NavLinkId = GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_RecFollowUpStatusForm Then
    '            e.Node.Target = "RecFollowUpStatus"
    '        End If

    '        'EXPAND IF BY DEFAULT
    '        If zLink.NavDefaultExpanded = True Then
    '            e.Node.Expanded = True
    '            If zLink.NavLinkId <> GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_ClientAdmin Then
    '                e.Node.CssClass = "selected"
    '            Else
    '                If UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.IsClientAdmin).ToLower() = "true" Then
    '                    e.Node.CssClass = "selected"
    '                End If
    '            End If
    '        End If

    '    End If
    'End Sub

    Private Sub LoadPlanProjectFileExplorer()
        Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString() & ""
        Dim zP1 As String = Request.QueryString("p1") & ""

        flxPlanProjectPicker.Configuration.SearchPatterns = New String() {"*.*"} '{"*.pdf"}
        flxPlanProjectPicker.VisibleControls = GetVisibleControls()
        flxPlanProjectPicker.EnableOpenFile = False
        flxPlanProjectPicker.DisplayUpFolderItem = True
        flxPlanProjectPicker.AllowPaging = False
        flxPlanProjectPicker.EnableCreateNewFolder = False
        For Each ToolBarItem As RadToolBarItem In flxPlanProjectPicker.ToolBar.Items
            If ToolBarItem.Value = "GridView" Then ToolBarItem.Visible = False
            If ToolBarItem.Value = "ThumbnailsView" Then ToolBarItem.Visible = False
        Next

        Dim zExternalPath As String = GRC.Connect.Libraries.CoreLib.UtilSystemParms.ReadExternalFilePath
        Dim zClientCode As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.cldbName)
        flxPlanProjectPicker.Configuration.ViewPaths = SetPath(TrailingChar(zExternalPath & "cldb" & zClientCode, "\"))
        flxPlanProjectPicker.Configuration.ContentProviderTypeName = GetType(CustomFileSystemProvider).AssemblyQualifiedName

    End Sub

    Protected Function GetVisibleControls() As Telerik.Web.UI.FileExplorer.FileExplorerControls
        Dim explorerControls As Telerik.Web.UI.FileExplorer.FileExplorerControls = 0
        explorerControls = explorerControls Or Telerik.Web.UI.FileExplorer.FileExplorerControls.Grid
        explorerControls = explorerControls Or Telerik.Web.UI.FileExplorer.FileExplorerControls.ListView
        explorerControls = explorerControls Or Telerik.Web.UI.FileExplorer.FileExplorerControls.Toolbar
        explorerControls = explorerControls Or Telerik.Web.UI.FileExplorer.FileExplorerControls.TreeView
        Return explorerControls

    End Function

    Private Function TrailingChar(pIn As String, pLastChar As String) As String
        Dim zReturn As String = ""
        Select Case pIn.Length
            Case 0
                zReturn = pIn & pLastChar
            Case Else
                If Right(pIn, 1) = pLastChar Then
                    zReturn = pIn
                Else
                    zReturn = pIn & pLastChar
                End If
        End Select
        Return zReturn
    End Function

    Private Function SetPath(pPath As String) As String()
        Dim zPathArr() As String
        ReDim zPathArr(0)
        zPathArr(0) = pPath
        Return zPathArr
    End Function

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

End Class