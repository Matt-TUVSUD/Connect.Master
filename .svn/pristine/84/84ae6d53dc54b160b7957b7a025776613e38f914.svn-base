Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports

Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing

Public Class rptFireSprinklerSystemSummary
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
    Private WithEvents lblFireSprinklerSystemSummary As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblLocationInformation As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFileNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblDivision2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblInspectionDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCity As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblAddress As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblSTProv As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCountry As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblTIVGrid As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblValves As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblSprinklerHeads As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblATV2inDrain As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblATVDryPipeValve As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblATVFirePump As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblATVAntifreeze As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblATVValveTamper As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblATVWaterFlow As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblAnnualTestVerification As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblImpProcObserved As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblNoMissingCapsFDC As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFireSupSysOver As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblBlowOffCaps As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblManualRelease As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblMin18Clearance As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFireAlarmZonePosted As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblOther As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtFileNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSurveyDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCity As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSTProv As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCountry As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtTIV As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtDivision2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtAddress As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtATV2inDrain As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtATVDryPipeValve As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtATVFirePump As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtATVAntifreeze As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtATVValveTamper As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtATVWaterFlow As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtATVDrySysLowAir As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtImpProcObserved As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtNoMissingCapsFDC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFireSupSysOver As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtBlowOffCaps As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtManualRelease As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtMin18Clearance As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFireAlarmZonePosted As GrapeCity.ActiveReports.SectionReportModel.TextBox
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
    Private WithEvents line7 As GrapeCity.ActiveReports.SectionReportModel.Line
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
    Private WithEvents txtClientLocNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFacility As GrapeCity.ActiveReports.SectionReportModel.TextBox
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
    Private WithEvents lblReportDate As GrapeCity.ActiveReports.SectionReportModel.Label
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
    Private WithEvents line67 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line68 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line70 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line71 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line72 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line75 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line76 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents reportInfo1 As GrapeCity.ActiveReports.SectionReportModel.ReportInfo
    Private WithEvents lblNoOfValves As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblAllValvesOpen As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblValvesLocked As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblValvesLabeled As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblValvesInspMonthly As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblSSHeadBoxMonthly As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblSSHeadsAvail As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblSSHeadWrenchInBox As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCorrectHeadsProvided As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblATVDrySysLowAir As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents line6 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line19 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line20 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line21 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line66 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line69 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line77 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line8 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtNoOfValves As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtAllValvesOpen As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtValvesLocked As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtValvesLabeled As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtValvesInspMonthly As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSSHeadBoxMonthly As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSSHeadsAvail As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSSHeadWrenchInBox As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCorrectHeadsProvided As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents line73 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line74 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line78 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line79 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line80 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line81 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line82 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line83 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line84 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line85 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line86 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line87 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line88 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line89 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line90 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtDisclaimer As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtATVDryPipeValveC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtATV2inDrainC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtATVFirePumpC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtATVAntifreezeC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtATVValveTamperC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtATVWaterFlowC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtATVDrySysLowAirC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtImpProcObservedC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFireSupSysOverC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtBlowOffCapsC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtManualReleaseC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtMin18ClearanceC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFireAlarmZonePostedC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtNoMissingCapsFDCC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtNoOfValvesC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtAllValvesOpenC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtValvesLockedC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtValvesLabeledC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtValvesInspMonthlyC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSSHeadBoxMonthlyC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSSHeadsAvailC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSSHeadWrenchInBoxC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCorrectHeadsProvidedC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents PageFooter1 As GrapeCity.ActiveReports.SectionReportModel.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptFireSprinklerSystemSummary))
        Me.PageHeader1 = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.lblSSHeadBoxMonthly = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblValvesLabeled = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblValvesLocked = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblAllValvesOpen = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblNoOfValves = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblValvesInspMonthly = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSSHeadWrenchInBox = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblCorrectHeadsProvided = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblATV2inDrain = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblATVDryPipeValve = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblATVFirePump = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblATVAntifreeze = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblATVValveTamper = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblATVWaterFlow = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblATVDrySysLowAir = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblImpProcObserved = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblNoMissingCapsFDC = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFireSupSysOver = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblBlowOffCaps = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblManualRelease = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFireAlarmZonePosted = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblMin18Clearance = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSprinklerHeads = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblAnnualTestVerification = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblClientName = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFireSprinklerSystemSummary = New GrapeCity.ActiveReports.SectionReportModel.Label()
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
        Me.lblValves = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblOther = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFilters = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtFilters = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblClientLocNo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFacility = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line5 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line7 = New GrapeCity.ActiveReports.SectionReportModel.Line()
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
        Me.line22 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line24 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line25 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line26 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line27 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line28 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line29 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line30 = New GrapeCity.ActiveReports.SectionReportModel.Line()
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
        Me.lblSSHeadsAvail = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.line6 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line19 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line20 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line21 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line66 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line69 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line23 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line77 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line8 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Detail1 = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.txtCorrectHeadsProvidedC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSSHeadWrenchInBoxC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSSHeadsAvailC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSSHeadBoxMonthlyC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtValvesInspMonthlyC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtValvesLabeledC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtValvesLockedC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtAllValvesOpenC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtNoOfValvesC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtNoMissingCapsFDCC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFireAlarmZonePostedC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMin18ClearanceC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtManualReleaseC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtBlowOffCapsC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFireSupSysOverC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtImpProcObservedC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtATVDrySysLowAirC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtATVWaterFlowC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtATVValveTamperC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtATVAntifreezeC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtATVFirePumpC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtATV2inDrainC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtATVDryPipeValveC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtATVDryPipeValve = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtAddress = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtDivision2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFileNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSurveyDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCity = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSTProv = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCountry = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtTIV = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtATV2inDrain = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtATVFirePump = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtATVAntifreeze = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtATVValveTamper = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtATVWaterFlow = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtATVDrySysLowAir = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtImpProcObserved = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFireSupSysOver = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtBlowOffCaps = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtManualRelease = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMin18Clearance = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFireAlarmZonePosted = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFacility = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtClientLocNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtNoMissingCapsFDC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.line41 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line42 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line43 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line44 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line45 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line46 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line47 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line48 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line49 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line50 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line51 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line52 = New GrapeCity.ActiveReports.SectionReportModel.Line()
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
        Me.line67 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line68 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line70 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line71 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line72 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line75 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line76 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtNoOfValves = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtAllValvesOpen = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtValvesLocked = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtValvesLabeled = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtValvesInspMonthly = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSSHeadBoxMonthly = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSSHeadsAvail = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSSHeadWrenchInBox = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCorrectHeadsProvided = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.line73 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line74 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line78 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line79 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line80 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line81 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line82 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line83 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line84 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line85 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line86 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line87 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line88 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line89 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line90 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.PageFooter1 = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.txtSort = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblReportDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.reportInfo1 = New GrapeCity.ActiveReports.SectionReportModel.ReportInfo()
        Me.txtDisclaimer = New GrapeCity.ActiveReports.SectionReportModel.Label()
        CType(Me.lblSSHeadBoxMonthly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblValvesLabeled, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblValvesLocked, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAllValvesOpen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNoOfValves, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblValvesInspMonthly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSSHeadWrenchInBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCorrectHeadsProvided, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblATV2inDrain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblATVDryPipeValve, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblATVFirePump, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblATVAntifreeze, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblATVValveTamper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblATVWaterFlow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblATVDrySysLowAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblImpProcObserved, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNoMissingCapsFDC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFireSupSysOver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBlowOffCaps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblManualRelease, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFireAlarmZonePosted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMin18Clearance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSprinklerHeads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAnnualTestVerification, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblClientName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFireSprinklerSystemSummary, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.lblValves, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblOther, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblClientLocNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFacility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSSHeadsAvail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCorrectHeadsProvidedC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSSHeadWrenchInBoxC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSSHeadsAvailC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSSHeadBoxMonthlyC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValvesInspMonthlyC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValvesLabeledC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValvesLockedC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAllValvesOpenC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoOfValvesC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoMissingCapsFDCC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFireAlarmZonePostedC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMin18ClearanceC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtManualReleaseC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBlowOffCapsC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFireSupSysOverC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImpProcObservedC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtATVDrySysLowAirC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtATVWaterFlowC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtATVValveTamperC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtATVAntifreezeC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtATVFirePumpC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtATV2inDrainC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtATVDryPipeValveC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtATVDryPipeValve, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDivision2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFileNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSurveyDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSTProv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTIV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtATV2inDrain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtATVFirePump, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtATVAntifreeze, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtATVValveTamper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtATVWaterFlow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtATVDrySysLowAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImpProcObserved, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFireSupSysOver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBlowOffCaps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtManualRelease, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMin18Clearance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFireAlarmZonePosted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFacility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientLocNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoMissingCapsFDC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoOfValves, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAllValvesOpen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValvesLocked, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValvesLabeled, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValvesInspMonthly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSSHeadBoxMonthly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSSHeadsAvail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSSHeadWrenchInBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCorrectHeadsProvided, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblReportDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisclaimer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.CanShrink = True
        Me.PageHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblSSHeadBoxMonthly, Me.lblValvesLabeled, Me.lblValvesLocked, Me.lblAllValvesOpen, Me.lblNoOfValves, Me.lblValvesInspMonthly, Me.lblSSHeadWrenchInBox, Me.lblCorrectHeadsProvided, Me.lblATV2inDrain, Me.lblATVDryPipeValve, Me.lblATVFirePump, Me.lblATVAntifreeze, Me.lblATVValveTamper, Me.lblATVWaterFlow, Me.lblATVDrySysLowAir, Me.lblImpProcObserved, Me.lblNoMissingCapsFDC, Me.lblFireSupSysOver, Me.lblBlowOffCaps, Me.lblManualRelease, Me.lblFireAlarmZonePosted, Me.lblMin18Clearance, Me.lblSprinklerHeads, Me.lblAnnualTestVerification, Me.lblClientName, Me.lblFireSprinklerSystemSummary, Me.lblLocationInformation, Me.picGRCLogo, Me.lblFileNo, Me.lblDivision2, Me.lblInspectionDate, Me.lblCity, Me.lblAddress, Me.lblSTProv, Me.lblCountry, Me.lblTIVGrid, Me.lblValves, Me.lblOther, Me.lblFilters, Me.txtFilters, Me.lblClientLocNo, Me.lblFacility, Me.line1, Me.line2, Me.line3, Me.line4, Me.line5, Me.line7, Me.line9, Me.line10, Me.line11, Me.line12, Me.line13, Me.line14, Me.line15, Me.line16, Me.line17, Me.line18, Me.line22, Me.line24, Me.line25, Me.line26, Me.line27, Me.line28, Me.line29, Me.line30, Me.line31, Me.line32, Me.line33, Me.line34, Me.line35, Me.line36, Me.line37, Me.line38, Me.line39, Me.line40, Me.lblSSHeadsAvail, Me.line6, Me.line19, Me.line20, Me.line21, Me.line66, Me.line69, Me.line23, Me.line77, Me.line8})
        Me.PageHeader1.Height = 1.65!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'lblSSHeadBoxMonthly
        '
        Me.lblSSHeadBoxMonthly.Height = 0.45!
        Me.lblSSHeadBoxMonthly.HyperLink = Nothing
        Me.lblSSHeadBoxMonthly.Left = 6.25!
        Me.lblSSHeadBoxMonthly.Name = "lblSSHeadBoxMonthly"
        Me.lblSSHeadBoxMonthly.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblSSHeadBoxMonthly.Text = "Box Check Montly"
        Me.lblSSHeadBoxMonthly.Top = 1.2!
        Me.lblSSHeadBoxMonthly.Width = 0.35!
        '
        'lblValvesLabeled
        '
        Me.lblValvesLabeled.Height = 0.45!
        Me.lblValvesLabeled.HyperLink = Nothing
        Me.lblValvesLabeled.Left = 5.4!
        Me.lblValvesLabeled.Name = "lblValvesLabeled"
        Me.lblValvesLabeled.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblValvesLabeled.Text = "Labeled"
        Me.lblValvesLabeled.Top = 1.2!
        Me.lblValvesLabeled.Width = 0.4!
        '
        'lblValvesLocked
        '
        Me.lblValvesLocked.Height = 0.45!
        Me.lblValvesLocked.HyperLink = Nothing
        Me.lblValvesLocked.Left = 5.05!
        Me.lblValvesLocked.Name = "lblValvesLocked"
        Me.lblValvesLocked.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblValvesLocked.Text = "Locked"
        Me.lblValvesLocked.Top = 1.2!
        Me.lblValvesLocked.Width = 0.35!
        '
        'lblAllValvesOpen
        '
        Me.lblAllValvesOpen.Height = 0.45!
        Me.lblAllValvesOpen.HyperLink = Nothing
        Me.lblAllValvesOpen.Left = 4.74!
        Me.lblAllValvesOpen.Name = "lblAllValvesOpen"
        Me.lblAllValvesOpen.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblAllValvesOpen.Text = "All Open"
        Me.lblAllValvesOpen.Top = 1.2!
        Me.lblAllValvesOpen.Width = 0.31!
        '
        'lblNoOfValves
        '
        Me.lblNoOfValves.Height = 0.45!
        Me.lblNoOfValves.HyperLink = Nothing
        Me.lblNoOfValves.Left = 4.42!
        Me.lblNoOfValves.Name = "lblNoOfValves"
        Me.lblNoOfValves.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblNoOfValves.Text = "No of Valves"
        Me.lblNoOfValves.Top = 1.2!
        Me.lblNoOfValves.Width = 0.32!
        '
        'lblValvesInspMonthly
        '
        Me.lblValvesInspMonthly.Height = 0.45!
        Me.lblValvesInspMonthly.HyperLink = Nothing
        Me.lblValvesInspMonthly.Left = 5.8!
        Me.lblValvesInspMonthly.Name = "lblValvesInspMonthly"
        Me.lblValvesInspMonthly.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblValvesInspMonthly.Text = "Insp. Monthly"
        Me.lblValvesInspMonthly.Top = 1.2!
        Me.lblValvesInspMonthly.Width = 0.4!
        '
        'lblSSHeadWrenchInBox
        '
        Me.lblSSHeadWrenchInBox.Height = 0.45!
        Me.lblSSHeadWrenchInBox.HyperLink = Nothing
        Me.lblSSHeadWrenchInBox.Left = 6.95!
        Me.lblSSHeadWrenchInBox.Name = "lblSSHeadWrenchInBox"
        Me.lblSSHeadWrenchInBox.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblSSHeadWrenchInBox.Text = "Wrench in Box"
        Me.lblSSHeadWrenchInBox.Top = 1.2!
        Me.lblSSHeadWrenchInBox.Width = 0.4!
        '
        'lblCorrectHeadsProvided
        '
        Me.lblCorrectHeadsProvided.Height = 0.45!
        Me.lblCorrectHeadsProvided.HyperLink = Nothing
        Me.lblCorrectHeadsProvided.Left = 7.35!
        Me.lblCorrectHeadsProvided.Name = "lblCorrectHeadsProvided"
        Me.lblCorrectHeadsProvided.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblCorrectHeadsProvided.Text = "Correct Heads Prov'd"
        Me.lblCorrectHeadsProvided.Top = 1.2!
        Me.lblCorrectHeadsProvided.Width = 0.35!
        '
        'lblATV2inDrain
        '
        Me.lblATV2inDrain.Height = 0.45!
        Me.lblATV2inDrain.HyperLink = Nothing
        Me.lblATV2inDrain.Left = 7.75!
        Me.lblATV2inDrain.Name = "lblATV2inDrain"
        Me.lblATV2inDrain.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblATV2inDrain.Text = "2in. Drain"
        Me.lblATV2inDrain.Top = 1.2!
        Me.lblATV2inDrain.Width = 0.35!
        '
        'lblATVDryPipeValve
        '
        Me.lblATVDryPipeValve.Height = 0.45!
        Me.lblATVDryPipeValve.HyperLink = Nothing
        Me.lblATVDryPipeValve.Left = 8.1!
        Me.lblATVDryPipeValve.Name = "lblATVDryPipeValve"
        Me.lblATVDryPipeValve.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblATVDryPipeValve.Text = "Dry Pipe Valve"
        Me.lblATVDryPipeValve.Top = 1.2!
        Me.lblATVDryPipeValve.Width = 0.35!
        '
        'lblATVFirePump
        '
        Me.lblATVFirePump.Height = 0.45!
        Me.lblATVFirePump.HyperLink = Nothing
        Me.lblATVFirePump.Left = 8.45!
        Me.lblATVFirePump.Name = "lblATVFirePump"
        Me.lblATVFirePump.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblATVFirePump.Text = "Fire Pump"
        Me.lblATVFirePump.Top = 1.2!
        Me.lblATVFirePump.Width = 0.35!
        '
        'lblATVAntifreeze
        '
        Me.lblATVAntifreeze.Height = 0.45!
        Me.lblATVAntifreeze.HyperLink = Nothing
        Me.lblATVAntifreeze.Left = 8.8!
        Me.lblATVAntifreeze.Name = "lblATVAntifreeze"
        Me.lblATVAntifreeze.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblATVAntifreeze.Text = "Antifreeze System(s)"
        Me.lblATVAntifreeze.Top = 1.2!
        Me.lblATVAntifreeze.Width = 0.5!
        '
        'lblATVValveTamper
        '
        Me.lblATVValveTamper.Height = 0.45!
        Me.lblATVValveTamper.HyperLink = Nothing
        Me.lblATVValveTamper.Left = 9.3!
        Me.lblATVValveTamper.Name = "lblATVValveTamper"
        Me.lblATVValveTamper.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblATVValveTamper.Text = "Valve Tamper"
        Me.lblATVValveTamper.Top = 1.2!
        Me.lblATVValveTamper.Width = 0.4!
        '
        'lblATVWaterFlow
        '
        Me.lblATVWaterFlow.Height = 0.45!
        Me.lblATVWaterFlow.HyperLink = Nothing
        Me.lblATVWaterFlow.Left = 9.7!
        Me.lblATVWaterFlow.Name = "lblATVWaterFlow"
        Me.lblATVWaterFlow.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblATVWaterFlow.Text = "Water Flow"
        Me.lblATVWaterFlow.Top = 1.2!
        Me.lblATVWaterFlow.Width = 0.35!
        '
        'lblATVDrySysLowAir
        '
        Me.lblATVDrySysLowAir.Height = 0.45!
        Me.lblATVDrySysLowAir.HyperLink = Nothing
        Me.lblATVDrySysLowAir.Left = 10.05!
        Me.lblATVDrySysLowAir.Name = "lblATVDrySysLowAir"
        Me.lblATVDrySysLowAir.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblATVDrySysLowAir.Text = "DS Low Air"
        Me.lblATVDrySysLowAir.Top = 1.2!
        Me.lblATVDrySysLowAir.Width = 0.35!
        '
        'lblImpProcObserved
        '
        Me.lblImpProcObserved.Height = 0.45!
        Me.lblImpProcObserved.HyperLink = Nothing
        Me.lblImpProcObserved.Left = 10.45!
        Me.lblImpProcObserved.Name = "lblImpProcObserved"
        Me.lblImpProcObserved.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblImpProcObserved.Text = "Imp. Proc. Observed"
        Me.lblImpProcObserved.Top = 1.2!
        Me.lblImpProcObserved.Width = 0.45!
        '
        'lblNoMissingCapsFDC
        '
        Me.lblNoMissingCapsFDC.Height = 0.45!
        Me.lblNoMissingCapsFDC.HyperLink = Nothing
        Me.lblNoMissingCapsFDC.Left = 10.9!
        Me.lblNoMissingCapsFDC.Name = "lblNoMissingCapsFDC"
        Me.lblNoMissingCapsFDC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblNoMissingCapsFDC.Text = "Caps on FD Conn."
        Me.lblNoMissingCapsFDC.Top = 1.2!
        Me.lblNoMissingCapsFDC.Width = 0.35!
        '
        'lblFireSupSysOver
        '
        Me.lblFireSupSysOver.Height = 0.45!
        Me.lblFireSupSysOver.HyperLink = Nothing
        Me.lblFireSupSysOver.Left = 11.25!
        Me.lblFireSupSysOver.Name = "lblFireSupSysOver"
        Me.lblFireSupSysOver.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblFireSupSysOver.Text = "Fire Suppr. Sys. Servicing"
        Me.lblFireSupSysOver.Top = 1.2!
        Me.lblFireSupSysOver.Width = 0.45!
        '
        'lblBlowOffCaps
        '
        Me.lblBlowOffCaps.Height = 0.45!
        Me.lblBlowOffCaps.HyperLink = Nothing
        Me.lblBlowOffCaps.Left = 11.7!
        Me.lblBlowOffCaps.Name = "lblBlowOffCaps"
        Me.lblBlowOffCaps.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblBlowOffCaps.Text = "Blow-off Caps"
        Me.lblBlowOffCaps.Top = 1.2!
        Me.lblBlowOffCaps.Width = 0.35!
        '
        'lblManualRelease
        '
        Me.lblManualRelease.Height = 0.45!
        Me.lblManualRelease.HyperLink = Nothing
        Me.lblManualRelease.Left = 12.05!
        Me.lblManualRelease.Name = "lblManualRelease"
        Me.lblManualRelease.Style = "background-color: White; font-size: 7pt; font-weight: normal; text-align: center;" & _
    " vertical-align: middle"
        Me.lblManualRelease.Text = "Manual Release Accessible"
        Me.lblManualRelease.Top = 1.2!
        Me.lblManualRelease.Width = 0.55!
        '
        'lblFireAlarmZonePosted
        '
        Me.lblFireAlarmZonePosted.Height = 0.45!
        Me.lblFireAlarmZonePosted.HyperLink = Nothing
        Me.lblFireAlarmZonePosted.Left = 13.1!
        Me.lblFireAlarmZonePosted.Name = "lblFireAlarmZonePosted"
        Me.lblFireAlarmZonePosted.Style = "background-color: White; font-size: 7pt; font-weight: normal; text-align: center;" & _
    " vertical-align: middle"
        Me.lblFireAlarmZonePosted.Text = "Alarm Zones Posted"
        Me.lblFireAlarmZonePosted.Top = 1.2!
        Me.lblFireAlarmZonePosted.Width = 0.4!
        '
        'lblMin18Clearance
        '
        Me.lblMin18Clearance.Height = 0.45!
        Me.lblMin18Clearance.HyperLink = Nothing
        Me.lblMin18Clearance.Left = 12.6!
        Me.lblMin18Clearance.Name = "lblMin18Clearance"
        Me.lblMin18Clearance.Style = "background-color: White; font-size: 7pt; font-weight: normal; text-align: center;" & _
    " vertical-align: middle"
        Me.lblMin18Clearance.Text = "Min. 18in Clearance"
        Me.lblMin18Clearance.Top = 1.2!
        Me.lblMin18Clearance.Width = 0.5!
        '
        'lblSprinklerHeads
        '
        Me.lblSprinklerHeads.Height = 0.15!
        Me.lblSprinklerHeads.HyperLink = Nothing
        Me.lblSprinklerHeads.Left = 6.25!
        Me.lblSprinklerHeads.Name = "lblSprinklerHeads"
        Me.lblSprinklerHeads.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblSprinklerHeads.Text = "Sprinkler Heads"
        Me.lblSprinklerHeads.Top = 1.05!
        Me.lblSprinklerHeads.Width = 1.45!
        '
        'lblAnnualTestVerification
        '
        Me.lblAnnualTestVerification.Height = 0.15!
        Me.lblAnnualTestVerification.HyperLink = Nothing
        Me.lblAnnualTestVerification.Left = 7.75!
        Me.lblAnnualTestVerification.Name = "lblAnnualTestVerification"
        Me.lblAnnualTestVerification.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblAnnualTestVerification.Text = "Annual Test Verification"
        Me.lblAnnualTestVerification.Top = 1.05!
        Me.lblAnnualTestVerification.Width = 2.65!
        '
        'lblClientName
        '
        Me.lblClientName.Height = 0.25!
        Me.lblClientName.HyperLink = Nothing
        Me.lblClientName.Left = 8.45!
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Style = "color: #C6D1DE; font-size: 16pt; font-style: italic; font-weight: bold; text-alig" & _
    "n: right; vertical-align: middle"
        Me.lblClientName.Text = "Company Name"
        Me.lblClientName.Top = 0.05!
        Me.lblClientName.Width = 5.075001!
        '
        'lblFireSprinklerSystemSummary
        '
        Me.lblFireSprinklerSystemSummary.Height = 0.25!
        Me.lblFireSprinklerSystemSummary.HyperLink = Nothing
        Me.lblFireSprinklerSystemSummary.Left = 8.45!
        Me.lblFireSprinklerSystemSummary.Name = "lblFireSprinklerSystemSummary"
        Me.lblFireSprinklerSystemSummary.Style = "font-size: 12pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblFireSprinklerSystemSummary.Text = "Fire - Sprinkler System Summary"
        Me.lblFireSprinklerSystemSummary.Top = 0.35!
        Me.lblFireSprinklerSystemSummary.Width = 5.075001!
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
        'lblValves
        '
        Me.lblValves.Height = 0.15!
        Me.lblValves.HyperLink = Nothing
        Me.lblValves.Left = 4.42!
        Me.lblValves.Name = "lblValves"
        Me.lblValves.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblValves.Text = "Valves"
        Me.lblValves.Top = 1.05!
        Me.lblValves.Width = 1.78!
        '
        'lblOther
        '
        Me.lblOther.Height = 0.15!
        Me.lblOther.HyperLink = Nothing
        Me.lblOther.Left = 10.45!
        Me.lblOther.Name = "lblOther"
        Me.lblOther.Style = "background-color: White; font-size: 7pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblOther.Text = "Other"
        Me.lblOther.Top = 1.05!
        Me.lblOther.Width = 3.05!
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
        'line7
        '
        Me.line7.Height = 0.6!
        Me.line7.Left = 6.2!
        Me.line7.LineWeight = 1.0!
        Me.line7.Name = "line7"
        Me.line7.Top = 1.05!
        Me.line7.Width = 0.0!
        Me.line7.X1 = 6.2!
        Me.line7.X2 = 6.2!
        Me.line7.Y1 = 1.05!
        Me.line7.Y2 = 1.65!
        '
        'line9
        '
        Me.line9.Height = 0.6!
        Me.line9.Left = 7.75!
        Me.line9.LineWeight = 1.0!
        Me.line9.Name = "line9"
        Me.line9.Top = 1.05!
        Me.line9.Width = 0.0!
        Me.line9.X1 = 7.75!
        Me.line9.X2 = 7.75!
        Me.line9.Y1 = 1.05!
        Me.line9.Y2 = 1.65!
        '
        'line10
        '
        Me.line10.Height = 0.4499999!
        Me.line10.Left = 7.35!
        Me.line10.LineWeight = 1.0!
        Me.line10.Name = "line10"
        Me.line10.Top = 1.2!
        Me.line10.Width = 0.0!
        Me.line10.X1 = 7.35!
        Me.line10.X2 = 7.35!
        Me.line10.Y1 = 1.2!
        Me.line10.Y2 = 1.65!
        '
        'line11
        '
        Me.line11.Height = 0.6!
        Me.line11.Left = 7.7!
        Me.line11.LineWeight = 1.0!
        Me.line11.Name = "line11"
        Me.line11.Top = 1.05!
        Me.line11.Width = 0.0!
        Me.line11.X1 = 7.7!
        Me.line11.X2 = 7.7!
        Me.line11.Y1 = 1.05!
        Me.line11.Y2 = 1.65!
        '
        'line12
        '
        Me.line12.Height = 0.6!
        Me.line12.Left = 10.4!
        Me.line12.LineWeight = 1.0!
        Me.line12.Name = "line12"
        Me.line12.Top = 1.05!
        Me.line12.Width = 0.0!
        Me.line12.X1 = 10.4!
        Me.line12.X2 = 10.4!
        Me.line12.Y1 = 1.05!
        Me.line12.Y2 = 1.65!
        '
        'line13
        '
        Me.line13.Height = 0.4499999!
        Me.line13.Left = 11.25!
        Me.line13.LineWeight = 1.0!
        Me.line13.Name = "line13"
        Me.line13.Top = 1.2!
        Me.line13.Width = 0.0!
        Me.line13.X1 = 11.25!
        Me.line13.X2 = 11.25!
        Me.line13.Y1 = 1.2!
        Me.line13.Y2 = 1.65!
        '
        'line14
        '
        Me.line14.Height = 0.6!
        Me.line14.Left = 10.45!
        Me.line14.LineWeight = 1.0!
        Me.line14.Name = "line14"
        Me.line14.Top = 1.05!
        Me.line14.Width = 0.0!
        Me.line14.X1 = 10.45!
        Me.line14.X2 = 10.45!
        Me.line14.Y1 = 1.05!
        Me.line14.Y2 = 1.65!
        '
        'line15
        '
        Me.line15.Height = 0.6!
        Me.line15.Left = 13.5!
        Me.line15.LineWeight = 1.0!
        Me.line15.Name = "line15"
        Me.line15.Top = 1.05!
        Me.line15.Width = 0.0!
        Me.line15.X1 = 13.5!
        Me.line15.X2 = 13.5!
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
        Me.line16.Width = 1.78!
        Me.line16.X1 = 4.42!
        Me.line16.X2 = 6.2!
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
        Me.line17.Width = 1.78!
        Me.line17.X1 = 4.42!
        Me.line17.X2 = 6.2!
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
        Me.line18.Width = 1.78!
        Me.line18.X1 = 4.42!
        Me.line18.X2 = 6.2!
        Me.line18.Y1 = 1.05!
        Me.line18.Y2 = 1.05!
        '
        'line22
        '
        Me.line22.Height = 0.0!
        Me.line22.Left = 7.75!
        Me.line22.LineWeight = 1.0!
        Me.line22.Name = "line22"
        Me.line22.Top = 1.65!
        Me.line22.Width = 2.65!
        Me.line22.X1 = 7.75!
        Me.line22.X2 = 10.4!
        Me.line22.Y1 = 1.65!
        Me.line22.Y2 = 1.65!
        '
        'line24
        '
        Me.line24.Height = 0.0!
        Me.line24.Left = 6.25!
        Me.line24.LineWeight = 1.0!
        Me.line24.Name = "line24"
        Me.line24.Top = 1.05!
        Me.line24.Width = 1.45!
        Me.line24.X1 = 6.25!
        Me.line24.X2 = 7.7!
        Me.line24.Y1 = 1.05!
        Me.line24.Y2 = 1.05!
        '
        'line25
        '
        Me.line25.Height = 0.4499999!
        Me.line25.Left = 8.1!
        Me.line25.LineWeight = 1.0!
        Me.line25.Name = "line25"
        Me.line25.Top = 1.2!
        Me.line25.Width = 0.0!
        Me.line25.X1 = 8.1!
        Me.line25.X2 = 8.1!
        Me.line25.Y1 = 1.2!
        Me.line25.Y2 = 1.65!
        '
        'line26
        '
        Me.line26.Height = 0.0!
        Me.line26.Left = 7.75!
        Me.line26.LineWeight = 1.0!
        Me.line26.Name = "line26"
        Me.line26.Top = 1.2!
        Me.line26.Width = 2.65!
        Me.line26.X1 = 7.75!
        Me.line26.X2 = 10.4!
        Me.line26.Y1 = 1.2!
        Me.line26.Y2 = 1.2!
        '
        'line27
        '
        Me.line27.Height = 0.0!
        Me.line27.Left = 7.75!
        Me.line27.LineWeight = 1.0!
        Me.line27.Name = "line27"
        Me.line27.Top = 1.05!
        Me.line27.Width = 2.65!
        Me.line27.X1 = 7.75!
        Me.line27.X2 = 10.4!
        Me.line27.Y1 = 1.05!
        Me.line27.Y2 = 1.05!
        '
        'line28
        '
        Me.line28.Height = 0.0!
        Me.line28.Left = 10.45!
        Me.line28.LineWeight = 1.0!
        Me.line28.Name = "line28"
        Me.line28.Top = 1.65!
        Me.line28.Width = 3.05!
        Me.line28.X1 = 10.45!
        Me.line28.X2 = 13.5!
        Me.line28.Y1 = 1.65!
        Me.line28.Y2 = 1.65!
        '
        'line29
        '
        Me.line29.Height = 0.0!
        Me.line29.Left = 10.45!
        Me.line29.LineWeight = 1.0!
        Me.line29.Name = "line29"
        Me.line29.Top = 1.2!
        Me.line29.Width = 3.05!
        Me.line29.X1 = 10.45!
        Me.line29.X2 = 13.5!
        Me.line29.Y1 = 1.2!
        Me.line29.Y2 = 1.2!
        '
        'line30
        '
        Me.line30.Height = 0.0!
        Me.line30.Left = 10.45!
        Me.line30.LineWeight = 1.0!
        Me.line30.Name = "line30"
        Me.line30.Top = 1.05!
        Me.line30.Width = 3.05!
        Me.line30.X1 = 10.45!
        Me.line30.X2 = 13.5!
        Me.line30.Y1 = 1.05!
        Me.line30.Y2 = 1.05!
        '
        'line31
        '
        Me.line31.Height = 0.4499999!
        Me.line31.Left = 13.1!
        Me.line31.LineWeight = 1.0!
        Me.line31.Name = "line31"
        Me.line31.Top = 1.2!
        Me.line31.Width = 0.0!
        Me.line31.X1 = 13.1!
        Me.line31.X2 = 13.1!
        Me.line31.Y1 = 1.2!
        Me.line31.Y2 = 1.65!
        '
        'line32
        '
        Me.line32.Height = 0.4499999!
        Me.line32.Left = 12.6!
        Me.line32.LineWeight = 1.0!
        Me.line32.Name = "line32"
        Me.line32.Top = 1.2!
        Me.line32.Width = 0.0!
        Me.line32.X1 = 12.6!
        Me.line32.X2 = 12.6!
        Me.line32.Y1 = 1.2!
        Me.line32.Y2 = 1.65!
        '
        'line33
        '
        Me.line33.Height = 0.4499999!
        Me.line33.Left = 12.05!
        Me.line33.LineWeight = 1.0!
        Me.line33.Name = "line33"
        Me.line33.Top = 1.2!
        Me.line33.Width = 0.0!
        Me.line33.X1 = 12.05!
        Me.line33.X2 = 12.05!
        Me.line33.Y1 = 1.2!
        Me.line33.Y2 = 1.65!
        '
        'line34
        '
        Me.line34.Height = 0.4499999!
        Me.line34.Left = 11.7!
        Me.line34.LineWeight = 1.0!
        Me.line34.Name = "line34"
        Me.line34.Top = 1.2!
        Me.line34.Width = 0.0!
        Me.line34.X1 = 11.7!
        Me.line34.X2 = 11.7!
        Me.line34.Y1 = 1.2!
        Me.line34.Y2 = 1.65!
        '
        'line35
        '
        Me.line35.Height = 0.4499999!
        Me.line35.Left = 10.9!
        Me.line35.LineWeight = 1.0!
        Me.line35.Name = "line35"
        Me.line35.Top = 1.2!
        Me.line35.Width = 0.0!
        Me.line35.X1 = 10.9!
        Me.line35.X2 = 10.9!
        Me.line35.Y1 = 1.2!
        Me.line35.Y2 = 1.65!
        '
        'line36
        '
        Me.line36.Height = 0.4499999!
        Me.line36.Left = 10.05!
        Me.line36.LineWeight = 1.0!
        Me.line36.Name = "line36"
        Me.line36.Top = 1.2!
        Me.line36.Width = 0.0!
        Me.line36.X1 = 10.05!
        Me.line36.X2 = 10.05!
        Me.line36.Y1 = 1.2!
        Me.line36.Y2 = 1.65!
        '
        'line37
        '
        Me.line37.Height = 0.4499999!
        Me.line37.Left = 9.7!
        Me.line37.LineWeight = 1.0!
        Me.line37.Name = "line37"
        Me.line37.Top = 1.2!
        Me.line37.Width = 0.0!
        Me.line37.X1 = 9.7!
        Me.line37.X2 = 9.7!
        Me.line37.Y1 = 1.2!
        Me.line37.Y2 = 1.65!
        '
        'line38
        '
        Me.line38.Height = 0.4499999!
        Me.line38.Left = 9.3!
        Me.line38.LineWeight = 1.0!
        Me.line38.Name = "line38"
        Me.line38.Top = 1.2!
        Me.line38.Width = 0.0!
        Me.line38.X1 = 9.3!
        Me.line38.X2 = 9.3!
        Me.line38.Y1 = 1.2!
        Me.line38.Y2 = 1.65!
        '
        'line39
        '
        Me.line39.Height = 0.4499999!
        Me.line39.Left = 8.8!
        Me.line39.LineWeight = 1.0!
        Me.line39.Name = "line39"
        Me.line39.Top = 1.2!
        Me.line39.Width = 0.0!
        Me.line39.X1 = 8.8!
        Me.line39.X2 = 8.8!
        Me.line39.Y1 = 1.2!
        Me.line39.Y2 = 1.65!
        '
        'line40
        '
        Me.line40.Height = 0.4499999!
        Me.line40.Left = 8.45!
        Me.line40.LineWeight = 1.0!
        Me.line40.Name = "line40"
        Me.line40.Top = 1.2!
        Me.line40.Width = 0.0!
        Me.line40.X1 = 8.45!
        Me.line40.X2 = 8.45!
        Me.line40.Y1 = 1.2!
        Me.line40.Y2 = 1.65!
        '
        'lblSSHeadsAvail
        '
        Me.lblSSHeadsAvail.Height = 0.45!
        Me.lblSSHeadsAvail.HyperLink = Nothing
        Me.lblSSHeadsAvail.Left = 6.6!
        Me.lblSSHeadsAvail.Name = "lblSSHeadsAvail"
        Me.lblSSHeadsAvail.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblSSHeadsAvail.Text = "Spare Heads Avail."
        Me.lblSSHeadsAvail.Top = 1.2!
        Me.lblSSHeadsAvail.Width = 0.35!
        '
        'line6
        '
        Me.line6.Height = 0.4499999!
        Me.line6.Left = 6.6!
        Me.line6.LineWeight = 1.0!
        Me.line6.Name = "line6"
        Me.line6.Top = 1.2!
        Me.line6.Width = 0.0!
        Me.line6.X1 = 6.6!
        Me.line6.X2 = 6.6!
        Me.line6.Y1 = 1.2!
        Me.line6.Y2 = 1.65!
        '
        'line19
        '
        Me.line19.Height = 0.4499999!
        Me.line19.Left = 4.74!
        Me.line19.LineWeight = 1.0!
        Me.line19.Name = "line19"
        Me.line19.Top = 1.2!
        Me.line19.Width = 0.0!
        Me.line19.X1 = 4.74!
        Me.line19.X2 = 4.74!
        Me.line19.Y1 = 1.2!
        Me.line19.Y2 = 1.65!
        '
        'line20
        '
        Me.line20.Height = 0.6!
        Me.line20.Left = 6.25!
        Me.line20.LineWeight = 1.0!
        Me.line20.Name = "line20"
        Me.line20.Top = 1.05!
        Me.line20.Width = 0.0!
        Me.line20.X1 = 6.25!
        Me.line20.X2 = 6.25!
        Me.line20.Y1 = 1.05!
        Me.line20.Y2 = 1.65!
        '
        'line21
        '
        Me.line21.Height = 0.4499999!
        Me.line21.Left = 5.4!
        Me.line21.LineWeight = 1.0!
        Me.line21.Name = "line21"
        Me.line21.Top = 1.2!
        Me.line21.Width = 0.0!
        Me.line21.X1 = 5.4!
        Me.line21.X2 = 5.4!
        Me.line21.Y1 = 1.2!
        Me.line21.Y2 = 1.65!
        '
        'line66
        '
        Me.line66.Height = 0.4499999!
        Me.line66.Left = 5.8!
        Me.line66.LineWeight = 1.0!
        Me.line66.Name = "line66"
        Me.line66.Top = 1.2!
        Me.line66.Width = 0.0!
        Me.line66.X1 = 5.8!
        Me.line66.X2 = 5.8!
        Me.line66.Y1 = 1.2!
        Me.line66.Y2 = 1.65!
        '
        'line69
        '
        Me.line69.Height = 0.4499999!
        Me.line69.Left = 6.95!
        Me.line69.LineWeight = 1.0!
        Me.line69.Name = "line69"
        Me.line69.Top = 1.2!
        Me.line69.Width = 0.0!
        Me.line69.X1 = 6.95!
        Me.line69.X2 = 6.95!
        Me.line69.Y1 = 1.2!
        Me.line69.Y2 = 1.65!
        '
        'line23
        '
        Me.line23.Height = 0.0!
        Me.line23.Left = 6.25!
        Me.line23.LineWeight = 1.0!
        Me.line23.Name = "line23"
        Me.line23.Top = 1.2!
        Me.line23.Width = 1.45!
        Me.line23.X1 = 6.25!
        Me.line23.X2 = 7.7!
        Me.line23.Y1 = 1.2!
        Me.line23.Y2 = 1.2!
        '
        'line77
        '
        Me.line77.Height = 0.4499999!
        Me.line77.Left = 5.05!
        Me.line77.LineWeight = 1.0!
        Me.line77.Name = "line77"
        Me.line77.Top = 1.2!
        Me.line77.Width = 0.0!
        Me.line77.X1 = 5.05!
        Me.line77.X2 = 5.05!
        Me.line77.Y1 = 1.2!
        Me.line77.Y2 = 1.65!
        '
        'line8
        '
        Me.line8.Height = 0.0!
        Me.line8.Left = 6.25!
        Me.line8.LineWeight = 1.0!
        Me.line8.Name = "line8"
        Me.line8.Top = 1.65!
        Me.line8.Width = 1.45!
        Me.line8.X1 = 6.25!
        Me.line8.X2 = 7.7!
        Me.line8.Y1 = 1.65!
        Me.line8.Y2 = 1.65!
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtCorrectHeadsProvidedC, Me.txtSSHeadWrenchInBoxC, Me.txtSSHeadsAvailC, Me.txtSSHeadBoxMonthlyC, Me.txtValvesInspMonthlyC, Me.txtValvesLabeledC, Me.txtValvesLockedC, Me.txtAllValvesOpenC, Me.txtNoOfValvesC, Me.txtNoMissingCapsFDCC, Me.txtFireAlarmZonePostedC, Me.txtMin18ClearanceC, Me.txtManualReleaseC, Me.txtBlowOffCapsC, Me.txtFireSupSysOverC, Me.txtImpProcObservedC, Me.txtATVDrySysLowAirC, Me.txtATVWaterFlowC, Me.txtATVValveTamperC, Me.txtATVAntifreezeC, Me.txtATVFirePumpC, Me.txtATV2inDrainC, Me.txtATVDryPipeValveC, Me.txtATVDryPipeValve, Me.txtAddress, Me.txtDivision2, Me.txtFileNo, Me.txtSurveyDate, Me.txtCity, Me.txtSTProv, Me.txtCountry, Me.txtTIV, Me.txtATV2inDrain, Me.txtATVFirePump, Me.txtATVAntifreeze, Me.txtATVValveTamper, Me.txtATVWaterFlow, Me.txtATVDrySysLowAir, Me.txtImpProcObserved, Me.txtFireSupSysOver, Me.txtBlowOffCaps, Me.txtManualRelease, Me.txtMin18Clearance, Me.txtFireAlarmZonePosted, Me.txtFacility, Me.txtClientLocNo, Me.txtNoMissingCapsFDC, Me.line41, Me.line42, Me.line43, Me.line44, Me.line45, Me.line46, Me.line47, Me.line48, Me.line49, Me.line50, Me.line51, Me.line52, Me.line53, Me.line54, Me.line55, Me.line56, Me.line57, Me.line58, Me.line59, Me.line60, Me.line61, Me.line62, Me.line63, Me.line64, Me.line65, Me.line67, Me.line68, Me.line70, Me.line71, Me.line72, Me.line75, Me.line76, Me.txtNoOfValves, Me.txtAllValvesOpen, Me.txtValvesLocked, Me.txtValvesLabeled, Me.txtValvesInspMonthly, Me.txtSSHeadBoxMonthly, Me.txtSSHeadsAvail, Me.txtSSHeadWrenchInBox, Me.txtCorrectHeadsProvided, Me.line73, Me.line74, Me.line78, Me.line79, Me.line80, Me.line81, Me.line82, Me.line83, Me.line84, Me.line85, Me.line86, Me.line87, Me.line88, Me.line89, Me.line90})
        Me.Detail1.Height = 0.363!
        Me.Detail1.KeepTogether = True
        Me.Detail1.Name = "Detail1"
        '
        'txtCorrectHeadsProvidedC
        '
        Me.txtCorrectHeadsProvidedC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtCorrectHeadsProvidedC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtCorrectHeadsProvidedC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtCorrectHeadsProvidedC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtCorrectHeadsProvidedC.DataField = "CorrectHeadsProvidedC"
        Me.txtCorrectHeadsProvidedC.Height = 0.1125!
        Me.txtCorrectHeadsProvidedC.Left = 7.429999!
        Me.txtCorrectHeadsProvidedC.Name = "txtCorrectHeadsProvidedC"
        Me.txtCorrectHeadsProvidedC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtCorrectHeadsProvidedC.Text = "CorrectHeadsProvidedC"
        Me.txtCorrectHeadsProvidedC.Top = 0.125!
        Me.txtCorrectHeadsProvidedC.Visible = False
        Me.txtCorrectHeadsProvidedC.Width = 0.224997!
        '
        'txtSSHeadWrenchInBoxC
        '
        Me.txtSSHeadWrenchInBoxC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtSSHeadWrenchInBoxC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtSSHeadWrenchInBoxC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtSSHeadWrenchInBoxC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtSSHeadWrenchInBoxC.DataField = "SSHeadWrenchInBoxC"
        Me.txtSSHeadWrenchInBoxC.Height = 0.1125!
        Me.txtSSHeadWrenchInBoxC.Left = 7.03!
        Me.txtSSHeadWrenchInBoxC.Name = "txtSSHeadWrenchInBoxC"
        Me.txtSSHeadWrenchInBoxC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtSSHeadWrenchInBoxC.Text = "SSHeadWrenchInBoxC"
        Me.txtSSHeadWrenchInBoxC.Top = 0.125!
        Me.txtSSHeadWrenchInBoxC.Visible = False
        Me.txtSSHeadWrenchInBoxC.Width = 0.2749972!
        '
        'txtSSHeadsAvailC
        '
        Me.txtSSHeadsAvailC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtSSHeadsAvailC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtSSHeadsAvailC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtSSHeadsAvailC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtSSHeadsAvailC.DataField = "SSHeadsAvailC"
        Me.txtSSHeadsAvailC.Height = 0.1125!
        Me.txtSSHeadsAvailC.Left = 6.679999!
        Me.txtSSHeadsAvailC.Name = "txtSSHeadsAvailC"
        Me.txtSSHeadsAvailC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtSSHeadsAvailC.Text = "SSHeadsAvailC"
        Me.txtSSHeadsAvailC.Top = 0.125!
        Me.txtSSHeadsAvailC.Visible = False
        Me.txtSSHeadsAvailC.Width = 0.224997!
        '
        'txtSSHeadBoxMonthlyC
        '
        Me.txtSSHeadBoxMonthlyC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtSSHeadBoxMonthlyC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtSSHeadBoxMonthlyC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtSSHeadBoxMonthlyC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtSSHeadBoxMonthlyC.DataField = "SSHeadBoxMonthlyC"
        Me.txtSSHeadBoxMonthlyC.Height = 0.1125!
        Me.txtSSHeadBoxMonthlyC.Left = 6.33!
        Me.txtSSHeadBoxMonthlyC.Name = "txtSSHeadBoxMonthlyC"
        Me.txtSSHeadBoxMonthlyC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtSSHeadBoxMonthlyC.Text = "SSHeadBoxMonthlyC"
        Me.txtSSHeadBoxMonthlyC.Top = 0.125!
        Me.txtSSHeadBoxMonthlyC.Visible = False
        Me.txtSSHeadBoxMonthlyC.Width = 0.224997!
        '
        'txtValvesInspMonthlyC
        '
        Me.txtValvesInspMonthlyC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtValvesInspMonthlyC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtValvesInspMonthlyC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtValvesInspMonthlyC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtValvesInspMonthlyC.DataField = "ValvesInspMonthlyC"
        Me.txtValvesInspMonthlyC.Height = 0.1125!
        Me.txtValvesInspMonthlyC.Left = 5.879999!
        Me.txtValvesInspMonthlyC.Name = "txtValvesInspMonthlyC"
        Me.txtValvesInspMonthlyC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtValvesInspMonthlyC.Text = "ValvesInspMonthlyC"
        Me.txtValvesInspMonthlyC.Top = 0.125!
        Me.txtValvesInspMonthlyC.Visible = False
        Me.txtValvesInspMonthlyC.Width = 0.2749972!
        '
        'txtValvesLabeledC
        '
        Me.txtValvesLabeledC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtValvesLabeledC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtValvesLabeledC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtValvesLabeledC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtValvesLabeledC.DataField = "ValvesLabeledC"
        Me.txtValvesLabeledC.Height = 0.1125!
        Me.txtValvesLabeledC.Left = 5.479999!
        Me.txtValvesLabeledC.Name = "txtValvesLabeledC"
        Me.txtValvesLabeledC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtValvesLabeledC.Text = "ValvesLabeledC"
        Me.txtValvesLabeledC.Top = 0.125!
        Me.txtValvesLabeledC.Visible = False
        Me.txtValvesLabeledC.Width = 0.2749972!
        '
        'txtValvesLockedC
        '
        Me.txtValvesLockedC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtValvesLockedC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtValvesLockedC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtValvesLockedC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtValvesLockedC.DataField = "ValvesLockedC"
        Me.txtValvesLockedC.Height = 0.1125!
        Me.txtValvesLockedC.Left = 5.129998!
        Me.txtValvesLockedC.Name = "txtValvesLockedC"
        Me.txtValvesLockedC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtValvesLockedC.Text = "ValvesLockedC"
        Me.txtValvesLockedC.Top = 0.125!
        Me.txtValvesLockedC.Visible = False
        Me.txtValvesLockedC.Width = 0.224997!
        '
        'txtAllValvesOpenC
        '
        Me.txtAllValvesOpenC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtAllValvesOpenC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtAllValvesOpenC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtAllValvesOpenC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtAllValvesOpenC.DataField = "AllValvesOpenC"
        Me.txtAllValvesOpenC.Height = 0.1125!
        Me.txtAllValvesOpenC.Left = 4.819999!
        Me.txtAllValvesOpenC.Name = "txtAllValvesOpenC"
        Me.txtAllValvesOpenC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtAllValvesOpenC.Text = "AllValvesOpenC"
        Me.txtAllValvesOpenC.Top = 0.125!
        Me.txtAllValvesOpenC.Visible = False
        Me.txtAllValvesOpenC.Width = 0.1849971!
        '
        'txtNoOfValvesC
        '
        Me.txtNoOfValvesC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtNoOfValvesC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtNoOfValvesC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtNoOfValvesC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtNoOfValvesC.DataField = "NoOfValvesC"
        Me.txtNoOfValvesC.Height = 0.1125!
        Me.txtNoOfValvesC.Left = 4.499998!
        Me.txtNoOfValvesC.Name = "txtNoOfValvesC"
        Me.txtNoOfValvesC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtNoOfValvesC.Text = "NoOfValvesC"
        Me.txtNoOfValvesC.Top = 0.125!
        Me.txtNoOfValvesC.Visible = False
        Me.txtNoOfValvesC.Width = 0.1949973!
        '
        'txtNoMissingCapsFDCC
        '
        Me.txtNoMissingCapsFDCC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtNoMissingCapsFDCC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtNoMissingCapsFDCC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtNoMissingCapsFDCC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtNoMissingCapsFDCC.DataField = "NoMissingCapsFDCC"
        Me.txtNoMissingCapsFDCC.Height = 0.1125!
        Me.txtNoMissingCapsFDCC.Left = 10.98!
        Me.txtNoMissingCapsFDCC.Name = "txtNoMissingCapsFDCC"
        Me.txtNoMissingCapsFDCC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtNoMissingCapsFDCC.Text = "NoMissingCapsFDCC"
        Me.txtNoMissingCapsFDCC.Top = 0.125!
        Me.txtNoMissingCapsFDCC.Visible = False
        Me.txtNoMissingCapsFDCC.Width = 0.2249975!
        '
        'txtFireAlarmZonePostedC
        '
        Me.txtFireAlarmZonePostedC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtFireAlarmZonePostedC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtFireAlarmZonePostedC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtFireAlarmZonePostedC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtFireAlarmZonePostedC.DataField = "FireAlarmZonePostedC"
        Me.txtFireAlarmZonePostedC.Height = 0.1125!
        Me.txtFireAlarmZonePostedC.Left = 13.205!
        Me.txtFireAlarmZonePostedC.Name = "txtFireAlarmZonePostedC"
        Me.txtFireAlarmZonePostedC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtFireAlarmZonePostedC.Text = "FireAlarmZonePostedC"
        Me.txtFireAlarmZonePostedC.Top = 0.1375!
        Me.txtFireAlarmZonePostedC.Visible = False
        Me.txtFireAlarmZonePostedC.Width = 0.2749968!
        '
        'txtMin18ClearanceC
        '
        Me.txtMin18ClearanceC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMin18ClearanceC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMin18ClearanceC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMin18ClearanceC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMin18ClearanceC.DataField = "Min18ClearanceC"
        Me.txtMin18ClearanceC.Height = 0.1125!
        Me.txtMin18ClearanceC.Left = 12.68!
        Me.txtMin18ClearanceC.Name = "txtMin18ClearanceC"
        Me.txtMin18ClearanceC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtMin18ClearanceC.Text = "Min18ClearanceC"
        Me.txtMin18ClearanceC.Top = 0.125!
        Me.txtMin18ClearanceC.Visible = False
        Me.txtMin18ClearanceC.Width = 0.3749971!
        '
        'txtManualReleaseC
        '
        Me.txtManualReleaseC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtManualReleaseC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtManualReleaseC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtManualReleaseC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtManualReleaseC.DataField = "ManualReleaseC"
        Me.txtManualReleaseC.Height = 0.1125!
        Me.txtManualReleaseC.Left = 12.13!
        Me.txtManualReleaseC.Name = "txtManualReleaseC"
        Me.txtManualReleaseC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtManualReleaseC.Text = "ManualReleaseC"
        Me.txtManualReleaseC.Top = 0.125!
        Me.txtManualReleaseC.Visible = False
        Me.txtManualReleaseC.Width = 0.4249973!
        '
        'txtBlowOffCapsC
        '
        Me.txtBlowOffCapsC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtBlowOffCapsC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtBlowOffCapsC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtBlowOffCapsC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtBlowOffCapsC.DataField = "BlowOffCapsC"
        Me.txtBlowOffCapsC.Height = 0.1125!
        Me.txtBlowOffCapsC.Left = 11.78!
        Me.txtBlowOffCapsC.Name = "txtBlowOffCapsC"
        Me.txtBlowOffCapsC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtBlowOffCapsC.Text = "BlowOffCapsC"
        Me.txtBlowOffCapsC.Top = 0.125!
        Me.txtBlowOffCapsC.Visible = False
        Me.txtBlowOffCapsC.Width = 0.2249975!
        '
        'txtFireSupSysOverC
        '
        Me.txtFireSupSysOverC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtFireSupSysOverC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtFireSupSysOverC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtFireSupSysOverC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtFireSupSysOverC.DataField = "FireSupSysOverC"
        Me.txtFireSupSysOverC.Height = 0.1125!
        Me.txtFireSupSysOverC.Left = 11.33!
        Me.txtFireSupSysOverC.Name = "txtFireSupSysOverC"
        Me.txtFireSupSysOverC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtFireSupSysOverC.Text = "FireSupSysOverC"
        Me.txtFireSupSysOverC.Top = 0.125!
        Me.txtFireSupSysOverC.Visible = False
        Me.txtFireSupSysOverC.Width = 0.3249969!
        '
        'txtImpProcObservedC
        '
        Me.txtImpProcObservedC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtImpProcObservedC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtImpProcObservedC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtImpProcObservedC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtImpProcObservedC.DataField = "ImpProcObservedC"
        Me.txtImpProcObservedC.Height = 0.1125!
        Me.txtImpProcObservedC.Left = 10.53!
        Me.txtImpProcObservedC.Name = "txtImpProcObservedC"
        Me.txtImpProcObservedC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtImpProcObservedC.Text = "ImpProcObservedC"
        Me.txtImpProcObservedC.Top = 0.125!
        Me.txtImpProcObservedC.Visible = False
        Me.txtImpProcObservedC.Width = 0.3249969!
        '
        'txtATVDrySysLowAirC
        '
        Me.txtATVDrySysLowAirC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtATVDrySysLowAirC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtATVDrySysLowAirC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtATVDrySysLowAirC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtATVDrySysLowAirC.DataField = "ATVDrySysLowAirC"
        Me.txtATVDrySysLowAirC.Height = 0.1125!
        Me.txtATVDrySysLowAirC.Left = 10.13!
        Me.txtATVDrySysLowAirC.Name = "txtATVDrySysLowAirC"
        Me.txtATVDrySysLowAirC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtATVDrySysLowAirC.Text = "ATVDrySysLowAirC"
        Me.txtATVDrySysLowAirC.Top = 0.125!
        Me.txtATVDrySysLowAirC.Visible = False
        Me.txtATVDrySysLowAirC.Width = 0.2249975!
        '
        'txtATVWaterFlowC
        '
        Me.txtATVWaterFlowC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtATVWaterFlowC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtATVWaterFlowC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtATVWaterFlowC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtATVWaterFlowC.DataField = "ATVWaterFlowC"
        Me.txtATVWaterFlowC.Height = 0.1125!
        Me.txtATVWaterFlowC.Left = 9.780001!
        Me.txtATVWaterFlowC.Name = "txtATVWaterFlowC"
        Me.txtATVWaterFlowC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtATVWaterFlowC.Text = "ATVWaterFlowC"
        Me.txtATVWaterFlowC.Top = 0.125!
        Me.txtATVWaterFlowC.Visible = False
        Me.txtATVWaterFlowC.Width = 0.2249975!
        '
        'txtATVValveTamperC
        '
        Me.txtATVValveTamperC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtATVValveTamperC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtATVValveTamperC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtATVValveTamperC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtATVValveTamperC.DataField = "ATVValveTamperC"
        Me.txtATVValveTamperC.Height = 0.1125!
        Me.txtATVValveTamperC.Left = 9.379999!
        Me.txtATVValveTamperC.Name = "txtATVValveTamperC"
        Me.txtATVValveTamperC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtATVValveTamperC.Text = "ATVValveTamperC"
        Me.txtATVValveTamperC.Top = 0.125!
        Me.txtATVValveTamperC.Visible = False
        Me.txtATVValveTamperC.Width = 0.2749968!
        '
        'txtATVAntifreezeC
        '
        Me.txtATVAntifreezeC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtATVAntifreezeC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtATVAntifreezeC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtATVAntifreezeC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtATVAntifreezeC.DataField = "ATVAntifreezeC"
        Me.txtATVAntifreezeC.Height = 0.1125!
        Me.txtATVAntifreezeC.Left = 8.880003!
        Me.txtATVAntifreezeC.Name = "txtATVAntifreezeC"
        Me.txtATVAntifreezeC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtATVAntifreezeC.Text = "ATVAntifreezeC"
        Me.txtATVAntifreezeC.Top = 0.125!
        Me.txtATVAntifreezeC.Visible = False
        Me.txtATVAntifreezeC.Width = 0.3749971!
        '
        'txtATVFirePumpC
        '
        Me.txtATVFirePumpC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtATVFirePumpC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtATVFirePumpC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtATVFirePumpC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtATVFirePumpC.DataField = "ATVFirePumpC"
        Me.txtATVFirePumpC.Height = 0.1125!
        Me.txtATVFirePumpC.Left = 8.530001!
        Me.txtATVFirePumpC.Name = "txtATVFirePumpC"
        Me.txtATVFirePumpC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtATVFirePumpC.Text = "ATVFirePumpC"
        Me.txtATVFirePumpC.Top = 0.125!
        Me.txtATVFirePumpC.Visible = False
        Me.txtATVFirePumpC.Width = 0.2249975!
        '
        'txtATV2inDrainC
        '
        Me.txtATV2inDrainC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtATV2inDrainC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtATV2inDrainC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtATV2inDrainC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtATV2inDrainC.DataField = "ATV2inDrainC"
        Me.txtATV2inDrainC.Height = 0.1125!
        Me.txtATV2inDrainC.Left = 7.83!
        Me.txtATV2inDrainC.Name = "txtATV2inDrainC"
        Me.txtATV2inDrainC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtATV2inDrainC.Text = "ATV2inDrainC"
        Me.txtATV2inDrainC.Top = 0.125!
        Me.txtATV2inDrainC.Visible = False
        Me.txtATV2inDrainC.Width = 0.224997!
        '
        'txtATVDryPipeValveC
        '
        Me.txtATVDryPipeValveC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtATVDryPipeValveC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtATVDryPipeValveC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtATVDryPipeValveC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtATVDryPipeValveC.DataField = "ATVDryPipeValveC"
        Me.txtATVDryPipeValveC.Height = 0.1125!
        Me.txtATVDryPipeValveC.Left = 8.18!
        Me.txtATVDryPipeValveC.Name = "txtATVDryPipeValveC"
        Me.txtATVDryPipeValveC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtATVDryPipeValveC.Text = "ATVDryPipeValveC"
        Me.txtATVDryPipeValveC.Top = 0.125!
        Me.txtATVDryPipeValveC.Visible = False
        Me.txtATVDryPipeValveC.Width = 0.2249975!
        '
        'txtATVDryPipeValve
        '
        Me.txtATVDryPipeValve.DataField = "ATVDryPipeValve"
        Me.txtATVDryPipeValve.Height = 0.3!
        Me.txtATVDryPipeValve.Left = 8.1!
        Me.txtATVDryPipeValve.Name = "txtATVDryPipeValve"
        Me.txtATVDryPipeValve.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtATVDryPipeValve.Text = "ATVDryPipeValve"
        Me.txtATVDryPipeValve.Top = 0.05!
        Me.txtATVDryPipeValve.Width = 0.35!
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
        'txtATV2inDrain
        '
        Me.txtATV2inDrain.DataField = "ATV2inDrain"
        Me.txtATV2inDrain.Height = 0.3!
        Me.txtATV2inDrain.Left = 7.75!
        Me.txtATV2inDrain.Name = "txtATV2inDrain"
        Me.txtATV2inDrain.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtATV2inDrain.Text = "ATV2inDrain"
        Me.txtATV2inDrain.Top = 0.05!
        Me.txtATV2inDrain.Width = 0.35!
        '
        'txtATVFirePump
        '
        Me.txtATVFirePump.DataField = "ATVFirePump"
        Me.txtATVFirePump.Height = 0.3!
        Me.txtATVFirePump.Left = 8.45!
        Me.txtATVFirePump.Name = "txtATVFirePump"
        Me.txtATVFirePump.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtATVFirePump.Text = "ATVFirePump"
        Me.txtATVFirePump.Top = 0.05!
        Me.txtATVFirePump.Width = 0.35!
        '
        'txtATVAntifreeze
        '
        Me.txtATVAntifreeze.DataField = "ATVAntifreeze"
        Me.txtATVAntifreeze.Height = 0.3!
        Me.txtATVAntifreeze.Left = 8.8!
        Me.txtATVAntifreeze.Name = "txtATVAntifreeze"
        Me.txtATVAntifreeze.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtATVAntifreeze.Text = "ATVAntifreeze"
        Me.txtATVAntifreeze.Top = 0.05!
        Me.txtATVAntifreeze.Width = 0.5!
        '
        'txtATVValveTamper
        '
        Me.txtATVValveTamper.DataField = "ATVValveTamper"
        Me.txtATVValveTamper.Height = 0.3!
        Me.txtATVValveTamper.Left = 9.3!
        Me.txtATVValveTamper.Name = "txtATVValveTamper"
        Me.txtATVValveTamper.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtATVValveTamper.Text = "ATVValveTamper"
        Me.txtATVValveTamper.Top = 0.05!
        Me.txtATVValveTamper.Width = 0.4!
        '
        'txtATVWaterFlow
        '
        Me.txtATVWaterFlow.DataField = "ATVWaterFlow"
        Me.txtATVWaterFlow.Height = 0.3!
        Me.txtATVWaterFlow.Left = 9.7!
        Me.txtATVWaterFlow.Name = "txtATVWaterFlow"
        Me.txtATVWaterFlow.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtATVWaterFlow.Text = "ATVWaterFlow"
        Me.txtATVWaterFlow.Top = 0.05!
        Me.txtATVWaterFlow.Width = 0.35!
        '
        'txtATVDrySysLowAir
        '
        Me.txtATVDrySysLowAir.DataField = "ATVDrySysLowAir"
        Me.txtATVDrySysLowAir.Height = 0.3!
        Me.txtATVDrySysLowAir.Left = 10.05!
        Me.txtATVDrySysLowAir.Name = "txtATVDrySysLowAir"
        Me.txtATVDrySysLowAir.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtATVDrySysLowAir.Text = "ATVDrySysLowAir"
        Me.txtATVDrySysLowAir.Top = 0.05!
        Me.txtATVDrySysLowAir.Width = 0.35!
        '
        'txtImpProcObserved
        '
        Me.txtImpProcObserved.DataField = "ImpProcObserved"
        Me.txtImpProcObserved.Height = 0.3!
        Me.txtImpProcObserved.Left = 10.45!
        Me.txtImpProcObserved.Name = "txtImpProcObserved"
        Me.txtImpProcObserved.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtImpProcObserved.Text = "ImpProcObserved"
        Me.txtImpProcObserved.Top = 0.05!
        Me.txtImpProcObserved.Width = 0.45!
        '
        'txtFireSupSysOver
        '
        Me.txtFireSupSysOver.DataField = "FireSupSysOver"
        Me.txtFireSupSysOver.Height = 0.3!
        Me.txtFireSupSysOver.Left = 11.25!
        Me.txtFireSupSysOver.Name = "txtFireSupSysOver"
        Me.txtFireSupSysOver.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtFireSupSysOver.Text = "FireSupSysOver"
        Me.txtFireSupSysOver.Top = 0.05!
        Me.txtFireSupSysOver.Width = 0.45!
        '
        'txtBlowOffCaps
        '
        Me.txtBlowOffCaps.DataField = "BlowOffCaps"
        Me.txtBlowOffCaps.Height = 0.3!
        Me.txtBlowOffCaps.Left = 11.7!
        Me.txtBlowOffCaps.Name = "txtBlowOffCaps"
        Me.txtBlowOffCaps.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtBlowOffCaps.Text = "BlowOffCaps"
        Me.txtBlowOffCaps.Top = 0.05!
        Me.txtBlowOffCaps.Width = 0.35!
        '
        'txtManualRelease
        '
        Me.txtManualRelease.DataField = "ManualRelease"
        Me.txtManualRelease.Height = 0.3!
        Me.txtManualRelease.Left = 12.05!
        Me.txtManualRelease.Name = "txtManualRelease"
        Me.txtManualRelease.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtManualRelease.Text = "ManualRelease"
        Me.txtManualRelease.Top = 0.05!
        Me.txtManualRelease.Width = 0.55!
        '
        'txtMin18Clearance
        '
        Me.txtMin18Clearance.DataField = "Min18Clearance"
        Me.txtMin18Clearance.Height = 0.3!
        Me.txtMin18Clearance.Left = 12.6!
        Me.txtMin18Clearance.Name = "txtMin18Clearance"
        Me.txtMin18Clearance.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtMin18Clearance.Text = "Min18Clearance"
        Me.txtMin18Clearance.Top = 0.05!
        Me.txtMin18Clearance.Width = 0.5!
        '
        'txtFireAlarmZonePosted
        '
        Me.txtFireAlarmZonePosted.DataField = "FireAlarmZonePosted"
        Me.txtFireAlarmZonePosted.Height = 0.3!
        Me.txtFireAlarmZonePosted.Left = 13.1!
        Me.txtFireAlarmZonePosted.Name = "txtFireAlarmZonePosted"
        Me.txtFireAlarmZonePosted.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtFireAlarmZonePosted.Text = "FireAlarmZonePosted"
        Me.txtFireAlarmZonePosted.Top = 0.05!
        Me.txtFireAlarmZonePosted.Width = 0.400001!
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
        'txtNoMissingCapsFDC
        '
        Me.txtNoMissingCapsFDC.DataField = "NoMissingCapsFDC"
        Me.txtNoMissingCapsFDC.Height = 0.3!
        Me.txtNoMissingCapsFDC.Left = 10.9!
        Me.txtNoMissingCapsFDC.Name = "txtNoMissingCapsFDC"
        Me.txtNoMissingCapsFDC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtNoMissingCapsFDC.Text = "NoMissingCapsFDC"
        Me.txtNoMissingCapsFDC.Top = 0.05!
        Me.txtNoMissingCapsFDC.Width = 0.35!
        '
        'line41
        '
        Me.line41.Height = 0.3!
        Me.line41.Left = 13.5!
        Me.line41.LineWeight = 1.0!
        Me.line41.Name = "line41"
        Me.line41.Top = 0.05!
        Me.line41.Width = 0.0!
        Me.line41.X1 = 13.5!
        Me.line41.X2 = 13.5!
        Me.line41.Y1 = 0.05!
        Me.line41.Y2 = 0.35!
        '
        'line42
        '
        Me.line42.Height = 0.3!
        Me.line42.Left = 13.1!
        Me.line42.LineWeight = 1.0!
        Me.line42.Name = "line42"
        Me.line42.Top = 0.05!
        Me.line42.Width = 0.0!
        Me.line42.X1 = 13.1!
        Me.line42.X2 = 13.1!
        Me.line42.Y1 = 0.05!
        Me.line42.Y2 = 0.35!
        '
        'line43
        '
        Me.line43.Height = 0.3!
        Me.line43.Left = 12.6!
        Me.line43.LineWeight = 1.0!
        Me.line43.Name = "line43"
        Me.line43.Top = 0.05!
        Me.line43.Width = 0.0!
        Me.line43.X1 = 12.6!
        Me.line43.X2 = 12.6!
        Me.line43.Y1 = 0.05!
        Me.line43.Y2 = 0.35!
        '
        'line44
        '
        Me.line44.Height = 0.3!
        Me.line44.Left = 12.05!
        Me.line44.LineWeight = 1.0!
        Me.line44.Name = "line44"
        Me.line44.Top = 0.05!
        Me.line44.Width = 0.0!
        Me.line44.X1 = 12.05!
        Me.line44.X2 = 12.05!
        Me.line44.Y1 = 0.05!
        Me.line44.Y2 = 0.35!
        '
        'line45
        '
        Me.line45.Height = 0.3!
        Me.line45.Left = 11.7!
        Me.line45.LineWeight = 1.0!
        Me.line45.Name = "line45"
        Me.line45.Top = 0.05!
        Me.line45.Width = 0.0!
        Me.line45.X1 = 11.7!
        Me.line45.X2 = 11.7!
        Me.line45.Y1 = 0.05!
        Me.line45.Y2 = 0.35!
        '
        'line46
        '
        Me.line46.Height = 0.3!
        Me.line46.Left = 11.25!
        Me.line46.LineWeight = 1.0!
        Me.line46.Name = "line46"
        Me.line46.Top = 0.05!
        Me.line46.Width = 0.0!
        Me.line46.X1 = 11.25!
        Me.line46.X2 = 11.25!
        Me.line46.Y1 = 0.05!
        Me.line46.Y2 = 0.35!
        '
        'line47
        '
        Me.line47.Height = 0.3!
        Me.line47.Left = 10.9!
        Me.line47.LineWeight = 1.0!
        Me.line47.Name = "line47"
        Me.line47.Top = 0.05!
        Me.line47.Width = 0.0!
        Me.line47.X1 = 10.9!
        Me.line47.X2 = 10.9!
        Me.line47.Y1 = 0.05!
        Me.line47.Y2 = 0.35!
        '
        'line48
        '
        Me.line48.Height = 0.3!
        Me.line48.Left = 10.45!
        Me.line48.LineWeight = 1.0!
        Me.line48.Name = "line48"
        Me.line48.Top = 0.05!
        Me.line48.Width = 0.0!
        Me.line48.X1 = 10.45!
        Me.line48.X2 = 10.45!
        Me.line48.Y1 = 0.05!
        Me.line48.Y2 = 0.35!
        '
        'line49
        '
        Me.line49.Height = 0.3!
        Me.line49.Left = 10.4!
        Me.line49.LineWeight = 1.0!
        Me.line49.Name = "line49"
        Me.line49.Top = 0.05!
        Me.line49.Width = 0.0!
        Me.line49.X1 = 10.4!
        Me.line49.X2 = 10.4!
        Me.line49.Y1 = 0.05!
        Me.line49.Y2 = 0.35!
        '
        'line50
        '
        Me.line50.Height = 0.3!
        Me.line50.Left = 8.45!
        Me.line50.LineWeight = 1.0!
        Me.line50.Name = "line50"
        Me.line50.Top = 0.05!
        Me.line50.Width = 0.0!
        Me.line50.X1 = 8.45!
        Me.line50.X2 = 8.45!
        Me.line50.Y1 = 0.05!
        Me.line50.Y2 = 0.35!
        '
        'line51
        '
        Me.line51.Height = 0.3!
        Me.line51.Left = 9.3!
        Me.line51.LineWeight = 1.0!
        Me.line51.Name = "line51"
        Me.line51.Top = 0.05!
        Me.line51.Width = 0.0!
        Me.line51.X1 = 9.3!
        Me.line51.X2 = 9.3!
        Me.line51.Y1 = 0.05!
        Me.line51.Y2 = 0.35!
        '
        'line52
        '
        Me.line52.Height = 0.3!
        Me.line52.Left = 9.7!
        Me.line52.LineWeight = 1.0!
        Me.line52.Name = "line52"
        Me.line52.Top = 0.05!
        Me.line52.Width = 0.0!
        Me.line52.X1 = 9.7!
        Me.line52.X2 = 9.7!
        Me.line52.Y1 = 0.05!
        Me.line52.Y2 = 0.35!
        '
        'line53
        '
        Me.line53.Height = 0.3!
        Me.line53.Left = 10.05!
        Me.line53.LineWeight = 1.0!
        Me.line53.Name = "line53"
        Me.line53.Top = 0.05!
        Me.line53.Width = 0.0!
        Me.line53.X1 = 10.05!
        Me.line53.X2 = 10.05!
        Me.line53.Y1 = 0.05!
        Me.line53.Y2 = 0.35!
        '
        'line54
        '
        Me.line54.Height = 0.3!
        Me.line54.Left = 8.8!
        Me.line54.LineWeight = 1.0!
        Me.line54.Name = "line54"
        Me.line54.Top = 0.05!
        Me.line54.Width = 0.0!
        Me.line54.X1 = 8.8!
        Me.line54.X2 = 8.8!
        Me.line54.Y1 = 0.05!
        Me.line54.Y2 = 0.35!
        '
        'line55
        '
        Me.line55.Height = 0.3!
        Me.line55.Left = 7.75!
        Me.line55.LineWeight = 1.0!
        Me.line55.Name = "line55"
        Me.line55.Top = 0.05!
        Me.line55.Width = 0.0!
        Me.line55.X1 = 7.75!
        Me.line55.X2 = 7.75!
        Me.line55.Y1 = 0.05!
        Me.line55.Y2 = 0.35!
        '
        'line56
        '
        Me.line56.Height = 0.3!
        Me.line56.Left = 8.1!
        Me.line56.LineWeight = 1.0!
        Me.line56.Name = "line56"
        Me.line56.Top = 0.05!
        Me.line56.Width = 0.0!
        Me.line56.X1 = 8.1!
        Me.line56.X2 = 8.1!
        Me.line56.Y1 = 0.05!
        Me.line56.Y2 = 0.35!
        '
        'line57
        '
        Me.line57.Height = 0.3!
        Me.line57.Left = 7.7!
        Me.line57.LineWeight = 1.0!
        Me.line57.Name = "line57"
        Me.line57.Top = 0.05!
        Me.line57.Width = 0.0!
        Me.line57.X1 = 7.7!
        Me.line57.X2 = 7.7!
        Me.line57.Y1 = 0.05!
        Me.line57.Y2 = 0.35!
        '
        'line58
        '
        Me.line58.Height = 0.3!
        Me.line58.Left = 6.25!
        Me.line58.LineWeight = 1.0!
        Me.line58.Name = "line58"
        Me.line58.Top = 0.05!
        Me.line58.Width = 0.0!
        Me.line58.X1 = 6.25!
        Me.line58.X2 = 6.25!
        Me.line58.Y1 = 0.05!
        Me.line58.Y2 = 0.35!
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
        'line68
        '
        Me.line68.Height = 0.0!
        Me.line68.Left = 6.25!
        Me.line68.LineWeight = 1.0!
        Me.line68.Name = "line68"
        Me.line68.Top = 0.05!
        Me.line68.Width = 1.45!
        Me.line68.X1 = 6.25!
        Me.line68.X2 = 7.7!
        Me.line68.Y1 = 0.05!
        Me.line68.Y2 = 0.05!
        '
        'line70
        '
        Me.line70.Height = 0.0!
        Me.line70.Left = 6.25!
        Me.line70.LineWeight = 1.0!
        Me.line70.Name = "line70"
        Me.line70.Top = 0.35!
        Me.line70.Width = 1.45!
        Me.line70.X1 = 6.25!
        Me.line70.X2 = 7.7!
        Me.line70.Y1 = 0.35!
        Me.line70.Y2 = 0.35!
        '
        'line71
        '
        Me.line71.Height = 0.0!
        Me.line71.Left = 7.75!
        Me.line71.LineWeight = 1.0!
        Me.line71.Name = "line71"
        Me.line71.Top = 0.05!
        Me.line71.Width = 2.65!
        Me.line71.X1 = 7.75!
        Me.line71.X2 = 10.4!
        Me.line71.Y1 = 0.05!
        Me.line71.Y2 = 0.05!
        '
        'line72
        '
        Me.line72.Height = 0.0!
        Me.line72.Left = 7.75!
        Me.line72.LineWeight = 1.0!
        Me.line72.Name = "line72"
        Me.line72.Top = 0.35!
        Me.line72.Width = 2.65!
        Me.line72.X1 = 7.75!
        Me.line72.X2 = 10.4!
        Me.line72.Y1 = 0.35!
        Me.line72.Y2 = 0.35!
        '
        'line75
        '
        Me.line75.Height = 0.0!
        Me.line75.Left = 10.45!
        Me.line75.LineWeight = 1.0!
        Me.line75.Name = "line75"
        Me.line75.Top = 0.05!
        Me.line75.Width = 3.05!
        Me.line75.X1 = 10.45!
        Me.line75.X2 = 13.5!
        Me.line75.Y1 = 0.05!
        Me.line75.Y2 = 0.05!
        '
        'line76
        '
        Me.line76.Height = 0.0!
        Me.line76.Left = 10.45!
        Me.line76.LineWeight = 1.0!
        Me.line76.Name = "line76"
        Me.line76.Top = 0.35!
        Me.line76.Width = 3.05!
        Me.line76.X1 = 10.45!
        Me.line76.X2 = 13.5!
        Me.line76.Y1 = 0.35!
        Me.line76.Y2 = 0.35!
        '
        'txtNoOfValves
        '
        Me.txtNoOfValves.DataField = "NoOfValves"
        Me.txtNoOfValves.Height = 0.3!
        Me.txtNoOfValves.Left = 4.42!
        Me.txtNoOfValves.Name = "txtNoOfValves"
        Me.txtNoOfValves.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtNoOfValves.Text = "NoOfValves"
        Me.txtNoOfValves.Top = 0.05!
        Me.txtNoOfValves.Width = 0.32!
        '
        'txtAllValvesOpen
        '
        Me.txtAllValvesOpen.DataField = "AllValvesOpen"
        Me.txtAllValvesOpen.Height = 0.3!
        Me.txtAllValvesOpen.Left = 4.74!
        Me.txtAllValvesOpen.Name = "txtAllValvesOpen"
        Me.txtAllValvesOpen.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtAllValvesOpen.Text = "AllValvesOpen"
        Me.txtAllValvesOpen.Top = 0.05!
        Me.txtAllValvesOpen.Width = 0.31!
        '
        'txtValvesLocked
        '
        Me.txtValvesLocked.DataField = "ValvesLocked"
        Me.txtValvesLocked.Height = 0.3!
        Me.txtValvesLocked.Left = 5.05!
        Me.txtValvesLocked.Name = "txtValvesLocked"
        Me.txtValvesLocked.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtValvesLocked.Text = "ValvesLocked"
        Me.txtValvesLocked.Top = 0.05!
        Me.txtValvesLocked.Width = 0.35!
        '
        'txtValvesLabeled
        '
        Me.txtValvesLabeled.DataField = "ValvesLabeled"
        Me.txtValvesLabeled.Height = 0.3!
        Me.txtValvesLabeled.Left = 5.4!
        Me.txtValvesLabeled.Name = "txtValvesLabeled"
        Me.txtValvesLabeled.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtValvesLabeled.Text = "ValvesLabeled"
        Me.txtValvesLabeled.Top = 0.05!
        Me.txtValvesLabeled.Width = 0.4!
        '
        'txtValvesInspMonthly
        '
        Me.txtValvesInspMonthly.DataField = "ValvesInspMonthly"
        Me.txtValvesInspMonthly.Height = 0.3!
        Me.txtValvesInspMonthly.Left = 5.8!
        Me.txtValvesInspMonthly.Name = "txtValvesInspMonthly"
        Me.txtValvesInspMonthly.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtValvesInspMonthly.Text = "ValvesInspMonthly"
        Me.txtValvesInspMonthly.Top = 0.05!
        Me.txtValvesInspMonthly.Width = 0.4!
        '
        'txtSSHeadBoxMonthly
        '
        Me.txtSSHeadBoxMonthly.DataField = "SSHeadBoxMonthly"
        Me.txtSSHeadBoxMonthly.Height = 0.3!
        Me.txtSSHeadBoxMonthly.Left = 6.25!
        Me.txtSSHeadBoxMonthly.Name = "txtSSHeadBoxMonthly"
        Me.txtSSHeadBoxMonthly.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtSSHeadBoxMonthly.Text = "SSHeadBoxMonthly"
        Me.txtSSHeadBoxMonthly.Top = 0.05!
        Me.txtSSHeadBoxMonthly.Width = 0.35!
        '
        'txtSSHeadsAvail
        '
        Me.txtSSHeadsAvail.DataField = "SSHeadsAvail"
        Me.txtSSHeadsAvail.Height = 0.3!
        Me.txtSSHeadsAvail.Left = 6.6!
        Me.txtSSHeadsAvail.Name = "txtSSHeadsAvail"
        Me.txtSSHeadsAvail.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtSSHeadsAvail.Text = "SSHeadsAvail"
        Me.txtSSHeadsAvail.Top = 0.05!
        Me.txtSSHeadsAvail.Width = 0.35!
        '
        'txtSSHeadWrenchInBox
        '
        Me.txtSSHeadWrenchInBox.DataField = "SSHeadWrenchInBox"
        Me.txtSSHeadWrenchInBox.Height = 0.3!
        Me.txtSSHeadWrenchInBox.Left = 6.95!
        Me.txtSSHeadWrenchInBox.Name = "txtSSHeadWrenchInBox"
        Me.txtSSHeadWrenchInBox.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtSSHeadWrenchInBox.Text = "SSHeadWrenchInBox"
        Me.txtSSHeadWrenchInBox.Top = 0.05!
        Me.txtSSHeadWrenchInBox.Width = 0.4!
        '
        'txtCorrectHeadsProvided
        '
        Me.txtCorrectHeadsProvided.DataField = "CorrectHeadsProvided"
        Me.txtCorrectHeadsProvided.Height = 0.3!
        Me.txtCorrectHeadsProvided.Left = 7.35!
        Me.txtCorrectHeadsProvided.Name = "txtCorrectHeadsProvided"
        Me.txtCorrectHeadsProvided.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtCorrectHeadsProvided.Text = "CorrectHeadsProvided"
        Me.txtCorrectHeadsProvided.Top = 0.05!
        Me.txtCorrectHeadsProvided.Width = 0.35!
        '
        'line73
        '
        Me.line73.Height = 0.3!
        Me.line73.Left = 7.7!
        Me.line73.LineWeight = 1.0!
        Me.line73.Name = "line73"
        Me.line73.Top = 0.05!
        Me.line73.Width = 0.0!
        Me.line73.X1 = 7.7!
        Me.line73.X2 = 7.7!
        Me.line73.Y1 = 0.05!
        Me.line73.Y2 = 0.35!
        '
        'line74
        '
        Me.line74.Height = 0.3!
        Me.line74.Left = 6.95!
        Me.line74.LineWeight = 1.0!
        Me.line74.Name = "line74"
        Me.line74.Top = 0.05!
        Me.line74.Width = 0.0!
        Me.line74.X1 = 6.95!
        Me.line74.X2 = 6.95!
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
        'line79
        '
        Me.line79.Height = 0.3!
        Me.line79.Left = 6.25!
        Me.line79.LineWeight = 1.0!
        Me.line79.Name = "line79"
        Me.line79.Top = 0.05!
        Me.line79.Width = 0.0!
        Me.line79.X1 = 6.25!
        Me.line79.X2 = 6.25!
        Me.line79.Y1 = 0.05!
        Me.line79.Y2 = 0.35!
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
        Me.line81.Left = 5.8!
        Me.line81.LineWeight = 1.0!
        Me.line81.Name = "line81"
        Me.line81.Top = 0.05!
        Me.line81.Width = 0.0!
        Me.line81.X1 = 5.8!
        Me.line81.X2 = 5.8!
        Me.line81.Y1 = 0.05!
        Me.line81.Y2 = 0.35!
        '
        'line82
        '
        Me.line82.Height = 0.3!
        Me.line82.Left = 5.4!
        Me.line82.LineWeight = 1.0!
        Me.line82.Name = "line82"
        Me.line82.Top = 0.05!
        Me.line82.Width = 0.0!
        Me.line82.X1 = 5.4!
        Me.line82.X2 = 5.4!
        Me.line82.Y1 = 0.05!
        Me.line82.Y2 = 0.35!
        '
        'line83
        '
        Me.line83.Height = 0.3!
        Me.line83.Left = 5.05!
        Me.line83.LineWeight = 1.0!
        Me.line83.Name = "line83"
        Me.line83.Top = 0.05!
        Me.line83.Width = 0.0!
        Me.line83.X1 = 5.05!
        Me.line83.X2 = 5.05!
        Me.line83.Y1 = 0.05!
        Me.line83.Y2 = 0.35!
        '
        'line84
        '
        Me.line84.Height = 0.3!
        Me.line84.Left = 4.74!
        Me.line84.LineWeight = 1.0!
        Me.line84.Name = "line84"
        Me.line84.Top = 0.05!
        Me.line84.Width = 0.0!
        Me.line84.X1 = 4.74!
        Me.line84.X2 = 4.74!
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
        Me.line86.Left = 7.35!
        Me.line86.LineWeight = 1.0!
        Me.line86.Name = "line86"
        Me.line86.Top = 0.05!
        Me.line86.Width = 0.0!
        Me.line86.X1 = 7.35!
        Me.line86.X2 = 7.35!
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
        Me.line87.Width = 1.78!
        Me.line87.X1 = 4.42!
        Me.line87.X2 = 6.2!
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
        Me.line88.Width = 1.78!
        Me.line88.X1 = 4.42!
        Me.line88.X2 = 6.2!
        Me.line88.Y1 = 0.35!
        Me.line88.Y2 = 0.35!
        '
        'line89
        '
        Me.line89.Height = 0.0!
        Me.line89.Left = 6.25!
        Me.line89.LineWeight = 1.0!
        Me.line89.Name = "line89"
        Me.line89.Top = 0.05!
        Me.line89.Width = 1.45!
        Me.line89.X1 = 6.25!
        Me.line89.X2 = 7.7!
        Me.line89.Y1 = 0.05!
        Me.line89.Y2 = 0.05!
        '
        'line90
        '
        Me.line90.Height = 0.0!
        Me.line90.Left = 6.25!
        Me.line90.LineWeight = 1.0!
        Me.line90.Name = "line90"
        Me.line90.Top = 0.35!
        Me.line90.Width = 1.45!
        Me.line90.X1 = 6.25!
        Me.line90.X2 = 7.7!
        Me.line90.Y1 = 0.35!
        Me.line90.Y2 = 0.35!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtSort, Me.lblReportDate, Me.reportInfo1, Me.txtDisclaimer})
        Me.PageFooter1.Height = 0.475!
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
        Me.txtSort.Width = 13.5!
        '
        'lblReportDate
        '
        Me.lblReportDate.Height = 0.15!
        Me.lblReportDate.HyperLink = Nothing
        Me.lblReportDate.Left = 0.0!
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
        Me.reportInfo1.Left = 11.5!
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
        Me.txtDisclaimer.Width = 13.5!
        '
        'rptFireSprinklerSystemSummary
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.25!
        Me.PageSettings.Margins.Left = 0.25!
        Me.PageSettings.Margins.Right = 0.25!
        Me.PageSettings.Margins.Top = 0.25!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 14.0!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Legal
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 13.525!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Calibri; font-style: normal; text-decoration: none; font-weight: nor" & _
            "mal; font-size: 10pt; color: Black", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
            "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.lblSSHeadBoxMonthly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblValvesLabeled, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblValvesLocked, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAllValvesOpen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNoOfValves, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblValvesInspMonthly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSSHeadWrenchInBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCorrectHeadsProvided, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblATV2inDrain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblATVDryPipeValve, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblATVFirePump, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblATVAntifreeze, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblATVValveTamper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblATVWaterFlow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblATVDrySysLowAir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblImpProcObserved, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNoMissingCapsFDC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFireSupSysOver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBlowOffCaps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblManualRelease, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFireAlarmZonePosted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMin18Clearance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSprinklerHeads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAnnualTestVerification, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblClientName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFireSprinklerSystemSummary, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.lblValves, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblOther, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblClientLocNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFacility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSSHeadsAvail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCorrectHeadsProvidedC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSSHeadWrenchInBoxC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSSHeadsAvailC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSSHeadBoxMonthlyC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValvesInspMonthlyC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValvesLabeledC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValvesLockedC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAllValvesOpenC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoOfValvesC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoMissingCapsFDCC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFireAlarmZonePostedC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMin18ClearanceC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtManualReleaseC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBlowOffCapsC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFireSupSysOverC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImpProcObservedC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtATVDrySysLowAirC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtATVWaterFlowC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtATVValveTamperC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtATVAntifreezeC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtATVFirePumpC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtATV2inDrainC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtATVDryPipeValveC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtATVDryPipeValve, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDivision2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFileNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSurveyDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSTProv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTIV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtATV2inDrain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtATVFirePump, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtATVAntifreeze, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtATVValveTamper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtATVWaterFlow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtATVDrySysLowAir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImpProcObserved, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFireSupSysOver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBlowOffCaps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtManualRelease, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMin18Clearance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFireAlarmZonePosted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFacility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientLocNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoMissingCapsFDC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoOfValves, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAllValvesOpen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValvesLocked, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValvesLabeled, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValvesInspMonthly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSSHeadBoxMonthly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSSHeadsAvail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSSHeadWrenchInBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCorrectHeadsProvided, System.ComponentModel.ISupportInitialize).EndInit()
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

    Private Sub rptFireSprinklerSystemSummary_FetchData(ByVal sender As Object, ByVal eArgs As FetchEventArgs) Handles Me.FetchData
        Dim zControls() As ARControl = {txtAllValvesOpen,
                                        txtValvesLocked,
                                        txtValvesLabeled,
                                        txtValvesInspMonthly,
                                        txtSSHeadBoxMonthly,
                                        txtSSHeadsAvail,
                                        txtSSHeadWrenchInBox,
                                        txtCorrectHeadsProvided,
                                        txtATV2inDrain,
                                        txtATVDryPipeValve,
                                        txtATVFirePump,
                                        txtATVAntifreeze,
                                        txtATVValveTamper,
                                        txtATVWaterFlow,
                                        txtATVDrySysLowAir,
                                        txtImpProcObserved,
                                        txtNoMissingCapsFDC,
                                        txtFireSupSysOver,
                                        txtBlowOffCaps,
                                        txtManualRelease,
                                        txtMin18Clearance,
                                        txtFireAlarmZonePosted}

        Dim zCommentControls() As ARControl = {txtAllValvesOpenC,
                                                txtValvesLockedC,
                                                txtValvesLabeledC,
                                                txtValvesInspMonthlyC,
                                                txtSSHeadBoxMonthlyC,
                                                txtSSHeadsAvailC,
                                                txtSSHeadWrenchInBoxC,
                                                txtCorrectHeadsProvidedC,
                                                txtATV2inDrainC,
                                                txtATVDryPipeValveC,
                                                txtATVFirePumpC,
                                                txtATVAntifreezeC,
                                                txtATVValveTamperC,
                                                txtATVWaterFlowC,
                                                txtATVDrySysLowAirC,
                                                txtImpProcObservedC,
                                                txtNoMissingCapsFDCC,
                                                txtFireSupSysOverC,
                                                txtBlowOffCapsC,
                                                txtManualReleaseC,
                                                txtMin18ClearanceC,
                                                txtFireAlarmZonePostedC}

        UtilReport.ActiveReport.SetItemBackColorByTextAndComment(Me, zControls, zCommentControls, rptProperties)
    End Sub

    Private Sub rptFireSprinklerSystemSummary_ReportStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportStart
        lblClientName.Text = rptProperties.ClientName
        lblReportDate.Text = Now
        lblTIVGrid.Text = "TIV " & rptProperties.Currency.colFldCode & vbLf & "(millions)"
    End Sub

    Private Sub rptFireSprinklerSystemSummary_PageStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.PageStart
        UtilReport.ActiveReport.SetFilter(Me, rptProperties)
        UtilReport.ActiveReport.SetSort(Me, rptProperties)
        UtilReport.ActiveReport.SetDisclaimer(Me, rptProperties)
    End Sub

    Private Sub rptFireSprinklerSystemSummary_ReportEnd(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportEnd
        DisposeParameters()
    End Sub

    Private Sub DisposeParameters()
        DataSource = Nothing
    End Sub

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties

End Class
