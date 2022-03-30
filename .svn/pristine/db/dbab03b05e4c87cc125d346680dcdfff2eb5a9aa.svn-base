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
    Partial Public Class VwEzyUsersFilters

        Public Shared Function LoadData() As List(Of rowVwEzyUsersFilters)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwEzyUsersFilters)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwEzyUsersFilters)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwEzyUsersFilters)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwEzyUsersFilters)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwEzyUsersFilters)
            Dim zReturn As New List(Of rowVwEzyUsersFilters)
            Dim zSQL As String = "SELECT * FROM [dbo].[vwEzyUsersFilters]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwEzyUsersFilters)

			Try
	            Dim zReturn As New List(Of rowVwEzyUsersFilters)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwEzyUsersFilters

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwEzyUsersFilters		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwEzyUsersFilters)
			If Not pReader.IsDBNull(pReader.GetOrdinal("ezyUsersID")) Then pObject.colEzyUsersID = UtilSQLServer.SafeReader.SafeReadString(pReader, "ezyUsersID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Email")) Then pObject.colEmail = UtilSQLServer.SafeReader.SafeReadString(pReader, "Email")
			If Not pReader.IsDBNull(pReader.GetOrdinal("GSafeGUID")) Then pObject.colGSafeGUID = UtilSQLServer.SafeReader.SafeReadString(pReader, "GSafeGUID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FilePrefix")) Then pObject.colFilePrefix = UtilSQLServer.SafeReader.SafeReadInt16(pReader, "FilePrefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Division")) Then pObject.colDivision = UtilSQLServer.SafeReader.SafeReadString(pReader, "Division")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Plant")) Then pObject.colPlant = UtilSQLServer.SafeReader.SafeReadString(pReader, "Plant")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CustomAccessText")) Then pObject.colCustomAccessText = UtilSQLServer.SafeReader.SafeReadString(pReader, "CustomAccessText")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ClientLocNoText")) Then pObject.colClientLocNoText = UtilSQLServer.SafeReader.SafeReadString(pReader, "ClientLocNoText")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FacilityText")) Then pObject.colFacilityText = UtilSQLServer.SafeReader.SafeReadString(pReader, "FacilityText")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CityText")) Then pObject.colCityText = UtilSQLServer.SafeReader.SafeReadString(pReader, "CityText")
			If Not pReader.IsDBNull(pReader.GetOrdinal("StProvText")) Then pObject.colStProvText = UtilSQLServer.SafeReader.SafeReadString(pReader, "StProvText")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CountryText")) Then pObject.colCountryText = UtilSQLServer.SafeReader.SafeReadString(pReader, "CountryText")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CCActive")) Then pObject.colCCActive = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "CCActive")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CityManager")) Then pObject.colCityManager = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "CityManager")
			If Not pReader.IsDBNull(pReader.GetOrdinal("StProvManager")) Then pObject.colStProvManager = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "StProvManager")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ActiveUser")) Then pObject.colActiveUser = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "ActiveUser")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CCOnly")) Then pObject.colCCOnly = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "CCOnly")
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
            Dim zSQL As String = "SELECT * FROM [dbo].[vwEzyUsersFilters]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowVwEzyUsersFilters
        Implements IrowVwEzyUsersFilters

        Public Event Loaded(pUserState As Object) Implements IrowVwEzyUsersFilters.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwEzyUsersFilters.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwEzyUsersFilters.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwEzyUsersFilters.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwEzyUsersFilters.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwEzyUsersFilters.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colEzyUsersID() As String Implements IrowVwEzyUsersFilters.colEzyUsersID
            Get
                Return m_colEzyUsersID
            End Get
            Set
                If Not Same(m_colEzyUsersID, Value) Then
                    m_colEzyUsersID = Value
                    m_IsDirty(FieldIndex.colEzyUsersID) = True
                End If
            End Set
        End Property
        Private m_colEzyUsersID As String

        Public Property colEmail() As String Implements IrowVwEzyUsersFilters.colEmail
            Get
                Return m_colEmail
            End Get
            Set
                If Not Same(m_colEmail, Value) Then
                    m_colEmail = Value
                    m_IsDirty(FieldIndex.colEmail) = True
                End If
            End Set
        End Property
        Private m_colEmail As String

        Public Property colGSafeGUID() As String Implements IrowVwEzyUsersFilters.colGSafeGUID
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

        Public Property colFilePrefix() As Nullable(Of Short) Implements IrowVwEzyUsersFilters.colFilePrefix
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
        Private m_colFilePrefix As Nullable(Of Short)

        Public Property colDivision() As String Implements IrowVwEzyUsersFilters.colDivision
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

        Public Property colPlant() As String Implements IrowVwEzyUsersFilters.colPlant
            Get
                Return m_colPlant
            End Get
            Set
                If Not Same(m_colPlant, Value) Then
                    m_colPlant = Value
                    m_IsDirty(FieldIndex.colPlant) = True
                End If
            End Set
        End Property
        Private m_colPlant As String

        Public Property colCustomAccessText() As String Implements IrowVwEzyUsersFilters.colCustomAccessText
            Get
                Return m_colCustomAccessText
            End Get
            Set
                If Not Same(m_colCustomAccessText, Value) Then
                    m_colCustomAccessText = Value
                    m_IsDirty(FieldIndex.colCustomAccessText) = True
                End If
            End Set
        End Property
        Private m_colCustomAccessText As String

        Public Property colClientLocNoText() As String Implements IrowVwEzyUsersFilters.colClientLocNoText
            Get
                Return m_colClientLocNoText
            End Get
            Set
                If Not Same(m_colClientLocNoText, Value) Then
                    m_colClientLocNoText = Value
                    m_IsDirty(FieldIndex.colClientLocNoText) = True
                End If
            End Set
        End Property
        Private m_colClientLocNoText As String

        Public Property colFacilityText() As String Implements IrowVwEzyUsersFilters.colFacilityText
            Get
                Return m_colFacilityText
            End Get
            Set
                If Not Same(m_colFacilityText, Value) Then
                    m_colFacilityText = Value
                    m_IsDirty(FieldIndex.colFacilityText) = True
                End If
            End Set
        End Property
        Private m_colFacilityText As String

        Public Property colCityText() As String Implements IrowVwEzyUsersFilters.colCityText
            Get
                Return m_colCityText
            End Get
            Set
                If Not Same(m_colCityText, Value) Then
                    m_colCityText = Value
                    m_IsDirty(FieldIndex.colCityText) = True
                End If
            End Set
        End Property
        Private m_colCityText As String

        Public Property colStProvText() As String Implements IrowVwEzyUsersFilters.colStProvText
            Get
                Return m_colStProvText
            End Get
            Set
                If Not Same(m_colStProvText, Value) Then
                    m_colStProvText = Value
                    m_IsDirty(FieldIndex.colStProvText) = True
                End If
            End Set
        End Property
        Private m_colStProvText As String

        Public Property colCountryText() As String Implements IrowVwEzyUsersFilters.colCountryText
            Get
                Return m_colCountryText
            End Get
            Set
                If Not Same(m_colCountryText, Value) Then
                    m_colCountryText = Value
                    m_IsDirty(FieldIndex.colCountryText) = True
                End If
            End Set
        End Property
        Private m_colCountryText As String

        Public Property colCCActive() As Nullable(Of Boolean) Implements IrowVwEzyUsersFilters.colCCActive
            Get
                Return m_colCCActive
            End Get
            Set
                If Not Same(m_colCCActive, Value) Then
                    m_colCCActive = Value
                    m_IsDirty(FieldIndex.colCCActive) = True
                End If
            End Set
        End Property
        Private m_colCCActive As Nullable(Of Boolean)

        Public Property colCityManager() As Nullable(Of Boolean) Implements IrowVwEzyUsersFilters.colCityManager
            Get
                Return m_colCityManager
            End Get
            Set
                If Not Same(m_colCityManager, Value) Then
                    m_colCityManager = Value
                    m_IsDirty(FieldIndex.colCityManager) = True
                End If
            End Set
        End Property
        Private m_colCityManager As Nullable(Of Boolean)

        Public Property colStProvManager() As Nullable(Of Boolean) Implements IrowVwEzyUsersFilters.colStProvManager
            Get
                Return m_colStProvManager
            End Get
            Set
                If Not Same(m_colStProvManager, Value) Then
                    m_colStProvManager = Value
                    m_IsDirty(FieldIndex.colStProvManager) = True
                End If
            End Set
        End Property
        Private m_colStProvManager As Nullable(Of Boolean)

        Public Property colActiveUser() As Nullable(Of Boolean) Implements IrowVwEzyUsersFilters.colActiveUser
            Get
                Return m_colActiveUser
            End Get
            Set
                If Not Same(m_colActiveUser, Value) Then
                    m_colActiveUser = Value
                    m_IsDirty(FieldIndex.colActiveUser) = True
                End If
            End Set
        End Property
        Private m_colActiveUser As Nullable(Of Boolean)

        Public Property colCCOnly() As Nullable(Of Boolean) Implements IrowVwEzyUsersFilters.colCCOnly
            Get
                Return m_colCCOnly
            End Get
            Set
                If Not Same(m_colCCOnly, Value) Then
                    m_colCCOnly = Value
                    m_IsDirty(FieldIndex.colCCOnly) = True
                End If
            End Set
        End Property
        Private m_colCCOnly As Nullable(Of Boolean)


        Public Function IsDirty(pIndex As rowVwEzyUsersFilters.FieldIndex) As Boolean Implements IrowVwEzyUsersFilters.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwEzyUsersFilters.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwEzyUsersFilters.SetIsDirty
            m_IsDirty(FieldIndex.colEzyUsersID) = pDirty
            m_IsDirty(FieldIndex.colEmail) = pDirty
            m_IsDirty(FieldIndex.colGSafeGUID) = pDirty
            m_IsDirty(FieldIndex.colFilePrefix) = pDirty
            m_IsDirty(FieldIndex.colDivision) = pDirty
            m_IsDirty(FieldIndex.colPlant) = pDirty
            m_IsDirty(FieldIndex.colCustomAccessText) = pDirty
            m_IsDirty(FieldIndex.colClientLocNoText) = pDirty
            m_IsDirty(FieldIndex.colFacilityText) = pDirty
            m_IsDirty(FieldIndex.colCityText) = pDirty
            m_IsDirty(FieldIndex.colStProvText) = pDirty
            m_IsDirty(FieldIndex.colCountryText) = pDirty
            m_IsDirty(FieldIndex.colCCActive) = pDirty
            m_IsDirty(FieldIndex.colCityManager) = pDirty
            m_IsDirty(FieldIndex.colStProvManager) = pDirty
            m_IsDirty(FieldIndex.colActiveUser) = pDirty
            m_IsDirty(FieldIndex.colCCOnly) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwEzyUsersFilters) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwEzyUsersFilters
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colEzyUsersID  = 1
            colEmail 
            colGSafeGUID 
            colFilePrefix 
            colDivision 
            colPlant 
            colCustomAccessText 
            colClientLocNoText 
            colFacilityText 
            colCityText 
            colStProvText 
            colCountryText 
            colCCActive 
            colCityManager 
            colStProvManager 
            colActiveUser 
            colCCOnly 
        End Enum

        Private m_IsDirty(17) As Boolean

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

    Public Interface IrowVwEzyUsersFilters
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colEzyUsersID() As String
        Property colEmail() As String
        Property colGSafeGUID() As String
        Property colFilePrefix() As Nullable(Of Short)
        Property colDivision() As String
        Property colPlant() As String
        Property colCustomAccessText() As String
        Property colClientLocNoText() As String
        Property colFacilityText() As String
        Property colCityText() As String
        Property colStProvText() As String
        Property colCountryText() As String
        Property colCCActive() As Nullable(Of Boolean)
        Property colCityManager() As Nullable(Of Boolean)
        Property colStProvManager() As Nullable(Of Boolean)
        Property colActiveUser() As Nullable(Of Boolean)
        Property colCCOnly() As Nullable(Of Boolean)
        Function IsDirty(pIndex As rowVwEzyUsersFilters.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

