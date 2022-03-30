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
    Partial Public Class VwBatchProcessingSet

        Public Shared Function LoadData() As List(Of rowVwBatchProcessingSet)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwBatchProcessingSet)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwBatchProcessingSet)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwBatchProcessingSet)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwBatchProcessingSet)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwBatchProcessingSet)
            Dim zReturn As New List(Of rowVwBatchProcessingSet)
            Dim zSQL As String = "SELECT * FROM [fv].[vwBatchProcessingSet]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwBatchProcessingSet)

			Try
	            Dim zReturn As New List(Of rowVwBatchProcessingSet)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwBatchProcessingSet

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwBatchProcessingSet		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwBatchProcessingSet)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldId")) Then pObject.colFldId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldCreateDate")) Then pObject.colFldCreateDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "fldCreateDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFilePrefix")) Then pObject.colFldFilePrefix = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldFilePrefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldGroupName")) Then pObject.colFldGroupName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldGroupName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldStatus")) Then pObject.colFldStatus = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldStatus")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFileName")) Then pObject.colFldFileName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldFileName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldDisable")) Then pObject.colFldDisable = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldDisable")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldIsMyBatchReport")) Then pObject.colFldIsMyBatchReport = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldIsMyBatchReport")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldCreatedByGsafeUserEmail")) Then pObject.colFldCreatedByGsafeUserEmail = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldCreatedByGsafeUserEmail")
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
            Dim zSQL As String = "SELECT * FROM [fv].[vwBatchProcessingSet]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowVwBatchProcessingSet
        Implements IrowVwBatchProcessingSet

        Public Event Loaded(pUserState As Object) Implements IrowVwBatchProcessingSet.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwBatchProcessingSet.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwBatchProcessingSet.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwBatchProcessingSet.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwBatchProcessingSet.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwBatchProcessingSet.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldId() As Nullable(Of Integer) Implements IrowVwBatchProcessingSet.colFldId
            Get
                Return m_colFldId
            End Get
            Set
                If Not Same(m_colFldId, Value) Then
                    m_colFldId = Value
                    m_IsDirty(FieldIndex.colFldId) = True
                End If
            End Set
        End Property
        Private m_colFldId As Nullable(Of Integer)

        Public Property colFldCreateDate() As Nullable(Of DateTime) Implements IrowVwBatchProcessingSet.colFldCreateDate
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

        Public Property colFldFilePrefix() As String Implements IrowVwBatchProcessingSet.colFldFilePrefix
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

        Public Property colFldGroupName() As String Implements IrowVwBatchProcessingSet.colFldGroupName
            Get
                Return m_colFldGroupName
            End Get
            Set
                If Not Same(m_colFldGroupName, Value) Then
                    m_colFldGroupName = Value
                    m_IsDirty(FieldIndex.colFldGroupName) = True
                End If
            End Set
        End Property
        Private m_colFldGroupName As String

        Public Property colFldStatus() As String Implements IrowVwBatchProcessingSet.colFldStatus
            Get
                Return m_colFldStatus
            End Get
            Set
                If Not Same(m_colFldStatus, Value) Then
                    m_colFldStatus = Value
                    m_IsDirty(FieldIndex.colFldStatus) = True
                End If
            End Set
        End Property
        Private m_colFldStatus As String

        Public Property colFldFileName() As String Implements IrowVwBatchProcessingSet.colFldFileName
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

        Public Property colFldDisable() As Nullable(Of Boolean) Implements IrowVwBatchProcessingSet.colFldDisable
            Get
                Return m_colFldDisable
            End Get
            Set
                If Not Same(m_colFldDisable, Value) Then
                    m_colFldDisable = Value
                    m_IsDirty(FieldIndex.colFldDisable) = True
                End If
            End Set
        End Property
        Private m_colFldDisable As Nullable(Of Boolean)

        Public Property colFldIsMyBatchReport() As Nullable(Of Boolean) Implements IrowVwBatchProcessingSet.colFldIsMyBatchReport
            Get
                Return m_colFldIsMyBatchReport
            End Get
            Set
                If Not Same(m_colFldIsMyBatchReport, Value) Then
                    m_colFldIsMyBatchReport = Value
                    m_IsDirty(FieldIndex.colFldIsMyBatchReport) = True
                End If
            End Set
        End Property
        Private m_colFldIsMyBatchReport As Nullable(Of Boolean)

        Public Property colFldCreatedByGsafeUserEmail() As String Implements IrowVwBatchProcessingSet.colFldCreatedByGsafeUserEmail
            Get
                Return m_colFldCreatedByGsafeUserEmail
            End Get
            Set
                If Not Same(m_colFldCreatedByGsafeUserEmail, Value) Then
                    m_colFldCreatedByGsafeUserEmail = Value
                    m_IsDirty(FieldIndex.colFldCreatedByGsafeUserEmail) = True
                End If
            End Set
        End Property
        Private m_colFldCreatedByGsafeUserEmail As String


        Public Function IsDirty(pIndex As rowVwBatchProcessingSet.FieldIndex) As Boolean Implements IrowVwBatchProcessingSet.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwBatchProcessingSet.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwBatchProcessingSet.SetIsDirty
            m_IsDirty(FieldIndex.colFldId) = pDirty
            m_IsDirty(FieldIndex.colFldCreateDate) = pDirty
            m_IsDirty(FieldIndex.colFldFilePrefix) = pDirty
            m_IsDirty(FieldIndex.colFldGroupName) = pDirty
            m_IsDirty(FieldIndex.colFldStatus) = pDirty
            m_IsDirty(FieldIndex.colFldFileName) = pDirty
            m_IsDirty(FieldIndex.colFldDisable) = pDirty
            m_IsDirty(FieldIndex.colFldIsMyBatchReport) = pDirty
            m_IsDirty(FieldIndex.colFldCreatedByGsafeUserEmail) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwBatchProcessingSet) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwBatchProcessingSet
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldId  = 1
            colFldCreateDate 
            colFldFilePrefix 
            colFldGroupName 
            colFldStatus 
            colFldFileName 
            colFldDisable 
            colFldIsMyBatchReport 
            colFldCreatedByGsafeUserEmail 
        End Enum

        Private m_IsDirty(9) As Boolean

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

    Public Interface IrowVwBatchProcessingSet
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldId() As Nullable(Of Integer)
        Property colFldCreateDate() As Nullable(Of DateTime)
        Property colFldFilePrefix() As String
        Property colFldGroupName() As String
        Property colFldStatus() As String
        Property colFldFileName() As String
        Property colFldDisable() As Nullable(Of Boolean)
        Property colFldIsMyBatchReport() As Nullable(Of Boolean)
        Property colFldCreatedByGsafeUserEmail() As String
        Function IsDirty(pIndex As rowVwBatchProcessingSet.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

