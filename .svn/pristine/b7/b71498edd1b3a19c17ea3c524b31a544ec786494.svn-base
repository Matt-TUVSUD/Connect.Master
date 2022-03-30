Imports System.Web
Imports System.Web.Services
Imports GRC.Connect.Libraries.CoreLib.UtilGSafe
Imports GRC.Connect.Libraries.DataLib.razor

Public Class ServeHTMLToPDF
    Implements System.Web.IHttpHandler

    Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        Dim zGUID As String = Nothing
        Dim zGSafeId As Integer = Nothing
        Dim zMsgLog As New UtilLog
        Try
            ' READ DATA
            Dim zHTML As String = context.Request.Form("pHTML") & ""
            Dim zCSS As String = context.Request.Form("pCSS") & ""
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
            Dim zFileNameParm As String = Nothing
            If Not context.Request.Form("pFileNameParm") Is Nothing Then
                zFileNameParm = context.Request.Form("pFileNameParm") & ""
            End If

            ' REBUILD ILLEGAL CHARACTERS
            zHTML = Replace(zHTML, "||OPEN||", "<")
            zHTML = Replace(zHTML, "||CLOSE||", ">")
            zHTML = Replace(zHTML, "  ", "")

            ' BUILD FILE NAME
            Dim zClient As String = ""
            Dim zChartId As Integer = Nothing
            Dim zReportId As Integer = Nothing
            Dim zReportFileName As String = ""
            Dim zMetaChart As rowTblMetaChart
            Dim zMetaReport As rowTblMetaReport
            Dim zFileName As String = ""
            Dim zDateStamp As String = "_" & Format(Now(), "yyyyMMddhhmm")
            zGUID = UtilGSafe.GetGUIDFromQueryString()
            zGSafeId = UtilGSafe.GetId(zGUID)
            zClient = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.ClientName)

            ' CONFIGURE THE FILE NAME
            If zFileNameParm Is Nothing Then
                If Not context.Request.QueryString("reportId") Is Nothing Then
                    ' DIRECT REPORTS FROM PASSED ID
                    zReportId = CInt(Val(context.Request.QueryString("reportId")))
                Else
                    ' REPORTS CALLED FROM CHARTS
                    zChartId = CInt(Val(UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.currentChartId)))
                    zMetaChart = TblMetaChart.LoadByPrimaryKey(zChartId)
                    zReportId = zMetaChart.colFldReportId
                End If
                zMetaReport = TblMetaReport.LoadByPrimaryKey(zReportId)
                zReportFileName = zMetaReport.colFldFileName
                zFileName = zReportFileName & "_" & UtilText.RemoveSpecialCharacters(zClient) & zDateStamp & ".pdf"
            Else
                zFileName = zFileNameParm & "_" & UtilText.RemoveSpecialCharacters(zClient) & zDateStamp & ".pdf"
            End If

            ' BUILD DOCUMENT STRING
            Dim zDocument As String = ""
            zDocument = zDocument & "<!DOCTYPE html><html><head><title>" & zFileName & "</title><style>"
            zDocument = zDocument & zCSS
            zDocument = zDocument & "</style></head><body><div id='pdf'>"
            zDocument = zDocument & zHTML
            zDocument = zDocument & "</div></body></html>"

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
            zErrLogError.ErrorType = "Serve HTML PDF Error"
            zErrLogError.UserEmail = GetValue(GetGUIDFromQueryString, KeyName.LoggedInUserEmail)
            zErrLogError.MessageOuter = ex.Message
            Dim zInnerException As String = Nothing
            If Not ex.InnerException Is Nothing Then zInnerException = ex.InnerException.Message
            zErrLogError.MessageInner = zInnerException
            zErrLogError.ReferringURL = HttpContext.Current.Request.Url.AbsoluteUri
            zErrLogError.ApplicationPage = "ServeHTMLPDF.aspx"
            zErrLogError.StackTraceInner = ex.StackTrace
            Dim zErrorId As Integer = zErrLogError.CreateErrorLogRecord()

            context.Response.Clear()
            context.Response.ClearHeaders()
            context.Response.ClearContent()
            context.Response.Redirect("~/Home_{{VER}}/Error/?sid=" & zGUID & "&p1=" & zErrorId, False)

        End Try

    End Sub

    ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class