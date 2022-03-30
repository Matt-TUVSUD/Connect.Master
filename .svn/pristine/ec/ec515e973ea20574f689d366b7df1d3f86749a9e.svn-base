Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class TelerikSample01
    Inherits Telerik.Reporting.Report

    Public Sub New()
        InitializeComponent()
        SetChartProps(False)

        Dim zSampleDT As New DataTable
        zSampleDT.Columns.Add("FileNo")
        zSampleDT.Columns.Add("ClientLocNo")
        zSampleDT.Columns.Add("City")
        zSampleDT.Columns.Add("State")
        zSampleDT.Columns.Add("Country")
        zSampleDT.Columns.Add("TIV")
        zSampleDT.Columns.Add("Division")
        zSampleDT.Columns.Add("Facility")
        zSampleDT.Columns.Add("Address")
        zSampleDT.Columns.Add("SeriesData", GetType(MyTest))

        zSampleDT.Rows.Add("2174.0002", "Andres", "Punta Caucedo, Boca Chica", "", "Dominican Republic", "816.198", "Mexico, Central America and Caribbean", "CT - Combined Cycle", "Calle Aurora No. 1", GetactiveData)
        zSampleDT.Rows.Add("2174.0003", "Itabo Complex", "Haina", "", "Dominican Republic", "825.466", "Mexico, Central America and Caribbean", "Boiler - Coal", "Av Romuio Bertancourt No. 1108; Ensanche", GetactiveData)
        zSampleDT.Rows.Add("2174.0004", "Los Mina", "Santo Domingo", "", "Dominican Republic", "297.778", "Mexico, Central America and Caribbean", "CT - Simple Cycle", "Avenida Venezuela; Parque Energetico Los", GetactiveData)
        zSampleDT.Rows.Add("2174.0005", "Merida III", "Merida", "YUC", "Mexico", "406.691", "Mexico, Central America and Caribbean", "CT - Combined Cycle", "Anillo Periferico KM.2 entrt CARR.; MID-", GetactiveData)
        zSampleDT.Rows.Add("2174.0006", "PR- Guayama", "Guayama", "PR", "Puerto Rico", "1172.36", "Mexico, Central America and Caribbean", "Boiler - Coal", "Carretera #3, km 142.0; Bo. Puente Jobos", GetactiveData)
      
        Me.DataSource = zSampleDT
    End Sub

    Private Sub SetTitle(sender As Object, e As EventArgs) Handles txtStandardHeader.ItemDataBinding, HtmlTextBox1.ItemDataBinding

    End Sub

    Public Function GetactiveData() As MyTest
        Dim zList As New List(Of ActivePoint)
        zList.Add(New ActivePoint(50, "Series1", 2008, 1))
        zList.Add(New ActivePoint(32, "Series1", 2009, 2))
        zList.Add(New ActivePoint(32, "Series1", 2010, 3))
        zList.Add(New ActivePoint(34, "Series1", 2011, 4))
        zList.Add(New ActivePoint(36, "Series1", 2012, 5))
        zList.Add(New ActivePoint(29.5, "Series1", 2013, 6))
        zList.Add(New ActivePoint(34, "Series1", 2013, 7))
        zList.Add(New ActivePoint(38, "Series1", 2014, 8))
        zList.Add(New ActivePoint(38, "Series1", 2015, 9))
        zList.Add(New ActivePoint(28.5, "Series1", 2016, 10))

        Dim zMyTest As New MyTest(zList)

        Return zMyTest
    End Function

    Public Class ActivePoint
        Public Property Rating As Double
        Public Property Category As String
        Public Property Year As String
        Public Property Order As Integer

        Public Sub New(pRating As Double, pCategory As String, pYear As String, pOrder As Integer)
            Me.Rating = pRating
            Me.Category = pCategory
            Me.Year = pYear
            Me.Order = pOrder
        End Sub

    End Class


    'Public Function GetPassiveData(Optional pUseTwoDigitYear As Boolean = False) As DataTable
    '    Dim zDT As New DataTable
    '    zDT.Columns.Add("Rating", GetType(Double))
    '    zDT.Columns.Add("Category")
    '    zDT.Columns.Add("Year")
    '    zDT.Columns.Add("Order", GetType(Integer))
    '    zDT.Rows.Add(35, "Series1", 2008, 1)
    '    zDT.Rows.Add(35, "Series1", 2009, 2)
    '    zDT.Rows.Add(35, "Series1", 2010, 3)
    '    zDT.Rows.Add(34, "Series1", 2011, 4)
    '    'zDT.Rows.Add(34, "Series1", 2012, 5)
    '    'zDT.Rows.Add(32, "Series1", 2013, 6)
    '    'zDT.Rows.Add(26, "Series1", 2013, 7)
    '    'zDT.Rows.Add(26, "Series1", 2014, 8)
    '    'zDT.Rows.Add(26, "Series1", 2015, 9)
    '    'zDT.Rows.Add(35, "Series1", 2016, 10)

    '    If pUseTwoDigitYear Then
    '        For Each zRow As DataRow In zDT.Rows
    '            zRow("Year") = "'" & Right(zRow("Year"), 2)
    '        Next
    '    End If


    '    Return zDT
    'End Function

    'Public Function GetTotalData(Optional pUseTwoDigitYear As Boolean = False) As DataTable
    '    Dim zDT As New DataTable
    '    zDT.Columns.Add("Rating", GetType(Double))
    '    zDT.Columns.Add("Category")
    '    zDT.Columns.Add("Year")
    '    zDT.Columns.Add("Order", GetType(Integer))
    '    zDT.Rows.Add(53.6, "Series1", 2008, 1)
    '    zDT.Rows.Add(53.6, "Series1", 2009, 2)
    '    zDT.Rows.Add(53.6, "Series1", 2010, 3)
    '    zDT.Rows.Add(54.4, "Series1", 2011, 4)
    '    zDT.Rows.Add(56, "Series1", 2012, 5)
    '    zDT.Rows.Add(49.2, "Series1", 2013, 6)
    '    zDT.Rows.Add(48, "Series1", 2013, 7)
    '    'zDT.Rows.Add(51.2, "Series1", 2014, 8)
    '    'zDT.Rows.Add(51.2, "Series1", 2015, 9)
    '    'zDT.Rows.Add(76.2, "Series1", 2016, 10)

    '    If pUseTwoDigitYear Then
    '        For Each zRow As DataRow In zDT.Rows
    '            zRow("Year") = "'" & Right(zRow("Year"), 2)
    '        Next
    '    End If

    '    Return zDT
    'End Function

    'Public Shared Function TestReportItem(pDataObject As Object) As String
    '    'Stop
    '    'Return Nothing
    '    Dim zList As List(Of Object) = pDataObject.SeriesActiveData


    'End Function


    Public Sub SetChartProps(Optional pUseTwoDigitYear As Boolean = False)

        Dim zCategoryGroup As New GraphGroup
        zCategoryGroup.Name = "DefGroup"
        zCategoryGroup.Label = "DefGroup"
        zCategoryGroup.Groupings.Add(New Grouping("=Fields.Order"))

        Dim zSeriesGroup As New GraphGroup
        zSeriesGroup.Name = "SerGroup"
        zSeriesGroup.Label = "SerGroup"
        zSeriesGroup.Groupings.Add(New Grouping("=Fields.Category"))

        Dim zOrderAxis As New GraphAxis
        zOrderAxis.Scale = New Telerik.Reporting.CategoryScale
        zOrderAxis.MajorGridLineStyle.Visible = False
        zOrderAxis.MinorGridLineStyle.Visible = False
        zOrderAxis.Style.Visible = False

        Dim zRatingAxis As New GraphAxis
        zRatingAxis.Scale = New Telerik.Reporting.NumericalScale
        DirectCast(zRatingAxis.Scale, Telerik.Reporting.NumericalScale).Maximum = 46
        DirectCast(zRatingAxis.Scale, Telerik.Reporting.NumericalScale).Minimum = 0
        zRatingAxis.MajorGridLineStyle.Visible = False
        zRatingAxis.MinorGridLineStyle.Visible = False
        zRatingAxis.Style.Visible = False

        Dim zCS As New CartesianCoordinateSystem
        zCS.XAxis = zOrderAxis
        zCS.YAxis = zRatingAxis

        Dim zLineSeries1 As New LineSeries
        Dim zColor As Color = ColorTranslator.FromHtml("#5A92DE")
        ConfigureSeries(zLineSeries1, zCS, zCategoryGroup, zSeriesGroup)
        zLineSeries1.LineStyle.LineColor = zColor
        zLineSeries1.DataPointStyle.Color = zColor
        zLineSeries1.DataPointStyle.LineColor = zColor
        zLineSeries1.DataPointStyle.BackgroundColor = zColor
        zLineSeries1.DataPointLabelStyle.TextAlign = HorizontalAlign.Center
        zLineSeries1.MarkerSize = New Telerik.Reporting.Drawing.Unit(3)

        With Graph1
            .Legend.Style.Visible = False
            .CoordinateSystems.Add(zCS)
            .Series.Add(zLineSeries1)
            .SeriesGroups.Add(zSeriesGroup)
            .DataSource = "=ReportItem.DataObject.SeriesData.PointList"
            .CategoryGroups.Add(zCategoryGroup)
            .Style.Font.Size = New Drawing.Unit(7)
            .Style.BorderColor.Default = Color.Black
            .Style.BorderStyle.Default = BorderType.Solid
            .Style.BorderWidth.Default = New Telerik.Reporting.Drawing.Unit(1)
        End With






        'Dim zRatingAxis2 As New GraphAxis
        'zRatingAxis2.Scale = New Telerik.Reporting.NumericalScale
        'DirectCast(zRatingAxis2.Scale, Telerik.Reporting.NumericalScale).Maximum = 45
        'DirectCast(zRatingAxis2.Scale, Telerik.Reporting.NumericalScale).Minimum = -2
        'zRatingAxis2.MajorGridLineStyle.Visible = False
        'zRatingAxis2.MinorGridLineStyle.Visible = False
        'zRatingAxis2.Style.Visible = False

        'Dim zCS2 As New CartesianCoordinateSystem
        'zCS2.XAxis = zOrderAxis
        'zCS2.YAxis = zRatingAxis2

        'Dim zLineSeries2 As New LineSeries
        'ConfigureSeries(zLineSeries2, zCS2, zCategoryGroup, zSeriesGroup)
        'zLineSeries2.LineStyle.LineColor = Color.Red
        'zLineSeries2.DataPointStyle.Color = Color.Red
        'zLineSeries2.DataPointStyle.LineColor = Color.Red
        'zLineSeries2.DataPointStyle.BackgroundColor = Color.Red
        'zLineSeries2.DataPointLabelStyle.TextAlign = HorizontalAlign.Center
        'zLineSeries2.MarkerSize = New Telerik.Reporting.Drawing.Unit(3)

        'With Graph2
        '    .Legend.Style.Visible = False
        '    .CoordinateSystems.Add(zCS2)
        '    .DataSource = GetPassiveData(pUseTwoDigitYear)
        '    .Series.Add(zLineSeries2)
        '    .SeriesGroups.Add(zSeriesGroup)
        '    .CategoryGroups.Add(zCategoryGroup)
        '    .Style.Font.Size = New Drawing.Unit(7)
        '    .Style.BorderColor.Default = Color.Black
        '    .Style.BorderStyle.Default = BorderType.Solid
        '    .Style.BorderWidth.Default = New Telerik.Reporting.Drawing.Unit(1)
        '    .PlotAreaStyle.Padding.Bottom = New Telerik.Reporting.Drawing.Unit(15)

        'End With





        'Dim zRatingAxis3 As New GraphAxis
        'zRatingAxis3.Scale = New Telerik.Reporting.NumericalScale
        'DirectCast(zRatingAxis3.Scale, Telerik.Reporting.NumericalScale).Maximum = 86
        'DirectCast(zRatingAxis3.Scale, Telerik.Reporting.NumericalScale).Minimum = 26
        'zRatingAxis3.MajorGridLineStyle.Visible = False
        'zRatingAxis3.MinorGridLineStyle.Visible = False
        'zRatingAxis3.Style.Visible = False

        'Dim zCS3 As New CartesianCoordinateSystem
        'zCS3.XAxis = zOrderAxis
        'zCS3.YAxis = zRatingAxis3

        'Dim zLineSeries3 As New LineSeries
        'ConfigureSeries(zLineSeries3, zCS3, zCategoryGroup, zSeriesGroup)
        'zLineSeries3.LineStyle.LineColor = Color.Green
        'zLineSeries3.DataPointStyle.Color = Color.Green
        'zLineSeries3.LineStyle.LineColor = Color.Green
        'zLineSeries3.DataPointStyle.Color = Color.Green
        'zLineSeries3.DataPointStyle.LineColor = Color.Green
        'zLineSeries3.DataPointStyle.BackgroundColor = Color.Green
        'zLineSeries3.DataPointLabelStyle.TextAlign = HorizontalAlign.Center
        'zLineSeries3.MarkerSize = New Telerik.Reporting.Drawing.Unit(3)

        'With Graph3
        '    .Legend.Style.Visible = False
        '    .CoordinateSystems.Add(zCS3)
        '    .DataSource = GetTotalData(pUseTwoDigitYear)
        '    .Series.Add(zLineSeries3)
        '    .SeriesGroups.Add(zSeriesGroup)
        '    .CategoryGroups.Add(zCategoryGroup)
        '    .Style.Font.Size = New Drawing.Unit(7)
        '    .Style.BorderColor.Default = Color.Black
        '    .Style.BorderStyle.Default = BorderType.Solid
        '    .Style.BorderWidth.Default = New Telerik.Reporting.Drawing.Unit(1)
        'End With

    End Sub

    Public Sub ConfigureSeries(ByRef zLineSeries As LineSeries, zCS As CartesianCoordinateSystem, zCategoryGroup As GraphGroup, zSeriesGroup As GraphGroup)
        With zLineSeries
            .DataPointLabelStyle.Color = Color.Black
            .DataPointLabelStyle.Font.Bold = False
            .LineStyle.Color = Color.Green
            .LineStyle.LineWidth = New Drawing.Unit(1)
            .CoordinateSystem = zCS
            .Y = "=Fields.Rating"
            .CategoryGroup = zCategoryGroup
            .SeriesGroup = zSeriesGroup
            .DataPointLabel = "{Fields.Rating}" & vbNewLine & "{Fields.Year}"
            .LineType = LineSeries.LineTypes.Straight
            .DataPointLabelAlignment = LineDataPointLabelAlignment.Below
            .DataPointLabelOffset = New Drawing.Unit(3)
            .MarkerType = DataPointMarkerType.Square
            .MarkerSize = New Telerik.Reporting.Drawing.Unit(3)
            .DataPointStyle.Visible = True
        End With
    End Sub


    Public Class MyTest
        Public Property PointList As List(Of ActivePoint)

        Public Sub New(pList As List(Of ActivePoint))
            PointList = pList
        End Sub

    End Class

End Class



