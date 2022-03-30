Imports System.ComponentModel
Imports System.Drawing
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class BMFacilityDataSummaryRatingReport
    Inherits BaseReportLandscape
    Implements IUtilReport
    Implements ITelerikReport

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        UtilReport.TelerikReport.FixBaseGroups(Me)
    End Sub

    Private Sub BoilerFacilityDataSummaryRating_ItemDataBinding(sender As Object, e As System.EventArgs) Handles Me.ItemDataBinding
        Dim zRpt As Processing.Report = DirectCast(sender, Processing.Report)
        Dim zDetailSections() As Telerik.Reporting.Processing.LayoutElement = Processing.ElementTreeHelper.FindChildByName(zRpt, "detail", True)
        Dim zFileNo As String
        For Each zDetail As Processing.DetailSection In zDetailSections
            zFileNo = zDetail.DataObject("FileNo")
        Next


        Me.BCPRecsSubReport.rptProperties = rptProperties
        Me.BoilerFacilityDataSummary_LargestPrimaryTransformers1.rptProperties = rptProperties
        Me.BPVRecsSubReport.rptProperties = rptProperties
        Me.ComputerSystemRecsSubReport.rptProperties = rptProperties
        Me.CriticalSparesRecsSubReport.rptProperties = rptProperties
        Me.CriticalSparesItemsSubReport.rptProperties = rptProperties
        Me.ElectricalRecsSubReport.rptProperties = rptProperties
        Me.EPPMRecsSubReport.rptProperties = rptProperties
        Me.BPVitemsSubReport.rptProperties = rptProperties
        Me.HERecsSubReport.rptProperties = rptProperties
        Me.MechanicalRecsSubReport.rptProperties = rptProperties
        Me.MPPMRecsSubReport.rptProperties = rptProperties

        Me.PPEItemsSubReport.rptProperties = rptProperties
        Me.PPERecsSubReport.rptProperties = rptProperties
        Me.MechanicalRecsSubReport.rptProperties = rptProperties
        Me.MPPMRecsSubReport.rptProperties = rptProperties

        Me.txtCurrency.Value = rptProperties.Currency.colFldName

        If UtilCustomFeature.Contains(rptProperties, CChar("&")) Then
            txtIBI.Visible = True
            txtIBILabel.Visible = True
        End If

    End Sub

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties

    Public Function IsStandardHeader() As Boolean Implements ITelerikReport.IsStandardHeader
        Return False
    End Function

    Public Function ReportSubSubTitle() As String Implements ITelerikReport.ReportSubSubTitle
        Return "{FileNo}"
    End Function

    Public Function ReportSubTitle() As String Implements ITelerikReport.ReportSubTitle
        Return "Location Facility Data Summary"
    End Function

    Public Function ReportTitle() As String Implements ITelerikReport.ReportTitle
        Return "Loss Prevention"
    End Function

    Private Sub BoilerFacilityDataSummaryRating_ItemDataBound(sender As Object, e As EventArgs) Handles Me.ItemDataBound
        Dim zLossEstimates() As TextBox = {Me.txtTIV, Me.txtTIVPD, Me.txtTIVBI, Me.txtTIV1, Me.txtTIVPD1, Me.txtTIVBI1, Me.txtPML, Me.txtPMLBI, Me.txtPMLPD, Me.txtMFL, Me.txtMFLPD, Me.txtMFLBI}
        UtilReport.TelerikReport.SetCurrencyFormat(zLossEstimates, rptProperties)

        Dim zExposureControls() As TextBox = {txtCompAirExposure, txtRefrigerationExposure, txtWaterExposure, txtCoolingExposure, txtFuelExposure, txtPPEExposure, txtBoilerExposure, txtElectricalExposure, txtComputerExposure, txtCriticalPressureVesselExposure}
        UtilReport.TelerikReport.SetItemBackColorByExposure(sender, zExposureControls, rptProperties)

        Dim zRatingControls() As GrcTelerikRatingCategoryTexBox = {txtOccupRating,
        txtMechEquipRating, txtPPERating, txtMPPMRating, txtEPPMRating, txtBPVRating, txtCriticalSparesRating, txtCompSysRating, txtBCPRating, txtHeRating,
        txtElecEquipRating}
        UtilReport.TelerikReport.SetItemBackColorByRating(sender, zRatingControls, rptProperties)

        Dim zTextControls() As TextBox = {txtPlanInPlace, txtOverallHeAdequate, txtEPPMOverallProgram, txtMPPMOverallProgram, txtCriticalSparesMaintained}
        UtilReport.TelerikReport.SetItemBackColorByText(sender, zTextControls, rptProperties)

        Dim zRiskRatingControls() As TextBox = {txtCurrentOverallRating, txtCurrentRating, txtLastRating, txtDivisionAverageRating, txtClientAverageRating}
        UtilReport.TelerikReport.SetItemBackColorByRiskRating(sender, zRiskRatingControls, rptProperties)

    End Sub

    Public Function AppendPracticeToTitle() As Boolean Implements ITelerikReport.AppendPracticeToTitle
        Return True
    End Function

    Private Sub Me_ItemDataBound(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        UtilReport.TelerikReport.SetFilterText(sender, rptProperties)
        UtilReport.TelerikReport.SetDisclaimerText(sender, rptProperties)
        UtilReport.TelerikReport.SetSortText(sender, rptProperties)
    End Sub

End Class