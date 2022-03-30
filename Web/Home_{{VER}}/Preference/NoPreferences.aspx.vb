

Public Class NoPreferences
    Inherits System.Web.UI.Page

    Public ServerSide_Email As String = ""
    Public ServerSide_DisplayName As String = ""
    Public ServerSide_IsAdminUser As String = "false"
    Public ServerSide_PasswordResetMessage As String = ""

    Private Sub LoadDefaults()
        ' *** GRC.Connect.Scott Update 7/30/2015
        Dim zGSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()

        Dim zUserEmail As String = ""
        If Not UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.UserEmail) Is Nothing And UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.UserEmail) <> "" Then
            zUserEmail = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.UserEmail)
        Else
            zUserEmail = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.PasswordResetEmail) ' *** GRC.Connect.Scott Update 7/30/2015
        End If
        Dim zUserPassword As String = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.UserPassword)
        Dim zUserFullName As String = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.userFullName)
        Dim zIsAdmin As String = UtilLogin2.IsGRCAdministrator(zUserEmail).ToString().ToLower()

        ServerSide_Email = zUserEmail
        ServerSide_DisplayName = zUserFullName
        ServerSide_IsAdminUser = zIsAdmin
        ServerSide_PasswordResetMessage = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.PasswordResetMessage) ' *** GRC.Connect.Scott Update 7/30/2015

    End Sub

    Private Sub LoadLists()

    End Sub

    Private Sub LoadData()

    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then
            Call LoadLists()
            Call LoadDefaults()
        End If

        Call LoadData()

    End Sub

End Class