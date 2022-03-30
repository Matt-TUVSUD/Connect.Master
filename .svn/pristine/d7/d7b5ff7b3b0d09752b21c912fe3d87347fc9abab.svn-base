'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblEzyLogin
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colLoginID As New razor.UtilSQLServer.IntegerDataColumn
        Public colEmailAddress As New razor.UtilSQLServer.StringDataColumn
        Public colFullName As New razor.UtilSQLServer.StringDataColumn
        Public colPassword As New razor.UtilSQLServer.StringDataColumn
        Public colActiveFlag As New razor.UtilSQLServer.BooleanDataColumn
        Public colMarkForDeletionDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colComments As New razor.UtilSQLServer.StringDataColumn
        Public colLoginGuid As New razor.UtilSQLServer.StringDataColumn
        Public colInactivityReminderSentDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colIsLockedOut As New razor.UtilSQLServer.BooleanDataColumn
        Public colPasswordIsExpired As New razor.UtilSQLServer.BooleanDataColumn
        Public colLastPasswordChangeDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colLastLoginDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colLastPasswordResetRequestDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colLastFailedLoginDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colInternal As New razor.UtilSQLServer.BooleanDataColumn
        Public colPasswordReminderSentFlag As New razor.UtilSQLServer.IntegerDataColumn
        Public colFailedLoginStrikeStartDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colFailedLoginStrikeCount As New razor.UtilSQLServer.IntegerDataColumn
        Public colAllowReclassLoginOverride As New razor.UtilSQLServer.BooleanDataColumn
        Public colSysUserCreated As New razor.UtilSQLServer.StringDataColumn
        Public colSysDateCreated As New razor.UtilSQLServer.DateTimeDataColumn
        Public colSysUserModified As New razor.UtilSQLServer.StringDataColumn
        Public colSysDateModified As New razor.UtilSQLServer.DateTimeDataColumn
        Public colWhatsNewLastReviewedDate As New razor.UtilSQLServer.DateTimeDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colLoginID.ColumnName = "[LoginID]"
            colEmailAddress.ColumnName = "[EmailAddress]"
            colFullName.ColumnName = "[FullName]"
            colPassword.ColumnName = "[Password]"
            colActiveFlag.ColumnName = "[ActiveFlag]"
            colMarkForDeletionDate.ColumnName = "[MarkForDeletionDate]"
            colComments.ColumnName = "[Comments]"
            colLoginGuid.ColumnName = "[LoginGuid]"
            colInactivityReminderSentDate.ColumnName = "[InactivityReminderSentDate]"
            colIsLockedOut.ColumnName = "[IsLockedOut]"
            colPasswordIsExpired.ColumnName = "[PasswordIsExpired]"
            colLastPasswordChangeDate.ColumnName = "[LastPasswordChangeDate]"
            colLastLoginDate.ColumnName = "[LastLoginDate]"
            colLastPasswordResetRequestDate.ColumnName = "[LastPasswordResetRequestDate]"
            colLastFailedLoginDate.ColumnName = "[LastFailedLoginDate]"
            colInternal.ColumnName = "[Internal]"
            colPasswordReminderSentFlag.ColumnName = "[PasswordReminderSentFlag]"
            colFailedLoginStrikeStartDate.ColumnName = "[FailedLoginStrikeStartDate]"
            colFailedLoginStrikeCount.ColumnName = "[FailedLoginStrikeCount]"
            colAllowReclassLoginOverride.ColumnName = "[AllowReclassLoginOverride]"
            colSysUserCreated.ColumnName = "[SysUserCreated]"
            colSysDateCreated.ColumnName = "[SysDateCreated]"
            colSysUserModified.ColumnName = "[SysUserModified]"
            colSysDateModified.ColumnName = "[SysDateModified]"
            colWhatsNewLastReviewedDate.ColumnName = "[WhatsNewLastReviewedDate]"

            _Members.Add("colLoginID", colLoginID)
            _Members.Add("colEmailAddress", colEmailAddress)
            _Members.Add("colFullName", colFullName)
            _Members.Add("colPassword", colPassword)
            _Members.Add("colActiveFlag", colActiveFlag)
            _Members.Add("colMarkForDeletionDate", colMarkForDeletionDate)
            _Members.Add("colComments", colComments)
            _Members.Add("colLoginGuid", colLoginGuid)
            _Members.Add("colInactivityReminderSentDate", colInactivityReminderSentDate)
            _Members.Add("colIsLockedOut", colIsLockedOut)
            _Members.Add("colPasswordIsExpired", colPasswordIsExpired)
            _Members.Add("colLastPasswordChangeDate", colLastPasswordChangeDate)
            _Members.Add("colLastLoginDate", colLastLoginDate)
            _Members.Add("colLastPasswordResetRequestDate", colLastPasswordResetRequestDate)
            _Members.Add("colLastFailedLoginDate", colLastFailedLoginDate)
            _Members.Add("colInternal", colInternal)
            _Members.Add("colPasswordReminderSentFlag", colPasswordReminderSentFlag)
            _Members.Add("colFailedLoginStrikeStartDate", colFailedLoginStrikeStartDate)
            _Members.Add("colFailedLoginStrikeCount", colFailedLoginStrikeCount)
            _Members.Add("colAllowReclassLoginOverride", colAllowReclassLoginOverride)
            _Members.Add("colSysUserCreated", colSysUserCreated)
            _Members.Add("colSysDateCreated", colSysDateCreated)
            _Members.Add("colSysUserModified", colSysUserModified)
            _Members.Add("colSysDateModified", colSysDateModified)
            _Members.Add("colWhatsNewLastReviewedDate", colWhatsNewLastReviewedDate)
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
                Case "colEmailAddress"
                    Return "[EmailAddress]"
                Case "colFullName"
                    Return "[FullName]"
                Case "colPassword"
                    Return "[Password]"
                Case "colActiveFlag"
                    Return "[ActiveFlag]"
                Case "colMarkForDeletionDate"
                    Return "[MarkForDeletionDate]"
                Case "colComments"
                    Return "[Comments]"
                Case "colLoginGuid"
                    Return "[LoginGuid]"
                Case "colInactivityReminderSentDate"
                    Return "[InactivityReminderSentDate]"
                Case "colIsLockedOut"
                    Return "[IsLockedOut]"
                Case "colPasswordIsExpired"
                    Return "[PasswordIsExpired]"
                Case "colLastPasswordChangeDate"
                    Return "[LastPasswordChangeDate]"
                Case "colLastLoginDate"
                    Return "[LastLoginDate]"
                Case "colLastPasswordResetRequestDate"
                    Return "[LastPasswordResetRequestDate]"
                Case "colLastFailedLoginDate"
                    Return "[LastFailedLoginDate]"
                Case "colInternal"
                    Return "[Internal]"
                Case "colPasswordReminderSentFlag"
                    Return "[PasswordReminderSentFlag]"
                Case "colFailedLoginStrikeStartDate"
                    Return "[FailedLoginStrikeStartDate]"
                Case "colFailedLoginStrikeCount"
                    Return "[FailedLoginStrikeCount]"
                Case "colAllowReclassLoginOverride"
                    Return "[AllowReclassLoginOverride]"
                Case "colSysUserCreated"
                    Return "[SysUserCreated]"
                Case "colSysDateCreated"
                    Return "[SysDateCreated]"
                Case "colSysUserModified"
                    Return "[SysUserModified]"
                Case "colSysDateModified"
                    Return "[SysDateModified]"
                Case "colWhatsNewLastReviewedDate"
                    Return "[WhatsNewLastReviewedDate]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[LoginID]", "LoginID", "LoginID", "colLoginID"  
                    Return "colLoginID"
                Case "[EmailAddress]", "EmailAddress", "EmailAddress", "colEmailAddress"  
                    Return "colEmailAddress"
                Case "[FullName]", "FullName", "FullName", "colFullName"  
                    Return "colFullName"
                Case "[Password]", "Password", "Password", "colPassword"  
                    Return "colPassword"
                Case "[ActiveFlag]", "ActiveFlag", "ActiveFlag", "colActiveFlag"  
                    Return "colActiveFlag"
                Case "[MarkForDeletionDate]", "MarkForDeletionDate", "MarkForDeletionDate", "colMarkForDeletionDate"  
                    Return "colMarkForDeletionDate"
                Case "[Comments]", "Comments", "Comments", "colComments"  
                    Return "colComments"
                Case "[LoginGuid]", "LoginGuid", "LoginGuid", "colLoginGuid"  
                    Return "colLoginGuid"
                Case "[InactivityReminderSentDate]", "InactivityReminderSentDate", "InactivityReminderSentDate", "colInactivityReminderSentDate"  
                    Return "colInactivityReminderSentDate"
                Case "[IsLockedOut]", "IsLockedOut", "IsLockedOut", "colIsLockedOut"  
                    Return "colIsLockedOut"
                Case "[PasswordIsExpired]", "PasswordIsExpired", "PasswordIsExpired", "colPasswordIsExpired"  
                    Return "colPasswordIsExpired"
                Case "[LastPasswordChangeDate]", "LastPasswordChangeDate", "LastPasswordChangeDate", "colLastPasswordChangeDate"  
                    Return "colLastPasswordChangeDate"
                Case "[LastLoginDate]", "LastLoginDate", "LastLoginDate", "colLastLoginDate"  
                    Return "colLastLoginDate"
                Case "[LastPasswordResetRequestDate]", "LastPasswordResetRequestDate", "LastPasswordResetRequestDate", "colLastPasswordResetRequestDate"  
                    Return "colLastPasswordResetRequestDate"
                Case "[LastFailedLoginDate]", "LastFailedLoginDate", "LastFailedLoginDate", "colLastFailedLoginDate"  
                    Return "colLastFailedLoginDate"
                Case "[Internal]", "Internal", "Internal", "colInternal"  
                    Return "colInternal"
                Case "[PasswordReminderSentFlag]", "PasswordReminderSentFlag", "PasswordReminderSentFlag", "colPasswordReminderSentFlag"  
                    Return "colPasswordReminderSentFlag"
                Case "[FailedLoginStrikeStartDate]", "FailedLoginStrikeStartDate", "FailedLoginStrikeStartDate", "colFailedLoginStrikeStartDate"  
                    Return "colFailedLoginStrikeStartDate"
                Case "[FailedLoginStrikeCount]", "FailedLoginStrikeCount", "FailedLoginStrikeCount", "colFailedLoginStrikeCount"  
                    Return "colFailedLoginStrikeCount"
                Case "[AllowReclassLoginOverride]", "AllowReclassLoginOverride", "AllowReclassLoginOverride", "colAllowReclassLoginOverride"  
                    Return "colAllowReclassLoginOverride"
                Case "[SysUserCreated]", "SysUserCreated", "SysUserCreated", "colSysUserCreated"  
                    Return "colSysUserCreated"
                Case "[SysDateCreated]", "SysDateCreated", "SysDateCreated", "colSysDateCreated"  
                    Return "colSysDateCreated"
                Case "[SysUserModified]", "SysUserModified", "SysUserModified", "colSysUserModified"  
                    Return "colSysUserModified"
                Case "[SysDateModified]", "SysDateModified", "SysDateModified", "colSysDateModified"  
                    Return "colSysDateModified"
                Case "[WhatsNewLastReviewedDate]", "WhatsNewLastReviewedDate", "WhatsNewLastReviewedDate", "colWhatsNewLastReviewedDate"  
                    Return "colWhatsNewLastReviewedDate"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colLoginID"
                    Return "Integer"
                Case "colEmailAddress"
                    Return "String"
                Case "colFullName"
                    Return "String"
                Case "colPassword"
                    Return "String"
                Case "colActiveFlag"
                    Return "Boolean"
                Case "colMarkForDeletionDate"
                    Return "DateTime"
                Case "colComments"
                    Return "String"
                Case "colLoginGuid"
                    Return "String"
                Case "colInactivityReminderSentDate"
                    Return "DateTime"
                Case "colIsLockedOut"
                    Return "Boolean"
                Case "colPasswordIsExpired"
                    Return "Boolean"
                Case "colLastPasswordChangeDate"
                    Return "DateTime"
                Case "colLastLoginDate"
                    Return "DateTime"
                Case "colLastPasswordResetRequestDate"
                    Return "DateTime"
                Case "colLastFailedLoginDate"
                    Return "DateTime"
                Case "colInternal"
                    Return "Boolean"
                Case "colPasswordReminderSentFlag"
                    Return "Integer"
                Case "colFailedLoginStrikeStartDate"
                    Return "DateTime"
                Case "colFailedLoginStrikeCount"
                    Return "Integer"
                Case "colAllowReclassLoginOverride"
                    Return "Boolean"
                Case "colSysUserCreated"
                    Return "String"
                Case "colSysDateCreated"
                    Return "DateTime"
                Case "colSysUserModified"
                    Return "String"
                Case "colSysDateModified"
                    Return "DateTime"
                Case "colWhatsNewLastReviewedDate"
                    Return "DateTime"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[ezy_Login]"
        End Function

        Private Function _FirstColumn() As String
            Return "[LoginID]"
        End Function

    End Class
End namespace

