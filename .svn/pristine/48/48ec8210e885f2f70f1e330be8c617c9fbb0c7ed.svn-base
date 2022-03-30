Imports System.ComponentModel
Imports System.Drawing

Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class QorChart
    Inherits BaseReportLandscape
    Implements IUtilReport
    Implements ITelerikReport

    Dim zQorPalette As New QorChartPalette

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        SetChartProperties()

        UtilReport.TelerikReport.FixBaseGroups(Me)
    End Sub

    Public Sub SetChartProperties()
        With Me.Chart1
            .AutoLayout = False
            .DefaultType = Charting.ChartSeriesType.StackedBar
            .SeriesOrientation = Charting.ChartSeriesOrientation.Horizontal
            .CustomPalettes.Add(zQorPalette)
            .SeriesPalette = zQorPalette.Name
            .Appearance.FillStyle.FillType = Charting.Styles.FillType.Solid
            .Appearance.FillStyle.MainColor = Color.Transparent
            .Appearance.Border.Visible = False
            .BitmapResolution = 300

            With .ChartTitle
                .Visible = False
            End With

            With .PlotArea
                .YAxis.MinValue = 0
                .YAxis.MaxValue = 100
                .YAxis.LabelStep = 10
                .YAxis.MaxItemsCount = 11
                .YAxis.AxisMode = Charting.ChartYAxisMode.Normal
                .YAxis.IsZeroBased = True
                .YAxis.AutoScale = False
                .YAxis.Appearance.MajorGridLines.Visible = True
                .YAxis.Appearance.MajorGridLines.PenStyle = Drawing2D.DashStyle.Solid
                .YAxis.Appearance.MajorGridLines.Width = 0.5
                .YAxis.Appearance.MajorGridLines.Color = Color.Black
                .YAxis.Appearance.MinorGridLines.Visible = False
                .YAxis.Appearance.MinorTick.Visible = False

                .YAxis.Appearance.TextAppearance.TextProperties.Font = New System.Drawing.Font("Arial", 7, FontStyle.Regular, GraphicsUnit.Point)
                .YAxis.Appearance.TextAppearance.TextProperties.Color = Color.Black

                .XAxis.LayoutMode = Charting.Styles.ChartAxisLayoutMode.Between
                .XAxis.Appearance.TextAppearance.TextProperties.Color = Color.Black
                .XAxis.Appearance.TextAppearance.TextProperties.Font = New System.Drawing.Font("Arial", 7, FontStyle.Regular, GraphicsUnit.Point)
                .XAxis.Appearance.TextAppearance.MaxLength = 1000
                .XAxis.Appearance.TextAppearance.Dimensions.Width = New Charting.Styles.Unit(30, Charting.Styles.UnitType.Percentage)
                .XAxis.AxisLabel.Visible = False
                .XAxis.Appearance.MajorGridLines.Visible = True
                .XAxis.Appearance.MajorGridLines.PenStyle = Drawing2D.DashStyle.Solid
                .XAxis.Appearance.MajorGridLines.Color = Color.Black
                .XAxis.Appearance.MajorGridLines.Width = 0.5
                .XAxis.AutoScale = False

                .Appearance.Dimensions.Width = New Telerik.Reporting.Charting.Styles.Unit(73, Charting.Styles.UnitType.Percentage)
                .Appearance.Dimensions.Margins.Left = New Telerik.Reporting.Charting.Styles.Unit(25, Charting.Styles.UnitType.Percentage)
                .Appearance.Dimensions.Margins.Top = New Telerik.Reporting.Charting.Styles.Unit(0)
                .Appearance.Dimensions.Margins.Right = New Telerik.Reporting.Charting.Styles.Unit(1, Charting.Styles.UnitType.Percentage)
                .Appearance.Dimensions.Margins.Bottom = New Telerik.Reporting.Charting.Styles.Unit(10, Charting.Styles.UnitType.Percentage)
                .Appearance.Border.Visible = True
                .Appearance.Border.PenStyle = Drawing2D.DashStyle.Solid
                .Appearance.Border.Color = Color.Black
                .Appearance.Border.Width = 1.5
                .Appearance.FillStyle.MainColor = Color.White
                .Appearance.FillStyle.FillType = Charting.Styles.FillType.Solid

            End With

            With .Legend
                .Appearance.Location = Charting.Styles.LabelLocation.OutsidePlotArea
                .Appearance.Position.AlignedPosition = Charting.Styles.AlignedPositions.Bottom
                .Appearance.Overflow = Charting.Styles.Overflow.Row
                .Appearance.ItemMarkerAppearance.Figure = "Rectangle"
                .Visible = True
                .Appearance.Border.Visible = True
                .Appearance.Border.Width = 0.5
                .Appearance.Border.Color = Color.Black
            End With

        End With

        AddSeries()

    End Sub

    Private Sub QorChart_ItemDataBinding(sender As Object, e As System.EventArgs) Handles Me.ItemDataBinding

        Dim zDT As DataTable = Me.DataSource
        Dim zDV As DataView = zDT.DefaultView
        zDV.Sort = "Location_Score ASC"
        zDT = zDV.ToTable

        For Each zRow As DataRow In zDT.Rows
            Dim zHeader As String = zRow("Facility") & " (" & rptProperties.Currency.colFldSymbol & zRow("TIV") & "M) " & zRow("FileNo")
            Plot(zHeader, zRow("Prim_Bus_Score"), zRow("Nat_Risk_Score"), zRow("Facility_Score"), zRow("Equipment"), zRow("Total_Claims_score"))
        Next


        Dim zEntAvg As Object = zDT.Compute("Avg(Ent_Wght_Avg)", "")
        Dim zChartAvg As Object = zDT.Compute("Avg(Location_Score)", "")

        If IsNumeric(zEntAvg) Then
            Me.txtEnterpriseAvg.Value = Math.Round(zEntAvg, 0)
        Else
            Me.txtEnterpriseAvg.Value = 0
        End If

        If IsNumeric(zChartAvg) Then
            Me.txtChartAvg.Value = Math.Round(zChartAvg, 0)
        Else
            Me.txtChartAvg.Value = 0
        End If

        FormatXAxisLabels()


        UtilReport.TelerikReport.SetFilterText(sender, rptProperties)
        UtilReport.TelerikReport.SetDisclaimerText(sender, rptProperties)
        UtilReport.TelerikReport.SetSortText(sender, rptProperties)


    End Sub

    Private Sub Plot(ByVal pLocation As String, Optional ByVal pPrimaryBusiness As Double = 0.0, Optional ByVal pNaturalHazards As Double = 0.0, Optional ByVal pFacility As Double = 0.0, Optional ByVal pEquipment As Double = 0.0, Optional ByVal pTotalClaims As Double = 0.0)
        Dim zItem As Charting.ChartSeriesItem = Nothing
        Dim zXLabel As New Charting.AxisLabel

        Me.Chart1.PlotArea.XAxis.AddItem(pLocation)


        zItem = New Charting.ChartSeriesItem(pPrimaryBusiness)
        Me.Chart1.Series(0).AddItem(zItem)
        FormatItem(zItem)

        zItem = New Charting.ChartSeriesItem(pNaturalHazards)
        Me.Chart1.Series(1).AddItem(zItem)
        FormatItem(zItem)

        zItem = New Charting.ChartSeriesItem(pFacility)
        Me.Chart1.Series(2).AddItem(zItem)
        FormatItem(zItem)

        zItem = New Charting.ChartSeriesItem(pEquipment)
        Me.Chart1.Series(3).AddItem(zItem)
        FormatItem(zItem)

        zItem = New Charting.ChartSeriesItem(pTotalClaims)
        Me.Chart1.Series(4).AddItem(zItem)
        FormatItem(zItem)
    End Sub

    Private Sub AddSeries()
        Dim zSeries As Charting.ChartSeries

        zSeries = New Charting.ChartSeries("Occupancy", Charting.ChartSeriesType.StackedBar)
        Me.Chart1.Series.Add(zSeries)
        FormatSeries(zSeries)

        zSeries = New Charting.ChartSeries("Exposure", Charting.ChartSeriesType.StackedBar)
        Me.Chart1.Series.Add(zSeries)
        FormatSeries(zSeries)

        zSeries = New Charting.ChartSeries("Facility", Charting.ChartSeriesType.StackedBar)
        Me.Chart1.Series.Add(zSeries)
        FormatSeries(zSeries)

        zSeries = New Charting.ChartSeries("Equipment", Charting.ChartSeriesType.StackedBar)
        Me.Chart1.Series.Add(zSeries)
        FormatSeries(zSeries)

        zSeries = New Charting.ChartSeries("Total Claims", Charting.ChartSeriesType.StackedBar)
        Me.Chart1.Series.Add(zSeries)
        FormatSeries(zSeries)

    End Sub

    Private Sub FormatSeries(ByRef pSeries As Charting.ChartSeries)
        pSeries.Appearance.LabelAppearance.LabelLocation = Charting.Styles.StyleSeriesItemLabel.ItemLabelLocation.Inside
        pSeries.Appearance.LabelAppearance.Position.AlignedPosition = Charting.Styles.AlignedPositions.Center
        pSeries.Appearance.TextAppearance.TextProperties.Font = New System.Drawing.Font("Arial", 7, FontStyle.Bold, GraphicsUnit.Point)
        pSeries.Appearance.BarWidthPercent = 50

    End Sub

    Private Sub FormatItem(ByRef pItem As Charting.ChartSeriesItem)
        pItem.Appearance.FillStyle.FillType = Charting.Styles.FillType.Solid

        If pItem.Parent.Name.ToLower = "equipment" Then
            pItem.Label.TextBlock.Appearance.TextProperties.Color = Color.Black
        ElseIf pItem.YValue = 0 Then
            pItem.Label.TextBlock.Appearance.TextProperties.Color = Color.Transparent
        Else
            pItem.Label.TextBlock.Appearance.TextProperties.Color = Color.White
        End If

        pItem.Appearance.Border.Color = Color.Black
        pItem.Appearance.Border.Width = 1
        pItem.Appearance.Border.PenStyle = Drawing2D.DashStyle.Solid


    End Sub

    Private Sub FormatXAxisLabels()

        For Each zAxisItem As Charting.ChartAxisItem In Me.Chart1.PlotArea.XAxis.Items
            zAxisItem.TextBlock.Text = SetLineBreak(zAxisItem.TextBlock.Text)
            zAxisItem.TextBlock.Appearance.Position.AlignedPosition = Charting.Styles.AlignedPositions.Right
        Next

    End Sub

    Private Function SetLineBreak(ByVal pValue As String) As String
        Dim zLine1 As String = ""
        Dim zLine2 As String = ""
        Dim zBracketPos As Integer = InStr(pValue, "(")
        Dim zBreakPos As Integer = 40

        If pValue.Length < 50 Then

            Return pValue

        ElseIf zBracketPos > zBreakPos Then

            If Left(pValue, zBreakPos) = "" Then
                zLine1 = Left(pValue, zBreakPos)
            Else
                zLine1 = Left(pValue, zBreakPos) & "-"
            End If

            zLine2 = Right(pValue, pValue.Length - zBreakPos)

            Return zLine1 & vbCrLf & zLine2

        ElseIf zBracketPos = zBreakPos Then

            If Left(pValue, zBreakPos - 1) = "" Then
                zLine1 = Left(pValue, zBreakPos - 1)
            Else
                zLine1 = Left(pValue, zBreakPos - 1) & "-"
            End If

            zLine2 = Right(pValue, pValue.Length - zBreakPos)

            Return zLine1 & vbCrLf & zLine2

        Else

            Return pValue

        End If

    End Function


    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties

    Public Function IsStandardHeader() As Boolean Implements ITelerikReport.IsStandardHeader
        Return False
    End Function

    Public Function ReportSubSubTitle() As String Implements ITelerikReport.ReportSubSubTitle
        Return ""
    End Function

    Public Function ReportSubTitle() As String Implements ITelerikReport.ReportSubTitle
        Return ""
    End Function

    Public Function ReportTitle() As String Implements ITelerikReport.ReportTitle
        Return "Kimberly Clark Quality of Risk Chart"
    End Function

    Public Function AppendPracticeToTitle() As Boolean Implements ITelerikReport.AppendPracticeToTitle
        Return True
    End Function

    Private Sub QorChart_ItemDataBound(sender As Object, e As EventArgs) Handles Me.ItemDataBound

        DirectCast(DirectCast(sender, Processing.Report).ItemDefinition, QorChart).txtStandardHeader.Visible = True
        DirectCast(DirectCast(sender, Processing.Report).ItemDefinition, QorChart).txtStandardHeader.Value = Format(Now, "dddd, MMMM dd, yyyy")


    End Sub
End Class