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
    Partial Public Class TblClientsskipdatafolder

        Public Shared Sub Delete(ByRef pRowData As IrowTblClientsskipdatafolder)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblClientsskipdatafolder, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblClientsskipdatafolder, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblClientsskipdatafolder, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colExcludeClientFolderId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[clientsskipdatafolder] " & _
                        "WHERE [ExcludeClientFolderId] = @colExcludeClientFolderId"

                Dim zCmd As New SQLCommand
                zCmd.CommandText = zSQL
                zCmd.Parameters.Add(New SQLParameter("@colExcludeClientFolderId", pRowData.colExcludeClientFolderId))

                zCmd.Transaction=pTransaction
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)

                pRowData.RaiseDeletedEvent(pDeleteEventUserState)

            End If

        End Sub

        Public Shared Sub Delete(pcolExcludeClientFolderId As Integer)
            Delete(pcolExcludeClientFolderId, Nothing, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolExcludeClientFolderId As Integer, pDeleteEventUserState As Object)
            Delete(pcolExcludeClientFolderId, Nothing, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Delete(pcolExcludeClientFolderId As Integer, ByRef pTransaction As SqlClient.SqlTransaction)
        Delete(pcolExcludeClientFolderId, pTransaction, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolExcludeClientFolderId As Integer, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
        Dim zObj As rowTblClientsskipdatafolder = LoadByPrimaryKey(pcolExcludeClientFolderId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblClientsskipdatafolder)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblClientsskipdatafolder, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblClientsskipdatafolder, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colExcludeClientFolderId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[clientsskipdatafolder] WHERE [ExcludeClientFolderId] = @colExcludeClientFolderId"

                Dim zCmdDoesExist As New SQLCommand

                zCmdDoesExist.CommandText = zSQL

                zCmdDoesExist.Parameters.Add(new SQLParameter("@colExcludeClientFolderId", pRowData.colExcludeClientFolderId))

                'if zExistInDB > 0  then  PK exists in the DB
                zCmdDoesExist.Transaction = pTransaction
                zExistInDB = razor.UtilSQLServer.ExecuteScalar(zCmdDoesExist)
            End If

            If razor.UtilSQLServer.IsKeySet(pRowData.colExcludeClientFolderId) And zExistInDB > 0 Then
                zMode = "UPDATE"
            End If
            If razor.UtilSQLServer.IsKeySet(pRowData.colExcludeClientFolderId) And zExistInDB = 0 Then
                zMode = "INSERTwithKey"
            End If
            If Not razor.UtilSQLServer.IsKeySet(pRowData.colExcludeClientFolderId) Then
                zMode = "INSERTnoKey"
            End If

            Select Case zMode
                Case "UPDATE"
                    If pRowData.IsDirty Then
                        Dim zUpdate As String = ""
                        Dim zSet As String = ""
                        Dim zWhere As String = ""
                        zUpdate = "UPDATE [dbo].[clientsskipdatafolder] SET " 
                        If pRowData.IsDirty(rowTblClientsskipdatafolder.FieldIndex.colCldbname) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [cldbname] = @colCldbname "
                        End If
                        If pRowData.IsDirty(rowTblClientsskipdatafolder.FieldIndex.colExcludeFolderName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ExcludeFolderName] = @colExcludeFolderName "
                        End If
                        If pRowData.IsDirty(rowTblClientsskipdatafolder.FieldIndex.colComments) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [Comments] = @colComments "
                        End If
                        zWhere = " WHERE [ExcludeClientFolderId] = @colExcludeClientFolderId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[clientsskipdatafolder] ([cldbname], [ExcludeFolderName], [Comments])" & _
                            " VALUES (@colCldbname, @colExcludeFolderName, @colComments); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[clientsskipdatafolder] ([cldbname], [ExcludeFolderName], [Comments])" & _
                            " VALUES (@colCldbname, @colExcludeFolderName, @colComments); SELECT SCOPE_IDENTITY()"
                Case Else
            End Select

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

			'IF UPDATE, SET PK PARAMETER
            If zMode = "UPDATE" Then
                zCmd.Parameters.Add(New SQLParameter("@colExcludeClientFolderId", pRowData.colExcludeClientFolderId))
            End If

			'IF INSERTING, KEY HAS VALUE AND KEY IS NOT IDENTITY, SET PK PARAMETER
			If zMode = "INSERTwithKey" Then
            End If

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClientsskipdatafolder.FieldIndex.colCldbname) Then
                    zCmd.Parameters.Add(New SqlParameter("@colCldbname", IIf(pRowData.colCldbname Is Nothing, DBNull.Value, pRowData.colCldbname)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClientsskipdatafolder.FieldIndex.colExcludeFolderName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colExcludeFolderName", IIf(pRowData.colExcludeFolderName Is Nothing, DBNull.Value, pRowData.colExcludeFolderName)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClientsskipdatafolder.FieldIndex.colComments) Then
                    zCmd.Parameters.Add(New SqlParameter("@colComments", IIf(pRowData.colComments Is Nothing, DBNull.Value, pRowData.colComments)))
                End If

            zCmd.Transaction=pTransaction
            If zMode = "INSERTnoKey" Then
                Dim zLastId As Long = 0
                zLastId = razor.UtilSQLServer.ExecuteNonQueryRowId(zCmd)

                pRowData.colExcludeClientFolderId = zLastId
            Else
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)
            End If

            pRowData.SetIsDirty(False)
            pRowData.RaiseSavedEvent(pSavedEventUserState)

		End If

        End Sub

        Public Shared Function LoadByPrimaryKey(pcolExcludeClientFolderId As Integer) As rowTblClientsskipdatafolder
            Return LoadByPrimaryKey(pcolExcludeClientFolderId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolExcludeClientFolderId As Integer, pLoadEventUserState As Object) As rowTblClientsskipdatafolder
            Return LoadByPrimaryKey(pcolExcludeClientFolderId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolExcludeClientFolderId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblClientsskipdatafolder
            Return LoadByPrimaryKey(pcolExcludeClientFolderId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolExcludeClientFolderId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblClientsskipdatafolder
            Dim zReturn As New rowTblClientsskipdatafolder
            Dim zSQL As String = "SELECT * FROM [dbo].[clientsskipdatafolder] WHERE [ExcludeClientFolderId] = @colExcludeClientFolderId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colExcludeClientFolderId", pcolExcludeClientFolderId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblClientsskipdatafolder) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK_clientsskipdatafolder(pcolExcludeClientFolderId As Integer) As List(Of rowTblClientsskipdatafolder)
            Return LoadByIDX_PK_clientsskipdatafolder(pcolExcludeClientFolderId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_clientsskipdatafolder(pcolExcludeClientFolderId As Integer, pLoadEventUserState As Object) As List(Of rowTblClientsskipdatafolder)
            Return LoadByIDX_PK_clientsskipdatafolder(pcolExcludeClientFolderId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_clientsskipdatafolder(pcolExcludeClientFolderId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblClientsskipdatafolder)
            Return LoadByIDX_PK_clientsskipdatafolder(pcolExcludeClientFolderId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_clientsskipdatafolder(pcolExcludeClientFolderId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblClientsskipdatafolder)
            Dim zReturn As New List(Of rowTblClientsskipdatafolder)
            Dim zSQL As String = "SELECT * FROM [dbo].[clientsskipdatafolder] WHERE [ExcludeClientFolderId] = @colExcludeClientFolderId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colExcludeClientFolderId", pcolExcludeClientFolderId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblClientsskipdatafolder)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblClientsskipdatafolder)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblClientsskipdatafolder)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblClientsskipdatafolder)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblClientsskipdatafolder)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblClientsskipdatafolder)
            Dim zReturn As New List(Of rowTblClientsskipdatafolder)
            Dim zSQL As String = "SELECT * FROM [dbo].[clientsskipdatafolder]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblClientsskipdatafolder)

			Try
	            Dim zReturn As New List(Of rowTblClientsskipdatafolder)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblClientsskipdatafolder

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblClientsskipdatafolder		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblClientsskipdatafolder)
			If Not pReader.IsDBNull(pReader.GetOrdinal("ExcludeClientFolderId")) Then pObject.colExcludeClientFolderId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "ExcludeClientFolderId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("cldbname")) Then pObject.colCldbname = UtilSQLServer.SafeReader.SafeReadString(pReader, "cldbname")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ExcludeFolderName")) Then pObject.colExcludeFolderName = UtilSQLServer.SafeReader.SafeReadString(pReader, "ExcludeFolderName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Comments")) Then pObject.colComments = UtilSQLServer.SafeReader.SafeReadString(pReader, "Comments")
			pObject.SetIsDirty(False)
			Return pObject
		End	 Function

    #Region "Reflection Based Load Functions"

        Public Shared Function LoadByPrimaryKey(Of T)(pcolExcludeClientFolderId As Integer) As T
            Return LoadByPrimaryKey(Of T)(pcolExcludeClientFolderId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolExcludeClientFolderId As Integer, pLoadEventUserState As Object) As T
            Return LoadByPrimaryKey(Of T)(pcolExcludeClientFolderId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolExcludeClientFolderId As Integer, pTransaction As SqlClient.SqlTransaction) As T
            Return LoadByPrimaryKey(Of T)(pcolExcludeClientFolderId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolExcludeClientFolderId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As T

            Dim zReturn As Object = Activator.CreateInstance(Of T)()
            If Not TypeOf zReturn Is rowTblClientsskipdatafolder Then Throw New ArgumentException("Generic type is not type of rowTblClientsskipdatafolder.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[clientsskipdatafolder] WHERE [ExcludeClientFolderId] = @colExcludeClientFolderId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colExcludeClientFolderId", pcolExcludeClientFolderId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of T) = ReadData(Of T)(zCmd, pLoadEventUserState)
            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

        End Function

        Public Shared Function LoadByIDX_PK_clientsskipdatafolder(Of T)(pcolExcludeClientFolderId As Integer) As List(Of T)
            Return LoadByIDX_PK_clientsskipdatafolder(Of T)(pcolExcludeClientFolderId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_clientsskipdatafolder(Of T)(pcolExcludeClientFolderId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK_clientsskipdatafolder(Of T)(pcolExcludeClientFolderId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_clientsskipdatafolder(Of T)(pcolExcludeClientFolderId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK_clientsskipdatafolder(Of T)(pcolExcludeClientFolderId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK_clientsskipdatafolder(Of T)(pcolExcludeClientFolderId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[clientsskipdatafolder] WHERE [ExcludeClientFolderId] = @colExcludeClientFolderId"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colExcludeClientFolderId", pcolExcludeClientFolderId))

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
            Dim zSQL As String = "SELECT * FROM [dbo].[clientsskipdatafolder]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblClientsskipdatafolder
        Implements IrowTblClientsskipdatafolder

        Public Event Loaded(pUserState As Object) Implements IrowTblClientsskipdatafolder.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblClientsskipdatafolder.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblClientsskipdatafolder.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblClientsskipdatafolder.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblClientsskipdatafolder.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblClientsskipdatafolder.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colExcludeClientFolderId() As Nullable(Of Integer) Implements IrowTblClientsskipdatafolder.colExcludeClientFolderId
            Get
                Return m_colExcludeClientFolderId
            End Get
            Set
                If Not Same(m_colExcludeClientFolderId, Value) Then
                    m_colExcludeClientFolderId = Value
                    m_IsDirty(FieldIndex.colExcludeClientFolderId) = True
                End If
            End Set
        End Property
        Private m_colExcludeClientFolderId As Nullable(Of Integer)

        Public Property colCldbname() As String Implements IrowTblClientsskipdatafolder.colCldbname
            Get
                Return m_colCldbname
            End Get
            Set
                If Not Same(m_colCldbname, Value) Then
                    m_colCldbname = Value
                    m_IsDirty(FieldIndex.colCldbname) = True
                End If
            End Set
        End Property
        Private m_colCldbname As String

        Public Property colExcludeFolderName() As String Implements IrowTblClientsskipdatafolder.colExcludeFolderName
            Get
                Return m_colExcludeFolderName
            End Get
            Set
                If Not Same(m_colExcludeFolderName, Value) Then
                    m_colExcludeFolderName = Value
                    m_IsDirty(FieldIndex.colExcludeFolderName) = True
                End If
            End Set
        End Property
        Private m_colExcludeFolderName As String

        Public Property colComments() As String Implements IrowTblClientsskipdatafolder.colComments
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


        Public Function IsDirty(pIndex As rowTblClientsskipdatafolder.FieldIndex) As Boolean Implements IrowTblClientsskipdatafolder.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblClientsskipdatafolder.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblClientsskipdatafolder.SetIsDirty
            m_IsDirty(FieldIndex.colExcludeClientFolderId) = pDirty
            m_IsDirty(FieldIndex.colCldbname) = pDirty
            m_IsDirty(FieldIndex.colExcludeFolderName) = pDirty
            m_IsDirty(FieldIndex.colComments) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblClientsskipdatafolder) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblClientsskipdatafolder
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colExcludeClientFolderId  = 1
            colCldbname 
            colExcludeFolderName 
            colComments 
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

    Public Interface IrowTblClientsskipdatafolder
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colExcludeClientFolderId() As Nullable(Of Integer)
        Property colCldbname() As String
        Property colExcludeFolderName() As String
        Property colComments() As String
        Function IsDirty(pIndex As rowTblClientsskipdatafolder.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

