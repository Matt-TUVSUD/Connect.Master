Imports System
Imports System.IO
Imports System.Web
Imports System.Collections.Generic
Imports Telerik.Web.UI.Widgets
Imports Telerik.Web.UI


Public Class DefaultExplorerPage
    Inherits System.Web.UI.Page

    Private Sub LoadDefaults()
        Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString 'Request.QueryString("sid") & ""
        Dim zP1 As String = Request.QueryString("p1") & "" '4


        Dim zUserid As Integer = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.EzyLoginId)

        FileExplorer1.Configuration.SearchPatterns = New String() {"*.*"}  ' New String() {"*.jpg", "*.jpeg", "*.gif", "*.png"}
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

        Dim zExternalPath As String = UtilSystemParms.ReadExternalFilePath  ' "\\Extra-data\ClientsWEB_D\data\cldbABCDEMO"
        Dim zClientCode As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.cldbName)
        Dim zTargetFolder As String = ""
        If zP1.Length > 0 Then
            Select Case zP1
                Case 1  'Client Information
                    zTargetFolder = "Client Information"
                    UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.practiceName, "Client Information", UtilGSafe.KeyNameGroup.PageHeader)
                    lblInstructions.Text = "The Client Library is used to store and share information regarding your Loss Control Program."
                    FileExplorer1.Configuration.ViewPaths = SetPath(TrailingChar(zExternalPath & "cldb" & zClientCode, "\") & zTargetFolder)
                    FileExplorer1.Configuration.ContentProviderTypeName = GetType(CustomFileSystemProvider).AssemblyQualifiedName
                    Dim Columns = New Telerik.Web.UI.GridTemplateColumn()
                    Columns.HeaderText = "Date Last Modified"
                    Columns.SortExpression = "DateModified"
                    Columns.UniqueName = "DateModified"
                    Columns.DataField = "DateModified"
                    FileExplorer1.Grid.Columns.Add(Columns)

                    UtilDB.LogOtherActivity(zUserid, "Filecab: Client Information")
                    'Case 2  'User manual
                    '    FileExplorer1.Configuration.SearchPatterns = New String() {"*_Plant_.pdf"}
                    '    zExternalPath = Replace(zExternalPath, "cldb", "")
                    '    zClientCode = "Documentation"
                    '    zTargetFolder = ""
                    '    GRC.Connect.Libraries.CoreLib.UtilGSafe.SetValue(zSafeGUID, "practiceName", "User Manuals", "PageHeader")
                    '    lblInstructions.Text = "Click the User Manuals below for details on the GRC Connect System."
                    '    FileExplorer1.Configuration.ViewPaths = SetPath(TrailingChar(zExternalPath & zClientCode, "\") & zTargetFolder)
                    '    FileExplorer1.Configuration.ContentProviderTypeName = GetType(CustomFileSystemProvider).AssemblyQualifiedName

                    'Case 3  'Full User manual
                    '    FileExplorer1.Configuration.SearchPatterns = New String() {"*_Account_.pdf"}
                    '    zExternalPath = Replace(zExternalPath, "cldb", "")
                    '    zClientCode = "Documentation"
                    '    zTargetFolder = ""
                    '    GRC.Connect.Libraries.CoreLib.UtilGSafe.SetValue(zSafeGUID, "practiceName", "Full User Manuals", "PageHeader")
                    '    lblInstructions.Text = "Click the User Manuals below for details on the GRC Connect System."
                    '    FileExplorer1.Configuration.ViewPaths = SetPath(TrailingChar(zExternalPath & zClientCode, "\") & zTargetFolder)
                    '    FileExplorer1.Configuration.ContentProviderTypeName = GetType(CustomFileSystemProvider).AssemblyQualifiedName

                Case 4 ' PROJECT MANAGEMENT DOCUMENTS
                    ' NEEDED INFORMATION FOR DOC LIB FOR PROJECT MANAGEMENT
                    ' - Project RowID OR Project GUID
                    Dim zProjectGUID As String = Nothing
                    If Not Request.QueryString("proj") Is Nothing Then
                        zProjectGUID = Request.QueryString("proj") & ""
                    End If

                    Dim zProjectFolderPath As String = PMLib.UtilPM.GetProjectFolder(Request.QueryString("sid"), zProjectGUID)

                    ' SET THE CURRENT PAGE IN GSAFE
                    UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.practiceName, "Project Management Documents", UtilGSafe.KeyNameGroup.PageHeader)
                    ' CREATE THE PATH FOR THE EXPLORER
                    zTargetFolder = "Project Management Documents"
                    lblInstructions.Text = IIf(zProjectFolderPath = String.Empty, "There are no documents posted to this library.", "")
                    FileExplorer1.Configuration.SearchPatterns = New String() {"*.pdf"}
                    FileExplorer1.Configuration.ViewPaths = New List(Of String)({zProjectFolderPath}).ToArray
                    FileExplorer1.Configuration.ContentProviderTypeName = GetType(CustomFileSystemProvider).AssemblyQualifiedName

                    UtilDB.LogOtherActivity(zUserid, "Filecab: Project Management")

                Case Else
                    zExternalPath = ""
                    FileExplorer1.Configuration.ViewPaths = SetPath(TrailingChar(zExternalPath & zClientCode, "\") & zTargetFolder)
                    FileExplorer1.Configuration.ContentProviderTypeName = GetType(CustomFileSystemProvider).AssemblyQualifiedName

            End Select
        End If

    End Sub

    Private Sub LoadData()

    End Sub

    Private Sub LoadLists()

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Call LoadLists()
            Call LoadDefaults()
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
        explorerControls = explorerControls Or Telerik.Web.UI.FileExplorer.FileExplorerControls.TreeView
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

    Private Shared DateModifiedSort As String

    Protected Sub RadFileExplorer1_ExplorerPopulated(sender As Object, e As RadFileExplorerPopulatedEventArgs)
        'implement sorting for the custom Date column
        Dim sortingColumn As String = e.SortColumnName
        If sortingColumn = "DateModified" Then
            Dim dc As New DateComparer()
            If e.SortDirection.IndexOf("DESC") <> -1 Then
                DateModifiedSort = "DESC"
            Else
                DateModifiedSort = "ASC"
            End If
            e.List.Sort(dc)
            If e.SortDirection.IndexOf("DESC") <> -1 Then
                e.List.Reverse()
            End If
        End If
    End Sub

    Public Class DateComparer
        Implements IComparer(Of FileBrowserItem)
        Function Compare(item1 As FileBrowserItem, item2 As FileBrowserItem) As Integer Implements IComparer(Of FileBrowserItem).Compare
            If DateModifiedSort = "DESC" Then
                If Not item1 Is Nothing And Not item2 Is Nothing Then
                    If item1.Attributes("DateModified") Is Nothing Then
                        Return 1
                    ElseIf item2.Attributes("DateModified") Is Nothing Then
                        Return -1
                    Else
                        Dim date1 As DateTime = DateTime.Parse(item1.Attributes("DateModified"))
                        Dim date2 As DateTime = DateTime.Parse(item2.Attributes("DateModified"))
                        Return DateTime.Compare(date1, date2)
                    End If
                Else
                    Return 1
                End If
            Else
                If Not item2 Is Nothing And Not item1 Is Nothing Then
                    If item2.Attributes("DateModified") Is Nothing Then
                        Return 1
                    ElseIf item1.Attributes("DateModified") Is Nothing Then
                        Return -1
                    Else
                        Dim date1 As DateTime = DateTime.Parse(item2.Attributes("DateModified"))
                        Dim date2 As DateTime = DateTime.Parse(item1.Attributes("DateModified"))
                        Return DateTime.Compare(date1, date2) * -1

                    End If
                Else
                    Return -1
                End If
            End If
        End Function
    End Class

    Public Class CustomColumnsContentProvider
        Inherits Telerik.Web.UI.Widgets.FileSystemContentProvider
        Public Sub New(context As HttpContext, searchPatterns As String(), viewPaths As String(), uploadPaths As String(), deletePaths As String(), selectedUrl As String, _
             selectedItemTag As String)
            ' Declaring a constructor is required when creating a custom content provider class
            MyBase.New(context, searchPatterns, viewPaths, uploadPaths, deletePaths, selectedUrl, _
                 selectedItemTag)
        End Sub

    End Class



End Class