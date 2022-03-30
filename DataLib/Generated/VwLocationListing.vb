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
    Partial Public Class VwLocationListing

        Public Shared Function LoadData() As List(Of rowVwLocationListing)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwLocationListing)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwLocationListing)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwLocationListing)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwLocationListing)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwLocationListing)
            Dim zReturn As New List(Of rowVwLocationListing)
            Dim zSQL As String = "SELECT * FROM [dbo].[vwLocationListing]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwLocationListing)

			Try
	            Dim zReturn As New List(Of rowVwLocationListing)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwLocationListing

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwLocationListing		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwLocationListing)
			If Not pReader.IsDBNull(pReader.GetOrdinal("FilePrefix")) Then pObject.colFilePrefix = UtilSQLServer.SafeReader.SafeReadString(pReader, "FilePrefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FileNo")) Then pObject.colFileNo = UtilSQLServer.SafeReader.SafeReadString(pReader, "FileNo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Client")) Then pObject.colClient = UtilSQLServer.SafeReader.SafeReadString(pReader, "Client")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ClientLocNo")) Then pObject.colClientLocNo = UtilSQLServer.SafeReader.SafeReadString(pReader, "ClientLocNo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Division")) Then pObject.colDivision = UtilSQLServer.SafeReader.SafeReadString(pReader, "Division")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CustomAccess")) Then pObject.colCustomAccess = UtilSQLServer.SafeReader.SafeReadString(pReader, "CustomAccess")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Facility")) Then pObject.colFacility = UtilSQLServer.SafeReader.SafeReadString(pReader, "Facility")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Address1")) Then pObject.colAddress1 = UtilSQLServer.SafeReader.SafeReadString(pReader, "Address1")
			If Not pReader.IsDBNull(pReader.GetOrdinal("City")) Then pObject.colCity = UtilSQLServer.SafeReader.SafeReadString(pReader, "City")
			If Not pReader.IsDBNull(pReader.GetOrdinal("StProv")) Then pObject.colStProv = UtilSQLServer.SafeReader.SafeReadString(pReader, "StProv")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Country")) Then pObject.colCountry = UtilSQLServer.SafeReader.SafeReadString(pReader, "Country")
			If Not pReader.IsDBNull(pReader.GetOrdinal("100PercentUSTot")) Then pObject.colPercentUSTot = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "100PercentUSTot")
			If Not pReader.IsDBNull(pReader.GetOrdinal("TIVAustralian")) Then pObject.colTIVAustralian = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "TIVAustralian")
			If Not pReader.IsDBNull(pReader.GetOrdinal("TIVBritish")) Then pObject.colTIVBritish = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "TIVBritish")
			If Not pReader.IsDBNull(pReader.GetOrdinal("TIVCanadian")) Then pObject.colTIVCanadian = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "TIVCanadian")
			If Not pReader.IsDBNull(pReader.GetOrdinal("TIVEuro")) Then pObject.colTIVEuro = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "TIVEuro")
			If Not pReader.IsDBNull(pReader.GetOrdinal("TIVJapanese")) Then pObject.colTIVJapanese = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "TIVJapanese")
			If Not pReader.IsDBNull(pReader.GetOrdinal("TIVMexican")) Then pObject.colTIVMexican = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "TIVMexican")
			If Not pReader.IsDBNull(pReader.GetOrdinal("TIVNewZealand")) Then pObject.colTIVNewZealand = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "TIVNewZealand")
			If Not pReader.IsDBNull(pReader.GetOrdinal("TIVUS")) Then pObject.colTivus = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "TIVUS")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Hazard")) Then pObject.colHazard = UtilSQLServer.SafeReader.SafeReadString(pReader, "Hazard")
			If Not pReader.IsDBNull(pReader.GetOrdinal("EffectiveDate")) Then pObject.colEffectiveDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "EffectiveDate")
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
            Dim zSQL As String = "SELECT * FROM [dbo].[vwLocationListing]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowVwLocationListing
        Implements IrowVwLocationListing

        Public Event Loaded(pUserState As Object) Implements IrowVwLocationListing.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwLocationListing.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwLocationListing.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwLocationListing.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwLocationListing.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwLocationListing.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFilePrefix() As String Implements IrowVwLocationListing.colFilePrefix
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

        Public Property colFileNo() As String Implements IrowVwLocationListing.colFileNo
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

        Public Property colClient() As String Implements IrowVwLocationListing.colClient
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

        Public Property colClientLocNo() As String Implements IrowVwLocationListing.colClientLocNo
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

        Public Property colDivision() As String Implements IrowVwLocationListing.colDivision
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

        Public Property colCustomAccess() As String Implements IrowVwLocationListing.colCustomAccess
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

        Public Property colFacility() As String Implements IrowVwLocationListing.colFacility
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

        Public Property colAddress1() As String Implements IrowVwLocationListing.colAddress1
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

        Public Property colCity() As String Implements IrowVwLocationListing.colCity
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

        Public Property colStProv() As String Implements IrowVwLocationListing.colStProv
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

        Public Property colCountry() As String Implements IrowVwLocationListing.colCountry
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

        Public Property colPercentUSTot() As Nullable(Of Double) Implements IrowVwLocationListing.colPercentUSTot
            Get
                Return m_colPercentUSTot
            End Get
            Set
                If Not Same(m_colPercentUSTot, Value) Then
                    m_colPercentUSTot = Value
                    m_IsDirty(FieldIndex.colPercentUSTot) = True
                End If
            End Set
        End Property
        Private m_colPercentUSTot As Nullable(Of Double)

        Public Property colTIVAustralian() As Nullable(Of Long) Implements IrowVwLocationListing.colTIVAustralian
            Get
                Return m_colTIVAustralian
            End Get
            Set
                If Not Same(m_colTIVAustralian, Value) Then
                    m_colTIVAustralian = Value
                    m_IsDirty(FieldIndex.colTIVAustralian) = True
                End If
            End Set
        End Property
        Private m_colTIVAustralian As Nullable(Of Long)

        Public Property colTIVBritish() As Nullable(Of Long) Implements IrowVwLocationListing.colTIVBritish
            Get
                Return m_colTIVBritish
            End Get
            Set
                If Not Same(m_colTIVBritish, Value) Then
                    m_colTIVBritish = Value
                    m_IsDirty(FieldIndex.colTIVBritish) = True
                End If
            End Set
        End Property
        Private m_colTIVBritish As Nullable(Of Long)

        Public Property colTIVCanadian() As Nullable(Of Long) Implements IrowVwLocationListing.colTIVCanadian
            Get
                Return m_colTIVCanadian
            End Get
            Set
                If Not Same(m_colTIVCanadian, Value) Then
                    m_colTIVCanadian = Value
                    m_IsDirty(FieldIndex.colTIVCanadian) = True
                End If
            End Set
        End Property
        Private m_colTIVCanadian As Nullable(Of Long)

        Public Property colTIVEuro() As Nullable(Of Long) Implements IrowVwLocationListing.colTIVEuro
            Get
                Return m_colTIVEuro
            End Get
            Set
                If Not Same(m_colTIVEuro, Value) Then
                    m_colTIVEuro = Value
                    m_IsDirty(FieldIndex.colTIVEuro) = True
                End If
            End Set
        End Property
        Private m_colTIVEuro As Nullable(Of Long)

        Public Property colTIVJapanese() As Nullable(Of Long) Implements IrowVwLocationListing.colTIVJapanese
            Get
                Return m_colTIVJapanese
            End Get
            Set
                If Not Same(m_colTIVJapanese, Value) Then
                    m_colTIVJapanese = Value
                    m_IsDirty(FieldIndex.colTIVJapanese) = True
                End If
            End Set
        End Property
        Private m_colTIVJapanese As Nullable(Of Long)

        Public Property colTIVMexican() As Nullable(Of Long) Implements IrowVwLocationListing.colTIVMexican
            Get
                Return m_colTIVMexican
            End Get
            Set
                If Not Same(m_colTIVMexican, Value) Then
                    m_colTIVMexican = Value
                    m_IsDirty(FieldIndex.colTIVMexican) = True
                End If
            End Set
        End Property
        Private m_colTIVMexican As Nullable(Of Long)

        Public Property colTIVNewZealand() As Nullable(Of Long) Implements IrowVwLocationListing.colTIVNewZealand
            Get
                Return m_colTIVNewZealand
            End Get
            Set
                If Not Same(m_colTIVNewZealand, Value) Then
                    m_colTIVNewZealand = Value
                    m_IsDirty(FieldIndex.colTIVNewZealand) = True
                End If
            End Set
        End Property
        Private m_colTIVNewZealand As Nullable(Of Long)

        Public Property colTivus() As Nullable(Of Long) Implements IrowVwLocationListing.colTivus
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
        Private m_colTivus As Nullable(Of Long)

        Public Property colHazard() As String Implements IrowVwLocationListing.colHazard
            Get
                Return m_colHazard
            End Get
            Set
                If Not Same(m_colHazard, Value) Then
                    m_colHazard = Value
                    m_IsDirty(FieldIndex.colHazard) = True
                End If
            End Set
        End Property
        Private m_colHazard As String

        Public Property colEffectiveDate() As Nullable(Of DateTime) Implements IrowVwLocationListing.colEffectiveDate
            Get
                Return m_colEffectiveDate
            End Get
            Set
                If Not Same(m_colEffectiveDate, Value) Then
                    m_colEffectiveDate = Value
                    m_IsDirty(FieldIndex.colEffectiveDate) = True
                End If
            End Set
        End Property
        Private m_colEffectiveDate As Nullable(Of DateTime)


        Public Function IsDirty(pIndex As rowVwLocationListing.FieldIndex) As Boolean Implements IrowVwLocationListing.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwLocationListing.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwLocationListing.SetIsDirty
            m_IsDirty(FieldIndex.colFilePrefix) = pDirty
            m_IsDirty(FieldIndex.colFileNo) = pDirty
            m_IsDirty(FieldIndex.colClient) = pDirty
            m_IsDirty(FieldIndex.colClientLocNo) = pDirty
            m_IsDirty(FieldIndex.colDivision) = pDirty
            m_IsDirty(FieldIndex.colCustomAccess) = pDirty
            m_IsDirty(FieldIndex.colFacility) = pDirty
            m_IsDirty(FieldIndex.colAddress1) = pDirty
            m_IsDirty(FieldIndex.colCity) = pDirty
            m_IsDirty(FieldIndex.colStProv) = pDirty
            m_IsDirty(FieldIndex.colCountry) = pDirty
            m_IsDirty(FieldIndex.colPercentUSTot) = pDirty
            m_IsDirty(FieldIndex.colTIVAustralian) = pDirty
            m_IsDirty(FieldIndex.colTIVBritish) = pDirty
            m_IsDirty(FieldIndex.colTIVCanadian) = pDirty
            m_IsDirty(FieldIndex.colTIVEuro) = pDirty
            m_IsDirty(FieldIndex.colTIVJapanese) = pDirty
            m_IsDirty(FieldIndex.colTIVMexican) = pDirty
            m_IsDirty(FieldIndex.colTIVNewZealand) = pDirty
            m_IsDirty(FieldIndex.colTivus) = pDirty
            m_IsDirty(FieldIndex.colHazard) = pDirty
            m_IsDirty(FieldIndex.colEffectiveDate) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwLocationListing) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwLocationListing
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFilePrefix  = 1
            colFileNo 
            colClient 
            colClientLocNo 
            colDivision 
            colCustomAccess 
            colFacility 
            colAddress1 
            colCity 
            colStProv 
            colCountry 
            colPercentUSTot 
            colTIVAustralian 
            colTIVBritish 
            colTIVCanadian 
            colTIVEuro 
            colTIVJapanese 
            colTIVMexican 
            colTIVNewZealand 
            colTivus 
            colHazard 
            colEffectiveDate 
        End Enum

        Private m_IsDirty(22) As Boolean

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

    Public Interface IrowVwLocationListing
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFilePrefix() As String
        Property colFileNo() As String
        Property colClient() As String
        Property colClientLocNo() As String
        Property colDivision() As String
        Property colCustomAccess() As String
        Property colFacility() As String
        Property colAddress1() As String
        Property colCity() As String
        Property colStProv() As String
        Property colCountry() As String
        Property colPercentUSTot() As Nullable(Of Double)
        Property colTIVAustralian() As Nullable(Of Long)
        Property colTIVBritish() As Nullable(Of Long)
        Property colTIVCanadian() As Nullable(Of Long)
        Property colTIVEuro() As Nullable(Of Long)
        Property colTIVJapanese() As Nullable(Of Long)
        Property colTIVMexican() As Nullable(Of Long)
        Property colTIVNewZealand() As Nullable(Of Long)
        Property colTivus() As Nullable(Of Long)
        Property colHazard() As String
        Property colEffectiveDate() As Nullable(Of DateTime)
        Function IsDirty(pIndex As rowVwLocationListing.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

