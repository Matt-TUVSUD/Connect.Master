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
    Partial Public Class VwDataTransferMetaGrid

        Public Shared Function LoadData() As List(Of rowVwDataTransferMetaGrid)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwDataTransferMetaGrid)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwDataTransferMetaGrid)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwDataTransferMetaGrid)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwDataTransferMetaGrid)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwDataTransferMetaGrid)
            Dim zReturn As New List(Of rowVwDataTransferMetaGrid)
            Dim zSQL As String = "SELECT * FROM [jv].[vwDataTransferMetaGrid]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwDataTransferMetaGrid)

			Try
	            Dim zReturn As New List(Of rowVwDataTransferMetaGrid)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwDataTransferMetaGrid

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwDataTransferMetaGrid		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwDataTransferMetaGrid)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldId")) Then pObject.colFldId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldGridId")) Then pObject.colFldGridId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldGridId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFilePrefix")) Then pObject.colFldFilePrefix = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldFilePrefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFileName")) Then pObject.colFldFileName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldFileName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSourceId")) Then pObject.colFldSourceId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldSourceId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSchemaName")) Then pObject.colFldSchemaName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldSchemaName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldObjectName")) Then pObject.colFldObjectName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldObjectName")
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
            Dim zSQL As String = "SELECT * FROM [jv].[vwDataTransferMetaGrid]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowVwDataTransferMetaGrid
        Implements IrowVwDataTransferMetaGrid

        Public Event Loaded(pUserState As Object) Implements IrowVwDataTransferMetaGrid.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwDataTransferMetaGrid.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwDataTransferMetaGrid.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwDataTransferMetaGrid.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwDataTransferMetaGrid.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwDataTransferMetaGrid.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldId() As Nullable(Of Integer) Implements IrowVwDataTransferMetaGrid.colFldId
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

        Public Property colFldGridId() As Nullable(Of Integer) Implements IrowVwDataTransferMetaGrid.colFldGridId
            Get
                Return m_colFldGridId
            End Get
            Set
                If Not Same(m_colFldGridId, Value) Then
                    m_colFldGridId = Value
                    m_IsDirty(FieldIndex.colFldGridId) = True
                End If
            End Set
        End Property
        Private m_colFldGridId As Nullable(Of Integer)

        Public Property colFldFilePrefix() As String Implements IrowVwDataTransferMetaGrid.colFldFilePrefix
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

        Public Property colFldFileName() As String Implements IrowVwDataTransferMetaGrid.colFldFileName
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

        Public Property colFldSourceId() As Nullable(Of Integer) Implements IrowVwDataTransferMetaGrid.colFldSourceId
            Get
                Return m_colFldSourceId
            End Get
            Set
                If Not Same(m_colFldSourceId, Value) Then
                    m_colFldSourceId = Value
                    m_IsDirty(FieldIndex.colFldSourceId) = True
                End If
            End Set
        End Property
        Private m_colFldSourceId As Nullable(Of Integer)

        Public Property colFldSchemaName() As String Implements IrowVwDataTransferMetaGrid.colFldSchemaName
            Get
                Return m_colFldSchemaName
            End Get
            Set
                If Not Same(m_colFldSchemaName, Value) Then
                    m_colFldSchemaName = Value
                    m_IsDirty(FieldIndex.colFldSchemaName) = True
                End If
            End Set
        End Property
        Private m_colFldSchemaName As String

        Public Property colFldObjectName() As String Implements IrowVwDataTransferMetaGrid.colFldObjectName
            Get
                Return m_colFldObjectName
            End Get
            Set
                If Not Same(m_colFldObjectName, Value) Then
                    m_colFldObjectName = Value
                    m_IsDirty(FieldIndex.colFldObjectName) = True
                End If
            End Set
        End Property
        Private m_colFldObjectName As String


        Public Function IsDirty(pIndex As rowVwDataTransferMetaGrid.FieldIndex) As Boolean Implements IrowVwDataTransferMetaGrid.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwDataTransferMetaGrid.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwDataTransferMetaGrid.SetIsDirty
            m_IsDirty(FieldIndex.colFldId) = pDirty
            m_IsDirty(FieldIndex.colFldGridId) = pDirty
            m_IsDirty(FieldIndex.colFldFilePrefix) = pDirty
            m_IsDirty(FieldIndex.colFldFileName) = pDirty
            m_IsDirty(FieldIndex.colFldSourceId) = pDirty
            m_IsDirty(FieldIndex.colFldSchemaName) = pDirty
            m_IsDirty(FieldIndex.colFldObjectName) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwDataTransferMetaGrid) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwDataTransferMetaGrid
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldId  = 1
            colFldGridId 
            colFldFilePrefix 
            colFldFileName 
            colFldSourceId 
            colFldSchemaName 
            colFldObjectName 
        End Enum

        Private m_IsDirty(7) As Boolean

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

    Public Interface IrowVwDataTransferMetaGrid
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldId() As Nullable(Of Integer)
        Property colFldGridId() As Nullable(Of Integer)
        Property colFldFilePrefix() As String
        Property colFldFileName() As String
        Property colFldSourceId() As Nullable(Of Integer)
        Property colFldSchemaName() As String
        Property colFldObjectName() As String
        Function IsDirty(pIndex As rowVwDataTransferMetaGrid.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

