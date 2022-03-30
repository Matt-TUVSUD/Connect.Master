Imports GRC.Connect.Libraries.DataLib.razor

Public Class UtilUserReclassification
    Implements AppJobLib.IAppJob

    Enum Navigation
        None = 0
        First = 1
        [Next] = 2
        Previous = 3
        Last = 4
    End Enum

    Enum Action
        None = 0
        Confirm = 1
        Activate = 2
        Inactivate = 3
        Delete = 4
    End Enum

    Enum EmailType
        Initial = 1
        FollowUp = 2
    End Enum

    ''TO SIMULATE A PROCESS DATE... CHANGE THE "TODAY DATE" VALUE IN THE BASE VIEW JV.VWRECLASSIFICATIONACCOUNT VIEW.
    Public Sub DoWork()
        'SEND EMAILS
        Process1stRequestEmails()
        Process2ndRequestEmails()

        'AUTO DELETE USERS
        AutoDeleteUsers(Today)

    End Sub

    Public Sub Process1stRequestEmails()

        Dim zQry As New queryVwReclassificationAccount
        zQry.SelectAll()
        zQry.Where.Add(zQry.colSend1stRequestEmail.Equals(True))

        Dim zReclassAccounts As List(Of rowVwReclassificationAccount) = VwReclassificationAccount.LoadData(zQry.QueryText)
        For Each zAccount As rowVwReclassificationAccount In zReclassAccounts
            Setup(zAccount.colFileprefix)
            UpdateClientSentDate(zAccount.colFileprefix, zAccount.colDateToSend1stRequestEmail)
            Send1stRequestEmail(zAccount.colFileprefix)
        Next
    End Sub

    Public Sub Send1stRequestEmail(pFilePrefix As String)

        Dim zClient As rowTblClients = TblClients.LoadByPrimaryKey(pFilePrefix)

        Dim zAccountQry As New queryVwReclassificationAccount
        zAccountQry.SelectAll()
        zAccountQry.Where.Add(zAccountQry.colFilePrefix.Equals(pFilePrefix))

        Dim zAccountList As List(Of rowVwReclassificationAccount) = VwReclassificationAccount.LoadData(zAccountQry.QueryText)
        If zAccountList.Count > 0 Then
            Dim zAccount As rowVwReclassificationAccount = zAccountList(0)
            Dim zTemplate As rowTblEmailTemplate = UtilEmailTemplate.GetReclassification1stRequestTemplate(zAccount.colASIContactName, zAccount.colClientname, zAccount.colServiceLeaderName, GetUserReclassificationPageURL(zClient))
            UtilNotification.SubmitNotification(zAccount.colConnectemail, zAccount.colServiceLeaderEmailAddress, CCUsers, zTemplate.colFldSubject, zTemplate.colFldBody, "Reclassification Initial Request")
        End If

    End Sub

    Public Sub Process2ndRequestEmails()

        Dim zQry As New queryVwReclassificationAccount
        zQry.SelectAll()
        zQry.Where.Add(zQry.colSend2ndRequestEmail.Equals(True))

        Dim zReclassAccounts As List(Of rowVwReclassificationAccount) = VwReclassificationAccount.LoadData(zQry.QueryText)
        For Each zAccount As rowVwReclassificationAccount In zReclassAccounts
            UpdateClientFollowUpDate(zAccount.colFileprefix, zAccount.colDateToSend2ndRequestEmail)
            Send2ndRequestEmail(zAccount.colFileprefix)
        Next

    End Sub

    Public Sub Send2ndRequestEmail(pFilePrefix As String)
        Dim zClient As rowTblClients = TblClients.LoadByPrimaryKey(pFilePrefix)

        Dim zAccountQry As New queryVwReclassificationAccount
        zAccountQry.SelectAll()
        zAccountQry.Where.Add(zAccountQry.colFilePrefix.Equals(pFilePrefix))

        Dim zAccountList As List(Of rowVwReclassificationAccount) = VwReclassificationAccount.LoadData(zAccountQry.QueryText)
        If zAccountList.Count > 0 Then
            Dim zAccount As rowVwReclassificationAccount = zAccountList(0)
            Dim zTemplate As rowTblEmailTemplate = UtilEmailTemplate.GetReclassification2ndRequestTemplate(zAccount.colASIContactName, zAccount.colClientname, zAccount.colServiceLeaderName, GetUserReclassificationPageURL(zClient))
            UtilNotification.SubmitNotification(zAccount.colConnectemail, zAccount.colServiceLeaderEmailAddress, CCUsers, zTemplate.colFldSubject, zTemplate.colFldBody, "Reclassification Follow-Up Request")
        End If
    End Sub

    Public Sub UpdateClientSentDate(pFilPrefix As String, pDate As Date)

        Dim zClient As rowTblClients = TblClients.LoadByPrimaryKey(pFilPrefix)
        zClient.colReclassificationEmailSentDate = pDate
        TblClients.Save(zClient)

    End Sub

    Public Sub UpdateClientFollowUpDate(pFilPrefix As String, pDate As Date)

        Dim zClient As rowTblClients = TblClients.LoadByPrimaryKey(pFilPrefix)
        zClient.colReclassificationEmailFollowUpDate = pDate
        TblClients.Save(zClient)

    End Sub

    Public Function CCUsers() As String
        Dim zSB As New StringBuilder
        zSB.Append(UtilSetting.GetValue(UtilSetting.Keys.UserReclassificationBCCAddresses))

        If Not IsNothing(Job) Then
            If Not String.IsNullOrEmpty(Job.colFldAlwaysCcRecipients) Then zSB.Append(",") : zSB.Append(Job.colFldAlwaysCcRecipients)
            If Not String.IsNullOrEmpty(Job.colFldAlwaysBccRecipients) Then zSB.Append(",") : zSB.AppendLine(Job.colFldAlwaysBccRecipients)
        End If

        Dim zList As List(Of String) = Split(zSB.ToString, ",").ToList
        Dim zValidEmails As New List(Of String)
        For Each zEmail As String In zList
            Try
                Dim z As New System.Net.Mail.MailAddress(zEmail)
                zValidEmails.Add(z.Address)
            Catch ex As Exception
            End Try
        Next

        If zValidEmails.Count > 0 Then
            Return Join(zValidEmails.ToArray, ",")
        Else
            Return ""
        End If

    End Function

    Public Sub AutoDeleteUsers(pProcessDate As Date)
        Dim zDate As Date = pProcessDate
        If IsNothing(zDate) Then zDate = Today.Date

        Dim zDeletedUsers As List(Of rowVwReclassificationDeletedUser) = VwReclassificationDeletedUser.LoadData
        For Each zUser As rowVwReclassificationDeletedUser In zDeletedUsers
            If zUser.colMarkedForDeletion And zDate >= New Date(zUser.colDeleteOnDate.Value.Year, zUser.colDeleteOnDate.Value.Month, zUser.colDeleteOnDate.Value.Day) Then
                Try
                    TblEzyUsers.Delete(zUser.colEzyUserID)
                    If zUser.colDeleteLogin Then
                        TblEzyLogin.Delete(zUser.colLoginId)
                    End If
                Catch ex As Exception
                    Dim zEx1 As New Exception("Reclassification process cannot auto delete user.", ex)
                    ex.Data.Add("EzyUserId", zUser.colEzyUserID)
                    ex.Data.Add("LoginId", zUser.colLoginId)
                    ex.Data.Add("Name", zUser.colFullName)
                    ex.Data.Add("Delete Login", zUser.colDeleteLogin.ToString)
                    Throw zEx1
                End Try
            End If
        Next
    End Sub

    Public Sub Setup(pFilePrefix As String)

        Dim zClients As List(Of rowTblClients) = TblClients.LoadByIDX_PK_clients(pFilePrefix)
        Dim zClient As rowTblClients
        If zClients.Count > 0 Then
            zClient = zClients(0)
            zClient.colLastReclassificationCompletionDate = zClient.colReclassificationCompletionDate
            zClient.colReclassificationCompletionDate = Nothing
            zClient.colReclassificationEmailFollowUpDate = Nothing
            zClient.colReclassificationEmailSentDate = Nothing
            zClient.colReclassificationLinkGUID = Guid.NewGuid.ToString("N")

            Dim zUsers As List(Of rowVwClientUsers) = GetClientUsers(pFilePrefix)
            For Each zUser As rowVwClientUsers In zUsers
                Dim zEzyUser As rowTblEzyUsers = TblEzyUsers.LoadByIDX_pk_EzyUserId(zUser.colEzyUserId)(0)
                zEzyUser.colLastReclassificationAction = zEzyUser.colReclassificationAction
                zEzyUser.colLastReclassificationByLoginID = zEzyUser.colReclassificationByLoginID
                zEzyUser.colLastReclassificationDate = zEzyUser.colReclassificationDate
                zEzyUser.colReclassificationAction = Action.None
                zEzyUser.colReclassificationByLoginID = Nothing
                zEzyUser.colReclassificationDate = Nothing
                zEzyUser.colMarkedForDeletionDate = Nothing
                TblEzyUsers.Save(zEzyUser)

                Dim zLogin As rowTblEzyLogin = TblEzyLogin.LoadByPrimaryKey(zEzyUser.colLoginId)
                If Not IsNothing(zLogin.colLoginID) Then
                    zLogin.colMarkForDeletionDate = Nothing
                    TblEzyLogin.Save(zLogin)
                End If
            Next

            TblClients.Save(zClient)

        End If
    End Sub

    Public Shared Sub MarkAsCompleted(pFilePrefix As String)
        Dim zClients As List(Of rowTblClients) = TblClients.LoadByIDX_PK_clients(pFilePrefix)
        Dim zClient As rowTblClients
        If zClients.Count > 0 Then
            zClient = zClients(0)
            zClient.colReclassificationLinkGUID = Nothing
            zClient.colReclassificationCompletionDate = DateTime.Now
            TblClients.Save(zClient)
        End If
    End Sub

    Public Shared Function GetClientUsers(pFilePrefix As String) As List(Of rowVwClientUsers)
        Dim zQry As New queryVwClientUsers
        zQry.SelectAll()
        zQry.Where.Add(zQry.colFilePrefix.Equals(CShort(pFilePrefix)))
        Return VwClientUsers.LoadData(zQry.QueryText)
    End Function

    ''' <summary>
    ''' Checks to see if the Reclassification link the user used is a valid link
    ''' </summary>
    ''' <param name="pReclassLinkGuid"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function IsLinkValid(pReclassLinkGuid As String) As Boolean

        Dim zQry As New queryTblClients
        zQry.SelectAll()
        zQry.Where.Add(zQry.colReclassificationLinkGUID.Equals(pReclassLinkGuid))

        Dim zClient As List(Of rowTblClients) = TblClients.LoadData(zQry.QueryText)
        If zClient.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Shared Function IsAuthorizedUser(pReclassLinkGuid As String, pLoginId As Integer) As Boolean

        Dim zQry As New queryTblClients
        zQry.SelectAll()
        zQry.Where.Add(zQry.colReclassificationLinkGUID.Equals(pReclassLinkGuid))
        Dim zClient As rowTblClients = TblClients.LoadData(zQry.QueryText)(0)

        Dim zClientReclassAcctQry As New queryVwReclassificationAccount
        zClientReclassAcctQry.SelectAll()
        zClientReclassAcctQry.Where.Add(zClientReclassAcctQry.colFileprefix.Equals(zClient.colFileprefix))

        Dim zClientReclassAcct As rowVwReclassificationAccount = VwReclassificationAccount.LoadData(zClientReclassAcctQry.QueryText)(0)

        If (zClientReclassAcct.colLoginID = pLoginId) OrElse CBool(UtilGSafe.GetValue(UtilGSafe.GetGUIDFromQueryString, UtilGSafe.KeyName.AllowReclassLoginOverride)) Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Shared Function IsComplete(pFilePrefix As String) As Boolean

        Dim zQry As New queryVwClientUsers
        zQry.SelectAll()
        zQry.Where.Add(zQry.colFilePrefix.Equals(CShort(pFilePrefix)))
        zQry.Where.Add(zQry.colActionId.Equals(0))  'CHECKING WHERE THERE ARE STILL USERS WHO NEED A ACTION

        Dim zList As List(Of rowVwClientUsers) = VwClientUsers.LoadData(zQry.QueryText)

        Return Not CBool(zList.Count)  'IF THE LIST HAS USERS, THEN REVERSE THE BOOLEAN TO RETURN A FALSE VALUE.

    End Function

    Public Shared Function GetUserReclassificationPageURL(pClient As rowTblClients) As String
        Dim zResetURL As String = UtilSetting.GetUserReclassificationUrl
        Return Replace(zResetURL, "{{ReclassificationLinkGUID}}", pClient.colReclassificationLinkGUID)
    End Function

    ''' <summary>
    ''' Send confirmation by using the GSafe values of the current user using the SafeGUID.
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared Sub SendConfirmationEmail(pSafeGUID As String)
        Dim zUserName As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.userFullName)
        Dim zClientName As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.ClientName)
        Dim zEmail As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.UserEmail)
        SendConfirmationEmail(pSafeGUID, zUserName, zClientName, zEmail)
    End Sub

    Public Shared Sub SendConfirmationEmail(pSafeGUID As String, pUserFullName As String, pClientName As String, pEmailAddress As String)
        Dim zUserGridMetaID As Integer = 193
        Dim zTemplate As rowTblEmailTemplate = UtilEmailTemplate.GetReclassificationConfirmationTemplate(pUserFullName, pClientName)
        Dim zExtract As Byte() = UtilExport.ExportGrid(pSafeGUID, zUserGridMetaID, "", "", "")
        Dim zBCCAddress As String = UtilSetting.GetValue(UtilSetting.Keys.UserReclassificationBCCAddresses)
        UtilNotification.SubmitNotification(pEmailAddress, "", IIf(String.IsNullOrEmpty(zBCCAddress), "", zBCCAddress), zTemplate.colFldSubject, zTemplate.colFldBody, UtilNotification.CreateAttachmentList(zExtract, pClientName & "_GRCConnectUsers.xlsx"), "Reclassification Completed")
    End Sub

