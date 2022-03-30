'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblMetaSQL
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldSql As New razor.UtilSQLServer.StringDataColumn
        Public colFldCreatedate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colFldDataKey As New razor.UtilSQLServer.StringDataColumn
        Public colFldForeignKey As New razor.UtilSQLServer.StringDataColumn
        Public colFldBatchKey As New razor.UtilSQLServer.StringDataColumn
        Public colFldDebugInfo As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldId.ColumnName = "[fldId]"
            colFldSql.ColumnName = "[fldSql]"
            colFldCreatedate.ColumnName = "[fldCreatedate]"
            colFldDataKey.ColumnName = "[fldDataKey]"
            colFldForeignKey.ColumnName = "[fldForeignKey]"
            colFldBatchKey.ColumnName = "[fldBatchKey]"
            colFldDebugInfo.ColumnName = "[fldDebugInfo]"

            _Members.Add("colFldId", colFldId)
            _Members.Add("colFldSql", colFldSql)
            _Members.Add("colFldCreatedate", colFldCreatedate)
            _Members.Add("colFldDataKey", colFldDataKey)
            _Members.Add("colFldForeignKey", colFldForeignKey)
            _Members.Add("colFldBatchKey", colFldBatchKey)
            _Members.Add("colFldDebugInfo", colFldDebugInfo)
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
                Case "colFldSql"
                    Return "[fldSql]"
                Case "colFldCreatedate"
                    Return "[fldCreatedate]"
                Case "colFldDataKey"
                    Return "[fldDataKey]"
                Case "colFldForeignKey"
                    Return "[fldForeignKey]"
                Case "colFldBatchKey"
                    Return "[fldBatchKey]"
                Case "colFldDebugInfo"
                    Return "[fldDebugInfo]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldId]", "fldId", "FldId", "colFldId"  
                    Return "colFldId"
                Case "[fldSql]", "fldSql", "FldSql", "colFldSql"  
                    Return "colFldSql"
                Case "[fldCreatedate]", "fldCreatedate", "FldCreatedate", "colFldCreatedate"  
                    Return "colFldCreatedate"
                Case "[fldDataKey]", "fldDataKey", "FldDataKey", "colFldDataKey"  
                    Return "colFldDataKey"
                Case "[fldForeignKey]", "fldForeignKey", "FldForeignKey", "colFldForeignKey"  
                    Return "colFldForeignKey"
                Case "[fldBatchKey]", "fldBatchKey", "FldBatchKey", "colFldBatchKey"  
                    Return "colFldBatchKey"
                Case "[fldDebugInfo]", "fldDebugInfo", "FldDebugInfo", "colFldDebugInfo"  
                    Return "colFldDebugInfo"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldId"
                    Return "Integer"
                Case "colFldSql"
                    Return "String"
                Case "colFldCreatedate"
                    Return "DateTime"
                Case "colFldDataKey"
                    Return "String"
                Case "colFldForeignKey"
                    Return "String"
                Case "colFldBatchKey"
                    Return "String"
                Case "colFldDebugInfo"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblMetaSQL]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldId]"
        End Function

    End Class
End namespace

