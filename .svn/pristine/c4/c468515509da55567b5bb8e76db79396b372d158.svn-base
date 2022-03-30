'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryVwBatchProcessingSet
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldCreateDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colFldFilePrefix As New razor.UtilSQLServer.StringDataColumn
        Public colFldGroupName As New razor.UtilSQLServer.StringDataColumn
        Public colFldStatus As New razor.UtilSQLServer.StringDataColumn
        Public colFldFileName As New razor.UtilSQLServer.StringDataColumn
        Public colFldDisable As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldIsMyBatchReport As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldCreatedByGsafeUserEmail As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldId.ColumnName = "[fldId]"
            colFldCreateDate.ColumnName = "[fldCreateDate]"
            colFldFilePrefix.ColumnName = "[fldFilePrefix]"
            colFldGroupName.ColumnName = "[fldGroupName]"
            colFldStatus.ColumnName = "[fldStatus]"
            colFldFileName.ColumnName = "[fldFileName]"
            colFldDisable.ColumnName = "[fldDisable]"
            colFldIsMyBatchReport.ColumnName = "[fldIsMyBatchReport]"
            colFldCreatedByGsafeUserEmail.ColumnName = "[fldCreatedByGsafeUserEmail]"

            _Members.Add("colFldId", colFldId)
            _Members.Add("colFldCreateDate", colFldCreateDate)
            _Members.Add("colFldFilePrefix", colFldFilePrefix)
            _Members.Add("colFldGroupName", colFldGroupName)
            _Members.Add("colFldStatus", colFldStatus)
            _Members.Add("colFldFileName", colFldFileName)
            _Members.Add("colFldDisable", colFldDisable)
            _Members.Add("colFldIsMyBatchReport", colFldIsMyBatchReport)
            _Members.Add("colFldCreatedByGsafeUserEmail", colFldCreatedByGsafeUserEmail)
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
                Case "colFldCreateDate"
                    Return "[fldCreateDate]"
                Case "colFldFilePrefix"
                    Return "[fldFilePrefix]"
                Case "colFldGroupName"
                    Return "[fldGroupName]"
                Case "colFldStatus"
                    Return "[fldStatus]"
                Case "colFldFileName"
                    Return "[fldFileName]"
                Case "colFldDisable"
                    Return "[fldDisable]"
                Case "colFldIsMyBatchReport"
                    Return "[fldIsMyBatchReport]"
                Case "colFldCreatedByGsafeUserEmail"
                    Return "[fldCreatedByGsafeUserEmail]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldId]", "fldId", "FldId", "colFldId"  
                    Return "colFldId"
                Case "[fldCreateDate]", "fldCreateDate", "FldCreateDate", "colFldCreateDate"  
                    Return "colFldCreateDate"
                Case "[fldFilePrefix]", "fldFilePrefix", "FldFilePrefix", "colFldFilePrefix"  
                    Return "colFldFilePrefix"
                Case "[fldGroupName]", "fldGroupName", "FldGroupName", "colFldGroupName"  
                    Return "colFldGroupName"
                Case "[fldStatus]", "fldStatus", "FldStatus", "colFldStatus"  
                    Return "colFldStatus"
                Case "[fldFileName]", "fldFileName", "FldFileName", "colFldFileName"  
                    Return "colFldFileName"
                Case "[fldDisable]", "fldDisable", "FldDisable", "colFldDisable"  
                    Return "colFldDisable"
                Case "[fldIsMyBatchReport]", "fldIsMyBatchReport", "FldIsMyBatchReport", "colFldIsMyBatchReport"  
                    Return "colFldIsMyBatchReport"
                Case "[fldCreatedByGsafeUserEmail]", "fldCreatedByGsafeUserEmail", "FldCreatedByGsafeUserEmail", "colFldCreatedByGsafeUserEmail"  
                    Return "colFldCreatedByGsafeUserEmail"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldId"
                    Return "Integer"
                Case "colFldCreateDate"
                    Return "DateTime"
                Case "colFldFilePrefix"
                    Return "String"
                Case "colFldGroupName"
                    Return "String"
                Case "colFldStatus"
                    Return "String"
                Case "colFldFileName"
                    Return "String"
                Case "colFldDisable"
                    Return "Boolean"
                Case "colFldIsMyBatchReport"
                    Return "Boolean"
                Case "colFldCreatedByGsafeUserEmail"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[fv].[vwBatchProcessingSet]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldId]"
        End Function

    End Class
End namespace

