Imports Telerik.Web.UI

Public Class LossEstimateAfterMeta
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub RadGrid1_BatchEditCommand(sender As Object, e As Telerik.Web.UI.GridBatchEditingEventArgs) Handles RadGridLossEstimate.BatchEditCommand
        Dim con As New SqlClient.SqlConnection(Libraries.CoreLib.UtilDB.ConnectionString)
        Dim updateBuilder As New StringBuilder
        Dim setBuilder As New StringBuilder
        Dim whereBuilder As New StringBuilder
        Dim sb As New StringBuilder

        For Each editcmd As GridBatchEditingCommand In e.Commands

            updateBuilder.Clear()
            updateBuilder.Append("UPDATE tblMetaLossEstimate ")

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

        RadGridLossEstimate.Rebind()

    End Sub

    Private Sub RadGrid1_NeedDataSource(sender As Object, e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles RadGridLossEstimate.NeedDataSource

        If Session("IsMetaAuth") Then

            Dim con As New SqlClient.SqlConnection(Libraries.CoreLib.UtilDB.ConnectionString)
            Dim s As String = My.Resources.MetaGetLossEstAfterView
            Dim cmd As New SqlClient.SqlCommand(s, con)
            Dim dt As New DataTable
            con.Open()
            dt.Load(cmd.ExecuteReader)
            con.Close()
            RadGridLossEstimate.DataSource = dt

        End If

    End Sub
End Class