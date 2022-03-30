Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports

Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing

Public Class rptFireMiscellaneousSummary
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
    Private WithEvents lblFireMiscellaneousSummary As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblLocationInformation As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFileNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblDivision2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblInspectionDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCity As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblAddress As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblSTProv As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCountry As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblTIVGrid As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblMiscellaneous As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblELProvided As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblBatOpEmerExit As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblEmergGenOptMonthly As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblGenSecPreUnauth As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblExitSignsProvIll As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblExitDoorsUnobstr As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblNatGasFryer As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblSeismicGasShutoff As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblStorRacksBolted As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtFileNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSurveyDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCity As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSTProv As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCountry As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtTIV As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtDivision2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtAddress As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtELProvided As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtBatOpEmerExit As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtEmergGenOptMonthly As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtGenSecPreUnauth As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtExitSignsProvIll As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtExitDoorsUnobstr As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtNatGasFryer As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSeismicGasShutoff As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtStorRacksBolted As GrapeCity.ActiveReports.SectionReportModel.TextBox
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
    Private WithEvents line11 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line12 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line16 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line17 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line18 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line35 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line36 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line37 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line38 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line39 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line40 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtClientLocNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFacility As GrapeCity.ActiveReports.SectionReportModel.TextBox
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
    Private WithEvents line60 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line61 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line62 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line63 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line64 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line65 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line67 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents reportInfo1 As GrapeCity.ActiveReports.SectionReportModel.ReportInfo
    Private WithEvents txtDisclaimer As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtELProvidedC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtBatOpEmerExitC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtEmergGenOptMonthlyC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtGenSecPreUnauthC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtExitSignsProvIllC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtExitDoorsUnobstrC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtNatGasFryerC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtStorRacksBoltedC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSeismicGasShutoffC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents PageFooter1 As GrapeCity.ActiveReports.SectionReportModel.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptFireMiscellaneousSummary))
        Me.PageHeader1 = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.lblClientName = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFireMiscellaneousSummary = New GrapeCity.ActiveReports.SectionReportModel.Label()
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
        Me.lblMiscellaneous = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblELProvided = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblBatOpEmerExit = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblEmergGenOptMonthly = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblGenSecPreUnauth = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblExitDoorsUnobstr = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblNatGasFryer = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSeismicGasShutoff = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblStorRacksBolted = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFilters = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtFilters = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblClientLocNo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFacility = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblExitSignsProvIll = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line5 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line9 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line11 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line12 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line16 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line17 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line18 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line35 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line36 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line37 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line38 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line39 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line40 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Detail1 = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.txtSeismicGasShutoffC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtStorRacksBoltedC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtNatGasFryerC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtExitDoorsUnobstrC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtExitSignsProvIllC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtGenSecPreUnauthC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtEmergGenOptMonthlyC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtBatOpEmerExitC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtELProvidedC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtELProvided = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtAddress = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtDivision2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFileNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSurveyDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCity = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSTProv = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCountry = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtTIV = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtBatOpEmerExit = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtEmergGenOptMonthly = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtGenSecPreUnauth = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtExitSignsProvIll = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtExitDoorsUnobstr = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtNatGasFryer = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtStorRacksBolted = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFacility = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtClientLocNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSeismicGasShutoff = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.line48 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line49 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line50 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line51 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line52 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line53 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line54 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line55 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line56 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line60 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line61 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line62 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line63 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line64 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line65 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line67 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.PageFooter1 = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.txtSort = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblReportDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.reportInfo1 = New GrapeCity.ActiveReports.SectionReportModel.ReportInfo()
        Me.txtDisclaimer = New GrapeCity.ActiveReports.SectionReportModel.Label()
        CType(Me.lblClientName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFireMiscellaneousSummary, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.lblMiscellaneous, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblELProvided, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBatOpEmerExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblEmergGenOptMonthly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblGenSecPreUnauth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblExitDoorsUnobstr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNatGasFryer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSeismicGasShutoff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblStorRacksBolted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblClientLocNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFacility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblExitSignsProvIll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSeismicGasShutoffC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStorRacksBoltedC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNatGasFryerC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExitDoorsUnobstrC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExitSignsProvIllC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGenSecPreUnauthC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmergGenOptMonthlyC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBatOpEmerExitC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtELProvidedC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtELProvided, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDivision2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFileNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSurveyDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSTProv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTIV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBatOpEmerExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmergGenOptMonthly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGenSecPreUnauth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExitSignsProvIll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExitDoorsUnobstr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNatGasFryer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStorRacksBolted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFacility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientLocNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSeismicGasShutoff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblReportDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisclaimer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.CanShrink = True
        Me.PageHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblClientName, Me.lblFireMiscellaneousSummary, Me.lblLocationInformation, Me.picGRCLogo, Me.lblFileNo, Me.lblDivision2, Me.lblInspectionDate, Me.lblCity, Me.lblAddress, Me.lblSTProv, Me.lblCountry, Me.lblTIVGrid, Me.lblMiscellaneous, Me.lblELProvided, Me.lblBatOpEmerExit, Me.lblEmergGenOptMonthly, Me.lblGenSecPreUnauth, Me.lblExitDoorsUnobstr, Me.lblNatGasFryer, Me.lblSeismicGasShutoff, Me.lblStorRacksBolted, Me.lblFilters, Me.txtFilters, Me.lblClientLocNo, Me.lblFacility, Me.lblExitSignsProvIll, Me.line1, Me.line2, Me.line3, Me.line4, Me.line5, Me.line9, Me.line11, Me.line12, Me.line16, Me.line17, Me.line18, Me.line35, Me.line36, Me.line37, Me.line38, Me.line39, Me.line40})
        Me.PageHeader1.Height = 1.65!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'lblClientName
        '
        Me.lblClientName.Height = 0.25!
        Me.lblClientName.HyperLink = Nothing
        Me.lblClientName.Left = 4.15!
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Style = "color: #C6D1DE; font-size: 16pt; font-style: italic; font-weight: bold; text-alig" & _
    "n: right; vertical-align: middle"
        Me.lblClientName.Text = "Company Name"
        Me.lblClientName.Top = 0.05!
        Me.lblClientName.Width = 5.05!
        '
        'lblFireMiscellaneousSummary
        '
        Me.lblFireMiscellaneousSummary.Height = 0.25!
        Me.lblFireMiscellaneousSummary.HyperLink = Nothing
        Me.lblFireMiscellaneousSummary.Left = 4.15!
        Me.lblFireMiscellaneousSummary.Name = "lblFireMiscellaneousSummary"
        Me.lblFireMiscellaneousSummary.Style = "font-size: 12pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblFireMiscellaneousSummary.Text = "Fire - Miscellaneous Summary"
        Me.lblFireMiscellaneousSummary.Top = 0.35!
        Me.lblFireMiscellaneousSummary.Width = 5.05!
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
        'lblMiscellaneous
        '
        Me.lblMiscellaneous.Height = 0.15!
        Me.lblMiscellaneous.HyperLink = Nothing
        Me.lblMiscellaneous.Left = 4.42!
        Me.lblMiscellaneous.Name = "lblMiscellaneous"
        Me.lblMiscellaneous.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblMiscellaneous.Text = "Miscellaneous"
        Me.lblMiscellaneous.Top = 1.05!
        Me.lblMiscellaneous.Width = 4.78!
        '
        'lblELProvided
        '
        Me.lblELProvided.Height = 0.45!
        Me.lblELProvided.HyperLink = Nothing
        Me.lblELProvided.Left = 4.42!
        Me.lblELProvided.Name = "lblELProvided"
        Me.lblELProvided.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblELProvided.Text = "Emerg. Lighting Provided"
        Me.lblELProvided.Top = 1.2!
        Me.lblELProvided.Width = 0.5!
        '
        'lblBatOpEmerExit
        '
        Me.lblBatOpEmerExit.Height = 0.45!
        Me.lblBatOpEmerExit.HyperLink = Nothing
        Me.lblBatOpEmerExit.Left = 4.92!
        Me.lblBatOpEmerExit.Name = "lblBatOpEmerExit"
        Me.lblBatOpEmerExit.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblBatOpEmerExit.Text = "Emergency Exits Lights Tested"
        Me.lblBatOpEmerExit.Top = 1.2!
        Me.lblBatOpEmerExit.Width = 0.58!
        '
        'lblEmergGenOptMonthly
        '
        Me.lblEmergGenOptMonthly.Height = 0.45!
        Me.lblEmergGenOptMonthly.HyperLink = Nothing
        Me.lblEmergGenOptMonthly.Left = 5.5!
        Me.lblEmergGenOptMonthly.Name = "lblEmergGenOptMonthly"
        Me.lblEmergGenOptMonthly.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblEmergGenOptMonthly.Text = "Emergency Generator Tested"
        Me.lblEmergGenOptMonthly.Top = 1.2!
        Me.lblEmergGenOptMonthly.Width = 0.6!
        '
        'lblGenSecPreUnauth
        '
        Me.lblGenSecPreUnauth.Height = 0.45!
        Me.lblGenSecPreUnauth.HyperLink = Nothing
        Me.lblGenSecPreUnauth.Left = 6.1!
        Me.lblGenSecPreUnauth.Name = "lblGenSecPreUnauth"
        Me.lblGenSecPreUnauth.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblGenSecPreUnauth.Text = "Generator Secure"
        Me.lblGenSecPreUnauth.Top = 1.2!
        Me.lblGenSecPreUnauth.Width = 0.5!
        '
        'lblExitDoorsUnobstr
        '
        Me.lblExitDoorsUnobstr.Height = 0.45!
        Me.lblExitDoorsUnobstr.HyperLink = Nothing
        Me.lblExitDoorsUnobstr.Left = 7.11!
        Me.lblExitDoorsUnobstr.Name = "lblExitDoorsUnobstr"
        Me.lblExitDoorsUnobstr.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblExitDoorsUnobstr.Text = "Exit Doors"
        Me.lblExitDoorsUnobstr.Top = 1.2!
        Me.lblExitDoorsUnobstr.Width = 0.51!
        '
        'lblNatGasFryer
        '
        Me.lblNatGasFryer.Height = 0.45!
        Me.lblNatGasFryer.HyperLink = Nothing
        Me.lblNatGasFryer.Left = 7.62!
        Me.lblNatGasFryer.Name = "lblNatGasFryer"
        Me.lblNatGasFryer.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblNatGasFryer.Text = "Natural Gas Fryers Secure"
        Me.lblNatGasFryer.Top = 1.2!
        Me.lblNatGasFryer.Width = 0.53!
        '
        'lblSeismicGasShutoff
        '
        Me.lblSeismicGasShutoff.Height = 0.45!
        Me.lblSeismicGasShutoff.HyperLink = Nothing
        Me.lblSeismicGasShutoff.Left = 8.15!
        Me.lblSeismicGasShutoff.Name = "lblSeismicGasShutoff"
        Me.lblSeismicGasShutoff.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblSeismicGasShutoff.Text = "Seismic Gas Shutoff"
        Me.lblSeismicGasShutoff.Top = 1.2!
        Me.lblSeismicGasShutoff.Width = 0.45!
        '
        'lblStorRacksBolted
        '
        Me.lblStorRacksBolted.Height = 0.45!
        Me.lblStorRacksBolted.HyperLink = Nothing
        Me.lblStorRacksBolted.Left = 8.6!
        Me.lblStorRacksBolted.Name = "lblStorRacksBolted"
        Me.lblStorRacksBolted.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblStorRacksBolted.Text = "Storage Racks Bolted Down"
        Me.lblStorRacksBolted.Top = 1.2!
        Me.lblStorRacksBolted.Width = 0.6!
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
        Me.txtFilters.Width = 8.76!
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
        'lblExitSignsProvIll
        '
        Me.lblExitSignsProvIll.Height = 0.45!
        Me.lblExitSignsProvIll.HyperLink = Nothing
        Me.lblExitSignsProvIll.Left = 6.6!
        Me.lblExitSignsProvIll.Name = "lblExitSignsProvIll"
        Me.lblExitSignsProvIll.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblExitSignsProvIll.Text = "Exit Signs"
        Me.lblExitSignsProvIll.Top = 1.2!
        Me.lblExitSignsProvIll.Width = 0.51!
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
        Me.line9.Left = 4.92!
        Me.line9.LineWeight = 1.0!
        Me.line9.Name = "line9"
        Me.line9.Top = 1.2!
        Me.line9.Width = 0.0!
        Me.line9.X1 = 4.92!
        Me.line9.X2 = 4.92!
        Me.line9.Y1 = 1.2!
        Me.line9.Y2 = 1.65!
        '
        'line11
        '
        Me.line11.Height = 0.4499999!
        Me.line11.Left = 8.15!
        Me.line11.LineWeight = 1.0!
        Me.line11.Name = "line11"
        Me.line11.Top = 1.2!
        Me.line11.Width = 0.0!
        Me.line11.X1 = 8.15!
        Me.line11.X2 = 8.15!
        Me.line11.Y1 = 1.2!
        Me.line11.Y2 = 1.65!
        '
        'line12
        '
        Me.line12.Height = 0.6!
        Me.line12.Left = 9.2!
        Me.line12.LineWeight = 1.0!
        Me.line12.Name = "line12"
        Me.line12.Top = 1.05!
        Me.line12.Width = 0.0!
        Me.line12.X1 = 9.2!
        Me.line12.X2 = 9.2!
        Me.line12.Y1 = 1.05!
        Me.line12.Y2 = 1.65!
        '
        'line16
        '
        Me.line16.Height = 0.0!
        Me.line16.Left = 4.42!
        Me.line16.LineWeight = 1.0!
        Me.line16.Name = "line16"
        Me.line16.Top = 1.65!
        Me.line16.Width = 4.78!
        Me.line16.X1 = 4.42!
        Me.line16.X2 = 9.2!
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
        Me.line17.Width = 4.78!
        Me.line17.X1 = 4.42!
        Me.line17.X2 = 9.2!
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
        Me.line18.Width = 4.78!
        Me.line18.X1 = 4.42!
        Me.line18.X2 = 9.2!
        Me.line18.Y1 = 1.05!
        Me.line18.Y2 = 1.05!
        '
        'line35
        '
        Me.line35.Height = 0.4499999!
        Me.line35.Left = 8.6!
        Me.line35.LineWeight = 1.0!
        Me.line35.Name = "line35"
        Me.line35.Top = 1.2!
        Me.line35.Width = 0.0!
        Me.line35.X1 = 8.6!
        Me.line35.X2 = 8.6!
        Me.line35.Y1 = 1.2!
        Me.line35.Y2 = 1.65!
        '
        'line36
        '
        Me.line36.Height = 0.4499999!
        Me.line36.Left = 7.62!
        Me.line36.LineWeight = 1.0!
        Me.line36.Name = "line36"
        Me.line36.Top = 1.2!
        Me.line36.Width = 0.0!
        Me.line36.X1 = 7.62!
        Me.line36.X2 = 7.62!
        Me.line36.Y1 = 1.2!
        Me.line36.Y2 = 1.65!
        '
        'line37
        '
        Me.line37.Height = 0.4499999!
        Me.line37.Left = 7.11!
        Me.line37.LineWeight = 1.0!
        Me.line37.Name = "line37"
        Me.line37.Top = 1.2!
        Me.line37.Width = 0.0!
        Me.line37.X1 = 7.11!
        Me.line37.X2 = 7.11!
        Me.line37.Y1 = 1.2!
        Me.line37.Y2 = 1.65!
        '
        'line38
        '
        Me.line38.Height = 0.4499999!
        Me.line38.Left = 6.6!
        Me.line38.LineWeight = 1.0!
        Me.line38.Name = "line38"
        Me.line38.Top = 1.2!
        Me.line38.Width = 0.0!
        Me.line38.X1 = 6.6!
        Me.line38.X2 = 6.6!
        Me.line38.Y1 = 1.2!
        Me.line38.Y2 = 1.65!
        '
        'line39
        '
        Me.line39.Height = 0.4499999!
        Me.line39.Left = 6.1!
        Me.line39.LineWeight = 1.0!
        Me.line39.Name = "line39"
        Me.line39.Top = 1.2!
        Me.line39.Width = 0.0!
        Me.line39.X1 = 6.1!
        Me.line39.X2 = 6.1!
        Me.line39.Y1 = 1.2!
        Me.line39.Y2 = 1.65!
        '
        'line40
        '
        Me.line40.Height = 0.4499999!
        Me.line40.Left = 5.5!
        Me.line40.LineWeight = 1.0!
        Me.line40.Name = "line40"
        Me.line40.Top = 1.2!
        Me.line40.Width = 0.0!
        Me.line40.X1 = 5.5!
        Me.line40.X2 = 5.5!
        Me.line40.Y1 = 1.2!
        Me.line40.Y2 = 1.65!
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtSeismicGasShutoffC, Me.txtStorRacksBoltedC, Me.txtNatGasFryerC, Me.txtExitDoorsUnobstrC, Me.txtExitSignsProvIllC, Me.txtGenSecPreUnauthC, Me.txtEmergGenOptMonthlyC, Me.txtBatOpEmerExitC, Me.txtELProvidedC, Me.txtELProvided, Me.txtAddress, Me.txtDivision2, Me.txtFileNo, Me.txtSurveyDate, Me.txtCity, Me.txtSTProv, Me.txtCountry, Me.txtTIV, Me.txtBatOpEmerExit, Me.txtEmergGenOptMonthly, Me.txtGenSecPreUnauth, Me.txtExitSignsProvIll, Me.txtExitDoorsUnobstr, Me.txtNatGasFryer, Me.txtStorRacksBolted, Me.txtFacility, Me.txtClientLocNo, Me.txtSeismicGasShutoff, Me.line48, Me.line49, Me.line50, Me.line51, Me.line52, Me.line53, Me.line54, Me.line55, Me.line56, Me.line60, Me.line61, Me.line62, Me.line63, Me.line64, Me.line65, Me.line67})
        Me.Detail1.Height = 0.35!
        Me.Detail1.KeepTogether = True
        Me.Detail1.Name = "Detail1"
        '
        'txtSeismicGasShutoffC
        '
        Me.txtSeismicGasShutoffC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtSeismicGasShutoffC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtSeismicGasShutoffC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtSeismicGasShutoffC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtSeismicGasShutoffC.DataField = "SeismicGasShutoffC"
        Me.txtSeismicGasShutoffC.Height = 0.188!
        Me.txtSeismicGasShutoffC.Left = 8.292002!
        Me.txtSeismicGasShutoffC.Name = "txtSeismicGasShutoffC"
        Me.txtSeismicGasShutoffC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtSeismicGasShutoffC.Text = "SeismicGasShutoffC"
        Me.txtSeismicGasShutoffC.Top = 0.125!
        Me.txtSeismicGasShutoffC.Visible = False
        Me.txtSeismicGasShutoffC.Width = 0.1829996!
        '
        'txtStorRacksBoltedC
        '
        Me.txtStorRacksBoltedC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtStorRacksBoltedC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtStorRacksBoltedC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtStorRacksBoltedC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtStorRacksBoltedC.DataField = "StorRacksBoltedC"
        Me.txtStorRacksBoltedC.Height = 0.188!
        Me.txtStorRacksBoltedC.Left = 8.742006!
        Me.txtStorRacksBoltedC.Name = "txtStorRacksBoltedC"
        Me.txtStorRacksBoltedC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtStorRacksBoltedC.Text = "StorRacksBoltedC"
        Me.txtStorRacksBoltedC.Top = 0.125!
        Me.txtStorRacksBoltedC.Visible = False
        Me.txtStorRacksBoltedC.Width = 0.3330002!
        '
        'txtNatGasFryerC
        '
        Me.txtNatGasFryerC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtNatGasFryerC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtNatGasFryerC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtNatGasFryerC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtNatGasFryerC.DataField = "NatGasFryerC"
        Me.txtNatGasFryerC.Height = 0.188!
        Me.txtNatGasFryerC.Left = 7.762003!
        Me.txtNatGasFryerC.Name = "txtNatGasFryerC"
        Me.txtNatGasFryerC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtNatGasFryerC.Text = "NatGasFryerC"
        Me.txtNatGasFryerC.Top = 0.125!
        Me.txtNatGasFryerC.Visible = False
        Me.txtNatGasFryerC.Width = 0.2629995!
        '
        'txtExitDoorsUnobstrC
        '
        Me.txtExitDoorsUnobstrC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtExitDoorsUnobstrC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtExitDoorsUnobstrC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtExitDoorsUnobstrC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtExitDoorsUnobstrC.DataField = "ExitDoorsUnobstrC"
        Me.txtExitDoorsUnobstrC.Height = 0.188!
        Me.txtExitDoorsUnobstrC.Left = 7.252003!
        Me.txtExitDoorsUnobstrC.Name = "txtExitDoorsUnobstrC"
        Me.txtExitDoorsUnobstrC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtExitDoorsUnobstrC.Text = "ExitDoorsUnobstrC"
        Me.txtExitDoorsUnobstrC.Top = 0.125!
        Me.txtExitDoorsUnobstrC.Visible = False
        Me.txtExitDoorsUnobstrC.Width = 0.243!
        '
        'txtExitSignsProvIllC
        '
        Me.txtExitSignsProvIllC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtExitSignsProvIllC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtExitSignsProvIllC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtExitSignsProvIllC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtExitSignsProvIllC.DataField = "ExitSignsProvIllC"
        Me.txtExitSignsProvIllC.Height = 0.188!
        Me.txtExitSignsProvIllC.Left = 6.742002!
        Me.txtExitSignsProvIllC.Name = "txtExitSignsProvIllC"
        Me.txtExitSignsProvIllC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtExitSignsProvIllC.Text = "ExitSignsProvIllC"
        Me.txtExitSignsProvIllC.Top = 0.125!
        Me.txtExitSignsProvIllC.Visible = False
        Me.txtExitSignsProvIllC.Width = 0.243!
        '
        'txtGenSecPreUnauthC
        '
        Me.txtGenSecPreUnauthC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtGenSecPreUnauthC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtGenSecPreUnauthC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtGenSecPreUnauthC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtGenSecPreUnauthC.DataField = "GenSecPreUnauthC"
        Me.txtGenSecPreUnauthC.Height = 0.188!
        Me.txtGenSecPreUnauthC.Left = 6.242002!
        Me.txtGenSecPreUnauthC.Name = "txtGenSecPreUnauthC"
        Me.txtGenSecPreUnauthC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtGenSecPreUnauthC.Text = "GenSecPreUnauthC"
        Me.txtGenSecPreUnauthC.Top = 0.125!
        Me.txtGenSecPreUnauthC.Visible = False
        Me.txtGenSecPreUnauthC.Width = 0.2329998!
        '
        'txtEmergGenOptMonthlyC
        '
        Me.txtEmergGenOptMonthlyC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtEmergGenOptMonthlyC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtEmergGenOptMonthlyC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtEmergGenOptMonthlyC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtEmergGenOptMonthlyC.DataField = "EmergGenOptMonthlyC"
        Me.txtEmergGenOptMonthlyC.Height = 0.188!
        Me.txtEmergGenOptMonthlyC.Left = 5.642001!
        Me.txtEmergGenOptMonthlyC.Name = "txtEmergGenOptMonthlyC"
        Me.txtEmergGenOptMonthlyC.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtEmergGenOptMonthlyC.Text = "EmergGenOptMonthlyC"
        Me.txtEmergGenOptMonthlyC.Top = 0.125!
        Me.txtEmergGenOptMonthlyC.Visible = False
        Me.txtEmergGenOptMonthlyC.Width = 0.3329997!
        '
        'txtBatOpEmerExitC
        '
        Me.txtBatOpEmerExitC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtBatOpEmerExitC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtBatOpEmerExitC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtBatOpEmerExitC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtBatOpEmerExitC.DataField = "BatOpEmerExitC"
        Me.txtBatOpEmerExitC.Height = 0.188!
        Me.txtBatOpEmerExitC.Left = 5.062!
        Me.txtBatOpEmerExitC.Name = "txtBatOpEmerExitC"
        Me.txtBatOpEmerExitC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtBatOpEmerExitC.Text = "BatOpEmerExitC"
        Me.txtBatOpEmerExitC.Top = 0.125!
        Me.txtBatOpEmerExitC.Visible = False
        Me.txtBatOpEmerExitC.Width = 0.3129997!
        '
        'txtELProvidedC
        '
        Me.txtELProvidedC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtELProvidedC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtELProvidedC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtELProvidedC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtELProvidedC.DataField = "ELProvidedC"
        Me.txtELProvidedC.Height = 0.188!
        Me.txtELProvidedC.Left = 4.562!
        Me.txtELProvidedC.Name = "txtELProvidedC"
        Me.txtELProvidedC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtELProvidedC.Text = "ELProvidedC"
        Me.txtELProvidedC.Top = 0.125!
        Me.txtELProvidedC.Visible = False
        Me.txtELProvidedC.Width = 0.2329998!
        '
        'txtELProvided
        '
        Me.txtELProvided.DataField = "ELProvided"
        Me.txtELProvided.Height = 0.3!
        Me.txtELProvided.Left = 4.42!
        Me.txtELProvided.Name = "txtELProvided"
        Me.txtELProvided.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtELProvided.Text = "ELProvided"
        Me.txtELProvided.Top = 0.05!
        Me.txtELProvided.Width = 0.5!
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
        'txtBatOpEmerExit
        '
        Me.txtBatOpEmerExit.DataField = "BatOpEmerExit"
        Me.txtBatOpEmerExit.Height = 0.3!
        Me.txtBatOpEmerExit.Left = 4.92!
        Me.txtBatOpEmerExit.Name = "txtBatOpEmerExit"
        Me.txtBatOpEmerExit.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtBatOpEmerExit.Text = "BatOpEmerExit"
        Me.txtBatOpEmerExit.Top = 0.05!
        Me.txtBatOpEmerExit.Width = 0.58!
        '
        'txtEmergGenOptMonthly
        '
        Me.txtEmergGenOptMonthly.DataField = "EmergGenOptMonthly"
        Me.txtEmergGenOptMonthly.Height = 0.3!
        Me.txtEmergGenOptMonthly.Left = 5.5!
        Me.txtEmergGenOptMonthly.Name = "txtEmergGenOptMonthly"
        Me.txtEmergGenOptMonthly.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtEmergGenOptMonthly.Text = "EmergGenOptMonthly"
        Me.txtEmergGenOptMonthly.Top = 0.05!
        Me.txtEmergGenOptMonthly.Width = 0.6!
        '
        'txtGenSecPreUnauth
        '
        Me.txtGenSecPreUnauth.DataField = "GenSecPreUnauth"
        Me.txtGenSecPreUnauth.Height = 0.3!
        Me.txtGenSecPreUnauth.Left = 6.1!
        Me.txtGenSecPreUnauth.Name = "txtGenSecPreUnauth"
        Me.txtGenSecPreUnauth.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtGenSecPreUnauth.Text = "GenSecPreUnauth"
        Me.txtGenSecPreUnauth.Top = 0.05!
        Me.txtGenSecPreUnauth.Width = 0.5!
        '
        'txtExitSignsProvIll
        '
        Me.txtExitSignsProvIll.DataField = "ExitSignsProvIll"
        Me.txtExitSignsProvIll.Height = 0.3!
        Me.txtExitSignsProvIll.Left = 6.6!
        Me.txtExitSignsProvIll.Name = "txtExitSignsProvIll"
        Me.txtExitSignsProvIll.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtExitSignsProvIll.Text = "ExitSignsProvIll"
        Me.txtExitSignsProvIll.Top = 0.05!
        Me.txtExitSignsProvIll.Width = 0.51!
        '
        'txtExitDoorsUnobstr
        '
        Me.txtExitDoorsUnobstr.DataField = "ExitDoorsUnobstr"
        Me.txtExitDoorsUnobstr.Height = 0.3!
        Me.txtExitDoorsUnobstr.Left = 7.11!
        Me.txtExitDoorsUnobstr.Name = "txtExitDoorsUnobstr"
        Me.txtExitDoorsUnobstr.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtExitDoorsUnobstr.Text = "ExitDoorsUnobstr"
        Me.txtExitDoorsUnobstr.Top = 0.05!
        Me.txtExitDoorsUnobstr.Width = 0.51!
        '
        'txtNatGasFryer
        '
        Me.txtNatGasFryer.DataField = "NatGasFryer"
        Me.txtNatGasFryer.Height = 0.3!
        Me.txtNatGasFryer.Left = 7.62!
        Me.txtNatGasFryer.Name = "txtNatGasFryer"
        Me.txtNatGasFryer.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtNatGasFryer.Text = "NatGasFryer"
        Me.txtNatGasFryer.Top = 0.05!
        Me.txtNatGasFryer.Width = 0.53!
        '
        'txtStorRacksBolted
        '
        Me.txtStorRacksBolted.DataField = "StorRacksBolted"
        Me.txtStorRacksBolted.Height = 0.3!
        Me.txtStorRacksBolted.Left = 8.6!
        Me.txtStorRacksBolted.Name = "txtStorRacksBolted"
        Me.txtStorRacksBolted.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtStorRacksBolted.Text = "StorRacksBolted"
        Me.txtStorRacksBolted.Top = 0.05!
        Me.txtStorRacksBolted.Width = 0.6!
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
        'txtSeismicGasShutoff
        '
        Me.txtSeismicGasShutoff.DataField = "SeismicGasShutoff"
        Me.txtSeismicGasShutoff.Height = 0.3!
        Me.txtSeismicGasShutoff.Left = 8.15!
        Me.txtSeismicGasShutoff.Name = "txtSeismicGasShutoff"
        Me.txtSeismicGasShutoff.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtSeismicGasShutoff.Text = "SeismicGasShutoff"
        Me.txtSeismicGasShutoff.Top = 0.05!
        Me.txtSeismicGasShutoff.Width = 0.45!
        '
        'line48
        '
        Me.line48.Height = 0.3!
        Me.line48.Left = 9.2!
        Me.line48.LineWeight = 1.0!
        Me.line48.Name = "line48"
        Me.line48.Top = 0.05!
        Me.line48.Width = 0.0!
        Me.line48.X1 = 9.2!
        Me.line48.X2 = 9.2!
        Me.line48.Y1 = 0.05!
        Me.line48.Y2 = 0.35!
        '
        'line49
        '
        Me.line49.Height = 0.3!
        Me.line49.Left = 8.6!
        Me.line49.LineWeight = 1.0!
        Me.line49.Name = "line49"
        Me.line49.Top = 0.05!
        Me.line49.Width = 0.0!
        Me.line49.X1 = 8.6!
        Me.line49.X2 = 8.6!
        Me.line49.Y1 = 0.05!
        Me.line49.Y2 = 0.35!
        '
        'line50
        '
        Me.line50.Height = 0.3!
        Me.line50.Left = 6.6!
        Me.line50.LineWeight = 1.0!
        Me.line50.Name = "line50"
        Me.line50.Top = 0.05!
        Me.line50.Width = 0.0!
        Me.line50.X1 = 6.6!
        Me.line50.X2 = 6.6!
        Me.line50.Y1 = 0.05!
        Me.line50.Y2 = 0.35!
        '
        'line51
        '
        Me.line51.Height = 0.3!
        Me.line51.Left = 7.11!
        Me.line51.LineWeight = 1.0!
        Me.line51.Name = "line51"
        Me.line51.Top = 0.05!
        Me.line51.Width = 0.0!
        Me.line51.X1 = 7.11!
        Me.line51.X2 = 7.11!
        Me.line51.Y1 = 0.05!
        Me.line51.Y2 = 0.35!
        '
        'line52
        '
        Me.line52.Height = 0.3!
        Me.line52.Left = 7.62!
        Me.line52.LineWeight = 1.0!
        Me.line52.Name = "line52"
        Me.line52.Top = 0.05!
        Me.line52.Width = 0.0!
        Me.line52.X1 = 7.62!
        Me.line52.X2 = 7.62!
        Me.line52.Y1 = 0.05!
        Me.line52.Y2 = 0.35!
        '
        'line53
        '
        Me.line53.Height = 0.3!
        Me.line53.Left = 8.15!
        Me.line53.LineWeight = 1.0!
        Me.line53.Name = "line53"
        Me.line53.Top = 0.05!
        Me.line53.Width = 0.0!
        Me.line53.X1 = 8.15!
        Me.line53.X2 = 8.15!
        Me.line53.Y1 = 0.05!
        Me.line53.Y2 = 0.35!
        '
        'line54
        '
        Me.line54.Height = 0.3!
        Me.line54.Left = 6.1!
        Me.line54.LineWeight = 1.0!
        Me.line54.Name = "line54"
        Me.line54.Top = 0.05!
        Me.line54.Width = 0.0!
        Me.line54.X1 = 6.1!
        Me.line54.X2 = 6.1!
        Me.line54.Y1 = 0.05!
        Me.line54.Y2 = 0.35!
        '
        'line55
        '
        Me.line55.Height = 0.3!
        Me.line55.Left = 5.5!
        Me.line55.LineWeight = 1.0!
        Me.line55.Name = "line55"
        Me.line55.Top = 0.05!
        Me.line55.Width = 0.0!
        Me.line55.X1 = 5.5!
        Me.line55.X2 = 5.5!
        Me.line55.Y1 = 0.05!
        Me.line55.Y2 = 0.35!
        '
        'line56
        '
        Me.line56.Height = 0.3!
        Me.line56.Left = 4.92!
        Me.line56.LineWeight = 1.0!
        Me.line56.Name = "line56"
        Me.line56.Top = 0.05!
        Me.line56.Width = 0.0!
        Me.line56.X1 = 4.92!
        Me.line56.X2 = 4.92!
        Me.line56.Y1 = 0.05!
        Me.line56.Y2 = 0.35!
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
        Me.line65.Width = 4.78!
        Me.line65.X1 = 4.42!
        Me.line65.X2 = 9.2!
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
        Me.line67.Width = 4.78!
        Me.line67.X1 = 4.42!
        Me.line67.X2 = 9.2!
        Me.line67.Y1 = 0.35!
        Me.line67.Y2 = 0.35!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtSort, Me.lblReportDate, Me.reportInfo1, Me.txtDisclaimer})
        Me.PageFooter1.Height = 0.4854167!
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
        Me.txtSort.Width = 9.2!
        '
        'lblReportDate
        '
        Me.lblReportDate.Height = 0.15!
        Me.lblReportDate.HyperLink = Nothing
        Me.lblReportDate.Left = 0.0000004768372!
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
        Me.reportInfo1.Left = 7.2!
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
        Me.txtDisclaimer.Width = 9.2!
        '
        'rptFireMiscellaneousSummary
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.25!
        Me.PageSettings.Margins.Left = 0.9!
        Me.PageSettings.Margins.Right = 0.9!
        Me.PageSettings.Margins.Top = 0.25!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 9.2!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Calibri; font-style: normal; text-decoration: none; font-weight: nor" & _
            "mal; font-size: 10pt; color: Black", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
            "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.lblClientName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFireMiscellaneousSummary, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.lblMiscellaneous, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblELProvided, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBatOpEmerExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblEmergGenOptMonthly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblGenSecPreUnauth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblExitDoorsUnobstr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNatGasFryer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSeismicGasShutoff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblStorRacksBolted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblClientLocNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFacility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblExitSignsProvIll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSeismicGasShutoffC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStorRacksBoltedC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNatGasFryerC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExitDoorsUnobstrC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExitSignsProvIllC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGenSecPreUnauthC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmergGenOptMonthlyC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBatOpEmerExitC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtELProvidedC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtELProvided, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDivision2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFileNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSurveyDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSTProv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTIV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBatOpEmerExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmergGenOptMonthly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGenSecPreUnauth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExitSignsProvIll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExitDoorsUnobstr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNatGasFryer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStorRacksBolted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFacility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientLocNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSeismicGasShutoff, System.ComponentModel.ISupportInitialize).EndInit()
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

    Private Sub rptFireMiscellaneousSummary_FetchData(ByVal sender As Object, ByVal eArgs As FetchEventArgs) Handles Me.FetchData
        Dim zControls() As ARControl = {txtELProvided,
                                        txtBatOpEmerExit,
                                        txtEmergGenOptMonthly,
                                        txtGenSecPreUnauth,
                                        txtExitSignsProvIll,
                                        txtExitDoorsUnobstr,
                                        txtNatGasFryer,
                                        txtSeismicGasShutoff,
                                        txtStorRacksBolted}
        Dim zCommentControls() As ARControl = {txtELProvidedC,
                                        txtBatOpEmerExitC,
                                        txtEmergGenOptMonthlyC,
                                        txtGenSecPreUnauthC,
                                        txtExitSignsProvIllC,
                                        txtExitDoorsUnobstrC,
                                        txtNatGasFryerC,
                                        txtSeismicGasShutoffC,
                                        txtStorRacksBoltedC}

        UtilReport.ActiveReport.SetItemBackColorByTextAndComment(Me, zControls, zCommentControls, rptProperties)
    End Sub

    Private Sub rptFireMiscellaneousSummary_ReportStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportStart
        lblClientName.Text = rptProperties.ClientName
        lblReportDate.Text = Now
        lblTIVGrid.Text = "TIV " & rptProperties.Currency.colFldCode & vbLf & "(millions)"
    End Sub

    Private Sub rptFireMiscellaneousSummary_PageStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.PageStart
        UtilReport.ActiveReport.SetFilter(Me, rptProperties)
        UtilReport.ActiveReport.SetSort(Me, rptProperties)
        UtilReport.ActiveReport.SetDisclaimer(Me, rptProperties)
    End Sub

    Private Sub rptFireMiscellaneousSummary_ReportEnd(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportEnd
        DisposeParameters()
    End Sub

    Private Sub DisposeParameters()
        DataSource = Nothing
    End Sub

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties

End Class
