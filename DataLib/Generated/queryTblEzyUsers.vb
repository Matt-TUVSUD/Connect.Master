'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblEzyUsers
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colUserID As New razor.UtilSQLServer.StringDataColumn
        Public colPassword As New razor.UtilSQLServer.StringDataColumn
        Public colFullName As New razor.UtilSQLServer.StringDataColumn
        Public colRiskManager As New razor.UtilSQLServer.BooleanDataColumn
        Public colDivisionManager As New razor.UtilSQLServer.BooleanDataColumn
        Public colDivision As New razor.UtilSQLServer.StringDataColumn
        Public colPlantManager As New razor.UtilSQLServer.BooleanDataColumn
        Public colPlant As New razor.UtilSQLServer.StringDataColumn
        Public colAdministrator As New razor.UtilSQLServer.BooleanDataColumn
        Public colDocumentAccess As New razor.UtilSQLServer.BooleanDataColumn
        Public colCustomAccess As New razor.UtilSQLServer.BooleanDataColumn
        Public colCustomAccessText As New razor.UtilSQLServer.StringDataColumn
        Public colOperatorStamp As New razor.UtilSQLServer.StringDataColumn
        Public colDateTimeStamp As New razor.UtilSQLServer.DateTimeDataColumn
        Public colPhone As New razor.UtilSQLServer.StringDataColumn
        Public colFax As New razor.UtilSQLServer.StringDataColumn
        Public colEmail As New razor.UtilSQLServer.StringDataColumn
        Public colNotificationStamp As New razor.UtilSQLServer.DateTimeDataColumn
        Public colActiveUser As New razor.UtilSQLServer.BooleanDataColumn
        Public colFilePrefix As New razor.UtilSQLServer.ShortDataColumn
        Public colLastLogin As New razor.UtilSQLServer.DateTimeDataColumn
        Public colLastPWChange As New razor.UtilSQLServer.DateTimeDataColumn
        Public colInternal As New razor.UtilSQLServer.BooleanDataColumn
        Public colComments As New razor.UtilSQLServer.StringDataColumn
        Public colRInit As New razor.UtilSQLServer.StringDataColumn
        Public colRfu1 As New razor.UtilSQLServer.StringDataColumn
        Public colRfu2 As New razor.UtilSQLServer.StringDataColumn
        Public colRfu3 As New razor.UtilSQLServer.StringDataColumn
        Public colRReport As New razor.UtilSQLServer.StringDataColumn
        Public colROverdue1 As New razor.UtilSQLServer.StringDataColumn
        Public colROverdue2 As New razor.UtilSQLServer.StringDataColumn
        Public colROverdue3 As New razor.UtilSQLServer.StringDataColumn
        Public colRActResp As New razor.UtilSQLServer.StringDataColumn
        Public colWo As New razor.UtilSQLServer.BooleanDataColumn
        Public colCalist As New razor.UtilSQLServer.StringDataColumn
        Public colDivlist As New razor.UtilSQLServer.StringDataColumn
        Public colLoclist As New razor.UtilSQLServer.StringDataColumn
        Public colThirdParty As New razor.UtilSQLServer.BooleanDataColumn
        Public colGRCAdministrator As New razor.UtilSQLServer.StringDataColumn
        Public colLastRecentUpdate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colEzyUserID As New razor.UtilSQLServer.IntegerDataColumn
        Public colAllowMaintLogin As New razor.UtilSQLServer.BooleanDataColumn
        Public colCCActive As New razor.UtilSQLServer.BooleanDataColumn
        Public colExpOverdue As New razor.UtilSQLServer.StringDataColumn
        Public colEzyGuid As New razor.UtilSQLServer.StringDataColumn
        Public colSecurityPasswordIsExpired As New razor.UtilSQLServer.BooleanDataColumn
        Public colSecurityAccountIsLockedOut As New razor.UtilSQLServer.BooleanDataColumn
        Public colAutoInactiveDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colSecurityInactivityReminderSentDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colMultipleUserType As New razor.UtilSQLServer.StringDataColumn
        Public colImport As New razor.UtilSQLServer.StringDataColumn
        Public colClientLocNoManager As New razor.UtilSQLServer.BooleanDataColumn
        Public colClientLocNoText As New razor.UtilSQLServer.StringDataColumn
        Public colFacilityManager As New razor.UtilSQLServer.BooleanDataColumn
        Public colFacilityText As New razor.UtilSQLServer.StringDataColumn
        Public colCityManager As New razor.UtilSQLServer.BooleanDataColumn
        Public colCityText As New razor.UtilSQLServer.StringDataColumn
        Public colStProvManager As New razor.UtilSQLServer.BooleanDataColumn
        Public colStProvText As New razor.UtilSQLServer.StringDataColumn
        Public colCountryManager As New razor.UtilSQLServer.BooleanDataColumn
        Public colCountryText As New razor.UtilSQLServer.StringDataColumn
        Public colRExpd As New razor.UtilSQLServer.StringDataColumn
        Public colCCOnly As New razor.UtilSQLServer.BooleanDataColumn
        Public colLoginId As New razor.UtilSQLServer.IntegerDataColumn
        Public colLastReclassificationDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colLastReclassificationByLoginID As New razor.UtilSQLServer.IntegerDataColumn
        Public colLastReclassificationAction As New razor.UtilSQLServer.IntegerDataColumn
        Public colMarkedForDeletionDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colReclassificationDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colReclassificationByLoginID As New razor.UtilSQLServer.IntegerDataColumn
        Public colReclassificationAction As New razor.UtilSQLServer.IntegerDataColumn
        Public colClientComment As New razor.UtilSQLServer.StringDataColumn
        Public colSysUserCreated As New razor.UtilSQLServer.StringDataColumn
        Public colSysDateCreated As New razor.UtilSQLServer.DateTimeDataColumn
        Public colSysUserModified As New razor.UtilSQLServer.StringDataColumn
        Public colSysDateModified As New razor.UtilSQLServer.DateTimeDataColumn
        Public colClientAdministration As New razor.UtilSQLServer.BooleanDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colUserID.ColumnName = "[UserID]"
            colPassword.ColumnName = "[Password]"
            colFullName.ColumnName = "[FullName]"
            colRiskManager.ColumnName = "[RiskManager]"
            colDivisionManager.ColumnName = "[DivisionManager]"
            colDivision.ColumnName = "[Division]"
            colPlantManager.ColumnName = "[PlantManager]"
            colPlant.ColumnName = "[Plant]"
            colAdministrator.ColumnName = "[Administrator]"
            colDocumentAccess.ColumnName = "[DocumentAccess]"
            colCustomAccess.ColumnName = "[CustomAccess]"
            colCustomAccessText.ColumnName = "[CustomAccessText]"
            colOperatorStamp.ColumnName = "[OperatorStamp]"
            colDateTimeStamp.ColumnName = "[DateTimeStamp]"
            colPhone.ColumnName = "[Phone]"
            colFax.ColumnName = "[Fax]"
            colEmail.ColumnName = "[Email]"
            colNotificationStamp.ColumnName = "[NotificationStamp]"
            colActiveUser.ColumnName = "[ActiveUser]"
            colFilePrefix.ColumnName = "[FilePrefix]"
            colLastLogin.ColumnName = "[LastLogin]"
            colLastPWChange.ColumnName = "[LastPWChange]"
            colInternal.ColumnName = "[Internal]"
            colComments.ColumnName = "[comments]"
            colRInit.ColumnName = "[RInit]"
            colRfu1.ColumnName = "[RFU1]"
            colRfu2.ColumnName = "[RFU2]"
            colRfu3.ColumnName = "[RFU3]"
            colRReport.ColumnName = "[RReport]"
            colROverdue1.ColumnName = "[ROverdue1]"
            colROverdue2.ColumnName = "[ROverdue2]"
            colROverdue3.ColumnName = "[ROverdue3]"
            colRActResp.ColumnName = "[RActResp]"
            colWo.ColumnName = "[WO]"
            colCalist.ColumnName = "[calist]"
            colDivlist.ColumnName = "[divlist]"
            colLoclist.ColumnName = "[loclist]"
            colThirdParty.ColumnName = "[ThirdParty]"
            colGRCAdministrator.ColumnName = "[GRCAdministrator]"
            colLastRecentUpdate.ColumnName = "[LastRecentUpdate]"
            colEzyUserID.ColumnName = "[EzyUserID]"
            colAllowMaintLogin.ColumnName = "[AllowMaintLogin]"
            colCCActive.ColumnName = "[CCActive]"
            colExpOverdue.ColumnName = "[ExpOverdue]"
            colEzyGuid.ColumnName = "[EzyGuid]"
            colSecurityPasswordIsExpired.ColumnName = "[SecurityPasswordIsExpired]"
            colSecurityAccountIsLockedOut.ColumnName = "[SecurityAccountIsLockedOut]"
            colAutoInactiveDate.ColumnName = "[AutoInactiveDate]"
            colSecurityInactivityReminderSentDate.ColumnName = "[SecurityInactivityReminderSentDate]"
            colMultipleUserType.ColumnName = "[MultipleUserType]"
            colImport.ColumnName = "[Import]"
            colClientLocNoManager.ColumnName = "[ClientLocNoManager]"
            colClientLocNoText.ColumnName = "[ClientLocNoText]"
            colFacilityManager.ColumnName = "[FacilityManager]"
            colFacilityText.ColumnName = "[FacilityText]"
            colCityManager.ColumnName = "[CityManager]"
            colCityText.ColumnName = "[CityText]"
            colStProvManager.ColumnName = "[StProvManager]"
            colStProvText.ColumnName = "[StProvText]"
            colCountryManager.ColumnName = "[CountryManager]"
            colCountryText.ColumnName = "[CountryText]"
            colRExpd.ColumnName = "[RExpd]"
            colCCOnly.ColumnName = "[CCOnly]"
            colLoginId.ColumnName = "[LoginId]"
            colLastReclassificationDate.ColumnName = "[LastReclassificationDate]"
            colLastReclassificationByLoginID.ColumnName = "[LastReclassificationByLoginID]"
            colLastReclassificationAction.ColumnName = "[LastReclassificationAction]"
            colMarkedForDeletionDate.ColumnName = "[MarkedForDeletionDate]"
            colReclassificationDate.ColumnName = "[ReclassificationDate]"
            colReclassificationByLoginID.ColumnName = "[ReclassificationByLoginID]"
            colReclassificationAction.ColumnName = "[ReclassificationAction]"
            colClientComment.ColumnName = "[ClientComment]"
            colSysUserCreated.ColumnName = "[SysUserCreated]"
            colSysDateCreated.ColumnName = "[SysDateCreated]"
            colSysUserModified.ColumnName = "[SysUserModified]"
            colSysDateModified.ColumnName = "[SysDateModified]"
            colClientAdministration.ColumnName = "[ClientAdministration]"

            _Members.Add("colUserID", colUserID)
            _Members.Add("colPassword", colPassword)
            _Members.Add("colFullName", colFullName)
            _Members.Add("colRiskManager", colRiskManager)
            _Members.Add("colDivisionManager", colDivisionManager)
            _Members.Add("colDivision", colDivision)
            _Members.Add("colPlantManager", colPlantManager)
            _Members.Add("colPlant", colPlant)
            _Members.Add("colAdministrator", colAdministrator)
            _Members.Add("colDocumentAccess", colDocumentAccess)
            _Members.Add("colCustomAccess", colCustomAccess)
            _Members.Add("colCustomAccessText", colCustomAccessText)
            _Members.Add("colOperatorStamp", colOperatorStamp)
            _Members.Add("colDateTimeStamp", colDateTimeStamp)
            _Members.Add("colPhone", colPhone)
            _Members.Add("colFax", colFax)
            _Members.Add("colEmail", colEmail)
            _Members.Add("colNotificationStamp", colNotificationStamp)
            _Members.Add("colActiveUser", colActiveUser)
            _Members.Add("colFilePrefix", colFilePrefix)
            _Members.Add("colLastLogin", colLastLogin)
            _Members.Add("colLastPWChange", colLastPWChange)
            _Members.Add("colInternal", colInternal)
            _Members.Add("colComments", colComments)
            _Members.Add("colRInit", colRInit)
            _Members.Add("colRfu1", colRfu1)
            _Members.Add("colRfu2", colRfu2)
            _Members.Add("colRfu3", colRfu3)
            _Members.Add("colRReport", colRReport)
            _Members.Add("colROverdue1", colROverdue1)
            _Members.Add("colROverdue2", colROverdue2)
            _Members.Add("colROverdue3", colROverdue3)
            _Members.Add("colRActResp", colRActResp)
            _Members.Add("colWo", colWo)
            _Members.Add("colCalist", colCalist)
            _Members.Add("colDivlist", colDivlist)
            _Members.Add("colLoclist", colLoclist)
            _Members.Add("colThirdParty", colThirdParty)
            _Members.Add("colGRCAdministrator", colGRCAdministrator)
            _Members.Add("colLastRecentUpdate", colLastRecentUpdate)
            _Members.Add("colEzyUserID", colEzyUserID)
            _Members.Add("colAllowMaintLogin", colAllowMaintLogin)
            _Members.Add("colCCActive", colCCActive)
            _Members.Add("colExpOverdue", colExpOverdue)
            _Members.Add("colEzyGuid", colEzyGuid)
            _Members.Add("colSecurityPasswordIsExpired", colSecurityPasswordIsExpired)
            _Members.Add("colSecurityAccountIsLockedOut", colSecurityAccountIsLockedOut)
            _Members.Add("colAutoInactiveDate", colAutoInactiveDate)
            _Members.Add("colSecurityInactivityReminderSentDate", colSecurityInactivityReminderSentDate)
            _Members.Add("colMultipleUserType", colMultipleUserType)
            _Members.Add("colImport", colImport)
            _Members.Add("colClientLocNoManager", colClientLocNoManager)
            _Members.Add("colClientLocNoText", colClientLocNoText)
            _Members.Add("colFacilityManager", colFacilityManager)
            _Members.Add("colFacilityText", colFacilityText)
            _Members.Add("colCityManager", colCityManager)
            _Members.Add("colCityText", colCityText)
            _Members.Add("colStProvManager", colStProvManager)
            _Members.Add("colStProvText", colStProvText)
            _Members.Add("colCountryManager", colCountryManager)
            _Members.Add("colCountryText", colCountryText)
            _Members.Add("colRExpd", colRExpd)
            _Members.Add("colCCOnly", colCCOnly)
            _Members.Add("colLoginId", colLoginId)
            _Members.Add("colLastReclassificationDate", colLastReclassificationDate)
            _Members.Add("colLastReclassificationByLoginID", colLastReclassificationByLoginID)
            _Members.Add("colLastReclassificationAction", colLastReclassificationAction)
            _Members.Add("colMarkedForDeletionDate", colMarkedForDeletionDate)
            _Members.Add("colReclassificationDate", colReclassificationDate)
            _Members.Add("colReclassificationByLoginID", colReclassificationByLoginID)
            _Members.Add("colReclassificationAction", colReclassificationAction)
            _Members.Add("colClientComment", colClientComment)
            _Members.Add("colSysUserCreated", colSysUserCreated)
            _Members.Add("colSysDateCreated", colSysDateCreated)
            _Members.Add("colSysUserModified", colSysUserModified)
            _Members.Add("colSysDateModified", colSysDateModified)
            _Members.Add("colClientAdministration", colClientAdministration)
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
                Case "colUserID"
                    Return "[UserID]"
                Case "colPassword"
                    Return "[Password]"
                Case "colFullName"
                    Return "[FullName]"
                Case "colRiskManager"
                    Return "[RiskManager]"
                Case "colDivisionManager"
                    Return "[DivisionManager]"
                Case "colDivision"
                    Return "[Division]"
                Case "colPlantManager"
                    Return "[PlantManager]"
                Case "colPlant"
                    Return "[Plant]"
                Case "colAdministrator"
                    Return "[Administrator]"
                Case "colDocumentAccess"
                    Return "[DocumentAccess]"
                Case "colCustomAccess"
                    Return "[CustomAccess]"
                Case "colCustomAccessText"
                    Return "[CustomAccessText]"
                Case "colOperatorStamp"
                    Return "[OperatorStamp]"
                Case "colDateTimeStamp"
                    Return "[DateTimeStamp]"
                Case "colPhone"
                    Return "[Phone]"
                Case "colFax"
                    Return "[Fax]"
                Case "colEmail"
                    Return "[Email]"
                Case "colNotificationStamp"
                    Return "[NotificationStamp]"
                Case "colActiveUser"
                    Return "[ActiveUser]"
                Case "colFilePrefix"
                    Return "[FilePrefix]"
                Case "colLastLogin"
                    Return "[LastLogin]"
                Case "colLastPWChange"
                    Return "[LastPWChange]"
                Case "colInternal"
                    Return "[Internal]"
                Case "colComments"
                    Return "[comments]"
                Case "colRInit"
                    Return "[RInit]"
                Case "colRfu1"
                    Return "[RFU1]"
                Case "colRfu2"
                    Return "[RFU2]"
                Case "colRfu3"
                    Return "[RFU3]"
                Case "colRReport"
                    Return "[RReport]"
                Case "colROverdue1"
                    Return "[ROverdue1]"
                Case "colROverdue2"
                    Return "[ROverdue2]"
                Case "colROverdue3"
                    Return "[ROverdue3]"
                Case "colRActResp"
                    Return "[RActResp]"
                Case "colWo"
                    Return "[WO]"
                Case "colCalist"
                    Return "[calist]"
                Case "colDivlist"
                    Return "[divlist]"
                Case "colLoclist"
                    Return "[loclist]"
                Case "colThirdParty"
                    Return "[ThirdParty]"
                Case "colGRCAdministrator"
                    Return "[GRCAdministrator]"
                Case "colLastRecentUpdate"
                    Return "[LastRecentUpdate]"
                Case "colEzyUserID"
                    Return "[EzyUserID]"
                Case "colAllowMaintLogin"
                    Return "[AllowMaintLogin]"
                Case "colCCActive"
                    Return "[CCActive]"
                Case "colExpOverdue"
                    Return "[ExpOverdue]"
                Case "colEzyGuid"
                    Return "[EzyGuid]"
                Case "colSecurityPasswordIsExpired"
                    Return "[SecurityPasswordIsExpired]"
                Case "colSecurityAccountIsLockedOut"
                    Return "[SecurityAccountIsLockedOut]"
                Case "colAutoInactiveDate"
                    Return "[AutoInactiveDate]"
                Case "colSecurityInactivityReminderSentDate"
                    Return "[SecurityInactivityReminderSentDate]"
                Case "colMultipleUserType"
                    Return "[MultipleUserType]"
                Case "colImport"
                    Return "[Import]"
                Case "colClientLocNoManager"
                    Return "[ClientLocNoManager]"
                Case "colClientLocNoText"
                    Return "[ClientLocNoText]"
                Case "colFacilityManager"
                    Return "[FacilityManager]"
                Case "colFacilityText"
                    Return "[FacilityText]"
                Case "colCityManager"
                    Return "[CityManager]"
                Case "colCityText"
                    Return "[CityText]"
                Case "colStProvManager"
                    Return "[StProvManager]"
                Case "colStProvText"
                    Return "[StProvText]"
                Case "colCountryManager"
                    Return "[CountryManager]"
                Case "colCountryText"
                    Return "[CountryText]"
                Case "colRExpd"
                    Return "[RExpd]"
                Case "colCCOnly"
                    Return "[CCOnly]"
                Case "colLoginId"
                    Return "[LoginId]"
                Case "colLastReclassificationDate"
                    Return "[LastReclassificationDate]"
                Case "colLastReclassificationByLoginID"
                    Return "[LastReclassificationByLoginID]"
                Case "colLastReclassificationAction"
                    Return "[LastReclassificationAction]"
                Case "colMarkedForDeletionDate"
                    Return "[MarkedForDeletionDate]"
                Case "colReclassificationDate"
                    Return "[ReclassificationDate]"
                Case "colReclassificationByLoginID"
                    Return "[ReclassificationByLoginID]"
                Case "colReclassificationAction"
                    Return "[ReclassificationAction]"
                Case "colClientComment"
                    Return "[ClientComment]"
                Case "colSysUserCreated"
                    Return "[SysUserCreated]"
                Case "colSysDateCreated"
                    Return "[SysDateCreated]"
                Case "colSysUserModified"
                    Return "[SysUserModified]"
                Case "colSysDateModified"
                    Return "[SysDateModified]"
                Case "colClientAdministration"
                    Return "[ClientAdministration]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[UserID]", "UserID", "UserID", "colUserID"  
                    Return "colUserID"
                Case "[Password]", "Password", "Password", "colPassword"  
                    Return "colPassword"
                Case "[FullName]", "FullName", "FullName", "colFullName"  
                    Return "colFullName"
                Case "[RiskManager]", "RiskManager", "RiskManager", "colRiskManager"  
                    Return "colRiskManager"
                Case "[DivisionManager]", "DivisionManager", "DivisionManager", "colDivisionManager"  
                    Return "colDivisionManager"
                Case "[Division]", "Division", "Division", "colDivision"  
                    Return "colDivision"
                Case "[PlantManager]", "PlantManager", "PlantManager", "colPlantManager"  
                    Return "colPlantManager"
                Case "[Plant]", "Plant", "Plant", "colPlant"  
                    Return "colPlant"
                Case "[Administrator]", "Administrator", "Administrator", "colAdministrator"  
                    Return "colAdministrator"
                Case "[DocumentAccess]", "DocumentAccess", "DocumentAccess", "colDocumentAccess"  
                    Return "colDocumentAccess"
                Case "[CustomAccess]", "CustomAccess", "CustomAccess", "colCustomAccess"  
                    Return "colCustomAccess"
                Case "[CustomAccessText]", "CustomAccessText", "CustomAccessText", "colCustomAccessText"  
                    Return "colCustomAccessText"
                Case "[OperatorStamp]", "OperatorStamp", "OperatorStamp", "colOperatorStamp"  
                    Return "colOperatorStamp"
                Case "[DateTimeStamp]", "DateTimeStamp", "DateTimeStamp", "colDateTimeStamp"  
                    Return "colDateTimeStamp"
                Case "[Phone]", "Phone", "Phone", "colPhone"  
                    Return "colPhone"
                Case "[Fax]", "Fax", "Fax", "colFax"  
                    Return "colFax"
                Case "[Email]", "Email", "Email", "colEmail"  
                    Return "colEmail"
                Case "[NotificationStamp]", "NotificationStamp", "NotificationStamp", "colNotificationStamp"  
                    Return "colNotificationStamp"
                Case "[ActiveUser]", "ActiveUser", "ActiveUser", "colActiveUser"  
                    Return "colActiveUser"
                Case "[FilePrefix]", "FilePrefix", "FilePrefix", "colFilePrefix"  
                    Return "colFilePrefix"
                Case "[LastLogin]", "LastLogin", "LastLogin", "colLastLogin"  
                    Return "colLastLogin"
                Case "[LastPWChange]", "LastPWChange", "LastPWChange", "colLastPWChange"  
                    Return "colLastPWChange"
                Case "[Internal]", "Internal", "Internal", "colInternal"  
                    Return "colInternal"
                Case "[comments]", "comments", "Comments", "colComments"  
                    Return "colComments"
                Case "[RInit]", "RInit", "RInit", "colRInit"  
                    Return "colRInit"
                Case "[RFU1]", "RFU1", "Rfu1", "colRfu1"  
                    Return "colRfu1"
                Case "[RFU2]", "RFU2", "Rfu2", "colRfu2"  
                    Return "colRfu2"
                Case "[RFU3]", "RFU3", "Rfu3", "colRfu3"  
                    Return "colRfu3"
                Case "[RReport]", "RReport", "RReport", "colRReport"  
                    Return "colRReport"
                Case "[ROverdue1]", "ROverdue1", "ROverdue1", "colROverdue1"  
                    Return "colROverdue1"
                Case "[ROverdue2]", "ROverdue2", "ROverdue2", "colROverdue2"  
                    Return "colROverdue2"
                Case "[ROverdue3]", "ROverdue3", "ROverdue3", "colROverdue3"  
                    Return "colROverdue3"
                Case "[RActResp]", "RActResp", "RActResp", "colRActResp"  
                    Return "colRActResp"
                Case "[WO]", "WO", "Wo", "colWo"  
                    Return "colWo"
                Case "[calist]", "calist", "Calist", "colCalist"  
                    Return "colCalist"
                Case "[divlist]", "divlist", "Divlist", "colDivlist"  
                    Return "colDivlist"
                Case "[loclist]", "loclist", "Loclist", "colLoclist"  
                    Return "colLoclist"
                Case "[ThirdParty]", "ThirdParty", "ThirdParty", "colThirdParty"  
                    Return "colThirdParty"
                Case "[GRCAdministrator]", "GRCAdministrator", "GRCAdministrator", "colGRCAdministrator"  
                    Return "colGRCAdministrator"
                Case "[LastRecentUpdate]", "LastRecentUpdate", "LastRecentUpdate", "colLastRecentUpdate"  
                    Return "colLastRecentUpdate"
                Case "[EzyUserID]", "EzyUserID", "EzyUserID", "colEzyUserID"  
                    Return "colEzyUserID"
                Case "[AllowMaintLogin]", "AllowMaintLogin", "AllowMaintLogin", "colAllowMaintLogin"  
                    Return "colAllowMaintLogin"
                Case "[CCActive]", "CCActive", "CCActive", "colCCActive"  
                    Return "colCCActive"
                Case "[ExpOverdue]", "ExpOverdue", "ExpOverdue", "colExpOverdue"  
                    Return "colExpOverdue"
                Case "[EzyGuid]", "EzyGuid", "EzyGuid", "colEzyGuid"  
                    Return "colEzyGuid"
                Case "[SecurityPasswordIsExpired]", "SecurityPasswordIsExpired", "SecurityPasswordIsExpired", "colSecurityPasswordIsExpired"  
                    Return "colSecurityPasswordIsExpired"
                Case "[SecurityAccountIsLockedOut]", "SecurityAccountIsLockedOut", "SecurityAccountIsLockedOut", "colSecurityAccountIsLockedOut"  
                    Return "colSecurityAccountIsLockedOut"
                Case "[AutoInactiveDate]", "AutoInactiveDate", "AutoInactiveDate", "colAutoInactiveDate"  
                    Return "colAutoInactiveDate"
                Case "[SecurityInactivityReminderSentDate]", "SecurityInactivityReminderSentDate", "SecurityInactivityReminderSentDate", "colSecurityInactivityReminderSentDate"  
                    Return "colSecurityInactivityReminderSentDate"
                Case "[MultipleUserType]", "MultipleUserType", "MultipleUserType", "colMultipleUserType"  
                    Return "colMultipleUserType"
                Case "[Import]", "Import", "Import", "colImport"  
                    Return "colImport"
                Case "[ClientLocNoManager]", "ClientLocNoManager", "ClientLocNoManager", "colClientLocNoManager"  
                    Return "colClientLocNoManager"
                Case "[ClientLocNoText]", "ClientLocNoText", "ClientLocNoText", "colClientLocNoText"  
                    Return "colClientLocNoText"
                Case "[FacilityManager]", "FacilityManager", "FacilityManager", "colFacilityManager"  
                    Return "colFacilityManager"
                Case "[FacilityText]", "FacilityText", "FacilityText", "colFacilityText"  
                    Return "colFacilityText"
                Case "[CityManager]", "CityManager", "CityManager", "colCityManager"  
                    Return "colCityManager"
                Case "[CityText]", "CityText", "CityText", "colCityText"  
                    Return "colCityText"
                Case "[StProvManager]", "StProvManager", "StProvManager", "colStProvManager"  
                    Return "colStProvManager"
                Case "[StProvText]", "StProvText", "StProvText", "colStProvText"  
                    Return "colStProvText"
                Case "[CountryManager]", "CountryManager", "CountryManager", "colCountryManager"  
                    Return "colCountryManager"
                Case "[CountryText]", "CountryText", "CountryText", "colCountryText"  
                    Return "colCountryText"
                Case "[RExpd]", "RExpd", "RExpd", "colRExpd"  
                    Return "colRExpd"
                Case "[CCOnly]", "CCOnly", "CCOnly", "colCCOnly"  
                    Return "colCCOnly"
                Case "[LoginId]", "LoginId", "LoginId", "colLoginId"  
                    Return "colLoginId"
                Case "[LastReclassificationDate]", "LastReclassificationDate", "LastReclassificationDate", "colLastReclassificationDate"  
                    Return "colLastReclassificationDate"
                Case "[LastReclassificationByLoginID]", "LastReclassificationByLoginID", "LastReclassificationByLoginID", "colLastReclassificationByLoginID"  
                    Return "colLastReclassificationByLoginID"
                Case "[LastReclassificationAction]", "LastReclassificationAction", "LastReclassificationAction", "colLastReclassificationAction"  
                    Return "colLastReclassificationAction"
                Case "[MarkedForDeletionDate]", "MarkedForDeletionDate", "MarkedForDeletionDate", "colMarkedForDeletionDate"  
                    Return "colMarkedForDeletionDate"
                Case "[ReclassificationDate]", "ReclassificationDate", "ReclassificationDate", "colReclassificationDate"  
                    Return "colReclassificationDate"
                Case "[ReclassificationByLoginID]", "ReclassificationByLoginID", "ReclassificationByLoginID", "colReclassificationByLoginID"  
                    Return "colReclassificationByLoginID"
                Case "[ReclassificationAction]", "ReclassificationAction", "ReclassificationAction", "colReclassificationAction"  
                    Return "colReclassificationAction"
                Case "[ClientComment]", "ClientComment", "ClientComment", "colClientComment"  
                    Return "colClientComment"
                Case "[SysUserCreated]", "SysUserCreated", "SysUserCreated", "colSysUserCreated"  
                    Return "colSysUserCreated"
                Case "[SysDateCreated]", "SysDateCreated", "SysDateCreated", "colSysDateCreated"  
                    Return "colSysDateCreated"
                Case "[SysUserModified]", "SysUserModified", "SysUserModified", "colSysUserModified"  
                    Return "colSysUserModified"
                Case "[SysDateModified]", "SysDateModified", "SysDateModified", "colSysDateModified"  
                    Return "colSysDateModified"
                Case "[ClientAdministration]", "ClientAdministration", "ClientAdministration", "colClientAdministration"  
                    Return "colClientAdministration"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colUserID"
                    Return "String"
                Case "colPassword"
                    Return "String"
                Case "colFullName"
                    Return "String"
                Case "colRiskManager"
                    Return "Boolean"
                Case "colDivisionManager"
                    Return "Boolean"
                Case "colDivision"
                    Return "String"
                Case "colPlantManager"
                    Return "Boolean"
                Case "colPlant"
                    Return "String"
                Case "colAdministrator"
                    Return "Boolean"
                Case "colDocumentAccess"
                    Return "Boolean"
                Case "colCustomAccess"
                    Return "Boolean"
                Case "colCustomAccessText"
                    Return "String"
                Case "colOperatorStamp"
                    Return "String"
                Case "colDateTimeStamp"
                    Return "DateTime"
                Case "colPhone"
                    Return "String"
                Case "colFax"
                    Return "String"
                Case "colEmail"
                    Return "String"
                Case "colNotificationStamp"
                    Return "DateTime"
                Case "colActiveUser"
                    Return "Boolean"
                Case "colFilePrefix"
                    Return "Short"
                Case "colLastLogin"
                    Return "DateTime"
                Case "colLastPWChange"
                    Return "DateTime"
                Case "colInternal"
                    Return "Boolean"
                Case "colComments"
                    Return "String"
                Case "colRInit"
                    Return "String"
                Case "colRfu1"
                    Return "String"
                Case "colRfu2"
                    Return "String"
                Case "colRfu3"
                    Return "String"
                Case "colRReport"
                    Return "String"
                Case "colROverdue1"
                    Return "String"
                Case "colROverdue2"
                    Return "String"
                Case "colROverdue3"
                    Return "String"
                Case "colRActResp"
                    Return "String"
                Case "colWo"
                    Return "Boolean"
                Case "colCalist"
                    Return "String"
                Case "colDivlist"
                    Return "String"
                Case "colLoclist"
                    Return "String"
                Case "colThirdParty"
                    Return "Boolean"
                Case "colGRCAdministrator"
                    Return "String"
                Case "colLastRecentUpdate"
                    Return "DateTime"
                Case "colEzyUserID"
                    Return "Integer"
                Case "colAllowMaintLogin"
                    Return "Boolean"
                Case "colCCActive"
                    Return "Boolean"
                Case "colExpOverdue"
                    Return "String"
                Case "colEzyGuid"
                    Return "String"
                Case "colSecurityPasswordIsExpired"
                    Return "Boolean"
                Case "colSecurityAccountIsLockedOut"
                    Return "Boolean"
                Case "colAutoInactiveDate"
                    Return "DateTime"
                Case "colSecurityInactivityReminderSentDate"
                    Return "DateTime"
                Case "colMultipleUserType"
                    Return "String"
                Case "colImport"
                    Return "String"
                Case "colClientLocNoManager"
                    Return "Boolean"
                Case "colClientLocNoText"
                    Return "String"
                Case "colFacilityManager"
                    Return "Boolean"
                Case "colFacilityText"
                    Return "String"
                Case "colCityManager"
                    Return "Boolean"
                Case "colCityText"
                    Return "String"
                Case "colStProvManager"
                    Return "Boolean"
                Case "colStProvText"
                    Return "String"
                Case "colCountryManager"
                    Return "Boolean"
                Case "colCountryText"
                    Return "String"
                Case "colRExpd"
                    Return "String"
                Case "colCCOnly"
                    Return "Boolean"
                Case "colLoginId"
                    Return "Integer"
                Case "colLastReclassificationDate"
                    Return "DateTime"
                Case "colLastReclassificationByLoginID"
                    Return "Integer"
                Case "colLastReclassificationAction"
                    Return "Integer"
                Case "colMarkedForDeletionDate"
                    Return "DateTime"
                Case "colReclassificationDate"
                    Return "DateTime"
                Case "colReclassificationByLoginID"
                    Return "Integer"
                Case "colReclassificationAction"
                    Return "Integer"
                Case "colClientComment"
                    Return "String"
                Case "colSysUserCreated"
                    Return "String"
                Case "colSysDateCreated"
                    Return "DateTime"
                Case "colSysUserModified"
                    Return "String"
                Case "colSysDateModified"
                    Return "DateTime"
                Case "colClientAdministration"
                    Return "Boolean"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[ezy_Users]"
        End Function

        Private Function _FirstColumn() As String
            Return "[UserID]"
        End Function

    End Class
End namespace

