Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports

Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing

Public Class rptFireExtinguishersHazardControlsSummary
    Inherits GrapeCity.ActiveReports.SectionReport
    Implements IUtilReport
    Implements IActiveReport

#Region " ActiveReports Designer generated code "
    'Required by the ActiveReports Designer
    Private Shadows components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the ActiveReports Designer
    'It can be modified using the ActiveReports Designer.
    'Do not modify it using the code editor.
    Private WithEvents PageHeader1 As GrapeCity.ActiveReports.SectionReportModel.PageHeader
    Private WithEvents Detail1 As GrapeCity.ActiveReports.SectionReportModel.Detail
    Private WithEvents picGRCLogo As GrapeCity.ActiveReports.SectionReportModel.Picture
    Private WithEvents lblClientName As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFireExtinguishersHazardControlsSummary As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblLocationInformation As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFileNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblDivision2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblInspectionDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCity As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblAddress As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblSTProv As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCountry As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblTIVGrid As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblExtinguishers As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblPortableFireExtinguisher As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblPropStorage As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblNoSmoking As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFireDoorsNotObstr As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblNoMissCealTiles As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblBarricadeProvided As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblNoStorageInElecRm As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblHazardControls As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtFileNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSurveyDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCity As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSTProv As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCountry As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtTIV As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtDivision2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtAddress As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtPropStorage As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtNoSmoking As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFireDoorsNotObstr As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtNoMissCealTiles As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtBarricadeProvided As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtNoStorageInElecRm As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtPlasSkids As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSort As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFilters As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtFilters As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblClientLocNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFacility As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line3 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line4 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line5 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line9 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line10 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line11 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line12 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line14 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line15 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line16 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line17 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line18 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line22 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line23 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line25 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line29 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line30 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line36 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line37 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line38 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line39 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line40 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtClientLocNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFacility As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents line49 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line50 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line51 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line52 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line53 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lblReportDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents line54 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line55 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line56 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line57 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line59 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line60 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line61 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line62 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line63 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line64 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line65 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line67 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line71 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line72 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents reportInfo1 As GrapeCity.ActiveReports.SectionReportModel.ReportInfo
    Private WithEvents lblPFEInspMonthly As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblPFEServAnn As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblPFEAppTypeSize As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblPFEMounted As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFireHosesInsp As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblHotWorkPermit As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFlamLiqStored As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lbl16Separation As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblPropCylinders As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblPlasSkids As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents line6 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line19 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line20 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line66 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line69 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtPFEInspMonthly As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtPFEServAnn As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtPFEAppTypeSize As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtPFEMounted As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFireHosesInsp As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtHotWorkPermit As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFlamLiqStored As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txt16Separation As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtPropCylinders As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents line73 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line74 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line78 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line80 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line81 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line83 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line84 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line85 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line86 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line87 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line88 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtDisclaimer As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtHotWorkPermitC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFlamLiqStoredC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txt16SeparationC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtPropCylindersC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtNoSmokingC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtPropStorageC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFireDoorsNotObstrC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtNoMissCealTilesC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtBarricadeProvidedC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtNoStorageInElecRmC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtPlasSkidsC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtPFEInspMonthlyC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtPFEServAnnC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtPFEAppTypeSizeC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtPFEMountedC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFireHosesInspC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents PageFooter1 As GrapeCity.ActiveReports.SectionReportModel.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptFireExtinguishersHazardControlsSummary))
        Me.PageHeader1 = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.lblFlamLiqStored = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblHotWorkPermit = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPFEMounted = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPFEAppTypeSize = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPFEServAnn = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPFEInspMonthly = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFireHosesInsp = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lbl16Separation = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPropCylinders = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPropStorage = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblNoSmoking = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFireDoorsNotObstr = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblNoMissCealTiles = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblBarricadeProvided = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblNoStorageInElecRm = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPlasSkids = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPortableFireExtinguisher = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblClientName = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFireExtinguishersHazardControlsSummary = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblLocationInformation = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.picGRCLogo = New GrapeCity.ActiveReports.SectionReportModel.Picture()
        Me.lblFileNo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblDivision2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblInspectionDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblCity = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblAddress = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSTProv = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblCountry = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblTIVGrid = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblExtinguishers = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblHazardControls = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFilters = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtFilters = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblClientLocNo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFacility = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line5 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line9 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line10 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line11 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line12 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line14 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line15 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line16 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line17 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line18 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line22 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line25 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line29 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line30 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line36 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line37 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line38 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line39 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line40 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line6 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line19 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line20 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line66 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line69 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line23 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Detail1 = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.txtFireHosesInspC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPFEMountedC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPFEAppTypeSizeC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPFEServAnnC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPFEInspMonthlyC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtNoStorageInElecRmC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtBarricadeProvidedC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtNoMissCealTilesC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFireDoorsNotObstrC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPropStorageC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtNoSmokingC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPropCylindersC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt16SeparationC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFlamLiqStoredC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtHotWorkPermitC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPlasSkidsC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtHotWorkPermit = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFlamLiqStored = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt16Separation = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPropCylinders = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtNoSmoking = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtAddress = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtDivision2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFileNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSurveyDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCity = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSTProv = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCountry = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtTIV = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPropStorage = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFireDoorsNotObstr = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtNoMissCealTiles = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtBarricadeProvided = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtNoStorageInElecRm = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPlasSkids = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFacility = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtClientLocNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.line49 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line50 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line51 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line52 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line53 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line54 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line55 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line56 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line57 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line59 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line60 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line61 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line62 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line63 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line64 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line65 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line67 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line71 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line72 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtPFEInspMonthly = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPFEServAnn = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPFEAppTypeSize = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPFEMounted = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFireHosesInsp = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.line73 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line74 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line78 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line80 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line81 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line83 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line84 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line85 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line86 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line87 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line88 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.PageFooter1 = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.txtSort = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblReportDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.reportInfo1 = New GrapeCity.ActiveReports.SectionReportModel.ReportInfo()
        Me.txtDisclaimer = New GrapeCity.ActiveReports.SectionReportModel.Label()
        CType(Me.lblFlamLiqStored, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHotWorkPermit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPFEMounted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPFEAppTypeSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPFEServAnn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPFEInspMonthly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFireHosesInsp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl16Separation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPropCylinders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPropStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNoSmoking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFireDoorsNotObstr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNoMissCealTiles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBarricadeProvided, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNoStorageInElecRm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPlasSkids, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPortableFireExtinguisher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblClientName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFireExtinguishersHazardControlsSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblLocationInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGRCLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFileNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDivision2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblInspectionDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSTProv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTIVGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblExtinguishers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHazardControls, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblClientLocNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFacility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFireHosesInspC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPFEMountedC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPFEAppTypeSizeC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPFEServAnnC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPFEInspMonthlyC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoStorageInElecRmC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBarricadeProvidedC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoMissCealTilesC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFireDoorsNotObstrC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPropStorageC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoSmokingC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPropCylindersC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt16SeparationC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFlamLiqStoredC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHotWorkPermitC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPlasSkidsC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHotWorkPermit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFlamLiqStored, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt16Separation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPropCylinders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoSmoking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDivision2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFileNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSurveyDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSTProv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTIV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPropStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFireDoorsNotObstr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoMissCealTiles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBarricadeProvided, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoStorageInElecRm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPlasSkids, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFacility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientLocNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPFEInspMonthly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPFEServAnn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPFEAppTypeSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPFEMounted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFireHosesInsp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblReportDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisclaimer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.CanShrink = True
        Me.PageHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblFlamLiqStored, Me.lblHotWorkPermit, Me.lblPFEMounted, Me.lblPFEAppTypeSize, Me.lblPFEServAnn, Me.lblPFEInspMonthly, Me.lblFireHosesInsp, Me.lbl16Separation, Me.lblPropCylinders, Me.lblPropStorage, Me.lblNoSmoking, Me.lblFireDoorsNotObstr, Me.lblNoMissCealTiles, Me.lblBarricadeProvided, Me.lblNoStorageInElecRm, Me.lblPlasSkids, Me.lblPortableFireExtinguisher, Me.lblClientName, Me.lblFireExtinguishersHazardControlsSummary, Me.lblLocationInformation, Me.picGRCLogo, Me.lblFileNo, Me.lblDivision2, Me.lblInspectionDate, Me.lblCity, Me.lblAddress, Me.lblSTProv, Me.lblCountry, Me.lblTIVGrid, Me.lblExtinguishers, Me.lblHazardControls, Me.lblFilters, Me.txtFilters, Me.lblClientLocNo, Me.lblFacility, Me.line1, Me.line2, Me.line3, Me.line4, Me.line5, Me.line9, Me.line10, Me.line11, Me.line12, Me.line14, Me.line15, Me.line16, Me.line17, Me.line18, Me.line22, Me.line25, Me.line29, Me.line30, Me.line36, Me.line37, Me.line38, Me.line39, Me.line40, Me.line6, Me.line19, Me.line20, Me.line66, Me.line69, Me.line23})
        Me.PageHeader1.Height = 1.65!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'lblFlamLiqStored
        '
        Me.lblFlamLiqStored.Height = 0.45!
        Me.lblFlamLiqStored.HyperLink = Nothing
        Me.lblFlamLiqStored.Left = 7.1!
        Me.lblFlamLiqStored.Name = "lblFlamLiqStored"
        Me.lblFlamLiqStored.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblFlamLiqStored.Text = "Flam. Liq. Storage"
        Me.lblFlamLiqStored.Top = 1.2!
        Me.lblFlamLiqStored.Width = 0.4!
        '
        'lblHotWorkPermit
        '
        Me.lblHotWorkPermit.Height = 0.45!
        Me.lblHotWorkPermit.HyperLink = Nothing
        Me.lblHotWorkPermit.Left = 6.65!
        Me.lblHotWorkPermit.Name = "lblHotWorkPermit"
        Me.lblHotWorkPermit.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblHotWorkPermit.Text = "Hot Work PS In Place"
        Me.lblHotWorkPermit.Top = 1.2!
        Me.lblHotWorkPermit.Width = 0.45!
        '
        'lblPFEMounted
        '
        Me.lblPFEMounted.Height = 0.3!
        Me.lblPFEMounted.HyperLink = Nothing
        Me.lblPFEMounted.Left = 5.7!
        Me.lblPFEMounted.Name = "lblPFEMounted"
        Me.lblPFEMounted.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblPFEMounted.Text = "Accessible"
        Me.lblPFEMounted.Top = 1.35!
        Me.lblPFEMounted.Width = 0.5!
        '
        'lblPFEAppTypeSize
        '
        Me.lblPFEAppTypeSize.Height = 0.3!
        Me.lblPFEAppTypeSize.HyperLink = Nothing
        Me.lblPFEAppTypeSize.Left = 5.23!
        Me.lblPFEAppTypeSize.Name = "lblPFEAppTypeSize"
        Me.lblPFEAppTypeSize.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblPFEAppTypeSize.Text = "Appr. Type/Size"
        Me.lblPFEAppTypeSize.Top = 1.35!
        Me.lblPFEAppTypeSize.Width = 0.47!
        '
        'lblPFEServAnn
        '
        Me.lblPFEServAnn.Height = 0.3!
        Me.lblPFEServAnn.HyperLink = Nothing
        Me.lblPFEServAnn.Left = 4.8!
        Me.lblPFEServAnn.Name = "lblPFEServAnn"
        Me.lblPFEServAnn.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblPFEServAnn.Text = "Serv'd Annually"
        Me.lblPFEServAnn.Top = 1.35!
        Me.lblPFEServAnn.Width = 0.43!
        '
        'lblPFEInspMonthly
        '
        Me.lblPFEInspMonthly.Height = 0.3!
        Me.lblPFEInspMonthly.HyperLink = Nothing
        Me.lblPFEInspMonthly.Left = 4.42!
        Me.lblPFEInspMonthly.Name = "lblPFEInspMonthly"
        Me.lblPFEInspMonthly.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblPFEInspMonthly.Text = "Insp. Monthly"
        Me.lblPFEInspMonthly.Top = 1.35!
        Me.lblPFEInspMonthly.Width = 0.38!
        '
        'lblFireHosesInsp
        '
        Me.lblFireHosesInsp.Height = 0.3!
        Me.lblFireHosesInsp.HyperLink = Nothing
        Me.lblFireHosesInsp.Left = 6.2!
        Me.lblFireHosesInsp.Name = "lblFireHosesInsp"
        Me.lblFireHosesInsp.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblFireHosesInsp.Text = "Fire Hoses"
        Me.lblFireHosesInsp.Top = 1.35!
        Me.lblFireHosesInsp.Width = 0.4!
        '
        'lbl16Separation
        '
        Me.lbl16Separation.Height = 0.45!
        Me.lbl16Separation.HyperLink = Nothing
        Me.lbl16Separation.Left = 7.5!
        Me.lbl16Separation.Name = "lbl16Separation"
        Me.lbl16Separation.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lbl16Separation.Text = "16in Clearance Cooking Equip."
        Me.lbl16Separation.Top = 1.2!
        Me.lbl16Separation.Width = 0.5!
        '
        'lblPropCylinders
        '
        Me.lblPropCylinders.Height = 0.45!
        Me.lblPropCylinders.HyperLink = Nothing
        Me.lblPropCylinders.Left = 8.0!
        Me.lblPropCylinders.Name = "lblPropCylinders"
        Me.lblPropCylinders.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblPropCylinders.Text = "No Interior Propane Storage"
        Me.lblPropCylinders.Top = 1.2!
        Me.lblPropCylinders.Width = 0.4!
        '
        'lblPropStorage
        '
        Me.lblPropStorage.Height = 0.45!
        Me.lblPropStorage.HyperLink = Nothing
        Me.lblPropStorage.Left = 8.4!
        Me.lblPropStorage.Name = "lblPropStorage"
        Me.lblPropStorage.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblPropStorage.Text = "Ext. LP Stg. 10ft Clearance"
        Me.lblPropStorage.Top = 1.2!
        Me.lblPropStorage.Width = 0.48!
        '
        'lblNoSmoking
        '
        Me.lblNoSmoking.Height = 0.45!
        Me.lblNoSmoking.HyperLink = Nothing
        Me.lblNoSmoking.Left = 8.88!
        Me.lblNoSmoking.Name = "lblNoSmoking"
        Me.lblNoSmoking.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblNoSmoking.Text = "No Smoking"
        Me.lblNoSmoking.Top = 1.2!
        Me.lblNoSmoking.Width = 0.42!
        '
        'lblFireDoorsNotObstr
        '
        Me.lblFireDoorsNotObstr.Height = 0.45!
        Me.lblFireDoorsNotObstr.HyperLink = Nothing
        Me.lblFireDoorsNotObstr.Left = 9.3!
        Me.lblFireDoorsNotObstr.Name = "lblFireDoorsNotObstr"
        Me.lblFireDoorsNotObstr.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblFireDoorsNotObstr.Text = "Fire Doors Not Obstructed"
        Me.lblFireDoorsNotObstr.Top = 1.2!
        Me.lblFireDoorsNotObstr.Width = 0.55!
        '
        'lblNoMissCealTiles
        '
        Me.lblNoMissCealTiles.Height = 0.45!
        Me.lblNoMissCealTiles.HyperLink = Nothing
        Me.lblNoMissCealTiles.Left = 9.85!
        Me.lblNoMissCealTiles.Name = "lblNoMissCealTiles"
        Me.lblNoMissCealTiles.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblNoMissCealTiles.Text = "No Missing Ceiling Tiles"
        Me.lblNoMissCealTiles.Top = 1.2!
        Me.lblNoMissCealTiles.Width = 0.4!
        '
        'lblBarricadeProvided
        '
        Me.lblBarricadeProvided.Height = 0.45!
        Me.lblBarricadeProvided.HyperLink = Nothing
        Me.lblBarricadeProvided.Left = 10.25!
        Me.lblBarricadeProvided.Name = "lblBarricadeProvided"
        Me.lblBarricadeProvided.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblBarricadeProvided.Text = "Barrier for NG/ Traffic"
        Me.lblBarricadeProvided.Top = 1.2!
        Me.lblBarricadeProvided.Width = 0.4!
        '
        'lblNoStorageInElecRm
        '
        Me.lblNoStorageInElecRm.Height = 0.45!
        Me.lblNoStorageInElecRm.HyperLink = Nothing
        Me.lblNoStorageInElecRm.Left = 10.65!
        Me.lblNoStorageInElecRm.Name = "lblNoStorageInElecRm"
        Me.lblNoStorageInElecRm.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblNoStorageInElecRm.Text = "No Storage in Elec. Room"
        Me.lblNoStorageInElecRm.Top = 1.2!
        Me.lblNoStorageInElecRm.Width = 0.4!
        '
        'lblPlasSkids
        '
        Me.lblPlasSkids.Height = 0.45!
        Me.lblPlasSkids.HyperLink = Nothing
        Me.lblPlasSkids.Left = 11.05!
        Me.lblPlasSkids.Name = "lblPlasSkids"
        Me.lblPlasSkids.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblPlasSkids.Text = "Skids / Pallet Storage"
        Me.lblPlasSkids.Top = 1.2!
        Me.lblPlasSkids.Width = 0.4!
        '
        'lblPortableFireExtinguisher
        '
        Me.lblPortableFireExtinguisher.Height = 0.15!
        Me.lblPortableFireExtinguisher.HyperLink = Nothing
        Me.lblPortableFireExtinguisher.Left = 4.42!
        Me.lblPortableFireExtinguisher.Name = "lblPortableFireExtinguisher"
        Me.lblPortableFireExtinguisher.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblPortableFireExtinguisher.Text = "Portable Fire Extinguisher"
        Me.lblPortableFireExtinguisher.Top = 1.2!
        Me.lblPortableFireExtinguisher.Width = 1.78!
        '
        'lblClientName
        '
        Me.lblClientName.Height = 0.25!
        Me.lblClientName.HyperLink = Nothing
        Me.lblClientName.Left = 7.11!
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Style = "color: #C6D1DE; font-size: 16pt; font-style: italic; font-weight: bold; text-alig" & _
    "n: right; vertical-align: middle"
        Me.lblClientName.Text = "Company Name"
        Me.lblClientName.Top = 0.05!
        Me.lblClientName.Width = 4.3!
        '
        'lblFireExtinguishersHazardControlsSummary
        '
        Me.lblFireExtinguishersHazardControlsSummary.Height = 0.25!
        Me.lblFireExtinguishersHazardControlsSummary.HyperLink = Nothing
        Me.lblFireExtinguishersHazardControlsSummary.Left = 7.11!
        Me.lblFireExtinguishersHazardControlsSummary.Name = "lblFireExtinguishersHazardControlsSummary"
        Me.lblFireExtinguishersHazardControlsSummary.Style = "font-size: 12pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblFireExtinguishersHazardControlsSummary.Text = "Fire - Extinguishers & Hazard Controls Summary"
        Me.lblFireExtinguishersHazardControlsSummary.Top = 0.35!
        Me.lblFireExtinguishersHazardControlsSummary.Width = 4.3!
        '
        'lblLocationInformation
        '
        Me.lblLocationInformation.Height = 0.15!
        Me.lblLocationInformation.HyperLink = Nothing
        Me.lblLocationInformation.Left = 0.0!
        Me.lblLocationInformation.Name = "lblLocationInformation"
        Me.lblLocationInformation.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblLocationInformation.Text = "Location Detail"
        Me.lblLocationInformation.Top = 1.05!
        Me.lblLocationInformation.Width = 4.37!
        '
        'picGRCLogo
        '
        Me.picGRCLogo.Height = 0.5!
        Me.picGRCLogo.ImageData = CType(resources.GetObject("picGRCLogo.ImageData"), System.IO.Stream)
        Me.picGRCLogo.Left = 0.0!
        Me.picGRCLogo.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.picGRCLogo.Name = "picGRCLogo"
        Me.picGRCLogo.PictureAlignment = GrapeCity.ActiveReports.SectionReportModel.PictureAlignment.TopLeft
        Me.picGRCLogo.SizeMode = GrapeCity.ActiveReports.SectionReportModel.SizeModes.Stretch
        Me.picGRCLogo.Top = 0.0!
        Me.picGRCLogo.Width = 3.0!
        '
        'lblFileNo
        '
        Me.lblFileNo.Height = 0.15!
        Me.lblFileNo.HyperLink = Nothing
        Me.lblFileNo.Left = 0.0!
        Me.lblFileNo.Name = "lblFileNo"
        Me.lblFileNo.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.lblFileNo.Text = "File No."
        Me.lblFileNo.Top = 1.2!
        Me.lblFileNo.Width = 0.52!
        '
        'lblDivision2
        '
        Me.lblDivision2.Height = 0.15!
        Me.lblDivision2.HyperLink = Nothing
        Me.lblDivision2.Left = 0.0!
        Me.lblDivision2.Name = "lblDivision2"
        Me.lblDivision2.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.lblDivision2.Text = "Division"
        Me.lblDivision2.Top = 1.35!
        Me.lblDivision2.Width = 1.1!
        '
        'lblInspectionDate
        '
        Me.lblInspectionDate.Height = 0.146!
        Me.lblInspectionDate.HyperLink = Nothing
        Me.lblInspectionDate.Left = 0.52!
        Me.lblInspectionDate.Name = "lblInspectionDate"
        Me.lblInspectionDate.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.lblInspectionDate.Text = "Date of Insp."
        Me.lblInspectionDate.Top = 1.2!
        Me.lblInspectionDate.Width = 0.58!
        '
        'lblCity
        '
        Me.lblCity.Height = 0.15!
        Me.lblCity.HyperLink = Nothing
        Me.lblCity.Left = 1.9!
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.lblCity.Text = "City/"
        Me.lblCity.Top = 1.2!
        Me.lblCity.Width = 0.95!
        '
        'lblAddress
        '
        Me.lblAddress.Height = 0.15!
        Me.lblAddress.HyperLink = Nothing
        Me.lblAddress.Left = 1.9!
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Style = "font-size: 7pt; vertical-align: middle"
        Me.lblAddress.Text = "Address"
        Me.lblAddress.Top = 1.35!
        Me.lblAddress.Width = 2.05!
        '
        'lblSTProv
        '
        Me.lblSTProv.Height = 0.15!
        Me.lblSTProv.HyperLink = Nothing
        Me.lblSTProv.Left = 2.85!
        Me.lblSTProv.Name = "lblSTProv"
        Me.lblSTProv.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.lblSTProv.Text = "St/Pr"
        Me.lblSTProv.Top = 1.2!
        Me.lblSTProv.Width = 0.35!
        '
        'lblCountry
        '
        Me.lblCountry.Height = 0.15!
        Me.lblCountry.HyperLink = Nothing
        Me.lblCountry.Left = 3.2!
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.lblCountry.Text = "Country"
        Me.lblCountry.Top = 1.2!
        Me.lblCountry.Width = 0.75!
        '
        'lblTIVGrid
        '
        Me.lblTIVGrid.Height = 0.3!
        Me.lblTIVGrid.HyperLink = Nothing
        Me.lblTIVGrid.Left = 3.95!
        Me.lblTIVGrid.Name = "lblTIVGrid"
        Me.lblTIVGrid.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblTIVGrid.Text = "TIV (millions)"
        Me.lblTIVGrid.Top = 1.2!
        Me.lblTIVGrid.Width = 0.42!
        '
        'lblExtinguishers
        '
        Me.lblExtinguishers.Height = 0.15!
        Me.lblExtinguishers.HyperLink = Nothing
        Me.lblExtinguishers.Left = 4.42!
        Me.lblExtinguishers.Name = "lblExtinguishers"
        Me.lblExtinguishers.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblExtinguishers.Text = "Extinguishers"
        Me.lblExtinguishers.Top = 1.05!
        Me.lblExtinguishers.Width = 2.18!
        '
        'lblHazardControls
        '
        Me.lblHazardControls.Height = 0.15!
        Me.lblHazardControls.HyperLink = Nothing
        Me.lblHazardControls.Left = 6.65!
        Me.lblHazardControls.Name = "lblHazardControls"
        Me.lblHazardControls.Style = "background-color: White; font-size: 7pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblHazardControls.Text = "Hazard Controls"
        Me.lblHazardControls.Top = 1.05!
        Me.lblHazardControls.Width = 4.8!
        '
        'lblFilters
        '
        Me.lblFilters.Height = 0.15!
        Me.lblFilters.HyperLink = Nothing
        Me.lblFilters.Left = 0.05!
        Me.lblFilters.Name = "lblFilters"
        Me.lblFilters.Style = "background-color: White; font-size: 8pt; font-weight: bold; vertical-align: middl" & _
    "e"
        Me.lblFilters.Text = "Filters:"
        Me.lblFilters.Top = 0.85!
        Me.lblFilters.Width = 0.4!
        '
        'txtFilters
        '
        Me.txtFilters.CanShrink = True
        Me.txtFilters.Height = 0.15!
        Me.txtFilters.Left = 0.44!
        Me.txtFilters.Name = "txtFilters"
        Me.txtFilters.Style = "background-color: White; font-size: 8pt; vertical-align: middle"
        Me.txtFilters.Text = Nothing
        Me.txtFilters.Top = 0.85!
        Me.txtFilters.Width = 13.06!
        '
        'lblClientLocNo
        '
        Me.lblClientLocNo.Height = 0.146!
        Me.lblClientLocNo.HyperLink = Nothing
        Me.lblClientLocNo.Left = 1.1!
        Me.lblClientLocNo.Name = "lblClientLocNo"
        Me.lblClientLocNo.Style = "background-color: White; font-size: 7pt"
        Me.lblClientLocNo.Text = "Client Loc. No"
        Me.lblClientLocNo.Top = 1.2!
        Me.lblClientLocNo.Width = 0.8!
        '
        'lblFacility
        '
        Me.lblFacility.Height = 0.15!
        Me.lblFacility.HyperLink = Nothing
        Me.lblFacility.Left = 1.1!
        Me.lblFacility.Name = "lblFacility"
        Me.lblFacility.Style = "background-color: White; font-size: 7pt"
        Me.lblFacility.Text = "Facility"
        Me.lblFacility.Top = 1.35!
        Me.lblFacility.Width = 0.8!
        '
        'line1
        '
        Me.line1.Height = 0.0!
        Me.line1.Left = 0.0!
        Me.line1.LineWeight = 1.0!
        Me.line1.Name = "line1"
        Me.line1.Top = 1.65!
        Me.line1.Width = 4.37!
        Me.line1.X1 = 0.0!
        Me.line1.X2 = 4.37!
        Me.line1.Y1 = 1.65!
        Me.line1.Y2 = 1.65!
        '
        'line2
        '
        Me.line2.Height = 0.0!
        Me.line2.Left = 0.0!
        Me.line2.LineWeight = 1.0!
        Me.line2.Name = "line2"
        Me.line2.Top = 1.05!
        Me.line2.Width = 4.37!
        Me.line2.X1 = 0.0!
        Me.line2.X2 = 4.37!
        Me.line2.Y1 = 1.05!
        Me.line2.Y2 = 1.05!
        '
        'line3
        '
        Me.line3.Height = 0.6!
        Me.line3.Left = 0.0!
        Me.line3.LineWeight = 1.0!
        Me.line3.Name = "line3"
        Me.line3.Top = 1.05!
        Me.line3.Width = 0.0!
        Me.line3.X1 = 0.0!
        Me.line3.X2 = 0.0!
        Me.line3.Y1 = 1.05!
        Me.line3.Y2 = 1.65!
        '
        'line4
        '
        Me.line4.Height = 0.6!
        Me.line4.Left = 4.37!
        Me.line4.LineWeight = 1.0!
        Me.line4.Name = "line4"
        Me.line4.Top = 1.05!
        Me.line4.Width = 0.0!
        Me.line4.X1 = 4.37!
        Me.line4.X2 = 4.37!
        Me.line4.Y1 = 1.05!
        Me.line4.Y2 = 1.65!
        '
        'line5
        '
        Me.line5.Height = 0.6!
        Me.line5.Left = 4.42!
        Me.line5.LineWeight = 1.0!
        Me.line5.Name = "line5"
        Me.line5.Top = 1.05!
        Me.line5.Width = 0.0!
        Me.line5.X1 = 4.42!
        Me.line5.X2 = 4.42!
        Me.line5.Y1 = 1.05!
        Me.line5.Y2 = 1.65!
        '
        'line9
        '
        Me.line9.Height = 0.4499999!
        Me.line9.Left = 7.5!
        Me.line9.LineWeight = 1.0!
        Me.line9.Name = "line9"
        Me.line9.Top = 1.2!
        Me.line9.Width = 0.0!
        Me.line9.X1 = 7.5!
        Me.line9.X2 = 7.5!
        Me.line9.Y1 = 1.2!
        Me.line9.Y2 = 1.65!
        '
        'line10
        '
        Me.line10.Height = 0.6!
        Me.line10.Left = 6.65!
        Me.line10.LineWeight = 1.0!
        Me.line10.Name = "line10"
        Me.line10.Top = 1.05!
        Me.line10.Width = 0.0!
        Me.line10.X1 = 6.65!
        Me.line10.X2 = 6.65!
        Me.line10.Y1 = 1.05!
        Me.line10.Y2 = 1.65!
        '
        'line11
        '
        Me.line11.Height = 0.4499999!
        Me.line11.Left = 7.1!
        Me.line11.LineWeight = 1.0!
        Me.line11.Name = "line11"
        Me.line11.Top = 1.2!
        Me.line11.Width = 0.0!
        Me.line11.X1 = 7.1!
        Me.line11.X2 = 7.1!
        Me.line11.Y1 = 1.2!
        Me.line11.Y2 = 1.65!
        '
        'line12
        '
        Me.line12.Height = 0.4499999!
        Me.line12.Left = 8.0!
        Me.line12.LineWeight = 1.0!
        Me.line12.Name = "line12"
        Me.line12.Top = 1.2!
        Me.line12.Width = 0.0!
        Me.line12.X1 = 8.0!
        Me.line12.X2 = 8.0!
        Me.line12.Y1 = 1.2!
        Me.line12.Y2 = 1.65!
        '
        'line14
        '
        Me.line14.Height = 0.4499999!
        Me.line14.Left = 8.4!
        Me.line14.LineWeight = 1.0!
        Me.line14.Name = "line14"
        Me.line14.Top = 1.2!
        Me.line14.Width = 0.0!
        Me.line14.X1 = 8.4!
        Me.line14.X2 = 8.4!
        Me.line14.Y1 = 1.2!
        Me.line14.Y2 = 1.65!
        '
        'line15
        '
        Me.line15.Height = 0.6!
        Me.line15.Left = 11.45!
        Me.line15.LineWeight = 1.0!
        Me.line15.Name = "line15"
        Me.line15.Top = 1.05!
        Me.line15.Width = 0.0!
        Me.line15.X1 = 11.45!
        Me.line15.X2 = 11.45!
        Me.line15.Y1 = 1.05!
        Me.line15.Y2 = 1.65!
        '
        'line16
        '
        Me.line16.Height = 0.0!
        Me.line16.Left = 4.42!
        Me.line16.LineWeight = 1.0!
        Me.line16.Name = "line16"
        Me.line16.Top = 1.65!
        Me.line16.Width = 2.18!
        Me.line16.X1 = 4.42!
        Me.line16.X2 = 6.6!
        Me.line16.Y1 = 1.65!
        Me.line16.Y2 = 1.65!
        '
        'line17
        '
        Me.line17.Height = 0.0!
        Me.line17.Left = 4.42!
        Me.line17.LineWeight = 1.0!
        Me.line17.Name = "line17"
        Me.line17.Top = 1.2!
        Me.line17.Width = 2.18!
        Me.line17.X1 = 4.42!
        Me.line17.X2 = 6.6!
        Me.line17.Y1 = 1.2!
        Me.line17.Y2 = 1.2!
        '
        'line18
        '
        Me.line18.Height = 0.0!
        Me.line18.Left = 4.42!
        Me.line18.LineWeight = 1.0!
        Me.line18.Name = "line18"
        Me.line18.Top = 1.05!
        Me.line18.Width = 2.18!
        Me.line18.X1 = 4.42!
        Me.line18.X2 = 6.6!
        Me.line18.Y1 = 1.05!
        Me.line18.Y2 = 1.05!
        '
        'line22
        '
        Me.line22.Height = 0.0!
        Me.line22.Left = 6.65!
        Me.line22.LineWeight = 1.0!
        Me.line22.Name = "line22"
        Me.line22.Top = 1.65!
        Me.line22.Width = 4.8!
        Me.line22.X1 = 6.65!
        Me.line22.X2 = 11.45!
        Me.line22.Y1 = 1.65!
        Me.line22.Y2 = 1.65!
        '
        'line25
        '
        Me.line25.Height = 0.4499999!
        Me.line25.Left = 8.88!
        Me.line25.LineWeight = 1.0!
        Me.line25.Name = "line25"
        Me.line25.Top = 1.2!
        Me.line25.Width = 0.0!
        Me.line25.X1 = 8.88!
        Me.line25.X2 = 8.88!
        Me.line25.Y1 = 1.2!
        Me.line25.Y2 = 1.65!
        '
        'line29
        '
        Me.line29.Height = 0.0!
        Me.line29.Left = 6.65!
        Me.line29.LineWeight = 1.0!
        Me.line29.Name = "line29"
        Me.line29.Top = 1.2!
        Me.line29.Width = 4.8!
        Me.line29.X1 = 6.65!
        Me.line29.X2 = 11.45!
        Me.line29.Y1 = 1.2!
        Me.line29.Y2 = 1.2!
        '
        'line30
        '
        Me.line30.Height = 0.0!
        Me.line30.Left = 6.65!
        Me.line30.LineWeight = 1.0!
        Me.line30.Name = "line30"
        Me.line30.Top = 1.05!
        Me.line30.Width = 4.8!
        Me.line30.X1 = 6.65!
        Me.line30.X2 = 11.45!
        Me.line30.Y1 = 1.05!
        Me.line30.Y2 = 1.05!
        '
        'line36
        '
        Me.line36.Height = 0.4499999!
        Me.line36.Left = 11.05!
        Me.line36.LineWeight = 1.0!
        Me.line36.Name = "line36"
        Me.line36.Top = 1.2!
        Me.line36.Width = 0.0!
        Me.line36.X1 = 11.05!
        Me.line36.X2 = 11.05!
        Me.line36.Y1 = 1.2!
        Me.line36.Y2 = 1.65!
        '
        'line37
        '
        Me.line37.Height = 0.4499999!
        Me.line37.Left = 10.65!
        Me.line37.LineWeight = 1.0!
        Me.line37.Name = "line37"
        Me.line37.Top = 1.2!
        Me.line37.Width = 0.0!
        Me.line37.X1 = 10.65!
        Me.line37.X2 = 10.65!
        Me.line37.Y1 = 1.2!
        Me.line37.Y2 = 1.65!
        '
        'line38
        '
        Me.line38.Height = 0.4499999!
        Me.line38.Left = 10.25!
        Me.line38.LineWeight = 1.0!
        Me.line38.Name = "line38"
        Me.line38.Top = 1.2!
        Me.line38.Width = 0.0!
        Me.line38.X1 = 10.25!
        Me.line38.X2 = 10.25!
        Me.line38.Y1 = 1.2!
        Me.line38.Y2 = 1.65!
        '
        'line39
        '
        Me.line39.Height = 0.4499999!
        Me.line39.Left = 9.85!
        Me.line39.LineWeight = 1.0!
        Me.line39.Name = "line39"
        Me.line39.Top = 1.2!
        Me.line39.Width = 0.0!
        Me.line39.X1 = 9.85!
        Me.line39.X2 = 9.85!
        Me.line39.Y1 = 1.2!
        Me.line39.Y2 = 1.65!
        '
        'line40
        '
        Me.line40.Height = 0.4499999!
        Me.line40.Left = 9.3!
        Me.line40.LineWeight = 1.0!
        Me.line40.Name = "line40"
        Me.line40.Top = 1.2!
        Me.line40.Width = 0.0!
        Me.line40.X1 = 9.3!
        Me.line40.X2 = 9.3!
        Me.line40.Y1 = 1.2!
        Me.line40.Y2 = 1.65!
        '
        'line6
        '
        Me.line6.Height = 0.3!
        Me.line6.Left = 5.7!
        Me.line6.LineWeight = 1.0!
        Me.line6.Name = "line6"
        Me.line6.Top = 1.35!
        Me.line6.Width = 0.0!
        Me.line6.X1 = 5.7!
        Me.line6.X2 = 5.7!
        Me.line6.Y1 = 1.35!
        Me.line6.Y2 = 1.65!
        '
        'line19
        '
        Me.line19.Height = 0.3!
        Me.line19.Left = 4.8!
        Me.line19.LineWeight = 1.0!
        Me.line19.Name = "line19"
        Me.line19.Top = 1.35!
        Me.line19.Width = 0.0!
        Me.line19.X1 = 4.8!
        Me.line19.X2 = 4.8!
        Me.line19.Y1 = 1.35!
        Me.line19.Y2 = 1.65!
        '
        'line20
        '
        Me.line20.Height = 0.6!
        Me.line20.Left = 6.6!
        Me.line20.LineWeight = 1.0!
        Me.line20.Name = "line20"
        Me.line20.Top = 1.05!
        Me.line20.Width = 0.0!
        Me.line20.X1 = 6.6!
        Me.line20.X2 = 6.6!
        Me.line20.Y1 = 1.05!
        Me.line20.Y2 = 1.65!
        '
        'line66
        '
        Me.line66.Height = 0.3!
        Me.line66.Left = 5.23!
        Me.line66.LineWeight = 1.0!
        Me.line66.Name = "line66"
        Me.line66.Top = 1.35!
        Me.line66.Width = 0.0!
        Me.line66.X1 = 5.23!
        Me.line66.X2 = 5.23!
        Me.line66.Y1 = 1.35!
        Me.line66.Y2 = 1.65!
        '
        'line69
        '
        Me.line69.Height = 0.4499999!
        Me.line69.Left = 6.2!
        Me.line69.LineWeight = 1.0!
        Me.line69.Name = "line69"
        Me.line69.Top = 1.2!
        Me.line69.Width = 0.0!
        Me.line69.X1 = 6.2!
        Me.line69.X2 = 6.2!
        Me.line69.Y1 = 1.2!
        Me.line69.Y2 = 1.65!
        '
        'line23
        '
        Me.line23.Height = 0.0!
        Me.line23.Left = 4.42!
        Me.line23.LineWeight = 1.0!
        Me.line23.Name = "line23"
        Me.line23.Top = 1.35!
        Me.line23.Width = 2.18!
        Me.line23.X1 = 4.42!
        Me.line23.X2 = 6.6!
        Me.line23.Y1 = 1.35!
        Me.line23.Y2 = 1.35!
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtFireHosesInspC, Me.txtPFEMountedC, Me.txtPFEAppTypeSizeC, Me.txtPFEServAnnC, Me.txtPFEInspMonthlyC, Me.txtNoStorageInElecRmC, Me.txtBarricadeProvidedC, Me.txtNoMissCealTilesC, Me.txtFireDoorsNotObstrC, Me.txtPropStorageC, Me.txtNoSmokingC, Me.txtPropCylindersC, Me.txt16SeparationC, Me.txtFlamLiqStoredC, Me.txtHotWorkPermitC, Me.txtPlasSkidsC, Me.txtHotWorkPermit, Me.txtFlamLiqStored, Me.txt16Separation, Me.txtPropCylinders, Me.txtNoSmoking, Me.txtAddress, Me.txtDivision2, Me.txtFileNo, Me.txtSurveyDate, Me.txtCity, Me.txtSTProv, Me.txtCountry, Me.txtTIV, Me.txtPropStorage, Me.txtFireDoorsNotObstr, Me.txtNoMissCealTiles, Me.txtBarricadeProvided, Me.txtNoStorageInElecRm, Me.txtPlasSkids, Me.txtFacility, Me.txtClientLocNo, Me.line49, Me.line50, Me.line51, Me.line52, Me.line53, Me.line54, Me.line55, Me.line56, Me.line57, Me.line59, Me.line60, Me.line61, Me.line62, Me.line63, Me.line64, Me.line65, Me.line67, Me.line71, Me.line72, Me.txtPFEInspMonthly, Me.txtPFEServAnn, Me.txtPFEAppTypeSize, Me.txtPFEMounted, Me.txtFireHosesInsp, Me.line73, Me.line74, Me.line78, Me.line80, Me.line81, Me.line83, Me.line84, Me.line85, Me.line86, Me.line87, Me.line88})
        Me.Detail1.Height = 0.363!
        Me.Detail1.KeepTogether = True
        Me.Detail1.Name = "Detail1"
        '
        'txtFireHosesInspC
        '
        Me.txtFireHosesInspC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtFireHosesInspC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtFireHosesInspC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtFireHosesInspC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtFireHosesInspC.DataField = "FireHosesInspC"
        Me.txtFireHosesInspC.Height = 0.1250001!
        Me.txtFireHosesInspC.Left = 6.279994!
        Me.txtFireHosesInspC.Name = "txtFireHosesInspC"
        Me.txtFireHosesInspC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtFireHosesInspC.Text = "FireHosesInspC"
        Me.txtFireHosesInspC.Top = 0.125!
        Me.txtFireHosesInspC.Visible = False
        Me.txtFireHosesInspC.Width = 0.2399945!
        '
        'txtPFEMountedC
        '
        Me.txtPFEMountedC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPFEMountedC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPFEMountedC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPFEMountedC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPFEMountedC.DataField = "PFEMountedC"
        Me.txtPFEMountedC.Height = 0.1250001!
        Me.txtPFEMountedC.Left = 5.779994!
        Me.txtPFEMountedC.Name = "txtPFEMountedC"
        Me.txtPFEMountedC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtPFEMountedC.Text = "PFEMountedC"
        Me.txtPFEMountedC.Top = 0.125!
        Me.txtPFEMountedC.Visible = False
        Me.txtPFEMountedC.Width = 0.3399944!
        '
        'txtPFEAppTypeSizeC
        '
        Me.txtPFEAppTypeSizeC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPFEAppTypeSizeC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPFEAppTypeSizeC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPFEAppTypeSizeC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPFEAppTypeSizeC.DataField = "PFEAppTypeSizeC"
        Me.txtPFEAppTypeSizeC.Height = 0.1250001!
        Me.txtPFEAppTypeSizeC.Left = 5.309994!
        Me.txtPFEAppTypeSizeC.Name = "txtPFEAppTypeSizeC"
        Me.txtPFEAppTypeSizeC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtPFEAppTypeSizeC.Text = "PFEAppTypeSizeC"
        Me.txtPFEAppTypeSizeC.Top = 0.125!
        Me.txtPFEAppTypeSizeC.Visible = False
        Me.txtPFEAppTypeSizeC.Width = 0.3099942!
        '
        'txtPFEServAnnC
        '
        Me.txtPFEServAnnC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPFEServAnnC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPFEServAnnC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPFEServAnnC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPFEServAnnC.DataField = "PFEServAnnC"
        Me.txtPFEServAnnC.Height = 0.1250001!
        Me.txtPFEServAnnC.Left = 4.879994!
        Me.txtPFEServAnnC.Name = "txtPFEServAnnC"
        Me.txtPFEServAnnC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtPFEServAnnC.Text = "PFEServAnnC"
        Me.txtPFEServAnnC.Top = 0.125!
        Me.txtPFEServAnnC.Visible = False
        Me.txtPFEServAnnC.Width = 0.2699943!
        '
        'txtPFEInspMonthlyC
        '
        Me.txtPFEInspMonthlyC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPFEInspMonthlyC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPFEInspMonthlyC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPFEInspMonthlyC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPFEInspMonthlyC.DataField = "PFEInspMonthlyC"
        Me.txtPFEInspMonthlyC.Height = 0.1250001!
        Me.txtPFEInspMonthlyC.Left = 4.499993!
        Me.txtPFEInspMonthlyC.Name = "txtPFEInspMonthlyC"
        Me.txtPFEInspMonthlyC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtPFEInspMonthlyC.Text = "PFEInspMonthlyC"
        Me.txtPFEInspMonthlyC.Top = 0.125!
        Me.txtPFEInspMonthlyC.Visible = False
        Me.txtPFEInspMonthlyC.Width = 0.2199945!
        '
        'txtNoStorageInElecRmC
        '
        Me.txtNoStorageInElecRmC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtNoStorageInElecRmC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtNoStorageInElecRmC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtNoStorageInElecRmC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtNoStorageInElecRmC.DataField = "NoStorageInElecRmC"
        Me.txtNoStorageInElecRmC.Height = 0.1250001!
        Me.txtNoStorageInElecRmC.Left = 10.73!
        Me.txtNoStorageInElecRmC.Name = "txtNoStorageInElecRmC"
        Me.txtNoStorageInElecRmC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtNoStorageInElecRmC.Text = "NoStorageInElecRmC"
        Me.txtNoStorageInElecRmC.Top = 0.125!
        Me.txtNoStorageInElecRmC.Visible = False
        Me.txtNoStorageInElecRmC.Width = 0.239994!
        '
        'txtBarricadeProvidedC
        '
        Me.txtBarricadeProvidedC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtBarricadeProvidedC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtBarricadeProvidedC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtBarricadeProvidedC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtBarricadeProvidedC.DataField = "BarricadeProvidedC"
        Me.txtBarricadeProvidedC.Height = 0.1250001!
        Me.txtBarricadeProvidedC.Left = 10.33!
        Me.txtBarricadeProvidedC.Name = "txtBarricadeProvidedC"
        Me.txtBarricadeProvidedC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtBarricadeProvidedC.Text = "BarricadeProvidedC"
        Me.txtBarricadeProvidedC.Top = 0.125!
        Me.txtBarricadeProvidedC.Visible = False
        Me.txtBarricadeProvidedC.Width = 0.239994!
        '
        'txtNoMissCealTilesC
        '
        Me.txtNoMissCealTilesC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtNoMissCealTilesC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtNoMissCealTilesC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtNoMissCealTilesC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtNoMissCealTilesC.DataField = "NoMissCealTilesC"
        Me.txtNoMissCealTilesC.Height = 0.1250001!
        Me.txtNoMissCealTilesC.Left = 9.930001!
        Me.txtNoMissCealTilesC.Name = "txtNoMissCealTilesC"
        Me.txtNoMissCealTilesC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtNoMissCealTilesC.Text = "NoMissCealTilesC"
        Me.txtNoMissCealTilesC.Top = 0.125!
        Me.txtNoMissCealTilesC.Visible = False
        Me.txtNoMissCealTilesC.Width = 0.239994!
        '
        'txtFireDoorsNotObstrC
        '
        Me.txtFireDoorsNotObstrC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtFireDoorsNotObstrC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtFireDoorsNotObstrC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtFireDoorsNotObstrC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtFireDoorsNotObstrC.DataField = "FireDoorsNotObstrC"
        Me.txtFireDoorsNotObstrC.Height = 0.1250001!
        Me.txtFireDoorsNotObstrC.Left = 9.379998!
        Me.txtFireDoorsNotObstrC.Name = "txtFireDoorsNotObstrC"
        Me.txtFireDoorsNotObstrC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtFireDoorsNotObstrC.Text = "FireDoorsNotObstrC"
        Me.txtFireDoorsNotObstrC.Top = 0.125!
        Me.txtFireDoorsNotObstrC.Visible = False
        Me.txtFireDoorsNotObstrC.Width = 0.3899946!
        '
        'txtPropStorageC
        '
        Me.txtPropStorageC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPropStorageC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPropStorageC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPropStorageC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPropStorageC.DataField = "PropStorageC"
        Me.txtPropStorageC.Height = 0.1250001!
        Me.txtPropStorageC.Left = 8.479995!
        Me.txtPropStorageC.Name = "txtPropStorageC"
        Me.txtPropStorageC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtPropStorageC.Text = "PropStorageC"
        Me.txtPropStorageC.Top = 0.125!
        Me.txtPropStorageC.Visible = False
        Me.txtPropStorageC.Width = 0.3199949!
        '
        'txtNoSmokingC
        '
        Me.txtNoSmokingC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtNoSmokingC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtNoSmokingC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtNoSmokingC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtNoSmokingC.DataField = "NoSmokingC"
        Me.txtNoSmokingC.Height = 0.1250001!
        Me.txtNoSmokingC.Left = 8.959998!
        Me.txtNoSmokingC.Name = "txtNoSmokingC"
        Me.txtNoSmokingC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtNoSmokingC.Text = "NoSmokingC"
        Me.txtNoSmokingC.Top = 0.125!
        Me.txtNoSmokingC.Visible = False
        Me.txtNoSmokingC.Width = 0.2599945!
        '
        'txtPropCylindersC
        '
        Me.txtPropCylindersC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPropCylindersC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPropCylindersC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPropCylindersC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPropCylindersC.DataField = "PropCylindersC"
        Me.txtPropCylindersC.Height = 0.1250001!
        Me.txtPropCylindersC.Left = 8.079995!
        Me.txtPropCylindersC.Name = "txtPropCylindersC"
        Me.txtPropCylindersC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtPropCylindersC.Text = "PropCylindersC"
        Me.txtPropCylindersC.Top = 0.125!
        Me.txtPropCylindersC.Visible = False
        Me.txtPropCylindersC.Width = 0.2399945!
        '
        'txt16SeparationC
        '
        Me.txt16SeparationC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt16SeparationC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt16SeparationC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt16SeparationC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt16SeparationC.DataField = "SixteenSeparationC"
        Me.txt16SeparationC.Height = 0.1250001!
        Me.txt16SeparationC.Left = 7.579996!
        Me.txt16SeparationC.Name = "txt16SeparationC"
        Me.txt16SeparationC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txt16SeparationC.Text = "SixteenSeparationC"
        Me.txt16SeparationC.Top = 0.125!
        Me.txt16SeparationC.Visible = False
        Me.txt16SeparationC.Width = 0.3399944!
        '
        'txtFlamLiqStoredC
        '
        Me.txtFlamLiqStoredC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtFlamLiqStoredC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtFlamLiqStoredC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtFlamLiqStoredC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtFlamLiqStoredC.DataField = "FlamLiqStoredC"
        Me.txtFlamLiqStoredC.Height = 0.1250001!
        Me.txtFlamLiqStoredC.Left = 7.179995!
        Me.txtFlamLiqStoredC.Name = "txtFlamLiqStoredC"
        Me.txtFlamLiqStoredC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtFlamLiqStoredC.Text = "FlamLiqStoredC"
        Me.txtFlamLiqStoredC.Top = 0.125!
        Me.txtFlamLiqStoredC.Visible = False
        Me.txtFlamLiqStoredC.Width = 0.2399945!
        '
        'txtHotWorkPermitC
        '
        Me.txtHotWorkPermitC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtHotWorkPermitC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtHotWorkPermitC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtHotWorkPermitC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtHotWorkPermitC.DataField = "HotWorkPermitC"
        Me.txtHotWorkPermitC.Height = 0.1250001!
        Me.txtHotWorkPermitC.Left = 6.729995!
        Me.txtHotWorkPermitC.Name = "txtHotWorkPermitC"
        Me.txtHotWorkPermitC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtHotWorkPermitC.Text = "HotWorkPermitC"
        Me.txtHotWorkPermitC.Top = 0.125!
        Me.txtHotWorkPermitC.Visible = False
        Me.txtHotWorkPermitC.Width = 0.2899942!
        '
        'txtPlasSkidsC
        '
        Me.txtPlasSkidsC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPlasSkidsC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPlasSkidsC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPlasSkidsC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPlasSkidsC.DataField = "PlasSkidsC"
        Me.txtPlasSkidsC.Height = 0.1250001!
        Me.txtPlasSkidsC.Left = 11.13!
        Me.txtPlasSkidsC.Name = "txtPlasSkidsC"
        Me.txtPlasSkidsC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtPlasSkidsC.Text = "PlasSkidsC"
        Me.txtPlasSkidsC.Top = 0.125!
        Me.txtPlasSkidsC.Visible = False
        Me.txtPlasSkidsC.Width = 0.239994!
        '
        'txtHotWorkPermit
        '
        Me.txtHotWorkPermit.DataField = "HotWorkPermit"
        Me.txtHotWorkPermit.Height = 0.3!
        Me.txtHotWorkPermit.Left = 6.65!
        Me.txtHotWorkPermit.Name = "txtHotWorkPermit"
        Me.txtHotWorkPermit.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtHotWorkPermit.Text = "HotWorkPermit"
        Me.txtHotWorkPermit.Top = 0.05!
        Me.txtHotWorkPermit.Width = 0.45!
        '
        'txtFlamLiqStored
        '
        Me.txtFlamLiqStored.DataField = "FlamLiqStored"
        Me.txtFlamLiqStored.Height = 0.3!
        Me.txtFlamLiqStored.Left = 7.1!
        Me.txtFlamLiqStored.Name = "txtFlamLiqStored"
        Me.txtFlamLiqStored.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtFlamLiqStored.Text = "FlamLiqStored"
        Me.txtFlamLiqStored.Top = 0.05!
        Me.txtFlamLiqStored.Width = 0.4!
        '
        'txt16Separation
        '
        Me.txt16Separation.DataField = "SixteenSeparation"
        Me.txt16Separation.Height = 0.3!
        Me.txt16Separation.Left = 7.5!
        Me.txt16Separation.Name = "txt16Separation"
        Me.txt16Separation.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txt16Separation.Text = "SixteenSeparation"
        Me.txt16Separation.Top = 0.05!
        Me.txt16Separation.Width = 0.5!
        '
        'txtPropCylinders
        '
        Me.txtPropCylinders.DataField = "PropCylinders"
        Me.txtPropCylinders.Height = 0.3!
        Me.txtPropCylinders.Left = 8.0!
        Me.txtPropCylinders.Name = "txtPropCylinders"
        Me.txtPropCylinders.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtPropCylinders.Text = "PropCylinders"
        Me.txtPropCylinders.Top = 0.05!
        Me.txtPropCylinders.Width = 0.4!
        '
        'txtNoSmoking
        '
        Me.txtNoSmoking.DataField = "NoSmoking"
        Me.txtNoSmoking.Height = 0.3!
        Me.txtNoSmoking.Left = 8.88!
        Me.txtNoSmoking.Name = "txtNoSmoking"
        Me.txtNoSmoking.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtNoSmoking.Text = "NoSmoking"
        Me.txtNoSmoking.Top = 0.05!
        Me.txtNoSmoking.Width = 0.42!
        '
        'txtAddress
        '
        Me.txtAddress.CanGrow = False
        Me.txtAddress.DataField = "Address"
        Me.txtAddress.Height = 0.15!
        Me.txtAddress.Left = 1.9!
        Me.txtAddress.MultiLine = False
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.txtAddress.Text = "Address"
        Me.txtAddress.Top = 0.2!
        Me.txtAddress.Width = 2.47!
        '
        'txtDivision2
        '
        Me.txtDivision2.CanGrow = False
        Me.txtDivision2.DataField = "Division"
        Me.txtDivision2.Height = 0.15!
        Me.txtDivision2.Left = 0.0!
        Me.txtDivision2.MultiLine = False
        Me.txtDivision2.Name = "txtDivision2"
        Me.txtDivision2.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.txtDivision2.Text = "Division"
        Me.txtDivision2.Top = 0.2!
        Me.txtDivision2.Width = 1.1!
        '
        'txtFileNo
        '
        Me.txtFileNo.CanGrow = False
        Me.txtFileNo.DataField = "FileNo"
        Me.txtFileNo.Height = 0.15!
        Me.txtFileNo.Left = 0.0!
        Me.txtFileNo.MultiLine = False
        Me.txtFileNo.Name = "txtFileNo"
        Me.txtFileNo.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.txtFileNo.Text = "File No."
        Me.txtFileNo.Top = 0.05!
        Me.txtFileNo.Width = 0.52!
        '
        'txtSurveyDate
        '
        Me.txtSurveyDate.CanGrow = False
        Me.txtSurveyDate.DataField = "SurveyDateString"
        Me.txtSurveyDate.Height = 0.15!
        Me.txtSurveyDate.Left = 0.52!
        Me.txtSurveyDate.MultiLine = False
        Me.txtSurveyDate.Name = "txtSurveyDate"
        Me.txtSurveyDate.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.txtSurveyDate.Text = "Survey Date"
        Me.txtSurveyDate.Top = 0.05!
        Me.txtSurveyDate.Width = 0.58!
        '
        'txtCity
        '
        Me.txtCity.CanGrow = False
        Me.txtCity.DataField = "City"
        Me.txtCity.Height = 0.15!
        Me.txtCity.Left = 1.9!
        Me.txtCity.MultiLine = False
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.txtCity.Text = "City"
        Me.txtCity.Top = 0.05!
        Me.txtCity.Width = 0.95!
        '
        'txtSTProv
        '
        Me.txtSTProv.CanGrow = False
        Me.txtSTProv.DataField = "StProv"
        Me.txtSTProv.Height = 0.15!
        Me.txtSTProv.Left = 2.85!
        Me.txtSTProv.MultiLine = False
        Me.txtSTProv.Name = "txtSTProv"
        Me.txtSTProv.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.txtSTProv.Text = "St/Pr"
        Me.txtSTProv.Top = 0.05!
        Me.txtSTProv.Width = 0.35!
        '
        'txtCountry
        '
        Me.txtCountry.CanGrow = False
        Me.txtCountry.DataField = "Country"
        Me.txtCountry.Height = 0.15!
        Me.txtCountry.Left = 3.2!
        Me.txtCountry.MultiLine = False
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.txtCountry.Text = "Country"
        Me.txtCountry.Top = 0.05!
        Me.txtCountry.Width = 0.75!
        '
        'txtTIV
        '
        Me.txtTIV.CanGrow = False
        Me.txtTIV.DataField = "TIV"
        Me.txtTIV.Height = 0.15!
        Me.txtTIV.Left = 3.95!
        Me.txtTIV.MultiLine = False
        Me.txtTIV.Name = "txtTIV"
        Me.txtTIV.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtTIV.Text = "TIV"
        Me.txtTIV.Top = 0.05!
        Me.txtTIV.Width = 0.42!
        '
        'txtPropStorage
        '
        Me.txtPropStorage.DataField = "PropStorage"
        Me.txtPropStorage.Height = 0.3!
        Me.txtPropStorage.Left = 8.4!
        Me.txtPropStorage.Name = "txtPropStorage"
        Me.txtPropStorage.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtPropStorage.Text = "PropStorage"
        Me.txtPropStorage.Top = 0.05!
        Me.txtPropStorage.Width = 0.48!
        '
        'txtFireDoorsNotObstr
        '
        Me.txtFireDoorsNotObstr.DataField = "FireDoorsNotObstr"
        Me.txtFireDoorsNotObstr.Height = 0.3!
        Me.txtFireDoorsNotObstr.Left = 9.3!
        Me.txtFireDoorsNotObstr.Name = "txtFireDoorsNotObstr"
        Me.txtFireDoorsNotObstr.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtFireDoorsNotObstr.Text = "FireDoorsNotObstr"
        Me.txtFireDoorsNotObstr.Top = 0.05!
        Me.txtFireDoorsNotObstr.Width = 0.55!
        '
        'txtNoMissCealTiles
        '
        Me.txtNoMissCealTiles.DataField = "NoMissCealTiles"
        Me.txtNoMissCealTiles.Height = 0.3!
        Me.txtNoMissCealTiles.Left = 9.85!
        Me.txtNoMissCealTiles.Name = "txtNoMissCealTiles"
        Me.txtNoMissCealTiles.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtNoMissCealTiles.Text = "NoMissCealTiles"
        Me.txtNoMissCealTiles.Top = 0.05!
        Me.txtNoMissCealTiles.Width = 0.4!
        '
        'txtBarricadeProvided
        '
        Me.txtBarricadeProvided.DataField = "BarricadeProvided"
        Me.txtBarricadeProvided.Height = 0.3!
        Me.txtBarricadeProvided.Left = 10.25!
        Me.txtBarricadeProvided.Name = "txtBarricadeProvided"
        Me.txtBarricadeProvided.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtBarricadeProvided.Text = "BarricadeProvided"
        Me.txtBarricadeProvided.Top = 0.05!
        Me.txtBarricadeProvided.Width = 0.4!
        '
        'txtNoStorageInElecRm
        '
        Me.txtNoStorageInElecRm.DataField = "NoStorageInElecRm"
        Me.txtNoStorageInElecRm.Height = 0.3!
        Me.txtNoStorageInElecRm.Left = 10.65!
        Me.txtNoStorageInElecRm.Name = "txtNoStorageInElecRm"
        Me.txtNoStorageInElecRm.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtNoStorageInElecRm.Text = "NoStorageInElecRm"
        Me.txtNoStorageInElecRm.Top = 0.05!
        Me.txtNoStorageInElecRm.Width = 0.4!
        '
        'txtPlasSkids
        '
        Me.txtPlasSkids.DataField = "PlasSkids"
        Me.txtPlasSkids.Height = 0.3!
        Me.txtPlasSkids.Left = 11.05!
        Me.txtPlasSkids.Name = "txtPlasSkids"
        Me.txtPlasSkids.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtPlasSkids.Text = "PlasSkids"
        Me.txtPlasSkids.Top = 0.05!
        Me.txtPlasSkids.Width = 0.4!
        '
        'txtFacility
        '
        Me.txtFacility.CanGrow = False
        Me.txtFacility.DataField = "Facility"
        Me.txtFacility.Height = 0.15!
        Me.txtFacility.Left = 1.1!
        Me.txtFacility.MultiLine = False
        Me.txtFacility.Name = "txtFacility"
        Me.txtFacility.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.txtFacility.Text = "Facility"
        Me.txtFacility.Top = 0.2!
        Me.txtFacility.Width = 0.8!
        '
        'txtClientLocNo
        '
        Me.txtClientLocNo.CanGrow = False
        Me.txtClientLocNo.DataField = "ClientLocNo"
        Me.txtClientLocNo.Height = 0.15!
        Me.txtClientLocNo.Left = 1.1!
        Me.txtClientLocNo.MultiLine = False
        Me.txtClientLocNo.Name = "txtClientLocNo"
        Me.txtClientLocNo.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.txtClientLocNo.Text = "Client Loc. No"
        Me.txtClientLocNo.Top = 0.05!
        Me.txtClientLocNo.Width = 0.8!
        '
        'line49
        '
        Me.line49.Height = 0.3!
        Me.line49.Left = 11.45!
        Me.line49.LineWeight = 1.0!
        Me.line49.Name = "line49"
        Me.line49.Top = 0.05!
        Me.line49.Width = 0.0!
        Me.line49.X1 = 11.45!
        Me.line49.X2 = 11.45!
        Me.line49.Y1 = 0.05!
        Me.line49.Y2 = 0.35!
        '
        'line50
        '
        Me.line50.Height = 0.3!
        Me.line50.Left = 9.3!
        Me.line50.LineWeight = 1.0!
        Me.line50.Name = "line50"
        Me.line50.Top = 0.05!
        Me.line50.Width = 0.0!
        Me.line50.X1 = 9.3!
        Me.line50.X2 = 9.3!
        Me.line50.Y1 = 0.05!
        Me.line50.Y2 = 0.35!
        '
        'line51
        '
        Me.line51.Height = 0.3!
        Me.line51.Left = 10.25!
        Me.line51.LineWeight = 1.0!
        Me.line51.Name = "line51"
        Me.line51.Top = 0.05!
        Me.line51.Width = 0.0!
        Me.line51.X1 = 10.25!
        Me.line51.X2 = 10.25!
        Me.line51.Y1 = 0.05!
        Me.line51.Y2 = 0.35!
        '
        'line52
        '
        Me.line52.Height = 0.3!
        Me.line52.Left = 10.65!
        Me.line52.LineWeight = 1.0!
        Me.line52.Name = "line52"
        Me.line52.Top = 0.05!
        Me.line52.Width = 0.0!
        Me.line52.X1 = 10.65!
        Me.line52.X2 = 10.65!
        Me.line52.Y1 = 0.05!
        Me.line52.Y2 = 0.35!
        '
        'line53
        '
        Me.line53.Height = 0.3!
        Me.line53.Left = 11.05!
        Me.line53.LineWeight = 1.0!
        Me.line53.Name = "line53"
        Me.line53.Top = 0.05!
        Me.line53.Width = 0.0!
        Me.line53.X1 = 11.05!
        Me.line53.X2 = 11.05!
        Me.line53.Y1 = 0.05!
        Me.line53.Y2 = 0.35!
        '
        'line54
        '
        Me.line54.Height = 0.3!
        Me.line54.Left = 9.85!
        Me.line54.LineWeight = 1.0!
        Me.line54.Name = "line54"
        Me.line54.Top = 0.05!
        Me.line54.Width = 0.0!
        Me.line54.X1 = 9.85!
        Me.line54.X2 = 9.85!
        Me.line54.Y1 = 0.05!
        Me.line54.Y2 = 0.35!
        '
        'line55
        '
        Me.line55.Height = 0.3!
        Me.line55.Left = 8.4!
        Me.line55.LineWeight = 1.0!
        Me.line55.Name = "line55"
        Me.line55.Top = 0.05!
        Me.line55.Width = 0.0!
        Me.line55.X1 = 8.4!
        Me.line55.X2 = 8.4!
        Me.line55.Y1 = 0.05!
        Me.line55.Y2 = 0.35!
        '
        'line56
        '
        Me.line56.Height = 0.3!
        Me.line56.Left = 8.88!
        Me.line56.LineWeight = 1.0!
        Me.line56.Name = "line56"
        Me.line56.Top = 0.05!
        Me.line56.Width = 0.0!
        Me.line56.X1 = 8.88!
        Me.line56.X2 = 8.88!
        Me.line56.Y1 = 0.05!
        Me.line56.Y2 = 0.35!
        '
        'line57
        '
        Me.line57.Height = 0.3!
        Me.line57.Left = 7.5!
        Me.line57.LineWeight = 1.0!
        Me.line57.Name = "line57"
        Me.line57.Top = 0.05!
        Me.line57.Width = 0.0!
        Me.line57.X1 = 7.5!
        Me.line57.X2 = 7.5!
        Me.line57.Y1 = 0.05!
        Me.line57.Y2 = 0.35!
        '
        'line59
        '
        Me.line59.Height = 0.3!
        Me.line59.Left = 6.2!
        Me.line59.LineWeight = 1.0!
        Me.line59.Name = "line59"
        Me.line59.Top = 0.05!
        Me.line59.Width = 0.0!
        Me.line59.X1 = 6.2!
        Me.line59.X2 = 6.2!
        Me.line59.Y1 = 0.05!
        Me.line59.Y2 = 0.35!
        '
        'line60
        '
        Me.line60.Height = 0.3!
        Me.line60.Left = 4.42!
        Me.line60.LineWeight = 1.0!
        Me.line60.Name = "line60"
        Me.line60.Top = 0.05!
        Me.line60.Width = 0.0!
        Me.line60.X1 = 4.42!
        Me.line60.X2 = 4.42!
        Me.line60.Y1 = 0.05!
        Me.line60.Y2 = 0.35!
        '
        'line61
        '
        Me.line61.Height = 0.3!
        Me.line61.Left = 4.37!
        Me.line61.LineWeight = 1.0!
        Me.line61.Name = "line61"
        Me.line61.Top = 0.05!
        Me.line61.Width = 0.0!
        Me.line61.X1 = 4.37!
        Me.line61.X2 = 4.37!
        Me.line61.Y1 = 0.05!
        Me.line61.Y2 = 0.35!
        '
        'line62
        '
        Me.line62.Height = 0.3!
        Me.line62.Left = 0.0!
        Me.line62.LineWeight = 1.0!
        Me.line62.Name = "line62"
        Me.line62.Top = 0.05!
        Me.line62.Width = 0.0!
        Me.line62.X1 = 0.0!
        Me.line62.X2 = 0.0!
        Me.line62.Y1 = 0.05!
        Me.line62.Y2 = 0.35!
        '
        'line63
        '
        Me.line63.Height = 0.0!
        Me.line63.Left = 0.0!
        Me.line63.LineWeight = 1.0!
        Me.line63.Name = "line63"
        Me.line63.Top = 0.05!
        Me.line63.Width = 4.37!
        Me.line63.X1 = 0.0!
        Me.line63.X2 = 4.37!
        Me.line63.Y1 = 0.05!
        Me.line63.Y2 = 0.05!
        '
        'line64
        '
        Me.line64.Height = 0.0!
        Me.line64.Left = 0.0!
        Me.line64.LineWeight = 1.0!
        Me.line64.Name = "line64"
        Me.line64.Top = 0.35!
        Me.line64.Width = 4.37!
        Me.line64.X1 = 0.0!
        Me.line64.X2 = 4.37!
        Me.line64.Y1 = 0.35!
        Me.line64.Y2 = 0.35!
        '
        'line65
        '
        Me.line65.Height = 0.0!
        Me.line65.Left = 4.42!
        Me.line65.LineWeight = 1.0!
        Me.line65.Name = "line65"
        Me.line65.Top = 0.05!
        Me.line65.Width = 1.78!
        Me.line65.X1 = 4.42!
        Me.line65.X2 = 6.2!
        Me.line65.Y1 = 0.05!
        Me.line65.Y2 = 0.05!
        '
        'line67
        '
        Me.line67.Height = 0.0!
        Me.line67.Left = 4.42!
        Me.line67.LineWeight = 1.0!
        Me.line67.Name = "line67"
        Me.line67.Top = 0.35!
        Me.line67.Width = 1.78!
        Me.line67.X1 = 4.42!
        Me.line67.X2 = 6.2!
        Me.line67.Y1 = 0.35!
        Me.line67.Y2 = 0.35!
        '
        'line71
        '
        Me.line71.Height = 0.0!
        Me.line71.Left = 6.65!
        Me.line71.LineWeight = 1.0!
        Me.line71.Name = "line71"
        Me.line71.Top = 0.05!
        Me.line71.Width = 4.8!
        Me.line71.X1 = 6.65!
        Me.line71.X2 = 11.45!
        Me.line71.Y1 = 0.05!
        Me.line71.Y2 = 0.05!
        '
        'line72
        '
        Me.line72.Height = 0.0!
        Me.line72.Left = 6.65!
        Me.line72.LineWeight = 1.0!
        Me.line72.Name = "line72"
        Me.line72.Top = 0.35!
        Me.line72.Width = 4.8!
        Me.line72.X1 = 6.65!
        Me.line72.X2 = 11.45!
        Me.line72.Y1 = 0.35!
        Me.line72.Y2 = 0.35!
        '
        'txtPFEInspMonthly
        '
        Me.txtPFEInspMonthly.DataField = "PFEInspMonthly"
        Me.txtPFEInspMonthly.Height = 0.3!
        Me.txtPFEInspMonthly.Left = 4.42!
        Me.txtPFEInspMonthly.Name = "txtPFEInspMonthly"
        Me.txtPFEInspMonthly.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtPFEInspMonthly.Text = "PFEInspMonthly"
        Me.txtPFEInspMonthly.Top = 0.05!
        Me.txtPFEInspMonthly.Width = 0.38!
        '
        'txtPFEServAnn
        '
        Me.txtPFEServAnn.DataField = "PFEServAnn"
        Me.txtPFEServAnn.Height = 0.3!
        Me.txtPFEServAnn.Left = 4.8!
        Me.txtPFEServAnn.Name = "txtPFEServAnn"
        Me.txtPFEServAnn.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtPFEServAnn.Text = "PFEServAnn"
        Me.txtPFEServAnn.Top = 0.05!
        Me.txtPFEServAnn.Width = 0.43!
        '
        'txtPFEAppTypeSize
        '
        Me.txtPFEAppTypeSize.DataField = "PFEAppTypeSize"
        Me.txtPFEAppTypeSize.Height = 0.3!
        Me.txtPFEAppTypeSize.Left = 5.23!
        Me.txtPFEAppTypeSize.Name = "txtPFEAppTypeSize"
        Me.txtPFEAppTypeSize.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtPFEAppTypeSize.Text = "PFEAppTypeSize"
        Me.txtPFEAppTypeSize.Top = 0.05!
        Me.txtPFEAppTypeSize.Width = 0.47!
        '
        'txtPFEMounted
        '
        Me.txtPFEMounted.DataField = "PFEMounted"
        Me.txtPFEMounted.Height = 0.3!
        Me.txtPFEMounted.Left = 5.7!
        Me.txtPFEMounted.Name = "txtPFEMounted"
        Me.txtPFEMounted.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtPFEMounted.Text = "PFEMounted"
        Me.txtPFEMounted.Top = 0.05!
        Me.txtPFEMounted.Width = 0.5!
        '
        'txtFireHosesInsp
        '
        Me.txtFireHosesInsp.DataField = "FireHosesInsp"
        Me.txtFireHosesInsp.Height = 0.3!
        Me.txtFireHosesInsp.Left = 6.2!
        Me.txtFireHosesInsp.Name = "txtFireHosesInsp"
        Me.txtFireHosesInsp.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtFireHosesInsp.Text = "FireHosesInsp"
        Me.txtFireHosesInsp.Top = 0.05!
        Me.txtFireHosesInsp.Width = 0.4!
        '
        'line73
        '
        Me.line73.Height = 0.3!
        Me.line73.Left = 8.0!
        Me.line73.LineWeight = 1.0!
        Me.line73.Name = "line73"
        Me.line73.Top = 0.05!
        Me.line73.Width = 0.0!
        Me.line73.X1 = 8.0!
        Me.line73.X2 = 8.0!
        Me.line73.Y1 = 0.05!
        Me.line73.Y2 = 0.35!
        '
        'line74
        '
        Me.line74.Height = 0.3!
        Me.line74.Left = 6.65!
        Me.line74.LineWeight = 1.0!
        Me.line74.Name = "line74"
        Me.line74.Top = 0.05!
        Me.line74.Width = 0.0!
        Me.line74.X1 = 6.65!
        Me.line74.X2 = 6.65!
        Me.line74.Y1 = 0.05!
        Me.line74.Y2 = 0.35!
        '
        'line78
        '
        Me.line78.Height = 0.3!
        Me.line78.Left = 6.6!
        Me.line78.LineWeight = 1.0!
        Me.line78.Name = "line78"
        Me.line78.Top = 0.05!
        Me.line78.Width = 0.0!
        Me.line78.X1 = 6.6!
        Me.line78.X2 = 6.6!
        Me.line78.Y1 = 0.05!
        Me.line78.Y2 = 0.35!
        '
        'line80
        '
        Me.line80.Height = 0.3!
        Me.line80.Left = 6.2!
        Me.line80.LineWeight = 1.0!
        Me.line80.Name = "line80"
        Me.line80.Top = 0.05!
        Me.line80.Width = 0.0!
        Me.line80.X1 = 6.2!
        Me.line80.X2 = 6.2!
        Me.line80.Y1 = 0.05!
        Me.line80.Y2 = 0.35!
        '
        'line81
        '
        Me.line81.Height = 0.3!
        Me.line81.Left = 5.7!
        Me.line81.LineWeight = 1.0!
        Me.line81.Name = "line81"
        Me.line81.Top = 0.05!
        Me.line81.Width = 0.0!
        Me.line81.X1 = 5.7!
        Me.line81.X2 = 5.7!
        Me.line81.Y1 = 0.05!
        Me.line81.Y2 = 0.35!
        '
        'line83
        '
        Me.line83.Height = 0.3!
        Me.line83.Left = 5.23!
        Me.line83.LineWeight = 1.0!
        Me.line83.Name = "line83"
        Me.line83.Top = 0.05!
        Me.line83.Width = 0.0!
        Me.line83.X1 = 5.23!
        Me.line83.X2 = 5.23!
        Me.line83.Y1 = 0.05!
        Me.line83.Y2 = 0.35!
        '
        'line84
        '
        Me.line84.Height = 0.3!
        Me.line84.Left = 4.8!
        Me.line84.LineWeight = 1.0!
        Me.line84.Name = "line84"
        Me.line84.Top = 0.05!
        Me.line84.Width = 0.0!
        Me.line84.X1 = 4.8!
        Me.line84.X2 = 4.8!
        Me.line84.Y1 = 0.05!
        Me.line84.Y2 = 0.35!
        '
        'line85
        '
        Me.line85.Height = 0.3!
        Me.line85.Left = 4.42!
        Me.line85.LineWeight = 1.0!
        Me.line85.Name = "line85"
        Me.line85.Top = 0.05!
        Me.line85.Width = 0.0!
        Me.line85.X1 = 4.42!
        Me.line85.X2 = 4.42!
        Me.line85.Y1 = 0.05!
        Me.line85.Y2 = 0.35!
        '
        'line86
        '
        Me.line86.Height = 0.3!
        Me.line86.Left = 7.1!
        Me.line86.LineWeight = 1.0!
        Me.line86.Name = "line86"
        Me.line86.Top = 0.05!
        Me.line86.Width = 0.0!
        Me.line86.X1 = 7.1!
        Me.line86.X2 = 7.1!
        Me.line86.Y1 = 0.05!
        Me.line86.Y2 = 0.35!
        '
        'line87
        '
        Me.line87.Height = 0.0!
        Me.line87.Left = 4.42!
        Me.line87.LineWeight = 1.0!
        Me.line87.Name = "line87"
        Me.line87.Top = 0.05!
        Me.line87.Width = 2.18!
        Me.line87.X1 = 4.42!
        Me.line87.X2 = 6.6!
        Me.line87.Y1 = 0.05!
        Me.line87.Y2 = 0.05!
        '
        'line88
        '
        Me.line88.Height = 0.0!
        Me.line88.Left = 4.42!
        Me.line88.LineWeight = 1.0!
        Me.line88.Name = "line88"
        Me.line88.Top = 0.35!
        Me.line88.Width = 2.18!
        Me.line88.X1 = 4.42!
        Me.line88.X2 = 6.6!
        Me.line88.Y1 = 0.35!
        Me.line88.Y2 = 0.35!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtSort, Me.lblReportDate, Me.reportInfo1, Me.txtDisclaimer})
        Me.PageFooter1.Height = 0.4395833!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'txtSort
        '
        Me.txtSort.Height = 0.15!
        Me.txtSort.HyperLink = Nothing
        Me.txtSort.Left = 0.0!
        Me.txtSort.Name = "txtSort"
        Me.txtSort.Style = "font-size: 7pt; font-style: italic; text-align: center; vertical-align: middle"
        Me.txtSort.Text = "(Sorted in descending order of largest TIV. TIV values in millions.)"
        Me.txtSort.Top = 0.0!
        Me.txtSort.Width = 11.45!
        '
        'lblReportDate
        '
        Me.lblReportDate.Height = 0.15!
        Me.lblReportDate.HyperLink = Nothing
        Me.lblReportDate.Left = 0.0000009536743!
        Me.lblReportDate.Name = "lblReportDate"
        Me.lblReportDate.Style = "font-size: 7pt; vertical-align: middle"
        Me.lblReportDate.Text = "Report Date"
        Me.lblReportDate.Top = 0.3!
        Me.lblReportDate.Width = 2.0!
        '
        'reportInfo1
        '
        Me.reportInfo1.FormatString = "Page {PageNumber} of {PageCount}"
        Me.reportInfo1.Height = 0.15!
        Me.reportInfo1.Left = 9.450001!
        Me.reportInfo1.Name = "reportInfo1"
        Me.reportInfo1.Style = "font-size: 7pt; font-style: italic; text-align: right; vertical-align: middle"
        Me.reportInfo1.Top = 0.3!
        Me.reportInfo1.Width = 2.0!
        '
        'txtDisclaimer
        '
        Me.txtDisclaimer.Height = 0.15!
        Me.txtDisclaimer.HyperLink = Nothing
        Me.txtDisclaimer.Left = 0.0!
        Me.txtDisclaimer.Name = "txtDisclaimer"
        Me.txtDisclaimer.Style = "font-size: 7pt; font-style: italic; text-align: center; vertical-align: middle"
        Me.txtDisclaimer.Text = "Disclaimer"
        Me.txtDisclaimer.Top = 0.15!
        Me.txtDisclaimer.Width = 11.45!
        '
        'rptFireExtinguishersHazardControlsSummary
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.25!
        Me.PageSettings.Margins.Left = 1.27!
        Me.PageSettings.Margins.Right = 1.28!
        Me.PageSettings.Margins.Top = 0.25!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 14.0!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Legal
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 11.45!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Calibri; font-style: normal; text-decoration: none; font-weight: nor" & _
            "mal; font-size: 10pt; color: Black", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
            "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.lblFlamLiqStored, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHotWorkPermit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPFEMounted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPFEAppTypeSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPFEServAnn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPFEInspMonthly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFireHosesInsp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl16Separation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPropCylinders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPropStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNoSmoking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFireDoorsNotObstr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNoMissCealTiles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBarricadeProvided, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNoStorageInElecRm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPlasSkids, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPortableFireExtinguisher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblClientName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFireExtinguishersHazardControlsSummary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblLocationInformation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGRCLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFileNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDivision2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblInspectionDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSTProv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCountry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTIVGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblExtinguishers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHazardControls, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblClientLocNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFacility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFireHosesInspC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPFEMountedC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPFEAppTypeSizeC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPFEServAnnC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPFEInspMonthlyC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoStorageInElecRmC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBarricadeProvidedC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoMissCealTilesC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFireDoorsNotObstrC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPropStorageC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoSmokingC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPropCylindersC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt16SeparationC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFlamLiqStoredC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHotWorkPermitC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPlasSkidsC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHotWorkPermit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFlamLiqStored, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt16Separation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPropCylinders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoSmoking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDivision2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFileNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSurveyDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSTProv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTIV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPropStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFireDoorsNotObstr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoMissCealTiles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBarricadeProvided, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoStorageInElecRm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPlasSkids, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFacility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientLocNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPFEInspMonthly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPFEServAnn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPFEAppTypeSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPFEMounted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFireHosesInsp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSort, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblReportDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reportInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisclaimer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
