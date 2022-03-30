'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblMetaPractice
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldName As New razor.UtilSQLServer.StringDataColumn
        Public colFldReportDisplayTitle As New razor.UtilSQLServer.StringDataColumn
        Public colFldIsHazard As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldFilterValue As New razor.UtilSQLServer.StringDataColumn
        Public colFldPracticeCode As New razor.UtilSQLServer.StringDataColumn
        Public colFldPracticeGroupCode As New razor.UtilSQLServer.StringDataColumn
        Public colFldSortOrder As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldPracticeLetter As New razor.UtilSQLServer.StringDataColumn
        Public colFldShortName As New razor.UtilSQLServer.StringDataColumn
        Public colFldPracticeNameText As New razor.UtilSQLServer.StringDataColumn
        Public colFldPracticeNameHTML As New razor.UtilSQLServer.StringDataColumn
        Public colFldNavLinkAllReportsKeyword As New razor.UtilSQLServer.StringDataColumn
        Public colFldImageHtml As New razor.UtilSQLServer.StringDataColumn
        Public colFldLocationListingUrl As New razor.UtilSQLServer.StringDataColumn
        Public colFldLearnMoreUrl As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldId.ColumnName = "[fldId]"
            colFldName.ColumnName = "[fldName]"
            colFldReportDisplayTitle.ColumnName = "[fldReportDisplayTitle]"
            colFldIsHazard.ColumnName = "[fldIsHazard]"
            colFldFilterValue.ColumnName = "[fldFilterValue]"
            colFldPracticeCode.ColumnName = "[fldPracticeCode]"
            colFldPracticeGroupCode.ColumnName = "[fldPracticeGroupCode]"
            colFldSortOrder.ColumnName = "[fldSortOrder]"
            colFldPracticeLetter.ColumnName = "[fldPracticeLetter]"
            colFldShortName.ColumnName = "[fldShortName]"
            colFldPracticeNameText.ColumnName = "[fldPracticeNameText]"
            colFldPracticeNameHTML.ColumnName = "[fldPracticeNameHTML]"
            colFldNavLinkAllReportsKeyword.ColumnName = "[fldNavLinkAllReportsKeyword]"
            colFldImageHtml.ColumnName = "[fldImageHtml]"
            colFldLocationListingUrl.ColumnName = "[fldLocationListingUrl]"
            colFldLearnMoreUrl.ColumnName = "[fldLearnMoreUrl]"

            _Members.Add("colFldId", colFldId)
            _Members.Add("colFldName", colFldName)
            _Members.Add("colFldReportDisplayTitle", colFldReportDisplayTitle)
            _Members.Add("colFldIsHazard", colFldIsHazard)
            _Members.Add("colFldFilterValue", colFldFilterValue)
            _Members.Add("colFldPracticeCode", colFldPracticeCode)
            _Members.Add("colFldPracticeGroupCode", colFldPracticeGroupCode)
            _Members.Add("colFldSortOrder", colFldSortOrder)
            _Members.Add("colFldPracticeLetter", colFldPracticeLetter)
            _Members.Add("colFldShortName", colFldShortName)
            _Members.Add("colFldPracticeNameText", colFldPracticeNameText)
            _Members.Add("colFldPracticeNameHTML", colFldPracticeNameHTML)
            _Members.Add("colFldNavLinkAllReportsKeyword", colFldNavLinkAllReportsKeyword)
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
                Case "colFldId"
                    Return "[fldId]"
                Case "colFldName"
                    Return "[fldName]"
                Case "colFldReportDisplayTitle"
                    Return "[fldReportDisplayTitle]"
                Case "colFldIsHazard"
                    Return "[fldIsHazard]"
                Case "colFldFilterValue"
                    Return "[fldFilterValue]"
                Case "colFldPracticeCode"
                    Return "[fldPracticeCode]"
                Case "colFldPracticeGroupCode"
                    Return "[fldPracticeGroupCode]"
                Case "colFldSortOrder"
                    Return "[fldSortOrder]"
                Case "colFldPracticeLetter"
                    Return "[fldPracticeLetter]"
                Case "colFldShortName"
                    Return "[fldShortName]"
                Case "colFldPracticeNameText"
                    Return "[fldPracticeNameText]"
                Case "colFldPracticeNameHTML"
                    Return "[fldPracticeNameHTML]"
                Case "colFldNavLinkAllReportsKeyword"
                    Return "[fldNavLinkAllReportsKeyword]"
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
                Case "[fldId]", "fldId", "FldId", "colFldId"  
                    Return "colFldId"
                Case "[fldName]", "fldName", "FldName", "colFldName"  
                    Return "colFldName"
                Case "[fldReportDisplayTitle]", "fldReportDisplayTitle", "FldReportDisplayTitle", "colFldReportDisplayTitle"  
                    Return "colFldReportDisplayTitle"
                Case "[fldIsHazard]", "fldIsHazard", "FldIsHazard", "colFldIsHazard"  
                    Return "colFldIsHazard"
                Case "[fldFilterValue]", "fldFilterValue", "FldFilterValue", "colFldFilterValue"  
                    Return "colFldFilterValue"
                Case "[fldPracticeCode]", "fldPracticeCode", "FldPracticeCode", "colFldPracticeCode"  
                    Return "colFldPracticeCode"
                Case "[fldPracticeGroupCode]", "fldPracticeGroupCode", "FldPracticeGroupCode", "colFldPracticeGroupCode"  
                    Return "colFldPracticeGroupCode"
                Case "[fldSortOrder]", "fldSortOrder", "FldSortOrder", "colFldSortOrder"  
                    Return "colFldSortOrder"
                Case "[fldPracticeLetter]", "fldPracticeLetter", "FldPracticeLetter", "colFldPracticeLetter"  
                    Return "colFldPracticeLetter"
                Case "[fldShortName]", "fldShortName", "FldShortName", "colFldShortName"  
                    Return "colFldShortName"
                Case "[fldPracticeNameText]", "fldPracticeNameText", "FldPracticeNameText", "colFldPracticeNameText"  
                    Return "colFldPracticeNameText"
                Case "[fldPracticeNameHTML]", "fldPracticeNameHTML", "FldPracticeNameHTML", "colFldPracticeNameHTML"  
                    Return "colFldPracticeNameHTML"
                Case "[fldNavLinkAllReportsKeyword]", "fldNavLinkAllReportsKeyword", "FldNavLinkAllReportsKeyword", "colFldNavLinkAllReportsKeyword"  
                    Return "colFldNavLinkAllReportsKeyword"
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
                Case "colFldId"
                    Return "Integer"
                Case "colFldName"
                    Return "String"
                Case "colFldReportDisplayTitle"
                    Return "String"
                Case "colFldIsHazard"
                    Return "Boolean"
                Case "colFldFilterValue"
                    Return "String"
                Case "colFldPracticeCode"
                    Return "String"
                Case "colFldPracticeGroupCode"
                    Return "String"
                Case "colFldSortOrder"
                    Return "Integer"
                Case "colFldPracticeLetter"
                    Return "String"
                Case "colFldShortName"
                    Return "String"
                Case "colFldPracticeNameText"
                    Return "String"
                Case "colFldPracticeNameHTML"
                    Return "String"
                Case "colFldNavLinkAllReportsKeyword"
                    Return "String"
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
            Return "[dbo].[tblMetaPractice]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldId]"
        End Function

    End Class
End namespace

