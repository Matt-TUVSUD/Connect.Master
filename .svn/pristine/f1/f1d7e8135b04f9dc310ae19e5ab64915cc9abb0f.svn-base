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
    Partial Public Class TblSystemAppEntry

        Public Shared Sub Delete(ByRef pRowData As IrowTblSystemAppEntry)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblSystemAppEntry, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblSystemAppEntry, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblSystemAppEntry, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldID) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[tblSystemAppEntry] " & _
                        "WHERE [fldID] = @colFldID"

                Dim zCmd As New SQLCommand
                zCmd.CommandText = zSQL
                zCmd.Parameters.Add(New SQLParameter("@colFldID", pRowData.colFldID))

                zCmd.Transaction=pTransaction
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)

                pRowData.RaiseDeletedEvent(pDeleteEventUserState)

            End If

        End Sub

        Public Shared Sub Delete(pcolFldID As Integer)
            Delete(pcolFldID, Nothing, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolFldID As Integer, pDeleteEventUserState As Object)
            Delete(pcolFldID, Nothing, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Delete(pcolFldID As Integer, ByRef pTransaction As SqlClient.SqlTransaction)
        Delete(pcolFldID, pTransaction, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolFldID As Integer, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
        Dim zObj As rowTblSystemAppEntry = LoadByPrimaryKey(pcolFldID, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblSystemAppEntry)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblSystemAppEntry, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblSystemAppEntry, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldID) Then

                zSQL = "SELECT COUNT(*) from [dbo].[tblSystemAppEntry] WHERE [fldID] = @colFldID"

                Dim zCmdDoesExist As New SQLCommand

                zCmdDoesExist.CommandText = zSQL

                zCmdDoesExist.Parameters.Add(new SQLParameter("@colFldID", pRowData.colFldID))

                'if zExistInDB > 0  then  PK exists in the DB
                zCmdDoesExist.Transaction = pTransaction
                zExistInDB = razor.UtilSQLServer.ExecuteScalar(zCmdDoesExist)
            End If

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldID) And zExistInDB > 0 Then
                zMode = "UPDATE"
            End If
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldID) And zExistInDB = 0 Then
                zMode = "INSERTwithKey"
            End If
            If Not razor.UtilSQLServer.IsKeySet(pRowData.colFldID) Then
                zMode = "INSERTnoKey"
            End If

            Select Case zMode
                Case "UPDATE"
                    If pRowData.IsDirty Then
                        Dim zUpdate As String = ""
                        Dim zSet As String = ""
                        Dim zWhere As String = ""
                        zUpdate = "UPDATE [dbo].[tblSystemAppEntry] SET " 
                        If pRowData.IsDirty(rowTblSystemAppEntry.FieldIndex.colFldGuid) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldGuid] = @colFldGuid "
                        End If
                        If pRowData.IsDirty(rowTblSystemAppEntry.FieldIndex.colFldUserName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldUserName] = @colFldUserName "
                        End If
                        If pRowData.IsDirty(rowTblSystemAppEntry.FieldIndex.colFldUserEmail) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldUserEmail] = @colFldUserEmail "
                        End If
                        If pRowData.IsDirty(rowTblSystemAppEntry.FieldIndex.colFldEntrySource) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldEntrySource] = @colFldEntrySource "
                        End If
                        If pRowData.IsDirty(rowTblSystemAppEntry.FieldIndex.colFldEntryDateTime) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldEntryDateTime] = @colFldEntryDateTime "
                        End If
                        If pRowData.IsDirty(rowTblSystemAppEntry.FieldIndex.colFldForeignKeyID) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldForeignKeyID] = @colFldForeignKeyID "
                        End If
                        If pRowData.IsDirty(rowTblSystemAppEntry.FieldIndex.colFldForeignTableName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldForeignTableName] = @colFldForeignTableName "
                        End If
                        zWhere = " WHERE [fldID] = @colFldID"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[tblSystemAppEntry] ([fldGuid], [fldUserName], [fldUserEmail], [fldEntrySource], [fldEntryDateTime], [fldForeignKeyID], [fldForeignTableName])" & _
                            " VALUES (@colFldGuid, @colFldUserName, @colFldUserEmail, @colFldEntrySource, @colFldEntryDateTime, @colFldForeignKeyID, @colFldForeignTableName); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[tblSystemAppEntry] ([fldGuid], [fldUserName], [fldUserEmail], [fldEntrySource], [fldEntryDateTime], [fldForeignKeyID], [fldForeignTableName])" & _
                            " VALUES (@colFldGuid, @colFldUserName, @colFldUserEmail, @colFldEntrySource, @colFldEntryDateTime, @colFldForeignKeyID, @colFldForeignTableName); SELECT SCOPE_IDENTITY()"
                Case Else
            End Select

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

			'IF UPDATE, SET PK PARAMETER
            If zMode = "UPDATE" Then
                zCmd.Parameters.Add(New SQLParameter("@colFldID", pRowData.colFldID))
            End If

			'IF INSERTING, KEY HAS VALUE AND KEY IS NOT IDENTITY, SET PK PARAMETER
			If zMode = "INSERTwithKey" Then
            End If

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblSystemAppEntry.FieldIndex.colFldGuid) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldGuid", IIf(pRowData.colFldGuid Is Nothing, DBNull.Value, pRowData.colFldGuid)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblSystemAppEntry.FieldIndex.colFldUserName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldUserName", IIf(pRowData.colFldUserName Is Nothing, DBNull.Value, pRowData.colFldUserName)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblSystemAppEntry.FieldIndex.colFldUserEmail) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldUserEmail", IIf(pRowData.colFldUserEmail Is Nothing, DBNull.Value, pRowData.colFldUserEmail)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblSystemAppEntry.FieldIndex.colFldEntrySource) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldEntrySource", IIf(pRowData.colFldEntrySource Is Nothing, DBNull.Value, pRowData.colFldEntrySource)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblSystemAppEntry.FieldIndex.colFldEntryDateTime) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldEntryDateTime", IIf(pRowData.colFldEntryDateTime Is Nothing, DBNull.Value, pRowData.colFldEntryDateTime)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblSystemAppEntry.FieldIndex.colFldForeignKeyID) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldForeignKeyID", IIf(pRowData.colFldForeignKeyID Is Nothing, DBNull.Value, pRowData.colFldForeignKeyID)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblSystemAppEntry.FieldIndex.colFldForeignTableName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldForeignTableName", IIf(pRowData.colFldForeignTableName Is Nothing, DBNull.Value, pRowData.colFldForeignTableName)))
                End If

            zCmd.Transaction=pTransaction
            If zMode = "INSERTnoKey" Then
                Dim zLastId As Long = 0
                zLastId = razor.UtilSQLServer.ExecuteNonQueryRowId(zCmd)

                pRowData.colFldID = zLastId
            Else
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)
            End If

            pRowData.SetIsDirty(False)
            pRowData.RaiseSavedEvent(pSavedEventUserState)

		End If

        End Sub

        Public Shared Function LoadByPrimaryKey(pcolFldID As Integer) As rowTblSystemAppEntry
            Return LoadByPrimaryKey(pcolFldID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldID As Integer, pLoadEventUserState As Object) As rowTblSystemAppEntry
            Return LoadByPrimaryKey(pcolFldID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblSystemAppEntry
            Return LoadByPrimaryKey(pcolFldID, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblSystemAppEntry
            Dim zReturn As New rowTblSystemAppEntry
            Dim zSQL As String = "SELECT * FROM [dbo].[tblSystemAppEntry] WHERE [fldID] = @colFldID"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldID", pcolFldID))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblSystemAppEntry) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK__tblSyste__36326BC3CAA2A406(pcolFldID As Integer) As List(Of rowTblSystemAppEntry)
            Return LoadByIDX_PK__tblSyste__36326BC3CAA2A406(pcolFldID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblSyste__36326BC3CAA2A406(pcolFldID As Integer, pLoadEventUserState As Object) As List(Of rowTblSystemAppEntry)
            Return LoadByIDX_PK__tblSyste__36326BC3CAA2A406(pcolFldID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblSyste__36326BC3CAA2A406(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblSystemAppEntry)
            Return LoadByIDX_PK__tblSyste__36326BC3CAA2A406(pcolFldID, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblSyste__36326BC3CAA2A406(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblSystemAppEntry)
            Dim zReturn As New List(Of rowTblSystemAppEntry)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblSystemAppEntry] WHERE [fldID] = @colFldID"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldID", pcolFldID))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblSystemAppEntry)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblSystemAppEntry)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblSystemAppEntry)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblSystemAppEntry)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblSystemAppEntry)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblSystemAppEntry)
            Dim zReturn As New List(Of rowTblSystemAppEntry)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblSystemAppEntry]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblSystemAppEntry)

			Try
	            Dim zReturn As New List(Of rowTblSystemAppEntry)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblSystemAppEntry

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblSystemAppEntry		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblSystemAppEntry)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldID")) Then pObject.colFldID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldGuid")) Then pObject.colFldGuid = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldGuid")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldUserName")) Then pObject.colFldUserName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldUserName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldUserEmail")) Then pObject.colFldUserEmail = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldUserEmail")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldEntrySource")) Then pObject.colFldEntrySource = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldEntrySource")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldEntryDateTime")) Then pObject.colFldEntryDateTime = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldEntryDateTime")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldForeignKeyID")) Then pObject.colFldForeignKeyID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldForeignKeyID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldForeignTableName")) Then pObject.colFldForeignTableName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldForeignTableName")
			pObject.SetIsDirty(False)
			Return pObject
		End	 Function

    #Region "Reflection Based Load Functions"

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldID As Integer) As T
            Return LoadByPrimaryKey(Of T)(pcolFldID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldID As Integer, pLoadEventUserState As Object) As T
            Return LoadByPrimaryKey(Of T)(pcolFldID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction) As T
            Return LoadByPrimaryKey(Of T)(pcolFldID, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As T

            Dim zReturn As Object = Activator.CreateInstance(Of T)()
            If Not TypeOf zReturn Is rowTblSystemAppEntry Then Throw New ArgumentException("Generic type is not type of rowTblSystemAppEntry.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[tblSystemAppEntry] WHERE [fldID] = @colFldID"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldID", pcolFldID))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of T) = ReadData(Of T)(zCmd, pLoadEventUserState)
            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

        End Function

        Public Shared Function LoadByIDX_PK__tblSyste__36326BC3CAA2A406(Of T)(pcolFldID As Integer) As List(Of T)
            Return LoadByIDX_PK__tblSyste__36326BC3CAA2A406(Of T)(pcolFldID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblSyste__36326BC3CAA2A406(Of T)(pcolFldID As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK__tblSyste__36326BC3CAA2A406(Of T)(pcolFldID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblSyste__36326BC3CAA2A406(Of T)(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK__tblSyste__36326BC3CAA2A406(Of T)(pcolFldID, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK__tblSyste__36326BC3CAA2A406(Of T)(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblSystemAppEntry] WHERE [fldID] = @colFldID"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldID", pcolFldID))

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
            Dim zSQL As String = "SELECT * FROM [dbo].[tblSystemAppEntry]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblSystemAppEntry
        Implements IrowTblSystemAppEntry

        Public Event Loaded(pUserState As Object) Implements IrowTblSystemAppEntry.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblSystemAppEntry.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblSystemAppEntry.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblSystemAppEntry.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblSystemAppEntry.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblSystemAppEntry.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldID() As Nullable(Of Integer) Implements IrowTblSystemAppEntry.colFldID
            Get
                Return m_colFldID
            End Get
            Set
                If Not Same(m_colFldID, Value) Then
                    m_colFldID = Value
                    m_IsDirty(FieldIndex.colFldID) = True
                End If
            End Set
        End Property
        Private m_colFldID As Nullable(Of Integer)

        Public Property colFldGuid() As String Implements IrowTblSystemAppEntry.colFldGuid
            Get
                Return m_colFldGuid
            End Get
            Set
                If Not Same(m_colFldGuid, Value) Then
                    m_colFldGuid = Value
                    m_IsDirty(FieldIndex.colFldGuid) = True
                End If
            End Set
        End Property
        Private m_colFldGuid As String

        Public Property colFldUserName() As String Implements IrowTblSystemAppEntry.colFldUserName
            Get
                Return m_colFldUserName
            End Get
            Set
                If Not Same(m_colFldUserName, Value) Then
                    m_colFldUserName = Value
                    m_IsDirty(FieldIndex.colFldUserName) = True
                End If
            End Set
        End Property
        Private m_colFldUserName As String

        Public Property colFldUserEmail() As String Implements IrowTblSystemAppEntry.colFldUserEmail
            Get
                Return m_colFldUserEmail
            End Get
            Set
                If Not Same(m_colFldUserEmail, Value) Then
                    m_colFldUserEmail = Value
                    m_IsDirty(FieldIndex.colFldUserEmail) = True
                End If
            End Set
        End Property
        Private m_colFldUserEmail As String

        Public Property colFldEntrySource() As String Implements IrowTblSystemAppEntry.colFldEntrySource
            Get
                Return m_colFldEntrySource
            End Get
            Set
                If Not Same(m_colFldEntrySource, Value) Then
                    m_colFldEntrySource = Value
                    m_IsDirty(FieldIndex.colFldEntrySource) = True
                End If
            End Set
        End Property
        Private m_colFldEntrySource As String

        Public Property colFldEntryDateTime() As String Implements IrowTblSystemAppEntry.colFldEntryDateTime
            Get
                Return m_colFldEntryDateTime
            End Get
            Set
                If Not Same(m_colFldEntryDateTime, Value) Then
                    m_colFldEntryDateTime = Value
                    m_IsDirty(FieldIndex.colFldEntryDateTime) = True
                End If
            End Set
        End Property
        Private m_colFldEntryDateTime As String

        Public Property colFldForeignKeyID() As Nullable(Of Integer) Implements IrowTblSystemAppEntry.colFldForeignKeyID
            Get
                Return m_colFldForeignKeyID
            End Get
            Set
                If Not Same(m_colFldForeignKeyID, Value) Then
                    m_colFldForeignKeyID = Value
                    m_IsDirty(FieldIndex.colFldForeignKeyID) = True
                End If
            End Set
        End Property
        Private m_colFldForeignKeyID As Nullable(Of Integer)

        Public Property colFldForeignTableName() As String Implements IrowTblSystemAppEntry.colFldForeignTableName
            Get
                Return m_colFldForeignTableName
            End Get
            Set
                If Not Same(m_colFldForeignTableName, Value) Then
                    m_colFldForeignTableName = Value
                    m_IsDirty(FieldIndex.colFldForeignTableName) = True
                End If
            End Set
        End Property
        Private m_colFldForeignTableName As String


        Public Function IsDirty(pIndex As rowTblSystemAppEntry.FieldIndex) As Boolean Implements IrowTblSystemAppEntry.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblSystemAppEntry.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblSystemAppEntry.SetIsDirty
            m_IsDirty(FieldIndex.colFldID) = pDirty
            m_IsDirty(FieldIndex.colFldGuid) = pDirty
            m_IsDirty(FieldIndex.colFldUserName) = pDirty
            m_IsDirty(FieldIndex.colFldUserEmail) = pDirty
            m_IsDirty(FieldIndex.colFldEntrySource) = pDirty
            m_IsDirty(FieldIndex.colFldEntryDateTime) = pDirty
            m_IsDirty(FieldIndex.colFldForeignKeyID) = pDirty
            m_IsDirty(FieldIndex.colFldForeignTableName) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblSystemAppEntry) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblSystemAppEntry
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldID  = 1
            colFldGuid 
            colFldUserName 
            colFldUserEmail 
            colFldEntrySource 
            colFldEntryDateTime 
            colFldForeignKeyID 
            colFldForeignTableName 
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

    Public Interface IrowTblSystemAppEntry
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldID() As Nullable(Of Integer)
        Property colFldGuid() As String
        Property colFldUserName() As String
        Property colFldUserEmail() As String
        Property colFldEntrySource() As String
        Property colFldEntryDateTime() As String
        Property colFldForeignKeyID() As Nullable(Of Integer)
        Property colFldForeignTableName() As String
        Function IsDirty(pIndex As rowTblSystemAppEntry.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

