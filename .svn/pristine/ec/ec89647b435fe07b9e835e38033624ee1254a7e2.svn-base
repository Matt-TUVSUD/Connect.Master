Imports System.ComponentModel
Imports System.Drawing

Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports GRC.Connect.Libraries.DataLib.razor

Public Class ReviewActivitySubReport
    Inherits BaseSubReport
    Implements IUtilReport

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub PlanReviewReport_ReviewActivitySubReport_NeedDataSource(sender As Object, e As System.EventArgs) Handles Me.NeedDataSource
        Me.DataSource = GetDataSource()
    End Sub

    Private Function GetDataSource() As DataTable
        Dim zCon As New SqlClient.SqlConnection(rptProperties.ConnectionString)
        Dim zCmd As SqlClient.SqlCommand = Nothing
        If rptProperties.Practice.Practice = TblMetaPractice.Practices.BM Then zCmd = New SqlClient.SqlCommand("SELECT * FROM gv.vwBMProjectPlanReviewSelect WHERE FileNo LIKE '" & rptProperties.FilePrefix & ".%' ORDER BY [Reviewed] DESC", zCon)
        If rptProperties.Practice.Practice = TblMetaPractice.Practices.Fire Then zCmd = New SqlClient.SqlCommand("SELECT * FROM gv.vwFireProjectPlanReviewSelect WHERE FileNo LIKE '" & rptProperties.FilePrefix & ".%' ORDER BY [Reviewed] DESC", zCon)
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

