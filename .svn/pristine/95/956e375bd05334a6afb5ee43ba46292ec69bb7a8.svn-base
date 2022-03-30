'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblBatchProcessingException
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldSetId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldSetItemId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldMessage As New razor.UtilSQLServer.StringDataColumn
        Public colFldStack As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldId.ColumnName = "[fldId]"
            colFldSetId.ColumnName = "[fldSetId]"
            colFldSetItemId.ColumnName = "[fldSetItemId]"
            colFldMessage.ColumnName = "[fldMessage]"
            colFldStack.ColumnName = "[fldStack]"

            _Members.Add("colFldId", colFldId)
            _Members.Add("colFldSetId", colFldSetId)
            _Members.Add("colFldSetItemId", colFldSetItemId)
            _Members.Add("colFldMessage", colFldMessage)
            _Members.Add("colFldStack", colFldStack)
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
                Case "colFldSetItemId"
                    Return "[fldSetItemId]"
                Case "colFldMessage"
                    Return "[fldMessage]"
                Case "colFldStack"
                    Return "[fldStack]"
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
                Case "[fldSetItemId]", "fldSetItemId", "FldSetItemId", "colFldSetItemId"  
                    Return "colFldSetItemId"
                Case "[fldMessage]", "fldMessage", "FldMessage", "colFldMessage"  
                    Return "colFldMessage"
                Case "[fldStack]", "fldStack", "FldStack", "colFldStack"  
                    Return "colFldStack"
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
                Case "colFldSetItemId"
                    Return "Integer"
                Case "colFldMessage"
                    Return "String"
                Case "colFldStack"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblBatchProcessingException]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldId]"
        End Function

    End Class
End namespace

