Imports GRC.Connect.Libraries.DataLib.razor

Public Class UtilLogin


    'Public Shared Function SilentAuthenticate(pEmail As String, pPassword As String, pCLDBName As String) As String
    '    Dim zSafeGUID As String = ""

    '    zSafeGUID = Authenticate(pEmail, pPassword)

    '    If zSafeGUID <> "" Then
    '        Call SetClientValues(zSafeGUID, pCLDBName)
    '        Call BuildSafeFileNo(zSafeGUID)
    '        Return zSafeGUID

    '    Else
    '        Diagnostics.EventLog.WriteEntry("GRC Connect", "Silent Authenticate failed. The system failed to authenticate Email=" & pEmail & ", Password=" & pPassword & ", CldbName=" & pCLDBName, EventLogEntryType.Error)
    '        Throw New Exception("Authentication failed. See Windows Eventlog for more details.")
    '    End If
    'End Function

    'Public Shared Function SilentAuthenticate(pEmail As String, pPassword As String, pCLDBName As String, pConnectionString As String) As String

    '    'When providing a connection string override the one in the config file
    '    UtilDB.ConnectionString = pConnectionString

    '    Dim zSafeGUID As String = ""

    '    zSafeGUID = Authenticate(pEmail, pPassword)

    '    If zSafeGUID <> "" Then
    '        Call SetClientValues(zSafeGUID, pCLDBName)
    '        Call BuildSafeFileNo(zSafeGUID)

    '        Return zSafeGUID
    '    Else
    '        Diagnostics.EventLog.WriteEntry("GRC Connect", "Silent Authenticate failed. The system failed to authenticate Email=" & pEmail & ", Password=" & pPassword & ", CldbName=" & pCLDBName, EventLogEntryType.Error)
    '        Throw New Exception("Authentication failed. See Windows Eventlog for more details.")
    '    End If
    'End Function

    'Public Shared Function GetFullName(pEmailAddress As String) As String
    '    Dim zReturn As String = ""
    '    Dim zEUColl As New BusinessObjects.EzyUsersCollection
    '    Dim zEUQry As New BusinessObjects.EzyUsersQuery("t1")

    '    With zEUQry
    '        .Select(.FullName)
    '        .Where(.Email = pEmailAddress)
    '    End With

    '    If zEUColl.Load(zEUQry) Then
    '        zReturn = zEUColl(0).FullName
    '    End If

    '    Return zReturn
    'End Function

    Public Shared Function SingleLocationPracticeURL(pSafeGUID As String) As String
        'TODO - Add hunt logic for inspection practice records
        Dim zPlantLocation As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.Plant)
        Dim zReturn As String = "~/Home_{{VER}}/Fire/locationdetails.aspx?sid=" & pSafeGUID & "&p1=" & zPlantLocation

        Dim zWLQry As New BusinessObjects.GRIPSSWorkloadQuery("t1")
        Dim zWLColl As New BusinessObjects.GRIPSSWorkloadCollection

        With zWLQry
            .es.Top = 1
            .Select(.PracticeCode, .Report1)
            .Where(.FileNo = zPlantLocation)
            .OrderBy(.FileNo, EntitySpaces.DynamicQuery.esOrderByDirection.Ascending)
        End With

        If zWLColl.Load(zWLQry) Then
            Dim zPracticeGroup As String = Left(zWLColl(0).PracticeCode, 2)
            Select Case zPracticeGroup
                Case "51" 'Boiler
                    zReturn = "~/Home_{{VER}}/Boiler/locationdetails.aspx?sid=" & pSafeGUID & "&p1=" & zPlantLocation
                Case "53" 'IR
                    zReturn = "~/Home_{{VER}}/Infrared/locationdetails.aspx?sid=" & pSafeGUID & "&p1=" & zPlantLocation
                Case "56" ' Juris
                    zReturn = "~/Home_{{VER}}/Jurisdictional/locationdetails.aspx?sid=" & pSafeGUID & "&p1=" & zPlantLocation
                Case Else
                    If zWLColl(0).PracticeCode = 526 Then
                        zWLQry = New BusinessObjects.GRIPSSWorkloadQuery("t1")
                        With zWLQry
                            .es.Top = 1
                            .Select(.PracticeCode, .Report1)
                            .Where(.FileNo = zPlantLocation)
                            .Where(.Report1.IsNotNull)
                            .OrderBy(.FileNo, EntitySpaces.DynamicQuery.esOrderByDirection.Ascending)
                        End With

                        If zWLColl.Load(zWLQry) Then
                            Dim zHaz As String = LCase(zWLColl(0).Report1)
                            If zHaz.Contains("wind") Then zReturn = "~/Home_{{VER}}/Wind/locationdetails.aspx?sid=" & pSafeGUID & "&p1=" & zPlantLocation
                            If zHaz.Contains("flood") Then zReturn = "~/Home_{{VER}}/Flood/locationdetails.aspx?sid=" & pSafeGUID & "&p1=" & zPlantLocation
                            If zHaz.Contains("seismic") Then zReturn = "~/Home_{{VER}}/Seismic/locationdetails.aspx?sid=" & pSafeGUID & "&p1=" & zPlantLocation
                        End If

                    Else
                        zReturn = "~/Home_{{VER}}/Fire/locationdetails.aspx?sid=" & pSafeGUID & "&p1=" & zPlantLocation
                    End If
            End Select
        End If
        Return zReturn
    End Function

    Public Shared Function DocumentAccessURL(pSafeGUID As String) As String
        Dim zReturn As String = "~/Home_{{VER}}/Grids/LibrariesDocumentLibrary/LibrariesDocumentLibrary.aspx?sid=" & pSafeGUID
        Return zReturn
    End Function

    Public Shared Function MultipleAccounts(pEmail As String) As Boolean
        Dim zReturn As Boolean = False
        Dim zQry As New BusinessObjects.EzyUsersQuery("t1")
        Dim zColl As New BusinessObjects.EzyUsersCollection
        zQry.SelectAll()
        zQry.Where(zQry.Email.ToLower = pEmail.ToLower)
        If zColl.Load(zQry) Then
            If zColl.Count > 1 Then
                zReturn = True
            End If
            If zColl(0).GRCAdministrator IsNot Nothing Then
                If zColl(0).GRCAdministrator.Trim.Length > 0 Then
                    zReturn = True
                End If
            End If
        End If
        Return zReturn
    End Function

    Public Shared Function ValidatePasswordStrength(pEmail As String, pPassword As String) As String
        Dim zReturn As String = "Valid"
        Dim zUL As New UtilLogin
        Dim zMessage As String = ""

        If MultipleAccounts(pEmail) Then
            'Multiple accounts not supported at this time
        Else
            Dim zEU As New BusinessObjects.EzyUsers
            If zEU.LoadByEmail(pEmail) Then
                If Not zEU.Manage.IsValidPasswordLength(pPassword) Then
                    zMessage = "Must be at least " & zEU.Client.SecurityPasswordMinimumLength & " in length.  "
                End If

                If Not zEU.Manage.IsValidPasswordStrength(pPassword) Then
                    Select Case zEU.Client.SecurityPasswordTypeId
                        Case BusinessObjects.DdPasswordType.PasswordTypes.Alphanumeric
                            zMessage = zMessage & "Password must contain at least one letter and one number."
                        Case BusinessObjects.DdPasswordType.PasswordTypes.AlphanumericWithCaps
                            zMessage = zMessage & "Password must contain at least one letter, one number, and one capital letter."
                        Case BusinessObjects.DdPasswordType.PasswordTypes.AlphanumericAndSpecialChars
                            zMessage = zMessage & "Password must contain at least one letter, one number, and one special character."
                        Case BusinessObjects.DdPasswordType.PasswordTypes.AlphanumericAndSpecialCharsWithCaps
                            zMessage = zMessage & "Password must contain at least one letter, one number, one capital letter and one special character."
                    End Select
                End If
            End If

            If zMessage.Length = 0 Then
                zEU.LastPWChange = Now
                zEU.SecurityPasswordIsExpired = False
                zEU.Save()
            End If

        End If

        If zMessage.Length > 0 Then zReturn = zMessage
        If zReturn.ToLower = "Valid".ToLower Then

        End If

        Return zReturn
    End Function

    'Private Function StrengthCheck(pData As String, pMode As String) As Boolean
    '    Dim zReturn As Boolean = False
    '    Dim zCountAlphaLower As Integer = 0
    '    Dim zCountAlphaUpper As Integer = 0
    '    Dim zCountNumeric As Integer = 0
    '    Dim zCountSpecial As Integer = 0
    '    Dim zChar As String = ""

    '    For zNdx = 1 To pData.Length
    '        zChar = Mid(pData, zNdx, 1)
    '        If InStr(DataAlpha, zChar) > 0 Then zCountAlphaLower = zCountAlphaLower + 1
    '        If InStr(DataAlpha.ToUpper, zChar) > 0 Then zCountAlphaUpper = zCountAlphaUpper + 1
    '        If InStr(DataNumeric, zChar) > 0 Then zCountNumeric = zCountNumeric + 1
    '        If InStr(DataSpecial, zChar) > 0 Then zCountSpecial = zCountSpecial + 1
    '    Next

    '    Select Case pMode
    '        Case "Alphanumeric".ToLower
    '            If zCountAlphaLower + zCountAlphaUpper >= 1 And zCountNumeric >= 1 Then zReturn = True
    '        Case "Alphanumeric with Caps".ToLower
    '            If zCountAlphaLower >= 1 And zCountAlphaUpper >= 1 And zCountNumeric >= 1 Then zReturn = True
    '        Case "Alphanumeric and Special Characters".ToLower
    '            If zCountAlphaLower + zCountAlphaUpper >= 1 And zCountNumeric >= 1 And zCountSpecial >= 1 Then zReturn = True
    '        Case "Alphanumeric and Special Characters with Caps".ToLower
    '            If zCountAlphaLower >= 1 And zCountAlphaUpper >= 1 And zCountNumeric >= 1 And zCountSpecial >= 1 Then zReturn = True
    '    End Select

    '    Return zReturn
    'End Function

    'Public Shared Function Authenticate(pEmail As String, pPassword As String) As String
    '    Dim zReturn As String = ""
    '    Dim zUserEmail As String = pEmail
    '    Dim zUserPassword As String = pPassword
    '    Dim zSafeGUID As String = ""

    '    Dim zObj As New BusinessObjects.EzyUsers
    '    Dim zQry As New BusinessObjects.EzyUsersQuery("t1")
    '    'REPLACE THIS V V V V V V V
    '    zQry.Select(zQry.Email, zQry.UserID, zQry.FullName, zQry.EzyUserID)
    '    zQry.SelectAll()
    '    zQry.Where(zQry.Email = zUserEmail)
    '    zQry.Where(zQry.Password = zUserPassword)
    '    zQry.Where(zQry.ActiveUser = True)
    '    zQry.es.Top = 1
    '    'REPLACE THIS ^ ^ ^ ^ ^ ^ ^ ^
    '    'WITH THIS V V V V V V V V
    '    '   Dim util As New UtilLogin2
    '    '   Dim zList As List(Of rowTblEzyLogin) = util.GetUser(pEmail)
    '    '   If zList.Count > 0 Then
    '    If zObj.Load(zQry) Then
    '        Dim zAM As New BusinessObjects.EzyUsers.AccountManagement(zObj)
    '        zAM.SetLastLogin()
    '        zAM = Nothing

    '        zSafeGUID = UtilGSafe.StartSafeSession(zUserEmail)
    '        Dim zSafeId As Integer = UtilGSafe.GetId(zSafeGUID)

    '        Call AuditLogout(False, zSafeGUID, 0)

    '        'Session("SafeGUID") = zSafeGUID
    '        UtilGSafe.ClearSafeSession_ByGSafeGUID(zSafeGUID)
    '        UtilSafe.ResetLargeObjectData(zSafeId)

    '        'UtilGSafe.ClearSafeSession_ByDataGroup(zSafeGUID, UtilGSafe.KeyNameGroup.PageHeader)
    '        UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.EzyUserId, zObj.EzyUserID, UtilGSafe.KeyNameGroup.Authentication)
    '        UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.UserEmail, zUserEmail, UtilGSafe.KeyNameGroup.Authentication)
    '        UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.UserPassword, zUserPassword, UtilGSafe.KeyNameGroup.Authentication)
    '        UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.AdminUser, CStr(IsAdminUser(zObj.Email)), UtilGSafe.KeyNameGroup.Authentication)
    '        UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.currentPage, "1", UtilGSafe.KeyNameGroup.Navigation)
    '        UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.currentTab, "1", UtilGSafe.KeyNameGroup.Navigation)
    '        UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.userFullName, zObj.FullName, UtilGSafe.KeyNameGroup.PageHeader)

    '        UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.findFileNo, "", UtilGSafe.KeyNameGroup.FindLocation)
    '        UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.findClientLocNo, "", UtilGSafe.KeyNameGroup.FindLocation)
    '        UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.findAddress1, "", UtilGSafe.KeyNameGroup.FindLocation)
    '        UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.findCity, "", UtilGSafe.KeyNameGroup.FindLocation)
    '        UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.findStProv, "", UtilGSafe.KeyNameGroup.FindLocation)
    '        UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.findCountry, "", UtilGSafe.KeyNameGroup.FindLocation)
    '        UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.findZip, "", UtilGSafe.KeyNameGroup.FindLocation)
    '        UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.findDivision, "", UtilGSafe.KeyNameGroup.FindLocation)
    '        UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.findFacility, "", UtilGSafe.KeyNameGroup.FindLocation)
    '        UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.findCustomAccess, "", UtilGSafe.KeyNameGroup.FindLocation)
    '        UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.findLongitude, "", UtilGSafe.KeyNameGroup.FindLocation)
    '        UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.findLatitude, "", UtilGSafe.KeyNameGroup.FindLocation)

    '        ' NOTE: THIS WILL HAVE TO BE CLEARED OR CHANGED IF A DIFFERENT WAY OF STORING LONG TERM MYPREFERENCES IS APPLIED
    '        'UtilGSafe.SetValue(zSafeGUID, UtilGSafe.PreferenceKeyName.IsMyPreferenceActive, "", UtilGSafe.KeyNameGroup.Preference)

    '        Call BuildSafeFilePrefix(zSafeGUID)
    '    End If

    '    zReturn = zSafeGUID

    '    Return zReturn
    'End Function

    'Public Shared Function GetGRCAdministrator(pEmail As String, pPassword As String) As String
    '    Dim zReturn As String = ""
    '    Dim zColl As New BusinessObjects.EzyUsersCollection
    '    Dim zQry As New BusinessObjects.EzyUsersQuery("T1")

    '    zQry.SelectAll()
    '    zQry.Where(zQry.Email = pEmail)
    '    zQry.Where(zQry.Password = pPassword)
    '    zQry.Where(zQry.GRCAdministrator.IsNotNull)

    '    If zColl.Load(zQry) Then
    '        If zColl(0).GRCAdministrator.Length > 0 Then
    '            zReturn = zColl(0).GRCAdministrator
    '        End If
    '    End If

    '    Return zReturn
    'End Function

    Public Shared Function IsAllowPasswordChange(pFilePrefix As String) As Boolean
        Dim zReturn As Boolean = False
        Dim zColl As New BusinessObjects.ClientsCollection
        Dim zQry As New BusinessObjects.ClientsQuery("T1")

        zQry.SelectAll()
        zQry.Where(zQry.SecurityAllowChangePassword = True)
        zQry.Where(zQry.Fileprefix = pFilePrefix)

        If zColl.Load(zQry) Then
            zReturn = True
        Else
            zReturn = False
        End If

        Return zReturn
    End Function

    'Public Shared Function IsGRCAdministrator(pEmail As String, pPassword As String) As Boolean
    '    Dim zReturn As Boolean = False
    '    Dim zColl As New BusinessObjects.EzyUsersCollection
    '    Dim zQry As New BusinessObjects.EzyUsersQuery("T1")

    '    zQry.SelectAll()
    '    zQry.Where(zQry.Email = pEmail)
    '    zQry.Where(zQry.Password = pPassword)
    '    zQry.Where(zQry.GRCAdministrator.IsNotNull)

    '    If zColl.Load(zQry) Then
    '        If zColl(0).GRCAdministrator.Length > 0 Then
    '            zReturn = True
    '        End If
    '    End If

    '    Return zReturn
    'End Function

    'Public Shared Function IsAdminUser(pEmail As String) As Boolean
    '    Dim zReturn As Boolean = False
    '    Dim zColl As New BusinessObjects.EzyUsersCollection
    '    Dim zQry As New BusinessObjects.EzyUsersQuery("T1")

    '    zQry.SelectAll()
    '    zQry.Where(zQry.Email.ToLower = pEmail.ToLower)
    '    zQry.Where(zQry.GRCAdministrator = "00")

    '    If zColl.Load(zQry) Then
    '        zReturn = True
    '    End If

    '    Return zReturn
    'End Function

    'Public Shared Sub BuildSafeFilePrefix(pSafeGUID As String)
    '    Dim zUserEmail As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.UserEmail)
    '    Dim zUserPassword As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.UserPassword)

    '    Select Case UtilLogin.GetGRCAdministrator(zUserEmail, zUserPassword)
    '        Case "00", "01"
    '            'Load 580Active clients
    '            Dim zColl As New BusinessObjects.ClientsCollection
    '            Dim zQry As New BusinessObjects.ClientsQuery("t1")

    '            zQry.Select(zQry.Fileprefix)
    '            'zQry.Where(zQry._580active = True)
    '            zQry.es.Distinct = True

    '            'Dim zInsObj As New BusinessObjects.GSafeFilePrefix
    '            'Dim zInsColl As New BusinessObjects.GSafeFilePrefixCollection
    '            'Dim zInsQry As New BusinessObjects.GSafeFilePrefixQuery
    '            Dim zSafeId As Integer = UtilGSafe.GetId(pSafeGUID)

    '            Dim zUtil As New EntitySpaces.Core.esUtility()

    '            'ADJUSTED COMMAND TO PREVENT HITS TO DATABASE

    '            Dim zDeleteCount As Integer = zUtil.ExecuteNonQuery(EntitySpaces.DynamicQuery.esQueryType.Text, "DELETE GSafeFilePrefix WHERE GSafeId=" & zSafeId)
    '            Dim zInsertCount As Integer = zUtil.ExecuteNonQuery(EntitySpaces.DynamicQuery.esQueryType.Text, "INSERT INTO GSafeFilePrefix(GSafeId, FilePrefix) Select " & zSafeId & ", FilePrefix FROM Clients")

    '            'zInsQry.SelectAll()
    '            'zInsQry.Where(zInsQry.GSafeId = zSafeId)
    '            'If zInsColl.Load(zInsQry) Then
    '            '    zInsColl.MarkAllAsDeleted()
    '            '    zInsColl.Save()
    '            'End If

    '            'If zColl.Load(zQry) Then
    '            '    For Each zObj As BusinessObjects.Clients In zColl
    '            '        zInsObj = zInsColl.AddNew()
    '            '        zInsObj.GSafeId = zSafeId
    '            '        zInsObj.FilePrefix = Val(zObj.Fileprefix).ToString()
    '            '        zInsObj.Save()
    '            '    Next
    '            'End If

    '        Case "04"
    '            'Load Employee/clients
    '            Dim zColl As New BusinessObjects.EmployeeClientListCollection
    '            Dim zQry As New BusinessObjects.EmployeeClientListQuery("t1")

    '            zQry.Select(zQry.FileNbrPrefix)
    '            zQry.Where(zQry.Email = zUserEmail)
    '            zQry.es.Distinct = True

    '            Dim zInsObj As New BusinessObjects.GSafeFilePrefix
    '            Dim zInsColl As New BusinessObjects.GSafeFilePrefixCollection
    '            Dim zInsQry As New BusinessObjects.GSafeFilePrefixQuery
    '            Dim zSafeId As Integer = UtilGSafe.GetId(pSafeGUID)

    '            zInsQry.SelectAll()
    '            zInsQry.Where(zInsQry.GSafeId = zSafeId)
    '            If zInsColl.Load(zInsQry) Then
    '                zInsColl.MarkAllAsDeleted()
    '                zInsColl.Save()
    '            End If

    '            If zColl.Load(zQry) Then
    '                For Each zObj As BusinessObjects.EmployeeClientList In zColl
    '                    zInsObj = zInsColl.AddNew()
    '                    zInsObj.GSafeId = zSafeId
    '                    zInsObj.FilePrefix = Val(zObj.FileNbrPrefix).ToString()
    '                    zInsObj.Save()
    '                Next
    '            End If

    '        Case Else
    '            'Load based on number of ezy_user records
    '            Dim zColl As New BusinessObjects.EzyUsersCollection
    '            Dim zQry As New BusinessObjects.EzyUsersQuery("t1")

    '            zQry.Select(zQry.FilePrefix)
    '            zQry.Where(zQry.Email = zUserEmail)
    '            zQry.Where(zQry.Password = zUserPassword)
    '            zQry.Where(zQry.ActiveUser = True)
    '            zQry.es.Distinct = True

    '            Dim zInsObj As New BusinessObjects.GSafeFilePrefix
    '            Dim zInsColl As New BusinessObjects.GSafeFilePrefixCollection
    '            Dim zInsQry As New BusinessObjects.GSafeFilePrefixQuery
    '            Dim zSafeId As Integer = UtilGSafe.GetId(pSafeGUID)

    '            zInsQry.SelectAll()
    '            zInsQry.Where(zInsQry.GSafeId = zSafeId)
    '            If zInsColl.Load(zInsQry) Then
    '                zInsColl.MarkAllAsDeleted()
    '                zInsColl.Save()
    '            End If

    '            If zColl.Load(zQry) Then
    '                For Each zObj As BusinessObjects.EzyUsers In zColl
    '                    zInsObj = zInsColl.AddNew()
    '                    zInsObj.GSafeId = zSafeId
    '                    zInsObj.FilePrefix = Val(zObj.FilePrefix).ToString()
    '                    zInsObj.Save()
    '                Next
    '            End If
    '    End Select
    'End Sub

    'Public Shared Sub SetClientValues(pSafeGUID As String, pCLDBName As String)

    '    Dim zCLDBName As String = pCLDBName
    '    Dim zClientName As String = ""
    '    Dim zFilePrefix As String = ""
    '    Dim zClientFeatures As String = ""
    '    Dim zCustomAccessLabel As String = ""
    '    Dim zCustomAccessLabelOriginal As String = ""

    '    Dim zObj As New BusinessObjects.Clients
    '    Dim zQry As New BusinessObjects.ClientsQuery

    '    zQry.SelectAll()
    '    zQry.Where(zQry.Cldbname = zCLDBName)
    '    zQry.es.Top = 1

    '    If zObj.Load(zQry) Then
    '        zFilePrefix = zObj.Fileprefix
    '        zClientFeatures = zObj.Features
    '        zClientName = zObj.Clientname
    '        zCustomAccessLabelOriginal = zObj.CustomAccessLabel
    '        If zObj.CustomAccessLabel.Length > 0 And zObj.CustomAccessLabel.ToLower = "not used" Then
    '            'DB - This value is set in the safe, and consequently a session variable is set. Grids depend on the session value on whether or not to show
    '            'the custom access column.
    '            zCustomAccessLabel = "Not Used"  '"Cus. Access(es)"
    '        Else
    '            zCustomAccessLabel = zObj.CustomAccessLabel
    '        End If
    '    End If

    '    Dim zUserEmail As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.UserEmail)
    '    Dim zUserPassword As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.UserPassword)

    '    'If the user is GRCAdministrator, we must set the FilePrefix value in ezy_user table to reflect the client that was selected.
    '    If UtilLogin.IsGRCAdministrator(zUserEmail, zUserPassword) Then
    '        'Change this to a stored proc since we are changing the compound primary key value
    '        Dim zStoredProc As String = ""
    '        zStoredProc = "EXEC spSetEzyUserFilePrefix '" & zUserEmail & "', '" & UtilLogin.GetGRCAdministrator(zUserEmail, zUserPassword) & "', '" & zUserPassword & "', " & zFilePrefix
    '        UtilDB.ExecuteProcedure(zStoredProc)
    '    End If

    '    'Check the current session data for a FilePrefix value, if different then clear preferences.  User preferences do NOT apply across separate FilePrefix values.
    '    'If UtilGSafe.GetValue(pSafeGUID, "FilePrefix") <> zFilePrefix Then
    '    '  UtilGSafe.ClearSafeSession_ByDataGroup(pSafeGUID, "Preference")
    '    'End If

    '    'set selected client values to the safe
    '    UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.FilePreFix, zFilePrefix, UtilGSafe.KeyNameGroup.Switch)
    '    UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.cldbName, zCLDBName, UtilGSafe.KeyNameGroup.Switch)
    '    UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.ClientName, zClientName, UtilGSafe.KeyNameGroup.PageHeader)
    '    UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.clientFeatures, zClientFeatures, UtilGSafe.KeyNameGroup.PageHeader)
    '    UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.practiceName, "", UtilGSafe.KeyNameGroup.PageHeader)
    '    UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.CustomAccessLabel, zCustomAccessLabel, UtilGSafe.KeyNameGroup.Preference)
    '    UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.CustomAccessLabelDefault, zCustomAccessLabel & " Default", UtilGSafe.KeyNameGroup.Preference)
    '    UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.CustomAccessLabelOriginal, zCustomAccessLabelOriginal, UtilGSafe.KeyNameGroup.Preference)
    '    UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.BMRatingKeyID, zObj.BMRatingKeyID, UtilGSafe.KeyNameGroup.Preference)
    '    UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.FireRatingKeyID, zObj.FireRatingKeyID, UtilGSafe.KeyNameGroup.Preference)
    '    If Not zObj.Recautofollowup Is Nothing Then
    '        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.Recautofollowup, zObj.Recautofollowup, UtilGSafe.KeyNameGroup.Preference)
    '    Else
    '        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.Recautofollowup, "False", UtilGSafe.KeyNameGroup.Preference)
    '    End If

    '    'set user client options to the safe
    '    Call SetDefaultPreferences(pSafeGUID)

    '    Dim zObjEU = New BusinessObjects.EzyUsers
    '    Dim zQryEU = New BusinessObjects.EzyUsersQuery

    '    zQryEU.SelectAllExcept(zQryEU.CustomAccess, zQryEU.CustomAccessText, zQryEU.Division, zQryEU.DivisionManager, zQryEU.PlantManager, zQryEU.Plant)
    '    zQryEU.Select(zQryEU.DocumentAccess.Coalesce("'False'"))  'protect against nulls in the ezy_users table
    '    zQryEU.Select(zQryEU.CustomAccess.Coalesce("'False'"))  'protect against nulls in the ezy_users table
    '    zQryEU.Select(zQryEU.CustomAccessText.Coalesce("''"))  'protect against nulls in the ezy_users table
    '    zQryEU.Select(zQryEU.DivisionManager.Coalesce("'False'"))  'protect against nulls in the ezy_users table
    '    zQryEU.Select(zQryEU.Division.Coalesce("''"))  'protect against nulls in the ezy_users table
    '    zQryEU.Select(zQryEU.PlantManager.Coalesce("'False'"))  'protect against nulls in the ezy_users table
    '    zQryEU.Select(zQryEU.Plant.Coalesce("''"))  'protect against nulls in the ezy_users table
    '    zQryEU.Where(zQryEU.Email = zUserEmail)
    '    zQryEU.Where(zQryEU.Password = zUserPassword)
    '    zQryEU.Where(zQryEU.FilePrefix = zFilePrefix)
    '    zQryEU.es.Top = 1

    '    If zObjEU.Load(zQryEU) Then
    '        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.DocumentAccess, zObjEU.DocumentAccess, UtilGSafe.KeyNameGroup.Authentication)
    '        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.DivisionManager, zObjEU.DivisionManager, UtilGSafe.KeyNameGroup.Authentication)
    '        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.Division, zObjEU.Division, UtilGSafe.KeyNameGroup.Authentication)
    '        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.CustomAccess, zObjEU.CustomAccess, UtilGSafe.KeyNameGroup.Authentication)
    '        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.CustomAccessText, zObjEU.CustomAccessText, UtilGSafe.KeyNameGroup.Authentication)
    '        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.PlantManager, zObjEU.PlantManager, UtilGSafe.KeyNameGroup.Authentication)
    '        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.Plant, zObjEU.Plant, UtilGSafe.KeyNameGroup.Authentication)
    '        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.UserID, zObjEU.UserID, UtilGSafe.KeyNameGroup.Authentication)
    '        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.PreviousLoginDate, If(IsNothing(zObjEU.LastLogin), Now.ToString, zObjEU.LastLogin), UtilGSafe.KeyNameGroup.Authentication)

    '        If UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.PlantManager) = "True" Then
    '            UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.SingleUser, "True", UtilGSafe.KeyNameGroup.Authentication)
    '            UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.AdminUser, "False", UtilGSafe.KeyNameGroup.Authentication)
    '        Else
    '            UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.SingleUser, "False", UtilGSafe.KeyNameGroup.Authentication)
    '        End If

    '        'Set user settings values
    '        Dim zDefault As String = ""
    '        If zObjEU.Division.Length = 0 Then
    '            zDefault = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.DivisionDefaultText)
    '            UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.Division, zDefault, UtilGSafe.KeyNameGroup.Preference)
    '        End If

    '        If zObjEU.CustomAccessText.Length = 0 Then
    '            zDefault = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.CustomAccessDefaultText)
    '            UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.CustomAccessText, zDefault, UtilGSafe.KeyNameGroup.Preference)
    '        End If
    '    End If

    '    Dim zObjUpdateEU = New BusinessObjects.EzyUsers
    '    Dim zQryUpdateEU = New BusinessObjects.EzyUsersQuery

    '    With zQryUpdateEU
    '        .Select(.UserID, .FilePrefix, .LastLogin)
    '        .Where(.Email = zUserEmail)
    '        .Where(.Password = zUserPassword)
    '        .Where(.FilePrefix = zFilePrefix)
    '        .es.Top = 1

    '        If zObjEU.Load(zQryEU) Then
    '            zObjEU.LastLogin = Now
    '            zObjEU.Save()
    '        End If
    '    End With

    '    Call AuditLogin(pSafeGUID)

    '    Dim zUserFilterSQL As String = UtilGSafe.GetFilterSQL(pSafeGUID, zFilePrefix)
    '    If zUserFilterSQL.Length > 0 Then
    '        'NOTE 12/6/2012: THE CALL FOR BuildSafeFileNo() IS A TEMP PATCH. SHOULD BE OPTIMIZED BY D.P. TO NOT BE DEPENDENT ON A FULL FILE NO LIST.
    '        Call BuildSafeFileNo(pSafeGUID)
    '        Call BuildUserFilteredSafeFileNo(pSafeGUID, zUserFilterSQL)
    '    Else
    '        Call BuildSafeFileNo(pSafeGUID)
    '    End If
    'End Sub

    'Public Shared Sub SetDefaultPreferences(pSafeGUID As String)
    '    Dim zFilePrefix As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.FilePreFix)

    '    If UtilGSafe.GetValue(pSafeGUID, zFilePrefix, UtilGSafe.PreferenceKeyName.CurrencyDefaultText).Length = 0 Then UtilGSafe.SetValue(pSafeGUID, zFilePrefix, UtilGSafe.PreferenceKeyName.CurrencyDefaultText, "USD", UtilGSafe.KeyNameGroup.Preference)
    '    If UtilGSafe.GetValue(pSafeGUID, zFilePrefix, UtilGSafe.PreferenceKeyName.UnitDefaultText).Length = 0 Then UtilGSafe.SetValue(pSafeGUID, zFilePrefix, UtilGSafe.PreferenceKeyName.UnitDefaultText, "English", UtilGSafe.KeyNameGroup.Preference)
    '    'If UtilGSafe.GetValue(pSafeGUID, "TIVDefaultText").Length = 0 Then UtilGSafe.SetValue(pSafeGUID, "TIVDefaultText", "(All)", "Preference")
    '    'If UtilGSafe.GetValue(pSafeGUID, "LocationDefaultText").Length = 0 Then UtilGSafe.SetValue(pSafeGUID, "LocationDefaultText", "(All)", "Preference")
    '    'If UtilGSafe.GetValue(pSafeGUID, "DivisionDefaultText").Length = 0 Then UtilGSafe.SetValue(pSafeGUID, "DivisionDefaultText", "(All)", "Preference")
    '    'If UtilGSafe.GetValue(pSafeGUID, "CustomAccessDefaultText").Length = 0 Then UtilGSafe.SetValue(pSafeGUID, "CustomAccessDefaultText", "(All)", "Preference")

    '    'UtilGSafe.SetValue(pSafeGUID, "CurrencyDefaultText", "USD", "Preference")
    '    'UtilGSafe.SetValue(pSafeGUID, "UnitDefaultText", "English", "Preference")
    '    UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.TIVDefaultText, "(All)", UtilGSafe.KeyNameGroup.Preference)
    '    UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.LocationDefaultText, "(All)", UtilGSafe.KeyNameGroup.Preference)
    '    UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.DivisionDefaultText, "(All)", UtilGSafe.KeyNameGroup.Preference)
    '    UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.CustomAccessDefaultText, "(All)", UtilGSafe.KeyNameGroup.Preference)
    'End Sub

    'Public Shared Sub BuildSafeFileNo(pSafeGUID As String)
    '    Call UtilLogin.BuildSafeFileNo3(pSafeGUID)
    '    Exit Sub

    '    Dim zSW As New Stopwatch

    '    zSW.Start()
    '    Diagnostics.Debug.WriteLine("Starting BuildSafeFileNo")
    '    Dim zFilePrefix As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.FilePreFix)

    '    'Change this routine to use the viewCCUserSecureLocations view after generated
    '    Dim zColl As New BusinessObjects.ViewCCUserSecureLocationsCollection
    '    Dim zQry As New BusinessObjects.ViewCCUserSecureLocationsQuery("t1")

    '    zQry.Select(zQry.FileNo)
    '    zQry.Where(zQry.FilePrefix = zFilePrefix)
    '    zQry.Where(zQry.GSafeGUID = pSafeGUID)

    '    'Check GSafe for Division Access
    '    Dim zDivision As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.Division)
    '    If zDivision.Length > 0 And zDivision <> "(All)" Then
    '        zQry.Where(zQry.Division = zDivision)
    '    End If

    '    'Check GSafe for Custom Access
    '    Dim zCustomAccess As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.CustomAccessText)
    '    If zCustomAccess.Length > 0 And zCustomAccess <> "(All)" Then
    '        zQry.Where(zQry.CustomAccess = zCustomAccess)
    '    End If

    '    'Check GSafe for Location restriction
    '    Dim zLocation As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.LocationDefaultText)
    '    If zLocation.Length > 0 And zLocation <> "(All)" Then
    '        zQry.Where(zQry.FileNo = zLocation)
    '    End If

    '    'Check GSafe for TIV restriction
    '    Dim zTIV As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.TIVDefaultText)
    '    If zTIV.Length > 0 And zTIV <> "(All)" Then
    '        zQry.Where(zQry.FileNo = zTIV)
    '    End If

    '    'Check for Plant restriction
    '    If UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.PlantManager) = "True" Then
    '        zQry.Where(zQry.FileNo = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.Plant))
    '    End If

    '    zQry.es.Distinct = True

    '    Dim zInsObj As New BusinessObjects.GSafeFileNo
    '    Dim zInsColl As New BusinessObjects.GSafeFileNoCollection
    '    Dim zInsQry As New BusinessObjects.GSafeFileNoQuery
    '    Dim zSafeId As Integer = UtilGSafe.GetId(pSafeGUID)

    '    Dim zUtil As New EntitySpaces.Core.esUtility
    '    Dim zDeleteCount As Integer = zUtil.ExecuteNonQuery(EntitySpaces.DynamicQuery.esQueryType.Text, "DELETE GSafeFileNo WHERE GSafeId=" & zSafeId)


    '    'zInsQry.SelectAll()
    '    'zInsQry.Where(zInsQry.GSafeId = zSafeId)
    '    'If zInsColl.Load(zInsQry) Then
    '    '    zInsColl.MarkAllAsDeleted()
    '    '    zInsColl.Save()
    '    'End If

    '    Dim zLocCount As Integer = 0
    '    Dim zSB As New StringBuilder
    '    If zColl.Load(zQry) Then
    '        For Each zObj As BusinessObjects.ViewCCUserSecureLocations In zColl
    '            zSB.Append(" INSERT INTO GSafeFileNo(GSafeId, FileNo) VALUES(" & zSafeId & "," & zObj.FileNo & "); ")
    '            'zInsObj = zInsColl.AddNew()
    '            'zInsObj.GSafeId = zSafeId
    '            'zInsObj.FileNo = zObj.FileNo

    '            'zInsObj.Save()
    '            zLocCount = zLocCount + 1
    '        Next
    '        Dim zInsertCount As Integer = zUtil.ExecuteNonQuery(EntitySpaces.DynamicQuery.esQueryType.Text, zSB.ToString)
    '    End If
    '    zSW.Stop()
    '    Diagnostics.Debug.WriteLine("Completed BuildSafeFileNo - Lapse " & zSW.Elapsed.TotalSeconds & " sec(s).  Location count: " & zLocCount)

    'End Sub

    'Public Shared Function HasFilterValue(pDataValue As Object) As Boolean
    '    If pDataValue Is Nothing Then
    '        Return False
    '    End If

    '    If IsDBNull(pDataValue) Then
    '        Return False
    '    End If

    '    If pDataValue.ToString.Length = 0 Then
    '        Return False
    '    End If

    '    Return True
    'End Function

    'Public Shared Sub BuildSafeFileNo3(pSafeGUID As String)
    '    Dim zSW As New Stopwatch

    '    Dim zGSafeId As Integer = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetId(pSafeGUID)

    '    zSW.Start()
    '    Diagnostics.Debug.WriteLine("Starting BuildSafeFileNo3")
    '    Dim zFilePrefix As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.FilePreFix)

    '    Dim zList As New List(Of GRC.Connect.Libraries.DataLib.razor.rowViewCCGRIPSSLocationsV3)
    '    Dim zQLocFileNo As New GRC.Connect.Libraries.DataLib.razor.queryViewCCGRIPSSLocationsV3

    '    zQLocFileNo.SelectAll()

    '    'zQLocFileNo.Distinct = True

    '    zQLocFileNo.Where.SetConjuction(UtilSQLServer.ConjuctionOperatorEnum.Or)

    '    zQLocFileNo.Where.OpenParen()

    '    'Check GSafe for Location restriction
    '    Dim zLocation As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.LocationDefaultText)
    '    If zLocation.Length > 0 And zLocation <> "(All)" Then
    '        zQLocFileNo.Where.Add(zQLocFileNo.FileNo.Equals(zLocation))
    '    End If

    '    'Check GSafe for TIV restriction
    '    Dim zTIV As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.TIVDefaultText)
    '    If zTIV.Length > 0 And zTIV <> "(All)" Then
    '        zQLocFileNo.Where.Add(zQLocFileNo.FileNo.Equals(zTIV))
    '    End If

    '    Dim zQEzyUserFilters As New GRC.Connect.Libraries.DataLib.razor.queryVwEzyUsersFilters

    '    'Read the Ezy_User Filter settings
    '    Dim zQUserRequirement As New GRC.Connect.Libraries.DataLib.razor.queryVwEzyUsersFilters
    '    Dim zDT As DataTable
    '    Dim zRow As DataRow
    '    Dim zFltCustomAccess As New List(Of String)
    '    Dim zFltDivision As New List(Of String)
    '    Dim zFltPlant As New List(Of String)
    '    Dim zFltClientLoc As New List(Of String)
    '    Dim zFltFacility As New List(Of String)
    '    Dim zFltCity As New List(Of String)
    '    Dim zFltStProv As New List(Of String)
    '    Dim zFltCountry As New List(Of String)
    '    Dim zColumnName As String = ""

    '    zQUserRequirement.SelectAll()
    '    zQUserRequirement.Where.Add(zQUserRequirement.colGSafeGUID.Equals(pSafeGUID))
    '    'Future use: if we need to use city/state manager to engage special logic for city/state/country
    '    'zQUserRequirement.Where.Add(zQUserRequirement.colStProvManager.NotEqual(True))
    '    'zQUserRequirement.Where.Add(zQUserRequirement.colCityManager.NotEqual(True))

    '    zDT = GRC.Connect.Libraries.DataLib.razor.UtilSQLServer.ExecuteDataTable(zQUserRequirement.QueryText)

    '    If zDT.Rows.Count > 0 Then
    '        For Each zRow In zDT.Rows
    '            'Division
    '            zColumnName = zQEzyUserFilters.colDivision.ColumnName.Replace("[", "").Replace("]", "")
    '            If HasFilterValue(zRow(zColumnName)) Then zFltDivision.Add(zRow(zColumnName))

    '            'Custom Access
    '            zColumnName = zQEzyUserFilters.colCustomAccessText.ColumnName.Replace("[", "").Replace("]", "")
    '            If HasFilterValue(zRow(zColumnName)) Then zFltCustomAccess.Add(zRow(zColumnName))

    '            'Plant
    '            zColumnName = zQEzyUserFilters.colPlant.ColumnName.Replace("[", "").Replace("]", "")
    '            If HasFilterValue(zRow(zColumnName)) Then zFltPlant.Add(zRow(zColumnName))

    '            'ClientLocNo
    '            zColumnName = zQEzyUserFilters.colClientLocNoText.ColumnName.Replace("[", "").Replace("]", "")
    '            If HasFilterValue(zRow(zColumnName)) Then zFltClientLoc.Add(zRow(zColumnName))

    '            'Facility
    '            zColumnName = zQEzyUserFilters.colFacilityText.ColumnName.Replace("[", "").Replace("]", "")
    '            If HasFilterValue(zRow(zColumnName)) Then zFltFacility.Add(zRow(zColumnName))

    '            'City
    '            zColumnName = zQEzyUserFilters.colCityText.ColumnName.Replace("[", "").Replace("]", "")
    '            If HasFilterValue(zRow(zColumnName)) Then zFltCity.Add(zRow(zColumnName))

    '            'StProv
    '            zColumnName = zQEzyUserFilters.colStProvText.ColumnName.Replace("[", "").Replace("]", "")
    '            If HasFilterValue(zRow(zColumnName)) Then zFltStProv.Add(zRow(zColumnName))

    '            'Country
    '            zColumnName = zQEzyUserFilters.colCountryText.ColumnName.Replace("[", "").Replace("]", "")
    '            If HasFilterValue(zRow(zColumnName)) Then zFltCountry.Add(zRow(zColumnName))
    '        Next
    '    End If

    '    'Division
    '    If zFltDivision.Count > 0 Then zQLocFileNo.Where.Add(zQLocFileNo.Division.In(zFltDivision.ToArray))

    '    'Custom Access
    '    If zFltCustomAccess.Count > 0 Then zQLocFileNo.Where.Add(zQLocFileNo.CustomAccess.In(zFltCustomAccess.ToArray))

    '    'Plant
    '    If zFltPlant.Count > 0 Then zQLocFileNo.Where.Add(zQLocFileNo.FileNo.In(zFltPlant.ToArray))

    '    'ClientLocNo
    '    If zFltClientLoc.Count > 0 Then zQLocFileNo.Where.Add(zQLocFileNo.ClientLocNo.In(zFltClientLoc.ToArray))

    '    'Facility
    '    If zFltFacility.Count > 0 Then zQLocFileNo.Where.Add(zQLocFileNo.Facility.In(zFltFacility.ToArray))

    '    'City
    '    If zFltCity.Count > 0 Then zQLocFileNo.Where.Add(zQLocFileNo.City.In(zFltCity.ToArray))

    '    'StProv
    '    If zFltStProv.Count > 0 Then zQLocFileNo.Where.Add(zQLocFileNo.StProv.In(zFltStProv.ToArray))

    '    'Country
    '    If zFltCountry.Count > 0 Then zQLocFileNo.Where.Add(zQLocFileNo.Country.In(zFltCountry.ToArray))

    '    zQLocFileNo.Where.CloseParen()

    '    zQLocFileNo.Where.SetConjuction(UtilSQLServer.ConjuctionOperatorEnum.And)

    '    zQLocFileNo.Where.Add(zQLocFileNo.FilePrefix.Equals(zFilePrefix))

    '    'Add the Preferences user custom filter requirement
    '    Dim zQGSafePref As New queryTblGSafePreferences
    '    zQGSafePref.SelectAll()
    '    zQGSafePref.Where.Add(zQGSafePref.colGSafeId.Equals(zGSafeId))
    '    zQGSafePref.Where.Add(zQGSafePref.colFilePrefix.Equals(zFilePrefix))
    '    zQGSafePref.Where.Add(zQGSafePref.colDataName.Equals("MyPreferenceFilter"))

    '    Dim rowGSafePref As List(Of rowTblGSafePreferences)
    '    rowGSafePref = TblGSafePreferences.LoadData(zQGSafePref.QueryText)

    '    'Process the MyPreferenceFilter JSON string into a SQL Where expression and add to zQLocFileNo
    '    If rowGSafePref.Count > 0 Then
    '        If rowGSafePref(0).colDataValue.Length > 0 Then
    '            'Data has been returned
    '            Dim zFS As New UtilFilterSort
    '            Call zFS.SetFilter(rowGSafePref(0).colDataValue, zQLocFileNo)
    '        End If
    '    End If

    '    Diagnostics.Debug.WriteLine("Location Filter SQL: " & zQLocFileNo.QueryText)
    '    zDT = razor.UtilSQLServer.ExecuteDataTable(zQLocFileNo.QueryText)
    '    Dim zSB As New StringBuilder
    '    Dim zSafeId As Integer = CoreLib.UtilGSafe.GetId(pSafeGUID)
    '    Dim zNdx As Integer = 0
    '    Dim zInsertCount As Integer = 0

    '    If zDT.Rows.Count > 0 Then
    '        Dim zDR As DataRow
    '        Dim zNeedComma As Boolean = False
    '        Dim zDictFileNo As New Dictionary(Of String, String)
    '        zNdx = 0
    '        zSB.Append("INSERT INTO GSafeFileNo(GSafeId, FileNo) VALUES ")
    '        For Each zDR In zDT.Rows
    '            If Not zDictFileNo.ContainsKey(zDR("FileNo")) Then
    '                zDictFileNo.Add(zDR("FileNo"), "")  'This is for keeping track of the FileNo's and not allowing any repeated FileNo values due to NatHaz or TIV in the LocationFilter table.
    '                If zNeedComma Then zSB.Append(",")
    '                zSB.Append("(" & zSafeId & "," & zDR("FileNo") & ")")
    '                zNdx = zNdx + 1
    '                zNeedComma = True

    '                If zNdx Mod 1000 = 999 Then
    '                    zSB.Append(";")
    '                    zSB.Append("INSERT INTO GSafeFileNo(GSafeId, FileNo) VALUES ")
    '                    zNeedComma = False
    '                End If
    '            End If
    '        Next
    '        zSB.Append(";")
    '    End If

    '    Dim zDeleteCount As Integer = razor.UtilSQLServer.ExecuteNonQuery("DELETE GSafeFileNo WHERE GSafeId=" & zSafeId)

    '    If zNdx > 0 Then
    '        zInsertCount = razor.UtilSQLServer.ExecuteNonQuery(zSB.ToString)
    '    End If

    '    zSW.Stop()
    '    Diagnostics.Debug.WriteLine("Completed BuildSafeFileNo3 - Lapse " & zSW.Elapsed.TotalSeconds & " sec(s).  Location count: " & zInsertCount)
    'End Sub

    'Public Shared Sub BuildSafeFileNo2(pSafeGUID As String)
    '    Dim zSW As New Stopwatch

    '    zSW.Start()
    '    Diagnostics.Debug.WriteLine("Starting BuildSafeFileNo2")
    '    Dim zFilePrefix As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.FilePreFix)

    '    Dim zList As New List(Of GRC.Connect.Libraries.DataLib.razor.rowViewCCGRIPSSLocationsV2)
    '    Dim zQLocFileNo As New GRC.Connect.Libraries.DataLib.razor.queryViewCCGRIPSSLocationsV2

    '    zQLocFileNo.SelectAll()

    '    zQLocFileNo.Distinct = True

    '    zQLocFileNo.Where.SetConjuction(UtilSQLServer.ConjuctionOperatorEnum.Or)

    '    zQLocFileNo.Where.OpenParen()

    '    'Check GSafe for Location restriction
    '    Dim zLocation As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.LocationDefaultText)
    '    If zLocation.Length > 0 And zLocation <> "(All)" Then
    '        zQLocFileNo.Where.Add(zQLocFileNo.colFileNo.Equals(zLocation))
    '    End If

    '    'Check GSafe for TIV restriction
    '    Dim zTIV As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.TIVDefaultText)
    '    If zTIV.Length > 0 And zTIV <> "(All)" Then
    '        zQLocFileNo.Where.Add(zQLocFileNo.colFileNo.Equals(zTIV))
    '    End If

    '    Dim zQEzyUserFilters As New GRC.Connect.Libraries.DataLib.razor.queryVwEzyUsersFilters
    '    Dim zArrResult() As String

    '    'Division
    '    zArrResult = BuildEzyUserColumnFilterRequirement(pSafeGUID, zQEzyUserFilters.colDivision)
    '    If zArrResult.Length > 0 Then zQLocFileNo.Where.Add(zQLocFileNo.colDivision.In(zArrResult))

    '    'Custom Access
    '    zArrResult = BuildEzyUserColumnFilterRequirement(pSafeGUID, zQEzyUserFilters.colCustomAccessText)
    '    If zArrResult.Length > 0 Then zQLocFileNo.Where.Add(zQLocFileNo.colCustomAccess.In(zArrResult))

    '    'Plant
    '    zArrResult = BuildEzyUserColumnFilterRequirement(pSafeGUID, zQEzyUserFilters.colPlant)
    '    If zArrResult.Length > 0 Then zQLocFileNo.Where.Add(zQLocFileNo.colFileNo.In(zArrResult))

    '    'ClientLocNo
    '    zArrResult = BuildEzyUserColumnFilterRequirement(pSafeGUID, zQEzyUserFilters.colClientLocNoText)
    '    If zArrResult.Length > 0 Then zQLocFileNo.Where.Add(zQLocFileNo.colClientLocNo.In(zArrResult))

    '    'Facility
    '    zArrResult = BuildEzyUserColumnFilterRequirement(pSafeGUID, zQEzyUserFilters.colFacilityText)
    '    If zArrResult.Length > 0 Then zQLocFileNo.Where.Add(zQLocFileNo.colFacility.In(zArrResult))

    '    'City
    '    zArrResult = BuildEzyUserColumnFilterRequirement(pSafeGUID, zQEzyUserFilters.colCityText)
    '    If zArrResult.Length > 0 Then zQLocFileNo.Where.Add(zQLocFileNo.colCity.In(zArrResult))

    '    'StProv
    '    zArrResult = BuildEzyUserColumnFilterRequirement(pSafeGUID, zQEzyUserFilters.colStProvText)
    '    If zArrResult.Length > 0 Then zQLocFileNo.Where.Add(zQLocFileNo.colStProv.In(zArrResult))

    '    'Country
    '    zArrResult = BuildEzyUserColumnFilterRequirement(pSafeGUID, zQEzyUserFilters.colCountryText)
    '    If zArrResult.Length > 0 Then zQLocFileNo.Where.Add(zQLocFileNo.colCountry.In(zArrResult))

    '    zQLocFileNo.Where.CloseParen()

    '    zQLocFileNo.Where.SetConjuction(UtilSQLServer.ConjuctionOperatorEnum.And)

    '    zQLocFileNo.Where.Add(zQLocFileNo.colFilePrefix.Equals(zFilePrefix))
    '    'zQLocFileNo.Where.Add(zQLocFileNo.colGSafeGUID.Equals(pSafeGUID))

    '    Dim zDT As DataTable = razor.UtilSQLServer.ExecuteDataTable(zQLocFileNo.QueryText)
    '    Dim zSB As New StringBuilder
    '    Dim zSafeId As Integer = CoreLib.UtilGSafe.GetId(pSafeGUID)

    '    If zDT.Rows.Count > 0 Then
    '        Dim zDR As DataRow
    '        Dim zNdx As Integer = 0
    '        zSB.Append("INSERT INTO GSafeFileNo(GSafeId, FileNo) VALUES")
    '        For Each zDR In zDT.Rows
    '            If zNdx > 0 Then zSB.Append(",")
    '            zSB.Append("(" & zSafeId & "," & zDR("FileNo") & ")")
    '            zNdx = zNdx + 1
    '        Next
    '        zSB.Append(";")
    '    End If

    '    Dim zInsertCount As Integer = razor.UtilSQLServer.ExecuteNonQuery(zSB.ToString)

    '    zSW.Stop()
    '    Diagnostics.Debug.WriteLine("Completed BuildSafeFileNo2 - Lapse " & zSW.Elapsed.TotalSeconds & " sec(s).  Location count: " & zInsertCount)
    'End Sub

    Public Shared Function BuildEzyUserColumnFilterRequirement(pSafeGUID As String, pObjectColumn As Object) As String()
        Dim zReturn() As String = Nothing
        Dim zDT As DataTable
        Dim zRow As DataRow
        Dim zNdx As Integer = 0

        Dim zQUserRequirement As New GRC.Connect.Libraries.DataLib.razor.queryVwEzyUsersFilters

        zQUserRequirement.GroupCount(pObjectColumn)
        zQUserRequirement.Where.Add(zQUserRequirement.colGSafeGUID.Equals(pSafeGUID))

        zDT = GRC.Connect.Libraries.DataLib.razor.UtilSQLServer.ExecuteDataTable(zQUserRequirement.QueryText)

        If zDT.Rows.Count > 0 Then
            zNdx = 0
            For Each zRow In zDT.Rows
                Dim zColumnName As String = pObjectColumn.ColumnName.replace("[", "").Replace("]", "")
                If zRow(zColumnName) Is Nothing Then
                    'EzyUser Data value is not set
                Else
                    ReDim Preserve zReturn(zNdx)
                    zReturn(zNdx) = zRow(zColumnName)
                    zNdx = zNdx + 1
                End If
            Next
        End If

        Return zReturn
    End Function

    Public Shared Sub BuildUserFilteredSafeFileNo(pSafeGUID As String, pUserFilterCriteriaSQL As String)
        Dim zUserFilterCriteriaSQL As String = ""
        zUserFilterCriteriaSQL = Replace(pUserFilterCriteriaSQL, "'", "''")
        UtilDB.ExecuteProcedure("EXEC spBuildUserFilteredSafeFileNo '" & pSafeGUID & "', " & UtilGSafe.GetId(pSafeGUID) & ", '" & zUserFilterCriteriaSQL & "'")
    End Sub

    'Public Shared Sub LogoutUser(pSessionTimeout As Boolean, pSafeGUID As String, pTimeoutLength As Integer)
    '    If pSafeGUID.Length > 0 Then
    '        AuditLogout(pSessionTimeout, pSafeGUID, pTimeoutLength)
    '        UtilFind.ClearFindFields(pSafeGUID)

    '        If pSessionTimeout Then
    '            UtilGSafe.ClearSafeSession_ByDataGroup(pSafeGUID, UtilGSafe.KeyNameGroup.Authentication)
    '        Else
    '            Dim zEmail As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.UserEmail)
    '            Dim zPassword As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.UserPassword)
    '            If Not UtilLogin.IsGRCAdministrator(zEmail, zPassword) Then UtilGSafe.ClearSafeSession_ByDataGroup(pSafeGUID, UtilGSafe.KeyNameGroup.Authentication)
    '        End If
    '    End If
    'End Sub

    'Public Shared Sub AuditLogin(pSafeGUID As String)
    '    Dim zAL As New BusinessObjects.EzyAuditLog

    '    zAL.LogIn = Now
    '    zAL.EzyUserID = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.EzyUserId)
    '    zAL.User = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.userFullName)
    '    zAL.UserID = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.UserEmail)
    '    zAL.Username = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.UserID)
    '    zAL.Fileprefix = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.FilePreFix)
    '    zAL.GRCAdministrator = UtilLogin.GetGRCAdministrator(UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.UserEmail), UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.UserPassword))
    '    zAL.Save()

    '    UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.EzyAuditLogId, zAL.LogID, UtilGSafe.KeyNameGroup.Authentication)
    'End Sub

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

    Public Shared Function UserSeesLocation(ByVal pFileNo As String, ByVal pEzyUserID As Integer) As Boolean
        Dim zReturn As String = UtilDB.ExecuteProcedure("Exec UserSeeLocation '" & pFileNo & "'," & pEzyUserID)
        If zReturn = "" Then
            Return False
        Else
            Return True
        End If
    End Function


End Class
