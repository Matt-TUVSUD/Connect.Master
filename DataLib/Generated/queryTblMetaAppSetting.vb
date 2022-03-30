'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblMetaAppSetting
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldKey As New razor.UtilSQLServer.StringDataColumn
        Public colFldDevValue As New razor.UtilSQLServer.StringDataColumn
        Public colFldTestValue As New razor.UtilSQLServer.StringDataColumn
        Public colFldLiveValue As New razor.UtilSQLServer.StringDataColumn
        Public colFldDefaultValue As New razor.UtilSQLServer.StringDataColumn
        Public colFldDevVSValue As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldKey.ColumnName = "[fldKey]"
            colFldDevValue.ColumnName = "[fldDevValue]"
            colFldTestValue.ColumnName = "[fldTestValue]"
            colFldLiveValue.ColumnName = "[fldLiveValue]"
            colFldDefaultValue.ColumnName = "[fldDefaultValue]"
            colFldDevVSValue.ColumnName = "[fldDevVSValue]"

            _Members.Add("colFldKey", colFldKey)
            _Members.Add("colFldDevValue", colFldDevValue)
            _Members.Add("colFldTestValue", colFldTestValue)
            _Members.Add("colFldLiveValue", colFldLiveValue)
            _Members.Add("colFldDefaultValue", colFldDefaultValue)
            _Members.Add("colFldDevVSValue", colFldDevVSValue)
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
                Case "colFldKey"
                    Return "[fldKey]"
                Case "colFldDevValue"
                    Return "[fldDevValue]"
                Case "colFldTestValue"
                    Return "[fldTestValue]"
                Case "colFldLiveValue"
                    Return "[fldLiveValue]"
                Case "colFldDefaultValue"
                    Return "[fldDefaultValue]"
                Case "colFldDevVSValue"
                    Return "[fldDevVSValue]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldKey]", "fldKey", "FldKey", "colFldKey"  
                    Return "colFldKey"
                Case "[fldDevValue]", "fldDevValue", "FldDevValue", "colFldDevValue"  
                    Return "colFldDevValue"
                Case "[fldTestValue]", "fldTestValue", "FldTestValue", "colFldTestValue"  
                    Return "colFldTestValue"
                Case "[fldLiveValue]", "fldLiveValue", "FldLiveValue", "colFldLiveValue"  
                    Return "colFldLiveValue"
                Case "[fldDefaultValue]", "fldDefaultValue", "FldDefaultValue", "colFldDefaultValue"  
                    Return "colFldDefaultValue"
                Case "[fldDevVSValue]", "fldDevVSValue", "FldDevVSValue", "colFldDevVSValue"  
                    Return "colFldDevVSValue"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldKey"
                    Return "String"
                Case "colFldDevValue"
                    Return "String"
                Case "colFldTestValue"
                    Return "String"
                Case "colFldLiveValue"
                    Return "String"
                Case "colFldDefaultValue"
                    Return "String"
                Case "colFldDevVSValue"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblMetaAppSetting]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldKey]"
        End Function

    End Class
End namespace

