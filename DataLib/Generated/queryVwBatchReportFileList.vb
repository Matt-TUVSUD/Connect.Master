'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryVwBatchReportFileList
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldFilePrefix As New razor.UtilSQLServer.StringDataColumn
        Public colClientname As New razor.UtilSQLServer.StringDataColumn
        Public colFldCreatedByGsafeId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldSetId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldGuid As New razor.UtilSQLServer.StringDataColumn
        Public colFldCreateDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colFldAccessDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colFldFileSize As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldMime As New razor.UtilSQLServer.StringDataColumn
        Public colFldExtension As New razor.UtilSQLServer.StringDataColumn
        Public colFldFileName As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldFilePrefix.ColumnName = "[fldFilePrefix]"
            colClientname.ColumnName = "[clientname]"
            colFldCreatedByGsafeId.ColumnName = "[fldCreatedByGsafeId]"
            colFldSetId.ColumnName = "[fldSetId]"
            colFldGuid.ColumnName = "[fldGuid]"
            colFldCreateDate.ColumnName = "[fldCreateDate]"
            colFldAccessDate.ColumnName = "[fldAccessDate]"
            colFldFileSize.ColumnName = "[fldFileSize]"
            colFldMime.ColumnName = "[fldMime]"
            colFldExtension.ColumnName = "[fldExtension]"
            colFldFileName.ColumnName = "[fldFileName]"

            _Members.Add("colFldFilePrefix", colFldFilePrefix)
            _Members.Add("colClientname", colClientname)
            _Members.Add("colFldCreatedByGsafeId", colFldCreatedByGsafeId)
            _Members.Add("colFldSetId", colFldSetId)
            _Members.Add("colFldGuid", colFldGuid)
            _Members.Add("colFldCreateDate", colFldCreateDate)
            _Members.Add("colFldAccessDate", colFldAccessDate)
            _Members.Add("colFldFileSize", colFldFileSize)
            _Members.Add("colFldMime", colFldMime)
            _Members.Add("colFldExtension", colFldExtension)
            _Members.Add("colFldFileName", colFldFileName)
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
                Case "colFldFilePrefix"
                    Return "[fldFilePrefix]"
                Case "colClientname"
                    Return "[clientname]"
                Case "colFldCreatedByGsafeId"
                    Return "[fldCreatedByGsafeId]"
                Case "colFldSetId"
                    Return "[fldSetId]"
                Case "colFldGuid"
                    Return "[fldGuid]"
                Case "colFldCreateDate"
                    Return "[fldCreateDate]"
                Case "colFldAccessDate"
                    Return "[fldAccessDate]"
                Case "colFldFileSize"
                    Return "[fldFileSize]"
                Case "colFldMime"
                    Return "[fldMime]"
                Case "colFldExtension"
                    Return "[fldExtension]"
                Case "colFldFileName"
                    Return "[fldFileName]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldFilePrefix]", "fldFilePrefix", "FldFilePrefix", "colFldFilePrefix"  
                    Return "colFldFilePrefix"
                Case "[clientname]", "clientname", "Clientname", "colClientname"  
                    Return "colClientname"
                Case "[fldCreatedByGsafeId]", "fldCreatedByGsafeId", "FldCreatedByGsafeId", "colFldCreatedByGsafeId"  
                    Return "colFldCreatedByGsafeId"
                Case "[fldSetId]", "fldSetId", "FldSetId", "colFldSetId"  
                    Return "colFldSetId"
                Case "[fldGuid]", "fldGuid", "FldGuid", "colFldGuid"  
                    Return "colFldGuid"
                Case "[fldCreateDate]", "fldCreateDate", "FldCreateDate", "colFldCreateDate"  
                    Return "colFldCreateDate"
                Case "[fldAccessDate]", "fldAccessDate", "FldAccessDate", "colFldAccessDate"  
                    Return "colFldAccessDate"
                Case "[fldFileSize]", "fldFileSize", "FldFileSize", "colFldFileSize"  
                    Return "colFldFileSize"
                Case "[fldMime]", "fldMime", "FldMime", "colFldMime"  
                    Return "colFldMime"
                Case "[fldExtension]", "fldExtension", "FldExtension", "colFldExtension"  
                    Return "colFldExtension"
                Case "[fldFileName]", "fldFileName", "FldFileName", "colFldFileName"  
                    Return "colFldFileName"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldFilePrefix"
                    Return "String"
                Case "colClientname"
                    Return "String"
                Case "colFldCreatedByGsafeId"
                    Return "Integer"
                Case "colFldSetId"
                    Return "Integer"
                Case "colFldGuid"
                    Return "String"
                Case "colFldCreateDate"
                    Return "DateTime"
                Case "colFldAccessDate"
                    Return "DateTime"
                Case "colFldFileSize"
                    Return "Integer"
                Case "colFldMime"
                    Return "String"
                Case "colFldExtension"
                    Return "String"
                Case "colFldFileName"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[vwBatchReportFileList]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldFilePrefix]"
        End Function

    End Class
End namespace

