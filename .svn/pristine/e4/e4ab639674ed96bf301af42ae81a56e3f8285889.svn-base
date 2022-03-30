

Public Class ReportFetch
    Inherits System.Web.UI.Page

    Public ServerSide_URL As String = ""
    Public ServerSide_GUID As String = ""
    Public ServerSide_ReportCode As String = ""
    Public ServerSide_P2 As String = ""
    Public ServerSide_P3 As String = ""
    Public LevelsDeep As Integer = 0

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LevelsDeep = Request.QueryString("levels")
        ServerSide_URL = "../FD/ServeReport.ashx?" & Request.QueryString.ToString 'sid=" & ServerSide_GUID '& "&rptCode=" & ServerSide_ReportCode & "&p2=" & ServerSide_P2 & "&p3=" & ServerSide_P3
    End Sub

End Class