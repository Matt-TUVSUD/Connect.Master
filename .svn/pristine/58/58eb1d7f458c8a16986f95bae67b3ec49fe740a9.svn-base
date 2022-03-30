Imports GRC.Connect.Libraries.CoreLib.UtilConstants
Imports GRC.Connect.Libraries.CoreLib.UtilGSafe

Public Class notification
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim zGUID As String = GetGUIDFromQueryString()
        Dim zP2 As String = Request.QueryString("p2") & ""
        divMessage01.Visible = False
        divMessage02.Visible = False
        divMessage03.Visible = False
        Select Case zP2
            Case "1"
                divMessage01.Visible = True
            Case "2"
                divMessage02.Visible = True
            Case "3"
                divMessage03.Visible = True
            Case Else
                ' SAME AS MESSAGE ONE
                divMessage01.Visible = True
        End Select

    End Sub

End Class