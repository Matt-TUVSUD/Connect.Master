'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblGridFavorite
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldTitle As New razor.UtilSQLServer.StringDataColumn
        Public colFldFilePrefix As New razor.UtilSQLServer.StringDataColumn
        Public colFldGridId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldEzyUserId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldPractice As New razor.UtilSQLServer.StringDataColumn
        Public colFldCurrencyId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldUnitId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldColumnOrderJSON As New razor.UtilSQLServer.StringDataColumn
        Public colFldSortJSON As New razor.UtilSQLServer.StringDataColumn
        Public colFldFilterJSON As New razor.UtilSQLServer.StringDataColumn
        Public colFldCriteriaJSON As New razor.UtilSQLServer.StringDataColumn
        Public colFldUpdateDate As New razor.UtilSQLServer.DateTimeDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colId.ColumnName = "[Id]"
            colFldTitle.ColumnName = "[fldTitle]"
            colFldFilePrefix.ColumnName = "[fldFilePrefix]"
            colFldGridId.ColumnName = "[fldGridId]"
            colFldEzyUserId.ColumnName = "[fldEzyUserId]"
            colFldPractice.ColumnName = "[fldPractice]"
            colFldCurrencyId.ColumnName = "[fldCurrencyId]"
            colFldUnitId.ColumnName = "[fldUnitId]"
            colFldColumnOrderJSON.ColumnName = "[fldColumnOrderJSON]"
            colFldSortJSON.ColumnName = "[fldSortJSON]"
            colFldFilterJSON.ColumnName = "[fldFilterJSON]"
            colFldCriteriaJSON.ColumnName = "[fldCriteriaJSON]"
            colFldUpdateDate.ColumnName = "[fldUpdateDate]"

            _Members.Add("colId", colId)
            _Members.Add("colFldTitle", colFldTitle)
            _Members.Add("colFldFilePrefix", colFldFilePrefix)
            _Members.Add("colFldGridId", colFldGridId)
            _Members.Add("colFldEzyUserId", colFldEzyUserId)
            _Members.Add("colFldPractice", colFldPractice)
            _Members.Add("colFldCurrencyId", colFldCurrencyId)
            _Members.Add("colFldUnitId", colFldUnitId)
            _Members.Add("colFldColumnOrderJSON", colFldColumnOrderJSON)
            _Members.Add("colFldSortJSON", colFldSortJSON)
            _Members.Add("colFldFilterJSON", colFldFilterJSON)
            _Members.Add("colFldCriteriaJSON", colFldCriteriaJSON)
            _Members.Add("colFldUpdateDate", colFldUpdateDate)
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
                Case "colId"
                    Return "[Id]"
                Case "colFldTitle"
                    Return "[fldTitle]"
                Case "colFldFilePrefix"
                    Return "[fldFilePrefix]"
                Case "colFldGridId"
                    Return "[fldGridId]"
                Case "colFldEzyUserId"
                    Return "[fldEzyUserId]"
                Case "colFldPractice"
                    Return "[fldPractice]"
                Case "colFldCurrencyId"
                    Return "[fldCurrencyId]"
                Case "colFldUnitId"
                    Return "[fldUnitId]"
                Case "colFldColumnOrderJSON"
                    Return "[fldColumnOrderJSON]"
                Case "colFldSortJSON"
                    Return "[fldSortJSON]"
                Case "colFldFilterJSON"
                    Return "[fldFilterJSON]"
                Case "colFldCriteriaJSON"
                    Return "[fldCriteriaJSON]"
                Case "colFldUpdateDate"
                    Return "[fldUpdateDate]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[Id]", "Id", "Id", "colId"  
                    Return "colId"
                Case "[fldTitle]", "fldTitle", "FldTitle", "colFldTitle"  
                    Return "colFldTitle"
                Case "[fldFilePrefix]", "fldFilePrefix", "FldFilePrefix", "colFldFilePrefix"  
                    Return "colFldFilePrefix"
                Case "[fldGridId]", "fldGridId", "FldGridId", "colFldGridId"  
                    Return "colFldGridId"
                Case "[fldEzyUserId]", "fldEzyUserId", "FldEzyUserId", "colFldEzyUserId"  
                    Return "colFldEzyUserId"
                Case "[fldPractice]", "fldPractice", "FldPractice", "colFldPractice"  
                    Return "colFldPractice"
                Case "[fldCurrencyId]", "fldCurrencyId", "FldCurrencyId", "colFldCurrencyId"  
                    Return "colFldCurrencyId"
                Case "[fldUnitId]", "fldUnitId", "FldUnitId", "colFldUnitId"  
                    Return "colFldUnitId"
                Case "[fldColumnOrderJSON]", "fldColumnOrderJSON", "FldColumnOrderJSON", "colFldColumnOrderJSON"  
                    Return "colFldColumnOrderJSON"
                Case "[fldSortJSON]", "fldSortJSON", "FldSortJSON", "colFldSortJSON"  
                    Return "colFldSortJSON"
                Case "[fldFilterJSON]", "fldFilterJSON", "FldFilterJSON", "colFldFilterJSON"  
                    Return "colFldFilterJSON"
                Case "[fldCriteriaJSON]", "fldCriteriaJSON", "FldCriteriaJSON", "colFldCriteriaJSON"  
                    Return "colFldCriteriaJSON"
                Case "[fldUpdateDate]", "fldUpdateDate", "FldUpdateDate", "colFldUpdateDate"  
                    Return "colFldUpdateDate"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colId"
                    Return "Integer"
                Case "colFldTitle"
                    Return "String"
                Case "colFldFilePrefix"
                    Return "String"
                Case "colFldGridId"
                    Return "Integer"
                Case "colFldEzyUserId"
                    Return "Integer"
                Case "colFldPractice"
                    Return "String"
                Case "colFldCurrencyId"
                    Return "Integer"
                Case "colFldUnitId"
                    Return "Integer"
                Case "colFldColumnOrderJSON"
                    Return "String"
                Case "colFldSortJSON"
                    Return "String"
                Case "colFldFilterJSON"
                    Return "String"
                Case "colFldCriteriaJSON"
                    Return "String"
                Case "colFldUpdateDate"
                    Return "DateTime"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblGridFavorite]"
        End Function

        Private Function _FirstColumn() As String
            Return "[Id]"
        End Function

    End Class
End namespace

