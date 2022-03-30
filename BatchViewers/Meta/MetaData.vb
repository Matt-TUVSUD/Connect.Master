Imports GRC.Connect.Libraries.DataLib.razor
Imports Telerik.WinControls.UI

Namespace Meta

    Public Class MetaData

        Public Shared Grids As List(Of rowTblMetaGrid)
        Public Shared Charts As List(Of rowTblMetaChart)
        Public Shared Reports As List(Of rowTblMetaReport)
        Public Shared GridColumns As List(Of rowTblMetaGridColumn)
        Public Shared ProgramStatus As List(Of rowTblMetaProgramStatus)
        Public Shared Navlink As List(Of rowTblNavLink)
        Public Shared Sources As List(Of rowTblMetaSource)
        Public Shared GridColumnTemplates As List(Of rowTblMetaGridColumnTemplate)
        Public Shared ChartSeries As List(Of rowTblMetaChartSeries)
        Public Shared ChartSeriesDetails As List(Of rowTblMetaChartSeriesDetail)

        Public Shared Sub LoadData()
            Grids = TblMetaGrid.LoadData
            Charts = TblMetaChart.LoadData
            Reports = TblMetaReport.LoadData
            GridColumns = TblMetaGridColumn.LoadData
            ProgramStatus = TblMetaProgramStatus.LoadData
            Navlink = TblNavLink.LoadData
            Sources = TblMetaSource.LoadData
            GridColumnTemplates = TblMetaGridColumnTemplate.LoadData
            ChartSeries = TblMetaChartSeries.LoadData
            ChartSeriesDetails = TblMetaChartSeriesDetail.LoadData
        End Sub

        Public Enum DataSources
            Grids = 1
            GridColumns
            Reports
            Sources
            NavLinks
            ColumnTemplate
            Charts
            ChartSeries
            ChartSeriesDetail
            ProgramStatus
        End Enum

     End Class

    Public Class MetaForm

        Public Shared Function GetTypes() As List(Of Type)

            Dim zAllTypes As List(Of Type) = Reflection.Assembly.GetExecutingAssembly.GetTypes().ToList()
            Dim zForms As List(Of Type)
            zForms = zAllTypes.FindAll(Function(x) x.BaseType = GetType(System.Windows.Forms.Form))
            zForms.AddRange(zAllTypes.FindAll(Function(x) x.BaseType = GetType(Telerik.WinControls.UI.RadForm)))
            Return zForms.OrderBy(Function(x) x.Name).ToList()

        End Function

    End Class


End Namespace
