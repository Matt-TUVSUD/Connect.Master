Imports GRC.Connect.Libraries.CoreLib

Public Class ClientConnectServerMyBatch
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Page.Header.DataBind()

        If Not Page.IsPostBack Then
            Call LoadDefaults()
        End If
        Call LoadData()

    End Sub


    Private Sub LoadDefaults()

    End Sub


    Private Sub LoadData()
        'THIS SUB IS FOR LOADING HEADER INFORMATION AND OTHER NEW DATA
        Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()
        lblCompany.Text = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.ClientName)
        lblLoginName.Text = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.userFullName)
        lblTodaysDate.Text = FormatDateTime(Date.Today(), DateFormat.LongDate)
        UtilGSafe.SetValue(zGUID, UtilGSafe.KeyName.practiceName, "myBatch Reports", UtilGSafe.KeyNameGroup.PageHeader)
        lblPageTitle.Text = "myBatch Reports"

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

End Class