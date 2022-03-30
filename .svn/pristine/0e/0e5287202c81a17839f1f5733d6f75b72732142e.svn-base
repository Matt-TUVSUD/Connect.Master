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
    Partial Public Class VwRRAutoRequest

        Public Shared Function LoadData() As List(Of rowVwRRAutoRequest)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwRRAutoRequest)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwRRAutoRequest)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwRRAutoRequest)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwRRAutoRequest)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwRRAutoRequest)
            Dim zReturn As New List(Of rowVwRRAutoRequest)
            Dim zSQL As String = "SELECT * FROM [jv].[vwRRAutoRequest]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwRRAutoRequest)

			Try
	            Dim zReturn As New List(Of rowVwRRAutoRequest)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwRRAutoRequest

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwRRAutoRequest		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwRRAutoRequest)
			If Not pReader.IsDBNull(pReader.GetOrdinal("FilePrefix")) Then pObject.colFilePrefix = UtilSQLServer.SafeReader.SafeReadString(pReader, "FilePrefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Division")) Then pObject.colDivision = UtilSQLServer.SafeReader.SafeReadString(pReader, "Division")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CustomAccess")) Then pObject.colCustomAccess = UtilSQLServer.SafeReader.SafeReadString(pReader, "CustomAccess")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ClientLocNo")) Then pObject.colClientLocNo = UtilSQLServer.SafeReader.SafeReadString(pReader, "ClientLocNo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Facility")) Then pObject.colFacility = UtilSQLServer.SafeReader.SafeReadString(pReader, "Facility")
			If Not pReader.IsDBNull(pReader.GetOrdinal("City")) Then pObject.colCity = UtilSQLServer.SafeReader.SafeReadString(pReader, "City")
			If Not pReader.IsDBNull(pReader.GetOrdinal("StProv")) Then pObject.colStProv = UtilSQLServer.SafeReader.SafeReadString(pReader, "StProv")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Country")) Then pObject.colCountry = UtilSQLServer.SafeReader.SafeReadString(pReader, "Country")
			If Not pReader.IsDBNull(pReader.GetOrdinal("AutoRequest")) Then pObject.colAutoRequest = UtilSQLServer.SafeReader.SafeReadString(pReader, "AutoRequest")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RecCount")) Then pObject.colRecCount = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "RecCount")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PracticeId")) Then pObject.colPracticeId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "PracticeId")
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
            Dim zSQL As String = "SELECT * FROM [jv].[vwRRAutoRequest]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowVwRRAutoRequest
        Implements IrowVwRRAutoRequest

        Public Event Loaded(pUserState As Object) Implements IrowVwRRAutoRequest.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwRRAutoRequest.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwRRAutoRequest.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwRRAutoRequest.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwRRAutoRequest.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwRRAutoRequest.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFilePrefix() As String Implements IrowVwRRAutoRequest.colFilePrefix
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

        Public Property colDivision() As String Implements IrowVwRRAutoRequest.colDivision
            Get
                Return m_colDivision
            End Get
            Set
                If Not Same(m_colDivision, Value) Then
                    m_colDivision = Value
                    m_IsDirty(FieldIndex.colDivision) = True
                End If
            End Set
        End Property
        Private m_colDivision As String

        Public Property colCustomAccess() As String Implements IrowVwRRAutoRequest.colCustomAccess
            Get
                Return m_colCustomAccess
            End Get
            Set
                If Not Same(m_colCustomAccess, Value) Then
                    m_colCustomAccess = Value
                    m_IsDirty(FieldIndex.colCustomAccess) = True
                End If
            End Set
        End Property
        Private m_colCustomAccess As String

        Public Property colClientLocNo() As String Implements IrowVwRRAutoRequest.colClientLocNo
            Get
                Return m_colClientLocNo
            End Get
            Set
                If Not Same(m_colClientLocNo, Value) Then
                    m_colClientLocNo = Value
                    m_IsDirty(FieldIndex.colClientLocNo) = True
                End If
            End Set
        End Property
        Private m_colClientLocNo As String

        Public Property colFacility() As String Implements IrowVwRRAutoRequest.colFacility
            Get
                Return m_colFacility
            End Get
            Set
                If Not Same(m_colFacility, Value) Then
                    m_colFacility = Value
                    m_IsDirty(FieldIndex.colFacility) = True
                End If
            End Set
        End Property
        Private m_colFacility As String

        Public Property colCity() As String Implements IrowVwRRAutoRequest.colCity
            Get
                Return m_colCity
            End Get
            Set
                If Not Same(m_colCity, Value) Then
                    m_colCity = Value
                    m_IsDirty(FieldIndex.colCity) = True
                End If
            End Set
        End Property
        Private m_colCity As String

        Public Property colStProv() As String Implements IrowVwRRAutoRequest.colStProv
            Get
                Return m_colStProv
            End Get
            Set
                If Not Same(m_colStProv, Value) Then
                    m_colStProv = Value
                    m_IsDirty(FieldIndex.colStProv) = True
                End If
            End Set
        End Property
        Private m_colStProv As String

        Public Property colCountry() As String Implements IrowVwRRAutoRequest.colCountry
            Get
                Return m_colCountry
            End Get
            Set
                If Not Same(m_colCountry, Value) Then
                    m_colCountry = Value
                    m_IsDirty(FieldIndex.colCountry) = True
                End If
            End Set
        End Property
        Private m_colCountry As String

        Public Property colAutoRequest() As String Implements IrowVwRRAutoRequest.colAutoRequest
            Get
                Return m_colAutoRequest
            End Get
            Set
                If Not Same(m_colAutoRequest, Value) Then
                    m_colAutoRequest = Value
                    m_IsDirty(FieldIndex.colAutoRequest) = True
                End If
            End Set
        End Property
        Private m_colAutoRequest As String

        Public Property colRecCount() As Nullable(Of Integer) Implements IrowVwRRAutoRequest.colRecCount
            Get
                Return m_colRecCount
            End Get
            Set
                If Not Same(m_colRecCount, Value) Then
                    m_colRecCount = Value
                    m_IsDirty(FieldIndex.colRecCount) = True
                End If
            End Set
        End Property
        Private m_colRecCount As Nullable(Of Integer)

        Public Property colPracticeId() As Nullable(Of Integer) Implements IrowVwRRAutoRequest.colPracticeId
            Get
                Return m_colPracticeId
            End Get
            Set
                If Not Same(m_colPracticeId, Value) Then
                    m_colPracticeId = Value
                    m_IsDirty(FieldIndex.colPracticeId) = True
                End If
            End Set
        End Property
        Private m_colPracticeId As Nullable(Of Integer)


        Public Function IsDirty(pIndex As rowVwRRAutoRequest.FieldIndex) As Boolean Implements IrowVwRRAutoRequest.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwRRAutoRequest.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwRRAutoRequest.SetIsDirty
            m_IsDirty(FieldIndex.colFilePrefix) = pDirty
            m_IsDirty(FieldIndex.colDivision) = pDirty
            m_IsDirty(FieldIndex.colCustomAccess) = pDirty
            m_IsDirty(FieldIndex.colClientLocNo) = pDirty
            m_IsDirty(FieldIndex.colFacility) = pDirty
            m_IsDirty(FieldIndex.colCity) = pDirty
            m_IsDirty(FieldIndex.colStProv) = pDirty
            m_IsDirty(FieldIndex.colCountry) = pDirty
            m_IsDirty(FieldIndex.colAutoRequest) = pDirty
            m_IsDirty(FieldIndex.colRecCount) = pDirty
            m_IsDirty(FieldIndex.colPracticeId) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwRRAutoRequest) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwRRAutoRequest
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFilePrefix  = 1
            colDivision 
            colCustomAccess 
            colClientLocNo 
            colFacility 
            colCity 
            colStProv 
            colCountry 
            colAutoRequest 
            colRecCount 
            colPracticeId 
        End Enum

        Private m_IsDirty(11) As Boolean

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

    Public Interface IrowVwRRAutoRequest
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFilePrefix() As String
        Property colDivision() As String
        Property colCustomAccess() As String
        Property colClientLocNo() As String
        Property colFacility() As String
        Property colCity() As String
        Property colStProv() As String
        Property colCountry() As String
        Property colAutoRequest() As String
        Property colRecCount() As Nullable(Of Integer)
        Property colPracticeId() As Nullable(Of Integer)
        Function IsDirty(pIndex As rowVwRRAutoRequest.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

