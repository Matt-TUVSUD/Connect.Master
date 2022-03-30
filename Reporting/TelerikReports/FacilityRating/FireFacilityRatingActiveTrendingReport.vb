Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class FireFacilityRatingActiveTrendingReport
    Inherits BaseReportLandscape
    Implements ITelerikReport
    Implements IUtilReport

    'links the graph id with the data column to bind to
    Private _GraphBind As New Dictionary(Of String, String)

    Private _DarkBlueHexColor As String = "#18375B"
    Private _DarkRedHexColor As String = "#953637"

    Public Sub New()
        InitializeComponent()
        UtilReport.TelerikReport.FixBaseGroups(Me)

        With _GraphBind
            .Add("uxProtectionGraph", "Protection")
            .Add("uxHEGraph", "Human")
            .Add("uxNatHazGraph", "NatHaz")
            .Add("uxBCPGraph", "Business")
        End With

    End Sub

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
        Return "Facility Rating Active Trending Chart"
    End Function

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties

    Private Sub TrendingReport_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        Me.DataSource = UtilTrend.BuildData(Me.DataSource, _GraphBind.Values.ToArray)
        UtilTrend.SetGraphProperties(Me, _GraphBind.Keys.ToArray, _DarkBlueHexColor, False)
        Me.uxTIVLabel.Value = "TIV " & vbNewLine & rptProperties.Currency.colFldCode
        UtilReport.TelerikReport.SetFilterText(sender, rptProperties)
        UtilReport.TelerikReport.SetFooterTexts(sender, rptProperties)
    End Sub

    Private Sub GraphNeedDataSourceHandler(sender As Object, e As EventArgs) Handles uxHEGraph.NeedDataSource, uxNatHazGraph.NeedDataSource, uxBCPGraph.NeedDataSource, uxProtectionGraph.NeedDataSource
        Dim zProcessDetail As Processing.DetailSection = sender.Parent
        Dim zIDataObject As Processing.IDataObject = zProcessDetail.DataObject
        Dim zData As UtilTrend.TrendingData = Nothing
        Dim zGraph As Graph = sender.ItemDefinition

        'Get the data column to bind this graph to
        zData = zIDataObject(_GraphBind(zGraph.Name))

        DirectCast(DirectCast(DirectCast(sender.itemdefinition, Graph).CoordinateSystems(0), UtilTrend.TrendingCoordinateSystem).YAxis.Scale, Telerik.Reporting.NumericalScale).Maximum = zData.MaxPoint
        DirectCast(DirectCast(DirectCast(sender.itemdefinition, Graph).CoordinateSystems(0), UtilTrend.TrendingCoordinateSystem).YAxis.Scale, Telerik.Reporting.NumericalScale).Minimum = zData.MinPoint
        sender.DataSource = zData.DataPointList

    End Sub





End Class



