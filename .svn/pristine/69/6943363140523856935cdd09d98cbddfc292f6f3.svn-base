Imports System.Web
Imports System.Web.Services

Public Class DataTransferHandler
    Implements System.Web.IHttpHandler

    Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        Dim zFilePrefix As String = ""
        Dim zPwd As String = ""
        Dim zFile As Byte() = Nothing
        Dim zUtilLog As New Libraries.CoreLib.UtilLog()

        If context.Request.QueryString.Count = 2 Then
            zFilePrefix = context.Request.QueryString("p1")
            zPwd = HttpUtility.UrlDecode(context.Request.QueryString("p2"))

            Try
                Dim zUtilDataTransfer As New GRC.Connect.Libraries.DataTransferLib.UtilDataTransfer()
                zFile = zUtilDataTransfer.GetEncryptedPackage(zFilePrefix, zPwd)
                zUtilDataTransfer.SetRetrievalDate(zFilePrefix)
                context.Response.Clear()
                context.Response.ClearHeaders()
                context.Response.ClearContent()
                context.Response.AddHeader("Content-Disposition", "attachment;filename=GRCDataExtract.zip") '& "." & zExtension)
                context.Response.ContentType = "application/zip"
                context.Response.OutputStream.Write(zFile, 0, zFile.Length)
                context.Response.Flush()

            Catch ex As Exception
                EventLog.WriteEntry("Data Transfer", ex.Message, EventLogEntryType.Error)
                context.Response.RedirectLocation = "~/Home_{{VER}}/Auth/"
                context.Response.StatusCode = 403

                'If context.Session("NotAuthorizedExceptionCount") = 3 Then
                '    zUtilLog.LogIt("The following exception has occurred three times in a single session. " & ex.Message, Libraries.CoreLib.UtilLog.EventLevel.Critical, Libraries.CoreLib.UtilLog.EventType.DataTransfer, 0, 0, 0, True)
                'End If

            End Try
        Else
            context.Response.RedirectLocation = "~/Home_{{VER}}/Auth/"
            context.Response.StatusCode = 400
        End If

    End Sub

    ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return True
        End Get
    End Property

End Class