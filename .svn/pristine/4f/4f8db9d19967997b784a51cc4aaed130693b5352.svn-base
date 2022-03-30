'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblMetaSourceValueColor
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldSourceId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldFieldContext As New razor.UtilSQLServer.StringDataColumn
        Public colFldValue As New razor.UtilSQLServer.StringDataColumn
        Public colFldColorId As New razor.UtilSQLServer.IntegerDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldId.ColumnName = "[fldId]"
            colFldSourceId.ColumnName = "[fldSourceId]"
            colFldFieldContext.ColumnName = "[fldFieldContext]"
            colFldValue.ColumnName = "[fldValue]"
            colFldColorId.ColumnName = "[fldColorId]"

            _Members.Add("colFldId", colFldId)
            _Members.Add("colFldSourceId", colFldSourceId)
            _Members.Add("colFldFieldContext", colFldFieldContext)
            _Members.Add("colFldValue", colFldValue)
            _Members.Add("colFldColorId", colFldColorId)
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
                Case "colFldSourceId"
                    Return "[fldSourceId]"
                Case "colFldFieldContext"
                    Return "[fldFieldContext]"
                Case "colFldValue"
                    Return "[fldValue]"
                Case "colFldColorId"
                    Return "[fldColorId]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldId]", "fldId", "FldId", "colFldId"  
                    Return "colFldId"
                Case "[fldSourceId]", "fldSourceId", "FldSourceId", "colFldSourceId"  
                    Return "colFldSourceId"
                Case "[fldFieldContext]", "fldFieldContext", "FldFieldContext", "colFldFieldContext"  
                    Return "colFldFieldContext"
                Case "[fldValue]", "fldValue", "FldValue", "colFldValue"  
                    Return "colFldValue"
                Case "[fldColorId]", "fldColorId", "FldColorId", "colFldColorId"  
                    Return "colFldColorId"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldId"
                    Return "Integer"
                Case "colFldSourceId"
                    Return "Integer"
                Case "colFldFieldContext"
                    Return "String"
                Case "colFldValue"
                    Return "String"
                Case "colFldColorId"
                    Return "Integer"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblMetaSourceValueColor]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldId]"
        End Function

    End Class
End namespace