#End Region

#Region "New Report"
    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub
#End Region

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private Sub rptFireExtinguishersHazardControlsSummary_FetchData(ByVal sender As Object, ByVal eArgs As FetchEventArgs) Handles Me.FetchData
        Dim zControls() As ARControl = {txtPFEInspMonthly,
                                        txtPFEServAnn,
                                        txtPFEAppTypeSize,
                                        txtPFEMounted,
                                        txtFireHosesInsp,
                                        txtHotWorkPermit,
                                        txtFlamLiqStored,
                                        txt16Separation,
                                        txtPropCylinders,
                                        txtPropStorage,
                                        txtNoSmoking,
                                        txtFireDoorsNotObstr,
                                        txtNoMissCealTiles,
                                        txtBarricadeProvided,
                                        txtNoStorageInElecRm,
                                        txtPlasSkids}

        Dim zCommentControls() As ARControl = {txtPFEInspMonthlyC,
                                                txtPFEServAnnC,
                                                txtPFEAppTypeSizeC,
                                                txtPFEMountedC,
                                                txtFireHosesInspC,
                                                txtHotWorkPermitC,
                                                txtFlamLiqStoredC,
                                                txt16SeparationC,
                                                txtPropCylindersC,
                                                txtPropStorageC,
                                                txtNoSmokingC,
                                                txtFireDoorsNotObstrC,
                                                txtNoMissCealTilesC,
                                                txtBarricadeProvidedC,
                                                txtNoStorageInElecRmC,
                                                txtPlasSkidsC}

        UtilReport.ActiveReport.SetItemBackColorByTextAndComment(Me, zControls, zCommentControls, rptProperties)
    End Sub

    Private Sub rptFireExtinguishersHazardControlsSummary_ReportStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportStart
        lblClientName.Text = rptProperties.ClientName
        lblReportDate.Text = Now
        lblTIVGrid.Text = "TIV " & rptProperties.Currency.colFldCode & vbLf & "(millions)"
    End Sub

    Private Sub rptFireExtinguishersHazardControlsSummary_PageStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.PageStart
        UtilReport.ActiveReport.SetFilter(Me, rptProperties)
        UtilReport.ActiveReport.SetSort(Me, rptProperties)
        UtilReport.ActiveReport.SetDisclaimer(Me, rptProperties)
    End Sub

    Private Sub rptFireExtinguishersHazardControlsSummary_ReportEnd(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportEnd
        DisposeParameters()
    End Sub

    Private Sub DisposeParameters()
        DataSource = Nothing
    End Sub

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties

End Class
