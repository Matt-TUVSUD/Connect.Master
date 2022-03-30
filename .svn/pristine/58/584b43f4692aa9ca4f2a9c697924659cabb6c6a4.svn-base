Imports GRC.Connect.Libraries.DataLib.razor

Public Class UserReclassificationControl
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim zReclassAccts As List(Of rowVwReclassificationAccount) = VwReclassificationAccount.LoadData
            zReclassAccts = zReclassAccts.OrderBy(Function(x) x.colClientname).ToList
            uxReclassFilePrefixes.DataTextField = "colClientName"
            uxReclassFilePrefixes.DataValueField = "colFilePrefix"
            uxReclassFilePrefixes.DataSource = zReclassAccts
            uxReclassFilePrefixes.DataBind()
        End If
    End Sub

    Private Sub uxGenerateReclass_Click(sender As Object, e As EventArgs) Handles uxGenerateReclass.Click
        Dim zQry As New queryVwReclassificationAccount
        zQry.SelectAll()
        zQry.Where.Add(zQry.colFilePrefix.Equals(uxReclassFilePrefixes.SelectedValue))

        Dim zList As List(Of rowVwReclassificationAccount) = VwReclassificationAccount.LoadData(zQry.QueryText)
        If zList.Count > 0 Then

            Dim zObj As rowVwReclassificationAccount = zList(0)
            Dim zUtilUserReclass As New UtilUserReclassification

            If uxOptions.SelectedValue = 1 Then
                zUtilUserReclass.Setup(zObj.colFileprefix)
                uxStatus.Text = "[" & Now.ToString & "] <br> Link generated for " & Chr(34) & uxReclassFilePrefixes.SelectedItem.Text & Chr(34)
            End If

            If uxOptions.SelectedValue = 2 Then
                zUtilUserReclass.Setup(zObj.colFileprefix)
                zUtilUserReclass.Send1stRequestEmail(zObj.colFileprefix)
                uxStatus.Text = "[" & Now.ToString & "] <br> Reclassification Email for " & Chr(34) & uxReclassFilePrefixes.SelectedItem.Text & Chr(34) & " Queued Up!!"

            End If

            If uxOptions.SelectedValue = 3 Then
                zUtilUserReclass.Send2ndRequestEmail(zObj.colFileprefix)
                uxStatus.Text = "[" & Now.ToString & "] <br> Reclassification Email for " & Chr(34) & uxReclassFilePrefixes.SelectedItem.Text & Chr(34) & " Queued Up!!"
            End If

            If uxOptions.SelectedValue = 4 Then
                RadWindow1.VisibleOnPageLoad = True
            End If


            LoadClient()

        End If


    End Sub

    Private Sub uxReclassFilePrefixes_SelectedIndexChanged(sender As Object, e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles uxReclassFilePrefixes.SelectedIndexChanged
        LoadClient()
        ClearStatus()

    End Sub

    Public Sub ClearStatus()
        uxStatus.Text = ""
    End Sub

    Public Sub LoadClient()
        Dim zUtilReclass As New UtilUserReclassification
        Dim zClient As rowTblClients = TblClients.LoadByPrimaryKey(uxReclassFilePrefixes.SelectedValue)
        Dim zResetURL As String = UtilSetting.GetUserReclassificationUrl
        Dim zLink As String = Replace(zResetURL, "{{ReclassificationLinkGUID}}", zClient.colReclassificationLinkGUID)
        If Not IsNothing(zClient.colReclassificationLinkGUID) Then
            uxCurrentLink.Text = "Client Reclassification Link <br><br><a href='" & zLink & "' target='_blank'>" & zLink & "</a>"
        Else
            uxCurrentLink.Text = "No Link Created"
        End If
    End Sub

    Private Sub uxOKAuth_Click(sender As Object, e As EventArgs) Handles uxOKAuth.Click
        Dim zUtilLogin2 As New UtilLogin2
        If zUtilLogin2.AuthenticateLogin(uxConnectUsername.Text, uxConnectPassword.Text) Then
            Dim zGuid As String = zUtilLogin2.SessionSetup(uxConnectUsername.Text)
            Dim zClient As rowTblClients = TblClients.LoadByPrimaryKey(uxReclassFilePrefixes.SelectedValue)
            UtilLogin2.SetClientValuesByCldbName(zGuid, zClient.colCldbname)
            UtilUserReclassification.SendConfirmationEmail(zGuid)
            uxStatus.Text = "[" & Now.ToString & "] <br> Reclassification Email for " & Chr(34) & uxReclassFilePrefixes.SelectedItem.Text & Chr(34) & " Queued Up!!"
        End If
        LoadClient()
        RadWindow1.VisibleOnPageLoad = False

    End Sub

    Private Sub uxCancelAuth_Click(sender As Object, e As EventArgs) Handles uxCancelAuth.Click
        RadWindow1.VisibleOnPageLoad = False
    End Sub
End Class