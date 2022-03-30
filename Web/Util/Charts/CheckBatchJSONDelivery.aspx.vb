Public Class CheckBatchJSONDelivery
    Inherits System.Web.UI.Page

    Public ServerSide_LargeObjectFilter As String = ""
    Public ServerSide_LargeObjectCriteria As String = ""
    Public ServerSide_LargeObjectSetting As String = ""
    Public ServerSide_ChartData As String = ""

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim zGSafeGUID As String = "588414be51294ea89bff52c960c9cda9"
        Dim zGSafeID As Integer = 3
        Dim zChartId As Integer = 1
        Dim zChart As New GRC.Connect.Libraries.CoreLib.UtilGDC
        Dim zChartData As New Dictionary(Of String, Object)

        ' GET THE LARGE OBJECT DATA
        Dim zFilter As String = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeID, UtilSafe.LargeObjectName.filterChart, zChartId)
        Dim zCriteria As String = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeID, UtilSafe.LargeObjectName.criteriaChart, zChartId)
        Dim zSetting As String = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeID, UtilSafe.LargeObjectName.settingChart, zChartId)

        ' GET THE CHART DATA
        zChart.PropChartId = CInt(UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.currentChartId))
        zChart.PropSafeGUID = zGSafeGUID
        zChart.PropFilter = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeID, UtilSafe.LargeObjectName.filterChart, zChart.PropChartId)
        zChart.PropCriteria = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeID, UtilSafe.LargeObjectName.criteriaChart, zChart.PropChartId)
        Dim zPropCountry As String = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.ChartPreFilter_Country)
        Dim zPropDivision As String = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.ChartPreFilter_Division)
        Dim zPropCustomAccess As String = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.ChartPreFilter_CustomAccess)
        Dim zPropTIV As String = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.ChartPreFilter_TIV)
        Dim zPropHazard As String = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.ChartPreFilter_Hazard)
        Dim zPropTIVValue As String = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.ChartPreFilter_TIVValue)
        zChart.PropParameters.FilePrefix = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.FilePreFix)
        zChart.PropParameters.Country = zPropCountry
        zChart.PropParameters.Division = zPropDivision
        zChart.PropParameters.CustomAccess = zPropCustomAccess
        zChart.PropParameters.TIV = zPropTIV
        zChart.PropParameters.Hazard = zPropHazard
        zChart.PropParameters.TIVValue = zPropTIVValue
        zChartData = zChart.GetChartData()

        ' BUILD THE JSON STRINGS
        Dim zSerializeSetting As New Newtonsoft.Json.JsonSerializerSettings
        zSerializeSetting.StringEscapeHandling = Newtonsoft.Json.StringEscapeHandling.EscapeHtml
        ServerSide_ChartData = Newtonsoft.Json.JsonConvert.SerializeObject(zChartData)
        ServerSide_ChartData = ServerSide_ChartData.Replace("""", "\""")
        ServerSide_LargeObjectFilter = zFilter.Replace("""", "\""")
        ServerSide_LargeObjectCriteria = zCriteria.Replace("""", "\""")
        ServerSide_LargeObjectSetting = zSetting.Replace("""", "\""")

    End Sub

End Class