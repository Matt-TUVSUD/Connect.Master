'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblAdminViewXLColumn
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldID As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldAdminXLSheetID As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldDataMember As New razor.UtilSQLServer.StringDataColumn
        Public colFdlHyperLinkMember As New razor.UtilSQLServer.StringDataColumn
        Public colFldHeaderText As New razor.UtilSQLServer.StringDataColumn
        Public colFldColumnPosition As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldInclude As New razor.UtilSQLServer.BooleanDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldID.ColumnName = "[fldID]"
            colFldAdminXLSheetID.ColumnName = "[fldAdminXLSheetID]"
            colFldDataMember.ColumnName = "[fldDataMember]"
            colFdlHyperLinkMember.ColumnName = "[fdlHyperLinkMember]"
            colFldHeaderText.ColumnName = "[fldHeaderText]"
            colFldColumnPosition.ColumnName = "[fldColumnPosition]"
            colFldInclude.ColumnName = "[fldInclude]"

            _Members.Add("colFldID", colFldID)
            _Members.Add("colFldAdminXLSheetID", colFldAdminXLSheetID)
            _Members.Add("colFldDataMember", colFldDataMember)
            _Members.Add("colFdlHyperLinkMember", colFdlHyperLinkMember)
            _Members.Add("colFldHeaderText", colFldHeaderText)
            _Members.Add("colFldColumnPosition", colFldColumnPosition)
            _Members.Add("colFldInclude", colFldInclude)
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
                Case "colFldID"
                    Return "[fldID]"
                Case "colFldAdminXLSheetID"
                    Return "[fldAdminXLSheetID]"
                Case "colFldDataMember"
                    Return "[fldDataMember]"
                Case "colFdlHyperLinkMember"
                    Return "[fdlHyperLinkMember]"
                Case "colFldHeaderText"
                    Return "[fldHeaderText]"
                Case "colFldColumnPosition"
                    Return "[fldColumnPosition]"
                Case "colFldInclude"
                    Return "[fldInclude]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldID]", "fldID", "FldID", "colFldID"  
                    Return "colFldID"
                Case "[fldAdminXLSheetID]", "fldAdminXLSheetID", "FldAdminXLSheetID", "colFldAdminXLSheetID"  
                    Return "colFldAdminXLSheetID"
                Case "[fldDataMember]", "fldDataMember", "FldDataMember", "colFldDataMember"  
                    Return "colFldDataMember"
                Case "[fdlHyperLinkMember]", "fdlHyperLinkMember", "FdlHyperLinkMember", "colFdlHyperLinkMember"  
                    Return "colFdlHyperLinkMember"
                Case "[fldHeaderText]", "fldHeaderText", "FldHeaderText", "colFldHeaderText"  
                    Return "colFldHeaderText"
                Case "[fldColumnPosition]", "fldColumnPosition", "FldColumnPosition", "colFldColumnPosition"  
                    Return "colFldColumnPosition"
                Case "[fldInclude]", "fldInclude", "FldInclude", "colFldInclude"  
                    Return "colFldInclude"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldID"
                    Return "Integer"
                Case "colFldAdminXLSheetID"
                    Return "Integer"
                Case "colFldDataMember"
                    Return "String"
                Case "colFdlHyperLinkMember"
                    Return "String"
                Case "colFldHeaderText"
                    Return "String"
                Case "colFldColumnPosition"
                    Return "Integer"
                Case "colFldInclude"
                    Return "Boolean"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[adm].[tblAdminViewXLColumn]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldID]"
        End Function

    End Class
End namespace

