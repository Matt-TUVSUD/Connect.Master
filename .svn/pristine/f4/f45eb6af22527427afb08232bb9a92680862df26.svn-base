'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblMetaGrid
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldGridName As New razor.UtilSQLServer.StringDataColumn
        Public colFldKeyField As New razor.UtilSQLServer.StringDataColumn
        Public colFldGridPageTitle As New razor.UtilSQLServer.StringDataColumn
        Public colFldGridPageSubTitle As New razor.UtilSQLServer.StringDataColumn
        Public colFldGridPractice As New razor.UtilSQLServer.StringDataColumn
        Public colFldFileName As New razor.UtilSQLServer.StringDataColumn
        Public colFldSourceId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldReportId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldFormViewTemplateName As New razor.UtilSQLServer.StringDataColumn
        Public colFldInstructions As New razor.UtilSQLServer.StringDataColumn
        Public colFldLegacyFavoritesGridID As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldReport2Id As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldComment As New razor.UtilSQLServer.StringDataColumn
        Public colFldFormViewReportId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldMapShowPinText As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldMetaPracticeId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldExtractHeaderRowHeight As New razor.UtilSQLServer.DecimalDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldId.ColumnName = "[fldId]"
            colFldGridName.ColumnName = "[fldGridName]"
            colFldKeyField.ColumnName = "[fldKeyField]"
            colFldGridPageTitle.ColumnName = "[fldGridPageTitle]"
            colFldGridPageSubTitle.ColumnName = "[fldGridPageSubTitle]"
            colFldGridPractice.ColumnName = "[fldGridPractice]"
            colFldFileName.ColumnName = "[fldFileName]"
            colFldSourceId.ColumnName = "[fldSourceId]"
            colFldReportId.ColumnName = "[fldReportId]"
            colFldFormViewTemplateName.ColumnName = "[fldFormViewTemplateName]"
            colFldInstructions.ColumnName = "[fldInstructions]"
            colFldLegacyFavoritesGridID.ColumnName = "[fldLegacyFavoritesGridID]"
            colFldReport2Id.ColumnName = "[fldReport2Id]"
            colFldComment.ColumnName = "[fldComment]"
            colFldFormViewReportId.ColumnName = "[fldFormViewReportId]"
            colFldMapShowPinText.ColumnName = "[fldMapShowPinText]"
            colFldMetaPracticeId.ColumnName = "[fldMetaPracticeId]"
            colFldExtractHeaderRowHeight.ColumnName = "[fldExtractHeaderRowHeight]"

            _Members.Add("colFldId", colFldId)
            _Members.Add("colFldGridName", colFldGridName)
            _Members.Add("colFldKeyField", colFldKeyField)
            _Members.Add("colFldGridPageTitle", colFldGridPageTitle)
            _Members.Add("colFldGridPageSubTitle", colFldGridPageSubTitle)
            _Members.Add("colFldGridPractice", colFldGridPractice)
            _Members.Add("colFldFileName", colFldFileName)
            _Members.Add("colFldSourceId", colFldSourceId)
            _Members.Add("colFldReportId", colFldReportId)
            _Members.Add("colFldFormViewTemplateName", colFldFormViewTemplateName)
            _Members.Add("colFldInstructions", colFldInstructions)
            _Members.Add("colFldLegacyFavoritesGridID", colFldLegacyFavoritesGridID)
            _Members.Add("colFldReport2Id", colFldReport2Id)
            _Members.Add("colFldComment", colFldComment)
            _Members.Add("colFldFormViewReportId", colFldFormViewReportId)
            _Members.Add("colFldMapShowPinText", colFldMapShowPinText)
            _Members.Add("colFldMetaPracticeId", colFldMetaPracticeId)
            _Members.Add("colFldExtractHeaderRowHeight", colFldExtractHeaderRowHeight)
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
                Case "colFldGridName"
                    Return "[fldGridName]"
                Case "colFldKeyField"
                    Return "[fldKeyField]"
                Case "colFldGridPageTitle"
                    Return "[fldGridPageTitle]"
                Case "colFldGridPageSubTitle"
                    Return "[fldGridPageSubTitle]"
                Case "colFldGridPractice"
                    Return "[fldGridPractice]"
                Case "colFldFileName"
                    Return "[fldFileName]"
                Case "colFldSourceId"
                    Return "[fldSourceId]"
                Case "colFldReportId"
                    Return "[fldReportId]"
                Case "colFldFormViewTemplateName"
                    Return "[fldFormViewTemplateName]"
                Case "colFldInstructions"
                    Return "[fldInstructions]"
                Case "colFldLegacyFavoritesGridID"
                    Return "[fldLegacyFavoritesGridID]"
                Case "colFldReport2Id"
                    Return "[fldReport2Id]"
                Case "colFldComment"
                    Return "[fldComment]"
                Case "colFldFormViewReportId"
                    Return "[fldFormViewReportId]"
                Case "colFldMapShowPinText"
                    Return "[fldMapShowPinText]"
                Case "colFldMetaPracticeId"
                    Return "[fldMetaPracticeId]"
                Case "colFldExtractHeaderRowHeight"
                    Return "[fldExtractHeaderRowHeight]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldId]", "fldId", "FldId", "colFldId"  
                    Return "colFldId"
                Case "[fldGridName]", "fldGridName", "FldGridName", "colFldGridName"  
                    Return "colFldGridName"
                Case "[fldKeyField]", "fldKeyField", "FldKeyField", "colFldKeyField"  
                    Return "colFldKeyField"
                Case "[fldGridPageTitle]", "fldGridPageTitle", "FldGridPageTitle", "colFldGridPageTitle"  
                    Return "colFldGridPageTitle"
                Case "[fldGridPageSubTitle]", "fldGridPageSubTitle", "FldGridPageSubTitle", "colFldGridPageSubTitle"  
                    Return "colFldGridPageSubTitle"
                Case "[fldGridPractice]", "fldGridPractice", "FldGridPractice", "colFldGridPractice"  
                    Return "colFldGridPractice"
                Case "[fldFileName]", "fldFileName", "FldFileName", "colFldFileName"  
                    Return "colFldFileName"
                Case "[fldSourceId]", "fldSourceId", "FldSourceId", "colFldSourceId"  
                    Return "colFldSourceId"
                Case "[fldReportId]", "fldReportId", "FldReportId", "colFldReportId"  
                    Return "colFldReportId"
                Case "[fldFormViewTemplateName]", "fldFormViewTemplateName", "FldFormViewTemplateName", "colFldFormViewTemplateName"  
                    Return "colFldFormViewTemplateName"
                Case "[fldInstructions]", "fldInstructions", "FldInstructions", "colFldInstructions"  
                    Return "colFldInstructions"
                Case "[fldLegacyFavoritesGridID]", "fldLegacyFavoritesGridID", "FldLegacyFavoritesGridID", "colFldLegacyFavoritesGridID"  
                    Return "colFldLegacyFavoritesGridID"
                Case "[fldReport2Id]", "fldReport2Id", "FldReport2Id", "colFldReport2Id"  
                    Return "colFldReport2Id"
                Case "[fldComment]", "fldComment", "FldComment", "colFldComment"  
                    Return "colFldComment"
                Case "[fldFormViewReportId]", "fldFormViewReportId", "FldFormViewReportId", "colFldFormViewReportId"  
                    Return "colFldFormViewReportId"
                Case "[fldMapShowPinText]", "fldMapShowPinText", "FldMapShowPinText", "colFldMapShowPinText"  
                    Return "colFldMapShowPinText"
                Case "[fldMetaPracticeId]", "fldMetaPracticeId", "FldMetaPracticeId", "colFldMetaPracticeId"  
                    Return "colFldMetaPracticeId"
                Case "[fldExtractHeaderRowHeight]", "fldExtractHeaderRowHeight", "FldExtractHeaderRowHeight", "colFldExtractHeaderRowHeight"  
                    Return "colFldExtractHeaderRowHeight"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldId"
                    Return "Integer"
                Case "colFldGridName"
                    Return "String"
                Case "colFldKeyField"
                    Return "String"
                Case "colFldGridPageTitle"
                    Return "String"
                Case "colFldGridPageSubTitle"
                    Return "String"
                Case "colFldGridPractice"
                    Return "String"
                Case "colFldFileName"
                    Return "String"
                Case "colFldSourceId"
                    Return "Integer"
                Case "colFldReportId"
                    Return "Integer"
                Case "colFldFormViewTemplateName"
                    Return "String"
                Case "colFldInstructions"
                    Return "String"
                Case "colFldLegacyFavoritesGridID"
                    Return "Integer"
                Case "colFldReport2Id"
                    Return "Integer"
                Case "colFldComment"
                    Return "String"
                Case "colFldFormViewReportId"
                    Return "Integer"
                Case "colFldMapShowPinText"
                    Return "Boolean"
                Case "colFldMetaPracticeId"
                    Return "Integer"
                Case "colFldExtractHeaderRowHeight"
                    Return "Decimal"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblMetaGrid]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldId]"
        End Function

    End Class
End namespace

