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
    Partial Public Class ViewCCUserSecureLocationsV2

        Public Shared Function LoadData() As List(Of rowViewCCUserSecureLocationsV2)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowViewCCUserSecureLocationsV2)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowViewCCUserSecureLocationsV2)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowViewCCUserSecureLocationsV2)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowViewCCUserSecureLocationsV2)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowViewCCUserSecureLocationsV2)
            Dim zReturn As New List(Of rowViewCCUserSecureLocationsV2)
            Dim zSQL As String = "SELECT * FROM [dbo].[viewCCUserSecureLocationsV2]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowViewCCUserSecureLocationsV2)

			Try
	            Dim zReturn As New List(Of rowViewCCUserSecureLocationsV2)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowViewCCUserSecureLocationsV2

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowViewCCUserSecureLocationsV2		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowViewCCUserSecureLocationsV2)
			If Not pReader.IsDBNull(pReader.GetOrdinal("GSafeId")) Then pObject.colGSafeId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "GSafeId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("GSafeGUID")) Then pObject.colGSafeGUID = UtilSQLServer.SafeReader.SafeReadString(pReader, "GSafeGUID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FilePrefix")) Then pObject.colFilePrefix = UtilSQLServer.SafeReader.SafeReadString(pReader, "FilePrefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FileNo")) Then pObject.colFileNo = UtilSQLServer.SafeReader.SafeReadString(pReader, "FileNo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Division")) Then pObject.colDivision = UtilSQLServer.SafeReader.SafeReadString(pReader, "Division")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CustomAccess")) Then pObject.colCustomAccess = UtilSQLServer.SafeReader.SafeReadString(pReader, "CustomAccess")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ClientLocNo")) Then pObject.colClientLocNo = UtilSQLServer.SafeReader.SafeReadString(pReader, "ClientLocNo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Facility")) Then pObject.colFacility = UtilSQLServer.SafeReader.SafeReadString(pReader, "Facility")
			If Not pReader.IsDBNull(pReader.GetOrdinal("City")) Then pObject.colCity = UtilSQLServer.SafeReader.SafeReadString(pReader, "City")
			If Not pReader.IsDBNull(pReader.GetOrdinal("StProv")) Then pObject.colStProv = UtilSQLServer.SafeReader.SafeReadString(pReader, "StProv")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Country")) Then pObject.colCountry = UtilSQLServer.SafeReader.SafeReadString(pReader, "Country")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CityStProvCountry")) Then pObject.colCityStProvCountry = UtilSQLServer.SafeReader.SafeReadString(pReader, "CityStProvCountry")
			If Not pReader.IsDBNull(pReader.GetOrdinal("StProvCountry")) Then pObject.colStProvCountry = UtilSQLServer.SafeReader.SafeReadString(pReader, "StProvCountry")
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
            Dim zSQL As String = "SELECT * FROM [dbo].[viewCCUserSecureLocationsV2]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowViewCCUserSecureLocationsV2
        Implements IrowViewCCUserSecureLocationsV2

        Public Event Loaded(pUserState As Object) Implements IrowViewCCUserSecureLocationsV2.Loaded
        Public Event Saved(pUserState As Object) Implements IrowViewCCUserSecureLocationsV2.Saved
        Public Event Deleted(pUserState As Object) Implements IrowViewCCUserSecureLocationsV2.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowViewCCUserSecureLocationsV2.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowViewCCUserSecureLocationsV2.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowViewCCUserSecureLocationsV2.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colGSafeId() As Nullable(Of Integer) Implements IrowViewCCUserSecureLocationsV2.colGSafeId
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

        Public Property colGSafeGUID() As String Implements IrowViewCCUserSecureLocationsV2.colGSafeGUID
            Get
                Return m_colGSafeGUID
            End Get
            Set
                If Not Same(m_colGSafeGUID, Value) Then
                    m_colGSafeGUID = Value
                    m_IsDirty(FieldIndex.colGSafeGUID) = True
                End If
            End Set
        End Property
        Private m_colGSafeGUID As String

        Public Property colFilePrefix() As String Implements IrowViewCCUserSecureLocationsV2.colFilePrefix
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

        Public Property colFileNo() As String Implements IrowViewCCUserSecureLocationsV2.colFileNo
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

        Public Property colDivision() As String Implements IrowViewCCUserSecureLocationsV2.colDivision
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

        Public Property colCustomAccess() As String Implements IrowViewCCUserSecureLocationsV2.colCustomAccess
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

        Public Property colClientLocNo() As String Implements IrowViewCCUserSecureLocationsV2.colClientLocNo
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

        Public Property colFacility() As String Implements IrowViewCCUserSecureLocationsV2.colFacility
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

        Public Property colCity() As String Implements IrowViewCCUserSecureLocationsV2.colCity
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

        Public Property colStProv() As String Implements IrowViewCCUserSecureLocationsV2.colStProv
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

        Public Property colCountry() As String Implements IrowViewCCUserSecureLocationsV2.colCountry
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

        Public Property colCityStProvCountry() As String Implements IrowViewCCUserSecureLocationsV2.colCityStProvCountry
            Get
                Return m_colCityStProvCountry
            End Get
            Set
                If Not Same(m_colCityStProvCountry, Value) Then
                    m_colCityStProvCountry = Value
                    m_IsDirty(FieldIndex.colCityStProvCountry) = True
                End If
            End Set
        End Property
        Private m_colCityStProvCountry As String

        Public Property colStProvCountry() As String Implements IrowViewCCUserSecureLocationsV2.colStProvCountry
            Get
                Return m_colStProvCountry
            End Get
            Set
                If Not Same(m_colStProvCountry, Value) Then
                    m_colStProvCountry = Value
                    m_IsDirty(FieldIndex.colStProvCountry) = True
                End If
            End Set
        End Property
        Private m_colStProvCountry As String


        Public Function IsDirty(pIndex As rowViewCCUserSecureLocationsV2.FieldIndex) As Boolean Implements IrowViewCCUserSecureLocationsV2.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowViewCCUserSecureLocationsV2.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowViewCCUserSecureLocationsV2.SetIsDirty
            m_IsDirty(FieldIndex.colGSafeId) = pDirty
            m_IsDirty(FieldIndex.colGSafeGUID) = pDirty
            m_IsDirty(FieldIndex.colFilePrefix) = pDirty
            m_IsDirty(FieldIndex.colFileNo) = pDirty
            m_IsDirty(FieldIndex.colDivision) = pDirty
            m_IsDirty(FieldIndex.colCustomAccess) = pDirty
            m_IsDirty(FieldIndex.colClientLocNo) = pDirty
            m_IsDirty(FieldIndex.colFacility) = pDirty
            m_IsDirty(FieldIndex.colCity) = pDirty
            m_IsDirty(FieldIndex.colStProv) = pDirty
            m_IsDirty(FieldIndex.colCountry) = pDirty
            m_IsDirty(FieldIndex.colCityStProvCountry) = pDirty
            m_IsDirty(FieldIndex.colStProvCountry) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (ViewCCUserSecureLocationsV2) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New ViewCCUserSecureLocationsV2
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colGSafeId  = 1
            colGSafeGUID 
            colFilePrefix 
            colFileNo 
            colDivision 
            colCustomAccess 
            colClientLocNo 
            colFacility 
            colCity 
            colStProv 
            colCountry 
            colCityStProvCountry 
            colStProvCountry 
        End Enum

        Private m_IsDirty(13) As Boolean

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

    Public Interface IrowViewCCUserSecureLocationsV2
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colGSafeId() As Nullable(Of Integer)
        Property colGSafeGUID() As String
        Property colFilePrefix() As String
        Property colFileNo() As String
        Property colDivision() As String
        Property colCustomAccess() As String
        Property colClientLocNo() As String
        Property colFacility() As String
        Property colCity() As String
        Property colStProv() As String
        Property colCountry() As String
        Property colCityStProvCountry() As String
        Property colStProvCountry() As String
        Function IsDirty(pIndex As rowViewCCUserSecureLocationsV2.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

