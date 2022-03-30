'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblClientsroguefile
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colRogueFileId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFilePathName As New razor.UtilSQLServer.StringDataColumn
        Public colFoundInFilePrefix As New razor.UtilSQLServer.StringDataColumn
        Public colFoundInCldbName As New razor.UtilSQLServer.StringDataColumn
        Public colFoundOnDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colComments As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colRogueFileId.ColumnName = "[RogueFileId]"
            colFilePathName.ColumnName = "[FilePathName]"
            colFoundInFilePrefix.ColumnName = "[FoundInFilePrefix]"
            colFoundInCldbName.ColumnName = "[FoundInCldbName]"
            colFoundOnDate.ColumnName = "[FoundOnDate]"
            colComments.ColumnName = "[Comments]"

            _Members.Add("colRogueFileId", colRogueFileId)
            _Members.Add("colFilePathName", colFilePathName)
            _Members.Add("colFoundInFilePrefix", colFoundInFilePrefix)
            _Members.Add("colFoundInCldbName", colFoundInCldbName)
            _Members.Add("colFoundOnDate", colFoundOnDate)
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
                Case "colRogueFileId"
                    Return "[RogueFileId]"
                Case "colFilePathName"
                    Return "[FilePathName]"
                Case "colFoundInFilePrefix"
                    Return "[FoundInFilePrefix]"
                Case "colFoundInCldbName"
                    Return "[FoundInCldbName]"
                Case "colFoundOnDate"
                    Return "[FoundOnDate]"
                Case "colComments"
                    Return "[Comments]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[RogueFileId]", "RogueFileId", "RogueFileId", "colRogueFileId"  
                    Return "colRogueFileId"
                Case "[FilePathName]", "FilePathName", "FilePathName", "colFilePathName"  
                    Return "colFilePathName"
                Case "[FoundInFilePrefix]", "FoundInFilePrefix", "FoundInFilePrefix", "colFoundInFilePrefix"  
                    Return "colFoundInFilePrefix"
                Case "[FoundInCldbName]", "FoundInCldbName", "FoundInCldbName", "colFoundInCldbName"  
                    Return "colFoundInCldbName"
                Case "[FoundOnDate]", "FoundOnDate", "FoundOnDate", "colFoundOnDate"  
                    Return "colFoundOnDate"
                Case "[Comments]", "Comments", "Comments", "colComments"  
                    Return "colComments"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colRogueFileId"
                    Return "Integer"
                Case "colFilePathName"
                    Return "String"
                Case "colFoundInFilePrefix"
                    Return "String"
                Case "colFoundInCldbName"
                    Return "String"
                Case "colFoundOnDate"
                    Return "DateTime"
                Case "colComments"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[clientsroguefile]"
        End Function

        Private Function _FirstColumn() As String
            Return "[RogueFileId]"
        End Function

    End Class
End namespace

