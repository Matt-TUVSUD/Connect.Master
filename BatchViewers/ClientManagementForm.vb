Imports GRC.Connect.Libraries.DataLib.razor

Public Class ClientManagementForm
    Implements IUtilityForm

    Private Sub ClientManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim zClients As List(Of rowTblClients) = TblClients.LoadData()
        RadListControl1.DataSource = zClients
        RadListControl1.ValueMember = rowTblClients.FieldIndex.colClientname.ToString
        RadListControl1.DataMember = rowTblClients.FieldIndex.colFileprefix.ToString

        Dim zDT As New ClientManagementForm.DataTransfer(Me)

    End Sub

    Public Class DataTransfer

        Dim Form As ClientManagementForm

        Public Sub New(pForm As ClientManagementForm)
            Form = pForm
            AddHandler Form.RadTextBoxControl1.TextChanged, AddressOf RadTextBoxControl1_TextChanged
            AddHandler Form.RadListControl1.SelectedIndexChanged, AddressOf RadListControl1_SelectedIndexChanged
            AddHandler Form.uxCopy.Click, AddressOf RadButton1_Click
            AddHandler Form.uxPaste.Click, AddressOf uxPaste_Click
            AddHandler Form.uxClear.Click, AddressOf uxClear_Click
            AddHandler Form.uxSave.Click, AddressOf uxSave_Click
            AddHandler Form.uxRun.Click, AddressOf uxRun_Click
        End Sub

        Private _clientCopy As rowTblClients = Nothing

        Private Sub RadTextBoxControl1_TextChanged(sender As Object, e As EventArgs)
            Dim zFilter As Object = Form.RadTextBoxControl1.Text
            If IsNumeric(zFilter) Then
                Form.RadListControl1.FilterExpression = "colFilePrefix like '%" & zFilter & "%'"
            Else
                Form.RadListControl1.FilterExpression = "colclientname like '%" & zFilter & "%'"
            End If
        End Sub

        Private Sub RadListControl1_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            If Not IsNothing(Form.RadListControl1.SelectedItem) Then
                Dim zitem As rowTblClients = Form.RadListControl1.SelectedItem.DataBoundItem
                Form.uxAESPassword.Text = zitem.colDataTransferPassword
                Form.uxType.Text = zitem.colDatatransfer
                Form.uxAESEncryption.Text = zitem.colDataTransferEncryptionKey
                Form.uxPGPEnabled.Checked = IIf(IsNothing(zitem.colDataTransferPgpEnabled), False, zitem.colDataTransferPgpEnabled)
                Form.uxPGPkey.Text = zitem.colDataTransferPgpPublicKey
                Form.uxFTPUrl.Text = zitem.colDataTransferFtpUrl
                Form.uxFTPPassword.Text = zitem.colDataTransferFtpPassword
                Form.uxFTPUser.Text = zitem.colDataTransferFtpUserName
                Form.uxFileExtension.Text = zitem.colDataTransferPgpFileExtension
            End If
        End Sub

        Private Sub RadButton1_Click(sender As Object, e As EventArgs)
            _clientCopy = Form.RadListControl1.SelectedItem.DataBoundItem
            Form.uxCopy.Enabled = False
            Form.uxPaste.Enabled = True
        End Sub

        Private Sub uxPaste_Click(sender As Object, e As EventArgs)
            Form.uxPGPEnabled.Checked = IIf(IsNothing(_clientCopy.colDataTransferPgpEnabled), False, _clientCopy.colDataTransferPgpEnabled)
            Form.uxPGPkey.Text = _clientCopy.colDataTransferPgpPublicKey
            Form.uxFTPUrl.Text = _clientCopy.colDataTransferFtpUrl
            Form.uxFTPPassword.Text = _clientCopy.colDataTransferFtpPassword
            Form.uxFTPUser.Text = _clientCopy.colDataTransferFtpUserName
            Form.uxFileExtension.Text = _clientCopy.colDataTransferPgpFileExtension
            uxClear_Click(sender, e)
        End Sub

        Private Sub uxClear_Click(sender As Object, e As EventArgs)
            _clientCopy = Nothing
            Form.uxCopy.Enabled = True
            Form.uxPaste.Enabled = False
        End Sub

        Private Sub uxSave_Click(sender As Object, e As EventArgs)
            If Not IsNothing(Form.RadListControl1.SelectedItem) Then
                Dim zitem As rowTblClients = Form.RadListControl1.SelectedItem.DataBoundItem
                zitem.colDataTransferPassword = Form.uxAESPassword.Text
                zitem.colDatatransfer = Form.uxType.Text
                zitem.colDataTransferEncryptionKey = Form.uxAESEncryption.Text
                zitem.colDataTransferPgpEnabled = Form.uxPGPEnabled.Checked
                zitem.colDataTransferPgpPublicKey = Form.uxPGPkey.Text
                zitem.colDataTransferFtpUrl = Form.uxFTPUrl.Text
                zitem.colDataTransferFtpPassword = Form.uxFTPPassword.Text
                zitem.colDataTransferFtpUserName = Form.uxFTPUser.Text
                zitem.colDataTransferPgpFileExtension = Form.uxFileExtension.Text

                TblClients.Save(zitem)
                MsgBox("Save Succesful!!")
            End If
        End Sub

        Private Sub uxRun_Click(sender As Object, e As EventArgs)

            If Not IsNothing(Form.RadListControl1.SelectedItem) Then

                Dim zDT As New GRC.Connect.Libraries.DataTransferLib.UtilDataTransfer()
                Dim zitem As rowTblClients = Form.RadListControl1.SelectedItem.DataBoundItem

                If zitem.colDataTransferPgpEnabled Then
                    Dim zResult As MsgBoxResult = MsgBox("Delay Upload to FTP Site?", MsgBoxStyle.YesNo, "PGP Upload")
                End If

                zDT.GridIDs.Add(DataTransferLib.UtilDataTransfer.DataTransferGrids.IRRecommendationsAll)
                zDT.DoWork(zitem.colFileprefix)

            End If
        End Sub
    End Class

    Public ReadOnly Property ShowOnMainMenu As Boolean Implements IUtilityForm.ShowOnMainMenu
        Get
            Return True
        End Get
    End Property
End Class