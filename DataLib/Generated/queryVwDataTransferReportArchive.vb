'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryVwDataTransferReportArchive
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colReportArchiveId As New razor.UtilSQLServer.IntegerDataColumn
        Public colColumnName As New razor.UtilSQLServer.StringDataColumn
        Public colFilePrefix As New razor.UtilSQLServer.StringDataColumn
        Public colFileNo As New razor.UtilSQLServer.StringDataColumn
        Public colDocumentDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colPractice As New razor.UtilSQLServer.StringDataColumn
        Public colPDFFilePath As New razor.UtilSQLServer.StringDataColumn
        Public colClientDBRootPath As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colReportArchiveId.ColumnName = "[ReportArchiveId]"
            colColumnName.ColumnName = "[ColumnName]"
            colFilePrefix.ColumnName = "[FilePrefix]"
            colFileNo.ColumnName = "[FileNo]"
            colDocumentDate.ColumnName = "[DocumentDate]"
            colPractice.ColumnName = "[Practice]"
            colPDFFilePath.ColumnName = "[PDFFilePath]"
            colClientDBRootPath.ColumnName = "[ClientDBRootPath]"

            _Members.Add("colReportArchiveId", colReportArchiveId)
            _Members.Add("colColumnName", colColumnName)
            _Members.Add("colFilePrefix", colFilePrefix)
            _Members.Add("colFileNo", colFileNo)
            _Members.Add("colDocumentDate", colDocumentDate)
            _Members.Add("colPractice", colPractice)
            _Members.Add("colPDFFilePath", colPDFFilePath)
            _Members.Add("colClientDBRootPath", colClientDBRootPath)
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
                Case "colReportArchiveId"
                    Return "[ReportArchiveId]"
                Case "colColumnName"
                    Return "[ColumnName]"
                Case "colFilePrefix"
                    Return "[FilePrefix]"
                Case "colFileNo"
                    Return "[FileNo]"
                Case "colDocumentDate"
                    Return "[DocumentDate]"
                Case "colPractice"
                    Return "[Practice]"
                Case "colPDFFilePath"
                    Return "[PDFFilePath]"
                Case "colClientDBRootPath"
                    Return "[ClientDBRootPath]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[ReportArchiveId]", "ReportArchiveId", "ReportArchiveId", "colReportArchiveId"  
                    Return "colReportArchiveId"
                Case "[ColumnName]", "ColumnName", "ColumnName", "colColumnName"  
                    Return "colColumnName"
                Case "[FilePrefix]", "FilePrefix", "FilePrefix", "colFilePrefix"  
                    Return "colFilePrefix"
                Case "[FileNo]", "FileNo", "FileNo", "colFileNo"  
                    Return "colFileNo"
                Case "[DocumentDate]", "DocumentDate", "DocumentDate", "colDocumentDate"  
                    Return "colDocumentDate"
                Case "[Practice]", "Practice", "Practice", "colPractice"  
                    Return "colPractice"
                Case "[PDFFilePath]", "PDFFilePath", "PDFFilePath", "colPDFFilePath"  
                    Return "colPDFFilePath"
                Case "[ClientDBRootPath]", "ClientDBRootPath", "ClientDBRootPath", "colClientDBRootPath"  
                    Return "colClientDBRootPath"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colReportArchiveId"
                    Return "Integer"
                Case "colColumnName"
                    Return "String"
                Case "colFilePrefix"
                    Return "String"
                Case "colFileNo"
                    Return "String"
                Case "colDocumentDate"
                    Return "DateTime"
                Case "colPractice"
                    Return "String"
                Case "colPDFFilePath"
                    Return "String"
                Case "colClientDBRootPath"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[jv].[vwDataTransferReportArchive]"
        End Function

        Private Function _FirstColumn() As String
            Return "[ReportArchiveId]"
        End Function

    End Class
End namespace

