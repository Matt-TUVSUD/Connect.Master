'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblReportArchiveValidation
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colId As New razor.UtilSQLServer.IntegerDataColumn
        Public colReportArchiveID As New razor.UtilSQLServer.IntegerDataColumn
        Public colFilePath As New razor.UtilSQLServer.StringDataColumn
        Public colReportType As New razor.UtilSQLServer.StringDataColumn
        Public colIsValid As New razor.UtilSQLServer.BooleanDataColumn
        Public colValidationDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colSuggestedFilePath As New razor.UtilSQLServer.StringDataColumn
        Public colSuggestedFilePathCount As New razor.UtilSQLServer.IntegerDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colId.ColumnName = "[ID]"
            colReportArchiveID.ColumnName = "[ReportArchiveID]"
            colFilePath.ColumnName = "[FilePath]"
            colReportType.ColumnName = "[ReportType]"
            colIsValid.ColumnName = "[IsValid]"
            colValidationDate.ColumnName = "[ValidationDate]"
            colSuggestedFilePath.ColumnName = "[SuggestedFilePath]"
            colSuggestedFilePathCount.ColumnName = "[SuggestedFilePathCount]"

            _Members.Add("colId", colId)
            _Members.Add("colReportArchiveID", colReportArchiveID)
            _Members.Add("colFilePath", colFilePath)
            _Members.Add("colReportType", colReportType)
            _Members.Add("colIsValid", colIsValid)
            _Members.Add("colValidationDate", colValidationDate)
            _Members.Add("colSuggestedFilePath", colSuggestedFilePath)
            _Members.Add("colSuggestedFilePathCount", colSuggestedFilePathCount)
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
                    Return "[ID]"
                Case "colReportArchiveID"
                    Return "[ReportArchiveID]"
                Case "colFilePath"
                    Return "[FilePath]"
                Case "colReportType"
                    Return "[ReportType]"
                Case "colIsValid"
                    Return "[IsValid]"
                Case "colValidationDate"
                    Return "[ValidationDate]"
                Case "colSuggestedFilePath"
                    Return "[SuggestedFilePath]"
                Case "colSuggestedFilePathCount"
                    Return "[SuggestedFilePathCount]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[ID]", "ID", "Id", "colId"  
                    Return "colId"
                Case "[ReportArchiveID]", "ReportArchiveID", "ReportArchiveID", "colReportArchiveID"  
                    Return "colReportArchiveID"
                Case "[FilePath]", "FilePath", "FilePath", "colFilePath"  
                    Return "colFilePath"
                Case "[ReportType]", "ReportType", "ReportType", "colReportType"  
                    Return "colReportType"
                Case "[IsValid]", "IsValid", "IsValid", "colIsValid"  
                    Return "colIsValid"
                Case "[ValidationDate]", "ValidationDate", "ValidationDate", "colValidationDate"  
                    Return "colValidationDate"
                Case "[SuggestedFilePath]", "SuggestedFilePath", "SuggestedFilePath", "colSuggestedFilePath"  
                    Return "colSuggestedFilePath"
                Case "[SuggestedFilePathCount]", "SuggestedFilePathCount", "SuggestedFilePathCount", "colSuggestedFilePathCount"  
                    Return "colSuggestedFilePathCount"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colId"
                    Return "Integer"
                Case "colReportArchiveID"
                    Return "Integer"
                Case "colFilePath"
                    Return "String"
                Case "colReportType"
                    Return "String"
                Case "colIsValid"
                    Return "Boolean"
                Case "colValidationDate"
                    Return "DateTime"
                Case "colSuggestedFilePath"
                    Return "String"
                Case "colSuggestedFilePathCount"
                    Return "Integer"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[ReportArchiveValidation]"
        End Function

        Private Function _FirstColumn() As String
            Return "[ID]"
        End Function

    End Class
End namespace

