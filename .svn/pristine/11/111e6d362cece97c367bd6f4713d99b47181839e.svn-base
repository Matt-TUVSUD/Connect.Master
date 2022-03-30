'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblClientsskipdatafolder
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colExcludeClientFolderId As New razor.UtilSQLServer.IntegerDataColumn
        Public colCldbname As New razor.UtilSQLServer.StringDataColumn
        Public colExcludeFolderName As New razor.UtilSQLServer.StringDataColumn
        Public colComments As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colExcludeClientFolderId.ColumnName = "[ExcludeClientFolderId]"
            colCldbname.ColumnName = "[cldbname]"
            colExcludeFolderName.ColumnName = "[ExcludeFolderName]"
            colComments.ColumnName = "[Comments]"

            _Members.Add("colExcludeClientFolderId", colExcludeClientFolderId)
            _Members.Add("colCldbname", colCldbname)
            _Members.Add("colExcludeFolderName", colExcludeFolderName)
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
                Case "colExcludeClientFolderId"
                    Return "[ExcludeClientFolderId]"
                Case "colCldbname"
                    Return "[cldbname]"
                Case "colExcludeFolderName"
                    Return "[ExcludeFolderName]"
                Case "colComments"
                    Return "[Comments]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[ExcludeClientFolderId]", "ExcludeClientFolderId", "ExcludeClientFolderId", "colExcludeClientFolderId"  
                    Return "colExcludeClientFolderId"
                Case "[cldbname]", "cldbname", "Cldbname", "colCldbname"  
                    Return "colCldbname"
                Case "[ExcludeFolderName]", "ExcludeFolderName", "ExcludeFolderName", "colExcludeFolderName"  
                    Return "colExcludeFolderName"
                Case "[Comments]", "Comments", "Comments", "colComments"  
                    Return "colComments"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colExcludeClientFolderId"
                    Return "Integer"
                Case "colCldbname"
                    Return "String"
                Case "colExcludeFolderName"
                    Return "String"
                Case "colComments"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[clientsskipdatafolder]"
        End Function

        Private Function _FirstColumn() As String
            Return "[ExcludeClientFolderId]"
        End Function

    End Class
End namespace

