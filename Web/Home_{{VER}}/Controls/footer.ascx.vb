Public Class footer
    Inherits System.Web.UI.UserControl
    Public ServerSide_AdminTab As String = ""
    Dim currentYear As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'SHOW OR HIDE BOTTOM BANNER BASED ON ADMIN USER
        'Dim zLoginId As Integer = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(UtilGSafe.GetGUIDFromQueryString(), UtilGSafe.KeyName.EzyLoginId)
        'Dim zAdminType = GRC.Connect.Libraries.CoreLib.UtilLogin2.GetGRCAdministrator(zLoginId)
        currentYear = System.DateTime.Now.Year
        curYear.Text = currentYear.ToString()
        'If zAdminType <> "00" Then
        '    adminLnk.Visible = False
        '    ServerSide_AdminTab = ""
        'Else
        '    adminLnk.Visible = True
        '    ServerSide_AdminTab = "Admin"
        'End If
    End Sub

End Class