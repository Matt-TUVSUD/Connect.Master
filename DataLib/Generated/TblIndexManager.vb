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
    Partial Public Class TblIndexManager

        Public Shared Sub Delete(ByRef pRowData As IrowTblIndexManager)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblIndexManager, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblIndexManager, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblIndexManager, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldIndexId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[tblIndexManager] " & _
                        "WHERE [fldIndexId] = @colFldIndexId"

                Dim zCmd As New SQLCommand
                zCmd.CommandText = zSQL
                zCmd.Parameters.Add(New SQLParameter("@colFldIndexId", pRowData.colFldIndexId))

                zCmd.Transaction=pTransaction
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)

                pRowData.RaiseDeletedEvent(pDeleteEventUserState)

            End If

        End Sub

        Public Shared Sub Delete(pcolFldIndexId As Integer)
            Delete(pcolFldIndexId, Nothing, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolFldIndexId As Integer, pDeleteEventUserState As Object)
            Delete(pcolFldIndexId, Nothing, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Delete(pcolFldIndexId As Integer, ByRef pTransaction As SqlClient.SqlTransaction)
        Delete(pcolFldIndexId, pTransaction, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolFldIndexId As Integer, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
        Dim zObj As rowTblIndexManager = LoadByPrimaryKey(pcolFldIndexId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblIndexManager)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblIndexManager, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblIndexManager, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldIndexId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[tblIndexManager] WHERE [fldIndexId] = @colFldIndexId"

                Dim zCmdDoesExist As New SQLCommand

                zCmdDoesExist.CommandText = zSQL

                zCmdDoesExist.Parameters.Add(new SQLParameter("@colFldIndexId", pRowData.colFldIndexId))

                'if zExistInDB > 0  then  PK exists in the DB
                zCmdDoesExist.Transaction = pTransaction
                zExistInDB = razor.UtilSQLServer.ExecuteScalar(zCmdDoesExist)
            End If

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldIndexId) And zExistInDB > 0 Then
                zMode = "UPDATE"
            End If
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldIndexId) And zExistInDB = 0 Then
                zMode = "INSERTwithKey"
            End If
            If Not razor.UtilSQLServer.IsKeySet(pRowData.colFldIndexId) Then
                zMode = "INSERTnoKey"
            End If

            Select Case zMode
                Case "UPDATE"
                    If pRowData.IsDirty Then
                        Dim zUpdate As String = ""
                        Dim zSet As String = ""
                        Dim zWhere As String = ""
                        zUpdate = "UPDATE [dbo].[tblIndexManager] SET " 
                        If pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldIndexName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldIndexName] = @colFldIndexName "
                        End If
                        If pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldStatus) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldStatus] = @colFldStatus "
                        End If
                        If pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldEnabled) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldEnabled] = @colFldEnabled "
                        End If
                        If pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldLastIndexDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldLastIndexDate] = @colFldLastIndexDate "
                        End If
                        If pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldLastContentUpdateDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldLastContentUpdateDate] = @colFldLastContentUpdateDate "
                        End If
                        If pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldStartDirectory) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldStartDirectory] = @colFldStartDirectory "
                        End If
                        If pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldSpiderURL) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldSpiderURL] = @colFldSpiderURL "
                        End If
                        If pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldBaseURL) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldBaseURL] = @colFldBaseURL "
                        End If
                        If pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldOutputDirectory) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldOutputDirectory] = @colFldOutputDirectory "
                        End If
                        If pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldTemplateFilename) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldTemplateFilename] = @colFldTemplateFilename "
                        End If
                        If pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldFilePrefix) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldFilePrefix] = @colFldFilePrefix "
                        End If
                        If pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldStartJobTime) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldStartJobTime] = @colFldStartJobTime "
                        End If
                        If pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldEndJobTime) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldEndJobTime] = @colFldEndJobTime "
                        End If
                        If pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldLastPollTime) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldLastPollTime] = @colFldLastPollTime "
                        End If
                        If pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldHasContent) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldHasContent] = @colFldHasContent "
                        End If
                        If pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldTnEInactiveFlag) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldTnEInactiveFlag] = @colFldTnEInactiveFlag "
                        End If
                        If pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldIndexMode) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldIndexMode] = @colFldIndexMode "
                        End If
                        If pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldLastIndexLapseMin) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldLastIndexLapseMin] = @colFldLastIndexLapseMin "
                        End If
                        If pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldIndexGUID) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldIndexGUID] = @colFldIndexGUID "
                        End If
                        If pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldCldbName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldCldbName] = @colFldCldbName "
                        End If
                        zWhere = " WHERE [fldIndexId] = @colFldIndexId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[tblIndexManager] ([fldIndexName], [fldStatus], [fldEnabled], [fldLastIndexDate], [fldLastContentUpdateDate], [fldStartDirectory], [fldSpiderURL], [fldBaseURL], [fldOutputDirectory], [fldTemplateFilename], [fldFilePrefix], [fldStartJobTime], [fldEndJobTime], [fldLastPollTime], [fldHasContent], [fldTnEInactiveFlag], [fldIndexMode], [fldLastIndexLapseMin], [fldIndexGUID], [fldCldbName])" & _
                            " VALUES (@colFldIndexName, @colFldStatus, @colFldEnabled, @colFldLastIndexDate, @colFldLastContentUpdateDate, @colFldStartDirectory, @colFldSpiderURL, @colFldBaseURL, @colFldOutputDirectory, @colFldTemplateFilename, @colFldFilePrefix, @colFldStartJobTime, @colFldEndJobTime, @colFldLastPollTime, @colFldHasContent, @colFldTnEInactiveFlag, @colFldIndexMode, @colFldLastIndexLapseMin, @colFldIndexGUID, @colFldCldbName); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[tblIndexManager] ([fldIndexName], [fldStatus], [fldEnabled], [fldLastIndexDate], [fldLastContentUpdateDate], [fldStartDirectory], [fldSpiderURL], [fldBaseURL], [fldOutputDirectory], [fldTemplateFilename], [fldFilePrefix], [fldStartJobTime], [fldEndJobTime], [fldLastPollTime], [fldHasContent], [fldTnEInactiveFlag], [fldIndexMode], [fldLastIndexLapseMin], [fldIndexGUID], [fldCldbName])" & _
                            " VALUES (@colFldIndexName, @colFldStatus, @colFldEnabled, @colFldLastIndexDate, @colFldLastContentUpdateDate, @colFldStartDirectory, @colFldSpiderURL, @colFldBaseURL, @colFldOutputDirectory, @colFldTemplateFilename, @colFldFilePrefix, @colFldStartJobTime, @colFldEndJobTime, @colFldLastPollTime, @colFldHasContent, @colFldTnEInactiveFlag, @colFldIndexMode, @colFldLastIndexLapseMin, @colFldIndexGUID, @colFldCldbName); SELECT SCOPE_IDENTITY()"
                Case Else
            End Select

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

			'IF UPDATE, SET PK PARAMETER
            If zMode = "UPDATE" Then
                zCmd.Parameters.Add(New SQLParameter("@colFldIndexId", pRowData.colFldIndexId))
            End If

			'IF INSERTING, KEY HAS VALUE AND KEY IS NOT IDENTITY, SET PK PARAMETER
			If zMode = "INSERTwithKey" Then
            End If

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldIndexName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldIndexName", IIf(pRowData.colFldIndexName Is Nothing, DBNull.Value, pRowData.colFldIndexName)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldStatus) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldStatus", IIf(pRowData.colFldStatus Is Nothing, DBNull.Value, pRowData.colFldStatus)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldEnabled) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldEnabled", IIf(pRowData.colFldEnabled Is Nothing, DBNull.Value, pRowData.colFldEnabled)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldLastIndexDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldLastIndexDate", IIf(pRowData.colFldLastIndexDate Is Nothing, DBNull.Value, pRowData.colFldLastIndexDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldLastContentUpdateDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldLastContentUpdateDate", IIf(pRowData.colFldLastContentUpdateDate Is Nothing, DBNull.Value, pRowData.colFldLastContentUpdateDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldStartDirectory) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldStartDirectory", IIf(pRowData.colFldStartDirectory Is Nothing, DBNull.Value, pRowData.colFldStartDirectory)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldSpiderURL) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldSpiderURL", IIf(pRowData.colFldSpiderURL Is Nothing, DBNull.Value, pRowData.colFldSpiderURL)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldBaseURL) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldBaseURL", IIf(pRowData.colFldBaseURL Is Nothing, DBNull.Value, pRowData.colFldBaseURL)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldOutputDirectory) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldOutputDirectory", IIf(pRowData.colFldOutputDirectory Is Nothing, DBNull.Value, pRowData.colFldOutputDirectory)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldTemplateFilename) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldTemplateFilename", IIf(pRowData.colFldTemplateFilename Is Nothing, DBNull.Value, pRowData.colFldTemplateFilename)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldFilePrefix) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldFilePrefix", IIf(pRowData.colFldFilePrefix Is Nothing, DBNull.Value, pRowData.colFldFilePrefix)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldStartJobTime) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldStartJobTime", IIf(pRowData.colFldStartJobTime Is Nothing, DBNull.Value, pRowData.colFldStartJobTime)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldEndJobTime) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldEndJobTime", IIf(pRowData.colFldEndJobTime Is Nothing, DBNull.Value, pRowData.colFldEndJobTime)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldLastPollTime) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldLastPollTime", IIf(pRowData.colFldLastPollTime Is Nothing, DBNull.Value, pRowData.colFldLastPollTime)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldHasContent) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldHasContent", IIf(pRowData.colFldHasContent Is Nothing, DBNull.Value, pRowData.colFldHasContent)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldTnEInactiveFlag) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldTnEInactiveFlag", IIf(pRowData.colFldTnEInactiveFlag Is Nothing, DBNull.Value, pRowData.colFldTnEInactiveFlag)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldIndexMode) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldIndexMode", IIf(pRowData.colFldIndexMode Is Nothing, DBNull.Value, pRowData.colFldIndexMode)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldLastIndexLapseMin) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldLastIndexLapseMin", IIf(pRowData.colFldLastIndexLapseMin Is Nothing, DBNull.Value, pRowData.colFldLastIndexLapseMin)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldIndexGUID) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldIndexGUID", IIf(pRowData.colFldIndexGUID Is Nothing, DBNull.Value, pRowData.colFldIndexGUID)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblIndexManager.FieldIndex.colFldCldbName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldCldbName", IIf(pRowData.colFldCldbName Is Nothing, DBNull.Value, pRowData.colFldCldbName)))
                End If

            zCmd.Transaction=pTransaction
            If zMode = "INSERTnoKey" Then
                Dim zLastId As Long = 0
                zLastId = razor.UtilSQLServer.ExecuteNonQueryRowId(zCmd)

                pRowData.colFldIndexId = zLastId
            Else
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)
            End If

            pRowData.SetIsDirty(False)
            pRowData.RaiseSavedEvent(pSavedEventUserState)

		End If

        End Sub

        Public Shared Function LoadByPrimaryKey(pcolFldIndexId As Integer) As rowTblIndexManager
            Return LoadByPrimaryKey(pcolFldIndexId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldIndexId As Integer, pLoadEventUserState As Object) As rowTblIndexManager
            Return LoadByPrimaryKey(pcolFldIndexId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldIndexId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblIndexManager
            Return LoadByPrimaryKey(pcolFldIndexId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldIndexId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblIndexManager
            Dim zReturn As New rowTblIndexManager
            Dim zSQL As String = "SELECT * FROM [dbo].[tblIndexManager] WHERE [fldIndexId] = @colFldIndexId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldIndexId", pcolFldIndexId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblIndexManager) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK_tblIndexManager(pcolFldIndexId As Integer) As List(Of rowTblIndexManager)
            Return LoadByIDX_PK_tblIndexManager(pcolFldIndexId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblIndexManager(pcolFldIndexId As Integer, pLoadEventUserState As Object) As List(Of rowTblIndexManager)
            Return LoadByIDX_PK_tblIndexManager(pcolFldIndexId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_tblIndexManager(pcolFldIndexId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblIndexManager)
            Return LoadByIDX_PK_tblIndexManager(pcolFldIndexId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblIndexManager(pcolFldIndexId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblIndexManager)
            Dim zReturn As New List(Of rowTblIndexManager)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblIndexManager] WHERE [fldIndexId] = @colFldIndexId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldIndexId", pcolFldIndexId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblIndexManager)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblIndexManager)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblIndexManager)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblIndexManager)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblIndexManager)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblIndexManager)
            Dim zReturn As New List(Of rowTblIndexManager)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblIndexManager]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblIndexManager)

			Try
	            Dim zReturn As New List(Of rowTblIndexManager)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblIndexManager

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblIndexManager		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblIndexManager)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldIndexId")) Then pObject.colFldIndexId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldIndexId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldIndexName")) Then pObject.colFldIndexName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldIndexName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldStatus")) Then pObject.colFldStatus = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldStatus")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldEnabled")) Then pObject.colFldEnabled = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldEnabled")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldLastIndexDate")) Then pObject.colFldLastIndexDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "fldLastIndexDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldLastContentUpdateDate")) Then pObject.colFldLastContentUpdateDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "fldLastContentUpdateDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldStartDirectory")) Then pObject.colFldStartDirectory = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldStartDirectory")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSpiderURL")) Then pObject.colFldSpiderURL = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldSpiderURL")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldBaseURL")) Then pObject.colFldBaseURL = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldBaseURL")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldOutputDirectory")) Then pObject.colFldOutputDirectory = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldOutputDirectory")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldTemplateFilename")) Then pObject.colFldTemplateFilename = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldTemplateFilename")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFilePrefix")) Then pObject.colFldFilePrefix = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldFilePrefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldStartJobTime")) Then pObject.colFldStartJobTime = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "fldStartJobTime")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldEndJobTime")) Then pObject.colFldEndJobTime = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "fldEndJobTime")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldLastPollTime")) Then pObject.colFldLastPollTime = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "fldLastPollTime")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldHasContent")) Then pObject.colFldHasContent = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldHasContent")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldTnEInactiveFlag")) Then pObject.colFldTnEInactiveFlag = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldTnEInactiveFlag")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldIndexMode")) Then pObject.colFldIndexMode = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldIndexMode")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldLastIndexLapseMin")) Then pObject.colFldLastIndexLapseMin = UtilSQLServer.SafeReader.SafeReadSingle(pReader, "fldLastIndexLapseMin")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldIndexGUID")) Then pObject.colFldIndexGUID = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldIndexGUID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldCldbName")) Then pObject.colFldCldbName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldCldbName")
			pObject.SetIsDirty(False)
			Return pObject
		End	 Function

    #Region "Reflection Based Load Functions"

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldIndexId As Integer) As T
            Return LoadByPrimaryKey(Of T)(pcolFldIndexId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldIndexId As Integer, pLoadEventUserState As Object) As T
            Return LoadByPrimaryKey(Of T)(pcolFldIndexId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldIndexId As Integer, pTransaction As SqlClient.SqlTransaction) As T
            Return LoadByPrimaryKey(Of T)(pcolFldIndexId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldIndexId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As T

            Dim zReturn As Object = Activator.CreateInstance(Of T)()
            If Not TypeOf zReturn Is rowTblIndexManager Then Throw New ArgumentException("Generic type is not type of rowTblIndexManager.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[tblIndexManager] WHERE [fldIndexId] = @colFldIndexId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldIndexId", pcolFldIndexId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of T) = ReadData(Of T)(zCmd, pLoadEventUserState)
            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

        End Function

        Public Shared Function LoadByIDX_PK_tblIndexManager(Of T)(pcolFldIndexId As Integer) As List(Of T)
            Return LoadByIDX_PK_tblIndexManager(Of T)(pcolFldIndexId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblIndexManager(Of T)(pcolFldIndexId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK_tblIndexManager(Of T)(pcolFldIndexId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_tblIndexManager(Of T)(pcolFldIndexId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK_tblIndexManager(Of T)(pcolFldIndexId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK_tblIndexManager(Of T)(pcolFldIndexId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblIndexManager] WHERE [fldIndexId] = @colFldIndexId"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldIndexId", pcolFldIndexId))

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
            Dim zSQL As String = "SELECT * FROM [dbo].[tblIndexManager]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblIndexManager
        Implements IrowTblIndexManager

        Public Event Loaded(pUserState As Object) Implements IrowTblIndexManager.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblIndexManager.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblIndexManager.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblIndexManager.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblIndexManager.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblIndexManager.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldIndexId() As Nullable(Of Integer) Implements IrowTblIndexManager.colFldIndexId
            Get
                Return m_colFldIndexId
            End Get
            Set
                If Not Same(m_colFldIndexId, Value) Then
                    m_colFldIndexId = Value
                    m_IsDirty(FieldIndex.colFldIndexId) = True
                End If
            End Set
        End Property
        Private m_colFldIndexId As Nullable(Of Integer)

        Public Property colFldIndexName() As String Implements IrowTblIndexManager.colFldIndexName
            Get
                Return m_colFldIndexName
            End Get
            Set
                If Not Same(m_colFldIndexName, Value) Then
                    m_colFldIndexName = Value
                    m_IsDirty(FieldIndex.colFldIndexName) = True
                End If
            End Set
        End Property
        Private m_colFldIndexName As String

        Public Property colFldStatus() As String Implements IrowTblIndexManager.colFldStatus
            Get
                Return m_colFldStatus
            End Get
            Set
                If Not Same(m_colFldStatus, Value) Then
                    m_colFldStatus = Value
                    m_IsDirty(FieldIndex.colFldStatus) = True
                End If
            End Set
        End Property
        Private m_colFldStatus As String

        Public Property colFldEnabled() As Nullable(Of Boolean) Implements IrowTblIndexManager.colFldEnabled
            Get
                Return m_colFldEnabled
            End Get
            Set
                If Not Same(m_colFldEnabled, Value) Then
                    m_colFldEnabled = Value
                    m_IsDirty(FieldIndex.colFldEnabled) = True
                End If
            End Set
        End Property
        Private m_colFldEnabled As Nullable(Of Boolean)

        Public Property colFldLastIndexDate() As Nullable(Of DateTime) Implements IrowTblIndexManager.colFldLastIndexDate
            Get
                Return m_colFldLastIndexDate
            End Get
            Set
                If Not Same(m_colFldLastIndexDate, Value) Then
                    m_colFldLastIndexDate = Value
                    m_IsDirty(FieldIndex.colFldLastIndexDate) = True
                End If
            End Set
        End Property
        Private m_colFldLastIndexDate As Nullable(Of DateTime)

        Public Property colFldLastContentUpdateDate() As Nullable(Of DateTime) Implements IrowTblIndexManager.colFldLastContentUpdateDate
            Get
                Return m_colFldLastContentUpdateDate
            End Get
            Set
                If Not Same(m_colFldLastContentUpdateDate, Value) Then
                    m_colFldLastContentUpdateDate = Value
                    m_IsDirty(FieldIndex.colFldLastContentUpdateDate) = True
                End If
            End Set
        End Property
        Private m_colFldLastContentUpdateDate As Nullable(Of DateTime)

        Public Property colFldStartDirectory() As String Implements IrowTblIndexManager.colFldStartDirectory
            Get
                Return m_colFldStartDirectory
            End Get
            Set
                If Not Same(m_colFldStartDirectory, Value) Then
                    m_colFldStartDirectory = Value
                    m_IsDirty(FieldIndex.colFldStartDirectory) = True
                End If
            End Set
        End Property
        Private m_colFldStartDirectory As String

        Public Property colFldSpiderURL() As String Implements IrowTblIndexManager.colFldSpiderURL
            Get
                Return m_colFldSpiderURL
            End Get
            Set
                If Not Same(m_colFldSpiderURL, Value) Then
                    m_colFldSpiderURL = Value
                    m_IsDirty(FieldIndex.colFldSpiderURL) = True
                End If
            End Set
        End Property
        Private m_colFldSpiderURL As String

        Public Property colFldBaseURL() As String Implements IrowTblIndexManager.colFldBaseURL
            Get
                Return m_colFldBaseURL
            End Get
            Set
                If Not Same(m_colFldBaseURL, Value) Then
                    m_colFldBaseURL = Value
                    m_IsDirty(FieldIndex.colFldBaseURL) = True
                End If
            End Set
        End Property
        Private m_colFldBaseURL As String

        Public Property colFldOutputDirectory() As String Implements IrowTblIndexManager.colFldOutputDirectory
            Get
                Return m_colFldOutputDirectory
            End Get
            Set
                If Not Same(m_colFldOutputDirectory, Value) Then
                    m_colFldOutputDirectory = Value
                    m_IsDirty(FieldIndex.colFldOutputDirectory) = True
                End If
            End Set
        End Property
        Private m_colFldOutputDirectory As String

        Public Property colFldTemplateFilename() As String Implements IrowTblIndexManager.colFldTemplateFilename
            Get
                Return m_colFldTemplateFilename
            End Get
            Set
                If Not Same(m_colFldTemplateFilename, Value) Then
                    m_colFldTemplateFilename = Value
                    m_IsDirty(FieldIndex.colFldTemplateFilename) = True
                End If
            End Set
        End Property
        Private m_colFldTemplateFilename As String

        Public Property colFldFilePrefix() As String Implements IrowTblIndexManager.colFldFilePrefix
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

        Public Property colFldStartJobTime() As Nullable(Of DateTime) Implements IrowTblIndexManager.colFldStartJobTime
            Get
                Return m_colFldStartJobTime
            End Get
            Set
                If Not Same(m_colFldStartJobTime, Value) Then
                    m_colFldStartJobTime = Value
                    m_IsDirty(FieldIndex.colFldStartJobTime) = True
                End If
            End Set
        End Property
        Private m_colFldStartJobTime As Nullable(Of DateTime)

        Public Property colFldEndJobTime() As Nullable(Of DateTime) Implements IrowTblIndexManager.colFldEndJobTime
            Get
                Return m_colFldEndJobTime
            End Get
            Set
                If Not Same(m_colFldEndJobTime, Value) Then
                    m_colFldEndJobTime = Value
                    m_IsDirty(FieldIndex.colFldEndJobTime) = True
                End If
            End Set
        End Property
        Private m_colFldEndJobTime As Nullable(Of DateTime)

        Public Property colFldLastPollTime() As Nullable(Of DateTime) Implements IrowTblIndexManager.colFldLastPollTime
            Get
                Return m_colFldLastPollTime
            End Get
            Set
                If Not Same(m_colFldLastPollTime, Value) Then
                    m_colFldLastPollTime = Value
                    m_IsDirty(FieldIndex.colFldLastPollTime) = True
                End If
            End Set
        End Property
        Private m_colFldLastPollTime As Nullable(Of DateTime)

        Public Property colFldHasContent() As Nullable(Of Boolean) Implements IrowTblIndexManager.colFldHasContent
            Get
                Return m_colFldHasContent
            End Get
            Set
                If Not Same(m_colFldHasContent, Value) Then
                    m_colFldHasContent = Value
                    m_IsDirty(FieldIndex.colFldHasContent) = True
                End If
            End Set
        End Property
        Private m_colFldHasContent As Nullable(Of Boolean)

        Public Property colFldTnEInactiveFlag() As Nullable(Of Integer) Implements IrowTblIndexManager.colFldTnEInactiveFlag
            Get
                Return m_colFldTnEInactiveFlag
            End Get
            Set
                If Not Same(m_colFldTnEInactiveFlag, Value) Then
                    m_colFldTnEInactiveFlag = Value
                    m_IsDirty(FieldIndex.colFldTnEInactiveFlag) = True
                End If
            End Set
        End Property
        Private m_colFldTnEInactiveFlag As Nullable(Of Integer)

        Public Property colFldIndexMode() As String Implements IrowTblIndexManager.colFldIndexMode
            Get
                Return m_colFldIndexMode
            End Get
            Set
                If Not Same(m_colFldIndexMode, Value) Then
                    m_colFldIndexMode = Value
                    m_IsDirty(FieldIndex.colFldIndexMode) = True
                End If
            End Set
        End Property
        Private m_colFldIndexMode As String

        Public Property colFldLastIndexLapseMin() As Nullable(Of Single) Implements IrowTblIndexManager.colFldLastIndexLapseMin
            Get
                Return m_colFldLastIndexLapseMin
            End Get
            Set
                If Not Same(m_colFldLastIndexLapseMin, Value) Then
                    m_colFldLastIndexLapseMin = Value
                    m_IsDirty(FieldIndex.colFldLastIndexLapseMin) = True
                End If
            End Set
        End Property
        Private m_colFldLastIndexLapseMin As Nullable(Of Single)

        Public Property colFldIndexGUID() As String Implements IrowTblIndexManager.colFldIndexGUID
            Get
                Return m_colFldIndexGUID
            End Get
            Set
                If Not Same(m_colFldIndexGUID, Value) Then
                    m_colFldIndexGUID = Value
                    m_IsDirty(FieldIndex.colFldIndexGUID) = True
                End If
            End Set
        End Property
        Private m_colFldIndexGUID As String

        Public Property colFldCldbName() As String Implements IrowTblIndexManager.colFldCldbName
            Get
                Return m_colFldCldbName
            End Get
            Set
                If Not Same(m_colFldCldbName, Value) Then
                    m_colFldCldbName = Value
                    m_IsDirty(FieldIndex.colFldCldbName) = True
                End If
            End Set
        End Property
        Private m_colFldCldbName As String


        Public Function IsDirty(pIndex As rowTblIndexManager.FieldIndex) As Boolean Implements IrowTblIndexManager.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblIndexManager.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblIndexManager.SetIsDirty
            m_IsDirty(FieldIndex.colFldIndexId) = pDirty
            m_IsDirty(FieldIndex.colFldIndexName) = pDirty
            m_IsDirty(FieldIndex.colFldStatus) = pDirty
            m_IsDirty(FieldIndex.colFldEnabled) = pDirty
            m_IsDirty(FieldIndex.colFldLastIndexDate) = pDirty
            m_IsDirty(FieldIndex.colFldLastContentUpdateDate) = pDirty
            m_IsDirty(FieldIndex.colFldStartDirectory) = pDirty
            m_IsDirty(FieldIndex.colFldSpiderURL) = pDirty
            m_IsDirty(FieldIndex.colFldBaseURL) = pDirty
            m_IsDirty(FieldIndex.colFldOutputDirectory) = pDirty
            m_IsDirty(FieldIndex.colFldTemplateFilename) = pDirty
            m_IsDirty(FieldIndex.colFldFilePrefix) = pDirty
            m_IsDirty(FieldIndex.colFldStartJobTime) = pDirty
            m_IsDirty(FieldIndex.colFldEndJobTime) = pDirty
            m_IsDirty(FieldIndex.colFldLastPollTime) = pDirty
            m_IsDirty(FieldIndex.colFldHasContent) = pDirty
            m_IsDirty(FieldIndex.colFldTnEInactiveFlag) = pDirty
            m_IsDirty(FieldIndex.colFldIndexMode) = pDirty
            m_IsDirty(FieldIndex.colFldLastIndexLapseMin) = pDirty
            m_IsDirty(FieldIndex.colFldIndexGUID) = pDirty
            m_IsDirty(FieldIndex.colFldCldbName) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblIndexManager) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblIndexManager
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldIndexId  = 1
            colFldIndexName 
            colFldStatus 
            colFldEnabled 
            colFldLastIndexDate 
            colFldLastContentUpdateDate 
            colFldStartDirectory 
            colFldSpiderURL 
            colFldBaseURL 
            colFldOutputDirectory 
            colFldTemplateFilename 
            colFldFilePrefix 
            colFldStartJobTime 
            colFldEndJobTime 
            colFldLastPollTime 
            colFldHasContent 
            colFldTnEInactiveFlag 
            colFldIndexMode 
            colFldLastIndexLapseMin 
            colFldIndexGUID 
            colFldCldbName 
        End Enum

        Private m_IsDirty(21) As Boolean

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

    Public Interface IrowTblIndexManager
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldIndexId() As Nullable(Of Integer)
        Property colFldIndexName() As String
        Property colFldStatus() As String
        Property colFldEnabled() As Nullable(Of Boolean)
        Property colFldLastIndexDate() As Nullable(Of DateTime)
        Property colFldLastContentUpdateDate() As Nullable(Of DateTime)
        Property colFldStartDirectory() As String
        Property colFldSpiderURL() As String
        Property colFldBaseURL() As String
        Property colFldOutputDirectory() As String
        Property colFldTemplateFilename() As String
        Property colFldFilePrefix() As String
        Property colFldStartJobTime() As Nullable(Of DateTime)
        Property colFldEndJobTime() As Nullable(Of DateTime)
        Property colFldLastPollTime() As Nullable(Of DateTime)
        Property colFldHasContent() As Nullable(Of Boolean)
        Property colFldTnEInactiveFlag() As Nullable(Of Integer)
        Property colFldIndexMode() As String
        Property colFldLastIndexLapseMin() As Nullable(Of Single)
        Property colFldIndexGUID() As String
        Property colFldCldbName() As String
        Function IsDirty(pIndex As rowTblIndexManager.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

