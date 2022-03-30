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
    Partial Public Class TblMetaSourceValueColor

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaSourceValueColor)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaSourceValueColor, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaSourceValueColor, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaSourceValueColor, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[tblMetaSourceValueColor] " & _
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
        Dim zObj As rowTblMetaSourceValueColor = LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblMetaSourceValueColor)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaSourceValueColor, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaSourceValueColor, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[tblMetaSourceValueColor] WHERE [fldId] = @colFldId"

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
                        zUpdate = "UPDATE [dbo].[tblMetaSourceValueColor] SET " 
                        If pRowData.IsDirty(rowTblMetaSourceValueColor.FieldIndex.colFldSourceId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldSourceId] = @colFldSourceId "
                        End If
                        If pRowData.IsDirty(rowTblMetaSourceValueColor.FieldIndex.colFldFieldContext) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldFieldContext] = @colFldFieldContext "
                        End If
                        If pRowData.IsDirty(rowTblMetaSourceValueColor.FieldIndex.colFldValue) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldValue] = @colFldValue "
                        End If
                        If pRowData.IsDirty(rowTblMetaSourceValueColor.FieldIndex.colFldColorId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldColorId] = @colFldColorId "
                        End If
                        zWhere = " WHERE [fldId] = @colFldId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaSourceValueColor] ([fldSourceId], [fldFieldContext], [fldValue], [fldColorId])" & _
                            " VALUES (@colFldSourceId, @colFldFieldContext, @colFldValue, @colFldColorId); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaSourceValueColor] ([fldSourceId], [fldFieldContext], [fldValue], [fldColorId])" & _
                            " VALUES (@colFldSourceId, @colFldFieldContext, @colFldValue, @colFldColorId); SELECT SCOPE_IDENTITY()"
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

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaSourceValueColor.FieldIndex.colFldSourceId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldSourceId", IIf(pRowData.colFldSourceId Is Nothing, DBNull.Value, pRowData.colFldSourceId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaSourceValueColor.FieldIndex.colFldFieldContext) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldFieldContext", IIf(pRowData.colFldFieldContext Is Nothing, DBNull.Value, pRowData.colFldFieldContext)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaSourceValueColor.FieldIndex.colFldValue) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldValue", IIf(pRowData.colFldValue Is Nothing, DBNull.Value, pRowData.colFldValue)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaSourceValueColor.FieldIndex.colFldColorId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldColorId", IIf(pRowData.colFldColorId Is Nothing, DBNull.Value, pRowData.colFldColorId)))
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

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer) As rowTblMetaSourceValueColor
            Return LoadByPrimaryKey(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pLoadEventUserState As Object) As rowTblMetaSourceValueColor
            Return LoadByPrimaryKey(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblMetaSourceValueColor
            Return LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblMetaSourceValueColor
            Dim zReturn As New rowTblMetaSourceValueColor
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaSourceValueColor] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblMetaSourceValueColor) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK__tblMetaS__36326BE35C1A1321(pcolFldId As Integer) As List(Of rowTblMetaSourceValueColor)
            Return LoadByIDX_PK__tblMetaS__36326BE35C1A1321(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaS__36326BE35C1A1321(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of rowTblMetaSourceValueColor)
            Return LoadByIDX_PK__tblMetaS__36326BE35C1A1321(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaS__36326BE35C1A1321(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaSourceValueColor)
            Return LoadByIDX_PK__tblMetaS__36326BE35C1A1321(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaS__36326BE35C1A1321(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaSourceValueColor)
            Dim zReturn As New List(Of rowTblMetaSourceValueColor)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaSourceValueColor] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblMetaSourceValueColor)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblMetaSourceValueColor)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblMetaSourceValueColor)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaSourceValueColor)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaSourceValueColor)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaSourceValueColor)
            Dim zReturn As New List(Of rowTblMetaSourceValueColor)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaSourceValueColor]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblMetaSourceValueColor)

			Try
	            Dim zReturn As New List(Of rowTblMetaSourceValueColor)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblMetaSourceValueColor

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblMetaSourceValueColor		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblMetaSourceValueColor)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldId")) Then pObject.colFldId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSourceId")) Then pObject.colFldSourceId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldSourceId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFieldContext")) Then pObject.colFldFieldContext = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldFieldContext")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldValue")) Then pObject.colFldValue = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldValue")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldColorId")) Then pObject.colFldColorId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldColorId")
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
            If Not TypeOf zReturn Is rowTblMetaSourceValueColor Then Throw New ArgumentException("Generic type is not type of rowTblMetaSourceValueColor.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaSourceValueColor] WHERE [fldId] = @colFldId"
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

        Public Shared Function LoadByIDX_PK__tblMetaS__36326BE35C1A1321(Of T)(pcolFldId As Integer) As List(Of T)
            Return LoadByIDX_PK__tblMetaS__36326BE35C1A1321(Of T)(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaS__36326BE35C1A1321(Of T)(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK__tblMetaS__36326BE35C1A1321(Of T)(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaS__36326BE35C1A1321(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK__tblMetaS__36326BE35C1A1321(Of T)(pcolFldId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK__tblMetaS__36326BE35C1A1321(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaSourceValueColor] WHERE [fldId] = @colFldId"
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
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaSourceValueColor]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblMetaSourceValueColor
        Implements IrowTblMetaSourceValueColor

        Public Event Loaded(pUserState As Object) Implements IrowTblMetaSourceValueColor.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblMetaSourceValueColor.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblMetaSourceValueColor.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblMetaSourceValueColor.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblMetaSourceValueColor.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblMetaSourceValueColor.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldId() As Nullable(Of Integer) Implements IrowTblMetaSourceValueColor.colFldId
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

        Public Property colFldSourceId() As Nullable(Of Integer) Implements IrowTblMetaSourceValueColor.colFldSourceId
            Get
                Return m_colFldSourceId
            End Get
            Set
                If Not Same(m_colFldSourceId, Value) Then
                    m_colFldSourceId = Value
                    m_IsDirty(FieldIndex.colFldSourceId) = True
                End If
            End Set
        End Property
        Private m_colFldSourceId As Nullable(Of Integer)

        Public Property colFldFieldContext() As String Implements IrowTblMetaSourceValueColor.colFldFieldContext
            Get
                Return m_colFldFieldContext
            End Get
            Set
                If Not Same(m_colFldFieldContext, Value) Then
                    m_colFldFieldContext = Value
                    m_IsDirty(FieldIndex.colFldFieldContext) = True
                End If
            End Set
        End Property
        Private m_colFldFieldContext As String

        Public Property colFldValue() As String Implements IrowTblMetaSourceValueColor.colFldValue
            Get
                Return m_colFldValue
            End Get
            Set
                If Not Same(m_colFldValue, Value) Then
                    m_colFldValue = Value
                    m_IsDirty(FieldIndex.colFldValue) = True
                End If
            End Set
        End Property
        Private m_colFldValue As String

        Public Property colFldColorId() As Nullable(Of Integer) Implements IrowTblMetaSourceValueColor.colFldColorId
            Get
                Return m_colFldColorId
            End Get
            Set
                If Not Same(m_colFldColorId, Value) Then
                    m_colFldColorId = Value
                    m_IsDirty(FieldIndex.colFldColorId) = True
                End If
            End Set
        End Property
        Private m_colFldColorId As Nullable(Of Integer)


        Public Function IsDirty(pIndex As rowTblMetaSourceValueColor.FieldIndex) As Boolean Implements IrowTblMetaSourceValueColor.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblMetaSourceValueColor.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblMetaSourceValueColor.SetIsDirty
            m_IsDirty(FieldIndex.colFldId) = pDirty
            m_IsDirty(FieldIndex.colFldSourceId) = pDirty
            m_IsDirty(FieldIndex.colFldFieldContext) = pDirty
            m_IsDirty(FieldIndex.colFldValue) = pDirty
            m_IsDirty(FieldIndex.colFldColorId) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblMetaSourceValueColor) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblMetaSourceValueColor
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldId  = 1
            colFldSourceId 
            colFldFieldContext 
            colFldValue 
            colFldColorId 
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

    Public Interface IrowTblMetaSourceValueColor
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldId() As Nullable(Of Integer)
        Property colFldSourceId() As Nullable(Of Integer)
        Property colFldFieldContext() As String
        Property colFldValue() As String
        Property colFldColorId() As Nullable(Of Integer)
        Function IsDirty(pIndex As rowTblMetaSourceValueColor.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace
