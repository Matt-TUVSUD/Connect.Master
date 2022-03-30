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
    Partial Public Class VwRRLogCleanUp

        Public Shared Function LoadData() As List(Of rowVwRRLogCleanUp)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwRRLogCleanUp)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwRRLogCleanUp)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwRRLogCleanUp)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwRRLogCleanUp)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwRRLogCleanUp)
            Dim zReturn As New List(Of rowVwRRLogCleanUp)
            Dim zSQL As String = "SELECT * FROM [jv].[vwRRLogCleanUp]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwRRLogCleanUp)

			Try
	            Dim zReturn As New List(Of rowVwRRLogCleanUp)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwRRLogCleanUp

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwRRLogCleanUp		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwRRLogCleanUp)
			If Not pReader.IsDBNull(pReader.GetOrdinal("ID")) Then pObject.colId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "ID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FilePrefix")) Then pObject.colFilePrefix = UtilSQLServer.SafeReader.SafeReadInt16(pReader, "FilePrefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FileNo")) Then pObject.colFileNo = UtilSQLServer.SafeReader.SafeReadString(pReader, "FileNo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PracticeCode")) Then pObject.colPracticeCode = UtilSQLServer.SafeReader.SafeReadInt16(pReader, "PracticeCode")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Hazard")) Then pObject.colHazard = UtilSQLServer.SafeReader.SafeReadString(pReader, "Hazard")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DateStamp")) Then pObject.colDateStamp = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "DateStamp")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Sender")) Then pObject.colSender = UtilSQLServer.SafeReader.SafeReadString(pReader, "Sender")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RecipientName")) Then pObject.colRecipientName = UtilSQLServer.SafeReader.SafeReadString(pReader, "RecipientName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RecipientEmail")) Then pObject.colRecipientEmail = UtilSQLServer.SafeReader.SafeReadString(pReader, "RecipientEmail")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Activity")) Then pObject.colActivity = UtilSQLServer.SafeReader.SafeReadString(pReader, "Activity")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LinkActive")) Then pObject.colLinkActive = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "LinkActive")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LinkActivatedDate")) Then pObject.colLinkActivatedDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "LinkActivatedDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LinkActivatedBy")) Then pObject.colLinkActivatedBy = UtilSQLServer.SafeReader.SafeReadString(pReader, "LinkActivatedBy")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LinkActivatedByEmail")) Then pObject.colLinkActivatedByEmail = UtilSQLServer.SafeReader.SafeReadString(pReader, "LinkActivatedByEmail")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ResponseActive")) Then pObject.colResponseActive = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "ResponseActive")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ResponseLastActivity")) Then pObject.colResponseLastActivity = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "ResponseLastActivity")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Changed")) Then pObject.colChanged = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "Changed")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RFU1Date")) Then pObject.colRFU1Date = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "RFU1Date")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RFU2Date")) Then pObject.colRFU2Date = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "RFU2Date")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RFU3Date")) Then pObject.colRFU3Date = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "RFU3Date")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RRLogGuid")) Then pObject.colRRLogGuid = UtilSQLServer.SafeReader.SafeReadString(pReader, "RRLogGuid")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CurrentLink")) Then pObject.colCurrentLink = UtilSQLServer.SafeReader.SafeReadString(pReader, "CurrentLink")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LanguagePreference")) Then pObject.colLanguagePreference = UtilSQLServer.SafeReader.SafeReadString(pReader, "LanguagePreference")
			If Not pReader.IsDBNull(pReader.GetOrdinal("AdminAlertDate")) Then pObject.colAdminAlertDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "AdminAlertDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("AdminAlertReason")) Then pObject.colAdminAlertReason = UtilSQLServer.SafeReader.SafeReadString(pReader, "AdminAlertReason")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SysUserCreated")) Then pObject.colSysUserCreated = UtilSQLServer.SafeReader.SafeReadString(pReader, "SysUserCreated")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SysDateCreated")) Then pObject.colSysDateCreated = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "SysDateCreated")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SysUserModified")) Then pObject.colSysUserModified = UtilSQLServer.SafeReader.SafeReadString(pReader, "SysUserModified")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SysDateModified")) Then pObject.colSysDateModified = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "SysDateModified")
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
            Dim zSQL As String = "SELECT * FROM [jv].[vwRRLogCleanUp]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowVwRRLogCleanUp
        Implements IrowVwRRLogCleanUp

        Public Event Loaded(pUserState As Object) Implements IrowVwRRLogCleanUp.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwRRLogCleanUp.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwRRLogCleanUp.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwRRLogCleanUp.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwRRLogCleanUp.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwRRLogCleanUp.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colId() As Nullable(Of Integer) Implements IrowVwRRLogCleanUp.colId
            Get
                Return m_colId
            End Get
            Set
                If Not Same(m_colId, Value) Then
                    m_colId = Value
                    m_IsDirty(FieldIndex.colId) = True
                End If
            End Set
        End Property
        Private m_colId As Nullable(Of Integer)

        Public Property colFilePrefix() As Nullable(Of Short) Implements IrowVwRRLogCleanUp.colFilePrefix
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

        Public Property colFileNo() As String Implements IrowVwRRLogCleanUp.colFileNo
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

        Public Property colPracticeCode() As Nullable(Of Short) Implements IrowVwRRLogCleanUp.colPracticeCode
            Get
                Return m_colPracticeCode
            End Get
            Set
                If Not Same(m_colPracticeCode, Value) Then
                    m_colPracticeCode = Value
                    m_IsDirty(FieldIndex.colPracticeCode) = True
                End If
            End Set
        End Property
        Private m_colPracticeCode As Nullable(Of Short)

        Public Property colHazard() As String Implements IrowVwRRLogCleanUp.colHazard
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

        Public Property colDateStamp() As Nullable(Of DateTime) Implements IrowVwRRLogCleanUp.colDateStamp
            Get
                Return m_colDateStamp
            End Get
            Set
                If Not Same(m_colDateStamp, Value) Then
                    m_colDateStamp = Value
                    m_IsDirty(FieldIndex.colDateStamp) = True
                End If
            End Set
        End Property
        Private m_colDateStamp As Nullable(Of DateTime)

        Public Property colSender() As String Implements IrowVwRRLogCleanUp.colSender
            Get
                Return m_colSender
            End Get
            Set
                If Not Same(m_colSender, Value) Then
                    m_colSender = Value
                    m_IsDirty(FieldIndex.colSender) = True
                End If
            End Set
        End Property
        Private m_colSender As String

        Public Property colRecipientName() As String Implements IrowVwRRLogCleanUp.colRecipientName
            Get
                Return m_colRecipientName
            End Get
            Set
                If Not Same(m_colRecipientName, Value) Then
                    m_colRecipientName = Value
                    m_IsDirty(FieldIndex.colRecipientName) = True
                End If
            End Set
        End Property
        Private m_colRecipientName As String

        Public Property colRecipientEmail() As String Implements IrowVwRRLogCleanUp.colRecipientEmail
            Get
                Return m_colRecipientEmail
            End Get
            Set
                If Not Same(m_colRecipientEmail, Value) Then
                    m_colRecipientEmail = Value
                    m_IsDirty(FieldIndex.colRecipientEmail) = True
                End If
            End Set
        End Property
        Private m_colRecipientEmail As String

        Public Property colActivity() As String Implements IrowVwRRLogCleanUp.colActivity
            Get
                Return m_colActivity
            End Get
            Set
                If Not Same(m_colActivity, Value) Then
                    m_colActivity = Value
                    m_IsDirty(FieldIndex.colActivity) = True
                End If
            End Set
        End Property
        Private m_colActivity As String

        Public Property colLinkActive() As Nullable(Of Boolean) Implements IrowVwRRLogCleanUp.colLinkActive
            Get
                Return m_colLinkActive
            End Get
            Set
                If Not Same(m_colLinkActive, Value) Then
                    m_colLinkActive = Value
                    m_IsDirty(FieldIndex.colLinkActive) = True
                End If
            End Set
        End Property
        Private m_colLinkActive As Nullable(Of Boolean)

        Public Property colLinkActivatedDate() As Nullable(Of DateTime) Implements IrowVwRRLogCleanUp.colLinkActivatedDate
            Get
                Return m_colLinkActivatedDate
            End Get
            Set
                If Not Same(m_colLinkActivatedDate, Value) Then
                    m_colLinkActivatedDate = Value
                    m_IsDirty(FieldIndex.colLinkActivatedDate) = True
                End If
            End Set
        End Property
        Private m_colLinkActivatedDate As Nullable(Of DateTime)

        Public Property colLinkActivatedBy() As String Implements IrowVwRRLogCleanUp.colLinkActivatedBy
            Get
                Return m_colLinkActivatedBy
            End Get
            Set
                If Not Same(m_colLinkActivatedBy, Value) Then
                    m_colLinkActivatedBy = Value
                    m_IsDirty(FieldIndex.colLinkActivatedBy) = True
                End If
            End Set
        End Property
        Private m_colLinkActivatedBy As String

        Public Property colLinkActivatedByEmail() As String Implements IrowVwRRLogCleanUp.colLinkActivatedByEmail
            Get
                Return m_colLinkActivatedByEmail
            End Get
            Set
                If Not Same(m_colLinkActivatedByEmail, Value) Then
                    m_colLinkActivatedByEmail = Value
                    m_IsDirty(FieldIndex.colLinkActivatedByEmail) = True
                End If
            End Set
        End Property
        Private m_colLinkActivatedByEmail As String

        Public Property colResponseActive() As Nullable(Of Boolean) Implements IrowVwRRLogCleanUp.colResponseActive
            Get
                Return m_colResponseActive
            End Get
            Set
                If Not Same(m_colResponseActive, Value) Then
                    m_colResponseActive = Value
                    m_IsDirty(FieldIndex.colResponseActive) = True
                End If
            End Set
        End Property
        Private m_colResponseActive As Nullable(Of Boolean)

        Public Property colResponseLastActivity() As Nullable(Of DateTime) Implements IrowVwRRLogCleanUp.colResponseLastActivity
            Get
                Return m_colResponseLastActivity
            End Get
            Set
                If Not Same(m_colResponseLastActivity, Value) Then
                    m_colResponseLastActivity = Value
                    m_IsDirty(FieldIndex.colResponseLastActivity) = True
                End If
            End Set
        End Property
        Private m_colResponseLastActivity As Nullable(Of DateTime)

        Public Property colChanged() As Nullable(Of Boolean) Implements IrowVwRRLogCleanUp.colChanged
            Get
                Return m_colChanged
            End Get
            Set
                If Not Same(m_colChanged, Value) Then
                    m_colChanged = Value
                    m_IsDirty(FieldIndex.colChanged) = True
                End If
            End Set
        End Property
        Private m_colChanged As Nullable(Of Boolean)

        Public Property colRFU1Date() As Nullable(Of DateTime) Implements IrowVwRRLogCleanUp.colRFU1Date
            Get
                Return m_colRFU1Date
            End Get
            Set
                If Not Same(m_colRFU1Date, Value) Then
                    m_colRFU1Date = Value
                    m_IsDirty(FieldIndex.colRFU1Date) = True
                End If
            End Set
        End Property
        Private m_colRFU1Date As Nullable(Of DateTime)

        Public Property colRFU2Date() As Nullable(Of DateTime) Implements IrowVwRRLogCleanUp.colRFU2Date
            Get
                Return m_colRFU2Date
            End Get
            Set
                If Not Same(m_colRFU2Date, Value) Then
                    m_colRFU2Date = Value
                    m_IsDirty(FieldIndex.colRFU2Date) = True
                End If
            End Set
        End Property
        Private m_colRFU2Date As Nullable(Of DateTime)

        Public Property colRFU3Date() As Nullable(Of DateTime) Implements IrowVwRRLogCleanUp.colRFU3Date
            Get
                Return m_colRFU3Date
            End Get
            Set
                If Not Same(m_colRFU3Date, Value) Then
                    m_colRFU3Date = Value
                    m_IsDirty(FieldIndex.colRFU3Date) = True
                End If
            End Set
        End Property
        Private m_colRFU3Date As Nullable(Of DateTime)

        Public Property colRRLogGuid() As String Implements IrowVwRRLogCleanUp.colRRLogGuid
            Get
                Return m_colRRLogGuid
            End Get
            Set
                If Not Same(m_colRRLogGuid, Value) Then
                    m_colRRLogGuid = Value
                    m_IsDirty(FieldIndex.colRRLogGuid) = True
                End If
            End Set
        End Property
        Private m_colRRLogGuid As String

        Public Property colCurrentLink() As String Implements IrowVwRRLogCleanUp.colCurrentLink
            Get
                Return m_colCurrentLink
            End Get
            Set
                If Not Same(m_colCurrentLink, Value) Then
                    m_colCurrentLink = Value
                    m_IsDirty(FieldIndex.colCurrentLink) = True
                End If
            End Set
        End Property
        Private m_colCurrentLink As String

        Public Property colLanguagePreference() As String Implements IrowVwRRLogCleanUp.colLanguagePreference
            Get
                Return m_colLanguagePreference
            End Get
            Set
                If Not Same(m_colLanguagePreference, Value) Then
                    m_colLanguagePreference = Value
                    m_IsDirty(FieldIndex.colLanguagePreference) = True
                End If
            End Set
        End Property
        Private m_colLanguagePreference As String

        Public Property colAdminAlertDate() As Nullable(Of DateTime) Implements IrowVwRRLogCleanUp.colAdminAlertDate
            Get
                Return m_colAdminAlertDate
            End Get
            Set
                If Not Same(m_colAdminAlertDate, Value) Then
                    m_colAdminAlertDate = Value
                    m_IsDirty(FieldIndex.colAdminAlertDate) = True
                End If
            End Set
        End Property
        Private m_colAdminAlertDate As Nullable(Of DateTime)

        Public Property colAdminAlertReason() As String Implements IrowVwRRLogCleanUp.colAdminAlertReason
            Get
                Return m_colAdminAlertReason
            End Get
            Set
                If Not Same(m_colAdminAlertReason, Value) Then
                    m_colAdminAlertReason = Value
                    m_IsDirty(FieldIndex.colAdminAlertReason) = True
                End If
            End Set
        End Property
        Private m_colAdminAlertReason As String

        Public Property colSysUserCreated() As String Implements IrowVwRRLogCleanUp.colSysUserCreated
            Get
                Return m_colSysUserCreated
            End Get
            Set
                If Not Same(m_colSysUserCreated, Value) Then
                    m_colSysUserCreated = Value
                    m_IsDirty(FieldIndex.colSysUserCreated) = True
                End If
            End Set
        End Property
        Private m_colSysUserCreated As String

        Public Property colSysDateCreated() As Nullable(Of DateTime) Implements IrowVwRRLogCleanUp.colSysDateCreated
            Get
                Return m_colSysDateCreated
            End Get
            Set
                If Not Same(m_colSysDateCreated, Value) Then
                    m_colSysDateCreated = Value
                    m_IsDirty(FieldIndex.colSysDateCreated) = True
                End If
            End Set
        End Property
        Private m_colSysDateCreated As Nullable(Of DateTime)

        Public Property colSysUserModified() As String Implements IrowVwRRLogCleanUp.colSysUserModified
            Get
                Return m_colSysUserModified
            End Get
            Set
                If Not Same(m_colSysUserModified, Value) Then
                    m_colSysUserModified = Value
                    m_IsDirty(FieldIndex.colSysUserModified) = True
                End If
            End Set
        End Property
        Private m_colSysUserModified As String

        Public Property colSysDateModified() As Nullable(Of DateTime) Implements IrowVwRRLogCleanUp.colSysDateModified
            Get
                Return m_colSysDateModified
            End Get
            Set
                If Not Same(m_colSysDateModified, Value) Then
                    m_colSysDateModified = Value
                    m_IsDirty(FieldIndex.colSysDateModified) = True
                End If
            End Set
        End Property
        Private m_colSysDateModified As Nullable(Of DateTime)


        Public Function IsDirty(pIndex As rowVwRRLogCleanUp.FieldIndex) As Boolean Implements IrowVwRRLogCleanUp.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwRRLogCleanUp.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwRRLogCleanUp.SetIsDirty
            m_IsDirty(FieldIndex.colId) = pDirty
            m_IsDirty(FieldIndex.colFilePrefix) = pDirty
            m_IsDirty(FieldIndex.colFileNo) = pDirty
            m_IsDirty(FieldIndex.colPracticeCode) = pDirty
            m_IsDirty(FieldIndex.colHazard) = pDirty
            m_IsDirty(FieldIndex.colDateStamp) = pDirty
            m_IsDirty(FieldIndex.colSender) = pDirty
            m_IsDirty(FieldIndex.colRecipientName) = pDirty
            m_IsDirty(FieldIndex.colRecipientEmail) = pDirty
            m_IsDirty(FieldIndex.colActivity) = pDirty
            m_IsDirty(FieldIndex.colLinkActive) = pDirty
            m_IsDirty(FieldIndex.colLinkActivatedDate) = pDirty
            m_IsDirty(FieldIndex.colLinkActivatedBy) = pDirty
            m_IsDirty(FieldIndex.colLinkActivatedByEmail) = pDirty
            m_IsDirty(FieldIndex.colResponseActive) = pDirty
            m_IsDirty(FieldIndex.colResponseLastActivity) = pDirty
            m_IsDirty(FieldIndex.colChanged) = pDirty
            m_IsDirty(FieldIndex.colRFU1Date) = pDirty
            m_IsDirty(FieldIndex.colRFU2Date) = pDirty
            m_IsDirty(FieldIndex.colRFU3Date) = pDirty
            m_IsDirty(FieldIndex.colRRLogGuid) = pDirty
            m_IsDirty(FieldIndex.colCurrentLink) = pDirty
            m_IsDirty(FieldIndex.colLanguagePreference) = pDirty
            m_IsDirty(FieldIndex.colAdminAlertDate) = pDirty
            m_IsDirty(FieldIndex.colAdminAlertReason) = pDirty
            m_IsDirty(FieldIndex.colSysUserCreated) = pDirty
            m_IsDirty(FieldIndex.colSysDateCreated) = pDirty
            m_IsDirty(FieldIndex.colSysUserModified) = pDirty
            m_IsDirty(FieldIndex.colSysDateModified) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwRRLogCleanUp) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwRRLogCleanUp
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colId  = 1
            colFilePrefix 
            colFileNo 
            colPracticeCode 
            colHazard 
            colDateStamp 
            colSender 
            colRecipientName 
            colRecipientEmail 
            colActivity 
            colLinkActive 
            colLinkActivatedDate 
            colLinkActivatedBy 
            colLinkActivatedByEmail 
            colResponseActive 
            colResponseLastActivity 
            colChanged 
            colRFU1Date 
            colRFU2Date 
            colRFU3Date 
            colRRLogGuid 
            colCurrentLink 
            colLanguagePreference 
            colAdminAlertDate 
            colAdminAlertReason 
            colSysUserCreated 
            colSysDateCreated 
            colSysUserModified 
            colSysDateModified 
        End Enum

        Private m_IsDirty(29) As Boolean

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

    Public Interface IrowVwRRLogCleanUp
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colId() As Nullable(Of Integer)
        Property colFilePrefix() As Nullable(Of Short)
        Property colFileNo() As String
        Property colPracticeCode() As Nullable(Of Short)
        Property colHazard() As String
        Property colDateStamp() As Nullable(Of DateTime)
        Property colSender() As String
        Property colRecipientName() As String
        Property colRecipientEmail() As String
        Property colActivity() As String
        Property colLinkActive() As Nullable(Of Boolean)
        Property colLinkActivatedDate() As Nullable(Of DateTime)
        Property colLinkActivatedBy() As String
        Property colLinkActivatedByEmail() As String
        Property colResponseActive() As Nullable(Of Boolean)
        Property colResponseLastActivity() As Nullable(Of DateTime)
        Property colChanged() As Nullable(Of Boolean)
        Property colRFU1Date() As Nullable(Of DateTime)
        Property colRFU2Date() As Nullable(Of DateTime)
        Property colRFU3Date() As Nullable(Of DateTime)
        Property colRRLogGuid() As String
        Property colCurrentLink() As String
        Property colLanguagePreference() As String
        Property colAdminAlertDate() As Nullable(Of DateTime)
        Property colAdminAlertReason() As String
        Property colSysUserCreated() As String
        Property colSysDateCreated() As Nullable(Of DateTime)
        Property colSysUserModified() As String
        Property colSysDateModified() As Nullable(Of DateTime)
        Function IsDirty(pIndex As rowVwRRLogCleanUp.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

