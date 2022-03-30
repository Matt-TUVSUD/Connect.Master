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
    Partial Public Class TblGSafeHeader

        Public Shared Sub Delete(ByRef pRowData As IrowTblGSafeHeader)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblGSafeHeader, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblGSafeHeader, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblGSafeHeader, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colGSafeId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[GSafeHeader] " & _
                        "WHERE [GSafeId] = @colGSafeId"

                Dim zCmd As New SQLCommand
                zCmd.CommandText = zSQL
                zCmd.Parameters.Add(New SQLParameter("@colGSafeId", pRowData.colGSafeId))

                zCmd.Transaction=pTransaction
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)

                pRowData.RaiseDeletedEvent(pDeleteEventUserState)

            End If

        End Sub

        Public Shared Sub Delete(pcolGSafeId As Integer)
            Delete(pcolGSafeId, Nothing, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolGSafeId As Integer, pDeleteEventUserState As Object)
            Delete(pcolGSafeId, Nothing, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Delete(pcolGSafeId As Integer, ByRef pTransaction As SqlClient.SqlTransaction)
        Delete(pcolGSafeId, pTransaction, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolGSafeId As Integer, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
        Dim zObj As rowTblGSafeHeader = LoadByPrimaryKey(pcolGSafeId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblGSafeHeader)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblGSafeHeader, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblGSafeHeader, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colGSafeId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[GSafeHeader] WHERE [GSafeId] = @colGSafeId"

                Dim zCmdDoesExist As New SQLCommand

                zCmdDoesExist.CommandText = zSQL

                zCmdDoesExist.Parameters.Add(new SQLParameter("@colGSafeId", pRowData.colGSafeId))

                'if zExistInDB > 0  then  PK exists in the DB
                zCmdDoesExist.Transaction = pTransaction
                zExistInDB = razor.UtilSQLServer.ExecuteScalar(zCmdDoesExist)
            End If

            If razor.UtilSQLServer.IsKeySet(pRowData.colGSafeId) And zExistInDB > 0 Then
                zMode = "UPDATE"
            End If
            If razor.UtilSQLServer.IsKeySet(pRowData.colGSafeId) And zExistInDB = 0 Then
                zMode = "INSERTwithKey"
            End If
            If Not razor.UtilSQLServer.IsKeySet(pRowData.colGSafeId) Then
                zMode = "INSERTnoKey"
            End If

            Select Case zMode
                Case "UPDATE"
                    If pRowData.IsDirty Then
                        Dim zUpdate As String = ""
                        Dim zSet As String = ""
                        Dim zWhere As String = ""
                        zUpdate = "UPDATE [dbo].[GSafeHeader] SET " 
                        If pRowData.IsDirty(rowTblGSafeHeader.FieldIndex.colGSafeGUID) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [GSafeGUID] = @colGSafeGUID "
                        End If
                        If pRowData.IsDirty(rowTblGSafeHeader.FieldIndex.colCreated) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [Created] = @colCreated "
                        End If
                        If pRowData.IsDirty(rowTblGSafeHeader.FieldIndex.colLastAccessed) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [LastAccessed] = @colLastAccessed "
                        End If
                        If pRowData.IsDirty(rowTblGSafeHeader.FieldIndex.colLastUpdated) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [LastUpdated] = @colLastUpdated "
                        End If
                        If pRowData.IsDirty(rowTblGSafeHeader.FieldIndex.colLoginName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [LoginName] = @colLoginName "
                        End If
                        If pRowData.IsDirty(rowTblGSafeHeader.FieldIndex.colLoginID) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [LoginID] = @colLoginID "
                        End If
                        zWhere = " WHERE [GSafeId] = @colGSafeId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[GSafeHeader] ([GSafeGUID], [Created], [LastAccessed], [LastUpdated], [LoginName], [LoginID])" & _
                            " VALUES (@colGSafeGUID, @colCreated, @colLastAccessed, @colLastUpdated, @colLoginName, @colLoginID); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[GSafeHeader] ([GSafeGUID], [Created], [LastAccessed], [LastUpdated], [LoginName], [LoginID])" & _
                            " VALUES (@colGSafeGUID, @colCreated, @colLastAccessed, @colLastUpdated, @colLoginName, @colLoginID); SELECT SCOPE_IDENTITY()"
                Case Else
            End Select

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

			'IF UPDATE, SET PK PARAMETER
            If zMode = "UPDATE" Then
                zCmd.Parameters.Add(New SQLParameter("@colGSafeId", pRowData.colGSafeId))
            End If

			'IF INSERTING, KEY HAS VALUE AND KEY IS NOT IDENTITY, SET PK PARAMETER
			If zMode = "INSERTwithKey" Then
            End If

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblGSafeHeader.FieldIndex.colGSafeGUID) Then
                    zCmd.Parameters.Add(New SqlParameter("@colGSafeGUID", IIf(pRowData.colGSafeGUID Is Nothing, DBNull.Value, pRowData.colGSafeGUID)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblGSafeHeader.FieldIndex.colCreated) Then
                    zCmd.Parameters.Add(New SqlParameter("@colCreated", IIf(pRowData.colCreated Is Nothing, DBNull.Value, pRowData.colCreated)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblGSafeHeader.FieldIndex.colLastAccessed) Then
                    zCmd.Parameters.Add(New SqlParameter("@colLastAccessed", IIf(pRowData.colLastAccessed Is Nothing, DBNull.Value, pRowData.colLastAccessed)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblGSafeHeader.FieldIndex.colLastUpdated) Then
                    zCmd.Parameters.Add(New SqlParameter("@colLastUpdated", IIf(pRowData.colLastUpdated Is Nothing, DBNull.Value, pRowData.colLastUpdated)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblGSafeHeader.FieldIndex.colLoginName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colLoginName", IIf(pRowData.colLoginName Is Nothing, DBNull.Value, pRowData.colLoginName)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblGSafeHeader.FieldIndex.colLoginID) Then
                    zCmd.Parameters.Add(New SqlParameter("@colLoginID", IIf(pRowData.colLoginID Is Nothing, DBNull.Value, pRowData.colLoginID)))
                End If

            zCmd.Transaction=pTransaction
            If zMode = "INSERTnoKey" Then
                Dim zLastId As Long = 0
                zLastId = razor.UtilSQLServer.ExecuteNonQueryRowId(zCmd)

                pRowData.colGSafeId = zLastId
            Else
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)
            End If

            pRowData.SetIsDirty(False)
            pRowData.RaiseSavedEvent(pSavedEventUserState)

		End If

        End Sub

        Public Shared Function LoadByPrimaryKey(pcolGSafeId As Integer) As rowTblGSafeHeader
            Return LoadByPrimaryKey(pcolGSafeId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolGSafeId As Integer, pLoadEventUserState As Object) As rowTblGSafeHeader
            Return LoadByPrimaryKey(pcolGSafeId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolGSafeId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblGSafeHeader
            Return LoadByPrimaryKey(pcolGSafeId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolGSafeId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblGSafeHeader
            Dim zReturn As New rowTblGSafeHeader
            Dim zSQL As String = "SELECT * FROM [dbo].[GSafeHeader] WHERE [GSafeId] = @colGSafeId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colGSafeId", pcolGSafeId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblGSafeHeader) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_IX_GSafeHeaderGUID(pcolGSafeId As Integer) As List(Of rowTblGSafeHeader)
            Return LoadByIDX_IX_GSafeHeaderGUID(pcolGSafeId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_GSafeHeaderGUID(pcolGSafeId As Integer, pLoadEventUserState As Object) As List(Of rowTblGSafeHeader)
            Return LoadByIDX_IX_GSafeHeaderGUID(pcolGSafeId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_GSafeHeaderGUID(pcolGSafeId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblGSafeHeader)
            Return LoadByIDX_IX_GSafeHeaderGUID(pcolGSafeId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_GSafeHeaderGUID(pcolGSafeId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblGSafeHeader)
            Dim zReturn As New List(Of rowTblGSafeHeader)
            Dim zSQL As String = "SELECT * FROM [dbo].[GSafeHeader] WHERE [GSafeId] = @colGSafeId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colGSafeId", pcolGSafeId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function
        Public Shared Function LoadByIDX_PK_GSafeHeader(pcolGSafeId As Integer) As List(Of rowTblGSafeHeader)
            Return LoadByIDX_PK_GSafeHeader(pcolGSafeId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_GSafeHeader(pcolGSafeId As Integer, pLoadEventUserState As Object) As List(Of rowTblGSafeHeader)
            Return LoadByIDX_PK_GSafeHeader(pcolGSafeId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_GSafeHeader(pcolGSafeId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblGSafeHeader)
            Return LoadByIDX_PK_GSafeHeader(pcolGSafeId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_GSafeHeader(pcolGSafeId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblGSafeHeader)
            Dim zReturn As New List(Of rowTblGSafeHeader)
            Dim zSQL As String = "SELECT * FROM [dbo].[GSafeHeader] WHERE [GSafeId] = @colGSafeId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colGSafeId", pcolGSafeId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblGSafeHeader)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblGSafeHeader)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblGSafeHeader)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblGSafeHeader)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblGSafeHeader)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblGSafeHeader)
            Dim zReturn As New List(Of rowTblGSafeHeader)
            Dim zSQL As String = "SELECT * FROM [dbo].[GSafeHeader]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblGSafeHeader)

			Try
	            Dim zReturn As New List(Of rowTblGSafeHeader)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblGSafeHeader

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblGSafeHeader		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblGSafeHeader)
			If Not pReader.IsDBNull(pReader.GetOrdinal("GSafeId")) Then pObject.colGSafeId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "GSafeId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("GSafeGUID")) Then pObject.colGSafeGUID = UtilSQLServer.SafeReader.SafeReadString(pReader, "GSafeGUID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Created")) Then pObject.colCreated = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "Created")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LastAccessed")) Then pObject.colLastAccessed = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "LastAccessed")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LastUpdated")) Then pObject.colLastUpdated = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "LastUpdated")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LoginName")) Then pObject.colLoginName = UtilSQLServer.SafeReader.SafeReadString(pReader, "LoginName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LoginID")) Then pObject.colLoginID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "LoginID")
			pObject.SetIsDirty(False)
			Return pObject
		End	 Function

    #Region "Reflection Based Load Functions"

        Public Shared Function LoadByPrimaryKey(Of T)(pcolGSafeId As Integer) As T
            Return LoadByPrimaryKey(Of T)(pcolGSafeId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolGSafeId As Integer, pLoadEventUserState As Object) As T
            Return LoadByPrimaryKey(Of T)(pcolGSafeId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolGSafeId As Integer, pTransaction As SqlClient.SqlTransaction) As T
            Return LoadByPrimaryKey(Of T)(pcolGSafeId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolGSafeId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As T

            Dim zReturn As Object = Activator.CreateInstance(Of T)()
            If Not TypeOf zReturn Is rowTblGSafeHeader Then Throw New ArgumentException("Generic type is not type of rowTblGSafeHeader.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[GSafeHeader] WHERE [GSafeId] = @colGSafeId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colGSafeId", pcolGSafeId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of T) = ReadData(Of T)(zCmd, pLoadEventUserState)
            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

        End Function

        Public Shared Function LoadByIDX_IX_GSafeHeaderGUID(Of T)(pcolGSafeId As Integer) As List(Of T)
            Return LoadByIDX_IX_GSafeHeaderGUID(Of T)(pcolGSafeId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_GSafeHeaderGUID(Of T)(pcolGSafeId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_IX_GSafeHeaderGUID(Of T)(pcolGSafeId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_GSafeHeaderGUID(Of T)(pcolGSafeId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_IX_GSafeHeaderGUID(Of T)(pcolGSafeId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_IX_GSafeHeaderGUID(Of T)(pcolGSafeId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[GSafeHeader] WHERE [GSafeId] = @colGSafeId"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colGSafeId", pcolGSafeId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_PK_GSafeHeader(Of T)(pcolGSafeId As Integer) As List(Of T)
            Return LoadByIDX_PK_GSafeHeader(Of T)(pcolGSafeId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_GSafeHeader(Of T)(pcolGSafeId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK_GSafeHeader(Of T)(pcolGSafeId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_GSafeHeader(Of T)(pcolGSafeId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK_GSafeHeader(Of T)(pcolGSafeId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK_GSafeHeader(Of T)(pcolGSafeId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[GSafeHeader] WHERE [GSafeId] = @colGSafeId"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colGSafeId", pcolGSafeId))

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
            Dim zSQL As String = "SELECT * FROM [dbo].[GSafeHeader]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblGSafeHeader
        Implements IrowTblGSafeHeader

        Public Event Loaded(pUserState As Object) Implements IrowTblGSafeHeader.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblGSafeHeader.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblGSafeHeader.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblGSafeHeader.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblGSafeHeader.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblGSafeHeader.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colGSafeId() As Nullable(Of Integer) Implements IrowTblGSafeHeader.colGSafeId
            Get
                Return m_colGSafeId
            End Get
            Set
                If Not Same(m_colGSafeId, Value) Then
                    m_colGSafeId = Value
                    m_IsDirty(FieldIndex.colGSafeId) = True
                End If
            End Set
        End Property
        Private m_colGSafeId As Nullable(Of Integer)

        Public Property colGSafeGUID() As String Implements IrowTblGSafeHeader.colGSafeGUID
            Get
                Return m_colGSafeGUID
            End Get
            Set
                If Not Same(m_colGSafeGUID, Value) Then
                    m_colGSafeGUID = Value
                    m_IsDirty(FieldIndex.colGSafeGUID) = True
                End If
            End Set
        End Property
        Private m_colGSafeGUID As String

        Public Property colCreated() As Nullable(Of DateTime) Implements IrowTblGSafeHeader.colCreated
            Get
                Return m_colCreated
            End Get
            Set
                If Not Same(m_colCreated, Value) Then
                    m_colCreated = Value
                    m_IsDirty(FieldIndex.colCreated) = True
                End If
            End Set
        End Property
        Private m_colCreated As Nullable(Of DateTime)

        Public Property colLastAccessed() As Nullable(Of DateTime) Implements IrowTblGSafeHeader.colLastAccessed
            Get
                Return m_colLastAccessed
            End Get
            Set
                If Not Same(m_colLastAccessed, Value) Then
                    m_colLastAccessed = Value
                    m_IsDirty(FieldIndex.colLastAccessed) = True
                End If
            End Set
        End Property
        Private m_colLastAccessed As Nullable(Of DateTime)

        Public Property colLastUpdated() As Nullable(Of DateTime) Implements IrowTblGSafeHeader.colLastUpdated
            Get
                Return m_colLastUpdated
            End Get
            Set
                If Not Same(m_colLastUpdated, Value) Then
                    m_colLastUpdated = Value
                    m_IsDirty(FieldIndex.colLastUpdated) = True
                End If
            End Set
        End Property
        Private m_colLastUpdated As Nullable(Of DateTime)

        Public Property colLoginName() As String Implements IrowTblGSafeHeader.colLoginName
            Get
                Return m_colLoginName
            End Get
            Set
                If Not Same(m_colLoginName, Value) Then
                    m_colLoginName = Value
                    m_IsDirty(FieldIndex.colLoginName) = True
                End If
            End Set
        End Property
        Private m_colLoginName As String

        Public Property colLoginID() As Nullable(Of Integer) Implements IrowTblGSafeHeader.colLoginID
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


        Public Function IsDirty(pIndex As rowTblGSafeHeader.FieldIndex) As Boolean Implements IrowTblGSafeHeader.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblGSafeHeader.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblGSafeHeader.SetIsDirty
            m_IsDirty(FieldIndex.colGSafeId) = pDirty
            m_IsDirty(FieldIndex.colGSafeGUID) = pDirty
            m_IsDirty(FieldIndex.colCreated) = pDirty
            m_IsDirty(FieldIndex.colLastAccessed) = pDirty
            m_IsDirty(FieldIndex.colLastUpdated) = pDirty
            m_IsDirty(FieldIndex.colLoginName) = pDirty
            m_IsDirty(FieldIndex.colLoginID) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblGSafeHeader) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblGSafeHeader
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colGSafeId  = 1
            colGSafeGUID 
            colCreated 
            colLastAccessed 
            colLastUpdated 
            colLoginName 
            colLoginID 
        End Enum

        Private m_IsDirty(7) As Boolean

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

    Public Interface IrowTblGSafeHeader
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colGSafeId() As Nullable(Of Integer)
        Property colGSafeGUID() As String
        Property colCreated() As Nullable(Of DateTime)
        Property colLastAccessed() As Nullable(Of DateTime)
        Property colLastUpdated() As Nullable(Of DateTime)
        Property colLoginName() As String
        Property colLoginID() As Nullable(Of Integer)
        Function IsDirty(pIndex As rowTblGSafeHeader.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