#Region "REST DEPENDANT FUNCTIONS"
    ''' <summary>
    ''' Gets the next user in the list of users.  Returns first record by default.
    ''' </summary>
    ''' <param name="pCurrentEzyUserGuid"></param>
    ''' <param name="pFilePrefix"></param>
    ''' <param name="pNavAction"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetUser(pFilePrefix As String, pCurrentEzyUserGuid As String, Optional pNavAction As Navigation = Navigation.First) As List(Of rowVwClientUsers)
        Dim zReturn As New List(Of rowVwClientUsers)

        Dim zQry As New queryVwClientUsers
        zQry.SelectAll()
        zQry.Where.Add(zQry.colFilePrefix.Equals(Convert.ToInt16(pFilePrefix & "")))
        zQry.OrderBy(zQry.colUserIndex.Ascending)

        Dim zUsers As List(Of rowVwClientUsers) = VwClientUsers.LoadData(zQry.QueryText)

        Dim zCurrentUser As rowVwClientUsers = zUsers.Find(Function(x) x.colEzyGuid = pCurrentEzyUserGuid)
        Dim zCurrentUserIndex As Integer = 1
        If Not IsNothing(zCurrentUser) Then zCurrentUserIndex = zCurrentUser.colUserIndex

        Dim zFirstUserIndex As Integer = 1
        Dim zNextUserIndex As Integer = zCurrentUserIndex + 1
        Dim zPrevUserIndex As Integer = zCurrentUserIndex - 1
        Dim zLastUserIndex As Integer = zUsers.Last.colUserIndex

        Dim zRequestedUser As rowVwClientUsers = Nothing
        If zUsers.Count > 0 Then
            If pNavAction = Navigation.None Then zRequestedUser = zUsers.Find(Function(x) x.colEzyGuid = pCurrentEzyUserGuid)
            If pNavAction = Navigation.First Then zRequestedUser = zUsers.Find(Function(x) x.colUserIndex = zFirstUserIndex)
            If pNavAction = Navigation.Next Then zRequestedUser = zUsers.Find(Function(x) x.colUserIndex = zNextUserIndex)
            If pNavAction = Navigation.Previous Then zRequestedUser = zUsers.Find(Function(x) x.colUserIndex = zPrevUserIndex)
            If pNavAction = Navigation.Last Then zRequestedUser = zUsers.Find(Function(x) x.colUserIndex = zLastUserIndex)
        End If

        If IsNothing(zRequestedUser) Then
            'these actions loop around to either the first or last user depending on whether the user clicks "next" or "previous"
            If pNavAction = Navigation.Previous Then zRequestedUser = zUsers.Last 'if at the first record and user clicks previous, then give last record
            If pNavAction = Navigation.Next Then zRequestedUser = zUsers.First 'if at the last record and user clicks next, then give first record
        End If

        'Set action ID to Zero
        zRequestedUser.colActionId = 0

        zReturn.Add(zRequestedUser)

        Return zReturn

    End Function

    ''' <summary>
    ''' Gets the next user in the list of users.  Returns first record by default.
    ''' </summary>
    ''' <param name="pCurrentEzyUserGuid"></param>
    ''' <param name="pReclassLinkGUID"></param>
    ''' <param name="pNavAction"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetReclassUser(pReclassLinkGUID As String, pCurrentEzyUserGuid As String, Optional pNavAction As Navigation = Navigation.First) As List(Of rowVwClientUsers)
        Dim zReturn As New List(Of rowVwClientUsers)

        Dim zQry As New queryVwClientUsers
        zQry.SelectAll()
        zQry.Where.Add(zQry.colReclassificationLinkGUID.Equals(pReclassLinkGUID))
        zQry.Where.Add(zQry.colReclassificationLinkGUID.NotEqual(""))
        zQry.OrderBy(zQry.colFilePrefix.Ascending)
        zQry.OrderBy(zQry.colUserIndex.Ascending)

        Dim zUsers As List(Of rowVwClientUsers) = VwClientUsers.LoadData(zQry.QueryText)

        Dim zCurrentUser As rowVwClientUsers = zUsers.Find(Function(x) x.colEzyGuid = pCurrentEzyUserGuid)
        Dim zCurrentUserIndex As Integer = 1
        If Not IsNothing(zCurrentUser) Then zCurrentUserIndex = zCurrentUser.colUserIndex

        Dim zFirstUserIndex As Integer = 1
        Dim zNextUserIndex As Integer = zCurrentUserIndex + 1
        Dim zPrevUserIndex As Integer = zCurrentUserIndex - 1
        Dim zLastUserIndex As Integer = zUsers.Last.colUserIndex

        Dim zRequestedUser As rowVwClientUsers = Nothing
        If zUsers.Count > 0 Then
            If pNavAction = Navigation.None Then zRequestedUser = zUsers.Find(Function(x) x.colEzyGuid = pCurrentEzyUserGuid)
            If pNavAction = Navigation.First Then zRequestedUser = zUsers.Find(Function(x) x.colUserIndex = zFirstUserIndex)
            If pNavAction = Navigation.Next Then zRequestedUser = zUsers.Find(Function(x) x.colUserIndex = zNextUserIndex)
            If pNavAction = Navigation.Previous Then zRequestedUser = zUsers.Find(Function(x) x.colUserIndex = zPrevUserIndex)
            If pNavAction = Navigation.Last Then zRequestedUser = zUsers.Find(Function(x) x.colUserIndex = zLastUserIndex)
        End If

        If IsNothing(zRequestedUser) Then
            'these actions loop around to either the first or last user depending on whether the user clicks "next" or "previous"
            If pNavAction = Navigation.Previous Then zRequestedUser = zUsers.Last 'if at the first record and user clicks previous, then give last record
            If pNavAction = Navigation.Next Then zRequestedUser = zUsers.First 'if at the last record and user clicks next, then give first record
        End If

        zReturn.Add(zRequestedUser)

        Return zReturn

    End Function

    ''' <summary>
    ''' Gets the next user in the list of PENDING users.  Returns first record by default.
    ''' </summary>
    ''' <param name="pCurrentEzyGuid"></param>
    ''' <param name="pReclassLinkGUID"></param>
    ''' <param name="pNavAction"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetReclassUserPending(pReclassLinkGUID As String, pCurrentEzyGuid As String, Optional pNavAction As Navigation = Navigation.First, Optional pCurrentIndex As Integer = 1) As List(Of rowVwClientUsersPending)
        Dim zReturn As New List(Of rowVwClientUsersPending)

        Dim zQry As New queryVwClientUsersPending
        zQry.SelectAll()
        zQry.Where.Add(zQry.colReclassificationLinkGUID.Equals(pReclassLinkGUID))
        zQry.Where.Add(zQry.colReclassificationLinkGUID.NotEqual(""))
        zQry.OrderBy(zQry.colFilePrefix.Ascending)
        zQry.OrderBy(zQry.colUserIndex.Ascending)

        Dim zUsers As List(Of rowVwClientUsersPending) = VwClientUsersPending.LoadData(zQry.QueryText)

        Dim zCurrentUser As rowVwClientUsersPending = zUsers.Find(Function(x) x.colEzyGuid = pCurrentEzyGuid)
        Dim zCurrentUserIndex As Integer = pCurrentIndex
        If Not IsNothing(zCurrentUser) Then zCurrentUserIndex = zCurrentUser.colUserIndex

        Dim zFirstUserIndex As Integer = 1
        Dim zNextUserIndex As Integer = zCurrentUserIndex
        Dim zPrevUserIndex As Integer = zCurrentUserIndex - 1
        Dim zLastUserIndex As Integer = zUsers.Last.colUserIndex
        If Not zCurrentUser Is Nothing AndAlso zCurrentUser.colActionId = UtilUserReclassification.Action.None Then
            zNextUserIndex = zCurrentUserIndex + 1
        End If

        Dim zRequestedUser As rowVwClientUsersPending = Nothing
        If zUsers.Count > 0 Then
            If pNavAction = Navigation.First Then zRequestedUser = zUsers.Find(Function(x) x.colUserIndex = zFirstUserIndex)
            If pNavAction = Navigation.Next Then zRequestedUser = zUsers.Find(Function(x) x.colUserIndex = zNextUserIndex)
            If pNavAction = Navigation.Previous Then zRequestedUser = zUsers.Find(Function(x) x.colUserIndex = zPrevUserIndex)
            If pNavAction = Navigation.Last Then zRequestedUser = zUsers.Find(Function(x) x.colUserIndex = zLastUserIndex)
        End If

        If IsNothing(zRequestedUser) Then
            'these actions loop around to either the first or last user depending on whether the user clicks "next" or "previous"
            If pNavAction = Navigation.Previous Then zRequestedUser = zUsers.Last 'if at the first record and user clicks previous, then give last record
            If pNavAction = Navigation.Next Then zRequestedUser = zUsers.First 'if at the last record and user clicks next, then give first record
        End If

        zReturn.Add(zRequestedUser)

        Return zReturn

    End Function


    ''' <summary>
    ''' Certifies the user
    ''' </summary>
    ''' <param name="pRecertifiedByLoginID"></param>
    ''' <param name="pUser"></param>
    ''' <remarks></remarks>
    Public Shared Sub CertifyUser(pRecertifiedByLoginID As Integer, pUser As rowVwClientUsers, pFilePrefix As String)
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
            .colReclassificationAction = pUser.colActionId

            If pUser.colActionId <> Action.None Then
                .colReclassificationByLoginID = pRecertifiedByLoginID
                .colReclassificationDate = Now
            Else
                .colReclassificationByLoginID = Nothing
                .colReclassificationDate = Nothing
            End If

            If pUser.colActionId = Action.Delete Then
                .colMarkedForDeletionDate = DateAdd(DateInterval.Day, 30, CDate(.colReclassificationDate))
                .colActiveUser = False
            Else
                .colMarkedForDeletionDate = Nothing  'WE NEED TO CLEAR OUT THE DELETE DATE IF BY CHANCE THE USER SELECTED THIS ON FIRST TRY.
                If pUser.colActionId = Action.Activate Then .colActiveUser = True
                If pUser.colActionId = Action.Inactivate Then .colActiveUser = False
            End If

            TblEzyUsers.Save(zEzyUser(0))

            .SetLoginActiveFlag(.IsActive)

            If .IsDeleted Then
                .SetLoginMarkForDeletion(.colMarkedForDeletionDate)
            Else
                .ClearLoginMarkForDeletion()
            End If

        End With

    End Sub

#End Region

    Public Property Job As AppJobLib.razor.rowTblJob Implements AppJobLib.IAppJob.Job

End Class
