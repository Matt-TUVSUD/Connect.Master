Imports System.Web
Imports System.Web.Services
''' <summary>
''' Handles redirection for old ColdFusion links.
''' </summary>
''' <remarks></remarks>
Public Class AutoRecRedirectHandler
    Implements System.Web.IHttpHandler

    Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        Throw New NotImplementedException
        'Dim zEncryptedID As String = HttpUtility.UrlDecode(context.Request.QueryString(0))
        'Dim zDecryptedID As String = Libraries.CoreLib.BusinessObjects.RRLogEncryptedId.GetDecryptedValue(zEncryptedID)
        'If zDecryptedID <> "" Then
        '    Dim zRRLog As New Libraries.CoreLib.BusinessObjects.RRLog
        '    If zRRLog.LoadByPrimaryKey(zDecryptedID) Then
        '        If String.IsNullOrEmpty(zRRLog.RRLogGuid) Then
        '            zRRLog.RRLogGuid = Guid.NewGuid().ToString("N")
        '            zRRLog.Save()
        '            context.Response.Redirect("../Auth/Default.aspx?p1=" & zRRLog.RRLogGuid)
        '        Else
        '            context.Response.Redirect("../Auth/Default.aspx?p1=" & zRRLog.RRLogGuid)
        '        End If
        '    Else
        '        context.Response.Write("This URL is expired or invalid. <br><br>Please contact <a href='mailto:grc-ResourceCenter@tuvsud.com'>ResourceCenter@tuvsud.com</a> if you need assistance.")
        '    End If
        'End If
    End Sub

    ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class