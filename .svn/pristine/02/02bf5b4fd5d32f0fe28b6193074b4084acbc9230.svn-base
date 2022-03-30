Public Class UtilEmail

    Public Shared Submitter As GRC.EmailManagement.Client.EmailSubmitter = Nothing
    Private Shared IsInit As Boolean = False

    Public Shared Sub Init()

        Dim zEmailCS As String = UtilSetting.GetValue(UtilSetting.Keys.EmailConnectionString)
        Dim zEnv As GRC.EmailManagement.Client.MailMessage.EmailMsgEnvironment = Nothing
        Dim zFromDisplay As String = "GRC_Connect"
        If UtilSystemParms.InDevMode Or UtilSystemParms.InTestMode Then
            zEnv = EmailManagement.Client.MailMessage.EmailMsgEnvironment.Test
            zFromDisplay = zFromDisplay & " (" & zEnv.ToString & ")"
        Else
            zEnv = EmailManagement.Client.MailMessage.EmailMsgEnvironment.Live
        End If
        Submitter = New GRC.EmailManagement.Client.EmailSubmitter(zEmailCS, My.Application.Info.AssemblyName, zEnv)
        IsInit = True

    End Sub

    Public Shared Sub SendException(pException As Exception, pProcess As String, Optional pFromDisplay As String = "GRC Connect")
        If Not IsInit Then Throw New ApplicationException("UtilEmail not initialized. Please call UtilEmail.Init() before using this function.")

        Dim zExceptionRecipients As String = UtilSetting.GetValue(UtilSetting.Keys.ApplicatonExceptionRecipients)
        Dim zMsgProps As New GRC.EmailManagement.Client.MailMessageProcessingProperties
        With zMsgProps
            If Not String.IsNullOrEmpty(zExceptionRecipients) Then
                zMsgProps.To.Add(zExceptionRecipients)
                zMsgProps.Subject = "Application Exception (" & UtilSystemParms.ReadWebAppMode & ")"
                zMsgProps.Body = GRC.Resources.ExceptionUtility.ExtractMessagesHTML(pException.Source, pException)
                zMsgProps.From = New Net.Mail.MailAddress("null@tuvsud.com", pFromDisplay)
                zMsgProps.OrigProcess = pProcess
                Submitter.Submit(zMsgProps.ToMailMessage)
            Else
                Diagnostics.EventLog.WriteEntry("GRC Task Agent", "Could not send exception email to Task Agent Exception Recipients. No email was specified in the system parms table.")
            End If
        End With
    End Sub

End Class
