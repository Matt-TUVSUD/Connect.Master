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
    Partial Public Class TblGSafeUserReclass

        Public Shared Sub Delete(ByRef pRowData As IrowTblGSafeUserReclass)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblGSafeUserReclass, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblGSafeUserReclass, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblGSafeUserReclass, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[GSafeUserReclass] " & _
                        "WHERE [Id] = @colId"

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
        Dim zObj As rowTblGSafeUserReclass = LoadByPrimaryKey(pcolId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblGSafeUserReclass)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblGSafeUserReclass, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblGSafeUserReclass, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[GSafeUserReclass] WHERE [Id] = @colId"

                Dim zCmdDoesExist As New SQLCommand

                zCmdDoesExist.CommandText = zSQL

                zCmdDoesExist.Parameters.Add(new SQLParameter("@colId", pRowData.colId))

                'if zExistInDB > 0  then  PK exists in the DB
                zCmdDoesExist.Transaction = pTransaction
                zExistInDB = razor.UtilSQLServer.ExecuteScalar(zCmdDoesExist)
            End If

            If razor.UtilSQLServer.IsKeySet(pRowData.colId) And zExistInDB > 0 Then
                zMode = "UPDATE"
            End If
            If razor.UtilSQLServer.IsKeySet(pRowData.colId) And zExistInDB = 0 Then
                zMode = "INSERTwithKey"
            End If
            If Not razor.UtilSQLServer.IsKeySet(pRowData.colId) Then
                zMode = "INSERTnoKey"
            End If

            Select Case zMode
                Case "UPDATE"
                    If pRowData.IsDirty Then
                        Dim zUpdate As String = ""
                        Dim zSet As String = ""
                        Dim zWhere As String = ""
                        zUpdate = "UPDATE [dbo].[GSafeUserReclass] SET " 
                        If pRowData.IsDirty(rowTblGSafeUserReclass.FieldIndex.colGsafeId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [GsafeId] = @colGsafeId "
                        End If
                        If pRowData.IsDirty(rowTblGSafeUserReclass.FieldIndex.colUserIndex) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [UserIndex] = @colUserIndex "
                        End If
                        If pRowData.IsDirty(rowTblGSafeUserReclass.FieldIndex.colEzyUserGuid) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [EzyUserGuid] = @colEzyUserGuid "
                        End If
                        If pRowData.IsDirty(rowTblGSafeUserReclass.FieldIndex.colIsReviewed) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [IsReviewed] = @colIsReviewed "
                        End If
                        zWhere = " WHERE [Id] = @colId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[GSafeUserReclass] ([GsafeId], [UserIndex], [EzyUserGuid], [IsReviewed])" & _
                            " VALUES (@colGsafeId, @colUserIndex, @colEzyUserGuid, @colIsReviewed); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[GSafeUserReclass] ([GsafeId], [UserIndex], [EzyUserGuid], [IsReviewed])" & _
                            " VALUES (@colGsafeId, @colUserIndex, @colEzyUserGuid, @colIsReviewed); SELECT SCOPE_IDENTITY()"
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
            End If

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblGSafeUserReclass.FieldIndex.colGsafeId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colGsafeId", IIf(pRowData.colGsafeId Is Nothing, DBNull.Value, pRowData.colGsafeId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblGSafeUserReclass.FieldIndex.colUserIndex) Then
                    zCmd.Parameters.Add(New SqlParameter("@colUserIndex", IIf(pRowData.colUserIndex Is Nothing, DBNull.Value, pRowData.colUserIndex)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblGSafeUserReclass.FieldIndex.colEzyUserGuid) Then
                    zCmd.Parameters.Add(New SqlParameter("@colEzyUserGuid", IIf(pRowData.colEzyUserGuid Is Nothing, DBNull.Value, pRowData.colEzyUserGuid)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblGSafeUserReclass.FieldIndex.colIsReviewed) Then
                    zCmd.Parameters.Add(New SqlParameter("@colIsReviewed", IIf(pRowData.colIsReviewed Is Nothing, DBNull.Value, pRowData.colIsReviewed)))
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

        Public Shared Function LoadByPrimaryKey(pcolId As Integer) As rowTblGSafeUserReclass
            Return LoadByPrimaryKey(pcolId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolId As Integer, pLoadEventUserState As Object) As rowTblGSafeUserReclass
            Return LoadByPrimaryKey(pcolId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblGSafeUserReclass
            Return LoadByPrimaryKey(pcolId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblGSafeUserReclass
            Dim zReturn As New rowTblGSafeUserReclass
            Dim zSQL As String = "SELECT * FROM [dbo].[GSafeUserReclass] WHERE [Id] = @colId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colId", pcolId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblGSafeUserReclass) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_IX_EzyUserGuid(pcolEzyUserGuid As String) As List(Of rowTblGSafeUserReclass)
            Return LoadByIDX_IX_EzyUserGuid(pcolEzyUserGuid, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_EzyUserGuid(pcolEzyUserGuid As String, pLoadEventUserState As Object) As List(Of rowTblGSafeUserReclass)
            Return LoadByIDX_IX_EzyUserGuid(pcolEzyUserGuid, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_EzyUserGuid(pcolEzyUserGuid As String, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblGSafeUserReclass)
            Return LoadByIDX_IX_EzyUserGuid(pcolEzyUserGuid, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_EzyUserGuid(pcolEzyUserGuid As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblGSafeUserReclass)
            Dim zReturn As New List(Of rowTblGSafeUserReclass)
            Dim zSQL As String = "SELECT * FROM [dbo].[GSafeUserReclass] WHERE [EzyUserGuid] = @colEzyUserGuid"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colEzyUserGuid", pcolEzyUserGuid))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function
        Public Shared Function LoadByIDX_IX_GSafeId(pcolGsafeId As Integer) As List(Of rowTblGSafeUserReclass)
            Return LoadByIDX_IX_GSafeId(pcolGsafeId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_GSafeId(pcolGsafeId As Integer, pLoadEventUserState As Object) As List(Of rowTblGSafeUserReclass)
            Return LoadByIDX_IX_GSafeId(pcolGsafeId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_GSafeId(pcolGsafeId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblGSafeUserReclass)
            Return LoadByIDX_IX_GSafeId(pcolGsafeId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_GSafeId(pcolGsafeId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblGSafeUserReclass)
            Dim zReturn As New List(Of rowTblGSafeUserReclass)
            Dim zSQL As String = "SELECT * FROM [dbo].[GSafeUserReclass] WHERE [GsafeId] = @colGsafeId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colGsafeId", pcolGsafeId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function
        Public Shared Function LoadByIDX_PK__GSafeUse__3214EC0746BFCEDF(pcolId As Integer) As List(Of rowTblGSafeUserReclass)
            Return LoadByIDX_PK__GSafeUse__3214EC0746BFCEDF(pcolId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__GSafeUse__3214EC0746BFCEDF(pcolId As Integer, pLoadEventUserState As Object) As List(Of rowTblGSafeUserReclass)
            Return LoadByIDX_PK__GSafeUse__3214EC0746BFCEDF(pcolId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__GSafeUse__3214EC0746BFCEDF(pcolId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblGSafeUserReclass)
            Return LoadByIDX_PK__GSafeUse__3214EC0746BFCEDF(pcolId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__GSafeUse__3214EC0746BFCEDF(pcolId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblGSafeUserReclass)
            Dim zReturn As New List(Of rowTblGSafeUserReclass)
            Dim zSQL As String = "SELECT * FROM [dbo].[GSafeUserReclass] WHERE [Id] = @colId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colId", pcolId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblGSafeUserReclass)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblGSafeUserReclass)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblGSafeUserReclass)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblGSafeUserReclass)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblGSafeUserReclass)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblGSafeUserReclass)
            Dim zReturn As New List(Of rowTblGSafeUserReclass)
            Dim zSQL As String = "SELECT * FROM [dbo].[GSafeUserReclass]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblGSafeUserReclass)

			Try
	            Dim zReturn As New List(Of rowTblGSafeUserReclass)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblGSafeUserReclass

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblGSafeUserReclass		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblGSafeUserReclass)
			If Not pReader.IsDBNull(pReader.GetOrdinal("Id")) Then pObject.colId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "Id")
			If Not pReader.IsDBNull(pReader.GetOrdinal("GsafeId")) Then pObject.colGsafeId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "GsafeId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("UserIndex")) Then pObject.colUserIndex = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "UserIndex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("EzyUserGuid")) Then pObject.colEzyUserGuid = UtilSQLServer.SafeReader.SafeReadString(pReader, "EzyUserGuid")
			If Not pReader.IsDBNull(pReader.GetOrdinal("IsReviewed")) Then pObject.colIsReviewed = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "IsReviewed")
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
            If Not TypeOf zReturn Is rowTblGSafeUserReclass Then Throw New ArgumentException("Generic type is not type of rowTblGSafeUserReclass.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[GSafeUserReclass] WHERE [Id] = @colId"
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

        Public Shared Function LoadByIDX_IX_EzyUserGuid(Of T)(pcolEzyUserGuid As String) As List(Of T)
            Return LoadByIDX_IX_EzyUserGuid(Of T)(pcolEzyUserGuid, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_EzyUserGuid(Of T)(pcolEzyUserGuid As String, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_IX_EzyUserGuid(Of T)(pcolEzyUserGuid, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_EzyUserGuid(Of T)(pcolEzyUserGuid As String, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_IX_EzyUserGuid(Of T)(pcolEzyUserGuid, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_IX_EzyUserGuid(Of T)(pcolEzyUserGuid As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[GSafeUserReclass] WHERE [EzyUserGuid] = @colEzyUserGuid"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colEzyUserGuid", pcolEzyUserGuid))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_IX_GSafeId(Of T)(pcolGsafeId As Integer) As List(Of T)
            Return LoadByIDX_IX_GSafeId(Of T)(pcolGsafeId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_GSafeId(Of T)(pcolGsafeId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_IX_GSafeId(Of T)(pcolGsafeId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_GSafeId(Of T)(pcolGsafeId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_IX_GSafeId(Of T)(pcolGsafeId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_IX_GSafeId(Of T)(pcolGsafeId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[GSafeUserReclass] WHERE [GsafeId] = @colGsafeId"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colGsafeId", pcolGsafeId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_PK__GSafeUse__3214EC0746BFCEDF(Of T)(pcolId As Integer) As List(Of T)
            Return LoadByIDX_PK__GSafeUse__3214EC0746BFCEDF(Of T)(pcolId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__GSafeUse__3214EC0746BFCEDF(Of T)(pcolId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK__GSafeUse__3214EC0746BFCEDF(Of T)(pcolId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__GSafeUse__3214EC0746BFCEDF(Of T)(pcolId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK__GSafeUse__3214EC0746BFCEDF(Of T)(pcolId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK__GSafeUse__3214EC0746BFCEDF(Of T)(pcolId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[GSafeUserReclass] WHERE [Id] = @colId"
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
            Dim zSQL As String = "SELECT * FROM [dbo].[GSafeUserReclass]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblGSafeUserReclass
        Implements IrowTblGSafeUserReclass

        Public Event Loaded(pUserState As Object) Implements IrowTblGSafeUserReclass.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblGSafeUserReclass.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblGSafeUserReclass.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblGSafeUserReclass.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblGSafeUserReclass.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblGSafeUserReclass.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colId() As Nullable(Of Integer) Implements IrowTblGSafeUserReclass.colId
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

        Public Property colGsafeId() As Nullable(Of Integer) Implements IrowTblGSafeUserReclass.colGsafeId
            Get
                Return m_colGsafeId
            End Get
            Set
                If Not Same(m_colGsafeId, Value) Then
                    m_colGsafeId = Value
                    m_IsDirty(FieldIndex.colGsafeId) = True
                End If
            End Set
        End Property
        Private m_colGsafeId As Nullable(Of Integer)

        Public Property colUserIndex() As Nullable(Of Integer) Implements IrowTblGSafeUserReclass.colUserIndex
            Get
                Return m_colUserIndex
            End Get
            Set
                If Not Same(m_colUserIndex, Value) Then
                    m_colUserIndex = Value
                    m_IsDirty(FieldIndex.colUserIndex) = True
                End If
            End Set
        End Property
        Private m_colUserIndex As Nullable(Of Integer)

        Public Property colEzyUserGuid() As String Implements IrowTblGSafeUserReclass.colEzyUserGuid
            Get
                Return m_colEzyUserGuid
            End Get
            Set
                If Not Same(m_colEzyUserGuid, Value) Then
                    m_colEzyUserGuid = Value
                    m_IsDirty(FieldIndex.colEzyUserGuid) = True
                End If
            End Set
        End Property
        Private m_colEzyUserGuid As String

        Public Property colIsReviewed() As Nullable(Of Boolean) Implements IrowTblGSafeUserReclass.colIsReviewed
            Get
                Return m_colIsReviewed
            End Get
            Set
                If Not Same(m_colIsReviewed, Value) Then
                    m_colIsReviewed = Value
                    m_IsDirty(FieldIndex.colIsReviewed) = True
                End If
            End Set
        End Property
        Private m_colIsReviewed As Nullable(Of Boolean)


        Public Function IsDirty(pIndex As rowTblGSafeUserReclass.FieldIndex) As Boolean Implements IrowTblGSafeUserReclass.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblGSafeUserReclass.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblGSafeUserReclass.SetIsDirty
            m_IsDirty(FieldIndex.colId) = pDirty
            m_IsDirty(FieldIndex.colGsafeId) = pDirty
            m_IsDirty(FieldIndex.colUserIndex) = pDirty
            m_IsDirty(FieldIndex.colEzyUserGuid) = pDirty
            m_IsDirty(FieldIndex.colIsReviewed) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblGSafeUserReclass) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblGSafeUserReclass
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colId  = 1
            colGsafeId 
            colUserIndex 
            colEzyUserGuid 
            colIsReviewed 
        End Enum

        Private m_IsDirty(5) As Boolean

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

    Public Interface IrowTblGSafeUserReclass
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colId() As Nullable(Of Integer)
        Property colGsafeId() As Nullable(Of Integer)
        Property colUserIndex() As Nullable(Of Integer)
        Property colEzyUserGuid() As String
        Property colIsReviewed() As Nullable(Of Boolean)
        Function IsDirty(pIndex As rowTblGSafeUserReclass.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

