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
    Partial Public Class VwAllLocations

        Public Shared Function LoadData() As List(Of rowVwAllLocations)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwAllLocations)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwAllLocations)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwAllLocations)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwAllLocations)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwAllLocations)
            Dim zReturn As New List(Of rowVwAllLocations)
            Dim zSQL As String = "SELECT * FROM [jv].[vwAllLocations]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwAllLocations)

			Try
	            Dim zReturn As New List(Of rowVwAllLocations)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwAllLocations

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwAllLocations		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwAllLocations)
			If Not pReader.IsDBNull(pReader.GetOrdinal("Link_to_Location")) Then pObject.colLinkToLocation = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "Link_to_Location")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FileNo")) Then pObject.colFileNo = UtilSQLServer.SafeReader.SafeReadString(pReader, "FileNo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Client")) Then pObject.colClient = UtilSQLServer.SafeReader.SafeReadString(pReader, "Client")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ClientLocNo")) Then pObject.colClientLocNo = UtilSQLServer.SafeReader.SafeReadString(pReader, "ClientLocNo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Division")) Then pObject.colDivision = UtilSQLServer.SafeReader.SafeReadString(pReader, "Division")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Facility")) Then pObject.colFacility = UtilSQLServer.SafeReader.SafeReadString(pReader, "Facility")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Address1")) Then pObject.colAddress1 = UtilSQLServer.SafeReader.SafeReadString(pReader, "Address1")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Address")) Then pObject.colAddress = UtilSQLServer.SafeReader.SafeReadString(pReader, "Address")
			If Not pReader.IsDBNull(pReader.GetOrdinal("City")) Then pObject.colCity = UtilSQLServer.SafeReader.SafeReadString(pReader, "City")
			If Not pReader.IsDBNull(pReader.GetOrdinal("StProv")) Then pObject.colStProv = UtilSQLServer.SafeReader.SafeReadString(pReader, "StProv")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Country")) Then pObject.colCountry = UtilSQLServer.SafeReader.SafeReadString(pReader, "Country")
			If Not pReader.IsDBNull(pReader.GetOrdinal("TIVUS")) Then pObject.colTivus = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "TIVUS")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FilePrefix")) Then pObject.colFilePrefix = UtilSQLServer.SafeReader.SafeReadString(pReader, "FilePrefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Zip")) Then pObject.colZip = UtilSQLServer.SafeReader.SafeReadString(pReader, "Zip")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CustomAccess")) Then pObject.colCustomAccess = UtilSQLServer.SafeReader.SafeReadString(pReader, "CustomAccess")
			If Not pReader.IsDBNull(pReader.GetOrdinal("longitude")) Then pObject.colLongitude = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "longitude")
			If Not pReader.IsDBNull(pReader.GetOrdinal("latitude")) Then pObject.colLatitude = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "latitude")
			If Not pReader.IsDBNull(pReader.GetOrdinal("TIV")) Then pObject.colTiv = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "TIV")
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
            Dim zSQL As String = "SELECT * FROM [jv].[vwAllLocations]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowVwAllLocations
        Implements IrowVwAllLocations

        Public Event Loaded(pUserState As Object) Implements IrowVwAllLocations.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwAllLocations.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwAllLocations.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwAllLocations.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwAllLocations.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwAllLocations.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colLinkToLocation() As Nullable(Of Integer) Implements IrowVwAllLocations.colLinkToLocation
            Get
                Return m_colLinkToLocation
            End Get
            Set
                If Not Same(m_colLinkToLocation, Value) Then
                    m_colLinkToLocation = Value
                    m_IsDirty(FieldIndex.colLinkToLocation) = True
                End If
            End Set
        End Property
        Private m_colLinkToLocation As Nullable(Of Integer)

        Public Property colFileNo() As String Implements IrowVwAllLocations.colFileNo
            Get
                Return m_colFileNo
            End Get
            Set
                If Not Same(m_colFileNo, Value) Then
                    m_colFileNo = Value
                    m_IsDirty(FieldIndex.colFileNo) = True
                End If
            End Set
        End Property
        Private m_colFileNo As String

        Public Property colClient() As String Implements IrowVwAllLocations.colClient
            Get
                Return m_colClient
            End Get
            Set
                If Not Same(m_colClient, Value) Then
                    m_colClient = Value
                    m_IsDirty(FieldIndex.colClient) = True
                End If
            End Set
        End Property
        Private m_colClient As String

        Public Property colClientLocNo() As String Implements IrowVwAllLocations.colClientLocNo
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

        Public Property colDivision() As String Implements IrowVwAllLocations.colDivision
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

        Public Property colFacility() As String Implements IrowVwAllLocations.colFacility
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

        Public Property colAddress1() As String Implements IrowVwAllLocations.colAddress1
            Get
                Return m_colAddress1
            End Get
            Set
                If Not Same(m_colAddress1, Value) Then
                    m_colAddress1 = Value
                    m_IsDirty(FieldIndex.colAddress1) = True
                End If
            End Set
        End Property
        Private m_colAddress1 As String

        Public Property colAddress() As String Implements IrowVwAllLocations.colAddress
            Get
                Return m_colAddress
            End Get
            Set
                If Not Same(m_colAddress, Value) Then
                    m_colAddress = Value
                    m_IsDirty(FieldIndex.colAddress) = True
                End If
            End Set
        End Property
        Private m_colAddress As String

        Public Property colCity() As String Implements IrowVwAllLocations.colCity
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

        Public Property colStProv() As String Implements IrowVwAllLocations.colStProv
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

        Public Property colCountry() As String Implements IrowVwAllLocations.colCountry
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

        Public Property colTivus() As Nullable(Of Integer) Implements IrowVwAllLocations.colTivus
            Get
                Return m_colTivus
            End Get
            Set
                If Not Same(m_colTivus, Value) Then
                    m_colTivus = Value
                    m_IsDirty(FieldIndex.colTivus) = True
                End If
            End Set
        End Property
        Private m_colTivus As Nullable(Of Integer)

        Public Property colFilePrefix() As String Implements IrowVwAllLocations.colFilePrefix
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

        Public Property colZip() As String Implements IrowVwAllLocations.colZip
            Get
                Return m_colZip
            End Get
            Set
                If Not Same(m_colZip, Value) Then
                    m_colZip = Value
                    m_IsDirty(FieldIndex.colZip) = True
                End If
            End Set
        End Property
        Private m_colZip As String

        Public Property colCustomAccess() As String Implements IrowVwAllLocations.colCustomAccess
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

        Public Property colLongitude() As Nullable(Of Decimal) Implements IrowVwAllLocations.colLongitude
            Get
                Return m_colLongitude
            End Get
            Set
                If Not Same(m_colLongitude, Value) Then
                    m_colLongitude = Value
                    m_IsDirty(FieldIndex.colLongitude) = True
                End If
            End Set
        End Property
        Private m_colLongitude As Nullable(Of Decimal)

        Public Property colLatitude() As Nullable(Of Decimal) Implements IrowVwAllLocations.colLatitude
            Get
                Return m_colLatitude
            End Get
            Set
                If Not Same(m_colLatitude, Value) Then
                    m_colLatitude = Value
                    m_IsDirty(FieldIndex.colLatitude) = True
                End If
            End Set
        End Property
        Private m_colLatitude As Nullable(Of Decimal)

        Public Property colTiv() As Nullable(Of Integer) Implements IrowVwAllLocations.colTiv
            Get
                Return m_colTiv
            End Get
            Set
                If Not Same(m_colTiv, Value) Then
                    m_colTiv = Value
                    m_IsDirty(FieldIndex.colTiv) = True
                End If
            End Set
        End Property
        Private m_colTiv As Nullable(Of Integer)


        Public Function IsDirty(pIndex As rowVwAllLocations.FieldIndex) As Boolean Implements IrowVwAllLocations.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwAllLocations.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwAllLocations.SetIsDirty
            m_IsDirty(FieldIndex.colLinkToLocation) = pDirty
            m_IsDirty(FieldIndex.colFileNo) = pDirty
            m_IsDirty(FieldIndex.colClient) = pDirty
            m_IsDirty(FieldIndex.colClientLocNo) = pDirty
            m_IsDirty(FieldIndex.colDivision) = pDirty
            m_IsDirty(FieldIndex.colFacility) = pDirty
            m_IsDirty(FieldIndex.colAddress1) = pDirty
            m_IsDirty(FieldIndex.colAddress) = pDirty
            m_IsDirty(FieldIndex.colCity) = pDirty
            m_IsDirty(FieldIndex.colStProv) = pDirty
            m_IsDirty(FieldIndex.colCountry) = pDirty
            m_IsDirty(FieldIndex.colTivus) = pDirty
            m_IsDirty(FieldIndex.colFilePrefix) = pDirty
            m_IsDirty(FieldIndex.colZip) = pDirty
            m_IsDirty(FieldIndex.colCustomAccess) = pDirty
            m_IsDirty(FieldIndex.colLongitude) = pDirty
            m_IsDirty(FieldIndex.colLatitude) = pDirty
            m_IsDirty(FieldIndex.colTiv) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwAllLocations) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwAllLocations
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colLinkToLocation  = 1
            colFileNo 
            colClient 
            colClientLocNo 
            colDivision 
            colFacility 
            colAddress1 
            colAddress 
            colCity 
            colStProv 
            colCountry 
            colTivus 
            colFilePrefix 
            colZip 
            colCustomAccess 
            colLongitude 
            colLatitude 
            colTiv 
        End Enum

        Private m_IsDirty(18) As Boolean

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

    Public Interface IrowVwAllLocations
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colLinkToLocation() As Nullable(Of Integer)
        Property colFileNo() As String
        Property colClient() As String
        Property colClientLocNo() As String
        Property colDivision() As String
        Property colFacility() As String
        Property colAddress1() As String
        Property colAddress() As String
        Property colCity() As String
        Property colStProv() As String
        Property colCountry() As String
        Property colTivus() As Nullable(Of Integer)
        Property colFilePrefix() As String
        Property colZip() As String
        Property colCustomAccess() As String
        Property colLongitude() As Nullable(Of Decimal)
        Property colLatitude() As Nullable(Of Decimal)
        Property colTiv() As Nullable(Of Integer)
        Function IsDirty(pIndex As rowVwAllLocations.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

