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
    Partial Public Class VwClientMetaPractice

        Public Shared Function LoadData() As List(Of rowVwClientMetaPractice)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwClientMetaPractice)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwClientMetaPractice)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwClientMetaPractice)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwClientMetaPractice)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwClientMetaPractice)
            Dim zReturn As New List(Of rowVwClientMetaPractice)
            Dim zSQL As String = "SELECT * FROM [gv].[vwClientMetaPractice]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwClientMetaPractice)

			Try
	            Dim zReturn As New List(Of rowVwClientMetaPractice)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwClientMetaPractice

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwClientMetaPractice		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwClientMetaPractice)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldId")) Then pObject.colFldId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldName")) Then pObject.colFldName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldReportDisplayTitle")) Then pObject.colFldReportDisplayTitle = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldReportDisplayTitle")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldIsHazard")) Then pObject.colFldIsHazard = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldIsHazard")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFilterValue")) Then pObject.colFldFilterValue = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldFilterValue")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldPracticeCode")) Then pObject.colFldPracticeCode = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldPracticeCode")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldPracticeGroupCode")) Then pObject.colFldPracticeGroupCode = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldPracticeGroupCode")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSortOrder")) Then pObject.colFldSortOrder = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldSortOrder")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldPracticeLetter")) Then pObject.colFldPracticeLetter = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldPracticeLetter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldShortName")) Then pObject.colFldShortName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldShortName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldPracticeNameText")) Then pObject.colFldPracticeNameText = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldPracticeNameText")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldPracticeNameHTML")) Then pObject.colFldPracticeNameHTML = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldPracticeNameHTML")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldNavLinkAllReportsKeyword")) Then pObject.colFldNavLinkAllReportsKeyword = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldNavLinkAllReportsKeyword")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldImageHtml")) Then pObject.colFldImageHtml = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldImageHtml")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldLocationListingUrl")) Then pObject.colFldLocationListingUrl = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldLocationListingUrl")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FilePrefix")) Then pObject.colFilePrefix = UtilSQLServer.SafeReader.SafeReadString(pReader, "FilePrefix")
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
            Dim zSQL As String = "SELECT * FROM [gv].[vwClientMetaPractice]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowVwClientMetaPractice
        Implements IrowVwClientMetaPractice

        Public Event Loaded(pUserState As Object) Implements IrowVwClientMetaPractice.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwClientMetaPractice.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwClientMetaPractice.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwClientMetaPractice.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwClientMetaPractice.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwClientMetaPractice.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldId() As Nullable(Of Integer) Implements IrowVwClientMetaPractice.colFldId
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

        Public Property colFldName() As String Implements IrowVwClientMetaPractice.colFldName
            Get
                Return m_colFldName
            End Get
            Set
                If Not Same(m_colFldName, Value) Then
                    m_colFldName = Value
                    m_IsDirty(FieldIndex.colFldName) = True
                End If
            End Set
        End Property
        Private m_colFldName As String

        Public Property colFldReportDisplayTitle() As String Implements IrowVwClientMetaPractice.colFldReportDisplayTitle
            Get
                Return m_colFldReportDisplayTitle
            End Get
            Set
                If Not Same(m_colFldReportDisplayTitle, Value) Then
                    m_colFldReportDisplayTitle = Value
                    m_IsDirty(FieldIndex.colFldReportDisplayTitle) = True
                End If
            End Set
        End Property
        Private m_colFldReportDisplayTitle As String

        Public Property colFldIsHazard() As Nullable(Of Boolean) Implements IrowVwClientMetaPractice.colFldIsHazard
            Get
                Return m_colFldIsHazard
            End Get
            Set
                If Not Same(m_colFldIsHazard, Value) Then
                    m_colFldIsHazard = Value
                    m_IsDirty(FieldIndex.colFldIsHazard) = True
                End If
            End Set
        End Property
        Private m_colFldIsHazard As Nullable(Of Boolean)

        Public Property colFldFilterValue() As String Implements IrowVwClientMetaPractice.colFldFilterValue
            Get
                Return m_colFldFilterValue
            End Get
            Set
                If Not Same(m_colFldFilterValue, Value) Then
                    m_colFldFilterValue = Value
                    m_IsDirty(FieldIndex.colFldFilterValue) = True
                End If
            End Set
        End Property
        Private m_colFldFilterValue As String

        Public Property colFldPracticeCode() As String Implements IrowVwClientMetaPractice.colFldPracticeCode
            Get
                Return m_colFldPracticeCode
            End Get
            Set
                If Not Same(m_colFldPracticeCode, Value) Then
                    m_colFldPracticeCode = Value
                    m_IsDirty(FieldIndex.colFldPracticeCode) = True
                End If
            End Set
        End Property
        Private m_colFldPracticeCode As String

        Public Property colFldPracticeGroupCode() As String Implements IrowVwClientMetaPractice.colFldPracticeGroupCode
            Get
                Return m_colFldPracticeGroupCode
            End Get
            Set
                If Not Same(m_colFldPracticeGroupCode, Value) Then
                    m_colFldPracticeGroupCode = Value
                    m_IsDirty(FieldIndex.colFldPracticeGroupCode) = True
                End If
            End Set
        End Property
        Private m_colFldPracticeGroupCode As String

        Public Property colFldSortOrder() As Nullable(Of Integer) Implements IrowVwClientMetaPractice.colFldSortOrder
            Get
                Return m_colFldSortOrder
            End Get
            Set
                If Not Same(m_colFldSortOrder, Value) Then
                    m_colFldSortOrder = Value
                    m_IsDirty(FieldIndex.colFldSortOrder) = True
                End If
            End Set
        End Property
        Private m_colFldSortOrder As Nullable(Of Integer)

        Public Property colFldPracticeLetter() As String Implements IrowVwClientMetaPractice.colFldPracticeLetter
            Get
                Return m_colFldPracticeLetter
            End Get
            Set
                If Not Same(m_colFldPracticeLetter, Value) Then
                    m_colFldPracticeLetter = Value
                    m_IsDirty(FieldIndex.colFldPracticeLetter) = True
                End If
            End Set
        End Property
        Private m_colFldPracticeLetter As String

        Public Property colFldShortName() As String Implements IrowVwClientMetaPractice.colFldShortName
            Get
                Return m_colFldShortName
            End Get
            Set
                If Not Same(m_colFldShortName, Value) Then
                    m_colFldShortName = Value
                    m_IsDirty(FieldIndex.colFldShortName) = True
                End If
            End Set
        End Property
        Private m_colFldShortName As String

        Public Property colFldPracticeNameText() As String Implements IrowVwClientMetaPractice.colFldPracticeNameText
            Get
                Return m_colFldPracticeNameText
            End Get
            Set
                If Not Same(m_colFldPracticeNameText, Value) Then
                    m_colFldPracticeNameText = Value
                    m_IsDirty(FieldIndex.colFldPracticeNameText) = True
                End If
            End Set
        End Property
        Private m_colFldPracticeNameText As String

        Public Property colFldPracticeNameHTML() As String Implements IrowVwClientMetaPractice.colFldPracticeNameHTML
            Get
                Return m_colFldPracticeNameHTML
            End Get
            Set
                If Not Same(m_colFldPracticeNameHTML, Value) Then
                    m_colFldPracticeNameHTML = Value
                    m_IsDirty(FieldIndex.colFldPracticeNameHTML) = True
                End If
            End Set
        End Property
        Private m_colFldPracticeNameHTML As String

        Public Property colFldNavLinkAllReportsKeyword() As String Implements IrowVwClientMetaPractice.colFldNavLinkAllReportsKeyword
            Get
                Return m_colFldNavLinkAllReportsKeyword
            End Get
            Set
                If Not Same(m_colFldNavLinkAllReportsKeyword, Value) Then
                    m_colFldNavLinkAllReportsKeyword = Value
                    m_IsDirty(FieldIndex.colFldNavLinkAllReportsKeyword) = True
                End If
            End Set
        End Property
        Private m_colFldNavLinkAllReportsKeyword As String

        Public Property colFldImageHtml() As String Implements IrowVwClientMetaPractice.colFldImageHtml
            Get
                Return m_colFldImageHtml
            End Get
            Set
                If Not Same(m_colFldImageHtml, Value) Then
                    m_colFldImageHtml = Value
                    m_IsDirty(FieldIndex.colFldImageHtml) = True
                End If
            End Set
        End Property
        Private m_colFldImageHtml As String

        Public Property colFldLocationListingUrl() As String Implements IrowVwClientMetaPractice.colFldLocationListingUrl
            Get
                Return m_colFldLocationListingUrl
            End Get
            Set
                If Not Same(m_colFldLocationListingUrl, Value) Then
                    m_colFldLocationListingUrl = Value
                    m_IsDirty(FieldIndex.colFldLocationListingUrl) = True
                End If
            End Set
        End Property
        Private m_colFldLocationListingUrl As String

        Public Property colFilePrefix() As String Implements IrowVwClientMetaPractice.colFilePrefix
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


        Public Function IsDirty(pIndex As rowVwClientMetaPractice.FieldIndex) As Boolean Implements IrowVwClientMetaPractice.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwClientMetaPractice.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwClientMetaPractice.SetIsDirty
            m_IsDirty(FieldIndex.colFldId) = pDirty
            m_IsDirty(FieldIndex.colFldName) = pDirty
            m_IsDirty(FieldIndex.colFldReportDisplayTitle) = pDirty
            m_IsDirty(FieldIndex.colFldIsHazard) = pDirty
            m_IsDirty(FieldIndex.colFldFilterValue) = pDirty
            m_IsDirty(FieldIndex.colFldPracticeCode) = pDirty
            m_IsDirty(FieldIndex.colFldPracticeGroupCode) = pDirty
            m_IsDirty(FieldIndex.colFldSortOrder) = pDirty
            m_IsDirty(FieldIndex.colFldPracticeLetter) = pDirty
            m_IsDirty(FieldIndex.colFldShortName) = pDirty
            m_IsDirty(FieldIndex.colFldPracticeNameText) = pDirty
            m_IsDirty(FieldIndex.colFldPracticeNameHTML) = pDirty
            m_IsDirty(FieldIndex.colFldNavLinkAllReportsKeyword) = pDirty
            m_IsDirty(FieldIndex.colFldImageHtml) = pDirty
            m_IsDirty(FieldIndex.colFldLocationListingUrl) = pDirty
            m_IsDirty(FieldIndex.colFilePrefix) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwClientMetaPractice) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwClientMetaPractice
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldId  = 1
            colFldName 
            colFldReportDisplayTitle 
            colFldIsHazard 
            colFldFilterValue 
            colFldPracticeCode 
            colFldPracticeGroupCode 
            colFldSortOrder 
            colFldPracticeLetter 
            colFldShortName 
            colFldPracticeNameText 
            colFldPracticeNameHTML 
            colFldNavLinkAllReportsKeyword 
            colFldImageHtml 
            colFldLocationListingUrl 
            colFilePrefix 
        End Enum

        Private m_IsDirty(16) As Boolean

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

    Public Interface IrowVwClientMetaPractice
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldId() As Nullable(Of Integer)
        Property colFldName() As String
        Property colFldReportDisplayTitle() As String
        Property colFldIsHazard() As Nullable(Of Boolean)
        Property colFldFilterValue() As String
        Property colFldPracticeCode() As String
        Property colFldPracticeGroupCode() As String
        Property colFldSortOrder() As Nullable(Of Integer)
        Property colFldPracticeLetter() As String
        Property colFldShortName() As String
        Property colFldPracticeNameText() As String
        Property colFldPracticeNameHTML() As String
        Property colFldNavLinkAllReportsKeyword() As String
        Property colFldImageHtml() As String
        Property colFldLocationListingUrl() As String
        Property colFilePrefix() As String
        Function IsDirty(pIndex As rowVwClientMetaPractice.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

