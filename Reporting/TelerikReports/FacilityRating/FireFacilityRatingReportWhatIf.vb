Imports System.ComponentModel
Imports System.Drawing
Imports GRC.Connect.Libraries.WhatIfInterfaceLib
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class FireFacilityRatingReportWhatIf
    Inherits Telerik.Reporting.Report
    Implements ITelerikBaseReport
    Implements ITelerikReport

    Public Shadows Property ReportDataSource As IRatingReportData

    Public Sub New()
        MyBase.New()
        InitializeComponent()
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
        Return "What If Analysis - Facility Rating"
    End Function

    Public Function AppendPracticeToTitle() As Boolean Implements ITelerikReport.AppendPracticeToTitle
        Return True
    End Function

    Public ReadOnly Property AlternateHeaderHTMLTextBox As HtmlTextBox Implements ITelerikBaseReport.AlternateHeaderHTMLTextBox
        Get
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property DisclaimerHTMLTextBox As HtmlTextBox Implements ITelerikBaseReport.DisclaimerHTMLTextBox
        Get
            Return txtDisclaimer
        End Get
    End Property

    Public ReadOnly Property FilterHTMLTextBox As HtmlTextBox Implements ITelerikBaseReport.FilterHTMLTextBox
        Get
            Return txtFilter
        End Get
    End Property

    Public ReadOnly Property PageCounterTextBox As TextBox Implements ITelerikBaseReport.PageCounterTextBox
        Get
            Return txtPageCounter
        End Get
    End Property

    Public ReadOnly Property ReportDateTextBox As TextBox Implements ITelerikBaseReport.ReportDateTextBox
        Get
            Return txtReportDate
        End Get
    End Property

    Public ReadOnly Property SortHTMLTextBox As HtmlTextBox Implements ITelerikBaseReport.SortHTMLTextBox
        Get
            Return txtSort
        End Get
    End Property

    Public ReadOnly Property StandardHeaderHTMLTextBox As HtmlTextBox Implements ITelerikBaseReport.StandardHeaderHTMLTextBox
        Get
            Return txtStandardHeader
        End Get
    End Property

    Private Sub FireFacilityRatingReport_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding

        ''SET DISCLAIMER TEXT
        txtDisclaimer.Value = ""

    End Sub

    Private Sub SetTitle(sender As Object, e As EventArgs) Handles txtStandardHeader.ItemDataBinding, HtmlTextBox1.ItemDataBinding
        txtStandardHeader.Value = ReportDataSource.Client.ClientName
        HtmlTextBox1.Value = ReportTitle()
    End Sub

    Private Sub FireFacilityRatingReport_ItemDataBound(sender As Object, e As EventArgs) Handles Me.ItemDataBound
        ApplyCurrency()
    End Sub

    Private Sub ApplyCurrency()
        'txtCurrency.Value = rptProperties.Currency.colFldName
        'txtCurrency1.Value = txtCurrency.Value

        'Dim zCurrencyControls As TextBox() = {txtAPL1, txtAPLWithRecs, txtAPLBI, txtAPLPD, txtAPL, txtPMLPD, txtPMLBI, txtPML, txtMFL, txtMFLBI, txtActiveScoreLabel, txtMFLPD, txtTIV, txtTIVBI, txtTIVPD, uxAplRecsComplete}
        'UtilReport.TelerikReport.SetCurrencyFormat(zCurrencyControls, rptProperties)

    End Sub

    Private Sub uxAchievableAverages_NeedDataSource(sender As Object, e As EventArgs) Handles uxAchievableAverages.NeedDataSource
        Me.uxAchievableAverages.DataSource = ReportDataSource.Averages
    End Sub

    Private Sub detail_ItemDataBinding(sender As Object, e As EventArgs) Handles detail.ItemDataBinding
        Dim zD As Processing.DetailSection = sender

    End Sub

    Private Sub uxRatingKeyTable_NeedDataSource(sender As Object, e As EventArgs) Handles uxRatingKeyTable.NeedDataSource
        uxRatingKeyTable.DataSource = ReportDataSource.RatingKeys
    End Sub


    Private Sub FireFacilityRatingReportWhatIf_NeedDataSource(sender As Object, e As EventArgs) Handles Me.NeedDataSource
        Me.DataSource = ReportDataSource.Fields

        ' Passive Score Rating color setting
        Me.txtFloodRating.Style.BackgroundColor = ColorTranslator.FromHtml(ReportDataSource.Fields.colFloorRatingBackColorHex)
        Me.txtFloodRating.Style.Color = ColorTranslator.FromHtml(ReportDataSource.Fields.colFloorRatingForeColorHex)
        Me.txtEarthquakeRating.Style.BackgroundColor = ColorTranslator.FromHtml(ReportDataSource.Fields.colEarthquakeRatingBackColorHex)
        Me.txtEarthquakeRating.Style.Color = ColorTranslator.FromHtml(ReportDataSource.Fields.colEarthquakeRatingForeColorHex)
        Me.txtWindstormRating.Style.BackgroundColor = ColorTranslator.FromHtml(ReportDataSource.Fields.colWindstormRatingBackColorHex)
        Me.txtWindstormRating.Style.Color = ColorTranslator.FromHtml(ReportDataSource.Fields.colWindstormRatingForeColorHex)
        Me.txtConstructionRating.Style.BackgroundColor = ColorTranslator.FromHtml(ReportDataSource.Fields.colConstructionRatingBackColorHex)
        Me.txtConstructionRating.Style.Color = ColorTranslator.FromHtml(ReportDataSource.Fields.colConstructionRatingForeColorHex)
        Me.txtOccupancyRating.Style.BackgroundColor = ColorTranslator.FromHtml(ReportDataSource.Fields.colOccupancyRatingBackColorHex)
        Me.txtOccupancyRating.Style.Color = ColorTranslator.FromHtml(ReportDataSource.Fields.colOccupancyRatingForeColorHex)
        Me.txtOtherRating.Style.BackgroundColor = ColorTranslator.FromHtml(ReportDataSource.Fields.colOtherRatingBackColorHex)
        Me.txtOtherRating.Style.Color = ColorTranslator.FromHtml(ReportDataSource.Fields.colOtherRatingForeColorHex)

        ' Active Score Rating color setting
        Me.txtProtectionRating.Style.BackgroundColor = ColorTranslator.FromHtml(ReportDataSource.Fields.colPhysicalProtectionRatingBackColorHex)
        Me.txtProtectionRating.Style.Color = ColorTranslator.FromHtml(ReportDataSource.Fields.colPhysicalProtectionRatingForeColorHex)
        Me.txtHeRating.Style.BackgroundColor = ColorTranslator.FromHtml(ReportDataSource.Fields.colHumanElementRatingBackColorHex)
        Me.txtHeRating.Style.Color = ColorTranslator.FromHtml(ReportDataSource.Fields.colHumanElementRatingForeColorHex)
        Me.txtNatHazRating.Style.BackgroundColor = ColorTranslator.FromHtml(ReportDataSource.Fields.colNaturalHazardsProtectionRatingBackColorHex)
        Me.txtNatHazRating.Style.Color = ColorTranslator.FromHtml(ReportDataSource.Fields.colNaturalHazardsProtectionRatingForeColorHex)
        Me.txtBcpRating.Style.BackgroundColor = ColorTranslator.FromHtml(ReportDataSource.Fields.colBcpAllRecsCompleteRatingBackColorHex)
        Me.txtBcpRating.Style.Color = ColorTranslator.FromHtml(ReportDataSource.Fields.colBcpAllRecsCompleteRatingForeColorHex)

        Me.txtProtectionRatingWhatIfRecs.Style.BackgroundColor = ColorTranslator.FromHtml(ReportDataSource.Fields.colPhysicalProtectionWhatIfRatingBackColorHex)
        Me.txtProtectionRatingWhatIfRecs.Style.Color = ColorTranslator.FromHtml(ReportDataSource.Fields.colPhysicalProtectionWhatIfRatingForeColorHex)
        Me.txtHeRatingWhatIfRecs.Style.BackgroundColor = ColorTranslator.FromHtml(ReportDataSource.Fields.colHumanElementWhatIfRatingBackColorHex)
        Me.txtHeRatingWhatIfRecs.Style.Color = ColorTranslator.FromHtml(ReportDataSource.Fields.colHumanElementWhatIfRatingForeColorHex)
        Me.txtNatHazRatingWhatIfRecs.Style.BackgroundColor = ColorTranslator.FromHtml(ReportDataSource.Fields.colNaturalHazardsProtectionWhatIfRatingBackColorHex)
        Me.txtNatHazRatingWhatIfRecs.Style.Color = ColorTranslator.FromHtml(ReportDataSource.Fields.colNaturalHazardsProtectionWhatIfRatingForeColorHex)
        Me.txtBcpRatingWhatIfRecs.Style.BackgroundColor = ColorTranslator.FromHtml(ReportDataSource.Fields.colBusinessContinuityWhatIfRatingBackColorHex)
        Me.txtBcpRatingWhatIfRecs.Style.Color = ColorTranslator.FromHtml(ReportDataSource.Fields.colBcpAllRecsCompleteRatingForeColorHex)

        Me.txtProtectionRatingRecs.Style.BackgroundColor = ColorTranslator.FromHtml(ReportDataSource.Fields.colFireProtectionAllRecsCompleteRatingBackColorHex)
        Me.txtProtectionRatingRecs.Style.Color = ColorTranslator.FromHtml(ReportDataSource.Fields.colFireProtectionAllRecsCompleteRatingForeColorHex)
        Me.txtHeRatingRecs.Style.BackgroundColor = ColorTranslator.FromHtml(ReportDataSource.Fields.colHumanElementAllRecsCompleteRatingBackColorHex)
        Me.txtHeRatingRecs.Style.Color = ColorTranslator.FromHtml(ReportDataSource.Fields.colHumanElementAllRecsCompleteRatingForeColorHex)
        Me.txtNatHazRatingRecs.Style.BackgroundColor = ColorTranslator.FromHtml(ReportDataSource.Fields.colNatHazProtAllRecsCompleteRatingBackColorHex)
        Me.txtNatHazRatingRecs.Style.Color = ColorTranslator.FromHtml(ReportDataSource.Fields.colNatHazProtAllRecsCompleteRatingForeColorHex)
        Me.txtBcpRatingRecs.Style.BackgroundColor = ColorTranslator.FromHtml(ReportDataSource.Fields.colBcpAllRecsCompleteRatingBackColorHex)
        Me.txtBcpRatingRecs.Style.Color = ColorTranslator.FromHtml(ReportDataSource.Fields.colBcpAllRecsCompleteRatingForeColorHex)

        ' Overall Score Rating color setting

    End Sub
End Class