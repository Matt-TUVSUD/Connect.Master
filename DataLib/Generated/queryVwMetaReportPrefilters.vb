'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryVwMetaReportPrefilters
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colRptCode As New razor.UtilSQLServer.IntegerDataColumn
        Public colEnumValue As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldName As New razor.UtilSQLServer.StringDataColumn
        Public colFldFieldName As New razor.UtilSQLServer.StringDataColumn
        Public colFldAllowWildcardValue As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldParameterKindId As New razor.UtilSQLServer.IntegerDataColumn
        Public colParameterKindName As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colRptCode.ColumnName = "[RptCode]"
            colEnumValue.ColumnName = "[EnumValue]"
            colFldName.ColumnName = "[fldName]"
            colFldFieldName.ColumnName = "[fldFieldName]"
            colFldAllowWildcardValue.ColumnName = "[fldAllowWildcardValue]"
            colFldParameterKindId.ColumnName = "[fldParameterKindId]"
            colParameterKindName.ColumnName = "[ParameterKindName]"

            _Members.Add("colRptCode", colRptCode)
            _Members.Add("colEnumValue", colEnumValue)
            _Members.Add("colFldName", colFldName)
            _Members.Add("colFldFieldName", colFldFieldName)
            _Members.Add("colFldAllowWildcardValue", colFldAllowWildcardValue)
            _Members.Add("colFldParameterKindId", colFldParameterKindId)
            _Members.Add("colParameterKindName", colParameterKindName)
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
                Case "colRptCode"
                    Return "[RptCode]"
                Case "colEnumValue"
                    Return "[EnumValue]"
                Case "colFldName"
                    Return "[fldName]"
                Case "colFldFieldName"
                    Return "[fldFieldName]"
                Case "colFldAllowWildcardValue"
                    Return "[fldAllowWildcardValue]"
                Case "colFldParameterKindId"
                    Return "[fldParameterKindId]"
                Case "colParameterKindName"
                    Return "[ParameterKindName]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[RptCode]", "RptCode", "RptCode", "colRptCode"  
                    Return "colRptCode"
                Case "[EnumValue]", "EnumValue", "EnumValue", "colEnumValue"  
                    Return "colEnumValue"
                Case "[fldName]", "fldName", "FldName", "colFldName"  
                    Return "colFldName"
                Case "[fldFieldName]", "fldFieldName", "FldFieldName", "colFldFieldName"  
                    Return "colFldFieldName"
                Case "[fldAllowWildcardValue]", "fldAllowWildcardValue", "FldAllowWildcardValue", "colFldAllowWildcardValue"  
                    Return "colFldAllowWildcardValue"
                Case "[fldParameterKindId]", "fldParameterKindId", "FldParameterKindId", "colFldParameterKindId"  
                    Return "colFldParameterKindId"
                Case "[ParameterKindName]", "ParameterKindName", "ParameterKindName", "colParameterKindName"  
                    Return "colParameterKindName"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colRptCode"
                    Return "Integer"
                Case "colEnumValue"
                    Return "Integer"
                Case "colFldName"
                    Return "String"
                Case "colFldFieldName"
                    Return "String"
                Case "colFldAllowWildcardValue"
                    Return "Boolean"
                Case "colFldParameterKindId"
                    Return "Integer"
                Case "colParameterKindName"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[rv].[vwMetaReportPrefilters]"
        End Function

        Private Function _FirstColumn() As String
            Return "[RptCode]"
        End Function

    End Class
End namespace

