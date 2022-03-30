Imports GRC.Connect.Libraries.CoreLib.CustomExtensions.ListExtensions
Imports GRC.Connect.Libraries.DataLib.razor

Public Class UtilAutoRec
    Implements AppJobLib.IAppJob

    Friend DebugEmailAddress As String = ""
    Friend Mode As UtilAutoRec.Modes = Modes.Normal

    Public Sub New()
        Mode = Modes.Normal
        DebugEmailAddress = ""
    End Sub

    Public Sub New(pMode As UtilAutoRec.Modes, pDebugEmailAddress As String)
        Mode = pMode
        DebugEmailAddress = pDebugEmailAddress
    End Sub

    Public Sub ProcessAutoRecSurveyProcessTable(id As Integer)

        Dim con As SqlClient.SqlConnection = UtilSQLServer.GetConnectionObject()
        Dim cmd As New SqlClient.SqlCommand("SELECT * FROM AutoRecSurveyProcess WHERE ID=@Id", con)
        cmd.Parameters.AddWithValue("@Id", id)
        Dim dt As New DataTable

        Using con
            Using cmd
                dt.Load(cmd.ExecuteReader)
            End Using
        End Using

        ProcessAutoRecSurveyData(dt)
    End Sub


    Public Sub ProcessAutoRecSurveyProcessTable()

        Dim con As SqlClient.SqlConnection = UtilSQLServer.GetConnectionObject()
        Dim cmd As New SqlClient.SqlCommand("SELECT * FROM AutoRecSurveyProcess WHERE Processed=@Processed", con)
        cmd.Parameters.AddWithValue("@Processed", False)
        Dim dt As New DataTable

        Using con
            Using cmd
                dt.Load(cmd.ExecuteReader)
            End Using
        End Using

        ProcessAutoRecSurveyData(dt)

    End Sub

    Public Sub ProcessAutoRecSurveyData(dt As DataTable)

        For Each r As DataRow In dt.Rows

            Dim Status As String = ""

            Try
                ProcessInitialEmail(CInt(r("RRLogID")))
                Status = "Processed!"

            Catch ex As Exception

                Status = "Error: " & ex.GetBaseException.Message

                Dim zTo As String = UtilSetting.GetValue(UtilSetting.Keys.TaskAgentExceptionRecipients)
                Dim zSubject As String = String.Format("Exception Processing AutoRecSurvey Process table ({0})", r("Id"))
                Dim zBody As String = UtilException.ExtractExceptionDataHTML(ex, True)

                UtilNotification.SubmitNotification(zTo, "", "", zSubject, zBody, "Auto Rec Initial Email (Survey Process)")

            End Try

            Dim con As SqlClient.SqlConnection = UtilSQLServer.GetConnectionObject()
            Dim cmd As New SqlClient.SqlCommand("Update AutoRecSurveyProcess SET Processed=1, ProcessDate=GETDATE(), StatusMsg=@StatusMsg", con)
            cmd.Parameters.AddWithValue("@StatusMsg", Status)

            Using con
                Using cmd
                    cmd.ExecuteNonQuery()
                End Using
            End Using

        Next

    End Sub

    Public Sub ProcessLogOut(pRRLogId As Integer, pRRClient As rowVwRRClients, Optional pLogoutType As String = "SYSTEM AUTOREC LOGOUT")
        Dim zData As New AutoRecData
        Dim zRRLog As rowTblRRLog = TblRRLog.LoadByPrimaryKey(pRRLogId)

        Dim zTemplate As Template = zData.FindTemplate(zRRLog.colFilePrefix.ToString, ProcessType.Logout)
        zTemplate.SetVariables(zRRLog, zData)

        Dim zBatchSet As New BatchSet()
        zBatchSet.AddFileNo(zRRLog.colFileNo)
        zBatchSet.SetParameters.FileNo = zRRLog.colFileNo
        zBatchSet.SetParameters.FilePrefix = zRRLog.colFilePrefix
        zBatchSet.SetParameters.Currency = [Enum].Parse(GetType(TblMetaCurrency.Currencies), pRRClient.colDefaultMetaCurrencyID)
        zBatchSet.colFldFileName = zTemplate.Variables.Location.colClient & "_" & zTemplate.Variables.GetPracticeName & " RecResponse_" & zRRLog.colFileNo & "_" & Format(Now, "dd-MMM-yy") & ".pdf"
        zBatchSet.Type = BatchSet.BatchType.Report
        zBatchSet.colFldIsMyBatchReport = False
        zBatchSet.colFldCreatedByGsafeUserEmail = pLogoutType

        Select Case zRRLog.colPracticeCode
            Case "510", "515", "519"
                zBatchSet.AddSetItem(305)           ' previously 123

            Case "520", "525", "529"
                zBatchSet.AddSetItem(306)           ' previously 109

            Case "530", "535", "539"
                zBatchSet.AddSetItem(308)           ' previously 138

            Case "526"
                Select Case zRRLog.colHazard.ToLower

                    Case "seismic"
                        zBatchSet.AddSetItem(311)   ' previously 148

                    Case "flood"
                        zBatchSet.AddSetItem(307)   ' previously 144

                    Case "wind"
                        zBatchSet.AddSetItem(312)   ' previously 152

                End Select

            Case "550", "555", "559"
                zBatchSet.AddSetItem(309)           ' previously 277

            Case "570", "575", "579"
                zBatchSet.AddSetItem(310)           ' previously 303

        End Select

        '  340	[CLONED 322] PSRecommendationsAll **USED IN AUTOREC LOGOUT EMAIL**
        '339	[CLONED 290] NHRecommendationsAll  **USED IN AUTOREC LOGOUT EMAIL**
        '338	[CLONED 173] IRRecommendationsAll  **USED IN AUTOREC LOGOUT EMAIL**
        '337	[CLONED 171] FireRecommendationsAll  **USED IN AUTOREC LOGOUT EMAIL**
        '336	[CLONED 169] BMRecommendationsAll  **USED IN AUTOREC LOGOUT EMAIL**

        'CREATE THE BATCHSET THAT WILL RUN THE MONTHLY OVERDUE EXTRACT
        Dim zBatchSet2 = New BatchSet()
        With zBatchSet2
            .AddFileNo(zRRLog.colFileNo)   'NEED TO BUILD LIST OF FILENOS
            .SetParameters.FileNo = zRRLog.colFileNo
            .colFldFileName = zTemplate.Variables.Location.colClient & "_" & zTemplate.Variables.GetPracticeName & " RecResponse_" & zRRLog.colFileNo & "_" & Format(Now, "dd-MMM-yy") & ".xlsx"
            .Type = BatchSet.BatchType.XLSX
            .colFldIsMyBatchReport = False
            .colFldCreatedByGsafeUserEmail = pLogoutType
            .colFldLOFilterJSON = "{'logic':'and','filters':[{'logic':'and','filters':[{'field':'RecStatus','operator':'neq','value':'Advisory'},{'field':'RecStatus','operator':'neq','value':'Conf Completed'},{'field':'RecStatus','operator':'neq','value':'Removed'}]}]}"
            .SetParameters.Currency = [Enum].Parse(GetType(TblMetaCurrency.Currencies), pRRClient.colDefaultMetaCurrencyID)

            'Recommendations All Grids
            Select Case zRRLog.colPracticeCode
                Case "510", "515", "519"
                    zBatchSet2.AddSetItem(336)

                Case "520", "525", "529"
                    zBatchSet2.AddSetItem(337)

                Case "530", "535", "539"
                    zBatchSet2.AddSetItem(338)

                Case "526", "550", "555", "559"
                    zBatchSet2.AddSetItem(339)

                Case "570", "575", "579"
                    zBatchSet2.AddSetItem(340)
            End Select
        End With

        Dim zEmailProcessing As New BatchEmail

        'ADD TO
        zEmailProcessing.AddTo(New System.Net.Mail.MailAddress(zRRLog.colRecipientEmail, zRRLog.colRecipientName))
        If zRRLog.colRecipientEmail <> zRRLog.colLinkActivatedByEmail Then zEmailProcessing.AddTo(zRRLog.colLinkActivatedByEmail, zRRLog.colLinkActivatedBy)

        'ADD CC
        If zRRLog.colChanged Then
            SetCc(zEmailProcessing, zRRLog.colFilePrefix, TblMetaPractice.GetPractice(zRRLog.colPracticeCode.ToString), zTemplate)
        End If

        'ADD BCC
        SetBcc(zEmailProcessing, zRRLog.colFilePrefix, TblMetaPractice.GetPractice(zRRLog.colPracticeCode.ToString), zTemplate)

        'SET BATCH SET SUBJECT AND BODY
        zEmailProcessing.colFldSubject = zTemplate.Template.colFldSubject
        zEmailProcessing.colFldBody = WrapInDiv(zTemplate.Template.colFldBody)

        zEmailProcessing.BatchSets.Add(zBatchSet)
        zEmailProcessing.BatchSets.Add(zBatchSet2)

        Dim List As New BatchSetList(zBatchSet, zBatchSet2)
        List.SaveAll()

        SendEmail(zEmailProcessing)
        SetResponseToInactive(zRRLog)

    End Sub

    Public Sub ProcessInitialEmail(ByVal zRRLogID As Integer)

        Dim zData As New AutoRecData
        Dim zRRLog As rowTblRRLog = TblRRLog.LoadByPrimaryKey(zRRLogID)

        Dim zTemplate As Template = zData.FindTemplate(zRRLog.colFilePrefix.ToString, ProcessType.Initial)
        zTemplate.SetVariables(zRRLog, zData)

        Dim zTo As String = New System.Net.Mail.MailAddress(zRRLog.colRecipientEmail, zRRLog.colRecipientName).ToString()
        Dim zCc As String = GetCc(zRRLog.colFilePrefix, TblMetaPractice.GetPractice(zRRLog.colPracticeCode.ToString), zTemplate)
        Dim zBcc As String = GetBcc(zRRLog.colFilePrefix, TblMetaPractice.GetPractice(zRRLog.colPracticeCode.ToString), zTemplate)
        Dim zSubject As String = zTemplate.Template.colFldSubject
        Dim zBody As String = WrapInDiv(zTemplate.Template.colFldBody)

        ''all practices that end with 9 are self inspection surveys
        If zRRLog.colPracticeCode.ToString.EndsWith("9") Then
            If zCc <> "" Then
                zCc = String.Format("{0},{1}", zCc, UtilSetting.GetValue(UtilSetting.Keys.AutoRecInitialSelfAuditCCAddresses))
            Else
                zCc = String.Format("{0}", UtilSetting.GetValue(UtilSetting.Keys.AutoRecInitialSelfAuditCCAddresses))
            End If
        End If

        UtilNotification.SubmitNotification(zTo, zCc, zBcc, zSubject, zBody, "Auto Rec Initial Email")

        SetResponseToInactive(zRRLog)

    End Sub

    Public Sub ProcessCleanUp()
        Dim zCleanUps As List(Of rowVwRRLogCleanUp) = VwRRLogCleanUp.LoadData
        Dim zRRClients As List(Of rowVwRRClients) = VwRRClients.LoadData
        For Each zCleanUp As rowVwRRLogCleanUp In zCleanUps
            ProcessLogOut(zCleanUp.colId, zRRClients.Find(Function(x) x.colFileprefix = zCleanUp.colFilePrefix), "SYSTEM AUTOREC LOGOUT (CLEANUP)")
        Next

        ''we also want to process the AutoRecSurveyProcess table
        ProcessAutoRecSurveyProcessTable()

    End Sub

    Public Sub ProcessDailyFollowUps()
        ProcessDailyFollowUpsByFilePrefix()
    End Sub

    Public Sub ProcessDailyFollowUpsByFilePrefix(ParamArray pFilePrefix() As String)

        Dim zResult As List(Of String) = UtilValidate.ValidateEmailAddresses
        If zResult.Count = 0 Then
            Dim zData As New FollowUpAutoRecData
            Dim zRRClients As List(Of rowVwRRClients) = zData.ClientDict.Values.ToList()
            If pFilePrefix.Count > 0 Then zRRClients = zRRClients.FindAll(Function(x) pFilePrefix.Contains(x.colFileprefix))

            For Each zClient As rowVwRRClients In zRRClients
                ProcessDailyFollowUp(ProcessType.FollowUp3rd, zClient, zData)
                ProcessDailyFollowUp(ProcessType.FollowUp2nd, zClient, zData)
                ProcessDailyFollowUp(ProcessType.FollowUp1st, zClient, zData)
            Next

        Else
            Dim zEx As New Exception("Process daily follow ups can not continue due to invalid email addresses found in database tables.")
            zEx.Data.Add("Data", zResult.ToArray)
            Throw zEx
        End If

    End Sub

    Private Sub ProcessDailyFollowUp(pARProcessType As UtilAutoRec.ProcessType, pClient As rowVwRRClients, pData As FollowUpAutoRecData)

        Dim zClientFollowUps As List(Of rowVwRRLogFollowUp) = pData.FindFollowUps(pARProcessType, pClient)
        If zClientFollowUps.Count > 0 Then
            For Each zFollowUp As rowVwRRLogFollowUp In zClientFollowUps
                Dim zRRLog As rowTblRRLog = pData.RRLogDict(zFollowUp.colRRLogId)
                Dim zTemplate As UtilAutoRec.Template = pData.FindTemplate(pClient.colFileprefix, pARProcessType)

                Try

                    zTemplate.SetVariables(zRRLog, pData)

                    Dim zFollowUpIsValid As Boolean = ValidateDailyFollowUp(zRRLog, pClient, pARProcessType)
                    If Not zFollowUpIsValid Then SendAdminAlert(zRRLog, pARProcessType, "Process would have sent consecutive follow-ups in a row.", zTemplate)

                    Dim zStatusDateIsValid As Boolean = ValidateStatusDate(zRRLog, pData.FollowUpRecStatusDates)
                    If Not zStatusDateIsValid Then SendAdminAlert(zRRLog, pARProcessType, "Status Date is greater than the Date the Link was last issued.", zTemplate)

                    If zFollowUpIsValid And zStatusDateIsValid Then

                        Dim zTo As String = New System.Net.Mail.MailAddress(zRRLog.colRecipientEmail, zRRLog.colRecipientName).ToString()
                        Dim zCc As String = GetCc(zRRLog.colFilePrefix, TblMetaPractice.GetPractice(zRRLog.colPracticeCode.ToString), zTemplate)
                        Dim zBcc As String = GetBcc(zRRLog.colFilePrefix, TblMetaPractice.GetPractice(zRRLog.colPracticeCode.ToString), zTemplate)
                        Dim zSubject As String = zTemplate.Template.colFldSubject
                        Dim zBody As String = WrapInDiv(zTemplate.Template.colFldBody)

                        Try
                            UpdateFollowUpDate(zRRLog, pARProcessType)
                            UtilNotification.SubmitNotification(zTo, zCc, zBcc, zSubject, zBody, "Auto Rec Daily Follow-Up")
                            Trace.WriteLine("Daily Follow Notification Submitted: " & zSubject)
                        Catch ex As Exception
                            SetFollowUpDateToNothing(zRRLog, pARProcessType)
                            Throw
                        End Try

                    End If

                Catch ex As Exception
                    SendAdminAlert(zRRLog, pARProcessType, ex.GetBaseException.Message, zTemplate)
                End Try
            Next
        End If
    End Sub

    'This function test to make sure the followup is valid and will not send consecutive followups in a row
    Private Function ValidateDailyFollowUp(pRRLog As rowTblRRLog, pClient As rowVwRRClients, pARProcessType As UtilAutoRec.ProcessType) As Boolean

        'GET THE THRID FOLLOW UP DAYS FOR CLIENT
        Dim zThirdFollowUpDays As Integer = pClient.colRecfollowup3
        Dim zDontSendEmailDays As Integer = zThirdFollowUpDays + 30
        Dim zAdminWasNotified As Boolean = False
        If IsNothing(pRRLog.colAdminAlertDate) Then zAdminWasNotified = False Else zAdminWasNotified = True

        Select Case pARProcessType
            Case ProcessType.FollowUp3rd
                If IsNothing(pRRLog.colRFU2Date) Or zAdminWasNotified Then
                    Return False
                Else
                    If (pRRLog.colRFU2Date > Today.AddDays(-3)) Or zAdminWasNotified Then
                        Return False
                    ElseIf (Today >= pRRLog.colDateStamp.Value.AddDays(zDontSendEmailDays)) Or zAdminWasNotified Then
                        Return False
                    End If
                End If

            Case ProcessType.FollowUp2nd
                If IsNothing(pRRLog.colRFU1Date) Or zAdminWasNotified Then
                    Return False
                Else
                    If (pRRLog.colRFU1Date > Today.AddDays(-3)) Or zAdminWasNotified Then
                        Return False
                    ElseIf (Today >= pRRLog.colDateStamp.Value.AddDays(zDontSendEmailDays)) Or zAdminWasNotified Then
                        Return False
                    End If
                End If

            Case ProcessType.FollowUp1st
                If IsNothing(pRRLog.colDateStamp) Or zAdminWasNotified Then
                    Return False
                Else
                    If (pRRLog.colDateStamp > Today.AddDays(-3)) Or zAdminWasNotified Then
                        Return False
                    ElseIf (Today >= pRRLog.colDateStamp.Value.AddDays(zDontSendEmailDays)) Or zAdminWasNotified Then
                        Return False
                    End If
                End If

        End Select

        Return True

    End Function

    Public Function ValidateStatusDate(pRRLog As rowTblRRLog, pRecStatusDates As List(Of rowVwRRLogFollowUpRecStatusDate)) As Boolean
        Dim zFilteredList As List(Of rowVwRRLogFollowUpRecStatusDate) = pRecStatusDates.FindAll(Function(x) x.colFileNo = pRRLog.colFileNo And x.colPracticeCode = pRRLog.colPracticeCode)

        'CHECK TO SEE IFT HE STATUS DATE OF ANY RECOMMENDATION IS GREATER THAN TODAYS DATE
        For Each zRec As rowVwRRLogFollowUpRecStatusDate In zFilteredList
            If zRec.colStatusDate > pRRLog.colDateStamp Then
                Return False
            End If
        Next
        Return True
    End Function


    Public Sub SendAdminAlert(ByVal pRR As rowTblRRLog, ByVal pARProcessType As UtilAutoRec.ProcessType, ByVal pReason As String, zTemplate As Template)

        'WE ARE GOING TO SEND THE ADMIN AN ALERT IF THE ADMINALERT DATE IS NULL, NOTHING OR OLDER THAN TODAY.

        If (IsNothing(pRR.colAdminAlertDate) OrElse (pRR.colAdminAlertDate < Today)) Then

            'GET ADMIN EMAIL ADDRESS
            Dim zClientDBAAddress As String = UtilSetting.GetValue(UtilSetting.Keys.AutoRecAdminAddress)

            'GET ADMIN HTML TEXT
            Dim zAdminText As String = UtilHTML.CreateAutoRecNoSendAdminText(pRR.colId, pReason)

            'CREATE EMAIL
            Dim zTo As String = zClientDBAAddress
            Dim zCc As String = ""
            If Not IsNothing(Job.colFldAlwaysCcRecipients) Then zCc = Job.colFldAlwaysCcRecipients

            Dim zBcc As String = ""
            If Not IsNothing(Job.colFldAlwaysBccRecipients) Then zBcc = Job.colFldAlwaysBccRecipients

            Dim zSubject As String = zTemplate.Template.colFldSubject
            Dim zBody As String = zAdminText & zTemplate.Template.colFldBody

            UtilNotification.SubmitNotification(zTo, zCc, zBcc, zSubject, zBody, "Admin Alert Notification")

            'UPDATE RRLOG WITH ADMINALERTDATE
            pRR.colAdminAlertReason = pReason
            pRR.colAdminAlertDate = Now
            TblRRLog.Save(pRR)

            ArchiveRRLog(pRR)

        End If

    End Sub

    Private Sub SetTo(ByVal pEmailProcessing As BatchEmail, pFilePrefix As String, pPractice As TblMetaPractice.Practices, pTemplate As Template)
        Dim zEzyCol As List(Of rowTblEzyUsers) = pTemplate.Data.FindUsersByFilePrefix(pFilePrefix)
        If zEzyCol.Count > 0 Then
            For Each zEzyUser As rowTblEzyUsers In zEzyCol
                If IsNothing(zEzyUser.colGRCAdministrator) OrElse zEzyUser.colGRCAdministrator <> "00" Then 'Never CC 00 users.
                    If Not pEmailProcessing.ExistsInTo(zEzyUser.colEmail) Then
                        If UserWantsEmail(zEzyUser, pFilePrefix, pPractice, pTemplate.ARProcessType) Then
                            pEmailProcessing.AddTo(zEzyUser.colEmail, zEzyUser.colFullName)
                        End If
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub SetCc(ByVal pEmailProcessing As BatchEmail, pFilePrefix As String, pPractice As TblMetaPractice.Practices, pTemplate As Template)
        Dim zEzyCol As List(Of rowTblEzyUsers) = pTemplate.Data.FindUsersByFilePrefix(pFilePrefix)
        If zEzyCol.Count > 0 Then
            For Each zEzyUser As rowTblEzyUsers In zEzyCol
                If IsNothing(zEzyUser.colGRCAdministrator) OrElse zEzyUser.colGRCAdministrator <> "00" Then 'Never CC 00 users.
                    If UserHasLocation(zEzyUser, pTemplate.Variables.Location) Then
                        If UserWantsEmail(zEzyUser, pFilePrefix, pPractice, pTemplate.ARProcessType) Then
                            If Not pEmailProcessing.ExistsInCc(zEzyUser.colEmail) Then
                                pEmailProcessing.AddCc(zEzyUser.colEmail, zEzyUser.colFullName)
                            End If
                        End If
                    End If
                End If
            Next
        End If

        'Always CC AutoRec EmailAddress
        If Not IsNothing(Job.colFldAlwaysCcRecipients) Then
            Dim zAlwaysCC() As String = Split(Job.colFldAlwaysCcRecipients, ",")
            For Each zAddress As String In zAlwaysCC
                If Not pEmailProcessing.ExistsInCc(zAddress) Then
                    pEmailProcessing.AddCc(zAddress)
                End If
            Next
        End If

    End Sub

    Private Function GetCc(pFilePrefix As String, pPractice As TblMetaPractice.Practices, pTemplate As Template) As String
        Dim zReturn As New List(Of String)
        Dim zBatchEmail As New BatchEmail
        SetCc(zBatchEmail, pFilePrefix, pPractice, pTemplate)
        Return zBatchEmail.colFldCc
    End Function

    Private Function GetBcc(pFilePrefix As String, pPractice As TblMetaPractice.Practices, pTemplate As Template) As String
        Dim zReturn As New List(Of String)
        Dim zBatchEmail As New BatchEmail
        SetBcc(zBatchEmail, pFilePrefix, pPractice, pTemplate)
        Return zBatchEmail.colFldBcc
    End Function

    Private Sub SetBcc(ByVal pEmailProcessing As BatchEmail, pFilePrefix As String, pPractice As TblMetaPractice.Practices, pTemplate As Template)
        Dim zEzyCol As List(Of rowTblEzyUsers) = pTemplate.Data.FindUsersByFilePrefix(pFilePrefix)
        zEzyCol = zEzyCol.FindAll(Function(x) x.colGRCAdministrator = "00")

        For Each zEzyUser As rowTblEzyUsers In zEzyCol
            If Not pEmailProcessing.ExistsInBcc(zEzyUser.colEmail) Then
                If UserWantsEmail(zEzyUser, pFilePrefix, pPractice, pTemplate.ARProcessType) Then
                    pEmailProcessing.AddBcc(zEzyUser.colEmail, zEzyUser.colFullName)
                End If
            End If
        Next

        'Always BCC AutoRec EmailAddress
        If Not IsNothing(Job.colFldAlwaysBccRecipients) Then
            Dim zAlwaysBCC() As String = Split(Job.colFldAlwaysBccRecipients, ",")
            For Each zAddress As String In zAlwaysBCC
                If Not pEmailProcessing.ExistsInBcc(zAddress) Then
                    pEmailProcessing.AddBcc(zAddress)
                End If
            Next
        End If

        If Not pEmailProcessing.ExistsInBcc(UtilSetting.GetValue(UtilSetting.Keys.AutoRecBCCAddress)) Then
            pEmailProcessing.AddBcc(UtilSetting.GetValue(UtilSetting.Keys.AutoRecBCCAddress))
        End If

    End Sub

    Public Sub ProcessMonthlyFollowUps()
        Dim zResult As List(Of String) = UtilValidate.ValidateEmailAddresses
        If zResult.Count = 0 Then
            ProcessMonthlyFollowUpsByFilePrefix(False)
        Else
            Dim zEx As New Exception("Process monthly follow ups can not continue due to invalid email addresses found in database tables.")
            zEx.Data.Add("Data", zResult.ToArray)
            Throw zEx
        End If
    End Sub

    Public Sub ProcessMonthlyFollowUpsByFilePrefix(pIgnoreLastProcessedDate As Boolean, ParamArray pFilePrefix() As String)

        Dim zData As New AutoRequestAutoRecData
        Dim zPractices As TblMetaPractice.Practices() = ({TblMetaPractice.Practices.BM, TblMetaPractice.Practices.Fire, TblMetaPractice.Practices.Infrared, TblMetaPractice.Practices.NaturalHazards, TblMetaPractice.Practices.ProcessSafety})
        Dim zRRClients As List(Of rowVwRRClients) = zData.ClientDict.Values.ToList()
        If pFilePrefix.Count > 0 Then zRRClients = zRRClients.FindAll(Function(x) pFilePrefix.Contains(x.colFileprefix))

        Dim zEzyManagerTypes() As UtilAutoRec.EzUserManagerType = _
        {EzUserManagerType.RiskManager, EzUserManagerType.DivisionManager, EzUserManagerType.CustomAccessManager, _
         EzUserManagerType.ClientLocNoManager, EzUserManagerType.FacilityManager, EzUserManagerType.CityManager, _
         EzUserManagerType.StProvManager, EzUserManagerType.CountryManager}

        For Each zRRClient As rowVwRRClients In zRRClients

            For Each zPractice As TblMetaPractice.Practices In zPractices
                If IsNothing(zRRClient.colAutoRecLastProcessDate) OrElse (zRRClient.colAutoRecLastProcessDate.Value.AddDays(27) < Now) Or pIgnoreLastProcessedDate Then

                    If Mode <> Modes.NoDataUpdates Then
                        Dim zClient As rowTblClients = zRRClient.ToClient
                        zClient.colAutoRecLastProcessDate = Now
                        TblClients.Save(zClient)
                    End If

                    For Each zManagerType As UtilAutoRec.EzUserManagerType In zEzyManagerTypes
                        ProcessMonthlyFollowUpByManagerType(ProcessType.Overdue3rd, zRRClient, zData, zPractice, zManagerType)
                        ProcessMonthlyFollowUpByManagerType(ProcessType.Overdue2nd, zRRClient, zData, zPractice, zManagerType)
                        ProcessMonthlyFollowUpByManagerType(ProcessType.Overdue1st, zRRClient, zData, zPractice, zManagerType)
                        ProcessMonthlyFollowUpByManagerType(ProcessType.ExpiredOverdue, zRRClient, zData, zPractice, zManagerType)
                    Next

                    ProcessMonthlyExpiringExpiredAlerts(ProcessType.ExpiringExpectedCompletionDate, zRRClient, zData, zPractice)

                End If

            Next

        Next

        'INSERT THE EXPIRING ALERTY SUMMARY
        If Mode <> Modes.NoDataUpdates Then
            Dim zCon As SqlClient.SqlConnection = UtilSQLServer.GetConnectionObject
            Dim zSQL As New SqlClient.SqlCommand("spInsertClientExpiringAlertLog", zCon)
            zSQL.CommandType = CommandType.StoredProcedure

            If zCon.State <> ConnectionState.Open Then zCon.Open()
            Using zCon
                zSQL.ExecuteNonQuery()
                zSQL.Dispose()
                zSQL = Nothing
            End Using
        End If

    End Sub

    Private Sub ProcessMonthlyFollowUpByManagerType(pARProcessType As UtilAutoRec.ProcessType, pClient As rowVwRRClients, pData As AutoRequestAutoRecData, pPractice As TblMetaPractice.Practices, pEzUserManagerType As EzUserManagerType)

        'FILTER DATA WILL CONTAIN A UNIQUE LIST OF DIVISIONS, CLIENTLOCNO, COUNTRIES, CUSTOMACCESS, FACILITIES OR STPROVS DEPENDING ON THE USER FILTER.
        Dim zFilterData As New List(Of String)

        Select Case pEzUserManagerType

            Case EzUserManagerType.RiskManager
                zFilterData.Add(pClient.colFileprefix)  'we are adding the file prefix for the risk manager.

            Case EzUserManagerType.DivisionManager
                zFilterData = pData.FindDivisionsByFilePrefix(pClient.colFileprefix)

            Case EzUserManagerType.ClientLocNoManager
                zFilterData = pData.FindClientLocNoByFilePrefix(pClient.colFileprefix)

            Case EzUserManagerType.CountryManager
                zFilterData = pData.FindCountryByFilePrefix(pClient.colFileprefix)

            Case EzUserManagerType.CustomAccessManager
                zFilterData = pData.FindCustomAccessesByFilePrefix(pClient.colFileprefix)

            Case EzUserManagerType.CityManager
                zFilterData = pData.FindCityByFilePrefix(pClient.colFileprefix)

            Case EzUserManagerType.FacilityManager
                zFilterData = pData.FindFacilityByFilePrefix(pClient.colFileprefix)

            Case EzUserManagerType.StProvManager
                zFilterData = pData.FindStProvByFilePrefix(pClient.colFileprefix)

        End Select


        For Each zItem As String In zFilterData

            Dim zUserFilter As New UserFilter(pEzUserManagerType, zItem)

            If pData.NeedsProcessing(pARProcessType, pPractice, pClient.colFileprefix, zUserFilter) Then

                Trace.WriteLine("PROCESSING MANAGER: " & pEzUserManagerType.ToString & " [" & zItem & "]".PadRight(25) & pARProcessType.ToString.PadRight(25) & pPractice.ToString.PadRight(20) & pClient.colClientname.PadRight(40))

                'GET EZYUSERS FOR THIS CLIENT FROM FILTER
                Dim zEzyUsers As List(Of rowTblEzyUsers) = pData.FindClientUsersByFilter(pClient.colFileprefix, zUserFilter)

                'FILTER OUT USERS THAT ONLY WANT TO GET THIS AUTOREQUEST EMAIL
                FilterUsersToEmail(pClient.colFileprefix, pPractice, pARProcessType, zEzyUsers)

                'IF THERE ARE STILL USERS
                If zEzyUsers.Count > 0 Then

                    'LOAD TEMPLATE
                    Dim zTemplate As UtilAutoRec.Template = pData.FindTemplate(pClient.colFileprefix, pARProcessType)
                    zTemplate.SetVariables(pClient.colFileprefix, pPractice, pData)
                    zTemplate.Template.colFldSubject = zTemplate.Template.colFldSubject & GetSubjectFilterBy(zUserFilter, zItem, pClient)

                    'CREATE THE BATCHSET
                    Dim zBatchSetList As List(Of BatchSet) = Nothing
                    Dim zJSONFilter As JSONFilter = Nothing
                    If zUserFilter.Filter <> EzUserManagerType.RiskManager Then zJSONFilter = CreateJSONFilter(zUserFilter)

                    Select Case pARProcessType
                        Case ProcessType.Overdue1st, ProcessType.Overdue2nd, ProcessType.Overdue3rd
                            zBatchSetList = CreateMonthlyOverdueBatchSetList(pARProcessType, zTemplate, pClient.colFileprefix, zJSONFilter, pClient)
                        Case ProcessType.ExpiredOverdue
                            zBatchSetList = CreateMonthlyExpectedCompletionOverdueBatchSetList(zTemplate, pClient.colFileprefix, zJSONFilter, pClient)
                    End Select

                    'CREATE THE EMAIL; ASSIGN BATCHSETS TO EMAIL
                    Dim zEmailProcessing As BatchEmail = New BatchEmail
                    zEmailProcessing.colFldSubject = zTemplate.Template.colFldSubject
                    zEmailProcessing.colFldBody = zTemplate.Template.colFldBody
                    zBatchSetList.ForEach(Sub(x) zEmailProcessing.BatchSets.Add(x))

                    zEzyUsers.ForEach(Sub(x) zEmailProcessing.AddTo(x.colEmail, x.colFullName))
                    SetBcc(zEmailProcessing, pClient.colFileprefix, pPractice, zTemplate)

                    If zEmailProcessing.colFldTo.Length > 0 Then
                        SendEmail(zEmailProcessing)
                    End If

                End If

            End If

        Next

    End Sub

    Private Sub ProcessMonthlyExpiringExpiredAlerts(pARProcessType As UtilAutoRec.ProcessType, pClient As rowVwRRClients, pData As AutoRequestAutoRecData, pPractice As TblMetaPractice.Practices)

        If pData.NeedsProcessing(pARProcessType, pPractice, pClient.colFileprefix, Nothing) Then

            Trace.WriteLine("MonthlyExpiringExpiredAlerts".PadRight(25) & pARProcessType.ToString.PadRight(25) & pPractice.ToString.PadRight(20) & pClient.colClientname.PadRight(40))

            'GET LOCATIONS THAT NEED ALERTS
            Dim List As List(Of rowVwRRExpiringExpiredExpectedCompletedDate) = pData.AutoRequestEEECD.FindAll(Function(x) x.colFilePrefix = pClient.colFileprefix And x.colPracticeId = pPractice)

            For Each zExpiringLocation As rowVwRRExpiringExpiredExpectedCompletedDate In List

                Dim zRRLog As rowTblRRLog = pData.FindRRLog(zExpiringLocation.colRRLogID)

                'LOAD TEMPLATE
                Dim zTemplate As UtilAutoRec.Template = pData.FindTemplate(pClient.colFileprefix, pARProcessType)
                zTemplate.SetVariables(zRRLog, pData)

                'SEND NOTIFICATION
                Dim zTo As String = New System.Net.Mail.MailAddress(zRRLog.colRecipientEmail, zRRLog.colRecipientName).ToString()
                Dim zCc As String = GetCc(pClient.colFileprefix, pPractice, zTemplate)
                Dim zBcc As String = GetBcc(pClient.colFileprefix, pPractice, zTemplate)
                Dim zSubject As String = zTemplate.Template.colFldSubject
                Dim zBody As String = WrapInDiv(zTemplate.Template.colFldBody)

                Try
                    UtilNotification.SubmitNotification(zTo, zCc, zBcc, zSubject, zBody, "Auto Rec Expiring Notification")
                Catch ex As Exception
                    Throw
                End Try

            Next

        End If


    End Sub


    Private Function CreateMonthlyOverdueBatchSetList(pARProcessType As UtilAutoRec.ProcessType, pTemplate As UtilAutoRec.Template, pFilePrefix As String, pJSONFilter As JSONFilter, pRRClient As rowVwRRClients) As List(Of BatchSet)
        Dim zReturn As New List(Of BatchSet)
        Dim zFileName As String = "Pending" & pTemplate.Variables.GetPracticeName & "RecResponseFollowUp"
        Dim zFileNoList As List(Of String) = UtilFileNo.BuildList(pFilePrefix, pJSONFilter)


        'CREATE THE BATCHSET THAT WILL RUN THE MONTHLY OVERDUE REPORT AND EXTRACT
        Dim zBatchSet1 As New BatchSet()
        With zBatchSet1

            .AddFileNo(zFileNoList.ToArray)   'NEED TO BUILD LIST OF FILENOS
            .SetParameters.FilePrefix = pFilePrefix
            .colFldFileName = zFileName
            .Type = BatchSet.BatchType.Report
            .colFldIsMyBatchReport = False
            .colFldCreatedByGsafeUserEmail = "SYSTEM AUTOREC"
            .SetParameters.Currency = [Enum].Parse(GetType(TblMetaCurrency.Currencies), pRRClient.colDefaultMetaCurrencyID)

            'CREATE AND ADD THE FILTER
            Dim zFilter As JSONFilter = pJSONFilter
            If IsNothing(zFilter) Then zFilter = CreateAutoRequestFilter(pARProcessType) Else zFilter.Filters.Add(CreateAutoRequestFilter(pARProcessType))
            .colFldLOFilterJSON = zFilter.ToJSON

            Select Case pTemplate.Variables.Practice
                Case TblMetaPractice.Practices.BM
                    .AddSetItem(29)

                Case TblMetaPractice.Practices.Infrared
                    .AddSetItem(50)

                Case TblMetaPractice.Practices.Fire
                    .AddSetItem(2)

                Case TblMetaPractice.Practices.NatHazFlood
                    .AddSetItem(62)

                Case TblMetaPractice.Practices.NatHazSeismic
                    .AddSetItem(77)

                Case TblMetaPractice.Practices.NatHazWind
                    .AddSetItem(97)

                Case TblMetaPractice.Practices.NaturalHazards
                    .AddSetItem(248)

                Case TblMetaPractice.Practices.ProcessSafety
                    .AddSetItem(295)
            End Select

        End With

        'CREATE THE BATCHSET THAT WILL RUN THE MONTHLY OVERDUE EXTRACT
        Dim zBatchSet2 As New BatchSet()
        With zBatchSet2

            .AddFileNo(zFileNoList.ToArray)   'NEED TO BUILD LIST OF FILENOS
            .SetParameters.FilePrefix = pFilePrefix
            .colFldFileName = zFileName
            .Type = BatchSet.BatchType.XLSX
            .colFldIsMyBatchReport = False
            .colFldLOFilterJSON = zBatchSet1.colFldLOFilterJSON
            .colFldCreatedByGsafeUserEmail = "SYSTEM AUTOREC"
            .SetParameters.Currency = [Enum].Parse(GetType(TblMetaCurrency.Currencies), pRRClient.colDefaultMetaCurrencyID)

            Select Case pTemplate.Variables.Practice
                Case TblMetaPractice.Practices.BM
                    .AddSetItem(143)   'THESE ARE GRID IDS.  THE BATCH SET TYPE OF XLSX USES THE GRID IDS

                Case TblMetaPractice.Practices.Infrared
                    .AddSetItem(149)

                Case TblMetaPractice.Practices.Fire
                    .AddSetItem(147)

                Case TblMetaPractice.Practices.NatHazFlood
                    .AddSetItem(151)

                Case TblMetaPractice.Practices.NatHazSeismic
                    .AddSetItem(153)

                Case TblMetaPractice.Practices.NatHazWind
                    .AddSetItem(155)

                Case TblMetaPractice.Practices.NaturalHazards
                    .AddSetItem(286)

                Case TblMetaPractice.Practices.ProcessSafety
                    .AddSetItem(317)

            End Select
        End With

        zReturn.Add(zBatchSet1)
        zReturn.Add(zBatchSet2)
        zBatchSet1.Save()
        zBatchSet2.Save()
        Return zReturn

    End Function

    ''' <summary>
    ''' This function creates a batchset which contains the expected expired overdue batch report and extract.
    ''' </summary>
    ''' <param name="pTemplate"></param>
    ''' <param name="pFilePrefix"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CreateMonthlyExpectedCompletionOverdueBatchSetList(pTemplate As UtilAutoRec.Template, pFilePrefix As String, pJSONFilter As JSONFilter, pRRClient As rowVwRRClients) As List(Of BatchSet)
        Dim zReturn As New List(Of BatchSet)
        Dim zFileName As String = pTemplate.Variables.GetPracticeName & "Expiring-ExpiredExpectedCompletionDate"
        Dim zFileNoList As List(Of String) = UtilFileNo.BuildList(pFilePrefix, pJSONFilter)

        'CREATE THE BATCHSET THAT WILL RUN THE MONTHLY OVERDUE REPORT
        Dim zBatchSet1 As New BatchSet()
        With zBatchSet1
            .AddFileNo(zFileNoList.ToArray)   'NEED TO BUILD LIST OF FILENOS
            .SetParameters.FilePrefix = pFilePrefix
            .colFldFileName = zFileName
            .Type = BatchSet.BatchType.Report
            .colFldIsMyBatchReport = False
            .colFldCreatedByGsafeUserEmail = "SYSTEM AUTOREC"
            .SetParameters.Currency = [Enum].Parse(GetType(TblMetaCurrency.Currencies), pRRClient.colDefaultMetaCurrencyID)

            'CREATE AND ADD THE FILTER
            Dim zFilter As JSONFilter = pJSONFilter
            If Not IsNothing(zFilter) Then .colFldLOFilterJSON = zFilter.ToJSON

            Select Case pTemplate.Variables.Practice
                Case TblMetaPractice.Practices.BM
                    .AddSetItem(39)

                Case TblMetaPractice.Practices.Infrared
                    .AddSetItem(56)

                Case TblMetaPractice.Practices.Fire
                    .AddSetItem(18)

                Case TblMetaPractice.Practices.NatHazFlood
                    .AddSetItem(70)

                Case TblMetaPractice.Practices.NatHazSeismic
                    .AddSetItem(85)

                Case TblMetaPractice.Practices.NatHazWind
                    .AddSetItem(100)

                Case TblMetaPractice.Practices.NaturalHazards
                    .AddSetItem(261)

                Case TblMetaPractice.Practices.ProcessSafety
                    .AddSetItem(300)
            End Select

        End With

        'CREATE THE BATCHSET THAT WILL RUN THE MONTHLY OVERDUE EXTRACT
        Dim zBatchSet2 = New BatchSet()
        With zBatchSet2
            .AddFileNo(zFileNoList.ToArray)   'NEED TO BUILD LIST OF FILENOS
            .SetParameters.FilePrefix = pFilePrefix
            .colFldFileName = zFileName
            .Type = BatchSet.BatchType.XLSX
            .colFldIsMyBatchReport = False
            .colFldCreatedByGsafeUserEmail = "SYSTEM AUTOREC"
            .colFldLOFilterJSON = zBatchSet1.colFldLOFilterJSON
            .SetParameters.Currency = [Enum].Parse(GetType(TblMetaCurrency.Currencies), pRRClient.colDefaultMetaCurrencyID)

            Select Case pTemplate.Variables.Practice
                Case TblMetaPractice.Practices.BM
                    .AddSetItem(185)   'THESE ARE TRACKING GRID IDS.  THE BATCH SET TYPE OF XLSX USES THE GRID IDS

                Case TblMetaPractice.Practices.Infrared
                    .AddSetItem(187)

                Case TblMetaPractice.Practices.Fire
                    .AddSetItem(186)

                Case TblMetaPractice.Practices.NatHazFlood
                    .AddSetItem(188)

                Case TblMetaPractice.Practices.NatHazSeismic
                    .AddSetItem(190)

                Case TblMetaPractice.Practices.NatHazWind
                    .AddSetItem(189)

                Case TblMetaPractice.Practices.NaturalHazards
                    .AddSetItem(306)

                Case TblMetaPractice.Practices.ProcessSafety
                    .AddSetItem(319)
            End Select
        End With

        zReturn.Add(zBatchSet1)
        zReturn.Add(zBatchSet2)
        zBatchSet1.Save()
        zBatchSet2.Save()

        Return zReturn

    End Function

    Private Sub SendEmail(pEmailProcessing As BatchEmail)
        Trace.WriteLine(pEmailProcessing.colFldSubject)
        If Not (Mode And Modes.NoEmails) Then
            If DebugEmailAddress <> "" Then pEmailProcessing.AddBcc(DebugEmailAddress)
            TblBatchProcessingEmail.Save(pEmailProcessing)
        End If
    End Sub

    Private Function WrapInDiv(ByVal pValue As String) As String
        Dim zStyle As String = "<style>.myDiv, .myTable{font-family:calibri; font-size:10pt;}</style>"
        Return zStyle & "<div class='myDiv'>" & pValue & "</div>"
    End Function

    Private Sub UpdateFollowUpDate(pCurrentRRLog As rowTblRRLog, ARProcessType As UtilAutoRec.ProcessType)
        Select Case ARProcessType
            Case ProcessType.FollowUp1st
                pCurrentRRLog.colRFU1Date = Now
                pCurrentRRLog.colActivity = "RFU1"

            Case ProcessType.FollowUp2nd
                pCurrentRRLog.colRFU2Date = Now
                pCurrentRRLog.colActivity = "RFU2"

            Case ProcessType.FollowUp3rd
                pCurrentRRLog.colRFU3Date = Now
                pCurrentRRLog.colActivity = "RFU3"

        End Select

        If Mode <> Modes.NoDataUpdates Then
            TblRRLog.Save(pCurrentRRLog)
        End If

    End Sub

    Private Sub SetFollowUpDateToNothing(pCurrentRRLog As rowTblRRLog, ARProcessType As UtilAutoRec.ProcessType)
        Select Case ARProcessType
            Case ProcessType.FollowUp1st
                pCurrentRRLog.colRFU1Date = Nothing
                pCurrentRRLog.colActivity = "ADMIN"

            Case ProcessType.FollowUp2nd
                pCurrentRRLog.colRFU2Date = Nothing
                pCurrentRRLog.colActivity = "RFU1"

            Case ProcessType.FollowUp3rd
                pCurrentRRLog.colRFU3Date = Nothing
                pCurrentRRLog.colActivity = "RFU2"

        End Select

        If Not (Mode And Modes.NoDataUpdates) Then
            TblRRLog.Save(pCurrentRRLog)
        End If

    End Sub

    Private Sub SetResponseToInactive(ByRef pCurrentRRLog As rowTblRRLog)
        'UPDATE RR RECORD TO RESPONSE ACTIVE =0
        pCurrentRRLog.colResponseActive = False
        pCurrentRRLog.colChanged = False
        TblRRLog.Save(pCurrentRRLog)
    End Sub


    ''' <summary>
    ''' Checks to see if the ezyuser has access to this location
    ''' </summary>
    ''' <param name="ezyUser"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function UserHasLocation(ezyUser As rowTblEzyUsers, pFileNo As String, pDivision As String, pCustomAccess As String) As Boolean

        If ezyUser.colRiskManager Then Return True
        If ezyUser.colDivisionManager Then
            If Coalesce(ezyUser.colDivision) = pDivision Then Return True Else Return False
        End If
        If ezyUser.colPlantManager Then
            If Coalesce(ezyUser.colPlant) = pFileNo Then Return True Else Return False
        End If
        If ezyUser.colCustomAccess Then
            If Coalesce(ezyUser.colCustomAccessText) = pCustomAccess Then Return True Else Return False
        End If
        Return False
    End Function

    ''' <summary>
    ''' Checks to see if the ezyuser has access to this location
    ''' </summary>
    ''' <param name="ezyUser"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function UserHasLocation(ezyUser As rowTblEzyUsers, pLocation As rowVwAllLocations) As Boolean

        If ezyUser.colRiskManager Then Return True

        If ezyUser.colDivisionManager Then
            Return Coalesce(ezyUser.colDivision).ToString.Equals(Coalesce(pLocation.colDivision).ToString, StringComparison.OrdinalIgnoreCase)
        End If

        If ezyUser.colPlantManager Then
            Return Coalesce(ezyUser.colPlant).ToString.Equals(Coalesce(pLocation.colFileNo).ToString, StringComparison.OrdinalIgnoreCase)
        End If

        If ezyUser.colCustomAccess Then
            Return Coalesce(ezyUser.colCustomAccessText).ToString.Equals(Coalesce(pLocation.colCustomAccess).ToString, StringComparison.OrdinalIgnoreCase)
        End If

        If ezyUser.colClientLocNoManager Then
            Return Coalesce(ezyUser.colClientLocNoText).ToString.Equals(Coalesce(pLocation.colClientLocNo).ToString, StringComparison.OrdinalIgnoreCase)
        End If

        If ezyUser.colCountryManager Then
            Return Coalesce(ezyUser.colCountryText).ToString.Equals(Coalesce(pLocation.colCountry).ToString, StringComparison.OrdinalIgnoreCase)
        End If

        If ezyUser.colFacilityManager Then
            Return Coalesce(ezyUser.colFacilityText).ToString.Equals(Coalesce(pLocation.colFacility).ToString, StringComparison.OrdinalIgnoreCase)
        End If

        If ezyUser.colStProvManager Then
            Return Coalesce(ezyUser.colStProvText).ToString.Equals(Coalesce(pLocation.colStProv).ToString, StringComparison.OrdinalIgnoreCase)
        End If

        If ezyUser.colCityManager Then
            Return Coalesce(ezyUser.colCityText).ToString.Equals(Coalesce(pLocation.colCity).ToString, StringComparison.OrdinalIgnoreCase)
        End If

        Return False
    End Function


    ''' <summary>
    ''' This function determines if an email should be sent or copied to the user based on the various ezy_users fields (RINIT, RFU1, RFU2, RFU3, OVERDUE1, OVERDUE, ETC)
    ''' </summary>
    ''' <param name="ezyUser"></param>
    ''' <param name="pPractice"></param>
    ''' <param name="pARProcessType"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function UserWantsEmail(ezyUser As rowTblEzyUsers, pFilePrefix As String, pPractice As TblMetaPractice.Practices, pARProcessType As ProcessType) As Boolean

        Select Case pARProcessType

            Case UtilAutoRec.ProcessType.FollowUp1st
                Return ezyUser.colActiveUser And Coalesce(ezyUser.colRfu1).Contains(GetPracticeLetter(pPractice)) And ezyUser.colFilePrefix = pFilePrefix

            Case UtilAutoRec.ProcessType.FollowUp2nd
                Return ezyUser.colActiveUser And Coalesce(ezyUser.colRfu2).Contains(GetPracticeLetter(pPractice)) And ezyUser.colFilePrefix = pFilePrefix

            Case UtilAutoRec.ProcessType.FollowUp3rd
                Return ezyUser.colActiveUser And Coalesce(ezyUser.colRfu3).Contains(GetPracticeLetter(pPractice)) And ezyUser.colFilePrefix = pFilePrefix

            Case UtilAutoRec.ProcessType.Overdue1st
                Return ezyUser.colActiveUser And Coalesce(ezyUser.colROverdue1).Contains(GetPracticeLetter(pPractice)) And ezyUser.colFilePrefix = pFilePrefix

            Case UtilAutoRec.ProcessType.Overdue2nd
                Return ezyUser.colActiveUser And Coalesce(ezyUser.colROverdue2).Contains(GetPracticeLetter(pPractice)) And ezyUser.colFilePrefix = pFilePrefix

            Case UtilAutoRec.ProcessType.Overdue3rd
                Return ezyUser.colActiveUser And Coalesce(ezyUser.colROverdue3).Contains(GetPracticeLetter(pPractice)) And ezyUser.colFilePrefix = pFilePrefix

            Case UtilAutoRec.ProcessType.Initial
                Return ezyUser.colActiveUser And Coalesce(ezyUser.colRInit).Contains(GetPracticeLetter(pPractice)) And ezyUser.colFilePrefix = pFilePrefix

            Case UtilAutoRec.ProcessType.Logout
                Return ezyUser.colActiveUser And Coalesce(ezyUser.colRReport).Contains(GetPracticeLetter(pPractice)) And ezyUser.colFilePrefix = pFilePrefix

            Case UtilAutoRec.ProcessType.ExpiredOverdue
                Return ezyUser.colActiveUser And Coalesce(ezyUser.colExpOverdue).Contains(GetPracticeLetter(pPractice)) And ezyUser.colFilePrefix = pFilePrefix

            Case UtilAutoRec.ProcessType.ExpiringExpectedCompletionDate
                Return ezyUser.colActiveUser And Coalesce(ezyUser.colRExpd).Contains(GetPracticeLetter(pPractice)) And ezyUser.colFilePrefix = pFilePrefix

            Case Else
                Throw New ArgumentException("Argument is incorrect.", "_Parent.ARProcessType")

        End Select
    End Function

    Private Sub FilterUsersToEmail(pFilePrefix As String, pPractice As TblMetaPractice.Practices, pARProcessType As ProcessType, ByRef pListOfUsers As List(Of rowTblEzyUsers))
        Dim zReturn As New List(Of rowTblEzyUsers)
        pListOfUsers.ForEach(Sub(x) If UserWantsEmail(x, pFilePrefix, pPractice, pARProcessType) Then zReturn.Add(x))
        pListOfUsers = zReturn
    End Sub

    Private Function GetPracticeLetter(pPractice As TblMetaPractice.Practices) As String

        ''ADJUSTED CODE TO GET FROM TABLE -DB 05/17/18
        Dim zPractice As rowTblMetaPractice = Nothing
        If AutoRecData.MetaPracticesDict.TryGetValue(CInt(pPractice), zPractice) Then
            Return zPractice.colFldPracticeLetter
        Else
            Throw New ArgumentException("Practice was not set on UtilEmailTemplate.Variables.Practice property.")
        End If


        'Select Case pPractice
        '    Case TblMetaPractice.Practices.BM
        '        Return "B"
        '    Case TblMetaPractice.Practices.Fire
        '        Return "F"
        '    Case TblMetaPractice.Practices.Infrared
        '        Return "I"
        '    Case TblMetaPractice.Practices.NatHazFlood
        '        Return "L"
        '    Case TblMetaPractice.Practices.NatHazSeismic
        '        Return "S"
        '    Case TblMetaPractice.Practices.NatHazWind
        '        Return "W"
        '    Case TblMetaPractice.Practices.NaturalHazards
        '        Return "N"
        '    Case TblMetaPractice.Practices.ProcessSafety
        '        Return "P"
        '    Case Else
        'End Select
    End Function

    Public Shared Function Coalesce(ByRef pValue As Object) As String
        If IsNothing(pValue) Then
            Return ""
        Else
            Return pValue
        End If
    End Function

    Private Function CreateAutoRequestFilter(pARProcessType As ProcessType) As JSONFilter
        Dim zJSONFilter As New JSONFilter
        zJSONFilter.Logic = JSONFilterLogic.Operators.And
        zJSONFilter.Filters.Add(New JSONFilterItem("AutoRequest", JSONFilterOperator.Operators.Equal, GetAutoRequestFilterValue(pARProcessType)))
        Return zJSONFilter
    End Function

    Private Function GetSubjectFilterBy(pUserFilter As UtilAutoRec.UserFilter, pValue As String, pClient As rowVwRRClients) As String

        Select Case pUserFilter.Filter
            Case EzUserManagerType.ClientLocNoManager
                Return " - Client Loc. No.: " & pValue
            Case EzUserManagerType.CustomAccessManager
                Return " - " & pClient.colCustomAccessLabel & ": " & pValue
            Case EzUserManagerType.CityManager
                Return " - City: " & pValue
            Case EzUserManagerType.CountryManager
                Return " - Country: " & pValue
            Case EzUserManagerType.DivisionManager
                Return " - Division: " & pValue
            Case EzUserManagerType.FacilityManager
                Return " - Facility: " & pValue
            Case EzUserManagerType.PlantManager
                Return " - Plant: " & pValue
            Case EzUserManagerType.StProvManager
                Return " - StProv.: " & pValue
            Case Else
                Return ""
        End Select

    End Function

    Private Function CreateJSONFilter(pUserFilter As UtilAutoRec.UserFilter) As JSONFilter
        Dim zJSONFilter As New JSONFilter
        zJSONFilter.Logic = JSONFilterLogic.Operators.And

        Select Case pUserFilter.Filter
            Case EzUserManagerType.CityManager
                zJSONFilter.Filters.Add(New JSONFilterItem("City", JSONFilterOperator.Operators.Equal, pUserFilter.City))

            Case EzUserManagerType.ClientLocNoManager
                zJSONFilter.Filters.Add(New JSONFilterItem("ClientLocNo", JSONFilterOperator.Operators.Equal, pUserFilter.ClientLocNo))

            Case EzUserManagerType.CountryManager
                zJSONFilter.Filters.Add(New JSONFilterItem("Country", JSONFilterOperator.Operators.Equal, pUserFilter.Country))

            Case EzUserManagerType.CustomAccessManager
                zJSONFilter.Filters.Add(New JSONFilterItem("CustomAccess", JSONFilterOperator.Operators.Equal, pUserFilter.CustomAccess))

            Case EzUserManagerType.DivisionManager
                zJSONFilter.Filters.Add(New JSONFilterItem("Division", JSONFilterOperator.Operators.Equal, pUserFilter.Division))

            Case EzUserManagerType.FacilityManager
                zJSONFilter.Filters.Add(New JSONFilterItem("Facility", JSONFilterOperator.Operators.Equal, pUserFilter.Facility))

            Case EzUserManagerType.PlantManager
                zJSONFilter.Filters.Add(New JSONFilterItem("FileNo", JSONFilterOperator.Operators.Equal, pUserFilter.Plant))

            Case EzUserManagerType.StProvManager
                zJSONFilter.Filters.Add(New JSONFilterItem("StProv", JSONFilterOperator.Operators.Equal, pUserFilter.StProv))

            Case EzUserManagerType.RiskManager
                zJSONFilter.Filters.Add(New JSONFilterItem("FilePrefix", JSONFilterOperator.Operators.Equal, pUserFilter.FilterValue))

        End Select

        Return zJSONFilter

    End Function

    Private Function GetAutoRequestFilterValue(pARProcessType As OverdueProcessType) As String
        Select Case pARProcessType
            Case ProcessType.Overdue1st
                Return "1st Follow-Up"
            Case ProcessType.Overdue2nd
                Return "2nd Follow-Up"
            Case ProcessType.Overdue3rd
                Return "3rd Follow-Up"
        End Select
        Throw New ArgumentException("Invalid overdue process type.", "pAROverDueProcessType")
    End Function

    Private Sub ArchiveRRLog(pRRLog As rowTblRRLog)
        Dim zCon As SqlClient.SqlConnection = DataLib.razor.UtilSQLServer.GetConnectionObject()
        Dim zTransaction As SqlClient.SqlTransaction = Nothing
        Dim zCmdInsert As New SqlClient.SqlCommand("Insert Into rrlogarchive select * from RRLog where ID=@RRID", zCon)
        Dim zCmdDelete As New SqlClient.SqlCommand("DELETE RRLog where ID=@RRID", zCon)

        zCmdInsert.Parameters.AddWithValue("@RRID", pRRLog.colId)
        zCmdDelete.Parameters.AddWithValue("@RRID", pRRLog.colId)

        If zCon.State = ConnectionState.Closed Then zCon.Open()

        Try
            Using zCon
                zTransaction = zCon.BeginTransaction()
                Using zTransaction
                    zCmdInsert.Transaction = zTransaction
                    zCmdDelete.Transaction = zTransaction

                    Using zCmdInsert
                        zCmdInsert.ExecuteNonQuery()
                    End Using

                    Using zCmdDelete
                        zCmdDelete.ExecuteNonQuery()
                    End Using

                    zTransaction.Commit()
                    zCon.Close()
                End Using

            End Using

        Catch ex As Exception
            zTransaction.Rollback()
            zCon.Close()
            Throw ex
        End Try

        zTransaction = Nothing
        zCmdDelete = Nothing
        zCmdInsert = Nothing
        zCon = Nothing

    End Sub


    Public Property Job As New AppJobLib.razor.rowTblJob Implements AppJobLib.IAppJob.Job

End Class
