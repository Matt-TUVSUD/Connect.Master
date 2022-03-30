Imports GRC.Connect.Libraries.DataLib.razor

Public Class ChartFetch
    Inherits System.Web.UI.Page

    Public ServerSide_ChartUrlBase As String = ""

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Dim zGSafeId As Integer = UtilGSafe.GetId(zSafeGUID)
        Dim zURL As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.ChartPreFilter_BaseUrl)
        ServerSide_ChartUrlBase = zURL
    End Sub

End Class