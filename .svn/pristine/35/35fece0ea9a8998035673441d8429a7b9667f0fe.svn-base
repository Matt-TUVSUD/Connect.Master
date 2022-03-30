Imports System.Web
Imports GRC.Connect.Libraries.DataLib.razor

Public Class DownloadHandler
    Implements IHttpHandler

    Public Enum ReportTypes
        RatingReport = 1
        WhatIfReport = 2
        RecExtract = 3
    End Enum

#Region "IHttpHandler Members"

    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            ' Return false in case your Managed Handler cannot be reused for another request.
            ' Usually this would be false in case you have some state information preserved per request.
            Return True
        End Get
    End Property

    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        Dim zGUID As String = context.Request.QueryString("pGUID")
        Dim zByte(0) As Byte
        Dim zReportName As String = ""
        Dim zExtension As String = ""
        Dim zMimeType As String = ""

        If Not IsNothing(zGUID) Or zGUID <> "" Then

            Dim zRow As rowTblWhatIfOutputParm = TblWhatIfOutputParm.LoadByPrimaryKey(zGUID)
            Dim zUtil As New UtilWhatIf(zRow.colFldSID)

            If zRow.colFldOutputID = 1 Then
                zByte = zUtil.GetFireRatingReport(zRow.colFldFileNo)
                zReportName = "WhatIf_RatingReport_" & zRow.colFldFileNo.ToString()
                zExtension = ".pdf"
                zMimeType = "applicaton/pdf"
            End If

            If zRow.colFldOutputID = 2 Then
                zByte = zUtil.GetWhatIfReport(zRow.colFldSortJSON, zRow.colFldFilterJSON, zRow.colFldEstBudget, zRow.colFldEstCostToComplete, zRow.colFldRemainBudget)
                zReportName = "WhatIfReport"
                zExtension = ".pdf"
                zMimeType = "applicaton/pdf"
            End If

            If zRow.colFldOutputID = 3 Then
                zByte = zUtil.GetWhatIfExtract(zRow.colFldSortJSON, zRow.colFldFilterJSON)
                zReportName = "WhatIf_Recommendations_" & Now.ToString()
                zExtension = ".xlsx"
                zMimeType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
            End If


        End If

        Try

            ' DELIVER FILE
            context.Response.Clear()
            context.Response.ClearHeaders()
            context.Response.ClearContent()
            context.Response.AddHeader("Content-Disposition", "attachment;filename=" & zReportName & zExtension)
            context.Response.ContentType = zMimeType
            context.Response.OutputStream.Write(zByte, 0, zByte.Length)
            context.Response.Flush()
            context.Response.End()
            context.Response.Close()

        Catch ex As System.Threading.ThreadAbortException
            ' THIS IS AN EXPECTED ERROR, THIS CATCH IS DESIGNED TO CONSUME THE ERROR AND CONTINUE

        Catch ex As Exception
            '' OTHER ERROR
            'Dim zErrLogError As New UtilErrorLog
            'zErrLogError.DateOccured = Now
            'zErrLogError.ErrorType = "Serve Batch Report Error"
            'zErrLogError.UserEmail = GetValue(GetGUIDFromQueryString, KeyName.LoggedInUserEmail)
            'zErrLogError.MessageOuter = ex.Message
            'Dim zInnerException As String = Nothing
            'If Not ex.InnerException Is Nothing Then zInnerException = ex.InnerException.Message
            'zErrLogError.MessageInner = zInnerException
            'zErrLogError.ReferringURL = HttpContext.Current.Request.Url.AbsoluteUri
            'zErrLogError.ApplicationPage = "ServeBatchReport.aspx"
            'zErrLogError.StackTraceInner = ex.StackTrace
            'Dim zErrorId As Integer = zErrLogError.CreateErrorLogRecord()

            'context.Response.Clear()
            'context.Response.ClearHeaders()
            'context.Response.ClearContent()
            'context.Response.Redirect("~/Home_{{VER}}/Error/?sid=" & zGSafeGUID & "&p1=" & zErrorId, False)

        End Try

    End Sub

#End Region

End Class
