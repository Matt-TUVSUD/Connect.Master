Imports System.ComponentModel
Imports System.Drawing
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class BMFacilityDataSummaryReport
    Inherits BaseReportPortrait
    Implements ITelerikReport
    Implements IUtilReport

    Public Sub New()
        MyBase.New()
        InitializeComponent()

        AdjustSubReportWidth()
        UtilReport.TelerikReport.FixBaseGroups(Me)

    End Sub

    Public Sub AdjustSubReportWidth()

        'This sub adjusts the width of the following controls due 
        PPEItemsSubReport.Width = New Telerik.Reporting.Drawing.Unit(7.95, UnitType.Inch)
        PPEItemsSubReport.txtDescriptionField.Width = New Telerik.Reporting.Drawing.Unit(7.15, UnitType.Inch)
        PPEItemsSubReport.txtDescriptionLabel.Width = New Telerik.Reporting.Drawing.Unit(7.15, UnitType.Inch)

        CPVItemsSubReport.Width = New Telerik.Reporting.Drawing.Unit(7.95, UnitType.Inch)
        CPVItemsSubReport.txtDescriptionField.Width = New Telerik.Reporting.Drawing.Unit(7.15, UnitType.Inch)
        CPVItemsSubReport.txtDescriptionLabel.Width = New Telerik.Reporting.Drawing.Unit(7.15, UnitType.Inch)

        CriticalSpareItemsSubReport.Width = New Telerik.Reporting.Drawing.Unit(7.95, UnitType.Inch)
        CriticalSpareItemsSubReport.txtDescriptionField.Width = New Telerik.Reporting.Drawing.Unit(7.15, UnitType.Inch)
        CriticalSpareItemsSubReport.txtDescriptionLabel.Width = New Telerik.Reporting.Drawing.Unit(7.15, UnitType.Inch)


    End Sub

    Private Sub BoilerFacilityDataSummary_ItemDataBinding(sender As Object, e As System.EventArgs) Handles Me.ItemDataBinding

        Dim zLossEstimates() As TextBox = {Me.txtTIV, Me.txtTIVPD, Me.txtTIVBI, Me.txtTIV1, Me.txtTIVPD1, Me.txtTIVBI1, Me.txtPML, Me.txtPMLBI, Me.txtPMLPD, Me.txtMFL, Me.txtMFLPD, Me.txtMFLBI}
        UtilReport.TelerikReport.SetCurrencyFormat(zLossEstimates, rptProperties)


        Me.BCPRecsSubReport.rptProperties = rptProperties
        Me.BoilerFacilityDataSummary_LargestPrimaryTransformers1.rptProperties = rptProperties
        Me.BPVRecsSubReport.rptProperties = rptProperties
        Me.ComputerSystemRecsSubReport.rptProperties = rptProperties
        Me.CritcalSparesRecsSubReport.rptProperties = rptProperties
        Me.CriticalSpareItemsSubReport.rptProperties = rptProperties
        Me.ElectricalRecsSubReport.rptProperties = rptProperties
        Me.EPPMRecsSubReport.rptProperties = rptProperties
        Me.CPVItemsSubReport.rptProperties = rptProperties
        Me.HeRecsSubReport.rptProperties = rptProperties
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

    Private Sub BoilerFacilityDataSummary_ItemDataBound(sender As Object, e As System.EventArgs) Handles Me.ItemDataBound

        Dim zExposureItems() As TextBox = {txtCompAirExposure, txtRefrigerationExposure, txtWaterExposure, txtCoolingExposure, txtFuelExposure, txtPPEExposure, txtBoilerExposure, txtCriticalPressureVesselExposure, txtCriticalSparesMaintained, txtComputerExposure, txtElectricalExposure}
        UtilReport.TelerikReport.SetItemBackColorByExposure(sender, zExposureItems, rptProperties)

        Dim zRatingItems() As TextBox = {txtMPPMOverallRating, txtEPPMOverallRating, txtOverallHERating, txtCriticalSparesMaintained, txtBCPInPlace}
        UtilReport.TelerikReport.SetItemBackColorByText(sender, zRatingItems, rptProperties)

    End Sub

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

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties

    Public Function AppendPracticeToTitle() As Boolean Implements ITelerikReport.AppendPracticeToTitle
        Return True
    End Function

    Private Sub Me_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        UtilReport.TelerikReport.SetFilterText(sender, rptProperties)
        UtilReport.TelerikReport.SetDisclaimerText(sender, rptProperties)
        UtilReport.TelerikReport.SetSortText(sender, rptProperties)
    End Sub

End Class