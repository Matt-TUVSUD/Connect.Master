Imports GRC.Connect.Libraries.DataLib.razor

Public Class BatchSet
    Inherits rowTblBatchProcessingSet

    Public Property BatchSetItems As New List(Of BatchSetItem)
    Public Property BatchSetFileNos As New List(Of String)
    Public Property ConnectionString As String = ""
    Public Property SetParameters As IUtilSQLMakerParameterInfo
    Private _SetNavLinkIDs As New List(Of Integer)

#Region "Enum"
    Public Enum JSONSetting
        FilterLO = 1
        MyPreference
        CriteriaLO
        SortLO
        SettingLO
        Parameter
    End Enum

    Public Enum DeliveryMode
        Interactive = 1
        Website
    End Enum

    Public Enum BatchTypeGroup
        Report = 1
        Extract = 2
    End Enum

    Public Enum BatchType
        Report = 1
        CSV
        TAB
        XLSX
    End Enum

    Public Enum BatchStatus
        Defining = 1
        Defined
        Queued
        Processing
        Processed
        Delivered
        Exception
        Cancelled
    End Enum

#End Region

    Public Sub New()
        SetParameters = New UtilSQLMaker.ParameterInfo
        UtilSQLServer.PersistSecurityInfo = True

        'DEFAULT VALUES

        Me.colFldStatusId = BatchStatus.Defining
        Me.colFldCreateDate = Now
        Me.colFldDisable = False
    End Sub

    Public Sub New(pFileName As String)
        Me.New()
        Me.colFldFileName = pFileName
    End Sub

    Public Property BatchSetStatus As BatchStatus
        Get
            Return CType(Me.colFldStatusId, BatchStatus)
        End Get
        Set(value As BatchStatus)
            Me.colFldStatusId = value
            LogStatusChange(value)
        End Set
    End Property

    Public Property Type As BatchType
        Get
            Return CType(Me.colFldSetTypeID, BatchType)
        End Get
        Set(value As BatchType)
            Me.colFldSetTypeID = value
        End Set
    End Property

    Public ReadOnly Property BatchSetTypeGroup As BatchTypeGroup
        Get
            Select Case Me.Type
                Case BatchType.CSV, BatchType.TAB, BatchType.XLSX
                    Return BatchTypeGroup.Extract
                Case Else
                    Return BatchTypeGroup.Report
            End Select
        End Get
    End Property

    Private Function GetProperty(pMetaParameter As tblMetaParameter.ParameterFlags) As Reflection.PropertyInfo
        Dim zPropInfo As Reflection.PropertyInfo = Me.GetType.GetProperty(pMetaParameter.ToString)
        If IsNothing(zPropInfo) Then
            Throw New ApplicationException("System could not find property info [" & pMetaParameter.ToString & "] in the UtilSQLMaker.Parameters object.")
        Else
            Return zPropInfo
        End If
    End Function

    Private Sub BatchSet_Loaded() Handles Me.Loaded
        Me.BatchSetItems = TblBatchProcessingSetItem.LoadByIDX_IX_fldSetId(Of BatchSetItem)(Me.colFldId)
        Try
            Me.BatchSetItems.ForEach(Sub(x) x.Parent = Me)
            Me.BatchSetItems.ForEach(AddressOf SetMetaObject)
            Me.BatchSetFileNos.AddRange(TblBatchProcessingFileNo.LoadByIDX_IX_tblBatchProcessingFileNo_fldSetID(Me.colFldId).ToDictionary(Function(x) x.colFldFileNo).Keys.ToArray)
            Me.ConnectionString = UtilSQLServer.ConnectionString
            Me.SetParameters = Newtonsoft.Json.JsonConvert.DeserializeObject(Of UtilSQLMaker.ParameterInfo)(Me.colFldMetaParameterJSON)
        Catch ex As Exception
            Throw New UtilBatchProcessSetException("An exception occurred trying to load batchset.", Me, ex)
        End Try
    End Sub

    Private Sub SetMetaObject(pBatchSetItem As BatchSetItem)
        Select Case pBatchSetItem.Parent.BatchSetTypeGroup
            Case BatchTypeGroup.Extract
                pBatchSetItem.MetaObject = TblMetaGrid.LoadByPrimaryKey(pBatchSetItem.colFldMetaObjectId)
            Case BatchTypeGroup.Report
                pBatchSetItem.MetaObject = TblMetaReport.LoadByPrimaryKey(pBatchSetItem.colFldMetaObjectId)
        End Select
    End Sub

    Public Shared Function LoadAll() As List(Of BatchSet)
        Return TblBatchProcessingSet.LoadData(Of BatchSet)()
    End Function

    Public Shared Function LoadByStatus(pStatus As BatchSet.BatchStatus) As List(Of BatchSet)
        Dim zSets As List(Of BatchSet) = TblBatchProcessingSet.LoadByIDX_IX_fldStatusID(Of BatchSet)(pStatus)
        Return zSets
    End Function

    ''' <summary>
    ''' Saves the batchset.  Returns the batchsetID.
    ''' </summary>
    ''' <param name="pDelayProcessing">Optional boolean value to delay any processing of the batch set.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Save(Optional pDelayProcessing As Boolean = False) As Integer

        If BatchSetFileNos.Count > 0 Then Me.colFldFilePrefix = Int(BatchSetFileNos(0))
        If Me.colFldLOSettingJSON <> "" Then Me.SetParameters.ApplyLO(Me.colFldLOSettingJSON)

        'SERIALIZE THE PARAMETERS PROPERTY TO BE SAVED IN THE DATABASE
        Dim zSerializedParms As String = Newtonsoft.Json.JsonConvert.SerializeObject(SetParameters, Newtonsoft.Json.Formatting.None)
        Me.colFldMetaParameterJSON = zSerializedParms
        Me.colFldIsInteractive = False
        TblBatchProcessingSet.Save(Me)

        'VERY IMPORTANT DELETE EXISTING SET ITEM RECORDS IF EXISTS.
        TblBatchProcessingSetItem.DeleteBySetId(Me.colFldId)

        'CONVERT NAVLINKS TO SETITEMS IF AVAILABLE
        ConvertNavLinkToSetItems()

        For Each zBatchSetItem As BatchSetItem In BatchSetItems
            zBatchSetItem.colFldSetId = Me.colFldId
            zBatchSetItem.colFldStatusId = BatchStatus.Defined
            zBatchSetItem.colExtendedPropJSON = Newtonsoft.Json.JsonConvert.SerializeObject(zBatchSetItem.ExtendedProperty)
            zBatchSetItem.Parent = Me
            Select Case Me.Type
                Case BatchType.Report
                    zBatchSetItem.MetaObject = TblMetaReport.LoadByPrimaryKey(zBatchSetItem.colFldMetaObjectId)
                Case Else
                    zBatchSetItem.MetaObject = TblMetaGrid.LoadByPrimaryKey(zBatchSetItem.colFldMetaObjectId)
            End Select

            zBatchSetItem.SetIsDirty(True)  'THIS IS SETTING TO DIRTY TO FORCE SAVE OF RECORD BACK TO THE DATABASE

            TblBatchProcessingSetItem.Save(zBatchSetItem)
        Next

        'VERY IMPORTANT DELETE EXISTING RECORDS IF EXISTS.
        TblBatchProcessingFileNo.DeleteBySetId(Me.colFldId)

        For Each zFileNo As String In BatchSetFileNos
            Dim zProcessingFileNo As New rowTblBatchProcessingFileNo
            zProcessingFileNo.colFldFileNo = zFileNo
            zProcessingFileNo.colFldSetId = Me.colFldId
            TblBatchProcessingFileNo.Save(zProcessingFileNo)
        Next

        If Not pDelayProcessing Then
            Me.BatchSetStatus = BatchStatus.Defined
            TblBatchProcessingSet.Save(Me)
        End If

        Return Me.colFldId

    End Function

    Public Sub ApplySettings()

        'Dim zObj As Newtonsoft.Json.Linq.JObject = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Object)(Me.colFldLOSettingJSON)
        'Dim zSettingParms As List(Of rowTblMetaParameter) = tblMetaParameter.GetSettingParameters
        'For Each zSettingParm As rowTblMetaParameter In zSettingParms
        '    Dim zToken As Newtonsoft.Json.Linq.JToken = Nothing
        '    If zObj.TryGetValue(zSettingParm.colFldFieldName, zToken) Then
        '        Dim zTokenValue As Integer = zToken.ToString
        '        SetParameters.SetValue(zSettingParm.colFldFlagId, zTokenValue)
        '    End If
        'Next

    End Sub

    Private Sub LogStatusChange(pNewStatus As BatchSet.BatchStatus)
        UtilBatchProcess.WriteLog(Me.colFldId, "Change Batch Set Status to " & pNewStatus.ToString)
    End Sub

    Public Function Execute() As UtilBatchProcessResult
        Me.colFldIsInteractive = True
        Save()
        Dim zUtilBatch As New UtilBatchProcess()
        Return zUtilBatch.Process(Me)
    End Function

    Public Sub AddSetItem(pMetaObjectId As Integer)
        Dim zBatchSetItem As New BatchSetItem
        zBatchSetItem.colFldMetaObjectId = pMetaObjectId
        BatchSetItems.Add(zBatchSetItem)
    End Sub

    Public Sub AddSetItemByReport(pReport As TblMetaReport.Reports)
        AddSetItem(pReport)
    End Sub

    Public Sub AddSetItem(pMetaObjectId As Integer())
        For Each zItem As Integer In pMetaObjectId
            AddSetItem(zItem)
        Next
    End Sub

    ''' <summary>
    ''' This method is required only when in interactive mode
    ''' </summary>
    ''' <param name="pNavLinkIds"></param>
    ''' <remarks></remarks>
    Public Sub AddNavLinkItem(pNavLinkIds As Integer())
        pNavLinkIds.ToList.ForEach(Sub(x) AddNavLinkItem(x))
    End Sub

    ''' <summary>
    ''' This method is required only when in interactive mode
    ''' </summary>
    ''' <param name="pNavLinkId"></param>
    ''' <remarks></remarks>
    Public Sub AddNavLinkItem(pNavLinkId As Integer)
        _SetNavLinkIDs.Add(pNavLinkId)
    End Sub

    Public Sub AddFileNo(pFileNo As String)
        BatchSetFileNos.Add(pFileNo)
    End Sub

    Public Sub AddFileNo(pFileNo As String())
        For Each zFileNo As String In pFileNo
            BatchSetFileNos.Add(zFileNo)
        Next
    End Sub

    Public Shared Function GetSetting(pSetting As JSONSetting, pBatchSetId As Integer)
        Dim zRow As rowTblBatchProcessingSet = TblBatchProcessingSet.LoadByPrimaryKey(pBatchSetId)

        Select Case pSetting
            Case JSONSetting.MyPreference
                Return zRow.colFldLOMyPreferenceJSON

            Case JSONSetting.CriteriaLO
                Return zRow.colFldLOCriteriaJSON

            Case JSONSetting.FilterLO
                Return zRow.colFldLOFilterJSON

            Case JSONSetting.Parameter
                Return zRow.colFldMetaParameterJSON

            Case JSONSetting.SettingLO
                Return zRow.colFldLOSettingJSON

            Case JSONSetting.SortLO
                Return zRow.colFldLOSortJSON

        End Select

        Return ""

    End Function


    ''' <summary>
    ''' This routine  converts the supplie navlink Ids to thier respective report or grid ID.  It also adds the child navlinks if exists and add them also. (Primarilly for charts)
    ''' </summary>
    ''' <remarks>This routine is primarilly used in myBatchReports.  
    ''' The myBatchReports page supplies NavLinks due to the the requirement of generating a chart via URL. The URL is stored in the Navlink table.
    ''' </remarks>
    Private Sub ConvertNavLinkToSetItems()
        Dim zReports As List(Of rowTblMetaReport) = TblMetaReport.LoadData
        Dim zNavLinks As List(Of rowTblNavLink) = TblNavLink.LoadData
        Dim zNavLinkChartDrillDowns As List(Of rowVwNavLinkChartDrillDownInfo) = VwNavLinkChartDrillDownInfo.LoadData()

        For Each zKey As Integer In _SetNavLinkIDs

            Dim zNavLink As rowTblNavLink = zNavLinks.Find(Function(x) x.colNavLinkId = zKey)
            Dim zNavLinkChartChildren As List(Of rowVwNavLinkChartDrillDownInfo) = Nothing
            If IsNumeric(zNavLink.colNavChartId) Then zNavLinkChartChildren = zNavLinkChartDrillDowns.FindAll(Function(x) x.colFldParentChartId = zNavLink.colNavChartId)

            If Not IsNothing(zNavLink.colNavReportId) Then
                Dim zXendProp As New BatchSetItem.ExtendedProperties
                zXendProp.ChartInfo.ChartNavLink = zNavLink
                zXendProp.ChartInfo.ChartChildInfo = zNavLinkChartChildren

                Dim zBatchSetItem As New BatchSetItem
                zBatchSetItem.colFldMetaObjectId = zNavLink.colNavReportId
                zBatchSetItem.ExtendedProperty = zXendProp
                BatchSetItems.Add(zBatchSetItem)

            Else
                Dim zEx As New ArgumentException("RptCode is invalid for NavLink [" & zNavLink.colNavLinkId & "].", "rowTblNavLink.NavRptCode")
                zEx.Data.Add("NavLinkId", zNavLink.colNavLinkId)
                zEx.Data.Add("NavText", zNavLink.colNavText)
                Throw zEx
            End If
        Next
    End Sub

    Public Shared Function Load(pSetId As Integer) As BatchSet
        '   Dim zBatchSet As New BatchSet
        Return TblBatchProcessingSet.LoadByPrimaryKey(Of BatchSet)(pSetId)

        ''COPY VALUES TO UTILBATCHSET
        'Dim pFieldInfos() As Reflection.FieldInfo = zSet.GetType.GetFields()
        'For Each pFieldInfo As Reflection.FieldInfo In pFieldInfos
        '    zUtilBatchSet.GetType.GetField(pFieldInfo.Name).SetValue(zUtilBatchSet, pFieldInfo.GetValue(zSet))
        'Next

        'For Each zSetItem As rowTblBatchProcessingSetItem In zSet.SetItems
        '    zUtilBatchSet._SetItemIDs.Add(zSetItem.colFldMetaObjectId, zSetItem.ExtendedProperties)
        'Next

        'For Each zFileNo As rowTblBatchProcessingFileNo In zSet.SetFileNos
        '    zUtilBatchSet._SetFileNos.Add(zFileNo.colFldFileNo)
        'Next

        'zUtilBatchSet.SetParameters = zSet.SetParameters

        'Return zUtilBatchSet

    End Function

    Public Sub SetAsDefined(Optional zTrx As SqlClient.SqlTransaction = Nothing)
        Me.BatchSetStatus = BatchStatus.Defined
        TblBatchProcessingSet.Save(Me, zTrx)
    End Sub


End Class
