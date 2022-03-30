Imports System.ComponentModel
Imports System.Drawing

Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class BoilerFacilityRatingReport
    Inherits BaseReportLandscape
    Implements ITelerikReport
    Implements IUtilReport

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        UtilReport.TelerikReport.FixBaseGroups(Me)
    End Sub

    Private Sub ApplyColor(rpt As Processing.Report)
        Dim zRatingItems() As GrcTelerikRatingCategoryTexBox = {txtBcpRating, txtBcpRatingRecs,
        txtBoilerRating, txtBoilerRatingRecs, txtCompSysRating, txtCompSysRatingRecs, txtCriticalSparesRating,
        txtCriticalSparesRatingRecs, txtElecMaintRating, txtElecMaintRatingRecs, txtElecSysRating, txtElecSysRatingRecs,
        txtHeRating, txtHeRatingRecs, txtMechMaintRating, txtMechMaintRatingRecs, txtMechSysRating, txtMechSysRatingRecs,
        txtOccupancyRating, txtOccupancyRatingRecs, txtProdRating, txtProdRatingRecs}

        UtilReport.TelerikReport.SetItemBackColorByRating(rpt, zRatingItems, rptProperties)

        Dim zRiskRatingItems() As TextBox = {txtOverallRating}
        UtilReport.TelerikReport.SetItemBackColorByRiskRating(rpt, zRiskRatingItems, rptProperties)

    End Sub

    Public Function IsStandardHeader() As Boolean Implements ITelerikReport.IsStandardHeader
        Return True
    End Function

    Public Function ReportSubSubTitle() As String Implements ITelerikReport.ReportSubSubTitle
        Return ""
    End Function

    Public Function ReportSubTitle() As String Implements ITelerikReport.ReportSubTitle
        Return ""
    End Function

    Public Function ReportTitle() As String Implements ITelerikReport.ReportTitle
        Return "Facility Rating"
    End Function

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties

    Private Sub BoilerFacilityRatingReport_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        UtilReport.TelerikReport.SetFilterText(sender, rptProperties)
        UtilReport.TelerikReport.SetDisclaimerText(sender, rptProperties)
        UtilReport.TelerikReport.SetSortText(sender, rptProperties)
    End Sub

    Private Sub BoilerFacilityRatingReport_ItemDataBound(sender As Object, e As EventArgs) Handles Me.ItemDataBound
        ApplyColor(sender)
    End Sub

    Public Function AppendPracticeToTitle() As Boolean Implements ITelerikReport.AppendPracticeToTitle
        Return True
    End Function

    Private Sub uxRatingKeyTable_NeedDataSource(sender As Object, e As EventArgs) Handles uxRatingKeyTable.NeedDataSource
        uxRatingKeyTable.DataSource = rptProperties.BMRatingRange
    End Sub
End Class