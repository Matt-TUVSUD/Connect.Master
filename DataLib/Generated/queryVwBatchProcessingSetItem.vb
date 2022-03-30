'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryVwBatchProcessingSetItem
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldSetId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldName As New razor.UtilSQLServer.StringDataColumn
        Public colFldStatus As New razor.UtilSQLServer.StringDataColumn
        Public colFldGroupName As New razor.UtilSQLServer.StringDataColumn
        Public colFldMessage As New razor.UtilSQLServer.StringDataColumn
        Public colFldStack As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldId.ColumnName = "[fldId]"
            colFldSetId.ColumnName = "[fldSetId]"
            colFldName.ColumnName = "[fldName]"
            colFldStatus.ColumnName = "[fldStatus]"
            colFldGroupName.ColumnName = "[fldGroupName]"
            colFldMessage.ColumnName = "[fldMessage]"
            colFldStack.ColumnName = "[fldStack]"

            _Members.Add("colFldId", colFldId)
            _Members.Add("colFldSetId", colFldSetId)
            _Members.Add("colFldName", colFldName)
            _Members.Add("colFldStatus", colFldStatus)
            _Members.Add("colFldGroupName", colFldGroupName)
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
                Case "colFldName"
                    Return "[fldName]"
                Case "colFldStatus"
                    Return "[fldStatus]"
                Case "colFldGroupName"
                    Return "[fldGroupName]"
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
                Case "[fldName]", "fldName", "FldName", "colFldName"  
                    Return "colFldName"
                Case "[fldStatus]", "fldStatus", "FldStatus", "colFldStatus"  
                    Return "colFldStatus"
                Case "[fldGroupName]", "fldGroupName", "FldGroupName", "colFldGroupName"  
                    Return "colFldGroupName"
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
                Case "colFldName"
                    Return "String"
                Case "colFldStatus"
                    Return "String"
                Case "colFldGroupName"
                    Return "String"
                Case "colFldMessage"
                    Return "String"
                Case "colFldStack"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[fv].[vwBatchProcessingSetItem]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldId]"
        End Function

    End Class
End namespace

