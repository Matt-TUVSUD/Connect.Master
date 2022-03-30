Imports System.Configuration

Public Class UtilSystemParms

    Public Shared ReadOnly Property InMaintenanceMode() As Boolean
        Get
            Dim zObj As New BusinessObjects.SysAppSetting
            If zObj.LoadByPrimaryKey("InMaintenanceMode") Then
                If zObj.AppValue.ToLower.Contains("yes") Or _
                    zObj.AppValue.ToLower.Contains("true") Or _
                    zObj.AppValue.ToLower.Contains("1") Or _
                    zObj.AppValue.ToLower.Contains("-1") Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If

        End Get
    End Property

    Private Shared ReadOnly Property InPublicModeText() As String
        Get
            Dim zObj As New BusinessObjects.SysAppSetting
            If zObj.LoadByPrimaryKey("InPublicModeText") Then
                Return zObj.AppValue
            Else
                Return ""
            End If
        End Get
    End Property

    Private Shared ReadOnly Property InMaintenanceModeText() As String
        Get
            Dim zObj As New BusinessObjects.SysAppSetting
            If zObj.LoadByPrimaryKey("InMaintenanceModeText") Then
                Return zObj.AppValue
            Else
                Return ""
            End If
        End Get
    End Property

    Public Shared ReadOnly Property InMaintenanceModeLoginDeniedText() As String
        Get
            Dim zObj As New BusinessObjects.SysAppSetting
            If zObj.LoadByPrimaryKey("InMaintenanceModeLoginDeniedText") Then
                Return zObj.AppValue
            Else
                Return ""
            End If

        End Get
    End Property

    Public Shared ReadOnly Property LoginDisplayText() As String
        Get
            If InMaintenanceMode Then
                Return InMaintenanceModeText
            Else
                Return InPublicModeText
            End If

        End Get
    End Property

    Public Shared ReadOnly Property InDevMode() As Boolean
        Get
            If ReadWebAppMode().ToLower = "dev" Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property

    Public Shared ReadOnly Property InTestMode() As Boolean
        Get
            If ReadWebAppMode().ToLower = "test" Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property

    Public Shared ReadOnly Property InLiveMode() As Boolean
        Get
            If ReadWebAppMode().ToLower = "live" Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property


    Public Shared ReadOnly Property InBetaMode() As Boolean
        Get
            If ReadWebAppMode().ToLower = "beta" Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property

    Public Shared Function LogFilesPhysicalPath() As String
        Dim zReturn As String = ""

        zReturn = ConfigurationManager.AppSettings("LogFilesPhysicalPath")

        Return zReturn
    End Function

    Public Shared Function LogFilesEnabled() As Boolean
        Dim zReturn As Boolean = False

        zReturn = ConfigurationManager.AppSettings("LogFilesEnabled")

        Return zReturn
    End Function

    Public Shared Function ReadQorFormUrl() As String
        Dim zReturn As String = ""

        Select Case ReadWebAppMode().ToLower
            Case "dev"
                zReturn = ConfigurationManager.AppSettings("QoRFormURL_Dev")
            Case "test"
                zReturn = ConfigurationManager.AppSettings("QoRFormURL_Test")
            Case Else
                zReturn = ConfigurationManager.AppSettings("QoRFormURL_Live")
        End Select

        Return zReturn
    End Function

    Public Shared Function ReadCheckListRequestUrl() As String
        Dim zReturn As String = ""

        Select Case ReadWebAppMode().ToLower
            Case "live"
                zReturn = ConfigurationManager.AppSettings("CheckListRequestURL_Live")
            Case Else
                zReturn = ConfigurationManager.AppSettings("CheckListRequestURL_Test")
        End Select

        Return zReturn
    End Function

    Public Shared Function ReadDashboardUrl() As String
        Dim zReturn As String = ""

        Select Case ReadWebAppMode().ToLower
            Case "live"
                zReturn = ConfigurationManager.AppSettings("DashboardURL_Live")
            Case "test"
                zReturn = ConfigurationManager.AppSettings("DashboardURL_Test")
            Case "beta"
                zReturn = ConfigurationManager.AppSettings("DashboardURL_Beta")
            Case Else
                zReturn = ConfigurationManager.AppSettings("DashboardURL_Dev")
        End Select

        Return zReturn
    End Function

    Public Shared Function ReadCheckListRetrieveUrl() As String
        Dim zReturn As String = ""

        Select Case ReadWebAppMode().ToLower
            Case "live"
                zReturn = ConfigurationManager.AppSettings("CheckListRetrieveURL_Live")
            Case Else
                zReturn = ConfigurationManager.AppSettings("CheckListRetrieveURL_Test")
        End Select

        Return zReturn
    End Function

    Public Shared Function ReadWebAppBaseURL() As String
        Dim zReturn As String = ""

        zReturn = ConfigurationManager.AppSettings("WebAppBaseURL")

        Return zReturn
    End Function

    Public Shared Function ReadWebAppMode() As String
        Dim zReturn As String = ""

        zReturn = ConfigurationManager.AppSettings("WebAppMode")

        Return zReturn
    End Function

    Public Shared Function ReadFileExpireHours() As String
        Dim zReturn As String = ""

        zReturn = ConfigurationManager.AppSettings("FileExpireHours")

        Return zReturn
    End Function

    Public Shared Function ReadExternalFilePath() As String
        Dim zReturn As String = ""

        If UtilSystemParms.InLiveMode Then
            zReturn = ConfigurationManager.AppSettings("ExternalFilePath")
        Else
            zReturn = ConfigurationManager.AppSettings("TempFilePath")
        End If

        If IO.Directory.Exists(zReturn) Then
            Return zReturn
        Else
            System.Diagnostics.EventLog.WriteEntry("GRC.Connect", "ExternalFilePath does not exist [" & zReturn & "]. Using " & GetTempDirectoryPath() & " instead.", EventLogEntryType.Error)
            Return GetTempDirectoryPath()
        End If

    End Function

    Public Shared Function ExternalWhatsNewPath() As String
        Dim zReturn As String = ""

        zReturn = ConfigurationManager.AppSettings("ExternalWhatsNewPath")

        If IO.Directory.Exists(zReturn) Then
            Return zReturn
        Else
            System.Diagnostics.EventLog.WriteEntry("GRC.Connect", "ExternalWhatsNewPath does not exist [" & zReturn & "]. Using " & GetTempDirectoryPath() & " instead.", EventLogEntryType.Error)
            Return GetTempDirectoryPath()
        End If

    End Function

    Public Shared Function ReadEmailReturnURL() As String
        Dim zReturn As String = ""
        zReturn = ConfigurationManager.AppSettings("EmailReturnURL")
        Return zReturn
    End Function

    Public Shared Function ReadReportServerURL() As String
        Dim zReturn As String = ""

        'IF DEBUGGING IN VS, RETURN THE LOCAL HOST URL WITH THE ACTIVE VS PORT BEING USED TO RUN THE REPORT.
        If Debugger.IsAttached Then
            If IsNothing(HttpContext.Current) Then
                zReturn = ConfigurationManager.AppSettings("ReportServerURL")
            Else
                Dim zVSPort As Integer = HttpContext.Current.Request.Url.Port
                zReturn = "http://localhost:" & zVSPort
            End If

        Else
            zReturn = ConfigurationManager.AppSettings("ReportServerURL")
        End If

        Return zReturn
    End Function

    Public Shared Function ReadPDFVaultPath() As String
        Dim zReturn As String = Libraries.CoreLib.BusinessObjects.SysAppSetting.GetValue(BusinessObjects.Setting.PDFVaultPath)
        If IO.Directory.Exists(zReturn) Then
            Return zReturn
        Else
            System.Diagnostics.EventLog.WriteEntry("GRC.Connect", "PDFVaultPath does not exist [" & zReturn & "]. Using " & GetTempDirectoryPath() & " instead.", EventLogEntryType.Error)
            Return GetTempDirectoryPath()
        End If

    End Function

    Public Shared Function GetTempDirectoryPath() As String
        Dim zTempPath As String = IO.Path.Combine(IO.Path.GetTempPath, "GRC.Connect")
        If Not IO.Directory.Exists(zTempPath) Then
            IO.Directory.CreateDirectory(zTempPath)
        End If
        Return zTempPath
    End Function

    'Public Shared Function ReadAutoRecErrorEmailAddress() As String
    '    Return Libraries.CoreLib.BusinessObjects.SysAppSetting.GetValue(BusinessObjects.Setting.AutoRecErrorEmailAddress)
    '    'Dim zReturn As String = ""

    '    'zReturn = ConfigurationManager.AppSettings("AutoRecErrorEmailAddress")

    '    'Return zReturn
    'End Function

    Public Shared Function ReadServiceEventLogArchiveDays() As String
        Return ConfigurationManager.AppSettings("ServiceEventLogArchiveDays")
    End Function

    Public Shared Function GRCNumber(ByVal pValue As Integer) As String
        Return Format(pValue, "#,###")
    End Function

    Public Shared Function GRCDate(ByVal pDate As Date) As String
        Return Format(pDate, "dd-MMM-yy")
    End Function

    Public Shared Function GRCDateNoDash(ByVal pDate As Date) As String
        Return Format(pDate, "dd MMM yy")
    End Function
    Public Shared Function IsTimeOnly(ByVal pDate As String) As Boolean
        If DatePart(DateInterval.Year, CDate(pDate)) = "1" Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Shared Function ReadSMTPHost() As String
        Return Libraries.CoreLib.BusinessObjects.SysAppSetting.GetValue(BusinessObjects.Setting.EmailServerHostIP)
        'Dim zReturn As String = ""
        'zReturn = ConfigurationManager.AppSettings("SMTPHost")
        'Return zReturn
    End Function

    Public Shared Function ReadSMTPPort() As String
        Return Libraries.CoreLib.BusinessObjects.SysAppSetting.GetValue(BusinessObjects.Setting.EmailServerPort)
        'Dim zReturn As String = ""
        'zReturn = ConfigurationManager.AppSettings("SMTPPort")
        'Return zReturn
    End Function

    Public Shared Function ReadSMTPFromEmail() As String
        Return Libraries.CoreLib.BusinessObjects.SysAppSetting.GetValue(BusinessObjects.Setting.SMTPFromEmailAddress)
        'Dim zReturn As String = ""
        'zReturn = ConfigurationManager.AppSettings("SMTPFromEmail")
        'Return zReturn
    End Function

    Public Shared Function ReadSMTPFromDisplayName() As String
        Return Libraries.CoreLib.BusinessObjects.SysAppSetting.GetValue(BusinessObjects.Setting.SMTPFromDisplayName)
        'Dim zReturn As String = ""
        'zReturn = ConfigurationManager.AppSettings("SMTPFromDisplayName")
        'Return zReturn
    End Function

    Public Shared Function ReadEmailLogBCC() As String
        Dim zReturn As String = ""
        zReturn = ConfigurationManager.AppSettings("EmailLogBCC")
        Return zReturn
    End Function

    Public Shared Function ReadReportServerErrorsDisplayName() As String
        Dim zReturn As String = ""
        zReturn = ConfigurationManager.AppSettings("ReportServerErrorsDisplayName")
        Return zReturn
    End Function

    Public Shared Function ReadReportServerErrorsEmailAddress() As String
        Dim zReturn As String = ""
        zReturn = ConfigurationManager.AppSettings("ReportServerErrorsEmailAddress")
        Return zReturn
    End Function

    Public Shared Function ReadReportServerReplyEmailAddress() As String
        Dim zReturn As String = ""
        zReturn = ConfigurationManager.AppSettings("ReportServerReplyEmailAddress")
        Return zReturn
    End Function

    Public Shared Function ReadDefaultSettingCurrencyValue() As String
        Dim zReturn As String = ""
        zReturn = ConfigurationManager.AppSettings("DefaultSettingCurrencyValue")
        Return zReturn
    End Function

    Public Shared Function ReadDefaultSettingCurrencyText() As String
        Dim zReturn As String = ""
        zReturn = ConfigurationManager.AppSettings("DefaultSettingCurrencyText")
        Return zReturn
    End Function

    Public Shared Function ReadDefaultSettingUnitsValue() As String
        Dim zReturn As String = ""
        zReturn = ConfigurationManager.AppSettings("DefaultSettingUnitsValue")
        Return zReturn
    End Function

    Public Shared Function ReadDefaultSettingUnitsText() As String
        Dim zReturn As String = ""
        zReturn = ConfigurationManager.AppSettings("DefaultSettingUnitsText")
        Return zReturn
    End Function

    Public Shared Function ReadReportServerErrorLimit() As String
        Dim zReturn As String = ""
        zReturn = ConfigurationManager.AppSettings("ReportServerErrorLimit")
        Return zReturn
    End Function

    Public Shared Function ReadReportServerErrorDurationSec() As String
        Dim zReturn As String = ""
        zReturn = ConfigurationManager.AppSettings("ReportServerErrorDurationSec")
        Return zReturn
    End Function

    Public Shared Function AutoRecBccEmailAddress() As String
        Return Libraries.CoreLib.BusinessObjects.SysAppSetting.GetValue(BusinessObjects.Setting.AutoRecBccEmailAddress)
        'Dim zReturn As String = ""
        'zReturn = ConfigurationManager.AppSettings("AutoRecEmailAddress")
        'Return zReturn
    End Function

    'Public Shared Function AutoRecEmailDisplayName() As String
    '    Dim zReturn As String = ""
    '    zReturn = ConfigurationManager.AppSettings("AutoRecEmailDisplayName")
    '    Return zReturn
    'End Function

    Public Shared Function DeveloperEmailAddress() As String
        Dim zReturn As String = ""
        zReturn = ConfigurationManager.AppSettings("DeveloperEmailAddress")
        Return zReturn
    End Function

    Public Shared Function AutoRecMonthlyReportStartDay() As String
        Return Libraries.CoreLib.BusinessObjects.SysAppSetting.GetValue(BusinessObjects.Setting.AutoRecMonthlyReportStartDay)
    End Function

    Public Shared Function AutoRecMonthlyReportStartTime() As String
        Return Libraries.CoreLib.BusinessObjects.SysAppSetting.GetValue(BusinessObjects.Setting.AutoRecMonthlyReportStartTime)
    End Function

    Public Shared Function AutoRecDailyFollowUpStartTime() As String
        Return Libraries.CoreLib.BusinessObjects.SysAppSetting.GetValue(BusinessObjects.Setting.AutoRecDailyFollowUpStartTime)
    End Function

    Public Shared Function UserMaintenanceStartTime() As String
        Return Libraries.CoreLib.BusinessObjects.SysAppSetting.GetValue(BusinessObjects.Setting.UserMaintenanceStartTime)
    End Function

    Public Shared Function DefaultToEmailAddress() As String
        Return Libraries.CoreLib.BusinessObjects.SysAppSetting.GetValue(BusinessObjects.Setting.DefaultToEmailAddress)
    End Function

    Public Shared Function DataTransferToAddress() As String
        Return Libraries.CoreLib.BusinessObjects.SysAppSetting.GetValue(BusinessObjects.Setting.DataTransferErrorEmailAddress)
    End Function

    Public Shared Function DataTransferDailyStartTime() As String
        Return Libraries.CoreLib.BusinessObjects.SysAppSetting.GetValue(BusinessObjects.Setting.DataTransferDailyStartTime)
    End Function

    Public Shared Function RRLogMaintenanceDailyStartTime() As String
        Return Libraries.CoreLib.BusinessObjects.SysAppSetting.GetValue(BusinessObjects.Setting.RRLogMaintenanceStartTime)
    End Function

    Public Shared Function TaskAgentExceptionRecipients() As String
        Return Libraries.CoreLib.BusinessObjects.SysAppSetting.GetValue(BusinessObjects.Setting.TaskAgentExceptionRecipients)
    End Function
End Class
