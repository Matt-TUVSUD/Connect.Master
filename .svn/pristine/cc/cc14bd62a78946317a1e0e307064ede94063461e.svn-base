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
    Partial Public Class TblClientsroguefile

        Public Shared Sub Delete(ByRef pRowData As IrowTblClientsroguefile)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblClientsroguefile, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblClientsroguefile, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblClientsroguefile, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colRogueFileId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[clientsroguefile] " & _
                        "WHERE [RogueFileId] = @colRogueFileId"

                Dim zCmd As New SQLCommand
                zCmd.CommandText = zSQL
                zCmd.Parameters.Add(New SQLParameter("@colRogueFileId", pRowData.colRogueFileId))

                zCmd.Transaction=pTransaction
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)

                pRowData.RaiseDeletedEvent(pDeleteEventUserState)

            End If

        End Sub

        Public Shared Sub Delete(pcolRogueFileId As Integer)
            Delete(pcolRogueFileId, Nothing, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolRogueFileId As Integer, pDeleteEventUserState As Object)
            Delete(pcolRogueFileId, Nothing, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Delete(pcolRogueFileId As Integer, ByRef pTransaction As SqlClient.SqlTransaction)
        Delete(pcolRogueFileId, pTransaction, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolRogueFileId As Integer, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
        Dim zObj As rowTblClientsroguefile = LoadByPrimaryKey(pcolRogueFileId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblClientsroguefile)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblClientsroguefile, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblClientsroguefile, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colRogueFileId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[clientsroguefile] WHERE [RogueFileId] = @colRogueFileId"

                Dim zCmdDoesExist As New SQLCommand

                zCmdDoesExist.CommandText = zSQL

                zCmdDoesExist.Parameters.Add(new SQLParameter("@colRogueFileId", pRowData.colRogueFileId))

                'if zExistInDB > 0  then  PK exists in the DB
                zCmdDoesExist.Transaction = pTransaction
                zExistInDB = razor.UtilSQLServer.ExecuteScalar(zCmdDoesExist)
            End If

            If razor.UtilSQLServer.IsKeySet(pRowData.colRogueFileId) And zExistInDB > 0 Then
                zMode = "UPDATE"
            End If
            If razor.UtilSQLServer.IsKeySet(pRowData.colRogueFileId) And zExistInDB = 0 Then
                zMode = "INSERTwithKey"
            End If
            If Not razor.UtilSQLServer.IsKeySet(pRowData.colRogueFileId) Then
                zMode = "INSERTnoKey"
            End If

            Select Case zMode
                Case "UPDATE"
                    If pRowData.IsDirty Then
                        Dim zUpdate As String = ""
                        Dim zSet As String = ""
                        Dim zWhere As String = ""
                        zUpdate = "UPDATE [dbo].[clientsroguefile] SET " 
                        If pRowData.IsDirty(rowTblClientsroguefile.FieldIndex.colFilePathName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [FilePathName] = @colFilePathName "
                        End If
                        If pRowData.IsDirty(rowTblClientsroguefile.FieldIndex.colFoundInFilePrefix) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [FoundInFilePrefix] = @colFoundInFilePrefix "
                        End If
                        If pRowData.IsDirty(rowTblClientsroguefile.FieldIndex.colFoundInCldbName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [FoundInCldbName] = @colFoundInCldbName "
                        End If
                        If pRowData.IsDirty(rowTblClientsroguefile.FieldIndex.colFoundOnDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [FoundOnDate] = @colFoundOnDate "
                        End If
                        If pRowData.IsDirty(rowTblClientsroguefile.FieldIndex.colComments) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [Comments] = @colComments "
                        End If
                        zWhere = " WHERE [RogueFileId] = @colRogueFileId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[clientsroguefile] ([FilePathName], [FoundInFilePrefix], [FoundInCldbName], [FoundOnDate], [Comments])" & _
                            " VALUES (@colFilePathName, @colFoundInFilePrefix, @colFoundInCldbName, @colFoundOnDate, @colComments); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[clientsroguefile] ([FilePathName], [FoundInFilePrefix], [FoundInCldbName], [FoundOnDate], [Comments])" & _
                            " VALUES (@colFilePathName, @colFoundInFilePrefix, @colFoundInCldbName, @colFoundOnDate, @colComments); SELECT SCOPE_IDENTITY()"
                Case Else
            End Select

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

			'IF UPDATE, SET PK PARAMETER
            If zMode = "UPDATE" Then
                zCmd.Parameters.Add(New SQLParameter("@colRogueFileId", pRowData.colRogueFileId))
            End If

			'IF INSERTING, KEY HAS VALUE AND KEY IS NOT IDENTITY, SET PK PARAMETER
			If zMode = "INSERTwithKey" Then
            End If

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClientsroguefile.FieldIndex.colFilePathName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFilePathName", IIf(pRowData.colFilePathName Is Nothing, DBNull.Value, pRowData.colFilePathName)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClientsroguefile.FieldIndex.colFoundInFilePrefix) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFoundInFilePrefix", IIf(pRowData.colFoundInFilePrefix Is Nothing, DBNull.Value, pRowData.colFoundInFilePrefix)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClientsroguefile.FieldIndex.colFoundInCldbName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFoundInCldbName", IIf(pRowData.colFoundInCldbName Is Nothing, DBNull.Value, pRowData.colFoundInCldbName)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClientsroguefile.FieldIndex.colFoundOnDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFoundOnDate", IIf(pRowData.colFoundOnDate Is Nothing, DBNull.Value, pRowData.colFoundOnDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClientsroguefile.FieldIndex.colComments) Then
                    zCmd.Parameters.Add(New SqlParameter("@colComments", IIf(pRowData.colComments Is Nothing, DBNull.Value, pRowData.colComments)))
                End If

            zCmd.Transaction=pTransaction
            If zMode = "INSERTnoKey" Then
                Dim zLastId As Long = 0
                zLastId = razor.UtilSQLServer.ExecuteNonQueryRowId(zCmd)

                pRowData.colRogueFileId = zLastId
            Else
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)
            End If

            pRowData.SetIsDirty(False)
            pRowData.RaiseSavedEvent(pSavedEventUserState)

		End If

        End Sub

        Public Shared Function LoadByPrimaryKey(pcolRogueFileId As Integer) As rowTblClientsroguefile
            Return LoadByPrimaryKey(pcolRogueFileId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolRogueFileId As Integer, pLoadEventUserState As Object) As rowTblClientsroguefile
            Return LoadByPrimaryKey(pcolRogueFileId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolRogueFileId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblClientsroguefile
            Return LoadByPrimaryKey(pcolRogueFileId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolRogueFileId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblClientsroguefile
            Dim zReturn As New rowTblClientsroguefile
            Dim zSQL As String = "SELECT * FROM [dbo].[clientsroguefile] WHERE [RogueFileId] = @colRogueFileId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colRogueFileId", pcolRogueFileId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblClientsroguefile) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK_clientsroguefiles(pcolRogueFileId As Integer) As List(Of rowTblClientsroguefile)
            Return LoadByIDX_PK_clientsroguefiles(pcolRogueFileId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_clientsroguefiles(pcolRogueFileId As Integer, pLoadEventUserState As Object) As List(Of rowTblClientsroguefile)
            Return LoadByIDX_PK_clientsroguefiles(pcolRogueFileId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_clientsroguefiles(pcolRogueFileId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblClientsroguefile)
            Return LoadByIDX_PK_clientsroguefiles(pcolRogueFileId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_clientsroguefiles(pcolRogueFileId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblClientsroguefile)
            Dim zReturn As New List(Of rowTblClientsroguefile)
            Dim zSQL As String = "SELECT * FROM [dbo].[clientsroguefile] WHERE [RogueFileId] = @colRogueFileId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colRogueFileId", pcolRogueFileId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblClientsroguefile)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblClientsroguefile)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblClientsroguefile)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblClientsroguefile)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblClientsroguefile)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblClientsroguefile)
            Dim zReturn As New List(Of rowTblClientsroguefile)
            Dim zSQL As String = "SELECT * FROM [dbo].[clientsroguefile]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblClientsroguefile)

			Try
	            Dim zReturn As New List(Of rowTblClientsroguefile)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblClientsroguefile

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblClientsroguefile		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblClientsroguefile)
			If Not pReader.IsDBNull(pReader.GetOrdinal("RogueFileId")) Then pObject.colRogueFileId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "RogueFileId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FilePathName")) Then pObject.colFilePathName = UtilSQLServer.SafeReader.SafeReadString(pReader, "FilePathName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FoundInFilePrefix")) Then pObject.colFoundInFilePrefix = UtilSQLServer.SafeReader.SafeReadString(pReader, "FoundInFilePrefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FoundInCldbName")) Then pObject.colFoundInCldbName = UtilSQLServer.SafeReader.SafeReadString(pReader, "FoundInCldbName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FoundOnDate")) Then pObject.colFoundOnDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "FoundOnDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Comments")) Then pObject.colComments = UtilSQLServer.SafeReader.SafeReadString(pReader, "Comments")
			pObject.SetIsDirty(False)
			Return pObject
		End	 Function

    #Region "Reflection Based Load Functions"

        Public Shared Function LoadByPrimaryKey(Of T)(pcolRogueFileId As Integer) As T
            Return LoadByPrimaryKey(Of T)(pcolRogueFileId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolRogueFileId As Integer, pLoadEventUserState As Object) As T
            Return LoadByPrimaryKey(Of T)(pcolRogueFileId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolRogueFileId As Integer, pTransaction As SqlClient.SqlTransaction) As T
            Return LoadByPrimaryKey(Of T)(pcolRogueFileId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolRogueFileId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As T

            Dim zReturn As Object = Activator.CreateInstance(Of T)()
            If Not TypeOf zReturn Is rowTblClientsroguefile Then Throw New ArgumentException("Generic type is not type of rowTblClientsroguefile.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[clientsroguefile] WHERE [RogueFileId] = @colRogueFileId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colRogueFileId", pcolRogueFileId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of T) = ReadData(Of T)(zCmd, pLoadEventUserState)
            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

        End Function

        Public Shared Function LoadByIDX_PK_clientsroguefiles(Of T)(pcolRogueFileId As Integer) As List(Of T)
            Return LoadByIDX_PK_clientsroguefiles(Of T)(pcolRogueFileId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_clientsroguefiles(Of T)(pcolRogueFileId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK_clientsroguefiles(Of T)(pcolRogueFileId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_clientsroguefiles(Of T)(pcolRogueFileId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK_clientsroguefiles(Of T)(pcolRogueFileId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK_clientsroguefiles(Of T)(pcolRogueFileId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[clientsroguefile] WHERE [RogueFileId] = @colRogueFileId"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colRogueFileId", pcolRogueFileId))

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
            Dim zSQL As String = "SELECT * FROM [dbo].[clientsroguefile]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblClientsroguefile
        Implements IrowTblClientsroguefile

        Public Event Loaded(pUserState As Object) Implements IrowTblClientsroguefile.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblClientsroguefile.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblClientsroguefile.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblClientsroguefile.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblClientsroguefile.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblClientsroguefile.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colRogueFileId() As Nullable(Of Integer) Implements IrowTblClientsroguefile.colRogueFileId
            Get
                Return m_colRogueFileId
            End Get
            Set
                If Not Same(m_colRogueFileId, Value) Then
                    m_colRogueFileId = Value
                    m_IsDirty(FieldIndex.colRogueFileId) = True
                End If
            End Set
        End Property
        Private m_colRogueFileId As Nullable(Of Integer)

        Public Property colFilePathName() As String Implements IrowTblClientsroguefile.colFilePathName
            Get
                Return m_colFilePathName
            End Get
            Set
                If Not Same(m_colFilePathName, Value) Then
                    m_colFilePathName = Value
                    m_IsDirty(FieldIndex.colFilePathName) = True
                End If
            End Set
        End Property
        Private m_colFilePathName As String

        Public Property colFoundInFilePrefix() As String Implements IrowTblClientsroguefile.colFoundInFilePrefix
            Get
                Return m_colFoundInFilePrefix
            End Get
            Set
                If Not Same(m_colFoundInFilePrefix, Value) Then
                    m_colFoundInFilePrefix = Value
                    m_IsDirty(FieldIndex.colFoundInFilePrefix) = True
                End If
            End Set
        End Property
        Private m_colFoundInFilePrefix As String

        Public Property colFoundInCldbName() As String Implements IrowTblClientsroguefile.colFoundInCldbName
            Get
                Return m_colFoundInCldbName
            End Get
            Set
                If Not Same(m_colFoundInCldbName, Value) Then
                    m_colFoundInCldbName = Value
                    m_IsDirty(FieldIndex.colFoundInCldbName) = True
                End If
            End Set
        End Property
        Private m_colFoundInCldbName As String

        Public Property colFoundOnDate() As Nullable(Of DateTime) Implements IrowTblClientsroguefile.colFoundOnDate
            Get
                Return m_colFoundOnDate
            End Get
            Set
                If Not Same(m_colFoundOnDate, Value) Then
                    m_colFoundOnDate = Value
                    m_IsDirty(FieldIndex.colFoundOnDate) = True
                End If
            End Set
        End Property
        Private m_colFoundOnDate As Nullable(Of DateTime)

        Public Property colComments() As String Implements IrowTblClientsroguefile.colComments
            Get
                Return m_colComments
            End Get
            Set
                If Not Same(m_colComments, Value) Then
                    m_colComments = Value
                    m_IsDirty(FieldIndex.colComments) = True
                End If
            End Set
        End Property
        Private m_colComments As String


        Public Function IsDirty(pIndex As rowTblClientsroguefile.FieldIndex) As Boolean Implements IrowTblClientsroguefile.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblClientsroguefile.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblClientsroguefile.SetIsDirty
            m_IsDirty(FieldIndex.colRogueFileId) = pDirty
            m_IsDirty(FieldIndex.colFilePathName) = pDirty
            m_IsDirty(FieldIndex.colFoundInFilePrefix) = pDirty
            m_IsDirty(FieldIndex.colFoundInCldbName) = pDirty
            m_IsDirty(FieldIndex.colFoundOnDate) = pDirty
            m_IsDirty(FieldIndex.colComments) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblClientsroguefile) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblClientsroguefile
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colRogueFileId  = 1
            colFilePathName 
            colFoundInFilePrefix 
            colFoundInCldbName 
            colFoundOnDate 
            colComments 
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

    Public Interface IrowTblClientsroguefile
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colRogueFileId() As Nullable(Of Integer)
        Property colFilePathName() As String
        Property colFoundInFilePrefix() As String
        Property colFoundInCldbName() As String
        Property colFoundOnDate() As Nullable(Of DateTime)
        Property colComments() As String
        Function IsDirty(pIndex As rowTblClientsroguefile.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

