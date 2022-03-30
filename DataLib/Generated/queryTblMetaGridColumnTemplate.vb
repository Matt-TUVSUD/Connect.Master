'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblMetaGridColumnTemplate
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldTemplateName As New razor.UtilSQLServer.StringDataColumn
        Public colFldTemplateSource As New razor.UtilSQLServer.StringDataColumn
        Public colFldNotes As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldId.ColumnName = "[fldId]"
            colFldTemplateName.ColumnName = "[fldTemplateName]"
            colFldTemplateSource.ColumnName = "[fldTemplateSource]"
            colFldNotes.ColumnName = "[fldNotes]"

            _Members.Add("colFldId", colFldId)
            _Members.Add("colFldTemplateName", colFldTemplateName)
            _Members.Add("colFldTemplateSource", colFldTemplateSource)
            _Members.Add("colFldNotes", colFldNotes)
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
                Case "colFldTemplateName"
                    Return "[fldTemplateName]"
                Case "colFldTemplateSource"
                    Return "[fldTemplateSource]"
                Case "colFldNotes"
                    Return "[fldNotes]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldId]", "fldId", "FldId", "colFldId"  
                    Return "colFldId"
                Case "[fldTemplateName]", "fldTemplateName", "FldTemplateName", "colFldTemplateName"  
                    Return "colFldTemplateName"
                Case "[fldTemplateSource]", "fldTemplateSource", "FldTemplateSource", "colFldTemplateSource"  
                    Return "colFldTemplateSource"
                Case "[fldNotes]", "fldNotes", "FldNotes", "colFldNotes"  
                    Return "colFldNotes"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldId"
                    Return "Integer"
                Case "colFldTemplateName"
                    Return "String"
                Case "colFldTemplateSource"
                    Return "String"
                Case "colFldNotes"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblMetaGridColumnTemplate]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldId]"
        End Function

    End Class
End namespace

