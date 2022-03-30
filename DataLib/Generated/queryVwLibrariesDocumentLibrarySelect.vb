'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryVwLibrariesDocumentLibrarySelect
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colPDFErFilePath As New razor.UtilSQLServer.StringDataColumn
        Public colPDFDiagramFilePath As New razor.UtilSQLServer.StringDataColumn
        Public colClientDBRootPath As New razor.UtilSQLServer.StringDataColumn
        Public colId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFileno As New razor.UtilSQLServer.StringDataColumn
        Public colClientlocid As New razor.UtilSQLServer.StringDataColumn
        Public colDocumentdate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colLinktoer As New razor.UtilSQLServer.StringDataColumn
        Public colLinktourorlereport As New razor.UtilSQLServer.StringDataColumn
        Public colLinktodiagram As New razor.UtilSQLServer.StringDataColumn
        Public colPractice As New razor.UtilSQLServer.StringDataColumn
        Public colDivision As New razor.UtilSQLServer.StringDataColumn
        Public colFacility As New razor.UtilSQLServer.StringDataColumn
        Public colAddress1 As New razor.UtilSQLServer.StringDataColumn
        Public colCity As New razor.UtilSQLServer.StringDataColumn
        Public colStProv As New razor.UtilSQLServer.StringDataColumn
        Public colCountry As New razor.UtilSQLServer.StringDataColumn
        Public colCldbname As New razor.UtilSQLServer.StringDataColumn
        Public colReportGuid As New razor.UtilSQLServer.StringDataColumn
        Public colMetaPracticeID As New razor.UtilSQLServer.IntegerDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colPDFErFilePath.ColumnName = "[PDFErFilePath]"
            colPDFDiagramFilePath.ColumnName = "[PDFDiagramFilePath]"
            colClientDBRootPath.ColumnName = "[ClientDBRootPath]"
            colId.ColumnName = "[id]"
            colFileno.ColumnName = "[fileno]"
            colClientlocid.ColumnName = "[clientlocid]"
            colDocumentdate.ColumnName = "[documentdate]"
            colLinktoer.ColumnName = "[linktoer]"
            colLinktourorlereport.ColumnName = "[linktourorlereport]"
            colLinktodiagram.ColumnName = "[linktodiagram]"
            colPractice.ColumnName = "[practice]"
            colDivision.ColumnName = "[division]"
            colFacility.ColumnName = "[facility]"
            colAddress1.ColumnName = "[address1]"
            colCity.ColumnName = "[city]"
            colStProv.ColumnName = "[st_prov]"
            colCountry.ColumnName = "[country]"
            colCldbname.ColumnName = "[cldbname]"
            colReportGuid.ColumnName = "[ReportGuid]"
            colMetaPracticeID.ColumnName = "[MetaPracticeID]"

            _Members.Add("colPDFErFilePath", colPDFErFilePath)
            _Members.Add("colPDFDiagramFilePath", colPDFDiagramFilePath)
            _Members.Add("colClientDBRootPath", colClientDBRootPath)
            _Members.Add("colId", colId)
            _Members.Add("colFileno", colFileno)
            _Members.Add("colClientlocid", colClientlocid)
            _Members.Add("colDocumentdate", colDocumentdate)
            _Members.Add("colLinktoer", colLinktoer)
            _Members.Add("colLinktourorlereport", colLinktourorlereport)
            _Members.Add("colLinktodiagram", colLinktodiagram)
            _Members.Add("colPractice", colPractice)
            _Members.Add("colDivision", colDivision)
            _Members.Add("colFacility", colFacility)
            _Members.Add("colAddress1", colAddress1)
            _Members.Add("colCity", colCity)
            _Members.Add("colStProv", colStProv)
            _Members.Add("colCountry", colCountry)
            _Members.Add("colCldbname", colCldbname)
            _Members.Add("colReportGuid", colReportGuid)
            _Members.Add("colMetaPracticeID", colMetaPracticeID)
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
                Case "colPDFErFilePath"
                    Return "[PDFErFilePath]"
                Case "colPDFDiagramFilePath"
                    Return "[PDFDiagramFilePath]"
                Case "colClientDBRootPath"
                    Return "[ClientDBRootPath]"
                Case "colId"
                    Return "[id]"
                Case "colFileno"
                    Return "[fileno]"
                Case "colClientlocid"
                    Return "[clientlocid]"
                Case "colDocumentdate"
                    Return "[documentdate]"
                Case "colLinktoer"
                    Return "[linktoer]"
                Case "colLinktourorlereport"
                    Return "[linktourorlereport]"
                Case "colLinktodiagram"
                    Return "[linktodiagram]"
                Case "colPractice"
                    Return "[practice]"
                Case "colDivision"
                    Return "[division]"
                Case "colFacility"
                    Return "[facility]"
                Case "colAddress1"
                    Return "[address1]"
                Case "colCity"
                    Return "[city]"
                Case "colStProv"
                    Return "[st_prov]"
                Case "colCountry"
                    Return "[country]"
                Case "colCldbname"
                    Return "[cldbname]"
                Case "colReportGuid"
                    Return "[ReportGuid]"
                Case "colMetaPracticeID"
                    Return "[MetaPracticeID]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[PDFErFilePath]", "PDFErFilePath", "PDFErFilePath", "colPDFErFilePath"  
                    Return "colPDFErFilePath"
                Case "[PDFDiagramFilePath]", "PDFDiagramFilePath", "PDFDiagramFilePath", "colPDFDiagramFilePath"  
                    Return "colPDFDiagramFilePath"
                Case "[ClientDBRootPath]", "ClientDBRootPath", "ClientDBRootPath", "colClientDBRootPath"  
                    Return "colClientDBRootPath"
                Case "[id]", "id", "Id", "colId"  
                    Return "colId"
                Case "[fileno]", "fileno", "Fileno", "colFileno"  
                    Return "colFileno"
                Case "[clientlocid]", "clientlocid", "Clientlocid", "colClientlocid"  
                    Return "colClientlocid"
                Case "[documentdate]", "documentdate", "Documentdate", "colDocumentdate"  
                    Return "colDocumentdate"
                Case "[linktoer]", "linktoer", "Linktoer", "colLinktoer"  
                    Return "colLinktoer"
                Case "[linktourorlereport]", "linktourorlereport", "Linktourorlereport", "colLinktourorlereport"  
                    Return "colLinktourorlereport"
                Case "[linktodiagram]", "linktodiagram", "Linktodiagram", "colLinktodiagram"  
                    Return "colLinktodiagram"
                Case "[practice]", "practice", "Practice", "colPractice"  
                    Return "colPractice"
                Case "[division]", "division", "Division", "colDivision"  
                    Return "colDivision"
                Case "[facility]", "facility", "Facility", "colFacility"  
                    Return "colFacility"
                Case "[address1]", "address1", "Address1", "colAddress1"  
                    Return "colAddress1"
                Case "[city]", "city", "City", "colCity"  
                    Return "colCity"
                Case "[st_prov]", "st_prov", "StProv", "colStProv"  
                    Return "colStProv"
                Case "[country]", "country", "Country", "colCountry"  
                    Return "colCountry"
                Case "[cldbname]", "cldbname", "Cldbname", "colCldbname"  
                    Return "colCldbname"
                Case "[ReportGuid]", "ReportGuid", "ReportGuid", "colReportGuid"  
                    Return "colReportGuid"
                Case "[MetaPracticeID]", "MetaPracticeID", "MetaPracticeID", "colMetaPracticeID"  
                    Return "colMetaPracticeID"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colPDFErFilePath"
                    Return "String"
                Case "colPDFDiagramFilePath"
                    Return "String"
                Case "colClientDBRootPath"
                    Return "String"
                Case "colId"
                    Return "Integer"
                Case "colFileno"
                    Return "String"
                Case "colClientlocid"
                    Return "String"
                Case "colDocumentdate"
                    Return "DateTime"
                Case "colLinktoer"
                    Return "String"
                Case "colLinktourorlereport"
                    Return "String"
                Case "colLinktodiagram"
                    Return "String"
                Case "colPractice"
                    Return "String"
                Case "colDivision"
                    Return "String"
                Case "colFacility"
                    Return "String"
                Case "colAddress1"
                    Return "String"
                Case "colCity"
                    Return "String"
                Case "colStProv"
                    Return "String"
                Case "colCountry"
                    Return "String"
                Case "colCldbname"
                    Return "String"
                Case "colReportGuid"
                    Return "String"
                Case "colMetaPracticeID"
                    Return "Integer"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[gv].[vwLibrariesDocumentLibrarySelect]"
        End Function

        Private Function _FirstColumn() As String
            Return "[PDFErFilePath]"
        End Function

    End Class
End namespace

