Imports System.ComponentModel
Imports System.Drawing
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports Telerik.Reporting.Expressions
Imports Telerik.ReportViewer

Partial Public Class ProgramStatusReport
    Inherits BaseReportPortrait

    Public Sub New(ByVal pGuid As String, Optional ByVal pReport As Core.UtilReporting.Reports = 0)

        MyBase.New(pGuid, pReport)
        InitializeComponent()
        Me.txtPageCounter.Visible = False

        SetDefaultProperties(Me.Chart1)
        SetDefaultProperties(Me.Chart2)

        Dim zSpcFeature As String = Core.UtilGSafe.GetValue(Me.Guid, "clientFeatures")

        If Not zSpcFeature.ToLower.Contains("j") Then
            Me.JurisObjectsPanel.Visible = False
            Me.JurisInnerPanel.Height = New Telerik.Reporting.Drawing.Unit(0.0, UnitType.Inch)
            Me.pnlJuris.Height = New Telerik.Reporting.Drawing.Unit(0.0, UnitType.Inch)
            Me.pnlFacilityRating.Height = New Telerik.Reporting.Drawing.Unit(Me.pnlFacilityRating.Height.Subtract(Me.JurisObjectsPanel.Height).Value, UnitType.Inch)
        End If

    End Sub

    Public Sub New(ByVal pJobId As Integer)

        MyBase.New(pJobId)
        InitializeComponent()
        Me.txtPageCounter.Visible = False
        SetDefaultProperties(Me.Chart1)
        SetDefaultProperties(Me.Chart2)

        Dim zSpcFeature As String = Core.UtilGSafe.GetValue(Me.Guid, "clientFeatures")

        If Not zSpcFeature.ToLower.Contains("j") Then
            Me.JurisObjectsPanel.Visible = False
            Me.JurisInnerPanel.Height = New Telerik.Reporting.Drawing.Unit(0.0, UnitType.Inch)
            Me.pnlJuris.Height = New Telerik.Reporting.Drawing.Unit(0.0, UnitType.Inch)
            Me.pnlFacilityRating.Height = New Telerik.Reporting.Drawing.Unit(Me.pnlFacilityRating.Height.Subtract(Me.JurisObjectsPanel.Height).Value, UnitType.Inch)
        End If

    End Sub

    Private Sub ProgramStatusReport_ItemDataBinding(sender As Object, e As System.EventArgs) Handles Me.ItemDataBinding
        Dim zDt As DataTable = DirectCast(sender.datasource, DataTable)

        Dim zNewDT As DataTable = zDt.Copy
        Me.DataSource = zNewDT

        Dim zRatingTables As Core.RatingTables = Core.UtilProgramStatus.GetRatingTables(zNewDT, Me.FilePrefix)

        'Set the datasource to the FireRating Table on Report
        Me.FireRatingTable.DataSource = zRatingTables.Fire

        'Create Risk Series for chart
        Dim zRiskSeries As New RiskSeries
        zRiskSeries.RiskRating1Value = zRatingTables.Fire.Rows(0)("Percent") * 100
        zRiskSeries.RiskRating1Text = FormatNumber(zRiskSeries.RiskRating1Value, 1) & "%"
        zRiskSeries.RiskRating1Color = GetColorFromHex(zRatingTables.Fire.Rows(0)("ColorHex"))

        zRiskSeries.RiskRating2Value = zRatingTables.Fire.Rows(1)("Percent") * 100
        zRiskSeries.RiskRating2Text = FormatNumber(zRiskSeries.RiskRating2Value, 1) & "%"
        zRiskSeries.RiskRating2Color = GetColorFromHex(zRatingTables.Fire.Rows(1)("ColorHex"))


        zRiskSeries.RiskRating3Value = zRatingTables.Fire.Rows(2)("Percent") * 100
        zRiskSeries.RiskRating3Text = FormatNumber(zRiskSeries.RiskRating3Value, 1) & "%"
        zRiskSeries.RiskRating3Color = GetColorFromHex(zRatingTables.Fire.Rows(2)("ColorHex"))


        If zRatingTables.Fire.Rows.Count >= 4 Then
            zRiskSeries.RiskRating4Value = zRatingTables.Fire.Rows(3)("Percent") * 100
            zRiskSeries.RiskRating4Text = FormatNumber(zRiskSeries.RiskRating4Value, 1) & "%"
            zRiskSeries.RiskRating4Color = GetColorFromHex(zRatingTables.Fire.Rows(3)("ColorHex"))

        End If


        If zRatingTables.Fire.Rows.Count >= 5 Then
            zRiskSeries.RiskRating5Value = zRatingTables.Fire.Rows(4)("Percent") * 100
            zRiskSeries.RiskRating5Text = FormatNumber(zRiskSeries.RiskRating5Value, 1) & "%"
            zRiskSeries.RiskRating5Color = GetColorFromHex(zRatingTables.Fire.Rows(4)("ColorHex"))

        End If



        'Get the RatingTables from the datatable

        'Set the datasource to the BmRating Table
        Me.BMRatingTable.DataSource = zRatingTables.BM

        'Create Risk Series
        Dim zBMRiskSeries As New RiskSeries
        zBMRiskSeries.RiskRating1Value = zRatingTables.BM.Rows(0)("Percent") * 100
        zBMRiskSeries.RiskRating1Text = FormatNumber(zBMRiskSeries.RiskRating1Value, 1) & "%"
        zBMRiskSeries.RiskRating1Color = GetColorFromHex(zRatingTables.BM.Rows(0)("ColorHex"))


        zBMRiskSeries.RiskRating2Value = zRatingTables.BM.Rows(1)("Percent") * 100
        zBMRiskSeries.RiskRating2Text = FormatNumber(zBMRiskSeries.RiskRating2Value, 1) & "%"
        zBMRiskSeries.RiskRating2Color = GetColorFromHex(zRatingTables.BM.Rows(1)("ColorHex"))


        zBMRiskSeries.RiskRating3Value = zRatingTables.BM.Rows(2)("Percent") * 100
        zBMRiskSeries.RiskRating3Text = FormatNumber(zBMRiskSeries.RiskRating3Value, 1) & "%"
        zBMRiskSeries.RiskRating3Color = GetColorFromHex(zRatingTables.BM.Rows(2)("ColorHex"))


        If zRatingTables.BM.Rows.Count >= 4 Then
            zBMRiskSeries.RiskRating4Value = zRatingTables.BM.Rows(3)("Percent") * 100
            zBMRiskSeries.RiskRating4Text = FormatNumber(zBMRiskSeries.RiskRating4Value, 1) & "%"
            zBMRiskSeries.RiskRating4Color = GetColorFromHex(zRatingTables.BM.Rows(3)("ColorHex"))

        End If

        If zRatingTables.BM.Rows.Count >= 5 Then
            zBMRiskSeries.RiskRating5Value = zRatingTables.BM.Rows(4)("Percent") * 100
            zBMRiskSeries.RiskRating5Text = FormatNumber(zBMRiskSeries.RiskRating5Value, 1) & "%"
            zBMRiskSeries.RiskRating5Color = GetColorFromHex(zRatingTables.BM.Rows(4)("ColorHex"))

        End If

        If zBMRiskSeries.RiskRating1Value = 0 And zBMRiskSeries.RiskRating2Value = 0 And zBMRiskSeries.RiskRating3Value = 0 Then
            Chart2.DataSource = Nothing
            Chart2.Series.Clear()
            Chart2.PlotArea.EmptySeriesMessage.TextBlock.Text = "N/A"
            Chart2.PlotArea.EmptySeriesMessage.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.Red
        Else
            AddRiskSeries(Chart2, zBMRiskSeries)
        End If

        If zRiskSeries.RiskRating1Value = 0 And zRiskSeries.RiskRating2Value = 0 And zRiskSeries.RiskRating3Value = 0 Then
            Chart1.DataSource = Nothing
            Chart1.Series.Clear()
            Chart1.PlotArea.EmptySeriesMessage.TextBlock.Text = "N/A"
            Chart1.PlotArea.EmptySeriesMessage.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.Red
        Else
            AddRiskSeries(Chart1, zRiskSeries)
        End If


        lblIndustryLabel.Value = "<span style='color: #000000'>Average Industry Group<span style='color: #0000ff'> (" & zDt.Rows(0)("RatingIndustryGroup") & ") </span> Facility Score:</span>"

        'Delete the row containing the URLs
        If zNewDT.Rows.Count > 1 Then zNewDT.Rows(1).Delete()

        'Add Filter Text
        Dim zSb As New System.Text.StringBuilder
        If Me.DataSource.rows(0)("Division") <> "" And Me.DataSource.rows(0)("Division") <> "All" Then zSb.Append("on Division to INCLUDE [" & Me.DataSource.rows(0)("Division") & "]")
        If Me.DataSource.rows(0)("CustomAccess") <> "" And Me.DataSource.rows(0)("CustomAccess") <> "All" Then
            If zSb.ToString <> "" Then
                zSb.Append(" and on ")
            Else
                zSb.Append(" on ")
            End If
            zSb.Append(Me.DataSource.rows(0)("CustomAccessLabel") & " to INCLUDE [" & Me.DataSource.rows(0)("CustomAccess") & "]")
        End If

        'HIDE FILTER IS NONE APPLIED
        If (Me.DataSource.rows(0)("Division") = "" Or Me.DataSource.rows(0)("Division") = "All") And
            (Me.DataSource.rows(0)("CustomAccess") = "" Or Me.DataSource.rows(0)("CustomAccess") = "All") Then
            Me.Filter = ""
        Else
            Me.Filter = zSb.ToString
        End If

    End Sub

    Public Shared Function GetTotal(ByVal pValue1 As Double, ByVal pValue2 As Double, Optional pValue3 As Double = 0, Optional pValue4 As Double = 0, Optional pValue5 As Double = 0, Optional pValue6 As Double = 0, Optional pValue7 As Double = 0, Optional pValue8 As Double = 0, Optional pValue9 As Double = 0)

        Return pValue1 + pValue2 + pValue3 + pValue4 + pValue5 + pValue6 + pValue7 + pValue8 + pValue9

    End Function

