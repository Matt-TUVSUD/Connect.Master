'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryViewCCUserActivityGridV2
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colLoginID As New razor.UtilSQLServer.IntegerDataColumn
        Public colEmailAddress As New razor.UtilSQLServer.StringDataColumn
        Public colActiveFlag As New razor.UtilSQLServer.BooleanDataColumn
        Public colLoginGuid As New razor.UtilSQLServer.StringDataColumn
        Public colFullName As New razor.UtilSQLServer.StringDataColumn
        Public colUserID As New razor.UtilSQLServer.StringDataColumn
        Public colPassword As New razor.UtilSQLServer.StringDataColumn
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
        Public colDateTimeStamp As New razor.UtilSQLServer.StringDataColumn
        Public colPhone As New razor.UtilSQLServer.StringDataColumn
        Public colFax As New razor.UtilSQLServer.StringDataColumn
        Public colEmail As New razor.UtilSQLServer.StringDataColumn
        Public colNotificationStamp As New razor.UtilSQLServer.StringDataColumn
        Public colActiveUser As New razor.UtilSQLServer.BooleanDataColumn
        Public colFilePrefix As New razor.UtilSQLServer.StringDataColumn
        Public colLastLogin As New razor.UtilSQLServer.StringDataColumn
        Public colLastPWChange As New razor.UtilSQLServer.StringDataColumn
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
        Public colExpOverdue As New razor.UtilSQLServer.StringDataColumn
        Public colWo As New razor.UtilSQLServer.BooleanDataColumn
        Public colCCActive As New razor.UtilSQLServer.BooleanDataColumn
        Public colCalist As New razor.UtilSQLServer.StringDataColumn
        Public colDivlist As New razor.UtilSQLServer.StringDataColumn
        Public colLoclist As New razor.UtilSQLServer.StringDataColumn
        Public colThirdparty As New razor.UtilSQLServer.BooleanDataColumn
        Public colGrcadministrator As New razor.UtilSQLServer.StringDataColumn
        Public colLastrecentupdate As New razor.UtilSQLServer.StringDataColumn
        Public colEzyUserID As New razor.UtilSQLServer.IntegerDataColumn
        Public colIsAMorAE As New razor.UtilSQLServer.BooleanDataColumn
        Public colCCOnly As New razor.UtilSQLServer.BooleanDataColumn
        Public colFacilityManager As New razor.UtilSQLServer.BooleanDataColumn
        Public colFacilityText As New razor.UtilSQLServer.StringDataColumn
        Public colClientLocNoManager As New razor.UtilSQLServer.BooleanDataColumn
        Public colClientLocNoText As New razor.UtilSQLServer.StringDataColumn
        Public colCityManager As New razor.UtilSQLServer.BooleanDataColumn
        Public colCityText As New razor.UtilSQLServer.StringDataColumn
        Public colStProvManager As New razor.UtilSQLServer.BooleanDataColumn
        Public colStProvText As New razor.UtilSQLServer.StringDataColumn
        Public colCountryManager As New razor.UtilSQLServer.BooleanDataColumn
        Public colCountryText As New razor.UtilSQLServer.StringDataColumn
        Public colRExpd As New razor.UtilSQLServer.StringDataColumn
        Public colClientAdministration As New razor.UtilSQLServer.BooleanDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colLoginID.ColumnName = "[LoginID]"
            colEmailAddress.ColumnName = "[EmailAddress]"
            colActiveFlag.ColumnName = "[ActiveFlag]"
            colLoginGuid.ColumnName = "[LoginGuid]"
            colFullName.ColumnName = "[FullName]"
            colUserID.ColumnName = "[UserID]"
            colPassword.ColumnName = "[Password]"
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
            colComments.ColumnName = "[Comments]"
            colRInit.ColumnName = "[RInit]"
            colRfu1.ColumnName = "[Rfu1]"
            colRfu2.ColumnName = "[Rfu2]"
            colRfu3.ColumnName = "[Rfu3]"
            colRReport.ColumnName = "[RReport]"
            colROverdue1.ColumnName = "[ROverdue1]"
            colROverdue2.ColumnName = "[ROverdue2]"
            colROverdue3.ColumnName = "[ROverdue3]"
            colRActResp.ColumnName = "[RActResp]"
            colExpOverdue.ColumnName = "[ExpOverdue]"
            colWo.ColumnName = "[Wo]"
            colCCActive.ColumnName = "[CCActive]"
            colCalist.ColumnName = "[calist]"
            colDivlist.ColumnName = "[divlist]"
            colLoclist.ColumnName = "[loclist]"
            colThirdparty.ColumnName = "[ThirdParty ]"
            colGrcadministrator.ColumnName = "[GRCAdministrator ]"
            colLastrecentupdate.ColumnName = "[LastRecentUpdate ]"
            colEzyUserID.ColumnName = "[EzyUserID]"
            colIsAMorAE.ColumnName = "[IsAMorAE]"
            colCCOnly.ColumnName = "[CCOnly]"
            colFacilityManager.ColumnName = "[FacilityManager]"
            colFacilityText.ColumnName = "[FacilityText]"
            colClientLocNoManager.ColumnName = "[ClientLocNoManager]"
            colClientLocNoText.ColumnName = "[ClientLocNoText]"
            colCityManager.ColumnName = "[CityManager]"
            colCityText.ColumnName = "[CityText]"
            colStProvManager.ColumnName = "[StProvManager]"
            colStProvText.ColumnName = "[StProvText]"
            colCountryManager.ColumnName = "[CountryManager]"
            colCountryText.ColumnName = "[CountryText]"
            colRExpd.ColumnName = "[RExpd]"
            colClientAdministration.ColumnName = "[ClientAdministration]"

            _Members.Add("colLoginID", colLoginID)
            _Members.Add("colEmailAddress", colEmailAddress)
            _Members.Add("colActiveFlag", colActiveFlag)
            _Members.Add("colLoginGuid", colLoginGuid)
            _Members.Add("colFullName", colFullName)
            _Members.Add("colUserID", colUserID)
            _Members.Add("colPassword", colPassword)
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
            _Members.Add("colExpOverdue", colExpOverdue)
            _Members.Add("colWo", colWo)
            _Members.Add("colCCActive", colCCActive)
            _Members.Add("colCalist", colCalist)
            _Members.Add("colDivlist", colDivlist)
            _Members.Add("colLoclist", colLoclist)
            _Members.Add("colThirdparty", colThirdparty)
            _Members.Add("colGrcadministrator", colGrcadministrator)
            _Members.Add("colLastrecentupdate", colLastrecentupdate)
            _Members.Add("colEzyUserID", colEzyUserID)
            _Members.Add("colIsAMorAE", colIsAMorAE)
            _Members.Add("colCCOnly", colCCOnly)
            _Members.Add("colFacilityManager", colFacilityManager)
            _Members.Add("colFacilityText", colFacilityText)
            _Members.Add("colClientLocNoManager", colClientLocNoManager)
            _Members.Add("colClientLocNoText", colClientLocNoText)
            _Members.Add("colCityManager", colCityManager)
            _Members.Add("colCityText", colCityText)
            _Members.Add("colStProvManager", colStProvManager)
            _Members.Add("colStProvText", colStProvText)
            _Members.Add("colCountryManager", colCountryManager)
            _Members.Add("colCountryText", colCountryText)
            _Members.Add("colRExpd", colRExpd)
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
                Case "colLoginID"
                    Return "[LoginID]"
                Case "colEmailAddress"
                    Return "[EmailAddress]"
                Case "colActiveFlag"
                    Return "[ActiveFlag]"
                Case "colLoginGuid"
                    Return "[LoginGuid]"
                Case "colFullName"
                    Return "[FullName]"
                Case "colUserID"
                    Return "[UserID]"
                Case "colPassword"
                    Return "[Password]"
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
                    Return "[Comments]"
                Case "colRInit"
                    Return "[RInit]"
                Case "colRfu1"
                    Return "[Rfu1]"
                Case "colRfu2"
                    Return "[Rfu2]"
                Case "colRfu3"
                    Return "[Rfu3]"
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
                Case "colExpOverdue"
                    Return "[ExpOverdue]"
                Case "colWo"
                    Return "[Wo]"
                Case "colCCActive"
                    Return "[CCActive]"
                Case "colCalist"
                    Return "[calist]"
                Case "colDivlist"
                    Return "[divlist]"
                Case "colLoclist"
                    Return "[loclist]"
                Case "colThirdparty"
                    Return "[ThirdParty ]"
                Case "colGrcadministrator"
                    Return "[GRCAdministrator ]"
                Case "colLastrecentupdate"
                    Return "[LastRecentUpdate ]"
                Case "colEzyUserID"
                    Return "[EzyUserID]"
                Case "colIsAMorAE"
                    Return "[IsAMorAE]"
                Case "colCCOnly"
                    Return "[CCOnly]"
                Case "colFacilityManager"
                    Return "[FacilityManager]"
                Case "colFacilityText"
                    Return "[FacilityText]"
                Case "colClientLocNoManager"
                    Return "[ClientLocNoManager]"
                Case "colClientLocNoText"
                    Return "[ClientLocNoText]"
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
                Case "colClientAdministration"
                    Return "[ClientAdministration]"
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
                Case "[ActiveFlag]", "ActiveFlag", "ActiveFlag", "colActiveFlag"  
                    Return "colActiveFlag"
                Case "[LoginGuid]", "LoginGuid", "LoginGuid", "colLoginGuid"  
                    Return "colLoginGuid"
                Case "[FullName]", "FullName", "FullName", "colFullName"  
                    Return "colFullName"
                Case "[UserID]", "UserID", "UserID", "colUserID"  
                    Return "colUserID"
                Case "[Password]", "Password", "Password", "colPassword"  
                    Return "colPassword"
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
                Case "[Comments]", "Comments", "Comments", "colComments"  
                    Return "colComments"
                Case "[RInit]", "RInit", "RInit", "colRInit"  
                    Return "colRInit"
                Case "[Rfu1]", "Rfu1", "Rfu1", "colRfu1"  
                    Return "colRfu1"
                Case "[Rfu2]", "Rfu2", "Rfu2", "colRfu2"  
                    Return "colRfu2"
                Case "[Rfu3]", "Rfu3", "Rfu3", "colRfu3"  
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
                Case "[ExpOverdue]", "ExpOverdue", "ExpOverdue", "colExpOverdue"  
                    Return "colExpOverdue"
                Case "[Wo]", "Wo", "Wo", "colWo"  
                    Return "colWo"
                Case "[CCActive]", "CCActive", "CCActive", "colCCActive"  
                    Return "colCCActive"
                Case "[calist]", "calist", "Calist", "colCalist"  
                    Return "colCalist"
                Case "[divlist]", "divlist", "Divlist", "colDivlist"  
                    Return "colDivlist"
                Case "[loclist]", "loclist", "Loclist", "colLoclist"  
                    Return "colLoclist"
                Case "[ThirdParty ]", "ThirdParty ", "Thirdparty", "colThirdparty"  
                    Return "colThirdparty"
                Case "[GRCAdministrator ]", "GRCAdministrator ", "Grcadministrator", "colGrcadministrator"  
                    Return "colGrcadministrator"
                Case "[LastRecentUpdate ]", "LastRecentUpdate ", "Lastrecentupdate", "colLastrecentupdate"  
                    Return "colLastrecentupdate"
                Case "[EzyUserID]", "EzyUserID", "EzyUserID", "colEzyUserID"  
                    Return "colEzyUserID"
                Case "[IsAMorAE]", "IsAMorAE", "IsAMorAE", "colIsAMorAE"  
                    Return "colIsAMorAE"
                Case "[CCOnly]", "CCOnly", "CCOnly", "colCCOnly"  
                    Return "colCCOnly"
                Case "[FacilityManager]", "FacilityManager", "FacilityManager", "colFacilityManager"  
                    Return "colFacilityManager"
                Case "[FacilityText]", "FacilityText", "FacilityText", "colFacilityText"  
                    Return "colFacilityText"
                Case "[ClientLocNoManager]", "ClientLocNoManager", "ClientLocNoManager", "colClientLocNoManager"  
                    Return "colClientLocNoManager"
                Case "[ClientLocNoText]", "ClientLocNoText", "ClientLocNoText", "colClientLocNoText"  
                    Return "colClientLocNoText"
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
                Case "[ClientAdministration]", "ClientAdministration", "ClientAdministration", "colClientAdministration"  
                    Return "colClientAdministration"
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
                Case "colActiveFlag"
                    Return "Boolean"
                Case "colLoginGuid"
                    Return "String"
                Case "colFullName"
                    Return "String"
                Case "colUserID"
                    Return "String"
                Case "colPassword"
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
                    Return "String"
                Case "colPhone"
                    Return "String"
                Case "colFax"
                    Return "String"
                Case "colEmail"
                    Return "String"
                Case "colNotificationStamp"
                    Return "String"
                Case "colActiveUser"
                    Return "Boolean"
                Case "colFilePrefix"
                    Return "String"
                Case "colLastLogin"
                    Return "String"
                Case "colLastPWChange"
                    Return "String"
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
                Case "colExpOverdue"
                    Return "String"
                Case "colWo"
                    Return "Boolean"
                Case "colCCActive"
                    Return "Boolean"
                Case "colCalist"
                    Return "String"
                Case "colDivlist"
                    Return "String"
                Case "colLoclist"
                    Return "String"
                Case "colThirdparty"
                    Return "Boolean"
                Case "colGrcadministrator"
                    Return "String"
                Case "colLastrecentupdate"
                    Return "String"
                Case "colEzyUserID"
                    Return "Integer"
                Case "colIsAMorAE"
                    Return "Boolean"
                Case "colCCOnly"
                    Return "Boolean"
                Case "colFacilityManager"
                    Return "Boolean"
                Case "colFacilityText"
                    Return "String"
                Case "colClientLocNoManager"
                    Return "Boolean"
                Case "colClientLocNoText"
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
                Case "colClientAdministration"
                    Return "Boolean"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[viewCCUserActivityGridV2]"
        End Function

        Private Function _FirstColumn() As String
            Return "[LoginID]"
        End Function

    End Class
End namespace

