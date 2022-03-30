'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblWhatsNew
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colId As New razor.UtilSQLServer.IntegerDataColumn
        Public colTitle As New razor.UtilSQLServer.StringDataColumn
        Public colPostDate As New razor.UtilSQLServer.DateDataColumn
        Public colComments As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colId.ColumnName = "[ID]"
            colTitle.ColumnName = "[Title]"
            colPostDate.ColumnName = "[PostDate]"
            colComments.ColumnName = "[Comments]"

            _Members.Add("colId", colId)
            _Members.Add("colTitle", colTitle)
            _Members.Add("colPostDate", colPostDate)
            _Members.Add("colComments", colComments)
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
                Case "colId"
                    Return "[ID]"
                Case "colTitle"
                    Return "[Title]"
                Case "colPostDate"
                    Return "[PostDate]"
                Case "colComments"
                    Return "[Comments]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[ID]", "ID", "Id", "colId"  
                    Return "colId"
                Case "[Title]", "Title", "Title", "colTitle"  
                    Return "colTitle"
                Case "[PostDate]", "PostDate", "PostDate", "colPostDate"  
                    Return "colPostDate"
                Case "[Comments]", "Comments", "Comments", "colComments"  
                    Return "colComments"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colId"
                    Return "Integer"
                Case "colTitle"
                    Return "String"
                Case "colPostDate"
                    Return "Date"
                Case "colComments"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblWhatsNew]"
        End Function

        Private Function _FirstColumn() As String
            Return "[ID]"
        End Function

    End Class
End namespace

