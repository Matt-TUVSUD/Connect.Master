Imports GRC.Connect.Libraries.DataLib.razor

Public Class PreFilter
    Inherits System.Web.UI.Page


    Public LevelsDeep As Integer = 0

    Private Sub LoadDefaults()
        Call SetDivAllVisible(False)

        Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Dim zReportId As Integer = GetReportIdFromGSafe(zSafeGUID)

        Dim zMeta As New UtilMeta
        Dim zPreFilters As List(Of rowVwMetaReportPrefilters) = zMeta.GetPreFiltersReports(CInt(zReportId))
        Dim zFilterEnum As UtilReporting.ReportFilter
        For Each zRow As rowVwMetaReportPrefilters In zPreFilters
            zFilterEnum = zRow.colEnumValue
            Call SetDivVisible(zFilterEnum, True)
            Call LoadUserSelectionList(zFilterEnum)
            Call SetValueFromUserPreferences(zFilterEnum)
        Next

        ' LOAD THE CUSTOM ACCESS CUSTOM LABEL
        Dim zCustomAccessLabel = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.CustomAccessLabel)
        If zCustomAccessLabel.ToLower() <> "Not Used".ToLower() Then
            lblCustomAccess.Text = zCustomAccessLabel
        Else
            lblCustomAccess.Text = "Custom Access"
        End If

        ' If MetaChartPrefilters List is empty call Submit() to simulate user clicking Submit
        If zPreFilters.Count = 0 Then Submit()
        If Request.QueryString("SubmitOnOpen") = 1 Then
            Submit()
        End If

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

        LevelsDeep = Request.QueryString("levels")
        Call LoadData()
    End Sub


    Private Sub SetValueFromUserPreferences(pEnumFilter As UtilReporting.ReportFilter)
        Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Dim zFilePrefix As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FilePreFix)

        Select Case pEnumFilter
            Case Libraries.CoreLib.UtilReporting.ReportFilter.Currency
                ' SET EACH COMBOBOX TO THE DEFAULT SAVED IN THE GSAFE TABLE
                ' CURRENCY
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

            Case Libraries.CoreLib.UtilReporting.ReportFilter.Units
                ' UNITS
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


            Case Libraries.CoreLib.UtilReporting.ReportFilter.InspectionProgramYear
                'LOAD LIST FOR INSPECTION PROGRAM YEAR
                cboInspectionProgramYear.Items.Clear()
                Dim zColl As List(Of rowTblMetaInspectionProgramYear)
                zColl = TblMetaInspectionProgramYear.LoadData
                For Each zRow As rowTblMetaInspectionProgramYear In zColl
                    cboInspectionProgramYear.Items.Add(New Telerik.Web.UI.RadComboBoxItem(zRow.colFldFilterText, zRow.colFldId))
                Next
                'cboInspectionProgramYear.Items.Add(New Telerik.Web.UI.RadComboBoxItem(FilterValuesInspectionProgramYear.All, FilterValuesInspectionProgramYearParms.All))
                'cboInspectionProgramYear.Items.Add(New Telerik.Web.UI.RadComboBoxItem(FilterValuesInspectionProgramYear.LatestRatings, FilterValuesInspectionProgramYearParms.LatestRatings))
                'cboInspectionProgramYear.Items.Add(New Telerik.Web.UI.RadComboBoxItem(FilterValuesInspectionProgramYear.CurrentPeriod, FilterValuesInspectionProgramYearParms.CurrentPeriod))
                'cboInspectionProgramYear.Items.Add(New Telerik.Web.UI.RadComboBoxItem(FilterValuesInspectionProgramYear.PreviousPeriod, FilterValuesInspectionProgramYearParms.PreviousPeriod))
                'cboInspectionProgramYear.Items.Add(New Telerik.Web.UI.RadComboBoxItem(FilterValuesInspectionProgramYear.TwoPreviousPeriods, FilterValuesInspectionProgramYearParms.TwoPreviousPeriods))

            Case Libraries.CoreLib.UtilReporting.ReportFilter.Currency
                'LOAD LIST FOR CURRENCY
                cboCurrency.Items.Clear()
                Dim zColl As List(Of rowTblMetaCurrency)
                zColl = TblMetaCurrency.LoadData
                For Each zRow As rowTblMetaCurrency In zColl
                    cboCurrency.Items.Add(New Telerik.Web.UI.RadComboBoxItem(zRow.colFldName, zRow.colFldId))
                Next

            Case Libraries.CoreLib.UtilReporting.ReportFilter.Units
                'LOAD LIST FOR UNITS
                cboUnits.Items.Clear()
                Dim zColl As List(Of rowTblMetaUnitSystem)
                zColl = TblMetaUnitSystem.LoadData
                For Each zRow As rowTblMetaUnitSystem In zColl
                    cboUnits.Items.Add(New Telerik.Web.UI.RadComboBoxItem(zRow.colFldName, zRow.colFldId))
                Next

            Case Libraries.CoreLib.UtilReporting.ReportFilter.Status
                'LOAD LIST FOR STATUS
                cboStatus.Items.Add(New Telerik.Web.UI.RadComboBoxItem(FilterValuesStatus.All, FilterValuesStatus.All))

            Case Libraries.CoreLib.UtilReporting.ReportFilter.ImpairmentStartDate

            Case Libraries.CoreLib.UtilReporting.ReportFilter.ImpairmentEndDate

            Case Libraries.CoreLib.UtilReporting.ReportFilter.Hazard
                'LOAD LIST FOR HAZARD
                cboHazard.Items.Clear()
                Dim zColl As List(Of rowTblMetaPractice)
                zColl = TblMetaPractice.LoadData
                For Each zRow As rowTblMetaPractice In zColl
                    cboHazard.Items.Add(New Telerik.Web.UI.RadComboBoxItem(zRow.colFldReportDisplayTitle, zRow.colFldFilterValue))
                Next
                'cboHazard.Items.Add(New Telerik.Web.UI.RadComboBoxItem(FilterValuesHazard.All, FilterValuesHazardParms.All))
                'cboHazard.Items.Add(New Telerik.Web.UI.RadComboBoxItem(FilterValuesHazard.Fire, FilterValuesHazardParms.Fire))
                'cboHazard.Items.Add(New Telerik.Web.UI.RadComboBoxItem(FilterValuesHazard.Seismic, FilterValuesHazardParms.Seismic))
                'cboHazard.Items.Add(New Telerik.Web.UI.RadComboBoxItem(FilterValuesHazard.Wind, FilterValuesHazardParms.Wind))
                'cboHazard.Items.Add(New Telerik.Web.UI.RadComboBoxItem(FilterValuesHazard.Flood, FilterValuesHazardParms.Flood))

            Case Libraries.CoreLib.UtilReporting.ReportFilter.Country
                'LOAD LIST FOR COUNTRY
                Dim zGsafeGuid As String = UtilGSafe.GetGUIDFromQueryString()
                Dim zClientName As String = UtilGSafe.GetValue(zGsafeGuid, UtilGSafe.KeyName.ClientName)
                cboCountry.Items.Clear()
                cboCountry.Items.Add(New Telerik.Web.UI.RadComboBoxItem("(All)", "(All)"))
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

            Case Libraries.CoreLib.UtilReporting.ReportFilter.TIV
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

            Case Libraries.CoreLib.UtilReporting.ReportFilter.TIVValue
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
            Case Libraries.CoreLib.UtilReporting.ReportFilter.CustomAccess
                divCustomAccess.Visible = pVisible
            Case Libraries.CoreLib.UtilReporting.ReportFilter.Division
                divDivision.Visible = pVisible
            Case Libraries.CoreLib.UtilReporting.ReportFilter.InspectionProgramYear
                divInspectionProgramYear.Visible = pVisible
                'Case Libraries.CoreLib.UtilReporting.ReportFilter.ConvertCurrency
                '    divConvertCurrency.Visible = pVisible
            Case Libraries.CoreLib.UtilReporting.ReportFilter.Currency
                divCurrency.Visible = pVisible
            Case Libraries.CoreLib.UtilReporting.ReportFilter.TIV
                divTIV.Visible = pVisible
                'Case Libraries.CoreLib.UtilReporting.ReportFilter.ConvertUnits
                '    divConvertUnits.Visible = pVisible
            Case Libraries.CoreLib.UtilReporting.ReportFilter.Units
                divUnits.Visible = pVisible
            Case Libraries.CoreLib.UtilReporting.ReportFilter.Status
                divStatus.Visible = pVisible
            Case Libraries.CoreLib.UtilReporting.ReportFilter.ImpairmentStartDate
                divDateFrom.Visible = pVisible
            Case Libraries.CoreLib.UtilReporting.ReportFilter.ImpairmentEndDate
                divDateTo.Visible = pVisible
            Case Libraries.CoreLib.UtilReporting.ReportFilter.Hazard
                divHazard.Visible = pVisible
            Case Libraries.CoreLib.UtilReporting.ReportFilter.Country
                divCountry.Visible = pVisible
            Case Libraries.CoreLib.UtilReporting.ReportFilter.TIVValue
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
        Libraries.CoreLib.UtilGSafe.ClearSafeSession_ByDataGroup(zSafeGUID, UtilGSafe.KeyNameGroup.ReportPreFilter)
    End Sub


    Private Sub SavePreFilterSelection(pEnumFilter As UtilReporting.ReportFilter, ByRef pJsonFilter As JSONFilter, ByRef pJsonSetting As String, ByRef pJsonVirtual As String)
        Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()

        Select Case pEnumFilter
            Case Libraries.CoreLib.UtilReporting.ReportFilter.CustomAccess
                UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.ReportPreFilter_CustomAccess, cboCustomAccess.SelectedValue, UtilGSafe.KeyNameGroup.ReportPreFilter)
                If cboCustomAccess.SelectedValue <> "(All)" And cboCustomAccess.SelectedValue <> "" Then
                    pJsonFilter.Filters.Add(New JSONFilterItem("CustomAccess", JSONFilterOperator.Operators.Equal, cboCustomAccess.SelectedValue))
                End If

            Case Libraries.CoreLib.UtilReporting.ReportFilter.Division
                UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.ReportPreFilter_Division, cboDivision.SelectedValue, UtilGSafe.KeyNameGroup.ReportPreFilter)
                If cboDivision.SelectedValue <> "(All)" And cboDivision.SelectedValue <> "" Then
                    pJsonFilter.Filters.Add(New JSONFilterItem("Division", JSONFilterOperator.Operators.Equal, cboDivision.SelectedValue))
                End If

            Case Libraries.CoreLib.UtilReporting.ReportFilter.InspectionProgramYear
                UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.ReportPreFilter_InspectionProgramYear, cboInspectionProgramYear.SelectedValue, UtilGSafe.KeyNameGroup.ReportPreFilter)
                If cboInspectionProgramYear.SelectedValue <> "(All)" And cboInspectionProgramYear.SelectedValue <> "" Then
                    'pJsonFilter.Filters.Add(New JSONFilterItem("InspectionProgramYear", JSONFilterOperator.Operators.Equal, cboInspectionProgramYear.SelectedValue))
                    If pJsonVirtual.Length > 0 Then
                        pJsonVirtual = pJsonVirtual & ", ""InspectionProgramYear"":" & cboInspectionProgramYear.SelectedValue
                    Else
                        pJsonVirtual = pJsonVirtual & """InspectionProgramYear"":" & cboInspectionProgramYear.SelectedValue
                    End If
                End If

            Case Libraries.CoreLib.UtilReporting.ReportFilter.Currency
                UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.ReportPreFilter_Currency, cboCurrency.SelectedValue, UtilGSafe.KeyNameGroup.ReportPreFilter)
                ' NOTE: CANNOT CHANGE THE CURRENCY IN THE GSAFE TO SELECTED, BECAUSE IT WILL RESET ALL CURRENCY OUTPUTS SUCH AS GRIDS
                If cboCurrency.SelectedValue <> "(All)" And cboCurrency.SelectedValue <> "" Then
                    If pJsonSetting.Length > 0 Then
                        pJsonSetting = pJsonSetting & ", ""Currency"":" & cboCurrency.SelectedValue
                    Else
                        pJsonSetting = pJsonSetting & """Currency"":" & cboCurrency.SelectedValue
                    End If
                End If

            Case Libraries.CoreLib.UtilReporting.ReportFilter.TIV
                UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.ReportPreFilter_TIV, cboTIV.SelectedValue, UtilGSafe.KeyNameGroup.ReportPreFilter)
                If cboTIV.SelectedValue <> "(All)" And cboTIV.SelectedValue <> "" Then
                    pJsonFilter.Filters.Add(New JSONFilterItem("TIV", JSONFilterOperator.Operators.Equal, cboTIV.SelectedValue))
                End If

            Case Libraries.CoreLib.UtilReporting.ReportFilter.Units
                UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.ReportPreFilter_Units, cboUnits.SelectedValue, UtilGSafe.KeyNameGroup.ReportPreFilter)
                If cboUnits.SelectedValue <> "(All)" And cboUnits.SelectedValue <> "" Then
                    If pJsonSetting.Length > 0 Then
                        pJsonSetting = pJsonSetting & ", ""Unit"":" & cboUnits.SelectedValue
                    Else
                        pJsonSetting = pJsonSetting & """Unit"":" & cboUnits.SelectedValue
                    End If
                End If

            Case Libraries.CoreLib.UtilReporting.ReportFilter.Status
                UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.ReportPreFilter_Status, cboStatus.SelectedValue, UtilGSafe.KeyNameGroup.ReportPreFilter)
                If cboStatus.SelectedValue <> "(All)" And cboStatus.SelectedValue <> "" Then
                    pJsonFilter.Filters.Add(New JSONFilterItem("Status", JSONFilterOperator.Operators.Equal, cboStatus.SelectedValue))
                End If

            Case Libraries.CoreLib.UtilReporting.ReportFilter.ImpairmentStartDate
                If Not dteDateFrom.SelectedDate Is Nothing Then
                    UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.ReportPreFilter_DateFrom, dteDateFrom.SelectedDate, UtilGSafe.KeyNameGroup.ReportPreFilter)
                    pJsonFilter.Filters.Add(New JSONFilterItem("ImpStartDateTime", JSONFilterOperator.Operators.GreaterThanEqualTo, dteDateFrom.SelectedDate))
                End If

            Case Libraries.CoreLib.UtilReporting.ReportFilter.ImpairmentEndDate
                If Not dteDateTo.SelectedDate Is Nothing Then
                    UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.ReportPreFilter_DateTo, dteDateTo.SelectedDate, UtilGSafe.KeyNameGroup.ReportPreFilter)
                    pJsonFilter.Filters.Add(New JSONFilterItem("ImpStartDateTime", JSONFilterOperator.Operators.LessThanEqualTo, dteDateTo.SelectedDate))
                End If

            Case Libraries.CoreLib.UtilReporting.ReportFilter.Hazard
                UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.ReportPreFilter_Hazard, cboHazard.SelectedValue, UtilGSafe.KeyNameGroup.ReportPreFilter)
                If cboHazard.SelectedValue <> "(All)" And cboHazard.SelectedValue <> "" Then
                    pJsonFilter.Filters.Add(New JSONFilterItem("Hazard", JSONFilterOperator.Operators.Equal, cboHazard.SelectedValue))
                End If

            Case Libraries.CoreLib.UtilReporting.ReportFilter.Country
                UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.ReportPreFilter_Country, cboCountry.SelectedValue, UtilGSafe.KeyNameGroup.ReportPreFilter)
                If cboCountry.SelectedValue <> "(All)" And cboCountry.SelectedValue <> "" Then
                    pJsonFilter.Filters.Add(New JSONFilterItem("Country", JSONFilterOperator.Operators.Equal, cboCountry.SelectedValue))
                End If

            Case Libraries.CoreLib.UtilReporting.ReportFilter.TIVValue
                UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.ReportPreFilter_TIVValue, cboTIVValue.SelectedValue, UtilGSafe.KeyNameGroup.ReportPreFilter)
                If cboTIVValue.SelectedValue <> "(All)" And cboTIVValue.SelectedValue <> "" Then
                    'pJsonFilter.Filters.Add(New JSONFilterItem("TIVValue", JSONFilterOperator.Operators.Equal, cboTIVValue.SelectedValue))
                    If pJsonVirtual.Length > 0 Then
                        pJsonVirtual = pJsonVirtual & ", ""TIVValue"":" & cboUnits.SelectedValue
                    Else
                        pJsonVirtual = pJsonVirtual & """TIVValue"":" & cboUnits.SelectedValue
                    End If
                End If

        End Select
    End Sub

    Private Function GetReportIdFromGSafe(pGuid As String) As Integer
        Return UtilGSafe.GetValue(pGuid, UtilGSafe.KeyName.currentReportCode)
    End Function

    Private Sub cmdSubmit_Click(sender As Object, e As System.EventArgs) Handles cmdSubmit.Click
        Submit()

        'Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        'Dim zGSafeId As Integer = UtilGSafe.GetId(zSafeGUID)

        ''Clear existing prefilters
        'Call ClearExistingPrefilterSelection()

        ''Save prefilter selections
        'Dim zRptCode As String = Request.QueryString("rptCode")
        'Dim zP2 As String = Request.QueryString("p2")
        'Dim zP3 As String = Request.QueryString("p3")

        'UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.currentReportCode, zRptCode, UtilGSafe.KeyNameGroup.Navigation)

        'UtilSafe.SaveLargeObjectData_ByDataGroup(zGSafeId, "filter", Nothing, zRptCode)
        'Dim zJsonVirtual As String = ""
        'Dim zJsonSetting As String = ""
        'Dim zJsonFilter As New JSONFilter
        'zJsonFilter.Logic = JSONFilterLogic.Operators.And
        'Dim zMeta As New UtilMeta
        'Dim zPreFilters As List(Of rowVwMetaReportPrefilters) = zMeta.GetPreFiltersReports(CInt(zRptCode))
        'Dim zFilterEnum As UtilReporting.ReportFilter
        'For Each zRow As rowVwMetaReportPrefilters In zPreFilters
        '    zFilterEnum = zRow.colEnumValue
        '    Call SavePreFilterSelection(zFilterEnum, zJsonFilter, zJsonSetting, zJsonVirtual)
        'Next
        'If zJsonFilter.Filters.Count > 0 Then
        '    Dim zJsonString As String = zJsonFilter.ToJSON
        '    UtilSafe.SaveLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.filter, zJsonString, zRptCode)
        'End If
        'If zJsonSetting.Length < 1 Then
        '    UtilSafe.SaveLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.setting, Nothing, zRptCode)
        'Else
        '    zJsonSetting = "{" & zJsonSetting & "}"
        '    UtilSafe.SaveLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.setting, zJsonSetting, zRptCode)
        'End If
        'If zJsonVirtual.Length < 1 Then
        '    UtilSafe.SaveLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.virtualFilter, Nothing, zRptCode)
        'Else
        '    zJsonVirtual = "{" & zJsonVirtual & "}"
        '    UtilSafe.SaveLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.virtualFilter, zJsonVirtual, zRptCode)
        'End If

        'Response.Redirect("~/Home_{{VER}}/Reports/ReportFetch.aspx?gSafeGuid=" & zSafeGUID & "&rptCode=" & zRptCode & "&p2=" & zP2 & "&p3=" & zP3, False)

        ''If zP3.ToLower = "practice" Then
        ''    'Response.Redirect("~/Service/ReportServer/PracticeReport.aspx?sid=" & zSafeGUID & "&rptCode=" & zRptCode & "&p2=" & zP2, False)
        ''    Response.Redirect("~/Home_{{VER}}/FD/ServeReport.ashx?gSafeGuid=" & zSafeGUID & "&rptCode=" & zRptCode & "&p2=" & zP2, False)
        ''Else
        ''    'Response.Redirect("~/Service/ReportServer/SingleReport.aspx?sid=" & zSafeGUID & "&rptCode=" & zRptCode & "&p2=" & zP2, False)
        ''    Response.Redirect("~/Home_{{VER}}/FD/ServeReport.ashx?gSafeGuid=" & zSafeGUID & "&rptCode=" & zRptCode & "&p2=" & zP2, False)
        ''End If
    End Sub

    Private Sub Submit()
        Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Dim zGSafeId As Integer = UtilGSafe.GetId(zSafeGUID)
        Dim zReportId As Integer = GetReportIdFromGSafe(zSafeGUID)

        'Clear existing prefilters
        Call ClearExistingPrefilterSelection()

        UtilSafe.SaveLargeObjectData_ByDataGroup(zGSafeId, "filter", Nothing, zReportId)
        Dim zJsonVirtual As String = ""
        Dim zJsonSetting As String = ""
        Dim zJsonFilter As New JSONFilter
        zJsonFilter.Logic = JSONFilterLogic.Operators.And
        Dim zMeta As New UtilMeta
        Dim zPreFilters As List(Of rowVwMetaReportPrefilters) = zMeta.GetPreFiltersReports(CInt(zReportId))
        Dim zFilterEnum As UtilReporting.ReportFilter
        For Each zRow As rowVwMetaReportPrefilters In zPreFilters
            zFilterEnum = zRow.colEnumValue
            Call SavePreFilterSelection(zFilterEnum, zJsonFilter, zJsonSetting, zJsonVirtual)
        Next
        If zJsonFilter.Filters.Count > 0 Then
            Dim zJsonString As String = zJsonFilter.ToJSON
            UtilSafe.SaveLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.filter, zJsonString, zReportId)
        End If
        If zJsonSetting.Length < 1 Then
            UtilSafe.SaveLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.setting, Nothing, zReportId)
        Else
            zJsonSetting = "{" & zJsonSetting & "}"
            UtilSafe.SaveLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.setting, zJsonSetting, zReportId)
        End If
        If zJsonVirtual.Length < 1 Then
            UtilSafe.SaveLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.virtualFilter, Nothing, zReportId)
        Else
            zJsonVirtual = "{" & zJsonVirtual & "}"
            UtilSafe.SaveLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.virtualFilter, zJsonVirtual, zReportId)
        End If

        Response.Redirect("ReportFetch.aspx?" & Request.QueryString.ToString) '"&rptCode=" & zRptCode & "&p2=" & zP2 & "&p3=" & zP3, False)

    End Sub

End Class