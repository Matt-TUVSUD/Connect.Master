'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblBatchProcessingEmail
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldTo As New razor.UtilSQLServer.StringDataColumn
        Public colFldCc As New razor.UtilSQLServer.StringDataColumn
        Public colFldBcc As New razor.UtilSQLServer.StringDataColumn
        Public colFldSubject As New razor.UtilSQLServer.StringDataColumn
        Public colFldBody As New razor.UtilSQLServer.StringDataColumn
        Public colFldSentDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colFldHasException As New razor.UtilSQLServer.BooleanDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldId.ColumnName = "[fldId]"
            colFldTo.ColumnName = "[fldTo]"
            colFldCc.ColumnName = "[fldCc]"
            colFldBcc.ColumnName = "[fldBcc]"
            colFldSubject.ColumnName = "[fldSubject]"
            colFldBody.ColumnName = "[fldBody]"
            colFldSentDate.ColumnName = "[fldSentDate]"
            colFldHasException.ColumnName = "[fldHasException]"

            _Members.Add("colFldId", colFldId)
            _Members.Add("colFldTo", colFldTo)
            _Members.Add("colFldCc", colFldCc)
            _Members.Add("colFldBcc", colFldBcc)
            _Members.Add("colFldSubject", colFldSubject)
            _Members.Add("colFldBody", colFldBody)
            _Members.Add("colFldSentDate", colFldSentDate)
            _Members.Add("colFldHasException", colFldHasException)
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
                Case "colFldTo"
                    Return "[fldTo]"
                Case "colFldCc"
                    Return "[fldCc]"
                Case "colFldBcc"
                    Return "[fldBcc]"
                Case "colFldSubject"
                    Return "[fldSubject]"
                Case "colFldBody"
                    Return "[fldBody]"
                Case "colFldSentDate"
                    Return "[fldSentDate]"
                Case "colFldHasException"
                    Return "[fldHasException]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldId]", "fldId", "FldId", "colFldId"  
                    Return "colFldId"
                Case "[fldTo]", "fldTo", "FldTo", "colFldTo"  
                    Return "colFldTo"
                Case "[fldCc]", "fldCc", "FldCc", "colFldCc"  
                    Return "colFldCc"
                Case "[fldBcc]", "fldBcc", "FldBcc", "colFldBcc"  
                    Return "colFldBcc"
                Case "[fldSubject]", "fldSubject", "FldSubject", "colFldSubject"  
                    Return "colFldSubject"
                Case "[fldBody]", "fldBody", "FldBody", "colFldBody"  
                    Return "colFldBody"
                Case "[fldSentDate]", "fldSentDate", "FldSentDate", "colFldSentDate"  
                    Return "colFldSentDate"
                Case "[fldHasException]", "fldHasException", "FldHasException", "colFldHasException"  
                    Return "colFldHasException"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldId"
                    Return "Integer"
                Case "colFldTo"
                    Return "String"
                Case "colFldCc"
                    Return "String"
                Case "colFldBcc"
                    Return "String"
                Case "colFldSubject"
                    Return "String"
                Case "colFldBody"
                    Return "String"
                Case "colFldSentDate"
                    Return "DateTime"
                Case "colFldHasException"
                    Return "Boolean"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblBatchProcessingEmail]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldId]"
        End Function

    End Class
End namespace

