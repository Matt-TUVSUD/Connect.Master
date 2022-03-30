Imports GRC.Connect.Libraries.DataLib.razor

Public Class UtilEmailTemplate

    Public Shared Function GetBatchReportTemplate(pUserFullName As String, pClientName As String, pFileName As String, pFilePrefix As String) As rowTblEmailTemplate
        Dim zEmailTemplate As rowTblEmailTemplate = TblEmailTemplate.LoadByIDX_IX_fldTypeId_fldFilePrefix(EmailTemplateType.BatchReport, 0)(0)
        zEmailTemplate.colFldBody = Replace(zEmailTemplate.colFldBody, "{{UserName}}", pUserFullName)
        zEmailTemplate.colFldBody = Replace(zEmailTemplate.colFldBody, "{{DateCreated}}", Now)
        zEmailTemplate.colFldBody = Replace(zEmailTemplate.colFldBody, "{{AppHomeURL}}", UtilSetting.GetAppBaseURL() & "/?p2=myBatchReports&p3=" & pFilePrefix)
        zEmailTemplate.colFldSubject = Replace(zEmailTemplate.colFldSubject, "{{FileName}}", pFileName)
        zEmailTemplate.colFldSubject = Replace(zEmailTemplate.colFldSubject, "{{ClientName}}", pClientName)
        Return zEmailTemplate
    End Function

    Public Shared Function GetFDRTemplate(pUserFullName As String, pClientName As String, pFileName As String) As rowTblEmailTemplate
        Dim zEmailTemplate As rowTblEmailTemplate = TblEmailTemplate.LoadByIDX_IX_fldTypeId_fldFilePrefix(EmailTemplateType.FDRReport, 0)(0)
        zEmailTemplate.colFldBody = Replace(zEmailTemplate.colFldBody, "{{UserName}}", pUserFullName)
        zEmailTemplate.colFldBody = Replace(zEmailTemplate.colFldBody, "{{DateCreated}}", Now)
        zEmailTemplate.colFldSubject = Replace(zEmailTemplate.colFldSubject, "{{FileName}}", pFileName)
        zEmailTemplate.colFldSubject = Replace(zEmailTemplate.colFldSubject, "{{ClientName}}", pClientName)
        Return zEmailTemplate
    End Function

    Public Shared Function GetReclassificationConfirmationTemplate(pUserFullName As String, pClientName As String) As rowTblEmailTemplate
        Dim zEmailTemplate As rowTblEmailTemplate = TblEmailTemplate.LoadByIDX_IX_fldTypeId_fldFilePrefix(EmailTemplateType.ReclassificationConfirmation, 0)(0)
        zEmailTemplate.colFldBody = Replace(zEmailTemplate.colFldBody, "{{UserName}}", pUserFullName)
        zEmailTemplate.colFldBody = Replace(zEmailTemplate.colFldBody, "{{ConnectURL}}", UtilSetting.GetAppBaseURL())
        zEmailTemplate.colFldSubject = Replace(zEmailTemplate.colFldSubject, "{{Client}}", pClientName)
        Return zEmailTemplate
    End Function

    Public Shared Function GetReclassification1stRequestTemplate(pUserFullName As String, pClientName As String, pServiceLeaderName As String, pReclassURL As String) As rowTblEmailTemplate
        Dim zEmailTemplate As rowTblEmailTemplate = TblEmailTemplate.LoadByIDX_IX_fldTypeId_fldFilePrefix(EmailTemplateType.ReclassificationInitial, 0)(0)
        zEmailTemplate.colFldBody = Replace(zEmailTemplate.colFldBody, "{{UserName}}", pUserFullName)
        zEmailTemplate.colFldBody = Replace(zEmailTemplate.colFldBody, "{{ServiceLeaderName}}", pServiceLeaderName)
        zEmailTemplate.colFldBody = Replace(zEmailTemplate.colFldBody, "{{ReclassificationURL}}", pReclassURL)
        zEmailTemplate.colFldSubject = Replace(zEmailTemplate.colFldSubject, "{{Client}}", pClientName)
        Return zEmailTemplate
    End Function

    Public Shared Function GetReclassification2ndRequestTemplate(pUserFullName As String, pClientName As String, pServiceLeaderName As String, pReclassURL As String) As rowTblEmailTemplate
        Dim zEmailTemplate As rowTblEmailTemplate = TblEmailTemplate.LoadByIDX_IX_fldTypeId_fldFilePrefix(EmailTemplateType.ReclassificationFollowUp, 0)(0)
        zEmailTemplate.colFldBody = Replace(zEmailTemplate.colFldBody, "{{UserName}}", pUserFullName)
        zEmailTemplate.colFldBody = Replace(zEmailTemplate.colFldBody, "{{ServiceLeaderName}}", pServiceLeaderName)
        zEmailTemplate.colFldBody = Replace(zEmailTemplate.colFldBody, "{{ReclassificationURL}}", pReclassURL)
        zEmailTemplate.colFldSubject = Replace(zEmailTemplate.colFldSubject, "{{Client}}", pClientName)
        Return zEmailTemplate
    End Function

