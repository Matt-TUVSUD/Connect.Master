'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblNotification
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colNotificationID As New razor.UtilSQLServer.IntegerDataColumn
        Public colTo As New razor.UtilSQLServer.StringDataColumn
        Public colCc As New razor.UtilSQLServer.StringDataColumn
        Public colBcc As New razor.UtilSQLServer.StringDataColumn
        Public colSubject As New razor.UtilSQLServer.StringDataColumn
        Public colBody As New razor.UtilSQLServer.StringDataColumn
        Public colCreateDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colSentDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colProcessedDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colIsException As New razor.UtilSQLServer.BooleanDataColumn
        Public colAttachmentData As New razor.UtilSQLServer.StringDataColumn
        Public colNotificationType As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colNotificationID.ColumnName = "[NotificationID]"
            colTo.ColumnName = "[To]"
            colCc.ColumnName = "[Cc]"
            colBcc.ColumnName = "[Bcc]"
            colSubject.ColumnName = "[Subject]"
            colBody.ColumnName = "[Body]"
            colCreateDate.ColumnName = "[CreateDate]"
            colSentDate.ColumnName = "[SentDate]"
            colProcessedDate.ColumnName = "[ProcessedDate]"
            colIsException.ColumnName = "[IsException]"
            colAttachmentData.ColumnName = "[AttachmentData]"
            colNotificationType.ColumnName = "[NotificationType]"

            _Members.Add("colNotificationID", colNotificationID)
            _Members.Add("colTo", colTo)
            _Members.Add("colCc", colCc)
            _Members.Add("colBcc", colBcc)
            _Members.Add("colSubject", colSubject)
            _Members.Add("colBody", colBody)
            _Members.Add("colCreateDate", colCreateDate)
            _Members.Add("colSentDate", colSentDate)
            _Members.Add("colProcessedDate", colProcessedDate)
            _Members.Add("colIsException", colIsException)
            _Members.Add("colAttachmentData", colAttachmentData)
            _Members.Add("colNotificationType", colNotificationType)
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
                Case "colNotificationID"
                    Return "[NotificationID]"
                Case "colTo"
                    Return "[To]"
                Case "colCc"
                    Return "[Cc]"
                Case "colBcc"
                    Return "[Bcc]"
                Case "colSubject"
                    Return "[Subject]"
                Case "colBody"
                    Return "[Body]"
                Case "colCreateDate"
                    Return "[CreateDate]"
                Case "colSentDate"
                    Return "[SentDate]"
                Case "colProcessedDate"
                    Return "[ProcessedDate]"
                Case "colIsException"
                    Return "[IsException]"
                Case "colAttachmentData"
                    Return "[AttachmentData]"
                Case "colNotificationType"
                    Return "[NotificationType]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[NotificationID]", "NotificationID", "NotificationID", "colNotificationID"  
                    Return "colNotificationID"
                Case "[To]", "To", "To", "colTo"  
                    Return "colTo"
                Case "[Cc]", "Cc", "Cc", "colCc"  
                    Return "colCc"
                Case "[Bcc]", "Bcc", "Bcc", "colBcc"  
                    Return "colBcc"
                Case "[Subject]", "Subject", "Subject", "colSubject"  
                    Return "colSubject"
                Case "[Body]", "Body", "Body", "colBody"  
                    Return "colBody"
                Case "[CreateDate]", "CreateDate", "CreateDate", "colCreateDate"  
                    Return "colCreateDate"
                Case "[SentDate]", "SentDate", "SentDate", "colSentDate"  
                    Return "colSentDate"
                Case "[ProcessedDate]", "ProcessedDate", "ProcessedDate", "colProcessedDate"  
                    Return "colProcessedDate"
                Case "[IsException]", "IsException", "IsException", "colIsException"  
                    Return "colIsException"
                Case "[AttachmentData]", "AttachmentData", "AttachmentData", "colAttachmentData"  
                    Return "colAttachmentData"
                Case "[NotificationType]", "NotificationType", "NotificationType", "colNotificationType"  
                    Return "colNotificationType"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colNotificationID"
                    Return "Integer"
                Case "colTo"
                    Return "String"
                Case "colCc"
                    Return "String"
                Case "colBcc"
                    Return "String"
                Case "colSubject"
                    Return "String"
                Case "colBody"
                    Return "String"
                Case "colCreateDate"
                    Return "DateTime"
                Case "colSentDate"
                    Return "DateTime"
                Case "colProcessedDate"
                    Return "DateTime"
                Case "colIsException"
                    Return "Boolean"
                Case "colAttachmentData"
                    Return "String"
                Case "colNotificationType"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblNotification]"
        End Function

        Private Function _FirstColumn() As String
            Return "[NotificationID]"
        End Function

    End Class
End namespace

