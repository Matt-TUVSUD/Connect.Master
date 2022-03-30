Imports GRC.Connect.Libraries.DataLib.razor
Imports GRC.EmailManagement.Client

Public Class UtilNotification

    Public Shared Function GetFilePrefix(pLoginId As Integer) As String
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

            'convert the list to a distinct list, and if greater than 1 then return 0, otherwise return the first fileprefix
            If zFilePrefixes.Distinct.ToList().Count > 1 Then
                Return 0
            Else
                Return zFilePrefixes.Distinct.ToList()(0)
            End If

        Else
            Return 0
        End If

    End Function

    Public Shared Sub SubmitNotification(pTo As String, pSubject As String, pBody As String, pAttachments As List(Of NotificationAttachment), pNotificationType As String)
        SubmitNotification(pTo, "", "", pSubject, pBody, pAttachments, pNotificationType)
    End Sub

    Public Shared Sub SubmitNotification(pTo As String, pCc As String, pSubject As String, pBody As String, pAttachments As List(Of NotificationAttachment), pNotificationType As String)
        SubmitNotification(pTo, pCc, "", pSubject, pBody, pAttachments, pNotificationType)
    End Sub

    Public Shared Sub SubmitNotification(pTo As String, pSubject As String, pBody As String, pNotificationType As String)
        SubmitNotification(pTo, "", "", pSubject, pBody, Nothing, pNotificationType)
    End Sub

    Public Shared Sub SubmitNotification(pTo As String, pCc As String, pSubject As String, pBody As String, pNotificationType As String)
        SubmitNotification(pTo, pCc, "", pSubject, pBody, Nothing, pNotificationType)
    End Sub

    Public Shared Sub SubmitNotification(pTo As String, pCc As String, pBcc As String, pSubject As String, pBody As String, pNotificationType As String)
        SubmitNotification(pTo, pCc, pBcc, pSubject, pBody, Nothing, pNotificationType)
    End Sub

    Public Shared Sub SubmitNotification(pTo As String, pCc As String, pBcc As String, pSubject As String, pBody As String, pAttachments As List(Of NotificationAttachment), pNotificationType As String)
        Dim zRow As New rowTblNotification
        With zRow
            .colTo = pTo
            .colCc = pCc
            .colBcc = pBcc
            .colSubject = pSubject
            .colBody = pBody
            .colCreateDate = Now
            .colIsException = False
            .colAttachmentData = Newtonsoft.Json.JsonConvert.SerializeObject(pAttachments)
            .colNotificationType = pNotificationType
        End With
        TblNotification.Save(zRow)
    End Sub

    Public Shared Sub SubmitUserLockedAccountNotification(pLoginId As Integer)
        Dim zLogin As rowTblEzyLogin = TblEzyLogin.LoadByPrimaryKey(pLoginId)
        Dim zTemplate As rowTblEmailTemplate = UtilEmailTemplate.GetUserSecurityTemplate(UtilEmailTemplate.UserSecurityEmailTemplateType.UserLockedOut, zLogin, UtilAutoNotification.GetClientName(zLogin.colLoginID))
        SubmitNotification(zLogin.colEmailAddress, zTemplate.colFldSubject, zTemplate.colFldBody, "User Locked Out - Failed Attempts")
    End Sub

    Public Shared Sub SubmitUserResetPasswordNotification(pLoginId As Integer)
        Dim zLogin As rowTblEzyLogin = TblEzyLogin.LoadByPrimaryKey(pLoginId)
        Dim zTemplate As rowTblEmailTemplate = UtilEmailTemplate.GetUserSecurityTemplate(UtilEmailTemplate.UserSecurityEmailTemplateType.UserResetPassword, zLogin, UtilAutoNotification.GetClientName(zLogin.colLoginID))
        SubmitNotification(zLogin.colEmailAddress, zTemplate.colFldSubject, zTemplate.colFldBody, "User Reset Password")
    End Sub

    Public Shared Function CreateAttachmentList(pFileOrDirectoryPath As String) As List(Of NotificationAttachment)
        Dim zReturn As New List(Of NotificationAttachment)
        If IO.File.Exists(pFileOrDirectoryPath) Then
            Dim zByte() As Byte = IO.File.ReadAllBytes(pFileOrDirectoryPath)
            zReturn.Add(New NotificationAttachment(IO.Path.GetFileName(pFileOrDirectoryPath), zByte))
        Else
            If IO.Directory.Exists(pFileOrDirectoryPath) Then
                Dim zFiles() As String = IO.Directory.GetFiles(pFileOrDirectoryPath)
                For Each zFile As String In zFiles
                    Dim zByte() As Byte = IO.File.ReadAllBytes(zFile)
                    zReturn.Add(New NotificationAttachment(IO.Path.GetFileName(zFile), zByte))
                Next
            End If
        End If
        Return zReturn
    End Function

    Public Shared Function CreateAttachmentList(pByte As Byte(), pFileName As String) As List(Of NotificationAttachment)
        Dim zReturn As New List(Of NotificationAttachment)
        zReturn.Add(New NotificationAttachment(pFileName, pByte))
        Return zReturn
    End Function


    Public Sub ProcessEmails()

        UtilEmail.Init()

        'SENDS SYSTEM NOTIFICATIONS
        Dim zSysQry As New queryTblNotification()
        zSysQry.SelectAll()
        zSysQry.Where.Add(zSysQry.colSentDate.IsNull)
        zSysQry.Where.Add(zSysQry.colIsException.Equals(False))
        zSysQry.Where.Add(zSysQry.colProcessedDate.IsNull)

        Dim zSysCol As List(Of rowTblNotification) = TblNotification.LoadData(zSysQry.QueryText)
        zSysCol.ForEach(Sub(x) SendNotification(x))

    End Sub

    <Serializable>
    Public Class NotificationAttachment
        Public FileName As String
        Public Data As Byte()

        Public Sub New(pFileName As String, pData As Byte())
            FileName = pFileName
            Data = pData
        End Sub

    End Class