#Region "User Security Email Template Functions"

    Public Shared Function GetUserSecurityTemplate(pTemplateType As UserSecurityEmailTemplateType, pEzyLogin As rowTblEzyLogin, pClientName As String)
        Dim zEmailTemplate As rowTblEmailTemplate = TblEmailTemplate.LoadByIDX_IX_fldTypeId_fldFilePrefix(pTemplateType, 0)(0)
        zEmailTemplate.colFldBody = Replace(zEmailTemplate.colFldBody, "{{UserName}}", pEzyLogin.colFullName)
        zEmailTemplate.colFldBody = Replace(zEmailTemplate.colFldBody, "{{Client}}", pClientName)
        zEmailTemplate.colFldBody = Replace(zEmailTemplate.colFldBody, "{{ResetPasswordURL}}", ResetPasswordPageURL(pEzyLogin))
        zEmailTemplate.colFldSubject = Replace(zEmailTemplate.colFldSubject, "{{ClientUserDateStamp}}", GetClientUserDateStamp(pEzyLogin, pClientName))
        Return zEmailTemplate
    End Function

    Private Shared Function GetClientUserDateStamp(pEzyUser As rowTblEzyLogin, pClientName As String) As String
        Dim zDate As String = Now.ToString("d-MMM-yy")
        If String.IsNullOrEmpty(pClientName) Then pClientName = "" Else pClientName = pClientName & " - "

        If pEzyUser.colInternal Then
            Return pEzyUser.colFullName & " - " & zDate  'DONT SHOW CLIENT FOR INTERNAL USERS
        Else
            Return pClientName & pEzyUser.colFullName & " - " & zDate
        End If

    End Function

    Private Shared Function ResetPasswordPageURL(pEzyLogin As rowTblEzyLogin) As String
        Dim zResetURL As String = UtilSetting.GetPasswordResetUrl
        Return Replace(zResetURL, "{{EzyLoginGuid}}", pEzyLogin.colLoginGuid)
    End Function

#End Region

    Public Enum EmailTemplateType
        FailedLoginAttempts = 1
        InactivityLockoutClientDesignee = 2
        InactivityLockoutEzyUser = 3
        InactivityLockoutReminder = 4
        ReactivateEzyUser = 5
        AutoRecInitial = 6
        AutoRecLogout = 7
        AutoRecOverdue = 8
        AutoRecExpiredOverdue = 9
        AutoRec1stFollowUp = 10
        AutoRec2ndFollowUp = 11
        AutoRec3rdFollowUp = 12
        BatchReport = 13
        FDRReport = 14
        ImpairmentReport = 15
        AutoRecExpiredExpiringAlert = 16
        MiscAutoRecSample = 17
        UserExpiring1Week = 18
        UserExpiring2Weeks = 19
        UserForgotResetPassword = 20
        UserLockedOut = 21
        UserNewAccount = 22
        UserResetPassword = 23
        UserResetPasswordConfirmation = 24
        ReclassificationInitial = 25
        ReclassificationFollowUp = 26
        ReclassificationConfirmation = 27
    End Enum

    Public Enum UserSecurityEmailTemplateType
        UserExpiring1Week = 18
        UserExpiring2Weeks = 19
        UserForgotResetPassword = 20
        UserLockedOut = 21
        UserNewAccount = 22
        UserResetPassword = 23
        UserResetPasswordConfirmation = 24
    End Enum

End Class
