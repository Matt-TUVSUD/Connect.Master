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
    Partial Public Class VwDataTransferClient

        Public Shared Function LoadData() As List(Of rowVwDataTransferClient)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwDataTransferClient)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwDataTransferClient)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwDataTransferClient)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwDataTransferClient)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwDataTransferClient)
            Dim zReturn As New List(Of rowVwDataTransferClient)
            Dim zSQL As String = "SELECT * FROM [jv].[vwDataTransferClient]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwDataTransferClient)

			Try
	            Dim zReturn As New List(Of rowVwDataTransferClient)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwDataTransferClient

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwDataTransferClient		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwDataTransferClient)
			If Not pReader.IsDBNull(pReader.GetOrdinal("cldbname")) Then pObject.colCldbname = UtilSQLServer.SafeReader.SafeReadString(pReader, "cldbname")
			If Not pReader.IsDBNull(pReader.GetOrdinal("clientname")) Then pObject.colClientname = UtilSQLServer.SafeReader.SafeReadString(pReader, "clientname")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fileprefix")) Then pObject.colFileprefix = UtilSQLServer.SafeReader.SafeReadString(pReader, "fileprefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DataTransferPassword")) Then pObject.colDataTransferPassword = UtilSQLServer.SafeReader.SafeReadString(pReader, "DataTransferPassword")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DataTransferEncryptionKey")) Then pObject.colDataTransferEncryptionKey = UtilSQLServer.SafeReader.SafeReadString(pReader, "DataTransferEncryptionKey")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DataTransferPgpEnabled")) Then pObject.colDataTransferPgpEnabled = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "DataTransferPgpEnabled")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DataTransferPgpPublicKey")) Then pObject.colDataTransferPgpPublicKey = UtilSQLServer.SafeReader.SafeReadString(pReader, "DataTransferPgpPublicKey")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DataTransferFtpEnabled")) Then pObject.colDataTransferFtpEnabled = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "DataTransferFtpEnabled")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DataTransferFtpUrl")) Then pObject.colDataTransferFtpUrl = UtilSQLServer.SafeReader.SafeReadString(pReader, "DataTransferFtpUrl")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DataTransferOutputOptions")) Then pObject.colDataTransferOutputOptions = UtilSQLServer.SafeReader.SafeReadString(pReader, "DataTransferOutputOptions")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DataTransferFtpUserName")) Then pObject.colDataTransferFtpUserName = UtilSQLServer.SafeReader.SafeReadString(pReader, "DataTransferFtpUserName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DataTransferFtpPassword")) Then pObject.colDataTransferFtpPassword = UtilSQLServer.SafeReader.SafeReadString(pReader, "DataTransferFtpPassword")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DataTransferPgpFileExtension")) Then pObject.colDataTransferPgpFileExtension = UtilSQLServer.SafeReader.SafeReadString(pReader, "DataTransferPgpFileExtension")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DataTransferFtpLocalFolder")) Then pObject.colDataTransferFtpLocalFolder = UtilSQLServer.SafeReader.SafeReadString(pReader, "DataTransferFtpLocalFolder")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DataTransferFileNameFormatString")) Then pObject.colDataTransferFileNameFormatString = UtilSQLServer.SafeReader.SafeReadString(pReader, "DataTransferFileNameFormatString")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DataTransferRetrievalDate")) Then pObject.colDataTransferRetrievalDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "DataTransferRetrievalDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ClientDBRootPath")) Then pObject.colClientDBRootPath = UtilSQLServer.SafeReader.SafeReadString(pReader, "ClientDBRootPath")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DataTransferFtpMonthJson")) Then pObject.colDataTransferFtpMonthJson = UtilSQLServer.SafeReader.SafeReadString(pReader, "DataTransferFtpMonthJson")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DataTransferFtpDayJson")) Then pObject.colDataTransferFtpDayJson = UtilSQLServer.SafeReader.SafeReadString(pReader, "DataTransferFtpDayJson")
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
            Dim zSQL As String = "SELECT * FROM [jv].[vwDataTransferClient]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowVwDataTransferClient
        Implements IrowVwDataTransferClient

        Public Event Loaded(pUserState As Object) Implements IrowVwDataTransferClient.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwDataTransferClient.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwDataTransferClient.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwDataTransferClient.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwDataTransferClient.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwDataTransferClient.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colCldbname() As String Implements IrowVwDataTransferClient.colCldbname
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

        Public Property colClientname() As String Implements IrowVwDataTransferClient.colClientname
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

        Public Property colFileprefix() As String Implements IrowVwDataTransferClient.colFileprefix
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

        Public Property colDataTransferPassword() As String Implements IrowVwDataTransferClient.colDataTransferPassword
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

        Public Property colDataTransferEncryptionKey() As String Implements IrowVwDataTransferClient.colDataTransferEncryptionKey
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

        Public Property colDataTransferPgpEnabled() As Nullable(Of Boolean) Implements IrowVwDataTransferClient.colDataTransferPgpEnabled
            Get
                Return m_colDataTransferPgpEnabled
            End Get
            Set
                If Not Same(m_colDataTransferPgpEnabled, Value) Then
                    m_colDataTransferPgpEnabled = Value
                    m_IsDirty(FieldIndex.colDataTransferPgpEnabled) = True
                End If
            End Set
        End Property
        Private m_colDataTransferPgpEnabled As Nullable(Of Boolean)

        Public Property colDataTransferPgpPublicKey() As String Implements IrowVwDataTransferClient.colDataTransferPgpPublicKey
            Get
                Return m_colDataTransferPgpPublicKey
            End Get
            Set
                If Not Same(m_colDataTransferPgpPublicKey, Value) Then
                    m_colDataTransferPgpPublicKey = Value
                    m_IsDirty(FieldIndex.colDataTransferPgpPublicKey) = True
                End If
            End Set
        End Property
        Private m_colDataTransferPgpPublicKey As String

        Public Property colDataTransferFtpEnabled() As Nullable(Of Boolean) Implements IrowVwDataTransferClient.colDataTransferFtpEnabled
            Get
                Return m_colDataTransferFtpEnabled
            End Get
            Set
                If Not Same(m_colDataTransferFtpEnabled, Value) Then
                    m_colDataTransferFtpEnabled = Value
                    m_IsDirty(FieldIndex.colDataTransferFtpEnabled) = True
                End If
            End Set
        End Property
        Private m_colDataTransferFtpEnabled As Nullable(Of Boolean)

        Public Property colDataTransferFtpUrl() As String Implements IrowVwDataTransferClient.colDataTransferFtpUrl
            Get
                Return m_colDataTransferFtpUrl
            End Get
            Set
                If Not Same(m_colDataTransferFtpUrl, Value) Then
                    m_colDataTransferFtpUrl = Value
                    m_IsDirty(FieldIndex.colDataTransferFtpUrl) = True
                End If
            End Set
        End Property
        Private m_colDataTransferFtpUrl As String

        Public Property colDataTransferOutputOptions() As String Implements IrowVwDataTransferClient.colDataTransferOutputOptions
            Get
                Return m_colDataTransferOutputOptions
            End Get
            Set
                If Not Same(m_colDataTransferOutputOptions, Value) Then
                    m_colDataTransferOutputOptions = Value
                    m_IsDirty(FieldIndex.colDataTransferOutputOptions) = True
                End If
            End Set
        End Property
        Private m_colDataTransferOutputOptions As String

        Public Property colDataTransferFtpUserName() As String Implements IrowVwDataTransferClient.colDataTransferFtpUserName
            Get
                Return m_colDataTransferFtpUserName
            End Get
            Set
                If Not Same(m_colDataTransferFtpUserName, Value) Then
                    m_colDataTransferFtpUserName = Value
                    m_IsDirty(FieldIndex.colDataTransferFtpUserName) = True
                End If
            End Set
        End Property
        Private m_colDataTransferFtpUserName As String

        Public Property colDataTransferFtpPassword() As String Implements IrowVwDataTransferClient.colDataTransferFtpPassword
            Get
                Return m_colDataTransferFtpPassword
            End Get
            Set
                If Not Same(m_colDataTransferFtpPassword, Value) Then
                    m_colDataTransferFtpPassword = Value
                    m_IsDirty(FieldIndex.colDataTransferFtpPassword) = True
                End If
            End Set
        End Property
        Private m_colDataTransferFtpPassword As String

        Public Property colDataTransferPgpFileExtension() As String Implements IrowVwDataTransferClient.colDataTransferPgpFileExtension
            Get
                Return m_colDataTransferPgpFileExtension
            End Get
            Set
                If Not Same(m_colDataTransferPgpFileExtension, Value) Then
                    m_colDataTransferPgpFileExtension = Value
                    m_IsDirty(FieldIndex.colDataTransferPgpFileExtension) = True
                End If
            End Set
        End Property
        Private m_colDataTransferPgpFileExtension As String

        Public Property colDataTransferFtpLocalFolder() As String Implements IrowVwDataTransferClient.colDataTransferFtpLocalFolder
            Get
                Return m_colDataTransferFtpLocalFolder
            End Get
            Set
                If Not Same(m_colDataTransferFtpLocalFolder, Value) Then
                    m_colDataTransferFtpLocalFolder = Value
                    m_IsDirty(FieldIndex.colDataTransferFtpLocalFolder) = True
                End If
            End Set
        End Property
        Private m_colDataTransferFtpLocalFolder As String

        Public Property colDataTransferFileNameFormatString() As String Implements IrowVwDataTransferClient.colDataTransferFileNameFormatString
            Get
                Return m_colDataTransferFileNameFormatString
            End Get
            Set
                If Not Same(m_colDataTransferFileNameFormatString, Value) Then
                    m_colDataTransferFileNameFormatString = Value
                    m_IsDirty(FieldIndex.colDataTransferFileNameFormatString) = True
                End If
            End Set
        End Property
        Private m_colDataTransferFileNameFormatString As String

        Public Property colDataTransferRetrievalDate() As Nullable(Of DateTime) Implements IrowVwDataTransferClient.colDataTransferRetrievalDate
            Get
                Return m_colDataTransferRetrievalDate
            End Get
            Set
                If Not Same(m_colDataTransferRetrievalDate, Value) Then
                    m_colDataTransferRetrievalDate = Value
                    m_IsDirty(FieldIndex.colDataTransferRetrievalDate) = True
                End If
            End Set
        End Property
        Private m_colDataTransferRetrievalDate As Nullable(Of DateTime)

        Public Property colClientDBRootPath() As String Implements IrowVwDataTransferClient.colClientDBRootPath
            Get
                Return m_colClientDBRootPath
            End Get
            Set
                If Not Same(m_colClientDBRootPath, Value) Then
                    m_colClientDBRootPath = Value
                    m_IsDirty(FieldIndex.colClientDBRootPath) = True
                End If
            End Set
        End Property
        Private m_colClientDBRootPath As String

        Public Property colDataTransferFtpMonthJson() As String Implements IrowVwDataTransferClient.colDataTransferFtpMonthJson
            Get
                Return m_colDataTransferFtpMonthJson
            End Get
            Set
                If Not Same(m_colDataTransferFtpMonthJson, Value) Then
                    m_colDataTransferFtpMonthJson = Value
                    m_IsDirty(FieldIndex.colDataTransferFtpMonthJson) = True
                End If
            End Set
        End Property
        Private m_colDataTransferFtpMonthJson As String

        Public Property colDataTransferFtpDayJson() As String Implements IrowVwDataTransferClient.colDataTransferFtpDayJson
            Get
                Return m_colDataTransferFtpDayJson
            End Get
            Set
                If Not Same(m_colDataTransferFtpDayJson, Value) Then
                    m_colDataTransferFtpDayJson = Value
                    m_IsDirty(FieldIndex.colDataTransferFtpDayJson) = True
                End If
            End Set
        End Property
        Private m_colDataTransferFtpDayJson As String


        Public Function IsDirty(pIndex As rowVwDataTransferClient.FieldIndex) As Boolean Implements IrowVwDataTransferClient.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwDataTransferClient.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwDataTransferClient.SetIsDirty
            m_IsDirty(FieldIndex.colCldbname) = pDirty
            m_IsDirty(FieldIndex.colClientname) = pDirty
            m_IsDirty(FieldIndex.colFileprefix) = pDirty
            m_IsDirty(FieldIndex.colDataTransferPassword) = pDirty
            m_IsDirty(FieldIndex.colDataTransferEncryptionKey) = pDirty
            m_IsDirty(FieldIndex.colDataTransferPgpEnabled) = pDirty
            m_IsDirty(FieldIndex.colDataTransferPgpPublicKey) = pDirty
            m_IsDirty(FieldIndex.colDataTransferFtpEnabled) = pDirty
            m_IsDirty(FieldIndex.colDataTransferFtpUrl) = pDirty
            m_IsDirty(FieldIndex.colDataTransferOutputOptions) = pDirty
            m_IsDirty(FieldIndex.colDataTransferFtpUserName) = pDirty
            m_IsDirty(FieldIndex.colDataTransferFtpPassword) = pDirty
            m_IsDirty(FieldIndex.colDataTransferPgpFileExtension) = pDirty
            m_IsDirty(FieldIndex.colDataTransferFtpLocalFolder) = pDirty
            m_IsDirty(FieldIndex.colDataTransferFileNameFormatString) = pDirty
            m_IsDirty(FieldIndex.colDataTransferRetrievalDate) = pDirty
            m_IsDirty(FieldIndex.colClientDBRootPath) = pDirty
            m_IsDirty(FieldIndex.colDataTransferFtpMonthJson) = pDirty
            m_IsDirty(FieldIndex.colDataTransferFtpDayJson) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwDataTransferClient) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwDataTransferClient
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colCldbname  = 1
            colClientname 
            colFileprefix 
            colDataTransferPassword 
            colDataTransferEncryptionKey 
            colDataTransferPgpEnabled 
            colDataTransferPgpPublicKey 
            colDataTransferFtpEnabled 
            colDataTransferFtpUrl 
            colDataTransferOutputOptions 
            colDataTransferFtpUserName 
            colDataTransferFtpPassword 
            colDataTransferPgpFileExtension 
            colDataTransferFtpLocalFolder 
            colDataTransferFileNameFormatString 
            colDataTransferRetrievalDate 
            colClientDBRootPath 
            colDataTransferFtpMonthJson 
            colDataTransferFtpDayJson 
        End Enum

        Private m_IsDirty(19) As Boolean

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

    Public Interface IrowVwDataTransferClient
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colCldbname() As String
        Property colClientname() As String
        Property colFileprefix() As String
        Property colDataTransferPassword() As String
        Property colDataTransferEncryptionKey() As String
        Property colDataTransferPgpEnabled() As Nullable(Of Boolean)
        Property colDataTransferPgpPublicKey() As String
        Property colDataTransferFtpEnabled() As Nullable(Of Boolean)
        Property colDataTransferFtpUrl() As String
        Property colDataTransferOutputOptions() As String
        Property colDataTransferFtpUserName() As String
        Property colDataTransferFtpPassword() As String
        Property colDataTransferPgpFileExtension() As String
        Property colDataTransferFtpLocalFolder() As String
        Property colDataTransferFileNameFormatString() As String
        Property colDataTransferRetrievalDate() As Nullable(Of DateTime)
        Property colClientDBRootPath() As String
        Property colDataTransferFtpMonthJson() As String
        Property colDataTransferFtpDayJson() As String
        Function IsDirty(pIndex As rowVwDataTransferClient.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

