
Public Class DefaultAuth
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' **************
        'If Diagnostics.Debugger.IsAttached Then
        '    Select Case My.User.Name.ToLower
        '        Case "us001\baras-da"
        '            Me.txtEmail.Text = "daniel.barasch@tuvsud.com"
        '            Me.txtPassword.Text = "password"
        '    End Select
        'End If
        '**************

        If Not Page.IsPostBack Then

            'HANDLE REQUEST BASED ON T
            Dim zT As String = Request.QueryString("t") & ""  'TYPE OF REQUEST

            If zT = "" Then

                Dim zP1 As String = Request.QueryString("p1") & ""

                If zP1.Length > 0 Then
                    Dim zErrLog As New UtilErrorLog
                    zErrLog.ReportErrorViaEmail(zP1)

                    'clear the querystring visual parameters
                    Response.Redirect("~/Home_{{VER}}/Auth/", False)
                End If

                Dim zP2 As String = ""
                If Not Request.QueryString("p2") Is Nothing Then
                    zP2 = Request.QueryString("p2") & ""
                End If

                'If zP2.Length > 0 Then
                '    Response.Redirect("~/Home_{{VER}}/Auth/", False)
                'End If

            Else

                Select Case zT.ToLower
                    Case "dt"  'DATA TRANSFER
                        Dim zP1 As String = Request.QueryString("p1") & ""  'FILEPREFIX
                        Dim zP2 As String = Request.QueryString("p2") & ""  'DATATRANSFER PASSWORD
                        Response.Redirect("../DataTransfer/default.ashx?p1=" & zP1 & "&p2=" & zP2)

                    Case Else  'FOR OTHER INVALID REQUESTS JUST RETURN TO LOGIN SCREEN
                        Response.Redirect("~/Home_{{VER}}/Auth/", False)

                End Select

            End If

        End If

        ' DISPLAY TEXT
        lblMessageMaintenance.Text = ""
        lblMessageMaintenance.Text = UtilSystemParms.LoginDisplayText

        If Request.QueryString("GRClogin") <> "" Then
            txtEmail.Text = Request.QueryString("GRClogin")
        End If

        txtEmail.Focus()

    End Sub

    Private Sub btnAuthenticate_Click(sender As Object, e As System.EventArgs) Handles btnAuthenticate.Click
        'Validate user / password combination with ezy_Users table, then proceed to Switch
        Dim zUserEmail As String = txtEmail.Text
        Dim zUserPassword As String = txtPassword.Text
        Dim zSafeGUID As String = ""
        Dim zOKToLogIn As Boolean = True

        ' CHECK IF WE ARE IN MAINTENANCE MODE AND IF IN ALLOWED EMAIL LIST
        If UtilSystemParms.InMaintenanceMode Then
            zOKToLogIn = False
            Dim zUL2 As New UtilLogin2
            If zUL2.AllowMaintenanceLogin(zUserEmail) Then
                zOKToLogIn = True
            End If
        End If

        If zOKToLogIn Then
            Dim zUL2 As New UtilLogin2
            Dim zEU As New BusinessObjects.EzyUsers
            If zUL2.AuthenticateLogin(zUserEmail, zUserPassword) Then
                zSafeGUID = InitUserSession(zUserEmail, zUserPassword)

                If zSafeGUID.Length > 0 Then
                    UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.LoggedInUserEmail, zUserEmail, UtilGSafe.KeyNameGroup.Session)
                    Dim zEntry As razor.rowTblSystemAppEntry = UtilAppEntry.Save(zSafeGUID, UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.userFullName), zUserEmail, UtilAppEntry.EntrySource.Main, UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.EzyLoginId))

                    ' SET THE USER COOKIE
                    Dim zIsUserCookieSaved As Boolean = UtilCookieUser.SetCookieUser(Me, zSafeGUID, zUserEmail, zEntry.colFldID)

                    Dim zP2 As String = ""
                    If Not Request.QueryString("p2") Is Nothing Then
                        zP2 = Request.QueryString("p2") & ""
                    End If

                    Select Case zP2.ToUpper
                        Case "myBatchReports".ToUpper
                            ''Consume the ReferenceKey and redirect to the myBatchReports page
                            '                            Response.Redirect("~/Home_{{VER}}/Reports/myBatchReports.aspx?sid=" & zSafeGUID & "&" & Request.QueryString.ToString, False)
                            Response.Redirect("~/Home_{{VER}}/Reports/myBatchReportsSelector.aspx?sid=" & zSafeGUID & "&" & Request.QueryString.ToString, False)

                        Case "reclass".ToUpper  'User Reclassification
                            Dim zP3 As String = Request.QueryString("p3") & ""  'GUID
                            Response.Redirect("../UserReclassification/default.aspx?sid=" & zSafeGUID & "&p1=" & zP3)  'SET GSAFE DETIALS GUID

                        Case Else

                            If GRC.Connect.Libraries.CoreLib.UtilLogin2.IsGRCAdministrator(zUserEmail) Then
                                Response.Redirect("~/Home_{{VER}}/Switch/SwitchIntegrated.aspx?sid=" & zSafeGUID, False)
                            Else
                                Response.Redirect("~/Home_{{VER}}/Switch/?sid=" & zSafeGUID, False)
                            End If
                    End Select
                    'End If
                Else
                    'Call LoginFailed(zUserEmail)
                    lblMessage.Text = "The user and password combination was not found.  Please ensure your email is correct and you are using the very latest password."
                End If
            Else
                'Call LoginFailed(zUserEmail)
                lblMessage.Text = "The user and password combination was not found.  Please ensure your email is correct and you are using the very latest password."

                If zUL2.IsLocked And zUL2.IsLockedDueToBadAttempts Then
                    UtilSession.IsRedirectedFromAuthPage = True
                    UtilSession.PasswordErrorMessage = "After three failed attempts, you have locked out your account!"
                    UtilSession.ResetPasswordEmailAddress = zUserEmail
                    UtilSession.IsLockedDueToBadAttempts = True
                    Response.Redirect("~/Home_{{VER}}/Preference/PasswordErrorPage.aspx")
                ElseIf zUL2.IsLocked Then
                    lblMessage.Text = "Account is locked out."
                End If

                If zUL2.IsPasswordExpired Then
                    Response.Redirect("~/Home/Reset/?p1=" & zUL2.LoginGUID)
                End If
            End If
        Else
            lblMessage.Text = UtilSystemParms.InMaintenanceModeLoginDeniedText
        End If
    End Sub

    Private Sub LoginFailed(pUserEmail As String)
        'Dim util As New UtilLogin2
        'lblMessage.Text = "The user and password combination was not found."
        'Dim zEzyUser As New BusinessObjects.EzyUsers
        ''If zEzyUser.LoadByEmail(pUserEmail) Then
        ''REPLACE THIS ^ ^ ^ ^ ^ ^ ^ 
        ''WITH THIS V V V V V V V V V
        'If util.LoadByEmail(pUserEmail) Then
        '    'If zEzyUser.EnforceUserSecurity Then
        '    'REPLACE THIS ^ ^ ^ ^ ^ ^ ^ 
        '    'WITH THIS V V V V V V V V V
        '    If True Then
        '        hidLoginStrike.Value = hidLoginStrike.Value + 1
        '        If hidLoginStrike.Value >= 3 Then
        '            Dim zAMLock As New BusinessObjects.EzyUsers.AccountManagement(zEzyUser)
        '            lblMessage.Text = "You have had three unsuccessful attempts logging into GRC Connect.  For security purposes, your access has been locked.  Please contact your Corporate Risk Management to have your access reinstated."
        '            'zAMLock.SendFailedLoginAttemptEmail(Me.txtPassword.Text, Request.ServerVariables("Remote_addr"))
        '            zAMLock.LockAccount()
        '        End If
        '    Else
        '        hidLoginStrike.Value = 0
        '    End If
        'Else
        '    hidLoginStrike.Value = 0
        'End If

    End Sub

    Private Function InitUserSession(pUserEmail As String, pUserPassword As String) As String
        Dim zSafeGUID As String = ""
        Dim util As New UtilLogin2
        zSafeGUID = util.SessionSetup(pUserEmail)
        UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.SafeGUID, zSafeGUID, UtilGSafe.KeyNameGroup.Session)

        Return zSafeGUID
    End Function

    Private Sub lnkPasswordReset_Click(sender As Object, e As EventArgs) Handles lnkPasswordReset.Click

        If String.IsNullOrEmpty(Me.txtEmail.Text) Then
            UtilSession.IsRedirectedFromAuthPage = True
            Response.Redirect("~/Home_{{VER}}/Preference/PasswordResetRequest.aspx")
        Else
            UtilSession.ResetPasswordEmailAddress = Me.txtEmail.Text

            Dim zLogin As New UtilLogin2
            If zLogin.EmailExists(Me.txtEmail.Text) Then
                Response.Redirect("~/Home_{{VER}}/Preference/PasswordErrorPage.aspx")
            Else
                lblMessage.Text = "Sorry we do not recognize your email. <BR/> Please contact your Risk Management to request access to the TUV SUD GRC Connect system."
            End If
        End If

    End Sub
End Class