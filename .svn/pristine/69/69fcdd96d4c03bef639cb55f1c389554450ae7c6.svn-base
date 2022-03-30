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
    Partial Public Class ViewCCUserActivityGridV2

        Public Shared Function LoadData() As List(Of rowViewCCUserActivityGridV2)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowViewCCUserActivityGridV2)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowViewCCUserActivityGridV2)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowViewCCUserActivityGridV2)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowViewCCUserActivityGridV2)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowViewCCUserActivityGridV2)
            Dim zReturn As New List(Of rowViewCCUserActivityGridV2)
            Dim zSQL As String = "SELECT * FROM [dbo].[viewCCUserActivityGridV2]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowViewCCUserActivityGridV2)

			Try
	            Dim zReturn As New List(Of rowViewCCUserActivityGridV2)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowViewCCUserActivityGridV2

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowViewCCUserActivityGridV2		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowViewCCUserActivityGridV2)
			If Not pReader.IsDBNull(pReader.GetOrdinal("LoginID")) Then pObject.colLoginID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "LoginID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("EmailAddress")) Then pObject.colEmailAddress = UtilSQLServer.SafeReader.SafeReadString(pReader, "EmailAddress")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ActiveFlag")) Then pObject.colActiveFlag = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "ActiveFlag")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LoginGuid")) Then pObject.colLoginGuid = UtilSQLServer.SafeReader.SafeReadString(pReader, "LoginGuid")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FullName")) Then pObject.colFullName = UtilSQLServer.SafeReader.SafeReadString(pReader, "FullName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("UserID")) Then pObject.colUserID = UtilSQLServer.SafeReader.SafeReadString(pReader, "UserID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Password")) Then pObject.colPassword = UtilSQLServer.SafeReader.SafeReadString(pReader, "Password")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RiskManager")) Then pObject.colRiskManager = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "RiskManager")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DivisionManager")) Then pObject.colDivisionManager = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "DivisionManager")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Division")) Then pObject.colDivision = UtilSQLServer.SafeReader.SafeReadString(pReader, "Division")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PlantManager")) Then pObject.colPlantManager = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "PlantManager")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Plant")) Then pObject.colPlant = UtilSQLServer.SafeReader.SafeReadString(pReader, "Plant")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Administrator")) Then pObject.colAdministrator = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "Administrator")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DocumentAccess")) Then pObject.colDocumentAccess = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "DocumentAccess")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CustomAccess")) Then pObject.colCustomAccess = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "CustomAccess")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CustomAccessText")) Then pObject.colCustomAccessText = UtilSQLServer.SafeReader.SafeReadString(pReader, "CustomAccessText")
			If Not pReader.IsDBNull(pReader.GetOrdinal("OperatorStamp")) Then pObject.colOperatorStamp = UtilSQLServer.SafeReader.SafeReadString(pReader, "OperatorStamp")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DateTimeStamp")) Then pObject.colDateTimeStamp = UtilSQLServer.SafeReader.SafeReadString(pReader, "DateTimeStamp")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Phone")) Then pObject.colPhone = UtilSQLServer.SafeReader.SafeReadString(pReader, "Phone")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Fax")) Then pObject.colFax = UtilSQLServer.SafeReader.SafeReadString(pReader, "Fax")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Email")) Then pObject.colEmail = UtilSQLServer.SafeReader.SafeReadString(pReader, "Email")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NotificationStamp")) Then pObject.colNotificationStamp = UtilSQLServer.SafeReader.SafeReadString(pReader, "NotificationStamp")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ActiveUser")) Then pObject.colActiveUser = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "ActiveUser")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FilePrefix")) Then pObject.colFilePrefix = UtilSQLServer.SafeReader.SafeReadString(pReader, "FilePrefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LastLogin")) Then pObject.colLastLogin = UtilSQLServer.SafeReader.SafeReadString(pReader, "LastLogin")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LastPWChange")) Then pObject.colLastPWChange = UtilSQLServer.SafeReader.SafeReadString(pReader, "LastPWChange")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Internal")) Then pObject.colInternal = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "Internal")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Comments")) Then pObject.colComments = UtilSQLServer.SafeReader.SafeReadString(pReader, "Comments")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RInit")) Then pObject.colRInit = UtilSQLServer.SafeReader.SafeReadString(pReader, "RInit")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Rfu1")) Then pObject.colRfu1 = UtilSQLServer.SafeReader.SafeReadString(pReader, "Rfu1")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Rfu2")) Then pObject.colRfu2 = UtilSQLServer.SafeReader.SafeReadString(pReader, "Rfu2")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Rfu3")) Then pObject.colRfu3 = UtilSQLServer.SafeReader.SafeReadString(pReader, "Rfu3")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RReport")) Then pObject.colRReport = UtilSQLServer.SafeReader.SafeReadString(pReader, "RReport")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ROverdue1")) Then pObject.colROverdue1 = UtilSQLServer.SafeReader.SafeReadString(pReader, "ROverdue1")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ROverdue2")) Then pObject.colROverdue2 = UtilSQLServer.SafeReader.SafeReadString(pReader, "ROverdue2")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ROverdue3")) Then pObject.colROverdue3 = UtilSQLServer.SafeReader.SafeReadString(pReader, "ROverdue3")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RActResp")) Then pObject.colRActResp = UtilSQLServer.SafeReader.SafeReadString(pReader, "RActResp")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ExpOverdue")) Then pObject.colExpOverdue = UtilSQLServer.SafeReader.SafeReadString(pReader, "ExpOverdue")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Wo")) Then pObject.colWo = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "Wo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CCActive")) Then pObject.colCCActive = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "CCActive")
			If Not pReader.IsDBNull(pReader.GetOrdinal("calist")) Then pObject.colCalist = UtilSQLServer.SafeReader.SafeReadString(pReader, "calist")
			If Not pReader.IsDBNull(pReader.GetOrdinal("divlist")) Then pObject.colDivlist = UtilSQLServer.SafeReader.SafeReadString(pReader, "divlist")
			If Not pReader.IsDBNull(pReader.GetOrdinal("loclist")) Then pObject.colLoclist = UtilSQLServer.SafeReader.SafeReadString(pReader, "loclist")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ThirdParty ")) Then pObject.colThirdparty = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "ThirdParty ")
			If Not pReader.IsDBNull(pReader.GetOrdinal("GRCAdministrator ")) Then pObject.colGrcadministrator = UtilSQLServer.SafeReader.SafeReadString(pReader, "GRCAdministrator ")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LastRecentUpdate ")) Then pObject.colLastrecentupdate = UtilSQLServer.SafeReader.SafeReadString(pReader, "LastRecentUpdate ")
			If Not pReader.IsDBNull(pReader.GetOrdinal("EzyUserID")) Then pObject.colEzyUserID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "EzyUserID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("IsAMorAE")) Then pObject.colIsAMorAE = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "IsAMorAE")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CCOnly")) Then pObject.colCCOnly = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "CCOnly")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FacilityManager")) Then pObject.colFacilityManager = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "FacilityManager")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FacilityText")) Then pObject.colFacilityText = UtilSQLServer.SafeReader.SafeReadString(pReader, "FacilityText")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ClientLocNoManager")) Then pObject.colClientLocNoManager = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "ClientLocNoManager")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ClientLocNoText")) Then pObject.colClientLocNoText = UtilSQLServer.SafeReader.SafeReadString(pReader, "ClientLocNoText")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CityManager")) Then pObject.colCityManager = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "CityManager")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CityText")) Then pObject.colCityText = UtilSQLServer.SafeReader.SafeReadString(pReader, "CityText")
			If Not pReader.IsDBNull(pReader.GetOrdinal("StProvManager")) Then pObject.colStProvManager = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "StProvManager")
			If Not pReader.IsDBNull(pReader.GetOrdinal("StProvText")) Then pObject.colStProvText = UtilSQLServer.SafeReader.SafeReadString(pReader, "StProvText")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CountryManager")) Then pObject.colCountryManager = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "CountryManager")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CountryText")) Then pObject.colCountryText = UtilSQLServer.SafeReader.SafeReadString(pReader, "CountryText")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RExpd")) Then pObject.colRExpd = UtilSQLServer.SafeReader.SafeReadString(pReader, "RExpd")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ClientAdministration")) Then pObject.colClientAdministration = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "ClientAdministration")
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
            Dim zSQL As String = "SELECT * FROM [dbo].[viewCCUserActivityGridV2]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowViewCCUserActivityGridV2
        Implements IrowViewCCUserActivityGridV2

        Public Event Loaded(pUserState As Object) Implements IrowViewCCUserActivityGridV2.Loaded
        Public Event Saved(pUserState As Object) Implements IrowViewCCUserActivityGridV2.Saved
        Public Event Deleted(pUserState As Object) Implements IrowViewCCUserActivityGridV2.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowViewCCUserActivityGridV2.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowViewCCUserActivityGridV2.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowViewCCUserActivityGridV2.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colLoginID() As Nullable(Of Integer) Implements IrowViewCCUserActivityGridV2.colLoginID
            Get
                Return m_colLoginID
            End Get
            Set
                If Not Same(m_colLoginID, Value) Then
                    m_colLoginID = Value
                    m_IsDirty(FieldIndex.colLoginID) = True
                End If
            End Set
        End Property
        Private m_colLoginID As Nullable(Of Integer)

        Public Property colEmailAddress() As String Implements IrowViewCCUserActivityGridV2.colEmailAddress
            Get
                Return m_colEmailAddress
            End Get
            Set
                If Not Same(m_colEmailAddress, Value) Then
                    m_colEmailAddress = Value
                    m_IsDirty(FieldIndex.colEmailAddress) = True
                End If
            End Set
        End Property
        Private m_colEmailAddress As String

        Public Property colActiveFlag() As Nullable(Of Boolean) Implements IrowViewCCUserActivityGridV2.colActiveFlag
            Get
                Return m_colActiveFlag
            End Get
            Set
                If Not Same(m_colActiveFlag, Value) Then
                    m_colActiveFlag = Value
                    m_IsDirty(FieldIndex.colActiveFlag) = True
                End If
            End Set
        End Property
        Private m_colActiveFlag As Nullable(Of Boolean)

        Public Property colLoginGuid() As String Implements IrowViewCCUserActivityGridV2.colLoginGuid
            Get
                Return m_colLoginGuid
            End Get
            Set
                If Not Same(m_colLoginGuid, Value) Then
                    m_colLoginGuid = Value
                    m_IsDirty(FieldIndex.colLoginGuid) = True
                End If
            End Set
        End Property
        Private m_colLoginGuid As String

        Public Property colFullName() As String Implements IrowViewCCUserActivityGridV2.colFullName
            Get
                Return m_colFullName
            End Get
            Set
                If Not Same(m_colFullName, Value) Then
                    m_colFullName = Value
                    m_IsDirty(FieldIndex.colFullName) = True
                End If
            End Set
        End Property
        Private m_colFullName As String

        Public Property colUserID() As String Implements IrowViewCCUserActivityGridV2.colUserID
            Get
                Return m_colUserID
            End Get
            Set
                If Not Same(m_colUserID, Value) Then
                    m_colUserID = Value
                    m_IsDirty(FieldIndex.colUserID) = True
                End If
            End Set
        End Property
        Private m_colUserID As String

        Public Property colPassword() As String Implements IrowViewCCUserActivityGridV2.colPassword
            Get
                Return m_colPassword
            End Get
            Set
                If Not Same(m_colPassword, Value) Then
                    m_colPassword = Value
                    m_IsDirty(FieldIndex.colPassword) = True
                End If
            End Set
        End Property
        Private m_colPassword As String

        Public Property colRiskManager() As Nullable(Of Boolean) Implements IrowViewCCUserActivityGridV2.colRiskManager
            Get
                Return m_colRiskManager
            End Get
            Set
                If Not Same(m_colRiskManager, Value) Then
                    m_colRiskManager = Value
                    m_IsDirty(FieldIndex.colRiskManager) = True
                End If
            End Set
        End Property
        Private m_colRiskManager As Nullable(Of Boolean)

        Public Property colDivisionManager() As Nullable(Of Boolean) Implements IrowViewCCUserActivityGridV2.colDivisionManager
            Get
                Return m_colDivisionManager
            End Get
            Set
                If Not Same(m_colDivisionManager, Value) Then
                    m_colDivisionManager = Value
                    m_IsDirty(FieldIndex.colDivisionManager) = True
                End If
            End Set
        End Property
        Private m_colDivisionManager As Nullable(Of Boolean)

        Public Property colDivision() As String Implements IrowViewCCUserActivityGridV2.colDivision
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

        Public Property colPlantManager() As Nullable(Of Boolean) Implements IrowViewCCUserActivityGridV2.colPlantManager
            Get
                Return m_colPlantManager
            End Get
            Set
                If Not Same(m_colPlantManager, Value) Then
                    m_colPlantManager = Value
                    m_IsDirty(FieldIndex.colPlantManager) = True
                End If
            End Set
        End Property
        Private m_colPlantManager As Nullable(Of Boolean)

        Public Property colPlant() As String Implements IrowViewCCUserActivityGridV2.colPlant
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

        Public Property colAdministrator() As Nullable(Of Boolean) Implements IrowViewCCUserActivityGridV2.colAdministrator
            Get
                Return m_colAdministrator
            End Get
            Set
                If Not Same(m_colAdministrator, Value) Then
                    m_colAdministrator = Value
                    m_IsDirty(FieldIndex.colAdministrator) = True
                End If
            End Set
        End Property
        Private m_colAdministrator As Nullable(Of Boolean)

        Public Property colDocumentAccess() As Nullable(Of Boolean) Implements IrowViewCCUserActivityGridV2.colDocumentAccess
            Get
                Return m_colDocumentAccess
            End Get
            Set
                If Not Same(m_colDocumentAccess, Value) Then
                    m_colDocumentAccess = Value
                    m_IsDirty(FieldIndex.colDocumentAccess) = True
                End If
            End Set
        End Property
        Private m_colDocumentAccess As Nullable(Of Boolean)

        Public Property colCustomAccess() As Nullable(Of Boolean) Implements IrowViewCCUserActivityGridV2.colCustomAccess
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
        Private m_colCustomAccess As Nullable(Of Boolean)

        Public Property colCustomAccessText() As String Implements IrowViewCCUserActivityGridV2.colCustomAccessText
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

        Public Property colOperatorStamp() As String Implements IrowViewCCUserActivityGridV2.colOperatorStamp
            Get
                Return m_colOperatorStamp
            End Get
            Set
                If Not Same(m_colOperatorStamp, Value) Then
                    m_colOperatorStamp = Value
                    m_IsDirty(FieldIndex.colOperatorStamp) = True
                End If
            End Set
        End Property
        Private m_colOperatorStamp As String

        Public Property colDateTimeStamp() As String Implements IrowViewCCUserActivityGridV2.colDateTimeStamp
            Get
                Return m_colDateTimeStamp
            End Get
            Set
                If Not Same(m_colDateTimeStamp, Value) Then
                    m_colDateTimeStamp = Value
                    m_IsDirty(FieldIndex.colDateTimeStamp) = True
                End If
            End Set
        End Property
        Private m_colDateTimeStamp As String

        Public Property colPhone() As String Implements IrowViewCCUserActivityGridV2.colPhone
            Get
                Return m_colPhone
            End Get
            Set
                If Not Same(m_colPhone, Value) Then
                    m_colPhone = Value
                    m_IsDirty(FieldIndex.colPhone) = True
                End If
            End Set
        End Property
        Private m_colPhone As String

        Public Property colFax() As String Implements IrowViewCCUserActivityGridV2.colFax
            Get
                Return m_colFax
            End Get
            Set
                If Not Same(m_colFax, Value) Then
                    m_colFax = Value
                    m_IsDirty(FieldIndex.colFax) = True
                End If
            End Set
        End Property
        Private m_colFax As String

        Public Property colEmail() As String Implements IrowViewCCUserActivityGridV2.colEmail
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

        Public Property colNotificationStamp() As String Implements IrowViewCCUserActivityGridV2.colNotificationStamp
            Get
                Return m_colNotificationStamp
            End Get
            Set
                If Not Same(m_colNotificationStamp, Value) Then
                    m_colNotificationStamp = Value
                    m_IsDirty(FieldIndex.colNotificationStamp) = True
                End If
            End Set
        End Property
        Private m_colNotificationStamp As String

        Public Property colActiveUser() As Nullable(Of Boolean) Implements IrowViewCCUserActivityGridV2.colActiveUser
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

        Public Property colFilePrefix() As String Implements IrowViewCCUserActivityGridV2.colFilePrefix
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

        Public Property colLastLogin() As String Implements IrowViewCCUserActivityGridV2.colLastLogin
            Get
                Return m_colLastLogin
            End Get
            Set
                If Not Same(m_colLastLogin, Value) Then
                    m_colLastLogin = Value
                    m_IsDirty(FieldIndex.colLastLogin) = True
                End If
            End Set
        End Property
        Private m_colLastLogin As String

        Public Property colLastPWChange() As String Implements IrowViewCCUserActivityGridV2.colLastPWChange
            Get
                Return m_colLastPWChange
            End Get
            Set
                If Not Same(m_colLastPWChange, Value) Then
                    m_colLastPWChange = Value
                    m_IsDirty(FieldIndex.colLastPWChange) = True
                End If
            End Set
        End Property
        Private m_colLastPWChange As String

        Public Property colInternal() As Nullable(Of Boolean) Implements IrowViewCCUserActivityGridV2.colInternal
            Get
                Return m_colInternal
            End Get
            Set
                If Not Same(m_colInternal, Value) Then
                    m_colInternal = Value
                    m_IsDirty(FieldIndex.colInternal) = True
                End If
            End Set
        End Property
        Private m_colInternal As Nullable(Of Boolean)

        Public Property colComments() As String Implements IrowViewCCUserActivityGridV2.colComments
            Get
                Return m_colComments
            End Get
            Set
                If Not Same(m_colComments, Value) Then
                    m_colComments = Value
                    m_IsDirty(FieldIndex.colComments) = True
                End If
            End Set
        End Property
        Private m_colComments As String

        Public Property colRInit() As String Implements IrowViewCCUserActivityGridV2.colRInit
            Get
                Return m_colRInit
            End Get
            Set
                If Not Same(m_colRInit, Value) Then
                    m_colRInit = Value
                    m_IsDirty(FieldIndex.colRInit) = True
                End If
            End Set
        End Property
        Private m_colRInit As String

        Public Property colRfu1() As String Implements IrowViewCCUserActivityGridV2.colRfu1
            Get
                Return m_colRfu1
            End Get
            Set
                If Not Same(m_colRfu1, Value) Then
                    m_colRfu1 = Value
                    m_IsDirty(FieldIndex.colRfu1) = True
                End If
            End Set
        End Property
        Private m_colRfu1 As String

        Public Property colRfu2() As String Implements IrowViewCCUserActivityGridV2.colRfu2
            Get
                Return m_colRfu2
            End Get
            Set
                If Not Same(m_colRfu2, Value) Then
                    m_colRfu2 = Value
                    m_IsDirty(FieldIndex.colRfu2) = True
                End If
            End Set
        End Property
        Private m_colRfu2 As String

        Public Property colRfu3() As String Implements IrowViewCCUserActivityGridV2.colRfu3
            Get
                Return m_colRfu3
            End Get
            Set
                If Not Same(m_colRfu3, Value) Then
                    m_colRfu3 = Value
                    m_IsDirty(FieldIndex.colRfu3) = True
                End If
            End Set
        End Property
        Private m_colRfu3 As String

        Public Property colRReport() As String Implements IrowViewCCUserActivityGridV2.colRReport
            Get
                Return m_colRReport
            End Get
            Set
                If Not Same(m_colRReport, Value) Then
                    m_colRReport = Value
                    m_IsDirty(FieldIndex.colRReport) = True
                End If
            End Set
        End Property
        Private m_colRReport As String

        Public Property colROverdue1() As String Implements IrowViewCCUserActivityGridV2.colROverdue1
            Get
                Return m_colROverdue1
            End Get
            Set
                If Not Same(m_colROverdue1, Value) Then
                    m_colROverdue1 = Value
                    m_IsDirty(FieldIndex.colROverdue1) = True
                End If
            End Set
        End Property
        Private m_colROverdue1 As String

        Public Property colROverdue2() As String Implements IrowViewCCUserActivityGridV2.colROverdue2
            Get
                Return m_colROverdue2
            End Get
            Set
                If Not Same(m_colROverdue2, Value) Then
                    m_colROverdue2 = Value
                    m_IsDirty(FieldIndex.colROverdue2) = True
                End If
            End Set
        End Property
        Private m_colROverdue2 As String

        Public Property colROverdue3() As String Implements IrowViewCCUserActivityGridV2.colROverdue3
            Get
                Return m_colROverdue3
            End Get
            Set
                If Not Same(m_colROverdue3, Value) Then
                    m_colROverdue3 = Value
                    m_IsDirty(FieldIndex.colROverdue3) = True
                End If
            End Set
        End Property
        Private m_colROverdue3 As String

        Public Property colRActResp() As String Implements IrowViewCCUserActivityGridV2.colRActResp
            Get
                Return m_colRActResp
            End Get
            Set
                If Not Same(m_colRActResp, Value) Then
                    m_colRActResp = Value
                    m_IsDirty(FieldIndex.colRActResp) = True
                End If
            End Set
        End Property
        Private m_colRActResp As String

        Public Property colExpOverdue() As String Implements IrowViewCCUserActivityGridV2.colExpOverdue
            Get
                Return m_colExpOverdue
            End Get
            Set
                If Not Same(m_colExpOverdue, Value) Then
                    m_colExpOverdue = Value
                    m_IsDirty(FieldIndex.colExpOverdue) = True
                End If
            End Set
        End Property
        Private m_colExpOverdue As String

        Public Property colWo() As Nullable(Of Boolean) Implements IrowViewCCUserActivityGridV2.colWo
            Get
                Return m_colWo
            End Get
            Set
                If Not Same(m_colWo, Value) Then
                    m_colWo = Value
                    m_IsDirty(FieldIndex.colWo) = True
                End If
            End Set
        End Property
        Private m_colWo As Nullable(Of Boolean)

        Public Property colCCActive() As Nullable(Of Boolean) Implements IrowViewCCUserActivityGridV2.colCCActive
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

        Public Property colCalist() As String Implements IrowViewCCUserActivityGridV2.colCalist
            Get
                Return m_colCalist
            End Get
            Set
                If Not Same(m_colCalist, Value) Then
                    m_colCalist = Value
                    m_IsDirty(FieldIndex.colCalist) = True
                End If
            End Set
        End Property
        Private m_colCalist As String

        Public Property colDivlist() As String Implements IrowViewCCUserActivityGridV2.colDivlist
            Get
                Return m_colDivlist
            End Get
            Set
                If Not Same(m_colDivlist, Value) Then
                    m_colDivlist = Value
                    m_IsDirty(FieldIndex.colDivlist) = True
                End If
            End Set
        End Property
        Private m_colDivlist As String

        Public Property colLoclist() As String Implements IrowViewCCUserActivityGridV2.colLoclist
            Get
                Return m_colLoclist
            End Get
            Set
                If Not Same(m_colLoclist, Value) Then
                    m_colLoclist = Value
                    m_IsDirty(FieldIndex.colLoclist) = True
                End If
            End Set
        End Property
        Private m_colLoclist As String

        Public Property colThirdparty() As Nullable(Of Boolean) Implements IrowViewCCUserActivityGridV2.colThirdparty
            Get
                Return m_colThirdparty
            End Get
            Set
                If Not Same(m_colThirdparty, Value) Then
                    m_colThirdparty = Value
                    m_IsDirty(FieldIndex.colThirdparty) = True
                End If
            End Set
        End Property
        Private m_colThirdparty As Nullable(Of Boolean)

        Public Property colGrcadministrator() As String Implements IrowViewCCUserActivityGridV2.colGrcadministrator
            Get
                Return m_colGrcadministrator
            End Get
            Set
                If Not Same(m_colGrcadministrator, Value) Then
                    m_colGrcadministrator = Value
                    m_IsDirty(FieldIndex.colGrcadministrator) = True
                End If
            End Set
        End Property
        Private m_colGrcadministrator As String

        Public Property colLastrecentupdate() As String Implements IrowViewCCUserActivityGridV2.colLastrecentupdate
            Get
                Return m_colLastrecentupdate
            End Get
            Set
                If Not Same(m_colLastrecentupdate, Value) Then
                    m_colLastrecentupdate = Value
                    m_IsDirty(FieldIndex.colLastrecentupdate) = True
                End If
            End Set
        End Property
        Private m_colLastrecentupdate As String

        Public Property colEzyUserID() As Nullable(Of Integer) Implements IrowViewCCUserActivityGridV2.colEzyUserID
            Get
                Return m_colEzyUserID
            End Get
            Set
                If Not Same(m_colEzyUserID, Value) Then
                    m_colEzyUserID = Value
                    m_IsDirty(FieldIndex.colEzyUserID) = True
                End If
            End Set
        End Property
        Private m_colEzyUserID As Nullable(Of Integer)

        Public Property colIsAMorAE() As Nullable(Of Boolean) Implements IrowViewCCUserActivityGridV2.colIsAMorAE
            Get
                Return m_colIsAMorAE
            End Get
            Set
                If Not Same(m_colIsAMorAE, Value) Then
                    m_colIsAMorAE = Value
                    m_IsDirty(FieldIndex.colIsAMorAE) = True
                End If
            End Set
        End Property
        Private m_colIsAMorAE As Nullable(Of Boolean)

        Public Property colCCOnly() As Nullable(Of Boolean) Implements IrowViewCCUserActivityGridV2.colCCOnly
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

        Public Property colFacilityManager() As Nullable(Of Boolean) Implements IrowViewCCUserActivityGridV2.colFacilityManager
            Get
                Return m_colFacilityManager
            End Get
            Set
                If Not Same(m_colFacilityManager, Value) Then
                    m_colFacilityManager = Value
                    m_IsDirty(FieldIndex.colFacilityManager) = True
                End If
            End Set
        End Property
        Private m_colFacilityManager As Nullable(Of Boolean)

        Public Property colFacilityText() As String Implements IrowViewCCUserActivityGridV2.colFacilityText
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

        Public Property colClientLocNoManager() As Nullable(Of Boolean) Implements IrowViewCCUserActivityGridV2.colClientLocNoManager
            Get
                Return m_colClientLocNoManager
            End Get
            Set
                If Not Same(m_colClientLocNoManager, Value) Then
                    m_colClientLocNoManager = Value
                    m_IsDirty(FieldIndex.colClientLocNoManager) = True
                End If
            End Set
        End Property
        Private m_colClientLocNoManager As Nullable(Of Boolean)

        Public Property colClientLocNoText() As String Implements IrowViewCCUserActivityGridV2.colClientLocNoText
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

        Public Property colCityManager() As Nullable(Of Boolean) Implements IrowViewCCUserActivityGridV2.colCityManager
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

        Public Property colCityText() As String Implements IrowViewCCUserActivityGridV2.colCityText
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

        Public Property colStProvManager() As Nullable(Of Boolean) Implements IrowViewCCUserActivityGridV2.colStProvManager
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

        Public Property colStProvText() As String Implements IrowViewCCUserActivityGridV2.colStProvText
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

        Public Property colCountryManager() As Nullable(Of Boolean) Implements IrowViewCCUserActivityGridV2.colCountryManager
            Get
                Return m_colCountryManager
            End Get
            Set
                If Not Same(m_colCountryManager, Value) Then
                    m_colCountryManager = Value
                    m_IsDirty(FieldIndex.colCountryManager) = True
                End If
            End Set
        End Property
        Private m_colCountryManager As Nullable(Of Boolean)

        Public Property colCountryText() As String Implements IrowViewCCUserActivityGridV2.colCountryText
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

        Public Property colRExpd() As String Implements IrowViewCCUserActivityGridV2.colRExpd
            Get
                Return m_colRExpd
            End Get
            Set
                If Not Same(m_colRExpd, Value) Then
                    m_colRExpd = Value
                    m_IsDirty(FieldIndex.colRExpd) = True
                End If
            End Set
        End Property
        Private m_colRExpd As String

        Public Property colClientAdministration() As Nullable(Of Boolean) Implements IrowViewCCUserActivityGridV2.colClientAdministration
            Get
                Return m_colClientAdministration
            End Get
            Set
                If Not Same(m_colClientAdministration, Value) Then
                    m_colClientAdministration = Value
                    m_IsDirty(FieldIndex.colClientAdministration) = True
                End If
            End Set
        End Property
        Private m_colClientAdministration As Nullable(Of Boolean)


        Public Function IsDirty(pIndex As rowViewCCUserActivityGridV2.FieldIndex) As Boolean Implements IrowViewCCUserActivityGridV2.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowViewCCUserActivityGridV2.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowViewCCUserActivityGridV2.SetIsDirty
            m_IsDirty(FieldIndex.colLoginID) = pDirty
            m_IsDirty(FieldIndex.colEmailAddress) = pDirty
            m_IsDirty(FieldIndex.colActiveFlag) = pDirty
            m_IsDirty(FieldIndex.colLoginGuid) = pDirty
            m_IsDirty(FieldIndex.colFullName) = pDirty
            m_IsDirty(FieldIndex.colUserID) = pDirty
            m_IsDirty(FieldIndex.colPassword) = pDirty
            m_IsDirty(FieldIndex.colRiskManager) = pDirty
            m_IsDirty(FieldIndex.colDivisionManager) = pDirty
            m_IsDirty(FieldIndex.colDivision) = pDirty
            m_IsDirty(FieldIndex.colPlantManager) = pDirty
            m_IsDirty(FieldIndex.colPlant) = pDirty
            m_IsDirty(FieldIndex.colAdministrator) = pDirty
            m_IsDirty(FieldIndex.colDocumentAccess) = pDirty
            m_IsDirty(FieldIndex.colCustomAccess) = pDirty
            m_IsDirty(FieldIndex.colCustomAccessText) = pDirty
            m_IsDirty(FieldIndex.colOperatorStamp) = pDirty
            m_IsDirty(FieldIndex.colDateTimeStamp) = pDirty
            m_IsDirty(FieldIndex.colPhone) = pDirty
            m_IsDirty(FieldIndex.colFax) = pDirty
            m_IsDirty(FieldIndex.colEmail) = pDirty
            m_IsDirty(FieldIndex.colNotificationStamp) = pDirty
            m_IsDirty(FieldIndex.colActiveUser) = pDirty
            m_IsDirty(FieldIndex.colFilePrefix) = pDirty
            m_IsDirty(FieldIndex.colLastLogin) = pDirty
            m_IsDirty(FieldIndex.colLastPWChange) = pDirty
            m_IsDirty(FieldIndex.colInternal) = pDirty
            m_IsDirty(FieldIndex.colComments) = pDirty
            m_IsDirty(FieldIndex.colRInit) = pDirty
            m_IsDirty(FieldIndex.colRfu1) = pDirty
            m_IsDirty(FieldIndex.colRfu2) = pDirty
            m_IsDirty(FieldIndex.colRfu3) = pDirty
            m_IsDirty(FieldIndex.colRReport) = pDirty
            m_IsDirty(FieldIndex.colROverdue1) = pDirty
            m_IsDirty(FieldIndex.colROverdue2) = pDirty
            m_IsDirty(FieldIndex.colROverdue3) = pDirty
            m_IsDirty(FieldIndex.colRActResp) = pDirty
            m_IsDirty(FieldIndex.colExpOverdue) = pDirty
            m_IsDirty(FieldIndex.colWo) = pDirty
            m_IsDirty(FieldIndex.colCCActive) = pDirty
            m_IsDirty(FieldIndex.colCalist) = pDirty
            m_IsDirty(FieldIndex.colDivlist) = pDirty
            m_IsDirty(FieldIndex.colLoclist) = pDirty
            m_IsDirty(FieldIndex.colThirdparty) = pDirty
            m_IsDirty(FieldIndex.colGrcadministrator) = pDirty
            m_IsDirty(FieldIndex.colLastrecentupdate) = pDirty
            m_IsDirty(FieldIndex.colEzyUserID) = pDirty
            m_IsDirty(FieldIndex.colIsAMorAE) = pDirty
            m_IsDirty(FieldIndex.colCCOnly) = pDirty
            m_IsDirty(FieldIndex.colFacilityManager) = pDirty
            m_IsDirty(FieldIndex.colFacilityText) = pDirty
            m_IsDirty(FieldIndex.colClientLocNoManager) = pDirty
            m_IsDirty(FieldIndex.colClientLocNoText) = pDirty
            m_IsDirty(FieldIndex.colCityManager) = pDirty
            m_IsDirty(FieldIndex.colCityText) = pDirty
            m_IsDirty(FieldIndex.colStProvManager) = pDirty
            m_IsDirty(FieldIndex.colStProvText) = pDirty
            m_IsDirty(FieldIndex.colCountryManager) = pDirty
            m_IsDirty(FieldIndex.colCountryText) = pDirty
            m_IsDirty(FieldIndex.colRExpd) = pDirty
            m_IsDirty(FieldIndex.colClientAdministration) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (ViewCCUserActivityGridV2) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New ViewCCUserActivityGridV2
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colLoginID  = 1
            colEmailAddress 
            colActiveFlag 
            colLoginGuid 
            colFullName 
            colUserID 
            colPassword 
            colRiskManager 
            colDivisionManager 
            colDivision 
            colPlantManager 
            colPlant 
            colAdministrator 
            colDocumentAccess 
            colCustomAccess 
            colCustomAccessText 
            colOperatorStamp 
            colDateTimeStamp 
            colPhone 
            colFax 
            colEmail 
            colNotificationStamp 
            colActiveUser 
            colFilePrefix 
            colLastLogin 
            colLastPWChange 
            colInternal 
            colComments 
            colRInit 
            colRfu1 
            colRfu2 
            colRfu3 
            colRReport 
            colROverdue1 
            colROverdue2 
            colROverdue3 
            colRActResp 
            colExpOverdue 
            colWo 
            colCCActive 
            colCalist 
            colDivlist 
            colLoclist 
            colThirdparty 
            colGrcadministrator 
            colLastrecentupdate 
            colEzyUserID 
            colIsAMorAE 
            colCCOnly 
            colFacilityManager 
            colFacilityText 
            colClientLocNoManager 
            colClientLocNoText 
            colCityManager 
            colCityText 
            colStProvManager 
            colStProvText 
            colCountryManager 
            colCountryText 
            colRExpd 
            colClientAdministration 
        End Enum

        Private m_IsDirty(61) As Boolean

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

    Public Interface IrowViewCCUserActivityGridV2
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colLoginID() As Nullable(Of Integer)
        Property colEmailAddress() As String
        Property colActiveFlag() As Nullable(Of Boolean)
        Property colLoginGuid() As String
        Property colFullName() As String
        Property colUserID() As String
        Property colPassword() As String
        Property colRiskManager() As Nullable(Of Boolean)
        Property colDivisionManager() As Nullable(Of Boolean)
        Property colDivision() As String
        Property colPlantManager() As Nullable(Of Boolean)
        Property colPlant() As String
        Property colAdministrator() As Nullable(Of Boolean)
        Property colDocumentAccess() As Nullable(Of Boolean)
        Property colCustomAccess() As Nullable(Of Boolean)
        Property colCustomAccessText() As String
        Property colOperatorStamp() As String
        Property colDateTimeStamp() As String
        Property colPhone() As String
        Property colFax() As String
        Property colEmail() As String
        Property colNotificationStamp() As String
        Property colActiveUser() As Nullable(Of Boolean)
        Property colFilePrefix() As String
        Property colLastLogin() As String
        Property colLastPWChange() As String
        Property colInternal() As Nullable(Of Boolean)
        Property colComments() As String
        Property colRInit() As String
        Property colRfu1() As String
        Property colRfu2() As String
        Property colRfu3() As String
        Property colRReport() As String
        Property colROverdue1() As String
        Property colROverdue2() As String
        Property colROverdue3() As String
        Property colRActResp() As String
        Property colExpOverdue() As String
        Property colWo() As Nullable(Of Boolean)
        Property colCCActive() As Nullable(Of Boolean)
        Property colCalist() As String
        Property colDivlist() As String
        Property colLoclist() As String
        Property colThirdparty() As Nullable(Of Boolean)
        Property colGrcadministrator() As String
        Property colLastrecentupdate() As String
        Property colEzyUserID() As Nullable(Of Integer)
        Property colIsAMorAE() As Nullable(Of Boolean)
        Property colCCOnly() As Nullable(Of Boolean)
        Property colFacilityManager() As Nullable(Of Boolean)
        Property colFacilityText() As String
        Property colClientLocNoManager() As Nullable(Of Boolean)
        Property colClientLocNoText() As String
        Property colCityManager() As Nullable(Of Boolean)
        Property colCityText() As String
        Property colStProvManager() As Nullable(Of Boolean)
        Property colStProvText() As String
        Property colCountryManager() As Nullable(Of Boolean)
        Property colCountryText() As String
        Property colRExpd() As String
        Property colClientAdministration() As Nullable(Of Boolean)
        Function IsDirty(pIndex As rowViewCCUserActivityGridV2.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

