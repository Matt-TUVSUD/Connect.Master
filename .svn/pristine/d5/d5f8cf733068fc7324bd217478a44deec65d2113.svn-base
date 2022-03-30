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
    Partial Public Class VwUserActivityLog

        Public Shared Function LoadData() As List(Of rowVwUserActivityLog)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwUserActivityLog)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwUserActivityLog)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwUserActivityLog)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwUserActivityLog)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwUserActivityLog)
            Dim zReturn As New List(Of rowVwUserActivityLog)
            Dim zSQL As String = "SELECT * FROM [gv].[vwUserActivityLog]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwUserActivityLog)

			Try
	            Dim zReturn As New List(Of rowVwUserActivityLog)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwUserActivityLog

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwUserActivityLog		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwUserActivityLog)
			If Not pReader.IsDBNull(pReader.GetOrdinal("ID")) Then pObject.colId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "ID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("clientname")) Then pObject.colClientname = UtilSQLServer.SafeReader.SafeReadString(pReader, "clientname")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FullName")) Then pObject.colFullName = UtilSQLServer.SafeReader.SafeReadString(pReader, "FullName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("EmailAddress")) Then pObject.colEmailAddress = UtilSQLServer.SafeReader.SafeReadString(pReader, "EmailAddress")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LastLoginDateTime")) Then pObject.colLastLoginDateTime = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "LastLoginDateTime")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LastActivityDateTime")) Then pObject.colLastActivityDateTime = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "LastActivityDateTime")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Duration")) Then pObject.colDuration = UtilSQLServer.SafeReader.SafeReadString(pReader, "Duration")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FilePrefix")) Then pObject.colFilePrefix = UtilSQLServer.SafeReader.SafeReadString(pReader, "FilePrefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LoginID")) Then pObject.colLoginID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "LoginID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Internal")) Then pObject.colInternal = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "Internal")
			If Not pReader.IsDBNull(pReader.GetOrdinal("UserLogout")) Then pObject.colUserLogout = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "UserLogout")
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
            Dim zSQL As String = "SELECT * FROM [gv].[vwUserActivityLog]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowVwUserActivityLog
        Implements IrowVwUserActivityLog

        Public Event Loaded(pUserState As Object) Implements IrowVwUserActivityLog.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwUserActivityLog.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwUserActivityLog.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwUserActivityLog.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwUserActivityLog.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwUserActivityLog.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colId() As Nullable(Of Integer) Implements IrowVwUserActivityLog.colId
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

        Public Property colClientname() As String Implements IrowVwUserActivityLog.colClientname
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

        Public Property colFullName() As String Implements IrowVwUserActivityLog.colFullName
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

        Public Property colEmailAddress() As String Implements IrowVwUserActivityLog.colEmailAddress
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

        Public Property colLastLoginDateTime() As Nullable(Of DateTime) Implements IrowVwUserActivityLog.colLastLoginDateTime
            Get
                Return m_colLastLoginDateTime
            End Get
            Set
                If Not Same(m_colLastLoginDateTime, Value) Then
                    m_colLastLoginDateTime = Value
                    m_IsDirty(FieldIndex.colLastLoginDateTime) = True
                End If
            End Set
        End Property
        Private m_colLastLoginDateTime As Nullable(Of DateTime)

        Public Property colLastActivityDateTime() As Nullable(Of DateTime) Implements IrowVwUserActivityLog.colLastActivityDateTime
            Get
                Return m_colLastActivityDateTime
            End Get
            Set
                If Not Same(m_colLastActivityDateTime, Value) Then
                    m_colLastActivityDateTime = Value
                    m_IsDirty(FieldIndex.colLastActivityDateTime) = True
                End If
            End Set
        End Property
        Private m_colLastActivityDateTime As Nullable(Of DateTime)

        Public Property colDuration() As String Implements IrowVwUserActivityLog.colDuration
            Get
                Return m_colDuration
            End Get
            Set
                If Not Same(m_colDuration, Value) Then
                    m_colDuration = Value
                    m_IsDirty(FieldIndex.colDuration) = True
                End If
            End Set
        End Property
        Private m_colDuration As String

        Public Property colFilePrefix() As String Implements IrowVwUserActivityLog.colFilePrefix
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

        Public Property colLoginID() As Nullable(Of Integer) Implements IrowVwUserActivityLog.colLoginID
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

        Public Property colInternal() As Nullable(Of Boolean) Implements IrowVwUserActivityLog.colInternal
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

        Public Property colUserLogout() As Nullable(Of Boolean) Implements IrowVwUserActivityLog.colUserLogout
            Get
                Return m_colUserLogout
            End Get
            Set
                If Not Same(m_colUserLogout, Value) Then
                    m_colUserLogout = Value
                    m_IsDirty(FieldIndex.colUserLogout) = True
                End If
            End Set
        End Property
        Private m_colUserLogout As Nullable(Of Boolean)


        Public Function IsDirty(pIndex As rowVwUserActivityLog.FieldIndex) As Boolean Implements IrowVwUserActivityLog.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwUserActivityLog.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwUserActivityLog.SetIsDirty
            m_IsDirty(FieldIndex.colId) = pDirty
            m_IsDirty(FieldIndex.colClientname) = pDirty
            m_IsDirty(FieldIndex.colFullName) = pDirty
            m_IsDirty(FieldIndex.colEmailAddress) = pDirty
            m_IsDirty(FieldIndex.colLastLoginDateTime) = pDirty
            m_IsDirty(FieldIndex.colLastActivityDateTime) = pDirty
            m_IsDirty(FieldIndex.colDuration) = pDirty
            m_IsDirty(FieldIndex.colFilePrefix) = pDirty
            m_IsDirty(FieldIndex.colLoginID) = pDirty
            m_IsDirty(FieldIndex.colInternal) = pDirty
            m_IsDirty(FieldIndex.colUserLogout) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwUserActivityLog) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwUserActivityLog
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colId  = 1
            colClientname 
            colFullName 
            colEmailAddress 
            colLastLoginDateTime 
            colLastActivityDateTime 
            colDuration 
            colFilePrefix 
            colLoginID 
            colInternal 
            colUserLogout 
        End Enum

        Private m_IsDirty(11) As Boolean

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

    Public Interface IrowVwUserActivityLog
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colId() As Nullable(Of Integer)
        Property colClientname() As String
        Property colFullName() As String
        Property colEmailAddress() As String
        Property colLastLoginDateTime() As Nullable(Of DateTime)
        Property colLastActivityDateTime() As Nullable(Of DateTime)
        Property colDuration() As String
        Property colFilePrefix() As String
        Property colLoginID() As Nullable(Of Integer)
        Property colInternal() As Nullable(Of Boolean)
        Property colUserLogout() As Nullable(Of Boolean)
        Function IsDirty(pIndex As rowVwUserActivityLog.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

