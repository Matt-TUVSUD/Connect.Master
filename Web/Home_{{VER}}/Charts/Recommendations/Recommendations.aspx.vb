
Imports GRC.Connect.Libraries.CoreLib.BusinessObjects
Imports GRC.Connect.Libraries.CoreLib.UtilGSafe
Imports GRC.Connect.Libraries.BatchLib
Imports GRC.Connect.Libraries.DataLib.razor



Public Class Charts_Recommendations
    Inherits System.Web.UI.Page



#Region "Local Variables"
    Public ServerSide_ChartId As String = ""
    Public ServerSide_IsBatchMode As String = "false"
    Public ServerSide_IsDrillDownMode As String = "false"
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
        Dim zGSafeGUID As String = ""
        Dim zGSafeID As Integer = 0
        Dim zBatchSetId As Integer = 0
        Dim zChartId As String = "0"
        Dim zEmail As String = ""
        Dim zInspectionYear As String = ""
        Dim zCurrency As String = "US Dollar"
        Dim zFilePrefix As String = ""

        Try
            If Not Request.QueryString("batchSetId") Is Nothing Then
                zBatchSetId = CInt(Request.QueryString("batchSetId") & "")
                zEmail = "tblBatchProcessingSet ID = " & Request.QueryString("batchSetId")
                ServerSide_IsBatchMode = "true"
                If Not Request.QueryString("chartId") Is Nothing Then
                    zChartId = CInt(Request.QueryString("batchSetId") & "")
                    ServerSide_ChartId = Request.QueryString("chartId")
                End If

            Else
                zGSafeGUID = UtilGSafe.GetGUIDFromQueryString()
                zGSafeID = UtilGSafe.GetId(zGSafeGUID)
                zChartId = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.currentChartId)
                ServerSide_ChartId = zChartId
                tdParameters.Visible = False
                tdAllRecommendations.Visible = True
                If Not Request.QueryString("DrillDown") Is Nothing Then
                    If Request.QueryString("DrillDown").ToLower() = "true" Then
                        ServerSide_IsDrillDownMode = "true"
                        tdParameters.Visible = False
                        tdAllRecommendations.Visible = False
                        tableHeaderContainer.Visible = False
                        trMessageContainer.Visible = False
                        trTipContainer.Visible = False
                        trFooterTableContainer.Visible = False
                    End If
                End If

            End If

            If Not String.IsNullOrEmpty(Request.QueryString("PrimaryRecTypeFromDrillDown")) Then
                Dim value As String = Request.QueryString("PrimaryRecTypeFromDrillDown")
                UtilGSafe.SetValue(zGSafeGUID, "PrimaryRecTypeFromDrillDown", value, "ChartFilter")
            Else
                UtilGSafe.SetValue(zGSafeGUID, "PrimaryRecTypeFromDrillDown", Nothing, "ChartFilter")
                UtilGSafe.SetValue(zGSafeGUID, UtilGSafe.KeyName.currentChartDrillBackId, zChartId, "Chart")
            End If

            Dim zChart As New rowTblMetaChart
            zChart = TblMetaChart.LoadByPrimaryKey(zChartId)
            ' DO SOMETHING WITH CHART INFO IF NEEDED

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
            zLog.ApplicationPage = "Recommendations.aspx.vb"
            zLog.StackTraceInner = ex.StackTrace
            Dim zErrorId As Integer = zLog.CreateErrorLogRecord()

        End Try

    End Sub


    Private Sub loadData()
        Dim zBatchSetId As Integer = 0
        Dim zChartId As Integer = 0
        Dim zEmail As String = ""

        Try
            If Not Request.QueryString("batchSetId") Is Nothing Then
                ' GET GENERAL INFORMATION
                ServerSide_IsBatchMode = "true"
                zBatchSetId = CInt(Request.QueryString("batchSetId") & "")
                zEmail = "tblBatchProcessingSet ID = " & Request.QueryString("batchSetId")

                If Not Request.QueryString("chartId") Is Nothing Then
                    zChartId = CInt(Request.QueryString("chartId") & "")
                    zEmail = zEmail & " | tblMetaChart ID = " & Request.QueryString("chartId")
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

                ' SET THE PRIMARY REC TYPE IF THIS IS A SECONDARY
                If Not Request.QueryString("PrimaryRecTypeFromDrillDown") Is Nothing Then
                    Dim zPrimaryRecType As String = Request.QueryString("PrimaryRecTypeFromDrillDown")
                    Dim zJsonCriteria As New JSONFilter
                    zJsonCriteria.Filters.Add(New JSONFilterItem("PrimaryRecType", JSONFilterOperator.Operators.Equal, zPrimaryRecType))
                    Dim zJsonCriteriaString As String = zJsonCriteria.ToJSON
                    zCriteria = zJsonCriteriaString
                End If

                ' SET THE PROPERTIES AND GET THE CHART DATA
                Dim zParameterInfo As UtilSQLMaker.ParameterInfo = Newtonsoft.Json.JsonConvert.DeserializeObject(Of UtilSQLMaker.ParameterInfo)(zParameterJSON)
                zChart.PropChartId = zChartId
                zChart.PropBatchSetId = zBatchSetId
                zChart.PropReportSetId = zBatchSetId
                zChart.PropReportId = zReportId
                zChart.PropFilter = zFilter
                zChart.PropCriteria = zCriteria
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


    Private Sub loadLists()

    End Sub


    Private Sub loadElements()
        Dim zChartId As String = ServerSide_ChartId

        ' HANDLE HIDING AND SHOWING OF ITEMS IN BATCH MODE
        If ServerSide_IsBatchMode.ToLower() = "true" Then
            divDrillDownContainer.Visible = False
            tdParameters.Visible = False
        Else
            ' DO NOTHING
        End If

        ' IF THIS IS A DRILLDOWN POPUP THEN HIDE ALL OTHER FIELDS
        If Not Request.QueryString("DrillDown") Is Nothing Then
            If Request.QueryString("DrillDown").ToLower() = "true" Then
            End If
        End If

        ' SHOW LEGENDS
        Select Case ServerSide_ChartId
            Case "42", "43", "44", "45", "46", "47"
                tdImpactLegend.Visible = True
            Case Else
                tdImpactLegend.Visible = False
        End Select

    End Sub

