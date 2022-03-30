'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblMetaKey
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldKeyName As New razor.UtilSQLServer.StringDataColumn
        Public colFldKeyValue As New razor.UtilSQLServer.IntegerDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldId.ColumnName = "[fldId]"
            colFldKeyName.ColumnName = "[fldKeyName]"
            colFldKeyValue.ColumnName = "[fldKeyValue]"

            _Members.Add("colFldId", colFldId)
            _Members.Add("colFldKeyName", colFldKeyName)
            _Members.Add("colFldKeyValue", colFldKeyValue)
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
                Case "colFldKeyName"
                    Return "[fldKeyName]"
                Case "colFldKeyValue"
                    Return "[fldKeyValue]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldId]", "fldId", "FldId", "colFldId"  
                    Return "colFldId"
                Case "[fldKeyName]", "fldKeyName", "FldKeyName", "colFldKeyName"  
                    Return "colFldKeyName"
                Case "[fldKeyValue]", "fldKeyValue", "FldKeyValue", "colFldKeyValue"  
                    Return "colFldKeyValue"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldId"
                    Return "Integer"
                Case "colFldKeyName"
                    Return "String"
                Case "colFldKeyValue"
                    Return "Integer"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblMetaKey]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldId]"
        End Function

    End Class
End namespace

