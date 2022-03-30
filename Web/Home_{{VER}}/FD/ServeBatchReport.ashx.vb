Imports System.Web
Imports System.Web.Services

Imports GRC.Connect.Libraries.CoreLib.UtilGSafe
Imports GRC.Connect.Libraries.DataLib.razor

Public Class ServeBatchReport
    Implements System.Web.IHttpHandler

    Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest

        Dim zFileGUID As String = ""
        Dim zGSafeGUID As String = ""
        Dim zMsgLog As New UtilLog
        Dim zFileName As String = ""
        Dim zExtension As String = ".pdf"
        Dim zMimeType As String = "application/pdf"
        Dim zByte(0) As Byte

        Try
            If Not context.Request.QueryString("pFileGUID") Is Nothing Then
                zFileGUID = context.Request.QueryString("pFileGUID")
            End If
            If Not context.Request.QueryString("pGSafeGUID") Is Nothing Then
                zGSafeGUID = context.Request.QueryString("pGSafeGUID")
            End If

            Dim zColl As New List(Of rowTblBatchProcessingFile)
            Dim zCmd As New SqlClient.SqlCommand("SELECT TOP 1 * FROM [dbo].[tblBatchProcessingFile] WHERE [fldGuid] = @FileGUID")
            zCmd.Parameters.AddWithValue("@FileGUID", zFileGUID)
            zColl = TblBatchProcessingFile.LoadData(zCmd)
            If zColl.Count > 0 Then
                zFileName = ""
                zFileName = zColl(0).colFldFileName
                zExtension = zColl(0).colFldExtension
                zMimeType = zColl(0).colFldMime
                zByte = zColl(0).colFldData
                zColl(0).colFldAccessDate = Now
                TblBatchProcessingFile.Save(zColl(0))
            End If

            ' DELIVER FILE
            context.Response.Clear()
            context.Response.ClearHeaders()
            context.Response.ClearContent()
            context.Response.AddHeader("Content-Disposition", "attachment;filename=" & zFileName & zExtension)
            context.Response.ContentType = zMimeType
            context.Response.OutputStream.Write(zByte, 0, zByte.Length)
            context.Response.Flush()
            context.Response.End()
            context.Response.Close()

        Catch ex As System.Threading.ThreadAbortException
            ' THIS IS AN EXPECTED ERROR, THIS CATCH IS DESIGNED TO CONSUME THE ERROR AND CONTINUE

        Catch ex As Exception
            ' OTHER ERROR
            Dim zErrLogError As New UtilErrorLog
            zErrLogError.DateOccured = Now
            zErrLogError.ErrorType = "Serve Batch Report Error"
            zErrLogError.UserEmail = GetValue(GetGUIDFromQueryString, KeyName.LoggedInUserEmail)
            zErrLogError.MessageOuter = ex.Message
            Dim zInnerException As String = Nothing
            If Not ex.InnerException Is Nothing Then zInnerException = ex.InnerException.Message
            zErrLogError.MessageInner = zInnerException
            zErrLogError.ReferringURL = HttpContext.Current.Request.Url.AbsoluteUri
            zErrLogError.ApplicationPage = "ServeBatchReport.aspx"
            zErrLogError.StackTraceInner = ex.StackTrace
            Dim zErrorId As Integer = zErrLogError.CreateErrorLogRecord()

            context.Response.Clear()
            context.Response.ClearHeaders()
            context.Response.ClearContent()
            context.Response.Redirect("~/Home_{{VER}}/Error/?sid=" & zGSafeGUID & "&p1=" & zErrorId, False)

        End Try

    End Sub

    ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class