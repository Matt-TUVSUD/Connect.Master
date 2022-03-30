Public Class KillExcel
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Label1.Text = GetExcelProcessesCount()
        Catch ex As Exception
            Label2.Text = ex.Message
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim Xcel() As Process = Process.GetProcessesByName("EXCEL")
            For Each Process As Process In Xcel
                Process.Kill()
            Next
            Label1.Text = GetExcelProcessesCount()
        Catch ex As Exception
            Label2.Text = ex.Message
        End Try
    End Sub

    Private Function GetExcelProcessesCount() As Integer
        Dim Xcel() As Process = Process.GetProcessesByName("EXCEL")
        Return Xcel.Count
    End Function
End Class