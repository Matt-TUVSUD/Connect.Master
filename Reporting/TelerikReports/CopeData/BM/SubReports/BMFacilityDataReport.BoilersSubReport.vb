Imports System.ComponentModel
Imports System.Drawing
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing



Public Class BmCopeDataReport_BoilersSubReport
    Inherits Telerik.Reporting.Report
    Implements IUtilReport

    Private _ShowNoRecLabel As Boolean = False
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub BmCopeDataReport_BoilersSubReport_NeedDataSource(sender As Object, e As System.EventArgs) Handles Me.NeedDataSource
        Me.DataSource = GetDataSource()
    End Sub

    Private Sub SetVisibility(sender As Object, e As System.EventArgs) Handles Me.ItemDataBound
        Dim zRpt As Processing.Report = DirectCast(sender, Processing.Report)
        Dim zSubRpt As Processing.SubReport = zRpt.ParentElement
        Dim zDetailSections() As Processing.LayoutElement = Processing.ElementTreeHelper.FindChildByName(zRpt, "Detail", True)
        If zDetailSections.Count = 0 Then
            '     zSubRpt.Visible = False
        End If
    End Sub

    Private Function GetDataSource() As DataTable
        Dim zCon As New SqlClient.SqlConnection(rptProperties.ConnectionString)
        Dim zCmd As New SqlClient.SqlCommand("SELECT * FROM rv.vwBMCopeBPVa WHERE filePrefix='" & rptProperties.FilePrefix & "'", zCon)
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