'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryVwReclassificationDeletedUser
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colEzyUserID As New razor.UtilSQLServer.IntegerDataColumn
        Public colFullName As New razor.UtilSQLServer.StringDataColumn
        Public colReclassificationAction As New razor.UtilSQLServer.IntegerDataColumn
        Public colReclassificationDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colMarkedForDeletionDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colReclassificationCompletionDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colMarkedForDeletion As New razor.UtilSQLServer.BooleanDataColumn
        Public colDeleteOnDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colLoginId As New razor.UtilSQLServer.IntegerDataColumn
        Public colDeleteLogin As New razor.UtilSQLServer.BooleanDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colEzyUserID.ColumnName = "[EzyUserID]"
            colFullName.ColumnName = "[FullName]"
            colReclassificationAction.ColumnName = "[ReclassificationAction]"
            colReclassificationDate.ColumnName = "[ReclassificationDate]"
            colMarkedForDeletionDate.ColumnName = "[MarkedForDeletionDate]"
            colReclassificationCompletionDate.ColumnName = "[ReclassificationCompletionDate]"
            colMarkedForDeletion.ColumnName = "[MarkedForDeletion]"
            colDeleteOnDate.ColumnName = "[DeleteOnDate]"
            colLoginId.ColumnName = "[LoginId]"
            colDeleteLogin.ColumnName = "[DeleteLogin]"

            _Members.Add("colEzyUserID", colEzyUserID)
            _Members.Add("colFullName", colFullName)
            _Members.Add("colReclassificationAction", colReclassificationAction)
            _Members.Add("colReclassificationDate", colReclassificationDate)
            _Members.Add("colMarkedForDeletionDate", colMarkedForDeletionDate)
            _Members.Add("colReclassificationCompletionDate", colReclassificationCompletionDate)
            _Members.Add("colMarkedForDeletion", colMarkedForDeletion)
            _Members.Add("colDeleteOnDate", colDeleteOnDate)
            _Members.Add("colLoginId", colLoginId)
            _Members.Add("colDeleteLogin", colDeleteLogin)
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
                Case "colEzyUserID"
                    Return "[EzyUserID]"
                Case "colFullName"
                    Return "[FullName]"
                Case "colReclassificationAction"
                    Return "[ReclassificationAction]"
                Case "colReclassificationDate"
                    Return "[ReclassificationDate]"
                Case "colMarkedForDeletionDate"
                    Return "[MarkedForDeletionDate]"
                Case "colReclassificationCompletionDate"
                    Return "[ReclassificationCompletionDate]"
                Case "colMarkedForDeletion"
                    Return "[MarkedForDeletion]"
                Case "colDeleteOnDate"
                    Return "[DeleteOnDate]"
                Case "colLoginId"
                    Return "[LoginId]"
                Case "colDeleteLogin"
                    Return "[DeleteLogin]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[EzyUserID]", "EzyUserID", "EzyUserID", "colEzyUserID"  
                    Return "colEzyUserID"
                Case "[FullName]", "FullName", "FullName", "colFullName"  
                    Return "colFullName"
                Case "[ReclassificationAction]", "ReclassificationAction", "ReclassificationAction", "colReclassificationAction"  
                    Return "colReclassificationAction"
                Case "[ReclassificationDate]", "ReclassificationDate", "ReclassificationDate", "colReclassificationDate"  
                    Return "colReclassificationDate"
                Case "[MarkedForDeletionDate]", "MarkedForDeletionDate", "MarkedForDeletionDate", "colMarkedForDeletionDate"  
                    Return "colMarkedForDeletionDate"
                Case "[ReclassificationCompletionDate]", "ReclassificationCompletionDate", "ReclassificationCompletionDate", "colReclassificationCompletionDate"  
                    Return "colReclassificationCompletionDate"
                Case "[MarkedForDeletion]", "MarkedForDeletion", "MarkedForDeletion", "colMarkedForDeletion"  
                    Return "colMarkedForDeletion"
                Case "[DeleteOnDate]", "DeleteOnDate", "DeleteOnDate", "colDeleteOnDate"  
                    Return "colDeleteOnDate"
                Case "[LoginId]", "LoginId", "LoginId", "colLoginId"  
                    Return "colLoginId"
                Case "[DeleteLogin]", "DeleteLogin", "DeleteLogin", "colDeleteLogin"  
                    Return "colDeleteLogin"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colEzyUserID"
                    Return "Integer"
                Case "colFullName"
                    Return "String"
                Case "colReclassificationAction"
                    Return "Integer"
                Case "colReclassificationDate"
                    Return "DateTime"
                Case "colMarkedForDeletionDate"
                    Return "DateTime"
                Case "colReclassificationCompletionDate"
                    Return "DateTime"
                Case "colMarkedForDeletion"
                    Return "Boolean"
                Case "colDeleteOnDate"
                    Return "DateTime"
                Case "colLoginId"
                    Return "Integer"
                Case "colDeleteLogin"
                    Return "Boolean"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[jv].[vwReclassificationDeletedUser]"
        End Function

        Private Function _FirstColumn() As String
            Return "[EzyUserID]"
        End Function

    End Class
End namespace

