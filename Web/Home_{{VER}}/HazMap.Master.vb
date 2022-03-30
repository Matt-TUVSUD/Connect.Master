Public Class HazMap
    Inherits System.Web.UI.MasterPage
    Public ServerSide_FilePrefix As String = ""
    Public zIsIE As Boolean = False
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()
        If zGUID <> "" Then
            ServerSide_FilePrefix = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.FilePreFix)
        End If
        If HttpContext.Current.Request.Browser.Type = "InternetExplorer11" Then zIsIE = True
    End Sub

End Class