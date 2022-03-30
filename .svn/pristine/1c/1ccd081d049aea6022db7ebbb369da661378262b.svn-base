'/===============================================================\
'| razor data (experimental) - rev 4.2.881   EXPERIMENTAL        |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'|  Data Types not supported due to type mapping issues: money,  |
'| date, varchar(1), nvarchar(1)                                 |
'\===============================================================/
Imports System.Data.SqlClient

Namespace razor
    Partial Public Class TblEzyUsers

        Public Shared Sub Delete(ByRef pRowData As IrowTblEzyUsers)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblEzyUsers, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblEzyUsers, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblEzyUsers, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colEzyUserID) Then

				If UtilConfiguration.Auditing.AuditIsEnabled Then				
					pRowData.colSysUserModified=UtilConfiguration.Auditing.CurrentUserDelegate.Invoke()
					pRowData.colSysDateModified=Now()
					Save(pRowData,pTransaction,Nothing) 'Save the person who is deleting this record to the AuditUserModifiedColumnName column.
				End If

                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[ezy_Users] " & _
                        "WHERE [EzyUserID] = @colEzyUserID"

                Dim zCmd As New SQLCommand
                zCmd.CommandText = zSQL
                zCmd.Parameters.Add(New SQLParameter("@colEzyUserID", pRowData.colEzyUserID))

                zCmd.Transaction=pTransaction
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)

                pRowData.RaiseDeletedEvent(pDeleteEventUserState)

            End If

        End Sub

        Public Shared Sub Delete(pcolEzyUserID As Integer)
            Delete(pcolEzyUserID, Nothing, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolEzyUserID As Integer, pDeleteEventUserState As Object)
            Delete(pcolEzyUserID, Nothing, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Delete(pcolEzyUserID As Integer, ByRef pTransaction As SqlClient.SqlTransaction)
        Delete(pcolEzyUserID, pTransaction, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolEzyUserID As Integer, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
        Dim zObj As rowTblEzyUsers = LoadByPrimaryKey(pcolEzyUserID, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblEzyUsers)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblEzyUsers, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblEzyUsers, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colEzyUserID) Then

                zSQL = "SELECT COUNT(*) from [dbo].[ezy_Users] WHERE [EzyUserID] = @colEzyUserID"

                Dim zCmdDoesExist As New SQLCommand

                zCmdDoesExist.CommandText = zSQL

                zCmdDoesExist.Parameters.Add(new SQLParameter("@colEzyUserID", pRowData.colEzyUserID))

                'if zExistInDB > 0  then  PK exists in the DB
                zCmdDoesExist.Transaction = pTransaction
                zExistInDB = razor.UtilSQLServer.ExecuteScalar(zCmdDoesExist)
            End If

            If razor.UtilSQLServer.IsKeySet(pRowData.colEzyUserID) And zExistInDB > 0 Then
                zMode = "UPDATE"
				If UtilConfiguration.Auditing.AuditIsEnabled Then				
					pRowData.colSysUserModified=UtilConfiguration.Auditing.CurrentUserDelegate.Invoke()
					pRowData.colSysDateModified=Now()
					End If			
            End If
            If razor.UtilSQLServer.IsKeySet(pRowData.colEzyUserID) And zExistInDB = 0 Then
                zMode = "INSERTwithKey"
				If UtilConfiguration.Auditing.AuditIsEnabled Then
					pRowData.colSysUserCreated=UtilConfiguration.Auditing.CurrentUserDelegate.Invoke()
					pRowData.colSysDateCreated=Now()
				End If
            End If
            If Not razor.UtilSQLServer.IsKeySet(pRowData.colEzyUserID) Then
                zMode = "INSERTnoKey"
				If UtilConfiguration.Auditing.AuditIsEnabled Then
					pRowData.colSysUserCreated=UtilConfiguration.Auditing.CurrentUserDelegate.Invoke()
					pRowData.colSysDateCreated=Now()
				End If
            End If

            Select Case zMode
                Case "UPDATE"
                    If pRowData.IsDirty Then
                        Dim zUpdate As String = ""
                        Dim zSet As String = ""
                        Dim zWhere As String = ""
                        zUpdate = "UPDATE [dbo].[ezy_Users] SET " 
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colUserID) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [UserID] = @colUserID "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colPassword) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [Password] = @colPassword "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colFullName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [FullName] = @colFullName "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colRiskManager) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [RiskManager] = @colRiskManager "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colDivisionManager) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [DivisionManager] = @colDivisionManager "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colDivision) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [Division] = @colDivision "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colPlantManager) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [PlantManager] = @colPlantManager "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colPlant) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [Plant] = @colPlant "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colAdministrator) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [Administrator] = @colAdministrator "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colDocumentAccess) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [DocumentAccess] = @colDocumentAccess "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colCustomAccess) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [CustomAccess] = @colCustomAccess "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colCustomAccessText) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [CustomAccessText] = @colCustomAccessText "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colOperatorStamp) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [OperatorStamp] = @colOperatorStamp "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colDateTimeStamp) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [DateTimeStamp] = @colDateTimeStamp "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colPhone) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [Phone] = @colPhone "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colFax) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [Fax] = @colFax "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colEmail) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [Email] = @colEmail "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colNotificationStamp) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [NotificationStamp] = @colNotificationStamp "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colActiveUser) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ActiveUser] = @colActiveUser "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colFilePrefix) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [FilePrefix] = @colFilePrefix "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colLastLogin) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [LastLogin] = @colLastLogin "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colLastPWChange) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [LastPWChange] = @colLastPWChange "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colInternal) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [Internal] = @colInternal "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colComments) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [comments] = @colComments "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colRInit) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [RInit] = @colRInit "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colRfu1) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [RFU1] = @colRfu1 "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colRfu2) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [RFU2] = @colRfu2 "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colRfu3) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [RFU3] = @colRfu3 "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colRReport) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [RReport] = @colRReport "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colROverdue1) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ROverdue1] = @colROverdue1 "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colROverdue2) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ROverdue2] = @colROverdue2 "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colROverdue3) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ROverdue3] = @colROverdue3 "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colRActResp) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [RActResp] = @colRActResp "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colWo) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [WO] = @colWo "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colCalist) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [calist] = @colCalist "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colDivlist) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [divlist] = @colDivlist "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colLoclist) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [loclist] = @colLoclist "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colThirdParty) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ThirdParty] = @colThirdParty "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colGRCAdministrator) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [GRCAdministrator] = @colGRCAdministrator "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colLastRecentUpdate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [LastRecentUpdate] = @colLastRecentUpdate "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colAllowMaintLogin) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [AllowMaintLogin] = @colAllowMaintLogin "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colCCActive) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [CCActive] = @colCCActive "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colExpOverdue) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ExpOverdue] = @colExpOverdue "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colEzyGuid) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [EzyGuid] = @colEzyGuid "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colSecurityPasswordIsExpired) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [SecurityPasswordIsExpired] = @colSecurityPasswordIsExpired "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colSecurityAccountIsLockedOut) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [SecurityAccountIsLockedOut] = @colSecurityAccountIsLockedOut "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colAutoInactiveDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [AutoInactiveDate] = @colAutoInactiveDate "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colSecurityInactivityReminderSentDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [SecurityInactivityReminderSentDate] = @colSecurityInactivityReminderSentDate "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colMultipleUserType) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [MultipleUserType] = @colMultipleUserType "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colImport) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [Import] = @colImport "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colClientLocNoManager) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ClientLocNoManager] = @colClientLocNoManager "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colClientLocNoText) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ClientLocNoText] = @colClientLocNoText "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colFacilityManager) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [FacilityManager] = @colFacilityManager "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colFacilityText) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [FacilityText] = @colFacilityText "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colCityManager) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [CityManager] = @colCityManager "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colCityText) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [CityText] = @colCityText "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colStProvManager) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [StProvManager] = @colStProvManager "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colStProvText) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [StProvText] = @colStProvText "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colCountryManager) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [CountryManager] = @colCountryManager "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colCountryText) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [CountryText] = @colCountryText "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colRExpd) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [RExpd] = @colRExpd "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colCCOnly) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [CCOnly] = @colCCOnly "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colLoginId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [LoginId] = @colLoginId "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colLastReclassificationDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [LastReclassificationDate] = @colLastReclassificationDate "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colLastReclassificationByLoginID) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [LastReclassificationByLoginID] = @colLastReclassificationByLoginID "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colLastReclassificationAction) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [LastReclassificationAction] = @colLastReclassificationAction "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colMarkedForDeletionDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [MarkedForDeletionDate] = @colMarkedForDeletionDate "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colReclassificationDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ReclassificationDate] = @colReclassificationDate "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colReclassificationByLoginID) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ReclassificationByLoginID] = @colReclassificationByLoginID "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colReclassificationAction) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ReclassificationAction] = @colReclassificationAction "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colClientComment) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ClientComment] = @colClientComment "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colSysUserCreated) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [SysUserCreated] = @colSysUserCreated "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colSysDateCreated) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [SysDateCreated] = @colSysDateCreated "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colSysUserModified) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [SysUserModified] = @colSysUserModified "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colSysDateModified) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [SysDateModified] = @colSysDateModified "
                        End If
                        If pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colClientAdministration) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ClientAdministration] = @colClientAdministration "
                        End If
                        zWhere = " WHERE [EzyUserID] = @colEzyUserID"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[ezy_Users] ([UserID], [Password], [FullName], [RiskManager], [DivisionManager], [Division], [PlantManager], [Plant], [Administrator], [DocumentAccess], [CustomAccess], [CustomAccessText], [OperatorStamp], [DateTimeStamp], [Phone], [Fax], [Email], [NotificationStamp], [ActiveUser], [FilePrefix], [LastLogin], [LastPWChange], [Internal], [comments], [RInit], [RFU1], [RFU2], [RFU3], [RReport], [ROverdue1], [ROverdue2], [ROverdue3], [RActResp], [WO], [calist], [divlist], [loclist], [ThirdParty], [GRCAdministrator], [LastRecentUpdate], [AllowMaintLogin], [CCActive], [ExpOverdue], [EzyGuid], [SecurityPasswordIsExpired], [SecurityAccountIsLockedOut], [AutoInactiveDate], [SecurityInactivityReminderSentDate], [MultipleUserType], [Import], [ClientLocNoManager], [ClientLocNoText], [FacilityManager], [FacilityText], [CityManager], [CityText], [StProvManager], [StProvText], [CountryManager], [CountryText], [RExpd], [CCOnly], [LoginId], [LastReclassificationDate], [LastReclassificationByLoginID], [LastReclassificationAction], [MarkedForDeletionDate], [ReclassificationDate], [ReclassificationByLoginID], [ReclassificationAction], [ClientComment], [SysUserCreated], [SysDateCreated], [SysUserModified], [SysDateModified], [ClientAdministration])" & _
                            " VALUES (@colUserID, @colPassword, @colFullName, @colRiskManager, @colDivisionManager, @colDivision, @colPlantManager, @colPlant, @colAdministrator, @colDocumentAccess, @colCustomAccess, @colCustomAccessText, @colOperatorStamp, @colDateTimeStamp, @colPhone, @colFax, @colEmail, @colNotificationStamp, @colActiveUser, @colFilePrefix, @colLastLogin, @colLastPWChange, @colInternal, @colComments, @colRInit, @colRfu1, @colRfu2, @colRfu3, @colRReport, @colROverdue1, @colROverdue2, @colROverdue3, @colRActResp, @colWo, @colCalist, @colDivlist, @colLoclist, @colThirdParty, @colGRCAdministrator, @colLastRecentUpdate, @colAllowMaintLogin, @colCCActive, @colExpOverdue, @colEzyGuid, @colSecurityPasswordIsExpired, @colSecurityAccountIsLockedOut, @colAutoInactiveDate, @colSecurityInactivityReminderSentDate, @colMultipleUserType, @colImport, @colClientLocNoManager, @colClientLocNoText, @colFacilityManager, @colFacilityText, @colCityManager, @colCityText, @colStProvManager, @colStProvText, @colCountryManager, @colCountryText, @colRExpd, @colCCOnly, @colLoginId, @colLastReclassificationDate, @colLastReclassificationByLoginID, @colLastReclassificationAction, @colMarkedForDeletionDate, @colReclassificationDate, @colReclassificationByLoginID, @colReclassificationAction, @colClientComment, @colSysUserCreated, @colSysDateCreated, @colSysUserModified, @colSysDateModified, @colClientAdministration); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[ezy_Users] ([UserID], [Password], [FullName], [RiskManager], [DivisionManager], [Division], [PlantManager], [Plant], [Administrator], [DocumentAccess], [CustomAccess], [CustomAccessText], [OperatorStamp], [DateTimeStamp], [Phone], [Fax], [Email], [NotificationStamp], [ActiveUser], [FilePrefix], [LastLogin], [LastPWChange], [Internal], [comments], [RInit], [RFU1], [RFU2], [RFU3], [RReport], [ROverdue1], [ROverdue2], [ROverdue3], [RActResp], [WO], [calist], [divlist], [loclist], [ThirdParty], [GRCAdministrator], [LastRecentUpdate], [AllowMaintLogin], [CCActive], [ExpOverdue], [EzyGuid], [SecurityPasswordIsExpired], [SecurityAccountIsLockedOut], [AutoInactiveDate], [SecurityInactivityReminderSentDate], [MultipleUserType], [Import], [ClientLocNoManager], [ClientLocNoText], [FacilityManager], [FacilityText], [CityManager], [CityText], [StProvManager], [StProvText], [CountryManager], [CountryText], [RExpd], [CCOnly], [LoginId], [LastReclassificationDate], [LastReclassificationByLoginID], [LastReclassificationAction], [MarkedForDeletionDate], [ReclassificationDate], [ReclassificationByLoginID], [ReclassificationAction], [ClientComment], [SysUserCreated], [SysDateCreated], [SysUserModified], [SysDateModified], [ClientAdministration])" & _
                            " VALUES (@colUserID, @colPassword, @colFullName, @colRiskManager, @colDivisionManager, @colDivision, @colPlantManager, @colPlant, @colAdministrator, @colDocumentAccess, @colCustomAccess, @colCustomAccessText, @colOperatorStamp, @colDateTimeStamp, @colPhone, @colFax, @colEmail, @colNotificationStamp, @colActiveUser, @colFilePrefix, @colLastLogin, @colLastPWChange, @colInternal, @colComments, @colRInit, @colRfu1, @colRfu2, @colRfu3, @colRReport, @colROverdue1, @colROverdue2, @colROverdue3, @colRActResp, @colWo, @colCalist, @colDivlist, @colLoclist, @colThirdParty, @colGRCAdministrator, @colLastRecentUpdate, @colAllowMaintLogin, @colCCActive, @colExpOverdue, @colEzyGuid, @colSecurityPasswordIsExpired, @colSecurityAccountIsLockedOut, @colAutoInactiveDate, @colSecurityInactivityReminderSentDate, @colMultipleUserType, @colImport, @colClientLocNoManager, @colClientLocNoText, @colFacilityManager, @colFacilityText, @colCityManager, @colCityText, @colStProvManager, @colStProvText, @colCountryManager, @colCountryText, @colRExpd, @colCCOnly, @colLoginId, @colLastReclassificationDate, @colLastReclassificationByLoginID, @colLastReclassificationAction, @colMarkedForDeletionDate, @colReclassificationDate, @colReclassificationByLoginID, @colReclassificationAction, @colClientComment, @colSysUserCreated, @colSysDateCreated, @colSysUserModified, @colSysDateModified, @colClientAdministration); SELECT SCOPE_IDENTITY()"
                Case Else
            End Select

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

			'IF UPDATE, SET PK PARAMETER
            If zMode = "UPDATE" Then
                zCmd.Parameters.Add(New SQLParameter("@colEzyUserID", pRowData.colEzyUserID))
            End If

			'IF INSERTING, KEY HAS VALUE AND KEY IS NOT IDENTITY, SET PK PARAMETER
			If zMode = "INSERTwithKey" Then
            End If

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colUserID) Then
                    zCmd.Parameters.Add(New SqlParameter("@colUserID", IIf(pRowData.colUserID Is Nothing, DBNull.Value, pRowData.colUserID)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colPassword) Then
                    zCmd.Parameters.Add(New SqlParameter("@colPassword", IIf(pRowData.colPassword Is Nothing, DBNull.Value, pRowData.colPassword)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colFullName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFullName", IIf(pRowData.colFullName Is Nothing, DBNull.Value, pRowData.colFullName)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colRiskManager) Then
                    zCmd.Parameters.Add(New SqlParameter("@colRiskManager", IIf(pRowData.colRiskManager Is Nothing, DBNull.Value, pRowData.colRiskManager)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colDivisionManager) Then
                    zCmd.Parameters.Add(New SqlParameter("@colDivisionManager", IIf(pRowData.colDivisionManager Is Nothing, DBNull.Value, pRowData.colDivisionManager)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colDivision) Then
                    zCmd.Parameters.Add(New SqlParameter("@colDivision", IIf(pRowData.colDivision Is Nothing, DBNull.Value, pRowData.colDivision)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colPlantManager) Then
                    zCmd.Parameters.Add(New SqlParameter("@colPlantManager", IIf(pRowData.colPlantManager Is Nothing, DBNull.Value, pRowData.colPlantManager)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colPlant) Then
                    zCmd.Parameters.Add(New SqlParameter("@colPlant", IIf(pRowData.colPlant Is Nothing, DBNull.Value, pRowData.colPlant)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colAdministrator) Then
                    zCmd.Parameters.Add(New SqlParameter("@colAdministrator", IIf(pRowData.colAdministrator Is Nothing, DBNull.Value, pRowData.colAdministrator)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colDocumentAccess) Then
                    zCmd.Parameters.Add(New SqlParameter("@colDocumentAccess", IIf(pRowData.colDocumentAccess Is Nothing, DBNull.Value, pRowData.colDocumentAccess)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colCustomAccess) Then
                    zCmd.Parameters.Add(New SqlParameter("@colCustomAccess", IIf(pRowData.colCustomAccess Is Nothing, DBNull.Value, pRowData.colCustomAccess)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colCustomAccessText) Then
                    zCmd.Parameters.Add(New SqlParameter("@colCustomAccessText", IIf(pRowData.colCustomAccessText Is Nothing, DBNull.Value, pRowData.colCustomAccessText)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colOperatorStamp) Then
                    zCmd.Parameters.Add(New SqlParameter("@colOperatorStamp", IIf(pRowData.colOperatorStamp Is Nothing, DBNull.Value, pRowData.colOperatorStamp)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colDateTimeStamp) Then
                    zCmd.Parameters.Add(New SqlParameter("@colDateTimeStamp", IIf(pRowData.colDateTimeStamp Is Nothing, DBNull.Value, pRowData.colDateTimeStamp)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colPhone) Then
                    zCmd.Parameters.Add(New SqlParameter("@colPhone", IIf(pRowData.colPhone Is Nothing, DBNull.Value, pRowData.colPhone)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colFax) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFax", IIf(pRowData.colFax Is Nothing, DBNull.Value, pRowData.colFax)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colEmail) Then
                    zCmd.Parameters.Add(New SqlParameter("@colEmail", IIf(pRowData.colEmail Is Nothing, DBNull.Value, pRowData.colEmail)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colNotificationStamp) Then
                    zCmd.Parameters.Add(New SqlParameter("@colNotificationStamp", IIf(pRowData.colNotificationStamp Is Nothing, DBNull.Value, pRowData.colNotificationStamp)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colActiveUser) Then
                    zCmd.Parameters.Add(New SqlParameter("@colActiveUser", IIf(pRowData.colActiveUser Is Nothing, DBNull.Value, pRowData.colActiveUser)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colFilePrefix) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFilePrefix", IIf(pRowData.colFilePrefix Is Nothing, DBNull.Value, pRowData.colFilePrefix)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colLastLogin) Then
                    zCmd.Parameters.Add(New SqlParameter("@colLastLogin", IIf(pRowData.colLastLogin Is Nothing, DBNull.Value, pRowData.colLastLogin)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colLastPWChange) Then
                    zCmd.Parameters.Add(New SqlParameter("@colLastPWChange", IIf(pRowData.colLastPWChange Is Nothing, DBNull.Value, pRowData.colLastPWChange)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colInternal) Then
                    zCmd.Parameters.Add(New SqlParameter("@colInternal", IIf(pRowData.colInternal Is Nothing, DBNull.Value, pRowData.colInternal)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colComments) Then
                    zCmd.Parameters.Add(New SqlParameter("@colComments", IIf(pRowData.colComments Is Nothing, DBNull.Value, pRowData.colComments)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colRInit) Then
                    zCmd.Parameters.Add(New SqlParameter("@colRInit", IIf(pRowData.colRInit Is Nothing, DBNull.Value, pRowData.colRInit)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colRfu1) Then
                    zCmd.Parameters.Add(New SqlParameter("@colRfu1", IIf(pRowData.colRfu1 Is Nothing, DBNull.Value, pRowData.colRfu1)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colRfu2) Then
                    zCmd.Parameters.Add(New SqlParameter("@colRfu2", IIf(pRowData.colRfu2 Is Nothing, DBNull.Value, pRowData.colRfu2)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colRfu3) Then
                    zCmd.Parameters.Add(New SqlParameter("@colRfu3", IIf(pRowData.colRfu3 Is Nothing, DBNull.Value, pRowData.colRfu3)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colRReport) Then
                    zCmd.Parameters.Add(New SqlParameter("@colRReport", IIf(pRowData.colRReport Is Nothing, DBNull.Value, pRowData.colRReport)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colROverdue1) Then
                    zCmd.Parameters.Add(New SqlParameter("@colROverdue1", IIf(pRowData.colROverdue1 Is Nothing, DBNull.Value, pRowData.colROverdue1)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colROverdue2) Then
                    zCmd.Parameters.Add(New SqlParameter("@colROverdue2", IIf(pRowData.colROverdue2 Is Nothing, DBNull.Value, pRowData.colROverdue2)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colROverdue3) Then
                    zCmd.Parameters.Add(New SqlParameter("@colROverdue3", IIf(pRowData.colROverdue3 Is Nothing, DBNull.Value, pRowData.colROverdue3)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colRActResp) Then
                    zCmd.Parameters.Add(New SqlParameter("@colRActResp", IIf(pRowData.colRActResp Is Nothing, DBNull.Value, pRowData.colRActResp)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colWo) Then
                    zCmd.Parameters.Add(New SqlParameter("@colWo", IIf(pRowData.colWo Is Nothing, DBNull.Value, pRowData.colWo)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colCalist) Then
                    zCmd.Parameters.Add(New SqlParameter("@colCalist", IIf(pRowData.colCalist Is Nothing, DBNull.Value, pRowData.colCalist)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colDivlist) Then
                    zCmd.Parameters.Add(New SqlParameter("@colDivlist", IIf(pRowData.colDivlist Is Nothing, DBNull.Value, pRowData.colDivlist)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colLoclist) Then
                    zCmd.Parameters.Add(New SqlParameter("@colLoclist", IIf(pRowData.colLoclist Is Nothing, DBNull.Value, pRowData.colLoclist)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colThirdParty) Then
                    zCmd.Parameters.Add(New SqlParameter("@colThirdParty", IIf(pRowData.colThirdParty Is Nothing, DBNull.Value, pRowData.colThirdParty)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colGRCAdministrator) Then
                    zCmd.Parameters.Add(New SqlParameter("@colGRCAdministrator", IIf(pRowData.colGRCAdministrator Is Nothing, DBNull.Value, pRowData.colGRCAdministrator)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colLastRecentUpdate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colLastRecentUpdate", IIf(pRowData.colLastRecentUpdate Is Nothing, DBNull.Value, pRowData.colLastRecentUpdate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colAllowMaintLogin) Then
                    zCmd.Parameters.Add(New SqlParameter("@colAllowMaintLogin", IIf(pRowData.colAllowMaintLogin Is Nothing, DBNull.Value, pRowData.colAllowMaintLogin)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colCCActive) Then
                    zCmd.Parameters.Add(New SqlParameter("@colCCActive", IIf(pRowData.colCCActive Is Nothing, DBNull.Value, pRowData.colCCActive)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colExpOverdue) Then
                    zCmd.Parameters.Add(New SqlParameter("@colExpOverdue", IIf(pRowData.colExpOverdue Is Nothing, DBNull.Value, pRowData.colExpOverdue)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colEzyGuid) Then
                    zCmd.Parameters.Add(New SqlParameter("@colEzyGuid", IIf(pRowData.colEzyGuid Is Nothing, DBNull.Value, pRowData.colEzyGuid)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colSecurityPasswordIsExpired) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSecurityPasswordIsExpired", IIf(pRowData.colSecurityPasswordIsExpired Is Nothing, DBNull.Value, pRowData.colSecurityPasswordIsExpired)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colSecurityAccountIsLockedOut) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSecurityAccountIsLockedOut", IIf(pRowData.colSecurityAccountIsLockedOut Is Nothing, DBNull.Value, pRowData.colSecurityAccountIsLockedOut)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colAutoInactiveDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colAutoInactiveDate", IIf(pRowData.colAutoInactiveDate Is Nothing, DBNull.Value, pRowData.colAutoInactiveDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colSecurityInactivityReminderSentDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSecurityInactivityReminderSentDate", IIf(pRowData.colSecurityInactivityReminderSentDate Is Nothing, DBNull.Value, pRowData.colSecurityInactivityReminderSentDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colMultipleUserType) Then
                    zCmd.Parameters.Add(New SqlParameter("@colMultipleUserType", IIf(pRowData.colMultipleUserType Is Nothing, DBNull.Value, pRowData.colMultipleUserType)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colImport) Then
                    zCmd.Parameters.Add(New SqlParameter("@colImport", IIf(pRowData.colImport Is Nothing, DBNull.Value, pRowData.colImport)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colClientLocNoManager) Then
                    zCmd.Parameters.Add(New SqlParameter("@colClientLocNoManager", IIf(pRowData.colClientLocNoManager Is Nothing, DBNull.Value, pRowData.colClientLocNoManager)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colClientLocNoText) Then
                    zCmd.Parameters.Add(New SqlParameter("@colClientLocNoText", IIf(pRowData.colClientLocNoText Is Nothing, DBNull.Value, pRowData.colClientLocNoText)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colFacilityManager) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFacilityManager", IIf(pRowData.colFacilityManager Is Nothing, DBNull.Value, pRowData.colFacilityManager)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colFacilityText) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFacilityText", IIf(pRowData.colFacilityText Is Nothing, DBNull.Value, pRowData.colFacilityText)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colCityManager) Then
                    zCmd.Parameters.Add(New SqlParameter("@colCityManager", IIf(pRowData.colCityManager Is Nothing, DBNull.Value, pRowData.colCityManager)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colCityText) Then
                    zCmd.Parameters.Add(New SqlParameter("@colCityText", IIf(pRowData.colCityText Is Nothing, DBNull.Value, pRowData.colCityText)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colStProvManager) Then
                    zCmd.Parameters.Add(New SqlParameter("@colStProvManager", IIf(pRowData.colStProvManager Is Nothing, DBNull.Value, pRowData.colStProvManager)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colStProvText) Then
                    zCmd.Parameters.Add(New SqlParameter("@colStProvText", IIf(pRowData.colStProvText Is Nothing, DBNull.Value, pRowData.colStProvText)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colCountryManager) Then
                    zCmd.Parameters.Add(New SqlParameter("@colCountryManager", IIf(pRowData.colCountryManager Is Nothing, DBNull.Value, pRowData.colCountryManager)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colCountryText) Then
                    zCmd.Parameters.Add(New SqlParameter("@colCountryText", IIf(pRowData.colCountryText Is Nothing, DBNull.Value, pRowData.colCountryText)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colRExpd) Then
                    zCmd.Parameters.Add(New SqlParameter("@colRExpd", IIf(pRowData.colRExpd Is Nothing, DBNull.Value, pRowData.colRExpd)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colCCOnly) Then
                    zCmd.Parameters.Add(New SqlParameter("@colCCOnly", IIf(pRowData.colCCOnly Is Nothing, DBNull.Value, pRowData.colCCOnly)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colLoginId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colLoginId", IIf(pRowData.colLoginId Is Nothing, DBNull.Value, pRowData.colLoginId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colLastReclassificationDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colLastReclassificationDate", IIf(pRowData.colLastReclassificationDate Is Nothing, DBNull.Value, pRowData.colLastReclassificationDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colLastReclassificationByLoginID) Then
                    zCmd.Parameters.Add(New SqlParameter("@colLastReclassificationByLoginID", IIf(pRowData.colLastReclassificationByLoginID Is Nothing, DBNull.Value, pRowData.colLastReclassificationByLoginID)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colLastReclassificationAction) Then
                    zCmd.Parameters.Add(New SqlParameter("@colLastReclassificationAction", IIf(pRowData.colLastReclassificationAction Is Nothing, DBNull.Value, pRowData.colLastReclassificationAction)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colMarkedForDeletionDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colMarkedForDeletionDate", IIf(pRowData.colMarkedForDeletionDate Is Nothing, DBNull.Value, pRowData.colMarkedForDeletionDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colReclassificationDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colReclassificationDate", IIf(pRowData.colReclassificationDate Is Nothing, DBNull.Value, pRowData.colReclassificationDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colReclassificationByLoginID) Then
                    zCmd.Parameters.Add(New SqlParameter("@colReclassificationByLoginID", IIf(pRowData.colReclassificationByLoginID Is Nothing, DBNull.Value, pRowData.colReclassificationByLoginID)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colReclassificationAction) Then
                    zCmd.Parameters.Add(New SqlParameter("@colReclassificationAction", IIf(pRowData.colReclassificationAction Is Nothing, DBNull.Value, pRowData.colReclassificationAction)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colClientComment) Then
                    zCmd.Parameters.Add(New SqlParameter("@colClientComment", IIf(pRowData.colClientComment Is Nothing, DBNull.Value, pRowData.colClientComment)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colSysUserCreated) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSysUserCreated", IIf(pRowData.colSysUserCreated Is Nothing, DBNull.Value, pRowData.colSysUserCreated)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colSysDateCreated) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSysDateCreated", IIf(pRowData.colSysDateCreated Is Nothing, DBNull.Value, pRowData.colSysDateCreated)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colSysUserModified) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSysUserModified", IIf(pRowData.colSysUserModified Is Nothing, DBNull.Value, pRowData.colSysUserModified)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colSysDateModified) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSysDateModified", IIf(pRowData.colSysDateModified Is Nothing, DBNull.Value, pRowData.colSysDateModified)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUsers.FieldIndex.colClientAdministration) Then
                    zCmd.Parameters.Add(New SqlParameter("@colClientAdministration", IIf(pRowData.colClientAdministration Is Nothing, DBNull.Value, pRowData.colClientAdministration)))
                End If

            zCmd.Transaction=pTransaction
            If zMode = "INSERTnoKey" Then
                Dim zLastId As Long = 0
                zLastId = razor.UtilSQLServer.ExecuteNonQueryRowId(zCmd)

                pRowData.colEzyUserID = zLastId
            Else
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)
            End If

            pRowData.SetIsDirty(False)
            pRowData.RaiseSavedEvent(pSavedEventUserState)

		End If

        End Sub

        Public Shared Function LoadByPrimaryKey(pcolEzyUserID As Integer) As rowTblEzyUsers
            Return LoadByPrimaryKey(pcolEzyUserID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolEzyUserID As Integer, pLoadEventUserState As Object) As rowTblEzyUsers
            Return LoadByPrimaryKey(pcolEzyUserID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolEzyUserID As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblEzyUsers
            Return LoadByPrimaryKey(pcolEzyUserID, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolEzyUserID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblEzyUsers
            Dim zReturn As New rowTblEzyUsers
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_Users] WHERE [EzyUserID] = @colEzyUserID"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colEzyUserID", pcolEzyUserID))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblEzyUsers) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_IX_EzyGuid(pcolEzyGuid As String) As List(Of rowTblEzyUsers)
            Return LoadByIDX_IX_EzyGuid(pcolEzyGuid, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_EzyGuid(pcolEzyGuid As String, pLoadEventUserState As Object) As List(Of rowTblEzyUsers)
            Return LoadByIDX_IX_EzyGuid(pcolEzyGuid, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_EzyGuid(pcolEzyGuid As String, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblEzyUsers)
            Return LoadByIDX_IX_EzyGuid(pcolEzyGuid, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_EzyGuid(pcolEzyGuid As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblEzyUsers)
            Dim zReturn As New List(Of rowTblEzyUsers)
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_Users] WHERE [EzyGuid] = @colEzyGuid"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colEzyGuid", pcolEzyGuid))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function
        Public Shared Function LoadByIDX_IX_FilePrefix_RFU1(pcolFilePrefix As Short, pcolRfu1 As String) As List(Of rowTblEzyUsers)
            Return LoadByIDX_IX_FilePrefix_RFU1(pcolFilePrefix, pcolRfu1, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_FilePrefix_RFU1(pcolFilePrefix As Short, pcolRfu1 As String, pLoadEventUserState As Object) As List(Of rowTblEzyUsers)
            Return LoadByIDX_IX_FilePrefix_RFU1(pcolFilePrefix, pcolRfu1, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_FilePrefix_RFU1(pcolFilePrefix As Short, pcolRfu1 As String, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblEzyUsers)
            Return LoadByIDX_IX_FilePrefix_RFU1(pcolFilePrefix, pcolRfu1, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_FilePrefix_RFU1(pcolFilePrefix As Short, pcolRfu1 As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblEzyUsers)
            Dim zReturn As New List(Of rowTblEzyUsers)
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_Users] WHERE [FilePrefix] = @colFilePrefix AND [RFU1] = @colRfu1"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFilePrefix", pcolFilePrefix))
            zCmd.Parameters.Add(New SQLParameter("@colRfu1", pcolRfu1))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function
        Public Shared Function LoadByIDX_IX_FilePrefix_RFU2(pcolFilePrefix As Short, pcolRfu2 As String) As List(Of rowTblEzyUsers)
            Return LoadByIDX_IX_FilePrefix_RFU2(pcolFilePrefix, pcolRfu2, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_FilePrefix_RFU2(pcolFilePrefix As Short, pcolRfu2 As String, pLoadEventUserState As Object) As List(Of rowTblEzyUsers)
            Return LoadByIDX_IX_FilePrefix_RFU2(pcolFilePrefix, pcolRfu2, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_FilePrefix_RFU2(pcolFilePrefix As Short, pcolRfu2 As String, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblEzyUsers)
            Return LoadByIDX_IX_FilePrefix_RFU2(pcolFilePrefix, pcolRfu2, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_FilePrefix_RFU2(pcolFilePrefix As Short, pcolRfu2 As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblEzyUsers)
            Dim zReturn As New List(Of rowTblEzyUsers)
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_Users] WHERE [FilePrefix] = @colFilePrefix AND [RFU2] = @colRfu2"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFilePrefix", pcolFilePrefix))
            zCmd.Parameters.Add(New SQLParameter("@colRfu2", pcolRfu2))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function
        Public Shared Function LoadByIDX_IX_FilePrefix_RFU3(pcolFilePrefix As Short, pcolRfu3 As String) As List(Of rowTblEzyUsers)
            Return LoadByIDX_IX_FilePrefix_RFU3(pcolFilePrefix, pcolRfu3, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_FilePrefix_RFU3(pcolFilePrefix As Short, pcolRfu3 As String, pLoadEventUserState As Object) As List(Of rowTblEzyUsers)
            Return LoadByIDX_IX_FilePrefix_RFU3(pcolFilePrefix, pcolRfu3, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_FilePrefix_RFU3(pcolFilePrefix As Short, pcolRfu3 As String, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblEzyUsers)
            Return LoadByIDX_IX_FilePrefix_RFU3(pcolFilePrefix, pcolRfu3, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_FilePrefix_RFU3(pcolFilePrefix As Short, pcolRfu3 As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblEzyUsers)
            Dim zReturn As New List(Of rowTblEzyUsers)
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_Users] WHERE [FilePrefix] = @colFilePrefix AND [RFU3] = @colRfu3"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFilePrefix", pcolFilePrefix))
            zCmd.Parameters.Add(New SQLParameter("@colRfu3", pcolRfu3))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function
        Public Shared Function LoadByIDX_IX_FilePrefix_RReport(pcolFilePrefix As Short, pcolRReport As String) As List(Of rowTblEzyUsers)
            Return LoadByIDX_IX_FilePrefix_RReport(pcolFilePrefix, pcolRReport, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_FilePrefix_RReport(pcolFilePrefix As Short, pcolRReport As String, pLoadEventUserState As Object) As List(Of rowTblEzyUsers)
            Return LoadByIDX_IX_FilePrefix_RReport(pcolFilePrefix, pcolRReport, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_FilePrefix_RReport(pcolFilePrefix As Short, pcolRReport As String, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblEzyUsers)
            Return LoadByIDX_IX_FilePrefix_RReport(pcolFilePrefix, pcolRReport, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_FilePrefix_RReport(pcolFilePrefix As Short, pcolRReport As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblEzyUsers)
            Dim zReturn As New List(Of rowTblEzyUsers)
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_Users] WHERE [FilePrefix] = @colFilePrefix AND [RReport] = @colRReport"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFilePrefix", pcolFilePrefix))
            zCmd.Parameters.Add(New SQLParameter("@colRReport", pcolRReport))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function
        Public Shared Function LoadByIDX_IX_LoginId(pcolLoginId As Integer) As List(Of rowTblEzyUsers)
            Return LoadByIDX_IX_LoginId(pcolLoginId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_LoginId(pcolLoginId As Integer, pLoadEventUserState As Object) As List(Of rowTblEzyUsers)
            Return LoadByIDX_IX_LoginId(pcolLoginId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_LoginId(pcolLoginId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblEzyUsers)
            Return LoadByIDX_IX_LoginId(pcolLoginId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_LoginId(pcolLoginId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblEzyUsers)
            Dim zReturn As New List(Of rowTblEzyUsers)
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_Users] WHERE [LoginId] = @colLoginId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colLoginId", pcolLoginId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function
        Public Shared Function LoadByIDX_pk_EzyUserId(pcolEzyUserID As Integer) As List(Of rowTblEzyUsers)
            Return LoadByIDX_pk_EzyUserId(pcolEzyUserID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_pk_EzyUserId(pcolEzyUserID As Integer, pLoadEventUserState As Object) As List(Of rowTblEzyUsers)
            Return LoadByIDX_pk_EzyUserId(pcolEzyUserID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_pk_EzyUserId(pcolEzyUserID As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblEzyUsers)
            Return LoadByIDX_pk_EzyUserId(pcolEzyUserID, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_pk_EzyUserId(pcolEzyUserID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblEzyUsers)
            Dim zReturn As New List(Of rowTblEzyUsers)
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_Users] WHERE [EzyUserID] = @colEzyUserID"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colEzyUserID", pcolEzyUserID))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblEzyUsers)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblEzyUsers)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblEzyUsers)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblEzyUsers)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblEzyUsers)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand)
            Return LoadData(pCommand, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object)
            Return LoadData(pCommand, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction)
            Return LoadData(pCommand,pTransaction,Nothing)
        End Function

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblEzyUsers)
            Dim zReturn As New List(Of rowTblEzyUsers)
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_Users]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblEzyUsers)

			Try
	            Dim zReturn As New List(Of rowTblEzyUsers)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblEzyUsers

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblEzyUsers		
	                            ReadDataRow(zReader,zObj)											
	                            zObj.RaiseLoadedEvent(pLoadEventUserState)
	                            zReturn.Add(zObj)
	                        End While
	                    End If
	                End Using
	            End Using

	            zReader.Close()
	            zReader = Nothing

	            Return zReturn

			Catch ex As Exception
				ex.Data.Add("SQL", pCommand.CommandText)				
	            For Each pParameter As SqlClient.SqlParameter In pCommand.Parameters
					ex.Data.Add(pParameter.ParameterName, pParameter.Value)
		        Next
				Throw
			End Try

        End function

        Public Shared Function ReadData(Of T)(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of T)

			Try
	            Dim zReturn As New List(Of T)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As Object = Activator.CreateInstance(Of T)()

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj  = Activator.CreateInstance(Of T)()	
	                            ReadDataRow(zReader,zObj)					
	                            zObj.RaiseLoadedEvent(pLoadEventUserState)
	                            zReturn.Add(zObj)
	                        End While			
	                    End If
	                End Using
	            End Using

	            zReader.Close()
	            zReader = Nothing

	            Return zReturn
			Catch ex As Exception
				ex.Data.Add("SQL", pCommand.CommandText)				
	            For Each pParameter As SqlClient.SqlParameter In pCommand.Parameters
					ex.Data.Add(pParameter.ParameterName, pParameter.Value)
		        Next				
				Throw
			End Try

        End function

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblEzyUsers)
			If Not pReader.IsDBNull(pReader.GetOrdinal("UserID")) Then pObject.colUserID = UtilSQLServer.SafeReader.SafeReadString(pReader, "UserID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Password")) Then pObject.colPassword = UtilSQLServer.SafeReader.SafeReadString(pReader, "Password")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FullName")) Then pObject.colFullName = UtilSQLServer.SafeReader.SafeReadString(pReader, "FullName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RiskManager")) Then pObject.colRiskManager = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "RiskManager")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DivisionManager")) Then pObject.colDivisionManager = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "DivisionManager")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Division")) Then pObject.colDivision = UtilSQLServer.SafeReader.SafeReadString(pReader, "Division")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PlantManager")) Then pObject.colPlantManager = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "PlantManager")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Plant")) Then pObject.colPlant = UtilSQLServer.SafeReader.SafeReadString(pReader, "Plant")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Administrator")) Then pObject.colAdministrator = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "Administrator")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DocumentAccess")) Then pObject.colDocumentAccess = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "DocumentAccess")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CustomAccess")) Then pObject.colCustomAccess = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "CustomAccess")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CustomAccessText")) Then pObject.colCustomAccessText = UtilSQLServer.SafeReader.SafeReadString(pReader, "CustomAccessText")
			If Not pReader.IsDBNull(pReader.GetOrdinal("OperatorStamp")) Then pObject.colOperatorStamp = UtilSQLServer.SafeReader.SafeReadString(pReader, "OperatorStamp")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DateTimeStamp")) Then pObject.colDateTimeStamp = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "DateTimeStamp")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Phone")) Then pObject.colPhone = UtilSQLServer.SafeReader.SafeReadString(pReader, "Phone")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Fax")) Then pObject.colFax = UtilSQLServer.SafeReader.SafeReadString(pReader, "Fax")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Email")) Then pObject.colEmail = UtilSQLServer.SafeReader.SafeReadString(pReader, "Email")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NotificationStamp")) Then pObject.colNotificationStamp = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "NotificationStamp")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ActiveUser")) Then pObject.colActiveUser = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "ActiveUser")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FilePrefix")) Then pObject.colFilePrefix = UtilSQLServer.SafeReader.SafeReadInt16(pReader, "FilePrefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LastLogin")) Then pObject.colLastLogin = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "LastLogin")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LastPWChange")) Then pObject.colLastPWChange = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "LastPWChange")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Internal")) Then pObject.colInternal = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "Internal")
			If Not pReader.IsDBNull(pReader.GetOrdinal("comments")) Then pObject.colComments = UtilSQLServer.SafeReader.SafeReadString(pReader, "comments")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RInit")) Then pObject.colRInit = UtilSQLServer.SafeReader.SafeReadString(pReader, "RInit")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RFU1")) Then pObject.colRfu1 = UtilSQLServer.SafeReader.SafeReadString(pReader, "RFU1")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RFU2")) Then pObject.colRfu2 = UtilSQLServer.SafeReader.SafeReadString(pReader, "RFU2")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RFU3")) Then pObject.colRfu3 = UtilSQLServer.SafeReader.SafeReadString(pReader, "RFU3")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RReport")) Then pObject.colRReport = UtilSQLServer.SafeReader.SafeReadString(pReader, "RReport")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ROverdue1")) Then pObject.colROverdue1 = UtilSQLServer.SafeReader.SafeReadString(pReader, "ROverdue1")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ROverdue2")) Then pObject.colROverdue2 = UtilSQLServer.SafeReader.SafeReadString(pReader, "ROverdue2")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ROverdue3")) Then pObject.colROverdue3 = UtilSQLServer.SafeReader.SafeReadString(pReader, "ROverdue3")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RActResp")) Then pObject.colRActResp = UtilSQLServer.SafeReader.SafeReadString(pReader, "RActResp")
			If Not pReader.IsDBNull(pReader.GetOrdinal("WO")) Then pObject.colWo = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "WO")
			If Not pReader.IsDBNull(pReader.GetOrdinal("calist")) Then pObject.colCalist = UtilSQLServer.SafeReader.SafeReadString(pReader, "calist")
			If Not pReader.IsDBNull(pReader.GetOrdinal("divlist")) Then pObject.colDivlist = UtilSQLServer.SafeReader.SafeReadString(pReader, "divlist")
			If Not pReader.IsDBNull(pReader.GetOrdinal("loclist")) Then pObject.colLoclist = UtilSQLServer.SafeReader.SafeReadString(pReader, "loclist")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ThirdParty")) Then pObject.colThirdParty = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "ThirdParty")
			If Not pReader.IsDBNull(pReader.GetOrdinal("GRCAdministrator")) Then pObject.colGRCAdministrator = UtilSQLServer.SafeReader.SafeReadString(pReader, "GRCAdministrator")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LastRecentUpdate")) Then pObject.colLastRecentUpdate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "LastRecentUpdate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("EzyUserID")) Then pObject.colEzyUserID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "EzyUserID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("AllowMaintLogin")) Then pObject.colAllowMaintLogin = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "AllowMaintLogin")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CCActive")) Then pObject.colCCActive = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "CCActive")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ExpOverdue")) Then pObject.colExpOverdue = UtilSQLServer.SafeReader.SafeReadString(pReader, "ExpOverdue")
			If Not pReader.IsDBNull(pReader.GetOrdinal("EzyGuid")) Then pObject.colEzyGuid = UtilSQLServer.SafeReader.SafeReadString(pReader, "EzyGuid")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SecurityPasswordIsExpired")) Then pObject.colSecurityPasswordIsExpired = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "SecurityPasswordIsExpired")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SecurityAccountIsLockedOut")) Then pObject.colSecurityAccountIsLockedOut = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "SecurityAccountIsLockedOut")
			If Not pReader.IsDBNull(pReader.GetOrdinal("AutoInactiveDate")) Then pObject.colAutoInactiveDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "AutoInactiveDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SecurityInactivityReminderSentDate")) Then pObject.colSecurityInactivityReminderSentDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "SecurityInactivityReminderSentDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("MultipleUserType")) Then pObject.colMultipleUserType = UtilSQLServer.SafeReader.SafeReadString(pReader, "MultipleUserType")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Import")) Then pObject.colImport = UtilSQLServer.SafeReader.SafeReadString(pReader, "Import")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ClientLocNoManager")) Then pObject.colClientLocNoManager = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "ClientLocNoManager")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ClientLocNoText")) Then pObject.colClientLocNoText = UtilSQLServer.SafeReader.SafeReadString(pReader, "ClientLocNoText")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FacilityManager")) Then pObject.colFacilityManager = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "FacilityManager")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FacilityText")) Then pObject.colFacilityText = UtilSQLServer.SafeReader.SafeReadString(pReader, "FacilityText")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CityManager")) Then pObject.colCityManager = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "CityManager")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CityText")) Then pObject.colCityText = UtilSQLServer.SafeReader.SafeReadString(pReader, "CityText")
			If Not pReader.IsDBNull(pReader.GetOrdinal("StProvManager")) Then pObject.colStProvManager = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "StProvManager")
			If Not pReader.IsDBNull(pReader.GetOrdinal("StProvText")) Then pObject.colStProvText = UtilSQLServer.SafeReader.SafeReadString(pReader, "StProvText")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CountryManager")) Then pObject.colCountryManager = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "CountryManager")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CountryText")) Then pObject.colCountryText = UtilSQLServer.SafeReader.SafeReadString(pReader, "CountryText")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RExpd")) Then pObject.colRExpd = UtilSQLServer.SafeReader.SafeReadString(pReader, "RExpd")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CCOnly")) Then pObject.colCCOnly = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "CCOnly")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LoginId")) Then pObject.colLoginId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "LoginId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LastReclassificationDate")) Then pObject.colLastReclassificationDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "LastReclassificationDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LastReclassificationByLoginID")) Then pObject.colLastReclassificationByLoginID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "LastReclassificationByLoginID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LastReclassificationAction")) Then pObject.colLastReclassificationAction = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "LastReclassificationAction")
			If Not pReader.IsDBNull(pReader.GetOrdinal("MarkedForDeletionDate")) Then pObject.colMarkedForDeletionDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "MarkedForDeletionDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ReclassificationDate")) Then pObject.colReclassificationDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "ReclassificationDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ReclassificationByLoginID")) Then pObject.colReclassificationByLoginID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "ReclassificationByLoginID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ReclassificationAction")) Then pObject.colReclassificationAction = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "ReclassificationAction")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ClientComment")) Then pObject.colClientComment = UtilSQLServer.SafeReader.SafeReadString(pReader, "ClientComment")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SysUserCreated")) Then pObject.colSysUserCreated = UtilSQLServer.SafeReader.SafeReadString(pReader, "SysUserCreated")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SysDateCreated")) Then pObject.colSysDateCreated = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "SysDateCreated")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SysUserModified")) Then pObject.colSysUserModified = UtilSQLServer.SafeReader.SafeReadString(pReader, "SysUserModified")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SysDateModified")) Then pObject.colSysDateModified = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "SysDateModified")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ClientAdministration")) Then pObject.colClientAdministration = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "ClientAdministration")
			pObject.SetIsDirty(False)
			Return pObject
		End	 Function

    #Region "Reflection Based Load Functions"

        Public Shared Function LoadByPrimaryKey(Of T)(pcolEzyUserID As Integer) As T
            Return LoadByPrimaryKey(Of T)(pcolEzyUserID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolEzyUserID As Integer, pLoadEventUserState As Object) As T
            Return LoadByPrimaryKey(Of T)(pcolEzyUserID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolEzyUserID As Integer, pTransaction As SqlClient.SqlTransaction) As T
            Return LoadByPrimaryKey(Of T)(pcolEzyUserID, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolEzyUserID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As T

            Dim zReturn As Object = Activator.CreateInstance(Of T)()
            If Not TypeOf zReturn Is rowTblEzyUsers Then Throw New ArgumentException("Generic type is not type of rowTblEzyUsers.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_Users] WHERE [EzyUserID] = @colEzyUserID"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colEzyUserID", pcolEzyUserID))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of T) = ReadData(Of T)(zCmd, pLoadEventUserState)
            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

        End Function

        Public Shared Function LoadByIDX_IX_EzyGuid(Of T)(pcolEzyGuid As String) As List(Of T)
            Return LoadByIDX_IX_EzyGuid(Of T)(pcolEzyGuid, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_EzyGuid(Of T)(pcolEzyGuid As String, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_IX_EzyGuid(Of T)(pcolEzyGuid, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_EzyGuid(Of T)(pcolEzyGuid As String, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_IX_EzyGuid(Of T)(pcolEzyGuid, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_IX_EzyGuid(Of T)(pcolEzyGuid As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_Users] WHERE [EzyGuid] = @colEzyGuid"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colEzyGuid", pcolEzyGuid))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_IX_FilePrefix_RFU1(Of T)(pcolFilePrefix As Short, pcolRfu1 As String) As List(Of T)
            Return LoadByIDX_IX_FilePrefix_RFU1(Of T)(pcolFilePrefix, pcolRfu1, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_FilePrefix_RFU1(Of T)(pcolFilePrefix As Short, pcolRfu1 As String, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_IX_FilePrefix_RFU1(Of T)(pcolFilePrefix, pcolRfu1, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_FilePrefix_RFU1(Of T)(pcolFilePrefix As Short, pcolRfu1 As String, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_IX_FilePrefix_RFU1(Of T)(pcolFilePrefix, pcolRfu1, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_IX_FilePrefix_RFU1(Of T)(pcolFilePrefix As Short, pcolRfu1 As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_Users] WHERE [FilePrefix] = @colFilePrefix AND [RFU1] = @colRfu1"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFilePrefix", pcolFilePrefix))
            zCmd.Parameters.Add(New SQLParameter("@colRfu1", pcolRfu1))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_IX_FilePrefix_RFU2(Of T)(pcolFilePrefix As Short, pcolRfu2 As String) As List(Of T)
            Return LoadByIDX_IX_FilePrefix_RFU2(Of T)(pcolFilePrefix, pcolRfu2, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_FilePrefix_RFU2(Of T)(pcolFilePrefix As Short, pcolRfu2 As String, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_IX_FilePrefix_RFU2(Of T)(pcolFilePrefix, pcolRfu2, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_FilePrefix_RFU2(Of T)(pcolFilePrefix As Short, pcolRfu2 As String, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_IX_FilePrefix_RFU2(Of T)(pcolFilePrefix, pcolRfu2, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_IX_FilePrefix_RFU2(Of T)(pcolFilePrefix As Short, pcolRfu2 As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_Users] WHERE [FilePrefix] = @colFilePrefix AND [RFU2] = @colRfu2"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFilePrefix", pcolFilePrefix))
            zCmd.Parameters.Add(New SQLParameter("@colRfu2", pcolRfu2))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_IX_FilePrefix_RFU3(Of T)(pcolFilePrefix As Short, pcolRfu3 As String) As List(Of T)
            Return LoadByIDX_IX_FilePrefix_RFU3(Of T)(pcolFilePrefix, pcolRfu3, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_FilePrefix_RFU3(Of T)(pcolFilePrefix As Short, pcolRfu3 As String, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_IX_FilePrefix_RFU3(Of T)(pcolFilePrefix, pcolRfu3, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_FilePrefix_RFU3(Of T)(pcolFilePrefix As Short, pcolRfu3 As String, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_IX_FilePrefix_RFU3(Of T)(pcolFilePrefix, pcolRfu3, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_IX_FilePrefix_RFU3(Of T)(pcolFilePrefix As Short, pcolRfu3 As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_Users] WHERE [FilePrefix] = @colFilePrefix AND [RFU3] = @colRfu3"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFilePrefix", pcolFilePrefix))
            zCmd.Parameters.Add(New SQLParameter("@colRfu3", pcolRfu3))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_IX_FilePrefix_RReport(Of T)(pcolFilePrefix As Short, pcolRReport As String) As List(Of T)
            Return LoadByIDX_IX_FilePrefix_RReport(Of T)(pcolFilePrefix, pcolRReport, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_FilePrefix_RReport(Of T)(pcolFilePrefix As Short, pcolRReport As String, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_IX_FilePrefix_RReport(Of T)(pcolFilePrefix, pcolRReport, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_FilePrefix_RReport(Of T)(pcolFilePrefix As Short, pcolRReport As String, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_IX_FilePrefix_RReport(Of T)(pcolFilePrefix, pcolRReport, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_IX_FilePrefix_RReport(Of T)(pcolFilePrefix As Short, pcolRReport As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_Users] WHERE [FilePrefix] = @colFilePrefix AND [RReport] = @colRReport"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFilePrefix", pcolFilePrefix))
            zCmd.Parameters.Add(New SQLParameter("@colRReport", pcolRReport))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_IX_LoginId(Of T)(pcolLoginId As Integer) As List(Of T)
            Return LoadByIDX_IX_LoginId(Of T)(pcolLoginId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_LoginId(Of T)(pcolLoginId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_IX_LoginId(Of T)(pcolLoginId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_LoginId(Of T)(pcolLoginId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_IX_LoginId(Of T)(pcolLoginId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_IX_LoginId(Of T)(pcolLoginId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_Users] WHERE [LoginId] = @colLoginId"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colLoginId", pcolLoginId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_pk_EzyUserId(Of T)(pcolEzyUserID As Integer) As List(Of T)
            Return LoadByIDX_pk_EzyUserId(Of T)(pcolEzyUserID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_pk_EzyUserId(Of T)(pcolEzyUserID As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_pk_EzyUserId(Of T)(pcolEzyUserID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_pk_EzyUserId(Of T)(pcolEzyUserID As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_pk_EzyUserId(Of T)(pcolEzyUserID, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_pk_EzyUserId(Of T)(pcolEzyUserID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_Users] WHERE [EzyUserID] = @colEzyUserID"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colEzyUserID", pcolEzyUserID))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadData(Of T)(pSQL As String) As List(Of T)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(Of T)(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(Of T)(pSQL As String, pLoadEventUserState As Object) As List(Of T)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(Of T)(zCmd, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(Of T)(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(Of T)(zCmd, pTransaction, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(Of T)() As List(Of T)
            Return LoadData(Of T)(New SqlClient.SqlCommand, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(Of T)(pLoadEventUserState As Object) As List(Of T)
            Return LoadData(Of T)(New SqlClient.SqlCommand, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(Of T)(pCommand As SqlCommand) As List(Of T)
            Return LoadData(Of T)(pCommand, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(Of T)(pCommand As SqlCommand, pLoadEventUserState As Object) As List(Of T)
            Return LoadData(Of T)(pCommand, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(Of T)(pCommand As SqlCommand, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadData(Of T)(pCommand, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(Of T)(pCommand As SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_Users]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblEzyUsers
        Implements IrowTblEzyUsers

        Public Event Loaded(pUserState As Object) Implements IrowTblEzyUsers.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblEzyUsers.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblEzyUsers.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblEzyUsers.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblEzyUsers.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblEzyUsers.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colUserID() As String Implements IrowTblEzyUsers.colUserID
            Get
                Return m_colUserID
            End Get
            Set
                If Not Same(m_colUserID, Value) Then
                    m_colUserID = Value
                    m_IsDirty(FieldIndex.colUserID) = True
                End If
            End Set
        End Property
        Private m_colUserID As String

        Public Property colPassword() As String Implements IrowTblEzyUsers.colPassword
            Get
                Return m_colPassword
            End Get
            Set
                If Not Same(m_colPassword, Value) Then
                    m_colPassword = Value
                    m_IsDirty(FieldIndex.colPassword) = True
                End If
            End Set
        End Property
        Private m_colPassword As String

        Public Property colFullName() As String Implements IrowTblEzyUsers.colFullName
            Get
                Return m_colFullName
            End Get
            Set
                If Not Same(m_colFullName, Value) Then
                    m_colFullName = Value
                    m_IsDirty(FieldIndex.colFullName) = True
                End If
            End Set
        End Property
        Private m_colFullName As String

        Public Property colRiskManager() As Nullable(Of Boolean) Implements IrowTblEzyUsers.colRiskManager
            Get
                Return m_colRiskManager
            End Get
            Set
                If Not Same(m_colRiskManager, Value) Then
                    m_colRiskManager = Value
                    m_IsDirty(FieldIndex.colRiskManager) = True
                End If
            End Set
        End Property
        Private m_colRiskManager As Nullable(Of Boolean)

        Public Property colDivisionManager() As Nullable(Of Boolean) Implements IrowTblEzyUsers.colDivisionManager
            Get
                Return m_colDivisionManager
            End Get
            Set
                If Not Same(m_colDivisionManager, Value) Then
                    m_colDivisionManager = Value
                    m_IsDirty(FieldIndex.colDivisionManager) = True
                End If
            End Set
        End Property
        Private m_colDivisionManager As Nullable(Of Boolean)

        Public Property colDivision() As String Implements IrowTblEzyUsers.colDivision
            Get
                Return m_colDivision
            End Get
            Set
                If Not Same(m_colDivision, Value) Then
                    m_colDivision = Value
                    m_IsDirty(FieldIndex.colDivision) = True
                End If
            End Set
        End Property
        Private m_colDivision As String

        Public Property colPlantManager() As Nullable(Of Boolean) Implements IrowTblEzyUsers.colPlantManager
            Get
                Return m_colPlantManager
            End Get
            Set
                If Not Same(m_colPlantManager, Value) Then
                    m_colPlantManager = Value
                    m_IsDirty(FieldIndex.colPlantManager) = True
                End If
            End Set
        End Property
        Private m_colPlantManager As Nullable(Of Boolean)

        Public Property colPlant() As String Implements IrowTblEzyUsers.colPlant
            Get
                Return m_colPlant
            End Get
            Set
                If Not Same(m_colPlant, Value) Then
                    m_colPlant = Value
                    m_IsDirty(FieldIndex.colPlant) = True
                End If
            End Set
        End Property
        Private m_colPlant As String

        Public Property colAdministrator() As Nullable(Of Boolean) Implements IrowTblEzyUsers.colAdministrator
            Get
                Return m_colAdministrator
            End Get
            Set
                If Not Same(m_colAdministrator, Value) Then
                    m_colAdministrator = Value
                    m_IsDirty(FieldIndex.colAdministrator) = True
                End If
            End Set
        End Property
        Private m_colAdministrator As Nullable(Of Boolean)

        Public Property colDocumentAccess() As Nullable(Of Boolean) Implements IrowTblEzyUsers.colDocumentAccess
            Get
                Return m_colDocumentAccess
            End Get
            Set
                If Not Same(m_colDocumentAccess, Value) Then
                    m_colDocumentAccess = Value
                    m_IsDirty(FieldIndex.colDocumentAccess) = True
                End If
            End Set
        End Property
        Private m_colDocumentAccess As Nullable(Of Boolean)

        Public Property colCustomAccess() As Nullable(Of Boolean) Implements IrowTblEzyUsers.colCustomAccess
            Get
                Return m_colCustomAccess
            End Get
            Set
                If Not Same(m_colCustomAccess, Value) Then
                    m_colCustomAccess = Value
                    m_IsDirty(FieldIndex.colCustomAccess) = True
                End If
            End Set
        End Property
        Private m_colCustomAccess As Nullable(Of Boolean)

        Public Property colCustomAccessText() As String Implements IrowTblEzyUsers.colCustomAccessText
            Get
                Return m_colCustomAccessText
            End Get
            Set
                If Not Same(m_colCustomAccessText, Value) Then
                    m_colCustomAccessText = Value
                    m_IsDirty(FieldIndex.colCustomAccessText) = True
                End If
            End Set
        End Property
        Private m_colCustomAccessText As String

        Public Property colOperatorStamp() As String Implements IrowTblEzyUsers.colOperatorStamp
            Get
                Return m_colOperatorStamp
            End Get
            Set
                If Not Same(m_colOperatorStamp, Value) Then
                    m_colOperatorStamp = Value
                    m_IsDirty(FieldIndex.colOperatorStamp) = True
                End If
            End Set
        End Property
        Private m_colOperatorStamp As String

        Public Property colDateTimeStamp() As Nullable(Of DateTime) Implements IrowTblEzyUsers.colDateTimeStamp
            Get
                Return m_colDateTimeStamp
            End Get
            Set
                If Not Same(m_colDateTimeStamp, Value) Then
                    m_colDateTimeStamp = Value
                    m_IsDirty(FieldIndex.colDateTimeStamp) = True
                End If
            End Set
        End Property
        Private m_colDateTimeStamp As Nullable(Of DateTime)

        Public Property colPhone() As String Implements IrowTblEzyUsers.colPhone
            Get
                Return m_colPhone
            End Get
            Set
                If Not Same(m_colPhone, Value) Then
                    m_colPhone = Value
                    m_IsDirty(FieldIndex.colPhone) = True
                End If
            End Set
        End Property
        Private m_colPhone As String

        Public Property colFax() As String Implements IrowTblEzyUsers.colFax
            Get
                Return m_colFax
            End Get
            Set
                If Not Same(m_colFax, Value) Then
                    m_colFax = Value
                    m_IsDirty(FieldIndex.colFax) = True
                End If
            End Set
        End Property
        Private m_colFax As String

        Public Property colEmail() As String Implements IrowTblEzyUsers.colEmail
            Get
                Return m_colEmail
            End Get
            Set
                If Not Same(m_colEmail, Value) Then
                    m_colEmail = Value
                    m_IsDirty(FieldIndex.colEmail) = True
                End If
            End Set
        End Property
        Private m_colEmail As String

        Public Property colNotificationStamp() As Nullable(Of DateTime) Implements IrowTblEzyUsers.colNotificationStamp
            Get
                Return m_colNotificationStamp
            End Get
            Set
                If Not Same(m_colNotificationStamp, Value) Then
                    m_colNotificationStamp = Value
                    m_IsDirty(FieldIndex.colNotificationStamp) = True
                End If
            End Set
        End Property
        Private m_colNotificationStamp As Nullable(Of DateTime)

        Public Property colActiveUser() As Nullable(Of Boolean) Implements IrowTblEzyUsers.colActiveUser
            Get
                Return m_colActiveUser
            End Get
            Set
                If Not Same(m_colActiveUser, Value) Then
                    m_colActiveUser = Value
                    m_IsDirty(FieldIndex.colActiveUser) = True
                End If
            End Set
        End Property
        Private m_colActiveUser As Nullable(Of Boolean)

        Public Property colFilePrefix() As Nullable(Of Short) Implements IrowTblEzyUsers.colFilePrefix
            Get
                Return m_colFilePrefix
            End Get
            Set
                If Not Same(m_colFilePrefix, Value) Then
                    m_colFilePrefix = Value
                    m_IsDirty(FieldIndex.colFilePrefix) = True
                End If
            End Set
        End Property
        Private m_colFilePrefix As Nullable(Of Short)

        Public Property colLastLogin() As Nullable(Of DateTime) Implements IrowTblEzyUsers.colLastLogin
            Get
                Return m_colLastLogin
            End Get
            Set
                If Not Same(m_colLastLogin, Value) Then
                    m_colLastLogin = Value
                    m_IsDirty(FieldIndex.colLastLogin) = True
                End If
            End Set
        End Property
        Private m_colLastLogin As Nullable(Of DateTime)

        Public Property colLastPWChange() As Nullable(Of DateTime) Implements IrowTblEzyUsers.colLastPWChange
            Get
                Return m_colLastPWChange
            End Get
            Set
                If Not Same(m_colLastPWChange, Value) Then
                    m_colLastPWChange = Value
                    m_IsDirty(FieldIndex.colLastPWChange) = True
                End If
            End Set
        End Property
        Private m_colLastPWChange As Nullable(Of DateTime)

        Public Property colInternal() As Nullable(Of Boolean) Implements IrowTblEzyUsers.colInternal
            Get
                Return m_colInternal
            End Get
            Set
                If Not Same(m_colInternal, Value) Then
                    m_colInternal = Value
                    m_IsDirty(FieldIndex.colInternal) = True
                End If
            End Set
        End Property
        Private m_colInternal As Nullable(Of Boolean)

        Public Property colComments() As String Implements IrowTblEzyUsers.colComments
            Get
                Return m_colComments
            End Get
            Set
                If Not Same(m_colComments, Value) Then
                    m_colComments = Value
                    m_IsDirty(FieldIndex.colComments) = True
                End If
            End Set
        End Property
        Private m_colComments As String

        Public Property colRInit() As String Implements IrowTblEzyUsers.colRInit
            Get
                Return m_colRInit
            End Get
            Set
                If Not Same(m_colRInit, Value) Then
                    m_colRInit = Value
                    m_IsDirty(FieldIndex.colRInit) = True
                End If
            End Set
        End Property
        Private m_colRInit As String

        Public Property colRfu1() As String Implements IrowTblEzyUsers.colRfu1
            Get
                Return m_colRfu1
            End Get
            Set
                If Not Same(m_colRfu1, Value) Then
                    m_colRfu1 = Value
                    m_IsDirty(FieldIndex.colRfu1) = True
                End If
            End Set
        End Property
        Private m_colRfu1 As String

        Public Property colRfu2() As String Implements IrowTblEzyUsers.colRfu2
            Get
                Return m_colRfu2
            End Get
            Set
                If Not Same(m_colRfu2, Value) Then
                    m_colRfu2 = Value
                    m_IsDirty(FieldIndex.colRfu2) = True
                End If
            End Set
        End Property
        Private m_colRfu2 As String

        Public Property colRfu3() As String Implements IrowTblEzyUsers.colRfu3
            Get
                Return m_colRfu3
            End Get
            Set
                If Not Same(m_colRfu3, Value) Then
                    m_colRfu3 = Value
                    m_IsDirty(FieldIndex.colRfu3) = True
                End If
            End Set
        End Property
        Private m_colRfu3 As String

        Public Property colRReport() As String Implements IrowTblEzyUsers.colRReport
            Get
                Return m_colRReport
            End Get
            Set
                If Not Same(m_colRReport, Value) Then
                    m_colRReport = Value
                    m_IsDirty(FieldIndex.colRReport) = True
                End If
            End Set
        End Property
        Private m_colRReport As String

        Public Property colROverdue1() As String Implements IrowTblEzyUsers.colROverdue1
            Get
                Return m_colROverdue1
            End Get
            Set
                If Not Same(m_colROverdue1, Value) Then
                    m_colROverdue1 = Value
                    m_IsDirty(FieldIndex.colROverdue1) = True
                End If
            End Set
        End Property
        Private m_colROverdue1 As String

        Public Property colROverdue2() As String Implements IrowTblEzyUsers.colROverdue2
            Get
                Return m_colROverdue2
            End Get
            Set
                If Not Same(m_colROverdue2, Value) Then
                    m_colROverdue2 = Value
                    m_IsDirty(FieldIndex.colROverdue2) = True
                End If
            End Set
        End Property
        Private m_colROverdue2 As String

        Public Property colROverdue3() As String Implements IrowTblEzyUsers.colROverdue3
            Get
                Return m_colROverdue3
            End Get
            Set
                If Not Same(m_colROverdue3, Value) Then
                    m_colROverdue3 = Value
                    m_IsDirty(FieldIndex.colROverdue3) = True
                End If
            End Set
        End Property
        Private m_colROverdue3 As String

        Public Property colRActResp() As String Implements IrowTblEzyUsers.colRActResp
            Get
                Return m_colRActResp
            End Get
            Set
                If Not Same(m_colRActResp, Value) Then
                    m_colRActResp = Value
                    m_IsDirty(FieldIndex.colRActResp) = True
                End If
            End Set
        End Property
        Private m_colRActResp As String

        Public Property colWo() As Nullable(Of Boolean) Implements IrowTblEzyUsers.colWo
            Get
                Return m_colWo
            End Get
            Set
                If Not Same(m_colWo, Value) Then
                    m_colWo = Value
                    m_IsDirty(FieldIndex.colWo) = True
                End If
            End Set
        End Property
        Private m_colWo As Nullable(Of Boolean)

        Public Property colCalist() As String Implements IrowTblEzyUsers.colCalist
            Get
                Return m_colCalist
            End Get
            Set
                If Not Same(m_colCalist, Value) Then
                    m_colCalist = Value
                    m_IsDirty(FieldIndex.colCalist) = True
                End If
            End Set
        End Property
        Private m_colCalist As String

        Public Property colDivlist() As String Implements IrowTblEzyUsers.colDivlist
            Get
                Return m_colDivlist
            End Get
            Set
                If Not Same(m_colDivlist, Value) Then
                    m_colDivlist = Value
                    m_IsDirty(FieldIndex.colDivlist) = True
                End If
            End Set
        End Property
        Private m_colDivlist As String

        Public Property colLoclist() As String Implements IrowTblEzyUsers.colLoclist
            Get
                Return m_colLoclist
            End Get
            Set
                If Not Same(m_colLoclist, Value) Then
                    m_colLoclist = Value
                    m_IsDirty(FieldIndex.colLoclist) = True
                End If
            End Set
        End Property
        Private m_colLoclist As String

        Public Property colThirdParty() As Nullable(Of Boolean) Implements IrowTblEzyUsers.colThirdParty
            Get
                Return m_colThirdParty
            End Get
            Set
                If Not Same(m_colThirdParty, Value) Then
                    m_colThirdParty = Value
                    m_IsDirty(FieldIndex.colThirdParty) = True
                End If
            End Set
        End Property
        Private m_colThirdParty As Nullable(Of Boolean)

        Public Property colGRCAdministrator() As String Implements IrowTblEzyUsers.colGRCAdministrator
            Get
                Return m_colGRCAdministrator
            End Get
            Set
                If Not Same(m_colGRCAdministrator, Value) Then
                    m_colGRCAdministrator = Value
                    m_IsDirty(FieldIndex.colGRCAdministrator) = True
                End If
            End Set
        End Property
        Private m_colGRCAdministrator As String

        Public Property colLastRecentUpdate() As Nullable(Of DateTime) Implements IrowTblEzyUsers.colLastRecentUpdate
            Get
                Return m_colLastRecentUpdate
            End Get
            Set
                If Not Same(m_colLastRecentUpdate, Value) Then
                    m_colLastRecentUpdate = Value
                    m_IsDirty(FieldIndex.colLastRecentUpdate) = True
                End If
            End Set
        End Property
        Private m_colLastRecentUpdate As Nullable(Of DateTime)

        Public Property colEzyUserID() As Nullable(Of Integer) Implements IrowTblEzyUsers.colEzyUserID
            Get
                Return m_colEzyUserID
            End Get
            Set
                If Not Same(m_colEzyUserID, Value) Then
                    m_colEzyUserID = Value
                    m_IsDirty(FieldIndex.colEzyUserID) = True
                End If
            End Set
        End Property
        Private m_colEzyUserID As Nullable(Of Integer)

        Public Property colAllowMaintLogin() As Nullable(Of Boolean) Implements IrowTblEzyUsers.colAllowMaintLogin
            Get
                Return m_colAllowMaintLogin
            End Get
            Set
                If Not Same(m_colAllowMaintLogin, Value) Then
                    m_colAllowMaintLogin = Value
                    m_IsDirty(FieldIndex.colAllowMaintLogin) = True
                End If
            End Set
        End Property
        Private m_colAllowMaintLogin As Nullable(Of Boolean)

        Public Property colCCActive() As Nullable(Of Boolean) Implements IrowTblEzyUsers.colCCActive
            Get
                Return m_colCCActive
            End Get
            Set
                If Not Same(m_colCCActive, Value) Then
                    m_colCCActive = Value
                    m_IsDirty(FieldIndex.colCCActive) = True
                End If
            End Set
        End Property
        Private m_colCCActive As Nullable(Of Boolean)

        Public Property colExpOverdue() As String Implements IrowTblEzyUsers.colExpOverdue
            Get
                Return m_colExpOverdue
            End Get
            Set
                If Not Same(m_colExpOverdue, Value) Then
                    m_colExpOverdue = Value
                    m_IsDirty(FieldIndex.colExpOverdue) = True
                End If
            End Set
        End Property
        Private m_colExpOverdue As String

        Public Property colEzyGuid() As String Implements IrowTblEzyUsers.colEzyGuid
            Get
                Return m_colEzyGuid
            End Get
            Set
                If Not Same(m_colEzyGuid, Value) Then
                    m_colEzyGuid = Value
                    m_IsDirty(FieldIndex.colEzyGuid) = True
                End If
            End Set
        End Property
        Private m_colEzyGuid As String

        Public Property colSecurityPasswordIsExpired() As Nullable(Of Boolean) Implements IrowTblEzyUsers.colSecurityPasswordIsExpired
            Get
                Return m_colSecurityPasswordIsExpired
            End Get
            Set
                If Not Same(m_colSecurityPasswordIsExpired, Value) Then
                    m_colSecurityPasswordIsExpired = Value
                    m_IsDirty(FieldIndex.colSecurityPasswordIsExpired) = True
                End If
            End Set
        End Property
        Private m_colSecurityPasswordIsExpired As Nullable(Of Boolean)

        Public Property colSecurityAccountIsLockedOut() As Nullable(Of Boolean) Implements IrowTblEzyUsers.colSecurityAccountIsLockedOut
            Get
                Return m_colSecurityAccountIsLockedOut
            End Get
            Set
                If Not Same(m_colSecurityAccountIsLockedOut, Value) Then
                    m_colSecurityAccountIsLockedOut = Value
                    m_IsDirty(FieldIndex.colSecurityAccountIsLockedOut) = True
                End If
            End Set
        End Property
        Private m_colSecurityAccountIsLockedOut As Nullable(Of Boolean)

        Public Property colAutoInactiveDate() As Nullable(Of DateTime) Implements IrowTblEzyUsers.colAutoInactiveDate
            Get
                Return m_colAutoInactiveDate
            End Get
            Set
                If Not Same(m_colAutoInactiveDate, Value) Then
                    m_colAutoInactiveDate = Value
                    m_IsDirty(FieldIndex.colAutoInactiveDate) = True
                End If
            End Set
        End Property
        Private m_colAutoInactiveDate As Nullable(Of DateTime)

        Public Property colSecurityInactivityReminderSentDate() As Nullable(Of DateTime) Implements IrowTblEzyUsers.colSecurityInactivityReminderSentDate
            Get
                Return m_colSecurityInactivityReminderSentDate
            End Get
            Set
                If Not Same(m_colSecurityInactivityReminderSentDate, Value) Then
                    m_colSecurityInactivityReminderSentDate = Value
                    m_IsDirty(FieldIndex.colSecurityInactivityReminderSentDate) = True
                End If
            End Set
        End Property
        Private m_colSecurityInactivityReminderSentDate As Nullable(Of DateTime)

        Public Property colMultipleUserType() As String Implements IrowTblEzyUsers.colMultipleUserType
            Get
                Return m_colMultipleUserType
            End Get
            Set
                If Not Same(m_colMultipleUserType, Value) Then
                    m_colMultipleUserType = Value
                    m_IsDirty(FieldIndex.colMultipleUserType) = True
                End If
            End Set
        End Property
        Private m_colMultipleUserType As String

        Public Property colImport() As String Implements IrowTblEzyUsers.colImport
            Get
                Return m_colImport
            End Get
            Set
                If Not Same(m_colImport, Value) Then
                    m_colImport = Value
                    m_IsDirty(FieldIndex.colImport) = True
                End If
            End Set
        End Property
        Private m_colImport As String

        Public Property colClientLocNoManager() As Nullable(Of Boolean) Implements IrowTblEzyUsers.colClientLocNoManager
            Get
                Return m_colClientLocNoManager
            End Get
            Set
                If Not Same(m_colClientLocNoManager, Value) Then
                    m_colClientLocNoManager = Value
                    m_IsDirty(FieldIndex.colClientLocNoManager) = True
                End If
            End Set
        End Property
        Private m_colClientLocNoManager As Nullable(Of Boolean)

        Public Property colClientLocNoText() As String Implements IrowTblEzyUsers.colClientLocNoText
            Get
                Return m_colClientLocNoText
            End Get
            Set
                If Not Same(m_colClientLocNoText, Value) Then
                    m_colClientLocNoText = Value
                    m_IsDirty(FieldIndex.colClientLocNoText) = True
                End If
            End Set
        End Property
        Private m_colClientLocNoText As String

        Public Property colFacilityManager() As Nullable(Of Boolean) Implements IrowTblEzyUsers.colFacilityManager
            Get
                Return m_colFacilityManager
            End Get
            Set
                If Not Same(m_colFacilityManager, Value) Then
                    m_colFacilityManager = Value
                    m_IsDirty(FieldIndex.colFacilityManager) = True
                End If
            End Set
        End Property
        Private m_colFacilityManager As Nullable(Of Boolean)

        Public Property colFacilityText() As String Implements IrowTblEzyUsers.colFacilityText
            Get
                Return m_colFacilityText
            End Get
            Set
                If Not Same(m_colFacilityText, Value) Then
                    m_colFacilityText = Value
                    m_IsDirty(FieldIndex.colFacilityText) = True
                End If
            End Set
        End Property
        Private m_colFacilityText As String

        Public Property colCityManager() As Nullable(Of Boolean) Implements IrowTblEzyUsers.colCityManager
            Get
                Return m_colCityManager
            End Get
            Set
                If Not Same(m_colCityManager, Value) Then
                    m_colCityManager = Value
                    m_IsDirty(FieldIndex.colCityManager) = True
                End If
            End Set
        End Property
        Private m_colCityManager As Nullable(Of Boolean)

        Public Property colCityText() As String Implements IrowTblEzyUsers.colCityText
            Get
                Return m_colCityText
            End Get
            Set
                If Not Same(m_colCityText, Value) Then
                    m_colCityText = Value
                    m_IsDirty(FieldIndex.colCityText) = True
                End If
            End Set
        End Property
        Private m_colCityText As String

        Public Property colStProvManager() As Nullable(Of Boolean) Implements IrowTblEzyUsers.colStProvManager
            Get
                Return m_colStProvManager
            End Get
            Set
                If Not Same(m_colStProvManager, Value) Then
                    m_colStProvManager = Value
                    m_IsDirty(FieldIndex.colStProvManager) = True
                End If
            End Set
        End Property
        Private m_colStProvManager As Nullable(Of Boolean)

        Public Property colStProvText() As String Implements IrowTblEzyUsers.colStProvText
            Get
                Return m_colStProvText
            End Get
            Set
                If Not Same(m_colStProvText, Value) Then
                    m_colStProvText = Value
                    m_IsDirty(FieldIndex.colStProvText) = True
                End If
            End Set
        End Property
        Private m_colStProvText As String

        Public Property colCountryManager() As Nullable(Of Boolean) Implements IrowTblEzyUsers.colCountryManager
            Get
                Return m_colCountryManager
            End Get
            Set
                If Not Same(m_colCountryManager, Value) Then
                    m_colCountryManager = Value
                    m_IsDirty(FieldIndex.colCountryManager) = True
                End If
            End Set
        End Property
        Private m_colCountryManager As Nullable(Of Boolean)

        Public Property colCountryText() As String Implements IrowTblEzyUsers.colCountryText
            Get
                Return m_colCountryText
            End Get
            Set
                If Not Same(m_colCountryText, Value) Then
                    m_colCountryText = Value
                    m_IsDirty(FieldIndex.colCountryText) = True
                End If
            End Set
        End Property
        Private m_colCountryText As String

        Public Property colRExpd() As String Implements IrowTblEzyUsers.colRExpd
            Get
                Return m_colRExpd
            End Get
            Set
                If Not Same(m_colRExpd, Value) Then
                    m_colRExpd = Value
                    m_IsDirty(FieldIndex.colRExpd) = True
                End If
            End Set
        End Property
        Private m_colRExpd As String

        Public Property colCCOnly() As Nullable(Of Boolean) Implements IrowTblEzyUsers.colCCOnly
            Get
                Return m_colCCOnly
            End Get
            Set
                If Not Same(m_colCCOnly, Value) Then
                    m_colCCOnly = Value
                    m_IsDirty(FieldIndex.colCCOnly) = True
                End If
            End Set
        End Property
        Private m_colCCOnly As Nullable(Of Boolean)

        Public Property colLoginId() As Nullable(Of Integer) Implements IrowTblEzyUsers.colLoginId
            Get
                Return m_colLoginId
            End Get
            Set
                If Not Same(m_colLoginId, Value) Then
                    m_colLoginId = Value
                    m_IsDirty(FieldIndex.colLoginId) = True
                End If
            End Set
        End Property
        Private m_colLoginId As Nullable(Of Integer)

        Public Property colLastReclassificationDate() As Nullable(Of DateTime) Implements IrowTblEzyUsers.colLastReclassificationDate
            Get
                Return m_colLastReclassificationDate
            End Get
            Set
                If Not Same(m_colLastReclassificationDate, Value) Then
                    m_colLastReclassificationDate = Value
                    m_IsDirty(FieldIndex.colLastReclassificationDate) = True
                End If
            End Set
        End Property
        Private m_colLastReclassificationDate As Nullable(Of DateTime)

        Public Property colLastReclassificationByLoginID() As Nullable(Of Integer) Implements IrowTblEzyUsers.colLastReclassificationByLoginID
            Get
                Return m_colLastReclassificationByLoginID
            End Get
            Set
                If Not Same(m_colLastReclassificationByLoginID, Value) Then
                    m_colLastReclassificationByLoginID = Value
                    m_IsDirty(FieldIndex.colLastReclassificationByLoginID) = True
                End If
            End Set
        End Property
        Private m_colLastReclassificationByLoginID As Nullable(Of Integer)

        Public Property colLastReclassificationAction() As Nullable(Of Integer) Implements IrowTblEzyUsers.colLastReclassificationAction
            Get
                Return m_colLastReclassificationAction
            End Get
            Set
                If Not Same(m_colLastReclassificationAction, Value) Then
                    m_colLastReclassificationAction = Value
                    m_IsDirty(FieldIndex.colLastReclassificationAction) = True
                End If
            End Set
        End Property
        Private m_colLastReclassificationAction As Nullable(Of Integer)

        Public Property colMarkedForDeletionDate() As Nullable(Of DateTime) Implements IrowTblEzyUsers.colMarkedForDeletionDate
            Get
                Return m_colMarkedForDeletionDate
            End Get
            Set
                If Not Same(m_colMarkedForDeletionDate, Value) Then
                    m_colMarkedForDeletionDate = Value
                    m_IsDirty(FieldIndex.colMarkedForDeletionDate) = True
                End If
            End Set
        End Property
        Private m_colMarkedForDeletionDate As Nullable(Of DateTime)

        Public Property colReclassificationDate() As Nullable(Of DateTime) Implements IrowTblEzyUsers.colReclassificationDate
            Get
                Return m_colReclassificationDate
            End Get
            Set
                If Not Same(m_colReclassificationDate, Value) Then
                    m_colReclassificationDate = Value
                    m_IsDirty(FieldIndex.colReclassificationDate) = True
                End If
            End Set
        End Property
        Private m_colReclassificationDate As Nullable(Of DateTime)

        Public Property colReclassificationByLoginID() As Nullable(Of Integer) Implements IrowTblEzyUsers.colReclassificationByLoginID
            Get
                Return m_colReclassificationByLoginID
            End Get
            Set
                If Not Same(m_colReclassificationByLoginID, Value) Then
                    m_colReclassificationByLoginID = Value
                    m_IsDirty(FieldIndex.colReclassificationByLoginID) = True
                End If
            End Set
        End Property
        Private m_colReclassificationByLoginID As Nullable(Of Integer)

        Public Property colReclassificationAction() As Nullable(Of Integer) Implements IrowTblEzyUsers.colReclassificationAction
            Get
                Return m_colReclassificationAction
            End Get
            Set
                If Not Same(m_colReclassificationAction, Value) Then
                    m_colReclassificationAction = Value
                    m_IsDirty(FieldIndex.colReclassificationAction) = True
                End If
            End Set
        End Property
        Private m_colReclassificationAction As Nullable(Of Integer)

        Public Property colClientComment() As String Implements IrowTblEzyUsers.colClientComment
            Get
                Return m_colClientComment
            End Get
            Set
                If Not Same(m_colClientComment, Value) Then
                    m_colClientComment = Value
                    m_IsDirty(FieldIndex.colClientComment) = True
                End If
            End Set
        End Property
        Private m_colClientComment As String

        Public Property colSysUserCreated() As String Implements IrowTblEzyUsers.colSysUserCreated
            Get
                Return m_colSysUserCreated
            End Get
            Set
                If Not Same(m_colSysUserCreated, Value) Then
                    m_colSysUserCreated = Value
                    m_IsDirty(FieldIndex.colSysUserCreated) = True
                End If
            End Set
        End Property
        Private m_colSysUserCreated As String

        Public Property colSysDateCreated() As Nullable(Of DateTime) Implements IrowTblEzyUsers.colSysDateCreated
            Get
                Return m_colSysDateCreated
            End Get
            Set
                If Not Same(m_colSysDateCreated, Value) Then
                    m_colSysDateCreated = Value
                    m_IsDirty(FieldIndex.colSysDateCreated) = True
                End If
            End Set
        End Property
        Private m_colSysDateCreated As Nullable(Of DateTime)

        Public Property colSysUserModified() As String Implements IrowTblEzyUsers.colSysUserModified
            Get
                Return m_colSysUserModified
            End Get
            Set
                If Not Same(m_colSysUserModified, Value) Then
                    m_colSysUserModified = Value
                    m_IsDirty(FieldIndex.colSysUserModified) = True
                End If
            End Set
        End Property
        Private m_colSysUserModified As String

        Public Property colSysDateModified() As Nullable(Of DateTime) Implements IrowTblEzyUsers.colSysDateModified
            Get
                Return m_colSysDateModified
            End Get
            Set
                If Not Same(m_colSysDateModified, Value) Then
                    m_colSysDateModified = Value
                    m_IsDirty(FieldIndex.colSysDateModified) = True
                End If
            End Set
        End Property
        Private m_colSysDateModified As Nullable(Of DateTime)

        Public Property colClientAdministration() As Nullable(Of Boolean) Implements IrowTblEzyUsers.colClientAdministration
            Get
                Return m_colClientAdministration
            End Get
            Set
                If Not Same(m_colClientAdministration, Value) Then
                    m_colClientAdministration = Value
                    m_IsDirty(FieldIndex.colClientAdministration) = True
                End If
            End Set
        End Property
        Private m_colClientAdministration As Nullable(Of Boolean)


        Public Function IsDirty(pIndex As rowTblEzyUsers.FieldIndex) As Boolean Implements IrowTblEzyUsers.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblEzyUsers.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblEzyUsers.SetIsDirty
            m_IsDirty(FieldIndex.colUserID) = pDirty
            m_IsDirty(FieldIndex.colPassword) = pDirty
            m_IsDirty(FieldIndex.colFullName) = pDirty
            m_IsDirty(FieldIndex.colRiskManager) = pDirty
            m_IsDirty(FieldIndex.colDivisionManager) = pDirty
            m_IsDirty(FieldIndex.colDivision) = pDirty
            m_IsDirty(FieldIndex.colPlantManager) = pDirty
            m_IsDirty(FieldIndex.colPlant) = pDirty
            m_IsDirty(FieldIndex.colAdministrator) = pDirty
            m_IsDirty(FieldIndex.colDocumentAccess) = pDirty
            m_IsDirty(FieldIndex.colCustomAccess) = pDirty
            m_IsDirty(FieldIndex.colCustomAccessText) = pDirty
            m_IsDirty(FieldIndex.colOperatorStamp) = pDirty
            m_IsDirty(FieldIndex.colDateTimeStamp) = pDirty
            m_IsDirty(FieldIndex.colPhone) = pDirty
            m_IsDirty(FieldIndex.colFax) = pDirty
            m_IsDirty(FieldIndex.colEmail) = pDirty
            m_IsDirty(FieldIndex.colNotificationStamp) = pDirty
            m_IsDirty(FieldIndex.colActiveUser) = pDirty
            m_IsDirty(FieldIndex.colFilePrefix) = pDirty
            m_IsDirty(FieldIndex.colLastLogin) = pDirty
            m_IsDirty(FieldIndex.colLastPWChange) = pDirty
            m_IsDirty(FieldIndex.colInternal) = pDirty
            m_IsDirty(FieldIndex.colComments) = pDirty
            m_IsDirty(FieldIndex.colRInit) = pDirty
            m_IsDirty(FieldIndex.colRfu1) = pDirty
            m_IsDirty(FieldIndex.colRfu2) = pDirty
            m_IsDirty(FieldIndex.colRfu3) = pDirty
            m_IsDirty(FieldIndex.colRReport) = pDirty
            m_IsDirty(FieldIndex.colROverdue1) = pDirty
            m_IsDirty(FieldIndex.colROverdue2) = pDirty
            m_IsDirty(FieldIndex.colROverdue3) = pDirty
            m_IsDirty(FieldIndex.colRActResp) = pDirty
            m_IsDirty(FieldIndex.colWo) = pDirty
            m_IsDirty(FieldIndex.colCalist) = pDirty
            m_IsDirty(FieldIndex.colDivlist) = pDirty
            m_IsDirty(FieldIndex.colLoclist) = pDirty
            m_IsDirty(FieldIndex.colThirdParty) = pDirty
            m_IsDirty(FieldIndex.colGRCAdministrator) = pDirty
            m_IsDirty(FieldIndex.colLastRecentUpdate) = pDirty
            m_IsDirty(FieldIndex.colEzyUserID) = pDirty
            m_IsDirty(FieldIndex.colAllowMaintLogin) = pDirty
            m_IsDirty(FieldIndex.colCCActive) = pDirty
            m_IsDirty(FieldIndex.colExpOverdue) = pDirty
            m_IsDirty(FieldIndex.colEzyGuid) = pDirty
            m_IsDirty(FieldIndex.colSecurityPasswordIsExpired) = pDirty
            m_IsDirty(FieldIndex.colSecurityAccountIsLockedOut) = pDirty
            m_IsDirty(FieldIndex.colAutoInactiveDate) = pDirty
            m_IsDirty(FieldIndex.colSecurityInactivityReminderSentDate) = pDirty
            m_IsDirty(FieldIndex.colMultipleUserType) = pDirty
            m_IsDirty(FieldIndex.colImport) = pDirty
            m_IsDirty(FieldIndex.colClientLocNoManager) = pDirty
            m_IsDirty(FieldIndex.colClientLocNoText) = pDirty
            m_IsDirty(FieldIndex.colFacilityManager) = pDirty
            m_IsDirty(FieldIndex.colFacilityText) = pDirty
            m_IsDirty(FieldIndex.colCityManager) = pDirty
            m_IsDirty(FieldIndex.colCityText) = pDirty
            m_IsDirty(FieldIndex.colStProvManager) = pDirty
            m_IsDirty(FieldIndex.colStProvText) = pDirty
            m_IsDirty(FieldIndex.colCountryManager) = pDirty
            m_IsDirty(FieldIndex.colCountryText) = pDirty
            m_IsDirty(FieldIndex.colRExpd) = pDirty
            m_IsDirty(FieldIndex.colCCOnly) = pDirty
            m_IsDirty(FieldIndex.colLoginId) = pDirty
            m_IsDirty(FieldIndex.colLastReclassificationDate) = pDirty
            m_IsDirty(FieldIndex.colLastReclassificationByLoginID) = pDirty
            m_IsDirty(FieldIndex.colLastReclassificationAction) = pDirty
            m_IsDirty(FieldIndex.colMarkedForDeletionDate) = pDirty
            m_IsDirty(FieldIndex.colReclassificationDate) = pDirty
            m_IsDirty(FieldIndex.colReclassificationByLoginID) = pDirty
            m_IsDirty(FieldIndex.colReclassificationAction) = pDirty
            m_IsDirty(FieldIndex.colClientComment) = pDirty
            m_IsDirty(FieldIndex.colSysUserCreated) = pDirty
            m_IsDirty(FieldIndex.colSysDateCreated) = pDirty
            m_IsDirty(FieldIndex.colSysUserModified) = pDirty
            m_IsDirty(FieldIndex.colSysDateModified) = pDirty
            m_IsDirty(FieldIndex.colClientAdministration) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblEzyUsers) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblEzyUsers
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colUserID  = 1
            colPassword 
            colFullName 
            colRiskManager 
            colDivisionManager 
            colDivision 
            colPlantManager 
            colPlant 
            colAdministrator 
            colDocumentAccess 
            colCustomAccess 
            colCustomAccessText 
            colOperatorStamp 
            colDateTimeStamp 
            colPhone 
            colFax 
            colEmail 
            colNotificationStamp 
            colActiveUser 
            colFilePrefix 
            colLastLogin 
            colLastPWChange 
            colInternal 
            colComments 
            colRInit 
            colRfu1 
            colRfu2 
            colRfu3 
            colRReport 
            colROverdue1 
            colROverdue2 
            colROverdue3 
            colRActResp 
            colWo 
            colCalist 
            colDivlist 
            colLoclist 
            colThirdParty 
            colGRCAdministrator 
            colLastRecentUpdate 
            colEzyUserID 
            colAllowMaintLogin 
            colCCActive 
            colExpOverdue 
            colEzyGuid 
            colSecurityPasswordIsExpired 
            colSecurityAccountIsLockedOut 
            colAutoInactiveDate 
            colSecurityInactivityReminderSentDate 
            colMultipleUserType 
            colImport 
            colClientLocNoManager 
            colClientLocNoText 
            colFacilityManager 
            colFacilityText 
            colCityManager 
            colCityText 
            colStProvManager 
            colStProvText 
            colCountryManager 
            colCountryText 
            colRExpd 
            colCCOnly 
            colLoginId 
            colLastReclassificationDate 
            colLastReclassificationByLoginID 
            colLastReclassificationAction 
            colMarkedForDeletionDate 
            colReclassificationDate 
            colReclassificationByLoginID 
            colReclassificationAction 
            colClientComment 
            colSysUserCreated 
            colSysDateCreated 
            colSysUserModified 
            colSysDateModified 
            colClientAdministration 
        End Enum

        Private m_IsDirty(78) As Boolean

        Private Function [Same](pValue1 As Object, pValue2 As Object) As Boolean
            If pValue1 Is Nothing And (Not pValue2 Is Nothing) Then
                Return False
            End If

            If (Not pValue1 Is Nothing) And pValue2 Is Nothing Then
                Return False
            End If

            If pValue1 <> pValue2 Then
                Return False
            End If

            Return True
        End Function

    End Class

    Public Interface IrowTblEzyUsers
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colUserID() As String
        Property colPassword() As String
        Property colFullName() As String
        Property colRiskManager() As Nullable(Of Boolean)
        Property colDivisionManager() As Nullable(Of Boolean)
        Property colDivision() As String
        Property colPlantManager() As Nullable(Of Boolean)
        Property colPlant() As String
        Property colAdministrator() As Nullable(Of Boolean)
        Property colDocumentAccess() As Nullable(Of Boolean)
        Property colCustomAccess() As Nullable(Of Boolean)
        Property colCustomAccessText() As String
        Property colOperatorStamp() As String
        Property colDateTimeStamp() As Nullable(Of DateTime)
        Property colPhone() As String
        Property colFax() As String
        Property colEmail() As String
        Property colNotificationStamp() As Nullable(Of DateTime)
        Property colActiveUser() As Nullable(Of Boolean)
        Property colFilePrefix() As Nullable(Of Short)
        Property colLastLogin() As Nullable(Of DateTime)
        Property colLastPWChange() As Nullable(Of DateTime)
        Property colInternal() As Nullable(Of Boolean)
        Property colComments() As String
        Property colRInit() As String
        Property colRfu1() As String
        Property colRfu2() As String
        Property colRfu3() As String
        Property colRReport() As String
        Property colROverdue1() As String
        Property colROverdue2() As String
        Property colROverdue3() As String
        Property colRActResp() As String
        Property colWo() As Nullable(Of Boolean)
        Property colCalist() As String
        Property colDivlist() As String
        Property colLoclist() As String
        Property colThirdParty() As Nullable(Of Boolean)
        Property colGRCAdministrator() As String
        Property colLastRecentUpdate() As Nullable(Of DateTime)
        Property colEzyUserID() As Nullable(Of Integer)
        Property colAllowMaintLogin() As Nullable(Of Boolean)
        Property colCCActive() As Nullable(Of Boolean)
        Property colExpOverdue() As String
        Property colEzyGuid() As String
        Property colSecurityPasswordIsExpired() As Nullable(Of Boolean)
        Property colSecurityAccountIsLockedOut() As Nullable(Of Boolean)
        Property colAutoInactiveDate() As Nullable(Of DateTime)
        Property colSecurityInactivityReminderSentDate() As Nullable(Of DateTime)
        Property colMultipleUserType() As String
        Property colImport() As String
        Property colClientLocNoManager() As Nullable(Of Boolean)
        Property colClientLocNoText() As String
        Property colFacilityManager() As Nullable(Of Boolean)
        Property colFacilityText() As String
        Property colCityManager() As Nullable(Of Boolean)
        Property colCityText() As String
        Property colStProvManager() As Nullable(Of Boolean)
        Property colStProvText() As String
        Property colCountryManager() As Nullable(Of Boolean)
        Property colCountryText() As String
        Property colRExpd() As String
        Property colCCOnly() As Nullable(Of Boolean)
        Property colLoginId() As Nullable(Of Integer)
        Property colLastReclassificationDate() As Nullable(Of DateTime)
        Property colLastReclassificationByLoginID() As Nullable(Of Integer)
        Property colLastReclassificationAction() As Nullable(Of Integer)
        Property colMarkedForDeletionDate() As Nullable(Of DateTime)
        Property colReclassificationDate() As Nullable(Of DateTime)
        Property colReclassificationByLoginID() As Nullable(Of Integer)
        Property colReclassificationAction() As Nullable(Of Integer)
        Property colClientComment() As String
        Property colSysUserCreated() As String
        Property colSysDateCreated() As Nullable(Of DateTime)
        Property colSysUserModified() As String
        Property colSysDateModified() As Nullable(Of DateTime)
        Property colClientAdministration() As Nullable(Of Boolean)
        Function IsDirty(pIndex As rowTblEzyUsers.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

