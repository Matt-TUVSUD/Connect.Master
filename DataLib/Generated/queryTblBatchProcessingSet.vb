'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblBatchProcessingSet
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldCreateDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colFldFilePrefix As New razor.UtilSQLServer.StringDataColumn
        Public colFldSetTypeID As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldFileName As New razor.UtilSQLServer.StringDataColumn
        Public colFldStatusId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldDisable As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldLOFilterJSON As New razor.UtilSQLServer.StringDataColumn
        Public colFldLOCriteriaJSON As New razor.UtilSQLServer.StringDataColumn
        Public colFldLOSortJSON As New razor.UtilSQLServer.StringDataColumn
        Public colFldLOSettingJSON As New razor.UtilSQLServer.StringDataColumn
        Public colFldMetaParameterJSON As New razor.UtilSQLServer.StringDataColumn
        Public colFldCreatedByGsafeId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldIsInteractive As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldIsMyBatchReport As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldCreatedByGsafeUserEmail As New razor.UtilSQLServer.StringDataColumn
        Public colFldLOMyPreferenceJSON As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldId.ColumnName = "[fldId]"
            colFldCreateDate.ColumnName = "[fldCreateDate]"
            colFldFilePrefix.ColumnName = "[fldFilePrefix]"
            colFldSetTypeID.ColumnName = "[fldSetTypeID]"
            colFldFileName.ColumnName = "[fldFileName]"
            colFldStatusId.ColumnName = "[fldStatusId]"
            colFldDisable.ColumnName = "[fldDisable]"
            colFldLOFilterJSON.ColumnName = "[fldLOFilterJSON]"
            colFldLOCriteriaJSON.ColumnName = "[fldLOCriteriaJSON]"
            colFldLOSortJSON.ColumnName = "[fldLOSortJSON]"
            colFldLOSettingJSON.ColumnName = "[fldLOSettingJSON]"
            colFldMetaParameterJSON.ColumnName = "[fldMetaParameterJSON]"
            colFldCreatedByGsafeId.ColumnName = "[fldCreatedByGsafeId]"
            colFldIsInteractive.ColumnName = "[fldIsInteractive]"
            colFldIsMyBatchReport.ColumnName = "[fldIsMyBatchReport]"
            colFldCreatedByGsafeUserEmail.ColumnName = "[fldCreatedByGsafeUserEmail]"
            colFldLOMyPreferenceJSON.ColumnName = "[fldLOMyPreferenceJSON]"

            _Members.Add("colFldId", colFldId)
            _Members.Add("colFldCreateDate", colFldCreateDate)
            _Members.Add("colFldFilePrefix", colFldFilePrefix)
            _Members.Add("colFldSetTypeID", colFldSetTypeID)
            _Members.Add("colFldFileName", colFldFileName)
            _Members.Add("colFldStatusId", colFldStatusId)
            _Members.Add("colFldDisable", colFldDisable)
            _Members.Add("colFldLOFilterJSON", colFldLOFilterJSON)
            _Members.Add("colFldLOCriteriaJSON", colFldLOCriteriaJSON)
            _Members.Add("colFldLOSortJSON", colFldLOSortJSON)
            _Members.Add("colFldLOSettingJSON", colFldLOSettingJSON)
            _Members.Add("colFldMetaParameterJSON", colFldMetaParameterJSON)
            _Members.Add("colFldCreatedByGsafeId", colFldCreatedByGsafeId)
            _Members.Add("colFldIsInteractive", colFldIsInteractive)
            _Members.Add("colFldIsMyBatchReport", colFldIsMyBatchReport)
            _Members.Add("colFldCreatedByGsafeUserEmail", colFldCreatedByGsafeUserEmail)
            _Members.Add("colFldLOMyPreferenceJSON", colFldLOMyPreferenceJSON)
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
                Case "colFldSetTypeID"
                    Return "[fldSetTypeID]"
                Case "colFldFileName"
                    Return "[fldFileName]"
                Case "colFldStatusId"
                    Return "[fldStatusId]"
                Case "colFldDisable"
                    Return "[fldDisable]"
                Case "colFldLOFilterJSON"
                    Return "[fldLOFilterJSON]"
                Case "colFldLOCriteriaJSON"
                    Return "[fldLOCriteriaJSON]"
                Case "colFldLOSortJSON"
                    Return "[fldLOSortJSON]"
                Case "colFldLOSettingJSON"
                    Return "[fldLOSettingJSON]"
                Case "colFldMetaParameterJSON"
                    Return "[fldMetaParameterJSON]"
                Case "colFldCreatedByGsafeId"
                    Return "[fldCreatedByGsafeId]"
                Case "colFldIsInteractive"
                    Return "[fldIsInteractive]"
                Case "colFldIsMyBatchReport"
                    Return "[fldIsMyBatchReport]"
                Case "colFldCreatedByGsafeUserEmail"
                    Return "[fldCreatedByGsafeUserEmail]"
                Case "colFldLOMyPreferenceJSON"
                    Return "[fldLOMyPreferenceJSON]"
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
                Case "[fldSetTypeID]", "fldSetTypeID", "FldSetTypeID", "colFldSetTypeID"  
                    Return "colFldSetTypeID"
                Case "[fldFileName]", "fldFileName", "FldFileName", "colFldFileName"  
                    Return "colFldFileName"
                Case "[fldStatusId]", "fldStatusId", "FldStatusId", "colFldStatusId"  
                    Return "colFldStatusId"
                Case "[fldDisable]", "fldDisable", "FldDisable", "colFldDisable"  
                    Return "colFldDisable"
                Case "[fldLOFilterJSON]", "fldLOFilterJSON", "FldLOFilterJSON", "colFldLOFilterJSON"  
                    Return "colFldLOFilterJSON"
                Case "[fldLOCriteriaJSON]", "fldLOCriteriaJSON", "FldLOCriteriaJSON", "colFldLOCriteriaJSON"  
                    Return "colFldLOCriteriaJSON"
                Case "[fldLOSortJSON]", "fldLOSortJSON", "FldLOSortJSON", "colFldLOSortJSON"  
                    Return "colFldLOSortJSON"
                Case "[fldLOSettingJSON]", "fldLOSettingJSON", "FldLOSettingJSON", "colFldLOSettingJSON"  
                    Return "colFldLOSettingJSON"
                Case "[fldMetaParameterJSON]", "fldMetaParameterJSON", "FldMetaParameterJSON", "colFldMetaParameterJSON"  
                    Return "colFldMetaParameterJSON"
                Case "[fldCreatedByGsafeId]", "fldCreatedByGsafeId", "FldCreatedByGsafeId", "colFldCreatedByGsafeId"  
                    Return "colFldCreatedByGsafeId"
                Case "[fldIsInteractive]", "fldIsInteractive", "FldIsInteractive", "colFldIsInteractive"  
                    Return "colFldIsInteractive"
                Case "[fldIsMyBatchReport]", "fldIsMyBatchReport", "FldIsMyBatchReport", "colFldIsMyBatchReport"  
                    Return "colFldIsMyBatchReport"
                Case "[fldCreatedByGsafeUserEmail]", "fldCreatedByGsafeUserEmail", "FldCreatedByGsafeUserEmail", "colFldCreatedByGsafeUserEmail"  
                    Return "colFldCreatedByGsafeUserEmail"
                Case "[fldLOMyPreferenceJSON]", "fldLOMyPreferenceJSON", "FldLOMyPreferenceJSON", "colFldLOMyPreferenceJSON"  
                    Return "colFldLOMyPreferenceJSON"
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
                Case "colFldSetTypeID"
                    Return "Integer"
                Case "colFldFileName"
                    Return "String"
                Case "colFldStatusId"
                    Return "Integer"
                Case "colFldDisable"
                    Return "Boolean"
                Case "colFldLOFilterJSON"
                    Return "String"
                Case "colFldLOCriteriaJSON"
                    Return "String"
                Case "colFldLOSortJSON"
                    Return "String"
                Case "colFldLOSettingJSON"
                    Return "String"
                Case "colFldMetaParameterJSON"
                    Return "String"
                Case "colFldCreatedByGsafeId"
                    Return "Integer"
                Case "colFldIsInteractive"
                    Return "Boolean"
                Case "colFldIsMyBatchReport"
                    Return "Boolean"
                Case "colFldCreatedByGsafeUserEmail"
                    Return "String"
                Case "colFldLOMyPreferenceJSON"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblBatchProcessingSet]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldId]"
        End Function

    End Class
End namespace

