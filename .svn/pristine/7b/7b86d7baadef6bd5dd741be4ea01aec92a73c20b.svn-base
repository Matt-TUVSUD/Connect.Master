Imports GRC.Connect.Libraries.CoreLib.BusinessObjects
Imports GRC.Connect.Libraries.DataLib.razor

Imports Telerik.Web.UI

Public Class MasterNoMenu
    Inherits System.Web.UI.MasterPage
    Implements IPostBackEventHandler

    ' GENERAL DECLARATIONS
    Dim zDefaultNavLinkQry As New NavLinkQuery
    Dim zLink As New NavLink
    Dim zToLevel As Integer
    Dim zCurrentPagePlaceholder As Integer
    'Public ServerSide_IsFullAdmin As String = "false"
    Public ServerSide_AdminTab As String = ""
    Public zIsIE As Boolean = False

    Private Sub LoadDefaults()
        ' SET THE TREEVIEW FOR NAVIGATION
        Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Dim zCurrentPage As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.currentPage)
        Dim zCurrentTab As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.currentTab)
        Dim zCurrentLevelId As String = ""
        Dim zParentId As String = ""

        ' CLEAR LOCATION DETAIL NAVIGATION INFORMATION
        UtilGSafe.ClearLocationNavigationInformation(zGUID)

    End Sub

    Private Sub LoadData()
        'THIS SUB IS FOR LOADING HEADER INFORMATION AND OTHER NEW DATA
        ' USE OBJECT NAME objGOCSafe
        Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()

    End Sub

    Private Sub Page_Init(sender As Object, e As System.EventArgs) Handles Me.Init
        'SAID Checker
        Dim zGUID = UtilGSafe.GetGUIDFromQueryString()
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
        'Call LoadPlanProjectFileExplorer()

        ' SET THE ICON TEXT LINKS
        Dim zGUID = UtilGSafe.GetGUIDFromQueryString()
        If HttpContext.Current.Request.Browser.Type = "InternetExplorer11" Then zIsIE = True
    End Sub

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
    '    Dim zClientCode As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.cldbName)
    '    flxPlanProjectPicker.Configuration.ViewPaths = SetPath(TrailingChar(zExternalPath & "cldb" & zClientCode, "\"))
    '    flxPlanProjectPicker.Configuration.ContentProviderTypeName = GetType(CustomFileSystemProvider).AssemblyQualifiedName

    'End Sub

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