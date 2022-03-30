Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports GRC.Connect.Libraries.WhatIfInterfaceLib
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports GRC.Connect.Libraries.DataLib.razor

Partial Public Class WhatIfAnalysisSummaryReport
    Inherits Telerik.Reporting.Report
    Implements ITelerikBaseReport
    Implements ITelerikReport
    Implements IUtilReport

    Public Shadows Property ReportDataSource As IWhatIfReportData

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

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

    Public ReadOnly Property PageCounterTextBox As Telerik.Reporting.TextBox Implements ITelerikBaseReport.PageCounterTextBox
        Get
            Return txtPageCounter
        End Get
    End Property

    Public ReadOnly Property ReportDateTextBox As Telerik.Reporting.TextBox Implements ITelerikBaseReport.ReportDateTextBox
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

    Public Function AppendPracticeToTitle() As Boolean Implements ITelerikReport.AppendPracticeToTitle
        Return False
    End Function

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
        Return "What If Analysis Summary"
    End Function

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties

    Private Sub SetTitle(sender As Object, e As EventArgs) Handles txtStandardHeader.ItemDataBinding, HtmlTextBox1.ItemDataBinding
        'txtStandardHeader.Value = rptProperties.ClientName
        txtStandardHeader.Value = ReportDataSource.Client.ClientName
        HtmlTextBox1.Value = ReportTitle()
    End Sub

    Public ReadOnly Property AlternateHeaderHTMLTextBox As HtmlTextBox Implements ITelerikBaseReport.AlternateHeaderHTMLTextBox
        Get
            Return Nothing
        End Get
    End Property

    'Private Sub WhatIfAnalysisSummaryReport_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding


    '    ' ''SET TIV CURRENCY
    '    'uxTivHeader.Value = "TIV" & vbNewLine & rptProperties.Currency.colFldCode & vbNewLine & "(mil)"

    '    ' ''SET FILTER TEXT
    '    'If rptProperties.FilterString <> "" Then
    '    '    txtFilter.Value = "<strong>Filter:</strong>&nbsp;" & System.Web.HttpUtility.HtmlEncode(rptProperties.FilterString)
    '    '    txtFilter.Visible = True
    '    'End If

    '    ' ''SET DISCLAIMER TEXT
    '    'txtDisclaimer.Value = rptProperties.Disclaimer

    '    ' ''SET SORT TEXT
    '    'txtSort.Value = rptProperties.SortString


    'End Sub

    'Private Sub uxWeightsTable_NeedDataSource(sender As Object, e As EventArgs)
    '    uxWeightsTable.DataSource = UtilRating.GetFireDetailRatingWeights(rptProperties.FilePrefix)
    'End Sub

    Private Sub Table1_ItemDataBinding(sender As Processing.Table, e As EventArgs) Handles uxRatingTable.ItemDataBinding
        Dim zMove As New Telerik.Reporting.Drawing.Unit(0)
        'ReportItem.DataObject.RecCategoryColor

        'uxAPL.Visible = Not UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.A)
        'uxAPLGroupHeader.Visible = Not UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.A)
        'uxAPLHeader.Visible = Not UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.A)
        'If Not uxAPL.Visible Then zMove = zMove.Add(uxAPL.Width)

        'uxWithRecsAPL.Visible = Not UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.A)
        'uxWithRecsAPLGroupHeader.Visible = Not UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.A)
        'uxWithRecsAPLHeader.Visible = Not UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.A)
        'If Not uxWithRecsAPL.Visible Then zMove = zMove.Add(uxWithRecsAPL.Width)

        'uxAPLFactor.Visible = Not UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.A, UtilCustomFeature.Letter.U)
        'uxAPLFactorGroupHeader.Visible = Not UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.A, UtilCustomFeature.Letter.U)
        'uxAPLFactorHeader.Visible = Not UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.A, UtilCustomFeature.Letter.U)
        'If Not uxAPLFactor.Visible Then zMove = zMove.Add(uxAPLFactor.Width)

        'uxWithRecsAPLFactor.Visible = Not UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.A, UtilCustomFeature.Letter.U)
        'uxWithRecsAPLFactorGroupHeader.Visible = Not UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.A, UtilCustomFeature.Letter.U)
        'uxWithRecsAPLFactorHeader.Visible = Not UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.A, UtilCustomFeature.Letter.U)
        'If Not uxWithRecsAPLFactor.Visible Then zMove = zMove.Add(uxWithRecsAPLFactor.Width)

        'uxAchRating.Visible = UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.U)
        'uxAchRatingHeader.Visible = UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.U)

        'If Not uxAchRating.Visible Then
        '    uxOverallScoreGroupHeader.Width = New Telerik.Reporting.Drawing.Unit(0.5, UnitType.Inch)
        '    zMove = zMove.Add(uxAchRating.Width)
        'End If

        'uxRatingTable.Left = uxRatingTable.Left.Add(zMove / 2)
        'uxWeightsTable.Left = uxWeightsTable.Left.Subtract(zMove / 2)

    End Sub

    Private Sub Table1_NeedDataSource(sender As Object, e As EventArgs) Handles uxRatingTable.NeedDataSource
        Dim zDT As New DataTable
        For Each zItem As Dictionary(Of String, Object) In ReportDataSource.GridData.Data
            If ReportDataSource.GridData.Data.IndexOf(zItem) = 0 Then
                For Each zKey As String In zItem.Keys
                    Select Case zKey
                        Case "StatusDate"
                            zDT.Columns.Add(zKey, Type.GetType("System.DateTime"))
                        Case "LossExpectancyBeforeActual", "LossExpectancyAfterActual", "CostToCompleteActual" ', "ActualCostToComplete"
                            zDT.Columns.Add(zKey, Type.GetType("System.Int32"))
                        Case Else
                            zDT.Columns.Add(zKey)
                    End Select
                    'If zKey = "StatusDate" Then
                    '    zDT.Columns.Add(zKey, Type.GetType("System.DateTime"))
                    'Else
                    '    zDT.Columns.Add(zKey)
                    'End If
                Next
            End If

            Dim zRow As DataRow = zDT.NewRow
            For Each zKey As String In zItem.Keys
                zRow.Item(zKey) = zItem(zKey)
            Next
            zDT.Rows.Add(zRow)
        Next
        uxRatingTable.DataSource = zDT

        If zDT.Rows.Count > 0 Then
            Me.txtSelectedRecs.Value = zDT.Rows.Count & " Selected Recommendations"
        Else
            Me.txtSelectedRecs.Value = "No Selected Recommendations"
        End If
    End Sub

    Private Sub RatingAverageScoreGraph_ItemDataBinding(sender As Object, e As EventArgs) Handles RatingAverageScoreGraph.ItemDataBinding
        ConfigureRatingGraph(Me.RatingAverageScoreGraph, ReportDataSource.FormData.Charts(0))
        Me.RatingAverageScoreGraph.DataSource = ReportDataSource.FormData.Charts(0).GetDataPoints
    End Sub

    Private Sub AchievableAveragePercentGraph_ItemDataBinding(sender As Object, e As EventArgs) Handles AchievableAveragePercentGraph.ItemDataBinding
        ConfigureRatingGraph(Me.AchievableAveragePercentGraph, ReportDataSource.FormData.Charts(1))
        Me.AchievableAveragePercentGraph.DataSource = ReportDataSource.FormData.Charts(1).GetDataPoints
    End Sub

    Private Sub RiskImprovementGraph_ItemDataBinding(sender As Object, e As EventArgs) Handles RiskImprovementGraph.ItemDataBinding
        Dim zData As List(Of ChartingLib.ColumnChartSeriesItem) = ReportDataSource.FormData.Charts(2).GetDataPoints
        ConfigureRiskGraph(Me.RiskImprovementGraph, zData.Select(Function(x) x.Y).Max)
        Me.RiskImprovementGraph.DataSource = zData
    End Sub

    Private Sub ConfigureRatingGraph(ByRef pGraph As Graph, pChart As ChartingLib.ColumnChart)

        With pGraph

            Dim zCategoryGroup As New GraphGroup
            zCategoryGroup.Groupings.Add("=X")
            zCategoryGroup.Name = "CategoriesGroup"
            .CategoryGroups.Add(zCategoryGroup)

            Dim zSeriesGroup As New GraphGroup
            zSeriesGroup.Groupings.Add("=Series")
            zSeriesGroup.Name = "SeriesGrouping"
            .SeriesGroups.Add(zSeriesGroup)

            Dim zAxisX As New GraphAxis
            zAxisX.Name = "CategoryAxis"
            zAxisX.Scale = New CategoryScale
            zAxisX.Style.LineWidth = New Telerik.Reporting.Drawing.Unit(1)
            zAxisX.Style.LineStyle = LineStyle.Solid
            zAxisX.Style.LineColor = Color.LightGray
            zAxisX.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8, UnitType.Point)

            Dim zAxisY As New GraphAxis
            zAxisY.Name = "NumericAxis"
            zAxisY.Title = "TIV Weighted Score %"
            zAxisY.TitlePlacement = GraphAxisTitlePlacement.Centered
            zAxisY.TitleStyle.Font.Size = New Telerik.Reporting.Drawing.Unit(8, UnitType.Point)
            zAxisY.Scale = New NumericalScale()
            zAxisY.Style.LineWidth = New Telerik.Reporting.Drawing.Unit(1)
            zAxisY.Style.LineStyle = LineStyle.Solid
            zAxisY.Style.LineColor = Color.LightGray
            zAxisY.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8, UnitType.Point)
            DirectCast(zAxisY.Scale, NumericalScale).Maximum = 120
            DirectCast(zAxisY.Scale, NumericalScale).LabelStep = 20

            Dim zCS As New CartesianCoordinateSystem
            zCS.Name = "CoordinateSystem1"
            zCS.XAxis = zAxisX
            zCS.YAxis = zAxisY
            .CoordinateSystems.Add(zCS)

            Dim zRatingRanges As List(Of rowVwMetaRatingKeyRange) = GetClientFireRatingRanges().OrderBy(Function(x) x.colFldScoreLow).ToList()
            Dim zFormattingRulesList As New List(Of FormattingRule)

            For Each zRange As rowVwMetaRatingKeyRange In zRatingRanges

                Dim zRule As New FormattingRule()
                zRule.Filters.Add(New Filter("Fields.Y", FilterOperator.GreaterOrEqual, zRange.colFldScoreLow))
                zRule.Filters.Add(New Filter("Fields.Y", FilterOperator.LessOrEqual, zRange.colFldScoreHigh))
                zRule.Style.BackgroundColor = ColorTranslator.FromHtml(zRange.colHexBackColor)
                zFormattingRulesList.Add(zRule)

            Next

            Dim zSeries As New BarSeries()
            With zSeries
                .CategoryGroup = zCategoryGroup
                .SeriesGroup = zSeriesGroup
                .CoordinateSystem = zCS
                .Y = "=Y"
                .Y0 = 0
                .LegendItem.Value = "=Series"
                .LegendItem.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8, UnitType.Point)
                .ArrangeMode = GraphSeriesArrangeMode.Clustered
                .DataPointLabel = "=Y"
                .DataPointLabelAlignment = BarDataPointLabelAlignment.OutsideEnd
                .DataPointLabelStyle.Color = Color.Black
                .DataPointLabelStyle.Font.Bold = False
                .DataPointLabelStyle.Font.Size = New Telerik.Reporting.Drawing.Unit(8, UnitType.Point)

                If pGraph.Name = "AchievableAveragePercentGraph" Then
                    pGraph.ConditionalFormatting.AddRange(zFormattingRulesList.ToArray)
                    .DataPointConditionalFormatting.AddRange(zFormattingRulesList.ToArray)
                    .ColorPalette = New ColorPalette(Color.LightGray)
                Else
                    .ColorPalette = New ColorPalette("#4472C4")
                End If

                '.DataPointLabelConditionalFormatting.Add(New Telerik.Reporting.Drawing.FormattingRule())
                '.DataPointLabelConditionalFormatting(0).Style.Color = Color.Black
                '.DataPointLabelConditionalFormatting(0).Filters.Add(New Telerik.Reporting.Filter("=Y", FilterOperator.Equal, 0))

            End With

            .Series.Add(zSeries)
            .Legend.Style.Visible = pChart.ShowLegend
            .Legend.Position = GraphItemPosition.BottomCenter
            .Legend.IsInsidePlotArea = False
            .PlotAreaStyle.Padding.Right = New Telerik.Reporting.Drawing.Unit(5, UnitType.Pixel)
            .PlotAreaStyle.Padding.Top = New Telerik.Reporting.Drawing.Unit(25, UnitType.Pixel)


        End With

    End Sub

    Private Sub ConfigureRiskGraph(ByRef pGraph As Graph, pMaxValue As Double)

        With pGraph

            'BIND CATEGORIES TO THE CATEGORIES PROPERTY
            Dim zCategoryGroup As New GraphGroup
            zCategoryGroup.Groupings.Add("=X")
            zCategoryGroup.Name = "CategoriesGroup"
            .CategoryGroups.Add(zCategoryGroup)

            'BIND RISK SERIE NAMES TO THE SERIES PROPERTY
            Dim zRiskSeriesGroup As New GraphGroup
            zRiskSeriesGroup.Groupings.Add("=Series")
            zRiskSeriesGroup.Name = "RiskSeriesGrouping"
            zRiskSeriesGroup.Filters.Add(New Telerik.Reporting.Filter("=Series", Telerik.Reporting.FilterOperator.Equal, "Risk"))
            .SeriesGroups.Add(zRiskSeriesGroup)

            'CREATE SHARED CAT AXIS
            Dim zCatAxisX As New GraphAxis
            zCatAxisX.Name = "CategoryNameAxis"
            zCatAxisX.Scale = New CategoryScale
            zCatAxisX.Style.LineWidth = New Telerik.Reporting.Drawing.Unit(1)
            zCatAxisX.Style.LineStyle = LineStyle.Solid
            zCatAxisX.Style.LineColor = Color.LightGray
            zCatAxisX.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8, UnitType.Point)

            'CREATE LOSS AXIS FOR THE RISK SERIES
            Dim zLossAxisY As New GraphAxis
            zLossAxisY.Name = "LossAxis"
            zLossAxisY.Scale = New NumericalScale()
            zLossAxisY.Title = "In millions"
            zLossAxisY.TitlePlacement = GraphAxisTitlePlacement.Centered
            zLossAxisY.TitleStyle.Font.Size = New Telerik.Reporting.Drawing.Unit(8, UnitType.Point)
            zLossAxisY.Style.LineWidth = New Telerik.Reporting.Drawing.Unit(1)
            zLossAxisY.Style.LineStyle = LineStyle.Solid
            zLossAxisY.Style.LineColor = Color.LightGray
            zLossAxisY.LabelFormat = "{0:###,###,###}"
            zLossAxisY.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8, UnitType.Point)
            DirectCast(zLossAxisY.Scale, NumericalScale).Maximum = pMaxValue * 1.5


            'CREATE COORDINATE SYSTEM FOR CAT/LOSS AXIS
            Dim zCS As New CartesianCoordinateSystem
            zCS.Name = "CatNameLossCS"
            zCS.XAxis = zCatAxisX
            zCS.YAxis = zLossAxisY
            .CoordinateSystems.Add(zCS)

            'SETUP CROSSAXIS
            Dim zCrossAxis1 As New CategoryScaleCrossAxisPosition()
            Dim zCrossAxis2 As New CategoryScaleCrossAxisPosition()
            zCrossAxis1.Position = GraphScaleCrossAxisPosition.Auto
            zCrossAxis2.Position = GraphScaleCrossAxisPosition.AtMaximum
            DirectCast(zCatAxisX.Scale, CategoryScale).CrossAxisPositions.Add(zCrossAxis1)
            DirectCast(zCatAxisX.Scale, CategoryScale).CrossAxisPositions.Add(zCrossAxis2)

            'SET UP COLOR PALETTE
            Dim zBlueColorPalette As New ColorPalette("#4472C4")
            Dim zGreenColorPalette As New ColorPalette("#70AD47")

            'SET UP BARSERIES ASSIGNING Y VALUES
            Dim zSeries As New BarSeries()
            With zSeries
                .CategoryGroup = zCategoryGroup
                .SeriesGroup = zRiskSeriesGroup
                .CoordinateSystem = zCS
                .Y = "=Y"
                .Y0 = "=Y0"
                .ColorPalette = zBlueColorPalette
                .LegendItem.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9, UnitType.Point)
                .DataPointLabel = "=Y"
                .DataPointLabelFormat = "{0:###,###,###}"
                .DataPointLabelAlignment = BarDataPointLabelAlignment.OutsideEnd
                .DataPointLabelStyle.Color = Color.Black
                .DataPointLabelStyle.Font.Bold = False
                .DataPointLabelStyle.Font.Size = New Telerik.Reporting.Drawing.Unit(8, UnitType.Point)

                '.DataPointLabelConditionalFormatting.Add(New Telerik.Reporting.Drawing.FormattingRule())
                '.DataPointLabelConditionalFormatting(0).Style.Color = Color.Black
                '.DataPointLabelConditionalFormatting(0).Filters.Add(New Telerik.Reporting.Filter("=Y", FilterOperator.Equal, 0))

                .LegendItem.Value = "Risk"
                .ArrangeMode = GraphSeriesArrangeMode.Clustered
            End With

            .Series.Add(zSeries)
            .Legend.Style.Visible = False
            .Legend.Position = GraphItemPosition.BottomCenter
            .Legend.IsInsidePlotArea = False

        End With

    End Sub

    Private Sub WhatIfAnalysisSummaryReport_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        Me.txtEstimatedBudget.Value = FormatNumber(ReportDataSource.Budget, 0)
        Me.txtEstCostToComplete.Value = FormatNumber(ReportDataSource.FormData.EstCost, 0)
        Me.txtRemainingBudget.Value = FormatNumber(ReportDataSource.RemainBudget, 0)
        Me.txtLocationFilters.Value = ReportDataSource.FormData.Filter
        Me.txtSorted.Value = FilterSortLib.fsSort.ToSortText(ReportDataSource.GridData.Sort)
        Me.txtGridFilter.Value = ReportDataSource.GridData.Filter
        Me.txtTotRecSelected.Value = FormatNumber(ReportDataSource.FormData.TotalSelected, 0)
        Me.txtTotSelScoreChange.Value = FormatNumber(ReportDataSource.FormData.TotalSelectedScoreChange, 2)
        Me.txtHESelRecs.Value = FormatNumber(ReportDataSource.FormData.HumanElementSelected, 0)
        Me.txtHERecScoreChange.Value = FormatNumber(ReportDataSource.FormData.HumanElementSelectedScoreChange, 2)
        If ReportDataSource.FormData.TotalSelected > 0 Then
            Me.txtSelectedRecs.Value = FormatNumber(ReportDataSource.FormData.TotalSelected, 0) & " Selected Recommendations"
        Else
            Me.txtSelectedRecs.Value = "No Selected Recommendations"
        End If
    End Sub

    Private Function GetClientFireRatingRanges() As List(Of rowVwMetaRatingKeyRange)

        Dim zData As List(Of rowVwMetaRatingKeyRange)
        zData = razor.VwMetaRatingKeyRange.LoadByKey(ReportDataSource.Client.FireRatingKeyID)
        Return zData

    End Function

End Class