Imports System.Web
Imports System.Web.Services

Public Class ServeDocLibReport
    Implements System.Web.IHttpHandler

    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest

        Dim zGuid As String = context.Request.QueryString("reportGuid")
        Dim zType As String = context.Request.QueryString("t")

        Dim zFilePath As String = ""
        If zType = "e" Then zFilePath = UtilDocLib.GetEngineeringReportPath(zGuid)
        If zType = "d" Then zFilePath = UtilDocLib.GetDiagramReportPath(zGuid)

        If IO.File.Exists(zFilePath) Then
            Dim zFileName As String = IO.Path.GetFileName(zFilePath)
            Dim zByte As Byte() = IO.File.ReadAllBytes(zFilePath)
            SendToBrowser(context, zFileName, IO.Path.GetExtension(zFilePath), zByte)
        End If

    End Sub

    Private Sub SendToBrowser(context As HttpContext, pFileName As String, pExtension As String, pByte As Byte())
        With context
            .Response.Clear()
            .Response.ClearHeaders()
            .Response.ClearContent()
            .Response.AddHeader("Content-Disposition", "attachment;filename=" & pFileName)
            .Response.ContentType = "application/" & pExtension
            .Response.OutputStream.Write(pByte, 0, pByte.Length)
            .Response.Flush()
            .Response.End()
            .Response.Close()
        End With
    End Sub

    Public ReadOnly Property IsReusable As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property
End Class