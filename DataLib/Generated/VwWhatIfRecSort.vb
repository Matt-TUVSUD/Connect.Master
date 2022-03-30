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
    Partial Public Class VwWhatIfRecSort

        Public Shared Function LoadData() As List(Of rowVwWhatIfRecSort)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwWhatIfRecSort)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwWhatIfRecSort)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwWhatIfRecSort)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwWhatIfRecSort)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwWhatIfRecSort)
            Dim zReturn As New List(Of rowVwWhatIfRecSort)
            Dim zSQL As String = "SELECT * FROM [gv].[vwWhatIfRecSort]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwWhatIfRecSort)

			Try
	            Dim zReturn As New List(Of rowVwWhatIfRecSort)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwWhatIfRecSort

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwWhatIfRecSort		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwWhatIfRecSort)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldID")) Then pObject.colFldID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldText")) Then pObject.colFldText = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldText")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldToolTip")) Then pObject.colFldToolTip = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldToolTip")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSortJson")) Then pObject.colFldSortJson = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldSortJson")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSortOrder")) Then pObject.colFldSortOrder = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldSortOrder")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldVisible")) Then pObject.colFldVisible = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldVisible")
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
            Dim zSQL As String = "SELECT * FROM [gv].[vwWhatIfRecSort]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowVwWhatIfRecSort
        Implements IrowVwWhatIfRecSort

        Public Event Loaded(pUserState As Object) Implements IrowVwWhatIfRecSort.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwWhatIfRecSort.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwWhatIfRecSort.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwWhatIfRecSort.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwWhatIfRecSort.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwWhatIfRecSort.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldID() As Nullable(Of Integer) Implements IrowVwWhatIfRecSort.colFldID
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

        Public Property colFldText() As String Implements IrowVwWhatIfRecSort.colFldText
            Get
                Return m_colFldText
            End Get
            Set
                If Not Same(m_colFldText, Value) Then
                    m_colFldText = Value
                    m_IsDirty(FieldIndex.colFldText) = True
                End If
            End Set
        End Property
        Private m_colFldText As String

        Public Property colFldToolTip() As String Implements IrowVwWhatIfRecSort.colFldToolTip
            Get
                Return m_colFldToolTip
            End Get
            Set
                If Not Same(m_colFldToolTip, Value) Then
                    m_colFldToolTip = Value
                    m_IsDirty(FieldIndex.colFldToolTip) = True
                End If
            End Set
        End Property
        Private m_colFldToolTip As String

        Public Property colFldSortJson() As String Implements IrowVwWhatIfRecSort.colFldSortJson
            Get
                Return m_colFldSortJson
            End Get
            Set
                If Not Same(m_colFldSortJson, Value) Then
                    m_colFldSortJson = Value
                    m_IsDirty(FieldIndex.colFldSortJson) = True
                End If
            End Set
        End Property
        Private m_colFldSortJson As String

        Public Property colFldSortOrder() As Nullable(Of Integer) Implements IrowVwWhatIfRecSort.colFldSortOrder
            Get
                Return m_colFldSortOrder
            End Get
            Set
                If Not Same(m_colFldSortOrder, Value) Then
                    m_colFldSortOrder = Value
                    m_IsDirty(FieldIndex.colFldSortOrder) = True
                End If
            End Set
        End Property
        Private m_colFldSortOrder As Nullable(Of Integer)

        Public Property colFldVisible() As Nullable(Of Boolean) Implements IrowVwWhatIfRecSort.colFldVisible
            Get
                Return m_colFldVisible
            End Get
            Set
                If Not Same(m_colFldVisible, Value) Then
                    m_colFldVisible = Value
                    m_IsDirty(FieldIndex.colFldVisible) = True
                End If
            End Set
        End Property
        Private m_colFldVisible As Nullable(Of Boolean)


        Public Function IsDirty(pIndex As rowVwWhatIfRecSort.FieldIndex) As Boolean Implements IrowVwWhatIfRecSort.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwWhatIfRecSort.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwWhatIfRecSort.SetIsDirty
            m_IsDirty(FieldIndex.colFldID) = pDirty
            m_IsDirty(FieldIndex.colFldText) = pDirty
            m_IsDirty(FieldIndex.colFldToolTip) = pDirty
            m_IsDirty(FieldIndex.colFldSortJson) = pDirty
            m_IsDirty(FieldIndex.colFldSortOrder) = pDirty
            m_IsDirty(FieldIndex.colFldVisible) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwWhatIfRecSort) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwWhatIfRecSort
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldID  = 1
            colFldText 
            colFldToolTip 
            colFldSortJson 
            colFldSortOrder 
            colFldVisible 
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

    Public Interface IrowVwWhatIfRecSort
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldID() As Nullable(Of Integer)
        Property colFldText() As String
        Property colFldToolTip() As String
        Property colFldSortJson() As String
        Property colFldSortOrder() As Nullable(Of Integer)
        Property colFldVisible() As Nullable(Of Boolean)
        Function IsDirty(pIndex As rowVwWhatIfRecSort.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

