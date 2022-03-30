Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports System.Drawing

Public Class UtilTrend

    Public Shared Function BuildData(pDataSource As DataTable, pRatingColumns As String()) As DataTable

        'Get Unique Addresses
        Dim zDV As DataView = pDataSource.DefaultView
        Dim zDT As DataTable = zDV.ToTable(True, {"FileNo", "ClientLocNo", "City", "StProv", "Country", "TIV", "Division", "Facility", "Address1"})
        pRatingColumns.ToList.ForEach(Sub(x) zDT.Columns.Add(x, GetType(TrendingData)))

        For Each zRow As DataRow In zDT.Rows
            For Each pRatingCol As String In pRatingColumns
                zRow(pRatingCol) = BuildData(pDataSource, zRow("FileNo"), pRatingCol)
            Next
        Next
        Return zDT
    End Function

    Public Shared Function BuildData(pDataSource As DataTable, pFileNo As String, pRatingColumn As String) As TrendingData
        Dim zTrendData As New TrendingData

        'filter source data based on fileno to get the datapoints
        Dim zDV As DataView = pDataSource.DefaultView
        zDV.RowFilter = "FileNo='" & pFileNo & "'"
        zDV.Sort = "fldOrdinal ASC"

        Dim zDTRatings As New DataTable
        zDTRatings = zDV.ToTable(False, {pRatingColumn, "fldYear", "fldOrdinal"})
        zTrendData.AddPoints(zDTRatings.Rows)
        Return zTrendData
    End Function

    Public Class TrendingData
        Public Property DataPointList As New List(Of TrendingDataPoint)

        Public Sub AddPoints(pRows As DataRowCollection)
            For Each zRow As DataRow In pRows
                DataPointList.Add(New TrendingDataPoint(zRow(0), zRow(1), zRow(2)))
            Next
        End Sub

        Public ReadOnly Property MaxPoint As Integer
            Get
                Dim zList As System.Linq.IOrderedEnumerable(Of TrendingDataPoint) = DataPointList.OrderByDescending(Of Double)(Function(x) x.Rating)
                If zList.Count > 0 Then
                    Return zList(0).Rating + 10
                Else
                    Return 100
                End If
            End Get
        End Property

        Public ReadOnly Property MinPoint As Integer
            Get
                Dim zList As System.Linq.IOrderedEnumerable(Of TrendingDataPoint) = DataPointList.OrderBy(Of Double)(Function(x) x.Rating)
                If zList.Count > 0 Then
                    Return zList(0).Rating - 30
                Else
                    Return 0
                End If
            End Get
        End Property
    End Class

    Public Class TrendingDataPoint
        Public Property Rating As Double
        Public Property Category As String
        Public Property Year As String
        Public Property Ordinal As Integer

        Public Sub New(pRatingValue As Double, pYear As String, pOrdinal As Integer)
            Me.Rating = pRatingValue
            Me.Category = "SeriesData"
            Me.Year = pYear
            Me.Ordinal = pOrdinal
        End Sub
    End Class

    Public Class TrendingCoordinateSystem
        Inherits Telerik.Reporting.CartesianCoordinateSystem

        Public Sub New()
            MyBase.New()

            Dim zOrderAxis As New GraphAxis
            zOrderAxis.Scale = New Telerik.Reporting.CategoryScale
            zOrderAxis.MajorGridLineStyle.Visible = False
            zOrderAxis.MinorGridLineStyle.Visible = False
            zOrderAxis.Style.Visible = False

            Dim zRatingAxis As New GraphAxis
            zRatingAxis.Scale = New Telerik.Reporting.NumericalScale
            DirectCast(zRatingAxis.Scale, Telerik.Reporting.NumericalScale).Maximum = 999  'See the Graph NeedDataSource Event Handler 
            DirectCast(zRatingAxis.Scale, Telerik.Reporting.NumericalScale).Minimum = 888  'See the Graph NeedDataSource Event Handler 
            zRatingAxis.MajorGridLineStyle.Visible = False
            zRatingAxis.MinorGridLineStyle.Visible = False
            zRatingAxis.Style.Visible = False

            Me.XAxis = zOrderAxis
            Me.YAxis = zRatingAxis

        End Sub

    End Class

    Public Shared Sub SetGraphProperties(ByRef pReport As Report, pGraphIds As String(), pLineColor As String, Optional pUseTwoDigitYear As Boolean = False)

        Dim zCategoryGroup As New GraphGroup
        zCategoryGroup.Name = "DefGroup"
        zCategoryGroup.Label = "DefGroup"
        zCategoryGroup.Groupings.Add(New Grouping("=Fields.Ordinal"))

        Dim zSeriesGroup As New GraphGroup
        zSeriesGroup.Name = "SerGroup"
        zSeriesGroup.Label = "SerGroup"
        zSeriesGroup.Groupings.Add(New Grouping("=Fields.Category"))

        Dim zTrendCS As New TrendingCoordinateSystem

        For Each zGraph As String In pGraphIds
            Dim zActiveLS As LineSeries = CreateLineSeries(zTrendCS, zCategoryGroup, zSeriesGroup, ColorTranslator.FromHtml(pLineColor))
            Dim zGraphControl As Telerik.Reporting.Graph = pReport.Items.Find(zGraph, True)(0)
            With zGraphControl
                .Legend.Style.Visible = False
                .CoordinateSystems.Add(zActiveLS.CoordinateSystem)
                .DataSource = Nothing 'See the NeedDataSource Event Handler 
                .Series.Add(zActiveLS)
                .SeriesGroups.Add(zActiveLS.SeriesGroup)
                .CategoryGroups.Add(zActiveLS.CategoryGroup)
                .Style.Font.Size = New Drawing.Unit(7)
                .Style.BorderColor.Default = Color.Black
                .Style.BorderStyle.Default = BorderType.Solid
                .Style.BorderWidth.Default = New Telerik.Reporting.Drawing.Unit(1)
            End With
        Next

    End Sub

    Private Shared Function CreateLineSeries(pCoordinateSystem As CartesianCoordinateSystem, pCategoryGroup As GraphGroup, pSeriesGroup As GraphGroup, pColor As System.Drawing.Color) As LineSeries
        Dim zLS As New LineSeries
        With zLS
            .DataPointLabelStyle.Color = Color.Black
            .DataPointLabelStyle.Font.Bold = False
            .LineStyle.Color = Color.Green
            .LineStyle.LineWidth = New Drawing.Unit(1)
            .CoordinateSystem = pCoordinateSystem
            .Y = "=Fields.Rating"
            .CategoryGroup = pCategoryGroup
            .SeriesGroup = pSeriesGroup
            .DataPointLabel = "{Fields.Rating}" & vbNewLine & "{Fields.Year}"
            .LineType = LineSeries.LineTypes.Straight
            .DataPointLabelAlignment = LineDataPointLabelAlignment.Below
            .DataPointLabelOffset = New Drawing.Unit(3)
            .MarkerType = DataPointMarkerType.Square
            .MarkerSize = New Telerik.Reporting.Drawing.Unit(3)
            .DataPointStyle.Visible = True
            .LineStyle.LineColor = pColor
            .DataPointStyle.Color = pColor
            .DataPointStyle.LineColor = pColor
            .DataPointStyle.BackgroundColor = pColor
            .DataPointLabelStyle.TextAlign = HorizontalAlign.Center
            .MarkerSize = New Telerik.Reporting.Drawing.Unit(3)
        End With

        Return zLS
    End Function


End Class


