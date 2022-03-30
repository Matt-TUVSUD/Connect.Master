'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/3/2013 2:42:31 PM
'===============================================================================

Imports System

Imports EntitySpaces.Core
Imports EntitySpaces.Interfaces
Imports EntitySpaces.DynamicQuery

Namespace BusinessObjects

	Partial Public Class SysAppSetting 
		Inherits esSysAppSetting

		Public Sub New()

		End Sub

        Public Shared Sub AutoRemoveMaintenanceMode()
            Dim zSetting As New SysAppSetting
            If zSetting.LoadByPrimaryKey("AutoRemoveMaintenanceModeDateTime") Then
                If IsDate(zSetting.AppValue) And Libraries.CoreLib.UtilSystemParms.InMaintenanceMode Then
                    If Now() > zSetting.AppValue Then
                        RemoveMaintenanceMode()
                    End If
                End If
            End If
        End Sub

        Private Shared Sub RemoveMaintenanceMode()
            Dim zSettingsCol As New SysAppSettingCollection
            zSettingsCol.LoadAll()

            For Each zSetting As SysAppSetting In zSettingsCol
                If zSetting.AppKey.ToLower = "inmaintenancemode" Then
                    zSetting.AppValue = "False"
                    zSetting.Save()
                End If

                If zSetting.AppKey.ToLower = "inpublicmodetext" Then
                    zSetting.AppValue = ""
                    zSetting.Save()
                End If


                If zSetting.AppKey.ToLower = "autoremovemaintenancemodedatetime" Then
                    zSetting.AppValue = SqlTypes.SqlDateTime.MaxValue
                    zSetting.Save()
                End If

            Next
        End Sub

        Public Shared Function GetValue(ByVal pSetting As Setting) As String
            Dim zSetting As New SysAppSetting
            If zSetting.LoadByPrimaryKey(pSetting.ToString) Then
                Return zSetting.AppValue
            Else
                Return ""
            End If

        End Function

        ''' <summary>
        ''' This sub simply checks to make sure all keys are available in table
        ''' </summary>
        ''' <remarks></remarks>
        Public Shared Sub CheckKeys()

            'These are all the keys that should be listed in the sysAppSetting table.  The value is the default value if the key doesn't exist.
            Dim zKeys As New Dictionary(Of String, Object)
            zKeys.Add("InMaintenanceMode", {"False", "Expects: True/False; Sets the application in maintenance mode."})
            zKeys.Add("InMaintenanceModeLoginDeniedText", {"", "Expects: String; The message to display when user is denied logging in while app in maintenance mode."})
            zKeys.Add("InMaintenanceModeText", {"", "Expects: String; The message to display while in maintenance mode."})
            zKeys.Add("InPublicModeText", {"", "Expects: String; The message to display while in normal (public) mode."})
            zKeys.Add("AutoRemoveMaintenanceModeDateTime", {SqlTypes.SqlDateTime.MaxValue.ToString, "Expects: DateTime; The date and time to automatically take system out of maintenance mode."})
            zKeys.Add("UserMaintenanceStartTime", {"9:00 AM", "Expects: Time; The time to run the daily UserMaintenance job."})
            zKeys.Add("AutoRecMonthlyReportStartDay", {"1", "Expects: Number (Day of month); The day to run the AutoRecMonthlyReport job."})
            zKeys.Add("AutoRecMonthlyReportStartTime", {"8:00 AM", "Expects: Time; The time when to run the AutoRecMonthlyReport job."})
            zKeys.Add("AutoRecDailyFollowUpStartTime", {"8:30 AM", "Expects: Time; The time when to run the AutoRecDailyFollowUp job."})
            zKeys.Add("DefaultToEmailAddress", {"grc-itapplications@tuvsud.com", "Expects: String; When no TO address is specified when sending an email, send to this address."})
            zKeys.Add("EmailServerHostIP", {"10.100.3.77", "Expects: String; The IP Address of the email server to manage sending emails."})
            zKeys.Add("EmailServerPort", {"25", "Expects: Number; The port number of the email server to send emails."})
            zKeys.Add("SMTPFromDisplayName", {"GRC Connect", "Expects: String; The display name the appears where the email comes from."})
            zKeys.Add("SMTPFromEmailAddress", {"grc-grcconnect@tuvsud.com", "Expects: String; The email address where the email comes from."})
            zKeys.Add("PDFVaultPath", {"\\extra-data\ClientsWEB_D\data\PDFVault\", "Expects: String; The UNC path to where PDFs are stored."})
            zKeys.Add("AutoRecBccEmailAddress", {"grc-AutoRec@tuvsud.com", "Expects: String; The email to BCC autorec emails."})
            zKeys.Add("AutoRecErrorEmailAddress", {"grc-clientdba@tuvsud.com", "Expects: String;  The email to send to when an error occurs with autorec emails."})
            zKeys.Add("DataTransferDailyStartTime", {"04:00 AM", "Expects: Time; The time to run the datatransfer."})
            zKeys.Add("DataTransferErrorEmailAddress", {"daniel.barasch@tuvsud.com", "Expects: String; The email address to send exceptions to."})
            zKeys.Add("DataTransferServiceAccount", {"4997", "Expects: Integer; The ezyuserId who will run the datatransfer process.  This account must have access to all data."})
            zKeys.Add("RRLogMaintenanceStartTime", {"07:30 AM", "Expects: Time; The time to run the datatransfer."})



            'Now check to make they exist in the table
            Dim zSettingsToAdd As New SysAppSettingCollection
            Dim zCurrentSettings As New BusinessObjects.SysAppSettingCollection
            Dim zAddKey As Boolean = Nothing

            zCurrentSettings.LoadAll()

            For Each zKey As KeyValuePair(Of String, Object) In zKeys

                zAddKey = True

                For Each zSetting As SysAppSetting In zCurrentSettings
                    If zKey.Key.ToLower = zSetting.AppKey.ToLower Then
                        zAddKey = False
                        Exit For
                    End If
                Next

                If zAddKey Then
                    Dim zNewSetting As New SysAppSetting
                    zNewSetting.AppKey = zKey.Key
                    zNewSetting.AppValue = zKey.Value(0)
                    zNewSetting.Description = zKey.Value(1)
                    zNewSetting.Save()
                End If

            Next


        End Sub

    End Class

    Public Enum Setting
        InMaintenanceMode
        InMaintenanceModeLoginDeniedText
        InMaintenanceModeText
        InPublicModeText
        AutoRemoveMaintenanceModeDateTime
        UserMaintenanceStartTime
        AutoRecMonthlyReportStartDay
        AutoRecMonthlyReportStartTime
        AutoRecDailyFollowUpStartTime
        EmailServerHostIP
        EmailServerPort
        SMTPFromDisplayName
        SMTPFromEmailAddress
        DefaultToEmailAddress
        PDFVaultPath
        AutoRecBccEmailAddress
        AutoRecErrorEmailAddress
        DataTransferDailyStartTime
        DataTransferErrorEmailAddress
        DataTransferServiceAccount
        RRLogMaintenanceStartTime
        TaskAgentExceptionRecipients
    End Enum


End Namespace
