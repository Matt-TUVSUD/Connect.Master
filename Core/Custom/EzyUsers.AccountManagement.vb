Namespace BusinessObjects
    Partial Class EzyUsers
        Public Class AccountManagement
            Private _ThisUser As EzyUsers
            Private TemplateReplacements As New Dictionary(Of String, String)
            Private _Logger = New UtilLog

            Public Sub New(ByVal pEzyUser As EzyUsers)
                _ThisUser = pEzyUser
            End Sub

            ''' <summary>
            ''' Determines if a inactivity reminder is needed. Applicable only for clients where special feature contains "U".
            ''' </summary>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Function NeedLockoutReminderEmail() As Boolean
                If _ThisUser.EnforceUserSecurity Then
                    If Not _ThisUser.Internal Then
                        If Not _ThisUser.SecurityAccountIsLockedOut Then
                            If IsNothing(_ThisUser.SecurityInactivityReminderSentDate) Then
                                If IsNumeric(_ThisUser.Client.SecurityInactivityLockoutRemindDays) Then
                                    If IsDate(_ThisUser.LastLogin) Then
                                        If Today >= CDate(_ThisUser.LastLogin).AddDays(_ThisUser.Client.SecurityInactivityLockoutRemindDays) Then
                                            Return True
                                        End If
                                    Else
                                        If Today >= CDate(_ThisUser.DateTimeStamp).AddDays(_ThisUser.Client.SecurityInactivityLockoutRemindDays) Then
                                            Return True
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                Return False
            End Function

            ''' <summary>
            ''' Determines if a inactivity is expired.  Applicable only for clients where special feature contains "U".
            ''' </summary>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Function NeedLockoutEmail() As Boolean
                If _ThisUser.EnforceUserSecurity Then
                    If Not _ThisUser.Internal Then
                        If Not _ThisUser.SecurityAccountIsLockedOut Then
                            If IsNumeric(_ThisUser.Client.SecurityInactivityLockoutDays) Then
                                If IsDate(_ThisUser.LastLogin) Then
                                    If Today >= CDate(_ThisUser.LastLogin).AddDays(_ThisUser.Client.SecurityInactivityLockoutDays) Then
                                        Return True
                                    End If
                                Else
                                    If Today >= CDate(_ThisUser.DateTimeStamp).AddDays(_ThisUser.Client.SecurityInactivityLockoutDays) Then
                                        Return True
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                Return False
            End Function

            ''' <summary>
            ''' Determines if a password needs to be changed due to password expiration days.  Applicable only for clients where special feature contains "U".
            ''' </summary>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Function NeedToChangePassword() As Boolean
                Dim zReturn As Boolean = False
                If _ThisUser.EnforceUserSecurity Then
                    If Not _ThisUser.Internal Then
                        If IsDate(_ThisUser.LastPWChange) Then
                            If IsNumeric(_ThisUser.Client.SecurityPasswordExpireDays) Then
                                If Today >= CDate(_ThisUser.LastPWChange).AddDays(_ThisUser.Client.SecurityPasswordExpireDays) Then
                                    zReturn = True
                                End If
                            End If
                        Else
                            zReturn = True
                            ''If the last password date was never set, then set to today
                            '_ThisUser.LastPWChange = Today
                            '_ThisUser.Save()
                        End If


                        'If the current password doesnt conform to the min passowrd value then the user will need to change password
                        If _ThisUser.Client.SecurityPasswordMinimumLength.HasValue And zReturn = False Then
                            zReturn = Not IsValidPasswordLength(_ThisUser.Password)
                        End If

                        'If the current password doesnt conform to the strength value then the user will need to change password
                        If _ThisUser.Client.SecurityPasswordTypeId.HasValue And zReturn = False Then
                            zReturn = Not IsValidPasswordStrength(_ThisUser.Password)
                        End If

                    End If
                End If

                Return zReturn
            End Function

            Public Function IsLocked() As Boolean
                If _ThisUser.EnforceUserSecurity Then
                    If Not _ThisUser.Internal Then
                        If _ThisUser.SecurityAccountIsLockedOut Then
                            Return True
                        End If
                    End If
                End If
                Return False
            End Function

            Public Function IsPasswordExpired() As Boolean
                If _ThisUser.EnforceUserSecurity Then
                    If Not _ThisUser.Internal Then
                        If _ThisUser.SecurityPasswordIsExpired Then
                            Return True
                        End If
                    End If
                End If
                Return False
            End Function

            Public Sub ExpirePassword()
                _ThisUser.SecurityPasswordIsExpired = True
                _ThisUser.Save()
            End Sub

            Public Sub LockAccount()
                _ThisUser.SecurityAccountIsLockedOut = True
                _ThisUser.AutoInactiveDate = Today.AddDays(30)
                _ThisUser.Save()
            End Sub

            Public Sub UnLockAccount()
                _ThisUser.SecurityAccountIsLockedOut = False
                _ThisUser.Save()
            End Sub

            ''' <summary>
            ''' Validates the length of the password
            ''' </summary>
            ''' <param name="pValue"></param>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Function IsValidPasswordLength(ByVal pValue As String) As Boolean
                If _ThisUser.EnforceUserSecurity Then
                    If Not _ThisUser.Internal Then
                        If pValue.Length >= _ThisUser.Client.SecurityPasswordMinimumLength Then
                            Return True
                        Else
                            Return False
                        End If
                    End If
                End If

                Return True

            End Function

            ''' <summary>
            ''' Validates the strength of the password
            ''' </summary>
            ''' <param name="pValue"></param>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Function IsValidPasswordStrength(ByVal pValue As String) As Boolean

                Dim DataAlpha As String = "abcdefghijklmnopqrstuvwxyz"
                Dim DataNumeric As String = "1234567890"
                Dim DataSpecial As String = "`~!@#$%^&*()_+-={}[];':,./<>?\|"
                Dim zReturn As Boolean = False
                Dim zCountAlphaLower As Integer = 0
                Dim zCountAlphaUpper As Integer = 0
                Dim zCountNumeric As Integer = 0
                Dim zCountSpecial As Integer = 0
                Dim zChar As String = ""

                If _ThisUser.EnforceUserSecurity Then
                    For zNdx = 1 To pValue.Length
                        zChar = Mid(pValue, zNdx, 1)
                        If InStr(DataAlpha, zChar) > 0 Then zCountAlphaLower = zCountAlphaLower + 1
                        If InStr(DataAlpha.ToUpper, zChar) > 0 Then zCountAlphaUpper = zCountAlphaUpper + 1
                        If InStr(DataNumeric, zChar) > 0 Then zCountNumeric = zCountNumeric + 1
                        If InStr(DataSpecial, zChar) > 0 Then zCountSpecial = zCountSpecial + 1
                    Next

                    Select Case _ThisUser.Client.SecurityPasswordTypeId
                        Case DdPasswordType.PasswordTypes.Alphanumeric
                            If zCountAlphaLower + zCountAlphaUpper >= 1 And zCountNumeric >= 1 Then zReturn = True
                        Case DdPasswordType.PasswordTypes.AlphanumericWithCaps
                            If zCountAlphaLower >= 1 And zCountAlphaUpper >= 1 And zCountNumeric >= 1 Then zReturn = True
                        Case DdPasswordType.PasswordTypes.AlphanumericAndSpecialChars
                            If zCountAlphaLower + zCountAlphaUpper >= 1 And zCountNumeric >= 1 And zCountSpecial >= 1 Then zReturn = True
                        Case DdPasswordType.PasswordTypes.AlphanumericAndSpecialCharsWithCaps
                            If zCountAlphaLower >= 1 And zCountAlphaUpper >= 1 And zCountNumeric >= 1 And zCountSpecial >= 1 Then zReturn = True
                        Case Else
                            zReturn = True
                    End Select
                Else
                    zReturn = True 'If the user does not enforce security feature then return True to allow password
                End If

                Return zReturn

            End Function



            Public Sub SetPassword(ByVal pPassword As String)
                _ThisUser.Password = pPassword
                _ThisUser.LastPWChange = Now
                _ThisUser.SecurityPasswordIsExpired = False
                _ThisUser.Save()
            End Sub

            'Public Sub SendLockoutReminderEmail()
            '    Dim zReminderInteval As Integer = _ThisUser.Client.SecurityInactivityLockoutRemindDays
            '    Me.TemplateReplacements.Add("%InactivityReminderExpireDays%", zReminderInteval)
            '    Me.TemplateReplacements.Add("%InactivityExpireDays%", _ThisUser.Client.SecurityInactivityLockoutDays)
            '    Me.TemplateReplacements.Add("%DaysLeftBeforeExpire%", (_ThisUser.Client.SecurityInactivityLockoutDays) - zReminderInteval)
            '    Me.TemplateReplacements.Add("%ResourceCenterEmail%", "<a href='mailto:grc-ResourceCenter@tuvsud.com'>ResourceCenter@tuvsud.com</a>")
            '    SendEmail(EmailFlag.EmailFlagEnum.InactivityLockoutReminder, _ThisUser.Email, "itapplications@globalriskconsultants.com", "")

            '    'Record date when reminder email is sent.
            '    _ThisUser.SecurityInactivityReminderSentDate = Now
            '    _ThisUser.Save()

            'End Sub

            'Public Sub SendLockoutEmail()
            '    Me.TemplateReplacements.Add("%User%", _ThisUser.FullName)
            '    Me.TemplateReplacements.Add("%InactivityExpireDays%", _ThisUser.Client.SecurityInactivityLockoutDays)
            '    Me.TemplateReplacements.Add("%ClientDesigneeEmail%", "<a href=mailto:" & _ThisUser.Client.Clientdesigneeemail & ">" & _ThisUser.Client.Clientdesigneeemail & "</a>")
            '    Me.TemplateReplacements.Add("%ResourceCenterEmail%", "<a href='mailto:grc-ResourceCenter@tuvsud.com'>ResourceCenter@tuvsud.com</a>")

            '    SendEmail(EmailFlag.EmailFlagEnum.InactivityLockoutEzyUser, _ThisUser.Email, "itapplications@tuvsud.com", "")

            '    If _ThisUser.Client.Clientdesigneenotify Then
            '        If _ThisUser.Client.Clientdesigneeemail <> "" Then
            '            Me.TemplateReplacements.Add("%ReactivationLink%", "<a href='" & GetURL() & "'>Reactivation Link</a>")
            '            SendEmail(EmailFlag.EmailFlagEnum.InactivityLockoutDesignee, _ThisUser.Client.Clientdesigneeemail, "itapplications@tuvsud.com", "")
            '        End If
            '    End If
            'End Sub

            'Public Sub SendReactivationEmail(ByVal pPassword As String)
            '    Me.TemplateReplacements.Add("%TempPassword%", pPassword)
            '    Me.TemplateReplacements.Add("%ResourceCenterEmail%", "<a href='mailto:grc-resourcecenter@tuvsud.com'>resourcecenter@tuvsud.com</a>")
            '    SendEmail(EmailFlag.EmailFlagEnum.ReactivateEzyUser, _ThisUser.Email, IIf(String.IsNullOrWhiteSpace(_ThisUser.Client.Clientdesigneeemail), "", _ThisUser.Client.Clientdesigneeemail), "")
            'End Sub

            'Public Sub SendFailedLoginAttemptEmail(ByVal pLastPasswordTried As String, ByVal pIpAddress As String)
            '    Me.TemplateReplacements.Add("%ClientDatabaseName%", _ThisUser.Client.Clientname)
            '    Me.TemplateReplacements.Add("%User%", _ThisUser.Email)
            '    Me.TemplateReplacements.Add("%UserName%", _ThisUser.FullName)
            '    Me.TemplateReplacements.Add("%Password%", pLastPasswordTried)
            '    Me.TemplateReplacements.Add("%IpAddress%", pIpAddress)
            '    Me.TemplateReplacements.Add("%ReactivationLink%", "<a href='" & GetURL() & "'>Reactivation Link</a>")

            '    If Not _ThisUser.SecurityAccountIsLockedOut Then
            '        If _ThisUser.Client.Clientdesigneenotify Then
            '            If _ThisUser.Client.Clientdesigneeemail <> "" Then
            '                SendEmail(EmailFlag.EmailFlagEnum.FailedLoginEzyUser, _ThisUser.Client.Clientdesigneeemail, "itapplications@tuvsud.com", "")
            '            Else
            '                SendEmail(EmailFlag.EmailFlagEnum.FailedLoginEzyUser, "itapplications@tuvsud.com", "", "")
            '            End If
            '        End If
            '    End If

            'End Sub

            'Public Sub ReactivateUser()
            '    If _ThisUser.SecurityAccountIsLockedOut = True Then
            '        _ThisUser.SecurityAccountIsLockedOut = False
            '        _ThisUser.LastLogin = Today
            '        _ThisUser.ActiveUser = True
            '        _ThisUser.AutoInactiveDate = Nothing
            '        _ThisUser.Password = GenerateRandomPassword()
            '        _ThisUser.SecurityPasswordIsExpired = True
            '        Me.SendReactivationEmail(_ThisUser.Password)
            '        _ThisUser.Save()
            '    End If
            'End Sub

            Public Sub SetLastLogin()
                _ThisUser.LastLogin = Now
                _ThisUser.SecurityInactivityReminderSentDate = Nothing  'Clear out the Reminder Date due to user logging in.
                _ThisUser.Save()
            End Sub




#Region "Private"

            'Private Sub SendEmail(pEmailType As EmailFlag.EmailFlagEnum, ByVal pTo As String, ByVal pCC As String, ByVal pBcc As String)

            '    Try
            '        Dim zEmailText As BusinessObjects.Emailtext = LoadEmailTemplate(pEmailType, _ThisUser.FilePrefix)
            '        Dim zMM As New GRC.Connect.Libraries.CoreLib.UtilMail(pEmailType)
            '        AddHandler zMM.MailSent, AddressOf MailSentHandler
            '        AddHandler zMM.MailException, AddressOf MailExceptionHandler

            '        'Load email template 
            '        Dim zEmailTemplate As String = zEmailText.Text
            '        Dim zEmailSubject As String = zEmailText.EmailSubject

            '        'Process email template replacements
            '        zEmailTemplate = ProcessReplacements(zEmailTemplate)
            '        zEmailSubject = ProcessReplacements(zEmailSubject)

            '        'Process linebreaks
            '        zEmailTemplate = ProcessLineBreaks(zEmailTemplate)

            '        'WRAP EMAIL TEMPLATE IN DIV TAG
            '        zEmailTemplate = CoreLib.UtilHTML.FormatAutoRecEmailTemplate(zEmailTemplate)

            '        'SEND THE EMAIL
            '        zMM.InitMail()
            '        zMM.MailSubject = zEmailSubject
            '        zMM.MailBody = zEmailTemplate
            '        zMM.MailTo.Clear()
            '        zMM.MailCC.Clear()
            '        zMM.MailBCC.Clear()

            '        If pTo <> "" Then zMM.MailTo.Add(pTo, pTo)
            '        If pBcc <> "" Then zMM.MailBCC.Add(pBcc, pBcc)
            '        If pCC <> "" Then zMM.MailCC.Add(pCC, pCC)

            '        zMM.SendMail(True)

            '        If Not UtilSystemParms.InDevMode Or Not UtilSystemParms.InTestMode Then
            '            _Logger.LogIt(pEmailType & " email sent to " & pTo)
            '        End If

            '    Catch ex As Exception
            '        Throw
            '    End Try

            'End Sub

            Private Function ProcessReplacements(pText As String) As String
                Dim zReturn As String = pText

                For Each zReplacement As KeyValuePair(Of String, String) In Me.TemplateReplacements
                    zReturn = Replace(zReturn, zReplacement.Key, zReplacement.Value)
                Next

                Return zReturn
            End Function

            Private Function ProcessLineBreaks(pText As String) As String
                Dim zChars As Char() = pText.ToCharArray
                Dim zSb As New StringBuilder

                For Each zChar As Char In zChars
                    If zSb.ToString = String.Empty Then
                        zSb.Append(Asc(zChar))
                    Else
                        zSb.Append("-" & Asc(zChar))
                    End If
                Next

                'REMOVE LINE BREAK AFTER </li>
                Dim zAdjustedString As String = zSb.ToString.Replace("60-47-108-105-62-13-10", "60-47-108-105-62")

                'REPLACE LINE BREAK WITH <BR/>
                zAdjustedString = zAdjustedString.Replace("13-10", "60-98-114-62")  'replace linebreak with <br>

                Dim zAscii() As String = Split(zAdjustedString, "-")
                Dim zAdjustedBuilder = New StringBuilder

                For Each zAsc As Integer In zAscii
                    zAdjustedBuilder.Append(Chr(zAsc))
                Next

                Return zAdjustedBuilder.ToString

            End Function

            'Private Function LoadEmailTemplate(pEmailType As EmailFlag.EmailFlagEnum, pFilePrefix As String) As Emailtext
            '    Dim zReturn As Emailtext = Nothing

            '    Dim zQryET As New BusinessObjects.EmailtextQuery("t1")
            '    Dim zCollET As New BusinessObjects.EmailtextCollection

            '    With zQryET
            '        .SelectAll()
            '        .Where(.EmailFlagId = pEmailType)
            '        .Where(.Fileprefix.In(pFilePrefix, "0"))
            '        .OrderBy(.Fileprefix, EntitySpaces.DynamicQuery.esOrderByDirection.Descending)  'if there is a FilePrefix specific override in place it will come to the top of the result
            '    End With

            '    If zCollET.Load(zQryET) Then
            '        ' zReturn = zCollET(0).Text & ""
            '        zReturn = zCollET(0)
            '    End If

            '    Return zReturn
            'End Function

            Private Function GenerateRandomPassword() As String
                Dim zMinLen As Integer = IIf(Not IsNumeric(_ThisUser.Client.SecurityPasswordMinimumLength), 7, _ThisUser.Client.SecurityPasswordMinimumLength)
                If zMinLen < 7 Then zMinLen = 7
                Dim zGuid As String = Guid.NewGuid.ToString("N")
                Dim zPasswordType As Integer = _ThisUser.Client.SecurityPasswordTypeId

                Select Case zPasswordType
                    Case DdPasswordType.PasswordTypes.Alphanumeric
                        zGuid.Insert(1, zPasswordType)
                        zGuid.Insert(2, "a")
                    Case DdPasswordType.PasswordTypes.AlphanumericAndSpecialChars
                        zGuid.Insert(3, zPasswordType)
                        zGuid.Insert(1, "b")
                        zGuid.Insert(2, "$")
                    Case DdPasswordType.PasswordTypes.AlphanumericAndSpecialCharsWithCaps
                        zGuid.Insert(2, zPasswordType)
                        zGuid.Insert(3, "C")
                        zGuid.Insert(1, "&")
                    Case DdPasswordType.PasswordTypes.AlphanumericWithCaps
                        zGuid.Insert(1, zPasswordType)
                        zGuid.Insert(2, "D")
                End Select

                Return Left(zGuid, zMinLen)

            End Function


            'Private Function LoadEmailSubject(pEmailType As String, pFilePrefix As String) As String
            '    Dim zReturn As String = ""

            '    Dim zQryET As New GRC.ClientConnect.Libraries.CoreLib.BusinessObjects.EmailtextQuery("t1")
            '    Dim zCollET As New GRC.ClientConnect.Libraries.CoreLib.BusinessObjects.EmailtextCollection

            '    With zQryET
            '        .SelectAll()
            '        .Where(.Type = pEmailType)
            '        .Where(.Fileprefix.In(pFilePrefix, "0"))
            '        .OrderBy(.Fileprefix, EntitySpaces.DynamicQuery.esOrderByDirection.Descending)  'if there is a FilePrefix specific override in place it will come to the top of the result
            '    End With

            '    If zCollET.Load(zQryET) Then
            '        zReturn = zCollET(0).EmailSubject & ""
            '    End If

            '    Return zReturn
            'End Function

            'Private Enum EmailType
            '    InactivityReminder
            '    InactivityLockoutEzUser
            '    InactivityLockoutDesignee
            '    ReactivatedUser
            '    FailedLoginAttempts
            'End Enum

            Private Function GetURL() As String
                If UtilSystemParms.InDevMode Then
                    Return "https://susnjcu01030/connect/Home/auth/reactivate.aspx?i=" & _ThisUser.EzyGuid
                ElseIf Libraries.CoreLib.UtilSystemParms.InTestMode Then
                    Return "https://grcconnect.globalriskconsultants.com/test/Home/auth/reactivate.aspx?i=" & _ThisUser.EzyGuid
                Else
                    Return "http://grcconnect.globalriskconsultants.com/app/Home/auth/reactivate.aspx?i=" & _ThisUser.EzyGuid
                End If
            End Function


            'Private Sub MailSentHandler(ByVal pEmailFlag As Integer, ByVal pMailMsg As System.Net.Mail.MailMessage, ByVal pSmtpClient As System.Net.Mail.SmtpClient)
            '    BusinessObjects.EmailLog.Insert(pEmailFlag, pMailMsg, pSmtpClient, Nothing)
            'End Sub

            'Private Sub MailExceptionHandler(ByVal pEmailFlag As Integer, ByVal pMailMsg As System.Net.Mail.MailMessage, ByVal pSmtpClient As System.Net.Mail.SmtpClient, ByVal pException As Exception)
            '    BusinessObjects.EmailLog.Insert(pEmailFlag, pMailMsg, pSmtpClient, pException)
            'End Sub


#End Region

        End Class
    End Class

End Namespace



