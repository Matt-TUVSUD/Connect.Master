
Public Class PasswordResetRequest
    Inherits System.Web.UI.Page

    Private Sub LoadDefaults()
        ' HIDE AND SHOW DIVS BY DEFAULT
        divEnterEmailAddress.Visible = True
        divEmailSent.Visible = False

        ' SET THE MESSAGE
        lblMessage.Text = ""
        'Verifies the email/GUID combination exists


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

    Protected Sub btnEnterEmail_Click(sender As Object, e As EventArgs) Handles btnEnterEmail.Click

        'The querystring parameter will not be empty when user clicks link in email
        If Not Request.QueryString("p1") Is Nothing Then

            Dim zLoginGUID As String = Request.QueryString("p1").ToString & ""
            Dim zEmailAddress As String = txtEmail.Text
            Dim zLogin As New GRC.Connect.Libraries.CoreLib.UtilLogin2

            If zLogin.EmailExists(zEmailAddress, zLoginGUID) Then
                SendNotification(zLogin.GetLoginId(zLoginGUID))
            Else
                ShowError()
            End If

        Else
            If UtilSession.IsRedirectedFromAuthPage Then
                Dim zEmailAddress As String = txtEmail.Text
                Dim zLogin As New GRC.Connect.Libraries.CoreLib.UtilLogin2
                If zLogin.EmailExists(zEmailAddress) Then
                    SendNotification(zLogin.GetLoginIdByEmail(zEmailAddress))
                Else
                    ShowError()
                End If
            Else
                ShowError()
            End If

        End If
    End Sub

    Private Sub ShowError()
        divEnterEmailAddress.Visible = False
        lblMessage.Text = "Sorry we do not recognize your email. <BR/> Please contact your Risk Management to request access to the TUV SUD GRC Connect system."
    End Sub

    Private Sub SendNotification(pLoginId As Integer)
        divEnterEmailAddress.Visible = False
        divEmailSent.Visible = True
        UtilNotification.SubmitUserResetPasswordNotification(pLoginId)
        UtilSession.Clear()
    End Sub

End Class