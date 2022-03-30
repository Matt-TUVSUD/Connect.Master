Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports

Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing

Public Class rptBMFacilityDataSummary
    Inherits GrapeCity.ActiveReports.SectionReport
    Implements IUtilReport

#Region " ActiveReports Designer generated code "
    'Required by the ActiveReports Designer
    Private Shadows components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the ActiveReports Designer
    'It can be modified using the ActiveReports Designer.
    'Do not modify it using the code editor.
    Private WithEvents Detail1 As GrapeCity.ActiveReports.SectionReportModel.Detail
    Private WithEvents txtFileNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtInspectionDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCity As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSTProv As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCountry As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtTIV As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtDivision2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtAddress As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSpecificGroup As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtMajorGroup As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCompMajorExp As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtElecEquipC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtBoilersC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtProcEquipC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCompSysC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtMechPreMaintAdequacy As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtElecPreMaintAdequate As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSparesMaintained As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtHEAdequate As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtBCP As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtClientLocNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFacility As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents line42 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line43 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line45 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line46 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line47 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line49 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line50 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line51 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line52 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line54 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line55 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line57 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line58 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line59 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line60 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line61 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line62 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line63 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line64 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line65 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line67 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line68 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line69 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line70 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line71 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents PageHeader1 As GrapeCity.ActiveReports.SectionReportModel.PageHeader
    Private WithEvents lblPassive As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblBCP As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblActive As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblClientName As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblReport As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblLocationInformation As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents picGRCLogo As GrapeCity.ActiveReports.SectionReportModel.Picture
    Private WithEvents lblFileNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblDivision2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblInspectionDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCity As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblAddress As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblSTProv As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCountry As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblTIVGrid As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblOccupancy As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblMajorGroup As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblSpecificGroup As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCompMajorExp As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblElecPreMaintCMMS As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblElecEquipC As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblProcEquipC As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCompSysC As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblMechPreMaintAdequacy As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblElecPreMaintAdequate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblHEAdequate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFilters As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtFilters As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblClientLocNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFacility As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblBoilersC As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblSparesMaintained As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line3 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line4 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line5 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line7 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line8 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line9 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line10 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line11 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line16 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line17 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line18 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line19 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line20 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line21 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line23 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line24 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line31 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line32 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line33 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line34 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line35 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line36 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line37 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line38 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line39 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line40 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line6 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents PageFooter1 As GrapeCity.ActiveReports.SectionReportModel.PageFooter
    Private WithEvents txtSort As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblReportDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents reportInfo1 As GrapeCity.ActiveReports.SectionReportModel.ReportInfo
    Private WithEvents lblMechanicalEquipment As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents line12 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line13 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line15 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lblRefrig As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblRefrigMajorExp As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents line25 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lblWater As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblWaterMajorExp As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents line27 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lblCoolingTwrs As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCoolingMajorExp As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents line29 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lblGasFuels As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFuelMajorExp As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtRefrigMajorExp As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents line41 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtWaterMajorExp As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents line48 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtCoolingMajorExp As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents line66 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtFuelMajorExp As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtDisclaimer As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents line72 As GrapeCity.ActiveReports.SectionReportModel.Line
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptBMFacilityDataSummary))
        Me.Detail1 = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.txtFuelMajorExp = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCoolingMajorExp = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtWaterMajorExp = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtRefrigMajorExp = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCompMajorExp = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtAddress = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtDivision2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFileNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtInspectionDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCity = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSTProv = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCountry = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtTIV = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSpecificGroup = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMajorGroup = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtElecEquipC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtBoilersC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtProcEquipC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCompSysC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtElecPreMaintAdequate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSparesMaintained = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtHEAdequate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtBCP = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFacility = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtClientLocNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMechPreMaintAdequacy = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.line42 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line43 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line45 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line46 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line47 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line49 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line50 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line51 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line52 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line54 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line55 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line57 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line58 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line59 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line60 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line61 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line62 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line63 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line64 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line65 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line67 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line68 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line69 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line70 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line71 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line72 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line15 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line41 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line48 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line66 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.PageHeader1 = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.lblRefrig = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblWater = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblCoolingTwrs = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblGasFuels = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFuelMajorExp = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblCoolingMajorExp = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblWaterMajorExp = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblRefrigMajorExp = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblMechanicalEquipment = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPassive = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblBCP = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblActive = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblClientName = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblReport = New GrapeCity.ActiveReports.SectionReportModel.Label()
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
        Me.lblOccupancy = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblMajorGroup = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSpecificGroup = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblCompMajorExp = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblElecPreMaintCMMS = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblElecEquipC = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblProcEquipC = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblCompSysC = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblMechPreMaintAdequacy = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblElecPreMaintAdequate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblHEAdequate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFilters = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtFilters = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblClientLocNo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFacility = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblBoilersC = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSparesMaintained = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line5 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line7 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line8 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line9 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line10 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line11 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line16 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line17 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line18 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line19 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line20 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line21 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line23 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line24 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line31 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line32 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line33 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line34 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line35 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line36 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line37 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line38 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line39 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line40 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line6 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line12 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line13 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line25 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line27 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line29 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.PageFooter1 = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.txtSort = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblReportDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.reportInfo1 = New GrapeCity.ActiveReports.SectionReportModel.ReportInfo()
        Me.txtDisclaimer = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        CType(Me.txtFuelMajorExp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCoolingMajorExp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWaterMajorExp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRefrigMajorExp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCompMajorExp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDivision2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFileNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInspectionDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSTProv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTIV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSpecificGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMajorGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtElecEquipC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBoilersC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProcEquipC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCompSysC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtElecPreMaintAdequate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSparesMaintained, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHEAdequate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBCP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFacility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientLocNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMechPreMaintAdequacy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRefrig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblWater, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCoolingTwrs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblGasFuels, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFuelMajorExp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCoolingMajorExp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblWaterMajorExp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRefrigMajorExp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMechanicalEquipment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPassive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBCP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblActive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblClientName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblReport, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.lblOccupancy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMajorGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSpecificGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCompMajorExp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblElecPreMaintCMMS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblElecEquipC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblProcEquipC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCompSysC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMechPreMaintAdequacy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblElecPreMaintAdequate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHEAdequate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblClientLocNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFacility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBoilersC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSparesMaintained, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblReportDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisclaimer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtFuelMajorExp, Me.txtCoolingMajorExp, Me.txtWaterMajorExp, Me.txtRefrigMajorExp, Me.txtCompMajorExp, Me.txtAddress, Me.txtDivision2, Me.txtFileNo, Me.txtInspectionDate, Me.txtCity, Me.txtSTProv, Me.txtCountry, Me.txtTIV, Me.txtSpecificGroup, Me.txtMajorGroup, Me.txtElecEquipC, Me.txtBoilersC, Me.txtProcEquipC, Me.txtCompSysC, Me.txtElecPreMaintAdequate, Me.txtSparesMaintained, Me.txtHEAdequate, Me.txtBCP, Me.txtFacility, Me.txtClientLocNo, Me.txtMechPreMaintAdequacy, Me.line42, Me.line43, Me.line45, Me.line46, Me.line47, Me.line49, Me.line50, Me.line51, Me.line52, Me.line54, Me.line55, Me.line57, Me.line58, Me.line59, Me.line60, Me.line61, Me.line62, Me.line63, Me.line64, Me.line65, Me.line67, Me.line68, Me.line69, Me.line70, Me.line71, Me.line72, Me.line15, Me.line41, Me.line48, Me.line66})
        Me.Detail1.Height = 0.35!
        Me.Detail1.KeepTogether = True
        Me.Detail1.Name = "Detail1"
        '
        'txtFuelMajorExp
        '
        Me.txtFuelMajorExp.DataField = "FuelMajorExp"
        Me.txtFuelMajorExp.Height = 0.3!
        Me.txtFuelMajorExp.Left = 8.57!
        Me.txtFuelMajorExp.Name = "txtFuelMajorExp"
        Me.txtFuelMajorExp.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtFuelMajorExp.Text = "FuelMajorExp"
        Me.txtFuelMajorExp.Top = 0.05!
        Me.txtFuelMajorExp.Width = 0.7300001!
        '
        'txtCoolingMajorExp
        '
        Me.txtCoolingMajorExp.DataField = "CoolingMajorExp"
        Me.txtCoolingMajorExp.Height = 0.3!
        Me.txtCoolingMajorExp.Left = 7.87!
        Me.txtCoolingMajorExp.Name = "txtCoolingMajorExp"
        Me.txtCoolingMajorExp.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtCoolingMajorExp.Text = "CoolingMajorExp"
        Me.txtCoolingMajorExp.Top = 0.05!
        Me.txtCoolingMajorExp.Width = 0.7000004!
        '
        'txtWaterMajorExp
        '
        Me.txtWaterMajorExp.DataField = "WaterMajorExp"
        Me.txtWaterMajorExp.Height = 0.3!
        Me.txtWaterMajorExp.Left = 7.17!
        Me.txtWaterMajorExp.Name = "txtWaterMajorExp"
        Me.txtWaterMajorExp.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtWaterMajorExp.Text = "WaterMajorExp"
        Me.txtWaterMajorExp.Top = 0.05!
        Me.txtWaterMajorExp.Width = 0.7000004!
        '
        'txtRefrigMajorExp
        '
        Me.txtRefrigMajorExp.DataField = "RefrigMajorExp"
        Me.txtRefrigMajorExp.Height = 0.3!
        Me.txtRefrigMajorExp.Left = 6.47!
        Me.txtRefrigMajorExp.Name = "txtRefrigMajorExp"
        Me.txtRefrigMajorExp.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtRefrigMajorExp.Text = "RefrigMajorExp"
        Me.txtRefrigMajorExp.Top = 0.05!
        Me.txtRefrigMajorExp.Width = 0.7000009!
        '
        'txtCompMajorExp
        '
        Me.txtCompMajorExp.DataField = "CompMajorExp"
        Me.txtCompMajorExp.Height = 0.3!
        Me.txtCompMajorExp.Left = 5.77!
        Me.txtCompMajorExp.Name = "txtCompMajorExp"
        Me.txtCompMajorExp.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtCompMajorExp.Text = "CompMajorExp"
        Me.txtCompMajorExp.Top = 0.05!
        Me.txtCompMajorExp.Width = 0.7000004!
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
        'txtInspectionDate
        '
        Me.txtInspectionDate.CanGrow = False
        Me.txtInspectionDate.DataField = "InspectionDateString"
        Me.txtInspectionDate.Height = 0.15!
        Me.txtInspectionDate.Left = 0.5!
        Me.txtInspectionDate.MultiLine = False
        Me.txtInspectionDate.Name = "txtInspectionDate"
        Me.txtInspectionDate.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.txtInspectionDate.Text = "Insp. Date"
        Me.txtInspectionDate.Top = 0.05!
        Me.txtInspectionDate.Width = 0.58!
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
        'txtSpecificGroup
        '
        Me.txtSpecificGroup.DataField = "SpecificGroup"
        Me.txtSpecificGroup.Height = 0.15!
        Me.txtSpecificGroup.Left = 4.42!
        Me.txtSpecificGroup.Name = "txtSpecificGroup"
        Me.txtSpecificGroup.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtSpecificGroup.Text = "Specific Group"
        Me.txtSpecificGroup.Top = 0.2!
        Me.txtSpecificGroup.Width = 1.3!
        '
        'txtMajorGroup
        '
        Me.txtMajorGroup.DataField = "MajorGroup"
        Me.txtMajorGroup.Height = 0.15!
        Me.txtMajorGroup.Left = 4.42!
        Me.txtMajorGroup.Name = "txtMajorGroup"
        Me.txtMajorGroup.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtMajorGroup.Text = "Major Group"
        Me.txtMajorGroup.Top = 0.05!
        Me.txtMajorGroup.Width = 1.3!
        '
        'txtElecEquipC
        '
        Me.txtElecEquipC.DataField = "ElecEquipC"
        Me.txtElecEquipC.Height = 0.3!
        Me.txtElecEquipC.Left = 9.35!
        Me.txtElecEquipC.Name = "txtElecEquipC"
        Me.txtElecEquipC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtElecEquipC.Text = "ElecEquipC"
        Me.txtElecEquipC.Top = 0.05!
        Me.txtElecEquipC.Width = 0.35!
        '
        'txtBoilersC
        '
        Me.txtBoilersC.DataField = "BoilersC"
        Me.txtBoilersC.Height = 0.3!
        Me.txtBoilersC.Left = 9.7!
        Me.txtBoilersC.Name = "txtBoilersC"
        Me.txtBoilersC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtBoilersC.Text = "BoilersC"
        Me.txtBoilersC.Top = 0.05!
        Me.txtBoilersC.Width = 0.35!
        '
        'txtProcEquipC
        '
        Me.txtProcEquipC.DataField = "ProcEquipC"
        Me.txtProcEquipC.Height = 0.3!
        Me.txtProcEquipC.Left = 10.05!
        Me.txtProcEquipC.Name = "txtProcEquipC"
        Me.txtProcEquipC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtProcEquipC.Text = "ProcEquipC"
        Me.txtProcEquipC.Top = 0.05!
        Me.txtProcEquipC.Width = 0.35!
        '
        'txtCompSysC
        '
        Me.txtCompSysC.DataField = "CompSysC"
        Me.txtCompSysC.Height = 0.3!
        Me.txtCompSysC.Left = 10.4!
        Me.txtCompSysC.Name = "txtCompSysC"
        Me.txtCompSysC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtCompSysC.Text = "CompSysC"
        Me.txtCompSysC.Top = 0.05!
        Me.txtCompSysC.Width = 0.35!
        '
        'txtElecPreMaintAdequate
        '
        Me.txtElecPreMaintAdequate.DataField = "ElecPreMaintAdequate"
        Me.txtElecPreMaintAdequate.Height = 0.3!
        Me.txtElecPreMaintAdequate.Left = 11.4!
        Me.txtElecPreMaintAdequate.Name = "txtElecPreMaintAdequate"
        Me.txtElecPreMaintAdequate.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtElecPreMaintAdequate.Text = "ElecPreMaintAdequate"
        Me.txtElecPreMaintAdequate.Top = 0.05!
        Me.txtElecPreMaintAdequate.Width = 0.6!
        '
        'txtSparesMaintained
        '
        Me.txtSparesMaintained.DataField = "SparesMaintained"
        Me.txtSparesMaintained.Height = 0.3!
        Me.txtSparesMaintained.Left = 12.0!
        Me.txtSparesMaintained.Name = "txtSparesMaintained"
        Me.txtSparesMaintained.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtSparesMaintained.Text = "SparesMaintained"
        Me.txtSparesMaintained.Top = 0.05!
        Me.txtSparesMaintained.Width = 0.6!
        '
        'txtHEAdequate
        '
        Me.txtHEAdequate.DataField = "HEAdequate"
        Me.txtHEAdequate.Height = 0.3!
        Me.txtHEAdequate.Left = 12.6!
        Me.txtHEAdequate.Name = "txtHEAdequate"
        Me.txtHEAdequate.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtHEAdequate.Text = "HEAdequate"
        Me.txtHEAdequate.Top = 0.05!
        Me.txtHEAdequate.Width = 0.6!
        '
        'txtBCP
        '
        Me.txtBCP.DataField = "BCP"
        Me.txtBCP.Height = 0.3!
        Me.txtBCP.Left = 13.2!
        Me.txtBCP.Name = "txtBCP"
        Me.txtBCP.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtBCP.Text = "BCP"
        Me.txtBCP.Top = 0.05!
        Me.txtBCP.Width = 0.6!
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
        'txtMechPreMaintAdequacy
        '
        Me.txtMechPreMaintAdequacy.DataField = "MechPreMaintAdequacy"
        Me.txtMechPreMaintAdequacy.Height = 0.3!
        Me.txtMechPreMaintAdequacy.Left = 10.8!
        Me.txtMechPreMaintAdequacy.Name = "txtMechPreMaintAdequacy"
        Me.txtMechPreMaintAdequacy.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtMechPreMaintAdequacy.Text = "MechPreMaintAdequacy"
        Me.txtMechPreMaintAdequacy.Top = 0.05!
        Me.txtMechPreMaintAdequacy.Width = 0.6!
        '
        'line42
        '
        Me.line42.Height = 0.3!
        Me.line42.Left = 13.8!
        Me.line42.LineWeight = 1.0!
        Me.line42.Name = "line42"
        Me.line42.Top = 0.05!
        Me.line42.Width = 0.0!
        Me.line42.X1 = 13.8!
        Me.line42.X2 = 13.8!
        Me.line42.Y1 = 0.05!
        Me.line42.Y2 = 0.35!
        '
        'line43
        '
        Me.line43.Height = 0.3!
        Me.line43.Left = 13.2!
        Me.line43.LineWeight = 1.0!
        Me.line43.Name = "line43"
        Me.line43.Top = 0.05!
        Me.line43.Width = 0.0!
        Me.line43.X1 = 13.2!
        Me.line43.X2 = 13.2!
        Me.line43.Y1 = 0.05!
        Me.line43.Y2 = 0.35!
        '
        'line45
        '
        Me.line45.Height = 0.3!
        Me.line45.Left = 12.6!
        Me.line45.LineWeight = 1.0!
        Me.line45.Name = "line45"
        Me.line45.Top = 0.05!
        Me.line45.Width = 0.0!
        Me.line45.X1 = 12.6!
        Me.line45.X2 = 12.6!
        Me.line45.Y1 = 0.05!
        Me.line45.Y2 = 0.35!
        '
        'line46
        '
        Me.line46.Height = 0.3!
        Me.line46.Left = 12.0!
        Me.line46.LineWeight = 1.0!
        Me.line46.Name = "line46"
        Me.line46.Top = 0.05!
        Me.line46.Width = 0.0!
        Me.line46.X1 = 12.0!
        Me.line46.X2 = 12.0!
        Me.line46.Y1 = 0.05!
        Me.line46.Y2 = 0.35!
        '
        'line47
        '
        Me.line47.Height = 0.3!
        Me.line47.Left = 11.4!
        Me.line47.LineWeight = 1.0!
        Me.line47.Name = "line47"
        Me.line47.Top = 0.05!
        Me.line47.Width = 0.0!
        Me.line47.X1 = 11.4!
        Me.line47.X2 = 11.4!
        Me.line47.Y1 = 0.05!
        Me.line47.Y2 = 0.35!
        '
        'line49
        '
        Me.line49.Height = 0.3!
        Me.line49.Left = 10.8!
        Me.line49.LineWeight = 1.0!
        Me.line49.Name = "line49"
        Me.line49.Top = 0.05!
        Me.line49.Width = 0.0!
        Me.line49.X1 = 10.8!
        Me.line49.X2 = 10.8!
        Me.line49.Y1 = 0.05!
        Me.line49.Y2 = 0.35!
        '
        'line50
        '
        Me.line50.Height = 0.3!
        Me.line50.Left = 9.7!
        Me.line50.LineWeight = 1.0!
        Me.line50.Name = "line50"
        Me.line50.Top = 0.05!
        Me.line50.Width = 0.0!
        Me.line50.X1 = 9.7!
        Me.line50.X2 = 9.7!
        Me.line50.Y1 = 0.05!
        Me.line50.Y2 = 0.35!
        '
        'line51
        '
        Me.line51.Height = 0.3!
        Me.line51.Left = 10.05!
        Me.line51.LineWeight = 1.0!
        Me.line51.Name = "line51"
        Me.line51.Top = 0.05!
        Me.line51.Width = 0.0!
        Me.line51.X1 = 10.05!
        Me.line51.X2 = 10.05!
        Me.line51.Y1 = 0.05!
        Me.line51.Y2 = 0.35!
        '
        'line52
        '
        Me.line52.Height = 0.3!
        Me.line52.Left = 10.4!
        Me.line52.LineWeight = 1.0!
        Me.line52.Name = "line52"
        Me.line52.Top = 0.05!
        Me.line52.Width = 0.0!
        Me.line52.X1 = 10.4!
        Me.line52.X2 = 10.4!
        Me.line52.Y1 = 0.05!
        Me.line52.Y2 = 0.35!
        '
        'line54
        '
        Me.line54.Height = 0.3!
        Me.line54.Left = 9.35!
        Me.line54.LineWeight = 1.0!
        Me.line54.Name = "line54"
        Me.line54.Top = 0.05!
        Me.line54.Width = 0.0!
        Me.line54.X1 = 9.35!
        Me.line54.X2 = 9.35!
        Me.line54.Y1 = 0.05!
        Me.line54.Y2 = 0.35!
        '
        'line55
        '
        Me.line55.Height = 0.3!
        Me.line55.Left = 9.3!
        Me.line55.LineWeight = 1.0!
        Me.line55.Name = "line55"
        Me.line55.Top = 0.05!
        Me.line55.Width = 0.0!
        Me.line55.X1 = 9.3!
        Me.line55.X2 = 9.3!
        Me.line55.Y1 = 0.05!
        Me.line55.Y2 = 0.35!
        '
        'line57
        '
        Me.line57.Height = 0.3!
        Me.line57.Left = 10.75!
        Me.line57.LineWeight = 1.0!
        Me.line57.Name = "line57"
        Me.line57.Top = 0.05!
        Me.line57.Width = 0.0!
        Me.line57.X1 = 10.75!
        Me.line57.X2 = 10.75!
        Me.line57.Y1 = 0.05!
        Me.line57.Y2 = 0.35!
        '
        'line58
        '
        Me.line58.Height = 0.3!
        Me.line58.Left = 5.77!
        Me.line58.LineWeight = 1.0!
        Me.line58.Name = "line58"
        Me.line58.Top = 0.05!
        Me.line58.Width = 0.0!
        Me.line58.X1 = 5.77!
        Me.line58.X2 = 5.77!
        Me.line58.Y1 = 0.05!
        Me.line58.Y2 = 0.35!
        '
        'line59
        '
        Me.line59.Height = 0.3!
        Me.line59.Left = 5.72!
        Me.line59.LineWeight = 1.0!
        Me.line59.Name = "line59"
        Me.line59.Top = 0.05!
        Me.line59.Width = 0.0!
        Me.line59.X1 = 5.72!
        Me.line59.X2 = 5.72!
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
        Me.line65.Width = 1.3!
        Me.line65.X1 = 4.42!
        Me.line65.X2 = 5.72!
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
        Me.line67.Width = 1.3!
        Me.line67.X1 = 4.42!
        Me.line67.X2 = 5.72!
        Me.line67.Y1 = 0.35!
        Me.line67.Y2 = 0.35!
        '
        'line68
        '
        Me.line68.Height = 0.0!
        Me.line68.Left = 5.77!
        Me.line68.LineWeight = 1.0!
        Me.line68.Name = "line68"
        Me.line68.Top = 0.05!
        Me.line68.Width = 4.98!
        Me.line68.X1 = 5.77!
        Me.line68.X2 = 10.75!
        Me.line68.Y1 = 0.05!
        Me.line68.Y2 = 0.05!
        '
        'line69
        '
        Me.line69.Height = 0.0!
        Me.line69.Left = 4.42!
        Me.line69.LineWeight = 1.0!
        Me.line69.Name = "line69"
        Me.line69.Top = 0.2!
        Me.line69.Width = 1.3!
        Me.line69.X1 = 4.42!
        Me.line69.X2 = 5.72!
        Me.line69.Y1 = 0.2!
        Me.line69.Y2 = 0.2!
        '
        'line70
        '
        Me.line70.Height = 0.0!
        Me.line70.Left = 5.77!
        Me.line70.LineWeight = 1.0!
        Me.line70.Name = "line70"
        Me.line70.Top = 0.35!
        Me.line70.Width = 4.98!
        Me.line70.X1 = 5.77!
        Me.line70.X2 = 10.75!
        Me.line70.Y1 = 0.35!
        Me.line70.Y2 = 0.35!
        '
        'line71
        '
        Me.line71.Height = 0.0!
        Me.line71.Left = 10.8!
        Me.line71.LineWeight = 1.0!
        Me.line71.Name = "line71"
        Me.line71.Top = 0.05!
        Me.line71.Width = 3.0!
        Me.line71.X1 = 10.8!
        Me.line71.X2 = 13.8!
        Me.line71.Y1 = 0.05!
        Me.line71.Y2 = 0.05!
        '
        'line72
        '
        Me.line72.Height = 0.0!
        Me.line72.Left = 10.8!
        Me.line72.LineWeight = 1.0!
        Me.line72.Name = "line72"
        Me.line72.Top = 0.35!
        Me.line72.Width = 3.0!
        Me.line72.X1 = 10.8!
        Me.line72.X2 = 13.8!
        Me.line72.Y1 = 0.35!
        Me.line72.Y2 = 0.35!
        '
        'line15
        '
        Me.line15.Height = 0.3!
        Me.line15.Left = 6.47!
        Me.line15.LineWeight = 1.0!
        Me.line15.Name = "line15"
        Me.line15.Top = 0.05!
        Me.line15.Width = 0.0!
        Me.line15.X1 = 6.47!
        Me.line15.X2 = 6.47!
        Me.line15.Y1 = 0.05!
        Me.line15.Y2 = 0.35!
        '
        'line41
        '
        Me.line41.Height = 0.3!
        Me.line41.Left = 7.17!
        Me.line41.LineWeight = 1.0!
        Me.line41.Name = "line41"
        Me.line41.Top = 0.05!
        Me.line41.Width = 0.0!
        Me.line41.X1 = 7.17!
        Me.line41.X2 = 7.17!
        Me.line41.Y1 = 0.05!
        Me.line41.Y2 = 0.35!
        '
        'line48
        '
        Me.line48.Height = 0.3!
        Me.line48.Left = 7.87!
        Me.line48.LineWeight = 1.0!
        Me.line48.Name = "line48"
        Me.line48.Top = 0.05!
        Me.line48.Width = 0.0!
        Me.line48.X1 = 7.87!
        Me.line48.X2 = 7.87!
        Me.line48.Y1 = 0.05!
        Me.line48.Y2 = 0.35!
        '
        'line66
        '
        Me.line66.Height = 0.3!
        Me.line66.Left = 8.57!
        Me.line66.LineWeight = 1.0!
        Me.line66.Name = "line66"
        Me.line66.Top = 0.05!
        Me.line66.Width = 0.0!
        Me.line66.X1 = 8.57!
        Me.line66.X2 = 8.57!
        Me.line66.Y1 = 0.05!
        Me.line66.Y2 = 0.35!
        '
        'PageHeader1
        '
        Me.PageHeader1.CanShrink = True
        Me.PageHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblRefrig, Me.lblWater, Me.lblCoolingTwrs, Me.lblGasFuels, Me.lblFuelMajorExp, Me.lblCoolingMajorExp, Me.lblWaterMajorExp, Me.lblRefrigMajorExp, Me.lblMechanicalEquipment, Me.lblPassive, Me.lblBCP, Me.lblActive, Me.lblClientName, Me.lblReport, Me.lblLocationInformation, Me.picGRCLogo, Me.lblFileNo, Me.lblDivision2, Me.lblInspectionDate, Me.lblCity, Me.lblAddress, Me.lblSTProv, Me.lblCountry, Me.lblTIVGrid, Me.lblOccupancy, Me.lblMajorGroup, Me.lblSpecificGroup, Me.lblCompMajorExp, Me.lblElecPreMaintCMMS, Me.lblElecEquipC, Me.lblProcEquipC, Me.lblCompSysC, Me.lblMechPreMaintAdequacy, Me.lblElecPreMaintAdequate, Me.lblHEAdequate, Me.lblFilters, Me.txtFilters, Me.lblClientLocNo, Me.lblFacility, Me.lblBoilersC, Me.lblSparesMaintained, Me.line1, Me.line2, Me.line3, Me.line4, Me.line5, Me.line7, Me.line8, Me.line9, Me.line10, Me.line11, Me.line16, Me.line17, Me.line18, Me.line19, Me.line20, Me.line21, Me.line23, Me.line24, Me.line31, Me.line32, Me.line33, Me.line34, Me.line35, Me.line36, Me.line37, Me.line38, Me.line39, Me.line40, Me.line6, Me.line12, Me.line13, Me.line25, Me.line27, Me.line29})
        Me.PageHeader1.Height = 1.8!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'lblRefrig
        '
        Me.lblRefrig.Height = 0.15!
        Me.lblRefrig.HyperLink = Nothing
        Me.lblRefrig.Left = 6.47!
        Me.lblRefrig.Name = "lblRefrig"
        Me.lblRefrig.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblRefrig.Text = "Refrig."
        Me.lblRefrig.Top = 1.35!
        Me.lblRefrig.Width = 0.7!
        '
        'lblWater
        '
        Me.lblWater.Height = 0.15!
        Me.lblWater.HyperLink = Nothing
        Me.lblWater.Left = 7.17!
        Me.lblWater.Name = "lblWater"
        Me.lblWater.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblWater.Text = "Water"
        Me.lblWater.Top = 1.35!
        Me.lblWater.Width = 0.7!
        '
        'lblCoolingTwrs
        '
        Me.lblCoolingTwrs.Height = 0.15!
        Me.lblCoolingTwrs.HyperLink = Nothing
        Me.lblCoolingTwrs.Left = 7.87!
        Me.lblCoolingTwrs.Name = "lblCoolingTwrs"
        Me.lblCoolingTwrs.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblCoolingTwrs.Text = "Cooling Twrs"
        Me.lblCoolingTwrs.Top = 1.35!
        Me.lblCoolingTwrs.Width = 0.7!
        '
        'lblGasFuels
        '
        Me.lblGasFuels.Height = 0.15!
        Me.lblGasFuels.HyperLink = Nothing
        Me.lblGasFuels.Left = 8.57!
        Me.lblGasFuels.Name = "lblGasFuels"
        Me.lblGasFuels.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblGasFuels.Text = "Gas/Fuels"
        Me.lblGasFuels.Top = 1.35!
        Me.lblGasFuels.Width = 0.7!
        '
        'lblFuelMajorExp
        '
        Me.lblFuelMajorExp.Height = 0.3!
        Me.lblFuelMajorExp.HyperLink = Nothing
        Me.lblFuelMajorExp.Left = 8.57!
        Me.lblFuelMajorExp.Name = "lblFuelMajorExp"
        Me.lblFuelMajorExp.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblFuelMajorExp.Text = "Maj. Exp."
        Me.lblFuelMajorExp.Top = 1.5!
        Me.lblFuelMajorExp.Width = 0.7300001!
        '
        'lblCoolingMajorExp
        '
        Me.lblCoolingMajorExp.Height = 0.3!
        Me.lblCoolingMajorExp.HyperLink = Nothing
        Me.lblCoolingMajorExp.Left = 7.87!
        Me.lblCoolingMajorExp.Name = "lblCoolingMajorExp"
        Me.lblCoolingMajorExp.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblCoolingMajorExp.Text = "Maj. Exp."
        Me.lblCoolingMajorExp.Top = 1.5!
        Me.lblCoolingMajorExp.Width = 0.7000004!
        '
        'lblWaterMajorExp
        '
        Me.lblWaterMajorExp.Height = 0.3!
        Me.lblWaterMajorExp.HyperLink = Nothing
        Me.lblWaterMajorExp.Left = 7.17!
        Me.lblWaterMajorExp.Name = "lblWaterMajorExp"
        Me.lblWaterMajorExp.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblWaterMajorExp.Text = "Maj. Exp."
        Me.lblWaterMajorExp.Top = 1.5!
        Me.lblWaterMajorExp.Width = 0.7000004!
        '
        'lblRefrigMajorExp
        '
        Me.lblRefrigMajorExp.Height = 0.3!
        Me.lblRefrigMajorExp.HyperLink = Nothing
        Me.lblRefrigMajorExp.Left = 6.47!
        Me.lblRefrigMajorExp.Name = "lblRefrigMajorExp"
        Me.lblRefrigMajorExp.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblRefrigMajorExp.Text = "Maj. Exp."
        Me.lblRefrigMajorExp.Top = 1.5!
        Me.lblRefrigMajorExp.Width = 0.7000009!
        '
        'lblMechanicalEquipment
        '
        Me.lblMechanicalEquipment.Height = 0.15!
        Me.lblMechanicalEquipment.HyperLink = Nothing
        Me.lblMechanicalEquipment.Left = 5.77!
        Me.lblMechanicalEquipment.Name = "lblMechanicalEquipment"
        Me.lblMechanicalEquipment.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblMechanicalEquipment.Text = "Mechanical Equipment"
        Me.lblMechanicalEquipment.Top = 1.2!
        Me.lblMechanicalEquipment.Width = 3.53!
        '
        'lblPassive
        '
        Me.lblPassive.Height = 0.15!
        Me.lblPassive.HyperLink = Nothing
        Me.lblPassive.Left = 5.77!
        Me.lblPassive.Name = "lblPassive"
        Me.lblPassive.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblPassive.Text = "Physical Assets"
        Me.lblPassive.Top = 1.05!
        Me.lblPassive.Width = 4.98!
        '
        'lblBCP
        '
        Me.lblBCP.Height = 0.6!
        Me.lblBCP.HyperLink = Nothing
        Me.lblBCP.Left = 13.2!
        Me.lblBCP.Name = "lblBCP"
        Me.lblBCP.Style = "background-color: White; font-size: 7pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblBCP.Text = "BCP"
        Me.lblBCP.Top = 1.2!
        Me.lblBCP.Width = 0.6!
        '
        'lblActive
        '
        Me.lblActive.Height = 0.15!
        Me.lblActive.HyperLink = Nothing
        Me.lblActive.Left = 10.8!
        Me.lblActive.Name = "lblActive"
        Me.lblActive.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblActive.Text = "Management Programs"
        Me.lblActive.Top = 1.05!
        Me.lblActive.Width = 3.0!
        '
        'lblClientName
        '
        Me.lblClientName.Height = 0.25!
        Me.lblClientName.HyperLink = Nothing
        Me.lblClientName.Left = 9.440001!
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Style = "color: #C6D1DE; font-size: 16pt; font-style: italic; font-weight: bold; text-alig" & _
    "n: right; vertical-align: middle"
        Me.lblClientName.Text = "Company Name"
        Me.lblClientName.Top = 0.05!
        Me.lblClientName.Width = 4.3!
        '
        'lblReport
        '
        Me.lblReport.Height = 0.25!
        Me.lblReport.HyperLink = Nothing
        Me.lblReport.Left = 9.440001!
        Me.lblReport.Name = "lblReport"
        Me.lblReport.Style = "font-size: 12pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblReport.Text = "B&M Facility Data Summary"
        Me.lblReport.Top = 0.35!
        Me.lblReport.Width = 4.3!
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
        Me.lblFileNo.Top = 1.35!
        Me.lblFileNo.Width = 0.5!
        '
        'lblDivision2
        '
        Me.lblDivision2.Height = 0.15!
        Me.lblDivision2.HyperLink = Nothing
        Me.lblDivision2.Left = 0.0!
        Me.lblDivision2.Name = "lblDivision2"
        Me.lblDivision2.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.lblDivision2.Text = "Division"
        Me.lblDivision2.Top = 1.5!
        Me.lblDivision2.Width = 1.1!
        '
        'lblInspectionDate
        '
        Me.lblInspectionDate.Height = 0.15!
        Me.lblInspectionDate.HyperLink = Nothing
        Me.lblInspectionDate.Left = 0.5!
        Me.lblInspectionDate.Name = "lblInspectionDate"
        Me.lblInspectionDate.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.lblInspectionDate.Text = "Date of Insp."
        Me.lblInspectionDate.Top = 1.35!
        Me.lblInspectionDate.Width = 0.6!
        '
        'lblCity
        '
        Me.lblCity.Height = 0.15!
        Me.lblCity.HyperLink = Nothing
        Me.lblCity.Left = 1.9!
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.lblCity.Text = "City/"
        Me.lblCity.Top = 1.35!
        Me.lblCity.Width = 0.95!
        '
        'lblAddress
        '
        Me.lblAddress.Height = 0.15!
        Me.lblAddress.HyperLink = Nothing
        Me.lblAddress.Left = 1.9!
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.lblAddress.Text = "Address"
        Me.lblAddress.Top = 1.5!
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
        Me.lblSTProv.Top = 1.35!
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
        Me.lblCountry.Top = 1.35!
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
        Me.lblTIVGrid.Top = 1.35!
        Me.lblTIVGrid.Width = 0.42!
        '
        'lblOccupancy
        '
        Me.lblOccupancy.Height = 0.15!
        Me.lblOccupancy.HyperLink = Nothing
        Me.lblOccupancy.Left = 4.42!
        Me.lblOccupancy.Name = "lblOccupancy"
        Me.lblOccupancy.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblOccupancy.Text = "Occupancy"
        Me.lblOccupancy.Top = 1.05!
        Me.lblOccupancy.Width = 1.3!
        '
        'lblMajorGroup
        '
        Me.lblMajorGroup.Height = 0.15!
        Me.lblMajorGroup.HyperLink = Nothing
        Me.lblMajorGroup.Left = 4.42!
        Me.lblMajorGroup.Name = "lblMajorGroup"
        Me.lblMajorGroup.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblMajorGroup.Text = "Major Occup. Group/"
        Me.lblMajorGroup.Top = 1.35!
        Me.lblMajorGroup.Width = 1.3!
        '
        'lblSpecificGroup
        '
        Me.lblSpecificGroup.Height = 0.15!
        Me.lblSpecificGroup.HyperLink = Nothing
        Me.lblSpecificGroup.Left = 4.42!
        Me.lblSpecificGroup.Name = "lblSpecificGroup"
        Me.lblSpecificGroup.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblSpecificGroup.Text = "Specific Occup. Group"
        Me.lblSpecificGroup.Top = 1.5!
        Me.lblSpecificGroup.Width = 1.3!
        '
        'lblCompMajorExp
        '
        Me.lblCompMajorExp.Height = 0.3!
        Me.lblCompMajorExp.HyperLink = Nothing
        Me.lblCompMajorExp.Left = 5.77!
        Me.lblCompMajorExp.Name = "lblCompMajorExp"
        Me.lblCompMajorExp.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblCompMajorExp.Text = "Maj. Exp."
        Me.lblCompMajorExp.Top = 1.5!
        Me.lblCompMajorExp.Width = 0.7000004!
        '
        'lblElecPreMaintCMMS
        '
        Me.lblElecPreMaintCMMS.Height = 0.15!
        Me.lblElecPreMaintCMMS.HyperLink = Nothing
        Me.lblElecPreMaintCMMS.Left = 5.77!
        Me.lblElecPreMaintCMMS.Name = "lblElecPreMaintCMMS"
        Me.lblElecPreMaintCMMS.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblElecPreMaintCMMS.Text = "Comp. Air"
        Me.lblElecPreMaintCMMS.Top = 1.35!
        Me.lblElecPreMaintCMMS.Width = 0.7!
        '
        'lblElecEquipC
        '
        Me.lblElecEquipC.Height = 0.6!
        Me.lblElecEquipC.HyperLink = Nothing
        Me.lblElecEquipC.Left = 9.35!
        Me.lblElecEquipC.Name = "lblElecEquipC"
        Me.lblElecEquipC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblElecEquipC.Text = "Elec. Equip."
        Me.lblElecEquipC.Top = 1.2!
        Me.lblElecEquipC.Width = 0.35!
        '
        'lblProcEquipC
        '
        Me.lblProcEquipC.Height = 0.6!
        Me.lblProcEquipC.HyperLink = Nothing
        Me.lblProcEquipC.Left = 10.05!
        Me.lblProcEquipC.Name = "lblProcEquipC"
        Me.lblProcEquipC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblProcEquipC.Text = "Prod. Equip."
        Me.lblProcEquipC.Top = 1.2!
        Me.lblProcEquipC.Width = 0.35!
        '
        'lblCompSysC
        '
        Me.lblCompSysC.Height = 0.6!
        Me.lblCompSysC.HyperLink = Nothing
        Me.lblCompSysC.Left = 10.4!
        Me.lblCompSysC.Name = "lblCompSysC"
        Me.lblCompSysC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblCompSysC.Text = "Trans. Oil Testing"
        Me.lblCompSysC.Top = 1.2!
        Me.lblCompSysC.Width = 0.35!
        '
        'lblMechPreMaintAdequacy
        '
        Me.lblMechPreMaintAdequacy.Height = 0.6!
        Me.lblMechPreMaintAdequacy.HyperLink = Nothing
        Me.lblMechPreMaintAdequacy.Left = 10.8!
        Me.lblMechPreMaintAdequacy.Name = "lblMechPreMaintAdequacy"
        Me.lblMechPreMaintAdequacy.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblMechPreMaintAdequacy.Text = "Mechanical Prev. Pred."
        Me.lblMechPreMaintAdequacy.Top = 1.2!
        Me.lblMechPreMaintAdequacy.Width = 0.6!
        '
        'lblElecPreMaintAdequate
        '
        Me.lblElecPreMaintAdequate.Height = 0.6!
        Me.lblElecPreMaintAdequate.HyperLink = Nothing
        Me.lblElecPreMaintAdequate.Left = 11.4!
        Me.lblElecPreMaintAdequate.Name = "lblElecPreMaintAdequate"
        Me.lblElecPreMaintAdequate.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblElecPreMaintAdequate.Text = "Electrical Prev. Pred."
        Me.lblElecPreMaintAdequate.Top = 1.2!
        Me.lblElecPreMaintAdequate.Width = 0.6!
        '
        'lblHEAdequate
        '
        Me.lblHEAdequate.Height = 0.6!
        Me.lblHEAdequate.HyperLink = Nothing
        Me.lblHEAdequate.Left = 12.6!
        Me.lblHEAdequate.Name = "lblHEAdequate"
        Me.lblHEAdequate.Style = "background-color: White; font-size: 7pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblHEAdequate.Text = "Human Element"
        Me.lblHEAdequate.Top = 1.2!
        Me.lblHEAdequate.Width = 0.6!
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
        Me.txtFilters.Width = 13.36!
        '
        'lblClientLocNo
        '
        Me.lblClientLocNo.Height = 0.15!
        Me.lblClientLocNo.HyperLink = Nothing
        Me.lblClientLocNo.Left = 1.1!
        Me.lblClientLocNo.Name = "lblClientLocNo"
        Me.lblClientLocNo.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.lblClientLocNo.Text = "Client Loc. No"
        Me.lblClientLocNo.Top = 1.35!
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
        Me.lblFacility.Top = 1.5!
        Me.lblFacility.Width = 0.8!
        '
        'lblBoilersC
        '
        Me.lblBoilersC.Height = 0.6!
        Me.lblBoilersC.HyperLink = Nothing
        Me.lblBoilersC.Left = 9.7!
        Me.lblBoilersC.Name = "lblBoilersC"
        Me.lblBoilersC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblBoilersC.Text = "Boilers / Press. Vess."
        Me.lblBoilersC.Top = 1.2!
        Me.lblBoilersC.Width = 0.35!
        '
        'lblSparesMaintained
        '
        Me.lblSparesMaintained.Height = 0.6!
        Me.lblSparesMaintained.HyperLink = Nothing
        Me.lblSparesMaintained.Left = 12.0!
        Me.lblSparesMaintained.Name = "lblSparesMaintained"
        Me.lblSparesMaintained.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblSparesMaintained.Text = "Critical Spares"
        Me.lblSparesMaintained.Top = 1.2!
        Me.lblSparesMaintained.Width = 0.6!
        '
        'line1
        '
        Me.line1.Height = 0.0!
        Me.line1.Left = 0.0!
        Me.line1.LineWeight = 1.0!
        Me.line1.Name = "line1"
        Me.line1.Top = 1.8!
        Me.line1.Width = 4.37!
        Me.line1.X1 = 0.0!
        Me.line1.X2 = 4.37!
        Me.line1.Y1 = 1.8!
        Me.line1.Y2 = 1.8!
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
        Me.line3.Height = 0.75!
        Me.line3.Left = 0.0!
        Me.line3.LineWeight = 1.0!
        Me.line3.Name = "line3"
        Me.line3.Top = 1.05!
        Me.line3.Width = 0.0!
        Me.line3.X1 = 0.0!
        Me.line3.X2 = 0.0!
        Me.line3.Y1 = 1.05!
        Me.line3.Y2 = 1.8!
        '
        'line4
        '
        Me.line4.Height = 0.75!
        Me.line4.Left = 4.37!
        Me.line4.LineWeight = 1.0!
        Me.line4.Name = "line4"
        Me.line4.Top = 1.05!
        Me.line4.Width = 0.0!
        Me.line4.X1 = 4.37!
        Me.line4.X2 = 4.37!
        Me.line4.Y1 = 1.05!
        Me.line4.Y2 = 1.8!
        '
        'line5
        '
        Me.line5.Height = 0.75!
        Me.line5.Left = 4.42!
        Me.line5.LineWeight = 1.0!
        Me.line5.Name = "line5"
        Me.line5.Top = 1.05!
        Me.line5.Width = 0.0!
        Me.line5.X1 = 4.42!
        Me.line5.X2 = 4.42!
        Me.line5.Y1 = 1.05!
        Me.line5.Y2 = 1.8!
        '
        'line7
        '
        Me.line7.Height = 0.75!
        Me.line7.Left = 5.72!
        Me.line7.LineWeight = 1.0!
        Me.line7.Name = "line7"
        Me.line7.Top = 1.05!
        Me.line7.Width = 0.0!
        Me.line7.X1 = 5.72!
        Me.line7.X2 = 5.72!
        Me.line7.Y1 = 1.05!
        Me.line7.Y2 = 1.8!
        '
        'line8
        '
        Me.line8.Height = 0.75!
        Me.line8.Left = 5.77!
        Me.line8.LineWeight = 1.0!
        Me.line8.Name = "line8"
        Me.line8.Top = 1.05!
        Me.line8.Width = 0.0!
        Me.line8.X1 = 5.77!
        Me.line8.X2 = 5.77!
        Me.line8.Y1 = 1.05!
        Me.line8.Y2 = 1.8!
        '
        'line9
        '
        Me.line9.Height = 0.75!
        Me.line9.Left = 10.75!
        Me.line9.LineWeight = 1.0!
        Me.line9.Name = "line9"
        Me.line9.Top = 1.05!
        Me.line9.Width = 0.0!
        Me.line9.X1 = 10.75!
        Me.line9.X2 = 10.75!
        Me.line9.Y1 = 1.05!
        Me.line9.Y2 = 1.8!
        '
        'line10
        '
        Me.line10.Height = 0.5999999!
        Me.line10.Left = 9.3!
        Me.line10.LineWeight = 1.0!
        Me.line10.Name = "line10"
        Me.line10.Top = 1.2!
        Me.line10.Width = 0.0!
        Me.line10.X1 = 9.3!
        Me.line10.X2 = 9.3!
        Me.line10.Y1 = 1.2!
        Me.line10.Y2 = 1.8!
        '
        'line11
        '
        Me.line11.Height = 0.75!
        Me.line11.Left = 13.8!
        Me.line11.LineWeight = 1.0!
        Me.line11.Name = "line11"
        Me.line11.Top = 1.05!
        Me.line11.Width = 0.0!
        Me.line11.X1 = 13.8!
        Me.line11.X2 = 13.8!
        Me.line11.Y1 = 1.05!
        Me.line11.Y2 = 1.8!
        '
        'line16
        '
        Me.line16.Height = 0.0!
        Me.line16.Left = 4.42!
        Me.line16.LineWeight = 1.0!
        Me.line16.Name = "line16"
        Me.line16.Top = 1.8!
        Me.line16.Width = 1.3!
        Me.line16.X1 = 4.42!
        Me.line16.X2 = 5.72!
        Me.line16.Y1 = 1.8!
        Me.line16.Y2 = 1.8!
        '
        'line17
        '
        Me.line17.Height = 0.0!
        Me.line17.Left = 4.42!
        Me.line17.LineWeight = 1.0!
        Me.line17.Name = "line17"
        Me.line17.Top = 1.2!
        Me.line17.Width = 1.3!
        Me.line17.X1 = 4.42!
        Me.line17.X2 = 5.72!
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
        Me.line18.Width = 1.3!
        Me.line18.X1 = 4.42!
        Me.line18.X2 = 5.72!
        Me.line18.Y1 = 1.05!
        Me.line18.Y2 = 1.05!
        '
        'line19
        '
        Me.line19.Height = 0.0!
        Me.line19.Left = 5.77!
        Me.line19.LineWeight = 1.0!
        Me.line19.Name = "line19"
        Me.line19.Top = 1.8!
        Me.line19.Width = 4.98!
        Me.line19.X1 = 5.77!
        Me.line19.X2 = 10.75!
        Me.line19.Y1 = 1.8!
        Me.line19.Y2 = 1.8!
        '
        'line20
        '
        Me.line20.Height = 0.0!
        Me.line20.Left = 5.77!
        Me.line20.LineWeight = 1.0!
        Me.line20.Name = "line20"
        Me.line20.Top = 1.2!
        Me.line20.Width = 4.98!
        Me.line20.X1 = 5.77!
        Me.line20.X2 = 10.75!
        Me.line20.Y1 = 1.2!
        Me.line20.Y2 = 1.2!
        '
        'line21
        '
        Me.line21.Height = 0.0!
        Me.line21.Left = 5.77!
        Me.line21.LineWeight = 1.0!
        Me.line21.Name = "line21"
        Me.line21.Top = 1.05!
        Me.line21.Width = 4.98!
        Me.line21.X1 = 5.77!
        Me.line21.X2 = 10.75!
        Me.line21.Y1 = 1.05!
        Me.line21.Y2 = 1.05!
        '
        'line23
        '
        Me.line23.Height = 0.0!
        Me.line23.Left = 10.8!
        Me.line23.LineWeight = 1.0!
        Me.line23.Name = "line23"
        Me.line23.Top = 1.2!
        Me.line23.Width = 3.0!
        Me.line23.X1 = 10.8!
        Me.line23.X2 = 13.8!
        Me.line23.Y1 = 1.2!
        Me.line23.Y2 = 1.2!
        '
        'line24
        '
        Me.line24.Height = 0.0!
        Me.line24.Left = 10.8!
        Me.line24.LineWeight = 1.0!
        Me.line24.Name = "line24"
        Me.line24.Top = 1.05!
        Me.line24.Width = 3.0!
        Me.line24.X1 = 10.8!
        Me.line24.X2 = 13.8!
        Me.line24.Y1 = 1.05!
        Me.line24.Y2 = 1.05!
        '
        'line31
        '
        Me.line31.Height = 0.5999999!
        Me.line31.Left = 12.6!
        Me.line31.LineWeight = 1.0!
        Me.line31.Name = "line31"
        Me.line31.Top = 1.2!
        Me.line31.Width = 0.0!
        Me.line31.X1 = 12.6!
        Me.line31.X2 = 12.6!
        Me.line31.Y1 = 1.2!
        Me.line31.Y2 = 1.8!
        '
        'line32
        '
        Me.line32.Height = 0.5999999!
        Me.line32.Left = 13.2!
        Me.line32.LineWeight = 1.0!
        Me.line32.Name = "line32"
        Me.line32.Top = 1.2!
        Me.line32.Width = 0.0!
        Me.line32.X1 = 13.2!
        Me.line32.X2 = 13.2!
        Me.line32.Y1 = 1.2!
        Me.line32.Y2 = 1.8!
        '
        'line33
        '
        Me.line33.Height = 0.5999999!
        Me.line33.Left = 12.0!
        Me.line33.LineWeight = 1.0!
        Me.line33.Name = "line33"
        Me.line33.Top = 1.2!
        Me.line33.Width = 0.0!
        Me.line33.X1 = 12.0!
        Me.line33.X2 = 12.0!
        Me.line33.Y1 = 1.2!
        Me.line33.Y2 = 1.8!
        '
        'line34
        '
        Me.line34.Height = 0.5999999!
        Me.line34.Left = 11.4!
        Me.line34.LineWeight = 1.0!
        Me.line34.Name = "line34"
        Me.line34.Top = 1.2!
        Me.line34.Width = 0.0!
        Me.line34.X1 = 11.4!
        Me.line34.X2 = 11.4!
        Me.line34.Y1 = 1.2!
        Me.line34.Y2 = 1.8!
        '
        'line35
        '
        Me.line35.Height = 0.75!
        Me.line35.Left = 10.8!
        Me.line35.LineWeight = 1.0!
        Me.line35.Name = "line35"
        Me.line35.Top = 1.05!
        Me.line35.Width = 0.0!
        Me.line35.X1 = 10.8!
        Me.line35.X2 = 10.8!
        Me.line35.Y1 = 1.05!
        Me.line35.Y2 = 1.8!
        '
        'line36
        '
        Me.line36.Height = 0.5999999!
        Me.line36.Left = 10.4!
        Me.line36.LineWeight = 1.0!
        Me.line36.Name = "line36"
        Me.line36.Top = 1.2!
        Me.line36.Width = 0.0!
        Me.line36.X1 = 10.4!
        Me.line36.X2 = 10.4!
        Me.line36.Y1 = 1.2!
        Me.line36.Y2 = 1.8!
        '
        'line37
        '
        Me.line37.Height = 0.5999999!
        Me.line37.Left = 10.05!
        Me.line37.LineWeight = 1.0!
        Me.line37.Name = "line37"
        Me.line37.Top = 1.2!
        Me.line37.Width = 0.0!
        Me.line37.X1 = 10.05!
        Me.line37.X2 = 10.05!
        Me.line37.Y1 = 1.2!
        Me.line37.Y2 = 1.8!
        '
        'line38
        '
        Me.line38.Height = 0.5999999!
        Me.line38.Left = 9.7!
        Me.line38.LineWeight = 1.0!
        Me.line38.Name = "line38"
        Me.line38.Top = 1.2!
        Me.line38.Width = 0.0!
        Me.line38.X1 = 9.7!
        Me.line38.X2 = 9.7!
        Me.line38.Y1 = 1.2!
        Me.line38.Y2 = 1.8!
        '
        'line39
        '
        Me.line39.Height = 0.5999999!
        Me.line39.Left = 9.35!
        Me.line39.LineWeight = 1.0!
        Me.line39.Name = "line39"
        Me.line39.Top = 1.2!
        Me.line39.Width = 0.0!
        Me.line39.X1 = 9.35!
        Me.line39.X2 = 9.35!
        Me.line39.Y1 = 1.2!
        Me.line39.Y2 = 1.8!
        '
        'line40
        '
        Me.line40.Height = 0.4499999!
        Me.line40.Left = 6.47!
        Me.line40.LineWeight = 1.0!
        Me.line40.Name = "line40"
        Me.line40.Top = 1.35!
        Me.line40.Width = 0.0!
        Me.line40.X1 = 6.47!
        Me.line40.X2 = 6.47!
        Me.line40.Y1 = 1.35!
        Me.line40.Y2 = 1.8!
        '
        'line6
        '
        Me.line6.Height = 0.0!
        Me.line6.Left = 10.8!
        Me.line6.LineWeight = 1.0!
        Me.line6.Name = "line6"
        Me.line6.Top = 1.8!
        Me.line6.Width = 3.0!
        Me.line6.X1 = 10.8!
        Me.line6.X2 = 13.8!
        Me.line6.Y1 = 1.8!
        Me.line6.Y2 = 1.8!
        '
        'line12
        '
        Me.line12.Height = 0.0!
        Me.line12.Left = 5.77!
        Me.line12.LineWeight = 1.0!
        Me.line12.Name = "line12"
        Me.line12.Top = 1.35!
        Me.line12.Width = 3.53!
        Me.line12.X1 = 5.77!
        Me.line12.X2 = 9.3!
        Me.line12.Y1 = 1.35!
        Me.line12.Y2 = 1.35!
        '
        'line13
        '
        Me.line13.Height = 0.0!
        Me.line13.Left = 5.77!
        Me.line13.LineWeight = 1.0!
        Me.line13.Name = "line13"
        Me.line13.Top = 1.5!
        Me.line13.Width = 3.53!
        Me.line13.X1 = 5.77!
        Me.line13.X2 = 9.3!
        Me.line13.Y1 = 1.5!
        Me.line13.Y2 = 1.5!
        '
        'line25
        '
        Me.line25.Height = 0.4499999!
        Me.line25.Left = 7.17!
        Me.line25.LineWeight = 1.0!
        Me.line25.Name = "line25"
        Me.line25.Top = 1.35!
        Me.line25.Width = 0.0!
        Me.line25.X1 = 7.17!
        Me.line25.X2 = 7.17!
        Me.line25.Y1 = 1.35!
        Me.line25.Y2 = 1.8!
        '
        'line27
        '
        Me.line27.Height = 0.4499999!
        Me.line27.Left = 7.87!
        Me.line27.LineWeight = 1.0!
        Me.line27.Name = "line27"
        Me.line27.Top = 1.35!
        Me.line27.Width = 0.0!
        Me.line27.X1 = 7.87!
        Me.line27.X2 = 7.87!
        Me.line27.Y1 = 1.35!
        Me.line27.Y2 = 1.8!
        '
        'line29
        '
        Me.line29.Height = 0.4499999!
        Me.line29.Left = 8.57!
        Me.line29.LineWeight = 1.0!
        Me.line29.Name = "line29"
        Me.line29.Top = 1.35!
        Me.line29.Width = 0.0!
        Me.line29.X1 = 8.57!
        Me.line29.X2 = 8.57!
        Me.line29.Y1 = 1.35!
        Me.line29.Y2 = 1.8!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtSort, Me.lblReportDate, Me.reportInfo1, Me.txtDisclaimer})
        Me.PageFooter1.Height = 0.50625!
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
        Me.txtSort.Width = 13.8!
        '
        'lblReportDate
        '
        Me.lblReportDate.Height = 0.15!
        Me.lblReportDate.HyperLink = Nothing
        Me.lblReportDate.Left = 0.0!
        Me.lblReportDate.Name = "lblReportDate"
        Me.lblReportDate.Style = "font-size: 7pt; vertical-align: middle"
        Me.lblReportDate.Text = "Report Date"
        Me.lblReportDate.Top = 0.312!
        Me.lblReportDate.Width = 2.0!
        '
        'reportInfo1
        '
        Me.reportInfo1.FormatString = "Page {PageNumber} of {PageCount}"
        Me.reportInfo1.Height = 0.15!
        Me.reportInfo1.Left = 11.812!
        Me.reportInfo1.Name = "reportInfo1"
        Me.reportInfo1.Style = "font-size: 7pt; font-style: italic; text-align: right; vertical-align: middle"
        Me.reportInfo1.Top = 0.375!
        Me.reportInfo1.Width = 2.0!
        '
        'txtDisclaimer
        '
        Me.txtDisclaimer.CanShrink = True
        Me.txtDisclaimer.Height = 0.212!
        Me.txtDisclaimer.Left = 0.0!
        Me.txtDisclaimer.Name = "txtDisclaimer"
        Me.txtDisclaimer.Style = "font-size: 7pt; font-style: italic; text-align: center; vertical-align: middle"
        Me.txtDisclaimer.Text = "Disclaimer"
        Me.txtDisclaimer.Top = 0.125!
        Me.txtDisclaimer.Width = 13.812!
        '
        'rptBMFacilityDataSummary
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.25!
        Me.PageSettings.Margins.Left = 0.1!
        Me.PageSettings.Margins.Right = 0.1!
        Me.PageSettings.Margins.Top = 0.25!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 14.0!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Legal
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 13.812!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Calibri; font-style: normal; text-decoration: none; font-weight: nor" & _
            "mal; font-size: 10pt; color: Black", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
            "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.txtFuelMajorExp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCoolingMajorExp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWaterMajorExp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRefrigMajorExp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCompMajorExp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDivision2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFileNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInspectionDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSTProv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTIV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSpecificGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMajorGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtElecEquipC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBoilersC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProcEquipC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCompSysC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtElecPreMaintAdequate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSparesMaintained, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHEAdequate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBCP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFacility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientLocNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMechPreMaintAdequacy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRefrig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblWater, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCoolingTwrs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblGasFuels, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFuelMajorExp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCoolingMajorExp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblWaterMajorExp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRefrigMajorExp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMechanicalEquipment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPassive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBCP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblActive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblClientName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblReport, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.lblOccupancy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMajorGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSpecificGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCompMajorExp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblElecPreMaintCMMS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblElecEquipC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblProcEquipC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCompSysC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMechPreMaintAdequacy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblElecPreMaintAdequate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHEAdequate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblClientLocNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFacility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBoilersC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSparesMaintained, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSort, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblReportDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reportInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisclaimer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
