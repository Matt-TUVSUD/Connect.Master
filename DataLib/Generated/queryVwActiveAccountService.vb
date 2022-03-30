'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryVwActiveAccountService
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldFilePrefix As New razor.UtilSQLServer.StringDataColumn
        Public colFldReportDisplayTitle As New razor.UtilSQLServer.StringDataColumn
        Public colFldPracticeGroupCode As New razor.UtilSQLServer.StringDataColumn
        Public colFldSortOrder As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldStatus As New razor.UtilSQLServer.StringDataColumn
        Public colMetaPracticeID As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldImageHtml As New razor.UtilSQLServer.StringDataColumn
        Public colFldLocationListingUrl As New razor.UtilSQLServer.StringDataColumn
        Public colFldLearnMoreUrl As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldFilePrefix.ColumnName = "[fldFilePrefix]"
            colFldReportDisplayTitle.ColumnName = "[fldReportDisplayTitle]"
            colFldPracticeGroupCode.ColumnName = "[fldPracticeGroupCode]"
            colFldSortOrder.ColumnName = "[fldSortOrder]"
            colFldStatus.ColumnName = "[fldStatus]"
            colMetaPracticeID.ColumnName = "[MetaPracticeID]"
            colFldImageHtml.ColumnName = "[fldImageHtml]"
            colFldLocationListingUrl.ColumnName = "[fldLocationListingUrl]"
            colFldLearnMoreUrl.ColumnName = "[fldLearnMoreUrl]"

            _Members.Add("colFldFilePrefix", colFldFilePrefix)
            _Members.Add("colFldReportDisplayTitle", colFldReportDisplayTitle)
            _Members.Add("colFldPracticeGroupCode", colFldPracticeGroupCode)
            _Members.Add("colFldSortOrder", colFldSortOrder)
            _Members.Add("colFldStatus", colFldStatus)
            _Members.Add("colMetaPracticeID", colMetaPracticeID)
            _Members.Add("colFldImageHtml", colFldImageHtml)
            _Members.Add("colFldLocationListingUrl", colFldLocationListingUrl)
            _Members.Add("colFldLearnMoreUrl", colFldLearnMoreUrl)
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
                Case "colFldReportDisplayTitle"
                    Return "[fldReportDisplayTitle]"
                Case "colFldPracticeGroupCode"
                    Return "[fldPracticeGroupCode]"
                Case "colFldSortOrder"
                    Return "[fldSortOrder]"
                Case "colFldStatus"
                    Return "[fldStatus]"
                Case "colMetaPracticeID"
                    Return "[MetaPracticeID]"
                Case "colFldImageHtml"
                    Return "[fldImageHtml]"
                Case "colFldLocationListingUrl"
                    Return "[fldLocationListingUrl]"
                Case "colFldLearnMoreUrl"
                    Return "[fldLearnMoreUrl]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldFilePrefix]", "fldFilePrefix", "FldFilePrefix", "colFldFilePrefix"  
                    Return "colFldFilePrefix"
                Case "[fldReportDisplayTitle]", "fldReportDisplayTitle", "FldReportDisplayTitle", "colFldReportDisplayTitle"  
                    Return "colFldReportDisplayTitle"
                Case "[fldPracticeGroupCode]", "fldPracticeGroupCode", "FldPracticeGroupCode", "colFldPracticeGroupCode"  
                    Return "colFldPracticeGroupCode"
                Case "[fldSortOrder]", "fldSortOrder", "FldSortOrder", "colFldSortOrder"  
                    Return "colFldSortOrder"
                Case "[fldStatus]", "fldStatus", "FldStatus", "colFldStatus"  
                    Return "colFldStatus"
                Case "[MetaPracticeID]", "MetaPracticeID", "MetaPracticeID", "colMetaPracticeID"  
                    Return "colMetaPracticeID"
                Case "[fldImageHtml]", "fldImageHtml", "FldImageHtml", "colFldImageHtml"  
                    Return "colFldImageHtml"
                Case "[fldLocationListingUrl]", "fldLocationListingUrl", "FldLocationListingUrl", "colFldLocationListingUrl"  
                    Return "colFldLocationListingUrl"
                Case "[fldLearnMoreUrl]", "fldLearnMoreUrl", "FldLearnMoreUrl", "colFldLearnMoreUrl"  
                    Return "colFldLearnMoreUrl"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldFilePrefix"
                    Return "String"
                Case "colFldReportDisplayTitle"
                    Return "String"
                Case "colFldPracticeGroupCode"
                    Return "String"
                Case "colFldSortOrder"
                    Return "Integer"
                Case "colFldStatus"
                    Return "String"
                Case "colMetaPracticeID"
                    Return "Integer"
                Case "colFldImageHtml"
                    Return "String"
                Case "colFldLocationListingUrl"
                    Return "String"
                Case "colFldLearnMoreUrl"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[vwActiveAccountService]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldFilePrefix]"
        End Function

    End Class
End namespace

