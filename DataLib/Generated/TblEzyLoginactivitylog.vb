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
    Partial Public Class TblEzyLoginactivitylog

        Public Shared Sub Delete(ByRef pRowData As IrowTblEzyLoginactivitylog)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblEzyLoginactivitylog, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblEzyLoginactivitylog, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblEzyLoginactivitylog, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[ezy_LoginActivityLog] " & _
                        "WHERE [ID] = @colId"

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
        Dim zObj As rowTblEzyLoginactivitylog = LoadByPrimaryKey(pcolId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblEzyLoginactivitylog)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblEzyLoginactivitylog, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblEzyLoginactivitylog, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[ezy_LoginActivityLog] WHERE [ID] = @colId"

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
                        zUpdate = "UPDATE [dbo].[ezy_LoginActivityLog] SET " 
                        If pRowData.IsDirty(rowTblEzyLoginactivitylog.FieldIndex.colLoginID) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [LoginID] = @colLoginID "
                        End If
                        If pRowData.IsDirty(rowTblEzyLoginactivitylog.FieldIndex.colLastLoginDateTime) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [LastLoginDateTime] = @colLastLoginDateTime "
                        End If
                        If pRowData.IsDirty(rowTblEzyLoginactivitylog.FieldIndex.colLastActivityDateTime) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [LastActivityDateTime] = @colLastActivityDateTime "
                        End If
                        If pRowData.IsDirty(rowTblEzyLoginactivitylog.FieldIndex.colFilePrefix) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [FilePrefix] = @colFilePrefix "
                        End If
                        If pRowData.IsDirty(rowTblEzyLoginactivitylog.FieldIndex.colUserLogout) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [UserLogout] = @colUserLogout "
                        End If
                        zWhere = " WHERE [ID] = @colId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[ezy_LoginActivityLog] ([LoginID], [LastLoginDateTime], [LastActivityDateTime], [FilePrefix], [UserLogout])" & _
                            " VALUES (@colLoginID, @colLastLoginDateTime, @colLastActivityDateTime, @colFilePrefix, @colUserLogout); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[ezy_LoginActivityLog] ([LoginID], [LastLoginDateTime], [LastActivityDateTime], [FilePrefix], [UserLogout])" & _
                            " VALUES (@colLoginID, @colLastLoginDateTime, @colLastActivityDateTime, @colFilePrefix, @colUserLogout); SELECT SCOPE_IDENTITY()"
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

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyLoginactivitylog.FieldIndex.colLoginID) Then
                    zCmd.Parameters.Add(New SqlParameter("@colLoginID", IIf(pRowData.colLoginID Is Nothing, DBNull.Value, pRowData.colLoginID)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyLoginactivitylog.FieldIndex.colLastLoginDateTime) Then
                    zCmd.Parameters.Add(New SqlParameter("@colLastLoginDateTime", IIf(pRowData.colLastLoginDateTime Is Nothing, DBNull.Value, pRowData.colLastLoginDateTime)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyLoginactivitylog.FieldIndex.colLastActivityDateTime) Then
                    zCmd.Parameters.Add(New SqlParameter("@colLastActivityDateTime", IIf(pRowData.colLastActivityDateTime Is Nothing, DBNull.Value, pRowData.colLastActivityDateTime)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyLoginactivitylog.FieldIndex.colFilePrefix) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFilePrefix", IIf(pRowData.colFilePrefix Is Nothing, DBNull.Value, pRowData.colFilePrefix)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyLoginactivitylog.FieldIndex.colUserLogout) Then
                    zCmd.Parameters.Add(New SqlParameter("@colUserLogout", IIf(pRowData.colUserLogout Is Nothing, DBNull.Value, pRowData.colUserLogout)))
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

        Public Shared Function LoadByPrimaryKey(pcolId As Integer) As rowTblEzyLoginactivitylog
            Return LoadByPrimaryKey(pcolId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolId As Integer, pLoadEventUserState As Object) As rowTblEzyLoginactivitylog
            Return LoadByPrimaryKey(pcolId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblEzyLoginactivitylog
            Return LoadByPrimaryKey(pcolId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblEzyLoginactivitylog
            Dim zReturn As New rowTblEzyLoginactivitylog
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_LoginActivityLog] WHERE [ID] = @colId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colId", pcolId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblEzyLoginactivitylog) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_IX_LoginActivityLog_LoginID(pcolLoginID As Integer) As List(Of rowTblEzyLoginactivitylog)
            Return LoadByIDX_IX_LoginActivityLog_LoginID(pcolLoginID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_LoginActivityLog_LoginID(pcolLoginID As Integer, pLoadEventUserState As Object) As List(Of rowTblEzyLoginactivitylog)
            Return LoadByIDX_IX_LoginActivityLog_LoginID(pcolLoginID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_LoginActivityLog_LoginID(pcolLoginID As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblEzyLoginactivitylog)
            Return LoadByIDX_IX_LoginActivityLog_LoginID(pcolLoginID, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_LoginActivityLog_LoginID(pcolLoginID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblEzyLoginactivitylog)
            Dim zReturn As New List(Of rowTblEzyLoginactivitylog)
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_LoginActivityLog] WHERE [LoginID] = @colLoginID"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colLoginID", pcolLoginID))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function
        Public Shared Function LoadByIDX_PK__ezy_Logi__3214EC2778222049(pcolId As Integer) As List(Of rowTblEzyLoginactivitylog)
            Return LoadByIDX_PK__ezy_Logi__3214EC2778222049(pcolId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__ezy_Logi__3214EC2778222049(pcolId As Integer, pLoadEventUserState As Object) As List(Of rowTblEzyLoginactivitylog)
            Return LoadByIDX_PK__ezy_Logi__3214EC2778222049(pcolId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__ezy_Logi__3214EC2778222049(pcolId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblEzyLoginactivitylog)
            Return LoadByIDX_PK__ezy_Logi__3214EC2778222049(pcolId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__ezy_Logi__3214EC2778222049(pcolId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblEzyLoginactivitylog)
            Dim zReturn As New List(Of rowTblEzyLoginactivitylog)
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_LoginActivityLog] WHERE [ID] = @colId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colId", pcolId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblEzyLoginactivitylog)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblEzyLoginactivitylog)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblEzyLoginactivitylog)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblEzyLoginactivitylog)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblEzyLoginactivitylog)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblEzyLoginactivitylog)
            Dim zReturn As New List(Of rowTblEzyLoginactivitylog)
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_LoginActivityLog]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblEzyLoginactivitylog)

			Try
	            Dim zReturn As New List(Of rowTblEzyLoginactivitylog)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblEzyLoginactivitylog

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblEzyLoginactivitylog		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblEzyLoginactivitylog)
			If Not pReader.IsDBNull(pReader.GetOrdinal("ID")) Then pObject.colId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "ID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LoginID")) Then pObject.colLoginID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "LoginID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LastLoginDateTime")) Then pObject.colLastLoginDateTime = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "LastLoginDateTime")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LastActivityDateTime")) Then pObject.colLastActivityDateTime = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "LastActivityDateTime")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FilePrefix")) Then pObject.colFilePrefix = UtilSQLServer.SafeReader.SafeReadString(pReader, "FilePrefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("UserLogout")) Then pObject.colUserLogout = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "UserLogout")
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
            If Not TypeOf zReturn Is rowTblEzyLoginactivitylog Then Throw New ArgumentException("Generic type is not type of rowTblEzyLoginactivitylog.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_LoginActivityLog] WHERE [ID] = @colId"
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

        Public Shared Function LoadByIDX_IX_LoginActivityLog_LoginID(Of T)(pcolLoginID As Integer) As List(Of T)
            Return LoadByIDX_IX_LoginActivityLog_LoginID(Of T)(pcolLoginID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_LoginActivityLog_LoginID(Of T)(pcolLoginID As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_IX_LoginActivityLog_LoginID(Of T)(pcolLoginID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_LoginActivityLog_LoginID(Of T)(pcolLoginID As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_IX_LoginActivityLog_LoginID(Of T)(pcolLoginID, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_IX_LoginActivityLog_LoginID(Of T)(pcolLoginID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_LoginActivityLog] WHERE [LoginID] = @colLoginID"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colLoginID", pcolLoginID))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_PK__ezy_Logi__3214EC2778222049(Of T)(pcolId As Integer) As List(Of T)
            Return LoadByIDX_PK__ezy_Logi__3214EC2778222049(Of T)(pcolId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__ezy_Logi__3214EC2778222049(Of T)(pcolId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK__ezy_Logi__3214EC2778222049(Of T)(pcolId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__ezy_Logi__3214EC2778222049(Of T)(pcolId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK__ezy_Logi__3214EC2778222049(Of T)(pcolId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK__ezy_Logi__3214EC2778222049(Of T)(pcolId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_LoginActivityLog] WHERE [ID] = @colId"
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
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_LoginActivityLog]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblEzyLoginactivitylog
        Implements IrowTblEzyLoginactivitylog

        Public Event Loaded(pUserState As Object) Implements IrowTblEzyLoginactivitylog.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblEzyLoginactivitylog.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblEzyLoginactivitylog.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblEzyLoginactivitylog.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblEzyLoginactivitylog.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblEzyLoginactivitylog.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colId() As Nullable(Of Integer) Implements IrowTblEzyLoginactivitylog.colId
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

        Public Property colLoginID() As Nullable(Of Integer) Implements IrowTblEzyLoginactivitylog.colLoginID
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

        Public Property colLastLoginDateTime() As Nullable(Of DateTime) Implements IrowTblEzyLoginactivitylog.colLastLoginDateTime
            Get
                Return m_colLastLoginDateTime
            End Get
            Set
                If Not Same(m_colLastLoginDateTime, Value) Then
                    m_colLastLoginDateTime = Value
                    m_IsDirty(FieldIndex.colLastLoginDateTime) = True
                End If
            End Set
        End Property
        Private m_colLastLoginDateTime As Nullable(Of DateTime)

        Public Property colLastActivityDateTime() As Nullable(Of DateTime) Implements IrowTblEzyLoginactivitylog.colLastActivityDateTime
            Get
                Return m_colLastActivityDateTime
            End Get
            Set
                If Not Same(m_colLastActivityDateTime, Value) Then
                    m_colLastActivityDateTime = Value
                    m_IsDirty(FieldIndex.colLastActivityDateTime) = True
                End If
            End Set
        End Property
        Private m_colLastActivityDateTime As Nullable(Of DateTime)

        Public Property colFilePrefix() As String Implements IrowTblEzyLoginactivitylog.colFilePrefix
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

        Public Property colUserLogout() As Nullable(Of Boolean) Implements IrowTblEzyLoginactivitylog.colUserLogout
            Get
                Return m_colUserLogout
            End Get
            Set
                If Not Same(m_colUserLogout, Value) Then
                    m_colUserLogout = Value
                    m_IsDirty(FieldIndex.colUserLogout) = True
                End If
            End Set
        End Property
        Private m_colUserLogout As Nullable(Of Boolean)


        Public Function IsDirty(pIndex As rowTblEzyLoginactivitylog.FieldIndex) As Boolean Implements IrowTblEzyLoginactivitylog.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblEzyLoginactivitylog.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblEzyLoginactivitylog.SetIsDirty
            m_IsDirty(FieldIndex.colId) = pDirty
            m_IsDirty(FieldIndex.colLoginID) = pDirty
            m_IsDirty(FieldIndex.colLastLoginDateTime) = pDirty
            m_IsDirty(FieldIndex.colLastActivityDateTime) = pDirty
            m_IsDirty(FieldIndex.colFilePrefix) = pDirty
            m_IsDirty(FieldIndex.colUserLogout) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblEzyLoginactivitylog) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblEzyLoginactivitylog
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colId  = 1
            colLoginID 
            colLastLoginDateTime 
            colLastActivityDateTime 
            colFilePrefix 
            colUserLogout 
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

    Public Interface IrowTblEzyLoginactivitylog
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colId() As Nullable(Of Integer)
        Property colLoginID() As Nullable(Of Integer)
        Property colLastLoginDateTime() As Nullable(Of DateTime)
        Property colLastActivityDateTime() As Nullable(Of DateTime)
        Property colFilePrefix() As String
        Property colUserLogout() As Nullable(Of Boolean)
        Function IsDirty(pIndex As rowTblEzyLoginactivitylog.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

