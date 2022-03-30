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
    Partial Public Class VwReclassificationDeletedUser

        Public Shared Function LoadData() As List(Of rowVwReclassificationDeletedUser)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwReclassificationDeletedUser)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwReclassificationDeletedUser)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwReclassificationDeletedUser)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwReclassificationDeletedUser)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwReclassificationDeletedUser)
            Dim zReturn As New List(Of rowVwReclassificationDeletedUser)
            Dim zSQL As String = "SELECT * FROM [jv].[vwReclassificationDeletedUser]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwReclassificationDeletedUser)

			Try
	            Dim zReturn As New List(Of rowVwReclassificationDeletedUser)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwReclassificationDeletedUser

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwReclassificationDeletedUser		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwReclassificationDeletedUser)
			If Not pReader.IsDBNull(pReader.GetOrdinal("EzyUserID")) Then pObject.colEzyUserID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "EzyUserID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FullName")) Then pObject.colFullName = UtilSQLServer.SafeReader.SafeReadString(pReader, "FullName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ReclassificationAction")) Then pObject.colReclassificationAction = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "ReclassificationAction")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ReclassificationDate")) Then pObject.colReclassificationDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "ReclassificationDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("MarkedForDeletionDate")) Then pObject.colMarkedForDeletionDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "MarkedForDeletionDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ReclassificationCompletionDate")) Then pObject.colReclassificationCompletionDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "ReclassificationCompletionDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("MarkedForDeletion")) Then pObject.colMarkedForDeletion = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "MarkedForDeletion")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DeleteOnDate")) Then pObject.colDeleteOnDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "DeleteOnDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LoginId")) Then pObject.colLoginId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "LoginId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DeleteLogin")) Then pObject.colDeleteLogin = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "DeleteLogin")
			pObject.SetIsDirty(False)
			Return pObject
		End	 Function

    #Region "Reflection Based Load Functions"


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
            Dim zSQL As String = "SELECT * FROM [jv].[vwReclassificationDeletedUser]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowVwReclassificationDeletedUser
        Implements IrowVwReclassificationDeletedUser

        Public Event Loaded(pUserState As Object) Implements IrowVwReclassificationDeletedUser.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwReclassificationDeletedUser.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwReclassificationDeletedUser.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwReclassificationDeletedUser.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwReclassificationDeletedUser.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwReclassificationDeletedUser.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colEzyUserID() As Nullable(Of Integer) Implements IrowVwReclassificationDeletedUser.colEzyUserID
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

        Public Property colFullName() As String Implements IrowVwReclassificationDeletedUser.colFullName
            Get
                Return m_colFullName
            End Get
            Set
                If Not Same(m_colFullName, Value) Then
                    m_colFullName = Value
                    m_IsDirty(FieldIndex.colFullName) = True
                End If
            End Set
        End Property
        Private m_colFullName As String

        Public Property colReclassificationAction() As Nullable(Of Integer) Implements IrowVwReclassificationDeletedUser.colReclassificationAction
            Get
                Return m_colReclassificationAction
            End Get
            Set
                If Not Same(m_colReclassificationAction, Value) Then
                    m_colReclassificationAction = Value
                    m_IsDirty(FieldIndex.colReclassificationAction) = True
                End If
            End Set
        End Property
        Private m_colReclassificationAction As Nullable(Of Integer)

        Public Property colReclassificationDate() As Nullable(Of DateTime) Implements IrowVwReclassificationDeletedUser.colReclassificationDate
            Get
                Return m_colReclassificationDate
            End Get
            Set
                If Not Same(m_colReclassificationDate, Value) Then
                    m_colReclassificationDate = Value
                    m_IsDirty(FieldIndex.colReclassificationDate) = True
                End If
            End Set
        End Property
        Private m_colReclassificationDate As Nullable(Of DateTime)

        Public Property colMarkedForDeletionDate() As Nullable(Of DateTime) Implements IrowVwReclassificationDeletedUser.colMarkedForDeletionDate
            Get
                Return m_colMarkedForDeletionDate
            End Get
            Set
                If Not Same(m_colMarkedForDeletionDate, Value) Then
                    m_colMarkedForDeletionDate = Value
                    m_IsDirty(FieldIndex.colMarkedForDeletionDate) = True
                End If
            End Set
        End Property
        Private m_colMarkedForDeletionDate As Nullable(Of DateTime)

        Public Property colReclassificationCompletionDate() As Nullable(Of DateTime) Implements IrowVwReclassificationDeletedUser.colReclassificationCompletionDate
            Get
                Return m_colReclassificationCompletionDate
            End Get
            Set
                If Not Same(m_colReclassificationCompletionDate, Value) Then
                    m_colReclassificationCompletionDate = Value
                    m_IsDirty(FieldIndex.colReclassificationCompletionDate) = True
                End If
            End Set
        End Property
        Private m_colReclassificationCompletionDate As Nullable(Of DateTime)

        Public Property colMarkedForDeletion() As Nullable(Of Boolean) Implements IrowVwReclassificationDeletedUser.colMarkedForDeletion
            Get
                Return m_colMarkedForDeletion
            End Get
            Set
                If Not Same(m_colMarkedForDeletion, Value) Then
                    m_colMarkedForDeletion = Value
                    m_IsDirty(FieldIndex.colMarkedForDeletion) = True
                End If
            End Set
        End Property
        Private m_colMarkedForDeletion As Nullable(Of Boolean)

        Public Property colDeleteOnDate() As Nullable(Of DateTime) Implements IrowVwReclassificationDeletedUser.colDeleteOnDate
            Get
                Return m_colDeleteOnDate
            End Get
            Set
                If Not Same(m_colDeleteOnDate, Value) Then
                    m_colDeleteOnDate = Value
                    m_IsDirty(FieldIndex.colDeleteOnDate) = True
                End If
            End Set
        End Property
        Private m_colDeleteOnDate As Nullable(Of DateTime)

        Public Property colLoginId() As Nullable(Of Integer) Implements IrowVwReclassificationDeletedUser.colLoginId
            Get
                Return m_colLoginId
            End Get
            Set
                If Not Same(m_colLoginId, Value) Then
                    m_colLoginId = Value
                    m_IsDirty(FieldIndex.colLoginId) = True
                End If
            End Set
        End Property
        Private m_colLoginId As Nullable(Of Integer)

        Public Property colDeleteLogin() As Nullable(Of Boolean) Implements IrowVwReclassificationDeletedUser.colDeleteLogin
            Get
                Return m_colDeleteLogin
            End Get
            Set
                If Not Same(m_colDeleteLogin, Value) Then
                    m_colDeleteLogin = Value
                    m_IsDirty(FieldIndex.colDeleteLogin) = True
                End If
            End Set
        End Property
        Private m_colDeleteLogin As Nullable(Of Boolean)


        Public Function IsDirty(pIndex As rowVwReclassificationDeletedUser.FieldIndex) As Boolean Implements IrowVwReclassificationDeletedUser.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwReclassificationDeletedUser.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwReclassificationDeletedUser.SetIsDirty
            m_IsDirty(FieldIndex.colEzyUserID) = pDirty
            m_IsDirty(FieldIndex.colFullName) = pDirty
            m_IsDirty(FieldIndex.colReclassificationAction) = pDirty
            m_IsDirty(FieldIndex.colReclassificationDate) = pDirty
            m_IsDirty(FieldIndex.colMarkedForDeletionDate) = pDirty
            m_IsDirty(FieldIndex.colReclassificationCompletionDate) = pDirty
            m_IsDirty(FieldIndex.colMarkedForDeletion) = pDirty
            m_IsDirty(FieldIndex.colDeleteOnDate) = pDirty
            m_IsDirty(FieldIndex.colLoginId) = pDirty
            m_IsDirty(FieldIndex.colDeleteLogin) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwReclassificationDeletedUser) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwReclassificationDeletedUser
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colEzyUserID  = 1
            colFullName 
            colReclassificationAction 
            colReclassificationDate 
            colMarkedForDeletionDate 
            colReclassificationCompletionDate 
            colMarkedForDeletion 
            colDeleteOnDate 
            colLoginId 
            colDeleteLogin 
        End Enum

        Private m_IsDirty(10) As Boolean

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

    Public Interface IrowVwReclassificationDeletedUser
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colEzyUserID() As Nullable(Of Integer)
        Property colFullName() As String
        Property colReclassificationAction() As Nullable(Of Integer)
        Property colReclassificationDate() As Nullable(Of DateTime)
        Property colMarkedForDeletionDate() As Nullable(Of DateTime)
        Property colReclassificationCompletionDate() As Nullable(Of DateTime)
        Property colMarkedForDeletion() As Nullable(Of Boolean)
        Property colDeleteOnDate() As Nullable(Of DateTime)
        Property colLoginId() As Nullable(Of Integer)
        Property colDeleteLogin() As Nullable(Of Boolean)
        Function IsDirty(pIndex As rowVwReclassificationDeletedUser.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

