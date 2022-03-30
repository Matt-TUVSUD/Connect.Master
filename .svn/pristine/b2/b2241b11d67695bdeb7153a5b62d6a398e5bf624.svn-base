Imports GRC.Connect.Libraries.CoreLib
Imports GRC.Connect.Libraries.DataLib.razor
Imports GRC.Connect.Libraries.WhatIfInterfaceLib
Imports GRC.Connect.Libraries.FilterSortLib
Imports GRC.Excel

Public Class UtilWhatIf

    Private _SafeGUID As String
    Private _SafeID As Integer
    Private _Source As rowTblMetaSource
    Private _GridID As Integer = 328
    Private _Client As IrowTblClients
    Private _FilePrefix As String
    Private _PageSize As Integer = 100

    Public Sub New(pSafeGuid As String)   
        _SafeGUID = pSafeGuid
        _SafeID = UtilGSafe.GetId(_SafeGUID)
        If CBool(_SafeID) Then
            _Source = TblMetaSource.LoadByPrimaryKey(TblMetaGrid.LoadByPrimaryKey(_GridID).colFldSourceId)
            _Client = TblClients.LoadByPrimaryKey(UtilGSafe.GetValue(_SafeID, UtilGSafe.KeyName.FilePreFix))
            _FilePrefix = _Client.colFileprefix
        Else
            Throw New ApplicationException("Invalid Security Identifier.")
        End If
    End Sub