#Region "Private"

    Protected Sub SendNotification(ByRef pRow As rowTblNotification)

        Try
            Dim zMsg As New MailMessageProcessingProperties
            With zMsg
                .Body = pRow.colBody
                .Subject = Replace(pRow.colSubject, vbNewLine, "")
                .To.Add(pRow.colTo)
                .OrigProcess = "System Notification"
                .From = New System.Net.Mail.MailAddress("grc-grcconnect@tuvsud.com", "GRC_Connect")
            End With

            Dim zM As System.Net.Mail.MailMessage = zMsg.ToMailMessage("Notification ID: " & pRow.colNotificationID)
            If Not String.IsNullOrEmpty(pRow.colCc) Then zM.CC.Add(pRow.colCc)
            If Not String.IsNullOrEmpty(pRow.colBcc) Then zM.Bcc.Add(pRow.colBcc)

            Dim zAttachments As List(Of NotificationAttachment) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of NotificationAttachment))(pRow.colAttachmentData)
            If Not IsNothing(zAttachments) Then
                For Each zAtt As NotificationAttachment In zAttachments
                    zM.Attachments.Add(New System.Net.Mail.Attachment(New IO.MemoryStream(zAtt.Data), zAtt.FileName))
                Next
            End If

            UtilEmail.Submitter.Submit(zM)

            pRow.colSentDate = Now
            pRow.colProcessedDate = Now
            TblNotification.Save(pRow)


        Catch ex As Exception
            pRow.colIsException = True
            pRow.colProcessedDate = Now
            TblNotification.Save(pRow)

            ex.Data.Add("Notification ID", pRow.colNotificationID)
            Throw
        End Try


    End Sub

    ' ''' <summary>
    ' ''' This function returns the base object from which to replace the variables inside the body of the email template.
    ' ''' </summary>
    ' ''' <param name="pEzyLoginID"></param>
    ' ''' <param name="pFilePrefix"></param>
    ' ''' <param name="pTemplate"></param>
    ' ''' <returns></returns>
    ' ''' <remarks></remarks>
    'Protected Function GetDataObject(pEzyLoginID As Integer, pFilePrefix As String, pTemplate As Templates) As Object
    '    Dim zObj As Object = Nothing

    '    Select Case pTemplate

    '        Case Templates.Reclassification1stRequest, Templates.Reclassification2ndRequest
    '            Dim zQry As New queryVwReclassificationAccount
    '            zQry.SelectAll()
    '            zQry.Where.Add(zQry.colLoginID.Equals(pEzyLoginID))
    '            zQry.Where.Add(zQry.colFilePrefix.Equals(pFilePrefix))

    '            Dim zObjList As List(Of rowVwReclassificationAccount) = VwReclassificationAccount.LoadData(zQry.QueryText)
    '            If zObjList.Count > 0 Then
    '                zObj = zObjList(0)
    '            End If

    '        Case Templates.UserExpiring1Week, Templates.UserExpiring2Week, Templates.UserForgotResetPassword, Templates.UserLockedOut, Templates.UserNewAccount, Templates.UserResetPassword, Templates.UserResetPasswordConfirmation
    '            zObj = TblEzyLogin.LoadByPrimaryKey(pEzyLoginID)

    '    End Select

    '    Return zObj

    'End Function


    'Protected Function GetFilePrefix(pEzyUsers As List(Of rowTblEzyUsers), pUpcomingExpiration As rowVwPasswordSecurity) As String
    '    Dim zUsers As List(Of rowTblEzyUsers) = pEzyUsers.FindAll(Function(x) x.colLoginId = pUpcomingExpiration.colLoginID)
    '    If zUsers.Count = 0 Then Return 0
    '    If zUsers.Count = 1 Then
    '        Return zUsers(0).colFilePrefix
    '    Else
    '        Dim zFilePrefixList As New List(Of Short)
    '        zUsers.ForEach(Sub(x) zFilePrefixList.Add(x.colFilePrefix.Value))

    '        If zFilePrefixList.Distinct.Count = 1 Then
    '            Return zFilePrefixList(0).ToString
    '        Else
    '            Return 0
    '        End If
    '    End If
    'End Function

#End Region





End Class
