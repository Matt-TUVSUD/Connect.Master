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
    Partial Public Class VwBatchProcessingSetItem

        Public Shared Function LoadData() As List(Of rowVwBatchProcessingSetItem)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwBatchProcessingSetItem)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwBatchProcessingSetItem)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwBatchProcessingSetItem)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwBatchProcessingSetItem)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwBatchProcessingSetItem)
            Dim zReturn As New List(Of rowVwBatchProcessingSetItem)
            Dim zSQL As String = "SELECT * FROM [fv].[vwBatchProcessingSetItem]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwBatchProcessingSetItem)

			Try
	            Dim zReturn As New List(Of rowVwBatchProcessingSetItem)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwBatchProcessingSetItem

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwBatchProcessingSetItem		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwBatchProcessingSetItem)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldId")) Then pObject.colFldId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSetId")) Then pObject.colFldSetId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldSetId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldName")) Then pObject.colFldName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldStatus")) Then pObject.colFldStatus = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldStatus")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldGroupName")) Then pObject.colFldGroupName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldGroupName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldMessage")) Then pObject.colFldMessage = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldMessage")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldStack")) Then pObject.colFldStack = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldStack")
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
            Dim zSQL As String = "SELECT * FROM [fv].[vwBatchProcessingSetItem]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowVwBatchProcessingSetItem
        Implements IrowVwBatchProcessingSetItem

        Public Event Loaded(pUserState As Object) Implements IrowVwBatchProcessingSetItem.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwBatchProcessingSetItem.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwBatchProcessingSetItem.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwBatchProcessingSetItem.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwBatchProcessingSetItem.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwBatchProcessingSetItem.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldId() As Nullable(Of Integer) Implements IrowVwBatchProcessingSetItem.colFldId
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

        Public Property colFldSetId() As Nullable(Of Integer) Implements IrowVwBatchProcessingSetItem.colFldSetId
            Get
                Return m_colFldSetId
            End Get
            Set
                If Not Same(m_colFldSetId, Value) Then
                    m_colFldSetId = Value
                    m_IsDirty(FieldIndex.colFldSetId) = True
                End If
            End Set
        End Property
        Private m_colFldSetId As Nullable(Of Integer)

        Public Property colFldName() As String Implements IrowVwBatchProcessingSetItem.colFldName
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

        Public Property colFldStatus() As String Implements IrowVwBatchProcessingSetItem.colFldStatus
            Get
                Return m_colFldStatus
            End Get
            Set
                If Not Same(m_colFldStatus, Value) Then
                    m_colFldStatus = Value
                    m_IsDirty(FieldIndex.colFldStatus) = True
                End If
            End Set
        End Property
        Private m_colFldStatus As String

        Public Property colFldGroupName() As String Implements IrowVwBatchProcessingSetItem.colFldGroupName
            Get
                Return m_colFldGroupName
            End Get
            Set
                If Not Same(m_colFldGroupName, Value) Then
                    m_colFldGroupName = Value
                    m_IsDirty(FieldIndex.colFldGroupName) = True
                End If
            End Set
        End Property
        Private m_colFldGroupName As String

        Public Property colFldMessage() As String Implements IrowVwBatchProcessingSetItem.colFldMessage
            Get
                Return m_colFldMessage
            End Get
            Set
                If Not Same(m_colFldMessage, Value) Then
                    m_colFldMessage = Value
                    m_IsDirty(FieldIndex.colFldMessage) = True
                End If
            End Set
        End Property
        Private m_colFldMessage As String

        Public Property colFldStack() As String Implements IrowVwBatchProcessingSetItem.colFldStack
            Get
                Return m_colFldStack
            End Get
            Set
                If Not Same(m_colFldStack, Value) Then
                    m_colFldStack = Value
                    m_IsDirty(FieldIndex.colFldStack) = True
                End If
            End Set
        End Property
        Private m_colFldStack As String


        Public Function IsDirty(pIndex As rowVwBatchProcessingSetItem.FieldIndex) As Boolean Implements IrowVwBatchProcessingSetItem.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwBatchProcessingSetItem.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwBatchProcessingSetItem.SetIsDirty
            m_IsDirty(FieldIndex.colFldId) = pDirty
            m_IsDirty(FieldIndex.colFldSetId) = pDirty
            m_IsDirty(FieldIndex.colFldName) = pDirty
            m_IsDirty(FieldIndex.colFldStatus) = pDirty
            m_IsDirty(FieldIndex.colFldGroupName) = pDirty
            m_IsDirty(FieldIndex.colFldMessage) = pDirty
            m_IsDirty(FieldIndex.colFldStack) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwBatchProcessingSetItem) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwBatchProcessingSetItem
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldId  = 1
            colFldSetId 
            colFldName 
            colFldStatus 
            colFldGroupName 
            colFldMessage 
            colFldStack 
        End Enum

        Private m_IsDirty(7) As Boolean

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

    Public Interface IrowVwBatchProcessingSetItem
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldId() As Nullable(Of Integer)
        Property colFldSetId() As Nullable(Of Integer)
        Property colFldName() As String
        Property colFldStatus() As String
        Property colFldGroupName() As String
        Property colFldMessage() As String
        Property colFldStack() As String
        Function IsDirty(pIndex As rowVwBatchProcessingSetItem.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