#End Region


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' TURN ON FOR TESTING BATCH MODE
        'If Request.QueryString("batchSetId") Is Nothing Then
        '    Dim zURI = Request.Url.AbsoluteUri
        '    Response.Redirect(zURI & "&batchSetId=36")
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

    End Sub


    Protected Sub cmdAllRecommendations_Click(sender As Object, e As EventArgs) Handles cmdAllRecommendations.Click
        Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Dim zSafeId As Integer = UtilGSafe.GetId(zSafeGUID)

        Dim zChartId As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.currentChartId)
        Dim zGridId As String = "171"

        ' FIND THE PRACTICE OF THE CURRENT CHART
        Dim zRow As New rowTblMetaChart
        zRow = TblMetaChart.LoadByPrimaryKey(zChartId)

        ' CHARTS ALL
        '1:		FireLossPreventionRecommendations
        '11:	NatHazWindLossPreventionRecommendations
        '16:	NatHazFloodLossPreventionRecommendations
        '20:	NatHazSeismicLossPreventionRecommendations
        '23:	IRLossPreventionRecommendations
        '31:	BMLossPreventionRecommendations

        ' CHARTS ACTIVE
        ' 42, 56, 43, 55, 44, 45, 46, 17

        ' GRIDS ALL
        '169:    BMRecommendationsAll()
        '171:    FireRecommendationsAll()
        '173:    IRRecommendationsAll()
        '175:    NatHazFloodRecommendationsAll()
        '177:    NatHazSeismicRecommendationsAll()
        '179:    NatHazWindRecommendationsAll()

        ' GRIDS ACTIVE
        ' 170, 168, 172, 178, 176, 174

        'SELECT * fldReportId
        'FROM tblMetaChart
        'WHERE (fldId IN (1, 42, 56, 31, 43, 55, 23, 44, 20, 45, 16, 46, 11, 17)) -- THIS FINDS ALL CHARTS THAT ARE ACTIVE INSTEAD OF ALL

        ' SET THE URL GRID ID, ACTIVE CHART GO TO ACTIVE GRID, ALL CHART GO TO ALL GRID
        Dim zURL As String = ""
        Dim zSubTitle As String = zRow.colFldTitlePageSub & ""
        If zSubTitle.ToLower().Contains("active") Then
            Select Case True
                Case zRow.colFldChartName.ToLower().Contains("fire")
                    zGridId = "170"
                Case zRow.colFldChartName.ToLower().Contains("bm")
                    zGridId = "168"
                Case zRow.colFldChartName.ToLower().Contains("boiler")
                    zGridId = "168"
                Case zRow.colFldChartName.ToLower().Contains("infrared")
                    zGridId = "172"
                Case zRow.colFldChartName.ToLower().Contains("wind")
                    zGridId = "178"
                Case zRow.colFldChartName.ToLower().Contains("seismic")
                    zGridId = "176"
                Case zRow.colFldChartName.ToLower().Contains("flood")
                    zGridId = "174"
                Case Else
                    zGridId = "172" 'IR
            End Select
            zURL = "~/Home_{{VER}}/Filter/Default.aspx?sid=" & zSafeGUID & "&gridId=" & zGridId
        Else
            Select Case True
                Case zRow.colFldChartName.ToLower().Contains("fire")
                    zGridId = "171"
                Case zRow.colFldChartName.ToLower().Contains("bm")
                    zGridId = "169"
                Case zRow.colFldChartName.ToLower().Contains("boiler")
                    zGridId = "169"
                Case zRow.colFldChartName.ToLower().Contains("infrared")
                    zGridId = "173"
                Case zRow.colFldChartName.ToLower().Contains("wind")
                    zGridId = "179"
                Case zRow.colFldChartName.ToLower().Contains("seismic")
                    zGridId = "177"
                Case zRow.colFldChartName.ToLower().Contains("flood")
                    zGridId = "175"
                Case Else
                    zGridId = "173" 'IR
            End Select
            zURL = "~/Home_{{VER}}/Filter/Default.aspx?sid=" & zSafeGUID & "&gridId=" & zGridId
        End If

        ' GET CRITERIA AND FILTER INFORMATION AND SET THEM FOR NAVIGATING TO THE GRID
        Dim zChartFilter As String = UtilSafe.LoadLargeObjectData_ByDataGroup(zSafeId, UtilSafe.LargeObjectName.filterChart, zChartId)
        Dim zChartCriteria As String = ""
        Dim zPrimaryRecType As String = Request.QueryString("PrimaryRecTypeFromDrillDown") & ""
        If zPrimaryRecType.Length > 0 Then
            Dim zJsonFilter As New JSONFilter
            zJsonFilter.Filters.Add(New JSONFilterItem("PrimaryRecType", JSONFilterOperator.Operators.Equal, zPrimaryRecType))
            zChartCriteria = zJsonFilter.ToJSON
        End If
        UtilSafe.SaveLargeObjectData_ByDataGroup(zSafeId, UtilSafe.LargeObjectName.filter, zChartFilter, zGridId)
        UtilSafe.SaveLargeObjectData_ByDataGroup(zSafeId, UtilSafe.LargeObjectName.criteriaPrimary, zChartCriteria, zGridId)

        ' REDIRECT
        Response.Redirect(zURL, False)
    End Sub


    Protected Sub cmdDrillBacks_Click(sender As Object, e As EventArgs) Handles cmdDrillBacks.Click
        Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Dim zSafeID As String = UtilGSafe.GetId(zSafeGUID)
        Dim zChartId = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.currentChartDrillBackId)
        If Not zChartId Is Nothing Then
            UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.currentChartId, zChartId, "Chart")
            If zChartId.Length > 0 Then
                zChartId = "&chartId=" & zChartId
                Dim zURL As String = "~/Home_{{VER}}/Charts/Recommendations/Recommendations.aspx?sid=" & zSafeGUID & zChartId
                Response.Redirect(zURL, True)
            End If
        End If
    End Sub
End Class