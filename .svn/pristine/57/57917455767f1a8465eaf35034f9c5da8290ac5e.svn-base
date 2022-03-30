Imports System.Web
Imports System.Web.Services
Imports GRC.Connect.Libraries.CoreLib.UtilGSafe

Public Class UserExportHandler
    Implements System.Web.IHttpHandler

    Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        Dim zMsgLog As New UtilLog
        Try
            ' GET THE FILE NAME IF EXISTS
            Dim zFileName As String = "GRCConnectUsers"
            If context.Request.Form("FileName") <> Nothing Then
                If context.Request.Form("FileName").Length > 0 Then
                    zFileName = context.Request.Form("FileName") & ""
                End If
            End If

            Dim ExcelData As String = ""
            If context.Request.Form("XMLData") <> Nothing Then
                If context.Request.Form("XMLData").Length > 0 Then
                    ExcelData = context.Request.Form("XMLData").ToString()
                    ' REBUILD ILLEGAL CHARACTERS
                    ExcelData = Replace(ExcelData, "||OPEN||", "<")
                    ExcelData = Replace(ExcelData, "||CLOSE||", ">")
                    ' PROCESS THE EXPORT
                    context.Response.ClearHeaders()
                    context.Response.ClearContent()
                    context.Response.Clear()
                    context.Response.AddHeader("Expires", Now())                           'CAUSES ERROR IN IE8
                    context.Response.AddHeader("Pragma", "no-cache")                       'CAUSES ERROR IN IE8
                    context.Response.AddHeader("Cache-Control", "no-store, no-cache")      'CAUSES ERROR IN IE8
                    context.Response.AddHeader("Content-Disposition", "attachment;filename=" & zFileName & ".xls")
                    context.Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet" '"application/vnd.ms-excel"
                    'context.Response.Write(ExcelData)
                    Dim zByte() As Byte
                    zByte = System.Text.Encoding.UTF8.GetBytes(ExcelData)
                    context.Response.OutputStream.Write(zByte, 0, zByte.Length)
                    context.Response.Flush()
                    context.Response.End()
                    context.Response.Close()
                End If
            End If

        Catch ex As System.Threading.ThreadAbortException
            ' THIS IS AN EXPECTED ERROR, THIS CATCH IS DESIGNED TO CONSUME THE ERROR AND CONTINUE

        Catch ex As Exception
            ' OTHER ERROR
            Dim zErrLogError As New UtilErrorLog
            zErrLogError.DateOccured = Now
            zErrLogError.ErrorType = "User Export Error"
            zErrLogError.UserEmail = "unknown"
            zErrLogError.MessageOuter = ex.Message
            Dim zInnerException As String = Nothing
            If Not ex.InnerException Is Nothing Then zInnerException = ex.InnerException.Message
            zErrLogError.MessageInner = zInnerException
            zErrLogError.ReferringURL = HttpContext.Current.Request.Url.AbsoluteUri
            zErrLogError.ApplicationPage = "UserExport.ashx"
            zErrLogError.StackTraceInner = ex.StackTrace
            zErrLogError.CreateErrorLogRecord()

            'context.Response.Clear()
            'context.Response.ClearHeaders()
            'context.Response.ClearContent()
            'context.Response.Redirect("~/Home_{{VER}}/Error/?sid=" & zGSafeGUID & "&p1=" & zErrorId, False)

        End Try

    End Sub

    ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class