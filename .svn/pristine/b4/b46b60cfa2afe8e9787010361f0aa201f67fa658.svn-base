'/===============================================================\
'| razor data (experimental) - rev 4.2.879   EXPERIMENTAL        |
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
    Partial Public Class ViewCCGRIPSSLocationsV3

        Public Shared Function LoadData() As List(Of rowViewCCGRIPSSLocationsV3)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowViewCCGRIPSSLocationsV3)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowViewCCGRIPSSLocationsV3)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowViewCCGRIPSSLocationsV3)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowViewCCGRIPSSLocationsV3)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowViewCCGRIPSSLocationsV3)
            Dim zReturn As New List(Of rowViewCCGRIPSSLocationsV3)
            Dim zSQL As String = "SELECT * FROM [dbo].[viewCCGRIPSSLocationsV3]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowViewCCGRIPSSLocationsV3)

			Try
	            Dim zReturn As New List(Of rowViewCCGRIPSSLocationsV3)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowViewCCGRIPSSLocationsV3

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowViewCCGRIPSSLocationsV3		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowViewCCGRIPSSLocationsV3)
			If Not pReader.IsDBNull(pReader.GetOrdinal("FilePrefix")) Then pObject.FilePrefix = UtilSQLServer.SafeReader.SafeReadString(pReader, "FilePrefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FileNo")) Then pObject.FileNo = UtilSQLServer.SafeReader.SafeReadString(pReader, "FileNo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Division")) Then pObject.Division = UtilSQLServer.SafeReader.SafeReadString(pReader, "Division")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CustomAccess")) Then pObject.CustomAccess = UtilSQLServer.SafeReader.SafeReadString(pReader, "CustomAccess")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ClientLocNo")) Then pObject.ClientLocNo = UtilSQLServer.SafeReader.SafeReadString(pReader, "ClientLocNo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Facility")) Then pObject.Facility = UtilSQLServer.SafeReader.SafeReadString(pReader, "Facility")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Address")) Then pObject.Address = UtilSQLServer.SafeReader.SafeReadString(pReader, "Address")
			If Not pReader.IsDBNull(pReader.GetOrdinal("City")) Then pObject.City = UtilSQLServer.SafeReader.SafeReadString(pReader, "City")
			If Not pReader.IsDBNull(pReader.GetOrdinal("StProv")) Then pObject.StProv = UtilSQLServer.SafeReader.SafeReadString(pReader, "StProv")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Country")) Then pObject.Country = UtilSQLServer.SafeReader.SafeReadString(pReader, "Country")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CityStProvCountry")) Then pObject.CityStProvCountry = UtilSQLServer.SafeReader.SafeReadString(pReader, "CityStProvCountry")
			If Not pReader.IsDBNull(pReader.GetOrdinal("StProvCountry")) Then pObject.StProvCountry = UtilSQLServer.SafeReader.SafeReadString(pReader, "StProvCountry")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Longitude")) Then pObject.Longitude = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "Longitude")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Latitude")) Then pObject.Latitude = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "Latitude")
			If Not pReader.IsDBNull(pReader.GetOrdinal("TIV")) Then pObject.Tiv = UtilSQLServer.SafeReader.SafeReadString(pReader, "TIV")
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
            Dim zSQL As String = "SELECT * FROM [dbo].[viewCCGRIPSSLocationsV3]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class

    Partial Public Class rowViewCCGRIPSSLocationsV3
        Implements IrowViewCCGRIPSSLocationsV3

        Public Event Loaded(pUserState As Object) Implements IrowViewCCGRIPSSLocationsV3.Loaded
        Public Event Saved(pUserState As Object) Implements IrowViewCCGRIPSSLocationsV3.Saved
        Public Event Deleted(pUserState As Object) Implements IrowViewCCGRIPSSLocationsV3.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowViewCCGRIPSSLocationsV3.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowViewCCGRIPSSLocationsV3.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowViewCCGRIPSSLocationsV3.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property FilePrefix() As String Implements IrowViewCCGRIPSSLocationsV3.FilePrefix
            Get
                Return m_FilePrefix
            End Get
            Set
                If Not Same(m_FilePrefix, Value) Then
                    m_FilePrefix = Value
                    m_IsDirty(FieldIndex.FilePrefix) = True
                End If
            End Set
        End Property
        Private m_FilePrefix As String

        Public Property FileNo() As String Implements IrowViewCCGRIPSSLocationsV3.FileNo
            Get
                Return m_FileNo
            End Get
            Set
                If Not Same(m_FileNo, Value) Then
                    m_FileNo = Value
                    m_IsDirty(FieldIndex.FileNo) = True
                End If
            End Set
        End Property
        Private m_FileNo As String

        Public Property Division() As String Implements IrowViewCCGRIPSSLocationsV3.Division
            Get
                Return m_Division
            End Get
            Set
                If Not Same(m_Division, Value) Then
                    m_Division = Value
                    m_IsDirty(FieldIndex.Division) = True
                End If
            End Set
        End Property
        Private m_Division As String

        Public Property CustomAccess() As String Implements IrowViewCCGRIPSSLocationsV3.CustomAccess
            Get
                Return m_CustomAccess
            End Get
            Set
                If Not Same(m_CustomAccess, Value) Then
                    m_CustomAccess = Value
                    m_IsDirty(FieldIndex.CustomAccess) = True
                End If
            End Set
        End Property
        Private m_CustomAccess As String

        Public Property ClientLocNo() As String Implements IrowViewCCGRIPSSLocationsV3.ClientLocNo
            Get
                Return m_ClientLocNo
            End Get
            Set
                If Not Same(m_ClientLocNo, Value) Then
                    m_ClientLocNo = Value
                    m_IsDirty(FieldIndex.ClientLocNo) = True
                End If
            End Set
        End Property
        Private m_ClientLocNo As String

        Public Property Facility() As String Implements IrowViewCCGRIPSSLocationsV3.Facility
            Get
                Return m_Facility
            End Get
            Set
                If Not Same(m_Facility, Value) Then
                    m_Facility = Value
                    m_IsDirty(FieldIndex.Facility) = True
                End If
            End Set
        End Property
        Private m_Facility As String

        Public Property Address() As String Implements IrowViewCCGRIPSSLocationsV3.Address
            Get
                Return m_Address
            End Get
            Set
                If Not Same(m_Address, Value) Then
                    m_Address = Value
                    m_IsDirty(FieldIndex.Address) = True
                End If
            End Set
        End Property
        Private m_Address As String

        Public Property City() As String Implements IrowViewCCGRIPSSLocationsV3.City
            Get
                Return m_City
            End Get
            Set
                If Not Same(m_City, Value) Then
                    m_City = Value
                    m_IsDirty(FieldIndex.City) = True
                End If
            End Set
        End Property
        Private m_City As String

        Public Property StProv() As String Implements IrowViewCCGRIPSSLocationsV3.StProv
            Get
                Return m_StProv
            End Get
            Set
                If Not Same(m_StProv, Value) Then
                    m_StProv = Value
                    m_IsDirty(FieldIndex.StProv) = True
                End If
            End Set
        End Property
        Private m_StProv As String

        Public Property Country() As String Implements IrowViewCCGRIPSSLocationsV3.Country
            Get
                Return m_Country
            End Get
            Set
                If Not Same(m_Country, Value) Then
                    m_Country = Value
                    m_IsDirty(FieldIndex.Country) = True
                End If
            End Set
        End Property
        Private m_Country As String

        Public Property CityStProvCountry() As String Implements IrowViewCCGRIPSSLocationsV3.CityStProvCountry
            Get
                Return m_CityStProvCountry
            End Get
            Set
                If Not Same(m_CityStProvCountry, Value) Then
                    m_CityStProvCountry = Value
                    m_IsDirty(FieldIndex.CityStProvCountry) = True
                End If
            End Set
        End Property
        Private m_CityStProvCountry As String

        Public Property StProvCountry() As String Implements IrowViewCCGRIPSSLocationsV3.StProvCountry
            Get
                Return m_StProvCountry
            End Get
            Set
                If Not Same(m_StProvCountry, Value) Then
                    m_StProvCountry = Value
                    m_IsDirty(FieldIndex.StProvCountry) = True
                End If
            End Set
        End Property
        Private m_StProvCountry As String

        Public Property Longitude() As Nullable(Of Decimal) Implements IrowViewCCGRIPSSLocationsV3.Longitude
            Get
                Return m_Longitude
            End Get
            Set
                If Not Same(m_Longitude, Value) Then
                    m_Longitude = Value
                    m_IsDirty(FieldIndex.Longitude) = True
                End If
            End Set
        End Property
        Private m_Longitude As Nullable(Of Decimal)

        Public Property Latitude() As Nullable(Of Decimal) Implements IrowViewCCGRIPSSLocationsV3.Latitude
            Get
                Return m_Latitude
            End Get
            Set
                If Not Same(m_Latitude, Value) Then
                    m_Latitude = Value
                    m_IsDirty(FieldIndex.Latitude) = True
                End If
            End Set
        End Property
        Private m_Latitude As Nullable(Of Decimal)

        Public Property Tiv() As String Implements IrowViewCCGRIPSSLocationsV3.Tiv
            Get
                Return m_Tiv
            End Get
            Set
                If Not Same(m_Tiv, Value) Then
                    m_Tiv = Value
                    m_IsDirty(FieldIndex.Tiv) = True
                End If
            End Set
        End Property
        Private m_Tiv As String


        Public Function IsDirty(pIndex As rowViewCCGRIPSSLocationsV3.FieldIndex) As Boolean Implements IrowViewCCGRIPSSLocationsV3.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowViewCCGRIPSSLocationsV3.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowViewCCGRIPSSLocationsV3.SetIsDirty
            m_IsDirty(FieldIndex.FilePrefix) = pDirty
            m_IsDirty(FieldIndex.FileNo) = pDirty
            m_IsDirty(FieldIndex.Division) = pDirty
            m_IsDirty(FieldIndex.CustomAccess) = pDirty
            m_IsDirty(FieldIndex.ClientLocNo) = pDirty
            m_IsDirty(FieldIndex.Facility) = pDirty
            m_IsDirty(FieldIndex.Address) = pDirty
            m_IsDirty(FieldIndex.City) = pDirty
            m_IsDirty(FieldIndex.StProv) = pDirty
            m_IsDirty(FieldIndex.Country) = pDirty
            m_IsDirty(FieldIndex.CityStProvCountry) = pDirty
            m_IsDirty(FieldIndex.StProvCountry) = pDirty
            m_IsDirty(FieldIndex.Longitude) = pDirty
            m_IsDirty(FieldIndex.Latitude) = pDirty
            m_IsDirty(FieldIndex.Tiv) = pDirty
        End Sub

        Public Enum FieldIndex
            FilePrefix  = 1
            FileNo 
            Division 
            CustomAccess 
            ClientLocNo 
            Facility 
            Address 
            City 
            StProv 
            Country 
            CityStProvCountry 
            StProvCountry 
            Longitude 
            Latitude 
            Tiv 
        End Enum

        Private m_IsDirty(15) As Boolean

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

    Public Interface IrowViewCCGRIPSSLocationsV3
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property FilePrefix() As String
        Property FileNo() As String
        Property Division() As String
        Property CustomAccess() As String
        Property ClientLocNo() As String
        Property Facility() As String
        Property Address() As String
        Property City() As String
        Property StProv() As String
        Property Country() As String
        Property CityStProvCountry() As String
        Property StProvCountry() As String
        Property Longitude() As Nullable(Of Decimal)
        Property Latitude() As Nullable(Of Decimal)
        Property Tiv() As String
        Function IsDirty(pIndex As rowViewCCGRIPSSLocationsV3.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

