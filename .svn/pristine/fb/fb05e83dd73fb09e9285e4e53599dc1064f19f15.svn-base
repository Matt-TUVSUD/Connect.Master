'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblBatchProcessingSetItem
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldSetId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldMetaObjectId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldStatusId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldException As New razor.UtilSQLServer.StringDataColumn
        Public colExtendedPropJSON As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldId.ColumnName = "[fldId]"
            colFldSetId.ColumnName = "[fldSetId]"
            colFldMetaObjectId.ColumnName = "[fldMetaObjectId]"
            colFldStatusId.ColumnName = "[fldStatusId]"
            colFldException.ColumnName = "[fldException]"
            colExtendedPropJSON.ColumnName = "[ExtendedPropJSON]"

            _Members.Add("colFldId", colFldId)
            _Members.Add("colFldSetId", colFldSetId)
            _Members.Add("colFldMetaObjectId", colFldMetaObjectId)
            _Members.Add("colFldStatusId", colFldStatusId)
            _Members.Add("colFldException", colFldException)
            _Members.Add("colExtendedPropJSON", colExtendedPropJSON)
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
                Case "colFldMetaObjectId"
                    Return "[fldMetaObjectId]"
                Case "colFldStatusId"
                    Return "[fldStatusId]"
                Case "colFldException"
                    Return "[fldException]"
                Case "colExtendedPropJSON"
                    Return "[ExtendedPropJSON]"
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
                Case "[fldMetaObjectId]", "fldMetaObjectId", "FldMetaObjectId", "colFldMetaObjectId"  
                    Return "colFldMetaObjectId"
                Case "[fldStatusId]", "fldStatusId", "FldStatusId", "colFldStatusId"  
                    Return "colFldStatusId"
                Case "[fldException]", "fldException", "FldException", "colFldException"  
                    Return "colFldException"
                Case "[ExtendedPropJSON]", "ExtendedPropJSON", "ExtendedPropJSON", "colExtendedPropJSON"  
                    Return "colExtendedPropJSON"
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
                Case "colFldMetaObjectId"
                    Return "Integer"
                Case "colFldStatusId"
                    Return "Integer"
                Case "colFldException"
                    Return "String"
                Case "colExtendedPropJSON"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblBatchProcessingSetItem]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldId]"
        End Function

    End Class
End namespace

