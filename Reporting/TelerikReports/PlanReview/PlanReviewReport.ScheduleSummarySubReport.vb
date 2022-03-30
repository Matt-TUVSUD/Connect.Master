Imports System.ComponentModel
Imports System.Drawing
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports GRC.Connect.Libraries.DataLib.razor

Public Class ScheduleSummarySubReport
    Inherits BaseSubReport
    Implements IUtilReport

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub ScheduleSummarySubReport_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        txtSchedulingComment.Value = rptProperties.Practice.colFldReportDisplayTitle & " Commen"
    End Sub

    Private Sub ScheduleSummarySubReport_NeedDataSource(sender As Object, e As System.EventArgs) Handles Me.NeedDataSource
        Me.DataSource = GetDataSource()
    End Sub

    Private Function GetDataSource() As DataTable
        Dim zCon As New SqlClient.SqlConnection(rptProperties.ConnectionString)
        Dim zCmd As SqlClient.SqlCommand = Nothing
        If rptProperties.Practice.Practice = TblMetaPractice.Practices.BM Then zCmd = New SqlClient.SqlCommand("SELECT * FROM [Gripss-Workload] WHERE FileNo LIKE '" & rptProperties.FilePrefix & ".%' AND PracticeCode IN (510,515)", zCon)
        If rptProperties.Practice.Practice = TblMetaPractice.Practices.Fire Then zCmd = New SqlClient.SqlCommand("SELECT * FROM [Gripss-Workload] WHERE FileNo LIKE '" & rptProperties.FilePrefix & ".%' AND PracticeCode IN (520,525)", zCon)
        Dim zDT As New DataTable
        zCon.Open()
        Using zCon
            Using zCmd
                zDT.Load(zCmd.ExecuteReader)
            End Using
        End Using
        Return zDT
    End Function

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties
End Class
