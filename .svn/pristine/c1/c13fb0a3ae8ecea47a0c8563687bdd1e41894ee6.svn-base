Imports System.Web
Imports System.Web.Services

Imports GRC.Connect.Libraries.CoreLib.UtilGSafe
Imports GRC.Connect.Libraries.DataLib.razor

Public Class ServeMultiPartChart
    Implements System.Web.IHttpHandler

    Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest

        Dim zGSafeGuid As String = Nothing
        Dim zGSafeId As Integer = Nothing
        Dim zChartId As Integer = Nothing
        Dim zMsgLog As New UtilLog
        Dim zClient As String = ""


        Try
            ' READ DATA
            'zChartId = CInt(context.Request.Form("pChartId") & ".0")
            zGSafeGuid = context.Request.QueryString("gSafeGuid") & ""
            zGSafeId = UtilGSafe.GetId(zGSafeGuid)
            zChartId = CInt(UtilGSafe.GetValue(zGSafeGuid, UtilGSafe.KeyName.currentChartId) & ".0")
            zClient = UtilGSafe.GetValue(zGSafeGuid, UtilGSafe.KeyName.ClientName)

            Dim zDocument As String = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.chartHTML, zChartId)

            ' PDF SETTINGS
            Dim zZoomFactor As String = "1.0"
            If Not context.Request.Form("pZoomFactor") Is Nothing Then
                zZoomFactor = context.Request.Form("pZoomFactor") & ""
            End If
            Dim zOrientation As String = "Landscape"
            Dim zHeight As String = "8.5in"
            Dim zWidth As String = "11in"
            If Not context.Request.Form("pOrientation") Is Nothing Then
                zOrientation = context.Request.Form("pOrientation") & ""
                If zOrientation.ToLower() = "portrait" Then
                    zOrientation = "Portrait"
                    zHeight = "11in"
                    zWidth = "8.5in"
                End If
            End If

            ' BUILD FILE NAME
            'Dim zDateStamp As String = "_" & Format(Now(), "yyyyMMddhhmm")
            'Dim zFileName As String = "PrintedChart_" & zClient & "_" & zDateStamp & ".pdf"
            'Dim zClient As String = ""
            'Dim zChartId As Integer = Nothing
            Dim zReportId As Integer = Nothing
            Dim zReportFileName As String = ""
            Dim zMetaChart As rowTblMetaChart
            Dim zMetaReport As rowTblMetaReport
            Dim zFileName As String = ""
            Dim zDateStamp As String = "_" & Format(Now(), "yyyyMMddhhmm")
            'zGUID = UtilGSafe.GetGUIDFromQueryString()
            'zGSafeId = UtilGSafe.GetId(zGUID)
            zClient = UtilGSafe.GetValue(zGSafeGuid, UtilGSafe.KeyName.ClientName)
            zChartId = UtilGSafe.GetValue(zGSafeGuid, UtilGSafe.KeyName.currentChartId)
            zMetaChart = TblMetaChart.LoadByPrimaryKey(zChartId)
            zReportId = zMetaChart.colFldReportId
            zMetaReport = TblMetaReport.LoadByPrimaryKey(zReportId)
            zReportFileName = zMetaReport.colFldFileName
            zFileName = zReportFileName & "_" & UtilText.RemoveSpecialCharacters(zClient) & zDateStamp & ".pdf"

            ' CONVERT THE DOCUMENT STRING TO A PDF BYTE ARRAY
            ' REMOVED HEIGHT AND WIDTH AS IT WAS NOT ALLOWING LANDSCAPE/PORTRAIT TO WORK
            Dim zResults As Byte() = OpenHtmlToPdf.Pdf.
                From(zDocument).
                WithGlobalSetting("web.enableIntelligentShrinking", False).
                WithGlobalSetting("orientation", zOrientation).
                WithGlobalSetting("size.paperSize", "Letter").
                WithGlobalSetting("margin.top", "0.15in").
                WithGlobalSetting("margin.bottom", "0.15in").
                WithGlobalSetting("margin.right", "0.15in").
                WithGlobalSetting("margin.left", "0.15in").
                WithGlobalSetting("dpi", "100").
                WithGlobalSetting("useCompression", "false").
                WithGlobalSetting("imageQuality", "99").
                WithObjectSetting("web.defaultEncoding", "utf-8").
                WithObjectSetting("header.fontName", "Arial").
                WithObjectSetting("load.zoomFactor", zZoomFactor).
            Content()

            ' DELIVER TO BROWSER
            context.Response.Clear()
            context.Response.ClearContent()
            context.Response.ClearHeaders()
            context.Response.AddHeader("Content-Disposition", "attachment;filename=" & zFileName)
            context.Response.ContentType = "application/pdf"
            context.Response.BinaryWrite(zResults)
            context.Response.Flush()

        Catch ex As System.Threading.ThreadAbortException
            ' THIS IS AN EXPECTED ERROR, THIS CATCH IS DESIGNED TO CONSUME THE ERROR AND CONTINUE

        Catch ex As Exception
            ' OTHER ERROR
            Dim zErrLogError As New UtilErrorLog
            zErrLogError.DateOccured = Now
            zErrLogError.ErrorType = "Serve Multi Part Chart PDF Error"
            zErrLogError.UserEmail = GetValue(GetGUIDFromQueryString, KeyName.LoggedInUserEmail)
            zErrLogError.MessageOuter = ex.Message
            Dim zInnerException As String = Nothing
            If Not ex.InnerException Is Nothing Then zInnerException = ex.InnerException.Message
            zErrLogError.MessageInner = zInnerException
            zErrLogError.ReferringURL = HttpContext.Current.Request.Url.AbsoluteUri
            zErrLogError.ApplicationPage = "ServeMultiPartChart.aspx"
            zErrLogError.StackTraceInner = ex.StackTrace
            Dim zErrorId As Integer = zErrLogError.CreateErrorLogRecord()

            context.Response.Clear()
            context.Response.ClearHeaders()
            context.Response.ClearContent()
            context.Response.Redirect("~/Home_{{VER}}/Error/?sid=" & zGSafeGuid & "&p1=" & zErrorId, False)

        End Try

    End Sub

    ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class