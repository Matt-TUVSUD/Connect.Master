Public Class RecommendationExport
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim zMsgLog As New UtilLog
        'Try
        '    Dim ExcelData As String = ""
        '    If Request.Form("XMLData") <> Nothing Then
        '        If Request.Form("XMLData").Length > 0 Then
        '            ExcelData = Request.Form("XMLData").ToString()
        '            ' REBUILD ILLEGAL CHARACTERS
        '            ExcelData = Replace(ExcelData, "||OPEN||", "<")
        '            ExcelData = Replace(ExcelData, "||CLOSE||", ">")
        '            ' PROCESS THE EXPORT
        '            Response.ClearHeaders()
        '            Response.ClearContent()
        '            Response.Clear()
        '            Response.AddHeader("Expires", Now())                           'CAUSES ERROR IN IE8
        '            Response.AddHeader("Pragma", "no-cache")                       'CAUSES ERROR IN IE8
        '            Response.AddHeader("Cache-Control", "no-store, no-cache")      'CAUSES ERROR IN IE8
        '            Response.AddHeader("Content-Disposition", "attachment;filename=RecommendationExport.xlsx")
        '            Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet" '"application/vnd.ms-excel"
        '            Response.Write(ExcelData)
        '            Response.Flush()
        '            Response.End()
        '            Response.Close()
        '        End If
        '    End If

        'Catch ex As System.Threading.ThreadAbortException
        '    ' THIS IS AN EXPECTED ERROR, THIS CATCH IS DESIGNED TO CONSUME THE ERROR AND CONTINUE

        'Catch ex As Exception
        '    ' OTHER ERROR
        '    Dim zErrLogError As New UtilErrorLog
        '    zErrLogError.DateOccured = Now
        '    zErrLogError.ErrorType = "Recommendation Export Error"
        '    zErrLogError.UserEmail = "unknown"
        '    zErrLogError.MessageOuter = ex.Message
        '    Dim zInnerException As String = Nothing
        '    If Not ex.InnerException Is Nothing Then zInnerException = ex.InnerException.Message
        '    zErrLogError.MessageInner = zInnerException
        '    zErrLogError.ReferringURL = HttpContext.Current.Request.Url.AbsoluteUri
        '    zErrLogError.ApplicationPage = "RecommendationExport.aspx"
        '    zErrLogError.StackTraceInner = ex.StackTrace
        '    zErrLogError.CreateErrorLogRecord()

        'End Try

    End Sub

End Class