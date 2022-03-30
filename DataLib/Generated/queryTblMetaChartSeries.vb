'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblMetaChartSeries
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldMetaChartId As New razor.UtilSQLServer.IntegerDataColumn
        Public colName As New razor.UtilSQLServer.StringDataColumn
        Public colType As New razor.UtilSQLServer.IntegerDataColumn
        Public colField As New razor.UtilSQLServer.StringDataColumn
        Public colCategoryField As New razor.UtilSQLServer.StringDataColumn
        Public colColorField As New razor.UtilSQLServer.StringDataColumn
        Public colColor As New razor.UtilSQLServer.StringDataColumn
        Public colFldNotes As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldId.ColumnName = "[fldId]"
            colFldMetaChartId.ColumnName = "[fldMetaChartId]"
            colName.ColumnName = "[name]"
            colType.ColumnName = "[type]"
            colField.ColumnName = "[field]"
            colCategoryField.ColumnName = "[categoryField]"
            colColorField.ColumnName = "[colorField]"
            colColor.ColumnName = "[color]"
            colFldNotes.ColumnName = "[fldNotes]"

            _Members.Add("colFldId", colFldId)
            _Members.Add("colFldMetaChartId", colFldMetaChartId)
            _Members.Add("colName", colName)
            _Members.Add("colType", colType)
            _Members.Add("colField", colField)
            _Members.Add("colCategoryField", colCategoryField)
            _Members.Add("colColorField", colColorField)
            _Members.Add("colColor", colColor)
            _Members.Add("colFldNotes", colFldNotes)
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
                Case "colFldMetaChartId"
                    Return "[fldMetaChartId]"
                Case "colName"
                    Return "[name]"
                Case "colType"
                    Return "[type]"
                Case "colField"
                    Return "[field]"
                Case "colCategoryField"
                    Return "[categoryField]"
                Case "colColorField"
                    Return "[colorField]"
                Case "colColor"
                    Return "[color]"
                Case "colFldNotes"
                    Return "[fldNotes]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldId]", "fldId", "FldId", "colFldId"  
                    Return "colFldId"
                Case "[fldMetaChartId]", "fldMetaChartId", "FldMetaChartId", "colFldMetaChartId"  
                    Return "colFldMetaChartId"
                Case "[name]", "name", "Name", "colName"  
                    Return "colName"
                Case "[type]", "type", "Type", "colType"  
                    Return "colType"
                Case "[field]", "field", "Field", "colField"  
                    Return "colField"
                Case "[categoryField]", "categoryField", "CategoryField", "colCategoryField"  
                    Return "colCategoryField"
                Case "[colorField]", "colorField", "ColorField", "colColorField"  
                    Return "colColorField"
                Case "[color]", "color", "Color", "colColor"  
                    Return "colColor"
                Case "[fldNotes]", "fldNotes", "FldNotes", "colFldNotes"  
                    Return "colFldNotes"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldId"
                    Return "Integer"
                Case "colFldMetaChartId"
                    Return "Integer"
                Case "colName"
                    Return "String"
                Case "colType"
                    Return "Integer"
                Case "colField"
                    Return "String"
                Case "colCategoryField"
                    Return "String"
                Case "colColorField"
                    Return "String"
                Case "colColor"
                    Return "String"
                Case "colFldNotes"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblMetaChartSeries]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldId]"
        End Function

    End Class
End namespace

