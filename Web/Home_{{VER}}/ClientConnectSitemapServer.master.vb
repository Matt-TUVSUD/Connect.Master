Imports GRC.Connect.Libraries.CoreLib.BusinessObjects
Imports Telerik.Web.UI

Public Class ClientConnectSitemapServer
    Inherits System.Web.UI.MasterPage
    Implements IPostBackEventHandler

    Private Sub LoadDefaults()
        ' SET THE TREEVIEW FOR NAVIGATION
        Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()

    End Sub

    Private Sub LoadData()
        Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()

        'THIS SUB IS FOR LOADING HEADER INFORMATION AND OTHER NEW DATA
        ' USE OBJECT NAME objGOCSafe
        lblCompany.Text = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.ClientName)
        'lblTitle.Text = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.PageTitle)
        lblTodaysDate.Text = FormatDateTime(Date.Today(), DateFormat.LongDate)

         ' CLEAR LOCATION DETAIL NAVIGATION INFORMATION
        UtilGSafe.ClearLocationNavigationInformation(zGUID)

        '' LOOK FOR FILTERS APPLIED
        '      If GRC.Connect.Libraries.CoreLib.UtilPreference.IsFilterApplied(zGUID) = True Then
        '          lblPreferencesApplied.Visible = True
        '      Else
        '          lblPreferencesApplied.Visible = False
        '      End If

        ' SET THE ICON TEXT LINKS
        'hypMyPreferences.NavigateUrl = "~/Home_{{VER}}/Grids/FilterPreferences/FilterPreferences.aspx?sid=" & zGUID
        'hypClose.NavigateUrl = "~/Home_{{VER}}/Gauge/Default.aspx?sid=" & zGUID

        ' CREATE EVENTS FOR ICON CLICKS
        iconClose.Attributes("onclick") = Me.Page.ClientScript.GetPostBackEventReference(Me, "icoClose_Click")
        'icoMyPreferences.Attributes("onclick") = Me.Page.ClientScript.GetPostBackEventReference(Me, "icoMyPreferences_Click")

        'DB - 'Sets the FileNo Gsafe value to empty string when
        GRC.Connect.Libraries.CoreLib.UtilGSafe.ClearGSafeItems(zGUID)


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

    ' RAISE AN EVENT FOR THE ICON CLICKS
    Public Sub RaisePostBackEvent1(ByVal eventArgument As String) Implements IPostBackEventHandler.RaisePostBackEvent
        Dim zSafeGUID As String = ""
        Select Case eventArgument
            Case "icoClose_Click"
                Response.Redirect("~/Home_{{VER}}/Gauge/Default.aspx?sid=" & UtilGSafe.GetGUIDFromQueryString(), False)
            Case "icoMyPreferences_Click"
                Response.Redirect("~/Home_{{VER}}/Grids/FilterPreferences/FilterPreferences.aspx?sid=" & UtilGSafe.GetGUIDFromQueryString(), False)
        End Select

    End Sub

End Class