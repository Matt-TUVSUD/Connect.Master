Imports GRC.Connect.Libraries.DataLib.razor
Imports GRC.EmailManagement.Client

''' <summary>
''' This class is responsible for sending out password expiration reminders.
''' </summary>
''' <remarks></remarks>
Public Class UtilAutoNotification
    Implements AppJobLib.IAppJob

    Private Enum PasswordReminderSentFlag
        NoReminderSent = 0
        OneWeekReminderSent = 1
        TwoWeekReminderSent = 2
    End Enum

    Public Sub DoWork()
        Dim zBaseList As List(Of rowVwPasswordSecurity) = VwPasswordSecurity.LoadData()

        Dim z2WeekList As List(Of rowVwPasswordSecurity) = zBaseList.FindAll(Function(x) x.colNeed14DayPasswordReminder = True)
        Dim z1WeekList As List(Of rowVwPasswordSecurity) = zBaseList.FindAll(Function(x) x.colNeed7DayPasswordReminder = True)
        Dim zExpireList As List(Of rowVwPasswordSecurity) = zBaseList.FindAll(Function(x) x.colNeedToExpirePasswordAndLockout = True)

        If z2WeekList.Count > 0 Or z1WeekList.Count > 0 Or zExpireList.Count > 0 Then
            UtilEmail.Init()

            Dim zEzyUsers As List(Of rowTblEzyUsers) = TblEzyUsers.LoadData.ToList.FindAll(Function(x) x.colLoginId IsNot Nothing)
            Dim zEzyLogin As rowTblEzyLogin = Nothing
            For Each zPwdExp As rowVwPasswordSecurity In z2WeekList
                zEzyLogin = Nothing
                zEzyLogin = TblEzyLogin.LoadByPrimaryKey(zPwdExp.colLoginID)
                zEzyLogin.colPasswordReminderSentFlag = PasswordReminderSentFlag.TwoWeekReminderSent
                TblEzyLogin.Save(zEzyLogin)

                Dim zTemplate As rowTblEmailTemplate = UtilEmailTemplate.GetUserSecurityTemplate(UtilEmailTemplate.UserSecurityEmailTemplateType.UserExpiring2Weeks, zEzyLogin, GetClientName(zEzyLogin.colLoginID))
                UtilNotification.SubmitNotification(zEzyLogin.colEmailAddress, zTemplate.colFldSubject, zTemplate.colFldBody, "User Expiring 2 Week")

            Next

            For Each zPwdExp As rowVwPasswordSecurity In z1WeekList
                zEzyLogin = Nothing
                zEzyLogin = TblEzyLogin.LoadByPrimaryKey(zPwdExp.colLoginID)
                zEzyLogin.colPasswordReminderSentFlag = PasswordReminderSentFlag.OneWeekReminderSent
                TblEzyLogin.Save(zEzyLogin)

                Dim zTemplate As rowTblEmailTemplate = UtilEmailTemplate.GetUserSecurityTemplate(UtilEmailTemplate.UserSecurityEmailTemplateType.UserExpiring1Week, zEzyLogin, GetClientName(zEzyLogin.colLoginID))
                UtilNotification.SubmitNotification(zEzyLogin.colEmailAddress, zTemplate.colFldSubject, zTemplate.colFldBody, "User Expiring 1 Week")

            Next

            For Each zExpired As rowVwPasswordSecurity In zExpireList
                zEzyLogin = Nothing
                zEzyLogin = TblEzyLogin.LoadByPrimaryKey(zExpired.colLoginID)
                zEzyLogin.colPasswordIsExpired = True
                zEzyLogin.colIsLockedOut = True
                TblEzyLogin.Save(zEzyLogin)

                Dim zTemplate As rowTblEmailTemplate = UtilEmailTemplate.GetUserSecurityTemplate(UtilEmailTemplate.UserSecurityEmailTemplateType.UserLockedOut, zEzyLogin, GetClientName(zEzyLogin.colLoginID))
                UtilNotification.SubmitNotification(zEzyLogin.colEmailAddress, zTemplate.colFldSubject, zTemplate.colFldBody, "User Locked Out")
            Next

        End If

    End Sub

    Public Shared Function GetClientName(pLoginId As Integer) As String
        'The spec called for that if a login has multiple logins with different fileprefixes then do not return a fileprefix.
        'if the login has same fileprefix, then use fileprefix.

        Dim zQry As New queryTblEzyUsers
        zQry.SelectAll()
        zQry.Where.And(zQry.colLoginId.Equals(pLoginId))

        Dim zEzyUsers As List(Of rowTblEzyUsers) = TblEzyUsers.LoadData(zQry.QueryText)
        If zEzyUsers.Count > 0 Then

            'initialize a list for holding fileprefixes
            Dim zFilePrefixes As New List(Of String)

            'fill fileprefix list
            zEzyUsers.ForEach(Sub(x) zFilePrefixes.Add(x.colFilePrefix.ToString))

            'convert the list to a distinct list, and if greater than 1 then return 0, otherwise return the first client name
            If zFilePrefixes.Distinct.ToList().Count > 1 Then
                Return ""
            Else
                Dim zClient As rowTblClients = TblClients.LoadByPrimaryKey(zFilePrefixes.Distinct.ToList()(0))
                Return zClient.colClientname
            End If

        Else
            Return ""
        End If

    End Function

    'Private Sub Notify(pEzyLoginID As Integer, pFilePrefix As String, pTemplate As Templates)

    '    Dim zEzyLogin As rowTblEzyLogin = TblEzyLogin.LoadByPrimaryKey(pEzyLoginID)
    '    Dim zClients As List(Of rowTblClients) = TblClients.LoadByIDX_IX_FilePrefix(pFilePrefix)
    '    If zClients.Count = 0 Then zClients.Add(New rowTblClients)

    '    Dim zDataObject As Object = GetDataObject(pEzyLoginID, pFilePrefix, pTemplate)

    '    Dim zTemplate As rowTblEmailTemplate = GetTemplate(zDataObject, zClients(0), pTemplate)
    '    Dim zMsg As New MailMessageProcessingProperties
    '    With zMsg
    '        .Body = zTemplate.colFldBody
    '        .Subject = zTemplate.colFldSubject
    '        .To.Add(zEzyLogin.colEmailAddress)
    '        .OrigProcess = pTemplate.ToString & " Notification"
    '        .From = New System.Net.Mail.MailAddress("grcconnect@tuvsud.com", "GRC_Connect")
    '    End With

    '    Dim zM As System.Net.Mail.MailMessage = zMsg.ToMailMessage("EzyLogin ID: " & pEzyLoginID)

    '    If Not IsNothing(Job) Then
    '        If Not IsNothing(Job.colFldAlwaysCcRecipients) Then zM.CC.Add(Job.colFldAlwaysCcRecipients)
    '        If Not IsNothing(Job.colFldAlwaysBccRecipients) Then zM.CC.Add(Job.colFldAlwaysBccRecipients)
    '    End If

    '    UtilEmail.Submitter.Submit(zM)

    'End Sub

    Public Property Job As AppJobLib.razor.rowTblJob Implements AppJobLib.IAppJob.Job

End Class
