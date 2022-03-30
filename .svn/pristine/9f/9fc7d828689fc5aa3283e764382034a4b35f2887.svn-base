'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblClientMetaRatingCategoryColor
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldFilePrefix As New razor.UtilSQLServer.StringDataColumn
        Public colFldCategoryId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldRatingValue As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldColorId As New razor.UtilSQLServer.IntegerDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldId.ColumnName = "[fldId]"
            colFldFilePrefix.ColumnName = "[fldFilePrefix]"
            colFldCategoryId.ColumnName = "[fldCategoryId]"
            colFldRatingValue.ColumnName = "[fldRatingValue]"
            colFldColorId.ColumnName = "[fldColorId]"

            _Members.Add("colFldId", colFldId)
            _Members.Add("colFldFilePrefix", colFldFilePrefix)
            _Members.Add("colFldCategoryId", colFldCategoryId)
            _Members.Add("colFldRatingValue", colFldRatingValue)
            _Members.Add("colFldColorId", colFldColorId)
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
                Case "colFldFilePrefix"
                    Return "[fldFilePrefix]"
                Case "colFldCategoryId"
                    Return "[fldCategoryId]"
                Case "colFldRatingValue"
                    Return "[fldRatingValue]"
                Case "colFldColorId"
                    Return "[fldColorId]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldId]", "fldId", "FldId", "colFldId"  
                    Return "colFldId"
                Case "[fldFilePrefix]", "fldFilePrefix", "FldFilePrefix", "colFldFilePrefix"  
                    Return "colFldFilePrefix"
                Case "[fldCategoryId]", "fldCategoryId", "FldCategoryId", "colFldCategoryId"  
                    Return "colFldCategoryId"
                Case "[fldRatingValue]", "fldRatingValue", "FldRatingValue", "colFldRatingValue"  
                    Return "colFldRatingValue"
                Case "[fldColorId]", "fldColorId", "FldColorId", "colFldColorId"  
                    Return "colFldColorId"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldId"
                    Return "Integer"
                Case "colFldFilePrefix"
                    Return "String"
                Case "colFldCategoryId"
                    Return "Integer"
                Case "colFldRatingValue"
                    Return "Integer"
                Case "colFldColorId"
                    Return "Integer"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblClientMetaRatingCategoryColor]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldId]"
        End Function

    End Class
End namespace

