Imports Telerik.Web.UI


Public Class GridMeta
    Inherits System.Web.UI.UserControl

    Private Sub Page_Init(sender As Object, e As EventArgs) Handles Me.Init
        SqlDataSource1.ConnectionString = Libraries.CoreLib.UtilDB.ConnectionString
        SqlDataSource1.SelectCommand = "Select * from tblMetaGridColumnType"
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub RadGridByGrid_BatchEditCommand(sender As Object, e As GridBatchEditingEventArgs) Handles RadGridByGrid.BatchEditCommand

        Dim sqlAllUpdates As New StringBuilder

        For Each batchEditCommand As Telerik.Web.UI.GridBatchEditingCommand In e.Commands

            Dim hash As Hashtable = batchEditCommand.NewValues
            Dim sqlUpdateBuilder As New StringBuilder

            If e.Item.OwnerTableView.Name = "GridView" Then
                sqlUpdateBuilder.Append("UPDATE tblMetaGrid SET ")
            ElseIf e.Item.OwnerTableView.Name = "GridColumnView" Then
                sqlUpdateBuilder.Append("UPDATE tblMetaGridColumn SET ")
            End If

            Dim key As Integer = hash("fldId")
            Dim sqlSetBuilder As New StringBuilder("")
            For Each fieldKey As String In hash.Keys
                If fieldKey <> "fldId" Then
                    sqlSetBuilder.Append(fieldKey & "='" & hash(fieldKey) & "',")
                End If
            Next
            sqlUpdateBuilder.Append(Left(sqlSetBuilder.ToString, sqlSetBuilder.Length - 1))
            sqlUpdateBuilder.Append(" WHERE fldid=" & key & ";")
            sqlAllUpdates.AppendLine(sqlUpdateBuilder.ToString)

        Next

        Dim con As New SqlClient.SqlConnection(Libraries.CoreLib.UtilDB.ConnectionString)
        Dim cmd As New SqlClient.SqlCommand(sqlAllUpdates.ToString, con)

        con.Open()
        Using con
            Using cmd
                cmd.ExecuteNonQuery()
            End Using
        End Using

        If e.Item.OwnerTableView.ParentItem IsNot Nothing Then
            Dim GridIdToExpand As Integer = e.Item.OwnerTableView.ParentItem.GetDataKeyValue("fldId")
            RadGridByGrid.Rebind()
            RadGridByGrid.MasterTableView.FindItemByKeyValue("fldId", GridIdToExpand).Expanded = True
        Else
            RadGridByGrid.Rebind()
        End If


    End Sub

    Private Sub RadGridByGrid_ItemCommand(sender As Object, e As GridCommandEventArgs) Handles RadGridByGrid.ItemCommand
        If e.CommandName = "RebindGrid" Then
            Me.RadGridByGrid.MasterTableView.FilterExpression = ""
        End If

        If e.CommandName = "Clone" Then
            Dim key As Integer = DirectCast(e.Item, GridDataItem).GetDataKeyValue("fldId")
            Dim newId As Integer = CloneGrid(key)
            FilterGridById(newId)
        End If

        If e.CommandName = "DeleteGrid" Then
            Dim key As Integer = DirectCast(e.Item, GridDataItem).GetDataKeyValue("fldId")
            DeleteGrid(key)
            RadGridByGrid.Rebind()
        End If

    End Sub

    Private Function CloneGrid(id As Integer) As Integer
        Dim con As New SqlClient.SqlConnection(Libraries.CoreLib.UtilDB.ConnectionString)

        Dim cmd As New SqlClient.SqlCommand("spMetaCloneGrid", con)
        cmd.CommandType = CommandType.StoredProcedure

        Dim parm As New SqlClient.SqlParameter("@GridToCloneId", id)
        Dim parm1 As New SqlClient.SqlParameter("@InsertedGridIdentity", 0)
        parm1.Direction = ParameterDirection.InputOutput

        Dim update As Integer = 0
        cmd.Parameters.Add(parm)
        cmd.Parameters.Add(parm1)

        con.Open()
        With con
            With cmd
                update = cmd.ExecuteNonQuery
            End With
        End With

        Return parm1.Value

    End Function

    Private Sub DeleteGrid(id As Integer)
        Dim con As New SqlClient.SqlConnection(Libraries.CoreLib.UtilDB.ConnectionString)

        Dim cmd As New SqlClient.SqlCommand("BEGIN TRANSACTION Delete tblMetaGrid Where fldId=" & id & "; Delete tblMetaGridColumn where fldMetaGridId=" & id & "; COMMIT TRANSACTION", con)
        cmd.CommandType = CommandType.Text
        con.Open()
        With con
            With cmd
                cmd.ExecuteNonQuery()
            End With
        End With
    End Sub

    Private Sub FilterGridById(id As Integer)
        RadGridByGrid.MasterTableView.Columns.FindByDataField("fldId").CurrentFilterFunction = GridKnownFunction.EqualTo
        RadGridByGrid.MasterTableView.Columns.FindByDataField("fldId").CurrentFilterValue = id
        RadGridByGrid.MasterTableView.FilterExpression = "([fldId]='" & id & "')"
        RadGridByGrid.Rebind()
        RadGridByGrid.MasterTableView.FindItemByKeyValue("fldId", id).Expanded = True
    End Sub

    Private Sub RadGrid1_NeedDataSource(sender As Object, e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles RadGridByGrid.NeedDataSource

        If Session("IsMetaAuth") Then

            Dim con As New SqlClient.SqlConnection(Libraries.CoreLib.UtilDB.ConnectionString)
            Dim cmd As SqlClient.SqlCommand = Nothing
            Dim dt As New DataTable

            Dim s As String = "SELECT fldId, fldGridName, fldGridPageTitle, fldGridPageSubTitle FROM TBLMETAGRID ORDER BY fldGridName"
            cmd = New SqlClient.SqlCommand(s, con)
            dt = New DataTable
            con.Open()
            dt.Load(cmd.ExecuteReader)
            con.Close()
            RadGridByGrid.MasterTableView.DataSource = dt

            dt = New DataTable
            cmd = New SqlClient.SqlCommand("select fldId, fldMetaGridId, field, title, width,indexorder, include, type, sortable, filterable, hidden, format, fldExcludeFromExtract  from tblMetaGridColumn order by indexorder ASC", con)
            con.Open()
            dt.Load(cmd.ExecuteReader)
            con.Close()
            RadGridByGrid.MasterTableView.DetailTables(0).DataSource = dt

        End If

    End Sub

    Private Sub RadGridByGrid_RowDrop(sender As Object, e As Telerik.Web.UI.GridDragDropEventArgs) Handles RadGridByGrid.RowDrop
        Dim doRebind As Boolean = False

        For Each draggedItem As GridDataItem In e.DraggedItems
            If draggedItem.OwnerTableView.Name = "GridColumnView" Then
                doRebind = True
                Dim con As New SqlClient.SqlConnection(Libraries.CoreLib.UtilDB.ConnectionString)
                Dim cmd As New SqlClient.SqlCommand("spMetaReorderGridColumn @dragged, @dropped, @dropPos", con)
                Dim parm1 As New SqlClient.SqlParameter("@dragged", draggedItem.GetDataKeyValue("fldId"))
                Dim parm2 As New SqlClient.SqlParameter("@dropped", e.DestDataItem.GetDataKeyValue("fldId"))
                Dim parm3 As New SqlClient.SqlParameter("@dropPos", e.DropPosition.ToString)
                cmd.Parameters.Add(parm1)
                cmd.Parameters.Add(parm2)
                cmd.Parameters.Add(parm3)
                con.Open()
                Using con
                    cmd.ExecuteScalar()
                    con.Close()
                End Using
            End If
        Next

        If doRebind Then
            RadGridByGrid.Rebind()
            RadGridByGrid.MasterTableView.FindItemByKeyValue("fldId", e.DraggedItems(0).OwnerTableView.ParentItem.GetDataKeyValue("fldId")).Expanded = True
        End If

    End Sub
End Class