Imports GRC.Connect.Libraries.DataLib.razor

Public Class UtilLogin2
    Public IsLockedDueToBadAttempts As Boolean = False
    Public IsLocked As Boolean
    Public IsPasswordExpired As Boolean
    Public LoginGUID As String = ""

    'Private Methods
    Private Function _tempScramble(pParm) As String
        Dim zReturn As String
        zReturn = Replace(pParm, "a", "@")
        Return zReturn
    End Function

    Public Function IsPasswordUsed(pEzyLogin As rowTblEzyLogin, pPassword As String) As Boolean
        Dim zLoginId As Integer = pEzyLogin.colLoginID
        Dim zQ As New queryTblEzyPasswordhistory()
        zQ.SelectAll()
        zQ.Top = 6      'ONLY CHECKS THE LAST 6 RECORDS
        zQ.Where.Add(zQ.colLoginID.Equals(zLoginId))
        zQ.Where.Add(zQ.colPassword.Equals(_encryptPassword2(pPassword, pEzyLogin)))
        zQ.OrderBy(zQ.colCreatedDate.Descending)

        Dim rowEzyPasswordHistory As List(Of rowTblEzyPasswordhistory)
        rowEzyPasswordHistory = TblEzyPasswordhistory.LoadData(zQ.QueryText)

        If rowEzyPasswordHistory.Count > 0 Then
            'If at least one record exists, the password cannot be used
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub CleanPasswordHistory(pLoginID As Integer)
        Dim zQ As New queryTblEzyPasswordhistory()
        zQ.SelectAll()
        zQ.Where.Add(zQ.colLoginID.Equals(pLoginID))
        zQ.OrderBy(zQ.colCreatedDate.Descending)

        Dim rowEzyPasswordHistory As List(Of rowTblEzyPasswordhistory)
        rowEzyPasswordHistory = TblEzyPasswordhistory.LoadData(zQ.QueryText)
        Dim Counter As Integer = 1

        For Each zRow In rowEzyPasswordHistory
            If Counter > 6 Then
                'Remove password history
                TblEzyPasswordhistory.Delete(zRow.colPasswordHistoryID)
            End If
            Counter += 1
        Next
    End Sub

    Public Function IsPasswordValid(pPassword As String) As Boolean
        'Needs 4 of 4 criteria
        '   Uppercase letter
        '   Lowercase letter
        '   Special char(s)
        '   Digits
        Dim checklistCounter As Integer = 0
        Dim checkList As New Dictionary(Of String, Boolean)
        checkList.Add("Uppercase", False)
        checkList.Add("Lowercase", False)
        checkList.Add("SpecialCharacter", False)
        checkList.Add("Digit", False)

        Dim uppercase As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim lowercase As String = "abcdefghijklmnopqrstuvwxyz"
        Dim specialChar As String = "`~!@#$%^&*()-_=+{[}]|\:;<,>.?/"
        Dim digit As String = "0123456789"
        If pPassword.Length >= 8 Then
            For Each letter As Char In pPassword
                If checklistCounter < 4 Then
                    'Not all standards met for a GRC password

                    'Is the letter an uppercase letter?
                    If uppercase.Contains(letter) And Not checkList("Uppercase") Then
                        checkList("Uppercase") = True
                        checklistCounter += 1
                    End If

                    'Is the letter a lowercase letter?
                    If lowercase.Contains(letter) And Not checkList("Lowercase") Then
                        checkList("Lowercase") = True
                        checklistCounter += 1
                    End If

                    'Is the letter a special character?
                    If specialChar.Contains(letter) And Not checkList("SpecialCharacter") Then
                        checkList("SpecialCharacter") = True
                        checklistCounter += 1
                    End If

                    'Is the letter a digit?
                    If digit.Contains(letter) And Not checkList("Digit") Then
                        checkList("Digit") = True
                        checklistCounter += 1
                    End If

                Else
                    'Password satisfies the standards for GRC passwords
                    'and exits the validation loop
                    Return True
                End If
            Next
        Else
            Return False
        End If

        'Final check for password validation
        If checklistCounter >= 4 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub _addToPasswordHistory(pLoginID As Integer, pPassword As String)
        Dim row As New rowTblEzyPasswordhistory()
        row.colCreatedDate = Date.Now
        row.colPassword = pPassword
        row.colLoginID = pLoginID
        TblEzyPasswordhistory.Save(row)
    End Sub

    Private Function _isPasswordExpired(pEmail As String) As Boolean
        Dim zReturn As Boolean = False
        Dim zList As New List(Of rowTblEzyLogin)
        Dim zQ As New queryTblEzyLogin
        zQ.SelectAll()
        zQ.Where.Add(zQ.colEmailAddress.Equals(pEmail))
        zList = TblEzyLogin.LoadData(zQ.QueryText)
        If zList.Count > 0 Then
            Return zList(0).colPasswordIsExpired
        End If
        Return zReturn
    End Function

    Private Function _getFirstEzyUserID(pLoginID As Integer) As Integer
        Dim zReturn As Integer = -1
        Dim zQ As New queryTblEzyUsers
        zQ.SelectAll()
        zQ.Top = 1
        zQ.Where.Add(zQ.colLoginId.Equals(pLoginID))

        Dim zList As New List(Of rowTblEzyUsers)
        zList = TblEzyUsers.LoadData(zQ.QueryText)

        If zList.Count > 0 Then zReturn = zList(0).colEzyUserID

        Return zReturn
    End Function

    Private Function _isFileNoValid(pFileNo As String) As Boolean

        If pFileNo Like "####.####" Then Return True
        If pFileNo Like "###.####" Then Return True
        If pFileNo Like "##.####" Then Return True
        If pFileNo Like "#.####" Then Return True

        Return False
    End Function

    ''Password Encryption
    'Private Function _encryptPassword(pPassword As String) As String
    '    Trace.Write(pPassword)
    '    Dim zSalt As String = "23049!@345sflkj05$#2xD"
    '    Dim zSaltedPassword As String = pPassword & zSalt
    '    Dim zSaltedChars() As Char = zSaltedPassword.ToCharArray
    '    Dim zEncrypCharsList As New List(Of Char)
    '    zSaltedChars.ToList.ForEach(Sub(x) zEncrypCharsList.Add(_encryptChar(x)))

    '    Dim zSB As New System.Text.StringBuilder
    '    zEncrypCharsList.ForEach(Sub(x) zSB.Append(x.ToString))

    '    Dim zEncryptedPassword As String = zSB.ToString
    '    Trace.WriteLine("  EncryptedTo " & zEncryptedPassword)

    '    Return zEncryptedPassword
    'End Function

    Public Function EncryptPassword(pPassword As String, pEzyLogin As rowTblEzyLogin) As String
        Return _encryptPassword2(pPassword, pEzyLogin)
    End Function

    'Password Encryption
    Private Function _encryptPassword2(pPassword As String, pEzyLogin As rowTblEzyLogin) As String

        Trace.Write("EzyLogin User: " & pEzyLogin.colFullName.PadRight(50))

        Trace.Write(Chr(34) & pPassword & Chr(34))

        'This is the default start date to calculate days to LastPasswordChangeDate
        Dim zDefaultStartDate As DateTime = "5/24/1965"

        'This is a default last password change date
        Dim zPasswordChangedDate As DateTime = "3/22/2010"

        'if the ezy_login record already has a last password change date use it.
        If Not IsNothing(pEzyLogin.colLastPasswordChangeDate) Then zPasswordChangedDate = pEzyLogin.colLastPasswordChangeDate

        'Calc days
        Dim zDaysFromStartDate As Integer = DateDiff(DateInterval.Day, zDefaultStartDate, zPasswordChangedDate)

        'Create a buffer combining the days from start date and ezyuser login id
        Dim zSalt As String = String.Concat(zDaysFromStartDate.ToString, pEzyLogin.colLoginID.ToString)

        'Combine buffer with user password
        Dim zSaltedChars() As Char = (pPassword & zSalt).ToCharArray

        'Convert to HEX value, adding the LoginID value to each number
        Dim zSB As New System.Text.StringBuilder
        zSaltedChars.ToList.ForEach(Sub(x) zSB.Append((Convert.ToInt32(Asc(x), 16) + pEzyLogin.colLoginID)))

        Trace.WriteLine(" Encyrpts to " & Chr(34) & zSB.ToString & Chr(34) & " (" & zSB.ToString.Length.ToString & " chars.)")

        Return zSB.ToString

    End Function

    Public Function AuthenticateLogin(pEmail As String, pPassword As String) As Boolean
        Dim zReturn As Boolean = False
        Dim zQ As New queryTblEzyLogin()
        zQ.SelectAll()
        zQ.Where.Add(zQ.colEmailAddress.Equals(pEmail))
        zQ.Where.Add(zQ.colMarkForDeletionDate.IsNull)
        zQ.Where.Add(zQ.colActiveFlag.Equals(True))

        Dim rowEzyLoginList As List(Of rowTblEzyLogin)
        rowEzyLoginList = TblEzyLogin.LoadData(zQ.QueryText)
        If rowEzyLoginList.Count > 0 Then
            Me.LoginGUID = rowEzyLoginList(0).colLoginGuid
            If Not rowEzyLoginList(0).colIsLockedOut Then
                If Not _isPasswordExpired(rowEzyLoginList(0).colEmailAddress) Then
                    Me.IsPasswordExpired = False
                    If rowEzyLoginList(0).colPassword = _encryptPassword2(pPassword, rowEzyLoginList(0)) Then
                        'Successful Login
                        rowEzyLoginList(0).colLastLoginDate = Date.Now
                        rowEzyLoginList(0).colFailedLoginStrikeStartDate = Nothing
                        rowEzyLoginList(0).colFailedLoginStrikeCount = 0

                        'Update Record with new password
                        TblEzyLogin.Save(rowEzyLoginList(0))
                        zReturn = True
                    Else
                        rowEzyLoginList(0).colLastFailedLoginDate = Now
                        If rowEzyLoginList(0).colFailedLoginStrikeStartDate < Date.Now.AddHours(-1) Or rowEzyLoginList(0).colFailedLoginStrikeStartDate Is Nothing Then
                            rowEzyLoginList(0).colFailedLoginStrikeStartDate = Date.Now
                            rowEzyLoginList(0).colFailedLoginStrikeCount = 1
                            'Else
                        Else
                            If rowEzyLoginList(0).colFailedLoginStrikeCount >= 2 Then
                                rowEzyLoginList(0).colIsLockedOut = True
                                Me.IsLockedDueToBadAttempts = True
                                Me.IsLocked = True
                            Else
                                '   Increment LastFailCounter
                                rowEzyLoginList(0).colFailedLoginStrikeCount += 1
                            End If
                        End If
                        TblEzyLogin.Save(rowEzyLoginList(0))
                    End If
                Else
                    'Password is Exired
                    Me.IsPasswordExpired = True
                End If
            Else
                'Account isLockedOut or Account ActiveFlag=False
                Me.IsLocked = True
            End If
        Else
            Me.LoginGUID = ""
            'Email does not exist
        End If
        Return zReturn
    End Function

    Public Function ReplacePassword(pEmail As String, pPassword As String) As Boolean
        Dim zReturn As Boolean = False

        'Verify LoginID exists
        Dim zEzyLogin As rowTblEzyLogin = GetLogin(pEmail)
        If Not IsNothing(zEzyLogin) Then

            If IsPasswordValid(pPassword) And Not IsPasswordUsed(zEzyLogin, pPassword) Then

                'Clean up PasswordHistory table
                zEzyLogin.colLastPasswordChangeDate = Date.Now
                zEzyLogin.colPasswordReminderSentFlag = 0
                zEzyLogin.colPassword = _encryptPassword2(pPassword, zEzyLogin)
                zEzyLogin.colPasswordIsExpired = False
                zEzyLogin.colIsLockedOut = False

                'Update Record with new password
                TblEzyLogin.Save(zEzyLogin)

                'Send Password Confirmation
                Dim zTemplate As rowTblEmailTemplate = UtilEmailTemplate.GetUserSecurityTemplate(UtilEmailTemplate.UserSecurityEmailTemplateType.UserResetPasswordConfirmation, zEzyLogin, UtilAutoNotification.GetClientName(zEzyLogin.colLoginID))
                UtilNotification.SubmitNotification(zEzyLogin.colEmailAddress, zTemplate.colFldSubject, zTemplate.colFldBody, "User Reset Password Confirmation")

                'WRITE A COPY OF THIS PASSWORD TO tblEzyPasswordHistory
                _addToPasswordHistory(zEzyLogin.colLoginID, zEzyLogin.colPassword)

                zReturn = True

            Else
                zReturn = False
            End If

        Else
            zReturn = False
        End If

        Return zReturn
    End Function

    Public Function UnlockAccount(pEmail As String) As Boolean
        Dim zReturn As Boolean = False
        Dim zQ As New queryTblEzyLogin()
        zQ.SelectAll()
        zQ.Where.Add(zQ.colEmailAddress.Equals(pEmail))

        Dim rowEzyLoginList As List(Of rowTblEzyLogin)
        rowEzyLoginList = TblEzyLogin.LoadData(zQ.QueryText)

        If rowEzyLoginList.Count > 0 Then
            'Email exists
            rowEzyLoginList(0).colIsLockedOut = False
            TblEzyLogin.Save(rowEzyLoginList(0))
            zReturn = True
        End If

        Return zReturn
    End Function

    Public Function LockAccount(pEmail As String) As Boolean
        Dim zReturn As Boolean = False
        Dim zQ As New queryTblEzyLogin()
        zQ.SelectAll()
        zQ.Where.Add(zQ.colEmailAddress.Equals(pEmail))

        Dim rowEzyLoginList As List(Of rowTblEzyLogin)
        rowEzyLoginList = TblEzyLogin.LoadData(zQ.QueryText)

        If rowEzyLoginList.Count > 0 Then
            'Email exists
            rowEzyLoginList(0).colIsLockedOut = True
            TblEzyLogin.Save(rowEzyLoginList(0))
            zReturn = True
        End If

        Return zReturn
    End Function

    Public Sub RequestPasswordReset(pEmail As String)
        Dim zQ As New queryTblEzyLogin()
        zQ.SelectAll()
        zQ.Where.Add(zQ.colEmailAddress.Equals(pEmail))

        Dim list As List(Of rowTblEzyLogin)
        list = TblEzyLogin.LoadData(zQ.QueryText)
        list(0).colLastPasswordResetRequestDate = Date.Now

        TblEzyLogin.Save(list(0))

    End Sub

    Public Function EmailExists(pEmail As String, pGuid As String) As Boolean
        Dim zReturn As Boolean = False

        Dim zQ As New queryTblEzyLogin
        zQ.SelectAll()
        zQ.Where.Add(zQ.colLoginGuid.Equals(pGuid))
        zQ.Where.Add(zQ.colEmailAddress.Equals(pEmail))

        Dim zList As New List(Of rowTblEzyLogin)
        zList = TblEzyLogin.LoadData(zQ.QueryText)

        If zList.Count > 0 Then zReturn = True Else zReturn = False
        Return zReturn
    End Function


    Public Function EmailExists(pEmail As String) As Boolean
        Dim zReturn As Boolean = False

        Dim zQ As New queryTblEzyLogin
        zQ.SelectAll()
        zQ.Where.Add(zQ.colEmailAddress.Equals(pEmail))

        Dim zList As New List(Of rowTblEzyLogin)
        zList = TblEzyLogin.LoadData(zQ.QueryText)

        If zList.Count > 0 Then zReturn = True Else zReturn = False
        Return zReturn
    End Function


    'Returns the LoginId based on the LoginGuid;  Returns -1 if no records are returned;
    Public Function GetLoginId(pLoginGuid As String) As Integer
        Dim zReturn As Integer

        Dim zQ As New queryTblEzyLogin
        zQ.SelectAll()
        zQ.Where.Add(zQ.colLoginGuid.Equals(pLoginGuid))

        Dim zList As New List(Of rowTblEzyLogin)
        zList = TblEzyLogin.LoadData(zQ.QueryText)

        If zList.Count = 1 Then zReturn = zList(0).colLoginID Else zReturn = -1
        Return zReturn
    End Function

    'Returns the LoginId based on the LoginGuid;  Returns -1 if no records are returned;
    Public Function GetLoginIdByEmail(pEmailAddress As String) As Integer
        Dim zReturn As Integer

        Dim zQ As New queryTblEzyLogin
        zQ.SelectAll()
        zQ.Where.Add(zQ.colEmailAddress.Equals(pEmailAddress))

        Dim zList As New List(Of rowTblEzyLogin)
        zList = TblEzyLogin.LoadData(zQ.QueryText)

        If zList.Count = 1 Then zReturn = zList(0).colLoginID Else zReturn = -1
        Return zReturn
    End Function

    '1) Save User
    Public Function SaveUser(pJSON As Dictionary(Of String, Object)) As Integer

        Dim zCon As SqlClient.SqlConnection = UtilSQLServer.GetConnectionObject
        Dim zTran As SqlClient.SqlTransaction = zCon.BeginTransaction
        Using zCon
            Using zTran

                Dim zUser As rowTblEzyUsers = UtilUser.SaveEzyUser(pJSON, zTran)
                Dim zLogin As rowTblEzyLogin = UtilUser.SaveEzyLogin(zUser, zTran)
                Dim zClient As rowTblClients = TblClients.LoadByPrimaryKey(zUser.colFilePrefix)
                UtilUser.Sync(zUser, zTran)

                'WE ARE NOW GETTING THE UPDATED LOGIN RECORD WITH THE VALUES UPDATED TO BE USED FOR GENERATING EMAILS
                zLogin = TblEzyLogin.LoadByPrimaryKey(zLogin.colLoginID.Value, zTran)

                If pJSON("emailflags.emailnewuser") Then
                    Dim zTemplate As rowTblEmailTemplate = UtilEmailTemplate.GetUserSecurityTemplate(UtilEmailTemplate.UserSecurityEmailTemplateType.UserNewAccount, zLogin, zClient.colClientname)
                    UtilNotification.SubmitNotification(zLogin.colEmailAddress, zTemplate.colFldSubject, zTemplate.colFldBody, "User New Account")
                End If

                If pJSON("emailflags.emailresetpassword") Then
                    Dim zTemplate As rowTblEmailTemplate = UtilEmailTemplate.GetUserSecurityTemplate(UtilEmailTemplate.UserSecurityEmailTemplateType.UserResetPassword, zLogin, zClient.colClientname)
                    UtilNotification.SubmitNotification(zLogin.colEmailAddress, zTemplate.colFldSubject, zTemplate.colFldBody, "User Reset Password")
                End If

                If pJSON("emailflags.emailunlockaccount") Then
                    Dim zTemplate As rowTblEmailTemplate = UtilEmailTemplate.GetUserSecurityTemplate(UtilEmailTemplate.UserSecurityEmailTemplateType.UserResetPassword, zLogin, zClient.colClientname)
                    UtilNotification.SubmitNotification(zLogin.colEmailAddress, zTemplate.colFldSubject, zTemplate.colFldBody, "User Reset Password")
                End If

                zTran.Commit()

                Return zUser.colEzyUserID

            End Using
        End Using

        Return 0

    End Function

    '2) Edit User
    Public Function EditUser(pEzyUserID As Integer) As Boolean
        Dim zReturn As Boolean = False

        Dim zQ As New queryTblEzyUsers
        zQ.SelectAll()
        zQ.Where.Add(zQ.colEzyUserID.Equals(pEzyUserID))

        Dim zList As New List(Of rowTblEzyUsers)
        zList = TblEzyUsers.LoadData(zQ.QueryText)

        If zList.Count > 0 Then
            'Update Record
            zReturn = True
        End If

        Return zReturn  'Defaults to Returning = False
    End Function

    Public Function HasEzyUserRecords(pLoginID As Integer) As Boolean

        Dim zQ As New queryTblEzyUsers
        zQ.SelectAll()
        zQ.Where.Add(zQ.colLoginId.Equals(pLoginID))

        Dim zList As New List(Of rowTblEzyUsers)
        zList = TblEzyUsers.LoadData(zQ.QueryText)

        Return CBool(zList.Count)

    End Function


    '3) Remove User
    Public Function RemoveEzyUser_ByEzyUserID(pEzyUserID As Integer) As Boolean
        Dim zReturn As Boolean = False

        Dim zQ As New queryTblEzyUsers
        zQ.SelectAll()
        zQ.Where.Add(zQ.colEzyUserID.Equals(pEzyUserID))

        Dim zList As New List(Of rowTblEzyUsers)
        zList = TblEzyUsers.LoadData(zQ.QueryText)

        If zList.Count > 0 Then
            'Remove Record
            TblEzyUsers.Delete(pEzyUserID)

            'IF ARE NO MORE EZY_USER RECORDS, THEN DELETE THE LOGIN RECORD
            If Not HasEzyUserRecords(zList(0).colLoginId) Then
                RemoveEzyLogin_ByLoginID(zList(0).colLoginId)
            End If

            zReturn = True

        End If

        Return zReturn  'Defaults to Returning = False
    End Function

    '4) Remove Login
    Public Function RemoveEzyLogin_ByLoginID(pLoginId As Integer) As Boolean
        Dim zReturn As Boolean = False

        Dim zQ As New queryTblEzyLogin
        zQ.SelectAll()
        zQ.Where.Add(zQ.colLoginID.Equals(pLoginId))

        Dim zList As New List(Of rowTblEzyLogin)
        zList = TblEzyLogin.LoadData(zQ.QueryText)

        If zList.Count > 0 Then
            'Remove Record
            TblEzyLogin.Delete(pLoginId)

            zReturn = True
        End If

        Return zReturn  'Defaults to Returning = False
    End Function


    'BUILD QUERY FOR FILLING ADMIN GRID
    Public Function BrowseCCUserActivityGrid_BySafeGuid(pSafeGuid As String) As List(Of rowViewCCUserActivityGridV2)
        Dim zFilePrefix As String = UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.FilePreFix)

        Dim zQ As New queryViewCCUserActivityGridV2
        zQ.SelectAll()
        zQ.Where.Add(zQ.colFilePrefix.Equals(zFilePrefix))

        Dim zList As New List(Of rowViewCCUserActivityGridV2)
        zList = ViewCCUserActivityGridV2.LoadData(zQ.QueryText)

        Return zList
    End Function

    'BUILD QUERY FOR FILLING ADMIN FORM
    Public Function BrowseCCUserActivityForm_ByEzyUserId(pEzyUserId As Integer) As List(Of rowViewCCUserActivityGridV2)
        Dim zQ As New queryViewCCUserActivityGridV2
        zQ.SelectAll()
        zQ.Where.Add(zQ.colEzyUserID.Equals(pEzyUserId))

        Dim zList As New List(Of rowViewCCUserActivityGridV2)
        zList = ViewCCUserActivityGridV2.LoadData(zQ.QueryText)

        Return zList
    End Function

    'BUILD A LIST FOR ADMIN DROPDOWNS
    Public Function getAdminDropdowns(pSafeGuid As String) As Dictionary(Of String, Object)
        Dim zReturn As New Dictionary(Of String, Object)
        Dim zFilePrefix As String = UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.FilePreFix)

        'FOR DEVELOPMENT ONLY
        'Dim zFilePrefix As String = "495"

        Dim zQ As New queryViewCCGRIPSSLocationsV2
        zQ.SelectAll()
        zQ.Where.Add(zQ.colFilePrefix.Equals(zFilePrefix))

        Dim zList As New List(Of rowViewCCGRIPSSLocationsV2)
        zList = ViewCCGRIPSSLocationsV2.LoadData(zQ.QueryText)

        Dim CustomAccess As New List(Of String)
        Dim Location As New List(Of String)
        Dim Division As New List(Of String)
        Dim ClientLocNo As New List(Of String)
        Dim Facility As New List(Of String)
        Dim City As New List(Of String)
        Dim StProv As New List(Of String)
        Dim Country As New List(Of String)

        For Ndx As Integer = 0 To zList.Count - 1
            CustomAccess.Remove(zList(Ndx).colCustomAccess)
            CustomAccess.Add(zList(Ndx).colCustomAccess)

            Location.Remove(zList(Ndx).colFileNo)
            Location.Add(zList(Ndx).colFileNo)

            Division.Remove(zList(Ndx).colDivision)
            Division.Add(zList(Ndx).colDivision)

            ClientLocNo.Remove(zList(Ndx).colClientLocNo)
            ClientLocNo.Add(zList(Ndx).colClientLocNo)

            Facility.Remove(zList(Ndx).colFacility)
            Facility.Add(zList(Ndx).colFacility)

            City.Remove(zList(Ndx).colCity)
            City.Add(zList(Ndx).colCity)

            StProv.Remove(zList(Ndx).colStProv)
            StProv.Add(zList(Ndx).colStProv)

            Country.Remove(zList(Ndx).colCountry)
            Country.Add(zList(Ndx).colCountry)
        Next

        CustomAccess.Sort()
        Location.Sort()
        Division.Sort()
        ClientLocNo.Sort()
        Facility.Sort()
        City.Sort()
        StProv.Sort()
        Country.Sort()


        zReturn.Add("CustomerAccess", CustomAccess)
        zReturn.Add("Location", Location)
        zReturn.Add("Division", Division)
        zReturn.Add("ClientLocNo", ClientLocNo)
        zReturn.Add("Facility", Facility)
        zReturn.Add("City", City)
        zReturn.Add("StProv", StProv)
        zReturn.Add("Country", Country)

        Return zReturn
    End Function

    'BUILD A LIST OF USERS BASED ON EMAIL
    Public Function getUsers_ByEmail(pEmail As String) As List(Of rowTblEzyUsers)
        Dim zReturn As New List(Of rowTblEzyUsers)
        Dim zQ As New queryTblEzyUsers

        zQ.SelectAll()
        zQ.Where.Add(zQ.colEmail.Equals(pEmail))

        zReturn = TblEzyUsers.LoadData(zQ.QueryText)
        Return zReturn
    End Function

    Public Function ValidateAdminUserForm(pEmail As String, pFilePrefix As String) As Boolean
        Dim zReturn As Boolean = False
        Dim zList As New List(Of rowTblEzyUsers)
        Dim zQ As New queryTblEzyUsers

        zQ.SelectAll()
        zQ.Where.Add(zQ.colEmail.Equals(pEmail))
        zQ.Where.Add(zQ.colFilePrefix.Equals(CShort(pFilePrefix)))

        zList = TblEzyUsers.LoadData(zQ.QueryText)

        If zList.Count > 1 Then zReturn = True

        Return zReturn
    End Function

    Public Function AllowMaintenanceLogin(pEmailAddress As String) As Boolean

        Dim zQ As New queryTblEzyUsers
        zQ.SelectAll()
        zQ.Where.Add(zQ.colEmail.Equals(pEmailAddress))
        Dim zList As New List(Of rowTblEzyUsers)
        zList = TblEzyUsers.LoadData(zQ.QueryText)

        If zList.Count > 0 Then
            If zList(0).colAllowMaintLogin Then
                Return True
            End If
        End If

        Return False

    End Function

    ''' <summary>
    ''' Gets the ezy_Login record based by email address. Returns Nothing if not found.
    ''' </summary>
    ''' <param name="pEmail"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetLogin(pEmail As String) As rowTblEzyLogin
        Dim zQ As New queryTblEzyLogin
        zQ.SelectAll()
        zQ.Where.Add(zQ.colEmailAddress.Equals(pEmail))
        zQ.Where.Add(zQ.colActiveFlag.Equals(True))
        Dim zList As New List(Of rowTblEzyLogin)
        zList = TblEzyLogin.LoadData(zQ.QueryText)

        If zList.Count > 0 Then
            Return zList(0)
        Else
            Return Nothing
        End If

    End Function

    ''' <summary>
    ''' Gets the ezy_Login record by Guid.  Returns Nothing if not found.
    ''' </summary>
    ''' <param name="pGuid"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetLoginByGuid(pGuid As String) As rowTblEzyLogin
        Dim zQ As New queryTblEzyLogin
        zQ.SelectAll()
        zQ.Where.Add(zQ.colLoginGuid.Equals(pGuid))
        zQ.Where.Add(zQ.colActiveFlag.Equals(True))
        Dim zList As New List(Of rowTblEzyLogin)
        zList = TblEzyLogin.LoadData(zQ.QueryText)

        If zList.Count > 0 Then
            Return zList(0)
        Else
            Return Nothing
        End If
    End Function

    Public Function IsAllowPasswordChange(pFilePrefix As String) As Boolean
        Dim zReturn As Boolean = False
        Dim zList As New List(Of rowTblClients)
        Dim zQ As New queryTblClients

        zQ.SelectAll()
        zQ.Where.Add(zQ.colSecurityAllowChangePassword.Equals(True))
        zQ.Where.Add(zQ.colFileprefix.Equals(pFilePrefix))

        If zList.Count > 0 Then zReturn = True

        Return zReturn
    End Function

    Public Shared Function IsGRCAdministrator(pEmail As String) As Boolean
        Dim zReturn As Boolean = False
        Dim zQ As New queryTblEzyUsers

        zQ.SelectAll()
        zQ.Where.And(zQ.colEmail.Equals(pEmail), zQ.colGRCAdministrator.IsNotNull(), zQ.colGRCAdministrator.NotEqual(""))
        Dim zList As New List(Of rowTblEzyUsers)
        zList = TblEzyUsers.LoadData(zQ.QueryText)

        If zList.Count > 0 Then zReturn = True

        Return zReturn
    End Function

    Public Shared Function IsAdminUser(pEmail As String) As Boolean
        Dim zReturn As Boolean = False
        Dim zQ As New queryTblEzyUsers

        zQ.SelectAll()
        zQ.Where.Add(zQ.colEmail.Equals(pEmail))
        zQ.Where.Add(zQ.colGRCAdministrator.Equals("00"))

        Dim zList As New List(Of rowTblEzyUsers)
        zList = TblEzyUsers.LoadData(zQ.QueryText)

        If zList.Count > 0 Then zReturn = True

        Return zReturn
    End Function

    Public Shared Function IsClientAdminUser(pEmail As String) As Boolean
        Dim zReturn As Boolean = False
        Dim zQ As New queryTblEzyUsers

        zQ.SelectAll()
        zQ.Where.Add(zQ.colEmail.Equals(pEmail))
        zQ.Where.Add(zQ.colClientAdministration.Equals(True))

        Dim zList As New List(Of rowTblEzyUsers)
        zList = TblEzyUsers.LoadData(zQ.QueryText)

        If zList.Count > 0 Then zReturn = True

        Return zReturn
    End Function

    Public Function LoadByEmail(pEmail As String) As Boolean
        Dim zReturn As Boolean = False

        Dim zQ As New queryTblEzyLogin
        zQ.SelectAll()
        zQ.Where.Add(zQ.colEmailAddress.Equals(pEmail))

        Dim zList As New List(Of rowTblEzyLogin)
        zList = TblEzyLogin.LoadData(zQ.QueryText)

        If zList.Count > 0 Then zReturn = True

        Return zReturn
    End Function

    Public Shared Sub AuditLogout(pSessionTimeout As Boolean, pSafeGUID As String, pTimeoutLength As Integer)
        'Only set logout time in the database if it is not already set by a user requested logout
        If UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.EzyAuditLogId).Length > 0 Then
            Dim zLogId As Integer = CInt((Val(UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.EzyAuditLogId))))
            Dim zAL As New BusinessObjects.EzyAuditLog
            If zAL.LoadByPrimaryKey(zLogId) Then
                If Not zAL.LogOut.HasValue Then
                    Dim zLogoutTime As DateTime = Now
                    Dim zLoginTime As DateTime = zAL.LogIn
                    If pSessionTimeout Then
                        zLogoutTime = DateAdd(DateInterval.Minute, pTimeoutLength * -1, zLogoutTime)
                        zAL.SessionTimeout = True
                    Else
                        zAL.SessionTimeout = False
                    End If
                    zAL.DataKey = pTimeoutLength
                    zAL.LogOut = zLogoutTime
                    zAL.Duration = DateDiff(DateInterval.Minute, zLoginTime, zLogoutTime)
                    zAL.Save()
                End If
            End If
            UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.EzyAuditLogId, "", UtilGSafe.KeyNameGroup.Authentication)
        End If
    End Sub

    Public Shared Sub BuildSafeFilePrefix(pSafeGUID As String)
        Dim zUserEmail As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.UserEmail)
        Dim zLoginId As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.EzyLoginId)
        Select Case GRC.Connect.Libraries.CoreLib.UtilLogin2.GetGRCAdministrator(zLoginId)
            Case "00", "01"
                'Load 580Active clients
                Dim zColl As New BusinessObjects.ClientsCollection
                Dim zQry As New BusinessObjects.ClientsQuery("t1")

                zQry.Select(zQry.Fileprefix)
                'zQry.Where(zQry._580active = True)
                zQry.es.Distinct = True

                Dim zSafeId As Integer = UtilGSafe.GetId(pSafeGUID)
                Dim zUtil As New EntitySpaces.Core.esUtility()

                'ADJUSTED COMMAND TO PREVENT HITS TO DATABASE

                Dim zDeleteCount As Integer = zUtil.ExecuteNonQuery(EntitySpaces.DynamicQuery.esQueryType.Text, "DELETE GSafeFilePrefix WHERE GSafeId=" & zSafeId)
                Dim zInsertCount As Integer = zUtil.ExecuteNonQuery(EntitySpaces.DynamicQuery.esQueryType.Text, "INSERT INTO GSafeFilePrefix(GSafeId, FilePrefix) Select " & zSafeId & ", FilePrefix FROM Clients")

            Case "04"
                'Load Employee/clients

                Dim zColl As New BusinessObjects.EmployeeClientListCollection
                Dim zQry As New BusinessObjects.EmployeeClientListQuery("t1")

                zQry.Select(zQry.FileNbrPrefix)
                zQry.Where(zQry.Email = zUserEmail)
                zQry.es.Distinct = True

                Dim zInsObj As New BusinessObjects.GSafeFilePrefix
                Dim zInsColl As New BusinessObjects.GSafeFilePrefixCollection
                Dim zInsQry As New BusinessObjects.GSafeFilePrefixQuery
                Dim zSafeId As Integer = UtilGSafe.GetId(pSafeGUID)

                zInsQry.SelectAll()
                zInsQry.Where(zInsQry.GSafeId = zSafeId)
                If zInsColl.Load(zInsQry) Then
                    zInsColl.MarkAllAsDeleted()
                    zInsColl.Save()
                End If

                If zColl.Load(zQry) Then
                    For Each zObj As BusinessObjects.EmployeeClientList In zColl
                        zInsObj = zInsColl.AddNew()
                        zInsObj.GSafeId = zSafeId
                        zInsObj.FilePrefix = Val(zObj.FileNbrPrefix).ToString()
                        zInsObj.Save()
                    Next
                End If

                'Load based on number of ezy_user records
                Dim zQ As New queryTblEzyUsers
                Dim zList As New List(Of rowTblEzyUsers)

                zQ.SelectAll()
                'zQ.Where.Add(zQ.colEmail.Equals(zUserEmail))
                zQ.Where.Add(zQ.colLoginId.Equals(CInt(zLoginId)))
                zQ.Where.Add(zQ.colActiveUser.Equals(True))
                zQ.Where.Add(zQ.colCCOnly.Equals(False))  'Users that are CCOnly do NOT include interactive access via Web application
                'zQ.Where.Add(zQ.colGRCAdministrator.NotEqual("04"))  'Exclude the 04 record itself  'Removed on 8/11/2016 because 04 contains a FilePrefix that should be included and also fixes issue where NULL GRCAdministrator values were being dropped out.
                'zQ.Distinct = True
                zList = TblEzyUsers.LoadData(zQ.QueryText)

                If zList.Count > 0 Then
                    For Each zObj As rowTblEzyUsers In zList
                        zInsObj = zInsColl.AddNew()
                        zInsObj.GSafeId = zSafeId
                        zInsObj.FilePrefix = Val(zObj.colFilePrefix).ToString()
                        Try
                            zInsObj.Save()
                        Catch ex As Exception
                            ' The record already exists in the table, just move on.
                        End Try
                    Next
                End If

            Case Else
                'Load based on number of ezy_user records
                Dim zQ As New queryTblEzyUsers
                Dim zList As New List(Of rowTblEzyUsers)

                zQ.SelectAll()
                'zQ.Where.Add(zQ.colEmail.Equals(zUserEmail))
                zQ.Where.Add(zQ.colLoginId.Equals(CInt(zLoginId)))
                zQ.Where.Add(zQ.colActiveUser.Equals(True))
                zQ.Where.Add(zQ.colCCOnly.Equals(False))  'Users that are CCOnly do NOT include interactive access via Web application
                'zQ.Distinct = True
                zList = TblEzyUsers.LoadData(zQ.QueryText)

                Dim zInsObj As New BusinessObjects.GSafeFilePrefix
                Dim zInsColl As New BusinessObjects.GSafeFilePrefixCollection
                Dim zInsQry As New BusinessObjects.GSafeFilePrefixQuery
                Dim zSafeId As Integer = UtilGSafe.GetId(pSafeGUID)

                zInsQry.SelectAll()
                zInsQry.Where(zInsQry.GSafeId = zSafeId)
                If zInsColl.Load(zInsQry) Then
                    zInsColl.MarkAllAsDeleted()
                    zInsColl.Save()
                End If

                If zList.Count > 0 Then
                    For Each zObj As rowTblEzyUsers In zList
                        zInsObj = zInsColl.AddNew()
                        zInsObj.GSafeId = zSafeId
                        zInsObj.FilePrefix = Val(zObj.colFilePrefix).ToString()
                        Try
                            zInsObj.Save()
                        Catch ex As Exception
                            ' The record already exists in the table, just move on.
                        End Try
                    Next
                End If
        End Select
    End Sub

    Public Function SessionSetup(pEmail As String) As String
        Dim zReturn As String = ""
        Dim zUserEmail As String = pEmail
        Dim zSafeGUID As String = ""

        Dim util As New UtilLogin2
        Dim zEzyLogin As rowTblEzyLogin = util.GetLogin(pEmail)
        If Not IsNothing(zEzyLogin) Then
            'If zObj.Load(zQry) Then
            'Dim zAM As New BusinessObjects.EzyUsers.AccountManagement(zObj)
            'zAM.SetLastLogin()

            'zAM = Nothing

            zSafeGUID = UtilGSafe.StartSafeSession(zUserEmail)
            Dim zSafeId As Integer = UtilGSafe.GetId(zSafeGUID)

            '     Call AuditLogout(False, zSafeGUID, 0)

            'Session("SafeGUID") = zSafeGUID
            UtilGSafe.ClearSafeSession_ByGSafeGUID(zSafeGUID)
            UtilSafe.ResetLargeObjectData(zSafeId)

            'UtilGSafe.ClearSafeSession_ByDataGroup(zSafeGUID, UtilGSafe.KeyNameGroup.PageHeader)
            '_getFirstEzyUserID
            UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.EzyUserId, util._getFirstEzyUserID(zEzyLogin.colLoginID), UtilGSafe.KeyNameGroup.Authentication)      'TO DO    MOVE TO SOMEWHERE AFTER A CLIENT IS DETERMINED
            'UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.EzyUserId, zObj.EzyUserID, UtilGSafe.KeyNameGroup.Authentication)      'TO DO    MOVE TO SOMEWHERE AFTER A CLIENT IS DETERMINED
            UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.EzyLoginId, zEzyLogin.colLoginID, UtilGSafe.KeyNameGroup.Authentication)
            UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.AllowReclassLoginOverride, IIf(IsNothing(zEzyLogin.colAllowReclassLoginOverride), False, zEzyLogin.colAllowReclassLoginOverride), UtilGSafe.KeyNameGroup.Authentication)
            UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.UserEmail, zUserEmail, UtilGSafe.KeyNameGroup.Authentication)
            'UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.UserPassword, zUserPassword, UtilGSafe.KeyNameGroup.Authentication)
            UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.AdminUser, CStr(IsAdminUser(zEzyLogin.colEmailAddress)), UtilGSafe.KeyNameGroup.Authentication)
            UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.IsClientAdmin, CStr(IsClientAdminUser(zEzyLogin.colEmailAddress)), UtilGSafe.KeyNameGroup.Authentication)
            UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.currentPage, "1", UtilGSafe.KeyNameGroup.Navigation)
            UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.currentTab, "1", UtilGSafe.KeyNameGroup.Navigation)
            UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.userFullName, zEzyLogin.colFullName, UtilGSafe.KeyNameGroup.PageHeader)

            UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.findFileNo, "", UtilGSafe.KeyNameGroup.FindLocation)
            UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.findClientLocNo, "", UtilGSafe.KeyNameGroup.FindLocation)
            UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.findAddress1, "", UtilGSafe.KeyNameGroup.FindLocation)
            UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.findCity, "", UtilGSafe.KeyNameGroup.FindLocation)
            UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.findStProv, "", UtilGSafe.KeyNameGroup.FindLocation)
            UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.findCountry, "", UtilGSafe.KeyNameGroup.FindLocation)
            UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.findZip, "", UtilGSafe.KeyNameGroup.FindLocation)
            UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.findDivision, "", UtilGSafe.KeyNameGroup.FindLocation)
            UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.findFacility, "", UtilGSafe.KeyNameGroup.FindLocation)
            UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.findCustomAccess, "", UtilGSafe.KeyNameGroup.FindLocation)
            UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.findLongitude, "", UtilGSafe.KeyNameGroup.FindLocation)
            UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.findLatitude, "", UtilGSafe.KeyNameGroup.FindLocation)

            ' NOTE: THIS WILL HAVE TO BE CLEARED OR CHANGED IF A DIFFERENT WAY OF STORING LONG TERM MYPREFERENCES IS APPLIED
            'UtilGSafe.SetValue(zSafeGUID, UtilGSafe.PreferenceKeyName.IsMyPreferenceActive, "", UtilGSafe.KeyNameGroup.Preference)

            Call BuildSafeFilePrefix(zSafeGUID)
        End If

        zReturn = zSafeGUID

        Return zReturn
    End Function

    Public Shared Function GetGRCAdministrator(pLoginId As Integer) As String
        Dim zReturn As String = ""
        Dim zQ As New queryTblEzyUsers

        zQ.SelectAll()
        zQ.Where.Add(zQ.colLoginId.Equals(pLoginId))
        zQ.Where.Add(zQ.colGRCAdministrator.In({"00", "01", "04"}))

        Dim zList As New List(Of rowTblEzyUsers)
        zList = TblEzyUsers.LoadData(zQ.QueryText)
        If zList.Count > 0 Then zReturn = zList(0).colGRCAdministrator
        Return zReturn
    End Function

    Public Shared Sub SetClientValuesByCldbName(pSafeGUID As String, pCLDBName As String)
        Dim zClients As List(Of rowTblClients) = TblClients.LoadByIDX_IX_cldbName(pCLDBName)
        If zClients.Count > 0 Then
            SetClientValues(pSafeGUID, zClients.First.colFilePrefix)
        End If
    End Sub

    Public Shared Sub SetClientValues(pSafeGUID As String, pFilePrefix As String)

        Dim zClientName As String = ""
        Dim zFilePrefix As String = ""
        Dim zClientFeatures As String = ""
        Dim zCustomAccessLabel As String = ""
        Dim zCustomAccessLabelOriginal As String = ""

        Dim zObj As rowTblClients = TblClients.LoadByPrimaryKey(pFilePrefix)
        If IsNumeric(zObj.colFilePrefix) Then

            zFilePrefix = zObj.colFilePrefix
            zClientFeatures = zObj.colFeatures
            zClientName = zObj.colClientname
            zCustomAccessLabelOriginal = zObj.colCustomAccessLabel
            If zObj.colCustomAccessLabel.Length > 0 And zObj.colCustomAccessLabel.ToLower = "not used" Then
                'DB - This value is set in the safe, and consequently a session variable is set. Grids depend on the session value on whether or not to show
                'the custom access column.
                zCustomAccessLabel = "Not Used"  '"Cus. Access(es)"
            Else
                zCustomAccessLabel = zObj.colCustomAccessLabel
            End If

            Dim zLoginId As Integer = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.EzyLoginId)
            Dim zUserEmail As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.UserEmail)
            Dim zUserPassword As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.UserPassword)

            'If the user is GRCAdministrator, we must set the FilePrefix value in ezy_user table to reflect the client that was selected.
            If IsGRCAdministrator(zUserEmail) Then
                Dim zEzyUsers As List(Of rowTblEzyUsers) = TblEzyUsers.LoadByIDX_IX_LoginId(zLoginId)
                Dim zEzyUserToUpdate As rowTblEzyUsers = zEzyUsers.Find(Function(x) x.colGRCAdministrator = GetGRCAdministrator(zLoginId))
                zEzyUserToUpdate.colFilePrefix = zFilePrefix
                TblEzyUsers.Save(zEzyUserToUpdate)
            End If

            'set selected client values to the safe
            UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.FilePreFix, zFilePrefix, UtilGSafe.KeyNameGroup.Switch)
            UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.cldbName, zObj.colCldbname, UtilGSafe.KeyNameGroup.Switch)
            UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.ClientName, zClientName, UtilGSafe.KeyNameGroup.PageHeader)
            UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.clientFeatures, zClientFeatures, UtilGSafe.KeyNameGroup.PageHeader)
            UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.practiceName, "", UtilGSafe.KeyNameGroup.PageHeader)
            UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.CustomAccessLabel, zCustomAccessLabel, UtilGSafe.KeyNameGroup.Preference)
            UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.CustomAccessLabelDefault, zCustomAccessLabel & " Default", UtilGSafe.KeyNameGroup.Preference)
            UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.CustomAccessLabelOriginal, zCustomAccessLabelOriginal, UtilGSafe.KeyNameGroup.Preference)
            UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.BMRatingKeyID, zObj.colBMRatingKeyID, UtilGSafe.KeyNameGroup.Preference)
            UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.FireRatingKeyID, zObj.colFireRatingKeyID, UtilGSafe.KeyNameGroup.Preference)
            UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.DefaultMetaCurrencyID, zObj.colDefaultMetaCurrencyID, UtilGSafe.KeyNameGroup.Preference)
            UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.Recautofollowup, IIf(IsNothing(zObj.colRecautofollowup), False, zObj.colRecautofollowup), UtilGSafe.KeyNameGroup.Preference)

            'set user client options to the safe
            Call SetDefaultPreferences(pSafeGUID)

            Dim zObjEU = New BusinessObjects.EzyUsers
            Dim zQryEU = New BusinessObjects.EzyUsersQuery

            zQryEU.SelectAllExcept(zQryEU.CustomAccess, zQryEU.CustomAccessText, zQryEU.Division, zQryEU.DivisionManager, zQryEU.PlantManager, zQryEU.Plant)
            zQryEU.Select(zQryEU.DocumentAccess.Coalesce("'False'"))  'protect against nulls in the ezy_users table
            zQryEU.Select(zQryEU.RiskManager.Coalesce("'False'"))  'protect against nulls in the ezy_users table
            zQryEU.Select(zQryEU.Internal.Coalesce("'False'"))  'protect against nulls in the ezy_users table
            zQryEU.Select(zQryEU.CustomAccess.Coalesce("'False'"))  'protect against nulls in the ezy_users table
            zQryEU.Select(zQryEU.CustomAccessText.Coalesce("''"))  'protect against nulls in the ezy_users table
            zQryEU.Select(zQryEU.DivisionManager.Coalesce("'False'"))  'protect against nulls in the ezy_users table
            zQryEU.Select(zQryEU.Division.Coalesce("''"))  'protect against nulls in the ezy_users table
            zQryEU.Select(zQryEU.PlantManager.Coalesce("'False'"))  'protect against nulls in the ezy_users table
            zQryEU.Select(zQryEU.Plant.Coalesce("''"))  'protect against nulls in the ezy_users table
            zQryEU.Where(zQryEU.Email = zUserEmail)
            'zQryEU.Where(zQryEU.Password = zUserPassword)  'TODO: this may be an issue for MB user.
            zQryEU.Where(zQryEU.FilePrefix = zFilePrefix)
            zQryEU.es.Top = 1

            If zObjEU.Load(zQryEU) Then
                UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.DocumentAccess, zObjEU.DocumentAccess, UtilGSafe.KeyNameGroup.Authentication)
                UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.RiskManager, zObjEU.RiskManager, UtilGSafe.KeyNameGroup.Authentication)
                UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.Internal, zObjEU.Internal, UtilGSafe.KeyNameGroup.Authentication)
                UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.DivisionManager, zObjEU.DivisionManager, UtilGSafe.KeyNameGroup.Authentication)
                UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.Division, zObjEU.Division, UtilGSafe.KeyNameGroup.Authentication)
                UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.CustomAccess, zObjEU.CustomAccess, UtilGSafe.KeyNameGroup.Authentication)
                UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.CustomAccessText, zObjEU.CustomAccessText, UtilGSafe.KeyNameGroup.Authentication)
                UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.PlantManager, zObjEU.PlantManager, UtilGSafe.KeyNameGroup.Authentication)
                UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.Plant, zObjEU.Plant, UtilGSafe.KeyNameGroup.Authentication)
                UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.UserID, zObjEU.UserID, UtilGSafe.KeyNameGroup.Authentication)
                UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.PreviousLoginDate, If(IsNothing(zObjEU.LastLogin), Now.ToString, zObjEU.LastLogin), UtilGSafe.KeyNameGroup.Authentication)

                If UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.PlantManager) = "True" Then
                    UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.SingleUser, "True", UtilGSafe.KeyNameGroup.Authentication)
                    UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.AdminUser, "False", UtilGSafe.KeyNameGroup.Authentication)
                Else
                    UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.SingleUser, "False", UtilGSafe.KeyNameGroup.Authentication)
                End If

                'Set user settings values
                Dim zDefault As String = ""
                If zObjEU.Division.Length = 0 Then
                    zDefault = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.DivisionDefaultText)
                    UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.Division, zDefault, UtilGSafe.KeyNameGroup.Preference)
                End If

                If zObjEU.CustomAccessText.Length = 0 Then
                    zDefault = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.CustomAccessDefaultText)
                    UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.CustomAccessText, zDefault, UtilGSafe.KeyNameGroup.Preference)
                End If
            End If

            Call AuditLogin(pSafeGUID)

            Dim zUserFilterSQL As String = UtilGSafe.GetFilterSQL(pSafeGUID, zFilePrefix)
            If zUserFilterSQL.Length > 0 Then
                'NOTE 12/6/2012: THE CALL FOR BuildSafeFileNo() IS A TEMP PATCH. SHOULD BE OPTIMIZED BY D.P. TO NOT BE DEPENDENT ON A FULL FILE NO LIST.
                Call BuildSafeFileNo3(pSafeGUID)
                'Removed as this is now handled by the new dynamic location security filters.
                'Call BuildUserFilteredSafeFileNo(pSafeGUID, zUserFilterSQL)
            Else
                Call BuildSafeFileNo3(pSafeGUID)
            End If

        End If

    End Sub

    Public Shared Sub SetDefaultPreferences(pSafeGUID As String)
        Dim zFilePrefix As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.FilePreFix)

        If UtilGSafe.GetValue(pSafeGUID, zFilePrefix, UtilGSafe.PreferenceKeyName.CurrencyDefaultText).Length = 0 Then UtilGSafe.SetValue(pSafeGUID, zFilePrefix, UtilGSafe.PreferenceKeyName.CurrencyDefaultText, "USD", UtilGSafe.KeyNameGroup.Preference)
        If UtilGSafe.GetValue(pSafeGUID, zFilePrefix, UtilGSafe.PreferenceKeyName.UnitDefaultText).Length = 0 Then UtilGSafe.SetValue(pSafeGUID, zFilePrefix, UtilGSafe.PreferenceKeyName.UnitDefaultText, "English", UtilGSafe.KeyNameGroup.Preference)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.TIVDefaultText, "(All)", UtilGSafe.KeyNameGroup.Preference)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.LocationDefaultText, "(All)", UtilGSafe.KeyNameGroup.Preference)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.DivisionDefaultText, "(All)", UtilGSafe.KeyNameGroup.Preference)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.CustomAccessDefaultText, "(All)", UtilGSafe.KeyNameGroup.Preference)
    End Sub

    Public Shared Sub AuditLogin(pSafeGUID As String)
        'Dim zAL As New BusinessObjects.EzyAuditLog

        'zAL.LogIn = Now
        'zAL.EzyUserID = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.EzyUserId)
        'zAL.User = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.userFullName)
        'zAL.UserID = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.UserEmail)
        'zAL.Username = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.UserID)
        'zAL.Fileprefix = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.FilePreFix)
        'zAL.GRCAdministrator = GetGRCAdministrator(UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.EzyLoginId))
        'zAL.Save()

        Dim zLogId As Integer = UtilUserActivity.Create(UtilGSafe.GetId(pSafeGUID), UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.FilePreFix))
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.EzyLoginActivityLogId, zLogId, UtilGSafe.KeyNameGroup.Authentication)

    End Sub

    Public Shared Sub BuildSafeFileNo3(pSafeGUID As String)
        Dim zSW As New Stopwatch

        Dim zGSafeId As Integer = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetId(pSafeGUID)

        zSW.Start()
        Diagnostics.Debug.WriteLine("Starting BuildSafeFileNo3")
        Dim zFilePrefix As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.FilePreFix)

        Dim zList As New List(Of GRC.Connect.Libraries.DataLib.razor.rowViewCCGRIPSSLocationsV3)
        Dim zQLocFileNo As New GRC.Connect.Libraries.DataLib.razor.queryViewCCGRIPSSLocationsV3

        zQLocFileNo.SelectAll()

        zQLocFileNo.Distinct = True

        zQLocFileNo.Where.SetConjuction(UtilSQLServer.ConjuctionOperatorEnum.Or)

        zQLocFileNo.Where.OpenParen()

        'Check GSafe for Location restriction
        Dim zLocation As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.LocationDefaultText)
        If zLocation.Length > 0 And zLocation <> "(All)" Then
            zQLocFileNo.Where.Add(zQLocFileNo.FileNo.Equals(zLocation))
        End If

        'Check GSafe for TIV restriction
        Dim zTIV As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.TIVDefaultText)
        If zTIV.Length > 0 And zTIV <> "(All)" Then
            zQLocFileNo.Where.Add(zQLocFileNo.FileNo.Equals(zTIV))
        End If

        Dim zQEzyUserFilters As New GRC.Connect.Libraries.DataLib.razor.queryVwEzyUsersFilters

        'Read the Ezy_User Filter settings
        Dim zQUserRequirement As New GRC.Connect.Libraries.DataLib.razor.queryVwEzyUsersFilters
        Dim zDT As DataTable
        Dim zRow As DataRow
        Dim zFltCustomAccess As New List(Of String)
        Dim zFltDivision As New List(Of String)
        Dim zFltPlant As New List(Of String)
        Dim zFltClientLoc As New List(Of String)
        Dim zFltFacility As New List(Of String)
        Dim zFltCity As New List(Of String)
        Dim zFltStProv As New List(Of String)
        Dim zFltCountry As New List(Of String)
        Dim zColumnName As String = ""

        zQUserRequirement.SelectAll()
        zQUserRequirement.Where.Add(zQUserRequirement.colGSafeGUID.Equals(pSafeGUID))
        zQUserRequirement.Where.Add(zQUserRequirement.colFilePrefix.Equals(CShort(zFilePrefix)))
        zQUserRequirement.Where.Add(zQUserRequirement.colCCOnly.Equals(False))
        'Future use: if we need to use city/state manager to engage special logic for city/state/country
        'zQUserRequirement.Where.Add(zQUserRequirement.colStProvManager.NotEqual(True))
        'zQUserRequirement.Where.Add(zQUserRequirement.colCityManager.NotEqual(True))

        zDT = GRC.Connect.Libraries.DataLib.razor.UtilSQLServer.ExecuteDataTable(zQUserRequirement.QueryText)

        If zDT.Rows.Count > 0 Then
            For Each zRow In zDT.Rows
                'Division
                zColumnName = zQEzyUserFilters.colDivision.ColumnName.Replace("[", "").Replace("]", "")
                If HasFilterValue(zRow(zColumnName)) Then zFltDivision.Add(zRow(zColumnName))

                'Custom Access
                zColumnName = zQEzyUserFilters.colCustomAccessText.ColumnName.Replace("[", "").Replace("]", "")
                If HasFilterValue(zRow(zColumnName)) Then zFltCustomAccess.Add(zRow(zColumnName))

                'Plant
                zColumnName = zQEzyUserFilters.colPlant.ColumnName.Replace("[", "").Replace("]", "")
                If HasFilterValue(zRow(zColumnName)) Then zFltPlant.Add(zRow(zColumnName))

                'ClientLocNo
                zColumnName = zQEzyUserFilters.colClientLocNoText.ColumnName.Replace("[", "").Replace("]", "")
                If HasFilterValue(zRow(zColumnName)) Then zFltClientLoc.Add(zRow(zColumnName))

                'Facility
                zColumnName = zQEzyUserFilters.colFacilityText.ColumnName.Replace("[", "").Replace("]", "")
                If HasFilterValue(zRow(zColumnName)) Then zFltFacility.Add(zRow(zColumnName))

                'City
                zColumnName = zQEzyUserFilters.colCityText.ColumnName.Replace("[", "").Replace("]", "")
                If HasFilterValue(zRow(zColumnName)) Then zFltCity.Add(zRow(zColumnName))

                'StProv
                zColumnName = zQEzyUserFilters.colStProvText.ColumnName.Replace("[", "").Replace("]", "")
                If HasFilterValue(zRow(zColumnName)) Then zFltStProv.Add(zRow(zColumnName))

                'Country
                zColumnName = zQEzyUserFilters.colCountryText.ColumnName.Replace("[", "").Replace("]", "")
                If HasFilterValue(zRow(zColumnName)) Then zFltCountry.Add(zRow(zColumnName))
            Next
        End If

        'Division
        If zFltDivision.Count > 0 Then zQLocFileNo.Where.Add(zQLocFileNo.Division.In(zFltDivision.ToArray))

        'Custom Access
        If zFltCustomAccess.Count > 0 Then zQLocFileNo.Where.Add(zQLocFileNo.CustomAccess.In(zFltCustomAccess.ToArray))

        'Plant
        If zFltPlant.Count > 0 Then zQLocFileNo.Where.Add(zQLocFileNo.FileNo.In(zFltPlant.ToArray))

        'ClientLocNo
        If zFltClientLoc.Count > 0 Then zQLocFileNo.Where.Add(zQLocFileNo.ClientLocNo.In(zFltClientLoc.ToArray))

        'Facility
        If zFltFacility.Count > 0 Then zQLocFileNo.Where.Add(zQLocFileNo.Facility.In(zFltFacility.ToArray))

        'City
        If zFltCity.Count > 0 Then zQLocFileNo.Where.Add(zQLocFileNo.City.In(zFltCity.ToArray))

        'StProv
        If zFltStProv.Count > 0 Then zQLocFileNo.Where.Add(zQLocFileNo.StProv.In(zFltStProv.ToArray))

        'Country
        If zFltCountry.Count > 0 Then zQLocFileNo.Where.Add(zQLocFileNo.Country.In(zFltCountry.ToArray))

        zQLocFileNo.Where.CloseParen()

        zQLocFileNo.Where.SetConjuction(UtilSQLServer.ConjuctionOperatorEnum.And)

        zQLocFileNo.Where.Add(zQLocFileNo.FilePrefix.Equals(zFilePrefix))

        'Add the Preferences user custom filter requirement
        Dim zQGSafePref As New queryTblGSafePreferences
        zQGSafePref.SelectAll()
        zQGSafePref.Where.Add(zQGSafePref.colGSafeId.Equals(zGSafeId))
        zQGSafePref.Where.Add(zQGSafePref.colFilePrefix.Equals(zFilePrefix))
        zQGSafePref.Where.Add(zQGSafePref.colDataName.Equals("MyPreferenceFilter"))

        Dim rowGSafePref As List(Of rowTblGSafePreferences)
        rowGSafePref = TblGSafePreferences.LoadData(zQGSafePref.QueryText)

        'Process the MyPreferenceFilter JSON string into a SQL Where expression and add to zQLocFileNo
        If rowGSafePref.Count > 0 Then
            If rowGSafePref(0).colDataValue.Length > 0 Then
                'Data has been returned
                Dim zFS As New UtilFilterSort
                Call zFS.SetFilter(rowGSafePref(0).colDataValue, zQLocFileNo)
            End If
        End If

        Diagnostics.Debug.WriteLine("Location Filter SQL: " & zQLocFileNo.QueryText)
        zDT = razor.UtilSQLServer.ExecuteDataTable(zQLocFileNo.QueryText)
        Dim zSB As New StringBuilder
        Dim zSafeId As Integer = CoreLib.UtilGSafe.GetId(pSafeGUID)
        Dim zNdx As Integer = 0
        Dim zInsertCount As Integer = 0

        If zDT.Rows.Count > 0 Then
            Dim zDR As DataRow
            Dim zNeedComma As Boolean = False
            Dim zDictFileNo As New Dictionary(Of String, String)
            zNdx = 0
            zSB.Append("INSERT INTO GSafeFileNo(GSafeId, FileNo) VALUES ")
            Dim util As New UtilLogin2
            For Each zDR In zDT.Rows

                If Not zDictFileNo.ContainsKey(zDR("FileNo")) And util._isFileNoValid(zDR("FileNo")) Then
                    zDictFileNo.Add(zDR("FileNo"), "")  'This is for keeping track of the FileNo's and not allowing any repeated FileNo values due to NatHaz or TIV in the LocationFilter table.
                    If zNeedComma Then zSB.Append(",")
                    zSB.Append("(" & zSafeId & "," & zDR("FileNo") & ")")
                    zNdx = zNdx + 1
                    zNeedComma = True

                    If zNdx Mod 1000 = 999 Then
                        zSB.Append(";")
                        zSB.Append("INSERT INTO GSafeFileNo(GSafeId, FileNo) VALUES ")
                        zNeedComma = False
                    End If
                End If
            Next
            zSB.Append(";")
        End If

        Dim zDeleteCount As Integer = razor.UtilSQLServer.ExecuteNonQuery("DELETE GSafeFileNo WHERE GSafeId=" & zSafeId)

        If zNdx > 0 Then
            zInsertCount = razor.UtilSQLServer.ExecuteNonQuery(zSB.ToString)
        End If

        zSW.Stop()
        Diagnostics.Debug.WriteLine("Completed BuildSafeFileNo3 - Lapse " & zSW.Elapsed.TotalSeconds & " sec(s).  Location count: " & zInsertCount)
    End Sub

    Public Shared Sub BuildUserFilteredSafeFileNo(pSafeGUID As String, pUserFilterCriteriaSQL As String)
        Dim zUserFilterCriteriaSQL As String = ""
        zUserFilterCriteriaSQL = Replace(pUserFilterCriteriaSQL, "'", "''")
        UtilDB.ExecuteProcedure("EXEC spBuildUserFilteredSafeFileNo '" & pSafeGUID & "', " & UtilGSafe.GetId(pSafeGUID) & ", '" & zUserFilterCriteriaSQL & "'")
    End Sub

    Public Shared Function HasFilterValue(pDataValue As Object) As Boolean
        If pDataValue Is Nothing Then
            Return False
        End If

        If IsDBNull(pDataValue) Then
            Return False
        End If

        If pDataValue.ToString.Length = 0 Then
            Return False
        End If

        Return True
    End Function

    Public Shared Sub LogoutUser(pSessionTimeout As Boolean, pSafeGUID As String)
        If pSafeGUID.Length > 0 Then

            UtilUserActivity.SetLogOut(UtilGSafe.GetId(pSafeGUID), pSessionTimeout)
            UtilFind.ClearFindFields(pSafeGUID)

            If pSessionTimeout Then
                UtilGSafe.ClearSafeSession_ByDataGroup(pSafeGUID, UtilGSafe.KeyNameGroup.Authentication)
            Else
                Dim zEmail As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.UserEmail)
                Dim zPassword As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.UserPassword)
                If Not IsGRCAdministrator(zEmail) Then UtilGSafe.ClearSafeSession_ByDataGroup(pSafeGUID, UtilGSafe.KeyNameGroup.Authentication)
            End If
        End If
    End Sub

    Public Shared Sub EncryptEzyUserPasswords()
        Dim util As New UtilLogin2
        Dim zQUser As New queryVwEzyUserPasswordLookup
        zQUser.SelectAll()
        zQUser.Where.Add(zQUser.colImport.Equals("Import"))
        Dim zListUser As New List(Of rowVwEzyUserPasswordLookup)
        zListUser = VwEzyUserPasswordLookup.LoadData(zQUser.QueryText)
        If zListUser.Count > 1 Then
            For Each zRowUser In zListUser
                Dim zQLogin As New queryTblEzyLogin
                Dim zList As New List(Of rowTblEzyLogin)

                zQLogin.SelectAll()
                zQLogin.Where.Add(zQLogin.colEmailAddress.Equals(zRowUser.colEmail))
                '  zQLogin.Where.Add(zQLogin.colEmailAddress.NotContains("globalriskconsultant"))
                ' zQLogin.Where.Add(zQLogin.colEmailAddress.NotContains("goccomputers"))

                zList = TblEzyLogin.LoadData(zQLogin.QueryText)

                If zList.Count > 0 Then
                    zList(0).colPassword = util._encryptPassword2(zRowUser.colPassword, zList(0))
                    TblEzyLogin.Save(zList(0))
                End If
            Next
        End If

        'Dim util As New UtilLogin2
        'Dim zQ As New queryTblEzyLogin
        'Dim zList As New List(Of rowTblEzyLogin)
        'zQ.SelectAll()
        ''zQ.Where.Add(zQ.colEmailAddress.Equals("aangulo@krautergroup.com"))
        'zQ.Where.Add(zQ.colEmailAddress.NotContains("globalriskconsultant"))
        'zQ.Where.Add(zQ.colEmailAddress.NotContains("goccomputers"))
        'zList = TblEzyLogin.LoadData(zQ.QueryText)
        'If zList.Count > 0 Then
        '    For Each zRow In zList
        '        zRow.colPassword = util._encryptPassword(zRow.colPassword)
        '        TblEzyLogin.Save(zRow)
        '    Next
        'End If
    End Sub
End Class



