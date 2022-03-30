

Public Class DefaultPreferences
    Inherits System.Web.UI.Page

    Private Sub LoadDefaults()
        Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString() ' *** GRC.Connect.Scott Update 7/30/2015
        Dim zUserEmail As String = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.UserEmail)
        Dim zUserPassword As String = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.UserPassword)
        Dim zClientName As String = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.ClientName)
        Dim zFilePrefix As String = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.FilePreFix)

        'txtEmail.Text = zUserEmail
        'txtPassword.Attributes("Value") = zUserPassword
        'txtEmail.Enabled = False
        'txtPassword.Enabled = False
        txtClientSelection.Text = zClientName

        txtCurrencyDefault.Text = UtilGSafe.GetValue(zGUID, zFilePrefix, UtilGSafe.PreferenceKeyName.CurrencyDefaultText)
        txtUnitDefault.Text = UtilGSafe.GetValue(zGUID, zFilePrefix, UtilGSafe.PreferenceKeyName.UnitDefaultText)
        txtTIVDefault.Text = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.TIVDefaultText)
        txtLocationDefault.Text = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.LocationDefaultText)
        txtDivisionDefault.Text = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.Division)
        txtCustomerAccessDefault.Text = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.CustomAccessText)
        hypEditPreferences.NavigateUrl = "~/Home_{{VER}}/Preference/Edit.aspx?sid=" & zGUID
    End Sub

    Private Sub LoadLists()
        ' SHOW OR HIDE ROWS OF PREFERENCES BASED ON TYPE OF USER
        Dim zSingleUser As String = UtilGSafe.GetValue(UtilGSafe.GetGUIDFromQueryString(), UtilGSafe.KeyName.SingleUser) ' *** GRC.Connect.Scott Update 7/30/2015
        If zSingleUser.ToLower() = "true".ToLower() Then
            divDivision.Visible = False
            divCustomAccess.Visible = False
            divLocation.Visible = False
            divTIV.Visible = False
        End If

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

    Protected Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Dim zSafeGUID As String = ""
        Response.Redirect("~/Home_{{VER}}/Gauge/?sid=" & UtilGSafe.GetGUIDFromQueryString(), False)
    End Sub
End Class