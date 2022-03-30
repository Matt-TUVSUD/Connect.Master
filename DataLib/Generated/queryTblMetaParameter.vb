'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblMetaParameter
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldName As New razor.UtilSQLServer.StringDataColumn
        Public colFldType As New razor.UtilSQLServer.StringDataColumn
        Public colFldAllowWildcardValue As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldParameterKindId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldFieldName As New razor.UtilSQLServer.StringDataColumn
        Public colFldFlagId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldIsVirtual As New razor.UtilSQLServer.BooleanDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldId.ColumnName = "[fldId]"
            colFldName.ColumnName = "[fldName]"
            colFldType.ColumnName = "[fldType]"
            colFldAllowWildcardValue.ColumnName = "[fldAllowWildcardValue]"
            colFldParameterKindId.ColumnName = "[fldParameterKindId]"
            colFldFieldName.ColumnName = "[fldFieldName]"
            colFldFlagId.ColumnName = "[fldFlagId]"
            colFldIsVirtual.ColumnName = "[fldIsVirtual]"

            _Members.Add("colFldId", colFldId)
            _Members.Add("colFldName", colFldName)
            _Members.Add("colFldType", colFldType)
            _Members.Add("colFldAllowWildcardValue", colFldAllowWildcardValue)
            _Members.Add("colFldParameterKindId", colFldParameterKindId)
            _Members.Add("colFldFieldName", colFldFieldName)
            _Members.Add("colFldFlagId", colFldFlagId)
            _Members.Add("colFldIsVirtual", colFldIsVirtual)
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
                Case "colFldType"
                    Return "[fldType]"
                Case "colFldAllowWildcardValue"
                    Return "[fldAllowWildcardValue]"
                Case "colFldParameterKindId"
                    Return "[fldParameterKindId]"
                Case "colFldFieldName"
                    Return "[fldFieldName]"
                Case "colFldFlagId"
                    Return "[fldFlagId]"
                Case "colFldIsVirtual"
                    Return "[fldIsVirtual]"
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
                Case "[fldType]", "fldType", "FldType", "colFldType"  
                    Return "colFldType"
                Case "[fldAllowWildcardValue]", "fldAllowWildcardValue", "FldAllowWildcardValue", "colFldAllowWildcardValue"  
                    Return "colFldAllowWildcardValue"
                Case "[fldParameterKindId]", "fldParameterKindId", "FldParameterKindId", "colFldParameterKindId"  
                    Return "colFldParameterKindId"
                Case "[fldFieldName]", "fldFieldName", "FldFieldName", "colFldFieldName"  
                    Return "colFldFieldName"
                Case "[fldFlagId]", "fldFlagId", "FldFlagId", "colFldFlagId"  
                    Return "colFldFlagId"
                Case "[fldIsVirtual]", "fldIsVirtual", "FldIsVirtual", "colFldIsVirtual"  
                    Return "colFldIsVirtual"
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
                Case "colFldType"
                    Return "String"
                Case "colFldAllowWildcardValue"
                    Return "Boolean"
                Case "colFldParameterKindId"
                    Return "Integer"
                Case "colFldFieldName"
                    Return "String"
                Case "colFldFlagId"
                    Return "Integer"
                Case "colFldIsVirtual"
                    Return "Boolean"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblMetaParameter]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldId]"
        End Function

    End Class
End namespace

