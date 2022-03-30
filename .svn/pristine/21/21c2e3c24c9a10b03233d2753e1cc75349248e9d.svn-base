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
    Partial Public Class TblEzyLogin

        Public Shared Sub Delete(ByRef pRowData As IrowTblEzyLogin)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblEzyLogin, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblEzyLogin, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblEzyLogin, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colLoginID) Then

				If UtilConfiguration.Auditing.AuditIsEnabled Then				
					pRowData.colSysUserModified=UtilConfiguration.Auditing.CurrentUserDelegate.Invoke()
					pRowData.colSysDateModified=Now()
					Save(pRowData,pTransaction,Nothing) 'Save the person who is deleting this record to the AuditUserModifiedColumnName column.
				End If

                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[ezy_Login] " & _
                        "WHERE [LoginID] = @colLoginID"

                Dim zCmd As New SQLCommand
                zCmd.CommandText = zSQL
                zCmd.Parameters.Add(New SQLParameter("@colLoginID", pRowData.colLoginID))

                zCmd.Transaction=pTransaction
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)

                pRowData.RaiseDeletedEvent(pDeleteEventUserState)

            End If

        End Sub

        Public Shared Sub Delete(pcolLoginID As Integer)
            Delete(pcolLoginID, Nothing, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolLoginID As Integer, pDeleteEventUserState As Object)
            Delete(pcolLoginID, Nothing, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Delete(pcolLoginID As Integer, ByRef pTransaction As SqlClient.SqlTransaction)
        Delete(pcolLoginID, pTransaction, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolLoginID As Integer, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
        Dim zObj As rowTblEzyLogin = LoadByPrimaryKey(pcolLoginID, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblEzyLogin)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblEzyLogin, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblEzyLogin, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colLoginID) Then

                zSQL = "SELECT COUNT(*) from [dbo].[ezy_Login] WHERE [LoginID] = @colLoginID"

                Dim zCmdDoesExist As New SQLCommand

                zCmdDoesExist.CommandText = zSQL

                zCmdDoesExist.Parameters.Add(new SQLParameter("@colLoginID", pRowData.colLoginID))

                'if zExistInDB > 0  then  PK exists in the DB
                zCmdDoesExist.Transaction = pTransaction
                zExistInDB = razor.UtilSQLServer.ExecuteScalar(zCmdDoesExist)
            End If

            If razor.UtilSQLServer.IsKeySet(pRowData.colLoginID) And zExistInDB > 0 Then
                zMode = "UPDATE"
				If UtilConfiguration.Auditing.AuditIsEnabled Then				
					pRowData.colSysUserModified=UtilConfiguration.Auditing.CurrentUserDelegate.Invoke()
					pRowData.colSysDateModified=Now()
					End If			
            End If
            If razor.UtilSQLServer.IsKeySet(pRowData.colLoginID) And zExistInDB = 0 Then
                zMode = "INSERTwithKey"
				If UtilConfiguration.Auditing.AuditIsEnabled Then
					pRowData.colSysUserCreated=UtilConfiguration.Auditing.CurrentUserDelegate.Invoke()
					pRowData.colSysDateCreated=Now()
				End If
            End If
            If Not razor.UtilSQLServer.IsKeySet(pRowData.colLoginID) Then
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
                        zUpdate = "UPDATE [dbo].[ezy_Login] SET " 
                        If pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colEmailAddress) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [EmailAddress] = @colEmailAddress "
                        End If
                        If pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colFullName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [FullName] = @colFullName "
                        End If
                        If pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colPassword) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [Password] = @colPassword "
                        End If
                        If pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colActiveFlag) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ActiveFlag] = @colActiveFlag "
                        End If
                        If pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colMarkForDeletionDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [MarkForDeletionDate] = @colMarkForDeletionDate "
                        End If
                        If pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colComments) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [Comments] = @colComments "
                        End If
                        If pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colLoginGuid) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [LoginGuid] = @colLoginGuid "
                        End If
                        If pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colInactivityReminderSentDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [InactivityReminderSentDate] = @colInactivityReminderSentDate "
                        End If
                        If pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colIsLockedOut) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [IsLockedOut] = @colIsLockedOut "
                        End If
                        If pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colPasswordIsExpired) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [PasswordIsExpired] = @colPasswordIsExpired "
                        End If
                        If pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colLastPasswordChangeDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [LastPasswordChangeDate] = @colLastPasswordChangeDate "
                        End If
                        If pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colLastLoginDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [LastLoginDate] = @colLastLoginDate "
                        End If
                        If pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colLastPasswordResetRequestDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [LastPasswordResetRequestDate] = @colLastPasswordResetRequestDate "
                        End If
                        If pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colLastFailedLoginDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [LastFailedLoginDate] = @colLastFailedLoginDate "
                        End If
                        If pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colInternal) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [Internal] = @colInternal "
                        End If
                        If pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colPasswordReminderSentFlag) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [PasswordReminderSentFlag] = @colPasswordReminderSentFlag "
                        End If
                        If pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colFailedLoginStrikeStartDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [FailedLoginStrikeStartDate] = @colFailedLoginStrikeStartDate "
                        End If
                        If pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colFailedLoginStrikeCount) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [FailedLoginStrikeCount] = @colFailedLoginStrikeCount "
                        End If
                        If pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colAllowReclassLoginOverride) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [AllowReclassLoginOverride] = @colAllowReclassLoginOverride "
                        End If
                        If pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colSysUserCreated) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [SysUserCreated] = @colSysUserCreated "
                        End If
                        If pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colSysDateCreated) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [SysDateCreated] = @colSysDateCreated "
                        End If
                        If pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colSysUserModified) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [SysUserModified] = @colSysUserModified "
                        End If
                        If pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colSysDateModified) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [SysDateModified] = @colSysDateModified "
                        End If
                        If pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colWhatsNewLastReviewedDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [WhatsNewLastReviewedDate] = @colWhatsNewLastReviewedDate "
                        End If
                        zWhere = " WHERE [LoginID] = @colLoginID"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[ezy_Login] ([EmailAddress], [FullName], [Password], [ActiveFlag], [MarkForDeletionDate], [Comments], [LoginGuid], [InactivityReminderSentDate], [IsLockedOut], [PasswordIsExpired], [LastPasswordChangeDate], [LastLoginDate], [LastPasswordResetRequestDate], [LastFailedLoginDate], [Internal], [PasswordReminderSentFlag], [FailedLoginStrikeStartDate], [FailedLoginStrikeCount], [AllowReclassLoginOverride], [SysUserCreated], [SysDateCreated], [SysUserModified], [SysDateModified], [WhatsNewLastReviewedDate])" & _
                            " VALUES (@colEmailAddress, @colFullName, @colPassword, @colActiveFlag, @colMarkForDeletionDate, @colComments, @colLoginGuid, @colInactivityReminderSentDate, @colIsLockedOut, @colPasswordIsExpired, @colLastPasswordChangeDate, @colLastLoginDate, @colLastPasswordResetRequestDate, @colLastFailedLoginDate, @colInternal, @colPasswordReminderSentFlag, @colFailedLoginStrikeStartDate, @colFailedLoginStrikeCount, @colAllowReclassLoginOverride, @colSysUserCreated, @colSysDateCreated, @colSysUserModified, @colSysDateModified, @colWhatsNewLastReviewedDate); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[ezy_Login] ([EmailAddress], [FullName], [Password], [ActiveFlag], [MarkForDeletionDate], [Comments], [LoginGuid], [InactivityReminderSentDate], [IsLockedOut], [PasswordIsExpired], [LastPasswordChangeDate], [LastLoginDate], [LastPasswordResetRequestDate], [LastFailedLoginDate], [Internal], [PasswordReminderSentFlag], [FailedLoginStrikeStartDate], [FailedLoginStrikeCount], [AllowReclassLoginOverride], [SysUserCreated], [SysDateCreated], [SysUserModified], [SysDateModified], [WhatsNewLastReviewedDate])" & _
                            " VALUES (@colEmailAddress, @colFullName, @colPassword, @colActiveFlag, @colMarkForDeletionDate, @colComments, @colLoginGuid, @colInactivityReminderSentDate, @colIsLockedOut, @colPasswordIsExpired, @colLastPasswordChangeDate, @colLastLoginDate, @colLastPasswordResetRequestDate, @colLastFailedLoginDate, @colInternal, @colPasswordReminderSentFlag, @colFailedLoginStrikeStartDate, @colFailedLoginStrikeCount, @colAllowReclassLoginOverride, @colSysUserCreated, @colSysDateCreated, @colSysUserModified, @colSysDateModified, @colWhatsNewLastReviewedDate); SELECT SCOPE_IDENTITY()"
                Case Else
            End Select

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

			'IF UPDATE, SET PK PARAMETER
            If zMode = "UPDATE" Then
                zCmd.Parameters.Add(New SQLParameter("@colLoginID", pRowData.colLoginID))
            End If

			'IF INSERTING, KEY HAS VALUE AND KEY IS NOT IDENTITY, SET PK PARAMETER
			If zMode = "INSERTwithKey" Then
            End If

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colEmailAddress) Then
                    zCmd.Parameters.Add(New SqlParameter("@colEmailAddress", IIf(pRowData.colEmailAddress Is Nothing, DBNull.Value, pRowData.colEmailAddress)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colFullName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFullName", IIf(pRowData.colFullName Is Nothing, DBNull.Value, pRowData.colFullName)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colPassword) Then
                    zCmd.Parameters.Add(New SqlParameter("@colPassword", IIf(pRowData.colPassword Is Nothing, DBNull.Value, pRowData.colPassword)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colActiveFlag) Then
                    zCmd.Parameters.Add(New SqlParameter("@colActiveFlag", IIf(pRowData.colActiveFlag Is Nothing, DBNull.Value, pRowData.colActiveFlag)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colMarkForDeletionDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colMarkForDeletionDate", IIf(pRowData.colMarkForDeletionDate Is Nothing, DBNull.Value, pRowData.colMarkForDeletionDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colComments) Then
                    zCmd.Parameters.Add(New SqlParameter("@colComments", IIf(pRowData.colComments Is Nothing, DBNull.Value, pRowData.colComments)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colLoginGuid) Then
                    zCmd.Parameters.Add(New SqlParameter("@colLoginGuid", IIf(pRowData.colLoginGuid Is Nothing, DBNull.Value, pRowData.colLoginGuid)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colInactivityReminderSentDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colInactivityReminderSentDate", IIf(pRowData.colInactivityReminderSentDate Is Nothing, DBNull.Value, pRowData.colInactivityReminderSentDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colIsLockedOut) Then
                    zCmd.Parameters.Add(New SqlParameter("@colIsLockedOut", IIf(pRowData.colIsLockedOut Is Nothing, DBNull.Value, pRowData.colIsLockedOut)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colPasswordIsExpired) Then
                    zCmd.Parameters.Add(New SqlParameter("@colPasswordIsExpired", IIf(pRowData.colPasswordIsExpired Is Nothing, DBNull.Value, pRowData.colPasswordIsExpired)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colLastPasswordChangeDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colLastPasswordChangeDate", IIf(pRowData.colLastPasswordChangeDate Is Nothing, DBNull.Value, pRowData.colLastPasswordChangeDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colLastLoginDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colLastLoginDate", IIf(pRowData.colLastLoginDate Is Nothing, DBNull.Value, pRowData.colLastLoginDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colLastPasswordResetRequestDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colLastPasswordResetRequestDate", IIf(pRowData.colLastPasswordResetRequestDate Is Nothing, DBNull.Value, pRowData.colLastPasswordResetRequestDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colLastFailedLoginDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colLastFailedLoginDate", IIf(pRowData.colLastFailedLoginDate Is Nothing, DBNull.Value, pRowData.colLastFailedLoginDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colInternal) Then
                    zCmd.Parameters.Add(New SqlParameter("@colInternal", IIf(pRowData.colInternal Is Nothing, DBNull.Value, pRowData.colInternal)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colPasswordReminderSentFlag) Then
                    zCmd.Parameters.Add(New SqlParameter("@colPasswordReminderSentFlag", IIf(pRowData.colPasswordReminderSentFlag Is Nothing, DBNull.Value, pRowData.colPasswordReminderSentFlag)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colFailedLoginStrikeStartDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFailedLoginStrikeStartDate", IIf(pRowData.colFailedLoginStrikeStartDate Is Nothing, DBNull.Value, pRowData.colFailedLoginStrikeStartDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colFailedLoginStrikeCount) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFailedLoginStrikeCount", IIf(pRowData.colFailedLoginStrikeCount Is Nothing, DBNull.Value, pRowData.colFailedLoginStrikeCount)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colAllowReclassLoginOverride) Then
                    zCmd.Parameters.Add(New SqlParameter("@colAllowReclassLoginOverride", IIf(pRowData.colAllowReclassLoginOverride Is Nothing, DBNull.Value, pRowData.colAllowReclassLoginOverride)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colSysUserCreated) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSysUserCreated", IIf(pRowData.colSysUserCreated Is Nothing, DBNull.Value, pRowData.colSysUserCreated)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colSysDateCreated) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSysDateCreated", IIf(pRowData.colSysDateCreated Is Nothing, DBNull.Value, pRowData.colSysDateCreated)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colSysUserModified) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSysUserModified", IIf(pRowData.colSysUserModified Is Nothing, DBNull.Value, pRowData.colSysUserModified)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colSysDateModified) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSysDateModified", IIf(pRowData.colSysDateModified Is Nothing, DBNull.Value, pRowData.colSysDateModified)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyLogin.FieldIndex.colWhatsNewLastReviewedDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colWhatsNewLastReviewedDate", IIf(pRowData.colWhatsNewLastReviewedDate Is Nothing, DBNull.Value, pRowData.colWhatsNewLastReviewedDate)))
                End If

            zCmd.Transaction=pTransaction
            If zMode = "INSERTnoKey" Then
                Dim zLastId As Long = 0
                zLastId = razor.UtilSQLServer.ExecuteNonQueryRowId(zCmd)

                pRowData.colLoginID = zLastId
            Else
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)
            End If

            pRowData.SetIsDirty(False)
            pRowData.RaiseSavedEvent(pSavedEventUserState)

		End If

        End Sub

        Public Shared Function LoadByPrimaryKey(pcolLoginID As Integer) As rowTblEzyLogin
            Return LoadByPrimaryKey(pcolLoginID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolLoginID As Integer, pLoadEventUserState As Object) As rowTblEzyLogin
            Return LoadByPrimaryKey(pcolLoginID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolLoginID As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblEzyLogin
            Return LoadByPrimaryKey(pcolLoginID, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolLoginID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblEzyLogin
            Dim zReturn As New rowTblEzyLogin
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_Login] WHERE [LoginID] = @colLoginID"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colLoginID", pcolLoginID))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblEzyLogin) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_IX_ezyLogin_EmailAddress(pcolEmailAddress As String) As List(Of rowTblEzyLogin)
            Return LoadByIDX_IX_ezyLogin_EmailAddress(pcolEmailAddress, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_ezyLogin_EmailAddress(pcolEmailAddress As String, pLoadEventUserState As Object) As List(Of rowTblEzyLogin)
            Return LoadByIDX_IX_ezyLogin_EmailAddress(pcolEmailAddress, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_ezyLogin_EmailAddress(pcolEmailAddress As String, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblEzyLogin)
            Return LoadByIDX_IX_ezyLogin_EmailAddress(pcolEmailAddress, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_ezyLogin_EmailAddress(pcolEmailAddress As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblEzyLogin)
            Dim zReturn As New List(Of rowTblEzyLogin)
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_Login] WHERE [EmailAddress] = @colEmailAddress"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colEmailAddress", pcolEmailAddress))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function
        Public Shared Function LoadByIDX_PK__tmp_ms_x__4DDA2838726946F3(pcolLoginID As Integer) As List(Of rowTblEzyLogin)
            Return LoadByIDX_PK__tmp_ms_x__4DDA2838726946F3(pcolLoginID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tmp_ms_x__4DDA2838726946F3(pcolLoginID As Integer, pLoadEventUserState As Object) As List(Of rowTblEzyLogin)
            Return LoadByIDX_PK__tmp_ms_x__4DDA2838726946F3(pcolLoginID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tmp_ms_x__4DDA2838726946F3(pcolLoginID As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblEzyLogin)
            Return LoadByIDX_PK__tmp_ms_x__4DDA2838726946F3(pcolLoginID, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tmp_ms_x__4DDA2838726946F3(pcolLoginID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblEzyLogin)
            Dim zReturn As New List(Of rowTblEzyLogin)
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_Login] WHERE [LoginID] = @colLoginID"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colLoginID", pcolLoginID))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblEzyLogin)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblEzyLogin)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblEzyLogin)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblEzyLogin)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblEzyLogin)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblEzyLogin)
            Dim zReturn As New List(Of rowTblEzyLogin)
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_Login]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblEzyLogin)

			Try
	            Dim zReturn As New List(Of rowTblEzyLogin)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblEzyLogin

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblEzyLogin		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblEzyLogin)
			If Not pReader.IsDBNull(pReader.GetOrdinal("LoginID")) Then pObject.colLoginID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "LoginID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("EmailAddress")) Then pObject.colEmailAddress = UtilSQLServer.SafeReader.SafeReadString(pReader, "EmailAddress")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FullName")) Then pObject.colFullName = UtilSQLServer.SafeReader.SafeReadString(pReader, "FullName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Password")) Then pObject.colPassword = UtilSQLServer.SafeReader.SafeReadString(pReader, "Password")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ActiveFlag")) Then pObject.colActiveFlag = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "ActiveFlag")
			If Not pReader.IsDBNull(pReader.GetOrdinal("MarkForDeletionDate")) Then pObject.colMarkForDeletionDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "MarkForDeletionDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Comments")) Then pObject.colComments = UtilSQLServer.SafeReader.SafeReadString(pReader, "Comments")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LoginGuid")) Then pObject.colLoginGuid = UtilSQLServer.SafeReader.SafeReadString(pReader, "LoginGuid")
			If Not pReader.IsDBNull(pReader.GetOrdinal("InactivityReminderSentDate")) Then pObject.colInactivityReminderSentDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "InactivityReminderSentDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("IsLockedOut")) Then pObject.colIsLockedOut = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "IsLockedOut")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PasswordIsExpired")) Then pObject.colPasswordIsExpired = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "PasswordIsExpired")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LastPasswordChangeDate")) Then pObject.colLastPasswordChangeDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "LastPasswordChangeDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LastLoginDate")) Then pObject.colLastLoginDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "LastLoginDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LastPasswordResetRequestDate")) Then pObject.colLastPasswordResetRequestDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "LastPasswordResetRequestDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LastFailedLoginDate")) Then pObject.colLastFailedLoginDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "LastFailedLoginDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Internal")) Then pObject.colInternal = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "Internal")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PasswordReminderSentFlag")) Then pObject.colPasswordReminderSentFlag = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "PasswordReminderSentFlag")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FailedLoginStrikeStartDate")) Then pObject.colFailedLoginStrikeStartDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "FailedLoginStrikeStartDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FailedLoginStrikeCount")) Then pObject.colFailedLoginStrikeCount = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "FailedLoginStrikeCount")
			If Not pReader.IsDBNull(pReader.GetOrdinal("AllowReclassLoginOverride")) Then pObject.colAllowReclassLoginOverride = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "AllowReclassLoginOverride")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SysUserCreated")) Then pObject.colSysUserCreated = UtilSQLServer.SafeReader.SafeReadString(pReader, "SysUserCreated")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SysDateCreated")) Then pObject.colSysDateCreated = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "SysDateCreated")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SysUserModified")) Then pObject.colSysUserModified = UtilSQLServer.SafeReader.SafeReadString(pReader, "SysUserModified")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SysDateModified")) Then pObject.colSysDateModified = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "SysDateModified")
			If Not pReader.IsDBNull(pReader.GetOrdinal("WhatsNewLastReviewedDate")) Then pObject.colWhatsNewLastReviewedDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "WhatsNewLastReviewedDate")
			pObject.SetIsDirty(False)
			Return pObject
		End	 Function

    #Region "Reflection Based Load Functions"

        Public Shared Function LoadByPrimaryKey(Of T)(pcolLoginID As Integer) As T
            Return LoadByPrimaryKey(Of T)(pcolLoginID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolLoginID As Integer, pLoadEventUserState As Object) As T
            Return LoadByPrimaryKey(Of T)(pcolLoginID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolLoginID As Integer, pTransaction As SqlClient.SqlTransaction) As T
            Return LoadByPrimaryKey(Of T)(pcolLoginID, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolLoginID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As T

            Dim zReturn As Object = Activator.CreateInstance(Of T)()
            If Not TypeOf zReturn Is rowTblEzyLogin Then Throw New ArgumentException("Generic type is not type of rowTblEzyLogin.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_Login] WHERE [LoginID] = @colLoginID"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colLoginID", pcolLoginID))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of T) = ReadData(Of T)(zCmd, pLoadEventUserState)
            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

        End Function

        Public Shared Function LoadByIDX_IX_ezyLogin_EmailAddress(Of T)(pcolEmailAddress As String) As List(Of T)
            Return LoadByIDX_IX_ezyLogin_EmailAddress(Of T)(pcolEmailAddress, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_ezyLogin_EmailAddress(Of T)(pcolEmailAddress As String, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_IX_ezyLogin_EmailAddress(Of T)(pcolEmailAddress, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_ezyLogin_EmailAddress(Of T)(pcolEmailAddress As String, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_IX_ezyLogin_EmailAddress(Of T)(pcolEmailAddress, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_IX_ezyLogin_EmailAddress(Of T)(pcolEmailAddress As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_Login] WHERE [EmailAddress] = @colEmailAddress"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colEmailAddress", pcolEmailAddress))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_PK__tmp_ms_x__4DDA2838726946F3(Of T)(pcolLoginID As Integer) As List(Of T)
            Return LoadByIDX_PK__tmp_ms_x__4DDA2838726946F3(Of T)(pcolLoginID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tmp_ms_x__4DDA2838726946F3(Of T)(pcolLoginID As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK__tmp_ms_x__4DDA2838726946F3(Of T)(pcolLoginID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tmp_ms_x__4DDA2838726946F3(Of T)(pcolLoginID As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK__tmp_ms_x__4DDA2838726946F3(Of T)(pcolLoginID, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK__tmp_ms_x__4DDA2838726946F3(Of T)(pcolLoginID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_Login] WHERE [LoginID] = @colLoginID"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colLoginID", pcolLoginID))

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
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_Login]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblEzyLogin
        Implements IrowTblEzyLogin

        Public Event Loaded(pUserState As Object) Implements IrowTblEzyLogin.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblEzyLogin.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblEzyLogin.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblEzyLogin.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblEzyLogin.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblEzyLogin.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colLoginID() As Nullable(Of Integer) Implements IrowTblEzyLogin.colLoginID
            Get
                Return m_colLoginID
            End Get
            Set
                If Not Same(m_colLoginID, Value) Then
                    m_colLoginID = Value
                    m_IsDirty(FieldIndex.colLoginID) = True
                End If
            End Set
        End Property
        Private m_colLoginID As Nullable(Of Integer)

        Public Property colEmailAddress() As String Implements IrowTblEzyLogin.colEmailAddress
            Get
                Return m_colEmailAddress
            End Get
            Set
                If Not Same(m_colEmailAddress, Value) Then
                    m_colEmailAddress = Value
                    m_IsDirty(FieldIndex.colEmailAddress) = True
                End If
            End Set
        End Property
        Private m_colEmailAddress As String

        Public Property colFullName() As String Implements IrowTblEzyLogin.colFullName
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

        Public Property colPassword() As String Implements IrowTblEzyLogin.colPassword
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

        Public Property colActiveFlag() As Nullable(Of Boolean) Implements IrowTblEzyLogin.colActiveFlag
            Get
                Return m_colActiveFlag
            End Get
            Set
                If Not Same(m_colActiveFlag, Value) Then
                    m_colActiveFlag = Value
                    m_IsDirty(FieldIndex.colActiveFlag) = True
                End If
            End Set
        End Property
        Private m_colActiveFlag As Nullable(Of Boolean)

        Public Property colMarkForDeletionDate() As Nullable(Of DateTime) Implements IrowTblEzyLogin.colMarkForDeletionDate
            Get
                Return m_colMarkForDeletionDate
            End Get
            Set
                If Not Same(m_colMarkForDeletionDate, Value) Then
                    m_colMarkForDeletionDate = Value
                    m_IsDirty(FieldIndex.colMarkForDeletionDate) = True
                End If
            End Set
        End Property
        Private m_colMarkForDeletionDate As Nullable(Of DateTime)

        Public Property colComments() As String Implements IrowTblEzyLogin.colComments
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

        Public Property colLoginGuid() As String Implements IrowTblEzyLogin.colLoginGuid
            Get
                Return m_colLoginGuid
            End Get
            Set
                If Not Same(m_colLoginGuid, Value) Then
                    m_colLoginGuid = Value
                    m_IsDirty(FieldIndex.colLoginGuid) = True
                End If
            End Set
        End Property
        Private m_colLoginGuid As String

        Public Property colInactivityReminderSentDate() As Nullable(Of DateTime) Implements IrowTblEzyLogin.colInactivityReminderSentDate
            Get
                Return m_colInactivityReminderSentDate
            End Get
            Set
                If Not Same(m_colInactivityReminderSentDate, Value) Then
                    m_colInactivityReminderSentDate = Value
                    m_IsDirty(FieldIndex.colInactivityReminderSentDate) = True
                End If
            End Set
        End Property
        Private m_colInactivityReminderSentDate As Nullable(Of DateTime)

        Public Property colIsLockedOut() As Nullable(Of Boolean) Implements IrowTblEzyLogin.colIsLockedOut
            Get
                Return m_colIsLockedOut
            End Get
            Set
                If Not Same(m_colIsLockedOut, Value) Then
                    m_colIsLockedOut = Value
                    m_IsDirty(FieldIndex.colIsLockedOut) = True
                End If
            End Set
        End Property
        Private m_colIsLockedOut As Nullable(Of Boolean)

        Public Property colPasswordIsExpired() As Nullable(Of Boolean) Implements IrowTblEzyLogin.colPasswordIsExpired
            Get
                Return m_colPasswordIsExpired
            End Get
            Set
                If Not Same(m_colPasswordIsExpired, Value) Then
                    m_colPasswordIsExpired = Value
                    m_IsDirty(FieldIndex.colPasswordIsExpired) = True
                End If
            End Set
        End Property
        Private m_colPasswordIsExpired As Nullable(Of Boolean)

        Public Property colLastPasswordChangeDate() As Nullable(Of DateTime) Implements IrowTblEzyLogin.colLastPasswordChangeDate
            Get
                Return m_colLastPasswordChangeDate
            End Get
            Set
                If Not Same(m_colLastPasswordChangeDate, Value) Then
                    m_colLastPasswordChangeDate = Value
                    m_IsDirty(FieldIndex.colLastPasswordChangeDate) = True
                End If
            End Set
        End Property
        Private m_colLastPasswordChangeDate As Nullable(Of DateTime)

        Public Property colLastLoginDate() As Nullable(Of DateTime) Implements IrowTblEzyLogin.colLastLoginDate
            Get
                Return m_colLastLoginDate
            End Get
            Set
                If Not Same(m_colLastLoginDate, Value) Then
                    m_colLastLoginDate = Value
                    m_IsDirty(FieldIndex.colLastLoginDate) = True
                End If
            End Set
        End Property
        Private m_colLastLoginDate As Nullable(Of DateTime)

        Public Property colLastPasswordResetRequestDate() As Nullable(Of DateTime) Implements IrowTblEzyLogin.colLastPasswordResetRequestDate
            Get
                Return m_colLastPasswordResetRequestDate
            End Get
            Set
                If Not Same(m_colLastPasswordResetRequestDate, Value) Then
                    m_colLastPasswordResetRequestDate = Value
                    m_IsDirty(FieldIndex.colLastPasswordResetRequestDate) = True
                End If
            End Set
        End Property
        Private m_colLastPasswordResetRequestDate As Nullable(Of DateTime)

        Public Property colLastFailedLoginDate() As Nullable(Of DateTime) Implements IrowTblEzyLogin.colLastFailedLoginDate
            Get
                Return m_colLastFailedLoginDate
            End Get
            Set
                If Not Same(m_colLastFailedLoginDate, Value) Then
                    m_colLastFailedLoginDate = Value
                    m_IsDirty(FieldIndex.colLastFailedLoginDate) = True
                End If
            End Set
        End Property
        Private m_colLastFailedLoginDate As Nullable(Of DateTime)

        Public Property colInternal() As Nullable(Of Boolean) Implements IrowTblEzyLogin.colInternal
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

        Public Property colPasswordReminderSentFlag() As Nullable(Of Integer) Implements IrowTblEzyLogin.colPasswordReminderSentFlag
            Get
                Return m_colPasswordReminderSentFlag
            End Get
            Set
                If Not Same(m_colPasswordReminderSentFlag, Value) Then
                    m_colPasswordReminderSentFlag = Value
                    m_IsDirty(FieldIndex.colPasswordReminderSentFlag) = True
                End If
            End Set
        End Property
        Private m_colPasswordReminderSentFlag As Nullable(Of Integer)

        Public Property colFailedLoginStrikeStartDate() As Nullable(Of DateTime) Implements IrowTblEzyLogin.colFailedLoginStrikeStartDate
            Get
                Return m_colFailedLoginStrikeStartDate
            End Get
            Set
                If Not Same(m_colFailedLoginStrikeStartDate, Value) Then
                    m_colFailedLoginStrikeStartDate = Value
                    m_IsDirty(FieldIndex.colFailedLoginStrikeStartDate) = True
                End If
            End Set
        End Property
        Private m_colFailedLoginStrikeStartDate As Nullable(Of DateTime)

        Public Property colFailedLoginStrikeCount() As Nullable(Of Integer) Implements IrowTblEzyLogin.colFailedLoginStrikeCount
            Get
                Return m_colFailedLoginStrikeCount
            End Get
            Set
                If Not Same(m_colFailedLoginStrikeCount, Value) Then
                    m_colFailedLoginStrikeCount = Value
                    m_IsDirty(FieldIndex.colFailedLoginStrikeCount) = True
                End If
            End Set
        End Property
        Private m_colFailedLoginStrikeCount As Nullable(Of Integer)

        Public Property colAllowReclassLoginOverride() As Nullable(Of Boolean) Implements IrowTblEzyLogin.colAllowReclassLoginOverride
            Get
                Return m_colAllowReclassLoginOverride
            End Get
            Set
                If Not Same(m_colAllowReclassLoginOverride, Value) Then
                    m_colAllowReclassLoginOverride = Value
                    m_IsDirty(FieldIndex.colAllowReclassLoginOverride) = True
                End If
            End Set
        End Property
        Private m_colAllowReclassLoginOverride As Nullable(Of Boolean)

        Public Property colSysUserCreated() As String Implements IrowTblEzyLogin.colSysUserCreated
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

        Public Property colSysDateCreated() As Nullable(Of DateTime) Implements IrowTblEzyLogin.colSysDateCreated
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

        Public Property colSysUserModified() As String Implements IrowTblEzyLogin.colSysUserModified
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

        Public Property colSysDateModified() As Nullable(Of DateTime) Implements IrowTblEzyLogin.colSysDateModified
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

        Public Property colWhatsNewLastReviewedDate() As Nullable(Of DateTime) Implements IrowTblEzyLogin.colWhatsNewLastReviewedDate
            Get
                Return m_colWhatsNewLastReviewedDate
            End Get
            Set
                If Not Same(m_colWhatsNewLastReviewedDate, Value) Then
                    m_colWhatsNewLastReviewedDate = Value
                    m_IsDirty(FieldIndex.colWhatsNewLastReviewedDate) = True
                End If
            End Set
        End Property
        Private m_colWhatsNewLastReviewedDate As Nullable(Of DateTime)


        Public Function IsDirty(pIndex As rowTblEzyLogin.FieldIndex) As Boolean Implements IrowTblEzyLogin.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblEzyLogin.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblEzyLogin.SetIsDirty
            m_IsDirty(FieldIndex.colLoginID) = pDirty
            m_IsDirty(FieldIndex.colEmailAddress) = pDirty
            m_IsDirty(FieldIndex.colFullName) = pDirty
            m_IsDirty(FieldIndex.colPassword) = pDirty
            m_IsDirty(FieldIndex.colActiveFlag) = pDirty
            m_IsDirty(FieldIndex.colMarkForDeletionDate) = pDirty
            m_IsDirty(FieldIndex.colComments) = pDirty
            m_IsDirty(FieldIndex.colLoginGuid) = pDirty
            m_IsDirty(FieldIndex.colInactivityReminderSentDate) = pDirty
            m_IsDirty(FieldIndex.colIsLockedOut) = pDirty
            m_IsDirty(FieldIndex.colPasswordIsExpired) = pDirty
            m_IsDirty(FieldIndex.colLastPasswordChangeDate) = pDirty
            m_IsDirty(FieldIndex.colLastLoginDate) = pDirty
            m_IsDirty(FieldIndex.colLastPasswordResetRequestDate) = pDirty
            m_IsDirty(FieldIndex.colLastFailedLoginDate) = pDirty
            m_IsDirty(FieldIndex.colInternal) = pDirty
            m_IsDirty(FieldIndex.colPasswordReminderSentFlag) = pDirty
            m_IsDirty(FieldIndex.colFailedLoginStrikeStartDate) = pDirty
            m_IsDirty(FieldIndex.colFailedLoginStrikeCount) = pDirty
            m_IsDirty(FieldIndex.colAllowReclassLoginOverride) = pDirty
            m_IsDirty(FieldIndex.colSysUserCreated) = pDirty
            m_IsDirty(FieldIndex.colSysDateCreated) = pDirty
            m_IsDirty(FieldIndex.colSysUserModified) = pDirty
            m_IsDirty(FieldIndex.colSysDateModified) = pDirty
            m_IsDirty(FieldIndex.colWhatsNewLastReviewedDate) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblEzyLogin) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblEzyLogin
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colLoginID  = 1
            colEmailAddress 
            colFullName 
            colPassword 
            colActiveFlag 
            colMarkForDeletionDate 
            colComments 
            colLoginGuid 
            colInactivityReminderSentDate 
            colIsLockedOut 
            colPasswordIsExpired 
            colLastPasswordChangeDate 
            colLastLoginDate 
            colLastPasswordResetRequestDate 
            colLastFailedLoginDate 
            colInternal 
            colPasswordReminderSentFlag 
            colFailedLoginStrikeStartDate 
            colFailedLoginStrikeCount 
            colAllowReclassLoginOverride 
            colSysUserCreated 
            colSysDateCreated 
            colSysUserModified 
            colSysDateModified 
            colWhatsNewLastReviewedDate 
        End Enum

        Private m_IsDirty(25) As Boolean

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

    Public Interface IrowTblEzyLogin
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colLoginID() As Nullable(Of Integer)
        Property colEmailAddress() As String
        Property colFullName() As String
        Property colPassword() As String
        Property colActiveFlag() As Nullable(Of Boolean)
        Property colMarkForDeletionDate() As Nullable(Of DateTime)
        Property colComments() As String
        Property colLoginGuid() As String
        Property colInactivityReminderSentDate() As Nullable(Of DateTime)
        Property colIsLockedOut() As Nullable(Of Boolean)
        Property colPasswordIsExpired() As Nullable(Of Boolean)
        Property colLastPasswordChangeDate() As Nullable(Of DateTime)
        Property colLastLoginDate() As Nullable(Of DateTime)
        Property colLastPasswordResetRequestDate() As Nullable(Of DateTime)
        Property colLastFailedLoginDate() As Nullable(Of DateTime)
        Property colInternal() As Nullable(Of Boolean)
        Property colPasswordReminderSentFlag() As Nullable(Of Integer)
        Property colFailedLoginStrikeStartDate() As Nullable(Of DateTime)
        Property colFailedLoginStrikeCount() As Nullable(Of Integer)
        Property colAllowReclassLoginOverride() As Nullable(Of Boolean)
        Property colSysUserCreated() As String
        Property colSysDateCreated() As Nullable(Of DateTime)
        Property colSysUserModified() As String
        Property colSysDateModified() As Nullable(Of DateTime)
        Property colWhatsNewLastReviewedDate() As Nullable(Of DateTime)
        Function IsDirty(pIndex As rowTblEzyLogin.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

