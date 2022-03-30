Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class TrendingReport
    Inherits BaseReportLandscape
    Implements ITelerikReport
    Implements IUtilReport

    Public Sub New()
        InitializeComponent()
        UtilReport.TelerikReport.FixBaseGroups(Me)
    End Sub

    ''' <summary>
    ''' This routine takes the raw data from the view and organizes it for report use.  The raw data has multiples records for each rating.  This routines makes 1 record for each location and stores the 
    ''' mulitple ratings ActiveRating, PassiveRating and TotalRating into thier respective columns called SeriesActiveData, SeriesPassiveData and SeriesTotalData
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub NormalizeData()

        'Get Unique Addresses
        Dim zDV As DataView = Me.DataSource.DefaultView
        Dim zDT As DataTable = zDV.ToTable(True, {"FileNo", "ClientLocNo", "City", "StProv", "Country", "TIV", "Division", "Facility", "Address1"})
        zDT.Columns.Add("SeriesActiveData", GetType(TrendingData))
        zDT.Columns.Add("SeriesPassiveData", GetType(TrendingData))
        zDT.Columns.Add("SeriesTotalData", GetType(TrendingData))
   
        For Each zRow As DataRow In zDT.Rows
            zRow("SeriesActiveData") = GetSeriesPointData(ScoreType.ActiveScore, zRow("FileNo"))
            zRow("SeriesPassiveData") = GetSeriesPointData(ScoreType.PassiveScore, zRow("FileNo"))
            zRow("SeriesTotalData") = GetSeriesPointData(ScoreType.TotalScore, zRow("FileNo"))
        Next

        Me.DataSource = zDT

    End Sub

    Private Function GetSeriesPointData(pScoreType As ScoreType, pFileNo As String) As TrendingData
        Dim zTrendData As New TrendingData

        'filter source data based on fileno to get the datapoints
        Dim zDV As DataView = Me.DataSource.DefaultView
        zDV.RowFilter = "FileNo='" & pFileNo & "'"
        zDV.Sort = "fldOrdinal ASC"

        Dim zDTRatings As New DataTable

        Select Case pScoreType
            Case ScoreType.ActiveScore
                zDTRatings = zDV.ToTable(False, {"ActiveScore", "fldYear", "fldOrdinal"})

            Case ScoreType.PassiveScore
                zDTRatings = zDV.ToTable(False, {"PassiveScore", "fldYear", "fldOrdinal"})

            Case Else
                zDTRatings = zDV.ToTable(False, {"TotalScore", "fldYear", "fldOrdinal"})

        End Select

        zTrendData.AddPoints(zDTRatings.Rows)

        Return zTrendData

    End Function

    Private Enum ScoreType
        ActiveScore = 1
        PassiveScore = 2
        TotalScore = 3
    End Enum

    Public Sub SetChartProps(Optional pUseTwoDigitYear As Boolean = False)

        Dim zCategoryGroup As New GraphGroup
        zCategoryGroup.Name = "DefGroup"
        zCategoryGroup.Label = "DefGroup"
        zCategoryGroup.Groupings.Add(New Grouping("=Fields.Ordinal"))

        Dim zSeriesGroup As New GraphGroup
        zSeriesGroup.Name = "SerGroup"
        zSeriesGroup.Label = "SerGroup"
        zSeriesGroup.Groupings.Add(New Grouping("=Fields.Category"))

        Dim zTrendCS As New TrendingCoordinateSystem

      

        Dim zActiveLS As LineSeries = CreateLineSeries(zTrendCS, zCategoryGroup, zSeriesGroup, ColorTranslator.FromHtml("#18375B"))
        With Graph1
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

        Dim zPassiveLS As LineSeries = CreateLineSeries(zTrendCS, zCategoryGroup, zSeriesGroup, ColorTranslator.FromHtml("#953637"))
        With Graph2
            .Legend.Style.Visible = False
            .CoordinateSystems.Add(zPassiveLS.CoordinateSystem)
            .DataSource = Nothing 'See the NeedDataSource Event Handler 
            .Series.Add(zPassiveLS)
            .SeriesGroups.Add(zPassiveLS.SeriesGroup)
            .CategoryGroups.Add(zPassiveLS.CategoryGroup)
            .Style.Font.Size = New Drawing.Unit(7)
            .Style.BorderColor.Default = Color.Black
            .Style.BorderStyle.Default = BorderType.Solid
            .Style.BorderWidth.Default = New Telerik.Reporting.Drawing.Unit(1)
        End With

        Dim zTotalLS As LineSeries = CreateLineSeries(zTrendCS, zCategoryGroup, zSeriesGroup, ColorTranslator.FromHtml("#958B58"))
        With Graph3
            .Legend.Style.Visible = False
            .CoordinateSystems.Add(zTotalLS.CoordinateSystem)
            .DataSource = Nothing 'See the NeedDataSource Event Handler 
            .Series.Add(zTotalLS)
            .SeriesGroups.Add(zTotalLS.SeriesGroup)
            .CategoryGroups.Add(zTotalLS.CategoryGroup)
            .Style.Font.Size = New Drawing.Unit(7)
            .Style.BorderColor.Default = Color.Black
            .Style.BorderStyle.Default = BorderType.Solid
            .Style.BorderWidth.Default = New Telerik.Reporting.Drawing.Unit(1)
        End With


    End Sub

    Private Function CreateLineSeries(pCoordinateSystem As CartesianCoordinateSystem, pCategoryGroup As GraphGroup, pSeriesGroup As GraphGroup, pColor As System.Drawing.Color) As LineSeries
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

    Public Function AppendPracticeToTitle() As Boolean Implements ITelerikReport.AppendPracticeToTitle
        Return True
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
        Return "Facility Rating Trending Report"
    End Function

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties

    Private Sub TrendingReport_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        NormalizeData()
        SetChartProps(False)
        Me.uxTIVLabel.Value = "TIV " & rptProperties.Currency.colFldCode

        If Me.rptProperties.Practice.colFldId = UtilPractice.PracticeEnum.BM Then
            uxActiveColumnTitle.Value = "Management Programs Chart"
            uxPassiveColumnTitle.Value = "Physical Assets Chart"
            uxTotalFacilityColumnSubTitle.Visible = False
            uxTotalFacilityColumnTitle.Location = New Drawing.PointU(uxTotalFacilityColumnTitle.Location.X, New Drawing.Unit(0.21, UnitType.Inch))
        End If

        UtilReport.TelerikReport.SetFilterText(sender, rptProperties)
        UtilReport.TelerikReport.SetFooterTexts(sender, rptProperties)
    End Sub

    Private Sub GraphNeedDataSourceHandler(sender As Object, e As EventArgs) Handles Graph1.NeedDataSource, Graph2.NeedDataSource, Graph3.NeedDataSource
        Dim zProcessDetail As Processing.DetailSection = sender.Parent
        Dim zIDataObject As Processing.IDataObject = zProcessDetail.DataObject
        Dim zData As TrendingData = Nothing
        Dim zGraph As Graph = sender.ItemDefinition
        Select Case zGraph.Name.ToLower
            Case "graph1"
                zData = zIDataObject("SeriesActiveData")

            Case "graph2"
                zData = zIDataObject("SeriesPassiveData")

            Case Else
                zData = zIDataObject("SeriesTotalData")
        End Select

        DirectCast(DirectCast(DirectCast(sender.itemdefinition, Graph).CoordinateSystems(0), TrendingCoordinateSystem).YAxis.Scale, Telerik.Reporting.NumericalScale).Maximum = zData.MaxPoint
        DirectCast(DirectCast(DirectCast(sender.itemdefinition, Graph).CoordinateSystems(0), TrendingCoordinateSystem).YAxis.Scale, Telerik.Reporting.NumericalScale).Minimum = zData.MinPoint
        sender.DataSource = zData.DataPointList
    End Sub

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

        Public Sub New(pRating As Double, pYear As String, pOrdinal As Integer)
            Me.Rating = pRating
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

End Class



