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
    Partial Public Class VwImpairmentDropDownGroups

        Public Shared Function LoadData() As List(Of rowVwImpairmentDropDownGroups)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwImpairmentDropDownGroups)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwImpairmentDropDownGroups)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwImpairmentDropDownGroups)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwImpairmentDropDownGroups)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwImpairmentDropDownGroups)
            Dim zReturn As New List(Of rowVwImpairmentDropDownGroups)
            Dim zSQL As String = "SELECT * FROM [rv].[vwImpairmentDropDownGroups]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwImpairmentDropDownGroups)

			Try
	            Dim zReturn As New List(Of rowVwImpairmentDropDownGroups)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwImpairmentDropDownGroups

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwImpairmentDropDownGroups		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwImpairmentDropDownGroups)
			If Not pReader.IsDBNull(pReader.GetOrdinal("SortOrder")) Then pObject.colSortOrder = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "SortOrder")
			If Not pReader.IsDBNull(pReader.GetOrdinal("GroupNo")) Then pObject.colGroupNo = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "GroupNo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DictionaryId")) Then pObject.colDictionaryId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "DictionaryId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("TextEnglish")) Then pObject.colTextEnglish = UtilSQLServer.SafeReader.SafeReadString(pReader, "TextEnglish")
			If Not pReader.IsDBNull(pReader.GetOrdinal("GroupCode")) Then pObject.colGroupCode = UtilSQLServer.SafeReader.SafeReadString(pReader, "GroupCode")
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
            Dim zSQL As String = "SELECT * FROM [rv].[vwImpairmentDropDownGroups]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowVwImpairmentDropDownGroups
        Implements IrowVwImpairmentDropDownGroups

        Public Event Loaded(pUserState As Object) Implements IrowVwImpairmentDropDownGroups.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwImpairmentDropDownGroups.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwImpairmentDropDownGroups.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwImpairmentDropDownGroups.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwImpairmentDropDownGroups.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwImpairmentDropDownGroups.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colSortOrder() As Nullable(Of Long) Implements IrowVwImpairmentDropDownGroups.colSortOrder
            Get
                Return m_colSortOrder
            End Get
            Set
                If Not Same(m_colSortOrder, Value) Then
                    m_colSortOrder = Value
                    m_IsDirty(FieldIndex.colSortOrder) = True
                End If
            End Set
        End Property
        Private m_colSortOrder As Nullable(Of Long)

        Public Property colGroupNo() As Nullable(Of Integer) Implements IrowVwImpairmentDropDownGroups.colGroupNo
            Get
                Return m_colGroupNo
            End Get
            Set
                If Not Same(m_colGroupNo, Value) Then
                    m_colGroupNo = Value
                    m_IsDirty(FieldIndex.colGroupNo) = True
                End If
            End Set
        End Property
        Private m_colGroupNo As Nullable(Of Integer)

        Public Property colDictionaryId() As Nullable(Of Integer) Implements IrowVwImpairmentDropDownGroups.colDictionaryId
            Get
                Return m_colDictionaryId
            End Get
            Set
                If Not Same(m_colDictionaryId, Value) Then
                    m_colDictionaryId = Value
                    m_IsDirty(FieldIndex.colDictionaryId) = True
                End If
            End Set
        End Property
        Private m_colDictionaryId As Nullable(Of Integer)

        Public Property colTextEnglish() As String Implements IrowVwImpairmentDropDownGroups.colTextEnglish
            Get
                Return m_colTextEnglish
            End Get
            Set
                If Not Same(m_colTextEnglish, Value) Then
                    m_colTextEnglish = Value
                    m_IsDirty(FieldIndex.colTextEnglish) = True
                End If
            End Set
        End Property
        Private m_colTextEnglish As String

        Public Property colGroupCode() As String Implements IrowVwImpairmentDropDownGroups.colGroupCode
            Get
                Return m_colGroupCode
            End Get
            Set
                If Not Same(m_colGroupCode, Value) Then
                    m_colGroupCode = Value
                    m_IsDirty(FieldIndex.colGroupCode) = True
                End If
            End Set
        End Property
        Private m_colGroupCode As String


        Public Function IsDirty(pIndex As rowVwImpairmentDropDownGroups.FieldIndex) As Boolean Implements IrowVwImpairmentDropDownGroups.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwImpairmentDropDownGroups.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwImpairmentDropDownGroups.SetIsDirty
            m_IsDirty(FieldIndex.colSortOrder) = pDirty
            m_IsDirty(FieldIndex.colGroupNo) = pDirty
            m_IsDirty(FieldIndex.colDictionaryId) = pDirty
            m_IsDirty(FieldIndex.colTextEnglish) = pDirty
            m_IsDirty(FieldIndex.colGroupCode) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwImpairmentDropDownGroups) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwImpairmentDropDownGroups
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colSortOrder  = 1
            colGroupNo 
            colDictionaryId 
            colTextEnglish 
            colGroupCode 
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

    Public Interface IrowVwImpairmentDropDownGroups
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colSortOrder() As Nullable(Of Long)
        Property colGroupNo() As Nullable(Of Integer)
        Property colDictionaryId() As Nullable(Of Integer)
        Property colTextEnglish() As String
        Property colGroupCode() As String
        Function IsDirty(pIndex As rowVwImpairmentDropDownGroups.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

