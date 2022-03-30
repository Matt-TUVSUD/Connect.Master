Imports System.Web
Imports System.Web.Services
Imports GRC.Connect.Libraries.CoreLib.BusinessObjects

Public Class ValidateIt_Home
    Implements System.Web.IHttpHandler

    Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        Try
            'PASSED PARMS
            Dim zEmail = context.Request("Email").ToString()
            Dim zPassword = context.Request("Password").ToString()
            Dim zResults As String = ""
            zResults = GRC.Connect.Libraries.CoreLib.UtilLogin.ValidatePasswordStrength(zEmail, zPassword)

            'CLOSE THE PAGE
            context.Response.Write(zResults)
            Return

        Catch ex As Exception
            'CLOSE THE PAGE
            context.Response.Write(ex.Message & "")

        End Try

    End Sub

    ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class