Imports GRC.Connect.Libraries.DataLib.razor

Public Class UtilSetting

    Public Shared SettingsList As List(Of rowTblMetaAppSetting)
    Public Shared AppVersion As rowTblAppVersion = Nothing
    Public Shared SettingsLoaded As Boolean = False
    Private Shared IsInit As Boolean = False


    'THIS VARIABLE ADJUSTS THE ENVIRONMENT SO THAT ALL URLS IN EMAILS USE THE PORT # VISUAL STUDIO IS USING.  
    'PRIMARY USAGE IS FOR ANY EMAILS THAT HAVE LINKS TO THE APPLICATION
    Private Shared UseVSAppMode As Boolean = False


    Public Enum Keys
        DataTransferFileName
        DataTransferRootPath
        DataTransferFolder
        ApplicationURL
        ApplicatonExceptionRecipients
        ApplicatonAuthority
        ApplicationPublicText
        ApplicationAllowPublicLogin
        ApplicationAllowMaintenanceLogin
        QorURL
        EmailConnectionString
        AutoRecLoginURL
        AutoRecBCCAddress
        BatchProcessingBCCAddress
        TaskAgentExceptionRecipients
        AutoRecAdminAddress
        PasswordResetURL
        NotificationBCCAddresses
        PasswordResetConfirmBCCAddresses
        UserReclassificationURL
        UserReclassificationBCCAddresses
        ClientDatabaseFolderRootPath
        ImportTemplateVersion
        AutoRecInitialSelfAuditCCAddresses
        InDataMaintenanceMode
    End Enum

    Public Enum AppMode
        VSDev = 1
        Dev
        Test
        Live
        Beta
    End Enum

    Public Shared Sub Init(pRequest As HttpRequest)
        If Not IsInit Then
            SettingsList = TblMetaAppSetting.LoadData
            IsInit = True

            SetAppVersion()
            SetVSDevAppAuthority(pRequest)
        End If
    End Sub

    Public Shared Sub Init()
        If Not IsInit Then
            SettingsList = TblMetaAppSetting.LoadData
            IsInit = True

            SetAppVersion()
            SetVSDevAppAuthority(Nothing)
        End If
    End Sub

    Private Shared Sub SetAppVersion()

        Dim zVersionList As List(Of rowTblAppVersion) = TblAppVersion.LoadData()
        Dim zAppVersion As rowTblAppVersion = Nothing
        If zVersionList.Count = 0 Then zAppVersion = New rowTblAppVersion Else zAppVersion = zVersionList(0)

        Dim zAssemblyName As Reflection.AssemblyName = Reflection.Assembly.GetExecutingAssembly.GetName
        zAppVersion.colFldVersion = zAssemblyName.Version.ToString
        zAppVersion.colFldBuild = zAssemblyName.Version.Build.ToString

        'DO NOT ADJUST THE VERSIONS WHEN RUNNING IS VS SINCE VERSIONS ARE NOT STAMPED.
        If Not Debugger.IsAttached Then
            If IsNothing(zAppVersion.colFldBuild) OrElse zAppVersion.colFldBuild <> zAssemblyName.Version.Build Then
                TblAppVersion.Save(zAppVersion)
            End If
        Else
            zAppVersion.colFldBuild = "{{VER}}"
        End If

        AppVersion = zAppVersion

    End Sub

    Public Shared Function GetValue(pKey As Keys, Optional pGetCachedValue As Boolean = True) As String

        If pGetCachedValue Then
            If Not IsInit Then Throw New ApplicationException("UtilSetting not initialized. Please call UtilSetting.Init() before using this function.")
            Dim zSetting As rowTblMetaAppSetting = SettingsList.Find(Function(x) x.colFldKey.ToLower = pKey.ToString.ToLower)
            Return GetModeValue(zSetting)
        Else
            Dim zSetting As rowTblMetaAppSetting = TblMetaAppSetting.LoadByPrimaryKey(pKey.ToString)
            Return GetModeValue(zSetting)
        End If
    End Function

    Public Shared Function GetSetting(pKey As Keys) As rowTblMetaAppSetting
        Return SettingsList.Find(Function(x) x.colFldKey.ToLower = pKey.ToString.ToLower)
    End Function

    Private Shared Function GetModeValue(pSetting As rowTblMetaAppSetting) As String
        Dim zDefault As String = IIf(IsNothing(pSetting.colFldDefaultValue), "", pSetting.colFldDefaultValue)
        Select Case GetAppMode()

            Case AppMode.Dev
                If IsNothing(pSetting.colFldDevValue) Then Return zDefault Else Return pSetting.colFldDevValue

            Case AppMode.Test
                If IsNothing(pSetting.colFldTestValue) Then Return zDefault Else Return pSetting.colFldTestValue

            Case AppMode.Live
                If IsNothing(pSetting.colFldLiveValue) Then Return zDefault Else Return pSetting.colFldLiveValue

            Case AppMode.VSDev
                If IsNothing(pSetting.colFldDevVSValue) Then Return zDefault Else Return pSetting.colFldDevVSValue

        End Select

        Return zDefault

    End Function

    Public Shared Function GetAppAuthority() As String
        Dim zReturn As String = GetValue(Keys.ApplicatonAuthority)
        If GetAppMode() = AppMode.VSDev Then zReturn = GetVSDevAppAuthority()
        Return zReturn
    End Function

    Public Shared Function GetAppBaseURL() As String
        Dim zAuthority As String = GetAppAuthority()
        Dim zApp As String = GetValue(Keys.ApplicationURL)
        If zApp = "/" Then zApp = ""
        Return zAuthority & zApp
    End Function

    Public Shared Function GetAppHomeURL() As String
        Dim zHomeFolder As String = "/Home"
        Return GetAppBaseURL() & zHomeFolder
    End Function

    Public Shared Function GetAppHomeVersionURL() As String
        Dim zHomeFolder As String = "/Home_{{VER}}"
        Return GetAppBaseURL() & zHomeFolder
    End Function

    Public Shared Function GetQorUrl() As String
        Dim zAuthority As String = GetAppAuthority()
        Dim zUrl As String = GetValue(Keys.QorURL)
        Return zAuthority & zUrl
    End Function

    Public Shared Function GetPasswordResetUrl() As String
        Dim zApplication As String = GetAppBaseURL()
        Dim zUrl As String = GetValue(Keys.PasswordResetURL)
        Return zApplication & zUrl
    End Function

    Public Shared Function GetUserReclassificationUrl() As String
        Dim zApplication As String = GetAppBaseURL()
        Dim zUrl As String = GetValue(Keys.UserReclassificationURL)
        Return zApplication & zUrl
    End Function

    Public Shared Function GetRecResponseLoginUrl() As String
        Dim zAuthority As String = GetAppBaseURL()
        Dim zRecResponseUrl As String = GetValue(Keys.AutoRecLoginURL)
        Return zAuthority & zRecResponseUrl
    End Function

    Public Shared Function GetAppMode() As AppMode
        Dim zReturn As AppMode = Nothing
        If System.Configuration.ConfigurationManager.AppSettings("WebAppMode").ToLower = "live" Then zReturn = AppMode.Live
        If System.Configuration.ConfigurationManager.AppSettings("WebAppMode").ToLower = "test" Then zReturn = AppMode.Test
        If System.Configuration.ConfigurationManager.AppSettings("WebAppMode").ToLower = "dev" Then zReturn = AppMode.Dev
        If Diagnostics.Debugger.IsAttached And UseVSAppMode Then zReturn = AppMode.VSDev
        Return zReturn
    End Function

    Public Shared Sub SetValue(pKey As Keys, pValue As String)
        Dim zSetting As rowTblMetaAppSetting = SettingsList.Find(Function(x) x.colFldKey.ToLower = pKey.ToString.ToLower)
        Dim zDoSave As Boolean = False

        If IsNothing(zSetting.colFldLiveValue) And GetAppMode() = AppMode.Live Then zSetting.colFldLiveValue = pValue : zDoSave = True
        If IsNothing(zSetting.colFldTestValue) And GetAppMode() = AppMode.Test Then zSetting.colFldTestValue = pValue : zDoSave = True
        If IsNothing(zSetting.colFldDevValue) And GetAppMode() = AppMode.Dev Then zSetting.colFldDevValue = pValue : zDoSave = True
        If IsNothing(zSetting.colFldDevVSValue) And GetAppMode() = AppMode.VSDev Then zSetting.colFldDevVSValue = pValue : zDoSave = True

        If GetAppMode() = AppMode.Live And zSetting.colFldLiveValue <> pValue Then zSetting.colFldLiveValue = pValue : zDoSave = True
        If GetAppMode() = AppMode.Test And zSetting.colFldTestValue <> pValue Then zSetting.colFldTestValue = pValue : zDoSave = True
        If GetAppMode() = AppMode.Dev And zSetting.colFldDevValue <> pValue Then zSetting.colFldDevValue = pValue : zDoSave = True
        If GetAppMode() = AppMode.VSDev And zSetting.colFldDevVSValue <> pValue Then zSetting.colFldDevVSValue = pValue : zDoSave = True

        If zDoSave Then
            TblMetaAppSetting.Save(zSetting)
            Init()
        End If

    End Sub

    Private Shared Sub SetVSDevAppAuthority(pRequest As HttpRequest)
        If Not IsNothing(pRequest) And GetAppMode() = AppMode.VSDev Then

            Dim zDevAuthoritiesJSON As String = GetValue(Keys.ApplicatonAuthority)
            Dim zDeveloperAuths As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
            Dim zDeveloperUserName As String = Environment.GetEnvironmentVariable("UserName")

            If Not String.IsNullOrEmpty(zDevAuthoritiesJSON) Then
                zDeveloperAuths = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(zDevAuthoritiesJSON)
            End If

            If zDeveloperAuths.TryGetValue(zDeveloperUserName, Nothing) Then
                zDeveloperAuths(zDeveloperUserName) = pRequest.Url.GetLeftPart(UriPartial.Authority)
            Else
                zDeveloperAuths.Add(zDeveloperUserName, pRequest.Url.GetLeftPart(UriPartial.Authority))
            End If

            zDevAuthoritiesJSON = Newtonsoft.Json.JsonConvert.SerializeObject(zDeveloperAuths)

            SetValue(Keys.ApplicatonAuthority, zDevAuthoritiesJSON)

        End If
    End Sub

    Private Shared Function GetVSDevAppAuthority() As String

        Dim zDevAuthoritiesJSON As String = GetValue(Keys.ApplicatonAuthority)
        Dim zDeveloperAuths As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
        Dim zDeveloperUserName As String = Environment.GetEnvironmentVariable("UserName")

        If Not String.IsNullOrEmpty(zDevAuthoritiesJSON) Then
            zDeveloperAuths = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(zDevAuthoritiesJSON)
        End If

        Return zDeveloperAuths(zDeveloperUserName)

    End Function
    Public Shared Function InDataMaintenanceMode() As Boolean
        Dim v As String = GetValue(Keys.InDataMaintenanceMode, False)
        If String.IsNullOrEmpty(v) Then
            Return True
        Else
            Return CBool(v)
        End If
    End Function

End Class
