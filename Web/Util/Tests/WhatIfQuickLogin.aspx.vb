Public Class WhatIfAutoLogin
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Debugger.IsAttached Then
            Response.Redirect("/Home_{{VER}}/Auth/Default.aspx")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim zUL2 As New UtilLogin2
        Dim zSafeGUID As String = "Not Authenticated"

        If Me.TextBox1.Text <> "" Then
            If zUL2.AuthenticateLogin(TextBox1.Text, TextBox2.Text) Then
                zSafeGUID = zUL2.SessionSetup(TextBox1.Text)
            Else
                If zUL2.IsLocked Then
                    zUL2.UnlockAccount(TextBox1.Text)

                    If zUL2.AuthenticateLogin(TextBox1.Text, TextBox2.Text) Then
                        zSafeGUID = zUL2.SessionSetup(TextBox1.Text)
                    End If
                End If
            End If

            If zSafeGUID <> "Not Authenticated" Then
                GRC.Connect.Libraries.CoreLib.UtilLogin2.SetClientValues(zSafeGUID, "4062")
                Response.Redirect("/Home_{{VER}}/WhatIf/WhatIfAnalysisTool.aspx?sid=" & zSafeGUID)
            Else
                Response.Write("<h3>Incorrect Credentials</h3>")
            End If

        End If
    End Sub
End Class