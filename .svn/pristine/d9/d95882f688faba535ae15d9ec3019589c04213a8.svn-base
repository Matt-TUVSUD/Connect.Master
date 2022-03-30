
Imports System.Web.SessionState
Imports GRC.Connect.Libraries.DataLib.razor
Imports System.ServiceModel.Activation


Public Class Global_asax
    Inherits System.Web.HttpApplication

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the application is started
        UtilESStart.InitEngine()
        UtilSQLServer.SetConnection(UtilDB.ConnectionString)
        UtilConfiguration.Auditing.CurrentUserDelegate = Function() (IIf(String.IsNullOrEmpty(UtilGSafe.GetValue(UtilGSafe.GetGUIDFromQueryString, UtilGSafe.KeyName.userFullName)), "SYSTEM", UtilGSafe.GetValue(UtilGSafe.GetGUIDFromQueryString, UtilGSafe.KeyName.userFullName)))

        Dim zFile As String = Server.MapPath("~/Version.xml")
        Dim zVersion As New UtilVersion(zFile)
        Application("SYS_VersionNumber") = zVersion.GetRevisionNumber
        Application("SYS_VersionDate") = zVersion.GetRevisionDate

        WhatIfService.InitService()


        UtilConstants.AssignNavLinkValues()
        UtilConstants.AssignGridIdValues()
        UtilSetting.Init()
        UtilEmail.Init()
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires at the beginning of each request
    End Sub

    Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires upon attempting to authenticate the use
    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when an error occurs
        If Not GRC.Connect.Libraries.CoreLib.UtilSystemParms.ReadWebAppMode.ToUpper = "DEV" Then
            Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString() ' *** GRC.Connect.Scott Update 7/29/2015
            Dim zErrLog As New GRC.Connect.Libraries.CoreLib.UtilErrorLog
            Dim zUserEmail As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.LoggedInUserEmail) ' *** GRC.Connect.Scott Update 7/29/2015
            Dim zSrcIP As String = Request.ServerVariables("REMOTE_ADDR")
            Dim zErrorType As String = "Interactive"
            Dim zErrorLogId As Integer = 0
            Dim zCTX As HttpContext = HttpContext.Current

            zErrorLogId = zErrLog.AddCTXError(zCTX, zUserEmail, zSrcIP, zErrorType)

            zCTX.ClearError()

            If zErrorLogId > 0 Then
                If zErrLog.ShouldNagivateToErrorUI Then
                    Response.Redirect("~/Home_{{VER}}/Error/?sid=" & zSafeGUID & "&p1=" & zErrorLogId, False)
                End If
            End If
        End If
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the session ends
        Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString() ' *** GRC.Connect.Scott Update 7/29/2015
        GRC.Connect.Libraries.CoreLib.UtilLogin2.LogoutUser(True, zSafeGUID)

    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the application ends
    End Sub

    Private Sub Global_asax_BeginRequest(sender As Object, e As EventArgs) Handles Me.BeginRequest
            UtilSetting.Init(HttpContext.Current.Request)
    End Sub
End Class