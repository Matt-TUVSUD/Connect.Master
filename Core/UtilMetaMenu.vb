Imports GRC.Connect.Libraries.DataLib.razor

Public Class UtilMetaMenu

    Private client As rowTblClients
    Private isClientAdmin As Boolean = False

    Public Sub New(safeGuid As String)
        Me.client = TblClients.LoadByPrimaryKey(UtilGSafe.GetValue(safeGuid, UtilGSafe.KeyName.FilePreFix))
        Me.isClientAdmin = Convert.ToBoolean(IIf(String.IsNullOrEmpty(UtilGSafe.GetValue(safeGuid, UtilGSafe.KeyName.IsClientAdmin)), False, UtilGSafe.GetValue(safeGuid, UtilGSafe.KeyName.IsClientAdmin)))
    End Sub

    ' ''' <summary>
    ' ''' For testing during development. Do not use.
    ' ''' </summary>
    ' ''' <param name="fileprefix"></param>
    ' ''' <remarks></remarks>
    'Public Sub New(fileprefix As String)
    '    Me.client = TblClients.LoadByPrimaryKey(fileprefix)
    '    Me.isClientAdmin = False
    'End Sub

    Public Function GetMenu(node As String, sid As String) As List(Of MetaMenuItem)

        Dim data As DataTable = GetData(node, sid)
        Dim dataList As List(Of DataRow) = data.Select.ToList().Where(Function(x) x("parentid") > 0).OrderBy(Function(x) x("sort")).ToList()
        Dim menuList As List(Of MetaMenuItem) = BuildList(dataList)

        HierarchizeList(Nothing, menuList)

        Return menuList

    End Function

    Private Function BuildList(list As List(Of DataRow)) As List(Of MetaMenuItem)
        Dim metaMenuList As New List(Of MetaMenuItem)
        Dim include As Boolean

        For Each row As DataRow In list
            include = True

            If Not IsDBNull(row("clientfeature")) Then
                include = row("clientfeature").ToString.ToArray().Contains(client.colFeatures)
            End If

            If Not IsDBNull(row("isclientadmin")) Then
                include = isClientAdmin OrElse Not (row("isclientadmin"))
            End If

            If include Then
                metaMenuList.Add(New MetaMenuItem(row("id"), row("parentid"), row("Text"), SafeString(row("href")), SafeString(row("ToolTip")), SafeString(row("Target")), SafeString(row("ImageFile")), SafeString(row("sort")), row("CanFilter"), SafeString(row("BypassFilterHref"))))
            End If

        Next

        Return metaMenuList

    End Function

    Private Sub HierarchizeList(menuitem As MetaMenuItem, ByRef menulist As List(Of MetaMenuItem))

        If IsNothing(menuitem) Then
            For i = menulist.Count - 1 To 0 Step -1
                HierarchizeList(menulist(i), menulist)
            Next
        Else
            If menulist.FindAll(Function(x) x.ParentId = menuitem.Id).Count > 0 Then
                menuitem.Items.AddRange(menulist.FindAll(Function(x) x.ParentId = menuitem.Id))
                For Each item As MetaMenuItem In menuitem.Items
                    menulist.Remove(item)
                Next
            End If
        End If

    End Sub

    Private Function GetData(node As String, sid As String) As DataTable

        Dim zCmd As New SqlClient.SqlCommand("spGetMetaMenu")
        zCmd.Parameters.AddWithValue("@node", node)
        zCmd.Parameters.AddWithValue("@sid", sid)
        zCmd.CommandType = CommandType.StoredProcedure

        Return GRC.Connect.Libraries.DataLib.razor.UtilSQLServer.ExecuteDataTable(zCmd)

    End Function

    Private Function SafeString(value As Object) As String
        If IsDBNull(value) Then
            Return ""
        Else
            Return value
        End If
    End Function

    Public Class MetaMenuItem
        Public Property Id As Integer
        Public Property Text As String
        Public Property Href As String
        Public Property ToolTip As String
        Public Property Target As String
        Public Property ImageName As String
        Public Property CanFilter As Boolean
        Public Property Items As New List(Of MetaMenuItem)
        Public Property BypassFilterHref As String

        <Newtonsoft.Json.JsonIgnore>
        Public Property ParentId As Integer = 0

        <Newtonsoft.Json.JsonIgnore>
        Public Property SortOrder As String

        Public Sub New(id As Integer, parentid As Integer, text As String, href As String, tooltip As String, target As String, imageName As String, sortOrder As String, canFilter As Boolean, BypassFilterHref As String)
            Me.Id = id
            Me.ParentId = parentid
            Me.Text = text
            Me.Href = ReplaceBaseURL(href)
            Me.ToolTip = tooltip
            Me.Target = target
            Me.ImageName = imageName
            Me.SortOrder = sortOrder
            Me.CanFilter = canFilter
            Me.BypassFilterHref = ReplaceBaseURL(BypassFilterHref)
        End Sub

        Private Function ReplaceBaseURL(href As String) As String

            If Not IsNothing(HttpContext.Current) Then
                Dim zSearchString = UtilNav.NavLinkPlaceholder
                Dim zActualPath As String = HttpContext.Current.Request.ApplicationPath
                href = Replace(href, UtilNav.NavLinkPlaceholder, UtilSystemParms.ReadWebAppBaseURL & "Home_{{VER}}")
            End If

            Return href

        End Function

        Public Overrides Function ToString() As String
            Return Me.Text & " (" & Me.Items.Count.ToString & " Items)"
        End Function
    End Class


End Class
