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
    Partial Public Class VwBatchReportFileList

        Public Shared Function LoadData() As List(Of rowVwBatchReportFileList)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwBatchReportFileList)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwBatchReportFileList)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwBatchReportFileList)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwBatchReportFileList)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwBatchReportFileList)
            Dim zReturn As New List(Of rowVwBatchReportFileList)
            Dim zSQL As String = "SELECT * FROM [dbo].[vwBatchReportFileList]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwBatchReportFileList)

			Try
	            Dim zReturn As New List(Of rowVwBatchReportFileList)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwBatchReportFileList

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwBatchReportFileList		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwBatchReportFileList)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFilePrefix")) Then pObject.colFldFilePrefix = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldFilePrefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("clientname")) Then pObject.colClientname = UtilSQLServer.SafeReader.SafeReadString(pReader, "clientname")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldCreatedByGsafeId")) Then pObject.colFldCreatedByGsafeId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldCreatedByGsafeId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSetId")) Then pObject.colFldSetId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldSetId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldGuid")) Then pObject.colFldGuid = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldGuid")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldCreateDate")) Then pObject.colFldCreateDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "fldCreateDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldAccessDate")) Then pObject.colFldAccessDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "fldAccessDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFileSize")) Then pObject.colFldFileSize = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldFileSize")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldMime")) Then pObject.colFldMime = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldMime")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldExtension")) Then pObject.colFldExtension = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldExtension")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFileName")) Then pObject.colFldFileName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldFileName")
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
            Dim zSQL As String = "SELECT * FROM [dbo].[vwBatchReportFileList]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowVwBatchReportFileList
        Implements IrowVwBatchReportFileList

        Public Event Loaded(pUserState As Object) Implements IrowVwBatchReportFileList.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwBatchReportFileList.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwBatchReportFileList.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwBatchReportFileList.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwBatchReportFileList.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwBatchReportFileList.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldFilePrefix() As String Implements IrowVwBatchReportFileList.colFldFilePrefix
            Get
                Return m_colFldFilePrefix
            End Get
            Set
                If Not Same(m_colFldFilePrefix, Value) Then
                    m_colFldFilePrefix = Value
                    m_IsDirty(FieldIndex.colFldFilePrefix) = True
                End If
            End Set
        End Property
        Private m_colFldFilePrefix As String

        Public Property colClientname() As String Implements IrowVwBatchReportFileList.colClientname
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

        Public Property colFldCreatedByGsafeId() As Nullable(Of Integer) Implements IrowVwBatchReportFileList.colFldCreatedByGsafeId
            Get
                Return m_colFldCreatedByGsafeId
            End Get
            Set
                If Not Same(m_colFldCreatedByGsafeId, Value) Then
                    m_colFldCreatedByGsafeId = Value
                    m_IsDirty(FieldIndex.colFldCreatedByGsafeId) = True
                End If
            End Set
        End Property
        Private m_colFldCreatedByGsafeId As Nullable(Of Integer)

        Public Property colFldSetId() As Nullable(Of Integer) Implements IrowVwBatchReportFileList.colFldSetId
            Get
                Return m_colFldSetId
            End Get
            Set
                If Not Same(m_colFldSetId, Value) Then
                    m_colFldSetId = Value
                    m_IsDirty(FieldIndex.colFldSetId) = True
                End If
            End Set
        End Property
        Private m_colFldSetId As Nullable(Of Integer)

        Public Property colFldGuid() As String Implements IrowVwBatchReportFileList.colFldGuid
            Get
                Return m_colFldGuid
            End Get
            Set
                If Not Same(m_colFldGuid, Value) Then
                    m_colFldGuid = Value
                    m_IsDirty(FieldIndex.colFldGuid) = True
                End If
            End Set
        End Property
        Private m_colFldGuid As String

        Public Property colFldCreateDate() As Nullable(Of DateTime) Implements IrowVwBatchReportFileList.colFldCreateDate
            Get
                Return m_colFldCreateDate
            End Get
            Set
                If Not Same(m_colFldCreateDate, Value) Then
                    m_colFldCreateDate = Value
                    m_IsDirty(FieldIndex.colFldCreateDate) = True
                End If
            End Set
        End Property
        Private m_colFldCreateDate As Nullable(Of DateTime)

        Public Property colFldAccessDate() As Nullable(Of DateTime) Implements IrowVwBatchReportFileList.colFldAccessDate
            Get
                Return m_colFldAccessDate
            End Get
            Set
                If Not Same(m_colFldAccessDate, Value) Then
                    m_colFldAccessDate = Value
                    m_IsDirty(FieldIndex.colFldAccessDate) = True
                End If
            End Set
        End Property
        Private m_colFldAccessDate As Nullable(Of DateTime)

        Public Property colFldFileSize() As Nullable(Of Integer) Implements IrowVwBatchReportFileList.colFldFileSize
            Get
                Return m_colFldFileSize
            End Get
            Set
                If Not Same(m_colFldFileSize, Value) Then
                    m_colFldFileSize = Value
                    m_IsDirty(FieldIndex.colFldFileSize) = True
                End If
            End Set
        End Property
        Private m_colFldFileSize As Nullable(Of Integer)

        Public Property colFldMime() As String Implements IrowVwBatchReportFileList.colFldMime
            Get
                Return m_colFldMime
            End Get
            Set
                If Not Same(m_colFldMime, Value) Then
                    m_colFldMime = Value
                    m_IsDirty(FieldIndex.colFldMime) = True
                End If
            End Set
        End Property
        Private m_colFldMime As String

        Public Property colFldExtension() As String Implements IrowVwBatchReportFileList.colFldExtension
            Get
                Return m_colFldExtension
            End Get
            Set
                If Not Same(m_colFldExtension, Value) Then
                    m_colFldExtension = Value
                    m_IsDirty(FieldIndex.colFldExtension) = True
                End If
            End Set
        End Property
        Private m_colFldExtension As String

        Public Property colFldFileName() As String Implements IrowVwBatchReportFileList.colFldFileName
            Get
                Return m_colFldFileName
            End Get
            Set
                If Not Same(m_colFldFileName, Value) Then
                    m_colFldFileName = Value
                    m_IsDirty(FieldIndex.colFldFileName) = True
                End If
            End Set
        End Property
        Private m_colFldFileName As String


        Public Function IsDirty(pIndex As rowVwBatchReportFileList.FieldIndex) As Boolean Implements IrowVwBatchReportFileList.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwBatchReportFileList.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwBatchReportFileList.SetIsDirty
            m_IsDirty(FieldIndex.colFldFilePrefix) = pDirty
            m_IsDirty(FieldIndex.colClientname) = pDirty
            m_IsDirty(FieldIndex.colFldCreatedByGsafeId) = pDirty
            m_IsDirty(FieldIndex.colFldSetId) = pDirty
            m_IsDirty(FieldIndex.colFldGuid) = pDirty
            m_IsDirty(FieldIndex.colFldCreateDate) = pDirty
            m_IsDirty(FieldIndex.colFldAccessDate) = pDirty
            m_IsDirty(FieldIndex.colFldFileSize) = pDirty
            m_IsDirty(FieldIndex.colFldMime) = pDirty
            m_IsDirty(FieldIndex.colFldExtension) = pDirty
            m_IsDirty(FieldIndex.colFldFileName) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwBatchReportFileList) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwBatchReportFileList
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldFilePrefix  = 1
            colClientname 
            colFldCreatedByGsafeId 
            colFldSetId 
            colFldGuid 
            colFldCreateDate 
            colFldAccessDate 
            colFldFileSize 
            colFldMime 
            colFldExtension 
            colFldFileName 
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

    Public Interface IrowVwBatchReportFileList
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldFilePrefix() As String
        Property colClientname() As String
        Property colFldCreatedByGsafeId() As Nullable(Of Integer)
        Property colFldSetId() As Nullable(Of Integer)
        Property colFldGuid() As String
        Property colFldCreateDate() As Nullable(Of DateTime)
        Property colFldAccessDate() As Nullable(Of DateTime)
        Property colFldFileSize() As Nullable(Of Integer)
        Property colFldMime() As String
        Property colFldExtension() As String
        Property colFldFileName() As String
        Function IsDirty(pIndex As rowVwBatchReportFileList.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

