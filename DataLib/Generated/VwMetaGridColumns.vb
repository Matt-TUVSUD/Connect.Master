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
    Partial Public Class VwMetaGridColumns

        Public Shared Function LoadData() As List(Of rowVwMetaGridColumns)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwMetaGridColumns)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwMetaGridColumns)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwMetaGridColumns)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwMetaGridColumns)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwMetaGridColumns)
            Dim zReturn As New List(Of rowVwMetaGridColumns)
            Dim zSQL As String = "SELECT * FROM [gv].[vwMetaGridColumns]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwMetaGridColumns)

			Try
	            Dim zReturn As New List(Of rowVwMetaGridColumns)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwMetaGridColumns

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwMetaGridColumns		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwMetaGridColumns)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFilePrefix")) Then pObject.colFldFilePrefix = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldFilePrefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldDisplayTitle")) Then pObject.colFldDisplayTitle = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldDisplayTitle")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldId")) Then pObject.colFldId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldMetaGridId")) Then pObject.colFldMetaGridId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldMetaGridId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldNotes")) Then pObject.colFldNotes = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldNotes")
			If Not pReader.IsDBNull(pReader.GetOrdinal("type")) Then pObject.colType = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "type")
			If Not pReader.IsDBNull(pReader.GetOrdinal("encoded")) Then pObject.colEncoded = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "encoded")
			If Not pReader.IsDBNull(pReader.GetOrdinal("field")) Then pObject.colField = UtilSQLServer.SafeReader.SafeReadString(pReader, "field")
			If Not pReader.IsDBNull(pReader.GetOrdinal("title")) Then pObject.colTitle = UtilSQLServer.SafeReader.SafeReadString(pReader, "title")
			If Not pReader.IsDBNull(pReader.GetOrdinal("width")) Then pObject.colWidth = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "width")
			If Not pReader.IsDBNull(pReader.GetOrdinal("hidden")) Then pObject.colHidden = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "hidden")
			If Not pReader.IsDBNull(pReader.GetOrdinal("filterable")) Then pObject.colFilterable = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "filterable")
			If Not pReader.IsDBNull(pReader.GetOrdinal("sortable")) Then pObject.colSortable = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "sortable")
			If Not pReader.IsDBNull(pReader.GetOrdinal("groupable")) Then pObject.colGroupable = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "groupable")
			If Not pReader.IsDBNull(pReader.GetOrdinal("locked")) Then pObject.colLocked = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "locked")
			If Not pReader.IsDBNull(pReader.GetOrdinal("lockable")) Then pObject.colLockable = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "lockable")
			If Not pReader.IsDBNull(pReader.GetOrdinal("include")) Then pObject.colInclude = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "include")
			If Not pReader.IsDBNull(pReader.GetOrdinal("format")) Then pObject.colFormat = UtilSQLServer.SafeReader.SafeReadString(pReader, "format")
			If Not pReader.IsDBNull(pReader.GetOrdinal("menu")) Then pObject.colMenu = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "menu")
			If Not pReader.IsDBNull(pReader.GetOrdinal("template")) Then pObject.colTemplate = UtilSQLServer.SafeReader.SafeReadString(pReader, "template")
			If Not pReader.IsDBNull(pReader.GetOrdinal("editable")) Then pObject.colEditable = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "editable")
			If Not pReader.IsDBNull(pReader.GetOrdinal("editor")) Then pObject.colEditor = UtilSQLServer.SafeReader.SafeReadString(pReader, "editor")
			If Not pReader.IsDBNull(pReader.GetOrdinal("nullable")) Then pObject.colNullable = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "nullable")
			If Not pReader.IsDBNull(pReader.GetOrdinal("footerTemplate")) Then pObject.colFooterTemplate = UtilSQLServer.SafeReader.SafeReadString(pReader, "footerTemplate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("headerAttributes")) Then pObject.colHeaderAttributes = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "headerAttributes")
			If Not pReader.IsDBNull(pReader.GetOrdinal("IndexOrder")) Then pObject.colIndexOrder = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "IndexOrder")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SrcField")) Then pObject.colSrcField = UtilSQLServer.SafeReader.SafeReadString(pReader, "SrcField")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SrcTable")) Then pObject.colSrcTable = UtilSQLServer.SafeReader.SafeReadString(pReader, "SrcTable")
			If Not pReader.IsDBNull(pReader.GetOrdinal("KeyField")) Then pObject.colKeyField = UtilSQLServer.SafeReader.SafeReadString(pReader, "KeyField")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFieldNameBackColor")) Then pObject.colFldFieldNameBackColor = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldFieldNameBackColor")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldCustomFeature")) Then pObject.colFldCustomFeature = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldCustomFeature")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldExcludeFromExtract")) Then pObject.colFldExcludeFromExtract = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldExcludeFromExtract")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldMapTitleHtmlSnippet")) Then pObject.colFldMapTitleHtmlSnippet = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldMapTitleHtmlSnippet")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldMapPinIconSqlSnippet")) Then pObject.colFldMapPinIconSqlSnippet = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldMapPinIconSqlSnippet")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldMapDefaultDepicted")) Then pObject.colFldMapDefaultDepicted = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldMapDefaultDepicted")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldMapIsDepictable")) Then pObject.colFldMapIsDepictable = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldMapIsDepictable")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldMapIsPicklistable")) Then pObject.colFldMapIsPicklistable = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldMapIsPicklistable")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldColumnDescription")) Then pObject.colFldColumnDescription = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldColumnDescription")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldExtractWrapText")) Then pObject.colFldExtractWrapText = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldExtractWrapText")
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
            Dim zSQL As String = "SELECT * FROM [gv].[vwMetaGridColumns]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowVwMetaGridColumns
        Implements IrowVwMetaGridColumns

        Public Event Loaded(pUserState As Object) Implements IrowVwMetaGridColumns.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwMetaGridColumns.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwMetaGridColumns.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwMetaGridColumns.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwMetaGridColumns.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwMetaGridColumns.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldFilePrefix() As Nullable(Of Integer) Implements IrowVwMetaGridColumns.colFldFilePrefix
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
        Private m_colFldFilePrefix As Nullable(Of Integer)

        Public Property colFldDisplayTitle() As String Implements IrowVwMetaGridColumns.colFldDisplayTitle
            Get
                Return m_colFldDisplayTitle
            End Get
            Set
                If Not Same(m_colFldDisplayTitle, Value) Then
                    m_colFldDisplayTitle = Value
                    m_IsDirty(FieldIndex.colFldDisplayTitle) = True
                End If
            End Set
        End Property
        Private m_colFldDisplayTitle As String

        Public Property colFldId() As Nullable(Of Integer) Implements IrowVwMetaGridColumns.colFldId
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

        Public Property colFldMetaGridId() As Nullable(Of Integer) Implements IrowVwMetaGridColumns.colFldMetaGridId
            Get
                Return m_colFldMetaGridId
            End Get
            Set
                If Not Same(m_colFldMetaGridId, Value) Then
                    m_colFldMetaGridId = Value
                    m_IsDirty(FieldIndex.colFldMetaGridId) = True
                End If
            End Set
        End Property
        Private m_colFldMetaGridId As Nullable(Of Integer)

        Public Property colFldNotes() As String Implements IrowVwMetaGridColumns.colFldNotes
            Get
                Return m_colFldNotes
            End Get
            Set
                If Not Same(m_colFldNotes, Value) Then
                    m_colFldNotes = Value
                    m_IsDirty(FieldIndex.colFldNotes) = True
                End If
            End Set
        End Property
        Private m_colFldNotes As String

        Public Property colType() As Nullable(Of Integer) Implements IrowVwMetaGridColumns.colType
            Get
                Return m_colType
            End Get
            Set
                If Not Same(m_colType, Value) Then
                    m_colType = Value
                    m_IsDirty(FieldIndex.colType) = True
                End If
            End Set
        End Property
        Private m_colType As Nullable(Of Integer)

        Public Property colEncoded() As Nullable(Of Boolean) Implements IrowVwMetaGridColumns.colEncoded
            Get
                Return m_colEncoded
            End Get
            Set
                If Not Same(m_colEncoded, Value) Then
                    m_colEncoded = Value
                    m_IsDirty(FieldIndex.colEncoded) = True
                End If
            End Set
        End Property
        Private m_colEncoded As Nullable(Of Boolean)

        Public Property colField() As String Implements IrowVwMetaGridColumns.colField
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

        Public Property colTitle() As String Implements IrowVwMetaGridColumns.colTitle
            Get
                Return m_colTitle
            End Get
            Set
                If Not Same(m_colTitle, Value) Then
                    m_colTitle = Value
                    m_IsDirty(FieldIndex.colTitle) = True
                End If
            End Set
        End Property
        Private m_colTitle As String

        Public Property colWidth() As Nullable(Of Integer) Implements IrowVwMetaGridColumns.colWidth
            Get
                Return m_colWidth
            End Get
            Set
                If Not Same(m_colWidth, Value) Then
                    m_colWidth = Value
                    m_IsDirty(FieldIndex.colWidth) = True
                End If
            End Set
        End Property
        Private m_colWidth As Nullable(Of Integer)

        Public Property colHidden() As Nullable(Of Boolean) Implements IrowVwMetaGridColumns.colHidden
            Get
                Return m_colHidden
            End Get
            Set
                If Not Same(m_colHidden, Value) Then
                    m_colHidden = Value
                    m_IsDirty(FieldIndex.colHidden) = True
                End If
            End Set
        End Property
        Private m_colHidden As Nullable(Of Boolean)

        Public Property colFilterable() As Nullable(Of Boolean) Implements IrowVwMetaGridColumns.colFilterable
            Get
                Return m_colFilterable
            End Get
            Set
                If Not Same(m_colFilterable, Value) Then
                    m_colFilterable = Value
                    m_IsDirty(FieldIndex.colFilterable) = True
                End If
            End Set
        End Property
        Private m_colFilterable As Nullable(Of Boolean)

        Public Property colSortable() As Nullable(Of Boolean) Implements IrowVwMetaGridColumns.colSortable
            Get
                Return m_colSortable
            End Get
            Set
                If Not Same(m_colSortable, Value) Then
                    m_colSortable = Value
                    m_IsDirty(FieldIndex.colSortable) = True
                End If
            End Set
        End Property
        Private m_colSortable As Nullable(Of Boolean)

        Public Property colGroupable() As Nullable(Of Boolean) Implements IrowVwMetaGridColumns.colGroupable
            Get
                Return m_colGroupable
            End Get
            Set
                If Not Same(m_colGroupable, Value) Then
                    m_colGroupable = Value
                    m_IsDirty(FieldIndex.colGroupable) = True
                End If
            End Set
        End Property
        Private m_colGroupable As Nullable(Of Boolean)

        Public Property colLocked() As Nullable(Of Boolean) Implements IrowVwMetaGridColumns.colLocked
            Get
                Return m_colLocked
            End Get
            Set
                If Not Same(m_colLocked, Value) Then
                    m_colLocked = Value
                    m_IsDirty(FieldIndex.colLocked) = True
                End If
            End Set
        End Property
        Private m_colLocked As Nullable(Of Boolean)

        Public Property colLockable() As Nullable(Of Boolean) Implements IrowVwMetaGridColumns.colLockable
            Get
                Return m_colLockable
            End Get
            Set
                If Not Same(m_colLockable, Value) Then
                    m_colLockable = Value
                    m_IsDirty(FieldIndex.colLockable) = True
                End If
            End Set
        End Property
        Private m_colLockable As Nullable(Of Boolean)

        Public Property colInclude() As Nullable(Of Boolean) Implements IrowVwMetaGridColumns.colInclude
            Get
                Return m_colInclude
            End Get
            Set
                If Not Same(m_colInclude, Value) Then
                    m_colInclude = Value
                    m_IsDirty(FieldIndex.colInclude) = True
                End If
            End Set
        End Property
        Private m_colInclude As Nullable(Of Boolean)

        Public Property colFormat() As String Implements IrowVwMetaGridColumns.colFormat
            Get
                Return m_colFormat
            End Get
            Set
                If Not Same(m_colFormat, Value) Then
                    m_colFormat = Value
                    m_IsDirty(FieldIndex.colFormat) = True
                End If
            End Set
        End Property
        Private m_colFormat As String

        Public Property colMenu() As Nullable(Of Boolean) Implements IrowVwMetaGridColumns.colMenu
            Get
                Return m_colMenu
            End Get
            Set
                If Not Same(m_colMenu, Value) Then
                    m_colMenu = Value
                    m_IsDirty(FieldIndex.colMenu) = True
                End If
            End Set
        End Property
        Private m_colMenu As Nullable(Of Boolean)

        Public Property colTemplate() As String Implements IrowVwMetaGridColumns.colTemplate
            Get
                Return m_colTemplate
            End Get
            Set
                If Not Same(m_colTemplate, Value) Then
                    m_colTemplate = Value
                    m_IsDirty(FieldIndex.colTemplate) = True
                End If
            End Set
        End Property
        Private m_colTemplate As String

        Public Property colEditable() As Nullable(Of Boolean) Implements IrowVwMetaGridColumns.colEditable
            Get
                Return m_colEditable
            End Get
            Set
                If Not Same(m_colEditable, Value) Then
                    m_colEditable = Value
                    m_IsDirty(FieldIndex.colEditable) = True
                End If
            End Set
        End Property
        Private m_colEditable As Nullable(Of Boolean)

        Public Property colEditor() As String Implements IrowVwMetaGridColumns.colEditor
            Get
                Return m_colEditor
            End Get
            Set
                If Not Same(m_colEditor, Value) Then
                    m_colEditor = Value
                    m_IsDirty(FieldIndex.colEditor) = True
                End If
            End Set
        End Property
        Private m_colEditor As String

        Public Property colNullable() As Nullable(Of Boolean) Implements IrowVwMetaGridColumns.colNullable
            Get
                Return m_colNullable
            End Get
            Set
                If Not Same(m_colNullable, Value) Then
                    m_colNullable = Value
                    m_IsDirty(FieldIndex.colNullable) = True
                End If
            End Set
        End Property
        Private m_colNullable As Nullable(Of Boolean)

        Public Property colFooterTemplate() As String Implements IrowVwMetaGridColumns.colFooterTemplate
            Get
                Return m_colFooterTemplate
            End Get
            Set
                If Not Same(m_colFooterTemplate, Value) Then
                    m_colFooterTemplate = Value
                    m_IsDirty(FieldIndex.colFooterTemplate) = True
                End If
            End Set
        End Property
        Private m_colFooterTemplate As String

        Public Property colHeaderAttributes() As Nullable(Of Integer) Implements IrowVwMetaGridColumns.colHeaderAttributes
            Get
                Return m_colHeaderAttributes
            End Get
            Set
                If Not Same(m_colHeaderAttributes, Value) Then
                    m_colHeaderAttributes = Value
                    m_IsDirty(FieldIndex.colHeaderAttributes) = True
                End If
            End Set
        End Property
        Private m_colHeaderAttributes As Nullable(Of Integer)

        Public Property colIndexOrder() As Nullable(Of Integer) Implements IrowVwMetaGridColumns.colIndexOrder
            Get
                Return m_colIndexOrder
            End Get
            Set
                If Not Same(m_colIndexOrder, Value) Then
                    m_colIndexOrder = Value
                    m_IsDirty(FieldIndex.colIndexOrder) = True
                End If
            End Set
        End Property
        Private m_colIndexOrder As Nullable(Of Integer)

        Public Property colSrcField() As String Implements IrowVwMetaGridColumns.colSrcField
            Get
                Return m_colSrcField
            End Get
            Set
                If Not Same(m_colSrcField, Value) Then
                    m_colSrcField = Value
                    m_IsDirty(FieldIndex.colSrcField) = True
                End If
            End Set
        End Property
        Private m_colSrcField As String

        Public Property colSrcTable() As String Implements IrowVwMetaGridColumns.colSrcTable
            Get
                Return m_colSrcTable
            End Get
            Set
                If Not Same(m_colSrcTable, Value) Then
                    m_colSrcTable = Value
                    m_IsDirty(FieldIndex.colSrcTable) = True
                End If
            End Set
        End Property
        Private m_colSrcTable As String

        Public Property colKeyField() As String Implements IrowVwMetaGridColumns.colKeyField
            Get
                Return m_colKeyField
            End Get
            Set
                If Not Same(m_colKeyField, Value) Then
                    m_colKeyField = Value
                    m_IsDirty(FieldIndex.colKeyField) = True
                End If
            End Set
        End Property
        Private m_colKeyField As String

        Public Property colFldFieldNameBackColor() As String Implements IrowVwMetaGridColumns.colFldFieldNameBackColor
            Get
                Return m_colFldFieldNameBackColor
            End Get
            Set
                If Not Same(m_colFldFieldNameBackColor, Value) Then
                    m_colFldFieldNameBackColor = Value
                    m_IsDirty(FieldIndex.colFldFieldNameBackColor) = True
                End If
            End Set
        End Property
        Private m_colFldFieldNameBackColor As String

        Public Property colFldCustomFeature() As String Implements IrowVwMetaGridColumns.colFldCustomFeature
            Get
                Return m_colFldCustomFeature
            End Get
            Set
                If Not Same(m_colFldCustomFeature, Value) Then
                    m_colFldCustomFeature = Value
                    m_IsDirty(FieldIndex.colFldCustomFeature) = True
                End If
            End Set
        End Property
        Private m_colFldCustomFeature As String

        Public Property colFldExcludeFromExtract() As Nullable(Of Boolean) Implements IrowVwMetaGridColumns.colFldExcludeFromExtract
            Get
                Return m_colFldExcludeFromExtract
            End Get
            Set
                If Not Same(m_colFldExcludeFromExtract, Value) Then
                    m_colFldExcludeFromExtract = Value
                    m_IsDirty(FieldIndex.colFldExcludeFromExtract) = True
                End If
            End Set
        End Property
        Private m_colFldExcludeFromExtract As Nullable(Of Boolean)

        Public Property colFldMapTitleHtmlSnippet() As String Implements IrowVwMetaGridColumns.colFldMapTitleHtmlSnippet
            Get
                Return m_colFldMapTitleHtmlSnippet
            End Get
            Set
                If Not Same(m_colFldMapTitleHtmlSnippet, Value) Then
                    m_colFldMapTitleHtmlSnippet = Value
                    m_IsDirty(FieldIndex.colFldMapTitleHtmlSnippet) = True
                End If
            End Set
        End Property
        Private m_colFldMapTitleHtmlSnippet As String

        Public Property colFldMapPinIconSqlSnippet() As String Implements IrowVwMetaGridColumns.colFldMapPinIconSqlSnippet
            Get
                Return m_colFldMapPinIconSqlSnippet
            End Get
            Set
                If Not Same(m_colFldMapPinIconSqlSnippet, Value) Then
                    m_colFldMapPinIconSqlSnippet = Value
                    m_IsDirty(FieldIndex.colFldMapPinIconSqlSnippet) = True
                End If
            End Set
        End Property
        Private m_colFldMapPinIconSqlSnippet As String

        Public Property colFldMapDefaultDepicted() As Nullable(Of Boolean) Implements IrowVwMetaGridColumns.colFldMapDefaultDepicted
            Get
                Return m_colFldMapDefaultDepicted
            End Get
            Set
                If Not Same(m_colFldMapDefaultDepicted, Value) Then
                    m_colFldMapDefaultDepicted = Value
                    m_IsDirty(FieldIndex.colFldMapDefaultDepicted) = True
                End If
            End Set
        End Property
        Private m_colFldMapDefaultDepicted As Nullable(Of Boolean)

        Public Property colFldMapIsDepictable() As Nullable(Of Boolean) Implements IrowVwMetaGridColumns.colFldMapIsDepictable
            Get
                Return m_colFldMapIsDepictable
            End Get
            Set
                If Not Same(m_colFldMapIsDepictable, Value) Then
                    m_colFldMapIsDepictable = Value
                    m_IsDirty(FieldIndex.colFldMapIsDepictable) = True
                End If
            End Set
        End Property
        Private m_colFldMapIsDepictable As Nullable(Of Boolean)

        Public Property colFldMapIsPicklistable() As Nullable(Of Boolean) Implements IrowVwMetaGridColumns.colFldMapIsPicklistable
            Get
                Return m_colFldMapIsPicklistable
            End Get
            Set
                If Not Same(m_colFldMapIsPicklistable, Value) Then
                    m_colFldMapIsPicklistable = Value
                    m_IsDirty(FieldIndex.colFldMapIsPicklistable) = True
                End If
            End Set
        End Property
        Private m_colFldMapIsPicklistable As Nullable(Of Boolean)

        Public Property colFldColumnDescription() As String Implements IrowVwMetaGridColumns.colFldColumnDescription
            Get
                Return m_colFldColumnDescription
            End Get
            Set
                If Not Same(m_colFldColumnDescription, Value) Then
                    m_colFldColumnDescription = Value
                    m_IsDirty(FieldIndex.colFldColumnDescription) = True
                End If
            End Set
        End Property
        Private m_colFldColumnDescription As String

        Public Property colFldExtractWrapText() As Nullable(Of Boolean) Implements IrowVwMetaGridColumns.colFldExtractWrapText
            Get
                Return m_colFldExtractWrapText
            End Get
            Set
                If Not Same(m_colFldExtractWrapText, Value) Then
                    m_colFldExtractWrapText = Value
                    m_IsDirty(FieldIndex.colFldExtractWrapText) = True
                End If
            End Set
        End Property
        Private m_colFldExtractWrapText As Nullable(Of Boolean)


        Public Function IsDirty(pIndex As rowVwMetaGridColumns.FieldIndex) As Boolean Implements IrowVwMetaGridColumns.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwMetaGridColumns.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwMetaGridColumns.SetIsDirty
            m_IsDirty(FieldIndex.colFldFilePrefix) = pDirty
            m_IsDirty(FieldIndex.colFldDisplayTitle) = pDirty
            m_IsDirty(FieldIndex.colFldId) = pDirty
            m_IsDirty(FieldIndex.colFldMetaGridId) = pDirty
            m_IsDirty(FieldIndex.colFldNotes) = pDirty
            m_IsDirty(FieldIndex.colType) = pDirty
            m_IsDirty(FieldIndex.colEncoded) = pDirty
            m_IsDirty(FieldIndex.colField) = pDirty
            m_IsDirty(FieldIndex.colTitle) = pDirty
            m_IsDirty(FieldIndex.colWidth) = pDirty
            m_IsDirty(FieldIndex.colHidden) = pDirty
            m_IsDirty(FieldIndex.colFilterable) = pDirty
            m_IsDirty(FieldIndex.colSortable) = pDirty
            m_IsDirty(FieldIndex.colGroupable) = pDirty
            m_IsDirty(FieldIndex.colLocked) = pDirty
            m_IsDirty(FieldIndex.colLockable) = pDirty
            m_IsDirty(FieldIndex.colInclude) = pDirty
            m_IsDirty(FieldIndex.colFormat) = pDirty
            m_IsDirty(FieldIndex.colMenu) = pDirty
            m_IsDirty(FieldIndex.colTemplate) = pDirty
            m_IsDirty(FieldIndex.colEditable) = pDirty
            m_IsDirty(FieldIndex.colEditor) = pDirty
            m_IsDirty(FieldIndex.colNullable) = pDirty
            m_IsDirty(FieldIndex.colFooterTemplate) = pDirty
            m_IsDirty(FieldIndex.colHeaderAttributes) = pDirty
            m_IsDirty(FieldIndex.colIndexOrder) = pDirty
            m_IsDirty(FieldIndex.colSrcField) = pDirty
            m_IsDirty(FieldIndex.colSrcTable) = pDirty
            m_IsDirty(FieldIndex.colKeyField) = pDirty
            m_IsDirty(FieldIndex.colFldFieldNameBackColor) = pDirty
            m_IsDirty(FieldIndex.colFldCustomFeature) = pDirty
            m_IsDirty(FieldIndex.colFldExcludeFromExtract) = pDirty
            m_IsDirty(FieldIndex.colFldMapTitleHtmlSnippet) = pDirty
            m_IsDirty(FieldIndex.colFldMapPinIconSqlSnippet) = pDirty
            m_IsDirty(FieldIndex.colFldMapDefaultDepicted) = pDirty
            m_IsDirty(FieldIndex.colFldMapIsDepictable) = pDirty
            m_IsDirty(FieldIndex.colFldMapIsPicklistable) = pDirty
            m_IsDirty(FieldIndex.colFldColumnDescription) = pDirty
            m_IsDirty(FieldIndex.colFldExtractWrapText) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwMetaGridColumns) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwMetaGridColumns
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldFilePrefix  = 1
            colFldDisplayTitle 
            colFldId 
            colFldMetaGridId 
            colFldNotes 
            colType 
            colEncoded 
            colField 
            colTitle 
            colWidth 
            colHidden 
            colFilterable 
            colSortable 
            colGroupable 
            colLocked 
            colLockable 
            colInclude 
            colFormat 
            colMenu 
            colTemplate 
            colEditable 
            colEditor 
            colNullable 
            colFooterTemplate 
            colHeaderAttributes 
            colIndexOrder 
            colSrcField 
            colSrcTable 
            colKeyField 
            colFldFieldNameBackColor 
            colFldCustomFeature 
            colFldExcludeFromExtract 
            colFldMapTitleHtmlSnippet 
            colFldMapPinIconSqlSnippet 
            colFldMapDefaultDepicted 
            colFldMapIsDepictable 
            colFldMapIsPicklistable 
            colFldColumnDescription 
            colFldExtractWrapText 
        End Enum

        Private m_IsDirty(39) As Boolean

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

    Public Interface IrowVwMetaGridColumns
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldFilePrefix() As Nullable(Of Integer)
        Property colFldDisplayTitle() As String
        Property colFldId() As Nullable(Of Integer)
        Property colFldMetaGridId() As Nullable(Of Integer)
        Property colFldNotes() As String
        Property colType() As Nullable(Of Integer)
        Property colEncoded() As Nullable(Of Boolean)
        Property colField() As String
        Property colTitle() As String
        Property colWidth() As Nullable(Of Integer)
        Property colHidden() As Nullable(Of Boolean)
        Property colFilterable() As Nullable(Of Boolean)
        Property colSortable() As Nullable(Of Boolean)
        Property colGroupable() As Nullable(Of Boolean)
        Property colLocked() As Nullable(Of Boolean)
        Property colLockable() As Nullable(Of Boolean)
        Property colInclude() As Nullable(Of Boolean)
        Property colFormat() As String
        Property colMenu() As Nullable(Of Boolean)
        Property colTemplate() As String
        Property colEditable() As Nullable(Of Boolean)
        Property colEditor() As String
        Property colNullable() As Nullable(Of Boolean)
        Property colFooterTemplate() As String
        Property colHeaderAttributes() As Nullable(Of Integer)
        Property colIndexOrder() As Nullable(Of Integer)
        Property colSrcField() As String
        Property colSrcTable() As String
        Property colKeyField() As String
        Property colFldFieldNameBackColor() As String
        Property colFldCustomFeature() As String
        Property colFldExcludeFromExtract() As Nullable(Of Boolean)
        Property colFldMapTitleHtmlSnippet() As String
        Property colFldMapPinIconSqlSnippet() As String
        Property colFldMapDefaultDepicted() As Nullable(Of Boolean)
        Property colFldMapIsDepictable() As Nullable(Of Boolean)
        Property colFldMapIsPicklistable() As Nullable(Of Boolean)
        Property colFldColumnDescription() As String
        Property colFldExtractWrapText() As Nullable(Of Boolean)
        Function IsDirty(pIndex As rowVwMetaGridColumns.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

