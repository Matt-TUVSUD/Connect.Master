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
    Partial Public Class VwGSafeFileNoRadius

        Public Shared Function LoadData() As List(Of rowVwGSafeFileNoRadius)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwGSafeFileNoRadius)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwGSafeFileNoRadius)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwGSafeFileNoRadius)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwGSafeFileNoRadius)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwGSafeFileNoRadius)
            Dim zReturn As New List(Of rowVwGSafeFileNoRadius)
            Dim zSQL As String = "SELECT * FROM [gv].[vwGSafeFileNoRadius]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwGSafeFileNoRadius)

			Try
	            Dim zReturn As New List(Of rowVwGSafeFileNoRadius)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwGSafeFileNoRadius

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwGSafeFileNoRadius		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwGSafeFileNoRadius)
			If Not pReader.IsDBNull(pReader.GetOrdinal("Link_to_Popup")) Then pObject.colLinkToPopup = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "Link_to_Popup")
			If Not pReader.IsDBNull(pReader.GetOrdinal("GSafeId")) Then pObject.colGSafeId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "GSafeId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RefLatitude")) Then pObject.colRefLatitude = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "RefLatitude")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RefLongitude")) Then pObject.colRefLongitude = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "RefLongitude")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Units")) Then pObject.colUnits = UtilSQLServer.SafeReader.SafeReadString(pReader, "Units")
			If Not pReader.IsDBNull(pReader.GetOrdinal("InputRange")) Then pObject.colInputRange = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "InputRange")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SearchName")) Then pObject.colSearchName = UtilSQLServer.SafeReader.SafeReadString(pReader, "SearchName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FileNo")) Then pObject.colFileNo = UtilSQLServer.SafeReader.SafeReadString(pReader, "FileNo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("client")) Then pObject.colClient = UtilSQLServer.SafeReader.SafeReadString(pReader, "client")
			If Not pReader.IsDBNull(pReader.GetOrdinal("address")) Then pObject.colAddress = UtilSQLServer.SafeReader.SafeReadString(pReader, "address")
			If Not pReader.IsDBNull(pReader.GetOrdinal("City")) Then pObject.colCity = UtilSQLServer.SafeReader.SafeReadString(pReader, "City")
			If Not pReader.IsDBNull(pReader.GetOrdinal("StProv")) Then pObject.colStProv = UtilSQLServer.SafeReader.SafeReadString(pReader, "StProv")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Country")) Then pObject.colCountry = UtilSQLServer.SafeReader.SafeReadString(pReader, "Country")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Zip")) Then pObject.colZip = UtilSQLServer.SafeReader.SafeReadString(pReader, "Zip")
			If Not pReader.IsDBNull(pReader.GetOrdinal("TIV")) Then pObject.colTiv = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "TIV")
			If Not pReader.IsDBNull(pReader.GetOrdinal("latitude")) Then pObject.colLatitude = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "latitude")
			If Not pReader.IsDBNull(pReader.GetOrdinal("longitude")) Then pObject.colLongitude = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "longitude")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DistanceMiles")) Then pObject.colDistanceMiles = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "DistanceMiles")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DistanceNauticalMiles")) Then pObject.colDistanceNauticalMiles = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "DistanceNauticalMiles")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DistanceKilometers")) Then pObject.colDistanceKilometers = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "DistanceKilometers")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LastInspDate")) Then pObject.colLastInspDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "LastInspDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ClientLocNo")) Then pObject.colClientLocNo = UtilSQLServer.SafeReader.SafeReadString(pReader, "ClientLocNo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Division")) Then pObject.colDivision = UtilSQLServer.SafeReader.SafeReadString(pReader, "Division")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Facility")) Then pObject.colFacility = UtilSQLServer.SafeReader.SafeReadString(pReader, "Facility")
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
            Dim zSQL As String = "SELECT * FROM [gv].[vwGSafeFileNoRadius]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowVwGSafeFileNoRadius
        Implements IrowVwGSafeFileNoRadius

        Public Event Loaded(pUserState As Object) Implements IrowVwGSafeFileNoRadius.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwGSafeFileNoRadius.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwGSafeFileNoRadius.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwGSafeFileNoRadius.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwGSafeFileNoRadius.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwGSafeFileNoRadius.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colLinkToPopup() As Nullable(Of Integer) Implements IrowVwGSafeFileNoRadius.colLinkToPopup
            Get
                Return m_colLinkToPopup
            End Get
            Set
                If Not Same(m_colLinkToPopup, Value) Then
                    m_colLinkToPopup = Value
                    m_IsDirty(FieldIndex.colLinkToPopup) = True
                End If
            End Set
        End Property
        Private m_colLinkToPopup As Nullable(Of Integer)

        Public Property colGSafeId() As Nullable(Of Integer) Implements IrowVwGSafeFileNoRadius.colGSafeId
            Get
                Return m_colGSafeId
            End Get
            Set
                If Not Same(m_colGSafeId, Value) Then
                    m_colGSafeId = Value
                    m_IsDirty(FieldIndex.colGSafeId) = True
                End If
            End Set
        End Property
        Private m_colGSafeId As Nullable(Of Integer)

        Public Property colRefLatitude() As Nullable(Of Decimal) Implements IrowVwGSafeFileNoRadius.colRefLatitude
            Get
                Return m_colRefLatitude
            End Get
            Set
                If Not Same(m_colRefLatitude, Value) Then
                    m_colRefLatitude = Value
                    m_IsDirty(FieldIndex.colRefLatitude) = True
                End If
            End Set
        End Property
        Private m_colRefLatitude As Nullable(Of Decimal)

        Public Property colRefLongitude() As Nullable(Of Decimal) Implements IrowVwGSafeFileNoRadius.colRefLongitude
            Get
                Return m_colRefLongitude
            End Get
            Set
                If Not Same(m_colRefLongitude, Value) Then
                    m_colRefLongitude = Value
                    m_IsDirty(FieldIndex.colRefLongitude) = True
                End If
            End Set
        End Property
        Private m_colRefLongitude As Nullable(Of Decimal)

        Public Property colUnits() As String Implements IrowVwGSafeFileNoRadius.colUnits
            Get
                Return m_colUnits
            End Get
            Set
                If Not Same(m_colUnits, Value) Then
                    m_colUnits = Value
                    m_IsDirty(FieldIndex.colUnits) = True
                End If
            End Set
        End Property
        Private m_colUnits As String

        Public Property colInputRange() As Nullable(Of Double) Implements IrowVwGSafeFileNoRadius.colInputRange
            Get
                Return m_colInputRange
            End Get
            Set
                If Not Same(m_colInputRange, Value) Then
                    m_colInputRange = Value
                    m_IsDirty(FieldIndex.colInputRange) = True
                End If
            End Set
        End Property
        Private m_colInputRange As Nullable(Of Double)

        Public Property colSearchName() As String Implements IrowVwGSafeFileNoRadius.colSearchName
            Get
                Return m_colSearchName
            End Get
            Set
                If Not Same(m_colSearchName, Value) Then
                    m_colSearchName = Value
                    m_IsDirty(FieldIndex.colSearchName) = True
                End If
            End Set
        End Property
        Private m_colSearchName As String

        Public Property colFileNo() As String Implements IrowVwGSafeFileNoRadius.colFileNo
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

        Public Property colClient() As String Implements IrowVwGSafeFileNoRadius.colClient
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

        Public Property colAddress() As String Implements IrowVwGSafeFileNoRadius.colAddress
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

        Public Property colCity() As String Implements IrowVwGSafeFileNoRadius.colCity
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

        Public Property colStProv() As String Implements IrowVwGSafeFileNoRadius.colStProv
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

        Public Property colCountry() As String Implements IrowVwGSafeFileNoRadius.colCountry
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

        Public Property colZip() As String Implements IrowVwGSafeFileNoRadius.colZip
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

        Public Property colTiv() As Nullable(Of Double) Implements IrowVwGSafeFileNoRadius.colTiv
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
        Private m_colTiv As Nullable(Of Double)

        Public Property colLatitude() As Nullable(Of Decimal) Implements IrowVwGSafeFileNoRadius.colLatitude
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

        Public Property colLongitude() As Nullable(Of Decimal) Implements IrowVwGSafeFileNoRadius.colLongitude
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

        Public Property colDistanceMiles() As Nullable(Of Double) Implements IrowVwGSafeFileNoRadius.colDistanceMiles
            Get
                Return m_colDistanceMiles
            End Get
            Set
                If Not Same(m_colDistanceMiles, Value) Then
                    m_colDistanceMiles = Value
                    m_IsDirty(FieldIndex.colDistanceMiles) = True
                End If
            End Set
        End Property
        Private m_colDistanceMiles As Nullable(Of Double)

        Public Property colDistanceNauticalMiles() As Nullable(Of Double) Implements IrowVwGSafeFileNoRadius.colDistanceNauticalMiles
            Get
                Return m_colDistanceNauticalMiles
            End Get
            Set
                If Not Same(m_colDistanceNauticalMiles, Value) Then
                    m_colDistanceNauticalMiles = Value
                    m_IsDirty(FieldIndex.colDistanceNauticalMiles) = True
                End If
            End Set
        End Property
        Private m_colDistanceNauticalMiles As Nullable(Of Double)

        Public Property colDistanceKilometers() As Nullable(Of Double) Implements IrowVwGSafeFileNoRadius.colDistanceKilometers
            Get
                Return m_colDistanceKilometers
            End Get
            Set
                If Not Same(m_colDistanceKilometers, Value) Then
                    m_colDistanceKilometers = Value
                    m_IsDirty(FieldIndex.colDistanceKilometers) = True
                End If
            End Set
        End Property
        Private m_colDistanceKilometers As Nullable(Of Double)

        Public Property colLastInspDate() As Nullable(Of DateTime) Implements IrowVwGSafeFileNoRadius.colLastInspDate
            Get
                Return m_colLastInspDate
            End Get
            Set
                If Not Same(m_colLastInspDate, Value) Then
                    m_colLastInspDate = Value
                    m_IsDirty(FieldIndex.colLastInspDate) = True
                End If
            End Set
        End Property
        Private m_colLastInspDate As Nullable(Of DateTime)

        Public Property colClientLocNo() As String Implements IrowVwGSafeFileNoRadius.colClientLocNo
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

        Public Property colDivision() As String Implements IrowVwGSafeFileNoRadius.colDivision
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

        Public Property colFacility() As String Implements IrowVwGSafeFileNoRadius.colFacility
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


        Public Function IsDirty(pIndex As rowVwGSafeFileNoRadius.FieldIndex) As Boolean Implements IrowVwGSafeFileNoRadius.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwGSafeFileNoRadius.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwGSafeFileNoRadius.SetIsDirty
            m_IsDirty(FieldIndex.colLinkToPopup) = pDirty
            m_IsDirty(FieldIndex.colGSafeId) = pDirty
            m_IsDirty(FieldIndex.colRefLatitude) = pDirty
            m_IsDirty(FieldIndex.colRefLongitude) = pDirty
            m_IsDirty(FieldIndex.colUnits) = pDirty
            m_IsDirty(FieldIndex.colInputRange) = pDirty
            m_IsDirty(FieldIndex.colSearchName) = pDirty
            m_IsDirty(FieldIndex.colFileNo) = pDirty
            m_IsDirty(FieldIndex.colClient) = pDirty
            m_IsDirty(FieldIndex.colAddress) = pDirty
            m_IsDirty(FieldIndex.colCity) = pDirty
            m_IsDirty(FieldIndex.colStProv) = pDirty
            m_IsDirty(FieldIndex.colCountry) = pDirty
            m_IsDirty(FieldIndex.colZip) = pDirty
            m_IsDirty(FieldIndex.colTiv) = pDirty
            m_IsDirty(FieldIndex.colLatitude) = pDirty
            m_IsDirty(FieldIndex.colLongitude) = pDirty
            m_IsDirty(FieldIndex.colDistanceMiles) = pDirty
            m_IsDirty(FieldIndex.colDistanceNauticalMiles) = pDirty
            m_IsDirty(FieldIndex.colDistanceKilometers) = pDirty
            m_IsDirty(FieldIndex.colLastInspDate) = pDirty
            m_IsDirty(FieldIndex.colClientLocNo) = pDirty
            m_IsDirty(FieldIndex.colDivision) = pDirty
            m_IsDirty(FieldIndex.colFacility) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwGSafeFileNoRadius) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwGSafeFileNoRadius
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colLinkToPopup  = 1
            colGSafeId 
            colRefLatitude 
            colRefLongitude 
            colUnits 
            colInputRange 
            colSearchName 
            colFileNo 
            colClient 
            colAddress 
            colCity 
            colStProv 
            colCountry 
            colZip 
            colTiv 
            colLatitude 
            colLongitude 
            colDistanceMiles 
            colDistanceNauticalMiles 
            colDistanceKilometers 
            colLastInspDate 
            colClientLocNo 
            colDivision 
            colFacility 
        End Enum

        Private m_IsDirty(24) As Boolean

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

    Public Interface IrowVwGSafeFileNoRadius
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colLinkToPopup() As Nullable(Of Integer)
        Property colGSafeId() As Nullable(Of Integer)
        Property colRefLatitude() As Nullable(Of Decimal)
        Property colRefLongitude() As Nullable(Of Decimal)
        Property colUnits() As String
        Property colInputRange() As Nullable(Of Double)
        Property colSearchName() As String
        Property colFileNo() As String
        Property colClient() As String
        Property colAddress() As String
        Property colCity() As String
        Property colStProv() As String
        Property colCountry() As String
        Property colZip() As String
        Property colTiv() As Nullable(Of Double)
        Property colLatitude() As Nullable(Of Decimal)
        Property colLongitude() As Nullable(Of Decimal)
        Property colDistanceMiles() As Nullable(Of Double)
        Property colDistanceNauticalMiles() As Nullable(Of Double)
        Property colDistanceKilometers() As Nullable(Of Double)
        Property colLastInspDate() As Nullable(Of DateTime)
        Property colClientLocNo() As String
        Property colDivision() As String
        Property colFacility() As String
        Function IsDirty(pIndex As rowVwGSafeFileNoRadius.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

