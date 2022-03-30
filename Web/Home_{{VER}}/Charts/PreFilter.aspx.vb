Imports GRC.Connect.Libraries.DataLib.razor

Public Class PreFilter_Chart
    Inherits System.Web.UI.Page

    Public ExtraUrlParms As New ArrayList
    Public PageName As String = ""
    Public ServerSide_ChartUrlBase As String = ""
    Public ServerSide_ChartUrl As String = ""
    Public ServerSide_NoPrefilters As String = "false"
    Public ServerSide_ChartId As String = "0"

    Private Sub LoadDefaults()
        Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Try
            Call ClearExistingPrefilterSelection()
            Call SetDivAllVisible(False)
            divTablePleaseWait.Visible = False
            divTablePrefilters.Visible = True

            Dim zLinkObj As New BusinessObjects.ViewCCNavLink
            Dim zLinkColl As New BusinessObjects.ViewCCNavLinkCollection
            Dim zLinkQry As New BusinessObjects.ViewCCNavLinkQuery
            Dim zLinkId As Integer = Val(Request.QueryString("id") & "")
            Dim zLinkUrl As String = ""
            Dim zChartUrlBase As String = ""
            Dim zChartUrl As String = ""
            Dim zChartId As Integer = 0
            Dim zIsDrillDown As Boolean = False
            If Not Request.QueryString("DrillDown") Is Nothing Then
                If Request.QueryString("DrillDown").ToLower() = "true" Then
                    zIsDrillDown = True
                End If
            End If

            ' GET THE CHART LINK FROM NAVLINK TABLE
            zLinkQry.SelectAll()
            zLinkQry.Where(zLinkQry.NavLinkId = zLinkId)
            If zLinkColl.Load(zLinkQry) Then
                zLinkUrl = zLinkColl(0).NavUrl
                zChartId = zLinkColl(0).NavChartId
                ServerSide_ChartId = zLinkColl(0).NavChartId
                zChartUrl = CoreLib.UtilURL.BuildLeftNavURL(zLinkId, zLinkUrl, zSafeGUID) & "&chartId=" & zChartId
                zChartUrlBase = Left(zChartUrl, InStr(zChartUrl, "?") - 1) & "?sid=" & zSafeGUID & "&chartId=" & zChartId
                If zIsDrillDown = True Then
                    UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.currentChartDrillDownId, zChartId, UtilGSafe.KeyNameGroup.Navigation)
                Else
                    UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.currentChartId, zChartId, UtilGSafe.KeyNameGroup.Navigation)
                End If

                UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.NavLinkId, zLinkId, UtilGSafe.KeyNameGroup.Navigation)
   
            Else
            'THROW ERROR, CANNOT SHOW MSGBOX IN A POPUP WINDOW
            Dim zErrLogError As New UtilErrorLog
            zErrLogError.DateOccured = Now
            zErrLogError.ErrorType = "Chart PreFilter Chart Link Id"
            zErrLogError.ApplicationPage = "PreFilter.aspx.vb"
            zErrLogError.UserEmail = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.LoggedInUserEmail) 'IIf(Not IsNothing(HttpContext.Current.Session), HttpContext.Current.Session("LoggedInUserEmail") & "", "")
            zErrLogError.MessageOuter = "Unable to find the chart link id for the prefilter list loaded. | Link ID = " & zLinkId
            zErrLogError.CreateErrorLogRecord()
            End If

            ' HIDE / SHOW DROPDOWNS BASED ON FILTERS IN URL
            ' OLD WAY USING ALL URL PARMS
            'Dim x As Integer = 0
            'For Each zFilter As String In zParms
            '    Dim zTemp() As String = Split(zFilter, "=")
            '    'If zTemp(0) = "CustomAccess" Or zTemp(0) = "Division" Or zTemp(0) = "InspectionProgramYear" Or zTemp(0) = "TIV" Or zTemp(0) = "Status" Or zTemp(0) = "DateFrom" Or zTemp(0) = "DateTo" Or zTemp(0) = "Hazard" Or zTemp(0) = "Country" Or zTemp(0) = "TIVValue" Or zTemp(0) = "Units" Or zTemp(0) = "Currency" Or zTemp(0) = "ConvertUnits" Or zTemp(0) = "ConvertCurrency" Then
            '    If zTemp(0) = "CustomAccess" Or zTemp(0) = "Division" Or zTemp(0) = "InspectionProgramYear" Or zTemp(0) = "TIV" Or zTemp(0) = "Status" Or zTemp(0) = "DateFrom" Or zTemp(0) = "DateTo" Or zTemp(0) = "Hazard" Or zTemp(0) = "Country" Or zTemp(0) = "TIVValue" Or zTemp(0) = "Units" Or zTemp(0) = "Currency" Then
            '        ' STANDARD FILTER
            '        Dim zFilterEnum As UtilReporting.ReportFilter
            '        zFilterEnum = CInt([Enum].Parse(GetType(UtilReporting.ReportFilter), zTemp(0)))
            '        Call SetDivVisible(zFilterEnum, True)
            '        Call LoadUserSelectionList(zFilterEnum)
            '        Call SetValueFromUserPreferences(zFilterEnum)

            '    Else
            '        ' CUSTOM FILTER
            '        ' NO CUSTOM FILTER, DO NOT ADD TO LIST
            '        If zTemp.Length > 1 Then
            '            ExtraUrlParms.Add(zFilter)
            '            zChartUrlBase = zChartUrlBase & "&" & zTemp(0) & "=" & zTemp(1)
            '            ServerSide_NoPrefilters = "false"
            '        Else
            '            divTablePleaseWait.Visible = True
            '            divTablePrefilters.Visible = False
            '            ServerSide_NoPrefilters = "true"
            '        End If

            '    End If
            'Next

            ' HIDE / SHOW DROPDOWNS BASED ON FILTERS IN URL
            ' GRAB THE AVAILABLE CHART PREFILTERS FROM THE META TABLES
            Dim zMeta As New UtilMeta
            Dim zPreFilters As List(Of rowVwMetaChartPrefilters) = zMeta.GetPreFiltersCharts(CInt(zChartId))
            Dim zFilterEnum As UtilReporting.ReportFilter
            For Each zRow As rowVwMetaChartPrefilters In zPreFilters
                zFilterEnum = zRow.colEnumValue
                Call SetDivVisible(zFilterEnum, True)
                Call LoadUserSelectionList(zFilterEnum)
                Call SetValueFromUserPreferences(zFilterEnum)
            Next

            ' GRAB THE AVAILABLE CHART FILTERS FROM THE URL
            zLinkUrl = Right(zLinkUrl, zLinkUrl.Length - InStr(zLinkUrl, "?"))
            Dim zParms() As String = Split(zLinkUrl, "&")
            Dim x As Integer = 0
            For Each zFilter As String In zParms
                Dim zTemp() As String = Split(zFilter, "=")
                If zTemp(0) <> "CustomAccess" And zTemp(0) <> "Division" And
                    zTemp(0) <> "InspectionProgramYear" And zTemp(0) <> "TIV" And
                    zTemp(0) <> "Status" And zTemp(0) <> "DateFrom" And
                    zTemp(0) <> "DateTo" And zTemp(0) <> "Hazard" And
                    zTemp(0) <> "Country" And zTemp(0) <> "TIVValue" And
                    zTemp(0) <> "Units" And zTemp(0) <> "Currency" Then
                    ' CUSTOM FILTER
                    ' NO CUSTOM FILTER, DO NOT ADD TO LIST
                    If zTemp.Length > 1 Then
                        ExtraUrlParms.Add(zFilter)
                        zChartUrlBase = zChartUrlBase & "&" & zTemp(0) & "=" & zTemp(1)
                        ServerSide_NoPrefilters = "false"
                        If zTemp(0) = "RecStatus" Then UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.ChartPreFilter_RecStatus, zTemp(1), UtilGSafe.KeyNameGroup.ChartPreFilter)
                    Else
                        divTablePleaseWait.Visible = True
                        divTablePrefilters.Visible = False
                        ServerSide_NoPrefilters = "true"
                    End If

                End If
            Next

            ' LOAD THE CUSTOM ACCESS CUSTOM LABEL
            Dim zCustomAccessLabel = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.CustomAccessLabel)
            If zCustomAccessLabel.ToLower() <> "Not Used".ToLower() Then
                lblCustomAccess.Text = zCustomAccessLabel
            Else
                lblCustomAccess.Text = "Custom Access"
            End If

            ' SET THE BASE URL FOR THE CLIENT SIDE TO READ
            ServerSide_ChartUrlBase = zChartUrlBase
            ServerSide_ChartUrl = zChartUrl
            hidChartUrlBase.Value = zChartUrlBase

            ' If MetaChartPrefilters List is empty call Submit() to simulate user clicking Submit
            If zPreFilters.Count = 0 Then Submit()

        Catch ex As Exception
            Dim zErrLogError As New UtilErrorLog
            zErrLogError.DateOccured = Now
            zErrLogError.ErrorType = "Chart PreFilter LoadDefaults"
            zErrLogError.ApplicationPage = "PreFilter.aspx.vb"
            zErrLogError.StackTraceInner = ex.StackTrace
            zErrLogError.UserEmail = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.LoggedInUserEmail) 'IIf(Not IsNothing(HttpContext.Current.Session), HttpContext.Current.Session("LoggedInUserEmail") & "", "")
            If Not ex.InnerException Is Nothing Then zErrLogError.MessageInner = ex.InnerException.ToString()
            zErrLogError.MessageOuter = ex.Message
            zErrLogError.CreateErrorLogRecord()
        End Try

    End Sub


    Private Sub LoadLists()

    End Sub


    Private Sub LoadData()

    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Call LoadLists()
            Call LoadDefaults()
        End If

        Call LoadData()

        If Request.QueryString("SubmitOnOpen") = 1 Then Submit()

    End Sub


    Private Sub SetValueFromUserPreferences(pEnumFilter As UtilReporting.ReportFilter)
        Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Dim zFilePrefix As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FilePreFix)

        Select Case pEnumFilter
            Case UtilReporting.ReportFilter.Currency

                Dim zCurrencyDefault As String = UtilGSafe.GetValue(zSafeGUID, zFilePrefix, UtilGSafe.PreferenceKeyName.CurrencyDefaultText)
                Dim zCurrencyDefaultEnum As Integer = TblMetaCurrency.Currencies.UsDollar
                Dim zColl As New List(Of rowTblMetaCurrency)
                Dim zCmd As New SqlClient.SqlCommand("SELECT TOP 1 * FROM [dbo].[tblMetaCurrency] WHERE [fldCode] = @CurrencyCode")
                zCmd.Parameters.AddWithValue("@CurrencyCode", zCurrencyDefault)
                zColl = TblMetaCurrency.LoadData(zCmd)
                If zColl.Count > 0 Then
                    zCurrencyDefaultEnum = zColl(0).colFldId
                End If
                Dim item As Telerik.Web.UI.RadComboBoxItem = cboCurrency.FindItemByValue(zCurrencyDefaultEnum, True)
                item.Selected = True

            Case UtilReporting.ReportFilter.Units
                Dim zUnitDefault As String = UtilGSafe.GetValue(zSafeGUID, zFilePrefix, UtilGSafe.PreferenceKeyName.UnitDefaultText)
                Dim zUnitDefaultEnum As Integer = TblMetaUnitSystem.Systems.English
                Dim zColl As New List(Of rowTblMetaUnitSystem)
                Dim zCmd As New SqlClient.SqlCommand("SELECT TOP 1 * FROM [dbo].[tblMetaUnitSystem] WHERE [fldName] = @UnitName")
                zCmd.Parameters.AddWithValue("@UnitName", zUnitDefault)
                zColl = TblMetaUnitSystem.LoadData(zCmd)
                If zColl.Count > 0 Then
                    zUnitDefaultEnum = zColl(0).colFldId
                End If
                Dim item As Telerik.Web.UI.RadComboBoxItem = cboUnits.FindItemByValue(zUnitDefaultEnum, True)
                item.Selected = True

        End Select

    End Sub


    Private Sub LoadUserSelectionList(pEnumFilter As UtilReporting.ReportFilter)
        Select Case pEnumFilter
            Case UtilReporting.ReportFilter.CustomAccess
                'LOAD LIST FOR CUSTOM ACCESS
                UtilPrefilter.SetCustomAccesses(cboCustomAccess, UtilGSafe.GetGUIDFromQueryString())
                If UtilGSafe.GetValue(UtilGSafe.GetGUIDFromQueryString, UtilGSafe.KeyName.CustomAccessLabel).Equals("not used", StringComparison.OrdinalIgnoreCase) Then
                    Call SetDivVisible(UtilReporting.ReportFilter.CustomAccess, False)
                End If

            Case UtilReporting.ReportFilter.Division
                'LOAD LIST FOR DIVISION
                UtilPrefilter.SetDivisions(cboDivision, UtilGSafe.GetGUIDFromQueryString)

            Case UtilReporting.ReportFilter.InspectionProgramYear
                'LOAD LIST FOR INSPECTION PROGRAM YEAR
                cboInspectionProgramYear.Items.Clear()
                Dim zColl As List(Of rowTblMetaInspectionProgramYear)
                Dim zSQL As String = ""
                If CInt(ServerSide_ChartId) = UtilMeta.GetMetaKey("ChartFireBenchmarkRatingTotalFacilityScoreByLocation", 57) Or _
                    CInt(ServerSide_ChartId) = UtilMeta.GetMetaKey("ChartBoilerBenchmarkRatingTotalFacilityScoreByLocation", 58) Then
                    zSQL = "SELECT * FROM [dbo].[tblMetaInspectionProgramYear] WHERE [fldFilterText] LIKE '%(All)%'"
                Else
                    zSQL = "SELECT * FROM [dbo].[tblMetaInspectionProgramYear] WHERE [fldFilterText] NOT LIKE '%(All)%'"
                End If
                Dim zCmd As New SqlClient.SqlCommand(zSQL)
                zColl = TblMetaInspectionProgramYear.LoadData(zCmd)
                For Each zRow As rowTblMetaInspectionProgramYear In zColl
                    cboInspectionProgramYear.Items.Add(New Telerik.Web.UI.RadComboBoxItem(zRow.colFldFilterText, zRow.colFldId))
                Next

                'cboInspectionProgramYear.Items.Add(New Telerik.Web.UI.RadComboBoxItem(FilterValuesInspectionProgramYear.All, FilterValuesInspectionProgramYearParms.All))
                'cboInspectionProgramYear.Items.Add(New Telerik.Web.UI.RadComboBoxItem(FilterValuesInspectionProgramYear.LatestRatings, FilterValuesInspectionProgramYearParms.LatestRatings))
                'cboInspectionProgramYear.Items.Add(New Telerik.Web.UI.RadComboBoxItem(FilterValuesInspectionProgramYear.CurrentPeriod, FilterValuesInspectionProgramYearParms.CurrentPeriod))
                'cboInspectionProgramYear.Items.Add(New Telerik.Web.UI.RadComboBoxItem(FilterValuesInspectionProgramYear.PreviousPeriod, FilterValuesInspectionProgramYearParms.PreviousPeriod))
                'cboInspectionProgramYear.Items.Add(New Telerik.Web.UI.RadComboBoxItem(FilterValuesInspectionProgramYear.TwoPreviousPeriods, FilterValuesInspectionProgramYearParms.TwoPreviousPeriods))

            Case UtilReporting.ReportFilter.Currency
                'LOAD LIST FOR CURRENCY
                cboCurrency.Items.Clear()
                Dim zColl As List(Of rowTblMetaCurrency)
                zColl = TblMetaCurrency.LoadData
                For Each zRow As rowTblMetaCurrency In zColl
                    cboCurrency.Items.Add(New Telerik.Web.UI.RadComboBoxItem(zRow.colFldName, zRow.colFldId))
                Next

            Case UtilReporting.ReportFilter.Units
                'LOAD LIST FOR UNITS
                cboUnits.Items.Clear()
                Dim zColl As List(Of rowTblMetaUnitSystem)
                zColl = TblMetaUnitSystem.LoadData
                For Each zRow As rowTblMetaUnitSystem In zColl
                    cboUnits.Items.Add(New Telerik.Web.UI.RadComboBoxItem(zRow.colFldName, zRow.colFldId))
                Next

            Case UtilReporting.ReportFilter.Status
                'LOAD LIST FOR STATUS
                cboStatus.Items.Add(New Telerik.Web.UI.RadComboBoxItem(FilterValuesStatus.All, FilterValuesStatus.All))

            Case UtilReporting.ReportFilter.ImpairmentStartDate

            Case UtilReporting.ReportFilter.ImpairmentEndDate

            Case UtilReporting.ReportFilter.Hazard
                'LOAD LIST FOR HAZARD
                cboHazard.Items.Clear()
                Dim zColl As List(Of rowTblMetaPractice)
                Dim zCmd As New SqlClient.SqlCommand("SELECT * FROM [dbo].[tblMetaPractice] WHERE [fldIsHazard] = 1 OR [fldReportDisplayTitle] LIKE '%All%'")
                zColl = TblMetaPractice.LoadData(zCmd)
                For Each zRow As rowTblMetaPractice In zColl
                    cboHazard.Items.Add(New Telerik.Web.UI.RadComboBoxItem(zRow.colFldReportDisplayTitle, zRow.colFldFilterValue))
                Next
                'cboHazard.Items.Add(New Telerik.Web.UI.RadComboBoxItem(FilterValuesHazard.All, FilterValuesHazardParms.All))
                'cboHazard.Items.Add(New Telerik.Web.UI.RadComboBoxItem(FilterValuesHazard.Fire, FilterValuesHazardParms.Fire))
                'cboHazard.Items.Add(New Telerik.Web.UI.RadComboBoxItem(FilterValuesHazard.Seismic, FilterValuesHazardParms.Seismic))
                'cboHazard.Items.Add(New Telerik.Web.UI.RadComboBoxItem(FilterValuesHazard.Wind, FilterValuesHazardParms.Wind))
                'cboHazard.Items.Add(New Telerik.Web.UI.RadComboBoxItem(FilterValuesHazard.Flood, FilterValuesHazardParms.Flood))

            Case UtilReporting.ReportFilter.Country
                'LOAD LIST FOR COUNTRY
                Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
                Dim zClientName As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.ClientName)
                cboCountry.Items.Clear()
                cboCountry.Items.Add(New Telerik.Web.UI.RadComboBoxItem("(All)", "%"))
                Using zColl As New BusinessObjects.ViewCCPrefCountryCollection
                    With zColl.Query()
                        .SelectAll()
                        .Where(.Client = zClientName)
                        If .Load() Then
                            For Each zObj As BusinessObjects.ViewCCPrefCountry In zColl
                                If Not zObj.Country Is Nothing Then
                                    If zObj.Country.Length > 0 Then
                                        cboCountry.Items.Add(New Telerik.Web.UI.RadComboBoxItem(zObj.Country, zObj.Country))
                                    End If
                                End If
                            Next
                        End If
                    End With
                End Using

            Case UtilReporting.ReportFilter.TIV
                'LOAD LIST FOR TIV
                cboTIV.Items.Clear()
                Dim zColl As List(Of rowTblMetaTIV)
                zColl = TblMetaTIV.LoadData
                For Each zRow As rowTblMetaTIV In zColl
                    cboTIV.Items.Add(New Telerik.Web.UI.RadComboBoxItem(zRow.colFldFilterText, zRow.colFldId))
                Next
                'cboTIV.Items.Add(New Telerik.Web.UI.RadComboBoxItem(FilterValuesTIV.All, FilterValuesTIVParms.All))
                'cboTIV.Items.Add(New Telerik.Web.UI.RadComboBoxItem(FilterValuesTIV.TopTen, FilterValuesTIVParms.TopTen))
                'cboTIV.Items.Add(New Telerik.Web.UI.RadComboBoxItem(FilterValuesTIV.GreaterThan50, FilterValuesTIVParms.GreaterThan50))
                'cboTIV.Items.Add(New Telerik.Web.UI.RadComboBoxItem(FilterValuesTIV.GreaterThan100, FilterValuesTIVParms.GreaterThan100))
                'cboTIV.Items.Add(New Telerik.Web.UI.RadComboBoxItem(FilterValuesTIV.GreaterThan250, FilterValuesTIVParms.GreaterThan250))

            Case UtilReporting.ReportFilter.TIVValue
                'LOAD LIST FOR TIV VALUE
                cboTIVValue.Items.Clear()
                Dim zColl As List(Of rowTblMetaTIV)
                zColl = TblMetaTIV.LoadData
                For Each zRow As rowTblMetaTIV In zColl
                    cboTIVValue.Items.Add(New Telerik.Web.UI.RadComboBoxItem(zRow.colFldFilterText, zRow.colFldId))
                Next
                'cboTIVValue.Items.Add(New Telerik.Web.UI.RadComboBoxItem(FilterValuesTIV.All, FilterValuesTIVParms.All))
                'cboTIVValue.Items.Add(New Telerik.Web.UI.RadComboBoxItem(FilterValuesTIV.TopTen, FilterValuesTIVParms.TopTen))
                'cboTIVValue.Items.Add(New Telerik.Web.UI.RadComboBoxItem(FilterValuesTIV.GreaterThan50, FilterValuesTIVParms.GreaterThan50))
                'cboTIVValue.Items.Add(New Telerik.Web.UI.RadComboBoxItem(FilterValuesTIV.GreaterThan100, FilterValuesTIVParms.GreaterThan100))
                'cboTIVValue.Items.Add(New Telerik.Web.UI.RadComboBoxItem(FilterValuesTIV.GreaterThan250, FilterValuesTIVParms.GreaterThan250))

        End Select
    End Sub


    Private Sub SetDivVisible(pEnumFilter As UtilReporting.ReportFilter, pVisible As Boolean)
        Select Case pEnumFilter
            Case UtilReporting.ReportFilter.CustomAccess
                divCustomAccess.Visible = pVisible
            Case UtilReporting.ReportFilter.Division
                divDivision.Visible = pVisible
            Case UtilReporting.ReportFilter.InspectionProgramYear
                divInspectionProgramYear.Visible = pVisible
                'Case UtilReporting.ReportFilter.ConvertCurrency
                '    divConvertCurrency.Visible = pVisible
            Case UtilReporting.ReportFilter.Currency
                divCurrency.Visible = pVisible
            Case UtilReporting.ReportFilter.TIV
                divTIV.Visible = pVisible
                'Case UtilReporting.ReportFilter.ConvertUnits
                '    divConvertUnits.Visible = pVisible
            Case UtilReporting.ReportFilter.Units
                divUnits.Visible = pVisible
            Case UtilReporting.ReportFilter.Status
                divStatus.Visible = pVisible
            Case UtilReporting.ReportFilter.ImpairmentStartDate
                divDateFrom.Visible = pVisible
            Case UtilReporting.ReportFilter.ImpairmentEndDate
                divDateTo.Visible = pVisible
            Case UtilReporting.ReportFilter.Hazard
                divHazard.Visible = pVisible
            Case UtilReporting.ReportFilter.Country
                divCountry.Visible = pVisible
            Case UtilReporting.ReportFilter.TIVValue
                divTIVValue.Visible = pVisible
        End Select
    End Sub


    Private Sub SetDivAllVisible(pVisible As Boolean)
        divCustomAccess.Visible = pVisible
        divDivision.Visible = pVisible
        divInspectionProgramYear.Visible = pVisible
        'divConvertCurrency.Visible = pVisible
        divCurrency.Visible = pVisible
        divTIV.Visible = pVisible
        'divConvertUnits.Visible = pVisible
        divUnits.Visible = pVisible
        divStatus.Visible = pVisible
        divDateFrom.Visible = pVisible
        divDateTo.Visible = pVisible
        divHazard.Visible = pVisible
        divCountry.Visible = pVisible
        divTIVValue.Visible = pVisible
    End Sub


    Private Sub ClearExistingPrefilterSelection()
        Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        UtilGSafe.ClearSafeSession_ByDataGroup(zSafeGUID, UtilGSafe.KeyNameGroup.ChartPreFilter)
    End Sub


    Private Sub SavePreFilterSelection(pEnumFilter As UtilReporting.ReportFilter, ByRef pJsonFilter As JSONFilter, ByRef pJsonSetting As String, ByRef pJsonVirtual As String)
        Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()

        Select Case pEnumFilter
            Case UtilReporting.ReportFilter.CustomAccess
                UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.ChartPreFilter_CustomAccess, cboCustomAccess.SelectedValue, UtilGSafe.KeyNameGroup.ChartPreFilter)
                If cboCustomAccess.SelectedValue <> "(All)" And cboCustomAccess.SelectedValue <> "" Then
                    pJsonFilter.Filters.Add(New JSONFilterItem("CustomAccess", JSONFilterOperator.Operators.Equal, cboCustomAccess.SelectedValue))
                End If

            Case UtilReporting.ReportFilter.Division
                UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.ChartPreFilter_Division, cboDivision.SelectedValue, UtilGSafe.KeyNameGroup.ChartPreFilter)
                If cboDivision.SelectedValue <> "(All)" And cboDivision.SelectedValue <> "" Then
                    pJsonFilter.Filters.Add(New JSONFilterItem("Division", JSONFilterOperator.Operators.Equal, cboDivision.SelectedValue))
                End If

            Case UtilReporting.ReportFilter.InspectionProgramYear
                UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.ChartPreFilter_InspectionProgramYear, cboInspectionProgramYear.SelectedValue, UtilGSafe.KeyNameGroup.ChartPreFilter)
                If cboInspectionProgramYear.SelectedValue <> "(All)" And cboInspectionProgramYear.SelectedValue <> "" Then
                    'pJsonFilter.Filters.Add(New JSONFilterItem("InspectionProgramYear", JSONFilterOperator.Operators.Equal, cboInspectionProgramYear.SelectedValue))
                    If pJsonVirtual.Length > 0 Then
                        pJsonVirtual = pJsonVirtual & ", ""InspectionProgramYear"":" & cboInspectionProgramYear.SelectedValue
                    Else
                        pJsonVirtual = pJsonVirtual & """InspectionProgramYear"":" & cboInspectionProgramYear.SelectedValue
                    End If
                End If

            Case UtilReporting.ReportFilter.Currency
                UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.ChartPreFilter_Currency, cboCurrency.SelectedValue, UtilGSafe.KeyNameGroup.ChartPreFilter)
                ' NOTE: CANNOT CHANGE THE CURRENCY IN THE GSAFE TO SELECTED, BECAUSE IT WILL RESET ALL CURRENCY OUTPUTS SUCH AS GRIDS
                If cboCurrency.SelectedValue <> "(All)" And cboCurrency.SelectedValue <> "" Then
                    If pJsonSetting.Length > 0 Then
                        pJsonSetting = pJsonSetting & ", ""Currency"":" & cboCurrency.SelectedValue
                    Else
                        pJsonSetting = pJsonSetting & """Currency"":" & cboCurrency.SelectedValue
                    End If
                End If

            Case UtilReporting.ReportFilter.TIV
                UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.ChartPreFilter_TIV, cboTIV.SelectedValue, UtilGSafe.KeyNameGroup.ChartPreFilter)
                If cboTIV.SelectedValue <> "(All)" And cboTIV.SelectedValue <> "" Then
                    pJsonFilter.Filters.Add(New JSONFilterItem("TIV", JSONFilterOperator.Operators.Equal, cboTIV.SelectedValue))
                End If

            Case UtilReporting.ReportFilter.Units
                UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.ChartPreFilter_Units, cboUnits.SelectedValue, UtilGSafe.KeyNameGroup.ChartPreFilter)
                If cboUnits.SelectedValue <> "(All)" And cboUnits.SelectedValue <> "" Then
                    If pJsonSetting.Length > 0 Then
                        pJsonSetting = pJsonSetting & ", ""Unit"":" & cboUnits.SelectedValue
                    Else
                        pJsonSetting = pJsonSetting & """Unit"":" & cboUnits.SelectedValue
                    End If
                End If

            Case UtilReporting.ReportFilter.Status
                UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.ChartPreFilter_Status, cboStatus.SelectedValue, UtilGSafe.KeyNameGroup.ChartPreFilter)
                If cboStatus.SelectedValue <> "(All)" And cboStatus.SelectedValue <> "" Then
                    pJsonFilter.Filters.Add(New JSONFilterItem("Status", JSONFilterOperator.Operators.Equal, cboStatus.SelectedValue))
                End If

            Case UtilReporting.ReportFilter.ImpairmentStartDate
                If Not dteDateFrom.SelectedDate Is Nothing Then
                    UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.ChartPreFilter_DateFrom, dteDateFrom.SelectedDate, UtilGSafe.KeyNameGroup.ChartPreFilter)
                    pJsonFilter.Filters.Add(New JSONFilterItem("ImpStartDateTime", JSONFilterOperator.Operators.GreaterThanEqualTo, dteDateFrom.SelectedDate))
                End If

            Case UtilReporting.ReportFilter.ImpairmentEndDate
                If Not dteDateTo.SelectedDate Is Nothing Then
                    UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.ChartPreFilter_DateTo, dteDateTo.SelectedDate, UtilGSafe.KeyNameGroup.ChartPreFilter)
                    pJsonFilter.Filters.Add(New JSONFilterItem("ImpStartDateTime", JSONFilterOperator.Operators.LessThanEqualTo, dteDateTo.SelectedDate))
                End If

            Case UtilReporting.ReportFilter.Hazard
                UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.ChartPreFilter_Hazard, cboHazard.SelectedValue, UtilGSafe.KeyNameGroup.ChartPreFilter)
                If cboHazard.SelectedValue <> "(All)" And cboHazard.SelectedValue <> "" Then
                    pJsonFilter.Filters.Add(New JSONFilterItem("Hazard", JSONFilterOperator.Operators.Equal, cboHazard.SelectedValue))
                End If

            Case UtilReporting.ReportFilter.Country
                UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.ChartPreFilter_Country, cboCountry.SelectedValue, UtilGSafe.KeyNameGroup.ChartPreFilter)
                If cboCountry.SelectedValue <> "(All)" And cboCountry.SelectedValue <> "" Then
                    pJsonFilter.Filters.Add(New JSONFilterItem("Country", JSONFilterOperator.Operators.Equal, cboCountry.SelectedValue))
                End If

            Case UtilReporting.ReportFilter.TIVValue
                UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.ChartPreFilter_TIVValue, cboTIVValue.SelectedValue, UtilGSafe.KeyNameGroup.ChartPreFilter)
                If cboTIVValue.SelectedValue <> "(All)" And cboTIVValue.SelectedValue <> "" Then
                    'pJsonFilter.Filters.Add(New JSONFilterItem("TIVValue", JSONFilterOperator.Operators.Equal, cboTIVValue.SelectedValue))
                    If pJsonVirtual.Length > 0 Then
                        pJsonVirtual = pJsonVirtual & ", ""TIVValue"":" & cboTIVValue.SelectedValue
                    Else
                        pJsonVirtual = pJsonVirtual & """TIVValue"":" & cboTIVValue.SelectedValue
                    End If
                End If

        End Select
    End Sub

    Private Sub cmdSubmit_Click(sender As Object, e As System.EventArgs) Handles cmdSubmit.Click

        Submit()

    End Sub

    Private Sub Submit()
        Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Dim zGSafeId As Integer = UtilGSafe.GetId(zSafeGUID)

        'Clear existing prefilters
        'Call ClearExistingPrefilterSelection()

        'Save prefilter selections
        Dim zChartId As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.currentChartId)
        'Dim zP2 As String = Request.QueryString("p2")
        'Dim zP3 As String = Request.QueryString("p3")

        'UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.currentReportCode, zChartId, UtilGSafe.KeyNameGroup.Navigation)
        UtilSafe.SaveLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.filterChart, Nothing, zChartId)
        UtilSafe.SaveLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.settingChart, Nothing, zChartId)
        UtilSafe.SaveLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.criteriaChart, Nothing, zChartId)
        Dim zJsonVirtual As String = ""
        Dim zJsonSetting As String = ""
        Dim zJsonFilter As New JSONFilter
        zJsonFilter.Logic = JSONFilterLogic.Operators.And
        Dim zMeta As New UtilMeta
        Dim zPreFilters As List(Of rowVwMetaChartPrefilters) = zMeta.GetPreFiltersCharts(CInt(zChartId))
        Dim zFilterEnum As UtilReporting.ReportFilter
        If UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.ChartPreFilter_RecStatus) = "Active" Then
            zJsonFilter.Filters.Add(New JSONFilterItem("RecStatus", JSONFilterOperator.Operators.NotEqual, "Conf Completed"))
            zJsonFilter.Filters.Add(New JSONFilterItem("RecStatus", JSONFilterOperator.Operators.NotEqual, "Removed"))
        End If
        '  Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)

        'Check to see if User is on a location
        Dim zIsOnDetailsPage As Boolean = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.IsOnDetailPage)
        Dim zNavLinkId As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.NavLinkId)
        Dim zFileNo As String = Nothing 'UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)

        If zIsOnDetailsPage Then
            Dim zNavSlideType As String = UtilNavLink.GetSlideMenuType(Int(zNavLinkId))
            If zNavSlideType = GRC.Connect.Libraries.CoreLib.BusinessObjects.NavLink.SlideMenuTypes.Practice Then
                zFileNo = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)
            End If
        End If

        Dim zPageTitle As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.PageTitle) & ""
        Dim zPageId As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.currentPage) & ""
        If Not zFileNo Is Nothing Then
            If zFileNo <> "" And zPageTitle.ToLower().Contains("site map") = False And zPageId <> "443" Then
                zJsonFilter.Filters.Add(New JSONFilterItem("FileNo", JSONFilterOperator.Operators.Equal, zFileNo))
            Else
                UtilGSafe.SetLocationNavigationInformation(zSafeGUID, zFileNo)
            End If
        End If
        For Each zRow As rowVwMetaChartPrefilters In zPreFilters
            zFilterEnum = zRow.colEnumValue
            Call SavePreFilterSelection(zFilterEnum, zJsonFilter, zJsonSetting, zJsonVirtual)
        Next
        If zJsonFilter.Filters.Count > 0 Then
            Dim zJsonString As String = zJsonFilter.ToJSON
            UtilSafe.SaveLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.filterChart, zJsonString, zChartId)
        End If
        If zJsonSetting.Length < 1 Then
            UtilSafe.SaveLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.settingChart, Nothing, zChartId)
        Else
            zJsonSetting = "{" & zJsonSetting & "}"
            UtilSafe.SaveLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.settingChart, zJsonSetting, zChartId)
        End If
        If zJsonVirtual.Length < 1 Then
            UtilSafe.SaveLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.virtualFilterChart, Nothing, zChartId)
        Else
            zJsonVirtual = "{" & zJsonVirtual & "}"
            UtilSafe.SaveLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.virtualFilterChart, zJsonVirtual, zChartId)
        End If

        ' NAVIGATE TO THE CHART PAGE FETCHER
        UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.ChartPreFilter_BaseUrl, hidChartUrlBase.Value, UtilGSafe.KeyNameGroup.ChartPreFilter)
        Response.Redirect("~/Home_{{VER}}/Charts/ChartFetch.aspx?sid=" & zSafeGUID & "&chartId=" & zChartId)

    End Sub

End Class