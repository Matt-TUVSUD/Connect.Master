
Public Class UtilMail

    Public MailFrom As String = ""
    Public MailFromDisplayName As String = ""
    Public MailTo As New Dictionary(Of String, String)
    Public MailCC As New Dictionary(Of String, String)
    Public MailBCC As New Dictionary(Of String, String)
    Public MailSubject As String = ""
    Public MailBody As String = ""
    Public SMTPServer As String = ""
    Public SMTPPort As Integer = 25
    Public SentCount As Integer = 0
    Public ErrorCount As Integer = 0
    Public AttachPath As String = ""
    Public AttachFile As String = ""
    Public EmailFlag As Integer = 0
    Private pEmailFlag As Integer
    Public AttachDisplayName As String = ""
    Private mAttachStream() As System.Net.Mail.Attachment
    Private mAttachCount As Integer = 0
    Dim zLog As New UtilLog

    Public Sub New(ByVal pFlag As EmailFlag.EmailFlagEnum)
        pEmailFlag = pFlag
    End Sub

    Public Sub AttachStream(pDataStream As System.IO.MemoryStream, pFileName As String)
        Dim zArrayMax As Integer = mAttachCount
        ReDim Preserve mAttachStream(zArrayMax)

        mAttachStream(zArrayMax) = New System.Net.Mail.Attachment(pDataStream, pFileName)
        mAttachCount = mAttachCount + 1
    End Sub

    Sub InitMail()
        MailFrom = UtilSystemParms.ReadSMTPFromEmail
        MailFromDisplayName = UtilSystemParms.ReadSMTPFromDisplayName
        MailTo.Clear()
        MailCC.Clear()
        MailBCC.Clear()
        MailSubject = ""
        MailBody = ""
        SMTPServer = UtilSystemParms.ReadSMTPHost
        SMTPPort = UtilSystemParms.ReadSMTPPort
        SentCount = 0
        ErrorCount = 0
        AttachPath = ""
        AttachFile = ""
        EmailFlag = pEmailFlag
        AttachDisplayName = ""
        ReDim mAttachStream(0)
        mAttachCount = 0
    End Sub

    Private Function BuildOrigString(pData As String, pEmailAddress As String, pDisplayName As String) As String
        Dim zReturn As String = pData

        If zReturn.Length > 0 Then zReturn = zReturn & ", "
        zReturn = zReturn & pEmailAddress & " (" & pDisplayName & ")"

        Return zReturn
    End Function

    Private Sub AssignAddress(ByRef pMailAddressColl As System.Net.Mail.MailAddressCollection, pEmailAddress As String, pDisplayName As String)
        If System.Diagnostics.Debugger.IsAttached Then
            zLog.LogIt("Checking for match to see if " & pEmailAddress & " is allowed to receive email. (DEBUG mode)")
            'Filter out all email addresses other than GRC and GOC
            If InStr(pEmailAddress.ToLower, Libraries.CoreLib.UtilSystemParms.DeveloperEmailAddress.ToLower) > 0 Or _
                InStr(pEmailAddress.ToLower, "goccomputers.com") > 0 Then
                zLog.LogIt("Match found! Will send email to " & pEmailAddress & " (" & pDisplayName & ")")
                pMailAddressColl.Add(New System.Net.Mail.MailAddress(pEmailAddress, pDisplayName))
            Else
                zLog.LogIt("Match not found. " & pEmailAddress & " (" & pDisplayName & ") will be scrubbed.")
            End If
        Else
            'Filter out all email addresses other than GRC and GOC
            zLog.LogIt("Checking for match to see if " & pEmailAddress & " is allowed to receive email.")
            Dim zDefaultToAddress As String = Libraries.CoreLib.UtilSystemParms.DefaultToEmailAddress

            If pEmailAddress.ToLower = "daniel.barasch@globalriskconsultants.com" Or _
               pEmailAddress.ToLower = "gary.kidney@globalriskconsultants.com" Or _
               pEmailAddress.ToLower = "margaret.bruton@globalriskconsultants.com" Or _
               pEmailAddress.ToLower = "alina.batista@globalriskconsultants.com" Or _
               pEmailAddress.ToLower = "edward.altus@globalriskconsultants.com" Or _
               pEmailAddress.ToLower = zDefaultToAddress.ToLower Or _
               pEmailAddress.ToLower.Contains("goccomputers.com") Then

                zLog.LogIt("Match found! Will send email to " & pEmailAddress & " (" & pDisplayName & ")")
                pMailAddressColl.Add(New System.Net.Mail.MailAddress(pEmailAddress, pDisplayName))

            Else
                zLog.LogIt("Match not found. " & pEmailAddress & " (" & pDisplayName & ") will be scrubbed.")
            End If
        End If
    End Sub

    Public Sub SendMail(Optional ByVal pIsHTML As Boolean = True)

        Dim zMailMsg As New System.Net.Mail.MailMessage()
        Dim zSmtpClient As New System.Net.Mail.SmtpClient(Me.SMTPServer, Me.SMTPPort)

        Try

            zMailMsg.From = New System.Net.Mail.MailAddress(Me.MailFrom, Me.MailFromDisplayName)
            zMailMsg.Subject = Me.MailSubject
            zMailMsg.IsBodyHtml = pIsHTML
            zMailMsg.Body = Me.MailBody

            If Not (UtilSystemParms.InDevMode Or UtilSystemParms.InTestMode) Then
                For Each zItem As String In Me.MailTo.Keys
                    If InStr(zItem, ",") > 0 Then
                        Dim zAddresses() As String = Split(zItem, ",")
                        If IsValidEmailFormat(zAddresses) Then
                            For Each zAddress As String In zAddresses
                                zMailMsg.To.Add(New System.Net.Mail.MailAddress(zAddress, Me.MailTo(zAddress)))
                            Next
                        Else
                            Throw New Exception("One or more email addresses is invalid.")
                        End If
                    Else
                        If IsValidEmailFormat(zItem) Then
                            zMailMsg.To.Add(New System.Net.Mail.MailAddress(zItem, Me.MailTo(zItem)))
                        Else
                            Throw New Exception("'" & zItem & "' is invalid.")
                        End If
                    End If
                Next

                For Each zItem As String In Me.MailCC.Keys
                    If InStr(zItem, ",") > 0 Then
                        Dim zAddresses() As String = Split(zItem, ",")
                        If IsValidEmailFormat(zAddresses) Then
                            For Each zAddress As String In zAddresses
                                zMailMsg.CC.Add(New System.Net.Mail.MailAddress(zAddress, Me.MailCC(zAddress)))
                            Next
                        Else
                            Throw New Exception("One or more email addresses is invalid.")
                        End If
                    Else
                        If IsValidEmailFormat(zItem) Then
                            zMailMsg.CC.Add(New System.Net.Mail.MailAddress(zItem, Me.MailCC(zItem)))
                        Else
                            Throw New Exception("'" & zItem & "' is an invalid email address.")
                        End If
                    End If
                Next

                For Each zItem As String In Me.MailBCC.Keys
                    If InStr(zItem, ",") > 0 Then
                        Dim zAddresses() As String = Split(zItem, ",")
                        If IsValidEmailFormat(zAddresses) Then
                            For Each zAddress As String In zAddresses
                                zMailMsg.Bcc.Add(New System.Net.Mail.MailAddress(zAddress, Me.MailBCC(zAddress)))
                            Next
                        Else
                            Throw New Exception("One or more email addresses is invalid.")
                        End If
                    Else
                        If IsValidEmailFormat(zItem) Then
                            zMailMsg.Bcc.Add(New System.Net.Mail.MailAddress(zItem, Me.MailBCC(zItem)))
                        Else
                            Throw New Exception("'" & zItem & "' is an invalid email address.")
                        End If
                    End If
                Next


            Else
                'Configure mail for only globalriskconsultants.com and goccomputers.com
                'Create header_debug.txt attachment with original To, CC, BCC items
                Dim zOrigTo As String = ""
                Dim zOrigCC As String = ""
                Dim zOrigBCC As String = ""

                If Me.MailTo.Keys.Count > 0 Then
                    zLog.LogIt("Original TO email addresses will be scrubbed due to being in DEV or TEST modes.", UtilLog.EventLevel.Information, UtilLog.EventType.LogServer, 0, 0, 0, False)
                    For Each zItem As String In Me.MailTo.Keys
                        zOrigTo = BuildOrigString(zOrigTo, zItem, Me.MailTo(zItem))
                        AssignAddress(zMailMsg.To, zItem, Me.MailTo(zItem))
                    Next
                End If

                If Me.MailCC.Keys.Count > 0 Then
                    zLog.LogIt("Original CC email addresses will scrubbed due to being in DEV or TEST modes.", UtilLog.EventLevel.Information, UtilLog.EventType.LogServer, 0, 0, 0, False)
                    For Each zItem As String In Me.MailCC.Keys
                        zOrigCC = BuildOrigString(zOrigCC, zItem, Me.MailCC(zItem))
                        AssignAddress(zMailMsg.CC, zItem, Me.MailCC(zItem))
                    Next
                End If

                If Me.MailBCC.Keys.Count > 0 Then
                    zLog.LogIt("Original BCC email addresses will scrubbed due to being in DEV or TEST modes.", UtilLog.EventLevel.Information, UtilLog.EventType.LogServer, 0, 0, 0, False)
                    For Each zItem As String In Me.MailBCC.Keys
                        zOrigBCC = BuildOrigString(zOrigBCC, zItem, Me.MailBCC(zItem))
                        AssignAddress(zMailMsg.Bcc, zItem, Me.MailBCC(zItem))
                    Next
                End If

                If (zMailMsg.To.Count = 0) And (Libraries.CoreLib.UtilSystemParms.InTestMode Or Libraries.CoreLib.UtilSystemParms.InDevMode) Then
                    If Not System.Diagnostics.Debugger.IsAttached Then
                        'Not in the development environment - send it to default TO email
                        If Libraries.CoreLib.UtilSystemParms.DefaultToEmailAddress <> "" Then
                            zLog.LogIt("No TO person is specified after scrubbing.  Setting TO email: " & Libraries.CoreLib.UtilSystemParms.DefaultToEmailAddress.ToLower, UtilLog.EventLevel.Information, UtilLog.EventType.LogServer, 0, 0, 0, False)
                            AssignAddress(zMailMsg.To, Libraries.CoreLib.UtilSystemParms.DefaultToEmailAddress, "IT Department")
                        Else
                            zLog.LogIt("No default TO person is specified in webconfig.  Exiting SendMail() procedure.")
                            Exit Sub
                        End If
                    Else
                        zLog.LogIt("No TO person is specified after scrubbing.  Setting TO email as specified in config file: " & Libraries.CoreLib.UtilSystemParms.DeveloperEmailAddress, UtilLog.EventLevel.Information, UtilLog.EventType.LogServer, 0, 0, 0, False)
                        AssignAddress(zMailMsg.To, Libraries.CoreLib.UtilSystemParms.DeveloperEmailAddress, "Developer")
                    End If
                End If

                'Create DebugAddress.txt attachment with all the original email destination addresses for DEV, TEST verification
                Dim zDebugText As String = ""
                zDebugText = zDebugText & "TO : " & zOrigTo & vbCrLf & vbCrLf
                zDebugText = zDebugText & "CC : " & zOrigCC & vbCrLf & vbCrLf
                zDebugText = zDebugText & "BCC: " & zOrigBCC & vbCrLf & vbCrLf

                Dim zEncode As New UTF8Encoding
                Dim zArrBytes() As Byte = zEncode.GetBytes(zDebugText)
                Dim zDebugStream As New System.IO.MemoryStream(zArrBytes)
                Dim zDebugAttach As New System.Net.Mail.Attachment(zDebugStream, "DebugAddress.txt")
                zMailMsg.Attachments.Add(zDebugAttach)
            End If

            If AttachFile.Length > 0 Then
                'Dim zAttach As New System.Net.Mail.Attachment(AttachPath & AttachFile)
                'AttachPath & AttachFile
                Dim zStream As New System.IO.FileStream(AttachPath & AttachFile, IO.FileMode.Open)
                Dim zAttach As New System.Net.Mail.Attachment(zStream, AttachDisplayName)
                zMailMsg.Attachments.Add(zAttach)
            End If

            If mAttachCount > 0 Then
                Dim zNdx As Integer = 0
                For zNdx = 0 To mAttachCount - 1
                    zMailMsg.Attachments.Add(mAttachStream(zNdx))
                Next
            End If

            zSmtpClient.Timeout = 1800000  '30 minutes
            zSmtpClient.Send(zMailMsg)
            RaiseEvent MailSent(EmailFlag, zMailMsg, zSmtpClient)


            Me.SentCount = Me.SentCount + 1
            zMailMsg.Attachments.Dispose() 'DB -- releases connection to file
            zMailMsg.Dispose()
            zSmtpClient.Dispose()
            zMailMsg = Nothing
            zSmtpClient = Nothing


        Catch ex As System.Net.Mail.SmtpFailedRecipientsException
            RaiseEvent MailException(EmailFlag, zMailMsg, zSmtpClient, ex)

        Catch ex As System.Net.Mail.SmtpFailedRecipientException
            RaiseEvent MailException(EmailFlag, zMailMsg, zSmtpClient, ex)

        Catch ex As System.Net.Mail.SmtpException
            RaiseEvent MailException(EmailFlag, zMailMsg, zSmtpClient, ex)

        Catch ex As Exception
            RaiseEvent MailException(EmailFlag, zMailMsg, zSmtpClient, Nothing)

            Dim zCounter As Integer = 1
            For Each zMailTo In MailTo.Keys
                ex.Data.Add("[To]." & zCounter, zMailTo)
                zCounter += 1
            Next

            zCounter = 1
            For Each zMailCc In MailCC.Keys
                ex.Data.Add("[Cc]." & zCounter, zMailCc)
                zCounter += 1
            Next

            zCounter = 1
            For Each zMailBcc In MailBCC.Keys
                ex.Data.Add("[Bcc]." & zCounter, zMailBcc)
                zCounter += 1
            Next

            Throw

        End Try
        'Catch ex As Exception
        '    Me.ErrorCount = Me.ErrorCount + 1
        '    LogIt("")
        '    LogIt(" ==================== BEGIN ERROR ========================")
        '    LogIt("  ERROR:  " & ex.Message)
        '    LogIt("  -------------------- EMAIL ------------------------")
        '    LogIt("  To:  " & Me.MailTo)
        '    LogIt("  From:  " & Me.MailFrom)
        '    LogIt("  CC:  " & Me.MailCC)
        '    LogIt("  BCC:  " & Me.MailBCC)
        '    LogIt("  Subject:  " & Me.MailSubject)
        '    LogIt("  Body (len):  " & Me.MailBody.Length)
        '    LogIt("  Attach:  " & Me.AttachFile)
        '    LogIt(" ===================== END ERROR =========================")
        '    LogIt("")
        'End Try
    End Sub

    Private Sub LogIt(pMessage As String)
        Diagnostics.Debug.Print(pMessage)
    End Sub

    Public Function IsValidEmailFormat(ByVal s As String) As Boolean
        Try
            Dim a As New System.Net.Mail.MailAddress(s)
        Catch
            Return False
        End Try
        Return True
    End Function

    Public Function IsValidEmailFormat(ByVal s() As String) As Boolean

        For Each zAddress As String In s
            If Not IsValidEmailFormat(zAddress) Then
                Return False
            End If
        Next
        Return True
    End Function

    Public Event MailSent(ByVal pEmailFlag As BusinessObjects.EmailFlag.EmailFlagEnum, ByVal pMailMsg As System.Net.Mail.MailMessage, ByVal pMailClient As System.Net.Mail.SmtpClient)
    Public Event MailException(ByVal pEmailFlag As BusinessObjects.EmailFlag.EmailFlagEnum, ByVal pMailMsg As System.Net.Mail.MailMessage, ByVal pMailClient As System.Net.Mail.SmtpClient, ByVal pException As System.Net.Mail.SmtpException)

    Private Sub UtilMail_MailException(pEmailFlag As BusinessObjects.EmailFlag.EmailFlagEnum, pMailMsg As System.Net.Mail.MailMessage, pMailClient As System.Net.Mail.SmtpClient, pException As System.Net.Mail.SmtpException) Handles Me.MailException
        BusinessObjects.EmailLog.Insert(pEmailFlag, pMailMsg, pMailClient, pException)
    End Sub

    Private Sub UtilMail_MailSent(pEmailFlag As BusinessObjects.EmailFlag.EmailFlagEnum, pMailMsg As System.Net.Mail.MailMessage, pMailClient As System.Net.Mail.SmtpClient) Handles Me.MailSent
        BusinessObjects.EmailLog.Insert(pEmailFlag, pMailMsg, pMailClient, Nothing)
    End Sub
End Class


'Public Class UtilMailComments
'    Public Shared Function SendCommentsEmail(ByVal pGUID As String, ByVal pURL As String, ByVal pComment As String) As Boolean

'    End Function

'End Class