#Region "Grid"

    Public Function GetGridMeta() As Dictionary(Of String, Object)
        Dim zMeta As New UtilMeta()
        zMeta.PropGridId = _GridID
        zMeta.PropSafeGUID = _SafeGUID
        Return zMeta.GetGridMeta()
    End Function

    ''' <summary>
    ''' Returns the unique columns values to be displayed in the picklist.
    ''' </summary>
    ''' <param name="pColumnName"></param>
    ''' <param name="pFilter"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetPickListData(pColumnName As String, pFilter As String) As IPickListData

        Dim zTypes As List(Of rowTblMetaGridColumnType) = TblMetaGridColumnType.LoadData()
        Dim zRow As rowTblMetaGridColumn = TblMetaGridColumn.LoadByIDX_idx_tblMetaGridColumn_fldMetaGridID_fldField(_GridID, pColumnName).First

        Dim Q As New RecGridQuery
        Q.Distinct = True
        Q.Select(pColumnName)
        Q.Where.Add(Q.colGSafeId.Equals(_SafeID))
        Q.ApplyFilter(pFilter)
        Q.OrderBy(pColumnName)

        Dim zDT As New DataTable
        Dim zCmd As New SqlClient.SqlCommand(Q.QueryText, UtilSQLServer.GetConnectionObject)
        Using zCmd.Connection
            Using zCmd
                zDT.Load(zCmd.ExecuteReader)
            End Using
        End Using

        Dim zPL As New PickListData
        zPL.ColumnName = pColumnName
        zPL.DataType = zTypes.Find(Function(x) x.colFldId = zRow.colType).colFldName
        zPL.Data = zDT.Select().ToList().Select(Of String)(Function(x) x(0)).OrderBy(Function(x) x).ToList()

        Return zPL

    End Function

    ''' <summary>
    ''' This method is used by the Sort By drop down on the page.
    ''' </summary>
    ''' <param name="pRecSortID"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetGridData(pPage As Integer, pPageSize As Integer, pRecSortID As Integer) As IGridData
        Dim zSuggest As rowVwWhatIfRecSort = VwWhatIfRecSort.LoadData().Find(Function(x) x.colFldID = pRecSortID)
        Return GetGridData(pPage, pPageSize, zSuggest.colFldSortJson, "")
    End Function

    ' ''' <summary>
    ' ''' This method is used by the picklist and supplies the sort and filter of the grid
    ' ''' </summary>
    ' ''' <param name="pSort"></param>
    ' ''' <param name="pFilter"></param>
    ' ''' <returns></returns>
    ' ''' <remarks></remarks>
    'Public Function GetGridData(pSort As String, pFilter As String) As IGridData
    '    Dim zFilter As fsFilter = GetSavedLocationsLists.ToFilter
    '    zFilter.AppendFilter(pFilter)
    '    Return GetGridData(1, _PageSize, pSort, zFilter.ToJSON)
    'End Function

    ''' <summary>
    ''' Gets grid data from virtual scrolling or paging in the grid.
    ''' </summary>
    ''' <param name="pPage"></param>
    ''' <param name="pPageSize"></param>
    ''' <param name="pSort"></param>
    ''' <param name="pFilter"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetGridData(pPage As Integer, pPageSize As Integer, pSort As String, pFilter As String) As IGridData
        Dim DP As New GridData

        DP.Total = GetTotalCount(pFilter)
        DP.Data = GetGridDataInternal(pPage, pPageSize, pSort, pFilter)
        DP.Sort = pSort
        DP.Filter = fsFilter.ToFilterText(pFilter)
        DP.Currency = Nothing
        DP.StartRow = (pPage - 1) * 100
        DP.EndRow = DP.StartRow + pPageSize

        Return DP

    End Function

    ''' <summary>
    ''' Internal method for populating the Data property in the GridData object
    ''' </summary>
    ''' <param name="pPage"></param>
    ''' <param name="pPageSize"></param>
    ''' <param name="pSort"></param>
    ''' <param name="pFilter"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetGridDataInternal(pPage As Integer, pPageSize As Integer, pSort As String, pFilter As String) As List(Of Dictionary(Of String, Object))

        Dim L As List(Of rowVwWhatIfFireRecGrid) = GetGridDataInternalView(pPage, pPageSize, pSort, pFilter)

        Dim zList As New List(Of Dictionary(Of String, Object))
        Dim zColumns As List(Of String) = GetMetaColumns()

        Dim zRow As New rowVwWhatIfFireRecGrid
        Dim zProps As List(Of Reflection.PropertyInfo) = zRow.GetType.GetProperties.ToList()

        For Each zItem As rowVwWhatIfFireRecGrid In L
            Dim zListItemData As New Dictionary(Of String, Object)
            For Each zCol As String In zColumns
                zListItemData.Add(zCol, zProps.Find(Function(x) x.Name.ToLower = "col" & zCol.ToLower).GetValue(zItem, Nothing))
            Next
            zList.Add(zListItemData)
        Next

        Return zList

    End Function

    ''' <summary>
    ''' Gets the rec grid data from the sql view
    ''' </summary>
    ''' <param name="pPage"></param>
    ''' <param name="pPageSize"></param>
    ''' <param name="pSort"></param>
    ''' <param name="pFilter"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetGridDataInternalView(pPage As Integer, pPageSize As Integer, pSort As String, pFilter As String) As List(Of rowVwWhatIfFireRecGrid)

        Dim Q As New RecGridQuery
        Q.SelectAll()
        Q.Where.Add(Q.colGSafeId.Equals(_SafeID))
        Q.ApplyFilter(pFilter)
        Q.ApplySort(pSort)

        Dim L As List(Of rowVwWhatIfFireRecGrid) = VwWhatIfFireRecGrid.LoadData(Q.QueryText).ToList()
        L = L.Skip((pPage - 1) * 100).Take(pPageSize).ToList()

        Return L

    End Function

    Public Function GetRecsSelected(pSortJson As String) As IGridData
        Dim zFilter As New fsFilter(fsFilterOperator.And)
        zFilter.AddDescriptor("WiIsSelected", fsFilterDescriptorOperator.eq, True)

        Return GetGridData(1, 9999, pSortJson, zFilter.ToJSON())

    End Function

    Private Function GetMetaColumns() As List(Of String)

        Dim zList As New List(Of String)
        Dim zCmd As New SqlClient.SqlCommand("spGetMetaGridColumns", UtilSQLServer.GetConnectionObject)
        zCmd.CommandType = CommandType.StoredProcedure
        zCmd.Parameters.AddWithValue("@pGridID", _GridID)
        zCmd.Parameters.AddWithValue("@pFilePrefix", _FilePrefix)
        Dim zDT As New DataTable

        Using zCmd.Connection
            Using zCmd
                zDT.Load(zCmd.ExecuteReader)
            End Using
        End Using

        For Each zRow As DataRow In zDT.Rows
            zList.Add(zRow("field"))
        Next

        Return zList

    End Function

    Private Function GetTotalCount(pFilter As String) As Integer
        Dim Q As New RecGridQuery
        Q.CountAll = True
        Q.Where.Add(Q.colGSafeId.Equals(_SafeID))
        Q.ApplyFilter(pFilter)
        Return UtilSQLServer.ExecuteScalar(New SqlClient.SqlCommand(Q.QueryText))
    End Function

#End Region

#Region "Form Data"

    Public Function InitForm() As IFormMeta

        Dim zCon As SqlClient.SqlConnection = UtilSQLServer.GetConnectionObject()
        Dim zCmd As New SqlClient.SqlCommand("spWhatIfInitialize", zCon)
        zCmd.Parameters.AddWithValue("@GSafeId", _SafeID)
        zCmd.CommandType = CommandType.StoredProcedure
        Using zCon
            Using zCmd
                zCmd.ExecuteNonQuery()
            End Using
        End Using

        Dim zReturn As New FormMeta
        zReturn.RecSorts = RecSort.ConvertList(VwWhatIfRecSort.LoadData())
        zReturn.GridMeta = GetGridMeta()
        zReturn.Client = GetClient()
        Return zReturn

    End Function

    Public Function GetFormData() As IFormData
        Return GetFormData(Nothing)
    End Function

    Public Function GetFormData(pFilter As LocationNameFilter) As IFormData
        SetLocationFilter(pFilter)

        Dim zCon As SqlClient.SqlConnection = UtilSQLServer.GetConnectionObject()
        Dim zCmd As New SqlClient.SqlCommand("spWhatIfGetChartData", zCon)
        Dim zChartsTable As New DataTable
        zCmd.CommandType = CommandType.StoredProcedure
        zCmd.Parameters.AddWithValue("@GSafeId", _SafeID)

        Using zCon
            Using zCmd
                zChartsTable.Load(zCmd.ExecuteReader)
            End Using
        End Using


        zCon = UtilSQLServer.GetConnectionObject()
        zCmd = New SqlClient.SqlCommand("spWhatIfGetRecSelectedCounts", zCon)
        Dim zCountsTable As New DataTable
        zCmd.CommandType = CommandType.StoredProcedure
        zCmd.Parameters.AddWithValue("@GSafeId", _SafeID)

        Using zCon
            Using zCmd
                zCountsTable.Load(zCmd.ExecuteReader)
            End Using
        End Using


        Dim zReturn As New FormData
        zReturn.Charts = InitChart()

        If zChartsTable.Rows.Count > 0 Then
            zReturn.Charts(0).Series(0).Y.Clear()
            zReturn.Charts(1).Series(0).Y.Clear()
            zReturn.Charts(2).Series(0).Y.Clear()
            zReturn.Charts(0).Series(0).YText.Clear()
            zReturn.Charts(1).Series(0).YText.Clear()
            zReturn.Charts(2).Series(0).YText.Clear()

            zReturn.Charts(0).Series(0).AddY(zChartsTable.Rows(0)("TotalScoreTivWeightedAvg"))
            zReturn.Charts(0).Series(0).AddY(zChartsTable.Rows(0)("TotalScoreRecsTivWeightedAvg"))
            zReturn.Charts(0).Series(0).AddY(zChartsTable.Rows(0)("WhatIfRecsTivWeightedAvg"))

            zReturn.Charts(1).Series(0).AddY(zChartsTable.Rows(0)("TotalScoreAchievedPercentTivWeightedAvg"))
            zReturn.Charts(1).Series(0).AddY(zChartsTable.Rows(0)("TotalScoreRecsAchievedPercentTivWeightedAvg"))
            zReturn.Charts(1).Series(0).AddY(zChartsTable.Rows(0)("WhatIfRecsAchievedPercentTivWeightedAvg"))

            zReturn.Charts(2).Series(0).AddY(zChartsTable.Rows(0)("IdentifiedRiskMillion"))
            zReturn.Charts(2).Series(0).AddY(zChartsTable.Rows(0)("RemainingRiskMillion"))
            zReturn.Charts(2).Series(0).AddY(zChartsTable.Rows(0)("ImprovedRiskMillion"))


            zReturn.HumanElementSelected = zCountsTable.Rows(0)("HeCount")
            zReturn.HumanElementSelectedScoreChange = zCountsTable.Rows(0)("HeScoreChange")
            zReturn.TotalSelected = zCountsTable.Rows(0)("TotalRecsSelected")
            zReturn.TotalSelectedScoreChange = zCountsTable.Rows(0)("TotalScoreChange")
            zReturn.EstCost = zCountsTable.Rows(0)("EstCost")


        End If

        zReturn.Filter = GetSavedLocationsLists.ToFilter.ToFilterText()
        Return zReturn

    End Function

    Public Function InitChart() As ChartingLib.ColumnChartList

        Dim zReturn As New ChartingLib.ColumnChartList
        Dim zBlue As System.Drawing.Color = System.Drawing.ColorTranslator.FromHtml("#4472C4")

        Dim zRatingChart As New ChartingLib.ColumnChart("Rating Score", "Current", "W/Rptd. Completed", "W/What If Completed")
        zRatingChart.Series.Add(New ChartingLib.ColumnChartSeries("Score", zBlue, 0, 0, 0))
        zRatingChart.ShowLegend = False

        Dim zAchChart As New ChartingLib.ColumnChart("Achievable Rating %", "Current", "W/Rptd. Completed", "W/What If Completed")
        zAchChart.Title = "Achievable Rating %"
        zAchChart.Series.Add(New ChartingLib.ColumnChartSeries("Percent", zBlue, 0, 0, 0))
        zAchChart.ShowLegend = False

        Dim zRisk As New ChartingLib.ColumnChart("Risk Improvement", "Identified", "Remaining", "Improved")
        zRisk.Series.Add(New ChartingLib.ColumnChartSeries("Risk", zBlue, 0, 0, 0))
        zRisk.ShowLegend = False

        zReturn.Add(zRatingChart)
        zReturn.Add(zAchChart)
        zReturn.Add(zRisk)

        Return zReturn
    End Function

    Public Function GetLocationRating(pFileNo As String) As ILocationRating

        Dim zReturn As New LocationRating

        Dim zQ As New queryVwWhatIfFireFacilityRating
        zQ.SelectAll()
        zQ.Where.Add(zQ.colGSafeId.Equals(_SafeID))
        zQ.Where.Add(zQ.colFileNo.Equals(pFileNo))

        Dim zL As List(Of rowVwWhatIfFireFacilityRating) = VwWhatIfFireFacilityRating.LoadData(zQ.QueryText)
        If zL.Count > 0 Then
            zReturn.Address = zL.First.colAddressStamp
            zReturn.FileNo = zL.First.colFileNo

            zReturn.TotalScoreString = zL.First.colTotalscore.ToString()
            zReturn.TotalScoreBackColorHex = zL.First.colTotalScoreHexBackColor
            zReturn.TotalScoreForeColorHex = zL.First.colTotalScoreHexForeColor

            zReturn.AchievableRatingPercentString = zL.First.colAchievableScorePercentString
            zReturn.AchievableRatingPercentForeColorHex = zL.First.colAchievableScorePercentHexForeColor
            zReturn.AchievableRatingPercentBackColorHex = zL.First.colAchievableScorePercentHexBackColor

            zReturn.TotalScoreRecsAllRecsCompString = zL.First.colOverallscorewithrecscomplete.ToString
            zReturn.TotalScoreRecsAllRecsCompForeColorHex = zL.First.colOverallScoreWithRecsCompleteHexForeColor
            zReturn.TotalScoreRecsAllRecsCompBackColorHex = zL.First.colOverallScoreWithRecsCompleteHexBackColor

            zReturn.WhatIfScoreString = zL.First.colWhatIfScore
            zReturn.WhatIfScoreForeColorHex = zL.First.colWhatIfScoreHexForeColor
            zReturn.WhatIfScoreBackColorHex = zL.First.colWhatIfScoreHexBackColor

            zReturn.WhatIfAchievableRatingPercentString = zL.First.colAchievablePercentWhatIfString
            zReturn.WhatIfAchievableRatingPercentForeColorHex = zL.First.colAchievablePercentWhatIfHexForeColor
            zReturn.WhatIfAchievableRatingPercentBackColorHex = zL.First.colAchievablePercentWhatIfHexBackColor

            ''always will be 100%
            zReturn.AllRecsCompAchievableRatingPercentString = "100%"
            zReturn.AllRecsCompAchievableRatingPercentForeColorHex = "#000000"
            zReturn.AllRecsCompAchievableRatingPercentBackColorHex = "#00FF00"

        End If

        Return zReturn

    End Function

#End Region

#Region "Filtering"

    Public Sub SetLocationFilter(pFilter As LocationNameFilter)

        If Not IsNothing(pFilter) AndAlso pFilter.Descriptor <> Client.LocationDescriptor.None Then

            Dim zSelectedLists As SelectedLocationLists = GetSavedLocationsLists()

            'ADD/REMOVE VALUES FROM LISTS
            If pFilter.Add Then
                If pFilter.Descriptor = Client.LocationDescriptor.Division Then zSelectedLists.DivisionList.Add(pFilter.Name)
                If pFilter.Descriptor = Client.LocationDescriptor.ClientLocID Then zSelectedLists.ClientLocIDList.Add(pFilter.Name)
                If pFilter.Descriptor = Client.LocationDescriptor.CustomAccess Then zSelectedLists.CustomAccessList.Add(pFilter.Name)
                If pFilter.Descriptor = Client.LocationDescriptor.FileNo Then zSelectedLists.FileNoList.Add(pFilter.Name)
                If pFilter.Descriptor = Client.LocationDescriptor.Facility Then zSelectedLists.FacilityList.Add(pFilter.Name)
            Else
                If pFilter.Descriptor = Client.LocationDescriptor.Division Then zSelectedLists.DivisionList.Remove(pFilter.Name)
                If pFilter.Descriptor = Client.LocationDescriptor.ClientLocID Then zSelectedLists.ClientLocIDList.Remove(pFilter.Name)
                If pFilter.Descriptor = Client.LocationDescriptor.CustomAccess Then zSelectedLists.CustomAccessList.Remove(pFilter.Name)
                If pFilter.Descriptor = Client.LocationDescriptor.FileNo Then zSelectedLists.FileNoList.Remove(pFilter.Name)
                If pFilter.Descriptor = Client.LocationDescriptor.Facility Then zSelectedLists.FacilityList.Remove(pFilter.Name)
            End If

            FillLocationFilter(zSelectedLists)

            If zSelectedLists.IsEmpty Then
                'IF THERE ARE NO MORE FILTERS THEN WE NEED TO FILL ALL THE LOCATIONS IN THE FILTER TABLE
                FillLocations()
                SetKey(Key.SelectedLocationListsJSON, "")
            Else
                SetKey(Key.SelectedLocationListsJSON, zSelectedLists.ToJSON())
            End If
        End If

    End Sub

    Private Sub FillLocationFilter(pLists As SelectedLocationLists)

        Dim zQ As New LocationQuery
        zQ.SelectInto("#SelectedLocations", zQ.colFldGSafeId, zQ.colFldFileNo)
        zQ.Where.Add(zQ.colFldGSafeId.Equals(_SafeID))
        zQ.ApplyFilter(pLists.ToFilter.ToJSON())

        Dim zSB As New Text.StringBuilder(zQ.QueryText & ";  EXEC spWhatIfFillLocationSelected @GSafeId;")

        Dim zCmd As New SqlClient.SqlCommand(zSB.ToString)
        zCmd.CommandType = CommandType.Text
        zCmd.Parameters.AddWithValue("@GSafeId", _SafeID)
        zCmd.Connection = UtilSQLServer.GetConnectionObject()

        Using zCmd.Connection
            Using zCmd
                zCmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub

    Public Sub FillLocations()

        Dim zCon As SqlClient.SqlConnection = UtilSQLServer.GetConnectionObject()
        Dim zCmd As New SqlClient.SqlCommand("spWhatIfFillLocations", zCon)
        zCmd.Parameters.AddWithValue("@GSafeId", _SafeID)
        zCmd.CommandType = CommandType.StoredProcedure
        Using zCon
            Using zCmd
                zCmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub

    Private Function GetSavedLocationsLists() As SelectedLocationLists
        Dim zSelectedLists As New SelectedLocationLists
        zSelectedLists.CustomAccessLabel = _Client.colCustomAccessLabel
        Dim zSelectedLocationNamesJSON As String = GetKey(Key.SelectedLocationListsJSON)
        If zSelectedLocationNamesJSON <> "" Then
            zSelectedLists = Newtonsoft.Json.JsonConvert.DeserializeObject(Of SelectedLocationLists)(zSelectedLocationNamesJSON)
        End If
        Return zSelectedLists
    End Function

    Private Class SelectedLocationLists

        Property DivisionList As New List(Of String)
        Property CustomAccessList As New List(Of String)
        Property FileNoList As New List(Of String)
        Property ClientLocIDList As New List(Of String)
        Property CustomAccessLabel As String = ""
        Property FacilityList As New List(Of String)

        Public Function GetDivisionFilter() As fsFilter
            Dim zF As New fsFilter(fsFilterOperator.Or)
            DivisionList.ForEach(Sub(x) zF.AddDescriptor("fldDivision", "Division", fsFilterDescriptorOperator.eq, x))
            Return zF
        End Function

        Public Function GetCustomAccessFilter() As fsFilter
            Dim zF As New fsFilter(fsFilterOperator.Or)
            CustomAccessList.ForEach(Sub(x) zF.AddDescriptor("fldCustomAccess", CustomAccessLabel, fsFilterDescriptorOperator.eq, x))
            Return zF
        End Function

        Public Function GetFileNoFilter() As fsFilter
            Dim zF As New fsFilter(fsFilterOperator.Or)
            FileNoList.ForEach(Sub(x) zF.AddDescriptor("fldFileNo", "File No.", fsFilterDescriptorOperator.eq, x))
            Return zF
        End Function

        Public Function GetClientLocIDFilter() As fsFilter
            Dim zF As New fsFilter(fsFilterOperator.Or)
            ClientLocIDList.ForEach(Sub(x) zF.AddDescriptor("fldClientLocID", "Client Loc. Id.", fsFilterDescriptorOperator.eq, x))
            Return zF
        End Function

        Public Function GetFacilityFilter() As fsFilter
            Dim zF As New fsFilter(fsFilterOperator.Or)
            FacilityList.ForEach(Sub(x) zF.AddDescriptor("FldFacility", "Facility.", fsFilterDescriptorOperator.eq, x))
            Return zF
        End Function

        Public Function IsEmpty() As Boolean
            Return Not CBool(DivisionList.Count Or CustomAccessList.Count Or FileNoList.Count Or ClientLocIDList.Count Or FacilityList.Count)
        End Function

        Public Function ToJSON() As String
            Return Newtonsoft.Json.JsonConvert.SerializeObject(Me)
        End Function

        Public Function ToFilter() As fsFilter
            'BUILD NEW FSFILTER OBJECT
            Dim zFsFilter As New fsFilter(fsFilterOperator.And)
            zFsFilter.AppendFilter(Me.GetDivisionFilter)
            zFsFilter.AppendFilter(Me.GetClientLocIDFilter)
            zFsFilter.AppendFilter(Me.GetCustomAccessFilter)
            zFsFilter.AppendFilter(Me.GetFileNoFilter)
            zFsFilter.AppendFilter(Me.GetFacilityFilter)
            Return zFsFilter
        End Function

    End Class

#End Region

#Region "Keys"

    Private Enum Key
        SelectedLocationListsJSON = 1
        LocationFilterJSON = 2
        GridFilterJSON = 3
    End Enum

    Private Sub SetKey(pKey As Key, pValue As String)
        Dim zRow As rowTblWhatIfKey = TblWhatIfKey.LoadByPrimaryKey(_SafeID, pKey)
        zRow.colFldGSafeID = _SafeID
        zRow.colFldKey = pKey.ToString()
        zRow.colFldValue = pValue
        TblWhatIfKey.Save(zRow)
    End Sub

    Private Function GetKey(pKey As Key) As Object
        Dim zRow As rowTblWhatIfKey = TblWhatIfKey.LoadByPrimaryKey(_SafeID, pKey.ToString())
        Return zRow.colFldValue
    End Function

#End Region

    Public Function GetClient() As IClient

        Dim Q As New LocationQuery
        Q.SelectAll()
        Q.Where.Add(Q.colFldGSafeId.Equals(_SafeID))

        Dim L As List(Of rowTblWhatIfLocation) = TblWhatIfLocation.LoadData(Q.QueryText)

        Dim zReturn As New Client
        L.Select(Function(x) x.colFldDivision).ToList.Distinct().OrderBy(Function(x) x).ToList().ForEach(Sub(x) zReturn.Divisions.Add(New LocationName("Division", x, Client.LocationDescriptor.Division)))
        L.Select(Function(x) x.colFldFileNo).ToList.Distinct().OrderBy(Function(x) x).ToList().ForEach(Sub(x) zReturn.FileNos.Add(New LocationName("FileNo", x, Client.LocationDescriptor.FileNo)))
        L.Select(Function(x) x.colFldClientLocID).ToList.Distinct().OrderBy(Function(x) x).ToList().ForEach(Sub(x) zReturn.ClientLocIDs.Add(New LocationName("ClientLocID", x, Client.LocationDescriptor.ClientLocID)))
        L.Select(Function(x) x.colFldFacility).ToList.Distinct().OrderBy(Function(x) x).ToList().ForEach(Sub(x) zReturn.Facilities.Add(New LocationName("Facility", x, Client.LocationDescriptor.Facility)))


        zReturn.ShowCustomAccess = Not _Client.colCustomAccessLabel.ToLower = "not used"
        If zReturn.ShowCustomAccess Then
            zReturn.CustomAccessLabel = _Client.colCustomAccessLabel
            L.Select(Function(x) x.colFldCustomAccess).ToList.Distinct().OrderBy(Function(x) x).ToList().ForEach(Sub(x) zReturn.CustomAccess.Add(New LocationName("CustomAccess", x, Client.LocationDescriptor.CustomAccess)))
        End If

        'ASSIGN UNIQUE IDS
        zReturn.ClientName = _Client.colClientname
        zReturn.FilePrefix = _Client.colFileprefix
        zReturn.FireRatingKeyID = _Client.colFireRatingKeyID
        zReturn.Divisions.ForEach(Sub(x) x.ID = x.ID & zReturn.Divisions.IndexOf(x))
        zReturn.FileNos.ForEach(Sub(x) x.ID = x.ID & zReturn.FileNos.IndexOf(x))
        zReturn.ClientLocIDs.ForEach(Sub(x) x.ID = x.ID & zReturn.ClientLocIDs.IndexOf(x))
        zReturn.CustomAccess.ForEach(Sub(x) x.ID = x.ID & zReturn.CustomAccess.IndexOf(x))
        zReturn.Facilities.ForEach(Sub(x) x.ID = x.ID & zReturn.Facilities.IndexOf(x))

        Return zReturn

    End Function

#Region "Grid CheckBox Events"

    Public Sub DeselectRec(pRecID As Integer)
        Dim zCon As SqlClient.SqlConnection = UtilSQLServer.GetConnectionObject()
        Dim zCmd As New SqlClient.SqlCommand("spWhatIfDeselectRec", zCon)
        zCmd.CommandType = CommandType.StoredProcedure
        zCmd.Parameters.AddWithValue("@GSafeId", _SafeID)
        zCmd.Parameters.AddWithValue("@RecID", pRecID)
        zCmd.Parameters.AddWithValue("@FilePrefix", _FilePrefix)

        Using zCmd.Connection
            Using zCmd
                zCmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub DeselectRecs(pFilterJSON As String)
        Dim zQ As New RecGridQuery
        zQ.SelectInto("#SelectedRecs", zQ.colGSafeId, zQ.colFilePrefix, zQ.colRecUniqueID)
        zQ.Where.And(zQ.colGSafeId.Equals(_SafeID), zQ.colFilePrefix.Equals(_FilePrefix))
        zQ.ApplyFilter(pFilterJSON)

        Dim zSB As New Text.StringBuilder(zQ.QueryText & "; EXEC spWhatIfDeselectRecs;")

        Dim zCmd As New SqlClient.SqlCommand(zSB.ToString)
        zCmd.Connection = UtilSQLServer.GetConnectionObject()

        Using zCmd.Connection
            Using zCmd
                zCmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub

    Public Sub SelectRec(pRecID As Integer)

        Dim zCon As SqlClient.SqlConnection = UtilSQLServer.GetConnectionObject()
        Dim zCmd As New SqlClient.SqlCommand("spWhatIfSelectRec", zCon)
        zCmd.CommandType = CommandType.StoredProcedure
        zCmd.Parameters.AddWithValue("@GSafeId", _SafeID)
        zCmd.Parameters.AddWithValue("@RecID", pRecID)
        zCmd.Parameters.AddWithValue("@FilePrefix", _FilePrefix)

        Using zCmd.Connection
            Using zCmd
                zCmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub

    Public Sub SelectRecs(pFilterJSON As String)

        Dim zQ As New RecGridQuery
        zQ.SelectInto("#SelectedRecs", zQ.colGSafeId, zQ.colFilePrefix, zQ.colRecUniqueID)
        zQ.Where.And(zQ.colGSafeId.Equals(_SafeID), zQ.colFilePrefix.Equals(_FilePrefix))
        zQ.ApplyFilter(pFilterJSON)

        Dim zSB As New Text.StringBuilder(zQ.QueryText & "; EXEC spWhatIfSelectRecs;")

        Dim zCmd As New SqlClient.SqlCommand(zSB.ToString)
        zCmd.Connection = UtilSQLServer.GetConnectionObject()

        Using zCmd.Connection
            Using zCmd
                zCmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub

#End Region

#Region "Reporting"


    Public Function GetFireRatingReport(pFileNo As String) As Byte()

        Dim z As IrowTblClients = TblClients.LoadByPrimaryKey(_FilePrefix)

        Dim zQ As New Queries
        zQ.SelectAll()
        zQ.Where.And(zQ.colGSafeId.Equals(_SafeID), zQ.colFileNo.Equals(pFileNo))
        Dim zL As List(Of rowVwWhatIfFireFacilityRating) = VwWhatIfFireFacilityRating.LoadData(zQ.QueryText)

        Dim zQ1 As New queryVwMetaRatingKeyRange
        zQ1.SelectAll()
        zQ1.Where.Add(zQ1.colFldKeyId.Equals(CInt(z.colFireRatingKeyID)))
        Dim zL1 As IEnumerable(Of IrowVwMetaRatingKeyRange) = VwMetaRatingKeyRange.LoadData(zQ1.QueryText)

        Dim zDS As New RatingReportData
        zDS.Client.ClientName = z.colClientname
        zDS.Fields = zL.First
        zDS.RatingKeys = zL1.ToList()

        Dim zRpt As New ReportLib.FireFacilityRatingReportWhatIf()
        zRpt.ReportDataSource = zDS

        Dim zReportSource As New Telerik.Reporting.InstanceReportSource()
        zReportSource.ReportDocument = zRpt

        Dim zProcessor As New Telerik.Reporting.Processing.ReportProcessor()
        Dim zResult As Telerik.Reporting.Processing.RenderingResult = zProcessor.RenderReport("pdf", zReportSource, Nothing)

        Return zResult.DocumentBytes

    End Function

    Public Function GetWhatIfReport(pHandlerGUID As String) As Byte()
        Dim zRow As rowTblWhatIfOutputParm = TblWhatIfOutputParm.LoadByPrimaryKey(pHandlerGUID)
        Return GetWhatIfReport(zRow.colFldSortJSON, zRow.colFldFilterJSON, zRow.colFldEstBudget, zRow.colFldEstCostToComplete, zRow.colFldRemainBudget)
    End Function

    Public Function GetWhatIfReportData(pHandlerGUID As String) As WhatIfReportData
        Dim zRow As rowTblWhatIfOutputParm = TblWhatIfOutputParm.LoadByPrimaryKey(pHandlerGUID)
        Return GetWhatIfReportData(zRow.colFldSortJSON, zRow.colFldFilterJSON, zRow.colFldEstBudget, zRow.colFldRemainBudget)
    End Function

    Public Function GetWhatIfReportData(pSortJson As String, pFilterJson As String, pEstBudget As String, pRemainBudget As String) As IWhatIfReportData

        Dim zfs As fsFilter = fsFilter.FromJSON(pFilterJson)
        zfs.AddDescriptor("WiIsSelected", fsFilterDescriptorOperator.eq, "True")
        pFilterJson = zfs.ToJSON()

        Dim zDS As New WhatIfReportData
        zDS.Client.ClientName = _Client.colClientname
        zDS.Client.FireRatingKeyID = _Client.colFireRatingKeyID
        zDS.Client.FilePrefix = _Client.colFileprefix
        zDS.FormData = GetFormData()
        zDS.Budget = pEstBudget
        zDS.RemainBudget = pRemainBudget
        zDS.GridData = GetGridData(1, 9999999, pSortJson, pFilterJson)
        Return zDS
    End Function

    Public Function GetWhatIfReport(pSortJson As String, pFilterJson As String, pEstBudget As String, pEstCostToComplete As String, pRemainBudget As String) As Byte()

        Dim zRpt As New ReportLib.WhatIfAnalysisSummaryReport
        zRpt.ReportDataSource = GetWhatIfReportData(pSortJson, pFilterJson, pEstBudget, pRemainBudget)

        Dim zReportSource As New Telerik.Reporting.InstanceReportSource()
        zReportSource.ReportDocument = zRpt

        Dim zProcessor As New Telerik.Reporting.Processing.ReportProcessor()
        AddHandler zProcessor.Error, AddressOf ReportErrorHandler
        Dim zResult As Telerik.Reporting.Processing.RenderingResult = zProcessor.RenderReport("pdf", zReportSource, Nothing)

        Return zResult.DocumentBytes

    End Function

    Public Function GetTestBubbleReport() As Byte()

        Dim zRpt As New ReportLib.TestBubbleChartReport

        Dim zReportSource As New Telerik.Reporting.InstanceReportSource()
        zReportSource.ReportDocument = zRpt

        Dim zProcessor As New Telerik.Reporting.Processing.ReportProcessor()
        AddHandler zProcessor.Error, AddressOf ReportErrorHandler
        Dim zResult As Telerik.Reporting.Processing.RenderingResult = zProcessor.RenderReport("pdf", zReportSource, Nothing)

        Return zResult.DocumentBytes

    End Function

    Public Function GetWhatIfExtract(pSortJson As String, pFilterJson As String) As Byte()
        Dim zQ As New RecGridQuery
        zQ.SelectAll()
        zQ.Where.Add(zQ.colGSafeId.Equals(_SafeID))

        If pSortJson = "null" Then pSortJson = ""
        If pFilterJson = "null" Then pFilterJson = ""

        zQ.ApplyFilter(pFilterJson)
        zQ.ApplySort(pSortJson)

        Dim zL As List(Of rowVwWhatIfFireRecGrid) = VwWhatIfFireRecGrid.LoadData(zQ.QueryText).ToList()

        Dim zMeta As Dictionary(Of String, Object) = GetGridMeta()
        Dim zCols As List(Of Object) = zMeta("columns")
        Dim zColList As New List(Of MetaColumn)
        zCols.ForEach(Sub(x) zColList.Add(New MetaColumn(x("title"), x("fldExcludeFromExtract"), x("field"), x("fieldnamebackcolor"), x("hidden"), x("feature"))))

        Dim zVisibleColsList As List(Of MetaColumn) = zColList.Where(Function(x) (x.Exclude = False Or x.CustomFeature.IndexOfAny(_Client.colFeatures.ToCharArray()) > -1)).ToList

        Dim zXLData As New Excel.Extractions.XLExtractListSource(zL)
        Dim zXLSheetCols As New List(Of Excel.Extractions.XLExtractColumn)
        zVisibleColsList.ForEach(Sub(x) zXLSheetCols.Add(New Excel.Extractions.XLExtractColumn("col" & x.Field, x.Title)))

        Dim zXLSheet As New Excel.Extractions.XLExtractSheet(zXLData, "What If Analysis Recommendations", zXLSheetCols)
        zXLSheet.sheetcolumns.Find(Function(X) X.DataMember = "colRecYear").XLDataType = Extractions.XLExtractColumn.XLDataTypes.xlString
        zXLSheet.sheetcolumns.Find(Function(X) X.DataMember = "colRecCategory").BackColorMember = "colRecCategoryColor"
        zXLSheet.sheetcolumns.Find(Function(X) X.DataMember = "colWiIsSelected").HeaderText = "Selected"

        Dim zXL As New Excel.Extractions.XLExtractor()
        zXL.Settings.BooleanHandling = Extractions.XLExtractSettings.BooleanHandlingOption.YesNo
        zXL.SheetData.Add(zXLSheet)
        Return zXL.Run()

    End Function

    Private Class MetaColumn
        Public Title As String
        Public Exclude As Boolean
        Public Field As String
        Public Hidden As String
        Public BackColorField As String
        Public CustomFeature As String

        Public Sub New(title As String, exclude As Boolean, field As String, backColorField As String, hidden As Boolean, feature As String)
            Me.Title = title
            Me.Exclude = exclude
            Me.Field = field
            Me.Hidden = hidden
            Me.BackColorField = backColorField
            Me.CustomFeature = IIf(IsNothing(feature), "", feature)
        End Sub

        Public Overrides Function ToString() As String
            Return String.Format("{0} - {1}", Title, Exclude)
        End Function

    End Class



#End Region

    Public Function SetOutputParameters(pReportTypeID As DownloadHandler.ReportTypes, pFileNo As String, pSortJSON As String, pFilterJSON As String, pEstBudget As String, pEstCostToComplete As String, pRemainBudget As String) As String
        Dim zRow As New rowTblWhatIfOutputParm
        zRow.colFldGUID = Guid.NewGuid.ToString()
        zRow.colFldSID = _SafeGUID
        zRow.colFldOutputID = CInt(pReportTypeID)
        zRow.colFldGSafeID = _SafeID
        zRow.colFldFileNo = pFileNo
        zRow.colFldFilterJSON = IIf(pFilterJSON = "null", Nothing, pFilterJSON)
        zRow.colFldSortJSON = IIf(pSortJSON = "null", Nothing, pSortJSON)
        zRow.colFldRemainBudget = pRemainBudget
        zRow.colFldEstBudget = pEstBudget
        zRow.colFldEstCostToComplete = pEstCostToComplete
        TblWhatIfOutputParm.Save(zRow)
        Return zRow.colFldGUID
    End Function

    Private Sub ReportErrorHandler(sender As Object, eventArgs As Telerik.Reporting.ErrorEventArgs)

    End Sub

End Class
