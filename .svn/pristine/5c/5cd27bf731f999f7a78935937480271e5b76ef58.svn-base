Imports Telerik.Web.UI

Public Class ColorMeta
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub RadGrid1_BatchEditCommand(sender As Object, e As Telerik.Web.UI.GridBatchEditingEventArgs) Handles ColorGrid.BatchEditCommand
        Dim con As New SqlClient.SqlConnection(Libraries.CoreLib.UtilDB.ConnectionString)
        Dim updateBuilder As New StringBuilder
        Dim setBuilder As New StringBuilder
        Dim whereBuilder As New StringBuilder
        Dim sb As New StringBuilder

        For Each editcmd As GridBatchEditingCommand In e.Commands

            updateBuilder.Clear()
            updateBuilder.Append("UPDATE tblMetaColor ")

            'SET PORTION
            updateBuilder.Append("SET ")
            setBuilder.Clear()

            For Each Key As String In editcmd.NewValues.Keys
                If Not e.Item.OwnerTableView.DataKeyNames.Contains(Key) Then
                    setBuilder.AppendLine(Key & "='" & editcmd.NewValues(Key) & "'")
                End If
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

        ColorGrid.Rebind()

    End Sub

    Private Sub ColorGrid_ItemDataBound(sender As Object, e As GridItemEventArgs) Handles ColorGrid.ItemDataBound
        If TypeOf e.Item Is GridDataItem Then
            Dim zDataItem As GridDataItem = e.Item
            Dim zDataRow As DataRowView = zDataItem.DataItem
            e.Item.BackColor = System.Drawing.ColorTranslator.FromHtml(zDataRow.Row("fldHex"))

            'Dim zColorPicker As RadColorPicker = zDataItem.FindControl("uxColorPicker")
            'zColorPicker.SelectedColor = e.Item.BackColor

        End If

    End Sub

    Private Sub RadGrid1_NeedDataSource(sender As Object, e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles ColorGrid.NeedDataSource

        If Session("IsMetaAuth") Then

            Dim con As New SqlClient.SqlConnection(Libraries.CoreLib.UtilDB.ConnectionString)
            Dim s As String = "SELECT * FROM tblMetaColor"
            Dim cmd As New SqlClient.SqlCommand(s, con)
            Dim dt As New DataTable
            con.Open()
            dt.Load(cmd.ExecuteReader)
            con.Close()
            sender.DataSource = dt
        End If

    End Sub
End Class