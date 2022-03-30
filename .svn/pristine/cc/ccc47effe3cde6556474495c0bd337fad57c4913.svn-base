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
    Partial Public Class VwAdminViewXLSheet

        Public Shared Function LoadData() As List(Of rowVwAdminViewXLSheet)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwAdminViewXLSheet)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwAdminViewXLSheet)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwAdminViewXLSheet)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwAdminViewXLSheet)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwAdminViewXLSheet)
            Dim zReturn As New List(Of rowVwAdminViewXLSheet)
            Dim zSQL As String = "SELECT * FROM [adm].[vwAdminViewXLSheet]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwAdminViewXLSheet)

			Try
	            Dim zReturn As New List(Of rowVwAdminViewXLSheet)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwAdminViewXLSheet

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwAdminViewXLSheet		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwAdminViewXLSheet)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldID")) Then pObject.colFldID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldTabName")) Then pObject.colFldTabName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldTabName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldViewName")) Then pObject.colFldViewName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldViewName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSheetPosition")) Then pObject.colFldSheetPosition = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldSheetPosition")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldInclude")) Then pObject.colFldInclude = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldInclude")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSQL")) Then pObject.colFldSQL = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldSQL")
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
            Dim zSQL As String = "SELECT * FROM [adm].[vwAdminViewXLSheet]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class

    Partial Public Class rowVwAdminViewXLSheet
        Implements IrowVwAdminViewXLSheet

        Public Event Loaded(pUserState As Object) Implements IrowVwAdminViewXLSheet.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwAdminViewXLSheet.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwAdminViewXLSheet.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwAdminViewXLSheet.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwAdminViewXLSheet.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwAdminViewXLSheet.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldID() As Nullable(Of Integer) Implements IrowVwAdminViewXLSheet.colFldID
            Get
                Return m_colFldID
            End Get
            Set
                If Not Same(m_colFldID, Value) Then
                    m_colFldID = Value
                    m_IsDirty(FieldIndex.colFldID) = True
                End If
            End Set
        End Property
        Private m_colFldID As Nullable(Of Integer)

        Public Property colFldTabName() As String Implements IrowVwAdminViewXLSheet.colFldTabName
            Get
                Return m_colFldTabName
            End Get
            Set
                If Not Same(m_colFldTabName, Value) Then
                    m_colFldTabName = Value
                    m_IsDirty(FieldIndex.colFldTabName) = True
                End If
            End Set
        End Property
        Private m_colFldTabName As String

        Public Property colFldViewName() As String Implements IrowVwAdminViewXLSheet.colFldViewName
            Get
                Return m_colFldViewName
            End Get
            Set
                If Not Same(m_colFldViewName, Value) Then
                    m_colFldViewName = Value
                    m_IsDirty(FieldIndex.colFldViewName) = True
                End If
            End Set
        End Property
        Private m_colFldViewName As String

        Public Property colFldSheetPosition() As Nullable(Of Integer) Implements IrowVwAdminViewXLSheet.colFldSheetPosition
            Get
                Return m_colFldSheetPosition
            End Get
            Set
                If Not Same(m_colFldSheetPosition, Value) Then
                    m_colFldSheetPosition = Value
                    m_IsDirty(FieldIndex.colFldSheetPosition) = True
                End If
            End Set
        End Property
        Private m_colFldSheetPosition As Nullable(Of Integer)

        Public Property colFldInclude() As Nullable(Of Boolean) Implements IrowVwAdminViewXLSheet.colFldInclude
            Get
                Return m_colFldInclude
            End Get
            Set
                If Not Same(m_colFldInclude, Value) Then
                    m_colFldInclude = Value
                    m_IsDirty(FieldIndex.colFldInclude) = True
                End If
            End Set
        End Property
        Private m_colFldInclude As Nullable(Of Boolean)

        Public Property colFldSQL() As String Implements IrowVwAdminViewXLSheet.colFldSQL
            Get
                Return m_colFldSQL
            End Get
            Set
                If Not Same(m_colFldSQL, Value) Then
                    m_colFldSQL = Value
                    m_IsDirty(FieldIndex.colFldSQL) = True
                End If
            End Set
        End Property
        Private m_colFldSQL As String


        Public Function IsDirty(pIndex As rowVwAdminViewXLSheet.FieldIndex) As Boolean Implements IrowVwAdminViewXLSheet.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwAdminViewXLSheet.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwAdminViewXLSheet.SetIsDirty
            m_IsDirty(FieldIndex.colFldID) = pDirty
            m_IsDirty(FieldIndex.colFldTabName) = pDirty
            m_IsDirty(FieldIndex.colFldViewName) = pDirty
            m_IsDirty(FieldIndex.colFldSheetPosition) = pDirty
            m_IsDirty(FieldIndex.colFldInclude) = pDirty
            m_IsDirty(FieldIndex.colFldSQL) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwAdminViewXLSheet) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwAdminViewXLSheet
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldID  = 1
            colFldTabName 
            colFldViewName 
            colFldSheetPosition 
            colFldInclude 
            colFldSQL 
        End Enum

        Private m_IsDirty(6) As Boolean

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

    Public Interface IrowVwAdminViewXLSheet
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldID() As Nullable(Of Integer)
        Property colFldTabName() As String
        Property colFldViewName() As String
        Property colFldSheetPosition() As Nullable(Of Integer)
        Property colFldInclude() As Nullable(Of Boolean)
        Property colFldSQL() As String
        Function IsDirty(pIndex As rowVwAdminViewXLSheet.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

