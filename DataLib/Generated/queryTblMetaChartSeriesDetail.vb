'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblMetaChartSeriesDetail
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldMetaChartSeriesId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldMetaChartDrillDownId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldIndexOrder As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldField As New razor.UtilSQLServer.StringDataColumn
        Public colFldTitle As New razor.UtilSQLServer.StringDataColumn
        Public colFldColor As New razor.UtilSQLServer.StringDataColumn
        Public colFldNotes As New razor.UtilSQLServer.StringDataColumn
        Public colFldMetaChartDrillDownTypeId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldInclude As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldCustomFeature As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldId.ColumnName = "[fldId]"
            colFldMetaChartSeriesId.ColumnName = "[fldMetaChartSeriesId]"
            colFldMetaChartDrillDownId.ColumnName = "[fldMetaChartDrillDownId]"
            colFldIndexOrder.ColumnName = "[fldIndexOrder]"
            colFldField.ColumnName = "[fldField]"
            colFldTitle.ColumnName = "[fldTitle]"
            colFldColor.ColumnName = "[fldColor]"
            colFldNotes.ColumnName = "[fldNotes]"
            colFldMetaChartDrillDownTypeId.ColumnName = "[fldMetaChartDrillDownTypeId]"
            colFldInclude.ColumnName = "[fldInclude]"
            colFldCustomFeature.ColumnName = "[fldCustomFeature]"

            _Members.Add("colFldId", colFldId)
            _Members.Add("colFldMetaChartSeriesId", colFldMetaChartSeriesId)
            _Members.Add("colFldMetaChartDrillDownId", colFldMetaChartDrillDownId)
            _Members.Add("colFldIndexOrder", colFldIndexOrder)
            _Members.Add("colFldField", colFldField)
            _Members.Add("colFldTitle", colFldTitle)
            _Members.Add("colFldColor", colFldColor)
            _Members.Add("colFldNotes", colFldNotes)
            _Members.Add("colFldMetaChartDrillDownTypeId", colFldMetaChartDrillDownTypeId)
            _Members.Add("colFldInclude", colFldInclude)
            _Members.Add("colFldCustomFeature", colFldCustomFeature)
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
                Case "colFldMetaChartSeriesId"
                    Return "[fldMetaChartSeriesId]"
                Case "colFldMetaChartDrillDownId"
                    Return "[fldMetaChartDrillDownId]"
                Case "colFldIndexOrder"
                    Return "[fldIndexOrder]"
                Case "colFldField"
                    Return "[fldField]"
                Case "colFldTitle"
                    Return "[fldTitle]"
                Case "colFldColor"
                    Return "[fldColor]"
                Case "colFldNotes"
                    Return "[fldNotes]"
                Case "colFldMetaChartDrillDownTypeId"
                    Return "[fldMetaChartDrillDownTypeId]"
                Case "colFldInclude"
                    Return "[fldInclude]"
                Case "colFldCustomFeature"
                    Return "[fldCustomFeature]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldId]", "fldId", "FldId", "colFldId"  
                    Return "colFldId"
                Case "[fldMetaChartSeriesId]", "fldMetaChartSeriesId", "FldMetaChartSeriesId", "colFldMetaChartSeriesId"  
                    Return "colFldMetaChartSeriesId"
                Case "[fldMetaChartDrillDownId]", "fldMetaChartDrillDownId", "FldMetaChartDrillDownId", "colFldMetaChartDrillDownId"  
                    Return "colFldMetaChartDrillDownId"
                Case "[fldIndexOrder]", "fldIndexOrder", "FldIndexOrder", "colFldIndexOrder"  
                    Return "colFldIndexOrder"
                Case "[fldField]", "fldField", "FldField", "colFldField"  
                    Return "colFldField"
                Case "[fldTitle]", "fldTitle", "FldTitle", "colFldTitle"  
                    Return "colFldTitle"
                Case "[fldColor]", "fldColor", "FldColor", "colFldColor"  
                    Return "colFldColor"
                Case "[fldNotes]", "fldNotes", "FldNotes", "colFldNotes"  
                    Return "colFldNotes"
                Case "[fldMetaChartDrillDownTypeId]", "fldMetaChartDrillDownTypeId", "FldMetaChartDrillDownTypeId", "colFldMetaChartDrillDownTypeId"  
                    Return "colFldMetaChartDrillDownTypeId"
                Case "[fldInclude]", "fldInclude", "FldInclude", "colFldInclude"  
                    Return "colFldInclude"
                Case "[fldCustomFeature]", "fldCustomFeature", "FldCustomFeature", "colFldCustomFeature"  
                    Return "colFldCustomFeature"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldId"
                    Return "Integer"
                Case "colFldMetaChartSeriesId"
                    Return "Integer"
                Case "colFldMetaChartDrillDownId"
                    Return "Integer"
                Case "colFldIndexOrder"
                    Return "Integer"
                Case "colFldField"
                    Return "String"
                Case "colFldTitle"
                    Return "String"
                Case "colFldColor"
                    Return "String"
                Case "colFldNotes"
                    Return "String"
                Case "colFldMetaChartDrillDownTypeId"
                    Return "Integer"
                Case "colFldInclude"
                    Return "Boolean"
                Case "colFldCustomFeature"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblMetaChartSeriesDetail]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldId]"
        End Function

    End Class
End namespace

