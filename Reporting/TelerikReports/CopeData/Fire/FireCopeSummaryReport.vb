Imports System.ComponentModel
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class FireCopeSummaryReport
    Inherits BaseReportPortrait
    Implements IUtilReport
    Implements ITelerikReport

    Public Sub New()
        MyBase.New()
        InitializeComponent()

        UtilReport.TelerikReport.FixBaseGroups(Me)

    End Sub

    Private Sub FireCopeSummary1_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        ApplySubIBatchSetReportProperties()
        ApplyCurrencyFormat()
        ApplySpecificValues()
        UtilReport.TelerikReport.SetFilterText(sender, rptProperties)
        UtilReport.TelerikReport.SetDisclaimerText(sender, rptProperties)
        UtilReport.TelerikReport.SetSortText(sender, rptProperties)

        If UtilCustomFeature.Contains(rptProperties, CChar("&")) Then
            txtIBI.Visible = True
            txtIBILabel.Visible = True
        End If


    End Sub

    Private Sub Me_ItemDataBound(sender As Object, e As System.EventArgs) Handles Me.ItemDataBound
        ApplyColor(sender)
    End Sub

    Private Sub ApplyCurrencyFormat()
        Dim zCurrencyControls() As TextBox = {txtTIV1, txtTIVBI1, txtTIVPD1, txtMFL, txtMFLPD, txtMFLBI, txtPML, txtPMLBI, txtPMLPD, txtAPL, txtAPLBI, txtAPLPD}
        UtilReport.TelerikReport.SetCurrencyFormat(zCurrencyControls, rptProperties)
    End Sub

    Private Sub ApplySubIBatchSetReportProperties()
        Me.HumanElementRecommendations.rptProperties = rptProperties
        Me.SprinklerRecommendations.rptProperties = rptProperties
        Me.WaterSupplyRecommendations.rptProperties = rptProperties
        Me.SurveillanceRecommendations.rptProperties = rptProperties
        Me.ManualProtectionRecommendations.rptProperties = rptProperties
        Me.SpecialHazardsRecommendations.rptProperties = rptProperties
        Me.HumanElementRecommendations.rptProperties = rptProperties
        Me.BCPRecommendations.rptProperties = rptProperties
        Me.ExposureRecommendations.rptProperties = rptProperties
    End Sub

    Private Sub ApplySpecificValues()
        Me.txtCurrency.Value = rptProperties.Currency.colFldName
        Me.txtUnit.Value = rptProperties.Unit.System.colFldName
    End Sub

    Private Sub ApplyColor(sender As Processing.Report)

        Dim zExposureItems() As TextBox = {txtExposureExternalFire, txtExposureExternalFireProtection, txtExposureFlood, txtExposureFloodProtection, txtExposureOtherPerils, txtExposureOtherPerilsProtection, txtExposureSeismic,
                           txtExposureWindstorm, txtExposureWindstormProtection}
        UtilReport.TelerikReport.SetItemBackColorByText(sender, zExposureItems, rptProperties)

        Dim zTextItems() As TextBox = {txtHEAlarms, txtHECombSafety, txtHEContractorSupervision, txtHEEmerResponse, txtHEEOTraining, txtHEEOType, txtHEExtinguishers, txtHEFireDoors, txtHEFirePumps,
            txtHEGeneralMaintenance, txtHEHotWorkMonitoring, txtHEHousekeeping, txtHEInfraredScans, txtHEMgmtChange, txtHESmokingControls, txtHESprinklerValves, txtSprinklerRating,
            txtWaterSupplyRating, txtSurveillanceRating, txtManualProtectionFireExt, txtManualProtectionFireHydt, txtManualProtectionHoseStations, txtSpecialHazardsRating, txtSpecProtSystemsRating, txtImpairmentHandling,
            txtHEFireDoors, txtExposureSeismicProtection}
        UtilReport.TelerikReport.SetItemBackColorByText(sender, zTextItems, rptProperties)

    End Sub

#Region "Special Feature Customizations"

    Private Sub ApplySpecialFeature(sender As Object, e As System.EventArgs) Handles txtSpecialProtSystemsLabel.ItemDataBound
        Dim zTextBox As Telerik.Reporting.Processing.TextBox = DirectCast(sender, Telerik.Reporting.Processing.TextBox)
        If UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.P) Then
            zTextBox.Value = "Process Safety Systems"
        End If
    End Sub

    Private Sub HidePML(sender As Object, e As System.EventArgs) Handles PMLpanel.ItemDataBound
        Dim wPanel As Telerik.Reporting.Processing.Panel = DirectCast(sender, Telerik.Reporting.Processing.Panel)

        If UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.F) Then
            wPanel.Visible = False
        End If

    End Sub

#End Region

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties

    Public Function IsStandardHeader() As Boolean Implements ITelerikReport.IsStandardHeader
        Return False
    End Function

    Public Function ReportSubSubTitle() As String Implements ITelerikReport.ReportSubSubTitle
        Return "Fire and Associated Perils <BR>{FileNo}"
    End Function

    Public Function ReportSubTitle() As String Implements ITelerikReport.ReportSubTitle
        Return "Location C.O.P.E. Summary"
    End Function

    Public Function ReportTitle() As String Implements ITelerikReport.ReportTitle
        Return "Loss Prevention"
    End Function

    Public Function AppendPracticeToTitle() As Boolean Implements ITelerikReport.AppendPracticeToTitle
        Return True
    End Function
End Class