Imports GRC.Connect.Libraries.CoreLib.BusinessObjects


Public Class ClientConnectExtractServer
    Inherits System.Web.UI.MasterPage

    Private Sub LoadDefaults()
        'THIS SUB IS FOR NAV MENU AND OTHER DEFAULT INFO ON MASTER PAGE
    End Sub

    Private Sub LoadData()
        'THIS SUB IS FOR LOADING HEADER INFORMATION AND OTHER NEW DATA
        ' USE OBJECT NAME objGOCSafe
        Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()
        lblCompany.Text = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.ClientName) ' "ABC Company"
        lblLoginName.Text = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.userFullName)  '"Gary Kidney"  
        lblTodaysDate.Text = FormatDateTime(Date.Today(), DateFormat.LongDate)
        lblPageTitle.Text = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.practiceName)      ' "Fire Program"

        ' IF NAVIGATING FROM A CHART, THEN MAKE BACK BUTTON VISIBLE
        icoBackArrowVisibleContainer.Visible = False
        If Not Request.QueryString("c1") Is Nothing Then
            If Request.QueryString("c1") = "true" Then
                icoBackArrowVisibleContainer.Visible = True
            End If
        End If

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
            Response.Redirect("~/Home_{{VER}}/Auth/Resecure.aspx", False)
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