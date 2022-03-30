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
    Partial Public Class VwReclassificationAccount

        Public Shared Function LoadData() As List(Of rowVwReclassificationAccount)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwReclassificationAccount)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwReclassificationAccount)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwReclassificationAccount)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwReclassificationAccount)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwReclassificationAccount)
            Dim zReturn As New List(Of rowVwReclassificationAccount)
            Dim zSQL As String = "SELECT * FROM [jv].[vwReclassificationAccount]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwReclassificationAccount)

			Try
	            Dim zReturn As New List(Of rowVwReclassificationAccount)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwReclassificationAccount

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwReclassificationAccount		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwReclassificationAccount)
			If Not pReader.IsDBNull(pReader.GetOrdinal("LoginID")) Then pObject.colLoginID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "LoginID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fileprefix")) Then pObject.colFileprefix = UtilSQLServer.SafeReader.SafeReadString(pReader, "fileprefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("clientname")) Then pObject.colClientname = UtilSQLServer.SafeReader.SafeReadString(pReader, "clientname")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ServiceLeaderName")) Then pObject.colServiceLeaderName = UtilSQLServer.SafeReader.SafeReadString(pReader, "ServiceLeaderName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ServiceLeaderEmailAddress")) Then pObject.colServiceLeaderEmailAddress = UtilSQLServer.SafeReader.SafeReadString(pReader, "ServiceLeaderEmailAddress")
			If Not pReader.IsDBNull(pReader.GetOrdinal("asicontactname")) Then pObject.colAsicontactname = UtilSQLServer.SafeReader.SafeReadString(pReader, "asicontactname")
			If Not pReader.IsDBNull(pReader.GetOrdinal("connectemail")) Then pObject.colConnectemail = UtilSQLServer.SafeReader.SafeReadString(pReader, "connectemail")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ContractFrom")) Then pObject.colContractFrom = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "ContractFrom")
			If Not pReader.IsDBNull(pReader.GetOrdinal("MonthOrdinal")) Then pObject.colMonthOrdinal = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "MonthOrdinal")
			If Not pReader.IsDBNull(pReader.GetOrdinal("reclassificationemailsentdate")) Then pObject.colReclassificationemailsentdate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "reclassificationemailsentdate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("reclassificationemailfollowupdate")) Then pObject.colReclassificationemailfollowupdate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "reclassificationemailfollowupdate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("reclassificationlinkguid")) Then pObject.colReclassificationlinkguid = UtilSQLServer.SafeReader.SafeReadString(pReader, "reclassificationlinkguid")
			If Not pReader.IsDBNull(pReader.GetOrdinal("reclassificationcompletiondate")) Then pObject.colReclassificationcompletiondate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "reclassificationcompletiondate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("TodaysDate")) Then pObject.colTodaysDate = UtilSQLServer.SafeReader.SafeReadDate(pReader, "TodaysDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DateToSend1stRequestEmail")) Then pObject.colDateToSend1stRequestEmail = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "DateToSend1stRequestEmail")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DateToSend2ndRequestEmail")) Then pObject.colDateToSend2ndRequestEmail = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "DateToSend2ndRequestEmail")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Send1stRequestEmail")) Then pObject.colSend1stRequestEmail = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "Send1stRequestEmail")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Send2ndRequestEmail")) Then pObject.colSend2ndRequestEmail = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "Send2ndRequestEmail")
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
            Dim zSQL As String = "SELECT * FROM [jv].[vwReclassificationAccount]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowVwReclassificationAccount
        Implements IrowVwReclassificationAccount

        Public Event Loaded(pUserState As Object) Implements IrowVwReclassificationAccount.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwReclassificationAccount.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwReclassificationAccount.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwReclassificationAccount.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwReclassificationAccount.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwReclassificationAccount.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colLoginID() As Nullable(Of Integer) Implements IrowVwReclassificationAccount.colLoginID
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

        Public Property colFileprefix() As String Implements IrowVwReclassificationAccount.colFileprefix
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

        Public Property colClientname() As String Implements IrowVwReclassificationAccount.colClientname
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

        Public Property colServiceLeaderName() As String Implements IrowVwReclassificationAccount.colServiceLeaderName
            Get
                Return m_colServiceLeaderName
            End Get
            Set
                If Not Same(m_colServiceLeaderName, Value) Then
                    m_colServiceLeaderName = Value
                    m_IsDirty(FieldIndex.colServiceLeaderName) = True
                End If
            End Set
        End Property
        Private m_colServiceLeaderName As String

        Public Property colServiceLeaderEmailAddress() As String Implements IrowVwReclassificationAccount.colServiceLeaderEmailAddress
            Get
                Return m_colServiceLeaderEmailAddress
            End Get
            Set
                If Not Same(m_colServiceLeaderEmailAddress, Value) Then
                    m_colServiceLeaderEmailAddress = Value
                    m_IsDirty(FieldIndex.colServiceLeaderEmailAddress) = True
                End If
            End Set
        End Property
        Private m_colServiceLeaderEmailAddress As String

        Public Property colAsicontactname() As String Implements IrowVwReclassificationAccount.colAsicontactname
            Get
                Return m_colAsicontactname
            End Get
            Set
                If Not Same(m_colAsicontactname, Value) Then
                    m_colAsicontactname = Value
                    m_IsDirty(FieldIndex.colAsicontactname) = True
                End If
            End Set
        End Property
        Private m_colAsicontactname As String

        Public Property colConnectemail() As String Implements IrowVwReclassificationAccount.colConnectemail
            Get
                Return m_colConnectemail
            End Get
            Set
                If Not Same(m_colConnectemail, Value) Then
                    m_colConnectemail = Value
                    m_IsDirty(FieldIndex.colConnectemail) = True
                End If
            End Set
        End Property
        Private m_colConnectemail As String

        Public Property colContractFrom() As Nullable(Of DateTime) Implements IrowVwReclassificationAccount.colContractFrom
            Get
                Return m_colContractFrom
            End Get
            Set
                If Not Same(m_colContractFrom, Value) Then
                    m_colContractFrom = Value
                    m_IsDirty(FieldIndex.colContractFrom) = True
                End If
            End Set
        End Property
        Private m_colContractFrom As Nullable(Of DateTime)

        Public Property colMonthOrdinal() As Nullable(Of Integer) Implements IrowVwReclassificationAccount.colMonthOrdinal
            Get
                Return m_colMonthOrdinal
            End Get
            Set
                If Not Same(m_colMonthOrdinal, Value) Then
                    m_colMonthOrdinal = Value
                    m_IsDirty(FieldIndex.colMonthOrdinal) = True
                End If
            End Set
        End Property
        Private m_colMonthOrdinal As Nullable(Of Integer)

        Public Property colReclassificationemailsentdate() As Nullable(Of DateTime) Implements IrowVwReclassificationAccount.colReclassificationemailsentdate
            Get
                Return m_colReclassificationemailsentdate
            End Get
            Set
                If Not Same(m_colReclassificationemailsentdate, Value) Then
                    m_colReclassificationemailsentdate = Value
                    m_IsDirty(FieldIndex.colReclassificationemailsentdate) = True
                End If
            End Set
        End Property
        Private m_colReclassificationemailsentdate As Nullable(Of DateTime)

        Public Property colReclassificationemailfollowupdate() As Nullable(Of DateTime) Implements IrowVwReclassificationAccount.colReclassificationemailfollowupdate
            Get
                Return m_colReclassificationemailfollowupdate
            End Get
            Set
                If Not Same(m_colReclassificationemailfollowupdate, Value) Then
                    m_colReclassificationemailfollowupdate = Value
                    m_IsDirty(FieldIndex.colReclassificationemailfollowupdate) = True
                End If
            End Set
        End Property
        Private m_colReclassificationemailfollowupdate As Nullable(Of DateTime)

        Public Property colReclassificationlinkguid() As String Implements IrowVwReclassificationAccount.colReclassificationlinkguid
            Get
                Return m_colReclassificationlinkguid
            End Get
            Set
                If Not Same(m_colReclassificationlinkguid, Value) Then
                    m_colReclassificationlinkguid = Value
                    m_IsDirty(FieldIndex.colReclassificationlinkguid) = True
                End If
            End Set
        End Property
        Private m_colReclassificationlinkguid As String

        Public Property colReclassificationcompletiondate() As Nullable(Of DateTime) Implements IrowVwReclassificationAccount.colReclassificationcompletiondate
            Get
                Return m_colReclassificationcompletiondate
            End Get
            Set
                If Not Same(m_colReclassificationcompletiondate, Value) Then
                    m_colReclassificationcompletiondate = Value
                    m_IsDirty(FieldIndex.colReclassificationcompletiondate) = True
                End If
            End Set
        End Property
        Private m_colReclassificationcompletiondate As Nullable(Of DateTime)

        Public Property colTodaysDate() As Nullable(Of Date) Implements IrowVwReclassificationAccount.colTodaysDate
            Get
                Return m_colTodaysDate
            End Get
            Set
                If Not Same(m_colTodaysDate, Value) Then
                    m_colTodaysDate = Value
                    m_IsDirty(FieldIndex.colTodaysDate) = True
                End If
            End Set
        End Property
        Private m_colTodaysDate As Nullable(Of Date)

        Public Property colDateToSend1stRequestEmail() As Nullable(Of DateTime) Implements IrowVwReclassificationAccount.colDateToSend1stRequestEmail
            Get
                Return m_colDateToSend1stRequestEmail
            End Get
            Set
                If Not Same(m_colDateToSend1stRequestEmail, Value) Then
                    m_colDateToSend1stRequestEmail = Value
                    m_IsDirty(FieldIndex.colDateToSend1stRequestEmail) = True
                End If
            End Set
        End Property
        Private m_colDateToSend1stRequestEmail As Nullable(Of DateTime)

        Public Property colDateToSend2ndRequestEmail() As Nullable(Of DateTime) Implements IrowVwReclassificationAccount.colDateToSend2ndRequestEmail
            Get
                Return m_colDateToSend2ndRequestEmail
            End Get
            Set
                If Not Same(m_colDateToSend2ndRequestEmail, Value) Then
                    m_colDateToSend2ndRequestEmail = Value
                    m_IsDirty(FieldIndex.colDateToSend2ndRequestEmail) = True
                End If
            End Set
        End Property
        Private m_colDateToSend2ndRequestEmail As Nullable(Of DateTime)

        Public Property colSend1stRequestEmail() As Nullable(Of Boolean) Implements IrowVwReclassificationAccount.colSend1stRequestEmail
            Get
                Return m_colSend1stRequestEmail
            End Get
            Set
                If Not Same(m_colSend1stRequestEmail, Value) Then
                    m_colSend1stRequestEmail = Value
                    m_IsDirty(FieldIndex.colSend1stRequestEmail) = True
                End If
            End Set
        End Property
        Private m_colSend1stRequestEmail As Nullable(Of Boolean)

        Public Property colSend2ndRequestEmail() As Nullable(Of Boolean) Implements IrowVwReclassificationAccount.colSend2ndRequestEmail
            Get
                Return m_colSend2ndRequestEmail
            End Get
            Set
                If Not Same(m_colSend2ndRequestEmail, Value) Then
                    m_colSend2ndRequestEmail = Value
                    m_IsDirty(FieldIndex.colSend2ndRequestEmail) = True
                End If
            End Set
        End Property
        Private m_colSend2ndRequestEmail As Nullable(Of Boolean)


        Public Function IsDirty(pIndex As rowVwReclassificationAccount.FieldIndex) As Boolean Implements IrowVwReclassificationAccount.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwReclassificationAccount.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwReclassificationAccount.SetIsDirty
            m_IsDirty(FieldIndex.colLoginID) = pDirty
            m_IsDirty(FieldIndex.colFileprefix) = pDirty
            m_IsDirty(FieldIndex.colClientname) = pDirty
            m_IsDirty(FieldIndex.colServiceLeaderName) = pDirty
            m_IsDirty(FieldIndex.colServiceLeaderEmailAddress) = pDirty
            m_IsDirty(FieldIndex.colAsicontactname) = pDirty
            m_IsDirty(FieldIndex.colConnectemail) = pDirty
            m_IsDirty(FieldIndex.colContractFrom) = pDirty
            m_IsDirty(FieldIndex.colMonthOrdinal) = pDirty
            m_IsDirty(FieldIndex.colReclassificationemailsentdate) = pDirty
            m_IsDirty(FieldIndex.colReclassificationemailfollowupdate) = pDirty
            m_IsDirty(FieldIndex.colReclassificationlinkguid) = pDirty
            m_IsDirty(FieldIndex.colReclassificationcompletiondate) = pDirty
            m_IsDirty(FieldIndex.colTodaysDate) = pDirty
            m_IsDirty(FieldIndex.colDateToSend1stRequestEmail) = pDirty
            m_IsDirty(FieldIndex.colDateToSend2ndRequestEmail) = pDirty
            m_IsDirty(FieldIndex.colSend1stRequestEmail) = pDirty
            m_IsDirty(FieldIndex.colSend2ndRequestEmail) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwReclassificationAccount) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwReclassificationAccount
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colLoginID  = 1
            colFileprefix 
            colClientname 
            colServiceLeaderName 
            colServiceLeaderEmailAddress 
            colAsicontactname 
            colConnectemail 
            colContractFrom 
            colMonthOrdinal 
            colReclassificationemailsentdate 
            colReclassificationemailfollowupdate 
            colReclassificationlinkguid 
            colReclassificationcompletiondate 
            colTodaysDate 
            colDateToSend1stRequestEmail 
            colDateToSend2ndRequestEmail 
            colSend1stRequestEmail 
            colSend2ndRequestEmail 
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

    Public Interface IrowVwReclassificationAccount
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colLoginID() As Nullable(Of Integer)
        Property colFileprefix() As String
        Property colClientname() As String
        Property colServiceLeaderName() As String
        Property colServiceLeaderEmailAddress() As String
        Property colAsicontactname() As String
        Property colConnectemail() As String
        Property colContractFrom() As Nullable(Of DateTime)
        Property colMonthOrdinal() As Nullable(Of Integer)
        Property colReclassificationemailsentdate() As Nullable(Of DateTime)
        Property colReclassificationemailfollowupdate() As Nullable(Of DateTime)
        Property colReclassificationlinkguid() As String
        Property colReclassificationcompletiondate() As Nullable(Of DateTime)
        Property colTodaysDate() As Nullable(Of Date)
        Property colDateToSend1stRequestEmail() As Nullable(Of DateTime)
        Property colDateToSend2ndRequestEmail() As Nullable(Of DateTime)
        Property colSend1stRequestEmail() As Nullable(Of Boolean)
        Property colSend2ndRequestEmail() As Nullable(Of Boolean)
        Function IsDirty(pIndex As rowVwReclassificationAccount.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

