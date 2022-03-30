Imports GrapeCity.ActiveReports 
Imports GrapeCity.ActiveReports.Document 

Public Class rptBMFacilityRatingKey 
    Implements IUtilReport

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Function GetDataSource() As DataTable
        Dim zCon As New SqlClient.SqlConnection(rptProperties.ConnectionString)
        Dim zCmd As New SqlClient.SqlCommand("SELECT * FROM gv.vwBMFacilityRatingWeight WHERE filePrefix='" & rptProperties.FilePrefix & "'", zCon)
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

    Private Sub rptBMFacilityRatingKey_ReportStart(sender As Object, e As EventArgs) Handles Me.ReportStart
        Me.DataSource = GetDataSource()
    End Sub
End Class
