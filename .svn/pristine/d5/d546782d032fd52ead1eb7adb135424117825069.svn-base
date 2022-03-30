

Public Class _Default_Error
    Inherits System.Web.UI.Page

    Public ServerSide_AuthURL As String = ""

    Private Sub ReportErrorViaEmail()
        Try
            Dim zGSafeGUID = UtilGSafe.GetGUIDFromQueryString()
            If zGSafeGUID.Length > 0 Then

                ' Dim zMM As New UtilMail(Libraries.CoreLib.BusinessObjects.EmailFlag.EmailFlagEnum.Exception)

                Dim zEmailDisplayName As String = UtilSystemParms.ReadReportServerErrorsDisplayName
                Dim zEmailAddress As String = UtilSystemParms.ReadReportServerErrorsEmailAddress
                Dim zMessage As String = ""
                Dim zUser As String = "N/A"
                Dim zError As String = ""
                Dim zLogIt As Boolean = False
                Dim zMailIt As Boolean = False

                'UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.

                If UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.LoggedInUserEmail).ToString.Length > 0 Then zUser = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.LoggedInUserEmail).ToString
                zError = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.SourceError)

                zMessage = zMessage & "Date: " & Now & vbCrLf
                zMessage = zMessage & "User: " & zUser & vbCrLf
                zMessage = zMessage & "Referring Page: " & UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.SourceError_OffendingURL) & vbCrLf
                zMessage = zMessage & "Source: " & UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.SourceError_Source) & vbCrLf
                zMessage = zMessage & "Message Outer: " & UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.SourceError_Message) & vbCrLf
                zMessage = zMessage & "Message Inner: " & UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.SourceError_MessageInnerException) & vbCrLf
                zMessage = zMessage & "Stacktrace (Inner): " & UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.SourceError_StacktraceInner) & vbCrLf

                If UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.SourceError_OffendingURL).ToString.Length > 0 Then zLogIt = True : zMailIt = True
                If UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.SourceError_Source).ToString.Length > 0 Then zLogIt = True : zMailIt = True
                If UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.SourceError_Message).ToString.Length > 0 Then zLogIt = True : zMailIt = True
                If UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.SourceError_MessageInnerException).ToString.Length > 0 Then zLogIt = True : zMailIt = True
                If UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.SourceError_StacktraceInner).ToString.Length > 0 Then zLogIt = True : zMailIt = True

                If zMailIt Then
                    UtilNotification.SubmitNotification(zEmailAddress, "WE: TUV SUD GRC Connect - " & UtilSystemParms.ReadWebAppMode & " - " & zUser, zMessage, "System Exception")

                    'zMM.InitMail()
                    ''zMM.MailSubject = "GRC Connect Web Error - " & UtilSystemParms.ReadWebAppMode
                    'zMM.MailSubject = "WE: GRC Connect - " & UtilSystemParms.ReadWebAppMode & " - " & zUser
                    'zMM.MailBody = zMessage
                    'zMM.MailTo.Clear()
                    'zMM.MailTo.Add(zEmailAddress, zEmailDisplayName)

                    'zMM.SendMail(False)
                End If
            End If

        Catch ex As Exception
            ' An error occured on the error page - database must be down - do not create a circular reference.
        End Try
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            'Call ReportErrorViaEmail()

            Dim zP1 As String = Request.QueryString("p1") & ""

            'SET THE URL OF THE AUTH PAGE FOR REDIRECTION
            If zP1.Length > 0 Then
                ServerSide_AuthURL = UtilSystemParms.ReadWebAppBaseURL & "Home_{{VER}}/Auth/?p1=" & zP1
            Else
                ServerSide_AuthURL = UtilSystemParms.ReadWebAppBaseURL & "Home_{{VER}}/Auth/"
            End If

            Session.Clear()
        End If
    End Sub

End Class