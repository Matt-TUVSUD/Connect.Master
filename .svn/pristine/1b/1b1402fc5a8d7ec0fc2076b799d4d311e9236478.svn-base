Imports GRC.Connect.Libraries.DataLib.razor

Public Class ChartMasterPageRecommendations
    Inherits System.Web.UI.MasterPage


#Region "Local Variables"
    Public ServerSide_CurrencyIdFromPrefilter As String = ""
#End Region


    'Private Sub loadDefaults()
    '    Dim zBatchSetId As Integer = 0
    '    Dim zChartId As String = "0"
    '    Dim zEmail As String = ""
    '    Dim zFileNo As String = ""

    '    Try
    '        ' GET THE CHART ID
    '        If Not Request.QueryString("batchSetId") Is Nothing Then
    '            zBatchSetId = CInt(Request.QueryString("batchSetId") & "")
    '            zEmail = "tblBatchProcessingSet ID = " & Request.QueryString("batchSetId")
    '            If Not Request.QueryString("chartId") Is Nothing Then
    '                zChartId = Request.QueryString("chartId")
    '            End If
    '        Else
    '            Dim zGSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
    '            zChartId = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.currentChartId)
    '        End If

    '        ' SET THE VISIBILITY OF THE FACILITY LEGEND
    '        If Not Request.QueryString("DrillDown") Is Nothing Then
    '            If Request.QueryString("DrillDown").ToLower() = "true" Then
    '                divContainerLegend.Visible = False
    '                divContainerDate.Visible = True
    '            End If
    '        Else
    '            ' CHECK CHART ID
    '            ' IF CHART ID IS IN ONE OF THE FACILITY CHARTS, SHOW THE LEGEND
    '            divContainerLegend.Visible = True
    '            divContainerDate.Visible = False
    '        End If


    '    Catch ex As Exception
    '        Dim zLog As New UtilErrorLog
    '        zLog.DateOccured = Now
    '        zLog.ErrorType = "Batch Chart Error Master (loadDefaults())"
    '        zLog.UserEmail = zEmail
    '        zLog.MessageOuter = ex.Message
    '        Dim zInnerException As String = Nothing
    '        If Not ex.InnerException Is Nothing Then zInnerException = ex.InnerException.Message
    '        zLog.MessageInner = zInnerException
    '        zLog.ReferringURL = HttpContext.Current.Request.Url.AbsoluteUri
    '        zLog.ApplicationPage = "FacilityScore.aspx.vb"
    '        zLog.StackTraceInner = ex.StackTrace
    '        Dim zErrorId As Integer = zLog.CreateErrorLogRecord()

    '    End Try



    'End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' TURN ON FOR TESTING BATCH MODE
        'If Request.QueryString("batchSetId") Is Nothing Then
        '    Dim zURI = Request.Url.AbsoluteUri
        '    Response.Redirect(zURI & "&batchSetId=1148")
        'End If
        ' END TESTING FOR BATCH MODE

        ' DEFAULT VIEW
        tdParameterBuffer.Visible = False

        ' DECLARATIONS
        Dim zGSafeGUID As String = ""
        Dim zGSafeID As Integer = 0
        Dim zChartId As Integer = 0
        Dim zClientName As String = ""
        Dim zInspectionYear As String = ""
        Dim zBatchSetId As Integer = 0
        Dim zCurrency As String = "US Dollar"
        Dim zFilePrefix As String = ""
        Dim zFileNo As String = ""

        ' CONDITIONS
        If Not Request.QueryString("batchSetId") Is Nothing Then
            zBatchSetId = CInt(Request.QueryString("batchSetId") & "")
            If Not Request.QueryString("chartId") Is Nothing Then
                zChartId = CInt(Request.QueryString("chartId") & "")
            End If

            Dim zColl As New List(Of rowVwBatchReportFileList)
            Dim zCmd As New SqlClient.SqlCommand("SELECT TOP 1 * FROM [dbo].[vwBatchReportFileList] WHERE [fldSetId] = @SetId")
            zCmd.Parameters.AddWithValue("@SetId", zBatchSetId)
            zColl = VwBatchReportFileList.LoadData(zCmd)
            If zColl.Count > 0 Then
                zClientName = zColl(0).colClientname
            End If
            tdParameters.Visible = False
            tdParameterBuffer.Visible = True
            spnCurrencyContainer.Visible = False
            spnInspectionYearContainer.Visible = False
            lblARINote.Visible = False

        Else
            zGSafeGUID = UtilGSafe.GetGUIDFromQueryString()
            zGSafeID = UtilGSafe.GetId(zGSafeGUID)
            zFilePrefix = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.FilePreFix)
            zChartId = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.currentChartId)
            zClientName = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.ClientName)

            'IF THERE IS NO PREFILTER CURRENCY SPECIFIED, THEN USE THE USER PREFERENCE
            If UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.ChartPreFilter_Currency) & "".Length > 0 Then
                zCurrency = TblMetaCurrency.GetCurrencyCode(UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.ChartPreFilter_Currency))
                ServerSide_CurrencyIdFromPrefilter = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.ChartPreFilter_Currency)
            Else
                zCurrency = UtilGSafe.GetValue(zGSafeGUID, zFilePrefix, UtilGSafe.PreferenceKeyName.CurrencyDefaultText)
                ServerSide_CurrencyIdFromPrefilter = ""
            End If

            zInspectionYear = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.ChartPreFilter_InspectionProgramYear)
            If Not zInspectionYear Is Nothing Then
                If zInspectionYear.Length > 0 Then
                    Dim zId As Integer = CInt(zInspectionYear)
                    Dim zColl As List(Of rowTblMetaInspectionProgramYear)
                    zColl = TblMetaInspectionProgramYear.LoadData
                    For Each zRow As rowTblMetaInspectionProgramYear In zColl
                        If zRow.colFldId = zId Then
                            spnInspectionYearContainer.Visible = True
                            lblInspectionYearValue.Text = zRow.colFldFilterText
                        End If
                    Next
                Else
                    spnInspectionYearContainer.Visible = False
                End If
            End If
            If Not zCurrency Is Nothing Then
                If zCurrency.Length < 1 Then
                    zCurrency = "USD"
                End If
            Else
                zCurrency = "USD"
            End If
            lblCurrencyValue.Text = zCurrency

            If CInt(zChartId) = UtilMeta.GetMetaKey("ChartFireBenchmarkRatingTotalFacilityScoreByLocation", 57) Or _
                CInt(zChartId) = UtilMeta.GetMetaKey("ChartBoilerBenchmarkRatingTotalFacilityScoreByLocation", 58) Then
                zFileNo = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.FileNo)
                Dim zLocation As String = ""
                Dim zColl As New List(Of rowVwAllLocations)
                Dim zCmd As New SqlClient.SqlCommand("SELECT TOP 1 * FROM [jv].[vwAllLocations] WHERE [FileNo] = @FileNo")
                zCmd.Parameters.AddWithValue("@FileNo", zFileNo)
                zColl = VwAllLocations.LoadData(zCmd)
                If zColl.Count > 0 Then
                    Dim zAddress = zColl(0).colAddress1 & ""
                    Dim zCity = zColl(0).colCity & ""
                    Dim zStProv = zColl(0).colStProv & ""
                    Dim zCountry = zColl(0).colCountry & ""
                    If zAddress.Length > 0 Then zAddress = zAddress & " "
                    If zCity.Length > 0 Then zCity = zCity & ", "
                    If zStProv.Length > 0 Then zStProv = zStProv & ", "
                    zLocation = zAddress & zCity & zStProv & zCountry
                End If
                lblLocationValue.Text = zLocation
                spnLocationContainer.Visible = True
            Else
                spnLocationContainer.Visible = False
            End If

            ' HIDE AREAS FOR AIR CHART
            If CInt(zChartId) = UtilMeta.GetMetaKey("ChartFireFacilityAchievableRiskImprovement", 59) Or _
                CInt(zChartId) = UtilMeta.GetMetaKey("ChartBMFacilityAchievableRiskImprovement", 60) Then
                tdParameters.Visible = False
                tdParameterBuffer.Visible = True
                lblARINote.Visible = True
            Else
                lblARINote.Visible = False
                tdParameterBuffer.Visible = False
                ' DO NOTHING
            End If

        End If

        ' GET META INFORMATION
        Dim zChart As New rowTblMetaChart
        zChart = TblMetaChart.LoadByPrimaryKey(zChartId)

        ' FILL IN PAGE INFORMATION
        Dim zDate = Now()
        lblDate.Text = zDate.ToString("dd-MMM-yyyy")
        lblClient.Text = zClientName
        lblTitle.Text = zChart.colFldTitlePage

        ' IF THIS IS A DRILLDOWN POPUP THEN HIDE ALL OTHER FIELDS
        If Not Request.QueryString("DrillDown") Is Nothing Then
            If Request.QueryString("DrillDown").ToLower() = "true" Then
                trHeaderContainer.Visible = False
                trParameterContainer.Visible = False
                trFooterContainer.Visible = False
                divContainerLegend.Visible = False
                divContainerDate.Visible = True
            End If
        End If

        ' SHOW OR HIDE THE DATE CONTAINER TO MAKE ROOM FOR THE FACILITY SCORE LEGEND
        If CInt(zChartId) = UtilMeta.GetMetaKey("ChartFireBenchmarkRatingTotalFacilityScoreByLocation", 57) Or _
            CInt(zChartId) = UtilMeta.GetMetaKey("ChartBoilerBenchmarkRatingTotalFacilityScoreByLocation", 58) Or _
            CInt(zChartId) = UtilMeta.GetMetaKey("FireBenchmarkRatingTotalFacilityScore", 4) Or _
            CInt(zChartId) = UtilMeta.GetMetaKey("BoilerBenchmarkRatingTotalFacilityScore", 54) Or _
            CInt(zChartId) = UtilMeta.GetMetaKey("FireBenchmarkRatingTotalFacilityScoreByLocation", 57) Or _
            CInt(zChartId) = UtilMeta.GetMetaKey("BoilerBenchmarkRatingTotalFacilityScoreByLocation", 58) Or _
            CInt(zChartId) = UtilMeta.GetMetaKey("ChartFireFacilityAchievableRiskImprovement", 59) Or _
            CInt(zChartId) = UtilMeta.GetMetaKey("ChartBMFacilityAchievableRiskImprovement", 60) Then
            divContainerLegend.Visible = True
            divContainerDate.Visible = False
        End If



    End Sub

End Class