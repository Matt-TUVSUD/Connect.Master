'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblMetaGridColumn
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldMetaGridId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldNotes As New razor.UtilSQLServer.StringDataColumn
        Public colType As New razor.UtilSQLServer.IntegerDataColumn
        Public colEncoded As New razor.UtilSQLServer.BooleanDataColumn
        Public colField As New razor.UtilSQLServer.StringDataColumn
        Public colTitle As New razor.UtilSQLServer.StringDataColumn
        Public colWidth As New razor.UtilSQLServer.IntegerDataColumn
        Public colHidden As New razor.UtilSQLServer.BooleanDataColumn
        Public colFilterable As New razor.UtilSQLServer.BooleanDataColumn
        Public colSortable As New razor.UtilSQLServer.BooleanDataColumn
        Public colGroupable As New razor.UtilSQLServer.BooleanDataColumn
        Public colLocked As New razor.UtilSQLServer.BooleanDataColumn
        Public colLockable As New razor.UtilSQLServer.BooleanDataColumn
        Public colInclude As New razor.UtilSQLServer.BooleanDataColumn
        Public colFormat As New razor.UtilSQLServer.StringDataColumn
        Public colMenu As New razor.UtilSQLServer.BooleanDataColumn
        Public colTemplate As New razor.UtilSQLServer.StringDataColumn
        Public colEditable As New razor.UtilSQLServer.BooleanDataColumn
        Public colEditor As New razor.UtilSQLServer.StringDataColumn
        Public colNullable As New razor.UtilSQLServer.BooleanDataColumn
        Public colFooterTemplate As New razor.UtilSQLServer.StringDataColumn
        Public colHeaderAttributes As New razor.UtilSQLServer.IntegerDataColumn
        Public colIndexOrder As New razor.UtilSQLServer.IntegerDataColumn
        Public colSrcField As New razor.UtilSQLServer.StringDataColumn
        Public colSrcTable As New razor.UtilSQLServer.StringDataColumn
        Public colKeyField As New razor.UtilSQLServer.StringDataColumn
        Public colFldFieldNameBackColor As New razor.UtilSQLServer.StringDataColumn
        Public colFldCustomFeature As New razor.UtilSQLServer.StringDataColumn
        Public colFldExcludeFromExtract As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldMapTitleHtmlSnippet As New razor.UtilSQLServer.StringDataColumn
        Public colFldMapPinIconSqlSnippet As New razor.UtilSQLServer.StringDataColumn
        Public colFldMapDefaultDepicted As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldMapIsDepictable As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldMapIsPicklistable As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldColumnDescription As New razor.UtilSQLServer.StringDataColumn
        Public colFldExtractWrapText As New razor.UtilSQLServer.BooleanDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldId.ColumnName = "[fldId]"
            colFldMetaGridId.ColumnName = "[fldMetaGridId]"
            colFldNotes.ColumnName = "[fldNotes]"
            colType.ColumnName = "[type]"
            colEncoded.ColumnName = "[encoded]"
            colField.ColumnName = "[field]"
            colTitle.ColumnName = "[title]"
            colWidth.ColumnName = "[width]"
            colHidden.ColumnName = "[hidden]"
            colFilterable.ColumnName = "[filterable]"
            colSortable.ColumnName = "[sortable]"
            colGroupable.ColumnName = "[groupable]"
            colLocked.ColumnName = "[locked]"
            colLockable.ColumnName = "[lockable]"
            colInclude.ColumnName = "[include]"
            colFormat.ColumnName = "[format]"
            colMenu.ColumnName = "[menu]"
            colTemplate.ColumnName = "[template]"
            colEditable.ColumnName = "[editable]"
            colEditor.ColumnName = "[editor]"
            colNullable.ColumnName = "[nullable]"
            colFooterTemplate.ColumnName = "[footerTemplate]"
            colHeaderAttributes.ColumnName = "[headerAttributes]"
            colIndexOrder.ColumnName = "[IndexOrder]"
            colSrcField.ColumnName = "[SrcField]"
            colSrcTable.ColumnName = "[SrcTable]"
            colKeyField.ColumnName = "[KeyField]"
            colFldFieldNameBackColor.ColumnName = "[fldFieldNameBackColor]"
            colFldCustomFeature.ColumnName = "[fldCustomFeature]"
            colFldExcludeFromExtract.ColumnName = "[fldExcludeFromExtract]"
            colFldMapTitleHtmlSnippet.ColumnName = "[fldMapTitleHtmlSnippet]"
            colFldMapPinIconSqlSnippet.ColumnName = "[fldMapPinIconSqlSnippet]"
            colFldMapDefaultDepicted.ColumnName = "[fldMapDefaultDepicted]"
            colFldMapIsDepictable.ColumnName = "[fldMapIsDepictable]"
            colFldMapIsPicklistable.ColumnName = "[fldMapIsPicklistable]"
            colFldColumnDescription.ColumnName = "[fldColumnDescription]"
            colFldExtractWrapText.ColumnName = "[fldExtractWrapText]"

            _Members.Add("colFldId", colFldId)
            _Members.Add("colFldMetaGridId", colFldMetaGridId)
            _Members.Add("colFldNotes", colFldNotes)
            _Members.Add("colType", colType)
            _Members.Add("colEncoded", colEncoded)
            _Members.Add("colField", colField)
            _Members.Add("colTitle", colTitle)
            _Members.Add("colWidth", colWidth)
            _Members.Add("colHidden", colHidden)
            _Members.Add("colFilterable", colFilterable)
            _Members.Add("colSortable", colSortable)
            _Members.Add("colGroupable", colGroupable)
            _Members.Add("colLocked", colLocked)
            _Members.Add("colLockable", colLockable)
            _Members.Add("colInclude", colInclude)
            _Members.Add("colFormat", colFormat)
            _Members.Add("colMenu", colMenu)
            _Members.Add("colTemplate", colTemplate)
            _Members.Add("colEditable", colEditable)
            _Members.Add("colEditor", colEditor)
            _Members.Add("colNullable", colNullable)
            _Members.Add("colFooterTemplate", colFooterTemplate)
            _Members.Add("colHeaderAttributes", colHeaderAttributes)
            _Members.Add("colIndexOrder", colIndexOrder)
            _Members.Add("colSrcField", colSrcField)
            _Members.Add("colSrcTable", colSrcTable)
            _Members.Add("colKeyField", colKeyField)
            _Members.Add("colFldFieldNameBackColor", colFldFieldNameBackColor)
            _Members.Add("colFldCustomFeature", colFldCustomFeature)
            _Members.Add("colFldExcludeFromExtract", colFldExcludeFromExtract)
            _Members.Add("colFldMapTitleHtmlSnippet", colFldMapTitleHtmlSnippet)
            _Members.Add("colFldMapPinIconSqlSnippet", colFldMapPinIconSqlSnippet)
            _Members.Add("colFldMapDefaultDepicted", colFldMapDefaultDepicted)
            _Members.Add("colFldMapIsDepictable", colFldMapIsDepictable)
            _Members.Add("colFldMapIsPicklistable", colFldMapIsPicklistable)
            _Members.Add("colFldColumnDescription", colFldColumnDescription)
            _Members.Add("colFldExtractWrapText", colFldExtractWrapText)
        End Sub

        Public Function Member(pObjectName As String) As Object
            Dim zReturn As Object = Nothing
            If _Members.ContainsKey(pObjectName) Then
                zReturn = _Members.Item(pObjectName)
            Else
                Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in member dictionary.")
            End If
            Return zReturn
        End Function

        Public Function MemberColumn(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldId"
                    Return "[fldId]"
                Case "colFldMetaGridId"
                    Return "[fldMetaGridId]"
                Case "colFldNotes"
                    Return "[fldNotes]"
                Case "colType"
                    Return "[type]"
                Case "colEncoded"
                    Return "[encoded]"
                Case "colField"
                    Return "[field]"
                Case "colTitle"
                    Return "[title]"
                Case "colWidth"
                    Return "[width]"
                Case "colHidden"
                    Return "[hidden]"
                Case "colFilterable"
                    Return "[filterable]"
                Case "colSortable"
                    Return "[sortable]"
                Case "colGroupable"
                    Return "[groupable]"
                Case "colLocked"
                    Return "[locked]"
                Case "colLockable"
                    Return "[lockable]"
                Case "colInclude"
                    Return "[include]"
                Case "colFormat"
                    Return "[format]"
                Case "colMenu"
                    Return "[menu]"
                Case "colTemplate"
                    Return "[template]"
                Case "colEditable"
                    Return "[editable]"
                Case "colEditor"
                    Return "[editor]"
                Case "colNullable"
                    Return "[nullable]"
                Case "colFooterTemplate"
                    Return "[footerTemplate]"
                Case "colHeaderAttributes"
                    Return "[headerAttributes]"
                Case "colIndexOrder"
                    Return "[IndexOrder]"
                Case "colSrcField"
                    Return "[SrcField]"
                Case "colSrcTable"
                    Return "[SrcTable]"
                Case "colKeyField"
                    Return "[KeyField]"
                Case "colFldFieldNameBackColor"
                    Return "[fldFieldNameBackColor]"
                Case "colFldCustomFeature"
                    Return "[fldCustomFeature]"
                Case "colFldExcludeFromExtract"
                    Return "[fldExcludeFromExtract]"
                Case "colFldMapTitleHtmlSnippet"
                    Return "[fldMapTitleHtmlSnippet]"
                Case "colFldMapPinIconSqlSnippet"
                    Return "[fldMapPinIconSqlSnippet]"
                Case "colFldMapDefaultDepicted"
                    Return "[fldMapDefaultDepicted]"
                Case "colFldMapIsDepictable"
                    Return "[fldMapIsDepictable]"
                Case "colFldMapIsPicklistable"
                    Return "[fldMapIsPicklistable]"
                Case "colFldColumnDescription"
                    Return "[fldColumnDescription]"
                Case "colFldExtractWrapText"
                    Return "[fldExtractWrapText]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldId]", "fldId", "FldId", "colFldId"  
                    Return "colFldId"
                Case "[fldMetaGridId]", "fldMetaGridId", "FldMetaGridId", "colFldMetaGridId"  
                    Return "colFldMetaGridId"
                Case "[fldNotes]", "fldNotes", "FldNotes", "colFldNotes"  
                    Return "colFldNotes"
                Case "[type]", "type", "Type", "colType"  
                    Return "colType"
                Case "[encoded]", "encoded", "Encoded", "colEncoded"  
                    Return "colEncoded"
                Case "[field]", "field", "Field", "colField"  
                    Return "colField"
                Case "[title]", "title", "Title", "colTitle"  
                    Return "colTitle"
                Case "[width]", "width", "Width", "colWidth"  
                    Return "colWidth"
                Case "[hidden]", "hidden", "Hidden", "colHidden"  
                    Return "colHidden"
                Case "[filterable]", "filterable", "Filterable", "colFilterable"  
                    Return "colFilterable"
                Case "[sortable]", "sortable", "Sortable", "colSortable"  
                    Return "colSortable"
                Case "[groupable]", "groupable", "Groupable", "colGroupable"  
                    Return "colGroupable"
                Case "[locked]", "locked", "Locked", "colLocked"  
                    Return "colLocked"
                Case "[lockable]", "lockable", "Lockable", "colLockable"  
                    Return "colLockable"
                Case "[include]", "include", "Include", "colInclude"  
                    Return "colInclude"
                Case "[format]", "format", "Format", "colFormat"  
                    Return "colFormat"
                Case "[menu]", "menu", "Menu", "colMenu"  
                    Return "colMenu"
                Case "[template]", "template", "Template", "colTemplate"  
                    Return "colTemplate"
                Case "[editable]", "editable", "Editable", "colEditable"  
                    Return "colEditable"
                Case "[editor]", "editor", "Editor", "colEditor"  
                    Return "colEditor"
                Case "[nullable]", "nullable", "Nullable", "colNullable"  
                    Return "colNullable"
                Case "[footerTemplate]", "footerTemplate", "FooterTemplate", "colFooterTemplate"  
                    Return "colFooterTemplate"
                Case "[headerAttributes]", "headerAttributes", "HeaderAttributes", "colHeaderAttributes"  
                    Return "colHeaderAttributes"
                Case "[IndexOrder]", "IndexOrder", "IndexOrder", "colIndexOrder"  
                    Return "colIndexOrder"
                Case "[SrcField]", "SrcField", "SrcField", "colSrcField"  
                    Return "colSrcField"
                Case "[SrcTable]", "SrcTable", "SrcTable", "colSrcTable"  
                    Return "colSrcTable"
                Case "[KeyField]", "KeyField", "KeyField", "colKeyField"  
                    Return "colKeyField"
                Case "[fldFieldNameBackColor]", "fldFieldNameBackColor", "FldFieldNameBackColor", "colFldFieldNameBackColor"  
                    Return "colFldFieldNameBackColor"
                Case "[fldCustomFeature]", "fldCustomFeature", "FldCustomFeature", "colFldCustomFeature"  
                    Return "colFldCustomFeature"
                Case "[fldExcludeFromExtract]", "fldExcludeFromExtract", "FldExcludeFromExtract", "colFldExcludeFromExtract"  
                    Return "colFldExcludeFromExtract"
                Case "[fldMapTitleHtmlSnippet]", "fldMapTitleHtmlSnippet", "FldMapTitleHtmlSnippet", "colFldMapTitleHtmlSnippet"  
                    Return "colFldMapTitleHtmlSnippet"
                Case "[fldMapPinIconSqlSnippet]", "fldMapPinIconSqlSnippet", "FldMapPinIconSqlSnippet", "colFldMapPinIconSqlSnippet"  
                    Return "colFldMapPinIconSqlSnippet"
                Case "[fldMapDefaultDepicted]", "fldMapDefaultDepicted", "FldMapDefaultDepicted", "colFldMapDefaultDepicted"  
                    Return "colFldMapDefaultDepicted"
                Case "[fldMapIsDepictable]", "fldMapIsDepictable", "FldMapIsDepictable", "colFldMapIsDepictable"  
                    Return "colFldMapIsDepictable"
                Case "[fldMapIsPicklistable]", "fldMapIsPicklistable", "FldMapIsPicklistable", "colFldMapIsPicklistable"  
                    Return "colFldMapIsPicklistable"
                Case "[fldColumnDescription]", "fldColumnDescription", "FldColumnDescription", "colFldColumnDescription"  
                    Return "colFldColumnDescription"
                Case "[fldExtractWrapText]", "fldExtractWrapText", "FldExtractWrapText", "colFldExtractWrapText"  
                    Return "colFldExtractWrapText"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldId"
                    Return "Integer"
                Case "colFldMetaGridId"
                    Return "Integer"
                Case "colFldNotes"
                    Return "String"
                Case "colType"
                    Return "Integer"
                Case "colEncoded"
                    Return "Boolean"
                Case "colField"
                    Return "String"
                Case "colTitle"
                    Return "String"
                Case "colWidth"
                    Return "Integer"
                Case "colHidden"
                    Return "Boolean"
                Case "colFilterable"
                    Return "Boolean"
                Case "colSortable"
                    Return "Boolean"
                Case "colGroupable"
                    Return "Boolean"
                Case "colLocked"
                    Return "Boolean"
                Case "colLockable"
                    Return "Boolean"
                Case "colInclude"
                    Return "Boolean"
                Case "colFormat"
                    Return "String"
                Case "colMenu"
                    Return "Boolean"
                Case "colTemplate"
                    Return "String"
                Case "colEditable"
                    Return "Boolean"
                Case "colEditor"
                    Return "String"
                Case "colNullable"
                    Return "Boolean"
                Case "colFooterTemplate"
                    Return "String"
                Case "colHeaderAttributes"
                    Return "Integer"
                Case "colIndexOrder"
                    Return "Integer"
                Case "colSrcField"
                    Return "String"
                Case "colSrcTable"
                    Return "String"
                Case "colKeyField"
                    Return "String"
                Case "colFldFieldNameBackColor"
                    Return "String"
                Case "colFldCustomFeature"
                    Return "String"
                Case "colFldExcludeFromExtract"
                    Return "Boolean"
                Case "colFldMapTitleHtmlSnippet"
                    Return "String"
                Case "colFldMapPinIconSqlSnippet"
                    Return "String"
                Case "colFldMapDefaultDepicted"
                    Return "Boolean"
                Case "colFldMapIsDepictable"
                    Return "Boolean"
                Case "colFldMapIsPicklistable"
                    Return "Boolean"
                Case "colFldColumnDescription"
                    Return "String"
                Case "colFldExtractWrapText"
                    Return "Boolean"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblMetaGridColumn]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldId]"
        End Function

    End Class
End namespace

