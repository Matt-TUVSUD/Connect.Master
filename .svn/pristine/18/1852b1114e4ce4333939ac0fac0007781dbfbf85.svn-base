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
    Partial Public Class TblEzyPasswordhistory

        Public Shared Sub Delete(ByRef pRowData As IrowTblEzyPasswordhistory)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblEzyPasswordhistory, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblEzyPasswordhistory, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblEzyPasswordhistory, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colPasswordHistoryID) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[ezy_PasswordHistory] " & _
                        "WHERE [PasswordHistoryID] = @colPasswordHistoryID"

                Dim zCmd As New SQLCommand
                zCmd.CommandText = zSQL
                zCmd.Parameters.Add(New SQLParameter("@colPasswordHistoryID", pRowData.colPasswordHistoryID))

                zCmd.Transaction=pTransaction
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)

                pRowData.RaiseDeletedEvent(pDeleteEventUserState)

            End If

        End Sub

        Public Shared Sub Delete(pcolPasswordHistoryID As Integer)
            Delete(pcolPasswordHistoryID, Nothing, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolPasswordHistoryID As Integer, pDeleteEventUserState As Object)
            Delete(pcolPasswordHistoryID, Nothing, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Delete(pcolPasswordHistoryID As Integer, ByRef pTransaction As SqlClient.SqlTransaction)
        Delete(pcolPasswordHistoryID, pTransaction, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolPasswordHistoryID As Integer, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
        Dim zObj As rowTblEzyPasswordhistory = LoadByPrimaryKey(pcolPasswordHistoryID, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblEzyPasswordhistory)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblEzyPasswordhistory, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblEzyPasswordhistory, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colPasswordHistoryID) Then

                zSQL = "SELECT COUNT(*) from [dbo].[ezy_PasswordHistory] WHERE [PasswordHistoryID] = @colPasswordHistoryID"

                Dim zCmdDoesExist As New SQLCommand

                zCmdDoesExist.CommandText = zSQL

                zCmdDoesExist.Parameters.Add(new SQLParameter("@colPasswordHistoryID", pRowData.colPasswordHistoryID))

                'if zExistInDB > 0  then  PK exists in the DB
                zCmdDoesExist.Transaction = pTransaction
                zExistInDB = razor.UtilSQLServer.ExecuteScalar(zCmdDoesExist)
            End If

            If razor.UtilSQLServer.IsKeySet(pRowData.colPasswordHistoryID) And zExistInDB > 0 Then
                zMode = "UPDATE"
            End If
            If razor.UtilSQLServer.IsKeySet(pRowData.colPasswordHistoryID) And zExistInDB = 0 Then
                zMode = "INSERTwithKey"
            End If
            If Not razor.UtilSQLServer.IsKeySet(pRowData.colPasswordHistoryID) Then
                zMode = "INSERTnoKey"
            End If

            Select Case zMode
                Case "UPDATE"
                    If pRowData.IsDirty Then
                        Dim zUpdate As String = ""
                        Dim zSet As String = ""
                        Dim zWhere As String = ""
                        zUpdate = "UPDATE [dbo].[ezy_PasswordHistory] SET " 
                        If pRowData.IsDirty(rowTblEzyPasswordhistory.FieldIndex.colLoginID) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [LoginID] = @colLoginID "
                        End If
                        If pRowData.IsDirty(rowTblEzyPasswordhistory.FieldIndex.colCreatedDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [CreatedDate] = @colCreatedDate "
                        End If
                        If pRowData.IsDirty(rowTblEzyPasswordhistory.FieldIndex.colPassword) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [Password] = @colPassword "
                        End If
                        zWhere = " WHERE [PasswordHistoryID] = @colPasswordHistoryID"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[ezy_PasswordHistory] ([LoginID], [CreatedDate], [Password])" & _
                            " VALUES (@colLoginID, @colCreatedDate, @colPassword); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[ezy_PasswordHistory] ([LoginID], [CreatedDate], [Password])" & _
                            " VALUES (@colLoginID, @colCreatedDate, @colPassword); SELECT SCOPE_IDENTITY()"
                Case Else
            End Select

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

			'IF UPDATE, SET PK PARAMETER
            If zMode = "UPDATE" Then
                zCmd.Parameters.Add(New SQLParameter("@colPasswordHistoryID", pRowData.colPasswordHistoryID))
            End If

			'IF INSERTING, KEY HAS VALUE AND KEY IS NOT IDENTITY, SET PK PARAMETER
			If zMode = "INSERTwithKey" Then
            End If

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyPasswordhistory.FieldIndex.colLoginID) Then
                    zCmd.Parameters.Add(New SqlParameter("@colLoginID", IIf(pRowData.colLoginID Is Nothing, DBNull.Value, pRowData.colLoginID)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyPasswordhistory.FieldIndex.colCreatedDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colCreatedDate", IIf(pRowData.colCreatedDate Is Nothing, DBNull.Value, pRowData.colCreatedDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblEzyPasswordhistory.FieldIndex.colPassword) Then
                    zCmd.Parameters.Add(New SqlParameter("@colPassword", IIf(pRowData.colPassword Is Nothing, DBNull.Value, pRowData.colPassword)))
                End If

            zCmd.Transaction=pTransaction
            If zMode = "INSERTnoKey" Then
                Dim zLastId As Long = 0
                zLastId = razor.UtilSQLServer.ExecuteNonQueryRowId(zCmd)

                pRowData.colPasswordHistoryID = zLastId
            Else
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)
            End If

            pRowData.SetIsDirty(False)
            pRowData.RaiseSavedEvent(pSavedEventUserState)

		End If

        End Sub

        Public Shared Function LoadByPrimaryKey(pcolPasswordHistoryID As Integer) As rowTblEzyPasswordhistory
            Return LoadByPrimaryKey(pcolPasswordHistoryID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolPasswordHistoryID As Integer, pLoadEventUserState As Object) As rowTblEzyPasswordhistory
            Return LoadByPrimaryKey(pcolPasswordHistoryID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolPasswordHistoryID As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblEzyPasswordhistory
            Return LoadByPrimaryKey(pcolPasswordHistoryID, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolPasswordHistoryID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblEzyPasswordhistory
            Dim zReturn As New rowTblEzyPasswordhistory
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_PasswordHistory] WHERE [PasswordHistoryID] = @colPasswordHistoryID"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colPasswordHistoryID", pcolPasswordHistoryID))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblEzyPasswordhistory) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK__ezy_Pass__0A9DD37D359542DD(pcolPasswordHistoryID As Integer) As List(Of rowTblEzyPasswordhistory)
            Return LoadByIDX_PK__ezy_Pass__0A9DD37D359542DD(pcolPasswordHistoryID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__ezy_Pass__0A9DD37D359542DD(pcolPasswordHistoryID As Integer, pLoadEventUserState As Object) As List(Of rowTblEzyPasswordhistory)
            Return LoadByIDX_PK__ezy_Pass__0A9DD37D359542DD(pcolPasswordHistoryID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__ezy_Pass__0A9DD37D359542DD(pcolPasswordHistoryID As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblEzyPasswordhistory)
            Return LoadByIDX_PK__ezy_Pass__0A9DD37D359542DD(pcolPasswordHistoryID, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__ezy_Pass__0A9DD37D359542DD(pcolPasswordHistoryID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblEzyPasswordhistory)
            Dim zReturn As New List(Of rowTblEzyPasswordhistory)
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_PasswordHistory] WHERE [PasswordHistoryID] = @colPasswordHistoryID"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colPasswordHistoryID", pcolPasswordHistoryID))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblEzyPasswordhistory)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblEzyPasswordhistory)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblEzyPasswordhistory)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblEzyPasswordhistory)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblEzyPasswordhistory)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblEzyPasswordhistory)
            Dim zReturn As New List(Of rowTblEzyPasswordhistory)
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_PasswordHistory]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblEzyPasswordhistory)

			Try
	            Dim zReturn As New List(Of rowTblEzyPasswordhistory)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblEzyPasswordhistory

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblEzyPasswordhistory		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblEzyPasswordhistory)
			If Not pReader.IsDBNull(pReader.GetOrdinal("PasswordHistoryID")) Then pObject.colPasswordHistoryID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "PasswordHistoryID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LoginID")) Then pObject.colLoginID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "LoginID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CreatedDate")) Then pObject.colCreatedDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "CreatedDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Password")) Then pObject.colPassword = UtilSQLServer.SafeReader.SafeReadString(pReader, "Password")
			pObject.SetIsDirty(False)
			Return pObject
		End	 Function

    #Region "Reflection Based Load Functions"

        Public Shared Function LoadByPrimaryKey(Of T)(pcolPasswordHistoryID As Integer) As T
            Return LoadByPrimaryKey(Of T)(pcolPasswordHistoryID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolPasswordHistoryID As Integer, pLoadEventUserState As Object) As T
            Return LoadByPrimaryKey(Of T)(pcolPasswordHistoryID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolPasswordHistoryID As Integer, pTransaction As SqlClient.SqlTransaction) As T
            Return LoadByPrimaryKey(Of T)(pcolPasswordHistoryID, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolPasswordHistoryID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As T

            Dim zReturn As Object = Activator.CreateInstance(Of T)()
            If Not TypeOf zReturn Is rowTblEzyPasswordhistory Then Throw New ArgumentException("Generic type is not type of rowTblEzyPasswordhistory.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_PasswordHistory] WHERE [PasswordHistoryID] = @colPasswordHistoryID"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colPasswordHistoryID", pcolPasswordHistoryID))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of T) = ReadData(Of T)(zCmd, pLoadEventUserState)
            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

        End Function

        Public Shared Function LoadByIDX_PK__ezy_Pass__0A9DD37D359542DD(Of T)(pcolPasswordHistoryID As Integer) As List(Of T)
            Return LoadByIDX_PK__ezy_Pass__0A9DD37D359542DD(Of T)(pcolPasswordHistoryID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__ezy_Pass__0A9DD37D359542DD(Of T)(pcolPasswordHistoryID As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK__ezy_Pass__0A9DD37D359542DD(Of T)(pcolPasswordHistoryID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__ezy_Pass__0A9DD37D359542DD(Of T)(pcolPasswordHistoryID As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK__ezy_Pass__0A9DD37D359542DD(Of T)(pcolPasswordHistoryID, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK__ezy_Pass__0A9DD37D359542DD(Of T)(pcolPasswordHistoryID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_PasswordHistory] WHERE [PasswordHistoryID] = @colPasswordHistoryID"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colPasswordHistoryID", pcolPasswordHistoryID))

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
            Dim zSQL As String = "SELECT * FROM [dbo].[ezy_PasswordHistory]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblEzyPasswordhistory
        Implements IrowTblEzyPasswordhistory

        Public Event Loaded(pUserState As Object) Implements IrowTblEzyPasswordhistory.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblEzyPasswordhistory.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblEzyPasswordhistory.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblEzyPasswordhistory.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblEzyPasswordhistory.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblEzyPasswordhistory.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colPasswordHistoryID() As Nullable(Of Integer) Implements IrowTblEzyPasswordhistory.colPasswordHistoryID
            Get
                Return m_colPasswordHistoryID
            End Get
            Set
                If Not Same(m_colPasswordHistoryID, Value) Then
                    m_colPasswordHistoryID = Value
                    m_IsDirty(FieldIndex.colPasswordHistoryID) = True
                End If
            End Set
        End Property
        Private m_colPasswordHistoryID As Nullable(Of Integer)

        Public Property colLoginID() As Nullable(Of Integer) Implements IrowTblEzyPasswordhistory.colLoginID
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

        Public Property colCreatedDate() As Nullable(Of DateTime) Implements IrowTblEzyPasswordhistory.colCreatedDate
            Get
                Return m_colCreatedDate
            End Get
            Set
                If Not Same(m_colCreatedDate, Value) Then
                    m_colCreatedDate = Value
                    m_IsDirty(FieldIndex.colCreatedDate) = True
                End If
            End Set
        End Property
        Private m_colCreatedDate As Nullable(Of DateTime)

        Public Property colPassword() As String Implements IrowTblEzyPasswordhistory.colPassword
            Get
                Return m_colPassword
            End Get
            Set
                If Not Same(m_colPassword, Value) Then
                    m_colPassword = Value
                    m_IsDirty(FieldIndex.colPassword) = True
                End If
            End Set
        End Property
        Private m_colPassword As String


        Public Function IsDirty(pIndex As rowTblEzyPasswordhistory.FieldIndex) As Boolean Implements IrowTblEzyPasswordhistory.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblEzyPasswordhistory.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblEzyPasswordhistory.SetIsDirty
            m_IsDirty(FieldIndex.colPasswordHistoryID) = pDirty
            m_IsDirty(FieldIndex.colLoginID) = pDirty
            m_IsDirty(FieldIndex.colCreatedDate) = pDirty
            m_IsDirty(FieldIndex.colPassword) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblEzyPasswordhistory) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblEzyPasswordhistory
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colPasswordHistoryID  = 1
            colLoginID 
            colCreatedDate 
            colPassword 
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

    Public Interface IrowTblEzyPasswordhistory
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colPasswordHistoryID() As Nullable(Of Integer)
        Property colLoginID() As Nullable(Of Integer)
        Property colCreatedDate() As Nullable(Of DateTime)
        Property colPassword() As String
        Function IsDirty(pIndex As rowTblEzyPasswordhistory.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

