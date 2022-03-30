Imports System.ComponentModel
Imports System.Drawing
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class BMFacilityDataReport
    Inherits BaseReportPortrait
    Implements ITelerikReport
    Implements IUtilReport

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        UtilReport.TelerikReport.FixBaseGroups(Me)
        'SetSubReportHeight()
        'SetPanelHeight()

    End Sub

    'Public Sub New(ByVal pGuid As String, Optional ByVal pReport As Libraries.CoreLib.UtilReporting.Reports = 0)
    '     MyBase.New(pGuid, pReport)
    '     InitializeComponent()
    '     ' SetSubReportHeight()
    '     'SetPanelHeight()

    '     If Me.BmCopeDataReport_BoilersSubReport1.detail.Items.Count = 0 Then Me.BmCopeDataReport_BoilersSubReport1.Visible = False
    '     If Me.BmCopeDataReport_CPVSubReport1.detail.Items.Count = 0 Then Me.BmCopeDataReport_CPVSubReport1.Visible = False
    '     If Me.BmCopeDataReport_CriticalSparesSubReport1.detail.Items.Count = 0 Then Me.BmCopeDataReport_CriticalSparesSubReport1.Visible = False
    '     If Me.BmCopeDataReport_PPESubReport1.detail.Items.Count = 0 Then Me.BmCopeDataReport_PPESubReport1.Visible = False
    '     If Me.BmCopeDataReport_PrimaryTransformers1.detail.Items.Count = 0 Then Me.BmCopeDataReport_PrimaryTransformers1.Visible = False
    '     If Me.BmCopeDataReport_PrimeMoversSubReport1.Items.Count = 0 Then Me.BmCopeDataReport_PrimeMoversSubReport1.Visible = False
    '     If Me.BmCopeDataReport_RotatingElectEquipment1.detail.Items.Count = 0 Then Me.BmCopeDataReport_RotatingElectEquipment1.Visible = False

    'End Sub

    'Public Sub New(ByVal pJobId As Integer)
    '     MyBase.New(pJobId)
    '     InitializeComponent()

    '     If Me.BmCopeDataReport_BoilersSubReport1.detail.Items.Count = 0 Then Me.BmCopeDataReport_BoilersSubReport1.Visible = False
    '     If Me.BmCopeDataReport_CPVSubReport1.detail.Items.Count = 0 Then Me.BmCopeDataReport_CPVSubReport1.Visible = False
    '     If Me.BmCopeDataReport_CriticalSparesSubReport1.detail.Items.Count = 0 Then Me.BmCopeDataReport_CriticalSparesSubReport1.Visible = False
    '     If Me.BmCopeDataReport_PPESubReport1.detail.Items.Count = 0 Then Me.BmCopeDataReport_PPESubReport1.Visible = False
    '     If Me.BmCopeDataReport_PrimaryTransformers1.detail.Items.Count = 0 Then Me.BmCopeDataReport_PrimaryTransformers1.Visible = False
    '     If Me.BmCopeDataReport_PrimeMoversSubReport1.Items.Count = 0 Then Me.BmCopeDataReport_PrimeMoversSubReport1.Visible = False
    '     If Me.BmCopeDataReport_RotatingElectEquipment1.detail.Items.Count = 0 Then Me.BmCopeDataReport_RotatingElectEquipment1.Visible = False



    '     'SetSubReportHeight()
    '     'SetPanelHeight()
    'End Sub

    Public Sub SetSubReportHeight()
        Me.SubReport1.Height = New Telerik.Reporting.Drawing.Unit(0.01, UnitType.Inch)
        Me.SubReport2.Height = New Telerik.Reporting.Drawing.Unit(0.01, UnitType.Inch)
        Me.SubReport3.Height = New Telerik.Reporting.Drawing.Unit(0.01, UnitType.Inch)
        Me.SubReport4.Height = New Telerik.Reporting.Drawing.Unit(0.01, UnitType.Inch)
        Me.SubReport5.Height = New Telerik.Reporting.Drawing.Unit(0.01, UnitType.Inch)
        Me.SubReport6.Height = New Telerik.Reporting.Drawing.Unit(0.01, UnitType.Inch)
        Me.SubReport7.Height = New Telerik.Reporting.Drawing.Unit(0.01, UnitType.Inch)
    End Sub

    Public Sub SetPanelHeight()
        Me.Panel1.Height = New Telerik.Reporting.Drawing.Unit(0.01, UnitType.Inch)
        Me.Panel2.Height = New Telerik.Reporting.Drawing.Unit(0.01, UnitType.Inch)
        Me.Panel4.Height = New Telerik.Reporting.Drawing.Unit(0.01, UnitType.Inch)
        Me.Panel5.Height = New Telerik.Reporting.Drawing.Unit(0.01, UnitType.Inch)
        Me.Panel6.Height = New Telerik.Reporting.Drawing.Unit(0.01, UnitType.Inch)
        Me.Panel7.Height = New Telerik.Reporting.Drawing.Unit(0.01, UnitType.Inch)
        Me.Panel8.Height = New Telerik.Reporting.Drawing.Unit(0.01, UnitType.Inch)
        Me.Panel9.Height = New Telerik.Reporting.Drawing.Unit(0.01, UnitType.Inch)
        Me.Panel10.Height = New Telerik.Reporting.Drawing.Unit(0.01, UnitType.Inch)
        Me.Panel11.Height = New Telerik.Reporting.Drawing.Unit(0.01, UnitType.Inch)
        Me.Panel12.Height = New Telerik.Reporting.Drawing.Unit(0.01, UnitType.Inch)
        Me.Panel13.Height = New Telerik.Reporting.Drawing.Unit(0.01, UnitType.Inch)
        Me.Panel14.Height = New Telerik.Reporting.Drawing.Unit(0.01, UnitType.Inch)
        Me.Panel15.Height = New Telerik.Reporting.Drawing.Unit(0.01, UnitType.Inch)
    End Sub

    Public Function IsStandardHeader() As Boolean Implements ITelerikReport.IsStandardHeader
        Return True
    End Function

    Public Function ReportSubSubTitle() As String Implements ITelerikReport.ReportSubSubTitle
        Return ""
    End Function

    Public Function ReportSubTitle() As String Implements ITelerikReport.ReportSubTitle
        Return ""
    End Function

    Public Function ReportTitle() As String Implements ITelerikReport.ReportTitle
        Return "Facility Data Form"
    End Function

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties

    Private Sub BoilerFacilityDataReport_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding

        Me.BmCopeDataReport_BoilersSubReport1.rptProperties = rptProperties
        Me.BmCopeDataReport_CPVSubReport1.rptProperties = rptProperties
        Me.BmCopeDataReport_CriticalSparesSubReport1.rptProperties = rptProperties
        Me.BmCopeDataReport_PPESubReport1.rptProperties = rptProperties
        Me.BmCopeDataReport_PrimaryTransformers1.rptProperties = rptProperties
        Me.BmCopeDataReport_PrimeMoversSubReport1.rptProperties = rptProperties
        Me.BmCopeDataReport_RotatingElectEquipment1.rptProperties = rptProperties

        'If Me.BmCopeDataReport_BoilersSubReport1.detail.Items.Count = 0 Then Me.BmCopeDataReport_BoilersSubReport1.Visible = False
        'If Me.BmCopeDataReport_CPVSubReport1.detail.Items.Count = 0 Then Me.BmCopeDataReport_CPVSubReport1.Visible = False
        'If Me.BmCopeDataReport_CriticalSparesSubReport1.detail.Items.Count = 0 Then Me.BmCopeDataReport_CriticalSparesSubReport1.Visible = False
        'If Me.BmCopeDataReport_PPESubReport1.detail.Items.Count = 0 Then Me.BmCopeDataReport_PPESubReport1.Visible = False
        'If Me.BmCopeDataReport_PrimaryTransformers1.detail.Items.Count = 0 Then Me.BmCopeDataReport_PrimaryTransformers1.Visible = False
        'If Me.BmCopeDataReport_PrimeMoversSubReport1.Items.Count = 0 Then Me.BmCopeDataReport_PrimeMoversSubReport1.Visible = False
        'If Me.BmCopeDataReport_RotatingElectEquipment1.detail.Items.Count = 0 Then Me.BmCopeDataReport_RotatingElectEquipment1.Visible = False

        Me.txtCurrency.Value = rptProperties.Currency.colFldName
        Dim zLossEstimates() As TextBox = {Me.txtPMLBI, Me.txtPMLPD, Me.txtPML, Me.txtTIV, Me.txtTIVBI, Me.txtTIVPD, Me.txtMFL, Me.txtMFLBI, Me.txtPMLPD, Me.txtIBI}
        UtilReport.TelerikReport.SetCurrencyFormat(zLossEstimates, rptProperties)

        If UtilCustomFeature.Contains(rptProperties, CChar("&")) Then
            txtIBI.Visible = True
            txtIBILabel.Visible = True
        End If
    End Sub

    Private Sub Me_ItemDataBound(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        UtilReport.TelerikReport.SetFilterText(sender, rptProperties)
        UtilReport.TelerikReport.SetDisclaimerText(sender, rptProperties)
        UtilReport.TelerikReport.SetSortText(sender, rptProperties)
    End Sub

    Public Function AppendPracticeToTitle() As Boolean Implements ITelerikReport.AppendPracticeToTitle
        Return True
    End Function
End Class