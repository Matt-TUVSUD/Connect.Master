Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports

Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing

Public Class rptFireHumanElementSummary
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
    Private WithEvents lblClientName As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblReport As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtSort As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblReportDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents reportInfo1 As GrapeCity.ActiveReports.SectionReportModel.ReportInfo
    Private WithEvents lblFDDistance As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblLocationDetail As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFileNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblTIVmillions As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCountry As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label7 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCity As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblSurveyDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblDivision As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblAddress As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblHERating As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblResponse As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblInspection As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblManagement As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblSprinklerValves As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFirePumps As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblAlarms As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblExtinguishers As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFireDoors As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCombSafety As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblInfrared As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblHotWork As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblContrSupv As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblImpHandling As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label26 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblGenMaint As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblSmokingControls As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblMgmtofChange As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblEOType As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblEOTraining As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblEmergPlans As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblPublicFD As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtTIV As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents textBox2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCountry As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents textBox4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents textBox5 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSurveyDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFileNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtDivision As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtHERating As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFDDistance As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSprinklerValves As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFirePumps As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtAlarms As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtExtinguishers As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFireDoors As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCombSafety As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtInfraredScans As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtHotWork As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtContrSupv As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtImpHandling As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtHousekeeping As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtGenMaint As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSmokingControls As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtMgmtofChange As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtEOType As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtEOTraining As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtEmergPlan As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents picGRCLogo As GrapeCity.ActiveReports.SectionReportModel.Picture
    Private WithEvents lblFilters As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtFilters As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lblClientLocNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFacility As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtClientLocNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFacility As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents line2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line3 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line4 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line5 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line6 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line7 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line8 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line9 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line10 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line11 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line12 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line13 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line14 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line15 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line16 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line17 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line18 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line19 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line20 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line21 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line22 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line23 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line24 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line25 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line26 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line27 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line28 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line29 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line30 As GrapeCity.ActiveReports.SectionReportModel.Line
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
    Private WithEvents line41 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line42 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line43 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line44 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line45 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line46 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line47 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line48 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line49 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line50 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line51 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line52 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line53 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line54 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line55 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line56 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line57 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line58 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line59 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line60 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line61 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line62 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line63 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line64 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line65 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line66 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line67 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line68 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtPublicFD As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtDisclaimer As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents PageFooter1 As GrapeCity.ActiveReports.SectionReportModel.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptFireHumanElementSummary))
        Me.PageHeader1 = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.txtFilters = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblLocationDetail = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblHERating = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSprinklerValves = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblClientName = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblReport = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFDDistance = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFileNo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblTIVmillions = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblCountry = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label7 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblCity = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSurveyDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblDivision = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblAddress = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblResponse = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblInspection = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblManagement = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFirePumps = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblAlarms = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblExtinguishers = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFireDoors = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblCombSafety = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblInfrared = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblHotWork = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblContrSupv = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblImpHandling = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label26 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblGenMaint = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSmokingControls = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblMgmtofChange = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblEOType = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblEOTraining = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblEmergPlans = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPublicFD = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.picGRCLogo = New GrapeCity.ActiveReports.SectionReportModel.Picture()
        Me.lblFilters = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblClientLocNo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFacility = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line5 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line6 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line7 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line8 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line9 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line10 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line11 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line12 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line13 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line14 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line15 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line16 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line17 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line18 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line19 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line20 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line53 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line54 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line55 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line56 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line57 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line58 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line59 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line60 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line61 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line62 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line63 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line64 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line65 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line66 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line67 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line68 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Detail1 = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.txtSurveyDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtClientLocNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.textBox5 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtTIV = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.textBox4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFileNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtDivision = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtHERating = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFDDistance = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSprinklerValves = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFirePumps = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtAlarms = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtExtinguishers = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFireDoors = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCombSafety = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtInfraredScans = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtHotWork = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtContrSupv = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtImpHandling = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtHousekeeping = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtGenMaint = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSmokingControls = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMgmtofChange = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtEOType = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtEOTraining = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtEmergPlan = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPublicFD = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFacility = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.line21 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line22 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line23 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line24 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line25 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line26 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line27 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line28 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line29 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line32 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line33 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line36 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line37 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line38 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line39 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line40 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line41 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line42 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line43 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line44 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line46 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line47 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line48 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line49 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line50 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line51 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line52 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line35 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line34 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line45 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.textBox2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line31 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtCountry = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.line30 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.PageFooter1 = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.txtSort = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblReportDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.reportInfo1 = New GrapeCity.ActiveReports.SectionReportModel.ReportInfo()
        Me.txtDisclaimer = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblLocationDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHERating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSprinklerValves, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblClientName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFDDistance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFileNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTIVmillions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSurveyDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDivision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblResponse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblInspection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblManagement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFirePumps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAlarms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblExtinguishers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFireDoors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCombSafety, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblInfrared, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHotWork, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblContrSupv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblImpHandling, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblGenMaint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSmokingControls, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMgmtofChange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblEOType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblEOTraining, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblEmergPlans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPublicFD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGRCLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblClientLocNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFacility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSurveyDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientLocNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTIV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFileNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDivision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHERating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFDDistance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSprinklerValves, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFirePumps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlarms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExtinguishers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFireDoors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCombSafety, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInfraredScans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHotWork, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContrSupv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImpHandling, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHousekeeping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGenMaint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSmokingControls, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMgmtofChange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEOType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEOTraining, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmergPlan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPublicFD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFacility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblReportDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisclaimer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.BackColor = System.Drawing.Color.White
        Me.PageHeader1.CanShrink = True
        Me.PageHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtFilters, Me.lblLocationDetail, Me.lblHERating, Me.lblSprinklerValves, Me.lblClientName, Me.lblReport, Me.lblFDDistance, Me.lblFileNo, Me.lblTIVmillions, Me.lblCountry, Me.label7, Me.lblCity, Me.lblSurveyDate, Me.lblDivision, Me.lblAddress, Me.lblResponse, Me.lblInspection, Me.lblManagement, Me.lblFirePumps, Me.lblAlarms, Me.lblExtinguishers, Me.lblFireDoors, Me.lblCombSafety, Me.lblInfrared, Me.lblHotWork, Me.lblContrSupv, Me.lblImpHandling, Me.label26, Me.lblGenMaint, Me.lblSmokingControls, Me.lblMgmtofChange, Me.lblEOType, Me.lblEOTraining, Me.lblEmergPlans, Me.lblPublicFD, Me.picGRCLogo, Me.lblFilters, Me.lblClientLocNo, Me.lblFacility, Me.line2, Me.line3, Me.line4, Me.line5, Me.line6, Me.line7, Me.line8, Me.line9, Me.line10, Me.line11, Me.line12, Me.line13, Me.line14, Me.line15, Me.line16, Me.line17, Me.line18, Me.line19, Me.line20, Me.line53, Me.line54, Me.line55, Me.line56, Me.line57, Me.line58, Me.line59, Me.line60, Me.line61, Me.line62, Me.line63, Me.line64, Me.line65, Me.line66, Me.line67, Me.line68})
        Me.PageHeader1.Height = 1.5!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'txtFilters
        '
        Me.txtFilters.CanShrink = True
        Me.txtFilters.Height = 0.15!
        Me.txtFilters.Left = 0.52!
        Me.txtFilters.Name = "txtFilters"
        Me.txtFilters.Style = "background-color: White; font-family: Calibri; font-size: 8pt; vertical-align: mi" & _
    "ddle"
        Me.txtFilters.Text = Nothing
        Me.txtFilters.Top = 0.85!
        Me.txtFilters.Width = 12.88!
        '
        'lblLocationDetail
        '
        Me.lblLocationDetail.Height = 0.15!
        Me.lblLocationDetail.HyperLink = Nothing
        Me.lblLocationDetail.Left = 0.0!
        Me.lblLocationDetail.Name = "lblLocationDetail"
        Me.lblLocationDetail.Style = "background-color: White; font-family: Calibri; font-size: 8pt; font-weight: bold;" & _
    " text-align: center; vertical-align: middle; ddo-char-set: 1"
        Me.lblLocationDetail.Text = "Location Detail"
        Me.lblLocationDetail.Top = 1.05!
        Me.lblLocationDetail.Width = 4.7!
        '
        'lblHERating
        '
        Me.lblHERating.Height = 0.3!
        Me.lblHERating.HyperLink = Nothing
        Me.lblHERating.Left = 4.37!
        Me.lblHERating.Name = "lblHERating"
        Me.lblHERating.Style = "background-color: White; font-family: Calibri; font-size: 7pt; text-align: center" & _
    "; ddo-char-set: 1"
        Me.lblHERating.Text = "HE Rating"
        Me.lblHERating.Top = 1.2!
        Me.lblHERating.Width = 0.33!
        '
        'lblSprinklerValves
        '
        Me.lblSprinklerValves.Height = 0.3!
        Me.lblSprinklerValves.HyperLink = Nothing
        Me.lblSprinklerValves.Left = 4.75!
        Me.lblSprinklerValves.Name = "lblSprinklerValves"
        Me.lblSprinklerValves.Style = "background-color: White; font-family: Calibri; font-size: 7pt; text-align: center" & _
    ""
        Me.lblSprinklerValves.Text = "Sprinkler Valves"
        Me.lblSprinklerValves.Top = 1.2!
        Me.lblSprinklerValves.Width = 0.45!
        '
        'lblClientName
        '
        Me.lblClientName.Height = 0.25!
        Me.lblClientName.HyperLink = Nothing
        Me.lblClientName.Left = 9.05!
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
        Me.lblReport.Left = 9.05!
        Me.lblReport.Name = "lblReport"
        Me.lblReport.Style = "font-size: 12pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblReport.Text = "Fire Human Element Summary"
        Me.lblReport.Top = 0.35!
        Me.lblReport.Width = 4.3!
        '
        'lblFDDistance
        '
        Me.lblFDDistance.Height = 0.3!
        Me.lblFDDistance.HyperLink = Nothing
        Me.lblFDDistance.Left = 12.95!
        Me.lblFDDistance.Name = "lblFDDistance"
        Me.lblFDDistance.Style = "background-color: White; font-family: Calibri; font-size: 7pt; text-align: center" & _
    ""
        Me.lblFDDistance.Text = "F.D. Distance"
        Me.lblFDDistance.Top = 1.2!
        Me.lblFDDistance.Width = 0.45!
        '
        'lblFileNo
        '
        Me.lblFileNo.Height = 0.15!
        Me.lblFileNo.HyperLink = Nothing
        Me.lblFileNo.Left = 0.0!
        Me.lblFileNo.Name = "lblFileNo"
        Me.lblFileNo.Style = "background-color: White; font-family: Calibri; font-size: 7pt; ddo-char-set: 1"
        Me.lblFileNo.Text = "File No."
        Me.lblFileNo.Top = 1.2!
        Me.lblFileNo.Width = 0.52!
        '
        'lblTIVmillions
        '
        Me.lblTIVmillions.Height = 0.3!
        Me.lblTIVmillions.HyperLink = Nothing
        Me.lblTIVmillions.Left = 3.898!
        Me.lblTIVmillions.Name = "lblTIVmillions"
        Me.lblTIVmillions.Style = "background-color: White; font-family: Calibri; font-size: 7pt; text-align: center" & _
    "; ddo-char-set: 1"
        Me.lblTIVmillions.Text = "TIV USD (millions)"
        Me.lblTIVmillions.Top = 1.2!
        Me.lblTIVmillions.Width = 0.4719996!
        '
        'lblCountry
        '
        Me.lblCountry.Height = 0.1458!
        Me.lblCountry.HyperLink = Nothing
        Me.lblCountry.Left = 3.2!
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Style = "background-color: White; font-family: Calibri; font-size: 7pt; ddo-char-set: 1"
        Me.lblCountry.Text = "Country"
        Me.lblCountry.Top = 1.2!
        Me.lblCountry.Width = 0.6980002!
        '
        'label7
        '
        Me.label7.Height = 0.15!
        Me.label7.HyperLink = Nothing
        Me.label7.Left = 2.85!
        Me.label7.Name = "label7"
        Me.label7.Style = "background-color: White; font-family: Calibri; font-size: 7pt; ddo-char-set: 1"
        Me.label7.Text = "St/Pr"
        Me.label7.Top = 1.2!
        Me.label7.Width = 0.35!
        '
        'lblCity
        '
        Me.lblCity.Height = 0.15!
        Me.lblCity.HyperLink = Nothing
        Me.lblCity.Left = 1.9!
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Style = "background-color: White; font-family: Calibri; font-size: 7pt; ddo-char-set: 1"
        Me.lblCity.Text = "City/"
        Me.lblCity.Top = 1.2!
        Me.lblCity.Width = 0.95!
        '
        'lblSurveyDate
        '
        Me.lblSurveyDate.Height = 0.1458!
        Me.lblSurveyDate.HyperLink = Nothing
        Me.lblSurveyDate.Left = 0.52!
        Me.lblSurveyDate.Name = "lblSurveyDate"
        Me.lblSurveyDate.Style = "background-color: White; font-family: Calibri; font-size: 7pt; ddo-char-set: 1"
        Me.lblSurveyDate.Text = "Date of Insp."
        Me.lblSurveyDate.Top = 1.2!
        Me.lblSurveyDate.Width = 0.58!
        '
        'lblDivision
        '
        Me.lblDivision.Height = 0.1458!
        Me.lblDivision.HyperLink = Nothing
        Me.lblDivision.Left = 0.0!
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.Style = "background-color: White; font-family: Calibri; font-size: 7pt; ddo-char-set: 1"
        Me.lblDivision.Text = "Division"
        Me.lblDivision.Top = 1.35!
        Me.lblDivision.Width = 1.1!
        '
        'lblAddress
        '
        Me.lblAddress.Height = 0.1458!
        Me.lblAddress.HyperLink = Nothing
        Me.lblAddress.Left = 1.9!
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Style = "background-color: White; font-family: Calibri; font-size: 7pt; ddo-char-set: 1"
        Me.lblAddress.Text = "Address"
        Me.lblAddress.Top = 1.35!
        Me.lblAddress.Width = 2.05!
        '
        'lblResponse
        '
        Me.lblResponse.Height = 0.1458!
        Me.lblResponse.HyperLink = Nothing
        Me.lblResponse.Left = 11.15!
        Me.lblResponse.Name = "lblResponse"
        Me.lblResponse.Style = "background-color: White; font-family: Calibri; font-size: 8pt; font-weight: bold;" & _
    " text-align: center; vertical-align: middle"
        Me.lblResponse.Text = "Response"
        Me.lblResponse.Top = 1.05!
        Me.lblResponse.Width = 2.25!
        '
        'lblInspection
        '
        Me.lblInspection.Height = 0.1458!
        Me.lblInspection.HyperLink = Nothing
        Me.lblInspection.Left = 4.75!
        Me.lblInspection.Name = "lblInspection"
        Me.lblInspection.Style = "background-color: White; font-family: Calibri; font-size: 8pt; font-weight: bold;" & _
    " text-align: center; vertical-align: middle"
        Me.lblInspection.Text = "Inspection/Testing"
        Me.lblInspection.Top = 1.05!
        Me.lblInspection.Width = 3.15!
        '
        'lblManagement
        '
        Me.lblManagement.Height = 0.1458!
        Me.lblManagement.HyperLink = Nothing
        Me.lblManagement.Left = 7.95!
        Me.lblManagement.Name = "lblManagement"
        Me.lblManagement.Style = "background-color: White; font-family: Calibri; font-size: 8pt; font-weight: bold;" & _
    " text-align: center; vertical-align: middle"
        Me.lblManagement.Text = "Management"
        Me.lblManagement.Top = 1.05!
        Me.lblManagement.Width = 3.15!
        '
        'lblFirePumps
        '
        Me.lblFirePumps.Height = 0.3!
        Me.lblFirePumps.HyperLink = Nothing
        Me.lblFirePumps.Left = 5.2!
        Me.lblFirePumps.Name = "lblFirePumps"
        Me.lblFirePumps.Style = "background-color: White; font-family: Calibri; font-size: 7pt; text-align: center" & _
    ""
        Me.lblFirePumps.Text = "Fire Pumps"
        Me.lblFirePumps.Top = 1.2!
        Me.lblFirePumps.Width = 0.45!
        '
        'lblAlarms
        '
        Me.lblAlarms.Height = 0.3!
        Me.lblAlarms.HyperLink = Nothing
        Me.lblAlarms.Left = 5.65!
        Me.lblAlarms.Name = "lblAlarms"
        Me.lblAlarms.Style = "background-color: White; font-family: Calibri; font-size: 7pt; text-align: center" & _
    ""
        Me.lblAlarms.Text = "Alarms"
        Me.lblAlarms.Top = 1.2!
        Me.lblAlarms.Width = 0.45!
        '
        'lblExtinguishers
        '
        Me.lblExtinguishers.Height = 0.3!
        Me.lblExtinguishers.HyperLink = Nothing
        Me.lblExtinguishers.Left = 6.1!
        Me.lblExtinguishers.Name = "lblExtinguishers"
        Me.lblExtinguishers.Style = "background-color: White; font-family: Calibri; font-size: 7pt; text-align: center" & _
    ""
        Me.lblExtinguishers.Text = "Exting-uishers"
        Me.lblExtinguishers.Top = 1.2!
        Me.lblExtinguishers.Width = 0.45!
        '
        'lblFireDoors
        '
        Me.lblFireDoors.Height = 0.3!
        Me.lblFireDoors.HyperLink = Nothing
        Me.lblFireDoors.Left = 6.55!
        Me.lblFireDoors.Name = "lblFireDoors"
        Me.lblFireDoors.Style = "background-color: White; font-family: Calibri; font-size: 7pt; text-align: center" & _
    ""
        Me.lblFireDoors.Text = "Fire Doors"
        Me.lblFireDoors.Top = 1.2!
        Me.lblFireDoors.Width = 0.45!
        '
        'lblCombSafety
        '
        Me.lblCombSafety.Height = 0.3!
        Me.lblCombSafety.HyperLink = Nothing
        Me.lblCombSafety.Left = 7.0!
        Me.lblCombSafety.Name = "lblCombSafety"
        Me.lblCombSafety.Style = "background-color: White; font-family: Calibri; font-size: 7pt; text-align: center" & _
    ""
        Me.lblCombSafety.Text = "Comb. Safety"
        Me.lblCombSafety.Top = 1.2!
        Me.lblCombSafety.Width = 0.45!
        '
        'lblInfrared
        '
        Me.lblInfrared.Height = 0.3!
        Me.lblInfrared.HyperLink = Nothing
        Me.lblInfrared.Left = 7.45!
        Me.lblInfrared.Name = "lblInfrared"
        Me.lblInfrared.Style = "background-color: White; font-family: Calibri; font-size: 7pt; text-align: center" & _
    ""
        Me.lblInfrared.Text = "Infrared Scans"
        Me.lblInfrared.Top = 1.2!
        Me.lblInfrared.Width = 0.45!
        '
        'lblHotWork
        '
        Me.lblHotWork.Height = 0.3!
        Me.lblHotWork.HyperLink = Nothing
        Me.lblHotWork.Left = 7.95!
        Me.lblHotWork.Name = "lblHotWork"
        Me.lblHotWork.Style = "background-color: White; font-family: Calibri; font-size: 7pt; text-align: center" & _
    ""
        Me.lblHotWork.Text = "Hot Work"
        Me.lblHotWork.Top = 1.2!
        Me.lblHotWork.Width = 0.45!
        '
        'lblContrSupv
        '
        Me.lblContrSupv.Height = 0.3!
        Me.lblContrSupv.HyperLink = Nothing
        Me.lblContrSupv.Left = 8.4!
        Me.lblContrSupv.Name = "lblContrSupv"
        Me.lblContrSupv.Style = "background-color: White; font-family: Calibri; font-size: 7pt; text-align: center" & _
    ""
        Me.lblContrSupv.Text = "Contr. Supv"
        Me.lblContrSupv.Top = 1.2!
        Me.lblContrSupv.Width = 0.45!
        '
        'lblImpHandling
        '
        Me.lblImpHandling.Height = 0.3!
        Me.lblImpHandling.HyperLink = Nothing
        Me.lblImpHandling.Left = 8.85!
        Me.lblImpHandling.Name = "lblImpHandling"
        Me.lblImpHandling.Style = "background-color: White; font-family: Calibri; font-size: 7pt; text-align: center" & _
    ""
        Me.lblImpHandling.Text = "Imp. Handling"
        Me.lblImpHandling.Top = 1.2!
        Me.lblImpHandling.Width = 0.45!
        '
        'label26
        '
        Me.label26.Height = 0.3!
        Me.label26.HyperLink = Nothing
        Me.label26.Left = 9.3!
        Me.label26.Name = "label26"
        Me.label26.Style = "background-color: White; font-family: Calibri; font-size: 7pt; text-align: center" & _
    ""
        Me.label26.Text = "House-keeping"
        Me.label26.Top = 1.2!
        Me.label26.Width = 0.45!
        '
        'lblGenMaint
        '
        Me.lblGenMaint.Height = 0.3!
        Me.lblGenMaint.HyperLink = Nothing
        Me.lblGenMaint.Left = 9.75!
        Me.lblGenMaint.Name = "lblGenMaint"
        Me.lblGenMaint.Style = "background-color: White; font-family: Calibri; font-size: 7pt; text-align: center" & _
    ""
        Me.lblGenMaint.Text = "Gen. Maint."
        Me.lblGenMaint.Top = 1.2!
        Me.lblGenMaint.Width = 0.45!
        '
        'lblSmokingControls
        '
        Me.lblSmokingControls.Height = 0.3!
        Me.lblSmokingControls.HyperLink = Nothing
        Me.lblSmokingControls.Left = 10.2!
        Me.lblSmokingControls.Name = "lblSmokingControls"
        Me.lblSmokingControls.Style = "background-color: White; font-family: Calibri; font-size: 7pt; text-align: center" & _
    ""
        Me.lblSmokingControls.Text = "Smoking Controls"
        Me.lblSmokingControls.Top = 1.2!
        Me.lblSmokingControls.Width = 0.45!
        '
        'lblMgmtofChange
        '
        Me.lblMgmtofChange.Height = 0.3!
        Me.lblMgmtofChange.HyperLink = Nothing
        Me.lblMgmtofChange.Left = 10.65!
        Me.lblMgmtofChange.Name = "lblMgmtofChange"
        Me.lblMgmtofChange.Style = "background-color: White; font-family: Calibri; font-size: 7pt; text-align: center" & _
    ""
        Me.lblMgmtofChange.Text = "Mgmt. of Change"
        Me.lblMgmtofChange.Top = 1.2!
        Me.lblMgmtofChange.Width = 0.45!
        '
        'lblEOType
        '
        Me.lblEOType.Height = 0.3!
        Me.lblEOType.HyperLink = Nothing
        Me.lblEOType.Left = 11.15!
        Me.lblEOType.Name = "lblEOType"
        Me.lblEOType.Style = "background-color: White; font-family: Calibri; font-size: 7pt; text-align: center" & _
    ""
        Me.lblEOType.Text = "EO Type"
        Me.lblEOType.Top = 1.2!
        Me.lblEOType.Width = 0.45!
        '
        'lblEOTraining
        '
        Me.lblEOTraining.Height = 0.3!
        Me.lblEOTraining.HyperLink = Nothing
        Me.lblEOTraining.Left = 11.6!
        Me.lblEOTraining.Name = "lblEOTraining"
        Me.lblEOTraining.Style = "background-color: White; font-family: Calibri; font-size: 7pt; text-align: center" & _
    ""
        Me.lblEOTraining.Text = "EO Training"
        Me.lblEOTraining.Top = 1.2!
        Me.lblEOTraining.Width = 0.45!
        '
        'lblEmergPlans
        '
        Me.lblEmergPlans.Height = 0.3!
        Me.lblEmergPlans.HyperLink = Nothing
        Me.lblEmergPlans.Left = 12.05!
        Me.lblEmergPlans.Name = "lblEmergPlans"
        Me.lblEmergPlans.Style = "background-color: White; font-family: Calibri; font-size: 7pt; text-align: center" & _
    ""
        Me.lblEmergPlans.Text = "Emerg. Plan"
        Me.lblEmergPlans.Top = 1.2!
        Me.lblEmergPlans.Width = 0.45!
        '
        'lblPublicFD
        '
        Me.lblPublicFD.Height = 0.3!
        Me.lblPublicFD.HyperLink = Nothing
        Me.lblPublicFD.Left = 12.5!
        Me.lblPublicFD.Name = "lblPublicFD"
        Me.lblPublicFD.Style = "background-color: White; font-family: Calibri; font-size: 7pt; text-align: center" & _
    ""
        Me.lblPublicFD.Text = "Public F.D."
        Me.lblPublicFD.Top = 1.2!
        Me.lblPublicFD.Width = 0.45!
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
        'lblFilters
        '
        Me.lblFilters.Height = 0.15!
        Me.lblFilters.HyperLink = Nothing
        Me.lblFilters.Left = 0.05!
        Me.lblFilters.Name = "lblFilters"
        Me.lblFilters.Style = "background-color: White; font-family: Calibri; font-size: 8pt; font-weight: bold;" & _
    " vertical-align: middle"
        Me.lblFilters.Text = "Filters:"
        Me.lblFilters.Top = 0.85!
        Me.lblFilters.Width = 0.47!
        '
        'lblClientLocNo
        '
        Me.lblClientLocNo.Height = 0.1458!
        Me.lblClientLocNo.HyperLink = Nothing
        Me.lblClientLocNo.Left = 1.1!
        Me.lblClientLocNo.Name = "lblClientLocNo"
        Me.lblClientLocNo.Style = "background-color: White; font-family: Calibri; font-size: 7pt; ddo-char-set: 1"
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
        Me.lblFacility.Style = "background-color: White; font-family: Calibri; font-size: 7pt; ddo-char-set: 1"
        Me.lblFacility.Text = "Facility"
        Me.lblFacility.Top = 1.35!
        Me.lblFacility.Width = 0.8!
        '
        'line2
        '
        Me.line2.Height = 0.0!
        Me.line2.Left = 4.75!
        Me.line2.LineWeight = 1.0!
        Me.line2.Name = "line2"
        Me.line2.Top = 1.2!
        Me.line2.Width = 3.15!
        Me.line2.X1 = 4.75!
        Me.line2.X2 = 7.9!
        Me.line2.Y1 = 1.2!
        Me.line2.Y2 = 1.2!
        '
        'line3
        '
        Me.line3.Height = 0.3!
        Me.line3.Left = 12.95!
        Me.line3.LineWeight = 1.0!
        Me.line3.Name = "line3"
        Me.line3.Top = 1.2!
        Me.line3.Width = 0.0!
        Me.line3.X1 = 12.95!
        Me.line3.X2 = 12.95!
        Me.line3.Y1 = 1.2!
        Me.line3.Y2 = 1.5!
        '
        'line4
        '
        Me.line4.Height = 0.3!
        Me.line4.Left = 5.2!
        Me.line4.LineWeight = 1.0!
        Me.line4.Name = "line4"
        Me.line4.Top = 1.2!
        Me.line4.Width = 0.0!
        Me.line4.X1 = 5.2!
        Me.line4.X2 = 5.2!
        Me.line4.Y1 = 1.2!
        Me.line4.Y2 = 1.5!
        '
        'line5
        '
        Me.line5.Height = 0.3!
        Me.line5.Left = 5.65!
        Me.line5.LineWeight = 1.0!
        Me.line5.Name = "line5"
        Me.line5.Top = 1.2!
        Me.line5.Width = 0.0!
        Me.line5.X1 = 5.65!
        Me.line5.X2 = 5.65!
        Me.line5.Y1 = 1.2!
        Me.line5.Y2 = 1.5!
        '
        'line6
        '
        Me.line6.Height = 0.3!
        Me.line6.Left = 6.1!
        Me.line6.LineWeight = 1.0!
        Me.line6.Name = "line6"
        Me.line6.Top = 1.2!
        Me.line6.Width = 0.0!
        Me.line6.X1 = 6.1!
        Me.line6.X2 = 6.1!
        Me.line6.Y1 = 1.2!
        Me.line6.Y2 = 1.5!
        '
        'line7
        '
        Me.line7.Height = 0.3!
        Me.line7.Left = 6.55!
        Me.line7.LineWeight = 1.0!
        Me.line7.Name = "line7"
        Me.line7.Top = 1.2!
        Me.line7.Width = 0.0!
        Me.line7.X1 = 6.55!
        Me.line7.X2 = 6.55!
        Me.line7.Y1 = 1.2!
        Me.line7.Y2 = 1.5!
        '
        'line8
        '
        Me.line8.Height = 0.3!
        Me.line8.Left = 7.0!
        Me.line8.LineWeight = 1.0!
        Me.line8.Name = "line8"
        Me.line8.Top = 1.2!
        Me.line8.Width = 0.0!
        Me.line8.X1 = 7.0!
        Me.line8.X2 = 7.0!
        Me.line8.Y1 = 1.2!
        Me.line8.Y2 = 1.5!
        '
        'line9
        '
        Me.line9.Height = 0.3!
        Me.line9.Left = 7.45!
        Me.line9.LineWeight = 1.0!
        Me.line9.Name = "line9"
        Me.line9.Top = 1.2!
        Me.line9.Width = 0.0!
        Me.line9.X1 = 7.45!
        Me.line9.X2 = 7.45!
        Me.line9.Y1 = 1.2!
        Me.line9.Y2 = 1.5!
        '
        'line10
        '
        Me.line10.Height = 0.3!
        Me.line10.Left = 8.4!
        Me.line10.LineWeight = 1.0!
        Me.line10.Name = "line10"
        Me.line10.Top = 1.2!
        Me.line10.Width = 0.0!
        Me.line10.X1 = 8.4!
        Me.line10.X2 = 8.4!
        Me.line10.Y1 = 1.2!
        Me.line10.Y2 = 1.5!
        '
        'line11
        '
        Me.line11.Height = 0.3!
        Me.line11.Left = 8.85!
        Me.line11.LineWeight = 1.0!
        Me.line11.Name = "line11"
        Me.line11.Top = 1.2!
        Me.line11.Width = 0.0!
        Me.line11.X1 = 8.85!
        Me.line11.X2 = 8.85!
        Me.line11.Y1 = 1.2!
        Me.line11.Y2 = 1.5!
        '
        'line12
        '
        Me.line12.Height = 0.3!
        Me.line12.Left = 9.3!
        Me.line12.LineWeight = 1.0!
        Me.line12.Name = "line12"
        Me.line12.Top = 1.2!
        Me.line12.Width = 0.0!
        Me.line12.X1 = 9.3!
        Me.line12.X2 = 9.3!
        Me.line12.Y1 = 1.2!
        Me.line12.Y2 = 1.5!
        '
        'line13
        '
        Me.line13.Height = 0.3!
        Me.line13.Left = 9.75!
        Me.line13.LineWeight = 1.0!
        Me.line13.Name = "line13"
        Me.line13.Top = 1.2!
        Me.line13.Width = 0.0!
        Me.line13.X1 = 9.75!
        Me.line13.X2 = 9.75!
        Me.line13.Y1 = 1.2!
        Me.line13.Y2 = 1.5!
        '
        'line14
        '
        Me.line14.Height = 0.3!
        Me.line14.Left = 10.2!
        Me.line14.LineWeight = 1.0!
        Me.line14.Name = "line14"
        Me.line14.Top = 1.2!
        Me.line14.Width = 0.0!
        Me.line14.X1 = 10.2!
        Me.line14.X2 = 10.2!
        Me.line14.Y1 = 1.2!
        Me.line14.Y2 = 1.5!
        '
        'line15
        '
        Me.line15.Height = 0.3!
        Me.line15.Left = 10.65!
        Me.line15.LineWeight = 1.0!
        Me.line15.Name = "line15"
        Me.line15.Top = 1.2!
        Me.line15.Width = 0.0!
        Me.line15.X1 = 10.65!
        Me.line15.X2 = 10.65!
        Me.line15.Y1 = 1.2!
        Me.line15.Y2 = 1.5!
        '
        'line16
        '
        Me.line16.Height = 0.0!
        Me.line16.Left = 7.95!
        Me.line16.LineWeight = 1.0!
        Me.line16.Name = "line16"
        Me.line16.Top = 1.2!
        Me.line16.Width = 3.150001!
        Me.line16.X1 = 7.95!
        Me.line16.X2 = 11.1!
        Me.line16.Y1 = 1.2!
        Me.line16.Y2 = 1.2!
        '
        'line17
        '
        Me.line17.Height = 0.0!
        Me.line17.Left = 11.15!
        Me.line17.LineWeight = 1.0!
        Me.line17.Name = "line17"
        Me.line17.Top = 1.2!
        Me.line17.Width = 2.25!
        Me.line17.X1 = 11.15!
        Me.line17.X2 = 13.4!
        Me.line17.Y1 = 1.2!
        Me.line17.Y2 = 1.2!
        '
        'line18
        '
        Me.line18.Height = 0.3!
        Me.line18.Left = 11.6!
        Me.line18.LineWeight = 1.0!
        Me.line18.Name = "line18"
        Me.line18.Top = 1.2!
        Me.line18.Width = 0.0!
        Me.line18.X1 = 11.6!
        Me.line18.X2 = 11.6!
        Me.line18.Y1 = 1.2!
        Me.line18.Y2 = 1.5!
        '
        'line19
        '
        Me.line19.Height = 0.3!
        Me.line19.Left = 12.05!
        Me.line19.LineWeight = 1.0!
        Me.line19.Name = "line19"
        Me.line19.Top = 1.2!
        Me.line19.Width = 0.0!
        Me.line19.X1 = 12.05!
        Me.line19.X2 = 12.05!
        Me.line19.Y1 = 1.2!
        Me.line19.Y2 = 1.5!
        '
        'line20
        '
        Me.line20.Height = 0.3!
        Me.line20.Left = 12.5!
        Me.line20.LineWeight = 1.0!
        Me.line20.Name = "line20"
        Me.line20.Top = 1.2!
        Me.line20.Width = 0.0!
        Me.line20.X1 = 12.5!
        Me.line20.X2 = 12.5!
        Me.line20.Y1 = 1.2!
        Me.line20.Y2 = 1.5!
        '
        'line53
        '
        Me.line53.Height = 0.0!
        Me.line53.Left = 4.75!
        Me.line53.LineWeight = 1.0!
        Me.line53.Name = "line53"
        Me.line53.Top = 1.05!
        Me.line53.Width = 3.15!
        Me.line53.X1 = 4.75!
        Me.line53.X2 = 7.9!
        Me.line53.Y1 = 1.05!
        Me.line53.Y2 = 1.05!
        '
        'line54
        '
        Me.line54.Height = 0.0!
        Me.line54.Left = 4.75!
        Me.line54.LineWeight = 1.0!
        Me.line54.Name = "line54"
        Me.line54.Top = 1.5!
        Me.line54.Width = 3.15!
        Me.line54.X1 = 4.75!
        Me.line54.X2 = 7.9!
        Me.line54.Y1 = 1.5!
        Me.line54.Y2 = 1.5!
        '
        'line55
        '
        Me.line55.Height = 0.0!
        Me.line55.Left = 0.0!
        Me.line55.LineWeight = 1.0!
        Me.line55.Name = "line55"
        Me.line55.Top = 1.05!
        Me.line55.Width = 4.7!
        Me.line55.X1 = 0.0!
        Me.line55.X2 = 4.7!
        Me.line55.Y1 = 1.05!
        Me.line55.Y2 = 1.05!
        '
        'line56
        '
        Me.line56.Height = 0.0!
        Me.line56.Left = 0.0!
        Me.line56.LineWeight = 1.0!
        Me.line56.Name = "line56"
        Me.line56.Top = 1.5!
        Me.line56.Width = 4.7!
        Me.line56.X1 = 0.0!
        Me.line56.X2 = 4.7!
        Me.line56.Y1 = 1.5!
        Me.line56.Y2 = 1.5!
        '
        'line57
        '
        Me.line57.Height = 0.45!
        Me.line57.Left = 4.75!
        Me.line57.LineWeight = 1.0!
        Me.line57.Name = "line57"
        Me.line57.Top = 1.05!
        Me.line57.Width = 0.0!
        Me.line57.X1 = 4.75!
        Me.line57.X2 = 4.75!
        Me.line57.Y1 = 1.05!
        Me.line57.Y2 = 1.5!
        '
        'line58
        '
        Me.line58.Height = 0.45!
        Me.line58.Left = 4.7!
        Me.line58.LineWeight = 1.0!
        Me.line58.Name = "line58"
        Me.line58.Top = 1.05!
        Me.line58.Width = 0.0!
        Me.line58.X1 = 4.7!
        Me.line58.X2 = 4.7!
        Me.line58.Y1 = 1.05!
        Me.line58.Y2 = 1.5!
        '
        'line59
        '
        Me.line59.Height = 0.45!
        Me.line59.Left = 0.0!
        Me.line59.LineWeight = 1.0!
        Me.line59.Name = "line59"
        Me.line59.Top = 1.05!
        Me.line59.Width = 0.0!
        Me.line59.X1 = 0.0!
        Me.line59.X2 = 0.0!
        Me.line59.Y1 = 1.05!
        Me.line59.Y2 = 1.5!
        '
        'line60
        '
        Me.line60.Height = 0.45!
        Me.line60.Left = 7.9!
        Me.line60.LineWeight = 1.0!
        Me.line60.Name = "line60"
        Me.line60.Top = 1.05!
        Me.line60.Width = 0.0!
        Me.line60.X1 = 7.9!
        Me.line60.X2 = 7.9!
        Me.line60.Y1 = 1.05!
        Me.line60.Y2 = 1.5!
        '
        'line61
        '
        Me.line61.Height = 0.45!
        Me.line61.Left = 7.95!
        Me.line61.LineWeight = 1.0!
        Me.line61.Name = "line61"
        Me.line61.Top = 1.05!
        Me.line61.Width = 0.0!
        Me.line61.X1 = 7.95!
        Me.line61.X2 = 7.95!
        Me.line61.Y1 = 1.05!
        Me.line61.Y2 = 1.5!
        '
        'line62
        '
        Me.line62.Height = 0.45!
        Me.line62.Left = 11.1!
        Me.line62.LineWeight = 1.0!
        Me.line62.Name = "line62"
        Me.line62.Top = 1.05!
        Me.line62.Width = 0.0!
        Me.line62.X1 = 11.1!
        Me.line62.X2 = 11.1!
        Me.line62.Y1 = 1.05!
        Me.line62.Y2 = 1.5!
        '
        'line63
        '
        Me.line63.Height = 0.0!
        Me.line63.Left = 7.95!
        Me.line63.LineWeight = 1.0!
        Me.line63.Name = "line63"
        Me.line63.Top = 1.5!
        Me.line63.Width = 3.150001!
        Me.line63.X1 = 7.95!
        Me.line63.X2 = 11.1!
        Me.line63.Y1 = 1.5!
        Me.line63.Y2 = 1.5!
        '
        'line64
        '
        Me.line64.Height = 0.0!
        Me.line64.Left = 7.95!
        Me.line64.LineWeight = 1.0!
        Me.line64.Name = "line64"
        Me.line64.Top = 1.05!
        Me.line64.Width = 3.150001!
        Me.line64.X1 = 7.95!
        Me.line64.X2 = 11.1!
        Me.line64.Y1 = 1.05!
        Me.line64.Y2 = 1.05!
        '
        'line65
        '
        Me.line65.Height = 0.0!
        Me.line65.Left = 11.15!
        Me.line65.LineWeight = 1.0!
        Me.line65.Name = "line65"
        Me.line65.Top = 1.05!
        Me.line65.Width = 2.25!
        Me.line65.X1 = 11.15!
        Me.line65.X2 = 13.4!
        Me.line65.Y1 = 1.05!
        Me.line65.Y2 = 1.05!
        '
        'line66
        '
        Me.line66.Height = 0.0!
        Me.line66.Left = 11.15!
        Me.line66.LineWeight = 1.0!
        Me.line66.Name = "line66"
        Me.line66.Top = 1.5!
        Me.line66.Width = 2.25!
        Me.line66.X1 = 11.15!
        Me.line66.X2 = 13.4!
        Me.line66.Y1 = 1.5!
        Me.line66.Y2 = 1.5!
        '
        'line67
        '
        Me.line67.Height = 0.45!
        Me.line67.Left = 11.15!
        Me.line67.LineWeight = 1.0!
        Me.line67.Name = "line67"
        Me.line67.Top = 1.05!
        Me.line67.Width = 0.0!
        Me.line67.X1 = 11.15!
        Me.line67.X2 = 11.15!
        Me.line67.Y1 = 1.05!
        Me.line67.Y2 = 1.5!
        '
        'line68
        '
        Me.line68.Height = 0.45!
        Me.line68.Left = 13.4!
        Me.line68.LineWeight = 1.0!
        Me.line68.Name = "line68"
        Me.line68.Top = 1.05!
        Me.line68.Width = 0.0!
        Me.line68.X1 = 13.4!
        Me.line68.X2 = 13.4!
        Me.line68.Y1 = 1.05!
        Me.line68.Y2 = 1.5!
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtSurveyDate, Me.txtClientLocNo, Me.textBox5, Me.txtTIV, Me.textBox4, Me.txtFileNo, Me.txtDivision, Me.txtHERating, Me.txtFDDistance, Me.txtSprinklerValves, Me.txtFirePumps, Me.txtAlarms, Me.txtExtinguishers, Me.txtFireDoors, Me.txtCombSafety, Me.txtInfraredScans, Me.txtHotWork, Me.txtContrSupv, Me.txtImpHandling, Me.txtHousekeeping, Me.txtGenMaint, Me.txtSmokingControls, Me.txtMgmtofChange, Me.txtEOType, Me.txtEOTraining, Me.txtEmergPlan, Me.txtPublicFD, Me.txtFacility, Me.line21, Me.line22, Me.line23, Me.line24, Me.line25, Me.line26, Me.line27, Me.line28, Me.line29, Me.line32, Me.line33, Me.line36, Me.line37, Me.line38, Me.line39, Me.line40, Me.line41, Me.line42, Me.line43, Me.line44, Me.line46, Me.line47, Me.line48, Me.line49, Me.line50, Me.line51, Me.line52, Me.line35, Me.line34, Me.line45, Me.textBox2, Me.line1, Me.line31, Me.txtCountry, Me.line30})
        Me.Detail1.Height = 0.36!
        Me.Detail1.KeepTogether = True
        Me.Detail1.Name = "Detail1"
        '
        'txtSurveyDate
        '
        Me.txtSurveyDate.CanGrow = False
        Me.txtSurveyDate.DataField = "SurveyDate"
        Me.txtSurveyDate.Height = 0.15!
        Me.txtSurveyDate.Left = 0.52!
        Me.txtSurveyDate.MultiLine = False
        Me.txtSurveyDate.Name = "txtSurveyDate"
        Me.txtSurveyDate.Style = "background-color: White; font-family: Calibri; font-size: 7pt; vertical-align: mi" & _
    "ddle"
        Me.txtSurveyDate.Text = "22 Mar 05"
        Me.txtSurveyDate.Top = 0.05!
        Me.txtSurveyDate.Width = 0.58!
        '
        'txtClientLocNo
        '
        Me.txtClientLocNo.CanGrow = False
        Me.txtClientLocNo.DataField = "ClientLocNo"
        Me.txtClientLocNo.Height = 0.15!
        Me.txtClientLocNo.Left = 1.1!
        Me.txtClientLocNo.Name = "txtClientLocNo"
        Me.txtClientLocNo.Style = "background-color: White; font-family: Calibri; font-size: 7pt"
        Me.txtClientLocNo.Text = "Client Loc. No"
        Me.txtClientLocNo.Top = 0.05!
        Me.txtClientLocNo.Width = 0.8!
        '
        'textBox5
        '
        Me.textBox5.CanGrow = False
        Me.textBox5.DataField = "City"
        Me.textBox5.Height = 0.15!
        Me.textBox5.Left = 1.9!
        Me.textBox5.MultiLine = False
        Me.textBox5.Name = "textBox5"
        Me.textBox5.Style = "background-color: White; font-family: Calibri; font-size: 7pt; vertical-align: mi" & _
    "ddle"
        Me.textBox5.Text = "City"
        Me.textBox5.Top = 0.05!
        Me.textBox5.Width = 0.95!
        '
        'txtTIV
        '
        Me.txtTIV.CanGrow = False
        Me.txtTIV.DataField = "TIV"
        Me.txtTIV.Height = 0.15!
        Me.txtTIV.Left = 3.95!
        Me.txtTIV.MultiLine = False
        Me.txtTIV.Name = "txtTIV"
        Me.txtTIV.Style = "background-color: White; font-family: Calibri; font-size: 7pt; text-align: center" & _
    "; vertical-align: middle"
        Me.txtTIV.Text = "TIV"
        Me.txtTIV.Top = 0.05!
        Me.txtTIV.Width = 0.42!
        '
        'textBox4
        '
        Me.textBox4.CanGrow = False
        Me.textBox4.DataField = "StProv"
        Me.textBox4.Height = 0.15!
        Me.textBox4.Left = 2.85!
        Me.textBox4.MultiLine = False
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Style = "background-color: White; font-family: Calibri; font-size: 7pt; vertical-align: mi" & _
    "ddle"
        Me.textBox4.Text = "VBRS"
        Me.textBox4.Top = 0.05!
        Me.textBox4.Width = 0.35!
        '
        'txtFileNo
        '
        Me.txtFileNo.CanGrow = False
        Me.txtFileNo.DataField = "FileNo"
        Me.txtFileNo.Height = 0.15!
        Me.txtFileNo.Left = 0.0!
        Me.txtFileNo.MultiLine = False
        Me.txtFileNo.Name = "txtFileNo"
        Me.txtFileNo.Style = "background-color: White; font-family: Calibri; font-size: 7pt; vertical-align: mi" & _
    "ddle"
        Me.txtFileNo.Text = "0000.0000"
        Me.txtFileNo.Top = 0.05!
        Me.txtFileNo.Width = 0.52!
        '
        'txtDivision
        '
        Me.txtDivision.CanGrow = False
        Me.txtDivision.DataField = "Division"
        Me.txtDivision.Height = 0.15!
        Me.txtDivision.Left = 0.0!
        Me.txtDivision.MultiLine = False
        Me.txtDivision.Name = "txtDivision"
        Me.txtDivision.Style = "background-color: White; font-family: Calibri; font-size: 7pt; vertical-align: mi" & _
    "ddle"
        Me.txtDivision.Text = "Division"
        Me.txtDivision.Top = 0.2!
        Me.txtDivision.Width = 1.1!
        '
        'txtHERating
        '
        Me.txtHERating.DataField = "HumanElementRating"
        Me.txtHERating.Height = 0.3!
        Me.txtHERating.Left = 4.37!
        Me.txtHERating.Name = "txtHERating"
        Me.txtHERating.Style = "background-color: White; font-family: Calibri; font-size: 7pt; text-align: center" & _
    "; vertical-align: middle"
        Me.txtHERating.Text = "HE Rating"
        Me.txtHERating.Top = 0.05!
        Me.txtHERating.Width = 0.33!
        '
        'txtFDDistance
        '
        Me.txtFDDistance.DataField = "DistanceToNearestStation"
        Me.txtFDDistance.Height = 0.3!
        Me.txtFDDistance.Left = 12.95!
        Me.txtFDDistance.Name = "txtFDDistance"
        Me.txtFDDistance.Style = "background-color: White; font-family: Calibri; font-size: 6pt; text-align: center" & _
    "; vertical-align: middle"
        Me.txtFDDistance.Text = "Unknown"
        Me.txtFDDistance.Top = 0.05!
        Me.txtFDDistance.Width = 0.45!
        '
        'txtSprinklerValves
        '
        Me.txtSprinklerValves.DataField = "SprinklerValves"
        Me.txtSprinklerValves.Height = 0.3!
        Me.txtSprinklerValves.Left = 4.75!
        Me.txtSprinklerValves.Name = "txtSprinklerValves"
        Me.txtSprinklerValves.Style = "background-color: White; font-family: Calibri; font-size: 6pt; text-align: center" & _
    "; vertical-align: middle"
        Me.txtSprinklerValves.Text = "Inadequate"
        Me.txtSprinklerValves.Top = 0.05!
        Me.txtSprinklerValves.Width = 0.45!
        '
        'txtFirePumps
        '
        Me.txtFirePumps.DataField = "FirePumps"
        Me.txtFirePumps.Height = 0.3!
        Me.txtFirePumps.Left = 5.2!
        Me.txtFirePumps.Name = "txtFirePumps"
        Me.txtFirePumps.Style = "background-color: White; font-family: Calibri; font-size: 6pt; text-align: center" & _
    "; vertical-align: middle"
        Me.txtFirePumps.Text = "Inadequate"
        Me.txtFirePumps.Top = 0.05!
        Me.txtFirePumps.Width = 0.45!
        '
        'txtAlarms
        '
        Me.txtAlarms.DataField = "Alarms"
        Me.txtAlarms.Height = 0.3!
        Me.txtAlarms.Left = 5.65!
        Me.txtAlarms.Name = "txtAlarms"
        Me.txtAlarms.Style = "background-color: White; font-family: Calibri; font-size: 6pt; text-align: center" & _
    "; vertical-align: middle"
        Me.txtAlarms.Text = "Inadequate"
        Me.txtAlarms.Top = 0.05!
        Me.txtAlarms.Width = 0.45!
        '
        'txtExtinguishers
        '
        Me.txtExtinguishers.DataField = "Extinguishers"
        Me.txtExtinguishers.Height = 0.3!
        Me.txtExtinguishers.Left = 6.1!
        Me.txtExtinguishers.Name = "txtExtinguishers"
        Me.txtExtinguishers.Style = "background-color: White; font-family: Calibri; font-size: 6pt; text-align: center" & _
    "; vertical-align: middle"
        Me.txtExtinguishers.Text = "Inadequate"
        Me.txtExtinguishers.Top = 0.05!
        Me.txtExtinguishers.Width = 0.45!
        '
        'txtFireDoors
        '
        Me.txtFireDoors.DataField = "FireDoors"
        Me.txtFireDoors.Height = 0.3!
        Me.txtFireDoors.Left = 6.55!
        Me.txtFireDoors.Name = "txtFireDoors"
        Me.txtFireDoors.Style = "background-color: White; font-family: Calibri; font-size: 6pt; text-align: center" & _
    "; vertical-align: middle"
        Me.txtFireDoors.Text = "Inadequate"
        Me.txtFireDoors.Top = 0.05!
        Me.txtFireDoors.Width = 0.45!
        '
        'txtCombSafety
        '
        Me.txtCombSafety.DataField = "CombustionSafetyControls"
        Me.txtCombSafety.Height = 0.3!
        Me.txtCombSafety.Left = 7.0!
        Me.txtCombSafety.Name = "txtCombSafety"
        Me.txtCombSafety.Style = "background-color: White; font-family: Calibri; font-size: 6pt; text-align: center" & _
    "; vertical-align: middle"
        Me.txtCombSafety.Text = "Inadequate"
        Me.txtCombSafety.Top = 0.05!
        Me.txtCombSafety.Width = 0.45!
        '
        'txtInfraredScans
        '
        Me.txtInfraredScans.DataField = "InfraredScans"
        Me.txtInfraredScans.Height = 0.3!
        Me.txtInfraredScans.Left = 7.45!
        Me.txtInfraredScans.Name = "txtInfraredScans"
        Me.txtInfraredScans.Style = "background-color: White; font-family: Calibri; font-size: 6pt; text-align: center" & _
    "; vertical-align: middle"
        Me.txtInfraredScans.Text = "Inadequate"
        Me.txtInfraredScans.Top = 0.05!
        Me.txtInfraredScans.Width = 0.45!
        '
        'txtHotWork
        '
        Me.txtHotWork.DataField = "HotWorkMonitoring"
        Me.txtHotWork.Height = 0.3!
        Me.txtHotWork.Left = 7.95!
        Me.txtHotWork.Name = "txtHotWork"
        Me.txtHotWork.Style = "background-color: White; font-family: Calibri; font-size: 6pt; text-align: center" & _
    "; vertical-align: middle"
        Me.txtHotWork.Text = "Inadequate"
        Me.txtHotWork.Top = 0.05!
        Me.txtHotWork.Width = 0.45!
        '
        'txtContrSupv
        '
        Me.txtContrSupv.DataField = "ContractorSupv"
        Me.txtContrSupv.Height = 0.3!
        Me.txtContrSupv.Left = 8.4!
        Me.txtContrSupv.Name = "txtContrSupv"
        Me.txtContrSupv.Style = "background-color: White; font-family: Calibri; font-size: 6pt; text-align: center" & _
    "; vertical-align: middle"
        Me.txtContrSupv.Text = "Inadequate"
        Me.txtContrSupv.Top = 0.05!
        Me.txtContrSupv.Width = 0.45!
        '
        'txtImpHandling
        '
        Me.txtImpHandling.DataField = "ImpairmentHandling"
        Me.txtImpHandling.Height = 0.3!
        Me.txtImpHandling.Left = 8.85!
        Me.txtImpHandling.Name = "txtImpHandling"
        Me.txtImpHandling.Style = "background-color: White; font-family: Calibri; font-size: 6pt; text-align: center" & _
    "; vertical-align: middle"
        Me.txtImpHandling.Text = "Inadequate"
        Me.txtImpHandling.Top = 0.05!
        Me.txtImpHandling.Width = 0.45!
        '
        'txtHousekeeping
        '
        Me.txtHousekeeping.DataField = "Housekeeping"
        Me.txtHousekeeping.Height = 0.3!
        Me.txtHousekeeping.Left = 9.3!
        Me.txtHousekeeping.Name = "txtHousekeeping"
        Me.txtHousekeeping.Style = "background-color: White; font-family: Calibri; font-size: 6pt; text-align: center" & _
    "; vertical-align: middle"
        Me.txtHousekeeping.Text = "Inadequate"
        Me.txtHousekeeping.Top = 0.05!
        Me.txtHousekeeping.Width = 0.45!
        '
        'txtGenMaint
        '
        Me.txtGenMaint.DataField = "GeneralMaintenance"
        Me.txtGenMaint.Height = 0.3!
        Me.txtGenMaint.Left = 9.75!
        Me.txtGenMaint.Name = "txtGenMaint"
        Me.txtGenMaint.Style = "background-color: White; font-family: Calibri; font-size: 6pt; text-align: center" & _
    "; vertical-align: middle"
        Me.txtGenMaint.Text = "Inadequate"
        Me.txtGenMaint.Top = 0.05!
        Me.txtGenMaint.Width = 0.45!
        '
        'txtSmokingControls
        '
        Me.txtSmokingControls.DataField = "SmokingControls"
        Me.txtSmokingControls.Height = 0.3!
        Me.txtSmokingControls.Left = 10.2!
        Me.txtSmokingControls.Name = "txtSmokingControls"
        Me.txtSmokingControls.Style = "background-color: White; font-family: Calibri; font-size: 6pt; text-align: center" & _
    "; vertical-align: middle"
        Me.txtSmokingControls.Text = "Inadequate"
        Me.txtSmokingControls.Top = 0.05!
        Me.txtSmokingControls.Width = 0.45!
        '
        'txtMgmtofChange
        '
        Me.txtMgmtofChange.DataField = "ManagementofChange"
        Me.txtMgmtofChange.Height = 0.3!
        Me.txtMgmtofChange.Left = 10.65!
        Me.txtMgmtofChange.Name = "txtMgmtofChange"
        Me.txtMgmtofChange.Style = "background-color: White; font-family: Calibri; font-size: 6pt; text-align: center" & _
    "; vertical-align: middle"
        Me.txtMgmtofChange.Text = "Inadequate"
        Me.txtMgmtofChange.Top = 0.05!
        Me.txtMgmtofChange.Width = 0.45!
        '
        'txtEOType
        '
        Me.txtEOType.DataField = "EOType"
        Me.txtEOType.Height = 0.3!
        Me.txtEOType.Left = 11.15!
        Me.txtEOType.Name = "txtEOType"
        Me.txtEOType.Style = "background-color: White; font-family: Calibri; font-size: 6pt; text-align: center" & _
    "; vertical-align: middle"
        Me.txtEOType.Text = "Inadequate"
        Me.txtEOType.Top = 0.05!
        Me.txtEOType.Width = 0.45!
        '
        'txtEOTraining
        '
        Me.txtEOTraining.DataField = "EOTraining"
        Me.txtEOTraining.Height = 0.3!
        Me.txtEOTraining.Left = 11.6!
        Me.txtEOTraining.Name = "txtEOTraining"
        Me.txtEOTraining.Style = "background-color: White; font-family: Calibri; font-size: 6pt; text-align: center" & _
    "; vertical-align: middle"
        Me.txtEOTraining.Text = "Inadequate"
        Me.txtEOTraining.Top = 0.05!
        Me.txtEOTraining.Width = 0.45!
        '
        'txtEmergPlan
        '
        Me.txtEmergPlan.DataField = "EmergResponseBCP"
        Me.txtEmergPlan.Height = 0.3!
        Me.txtEmergPlan.Left = 12.05!
        Me.txtEmergPlan.Name = "txtEmergPlan"
        Me.txtEmergPlan.Style = "background-color: White; font-family: Calibri; font-size: 6pt; text-align: center" & _
    "; vertical-align: middle"
        Me.txtEmergPlan.Text = "Inadequate"
        Me.txtEmergPlan.Top = 0.05!
        Me.txtEmergPlan.Width = 0.45!
        '
        'txtPublicFD
        '
        Me.txtPublicFD.DataField = "PublicFireDepartmentType"
        Me.txtPublicFD.Height = 0.3!
        Me.txtPublicFD.Left = 12.5!
        Me.txtPublicFD.Name = "txtPublicFD"
        Me.txtPublicFD.Style = "background-color: White; font-family: Calibri; font-size: 6pt; text-align: center" & _
    "; vertical-align: middle"
        Me.txtPublicFD.Text = "Inadequate"
        Me.txtPublicFD.Top = 0.05!
        Me.txtPublicFD.Width = 0.45!
        '
        'txtFacility
        '
        Me.txtFacility.CanGrow = False
        Me.txtFacility.DataField = "Facility"
        Me.txtFacility.Height = 0.15!
        Me.txtFacility.Left = 1.1!
        Me.txtFacility.MultiLine = False
        Me.txtFacility.Name = "txtFacility"
        Me.txtFacility.Style = "background-color: White; font-family: Calibri; font-size: 7pt; vertical-align: mi" & _
    "ddle"
        Me.txtFacility.Text = "Facility"
        Me.txtFacility.Top = 0.2!
        Me.txtFacility.Width = 0.8!
        '
        'line21
        '
        Me.line21.Height = 0.3!
        Me.line21.Left = 5.2!
        Me.line21.LineWeight = 1.0!
        Me.line21.Name = "line21"
        Me.line21.Top = 0.05!
        Me.line21.Width = 0.0!
        Me.line21.X1 = 5.2!
        Me.line21.X2 = 5.2!
        Me.line21.Y1 = 0.05!
        Me.line21.Y2 = 0.35!
        '
        'line22
        '
        Me.line22.Height = 0.3!
        Me.line22.Left = 5.65!
        Me.line22.LineWeight = 1.0!
        Me.line22.Name = "line22"
        Me.line22.Top = 0.05!
        Me.line22.Width = 0.0!
        Me.line22.X1 = 5.65!
        Me.line22.X2 = 5.65!
        Me.line22.Y1 = 0.05!
        Me.line22.Y2 = 0.35!
        '
        'line23
        '
        Me.line23.Height = 0.3!
        Me.line23.Left = 6.1!
        Me.line23.LineWeight = 1.0!
        Me.line23.Name = "line23"
        Me.line23.Top = 0.05!
        Me.line23.Width = 0.0!
        Me.line23.X1 = 6.1!
        Me.line23.X2 = 6.1!
        Me.line23.Y1 = 0.05!
        Me.line23.Y2 = 0.35!
        '
        'line24
        '
        Me.line24.Height = 0.3!
        Me.line24.Left = 6.55!
        Me.line24.LineWeight = 1.0!
        Me.line24.Name = "line24"
        Me.line24.Top = 0.05!
        Me.line24.Width = 0.0!
        Me.line24.X1 = 6.55!
        Me.line24.X2 = 6.55!
        Me.line24.Y1 = 0.05!
        Me.line24.Y2 = 0.35!
        '
        'line25
        '
        Me.line25.Height = 0.3!
        Me.line25.Left = 7.0!
        Me.line25.LineWeight = 1.0!
        Me.line25.Name = "line25"
        Me.line25.Top = 0.05!
        Me.line25.Width = 0.0!
        Me.line25.X1 = 7.0!
        Me.line25.X2 = 7.0!
        Me.line25.Y1 = 0.05!
        Me.line25.Y2 = 0.35!
        '
        'line26
        '
        Me.line26.Height = 0.3!
        Me.line26.Left = 7.45!
        Me.line26.LineWeight = 1.0!
        Me.line26.Name = "line26"
        Me.line26.Top = 0.05!
        Me.line26.Width = 0.0!
        Me.line26.X1 = 7.45!
        Me.line26.X2 = 7.45!
        Me.line26.Y1 = 0.05!
        Me.line26.Y2 = 0.35!
        '
        'line27
        '
        Me.line27.Height = 0.3!
        Me.line27.Left = 4.75!
        Me.line27.LineWeight = 1.0!
        Me.line27.Name = "line27"
        Me.line27.Top = 0.05!
        Me.line27.Width = 0.0!
        Me.line27.X1 = 4.75!
        Me.line27.X2 = 4.75!
        Me.line27.Y1 = 0.05!
        Me.line27.Y2 = 0.35!
        '
        'line28
        '
        Me.line28.Height = 0.3!
        Me.line28.Left = 4.7!
        Me.line28.LineWeight = 1.0!
        Me.line28.Name = "line28"
        Me.line28.Top = 0.05!
        Me.line28.Width = 0.0!
        Me.line28.X1 = 4.7!
        Me.line28.X2 = 4.7!
        Me.line28.Y1 = 0.05!
        Me.line28.Y2 = 0.35!
        '
        'line29
        '
        Me.line29.Height = 0.3!
        Me.line29.Left = 0.0!
        Me.line29.LineWeight = 1.0!
        Me.line29.Name = "line29"
        Me.line29.Top = 0.05!
        Me.line29.Width = 0.0!
        Me.line29.X1 = 0.0!
        Me.line29.X2 = 0.0!
        Me.line29.Y1 = 0.05!
        Me.line29.Y2 = 0.35!
        '
        'line32
        '
        Me.line32.Height = 0.0!
        Me.line32.Left = 4.75!
        Me.line32.LineWeight = 1.0!
        Me.line32.Name = "line32"
        Me.line32.Top = 0.35!
        Me.line32.Width = 3.15!
        Me.line32.X1 = 4.75!
        Me.line32.X2 = 7.9!
        Me.line32.Y1 = 0.35!
        Me.line32.Y2 = 0.35!
        '
        'line33
        '
        Me.line33.Height = 0.0!
        Me.line33.Left = 7.95!
        Me.line33.LineWeight = 1.0!
        Me.line33.Name = "line33"
        Me.line33.Top = 0.35!
        Me.line33.Width = 3.150001!
        Me.line33.X1 = 7.95!
        Me.line33.X2 = 11.1!
        Me.line33.Y1 = 0.35!
        Me.line33.Y2 = 0.35!
        '
        'line36
        '
        Me.line36.Height = 0.3!
        Me.line36.Left = 7.9!
        Me.line36.LineWeight = 1.0!
        Me.line36.Name = "line36"
        Me.line36.Top = 0.05!
        Me.line36.Width = 0.0!
        Me.line36.X1 = 7.9!
        Me.line36.X2 = 7.9!
        Me.line36.Y1 = 0.05!
        Me.line36.Y2 = 0.35!
        '
        'line37
        '
        Me.line37.Height = 0.3!
        Me.line37.Left = 7.95!
        Me.line37.LineWeight = 1.0!
        Me.line37.Name = "line37"
        Me.line37.Top = 0.05!
        Me.line37.Width = 0.0!
        Me.line37.X1 = 7.95!
        Me.line37.X2 = 7.95!
        Me.line37.Y1 = 0.05!
        Me.line37.Y2 = 0.35!
        '
        'line38
        '
        Me.line38.Height = 0.3!
        Me.line38.Left = 8.4!
        Me.line38.LineWeight = 1.0!
        Me.line38.Name = "line38"
        Me.line38.Top = 0.05!
        Me.line38.Width = 0.0!
        Me.line38.X1 = 8.4!
        Me.line38.X2 = 8.4!
        Me.line38.Y1 = 0.05!
        Me.line38.Y2 = 0.35!
        '
        'line39
        '
        Me.line39.Height = 0.3!
        Me.line39.Left = 8.85!
        Me.line39.LineWeight = 1.0!
        Me.line39.Name = "line39"
        Me.line39.Top = 0.05!
        Me.line39.Width = 0.0!
        Me.line39.X1 = 8.85!
        Me.line39.X2 = 8.85!
        Me.line39.Y1 = 0.05!
        Me.line39.Y2 = 0.35!
        '
        'line40
        '
        Me.line40.Height = 0.3!
        Me.line40.Left = 9.3!
        Me.line40.LineWeight = 1.0!
        Me.line40.Name = "line40"
        Me.line40.Top = 0.05!
        Me.line40.Width = 0.0!
        Me.line40.X1 = 9.3!
        Me.line40.X2 = 9.3!
        Me.line40.Y1 = 0.05!
        Me.line40.Y2 = 0.35!
        '
        'line41
        '
        Me.line41.Height = 0.3!
        Me.line41.Left = 9.75!
        Me.line41.LineWeight = 1.0!
        Me.line41.Name = "line41"
        Me.line41.Top = 0.05!
        Me.line41.Width = 0.0!
        Me.line41.X1 = 9.75!
        Me.line41.X2 = 9.75!
        Me.line41.Y1 = 0.05!
        Me.line41.Y2 = 0.35!
        '
        'line42
        '
        Me.line42.Height = 0.3!
        Me.line42.Left = 10.2!
        Me.line42.LineWeight = 1.0!
        Me.line42.Name = "line42"
        Me.line42.Top = 0.05!
        Me.line42.Width = 0.0!
        Me.line42.X1 = 10.2!
        Me.line42.X2 = 10.2!
        Me.line42.Y1 = 0.05!
        Me.line42.Y2 = 0.35!
        '
        'line43
        '
        Me.line43.Height = 0.3!
        Me.line43.Left = 11.1!
        Me.line43.LineWeight = 1.0!
        Me.line43.Name = "line43"
        Me.line43.Top = 0.05!
        Me.line43.Width = 0.0!
        Me.line43.X1 = 11.1!
        Me.line43.X2 = 11.1!
        Me.line43.Y1 = 0.05!
        Me.line43.Y2 = 0.35!
        '
        'line44
        '
        Me.line44.Height = 0.3!
        Me.line44.Left = 10.65!
        Me.line44.LineWeight = 1.0!
        Me.line44.Name = "line44"
        Me.line44.Top = 0.05!
        Me.line44.Width = 0.0!
        Me.line44.X1 = 10.65!
        Me.line44.X2 = 10.65!
        Me.line44.Y1 = 0.05!
        Me.line44.Y2 = 0.35!
        '
        'line46
        '
        Me.line46.Height = 0.0!
        Me.line46.Left = 11.15!
        Me.line46.LineWeight = 1.0!
        Me.line46.Name = "line46"
        Me.line46.Top = 0.35!
        Me.line46.Width = 2.25!
        Me.line46.X1 = 11.15!
        Me.line46.X2 = 13.4!
        Me.line46.Y1 = 0.35!
        Me.line46.Y2 = 0.35!
        '
        'line47
        '
        Me.line47.Height = 0.3!
        Me.line47.Left = 11.15!
        Me.line47.LineWeight = 1.0!
        Me.line47.Name = "line47"
        Me.line47.Top = 0.05!
        Me.line47.Width = 0.0!
        Me.line47.X1 = 11.15!
        Me.line47.X2 = 11.15!
        Me.line47.Y1 = 0.05!
        Me.line47.Y2 = 0.35!
        '
        'line48
        '
        Me.line48.Height = 0.3!
        Me.line48.Left = 11.6!
        Me.line48.LineWeight = 1.0!
        Me.line48.Name = "line48"
        Me.line48.Top = 0.05!
        Me.line48.Width = 0.0!
        Me.line48.X1 = 11.6!
        Me.line48.X2 = 11.6!
        Me.line48.Y1 = 0.05!
        Me.line48.Y2 = 0.35!
        '
        'line49
        '
        Me.line49.Height = 0.3!
        Me.line49.Left = 12.05!
        Me.line49.LineWeight = 1.0!
        Me.line49.Name = "line49"
        Me.line49.Top = 0.05!
        Me.line49.Width = 0.0!
        Me.line49.X1 = 12.05!
        Me.line49.X2 = 12.05!
        Me.line49.Y1 = 0.05!
        Me.line49.Y2 = 0.35!
        '
        'line50
        '
        Me.line50.Height = 0.3!
        Me.line50.Left = 12.5!
        Me.line50.LineWeight = 1.0!
        Me.line50.Name = "line50"
        Me.line50.Top = 0.05!
        Me.line50.Width = 0.0!
        Me.line50.X1 = 12.5!
        Me.line50.X2 = 12.5!
        Me.line50.Y1 = 0.05!
        Me.line50.Y2 = 0.35!
        '
        'line51
        '
        Me.line51.Height = 0.3!
        Me.line51.Left = 12.95!
        Me.line51.LineWeight = 1.0!
        Me.line51.Name = "line51"
        Me.line51.Top = 0.05!
        Me.line51.Width = 0.0!
        Me.line51.X1 = 12.95!
        Me.line51.X2 = 12.95!
        Me.line51.Y1 = 0.05!
        Me.line51.Y2 = 0.35!
        '
        'line52
        '
        Me.line52.Height = 0.3!
        Me.line52.Left = 13.4!
        Me.line52.LineWeight = 1.0!
        Me.line52.Name = "line52"
        Me.line52.Top = 0.05!
        Me.line52.Width = 0.0!
        Me.line52.X1 = 13.4!
        Me.line52.X2 = 13.4!
        Me.line52.Y1 = 0.05!
        Me.line52.Y2 = 0.35!
        '
        'line35
        '
        Me.line35.Height = 0.0!
        Me.line35.Left = 4.75!
        Me.line35.LineWeight = 1.0!
        Me.line35.Name = "line35"
        Me.line35.Top = 0.05!
        Me.line35.Width = 3.15!
        Me.line35.X1 = 4.75!
        Me.line35.X2 = 7.9!
        Me.line35.Y1 = 0.05!
        Me.line35.Y2 = 0.05!
        '
        'line34
        '
        Me.line34.Height = 0.0!
        Me.line34.Left = 7.95!
        Me.line34.LineWeight = 1.0!
        Me.line34.Name = "line34"
        Me.line34.Top = 0.05!
        Me.line34.Width = 3.150001!
        Me.line34.X1 = 7.95!
        Me.line34.X2 = 11.1!
        Me.line34.Y1 = 0.05!
        Me.line34.Y2 = 0.05!
        '
        'line45
        '
        Me.line45.Height = 0.0!
        Me.line45.Left = 11.15!
        Me.line45.LineWeight = 1.0!
        Me.line45.Name = "line45"
        Me.line45.Top = 0.05!
        Me.line45.Width = 2.25!
        Me.line45.X1 = 11.15!
        Me.line45.X2 = 13.4!
        Me.line45.Y1 = 0.05!
        Me.line45.Y2 = 0.05!
        '
        'textBox2
        '
        Me.textBox2.CanGrow = False
        Me.textBox2.DataField = "Address"
        Me.textBox2.Height = 0.15!
        Me.textBox2.Left = 1.9!
        Me.textBox2.MultiLine = False
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Style = "background-color: White; font-family: Calibri; font-size: 7pt; vertical-align: mi" & _
    "ddle"
        Me.textBox2.Text = "Address"
        Me.textBox2.Top = 0.2!
        Me.textBox2.Width = 2.47!
        '
        'line1
        '
        Me.line1.Height = 0.3!
        Me.line1.Left = 4.37!
        Me.line1.LineWeight = 1.0!
        Me.line1.Name = "line1"
        Me.line1.Top = 0.05!
        Me.line1.Width = 0.0!
        Me.line1.X1 = 4.37!
        Me.line1.X2 = 4.37!
        Me.line1.Y1 = 0.05!
        Me.line1.Y2 = 0.35!
        '
        'line31
        '
        Me.line31.Height = 0.0!
        Me.line31.Left = 0.0!
        Me.line31.LineWeight = 1.0!
        Me.line31.Name = "line31"
        Me.line31.Top = 0.35!
        Me.line31.Width = 4.7!
        Me.line31.X1 = 0.0!
        Me.line31.X2 = 4.7!
        Me.line31.Y1 = 0.35!
        Me.line31.Y2 = 0.35!
        '
        'txtCountry
        '
        Me.txtCountry.CanGrow = False
        Me.txtCountry.DataField = "Country"
        Me.txtCountry.Height = 0.15!
        Me.txtCountry.Left = 3.2!
        Me.txtCountry.MultiLine = False
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Style = "background-color: White; font-family: Calibri; font-size: 7pt; vertical-align: mi" & _
    "ddle"
        Me.txtCountry.Text = "Country"
        Me.txtCountry.Top = 0.05!
        Me.txtCountry.Width = 0.75!
        '
        'line30
        '
        Me.line30.Height = 0.0!
        Me.line30.Left = 0.0!
        Me.line30.LineWeight = 1.0!
        Me.line30.Name = "line30"
        Me.line30.Top = 0.05!
        Me.line30.Width = 4.7!
        Me.line30.X1 = 0.0!
        Me.line30.X2 = 4.7!
        Me.line30.Y1 = 0.05!
        Me.line30.Y2 = 0.05!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtSort, Me.lblReportDate, Me.reportInfo1, Me.txtDisclaimer})
        Me.PageFooter1.Height = 0.4958334!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'txtSort
        '
        Me.txtSort.CanShrink = True
        Me.txtSort.Height = 0.15!
        Me.txtSort.Left = 0.0!
        Me.txtSort.Name = "txtSort"
        Me.txtSort.Style = "font-family: Calibri; font-size: 7pt; font-style: italic; text-align: center; ver" & _
    "tical-align: middle"
        Me.txtSort.Text = "Sort"
        Me.txtSort.Top = 0.0!
        Me.txtSort.Width = 13.4!
        '
        'lblReportDate
        '
        Me.lblReportDate.Height = 0.15!
        Me.lblReportDate.HyperLink = Nothing
        Me.lblReportDate.Left = 0.0!
        Me.lblReportDate.Name = "lblReportDate"
        Me.lblReportDate.Style = "font-family: Calibri; font-size: 7pt; vertical-align: middle"
        Me.lblReportDate.Text = "Report Date"
        Me.lblReportDate.Top = 0.3125!
        Me.lblReportDate.Width = 2.0!
        '
        'reportInfo1
        '
        Me.reportInfo1.FormatString = "Page {PageNumber} of {PageCount}"
        Me.reportInfo1.Height = 0.15!
        Me.reportInfo1.Left = 11.265!
        Me.reportInfo1.Name = "reportInfo1"
        Me.reportInfo1.Style = "font-family: Calibri; font-size: 7pt; font-style: italic; text-align: right; vert" & _
    "ical-align: middle"
        Me.reportInfo1.Top = 0.3!
        Me.reportInfo1.Width = 2.134999!
        '
        'txtDisclaimer
        '
        Me.txtDisclaimer.CanShrink = True
        Me.txtDisclaimer.Height = 0.15!
        Me.txtDisclaimer.Left = 0.0!
        Me.txtDisclaimer.Name = "txtDisclaimer"
        Me.txtDisclaimer.Style = "font-family: Calibri; font-size: 7pt; font-style: italic; text-align: center; ver" & _
    "tical-align: middle"
        Me.txtDisclaimer.Text = "Disclaimer"
        Me.txtDisclaimer.Top = 0.15!
        Me.txtDisclaimer.Width = 13.4!
        '
        'rptFireHumanElementSummary
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.25!
        Me.PageSettings.Margins.Left = 0.3!
        Me.PageSettings.Margins.Right = 0.3!
        Me.PageSettings.Margins.Top = 0.25!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 14.0!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Legal
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 13.4!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Calibri; font-style: normal; text-decoration: none; font-weight: nor" & _
            "mal; font-size: 10pt; color: Black", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
            "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblLocationDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHERating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSprinklerValves, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblClientName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFDDistance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFileNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTIVmillions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCountry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSurveyDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDivision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblResponse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblInspection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblManagement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFirePumps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAlarms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblExtinguishers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFireDoors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCombSafety, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblInfrared, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHotWork, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblContrSupv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblImpHandling, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblGenMaint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSmokingControls, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMgmtofChange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblEOType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblEOTraining, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblEmergPlans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPublicFD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGRCLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblClientLocNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFacility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSurveyDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientLocNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTIV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFileNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDivision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHERating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFDDistance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSprinklerValves, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFirePumps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlarms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExtinguishers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFireDoors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCombSafety, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInfraredScans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHotWork, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContrSupv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImpHandling, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHousekeeping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGenMaint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSmokingControls, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMgmtofChange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEOType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEOTraining, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmergPlan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPublicFD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFacility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).EndInit()
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

    Private Sub rptFireHumanElementSummary_FetchData(ByVal sender As Object, ByVal eArgs As FetchEventArgs) Handles Me.FetchData
        Dim zRatingHEControls() As ARControl = {txtHERating}
        Dim zTextControls() As ARControl = {txtSprinklerValves,
                                            txtFirePumps,
                                            txtAlarms,
                                            txtExtinguishers,
                                            txtFireDoors,
                                            txtCombSafety,
                                            txtInfraredScans,
                                            txtHotWork,
                                            txtContrSupv,
                                            txtImpHandling,
                                            txtHousekeeping,
                                            txtGenMaint,
                                            txtSmokingControls,
                                            txtMgmtofChange,
                                            txtEOType,
                                            txtEOTraining,
                                            txtEmergPlan}

        UtilReport.ActiveReport.SetItemBackColorByRatingHE(Me, zRatingHEControls, rptProperties)
        UtilReport.ActiveReport.SetItemBackColorByText(Me, zTextControls, rptProperties)

    End Sub

    Private Sub rptFireHumanElementSummary_ReportStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportStart
        lblClientName.Text = rptProperties.ClientName
        lblReportDate.Text = Now
        lblTIVmillions.Text = "TIV " & rptProperties.Currency.colFldCode & vbLf & "(millions)"
    End Sub

    Private Sub rptFireHumanElementSummary_PageStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.PageStart
        UtilReport.ActiveReport.SetFilter(Me, rptProperties)
        UtilReport.ActiveReport.SetSort(Me, rptProperties)
        UtilReport.ActiveReport.SetDisclaimer(Me, rptProperties)
    End Sub

    Private Sub rptFireHumanElementSummary_ReportEnd(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportEnd
        DisposeParameters()
    End Sub

    Private Sub DisposeParameters()
        DataSource = Nothing
    End Sub

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties

End Class
