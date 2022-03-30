Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports GRC.Connect.Libraries.WhatIfInterfaceLib

Partial Public Class TestBubbleChartReport
    Inherits Telerik.Reporting.Report
    Public Sub New()
        InitializeComponent()
    End Sub


    Private Sub ConfigureRatingGraph(ByRef pGraph As Graph, pChartData As ChartingLib.ColumnChart)

        With pGraph

            Dim zTitle As New GraphTitle
            zTitle.Text = pChartData.Title
            zTitle.Style.Font.Bold = False
            zTitle.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9, UnitType.Point)
            zTitle.Position = GraphItemPosition.TopCenter
            zTitle.IsInsidePlotArea = False
            zTitle.Style.Color = Color.DarkGray
            .Titles.Add(zTitle)

            Dim zCategoryGroup As New GraphGroup
            .CategoryGroups.Add(zCategoryGroup)

            Dim zSeriesGroup As New GraphGroup
            zSeriesGroup.Groupings.Add("=Series")
            zSeriesGroup.Name = "SeriesGrouping"
            .SeriesGroups.Add(zSeriesGroup)

            Dim zAxisX As New GraphAxis
            zAxisX.Name = "NumericXAxis"
            zAxisX.Scale = New NumericalScale

            Dim zAxisY As New GraphAxis
            zAxisY.Name = "NumericYAxis"
            zAxisY.Scale = New NumericalScale()

            Dim zCS As New CartesianCoordinateSystem
            zCS.Name = "CoordinateSystem1"
            zCS.XAxis = zAxisX
            zCS.YAxis = zAxisY
            .CoordinateSystems.Add(zCS)

            Dim zSeries As New LineSeries
            With zSeries
                .CategoryGroup = zCategoryGroup
                .SeriesGroup = zSeriesGroup
                .CoordinateSystem = zCS
                .Y = "=Y"
                .X = "=X"
                .Size = "=Z"
                .LineStyle.Visible = False
                .DataPointStyle.Visible = True
                .MarkerType = DataPointMarkerType.Circle
                .ColorPalette = New ColorPalette(System.Drawing.Color.Blue, System.Drawing.Color.Red)
                '.LegendItem.Value = "=Series"
                '.LegendItem.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9, UnitType.Point)
                '.ArrangeMode = GraphSeriesArrangeMode.Clustered
            End With

            .Series.Add(zSeries)
            .Legend.Style.Visible = pChartData.ShowLegend
            .Legend.Position = GraphItemPosition.BottomCenter
            .Legend.IsInsidePlotArea = False
            .PlotAreaStyle.Padding.Right = New Telerik.Reporting.Drawing.Unit(5, UnitType.Pixel)

        End With

    End Sub

    'Private Class BubbleChartData
    '    Implements IBubbleChartData

    '    Public Property Series As IList(Of IBubbleChartSeriesData) = New List(Of BubbleChartDataSeries) Implements IBubbleChartData.Series

    '    Public Property ShowLegend As Boolean Implements IBubbleChartData.ShowLegend

    '    Public Property Title As String Implements IBubbleChartData.Title

    '    Public Function ToList() As List(Of IBubbleChartDataItem) Implements IBubbleChartData.ToList
    '        Dim zList As New List(Of IBubbleChartDataItem)

    '        For Each zSeries As IBubbleChartSeriesData In Series
    '            For Each zY As Object In zSeries.Y
    '                Dim zItem As New BubbleChartDataItem
    '                zItem.Series = zSeries.Name
    '                zItem.X = zSeries.X(zSeries.Y.IndexOf(zY))
    '                zItem.Y = zY
    '                zItem.Z = zSeries.X(zSeries.Y.IndexOf(zY))
    '                zList.Add(zItem)
    '            Next
    '        Next
    '        Return zList
    '    End Function
    'End Class

    'Private Class BubbleChartDataItem
    '    Implements IBubbleChartDataItem

    '    Public Property Series As String Implements IBubbleChartDataItem.Series

    '    Public Property X As Object Implements IBubbleChartDataItem.X

    '    Public Property Y As Object Implements IBubbleChartDataItem.Y

    '    Public Property Z As Object Implements IBubbleChartDataItem.Z

    'End Class

    'Private Class BubbleChartDataSeries
    '    Implements IBubbleChartSeriesData

    '    Public Property Color As Color Implements IBubbleChartSeriesData.Color

    '    Public Property Name As String = "" Implements IBubbleChartSeriesData.Name

    '    Public Property X As List(Of Object) = New List(Of Object) Implements IBubbleChartSeriesData.X

    '    Public Property Y As List(Of Object) = New List(Of Object) Implements IBubbleChartSeriesData.Y

    '    Public Property Z As List(Of Object) = New List(Of Object) Implements IBubbleChartSeriesData.Z

    'End Class

    'Private Sub TestBubbleChartReport_NeedDataSource(sender As Object, e As EventArgs) Handles Me.NeedDataSource
    '    Dim zChartData As New BubbleChartData
    '    zChartData.ShowLegend = False

    '    Dim zS1 As New BubbleChartDataSeries
    '    With zS1
    '        .Name = "Series1"
    '        .X.AddRange({500.4, 288.7, 6851.44, 354.5})
    '        .Y.AddRange({65.7, 85.6, 95, 75.4})
    '        .Z.AddRange({188.4, 288.7, 350.44, 40.5})
    '    End With

    '    zChartData.Series.Add(zS1)
    '    Me.DataSource = zChartData.ToList()
    'End Sub
End Class


