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
    Partial Public Class VwMetaChartPrefilters

        Public Shared Function LoadData() As List(Of rowVwMetaChartPrefilters)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwMetaChartPrefilters)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwMetaChartPrefilters)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwMetaChartPrefilters)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwMetaChartPrefilters)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwMetaChartPrefilters)
            Dim zReturn As New List(Of rowVwMetaChartPrefilters)
            Dim zSQL As String = "SELECT * FROM [cv].[vwMetaChartPrefilters]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwMetaChartPrefilters)

			Try
	            Dim zReturn As New List(Of rowVwMetaChartPrefilters)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwMetaChartPrefilters

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwMetaChartPrefilters		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwMetaChartPrefilters)
			If Not pReader.IsDBNull(pReader.GetOrdinal("ChartCode")) Then pObject.colChartCode = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "ChartCode")
			If Not pReader.IsDBNull(pReader.GetOrdinal("EnumValue")) Then pObject.colEnumValue = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "EnumValue")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldName")) Then pObject.colFldName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFieldName")) Then pObject.colFldFieldName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldFieldName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldAllowWildcardValue")) Then pObject.colFldAllowWildcardValue = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldAllowWildcardValue")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldParameterKindId")) Then pObject.colFldParameterKindId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldParameterKindId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ParameterKindName")) Then pObject.colParameterKindName = UtilSQLServer.SafeReader.SafeReadString(pReader, "ParameterKindName")
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
            Dim zSQL As String = "SELECT * FROM [cv].[vwMetaChartPrefilters]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowVwMetaChartPrefilters
        Implements IrowVwMetaChartPrefilters

        Public Event Loaded(pUserState As Object) Implements IrowVwMetaChartPrefilters.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwMetaChartPrefilters.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwMetaChartPrefilters.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwMetaChartPrefilters.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwMetaChartPrefilters.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwMetaChartPrefilters.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colChartCode() As Nullable(Of Integer) Implements IrowVwMetaChartPrefilters.colChartCode
            Get
                Return m_colChartCode
            End Get
            Set
                If Not Same(m_colChartCode, Value) Then
                    m_colChartCode = Value
                    m_IsDirty(FieldIndex.colChartCode) = True
                End If
            End Set
        End Property
        Private m_colChartCode As Nullable(Of Integer)

        Public Property colEnumValue() As Nullable(Of Integer) Implements IrowVwMetaChartPrefilters.colEnumValue
            Get
                Return m_colEnumValue
            End Get
            Set
                If Not Same(m_colEnumValue, Value) Then
                    m_colEnumValue = Value
                    m_IsDirty(FieldIndex.colEnumValue) = True
                End If
            End Set
        End Property
        Private m_colEnumValue As Nullable(Of Integer)

        Public Property colFldName() As String Implements IrowVwMetaChartPrefilters.colFldName
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

        Public Property colFldFieldName() As String Implements IrowVwMetaChartPrefilters.colFldFieldName
            Get
                Return m_colFldFieldName
            End Get
            Set
                If Not Same(m_colFldFieldName, Value) Then
                    m_colFldFieldName = Value
                    m_IsDirty(FieldIndex.colFldFieldName) = True
                End If
            End Set
        End Property
        Private m_colFldFieldName As String

        Public Property colFldAllowWildcardValue() As Nullable(Of Boolean) Implements IrowVwMetaChartPrefilters.colFldAllowWildcardValue
            Get
                Return m_colFldAllowWildcardValue
            End Get
            Set
                If Not Same(m_colFldAllowWildcardValue, Value) Then
                    m_colFldAllowWildcardValue = Value
                    m_IsDirty(FieldIndex.colFldAllowWildcardValue) = True
                End If
            End Set
        End Property
        Private m_colFldAllowWildcardValue As Nullable(Of Boolean)

        Public Property colFldParameterKindId() As Nullable(Of Integer) Implements IrowVwMetaChartPrefilters.colFldParameterKindId
            Get
                Return m_colFldParameterKindId
            End Get
            Set
                If Not Same(m_colFldParameterKindId, Value) Then
                    m_colFldParameterKindId = Value
                    m_IsDirty(FieldIndex.colFldParameterKindId) = True
                End If
            End Set
        End Property
        Private m_colFldParameterKindId As Nullable(Of Integer)

        Public Property colParameterKindName() As String Implements IrowVwMetaChartPrefilters.colParameterKindName
            Get
                Return m_colParameterKindName
            End Get
            Set
                If Not Same(m_colParameterKindName, Value) Then
                    m_colParameterKindName = Value
                    m_IsDirty(FieldIndex.colParameterKindName) = True
                End If
            End Set
        End Property
        Private m_colParameterKindName As String


        Public Function IsDirty(pIndex As rowVwMetaChartPrefilters.FieldIndex) As Boolean Implements IrowVwMetaChartPrefilters.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwMetaChartPrefilters.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwMetaChartPrefilters.SetIsDirty
            m_IsDirty(FieldIndex.colChartCode) = pDirty
            m_IsDirty(FieldIndex.colEnumValue) = pDirty
            m_IsDirty(FieldIndex.colFldName) = pDirty
            m_IsDirty(FieldIndex.colFldFieldName) = pDirty
            m_IsDirty(FieldIndex.colFldAllowWildcardValue) = pDirty
            m_IsDirty(FieldIndex.colFldParameterKindId) = pDirty
            m_IsDirty(FieldIndex.colParameterKindName) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwMetaChartPrefilters) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwMetaChartPrefilters
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colChartCode  = 1
            colEnumValue 
            colFldName 
            colFldFieldName 
            colFldAllowWildcardValue 
            colFldParameterKindId 
            colParameterKindName 
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

    Public Interface IrowVwMetaChartPrefilters
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colChartCode() As Nullable(Of Integer)
        Property colEnumValue() As Nullable(Of Integer)
        Property colFldName() As String
        Property colFldFieldName() As String
        Property colFldAllowWildcardValue() As Nullable(Of Boolean)
        Property colFldParameterKindId() As Nullable(Of Integer)
        Property colParameterKindName() As String
        Function IsDirty(pIndex As rowVwMetaChartPrefilters.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