#End Region

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private Sub rptBMFacilityDataSummary_FetchData(ByVal sender As Object, ByVal eArgs As FetchEventArgs) Handles Me.FetchData
        lblTIVGrid.Text = "TIV " & rptProperties.Currency.colFldCode & vbLf & "(millions)"
        Dim zExposureControls As ARControl() = {txtCompMajorExp, txtRefrigMajorExp, txtWaterMajorExp, txtCoolingMajorExp, txtFuelMajorExp}
        UtilReport.ActiveReport.SetItemBackColorByExposure(Me, zExposureControls, rptProperties)
        Dim zRatingScoreControls As ARControl() = {txtElecEquipC, txtBoilersC, txtProcEquipC, txtCompSysC}
        UtilReport.ActiveReport.SetItemBackColorByRating(Me, zRatingScoreControls, rptProperties)
        Dim zRatingControls As ARControl() = {txtMechPreMaintAdequacy, txtElecPreMaintAdequate, txtSparesMaintained, txtHEAdequate, txtBCP}
        UtilReport.ActiveReport.SetItemBackColorByText(Me, zRatingControls, rptProperties)
    End Sub

    Private Sub rptBMFacilityDataSummary_ReportStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportStart
        lblClientName.Text = rptProperties.ClientName 'AppSession.ClientName
        lblReportDate.Text = Now.ToString 'modActiveReport.ReportDate
    End Sub

    Private Sub rptBMFacilityDataSummary_PageStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.PageStart
        UtilReport.ActiveReport.SetFilter(Me, rptProperties)
        UtilReport.ActiveReport.SetSort(Me, rptProperties)
        UtilReport.ActiveReport.SetDisclaimer(Me, rptProperties)
    End Sub

    Private Sub rptBMFacilityDataSummary_ReportEnd(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportEnd
        DisposeParameters()
    End Sub

    Private Sub DisposeParameters()
        DataSource = Nothing
    End Sub

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties
End Class
