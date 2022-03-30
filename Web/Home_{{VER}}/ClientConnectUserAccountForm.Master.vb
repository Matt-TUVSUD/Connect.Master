Imports GRC.Connect.Libraries.CoreLib.BusinessObjects
Imports GRC.Connect.Libraries.DataLib.razor
Imports Telerik.Web.UI

Public Class ClientConnectUserAccountForm
    Inherits System.Web.UI.MasterPage

    Private Sub LoadDefaults()
        ' SET THE TREEVIEW FOR NAVIGATION
        Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Dim zCurrentPage As String = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.currentPage)
        Dim zCurrentTab As String = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.currentTab)
        Dim zCurrentLevelId As String = ""
        Dim zParentId As String = ""

        'SET THE BACKGROUND IMAGE OF THE NAV
        RadWindow1.BackColor = Drawing.Color.Transparent
        RadWindowManager1.BackColor = Drawing.Color.Transparent

    End Sub

    Private Sub LoadData()
        Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()

        'THIS SUB IS FOR LOADING HEADER INFORMATION AND OTHER NEW DATA
        ' USE OBJECT NAME objGOCSafe
        lblCompany.Text = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.ClientName)          ' "ABC Company"
        lblLoginName.Text = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.userFullName)      ' "Gary Kidney"  
        lblTodaysDate.Text = FormatDateTime(Date.Today(), DateFormat.LongDate)
        'lblPageTitle.Text = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.practiceName)      ' "Fire Program"

         ' CLEAR LOCATION DETAIL NAVIGATION INFORMATION
        UtilGSafe.ClearLocationNavigationInformation(zGUID)

        ' LOOK FOR FILTERS APPLIED
        If GRC.Connect.Libraries.CoreLib.UtilPreference.IsFilterApplied(zGUID) = True Then
            lblPreferencesApplied.Visible = True
        Else
            lblPreferencesApplied.Visible = False
        End If


    End Sub

    Private Sub Page_Init(sender As Object, e As System.EventArgs) Handles Me.Init
        'SAID Checker
        Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()
        'If GRC.Connect.Libraries.CoreLib.UtilSAID.IsNotSecure(UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.SafeGUID), zGUID) Then
        If GRC.Connect.Libraries.CoreLib.UtilSAID.IsNotSecureWithCookie(UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.SafeGUID), zGUID, Me.Page) Then
            Dim zErrLog As New GRC.Connect.Libraries.CoreLib.UtilErrorLog : zErrLog.CreateSimpleErrorLogRecord(
                        UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.LoggedInUserEmail),
                        "IsNotSecure hit in file: " & HttpContext.Current.Request.Url.AbsolutePath,
                        HttpContext.Current.Request.Url.AbsolutePath,
                        "SAID IsNotSecure",
                        Request.ServerVariables("REMOTE_ADDR"))
            Response.Redirect("~/Home_{{VER}}/Auth/Resecure.aspx", False)
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()

        If Not Page.IsPostBack Then
            Call LoadDefaults()
        End If
        Call LoadData()
        Call ClearPageTitle()

    End Sub

    Private Sub ClearPageTitle()
        'WE ARE CLEARING THE GSAFEDETAIL PAGETITLE INFO SO AS NOT TO CONFLICT WHEN RUNNING THE TOTAL 
        Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString() & ""
        UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.PageTitle, "", UtilGSafe.KeyNameGroup.PageHeader)
    End Sub

End Class