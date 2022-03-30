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
    Partial Public Class TblMetaSource

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaSource)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaSource, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaSource, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaSource, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[tblMetaSource] " & _
                        "WHERE [fldId] = @colFldId"

                Dim zCmd As New SQLCommand
                zCmd.CommandText = zSQL
                zCmd.Parameters.Add(New SQLParameter("@colFldId", pRowData.colFldId))

                zCmd.Transaction=pTransaction
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)

                pRowData.RaiseDeletedEvent(pDeleteEventUserState)

            End If

        End Sub

        Public Shared Sub Delete(pcolFldId As Integer)
            Delete(pcolFldId, Nothing, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolFldId As Integer, pDeleteEventUserState As Object)
            Delete(pcolFldId, Nothing, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Delete(pcolFldId As Integer, ByRef pTransaction As SqlClient.SqlTransaction)
        Delete(pcolFldId, pTransaction, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolFldId As Integer, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
        Dim zObj As rowTblMetaSource = LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblMetaSource)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaSource, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaSource, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[tblMetaSource] WHERE [fldId] = @colFldId"

                Dim zCmdDoesExist As New SQLCommand

                zCmdDoesExist.CommandText = zSQL

                zCmdDoesExist.Parameters.Add(new SQLParameter("@colFldId", pRowData.colFldId))

                'if zExistInDB > 0  then  PK exists in the DB
                zCmdDoesExist.Transaction = pTransaction
                zExistInDB = razor.UtilSQLServer.ExecuteScalar(zCmdDoesExist)
            End If

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) And zExistInDB > 0 Then
                zMode = "UPDATE"
            End If
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) And zExistInDB = 0 Then
                zMode = "INSERTwithKey"
            End If
            If Not razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then
                zMode = "INSERTnoKey"
            End If

            Select Case zMode
                Case "UPDATE"
                    If pRowData.IsDirty Then
                        Dim zUpdate As String = ""
                        Dim zSet As String = ""
                        Dim zWhere As String = ""
                        zUpdate = "UPDATE [dbo].[tblMetaSource] SET " 
                        If pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldSchemaName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldSchemaName] = @colFldSchemaName "
                        End If
                        If pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldObjectName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldObjectName] = @colFldObjectName "
                        End If
                        If pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldOrderBy) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldOrderBy] = @colFldOrderBy "
                        End If
                        If pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldJoinFieldName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldJoinFieldName] = @colFldJoinFieldName "
                        End If
                        If pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldIsJoinRequired) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldIsJoinRequired] = @colFldIsJoinRequired "
                        End If
                        If pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldHasCurrencyParm) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldHasCurrencyParm] = @colFldHasCurrencyParm "
                        End If
                        If pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldHasUnitParm) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldHasUnitParm] = @colFldHasUnitParm "
                        End If
                        If pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldHasFileNoParm) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldHasFileNoParm] = @colFldHasFileNoParm "
                        End If
                        If pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldHasFilePrefixParm) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldHasFilePrefixParm] = @colFldHasFilePrefixParm "
                        End If
                        If pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldType) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldType] = @colFldType "
                        End If
                        If pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldHasDivisionParm) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldHasDivisionParm] = @colFldHasDivisionParm "
                        End If
                        If pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldHasCountryParm) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldHasCountryParm] = @colFldHasCountryParm "
                        End If
                        If pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldHasCustomAccessParm) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldHasCustomAccessParm] = @colFldHasCustomAccessParm "
                        End If
                        If pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldObjectId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldObjectId] = @colFldObjectId "
                        End If
                        If pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldParameterFlag) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldParameterFlag] = @colFldParameterFlag "
                        End If
                        If pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldHasLanguageParm) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldHasLanguageParm] = @colFldHasLanguageParm "
                        End If
                        If pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldHasImpStartDateParm) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldHasImpStartDateParm] = @colFldHasImpStartDateParm "
                        End If
                        If pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldHasImpEndDateParm) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldHasImpEndDateParm] = @colFldHasImpEndDateParm "
                        End If
                        If pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldHasInspProgramYearParm) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldHasInspProgramYearParm] = @colFldHasInspProgramYearParm "
                        End If
                        If pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldHasTIVParm) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldHasTIVParm] = @colFldHasTIVParm "
                        End If
                        If pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldHasRecStatusParm) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldHasRecStatusParm] = @colFldHasRecStatusParm "
                        End If
                        If pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldHasHazardParm) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldHasHazardParm] = @colFldHasHazardParm "
                        End If
                        If pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldHasTIVValueParm) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldHasTIVValueParm] = @colFldHasTIVValueParm "
                        End If
                        If pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldHasAutoRequestParm) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldHasAutoRequestParm] = @colFldHasAutoRequestParm "
                        End If
                        If pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldComment) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldComment] = @colFldComment "
                        End If
                        If pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldUniqueFieldName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldUniqueFieldName] = @colFldUniqueFieldName "
                        End If
                        zWhere = " WHERE [fldId] = @colFldId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaSource] ([fldSchemaName], [fldObjectName], [fldOrderBy], [fldJoinFieldName], [fldIsJoinRequired], [fldHasCurrencyParm], [fldHasUnitParm], [fldHasFileNoParm], [fldHasFilePrefixParm], [fldType], [fldHasDivisionParm], [fldHasCountryParm], [fldHasCustomAccessParm], [fldObjectId], [fldParameterFlag], [fldHasLanguageParm], [fldHasImpStartDateParm], [fldHasImpEndDateParm], [fldHasInspProgramYearParm], [fldHasTIVParm], [fldHasRecStatusParm], [fldHasHazardParm], [fldHasTIVValueParm], [fldHasAutoRequestParm], [fldComment], [fldUniqueFieldName])" & _
                            " VALUES (@colFldSchemaName, @colFldObjectName, @colFldOrderBy, @colFldJoinFieldName, @colFldIsJoinRequired, @colFldHasCurrencyParm, @colFldHasUnitParm, @colFldHasFileNoParm, @colFldHasFilePrefixParm, @colFldType, @colFldHasDivisionParm, @colFldHasCountryParm, @colFldHasCustomAccessParm, @colFldObjectId, @colFldParameterFlag, @colFldHasLanguageParm, @colFldHasImpStartDateParm, @colFldHasImpEndDateParm, @colFldHasInspProgramYearParm, @colFldHasTIVParm, @colFldHasRecStatusParm, @colFldHasHazardParm, @colFldHasTIVValueParm, @colFldHasAutoRequestParm, @colFldComment, @colFldUniqueFieldName); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaSource] ([fldSchemaName], [fldObjectName], [fldOrderBy], [fldJoinFieldName], [fldIsJoinRequired], [fldHasCurrencyParm], [fldHasUnitParm], [fldHasFileNoParm], [fldHasFilePrefixParm], [fldType], [fldHasDivisionParm], [fldHasCountryParm], [fldHasCustomAccessParm], [fldObjectId], [fldParameterFlag], [fldHasLanguageParm], [fldHasImpStartDateParm], [fldHasImpEndDateParm], [fldHasInspProgramYearParm], [fldHasTIVParm], [fldHasRecStatusParm], [fldHasHazardParm], [fldHasTIVValueParm], [fldHasAutoRequestParm], [fldComment], [fldUniqueFieldName])" & _
                            " VALUES (@colFldSchemaName, @colFldObjectName, @colFldOrderBy, @colFldJoinFieldName, @colFldIsJoinRequired, @colFldHasCurrencyParm, @colFldHasUnitParm, @colFldHasFileNoParm, @colFldHasFilePrefixParm, @colFldType, @colFldHasDivisionParm, @colFldHasCountryParm, @colFldHasCustomAccessParm, @colFldObjectId, @colFldParameterFlag, @colFldHasLanguageParm, @colFldHasImpStartDateParm, @colFldHasImpEndDateParm, @colFldHasInspProgramYearParm, @colFldHasTIVParm, @colFldHasRecStatusParm, @colFldHasHazardParm, @colFldHasTIVValueParm, @colFldHasAutoRequestParm, @colFldComment, @colFldUniqueFieldName); SELECT SCOPE_IDENTITY()"
                Case Else
            End Select

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

			'IF UPDATE, SET PK PARAMETER
            If zMode = "UPDATE" Then
                zCmd.Parameters.Add(New SQLParameter("@colFldId", pRowData.colFldId))
            End If

			'IF INSERTING, KEY HAS VALUE AND KEY IS NOT IDENTITY, SET PK PARAMETER
			If zMode = "INSERTwithKey" Then
            End If

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldSchemaName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldSchemaName", IIf(pRowData.colFldSchemaName Is Nothing, DBNull.Value, pRowData.colFldSchemaName)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldObjectName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldObjectName", IIf(pRowData.colFldObjectName Is Nothing, DBNull.Value, pRowData.colFldObjectName)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldOrderBy) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldOrderBy", IIf(pRowData.colFldOrderBy Is Nothing, DBNull.Value, pRowData.colFldOrderBy)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldJoinFieldName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldJoinFieldName", IIf(pRowData.colFldJoinFieldName Is Nothing, DBNull.Value, pRowData.colFldJoinFieldName)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldIsJoinRequired) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldIsJoinRequired", IIf(pRowData.colFldIsJoinRequired Is Nothing, DBNull.Value, pRowData.colFldIsJoinRequired)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldHasCurrencyParm) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldHasCurrencyParm", IIf(pRowData.colFldHasCurrencyParm Is Nothing, DBNull.Value, pRowData.colFldHasCurrencyParm)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldHasUnitParm) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldHasUnitParm", IIf(pRowData.colFldHasUnitParm Is Nothing, DBNull.Value, pRowData.colFldHasUnitParm)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldHasFileNoParm) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldHasFileNoParm", IIf(pRowData.colFldHasFileNoParm Is Nothing, DBNull.Value, pRowData.colFldHasFileNoParm)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldHasFilePrefixParm) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldHasFilePrefixParm", IIf(pRowData.colFldHasFilePrefixParm Is Nothing, DBNull.Value, pRowData.colFldHasFilePrefixParm)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldType) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldType", IIf(pRowData.colFldType Is Nothing, DBNull.Value, pRowData.colFldType)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldHasDivisionParm) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldHasDivisionParm", IIf(pRowData.colFldHasDivisionParm Is Nothing, DBNull.Value, pRowData.colFldHasDivisionParm)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldHasCountryParm) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldHasCountryParm", IIf(pRowData.colFldHasCountryParm Is Nothing, DBNull.Value, pRowData.colFldHasCountryParm)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldHasCustomAccessParm) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldHasCustomAccessParm", IIf(pRowData.colFldHasCustomAccessParm Is Nothing, DBNull.Value, pRowData.colFldHasCustomAccessParm)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldObjectId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldObjectId", IIf(pRowData.colFldObjectId Is Nothing, DBNull.Value, pRowData.colFldObjectId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldParameterFlag) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldParameterFlag", IIf(pRowData.colFldParameterFlag Is Nothing, DBNull.Value, pRowData.colFldParameterFlag)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldHasLanguageParm) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldHasLanguageParm", IIf(pRowData.colFldHasLanguageParm Is Nothing, DBNull.Value, pRowData.colFldHasLanguageParm)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldHasImpStartDateParm) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldHasImpStartDateParm", IIf(pRowData.colFldHasImpStartDateParm Is Nothing, DBNull.Value, pRowData.colFldHasImpStartDateParm)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldHasImpEndDateParm) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldHasImpEndDateParm", IIf(pRowData.colFldHasImpEndDateParm Is Nothing, DBNull.Value, pRowData.colFldHasImpEndDateParm)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldHasInspProgramYearParm) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldHasInspProgramYearParm", IIf(pRowData.colFldHasInspProgramYearParm Is Nothing, DBNull.Value, pRowData.colFldHasInspProgramYearParm)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldHasTIVParm) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldHasTIVParm", IIf(pRowData.colFldHasTIVParm Is Nothing, DBNull.Value, pRowData.colFldHasTIVParm)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldHasRecStatusParm) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldHasRecStatusParm", IIf(pRowData.colFldHasRecStatusParm Is Nothing, DBNull.Value, pRowData.colFldHasRecStatusParm)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldHasHazardParm) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldHasHazardParm", IIf(pRowData.colFldHasHazardParm Is Nothing, DBNull.Value, pRowData.colFldHasHazardParm)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldHasTIVValueParm) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldHasTIVValueParm", IIf(pRowData.colFldHasTIVValueParm Is Nothing, DBNull.Value, pRowData.colFldHasTIVValueParm)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldHasAutoRequestParm) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldHasAutoRequestParm", IIf(pRowData.colFldHasAutoRequestParm Is Nothing, DBNull.Value, pRowData.colFldHasAutoRequestParm)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldComment) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldComment", IIf(pRowData.colFldComment Is Nothing, DBNull.Value, pRowData.colFldComment)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaSource.FieldIndex.colFldUniqueFieldName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldUniqueFieldName", IIf(pRowData.colFldUniqueFieldName Is Nothing, DBNull.Value, pRowData.colFldUniqueFieldName)))
                End If

            zCmd.Transaction=pTransaction
            If zMode = "INSERTnoKey" Then
                Dim zLastId As Long = 0
                zLastId = razor.UtilSQLServer.ExecuteNonQueryRowId(zCmd)

                pRowData.colFldId = zLastId
            Else
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)
            End If

            pRowData.SetIsDirty(False)
            pRowData.RaiseSavedEvent(pSavedEventUserState)

		End If

        End Sub

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer) As rowTblMetaSource
            Return LoadByPrimaryKey(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pLoadEventUserState As Object) As rowTblMetaSource
            Return LoadByPrimaryKey(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblMetaSource
            Return LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblMetaSource
            Dim zReturn As New rowTblMetaSource
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaSource] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblMetaSource) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_IX_object_name(pcolFldObjectName As String) As List(Of rowTblMetaSource)
            Return LoadByIDX_IX_object_name(pcolFldObjectName, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_object_name(pcolFldObjectName As String, pLoadEventUserState As Object) As List(Of rowTblMetaSource)
            Return LoadByIDX_IX_object_name(pcolFldObjectName, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_object_name(pcolFldObjectName As String, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaSource)
            Return LoadByIDX_IX_object_name(pcolFldObjectName, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_object_name(pcolFldObjectName As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaSource)
            Dim zReturn As New List(Of rowTblMetaSource)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaSource] WHERE [fldObjectName] = @colFldObjectName"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldObjectName", pcolFldObjectName))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function
        Public Shared Function LoadByIDX_PK__tblSQLMa__3213E83F41462154(pcolFldId As Integer) As List(Of rowTblMetaSource)
            Return LoadByIDX_PK__tblSQLMa__3213E83F41462154(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblSQLMa__3213E83F41462154(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of rowTblMetaSource)
            Return LoadByIDX_PK__tblSQLMa__3213E83F41462154(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblSQLMa__3213E83F41462154(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaSource)
            Return LoadByIDX_PK__tblSQLMa__3213E83F41462154(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblSQLMa__3213E83F41462154(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaSource)
            Dim zReturn As New List(Of rowTblMetaSource)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaSource] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblMetaSource)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblMetaSource)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblMetaSource)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaSource)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaSource)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaSource)
            Dim zReturn As New List(Of rowTblMetaSource)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaSource]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblMetaSource)

			Try
	            Dim zReturn As New List(Of rowTblMetaSource)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblMetaSource

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblMetaSource		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblMetaSource)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldId")) Then pObject.colFldId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSchemaName")) Then pObject.colFldSchemaName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldSchemaName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldObjectName")) Then pObject.colFldObjectName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldObjectName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldOrderBy")) Then pObject.colFldOrderBy = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldOrderBy")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldJoinFieldName")) Then pObject.colFldJoinFieldName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldJoinFieldName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldIsJoinRequired")) Then pObject.colFldIsJoinRequired = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldIsJoinRequired")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldHasCurrencyParm")) Then pObject.colFldHasCurrencyParm = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldHasCurrencyParm")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldHasUnitParm")) Then pObject.colFldHasUnitParm = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldHasUnitParm")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldHasFileNoParm")) Then pObject.colFldHasFileNoParm = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldHasFileNoParm")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldHasFilePrefixParm")) Then pObject.colFldHasFilePrefixParm = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldHasFilePrefixParm")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldType")) Then pObject.colFldType = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldType")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldHasDivisionParm")) Then pObject.colFldHasDivisionParm = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldHasDivisionParm")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldHasCountryParm")) Then pObject.colFldHasCountryParm = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldHasCountryParm")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldHasCustomAccessParm")) Then pObject.colFldHasCustomAccessParm = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldHasCustomAccessParm")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldObjectId")) Then pObject.colFldObjectId = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "fldObjectId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldParameterFlag")) Then pObject.colFldParameterFlag = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldParameterFlag")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldHasLanguageParm")) Then pObject.colFldHasLanguageParm = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldHasLanguageParm")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldHasImpStartDateParm")) Then pObject.colFldHasImpStartDateParm = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldHasImpStartDateParm")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldHasImpEndDateParm")) Then pObject.colFldHasImpEndDateParm = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldHasImpEndDateParm")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldHasInspProgramYearParm")) Then pObject.colFldHasInspProgramYearParm = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldHasInspProgramYearParm")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldHasTIVParm")) Then pObject.colFldHasTIVParm = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldHasTIVParm")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldHasRecStatusParm")) Then pObject.colFldHasRecStatusParm = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldHasRecStatusParm")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldHasHazardParm")) Then pObject.colFldHasHazardParm = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldHasHazardParm")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldHasTIVValueParm")) Then pObject.colFldHasTIVValueParm = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldHasTIVValueParm")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldHasAutoRequestParm")) Then pObject.colFldHasAutoRequestParm = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldHasAutoRequestParm")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldComment")) Then pObject.colFldComment = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldComment")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldUniqueFieldName")) Then pObject.colFldUniqueFieldName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldUniqueFieldName")
			pObject.SetIsDirty(False)
			Return pObject
		End	 Function

    #Region "Reflection Based Load Functions"

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldId As Integer) As T
            Return LoadByPrimaryKey(Of T)(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldId As Integer, pLoadEventUserState As Object) As T
            Return LoadByPrimaryKey(Of T)(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As T
            Return LoadByPrimaryKey(Of T)(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As T

            Dim zReturn As Object = Activator.CreateInstance(Of T)()
            If Not TypeOf zReturn Is rowTblMetaSource Then Throw New ArgumentException("Generic type is not type of rowTblMetaSource.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaSource] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of T) = ReadData(Of T)(zCmd, pLoadEventUserState)
            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

        End Function

        Public Shared Function LoadByIDX_IX_object_name(Of T)(pcolFldObjectName As String) As List(Of T)
            Return LoadByIDX_IX_object_name(Of T)(pcolFldObjectName, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_object_name(Of T)(pcolFldObjectName As String, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_IX_object_name(Of T)(pcolFldObjectName, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_object_name(Of T)(pcolFldObjectName As String, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_IX_object_name(Of T)(pcolFldObjectName, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_IX_object_name(Of T)(pcolFldObjectName As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaSource] WHERE [fldObjectName] = @colFldObjectName"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldObjectName", pcolFldObjectName))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_PK__tblSQLMa__3213E83F41462154(Of T)(pcolFldId As Integer) As List(Of T)
            Return LoadByIDX_PK__tblSQLMa__3213E83F41462154(Of T)(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblSQLMa__3213E83F41462154(Of T)(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK__tblSQLMa__3213E83F41462154(Of T)(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblSQLMa__3213E83F41462154(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK__tblSQLMa__3213E83F41462154(Of T)(pcolFldId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK__tblSQLMa__3213E83F41462154(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaSource] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

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
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaSource]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblMetaSource
        Implements IrowTblMetaSource

        Public Event Loaded(pUserState As Object) Implements IrowTblMetaSource.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblMetaSource.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblMetaSource.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblMetaSource.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblMetaSource.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblMetaSource.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldId() As Nullable(Of Integer) Implements IrowTblMetaSource.colFldId
            Get
                Return m_colFldId
            End Get
            Set
                If Not Same(m_colFldId, Value) Then
                    m_colFldId = Value
                    m_IsDirty(FieldIndex.colFldId) = True
                End If
            End Set
        End Property
        Private m_colFldId As Nullable(Of Integer)

        Public Property colFldSchemaName() As String Implements IrowTblMetaSource.colFldSchemaName
            Get
                Return m_colFldSchemaName
            End Get
            Set
                If Not Same(m_colFldSchemaName, Value) Then
                    m_colFldSchemaName = Value
                    m_IsDirty(FieldIndex.colFldSchemaName) = True
                End If
            End Set
        End Property
        Private m_colFldSchemaName As String

        Public Property colFldObjectName() As String Implements IrowTblMetaSource.colFldObjectName
            Get
                Return m_colFldObjectName
            End Get
            Set
                If Not Same(m_colFldObjectName, Value) Then
                    m_colFldObjectName = Value
                    m_IsDirty(FieldIndex.colFldObjectName) = True
                End If
            End Set
        End Property
        Private m_colFldObjectName As String

        Public Property colFldOrderBy() As String Implements IrowTblMetaSource.colFldOrderBy
            Get
                Return m_colFldOrderBy
            End Get
            Set
                If Not Same(m_colFldOrderBy, Value) Then
                    m_colFldOrderBy = Value
                    m_IsDirty(FieldIndex.colFldOrderBy) = True
                End If
            End Set
        End Property
        Private m_colFldOrderBy As String

        Public Property colFldJoinFieldName() As String Implements IrowTblMetaSource.colFldJoinFieldName
            Get
                Return m_colFldJoinFieldName
            End Get
            Set
                If Not Same(m_colFldJoinFieldName, Value) Then
                    m_colFldJoinFieldName = Value
                    m_IsDirty(FieldIndex.colFldJoinFieldName) = True
                End If
            End Set
        End Property
        Private m_colFldJoinFieldName As String

        Public Property colFldIsJoinRequired() As Nullable(Of Boolean) Implements IrowTblMetaSource.colFldIsJoinRequired
            Get
                Return m_colFldIsJoinRequired
            End Get
            Set
                If Not Same(m_colFldIsJoinRequired, Value) Then
                    m_colFldIsJoinRequired = Value
                    m_IsDirty(FieldIndex.colFldIsJoinRequired) = True
                End If
            End Set
        End Property
        Private m_colFldIsJoinRequired As Nullable(Of Boolean)

        Public Property colFldHasCurrencyParm() As Nullable(Of Boolean) Implements IrowTblMetaSource.colFldHasCurrencyParm
            Get
                Return m_colFldHasCurrencyParm
            End Get
            Set
                If Not Same(m_colFldHasCurrencyParm, Value) Then
                    m_colFldHasCurrencyParm = Value
                    m_IsDirty(FieldIndex.colFldHasCurrencyParm) = True
                End If
            End Set
        End Property
        Private m_colFldHasCurrencyParm As Nullable(Of Boolean)

        Public Property colFldHasUnitParm() As Nullable(Of Boolean) Implements IrowTblMetaSource.colFldHasUnitParm
            Get
                Return m_colFldHasUnitParm
            End Get
            Set
                If Not Same(m_colFldHasUnitParm, Value) Then
                    m_colFldHasUnitParm = Value
                    m_IsDirty(FieldIndex.colFldHasUnitParm) = True
                End If
            End Set
        End Property
        Private m_colFldHasUnitParm As Nullable(Of Boolean)

        Public Property colFldHasFileNoParm() As Nullable(Of Boolean) Implements IrowTblMetaSource.colFldHasFileNoParm
            Get
                Return m_colFldHasFileNoParm
            End Get
            Set
                If Not Same(m_colFldHasFileNoParm, Value) Then
                    m_colFldHasFileNoParm = Value
                    m_IsDirty(FieldIndex.colFldHasFileNoParm) = True
                End If
            End Set
        End Property
        Private m_colFldHasFileNoParm As Nullable(Of Boolean)

        Public Property colFldHasFilePrefixParm() As Nullable(Of Boolean) Implements IrowTblMetaSource.colFldHasFilePrefixParm
            Get
                Return m_colFldHasFilePrefixParm
            End Get
            Set
                If Not Same(m_colFldHasFilePrefixParm, Value) Then
                    m_colFldHasFilePrefixParm = Value
                    m_IsDirty(FieldIndex.colFldHasFilePrefixParm) = True
                End If
            End Set
        End Property
        Private m_colFldHasFilePrefixParm As Nullable(Of Boolean)

        Public Property colFldType() As Nullable(Of Integer) Implements IrowTblMetaSource.colFldType
            Get
                Return m_colFldType
            End Get
            Set
                If Not Same(m_colFldType, Value) Then
                    m_colFldType = Value
                    m_IsDirty(FieldIndex.colFldType) = True
                End If
            End Set
        End Property
        Private m_colFldType As Nullable(Of Integer)

        Public Property colFldHasDivisionParm() As Nullable(Of Boolean) Implements IrowTblMetaSource.colFldHasDivisionParm
            Get
                Return m_colFldHasDivisionParm
            End Get
            Set
                If Not Same(m_colFldHasDivisionParm, Value) Then
                    m_colFldHasDivisionParm = Value
                    m_IsDirty(FieldIndex.colFldHasDivisionParm) = True
                End If
            End Set
        End Property
        Private m_colFldHasDivisionParm As Nullable(Of Boolean)

        Public Property colFldHasCountryParm() As Nullable(Of Boolean) Implements IrowTblMetaSource.colFldHasCountryParm
            Get
                Return m_colFldHasCountryParm
            End Get
            Set
                If Not Same(m_colFldHasCountryParm, Value) Then
                    m_colFldHasCountryParm = Value
                    m_IsDirty(FieldIndex.colFldHasCountryParm) = True
                End If
            End Set
        End Property
        Private m_colFldHasCountryParm As Nullable(Of Boolean)

        Public Property colFldHasCustomAccessParm() As Nullable(Of Boolean) Implements IrowTblMetaSource.colFldHasCustomAccessParm
            Get
                Return m_colFldHasCustomAccessParm
            End Get
            Set
                If Not Same(m_colFldHasCustomAccessParm, Value) Then
                    m_colFldHasCustomAccessParm = Value
                    m_IsDirty(FieldIndex.colFldHasCustomAccessParm) = True
                End If
            End Set
        End Property
        Private m_colFldHasCustomAccessParm As Nullable(Of Boolean)

        Public Property colFldObjectId() As Nullable(Of Long) Implements IrowTblMetaSource.colFldObjectId
            Get
                Return m_colFldObjectId
            End Get
            Set
                If Not Same(m_colFldObjectId, Value) Then
                    m_colFldObjectId = Value
                    m_IsDirty(FieldIndex.colFldObjectId) = True
                End If
            End Set
        End Property
        Private m_colFldObjectId As Nullable(Of Long)

        Public Property colFldParameterFlag() As Nullable(Of Integer) Implements IrowTblMetaSource.colFldParameterFlag
            Get
                Return m_colFldParameterFlag
            End Get
            Set
                If Not Same(m_colFldParameterFlag, Value) Then
                    m_colFldParameterFlag = Value
                    m_IsDirty(FieldIndex.colFldParameterFlag) = True
                End If
            End Set
        End Property
        Private m_colFldParameterFlag As Nullable(Of Integer)

        Public Property colFldHasLanguageParm() As Nullable(Of Boolean) Implements IrowTblMetaSource.colFldHasLanguageParm
            Get
                Return m_colFldHasLanguageParm
            End Get
            Set
                If Not Same(m_colFldHasLanguageParm, Value) Then
                    m_colFldHasLanguageParm = Value
                    m_IsDirty(FieldIndex.colFldHasLanguageParm) = True
                End If
            End Set
        End Property
        Private m_colFldHasLanguageParm As Nullable(Of Boolean)

        Public Property colFldHasImpStartDateParm() As Nullable(Of Boolean) Implements IrowTblMetaSource.colFldHasImpStartDateParm
            Get
                Return m_colFldHasImpStartDateParm
            End Get
            Set
                If Not Same(m_colFldHasImpStartDateParm, Value) Then
                    m_colFldHasImpStartDateParm = Value
                    m_IsDirty(FieldIndex.colFldHasImpStartDateParm) = True
                End If
            End Set
        End Property
        Private m_colFldHasImpStartDateParm As Nullable(Of Boolean)

        Public Property colFldHasImpEndDateParm() As Nullable(Of Boolean) Implements IrowTblMetaSource.colFldHasImpEndDateParm
            Get
                Return m_colFldHasImpEndDateParm
            End Get
            Set
                If Not Same(m_colFldHasImpEndDateParm, Value) Then
                    m_colFldHasImpEndDateParm = Value
                    m_IsDirty(FieldIndex.colFldHasImpEndDateParm) = True
                End If
            End Set
        End Property
        Private m_colFldHasImpEndDateParm As Nullable(Of Boolean)

        Public Property colFldHasInspProgramYearParm() As Nullable(Of Boolean) Implements IrowTblMetaSource.colFldHasInspProgramYearParm
            Get
                Return m_colFldHasInspProgramYearParm
            End Get
            Set
                If Not Same(m_colFldHasInspProgramYearParm, Value) Then
                    m_colFldHasInspProgramYearParm = Value
                    m_IsDirty(FieldIndex.colFldHasInspProgramYearParm) = True
                End If
            End Set
        End Property
        Private m_colFldHasInspProgramYearParm As Nullable(Of Boolean)

        Public Property colFldHasTIVParm() As Nullable(Of Boolean) Implements IrowTblMetaSource.colFldHasTIVParm
            Get
                Return m_colFldHasTIVParm
            End Get
            Set
                If Not Same(m_colFldHasTIVParm, Value) Then
                    m_colFldHasTIVParm = Value
                    m_IsDirty(FieldIndex.colFldHasTIVParm) = True
                End If
            End Set
        End Property
        Private m_colFldHasTIVParm As Nullable(Of Boolean)

        Public Property colFldHasRecStatusParm() As Nullable(Of Boolean) Implements IrowTblMetaSource.colFldHasRecStatusParm
            Get
                Return m_colFldHasRecStatusParm
            End Get
            Set
                If Not Same(m_colFldHasRecStatusParm, Value) Then
                    m_colFldHasRecStatusParm = Value
                    m_IsDirty(FieldIndex.colFldHasRecStatusParm) = True
                End If
            End Set
        End Property
        Private m_colFldHasRecStatusParm As Nullable(Of Boolean)

        Public Property colFldHasHazardParm() As Nullable(Of Boolean) Implements IrowTblMetaSource.colFldHasHazardParm
            Get
                Return m_colFldHasHazardParm
            End Get
            Set
                If Not Same(m_colFldHasHazardParm, Value) Then
                    m_colFldHasHazardParm = Value
                    m_IsDirty(FieldIndex.colFldHasHazardParm) = True
                End If
            End Set
        End Property
        Private m_colFldHasHazardParm As Nullable(Of Boolean)

        Public Property colFldHasTIVValueParm() As Nullable(Of Boolean) Implements IrowTblMetaSource.colFldHasTIVValueParm
            Get
                Return m_colFldHasTIVValueParm
            End Get
            Set
                If Not Same(m_colFldHasTIVValueParm, Value) Then
                    m_colFldHasTIVValueParm = Value
                    m_IsDirty(FieldIndex.colFldHasTIVValueParm) = True
                End If
            End Set
        End Property
        Private m_colFldHasTIVValueParm As Nullable(Of Boolean)

        Public Property colFldHasAutoRequestParm() As Nullable(Of Boolean) Implements IrowTblMetaSource.colFldHasAutoRequestParm
            Get
                Return m_colFldHasAutoRequestParm
            End Get
            Set
                If Not Same(m_colFldHasAutoRequestParm, Value) Then
                    m_colFldHasAutoRequestParm = Value
                    m_IsDirty(FieldIndex.colFldHasAutoRequestParm) = True
                End If
            End Set
        End Property
        Private m_colFldHasAutoRequestParm As Nullable(Of Boolean)

        Public Property colFldComment() As String Implements IrowTblMetaSource.colFldComment
            Get
                Return m_colFldComment
            End Get
            Set
                If Not Same(m_colFldComment, Value) Then
                    m_colFldComment = Value
                    m_IsDirty(FieldIndex.colFldComment) = True
                End If
            End Set
        End Property
        Private m_colFldComment As String

        Public Property colFldUniqueFieldName() As String Implements IrowTblMetaSource.colFldUniqueFieldName
            Get
                Return m_colFldUniqueFieldName
            End Get
            Set
                If Not Same(m_colFldUniqueFieldName, Value) Then
                    m_colFldUniqueFieldName = Value
                    m_IsDirty(FieldIndex.colFldUniqueFieldName) = True
                End If
            End Set
        End Property
        Private m_colFldUniqueFieldName As String


        Public Function IsDirty(pIndex As rowTblMetaSource.FieldIndex) As Boolean Implements IrowTblMetaSource.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblMetaSource.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblMetaSource.SetIsDirty
            m_IsDirty(FieldIndex.colFldId) = pDirty
            m_IsDirty(FieldIndex.colFldSchemaName) = pDirty
            m_IsDirty(FieldIndex.colFldObjectName) = pDirty
            m_IsDirty(FieldIndex.colFldOrderBy) = pDirty
            m_IsDirty(FieldIndex.colFldJoinFieldName) = pDirty
            m_IsDirty(FieldIndex.colFldIsJoinRequired) = pDirty
            m_IsDirty(FieldIndex.colFldHasCurrencyParm) = pDirty
            m_IsDirty(FieldIndex.colFldHasUnitParm) = pDirty
            m_IsDirty(FieldIndex.colFldHasFileNoParm) = pDirty
            m_IsDirty(FieldIndex.colFldHasFilePrefixParm) = pDirty
            m_IsDirty(FieldIndex.colFldType) = pDirty
            m_IsDirty(FieldIndex.colFldHasDivisionParm) = pDirty
            m_IsDirty(FieldIndex.colFldHasCountryParm) = pDirty
            m_IsDirty(FieldIndex.colFldHasCustomAccessParm) = pDirty
            m_IsDirty(FieldIndex.colFldObjectId) = pDirty
            m_IsDirty(FieldIndex.colFldParameterFlag) = pDirty
            m_IsDirty(FieldIndex.colFldHasLanguageParm) = pDirty
            m_IsDirty(FieldIndex.colFldHasImpStartDateParm) = pDirty
            m_IsDirty(FieldIndex.colFldHasImpEndDateParm) = pDirty
            m_IsDirty(FieldIndex.colFldHasInspProgramYearParm) = pDirty
            m_IsDirty(FieldIndex.colFldHasTIVParm) = pDirty
            m_IsDirty(FieldIndex.colFldHasRecStatusParm) = pDirty
            m_IsDirty(FieldIndex.colFldHasHazardParm) = pDirty
            m_IsDirty(FieldIndex.colFldHasTIVValueParm) = pDirty
            m_IsDirty(FieldIndex.colFldHasAutoRequestParm) = pDirty
            m_IsDirty(FieldIndex.colFldComment) = pDirty
            m_IsDirty(FieldIndex.colFldUniqueFieldName) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblMetaSource) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblMetaSource
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldId  = 1
            colFldSchemaName 
            colFldObjectName 
            colFldOrderBy 
            colFldJoinFieldName 
            colFldIsJoinRequired 
            colFldHasCurrencyParm 
            colFldHasUnitParm 
            colFldHasFileNoParm 
            colFldHasFilePrefixParm 
            colFldType 
            colFldHasDivisionParm 
            colFldHasCountryParm 
            colFldHasCustomAccessParm 
            colFldObjectId 
            colFldParameterFlag 
            colFldHasLanguageParm 
            colFldHasImpStartDateParm 
            colFldHasImpEndDateParm 
            colFldHasInspProgramYearParm 
            colFldHasTIVParm 
            colFldHasRecStatusParm 
            colFldHasHazardParm 
            colFldHasTIVValueParm 
            colFldHasAutoRequestParm 
            colFldComment 
            colFldUniqueFieldName 
        End Enum

        Private m_IsDirty(27) As Boolean

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

    Public Interface IrowTblMetaSource
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldId() As Nullable(Of Integer)
        Property colFldSchemaName() As String
        Property colFldObjectName() As String
        Property colFldOrderBy() As String
        Property colFldJoinFieldName() As String
        Property colFldIsJoinRequired() As Nullable(Of Boolean)
        Property colFldHasCurrencyParm() As Nullable(Of Boolean)
        Property colFldHasUnitParm() As Nullable(Of Boolean)
        Property colFldHasFileNoParm() As Nullable(Of Boolean)
        Property colFldHasFilePrefixParm() As Nullable(Of Boolean)
        Property colFldType() As Nullable(Of Integer)
        Property colFldHasDivisionParm() As Nullable(Of Boolean)
        Property colFldHasCountryParm() As Nullable(Of Boolean)
        Property colFldHasCustomAccessParm() As Nullable(Of Boolean)
        Property colFldObjectId() As Nullable(Of Long)
        Property colFldParameterFlag() As Nullable(Of Integer)
        Property colFldHasLanguageParm() As Nullable(Of Boolean)
        Property colFldHasImpStartDateParm() As Nullable(Of Boolean)
        Property colFldHasImpEndDateParm() As Nullable(Of Boolean)
        Property colFldHasInspProgramYearParm() As Nullable(Of Boolean)
        Property colFldHasTIVParm() As Nullable(Of Boolean)
        Property colFldHasRecStatusParm() As Nullable(Of Boolean)
        Property colFldHasHazardParm() As Nullable(Of Boolean)
        Property colFldHasTIVValueParm() As Nullable(Of Boolean)
        Property colFldHasAutoRequestParm() As Nullable(Of Boolean)
        Property colFldComment() As String
        Property colFldUniqueFieldName() As String
        Function IsDirty(pIndex As rowTblMetaSource.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

