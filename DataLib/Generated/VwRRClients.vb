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
    Partial Public Class VwRRClients

        Public Shared Function LoadData() As List(Of rowVwRRClients)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwRRClients)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwRRClients)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwRRClients)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwRRClients)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwRRClients)
            Dim zReturn As New List(Of rowVwRRClients)
            Dim zSQL As String = "SELECT * FROM [jv].[vwRRClients]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwRRClients)

			Try
	            Dim zReturn As New List(Of rowVwRRClients)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwRRClients

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwRRClients		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwRRClients)
			If Not pReader.IsDBNull(pReader.GetOrdinal("cldbname")) Then pObject.colCldbname = UtilSQLServer.SafeReader.SafeReadString(pReader, "cldbname")
			If Not pReader.IsDBNull(pReader.GetOrdinal("clientname")) Then pObject.colClientname = UtilSQLServer.SafeReader.SafeReadString(pReader, "clientname")
			If Not pReader.IsDBNull(pReader.GetOrdinal("features")) Then pObject.colFeatures = UtilSQLServer.SafeReader.SafeReadString(pReader, "features")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fileprefix")) Then pObject.colFileprefix = UtilSQLServer.SafeReader.SafeReadString(pReader, "fileprefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("clientdesigneenotify")) Then pObject.colClientdesigneenotify = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "clientdesigneenotify")
			If Not pReader.IsDBNull(pReader.GetOrdinal("clientdesigneename")) Then pObject.colClientdesigneename = UtilSQLServer.SafeReader.SafeReadString(pReader, "clientdesigneename")
			If Not pReader.IsDBNull(pReader.GetOrdinal("clientdesigneeemail")) Then pObject.colClientdesigneeemail = UtilSQLServer.SafeReader.SafeReadString(pReader, "clientdesigneeemail")
			If Not pReader.IsDBNull(pReader.GetOrdinal("580active")) Then pObject.colActive = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "580active")
			If Not pReader.IsDBNull(pReader.GetOrdinal("recrespemail")) Then pObject.colRecrespemail = UtilSQLServer.SafeReader.SafeReadString(pReader, "recrespemail")
			If Not pReader.IsDBNull(pReader.GetOrdinal("recautofollowup")) Then pObject.colRecautofollowup = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "recautofollowup")
			If Not pReader.IsDBNull(pReader.GetOrdinal("recfollowup1")) Then pObject.colRecfollowup1 = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "recfollowup1")
			If Not pReader.IsDBNull(pReader.GetOrdinal("recfollowup2")) Then pObject.colRecfollowup2 = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "recfollowup2")
			If Not pReader.IsDBNull(pReader.GetOrdinal("recfollowup3")) Then pObject.colRecfollowup3 = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "recfollowup3")
			If Not pReader.IsDBNull(pReader.GetOrdinal("datatransfer")) Then pObject.colDatatransfer = UtilSQLServer.SafeReader.SafeReadString(pReader, "datatransfer")
			If Not pReader.IsDBNull(pReader.GetOrdinal("AutoRecStartDate")) Then pObject.colAutoRecStartDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "AutoRecStartDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("AutoRecComments")) Then pObject.colAutoRecComments = UtilSQLServer.SafeReader.SafeReadString(pReader, "AutoRecComments")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FireRatingKeyID")) Then pObject.colFireRatingKeyID = UtilSQLServer.SafeReader.SafeReadByte(pReader, "FireRatingKeyID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("BMRatingKeyID")) Then pObject.colBMRatingKeyID = UtilSQLServer.SafeReader.SafeReadByte(pReader, "BMRatingKeyID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CustomAccessLabel")) Then pObject.colCustomAccessLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "CustomAccessLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("WORecipientName")) Then pObject.colWORecipientName = UtilSQLServer.SafeReader.SafeReadString(pReader, "WORecipientName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("WORecipientEmail")) Then pObject.colWORecipientEmail = UtilSQLServer.SafeReader.SafeReadString(pReader, "WORecipientEmail")
			If Not pReader.IsDBNull(pReader.GetOrdinal("WOSubject")) Then pObject.colWOSubject = UtilSQLServer.SafeReader.SafeReadString(pReader, "WOSubject")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ExchangeRateGroupID")) Then pObject.colExchangeRateGroupID = UtilSQLServer.SafeReader.SafeReadByte(pReader, "ExchangeRateGroupID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("AutoRecLastProcessDate")) Then pObject.colAutoRecLastProcessDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "AutoRecLastProcessDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("IFU")) Then pObject.colIfu = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "IFU")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PIFU1")) Then pObject.colPifu1 = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "PIFU1")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PIFU2")) Then pObject.colPifu2 = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "PIFU2")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PIFU3")) Then pObject.colPifu3 = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "PIFU3")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PIFU4")) Then pObject.colPifu4 = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "PIFU4")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ImpClientDesName1")) Then pObject.colImpClientDesName1 = UtilSQLServer.SafeReader.SafeReadString(pReader, "ImpClientDesName1")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ImpClientDesEmail1")) Then pObject.colImpClientDesEmail1 = UtilSQLServer.SafeReader.SafeReadString(pReader, "ImpClientDesEmail1")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ImpClientDesName2")) Then pObject.colImpClientDesName2 = UtilSQLServer.SafeReader.SafeReadString(pReader, "ImpClientDesName2")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ImpClientDesEmail2")) Then pObject.colImpClientDesEmail2 = UtilSQLServer.SafeReader.SafeReadString(pReader, "ImpClientDesEmail2")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ImpClientDesName3")) Then pObject.colImpClientDesName3 = UtilSQLServer.SafeReader.SafeReadString(pReader, "ImpClientDesName3")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ImpClientDesEmail3")) Then pObject.colImpClientDesEmail3 = UtilSQLServer.SafeReader.SafeReadString(pReader, "ImpClientDesEmail3")
			If Not pReader.IsDBNull(pReader.GetOrdinal("AIFU")) Then pObject.colAifu = UtilSQLServer.SafeReader.SafeReadString(pReader, "AIFU")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ImpClientDesName4")) Then pObject.colImpClientDesName4 = UtilSQLServer.SafeReader.SafeReadString(pReader, "ImpClientDesName4")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ImpClientDesEmail4")) Then pObject.colImpClientDesEmail4 = UtilSQLServer.SafeReader.SafeReadString(pReader, "ImpClientDesEmail4")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ImpClientDesName5")) Then pObject.colImpClientDesName5 = UtilSQLServer.SafeReader.SafeReadString(pReader, "ImpClientDesName5")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ImpClientDesEmail5")) Then pObject.colImpClientDesEmail5 = UtilSQLServer.SafeReader.SafeReadString(pReader, "ImpClientDesEmail5")
			If Not pReader.IsDBNull(pReader.GetOrdinal("MgmtARR")) Then pObject.colMgmtARR = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "MgmtARR")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ImpEmailAll")) Then pObject.colImpEmailAll = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "ImpEmailAll")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SecurityPasswordExpireDays")) Then pObject.colSecurityPasswordExpireDays = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "SecurityPasswordExpireDays")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SecurityInactivityLockoutDays")) Then pObject.colSecurityInactivityLockoutDays = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "SecurityInactivityLockoutDays")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SecurityInactivityLockoutRemindDays")) Then pObject.colSecurityInactivityLockoutRemindDays = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "SecurityInactivityLockoutRemindDays")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SecurityPasswordMinimumLength")) Then pObject.colSecurityPasswordMinimumLength = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "SecurityPasswordMinimumLength")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SecurityPasswordTypeId")) Then pObject.colSecurityPasswordTypeId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "SecurityPasswordTypeId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DataTransferPackageId")) Then pObject.colDataTransferPackageId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "DataTransferPackageId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DataTransferPassword")) Then pObject.colDataTransferPassword = UtilSQLServer.SafeReader.SafeReadString(pReader, "DataTransferPassword")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DataTransferEncryptionKey")) Then pObject.colDataTransferEncryptionKey = UtilSQLServer.SafeReader.SafeReadString(pReader, "DataTransferEncryptionKey")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SecurityAllowChangePassword")) Then pObject.colSecurityAllowChangePassword = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "SecurityAllowChangePassword")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ReclassificationEmailSentDate")) Then pObject.colReclassificationEmailSentDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "ReclassificationEmailSentDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ReclassificationEmailFollowUpDate")) Then pObject.colReclassificationEmailFollowUpDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "ReclassificationEmailFollowUpDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ReclassificationCompletionDate")) Then pObject.colReclassificationCompletionDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "ReclassificationCompletionDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ReclassificationLinkGUID")) Then pObject.colReclassificationLinkGUID = UtilSQLServer.SafeReader.SafeReadString(pReader, "ReclassificationLinkGUID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LastReclassificationCompletionDate")) Then pObject.colLastReclassificationCompletionDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "LastReclassificationCompletionDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SysUserCreated")) Then pObject.colSysUserCreated = UtilSQLServer.SafeReader.SafeReadString(pReader, "SysUserCreated")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SysDateCreated")) Then pObject.colSysDateCreated = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "SysDateCreated")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SysUserModified")) Then pObject.colSysUserModified = UtilSQLServer.SafeReader.SafeReadString(pReader, "SysUserModified")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SysDateModified")) Then pObject.colSysDateModified = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "SysDateModified")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ClientId")) Then pObject.colClientId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "ClientId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DefaultMetaCurrencyID")) Then pObject.colDefaultMetaCurrencyID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "DefaultMetaCurrencyID")
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
            Dim zSQL As String = "SELECT * FROM [jv].[vwRRClients]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowVwRRClients
        Implements IrowVwRRClients

        Public Event Loaded(pUserState As Object) Implements IrowVwRRClients.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwRRClients.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwRRClients.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwRRClients.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwRRClients.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwRRClients.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colCldbname() As String Implements IrowVwRRClients.colCldbname
            Get
                Return m_colCldbname
            End Get
            Set
                If Not Same(m_colCldbname, Value) Then
                    m_colCldbname = Value
                    m_IsDirty(FieldIndex.colCldbname) = True
                End If
            End Set
        End Property
        Private m_colCldbname As String

        Public Property colClientname() As String Implements IrowVwRRClients.colClientname
            Get
                Return m_colClientname
            End Get
            Set
                If Not Same(m_colClientname, Value) Then
                    m_colClientname = Value
                    m_IsDirty(FieldIndex.colClientname) = True
                End If
            End Set
        End Property
        Private m_colClientname As String

        Public Property colFeatures() As String Implements IrowVwRRClients.colFeatures
            Get
                Return m_colFeatures
            End Get
            Set
                If Not Same(m_colFeatures, Value) Then
                    m_colFeatures = Value
                    m_IsDirty(FieldIndex.colFeatures) = True
                End If
            End Set
        End Property
        Private m_colFeatures As String

        Public Property colFileprefix() As String Implements IrowVwRRClients.colFileprefix
            Get
                Return m_colFileprefix
            End Get
            Set
                If Not Same(m_colFileprefix, Value) Then
                    m_colFileprefix = Value
                    m_IsDirty(FieldIndex.colFileprefix) = True
                End If
            End Set
        End Property
        Private m_colFileprefix As String

        Public Property colClientdesigneenotify() As Nullable(Of Boolean) Implements IrowVwRRClients.colClientdesigneenotify
            Get
                Return m_colClientdesigneenotify
            End Get
            Set
                If Not Same(m_colClientdesigneenotify, Value) Then
                    m_colClientdesigneenotify = Value
                    m_IsDirty(FieldIndex.colClientdesigneenotify) = True
                End If
            End Set
        End Property
        Private m_colClientdesigneenotify As Nullable(Of Boolean)

        Public Property colClientdesigneename() As String Implements IrowVwRRClients.colClientdesigneename
            Get
                Return m_colClientdesigneename
            End Get
            Set
                If Not Same(m_colClientdesigneename, Value) Then
                    m_colClientdesigneename = Value
                    m_IsDirty(FieldIndex.colClientdesigneename) = True
                End If
            End Set
        End Property
        Private m_colClientdesigneename As String

        Public Property colClientdesigneeemail() As String Implements IrowVwRRClients.colClientdesigneeemail
            Get
                Return m_colClientdesigneeemail
            End Get
            Set
                If Not Same(m_colClientdesigneeemail, Value) Then
                    m_colClientdesigneeemail = Value
                    m_IsDirty(FieldIndex.colClientdesigneeemail) = True
                End If
            End Set
        End Property
        Private m_colClientdesigneeemail As String

        Public Property colActive() As Nullable(Of Boolean) Implements IrowVwRRClients.colActive
            Get
                Return m_colActive
            End Get
            Set
                If Not Same(m_colActive, Value) Then
                    m_colActive = Value
                    m_IsDirty(FieldIndex.colActive) = True
                End If
            End Set
        End Property
        Private m_colActive As Nullable(Of Boolean)

        Public Property colRecrespemail() As String Implements IrowVwRRClients.colRecrespemail
            Get
                Return m_colRecrespemail
            End Get
            Set
                If Not Same(m_colRecrespemail, Value) Then
                    m_colRecrespemail = Value
                    m_IsDirty(FieldIndex.colRecrespemail) = True
                End If
            End Set
        End Property
        Private m_colRecrespemail As String

        Public Property colRecautofollowup() As Nullable(Of Boolean) Implements IrowVwRRClients.colRecautofollowup
            Get
                Return m_colRecautofollowup
            End Get
            Set
                If Not Same(m_colRecautofollowup, Value) Then
                    m_colRecautofollowup = Value
                    m_IsDirty(FieldIndex.colRecautofollowup) = True
                End If
            End Set
        End Property
        Private m_colRecautofollowup As Nullable(Of Boolean)

        Public Property colRecfollowup1() As Nullable(Of Integer) Implements IrowVwRRClients.colRecfollowup1
            Get
                Return m_colRecfollowup1
            End Get
            Set
                If Not Same(m_colRecfollowup1, Value) Then
                    m_colRecfollowup1 = Value
                    m_IsDirty(FieldIndex.colRecfollowup1) = True
                End If
            End Set
        End Property
        Private m_colRecfollowup1 As Nullable(Of Integer)

        Public Property colRecfollowup2() As Nullable(Of Integer) Implements IrowVwRRClients.colRecfollowup2
            Get
                Return m_colRecfollowup2
            End Get
            Set
                If Not Same(m_colRecfollowup2, Value) Then
                    m_colRecfollowup2 = Value
                    m_IsDirty(FieldIndex.colRecfollowup2) = True
                End If
            End Set
        End Property
        Private m_colRecfollowup2 As Nullable(Of Integer)

        Public Property colRecfollowup3() As Nullable(Of Integer) Implements IrowVwRRClients.colRecfollowup3
            Get
                Return m_colRecfollowup3
            End Get
            Set
                If Not Same(m_colRecfollowup3, Value) Then
                    m_colRecfollowup3 = Value
                    m_IsDirty(FieldIndex.colRecfollowup3) = True
                End If
            End Set
        End Property
        Private m_colRecfollowup3 As Nullable(Of Integer)

        Public Property colDatatransfer() As String Implements IrowVwRRClients.colDatatransfer
            Get
                Return m_colDatatransfer
            End Get
            Set
                If Not Same(m_colDatatransfer, Value) Then
                    m_colDatatransfer = Value
                    m_IsDirty(FieldIndex.colDatatransfer) = True
                End If
            End Set
        End Property
        Private m_colDatatransfer As String

        Public Property colAutoRecStartDate() As Nullable(Of DateTime) Implements IrowVwRRClients.colAutoRecStartDate
            Get
                Return m_colAutoRecStartDate
            End Get
            Set
                If Not Same(m_colAutoRecStartDate, Value) Then
                    m_colAutoRecStartDate = Value
                    m_IsDirty(FieldIndex.colAutoRecStartDate) = True
                End If
            End Set
        End Property
        Private m_colAutoRecStartDate As Nullable(Of DateTime)

        Public Property colAutoRecComments() As String Implements IrowVwRRClients.colAutoRecComments
            Get
                Return m_colAutoRecComments
            End Get
            Set
                If Not Same(m_colAutoRecComments, Value) Then
                    m_colAutoRecComments = Value
                    m_IsDirty(FieldIndex.colAutoRecComments) = True
                End If
            End Set
        End Property
        Private m_colAutoRecComments As String

        Public Property colFireRatingKeyID() As Nullable(Of Byte) Implements IrowVwRRClients.colFireRatingKeyID
            Get
                Return m_colFireRatingKeyID
            End Get
            Set
                If Not Same(m_colFireRatingKeyID, Value) Then
                    m_colFireRatingKeyID = Value
                    m_IsDirty(FieldIndex.colFireRatingKeyID) = True
                End If
            End Set
        End Property
        Private m_colFireRatingKeyID As Nullable(Of Byte)

        Public Property colBMRatingKeyID() As Nullable(Of Byte) Implements IrowVwRRClients.colBMRatingKeyID
            Get
                Return m_colBMRatingKeyID
            End Get
            Set
                If Not Same(m_colBMRatingKeyID, Value) Then
                    m_colBMRatingKeyID = Value
                    m_IsDirty(FieldIndex.colBMRatingKeyID) = True
                End If
            End Set
        End Property
        Private m_colBMRatingKeyID As Nullable(Of Byte)

        Public Property colCustomAccessLabel() As String Implements IrowVwRRClients.colCustomAccessLabel
            Get
                Return m_colCustomAccessLabel
            End Get
            Set
                If Not Same(m_colCustomAccessLabel, Value) Then
                    m_colCustomAccessLabel = Value
                    m_IsDirty(FieldIndex.colCustomAccessLabel) = True
                End If
            End Set
        End Property
        Private m_colCustomAccessLabel As String

        Public Property colWORecipientName() As String Implements IrowVwRRClients.colWORecipientName
            Get
                Return m_colWORecipientName
            End Get
            Set
                If Not Same(m_colWORecipientName, Value) Then
                    m_colWORecipientName = Value
                    m_IsDirty(FieldIndex.colWORecipientName) = True
                End If
            End Set
        End Property
        Private m_colWORecipientName As String

        Public Property colWORecipientEmail() As String Implements IrowVwRRClients.colWORecipientEmail
            Get
                Return m_colWORecipientEmail
            End Get
            Set
                If Not Same(m_colWORecipientEmail, Value) Then
                    m_colWORecipientEmail = Value
                    m_IsDirty(FieldIndex.colWORecipientEmail) = True
                End If
            End Set
        End Property
        Private m_colWORecipientEmail As String

        Public Property colWOSubject() As String Implements IrowVwRRClients.colWOSubject
            Get
                Return m_colWOSubject
            End Get
            Set
                If Not Same(m_colWOSubject, Value) Then
                    m_colWOSubject = Value
                    m_IsDirty(FieldIndex.colWOSubject) = True
                End If
            End Set
        End Property
        Private m_colWOSubject As String

        Public Property colExchangeRateGroupID() As Nullable(Of Byte) Implements IrowVwRRClients.colExchangeRateGroupID
            Get
                Return m_colExchangeRateGroupID
            End Get
            Set
                If Not Same(m_colExchangeRateGroupID, Value) Then
                    m_colExchangeRateGroupID = Value
                    m_IsDirty(FieldIndex.colExchangeRateGroupID) = True
                End If
            End Set
        End Property
        Private m_colExchangeRateGroupID As Nullable(Of Byte)

        Public Property colAutoRecLastProcessDate() As Nullable(Of DateTime) Implements IrowVwRRClients.colAutoRecLastProcessDate
            Get
                Return m_colAutoRecLastProcessDate
            End Get
            Set
                If Not Same(m_colAutoRecLastProcessDate, Value) Then
                    m_colAutoRecLastProcessDate = Value
                    m_IsDirty(FieldIndex.colAutoRecLastProcessDate) = True
                End If
            End Set
        End Property
        Private m_colAutoRecLastProcessDate As Nullable(Of DateTime)

        Public Property colIfu() As Nullable(Of Boolean) Implements IrowVwRRClients.colIfu
            Get
                Return m_colIfu
            End Get
            Set
                If Not Same(m_colIfu, Value) Then
                    m_colIfu = Value
                    m_IsDirty(FieldIndex.colIfu) = True
                End If
            End Set
        End Property
        Private m_colIfu As Nullable(Of Boolean)

        Public Property colPifu1() As Nullable(Of Integer) Implements IrowVwRRClients.colPifu1
            Get
                Return m_colPifu1
            End Get
            Set
                If Not Same(m_colPifu1, Value) Then
                    m_colPifu1 = Value
                    m_IsDirty(FieldIndex.colPifu1) = True
                End If
            End Set
        End Property
        Private m_colPifu1 As Nullable(Of Integer)

        Public Property colPifu2() As Nullable(Of Integer) Implements IrowVwRRClients.colPifu2
            Get
                Return m_colPifu2
            End Get
            Set
                If Not Same(m_colPifu2, Value) Then
                    m_colPifu2 = Value
                    m_IsDirty(FieldIndex.colPifu2) = True
                End If
            End Set
        End Property
        Private m_colPifu2 As Nullable(Of Integer)

        Public Property colPifu3() As Nullable(Of Integer) Implements IrowVwRRClients.colPifu3
            Get
                Return m_colPifu3
            End Get
            Set
                If Not Same(m_colPifu3, Value) Then
                    m_colPifu3 = Value
                    m_IsDirty(FieldIndex.colPifu3) = True
                End If
            End Set
        End Property
        Private m_colPifu3 As Nullable(Of Integer)

        Public Property colPifu4() As Nullable(Of Integer) Implements IrowVwRRClients.colPifu4
            Get
                Return m_colPifu4
            End Get
            Set
                If Not Same(m_colPifu4, Value) Then
                    m_colPifu4 = Value
                    m_IsDirty(FieldIndex.colPifu4) = True
                End If
            End Set
        End Property
        Private m_colPifu4 As Nullable(Of Integer)

        Public Property colImpClientDesName1() As String Implements IrowVwRRClients.colImpClientDesName1
            Get
                Return m_colImpClientDesName1
            End Get
            Set
                If Not Same(m_colImpClientDesName1, Value) Then
                    m_colImpClientDesName1 = Value
                    m_IsDirty(FieldIndex.colImpClientDesName1) = True
                End If
            End Set
        End Property
        Private m_colImpClientDesName1 As String

        Public Property colImpClientDesEmail1() As String Implements IrowVwRRClients.colImpClientDesEmail1
            Get
                Return m_colImpClientDesEmail1
            End Get
            Set
                If Not Same(m_colImpClientDesEmail1, Value) Then
                    m_colImpClientDesEmail1 = Value
                    m_IsDirty(FieldIndex.colImpClientDesEmail1) = True
                End If
            End Set
        End Property
        Private m_colImpClientDesEmail1 As String

        Public Property colImpClientDesName2() As String Implements IrowVwRRClients.colImpClientDesName2
            Get
                Return m_colImpClientDesName2
            End Get
            Set
                If Not Same(m_colImpClientDesName2, Value) Then
                    m_colImpClientDesName2 = Value
                    m_IsDirty(FieldIndex.colImpClientDesName2) = True
                End If
            End Set
        End Property
        Private m_colImpClientDesName2 As String

        Public Property colImpClientDesEmail2() As String Implements IrowVwRRClients.colImpClientDesEmail2
            Get
                Return m_colImpClientDesEmail2
            End Get
            Set
                If Not Same(m_colImpClientDesEmail2, Value) Then
                    m_colImpClientDesEmail2 = Value
                    m_IsDirty(FieldIndex.colImpClientDesEmail2) = True
                End If
            End Set
        End Property
        Private m_colImpClientDesEmail2 As String

        Public Property colImpClientDesName3() As String Implements IrowVwRRClients.colImpClientDesName3
            Get
                Return m_colImpClientDesName3
            End Get
            Set
                If Not Same(m_colImpClientDesName3, Value) Then
                    m_colImpClientDesName3 = Value
                    m_IsDirty(FieldIndex.colImpClientDesName3) = True
                End If
            End Set
        End Property
        Private m_colImpClientDesName3 As String

        Public Property colImpClientDesEmail3() As String Implements IrowVwRRClients.colImpClientDesEmail3
            Get
                Return m_colImpClientDesEmail3
            End Get
            Set
                If Not Same(m_colImpClientDesEmail3, Value) Then
                    m_colImpClientDesEmail3 = Value
                    m_IsDirty(FieldIndex.colImpClientDesEmail3) = True
                End If
            End Set
        End Property
        Private m_colImpClientDesEmail3 As String

        Public Property colAifu() As String Implements IrowVwRRClients.colAifu
            Get
                Return m_colAifu
            End Get
            Set
                If Not Same(m_colAifu, Value) Then
                    m_colAifu = Value
                    m_IsDirty(FieldIndex.colAifu) = True
                End If
            End Set
        End Property
        Private m_colAifu As String

        Public Property colImpClientDesName4() As String Implements IrowVwRRClients.colImpClientDesName4
            Get
                Return m_colImpClientDesName4
            End Get
            Set
                If Not Same(m_colImpClientDesName4, Value) Then
                    m_colImpClientDesName4 = Value
                    m_IsDirty(FieldIndex.colImpClientDesName4) = True
                End If
            End Set
        End Property
        Private m_colImpClientDesName4 As String

        Public Property colImpClientDesEmail4() As String Implements IrowVwRRClients.colImpClientDesEmail4
            Get
                Return m_colImpClientDesEmail4
            End Get
            Set
                If Not Same(m_colImpClientDesEmail4, Value) Then
                    m_colImpClientDesEmail4 = Value
                    m_IsDirty(FieldIndex.colImpClientDesEmail4) = True
                End If
            End Set
        End Property
        Private m_colImpClientDesEmail4 As String

        Public Property colImpClientDesName5() As String Implements IrowVwRRClients.colImpClientDesName5
            Get
                Return m_colImpClientDesName5
            End Get
            Set
                If Not Same(m_colImpClientDesName5, Value) Then
                    m_colImpClientDesName5 = Value
                    m_IsDirty(FieldIndex.colImpClientDesName5) = True
                End If
            End Set
        End Property
        Private m_colImpClientDesName5 As String

        Public Property colImpClientDesEmail5() As String Implements IrowVwRRClients.colImpClientDesEmail5
            Get
                Return m_colImpClientDesEmail5
            End Get
            Set
                If Not Same(m_colImpClientDesEmail5, Value) Then
                    m_colImpClientDesEmail5 = Value
                    m_IsDirty(FieldIndex.colImpClientDesEmail5) = True
                End If
            End Set
        End Property
        Private m_colImpClientDesEmail5 As String

        Public Property colMgmtARR() As Nullable(Of Boolean) Implements IrowVwRRClients.colMgmtARR
            Get
                Return m_colMgmtARR
            End Get
            Set
                If Not Same(m_colMgmtARR, Value) Then
                    m_colMgmtARR = Value
                    m_IsDirty(FieldIndex.colMgmtARR) = True
                End If
            End Set
        End Property
        Private m_colMgmtARR As Nullable(Of Boolean)

        Public Property colImpEmailAll() As Nullable(Of Boolean) Implements IrowVwRRClients.colImpEmailAll
            Get
                Return m_colImpEmailAll
            End Get
            Set
                If Not Same(m_colImpEmailAll, Value) Then
                    m_colImpEmailAll = Value
                    m_IsDirty(FieldIndex.colImpEmailAll) = True
                End If
            End Set
        End Property
        Private m_colImpEmailAll As Nullable(Of Boolean)

        Public Property colSecurityPasswordExpireDays() As Nullable(Of Integer) Implements IrowVwRRClients.colSecurityPasswordExpireDays
            Get
                Return m_colSecurityPasswordExpireDays
            End Get
            Set
                If Not Same(m_colSecurityPasswordExpireDays, Value) Then
                    m_colSecurityPasswordExpireDays = Value
                    m_IsDirty(FieldIndex.colSecurityPasswordExpireDays) = True
                End If
            End Set
        End Property
        Private m_colSecurityPasswordExpireDays As Nullable(Of Integer)

        Public Property colSecurityInactivityLockoutDays() As Nullable(Of Integer) Implements IrowVwRRClients.colSecurityInactivityLockoutDays
            Get
                Return m_colSecurityInactivityLockoutDays
            End Get
            Set
                If Not Same(m_colSecurityInactivityLockoutDays, Value) Then
                    m_colSecurityInactivityLockoutDays = Value
                    m_IsDirty(FieldIndex.colSecurityInactivityLockoutDays) = True
                End If
            End Set
        End Property
        Private m_colSecurityInactivityLockoutDays As Nullable(Of Integer)

        Public Property colSecurityInactivityLockoutRemindDays() As Nullable(Of Integer) Implements IrowVwRRClients.colSecurityInactivityLockoutRemindDays
            Get
                Return m_colSecurityInactivityLockoutRemindDays
            End Get
            Set
                If Not Same(m_colSecurityInactivityLockoutRemindDays, Value) Then
                    m_colSecurityInactivityLockoutRemindDays = Value
                    m_IsDirty(FieldIndex.colSecurityInactivityLockoutRemindDays) = True
                End If
            End Set
        End Property
        Private m_colSecurityInactivityLockoutRemindDays As Nullable(Of Integer)

        Public Property colSecurityPasswordMinimumLength() As Nullable(Of Integer) Implements IrowVwRRClients.colSecurityPasswordMinimumLength
            Get
                Return m_colSecurityPasswordMinimumLength
            End Get
            Set
                If Not Same(m_colSecurityPasswordMinimumLength, Value) Then
                    m_colSecurityPasswordMinimumLength = Value
                    m_IsDirty(FieldIndex.colSecurityPasswordMinimumLength) = True
                End If
            End Set
        End Property
        Private m_colSecurityPasswordMinimumLength As Nullable(Of Integer)

        Public Property colSecurityPasswordTypeId() As Nullable(Of Integer) Implements IrowVwRRClients.colSecurityPasswordTypeId
            Get
                Return m_colSecurityPasswordTypeId
            End Get
            Set
                If Not Same(m_colSecurityPasswordTypeId, Value) Then
                    m_colSecurityPasswordTypeId = Value
                    m_IsDirty(FieldIndex.colSecurityPasswordTypeId) = True
                End If
            End Set
        End Property
        Private m_colSecurityPasswordTypeId As Nullable(Of Integer)

        Public Property colDataTransferPackageId() As Nullable(Of Integer) Implements IrowVwRRClients.colDataTransferPackageId
            Get
                Return m_colDataTransferPackageId
            End Get
            Set
                If Not Same(m_colDataTransferPackageId, Value) Then
                    m_colDataTransferPackageId = Value
                    m_IsDirty(FieldIndex.colDataTransferPackageId) = True
                End If
            End Set
        End Property
        Private m_colDataTransferPackageId As Nullable(Of Integer)

        Public Property colDataTransferPassword() As String Implements IrowVwRRClients.colDataTransferPassword
            Get
                Return m_colDataTransferPassword
            End Get
            Set
                If Not Same(m_colDataTransferPassword, Value) Then
                    m_colDataTransferPassword = Value
                    m_IsDirty(FieldIndex.colDataTransferPassword) = True
                End If
            End Set
        End Property
        Private m_colDataTransferPassword As String

        Public Property colDataTransferEncryptionKey() As String Implements IrowVwRRClients.colDataTransferEncryptionKey
            Get
                Return m_colDataTransferEncryptionKey
            End Get
            Set
                If Not Same(m_colDataTransferEncryptionKey, Value) Then
                    m_colDataTransferEncryptionKey = Value
                    m_IsDirty(FieldIndex.colDataTransferEncryptionKey) = True
                End If
            End Set
        End Property
        Private m_colDataTransferEncryptionKey As String

        Public Property colSecurityAllowChangePassword() As Nullable(Of Boolean) Implements IrowVwRRClients.colSecurityAllowChangePassword
            Get
                Return m_colSecurityAllowChangePassword
            End Get
            Set
                If Not Same(m_colSecurityAllowChangePassword, Value) Then
                    m_colSecurityAllowChangePassword = Value
                    m_IsDirty(FieldIndex.colSecurityAllowChangePassword) = True
                End If
            End Set
        End Property
        Private m_colSecurityAllowChangePassword As Nullable(Of Boolean)

        Public Property colReclassificationEmailSentDate() As Nullable(Of DateTime) Implements IrowVwRRClients.colReclassificationEmailSentDate
            Get
                Return m_colReclassificationEmailSentDate
            End Get
            Set
                If Not Same(m_colReclassificationEmailSentDate, Value) Then
                    m_colReclassificationEmailSentDate = Value
                    m_IsDirty(FieldIndex.colReclassificationEmailSentDate) = True
                End If
            End Set
        End Property
        Private m_colReclassificationEmailSentDate As Nullable(Of DateTime)

        Public Property colReclassificationEmailFollowUpDate() As Nullable(Of DateTime) Implements IrowVwRRClients.colReclassificationEmailFollowUpDate
            Get
                Return m_colReclassificationEmailFollowUpDate
            End Get
            Set
                If Not Same(m_colReclassificationEmailFollowUpDate, Value) Then
                    m_colReclassificationEmailFollowUpDate = Value
                    m_IsDirty(FieldIndex.colReclassificationEmailFollowUpDate) = True
                End If
            End Set
        End Property
        Private m_colReclassificationEmailFollowUpDate As Nullable(Of DateTime)

        Public Property colReclassificationCompletionDate() As Nullable(Of DateTime) Implements IrowVwRRClients.colReclassificationCompletionDate
            Get
                Return m_colReclassificationCompletionDate
            End Get
            Set
                If Not Same(m_colReclassificationCompletionDate, Value) Then
                    m_colReclassificationCompletionDate = Value
                    m_IsDirty(FieldIndex.colReclassificationCompletionDate) = True
                End If
            End Set
        End Property
        Private m_colReclassificationCompletionDate As Nullable(Of DateTime)

        Public Property colReclassificationLinkGUID() As String Implements IrowVwRRClients.colReclassificationLinkGUID
            Get
                Return m_colReclassificationLinkGUID
            End Get
            Set
                If Not Same(m_colReclassificationLinkGUID, Value) Then
                    m_colReclassificationLinkGUID = Value
                    m_IsDirty(FieldIndex.colReclassificationLinkGUID) = True
                End If
            End Set
        End Property
        Private m_colReclassificationLinkGUID As String

        Public Property colLastReclassificationCompletionDate() As Nullable(Of DateTime) Implements IrowVwRRClients.colLastReclassificationCompletionDate
            Get
                Return m_colLastReclassificationCompletionDate
            End Get
            Set
                If Not Same(m_colLastReclassificationCompletionDate, Value) Then
                    m_colLastReclassificationCompletionDate = Value
                    m_IsDirty(FieldIndex.colLastReclassificationCompletionDate) = True
                End If
            End Set
        End Property
        Private m_colLastReclassificationCompletionDate As Nullable(Of DateTime)

        Public Property colSysUserCreated() As String Implements IrowVwRRClients.colSysUserCreated
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

        Public Property colSysDateCreated() As Nullable(Of DateTime) Implements IrowVwRRClients.colSysDateCreated
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

        Public Property colSysUserModified() As String Implements IrowVwRRClients.colSysUserModified
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

        Public Property colSysDateModified() As Nullable(Of DateTime) Implements IrowVwRRClients.colSysDateModified
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

        Public Property colClientId() As Nullable(Of Integer) Implements IrowVwRRClients.colClientId
            Get
                Return m_colClientId
            End Get
            Set
                If Not Same(m_colClientId, Value) Then
                    m_colClientId = Value
                    m_IsDirty(FieldIndex.colClientId) = True
                End If
            End Set
        End Property
        Private m_colClientId As Nullable(Of Integer)

        Public Property colDefaultMetaCurrencyID() As Nullable(Of Integer) Implements IrowVwRRClients.colDefaultMetaCurrencyID
            Get
                Return m_colDefaultMetaCurrencyID
            End Get
            Set
                If Not Same(m_colDefaultMetaCurrencyID, Value) Then
                    m_colDefaultMetaCurrencyID = Value
                    m_IsDirty(FieldIndex.colDefaultMetaCurrencyID) = True
                End If
            End Set
        End Property
        Private m_colDefaultMetaCurrencyID As Nullable(Of Integer)


        Public Function IsDirty(pIndex As rowVwRRClients.FieldIndex) As Boolean Implements IrowVwRRClients.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwRRClients.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwRRClients.SetIsDirty
            m_IsDirty(FieldIndex.colCldbname) = pDirty
            m_IsDirty(FieldIndex.colClientname) = pDirty
            m_IsDirty(FieldIndex.colFeatures) = pDirty
            m_IsDirty(FieldIndex.colFileprefix) = pDirty
            m_IsDirty(FieldIndex.colClientdesigneenotify) = pDirty
            m_IsDirty(FieldIndex.colClientdesigneename) = pDirty
            m_IsDirty(FieldIndex.colClientdesigneeemail) = pDirty
            m_IsDirty(FieldIndex.colActive) = pDirty
            m_IsDirty(FieldIndex.colRecrespemail) = pDirty
            m_IsDirty(FieldIndex.colRecautofollowup) = pDirty
            m_IsDirty(FieldIndex.colRecfollowup1) = pDirty
            m_IsDirty(FieldIndex.colRecfollowup2) = pDirty
            m_IsDirty(FieldIndex.colRecfollowup3) = pDirty
            m_IsDirty(FieldIndex.colDatatransfer) = pDirty
            m_IsDirty(FieldIndex.colAutoRecStartDate) = pDirty
            m_IsDirty(FieldIndex.colAutoRecComments) = pDirty
            m_IsDirty(FieldIndex.colFireRatingKeyID) = pDirty
            m_IsDirty(FieldIndex.colBMRatingKeyID) = pDirty
            m_IsDirty(FieldIndex.colCustomAccessLabel) = pDirty
            m_IsDirty(FieldIndex.colWORecipientName) = pDirty
            m_IsDirty(FieldIndex.colWORecipientEmail) = pDirty
            m_IsDirty(FieldIndex.colWOSubject) = pDirty
            m_IsDirty(FieldIndex.colExchangeRateGroupID) = pDirty
            m_IsDirty(FieldIndex.colAutoRecLastProcessDate) = pDirty
            m_IsDirty(FieldIndex.colIfu) = pDirty
            m_IsDirty(FieldIndex.colPifu1) = pDirty
            m_IsDirty(FieldIndex.colPifu2) = pDirty
            m_IsDirty(FieldIndex.colPifu3) = pDirty
            m_IsDirty(FieldIndex.colPifu4) = pDirty
            m_IsDirty(FieldIndex.colImpClientDesName1) = pDirty
            m_IsDirty(FieldIndex.colImpClientDesEmail1) = pDirty
            m_IsDirty(FieldIndex.colImpClientDesName2) = pDirty
            m_IsDirty(FieldIndex.colImpClientDesEmail2) = pDirty
            m_IsDirty(FieldIndex.colImpClientDesName3) = pDirty
            m_IsDirty(FieldIndex.colImpClientDesEmail3) = pDirty
            m_IsDirty(FieldIndex.colAifu) = pDirty
            m_IsDirty(FieldIndex.colImpClientDesName4) = pDirty
            m_IsDirty(FieldIndex.colImpClientDesEmail4) = pDirty
            m_IsDirty(FieldIndex.colImpClientDesName5) = pDirty
            m_IsDirty(FieldIndex.colImpClientDesEmail5) = pDirty
            m_IsDirty(FieldIndex.colMgmtARR) = pDirty
            m_IsDirty(FieldIndex.colImpEmailAll) = pDirty
            m_IsDirty(FieldIndex.colSecurityPasswordExpireDays) = pDirty
            m_IsDirty(FieldIndex.colSecurityInactivityLockoutDays) = pDirty
            m_IsDirty(FieldIndex.colSecurityInactivityLockoutRemindDays) = pDirty
            m_IsDirty(FieldIndex.colSecurityPasswordMinimumLength) = pDirty
            m_IsDirty(FieldIndex.colSecurityPasswordTypeId) = pDirty
            m_IsDirty(FieldIndex.colDataTransferPackageId) = pDirty
            m_IsDirty(FieldIndex.colDataTransferPassword) = pDirty
            m_IsDirty(FieldIndex.colDataTransferEncryptionKey) = pDirty
            m_IsDirty(FieldIndex.colSecurityAllowChangePassword) = pDirty
            m_IsDirty(FieldIndex.colReclassificationEmailSentDate) = pDirty
            m_IsDirty(FieldIndex.colReclassificationEmailFollowUpDate) = pDirty
            m_IsDirty(FieldIndex.colReclassificationCompletionDate) = pDirty
            m_IsDirty(FieldIndex.colReclassificationLinkGUID) = pDirty
            m_IsDirty(FieldIndex.colLastReclassificationCompletionDate) = pDirty
            m_IsDirty(FieldIndex.colSysUserCreated) = pDirty
            m_IsDirty(FieldIndex.colSysDateCreated) = pDirty
            m_IsDirty(FieldIndex.colSysUserModified) = pDirty
            m_IsDirty(FieldIndex.colSysDateModified) = pDirty
            m_IsDirty(FieldIndex.colClientId) = pDirty
            m_IsDirty(FieldIndex.colDefaultMetaCurrencyID) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwRRClients) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwRRClients
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colCldbname  = 1
            colClientname 
            colFeatures 
            colFileprefix 
            colClientdesigneenotify 
            colClientdesigneename 
            colClientdesigneeemail 
            colActive 
            colRecrespemail 
            colRecautofollowup 
            colRecfollowup1 
            colRecfollowup2 
            colRecfollowup3 
            colDatatransfer 
            colAutoRecStartDate 
            colAutoRecComments 
            colFireRatingKeyID 
            colBMRatingKeyID 
            colCustomAccessLabel 
            colWORecipientName 
            colWORecipientEmail 
            colWOSubject 
            colExchangeRateGroupID 
            colAutoRecLastProcessDate 
            colIfu 
            colPifu1 
            colPifu2 
            colPifu3 
            colPifu4 
            colImpClientDesName1 
            colImpClientDesEmail1 
            colImpClientDesName2 
            colImpClientDesEmail2 
            colImpClientDesName3 
            colImpClientDesEmail3 
            colAifu 
            colImpClientDesName4 
            colImpClientDesEmail4 
            colImpClientDesName5 
            colImpClientDesEmail5 
            colMgmtARR 
            colImpEmailAll 
            colSecurityPasswordExpireDays 
            colSecurityInactivityLockoutDays 
            colSecurityInactivityLockoutRemindDays 
            colSecurityPasswordMinimumLength 
            colSecurityPasswordTypeId 
            colDataTransferPackageId 
            colDataTransferPassword 
            colDataTransferEncryptionKey 
            colSecurityAllowChangePassword 
            colReclassificationEmailSentDate 
            colReclassificationEmailFollowUpDate 
            colReclassificationCompletionDate 
            colReclassificationLinkGUID 
            colLastReclassificationCompletionDate 
            colSysUserCreated 
            colSysDateCreated 
            colSysUserModified 
            colSysDateModified 
            colClientId 
            colDefaultMetaCurrencyID 
        End Enum

        Private m_IsDirty(63) As Boolean

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

    Public Interface IrowVwRRClients
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colCldbname() As String
        Property colClientname() As String
        Property colFeatures() As String
        Property colFileprefix() As String
        Property colClientdesigneenotify() As Nullable(Of Boolean)
        Property colClientdesigneename() As String
        Property colClientdesigneeemail() As String
        Property colActive() As Nullable(Of Boolean)
        Property colRecrespemail() As String
        Property colRecautofollowup() As Nullable(Of Boolean)
        Property colRecfollowup1() As Nullable(Of Integer)
        Property colRecfollowup2() As Nullable(Of Integer)
        Property colRecfollowup3() As Nullable(Of Integer)
        Property colDatatransfer() As String
        Property colAutoRecStartDate() As Nullable(Of DateTime)
        Property colAutoRecComments() As String
        Property colFireRatingKeyID() As Nullable(Of Byte)
        Property colBMRatingKeyID() As Nullable(Of Byte)
        Property colCustomAccessLabel() As String
        Property colWORecipientName() As String
        Property colWORecipientEmail() As String
        Property colWOSubject() As String
        Property colExchangeRateGroupID() As Nullable(Of Byte)
        Property colAutoRecLastProcessDate() As Nullable(Of DateTime)
        Property colIfu() As Nullable(Of Boolean)
        Property colPifu1() As Nullable(Of Integer)
        Property colPifu2() As Nullable(Of Integer)
        Property colPifu3() As Nullable(Of Integer)
        Property colPifu4() As Nullable(Of Integer)
        Property colImpClientDesName1() As String
        Property colImpClientDesEmail1() As String
        Property colImpClientDesName2() As String
        Property colImpClientDesEmail2() As String
        Property colImpClientDesName3() As String
        Property colImpClientDesEmail3() As String
        Property colAifu() As String
        Property colImpClientDesName4() As String
        Property colImpClientDesEmail4() As String
        Property colImpClientDesName5() As String
        Property colImpClientDesEmail5() As String
        Property colMgmtARR() As Nullable(Of Boolean)
        Property colImpEmailAll() As Nullable(Of Boolean)
        Property colSecurityPasswordExpireDays() As Nullable(Of Integer)
        Property colSecurityInactivityLockoutDays() As Nullable(Of Integer)
        Property colSecurityInactivityLockoutRemindDays() As Nullable(Of Integer)
        Property colSecurityPasswordMinimumLength() As Nullable(Of Integer)
        Property colSecurityPasswordTypeId() As Nullable(Of Integer)
        Property colDataTransferPackageId() As Nullable(Of Integer)
        Property colDataTransferPassword() As String
        Property colDataTransferEncryptionKey() As String
        Property colSecurityAllowChangePassword() As Nullable(Of Boolean)
        Property colReclassificationEmailSentDate() As Nullable(Of DateTime)
        Property colReclassificationEmailFollowUpDate() As Nullable(Of DateTime)
        Property colReclassificationCompletionDate() As Nullable(Of DateTime)
        Property colReclassificationLinkGUID() As String
        Property colLastReclassificationCompletionDate() As Nullable(Of DateTime)
        Property colSysUserCreated() As String
        Property colSysDateCreated() As Nullable(Of DateTime)
        Property colSysUserModified() As String
        Property colSysDateModified() As Nullable(Of DateTime)
        Property colClientId() As Nullable(Of Integer)
        Property colDefaultMetaCurrencyID() As Nullable(Of Integer)
        Function IsDirty(pIndex As rowVwRRClients.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

