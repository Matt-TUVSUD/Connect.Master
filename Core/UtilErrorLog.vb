Public Class UtilErrorLog
    Public DateOccured As DateTime
    Public UserEmail As String = ""
    Public SourceIP As String = ""
    Public SourceNamespace As String = ""
    Public ReferringURL As String = ""
    Public MessageOuter As String = ""
    Public MessageInner As String = ""
    Public StackTraceInner As String = ""
    Public ApplicationPage As String = ""
    Public ErrorType As String = ""

    Public Function AddCTXError(pCTX As HttpContext, pUserEmail As String, pSrcIP As String, pErrorType As String) As Integer
        Dim zReturn As Integer = 0
        Dim zException As Exception = pCTX.Server.GetLastError()

        If zException Is Nothing Then
            Me.DateOccured = Now
            Me.UserEmail = pUserEmail
            Me.SourceIP = pSrcIP
            Me.SourceNamespace = "Unknown"
            Me.ReferringURL = pCTX.Request.Url.ToString
            Me.MessageOuter = "Unknown - Error creating exception"
            Me.ApplicationPage = pCTX.Request.Url.AbsolutePath.ToString
            Me.ErrorType = pErrorType

        Else
            Me.DateOccured = Now
            Me.UserEmail = pUserEmail
            Me.SourceIP = pSrcIP
            Me.SourceNamespace = zException.Source.ToString
            Me.ReferringURL = pCTX.Request.Url.ToString
            Me.MessageOuter = zException.Message.ToString
            If Not IsNothing(zException.InnerException) Then Me.MessageInner = zException.InnerException.Message.ToString
            Me.StackTraceInner = zException.StackTrace.ToString
            Me.ApplicationPage = pCTX.Request.Url.AbsolutePath.ToString
            Me.ErrorType = pErrorType

        End If

        zReturn = CreateErrorLogRecord()

        Return zReturn
    End Function

    Public Function ShouldNagivateToErrorUI() As Boolean
        Dim zReturn As Boolean = False

        'Do we have details?  If not, do not report or show error screen.
        If Me.ReferringURL.Trim.Length > 0 Then
            If InStr(Me.ReferringURL.ToLower, "Error/Default.aspx".ToLower) = 0 Then  'Prevent circular redirect
                If Me.UserEmail.Length > 0 Then
                    zReturn = True
                End If
            End If
        End If

        Return zReturn
    End Function

    Public Function CreateErrorLogRecord() As Integer
        Dim zReturn As Integer = 0

        Try
            Dim zErrLog As New BusinessObjects.ErrorLog

            zErrLog.DateOccured = Now
            zErrLog.UserEmail = Me.UserEmail
            zErrLog.SourceIP = Me.SourceIP
            zErrLog.SourceNamespace = Me.SourceNamespace
            zErrLog.ReferringURL = Me.ReferringURL
            zErrLog.MessageOuter = Me.MessageOuter
            zErrLog.MessageInner = Me.MessageInner
            zErrLog.StackTraceInner = Me.StackTraceInner
            zErrLog.ApplicationPage = Me.ApplicationPage
            zErrLog.ErrorType = Me.ErrorType

            zErrLog.Save()
            zReturn = zErrLog.LogId
        Catch ex As Exception
            'Error occured while writting to DB, the server must be down.
        End Try

        Return zreturn
    End Function


    Public Function CreateSimpleErrorLogRecord(pEmail As String, pMessage As String, pApplicationPage As String, pErrorType As String, pSourceIP As String) As Integer
        Dim zReturn As Integer = 0

        Try
            Dim zErrLog As New BusinessObjects.ErrorLog

            zErrLog.DateOccured = Now
            zErrLog.UserEmail = pEmail
            zErrLog.SourceIP = pSourceIP
            zErrLog.SourceNamespace = Nothing
            zErrLog.ReferringURL = Nothing
            zErrLog.MessageOuter = pMessage
            zErrLog.MessageInner = Nothing
            zErrLog.StackTraceInner = Nothing
            zErrLog.ApplicationPage = pApplicationPage
            zErrLog.ErrorType = pErrorType

            zErrLog.Save()
            zReturn = zErrLog.LogId
        Catch ex As Exception
            'Error occured while writting to DB, the server must be down.
        End Try

        Return zReturn
    End Function


    Public Sub ThrowSystemError()
        Throw New NotImplementedException("Manufactured system error to test revised error handling.  Do NOT panic, yet.")
    End Sub

    Private Function LoadErrorLog_ById(pErrorLogId As Integer) As Boolean
        Dim zReturn As Boolean = False
        Dim zErrLog As New BusinessObjects.ErrorLog

        If zErrLog.LoadByPrimaryKey(pErrorLogId) Then
            Me.DateOccured = zErrLog.DateOccured
            Me.UserEmail = zErrLog.UserEmail
            Me.SourceIP = zErrLog.SourceIP
            Me.SourceNamespace = zErrLog.SourceNamespace
            Me.ReferringURL = zErrLog.ReferringURL
            Me.MessageOuter = zErrLog.MessageOuter
            Me.MessageInner = zErrLog.MessageInner
            Me.StackTraceInner = zErrLog.StackTraceInner
            Me.ApplicationPage = zErrLog.ApplicationPage
            Me.ErrorType = zErrLog.ErrorType
            zReturn = True
        End If

        Return zReturn
    End Function

    Public Sub ReportErrorViaEmail(pErrorLogId As Integer)
        Try
            If LoadErrorLog_ById(pErrorLogId) Then
                Dim zEmailDisplayName As String = UtilSystemParms.ReadReportServerErrorsDisplayName
                Dim zEmailAddress As String = UtilSystemParms.ReadReportServerErrorsEmailAddress
                Dim zMessage As String = ""

                zMessage = zMessage & "Date: " & Me.DateOccured & vbCrLf
                zMessage = zMessage & "User: " & Me.UserEmail & vbCrLf
                zMessage = zMessage & "Referring Page: " & Me.ReferringURL & vbCrLf
                zMessage = zMessage & "Source: " & Me.SourceNamespace & vbCrLf
                zMessage = zMessage & "Message Outer: " & Me.MessageOuter & vbCrLf
                zMessage = zMessage & "Message Inner: " & Me.MessageInner & vbCrLf
                zMessage = zMessage & "Stacktrace (Inner): " & Me.StackTraceInner & vbCrLf

                'If Me.ReferringURL.Length > 0 Then zLogIt = True : zMailIt = True
                'If Me.SourceNamespace.Length > 0 Then zLogIt = True : zMailIt = True
                'If Me.MessageOuter.Length > 0 Then zLogIt = True : zMailIt = True
                'If Me.MessageInner.Length > 0 Then zLogIt = True : zMailIt = True
                'If Me.StackTraceInner.Length > 0 Then zLogIt = True : zMailIt = True

                UtilNotification.SubmitNotification(zEmailAddress, "WE: GRC Connect - " & UtilSystemParms.ReadWebAppMode & " - " & Me.UserEmail, zMessage, "System Exception")

                'Dim zMM As New UtilMail(BusinessObjects.EmailFlag.EmailFlagEnum.Exception)
                'zMM.InitMail()
                'zMM.MailSubject = "WE: GRC Connect - " & UtilSystemParms.ReadWebAppMode & " - " & Me.UserEmail
                'zMM.MailBody = zMessage
                'zMM.MailTo.Clear()
                'zMM.MailTo.Add(zEmailAddress, zEmailDisplayName)

                'zMM.SendMail(False)
            End If
        Catch ex As Exception
            ' An error occured on the error page - database must be down - do not create a circular reference.
        End Try
    End Sub

End Class
