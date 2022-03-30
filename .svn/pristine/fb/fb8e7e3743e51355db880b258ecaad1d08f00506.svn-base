'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblEzyPasswordhistory
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colPasswordHistoryID As New razor.UtilSQLServer.IntegerDataColumn
        Public colLoginID As New razor.UtilSQLServer.IntegerDataColumn
        Public colCreatedDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colPassword As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colPasswordHistoryID.ColumnName = "[PasswordHistoryID]"
            colLoginID.ColumnName = "[LoginID]"
            colCreatedDate.ColumnName = "[CreatedDate]"
            colPassword.ColumnName = "[Password]"

            _Members.Add("colPasswordHistoryID", colPasswordHistoryID)
            _Members.Add("colLoginID", colLoginID)
            _Members.Add("colCreatedDate", colCreatedDate)
            _Members.Add("colPassword", colPassword)
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
                Case "colPasswordHistoryID"
                    Return "[PasswordHistoryID]"
                Case "colLoginID"
                    Return "[LoginID]"
                Case "colCreatedDate"
                    Return "[CreatedDate]"
                Case "colPassword"
                    Return "[Password]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[PasswordHistoryID]", "PasswordHistoryID", "PasswordHistoryID", "colPasswordHistoryID"  
                    Return "colPasswordHistoryID"
                Case "[LoginID]", "LoginID", "LoginID", "colLoginID"  
                    Return "colLoginID"
                Case "[CreatedDate]", "CreatedDate", "CreatedDate", "colCreatedDate"  
                    Return "colCreatedDate"
                Case "[Password]", "Password", "Password", "colPassword"  
                    Return "colPassword"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colPasswordHistoryID"
                    Return "Integer"
                Case "colLoginID"
                    Return "Integer"
                Case "colCreatedDate"
                    Return "DateTime"
                Case "colPassword"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[ezy_PasswordHistory]"
        End Function

        Private Function _FirstColumn() As String
            Return "[PasswordHistoryID]"
        End Function

    End Class
End namespace

