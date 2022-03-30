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
    Partial Public Class TblMetaSQL

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaSQL)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaSQL, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaSQL, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaSQL, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[tblMetaSQL] " & _
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
        Dim zObj As rowTblMetaSQL = LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblMetaSQL)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaSQL, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaSQL, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[tblMetaSQL] WHERE [fldId] = @colFldId"

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
                        zUpdate = "UPDATE [dbo].[tblMetaSQL] SET " 
                        If pRowData.IsDirty(rowTblMetaSQL.FieldIndex.colFldSql) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldSql] = @colFldSql "
                        End If
                        If pRowData.IsDirty(rowTblMetaSQL.FieldIndex.colFldCreatedate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldCreatedate] = @colFldCreatedate "
                        End If
                        If pRowData.IsDirty(rowTblMetaSQL.FieldIndex.colFldDataKey) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldDataKey] = @colFldDataKey "
                        End If
                        If pRowData.IsDirty(rowTblMetaSQL.FieldIndex.colFldForeignKey) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldForeignKey] = @colFldForeignKey "
                        End If
                        If pRowData.IsDirty(rowTblMetaSQL.FieldIndex.colFldBatchKey) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldBatchKey] = @colFldBatchKey "
                        End If
                        If pRowData.IsDirty(rowTblMetaSQL.FieldIndex.colFldDebugInfo) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldDebugInfo] = @colFldDebugInfo "
                        End If
                        zWhere = " WHERE [fldId] = @colFldId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaSQL] ([fldSql], [fldCreatedate], [fldDataKey], [fldForeignKey], [fldBatchKey], [fldDebugInfo])" & _
                            " VALUES (@colFldSql, @colFldCreatedate, @colFldDataKey, @colFldForeignKey, @colFldBatchKey, @colFldDebugInfo); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaSQL] ([fldSql], [fldCreatedate], [fldDataKey], [fldForeignKey], [fldBatchKey], [fldDebugInfo])" & _
                            " VALUES (@colFldSql, @colFldCreatedate, @colFldDataKey, @colFldForeignKey, @colFldBatchKey, @colFldDebugInfo); SELECT SCOPE_IDENTITY()"
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

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaSQL.FieldIndex.colFldSql) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldSql", IIf(pRowData.colFldSql Is Nothing, DBNull.Value, pRowData.colFldSql)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaSQL.FieldIndex.colFldCreatedate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldCreatedate", IIf(pRowData.colFldCreatedate Is Nothing, DBNull.Value, pRowData.colFldCreatedate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaSQL.FieldIndex.colFldDataKey) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldDataKey", IIf(pRowData.colFldDataKey Is Nothing, DBNull.Value, pRowData.colFldDataKey)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaSQL.FieldIndex.colFldForeignKey) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldForeignKey", IIf(pRowData.colFldForeignKey Is Nothing, DBNull.Value, pRowData.colFldForeignKey)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaSQL.FieldIndex.colFldBatchKey) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldBatchKey", IIf(pRowData.colFldBatchKey Is Nothing, DBNull.Value, pRowData.colFldBatchKey)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaSQL.FieldIndex.colFldDebugInfo) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldDebugInfo", IIf(pRowData.colFldDebugInfo Is Nothing, DBNull.Value, pRowData.colFldDebugInfo)))
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

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer) As rowTblMetaSQL
            Return LoadByPrimaryKey(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pLoadEventUserState As Object) As rowTblMetaSQL
            Return LoadByPrimaryKey(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblMetaSQL
            Return LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblMetaSQL
            Dim zReturn As New rowTblMetaSQL
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaSQL] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblMetaSQL) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK__tblSQLMa__3213E83F3D759070(pcolFldId As Integer) As List(Of rowTblMetaSQL)
            Return LoadByIDX_PK__tblSQLMa__3213E83F3D759070(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblSQLMa__3213E83F3D759070(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of rowTblMetaSQL)
            Return LoadByIDX_PK__tblSQLMa__3213E83F3D759070(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblSQLMa__3213E83F3D759070(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaSQL)
            Return LoadByIDX_PK__tblSQLMa__3213E83F3D759070(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblSQLMa__3213E83F3D759070(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaSQL)
            Dim zReturn As New List(Of rowTblMetaSQL)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaSQL] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblMetaSQL)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblMetaSQL)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblMetaSQL)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaSQL)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaSQL)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaSQL)
            Dim zReturn As New List(Of rowTblMetaSQL)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaSQL]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblMetaSQL)

			Try
	            Dim zReturn As New List(Of rowTblMetaSQL)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblMetaSQL

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblMetaSQL		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblMetaSQL)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldId")) Then pObject.colFldId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSql")) Then pObject.colFldSql = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldSql")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldCreatedate")) Then pObject.colFldCreatedate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "fldCreatedate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldDataKey")) Then pObject.colFldDataKey = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldDataKey")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldForeignKey")) Then pObject.colFldForeignKey = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldForeignKey")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldBatchKey")) Then pObject.colFldBatchKey = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldBatchKey")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldDebugInfo")) Then pObject.colFldDebugInfo = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldDebugInfo")
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
            If Not TypeOf zReturn Is rowTblMetaSQL Then Throw New ArgumentException("Generic type is not type of rowTblMetaSQL.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaSQL] WHERE [fldId] = @colFldId"
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

        Public Shared Function LoadByIDX_PK__tblSQLMa__3213E83F3D759070(Of T)(pcolFldId As Integer) As List(Of T)
            Return LoadByIDX_PK__tblSQLMa__3213E83F3D759070(Of T)(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblSQLMa__3213E83F3D759070(Of T)(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK__tblSQLMa__3213E83F3D759070(Of T)(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblSQLMa__3213E83F3D759070(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK__tblSQLMa__3213E83F3D759070(Of T)(pcolFldId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK__tblSQLMa__3213E83F3D759070(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaSQL] WHERE [fldId] = @colFldId"
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
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaSQL]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblMetaSQL
        Implements IrowTblMetaSQL

        Public Event Loaded(pUserState As Object) Implements IrowTblMetaSQL.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblMetaSQL.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblMetaSQL.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblMetaSQL.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblMetaSQL.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblMetaSQL.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldId() As Nullable(Of Integer) Implements IrowTblMetaSQL.colFldId
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

        Public Property colFldSql() As String Implements IrowTblMetaSQL.colFldSql
            Get
                Return m_colFldSql
            End Get
            Set
                If Not Same(m_colFldSql, Value) Then
                    m_colFldSql = Value
                    m_IsDirty(FieldIndex.colFldSql) = True
                End If
            End Set
        End Property
        Private m_colFldSql As String

        Public Property colFldCreatedate() As Nullable(Of DateTime) Implements IrowTblMetaSQL.colFldCreatedate
            Get
                Return m_colFldCreatedate
            End Get
            Set
                If Not Same(m_colFldCreatedate, Value) Then
                    m_colFldCreatedate = Value
                    m_IsDirty(FieldIndex.colFldCreatedate) = True
                End If
            End Set
        End Property
        Private m_colFldCreatedate As Nullable(Of DateTime)

        Public Property colFldDataKey() As String Implements IrowTblMetaSQL.colFldDataKey
            Get
                Return m_colFldDataKey
            End Get
            Set
                If Not Same(m_colFldDataKey, Value) Then
                    m_colFldDataKey = Value
                    m_IsDirty(FieldIndex.colFldDataKey) = True
                End If
            End Set
        End Property
        Private m_colFldDataKey As String

        Public Property colFldForeignKey() As String Implements IrowTblMetaSQL.colFldForeignKey
            Get
                Return m_colFldForeignKey
            End Get
            Set
                If Not Same(m_colFldForeignKey, Value) Then
                    m_colFldForeignKey = Value
                    m_IsDirty(FieldIndex.colFldForeignKey) = True
                End If
            End Set
        End Property
        Private m_colFldForeignKey As String

        Public Property colFldBatchKey() As String Implements IrowTblMetaSQL.colFldBatchKey
            Get
                Return m_colFldBatchKey
            End Get
            Set
                If Not Same(m_colFldBatchKey, Value) Then
                    m_colFldBatchKey = Value
                    m_IsDirty(FieldIndex.colFldBatchKey) = True
                End If
            End Set
        End Property
        Private m_colFldBatchKey As String

        Public Property colFldDebugInfo() As String Implements IrowTblMetaSQL.colFldDebugInfo
            Get
                Return m_colFldDebugInfo
            End Get
            Set
                If Not Same(m_colFldDebugInfo, Value) Then
                    m_colFldDebugInfo = Value
                    m_IsDirty(FieldIndex.colFldDebugInfo) = True
                End If
            End Set
        End Property
        Private m_colFldDebugInfo As String


        Public Function IsDirty(pIndex As rowTblMetaSQL.FieldIndex) As Boolean Implements IrowTblMetaSQL.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblMetaSQL.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblMetaSQL.SetIsDirty
            m_IsDirty(FieldIndex.colFldId) = pDirty
            m_IsDirty(FieldIndex.colFldSql) = pDirty
            m_IsDirty(FieldIndex.colFldCreatedate) = pDirty
            m_IsDirty(FieldIndex.colFldDataKey) = pDirty
            m_IsDirty(FieldIndex.colFldForeignKey) = pDirty
            m_IsDirty(FieldIndex.colFldBatchKey) = pDirty
            m_IsDirty(FieldIndex.colFldDebugInfo) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblMetaSQL) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblMetaSQL
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldId  = 1
            colFldSql 
            colFldCreatedate 
            colFldDataKey 
            colFldForeignKey 
            colFldBatchKey 
            colFldDebugInfo 
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

    Public Interface IrowTblMetaSQL
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldId() As Nullable(Of Integer)
        Property colFldSql() As String
        Property colFldCreatedate() As Nullable(Of DateTime)
        Property colFldDataKey() As String
        Property colFldForeignKey() As String
        Property colFldBatchKey() As String
        Property colFldDebugInfo() As String
        Function IsDirty(pIndex As rowTblMetaSQL.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

