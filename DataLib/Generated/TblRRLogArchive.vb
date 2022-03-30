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
    Partial Public Class TblRRLogArchive

        Public Shared Sub Delete(ByRef pRowData As IrowTblRRLogArchive)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblRRLogArchive, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblRRLogArchive, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblRRLogArchive, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colId) Then

				If UtilConfiguration.Auditing.AuditIsEnabled Then				
					pRowData.colSysUserModified=UtilConfiguration.Auditing.CurrentUserDelegate.Invoke()
					pRowData.colSysDateModified=Now()
					Save(pRowData,pTransaction,Nothing) 'Save the person who is deleting this record to the AuditUserModifiedColumnName column.
				End If

                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[RRLogArchive] " & _
                        "WHERE [ID] = @colId"

                Dim zCmd As New SQLCommand
                zCmd.CommandText = zSQL
                zCmd.Parameters.Add(New SQLParameter("@colId", pRowData.colId))

                zCmd.Transaction=pTransaction
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)

                pRowData.RaiseDeletedEvent(pDeleteEventUserState)

            End If

        End Sub

        Public Shared Sub Delete(pcolId As Integer)
            Delete(pcolId, Nothing, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolId As Integer, pDeleteEventUserState As Object)
            Delete(pcolId, Nothing, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Delete(pcolId As Integer, ByRef pTransaction As SqlClient.SqlTransaction)
        Delete(pcolId, pTransaction, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolId As Integer, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
        Dim zObj As rowTblRRLogArchive = LoadByPrimaryKey(pcolId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblRRLogArchive)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblRRLogArchive, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblRRLogArchive, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[RRLogArchive] WHERE [ID] = @colId"

                Dim zCmdDoesExist As New SQLCommand

                zCmdDoesExist.CommandText = zSQL

                zCmdDoesExist.Parameters.Add(new SQLParameter("@colId", pRowData.colId))

                'if zExistInDB > 0  then  PK exists in the DB
                zCmdDoesExist.Transaction = pTransaction
                zExistInDB = razor.UtilSQLServer.ExecuteScalar(zCmdDoesExist)
            End If

            If razor.UtilSQLServer.IsKeySet(pRowData.colId) And zExistInDB > 0 Then
                zMode = "UPDATE"
				If UtilConfiguration.Auditing.AuditIsEnabled Then				
					pRowData.colSysUserModified=UtilConfiguration.Auditing.CurrentUserDelegate.Invoke()
					pRowData.colSysDateModified=Now()
					End If			
            End If
            If razor.UtilSQLServer.IsKeySet(pRowData.colId) And zExistInDB = 0 Then
                zMode = "INSERTwithKey"
				If UtilConfiguration.Auditing.AuditIsEnabled Then
					pRowData.colSysUserCreated=UtilConfiguration.Auditing.CurrentUserDelegate.Invoke()
					pRowData.colSysDateCreated=Now()
				End If
            End If
            If Not razor.UtilSQLServer.IsKeySet(pRowData.colId) Then
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
                        zUpdate = "UPDATE [dbo].[RRLogArchive] SET " 
                        If pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colFilePrefix) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [FilePrefix] = @colFilePrefix "
                        End If
                        If pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colFileNo) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [FileNo] = @colFileNo "
                        End If
                        If pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colPracticeCode) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [PracticeCode] = @colPracticeCode "
                        End If
                        If pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colHazard) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [Hazard] = @colHazard "
                        End If
                        If pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colDateStamp) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [DateStamp] = @colDateStamp "
                        End If
                        If pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colSender) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [Sender] = @colSender "
                        End If
                        If pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colRecipientName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [RecipientName] = @colRecipientName "
                        End If
                        If pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colRecipientEmail) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [RecipientEmail] = @colRecipientEmail "
                        End If
                        If pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colActivity) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [Activity] = @colActivity "
                        End If
                        If pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colLinkActive) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [LinkActive] = @colLinkActive "
                        End If
                        If pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colLinkActivatedDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [LinkActivatedDate] = @colLinkActivatedDate "
                        End If
                        If pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colLinkActivatedBy) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [LinkActivatedBy] = @colLinkActivatedBy "
                        End If
                        If pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colLinkActivatedByEmail) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [LinkActivatedByEmail] = @colLinkActivatedByEmail "
                        End If
                        If pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colResponseActive) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ResponseActive] = @colResponseActive "
                        End If
                        If pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colResponseLastActivity) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ResponseLastActivity] = @colResponseLastActivity "
                        End If
                        If pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colChanged) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [Changed] = @colChanged "
                        End If
                        If pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colRFU1Date) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [RFU1Date] = @colRFU1Date "
                        End If
                        If pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colRFU2Date) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [RFU2Date] = @colRFU2Date "
                        End If
                        If pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colRFU3Date) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [RFU3Date] = @colRFU3Date "
                        End If
                        If pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colRRLogGuid) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [RRLogGuid] = @colRRLogGuid "
                        End If
                        If pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colCurrentLink) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [CurrentLink] = @colCurrentLink "
                        End If
                        If pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colLanguagePreference) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [LanguagePreference] = @colLanguagePreference "
                        End If
                        If pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colAdminAlertDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [AdminAlertDate] = @colAdminAlertDate "
                        End If
                        If pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colAdminAlertReason) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [AdminAlertReason] = @colAdminAlertReason "
                        End If
                        If pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colSysUserCreated) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [SysUserCreated] = @colSysUserCreated "
                        End If
                        If pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colSysDateCreated) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [SysDateCreated] = @colSysDateCreated "
                        End If
                        If pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colSysUserModified) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [SysUserModified] = @colSysUserModified "
                        End If
                        If pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colSysDateModified) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [SysDateModified] = @colSysDateModified "
                        End If
                        zWhere = " WHERE [ID] = @colId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[RRLogArchive] ([ID], [FilePrefix], [FileNo], [PracticeCode], [Hazard], [DateStamp], [Sender], [RecipientName], [RecipientEmail], [Activity], [LinkActive], [LinkActivatedDate], [LinkActivatedBy], [LinkActivatedByEmail], [ResponseActive], [ResponseLastActivity], [Changed], [RFU1Date], [RFU2Date], [RFU3Date], [RRLogGuid], [CurrentLink], [LanguagePreference], [AdminAlertDate], [AdminAlertReason], [SysUserCreated], [SysDateCreated], [SysUserModified], [SysDateModified])" & _
                            " VALUES (@colId, @colFilePrefix, @colFileNo, @colPracticeCode, @colHazard, @colDateStamp, @colSender, @colRecipientName, @colRecipientEmail, @colActivity, @colLinkActive, @colLinkActivatedDate, @colLinkActivatedBy, @colLinkActivatedByEmail, @colResponseActive, @colResponseLastActivity, @colChanged, @colRFU1Date, @colRFU2Date, @colRFU3Date, @colRRLogGuid, @colCurrentLink, @colLanguagePreference, @colAdminAlertDate, @colAdminAlertReason, @colSysUserCreated, @colSysDateCreated, @colSysUserModified, @colSysDateModified); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[RRLogArchive] ([FilePrefix], [FileNo], [PracticeCode], [Hazard], [DateStamp], [Sender], [RecipientName], [RecipientEmail], [Activity], [LinkActive], [LinkActivatedDate], [LinkActivatedBy], [LinkActivatedByEmail], [ResponseActive], [ResponseLastActivity], [Changed], [RFU1Date], [RFU2Date], [RFU3Date], [RRLogGuid], [CurrentLink], [LanguagePreference], [AdminAlertDate], [AdminAlertReason], [SysUserCreated], [SysDateCreated], [SysUserModified], [SysDateModified])" & _
                            " VALUES (@colFilePrefix, @colFileNo, @colPracticeCode, @colHazard, @colDateStamp, @colSender, @colRecipientName, @colRecipientEmail, @colActivity, @colLinkActive, @colLinkActivatedDate, @colLinkActivatedBy, @colLinkActivatedByEmail, @colResponseActive, @colResponseLastActivity, @colChanged, @colRFU1Date, @colRFU2Date, @colRFU3Date, @colRRLogGuid, @colCurrentLink, @colLanguagePreference, @colAdminAlertDate, @colAdminAlertReason, @colSysUserCreated, @colSysDateCreated, @colSysUserModified, @colSysDateModified); SELECT SCOPE_IDENTITY()"
                Case Else
            End Select

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

			'IF UPDATE, SET PK PARAMETER
            If zMode = "UPDATE" Then
                zCmd.Parameters.Add(New SQLParameter("@colId", pRowData.colId))
            End If

			'IF INSERTING, KEY HAS VALUE AND KEY IS NOT IDENTITY, SET PK PARAMETER
			If zMode = "INSERTwithKey" Then
                zCmd.Parameters.Add(New SQLParameter("@colId", pRowData.colId))
            End If

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colFilePrefix) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFilePrefix", IIf(pRowData.colFilePrefix Is Nothing, DBNull.Value, pRowData.colFilePrefix)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colFileNo) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFileNo", IIf(pRowData.colFileNo Is Nothing, DBNull.Value, pRowData.colFileNo)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colPracticeCode) Then
                    zCmd.Parameters.Add(New SqlParameter("@colPracticeCode", IIf(pRowData.colPracticeCode Is Nothing, DBNull.Value, pRowData.colPracticeCode)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colHazard) Then
                    zCmd.Parameters.Add(New SqlParameter("@colHazard", IIf(pRowData.colHazard Is Nothing, DBNull.Value, pRowData.colHazard)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colDateStamp) Then
                    zCmd.Parameters.Add(New SqlParameter("@colDateStamp", IIf(pRowData.colDateStamp Is Nothing, DBNull.Value, pRowData.colDateStamp)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colSender) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSender", IIf(pRowData.colSender Is Nothing, DBNull.Value, pRowData.colSender)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colRecipientName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colRecipientName", IIf(pRowData.colRecipientName Is Nothing, DBNull.Value, pRowData.colRecipientName)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colRecipientEmail) Then
                    zCmd.Parameters.Add(New SqlParameter("@colRecipientEmail", IIf(pRowData.colRecipientEmail Is Nothing, DBNull.Value, pRowData.colRecipientEmail)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colActivity) Then
                    zCmd.Parameters.Add(New SqlParameter("@colActivity", IIf(pRowData.colActivity Is Nothing, DBNull.Value, pRowData.colActivity)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colLinkActive) Then
                    zCmd.Parameters.Add(New SqlParameter("@colLinkActive", IIf(pRowData.colLinkActive Is Nothing, DBNull.Value, pRowData.colLinkActive)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colLinkActivatedDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colLinkActivatedDate", IIf(pRowData.colLinkActivatedDate Is Nothing, DBNull.Value, pRowData.colLinkActivatedDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colLinkActivatedBy) Then
                    zCmd.Parameters.Add(New SqlParameter("@colLinkActivatedBy", IIf(pRowData.colLinkActivatedBy Is Nothing, DBNull.Value, pRowData.colLinkActivatedBy)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colLinkActivatedByEmail) Then
                    zCmd.Parameters.Add(New SqlParameter("@colLinkActivatedByEmail", IIf(pRowData.colLinkActivatedByEmail Is Nothing, DBNull.Value, pRowData.colLinkActivatedByEmail)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colResponseActive) Then
                    zCmd.Parameters.Add(New SqlParameter("@colResponseActive", IIf(pRowData.colResponseActive Is Nothing, DBNull.Value, pRowData.colResponseActive)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colResponseLastActivity) Then
                    zCmd.Parameters.Add(New SqlParameter("@colResponseLastActivity", IIf(pRowData.colResponseLastActivity Is Nothing, DBNull.Value, pRowData.colResponseLastActivity)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colChanged) Then
                    zCmd.Parameters.Add(New SqlParameter("@colChanged", IIf(pRowData.colChanged Is Nothing, DBNull.Value, pRowData.colChanged)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colRFU1Date) Then
                    zCmd.Parameters.Add(New SqlParameter("@colRFU1Date", IIf(pRowData.colRFU1Date Is Nothing, DBNull.Value, pRowData.colRFU1Date)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colRFU2Date) Then
                    zCmd.Parameters.Add(New SqlParameter("@colRFU2Date", IIf(pRowData.colRFU2Date Is Nothing, DBNull.Value, pRowData.colRFU2Date)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colRFU3Date) Then
                    zCmd.Parameters.Add(New SqlParameter("@colRFU3Date", IIf(pRowData.colRFU3Date Is Nothing, DBNull.Value, pRowData.colRFU3Date)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colRRLogGuid) Then
                    zCmd.Parameters.Add(New SqlParameter("@colRRLogGuid", IIf(pRowData.colRRLogGuid Is Nothing, DBNull.Value, pRowData.colRRLogGuid)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colCurrentLink) Then
                    zCmd.Parameters.Add(New SqlParameter("@colCurrentLink", IIf(pRowData.colCurrentLink Is Nothing, DBNull.Value, pRowData.colCurrentLink)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colLanguagePreference) Then
                    zCmd.Parameters.Add(New SqlParameter("@colLanguagePreference", IIf(pRowData.colLanguagePreference Is Nothing, DBNull.Value, pRowData.colLanguagePreference)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colAdminAlertDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colAdminAlertDate", IIf(pRowData.colAdminAlertDate Is Nothing, DBNull.Value, pRowData.colAdminAlertDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colAdminAlertReason) Then
                    zCmd.Parameters.Add(New SqlParameter("@colAdminAlertReason", IIf(pRowData.colAdminAlertReason Is Nothing, DBNull.Value, pRowData.colAdminAlertReason)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colSysUserCreated) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSysUserCreated", IIf(pRowData.colSysUserCreated Is Nothing, DBNull.Value, pRowData.colSysUserCreated)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colSysDateCreated) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSysDateCreated", IIf(pRowData.colSysDateCreated Is Nothing, DBNull.Value, pRowData.colSysDateCreated)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colSysUserModified) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSysUserModified", IIf(pRowData.colSysUserModified Is Nothing, DBNull.Value, pRowData.colSysUserModified)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblRRLogArchive.FieldIndex.colSysDateModified) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSysDateModified", IIf(pRowData.colSysDateModified Is Nothing, DBNull.Value, pRowData.colSysDateModified)))
                End If

            zCmd.Transaction=pTransaction
            If zMode = "INSERTnoKey" Then
                Dim zLastId As Long = 0
                zLastId = razor.UtilSQLServer.ExecuteNonQueryRowId(zCmd)

                pRowData.colId = zLastId
            Else
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)
            End If

            pRowData.SetIsDirty(False)
            pRowData.RaiseSavedEvent(pSavedEventUserState)

		End If

        End Sub

        Public Shared Function LoadByPrimaryKey(pcolId As Integer) As rowTblRRLogArchive
            Return LoadByPrimaryKey(pcolId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolId As Integer, pLoadEventUserState As Object) As rowTblRRLogArchive
            Return LoadByPrimaryKey(pcolId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblRRLogArchive
            Return LoadByPrimaryKey(pcolId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblRRLogArchive
            Dim zReturn As New rowTblRRLogArchive
            Dim zSQL As String = "SELECT * FROM [dbo].[RRLogArchive] WHERE [ID] = @colId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colId", pcolId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblRRLogArchive) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK__RRLogArchive__61C7FF7F(pcolId As Integer) As List(Of rowTblRRLogArchive)
            Return LoadByIDX_PK__RRLogArchive__61C7FF7F(pcolId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__RRLogArchive__61C7FF7F(pcolId As Integer, pLoadEventUserState As Object) As List(Of rowTblRRLogArchive)
            Return LoadByIDX_PK__RRLogArchive__61C7FF7F(pcolId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__RRLogArchive__61C7FF7F(pcolId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblRRLogArchive)
            Return LoadByIDX_PK__RRLogArchive__61C7FF7F(pcolId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__RRLogArchive__61C7FF7F(pcolId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblRRLogArchive)
            Dim zReturn As New List(Of rowTblRRLogArchive)
            Dim zSQL As String = "SELECT * FROM [dbo].[RRLogArchive] WHERE [ID] = @colId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colId", pcolId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblRRLogArchive)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblRRLogArchive)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblRRLogArchive)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblRRLogArchive)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblRRLogArchive)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblRRLogArchive)
            Dim zReturn As New List(Of rowTblRRLogArchive)
            Dim zSQL As String = "SELECT * FROM [dbo].[RRLogArchive]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblRRLogArchive)

			Try
	            Dim zReturn As New List(Of rowTblRRLogArchive)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblRRLogArchive

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblRRLogArchive		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblRRLogArchive)
			If Not pReader.IsDBNull(pReader.GetOrdinal("ID")) Then pObject.colId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "ID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FilePrefix")) Then pObject.colFilePrefix = UtilSQLServer.SafeReader.SafeReadInt16(pReader, "FilePrefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FileNo")) Then pObject.colFileNo = UtilSQLServer.SafeReader.SafeReadString(pReader, "FileNo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PracticeCode")) Then pObject.colPracticeCode = UtilSQLServer.SafeReader.SafeReadInt16(pReader, "PracticeCode")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Hazard")) Then pObject.colHazard = UtilSQLServer.SafeReader.SafeReadString(pReader, "Hazard")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DateStamp")) Then pObject.colDateStamp = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "DateStamp")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Sender")) Then pObject.colSender = UtilSQLServer.SafeReader.SafeReadString(pReader, "Sender")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RecipientName")) Then pObject.colRecipientName = UtilSQLServer.SafeReader.SafeReadString(pReader, "RecipientName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RecipientEmail")) Then pObject.colRecipientEmail = UtilSQLServer.SafeReader.SafeReadString(pReader, "RecipientEmail")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Activity")) Then pObject.colActivity = UtilSQLServer.SafeReader.SafeReadString(pReader, "Activity")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LinkActive")) Then pObject.colLinkActive = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "LinkActive")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LinkActivatedDate")) Then pObject.colLinkActivatedDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "LinkActivatedDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LinkActivatedBy")) Then pObject.colLinkActivatedBy = UtilSQLServer.SafeReader.SafeReadString(pReader, "LinkActivatedBy")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LinkActivatedByEmail")) Then pObject.colLinkActivatedByEmail = UtilSQLServer.SafeReader.SafeReadString(pReader, "LinkActivatedByEmail")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ResponseActive")) Then pObject.colResponseActive = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "ResponseActive")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ResponseLastActivity")) Then pObject.colResponseLastActivity = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "ResponseLastActivity")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Changed")) Then pObject.colChanged = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "Changed")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RFU1Date")) Then pObject.colRFU1Date = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "RFU1Date")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RFU2Date")) Then pObject.colRFU2Date = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "RFU2Date")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RFU3Date")) Then pObject.colRFU3Date = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "RFU3Date")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RRLogGuid")) Then pObject.colRRLogGuid = UtilSQLServer.SafeReader.SafeReadString(pReader, "RRLogGuid")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CurrentLink")) Then pObject.colCurrentLink = UtilSQLServer.SafeReader.SafeReadString(pReader, "CurrentLink")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LanguagePreference")) Then pObject.colLanguagePreference = UtilSQLServer.SafeReader.SafeReadString(pReader, "LanguagePreference")
			If Not pReader.IsDBNull(pReader.GetOrdinal("AdminAlertDate")) Then pObject.colAdminAlertDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "AdminAlertDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("AdminAlertReason")) Then pObject.colAdminAlertReason = UtilSQLServer.SafeReader.SafeReadString(pReader, "AdminAlertReason")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SysUserCreated")) Then pObject.colSysUserCreated = UtilSQLServer.SafeReader.SafeReadString(pReader, "SysUserCreated")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SysDateCreated")) Then pObject.colSysDateCreated = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "SysDateCreated")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SysUserModified")) Then pObject.colSysUserModified = UtilSQLServer.SafeReader.SafeReadString(pReader, "SysUserModified")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SysDateModified")) Then pObject.colSysDateModified = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "SysDateModified")
			pObject.SetIsDirty(False)
			Return pObject
		End	 Function

    #Region "Reflection Based Load Functions"

        Public Shared Function LoadByPrimaryKey(Of T)(pcolId As Integer) As T
            Return LoadByPrimaryKey(Of T)(pcolId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolId As Integer, pLoadEventUserState As Object) As T
            Return LoadByPrimaryKey(Of T)(pcolId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolId As Integer, pTransaction As SqlClient.SqlTransaction) As T
            Return LoadByPrimaryKey(Of T)(pcolId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As T

            Dim zReturn As Object = Activator.CreateInstance(Of T)()
            If Not TypeOf zReturn Is rowTblRRLogArchive Then Throw New ArgumentException("Generic type is not type of rowTblRRLogArchive.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[RRLogArchive] WHERE [ID] = @colId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colId", pcolId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of T) = ReadData(Of T)(zCmd, pLoadEventUserState)
            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

        End Function

        Public Shared Function LoadByIDX_PK__RRLogArchive__61C7FF7F(Of T)(pcolId As Integer) As List(Of T)
            Return LoadByIDX_PK__RRLogArchive__61C7FF7F(Of T)(pcolId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__RRLogArchive__61C7FF7F(Of T)(pcolId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK__RRLogArchive__61C7FF7F(Of T)(pcolId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__RRLogArchive__61C7FF7F(Of T)(pcolId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK__RRLogArchive__61C7FF7F(Of T)(pcolId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK__RRLogArchive__61C7FF7F(Of T)(pcolId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[RRLogArchive] WHERE [ID] = @colId"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colId", pcolId))

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
            Dim zSQL As String = "SELECT * FROM [dbo].[RRLogArchive]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblRRLogArchive
        Implements IrowTblRRLogArchive

        Public Event Loaded(pUserState As Object) Implements IrowTblRRLogArchive.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblRRLogArchive.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblRRLogArchive.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblRRLogArchive.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblRRLogArchive.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblRRLogArchive.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colId() As Nullable(Of Integer) Implements IrowTblRRLogArchive.colId
            Get
                Return m_colId
            End Get
            Set
                If Not Same(m_colId, Value) Then
                    m_colId = Value
                    m_IsDirty(FieldIndex.colId) = True
                End If
            End Set
        End Property
        Private m_colId As Nullable(Of Integer)

        Public Property colFilePrefix() As Nullable(Of Short) Implements IrowTblRRLogArchive.colFilePrefix
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

        Public Property colFileNo() As String Implements IrowTblRRLogArchive.colFileNo
            Get
                Return m_colFileNo
            End Get
            Set
                If Not Same(m_colFileNo, Value) Then
                    m_colFileNo = Value
                    m_IsDirty(FieldIndex.colFileNo) = True
                End If
            End Set
        End Property
        Private m_colFileNo As String

        Public Property colPracticeCode() As Nullable(Of Short) Implements IrowTblRRLogArchive.colPracticeCode
            Get
                Return m_colPracticeCode
            End Get
            Set
                If Not Same(m_colPracticeCode, Value) Then
                    m_colPracticeCode = Value
                    m_IsDirty(FieldIndex.colPracticeCode) = True
                End If
            End Set
        End Property
        Private m_colPracticeCode As Nullable(Of Short)

        Public Property colHazard() As String Implements IrowTblRRLogArchive.colHazard
            Get
                Return m_colHazard
            End Get
            Set
                If Not Same(m_colHazard, Value) Then
                    m_colHazard = Value
                    m_IsDirty(FieldIndex.colHazard) = True
                End If
            End Set
        End Property
        Private m_colHazard As String

        Public Property colDateStamp() As Nullable(Of DateTime) Implements IrowTblRRLogArchive.colDateStamp
            Get
                Return m_colDateStamp
            End Get
            Set
                If Not Same(m_colDateStamp, Value) Then
                    m_colDateStamp = Value
                    m_IsDirty(FieldIndex.colDateStamp) = True
                End If
            End Set
        End Property
        Private m_colDateStamp As Nullable(Of DateTime)

        Public Property colSender() As String Implements IrowTblRRLogArchive.colSender
            Get
                Return m_colSender
            End Get
            Set
                If Not Same(m_colSender, Value) Then
                    m_colSender = Value
                    m_IsDirty(FieldIndex.colSender) = True
                End If
            End Set
        End Property
        Private m_colSender As String

        Public Property colRecipientName() As String Implements IrowTblRRLogArchive.colRecipientName
            Get
                Return m_colRecipientName
            End Get
            Set
                If Not Same(m_colRecipientName, Value) Then
                    m_colRecipientName = Value
                    m_IsDirty(FieldIndex.colRecipientName) = True
                End If
            End Set
        End Property
        Private m_colRecipientName As String

        Public Property colRecipientEmail() As String Implements IrowTblRRLogArchive.colRecipientEmail
            Get
                Return m_colRecipientEmail
            End Get
            Set
                If Not Same(m_colRecipientEmail, Value) Then
                    m_colRecipientEmail = Value
                    m_IsDirty(FieldIndex.colRecipientEmail) = True
                End If
            End Set
        End Property
        Private m_colRecipientEmail As String

        Public Property colActivity() As String Implements IrowTblRRLogArchive.colActivity
            Get
                Return m_colActivity
            End Get
            Set
                If Not Same(m_colActivity, Value) Then
                    m_colActivity = Value
                    m_IsDirty(FieldIndex.colActivity) = True
                End If
            End Set
        End Property
        Private m_colActivity As String

        Public Property colLinkActive() As Nullable(Of Boolean) Implements IrowTblRRLogArchive.colLinkActive
            Get
                Return m_colLinkActive
            End Get
            Set
                If Not Same(m_colLinkActive, Value) Then
                    m_colLinkActive = Value
                    m_IsDirty(FieldIndex.colLinkActive) = True
                End If
            End Set
        End Property
        Private m_colLinkActive As Nullable(Of Boolean)

        Public Property colLinkActivatedDate() As Nullable(Of DateTime) Implements IrowTblRRLogArchive.colLinkActivatedDate
            Get
                Return m_colLinkActivatedDate
            End Get
            Set
                If Not Same(m_colLinkActivatedDate, Value) Then
                    m_colLinkActivatedDate = Value
                    m_IsDirty(FieldIndex.colLinkActivatedDate) = True
                End If
            End Set
        End Property
        Private m_colLinkActivatedDate As Nullable(Of DateTime)

        Public Property colLinkActivatedBy() As String Implements IrowTblRRLogArchive.colLinkActivatedBy
            Get
                Return m_colLinkActivatedBy
            End Get
            Set
                If Not Same(m_colLinkActivatedBy, Value) Then
                    m_colLinkActivatedBy = Value
                    m_IsDirty(FieldIndex.colLinkActivatedBy) = True
                End If
            End Set
        End Property
        Private m_colLinkActivatedBy As String

        Public Property colLinkActivatedByEmail() As String Implements IrowTblRRLogArchive.colLinkActivatedByEmail
            Get
                Return m_colLinkActivatedByEmail
            End Get
            Set
                If Not Same(m_colLinkActivatedByEmail, Value) Then
                    m_colLinkActivatedByEmail = Value
                    m_IsDirty(FieldIndex.colLinkActivatedByEmail) = True
                End If
            End Set
        End Property
        Private m_colLinkActivatedByEmail As String

        Public Property colResponseActive() As Nullable(Of Boolean) Implements IrowTblRRLogArchive.colResponseActive
            Get
                Return m_colResponseActive
            End Get
            Set
                If Not Same(m_colResponseActive, Value) Then
                    m_colResponseActive = Value
                    m_IsDirty(FieldIndex.colResponseActive) = True
                End If
            End Set
        End Property
        Private m_colResponseActive As Nullable(Of Boolean)

        Public Property colResponseLastActivity() As Nullable(Of DateTime) Implements IrowTblRRLogArchive.colResponseLastActivity
            Get
                Return m_colResponseLastActivity
            End Get
            Set
                If Not Same(m_colResponseLastActivity, Value) Then
                    m_colResponseLastActivity = Value
                    m_IsDirty(FieldIndex.colResponseLastActivity) = True
                End If
            End Set
        End Property
        Private m_colResponseLastActivity As Nullable(Of DateTime)

        Public Property colChanged() As Nullable(Of Boolean) Implements IrowTblRRLogArchive.colChanged
            Get
                Return m_colChanged
            End Get
            Set
                If Not Same(m_colChanged, Value) Then
                    m_colChanged = Value
                    m_IsDirty(FieldIndex.colChanged) = True
                End If
            End Set
        End Property
        Private m_colChanged As Nullable(Of Boolean)

        Public Property colRFU1Date() As Nullable(Of DateTime) Implements IrowTblRRLogArchive.colRFU1Date
            Get
                Return m_colRFU1Date
            End Get
            Set
                If Not Same(m_colRFU1Date, Value) Then
                    m_colRFU1Date = Value
                    m_IsDirty(FieldIndex.colRFU1Date) = True
                End If
            End Set
        End Property
        Private m_colRFU1Date As Nullable(Of DateTime)

        Public Property colRFU2Date() As Nullable(Of DateTime) Implements IrowTblRRLogArchive.colRFU2Date
            Get
                Return m_colRFU2Date
            End Get
            Set
                If Not Same(m_colRFU2Date, Value) Then
                    m_colRFU2Date = Value
                    m_IsDirty(FieldIndex.colRFU2Date) = True
                End If
            End Set
        End Property
        Private m_colRFU2Date As Nullable(Of DateTime)

        Public Property colRFU3Date() As Nullable(Of DateTime) Implements IrowTblRRLogArchive.colRFU3Date
            Get
                Return m_colRFU3Date
            End Get
            Set
                If Not Same(m_colRFU3Date, Value) Then
                    m_colRFU3Date = Value
                    m_IsDirty(FieldIndex.colRFU3Date) = True
                End If
            End Set
        End Property
        Private m_colRFU3Date As Nullable(Of DateTime)

        Public Property colRRLogGuid() As String Implements IrowTblRRLogArchive.colRRLogGuid
            Get
                Return m_colRRLogGuid
            End Get
            Set
                If Not Same(m_colRRLogGuid, Value) Then
                    m_colRRLogGuid = Value
                    m_IsDirty(FieldIndex.colRRLogGuid) = True
                End If
            End Set
        End Property
        Private m_colRRLogGuid As String

        Public Property colCurrentLink() As String Implements IrowTblRRLogArchive.colCurrentLink
            Get
                Return m_colCurrentLink
            End Get
            Set
                If Not Same(m_colCurrentLink, Value) Then
                    m_colCurrentLink = Value
                    m_IsDirty(FieldIndex.colCurrentLink) = True
                End If
            End Set
        End Property
        Private m_colCurrentLink As String

        Public Property colLanguagePreference() As String Implements IrowTblRRLogArchive.colLanguagePreference
            Get
                Return m_colLanguagePreference
            End Get
            Set
                If Not Same(m_colLanguagePreference, Value) Then
                    m_colLanguagePreference = Value
                    m_IsDirty(FieldIndex.colLanguagePreference) = True
                End If
            End Set
        End Property
        Private m_colLanguagePreference As String

        Public Property colAdminAlertDate() As Nullable(Of DateTime) Implements IrowTblRRLogArchive.colAdminAlertDate
            Get
                Return m_colAdminAlertDate
            End Get
            Set
                If Not Same(m_colAdminAlertDate, Value) Then
                    m_colAdminAlertDate = Value
                    m_IsDirty(FieldIndex.colAdminAlertDate) = True
                End If
            End Set
        End Property
        Private m_colAdminAlertDate As Nullable(Of DateTime)

        Public Property colAdminAlertReason() As String Implements IrowTblRRLogArchive.colAdminAlertReason
            Get
                Return m_colAdminAlertReason
            End Get
            Set
                If Not Same(m_colAdminAlertReason, Value) Then
                    m_colAdminAlertReason = Value
                    m_IsDirty(FieldIndex.colAdminAlertReason) = True
                End If
            End Set
        End Property
        Private m_colAdminAlertReason As String

        Public Property colSysUserCreated() As String Implements IrowTblRRLogArchive.colSysUserCreated
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

        Public Property colSysDateCreated() As Nullable(Of DateTime) Implements IrowTblRRLogArchive.colSysDateCreated
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

        Public Property colSysUserModified() As String Implements IrowTblRRLogArchive.colSysUserModified
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

        Public Property colSysDateModified() As Nullable(Of DateTime) Implements IrowTblRRLogArchive.colSysDateModified
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


        Public Function IsDirty(pIndex As rowTblRRLogArchive.FieldIndex) As Boolean Implements IrowTblRRLogArchive.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblRRLogArchive.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblRRLogArchive.SetIsDirty
            m_IsDirty(FieldIndex.colId) = pDirty
            m_IsDirty(FieldIndex.colFilePrefix) = pDirty
            m_IsDirty(FieldIndex.colFileNo) = pDirty
            m_IsDirty(FieldIndex.colPracticeCode) = pDirty
            m_IsDirty(FieldIndex.colHazard) = pDirty
            m_IsDirty(FieldIndex.colDateStamp) = pDirty
            m_IsDirty(FieldIndex.colSender) = pDirty
            m_IsDirty(FieldIndex.colRecipientName) = pDirty
            m_IsDirty(FieldIndex.colRecipientEmail) = pDirty
            m_IsDirty(FieldIndex.colActivity) = pDirty
            m_IsDirty(FieldIndex.colLinkActive) = pDirty
            m_IsDirty(FieldIndex.colLinkActivatedDate) = pDirty
            m_IsDirty(FieldIndex.colLinkActivatedBy) = pDirty
            m_IsDirty(FieldIndex.colLinkActivatedByEmail) = pDirty
            m_IsDirty(FieldIndex.colResponseActive) = pDirty
            m_IsDirty(FieldIndex.colResponseLastActivity) = pDirty
            m_IsDirty(FieldIndex.colChanged) = pDirty
            m_IsDirty(FieldIndex.colRFU1Date) = pDirty
            m_IsDirty(FieldIndex.colRFU2Date) = pDirty
            m_IsDirty(FieldIndex.colRFU3Date) = pDirty
            m_IsDirty(FieldIndex.colRRLogGuid) = pDirty
            m_IsDirty(FieldIndex.colCurrentLink) = pDirty
            m_IsDirty(FieldIndex.colLanguagePreference) = pDirty
            m_IsDirty(FieldIndex.colAdminAlertDate) = pDirty
            m_IsDirty(FieldIndex.colAdminAlertReason) = pDirty
            m_IsDirty(FieldIndex.colSysUserCreated) = pDirty
            m_IsDirty(FieldIndex.colSysDateCreated) = pDirty
            m_IsDirty(FieldIndex.colSysUserModified) = pDirty
            m_IsDirty(FieldIndex.colSysDateModified) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblRRLogArchive) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblRRLogArchive
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colId  = 1
            colFilePrefix 
            colFileNo 
            colPracticeCode 
            colHazard 
            colDateStamp 
            colSender 
            colRecipientName 
            colRecipientEmail 
            colActivity 
            colLinkActive 
            colLinkActivatedDate 
            colLinkActivatedBy 
            colLinkActivatedByEmail 
            colResponseActive 
            colResponseLastActivity 
            colChanged 
            colRFU1Date 
            colRFU2Date 
            colRFU3Date 
            colRRLogGuid 
            colCurrentLink 
            colLanguagePreference 
            colAdminAlertDate 
            colAdminAlertReason 
            colSysUserCreated 
            colSysDateCreated 
            colSysUserModified 
            colSysDateModified 
        End Enum

        Private m_IsDirty(29) As Boolean

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

    Public Interface IrowTblRRLogArchive
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colId() As Nullable(Of Integer)
        Property colFilePrefix() As Nullable(Of Short)
        Property colFileNo() As String
        Property colPracticeCode() As Nullable(Of Short)
        Property colHazard() As String
        Property colDateStamp() As Nullable(Of DateTime)
        Property colSender() As String
        Property colRecipientName() As String
        Property colRecipientEmail() As String
        Property colActivity() As String
        Property colLinkActive() As Nullable(Of Boolean)
        Property colLinkActivatedDate() As Nullable(Of DateTime)
        Property colLinkActivatedBy() As String
        Property colLinkActivatedByEmail() As String
        Property colResponseActive() As Nullable(Of Boolean)
        Property colResponseLastActivity() As Nullable(Of DateTime)
        Property colChanged() As Nullable(Of Boolean)
        Property colRFU1Date() As Nullable(Of DateTime)
        Property colRFU2Date() As Nullable(Of DateTime)
        Property colRFU3Date() As Nullable(Of DateTime)
        Property colRRLogGuid() As String
        Property colCurrentLink() As String
        Property colLanguagePreference() As String
        Property colAdminAlertDate() As Nullable(Of DateTime)
        Property colAdminAlertReason() As String
        Property colSysUserCreated() As String
        Property colSysDateCreated() As Nullable(Of DateTime)
        Property colSysUserModified() As String
        Property colSysDateModified() As Nullable(Of DateTime)
        Function IsDirty(pIndex As rowTblRRLogArchive.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

