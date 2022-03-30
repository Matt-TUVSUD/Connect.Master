'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblMetaColorAlias
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldColorId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldAlias As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldId.ColumnName = "[fldId]"
            colFldColorId.ColumnName = "[fldColorId]"
            colFldAlias.ColumnName = "[fldAlias]"

            _Members.Add("colFldId", colFldId)
            _Members.Add("colFldColorId", colFldColorId)
            _Members.Add("colFldAlias", colFldAlias)
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
                Case "colFldColorId"
                    Return "[fldColorId]"
                Case "colFldAlias"
                    Return "[fldAlias]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldId]", "fldId", "FldId", "colFldId"  
                    Return "colFldId"
                Case "[fldColorId]", "fldColorId", "FldColorId", "colFldColorId"  
                    Return "colFldColorId"
                Case "[fldAlias]", "fldAlias", "FldAlias", "colFldAlias"  
                    Return "colFldAlias"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldId"
                    Return "Integer"
                Case "colFldColorId"
                    Return "Integer"
                Case "colFldAlias"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblMetaColorAlias]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldId]"
        End Function

    End Class
End namespace

