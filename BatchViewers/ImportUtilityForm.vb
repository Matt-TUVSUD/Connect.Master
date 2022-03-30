Imports GRC.Connect.Libraries.ImportLib

Public Class ImportUtilityForm
    Implements IUtilityForm

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles AuthenticateButton.Click
        Dim zUL2 As New UtilLogin2
        Dim zSafeGUID As String = "Not Authenticated"

        If Me.PasswordTextBox.Text <> "" Then
            If zUL2.AuthenticateLogin(UserNameTextBox.Text, PasswordTextBox.Text) Then
                zSafeGUID = zUL2.SessionSetup(UserNameTextBox.Text)
            Else
                If zUL2.IsLocked Then
                    zUL2.UnlockAccount(UserNameTextBox.Text)

                    If zUL2.AuthenticateLogin(UserNameTextBox.Text, PasswordTextBox.Text) Then
                        zSafeGUID = zUL2.SessionSetup(UserNameTextBox.Text)
                    End If
                End If
            End If

            SIDLabel.Text = zSafeGUID
        End If


    End Sub

    Private Sub ImportUtilityForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AuthenticateButton.PerformClick()
        FileNoTextBox.Text = "4083.0040"
        SetLocationButton.PerformClick()
        FilePathTextBox.Text = "C:\Users\Baras-Da\Desktop\Magna\f40620000_YYMMDDFDS.xlsm" ' "\\EXNJCU01002.EXUS01.NET\AppData\ClientData\cldbAES\Contract Period 17-Jan-01 to 17-Dec-31\Fire\FDS\F21740006_170315FDS.xlsm"
        SetPractice()
        ' ImportButton.PerformClick()

        SetCheckBoxes()

    End Sub

    Private Sub FileSelectorButton_Click(sender As Object, e As EventArgs) Handles FileSelectorButton.Click
        OpenFileDialog1.ShowDialog()
        FilePathTextBox.Text = OpenFileDialog1.FileNames(0)
        OpenFileDialog1.Dispose()

        SetPractice()

        SetCheckBoxes()

    End Sub

    Public ReadOnly Property ShowOnMainMenu As Boolean Implements IUtilityForm.ShowOnMainMenu
        Get
            Return True
        End Get
    End Property

    Private Sub SetCheckBoxes()
        Dim p As String = ""
        If FilePathTextBox.Text.ToLower.Contains("fds.") Then p = "Fire"
        If FilePathTextBox.Text.ToLower.Contains("bds.") Then p = "B&&M"

        Dim CheckBoxes As List(Of Windows.Forms.CheckBox) = Me.Controls.OfType(Of Windows.Forms.CheckBox).ToList
        For Each zC As Windows.Forms.CheckBox In CheckBoxes
            zC.Enabled = zC.Text.StartsWith(p)
        Next
    End Sub

    Private Function GetCheckImportSheets() As Integer()

        Dim zList As New List(Of Integer)
        Dim CheckBoxes As List(Of Windows.Forms.CheckBox) = Me.Controls.OfType(Of Windows.Forms.CheckBox).ToList
        For Each zC As Windows.Forms.CheckBox In CheckBoxes
            If zC.Checked Then
                zList.Add(zC.Tag)
            End If
        Next

        Return zList.ToArray()
    End Function


    Private Sub SetLocationButton_Click(sender As Object, e As EventArgs) Handles SetLocationButton.Click

        Dim zFilePrefix As String = Int(FileNoTextBox.Text).ToString()
        Dim zClients As GRC.Connect.Libraries.DataLib.razor.rowTblClients = GRC.Connect.Libraries.DataLib.razor.TblClients.LoadByPrimaryKey(zFilePrefix)

        GRC.Connect.Libraries.CoreLib.UtilLogin2.SetClientValues(SIDLabel.Text, zClients.colFilePrefix)
        GRC.Connect.Libraries.CoreLib.UtilGSafe.SetLocationNavigationInformation(SIDLabel.Text, FileNoTextBox.Text)

        ClientNameTextBox.Text = zClients.colClientname

        SetPractice()
        FileNoLabel.Text = FileNoTextBox.Text

    End Sub

    Private Sub ImportButton_Click(sender As Object, e As EventArgs) Handles ImportButton.Click

        MessageTextbox.Text = "Running..."

        Dim zResult As ImportFileResultList
        Dim zSheets As New List(Of ImportEnum.ImportSheet)

        Dim zFileName As String = IO.Path.GetFileNameWithoutExtension(FilePathTextBox.Text)
        GetCheckImportSheets.ToList.ForEach(Sub(x) zSheets.Add(x))

        'If zFileName.ToLower.EndsWith("fds") Then
        '    ' zSheets.Add(ImportEnum.ImportSheet.CopeData)
        '    'zSheets.Add(ImportEnum.ImportSheet.RatingForm)
        '    zSheets.Add(ImportEnum.ImportSheet.RecTracking)
        '    '    zSheets.Add(ImportEnum.ImportSheet.RetailData)
        'End If

        'If zFileName.ToLower.EndsWith("bds") Then
        '    zSheets.Add(ImportEnum.ImportSheet.FacilityData)
        '    zSheets.Add(ImportEnum.ImportSheet.RatingForm)
        '    zSheets.Add(ImportEnum.ImportSheet.RecTracking)
        '    '  zSheets.Add(ImportEnum.ImportSheet.RetailData)
        'End If

        Try
            zResult = ImportLib.Public.ImportTemplate(SIDLabel.Text, {FilePathTextBox.Text}.ToList, zSheets)

            MessageTextbox.Text = ""
            For Each zR As ImportLib.ImportFileResult In zResult
                MessageTextbox.Text = MessageTextbox.Text & vbNewLine & zR.Text
            Next

        Catch ex As Exception
            MessageTextbox.Text = GRC.Resources.ExceptionUtility.ExtractMessages(ex)
        End Try

        MessageTextbox.Text = Replace(MessageTextbox.Text, "\n\r", "")

    End Sub


    Private Sub SetPractice()
        Dim zFileName As String = IO.Path.GetFileNameWithoutExtension(FilePathTextBox.Text)
        If zFileName.ToLower.EndsWith("fds") Then UtilGSafe.SetValue(SIDLabel.Text, UtilGSafe.KeyName.practiceName, "fire", UtilGSafe.KeyNameGroup.Navigation)
        If zFileName.ToLower.EndsWith("bds") Then UtilGSafe.SetValue(SIDLabel.Text, UtilGSafe.KeyName.practiceName, "boiler", UtilGSafe.KeyNameGroup.Navigation)
        If zFileName.ToLower.EndsWith("psds") Then UtilGSafe.SetValue(SIDLabel.Text, UtilGSafe.KeyName.practiceName, "process", UtilGSafe.KeyNameGroup.Navigation)
    End Sub

    Private Sub OpenFileButton_Click(sender As Object, e As EventArgs) Handles OpenFileButton.Click
        Process.Start(FilePathTextBox.Text)
    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged

    End Sub
End Class