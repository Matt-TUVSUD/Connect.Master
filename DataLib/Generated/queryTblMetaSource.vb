'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblMetaSource
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldSchemaName As New razor.UtilSQLServer.StringDataColumn
        Public colFldObjectName As New razor.UtilSQLServer.StringDataColumn
        Public colFldOrderBy As New razor.UtilSQLServer.StringDataColumn
        Public colFldJoinFieldName As New razor.UtilSQLServer.StringDataColumn
        Public colFldIsJoinRequired As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldHasCurrencyParm As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldHasUnitParm As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldHasFileNoParm As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldHasFilePrefixParm As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldType As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldHasDivisionParm As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldHasCountryParm As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldHasCustomAccessParm As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldObjectId As New razor.UtilSQLServer.LongDataColumn
        Public colFldParameterFlag As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldHasLanguageParm As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldHasImpStartDateParm As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldHasImpEndDateParm As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldHasInspProgramYearParm As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldHasTIVParm As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldHasRecStatusParm As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldHasHazardParm As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldHasTIVValueParm As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldHasAutoRequestParm As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldComment As New razor.UtilSQLServer.StringDataColumn
        Public colFldUniqueFieldName As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldId.ColumnName = "[fldId]"
            colFldSchemaName.ColumnName = "[fldSchemaName]"
            colFldObjectName.ColumnName = "[fldObjectName]"
            colFldOrderBy.ColumnName = "[fldOrderBy]"
            colFldJoinFieldName.ColumnName = "[fldJoinFieldName]"
            colFldIsJoinRequired.ColumnName = "[fldIsJoinRequired]"
            colFldHasCurrencyParm.ColumnName = "[fldHasCurrencyParm]"
            colFldHasUnitParm.ColumnName = "[fldHasUnitParm]"
            colFldHasFileNoParm.ColumnName = "[fldHasFileNoParm]"
            colFldHasFilePrefixParm.ColumnName = "[fldHasFilePrefixParm]"
            colFldType.ColumnName = "[fldType]"
            colFldHasDivisionParm.ColumnName = "[fldHasDivisionParm]"
            colFldHasCountryParm.ColumnName = "[fldHasCountryParm]"
            colFldHasCustomAccessParm.ColumnName = "[fldHasCustomAccessParm]"
            colFldObjectId.ColumnName = "[fldObjectId]"
            colFldParameterFlag.ColumnName = "[fldParameterFlag]"
            colFldHasLanguageParm.ColumnName = "[fldHasLanguageParm]"
            colFldHasImpStartDateParm.ColumnName = "[fldHasImpStartDateParm]"
            colFldHasImpEndDateParm.ColumnName = "[fldHasImpEndDateParm]"
            colFldHasInspProgramYearParm.ColumnName = "[fldHasInspProgramYearParm]"
            colFldHasTIVParm.ColumnName = "[fldHasTIVParm]"
            colFldHasRecStatusParm.ColumnName = "[fldHasRecStatusParm]"
            colFldHasHazardParm.ColumnName = "[fldHasHazardParm]"
            colFldHasTIVValueParm.ColumnName = "[fldHasTIVValueParm]"
            colFldHasAutoRequestParm.ColumnName = "[fldHasAutoRequestParm]"
            colFldComment.ColumnName = "[fldComment]"
            colFldUniqueFieldName.ColumnName = "[fldUniqueFieldName]"

            _Members.Add("colFldId", colFldId)
            _Members.Add("colFldSchemaName", colFldSchemaName)
            _Members.Add("colFldObjectName", colFldObjectName)
            _Members.Add("colFldOrderBy", colFldOrderBy)
            _Members.Add("colFldJoinFieldName", colFldJoinFieldName)
            _Members.Add("colFldIsJoinRequired", colFldIsJoinRequired)
            _Members.Add("colFldHasCurrencyParm", colFldHasCurrencyParm)
            _Members.Add("colFldHasUnitParm", colFldHasUnitParm)
            _Members.Add("colFldHasFileNoParm", colFldHasFileNoParm)
            _Members.Add("colFldHasFilePrefixParm", colFldHasFilePrefixParm)
            _Members.Add("colFldType", colFldType)
            _Members.Add("colFldHasDivisionParm", colFldHasDivisionParm)
            _Members.Add("colFldHasCountryParm", colFldHasCountryParm)
            _Members.Add("colFldHasCustomAccessParm", colFldHasCustomAccessParm)
            _Members.Add("colFldObjectId", colFldObjectId)
            _Members.Add("colFldParameterFlag", colFldParameterFlag)
            _Members.Add("colFldHasLanguageParm", colFldHasLanguageParm)
            _Members.Add("colFldHasImpStartDateParm", colFldHasImpStartDateParm)
            _Members.Add("colFldHasImpEndDateParm", colFldHasImpEndDateParm)
            _Members.Add("colFldHasInspProgramYearParm", colFldHasInspProgramYearParm)
            _Members.Add("colFldHasTIVParm", colFldHasTIVParm)
            _Members.Add("colFldHasRecStatusParm", colFldHasRecStatusParm)
            _Members.Add("colFldHasHazardParm", colFldHasHazardParm)
            _Members.Add("colFldHasTIVValueParm", colFldHasTIVValueParm)
            _Members.Add("colFldHasAutoRequestParm", colFldHasAutoRequestParm)
            _Members.Add("colFldComment", colFldComment)
            _Members.Add("colFldUniqueFieldName", colFldUniqueFieldName)
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
                Case "colFldSchemaName"
                    Return "[fldSchemaName]"
                Case "colFldObjectName"
                    Return "[fldObjectName]"
                Case "colFldOrderBy"
                    Return "[fldOrderBy]"
                Case "colFldJoinFieldName"
                    Return "[fldJoinFieldName]"
                Case "colFldIsJoinRequired"
                    Return "[fldIsJoinRequired]"
                Case "colFldHasCurrencyParm"
                    Return "[fldHasCurrencyParm]"
                Case "colFldHasUnitParm"
                    Return "[fldHasUnitParm]"
                Case "colFldHasFileNoParm"
                    Return "[fldHasFileNoParm]"
                Case "colFldHasFilePrefixParm"
                    Return "[fldHasFilePrefixParm]"
                Case "colFldType"
                    Return "[fldType]"
                Case "colFldHasDivisionParm"
                    Return "[fldHasDivisionParm]"
                Case "colFldHasCountryParm"
                    Return "[fldHasCountryParm]"
                Case "colFldHasCustomAccessParm"
                    Return "[fldHasCustomAccessParm]"
                Case "colFldObjectId"
                    Return "[fldObjectId]"
                Case "colFldParameterFlag"
                    Return "[fldParameterFlag]"
                Case "colFldHasLanguageParm"
                    Return "[fldHasLanguageParm]"
                Case "colFldHasImpStartDateParm"
                    Return "[fldHasImpStartDateParm]"
                Case "colFldHasImpEndDateParm"
                    Return "[fldHasImpEndDateParm]"
                Case "colFldHasInspProgramYearParm"
                    Return "[fldHasInspProgramYearParm]"
                Case "colFldHasTIVParm"
                    Return "[fldHasTIVParm]"
                Case "colFldHasRecStatusParm"
                    Return "[fldHasRecStatusParm]"
                Case "colFldHasHazardParm"
                    Return "[fldHasHazardParm]"
                Case "colFldHasTIVValueParm"
                    Return "[fldHasTIVValueParm]"
                Case "colFldHasAutoRequestParm"
                    Return "[fldHasAutoRequestParm]"
                Case "colFldComment"
                    Return "[fldComment]"
                Case "colFldUniqueFieldName"
                    Return "[fldUniqueFieldName]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldId]", "fldId", "FldId", "colFldId"  
                    Return "colFldId"
                Case "[fldSchemaName]", "fldSchemaName", "FldSchemaName", "colFldSchemaName"  
                    Return "colFldSchemaName"
                Case "[fldObjectName]", "fldObjectName", "FldObjectName", "colFldObjectName"  
                    Return "colFldObjectName"
                Case "[fldOrderBy]", "fldOrderBy", "FldOrderBy", "colFldOrderBy"  
                    Return "colFldOrderBy"
                Case "[fldJoinFieldName]", "fldJoinFieldName", "FldJoinFieldName", "colFldJoinFieldName"  
                    Return "colFldJoinFieldName"
                Case "[fldIsJoinRequired]", "fldIsJoinRequired", "FldIsJoinRequired", "colFldIsJoinRequired"  
                    Return "colFldIsJoinRequired"
                Case "[fldHasCurrencyParm]", "fldHasCurrencyParm", "FldHasCurrencyParm", "colFldHasCurrencyParm"  
                    Return "colFldHasCurrencyParm"
                Case "[fldHasUnitParm]", "fldHasUnitParm", "FldHasUnitParm", "colFldHasUnitParm"  
                    Return "colFldHasUnitParm"
                Case "[fldHasFileNoParm]", "fldHasFileNoParm", "FldHasFileNoParm", "colFldHasFileNoParm"  
                    Return "colFldHasFileNoParm"
                Case "[fldHasFilePrefixParm]", "fldHasFilePrefixParm", "FldHasFilePrefixParm", "colFldHasFilePrefixParm"  
                    Return "colFldHasFilePrefixParm"
                Case "[fldType]", "fldType", "FldType", "colFldType"  
                    Return "colFldType"
                Case "[fldHasDivisionParm]", "fldHasDivisionParm", "FldHasDivisionParm", "colFldHasDivisionParm"  
                    Return "colFldHasDivisionParm"
                Case "[fldHasCountryParm]", "fldHasCountryParm", "FldHasCountryParm", "colFldHasCountryParm"  
                    Return "colFldHasCountryParm"
                Case "[fldHasCustomAccessParm]", "fldHasCustomAccessParm", "FldHasCustomAccessParm", "colFldHasCustomAccessParm"  
                    Return "colFldHasCustomAccessParm"
                Case "[fldObjectId]", "fldObjectId", "FldObjectId", "colFldObjectId"  
                    Return "colFldObjectId"
                Case "[fldParameterFlag]", "fldParameterFlag", "FldParameterFlag", "colFldParameterFlag"  
                    Return "colFldParameterFlag"
                Case "[fldHasLanguageParm]", "fldHasLanguageParm", "FldHasLanguageParm", "colFldHasLanguageParm"  
                    Return "colFldHasLanguageParm"
                Case "[fldHasImpStartDateParm]", "fldHasImpStartDateParm", "FldHasImpStartDateParm", "colFldHasImpStartDateParm"  
                    Return "colFldHasImpStartDateParm"
                Case "[fldHasImpEndDateParm]", "fldHasImpEndDateParm", "FldHasImpEndDateParm", "colFldHasImpEndDateParm"  
                    Return "colFldHasImpEndDateParm"
                Case "[fldHasInspProgramYearParm]", "fldHasInspProgramYearParm", "FldHasInspProgramYearParm", "colFldHasInspProgramYearParm"  
                    Return "colFldHasInspProgramYearParm"
                Case "[fldHasTIVParm]", "fldHasTIVParm", "FldHasTIVParm", "colFldHasTIVParm"  
                    Return "colFldHasTIVParm"
                Case "[fldHasRecStatusParm]", "fldHasRecStatusParm", "FldHasRecStatusParm", "colFldHasRecStatusParm"  
                    Return "colFldHasRecStatusParm"
                Case "[fldHasHazardParm]", "fldHasHazardParm", "FldHasHazardParm", "colFldHasHazardParm"  
                    Return "colFldHasHazardParm"
                Case "[fldHasTIVValueParm]", "fldHasTIVValueParm", "FldHasTIVValueParm", "colFldHasTIVValueParm"  
                    Return "colFldHasTIVValueParm"
                Case "[fldHasAutoRequestParm]", "fldHasAutoRequestParm", "FldHasAutoRequestParm", "colFldHasAutoRequestParm"  
                    Return "colFldHasAutoRequestParm"
                Case "[fldComment]", "fldComment", "FldComment", "colFldComment"  
                    Return "colFldComment"
                Case "[fldUniqueFieldName]", "fldUniqueFieldName", "FldUniqueFieldName", "colFldUniqueFieldName"  
                    Return "colFldUniqueFieldName"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldId"
                    Return "Integer"
                Case "colFldSchemaName"
                    Return "String"
                Case "colFldObjectName"
                    Return "String"
                Case "colFldOrderBy"
                    Return "String"
                Case "colFldJoinFieldName"
                    Return "String"
                Case "colFldIsJoinRequired"
                    Return "Boolean"
                Case "colFldHasCurrencyParm"
                    Return "Boolean"
                Case "colFldHasUnitParm"
                    Return "Boolean"
                Case "colFldHasFileNoParm"
                    Return "Boolean"
                Case "colFldHasFilePrefixParm"
                    Return "Boolean"
                Case "colFldType"
                    Return "Integer"
                Case "colFldHasDivisionParm"
                    Return "Boolean"
                Case "colFldHasCountryParm"
                    Return "Boolean"
                Case "colFldHasCustomAccessParm"
                    Return "Boolean"
                Case "colFldObjectId"
                    Return "Long"
                Case "colFldParameterFlag"
                    Return "Integer"
                Case "colFldHasLanguageParm"
                    Return "Boolean"
                Case "colFldHasImpStartDateParm"
                    Return "Boolean"
                Case "colFldHasImpEndDateParm"
                    Return "Boolean"
                Case "colFldHasInspProgramYearParm"
                    Return "Boolean"
                Case "colFldHasTIVParm"
                    Return "Boolean"
                Case "colFldHasRecStatusParm"
                    Return "Boolean"
                Case "colFldHasHazardParm"
                    Return "Boolean"
                Case "colFldHasTIVValueParm"
                    Return "Boolean"
                Case "colFldHasAutoRequestParm"
                    Return "Boolean"
                Case "colFldComment"
                    Return "String"
                Case "colFldUniqueFieldName"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblMetaSource]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldId]"
        End Function

    End Class
End namespace

