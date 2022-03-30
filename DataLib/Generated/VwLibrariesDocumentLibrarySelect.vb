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
    Partial Public Class VwLibrariesDocumentLibrarySelect

        Public Shared Function LoadData() As List(Of rowVwLibrariesDocumentLibrarySelect)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwLibrariesDocumentLibrarySelect)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwLibrariesDocumentLibrarySelect)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwLibrariesDocumentLibrarySelect)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwLibrariesDocumentLibrarySelect)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwLibrariesDocumentLibrarySelect)
            Dim zReturn As New List(Of rowVwLibrariesDocumentLibrarySelect)
            Dim zSQL As String = "SELECT * FROM [gv].[vwLibrariesDocumentLibrarySelect]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwLibrariesDocumentLibrarySelect)

			Try
	            Dim zReturn As New List(Of rowVwLibrariesDocumentLibrarySelect)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwLibrariesDocumentLibrarySelect

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwLibrariesDocumentLibrarySelect		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwLibrariesDocumentLibrarySelect)
			If Not pReader.IsDBNull(pReader.GetOrdinal("PDFErFilePath")) Then pObject.colPDFErFilePath = UtilSQLServer.SafeReader.SafeReadString(pReader, "PDFErFilePath")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PDFDiagramFilePath")) Then pObject.colPDFDiagramFilePath = UtilSQLServer.SafeReader.SafeReadString(pReader, "PDFDiagramFilePath")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ClientDBRootPath")) Then pObject.colClientDBRootPath = UtilSQLServer.SafeReader.SafeReadString(pReader, "ClientDBRootPath")
			If Not pReader.IsDBNull(pReader.GetOrdinal("id")) Then pObject.colId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "id")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fileno")) Then pObject.colFileno = UtilSQLServer.SafeReader.SafeReadString(pReader, "fileno")
			If Not pReader.IsDBNull(pReader.GetOrdinal("clientlocid")) Then pObject.colClientlocid = UtilSQLServer.SafeReader.SafeReadString(pReader, "clientlocid")
			If Not pReader.IsDBNull(pReader.GetOrdinal("documentdate")) Then pObject.colDocumentdate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "documentdate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("linktoer")) Then pObject.colLinktoer = UtilSQLServer.SafeReader.SafeReadString(pReader, "linktoer")
			If Not pReader.IsDBNull(pReader.GetOrdinal("linktourorlereport")) Then pObject.colLinktourorlereport = UtilSQLServer.SafeReader.SafeReadString(pReader, "linktourorlereport")
			If Not pReader.IsDBNull(pReader.GetOrdinal("linktodiagram")) Then pObject.colLinktodiagram = UtilSQLServer.SafeReader.SafeReadString(pReader, "linktodiagram")
			If Not pReader.IsDBNull(pReader.GetOrdinal("practice")) Then pObject.colPractice = UtilSQLServer.SafeReader.SafeReadString(pReader, "practice")
			If Not pReader.IsDBNull(pReader.GetOrdinal("division")) Then pObject.colDivision = UtilSQLServer.SafeReader.SafeReadString(pReader, "division")
			If Not pReader.IsDBNull(pReader.GetOrdinal("facility")) Then pObject.colFacility = UtilSQLServer.SafeReader.SafeReadString(pReader, "facility")
			If Not pReader.IsDBNull(pReader.GetOrdinal("address1")) Then pObject.colAddress1 = UtilSQLServer.SafeReader.SafeReadString(pReader, "address1")
			If Not pReader.IsDBNull(pReader.GetOrdinal("city")) Then pObject.colCity = UtilSQLServer.SafeReader.SafeReadString(pReader, "city")
			If Not pReader.IsDBNull(pReader.GetOrdinal("st_prov")) Then pObject.colStProv = UtilSQLServer.SafeReader.SafeReadString(pReader, "st_prov")
			If Not pReader.IsDBNull(pReader.GetOrdinal("country")) Then pObject.colCountry = UtilSQLServer.SafeReader.SafeReadString(pReader, "country")
			If Not pReader.IsDBNull(pReader.GetOrdinal("cldbname")) Then pObject.colCldbname = UtilSQLServer.SafeReader.SafeReadString(pReader, "cldbname")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ReportGuid")) Then pObject.colReportGuid = UtilSQLServer.SafeReader.SafeReadString(pReader, "ReportGuid")
			If Not pReader.IsDBNull(pReader.GetOrdinal("MetaPracticeID")) Then pObject.colMetaPracticeID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "MetaPracticeID")
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
            Dim zSQL As String = "SELECT * FROM [gv].[vwLibrariesDocumentLibrarySelect]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowVwLibrariesDocumentLibrarySelect
        Implements IrowVwLibrariesDocumentLibrarySelect

        Public Event Loaded(pUserState As Object) Implements IrowVwLibrariesDocumentLibrarySelect.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwLibrariesDocumentLibrarySelect.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwLibrariesDocumentLibrarySelect.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwLibrariesDocumentLibrarySelect.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwLibrariesDocumentLibrarySelect.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwLibrariesDocumentLibrarySelect.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colPDFErFilePath() As String Implements IrowVwLibrariesDocumentLibrarySelect.colPDFErFilePath
            Get
                Return m_colPDFErFilePath
            End Get
            Set
                If Not Same(m_colPDFErFilePath, Value) Then
                    m_colPDFErFilePath = Value
                    m_IsDirty(FieldIndex.colPDFErFilePath) = True
                End If
            End Set
        End Property
        Private m_colPDFErFilePath As String

        Public Property colPDFDiagramFilePath() As String Implements IrowVwLibrariesDocumentLibrarySelect.colPDFDiagramFilePath
            Get
                Return m_colPDFDiagramFilePath
            End Get
            Set
                If Not Same(m_colPDFDiagramFilePath, Value) Then
                    m_colPDFDiagramFilePath = Value
                    m_IsDirty(FieldIndex.colPDFDiagramFilePath) = True
                End If
            End Set
        End Property
        Private m_colPDFDiagramFilePath As String

        Public Property colClientDBRootPath() As String Implements IrowVwLibrariesDocumentLibrarySelect.colClientDBRootPath
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

        Public Property colId() As Nullable(Of Integer) Implements IrowVwLibrariesDocumentLibrarySelect.colId
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

        Public Property colFileno() As String Implements IrowVwLibrariesDocumentLibrarySelect.colFileno
            Get
                Return m_colFileno
            End Get
            Set
                If Not Same(m_colFileno, Value) Then
                    m_colFileno = Value
                    m_IsDirty(FieldIndex.colFileno) = True
                End If
            End Set
        End Property
        Private m_colFileno As String

        Public Property colClientlocid() As String Implements IrowVwLibrariesDocumentLibrarySelect.colClientlocid
            Get
                Return m_colClientlocid
            End Get
            Set
                If Not Same(m_colClientlocid, Value) Then
                    m_colClientlocid = Value
                    m_IsDirty(FieldIndex.colClientlocid) = True
                End If
            End Set
        End Property
        Private m_colClientlocid As String

        Public Property colDocumentdate() As Nullable(Of DateTime) Implements IrowVwLibrariesDocumentLibrarySelect.colDocumentdate
            Get
                Return m_colDocumentdate
            End Get
            Set
                If Not Same(m_colDocumentdate, Value) Then
                    m_colDocumentdate = Value
                    m_IsDirty(FieldIndex.colDocumentdate) = True
                End If
            End Set
        End Property
        Private m_colDocumentdate As Nullable(Of DateTime)

        Public Property colLinktoer() As String Implements IrowVwLibrariesDocumentLibrarySelect.colLinktoer
            Get
                Return m_colLinktoer
            End Get
            Set
                If Not Same(m_colLinktoer, Value) Then
                    m_colLinktoer = Value
                    m_IsDirty(FieldIndex.colLinktoer) = True
                End If
            End Set
        End Property
        Private m_colLinktoer As String

        Public Property colLinktourorlereport() As String Implements IrowVwLibrariesDocumentLibrarySelect.colLinktourorlereport
            Get
                Return m_colLinktourorlereport
            End Get
            Set
                If Not Same(m_colLinktourorlereport, Value) Then
                    m_colLinktourorlereport = Value
                    m_IsDirty(FieldIndex.colLinktourorlereport) = True
                End If
            End Set
        End Property
        Private m_colLinktourorlereport As String

        Public Property colLinktodiagram() As String Implements IrowVwLibrariesDocumentLibrarySelect.colLinktodiagram
            Get
                Return m_colLinktodiagram
            End Get
            Set
                If Not Same(m_colLinktodiagram, Value) Then
                    m_colLinktodiagram = Value
                    m_IsDirty(FieldIndex.colLinktodiagram) = True
                End If
            End Set
        End Property
        Private m_colLinktodiagram As String

        Public Property colPractice() As String Implements IrowVwLibrariesDocumentLibrarySelect.colPractice
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

        Public Property colDivision() As String Implements IrowVwLibrariesDocumentLibrarySelect.colDivision
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

        Public Property colFacility() As String Implements IrowVwLibrariesDocumentLibrarySelect.colFacility
            Get
                Return m_colFacility
            End Get
            Set
                If Not Same(m_colFacility, Value) Then
                    m_colFacility = Value
                    m_IsDirty(FieldIndex.colFacility) = True
                End If
            End Set
        End Property
        Private m_colFacility As String

        Public Property colAddress1() As String Implements IrowVwLibrariesDocumentLibrarySelect.colAddress1
            Get
                Return m_colAddress1
            End Get
            Set
                If Not Same(m_colAddress1, Value) Then
                    m_colAddress1 = Value
                    m_IsDirty(FieldIndex.colAddress1) = True
                End If
            End Set
        End Property
        Private m_colAddress1 As String

        Public Property colCity() As String Implements IrowVwLibrariesDocumentLibrarySelect.colCity
            Get
                Return m_colCity
            End Get
            Set
                If Not Same(m_colCity, Value) Then
                    m_colCity = Value
                    m_IsDirty(FieldIndex.colCity) = True
                End If
            End Set
        End Property
        Private m_colCity As String

        Public Property colStProv() As String Implements IrowVwLibrariesDocumentLibrarySelect.colStProv
            Get
                Return m_colStProv
            End Get
            Set
                If Not Same(m_colStProv, Value) Then
                    m_colStProv = Value
                    m_IsDirty(FieldIndex.colStProv) = True
                End If
            End Set
        End Property
        Private m_colStProv As String

        Public Property colCountry() As String Implements IrowVwLibrariesDocumentLibrarySelect.colCountry
            Get
                Return m_colCountry
            End Get
            Set
                If Not Same(m_colCountry, Value) Then
                    m_colCountry = Value
                    m_IsDirty(FieldIndex.colCountry) = True
                End If
            End Set
        End Property
        Private m_colCountry As String

        Public Property colCldbname() As String Implements IrowVwLibrariesDocumentLibrarySelect.colCldbname
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

        Public Property colReportGuid() As String Implements IrowVwLibrariesDocumentLibrarySelect.colReportGuid
            Get
                Return m_colReportGuid
            End Get
            Set
                If Not Same(m_colReportGuid, Value) Then
                    m_colReportGuid = Value
                    m_IsDirty(FieldIndex.colReportGuid) = True
                End If
            End Set
        End Property
        Private m_colReportGuid As String

        Public Property colMetaPracticeID() As Nullable(Of Integer) Implements IrowVwLibrariesDocumentLibrarySelect.colMetaPracticeID
            Get
                Return m_colMetaPracticeID
            End Get
            Set
                If Not Same(m_colMetaPracticeID, Value) Then
                    m_colMetaPracticeID = Value
                    m_IsDirty(FieldIndex.colMetaPracticeID) = True
                End If
            End Set
        End Property
        Private m_colMetaPracticeID As Nullable(Of Integer)


        Public Function IsDirty(pIndex As rowVwLibrariesDocumentLibrarySelect.FieldIndex) As Boolean Implements IrowVwLibrariesDocumentLibrarySelect.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwLibrariesDocumentLibrarySelect.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwLibrariesDocumentLibrarySelect.SetIsDirty
            m_IsDirty(FieldIndex.colPDFErFilePath) = pDirty
            m_IsDirty(FieldIndex.colPDFDiagramFilePath) = pDirty
            m_IsDirty(FieldIndex.colClientDBRootPath) = pDirty
            m_IsDirty(FieldIndex.colId) = pDirty
            m_IsDirty(FieldIndex.colFileno) = pDirty
            m_IsDirty(FieldIndex.colClientlocid) = pDirty
            m_IsDirty(FieldIndex.colDocumentdate) = pDirty
            m_IsDirty(FieldIndex.colLinktoer) = pDirty
            m_IsDirty(FieldIndex.colLinktourorlereport) = pDirty
            m_IsDirty(FieldIndex.colLinktodiagram) = pDirty
            m_IsDirty(FieldIndex.colPractice) = pDirty
            m_IsDirty(FieldIndex.colDivision) = pDirty
            m_IsDirty(FieldIndex.colFacility) = pDirty
            m_IsDirty(FieldIndex.colAddress1) = pDirty
            m_IsDirty(FieldIndex.colCity) = pDirty
            m_IsDirty(FieldIndex.colStProv) = pDirty
            m_IsDirty(FieldIndex.colCountry) = pDirty
            m_IsDirty(FieldIndex.colCldbname) = pDirty
            m_IsDirty(FieldIndex.colReportGuid) = pDirty
            m_IsDirty(FieldIndex.colMetaPracticeID) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwLibrariesDocumentLibrarySelect) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwLibrariesDocumentLibrarySelect
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colPDFErFilePath  = 1
            colPDFDiagramFilePath 
            colClientDBRootPath 
            colId 
            colFileno 
            colClientlocid 
            colDocumentdate 
            colLinktoer 
            colLinktourorlereport 
            colLinktodiagram 
            colPractice 
            colDivision 
            colFacility 
            colAddress1 
            colCity 
            colStProv 
            colCountry 
            colCldbname 
            colReportGuid 
            colMetaPracticeID 
        End Enum

        Private m_IsDirty(20) As Boolean

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

    Public Interface IrowVwLibrariesDocumentLibrarySelect
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colPDFErFilePath() As String
        Property colPDFDiagramFilePath() As String
        Property colClientDBRootPath() As String
        Property colId() As Nullable(Of Integer)
        Property colFileno() As String
        Property colClientlocid() As String
        Property colDocumentdate() As Nullable(Of DateTime)
        Property colLinktoer() As String
        Property colLinktourorlereport() As String
        Property colLinktodiagram() As String
        Property colPractice() As String
        Property colDivision() As String
        Property colFacility() As String
        Property colAddress1() As String
        Property colCity() As String
        Property colStProv() As String
        Property colCountry() As String
        Property colCldbname() As String
        Property colReportGuid() As String
        Property colMetaPracticeID() As Nullable(Of Integer)
        Function IsDirty(pIndex As rowVwLibrariesDocumentLibrarySelect.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

