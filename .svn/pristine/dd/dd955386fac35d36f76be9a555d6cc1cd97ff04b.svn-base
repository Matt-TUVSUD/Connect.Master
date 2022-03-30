Imports GRC.Connect.Libraries.CoreLib.UtilConstants
Imports GRC.Connect.Libraries.CoreLib.UtilGSafe

Public Class WhatsNew
    Inherits System.Web.UI.Page

    Private Sub ValidatePage()
        UtilValidate.CorrectPageCheck(GetGUIDFromQueryString, PageId_WhatsNew, PageId_Gauge)

    End Sub

    Private Sub LoadDefaults()

        Dim zSafeGUID As String = GetGUIDFromQueryString()
        lblInstructions.Text = "Double click the document below to open the 'What's New' article."
        lblContentTitle.Text = "What's New!"
        SetValue(zSafeGUID, KeyName.practiceName, "What's New!", KeyNameGroup.PageHeader)
        SetValue(zSafeGUID, KeyName.currentPage, PageId_WhatsNew, KeyNameGroup.Navigation)
        SetValue(zSafeGUID, KeyName.currentTab, PageId_Gauge, KeyNameGroup.Navigation)


        FileExplorer1.Configuration.SearchPatterns = New String() {"*.pdf", "*.ppt", "*.pptx"}  'New String() {"*.*"}  'New String() {"*.jpg", "*.jpeg", "*.gif", "*.png"}
        FileExplorer1.VisibleControls = GetVisibleControls()
        FileExplorer1.EnableOpenFile = False
        FileExplorer1.DisplayUpFolderItem = True
        FileExplorer1.AllowPaging = False
        FileExplorer1.EnableCreateNewFolder = False

        If (FileExplorer1.VisibleControls And Telerik.Web.UI.FileExplorer.FileExplorerControls.Grid) = 0 Then
            FileExplorer1.ExplorerMode = Telerik.Web.UI.FileExplorer.FileExplorerMode.Thumbnails
        End If
        If (FileExplorer1.VisibleControls And Telerik.Web.UI.FileExplorer.FileExplorerControls.ListView) = 0 Then
            FileExplorer1.ExplorerMode = Telerik.Web.UI.FileExplorer.FileExplorerMode.[Default]
        End If

        Dim zExternalPath As String = GRC.Connect.Libraries.CoreLib.UtilSystemParms.ExternalWhatsNewPath  ' "\\Extra-data\ClientsWEB_D\data\WhatsNew"

        FileExplorer1.Configuration.ViewPaths = SetPath(TrailingChar(zExternalPath, "\"))
        EventLog.WriteEntry("Application", "WhatsNewPath:" & FileExplorer1.Configuration.ViewPaths(0), EventLogEntryType.Information)

        FileExplorer1.Configuration.ContentProviderTypeName = GetType(CustomFileSystemProvider).AssemblyQualifiedName

    End Sub

    Private Sub LoadData()

    End Sub

    Private Sub LoadLists()

    End Sub

    Private Sub WhatsNew_Init(sender As Object, e As System.EventArgs) Handles Me.Init
        IsPagePostBack.Value = Page.IsPostBack.ToString.ToLower()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call ValidatePage()

        If Not Page.IsPostBack Then
            Call LoadLists()
            Call LoadDefaults()
            IsPagePostBack.Value = Page.IsPostBack.ToString.ToLower()
        Else
            'PREVENT CLIENT SIDE FILE EXPLORER FROM AUTOMATICALLY DOWNLOADING FILE ON POSTBACK
            IsPagePostBack.Value = Page.IsPostBack.ToString.ToLower()
        End If

        Call LoadData()

    End Sub

    Private Function SetPath(pPath As String) As String()
        Dim zPathArr() As String
        ReDim zPathArr(0)
        zPathArr(0) = pPath
        Return zPathArr
    End Function

    Protected Function GetVisibleControls() As Telerik.Web.UI.FileExplorer.FileExplorerControls
        Dim explorerControls As Telerik.Web.UI.FileExplorer.FileExplorerControls = 0
        'explorerControls = explorerControls Or Telerik.Web.UI.FileExplorer.FileExplorerControls.AddressBox
        explorerControls = explorerControls Or Telerik.Web.UI.FileExplorer.FileExplorerControls.Grid
        explorerControls = explorerControls Or Telerik.Web.UI.FileExplorer.FileExplorerControls.ListView
        explorerControls = explorerControls Or Telerik.Web.UI.FileExplorer.FileExplorerControls.Toolbar
        'explorerControls = explorerControls Or Telerik.Web.UI.FileExplorer.FileExplorerControls.TreeView
        'explorerControls = explorerControls Or Telerik.Web.UI.FileExplorer.FileExplorerControls.ContextMenus
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

End Class