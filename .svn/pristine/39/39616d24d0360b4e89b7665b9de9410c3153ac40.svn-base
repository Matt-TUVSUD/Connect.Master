'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblClientsfileprefixspec
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colCldbname As New razor.UtilSQLServer.StringDataColumn
        Public colFilePrefixSpec As New razor.UtilSQLServer.StringDataColumn
        Public colComments As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colCldbname.ColumnName = "[cldbname]"
            colFilePrefixSpec.ColumnName = "[FilePrefixSpec]"
            colComments.ColumnName = "[Comments]"

            _Members.Add("colCldbname", colCldbname)
            _Members.Add("colFilePrefixSpec", colFilePrefixSpec)
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
                Case "colCldbname"
                    Return "[cldbname]"
                Case "colFilePrefixSpec"
                    Return "[FilePrefixSpec]"
                Case "colComments"
                    Return "[Comments]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[cldbname]", "cldbname", "Cldbname", "colCldbname"  
                    Return "colCldbname"
                Case "[FilePrefixSpec]", "FilePrefixSpec", "FilePrefixSpec", "colFilePrefixSpec"  
                    Return "colFilePrefixSpec"
                Case "[Comments]", "Comments", "Comments", "colComments"  
                    Return "colComments"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colCldbname"
                    Return "String"
                Case "colFilePrefixSpec"
                    Return "String"
                Case "colComments"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[clientsfileprefixspec]"
        End Function

        Private Function _FirstColumn() As String
            Return "[cldbname]"
        End Function

    End Class
End namespace

