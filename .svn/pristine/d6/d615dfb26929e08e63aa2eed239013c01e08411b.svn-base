Public Class DefaultAuth_Home
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim zQueryString As String = Request.QueryString.ToString
        Dim zRedirectURL As String = "~/Home_{{VER}}/Auth/?pBuffer=0"

        If zQueryString.Length > 0 Then
            zRedirectURL = zRedirectURL & "&" & zQueryString
        End If

        ' REDIRECT TO THE CORRECT HOME PAGE IN THE Home_{{VER}} FOLDER
        Response.Redirect(zRedirectURL, False)

        '' GET THE RRLOG GUID
        'Dim zP1 As String = ""
        'If Not Request.QueryString("p1") = Nothing Then
        '    zP1 = "&p1=" & Request.QueryString("p1")
        'End If
        '' GET THE BATCH REPORTS FLAG
        'Dim zP2 As String = ""
        'If Not Request.QueryString("p2") = Nothing Then
        '    zP2 = "&p2=" & Request.QueryString("p2")
        'End If
        '' GET THE TYPE OF REQUEST
        'Dim zT As String = ""
        'If Not Request.QueryString("t") = Nothing Then
        '    zT = "&t=" & Request.QueryString("t")
        'End If
        '' GET THE ??? PARAMETER
        'Dim zI As String = ""
        'If Not Request.QueryString("i") = Nothing Then
        '    zI = "&i=" & Request.QueryString("i")
        'End If

        ' REDIRECT TO THE CORRECT HOME PAGE IN THE Home_{{VER}} FOLDER
        'Response.Redirect("~/Home_{{VER}}/Auth/?pBuffer=0" & zP1 & zP2 & zT & zI, False)

    End Sub

End Class