#Region "Special Feature Customizations"

    Private Sub ApplySpecialFeature(sender As Object, e As System.EventArgs) Handles pnlFireIndustryGroup.ItemDataBound, pnlBMIndustryGroup.ItemDataBound, pnlGRCBMFacilityScore.ItemDataBound, pnlGRCFireFacilityScore.ItemDataBound, pnlRatingSpacer.ItemDataBound, pnlFacilityRating.ItemDataBound, pnlImpairments.ItemDataBound, pnlJuris.ItemDataBound
        Dim zPnl As Telerik.Reporting.Processing.Panel = DirectCast(sender, Telerik.Reporting.Processing.Panel)
        Dim zSpcFeature As String = Core.UtilGSafe.GetValue(Me.Guid, "clientFeatures")

        If zSpcFeature.ToLower.Contains("1") Or zSpcFeature.ToLower.Contains("2") Or zSpcFeature.ToLower.Contains("4") Or zSpcFeature.ToLower.Contains("5") Or zSpcFeature.ToLower.Contains("a") Then
            'If has special feature that set panels visiblity

            If zPnl.Name.ToLower = "pnlgrcfirefacilityscore" Or zPnl.Name.ToLower = "pnlgrcbmfacilityscore" Or zPnl.Name.ToLower = "pnlfireindustrygroup" Or zPnl.Name.ToLower = "pnlbmindustrygroup" Then
                zPnl.Visible = False
            ElseIf zPnl.Name.ToLower = "pnlratingspacer" Then
                zPnl.Visible = True
                Dim zAddUnits As New Telerik.Reporting.Drawing.Unit(0.4, UnitType.Inch)
                Dim zNewUnit As Telerik.Reporting.Drawing.Unit = zPnl.Height.Subtract(zAddUnits)
                zPnl.Height = zNewUnit
            End If
        End If


        'If zPnl.Name = "pnlJuris" Then
        '    If Not zSpcFeature.ToLower.Contains("j") Then
        '        Me.JurisObjectsPanel.Visible = False
        '        Me.JurisObjectsPanel.Height = New Telerik.Reporting.Drawing.Unit(0, UnitType.Inch)
        '        Me.pnlJuris.Height = New Telerik.Reporting.Drawing.Unit(Me.pnlJuris.Height.Subtract(Me.JurisObjectsPanel.Height).Value, UnitType.Inch)
        '    End If
        'End If


        '    If zPnl.Name.ToLower = "pnlratingspacer" Then
        '        zPnl.Visible = False
        '    ElseIf zPnl.Name.ToLower = "pnlfacilityrating" Then
        '        Dim zSubtractUnit As New Telerik.Reporting.Drawing.Unit(0.4, UnitType.Inch)
        '        Dim zNewUnit As Telerik.Reporting.Drawing.Unit = zPnl.Height.Subtract(zSubtractUnit)
        '        zPnl.Height = zNewUnit
        '    ElseIf zPnl.Name.ToLower = "pnljuris" Or zPnl.Name.ToLower = "pnlimpairments" Then
        '        'Dim zSubtractUnit As New Telerik.Reporting.Drawing.Unit(0.4, UnitType.Inch)
        '        'Dim zNewUnit As Telerik.Reporting.Drawing.Unit = zPnl.Location.X.Subtract(zSubtractUnit)
        '        'zPnl.Location = New Telerik.Reporting.Drawing.PointU(zPnl.Location.X, zNewUnit)
        '        'zPnl.Visible = True
        '    End If
        'End If
    End Sub


