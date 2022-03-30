Imports Telerik.Web.UI

Public Class BatchColumn
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub RadGrid1_BatchEditCommand(sender As Object, e As Telerik.Web.UI.GridBatchEditingEventArgs) Handles RadGridByColumn.BatchEditCommand
        Dim con As New SqlClient.SqlConnection(CoreLib.UtilDB.ConnectionString)
        Dim updateBuilder As New StringBuilder
        Dim setBuilder As New StringBuilder
        Dim whereBuilder As New StringBuilder
        Dim sb As New StringBuilder

        For Each editcmd As GridBatchEditingCommand In e.Commands

            updateBuilder.Clear()
            updateBuilder.Append("UPDATE tblMetaGridColumn ")

            'SET PORTION
            updateBuilder.Append("SET ")
            setBuilder.Clear()

            For Each Key As String In editcmd.NewValues.Keys
                setBuilder.AppendLine(Key & "='" & editcmd.NewValues(Key) & "'")
            Next

            Dim setSQL As String = Replace(setBuilder.ToString, Chr(13) & Chr(10), ",")
            updateBuilder.Append(Left(setSQL, Len(setSQL) - 1))

            'WHERE PORTION
            updateBuilder.Append(" WHERE ")
            whereBuilder.Clear()

            For Each Key As String In editcmd.OldValues.Keys
                whereBuilder.AppendLine(Key & "='" & editcmd.OldValues(Key) & "'")
            Next

            Dim whereSQL As String = Replace(whereBuilder.ToString, Chr(13) & Chr(10), " AND ")

            updateBuilder.Append(Left(whereSQL, Len(whereSQL) - 5))

            sb.Append(updateBuilder.ToString & "; ")

        Next

        Dim cmd As New SqlClient.SqlCommand(sb.ToString, con)
        con.Open()
        Using con
            Using cmd
                Dim UpdateCount As Integer = cmd.ExecuteNonQuery()
            End Using
        End Using

        RadGridByColumn.Rebind()

    End Sub

    Private Sub RadGridByColumn_ItemCommand(sender As Object, e As GridCommandEventArgs) Handles RadGridByColumn.ItemCommand
        If e.CommandName = "NavigateToGrid" Then
            RaiseBubbleEvent(sender, e)
        End If
    End Sub

    Private Sub RadGridByColumn_ItemCreated(sender As Object, e As GridItemEventArgs) Handles RadGridByColumn.ItemCreated
        'If TypeOf e.Item Is GridEditableItem Then
        '    Dim zEditItem As GridEditableItem = e.Item
        '    Dim zControls As ControlCollection = zEditItem.Cells(e.Item.OwnerTableView.Columns.FindByUniqueName("Title").OrderIndex).Controls

        'End If
    End Sub


    Private Sub RadGrid1_NeedDataSource(sender As Object, e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles RadGridByColumn.NeedDataSource

        If Session("IsMetaAuth") Then

            Dim con As New SqlClient.SqlConnection(CoreLib.UtilDB.ConnectionString)
            Dim cmd As New SqlClient.SqlCommand("SELECT ROW_NUMBER() OVER (ORDER BY field, AppearCount DESC) AS RowNum, * FROM(SELECT field, title, width, COUNT(*) AS AppearCount FROM tblMetaGridColumn GROUP BY FIELD, Title, width) T", con)
            Dim dt As New DataTable
            con.Open()
            dt.Load(cmd.ExecuteReader)
            con.Close()
            RadGridByColumn.DataSource = dt

            Dim s As String = My.Resources.MetaGetSourceViewQuery.ToString
            cmd = New SqlClient.SqlCommand(s, con)
            dt = New DataTable
            con.Open()
            dt.Load(cmd.ExecuteReader)
            con.Close()
            RadGridByColumn.MasterTableView.DetailTables(0).DataSource = dt

        End If

    End Sub
End Class