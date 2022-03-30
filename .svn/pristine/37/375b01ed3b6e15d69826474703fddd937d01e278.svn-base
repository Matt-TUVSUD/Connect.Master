
Public Class PasswordResetForm
    Inherits System.Web.UI.Page

    Private Sub LoadDefaults()
        ' SET THE MESSAGE
        lblMessage.Text = ""

        Dim zLogin As New UtilLogin2
        Dim zEzyLogin As razor.rowTblEzyLogin = zLogin.GetLoginByGuid(Request.QueryString("p1"))
        Dim zYellowColor As System.Drawing.Color = System.Drawing.Color.FromArgb(255, 255, 166)

        txtDisplayName.Text = zEzyLogin.colFullName
        txtDisplayName.Enabled = True
        txtDisplayName.BackColor = zYellowColor

        txtEmail.Text = zEzyLogin.colEmailAddress
        txtEmail.Enabled = False

        txtPasswordNew.BackColor = zYellowColor
        txtPasswordNew.Enabled = True

        txtPasswordConfirm.BackColor = zYellowColor
        txtPasswordConfirm.Enabled = True

    End Sub

    Private Sub LoadLists()

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

    Protected Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click

        Dim zUtilLogin2 As New UtilLogin2
        Dim zEzyLogin As razor.rowTblEzyLogin = zUtilLogin2.GetLoginByGuid(Request.QueryString("p1"))
        Dim zOkToChangePassword As Boolean = True

        If Me.txtPasswordNew.Text.Equals(Me.txtPasswordConfirm.Text) Then

            If zUtilLogin2.IsPasswordUsed(zEzyLogin, Me.txtPasswordNew.Text) Then
                lblMessage.Text = "Sorry, this password can not be used as it was same as one of your past five passwords!"
                zOkToChangePassword = False
            End If

            If Not zUtilLogin2.IsPasswordValid(Me.txtPasswordNew.Text) Then
                lblMessage.Text = "Sorry, you have not met the password requirements!"
                zOkToChangePassword = False
            End If

            If zOkToChangePassword Then
                zUtilLogin2.ReplacePassword(zEzyLogin.colEmailAddress, txtPasswordNew.Text)
                zEzyLogin.colFullName = txtDisplayName.Text
                zEzyLogin.colFailedLoginStrikeStartDate = Nothing
                zEzyLogin.colFailedLoginStrikeCount = 0
                razor.TblEzyLogin.Save(zEzyLogin)

                UtilSession.Clear()
                Response.Redirect("~/Home_{{VER}}/Auth/?GRClogin=" + zEzyLogin.colEmailAddress)
            End If

        Else
            lblMessage.Text = "Sorry, your New and Confirm New passwords do not match!"
        End If

    End Sub

    Protected Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'go back to auth page
    End Sub

End Class