#End Region

    Public Shared Function GetColorFromHex(ByVal pHex As String) As System.Drawing.Color
        Return System.Drawing.ColorTranslator.FromHtml(pHex)
    End Function

    Private Sub AddRiskSeries(ByVal pChart As Telerik.Reporting.Chart, ByVal pRiskSeries As RiskSeries)

        Dim zSeries As New Charting.ChartSeries("Risk", Charting.ChartSeriesType.Pie)
        pChart.Series.Add(zSeries)

        zSeries.Appearance.TextAppearance.TextProperties.Font = New System.Drawing.Font("Arial", 10)
        zSeries.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.Black
        zSeries.Appearance.LegendDisplayMode = Charting.ChartSeriesLegendDisplayMode.ItemLabels
        zSeries.Appearance.ShowLabelConnectors = True
        zSeries.Appearance.TextAppearance.MaxLength = 100
        zSeries.Appearance.ExplodePercent = 0

        Dim zItem As New Charting.ChartSeriesItem
        zItem = New Charting.ChartSeriesItem(pRiskSeries.RiskRating1Value)
        zItem.Label.TextBlock.Text = pRiskSeries.RiskRating1Text
        zItem.Label.TextBlock.Appearance.Dimensions.Paddings = New Charting.Styles.ChartPaddings(New Charting.Styles.Unit(3, Charting.Styles.UnitType.Pixel))
        zItem.Appearance.FillStyle.MainColor = pRiskSeries.RiskRating1Color
        FormatItem(zItem)
        zSeries.AddItem(zItem)

        zItem = New Charting.ChartSeriesItem
        zItem = New Charting.ChartSeriesItem(pRiskSeries.RiskRating2Value)
        zItem.Label.TextBlock.Text = pRiskSeries.RiskRating2Text
        zItem.Label.TextBlock.Appearance.Dimensions.Paddings = New Charting.Styles.ChartPaddings(New Charting.Styles.Unit(3, Charting.Styles.UnitType.Pixel))
        zItem.Appearance.FillStyle.MainColor = pRiskSeries.RiskRating2Color
        FormatItem(zItem)
        zSeries.AddItem(zItem)

        zItem = New Charting.ChartSeriesItem
        zItem = New Charting.ChartSeriesItem(pRiskSeries.RiskRating3Value)
        zItem.Label.TextBlock.Text = pRiskSeries.RiskRating3Text
        zItem.Label.TextBlock.Appearance.Dimensions.Paddings = New Charting.Styles.ChartPaddings(New Charting.Styles.Unit(3, Charting.Styles.UnitType.Pixel))
        zItem.Appearance.FillStyle.MainColor = pRiskSeries.RiskRating3Color
        FormatItem(zItem)
        zSeries.AddItem(zItem)

        If pRiskSeries.RiskRating4Value <> -1 Then
            zItem = New Charting.ChartSeriesItem
            zItem = New Charting.ChartSeriesItem(pRiskSeries.RiskRating4Value)
            zItem.Label.TextBlock.Text = pRiskSeries.RiskRating4Text
            zItem.Label.TextBlock.Appearance.Dimensions.Paddings = New Charting.Styles.ChartPaddings(New Charting.Styles.Unit(3, Charting.Styles.UnitType.Pixel))
            zItem.Appearance.FillStyle.MainColor = pRiskSeries.RiskRating4Color
            FormatItem(zItem)
            zSeries.AddItem(zItem)
        End If

        If pRiskSeries.RiskRating5Value <> -1 Then
            zItem = New Charting.ChartSeriesItem
            zItem = New Charting.ChartSeriesItem(pRiskSeries.RiskRating5Value)
            zItem.Label.TextBlock.Text = pRiskSeries.RiskRating5Text
            zItem.Label.TextBlock.Appearance.Dimensions.Paddings = New Charting.Styles.ChartPaddings(New Charting.Styles.Unit(3, Charting.Styles.UnitType.Pixel))
            zItem.Appearance.FillStyle.MainColor = pRiskSeries.RiskRating5Color
            FormatItem(zItem)
            zSeries.AddItem(zItem)
        End If

    End Sub

    Private Sub SetDefaultProperties(ByVal pChart As Telerik.Reporting.Chart)

        With pChart
            .Series.Clear()
            .AutoLayout = False
            .DefaultType = Telerik.Reporting.Charting.ChartSeriesType.Pie
            .Appearance.FillStyle.MainColor = System.Drawing.Color.White
            .Appearance.Border.Visible = False
            .ChartTitle.Visible = False
            .Appearance.Border.Visible = False
            .BitmapResolution = 300

            .Legend.Visible = False
            .Legend.Appearance.Dimensions.Width = New Charting.Styles.Unit(500, Charting.Styles.UnitType.Pixel)
            .Legend.Appearance.Dimensions.Height = New Charting.Styles.Unit(25, Charting.Styles.UnitType.Pixel)
            .Legend.Appearance.Dimensions.Margins.Bottom = New Charting.Styles.Unit(25, Charting.Styles.UnitType.Pixel)
            .Legend.Appearance.Dimensions.AutoSize = False
            .Legend.Appearance.Location = Charting.Styles.LabelLocation.OutsidePlotArea
            .Legend.Appearance.Position.AlignedPosition = Charting.Styles.AlignedPositions.Bottom
            .Legend.Appearance.Overflow = Charting.Styles.Overflow.Row
            .Legend.Appearance.ItemMarkerAppearance.Figure = "Rectangle"
            .Legend.Appearance.ItemMarkerAppearance.FillStyle.FillType = Charting.Styles.FillType.Solid
            .Legend.Appearance.ItemTextAppearance.TextProperties.Font = New System.Drawing.Font("Verdana", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            .Legend.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.Black
            .Legend.Appearance.Border.Visible = True
            .Legend.Appearance.Border.Width = 0.5
            .Legend.Appearance.Border.Color = System.Drawing.Color.Black

            .PlotArea.Appearance.FillStyle.GammaCorrection = True
            .PlotArea.Appearance.Border.Visible = False
            .PlotArea.Appearance.Border.Color = System.Drawing.Color.White
            .PlotArea.Appearance.FillStyle.MainColor = System.Drawing.Color.White
            .PlotArea.Appearance.FillStyle.FillType = Charting.Styles.FillType.Solid
            .PlotArea.Appearance.Dimensions.Margins.Top = New Charting.Styles.Unit(5)
            .PlotArea.Appearance.Dimensions.Margins.Left = New Charting.Styles.Unit(5)
            .PlotArea.Appearance.Dimensions.Margins.Right = New Charting.Styles.Unit(5)
            .PlotArea.Appearance.Dimensions.Margins.Bottom = New Charting.Styles.Unit(5)

            .ImageFormat = System.Drawing.Imaging.ImageFormat.Png

        End With

    End Sub

    Private Sub FormatItem(ByRef pItem As Charting.ChartSeriesItem)
        pItem.Appearance.FillStyle.FillType = Charting.Styles.FillType.Solid
        pItem.Label.TextBlock.Appearance.TextProperties.Font = New System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular)
        pItem.Label.Appearance.Distance = 10
        pItem.Appearance.FillStyle.FillSettings.GradientMode = Charting.Styles.GradientFillStyle.BackwardDiagonal
        pItem.Appearance.Exploded = False
        pItem.Label.Appearance.LabelLocation = Charting.Styles.StyleSeriesItemLabel.ItemLabelLocation.Outside
        pItem.Appearance.Border.Visible = True
        pItem.Appearance.Border.Color = System.Drawing.Color.Black
        pItem.Appearance.Border.Width = 1
    End Sub

End Class