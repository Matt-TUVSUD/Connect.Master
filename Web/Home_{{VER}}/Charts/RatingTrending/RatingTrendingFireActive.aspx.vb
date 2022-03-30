
Imports GRC.Connect.Libraries.CoreLib.BusinessObjects
Imports GRC.Connect.Libraries.CoreLib.UtilGSafe
Imports GRC.Connect.Libraries.DataLib.razor


Public Class Charts_RatingTrendingFireActive
    Inherits System.Web.UI.Page



#Region "Local Variables"
    Public ServerSide_ChartId As String = ""
    Public ServerSide_IsBatchMode As String = "false"
    Public ServerSide_IsDrillDownMode As String = "false"
    Public ServerSide_PageSize As String = "10"
    Public ServerSide_LargeObjectFilter As String = ""
    Public ServerSide_LargeObjectCriteria As String = ""
    Public ServerSide_LargeObjectSetting As String = ""
    Public ServerSide_ChartData As String = ""
    Public ServerSide_ErrorMessage As String = ""
#End Region


#Region "Init"
    Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Init

    End Sub
#End Region


#Region "Data Loading"
    Private Sub loadDefaults()
        Dim zBatchSetId As Integer = 0
        Dim zChartId As String = "0"
        Dim zEmail As String = ""
        Dim zFileNo As String = ""

        Try
            If Not Request.QueryString("batchSetId") Is Nothing Then
                zBatchSetId = CInt(Request.QueryString("batchSetId") & "")
                zEmail = "tblBatchProcessingSet ID = " & Request.QueryString("batchSetId")
                ServerSide_IsBatchMode = "true"
                If Not Request.QueryString("chartId") Is Nothing Then
                    ServerSide_ChartId = Request.QueryString("chartId")
                End If
            Else
                Dim zGSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
                zChartId = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.currentChartId)
                ServerSide_ChartId = zChartId
                If Not Request.QueryString("DrillDown") Is Nothing Then
                    If Request.QueryString("DrillDown").ToLower() = "true" Then
                        ServerSide_IsDrillDownMode = "true"
                        tdParameters.Visible = False
                        tableHeaderContainer.Visible = False
                        trMessageContainer.Visible = False
                        trTipContainer.Visible = False
                        trFooterTableContainer.Visible = False
                    End If
                End If
            End If

        Catch ex As Exception
            ServerSide_ErrorMessage = "Server chart error (loadDefaults()): " & ex.Message
            ServerSide_ErrorMessage = ServerSide_ErrorMessage.Replace("""", "\""")
            ServerSide_ErrorMessage = ServerSide_ErrorMessage.Replace(vbCrLf, " | ")
            Dim zLog As New UtilErrorLog
            zLog.DateOccured = Now
            zLog.ErrorType = "Batch Chart Error (loadDefaults())"
            zLog.UserEmail = zEmail
            zLog.MessageOuter = ex.Message
            Dim zInnerException As String = Nothing
            If Not ex.InnerException Is Nothing Then zInnerException = ex.InnerException.Message
            zLog.MessageInner = zInnerException
            zLog.ReferringURL = HttpContext.Current.Request.Url.AbsoluteUri
            zLog.ApplicationPage = "FacilityScore.aspx.vb"
            zLog.StackTraceInner = ex.StackTrace
            Dim zErrorId As Integer = zLog.CreateErrorLogRecord()

        End Try



    End Sub


    Private Sub loadData()
        Dim zBatchSetId As Integer = 0
        Dim zChartId As Integer = 0
        Dim zEmail As String = ""
        Dim zPageId As Integer = 1
        Try
            Dim zLog As New UtilErrorLog

            If Not Request.QueryString("batchSetId") Is Nothing Then
                ' GET GENERAL INFORMATION
                ServerSide_IsBatchMode = "true"
                zBatchSetId = CInt(Request.QueryString("batchSetId") & "")
                zEmail = "tblBatchProcessingSet ID = " & Request.QueryString("batchSetId")
                If Not Request.QueryString("chartId") Is Nothing Then
                    zChartId = CInt(Request.QueryString("chartId") & "")
                    zEmail = zEmail & " | tblMetaChart ID = " & Request.QueryString("chartId")
                End If
                If Not Request.QueryString("pageId") Is Nothing Then
                    zPageId = CInt(Request.QueryString("pageId") & "")
                    zEmail = zEmail & " | Page No. = " & Request.QueryString("pageId")
                End If

                ' BUILD A CHART
                Dim zChart As New GRC.Connect.Libraries.CoreLib.UtilGDC
                Dim zChartData As New Dictionary(Of String, Object)

                ' GET BATCH REPORT ID
                Dim zReportId As Integer = 0
                Dim zRow As New rowTblMetaChart
                zRow = TblMetaChart.LoadByPrimaryKey(zChartId)
                zReportId = zRow.colFldReportId

                ' GET THE LARGE OBJECT DATA
                Dim zFilter As String = BatchSet.GetSetting(BatchSet.JSONSetting.FilterLO, zBatchSetId)
                Dim zCriteria As String = "" 'BatchSet.GetSetting(BatchSet.JSONSetting.CriteriaLO, zBatchSetId)
                Dim zSetting As String = BatchSet.GetSetting(BatchSet.JSONSetting.SettingLO, zBatchSetId)
                Dim zParameterJSON As String = BatchSet.GetSetting(BatchSet.JSONSetting.Parameter, zBatchSetId)

                ' SET THE PROPERTIES AND GET THE CHART DATA
                Dim zParameterInfo As UtilSQLMaker.ParameterInfo = Newtonsoft.Json.JsonConvert.DeserializeObject(Of UtilSQLMaker.ParameterInfo)(zParameterJSON)
                zChart.PropChartId = zChartId
                zChart.PropBatchSetId = zBatchSetId
                zChart.PropReportSetId = zBatchSetId
                zChart.PropReportId = zReportId
                zChart.PropFilter = zFilter
                zChart.PropCriteria = zCriteria
                zChart.PropPageNumber = zPageId
                zChart.PropPageSize = CInt(ServerSide_PageSize & "")
                zChart.PropSort = "[{""field"":""totalscore"",""dir"":""des""}]"
                zChart.PropParameters.FilePrefix = zParameterInfo.FilePrefix
                zChart.PropParameters.Country = zParameterInfo.Country
                zChart.PropParameters.Division = zParameterInfo.Division
                zChart.PropParameters.CustomAccess = zParameterInfo.CustomAccess
                zChart.PropParameters.TIV = zParameterInfo.TIV
                zChart.PropParameters.Hazard = zParameterInfo.Hazard
                zChart.PropParameters.TIVValue = zParameterInfo.TIVValue
                zChartData = zChart.GetChartData()

                ' BUILD THE JSON STRINGS
                'Dim zJSONSetting As New Newtonsoft.Json.JsonSerializerSettings
                'zJSONSetting.StringEscapeHandling = Newtonsoft.Json.StringEscapeHandling.EscapeHtml
                If Not zChartData Is Nothing Then
                    ServerSide_ChartData = Newtonsoft.Json.JsonConvert.SerializeObject(zChartData)
                    ServerSide_ChartData = ServerSide_ChartData.Replace("""", "\""")
                    ServerSide_ChartData = ServerSide_ChartData.Replace(vbCrLf, " ")
                    ServerSide_ChartData = ServerSide_ChartData.Replace("\r\n", " ")
                    ServerSide_ChartData = ServerSide_ChartData.Replace(Chr(13), " ")
                    ServerSide_ChartData = ServerSide_ChartData.Replace(Chr(10), " ")
                End If
                If Not zFilter Is Nothing Then
                    ServerSide_LargeObjectFilter = zFilter.Replace("""", "\""")
                    ServerSide_LargeObjectFilter = ServerSide_LargeObjectFilter.Replace(vbCrLf, " ")
                End If
                If Not zCriteria Is Nothing Then
                    ServerSide_LargeObjectCriteria = zCriteria.Replace("""", "\""")
                    ServerSide_LargeObjectCriteria = ServerSide_LargeObjectCriteria.Replace(vbCrLf, " ")
                End If
                If Not zSetting Is Nothing Then
                    ServerSide_LargeObjectSetting = zSetting.Replace("""", "\""")
                    ServerSide_LargeObjectSetting = ServerSide_LargeObjectSetting.Replace(vbCrLf, " ")
                End If
            End If

        Catch ex As Exception
            ServerSide_ErrorMessage = "Server chart error (loadData()): " & ex.Message
            ServerSide_ErrorMessage = ServerSide_ErrorMessage.Replace("""", "\""")
            ServerSide_ErrorMessage = ServerSide_ErrorMessage.Replace(vbCrLf, " | ")
            Dim zLog As New UtilErrorLog
            zLog.DateOccured = Now
            zLog.ErrorType = "Batch Chart Error (loadData())"
            zLog.UserEmail = zEmail
            zLog.MessageOuter = ex.Message
            Dim zInnerException As String = Nothing
            If Not ex.InnerException Is Nothing Then zInnerException = ex.InnerException.Message
            zLog.MessageInner = zInnerException
            zLog.ReferringURL = HttpContext.Current.Request.Url.AbsoluteUri
            zLog.ApplicationPage = "Recommendations.aspx.vb"
            zLog.StackTraceInner = ex.StackTrace
            Dim zErrorId As Integer = zLog.CreateErrorLogRecord()

        End Try

    End Sub


    Private Sub loadElements()
        Dim zChartId As String = ServerSide_ChartId
        ' HANDLE HIDING AND SHOWING OF ITEMS IN BATCH MODE
        If ServerSide_IsBatchMode.ToLower() = "true" Then
            'divDrillDownContainer.Visible = False
        Else
            ' FACILITY RATINGS CHART
            If CInt(zChartId) = UtilMeta.GetMetaKey("ChartFireBenchmarkRatingTotalFacilityScoreByLocation", 57) Or _
                CInt(zChartId) = UtilMeta.GetMetaKey("ChartBoilerBenchmarkRatingTotalFacilityScoreByLocation", 58) Then
                tableParameters.Visible = False
            Else
                tableParameters.Visible = True
            End If

            ' HIDE AREAS FOR AIR CHART
            If CInt(zChartId) = UtilMeta.GetMetaKey("ChartFireFacilityAchievableRiskImprovement", 59) Or _
                CInt(zChartId) = UtilMeta.GetMetaKey("ChartBMFacilityAchievableRiskImprovement", 60) Then
                'tableRatingsTable.Visible = False
                tableParameters.Visible = False
            Else
                ' DO NOTHING
            End If


        End If
    End Sub


    Private Sub loadLists()

    End Sub
#End Region

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' TURN ON FOR TESTING BATCH MODE
        'If Request.QueryString("batchSetId") Is Nothing Then
        '    Dim zURI = Request.Url.AbsoluteUri
        '    Response.Redirect(zURI & "&batchSetId=261")
        'End If
        ' END TESTING FOR BATCH MODE

        If Not Page.IsPostBack Then
            Call loadLists()
            Call loadDefaults()
        End If
        Call loadData()
        Call loadElements()
    End Sub


    Protected Sub Page_LoadComplete(ByVal sender As Object, ByVal e As EventArgs) Handles Me.LoadComplete
        'DB - 'Sets the FileNo Gsafe value to empty string when
        GRC.Connect.Libraries.CoreLib.UtilGSafe.ClearGSafeItems(GetGUIDFromQueryString())
    End Sub

End Class