Imports GRC.Connect.Libraries.DataLib.razor

Public Class UtilGDC
    Const _DEFAULT_JSRGBA As String = "rgba(255,255,255,1)"
    Const _FAVORITE_GRID_ID As Integer = 183
    Const _VWFIRESECONDARYSOURCEID = 271
    Const _VWBMSECONDARYSOURCEID = 295
    Const _VWIRSECONDARYSOURCEID = 290
    Const _VWNATHAZWINDSECONDARYSOURCEID = 284
    Const _VWNATHAZFLOODSECONDARYSOURCEID = 286
    Const _VWNATHAZSEISMICCONDARYSOURCEID = 288
    Const _VWNHWINDSECONDARYSOURCEID = 379
    Const _VWNHFLOODSECONDARYSOURCEID = 381
    Const _VWNHSEISMICCONDARYSOURCEID = 383

    Const _FIREBENCHMARKRATINGTOTALFACILITYSCORE = 4
    Const _BOILERBENCHMARKRATINGTOTALFACILITYSCORE = 54
    Const _FIREBENCHMARKRATINGTOTALFACILITYSCOREBYLOCATION = 57
    Const _BOILERBENCHMARKRATINGTOTALFACILITYSCOREBYLOCATION = 58
    Const _FIREFACILITYACHIEVABLERISKIMPROVEMENT = 59
    Const _BMFACILITYACHIEVABLERISKIMPROVEMENT = 60

    'Facility Rating Trend chart variables
    Private _TotalCount As Integer = 0
    Private _Driver As DataTable
    Private _Data As DataTable
    Private _Meta As DataTable
    Private _FRTsourceView As String
    Private _SortField As String = "TIV"
    Private _SortDirection As String = "DESC"
    '----------------------------------------

    Public PropDriverCount As Integer = 0
    Public PropFavoriteId As Integer = 0
    Public PropReportId As Integer = 0
    Public PropReportSetId As Integer = 0
    Public PropGridId As Integer = 0
    Public PropChartId As Integer = 0
    Public PropBatchSetId As Integer = 0
    Public PropSourceId As Integer = 0
    '    Public PropSafeGUID As String = ""
    Public _PropSafeGUID As String = ""
    Public PropSafeID As Integer = 0
    Public PropColumnName As String = ""
    Public PropSort As String = ""
    Public PropFilter As String = ""
    Public PropCriteria As String = ""
    Public PropEZUserId As Integer = 0
    Public PropSortText As String = ""
    Public PropFilterText As String = ""
    Public PropFavFilter As String = ""
    Public PropFavCriteria As String = ""
    Public PropFavFilterText As String = ""
    Public PropDepictedByColumnName As String = ""

    Public PropCriteriaText As String = ""
    Public PropCurrency As TblMetaCurrency.Currencies = TblMetaCurrency.Currencies.UsDollar
    Friend PropDataCount As Integer = 0

    Public PropPageSize As Integer = 30
    Public PropPageNumber As Integer = 1

    Public PropParameters As IUtilSQLMakerParameterInfo

    Public Enum TrendingReportMode
        None = 0
        FireFacilityRatingTrend
        BMFacilityRatingTrend
        FireTrendingPassive
        FireTrendingActive
        BMTrendingPassive
        BMTrendingActive
    End Enum

    Public Property PropSafeGUID
        Get
            Return _PropSafeGUID
        End Get
        Set(value)
            _PropSafeGUID = value
            PropSafeID = UtilGSafe.GetId(value)
        End Set
    End Property

    Public Function GetReportSQL() As String
        'Set the PropReportId, PropReportSetId before calling this function.  Return String
        Dim zReturn As String = ""

        'Get the sourceid from the report id
        Dim zR As rowTblMetaReport = TblMetaReport.LoadByPrimaryKey(PropReportId)
        PropSourceId = zR.colFldSourceId

        'Set UtilSQLMaker, sourceid, guid
        Dim zDataMaker As New UtilSQLMaker(PropReportId, UtilSQLMaker.SQLMetaData.MetaContext.Reports, PropReportSetId)

        'Set required parameters
        zDataMaker.Parameters = PropParameters

        Dim zFilter As New UtilFilter

        'Process sort options
        Call zFilter.SetSort(PropSort, zDataMaker)
        PropSortText = zFilter.SortText

        'Process filter options
        Call zFilter.SetFilter(PropFilter, zDataMaker)
        PropFilterText = zFilter.FilterText

        'If we have filter information that produces sql changes AND criteria information that produces sql changes, then we must put a SQL AND in the middle
        If NeedAnd() Then zDataMaker.Where.AndOperator()

        'Process criteria options
        Call zFilter.SetFilter(PropCriteria, zDataMaker)
        PropCriteriaText = zFilter.FilterText

        'generate sql
        Dim zDataSQL As String = zDataMaker.GenerateSQL("GetReportSQL", PropReportSetId, PropReportId, PropFilter)

        zReturn = zDataSQL

        Return zReturn
    End Function

    Public Function GetGridExportSQL() As String
        'Set the PropGridId, PropSafeGUID before calling this function.  Return String
        Dim zReturn As String

        'Get the sourceid from the grid id
        Dim zG As rowTblMetaGrid = TblMetaGrid.LoadByPrimaryKey(PropGridId)
        PropSourceId = zG.colFldSourceId

        'Set EZUserId from GSafe
        PropEZUserId = CInt(UtilGSafe.GetValue(PropSafeGUID, UtilGSafe.KeyName.EzyUserId))

        'Set UtilSQLMaker, sourceid, guid
        Dim zDataMaker As New UtilSQLMaker(PropGridId, UtilSQLMaker.SQLMetaData.MetaContext.Grids, PropSafeID)

        'Set required parameters
        zDataMaker.Parameters = PropParameters

        Dim zFilter As New UtilFilter

        'Process sort options
        Call zFilter.SetSort(PropSort, zDataMaker)
        PropSortText = zFilter.SortText

        'Process filter options
        Call zFilter.SetFilter(PropFilter, zDataMaker)
        PropFilterText = zFilter.FilterText

        'If we have filter information that produces sql changes AND criteria information that produces sql changes, then we must put a SQL AND in the middle
        If NeedAnd() Then zDataMaker.Where.AndOperator()

        'Process criteria options
        Call zFilter.SetFilter(PropCriteria, zDataMaker)
        PropCriteriaText = zFilter.FilterText

        'generate sql
        Dim zDataSQL As String = zDataMaker.GenerateSQL("GetGridExportSQL", PropSafeGUID, PropEZUserId, PropFilter)
        If PropGridId = UtilMeta.GetMetaKey("FacilitySearch", 313) Then zDataSQL = zDataSQL.Replace("999999999", CoreLib.UtilGSafe.GetId(PropSafeGUID))
        zReturn = zDataSQL

        Return zReturn
    End Function

    Public Function GetBatchExportSQL() As String
        'Set the PropGridId, PropBatchId before calling this function.  Return String
        Dim zReturn As String

        'Get the sourceid from the grid id
        Dim zG As rowTblMetaGrid = TblMetaGrid.LoadByPrimaryKey(PropGridId)
        PropSourceId = zG.colFldSourceId

        'Set UtilSQLMaker, sourceid, guid
        Dim zDataMaker As New GRC.Connect.Libraries.CoreLib.UtilSQLMaker(PropGridId, UtilSQLMaker.SQLMetaData.MetaContext.Extracts, PropBatchSetId)

        'Set required parameters
        zDataMaker.Parameters = PropParameters

        Dim zFilter As New GRC.Connect.Libraries.CoreLib.UtilFilter

        'Process sort options
        Call zFilter.SetSort(PropSort, zDataMaker)
        PropSortText = zFilter.SortText

        'Process filter options
        Call zFilter.SetFilter(PropFilter, zDataMaker)
        PropFilterText = zFilter.FilterText

        'If we have filter information that produces sql changes AND criteria information that produces sql changes, then we must put a SQL AND in the middle
        If NeedAnd() Then zDataMaker.Where.AndOperator()

        'Process criteria options
        Call zFilter.SetFilter(PropCriteria, zDataMaker)
        PropCriteriaText = zFilter.FilterText

        'generate sql
        Dim zDataSQL As String = zDataMaker.GenerateSQL("GetBatchExportSQL", PropBatchSetId, PropGridId, PropFilter)

        zReturn = zDataSQL

        Return zReturn
    End Function

    Private Sub LoadChartMetaData(ParamArray pId() As String)
        Dim zSQL As String = "SELECT * FROM cv.vwFacilityRatingTrendChartMeta WHERE chartId IN ({{Ids}})"
        zSQL = Replace(zSQL, "{{Ids}}", Join(pId, ","))
        Dim zCmd As New SqlClient.SqlCommand(zSQL)
        Dim zReader As SqlClient.SqlDataReader
        zReader = UtilSQLServer.ExecuteReader(zCmd)
        _Meta = New DataTable
        _Meta.Load(zReader)
        zReader.Close()
    End Sub

    Private Sub LoadFacilityRatingTrendingDriver()

        'Get the sourceid from the chart id
        Dim zC As rowTblMetaChart = TblMetaChart.LoadByPrimaryKey(PropChartId)
        PropSourceId = zC.colFldSourceId

        'Set EZUserId from GSafe
        PropEZUserId = CInt(UtilGSafe.GetValue(PropSafeGUID, UtilGSafe.KeyName.EzyUserId))

        'Set UtilSQLMaker, sourceid, guid
        Dim zDataMaker As New GRC.Connect.Libraries.CoreLib.UtilSQLMaker(PropChartId, UtilSQLMaker.SQLMetaData.MetaContext.Charts, PropSafeID)

        'Set required parameters
        zDataMaker.Parameters = Me.PropParameters

        'Set the page size configuration
        zDataMaker.Select.Page(PropPageNumber, PropPageSize)

        Dim zFilter As New GRC.Connect.Libraries.CoreLib.UtilFilter

        'Process sort options
        Call zFilter.SetSort(PropSort, zDataMaker)
        PropSortText = zFilter.SortText
        If PropSortText.Length > 0 Then _SortField = zFilter.mSortData(0).SortField
        If PropSortText.ToLower().Contains("ascending") Then _SortDirection = "ASC"
        If PropSortText.ToLower().Contains("descending") Then _SortDirection = "DESC"

        'Process filter options
        Call zFilter.SetFilter(PropFilter, zDataMaker)
        PropFilterText = zFilter.FilterText

        'If we have filter information that produces sql changes AND criteria information that produces sql changes, then we must put a SQL AND in the middle
        If NeedAnd() Then zDataMaker.Where.AndOperator()

        'Process criteria options
        Call zFilter.SetFilter(PropCriteria, zDataMaker)
        PropCriteriaText = zFilter.FilterText

        'generate sql
        Dim zDataSQL As String = zDataMaker.GenerateSQL("LoadFacilityRatingTrendingDriver", PropSafeGUID, PropEZUserId, PropFilter & " - " & PropCriteria)
        Dim zCmd As SqlClient.SqlCommand
        zCmd = New SqlClient.SqlCommand(zDataSQL)

        'execute sql
        Dim zReader As SqlClient.SqlDataReader = UtilSQLServer.ExecuteReader(zCmd)

        'process data into return structure
        _Driver = New DataTable
        _Driver.Load(zReader)
        If _Driver.Rows.Count > 0 Then PropDriverCount = _Driver.Rows.Count
        zReader.Close()

        'Set the total count
        Dim zCountMaker As New GRC.Connect.Libraries.CoreLib.UtilSQLMaker(PropChartId, UtilSQLMaker.SQLMetaData.MetaContext.Charts, PropSafeID)
        zCountMaker.Select.Count()

        'Set paramters
        zCountMaker.Parameters = Me.PropParameters

        zFilter = New GRC.Connect.Libraries.CoreLib.UtilFilter

        'Process filter options
        Call zFilter.SetFilter(PropFilter, zCountMaker)

        'If we have filter information that produces sql changes AND criteria information that produces sql changes, then we must put a SQL AND in the middle
        If NeedAnd() Then zCountMaker.Where.AndOperator()

        'Process criteria options
        Call zFilter.SetFilter(PropCriteria, zCountMaker)

        Dim zCountSQL As String = zCountMaker.GenerateSQL("LoadFacilityRatingTrendingDriverCount", PropSafeGUID, PropEZUserId, PropFilter)
        zCmd = New SqlClient.SqlCommand(zCountSQL)
        _TotalCount = UtilSQLServer.ExecuteScalar(zCmd)

    End Sub

    Private Sub LoadFacilityRatingTrendingData()
        If PropDriverCount > 0 Then
            Dim zSQL As String
            Dim zArrFileNo() As String
            Dim zSize As Integer = _Driver.Rows.Count - 1
            ReDim zArrFileNo(zSize)

            For i = 0 To zSize
                zArrFileNo(i) = "'" & _Driver.Rows(i).Item("FileNo") & "'"
            Next
            zSQL = "SELECT * FROM {{_FRTsourceView}} WHERE FileNo IN ({{zArrFileNo}}) ORDER BY {{_SortField}} {{_SortDirection}}, FileNo, fldOrdinal"
            zSQL = Replace(zSQL, "{{_FRTsourceView}}", _FRTsourceView)
            zSQL = Replace(zSQL, "{{zArrFileNo}}", Join(zArrFileNo, ","))
            zSQL = Replace(zSQL, "{{_SortField}}", _SortField)
            zSQL = Replace(zSQL, "{{_SortDirection}}", _SortDirection)
            Dim zCmd As New SqlClient.SqlCommand(zSQL)
            Dim zReader As SqlClient.SqlDataReader
            zReader = UtilSQLServer.ExecuteReader(zCmd)
            _Data = New DataTable
            _Data.Load(zReader)
            zReader.Close()
        End If
    End Sub

    Public Function GetFacilityRatingTrendDict(pBlank As Boolean) As Dictionary(Of String, Object)
        Dim zDoc As New Dictionary(Of String, Object)
        Dim zLocs As New List(Of Object)
        Dim zLoc As Dictionary(Of String, Object)
        Dim zTrendingReportMode = TrendingReportMode.None

        ' IDs FOR TOTALS TRENDING REPORT 
        Dim zActiveChartId As Integer = 0
        Dim zPassiveChartId As Integer = 0
        Dim zTotalChartId As Integer = 0

        ' IDs FOR FIRE PASSIVE TRENDING REPORT
        Dim zFirePassiveFloodChartId As Integer = 0
        Dim zFirePassiveEarthquakeChartId As Integer = 0
        Dim zFirePassiveWindChartId As Integer = 0
        Dim zFirePassiveConstructionChartId As Integer = 0
        Dim zFirePassiveOccupancyChartId As Integer = 0
        Dim zFirePassiveOtherExposureChartId As Integer = 0

        ' IDs FOR FIRE ACTIVE TRENDING REPORT
        Dim zFireActiveProtectionChartId As Integer = 0
        Dim zFireActiveHumanChartId As Integer = 0
        Dim zFireActiveNatHazChartId As Integer = 0
        Dim zFireActiveBusinessChartId As Integer = 0

        ' IDs FOR BOILER PASSIVE TRENDING REPORT
        Dim zBMPassiveMechChartId As Integer = 0
        Dim zBMPassiveElecChartId As Integer = 0
        Dim zBMPassivePressureChartId As Integer = 0
        Dim zBMPassiveProductionChartId As Integer = 0
        Dim zBMPassiveOccupancyChartId As Integer = 0
        Dim zBMPassiveComputerChartId As Integer = 0

        ' IDs FOR BOILER ACTIVE TRENDING REPORT
        Dim zBMActiveMechChartId As Integer = 0
        Dim zBMActiveElecChartId As Integer = 0
        Dim zBMActiveSparesChartId As Integer = 0
        Dim zBMActiveHumanChartId As Integer = 0
        Dim zBMActiveBusinessChartId As Integer = 0


        ' **** TO DO: ADD TO CASE SELECT HERE FOR ALL DIFFERENT CHART TYPE VARIABLES NEEDED
        'Build the custom header here
        Select Case PropChartId
            Case UtilMeta.GetMetaKey("FireFacilityRatingTrendActive", 61)
                ' FIRE TOTALS TRENDING REPORT
                zTrendingReportMode = TrendingReportMode.FireFacilityRatingTrend
                _FRTsourceView = "cv.vwFireFacilityRatingTrending"
                zActiveChartId = UtilMeta.GetMetaKey("FireFacilityRatingTrendActive", 61)
                zPassiveChartId = UtilMeta.GetMetaKey("FireFacilityRatingTrendPassive", 62)
                zTotalChartId = UtilMeta.GetMetaKey("FireFacilityRatingTrendTotal", 63)
            Case UtilMeta.GetMetaKey("BMFacilityRatingTrendActive", 64)
                ' BM TOTALS TRENDING REPORT 
                zTrendingReportMode = TrendingReportMode.BMFacilityRatingTrend
                _FRTsourceView = "cv.vwBMFacilityRatingTrending"
                zActiveChartId = UtilMeta.GetMetaKey("BMFacilityRatingTrendActive", 64)
                zPassiveChartId = UtilMeta.GetMetaKey("BMFacilityRatingTrendPassive", 65)
                zTotalChartId = UtilMeta.GetMetaKey("BMFacilityRatingTrendTotal", 66)
            Case UtilMeta.GetMetaKey("FireTrendPassiveFlood", 88),
                UtilMeta.GetMetaKey("FireTrendPassiveEarthquake", 89),
                UtilMeta.GetMetaKey("FireTrendPassiveWind", 90),
                UtilMeta.GetMetaKey("FireTrendPassiveConstruction", 91),
                UtilMeta.GetMetaKey("FireTrendPassiveOccupancy", 92),
                UtilMeta.GetMetaKey("FireTrendPassiveOtherExposure", 93)
                ' FIRE PASSIVE TRENDING REPORT 
                zTrendingReportMode = TrendingReportMode.FireTrendingPassive
                _FRTsourceView = "cv.vwFireTrendingPassive"
                zFirePassiveFloodChartId = UtilMeta.GetMetaKey("FireTrendPassiveFlood", 88)
                zFirePassiveEarthquakeChartId = UtilMeta.GetMetaKey("FireTrendPassiveEarthquake", 89)
                zFirePassiveWindChartId = UtilMeta.GetMetaKey("FireTrendPassiveWind", 90)
                zFirePassiveConstructionChartId = UtilMeta.GetMetaKey("FireTrendPassiveConstruction", 91)
                zFirePassiveOccupancyChartId = UtilMeta.GetMetaKey("FireTrendPassiveOccupancy", 92)
                zFirePassiveOtherExposureChartId = UtilMeta.GetMetaKey("FireTrendPassiveOtherExposure", 93)
            Case UtilMeta.GetMetaKey("FireTrendActiveProtection", 94),
                UtilMeta.GetMetaKey("FireTrendActiveHuman", 95),
                UtilMeta.GetMetaKey("FireTrendActiveNatHaz", 96),
                UtilMeta.GetMetaKey("FireTrendActiveBusiness", 97)
                ' FIRE ACTIVE TRENDING REPORT 
                zTrendingReportMode = TrendingReportMode.FireTrendingActive
                _FRTsourceView = "cv.vwFireTrendingActive"
                zFireActiveProtectionChartId = UtilMeta.GetMetaKey("FireTrendActiveProtection", 94)
                zFireActiveHumanChartId = UtilMeta.GetMetaKey("FireTrendActiveHuman", 95)
                zFireActiveNatHazChartId = UtilMeta.GetMetaKey("FireTrendActiveNatHaz", 96)
                zFireActiveBusinessChartId = UtilMeta.GetMetaKey("FireTrendActiveBusiness", 97)
            Case UtilMeta.GetMetaKey("BMTrendPassiveMech", 98),
                UtilMeta.GetMetaKey("BMTrendPassiveElec", 99),
                UtilMeta.GetMetaKey("BMTrendPassivePressure", 100),
                UtilMeta.GetMetaKey("BMTrendPassiveProduction", 101),
                UtilMeta.GetMetaKey("BMTrendPassiveOccupancy", 102),
                UtilMeta.GetMetaKey("BMTrendPassiveComputer", 103)
                ' BOILER PASSIVE TRENDING REPORT 
                zTrendingReportMode = TrendingReportMode.BMTrendingPassive
                _FRTsourceView = "cv.vwBMTrendingPassive"
                zBMPassiveMechChartId = UtilMeta.GetMetaKey("BMTrendPassiveMech", 98)
                zBMPassiveElecChartId = UtilMeta.GetMetaKey("BMTrendPassiveElec", 99)
                zBMPassivePressureChartId = UtilMeta.GetMetaKey("BMTrendPassivePressure", 100)
                zBMPassiveProductionChartId = UtilMeta.GetMetaKey("BMTrendPassiveProduction", 101)
                zBMPassiveOccupancyChartId = UtilMeta.GetMetaKey("BMTrendPassiveOccupancy", 102)
                zBMPassiveComputerChartId = UtilMeta.GetMetaKey("BMTrendPassiveComputer", 103)
            Case UtilMeta.GetMetaKey("BMTrendActiveMech", 104),
                UtilMeta.GetMetaKey("BMTrendActiveElec", 105),
                UtilMeta.GetMetaKey("BMTrendActiveSpares", 106),
                UtilMeta.GetMetaKey("BMTrendActiveHuman", 107),
                UtilMeta.GetMetaKey("BMTrendActiveBusiness", 108)
                ' BOILER ACTIVE TRENDING REPORT 
                zTrendingReportMode = TrendingReportMode.BMTrendingActive
                _FRTsourceView = "cv.vwBMTrendingActive"
                zBMActiveMechChartId = UtilMeta.GetMetaKey("BMTrendActiveMech", 104)
                zBMActiveElecChartId = UtilMeta.GetMetaKey("BMTrendActiveElec", 105)
                zBMActiveSparesChartId = UtilMeta.GetMetaKey("BMTrendActiveSpares", 106)
                zBMActiveHumanChartId = UtilMeta.GetMetaKey("BMTrendActiveHuman", 107)
                zBMActiveBusinessChartId = UtilMeta.GetMetaKey("BMTrendActiveBusiness", 108)
        End Select

        'Read the meta
        ' **** TO DO: ADD ALL ADDITIONAL CHART ID VARIABLES TO THIS CALL
        Call LoadChartMetaData(zActiveChartId,
            zPassiveChartId,
            zTotalChartId,
            zFirePassiveFloodChartId,
            zFirePassiveEarthquakeChartId,
            zFirePassiveWindChartId,
            zFirePassiveConstructionChartId,
            zFirePassiveOccupancyChartId,
            zFirePassiveOtherExposureChartId,
            zFireActiveProtectionChartId,
            zFireActiveHumanChartId,
            zFireActiveNatHazChartId,
            zFireActiveBusinessChartId,
            zBMPassiveMechChartId,
            zBMPassiveElecChartId,
            zBMPassivePressureChartId,
            zBMPassiveProductionChartId,
            zBMPassiveOccupancyChartId,
            zBMPassiveComputerChartId,
            zBMActiveMechChartId,
            zBMActiveElecChartId,
            zBMActiveSparesChartId,
            zBMActiveHumanChartId,
            zBMActiveBusinessChartId)

        'Read and the driver using sql maker
        Call LoadFacilityRatingTrendingDriver()

        'Load the data point using list of locations from the driver
        Call LoadFacilityRatingTrendingData()

        If pBlank Then

            'Begin loop for array of locations
            zLoc = New Dictionary(Of String, Object)
            zLoc.Add("FileNo", Nothing)
            zLoc.Add("ClientLocNo", Nothing)
            zLoc.Add("Division", Nothing)
            zLoc.Add("Facility", Nothing)
            zLoc.Add("City", Nothing)
            zLoc.Add("StProv", Nothing)
            zLoc.Add("Country", Nothing)
            zLoc.Add("Address", Nothing)
            zLoc.Add("TIV", Nothing)
            Select Case zTrendingReportMode
                Case TrendingReportMode.FireFacilityRatingTrend,
                    TrendingReportMode.BMFacilityRatingTrend
                    zLoc.Add("ActiveData", BuildLevel_Chart(True, zActiveChartId, ""))
                    zLoc.Add("PassiveData", BuildLevel_Chart(True, zPassiveChartId, ""))
                    zLoc.Add("TotalData", BuildLevel_Chart(True, zTotalChartId, ""))
                Case TrendingReportMode.FireTrendingPassive
                    zLoc.Add("FloodData", BuildLevel_Chart(True, zFirePassiveFloodChartId, ""))
                    zLoc.Add("EarthquakeData", BuildLevel_Chart(True, zFirePassiveEarthquakeChartId, ""))
                    zLoc.Add("WindData", BuildLevel_Chart(True, zFirePassiveWindChartId, ""))
                    zLoc.Add("ConstructionData", BuildLevel_Chart(True, zFirePassiveConstructionChartId, ""))
                    zLoc.Add("OccupancyData", BuildLevel_Chart(True, zFirePassiveOccupancyChartId, ""))
                    zLoc.Add("OtherExposureData", BuildLevel_Chart(True, zFirePassiveOtherExposureChartId, ""))
                Case TrendingReportMode.FireTrendingActive
                    zLoc.Add("ProtectionData", BuildLevel_Chart(True, zFireActiveProtectionChartId, ""))
                    zLoc.Add("HumanData", BuildLevel_Chart(True, zFireActiveHumanChartId, ""))
                    zLoc.Add("NatHazData", BuildLevel_Chart(True, zFireActiveNatHazChartId, ""))
                    zLoc.Add("BusinessData", BuildLevel_Chart(True, zFireActiveBusinessChartId, ""))
                Case TrendingReportMode.BMTrendingPassive
                    zLoc.Add("MechData", BuildLevel_Chart(True, zBMPassiveMechChartId, ""))
                    zLoc.Add("ElecData", BuildLevel_Chart(True, zBMPassiveElecChartId, ""))
                    zLoc.Add("PressureData", BuildLevel_Chart(True, zBMPassivePressureChartId, ""))
                    zLoc.Add("ProductionData", BuildLevel_Chart(True, zBMPassiveProductionChartId, ""))
                    zLoc.Add("OccupancyData", BuildLevel_Chart(True, zBMPassiveOccupancyChartId, ""))
                    zLoc.Add("ComputerData", BuildLevel_Chart(True, zBMPassiveComputerChartId, ""))
                Case TrendingReportMode.BMTrendingActive
                    zLoc.Add("MechData", BuildLevel_Chart(True, zBMActiveMechChartId, ""))
                    zLoc.Add("ElecData", BuildLevel_Chart(True, zBMActiveElecChartId, ""))
                    zLoc.Add("SparesData", BuildLevel_Chart(True, zBMActiveSparesChartId, ""))
                    zLoc.Add("HumanData", BuildLevel_Chart(True, zBMActiveHumanChartId, ""))
                    zLoc.Add("BusinessData", BuildLevel_Chart(True, zBMActiveBusinessChartId, ""))
            End Select


            zLocs.Add(zLoc)
            'End loop

            'Document data object
            zDoc.Add("TotalLocations", Nothing)
            zDoc.Add("Locations", zLocs)

        Else

            'Begin loop for array of locations
            Dim zLastFileNo As String = ""
            Dim zCurrFileNo As String = ""

            For Each zRow As DataRow In _Driver.Rows
                zCurrFileNo = zRow("FileNo").ToString
                If zLastFileNo <> zCurrFileNo Then
                    zLoc = New Dictionary(Of String, Object)
                    zLoc.Add("FileNo", zRow("FileNo").ToString)
                    zLoc.Add("ClientLocNo", zRow("ClientLocNo").ToString)
                    zLoc.Add("Division", zRow("Division").ToString)
                    zLoc.Add("Facility", zRow("Facility").ToString)
                    zLoc.Add("City", zRow("City").ToString)
                    zLoc.Add("StProv", zRow("StProv").ToString)
                    zLoc.Add("Country", zRow("Country").ToString)
                    zLoc.Add("Address", zRow("Address").ToString)
                    zLoc.Add("TIV", zRow("TIV"))
                    Select Case zTrendingReportMode
                        Case TrendingReportMode.FireFacilityRatingTrend,
                            TrendingReportMode.BMFacilityRatingTrend
                            zLoc.Add("ActiveData", BuildLevel_Chart(False, zActiveChartId, zRow("FileNo").ToString))
                            zLoc.Add("PassiveData", BuildLevel_Chart(False, zPassiveChartId, zRow("FileNo").ToString))
                            zLoc.Add("TotalData", BuildLevel_Chart(False, zTotalChartId, zRow("FileNo").ToString))
                        Case TrendingReportMode.FireTrendingPassive
                            zLoc.Add("FloodData", BuildLevel_Chart(False, zFirePassiveFloodChartId, zRow("FileNo").ToString))
                            zLoc.Add("EarthquakeData", BuildLevel_Chart(False, zFirePassiveEarthquakeChartId, zRow("FileNo").ToString))
                            zLoc.Add("WindData", BuildLevel_Chart(False, zFirePassiveWindChartId, zRow("FileNo").ToString))
                            zLoc.Add("ConstructionData", BuildLevel_Chart(False, zFirePassiveConstructionChartId, zRow("FileNo").ToString))
                            zLoc.Add("OccupancyData", BuildLevel_Chart(False, zFirePassiveOccupancyChartId, zRow("FileNo").ToString))
                            zLoc.Add("OtherExposureData", BuildLevel_Chart(False, zFirePassiveOtherExposureChartId, zRow("FileNo").ToString))
                        Case TrendingReportMode.FireTrendingActive
                            zLoc.Add("ProtectionData", BuildLevel_Chart(False, zFireActiveProtectionChartId, zRow("FileNo").ToString))
                            zLoc.Add("HumanData", BuildLevel_Chart(False, zFireActiveHumanChartId, zRow("FileNo").ToString))
                            zLoc.Add("NatHazData", BuildLevel_Chart(False, zFireActiveNatHazChartId, zRow("FileNo").ToString))
                            zLoc.Add("BusinessData", BuildLevel_Chart(False, zFireActiveBusinessChartId, zRow("FileNo").ToString))
                        Case TrendingReportMode.BMTrendingPassive
                            zLoc.Add("MechData", BuildLevel_Chart(False, zBMPassiveMechChartId, zRow("FileNo").ToString))
                            zLoc.Add("ElecData", BuildLevel_Chart(False, zBMPassiveElecChartId, zRow("FileNo").ToString))
                            zLoc.Add("PressureData", BuildLevel_Chart(False, zBMPassivePressureChartId, zRow("FileNo").ToString))
                            zLoc.Add("ProductionData", BuildLevel_Chart(False, zBMPassiveProductionChartId, zRow("FileNo").ToString))
                            zLoc.Add("OccupancyData", BuildLevel_Chart(False, zBMPassiveOccupancyChartId, zRow("FileNo").ToString))
                            zLoc.Add("ComputerData", BuildLevel_Chart(False, zBMPassiveComputerChartId, zRow("FileNo").ToString))
                        Case TrendingReportMode.BMTrendingActive
                            zLoc.Add("MechData", BuildLevel_Chart(False, zBMActiveMechChartId, zRow("FileNo").ToString))
                            zLoc.Add("ElecData", BuildLevel_Chart(False, zBMActiveElecChartId, zRow("FileNo").ToString))
                            zLoc.Add("SparesData", BuildLevel_Chart(False, zBMActiveSparesChartId, zRow("FileNo").ToString))
                            zLoc.Add("HumanData", BuildLevel_Chart(False, zBMActiveHumanChartId, zRow("FileNo").ToString))
                            zLoc.Add("BusinessData", BuildLevel_Chart(False, zBMActiveBusinessChartId, zRow("FileNo").ToString))
                    End Select

                    zLocs.Add(zLoc)
                    zLastFileNo = zCurrFileNo
                End If
            Next
            'End loop

            'Document data object
            zDoc.Add("TotalLocations", _TotalCount)
            zDoc.Add("Locations", zLocs)

        End If

        Return zDoc
    End Function

    Private Function CalcAggregate(pFileNo As String, pChartId As Integer, pAggregate As String) As Double
        Dim zRef As Double = 0
        Dim zColumnName As String = ""

        ' **** TO DO: ADD TO CASE SELECT HERE FOR ALL DIFFERENT CHART TYPES NEEDED
        Select Case pChartId
            Case UtilMeta.GetMetaKey("FireFacilityRatingTrendActive", 61), UtilMeta.GetMetaKey("BMFacilityRatingTrendActive", 64)
                zColumnName = "ActiveScore"
            Case UtilMeta.GetMetaKey("FireFacilityRatingTrendPassive", 62), UtilMeta.GetMetaKey("BMFacilityRatingTrendPassive", 65)
                zColumnName = "PassiveScore"
            Case UtilMeta.GetMetaKey("FireTrendPassiveFlood", 88)
                zColumnName = "Flood"
            Case UtilMeta.GetMetaKey("FireTrendPassiveEarthquake", 89)
                zColumnName = "Earthquake"
            Case UtilMeta.GetMetaKey("FireTrendPassiveWind", 90)
                zColumnName = "Wind"
            Case UtilMeta.GetMetaKey("FireTrendPassiveConstruction", 91)
                zColumnName = "Construction"
            Case UtilMeta.GetMetaKey("FireTrendPassiveOccupancy", 92)
                zColumnName = "Occupancy"
            Case UtilMeta.GetMetaKey("FireTrendPassiveOtherExposure", 93)
                zColumnName = "OtherExposure"
            Case UtilMeta.GetMetaKey("FireTrendActiveProtection", 94)
                zColumnName = "Protection"
            Case UtilMeta.GetMetaKey("FireTrendActiveHuman", 95)
                zColumnName = "Human"
            Case UtilMeta.GetMetaKey("FireTrendActiveNatHaz", 96)
                zColumnName = "NatHaz"
            Case UtilMeta.GetMetaKey("FireTrendActiveBusiness", 97)
                zColumnName = "Business"
            Case UtilMeta.GetMetaKey("BMTrendPassiveMech", 98)
                zColumnName = "Mech"
            Case UtilMeta.GetMetaKey("BMTrendPassiveElec", 99)
                zColumnName = "Elec"
            Case UtilMeta.GetMetaKey("BMTrendPassivePressure", 100)
                zColumnName = "Pressure"
            Case UtilMeta.GetMetaKey("BMTrendPassiveProduction", 101)
                zColumnName = "Production"
            Case UtilMeta.GetMetaKey("BMTrendPassiveOccupancy", 102)
                zColumnName = "Occupancy"
            Case UtilMeta.GetMetaKey("BMTrendPassiveComputer", 103)
                zColumnName = "Computer"
            Case UtilMeta.GetMetaKey("BMTrendActiveMech", 104)
                zColumnName = "Mech"
            Case UtilMeta.GetMetaKey("BMTrendActiveElec", 105)
                zColumnName = "Elec"
            Case UtilMeta.GetMetaKey("BMTrendActiveSpares", 106)
                zColumnName = "Spares"
            Case UtilMeta.GetMetaKey("BMTrendActiveHuman", 107)
                zColumnName = "Human"
            Case UtilMeta.GetMetaKey("BMTrendActiveBusiness", 108)
                zColumnName = "Business"
            Case Else
                zColumnName = "TotalScore"
        End Select

        For Each zRow As DataRow In _Data.Rows
            If pFileNo = zRow("FileNo").ToString Then
                If zRef = 0 Then zRef = zRow(zColumnName) 'Prime the value to the first item read from data values
                Select Case pAggregate
                    Case "Max"
                        If zRef < zRow(zColumnName) Then
                            zRef = zRow(zColumnName)
                        End If
                    Case "Min"
                        If zRef > zRow(zColumnName) Then
                            zRef = zRow(zColumnName)
                        End If
                End Select
            End If
        Next

        Return zRef
    End Function

    Private Function BuildLevel_Chart(pBlank As Boolean, pChartId As Integer, pFileNo As String) As Dictionary(Of String, Object)
        Dim zPlotBands As New List(Of Object)
        Dim zChart As Dictionary(Of String, Object)
        'Call BuildLevel_Series multiple times if needed

        If pBlank Then

            zChart = New Dictionary(Of String, Object)
            zChart.Add("transitions", Nothing)
            zChart.Add("fldPlotBands", zPlotBands)
            zChart.Add("fldTitleChart", Nothing)
            zChart.Add("fldTitleValueAxis", Nothing)
            zChart.Add("fldTitleLocation", Nothing)
            zChart.Add("fldValueAxisMin", Nothing)
            zChart.Add("fldValueAxisMax", Nothing)
            zChart.Add("series", BuildLevel_Series(True, pChartId, ""))

        Else
            Dim zMetaRow As DataRow = Nothing
            zChart = New Dictionary(Of String, Object)

            For Each zRow As DataRow In _Meta.Rows
                If zRow("chartId") = pChartId Then
                    zMetaRow = zRow
                End If
            Next

            For Each zRow As DataRow In _Data.Rows
                If pFileNo = zRow("FileNo").ToString Then
                    zChart = New Dictionary(Of String, Object)
                    zChart.Add("transitions", True)
                    zChart.Add("fldPlotBands", zPlotBands)
                    zChart.Add("fldTitleChart", zMetaRow("fldTitleChart").ToString)
                    zChart.Add("fldTitleValueAxis", zMetaRow("fldTitleValueAxis").ToString)
                    zChart.Add("fldTitleLocation", zRow("FileNo").ToString)
                    zChart.Add("fldValueAxisMin", CalcAggregate(zRow("FileNo").ToString, pChartId, "Min") - 20)     'Add offset value MINUS 20 FROM LOWEST
                    zChart.Add("fldValueAxisMax", CalcAggregate(zRow("FileNo").ToString, pChartId, "Max") + 5)      'Add offset value PLUS 5 TO HIGHEST
                    zChart.Add("series", BuildLevel_Series(False, pChartId, zRow("FileNo").ToString))
                End If
            Next

        End If

        Return zChart
    End Function

    Private Function BuildLevel_Series(pBlank As Boolean, pChartId As Integer, pFileNo As String) As List(Of Object)
        Dim zMarker As Dictionary(Of String, Object)
        Dim zSeriesList As New List(Of Object)
        Dim zSeriesSetting As Dictionary(Of String, Object)
        'build a series object for charts

        'Call BuildLevel_Data multiple times if needed

        If pBlank Then

            zMarker = New Dictionary(Of String, Object)
            zMarker.Add("visible", Nothing)
            zMarker.Add("background", Nothing)
            zMarker.Add("type", Nothing)
            zMarker.Add("size", Nothing)

            'Begin loop for series settings
            zSeriesSetting = New Dictionary(Of String, Object)
            zSeriesSetting.Add("name", Nothing)
            zSeriesSetting.Add("type", Nothing)
            zSeriesSetting.Add("field", Nothing)
            zSeriesSetting.Add("categoryField", Nothing)
            zSeriesSetting.Add("colorField", Nothing)
            zSeriesSetting.Add("color", Nothing)
            zSeriesSetting.Add("markers", zMarker)
            zSeriesSetting.Add("data", BuildLevel_Data(True, pChartId, pFileNo, ""))
            zSeriesList.Add(zSeriesSetting)
            'End loop for series settings

        Else
            Dim zMetaRow As DataRow = Nothing
            For Each zRow As DataRow In _Meta.Rows
                If zRow("chartId") = pChartId Then
                    zMetaRow = zRow
                End If
            Next

            zMarker = New Dictionary(Of String, Object)
            zMarker.Add("visible", zMetaRow("markersVisible"))
            zMarker.Add("background", zMetaRow("markersBackground").ToString)
            zMarker.Add("type", zMetaRow("markersType").ToString)
            zMarker.Add("size", zMetaRow("markersSize"))

            'Begin loop for series settings
            zSeriesSetting = New Dictionary(Of String, Object)
            zSeriesSetting.Add("name", zMetaRow("seriesName").ToString)
            zSeriesSetting.Add("type", zMetaRow("seriesType").ToString)
            zSeriesSetting.Add("field", zMetaRow("seriesField").ToString)
            zSeriesSetting.Add("categoryField", zMetaRow("seriesCategoryField").ToString)
            zSeriesSetting.Add("colorField", zMetaRow("seriesColorField").ToString)
            zSeriesSetting.Add("color", zMetaRow("seriesColor").ToString)
            zSeriesSetting.Add("markers", zMarker)
            zSeriesSetting.Add("data", BuildLevel_Data(False, pChartId, pFileNo, zMetaRow("seriesColor").ToString))
            zSeriesList.Add(zSeriesSetting)
            'End loop for series settings

        End If

        Return zSeriesList
    End Function

    Private Function BuildLevel_Data(pBlank As Boolean, pChartId As Integer, pFileNo As String, pColor As String) As List(Of Object)
        Dim zDataList As New List(Of Object)
        Dim zDataPoint As Dictionary(Of String, Object)

        'build a series object for charts
        If pBlank Then

            'Begin loop for data points
            zDataPoint = New Dictionary(Of String, Object)
            zDataPoint.Add("fldOrdinal", Nothing)
            zDataPoint.Add("FileNo", Nothing)
            zDataPoint.Add("ActiveScore", Nothing)
            zDataPoint.Add("fldYear", Nothing)
            zDataPoint.Add("fldColor", Nothing)
            zDataPoint.Add("fldToolTip", Nothing)
            zDataList.Add(zDataPoint)
            'End loop for data points

        Else

            'Execute the data pull query for our filtered record set

            'loop the data set creating a data point for each below
            'Begin loop for data points
            For Each zRow As DataRow In _Data.Rows
                If pFileNo = zRow("FileNo").ToString Then
                    zDataPoint = New Dictionary(Of String, Object)
                    zDataPoint.Add("fldOrdinal", zRow("fldOrdinal"))
                    zDataPoint.Add("FileNo", zRow("FileNo").ToString)

                    ' **** TO DO: ADD TO CASE SELECT HERE FOR ALL DIFFERENT CHART TYPES NEEDED
                    Select Case pChartId
                        Case UtilMeta.GetMetaKey("FireFacilityRatingTrendActive", 61), UtilMeta.GetMetaKey("BMFacilityRatingTrendActive", 64)
                            zDataPoint.Add("ActiveScore", zRow("ActiveScore"))
                        Case UtilMeta.GetMetaKey("FireFacilityRatingTrendPassive", 62), UtilMeta.GetMetaKey("BMFacilityRatingTrendPassive", 65)
                            zDataPoint.Add("PassiveScore", zRow("PassiveScore"))
                        Case UtilMeta.GetMetaKey("FireTrendPassiveFlood", 88)
                            zDataPoint.Add("Flood", zRow("Flood"))
                        Case UtilMeta.GetMetaKey("FireTrendPassiveEarthquake", 89)
                            zDataPoint.Add("Earthquake", zRow("Earthquake"))
                        Case UtilMeta.GetMetaKey("FireTrendPassiveWind", 90)
                            zDataPoint.Add("Wind", zRow("Wind"))
                        Case UtilMeta.GetMetaKey("FireTrendPassiveConstruction", 91)
                            zDataPoint.Add("Construction", zRow("Construction"))
                        Case UtilMeta.GetMetaKey("FireTrendPassiveOccupancy", 92)
                            zDataPoint.Add("Occupancy", zRow("Occupancy"))
                        Case UtilMeta.GetMetaKey("FireTrendPassiveOtherExposure", 93)
                            zDataPoint.Add("OtherExposure", zRow("OtherExposure"))
                        Case UtilMeta.GetMetaKey("FireTrendActiveProtection", 94)
                            zDataPoint.Add("Protection", zRow("Protection"))
                        Case UtilMeta.GetMetaKey("FireTrendActiveHuman", 95)
                            zDataPoint.Add("Human", zRow("Human"))
                        Case UtilMeta.GetMetaKey("FireTrendActiveNatHaz", 96)
                            zDataPoint.Add("NatHaz", zRow("NatHaz"))
                        Case UtilMeta.GetMetaKey("FireTrendActiveBusiness", 97)
                            zDataPoint.Add("Business", zRow("Business"))
                        Case UtilMeta.GetMetaKey("BMTrendPassiveMech", 98)
                            zDataPoint.Add("Mech", zRow("Mech"))
                        Case UtilMeta.GetMetaKey("BMTrendPassiveElec", 99)
                            zDataPoint.Add("Elec", zRow("Elec"))
                        Case UtilMeta.GetMetaKey("BMTrendPassivePressure", 100)
                            zDataPoint.Add("Pressure", zRow("Pressure"))
                        Case UtilMeta.GetMetaKey("BMTrendPassiveProduction", 101)
                            zDataPoint.Add("Production", zRow("Production"))
                        Case UtilMeta.GetMetaKey("BMTrendPassiveOccupancy", 102)
                            zDataPoint.Add("Occupancy", zRow("Occupancy"))
                        Case UtilMeta.GetMetaKey("BMTrendPassiveComputer", 103)
                            zDataPoint.Add("Computer", zRow("Computer"))
                        Case UtilMeta.GetMetaKey("BMTrendActiveMech", 104)
                            zDataPoint.Add("Mech", zRow("Mech"))
                        Case UtilMeta.GetMetaKey("BMTrendActiveElec", 105)
                            zDataPoint.Add("Elec", zRow("Elec"))
                        Case UtilMeta.GetMetaKey("BMTrendActiveSpares", 106)
                            zDataPoint.Add("Spares", zRow("Spares"))
                        Case UtilMeta.GetMetaKey("BMTrendActiveHuman", 107)
                            zDataPoint.Add("Human", zRow("Human"))
                        Case UtilMeta.GetMetaKey("BMTrendActiveBusiness", 108)
                            zDataPoint.Add("Business", zRow("Business"))
                        Case Else
                            zDataPoint.Add("TotalScore", zRow("TotalScore"))
                    End Select

                    zDataPoint.Add("InspectionDate", zRow("InspectionDate").ToString)
                    zDataPoint.Add("fldYear", zRow("fldYear").ToString)
                    zDataPoint.Add("fldColor", pColor)
                    zDataPoint.Add("fldToolTip", zRow("fldToolTip").ToString)
                    zDataList.Add(zDataPoint)
                End If
            Next
            'End loop for data points

        End If

        Return zDataList
    End Function

    Public Function GetChartData(Optional pBatchSetID As Integer = 0) As Dictionary(Of String, Object)
        Dim zReturn As Dictionary(Of String, Object)
        Dim zDictChartData As New List(Of Object)
        Dim zDictChartDataItem As Dictionary(Of String, Object)
        Dim zDictChartSeries As New List(Of Object)
        Dim zDictChartSeriesItem As Dictionary(Of String, Object)
        Dim zDictChartPlotBands As New List(Of Object)
        Dim zDictChartPlotBandItem As Dictionary(Of String, Object)

        Dim zGRCAverages As String = ""
        Dim zGRCAveragesWeighted As String = ""
        Dim zGRCAveragesAchievable As String = ""
        Dim zGRCAveragesAchievableWeighted As String = ""
        Dim zClientAverages As String = ""
        Dim zClientAveragesWeighted As String = ""
        Dim zClientAveragesAchievable As String = ""
        Dim zClientAveragesAchievableWeighted As String = ""
        Dim zDivisionAverages As String = ""
        Dim zDivisionAveragesWeighted As String = ""
        Dim zDivisionAveragesAchievable As String = ""
        Dim zDivisionAveragesAchievableWeighted As String = ""
        Dim zCustomAccessLabel As String = ""
        Dim zCustomAccessAverages As String = ""
        Dim zCustomAccessAveragesWeighted As String = ""
        Dim zCustomAccessAveragesAchievable As String = ""
        Dim zCustomAccessAveragesAchievableWeighted As String = ""
        Dim zIndustryLabel As String = ""
        Dim zIndustryAverages As String = ""
        Dim zIndustryAveragesWeighted As String = ""
        Dim zIndustryAveragesAchievable As String = ""
        Dim zIndustryAveragesAchievableWeighted As String = ""
        Dim zFilteredAverages As String = ""
        Dim zFilteredAveragesWeighted As String = ""
        Dim zFilteredAveragesAchievable As String = ""
        Dim zFilteredAveragesAchievableWeighted As String = ""

        Dim zMC As rowTblMetaChart = TblMetaChart.LoadByPrimaryKey(PropChartId)

        PropSourceId = zMC.colFldSourceId

        Dim zMS As rowTblMetaSource = TblMetaSource.LoadByPrimaryKey(PropSourceId)

        PropColumnName = zMS.colFldOrderBy

        If IsPropChartIdPagingChart() Then PropPageSize = 10
        If IsPropSourceIdSecondaryRecView() Then PropPageSize = 100 'SETTING TO 100 TO SHOW ALL SECONDARY COUNTS FOR ALL PRIMARY KEYWORDS
        Dim zDT As DataTable = GetChartDataValues(zMC.colFldSummaryMode)

        Dim zCmdMCS As New SqlClient.SqlCommand("SELECT * FROM [VwMetaChartSeriesItem] WHERE fldMetaChartId = @fldMetaChartId")
        zCmdMCS.Parameters.AddWithValue("@fldMetaChartId", PropChartId)
        Dim zListMCS As List(Of rowVwMetaChartSeriesItem) = VwMetaChartSeriesItem.LoadData(zCmdMCS)

        Select Case zMC.colFldSummaryMode
            Case "meta"
                'The meta information is driving source for the chart data values.  (ie: zero values are included)
                For Each zRowMCS As rowVwMetaChartSeriesItem In zListMCS

                    Dim zCmdMCSD As New SqlClient.SqlCommand("SELECT * FROM [tblMetaChartSeriesDetail] WHERE fldMetaChartSeriesId = @fldMetaChartSeriesId")
                    zCmdMCSD.Parameters.AddWithValue("@fldMetaChartSeriesId", zRowMCS.colFldId)
                    Dim zListMCSD As List(Of rowTblMetaChartSeriesDetail) = TblMetaChartSeriesDetail.LoadData(zCmdMCSD)

                    For Each zRowMCSD As rowTblMetaChartSeriesDetail In zListMCSD

                        zDictChartDataItem = New Dictionary(Of String, Object)
                        zDictChartDataItem.Add("fldId", zRowMCSD.colFldId)
                        zDictChartDataItem.Add("fldFieldId", FillReplacer(zRowMCSD.colFldField))
                        zDictChartDataItem.Add("fldTitle", FillReplacer(zRowMCSD.colFldTitle))

                        Dim zValue As Integer = 0
                        For Each zDR As DataRow In zDT.Rows
                            If Not IsDBNull(zDR.Item(0)) Then
                                If IsPropSourceIdSecondaryRecView() And Not String.IsNullOrEmpty(PropSafeGUID) Then
                                    If zDR("SecondaryRecType").ToString() = zRowMCSD.colFldField And zDR.Item("PrimaryRecType").ToString() = UtilGSafe.GetValue(PropSafeGUID, "PrimaryRecTypeFromDrillDown") Then
                                        zValue = zDR.Item("Count")
                                    End If
                                Else
                                    If zDR.Item(0) = zRowMCSD.colFldField Then
                                        zValue = zDR.Item(1)
                                    End If
                                End If
                            End If
                        Next
                        zDictChartDataItem.Add("fldValue", zValue)

                        zDictChartDataItem.Add("fldColor", GetRGBAColor(zRowMCSD.colFldColor))
                        zDictChartDataItem.Add("fldMetaChartDrillDownId", zRowMCSD.colFldMetaChartDrillDownId)
                        zDictChartDataItem.Add("fldMetaChartDrillDownTypeId", zRowMCSD.colFldMetaChartDrillDownTypeId)

                        If zRowMCSD.colFldCustomFeature = "" Then
                            zDictChartDataItem.Add("fldInclude", zRowMCSD.colFldInclude)
                        End If

                        'Based on client custom feature rules certain chart data series detail items may need to be excluded.  Always check the custom
                        'feature setting for the client to verify the data item should be included.
                        If SetInclude(zRowMCSD.colFldInclude, zRowMCSD.colFldCustomFeature) Then
                            zDictChartData.Add(zDictChartDataItem)
                        End If

                    Next

                    zDictChartSeriesItem = New Dictionary(Of String, Object)
                    zDictChartSeriesItem.Add("name", zRowMCS.colName)
                    zDictChartSeriesItem.Add("type", zRowMCS.colFldTypeName)
                    zDictChartSeriesItem.Add("field", zRowMCS.colField)
                    zDictChartSeriesItem.Add("categoryField", zRowMCS.colCategoryField)
                    zDictChartSeriesItem.Add("colorField", zRowMCS.colColorField)
                    zDictChartSeriesItem.Add("color", zRowMCS.colColor)
                    zDictChartSeriesItem.Add("data", zDictChartData)
                    zDictChartSeries.Add(zDictChartSeriesItem)

                Next

            Case "data"
                'The data information is driving source for the chart data values.  (ie: top xx type of charts like facility score)
                For Each zRowMCS As rowVwMetaChartSeriesItem In zListMCS

                    Dim zCmdMCSD As New SqlClient.SqlCommand("SELECT * FROM [tblMetaChartSeriesDetail] WHERE fldMetaChartSeriesId = @fldMetaChartSeriesId")
                    zCmdMCSD.Parameters.AddWithValue("@fldMetaChartSeriesId", zRowMCS.colFldId)
                    Dim zListMCSD As List(Of rowTblMetaChartSeriesDetail) = TblMetaChartSeriesDetail.LoadData(zCmdMCSD)

                    If zListMCSD.Count > 0 Then
                        Dim zSelfId As Integer = 1
                        Dim zValue As Double = 0.0
                        Dim zName As String = ""
                        Dim zFileNo As String = ""
                        Dim zToolTip As String = ""
                        Dim zAchievableScorePercentString As String = ""

                        zDictChartData = New List(Of Object)
                        For Each zDR As DataRow In zDT.Rows
                            zName = zDR.Item(zListMCSD(0).colFldTitle) & ""
                            zValue = zDR.Item(zListMCSD(0).colFldField)
                            If DoesColumnExist(zDR, "FileNo") Then zFileNo = zDR.Item("FileNo") & ""
                            If DoesColumnExist(zDR, "ToolTip") Then zToolTip = zDR.Item("ToolTip") & ""
                            If DoesColumnExist(zDR, "AchievableScorePercentString") Then zAchievableScorePercentString = zDR.Item("AchievableScorePercentString") & ""

                            zDictChartDataItem = New Dictionary(Of String, Object)
                            zDictChartDataItem.Add("fldId", zSelfId)
                            zDictChartDataItem.Add("fldFieldId", zName)
                            zDictChartDataItem.Add("fldTitle", zName)
                            zDictChartDataItem.Add("fldValue", zValue)

                            zDictChartDataItem.Add("InspectionDate", zDR.Item("InspectionDate").ToString & "")
                            zDictChartDataItem.Add("fldColor", GetRGBAColor(zListMCSD(0).colFldColor))
                            zDictChartDataItem.Add("fldMetaChartDrillDownId", zListMCSD(0).colFldMetaChartDrillDownId)
                            zDictChartDataItem.Add("fldMetaChartDrillDownTypeId", zListMCSD(0).colFldMetaChartDrillDownTypeId)
                            zDictChartDataItem.Add("fldFileNo", zFileNo)
                            zDictChartDataItem.Add("fldToolTip", zToolTip)
                            zDictChartDataItem.Add("fldAchievableScorePercentString", zAchievableScorePercentString)
                            zDictChartData.Add(zDictChartDataItem)
                            zSelfId = zSelfId + 1
                        Next
                    End If

                    zDictChartSeriesItem = New Dictionary(Of String, Object)
                    zDictChartSeriesItem.Add("name", zRowMCS.colName)
                    zDictChartSeriesItem.Add("type", zRowMCS.colFldTypeName)
                    zDictChartSeriesItem.Add("field", zRowMCS.colField)
                    zDictChartSeriesItem.Add("categoryField", zRowMCS.colCategoryField)
                    zDictChartSeriesItem.Add("colorField", zRowMCS.colColorField)
                    zDictChartSeriesItem.Add("color", zRowMCS.colColor)
                    zDictChartSeriesItem.Add("data", zDictChartData)
                    zDictChartSeriesItem.Add("total", PropDataCount)
                    zDictChartSeries.Add(zDictChartSeriesItem)

                Next

                Dim zClients As List(Of rowTblClients) = TblClients.LoadByIDX_PK_clients(GetFilePrefix())
                Dim zRatingKeyId As Integer = 1
                '
                If PropChartId = UtilMeta.GetMetaKey("FireBenchmarkRatingTotalFacilityScore", 4) Or _
                    PropChartId = UtilMeta.GetMetaKey("FireBenchmarkRatingTotalFacilityScoreByLocation", 57) Then
                    zRatingKeyId = zClients(0).colFireRatingKeyID
                    If Not String.IsNullOrEmpty(zClients(0).colFeatures) AndAlso UtilCustomFeature.Contains(zClients(0).colFeatures, UtilCustomFeature.Letter.U) Then
                        Dim zDTU As DataTable
                        If PropChartId = UtilMeta.GetMetaKey("FireBenchmarkRatingTotalFacilityScore", 4) Then

                            If pBatchSetID > 0 Then
                                zDTU = UtilRating.GetTotalClientFireScoreAverages(pBatchSetID, UtilRating.LocListKeyId.BatchSetId)
                            Else
                                zDTU = UtilRating.GetTotalClientFireScoreAverages(UtilGSafe.GetValue(PropSafeGUID, UtilGSafe.KeyName.SafeGUID), UtilRating.LocListKeyId.GSafeId)
                            End If

                            If zDTU.Rows.Count > 0 Then
                                zClientAverages = zDTU.Rows(0).Item("fldValue1")
                                zClientAveragesWeighted = zDTU.Rows(0).Item("fldValue2")
                                zClientAveragesAchievable = zDTU.Rows(0).Item("fldValue3")
                                zClientAveragesAchievableWeighted = zDTU.Rows(0).Item("fldValue4")

                                zGRCAverages = zDTU.Rows(1).Item("fldValue1")
                                zGRCAveragesWeighted = zDTU.Rows(1).Item("fldValue2")
                                zGRCAveragesAchievable = zDTU.Rows(1).Item("fldValue3")
                                zGRCAveragesAchievableWeighted = zDTU.Rows(1).Item("fldValue4")

                                zFilteredAverages = zDTU.Rows(2).Item("fldValue1")
                                zFilteredAveragesWeighted = zDTU.Rows(2).Item("fldValue2")
                                zFilteredAveragesAchievable = zDTU.Rows(2).Item("fldValue3")
                                zFilteredAveragesAchievableWeighted = zDTU.Rows(2).Item("fldValue4")
                            End If

                        End If
                        If PropChartId = UtilMeta.GetMetaKey("FireBenchmarkRatingTotalFacilityScoreByLocation", 57) Then
                            zDTU = UtilRating.GetTotaFirelFacilityScoreAverages(UtilGSafe.GetValue(PropSafeGUID, UtilGSafe.KeyName.FileNo))
                            If zDTU.Rows.Count > 0 Then
                                zClientAverages = zDTU.Rows(0).Item("fldValue1")
                                zClientAveragesWeighted = zDTU.Rows(0).Item("fldValue2")
                                zClientAveragesAchievable = zDTU.Rows(0).Item("fldValue3")
                                zClientAveragesAchievableWeighted = zDTU.Rows(0).Item("fldValue4")

                                zDivisionAverages = zDTU.Rows(1).Item("fldValue1")
                                zDivisionAveragesWeighted = zDTU.Rows(1).Item("fldValue2")
                                zDivisionAveragesAchievable = zDTU.Rows(1).Item("fldValue3")
                                zDivisionAveragesAchievableWeighted = zDTU.Rows(1).Item("fldValue4")

                                zCustomAccessLabel = zDTU.Rows(2).Item("fldLabel")
                                zCustomAccessAverages = zDTU.Rows(2).Item("fldValue1")
                                zCustomAccessAveragesWeighted = zDTU.Rows(2).Item("fldValue2")
                                zCustomAccessAveragesAchievable = zDTU.Rows(2).Item("fldValue3")
                                zCustomAccessAveragesAchievableWeighted = zDTU.Rows(2).Item("fldValue4")

                                zGRCAverages = zDTU.Rows(3).Item("fldValue1")
                                zGRCAveragesWeighted = zDTU.Rows(3).Item("fldValue2")
                                zGRCAveragesAchievable = zDTU.Rows(3).Item("fldValue3")
                                zGRCAveragesAchievableWeighted = zDTU.Rows(3).Item("fldValue4")

                                zIndustryLabel = zDTU.Rows(4).Item("fldLabel")
                                zIndustryAverages = zDTU.Rows(4).Item("fldValue1")
                                zIndustryAveragesWeighted = zDTU.Rows(4).Item("fldValue2")
                                zIndustryAveragesAchievable = zDTU.Rows(4).Item("fldValue3")
                                zIndustryAveragesAchievableWeighted = zDTU.Rows(4).Item("fldValue4")
                            End If
                        End If
                    Else
                        zGRCAverages = GetAverage("GRC", "gv.vwFireFacilityRatingExtractSelect", "TotalScore")
                        zClientAverages = GetAverage("Client", "gv.vwFireFacilityRatingExtractSelect", "TotalScore")
                        zFilteredAverages = GetAverage("Filtered", "gv.vwFireFacilityRatingExtractSelect", "TotalScore", pBatchSetID)  ''Was changed to Filtered Average instead of Division
                    End If
                Else
                    zRatingKeyId = zClients(0).colBMRatingKeyID
                    zGRCAverages = GetAverage("GRC", "gv.vwBMFacilityRatingExtractSelect", "TotalScoreCurrent")
                    zClientAverages = GetAverage("Client", "gv.vwBMFacilityRatingExtractSelect", "TotalScoreCurrent")
                    zFilteredAverages = GetAverage("Filtered", "gv.vwBMFacilityRatingExtractSelect", "TotalScoreCurrent", pBatchSetID)  ''Was changed to Filtered Average instead of Division
                End If

                Dim zRatings As List(Of rowTblMetaRatingKeyRange) = TblMetaRatingKeyRange.LoadByIDX_IX_fldKeyId(zRatingKeyId)

                For Each zRating As rowTblMetaRatingKeyRange In zRatings
                    zDictChartPlotBandItem = New Dictionary(Of String, Object)
                    zDictChartPlotBandItem.Add("from", zRating.colFldScoreLow)
                    zDictChartPlotBandItem.Add("to", zRating.colFldScoreHigh)
                    zDictChartPlotBandItem.Add("color", GetHexColor(zRating.colFldMetaColorId))
                    zDictChartPlotBandItem.Add("opacity", 0.8)
                    zDictChartPlotBandItem.Add("title", zRating.colFldDescription)
                    zDictChartPlotBands.Add(zDictChartPlotBandItem)
                Next

        End Select

        Dim zDoc As New Dictionary(Of String, Object)
        zDoc.Add("transitions", True)
        zDoc.Add("fldId", zMC.colFldId)
        zDoc.Add("fldTitlePage", zMC.colFldTitlePage)
        zDoc.Add("fldTitlePageSub", zMC.colFldTitlePageSub)
        zDoc.Add("fldTitleChart", zMC.colFldTitleChart)
        zDoc.Add("fldTitleValueAxis", zMC.colFldTitleValueAxis)
        zDoc.Add("series", zDictChartSeries)
        zDoc.Add("fldPlotBands", zDictChartPlotBands)

        zDoc.Add("fldGRCAverages", zGRCAverages)
        zDoc.Add("fldGRCAveragesWeighted", zGRCAveragesWeighted)
        zDoc.Add("fldGRCAveragesAchievable", zGRCAveragesAchievable)
        zDoc.Add("fldGRCAveragesAchievableWeighted", zGRCAveragesAchievableWeighted)

        zDoc.Add("fldClientAverages", zClientAverages)
        zDoc.Add("fldClientAveragesWeighted", zClientAveragesWeighted)
        zDoc.Add("fldClientAveragesAchievable", zClientAveragesAchievable)
        zDoc.Add("fldClientAveragesAchievableWeighted", zClientAveragesAchievableWeighted)

        zDoc.Add("fldDivisionAverages", zDivisionAverages)
        zDoc.Add("fldDivisionAveragesWeighted", zDivisionAveragesWeighted)
        zDoc.Add("fldDivisionAveragesAchievable", zDivisionAveragesAchievable)
        zDoc.Add("fldDivisionAveragesAchievableWeighted", zDivisionAveragesAchievableWeighted)

        zDoc.Add("fldCustomAccessLabel", zCustomAccessLabel)
        zDoc.Add("fldCustomAccessAverages", zCustomAccessAverages)
        zDoc.Add("fldCustomAccessAveragesWeighted", zCustomAccessAveragesWeighted)
        zDoc.Add("fldCustomAccessAveragesAchievable", zCustomAccessAveragesAchievable)
        zDoc.Add("fldCustomAccessAveragesAchievableWeighted", zCustomAccessAveragesAchievableWeighted)

        zDoc.Add("fldIndustryLabel", zIndustryLabel)
        zDoc.Add("fldIndustryAverages", zIndustryAverages)
        zDoc.Add("fldIndustryAveragesWeighted", zIndustryAveragesWeighted)
        zDoc.Add("fldIndustryAveragesAchievable", zIndustryAveragesAchievable)
        zDoc.Add("fldIndustryAveragesAchievableWeighted", zIndustryAveragesAchievableWeighted)

        zDoc.Add("fldFilteredAverages", zFilteredAverages)
        zDoc.Add("fldFilteredAveragesWeighted", zFilteredAveragesWeighted)
        zDoc.Add("fldFilteredAveragesAchievable", zFilteredAveragesAchievable)
        zDoc.Add("fldFilteredAveragesAchievableWeighted", zFilteredAveragesAchievableWeighted)

        zReturn = zDoc

        'serialize to json
        Dim zJSON As String = Newtonsoft.Json.JsonConvert.SerializeObject(zReturn)

        Return zReturn

    End Function

    Private Function IsPropSourceIdSecondaryRecView() As Boolean
        If PropSourceId = _VWBMSECONDARYSOURCEID Then Return True
        If PropSourceId = _VWFIRESECONDARYSOURCEID Then Return True
        If PropSourceId = _VWIRSECONDARYSOURCEID Then Return True
        If PropSourceId = _VWNATHAZFLOODSECONDARYSOURCEID Then Return True
        If PropSourceId = _VWNATHAZSEISMICCONDARYSOURCEID Then Return True
        If PropSourceId = _VWNATHAZWINDSECONDARYSOURCEID Then Return True
        If PropSourceId = _VWNHFLOODSECONDARYSOURCEID Then Return True
        If PropSourceId = _VWNHSEISMICCONDARYSOURCEID Then Return True
        If PropSourceId = _VWNHWINDSECONDARYSOURCEID Then Return True
        Return False
    End Function

    Private Function IsPropChartIdPagingChart() As Boolean
        If PropChartId = _FIREBENCHMARKRATINGTOTALFACILITYSCORE Then Return True
        If PropChartId = _BOILERBENCHMARKRATINGTOTALFACILITYSCORE Then Return True
        If PropChartId = _FIREBENCHMARKRATINGTOTALFACILITYSCOREBYLOCATION Then Return True
        If PropChartId = _BOILERBENCHMARKRATINGTOTALFACILITYSCOREBYLOCATION Then Return True
        If PropChartId = _FIREFACILITYACHIEVABLERISKIMPROVEMENT Then Return True
        If PropChartId = _BMFACILITYACHIEVABLERISKIMPROVEMENT Then Return True
        Return False
    End Function

    Private Function SetInclude(pInclude As Boolean, pChartSeriesDetailFeature As String) As Boolean
        Dim zClientFeature As String = ""

        If Not pChartSeriesDetailFeature Is Nothing Then
            If pChartSeriesDetailFeature.Length > 0 Then
                Dim zFilePrefix As String = GetFilePrefix()
                Dim zRC As List(Of rowTblClients) = TblClients.LoadByIDX_PK_clients(zFilePrefix)
                If zRC.Count > 0 Then
                    zClientFeature = zRC(0).colFeatures
                End If

                If Not String.IsNullOrEmpty(zClientFeature) Then
                    Dim zChartSeriesDetailFeatureNdx As Integer = 0
                    For zChartSeriesDetailFeatureNdx = 1 To pChartSeriesDetailFeature.Length
                        Dim zClientFeatureNdx As Integer = 0
                        For zClientFeatureNdx = 1 To zClientFeature.Length
                            If pChartSeriesDetailFeature.Substring(zChartSeriesDetailFeatureNdx - 1, 1) = zClientFeature.Substring(zClientFeatureNdx - 1, 1) Then
                                Return Not pInclude  'Flip the Include property if the custom feature matches.
                            End If
                        Next
                    Next
                End If
            End If
        End If

        Return pInclude
    End Function

    Private Function DoesColumnExist(pDR As DataRow, pColumnName As String) As Boolean
        Dim zReturn As Boolean = False

        Try
            Dim zResult As Object = pDR.Item(pColumnName)
            zReturn = True
        Catch ex As Exception
            'Eat the exception the column does not exist
        End Try

        Return zReturn
    End Function

    Private Function GetAverage(pMode As String, pView As String, pColumn As String, Optional pBatchSetID As Integer = 0) As Integer
        Dim zReturn As Integer = 0
        Dim zCmd As New SqlClient.SqlCommand
        Dim zBatchSetJoin As String = ""
        '
        Select Case pMode
            Case "GRC"
                zCmd.CommandText = "SELECT AVG(vw." & pColumn & ") FROM " & pView & " vw WHERE InspProgramYear LIKE '%Latest Ratings%';"
            Case "Filtered"

                If pBatchSetID > 0 Then
                    ''WHEN RUNNING IN BATCH MODE WE NEED TO LINK UP TO THE TBLBATCHPROCESSINGFILENO TO GET THE AVERAGE.
                    zCmd.CommandText = "SELECT AVG(vw." & pColumn & ") FROM " & pView & _
                    " vw INNER JOIN tblBatchProcessingFileNo fn ON fn.FldFileNo=vw.FileNo WHERE fldSetID=@SetID AND InspProgramYear LIKE '%Latest Ratings%';"
                    zCmd.Parameters.AddWithValue("@SetID", pBatchSetID)
                Else
                    If PropParameters.Country.Length > 0 And PropParameters.Country <> "%" Then
                        Dim zGSafeId As Integer = UtilGSafe.GetId(PropSafeGUID)
                        zCmd.CommandText = "SELECT AVG(vw." & pColumn & ") FROM " & pView & _
                        " vw INNER JOIN GSafeFileNo fn ON fn.FileNo=vw.FileNo WHERE fn.GSafeID=@GSafeID AND vw.Country = @Country AND InspProgramYear LIKE '%Latest Ratings%';"
                        zCmd.Parameters.AddWithValue("@Country", PropParameters.Country)
                        zCmd.Parameters.AddWithValue("@GSafeID", zGSafeId)
                    ElseIf PropParameters.Division.Length > 0 And PropParameters.Division <> "%" Then
                        Dim zGSafeId As Integer = UtilGSafe.GetId(PropSafeGUID)
                        zCmd.CommandText = "SELECT AVG(vw." & pColumn & ") FROM " & pView & _
                        " vw INNER JOIN GSafeFileNo fn ON fn.FileNo=vw.FileNo WHERE fn.GSafeID=@GSafeID AND vw.Division = @Division AND InspProgramYear LIKE '%Latest Ratings%';"
                        zCmd.Parameters.AddWithValue("@Division", PropParameters.Division)
                        zCmd.Parameters.AddWithValue("@GSafeID", zGSafeId)
                    ElseIf PropParameters.CustomAccess.Length > 0 And PropParameters.CustomAccess <> "%" And PropParameters.CustomAccess.ToLower <> "not used" Then
                        Dim zGSafeId As Integer = UtilGSafe.GetId(PropSafeGUID)
                        zCmd.CommandText = "SELECT AVG(vw." & pColumn & ") FROM " & pView & _
                        " vw INNER JOIN GSafeFileNo fn ON fn.FileNo=vw.FileNo WHERE fn.GSafeID=@GSafeID AND vw.CustomAccess = @CustomAccess AND InspProgramYear LIKE '%Latest Ratings%';"
                        zCmd.Parameters.AddWithValue("@CustomAccess", PropParameters.CustomAccess)
                        zCmd.Parameters.AddWithValue("@GSafeID", zGSafeId)
                    ElseIf PropParameters.TIVValue = TblMetaTIV.TIVRanges.Top10Highest Then
                        Dim zGSafeId As Integer = UtilGSafe.GetId(PropSafeGUID)
                        zCmd.CommandText = "SELECT AVG(vw." & pColumn & ") FROM " & pView & _
                        " vw INNER JOIN GSafeFileNo fn ON fn.FileNo=vw.FileNo INNER JOIN [sv].[vwTopTenTIV] tt ON tt.FileNo=vw.FileNo WHERE fn.GSafeID=@GSafeID AND InspProgramYear LIKE '%Latest Ratings%';"
                        zCmd.Parameters.AddWithValue("@GSafeID", zGSafeId)
                    ElseIf PropParameters.TIVValue = TblMetaTIV.TIVRanges.Greater100Million Or PropParameters.TIVValue = TblMetaTIV.TIVRanges.Greater250Million Or PropParameters.TIVValue = TblMetaTIV.TIVRanges.Greater50Million Then
                        zCmd.CommandText = "SELECT AVG(vw." & pColumn & ") FROM " & pView & _
                      " vw INNER JOIN GSafeFileNo fn ON fn.FileNo=vw.FileNo WHERE fn.GSafeID=@GSafeID AND vw.TIV > @TIV AND InspProgramYear LIKE '%Latest Ratings%';"

                        Dim zGSafeId As Integer = UtilGSafe.GetId(PropSafeGUID)
                        Select Case PropParameters.TIVValue
                            Case TblMetaTIV.TIVRanges.Greater100Million
                                zCmd.Parameters.AddWithValue("@TIV", 100)
                                zCmd.Parameters.AddWithValue("@GSafeID", zGSafeId)
                            Case TblMetaTIV.TIVRanges.Greater250Million
                                zCmd.Parameters.AddWithValue("@TIV", 250)
                                zCmd.Parameters.AddWithValue("@GSafeID", zGSafeId)
                            Case Else
                                zCmd.Parameters.AddWithValue("@TIV", 50)
                                zCmd.Parameters.AddWithValue("@GSafeID", zGSafeId)
                        End Select

                    Else
                        Dim zGSafeId As Integer = UtilGSafe.GetId(PropSafeGUID)
                        zCmd.CommandText = "SELECT AVG(vw." & pColumn & ") FROM " & pView & _
                        " vw INNER JOIN GSafeFileNo fn ON fn.FileNo=vw.FileNo WHERE fn.GSafeID=@GSafeID AND InspProgramYear LIKE '%Latest Ratings%';"

                        zCmd.Parameters.AddWithValue("@GSafeID", zGSafeId)
                    End If
                End If
            Case "Client"

                Dim zFilePrefix As String = GetFilePrefix()
                If zFilePrefix.Length > 0 Then
                    Dim zLocListName As String = "gv.vwFireLocList"
                    If pView.ToLower.Contains("bm") Then zLocListName = "gv.vwBMLocList"

                    zCmd.CommandText = "SELECT AVG(vw." & pColumn & ") FROM " & pView & _
                         " vw INNER JOIN " & zLocListName & " fn ON fn.FileNo=vw.FileNo WHERE FLOOR(vw.FileNo) = @FilePrefix AND InspProgramYear LIKE '%Latest Ratings%';"
                    zCmd.Parameters.AddWithValue("@FilePrefix", zFilePrefix)
                End If

        End Select

        Dim zVal As Object = UtilSQLServer.ExecuteScalar(zCmd)
        If IsDBNull(zVal) Then zReturn = Val(0) Else zReturn = Val(zVal)

        Return zReturn
    End Function

    Private Function GetFilePrefix() As String
        Dim zReturn As String = ""

        If Me.PropSafeGUID.Length > 0 Then
            zReturn = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(Me.PropSafeGUID, UtilGSafe.KeyName.FilePreFix)
        Else
            zReturn = PropParameters.FilePrefix   'Question for Dan B. how do I get this from the Batch Report maker
        End If

        Return zReturn
    End Function

    Public Function GetGridData() As GRC.Connect.Libraries.CoreLib.UtilKendo.DataPackGrid
        Dim zReturn As New GRC.Connect.Libraries.CoreLib.UtilKendo.DataPackGrid

        If PropFavoriteId > 0 Then
            'The PropFavoriteId has a value; load the favorite sort, filter and criteria text to use the in the griddata load below.
            Dim zFav As rowTblGridFavorite = UtilGridFavorite.LoadFavorite(PropFavoriteId)

            If Not zFav Is Nothing Then
                If PropSort Is Nothing Then PropSort = zFav.colFldSortJSON 'only use the favorite sort if a user sort is not available.

                PropFavFilter = zFav.colFldFilterJSON
                PropFavCriteria = zFav.colFldCriteriaJSON
                PropGridId = zFav.colFldGridId
            End If
        End If

        'Get the sourceid from the grid id
        Dim zG As rowTblMetaGrid = TblMetaGrid.LoadByPrimaryKey(PropGridId)
        PropSourceId = zG.colFldSourceId

        'Set EZUserId from GSafe
        PropEZUserId = CInt(UtilGSafe.GetValue(PropSafeGUID, UtilGSafe.KeyName.EzyUserId))

        'Set UtilSQLMaker, sourceid, guid
        Dim zDataMaker As New GRC.Connect.Libraries.CoreLib.UtilSQLMaker(PropGridId, UtilSQLMaker.SQLMetaData.MetaContext.Grids, PropSafeID)

        'Check to see if User is on a location

        Dim zIsOnDetailsPage As Boolean = IIf(UtilGSafe.GetValue(PropSafeGUID, UtilGSafe.KeyName.IsOnDetailPage) = "", False, UtilGSafe.GetValue(PropSafeGUID, UtilGSafe.KeyName.IsOnDetailPage))
        Dim zNavLinkId As String = UtilGSafe.GetValue(PropSafeGUID, UtilGSafe.KeyName.NavLinkId)
        Dim zFileNo As String = UtilGSafe.GetValue(PropSafeGUID, UtilGSafe.KeyName.FileNo)
        If zIsOnDetailsPage Then

            If zNavLinkId = "" Then
                If zFileNo.Length > 0 Then Me.PropParameters.FileNo = zFileNo
            Else
                Dim zNavSlideType As String = UtilNavLink.GetSlideMenuType(Int(zNavLinkId))
                If zNavSlideType = NavLink.SlideMenuTypes.Practice Then
                    If zFileNo.Length > 0 Then Me.PropParameters.FileNo = zFileNo
                End If
            End If
        Else
            If zFileNo.Length > 0 Then Me.PropParameters.FileNo = zFileNo
        End If

        'Set required parameters
        zDataMaker.Parameters = Me.PropParameters

        'Set the page size configuration
        zDataMaker.Select.Page(PropPageNumber, PropPageSize)

        Dim zFilter As New GRC.Connect.Libraries.CoreLib.UtilFilter

        'Process sort options
        Call zFilter.SetSort(PropSort, zDataMaker)
        PropSortText = zFilter.SortText
        zReturn.sort = PropSortText

        If Not PropFavFilter Is Nothing Then
            If PropFavFilter.Length > 0 Then
                'Process fav filter options
                Call zFilter.SetFilter(PropFavFilter, zDataMaker)
                PropFavFilterText = zFilter.FilterText
                zReturn.filter = PropFavFilterText
            End If
        End If

        'If we have filter information that produces sql changes AND criteria information that produces sql changes, then we must put a SQL AND in the middle
        If NeedFavAnd() Then zDataMaker.Where.AndOperator()

        If Not PropFavCriteria Is Nothing Then
            If PropFavCriteria.Length > 0 Then
                'Process fav criteria options
                Call zFilter.SetFilter(PropFavCriteria, zDataMaker)
            End If
        End If

        If NeedAnd(False) And NeedFavAnd(False) Then zDataMaker.Where.AndOperator()

        'Process filter options
        Call zFilter.SetFilter(PropFilter, zDataMaker)
        PropFilterText = zFilter.FilterText

        If PropGridId = UtilMeta.GetMetaKey("FilterPreferences", 84) Then
            Dim zFilePrefix As String = UtilGSafe.GetValue(PropSafeGUID, UtilGSafe.KeyName.FilePreFix)
            Dim zMyPreferenceFilterDescText As String = UtilGSafe.GetValue(PropSafeGUID, zFilePrefix, UtilGSafe.PreferenceKeyName.MyPreferenceFilterDescText)
            PropFilterText = zMyPreferenceFilterDescText & PropFilterText
        End If

        'If we have filter information that produces sql changes AND criteria information that produces sql changes, then we must put a SQL AND in the middle
        If NeedAnd() Then zDataMaker.Where.AndOperator()

        'Process criteria options
        Call zFilter.SetFilter(PropCriteria, zDataMaker)
        PropCriteriaText = zFilter.FilterText

        zReturn.filter = CombineFilterText(PropFavFilterText, PropFilterText)

        If PropGridId = _FAVORITE_GRID_ID Then 'favorite grid
            If NeedAnd(False) Then zDataMaker.Where.AndOperator()
            zDataMaker.Where.Add("fldEzyUserId", UtilSQLMaker.SQLComparisonOperator.Equal, PropEZUserId, "")
        End If

        'generate sql
        Dim zDataSQL As String = zDataMaker.GenerateSQL("GetGridData", PropSafeGUID, PropEZUserId, PropFilter & " - " & PropCriteria)
        If PropGridId = UtilMeta.GetMetaKey("FacilitySearch", 313) Then zDataSQL = zDataSQL.Replace("999999999", CoreLib.UtilGSafe.GetId(PropSafeGUID))
        Dim zCmd As SqlClient.SqlCommand
        zCmd = New SqlClient.SqlCommand(zDataSQL)

        'execute sql
        Dim zReader As SqlClient.SqlDataReader = UtilSQLServer.ExecuteReader(zCmd)

        'process data into return structure
        zReturn.data = New DataTable
        zReturn.data.Load(zReader)
        zReader.Close()

        'Set the total count
        Dim zCountMaker As New GRC.Connect.Libraries.CoreLib.UtilSQLMaker(PropGridId, UtilSQLMaker.SQLMetaData.MetaContext.Grids, PropSafeID)
        zCountMaker.Select.Count()

        'Set paramters
        zCountMaker.Parameters = Me.PropParameters

        zFilter = New GRC.Connect.Libraries.CoreLib.UtilFilter

        If Not PropFavFilter Is Nothing Then
            If PropFavFilter.Length > 0 Then
                'Process fav filter options
                Call zFilter.SetFilter(PropFavFilter, zCountMaker)
            End If
        End If

        'If we have filter information that produces sql changes AND criteria information that produces sql changes, then we must put a SQL AND in the middle
        If NeedFavAnd() Then zCountMaker.Where.AndOperator()

        If Not PropFavCriteria Is Nothing Then
            If PropFavCriteria.Length > 0 Then
                'Process fav criteria options
                Call zFilter.SetFilter(PropFavCriteria, zCountMaker)
            End If
        End If

        If NeedAnd(False) And NeedFavAnd(False) Then zCountMaker.Where.AndOperator()

        'Process filter options
        Call zFilter.SetFilter(PropFilter, zCountMaker)

        'If we have filter information that produces sql changes AND criteria information that produces sql changes, then we must put a SQL AND in the middle
        If NeedAnd() Then zCountMaker.Where.AndOperator()

        'Process criteria options
        Call zFilter.SetFilter(PropCriteria, zCountMaker)

        If PropGridId = UtilMeta.GetMetaKey("FavoritesLibrary", 183) Then 'favorite grid
            If NeedAnd(False) Then zCountMaker.Where.AndOperator()
            zCountMaker.Where.Add("fldEzyUserId", UtilSQLMaker.SQLComparisonOperator.Equal, PropEZUserId, "")
        End If

        Dim zCountSQL As String = zCountMaker.GenerateSQL("GetGridDataCount", PropSafeGUID, PropEZUserId, PropFilter)
        If PropGridId = UtilMeta.GetMetaKey("FacilitySearch", 313) Then zCountSQL = zCountSQL.Replace("999999999", CoreLib.UtilGSafe.GetId(PropSafeGUID))
        zCmd = New SqlClient.SqlCommand(zCountSQL)
        zReturn.total = UtilSQLServer.ExecuteScalar(zCmd)

        'serialize to json
        Dim zJSON As String = Newtonsoft.Json.JsonConvert.SerializeObject(zReturn)

        Return zReturn
    End Function

    Public Function GetFormData() As GRC.Connect.Libraries.CoreLib.UtilKendo.DataPackGrid
        Dim zReturn As New GRC.Connect.Libraries.CoreLib.UtilKendo.DataPackGrid
        Dim zFilePrefix As String = UtilGSafe.GetValue(PropSafeGUID, UtilGSafe.KeyName.FilePreFix)
        Dim zGSafeId As Integer = UtilGSafe.GetId(PropSafeGUID)

        'Get the sourceid from the grid id
        Dim zG As rowTblMetaGrid = TblMetaGrid.LoadByPrimaryKey(PropGridId)
        PropSourceId = zG.colFldSourceId

        'Set EZUserId from GSafe
        PropEZUserId = CInt(UtilGSafe.GetValue(PropSafeGUID, UtilGSafe.KeyName.EzyUserId))

        'Set UtilSQLMaker, sourceid, guid
        Dim zDataMaker As New GRC.Connect.Libraries.CoreLib.UtilSQLMaker(PropGridId, UtilSQLMaker.SQLMetaData.MetaContext.Grids, PropSafeID)

        'Check to see if User is on a location
        Dim zFileNo As String = UtilGSafe.GetValue(PropSafeGUID, UtilGSafe.KeyName.FormFileNo)
        Dim zUniqueId As String = UtilGSafe.GetValue(PropSafeGUID, UtilGSafe.KeyName.FormUniqueId)

        Me.PropParameters.FileNo = zFileNo

        'Set required parameters
        zDataMaker.Parameters = Me.PropParameters

        Dim zFilter As New GRC.Connect.Libraries.CoreLib.UtilFilter

        'Process sort options
        Call zFilter.SetSort(PropSort, zDataMaker)
        PropSortText = zFilter.SortText
        zReturn.sort = PropSortText

        'Process filter options
        Call zFilter.SetFilter(PropFilter, zDataMaker)
        PropFilterText = zFilter.FilterText

        If PropGridId = UtilMeta.GetMetaKey("FilterPreferences", 84) Then
            Dim zMyPreferenceFilterDescText As String = UtilGSafe.GetValue(PropSafeGUID, zFilePrefix, UtilGSafe.PreferenceKeyName.MyPreferenceFilterDescText)
            PropFilterText = zMyPreferenceFilterDescText & PropFilterText
        End If

        'If we have filter information that produces sql changes AND criteria information that produces sql changes, then we must put a SQL AND in the middle
        If NeedAnd() Then zDataMaker.Where.AndOperator()

        'Process criteria options
        Call zFilter.SetFilter(PropCriteria, zDataMaker)
        PropCriteriaText = zFilter.FilterText

        zReturn.filter = CombineFilterText(PropFavFilterText, PropFilterText)

        'Set the FileNo
        If zDataMaker.Where._List.Count > 0 Then zDataMaker.Where.AndOperator()
        zDataMaker.Where.Add("FileNo", UtilSQLMaker.SQLComparisonOperator.Equal, zFileNo, "")

        If Not String.IsNullOrEmpty(zUniqueId) Then
            zDataMaker.Where.AndOperator()
            zDataMaker.Where.Add("UniqueID", UtilSQLMaker.SQLComparisonOperator.Equal, zUniqueId, "")
        End If

        'generate sql
        Dim zDataSQL As String = zDataMaker.GenerateSQL("GetFormData", PropSafeGUID, PropEZUserId, PropFilter & " - " & PropCriteria)
        If PropGridId = UtilMeta.GetMetaKey("FacilitySearch", 313) Then zDataSQL = zDataSQL.Replace("999999999", CoreLib.UtilGSafe.GetId(PropSafeGUID))
        Dim zCmd As SqlClient.SqlCommand
        zCmd = New SqlClient.SqlCommand(zDataSQL)

        'execute sql
        Dim zReader As SqlClient.SqlDataReader = UtilSQLServer.ExecuteReader(zCmd)

        'process data into return structure
        zReturn.data = New DataTable
        zReturn.data.Load(zReader)
        zReader.Close()

        zReturn.total = zReturn.data.Rows.Count

        ' GET THE PREFERENCE CURRENCY STRING
        zReturn.currency = UtilGSafe.GetValue(PropSafeGUID, zFilePrefix, UtilGSafe.PreferenceKeyName.CurrencyDefaultText)

        'FOR INSPECITON STATUS GRIDS ONLY
        Dim zInspectionStatusGrids As New List(Of Integer)({55, 56, 57, 139, 140, 141, 274, 282, 309})
        If zInspectionStatusGrids.Contains(PropGridId) Then
            zReturn.data.Columns.Add("SortOrder", GetType(System.Int32))
            For Each zRow As DataRow In zReturn.data.Rows
                If Not IsDBNull(zRow("inspectionstatus")) AndAlso zRow("inspectionstatus").ToString.ToLower = "pending" Then zRow("SortOrder") = 1
                If Not IsDBNull(zRow("inspectionstatus")) AndAlso zRow("inspectionstatus").ToString.ToLower = "completed" Then zRow("SortOrder") = 2
                If Not IsDBNull(zRow("inspectionstatus")) AndAlso zRow("inspectionstatus").ToString.ToLower = "cancelled" Then zRow("SortOrder") = 3
                If IsDBNull(zRow("inspectionstatus")) Then zRow("SortOrder") = 4
            Next

            Dim zDV As DataView = zReturn.data.AsDataView
            zDV.Sort = "SortOrder, Engineer_Target"
            zReturn.data = zDV.ToTable

        End If

        'serialize to json
        Dim zJSON As String = Newtonsoft.Json.JsonConvert.SerializeObject(zReturn)

        Return zReturn
    End Function

    Private Function GetDefaultDepictedByColumnName(pGridId As Integer) As String
        Dim zReturn As String = ""

        Dim zQ As New queryTblMetaGridColumn

        zQ.SelectAll()
        zQ.Where.And(zQ.colFldMetaGridId.Equals(pGridId))
        zQ.Where.And(zQ.colFldMapDefaultDepicted.Equals(True))

        Dim zList As List(Of rowTblMetaGridColumn)
        zList = TblMetaGridColumn.LoadData(zQ.QueryText)

        For Each zItem As rowTblMetaGridColumn In zList
            zReturn = zItem.colField
        Next

        Return zReturn
    End Function

    Public Function GetMapData() As GRC.Connect.Libraries.CoreLib.UtilKendo.MapDataPackGrid
        Dim zReturn As New GRC.Connect.Libraries.CoreLib.UtilKendo.MapDataPackGrid

        'Get the sourceid from the grid id
        Dim zG As rowTblMetaGrid = TblMetaGrid.LoadByPrimaryKey(PropGridId)
        PropSourceId = zG.colFldSourceId

        'Set EZUserId from GSafe
        PropEZUserId = CInt(UtilGSafe.GetValue(PropSafeGUID, UtilGSafe.KeyName.EzyUserId))

        'Use the default depicted by initially
        Dim zDepictedColumnName As String = GetDefaultDepictedByColumnName(PropGridId)

        'Get the user selected depicted column name
        If PropDepictedByColumnName.Length > 0 Then
            zDepictedColumnName = PropDepictedByColumnName
        End If

        'Set UtilSQLMaker, sourceid, guid
        Dim zDataMaker As New GRC.Connect.Libraries.CoreLib.UtilSQLMaker(PropGridId, GRC.Connect.Libraries.CoreLib.UtilSQLMaker.SQLMetaData.MetaContext.Maps, PropSafeID, zDepictedColumnName)

        zDataMaker.Parameters.FilePrefix = UtilGSafe.GetValue(PropSafeGUID, UtilGSafe.KeyName.FilePreFix)
        zDataMaker.Select.SelectMapFields()

        Dim zFilter As New GRC.Connect.Libraries.CoreLib.UtilFilter

        'Process sort options
        Call zFilter.SetSort(PropSort, zDataMaker)
        PropSortText = zFilter.SortText
        zReturn.sort = PropSortText

        'Process filter options
        Call zFilter.SetFilter(PropFilter, zDataMaker)
        PropFilterText = zFilter.FilterText

        If PropGridId = UtilMeta.GetMetaKey("FilterPreferences", 84) Then
            Dim zFilePrefix As String = UtilGSafe.GetValue(PropSafeGUID, UtilGSafe.KeyName.FilePreFix)
            Dim zMyPreferenceFilterDescText As String = UtilGSafe.GetValue(PropSafeGUID, zFilePrefix, UtilGSafe.PreferenceKeyName.MyPreferenceFilterDescText)
            PropFilterText = zMyPreferenceFilterDescText & PropFilterText
        End If

        'If we have filter information that produces sql changes AND criteria information that produces sql changes, then we must put a SQL AND in the middle
        If NeedAnd() Then zDataMaker.Where.AndOperator()

        'Process criteria options
        Call zFilter.SetFilter(PropCriteria, zDataMaker)
        PropCriteriaText = zFilter.FilterText

        zReturn.filter = PropFilterText

        'generate sql
        Dim zDataSQL As String = zDataMaker.GenerateSQL("GetMapData", PropSafeGUID, PropEZUserId, PropFilter & " - " & PropCriteria)
        If PropGridId = UtilMeta.GetMetaKey("FacilitySearch", 313) Then zDataSQL = zDataSQL.Replace("999999999", CoreLib.UtilGSafe.GetId(PropSafeGUID))
        Dim zCmd As SqlClient.SqlCommand
        zCmd = New SqlClient.SqlCommand(zDataSQL)

        'execute sql
        Dim zReader As SqlClient.SqlDataReader = UtilSQLServer.ExecuteReader(zCmd)

        'process data into return structure
        zReturn.data = New DataTable
        zReturn.data.Load(zReader)
        zReader.Close()

        'get meta
        zCmd = New SqlClient.SqlCommand(UtilMetaMapPin.GetPinMetaDataSQL(zReturn.data))
        zReader = UtilSQLServer.ExecuteReader(zCmd)
        zReturn.meta = New DataTable
        zReturn.meta.Load(zReader)
        zReader.Close()
        zReturn.meta = zReturn.meta.DefaultView.ToTable(True, {"fldId", "fldIcon", "fldBaseString"})  ''only return needed columns

        'Set the total count
        zReturn.total = zReturn.data.Rows.Count

        'serialize to json
        Dim zJSON As String = Newtonsoft.Json.JsonConvert.SerializeObject(zReturn)

        Return zReturn
    End Function

    Public Function GetMapShapeData() As GRC.Connect.Libraries.CoreLib.UtilKendo.MapDataPackGrid
        Dim zReturn As New GRC.Connect.Libraries.CoreLib.UtilKendo.MapDataPackGrid

        'generate sql
        Dim zDatabaseMode = "[cldbConnect]"
        If GRC.Connect.Libraries.CoreLib.UtilSetting.GetAppMode() = GRC.Connect.Libraries.CoreLib.UtilSetting.AppMode.Dev Or GRC.Connect.Libraries.CoreLib.UtilSetting.GetAppMode() = GRC.Connect.Libraries.CoreLib.UtilSetting.AppMode.Test Then
            zDatabaseMode = "[cldbConnect]"
        Else
            zDatabaseMode = "[cldbConnect]"
        End If
        Dim zDataSQL As String = "SELECT NULL AS FileNo,[Latitude],[Longitude],[InputRange] As Radius, '#FF0000' AS RadiusColor, [Units],'pin_epicenter' AS MapPinIcon, '' AS TitleSnippet, 'FileNo' AS DepictedField, '' AS DepictedFieldBackColor, '' AS UniqueFieldName, -1 AS ShowPinText, '' AS PinValue, mp.fldHeight, mp.fldWidth, fldAnchorX, fldAnchorY, fldTextOffsetX, fldTextOffsetY, NULL AS PinText FROM " & zDatabaseMode & ".[dbo].[GSafeFileNoRadiusParms] rp INNER JOIN GSafeHeader h ON h.GSafeId = rp.GSafeId INNER JOIN tblMetaMapPin mp ON mp.fldIcon = 'pin_epicenter' WHERE h.GSafeGUID = @GSafeGUID"
        Dim zCmd As SqlClient.SqlCommand
        zCmd = New SqlClient.SqlCommand(zDataSQL)
        zCmd.Parameters.AddWithValue("@GSafeGUID", PropSafeGUID)

        'execute sql
        Dim zReader As SqlClient.SqlDataReader = UtilSQLServer.ExecuteReader(zCmd)

        'process data into return structure
        zReturn.data = New DataTable
        zReturn.data.Load(zReader)
        zReader.Close()

        'get meta
        zCmd = New SqlClient.SqlCommand(UtilMetaMapPin.GetPinMetaDataSQL(zReturn.data))
        zReader = UtilSQLServer.ExecuteReader(zCmd)
        zReturn.meta = New DataTable
        zReturn.meta.Load(zReader)
        zReader.Close()
        zReturn.meta = zReturn.meta.DefaultView.ToTable(True, {"fldId", "fldIcon", "fldBaseString"})  ''only return needed columns

        'Set the total count
        zReturn.total = zReturn.data.Rows.Count

        'serialize to json
        Dim zJSON As String = Newtonsoft.Json.JsonConvert.SerializeObject(zReturn)

        Return zReturn
    End Function

    Private Function CombineFilterText(p1 As String, p2 As String) As String
        Dim zReturn As String = ""
        Dim zP1 As String = p1 & ""
        Dim zP2 As String = p2 & ""

        'IF THE FILTER IS THE SAME EXACT FILTER, THEN IGNORE COMBINE AND RETURN THE FIRST 1
        If p1.ToLower <> p2.ToLower Then
            If zP1.Length > 0 And zP2.Length > 0 Then
                zReturn = zP1 & " and " & zP2
            Else
                If zP1.Length > 0 Then
                    zReturn = zP1
                Else
                    If zP2.Length > 0 Then
                        zReturn = zP2
                    End If
                End If
            End If
        Else
            zReturn = p1
        End If

        Return zReturn
    End Function

    Private Function GetMetaUnitId_ByCode(pUnitCode As String) As Integer
        Dim zReturn As Integer = 1 'USD
        Dim zUnit As New List(Of rowTblMetaUnitSystem)
        Dim zCmd As SqlClient.SqlCommand
        zCmd = New SqlClient.SqlCommand("SELECT TOP 1 * FROM tblMetaUnitSystem WHERE fldName = @fldCode")
        zCmd.Parameters.AddWithValue("@fldCode", pUnitCode)
        zUnit = TblMetaUnitSystem.LoadData(zCmd)
        zReturn = zUnit(0).colFldId.GetValueOrDefault(1)

        Return zReturn
    End Function

    Private Function GetMetaCurrencyId_ByCode(pCurrencyCode As String) As Integer
        Dim zReturn As Integer = 1 'USD
        Dim zCurr As New List(Of rowTblMetaCurrency)
        Dim zCmd As SqlClient.SqlCommand
        zCmd = New SqlClient.SqlCommand("SELECT TOP 1 * FROM tblMetaCurrency WHERE fldCode = @fldCode")
        zCmd.Parameters.AddWithValue("@fldCode", pCurrencyCode)
        zCurr = TblMetaCurrency.LoadData(zCmd)
        zReturn = zCurr(0).colFldId.GetValueOrDefault(1)

        Return zReturn
    End Function

    Public Function GetValueList() As DataTable
        'Set the PropGridId, PropColumnName, PropSafeGUID before calling this function.  Return DataTable
        Dim zReturn As DataTable

        'Get the sourceid from the grid id
        Dim zG As rowTblMetaGrid = TblMetaGrid.LoadByPrimaryKey(PropGridId)
        PropSourceId = zG.colFldSourceId

        'Set EZUserId from GSafe
        PropEZUserId = CInt(UtilGSafe.GetValue(PropSafeGUID, UtilGSafe.KeyName.EzyUserId))

        'Set UtilSQLMaker, sourceid, guid
        Dim zMaker As New GRC.Connect.Libraries.CoreLib.UtilSQLMaker(PropGridId, UtilSQLMaker.SQLMetaData.MetaContext.Grids, PropSafeID)
        zMaker.Select.Count(PropColumnName)

        'Set required parameters
        zMaker.Parameters = Me.PropParameters

        'Process filter options
        Dim zFilter As New GRC.Connect.Libraries.CoreLib.UtilFilter
        Call zFilter.SetFilter(PropFilter, zMaker)
        PropFilterText = zFilter.FilterText

        'If we have filter information that produces sql changes AND criteria information that produces sql changes, then we must put a SQL AND in the middle
        If NeedAnd() Then zMaker.Where.AndOperator()

        'Process criteria options
        Call zFilter.SetFilter(PropCriteria, zMaker)
        PropCriteriaText = zFilter.FilterText

        'generate sql
        Dim zSQL As String = zMaker.GenerateSQL("GetValueList", PropSafeGUID, PropEZUserId, PropFilter & " - " & PropCriteria)

        Dim zCmd As New SqlClient.SqlCommand(zSQL)
        'execute sql
        Dim zReader As SqlClient.SqlDataReader = UtilSQLServer.ExecuteReader(zCmd)

        'process data into return structure
        zReturn = New DataTable
        zReturn.Load(zReader)
        zReader.Close()

        Return zReturn
    End Function

    Private Function GetChartDataValues(pSummaryMode As String) As DataTable
        'Set the PropSourceId, PropColumnName, PropSafeGUID before calling this function.  Return DataTable
        Dim zReturn As DataTable

        'Set UtilSQLMaker, sourceid, guid
        Dim zMaker As GRC.Connect.Libraries.CoreLib.UtilSQLMaker
        Dim zCountMaker As GRC.Connect.Libraries.CoreLib.UtilSQLMaker

        If PropReportSetId > 0 Then
            zMaker = New GRC.Connect.Libraries.CoreLib.UtilSQLMaker(PropReportId, UtilSQLMaker.SQLMetaData.MetaContext.Reports, PropReportSetId)
            zCountMaker = New GRC.Connect.Libraries.CoreLib.UtilSQLMaker(PropReportId, UtilSQLMaker.SQLMetaData.MetaContext.Reports, PropReportSetId)
        Else
            'PropEZUserId = CInt(UtilGSafe.GetValue(PropSafeGUID, UtilGSafe.KeyName.EzyUserId))
            Me.PropParameters.FilePrefix = UtilGSafe.GetValue(PropSafeGUID, UtilGSafe.KeyName.FilePreFix)
            zMaker = New GRC.Connect.Libraries.CoreLib.UtilSQLMaker(PropChartId, UtilSQLMaker.SQLMetaData.MetaContext.Charts, PropSafeID)
            zCountMaker = New GRC.Connect.Libraries.CoreLib.UtilSQLMaker(PropChartId, UtilSQLMaker.SQLMetaData.MetaContext.Charts, PropSafeID)
        End If

        zCountMaker.Select.Count()

        If PropPageSize > 0 Then
            'Set the page size configuration
            zMaker.Select.Page(PropPageNumber, PropPageSize)
        End If

        Select Case pSummaryMode
            Case "data"
                'FireTotalFacilityRatingChart
            Case Else  ' "meta"
                'Primary and Secondary Rec Type charts
                zMaker.Select.Count(PropColumnName)
                If IsPropSourceIdSecondaryRecView() Then
                    zMaker.Select.Add("PrimaryRecType")
                End If
        End Select

        'Set required parameters
        zMaker.Parameters = PropParameters
        zCountMaker.Parameters = PropParameters

        'Process filter and sort options
        Dim zFilter As New GRC.Connect.Libraries.CoreLib.UtilFilter
        Call zFilter.SetSort(PropSort, zMaker)
        Call zFilter.SetFilter(PropFilter, zMaker)
        PropFilterText = zFilter.FilterText

        Dim zCountFilter As New GRC.Connect.Libraries.CoreLib.UtilFilter
        Call zCountFilter.SetFilter(PropFilter, zCountMaker)

        'If we have filter information that produces sql changes AND criteria information that produces sql changes, then we must put a SQL AND in the middle
        If NeedAnd() Then zMaker.Where.AndOperator()
        If NeedAnd() Then zCountMaker.Where.AndOperator()

        'Process criteria options
        Call zFilter.SetFilter(PropCriteria, zMaker)
        PropCriteriaText = zFilter.FilterText
        Call zCountFilter.SetFilter(PropCriteria, zCountMaker)

        'generate sql
        Dim zSQL As String = zMaker.GenerateSQL("GetChartDataValues", PropSafeGUID, PropEZUserId, PropFilter + " - " + PropCriteria)

        Dim zCmd As New SqlClient.SqlCommand(zSQL)
        'execute sql
        Dim zReader As SqlClient.SqlDataReader = UtilSQLServer.ExecuteReader(zCmd)

        'process data into return structure
        zReturn = New DataTable
        zReturn.Load(zReader)
        zReader.Close()

        'Build total data count
        Dim zCountSQL As String = zCountMaker.GenerateSQL("GetChartDataValuesCount", PropSafeGUID, PropEZUserId, PropFilter + " - " + PropCriteria)
        zCmd = New SqlClient.SqlCommand(zCountSQL)
        PropDataCount = UtilSQLServer.ExecuteScalar(zCmd)

        Return zReturn
    End Function

    Private Function NeedFavAnd(Optional pBoth As Boolean = True) As Boolean
        'If we have filter information that produces sql changes AND criteria information that produces sql changes, then we must put a SQL AND in the middle
        Dim zReturn As Boolean = False
        Dim zSM As New GRC.Connect.Libraries.CoreLib.UtilSQLMaker() ' GRC.Connect.Libraries.CoreLib.UtilSQLMaker(1, UtilSQLMaker.SQLMetaData.MetaContext.Grids, "")
        Dim zFilter As New GRC.Connect.Libraries.CoreLib.UtilFilter

        If pBoth Then
            If zFilter.SetFilter(PropFavFilter, zSM) > 0 And zFilter.SetFilter(PropFavCriteria, zSM) > 0 Then
                zReturn = True
            End If
        Else
            If zFilter.SetFilter(PropFavFilter, zSM) > 0 Or zFilter.SetFilter(PropFavCriteria, zSM) > 0 Then
                zReturn = True
            End If
        End If

        Return zReturn
    End Function

    Private Function NeedAnd(Optional pBoth As Boolean = True) As Boolean
        'If we have filter information that produces sql changes AND criteria information that produces sql changes, then we must put a SQL AND in the middle
        Dim zReturn As Boolean = False
        Dim zSM As New GRC.Connect.Libraries.CoreLib.UtilSQLMaker() ' GRC.Connect.Libraries.CoreLib.UtilSQLMaker(1, UtilSQLMaker.SQLMetaData.MetaContext.Grids, "")
        Dim zFilter As New GRC.Connect.Libraries.CoreLib.UtilFilter

        If pBoth Then
            If zFilter.SetFilter(PropFilter, zSM) > 0 And zFilter.SetFilter(PropCriteria, zSM) > 0 Then
                zReturn = True
            End If
        Else
            If zFilter.SetFilter(PropFilter, zSM) > 0 Or zFilter.SetFilter(PropCriteria, zSM) > 0 Then
                zReturn = True
            End If
        End If

        Return zReturn
    End Function

    Public Function GetPickFormData() As GRC.Connect.Libraries.CoreLib.UtilKendo.DataPackGrid
        Dim zReturn As New GRC.Connect.Libraries.CoreLib.UtilKendo.DataPackGrid

        'Get the sourceid from the grid id
        Dim zG As rowTblMetaGrid = TblMetaGrid.LoadByPrimaryKey(PropGridId)
        PropSourceId = zG.colFldSourceId

        'Set EZUserId from GSafe
        PropEZUserId = CInt(UtilGSafe.GetValue(PropSafeGUID, UtilGSafe.KeyName.EzyUserId))

        'Set UtilSQLMaker, sourceid, guid
        Dim zMaker As New GRC.Connect.Libraries.CoreLib.UtilSQLMaker(PropGridId, UtilSQLMaker.SQLMetaData.MetaContext.Grids, PropSafeID)
        zMaker.Select.Count(PropColumnName)

        'Set required parameters
        zMaker.Parameters = Me.PropParameters
        If String.IsNullOrEmpty(zMaker.Parameters.FilePrefix) Then zMaker.Parameters.FilePrefix = UtilGSafe.GetValue(PropSafeGUID, UtilGSafe.KeyName.FilePreFix)

        'Process filter options
        Dim zFilter As New GRC.Connect.Libraries.CoreLib.UtilFilter
        Call zFilter.SetFilter(PropFilter, zMaker)
        PropFilterText = zFilter.FilterText

        'generate sql
        Dim zSQL As String = zMaker.GenerateSQL("GetPickFormData", PropSafeGUID, PropEZUserId, PropFilter)

        Dim zCmd As New SqlClient.SqlCommand(zSQL)
        'execute sql
        Dim zReader As SqlClient.SqlDataReader = UtilSQLServer.ExecuteReader(zCmd)

        'process data into return structure
        zReturn.data = New DataTable
        zReturn.data.Load(zReader)
        zReader.Close()

        'Set the total count
        zReturn.total = zReturn.data.Rows.Count

        'serialize to json for testing
        'Dim zJSON As String = Newtonsoft.Json.JsonConvert.SerializeObject(zReturn)

        Return zReturn
    End Function

    Public Function GetPickListData() As Dictionary(Of String, Object)
        Dim zReturn As New Dictionary(Of String, Object)

        'Get the sourceid from the grid id
        Dim zG As rowTblMetaGrid = TblMetaGrid.LoadByPrimaryKey(PropGridId)
        PropSourceId = zG.colFldSourceId

        'Set EZUserId from GSafe
        PropEZUserId = CInt(UtilGSafe.GetValue(PropSafeGUID, UtilGSafe.KeyName.EzyUserId))

        'Set UtilSQLMaker, sourceid, guid
        Dim zMaker As New GRC.Connect.Libraries.CoreLib.UtilSQLMaker(PropGridId, UtilSQLMaker.SQLMetaData.MetaContext.Grids, PropSafeID)
        zMaker.Select.Count(PropColumnName)

        'Set required parameters
        zMaker.Parameters = Me.PropParameters
        If String.IsNullOrEmpty(zMaker.Parameters.FilePrefix) Then zMaker.Parameters.FilePrefix = UtilGSafe.GetValue(PropSafeGUID, UtilGSafe.KeyName.FilePreFix)

        'Process filter options
        Dim zFilter As New GRC.Connect.Libraries.CoreLib.UtilFilter
        Call zFilter.SetFilter(PropFilter, zMaker)

        'If we have filter information that produces sql changes AND criteria information that produces sql changes, then we must put a SQL AND in the middle
        If NeedAnd() Then zMaker.Where.AndOperator()

        'Process criteria options
        Call zFilter.SetFilter(PropCriteria, zMaker)

        'generate sql
        Dim zSQL As String = zMaker.GenerateSQL("GetPickListData", PropSafeGUID, PropEZUserId, PropFilter)
        If PropGridId = UtilMeta.GetMetaKey("FacilitySearch", 313) Then zSQL = zSQL.Replace("999999999", CoreLib.UtilGSafe.GetId(PropSafeGUID))

        Dim zCmd As New SqlClient.SqlCommand(zSQL)
        'execute sql
        Dim zReader As SqlClient.SqlDataReader = UtilSQLServer.ExecuteReader(zCmd)

        'process data into return structure
        Dim zTable As New DataTable
        zTable.Load(zReader)
        zReader.Close()

        'SET THE DATA FOR THE PICK LIST
        Dim zData As New List(Of String)
        For Each zRow In zTable.Rows
            zData.Add(zRow.ItemArray(0) & "")
        Next

        ' GET THE DATA TYPE
        Dim zType As String = "string"
        Dim zColumnTypes As New List(Of rowTblMetaGridColumnType)
        zColumnTypes = TblMetaGridColumnType.LoadData()
        Dim zMetaColumns As New List(Of rowTblMetaGridColumn)
        'Dim zCmd As New SqlClient.SqlCommand("SELECT TOP 1 [type] FROM tblMetaGridColumn WHERE fldMetaGridId = @fldMetaGridId AND field = @field")
        Dim zCmdMGC As New SqlClient.SqlCommand("SELECT TOP 1 * FROM tblMetaGridColumn WHERE fldMetaGridId = @fldMetaGridId AND field = @field")
        zCmdMGC.Parameters.AddWithValue("@fldMetaGridId", PropSourceId)
        zCmdMGC.Parameters.AddWithValue("@field", PropColumnName)
        zMetaColumns = TblMetaGridColumn.LoadData(zCmdMGC)
        If zMetaColumns.Count > 0 Then
            For Each zItem In zColumnTypes
                If zMetaColumns(0).colType = zItem.colFldId Then
                    zType = zItem.colFldName
                    Exit For
                End If
            Next
        End If

        ' PACKAGE THE JSON
        zReturn.Add("columnName", PropColumnName)
        zReturn.Add("dataType", zType)
        zReturn.Add("data", zData)

        'serialize to json for testing
        'Dim zJSON As String = Newtonsoft.Json.JsonConvert.SerializeObject(zReturn)

        Return zReturn
    End Function

    Private Function GetRGBAAlias(pAlias As String) As String
        Dim zReturn As String = _DEFAULT_JSRGBA

        Dim zRows As List(Of rowTblMetaColorAlias)
        zRows = TblMetaColorAlias.LoadByIDX_IDX_Alias(pAlias)
        If zRows.Count > 0 Then
            zReturn = GetRGBAColor(zRows(0).colFldColorId.Value)
        End If

        Return zReturn
    End Function

    Private Function GetRGBAColor(pColorId As Integer) As String
        Dim zReturn As String = _DEFAULT_JSRGBA

        Dim zRows As List(Of rowTblMetaColor)
        zRows = TblMetaColor.LoadByIDX_PK_tblMetaColor(pColorId)
        If zRows.Count > 0 Then
            zReturn = BuildJSRGBA(zRows(0).colFldR, zRows(0).colFldG, zRows(0).colFldB, zRows(0).colFldA)
        End If

        Return zReturn
    End Function

    Private Function GetHexColor(pColorId As Integer) As String
        Dim zReturn As String = "#FFFFFF"

        Dim zRows As List(Of rowTblMetaColor)
        zRows = TblMetaColor.LoadByIDX_PK_tblMetaColor(pColorId)
        If zRows.Count > 0 Then
            zReturn = zRows(0).colFldHex
        End If

        Return zReturn
    End Function

    Private Function GetRGBAColor(pColor As String) As String
        Dim zReturn As String = _DEFAULT_JSRGBA

        Dim zRows As List(Of rowTblMetaColor)
        zRows = TblMetaColor.LoadByIDX_IDX_Color(pColor)
        If zRows.Count > 0 Then
            zReturn = BuildJSRGBA(zRows(0).colFldR, zRows(0).colFldG, zRows(0).colFldB, zRows(0).colFldA)
        End If

        Return zReturn
    End Function

    Private Function BuildJSRGBA(pRed As Integer, pGreen As Integer, pBlue As Integer, pAlpha As Double) As String
        Dim zReturn As String = ""

        zReturn = "rgba(fldR, fldG, fldB, fldA)"
        zReturn = Replace(zReturn, "fldR", pRed.ToString)
        zReturn = Replace(zReturn, "fldG", pGreen.ToString)
        zReturn = Replace(zReturn, "fldB", pBlue.ToString)
        zReturn = Replace(zReturn, "fldA", pAlpha.ToString)

        Return zReturn
    End Function

    Public Function FillReplacer(pReplacer As String) As String
        Dim zReturn As String = pReplacer
        Dim zKeyWords As String = pReplacer
        Dim zNewValue As String = ""

        Dim zStartPos As Integer = zKeyWords.IndexOf("{{")
        Dim zEndPos As Integer = zKeyWords.IndexOf("}}")

        If zStartPos > -1 And zEndPos > zStartPos Then
            zKeyWords = zKeyWords.Substring(zStartPos, zEndPos - zStartPos + 2)
            'Handle specific replacer cases in the main case block, handle sub cases in the else
            Select Case zKeyWords
                Case Else
                    'Handle replacer sub cases (ie: color, alias, templates)
                    If InStr(zKeyWords, "=") > 0 Then
                        Const _NAME As Integer = 0
                        Const _VALUE As Integer = 1
                        Dim zKeyWordsNoBraces As String = Replace(Replace(zKeyWords, "{{", ""), "}}", "")
                        Dim zParts() As String = Split(zKeyWordsNoBraces, "=")
                        Select Case zParts(_NAME)
                            Case "tblMetaLossEstimate.fldIndexNo"
                                zNewValue = GetMetaLossEstimate_byIndexNo(zParts(_VALUE))
                        End Select
                    End If
            End Select
        End If

        If zNewValue.Length = 0 Then
            zReturn = pReplacer
        Else
            zReturn = Replace(pReplacer, zKeyWords, zNewValue)
        End If

        Return zReturn
    End Function

    Public Function FillReplacerWithValue(pSource As String, pReplacer As String, pValue As String) As String
        Dim zReturn As String = pSource

        If pValue.Length = 0 Then
            zReturn = pSource
        Else
            zReturn = Replace(pSource, pReplacer, pValue)
        End If

        Return zReturn
    End Function

    Private Function GetMetaLossEstimate_byIndexNo(pIndexNo As String) As String
        Dim zReturn As String = ""
        Dim zCurrencyId As Integer = 1

        If Me.PropSafeGUID.Length > 0 Then
            zCurrencyId = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(Me.PropSafeGUID, "ChartPreFilter-Currency")
        Else
            zCurrencyId = Me.PropCurrency
        End If

        Dim zClient As rowTblClients = TblClients.LoadByPrimaryKey(PropParameters.FilePrefix)
        Dim zExchangeRateGroupId As Integer = CInt(zClient.colExchangeRateGroupID)

        Dim zCmd As New SqlClient.SqlCommand("SELECT TOP 1 * FROM tblMetaLossEstimate WHERE fldExchangeRateGroupId = @ExchangeRateGroupId AND fldCurrencyId = @CurrencyId AND fldLossEstimateTypeId = @LossEstimateTypeId AND fldIndexNo = @IndexNo")
        zCmd.Parameters.AddWithValue("@ExchangeRateGroupId", zExchangeRateGroupId)
        zCmd.Parameters.AddWithValue("@CurrencyId", zCurrencyId)
        zCmd.Parameters.AddWithValue("@LossEstimateTypeId", 1)
        zCmd.Parameters.AddWithValue("@IndexNo", pIndexNo)

        Dim zMLE As List(Of rowTblMetaLossEstimate) = TblMetaLossEstimate.LoadData(zCmd)

        If zMLE.Count > 0 Then
            zReturn = zMLE(0).colFldRangeDisplay
        End If
        Return zReturn
    End Function

    Public Sub New()
        PropParameters = New UtilSQLMaker.ParameterInfo
    End Sub
End Class

