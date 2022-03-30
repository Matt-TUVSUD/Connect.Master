'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblMetaContextTerm
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldContext As New razor.UtilSQLServer.StringDataColumn
        Public colFldTerm As New razor.UtilSQLServer.StringDataColumn
        Public colFldAbbreviation As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldId.ColumnName = "[fldId]"
            colFldContext.ColumnName = "[fldContext]"
            colFldTerm.ColumnName = "[fldTerm]"
            colFldAbbreviation.ColumnName = "[fldAbbreviation]"

            _Members.Add("colFldId", colFldId)
            _Members.Add("colFldContext", colFldContext)
            _Members.Add("colFldTerm", colFldTerm)
            _Members.Add("colFldAbbreviation", colFldAbbreviation)
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
                Case "colFldContext"
                    Return "[fldContext]"
                Case "colFldTerm"
                    Return "[fldTerm]"
                Case "colFldAbbreviation"
                    Return "[fldAbbreviation]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldId]", "fldId", "FldId", "colFldId"  
                    Return "colFldId"
                Case "[fldContext]", "fldContext", "FldContext", "colFldContext"  
                    Return "colFldContext"
                Case "[fldTerm]", "fldTerm", "FldTerm", "colFldTerm"  
                    Return "colFldTerm"
                Case "[fldAbbreviation]", "fldAbbreviation", "FldAbbreviation", "colFldAbbreviation"  
                    Return "colFldAbbreviation"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldId"
                    Return "Integer"
                Case "colFldContext"
                    Return "String"
                Case "colFldTerm"
                    Return "String"
                Case "colFldAbbreviation"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblMetaContextTerm]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldId]"
        End Function

    End Class
End namespace

