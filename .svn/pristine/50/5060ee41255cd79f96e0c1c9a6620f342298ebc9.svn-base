
Imports Telerik.Web.UI

Public Class _Default3
    Inherits System.Web.UI.Page

    'DECLARATIONS
    ' COUNTERS USED TO DISPLAY BUTTONS IN THREE COLUMNS
    Dim rowCounter As Integer = 1

    Private Sub LoadDefaults()
        '***GRC.Connect.Ed - Replace with new function created by SB 7/29/2015
        'Dim zUserEmail As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(Request.QueryString("sid"), "UserEmail")
        'Dim zUserPassword As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(Request.QueryString("sid"), "UserPassword")
        'Dim zUserFullname As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(Request.QueryString("sid"), "userFullName")
        Dim zUserEmail As String = UtilGSafe.GetValue(UtilGSafe.GetGUIDFromQueryString(), UtilGSafe.KeyName.UserEmail)
        Dim zUserPassword As String = UtilGSafe.GetValue(UtilGSafe.GetGUIDFromQueryString(), UtilGSafe.KeyName.UserPassword)
        Dim zUserFullname As String = UtilGSafe.GetValue(UtilGSafe.GetGUIDFromQueryString(), UtilGSafe.KeyName.userFullName)

        txtEmail.Text = zUserEmail
        txtWelcome.Text = zUserFullname
        'txtPassword.Attributes("Value") = zUserPassword
        txtEmail.Enabled = False
        txtWelcome.Enabled = False
        'txtPassword.Enabled = False

        '***GRC.Connect.Ed - Replace with new function created by SB 7/29/2015
        'hypChangePassword.NavigateUrl = "~/Home_{{VER}}/Preference/Password.aspx?sid=" & Request.QueryString("sid") & "&p1=1"
        hypChangePassword.NavigateUrl = "~/Home_{{VER}}/Preference/Password.aspx?sid=" & UtilGSafe.GetGUIDFromQueryString() & "&p1=1"
        hypChangePassword.Visible = False 'TURN THIS OFF BECAUSE IT IS DONE AT LOGIN

        Page.Form.DefaultButton = btnSkip.UniqueID ' BINDS ENTER KEY TO AUTHENTICATE BUTTON

        If cboClient.Items.Count = 1 Then
            Call ProcessSelection(False)
        End If
    End Sub

    Private Sub LoadLists()
        'Clear lists
        cboClient.Items.Clear()

        'Add "none" options
        'cboPDMBudget.Items.Add(New Telerik.Web.UI.RadComboBoxItem("(None)", -1))

        'Change the collection below to use viewCCUserSecureClients to build the list of client for this user
        Using zColl As New GRC.Connect.Libraries.CoreLib.BusinessObjects.ViewCCUserSecureClientsCollection
            With zColl.Query()
                '***GRC.Connect.Ed - Replace with new function created by SB 7/29/2015
                '.Where(.GSafeGUID = Request.QueryString("sid"))
                .Where(.GSafeGUID = UtilGSafe.GetGUIDFromQueryString())
                .OrderBy(.Clientname, EntitySpaces.DynamicQuery.esOrderByDirection.Ascending)
                If .Load() Then
                    'ADD THE CLIENTS TO THE DROP DOWN LIST
                    For Each zObj As GRC.Connect.Libraries.CoreLib.BusinessObjects.ViewCCUserSecureClients In zColl
                        cboClient.Items.Add(New Telerik.Web.UI.RadComboBoxItem(zObj.Clientname, zObj.Cldbname))
                    Next
                    ''ADD THE CLIENTS TO THE BUTTON REPEATER
                    'rptClientButtons.DataSource = zColl
                    'rptClientButtons.DataBind()
                Else
                    'No clients are active for this user or all of their ezy_Users data is CCOnly = True
                    Response.Redirect("~/", False)
                End If
            End With
        End Using

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

    'Private Sub btnNext_Click(sender As Object, e As System.EventArgs) Handles btnNext.Click
    '    Call ProcessSelection(True)

    'End Sub

    Protected Sub btnSkip_Click(sender As Object, e As EventArgs) Handles btnSkip.Click
        Call ProcessSelection(False)

    End Sub

    Private Sub ProcessSelection(ByVal EditPreferences As Boolean)
        Dim zCLDBName As String = cboClient.SelectedValue
        '***GRC.Connect.Ed - Replace with new function created by SB 7/29/2015
        'Dim zSafeGUID As String = Request.QueryString("sid")
        Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()

        Call GRC.Connect.Libraries.CoreLib.UtilLogin2.SetClientValuesByCldbName(zSafeGUID, zCLDBName)

        'Response.Redirect("~/Home_{{VER}}/Preference/?sid=" & Request.QueryString("sid"), False)

        '***GRC.Connect.Ed - Replace with new function created by SB 7/29/2015
        If EditPreferences = True Then
            'Response.Redirect("~/Home_{{VER}}/Switch/SwitchRedirect.aspx?sid=" & Request.QueryString("sid") & "&p1=true", False)
            Response.Redirect("~/Home_{{VER}}/Switch/SwitchRedirect.aspx?sid=" & UtilGSafe.GetGUIDFromQueryString() & "&p1=true", False)
        Else
            'Response.Redirect("~/Home_{{VER}}/Switch/SwitchRedirect.aspx?sid=" & Request.QueryString("sid") & "&p1=false", False)
            Response.Redirect("~/Home_{{VER}}/Switch/SwitchRedirect.aspx?sid=" & UtilGSafe.GetGUIDFromQueryString() & "&p1=false", False)
        End If

    End Sub


End Class