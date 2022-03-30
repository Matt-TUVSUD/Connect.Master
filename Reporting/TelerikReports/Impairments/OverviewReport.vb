Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports Telerik.Reporting.Charting
Imports GRC.Connect.Libraries.DataLib.razor

Partial Public Class ImpairmentOverviewReport
    Inherits BaseReportLandscape
    Implements IUtilReport
    Implements ITelerikReport

    Public ChartDataSet As DataSet
    Private TotalImpairments As String

    Public Sub New()
        InitializeComponent()
        SetChartProperties()
        UtilReport.TelerikReport.FixBaseGroups(Me)
    End Sub

    Private Sub OverviewReport_Error(sender As Object, eventArgs As Telerik.Reporting.ErrorEventArgs) Handles Me.Error
        '  ReportUtility.HandleReportError(sender, eventArgs)
    End Sub

    Private Sub OverviewReport_ItemDataBinding(sender As Object, e As System.EventArgs) Handles Me.ItemDataBinding
        Dim zGroups As List(Of rowVwImpairmentDropDownGroups) = VwImpairmentDropDownGroups.LoadData
        Dim zTimeLines As List(Of rowVwImpairmentDropDownGroups) = zGroups.FindAll(Function(x) x.colGroupNo = OverviewGroups.ddTimeline)
        Dim zAreaAffected As List(Of rowVwImpairmentDropDownGroups) = zGroups.FindAll(Function(x) x.colGroupNo = OverviewGroups.ddAreaAffected)
        Dim zEstAreaImp As List(Of rowVwImpairmentDropDownGroups) = zGroups.FindAll(Function(x) x.colGroupNo = OverviewGroups.ddEstimatedAreaImpaired)
        Dim zOccupancy As List(Of rowVwImpairmentDropDownGroups) = zGroups.FindAll(Function(x) x.colGroupNo = OverviewGroups.ddOccupancy)
        Dim zStatus As List(Of rowVwImpairmentDropDownGroups) = zGroups.FindAll(Function(x) x.colGroupNo = OverviewGroups.ddStatus)
        Dim zTypeOfImp As List(Of rowVwImpairmentDropDownGroups) = zGroups.FindAll(Function(x) x.colGroupNo = OverviewGroups.ddTypeOfSystemIm)

        Me.tblSystemsAffected.DataSource = GetDataTable(zTypeOfImp, OverviewGroups.ddTypeOfSystemIm)
        Me.tblRestorationTimeLine.DataSource = GetDataTable(zTimeLines, OverviewGroups.ddTimeline)
        Me.tblOccupancy.DataSource = GetDataTable(zOccupancy, OverviewGroups.ddOccupancy)
        Me.tblImpairmentStatus.DataSource = GetDataTable(zStatus, OverviewGroups.ddStatus)
        Me.tblEstAreaAffected.DataSource = GetDataTable(zEstAreaImp, OverviewGroups.ddEstimatedAreaImpaired)
        Me.tblAreaAffected.DataSource = GetDataTable(zAreaAffected, OverviewGroups.ddAreaAffected)

        Plot(DirectCast(Me.tblRestorationTimeLine.DataSource, DataTable))

        'CreateDataSet()
        'FillChartData()
        'Trace.WriteLine("Chart Data Rows:" & ChartDataSet.Tables("ChartData").Rows.Count)
        'FilterChartData()
        'Trace.WriteLine("Chart Data Rows [Filtered]:" & ChartDataSet.Tables("FilteredData").Rows.Count)
        'SetTimeLineData()
        'SetAreaAffectedData()
        'SetStatusData()
        'SetOccupancyAffectedData()
        'SetEstAreaAffectedData()
        'SetSystemsAffectedData()
        Me.DataSource = Nothing
    End Sub

    Private Function GetDataTable(pList As List(Of rowVwImpairmentDropDownGroups), pGroup As OverviewGroups) As DataTable
        Dim zSrcDT As DataTable = Me.DataSource
        Dim zDT As New DataTable
        zDT.Columns.Add("ItemText")
        zDT.Columns.Add("Total", GetType(System.Int32))


        For Each zGroup As rowVwImpairmentDropDownGroups In pList
            Dim zNew As DataRow = zDT.NewRow
            zNew("ItemText") = zGroup.colTextEnglish
            Select Case pGroup

                Case OverviewGroups.ddAreaAffected
                    zNew("Total") = zSrcDT.Compute("Count(AreaAffectedText)", "AreaAffectedText='" & zGroup.colTextEnglish & "'")

                Case OverviewGroups.ddEstimatedAreaImpaired
                    zNew("Total") = zSrcDT.Compute("Count(EstAreaImpText)", "EstAreaImpText='" & zGroup.colTextEnglish & "'")

                Case OverviewGroups.ddOccupancy
                    zNew("Total") = zSrcDT.Compute("Count(OccupancyText)", "OccupancyText='" & zGroup.colTextEnglish & "'")

                Case OverviewGroups.ddStatus
                    zNew("Total") = zSrcDT.Compute("Count(ImpairmentStatusText)", "ImpairmentStatusText='" & zGroup.colTextEnglish & "'")

                Case OverviewGroups.ddTimeline
                    zNew("Total") = zSrcDT.Compute("Count(RestorationTimeLine)", "RestorationTimeLine='" & zGroup.colTextEnglish & "'")

                Case OverviewGroups.ddTypeOfSystemIm
                    zNew("Total") = zSrcDT.Compute("Count(TypeSysImpText)", "TypeSysImpText='" & zGroup.colTextEnglish & "'")

            End Select
            zDT.Rows.Add(zNew)
        Next

        If pGroup = OverviewGroups.ddTimeline Then
            Dim zErrorCount As Integer = zSrcDT.Compute("Count(RestorationTimeLine)", "RestorationTimeLine='##Error##'")
            If zErrorCount > 0 Then
                Dim zNew As DataRow = zDT.NewRow
                zNew("ItemText") = "##Error##"
                zNew("Total") = zErrorCount
                zDT.Rows.Add(zNew)
            End If
        End If

        Return zDT
    End Function

    'Public Sub CreateDataSet()
    '    ChartDataSet = New DataSet

    '    Dim zDV As DataView = DirectCast(Me.DataSource, DataTable).DefaultView
    '    Dim zSourceFileNoDT As DataTable = zDV.ToTable("SourceData", True, {"FileNo"})
    '    ChartDataSet.Tables.Add(zSourceFileNoDT)

    '    Dim zDT As New DataTable
    '    zDT.Columns.Add("FileNo")
    '    zDT.Columns.Add("ImpairmentStatusCode")
    '    zDT.Columns.Add("AreaAffected")
    '    zDT.Columns.Add("SystemAffected")
    '    zDT.Columns.Add("EstAreaAffected")
    '    zDT.Columns.Add("OccupancyAffected")
    '    zDT.Columns.Add("RestorationTimeLine")
    '    zDT.TableName = "ChartData"
    '    ChartDataSet.Tables.Add(zDT)

    'End Sub

    'Public Sub FilterChartData()
    '    Dim zDT As DataTable = ChartDataSet.Tables("ChartData")
    '    Dim zDataRows() As DataRow = zDT.Select(GetFilterExpression)
    '    Dim zFilteredDT As DataTable = zDataRows.CopyToDataTable
    '    zFilteredDT.TableName = "FilteredData"
    '    ChartDataSet.Tables.Add(zFilteredDT)
    'End Sub

    'Public Sub FillChartData()
    '    Dim zCon As New SqlClient.SqlConnection(UtilDB.ConnectionString)
    '    Dim zCmd As New SqlClient.SqlCommand(UtilReport.SQL.GetImpairmentChartDataSQL(rptProperties.FilePrefix) & ";" & UtilReport.SQL.GetImpairmentChartDataPartitionsSQL(), zCon)
    '    zCon.Open()
    '    Using zCon
    '        ChartDataSet.Load(zCmd.ExecuteReader, LoadOption.OverwriteChanges, {"ChartData", "PartitionData"})
    '        zCon.Close()
    '    End Using
    'End Sub

    'Public Function GetFilterExpression() As String
    '    Dim zSB As New System.Text.StringBuilder
    '    For Each zRow As DataRow In ChartDataSet.Tables("SourceData").Rows
    '        zSB.Append("'" & zRow("FileNo") & "',")
    '    Next

    '    Return "FileNo IN (" & Left(zSB.ToString, zSB.Length - 1) & ")"

    'End Function

    'Private Sub SetTimeLineData()

    '    Dim zPartitionDV = ChartDataSet.Tables("PartitionData").DefaultView
    '    zPartitionDV.RowFilter = "PartitionName='TimeLine'"
    '    zPartitionDV.Sort = "SortOrder ASC"
    '    Dim zPartitionDT As DataTable = zPartitionDV.ToTable

    '    Dim zFilteredData As DataTable = ChartDataSet.Tables("FilteredData")

    '    Dim zDT As New DataTable
    '    zDT.Columns.Add("ItemText")
    '    zDT.Columns.Add("Total", GetType(System.Int32))

    '    For Each zRow As DataRow In zPartitionDT.Rows
    '        Dim zNew As DataRow = zDT.NewRow
    '        zNew("ItemText") = zRow("TextDisplay")
    '        zNew("Total") = zFilteredData.Compute("Count(RestorationTimeLine)", "RestorationTimeLine='" & zRow("TextDisplay") & "'")
    '        zDT.Rows.Add(zNew)
    '    Next

    '    Plot(zDT)

    '    Me.tblRestorationTimeLine.DataSource = zDT

    'End Sub

    'Private Sub SetStatusData()

    '    Dim zPartitionDV = ChartDataSet.Tables("PartitionData").DefaultView
    '    zPartitionDV.RowFilter = "PartitionName='Status'"
    '    zPartitionDV.Sort = "SortOrder ASC"
    '    Dim zPartitionDT As DataTable = zPartitionDV.ToTable

    '    Dim zFilteredData As DataTable = ChartDataSet.Tables("FilteredData")

    '    Dim zDT As New DataTable
    '    zDT.Columns.Add("ItemText")
    '    zDT.Columns.Add("Total", GetType(System.Int32))

    '    For Each zRow As DataRow In zPartitionDT.Rows
    '        Dim zNew As DataRow = zDT.NewRow
    '        zNew("ItemText") = zRow("TextDisplay")
    '        zNew("Total") = zFilteredData.Compute("Count(ImpairmentStatusCode)", "ImpairmentStatusCode='" & zRow("TextDisplay") & "'")
    '        zDT.Rows.Add(zNew)
    '    Next

    '    Me.tblImpairmentStatus.DataSource = zDT

    'End Sub

    'Private Sub SetSystemsAffectedData()

    '    Dim zPartitionDV = ChartDataSet.Tables("PartitionData").DefaultView
    '    zPartitionDV.RowFilter = "PartitionName='SystemAffected'"
    '    zPartitionDV.Sort = "SortOrder ASC"
    '    Dim zPartitionDT As DataTable = zPartitionDV.ToTable

    '    Dim zFilteredData As DataTable = ChartDataSet.Tables("FilteredData")

    '    Dim zDT As New DataTable
    '    zDT.Columns.Add("ItemText")
    '    zDT.Columns.Add("Total", GetType(System.Int32))

    '    For Each zRow As DataRow In zPartitionDT.Rows
    '        Dim zNew As DataRow = zDT.NewRow
    '        zNew("ItemText") = zRow("TextDisplay")
    '        zNew("Total") = zFilteredData.Compute("Count(SystemAffected)", "SystemAffected='" & zRow("TextDisplay") & "'")
    '        zDT.Rows.Add(zNew)
    '    Next

    '    Me.tblSystemsAffected.DataSource = zDT

    'End Sub

    'Private Sub SetAreaAffectedData()

    '    Dim zPartitionDV = ChartDataSet.Tables("PartitionData").DefaultView
    '    zPartitionDV.RowFilter = "PartitionName='AreaAffected'"
    '    zPartitionDV.Sort = "SortOrder ASC"
    '    Dim zPartitionDT As DataTable = zPartitionDV.ToTable

    '    Dim zFilteredData As DataTable = ChartDataSet.Tables("FilteredData")

    '    Dim zDT As New DataTable
    '    zDT.Columns.Add("ItemText")
    '    zDT.Columns.Add("Total", GetType(System.Int32))

    '    For Each zRow As DataRow In zPartitionDT.Rows
    '        Dim zNew As DataRow = zDT.NewRow
    '        zNew("ItemText") = zRow("TextDisplay")
    '        zNew("Total") = zFilteredData.Compute("Count(AreaAffected)", "AreaAffected='" & zRow("TextDisplay") & "'")
    '        zDT.Rows.Add(zNew)
    '    Next

    '    Me.tblAreaAffected.DataSource = zDT

    'End Sub

    'Private Sub SetEstAreaAffectedData()

    '    Dim zPartitionDV = ChartDataSet.Tables("PartitionData").DefaultView
    '    zPartitionDV.RowFilter = "PartitionName='EstimatedAreaAffected'"
    '    zPartitionDV.Sort = "SortOrder ASC"
    '    Dim zPartitionDT As DataTable = zPartitionDV.ToTable

    '    Dim zFilteredData As DataTable = ChartDataSet.Tables("FilteredData")

    '    Dim zDT As New DataTable
    '    zDT.Columns.Add("ItemText")
    '    zDT.Columns.Add("Total", GetType(System.Int32))

    '    For Each zRow As DataRow In zPartitionDT.Rows
    '        Dim zNew As DataRow = zDT.NewRow
    '        zNew("ItemText") = zRow("TextDisplay")
    '        zNew("Total") = zFilteredData.Compute("Count(EstAreaAffected)", "EstAreaAffected='" & zRow("TextDisplay") & "'")
    '        zDT.Rows.Add(zNew)
    '    Next

    '    Me.tblEstAreaAffected.DataSource = zDT

    'End Sub

    'Private Sub SetOccupancyAffectedData()

    '    Dim zPartitionDV = ChartDataSet.Tables("PartitionData").DefaultView
    '    zPartitionDV.RowFilter = "PartitionName='Occupancy'"
    '    zPartitionDV.Sort = "SortOrder ASC"
    '    Dim zPartitionDT As DataTable = zPartitionDV.ToTable

    '    Dim zFilteredData As DataTable = ChartDataSet.Tables("FilteredData")

    '    Dim zDT As New DataTable
    '    zDT.Columns.Add("ItemText")
    '    zDT.Columns.Add("Total", GetType(System.Int32))

    '    For Each zRow As DataRow In zPartitionDT.Rows
    '        Dim zNew As DataRow = zDT.NewRow
    '        zNew("ItemText") = zRow("TextDisplay")
    '        zNew("Total") = zFilteredData.Compute("Count(OccupancyAffected)", "OccupancyAffected='" & zRow("TextDisplay") & "'")
    '        zDT.Rows.Add(zNew)
    '    Next

    '    Me.tblOccupancy.DataSource = zDT

    'End Sub

