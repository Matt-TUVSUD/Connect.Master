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
    Partial Public Class TblClients

        Public Shared Sub Delete(ByRef pRowData As IrowTblClients)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblClients, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblClients, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblClients, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFileprefix) Then

				If UtilConfiguration.Auditing.AuditIsEnabled Then				
					pRowData.colSysUserModified=UtilConfiguration.Auditing.CurrentUserDelegate.Invoke()
					pRowData.colSysDateModified=Now()
					Save(pRowData,pTransaction,Nothing) 'Save the person who is deleting this record to the AuditUserModifiedColumnName column.
				End If

                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[clients] " & _
                        "WHERE [fileprefix] = @colFileprefix"

                Dim zCmd As New SQLCommand
                zCmd.CommandText = zSQL
                zCmd.Parameters.Add(New SQLParameter("@colFileprefix", pRowData.colFileprefix))

                zCmd.Transaction=pTransaction
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)

                pRowData.RaiseDeletedEvent(pDeleteEventUserState)

            End If

        End Sub

        Public Shared Sub Delete(pcolFileprefix As String)
            Delete(pcolFileprefix, Nothing, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolFileprefix As String, pDeleteEventUserState As Object)
            Delete(pcolFileprefix, Nothing, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Delete(pcolFileprefix As String, ByRef pTransaction As SqlClient.SqlTransaction)
        Delete(pcolFileprefix, pTransaction, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolFileprefix As String, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
        Dim zObj As rowTblClients = LoadByPrimaryKey(pcolFileprefix, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblClients)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblClients, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblClients, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFileprefix) Then

                zSQL = "SELECT COUNT(*) from [dbo].[clients] WHERE [fileprefix] = @colFileprefix"

                Dim zCmdDoesExist As New SQLCommand

                zCmdDoesExist.CommandText = zSQL

                zCmdDoesExist.Parameters.Add(new SQLParameter("@colFileprefix", pRowData.colFileprefix))

                'if zExistInDB > 0  then  PK exists in the DB
                zCmdDoesExist.Transaction = pTransaction
                zExistInDB = razor.UtilSQLServer.ExecuteScalar(zCmdDoesExist)
            End If

            If razor.UtilSQLServer.IsKeySet(pRowData.colFileprefix) And zExistInDB > 0 Then
                zMode = "UPDATE"
				If UtilConfiguration.Auditing.AuditIsEnabled Then				
					pRowData.colSysUserModified=UtilConfiguration.Auditing.CurrentUserDelegate.Invoke()
					pRowData.colSysDateModified=Now()
					End If			
            End If
            If razor.UtilSQLServer.IsKeySet(pRowData.colFileprefix) And zExistInDB = 0 Then
                zMode = "INSERTwithKey"
				If UtilConfiguration.Auditing.AuditIsEnabled Then
					pRowData.colSysUserCreated=UtilConfiguration.Auditing.CurrentUserDelegate.Invoke()
					pRowData.colSysDateCreated=Now()
				End If
            End If
            If Not razor.UtilSQLServer.IsKeySet(pRowData.colFileprefix) Then
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
                        zUpdate = "UPDATE [dbo].[clients] SET " 
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colCldbname) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [cldbname] = @colCldbname "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colClientname) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [clientname] = @colClientname "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colFeatures) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [features] = @colFeatures "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colClientdesigneenotify) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [clientdesigneenotify] = @colClientdesigneenotify "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colClientdesigneename) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [clientdesigneename] = @colClientdesigneename "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colClientdesigneeemail) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [clientdesigneeemail] = @colClientdesigneeemail "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colActive) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [580active] = @colActive "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colRecrespemail) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [recrespemail] = @colRecrespemail "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colRecautofollowup) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [recautofollowup] = @colRecautofollowup "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colRecfollowup1) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [recfollowup1] = @colRecfollowup1 "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colRecfollowup2) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [recfollowup2] = @colRecfollowup2 "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colRecfollowup3) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [recfollowup3] = @colRecfollowup3 "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colDatatransfer) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [datatransfer] = @colDatatransfer "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colAutoRecStartDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [AutoRecStartDate] = @colAutoRecStartDate "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colAutoRecComments) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [AutoRecComments] = @colAutoRecComments "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colFireRatingKeyID) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [FireRatingKeyID] = @colFireRatingKeyID "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colBMRatingKeyID) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [BMRatingKeyID] = @colBMRatingKeyID "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colCustomAccessLabel) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [CustomAccessLabel] = @colCustomAccessLabel "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colWORecipientName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [WORecipientName] = @colWORecipientName "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colWORecipientEmail) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [WORecipientEmail] = @colWORecipientEmail "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colWOSubject) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [WOSubject] = @colWOSubject "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colExchangeRateGroupID) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ExchangeRateGroupID] = @colExchangeRateGroupID "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colAutoRecLastProcessDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [AutoRecLastProcessDate] = @colAutoRecLastProcessDate "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colIfu) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [IFU] = @colIfu "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colPifu1) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [PIFU1] = @colPifu1 "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colPifu2) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [PIFU2] = @colPifu2 "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colPifu3) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [PIFU3] = @colPifu3 "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colPifu4) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [PIFU4] = @colPifu4 "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colImpClientDesName1) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ImpClientDesName1] = @colImpClientDesName1 "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colImpClientDesEmail1) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ImpClientDesEmail1] = @colImpClientDesEmail1 "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colImpClientDesName2) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ImpClientDesName2] = @colImpClientDesName2 "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colImpClientDesEmail2) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ImpClientDesEmail2] = @colImpClientDesEmail2 "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colImpClientDesName3) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ImpClientDesName3] = @colImpClientDesName3 "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colImpClientDesEmail3) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ImpClientDesEmail3] = @colImpClientDesEmail3 "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colAifu) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [AIFU] = @colAifu "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colImpClientDesName4) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ImpClientDesName4] = @colImpClientDesName4 "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colImpClientDesEmail4) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ImpClientDesEmail4] = @colImpClientDesEmail4 "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colImpClientDesName5) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ImpClientDesName5] = @colImpClientDesName5 "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colImpClientDesEmail5) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ImpClientDesEmail5] = @colImpClientDesEmail5 "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colMgmtARR) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [MgmtARR] = @colMgmtARR "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colImpEmailAll) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ImpEmailAll] = @colImpEmailAll "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colSecurityPasswordExpireDays) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [SecurityPasswordExpireDays] = @colSecurityPasswordExpireDays "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colSecurityInactivityLockoutDays) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [SecurityInactivityLockoutDays] = @colSecurityInactivityLockoutDays "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colSecurityInactivityLockoutRemindDays) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [SecurityInactivityLockoutRemindDays] = @colSecurityInactivityLockoutRemindDays "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colSecurityPasswordMinimumLength) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [SecurityPasswordMinimumLength] = @colSecurityPasswordMinimumLength "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colSecurityPasswordTypeId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [SecurityPasswordTypeId] = @colSecurityPasswordTypeId "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colDataTransferPackageId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [DataTransferPackageId] = @colDataTransferPackageId "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colDataTransferPassword) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [DataTransferPassword] = @colDataTransferPassword "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colDataTransferEncryptionKey) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [DataTransferEncryptionKey] = @colDataTransferEncryptionKey "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colSecurityAllowChangePassword) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [SecurityAllowChangePassword] = @colSecurityAllowChangePassword "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colReclassificationEmailSentDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ReclassificationEmailSentDate] = @colReclassificationEmailSentDate "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colReclassificationEmailFollowUpDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ReclassificationEmailFollowUpDate] = @colReclassificationEmailFollowUpDate "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colReclassificationCompletionDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ReclassificationCompletionDate] = @colReclassificationCompletionDate "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colReclassificationLinkGUID) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ReclassificationLinkGUID] = @colReclassificationLinkGUID "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colLastReclassificationCompletionDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [LastReclassificationCompletionDate] = @colLastReclassificationCompletionDate "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colSysUserCreated) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [SysUserCreated] = @colSysUserCreated "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colSysDateCreated) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [SysDateCreated] = @colSysDateCreated "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colSysUserModified) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [SysUserModified] = @colSysUserModified "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colSysDateModified) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [SysDateModified] = @colSysDateModified "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colDataTransferPgpEnabled) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [DataTransferPgpEnabled] = @colDataTransferPgpEnabled "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colDataTransferPgpPublicKey) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [DataTransferPgpPublicKey] = @colDataTransferPgpPublicKey "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colDataTransferFtpUrl) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [DataTransferFtpUrl] = @colDataTransferFtpUrl "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colDataTransferFtpUserName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [DataTransferFtpUserName] = @colDataTransferFtpUserName "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colDataTransferFtpPassword) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [DataTransferFtpPassword] = @colDataTransferFtpPassword "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colDataTransferPgpFileExtension) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [DataTransferPgpFileExtension] = @colDataTransferPgpFileExtension "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colDataTransferFtpEnabled) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [DataTransferFtpEnabled] = @colDataTransferFtpEnabled "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colDataTransferRetrievalDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [DataTransferRetrievalDate] = @colDataTransferRetrievalDate "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colDefaultMetaCurrencyID) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [DefaultMetaCurrencyID] = @colDefaultMetaCurrencyID "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colARRRolloutOption) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ARRRolloutOption] = @colARRRolloutOption "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colARRRolloutOptionDesc) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ARRRolloutOptionDesc] = @colARRRolloutOptionDesc "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colImpairmentStatus) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ImpairmentStatus] = @colImpairmentStatus "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colImpairmentSpecialHandling) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ImpairmentSpecialHandling] = @colImpairmentSpecialHandling "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colImpairmentSpecialHandlingDesc) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ImpairmentSpecialHandlingDesc] = @colImpairmentSpecialHandlingDesc "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colDataTransferFtpLocalFolder) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [DataTransferFtpLocalFolder] = @colDataTransferFtpLocalFolder "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colDataTransferFileNameFormatString) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [DataTransferFileNameFormatString] = @colDataTransferFileNameFormatString "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colDataTransferFtpMonthJson) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [DataTransferFtpMonthJson] = @colDataTransferFtpMonthJson "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colDataTransferFtpDayJson) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [DataTransferFtpDayJson] = @colDataTransferFtpDayJson "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colIndustryGroup) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [IndustryGroup] = @colIndustryGroup "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colMajorGroup) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [MajorGroup] = @colMajorGroup "
                        End If
                        If pRowData.IsDirty(rowTblClients.FieldIndex.colSpecificGroup) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [SpecificGroup] = @colSpecificGroup "
                        End If
                        zWhere = " WHERE [fileprefix] = @colFileprefix"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[clients] ([cldbname], [clientname], [features], [fileprefix], [clientdesigneenotify], [clientdesigneename], [clientdesigneeemail], [580active], [recrespemail], [recautofollowup], [recfollowup1], [recfollowup2], [recfollowup3], [datatransfer], [AutoRecStartDate], [AutoRecComments], [FireRatingKeyID], [BMRatingKeyID], [CustomAccessLabel], [WORecipientName], [WORecipientEmail], [WOSubject], [ExchangeRateGroupID], [AutoRecLastProcessDate], [IFU], [PIFU1], [PIFU2], [PIFU3], [PIFU4], [ImpClientDesName1], [ImpClientDesEmail1], [ImpClientDesName2], [ImpClientDesEmail2], [ImpClientDesName3], [ImpClientDesEmail3], [AIFU], [ImpClientDesName4], [ImpClientDesEmail4], [ImpClientDesName5], [ImpClientDesEmail5], [MgmtARR], [ImpEmailAll], [SecurityPasswordExpireDays], [SecurityInactivityLockoutDays], [SecurityInactivityLockoutRemindDays], [SecurityPasswordMinimumLength], [SecurityPasswordTypeId], [DataTransferPackageId], [DataTransferPassword], [DataTransferEncryptionKey], [SecurityAllowChangePassword], [ReclassificationEmailSentDate], [ReclassificationEmailFollowUpDate], [ReclassificationCompletionDate], [ReclassificationLinkGUID], [LastReclassificationCompletionDate], [SysUserCreated], [SysDateCreated], [SysUserModified], [SysDateModified], [DataTransferPgpEnabled], [DataTransferPgpPublicKey], [DataTransferFtpUrl], [DataTransferFtpUserName], [DataTransferFtpPassword], [DataTransferPgpFileExtension], [DataTransferFtpEnabled], [DataTransferRetrievalDate], [DefaultMetaCurrencyID], [ARRRolloutOption], [ARRRolloutOptionDesc], [ImpairmentStatus], [ImpairmentSpecialHandling], [ImpairmentSpecialHandlingDesc], [DataTransferFtpLocalFolder], [DataTransferFileNameFormatString], [DataTransferFtpMonthJson], [DataTransferFtpDayJson], [IndustryGroup], [MajorGroup], [SpecificGroup])" & _
                            " VALUES (@colCldbname, @colClientname, @colFeatures, @colFileprefix, @colClientdesigneenotify, @colClientdesigneename, @colClientdesigneeemail, @colActive, @colRecrespemail, @colRecautofollowup, @colRecfollowup1, @colRecfollowup2, @colRecfollowup3, @colDatatransfer, @colAutoRecStartDate, @colAutoRecComments, @colFireRatingKeyID, @colBMRatingKeyID, @colCustomAccessLabel, @colWORecipientName, @colWORecipientEmail, @colWOSubject, @colExchangeRateGroupID, @colAutoRecLastProcessDate, @colIfu, @colPifu1, @colPifu2, @colPifu3, @colPifu4, @colImpClientDesName1, @colImpClientDesEmail1, @colImpClientDesName2, @colImpClientDesEmail2, @colImpClientDesName3, @colImpClientDesEmail3, @colAifu, @colImpClientDesName4, @colImpClientDesEmail4, @colImpClientDesName5, @colImpClientDesEmail5, @colMgmtARR, @colImpEmailAll, @colSecurityPasswordExpireDays, @colSecurityInactivityLockoutDays, @colSecurityInactivityLockoutRemindDays, @colSecurityPasswordMinimumLength, @colSecurityPasswordTypeId, @colDataTransferPackageId, @colDataTransferPassword, @colDataTransferEncryptionKey, @colSecurityAllowChangePassword, @colReclassificationEmailSentDate, @colReclassificationEmailFollowUpDate, @colReclassificationCompletionDate, @colReclassificationLinkGUID, @colLastReclassificationCompletionDate, @colSysUserCreated, @colSysDateCreated, @colSysUserModified, @colSysDateModified, @colDataTransferPgpEnabled, @colDataTransferPgpPublicKey, @colDataTransferFtpUrl, @colDataTransferFtpUserName, @colDataTransferFtpPassword, @colDataTransferPgpFileExtension, @colDataTransferFtpEnabled, @colDataTransferRetrievalDate, @colDefaultMetaCurrencyID, @colARRRolloutOption, @colARRRolloutOptionDesc, @colImpairmentStatus, @colImpairmentSpecialHandling, @colImpairmentSpecialHandlingDesc, @colDataTransferFtpLocalFolder, @colDataTransferFileNameFormatString, @colDataTransferFtpMonthJson, @colDataTransferFtpDayJson, @colIndustryGroup, @colMajorGroup, @colSpecificGroup); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[clients] ([cldbname], [clientname], [features], [clientdesigneenotify], [clientdesigneename], [clientdesigneeemail], [580active], [recrespemail], [recautofollowup], [recfollowup1], [recfollowup2], [recfollowup3], [datatransfer], [AutoRecStartDate], [AutoRecComments], [FireRatingKeyID], [BMRatingKeyID], [CustomAccessLabel], [WORecipientName], [WORecipientEmail], [WOSubject], [ExchangeRateGroupID], [AutoRecLastProcessDate], [IFU], [PIFU1], [PIFU2], [PIFU3], [PIFU4], [ImpClientDesName1], [ImpClientDesEmail1], [ImpClientDesName2], [ImpClientDesEmail2], [ImpClientDesName3], [ImpClientDesEmail3], [AIFU], [ImpClientDesName4], [ImpClientDesEmail4], [ImpClientDesName5], [ImpClientDesEmail5], [MgmtARR], [ImpEmailAll], [SecurityPasswordExpireDays], [SecurityInactivityLockoutDays], [SecurityInactivityLockoutRemindDays], [SecurityPasswordMinimumLength], [SecurityPasswordTypeId], [DataTransferPackageId], [DataTransferPassword], [DataTransferEncryptionKey], [SecurityAllowChangePassword], [ReclassificationEmailSentDate], [ReclassificationEmailFollowUpDate], [ReclassificationCompletionDate], [ReclassificationLinkGUID], [LastReclassificationCompletionDate], [SysUserCreated], [SysDateCreated], [SysUserModified], [SysDateModified], [DataTransferPgpEnabled], [DataTransferPgpPublicKey], [DataTransferFtpUrl], [DataTransferFtpUserName], [DataTransferFtpPassword], [DataTransferPgpFileExtension], [DataTransferFtpEnabled], [DataTransferRetrievalDate], [DefaultMetaCurrencyID], [ARRRolloutOption], [ARRRolloutOptionDesc], [ImpairmentStatus], [ImpairmentSpecialHandling], [ImpairmentSpecialHandlingDesc], [DataTransferFtpLocalFolder], [DataTransferFileNameFormatString], [DataTransferFtpMonthJson], [DataTransferFtpDayJson], [IndustryGroup], [MajorGroup], [SpecificGroup])" & _
                            " VALUES (@colCldbname, @colClientname, @colFeatures, @colClientdesigneenotify, @colClientdesigneename, @colClientdesigneeemail, @colActive, @colRecrespemail, @colRecautofollowup, @colRecfollowup1, @colRecfollowup2, @colRecfollowup3, @colDatatransfer, @colAutoRecStartDate, @colAutoRecComments, @colFireRatingKeyID, @colBMRatingKeyID, @colCustomAccessLabel, @colWORecipientName, @colWORecipientEmail, @colWOSubject, @colExchangeRateGroupID, @colAutoRecLastProcessDate, @colIfu, @colPifu1, @colPifu2, @colPifu3, @colPifu4, @colImpClientDesName1, @colImpClientDesEmail1, @colImpClientDesName2, @colImpClientDesEmail2, @colImpClientDesName3, @colImpClientDesEmail3, @colAifu, @colImpClientDesName4, @colImpClientDesEmail4, @colImpClientDesName5, @colImpClientDesEmail5, @colMgmtARR, @colImpEmailAll, @colSecurityPasswordExpireDays, @colSecurityInactivityLockoutDays, @colSecurityInactivityLockoutRemindDays, @colSecurityPasswordMinimumLength, @colSecurityPasswordTypeId, @colDataTransferPackageId, @colDataTransferPassword, @colDataTransferEncryptionKey, @colSecurityAllowChangePassword, @colReclassificationEmailSentDate, @colReclassificationEmailFollowUpDate, @colReclassificationCompletionDate, @colReclassificationLinkGUID, @colLastReclassificationCompletionDate, @colSysUserCreated, @colSysDateCreated, @colSysUserModified, @colSysDateModified, @colDataTransferPgpEnabled, @colDataTransferPgpPublicKey, @colDataTransferFtpUrl, @colDataTransferFtpUserName, @colDataTransferFtpPassword, @colDataTransferPgpFileExtension, @colDataTransferFtpEnabled, @colDataTransferRetrievalDate, @colDefaultMetaCurrencyID, @colARRRolloutOption, @colARRRolloutOptionDesc, @colImpairmentStatus, @colImpairmentSpecialHandling, @colImpairmentSpecialHandlingDesc, @colDataTransferFtpLocalFolder, @colDataTransferFileNameFormatString, @colDataTransferFtpMonthJson, @colDataTransferFtpDayJson, @colIndustryGroup, @colMajorGroup, @colSpecificGroup); SELECT SCOPE_IDENTITY()"
                Case Else
            End Select

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

			'IF UPDATE, SET PK PARAMETER
            If zMode = "UPDATE" Then
                zCmd.Parameters.Add(New SQLParameter("@colFileprefix", pRowData.colFileprefix))
            End If

			'IF INSERTING, KEY HAS VALUE AND KEY IS NOT IDENTITY, SET PK PARAMETER
			If zMode = "INSERTwithKey" Then
                zCmd.Parameters.Add(New SQLParameter("@colFileprefix", pRowData.colFileprefix))
            End If

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colCldbname) Then
                    zCmd.Parameters.Add(New SqlParameter("@colCldbname", IIf(pRowData.colCldbname Is Nothing, DBNull.Value, pRowData.colCldbname)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colClientname) Then
                    zCmd.Parameters.Add(New SqlParameter("@colClientname", IIf(pRowData.colClientname Is Nothing, DBNull.Value, pRowData.colClientname)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colFeatures) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFeatures", IIf(pRowData.colFeatures Is Nothing, DBNull.Value, pRowData.colFeatures)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colClientdesigneenotify) Then
                    zCmd.Parameters.Add(New SqlParameter("@colClientdesigneenotify", IIf(pRowData.colClientdesigneenotify Is Nothing, DBNull.Value, pRowData.colClientdesigneenotify)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colClientdesigneename) Then
                    zCmd.Parameters.Add(New SqlParameter("@colClientdesigneename", IIf(pRowData.colClientdesigneename Is Nothing, DBNull.Value, pRowData.colClientdesigneename)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colClientdesigneeemail) Then
                    zCmd.Parameters.Add(New SqlParameter("@colClientdesigneeemail", IIf(pRowData.colClientdesigneeemail Is Nothing, DBNull.Value, pRowData.colClientdesigneeemail)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colActive) Then
                    zCmd.Parameters.Add(New SqlParameter("@colActive", IIf(pRowData.colActive Is Nothing, DBNull.Value, pRowData.colActive)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colRecrespemail) Then
                    zCmd.Parameters.Add(New SqlParameter("@colRecrespemail", IIf(pRowData.colRecrespemail Is Nothing, DBNull.Value, pRowData.colRecrespemail)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colRecautofollowup) Then
                    zCmd.Parameters.Add(New SqlParameter("@colRecautofollowup", IIf(pRowData.colRecautofollowup Is Nothing, DBNull.Value, pRowData.colRecautofollowup)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colRecfollowup1) Then
                    zCmd.Parameters.Add(New SqlParameter("@colRecfollowup1", IIf(pRowData.colRecfollowup1 Is Nothing, DBNull.Value, pRowData.colRecfollowup1)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colRecfollowup2) Then
                    zCmd.Parameters.Add(New SqlParameter("@colRecfollowup2", IIf(pRowData.colRecfollowup2 Is Nothing, DBNull.Value, pRowData.colRecfollowup2)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colRecfollowup3) Then
                    zCmd.Parameters.Add(New SqlParameter("@colRecfollowup3", IIf(pRowData.colRecfollowup3 Is Nothing, DBNull.Value, pRowData.colRecfollowup3)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colDatatransfer) Then
                    zCmd.Parameters.Add(New SqlParameter("@colDatatransfer", IIf(pRowData.colDatatransfer Is Nothing, DBNull.Value, pRowData.colDatatransfer)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colAutoRecStartDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colAutoRecStartDate", IIf(pRowData.colAutoRecStartDate Is Nothing, DBNull.Value, pRowData.colAutoRecStartDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colAutoRecComments) Then
                    zCmd.Parameters.Add(New SqlParameter("@colAutoRecComments", IIf(pRowData.colAutoRecComments Is Nothing, DBNull.Value, pRowData.colAutoRecComments)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colFireRatingKeyID) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFireRatingKeyID", IIf(pRowData.colFireRatingKeyID Is Nothing, DBNull.Value, pRowData.colFireRatingKeyID)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colBMRatingKeyID) Then
                    zCmd.Parameters.Add(New SqlParameter("@colBMRatingKeyID", IIf(pRowData.colBMRatingKeyID Is Nothing, DBNull.Value, pRowData.colBMRatingKeyID)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colCustomAccessLabel) Then
                    zCmd.Parameters.Add(New SqlParameter("@colCustomAccessLabel", IIf(pRowData.colCustomAccessLabel Is Nothing, DBNull.Value, pRowData.colCustomAccessLabel)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colWORecipientName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colWORecipientName", IIf(pRowData.colWORecipientName Is Nothing, DBNull.Value, pRowData.colWORecipientName)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colWORecipientEmail) Then
                    zCmd.Parameters.Add(New SqlParameter("@colWORecipientEmail", IIf(pRowData.colWORecipientEmail Is Nothing, DBNull.Value, pRowData.colWORecipientEmail)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colWOSubject) Then
                    zCmd.Parameters.Add(New SqlParameter("@colWOSubject", IIf(pRowData.colWOSubject Is Nothing, DBNull.Value, pRowData.colWOSubject)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colExchangeRateGroupID) Then
                    zCmd.Parameters.Add(New SqlParameter("@colExchangeRateGroupID", IIf(pRowData.colExchangeRateGroupID Is Nothing, DBNull.Value, pRowData.colExchangeRateGroupID)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colAutoRecLastProcessDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colAutoRecLastProcessDate", IIf(pRowData.colAutoRecLastProcessDate Is Nothing, DBNull.Value, pRowData.colAutoRecLastProcessDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colIfu) Then
                    zCmd.Parameters.Add(New SqlParameter("@colIfu", IIf(pRowData.colIfu Is Nothing, DBNull.Value, pRowData.colIfu)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colPifu1) Then
                    zCmd.Parameters.Add(New SqlParameter("@colPifu1", IIf(pRowData.colPifu1 Is Nothing, DBNull.Value, pRowData.colPifu1)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colPifu2) Then
                    zCmd.Parameters.Add(New SqlParameter("@colPifu2", IIf(pRowData.colPifu2 Is Nothing, DBNull.Value, pRowData.colPifu2)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colPifu3) Then
                    zCmd.Parameters.Add(New SqlParameter("@colPifu3", IIf(pRowData.colPifu3 Is Nothing, DBNull.Value, pRowData.colPifu3)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colPifu4) Then
                    zCmd.Parameters.Add(New SqlParameter("@colPifu4", IIf(pRowData.colPifu4 Is Nothing, DBNull.Value, pRowData.colPifu4)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colImpClientDesName1) Then
                    zCmd.Parameters.Add(New SqlParameter("@colImpClientDesName1", IIf(pRowData.colImpClientDesName1 Is Nothing, DBNull.Value, pRowData.colImpClientDesName1)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colImpClientDesEmail1) Then
                    zCmd.Parameters.Add(New SqlParameter("@colImpClientDesEmail1", IIf(pRowData.colImpClientDesEmail1 Is Nothing, DBNull.Value, pRowData.colImpClientDesEmail1)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colImpClientDesName2) Then
                    zCmd.Parameters.Add(New SqlParameter("@colImpClientDesName2", IIf(pRowData.colImpClientDesName2 Is Nothing, DBNull.Value, pRowData.colImpClientDesName2)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colImpClientDesEmail2) Then
                    zCmd.Parameters.Add(New SqlParameter("@colImpClientDesEmail2", IIf(pRowData.colImpClientDesEmail2 Is Nothing, DBNull.Value, pRowData.colImpClientDesEmail2)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colImpClientDesName3) Then
                    zCmd.Parameters.Add(New SqlParameter("@colImpClientDesName3", IIf(pRowData.colImpClientDesName3 Is Nothing, DBNull.Value, pRowData.colImpClientDesName3)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colImpClientDesEmail3) Then
                    zCmd.Parameters.Add(New SqlParameter("@colImpClientDesEmail3", IIf(pRowData.colImpClientDesEmail3 Is Nothing, DBNull.Value, pRowData.colImpClientDesEmail3)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colAifu) Then
                    zCmd.Parameters.Add(New SqlParameter("@colAifu", IIf(pRowData.colAifu Is Nothing, DBNull.Value, pRowData.colAifu)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colImpClientDesName4) Then
                    zCmd.Parameters.Add(New SqlParameter("@colImpClientDesName4", IIf(pRowData.colImpClientDesName4 Is Nothing, DBNull.Value, pRowData.colImpClientDesName4)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colImpClientDesEmail4) Then
                    zCmd.Parameters.Add(New SqlParameter("@colImpClientDesEmail4", IIf(pRowData.colImpClientDesEmail4 Is Nothing, DBNull.Value, pRowData.colImpClientDesEmail4)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colImpClientDesName5) Then
                    zCmd.Parameters.Add(New SqlParameter("@colImpClientDesName5", IIf(pRowData.colImpClientDesName5 Is Nothing, DBNull.Value, pRowData.colImpClientDesName5)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colImpClientDesEmail5) Then
                    zCmd.Parameters.Add(New SqlParameter("@colImpClientDesEmail5", IIf(pRowData.colImpClientDesEmail5 Is Nothing, DBNull.Value, pRowData.colImpClientDesEmail5)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colMgmtARR) Then
                    zCmd.Parameters.Add(New SqlParameter("@colMgmtARR", IIf(pRowData.colMgmtARR Is Nothing, DBNull.Value, pRowData.colMgmtARR)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colImpEmailAll) Then
                    zCmd.Parameters.Add(New SqlParameter("@colImpEmailAll", IIf(pRowData.colImpEmailAll Is Nothing, DBNull.Value, pRowData.colImpEmailAll)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colSecurityPasswordExpireDays) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSecurityPasswordExpireDays", IIf(pRowData.colSecurityPasswordExpireDays Is Nothing, DBNull.Value, pRowData.colSecurityPasswordExpireDays)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colSecurityInactivityLockoutDays) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSecurityInactivityLockoutDays", IIf(pRowData.colSecurityInactivityLockoutDays Is Nothing, DBNull.Value, pRowData.colSecurityInactivityLockoutDays)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colSecurityInactivityLockoutRemindDays) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSecurityInactivityLockoutRemindDays", IIf(pRowData.colSecurityInactivityLockoutRemindDays Is Nothing, DBNull.Value, pRowData.colSecurityInactivityLockoutRemindDays)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colSecurityPasswordMinimumLength) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSecurityPasswordMinimumLength", IIf(pRowData.colSecurityPasswordMinimumLength Is Nothing, DBNull.Value, pRowData.colSecurityPasswordMinimumLength)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colSecurityPasswordTypeId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSecurityPasswordTypeId", IIf(pRowData.colSecurityPasswordTypeId Is Nothing, DBNull.Value, pRowData.colSecurityPasswordTypeId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colDataTransferPackageId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colDataTransferPackageId", IIf(pRowData.colDataTransferPackageId Is Nothing, DBNull.Value, pRowData.colDataTransferPackageId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colDataTransferPassword) Then
                    zCmd.Parameters.Add(New SqlParameter("@colDataTransferPassword", IIf(pRowData.colDataTransferPassword Is Nothing, DBNull.Value, pRowData.colDataTransferPassword)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colDataTransferEncryptionKey) Then
                    zCmd.Parameters.Add(New SqlParameter("@colDataTransferEncryptionKey", IIf(pRowData.colDataTransferEncryptionKey Is Nothing, DBNull.Value, pRowData.colDataTransferEncryptionKey)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colSecurityAllowChangePassword) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSecurityAllowChangePassword", IIf(pRowData.colSecurityAllowChangePassword Is Nothing, DBNull.Value, pRowData.colSecurityAllowChangePassword)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colReclassificationEmailSentDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colReclassificationEmailSentDate", IIf(pRowData.colReclassificationEmailSentDate Is Nothing, DBNull.Value, pRowData.colReclassificationEmailSentDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colReclassificationEmailFollowUpDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colReclassificationEmailFollowUpDate", IIf(pRowData.colReclassificationEmailFollowUpDate Is Nothing, DBNull.Value, pRowData.colReclassificationEmailFollowUpDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colReclassificationCompletionDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colReclassificationCompletionDate", IIf(pRowData.colReclassificationCompletionDate Is Nothing, DBNull.Value, pRowData.colReclassificationCompletionDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colReclassificationLinkGUID) Then
                    zCmd.Parameters.Add(New SqlParameter("@colReclassificationLinkGUID", IIf(pRowData.colReclassificationLinkGUID Is Nothing, DBNull.Value, pRowData.colReclassificationLinkGUID)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colLastReclassificationCompletionDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colLastReclassificationCompletionDate", IIf(pRowData.colLastReclassificationCompletionDate Is Nothing, DBNull.Value, pRowData.colLastReclassificationCompletionDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colSysUserCreated) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSysUserCreated", IIf(pRowData.colSysUserCreated Is Nothing, DBNull.Value, pRowData.colSysUserCreated)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colSysDateCreated) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSysDateCreated", IIf(pRowData.colSysDateCreated Is Nothing, DBNull.Value, pRowData.colSysDateCreated)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colSysUserModified) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSysUserModified", IIf(pRowData.colSysUserModified Is Nothing, DBNull.Value, pRowData.colSysUserModified)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colSysDateModified) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSysDateModified", IIf(pRowData.colSysDateModified Is Nothing, DBNull.Value, pRowData.colSysDateModified)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colDataTransferPgpEnabled) Then
                    zCmd.Parameters.Add(New SqlParameter("@colDataTransferPgpEnabled", IIf(pRowData.colDataTransferPgpEnabled Is Nothing, DBNull.Value, pRowData.colDataTransferPgpEnabled)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colDataTransferPgpPublicKey) Then
                    zCmd.Parameters.Add(New SqlParameter("@colDataTransferPgpPublicKey", IIf(pRowData.colDataTransferPgpPublicKey Is Nothing, DBNull.Value, pRowData.colDataTransferPgpPublicKey)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colDataTransferFtpUrl) Then
                    zCmd.Parameters.Add(New SqlParameter("@colDataTransferFtpUrl", IIf(pRowData.colDataTransferFtpUrl Is Nothing, DBNull.Value, pRowData.colDataTransferFtpUrl)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colDataTransferFtpUserName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colDataTransferFtpUserName", IIf(pRowData.colDataTransferFtpUserName Is Nothing, DBNull.Value, pRowData.colDataTransferFtpUserName)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colDataTransferFtpPassword) Then
                    zCmd.Parameters.Add(New SqlParameter("@colDataTransferFtpPassword", IIf(pRowData.colDataTransferFtpPassword Is Nothing, DBNull.Value, pRowData.colDataTransferFtpPassword)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colDataTransferPgpFileExtension) Then
                    zCmd.Parameters.Add(New SqlParameter("@colDataTransferPgpFileExtension", IIf(pRowData.colDataTransferPgpFileExtension Is Nothing, DBNull.Value, pRowData.colDataTransferPgpFileExtension)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colDataTransferFtpEnabled) Then
                    zCmd.Parameters.Add(New SqlParameter("@colDataTransferFtpEnabled", IIf(pRowData.colDataTransferFtpEnabled Is Nothing, DBNull.Value, pRowData.colDataTransferFtpEnabled)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colDataTransferRetrievalDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colDataTransferRetrievalDate", IIf(pRowData.colDataTransferRetrievalDate Is Nothing, DBNull.Value, pRowData.colDataTransferRetrievalDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colDefaultMetaCurrencyID) Then
                    zCmd.Parameters.Add(New SqlParameter("@colDefaultMetaCurrencyID", IIf(pRowData.colDefaultMetaCurrencyID Is Nothing, DBNull.Value, pRowData.colDefaultMetaCurrencyID)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colARRRolloutOption) Then
                    zCmd.Parameters.Add(New SqlParameter("@colARRRolloutOption", IIf(pRowData.colARRRolloutOption Is Nothing, DBNull.Value, pRowData.colARRRolloutOption)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colARRRolloutOptionDesc) Then
                    zCmd.Parameters.Add(New SqlParameter("@colARRRolloutOptionDesc", IIf(pRowData.colARRRolloutOptionDesc Is Nothing, DBNull.Value, pRowData.colARRRolloutOptionDesc)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colImpairmentStatus) Then
                    zCmd.Parameters.Add(New SqlParameter("@colImpairmentStatus", IIf(pRowData.colImpairmentStatus Is Nothing, DBNull.Value, pRowData.colImpairmentStatus)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colImpairmentSpecialHandling) Then
                    zCmd.Parameters.Add(New SqlParameter("@colImpairmentSpecialHandling", IIf(pRowData.colImpairmentSpecialHandling Is Nothing, DBNull.Value, pRowData.colImpairmentSpecialHandling)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colImpairmentSpecialHandlingDesc) Then
                    zCmd.Parameters.Add(New SqlParameter("@colImpairmentSpecialHandlingDesc", IIf(pRowData.colImpairmentSpecialHandlingDesc Is Nothing, DBNull.Value, pRowData.colImpairmentSpecialHandlingDesc)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colDataTransferFtpLocalFolder) Then
                    zCmd.Parameters.Add(New SqlParameter("@colDataTransferFtpLocalFolder", IIf(pRowData.colDataTransferFtpLocalFolder Is Nothing, DBNull.Value, pRowData.colDataTransferFtpLocalFolder)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colDataTransferFileNameFormatString) Then
                    zCmd.Parameters.Add(New SqlParameter("@colDataTransferFileNameFormatString", IIf(pRowData.colDataTransferFileNameFormatString Is Nothing, DBNull.Value, pRowData.colDataTransferFileNameFormatString)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colDataTransferFtpMonthJson) Then
                    zCmd.Parameters.Add(New SqlParameter("@colDataTransferFtpMonthJson", IIf(pRowData.colDataTransferFtpMonthJson Is Nothing, DBNull.Value, pRowData.colDataTransferFtpMonthJson)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colDataTransferFtpDayJson) Then
                    zCmd.Parameters.Add(New SqlParameter("@colDataTransferFtpDayJson", IIf(pRowData.colDataTransferFtpDayJson Is Nothing, DBNull.Value, pRowData.colDataTransferFtpDayJson)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colIndustryGroup) Then
                    zCmd.Parameters.Add(New SqlParameter("@colIndustryGroup", IIf(pRowData.colIndustryGroup Is Nothing, DBNull.Value, pRowData.colIndustryGroup)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colMajorGroup) Then
                    zCmd.Parameters.Add(New SqlParameter("@colMajorGroup", IIf(pRowData.colMajorGroup Is Nothing, DBNull.Value, pRowData.colMajorGroup)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClients.FieldIndex.colSpecificGroup) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSpecificGroup", IIf(pRowData.colSpecificGroup Is Nothing, DBNull.Value, pRowData.colSpecificGroup)))
                End If

            zCmd.Transaction=pTransaction
            If zMode = "INSERTnoKey" Then
                Dim zLastId As Long = 0
                zLastId = razor.UtilSQLServer.ExecuteNonQueryRowId(zCmd)

                pRowData.colFileprefix = zLastId
                pRowData.colClientId = zLastId
            Else
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)
            End If

            pRowData.SetIsDirty(False)
            pRowData.RaiseSavedEvent(pSavedEventUserState)

		End If

        End Sub

        Public Shared Function LoadByPrimaryKey(pcolFileprefix As String) As rowTblClients
            Return LoadByPrimaryKey(pcolFileprefix, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFileprefix As String, pLoadEventUserState As Object) As rowTblClients
            Return LoadByPrimaryKey(pcolFileprefix, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFileprefix As String, pTransaction As SqlClient.SqlTransaction) As rowTblClients
            Return LoadByPrimaryKey(pcolFileprefix, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFileprefix As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblClients
            Dim zReturn As New rowTblClients
            Dim zSQL As String = "SELECT * FROM [dbo].[clients] WHERE [fileprefix] = @colFileprefix"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFileprefix", pcolFileprefix))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblClients) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_IX_FireRatingKeyID(pcolFireRatingKeyID As Byte) As List(Of rowTblClients)
            Return LoadByIDX_IX_FireRatingKeyID(pcolFireRatingKeyID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_FireRatingKeyID(pcolFireRatingKeyID As Byte, pLoadEventUserState As Object) As List(Of rowTblClients)
            Return LoadByIDX_IX_FireRatingKeyID(pcolFireRatingKeyID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_FireRatingKeyID(pcolFireRatingKeyID As Byte, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblClients)
            Return LoadByIDX_IX_FireRatingKeyID(pcolFireRatingKeyID, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_FireRatingKeyID(pcolFireRatingKeyID As Byte, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblClients)
            Dim zReturn As New List(Of rowTblClients)
            Dim zSQL As String = "SELECT * FROM [dbo].[clients] WHERE [FireRatingKeyID] = @colFireRatingKeyID"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFireRatingKeyID", pcolFireRatingKeyID))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function
        Public Shared Function LoadByIDX_IX_cldbname(pcolCldbname As String) As List(Of rowTblClients)
            Return LoadByIDX_IX_cldbname(pcolCldbname, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_cldbname(pcolCldbname As String, pLoadEventUserState As Object) As List(Of rowTblClients)
            Return LoadByIDX_IX_cldbname(pcolCldbname, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_cldbname(pcolCldbname As String, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblClients)
            Return LoadByIDX_IX_cldbname(pcolCldbname, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_cldbname(pcolCldbname As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblClients)
            Dim zReturn As New List(Of rowTblClients)
            Dim zSQL As String = "SELECT * FROM [dbo].[clients] WHERE [cldbname] = @colCldbname"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colCldbname", pcolCldbname))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function
        Public Shared Function LoadByIDX_PK_clients(pcolFileprefix As String) As List(Of rowTblClients)
            Return LoadByIDX_PK_clients(pcolFileprefix, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_clients(pcolFileprefix As String, pLoadEventUserState As Object) As List(Of rowTblClients)
            Return LoadByIDX_PK_clients(pcolFileprefix, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_clients(pcolFileprefix As String, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblClients)
            Return LoadByIDX_PK_clients(pcolFileprefix, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_clients(pcolFileprefix As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblClients)
            Dim zReturn As New List(Of rowTblClients)
            Dim zSQL As String = "SELECT * FROM [dbo].[clients] WHERE [fileprefix] = @colFileprefix"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFileprefix", pcolFileprefix))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblClients)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblClients)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblClients)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblClients)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblClients)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblClients)
            Dim zReturn As New List(Of rowTblClients)
            Dim zSQL As String = "SELECT * FROM [dbo].[clients]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblClients)

			Try
	            Dim zReturn As New List(Of rowTblClients)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblClients

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblClients		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblClients)
			If Not pReader.IsDBNull(pReader.GetOrdinal("cldbname")) Then pObject.colCldbname = UtilSQLServer.SafeReader.SafeReadString(pReader, "cldbname")
			If Not pReader.IsDBNull(pReader.GetOrdinal("clientname")) Then pObject.colClientname = UtilSQLServer.SafeReader.SafeReadString(pReader, "clientname")
			If Not pReader.IsDBNull(pReader.GetOrdinal("features")) Then pObject.colFeatures = UtilSQLServer.SafeReader.SafeReadString(pReader, "features")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fileprefix")) Then pObject.colFileprefix = UtilSQLServer.SafeReader.SafeReadString(pReader, "fileprefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("clientdesigneenotify")) Then pObject.colClientdesigneenotify = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "clientdesigneenotify")
			If Not pReader.IsDBNull(pReader.GetOrdinal("clientdesigneename")) Then pObject.colClientdesigneename = UtilSQLServer.SafeReader.SafeReadString(pReader, "clientdesigneename")
			If Not pReader.IsDBNull(pReader.GetOrdinal("clientdesigneeemail")) Then pObject.colClientdesigneeemail = UtilSQLServer.SafeReader.SafeReadString(pReader, "clientdesigneeemail")
			If Not pReader.IsDBNull(pReader.GetOrdinal("580active")) Then pObject.colActive = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "580active")
			If Not pReader.IsDBNull(pReader.GetOrdinal("recrespemail")) Then pObject.colRecrespemail = UtilSQLServer.SafeReader.SafeReadString(pReader, "recrespemail")
			If Not pReader.IsDBNull(pReader.GetOrdinal("recautofollowup")) Then pObject.colRecautofollowup = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "recautofollowup")
			If Not pReader.IsDBNull(pReader.GetOrdinal("recfollowup1")) Then pObject.colRecfollowup1 = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "recfollowup1")
			If Not pReader.IsDBNull(pReader.GetOrdinal("recfollowup2")) Then pObject.colRecfollowup2 = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "recfollowup2")
			If Not pReader.IsDBNull(pReader.GetOrdinal("recfollowup3")) Then pObject.colRecfollowup3 = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "recfollowup3")
			If Not pReader.IsDBNull(pReader.GetOrdinal("datatransfer")) Then pObject.colDatatransfer = UtilSQLServer.SafeReader.SafeReadString(pReader, "datatransfer")
			If Not pReader.IsDBNull(pReader.GetOrdinal("AutoRecStartDate")) Then pObject.colAutoRecStartDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "AutoRecStartDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("AutoRecComments")) Then pObject.colAutoRecComments = UtilSQLServer.SafeReader.SafeReadString(pReader, "AutoRecComments")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FireRatingKeyID")) Then pObject.colFireRatingKeyID = UtilSQLServer.SafeReader.SafeReadByte(pReader, "FireRatingKeyID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("BMRatingKeyID")) Then pObject.colBMRatingKeyID = UtilSQLServer.SafeReader.SafeReadByte(pReader, "BMRatingKeyID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CustomAccessLabel")) Then pObject.colCustomAccessLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "CustomAccessLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("WORecipientName")) Then pObject.colWORecipientName = UtilSQLServer.SafeReader.SafeReadString(pReader, "WORecipientName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("WORecipientEmail")) Then pObject.colWORecipientEmail = UtilSQLServer.SafeReader.SafeReadString(pReader, "WORecipientEmail")
			If Not pReader.IsDBNull(pReader.GetOrdinal("WOSubject")) Then pObject.colWOSubject = UtilSQLServer.SafeReader.SafeReadString(pReader, "WOSubject")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ExchangeRateGroupID")) Then pObject.colExchangeRateGroupID = UtilSQLServer.SafeReader.SafeReadByte(pReader, "ExchangeRateGroupID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("AutoRecLastProcessDate")) Then pObject.colAutoRecLastProcessDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "AutoRecLastProcessDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("IFU")) Then pObject.colIfu = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "IFU")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PIFU1")) Then pObject.colPifu1 = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "PIFU1")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PIFU2")) Then pObject.colPifu2 = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "PIFU2")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PIFU3")) Then pObject.colPifu3 = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "PIFU3")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PIFU4")) Then pObject.colPifu4 = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "PIFU4")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ImpClientDesName1")) Then pObject.colImpClientDesName1 = UtilSQLServer.SafeReader.SafeReadString(pReader, "ImpClientDesName1")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ImpClientDesEmail1")) Then pObject.colImpClientDesEmail1 = UtilSQLServer.SafeReader.SafeReadString(pReader, "ImpClientDesEmail1")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ImpClientDesName2")) Then pObject.colImpClientDesName2 = UtilSQLServer.SafeReader.SafeReadString(pReader, "ImpClientDesName2")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ImpClientDesEmail2")) Then pObject.colImpClientDesEmail2 = UtilSQLServer.SafeReader.SafeReadString(pReader, "ImpClientDesEmail2")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ImpClientDesName3")) Then pObject.colImpClientDesName3 = UtilSQLServer.SafeReader.SafeReadString(pReader, "ImpClientDesName3")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ImpClientDesEmail3")) Then pObject.colImpClientDesEmail3 = UtilSQLServer.SafeReader.SafeReadString(pReader, "ImpClientDesEmail3")
			If Not pReader.IsDBNull(pReader.GetOrdinal("AIFU")) Then pObject.colAifu = UtilSQLServer.SafeReader.SafeReadString(pReader, "AIFU")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ImpClientDesName4")) Then pObject.colImpClientDesName4 = UtilSQLServer.SafeReader.SafeReadString(pReader, "ImpClientDesName4")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ImpClientDesEmail4")) Then pObject.colImpClientDesEmail4 = UtilSQLServer.SafeReader.SafeReadString(pReader, "ImpClientDesEmail4")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ImpClientDesName5")) Then pObject.colImpClientDesName5 = UtilSQLServer.SafeReader.SafeReadString(pReader, "ImpClientDesName5")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ImpClientDesEmail5")) Then pObject.colImpClientDesEmail5 = UtilSQLServer.SafeReader.SafeReadString(pReader, "ImpClientDesEmail5")
			If Not pReader.IsDBNull(pReader.GetOrdinal("MgmtARR")) Then pObject.colMgmtARR = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "MgmtARR")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ImpEmailAll")) Then pObject.colImpEmailAll = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "ImpEmailAll")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SecurityPasswordExpireDays")) Then pObject.colSecurityPasswordExpireDays = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "SecurityPasswordExpireDays")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SecurityInactivityLockoutDays")) Then pObject.colSecurityInactivityLockoutDays = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "SecurityInactivityLockoutDays")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SecurityInactivityLockoutRemindDays")) Then pObject.colSecurityInactivityLockoutRemindDays = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "SecurityInactivityLockoutRemindDays")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SecurityPasswordMinimumLength")) Then pObject.colSecurityPasswordMinimumLength = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "SecurityPasswordMinimumLength")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SecurityPasswordTypeId")) Then pObject.colSecurityPasswordTypeId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "SecurityPasswordTypeId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DataTransferPackageId")) Then pObject.colDataTransferPackageId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "DataTransferPackageId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DataTransferPassword")) Then pObject.colDataTransferPassword = UtilSQLServer.SafeReader.SafeReadString(pReader, "DataTransferPassword")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DataTransferEncryptionKey")) Then pObject.colDataTransferEncryptionKey = UtilSQLServer.SafeReader.SafeReadString(pReader, "DataTransferEncryptionKey")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SecurityAllowChangePassword")) Then pObject.colSecurityAllowChangePassword = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "SecurityAllowChangePassword")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ReclassificationEmailSentDate")) Then pObject.colReclassificationEmailSentDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "ReclassificationEmailSentDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ReclassificationEmailFollowUpDate")) Then pObject.colReclassificationEmailFollowUpDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "ReclassificationEmailFollowUpDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ReclassificationCompletionDate")) Then pObject.colReclassificationCompletionDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "ReclassificationCompletionDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ReclassificationLinkGUID")) Then pObject.colReclassificationLinkGUID = UtilSQLServer.SafeReader.SafeReadString(pReader, "ReclassificationLinkGUID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LastReclassificationCompletionDate")) Then pObject.colLastReclassificationCompletionDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "LastReclassificationCompletionDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SysUserCreated")) Then pObject.colSysUserCreated = UtilSQLServer.SafeReader.SafeReadString(pReader, "SysUserCreated")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SysDateCreated")) Then pObject.colSysDateCreated = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "SysDateCreated")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SysUserModified")) Then pObject.colSysUserModified = UtilSQLServer.SafeReader.SafeReadString(pReader, "SysUserModified")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SysDateModified")) Then pObject.colSysDateModified = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "SysDateModified")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ClientId")) Then pObject.colClientId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "ClientId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DataTransferPgpEnabled")) Then pObject.colDataTransferPgpEnabled = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "DataTransferPgpEnabled")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DataTransferPgpPublicKey")) Then pObject.colDataTransferPgpPublicKey = UtilSQLServer.SafeReader.SafeReadString(pReader, "DataTransferPgpPublicKey")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DataTransferFtpUrl")) Then pObject.colDataTransferFtpUrl = UtilSQLServer.SafeReader.SafeReadString(pReader, "DataTransferFtpUrl")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DataTransferFtpUserName")) Then pObject.colDataTransferFtpUserName = UtilSQLServer.SafeReader.SafeReadString(pReader, "DataTransferFtpUserName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DataTransferFtpPassword")) Then pObject.colDataTransferFtpPassword = UtilSQLServer.SafeReader.SafeReadString(pReader, "DataTransferFtpPassword")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DataTransferPgpFileExtension")) Then pObject.colDataTransferPgpFileExtension = UtilSQLServer.SafeReader.SafeReadString(pReader, "DataTransferPgpFileExtension")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DataTransferFtpEnabled")) Then pObject.colDataTransferFtpEnabled = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "DataTransferFtpEnabled")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DataTransferRetrievalDate")) Then pObject.colDataTransferRetrievalDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "DataTransferRetrievalDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DefaultMetaCurrencyID")) Then pObject.colDefaultMetaCurrencyID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "DefaultMetaCurrencyID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ARRRolloutOption")) Then pObject.colARRRolloutOption = UtilSQLServer.SafeReader.SafeReadString(pReader, "ARRRolloutOption")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ARRRolloutOptionDesc")) Then pObject.colARRRolloutOptionDesc = UtilSQLServer.SafeReader.SafeReadString(pReader, "ARRRolloutOptionDesc")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ImpairmentStatus")) Then pObject.colImpairmentStatus = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "ImpairmentStatus")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ImpairmentSpecialHandling")) Then pObject.colImpairmentSpecialHandling = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "ImpairmentSpecialHandling")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ImpairmentSpecialHandlingDesc")) Then pObject.colImpairmentSpecialHandlingDesc = UtilSQLServer.SafeReader.SafeReadString(pReader, "ImpairmentSpecialHandlingDesc")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DataTransferFtpLocalFolder")) Then pObject.colDataTransferFtpLocalFolder = UtilSQLServer.SafeReader.SafeReadString(pReader, "DataTransferFtpLocalFolder")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DataTransferFileNameFormatString")) Then pObject.colDataTransferFileNameFormatString = UtilSQLServer.SafeReader.SafeReadString(pReader, "DataTransferFileNameFormatString")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DataTransferFtpMonthJson")) Then pObject.colDataTransferFtpMonthJson = UtilSQLServer.SafeReader.SafeReadString(pReader, "DataTransferFtpMonthJson")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DataTransferFtpDayJson")) Then pObject.colDataTransferFtpDayJson = UtilSQLServer.SafeReader.SafeReadString(pReader, "DataTransferFtpDayJson")
			If Not pReader.IsDBNull(pReader.GetOrdinal("IndustryGroup")) Then pObject.colIndustryGroup = UtilSQLServer.SafeReader.SafeReadString(pReader, "IndustryGroup")
			If Not pReader.IsDBNull(pReader.GetOrdinal("MajorGroup")) Then pObject.colMajorGroup = UtilSQLServer.SafeReader.SafeReadString(pReader, "MajorGroup")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SpecificGroup")) Then pObject.colSpecificGroup = UtilSQLServer.SafeReader.SafeReadString(pReader, "SpecificGroup")
			pObject.SetIsDirty(False)
			Return pObject
		End	 Function

    #Region "Reflection Based Load Functions"

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFileprefix As String) As T
            Return LoadByPrimaryKey(Of T)(pcolFileprefix, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFileprefix As String, pLoadEventUserState As Object) As T
            Return LoadByPrimaryKey(Of T)(pcolFileprefix, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFileprefix As String, pTransaction As SqlClient.SqlTransaction) As T
            Return LoadByPrimaryKey(Of T)(pcolFileprefix, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFileprefix As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As T

            Dim zReturn As Object = Activator.CreateInstance(Of T)()
            If Not TypeOf zReturn Is rowTblClients Then Throw New ArgumentException("Generic type is not type of rowTblClients.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[clients] WHERE [fileprefix] = @colFileprefix"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFileprefix", pcolFileprefix))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of T) = ReadData(Of T)(zCmd, pLoadEventUserState)
            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

        End Function

        Public Shared Function LoadByIDX_IX_FireRatingKeyID(Of T)(pcolFireRatingKeyID As Byte) As List(Of T)
            Return LoadByIDX_IX_FireRatingKeyID(Of T)(pcolFireRatingKeyID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_FireRatingKeyID(Of T)(pcolFireRatingKeyID As Byte, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_IX_FireRatingKeyID(Of T)(pcolFireRatingKeyID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_FireRatingKeyID(Of T)(pcolFireRatingKeyID As Byte, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_IX_FireRatingKeyID(Of T)(pcolFireRatingKeyID, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_IX_FireRatingKeyID(Of T)(pcolFireRatingKeyID As Byte, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[clients] WHERE [FireRatingKeyID] = @colFireRatingKeyID"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFireRatingKeyID", pcolFireRatingKeyID))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_IX_cldbname(Of T)(pcolCldbname As String) As List(Of T)
            Return LoadByIDX_IX_cldbname(Of T)(pcolCldbname, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_cldbname(Of T)(pcolCldbname As String, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_IX_cldbname(Of T)(pcolCldbname, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_cldbname(Of T)(pcolCldbname As String, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_IX_cldbname(Of T)(pcolCldbname, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_IX_cldbname(Of T)(pcolCldbname As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[clients] WHERE [cldbname] = @colCldbname"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colCldbname", pcolCldbname))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_PK_clients(Of T)(pcolFileprefix As String) As List(Of T)
            Return LoadByIDX_PK_clients(Of T)(pcolFileprefix, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_clients(Of T)(pcolFileprefix As String, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK_clients(Of T)(pcolFileprefix, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_clients(Of T)(pcolFileprefix As String, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK_clients(Of T)(pcolFileprefix, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK_clients(Of T)(pcolFileprefix As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[clients] WHERE [fileprefix] = @colFileprefix"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFileprefix", pcolFileprefix))

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
            Dim zSQL As String = "SELECT * FROM [dbo].[clients]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblClients
        Implements IrowTblClients

        Public Event Loaded(pUserState As Object) Implements IrowTblClients.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblClients.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblClients.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblClients.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblClients.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblClients.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colCldbname() As String Implements IrowTblClients.colCldbname
            Get
                Return m_colCldbname
            End Get
            Set
                If Not Same(m_colCldbname, Value) Then
                    m_colCldbname = Value
                    m_IsDirty(FieldIndex.colCldbname) = True
                End If
            End Set
        End Property
        Private m_colCldbname As String

        Public Property colClientname() As String Implements IrowTblClients.colClientname
            Get
                Return m_colClientname
            End Get
            Set
                If Not Same(m_colClientname, Value) Then
                    m_colClientname = Value
                    m_IsDirty(FieldIndex.colClientname) = True
                End If
            End Set
        End Property
        Private m_colClientname As String

        Public Property colFeatures() As String Implements IrowTblClients.colFeatures
            Get
                Return m_colFeatures
            End Get
            Set
                If Not Same(m_colFeatures, Value) Then
                    m_colFeatures = Value
                    m_IsDirty(FieldIndex.colFeatures) = True
                End If
            End Set
        End Property
        Private m_colFeatures As String

        Public Property colFileprefix() As String Implements IrowTblClients.colFileprefix
            Get
                Return m_colFileprefix
            End Get
            Set
                If Not Same(m_colFileprefix, Value) Then
                    m_colFileprefix = Value
                    m_IsDirty(FieldIndex.colFileprefix) = True
                End If
            End Set
        End Property
        Private m_colFileprefix As String

        Public Property colClientdesigneenotify() As Nullable(Of Boolean) Implements IrowTblClients.colClientdesigneenotify
            Get
                Return m_colClientdesigneenotify
            End Get
            Set
                If Not Same(m_colClientdesigneenotify, Value) Then
                    m_colClientdesigneenotify = Value
                    m_IsDirty(FieldIndex.colClientdesigneenotify) = True
                End If
            End Set
        End Property
        Private m_colClientdesigneenotify As Nullable(Of Boolean)

        Public Property colClientdesigneename() As String Implements IrowTblClients.colClientdesigneename
            Get
                Return m_colClientdesigneename
            End Get
            Set
                If Not Same(m_colClientdesigneename, Value) Then
                    m_colClientdesigneename = Value
                    m_IsDirty(FieldIndex.colClientdesigneename) = True
                End If
            End Set
        End Property
        Private m_colClientdesigneename As String

        Public Property colClientdesigneeemail() As String Implements IrowTblClients.colClientdesigneeemail
            Get
                Return m_colClientdesigneeemail
            End Get
            Set
                If Not Same(m_colClientdesigneeemail, Value) Then
                    m_colClientdesigneeemail = Value
                    m_IsDirty(FieldIndex.colClientdesigneeemail) = True
                End If
            End Set
        End Property
        Private m_colClientdesigneeemail As String

        Public Property colActive() As Nullable(Of Boolean) Implements IrowTblClients.colActive
            Get
                Return m_colActive
            End Get
            Set
                If Not Same(m_colActive, Value) Then
                    m_colActive = Value
                    m_IsDirty(FieldIndex.colActive) = True
                End If
            End Set
        End Property
        Private m_colActive As Nullable(Of Boolean)

        Public Property colRecrespemail() As String Implements IrowTblClients.colRecrespemail
            Get
                Return m_colRecrespemail
            End Get
            Set
                If Not Same(m_colRecrespemail, Value) Then
                    m_colRecrespemail = Value
                    m_IsDirty(FieldIndex.colRecrespemail) = True
                End If
            End Set
        End Property
        Private m_colRecrespemail As String

        Public Property colRecautofollowup() As Nullable(Of Boolean) Implements IrowTblClients.colRecautofollowup
            Get
                Return m_colRecautofollowup
            End Get
            Set
                If Not Same(m_colRecautofollowup, Value) Then
                    m_colRecautofollowup = Value
                    m_IsDirty(FieldIndex.colRecautofollowup) = True
                End If
            End Set
        End Property
        Private m_colRecautofollowup As Nullable(Of Boolean)

        Public Property colRecfollowup1() As Nullable(Of Integer) Implements IrowTblClients.colRecfollowup1
            Get
                Return m_colRecfollowup1
            End Get
            Set
                If Not Same(m_colRecfollowup1, Value) Then
                    m_colRecfollowup1 = Value
                    m_IsDirty(FieldIndex.colRecfollowup1) = True
                End If
            End Set
        End Property
        Private m_colRecfollowup1 As Nullable(Of Integer)

        Public Property colRecfollowup2() As Nullable(Of Integer) Implements IrowTblClients.colRecfollowup2
            Get
                Return m_colRecfollowup2
            End Get
            Set
                If Not Same(m_colRecfollowup2, Value) Then
                    m_colRecfollowup2 = Value
                    m_IsDirty(FieldIndex.colRecfollowup2) = True
                End If
            End Set
        End Property
        Private m_colRecfollowup2 As Nullable(Of Integer)

        Public Property colRecfollowup3() As Nullable(Of Integer) Implements IrowTblClients.colRecfollowup3
            Get
                Return m_colRecfollowup3
            End Get
            Set
                If Not Same(m_colRecfollowup3, Value) Then
                    m_colRecfollowup3 = Value
                    m_IsDirty(FieldIndex.colRecfollowup3) = True
                End If
            End Set
        End Property
        Private m_colRecfollowup3 As Nullable(Of Integer)

        Public Property colDatatransfer() As String Implements IrowTblClients.colDatatransfer
            Get
                Return m_colDatatransfer
            End Get
            Set
                If Not Same(m_colDatatransfer, Value) Then
                    m_colDatatransfer = Value
                    m_IsDirty(FieldIndex.colDatatransfer) = True
                End If
            End Set
        End Property
        Private m_colDatatransfer As String

        Public Property colAutoRecStartDate() As Nullable(Of DateTime) Implements IrowTblClients.colAutoRecStartDate
            Get
                Return m_colAutoRecStartDate
            End Get
            Set
                If Not Same(m_colAutoRecStartDate, Value) Then
                    m_colAutoRecStartDate = Value
                    m_IsDirty(FieldIndex.colAutoRecStartDate) = True
                End If
            End Set
        End Property
        Private m_colAutoRecStartDate As Nullable(Of DateTime)

        Public Property colAutoRecComments() As String Implements IrowTblClients.colAutoRecComments
            Get
                Return m_colAutoRecComments
            End Get
            Set
                If Not Same(m_colAutoRecComments, Value) Then
                    m_colAutoRecComments = Value
                    m_IsDirty(FieldIndex.colAutoRecComments) = True
                End If
            End Set
        End Property
        Private m_colAutoRecComments As String

        Public Property colFireRatingKeyID() As Nullable(Of Byte) Implements IrowTblClients.colFireRatingKeyID
            Get
                Return m_colFireRatingKeyID
            End Get
            Set
                If Not Same(m_colFireRatingKeyID, Value) Then
                    m_colFireRatingKeyID = Value
                    m_IsDirty(FieldIndex.colFireRatingKeyID) = True
                End If
            End Set
        End Property
        Private m_colFireRatingKeyID As Nullable(Of Byte)

        Public Property colBMRatingKeyID() As Nullable(Of Byte) Implements IrowTblClients.colBMRatingKeyID
            Get
                Return m_colBMRatingKeyID
            End Get
            Set
                If Not Same(m_colBMRatingKeyID, Value) Then
                    m_colBMRatingKeyID = Value
                    m_IsDirty(FieldIndex.colBMRatingKeyID) = True
                End If
            End Set
        End Property
        Private m_colBMRatingKeyID As Nullable(Of Byte)

        Public Property colCustomAccessLabel() As String Implements IrowTblClients.colCustomAccessLabel
            Get
                Return m_colCustomAccessLabel
            End Get
            Set
                If Not Same(m_colCustomAccessLabel, Value) Then
                    m_colCustomAccessLabel = Value
                    m_IsDirty(FieldIndex.colCustomAccessLabel) = True
                End If
            End Set
        End Property
        Private m_colCustomAccessLabel As String

        Public Property colWORecipientName() As String Implements IrowTblClients.colWORecipientName
            Get
                Return m_colWORecipientName
            End Get
            Set
                If Not Same(m_colWORecipientName, Value) Then
                    m_colWORecipientName = Value
                    m_IsDirty(FieldIndex.colWORecipientName) = True
                End If
            End Set
        End Property
        Private m_colWORecipientName As String

        Public Property colWORecipientEmail() As String Implements IrowTblClients.colWORecipientEmail
            Get
                Return m_colWORecipientEmail
            End Get
            Set
                If Not Same(m_colWORecipientEmail, Value) Then
                    m_colWORecipientEmail = Value
                    m_IsDirty(FieldIndex.colWORecipientEmail) = True
                End If
            End Set
        End Property
        Private m_colWORecipientEmail As String

        Public Property colWOSubject() As String Implements IrowTblClients.colWOSubject
            Get
                Return m_colWOSubject
            End Get
            Set
                If Not Same(m_colWOSubject, Value) Then
                    m_colWOSubject = Value
                    m_IsDirty(FieldIndex.colWOSubject) = True
                End If
            End Set
        End Property
        Private m_colWOSubject As String

        Public Property colExchangeRateGroupID() As Nullable(Of Byte) Implements IrowTblClients.colExchangeRateGroupID
            Get
                Return m_colExchangeRateGroupID
            End Get
            Set
                If Not Same(m_colExchangeRateGroupID, Value) Then
                    m_colExchangeRateGroupID = Value
                    m_IsDirty(FieldIndex.colExchangeRateGroupID) = True
                End If
            End Set
        End Property
        Private m_colExchangeRateGroupID As Nullable(Of Byte)

        Public Property colAutoRecLastProcessDate() As Nullable(Of DateTime) Implements IrowTblClients.colAutoRecLastProcessDate
            Get
                Return m_colAutoRecLastProcessDate
            End Get
            Set
                If Not Same(m_colAutoRecLastProcessDate, Value) Then
                    m_colAutoRecLastProcessDate = Value
                    m_IsDirty(FieldIndex.colAutoRecLastProcessDate) = True
                End If
            End Set
        End Property
        Private m_colAutoRecLastProcessDate As Nullable(Of DateTime)

        Public Property colIfu() As Nullable(Of Boolean) Implements IrowTblClients.colIfu
            Get
                Return m_colIfu
            End Get
            Set
                If Not Same(m_colIfu, Value) Then
                    m_colIfu = Value
                    m_IsDirty(FieldIndex.colIfu) = True
                End If
            End Set
        End Property
        Private m_colIfu As Nullable(Of Boolean)

        Public Property colPifu1() As Nullable(Of Integer) Implements IrowTblClients.colPifu1
            Get
                Return m_colPifu1
            End Get
            Set
                If Not Same(m_colPifu1, Value) Then
                    m_colPifu1 = Value
                    m_IsDirty(FieldIndex.colPifu1) = True
                End If
            End Set
        End Property
        Private m_colPifu1 As Nullable(Of Integer)

        Public Property colPifu2() As Nullable(Of Integer) Implements IrowTblClients.colPifu2
            Get
                Return m_colPifu2
            End Get
            Set
                If Not Same(m_colPifu2, Value) Then
                    m_colPifu2 = Value
                    m_IsDirty(FieldIndex.colPifu2) = True
                End If
            End Set
        End Property
        Private m_colPifu2 As Nullable(Of Integer)

        Public Property colPifu3() As Nullable(Of Integer) Implements IrowTblClients.colPifu3
            Get
                Return m_colPifu3
            End Get
            Set
                If Not Same(m_colPifu3, Value) Then
                    m_colPifu3 = Value
                    m_IsDirty(FieldIndex.colPifu3) = True
                End If
            End Set
        End Property
        Private m_colPifu3 As Nullable(Of Integer)

        Public Property colPifu4() As Nullable(Of Integer) Implements IrowTblClients.colPifu4
            Get
                Return m_colPifu4
            End Get
            Set
                If Not Same(m_colPifu4, Value) Then
                    m_colPifu4 = Value
                    m_IsDirty(FieldIndex.colPifu4) = True
                End If
            End Set
        End Property
        Private m_colPifu4 As Nullable(Of Integer)

        Public Property colImpClientDesName1() As String Implements IrowTblClients.colImpClientDesName1
            Get
                Return m_colImpClientDesName1
            End Get
            Set
                If Not Same(m_colImpClientDesName1, Value) Then
                    m_colImpClientDesName1 = Value
                    m_IsDirty(FieldIndex.colImpClientDesName1) = True
                End If
            End Set
        End Property
        Private m_colImpClientDesName1 As String

        Public Property colImpClientDesEmail1() As String Implements IrowTblClients.colImpClientDesEmail1
            Get
                Return m_colImpClientDesEmail1
            End Get
            Set
                If Not Same(m_colImpClientDesEmail1, Value) Then
                    m_colImpClientDesEmail1 = Value
                    m_IsDirty(FieldIndex.colImpClientDesEmail1) = True
                End If
            End Set
        End Property
        Private m_colImpClientDesEmail1 As String

        Public Property colImpClientDesName2() As String Implements IrowTblClients.colImpClientDesName2
            Get
                Return m_colImpClientDesName2
            End Get
            Set
                If Not Same(m_colImpClientDesName2, Value) Then
                    m_colImpClientDesName2 = Value
                    m_IsDirty(FieldIndex.colImpClientDesName2) = True
                End If
            End Set
        End Property
        Private m_colImpClientDesName2 As String

        Public Property colImpClientDesEmail2() As String Implements IrowTblClients.colImpClientDesEmail2
            Get
                Return m_colImpClientDesEmail2
            End Get
            Set
                If Not Same(m_colImpClientDesEmail2, Value) Then
                    m_colImpClientDesEmail2 = Value
                    m_IsDirty(FieldIndex.colImpClientDesEmail2) = True
                End If
            End Set
        End Property
        Private m_colImpClientDesEmail2 As String

        Public Property colImpClientDesName3() As String Implements IrowTblClients.colImpClientDesName3
            Get
                Return m_colImpClientDesName3
            End Get
            Set
                If Not Same(m_colImpClientDesName3, Value) Then
                    m_colImpClientDesName3 = Value
                    m_IsDirty(FieldIndex.colImpClientDesName3) = True
                End If
            End Set
        End Property
        Private m_colImpClientDesName3 As String

        Public Property colImpClientDesEmail3() As String Implements IrowTblClients.colImpClientDesEmail3
            Get
                Return m_colImpClientDesEmail3
            End Get
            Set
                If Not Same(m_colImpClientDesEmail3, Value) Then
                    m_colImpClientDesEmail3 = Value
                    m_IsDirty(FieldIndex.colImpClientDesEmail3) = True
                End If
            End Set
        End Property
        Private m_colImpClientDesEmail3 As String

        Public Property colAifu() As String Implements IrowTblClients.colAifu
            Get
                Return m_colAifu
            End Get
            Set
                If Not Same(m_colAifu, Value) Then
                    m_colAifu = Value
                    m_IsDirty(FieldIndex.colAifu) = True
                End If
            End Set
        End Property
        Private m_colAifu As String

        Public Property colImpClientDesName4() As String Implements IrowTblClients.colImpClientDesName4
            Get
                Return m_colImpClientDesName4
            End Get
            Set
                If Not Same(m_colImpClientDesName4, Value) Then
                    m_colImpClientDesName4 = Value
                    m_IsDirty(FieldIndex.colImpClientDesName4) = True
                End If
            End Set
        End Property
        Private m_colImpClientDesName4 As String

        Public Property colImpClientDesEmail4() As String Implements IrowTblClients.colImpClientDesEmail4
            Get
                Return m_colImpClientDesEmail4
            End Get
            Set
                If Not Same(m_colImpClientDesEmail4, Value) Then
                    m_colImpClientDesEmail4 = Value
                    m_IsDirty(FieldIndex.colImpClientDesEmail4) = True
                End If
            End Set
        End Property
        Private m_colImpClientDesEmail4 As String

        Public Property colImpClientDesName5() As String Implements IrowTblClients.colImpClientDesName5
            Get
                Return m_colImpClientDesName5
            End Get
            Set
                If Not Same(m_colImpClientDesName5, Value) Then
                    m_colImpClientDesName5 = Value
                    m_IsDirty(FieldIndex.colImpClientDesName5) = True
                End If
            End Set
        End Property
        Private m_colImpClientDesName5 As String

        Public Property colImpClientDesEmail5() As String Implements IrowTblClients.colImpClientDesEmail5
            Get
                Return m_colImpClientDesEmail5
            End Get
            Set
                If Not Same(m_colImpClientDesEmail5, Value) Then
                    m_colImpClientDesEmail5 = Value
                    m_IsDirty(FieldIndex.colImpClientDesEmail5) = True
                End If
            End Set
        End Property
        Private m_colImpClientDesEmail5 As String

        Public Property colMgmtARR() As Nullable(Of Boolean) Implements IrowTblClients.colMgmtARR
            Get
                Return m_colMgmtARR
            End Get
            Set
                If Not Same(m_colMgmtARR, Value) Then
                    m_colMgmtARR = Value
                    m_IsDirty(FieldIndex.colMgmtARR) = True
                End If
            End Set
        End Property
        Private m_colMgmtARR As Nullable(Of Boolean)

        Public Property colImpEmailAll() As Nullable(Of Boolean) Implements IrowTblClients.colImpEmailAll
            Get
                Return m_colImpEmailAll
            End Get
            Set
                If Not Same(m_colImpEmailAll, Value) Then
                    m_colImpEmailAll = Value
                    m_IsDirty(FieldIndex.colImpEmailAll) = True
                End If
            End Set
        End Property
        Private m_colImpEmailAll As Nullable(Of Boolean)

        Public Property colSecurityPasswordExpireDays() As Nullable(Of Integer) Implements IrowTblClients.colSecurityPasswordExpireDays
            Get
                Return m_colSecurityPasswordExpireDays
            End Get
            Set
                If Not Same(m_colSecurityPasswordExpireDays, Value) Then
                    m_colSecurityPasswordExpireDays = Value
                    m_IsDirty(FieldIndex.colSecurityPasswordExpireDays) = True
                End If
            End Set
        End Property
        Private m_colSecurityPasswordExpireDays As Nullable(Of Integer)

        Public Property colSecurityInactivityLockoutDays() As Nullable(Of Integer) Implements IrowTblClients.colSecurityInactivityLockoutDays
            Get
                Return m_colSecurityInactivityLockoutDays
            End Get
            Set
                If Not Same(m_colSecurityInactivityLockoutDays, Value) Then
                    m_colSecurityInactivityLockoutDays = Value
                    m_IsDirty(FieldIndex.colSecurityInactivityLockoutDays) = True
                End If
            End Set
        End Property
        Private m_colSecurityInactivityLockoutDays As Nullable(Of Integer)

        Public Property colSecurityInactivityLockoutRemindDays() As Nullable(Of Integer) Implements IrowTblClients.colSecurityInactivityLockoutRemindDays
            Get
                Return m_colSecurityInactivityLockoutRemindDays
            End Get
            Set
                If Not Same(m_colSecurityInactivityLockoutRemindDays, Value) Then
                    m_colSecurityInactivityLockoutRemindDays = Value
                    m_IsDirty(FieldIndex.colSecurityInactivityLockoutRemindDays) = True
                End If
            End Set
        End Property
        Private m_colSecurityInactivityLockoutRemindDays As Nullable(Of Integer)

        Public Property colSecurityPasswordMinimumLength() As Nullable(Of Integer) Implements IrowTblClients.colSecurityPasswordMinimumLength
            Get
                Return m_colSecurityPasswordMinimumLength
            End Get
            Set
                If Not Same(m_colSecurityPasswordMinimumLength, Value) Then
                    m_colSecurityPasswordMinimumLength = Value
                    m_IsDirty(FieldIndex.colSecurityPasswordMinimumLength) = True
                End If
            End Set
        End Property
        Private m_colSecurityPasswordMinimumLength As Nullable(Of Integer)

        Public Property colSecurityPasswordTypeId() As Nullable(Of Integer) Implements IrowTblClients.colSecurityPasswordTypeId
            Get
                Return m_colSecurityPasswordTypeId
            End Get
            Set
                If Not Same(m_colSecurityPasswordTypeId, Value) Then
                    m_colSecurityPasswordTypeId = Value
                    m_IsDirty(FieldIndex.colSecurityPasswordTypeId) = True
                End If
            End Set
        End Property
        Private m_colSecurityPasswordTypeId As Nullable(Of Integer)

        Public Property colDataTransferPackageId() As Nullable(Of Integer) Implements IrowTblClients.colDataTransferPackageId
            Get
                Return m_colDataTransferPackageId
            End Get
            Set
                If Not Same(m_colDataTransferPackageId, Value) Then
                    m_colDataTransferPackageId = Value
                    m_IsDirty(FieldIndex.colDataTransferPackageId) = True
                End If
            End Set
        End Property
        Private m_colDataTransferPackageId As Nullable(Of Integer)

        Public Property colDataTransferPassword() As String Implements IrowTblClients.colDataTransferPassword
            Get
                Return m_colDataTransferPassword
            End Get
            Set
                If Not Same(m_colDataTransferPassword, Value) Then
                    m_colDataTransferPassword = Value
                    m_IsDirty(FieldIndex.colDataTransferPassword) = True
                End If
            End Set
        End Property
        Private m_colDataTransferPassword As String

        Public Property colDataTransferEncryptionKey() As String Implements IrowTblClients.colDataTransferEncryptionKey
            Get
                Return m_colDataTransferEncryptionKey
            End Get
            Set
                If Not Same(m_colDataTransferEncryptionKey, Value) Then
                    m_colDataTransferEncryptionKey = Value
                    m_IsDirty(FieldIndex.colDataTransferEncryptionKey) = True
                End If
            End Set
        End Property
        Private m_colDataTransferEncryptionKey As String

        Public Property colSecurityAllowChangePassword() As Nullable(Of Boolean) Implements IrowTblClients.colSecurityAllowChangePassword
            Get
                Return m_colSecurityAllowChangePassword
            End Get
            Set
                If Not Same(m_colSecurityAllowChangePassword, Value) Then
                    m_colSecurityAllowChangePassword = Value
                    m_IsDirty(FieldIndex.colSecurityAllowChangePassword) = True
                End If
            End Set
        End Property
        Private m_colSecurityAllowChangePassword As Nullable(Of Boolean)

        Public Property colReclassificationEmailSentDate() As Nullable(Of DateTime) Implements IrowTblClients.colReclassificationEmailSentDate
            Get
                Return m_colReclassificationEmailSentDate
            End Get
            Set
                If Not Same(m_colReclassificationEmailSentDate, Value) Then
                    m_colReclassificationEmailSentDate = Value
                    m_IsDirty(FieldIndex.colReclassificationEmailSentDate) = True
                End If
            End Set
        End Property
        Private m_colReclassificationEmailSentDate As Nullable(Of DateTime)

        Public Property colReclassificationEmailFollowUpDate() As Nullable(Of DateTime) Implements IrowTblClients.colReclassificationEmailFollowUpDate
            Get
                Return m_colReclassificationEmailFollowUpDate
            End Get
            Set
                If Not Same(m_colReclassificationEmailFollowUpDate, Value) Then
                    m_colReclassificationEmailFollowUpDate = Value
                    m_IsDirty(FieldIndex.colReclassificationEmailFollowUpDate) = True
                End If
            End Set
        End Property
        Private m_colReclassificationEmailFollowUpDate As Nullable(Of DateTime)

        Public Property colReclassificationCompletionDate() As Nullable(Of DateTime) Implements IrowTblClients.colReclassificationCompletionDate
            Get
                Return m_colReclassificationCompletionDate
            End Get
            Set
                If Not Same(m_colReclassificationCompletionDate, Value) Then
                    m_colReclassificationCompletionDate = Value
                    m_IsDirty(FieldIndex.colReclassificationCompletionDate) = True
                End If
            End Set
        End Property
        Private m_colReclassificationCompletionDate As Nullable(Of DateTime)

        Public Property colReclassificationLinkGUID() As String Implements IrowTblClients.colReclassificationLinkGUID
            Get
                Return m_colReclassificationLinkGUID
            End Get
            Set
                If Not Same(m_colReclassificationLinkGUID, Value) Then
                    m_colReclassificationLinkGUID = Value
                    m_IsDirty(FieldIndex.colReclassificationLinkGUID) = True
                End If
            End Set
        End Property
        Private m_colReclassificationLinkGUID As String

        Public Property colLastReclassificationCompletionDate() As Nullable(Of DateTime) Implements IrowTblClients.colLastReclassificationCompletionDate
            Get
                Return m_colLastReclassificationCompletionDate
            End Get
            Set
                If Not Same(m_colLastReclassificationCompletionDate, Value) Then
                    m_colLastReclassificationCompletionDate = Value
                    m_IsDirty(FieldIndex.colLastReclassificationCompletionDate) = True
                End If
            End Set
        End Property
        Private m_colLastReclassificationCompletionDate As Nullable(Of DateTime)

        Public Property colSysUserCreated() As String Implements IrowTblClients.colSysUserCreated
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

        Public Property colSysDateCreated() As Nullable(Of DateTime) Implements IrowTblClients.colSysDateCreated
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

        Public Property colSysUserModified() As String Implements IrowTblClients.colSysUserModified
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

        Public Property colSysDateModified() As Nullable(Of DateTime) Implements IrowTblClients.colSysDateModified
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

        Public Property colClientId() As Nullable(Of Integer) Implements IrowTblClients.colClientId
            Get
                Return m_colClientId
            End Get
            Set
                If Not Same(m_colClientId, Value) Then
                    m_colClientId = Value
                    m_IsDirty(FieldIndex.colClientId) = True
                End If
            End Set
        End Property
        Private m_colClientId As Nullable(Of Integer)

        Public Property colDataTransferPgpEnabled() As Nullable(Of Boolean) Implements IrowTblClients.colDataTransferPgpEnabled
            Get
                Return m_colDataTransferPgpEnabled
            End Get
            Set
                If Not Same(m_colDataTransferPgpEnabled, Value) Then
                    m_colDataTransferPgpEnabled = Value
                    m_IsDirty(FieldIndex.colDataTransferPgpEnabled) = True
                End If
            End Set
        End Property
        Private m_colDataTransferPgpEnabled As Nullable(Of Boolean)

        Public Property colDataTransferPgpPublicKey() As String Implements IrowTblClients.colDataTransferPgpPublicKey
            Get
                Return m_colDataTransferPgpPublicKey
            End Get
            Set
                If Not Same(m_colDataTransferPgpPublicKey, Value) Then
                    m_colDataTransferPgpPublicKey = Value
                    m_IsDirty(FieldIndex.colDataTransferPgpPublicKey) = True
                End If
            End Set
        End Property
        Private m_colDataTransferPgpPublicKey As String

        Public Property colDataTransferFtpUrl() As String Implements IrowTblClients.colDataTransferFtpUrl
            Get
                Return m_colDataTransferFtpUrl
            End Get
            Set
                If Not Same(m_colDataTransferFtpUrl, Value) Then
                    m_colDataTransferFtpUrl = Value
                    m_IsDirty(FieldIndex.colDataTransferFtpUrl) = True
                End If
            End Set
        End Property
        Private m_colDataTransferFtpUrl As String

        Public Property colDataTransferFtpUserName() As String Implements IrowTblClients.colDataTransferFtpUserName
            Get
                Return m_colDataTransferFtpUserName
            End Get
            Set
                If Not Same(m_colDataTransferFtpUserName, Value) Then
                    m_colDataTransferFtpUserName = Value
                    m_IsDirty(FieldIndex.colDataTransferFtpUserName) = True
                End If
            End Set
        End Property
        Private m_colDataTransferFtpUserName As String

        Public Property colDataTransferFtpPassword() As String Implements IrowTblClients.colDataTransferFtpPassword
            Get
                Return m_colDataTransferFtpPassword
            End Get
            Set
                If Not Same(m_colDataTransferFtpPassword, Value) Then
                    m_colDataTransferFtpPassword = Value
                    m_IsDirty(FieldIndex.colDataTransferFtpPassword) = True
                End If
            End Set
        End Property
        Private m_colDataTransferFtpPassword As String

        Public Property colDataTransferPgpFileExtension() As String Implements IrowTblClients.colDataTransferPgpFileExtension
            Get
                Return m_colDataTransferPgpFileExtension
            End Get
            Set
                If Not Same(m_colDataTransferPgpFileExtension, Value) Then
                    m_colDataTransferPgpFileExtension = Value
                    m_IsDirty(FieldIndex.colDataTransferPgpFileExtension) = True
                End If
            End Set
        End Property
        Private m_colDataTransferPgpFileExtension As String

        Public Property colDataTransferFtpEnabled() As Nullable(Of Boolean) Implements IrowTblClients.colDataTransferFtpEnabled
            Get
                Return m_colDataTransferFtpEnabled
            End Get
            Set
                If Not Same(m_colDataTransferFtpEnabled, Value) Then
                    m_colDataTransferFtpEnabled = Value
                    m_IsDirty(FieldIndex.colDataTransferFtpEnabled) = True
                End If
            End Set
        End Property
        Private m_colDataTransferFtpEnabled As Nullable(Of Boolean)

        Public Property colDataTransferRetrievalDate() As Nullable(Of DateTime) Implements IrowTblClients.colDataTransferRetrievalDate
            Get
                Return m_colDataTransferRetrievalDate
            End Get
            Set
                If Not Same(m_colDataTransferRetrievalDate, Value) Then
                    m_colDataTransferRetrievalDate = Value
                    m_IsDirty(FieldIndex.colDataTransferRetrievalDate) = True
                End If
            End Set
        End Property
        Private m_colDataTransferRetrievalDate As Nullable(Of DateTime)

        Public Property colDefaultMetaCurrencyID() As Nullable(Of Integer) Implements IrowTblClients.colDefaultMetaCurrencyID
            Get
                Return m_colDefaultMetaCurrencyID
            End Get
            Set
                If Not Same(m_colDefaultMetaCurrencyID, Value) Then
                    m_colDefaultMetaCurrencyID = Value
                    m_IsDirty(FieldIndex.colDefaultMetaCurrencyID) = True
                End If
            End Set
        End Property
        Private m_colDefaultMetaCurrencyID As Nullable(Of Integer)

        Public Property colARRRolloutOption() As String Implements IrowTblClients.colARRRolloutOption
            Get
                Return m_colARRRolloutOption
            End Get
            Set
                If Not Same(m_colARRRolloutOption, Value) Then
                    m_colARRRolloutOption = Value
                    m_IsDirty(FieldIndex.colARRRolloutOption) = True
                End If
            End Set
        End Property
        Private m_colARRRolloutOption As String

        Public Property colARRRolloutOptionDesc() As String Implements IrowTblClients.colARRRolloutOptionDesc
            Get
                Return m_colARRRolloutOptionDesc
            End Get
            Set
                If Not Same(m_colARRRolloutOptionDesc, Value) Then
                    m_colARRRolloutOptionDesc = Value
                    m_IsDirty(FieldIndex.colARRRolloutOptionDesc) = True
                End If
            End Set
        End Property
        Private m_colARRRolloutOptionDesc As String

        Public Property colImpairmentStatus() As Nullable(Of Boolean) Implements IrowTblClients.colImpairmentStatus
            Get
                Return m_colImpairmentStatus
            End Get
            Set
                If Not Same(m_colImpairmentStatus, Value) Then
                    m_colImpairmentStatus = Value
                    m_IsDirty(FieldIndex.colImpairmentStatus) = True
                End If
            End Set
        End Property
        Private m_colImpairmentStatus As Nullable(Of Boolean)

        Public Property colImpairmentSpecialHandling() As Nullable(Of Boolean) Implements IrowTblClients.colImpairmentSpecialHandling
            Get
                Return m_colImpairmentSpecialHandling
            End Get
            Set
                If Not Same(m_colImpairmentSpecialHandling, Value) Then
                    m_colImpairmentSpecialHandling = Value
                    m_IsDirty(FieldIndex.colImpairmentSpecialHandling) = True
                End If
            End Set
        End Property
        Private m_colImpairmentSpecialHandling As Nullable(Of Boolean)

        Public Property colImpairmentSpecialHandlingDesc() As String Implements IrowTblClients.colImpairmentSpecialHandlingDesc
            Get
                Return m_colImpairmentSpecialHandlingDesc
            End Get
            Set
                If Not Same(m_colImpairmentSpecialHandlingDesc, Value) Then
                    m_colImpairmentSpecialHandlingDesc = Value
                    m_IsDirty(FieldIndex.colImpairmentSpecialHandlingDesc) = True
                End If
            End Set
        End Property
        Private m_colImpairmentSpecialHandlingDesc As String

        Public Property colDataTransferFtpLocalFolder() As String Implements IrowTblClients.colDataTransferFtpLocalFolder
            Get
                Return m_colDataTransferFtpLocalFolder
            End Get
            Set
                If Not Same(m_colDataTransferFtpLocalFolder, Value) Then
                    m_colDataTransferFtpLocalFolder = Value
                    m_IsDirty(FieldIndex.colDataTransferFtpLocalFolder) = True
                End If
            End Set
        End Property
        Private m_colDataTransferFtpLocalFolder As String

        Public Property colDataTransferFileNameFormatString() As String Implements IrowTblClients.colDataTransferFileNameFormatString
            Get
                Return m_colDataTransferFileNameFormatString
            End Get
            Set
                If Not Same(m_colDataTransferFileNameFormatString, Value) Then
                    m_colDataTransferFileNameFormatString = Value
                    m_IsDirty(FieldIndex.colDataTransferFileNameFormatString) = True
                End If
            End Set
        End Property
        Private m_colDataTransferFileNameFormatString As String

        Public Property colDataTransferFtpMonthJson() As String Implements IrowTblClients.colDataTransferFtpMonthJson
            Get
                Return m_colDataTransferFtpMonthJson
            End Get
            Set
                If Not Same(m_colDataTransferFtpMonthJson, Value) Then
                    m_colDataTransferFtpMonthJson = Value
                    m_IsDirty(FieldIndex.colDataTransferFtpMonthJson) = True
                End If
            End Set
        End Property
        Private m_colDataTransferFtpMonthJson As String

        Public Property colDataTransferFtpDayJson() As String Implements IrowTblClients.colDataTransferFtpDayJson
            Get
                Return m_colDataTransferFtpDayJson
            End Get
            Set
                If Not Same(m_colDataTransferFtpDayJson, Value) Then
                    m_colDataTransferFtpDayJson = Value
                    m_IsDirty(FieldIndex.colDataTransferFtpDayJson) = True
                End If
            End Set
        End Property
        Private m_colDataTransferFtpDayJson As String

        Public Property colIndustryGroup() As String Implements IrowTblClients.colIndustryGroup
            Get
                Return m_colIndustryGroup
            End Get
            Set
                If Not Same(m_colIndustryGroup, Value) Then
                    m_colIndustryGroup = Value
                    m_IsDirty(FieldIndex.colIndustryGroup) = True
                End If
            End Set
        End Property
        Private m_colIndustryGroup As String

        Public Property colMajorGroup() As String Implements IrowTblClients.colMajorGroup
            Get
                Return m_colMajorGroup
            End Get
            Set
                If Not Same(m_colMajorGroup, Value) Then
                    m_colMajorGroup = Value
                    m_IsDirty(FieldIndex.colMajorGroup) = True
                End If
            End Set
        End Property
        Private m_colMajorGroup As String

        Public Property colSpecificGroup() As String Implements IrowTblClients.colSpecificGroup
            Get
                Return m_colSpecificGroup
            End Get
            Set
                If Not Same(m_colSpecificGroup, Value) Then
                    m_colSpecificGroup = Value
                    m_IsDirty(FieldIndex.colSpecificGroup) = True
                End If
            End Set
        End Property
        Private m_colSpecificGroup As String


        Public Function IsDirty(pIndex As rowTblClients.FieldIndex) As Boolean Implements IrowTblClients.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblClients.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblClients.SetIsDirty
            m_IsDirty(FieldIndex.colCldbname) = pDirty
            m_IsDirty(FieldIndex.colClientname) = pDirty
            m_IsDirty(FieldIndex.colFeatures) = pDirty
            m_IsDirty(FieldIndex.colFileprefix) = pDirty
            m_IsDirty(FieldIndex.colClientdesigneenotify) = pDirty
            m_IsDirty(FieldIndex.colClientdesigneename) = pDirty
            m_IsDirty(FieldIndex.colClientdesigneeemail) = pDirty
            m_IsDirty(FieldIndex.colActive) = pDirty
            m_IsDirty(FieldIndex.colRecrespemail) = pDirty
            m_IsDirty(FieldIndex.colRecautofollowup) = pDirty
            m_IsDirty(FieldIndex.colRecfollowup1) = pDirty
            m_IsDirty(FieldIndex.colRecfollowup2) = pDirty
            m_IsDirty(FieldIndex.colRecfollowup3) = pDirty
            m_IsDirty(FieldIndex.colDatatransfer) = pDirty
            m_IsDirty(FieldIndex.colAutoRecStartDate) = pDirty
            m_IsDirty(FieldIndex.colAutoRecComments) = pDirty
            m_IsDirty(FieldIndex.colFireRatingKeyID) = pDirty
            m_IsDirty(FieldIndex.colBMRatingKeyID) = pDirty
            m_IsDirty(FieldIndex.colCustomAccessLabel) = pDirty
            m_IsDirty(FieldIndex.colWORecipientName) = pDirty
            m_IsDirty(FieldIndex.colWORecipientEmail) = pDirty
            m_IsDirty(FieldIndex.colWOSubject) = pDirty
            m_IsDirty(FieldIndex.colExchangeRateGroupID) = pDirty
            m_IsDirty(FieldIndex.colAutoRecLastProcessDate) = pDirty
            m_IsDirty(FieldIndex.colIfu) = pDirty
            m_IsDirty(FieldIndex.colPifu1) = pDirty
            m_IsDirty(FieldIndex.colPifu2) = pDirty
            m_IsDirty(FieldIndex.colPifu3) = pDirty
            m_IsDirty(FieldIndex.colPifu4) = pDirty
            m_IsDirty(FieldIndex.colImpClientDesName1) = pDirty
            m_IsDirty(FieldIndex.colImpClientDesEmail1) = pDirty
            m_IsDirty(FieldIndex.colImpClientDesName2) = pDirty
            m_IsDirty(FieldIndex.colImpClientDesEmail2) = pDirty
            m_IsDirty(FieldIndex.colImpClientDesName3) = pDirty
            m_IsDirty(FieldIndex.colImpClientDesEmail3) = pDirty
            m_IsDirty(FieldIndex.colAifu) = pDirty
            m_IsDirty(FieldIndex.colImpClientDesName4) = pDirty
            m_IsDirty(FieldIndex.colImpClientDesEmail4) = pDirty
            m_IsDirty(FieldIndex.colImpClientDesName5) = pDirty
            m_IsDirty(FieldIndex.colImpClientDesEmail5) = pDirty
            m_IsDirty(FieldIndex.colMgmtARR) = pDirty
            m_IsDirty(FieldIndex.colImpEmailAll) = pDirty
            m_IsDirty(FieldIndex.colSecurityPasswordExpireDays) = pDirty
            m_IsDirty(FieldIndex.colSecurityInactivityLockoutDays) = pDirty
            m_IsDirty(FieldIndex.colSecurityInactivityLockoutRemindDays) = pDirty
            m_IsDirty(FieldIndex.colSecurityPasswordMinimumLength) = pDirty
            m_IsDirty(FieldIndex.colSecurityPasswordTypeId) = pDirty
            m_IsDirty(FieldIndex.colDataTransferPackageId) = pDirty
            m_IsDirty(FieldIndex.colDataTransferPassword) = pDirty
            m_IsDirty(FieldIndex.colDataTransferEncryptionKey) = pDirty
            m_IsDirty(FieldIndex.colSecurityAllowChangePassword) = pDirty
            m_IsDirty(FieldIndex.colReclassificationEmailSentDate) = pDirty
            m_IsDirty(FieldIndex.colReclassificationEmailFollowUpDate) = pDirty
            m_IsDirty(FieldIndex.colReclassificationCompletionDate) = pDirty
            m_IsDirty(FieldIndex.colReclassificationLinkGUID) = pDirty
            m_IsDirty(FieldIndex.colLastReclassificationCompletionDate) = pDirty
            m_IsDirty(FieldIndex.colSysUserCreated) = pDirty
            m_IsDirty(FieldIndex.colSysDateCreated) = pDirty
            m_IsDirty(FieldIndex.colSysUserModified) = pDirty
            m_IsDirty(FieldIndex.colSysDateModified) = pDirty
            m_IsDirty(FieldIndex.colClientId) = pDirty
            m_IsDirty(FieldIndex.colDataTransferPgpEnabled) = pDirty
            m_IsDirty(FieldIndex.colDataTransferPgpPublicKey) = pDirty
            m_IsDirty(FieldIndex.colDataTransferFtpUrl) = pDirty
            m_IsDirty(FieldIndex.colDataTransferFtpUserName) = pDirty
            m_IsDirty(FieldIndex.colDataTransferFtpPassword) = pDirty
            m_IsDirty(FieldIndex.colDataTransferPgpFileExtension) = pDirty
            m_IsDirty(FieldIndex.colDataTransferFtpEnabled) = pDirty
            m_IsDirty(FieldIndex.colDataTransferRetrievalDate) = pDirty
            m_IsDirty(FieldIndex.colDefaultMetaCurrencyID) = pDirty
            m_IsDirty(FieldIndex.colARRRolloutOption) = pDirty
            m_IsDirty(FieldIndex.colARRRolloutOptionDesc) = pDirty
            m_IsDirty(FieldIndex.colImpairmentStatus) = pDirty
            m_IsDirty(FieldIndex.colImpairmentSpecialHandling) = pDirty
            m_IsDirty(FieldIndex.colImpairmentSpecialHandlingDesc) = pDirty
            m_IsDirty(FieldIndex.colDataTransferFtpLocalFolder) = pDirty
            m_IsDirty(FieldIndex.colDataTransferFileNameFormatString) = pDirty
            m_IsDirty(FieldIndex.colDataTransferFtpMonthJson) = pDirty
            m_IsDirty(FieldIndex.colDataTransferFtpDayJson) = pDirty
            m_IsDirty(FieldIndex.colIndustryGroup) = pDirty
            m_IsDirty(FieldIndex.colMajorGroup) = pDirty
            m_IsDirty(FieldIndex.colSpecificGroup) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblClients) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblClients
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colCldbname  = 1
            colClientname 
            colFeatures 
            colFileprefix 
            colClientdesigneenotify 
            colClientdesigneename 
            colClientdesigneeemail 
            colActive 
            colRecrespemail 
            colRecautofollowup 
            colRecfollowup1 
            colRecfollowup2 
            colRecfollowup3 
            colDatatransfer 
            colAutoRecStartDate 
            colAutoRecComments 
            colFireRatingKeyID 
            colBMRatingKeyID 
            colCustomAccessLabel 
            colWORecipientName 
            colWORecipientEmail 
            colWOSubject 
            colExchangeRateGroupID 
            colAutoRecLastProcessDate 
            colIfu 
            colPifu1 
            colPifu2 
            colPifu3 
            colPifu4 
            colImpClientDesName1 
            colImpClientDesEmail1 
            colImpClientDesName2 
            colImpClientDesEmail2 
            colImpClientDesName3 
            colImpClientDesEmail3 
            colAifu 
            colImpClientDesName4 
            colImpClientDesEmail4 
            colImpClientDesName5 
            colImpClientDesEmail5 
            colMgmtARR 
            colImpEmailAll 
            colSecurityPasswordExpireDays 
            colSecurityInactivityLockoutDays 
            colSecurityInactivityLockoutRemindDays 
            colSecurityPasswordMinimumLength 
            colSecurityPasswordTypeId 
            colDataTransferPackageId 
            colDataTransferPassword 
            colDataTransferEncryptionKey 
            colSecurityAllowChangePassword 
            colReclassificationEmailSentDate 
            colReclassificationEmailFollowUpDate 
            colReclassificationCompletionDate 
            colReclassificationLinkGUID 
            colLastReclassificationCompletionDate 
            colSysUserCreated 
            colSysDateCreated 
            colSysUserModified 
            colSysDateModified 
            colClientId 
            colDataTransferPgpEnabled 
            colDataTransferPgpPublicKey 
            colDataTransferFtpUrl 
            colDataTransferFtpUserName 
            colDataTransferFtpPassword 
            colDataTransferPgpFileExtension 
            colDataTransferFtpEnabled 
            colDataTransferRetrievalDate 
            colDefaultMetaCurrencyID 
            colARRRolloutOption 
            colARRRolloutOptionDesc 
            colImpairmentStatus 
            colImpairmentSpecialHandling 
            colImpairmentSpecialHandlingDesc 
            colDataTransferFtpLocalFolder 
            colDataTransferFileNameFormatString 
            colDataTransferFtpMonthJson 
            colDataTransferFtpDayJson 
            colIndustryGroup 
            colMajorGroup 
            colSpecificGroup 
        End Enum

        Private m_IsDirty(83) As Boolean

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

    Public Interface IrowTblClients
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colCldbname() As String
        Property colClientname() As String
        Property colFeatures() As String
        Property colFileprefix() As String
        Property colClientdesigneenotify() As Nullable(Of Boolean)
        Property colClientdesigneename() As String
        Property colClientdesigneeemail() As String
        Property colActive() As Nullable(Of Boolean)
        Property colRecrespemail() As String
        Property colRecautofollowup() As Nullable(Of Boolean)
        Property colRecfollowup1() As Nullable(Of Integer)
        Property colRecfollowup2() As Nullable(Of Integer)
        Property colRecfollowup3() As Nullable(Of Integer)
        Property colDatatransfer() As String
        Property colAutoRecStartDate() As Nullable(Of DateTime)
        Property colAutoRecComments() As String
        Property colFireRatingKeyID() As Nullable(Of Byte)
        Property colBMRatingKeyID() As Nullable(Of Byte)
        Property colCustomAccessLabel() As String
        Property colWORecipientName() As String
        Property colWORecipientEmail() As String
        Property colWOSubject() As String
        Property colExchangeRateGroupID() As Nullable(Of Byte)
        Property colAutoRecLastProcessDate() As Nullable(Of DateTime)
        Property colIfu() As Nullable(Of Boolean)
        Property colPifu1() As Nullable(Of Integer)
        Property colPifu2() As Nullable(Of Integer)
        Property colPifu3() As Nullable(Of Integer)
        Property colPifu4() As Nullable(Of Integer)
        Property colImpClientDesName1() As String
        Property colImpClientDesEmail1() As String
        Property colImpClientDesName2() As String
        Property colImpClientDesEmail2() As String
        Property colImpClientDesName3() As String
        Property colImpClientDesEmail3() As String
        Property colAifu() As String
        Property colImpClientDesName4() As String
        Property colImpClientDesEmail4() As String
        Property colImpClientDesName5() As String
        Property colImpClientDesEmail5() As String
        Property colMgmtARR() As Nullable(Of Boolean)
        Property colImpEmailAll() As Nullable(Of Boolean)
        Property colSecurityPasswordExpireDays() As Nullable(Of Integer)
        Property colSecurityInactivityLockoutDays() As Nullable(Of Integer)
        Property colSecurityInactivityLockoutRemindDays() As Nullable(Of Integer)
        Property colSecurityPasswordMinimumLength() As Nullable(Of Integer)
        Property colSecurityPasswordTypeId() As Nullable(Of Integer)
        Property colDataTransferPackageId() As Nullable(Of Integer)
        Property colDataTransferPassword() As String
        Property colDataTransferEncryptionKey() As String
        Property colSecurityAllowChangePassword() As Nullable(Of Boolean)
        Property colReclassificationEmailSentDate() As Nullable(Of DateTime)
        Property colReclassificationEmailFollowUpDate() As Nullable(Of DateTime)
        Property colReclassificationCompletionDate() As Nullable(Of DateTime)
        Property colReclassificationLinkGUID() As String
        Property colLastReclassificationCompletionDate() As Nullable(Of DateTime)
        Property colSysUserCreated() As String
        Property colSysDateCreated() As Nullable(Of DateTime)
        Property colSysUserModified() As String
        Property colSysDateModified() As Nullable(Of DateTime)
        Property colClientId() As Nullable(Of Integer)
        Property colDataTransferPgpEnabled() As Nullable(Of Boolean)
        Property colDataTransferPgpPublicKey() As String
        Property colDataTransferFtpUrl() As String
        Property colDataTransferFtpUserName() As String
        Property colDataTransferFtpPassword() As String
        Property colDataTransferPgpFileExtension() As String
        Property colDataTransferFtpEnabled() As Nullable(Of Boolean)
        Property colDataTransferRetrievalDate() As Nullable(Of DateTime)
        Property colDefaultMetaCurrencyID() As Nullable(Of Integer)
        Property colARRRolloutOption() As String
        Property colARRRolloutOptionDesc() As String
        Property colImpairmentStatus() As Nullable(Of Boolean)
        Property colImpairmentSpecialHandling() As Nullable(Of Boolean)
        Property colImpairmentSpecialHandlingDesc() As String
        Property colDataTransferFtpLocalFolder() As String
        Property colDataTransferFileNameFormatString() As String
        Property colDataTransferFtpMonthJson() As String
        Property colDataTransferFtpDayJson() As String
        Property colIndustryGroup() As String
        Property colMajorGroup() As String
        Property colSpecificGroup() As String
        Function IsDirty(pIndex As rowTblClients.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

