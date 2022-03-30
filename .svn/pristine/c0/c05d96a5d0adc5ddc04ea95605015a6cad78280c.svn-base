Imports GRC.Connect.Libraries.DataLib.razor

Public Class DataTransferUtilityForm
    Implements IUtilityForm

    Private Sub DataTransferUtilityForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadClients()
        uxWebAppMode.Text = CoreLib.UtilSystemParms.ReadWebAppMode()
    End Sub

    Private Function GetData(Optional pFilter As String = "%") As List(Of rowTblClients)

        Dim q As New queryTblClients
        q.SelectAll()
        q.Where.Or(q.colClientname.Contains(pFilter, False), q.colFileprefix.Contains(pFilter, False))

        Dim l As List(Of rowTblClients) = TblClients.LoadData(q.QueryText)

        Return l
    End Function

    Private Sub LoadClients(Optional pFilter As String = "%")

        uxClientList.ValueMember = "colFilePrefix"
        uxClientList.DisplayMember = "colClientName"
        uxClientList.DataSource = GetData(pFilter)

        uxClientList.Items.FirstOrDefault.Selected = True

    End Sub

    Public ReadOnly Property ShowOnMainMenu As Boolean Implements IUtilityForm.ShowOnMainMenu
        Get
            Return True
        End Get
    End Property

    Private Sub uxSearchBox_TextChanged(sender As Object, e As EventArgs) Handles uxSearchBox.TextChanged
        uxClientList.Items.Clear()
        LoadClients(uxSearchBox.Text)
    End Sub

    Private Sub uxDataTransferClientsOnly_Click(sender As Object, e As EventArgs) Handles uxDataTransferClientsOnly.CheckStateChanged
        Dim zData As List(Of rowTblClients) = Nothing
        uxClientList.ValueMember = "colFilePrefix"
        uxClientList.DisplayMember = "colClientName"

        If uxDataTransferClientsOnly.Checked Then
            zData = GetData(uxSearchBox.Text).FindAll(Function(x) String.IsNullOrEmpty(x.colDatatransfer) = False).FindAll(Function(x) Trim(x.colDatatransfer).Length > 0).ToList
        Else
            zData = GetData(uxSearchBox.Text)
        End If

        uxClientList.DataSource = zData
        uxClientList.Items.FirstOrDefault.Selected = True
    End Sub

    Private Sub uxClientList_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles uxClientList.SelectedIndexChanged
        If e.Position <> -1 Then
            Dim zClient As IrowTblClients = uxClientList.Items(e.Position).DataBoundItem
            uxOutputOption.Text = zClient.colDatatransfer
            uxAESEncrypKey.Text = zClient.colDataTransferEncryptionKey
            uxUrlRetrievalKey.Text = zClient.colDataTransferPassword
            uxPGPEnabled.Checked = IIf(IsNothing(zClient.colDataTransferPgpEnabled), False, zClient.colDataTransferPgpEnabled)
            uxPGPKey.Text = zClient.colDataTransferPgpPublicKey
            uxPGPExt.Text = zClient.colDataTransferPgpFileExtension
            uxFTPEnabled.Checked = IIf(IsNothing(zClient.colDataTransferFtpEnabled), False, zClient.colDataTransferFtpEnabled)
            uxFTPUrl.Text = zClient.colDataTransferFtpUrl
            uxFTPUser.Text = zClient.colDataTransferFtpUserName
            uxFTPPass.Text = zClient.colDataTransferFtpPassword
            uxFTPLocalFolder.Text = zClient.colDataTransferFtpLocalFolder
            uxFTPFileNameFormat.Text = zClient.colDataTransferFileNameFormatString
            uxClientName.Text = zClient.colClientname

            If Not IsNothing(zClient.colDataTransferFtpDayJson) Then
                uxTransferDays.Lines = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of String))(zClient.colDataTransferFtpDayJson).ToArray
            Else
                uxTransferDays.Text = ""
            End If

            If Not IsNothing(zClient.colDataTransferFtpMonthJson) Then
                uxTransferMonths.Lines = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of String))(zClient.colDataTransferFtpMonthJson).ToArray
            Else
                uxTransferMonths.Text = ""
            End If

        End If
    End Sub

  
    Private Sub uxSave_Click(sender As Object, e As EventArgs) Handles uxSave.Click
        Dim zClient As IrowTblClients = uxClientList.SelectedItem.DataBoundItem
        zClient.colDatatransfer = uxOutputOption.Text
        zClient.colDataTransferEncryptionKey = uxAESEncrypKey.Text
        zClient.colDataTransferPassword = uxUrlRetrievalKey.Text
        zClient.colDataTransferPgpEnabled = uxPGPEnabled.Checked
        zClient.colDataTransferPgpPublicKey = uxPGPKey.Text
        zClient.colDataTransferPgpFileExtension = uxPGPExt.Text
        zClient.colDataTransferFtpEnabled = uxFTPEnabled.Checked
        zClient.colDataTransferFtpUrl = uxFTPUrl.Text
        zClient.colDataTransferFtpUserName = uxFTPUser.Text
        zClient.colDataTransferFtpPassword = uxFTPPass.Text
        zClient.colDataTransferFtpLocalFolder = uxFTPLocalFolder.Text
        zClient.colDataTransferFileNameFormatString = uxFTPFileNameFormat.Text

        Dim zDays As New List(Of Integer)
        uxTransferDays.Lines.ToList.ForEach(Sub(x) zDays.Add(CInt(x)))
        zClient.colDataTransferFtpDayJson = Newtonsoft.Json.JsonConvert.SerializeObject(zDays)

        Dim zMonths As New List(Of Integer)
        uxTransferMonths.Lines.ToList.ForEach(Sub(x) zMonths.Add(CInt(x)))
        zClient.colDataTransferFtpMonthJson = Newtonsoft.Json.JsonConvert.SerializeObject(zMonths)

        TblClients.Save(uxClientList.SelectedItem.DataBoundItem)
        RadDesktopAlert1.Show()

    End Sub

    Private Sub uxRunDataTransfer_Click(sender As Object, e As EventArgs) Handles uxRunDataTransfer.Click
        Dim zDT As New DataTransferLib.UtilDataTransfer
        zDT.DoWork(uxClientList.SelectedItem.Value)
    End Sub

    Private Sub uxPopulateDaysLink_Click(sender As Object, e As EventArgs) Handles uxPopulateDays.Click
        Dim i As Integer = 1
        Dim zList As New List(Of String)
        Do While i <= 31
            zList.Add(i)
            i += 1
        Loop
        uxTransferDays.Lines = zList.ToArray()
    End Sub

    Private Sub uxPopulateMonths_Click(sender As Object, e As EventArgs) Handles uxPopulateMonths.Click
        Dim i As Integer = 1
        Dim zList As New List(Of String)
        Do While i <= 12
            zList.Add(i)
            i += 1
        Loop
        uxTransferMonths.Lines = zList.ToArray()
    End Sub
End Class