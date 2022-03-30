'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblMetaSourceParameter
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldSourceid As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldParameterId As New razor.UtilSQLServer.IntegerDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldSourceid.ColumnName = "[fldSourceid]"
            colFldParameterId.ColumnName = "[fldParameterId]"

            _Members.Add("colFldSourceid", colFldSourceid)
            _Members.Add("colFldParameterId", colFldParameterId)
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
                Case "colFldSourceid"
                    Return "[fldSourceid]"
                Case "colFldParameterId"
                    Return "[fldParameterId]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldSourceid]", "fldSourceid", "FldSourceid", "colFldSourceid"  
                    Return "colFldSourceid"
                Case "[fldParameterId]", "fldParameterId", "FldParameterId", "colFldParameterId"  
                    Return "colFldParameterId"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldSourceid"
                    Return "Integer"
                Case "colFldParameterId"
                    Return "Integer"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblMetaSourceParameter]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldSourceid]"
        End Function

    End Class
End namespace

