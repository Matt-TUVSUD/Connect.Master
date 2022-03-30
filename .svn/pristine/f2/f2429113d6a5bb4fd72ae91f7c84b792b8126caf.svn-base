
Imports GRC.EmailManagement.Client
Imports GRC.Connect.Libraries.CoreLib
Imports GRC.Connect.Libraries.DataLib.razor

Module Module1

    Sub Main()
        Try
            UtilESStart.InitEngine()
            UtilSQLServer.SetConnection(UtilDB.ConnectionString)
            UtilSetting.Init()
            UtilEmail.Init()
            UtilConfiguration.Auditing.CurrentUserDelegate = Function() ("SYSTEM")

            'DEBUG_DoFollowUps()
            'DEBUG_DoMonthlies(Nothing)
            If Not Debugger.IsAttached Then
                If Not UtilSetting.InDataMaintenanceMode Then
                    DoJobs()
                End If
            Else

                    'Dim t As New BatchLib.UtilTopo
                    't.ProcessTopoImports()

                    'Dim ar As New AutoRecLib.UtilAutoRec
                    'ar.ProcessAutoRecSurveyProcessTable()
                    ''DoAlways()
                    'Dim zAR As New AutoRecLib.UtilAutoRec
                    'zAR.ProcessAutoRecSurveyProcessTable()

                    'DoJobs()
                    'DoBatches()
                    'ProcessEmails()
                    'DoLogMaintenance()
                End If

        Catch jobEx As AppJobLib.UtilAppJobException
            jobEx.Data.Add("JobId", jobEx.Job.colFldJobId)
            jobEx.Data.Add("JobName", jobEx.Job.colFldJobName)
            jobEx.Data.Add("JobLastExecuted", jobEx.Job.colFldLastExecutedTime)
            jobEx.Data.Add("JobAssembly", jobEx.Job.colFldAssemblyName)
            jobEx.Data.Add("JobType", jobEx.Job.colFldTypeName)
            jobEx.Data.Add("JobMethod", jobEx.Job.colFldMethodName)

            EventLog.WriteEntry(jobEx.InnerException.Source, GRC.Resources.ExceptionUtility.ExtractMessages(jobEx))
            SendEmail(jobEx)

        Catch batchEx As BatchLib.UtilBatchProcessSetItemException
            batchEx.Data.Add("SetId", batchEx.BatchSet.colFldId)
            batchEx.Data.Add("SetIsInteractive", batchEx.BatchSet.colFldIsInteractive)
            batchEx.Data.Add("SetFilePrefix", batchEx.BatchSet.colFldFilePrefix)
            batchEx.Data.Add("SetGSafeID", batchEx.BatchSet.colFldCreatedByGsafeId)
            batchEx.Data.Add("SetCreateDate", batchEx.BatchSet.colFldCreateDate)
            batchEx.Data.Add("SetParameters", batchEx.BatchSet.colFldMetaParameterJSON)
            batchEx.Data.Add("SetType", batchEx.BatchSet.Type.ToString)
            batchEx.Data.Add("SetItemId", batchEx.SetItem.colFldSetId)
            batchEx.Data.Add("SetItemObjectId", batchEx.SetItem.colFldMetaObjectId.Value)

            EventLog.WriteEntry(batchEx.InnerException.Source, GRC.Resources.ExceptionUtility.ExtractMessages(batchEx))
            SendEmail(batchEx)

        Catch batchEx As BatchLib.UtilBatchProcessSetException
            batchEx.Data.Add("SetId", batchEx.BatchSet.colFldId)
            batchEx.Data.Add("SetIsInteractive", batchEx.BatchSet.colFldIsInteractive)
            batchEx.Data.Add("SetFilePrefix", batchEx.BatchSet.colFldFilePrefix)
            batchEx.Data.Add("SetGSafeID", batchEx.BatchSet.colFldCreatedByGsafeId)
            batchEx.Data.Add("SetCreateDate", batchEx.BatchSet.colFldCreateDate)
            batchEx.Data.Add("SetParameters", batchEx.BatchSet.colFldMetaParameterJSON)
            batchEx.Data.Add("SetType", batchEx.BatchSet.Type.ToString)

            EventLog.WriteEntry(batchEx.InnerException.Source, GRC.Resources.ExceptionUtility.ExtractMessages(batchEx))
            SendEmail(batchEx)

        Catch ex As Exception
            EventLog.WriteEntry(ex.Source, GRC.Resources.ExceptionUtility.ExtractMessages(ex))
            SendEmail(ex)
        End Try

    End Sub

    Sub DoJobs()
        Dim zCS As String = Configuration.ConfigurationManager.ConnectionStrings("AppJob.Dev").ConnectionString
        If UtilSystemParms.InTestMode Then zCS = Configuration.ConfigurationManager.ConnectionStrings("AppJob.Test").ConnectionString
        If UtilSystemParms.InLiveMode Then zCS = Configuration.ConfigurationManager.ConnectionStrings("AppJob.Live").ConnectionString
        If UtilSystemParms.InBetaMode Then zCS = Configuration.ConfigurationManager.ConnectionStrings("AppJob.Beta").ConnectionString

        Dim zUtilAutoRect As New AutoRecLib.UtilAutoRec
        Dim zUtilDataTransfer As New DataTransferLib.UtilDataTransfer
        Dim zUtilDataTransferPDF As New DataTransferLib.UtilDataTransfer.PDF
        Dim zUtilAutoUserNotif As New CoreLib.UtilAutoNotification
        Dim zUtilReclassification As New CoreLib.UtilUserReclassification
        Dim zUtilBatchLib As New BatchLib.UtilTopo

        Dim zList As New List(Of IAppJob)({zUtilAutoRect, zUtilDataTransfer, zUtilAutoUserNotif, zUtilReclassification, zUtilBatchLib})

        Dim zUtilJob As New AppJobLib.UtilAppJob(zCS)

        zUtilJob.Run(zList, 1)

    End Sub

    Sub SendEmail(pException As Exception)
        Dim zEmailCS As String = ""
        Dim zEnv As GRC.EmailManagement.Client.MailMessage.EmailMsgEnvironment = Nothing
        Dim zFromDisplay As String = "GRC Scheduled Job Agent"
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
