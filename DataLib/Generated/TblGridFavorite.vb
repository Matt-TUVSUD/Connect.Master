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
    Partial Public Class TblGridFavorite

        Public Shared Sub Delete(ByRef pRowData As IrowTblGridFavorite)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblGridFavorite, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblGridFavorite, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblGridFavorite, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[tblGridFavorite] " & _
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
        Dim zObj As rowTblGridFavorite = LoadByPrimaryKey(pcolId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblGridFavorite)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblGridFavorite, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblGridFavorite, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[tblGridFavorite] WHERE [Id] = @colId"

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
                        zUpdate = "UPDATE [dbo].[tblGridFavorite] SET " 
                        If pRowData.IsDirty(rowTblGridFavorite.FieldIndex.colFldTitle) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldTitle] = @colFldTitle "
                        End If
                        If pRowData.IsDirty(rowTblGridFavorite.FieldIndex.colFldFilePrefix) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldFilePrefix] = @colFldFilePrefix "
                        End If
                        If pRowData.IsDirty(rowTblGridFavorite.FieldIndex.colFldGridId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldGridId] = @colFldGridId "
                        End If
                        If pRowData.IsDirty(rowTblGridFavorite.FieldIndex.colFldEzyUserId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldEzyUserId] = @colFldEzyUserId "
                        End If
                        If pRowData.IsDirty(rowTblGridFavorite.FieldIndex.colFldPractice) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldPractice] = @colFldPractice "
                        End If
                        If pRowData.IsDirty(rowTblGridFavorite.FieldIndex.colFldCurrencyId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldCurrencyId] = @colFldCurrencyId "
                        End If
                        If pRowData.IsDirty(rowTblGridFavorite.FieldIndex.colFldUnitId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldUnitId] = @colFldUnitId "
                        End If
                        If pRowData.IsDirty(rowTblGridFavorite.FieldIndex.colFldColumnOrderJSON) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldColumnOrderJSON] = @colFldColumnOrderJSON "
                        End If
                        If pRowData.IsDirty(rowTblGridFavorite.FieldIndex.colFldSortJSON) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldSortJSON] = @colFldSortJSON "
                        End If
                        If pRowData.IsDirty(rowTblGridFavorite.FieldIndex.colFldFilterJSON) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldFilterJSON] = @colFldFilterJSON "
                        End If
                        If pRowData.IsDirty(rowTblGridFavorite.FieldIndex.colFldCriteriaJSON) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldCriteriaJSON] = @colFldCriteriaJSON "
                        End If
                        If pRowData.IsDirty(rowTblGridFavorite.FieldIndex.colFldUpdateDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldUpdateDate] = @colFldUpdateDate "
                        End If
                        zWhere = " WHERE [Id] = @colId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[tblGridFavorite] ([fldTitle], [fldFilePrefix], [fldGridId], [fldEzyUserId], [fldPractice], [fldCurrencyId], [fldUnitId], [fldColumnOrderJSON], [fldSortJSON], [fldFilterJSON], [fldCriteriaJSON], [fldUpdateDate])" & _
                            " VALUES (@colFldTitle, @colFldFilePrefix, @colFldGridId, @colFldEzyUserId, @colFldPractice, @colFldCurrencyId, @colFldUnitId, @colFldColumnOrderJSON, @colFldSortJSON, @colFldFilterJSON, @colFldCriteriaJSON, @colFldUpdateDate); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[tblGridFavorite] ([fldTitle], [fldFilePrefix], [fldGridId], [fldEzyUserId], [fldPractice], [fldCurrencyId], [fldUnitId], [fldColumnOrderJSON], [fldSortJSON], [fldFilterJSON], [fldCriteriaJSON], [fldUpdateDate])" & _
                            " VALUES (@colFldTitle, @colFldFilePrefix, @colFldGridId, @colFldEzyUserId, @colFldPractice, @colFldCurrencyId, @colFldUnitId, @colFldColumnOrderJSON, @colFldSortJSON, @colFldFilterJSON, @colFldCriteriaJSON, @colFldUpdateDate); SELECT SCOPE_IDENTITY()"
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

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblGridFavorite.FieldIndex.colFldTitle) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldTitle", IIf(pRowData.colFldTitle Is Nothing, DBNull.Value, pRowData.colFldTitle)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblGridFavorite.FieldIndex.colFldFilePrefix) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldFilePrefix", IIf(pRowData.colFldFilePrefix Is Nothing, DBNull.Value, pRowData.colFldFilePrefix)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblGridFavorite.FieldIndex.colFldGridId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldGridId", IIf(pRowData.colFldGridId Is Nothing, DBNull.Value, pRowData.colFldGridId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblGridFavorite.FieldIndex.colFldEzyUserId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldEzyUserId", IIf(pRowData.colFldEzyUserId Is Nothing, DBNull.Value, pRowData.colFldEzyUserId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblGridFavorite.FieldIndex.colFldPractice) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldPractice", IIf(pRowData.colFldPractice Is Nothing, DBNull.Value, pRowData.colFldPractice)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblGridFavorite.FieldIndex.colFldCurrencyId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldCurrencyId", IIf(pRowData.colFldCurrencyId Is Nothing, DBNull.Value, pRowData.colFldCurrencyId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblGridFavorite.FieldIndex.colFldUnitId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldUnitId", IIf(pRowData.colFldUnitId Is Nothing, DBNull.Value, pRowData.colFldUnitId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblGridFavorite.FieldIndex.colFldColumnOrderJSON) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldColumnOrderJSON", IIf(pRowData.colFldColumnOrderJSON Is Nothing, DBNull.Value, pRowData.colFldColumnOrderJSON)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblGridFavorite.FieldIndex.colFldSortJSON) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldSortJSON", IIf(pRowData.colFldSortJSON Is Nothing, DBNull.Value, pRowData.colFldSortJSON)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblGridFavorite.FieldIndex.colFldFilterJSON) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldFilterJSON", IIf(pRowData.colFldFilterJSON Is Nothing, DBNull.Value, pRowData.colFldFilterJSON)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblGridFavorite.FieldIndex.colFldCriteriaJSON) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldCriteriaJSON", IIf(pRowData.colFldCriteriaJSON Is Nothing, DBNull.Value, pRowData.colFldCriteriaJSON)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblGridFavorite.FieldIndex.colFldUpdateDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldUpdateDate", IIf(pRowData.colFldUpdateDate Is Nothing, DBNull.Value, pRowData.colFldUpdateDate)))
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

        Public Shared Function LoadByPrimaryKey(pcolId As Integer) As rowTblGridFavorite
            Return LoadByPrimaryKey(pcolId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolId As Integer, pLoadEventUserState As Object) As rowTblGridFavorite
            Return LoadByPrimaryKey(pcolId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblGridFavorite
            Return LoadByPrimaryKey(pcolId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblGridFavorite
            Dim zReturn As New rowTblGridFavorite
            Dim zSQL As String = "SELECT * FROM [dbo].[tblGridFavorite] WHERE [Id] = @colId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colId", pcolId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblGridFavorite) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK_tblGridFavorite(pcolId As Integer) As List(Of rowTblGridFavorite)
            Return LoadByIDX_PK_tblGridFavorite(pcolId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblGridFavorite(pcolId As Integer, pLoadEventUserState As Object) As List(Of rowTblGridFavorite)
            Return LoadByIDX_PK_tblGridFavorite(pcolId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_tblGridFavorite(pcolId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblGridFavorite)
            Return LoadByIDX_PK_tblGridFavorite(pcolId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblGridFavorite(pcolId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblGridFavorite)
            Dim zReturn As New List(Of rowTblGridFavorite)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblGridFavorite] WHERE [Id] = @colId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colId", pcolId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblGridFavorite)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblGridFavorite)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblGridFavorite)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblGridFavorite)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblGridFavorite)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblGridFavorite)
            Dim zReturn As New List(Of rowTblGridFavorite)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblGridFavorite]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblGridFavorite)

			Try
	            Dim zReturn As New List(Of rowTblGridFavorite)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblGridFavorite

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblGridFavorite		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblGridFavorite)
			If Not pReader.IsDBNull(pReader.GetOrdinal("Id")) Then pObject.colId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "Id")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldTitle")) Then pObject.colFldTitle = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldTitle")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFilePrefix")) Then pObject.colFldFilePrefix = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldFilePrefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldGridId")) Then pObject.colFldGridId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldGridId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldEzyUserId")) Then pObject.colFldEzyUserId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldEzyUserId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldPractice")) Then pObject.colFldPractice = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldPractice")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldCurrencyId")) Then pObject.colFldCurrencyId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldCurrencyId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldUnitId")) Then pObject.colFldUnitId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldUnitId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldColumnOrderJSON")) Then pObject.colFldColumnOrderJSON = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldColumnOrderJSON")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSortJSON")) Then pObject.colFldSortJSON = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldSortJSON")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFilterJSON")) Then pObject.colFldFilterJSON = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldFilterJSON")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldCriteriaJSON")) Then pObject.colFldCriteriaJSON = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldCriteriaJSON")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldUpdateDate")) Then pObject.colFldUpdateDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "fldUpdateDate")
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
            If Not TypeOf zReturn Is rowTblGridFavorite Then Throw New ArgumentException("Generic type is not type of rowTblGridFavorite.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[tblGridFavorite] WHERE [Id] = @colId"
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

        Public Shared Function LoadByIDX_PK_tblGridFavorite(Of T)(pcolId As Integer) As List(Of T)
            Return LoadByIDX_PK_tblGridFavorite(Of T)(pcolId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblGridFavorite(Of T)(pcolId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK_tblGridFavorite(Of T)(pcolId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_tblGridFavorite(Of T)(pcolId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK_tblGridFavorite(Of T)(pcolId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK_tblGridFavorite(Of T)(pcolId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblGridFavorite] WHERE [Id] = @colId"
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
            Dim zSQL As String = "SELECT * FROM [dbo].[tblGridFavorite]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblGridFavorite
        Implements IrowTblGridFavorite

        Public Event Loaded(pUserState As Object) Implements IrowTblGridFavorite.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblGridFavorite.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblGridFavorite.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblGridFavorite.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblGridFavorite.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblGridFavorite.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colId() As Nullable(Of Integer) Implements IrowTblGridFavorite.colId
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

        Public Property colFldTitle() As String Implements IrowTblGridFavorite.colFldTitle
            Get
                Return m_colFldTitle
            End Get
            Set
                If Not Same(m_colFldTitle, Value) Then
                    m_colFldTitle = Value
                    m_IsDirty(FieldIndex.colFldTitle) = True
                End If
            End Set
        End Property
        Private m_colFldTitle As String

        Public Property colFldFilePrefix() As String Implements IrowTblGridFavorite.colFldFilePrefix
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

        Public Property colFldGridId() As Nullable(Of Integer) Implements IrowTblGridFavorite.colFldGridId
            Get
                Return m_colFldGridId
            End Get
            Set
                If Not Same(m_colFldGridId, Value) Then
                    m_colFldGridId = Value
                    m_IsDirty(FieldIndex.colFldGridId) = True
                End If
            End Set
        End Property
        Private m_colFldGridId As Nullable(Of Integer)

        Public Property colFldEzyUserId() As Nullable(Of Integer) Implements IrowTblGridFavorite.colFldEzyUserId
            Get
                Return m_colFldEzyUserId
            End Get
            Set
                If Not Same(m_colFldEzyUserId, Value) Then
                    m_colFldEzyUserId = Value
                    m_IsDirty(FieldIndex.colFldEzyUserId) = True
                End If
            End Set
        End Property
        Private m_colFldEzyUserId As Nullable(Of Integer)

        Public Property colFldPractice() As String Implements IrowTblGridFavorite.colFldPractice
            Get
                Return m_colFldPractice
            End Get
            Set
                If Not Same(m_colFldPractice, Value) Then
                    m_colFldPractice = Value
                    m_IsDirty(FieldIndex.colFldPractice) = True
                End If
            End Set
        End Property
        Private m_colFldPractice As String

        Public Property colFldCurrencyId() As Nullable(Of Integer) Implements IrowTblGridFavorite.colFldCurrencyId
            Get
                Return m_colFldCurrencyId
            End Get
            Set
                If Not Same(m_colFldCurrencyId, Value) Then
                    m_colFldCurrencyId = Value
                    m_IsDirty(FieldIndex.colFldCurrencyId) = True
                End If
            End Set
        End Property
        Private m_colFldCurrencyId As Nullable(Of Integer)

        Public Property colFldUnitId() As Nullable(Of Integer) Implements IrowTblGridFavorite.colFldUnitId
            Get
                Return m_colFldUnitId
            End Get
            Set
                If Not Same(m_colFldUnitId, Value) Then
                    m_colFldUnitId = Value
                    m_IsDirty(FieldIndex.colFldUnitId) = True
                End If
            End Set
        End Property
        Private m_colFldUnitId As Nullable(Of Integer)

        Public Property colFldColumnOrderJSON() As String Implements IrowTblGridFavorite.colFldColumnOrderJSON
            Get
                Return m_colFldColumnOrderJSON
            End Get
            Set
                If Not Same(m_colFldColumnOrderJSON, Value) Then
                    m_colFldColumnOrderJSON = Value
                    m_IsDirty(FieldIndex.colFldColumnOrderJSON) = True
                End If
            End Set
        End Property
        Private m_colFldColumnOrderJSON As String

        Public Property colFldSortJSON() As String Implements IrowTblGridFavorite.colFldSortJSON
            Get
                Return m_colFldSortJSON
            End Get
            Set
                If Not Same(m_colFldSortJSON, Value) Then
                    m_colFldSortJSON = Value
                    m_IsDirty(FieldIndex.colFldSortJSON) = True
                End If
            End Set
        End Property
        Private m_colFldSortJSON As String

        Public Property colFldFilterJSON() As String Implements IrowTblGridFavorite.colFldFilterJSON
            Get
                Return m_colFldFilterJSON
            End Get
            Set
                If Not Same(m_colFldFilterJSON, Value) Then
                    m_colFldFilterJSON = Value
                    m_IsDirty(FieldIndex.colFldFilterJSON) = True
                End If
            End Set
        End Property
        Private m_colFldFilterJSON As String

        Public Property colFldCriteriaJSON() As String Implements IrowTblGridFavorite.colFldCriteriaJSON
            Get
                Return m_colFldCriteriaJSON
            End Get
            Set
                If Not Same(m_colFldCriteriaJSON, Value) Then
                    m_colFldCriteriaJSON = Value
                    m_IsDirty(FieldIndex.colFldCriteriaJSON) = True
                End If
            End Set
        End Property
        Private m_colFldCriteriaJSON As String

        Public Property colFldUpdateDate() As Nullable(Of DateTime) Implements IrowTblGridFavorite.colFldUpdateDate
            Get
                Return m_colFldUpdateDate
            End Get
            Set
                If Not Same(m_colFldUpdateDate, Value) Then
                    m_colFldUpdateDate = Value
                    m_IsDirty(FieldIndex.colFldUpdateDate) = True
                End If
            End Set
        End Property
        Private m_colFldUpdateDate As Nullable(Of DateTime)


        Public Function IsDirty(pIndex As rowTblGridFavorite.FieldIndex) As Boolean Implements IrowTblGridFavorite.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblGridFavorite.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblGridFavorite.SetIsDirty
            m_IsDirty(FieldIndex.colId) = pDirty
            m_IsDirty(FieldIndex.colFldTitle) = pDirty
            m_IsDirty(FieldIndex.colFldFilePrefix) = pDirty
            m_IsDirty(FieldIndex.colFldGridId) = pDirty
            m_IsDirty(FieldIndex.colFldEzyUserId) = pDirty
            m_IsDirty(FieldIndex.colFldPractice) = pDirty
            m_IsDirty(FieldIndex.colFldCurrencyId) = pDirty
            m_IsDirty(FieldIndex.colFldUnitId) = pDirty
            m_IsDirty(FieldIndex.colFldColumnOrderJSON) = pDirty
            m_IsDirty(FieldIndex.colFldSortJSON) = pDirty
            m_IsDirty(FieldIndex.colFldFilterJSON) = pDirty
            m_IsDirty(FieldIndex.colFldCriteriaJSON) = pDirty
            m_IsDirty(FieldIndex.colFldUpdateDate) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblGridFavorite) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblGridFavorite
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colId  = 1
            colFldTitle 
            colFldFilePrefix 
            colFldGridId 
            colFldEzyUserId 
            colFldPractice 
            colFldCurrencyId 
            colFldUnitId 
            colFldColumnOrderJSON 
            colFldSortJSON 
            colFldFilterJSON 
            colFldCriteriaJSON 
            colFldUpdateDate 
        End Enum

        Private m_IsDirty(14) As Boolean

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

    Public Interface IrowTblGridFavorite
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colId() As Nullable(Of Integer)
        Property colFldTitle() As String
        Property colFldFilePrefix() As String
        Property colFldGridId() As Nullable(Of Integer)
        Property colFldEzyUserId() As Nullable(Of Integer)
        Property colFldPractice() As String
        Property colFldCurrencyId() As Nullable(Of Integer)
        Property colFldUnitId() As Nullable(Of Integer)
        Property colFldColumnOrderJSON() As String
        Property colFldSortJSON() As String
        Property colFldFilterJSON() As String
        Property colFldCriteriaJSON() As String
        Property colFldUpdateDate() As Nullable(Of DateTime)
        Function IsDirty(pIndex As rowTblGridFavorite.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

