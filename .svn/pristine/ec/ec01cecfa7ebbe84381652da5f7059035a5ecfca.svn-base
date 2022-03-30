'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryVwUserActivityLog
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colId As New razor.UtilSQLServer.IntegerDataColumn
        Public colClientname As New razor.UtilSQLServer.StringDataColumn
        Public colFullName As New razor.UtilSQLServer.StringDataColumn
        Public colEmailAddress As New razor.UtilSQLServer.StringDataColumn
        Public colLastLoginDateTime As New razor.UtilSQLServer.DateTimeDataColumn
        Public colLastActivityDateTime As New razor.UtilSQLServer.DateTimeDataColumn
        Public colDuration As New razor.UtilSQLServer.StringDataColumn
        Public colFilePrefix As New razor.UtilSQLServer.StringDataColumn
        Public colLoginID As New razor.UtilSQLServer.IntegerDataColumn
        Public colInternal As New razor.UtilSQLServer.BooleanDataColumn
        Public colUserLogout As New razor.UtilSQLServer.BooleanDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colId.ColumnName = "[ID]"
            colClientname.ColumnName = "[clientname]"
            colFullName.ColumnName = "[FullName]"
            colEmailAddress.ColumnName = "[EmailAddress]"
            colLastLoginDateTime.ColumnName = "[LastLoginDateTime]"
            colLastActivityDateTime.ColumnName = "[LastActivityDateTime]"
            colDuration.ColumnName = "[Duration]"
            colFilePrefix.ColumnName = "[FilePrefix]"
            colLoginID.ColumnName = "[LoginID]"
            colInternal.ColumnName = "[Internal]"
            colUserLogout.ColumnName = "[UserLogout]"

            _Members.Add("colId", colId)
            _Members.Add("colClientname", colClientname)
            _Members.Add("colFullName", colFullName)
            _Members.Add("colEmailAddress", colEmailAddress)
            _Members.Add("colLastLoginDateTime", colLastLoginDateTime)
            _Members.Add("colLastActivityDateTime", colLastActivityDateTime)
            _Members.Add("colDuration", colDuration)
            _Members.Add("colFilePrefix", colFilePrefix)
            _Members.Add("colLoginID", colLoginID)
            _Members.Add("colInternal", colInternal)
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
                Case "colClientname"
                    Return "[clientname]"
                Case "colFullName"
                    Return "[FullName]"
                Case "colEmailAddress"
                    Return "[EmailAddress]"
                Case "colLastLoginDateTime"
                    Return "[LastLoginDateTime]"
                Case "colLastActivityDateTime"
                    Return "[LastActivityDateTime]"
                Case "colDuration"
                    Return "[Duration]"
                Case "colFilePrefix"
                    Return "[FilePrefix]"
                Case "colLoginID"
                    Return "[LoginID]"
                Case "colInternal"
                    Return "[Internal]"
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
                Case "[clientname]", "clientname", "Clientname", "colClientname"  
                    Return "colClientname"
                Case "[FullName]", "FullName", "FullName", "colFullName"  
                    Return "colFullName"
                Case "[EmailAddress]", "EmailAddress", "EmailAddress", "colEmailAddress"  
                    Return "colEmailAddress"
                Case "[LastLoginDateTime]", "LastLoginDateTime", "LastLoginDateTime", "colLastLoginDateTime"  
                    Return "colLastLoginDateTime"
                Case "[LastActivityDateTime]", "LastActivityDateTime", "LastActivityDateTime", "colLastActivityDateTime"  
                    Return "colLastActivityDateTime"
                Case "[Duration]", "Duration", "Duration", "colDuration"  
                    Return "colDuration"
                Case "[FilePrefix]", "FilePrefix", "FilePrefix", "colFilePrefix"  
                    Return "colFilePrefix"
                Case "[LoginID]", "LoginID", "LoginID", "colLoginID"  
                    Return "colLoginID"
                Case "[Internal]", "Internal", "Internal", "colInternal"  
                    Return "colInternal"
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
                Case "colClientname"
                    Return "String"
                Case "colFullName"
                    Return "String"
                Case "colEmailAddress"
                    Return "String"
                Case "colLastLoginDateTime"
                    Return "DateTime"
                Case "colLastActivityDateTime"
                    Return "DateTime"
                Case "colDuration"
                    Return "String"
                Case "colFilePrefix"
                    Return "String"
                Case "colLoginID"
                    Return "Integer"
                Case "colInternal"
                    Return "Boolean"
                Case "colUserLogout"
                    Return "Boolean"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[gv].[vwUserActivityLog]"
        End Function

        Private Function _FirstColumn() As String
            Return "[ID]"
        End Function

    End Class
End namespace

