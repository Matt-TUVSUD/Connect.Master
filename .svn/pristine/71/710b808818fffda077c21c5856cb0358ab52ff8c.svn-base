'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryVwImpairmentDropDownGroups
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colSortOrder As New razor.UtilSQLServer.LongDataColumn
        Public colGroupNo As New razor.UtilSQLServer.IntegerDataColumn
        Public colDictionaryId As New razor.UtilSQLServer.IntegerDataColumn
        Public colTextEnglish As New razor.UtilSQLServer.StringDataColumn
        Public colGroupCode As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colSortOrder.ColumnName = "[SortOrder]"
            colGroupNo.ColumnName = "[GroupNo]"
            colDictionaryId.ColumnName = "[DictionaryId]"
            colTextEnglish.ColumnName = "[TextEnglish]"
            colGroupCode.ColumnName = "[GroupCode]"

            _Members.Add("colSortOrder", colSortOrder)
            _Members.Add("colGroupNo", colGroupNo)
            _Members.Add("colDictionaryId", colDictionaryId)
            _Members.Add("colTextEnglish", colTextEnglish)
            _Members.Add("colGroupCode", colGroupCode)
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
                Case "colSortOrder"
                    Return "[SortOrder]"
                Case "colGroupNo"
                    Return "[GroupNo]"
                Case "colDictionaryId"
                    Return "[DictionaryId]"
                Case "colTextEnglish"
                    Return "[TextEnglish]"
                Case "colGroupCode"
                    Return "[GroupCode]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[SortOrder]", "SortOrder", "SortOrder", "colSortOrder"  
                    Return "colSortOrder"
                Case "[GroupNo]", "GroupNo", "GroupNo", "colGroupNo"  
                    Return "colGroupNo"
                Case "[DictionaryId]", "DictionaryId", "DictionaryId", "colDictionaryId"  
                    Return "colDictionaryId"
                Case "[TextEnglish]", "TextEnglish", "TextEnglish", "colTextEnglish"  
                    Return "colTextEnglish"
                Case "[GroupCode]", "GroupCode", "GroupCode", "colGroupCode"  
                    Return "colGroupCode"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colSortOrder"
                    Return "Long"
                Case "colGroupNo"
                    Return "Integer"
                Case "colDictionaryId"
                    Return "Integer"
                Case "colTextEnglish"
                    Return "String"
                Case "colGroupCode"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[rv].[vwImpairmentDropDownGroups]"
        End Function

        Private Function _FirstColumn() As String
            Return "[SortOrder]"
        End Function

    End Class
End namespace

