
Imports GRC.Connect.Libraries.CoreLib.BusinessObjects
Imports GRC.Connect.Libraries.CoreLib.UtilGSafe
Imports GRC.Connect.Libraries.CoreLib.UtilWebBrowser

Public Class ChartTest01
    Inherits System.Web.UI.Page

#Region "Local Variables"
    Public ServerSide_ChartId As String = ""

#End Region


#Region "Init"
    Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Init

    End Sub
#End Region


#Region "Data Loading"
    Private Sub loadDefaults()
        Dim zGSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Dim zChartId As String = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.currentChartId)
        ServerSide_ChartId = zChartId

    End Sub


    Private Sub loadData()

    End Sub


    Private Sub loadLists()

    End Sub
#End Region

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Call loadLists()
            Call loadDefaults()
        End If
        Call loadData()
    End Sub


    Protected Sub Page_LoadComplete(ByVal sender As Object, ByVal e As EventArgs) Handles Me.LoadComplete

    End Sub

End Class