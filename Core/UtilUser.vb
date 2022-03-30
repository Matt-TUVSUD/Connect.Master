Imports GRC.Connect.Libraries.DataLib.razor

Public Class UtilUser

    Enum Action
        None = 0
        Confirm = 1
        Activate = 2
        Inactivate = 3
        Delete = 4
    End Enum


    Public Shared Sub Sync(pUser As rowTblEzyUsers, ByRef pTransaction As SqlClient.SqlTransaction)

        Dim zLoginId As Integer = pUser.colLoginId

        If zLoginId > 0 Then

            Dim zUserQry As New queryTblEzyUsers
            zUserQry.SelectAll()
            zUserQry.Where.Add(zUserQry.colLoginId.Equals(zLoginId))

            Dim zUsers As New List(Of rowTblEzyUsers)
            zUsers = TblEzyUsers.LoadData(zUserQry.QueryText, pTransaction)

            For Each zUser As rowTblEzyUsers In zUsers
                zUser.colEmail = pUser.colEmail
                zUser.colFullName = pUser.colFullName  'keep full names in sync
                zUser.colInternal = pUser.colInternal
                TblEzyUsers.Save(zUser, pTransaction)
            Next

            Dim zLogin As rowTblEzyLogin = TblEzyLogin.LoadByPrimaryKey(zLoginId, pTransaction)
            zLogin.colEmailAddress = pUser.colEmail
            zLogin.colFullName = pUser.colFullName
            zLogin.colInternal = pUser.colInternal
            TblEzyLogin.Save(zLogin, pTransaction)

        End If

    End Sub

    Public Shared Function SaveEzyUser(pJSON As Dictionary(Of String, Object), ByRef pTransaction As SqlClient.SqlTransaction) As rowTblEzyUsers

        Dim zEzyUserId As Integer = Convert.ToInt32(pJSON("colezyuserid"))
        Dim zIsExistingUser As Boolean = CBool(zEzyUserId)

        Dim zRowUser As New rowTblEzyUsers
        If zIsExistingUser Then zRowUser = TblEzyUsers.LoadByPrimaryKey(zEzyUserId) : zEzyUserId = zRowUser.colEzyUserID

        zRowUser.colFullName = pJSON("colfullname")
        zRowUser.colUserID = pJSON("coluserid")
        zRowUser.colPassword = pJSON("colpassword")

        'ONLY SET THE DATETIMESTAMP AT TIME OF CREATED. NEVER OVERWRITE
        'DO NOT OVERWRITE THE LAST LOGIN DATE
        If Not zIsExistingUser Then
            zRowUser.colDateTimeStamp = DateTime.Now 'Convert.ToDateTime(pJSON("coldatetimestamp"))
            zRowUser.colLastLogin = Nothing 'Convert.ToDateTime(pJSON("collastlogin"))
            zRowUser.colEzyGuid = Guid.NewGuid.ToString("N")
        End If

        zRowUser.colActiveUser = UtilGlobal.Coalesce(pJSON("colactiveuser"), "")
        zRowUser.colThirdParty = UtilGlobal.Coalesce(pJSON("colthirdparty"), False)
        zRowUser.colInternal = UtilGlobal.Coalesce(pJSON("colinternal"), False)
        zRowUser.colGRCAdministrator = UtilGlobal.Coalesce(pJSON("colgrcadministrator"), "")
        zRowUser.colRiskManager = UtilGlobal.Coalesce(pJSON("colriskmanager"), False)
        zRowUser.colDocumentAccess = UtilGlobal.Coalesce(pJSON("coldocumentaccess"), False)
        zRowUser.colCustomAccess = UtilGlobal.Coalesce(pJSON("colcustomaccess"), False)
        zRowUser.colCustomAccessText = UtilGlobal.Coalesce(pJSON("colcustomaccesstext"), "")
        zRowUser.colDivisionManager = UtilGlobal.Coalesce(pJSON("coldivisionmanager"), False)
        zRowUser.colDivision = UtilGlobal.Coalesce(pJSON("coldivision"), "")
        zRowUser.colPlantManager = UtilGlobal.Coalesce(pJSON("colplantmanager"), False)
        zRowUser.colPlant = UtilGlobal.Coalesce(pJSON("colplant"), "")
        zRowUser.colPhone = UtilGlobal.Coalesce(pJSON("colphone"), "")
        zRowUser.colFax = UtilGlobal.Coalesce(pJSON("colfax"), "")
        zRowUser.colEmail = UtilGlobal.Coalesce(pJSON("colemail"), "")
        zRowUser.colComments = UtilGlobal.Coalesce(pJSON("colcomments"), "")
        zRowUser.colRInit = UtilGlobal.Coalesce(pJSON("colrinit"), "")
        zRowUser.colRReport = UtilGlobal.Coalesce(pJSON("colrreport"), "")
        zRowUser.colRfu1 = UtilGlobal.Coalesce(pJSON("colrfu1"), "")
        zRowUser.colRfu2 = UtilGlobal.Coalesce(pJSON("colrfu2"), "")
        zRowUser.colRfu3 = UtilGlobal.Coalesce(pJSON("colrfu3"), "")
        zRowUser.colROverdue1 = UtilGlobal.Coalesce(pJSON("colroverdue1"), "")
        zRowUser.colROverdue2 = UtilGlobal.Coalesce(pJSON("colroverdue2"), "")
        zRowUser.colROverdue3 = UtilGlobal.Coalesce(pJSON("colroverdue3"), "")
        zRowUser.colExpOverdue = UtilGlobal.Coalesce(pJSON("colexpoverdue"), "")
        zRowUser.colWo = UtilGlobal.Coalesce(pJSON("colwo"), False)
        zRowUser.colCCActive = UtilGlobal.Coalesce(pJSON("colccactive"), False)
        zRowUser.colOperatorStamp = UtilGlobal.Coalesce(pJSON("coloperatorstamp"), "")
        zRowUser.colNotificationStamp = IIf(IsNothing(pJSON("colnotificationstamp")), Nothing, Convert.ToDateTime(pJSON("colnotificationstamp")))
        zRowUser.colFilePrefix = UtilGlobal.Coalesce(CShort(pJSON("colfileprefix")), 0)
        zRowUser.colLastPWChange = IIf(IsNothing(pJSON("collastpwchange")), Nothing, Convert.ToDateTime(pJSON("collastpwchange")))
        zRowUser.colRActResp = UtilGlobal.Coalesce(pJSON("colractresp"), "")
        zRowUser.colCalist = UtilGlobal.Coalesce(pJSON("colcalist"), "")
        zRowUser.colDivlist = UtilGlobal.Coalesce(pJSON("coldivlist"), "")
        zRowUser.colLoclist = UtilGlobal.Coalesce(pJSON("colloclist"), "")
        zRowUser.colClientLocNoManager = Convert.ToBoolean(pJSON("colclientlocnomanager"))
        zRowUser.colClientLocNoText = UtilGlobal.Coalesce(pJSON("colclientlocnotext"), "")
        zRowUser.colFacilityManager = Convert.ToBoolean(pJSON("colfacilitymanager"))
        zRowUser.colFacilityText = UtilGlobal.Coalesce(pJSON("colfacilitytext"), "")
        zRowUser.colCityManager = Convert.ToBoolean(pJSON("colcitymanager"))
        zRowUser.colCityText = UtilGlobal.Coalesce(pJSON("colcitytext"), "")
        zRowUser.colStProvManager = Convert.ToBoolean(pJSON("colstprovmanager"))
        zRowUser.colStProvText = UtilGlobal.Coalesce(pJSON("colstprovtext"), "")
        zRowUser.colCountryManager = Convert.ToBoolean(pJSON("colcountrymanager"))
        zRowUser.colCountryText = UtilGlobal.Coalesce(pJSON("colcountrytext"), "")
        zRowUser.colRExpd = UtilGlobal.Coalesce(pJSON("colrexpd"), "")
        zRowUser.colCCOnly = Convert.ToBoolean(pJSON("colcconly"))
        zRowUser.colClientAdministration = Convert.ToBoolean(pJSON("colclientadministration"))
        zRowUser.colAdministrator = False
        zRowUser.colAllowMaintLogin = False
        zRowUser.colSecurityPasswordIsExpired = False
        zRowUser.colSecurityAccountIsLockedOut = False
        TblEzyUsers.Save(zRowUser, pTransaction)

        Return zRowUser

    End Function

    Public Shared Function SaveEzyLogin(ByRef pUser As rowTblEzyUsers, ByRef pTransaction As SqlClient.SqlTransaction) As rowTblEzyLogin

        Dim zEzyUserId As Integer = pUser.colEzyUserID
        Dim zLoginId As Integer = 0
        If IsNumeric(pUser.colLoginId) Then
            zLoginId = pUser.colLoginId
        Else
            Dim LoginList As List(Of rowTblEzyLogin) = TblEzyLogin.LoadByIDX_IX_ezyLogin_EmailAddress(pUser.colEmail)
            If LoginList.Count > 0 Then
                zLoginId = LoginList(0).colLoginID
            End If
        End If

        'THIS CREATES A NEW LOGIN IF DOESNT EXIST. OTHERWISE THE SYNC() FUNCTION UPDATES THE VALUES IN THE LOGIN TABLE.
        Dim zRowLogin As New rowTblEzyLogin
        If zLoginId = 0 Then
            zRowLogin.colEmailAddress = pUser.colEmail
            zRowLogin.colFullName = pUser.colFullName
            zRowLogin.colActiveFlag = pUser.colActiveUser
            zRowLogin.colIsLockedOut = False
            zRowLogin.colLoginGuid = Guid.NewGuid().ToString("N")
            zRowLogin.colInternal = pUser.colInternal
            zRowLogin.colPasswordReminderSentFlag = False
            zRowLogin.colPasswordIsExpired = False
            zRowLogin.colPassword = Guid.NewGuid.ToString("N")
            zRowLogin.colFailedLoginStrikeCount = 0
            zRowLogin.colComments = ""
            zRowLogin.colAllowReclassLoginOverride = False

            TblEzyLogin.Save(zRowLogin, pTransaction)
            zLoginId = zRowLogin.colLoginID
        End If

        'SAVE USER WITH LOGIN ID IF DOESNT EXIST
        If Not IsNumeric(pUser.colLoginId) Then
            pUser.colLoginId = zLoginId
            TblEzyUsers.Save(pUser, pTransaction)
        End If

        zRowLogin = TblEzyLogin.LoadByPrimaryKey(zLoginId, pTransaction)

        Return zRowLogin

    End Function

    Public Shared Sub UpdateUserLoginId(pEzyUserId As Integer, pLoginId As Integer, ByRef pTransaction As SqlClient.SqlTransaction)
        Dim zUser As rowTblEzyUsers = TblEzyUsers.LoadByPrimaryKey(pEzyUserId)
        If zUser.colLoginId = 0 Then
            zUser.colLoginId = pLoginId
            TblEzyUsers.Save(zUser, pTransaction)
        End If
    End Sub

    ''' <summary>
    ''' This procedure is called when a client makes a change in the User Account Form.
    ''' </summary>
    ''' <param name="pUser"></param>
    ''' <remarks></remarks>
    Public Shared Sub SaveEzyUser(pUser As rowVwClientUsers)
        Dim zEzyUser As List(Of rowTblEzyUsers) = TblEzyUsers.LoadByIDX_IX_EzyGuid(pUser.colEzyGuid)

        With zEzyUser(0)
            .colRInit = pUser.colRInit
            .colRReport = pUser.colRReport
            .colRfu1 = pUser.colRfu1
            .colRfu2 = pUser.colRfu2
            .colRfu3 = pUser.colRfu3
            .colROverdue1 = pUser.colROverdue1
            .colROverdue2 = pUser.colROverdue2
            .colROverdue3 = pUser.colROverdue3
            .colExpOverdue = pUser.colExpOverdue
            .colRExpd = pUser.colRExpd
            .colComments = pUser.colComment
            .colClientComment = pUser.colClientComment


            'IF ACION HAS BEEN CHOSEN THEN DO THE FOLLOWING
            If pUser.colActionId <> Action.None Then

                If pUser.colActionId = Action.Delete Then
                    .colMarkedForDeletionDate = DateAdd(DateInterval.Day, 30, CDate(Now))
                    .colActiveUser = False
                Else
                    .colMarkedForDeletionDate = Nothing  'WE NEED TO CLEAR OUT THE DELETE DATE IF BY CHANCE THE USER SELECTED THIS ON FIRST TRY.
                    If pUser.colActionId = Action.Activate Then .colActiveUser = True
                    If pUser.colActionId = Action.Inactivate Then .colActiveUser = False
                End If

            End If

            TblEzyUsers.Save(zEzyUser(0))


            'SET THE LOGIN RECORD AS APPROPRIATE
            .SetLoginActiveFlag(.IsActive)

            If .IsDeleted Then
                .SetLoginMarkForDeletion(.colMarkedForDeletionDate)
            Else
                .ClearLoginMarkForDeletion()
            End If

        End With

    End Sub


End Class
