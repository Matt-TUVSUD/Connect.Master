Imports Telerik.Web.UI
Imports GRC.Connect.Libraries.CoreLib.BusinessObjects


Public Class ClientConnectNoExit
    Inherits System.Web.UI.MasterPage

    ' GENERAL DECLARATIONS
    Dim zDefaultNavLinkQry As New NavLinkQuery
    Dim zLink As New NavLink
    Dim zToLevel As Integer
    Dim zCurrentPagePlaceholder As Integer
    Public ServerSide_IsFullAdmin As String = "false"

    Private Sub LoadDefaults()
        ' SET THE TREEVIEW FOR NAVIGATION
        Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Dim zCurrentPage As String = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.currentPage)
        Dim zCurrentTab As String = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.currentTab)
        Dim zCurrentLevelId As String = ""
        Dim zParentId As String = ""

        'SHOW OR HIDE BOTTOM BANNER BASED ON ADMIN USER
        'Dim zUserEmail As String = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.UserEmail)
        'Dim zUserPassword As String = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.UserPassword)
        'Dim zAdminType = UtilLogin.GetGRCAdministrator(zUserEmail, zUserPassword)
        Dim zLoginId As Integer = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(UtilGSafe.GetGUIDFromQueryString(), UtilGSafe.KeyName.EzyLoginId)
        Dim zAdminType = GRC.Connect.Libraries.CoreLib.UtilLogin2.GetGRCAdministrator(zLoginId)
        If zAdminType = "00" Then
            ServerSide_IsFullAdmin = "true"
        End If

        ' CLEAR LOCATION DETAIL NAVIGATION INFORMATION
        UtilGSafe.ClearLocationNavigationInformation(zGUID)

        ' LOOK FOR FILTERS APPLIED
        If GRC.Connect.Libraries.CoreLib.UtilPreference.IsFilterApplied(zGUID) = True Then
            'lblPreferencesApplied.Visible = True
        Else
            'lblPreferencesApplied.Visible = False
        End If


    End Sub

    Private Sub LoadData()
        Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()

        'THIS SUB IS FOR LOADING HEADER INFORMATION AND OTHER NEW DATA
        'lblLoginName.Text = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.userFullName)
        'lblTodaysDate.Text = FormatDateTime(Date.Today(), DateFormat.LongDate)

        'DB - 'Sets the FileNo Gsafe value to empty string when user is at the gauge screen
        UtilGSafe.ClearGSafeItems(zGUID)

    End Sub

    Private Sub Page_Init(sender As Object, e As System.EventArgs) Handles Me.Init
        'SAID Checker
        Dim zGUID = UtilGSafe.GetGUIDFromQueryString()
        'If GRC.Connect.Libraries.CoreLib.UtilSAID.IsNotSecure(UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.SafeGUID), zGUID) Then
        If GRC.Connect.Libraries.CoreLib.UtilSAID.IsNotSecureWithCookie(UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.SafeGUID), zGUID, Me.Page) Then
            Dim zErrLog As New GRC.Connect.Libraries.CoreLib.UtilErrorLog : zErrLog.CreateSimpleErrorLogRecord(
                       UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.LoggedInUserEmail),
                       "IsNotSecure hit in file: " & HttpContext.Current.Request.Url.AbsolutePath,
                       HttpContext.Current.Request.Url.AbsolutePath,
                       "SAID IsNotSecure",
                       Request.ServerVariables("REMOTE_ADDR"))
            Response.Redirect("~/Home_{{VER}}/Auth/Resecure.aspx", True)
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Page.Header.DataBind()

        If Not Page.IsPostBack Then
            Call LoadDefaults()
        End If
        Call LoadData()

    End Sub

End Class