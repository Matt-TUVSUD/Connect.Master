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
    Partial Public Class VwActiveAccountService

        Public Shared Function LoadData() As List(Of rowVwActiveAccountService)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwActiveAccountService)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwActiveAccountService)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwActiveAccountService)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwActiveAccountService)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwActiveAccountService)
            Dim zReturn As New List(Of rowVwActiveAccountService)
            Dim zSQL As String = "SELECT * FROM [dbo].[vwActiveAccountService]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwActiveAccountService)

			Try
	            Dim zReturn As New List(Of rowVwActiveAccountService)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwActiveAccountService

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwActiveAccountService		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwActiveAccountService)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFilePrefix")) Then pObject.colFldFilePrefix = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldFilePrefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldReportDisplayTitle")) Then pObject.colFldReportDisplayTitle = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldReportDisplayTitle")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldPracticeGroupCode")) Then pObject.colFldPracticeGroupCode = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldPracticeGroupCode")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSortOrder")) Then pObject.colFldSortOrder = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldSortOrder")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldStatus")) Then pObject.colFldStatus = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldStatus")
			If Not pReader.IsDBNull(pReader.GetOrdinal("MetaPracticeID")) Then pObject.colMetaPracticeID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "MetaPracticeID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldImageHtml")) Then pObject.colFldImageHtml = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldImageHtml")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldLocationListingUrl")) Then pObject.colFldLocationListingUrl = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldLocationListingUrl")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldLearnMoreUrl")) Then pObject.colFldLearnMoreUrl = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldLearnMoreUrl")
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
            Dim zSQL As String = "SELECT * FROM [dbo].[vwActiveAccountService]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowVwActiveAccountService
        Implements IrowVwActiveAccountService

        Public Event Loaded(pUserState As Object) Implements IrowVwActiveAccountService.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwActiveAccountService.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwActiveAccountService.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwActiveAccountService.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwActiveAccountService.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwActiveAccountService.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldFilePrefix() As String Implements IrowVwActiveAccountService.colFldFilePrefix
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

        Public Property colFldReportDisplayTitle() As String Implements IrowVwActiveAccountService.colFldReportDisplayTitle
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

        Public Property colFldPracticeGroupCode() As String Implements IrowVwActiveAccountService.colFldPracticeGroupCode
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

        Public Property colFldSortOrder() As Nullable(Of Integer) Implements IrowVwActiveAccountService.colFldSortOrder
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

        Public Property colFldStatus() As String Implements IrowVwActiveAccountService.colFldStatus
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

        Public Property colMetaPracticeID() As Nullable(Of Integer) Implements IrowVwActiveAccountService.colMetaPracticeID
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

        Public Property colFldImageHtml() As String Implements IrowVwActiveAccountService.colFldImageHtml
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

        Public Property colFldLocationListingUrl() As String Implements IrowVwActiveAccountService.colFldLocationListingUrl
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

        Public Property colFldLearnMoreUrl() As String Implements IrowVwActiveAccountService.colFldLearnMoreUrl
            Get
                Return m_colFldLearnMoreUrl
            End Get
            Set
                If Not Same(m_colFldLearnMoreUrl, Value) Then
                    m_colFldLearnMoreUrl = Value
                    m_IsDirty(FieldIndex.colFldLearnMoreUrl) = True
                End If
            End Set
        End Property
        Private m_colFldLearnMoreUrl As String


        Public Function IsDirty(pIndex As rowVwActiveAccountService.FieldIndex) As Boolean Implements IrowVwActiveAccountService.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwActiveAccountService.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwActiveAccountService.SetIsDirty
            m_IsDirty(FieldIndex.colFldFilePrefix) = pDirty
            m_IsDirty(FieldIndex.colFldReportDisplayTitle) = pDirty
            m_IsDirty(FieldIndex.colFldPracticeGroupCode) = pDirty
            m_IsDirty(FieldIndex.colFldSortOrder) = pDirty
            m_IsDirty(FieldIndex.colFldStatus) = pDirty
            m_IsDirty(FieldIndex.colMetaPracticeID) = pDirty
            m_IsDirty(FieldIndex.colFldImageHtml) = pDirty
            m_IsDirty(FieldIndex.colFldLocationListingUrl) = pDirty
            m_IsDirty(FieldIndex.colFldLearnMoreUrl) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwActiveAccountService) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwActiveAccountService
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldFilePrefix  = 1
            colFldReportDisplayTitle 
            colFldPracticeGroupCode 
            colFldSortOrder 
            colFldStatus 
            colMetaPracticeID 
            colFldImageHtml 
            colFldLocationListingUrl 
            colFldLearnMoreUrl 
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

    Public Interface IrowVwActiveAccountService
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldFilePrefix() As String
        Property colFldReportDisplayTitle() As String
        Property colFldPracticeGroupCode() As String
        Property colFldSortOrder() As Nullable(Of Integer)
        Property colFldStatus() As String
        Property colMetaPracticeID() As Nullable(Of Integer)
        Property colFldImageHtml() As String
        Property colFldLocationListingUrl() As String
        Property colFldLearnMoreUrl() As String
        Function IsDirty(pIndex As rowVwActiveAccountService.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

