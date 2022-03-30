'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblBatchProcessingLog
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldSetId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colFldMessage As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldId.ColumnName = "[fldId]"
            colFldSetId.ColumnName = "[fldSetId]"
            colFldDate.ColumnName = "[fldDate]"
            colFldMessage.ColumnName = "[fldMessage]"

            _Members.Add("colFldId", colFldId)
            _Members.Add("colFldSetId", colFldSetId)
            _Members.Add("colFldDate", colFldDate)
            _Members.Add("colFldMessage", colFldMessage)
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
                Case "colFldSetId"
                    Return "[fldSetId]"
                Case "colFldDate"
                    Return "[fldDate]"
                Case "colFldMessage"
                    Return "[fldMessage]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldId]", "fldId", "FldId", "colFldId"  
                    Return "colFldId"
                Case "[fldSetId]", "fldSetId", "FldSetId", "colFldSetId"  
                    Return "colFldSetId"
                Case "[fldDate]", "fldDate", "FldDate", "colFldDate"  
                    Return "colFldDate"
                Case "[fldMessage]", "fldMessage", "FldMessage", "colFldMessage"  
                    Return "colFldMessage"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldId"
                    Return "Integer"
                Case "colFldSetId"
                    Return "Integer"
                Case "colFldDate"
                    Return "DateTime"
                Case "colFldMessage"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblBatchProcessingLog]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldId]"
        End Function

    End Class
End namespace

