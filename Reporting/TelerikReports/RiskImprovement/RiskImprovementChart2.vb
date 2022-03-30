Imports System.ComponentModel
Imports System.Drawing

Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports GRC.Connect.Libraries.DataLib.razor



Partial Public Class RiskImprovementChart2
    Inherits BaseReportLandscape
    Implements IUtilReport
    Implements ITelerikReport

    Public Property data As DataTable = Nothing

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        UtilReport.TelerikReport.FixBaseGroups(Me)
        SetChartProperties()
        Me.FooterDatePagerPanel.Visible = False
    End Sub

    Private Sub Me_ItemDataBinding(sender As Object, e As System.EventArgs) Handles Me.ItemDataBinding


        Try

            Dim zUtilRI As New CoreLib.UtilRiskImprovement(data, rptProperties.FilePrefix)

            Me.txtStandardHeader.Visible = True
            Me.txtStandardHeader.Value = Format(Now, "dddd, MMMM dd, yyyy")

            Dim zFilePrefix As String = rptProperties.FilePrefix
            Dim zClient As rowTblClients = TblClients.LoadByPrimaryKey(zFilePrefix)

            'THE BASE VIEW ALWAYS RETURNS LOSS ESTIMATE VALUES IN US DOLLARS
            'WE WILL BE USING THE EXCHANGE TO CONVERT USDOLLAR VALUE TO FOREIGN CURRENCY VALUES
            Dim zCurrencyExchangeRate As Double = TblMetaExchangeRate.LoadByIDX_PK_tblMetaExchangeRate(zClient.colExchangeRateGroupID, TblMetaCurrency.Currencies.UsDollar, rptProperties.Currency.colFldId)(0).colFldExchangeRate

            SetRecommendationsPieValues(zUtilRI.Recommendations)
            SetRiskMitigatedBarSeries(zUtilRI.RiskMitigated, zCurrencyExchangeRate)
            SetCloseRecLast5BarSeries(zUtilRI.RiskMitigated)
            SetRiskImprovementLast5BarSeries(zUtilRI.RiskMitigated, zCurrencyExchangeRate)

        Catch ex As CoreLib.MissingLossEstimateDataException

            MissingLossEstimateExceptionMessage.Visible = True

            RiskMitigatedGraph.NoDataMessage = "" 'ex.Message
            RiskMitigatedGraph.NoDataStyle.Color = Color.Red
            RiskMitigatedGraph.NoDataStyle.TextAlign = HorizontalAlign.Center
            RiskMitigatedGraph.NoDataStyle.VerticalAlign = VerticalAlign.Middle

            RiskImprovementLast5YearGraph.NoDataMessage = "" 'ex.Message
            RiskImprovementLast5YearGraph.NoDataStyle.Color = Color.Red
            RiskImprovementLast5YearGraph.NoDataStyle.TextAlign = HorizontalAlign.Center
            RiskImprovementLast5YearGraph.NoDataStyle.VerticalAlign = VerticalAlign.Middle

            RecStatusChart.NoDataMessage = ""
            RecStatusChart.NoDataStyle.Color = Color.Red
            RecStatusChart.NoDataStyle.TextAlign = HorizontalAlign.Center
            RecStatusChart.NoDataStyle.VerticalAlign = VerticalAlign.Middle

            ClosedRecLast5YearGraph.NoDataMessage = ""
            ClosedRecLast5YearGraph.NoDataStyle.Color = Color.Red
            ClosedRecLast5YearGraph.NoDataStyle.TextAlign = HorizontalAlign.Center
            ClosedRecLast5YearGraph.NoDataStyle.VerticalAlign = VerticalAlign.Middle

        Finally

            Dim zEmptyDT As New DataTable
            zEmptyDT.Columns.Add("Empty")
            zEmptyDT.Rows.Add("")
            Me.DataSource = Nothing

        End Try

    End Sub

    Private Sub SetChartProperties()
        With RecStatusChart
            .AutoLayout = True
            .DefaultType = Charting.ChartSeriesType.Pie
            .SeriesPalette = "(None)"
            .PlotArea.Appearance.FillStyle.FillType = Charting.Styles.FillType.Solid
            .PlotArea.Appearance.FillStyle.MainColor = Color.Transparent
            .PlotArea.Appearance.Dimensions.Paddings = New Charting.Styles.ChartPaddings(0, 0, 0, 0)
            .PlotArea.Appearance.Dimensions.Margins = New Charting.Styles.ChartMargins(0, 0, 0, 0)
            .Appearance.FillStyle.FillType = Charting.Styles.FillType.Solid
            .Appearance.FillStyle.MainColor = Color.Transparent
            .Appearance.Border.Visible = False
            .Legend.Visible = False
            .Legend.Appearance.Location = Charting.Styles.LabelLocation.OutsidePlotArea
            .Legend.Appearance.Position.AlignedPosition = Charting.Styles.AlignedPositions.Bottom
            .Legend.Appearance.Overflow = Charting.Styles.Overflow.Auto
            .Legend.Appearance.ItemTextAppearance.TextProperties.Color = Color.Black
            .Legend.Appearance.ItemAppearance.Figure = "Circle"
            .Legend.Appearance.Border.Visible = False
            .PlotArea.Appearance.Border.Visible = False
            .PlotArea.EmptySeriesMessage.TextBlock.Text = ""
            .ChartTitle.Visible = False


        End With

        'With ExposureChart
        '    .AutoLayout = True
        '    .DefaultType = Charting.ChartSeriesType.Bar
        '    .SeriesPalette = "(None)"
        '    .PlotArea.Appearance.FillStyle.FillType = Charting.Styles.FillType.Solid
        '    .PlotArea.Appearance.FillStyle.MainColor = Color.White
        '    .PlotArea.Appearance.Dimensions.Paddings = New Charting.Styles.ChartPaddings(0, 0, 0, 0)
        '    .PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Color = Color.Black
        '    .PlotArea.YAxis.AxisLabel.TextBlock.Appearance.TextProperties.Color = Color.Black
        '    .PlotArea.YAxis.Visible = Charting.Styles.ChartAxisVisibility.True
        '    .PlotArea.YAxis.AxisLabel.Visible = True
        '    .PlotArea.YAxis.AxisLabel.TextBlock.Text = "Value in Millions ($USD)"
        '    .PlotArea.XAxis.AxisLabel.TextBlock.Text = "Exposure"
        '    .PlotArea.XAxis.Appearance.LabelAppearance.Visible = False
        '    .PlotArea.XAxis.AxisLabel.TextBlock.Appearance.TextProperties.Color = Color.Black
        '    .PlotArea.XAxis.AxisLabel.Visible = True
        '    .PlotArea.YAxis.Appearance.MajorGridLines.Visible = True
        '    .PlotArea.YAxis.Appearance.MajorGridLines.PenStyle = Drawing2D.DashStyle.Solid
        '    .PlotArea.YAxis.Appearance.MajorGridLines.Color = Color.Gray
        '    .PlotArea.YAxis.Appearance.MajorGridLines.Width = 0.5
        '    .PlotArea.YAxis.VisibleValues = Charting.Styles.ChartAxisVisibleValues.Positive
        '    .PlotArea.YAxis.AxisMode = Charting.ChartYAxisMode.Extended
        '    .PlotArea.YAxis.AutoScale = True
        '    .Appearance.FillStyle.FillType = Charting.Styles.FillType.Solid
        '    .Appearance.FillStyle.MainColor = Color.White
        '    .Appearance.Border.Visible = False
        '    .Legend.Visible = False
        '    .ChartTitle.Visible = False

        'End With

    End Sub

    Private Sub SetRecommendationsPieValues(ByVal pRecInfo As UtilRiskImprovement.RecStatusInfo)

        Dim zCC As UtilRiskImprovement.RecStatusItem = pRecInfo.StatusCounts.Find(Function(x) x.Status = "Conf Completed")
        Dim zRC As UtilRiskImprovement.RecStatusItem = pRecInfo.StatusCounts.Find(Function(x) x.Status = "Rptd Completed")
        Dim zIP As UtilRiskImprovement.RecStatusItem = pRecInfo.StatusCounts.Find(Function(x) x.Status = "In Progress")
        Dim zA As UtilRiskImprovement.RecStatusItem = pRecInfo.StatusCounts.Find(Function(x) x.Status = "Advisory")
        Dim zO As UtilRiskImprovement.RecStatusItem = pRecInfo.StatusCounts.Find(Function(x) x.Status = "Outstanding")
        Dim zR As UtilRiskImprovement.RecStatusItem = pRecInfo.StatusCounts.Find(Function(x) x.Status = "Removed")

        Dim zSeries As New Charting.ChartSeries("RecStatus", Charting.ChartSeriesType.Pie)

        With zSeries.Appearance
            .DiameterScale = 1
            .LegendDisplayMode = Charting.ChartSeriesLegendDisplayMode.Nothing
            .TextAppearance.TextProperties.Font = New System.Drawing.Font("Arial", 10, FontStyle.Bold)
            .TextAppearance.TextProperties.Color = Color.Black
            .LabelAppearance.LabelLocation = Charting.Styles.StyleSeriesItemLabel.ItemLabelLocation.Inside
        End With

        If zCC.Count <> 0 Then
            Dim zConfCompItem As New Charting.ChartSeriesItem(zCC.Percent, zCC.PercentText)
            If (zCC.Percent * 100) < 5 Then
                zConfCompItem.Label.Appearance.LabelLocation = Charting.Styles.StyleSeriesItemLabel.ItemLabelLocation.Outside
            End If
            zConfCompItem.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(148, 182, 0)   'green
            zConfCompItem.Appearance.FillStyle.SecondColor = System.Drawing.Color.FromArgb(140, 173, 72)   
            RecStatusChart.Legend.AddCustomItemToLegend("Conf Comp.", zConfCompItem.Appearance.FillStyle, "Circle")
            zSeries.AddItem(zConfCompItem)
        End If

        If zRC.Count <> 0 Then
            Dim zRptdCompItem As New Charting.ChartSeriesItem(zRC.Percent, zRC.PercentText)
            If (zRC.Percent * 100) < 5 Then
                zRptdCompItem.Label.Appearance.LabelLocation = Charting.Styles.StyleSeriesItemLabel.ItemLabelLocation.Outside
            End If
            zRptdCompItem.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(59, 153, 178) 'Light blue
            zRptdCompItem.Appearance.FillStyle.SecondColor = System.Drawing.Color.FromArgb(74, 169, 195)
            zRptdCompItem.Label.TextBlock.Appearance.Dimensions.Paddings.Top = New Charting.Styles.Unit(10, Charting.Styles.UnitType.Pixel)
            RecStatusChart.Legend.AddCustomItemToLegend("Rptd Comp.", zRptdCompItem.Appearance.FillStyle, "Circle")
            zSeries.AddItem(zRptdCompItem)
        End If

        If zIP.Count <> 0 Then
            Dim zInProgItem As New Charting.ChartSeriesItem(zIP.Percent, zIP.PercentText)
            If (zIP.Percent * 100) < 5 Then
                zInProgItem.Label.Appearance.LabelLocation = Charting.Styles.StyleSeriesItemLabel.ItemLabelLocation.Outside
            End If
            zInProgItem.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(110, 85, 139)   'Purple
            zInProgItem.Appearance.FillStyle.SecondColor = System.Drawing.Color.FromArgb(124, 96, 158)
            RecStatusChart.Legend.AddCustomItemToLegend("In Progress", zInProgItem.Appearance.FillStyle, "Circle")
            zSeries.AddItem(zInProgItem)
        End If

        If zR.Count <> 0 Then
            Dim zRemovedItem As New Charting.ChartSeriesItem(zR.Percent, zR.PercentText)
            If (zR.Percent * 100) < 5 Then
                zRemovedItem.Label.Appearance.LabelLocation = Charting.Styles.StyleSeriesItemLabel.ItemLabelLocation.Outside
            End If
            zRemovedItem.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(64, 112, 168)  'Dark Blue
            zRemovedItem.Appearance.FillStyle.SecondColor = System.Drawing.Color.FromArgb(83, 131, 188)
            RecStatusChart.Legend.AddCustomItemToLegend("Removed", zRemovedItem.Appearance.FillStyle, "Circle")
            zSeries.AddItem(zRemovedItem)
        End If

        If zA.Count <> 0 Then
            Dim zAdvisoryItem As New Charting.ChartSeriesItem(zA.Percent, zA.PercentText)
            If (zA.Percent * 100) < 5 Then
                zAdvisoryItem.Label.Appearance.LabelLocation = Charting.Styles.StyleSeriesItemLabel.ItemLabelLocation.Outside
            End If
            zAdvisoryItem.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(105, 73, 74)   'Brown
            zAdvisoryItem.Appearance.FillStyle.SecondColor = System.Drawing.Color.FromArgb(117, 82, 83)
            RecStatusChart.Legend.AddCustomItemToLegend("Advisory", zAdvisoryItem.Appearance.FillStyle, "Circle")
            zSeries.AddItem(zAdvisoryItem)
        End If

        If zO.Count <> 0 Then
            Dim zOutstandingItem As New Charting.ChartSeriesItem(zO.Percent, zO.PercentText)
            If (zO.Percent * 100) < 5 Then
                zOutstandingItem.Label.Appearance.LabelLocation = Charting.Styles.StyleSeriesItemLabel.ItemLabelLocation.Outside
            End If
            zOutstandingItem.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(173, 72, 69)  'Maroon
            zOutstandingItem.Appearance.FillStyle.SecondColor = System.Drawing.Color.FromArgb(185, 85, 81)
            RecStatusChart.Legend.AddCustomItemToLegend("Outstanding", zOutstandingItem.Appearance.FillStyle, "Circle")
            zSeries.AddItem(zOutstandingItem)
        End If

        Me.RecStatusChart.Series.Add(zSeries)

        SetRecommendationTitles(rptProperties.Practice.colFldReportDisplayTitle, pRecInfo.TotalCount, False)


    End Sub

    'Private Sub SetBarValues(ByVal pMigitagedInfo As UtilRiskImprovement.MitigatedInfo)

    '    Dim zIdentifiedValue As Single = pMigitagedInfo.TotalExposureIdentified / 1000000
    '    Dim zRemainingValue As Single = pMigitagedInfo.TotalExposureRemaining / 1000000
    '    Dim zIdentifiedDollar As String = FormatCurrency(pMigitagedInfo.TotalExposureIdentified / 1000000)
    '    Dim zRemainingDollar As String = FormatCurrency(pMigitagedInfo.TotalExposureRemaining / 1000000)
    '    Dim zImprovementValue As Single = pMigitagedInfo.TotalExposureReduced / 1000000
    '    Dim zImprovementDollar As String = FormatCurrency(pMigitagedInfo.TotalExposureReduced / 1000000)
    '    Dim zStarValue As Single = zImprovementValue
    '    Dim zSuffix As String = ""

    '    If zImprovementValue < 1000 And zImprovementValue > 100 Then
    '        zSuffix = "M"
    '    ElseIf zImprovementValue > 1000 Then
    '        zStarValue = zStarValue / 1000.0
    '        zSuffix = "B"
    '    End If

    '    Dim zIdentifiedSeries As New Charting.ChartSeries("TotalExposure", Charting.ChartSeriesType.Bar)
    '    Dim zRemainingSeries As New Charting.ChartSeries("RemainingExposure", Charting.ChartSeriesType.Bar)
    '    Dim zImprovementSeries As New Charting.ChartSeries("Improvement", Charting.ChartSeriesType.Bar)

    '    With zIdentifiedSeries.Appearance
    '        .BarWidthPercent = 75
    '        .TextAppearance.TextProperties.Font = New System.Drawing.Font("Arial", 8, FontStyle.Regular)
    '        .TextAppearance.TextProperties.Color = Color.Black
    '        .TextAppearance.MaxLength = 500
    '        .FillStyle.SecondColor = System.Drawing.Color.FromArgb(78, 129, 189)
    '        .FillStyle.MainColor = System.Drawing.Color.FromArgb(150, 50, 82, 122)
    '        .FillStyle.FillSettings.GradientMode = Charting.Styles.GradientFillStyle.Vertical
    '        .ShowLabels = True
    '        .TextAppearance.Visible = True
    '        .LabelAppearance.LabelLocation = Charting.Styles.StyleSeriesItemLabel.ItemLabelLocation.Outside
    '    End With

    '    With zRemainingSeries.Appearance
    '        .BarWidthPercent = 75
    '        .TextAppearance.TextProperties.Font = New System.Drawing.Font("Arial", 8, FontStyle.Regular)
    '        .TextAppearance.TextProperties.Color = Color.Black
    '        .TextAppearance.MaxLength = 500
    '        .FillStyle.SecondColor = System.Drawing.Color.FromArgb(193, 80, 76)
    '        .FillStyle.MainColor = System.Drawing.Color.FromArgb(150, 145, 60, 58)
    '        .FillStyle.FillSettings.GradientMode = Charting.Styles.GradientFillStyle.Vertical
    '    End With

    '    With zImprovementSeries.Appearance
    '        .BarWidthPercent = 75
    '        .TextAppearance.TextProperties.Font = New System.Drawing.Font("Arial", 8, FontStyle.Regular)
    '        .TextAppearance.TextProperties.Color = Color.Black
    '        .TextAppearance.MaxLength = 500
    '        .FillStyle.SecondColor = System.Drawing.Color.FromArgb(146, 208, 80)
    '        .FillStyle.MainColor = System.Drawing.Color.FromArgb(207, 234, 177)
    '        .FillStyle.FillSettings.GradientMode = Charting.Styles.GradientFillStyle.Vertical
    '    End With

    '    Dim zIdentifiedItem As New Charting.ChartSeriesItem(zIdentifiedValue, zIdentifiedDollar & System.Environment.NewLine & "Identified" & System.Environment.NewLine & "(All Recs)")
    '    Dim zRemainingItem As New Charting.ChartSeriesItem(zRemainingValue, zRemainingDollar & System.Environment.NewLine & "Remaining" & System.Environment.NewLine & "(Open Recs)")
    '    Dim zImprovementItem As New Charting.ChartSeriesItem(zImprovementValue, zImprovementDollar & System.Environment.NewLine & "Improvement" & System.Environment.NewLine & "(Closed Recs)")

    '    zRemainingSeries.Items.Add(zRemainingItem)
    '    zIdentifiedSeries.Items.Add(zIdentifiedItem)
    '    zImprovementSeries.Items.Add(zImprovementItem)


    '    'Me.ExposureChart.Series.Clear()
    '    'Me.ExposureChart.Series.Add(zIdentifiedSeries)
    '    'Me.ExposureChart.Series.Add(zRemainingSeries)
    '    'Me.ExposureChart.Series.Add(zImprovementSeries)

    '    SetChartMessage(zStarValue, zSuffix)

    'End Sub

    Private Sub SetRiskMitigatedBarSeries(ByVal pMitigatedInfo As UtilRiskImprovement.MitigatedInfo, pExchangeRate As Double)

        RiskMitigatedGraph.DataSource = pMitigatedInfo
        RiskMitigatedGraph.Legend.Style.Visible = True
        RiskMitigatedGraph.Legend.IsInsidePlotArea = True
        RiskMitigatedGraph.Legend.Style.Padding.Top = New Drawing.Unit(10)
        RiskMitigatedGraph.Legend.Position = GraphItemPosition.TopCenter

        Dim zDT As New DataTable
        zDT.Columns.Add("xValue", GetType(Double))
        zDT.Columns.Add("xCategory")
        zDT.Columns.Add("xSeries")
        zDT.Columns.Add("xDisplayText")

        Dim zTotalExposureIdentifiedInMillions As Double = Convert2Mllions(pMitigatedInfo.TotalExposureIdentified / pExchangeRate)
        Dim zTotalExposureReducedInMillions As Double = Convert2Mllions(pMitigatedInfo.TotalExposureReduced / pExchangeRate)
        Dim zTotalExposureRemainingInMillions As Double = Convert2Mllions(pMitigatedInfo.TotalExposureRemaining / pExchangeRate)
        Dim zChartBuffer As Double = 0

        zDT.Rows.Add({zTotalExposureIdentifiedInMillions, "Identified (All)", "Exposure", rptProperties.Currency.colFldSymbol & FormatNumber(zTotalExposureIdentifiedInMillions, 0)})
        zDT.Rows.Add({zTotalExposureRemainingInMillions, "Remaining (Open)", "Exposure", rptProperties.Currency.colFldSymbol & FormatNumber(zTotalExposureRemainingInMillions, 0)})
        zDT.Rows.Add({zTotalExposureReducedInMillions, "Improved (Closed)", "Exposure", rptProperties.Currency.colFldSymbol & FormatNumber(zTotalExposureReducedInMillions, 0)})

        RiskMitigatedGraph.DataSource = zDT

        'Create the category group.
        'The CategoryGroups hierarchy defines the data points in the Graph series. 
        Dim productCategoryGroup = New GraphGroup()
        productCategoryGroup.Name = "categoryGroup1"
        'Add a new grouping to the graph group.
        'In this case you have a group by product categories in the CategoryGroups hierarchy.
        'The number of different categories will determine how many data points the series will have at runtime. 
        'If the product categories consist of 'Accessories', 'Bikes', 'Components' and 'Clothing' categories, 
        'the series in the Graph will have four data points. 
        productCategoryGroup.Groupings.Add(New Grouping("=Fields.xSeries"))
        productCategoryGroup.Sortings.Add(New Sorting("=Fields.xSeries", SortDirection.Asc))
        RiskMitigatedGraph.CategoryGroups.Add(productCategoryGroup)

        'The SeriesGroups hierarchy defines the series at runtime. 
        Dim orderDateGroup = New GraphGroup()
        orderDateGroup.Name = "seriesGroup1"
        'Add a new grouping to the Graph group.
        'In this case you have a group by the Year field in the SeriesGroups hierarchy. 
        'The number of different years will determine how many series will appear on the Graph. 
        'If the Year field contains the years 2001, 2002, 2003, and 2004, 
        'the Graph will display four series for every series definition bound to this group. 
        orderDateGroup.Groupings.Add(New Grouping("=Fields.xCategory"))
        '   orderDateGroup.Sortings.Add(New Sorting("=Fields.xCategory", SortDirection.Asc))
        RiskMitigatedGraph.SeriesGroups.Add(orderDateGroup)

        'Setup Graph Axis with CategoryScale.
        'The Axis represents a single dimension of the coordinate system.
        Dim graphAxisCategoryScale = New GraphAxis()
        graphAxisCategoryScale.Name = "GraphAxis1"
        graphAxisCategoryScale.MajorTickMarkDisplayType = GraphAxisTickMarkDisplayType.None
        graphAxisCategoryScale.MinorTickMarkDisplayType = GraphAxisTickMarkDisplayType.None

        'The Scale defines how the data is projected on the axis;
        'The CategoryScale represents an ordinal scale with discrete domain like names and categories.
        graphAxisCategoryScale.Scale = New CategoryScale()
        graphAxisCategoryScale.Scale.SpacingSlotCount = 1

        'Setup Graph axis with NumericalScale.
        Dim graphAxisNumericScale = New GraphAxis()
        graphAxisNumericScale.Name = "GraphAxis2"
        graphAxisNumericScale.Title = "Value in Millions (" & rptProperties.Currency.colFldSymbol.ToString & rptProperties.Currency.colFldCode & ")"
        graphAxisNumericScale.Style.BorderStyle.Default = BorderType.None

        'The numerical scale represents a scale with continuous domain of numbers: 
        'integer numbers (Int16, Int32, Int64) or floating point numbers (Single, Double), etc;
        graphAxisNumericScale.Scale = New NumericalScale()

        If zTotalExposureIdentifiedInMillions < 1000 Then
            zChartBuffer = zTotalExposureIdentifiedInMillions / 2
        Else
            zChartBuffer = zTotalExposureIdentifiedInMillions / 5
        End If

        DirectCast(graphAxisNumericScale.Scale, NumericalScale).Maximum = zTotalExposureIdentifiedInMillions + zChartBuffer
        DirectCast(graphAxisNumericScale.Scale, NumericalScale).Minimum = 0


        'The Graph item uses a two-dimensional coordinate system that uniquely identifies the position of each data point. 
        'Each coordinate system consists of two axes(reference lines) and an origin. 
        Dim cartesianCoordinateSystem1 = New CartesianCoordinateSystem()
        cartesianCoordinateSystem1.Name = "cartesianCoordinateSystem1"
        cartesianCoordinateSystem1.XAxis = graphAxisCategoryScale
        cartesianCoordinateSystem1.YAxis = graphAxisNumericScale
        RiskMitigatedGraph.CoordinateSystems.Add(cartesianCoordinateSystem1)


        'Color Palette
        Dim zBlue As System.Drawing.Color = System.Drawing.Color.FromArgb(55, 129, 183)
        Dim zRed As System.Drawing.Color = System.Drawing.Color.FromArgb(215, 77, 71)
        Dim zGreen As System.Drawing.Color = System.Drawing.Color.FromArgb(146, 208, 80)
        Dim zCP As New ColorPalette({zBlue, zRed, zGreen})


        'The Graph Series are series of data points that represents individual measurements.
        'At runtime the intersection between the series group hierarchy members 
        'and the category group hierarchy members defines the data points in the series.
        'For each data point one or more aggregate functions are calculated to define 
        'the value/coordinates of the data points.
        Dim barSeries1 = New BarSeries()
        barSeries1.CategoryGroup = productCategoryGroup
        barSeries1.CoordinateSystem = cartesianCoordinateSystem1
        barSeries1.LegendItem.Value = "= Fields.xCategory"
        barSeries1.SeriesGroup = orderDateGroup
        barSeries1.Y = "=Fields.xValue"
        barSeries1.DataPointLabel = "=Fields.xDisplayText"
        barSeries1.DataPointLabelStyle.Font.Bold = True
        barSeries1.DataPointLabelStyle.Font.Size = New Drawing.Unit(10)
        barSeries1.DataPointLabelStyle.TextAlign = HorizontalAlign.Center
        barSeries1.ColorPalette = zCP
        RiskMitigatedGraph.Series.Add(barSeries1)

        SetRiskImprovementTitles(Convert2Mllions(pMitigatedInfo.TotalExposureReduced / pExchangeRate), False)


    End Sub

    'Private Sub SetCloseRecLast5BarSeries(ByVal pMitigatedInfo As UtilRiskImprovement.MitigatedInfo)
    '    Dim zLast5 As List(Of UtilRiskImprovement.RiskYear) = GetLast5Years(pMitigatedInfo)
    '    Dim zMaxRecCount As Integer = 0
    '    Dim zCloseCount As Integer = 0
    '    zLast5.ForEach(Sub(x) zMaxRecCount = IIf(x.RecCountClosed > zMaxRecCount, x.RecCountClosed, zMaxRecCount))
    '    zLast5.ForEach(Sub(x) zCloseCount += x.RecCountClosed)

    '    uxClosedRecLast5YearsText.Value = "<p style='text-align: center'><strong>Closed Recs " & zCloseCount & "</strong></p>"
    '    ClosedRecLast5YearGraph.DataSource = zLast5
    '    ClosedRecLast5YearGraph.Legend.Style.Visible = True

    '    'Create the category group.
    '    'The CategoryGroups hierarchy defines the data points in the Graph series. 
    '    Dim productCategoryGroup = New GraphGroup()
    '    productCategoryGroup.Name = "categoryGroup1"
    '    'Add a new grouping to the graph group.
    '    'In this case you have a group by product categories in the CategoryGroups hierarchy.
    '    'The number of different categories will determine how many data points the series will have at runtime. 
    '    'If the product categories consist of 'Accessories', 'Bikes', 'Components' and 'Clothing' categories, 
    '    'the series in the Graph will have four data points. 
    '    productCategoryGroup.Groupings.Add(New Grouping("=Fields.RecYear"))
    '    productCategoryGroup.Sortings.Add(New Sorting("=Fields.RecYear", SortDirection.Asc))
    '    ClosedRecLast5YearGraph.CategoryGroups.Add(productCategoryGroup)

    '    'The SeriesGroups hierarchy defines the series at runtime. 
    '    Dim orderDateGroup = New GraphGroup()
    '    orderDateGroup.Name = "seriesGroup1"
    '    'Add a new grouping to the Graph group.
    '    'In this case you have a group by the Year field in the SeriesGroups hierarchy. 
    '    'The number of different years will determine how many series will appear on the Graph. 
    '    'If the Year field contains the years 2001, 2002, 2003, and 2004, 
    '    'the Graph will display four series for every series definition bound to this group. 
    '    'orderDateGroup.Groupings.Add(New Grouping("=Fields.RecYear"))
    '    'orderDateGroup.Sortings.Add(New Sorting("=Fields.RecYear", SortDirection.Asc))
    '    ClosedRecLast5YearGraph.SeriesGroups.Add(orderDateGroup)

    '    'Setup Graph Axis with CategoryScale.
    '    'The Axis represents a single dimension of the coordinate system.
    '    Dim graphAxisCategoryScale = New GraphAxis()
    '    graphAxisCategoryScale.Name = "GraphAxis1"
    '    graphAxisCategoryScale.MajorTickMarkDisplayType = GraphAxisTickMarkDisplayType.None
    '    graphAxisCategoryScale.MinorTickMarkDisplayType = GraphAxisTickMarkDisplayType.None

    '    'The Scale defines how the data is projected on the axis;
    '    'The CategoryScale represents an ordinal scale with discrete domain like names and categories.
    '    graphAxisCategoryScale.Scale = New CategoryScale()

    '    'Setup Graph axis with NumericalScale.
    '    Dim graphAxisNumericScale = New GraphAxis()
    '    graphAxisNumericScale.Name = "GraphAxis2"
    '    graphAxisNumericScale.Title = "Closed Recommendations"
    '    graphAxisNumericScale.Style.BorderStyle.Default = BorderType.None

    '    'The numerical scale represents a scale with continuous domain of numbers: 
    '    'integer numbers (Int16, Int32, Int64) or floating point numbers (Single, Double), etc;
    '    graphAxisNumericScale.Scale = New NumericalScale()
    '    DirectCast(graphAxisNumericScale.Scale, NumericalScale).Maximum = zMaxRecCount + 100

    '    'The Graph item uses a two-dimensional coordinate system that uniquely identifies the position of each data point. 
    '    'Each coordinate system consists of two axes(reference lines) and an origin. 
    '    Dim cartesianCoordinateSystem1 = New CartesianCoordinateSystem()
    '    cartesianCoordinateSystem1.Name = "cartesianCoordinateSystem1"
    '    cartesianCoordinateSystem1.XAxis = graphAxisCategoryScale
    '    cartesianCoordinateSystem1.YAxis = graphAxisNumericScale
    '    ClosedRecLast5YearGraph.CoordinateSystems.Add(cartesianCoordinateSystem1)


    '    'Color Palette
    '    Dim zCPGreen As New ColorPalette(System.Drawing.Color.FromArgb(0, 178, 82))
    '    Dim zCPBlue As New ColorPalette(System.Drawing.Color.FromArgb(55, 129, 183))

    '    'The Graph Series are series of data points that represents individual measurements.
    '    'At runtime the intersection between the series group hierarchy members 
    '    'and the category group hierarchy members defines the data points in the series.
    '    'For each data point one or more aggregate functions are calculated to define 
    '    'the value/coordinates of the data points.
    '    Dim barSeries1 = New BarSeries()
    '    barSeries1.CategoryGroup = productCategoryGroup
    '    barSeries1.CoordinateSystem = cartesianCoordinateSystem1
    '    barSeries1.LegendItem.Value = "= Fields.RecCount"
    '    barSeries1.SeriesGroup = orderDateGroup
    '    barSeries1.Y = "=Fields.RecCount"
    '    barSeries1.DataPointLabel = "=Fields.RecCount"
    '    barSeries1.DataPointLabelStyle.TextAlign = HorizontalAlign.Center
    '    barSeries1.ColorPalette = zCPBlue
    '    ClosedRecLast5YearGraph.Series.Add(barSeries1)


    '    Dim barSeries2 = New BarSeries()
    '    With barSeries2
    '        .CategoryGroup = productCategoryGroup
    '        .CoordinateSystem = cartesianCoordinateSystem1
    '        .LegendItem.Value = "= Fields.RecCountClosed"
    '        .SeriesGroup = orderDateGroup
    '        .Y = "=Fields.RecCountClosed"
    '        .DataPointLabel = "=Fields.RecCountClosed"
    '        .DataPointLabelStyle.TextAlign = HorizontalAlign.Center
    '        .ColorPalette = zCPGreen
    '        ClosedRecLast5YearGraph.Series.Add(barSeries2)
    '    End With


    'End Sub

    Private Sub SetCloseRecLast5BarSeries(ByVal pMitigatedInfo As UtilRiskImprovement.MitigatedInfo)
        Dim zLast5 As List(Of UtilRiskImprovement.RiskYear) = GetLast5Years(pMitigatedInfo)
        Dim zMaxRecCount As Integer = 0
        Dim zCloseCount As Integer = 0
        zLast5.ForEach(Sub(x) zMaxRecCount = IIf(x.RecCountClosed > zMaxRecCount, x.RecCountClosed, zMaxRecCount))
        zLast5.ForEach(Sub(x) zMaxRecCount = IIf(x.RecCount > zMaxRecCount, x.RecCount, zMaxRecCount))
        zLast5.ForEach(Sub(x) zCloseCount += x.RecCountClosed)

        ClosedRecLast5YearGraph.DataSource = zLast5
        ClosedRecLast5YearGraph.Legend.Style.Visible = True
        ClosedRecLast5YearGraph.Legend.IsInsidePlotArea = False
        ClosedRecLast5YearGraph.Legend.Position = GraphItemPosition.TopCenter
        'ClosedRecLast5YearGraph.Legend.Style.Padding.Top = New Unit(10)
        'ClosedRecLast5YearGraph.Legend.Style.Padding.Bottom = New Unit(10)


        'Create the category group.
        'The CategoryGroups hierarchy defines the data points in the Graph series. 
        Dim productCategoryGroup = New GraphGroup()
        productCategoryGroup.Name = "categoryGroup1"
        'Add a new grouping to the graph group.
        'In this case you have a group by product categories in the CategoryGroups hierarchy.
        'The number of different categories will determine how many data points the series will have at runtime. 
        'If the product categories consist of 'Accessories', 'Bikes', 'Components' and 'Clothing' categories, 
        'the series in the Graph will have four data points. 
        productCategoryGroup.Groupings.Add(New Grouping("=Fields.RecYear"))
        productCategoryGroup.Sortings.Add(New Sorting("=Fields.RecYear", SortDirection.Asc))
        ClosedRecLast5YearGraph.CategoryGroups.Add(productCategoryGroup)

        'The SeriesGroups hierarchy defines the series at runtime. 
        Dim orderDateGroup = New GraphGroup()
        orderDateGroup.Name = "seriesGroup1"
        'Add a new grouping to the Graph group.
        'In this case you have a group by the Year field in the SeriesGroups hierarchy. 
        'The number of different years will determine how many series will appear on the Graph. 
        'If the Year field contains the years 2001, 2002, 2003, and 2004, 
        'the Graph will display four series for every series definition bound to this group. 
        'orderDateGroup.Groupings.Add(New Grouping("=Fields.RecYear"))
        'orderDateGroup.Sortings.Add(New Sorting("=Fields.RecYear", SortDirection.Asc))
        ClosedRecLast5YearGraph.SeriesGroups.Add(orderDateGroup)

        'Setup Graph Axis with CategoryScale.
        'The Axis represents a single dimension of the coordinate system.
        Dim graphAxisCategoryScale = New GraphAxis()
        graphAxisCategoryScale.Name = "GraphAxis1"
        graphAxisCategoryScale.MajorTickMarkDisplayType = GraphAxisTickMarkDisplayType.None
        graphAxisCategoryScale.MinorTickMarkDisplayType = GraphAxisTickMarkDisplayType.None

        'The Scale defines how the data is projected on the axis;
        'The CategoryScale represents an ordinal scale with discrete domain like names and categories.
        graphAxisCategoryScale.Scale = New CategoryScale()

        'Setup Graph axis with NumericalScale.
        Dim graphAxisNumericScale = New GraphAxis()
        graphAxisNumericScale.Name = "GraphAxis2"
        graphAxisNumericScale.Title = "Recommendations"
        graphAxisNumericScale.Style.BorderStyle.Default = BorderType.None

        'The numerical scale represents a scale with continuous domain of numbers: 
        'integer numbers (Int16, Int32, Int64) or floating point numbers (Single, Double), etc;
        graphAxisNumericScale.Scale = New NumericalScale()
        DirectCast(graphAxisNumericScale.Scale, NumericalScale).Maximum = PadMaxRecCount(zMaxRecCount)

        'The Graph item uses a two-dimensional coordinate system that uniquely identifies the position of each data point. 
        'Each coordinate system consists of two axes(reference lines) and an origin. 
        Dim cartesianCoordinateSystem1 = New CartesianCoordinateSystem()
        cartesianCoordinateSystem1.Name = "cartesianCoordinateSystem1"
        cartesianCoordinateSystem1.XAxis = graphAxisCategoryScale
        cartesianCoordinateSystem1.YAxis = graphAxisNumericScale
        ClosedRecLast5YearGraph.CoordinateSystems.Add(cartesianCoordinateSystem1)


        'Color Palette
        Dim zCPGreen As New ColorPalette(System.Drawing.Color.FromArgb(0, 178, 82))
        Dim zCPBlue As New ColorPalette(System.Drawing.Color.FromArgb(55, 129, 183))

        'The Graph Series are series of data points that represents individual measurements.
        'At runtime the intersection between the series group hierarchy members 
        'and the category group hierarchy members defines the data points in the series.
        'For each data point one or more aggregate functions are calculated to define 
        'the value/coordinates of the data points.
        Dim barSeries1 = New BarSeries()
        barSeries1.CategoryGroup = productCategoryGroup
        barSeries1.CoordinateSystem = cartesianCoordinateSystem1
        barSeries1.LegendItem.Value = "New Recs"
        barSeries1.SeriesGroup = orderDateGroup
        barSeries1.Y = "=Fields.RecCount"
        barSeries1.DataPointLabel = "=Fields.RecCount"
        barSeries1.DataPointLabelStyle.Font.Bold = True
        barSeries1.DataPointLabelStyle.Font.Size = New Drawing.Unit(10)
        barSeries1.DataPointLabelStyle.TextAlign = HorizontalAlign.Center
        barSeries1.ColorPalette = zCPBlue
        ClosedRecLast5YearGraph.Series.Add(barSeries1)


        Dim barSeries2 = New BarSeries()
        With barSeries2
            .CategoryGroup = productCategoryGroup
            .CoordinateSystem = cartesianCoordinateSystem1
            .LegendItem.Value = "Closed Recs"
            .SeriesGroup = orderDateGroup
            .Y = "=Fields.RecCountClosed"
            .DataPointLabel = "=Fields.RecCountClosed"
            .DataPointLabelStyle.Font.Bold = True
            .DataPointLabelStyle.Font.Size = New Drawing.Unit(10)

            .DataPointLabelStyle.TextAlign = HorizontalAlign.Center
            .ColorPalette = zCPGreen
            ClosedRecLast5YearGraph.Series.Add(barSeries2)
        End With

        SetRecommendationTitles(rptProperties.Practice.colFldReportDisplayTitle, zCloseCount, True)


    End Sub



    Private Sub SetRiskImprovementLast5BarSeries(ByVal pMitigatedInfo As UtilRiskImprovement.MitigatedInfo, pExchangeRate As Double)
        Dim zLast5 As List(Of UtilRiskImprovement.RiskYear) = GetLast5Years(pMitigatedInfo)
        Dim zTotalExposureReduced As Long = 0
        Dim zMaxValue As Long = 0

        zLast5.ForEach(Sub(x) x.ExposureReduced = Convert2Mllions(x.ExposureReduced / pExchangeRate))
        zLast5.ForEach(Sub(x) x.ExposureIdentified = Convert2Mllions(x.ExposureIdentified / pExchangeRate))
        zLast5.ForEach(Sub(x) x.TotalLossEstimateAfter = Convert2Mllions(x.TotalLossEstimateAfter / pExchangeRate))
        zLast5.ForEach(Sub(x) x.TotalLossEstimateBefore = Convert2Mllions(x.TotalLossEstimateBefore / pExchangeRate))
        zLast5.ForEach(Sub(x) zMaxValue = IIf(x.ExposureIdentified > zMaxValue, x.ExposureIdentified, zMaxValue))
        zLast5.ForEach(Sub(x) zMaxValue = IIf(x.ExposureReduced > zMaxValue, x.ExposureReduced, zMaxValue))
        zLast5.ForEach(Sub(x) zTotalExposureReduced += x.ExposureReduced)

        For Each zYear As UtilRiskImprovement.RiskYear In zLast5
            If zYear.ExposureIdentified = 0 Then
                zYear.ExposureIdentified = 0.001
            End If

            If zYear.ExposureReduced = 0 Then
                zYear.ExposureReduced = 0.001
            End If
        Next

        RiskImprovementLast5YearGraph.DataSource = zLast5
        RiskImprovementLast5YearGraph.Legend.IsInsidePlotArea = False
        RiskImprovementLast5YearGraph.Legend.Position = GraphItemPosition.TopCenter
        'RiskImprovementLast5YearGraph.Legend.Style.Padding.Top = New Unit(10)

        'Create the category group.
        'The CategoryGroups hierarchy defines the data points in the Graph series. 
        Dim productCategoryGroup = New GraphGroup()
        productCategoryGroup.Name = "categoryGroup1"
        'Add a new grouping to the graph group.
        'In this case you have a group by product categories in the CategoryGroups hierarchy.
        'The number of different categories will determine how many data points the series will have at runtime. 
        'If the product categories consist of 'Accessories', 'Bikes', 'Components' and 'Clothing' categories, 
        'the series in the Graph will have four data points. 
        productCategoryGroup.Groupings.Add(New Grouping("=Fields.RecYear"))
        productCategoryGroup.Sortings.Add(New Sorting("=Fields.RecYear", SortDirection.Asc))
        RiskImprovementLast5YearGraph.CategoryGroups.Add(productCategoryGroup)

        'The SeriesGroups hierarchy defines the series at runtime. 
        Dim orderDateGroup = New GraphGroup()
        orderDateGroup.Name = "seriesGroup1"
        'Add a new grouping to the Graph group.
        'In this case you have a group by the Year field in the SeriesGroups hierarchy. 
        'The number of different years will determine how many series will appear on the Graph. 
        'If the Year field contains the years 2001, 2002, 2003, and 2004, 
        'the Graph will display four series for every series definition bound to this group. 
        'orderDateGroup.Groupings.Add(New Grouping("=Fields.RecYear"))
        'orderDateGroup.Sortings.Add(New Sorting("=Fields.RecYear", SortDirection.Asc))
        RiskImprovementLast5YearGraph.SeriesGroups.Add(orderDateGroup)

        'Setup Graph Axis with CategoryScale.
        'The Axis represents a single dimension of the coordinate system.
        Dim graphAxisCategoryScale = New GraphAxis()
        graphAxisCategoryScale.Name = "GraphAxis1"

        'The Scale defines how the data is projected on the axis;
        'The CategoryScale represents an ordinal scale with discrete domain like names and categories.
        graphAxisCategoryScale.Scale = New CategoryScale()

        'Setup Graph axis with NumericalScale.
        Dim graphAxisNumericScale = New GraphAxis()
        graphAxisNumericScale.Title = "Value in Millions (" & rptProperties.Currency.colFldSymbol & rptProperties.Currency.colFldCode & ")"
        graphAxisNumericScale.Name = "GraphAxis2"
        graphAxisCategoryScale.MajorTickMarkDisplayType = GraphAxisTickMarkDisplayType.None
        graphAxisCategoryScale.MinorTickMarkDisplayType = GraphAxisTickMarkDisplayType.None

        'The numerical scale represents a scale with continuous domain of numbers: 
        'integer numbers (Int16, Int32, Int64) or floating point numbers (Single, Double), etc;
        graphAxisNumericScale.Scale = New NumericalScale()
        DirectCast(graphAxisNumericScale.Scale, NumericalScale).Maximum = PadMaxExposure(zMaxValue)
        DirectCast(graphAxisNumericScale.Scale, NumericalScale).Minimum = 0


        'The Graph item uses a two-dimensional coordinate system that uniquely identifies the position of each data point. 
        'Each coordinate system consists of two axes(reference lines) and an origin. 
        Dim cartesianCoordinateSystem1 = New CartesianCoordinateSystem()
        cartesianCoordinateSystem1.Name = "cartesianCoordinateSystem1"
        cartesianCoordinateSystem1.XAxis = graphAxisCategoryScale
        cartesianCoordinateSystem1.YAxis = graphAxisNumericScale
        RiskImprovementLast5YearGraph.CoordinateSystems.Add(cartesianCoordinateSystem1)


        'Color Palette
        Dim zCPGreen As New ColorPalette(System.Drawing.Color.FromArgb(0, 178, 82))
        Dim zCPBlue As New ColorPalette(System.Drawing.Color.FromArgb(55, 129, 183))


        'The Graph Series are series of data points that represents individual measurements.
        'At runtime the intersection between the series group hierarchy members 
        'and the category group hierarchy members defines the data points in the series.
        'For each data point one or more aggregate functions are calculated to define 
        'the value/coordinates of the data points.
        Dim barSeries1 = New BarSeries()
        barSeries1.CategoryGroup = productCategoryGroup
        barSeries1.CoordinateSystem = cartesianCoordinateSystem1
        barSeries1.SeriesGroup = orderDateGroup
        barSeries1.LegendItem.Value = "Identified"
        barSeries1.Y = "=Fields.ExposureIdentified"
        barSeries1.DataPointLabel = rptProperties.Currency.colFldSymbol & "{Fields.ExposureIdentifiedString}"
        barSeries1.DataPointLabelStyle.Font.Bold = True
        barSeries1.DataPointLabelStyle.Font.Size = New Drawing.Unit(9)
        barSeries1.DataPointLabelStyle.TextAlign = HorizontalAlign.Left
        barSeries1.ColorPalette = zCPBlue
        RiskImprovementLast5YearGraph.Series.Add(barSeries1)

        Dim barSeries2 = New BarSeries()
        With barSeries2
            .CategoryGroup = productCategoryGroup
            .CoordinateSystem = cartesianCoordinateSystem1
            .LegendItem.Value = "Improved"
            .SeriesGroup = orderDateGroup
            .Y = "=Fields.ExposureReduced"
            .DataPointLabel = rptProperties.Currency.colFldSymbol & "{Fields.ExposureReducedString}"
            .DataPointLabelStyle.Font.Bold = True
            .DataPointLabelStyle.Font.Size = New Drawing.Unit(9)
            .DataPointLabelStyle.TextAlign = HorizontalAlign.Right
            .ColorPalette = zCPGreen
            RiskImprovementLast5YearGraph.Series.Add(barSeries2)
        End With


        SetRiskImprovementTitles(zTotalExposureReduced, True)

    End Sub

    Private Function GetLast5Years(ByVal pMitigatedInfo As UtilRiskImprovement.MitigatedInfo) As List(Of UtilRiskImprovement.RiskYear)
        Dim zDescendingList As List(Of UtilRiskImprovement.RiskYear) = pMitigatedInfo.RiskYearList.OrderByDescending(Function(x) x.RecYear).ToList
        Dim zLast5Years As New List(Of UtilRiskImprovement.RiskYear)
        If zDescendingList.Count > 5 Then
            For i = 0 To 4 Step 1
                zLast5Years.Add(zDescendingList(i))
            Next
        End If
        Return zLast5Years
    End Function

    Private Sub SetRecommendationTitles(ByVal pPractice As String, ByVal pAmount As Integer, pIsClosedRecAmount As Boolean)
        Me.RecStatusTitle.Value = "<p style='text-align: center'><strong>" & System.Web.HttpUtility.HtmlEncode(pPractice) & " Recommendations</strong></p>"
        Me.uxClosedRecLast5YearsPracticeText.Value = "<p style='text-align: center'><strong>" & System.Web.HttpUtility.HtmlEncode(pPractice) & " Recommendations</strong></p>"

        If pIsClosedRecAmount Then
            Me.uxClosedRecLast5YearsText.Value = "<p style='text-align: center'>" & FormatNumber(pAmount, 0) & " Closed Recommendations</p>"
        Else
            Me.RecStatusSubTitle.Value = "<p style='text-align: center'>" & FormatNumber(pAmount, 0) & " Total Recommendations</p>"
        End If

    End Sub

    Private Sub SetRiskImprovementTitles(ByVal pImprovementValueInMillions As String, pIsLastFiveYears As Boolean)
        Dim zValueString As String = rptProperties.Currency.colFldSymbol & FormatNumber(pImprovementValueInMillions, 0) & "M"
        Dim zSubTitleHeader As String = "Life of Program"
        If pIsLastFiveYears Then zSubTitleHeader = "Last Five Years"

        If pIsLastFiveYears Then
            Me.uxRILast5YearsText.Value = "<p style='text-align: center'>" & zSubTitleHeader & "&nbsp;" & zValueString & "&nbsp;(" & rptProperties.Currency.colFldCode & ")</p>"
        Else
            Me.uxStarText.Value = "<p style='text-align: center'><br><br><span style='font-size: 9pt; text-align: center'><strong>" & zValueString & "<br />Risk Improvement</strong></span></p>"
            Me.uxLifeOfProgramText.Value = "<p style='text-align: center'>" & zSubTitleHeader & "&nbsp;" & zValueString & "&nbsp;(" & rptProperties.Currency.colFldCode & ")</p>"
        End If

    End Sub

    Private Function Convert2Mllions(pValue As Long) As Double
        Return FormatNumber(pValue / 1000000, 1)
    End Function

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties

    Public Function AppendPracticeToTitle() As Boolean Implements ITelerikReport.AppendPracticeToTitle
        Return False
    End Function

    Public Function IsStandardHeader() As Boolean Implements ITelerikReport.IsStandardHeader
        Return False
    End Function

    Public Function ReportSubSubTitle() As String Implements ITelerikReport.ReportSubSubTitle
        Return ""
    End Function

    Public Function ReportSubTitle() As String Implements ITelerikReport.ReportSubTitle
        Dim zPractice As String = "Fire"
        If rptProperties.Practice.Practice = TblMetaPractice.Practices.BM Then zPractice = "B&amp;M"
        If rptProperties.Practice.Practice = TblMetaPractice.Practices.ProcessSafety Then zPractice = "Process Safety"
        Return zPractice & " Risk Improvement"
    End Function

    Public Function ReportTitle() As String Implements ITelerikReport.ReportTitle
        Return rptProperties.ClientName
    End Function

    Private Sub RiskImprovementChart_ItemDataBound(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        UtilReport.TelerikReport.SetFilterText(sender, rptProperties)
        UtilReport.TelerikReport.SetDisclaimerText(sender, rptProperties)
        UtilReport.TelerikReport.SetSortText(sender, rptProperties)
    End Sub

    Private Function PadMaxRecCount(ByVal pMaxCount As Integer) As Integer
        Dim zPadAmt As Integer = pMaxCount * 0.2
        Return pMaxCount + zPadAmt
        ' Return pMaxCount
    End Function

    Private Function PadMaxExposure(ByVal pMaxExposure As Integer) As Integer
        Dim zPadAmt As Integer = pMaxExposure * 0.2
        Return pMaxExposure + zPadAmt
        'Return pMaxExposure
    End Function

End Class