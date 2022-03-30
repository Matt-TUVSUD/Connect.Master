Imports System.IO


Public Class ChartMasterPage
    Inherits System.Web.UI.MasterPage


#Region "Local Variables"
    'Private modChart As New modChart
    'Private modGlobalFunctions As New modGlobalFunctions
    Public ServerSide_CurrencyIdFromPrefilter As String = ""
#End Region



#Region "Header Information"
    Public Sub LoadDefaults()

    End Sub


    Private Sub LoadData()
        Dim zGSafeGUID As String = ""
        Dim zChartId As String = "0"
        Dim zFileNo As String = ""

        ' IF LOCATION CHART THEN GET THE LOCATION INFORMATION
        If Not Request.QueryString("batchSetId") Is Nothing Then
            ' DO NOTHING
        Else
            zGSafeGUID = UtilGSafe.GetGUIDFromQueryString()
            zChartId = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.currentChartId)
        End If

        'IF THERE IS NO PREFILTER CURRENCY SPECIFIED, THEN USE THE USER PREFERENCE
        If UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.ChartPreFilter_Currency) & "".Length > 0 Then
            ServerSide_CurrencyIdFromPrefilter = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.ChartPreFilter_Currency)
        Else
            ServerSide_CurrencyIdFromPrefilter = ""
        End If

    End Sub
#End Region



#Region "PageEvents"
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()

        'If (Not Page.ClientScript.IsStartupScriptRegistered("window_onload")) Then
        '    Page.ClientScript.RegisterStartupScript(Me.GetType(), "window_onload", "globalLoadChart();", True)
        'End If

        'Dim chartImagesPath As String = Request.PhysicalPath.ToString
        'chartImagesPath = chartImagesPath.Replace(Path.GetFileName(chartImagesPath).ToString, "ChartImages")
        'modGlobalFunctions.DeleteFilesByDate(chartImagesPath, "Png")

        Dim zDate = Now()
        'lblClient.Text = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.ClientName)
        'lblDate.Text = zDate.ToString("dd-MMM-yyyy")  'modChart.ChartDate
        'lblTitle.Text = "Auto-Recommendation Response & Follow-Up Status"

        If Not Page.IsPostBack Then
            LoadDefaults()
        End If
        LoadData()
    End Sub



#End Region

End Class