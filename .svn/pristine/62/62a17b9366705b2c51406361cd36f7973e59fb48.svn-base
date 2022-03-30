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
    Partial Public Class VwDataTransferReportArchiveValidation

        Public Shared Function LoadData() As List(Of rowVwDataTransferReportArchiveValidation)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwDataTransferReportArchiveValidation)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwDataTransferReportArchiveValidation)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwDataTransferReportArchiveValidation)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwDataTransferReportArchiveValidation)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwDataTransferReportArchiveValidation)
            Dim zReturn As New List(Of rowVwDataTransferReportArchiveValidation)
            Dim zSQL As String = "SELECT * FROM [jv].[vwDataTransferReportArchiveValidation]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwDataTransferReportArchiveValidation)

			Try
	            Dim zReturn As New List(Of rowVwDataTransferReportArchiveValidation)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwDataTransferReportArchiveValidation

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwDataTransferReportArchiveValidation		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwDataTransferReportArchiveValidation)
			If Not pReader.IsDBNull(pReader.GetOrdinal("ReportArchiveId")) Then pObject.colReportArchiveId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "ReportArchiveId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ColumnName")) Then pObject.colColumnName = UtilSQLServer.SafeReader.SafeReadString(pReader, "ColumnName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FilePrefix")) Then pObject.colFilePrefix = UtilSQLServer.SafeReader.SafeReadString(pReader, "FilePrefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FileNo")) Then pObject.colFileNo = UtilSQLServer.SafeReader.SafeReadString(pReader, "FileNo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DocumentDate")) Then pObject.colDocumentDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "DocumentDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Practice")) Then pObject.colPractice = UtilSQLServer.SafeReader.SafeReadString(pReader, "Practice")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PDFFilePath")) Then pObject.colPDFFilePath = UtilSQLServer.SafeReader.SafeReadString(pReader, "PDFFilePath")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ClientDBRootPath")) Then pObject.colClientDBRootPath = UtilSQLServer.SafeReader.SafeReadString(pReader, "ClientDBRootPath")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ValidationID")) Then pObject.colValidationID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "ValidationID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("IsValid")) Then pObject.colIsValid = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "IsValid")
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
            Dim zSQL As String = "SELECT * FROM [jv].[vwDataTransferReportArchiveValidation]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowVwDataTransferReportArchiveValidation
        Implements IrowVwDataTransferReportArchiveValidation

        Public Event Loaded(pUserState As Object) Implements IrowVwDataTransferReportArchiveValidation.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwDataTransferReportArchiveValidation.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwDataTransferReportArchiveValidation.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwDataTransferReportArchiveValidation.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwDataTransferReportArchiveValidation.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwDataTransferReportArchiveValidation.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colReportArchiveId() As Nullable(Of Integer) Implements IrowVwDataTransferReportArchiveValidation.colReportArchiveId
            Get
                Return m_colReportArchiveId
            End Get
            Set
                If Not Same(m_colReportArchiveId, Value) Then
                    m_colReportArchiveId = Value
                    m_IsDirty(FieldIndex.colReportArchiveId) = True
                End If
            End Set
        End Property
        Private m_colReportArchiveId As Nullable(Of Integer)

        Public Property colColumnName() As String Implements IrowVwDataTransferReportArchiveValidation.colColumnName
            Get
                Return m_colColumnName
            End Get
            Set
                If Not Same(m_colColumnName, Value) Then
                    m_colColumnName = Value
                    m_IsDirty(FieldIndex.colColumnName) = True
                End If
            End Set
        End Property
        Private m_colColumnName As String

        Public Property colFilePrefix() As String Implements IrowVwDataTransferReportArchiveValidation.colFilePrefix
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

        Public Property colFileNo() As String Implements IrowVwDataTransferReportArchiveValidation.colFileNo
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

        Public Property colDocumentDate() As Nullable(Of DateTime) Implements IrowVwDataTransferReportArchiveValidation.colDocumentDate
            Get
                Return m_colDocumentDate
            End Get
            Set
                If Not Same(m_colDocumentDate, Value) Then
                    m_colDocumentDate = Value
                    m_IsDirty(FieldIndex.colDocumentDate) = True
                End If
            End Set
        End Property
        Private m_colDocumentDate As Nullable(Of DateTime)

        Public Property colPractice() As String Implements IrowVwDataTransferReportArchiveValidation.colPractice
            Get
                Return m_colPractice
            End Get
            Set
                If Not Same(m_colPractice, Value) Then
                    m_colPractice = Value
                    m_IsDirty(FieldIndex.colPractice) = True
                End If
            End Set
        End Property
        Private m_colPractice As String

        Public Property colPDFFilePath() As String Implements IrowVwDataTransferReportArchiveValidation.colPDFFilePath
            Get
                Return m_colPDFFilePath
            End Get
            Set
                If Not Same(m_colPDFFilePath, Value) Then
                    m_colPDFFilePath = Value
                    m_IsDirty(FieldIndex.colPDFFilePath) = True
                End If
            End Set
        End Property
        Private m_colPDFFilePath As String

        Public Property colClientDBRootPath() As String Implements IrowVwDataTransferReportArchiveValidation.colClientDBRootPath
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

        Public Property colValidationID() As Nullable(Of Integer) Implements IrowVwDataTransferReportArchiveValidation.colValidationID
            Get
                Return m_colValidationID
            End Get
            Set
                If Not Same(m_colValidationID, Value) Then
                    m_colValidationID = Value
                    m_IsDirty(FieldIndex.colValidationID) = True
                End If
            End Set
        End Property
        Private m_colValidationID As Nullable(Of Integer)

        Public Property colIsValid() As Nullable(Of Integer) Implements IrowVwDataTransferReportArchiveValidation.colIsValid
            Get
                Return m_colIsValid
            End Get
            Set
                If Not Same(m_colIsValid, Value) Then
                    m_colIsValid = Value
                    m_IsDirty(FieldIndex.colIsValid) = True
                End If
            End Set
        End Property
        Private m_colIsValid As Nullable(Of Integer)


        Public Function IsDirty(pIndex As rowVwDataTransferReportArchiveValidation.FieldIndex) As Boolean Implements IrowVwDataTransferReportArchiveValidation.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwDataTransferReportArchiveValidation.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwDataTransferReportArchiveValidation.SetIsDirty
            m_IsDirty(FieldIndex.colReportArchiveId) = pDirty
            m_IsDirty(FieldIndex.colColumnName) = pDirty
            m_IsDirty(FieldIndex.colFilePrefix) = pDirty
            m_IsDirty(FieldIndex.colFileNo) = pDirty
            m_IsDirty(FieldIndex.colDocumentDate) = pDirty
            m_IsDirty(FieldIndex.colPractice) = pDirty
            m_IsDirty(FieldIndex.colPDFFilePath) = pDirty
            m_IsDirty(FieldIndex.colClientDBRootPath) = pDirty
            m_IsDirty(FieldIndex.colValidationID) = pDirty
            m_IsDirty(FieldIndex.colIsValid) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwDataTransferReportArchiveValidation) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwDataTransferReportArchiveValidation
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colReportArchiveId  = 1
            colColumnName 
            colFilePrefix 
            colFileNo 
            colDocumentDate 
            colPractice 
            colPDFFilePath 
            colClientDBRootPath 
            colValidationID 
            colIsValid 
        End Enum

        Private m_IsDirty(10) As Boolean

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

    Public Interface IrowVwDataTransferReportArchiveValidation
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colReportArchiveId() As Nullable(Of Integer)
        Property colColumnName() As String
        Property colFilePrefix() As String
        Property colFileNo() As String
        Property colDocumentDate() As Nullable(Of DateTime)
        Property colPractice() As String
        Property colPDFFilePath() As String
        Property colClientDBRootPath() As String
        Property colValidationID() As Nullable(Of Integer)
        Property colIsValid() As Nullable(Of Integer)
        Function IsDirty(pIndex As rowVwDataTransferReportArchiveValidation.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

