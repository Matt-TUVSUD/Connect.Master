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
    Partial Public Class TblBatchProcessingSet

        Public Shared Sub Delete(ByRef pRowData As IrowTblBatchProcessingSet)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblBatchProcessingSet, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblBatchProcessingSet, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblBatchProcessingSet, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[tblBatchProcessingSet] " & _
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
        Dim zObj As rowTblBatchProcessingSet = LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblBatchProcessingSet)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblBatchProcessingSet, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblBatchProcessingSet, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[tblBatchProcessingSet] WHERE [fldId] = @colFldId"

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
                        zUpdate = "UPDATE [dbo].[tblBatchProcessingSet] SET " 
                        If pRowData.IsDirty(rowTblBatchProcessingSet.FieldIndex.colFldCreateDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldCreateDate] = @colFldCreateDate "
                        End If
                        If pRowData.IsDirty(rowTblBatchProcessingSet.FieldIndex.colFldFilePrefix) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldFilePrefix] = @colFldFilePrefix "
                        End If
                        If pRowData.IsDirty(rowTblBatchProcessingSet.FieldIndex.colFldSetTypeID) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldSetTypeID] = @colFldSetTypeID "
                        End If
                        If pRowData.IsDirty(rowTblBatchProcessingSet.FieldIndex.colFldFileName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldFileName] = @colFldFileName "
                        End If
                        If pRowData.IsDirty(rowTblBatchProcessingSet.FieldIndex.colFldStatusId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldStatusId] = @colFldStatusId "
                        End If
                        If pRowData.IsDirty(rowTblBatchProcessingSet.FieldIndex.colFldDisable) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldDisable] = @colFldDisable "
                        End If
                        If pRowData.IsDirty(rowTblBatchProcessingSet.FieldIndex.colFldLOFilterJSON) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldLOFilterJSON] = @colFldLOFilterJSON "
                        End If
                        If pRowData.IsDirty(rowTblBatchProcessingSet.FieldIndex.colFldLOCriteriaJSON) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldLOCriteriaJSON] = @colFldLOCriteriaJSON "
                        End If
                        If pRowData.IsDirty(rowTblBatchProcessingSet.FieldIndex.colFldLOSortJSON) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldLOSortJSON] = @colFldLOSortJSON "
                        End If
                        If pRowData.IsDirty(rowTblBatchProcessingSet.FieldIndex.colFldLOSettingJSON) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldLOSettingJSON] = @colFldLOSettingJSON "
                        End If
                        If pRowData.IsDirty(rowTblBatchProcessingSet.FieldIndex.colFldMetaParameterJSON) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldMetaParameterJSON] = @colFldMetaParameterJSON "
                        End If
                        If pRowData.IsDirty(rowTblBatchProcessingSet.FieldIndex.colFldCreatedByGsafeId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldCreatedByGsafeId] = @colFldCreatedByGsafeId "
                        End If
                        If pRowData.IsDirty(rowTblBatchProcessingSet.FieldIndex.colFldIsInteractive) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldIsInteractive] = @colFldIsInteractive "
                        End If
                        If pRowData.IsDirty(rowTblBatchProcessingSet.FieldIndex.colFldIsMyBatchReport) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldIsMyBatchReport] = @colFldIsMyBatchReport "
                        End If
                        If pRowData.IsDirty(rowTblBatchProcessingSet.FieldIndex.colFldCreatedByGsafeUserEmail) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldCreatedByGsafeUserEmail] = @colFldCreatedByGsafeUserEmail "
                        End If
                        If pRowData.IsDirty(rowTblBatchProcessingSet.FieldIndex.colFldLOMyPreferenceJSON) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldLOMyPreferenceJSON] = @colFldLOMyPreferenceJSON "
                        End If
                        zWhere = " WHERE [fldId] = @colFldId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[tblBatchProcessingSet] ([fldCreateDate], [fldFilePrefix], [fldSetTypeID], [fldFileName], [fldStatusId], [fldDisable], [fldLOFilterJSON], [fldLOCriteriaJSON], [fldLOSortJSON], [fldLOSettingJSON], [fldMetaParameterJSON], [fldCreatedByGsafeId], [fldIsInteractive], [fldIsMyBatchReport], [fldCreatedByGsafeUserEmail], [fldLOMyPreferenceJSON])" & _
                            " VALUES (@colFldCreateDate, @colFldFilePrefix, @colFldSetTypeID, @colFldFileName, @colFldStatusId, @colFldDisable, @colFldLOFilterJSON, @colFldLOCriteriaJSON, @colFldLOSortJSON, @colFldLOSettingJSON, @colFldMetaParameterJSON, @colFldCreatedByGsafeId, @colFldIsInteractive, @colFldIsMyBatchReport, @colFldCreatedByGsafeUserEmail, @colFldLOMyPreferenceJSON); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[tblBatchProcessingSet] ([fldCreateDate], [fldFilePrefix], [fldSetTypeID], [fldFileName], [fldStatusId], [fldDisable], [fldLOFilterJSON], [fldLOCriteriaJSON], [fldLOSortJSON], [fldLOSettingJSON], [fldMetaParameterJSON], [fldCreatedByGsafeId], [fldIsInteractive], [fldIsMyBatchReport], [fldCreatedByGsafeUserEmail], [fldLOMyPreferenceJSON])" & _
                            " VALUES (@colFldCreateDate, @colFldFilePrefix, @colFldSetTypeID, @colFldFileName, @colFldStatusId, @colFldDisable, @colFldLOFilterJSON, @colFldLOCriteriaJSON, @colFldLOSortJSON, @colFldLOSettingJSON, @colFldMetaParameterJSON, @colFldCreatedByGsafeId, @colFldIsInteractive, @colFldIsMyBatchReport, @colFldCreatedByGsafeUserEmail, @colFldLOMyPreferenceJSON); SELECT SCOPE_IDENTITY()"
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

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblBatchProcessingSet.FieldIndex.colFldCreateDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldCreateDate", IIf(pRowData.colFldCreateDate Is Nothing, DBNull.Value, pRowData.colFldCreateDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblBatchProcessingSet.FieldIndex.colFldFilePrefix) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldFilePrefix", IIf(pRowData.colFldFilePrefix Is Nothing, DBNull.Value, pRowData.colFldFilePrefix)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblBatchProcessingSet.FieldIndex.colFldSetTypeID) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldSetTypeID", IIf(pRowData.colFldSetTypeID Is Nothing, DBNull.Value, pRowData.colFldSetTypeID)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblBatchProcessingSet.FieldIndex.colFldFileName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldFileName", IIf(pRowData.colFldFileName Is Nothing, DBNull.Value, pRowData.colFldFileName)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblBatchProcessingSet.FieldIndex.colFldStatusId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldStatusId", IIf(pRowData.colFldStatusId Is Nothing, DBNull.Value, pRowData.colFldStatusId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblBatchProcessingSet.FieldIndex.colFldDisable) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldDisable", IIf(pRowData.colFldDisable Is Nothing, DBNull.Value, pRowData.colFldDisable)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblBatchProcessingSet.FieldIndex.colFldLOFilterJSON) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldLOFilterJSON", IIf(pRowData.colFldLOFilterJSON Is Nothing, DBNull.Value, pRowData.colFldLOFilterJSON)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblBatchProcessingSet.FieldIndex.colFldLOCriteriaJSON) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldLOCriteriaJSON", IIf(pRowData.colFldLOCriteriaJSON Is Nothing, DBNull.Value, pRowData.colFldLOCriteriaJSON)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblBatchProcessingSet.FieldIndex.colFldLOSortJSON) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldLOSortJSON", IIf(pRowData.colFldLOSortJSON Is Nothing, DBNull.Value, pRowData.colFldLOSortJSON)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblBatchProcessingSet.FieldIndex.colFldLOSettingJSON) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldLOSettingJSON", IIf(pRowData.colFldLOSettingJSON Is Nothing, DBNull.Value, pRowData.colFldLOSettingJSON)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblBatchProcessingSet.FieldIndex.colFldMetaParameterJSON) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldMetaParameterJSON", IIf(pRowData.colFldMetaParameterJSON Is Nothing, DBNull.Value, pRowData.colFldMetaParameterJSON)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblBatchProcessingSet.FieldIndex.colFldCreatedByGsafeId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldCreatedByGsafeId", IIf(pRowData.colFldCreatedByGsafeId Is Nothing, DBNull.Value, pRowData.colFldCreatedByGsafeId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblBatchProcessingSet.FieldIndex.colFldIsInteractive) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldIsInteractive", IIf(pRowData.colFldIsInteractive Is Nothing, DBNull.Value, pRowData.colFldIsInteractive)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblBatchProcessingSet.FieldIndex.colFldIsMyBatchReport) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldIsMyBatchReport", IIf(pRowData.colFldIsMyBatchReport Is Nothing, DBNull.Value, pRowData.colFldIsMyBatchReport)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblBatchProcessingSet.FieldIndex.colFldCreatedByGsafeUserEmail) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldCreatedByGsafeUserEmail", IIf(pRowData.colFldCreatedByGsafeUserEmail Is Nothing, DBNull.Value, pRowData.colFldCreatedByGsafeUserEmail)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblBatchProcessingSet.FieldIndex.colFldLOMyPreferenceJSON) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldLOMyPreferenceJSON", IIf(pRowData.colFldLOMyPreferenceJSON Is Nothing, DBNull.Value, pRowData.colFldLOMyPreferenceJSON)))
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

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer) As rowTblBatchProcessingSet
            Return LoadByPrimaryKey(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pLoadEventUserState As Object) As rowTblBatchProcessingSet
            Return LoadByPrimaryKey(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblBatchProcessingSet
            Return LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblBatchProcessingSet
            Dim zReturn As New rowTblBatchProcessingSet
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingSet] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblBatchProcessingSet) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_IX_fldGSafeID(pcolFldCreatedByGsafeId As Integer) As List(Of rowTblBatchProcessingSet)
            Return LoadByIDX_IX_fldGSafeID(pcolFldCreatedByGsafeId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_fldGSafeID(pcolFldCreatedByGsafeId As Integer, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingSet)
            Return LoadByIDX_IX_fldGSafeID(pcolFldCreatedByGsafeId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_fldGSafeID(pcolFldCreatedByGsafeId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblBatchProcessingSet)
            Return LoadByIDX_IX_fldGSafeID(pcolFldCreatedByGsafeId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_fldGSafeID(pcolFldCreatedByGsafeId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingSet)
            Dim zReturn As New List(Of rowTblBatchProcessingSet)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingSet] WHERE [fldCreatedByGsafeId] = @colFldCreatedByGsafeId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldCreatedByGsafeId", pcolFldCreatedByGsafeId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function
        Public Shared Function LoadByIDX_IX_fldStatusID(pcolFldStatusId As Integer) As List(Of rowTblBatchProcessingSet)
            Return LoadByIDX_IX_fldStatusID(pcolFldStatusId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_fldStatusID(pcolFldStatusId As Integer, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingSet)
            Return LoadByIDX_IX_fldStatusID(pcolFldStatusId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_fldStatusID(pcolFldStatusId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblBatchProcessingSet)
            Return LoadByIDX_IX_fldStatusID(pcolFldStatusId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_fldStatusID(pcolFldStatusId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingSet)
            Dim zReturn As New List(Of rowTblBatchProcessingSet)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingSet] WHERE [fldStatusId] = @colFldStatusId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldStatusId", pcolFldStatusId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function
        Public Shared Function LoadByIDX_IX_fldStatusID_fldSetTypeID(pcolFldStatusId As Integer, pcolFldSetTypeID As Integer) As List(Of rowTblBatchProcessingSet)
            Return LoadByIDX_IX_fldStatusID_fldSetTypeID(pcolFldStatusId, pcolFldSetTypeID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_fldStatusID_fldSetTypeID(pcolFldStatusId As Integer, pcolFldSetTypeID As Integer, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingSet)
            Return LoadByIDX_IX_fldStatusID_fldSetTypeID(pcolFldStatusId, pcolFldSetTypeID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_fldStatusID_fldSetTypeID(pcolFldStatusId As Integer, pcolFldSetTypeID As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblBatchProcessingSet)
            Return LoadByIDX_IX_fldStatusID_fldSetTypeID(pcolFldStatusId, pcolFldSetTypeID, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_fldStatusID_fldSetTypeID(pcolFldStatusId As Integer, pcolFldSetTypeID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingSet)
            Dim zReturn As New List(Of rowTblBatchProcessingSet)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingSet] WHERE [fldStatusId] = @colFldStatusId AND [fldSetTypeID] = @colFldSetTypeID"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldStatusId", pcolFldStatusId))
            zCmd.Parameters.Add(New SQLParameter("@colFldSetTypeID", pcolFldSetTypeID))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function
        Public Shared Function LoadByIDX_PK__tblBatch__36326BE35E4252B5(pcolFldId As Integer) As List(Of rowTblBatchProcessingSet)
            Return LoadByIDX_PK__tblBatch__36326BE35E4252B5(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblBatch__36326BE35E4252B5(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingSet)
            Return LoadByIDX_PK__tblBatch__36326BE35E4252B5(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblBatch__36326BE35E4252B5(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblBatchProcessingSet)
            Return LoadByIDX_PK__tblBatch__36326BE35E4252B5(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblBatch__36326BE35E4252B5(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingSet)
            Dim zReturn As New List(Of rowTblBatchProcessingSet)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingSet] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblBatchProcessingSet)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblBatchProcessingSet)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblBatchProcessingSet)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblBatchProcessingSet)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingSet)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingSet)
            Dim zReturn As New List(Of rowTblBatchProcessingSet)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingSet]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingSet)

			Try
	            Dim zReturn As New List(Of rowTblBatchProcessingSet)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblBatchProcessingSet

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblBatchProcessingSet		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblBatchProcessingSet)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldId")) Then pObject.colFldId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldCreateDate")) Then pObject.colFldCreateDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "fldCreateDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFilePrefix")) Then pObject.colFldFilePrefix = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldFilePrefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSetTypeID")) Then pObject.colFldSetTypeID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldSetTypeID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFileName")) Then pObject.colFldFileName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldFileName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldStatusId")) Then pObject.colFldStatusId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldStatusId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldDisable")) Then pObject.colFldDisable = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldDisable")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldLOFilterJSON")) Then pObject.colFldLOFilterJSON = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldLOFilterJSON")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldLOCriteriaJSON")) Then pObject.colFldLOCriteriaJSON = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldLOCriteriaJSON")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldLOSortJSON")) Then pObject.colFldLOSortJSON = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldLOSortJSON")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldLOSettingJSON")) Then pObject.colFldLOSettingJSON = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldLOSettingJSON")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldMetaParameterJSON")) Then pObject.colFldMetaParameterJSON = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldMetaParameterJSON")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldCreatedByGsafeId")) Then pObject.colFldCreatedByGsafeId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldCreatedByGsafeId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldIsInteractive")) Then pObject.colFldIsInteractive = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldIsInteractive")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldIsMyBatchReport")) Then pObject.colFldIsMyBatchReport = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldIsMyBatchReport")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldCreatedByGsafeUserEmail")) Then pObject.colFldCreatedByGsafeUserEmail = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldCreatedByGsafeUserEmail")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldLOMyPreferenceJSON")) Then pObject.colFldLOMyPreferenceJSON = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldLOMyPreferenceJSON")
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
            If Not TypeOf zReturn Is rowTblBatchProcessingSet Then Throw New ArgumentException("Generic type is not type of rowTblBatchProcessingSet.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingSet] WHERE [fldId] = @colFldId"
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

        Public Shared Function LoadByIDX_IX_fldGSafeID(Of T)(pcolFldCreatedByGsafeId As Integer) As List(Of T)
            Return LoadByIDX_IX_fldGSafeID(Of T)(pcolFldCreatedByGsafeId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_fldGSafeID(Of T)(pcolFldCreatedByGsafeId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_IX_fldGSafeID(Of T)(pcolFldCreatedByGsafeId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_fldGSafeID(Of T)(pcolFldCreatedByGsafeId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_IX_fldGSafeID(Of T)(pcolFldCreatedByGsafeId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_IX_fldGSafeID(Of T)(pcolFldCreatedByGsafeId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingSet] WHERE [fldCreatedByGsafeId] = @colFldCreatedByGsafeId"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldCreatedByGsafeId", pcolFldCreatedByGsafeId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_IX_fldStatusID(Of T)(pcolFldStatusId As Integer) As List(Of T)
            Return LoadByIDX_IX_fldStatusID(Of T)(pcolFldStatusId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_fldStatusID(Of T)(pcolFldStatusId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_IX_fldStatusID(Of T)(pcolFldStatusId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_fldStatusID(Of T)(pcolFldStatusId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_IX_fldStatusID(Of T)(pcolFldStatusId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_IX_fldStatusID(Of T)(pcolFldStatusId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingSet] WHERE [fldStatusId] = @colFldStatusId"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldStatusId", pcolFldStatusId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_IX_fldStatusID_fldSetTypeID(Of T)(pcolFldStatusId As Integer, pcolFldSetTypeID As Integer) As List(Of T)
            Return LoadByIDX_IX_fldStatusID_fldSetTypeID(Of T)(pcolFldStatusId, pcolFldSetTypeID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_fldStatusID_fldSetTypeID(Of T)(pcolFldStatusId As Integer, pcolFldSetTypeID As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_IX_fldStatusID_fldSetTypeID(Of T)(pcolFldStatusId, pcolFldSetTypeID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_fldStatusID_fldSetTypeID(Of T)(pcolFldStatusId As Integer, pcolFldSetTypeID As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_IX_fldStatusID_fldSetTypeID(Of T)(pcolFldStatusId, pcolFldSetTypeID, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_IX_fldStatusID_fldSetTypeID(Of T)(pcolFldStatusId As Integer, pcolFldSetTypeID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingSet] WHERE [fldStatusId] = @colFldStatusId AND [fldSetTypeID] = @colFldSetTypeID"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldStatusId", pcolFldStatusId))
            zCmd.Parameters.Add(New SQLParameter("@colFldSetTypeID", pcolFldSetTypeID))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_PK__tblBatch__36326BE35E4252B5(Of T)(pcolFldId As Integer) As List(Of T)
            Return LoadByIDX_PK__tblBatch__36326BE35E4252B5(Of T)(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblBatch__36326BE35E4252B5(Of T)(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK__tblBatch__36326BE35E4252B5(Of T)(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblBatch__36326BE35E4252B5(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK__tblBatch__36326BE35E4252B5(Of T)(pcolFldId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK__tblBatch__36326BE35E4252B5(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingSet] WHERE [fldId] = @colFldId"
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
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingSet]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblBatchProcessingSet
        Implements IrowTblBatchProcessingSet

        Public Event Loaded(pUserState As Object) Implements IrowTblBatchProcessingSet.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblBatchProcessingSet.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblBatchProcessingSet.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblBatchProcessingSet.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblBatchProcessingSet.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblBatchProcessingSet.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldId() As Nullable(Of Integer) Implements IrowTblBatchProcessingSet.colFldId
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

        Public Property colFldCreateDate() As Nullable(Of DateTime) Implements IrowTblBatchProcessingSet.colFldCreateDate
            Get
                Return m_colFldCreateDate
            End Get
            Set
                If Not Same(m_colFldCreateDate, Value) Then
                    m_colFldCreateDate = Value
                    m_IsDirty(FieldIndex.colFldCreateDate) = True
                End If
            End Set
        End Property
        Private m_colFldCreateDate As Nullable(Of DateTime)

        Public Property colFldFilePrefix() As String Implements IrowTblBatchProcessingSet.colFldFilePrefix
            Get
                Return m_colFldFilePrefix
            End Get
            Set
                If Not Same(m_colFldFilePrefix, Value) Then
                    m_colFldFilePrefix = Value
                    m_IsDirty(FieldIndex.colFldFilePrefix) = True
                End If
            End Set
        End Property
        Private m_colFldFilePrefix As String

        Public Property colFldSetTypeID() As Nullable(Of Integer) Implements IrowTblBatchProcessingSet.colFldSetTypeID
            Get
                Return m_colFldSetTypeID
            End Get
            Set
                If Not Same(m_colFldSetTypeID, Value) Then
                    m_colFldSetTypeID = Value
                    m_IsDirty(FieldIndex.colFldSetTypeID) = True
                End If
            End Set
        End Property
        Private m_colFldSetTypeID As Nullable(Of Integer)

        Public Property colFldFileName() As String Implements IrowTblBatchProcessingSet.colFldFileName
            Get
                Return m_colFldFileName
            End Get
            Set
                If Not Same(m_colFldFileName, Value) Then
                    m_colFldFileName = Value
                    m_IsDirty(FieldIndex.colFldFileName) = True
                End If
            End Set
        End Property
        Private m_colFldFileName As String

        Public Property colFldStatusId() As Nullable(Of Integer) Implements IrowTblBatchProcessingSet.colFldStatusId
            Get
                Return m_colFldStatusId
            End Get
            Set
                If Not Same(m_colFldStatusId, Value) Then
                    m_colFldStatusId = Value
                    m_IsDirty(FieldIndex.colFldStatusId) = True
                End If
            End Set
        End Property
        Private m_colFldStatusId As Nullable(Of Integer)

        Public Property colFldDisable() As Nullable(Of Boolean) Implements IrowTblBatchProcessingSet.colFldDisable
            Get
                Return m_colFldDisable
            End Get
            Set
                If Not Same(m_colFldDisable, Value) Then
                    m_colFldDisable = Value
                    m_IsDirty(FieldIndex.colFldDisable) = True
                End If
            End Set
        End Property
        Private m_colFldDisable As Nullable(Of Boolean)

        Public Property colFldLOFilterJSON() As String Implements IrowTblBatchProcessingSet.colFldLOFilterJSON
            Get
                Return m_colFldLOFilterJSON
            End Get
            Set
                If Not Same(m_colFldLOFilterJSON, Value) Then
                    m_colFldLOFilterJSON = Value
                    m_IsDirty(FieldIndex.colFldLOFilterJSON) = True
                End If
            End Set
        End Property
        Private m_colFldLOFilterJSON As String

        Public Property colFldLOCriteriaJSON() As String Implements IrowTblBatchProcessingSet.colFldLOCriteriaJSON
            Get
                Return m_colFldLOCriteriaJSON
            End Get
            Set
                If Not Same(m_colFldLOCriteriaJSON, Value) Then
                    m_colFldLOCriteriaJSON = Value
                    m_IsDirty(FieldIndex.colFldLOCriteriaJSON) = True
                End If
            End Set
        End Property
        Private m_colFldLOCriteriaJSON As String

        Public Property colFldLOSortJSON() As String Implements IrowTblBatchProcessingSet.colFldLOSortJSON
            Get
                Return m_colFldLOSortJSON
            End Get
            Set
                If Not Same(m_colFldLOSortJSON, Value) Then
                    m_colFldLOSortJSON = Value
                    m_IsDirty(FieldIndex.colFldLOSortJSON) = True
                End If
            End Set
        End Property
        Private m_colFldLOSortJSON As String

        Public Property colFldLOSettingJSON() As String Implements IrowTblBatchProcessingSet.colFldLOSettingJSON
            Get
                Return m_colFldLOSettingJSON
            End Get
            Set
                If Not Same(m_colFldLOSettingJSON, Value) Then
                    m_colFldLOSettingJSON = Value
                    m_IsDirty(FieldIndex.colFldLOSettingJSON) = True
                End If
            End Set
        End Property
        Private m_colFldLOSettingJSON As String

        Public Property colFldMetaParameterJSON() As String Implements IrowTblBatchProcessingSet.colFldMetaParameterJSON
            Get
                Return m_colFldMetaParameterJSON
            End Get
            Set
                If Not Same(m_colFldMetaParameterJSON, Value) Then
                    m_colFldMetaParameterJSON = Value
                    m_IsDirty(FieldIndex.colFldMetaParameterJSON) = True
                End If
            End Set
        End Property
        Private m_colFldMetaParameterJSON As String

        Public Property colFldCreatedByGsafeId() As Nullable(Of Integer) Implements IrowTblBatchProcessingSet.colFldCreatedByGsafeId
            Get
                Return m_colFldCreatedByGsafeId
            End Get
            Set
                If Not Same(m_colFldCreatedByGsafeId, Value) Then
                    m_colFldCreatedByGsafeId = Value
                    m_IsDirty(FieldIndex.colFldCreatedByGsafeId) = True
                End If
            End Set
        End Property
        Private m_colFldCreatedByGsafeId As Nullable(Of Integer)

        Public Property colFldIsInteractive() As Nullable(Of Boolean) Implements IrowTblBatchProcessingSet.colFldIsInteractive
            Get
                Return m_colFldIsInteractive
            End Get
            Set
                If Not Same(m_colFldIsInteractive, Value) Then
                    m_colFldIsInteractive = Value
                    m_IsDirty(FieldIndex.colFldIsInteractive) = True
                End If
            End Set
        End Property
        Private m_colFldIsInteractive As Nullable(Of Boolean)

        Public Property colFldIsMyBatchReport() As Nullable(Of Boolean) Implements IrowTblBatchProcessingSet.colFldIsMyBatchReport
            Get
                Return m_colFldIsMyBatchReport
            End Get
            Set
                If Not Same(m_colFldIsMyBatchReport, Value) Then
                    m_colFldIsMyBatchReport = Value
                    m_IsDirty(FieldIndex.colFldIsMyBatchReport) = True
                End If
            End Set
        End Property
        Private m_colFldIsMyBatchReport As Nullable(Of Boolean)

        Public Property colFldCreatedByGsafeUserEmail() As String Implements IrowTblBatchProcessingSet.colFldCreatedByGsafeUserEmail
            Get
                Return m_colFldCreatedByGsafeUserEmail
            End Get
            Set
                If Not Same(m_colFldCreatedByGsafeUserEmail, Value) Then
                    m_colFldCreatedByGsafeUserEmail = Value
                    m_IsDirty(FieldIndex.colFldCreatedByGsafeUserEmail) = True
                End If
            End Set
        End Property
        Private m_colFldCreatedByGsafeUserEmail As String

        Public Property colFldLOMyPreferenceJSON() As String Implements IrowTblBatchProcessingSet.colFldLOMyPreferenceJSON
            Get
                Return m_colFldLOMyPreferenceJSON
            End Get
            Set
                If Not Same(m_colFldLOMyPreferenceJSON, Value) Then
                    m_colFldLOMyPreferenceJSON = Value
                    m_IsDirty(FieldIndex.colFldLOMyPreferenceJSON) = True
                End If
            End Set
        End Property
        Private m_colFldLOMyPreferenceJSON As String


        Public Function IsDirty(pIndex As rowTblBatchProcessingSet.FieldIndex) As Boolean Implements IrowTblBatchProcessingSet.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblBatchProcessingSet.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblBatchProcessingSet.SetIsDirty
            m_IsDirty(FieldIndex.colFldId) = pDirty
            m_IsDirty(FieldIndex.colFldCreateDate) = pDirty
            m_IsDirty(FieldIndex.colFldFilePrefix) = pDirty
            m_IsDirty(FieldIndex.colFldSetTypeID) = pDirty
            m_IsDirty(FieldIndex.colFldFileName) = pDirty
            m_IsDirty(FieldIndex.colFldStatusId) = pDirty
            m_IsDirty(FieldIndex.colFldDisable) = pDirty
            m_IsDirty(FieldIndex.colFldLOFilterJSON) = pDirty
            m_IsDirty(FieldIndex.colFldLOCriteriaJSON) = pDirty
            m_IsDirty(FieldIndex.colFldLOSortJSON) = pDirty
            m_IsDirty(FieldIndex.colFldLOSettingJSON) = pDirty
            m_IsDirty(FieldIndex.colFldMetaParameterJSON) = pDirty
            m_IsDirty(FieldIndex.colFldCreatedByGsafeId) = pDirty
            m_IsDirty(FieldIndex.colFldIsInteractive) = pDirty
            m_IsDirty(FieldIndex.colFldIsMyBatchReport) = pDirty
            m_IsDirty(FieldIndex.colFldCreatedByGsafeUserEmail) = pDirty
            m_IsDirty(FieldIndex.colFldLOMyPreferenceJSON) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblBatchProcessingSet) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblBatchProcessingSet
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldId  = 1
            colFldCreateDate 
            colFldFilePrefix 
            colFldSetTypeID 
            colFldFileName 
            colFldStatusId 
            colFldDisable 
            colFldLOFilterJSON 
            colFldLOCriteriaJSON 
            colFldLOSortJSON 
            colFldLOSettingJSON 
            colFldMetaParameterJSON 
            colFldCreatedByGsafeId 
            colFldIsInteractive 
            colFldIsMyBatchReport 
            colFldCreatedByGsafeUserEmail 
            colFldLOMyPreferenceJSON 
        End Enum

        Private m_IsDirty(17) As Boolean

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

    Public Interface IrowTblBatchProcessingSet
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldId() As Nullable(Of Integer)
        Property colFldCreateDate() As Nullable(Of DateTime)
        Property colFldFilePrefix() As String
        Property colFldSetTypeID() As Nullable(Of Integer)
        Property colFldFileName() As String
        Property colFldStatusId() As Nullable(Of Integer)
        Property colFldDisable() As Nullable(Of Boolean)
        Property colFldLOFilterJSON() As String
        Property colFldLOCriteriaJSON() As String
        Property colFldLOSortJSON() As String
        Property colFldLOSettingJSON() As String
        Property colFldMetaParameterJSON() As String
        Property colFldCreatedByGsafeId() As Nullable(Of Integer)
        Property colFldIsInteractive() As Nullable(Of Boolean)
        Property colFldIsMyBatchReport() As Nullable(Of Boolean)
        Property colFldCreatedByGsafeUserEmail() As String
        Property colFldLOMyPreferenceJSON() As String
        Function IsDirty(pIndex As rowTblBatchProcessingSet.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