#Region "Charting Functions"
    Public Sub SetChartProperties()

        Dim zCustPal As New FireImpairmentChartPalette
        With Me.Chart1
            .Series.Clear()
            .Style.BackgroundColor = Color.White
            .ChartTitle.Visible = False
            .AutoLayout = False
            .DefaultType = Charting.ChartSeriesType.Pie
            .CustomPalettes.Add(zCustPal)
            .SeriesPalette = zCustPal.Name
            .Appearance.FillStyle.MainColor = Color.White
            .Height = New Telerik.Reporting.Drawing.Unit(375)
            .Width = New Telerik.Reporting.Drawing.Unit(600)
            .Appearance.Border.Visible = True

            .Legend.Appearance.Dimensions.Width = New Telerik.Reporting.Charting.Styles.Unit(500, Styles.UnitType.Pixel)
            .Legend.Appearance.Dimensions.Height = New Styles.Unit(25, Styles.UnitType.Pixel)
            .Legend.Appearance.Dimensions.Margins.Bottom = New Styles.Unit(25, Styles.UnitType.Pixel)
            .Legend.Appearance.Dimensions.AutoSize = False
            .Legend.Appearance.Location = Charting.Styles.LabelLocation.OutsidePlotArea
            .Legend.Appearance.Position.AlignedPosition = Charting.Styles.AlignedPositions.Bottom
            .Legend.Appearance.Overflow = Charting.Styles.Overflow.Row
            .Legend.Appearance.ItemMarkerAppearance.Figure = "Rectangle"
            .Legend.Appearance.ItemMarkerAppearance.FillStyle.FillType = Charting.Styles.FillType.Solid
            .Legend.Appearance.ItemTextAppearance.TextProperties.Font = New System.Drawing.Font("Arial", 9, FontStyle.Bold, GraphicsUnit.Point)
            .Legend.TextBlock.Appearance.TextProperties.Color = Color.Black
            .Legend.Appearance.Border.Visible = True
            .Legend.Appearance.Border.Width = 0.5
            .Legend.Appearance.Border.Color = Color.Black
            .Legend.Visible = True
            .Legend.Appearance.Dimensions.Width = New Styles.Unit(560, Styles.UnitType.Pixel)


            .PlotArea.Appearance.FillStyle.GammaCorrection = True
            .PlotArea.Appearance.Border.Visible = False
            .PlotArea.Appearance.Dimensions.Margins.Top = New Styles.Unit(5)
            .PlotArea.Appearance.Dimensions.Margins.Left = New Styles.Unit(5)
            .PlotArea.Appearance.Dimensions.Margins.Right = New Styles.Unit(5)
            .PlotArea.Appearance.Dimensions.Margins.Bottom = New Styles.Unit(50)
            .Appearance.Border.Visible = True
            .ImageFormat = System.Drawing.Imaging.ImageFormat.Jpeg

        End With

        AddSeries()

    End Sub

    Public ReadOnly Property ChartTextFont() As System.Drawing.Font
        Get
            Return New System.Drawing.Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point)
        End Get
    End Property

    Private Sub AddSeries()

        Dim zSeries As Charting.ChartSeries
        zSeries = New Charting.ChartSeries("Impairment", Charting.ChartSeriesType.Pie)
        FormatSeries(zSeries)
        Me.Chart1.Series.Add(zSeries)

    End Sub

    Private Sub FormatSeries(ByRef pSeries As Charting.ChartSeries)
        'pSeries.Appearance.LabelAppearance.Position.AlignedPosition = Charting.Styles.AlignedPositions.Center
        pSeries.Appearance.TextAppearance.TextProperties.Font = ChartTextFont
        pSeries.Appearance.TextAppearance.TextProperties.Color = Color.Black
        pSeries.Appearance.LegendDisplayMode = Charting.ChartSeriesLegendDisplayMode.ItemLabels
        pSeries.Appearance.ShowLabelConnectors = True
        pSeries.Appearance.TextAppearance.MaxLength = 100
        ' pSeries.Appearance.ExplodePercent = 5
        pSeries.Appearance.ExplodePercent = 10

    End Sub

    Private Sub Plot(dt As DataTable)
        Dim zSD As Double = dt.Rows(0)("Total")
        Dim z1To5 As Double = dt.Rows(1)("Total")
        Dim z6To10 As Double = dt.Rows(2)("Total")
        Dim zOver10 As Double = dt.Rows(3)("Total")
        Dim zPAO As Double = dt.Rows(4)("Total")
        Plot(zSD, z1To5, z6To10, zOver10, zPAO)
    End Sub

    Private Sub Plot(Optional ByVal pSameDay As Double = 0.0, Optional ByVal pOneToFive As Double = 0.0, Optional ByVal pSixToTen As Double = 0.0, Optional ByVal pOverTen As Double = 0.0, Optional ByVal pPending As Double = 0.0)
        Trace.WriteLine("Plot()  [Overview Report]")

        Dim zTotal As Double
        Dim zItem As Charting.ChartSeriesItem = Nothing

        zTotal = pSameDay + pOneToFive + pSixToTen + pOverTen + pPending
        TotalImpairments = Me.DataSource.Rows.Count


        zItem = New Charting.ChartSeriesItem(CalculatePercentage(pSameDay, zTotal))
        zItem.Name = "Same Day"
        zItem.Label.TextBlock.Text = zItem.YValue & "%"
        FormatItem(zItem)
        Me.Chart1.Series(0).AddItem(zItem)

        zItem = New Charting.ChartSeriesItem(CalculatePercentage(pOneToFive, zTotal))
        zItem.Name = "1-5 Days"
        zItem.Label.TextBlock.Text = zItem.YValue & "%"
        FormatItem(zItem)
        Me.Chart1.Series(0).AddItem(zItem)

        zItem = New Charting.ChartSeriesItem(CalculatePercentage(pSixToTen, zTotal))
        zItem.Name = "6-10 Days"
        zItem.Label.TextBlock.Text = zItem.YValue & "%"
        FormatItem(zItem)
        Me.Chart1.Series(0).AddItem(zItem)

        zItem = New Charting.ChartSeriesItem(CalculatePercentage(pOverTen, zTotal))
        zItem.Name = "Over 10 Days"
        zItem.Label.TextBlock.Text = zItem.YValue & "%"
        FormatItem(zItem)
        Me.Chart1.Series(0).AddItem(zItem)


        zItem = New Charting.ChartSeriesItem(CalculatePercentage(pPending, zTotal))
        zItem.Name = "Pending/Advisory/Overdue"
        zItem.Label.TextBlock.Text = zItem.YValue & "%"
        FormatItem(zItem)
        Me.Chart1.Series(0).AddItem(zItem)

    End Sub

    Private Function CalculatePercentage(ByVal pNumber As Integer, ByVal pTotal As Integer) As Integer
        If pTotal <> 0 Then
            Dim zPercent As Single = (pNumber / pTotal) * 100
            Return Int(Math.Round(zPercent, 2))
        Else
            Return 0
        End If

    End Function

    Private Sub FormatItem(ByRef pItem As Charting.ChartSeriesItem)

        If pItem.YValue > 0 Then
            pItem.Appearance.FillStyle.FillType = Charting.Styles.FillType.ComplexGradient
            pItem.Label.TextBlock.Appearance.TextProperties.Font = New System.Drawing.Font("Arial", 10, FontStyle.Bold)
            pItem.Label.TextBlock.Appearance.TextProperties.Color = Color.Black
            pItem.Label.Appearance.Distance = 15
            pItem.Appearance.FillStyle.FillSettings.GradientMode = Charting.Styles.GradientFillStyle.BackwardDiagonal
            pItem.Appearance.Exploded = True
            pItem.Label.Appearance.LabelLocation = Charting.Styles.StyleSeriesItemLabel.ItemLabelLocation.Outside
            pItem.Label.Appearance.Dimensions.Paddings = New Charting.Styles.ChartPaddings(5, 5, 5, 5)
            pItem.Appearance.Border.Visible = True
            pItem.Appearance.Border.Color = Color.Black
            pItem.Appearance.Border.Width = 1
        Else
            pItem.Label.Visible = False
            pItem.Appearance.FillStyle.FillType = Charting.Styles.FillType.ComplexGradient
            pItem.Label.TextBlock.Appearance.TextProperties.Font = New System.Drawing.Font("Arial", 10, FontStyle.Bold)
            pItem.Label.TextBlock.Appearance.TextProperties.Color = Color.Transparent
            pItem.Appearance.Border.Visible = False
            pItem.Appearance.Border.Color = Color.Transparent
            pItem.Appearance.Border.Width = 1
        End If
    End Sub

    Public Enum OverviewGroups
        ddEstimatedAreaImpaired = 1
        ddOccupancy = 2
        ddTypeOfSystemIm = 3
        ddAreaAffected = 4
        ddStatus = 5
        ddTimeline = 6
    End Enum

#End Region

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties

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
        Return "<strong>Total No. of Impairments: " & TotalImpairments & "</strong>" '"<span style='font-size: x-small;'><strong>Total No. of Impairments = " & TotalImpairments & "</strong></span>"
    End Function

    Public Function ReportTitle() As String Implements ITelerikReport.ReportTitle
        Return "Impairment Summary Report"
    End Function

    Private Sub ImpairmentOverviewReport_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        UtilReport.TelerikReport.SetFilterText(sender, rptProperties)
        UtilReport.TelerikReport.SetDisclaimerText(sender, rptProperties)
        UtilReport.TelerikReport.SetSortText(sender, rptProperties)
    End Sub

End Class