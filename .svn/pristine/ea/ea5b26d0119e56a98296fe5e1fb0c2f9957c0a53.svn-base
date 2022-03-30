'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblBatchProcessingEmailSet
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldEmailId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldSetId As New razor.UtilSQLServer.IntegerDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldEmailId.ColumnName = "[fldEmailId]"
            colFldSetId.ColumnName = "[fldSetId]"

            _Members.Add("colFldEmailId", colFldEmailId)
            _Members.Add("colFldSetId", colFldSetId)
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
                Case "colFldEmailId"
                    Return "[fldEmailId]"
                Case "colFldSetId"
                    Return "[fldSetId]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldEmailId]", "fldEmailId", "FldEmailId", "colFldEmailId"  
                    Return "colFldEmailId"
                Case "[fldSetId]", "fldSetId", "FldSetId", "colFldSetId"  
                    Return "colFldSetId"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldEmailId"
                    Return "Integer"
                Case "colFldSetId"
                    Return "Integer"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblBatchProcessingEmailSet]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldEmailId]"
        End Function

    End Class
End namespace

