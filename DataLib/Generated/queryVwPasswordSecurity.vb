'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryVwPasswordSecurity
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colLoginID As New razor.UtilSQLServer.IntegerDataColumn
        Public colPasswordReminderSentFlag As New razor.UtilSQLServer.IntegerDataColumn
        Public colExpireEveryNthDay As New razor.UtilSQLServer.IntegerDataColumn
        Public colLastPasswordChangeDate As New razor.UtilSQLServer.DateDataColumn
        Public colIsLockedOut As New razor.UtilSQLServer.BooleanDataColumn
        Public colPasswordIsExpired As New razor.UtilSQLServer.BooleanDataColumn
        Public colPasswordExpirationDate As New razor.UtilSQLServer.DateDataColumn
        Public colNeedToExpirePasswordAndLockout As New razor.UtilSQLServer.BooleanDataColumn
        Public colDaysUntilPasswordExpiration As New razor.UtilSQLServer.IntegerDataColumn
        Public colNeed14DayPasswordReminder As New razor.UtilSQLServer.BooleanDataColumn
        Public colNeed7DayPasswordReminder As New razor.UtilSQLServer.BooleanDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colLoginID.ColumnName = "[LoginID]"
            colPasswordReminderSentFlag.ColumnName = "[PasswordReminderSentFlag]"
            colExpireEveryNthDay.ColumnName = "[ExpireEveryNthDay]"
            colLastPasswordChangeDate.ColumnName = "[LastPasswordChangeDate]"
            colIsLockedOut.ColumnName = "[IsLockedOut]"
            colPasswordIsExpired.ColumnName = "[PasswordIsExpired]"
            colPasswordExpirationDate.ColumnName = "[PasswordExpirationDate]"
            colNeedToExpirePasswordAndLockout.ColumnName = "[NeedToExpirePasswordAndLockout]"
            colDaysUntilPasswordExpiration.ColumnName = "[DaysUntilPasswordExpiration]"
            colNeed14DayPasswordReminder.ColumnName = "[Need14DayPasswordReminder]"
            colNeed7DayPasswordReminder.ColumnName = "[Need7DayPasswordReminder]"

            _Members.Add("colLoginID", colLoginID)
            _Members.Add("colPasswordReminderSentFlag", colPasswordReminderSentFlag)
            _Members.Add("colExpireEveryNthDay", colExpireEveryNthDay)
            _Members.Add("colLastPasswordChangeDate", colLastPasswordChangeDate)
            _Members.Add("colIsLockedOut", colIsLockedOut)
            _Members.Add("colPasswordIsExpired", colPasswordIsExpired)
            _Members.Add("colPasswordExpirationDate", colPasswordExpirationDate)
            _Members.Add("colNeedToExpirePasswordAndLockout", colNeedToExpirePasswordAndLockout)
            _Members.Add("colDaysUntilPasswordExpiration", colDaysUntilPasswordExpiration)
            _Members.Add("colNeed14DayPasswordReminder", colNeed14DayPasswordReminder)
            _Members.Add("colNeed7DayPasswordReminder", colNeed7DayPasswordReminder)
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
                Case "colLoginID"
                    Return "[LoginID]"
                Case "colPasswordReminderSentFlag"
                    Return "[PasswordReminderSentFlag]"
                Case "colExpireEveryNthDay"
                    Return "[ExpireEveryNthDay]"
                Case "colLastPasswordChangeDate"
                    Return "[LastPasswordChangeDate]"
                Case "colIsLockedOut"
                    Return "[IsLockedOut]"
                Case "colPasswordIsExpired"
                    Return "[PasswordIsExpired]"
                Case "colPasswordExpirationDate"
                    Return "[PasswordExpirationDate]"
                Case "colNeedToExpirePasswordAndLockout"
                    Return "[NeedToExpirePasswordAndLockout]"
                Case "colDaysUntilPasswordExpiration"
                    Return "[DaysUntilPasswordExpiration]"
                Case "colNeed14DayPasswordReminder"
                    Return "[Need14DayPasswordReminder]"
                Case "colNeed7DayPasswordReminder"
                    Return "[Need7DayPasswordReminder]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[LoginID]", "LoginID", "LoginID", "colLoginID"  
                    Return "colLoginID"
                Case "[PasswordReminderSentFlag]", "PasswordReminderSentFlag", "PasswordReminderSentFlag", "colPasswordReminderSentFlag"  
                    Return "colPasswordReminderSentFlag"
                Case "[ExpireEveryNthDay]", "ExpireEveryNthDay", "ExpireEveryNthDay", "colExpireEveryNthDay"  
                    Return "colExpireEveryNthDay"
                Case "[LastPasswordChangeDate]", "LastPasswordChangeDate", "LastPasswordChangeDate", "colLastPasswordChangeDate"  
                    Return "colLastPasswordChangeDate"
                Case "[IsLockedOut]", "IsLockedOut", "IsLockedOut", "colIsLockedOut"  
                    Return "colIsLockedOut"
                Case "[PasswordIsExpired]", "PasswordIsExpired", "PasswordIsExpired", "colPasswordIsExpired"  
                    Return "colPasswordIsExpired"
                Case "[PasswordExpirationDate]", "PasswordExpirationDate", "PasswordExpirationDate", "colPasswordExpirationDate"  
                    Return "colPasswordExpirationDate"
                Case "[NeedToExpirePasswordAndLockout]", "NeedToExpirePasswordAndLockout", "NeedToExpirePasswordAndLockout", "colNeedToExpirePasswordAndLockout"  
                    Return "colNeedToExpirePasswordAndLockout"
                Case "[DaysUntilPasswordExpiration]", "DaysUntilPasswordExpiration", "DaysUntilPasswordExpiration", "colDaysUntilPasswordExpiration"  
                    Return "colDaysUntilPasswordExpiration"
                Case "[Need14DayPasswordReminder]", "Need14DayPasswordReminder", "Need14DayPasswordReminder", "colNeed14DayPasswordReminder"  
                    Return "colNeed14DayPasswordReminder"
                Case "[Need7DayPasswordReminder]", "Need7DayPasswordReminder", "Need7DayPasswordReminder", "colNeed7DayPasswordReminder"  
                    Return "colNeed7DayPasswordReminder"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colLoginID"
                    Return "Integer"
                Case "colPasswordReminderSentFlag"
                    Return "Integer"
                Case "colExpireEveryNthDay"
                    Return "Integer"
                Case "colLastPasswordChangeDate"
                    Return "Date"
                Case "colIsLockedOut"
                    Return "Boolean"
                Case "colPasswordIsExpired"
                    Return "Boolean"
                Case "colPasswordExpirationDate"
                    Return "Date"
                Case "colNeedToExpirePasswordAndLockout"
                    Return "Boolean"
                Case "colDaysUntilPasswordExpiration"
                    Return "Integer"
                Case "colNeed14DayPasswordReminder"
                    Return "Boolean"
                Case "colNeed7DayPasswordReminder"
                    Return "Boolean"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[jv].[vwPasswordSecurity]"
        End Function

        Private Function _FirstColumn() As String
            Return "[LoginID]"
        End Function

    End Class
End namespace

