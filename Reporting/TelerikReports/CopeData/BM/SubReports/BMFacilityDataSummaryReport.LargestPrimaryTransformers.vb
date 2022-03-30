Imports System.ComponentModel
Imports System.Drawing
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing



Public Class BoilerFacilityDataSummary_LargestPrimaryTransformers
    Inherits Telerik.Reporting.Report
    Implements IUtilReport

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Function GetDataSource() As DataTable
        Dim zCon As New SqlClient.SqlConnection(rptProperties.ConnectionString)
        Dim zCmd As New SqlClient.SqlCommand("SELECT * FROM rv.vwBMCopeLargestTransformer WHERE filePrefix='" & rptProperties.FilePrefix & "'", zCon)
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

    Private Sub BoilerFacilityDataSummary_LargestPrimaryTransformers_NeedDataSource(sender As Object, e As EventArgs) Handles Me.NeedDataSource
        Me.DataSource = GetDataSource()
    End Sub
End Class