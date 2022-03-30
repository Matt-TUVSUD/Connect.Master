
Imports GRC.EmailManagement.Client
Imports GRC.Connect.Libraries.CoreLib
Imports GRC.Connect.Libraries.DataLib.razor
Imports GRC.Connect.Libraries
Imports AppJobLib

Module Module1

    Sub Main()
        Try
            UtilESStart.InitEngine()
            UtilSQLServer.SetConnection(UtilDB.ConnectionString)
            UtilSetting.Init()
            UtilEmail.Init()
            UtilConfiguration.Auditing.CurrentUserDelegate = Function() ("SYSTEM")

            If Not UtilSetting.InDataMaintenanceMode Then
                Dim z As New GRC.Connect.Libraries.DataTransferLib.UtilDataTransfer
                DoJobs()
            End If

        Catch jobEx As AppJobLib.UtilAppJobException
            jobEx.Data.Add("JobId", jobEx.Job.colFldJobId)
            jobEx.Data.Add("JobName", jobEx.Job.colFldJobName)
            jobEx.Data.Add("JobLastExecuted", jobEx.Job.colFldLastExecutedTime)
            jobEx.Data.Add("JobAssembly", jobEx.Job.colFldAssemblyName)
            jobEx.Data.Add("JobType", jobEx.Job.colFldTypeName)
            jobEx.Data.Add("JobMethod", jobEx.Job.colFldMethodName)

            EventLog.WriteEntry("Application", GRC.Resources.ExceptionUtility.ExtractMessages(jobEx))
            SendEmail(jobEx)

        Catch ex As Exception
            EventLog.WriteEntry("Application", GRC.Resources.ExceptionUtility.ExtractMessages(ex))
            SendEmail(ex)
        End Try

    End Sub

    Sub DoJobs()
        Dim zCS As String = Configuration.ConfigurationManager.ConnectionStrings("AppJob.Dev").ConnectionString
        If UtilSystemParms.InTestMode Then zCS = Configuration.ConfigurationManager.ConnectionStrings("AppJob.Test").ConnectionString
        If UtilSystemParms.InLiveMode Then zCS = Configuration.ConfigurationManager.ConnectionStrings("AppJob.Live").ConnectionString
        If UtilSystemParms.InBetaMode Then zCS = Configuration.ConfigurationManager.ConnectionStrings("AppJob.Beta").ConnectionString

        Dim zUtilDataTransfer As New DataTransferLib.UtilDataTransfer
        Dim zUtilDataTransferPDF As New DataTransferLib.UtilDataTransfer.PDF

        Dim zList As New List(Of IAppJob)({zUtilDataTransfer, zUtilDataTransferPDF})

        Dim zUtilJob As New AppJobLib.UtilAppJob(zCS)

        zUtilJob.Run(zList, 2)

    End Sub

    Sub SendEmail(pException As Exception)
        Dim zEmailCS As String = ""
        Dim zEnv As GRC.EmailManagement.Client.MailMessage.EmailMsgEnvironment = Nothing
        Dim zFromDisplay As String = "GRC Data Transfer Agent"
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
                EventLog.WriteEntry("Application", "Could not send exception email to Task Agent Exception Recipients. No email was specified in the system parms table.")
            End If
        End With
    End Sub

End Module
