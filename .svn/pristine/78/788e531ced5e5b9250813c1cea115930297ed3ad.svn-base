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
    Partial Public Class TblEzyUserstracking

        Public Shared Sub Delete(ByRef pRowData As IrowTblEzyUserstracking)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblEzyUserstracking, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblEzyUserstracking, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblEzyUserstracking, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[ezy_UsersTracking] " & _
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
        Dim zObj As rowTblEzyUserstracking = LoadByPrimaryKey(pcolId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblEzyUserstracking)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblEzyUserstracking, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblEzyUserstracking, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[ezy_UsersTracking] WHERE [ID] = @colId"

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
                        zUpdate = "UPDATE [dbo].[ezy_UsersTracking] SET " 
                        If pRowData.IsDirty(rowTblEzyUserstracking.FieldIndex.colEzyUserID) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [EzyUserID] = @colEzyUserID "
                        End If
                        If pRowData.IsDirty(rowTblEzyUserstracking.FieldIndex.colFilePrefix) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [FilePrefix] = @colFilePrefix "
                        End If
                        If pRowData.IsDirty(rowTblEzyUserstracking.FieldIndex.colDocLibLastReviewedDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [DocLibLastReviewedDate] = @colDocLibLastReviewedDate "
                        End If
                        zWhere = " WHERE [ID] = @colId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[ezy_UsersTracking] ([EzyUserID], [FilePrefix], [DocLibLastReviewedDate])" & _
                            " VALUES (@colEzyUserID, @colFilePrefix, @colDocLibLastReviewedDate); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[ezy_UsersTracking] ([EzyUserID], [FilePrefix], [DocLibLastReviewedDate])" & _
                            " VALUES (@colEzyUserID, @colFilePrefix, @colDocLibLastReviewedDate); SELECT SCOPE_IDENTITY()"
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

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUserstracking.FieldIndex.colEzyUserID) Then
                    zCmd.Parameters.Add(New SqlParameter("@colEzyUserID", IIf(pRowData.colEzyUserID Is Nothing, DBNull.Value, pRowData.colEzyUserID)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUserstracking.FieldIndex.colFilePrefix) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFilePrefix", IIf(pRowData.colFilePrefix Is Nothing, DBNull.Value, pRowData.colFilePrefix)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyUserstracking.FieldIndex.colDocLibLastReviewedDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colDocLibLastReviewedDate", IIf(pRowData.colDocLibLastReviewedDate Is Nothing, DBNull.Value, pRowData.colDocLibLastReviewedDate)))
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

        Public Shared Function LoadByPrimaryKey(pcolId As Integer) As rowTblEzyUserstracking
            Return LoadByPrimaryKey(pcolId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolId As Integer, pLoadEventUserState As Object) As rowTblEzyUserstracking
            Return LoadByPrimaryKey(pcolId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblEzyUserstracking
            Return LoadByPrimaryKey(pcolId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblEzyUserstracking
            Dim zReturn As New rowTblEzyUserstracking
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_UsersTracking] WHERE [ID] = @colId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colId", pcolId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblEzyUserstracking) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK__ezy_User__3214EC2734F6245F(pcolId As Integer) As List(Of rowTblEzyUserstracking)
            Return LoadByIDX_PK__ezy_User__3214EC2734F6245F(pcolId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__ezy_User__3214EC2734F6245F(pcolId As Integer, pLoadEventUserState As Object) As List(Of rowTblEzyUserstracking)
            Return LoadByIDX_PK__ezy_User__3214EC2734F6245F(pcolId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__ezy_User__3214EC2734F6245F(pcolId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblEzyUserstracking)
            Return LoadByIDX_PK__ezy_User__3214EC2734F6245F(pcolId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__ezy_User__3214EC2734F6245F(pcolId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblEzyUserstracking)
            Dim zReturn As New List(Of rowTblEzyUserstracking)
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_UsersTracking] WHERE [ID] = @colId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colId", pcolId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function
        Public Shared Function LoadByIDX_idx_Ezyuserid_FilePrefix(pcolEzyUserID As Integer, pcolFilePrefix As Integer) As List(Of rowTblEzyUserstracking)
            Return LoadByIDX_idx_Ezyuserid_FilePrefix(pcolEzyUserID, pcolFilePrefix, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_idx_Ezyuserid_FilePrefix(pcolEzyUserID As Integer, pcolFilePrefix As Integer, pLoadEventUserState As Object) As List(Of rowTblEzyUserstracking)
            Return LoadByIDX_idx_Ezyuserid_FilePrefix(pcolEzyUserID, pcolFilePrefix, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_idx_Ezyuserid_FilePrefix(pcolEzyUserID As Integer, pcolFilePrefix As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblEzyUserstracking)
            Return LoadByIDX_idx_Ezyuserid_FilePrefix(pcolEzyUserID, pcolFilePrefix, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_idx_Ezyuserid_FilePrefix(pcolEzyUserID As Integer, pcolFilePrefix As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblEzyUserstracking)
            Dim zReturn As New List(Of rowTblEzyUserstracking)
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_UsersTracking] WHERE [EzyUserID] = @colEzyUserID AND [FilePrefix] = @colFilePrefix"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colEzyUserID", pcolEzyUserID))
            zCmd.Parameters.Add(New SQLParameter("@colFilePrefix", pcolFilePrefix))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblEzyUserstracking)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblEzyUserstracking)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblEzyUserstracking)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblEzyUserstracking)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblEzyUserstracking)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblEzyUserstracking)
            Dim zReturn As New List(Of rowTblEzyUserstracking)
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_UsersTracking]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblEzyUserstracking)

			Try
	            Dim zReturn As New List(Of rowTblEzyUserstracking)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblEzyUserstracking

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblEzyUserstracking		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblEzyUserstracking)
			If Not pReader.IsDBNull(pReader.GetOrdinal("ID")) Then pObject.colId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "ID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("EzyUserID")) Then pObject.colEzyUserID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "EzyUserID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FilePrefix")) Then pObject.colFilePrefix = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "FilePrefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DocLibLastReviewedDate")) Then pObject.colDocLibLastReviewedDate = UtilSQLServer.SafeReader.SafeReadDate(pReader, "DocLibLastReviewedDate")
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
            If Not TypeOf zReturn Is rowTblEzyUserstracking Then Throw New ArgumentException("Generic type is not type of rowTblEzyUserstracking.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_UsersTracking] WHERE [ID] = @colId"
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

        Public Shared Function LoadByIDX_PK__ezy_User__3214EC2734F6245F(Of T)(pcolId As Integer) As List(Of T)
            Return LoadByIDX_PK__ezy_User__3214EC2734F6245F(Of T)(pcolId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__ezy_User__3214EC2734F6245F(Of T)(pcolId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK__ezy_User__3214EC2734F6245F(Of T)(pcolId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__ezy_User__3214EC2734F6245F(Of T)(pcolId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK__ezy_User__3214EC2734F6245F(Of T)(pcolId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK__ezy_User__3214EC2734F6245F(Of T)(pcolId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_UsersTracking] WHERE [ID] = @colId"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colId", pcolId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_idx_Ezyuserid_FilePrefix(Of T)(pcolEzyUserID As Integer, pcolFilePrefix As Integer) As List(Of T)
            Return LoadByIDX_idx_Ezyuserid_FilePrefix(Of T)(pcolEzyUserID, pcolFilePrefix, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_idx_Ezyuserid_FilePrefix(Of T)(pcolEzyUserID As Integer, pcolFilePrefix As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_idx_Ezyuserid_FilePrefix(Of T)(pcolEzyUserID, pcolFilePrefix, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_idx_Ezyuserid_FilePrefix(Of T)(pcolEzyUserID As Integer, pcolFilePrefix As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_idx_Ezyuserid_FilePrefix(Of T)(pcolEzyUserID, pcolFilePrefix, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_idx_Ezyuserid_FilePrefix(Of T)(pcolEzyUserID As Integer, pcolFilePrefix As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_UsersTracking] WHERE [EzyUserID] = @colEzyUserID AND [FilePrefix] = @colFilePrefix"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colEzyUserID", pcolEzyUserID))
            zCmd.Parameters.Add(New SQLParameter("@colFilePrefix", pcolFilePrefix))

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
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_UsersTracking]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblEzyUserstracking
        Implements IrowTblEzyUserstracking

        Public Event Loaded(pUserState As Object) Implements IrowTblEzyUserstracking.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblEzyUserstracking.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblEzyUserstracking.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblEzyUserstracking.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblEzyUserstracking.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblEzyUserstracking.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colId() As Nullable(Of Integer) Implements IrowTblEzyUserstracking.colId
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

        Public Property colEzyUserID() As Nullable(Of Integer) Implements IrowTblEzyUserstracking.colEzyUserID
            Get
                Return m_colEzyUserID
            End Get
            Set
                If Not Same(m_colEzyUserID, Value) Then
                    m_colEzyUserID = Value
                    m_IsDirty(FieldIndex.colEzyUserID) = True
                End If
            End Set
        End Property
        Private m_colEzyUserID As Nullable(Of Integer)

        Public Property colFilePrefix() As Nullable(Of Integer) Implements IrowTblEzyUserstracking.colFilePrefix
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
        Private m_colFilePrefix As Nullable(Of Integer)

        Public Property colDocLibLastReviewedDate() As Nullable(Of Date) Implements IrowTblEzyUserstracking.colDocLibLastReviewedDate
            Get
                Return m_colDocLibLastReviewedDate
            End Get
            Set
                If Not Same(m_colDocLibLastReviewedDate, Value) Then
                    m_colDocLibLastReviewedDate = Value
                    m_IsDirty(FieldIndex.colDocLibLastReviewedDate) = True
                End If
            End Set
        End Property
        Private m_colDocLibLastReviewedDate As Nullable(Of Date)


        Public Function IsDirty(pIndex As rowTblEzyUserstracking.FieldIndex) As Boolean Implements IrowTblEzyUserstracking.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblEzyUserstracking.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblEzyUserstracking.SetIsDirty
            m_IsDirty(FieldIndex.colId) = pDirty
            m_IsDirty(FieldIndex.colEzyUserID) = pDirty
            m_IsDirty(FieldIndex.colFilePrefix) = pDirty
            m_IsDirty(FieldIndex.colDocLibLastReviewedDate) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblEzyUserstracking) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblEzyUserstracking
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colId  = 1
            colEzyUserID 
            colFilePrefix 
            colDocLibLastReviewedDate 
        End Enum

        Private m_IsDirty(4) As Boolean

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

    Public Interface IrowTblEzyUserstracking
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colId() As Nullable(Of Integer)
        Property colEzyUserID() As Nullable(Of Integer)
        Property colFilePrefix() As Nullable(Of Integer)
        Property colDocLibLastReviewedDate() As Nullable(Of Date)
        Function IsDirty(pIndex As rowTblEzyUserstracking.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

