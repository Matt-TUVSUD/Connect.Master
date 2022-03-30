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
    Partial Public Class TblMetaParameter

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaParameter)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaParameter, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaParameter, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaParameter, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[tblMetaParameter] " & _
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
        Dim zObj As rowTblMetaParameter = LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblMetaParameter)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaParameter, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaParameter, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[tblMetaParameter] WHERE [fldId] = @colFldId"

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
                        zUpdate = "UPDATE [dbo].[tblMetaParameter] SET " 
                        If pRowData.IsDirty(rowTblMetaParameter.FieldIndex.colFldName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldName] = @colFldName "
                        End If
                        If pRowData.IsDirty(rowTblMetaParameter.FieldIndex.colFldType) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldType] = @colFldType "
                        End If
                        If pRowData.IsDirty(rowTblMetaParameter.FieldIndex.colFldAllowWildcardValue) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldAllowWildcardValue] = @colFldAllowWildcardValue "
                        End If
                        If pRowData.IsDirty(rowTblMetaParameter.FieldIndex.colFldParameterKindId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldParameterKindId] = @colFldParameterKindId "
                        End If
                        If pRowData.IsDirty(rowTblMetaParameter.FieldIndex.colFldFieldName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldFieldName] = @colFldFieldName "
                        End If
                        If pRowData.IsDirty(rowTblMetaParameter.FieldIndex.colFldFlagId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldFlagId] = @colFldFlagId "
                        End If
                        If pRowData.IsDirty(rowTblMetaParameter.FieldIndex.colFldIsVirtual) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldIsVirtual] = @colFldIsVirtual "
                        End If
                        zWhere = " WHERE [fldId] = @colFldId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaParameter] ([fldName], [fldType], [fldAllowWildcardValue], [fldParameterKindId], [fldFieldName], [fldFlagId], [fldIsVirtual])" & _
                            " VALUES (@colFldName, @colFldType, @colFldAllowWildcardValue, @colFldParameterKindId, @colFldFieldName, @colFldFlagId, @colFldIsVirtual); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaParameter] ([fldName], [fldType], [fldAllowWildcardValue], [fldParameterKindId], [fldFieldName], [fldFlagId], [fldIsVirtual])" & _
                            " VALUES (@colFldName, @colFldType, @colFldAllowWildcardValue, @colFldParameterKindId, @colFldFieldName, @colFldFlagId, @colFldIsVirtual); SELECT SCOPE_IDENTITY()"
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

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaParameter.FieldIndex.colFldName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldName", IIf(pRowData.colFldName Is Nothing, DBNull.Value, pRowData.colFldName)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaParameter.FieldIndex.colFldType) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldType", IIf(pRowData.colFldType Is Nothing, DBNull.Value, pRowData.colFldType)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaParameter.FieldIndex.colFldAllowWildcardValue) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldAllowWildcardValue", IIf(pRowData.colFldAllowWildcardValue Is Nothing, DBNull.Value, pRowData.colFldAllowWildcardValue)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaParameter.FieldIndex.colFldParameterKindId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldParameterKindId", IIf(pRowData.colFldParameterKindId Is Nothing, DBNull.Value, pRowData.colFldParameterKindId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaParameter.FieldIndex.colFldFieldName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldFieldName", IIf(pRowData.colFldFieldName Is Nothing, DBNull.Value, pRowData.colFldFieldName)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaParameter.FieldIndex.colFldFlagId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldFlagId", IIf(pRowData.colFldFlagId Is Nothing, DBNull.Value, pRowData.colFldFlagId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaParameter.FieldIndex.colFldIsVirtual) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldIsVirtual", IIf(pRowData.colFldIsVirtual Is Nothing, DBNull.Value, pRowData.colFldIsVirtual)))
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

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer) As rowTblMetaParameter
            Return LoadByPrimaryKey(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pLoadEventUserState As Object) As rowTblMetaParameter
            Return LoadByPrimaryKey(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblMetaParameter
            Return LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblMetaParameter
            Dim zReturn As New rowTblMetaParameter
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaParameter] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblMetaParameter) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK__tblMetaP__3213E83F05F0515C(pcolFldId As Integer) As List(Of rowTblMetaParameter)
            Return LoadByIDX_PK__tblMetaP__3213E83F05F0515C(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaP__3213E83F05F0515C(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of rowTblMetaParameter)
            Return LoadByIDX_PK__tblMetaP__3213E83F05F0515C(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaP__3213E83F05F0515C(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaParameter)
            Return LoadByIDX_PK__tblMetaP__3213E83F05F0515C(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaP__3213E83F05F0515C(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaParameter)
            Dim zReturn As New List(Of rowTblMetaParameter)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaParameter] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblMetaParameter)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblMetaParameter)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblMetaParameter)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaParameter)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaParameter)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaParameter)
            Dim zReturn As New List(Of rowTblMetaParameter)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaParameter]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblMetaParameter)

			Try
	            Dim zReturn As New List(Of rowTblMetaParameter)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblMetaParameter

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblMetaParameter		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblMetaParameter)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldId")) Then pObject.colFldId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldName")) Then pObject.colFldName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldType")) Then pObject.colFldType = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldType")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldAllowWildcardValue")) Then pObject.colFldAllowWildcardValue = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldAllowWildcardValue")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldParameterKindId")) Then pObject.colFldParameterKindId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldParameterKindId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFieldName")) Then pObject.colFldFieldName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldFieldName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFlagId")) Then pObject.colFldFlagId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldFlagId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldIsVirtual")) Then pObject.colFldIsVirtual = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldIsVirtual")
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
            If Not TypeOf zReturn Is rowTblMetaParameter Then Throw New ArgumentException("Generic type is not type of rowTblMetaParameter.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaParameter] WHERE [fldId] = @colFldId"
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

        Public Shared Function LoadByIDX_PK__tblMetaP__3213E83F05F0515C(Of T)(pcolFldId As Integer) As List(Of T)
            Return LoadByIDX_PK__tblMetaP__3213E83F05F0515C(Of T)(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaP__3213E83F05F0515C(Of T)(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK__tblMetaP__3213E83F05F0515C(Of T)(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaP__3213E83F05F0515C(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK__tblMetaP__3213E83F05F0515C(Of T)(pcolFldId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK__tblMetaP__3213E83F05F0515C(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaParameter] WHERE [fldId] = @colFldId"
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
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaParameter]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblMetaParameter
        Implements IrowTblMetaParameter

        Public Event Loaded(pUserState As Object) Implements IrowTblMetaParameter.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblMetaParameter.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblMetaParameter.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblMetaParameter.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblMetaParameter.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblMetaParameter.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldId() As Nullable(Of Integer) Implements IrowTblMetaParameter.colFldId
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

        Public Property colFldName() As String Implements IrowTblMetaParameter.colFldName
            Get
                Return m_colFldName
            End Get
            Set
                If Not Same(m_colFldName, Value) Then
                    m_colFldName = Value
                    m_IsDirty(FieldIndex.colFldName) = True
                End If
            End Set
        End Property
        Private m_colFldName As String

        Public Property colFldType() As String Implements IrowTblMetaParameter.colFldType
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
        Private m_colFldType As String

        Public Property colFldAllowWildcardValue() As Nullable(Of Boolean) Implements IrowTblMetaParameter.colFldAllowWildcardValue
            Get
                Return m_colFldAllowWildcardValue
            End Get
            Set
                If Not Same(m_colFldAllowWildcardValue, Value) Then
                    m_colFldAllowWildcardValue = Value
                    m_IsDirty(FieldIndex.colFldAllowWildcardValue) = True
                End If
            End Set
        End Property
        Private m_colFldAllowWildcardValue As Nullable(Of Boolean)

        Public Property colFldParameterKindId() As Nullable(Of Integer) Implements IrowTblMetaParameter.colFldParameterKindId
            Get
                Return m_colFldParameterKindId
            End Get
            Set
                If Not Same(m_colFldParameterKindId, Value) Then
                    m_colFldParameterKindId = Value
                    m_IsDirty(FieldIndex.colFldParameterKindId) = True
                End If
            End Set
        End Property
        Private m_colFldParameterKindId As Nullable(Of Integer)

        Public Property colFldFieldName() As String Implements IrowTblMetaParameter.colFldFieldName
            Get
                Return m_colFldFieldName
            End Get
            Set
                If Not Same(m_colFldFieldName, Value) Then
                    m_colFldFieldName = Value
                    m_IsDirty(FieldIndex.colFldFieldName) = True
                End If
            End Set
        End Property
        Private m_colFldFieldName As String

        Public Property colFldFlagId() As Nullable(Of Integer) Implements IrowTblMetaParameter.colFldFlagId
            Get
                Return m_colFldFlagId
            End Get
            Set
                If Not Same(m_colFldFlagId, Value) Then
                    m_colFldFlagId = Value
                    m_IsDirty(FieldIndex.colFldFlagId) = True
                End If
            End Set
        End Property
        Private m_colFldFlagId As Nullable(Of Integer)

        Public Property colFldIsVirtual() As Nullable(Of Boolean) Implements IrowTblMetaParameter.colFldIsVirtual
            Get
                Return m_colFldIsVirtual
            End Get
            Set
                If Not Same(m_colFldIsVirtual, Value) Then
                    m_colFldIsVirtual = Value
                    m_IsDirty(FieldIndex.colFldIsVirtual) = True
                End If
            End Set
        End Property
        Private m_colFldIsVirtual As Nullable(Of Boolean)


        Public Function IsDirty(pIndex As rowTblMetaParameter.FieldIndex) As Boolean Implements IrowTblMetaParameter.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblMetaParameter.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblMetaParameter.SetIsDirty
            m_IsDirty(FieldIndex.colFldId) = pDirty
            m_IsDirty(FieldIndex.colFldName) = pDirty
            m_IsDirty(FieldIndex.colFldType) = pDirty
            m_IsDirty(FieldIndex.colFldAllowWildcardValue) = pDirty
            m_IsDirty(FieldIndex.colFldParameterKindId) = pDirty
            m_IsDirty(FieldIndex.colFldFieldName) = pDirty
            m_IsDirty(FieldIndex.colFldFlagId) = pDirty
            m_IsDirty(FieldIndex.colFldIsVirtual) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblMetaParameter) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblMetaParameter
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldId  = 1
            colFldName 
            colFldType 
            colFldAllowWildcardValue 
            colFldParameterKindId 
            colFldFieldName 
            colFldFlagId 
            colFldIsVirtual 
        End Enum

        Private m_IsDirty(8) As Boolean

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

    Public Interface IrowTblMetaParameter
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldId() As Nullable(Of Integer)
        Property colFldName() As String
        Property colFldType() As String
        Property colFldAllowWildcardValue() As Nullable(Of Boolean)
        Property colFldParameterKindId() As Nullable(Of Integer)
        Property colFldFieldName() As String
        Property colFldFlagId() As Nullable(Of Integer)
        Property colFldIsVirtual() As Nullable(Of Boolean)
        Function IsDirty(pIndex As rowTblMetaParameter.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

