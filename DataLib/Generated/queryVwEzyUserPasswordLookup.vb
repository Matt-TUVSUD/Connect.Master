'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryVwEzyUserPasswordLookup
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colEmail As New razor.UtilSQLServer.StringDataColumn
        Public colPassword As New razor.UtilSQLServer.StringDataColumn
        Public colImport As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colEmail.ColumnName = "[Email]"
            colPassword.ColumnName = "[Password]"
            colImport.ColumnName = "[Import]"

            _Members.Add("colEmail", colEmail)
            _Members.Add("colPassword", colPassword)
            _Members.Add("colImport", colImport)
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
                Case "colEmail"
                    Return "[Email]"
                Case "colPassword"
                    Return "[Password]"
                Case "colImport"
                    Return "[Import]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[Email]", "Email", "Email", "colEmail"  
                    Return "colEmail"
                Case "[Password]", "Password", "Password", "colPassword"  
                    Return "colPassword"
                Case "[Import]", "Import", "Import", "colImport"  
                    Return "colImport"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colEmail"
                    Return "String"
                Case "colPassword"
                    Return "String"
                Case "colImport"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[vwEzyUserPasswordLookup]"
        End Function

        Private Function _FirstColumn() As String
            Return "[Email]"
        End Function

    End Class
End namespace

