Imports System.ComponentModel
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class FireCopeSummaryRatingReport
    Inherits BaseReportLandscape
    Implements IUtilReport
    Implements ITelerikReport

    Private _FileNo As String = ""

    Public Sub New()
        MyBase.New()
        InitializeComponent()

        UtilReport.TelerikReport.FixBaseGroups(Me)

    End Sub

    Private Sub FireCopeSummary1_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        ApplySubIBatchSetReportProperties()
        ApplyCurrencyFormat()
        ApplySpecificValues()

    End Sub

    Private Sub BoilerFacilityDataSummary_ItemDataBound(sender As Object, e As System.EventArgs) Handles Me.ItemDataBound
        ApplyColor(sender)

        If UtilCustomFeature.Contains(rptProperties, CChar("&")) Then
            txtIBI.Visible = True
            txtIBILabel.Visible = True
        End If


    End Sub

    Private Sub ApplyCurrencyFormat()
        Dim zCurrencyControls() As TextBox = {txtTIV, txtTIVBI, txtTIVPD, txtMFL, txtMFLPD, txtMFLBI, txtPML, txtPMLBI, txtPMLPD, txtAPL, txtAPLBI, txtAPLPD}
        UtilReport.TelerikReport.SetCurrencyFormat(zCurrencyControls, rptProperties)
    End Sub

    Private Sub ApplySubIBatchSetReportProperties()
        Me.HeRecsSubReport.rptProperties = rptProperties
        Me.SprinklerRecsSubReport.rptProperties = rptProperties
        Me.WaterSupplyRecsSubReport.rptProperties = rptProperties
        Me.SurveillanceRecsSubReport.rptProperties = rptProperties
        Me.ManualProtRecsSubReport.rptProperties = rptProperties
        Me.SpecProtRecsSubReport.rptProperties = rptProperties
        Me.BCPRecsSubReport.rptProperties = rptProperties
        Me.ExposureRecsSubReport.rptProperties = rptProperties
    End Sub

    Private Sub ApplySpecificValues()
        Me.txtCurrency.Value = rptProperties.Currency.colFldName
        Me.txtUnit.Value = rptProperties.Unit.System.colFldName
    End Sub

    Private Sub ApplyColor(sender As Processing.Report)

        Dim zExposureItems() As TextBox = {txtExposureExternalFire, txtExposureExternalFireProtection, txtExposureFlood, txtExposureFloodProtection, txtExposureOtherPerils, txtExposureOtherPerilsProtection, txtExposureSeismic,
                           txtExposureWindstorm, txtExposureWindstormProtection, txtHEAlarms, txtHECombSafety, txtHEContractorSupervision, txtHEEmerResponse, txtHEEOTraining, txtHEEOType, txtHEExtinguishers, txtHEFireDoors, txtHEFirePumps,
            txtHEGeneralMaintenance, txtHEHotWorkMonitoring, txtHEHousekeeping, txtHEInfraredScans, txtHEMgmtChange, txtHESmokingControls, txtHESprinklerValves, txtSprinklerRating,
            txtWaterSupplyRating, txtSurveillanceRating, txtManualProtectionFireExt, txtManualProtectionFireHydt, txtManualProtectionHoseStations, txtSpecialHazardsRating, txtSpecProtSystemsRating, txtImpairmentHandling,
            txtHEFireDoors, txtExposureSeismicProtection}
        UtilReport.TelerikReport.SetItemBackColorByText(sender, zExposureItems, rptProperties)

        Dim zRating() As GrcTelerikRatingCategoryTexBox = {txtConstructionRating, txtOccupancyRating, txtOverallProtectionRating, txtExposureRating, txtHeRating, txtBcpRating}
        UtilReport.TelerikReport.SetItemBackColorByRating(sender, zRating, rptProperties)

    End Sub

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties

    Public Function IsStandardHeader() As Boolean Implements ITelerikReport.IsStandardHeader
        Return False
    End Function

    Public Function ReportSubSubTitle() As String Implements ITelerikReport.ReportSubSubTitle
        Return "Fire and Associated Perils <BR>{FileNo}"
    End Function

    Public Function ReportSubTitle() As String Implements ITelerikReport.ReportSubTitle
        Return "Location C.O.P.E. and Rating Summary"
    End Function

    Public Function ReportTitle() As String Implements ITelerikReport.ReportTitle
        Return "Loss Prevention"
    End Function

    Public Function AppendPracticeToTitle() As Boolean Implements ITelerikReport.AppendPracticeToTitle
        Return True
    End Function

    Private Sub Me_ItemDataBound(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        UtilReport.TelerikReport.SetFilterText(sender, rptProperties)
        UtilReport.TelerikReport.SetDisclaimerText(sender, rptProperties)
        UtilReport.TelerikReport.SetSortText(sender, rptProperties)

        If UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.U) Then
            uxAPLFactor.Visible = False
            uxAPLFactorLabel.Visible = False
        End If

        If UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.F) Then
            PMLpanel.Visible = False
        End If

        If UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.P) Then
            txtSpecialProtSystemsLabel.Value = "Process Safety Systems"
        End If



    End Sub

    Private Sub uxFireFacilityRatingInfoTable_NeedDataSource(sender As Object, e As EventArgs) Handles uxFireFacilityRatingInfoTable.NeedDataSource
        Dim zData As List(Of CoreLib.FireFacilityRatingItem) = UtilRating.GetFireFacilityRatingInfo(_FileNo).ToList()

        If Not UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.U) Then
            zData = zData.FindAll(Function(x) x.SortOrder > 1)  'DO NOT INCLUDE THE ACHIEVALBE RATING % IF NOT U CUSTOM FEATURE
        End If

        uxFireFacilityRatingInfoTable.DataSource = zData

    End Sub

    Private Sub detail_ItemDataBinding(sender As Object, e As EventArgs) Handles detail.ItemDataBinding
        _FileNo = DirectCast(DirectCast(sender, Telerik.Reporting.Processing.DetailSection).DataObject.RawData, DataRowView).Item("FileNo")
    End Sub
End Class