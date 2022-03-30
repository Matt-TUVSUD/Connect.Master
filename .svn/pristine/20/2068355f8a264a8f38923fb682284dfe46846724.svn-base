
Public Class SwitchIntegrated
    Inherits System.Web.UI.Page

    Private Sub LoadDefaults()
        '***GRC.Connect.Ed - Replace with new function created by SB 7/29/2015
        'Dim zUserEmail As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(Request.QueryString("sid"), "UserEmail")
        'Dim zUserPassword As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(Request.QueryString("sid"), "UserPassword")
        'Dim zUserFullname As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(Request.QueryString("sid"), "userFullName")
        Dim zUserEmail As String = UtilGSafe.GetValue(UtilGSafe.GetGUIDFromQueryString(), UtilGSafe.KeyName.UserEmail)
        Dim zUserPassword As String = UtilGSafe.GetValue(UtilGSafe.GetGUIDFromQueryString(), UtilGSafe.KeyName.UserPassword)
        Dim zUserFullname As String = UtilGSafe.GetValue(UtilGSafe.GetGUIDFromQueryString(), UtilGSafe.KeyName.userFullName)

        Page.Form.DefaultButton = btnSkip.UniqueID ' BINDS ENTER KEY TO AUTHENTICATE BUTTON

        txtEmail.Text = zUserEmail
        txtWelcome.Text = zUserFullname
        txtEmail.Enabled = False
        txtWelcome.Enabled = False
        '***GRC.Connect.Ed - Replace with new function created by SB 7/29/2015
        'hypChangePassword.NavigateUrl = "~/Home_{{VER}}/Preference/Password.aspx?sid=" & Request.QueryString("sid") & "&p1=2"
        hypChangePassword.NavigateUrl = "~/Home_{{VER}}/Preference/Password.aspx?sid=" & UtilGSafe.GetGUIDFromQueryString() & "&p1=2"
        'hypRecentActivity.NavigateUrl = "https://clientsweb.globalriskconsultants.com/recentactivity.cfm" ' USE CLIENT LINK INSTEAD FOR POPUP
        hypGRCConnectTest.NavigateUrl = "https://grcconnect.globalriskconsultants.com/test/"
        hypGRCConnectLive.NavigateUrl = "https://grcconnect.globalriskconsultants.com/app/"
        'hypTestSite.NavigateUrl = "http://clientswebtest.globalriskconsultants.com/"
        'hypLiveSite.NavigateUrl = "https://clientsweb.globalriskconsultants.com/index2.cfm" '"https://clientsweb.globalriskconsultants.com/"
        hypSystemTools.NavigateUrl = "http://app.globalriskconsultants.com/clientwebtools/app/"

    End Sub


    Private Sub LoadLists()
        Try
            '***GRC.Connect.Ed - Replace with new function created by SB 7/29/2015
            'Dim zUserEmail As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(Request.QueryString("sid"), "UserEmail")
            'Dim zUserPassword As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(Request.QueryString("sid"), "UserPassword")
            'Dim zUserEmail As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(UtilGSafe.GetGUIDFromQueryString(), UtilGSafe.KeyName.UserEmail)
            'Dim zUserPassword As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(UtilGSafe.GetGUIDFromQueryString(), UtilGSafe.KeyName.UserPassword)
            Dim zLoginId As Integer = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(UtilGSafe.GetGUIDFromQueryString(), UtilGSafe.KeyName.EzyLoginId)
            Dim zAdminType = GRC.Connect.Libraries.CoreLib.UtilLogin2.GetGRCAdministrator(zLoginId)
            'Dim zGSafeGUID As String = Request.QueryString("sid")
            Dim zGSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
            Dim zSortOrder As String = Request.QueryString("s1")
            Dim zTotal As Integer = 0
            Dim zColumnCount As Integer = 0

            ' GET THE TOTAL COUNT AVAILABLE IN GSAFEHEADER
            Dim zCollCount As New GRC.Connect.Libraries.CoreLib.BusinessObjects.ViewCCUserSecureClientsCollection
            Dim zQry As New GRC.Connect.Libraries.CoreLib.BusinessObjects.ViewCCUserSecureClientsQuery
            zQry.Where(zQry._580active = True)
            '***GRC.Connect.Ed - Replace with new function created by SB 7/29/2015
            'zQry.Where(zQry.GSafeGUID = Request.QueryString("sid"))
            zQry.Where(zQry.GSafeGUID = UtilGSafe.GetGUIDFromQueryString())
            zCollCount.Load(zQry)

            With zCollCount.Query()
                .Where(.GSafeGUID = zGSafeGUID)
                If .Load() Then
                    zTotal = zCollCount.Count
                    zColumnCount = (zTotal / 5) + 1
                End If
            End With

            ' BUILD OR HIDE THE REPEATER LIST
            If zColumnCount < 10 Then
                Call BuildColumns2((zTotal / 2) + 1)
            Else
                Call BuildColumns5(zColumnCount)
                'Call BuildColumns6(zColumnCount)
            End If

            ' CLEAR THEN BUILD THE DROPDOWN LISTS
            cboClientByFilePrefix.Items.Clear()
            cboClientByName.Items.Clear()

            If zAdminType = "04" Then

                ' POPULATE THE NAME SORTED DROPDOWN
                cboClientByName.Items.Add(New Telerik.Web.UI.RadComboBoxItem("-- Please Select --", -1))
                Using zCollDropDown As New GRC.Connect.Libraries.CoreLib.BusinessObjects.ViewCCUserSecureClientsCollection
                    With zCollDropDown.Query()
                        .Where(.GSafeGUID = zGSafeGUID, .Fileprefix <> "", .Cldbname <> "", .Clientname <> "")
                        .OrderBy(.Clientname, EntitySpaces.DynamicQuery.esOrderByDirection.Ascending)
                        If .Load() Then
                            'ADD THE CLIENTS TO THE DROP DOWN LIST
                            For Each zObj As GRC.Connect.Libraries.CoreLib.BusinessObjects.ViewCCUserSecureClients In zCollDropDown
                                cboClientByName.Items.Add(New Telerik.Web.UI.RadComboBoxItem(zObj.Clientname & " - " & zObj.Fileprefix, zObj.Cldbname))
                            Next
                        End If
                    End With
                End Using

                ' POPULATE THE FILE PREFIX SORTED DROPDOWN
                cboClientByFilePrefix.Items.Add(New Telerik.Web.UI.RadComboBoxItem("-- Please Select --", -1))
                Using zCollDropDown As New GRC.Connect.Libraries.CoreLib.BusinessObjects.ViewCCUserSecureClientsCollection
                    With zCollDropDown.Query()
                        .Where(.GSafeGUID = zGSafeGUID, .Fileprefix <> "", .Cldbname <> "", .Clientname <> "")
                        .OrderBy(.Fileprefix, EntitySpaces.DynamicQuery.esOrderByDirection.Ascending)
                        If .Load() Then
                            'ADD THE CLIENTS TO THE DROP DOWN LIST
                            For Each zObj As GRC.Connect.Libraries.CoreLib.BusinessObjects.ViewCCUserSecureClients In zCollDropDown
                                cboClientByFilePrefix.Items.Add(New Telerik.Web.UI.RadComboBoxItem(zObj.Fileprefix & " - " & zObj.Clientname, zObj.Cldbname))
                            Next
                        End If
                    End With
                End Using

            Else

                ' POPULATE THE NAME SORTED DROPDOWN
                cboClientByName.Items.Add(New Telerik.Web.UI.RadComboBoxItem("-- Please Select --", -1))
                Using zCollDropDown As New GRC.Connect.Libraries.CoreLib.BusinessObjects.ViewCCAllClientsCollection
                    With zCollDropDown.Query()
                        .Where(.Fileprefix <> "", .Cldbname <> "", .Clientname <> "")
                        .OrderBy(.Clientname, EntitySpaces.DynamicQuery.esOrderByDirection.Ascending)
                        If .Load() Then
                            'ADD THE CLIENTS TO THE DROP DOWN LIST
                            For Each zObj As GRC.Connect.Libraries.CoreLib.BusinessObjects.ViewCCAllClients In zCollDropDown
                                cboClientByName.Items.Add(New Telerik.Web.UI.RadComboBoxItem(zObj.Clientname & " - " & zObj.Fileprefix, zObj.Cldbname))
                            Next
                        End If
                    End With
                End Using

                ' POPULATE THE FILE PREFIX SORTED DROPDOWN
                cboClientByFilePrefix.Items.Add(New Telerik.Web.UI.RadComboBoxItem("-- Please Select --", -1))
                Using zCollDropDown As New GRC.Connect.Libraries.CoreLib.BusinessObjects.ViewCCAllClientsCollection
                    With zCollDropDown.Query()
                        .Where(.Fileprefix <> "", .Cldbname <> "", .Clientname <> "")
                        .OrderBy(.Fileprefix, EntitySpaces.DynamicQuery.esOrderByDirection.Ascending)
                        If .Load() Then
                            'ADD THE CLIENTS TO THE DROP DOWN LIST
                            For Each zObj As GRC.Connect.Libraries.CoreLib.BusinessObjects.ViewCCAllClients In zCollDropDown
                                cboClientByFilePrefix.Items.Add(New Telerik.Web.UI.RadComboBoxItem(zObj.Fileprefix & " - " & zObj.Clientname, zObj.Cldbname))
                            Next
                        End If
                    End With
                End Using

            End If

        Catch ex As Exception
            MsgBox("Unknown error while loading client list.")
        End Try

    End Sub


    Private Sub LoadData()
        '***GRC.Connect.Ed - Replace with new function created by SB 7/29/2015
        'Dim zUserEmail As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(Request.QueryString("sid"), "UserEmail")
        'Dim zUserPassword As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(Request.QueryString("sid"), "UserPassword")
        'Dim zUserEmail As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(UtilGSafe.GetGUIDFromQueryString(), UtilGSafe.KeyName.UserEmail)
        'Dim zUserPassword As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(UtilGSafe.GetGUIDFromQueryString(), UtilGSafe.KeyName.UserPassword)
        'Dim zAdminType = GRC.Connect.Libraries.CoreLib.UtilLogin.GetGRCAdministrator(zUserEmail, zUserPassword)
        Dim zLoginId As Integer = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(UtilGSafe.GetGUIDFromQueryString(), UtilGSafe.KeyName.EzyLoginId)
        Dim zAdminType = GRC.Connect.Libraries.CoreLib.UtilLogin2.GetGRCAdministrator(zLoginId)

        Select Case zAdminType
            Case "00"
                lblSwitchTitle.Text = "Client Database Selection"
                divLinks.Visible = True
                divComboContainer.Visible = True
                divMainListContainer.Visible = True
                divSecondaryEnterButton.Visible = True
                divThirdEnterButtons.Visible = False
                divPreferences.Visible = True
                hypChangePassword.Visible = False
                'hypViewRecentActivity.Visible = True
                divSecondaryLogo.Visible = False
                divSideGraphic.Visible = False
                divSecondaryTitle.Visible = False
                divSecondaryInstructions.Visible = False
                spnButtonSpace.Visible = False
                btnNext.Visible = False
                divSecondaryNotice.Visible = False
                divSecondaryExtraPadding.Visible = False
            Case "01"
                lblSwitchTitle.Text = "Administration Client Selection"
                divLinks.Visible = False
                divComboContainer.Visible = True
                divMainListContainer.Visible = True
                divSecondaryEnterButton.Visible = True
                divThirdEnterButtons.Visible = False
                divPreferences.Visible = True
                hypChangePassword.Visible = False
                'hypViewRecentActivity.Visible = True
                divSecondaryLogo.Visible = False
                divSideGraphic.Visible = False
                divSecondaryTitle.Visible = False
                divSecondaryInstructions.Visible = False
                spnButtonSpace.Visible = False
                btnNext.Visible = False
                divSecondaryNotice.Visible = False
                divSecondaryExtraPadding.Visible = False
            Case "04"
                lblSwitchTitle.Text = "Client Selection"
                divLinks.Visible = False
                divComboContainer.Visible = True
                divMainListContainer.Visible = False
                divSecondaryEnterButton.Visible = False
                divThirdEnterButtons.Visible = True
                divPreferences.Visible = True
                hypChangePassword.Visible = False
                'hypViewRecentActivity.Visible = False
                divSecondaryLogo.Visible = True
                divSideGraphic.Visible = True
                divSecondaryTitle.Visible = True
                divSecondaryInstructions.Visible = True
                spnButtonSpace.Visible = False
                btnNext.Visible = False
                divSecondaryNotice.Visible = True
                divSecondaryExtraPadding.Visible = True
            Case Else
                lblSwitchTitle.Text = "Client Selection"
                divLinks.Visible = False
                divComboContainer.Visible = True
                divMainListContainer.Visible = False
                divSecondaryEnterButton.Visible = False
                divThirdEnterButtons.Visible = True
                divPreferences.Visible = True
                hypChangePassword.Visible = False
                'hypViewRecentActivity.Visible = False
                divSecondaryTitle.Visible = True
                divSecondaryInstructions.Visible = True
                spnButtonSpace.Visible = False
                btnNext.Visible = False
                divSecondaryNotice.Visible = True
                divSecondaryExtraPadding.Visible = True
        End Select

    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then
            Call LoadLists()
            Call LoadDefaults()
        End If

        Call LoadData()

    End Sub


    Private Sub btnNext_Click(sender As Object, e As System.EventArgs) Handles btnNext.Click
        Call ProcessSelectionByButton(True)
    End Sub


    Protected Sub btnSkip_Click(sender As Object, e As EventArgs) Handles btnSkip.Click
        Call ProcessSelectionByButton(False)
    End Sub


    Protected Sub btnSkip2_Click(sender As Object, e As EventArgs) Handles btnSkip2.Click
        Call ProcessSelectionByButton(False)
    End Sub


    Private Sub ProcessSelectionByLink(ByRef pItem As System.Web.UI.WebControls.RepeaterCommandEventArgs)
        '***GRC.Connect.Ed - Replace with new function created by SB 7/29/2015
        'Dim zSafeGUID As String = Request.QueryString("sid")
        Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Dim zSafeId As Integer = UtilGSafe.GetId(zSafeGUID)
        Dim zCLDBName As String = CType(pItem.Item.FindControl("hidCLDBName"), HiddenField).Value
        UtilGSafe.ClearDataGroup(zSafeGUID, UtilGSafe.KeyNameGroup.ChartPreFilter)
        UtilGSafe.ClearDataGroup(zSafeGUID, UtilGSafe.KeyNameGroup.ReportPreFilter)
        UtilGSafe.ClearDataGroup(zSafeGUID, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.ClearDataGroup(zSafeGUID, UtilGSafe.KeyNameGroup.LocationSelection)
        UtilSafe.ResetLargeObjectData(zSafeId)

        Dim zSW As New Stopwatch
        zSW.Start()
        Call GRC.Connect.Libraries.CoreLib.UtilLogin2.SetClientValuesByCldbName(zSafeGUID, zCLDBName)
        zSW.Stop()
        Diagnostics.Trace.WriteLine("UtilLogin2.SetClientValues: " & zSW.Elapsed.ToString)

        If chkEditPreferences.Checked = True Then
            Response.Redirect("~/Home_{{VER}}/Switch/SwitchRedirect.aspx?sid=" & zSafeGUID & "&p1=true", False)
        Else
            Response.Redirect("~/Home_{{VER}}/Switch/SwitchRedirect.aspx?sid=" & zSafeGUID & "&p1=false", False)
        End If
    End Sub


    Private Sub ProcessSelectionByButton(ByVal EditPreferences As Boolean)
        Dim zCLDBName As String = cboClientByName.SelectedValue
        '***GRC.Connect.Ed - Replace with new function created by SB 7/29/2015
        'Dim zSafeGUID As String = Request.QueryString("sid")
        Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()

        If zCLDBName <> "-1" And zCLDBName <> "" Then
            Call GRC.Connect.Libraries.CoreLib.UtilLogin2.SetClientValuesByCldbName(zSafeGUID, zCLDBName)
            If EditPreferences = True Then
                Response.Redirect("~/Home_{{VER}}/Switch/SwitchRedirect.aspx?sid=" & zSafeGUID & "&p1=true", False)
            Else
                Response.Redirect("~/Home_{{VER}}/Switch/SwitchRedirect.aspx?sid=" & zSafeGUID & "&p1=false", False)
            End If
        Else
            lblMessage.Text = "Please choose a client name from the dropdown lists above if clicking the 'Connect Now' or 'Edit Preferences' buttons.<br />"
        End If

    End Sub


#Region "Build Columns"

    Private Sub BuildColumns2(ByVal pColumnCount As Integer)
        '***GRC.Connect.Ed - Replace with new function created by SB 7/29/2015
        'Dim zGSafeGUID As String = Request.QueryString("sid")
        Dim zGSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Dim zCollNames As New GRC.Connect.Libraries.CoreLib.BusinessObjects.ViewCCUserSecureClientsCollection
        Dim zQry As New GRC.Connect.Libraries.CoreLib.BusinessObjects.ViewCCUserSecureClientsQuery
        zQry.Where(zQry._580active = True)
        'zQry.Where(zQry.GSafeGUID = Request.QueryString("sid"))
        zQry.Where(zQry.GSafeGUID = UtilGSafe.GetGUIDFromQueryString())
        zCollNames.Load(zQry)
        ' BY NAME
        With zCollNames.Query()
            .es.PageSize = pColumnCount
            .es.PageNumber = 1
            .Where(.GSafeGUID = zGSafeGUID)
            .OrderBy(.Clientname, EntitySpaces.DynamicQuery.esOrderByDirection.Ascending)
            If .Load() Then
                rptSwitchCol1.DataSource = zCollNames
                rptSwitchCol1.DataBind()
            End If
        End With
        With zCollNames.Query()
            .es.PageSize = pColumnCount
            .es.PageNumber = 2
            .Where(.GSafeGUID = zGSafeGUID)
            .OrderBy(.Clientname, EntitySpaces.DynamicQuery.esOrderByDirection.Ascending)
            If .Load() Then
                rptSwitchCol2.DataSource = zCollNames
                rptSwitchCol2.DataBind()
            End If
        End With

        ' BY FILE PREFIX
        zCollNames = New GRC.Connect.Libraries.CoreLib.BusinessObjects.ViewCCUserSecureClientsCollection
        With zCollNames.Query()
            .es.PageSize = pColumnCount
            .es.PageNumber = 1
            .Where(.GSafeGUID = zGSafeGUID)
            .OrderBy(.Fileprefix, EntitySpaces.DynamicQuery.esOrderByDirection.Ascending)
            If .Load() Then
                rptSwitchFilePrefixCol1.DataSource = zCollNames
                rptSwitchFilePrefixCol1.DataBind()
            End If
        End With
        With zCollNames.Query()
            .es.PageSize = pColumnCount
            .es.PageNumber = 2
            .Where(.GSafeGUID = zGSafeGUID)
            .OrderBy(.Fileprefix, EntitySpaces.DynamicQuery.esOrderByDirection.Ascending)
            If .Load() Then
                rptSwitchFilePrefixCol2.DataSource = zCollNames
                rptSwitchFilePrefixCol2.DataBind()
            End If
        End With

    End Sub

    Private Sub BuildColumns5(ByVal pColumnCount As Integer)
        '***GRC.Connect.Ed - Replace with new function created by SB 7/29/2015
        'Dim zGSafeGUID As String = Request.QueryString("sid")
        Dim zGSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Dim zCollNames As New GRC.Connect.Libraries.CoreLib.BusinessObjects.ViewCCUserSecureClientsCollection
        Dim zQry As New GRC.Connect.Libraries.CoreLib.BusinessObjects.ViewCCUserSecureClientsQuery
        zQry.Where(zQry._580active = True)
        'zQry.Where(zQry.GSafeGUID = Request.QueryString("sid"))
        zQry.Where(zQry.GSafeGUID = UtilGSafe.GetGUIDFromQueryString())
        zCollNames.Load(zQry)

        ' LIST BY NAME
        With zCollNames.Query()
            .es.PageSize = pColumnCount
            .es.PageNumber = 1
            .Where(.GSafeGUID = zGSafeGUID)
            .OrderBy(.Clientname, EntitySpaces.DynamicQuery.esOrderByDirection.Ascending)
            If .Load() Then
                rptSwitchCol1.DataSource = zCollNames
                rptSwitchCol1.DataBind()
            End If
        End With
        With zCollNames.Query()
            .es.PageSize = pColumnCount
            .es.PageNumber = 2
            .Where(.GSafeGUID = zGSafeGUID)
            .OrderBy(.Clientname, EntitySpaces.DynamicQuery.esOrderByDirection.Ascending)
            If .Load() Then
                rptSwitchCol2.DataSource = zCollNames
                rptSwitchCol2.DataBind()
            End If
        End With
        With zCollNames.Query()
            .es.PageSize = pColumnCount
            .es.PageNumber = 3
            .Where(.GSafeGUID = zGSafeGUID)
            .OrderBy(.Clientname, EntitySpaces.DynamicQuery.esOrderByDirection.Ascending)
            If .Load() Then
                rptSwitchCol3.DataSource = zCollNames
                rptSwitchCol3.DataBind()
            End If
        End With
        With zCollNames.Query()
            .es.PageSize = pColumnCount
            .es.PageNumber = 4
            .Where(.GSafeGUID = zGSafeGUID)
            .OrderBy(.Clientname, EntitySpaces.DynamicQuery.esOrderByDirection.Ascending)
            If .Load() Then
                rptSwitchCol4.DataSource = zCollNames
                rptSwitchCol4.DataBind()
            End If
        End With
        With zCollNames.Query()
            .es.PageSize = pColumnCount
            .es.PageNumber = 5
            .Where(.GSafeGUID = zGSafeGUID)
            .OrderBy(.Clientname, EntitySpaces.DynamicQuery.esOrderByDirection.Ascending)
            If .Load() Then
                rptSwitchCol5.DataSource = zCollNames
                rptSwitchCol5.DataBind()
            End If
        End With

        ' LIST BY FILE PREFIX
        zCollNames = New GRC.Connect.Libraries.CoreLib.BusinessObjects.ViewCCUserSecureClientsCollection
        zQry = New GRC.Connect.Libraries.CoreLib.BusinessObjects.ViewCCUserSecureClientsQuery
        zQry.Where(zQry._580active = True)
        'zQry.Where(zQry.GSafeGUID = Request.QueryString("sid"))
        zQry.Where(zQry.GSafeGUID = UtilGSafe.GetGUIDFromQueryString())
        zCollNames.Load(zQry)

        With zCollNames.Query()
            .es.PageSize = pColumnCount
            .es.PageNumber = 1
            .Where(.GSafeGUID = zGSafeGUID)
            .OrderBy(.Fileprefix, EntitySpaces.DynamicQuery.esOrderByDirection.Ascending)
            If .Load() Then
                rptSwitchFilePrefixCol1.DataSource = zCollNames
                rptSwitchFilePrefixCol1.DataBind()
            End If
        End With
        With zCollNames.Query()
            .es.PageSize = pColumnCount
            .es.PageNumber = 2
            .Where(.GSafeGUID = zGSafeGUID)
            .OrderBy(.Fileprefix, EntitySpaces.DynamicQuery.esOrderByDirection.Ascending)
            If .Load() Then
                rptSwitchFilePrefixCol2.DataSource = zCollNames
                rptSwitchFilePrefixCol2.DataBind()
            End If
        End With
        With zCollNames.Query()
            .es.PageSize = pColumnCount
            .es.PageNumber = 3
            .Where(.GSafeGUID = zGSafeGUID)
            .OrderBy(.Fileprefix, EntitySpaces.DynamicQuery.esOrderByDirection.Ascending)
            If .Load() Then
                rptSwitchFilePrefixCol3.DataSource = zCollNames
                rptSwitchFilePrefixCol3.DataBind()
            End If
        End With
        With zCollNames.Query()
            .es.PageSize = pColumnCount
            .es.PageNumber = 4
            .Where(.GSafeGUID = zGSafeGUID)
            .OrderBy(.Fileprefix, EntitySpaces.DynamicQuery.esOrderByDirection.Ascending)
            If .Load() Then
                rptSwitchFilePrefixCol4.DataSource = zCollNames
                rptSwitchFilePrefixCol4.DataBind()
            End If
        End With
        With zCollNames.Query()
            .es.PageSize = pColumnCount
            .es.PageNumber = 5
            .Where(.GSafeGUID = zGSafeGUID)
            .OrderBy(.Fileprefix, EntitySpaces.DynamicQuery.esOrderByDirection.Ascending)
            If .Load() Then
                rptSwitchFilePrefixCol5.DataSource = zCollNames
                rptSwitchFilePrefixCol5.DataBind()
            End If
        End With


    End Sub

    Private Sub BuildColumns6(ByVal pColumnCount As Integer)
        '***GRC.Connect.Ed - Replace with new function created by SB 7/29/2015
        'Dim zGSafeGUID As String = Request.QueryString("sid")
        Dim zGSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Dim zCollNames As New GRC.Connect.Libraries.CoreLib.BusinessObjects.ViewCCUserSecureClientsCollection

        ' LIST BY NAME
        With zCollNames.Query()
            .es.PageSize = pColumnCount
            .es.PageNumber = 1
            .Where(.GSafeGUID = zGSafeGUID)
            .OrderBy(.Clientname, EntitySpaces.DynamicQuery.esOrderByDirection.Ascending)
            If .Load() Then
                rptSwitchCol1.DataSource = zCollNames
                rptSwitchCol1.DataBind()
            End If
        End With
        With zCollNames.Query()
            .es.PageSize = pColumnCount
            .es.PageNumber = 2
            .Where(.GSafeGUID = zGSafeGUID)
            .OrderBy(.Clientname, EntitySpaces.DynamicQuery.esOrderByDirection.Ascending)
            If .Load() Then
                rptSwitchCol2.DataSource = zCollNames
                rptSwitchCol2.DataBind()
            End If
        End With
        With zCollNames.Query()
            .es.PageSize = pColumnCount
            .es.PageNumber = 3
            .Where(.GSafeGUID = zGSafeGUID)
            .OrderBy(.Clientname, EntitySpaces.DynamicQuery.esOrderByDirection.Ascending)
            If .Load() Then
                rptSwitchCol3.DataSource = zCollNames
                rptSwitchCol3.DataBind()
            End If
        End With
        With zCollNames.Query()
            .es.PageSize = pColumnCount
            .es.PageNumber = 4
            .Where(.GSafeGUID = zGSafeGUID)
            .OrderBy(.Clientname, EntitySpaces.DynamicQuery.esOrderByDirection.Ascending)
            If .Load() Then
                rptSwitchCol4.DataSource = zCollNames
                rptSwitchCol4.DataBind()
            End If
        End With
        With zCollNames.Query()
            .es.PageSize = pColumnCount
            .es.PageNumber = 5
            .Where(.GSafeGUID = zGSafeGUID)
            .OrderBy(.Clientname, EntitySpaces.DynamicQuery.esOrderByDirection.Ascending)
            If .Load() Then
                rptSwitchCol5.DataSource = zCollNames
                rptSwitchCol5.DataBind()
            End If
        End With
        With zCollNames.Query()
            .es.PageSize = pColumnCount
            .es.PageNumber = 6
            .Where(.GSafeGUID = zGSafeGUID)
            .OrderBy(.Clientname, EntitySpaces.DynamicQuery.esOrderByDirection.Ascending)
            If .Load() Then
                rptSwitchCol6.DataSource = zCollNames
                rptSwitchCol6.DataBind()
            End If
        End With

        ' LIST BY FILE PREFIX
        zCollNames = New GRC.Connect.Libraries.CoreLib.BusinessObjects.ViewCCUserSecureClientsCollection
        With zCollNames.Query()
            .es.PageSize = pColumnCount
            .es.PageNumber = 1
            .Where(.GSafeGUID = zGSafeGUID)
            .OrderBy(.Fileprefix, EntitySpaces.DynamicQuery.esOrderByDirection.Ascending)
            If .Load() Then
                rptSwitchFilePrefixCol1.DataSource = zCollNames
                rptSwitchFilePrefixCol1.DataBind()
            End If
        End With
        With zCollNames.Query()
            .es.PageSize = pColumnCount
            .es.PageNumber = 2
            .Where(.GSafeGUID = zGSafeGUID)
            .OrderBy(.Fileprefix, EntitySpaces.DynamicQuery.esOrderByDirection.Ascending)
            If .Load() Then
                rptSwitchFilePrefixCol2.DataSource = zCollNames
                rptSwitchFilePrefixCol2.DataBind()
            End If
        End With
        With zCollNames.Query()
            .es.PageSize = pColumnCount
            .es.PageNumber = 3
            .Where(.GSafeGUID = zGSafeGUID)
            .OrderBy(.Fileprefix, EntitySpaces.DynamicQuery.esOrderByDirection.Ascending)
            If .Load() Then
                rptSwitchFilePrefixCol3.DataSource = zCollNames
                rptSwitchFilePrefixCol3.DataBind()
            End If
        End With
        With zCollNames.Query()
            .es.PageSize = pColumnCount
            .es.PageNumber = 4
            .Where(.GSafeGUID = zGSafeGUID)
            .OrderBy(.Fileprefix, EntitySpaces.DynamicQuery.esOrderByDirection.Ascending)
            If .Load() Then
                rptSwitchFilePrefixCol4.DataSource = zCollNames
                rptSwitchFilePrefixCol4.DataBind()
            End If
        End With
        With zCollNames.Query()
            .es.PageSize = pColumnCount
            .es.PageNumber = 5
            .Where(.GSafeGUID = zGSafeGUID)
            .OrderBy(.Fileprefix, EntitySpaces.DynamicQuery.esOrderByDirection.Ascending)
            If .Load() Then
                rptSwitchFilePrefixCol5.DataSource = zCollNames
                rptSwitchFilePrefixCol5.DataBind()
            End If
        End With
        With zCollNames.Query()
            .es.PageSize = pColumnCount
            .es.PageNumber = 6
            .Where(.GSafeGUID = zGSafeGUID)
            .OrderBy(.Fileprefix, EntitySpaces.DynamicQuery.esOrderByDirection.Ascending)
            If .Load() Then
                rptSwitchFilePrefixCol6.DataSource = zCollNames
                rptSwitchFilePrefixCol6.DataBind()
            End If
        End With


    End Sub

#End Region


#Region "Repeater Clicks"

    Protected Sub rptSwitchCol1_ItemCommand(source As Object, e As System.Web.UI.WebControls.RepeaterCommandEventArgs) Handles rptSwitchCol1.ItemCommand
        Call ProcessSelectionByLink(e)
    End Sub

    Protected Sub rptSwitchCol2_ItemCommand(source As Object, e As System.Web.UI.WebControls.RepeaterCommandEventArgs) Handles rptSwitchCol2.ItemCommand
        Call ProcessSelectionByLink(e)
    End Sub

    Protected Sub rptSwitchCol3_ItemCommand(source As Object, e As System.Web.UI.WebControls.RepeaterCommandEventArgs) Handles rptSwitchCol3.ItemCommand
        Call ProcessSelectionByLink(e)
    End Sub

    Protected Sub rptSwitchCol4_ItemCommand(source As Object, e As System.Web.UI.WebControls.RepeaterCommandEventArgs) Handles rptSwitchCol4.ItemCommand
        Call ProcessSelectionByLink(e)
    End Sub

    Protected Sub rptSwitchCol5_ItemCommand(source As Object, e As System.Web.UI.WebControls.RepeaterCommandEventArgs) Handles rptSwitchCol5.ItemCommand
        Call ProcessSelectionByLink(e)
    End Sub

    Protected Sub rptSwitchCol6_ItemCommand(source As Object, e As System.Web.UI.WebControls.RepeaterCommandEventArgs) Handles rptSwitchCol6.ItemCommand
        Call ProcessSelectionByLink(e)
    End Sub

    Protected Sub rptSwitchFilePrefixCol1_ItemCommand(source As Object, e As System.Web.UI.WebControls.RepeaterCommandEventArgs) Handles rptSwitchFilePrefixCol1.ItemCommand
        Call ProcessSelectionByLink(e)
    End Sub

    Protected Sub rptSwitchFilePrefixCol2_ItemCommand(source As Object, e As System.Web.UI.WebControls.RepeaterCommandEventArgs) Handles rptSwitchFilePrefixCol2.ItemCommand
        Call ProcessSelectionByLink(e)
    End Sub

    Protected Sub rptSwitchFilePrefixCol3_ItemCommand(source As Object, e As System.Web.UI.WebControls.RepeaterCommandEventArgs) Handles rptSwitchFilePrefixCol3.ItemCommand
        Call ProcessSelectionByLink(e)
    End Sub

    Protected Sub rptSwitchFilePrefixCol4_ItemCommand(source As Object, e As System.Web.UI.WebControls.RepeaterCommandEventArgs) Handles rptSwitchFilePrefixCol4.ItemCommand
        Call ProcessSelectionByLink(e)
    End Sub

    Protected Sub rptSwitchFilePrefixCol5_ItemCommand(source As Object, e As System.Web.UI.WebControls.RepeaterCommandEventArgs) Handles rptSwitchFilePrefixCol5.ItemCommand
        Call ProcessSelectionByLink(e)
    End Sub

    Protected Sub rptSwitchFilePrefixCol6_ItemCommand(source As Object, e As System.Web.UI.WebControls.RepeaterCommandEventArgs) Handles rptSwitchFilePrefixCol6.ItemCommand
        Call ProcessSelectionByLink(e)
    End Sub

#End Region

End Class