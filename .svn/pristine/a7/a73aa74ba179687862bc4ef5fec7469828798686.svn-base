'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblClients
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colCldbname As New razor.UtilSQLServer.StringDataColumn
        Public colClientname As New razor.UtilSQLServer.StringDataColumn
        Public colFeatures As New razor.UtilSQLServer.StringDataColumn
        Public colFileprefix As New razor.UtilSQLServer.StringDataColumn
        Public colClientdesigneenotify As New razor.UtilSQLServer.BooleanDataColumn
        Public colClientdesigneename As New razor.UtilSQLServer.StringDataColumn
        Public colClientdesigneeemail As New razor.UtilSQLServer.StringDataColumn
        Public colActive As New razor.UtilSQLServer.BooleanDataColumn
        Public colRecrespemail As New razor.UtilSQLServer.StringDataColumn
        Public colRecautofollowup As New razor.UtilSQLServer.BooleanDataColumn
        Public colRecfollowup1 As New razor.UtilSQLServer.IntegerDataColumn
        Public colRecfollowup2 As New razor.UtilSQLServer.IntegerDataColumn
        Public colRecfollowup3 As New razor.UtilSQLServer.IntegerDataColumn
        Public colDatatransfer As New razor.UtilSQLServer.StringDataColumn
        Public colAutoRecStartDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colAutoRecComments As New razor.UtilSQLServer.StringDataColumn
        Public colFireRatingKeyID As New razor.UtilSQLServer.ByteDataColumn
        Public colBMRatingKeyID As New razor.UtilSQLServer.ByteDataColumn
        Public colCustomAccessLabel As New razor.UtilSQLServer.StringDataColumn
        Public colWORecipientName As New razor.UtilSQLServer.StringDataColumn
        Public colWORecipientEmail As New razor.UtilSQLServer.StringDataColumn
        Public colWOSubject As New razor.UtilSQLServer.StringDataColumn
        Public colExchangeRateGroupID As New razor.UtilSQLServer.ByteDataColumn
        Public colAutoRecLastProcessDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colIfu As New razor.UtilSQLServer.BooleanDataColumn
        Public colPifu1 As New razor.UtilSQLServer.IntegerDataColumn
        Public colPifu2 As New razor.UtilSQLServer.IntegerDataColumn
        Public colPifu3 As New razor.UtilSQLServer.IntegerDataColumn
        Public colPifu4 As New razor.UtilSQLServer.IntegerDataColumn
        Public colImpClientDesName1 As New razor.UtilSQLServer.StringDataColumn
        Public colImpClientDesEmail1 As New razor.UtilSQLServer.StringDataColumn
        Public colImpClientDesName2 As New razor.UtilSQLServer.StringDataColumn
        Public colImpClientDesEmail2 As New razor.UtilSQLServer.StringDataColumn
        Public colImpClientDesName3 As New razor.UtilSQLServer.StringDataColumn
        Public colImpClientDesEmail3 As New razor.UtilSQLServer.StringDataColumn
        Public colAifu As New razor.UtilSQLServer.StringDataColumn
        Public colImpClientDesName4 As New razor.UtilSQLServer.StringDataColumn
        Public colImpClientDesEmail4 As New razor.UtilSQLServer.StringDataColumn
        Public colImpClientDesName5 As New razor.UtilSQLServer.StringDataColumn
        Public colImpClientDesEmail5 As New razor.UtilSQLServer.StringDataColumn
        Public colMgmtARR As New razor.UtilSQLServer.BooleanDataColumn
        Public colImpEmailAll As New razor.UtilSQLServer.BooleanDataColumn
        Public colSecurityPasswordExpireDays As New razor.UtilSQLServer.IntegerDataColumn
        Public colSecurityInactivityLockoutDays As New razor.UtilSQLServer.IntegerDataColumn
        Public colSecurityInactivityLockoutRemindDays As New razor.UtilSQLServer.IntegerDataColumn
        Public colSecurityPasswordMinimumLength As New razor.UtilSQLServer.IntegerDataColumn
        Public colSecurityPasswordTypeId As New razor.UtilSQLServer.IntegerDataColumn
        Public colDataTransferPackageId As New razor.UtilSQLServer.IntegerDataColumn
        Public colDataTransferPassword As New razor.UtilSQLServer.StringDataColumn
        Public colDataTransferEncryptionKey As New razor.UtilSQLServer.StringDataColumn
        Public colSecurityAllowChangePassword As New razor.UtilSQLServer.BooleanDataColumn
        Public colReclassificationEmailSentDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colReclassificationEmailFollowUpDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colReclassificationCompletionDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colReclassificationLinkGUID As New razor.UtilSQLServer.StringDataColumn
        Public colLastReclassificationCompletionDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colSysUserCreated As New razor.UtilSQLServer.StringDataColumn
        Public colSysDateCreated As New razor.UtilSQLServer.DateTimeDataColumn
        Public colSysUserModified As New razor.UtilSQLServer.StringDataColumn
        Public colSysDateModified As New razor.UtilSQLServer.DateTimeDataColumn
        Public colClientId As New razor.UtilSQLServer.IntegerDataColumn
        Public colDataTransferPgpEnabled As New razor.UtilSQLServer.BooleanDataColumn
        Public colDataTransferPgpPublicKey As New razor.UtilSQLServer.StringDataColumn
        Public colDataTransferFtpUrl As New razor.UtilSQLServer.StringDataColumn
        Public colDataTransferFtpUserName As New razor.UtilSQLServer.StringDataColumn
        Public colDataTransferFtpPassword As New razor.UtilSQLServer.StringDataColumn
        Public colDataTransferPgpFileExtension As New razor.UtilSQLServer.StringDataColumn
        Public colDataTransferFtpEnabled As New razor.UtilSQLServer.BooleanDataColumn
        Public colDataTransferRetrievalDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colDefaultMetaCurrencyID As New razor.UtilSQLServer.IntegerDataColumn
        Public colARRRolloutOption As New razor.UtilSQLServer.StringDataColumn
        Public colARRRolloutOptionDesc As New razor.UtilSQLServer.StringDataColumn
        Public colImpairmentStatus As New razor.UtilSQLServer.BooleanDataColumn
        Public colImpairmentSpecialHandling As New razor.UtilSQLServer.BooleanDataColumn
        Public colImpairmentSpecialHandlingDesc As New razor.UtilSQLServer.StringDataColumn
        Public colDataTransferFtpLocalFolder As New razor.UtilSQLServer.StringDataColumn
        Public colDataTransferFileNameFormatString As New razor.UtilSQLServer.StringDataColumn
        Public colDataTransferFtpMonthJson As New razor.UtilSQLServer.StringDataColumn
        Public colDataTransferFtpDayJson As New razor.UtilSQLServer.StringDataColumn
        Public colIndustryGroup As New razor.UtilSQLServer.StringDataColumn
        Public colMajorGroup As New razor.UtilSQLServer.StringDataColumn
        Public colSpecificGroup As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colCldbname.ColumnName = "[cldbname]"
            colClientname.ColumnName = "[clientname]"
            colFeatures.ColumnName = "[features]"
            colFileprefix.ColumnName = "[fileprefix]"
            colClientdesigneenotify.ColumnName = "[clientdesigneenotify]"
            colClientdesigneename.ColumnName = "[clientdesigneename]"
            colClientdesigneeemail.ColumnName = "[clientdesigneeemail]"
            colActive.ColumnName = "[580active]"
            colRecrespemail.ColumnName = "[recrespemail]"
            colRecautofollowup.ColumnName = "[recautofollowup]"
            colRecfollowup1.ColumnName = "[recfollowup1]"
            colRecfollowup2.ColumnName = "[recfollowup2]"
            colRecfollowup3.ColumnName = "[recfollowup3]"
            colDatatransfer.ColumnName = "[datatransfer]"
            colAutoRecStartDate.ColumnName = "[AutoRecStartDate]"
            colAutoRecComments.ColumnName = "[AutoRecComments]"
            colFireRatingKeyID.ColumnName = "[FireRatingKeyID]"
            colBMRatingKeyID.ColumnName = "[BMRatingKeyID]"
            colCustomAccessLabel.ColumnName = "[CustomAccessLabel]"
            colWORecipientName.ColumnName = "[WORecipientName]"
            colWORecipientEmail.ColumnName = "[WORecipientEmail]"
            colWOSubject.ColumnName = "[WOSubject]"
            colExchangeRateGroupID.ColumnName = "[ExchangeRateGroupID]"
            colAutoRecLastProcessDate.ColumnName = "[AutoRecLastProcessDate]"
            colIfu.ColumnName = "[IFU]"
            colPifu1.ColumnName = "[PIFU1]"
            colPifu2.ColumnName = "[PIFU2]"
            colPifu3.ColumnName = "[PIFU3]"
            colPifu4.ColumnName = "[PIFU4]"
            colImpClientDesName1.ColumnName = "[ImpClientDesName1]"
            colImpClientDesEmail1.ColumnName = "[ImpClientDesEmail1]"
            colImpClientDesName2.ColumnName = "[ImpClientDesName2]"
            colImpClientDesEmail2.ColumnName = "[ImpClientDesEmail2]"
            colImpClientDesName3.ColumnName = "[ImpClientDesName3]"
            colImpClientDesEmail3.ColumnName = "[ImpClientDesEmail3]"
            colAifu.ColumnName = "[AIFU]"
            colImpClientDesName4.ColumnName = "[ImpClientDesName4]"
            colImpClientDesEmail4.ColumnName = "[ImpClientDesEmail4]"
            colImpClientDesName5.ColumnName = "[ImpClientDesName5]"
            colImpClientDesEmail5.ColumnName = "[ImpClientDesEmail5]"
            colMgmtARR.ColumnName = "[MgmtARR]"
            colImpEmailAll.ColumnName = "[ImpEmailAll]"
            colSecurityPasswordExpireDays.ColumnName = "[SecurityPasswordExpireDays]"
            colSecurityInactivityLockoutDays.ColumnName = "[SecurityInactivityLockoutDays]"
            colSecurityInactivityLockoutRemindDays.ColumnName = "[SecurityInactivityLockoutRemindDays]"
            colSecurityPasswordMinimumLength.ColumnName = "[SecurityPasswordMinimumLength]"
            colSecurityPasswordTypeId.ColumnName = "[SecurityPasswordTypeId]"
            colDataTransferPackageId.ColumnName = "[DataTransferPackageId]"
            colDataTransferPassword.ColumnName = "[DataTransferPassword]"
            colDataTransferEncryptionKey.ColumnName = "[DataTransferEncryptionKey]"
            colSecurityAllowChangePassword.ColumnName = "[SecurityAllowChangePassword]"
            colReclassificationEmailSentDate.ColumnName = "[ReclassificationEmailSentDate]"
            colReclassificationEmailFollowUpDate.ColumnName = "[ReclassificationEmailFollowUpDate]"
            colReclassificationCompletionDate.ColumnName = "[ReclassificationCompletionDate]"
            colReclassificationLinkGUID.ColumnName = "[ReclassificationLinkGUID]"
            colLastReclassificationCompletionDate.ColumnName = "[LastReclassificationCompletionDate]"
            colSysUserCreated.ColumnName = "[SysUserCreated]"
            colSysDateCreated.ColumnName = "[SysDateCreated]"
            colSysUserModified.ColumnName = "[SysUserModified]"
            colSysDateModified.ColumnName = "[SysDateModified]"
            colClientId.ColumnName = "[ClientId]"
            colDataTransferPgpEnabled.ColumnName = "[DataTransferPgpEnabled]"
            colDataTransferPgpPublicKey.ColumnName = "[DataTransferPgpPublicKey]"
            colDataTransferFtpUrl.ColumnName = "[DataTransferFtpUrl]"
            colDataTransferFtpUserName.ColumnName = "[DataTransferFtpUserName]"
            colDataTransferFtpPassword.ColumnName = "[DataTransferFtpPassword]"
            colDataTransferPgpFileExtension.ColumnName = "[DataTransferPgpFileExtension]"
            colDataTransferFtpEnabled.ColumnName = "[DataTransferFtpEnabled]"
            colDataTransferRetrievalDate.ColumnName = "[DataTransferRetrievalDate]"
            colDefaultMetaCurrencyID.ColumnName = "[DefaultMetaCurrencyID]"
            colARRRolloutOption.ColumnName = "[ARRRolloutOption]"
            colARRRolloutOptionDesc.ColumnName = "[ARRRolloutOptionDesc]"
            colImpairmentStatus.ColumnName = "[ImpairmentStatus]"
            colImpairmentSpecialHandling.ColumnName = "[ImpairmentSpecialHandling]"
            colImpairmentSpecialHandlingDesc.ColumnName = "[ImpairmentSpecialHandlingDesc]"
            colDataTransferFtpLocalFolder.ColumnName = "[DataTransferFtpLocalFolder]"
            colDataTransferFileNameFormatString.ColumnName = "[DataTransferFileNameFormatString]"
            colDataTransferFtpMonthJson.ColumnName = "[DataTransferFtpMonthJson]"
            colDataTransferFtpDayJson.ColumnName = "[DataTransferFtpDayJson]"
            colIndustryGroup.ColumnName = "[IndustryGroup]"
            colMajorGroup.ColumnName = "[MajorGroup]"
            colSpecificGroup.ColumnName = "[SpecificGroup]"

            _Members.Add("colCldbname", colCldbname)
            _Members.Add("colClientname", colClientname)
            _Members.Add("colFeatures", colFeatures)
            _Members.Add("colFileprefix", colFileprefix)
            _Members.Add("colClientdesigneenotify", colClientdesigneenotify)
            _Members.Add("colClientdesigneename", colClientdesigneename)
            _Members.Add("colClientdesigneeemail", colClientdesigneeemail)
            _Members.Add("colActive", colActive)
            _Members.Add("colRecrespemail", colRecrespemail)
            _Members.Add("colRecautofollowup", colRecautofollowup)
            _Members.Add("colRecfollowup1", colRecfollowup1)
            _Members.Add("colRecfollowup2", colRecfollowup2)
            _Members.Add("colRecfollowup3", colRecfollowup3)
            _Members.Add("colDatatransfer", colDatatransfer)
            _Members.Add("colAutoRecStartDate", colAutoRecStartDate)
            _Members.Add("colAutoRecComments", colAutoRecComments)
            _Members.Add("colFireRatingKeyID", colFireRatingKeyID)
            _Members.Add("colBMRatingKeyID", colBMRatingKeyID)
            _Members.Add("colCustomAccessLabel", colCustomAccessLabel)
            _Members.Add("colWORecipientName", colWORecipientName)
            _Members.Add("colWORecipientEmail", colWORecipientEmail)
            _Members.Add("colWOSubject", colWOSubject)
            _Members.Add("colExchangeRateGroupID", colExchangeRateGroupID)
            _Members.Add("colAutoRecLastProcessDate", colAutoRecLastProcessDate)
            _Members.Add("colIfu", colIfu)
            _Members.Add("colPifu1", colPifu1)
            _Members.Add("colPifu2", colPifu2)
            _Members.Add("colPifu3", colPifu3)
            _Members.Add("colPifu4", colPifu4)
            _Members.Add("colImpClientDesName1", colImpClientDesName1)
            _Members.Add("colImpClientDesEmail1", colImpClientDesEmail1)
            _Members.Add("colImpClientDesName2", colImpClientDesName2)
            _Members.Add("colImpClientDesEmail2", colImpClientDesEmail2)
            _Members.Add("colImpClientDesName3", colImpClientDesName3)
            _Members.Add("colImpClientDesEmail3", colImpClientDesEmail3)
            _Members.Add("colAifu", colAifu)
            _Members.Add("colImpClientDesName4", colImpClientDesName4)
            _Members.Add("colImpClientDesEmail4", colImpClientDesEmail4)
            _Members.Add("colImpClientDesName5", colImpClientDesName5)
            _Members.Add("colImpClientDesEmail5", colImpClientDesEmail5)
            _Members.Add("colMgmtARR", colMgmtARR)
            _Members.Add("colImpEmailAll", colImpEmailAll)
            _Members.Add("colSecurityPasswordExpireDays", colSecurityPasswordExpireDays)
            _Members.Add("colSecurityInactivityLockoutDays", colSecurityInactivityLockoutDays)
            _Members.Add("colSecurityInactivityLockoutRemindDays", colSecurityInactivityLockoutRemindDays)
            _Members.Add("colSecurityPasswordMinimumLength", colSecurityPasswordMinimumLength)
            _Members.Add("colSecurityPasswordTypeId", colSecurityPasswordTypeId)
            _Members.Add("colDataTransferPackageId", colDataTransferPackageId)
            _Members.Add("colDataTransferPassword", colDataTransferPassword)
            _Members.Add("colDataTransferEncryptionKey", colDataTransferEncryptionKey)
            _Members.Add("colSecurityAllowChangePassword", colSecurityAllowChangePassword)
            _Members.Add("colReclassificationEmailSentDate", colReclassificationEmailSentDate)
            _Members.Add("colReclassificationEmailFollowUpDate", colReclassificationEmailFollowUpDate)
            _Members.Add("colReclassificationCompletionDate", colReclassificationCompletionDate)
            _Members.Add("colReclassificationLinkGUID", colReclassificationLinkGUID)
            _Members.Add("colLastReclassificationCompletionDate", colLastReclassificationCompletionDate)
            _Members.Add("colSysUserCreated", colSysUserCreated)
            _Members.Add("colSysDateCreated", colSysDateCreated)
            _Members.Add("colSysUserModified", colSysUserModified)
            _Members.Add("colSysDateModified", colSysDateModified)
            _Members.Add("colClientId", colClientId)
            _Members.Add("colDataTransferPgpEnabled", colDataTransferPgpEnabled)
            _Members.Add("colDataTransferPgpPublicKey", colDataTransferPgpPublicKey)
            _Members.Add("colDataTransferFtpUrl", colDataTransferFtpUrl)
            _Members.Add("colDataTransferFtpUserName", colDataTransferFtpUserName)
            _Members.Add("colDataTransferFtpPassword", colDataTransferFtpPassword)
            _Members.Add("colDataTransferPgpFileExtension", colDataTransferPgpFileExtension)
            _Members.Add("colDataTransferFtpEnabled", colDataTransferFtpEnabled)
            _Members.Add("colDataTransferRetrievalDate", colDataTransferRetrievalDate)
            _Members.Add("colDefaultMetaCurrencyID", colDefaultMetaCurrencyID)
            _Members.Add("colARRRolloutOption", colARRRolloutOption)
            _Members.Add("colARRRolloutOptionDesc", colARRRolloutOptionDesc)
            _Members.Add("colImpairmentStatus", colImpairmentStatus)
            _Members.Add("colImpairmentSpecialHandling", colImpairmentSpecialHandling)
            _Members.Add("colImpairmentSpecialHandlingDesc", colImpairmentSpecialHandlingDesc)
            _Members.Add("colDataTransferFtpLocalFolder", colDataTransferFtpLocalFolder)
            _Members.Add("colDataTransferFileNameFormatString", colDataTransferFileNameFormatString)
            _Members.Add("colDataTransferFtpMonthJson", colDataTransferFtpMonthJson)
            _Members.Add("colDataTransferFtpDayJson", colDataTransferFtpDayJson)
            _Members.Add("colIndustryGroup", colIndustryGroup)
            _Members.Add("colMajorGroup", colMajorGroup)
            _Members.Add("colSpecificGroup", colSpecificGroup)
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
                Case "colClientname"
                    Return "[clientname]"
                Case "colFeatures"
                    Return "[features]"
                Case "colFileprefix"
                    Return "[fileprefix]"
                Case "colClientdesigneenotify"
                    Return "[clientdesigneenotify]"
                Case "colClientdesigneename"
                    Return "[clientdesigneename]"
                Case "colClientdesigneeemail"
                    Return "[clientdesigneeemail]"
                Case "colActive"
                    Return "[580active]"
                Case "colRecrespemail"
                    Return "[recrespemail]"
                Case "colRecautofollowup"
                    Return "[recautofollowup]"
                Case "colRecfollowup1"
                    Return "[recfollowup1]"
                Case "colRecfollowup2"
                    Return "[recfollowup2]"
                Case "colRecfollowup3"
                    Return "[recfollowup3]"
                Case "colDatatransfer"
                    Return "[datatransfer]"
                Case "colAutoRecStartDate"
                    Return "[AutoRecStartDate]"
                Case "colAutoRecComments"
                    Return "[AutoRecComments]"
                Case "colFireRatingKeyID"
                    Return "[FireRatingKeyID]"
                Case "colBMRatingKeyID"
                    Return "[BMRatingKeyID]"
                Case "colCustomAccessLabel"
                    Return "[CustomAccessLabel]"
                Case "colWORecipientName"
                    Return "[WORecipientName]"
                Case "colWORecipientEmail"
                    Return "[WORecipientEmail]"
                Case "colWOSubject"
                    Return "[WOSubject]"
                Case "colExchangeRateGroupID"
                    Return "[ExchangeRateGroupID]"
                Case "colAutoRecLastProcessDate"
                    Return "[AutoRecLastProcessDate]"
                Case "colIfu"
                    Return "[IFU]"
                Case "colPifu1"
                    Return "[PIFU1]"
                Case "colPifu2"
                    Return "[PIFU2]"
                Case "colPifu3"
                    Return "[PIFU3]"
                Case "colPifu4"
                    Return "[PIFU4]"
                Case "colImpClientDesName1"
                    Return "[ImpClientDesName1]"
                Case "colImpClientDesEmail1"
                    Return "[ImpClientDesEmail1]"
                Case "colImpClientDesName2"
                    Return "[ImpClientDesName2]"
                Case "colImpClientDesEmail2"
                    Return "[ImpClientDesEmail2]"
                Case "colImpClientDesName3"
                    Return "[ImpClientDesName3]"
                Case "colImpClientDesEmail3"
                    Return "[ImpClientDesEmail3]"
                Case "colAifu"
                    Return "[AIFU]"
                Case "colImpClientDesName4"
                    Return "[ImpClientDesName4]"
                Case "colImpClientDesEmail4"
                    Return "[ImpClientDesEmail4]"
                Case "colImpClientDesName5"
                    Return "[ImpClientDesName5]"
                Case "colImpClientDesEmail5"
                    Return "[ImpClientDesEmail5]"
                Case "colMgmtARR"
                    Return "[MgmtARR]"
                Case "colImpEmailAll"
                    Return "[ImpEmailAll]"
                Case "colSecurityPasswordExpireDays"
                    Return "[SecurityPasswordExpireDays]"
                Case "colSecurityInactivityLockoutDays"
                    Return "[SecurityInactivityLockoutDays]"
                Case "colSecurityInactivityLockoutRemindDays"
                    Return "[SecurityInactivityLockoutRemindDays]"
                Case "colSecurityPasswordMinimumLength"
                    Return "[SecurityPasswordMinimumLength]"
                Case "colSecurityPasswordTypeId"
                    Return "[SecurityPasswordTypeId]"
                Case "colDataTransferPackageId"
                    Return "[DataTransferPackageId]"
                Case "colDataTransferPassword"
                    Return "[DataTransferPassword]"
                Case "colDataTransferEncryptionKey"
                    Return "[DataTransferEncryptionKey]"
                Case "colSecurityAllowChangePassword"
                    Return "[SecurityAllowChangePassword]"
                Case "colReclassificationEmailSentDate"
                    Return "[ReclassificationEmailSentDate]"
                Case "colReclassificationEmailFollowUpDate"
                    Return "[ReclassificationEmailFollowUpDate]"
                Case "colReclassificationCompletionDate"
                    Return "[ReclassificationCompletionDate]"
                Case "colReclassificationLinkGUID"
                    Return "[ReclassificationLinkGUID]"
                Case "colLastReclassificationCompletionDate"
                    Return "[LastReclassificationCompletionDate]"
                Case "colSysUserCreated"
                    Return "[SysUserCreated]"
                Case "colSysDateCreated"
                    Return "[SysDateCreated]"
                Case "colSysUserModified"
                    Return "[SysUserModified]"
                Case "colSysDateModified"
                    Return "[SysDateModified]"
                Case "colClientId"
                    Return "[ClientId]"
                Case "colDataTransferPgpEnabled"
                    Return "[DataTransferPgpEnabled]"
                Case "colDataTransferPgpPublicKey"
                    Return "[DataTransferPgpPublicKey]"
                Case "colDataTransferFtpUrl"
                    Return "[DataTransferFtpUrl]"
                Case "colDataTransferFtpUserName"
                    Return "[DataTransferFtpUserName]"
                Case "colDataTransferFtpPassword"
                    Return "[DataTransferFtpPassword]"
                Case "colDataTransferPgpFileExtension"
                    Return "[DataTransferPgpFileExtension]"
                Case "colDataTransferFtpEnabled"
                    Return "[DataTransferFtpEnabled]"
                Case "colDataTransferRetrievalDate"
                    Return "[DataTransferRetrievalDate]"
                Case "colDefaultMetaCurrencyID"
                    Return "[DefaultMetaCurrencyID]"
                Case "colARRRolloutOption"
                    Return "[ARRRolloutOption]"
                Case "colARRRolloutOptionDesc"
                    Return "[ARRRolloutOptionDesc]"
                Case "colImpairmentStatus"
                    Return "[ImpairmentStatus]"
                Case "colImpairmentSpecialHandling"
                    Return "[ImpairmentSpecialHandling]"
                Case "colImpairmentSpecialHandlingDesc"
                    Return "[ImpairmentSpecialHandlingDesc]"
                Case "colDataTransferFtpLocalFolder"
                    Return "[DataTransferFtpLocalFolder]"
                Case "colDataTransferFileNameFormatString"
                    Return "[DataTransferFileNameFormatString]"
                Case "colDataTransferFtpMonthJson"
                    Return "[DataTransferFtpMonthJson]"
                Case "colDataTransferFtpDayJson"
                    Return "[DataTransferFtpDayJson]"
                Case "colIndustryGroup"
                    Return "[IndustryGroup]"
                Case "colMajorGroup"
                    Return "[MajorGroup]"
                Case "colSpecificGroup"
                    Return "[SpecificGroup]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[cldbname]", "cldbname", "Cldbname", "colCldbname"  
                    Return "colCldbname"
                Case "[clientname]", "clientname", "Clientname", "colClientname"  
                    Return "colClientname"
                Case "[features]", "features", "Features", "colFeatures"  
                    Return "colFeatures"
                Case "[fileprefix]", "fileprefix", "Fileprefix", "colFileprefix"  
                    Return "colFileprefix"
                Case "[clientdesigneenotify]", "clientdesigneenotify", "Clientdesigneenotify", "colClientdesigneenotify"  
                    Return "colClientdesigneenotify"
                Case "[clientdesigneename]", "clientdesigneename", "Clientdesigneename", "colClientdesigneename"  
                    Return "colClientdesigneename"
                Case "[clientdesigneeemail]", "clientdesigneeemail", "Clientdesigneeemail", "colClientdesigneeemail"  
                    Return "colClientdesigneeemail"
                Case "[580active]", "580active", "Active", "colActive"  
                    Return "colActive"
                Case "[recrespemail]", "recrespemail", "Recrespemail", "colRecrespemail"  
                    Return "colRecrespemail"
                Case "[recautofollowup]", "recautofollowup", "Recautofollowup", "colRecautofollowup"  
                    Return "colRecautofollowup"
                Case "[recfollowup1]", "recfollowup1", "Recfollowup1", "colRecfollowup1"  
                    Return "colRecfollowup1"
                Case "[recfollowup2]", "recfollowup2", "Recfollowup2", "colRecfollowup2"  
                    Return "colRecfollowup2"
                Case "[recfollowup3]", "recfollowup3", "Recfollowup3", "colRecfollowup3"  
                    Return "colRecfollowup3"
                Case "[datatransfer]", "datatransfer", "Datatransfer", "colDatatransfer"  
                    Return "colDatatransfer"
                Case "[AutoRecStartDate]", "AutoRecStartDate", "AutoRecStartDate", "colAutoRecStartDate"  
                    Return "colAutoRecStartDate"
                Case "[AutoRecComments]", "AutoRecComments", "AutoRecComments", "colAutoRecComments"  
                    Return "colAutoRecComments"
                Case "[FireRatingKeyID]", "FireRatingKeyID", "FireRatingKeyID", "colFireRatingKeyID"  
                    Return "colFireRatingKeyID"
                Case "[BMRatingKeyID]", "BMRatingKeyID", "BMRatingKeyID", "colBMRatingKeyID"  
                    Return "colBMRatingKeyID"
                Case "[CustomAccessLabel]", "CustomAccessLabel", "CustomAccessLabel", "colCustomAccessLabel"  
                    Return "colCustomAccessLabel"
                Case "[WORecipientName]", "WORecipientName", "WORecipientName", "colWORecipientName"  
                    Return "colWORecipientName"
                Case "[WORecipientEmail]", "WORecipientEmail", "WORecipientEmail", "colWORecipientEmail"  
                    Return "colWORecipientEmail"
                Case "[WOSubject]", "WOSubject", "WOSubject", "colWOSubject"  
                    Return "colWOSubject"
                Case "[ExchangeRateGroupID]", "ExchangeRateGroupID", "ExchangeRateGroupID", "colExchangeRateGroupID"  
                    Return "colExchangeRateGroupID"
                Case "[AutoRecLastProcessDate]", "AutoRecLastProcessDate", "AutoRecLastProcessDate", "colAutoRecLastProcessDate"  
                    Return "colAutoRecLastProcessDate"
                Case "[IFU]", "IFU", "Ifu", "colIfu"  
                    Return "colIfu"
                Case "[PIFU1]", "PIFU1", "Pifu1", "colPifu1"  
                    Return "colPifu1"
                Case "[PIFU2]", "PIFU2", "Pifu2", "colPifu2"  
                    Return "colPifu2"
                Case "[PIFU3]", "PIFU3", "Pifu3", "colPifu3"  
                    Return "colPifu3"
                Case "[PIFU4]", "PIFU4", "Pifu4", "colPifu4"  
                    Return "colPifu4"
                Case "[ImpClientDesName1]", "ImpClientDesName1", "ImpClientDesName1", "colImpClientDesName1"  
                    Return "colImpClientDesName1"
                Case "[ImpClientDesEmail1]", "ImpClientDesEmail1", "ImpClientDesEmail1", "colImpClientDesEmail1"  
                    Return "colImpClientDesEmail1"
                Case "[ImpClientDesName2]", "ImpClientDesName2", "ImpClientDesName2", "colImpClientDesName2"  
                    Return "colImpClientDesName2"
                Case "[ImpClientDesEmail2]", "ImpClientDesEmail2", "ImpClientDesEmail2", "colImpClientDesEmail2"  
                    Return "colImpClientDesEmail2"
                Case "[ImpClientDesName3]", "ImpClientDesName3", "ImpClientDesName3", "colImpClientDesName3"  
                    Return "colImpClientDesName3"
                Case "[ImpClientDesEmail3]", "ImpClientDesEmail3", "ImpClientDesEmail3", "colImpClientDesEmail3"  
                    Return "colImpClientDesEmail3"
                Case "[AIFU]", "AIFU", "Aifu", "colAifu"  
                    Return "colAifu"
                Case "[ImpClientDesName4]", "ImpClientDesName4", "ImpClientDesName4", "colImpClientDesName4"  
                    Return "colImpClientDesName4"
                Case "[ImpClientDesEmail4]", "ImpClientDesEmail4", "ImpClientDesEmail4", "colImpClientDesEmail4"  
                    Return "colImpClientDesEmail4"
                Case "[ImpClientDesName5]", "ImpClientDesName5", "ImpClientDesName5", "colImpClientDesName5"  
                    Return "colImpClientDesName5"
                Case "[ImpClientDesEmail5]", "ImpClientDesEmail5", "ImpClientDesEmail5", "colImpClientDesEmail5"  
                    Return "colImpClientDesEmail5"
                Case "[MgmtARR]", "MgmtARR", "MgmtARR", "colMgmtARR"  
                    Return "colMgmtARR"
                Case "[ImpEmailAll]", "ImpEmailAll", "ImpEmailAll", "colImpEmailAll"  
                    Return "colImpEmailAll"
                Case "[SecurityPasswordExpireDays]", "SecurityPasswordExpireDays", "SecurityPasswordExpireDays", "colSecurityPasswordExpireDays"  
                    Return "colSecurityPasswordExpireDays"
                Case "[SecurityInactivityLockoutDays]", "SecurityInactivityLockoutDays", "SecurityInactivityLockoutDays", "colSecurityInactivityLockoutDays"  
                    Return "colSecurityInactivityLockoutDays"
                Case "[SecurityInactivityLockoutRemindDays]", "SecurityInactivityLockoutRemindDays", "SecurityInactivityLockoutRemindDays", "colSecurityInactivityLockoutRemindDays"  
                    Return "colSecurityInactivityLockoutRemindDays"
                Case "[SecurityPasswordMinimumLength]", "SecurityPasswordMinimumLength", "SecurityPasswordMinimumLength", "colSecurityPasswordMinimumLength"  
                    Return "colSecurityPasswordMinimumLength"
                Case "[SecurityPasswordTypeId]", "SecurityPasswordTypeId", "SecurityPasswordTypeId", "colSecurityPasswordTypeId"  
                    Return "colSecurityPasswordTypeId"
                Case "[DataTransferPackageId]", "DataTransferPackageId", "DataTransferPackageId", "colDataTransferPackageId"  
                    Return "colDataTransferPackageId"
                Case "[DataTransferPassword]", "DataTransferPassword", "DataTransferPassword", "colDataTransferPassword"  
                    Return "colDataTransferPassword"
                Case "[DataTransferEncryptionKey]", "DataTransferEncryptionKey", "DataTransferEncryptionKey", "colDataTransferEncryptionKey"  
                    Return "colDataTransferEncryptionKey"
                Case "[SecurityAllowChangePassword]", "SecurityAllowChangePassword", "SecurityAllowChangePassword", "colSecurityAllowChangePassword"  
                    Return "colSecurityAllowChangePassword"
                Case "[ReclassificationEmailSentDate]", "ReclassificationEmailSentDate", "ReclassificationEmailSentDate", "colReclassificationEmailSentDate"  
                    Return "colReclassificationEmailSentDate"
                Case "[ReclassificationEmailFollowUpDate]", "ReclassificationEmailFollowUpDate", "ReclassificationEmailFollowUpDate", "colReclassificationEmailFollowUpDate"  
                    Return "colReclassificationEmailFollowUpDate"
                Case "[ReclassificationCompletionDate]", "ReclassificationCompletionDate", "ReclassificationCompletionDate", "colReclassificationCompletionDate"  
                    Return "colReclassificationCompletionDate"
                Case "[ReclassificationLinkGUID]", "ReclassificationLinkGUID", "ReclassificationLinkGUID", "colReclassificationLinkGUID"  
                    Return "colReclassificationLinkGUID"
                Case "[LastReclassificationCompletionDate]", "LastReclassificationCompletionDate", "LastReclassificationCompletionDate", "colLastReclassificationCompletionDate"  
                    Return "colLastReclassificationCompletionDate"
                Case "[SysUserCreated]", "SysUserCreated", "SysUserCreated", "colSysUserCreated"  
                    Return "colSysUserCreated"
                Case "[SysDateCreated]", "SysDateCreated", "SysDateCreated", "colSysDateCreated"  
                    Return "colSysDateCreated"
                Case "[SysUserModified]", "SysUserModified", "SysUserModified", "colSysUserModified"  
                    Return "colSysUserModified"
                Case "[SysDateModified]", "SysDateModified", "SysDateModified", "colSysDateModified"  
                    Return "colSysDateModified"
                Case "[ClientId]", "ClientId", "ClientId", "colClientId"  
                    Return "colClientId"
                Case "[DataTransferPgpEnabled]", "DataTransferPgpEnabled", "DataTransferPgpEnabled", "colDataTransferPgpEnabled"  
                    Return "colDataTransferPgpEnabled"
                Case "[DataTransferPgpPublicKey]", "DataTransferPgpPublicKey", "DataTransferPgpPublicKey", "colDataTransferPgpPublicKey"  
                    Return "colDataTransferPgpPublicKey"
                Case "[DataTransferFtpUrl]", "DataTransferFtpUrl", "DataTransferFtpUrl", "colDataTransferFtpUrl"  
                    Return "colDataTransferFtpUrl"
                Case "[DataTransferFtpUserName]", "DataTransferFtpUserName", "DataTransferFtpUserName", "colDataTransferFtpUserName"  
                    Return "colDataTransferFtpUserName"
                Case "[DataTransferFtpPassword]", "DataTransferFtpPassword", "DataTransferFtpPassword", "colDataTransferFtpPassword"  
                    Return "colDataTransferFtpPassword"
                Case "[DataTransferPgpFileExtension]", "DataTransferPgpFileExtension", "DataTransferPgpFileExtension", "colDataTransferPgpFileExtension"  
                    Return "colDataTransferPgpFileExtension"
                Case "[DataTransferFtpEnabled]", "DataTransferFtpEnabled", "DataTransferFtpEnabled", "colDataTransferFtpEnabled"  
                    Return "colDataTransferFtpEnabled"
                Case "[DataTransferRetrievalDate]", "DataTransferRetrievalDate", "DataTransferRetrievalDate", "colDataTransferRetrievalDate"  
                    Return "colDataTransferRetrievalDate"
                Case "[DefaultMetaCurrencyID]", "DefaultMetaCurrencyID", "DefaultMetaCurrencyID", "colDefaultMetaCurrencyID"  
                    Return "colDefaultMetaCurrencyID"
                Case "[ARRRolloutOption]", "ARRRolloutOption", "ARRRolloutOption", "colARRRolloutOption"  
                    Return "colARRRolloutOption"
                Case "[ARRRolloutOptionDesc]", "ARRRolloutOptionDesc", "ARRRolloutOptionDesc", "colARRRolloutOptionDesc"  
                    Return "colARRRolloutOptionDesc"
                Case "[ImpairmentStatus]", "ImpairmentStatus", "ImpairmentStatus", "colImpairmentStatus"  
                    Return "colImpairmentStatus"
                Case "[ImpairmentSpecialHandling]", "ImpairmentSpecialHandling", "ImpairmentSpecialHandling", "colImpairmentSpecialHandling"  
                    Return "colImpairmentSpecialHandling"
                Case "[ImpairmentSpecialHandlingDesc]", "ImpairmentSpecialHandlingDesc", "ImpairmentSpecialHandlingDesc", "colImpairmentSpecialHandlingDesc"  
                    Return "colImpairmentSpecialHandlingDesc"
                Case "[DataTransferFtpLocalFolder]", "DataTransferFtpLocalFolder", "DataTransferFtpLocalFolder", "colDataTransferFtpLocalFolder"  
                    Return "colDataTransferFtpLocalFolder"
                Case "[DataTransferFileNameFormatString]", "DataTransferFileNameFormatString", "DataTransferFileNameFormatString", "colDataTransferFileNameFormatString"  
                    Return "colDataTransferFileNameFormatString"
                Case "[DataTransferFtpMonthJson]", "DataTransferFtpMonthJson", "DataTransferFtpMonthJson", "colDataTransferFtpMonthJson"  
                    Return "colDataTransferFtpMonthJson"
                Case "[DataTransferFtpDayJson]", "DataTransferFtpDayJson", "DataTransferFtpDayJson", "colDataTransferFtpDayJson"  
                    Return "colDataTransferFtpDayJson"
                Case "[IndustryGroup]", "IndustryGroup", "IndustryGroup", "colIndustryGroup"  
                    Return "colIndustryGroup"
                Case "[MajorGroup]", "MajorGroup", "MajorGroup", "colMajorGroup"  
                    Return "colMajorGroup"
                Case "[SpecificGroup]", "SpecificGroup", "SpecificGroup", "colSpecificGroup"  
                    Return "colSpecificGroup"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colCldbname"
                    Return "String"
                Case "colClientname"
                    Return "String"
                Case "colFeatures"
                    Return "String"
                Case "colFileprefix"
                    Return "String"
                Case "colClientdesigneenotify"
                    Return "Boolean"
                Case "colClientdesigneename"
                    Return "String"
                Case "colClientdesigneeemail"
                    Return "String"
                Case "colActive"
                    Return "Boolean"
                Case "colRecrespemail"
                    Return "String"
                Case "colRecautofollowup"
                    Return "Boolean"
                Case "colRecfollowup1"
                    Return "Integer"
                Case "colRecfollowup2"
                    Return "Integer"
                Case "colRecfollowup3"
                    Return "Integer"
                Case "colDatatransfer"
                    Return "String"
                Case "colAutoRecStartDate"
                    Return "DateTime"
                Case "colAutoRecComments"
                    Return "String"
                Case "colFireRatingKeyID"
                    Return "Byte"
                Case "colBMRatingKeyID"
                    Return "Byte"
                Case "colCustomAccessLabel"
                    Return "String"
                Case "colWORecipientName"
                    Return "String"
                Case "colWORecipientEmail"
                    Return "String"
                Case "colWOSubject"
                    Return "String"
                Case "colExchangeRateGroupID"
                    Return "Byte"
                Case "colAutoRecLastProcessDate"
                    Return "DateTime"
                Case "colIfu"
                    Return "Boolean"
                Case "colPifu1"
                    Return "Integer"
                Case "colPifu2"
                    Return "Integer"
                Case "colPifu3"
                    Return "Integer"
                Case "colPifu4"
                    Return "Integer"
                Case "colImpClientDesName1"
                    Return "String"
                Case "colImpClientDesEmail1"
                    Return "String"
                Case "colImpClientDesName2"
                    Return "String"
                Case "colImpClientDesEmail2"
                    Return "String"
                Case "colImpClientDesName3"
                    Return "String"
                Case "colImpClientDesEmail3"
                    Return "String"
                Case "colAifu"
                    Return "String"
                Case "colImpClientDesName4"
                    Return "String"
                Case "colImpClientDesEmail4"
                    Return "String"
                Case "colImpClientDesName5"
                    Return "String"
                Case "colImpClientDesEmail5"
                    Return "String"
                Case "colMgmtARR"
                    Return "Boolean"
                Case "colImpEmailAll"
                    Return "Boolean"
                Case "colSecurityPasswordExpireDays"
                    Return "Integer"
                Case "colSecurityInactivityLockoutDays"
                    Return "Integer"
                Case "colSecurityInactivityLockoutRemindDays"
                    Return "Integer"
                Case "colSecurityPasswordMinimumLength"
                    Return "Integer"
                Case "colSecurityPasswordTypeId"
                    Return "Integer"
                Case "colDataTransferPackageId"
                    Return "Integer"
                Case "colDataTransferPassword"
                    Return "String"
                Case "colDataTransferEncryptionKey"
                    Return "String"
                Case "colSecurityAllowChangePassword"
                    Return "Boolean"
                Case "colReclassificationEmailSentDate"
                    Return "DateTime"
                Case "colReclassificationEmailFollowUpDate"
                    Return "DateTime"
                Case "colReclassificationCompletionDate"
                    Return "DateTime"
                Case "colReclassificationLinkGUID"
                    Return "String"
                Case "colLastReclassificationCompletionDate"
                    Return "DateTime"
                Case "colSysUserCreated"
                    Return "String"
                Case "colSysDateCreated"
                    Return "DateTime"
                Case "colSysUserModified"
                    Return "String"
                Case "colSysDateModified"
                    Return "DateTime"
                Case "colClientId"
                    Return "Integer"
                Case "colDataTransferPgpEnabled"
                    Return "Boolean"
                Case "colDataTransferPgpPublicKey"
                    Return "String"
                Case "colDataTransferFtpUrl"
                    Return "String"
                Case "colDataTransferFtpUserName"
                    Return "String"
                Case "colDataTransferFtpPassword"
                    Return "String"
                Case "colDataTransferPgpFileExtension"
                    Return "String"
                Case "colDataTransferFtpEnabled"
                    Return "Boolean"
                Case "colDataTransferRetrievalDate"
                    Return "DateTime"
                Case "colDefaultMetaCurrencyID"
                    Return "Integer"
                Case "colARRRolloutOption"
                    Return "String"
                Case "colARRRolloutOptionDesc"
                    Return "String"
                Case "colImpairmentStatus"
                    Return "Boolean"
                Case "colImpairmentSpecialHandling"
                    Return "Boolean"
                Case "colImpairmentSpecialHandlingDesc"
                    Return "String"
                Case "colDataTransferFtpLocalFolder"
                    Return "String"
                Case "colDataTransferFileNameFormatString"
                    Return "String"
                Case "colDataTransferFtpMonthJson"
                    Return "String"
                Case "colDataTransferFtpDayJson"
                    Return "String"
                Case "colIndustryGroup"
                    Return "String"
                Case "colMajorGroup"
                    Return "String"
                Case "colSpecificGroup"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[clients]"
        End Function

        Private Function _FirstColumn() As String
            Return "[cldbname]"
        End Function

    End Class
End namespace

