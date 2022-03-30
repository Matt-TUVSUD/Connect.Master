'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblEzyLoginactivitylog
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colId As New razor.UtilSQLServer.IntegerDataColumn
        Public colLoginID As New razor.UtilSQLServer.IntegerDataColumn
        Public colLastLoginDateTime As New razor.UtilSQLServer.DateTimeDataColumn
        Public colLastActivityDateTime As New razor.UtilSQLServer.DateTimeDataColumn
        Public colFilePrefix As New razor.UtilSQLServer.StringDataColumn
        Public colUserLogout As New razor.UtilSQLServer.BooleanDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colId.ColumnName = "[ID]"
            colLoginID.ColumnName = "[LoginID]"
            colLastLoginDateTime.ColumnName = "[LastLoginDateTime]"
            colLastActivityDateTime.ColumnName = "[LastActivityDateTime]"
            colFilePrefix.ColumnName = "[FilePrefix]"
            colUserLogout.ColumnName = "[UserLogout]"

            _Members.Add("colId", colId)
            _Members.Add("colLoginID", colLoginID)
            _Members.Add("colLastLoginDateTime", colLastLoginDateTime)
            _Members.Add("colLastActivityDateTime", colLastActivityDateTime)
            _Members.Add("colFilePrefix", colFilePrefix)
            _Members.Add("colUserLogout", colUserLogout)
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
                Case "colLoginID"
                    Return "[LoginID]"
                Case "colLastLoginDateTime"
                    Return "[LastLoginDateTime]"
                Case "colLastActivityDateTime"
                    Return "[LastActivityDateTime]"
                Case "colFilePrefix"
                    Return "[FilePrefix]"
                Case "colUserLogout"
                    Return "[UserLogout]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[ID]", "ID", "Id", "colId"  
                    Return "colId"
                Case "[LoginID]", "LoginID", "LoginID", "colLoginID"  
                    Return "colLoginID"
                Case "[LastLoginDateTime]", "LastLoginDateTime", "LastLoginDateTime", "colLastLoginDateTime"  
                    Return "colLastLoginDateTime"
                Case "[LastActivityDateTime]", "LastActivityDateTime", "LastActivityDateTime", "colLastActivityDateTime"  
                    Return "colLastActivityDateTime"
                Case "[FilePrefix]", "FilePrefix", "FilePrefix", "colFilePrefix"  
                    Return "colFilePrefix"
                Case "[UserLogout]", "UserLogout", "UserLogout", "colUserLogout"  
                    Return "colUserLogout"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colId"
                    Return "Integer"
                Case "colLoginID"
                    Return "Integer"
                Case "colLastLoginDateTime"
                    Return "DateTime"
                Case "colLastActivityDateTime"
                    Return "DateTime"
                Case "colFilePrefix"
                    Return "String"
                Case "colUserLogout"
                    Return "Boolean"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[ezy_LoginActivityLog]"
        End Function

        Private Function _FirstColumn() As String
            Return "[ID]"
        End Function

    End Class
End namespace

