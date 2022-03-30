Imports System.ComponentModel
Imports System.Drawing

Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports GRC.Connect.Libraries.DataLib.razor

Partial Public Class RiskImprovementChart
    Inherits BaseReportLandscape
    Implements IUtilReport
    Implements ITelerikReport

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        UtilReport.TelerikReport.FixBaseGroups(Me)
        SetChartProperties()
        Me.FooterDatePagerPanel.Visible = False
    End Sub

    Private Sub Me_ItemDataBinding(sender As Object, e As System.EventArgs) Handles Me.ItemDataBinding

        Me.txtStandardHeader.Visible = True
        Me.txtStandardHeader.Value = Format(Now, "dddd, MMMM dd, yyyy")

        Dim zFilePrefix As String = rptProperties.FilePrefix
        Dim zDt As New DataTable
        Dim zRecStatusDT As DataTable = Me.DataSource.Tables(1)
        Dim zExposureDT As DataTable = Me.DataSource.Tables(0)

        If rptProperties.Practice.Practice = TblMetaPractice.Practices.Fire Then
            AddRecChartTitle("Fire", zRecStatusDT)
        ElseIf rptProperties.Practice.Practice = TblMetaPractice.Practices.BM Then
            AddRecChartTitle("B&M", zRecStatusDT)
        End If

        Me.DataSource = zExposureDT

        SetPieValues(zRecStatusDT)
        SetBarValues(zExposureDT)

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
            .PlotArea.EmptySeriesMessage.TextBlock.Text = "There are zero recommendations."
            .ChartTitle.Visible = False


        End With

        With ExposureChart
            .AutoLayout = True
            .DefaultType = Charting.ChartSeriesType.Bar
            .SeriesPalette = "(None)"
            .PlotArea.Appearance.FillStyle.FillType = Charting.Styles.FillType.Solid
            .PlotArea.Appearance.FillStyle.MainColor = Color.White
            .PlotArea.Appearance.Dimensions.Paddings = New Charting.Styles.ChartPaddings(0, 0, 0, 0)
            .PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Color = Color.Black
            .PlotArea.YAxis.AxisLabel.TextBlock.Appearance.TextProperties.Color = Color.Black
            .PlotArea.YAxis.Visible = Charting.Styles.ChartAxisVisibility.True
            .PlotArea.YAxis.AxisLabel.Visible = True
            .PlotArea.YAxis.AxisLabel.TextBlock.Text = "Value in Millions ($USD)"
            .PlotArea.XAxis.AxisLabel.TextBlock.Text = "Exposure"
            .PlotArea.XAxis.Appearance.LabelAppearance.Visible = False
            .PlotArea.XAxis.AxisLabel.TextBlock.Appearance.TextProperties.Color = Color.Black
            .PlotArea.XAxis.AxisLabel.Visible = True
            .PlotArea.YAxis.Appearance.MajorGridLines.Visible = True
            .PlotArea.YAxis.Appearance.MajorGridLines.PenStyle = Drawing2D.DashStyle.Solid
            .PlotArea.YAxis.Appearance.MajorGridLines.Color = Color.Gray
            .PlotArea.YAxis.Appearance.MajorGridLines.Width = 0.5
            .PlotArea.YAxis.VisibleValues = Charting.Styles.ChartAxisVisibleValues.Positive
            .PlotArea.YAxis.AxisMode = Charting.ChartYAxisMode.Extended
            .PlotArea.YAxis.AutoScale = True
            .Appearance.FillStyle.FillType = Charting.Styles.FillType.Solid
            .Appearance.FillStyle.MainColor = Color.White
            .Appearance.Border.Visible = False
            .Legend.Visible = False
            .ChartTitle.Visible = False

        End With

    End Sub

    Private Sub SetPieValues(ByVal pData As DataTable)

        Dim zConfCompCount As Integer = 0
        Dim zRptdCompCount As Integer = 0
        Dim zInProgCount As Integer = 0
        Dim zRemovedCount As Integer = 0
        Dim zAdvisoryCount As Integer = 0
        Dim zOutstandingCount As Integer = 0
        Dim zTotalValues As Integer = 0

        For Each pRow As DataRow In pData.Rows
            Select Case pRow("RecStatus")
                Case "Conf Completed"
                    zConfCompCount = pRow("RecCount")
                Case "Rptd Completed"
                    zRptdCompCount = pRow("RecCount")
                Case "In Progress"
                    zInProgCount = pRow("RecCount")
                Case "Removed"
                    zRemovedCount = pRow("RecCount")
                Case "Advisory"
                    zAdvisoryCount = pRow("RecCount")
                Case "Outstanding"
                    zOutstandingCount = pRow("RecCount")
            End Select
            zTotalValues += pRow("RecCount")
        Next

        Dim zSeries As New Charting.ChartSeries("RecStatus", Charting.ChartSeriesType.Pie)

        With zSeries.Appearance
            .DiameterScale = 1
            .LegendDisplayMode = Charting.ChartSeriesLegendDisplayMode.Nothing
            .TextAppearance.TextProperties.Font = New System.Drawing.Font("Arial", 10, FontStyle.Bold)
            .TextAppearance.TextProperties.Color = Color.Black
            .LabelAppearance.LabelLocation = Charting.Styles.StyleSeriesItemLabel.ItemLabelLocation.Inside
        End With

        If zConfCompCount <> 0 Then
            Dim zPercentValue As Single = zConfCompCount / zTotalValues
            Dim zConfCompItem As New Charting.ChartSeriesItem(zPercentValue, FormatNumber(zPercentValue * 100, 1) & "%")
            If (zPercentValue * 100) < 5 Then
                zConfCompItem.Label.Appearance.LabelLocation = Charting.Styles.StyleSeriesItemLabel.ItemLabelLocation.Outside
            End If
            zConfCompItem.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(148, 182, 0)   'green
            zConfCompItem.Appearance.FillStyle.SecondColor = System.Drawing.Color.FromArgb(140, 173, 72)
            'zConfCompItem.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(173, 72, 69)  'Maroon
            'zConfCompItem.Appearance.FillStyle.SecondColor = System.Drawing.Color.FromArgb(185, 85, 81)
            RecStatusChart.Legend.AddCustomItemToLegend("Conf Comp.", zConfCompItem.Appearance.FillStyle, "Circle")
            zSeries.AddItem(zConfCompItem)
        End If

        If zRptdCompCount <> 0 Then
            Dim zPercentValue As Single = zRptdCompCount / zTotalValues
            Dim zRptdCompItem As New Charting.ChartSeriesItem(zPercentValue, FormatNumber(zPercentValue * 100, 1) & "%")
            If (zPercentValue * 100) < 5 Then
                zRptdCompItem.Label.Appearance.LabelLocation = Charting.Styles.StyleSeriesItemLabel.ItemLabelLocation.Outside
            End If
            zRptdCompItem.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(59, 153, 178) 'Light blue
            zRptdCompItem.Appearance.FillStyle.SecondColor = System.Drawing.Color.FromArgb(74, 169, 195)
            zRptdCompItem.Label.TextBlock.Appearance.Dimensions.Paddings.Top = New Charting.Styles.Unit(10, Charting.Styles.UnitType.Pixel)
            RecStatusChart.Legend.AddCustomItemToLegend("Rptd Comp.", zRptdCompItem.Appearance.FillStyle, "Circle")

            zSeries.AddItem(zRptdCompItem)
        End If

        If zInProgCount <> 0 Then
            Dim zPercentValue As Single = zInProgCount / zTotalValues
            Dim zInProgItem As New Charting.ChartSeriesItem(zPercentValue, FormatNumber(zPercentValue * 100, 1) & "%")
            If (zPercentValue * 100) < 5 Then
                zInProgItem.Label.Appearance.LabelLocation = Charting.Styles.StyleSeriesItemLabel.ItemLabelLocation.Outside
            End If
            zInProgItem.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(110, 85, 139)   'Purple
            zInProgItem.Appearance.FillStyle.SecondColor = System.Drawing.Color.FromArgb(124, 96, 158)
            RecStatusChart.Legend.AddCustomItemToLegend("In Progress", zInProgItem.Appearance.FillStyle, "Circle")
            zSeries.AddItem(zInProgItem)
        End If

        If zRemovedCount <> 0 Then
            Dim zPercentValue As Single = zRemovedCount / zTotalValues
            Dim zRemovedItem As New Charting.ChartSeriesItem(zPercentValue, FormatNumber(zPercentValue * 100, 1) & "%")
            If (zPercentValue * 100) < 5 Then
                zRemovedItem.Label.Appearance.LabelLocation = Charting.Styles.StyleSeriesItemLabel.ItemLabelLocation.Outside
            End If
            zRemovedItem.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(64, 112, 168)  'Dark Blue
            zRemovedItem.Appearance.FillStyle.SecondColor = System.Drawing.Color.FromArgb(83, 131, 188)
            RecStatusChart.Legend.AddCustomItemToLegend("Removed", zRemovedItem.Appearance.FillStyle, "Circle")
            zSeries.AddItem(zRemovedItem)
        End If

        If zAdvisoryCount <> 0 Then
            Dim zPercentValue As Single = zAdvisoryCount / zTotalValues
            Dim zAdvisoryItem As New Charting.ChartSeriesItem(zPercentValue, FormatNumber(zPercentValue * 100, 1) & "%")
            If (zPercentValue * 100) < 5 Then
                zAdvisoryItem.Label.Appearance.LabelLocation = Charting.Styles.StyleSeriesItemLabel.ItemLabelLocation.Outside
            End If
            zAdvisoryItem.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(105, 73, 74)   'Brown
            zAdvisoryItem.Appearance.FillStyle.SecondColor = System.Drawing.Color.FromArgb(117, 82, 83)
            RecStatusChart.Legend.AddCustomItemToLegend("Advisory", zAdvisoryItem.Appearance.FillStyle, "Circle")
            zSeries.AddItem(zAdvisoryItem)
        End If

        If zOutstandingCount <> 0 Then
            Dim zPercentValue As Single = zOutstandingCount / zTotalValues
            Dim zOutstandingItem As New Charting.ChartSeriesItem(zPercentValue, FormatNumber(zPercentValue * 100, 1) & "%")
            If (zPercentValue * 100) < 5 Then
                zOutstandingItem.Label.Appearance.LabelLocation = Charting.Styles.StyleSeriesItemLabel.ItemLabelLocation.Outside
            End If
            zOutstandingItem.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(173, 72, 69)  'Maroon
            zOutstandingItem.Appearance.FillStyle.SecondColor = System.Drawing.Color.FromArgb(185, 85, 81)
            'zOutstandingItem.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(148, 182, 0)   'green
            'zOutstandingItem.Appearance.FillStyle.SecondColor = System.Drawing.Color.FromArgb(140, 173, 72)
            RecStatusChart.Legend.AddCustomItemToLegend("Outstanding", zOutstandingItem.Appearance.FillStyle, "Circle")
            zSeries.AddItem(zOutstandingItem)
        End If

        Me.RecStatusChart.Series.Add(zSeries)

    End Sub

    Private Sub SetBarValues(ByVal pData As DataTable)

        Dim zIdentifiedValue As Single = 0.0
        Dim zRemainingValue As Single = 0.0
        Dim zIdentifiedDollar As String = "$0.00"
        Dim zRemainingDollar As String = "$0.00"
        Dim zImprovementValue As Single = 0.0
        Dim zSuffix As String = ""

        If IsNumeric(pData.Rows(0)("IdentifiedExposure")) Then
            zIdentifiedValue = pData.Rows(0)("IdentifiedExposure")
            zIdentifiedDollar = FormatCurrency(zIdentifiedValue, 2, TriState.UseDefault, TriState.UseDefault, TriState.True)
        End If

        If IsNumeric(pData.Rows(0)("RemainingExposure")) Then
            zRemainingValue = pData.Rows(0)("RemainingExposure")
            zRemainingDollar = FormatCurrency(zRemainingValue, 2, TriState.UseDefault, TriState.UseDefault, TriState.True)
        End If

        zImprovementValue = FormatNumber(zIdentifiedValue - zRemainingValue, 1)
        If zImprovementValue < 1000 And zImprovementValue > 100 Then
            zSuffix = "M"
        End If

        If zImprovementValue > 1000 Then
            zImprovementValue = zImprovementValue / 1000.0
            zSuffix = "B"
        End If

        Dim zIdentifiedSeries As New Charting.ChartSeries("TotalExposure", Charting.ChartSeriesType.Bar)
        Dim zRemainingSeries As New Charting.ChartSeries("RemainingExposure", Charting.ChartSeriesType.Bar)

        With zIdentifiedSeries.Appearance
            .BarWidthPercent = 50
            .TextAppearance.TextProperties.Font = New System.Drawing.Font("Arial", 9, FontStyle.Regular)
            .TextAppearance.TextProperties.Color = Color.Black
            .FillStyle.SecondColor = System.Drawing.Color.FromArgb(78, 129, 189)
            .FillStyle.MainColor = System.Drawing.Color.FromArgb(150, 50, 82, 122)
            .FillStyle.FillSettings.GradientMode = Charting.Styles.GradientFillStyle.Vertical
        End With

        With zRemainingSeries.Appearance
            .BarWidthPercent = 50
            .TextAppearance.TextProperties.Font = New System.Drawing.Font("Arial", 9, FontStyle.Regular)
            .TextAppearance.TextProperties.Color = Color.Black
            .FillStyle.SecondColor = System.Drawing.Color.FromArgb(193, 80, 76)
            .FillStyle.MainColor = System.Drawing.Color.FromArgb(150, 145, 60, 58)
            .FillStyle.FillSettings.GradientMode = Charting.Styles.GradientFillStyle.Vertical
        End With

        Dim zIdentifiedItem As New Charting.ChartSeriesItem(zIdentifiedValue, zIdentifiedDollar & System.Environment.NewLine & "Identified")
        zIdentifiedItem.Label.TextBlock.Appearance.TextProperties.Font = New System.Drawing.Font("Arial", 9, FontStyle.Bold)
        zIdentifiedItem.Label.TextBlock.Appearance.Position.Auto = True

        Dim zRemainingItem As New Charting.ChartSeriesItem(zRemainingValue, zRemainingDollar & System.Environment.NewLine & "Remaining")
        zRemainingItem.Label.TextBlock.Appearance.TextProperties.Font = New System.Drawing.Font("Arial", 9, FontStyle.Bold)

        zRemainingSeries.Items.Add(zRemainingItem)
        zIdentifiedSeries.Items.Add(zIdentifiedItem)

        Me.ExposureChart.Series.Clear()
        Me.ExposureChart.Series.Add(zIdentifiedSeries)
        Me.ExposureChart.Series.Add(zRemainingSeries)

        SetChartMessage(zImprovementValue, zSuffix)

    End Sub

    Private Sub AddRecChartTitle(ByVal pPractice As String, ByVal pData As DataTable)
        Dim zCounter As Integer = 0
        For Each zRow In pData.Rows
            zCounter += zRow("RecCount")
        Next

        Me.RecStatusTitle.Value = "<p style='text-align: center'><strong>Total " & System.Web.HttpUtility.HtmlEncode(pPractice) & " Recommendations</strong></p>"
        Me.RecStatusSubTitle.Value = "<p style='text-align: center'>" & FormatNumber(zCounter, 0, TriState.UseDefault, TriState.UseDefault, TriState.True) & " Total Rec's</p>"

    End Sub

    Private Sub SetChartMessage(ByVal pImprovementValue As String, ByVal pSuffix As String)

        Me.ChartMessage.Value = "$" & FormatNumber(pImprovementValue, 1) & pSuffix & " in Risk " & System.Environment.NewLine & "Improvement"
    End Sub

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
End Class