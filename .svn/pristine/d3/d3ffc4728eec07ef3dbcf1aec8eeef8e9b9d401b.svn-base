
Imports GRC.EmailManagement.Client
Imports GRC.Connect.Libraries.CoreLib
Imports GRC.Connect.Libraries.DataLib.razor
Imports GRC.Connect.Libraries

Module Module1

    Sub Main()
        Try
            UtilESStart.InitEngine()
            UtilSQLServer.SetConnection(UtilDB.ConnectionString)
            UtilSetting.Init()
            UtilEmail.Init()
            UtilConfiguration.Auditing.CurrentUserDelegate = Function() ("SYSTEM")

            ProcessEmails()

        Catch ex As Exception
            EventLog.WriteEntry(ex.Source, GRC.Resources.ExceptionUtility.ExtractMessages(ex))
            SendEmail(ex)
        End Try

    End Sub

    Sub ProcessEmails()

        Dim zUtilNotif As New UtilNotification
        zUtilNotif.ProcessEmails()

    End Sub

    Sub SendEmail(pException As Exception)
        Dim zEmailCS As String = ""
        Dim zEnv As GRC.EmailManagement.Client.MailMessage.EmailMsgEnvironment = Nothing
        Dim zFromDisplay As String = "GRC Notification Agent"
        If UtilSystemParms.InDevMode Or UtilSystemParms.InTestMode Then
            zEmailCS = "EmailManagement.Test"
            zEnv = MailMessage.EmailMsgEnvironment.Test
            zFromDisplay = zFromDisplay
        Else
            zEmailCS = "EmailManagement.Live"
            zEnv = MailMessage.EmailMsgEnvironment.Live
        End If

        Dim zSubmitter As New GRC.EmailManagement.Client.EmailSubmitter(Configuration.ConfigurationManager.ConnectionStrings(zEmailCS).ConnectionString, My.Application.Info.AssemblyName, zEnv)
        Dim zMsgProps As New GRC.EmailManagement.Client.MailMessageProcessingProperties
        With zMsgProps
            If Not String.IsNullOrEmpty(UtilSetting.GetValue(UtilSetting.Keys.TaskAgentExceptionRecipients)) Then
                zMsgProps.To.Add(UtilSetting.GetValue(UtilSetting.Keys.TaskAgentExceptionRecipients))
                zMsgProps.Subject = zFromDisplay & " Exception (" & UtilSystemParms.ReadWebAppMode & ")"
                zMsgProps.Body = GRC.Resources.ExceptionUtility.ExtractMessagesHTML(pException.Source, pException)
                zMsgProps.From = New Net.Mail.MailAddress("null@tuvsud.com", zFromDisplay)
                zMsgProps.OrigProcess = zFromDisplay
                zSubmitter.Submit(zMsgProps.ToMailMessage)
            Else
                EventLog.WriteEntry("Application", "Could not send exception email to recipients. No email was specified in the system parms table.")
            End If
        End With
    End Sub

End Module
