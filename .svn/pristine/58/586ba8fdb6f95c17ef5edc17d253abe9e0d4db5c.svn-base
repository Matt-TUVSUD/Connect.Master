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
    Partial Public Class TblBatchProcessingSetItem

        Public Shared Sub Delete(ByRef pRowData As IrowTblBatchProcessingSetItem)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblBatchProcessingSetItem, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblBatchProcessingSetItem, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblBatchProcessingSetItem, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[tblBatchProcessingSetItem] " & _
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
        Dim zObj As rowTblBatchProcessingSetItem = LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblBatchProcessingSetItem)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblBatchProcessingSetItem, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblBatchProcessingSetItem, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[tblBatchProcessingSetItem] WHERE [fldId] = @colFldId"

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
                        zUpdate = "UPDATE [dbo].[tblBatchProcessingSetItem] SET " 
                        If pRowData.IsDirty(rowTblBatchProcessingSetItem.FieldIndex.colFldSetId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldSetId] = @colFldSetId "
                        End If
                        If pRowData.IsDirty(rowTblBatchProcessingSetItem.FieldIndex.colFldMetaObjectId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldMetaObjectId] = @colFldMetaObjectId "
                        End If
                        If pRowData.IsDirty(rowTblBatchProcessingSetItem.FieldIndex.colFldStatusId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldStatusId] = @colFldStatusId "
                        End If
                        If pRowData.IsDirty(rowTblBatchProcessingSetItem.FieldIndex.colFldException) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldException] = @colFldException "
                        End If
                        If pRowData.IsDirty(rowTblBatchProcessingSetItem.FieldIndex.colExtendedPropJSON) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ExtendedPropJSON] = @colExtendedPropJSON "
                        End If
                        zWhere = " WHERE [fldId] = @colFldId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[tblBatchProcessingSetItem] ([fldSetId], [fldMetaObjectId], [fldStatusId], [fldException], [ExtendedPropJSON])" & _
                            " VALUES (@colFldSetId, @colFldMetaObjectId, @colFldStatusId, @colFldException, @colExtendedPropJSON); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[tblBatchProcessingSetItem] ([fldSetId], [fldMetaObjectId], [fldStatusId], [fldException], [ExtendedPropJSON])" & _
                            " VALUES (@colFldSetId, @colFldMetaObjectId, @colFldStatusId, @colFldException, @colExtendedPropJSON); SELECT SCOPE_IDENTITY()"
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

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblBatchProcessingSetItem.FieldIndex.colFldSetId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldSetId", IIf(pRowData.colFldSetId Is Nothing, DBNull.Value, pRowData.colFldSetId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblBatchProcessingSetItem.FieldIndex.colFldMetaObjectId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldMetaObjectId", IIf(pRowData.colFldMetaObjectId Is Nothing, DBNull.Value, pRowData.colFldMetaObjectId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblBatchProcessingSetItem.FieldIndex.colFldStatusId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldStatusId", IIf(pRowData.colFldStatusId Is Nothing, DBNull.Value, pRowData.colFldStatusId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblBatchProcessingSetItem.FieldIndex.colFldException) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldException", IIf(pRowData.colFldException Is Nothing, DBNull.Value, pRowData.colFldException)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblBatchProcessingSetItem.FieldIndex.colExtendedPropJSON) Then
                    zCmd.Parameters.Add(New SqlParameter("@colExtendedPropJSON", IIf(pRowData.colExtendedPropJSON Is Nothing, DBNull.Value, pRowData.colExtendedPropJSON)))
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

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer) As rowTblBatchProcessingSetItem
            Return LoadByPrimaryKey(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pLoadEventUserState As Object) As rowTblBatchProcessingSetItem
            Return LoadByPrimaryKey(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblBatchProcessingSetItem
            Return LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblBatchProcessingSetItem
            Dim zReturn As New rowTblBatchProcessingSetItem
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingSetItem] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblBatchProcessingSetItem) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_IX_fldSetId(pcolFldSetId As Integer) As List(Of rowTblBatchProcessingSetItem)
            Return LoadByIDX_IX_fldSetId(pcolFldSetId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_fldSetId(pcolFldSetId As Integer, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingSetItem)
            Return LoadByIDX_IX_fldSetId(pcolFldSetId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_fldSetId(pcolFldSetId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblBatchProcessingSetItem)
            Return LoadByIDX_IX_fldSetId(pcolFldSetId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_fldSetId(pcolFldSetId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingSetItem)
            Dim zReturn As New List(Of rowTblBatchProcessingSetItem)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingSetItem] WHERE [fldSetId] = @colFldSetId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldSetId", pcolFldSetId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function
        Public Shared Function LoadByIDX_PK__tblBatch__36326BE37BB2BA0B(pcolFldId As Integer) As List(Of rowTblBatchProcessingSetItem)
            Return LoadByIDX_PK__tblBatch__36326BE37BB2BA0B(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblBatch__36326BE37BB2BA0B(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingSetItem)
            Return LoadByIDX_PK__tblBatch__36326BE37BB2BA0B(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblBatch__36326BE37BB2BA0B(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblBatchProcessingSetItem)
            Return LoadByIDX_PK__tblBatch__36326BE37BB2BA0B(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblBatch__36326BE37BB2BA0B(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingSetItem)
            Dim zReturn As New List(Of rowTblBatchProcessingSetItem)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingSetItem] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblBatchProcessingSetItem)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblBatchProcessingSetItem)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblBatchProcessingSetItem)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblBatchProcessingSetItem)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingSetItem)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingSetItem)
            Dim zReturn As New List(Of rowTblBatchProcessingSetItem)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingSetItem]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingSetItem)

			Try
	            Dim zReturn As New List(Of rowTblBatchProcessingSetItem)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblBatchProcessingSetItem

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblBatchProcessingSetItem		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblBatchProcessingSetItem)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldId")) Then pObject.colFldId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSetId")) Then pObject.colFldSetId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldSetId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldMetaObjectId")) Then pObject.colFldMetaObjectId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldMetaObjectId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldStatusId")) Then pObject.colFldStatusId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldStatusId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldException")) Then pObject.colFldException = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldException")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ExtendedPropJSON")) Then pObject.colExtendedPropJSON = UtilSQLServer.SafeReader.SafeReadString(pReader, "ExtendedPropJSON")
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
            If Not TypeOf zReturn Is rowTblBatchProcessingSetItem Then Throw New ArgumentException("Generic type is not type of rowTblBatchProcessingSetItem.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingSetItem] WHERE [fldId] = @colFldId"
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

        Public Shared Function LoadByIDX_IX_fldSetId(Of T)(pcolFldSetId As Integer) As List(Of T)
            Return LoadByIDX_IX_fldSetId(Of T)(pcolFldSetId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_fldSetId(Of T)(pcolFldSetId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_IX_fldSetId(Of T)(pcolFldSetId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_fldSetId(Of T)(pcolFldSetId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_IX_fldSetId(Of T)(pcolFldSetId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_IX_fldSetId(Of T)(pcolFldSetId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingSetItem] WHERE [fldSetId] = @colFldSetId"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldSetId", pcolFldSetId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_PK__tblBatch__36326BE37BB2BA0B(Of T)(pcolFldId As Integer) As List(Of T)
            Return LoadByIDX_PK__tblBatch__36326BE37BB2BA0B(Of T)(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblBatch__36326BE37BB2BA0B(Of T)(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK__tblBatch__36326BE37BB2BA0B(Of T)(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblBatch__36326BE37BB2BA0B(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK__tblBatch__36326BE37BB2BA0B(Of T)(pcolFldId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK__tblBatch__36326BE37BB2BA0B(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingSetItem] WHERE [fldId] = @colFldId"
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
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingSetItem]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblBatchProcessingSetItem
        Implements IrowTblBatchProcessingSetItem

        Public Event Loaded(pUserState As Object) Implements IrowTblBatchProcessingSetItem.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblBatchProcessingSetItem.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblBatchProcessingSetItem.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblBatchProcessingSetItem.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblBatchProcessingSetItem.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblBatchProcessingSetItem.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldId() As Nullable(Of Integer) Implements IrowTblBatchProcessingSetItem.colFldId
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

        Public Property colFldSetId() As Nullable(Of Integer) Implements IrowTblBatchProcessingSetItem.colFldSetId
            Get
                Return m_colFldSetId
            End Get
            Set
                If Not Same(m_colFldSetId, Value) Then
                    m_colFldSetId = Value
                    m_IsDirty(FieldIndex.colFldSetId) = True
                End If
            End Set
        End Property
        Private m_colFldSetId As Nullable(Of Integer)

        Public Property colFldMetaObjectId() As Nullable(Of Integer) Implements IrowTblBatchProcessingSetItem.colFldMetaObjectId
            Get
                Return m_colFldMetaObjectId
            End Get
            Set
                If Not Same(m_colFldMetaObjectId, Value) Then
                    m_colFldMetaObjectId = Value
                    m_IsDirty(FieldIndex.colFldMetaObjectId) = True
                End If
            End Set
        End Property
        Private m_colFldMetaObjectId As Nullable(Of Integer)

        Public Property colFldStatusId() As Nullable(Of Integer) Implements IrowTblBatchProcessingSetItem.colFldStatusId
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

        Public Property colFldException() As String Implements IrowTblBatchProcessingSetItem.colFldException
            Get
                Return m_colFldException
            End Get
            Set
                If Not Same(m_colFldException, Value) Then
                    m_colFldException = Value
                    m_IsDirty(FieldIndex.colFldException) = True
                End If
            End Set
        End Property
        Private m_colFldException As String

        Public Property colExtendedPropJSON() As String Implements IrowTblBatchProcessingSetItem.colExtendedPropJSON
            Get
                Return m_colExtendedPropJSON
            End Get
            Set
                If Not Same(m_colExtendedPropJSON, Value) Then
                    m_colExtendedPropJSON = Value
                    m_IsDirty(FieldIndex.colExtendedPropJSON) = True
                End If
            End Set
        End Property
        Private m_colExtendedPropJSON As String


        Public Function IsDirty(pIndex As rowTblBatchProcessingSetItem.FieldIndex) As Boolean Implements IrowTblBatchProcessingSetItem.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblBatchProcessingSetItem.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblBatchProcessingSetItem.SetIsDirty
            m_IsDirty(FieldIndex.colFldId) = pDirty
            m_IsDirty(FieldIndex.colFldSetId) = pDirty
            m_IsDirty(FieldIndex.colFldMetaObjectId) = pDirty
            m_IsDirty(FieldIndex.colFldStatusId) = pDirty
            m_IsDirty(FieldIndex.colFldException) = pDirty
            m_IsDirty(FieldIndex.colExtendedPropJSON) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblBatchProcessingSetItem) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblBatchProcessingSetItem
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldId  = 1
            colFldSetId 
            colFldMetaObjectId 
            colFldStatusId 
            colFldException 
            colExtendedPropJSON 
        End Enum

        Private m_IsDirty(6) As Boolean

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

    Public Interface IrowTblBatchProcessingSetItem
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldId() As Nullable(Of Integer)
        Property colFldSetId() As Nullable(Of Integer)
        Property colFldMetaObjectId() As Nullable(Of Integer)
        Property colFldStatusId() As Nullable(Of Integer)
        Property colFldException() As String
        Property colExtendedPropJSON() As String
        Function IsDirty(pIndex As rowTblBatchProcessingSetItem.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

