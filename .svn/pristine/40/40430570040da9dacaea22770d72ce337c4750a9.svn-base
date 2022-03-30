'Imports Infragistics.UltraChart.Shared.Events
'Imports Infragistics.WebUI.UltraWebChart
'Imports Infragistics.WebUI.UltraWebGrid
Imports GRC.Connect.Libraries.CoreLib.UtilConstants
Imports GRC.Connect.Libraries.CoreLib.UtilGSafe
Imports GRC.Connect.Libraries.CoreLib.UtilSafe
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports Telerik.Reporting.Charting

Partial Class Charts_AutoRecommendationResponseFollowUpStatus
    Inherits System.Web.UI.Page

#Region "Local Variables"
    Public ServerSide_ErrorMessage As String = ""

#End Region

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Init

    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Call loadLists()
            Call loadElements()
            Call loadDefaults()
        End If

        Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Dim zUserid As Integer = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.EzyLoginId)
        UtilDB.LogOtherActivity(zUserid, "Auto-Rec Response Summary")

        Call loadData()
    End Sub



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
        Dim zGSafeGUID As String = ""
        Dim zGSafeID As Integer = 0
        Dim zBatchSetId As Integer = 0
        Dim zChartId As String = "0"
        Dim zEmail As String = ""
        Dim zInspectionYear As String = ""
        Dim zCurrency As String = "US Dollar"
        Dim zFilePrefix As String = ""

        Try

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

    End Sub

#End Region

End Class
