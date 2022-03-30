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
    Partial Public Class TblGSafePreferences

        Public Shared Sub Delete(ByRef pRowData As IrowTblGSafePreferences)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblGSafePreferences, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblGSafePreferences, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblGSafePreferences, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colGSafeId) And razor.UtilSQLServer.IsKeySet(pRowData.colFilePrefix) And razor.UtilSQLServer.IsKeySet(pRowData.colDataName) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[GSafePreferences] " & _
                        "WHERE [GSafeId] = @colGSafeId AND [FilePrefix] = @colFilePrefix AND [DataName] = @colDataName"

                Dim zCmd As New SQLCommand
                zCmd.CommandText = zSQL
                zCmd.Parameters.Add(New SQLParameter("@colGSafeId", pRowData.colGSafeId))
                zCmd.Parameters.Add(New SQLParameter("@colFilePrefix", pRowData.colFilePrefix))
                zCmd.Parameters.Add(New SQLParameter("@colDataName", pRowData.colDataName))

                zCmd.Transaction=pTransaction
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)

                pRowData.RaiseDeletedEvent(pDeleteEventUserState)

            End If

        End Sub

        Public Shared Sub Delete(pcolGSafeId As Integer, pcolFilePrefix As String, pcolDataName As String)
            Delete(pcolGSafeId, pcolFilePrefix, pcolDataName, Nothing, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolGSafeId As Integer, pcolFilePrefix As String, pcolDataName As String, pDeleteEventUserState As Object)
            Delete(pcolGSafeId, pcolFilePrefix, pcolDataName, Nothing, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Delete(pcolGSafeId As Integer, pcolFilePrefix As String, pcolDataName As String, ByRef pTransaction As SqlClient.SqlTransaction)
        Delete(pcolGSafeId, pcolFilePrefix, pcolDataName, pTransaction, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolGSafeId As Integer, pcolFilePrefix As String, pcolDataName As String, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
        Dim zObj As rowTblGSafePreferences = LoadByPrimaryKey(pcolGSafeId, pcolFilePrefix, pcolDataName, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblGSafePreferences)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblGSafePreferences, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblGSafePreferences, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colGSafeId) And razor.UtilSQLServer.IsKeySet(pRowData.colFilePrefix) And razor.UtilSQLServer.IsKeySet(pRowData.colDataName) Then

                zSQL = "SELECT COUNT(*) from [dbo].[GSafePreferences] WHERE [GSafeId] = @colGSafeId AND [FilePrefix] = @colFilePrefix AND [DataName] = @colDataName"

                Dim zCmdDoesExist As New SQLCommand

                zCmdDoesExist.CommandText = zSQL

                zCmdDoesExist.Parameters.Add(new SQLParameter("@colGSafeId", pRowData.colGSafeId))
                zCmdDoesExist.Parameters.Add(new SQLParameter("@colFilePrefix", pRowData.colFilePrefix))
                zCmdDoesExist.Parameters.Add(new SQLParameter("@colDataName", pRowData.colDataName))

                'if zExistInDB > 0  then  PK exists in the DB
                zCmdDoesExist.Transaction = pTransaction
                zExistInDB = razor.UtilSQLServer.ExecuteScalar(zCmdDoesExist)
            End If

            If razor.UtilSQLServer.IsKeySet(pRowData.colGSafeId) And razor.UtilSQLServer.IsKeySet(pRowData.colFilePrefix) And razor.UtilSQLServer.IsKeySet(pRowData.colDataName) And zExistInDB > 0 Then
                zMode = "UPDATE"
            End If
            If razor.UtilSQLServer.IsKeySet(pRowData.colGSafeId) And razor.UtilSQLServer.IsKeySet(pRowData.colFilePrefix) And razor.UtilSQLServer.IsKeySet(pRowData.colDataName) And zExistInDB = 0 Then
                zMode = "INSERTwithKey"
            End If
            If Not razor.UtilSQLServer.IsKeySet(pRowData.colGSafeId) Or Not razor.UtilSQLServer.IsKeySet(pRowData.colFilePrefix) Or Not razor.UtilSQLServer.IsKeySet(pRowData.colDataName) Then
                zMode = "INSERTnoKey"
            End If

            Select Case zMode
                Case "UPDATE"
                    If pRowData.IsDirty Then
                        Dim zUpdate As String = ""
                        Dim zSet As String = ""
                        Dim zWhere As String = ""
                        zUpdate = "UPDATE [dbo].[GSafePreferences] SET " 
                        If pRowData.IsDirty(rowTblGSafePreferences.FieldIndex.colDataValue) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [DataValue] = @colDataValue "
                        End If
                        If pRowData.IsDirty(rowTblGSafePreferences.FieldIndex.colDataGroup) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [DataGroup] = @colDataGroup "
                        End If
                        zWhere = " WHERE [GSafeId] = @colGSafeId AND [FilePrefix] = @colFilePrefix AND [DataName] = @colDataName"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[GSafePreferences] ([GSafeId], [FilePrefix], [DataName], [DataValue], [DataGroup])" & _
                            " VALUES (@colGSafeId, @colFilePrefix, @colDataName, @colDataValue, @colDataGroup); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[GSafePreferences] ([DataValue], [DataGroup])" & _
                            " VALUES (@colDataValue, @colDataGroup); SELECT SCOPE_IDENTITY()"
                Case Else
            End Select

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

			'IF UPDATE, SET PK PARAMETER
            If zMode = "UPDATE" Then
                zCmd.Parameters.Add(New SQLParameter("@colGSafeId", pRowData.colGSafeId))
                zCmd.Parameters.Add(New SQLParameter("@colFilePrefix", pRowData.colFilePrefix))
                zCmd.Parameters.Add(New SQLParameter("@colDataName", pRowData.colDataName))
            End If

			'IF INSERTING, KEY HAS VALUE AND KEY IS NOT IDENTITY, SET PK PARAMETER
			If zMode = "INSERTwithKey" Then
                zCmd.Parameters.Add(New SQLParameter("@colGSafeId", pRowData.colGSafeId))
                zCmd.Parameters.Add(New SQLParameter("@colFilePrefix", pRowData.colFilePrefix))
                zCmd.Parameters.Add(New SQLParameter("@colDataName", pRowData.colDataName))
            End If

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblGSafePreferences.FieldIndex.colDataValue) Then
                    zCmd.Parameters.Add(New SqlParameter("@colDataValue", IIf(pRowData.colDataValue Is Nothing, DBNull.Value, pRowData.colDataValue)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblGSafePreferences.FieldIndex.colDataGroup) Then
                    zCmd.Parameters.Add(New SqlParameter("@colDataGroup", IIf(pRowData.colDataGroup Is Nothing, DBNull.Value, pRowData.colDataGroup)))
                End If

            zCmd.Transaction=pTransaction
            If zMode = "INSERTnoKey" Then
                Dim zLastId As Long = 0
                zLastId = razor.UtilSQLServer.ExecuteNonQueryRowId(zCmd)

                pRowData.colGSafeId = zLastId
                pRowData.colFilePrefix = zLastId
                pRowData.colDataName = zLastId
            Else
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)
            End If

            pRowData.SetIsDirty(False)
            pRowData.RaiseSavedEvent(pSavedEventUserState)

		End If

        End Sub

        Public Shared Function LoadByPrimaryKey(pcolGSafeId As Integer, pcolFilePrefix As String, pcolDataName As String) As rowTblGSafePreferences
            Return LoadByPrimaryKey(pcolGSafeId, pcolFilePrefix, pcolDataName, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolGSafeId As Integer, pcolFilePrefix As String, pcolDataName As String, pLoadEventUserState As Object) As rowTblGSafePreferences
            Return LoadByPrimaryKey(pcolGSafeId, pcolFilePrefix, pcolDataName, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolGSafeId As Integer, pcolFilePrefix As String, pcolDataName As String, pTransaction As SqlClient.SqlTransaction) As rowTblGSafePreferences
            Return LoadByPrimaryKey(pcolGSafeId, pcolFilePrefix, pcolDataName, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolGSafeId As Integer, pcolFilePrefix As String, pcolDataName As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblGSafePreferences
            Dim zReturn As New rowTblGSafePreferences
            Dim zSQL As String = "SELECT * FROM [dbo].[GSafePreferences] WHERE [GSafeId] = @colGSafeId AND [FilePrefix] = @colFilePrefix AND [DataName] = @colDataName"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colGSafeId", pcolGSafeId))
            zCmd.Parameters.Add(New SQLParameter("@colFilePrefix", pcolFilePrefix))
            zCmd.Parameters.Add(New SQLParameter("@colDataName", pcolDataName))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblGSafePreferences) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK_GSafePreferences(pcolGSafeId As Integer, pcolFilePrefix As String, pcolDataName As String) As List(Of rowTblGSafePreferences)
            Return LoadByIDX_PK_GSafePreferences(pcolGSafeId, pcolFilePrefix, pcolDataName, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_GSafePreferences(pcolGSafeId As Integer, pcolFilePrefix As String, pcolDataName As String, pLoadEventUserState As Object) As List(Of rowTblGSafePreferences)
            Return LoadByIDX_PK_GSafePreferences(pcolGSafeId, pcolFilePrefix, pcolDataName, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_GSafePreferences(pcolGSafeId As Integer, pcolFilePrefix As String, pcolDataName As String, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblGSafePreferences)
            Return LoadByIDX_PK_GSafePreferences(pcolGSafeId, pcolFilePrefix, pcolDataName, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_GSafePreferences(pcolGSafeId As Integer, pcolFilePrefix As String, pcolDataName As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblGSafePreferences)
            Dim zReturn As New List(Of rowTblGSafePreferences)
            Dim zSQL As String = "SELECT * FROM [dbo].[GSafePreferences] WHERE [GSafeId] = @colGSafeId AND [FilePrefix] = @colFilePrefix AND [DataName] = @colDataName"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colGSafeId", pcolGSafeId))
            zCmd.Parameters.Add(New SQLParameter("@colFilePrefix", pcolFilePrefix))
            zCmd.Parameters.Add(New SQLParameter("@colDataName", pcolDataName))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblGSafePreferences)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblGSafePreferences)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblGSafePreferences)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblGSafePreferences)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblGSafePreferences)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblGSafePreferences)
            Dim zReturn As New List(Of rowTblGSafePreferences)
            Dim zSQL As String = "SELECT * FROM [dbo].[GSafePreferences]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblGSafePreferences)

			Try
	            Dim zReturn As New List(Of rowTblGSafePreferences)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblGSafePreferences

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblGSafePreferences		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblGSafePreferences)
			If Not pReader.IsDBNull(pReader.GetOrdinal("GSafeId")) Then pObject.colGSafeId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "GSafeId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FilePrefix")) Then pObject.colFilePrefix = UtilSQLServer.SafeReader.SafeReadString(pReader, "FilePrefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DataName")) Then pObject.colDataName = UtilSQLServer.SafeReader.SafeReadString(pReader, "DataName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DataValue")) Then pObject.colDataValue = UtilSQLServer.SafeReader.SafeReadString(pReader, "DataValue")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DataGroup")) Then pObject.colDataGroup = UtilSQLServer.SafeReader.SafeReadString(pReader, "DataGroup")
			pObject.SetIsDirty(False)
			Return pObject
		End	 Function

    #Region "Reflection Based Load Functions"

        Public Shared Function LoadByPrimaryKey(Of T)(pcolGSafeId As Integer, pcolFilePrefix As String, pcolDataName As String) As T
            Return LoadByPrimaryKey(Of T)(pcolGSafeId, pcolFilePrefix, pcolDataName, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolGSafeId As Integer, pcolFilePrefix As String, pcolDataName As String, pLoadEventUserState As Object) As T
            Return LoadByPrimaryKey(Of T)(pcolGSafeId, pcolFilePrefix, pcolDataName, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolGSafeId As Integer, pcolFilePrefix As String, pcolDataName As String, pTransaction As SqlClient.SqlTransaction) As T
            Return LoadByPrimaryKey(Of T)(pcolGSafeId, pcolFilePrefix, pcolDataName, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolGSafeId As Integer, pcolFilePrefix As String, pcolDataName As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As T

            Dim zReturn As Object = Activator.CreateInstance(Of T)()
            If Not TypeOf zReturn Is rowTblGSafePreferences Then Throw New ArgumentException("Generic type is not type of rowTblGSafePreferences.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[GSafePreferences] WHERE [GSafeId] = @colGSafeId AND [FilePrefix] = @colFilePrefix AND [DataName] = @colDataName"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colGSafeId", pcolGSafeId))
            zCmd.Parameters.Add(New SQLParameter("@colFilePrefix", pcolFilePrefix))
            zCmd.Parameters.Add(New SQLParameter("@colDataName", pcolDataName))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of T) = ReadData(Of T)(zCmd, pLoadEventUserState)
            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

        End Function

        Public Shared Function LoadByIDX_PK_GSafePreferences(Of T)(pcolGSafeId As Integer, pcolFilePrefix As String, pcolDataName As String) As List(Of T)
            Return LoadByIDX_PK_GSafePreferences(Of T)(pcolGSafeId, pcolFilePrefix, pcolDataName, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_GSafePreferences(Of T)(pcolGSafeId As Integer, pcolFilePrefix As String, pcolDataName As String, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK_GSafePreferences(Of T)(pcolGSafeId, pcolFilePrefix, pcolDataName, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_GSafePreferences(Of T)(pcolGSafeId As Integer, pcolFilePrefix As String, pcolDataName As String, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK_GSafePreferences(Of T)(pcolGSafeId, pcolFilePrefix, pcolDataName, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK_GSafePreferences(Of T)(pcolGSafeId As Integer, pcolFilePrefix As String, pcolDataName As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[GSafePreferences] WHERE [GSafeId] = @colGSafeId AND [FilePrefix] = @colFilePrefix AND [DataName] = @colDataName"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colGSafeId", pcolGSafeId))
            zCmd.Parameters.Add(New SQLParameter("@colFilePrefix", pcolFilePrefix))
            zCmd.Parameters.Add(New SQLParameter("@colDataName", pcolDataName))

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
            Dim zSQL As String = "SELECT * FROM [dbo].[GSafePreferences]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblGSafePreferences
        Implements IrowTblGSafePreferences

        Public Event Loaded(pUserState As Object) Implements IrowTblGSafePreferences.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblGSafePreferences.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblGSafePreferences.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblGSafePreferences.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblGSafePreferences.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblGSafePreferences.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colGSafeId() As Nullable(Of Integer) Implements IrowTblGSafePreferences.colGSafeId
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

        Public Property colFilePrefix() As String Implements IrowTblGSafePreferences.colFilePrefix
            Get
                Return m_colFilePrefix
            End Get
            Set
                If Not Same(m_colFilePrefix, Value) Then
                    m_colFilePrefix = Value
                    m_IsDirty(FieldIndex.colFilePrefix) = True
                End If
            End Set
        End Property
        Private m_colFilePrefix As String

        Public Property colDataName() As String Implements IrowTblGSafePreferences.colDataName
            Get
                Return m_colDataName
            End Get
            Set
                If Not Same(m_colDataName, Value) Then
                    m_colDataName = Value
                    m_IsDirty(FieldIndex.colDataName) = True
                End If
            End Set
        End Property
        Private m_colDataName As String

        Public Property colDataValue() As String Implements IrowTblGSafePreferences.colDataValue
            Get
                Return m_colDataValue
            End Get
            Set
                If Not Same(m_colDataValue, Value) Then
                    m_colDataValue = Value
                    m_IsDirty(FieldIndex.colDataValue) = True
                End If
            End Set
        End Property
        Private m_colDataValue As String

        Public Property colDataGroup() As String Implements IrowTblGSafePreferences.colDataGroup
            Get
                Return m_colDataGroup
            End Get
            Set
                If Not Same(m_colDataGroup, Value) Then
                    m_colDataGroup = Value
                    m_IsDirty(FieldIndex.colDataGroup) = True
                End If
            End Set
        End Property
        Private m_colDataGroup As String


        Public Function IsDirty(pIndex As rowTblGSafePreferences.FieldIndex) As Boolean Implements IrowTblGSafePreferences.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblGSafePreferences.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblGSafePreferences.SetIsDirty
            m_IsDirty(FieldIndex.colGSafeId) = pDirty
            m_IsDirty(FieldIndex.colFilePrefix) = pDirty
            m_IsDirty(FieldIndex.colDataName) = pDirty
            m_IsDirty(FieldIndex.colDataValue) = pDirty
            m_IsDirty(FieldIndex.colDataGroup) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblGSafePreferences) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblGSafePreferences
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colGSafeId  = 1
            colFilePrefix 
            colDataName 
            colDataValue 
            colDataGroup 
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

    Public Interface IrowTblGSafePreferences
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colGSafeId() As Nullable(Of Integer)
        Property colFilePrefix() As String
        Property colDataName() As String
        Property colDataValue() As String
        Property colDataGroup() As String
        Function IsDirty(pIndex As rowTblGSafePreferences.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

