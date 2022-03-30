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
    Partial Public Class VwMetaChartSeriesItem

        Public Shared Function LoadData() As List(Of rowVwMetaChartSeriesItem)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwMetaChartSeriesItem)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwMetaChartSeriesItem)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwMetaChartSeriesItem)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwMetaChartSeriesItem)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwMetaChartSeriesItem)
            Dim zReturn As New List(Of rowVwMetaChartSeriesItem)
            Dim zSQL As String = "SELECT * FROM [dbo].[vwMetaChartSeriesItem]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwMetaChartSeriesItem)

			Try
	            Dim zReturn As New List(Of rowVwMetaChartSeriesItem)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwMetaChartSeriesItem

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwMetaChartSeriesItem		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwMetaChartSeriesItem)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldId")) Then pObject.colFldId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldMetaChartId")) Then pObject.colFldMetaChartId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldMetaChartId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("name")) Then pObject.colName = UtilSQLServer.SafeReader.SafeReadString(pReader, "name")
			If Not pReader.IsDBNull(pReader.GetOrdinal("field")) Then pObject.colField = UtilSQLServer.SafeReader.SafeReadString(pReader, "field")
			If Not pReader.IsDBNull(pReader.GetOrdinal("categoryField")) Then pObject.colCategoryField = UtilSQLServer.SafeReader.SafeReadString(pReader, "categoryField")
			If Not pReader.IsDBNull(pReader.GetOrdinal("colorField")) Then pObject.colColorField = UtilSQLServer.SafeReader.SafeReadString(pReader, "colorField")
			If Not pReader.IsDBNull(pReader.GetOrdinal("color")) Then pObject.colColor = UtilSQLServer.SafeReader.SafeReadString(pReader, "color")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldTypeName")) Then pObject.colFldTypeName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldTypeName")
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
            Dim zSQL As String = "SELECT * FROM [dbo].[vwMetaChartSeriesItem]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowVwMetaChartSeriesItem
        Implements IrowVwMetaChartSeriesItem

        Public Event Loaded(pUserState As Object) Implements IrowVwMetaChartSeriesItem.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwMetaChartSeriesItem.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwMetaChartSeriesItem.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwMetaChartSeriesItem.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwMetaChartSeriesItem.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwMetaChartSeriesItem.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldId() As Nullable(Of Integer) Implements IrowVwMetaChartSeriesItem.colFldId
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

        Public Property colFldMetaChartId() As Nullable(Of Integer) Implements IrowVwMetaChartSeriesItem.colFldMetaChartId
            Get
                Return m_colFldMetaChartId
            End Get
            Set
                If Not Same(m_colFldMetaChartId, Value) Then
                    m_colFldMetaChartId = Value
                    m_IsDirty(FieldIndex.colFldMetaChartId) = True
                End If
            End Set
        End Property
        Private m_colFldMetaChartId As Nullable(Of Integer)

        Public Property colName() As String Implements IrowVwMetaChartSeriesItem.colName
            Get
                Return m_colName
            End Get
            Set
                If Not Same(m_colName, Value) Then
                    m_colName = Value
                    m_IsDirty(FieldIndex.colName) = True
                End If
            End Set
        End Property
        Private m_colName As String

        Public Property colField() As String Implements IrowVwMetaChartSeriesItem.colField
            Get
                Return m_colField
            End Get
            Set
                If Not Same(m_colField, Value) Then
                    m_colField = Value
                    m_IsDirty(FieldIndex.colField) = True
                End If
            End Set
        End Property
        Private m_colField As String

        Public Property colCategoryField() As String Implements IrowVwMetaChartSeriesItem.colCategoryField
            Get
                Return m_colCategoryField
            End Get
            Set
                If Not Same(m_colCategoryField, Value) Then
                    m_colCategoryField = Value
                    m_IsDirty(FieldIndex.colCategoryField) = True
                End If
            End Set
        End Property
        Private m_colCategoryField As String

        Public Property colColorField() As String Implements IrowVwMetaChartSeriesItem.colColorField
            Get
                Return m_colColorField
            End Get
            Set
                If Not Same(m_colColorField, Value) Then
                    m_colColorField = Value
                    m_IsDirty(FieldIndex.colColorField) = True
                End If
            End Set
        End Property
        Private m_colColorField As String

        Public Property colColor() As String Implements IrowVwMetaChartSeriesItem.colColor
            Get
                Return m_colColor
            End Get
            Set
                If Not Same(m_colColor, Value) Then
                    m_colColor = Value
                    m_IsDirty(FieldIndex.colColor) = True
                End If
            End Set
        End Property
        Private m_colColor As String

        Public Property colFldTypeName() As String Implements IrowVwMetaChartSeriesItem.colFldTypeName
            Get
                Return m_colFldTypeName
            End Get
            Set
                If Not Same(m_colFldTypeName, Value) Then
                    m_colFldTypeName = Value
                    m_IsDirty(FieldIndex.colFldTypeName) = True
                End If
            End Set
        End Property
        Private m_colFldTypeName As String


        Public Function IsDirty(pIndex As rowVwMetaChartSeriesItem.FieldIndex) As Boolean Implements IrowVwMetaChartSeriesItem.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwMetaChartSeriesItem.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwMetaChartSeriesItem.SetIsDirty
            m_IsDirty(FieldIndex.colFldId) = pDirty
            m_IsDirty(FieldIndex.colFldMetaChartId) = pDirty
            m_IsDirty(FieldIndex.colName) = pDirty
            m_IsDirty(FieldIndex.colField) = pDirty
            m_IsDirty(FieldIndex.colCategoryField) = pDirty
            m_IsDirty(FieldIndex.colColorField) = pDirty
            m_IsDirty(FieldIndex.colColor) = pDirty
            m_IsDirty(FieldIndex.colFldTypeName) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwMetaChartSeriesItem) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwMetaChartSeriesItem
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldId  = 1
            colFldMetaChartId 
            colName 
            colField 
            colCategoryField 
            colColorField 
            colColor 
            colFldTypeName 
        End Enum

        Private m_IsDirty(8) As Boolean

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

    Public Interface IrowVwMetaChartSeriesItem
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldId() As Nullable(Of Integer)
        Property colFldMetaChartId() As Nullable(Of Integer)
        Property colName() As String
        Property colField() As String
        Property colCategoryField() As String
        Property colColorField() As String
        Property colColor() As String
        Property colFldTypeName() As String
        Function IsDirty(pIndex As rowVwMetaChartSeriesItem.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

