Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports

Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing

Public Class rptFireCleaningElectricalSummary
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
    Private WithEvents lblFireCleaningElectricalSummary As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblLocationInformation As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFileNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblDivision2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblInspectionDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCity As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblAddress As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblSTProv As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCountry As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblTIVGrid As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblExhaustHoodsDuct As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblElectExtCords As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFiltersForCooking As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCleaning As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblElectrical As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblElectEquipFreeDam As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lbl36Clearance As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtFileNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSurveyDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCity As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSTProv As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCountry As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtTIV As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtDivision2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtAddress As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtExhaustHoodsDuct As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFiltersForCooking As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtElectExtCords As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtElectEquipFreeDam As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txt36Clearance As GrapeCity.ActiveReports.SectionReportModel.TextBox
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
    Private WithEvents line8 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line9 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line15 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line16 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line17 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line18 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line19 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line20 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line21 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtClientLocNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFacility As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblReportDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents line54 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line55 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line56 As GrapeCity.ActiveReports.SectionReportModel.Line
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
    Private WithEvents line77 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents reportInfo1 As GrapeCity.ActiveReports.SectionReportModel.ReportInfo
    Private WithEvents line6 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line10 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line11 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtDisclaimer As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txt36ClearanceC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtElectEquipFreeDamC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtElectExtCordsC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFiltersForCookingC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtExhaustHoodsDuctC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents PageFooter1 As GrapeCity.ActiveReports.SectionReportModel.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptFireCleaningElectricalSummary))
        Me.PageHeader1 = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.lblClientName = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFireCleaningElectricalSummary = New GrapeCity.ActiveReports.SectionReportModel.Label()
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
        Me.lblExhaustHoodsDuct = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblElectExtCords = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFiltersForCooking = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblCleaning = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblElectrical = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblElectEquipFreeDam = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lbl36Clearance = New GrapeCity.ActiveReports.SectionReportModel.Label()
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
        Me.line8 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line9 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line15 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line16 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line17 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line18 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line19 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line20 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line21 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line6 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line10 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line11 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Detail1 = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.txt36ClearanceC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtElectEquipFreeDamC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtElectExtCordsC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFiltersForCookingC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtExhaustHoodsDuctC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtElectEquipFreeDam = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtExhaustHoodsDuct = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFiltersForCooking = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtAddress = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtDivision2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFileNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSurveyDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCity = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSTProv = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCountry = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtTIV = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtElectExtCords = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt36Clearance = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFacility = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtClientLocNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.line54 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line55 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line56 = New GrapeCity.ActiveReports.SectionReportModel.Line()
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
        Me.line77 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.PageFooter1 = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.txtSort = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblReportDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.reportInfo1 = New GrapeCity.ActiveReports.SectionReportModel.ReportInfo()
        Me.txtDisclaimer = New GrapeCity.ActiveReports.SectionReportModel.Label()
        CType(Me.lblClientName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFireCleaningElectricalSummary, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.lblExhaustHoodsDuct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblElectExtCords, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFiltersForCooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCleaning, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblElectrical, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblElectEquipFreeDam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl36Clearance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblClientLocNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFacility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt36ClearanceC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtElectEquipFreeDamC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtElectExtCordsC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFiltersForCookingC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExhaustHoodsDuctC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtElectEquipFreeDam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExhaustHoodsDuct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFiltersForCooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDivision2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFileNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSurveyDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSTProv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTIV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtElectExtCords, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt36Clearance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFacility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientLocNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblReportDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisclaimer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.CanShrink = True
        Me.PageHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblClientName, Me.lblFireCleaningElectricalSummary, Me.lblLocationInformation, Me.picGRCLogo, Me.lblFileNo, Me.lblDivision2, Me.lblInspectionDate, Me.lblCity, Me.lblAddress, Me.lblSTProv, Me.lblCountry, Me.lblTIVGrid, Me.lblExhaustHoodsDuct, Me.lblElectExtCords, Me.lblFiltersForCooking, Me.lblCleaning, Me.lblElectrical, Me.lblElectEquipFreeDam, Me.lbl36Clearance, Me.lblFilters, Me.txtFilters, Me.lblClientLocNo, Me.lblFacility, Me.line1, Me.line2, Me.line3, Me.line4, Me.line5, Me.line7, Me.line8, Me.line9, Me.line15, Me.line16, Me.line17, Me.line18, Me.line19, Me.line20, Me.line21, Me.line6, Me.line10, Me.line11})
        Me.PageHeader1.Height = 1.65!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'lblClientName
        '
        Me.lblClientName.Height = 0.25!
        Me.lblClientName.HyperLink = Nothing
        Me.lblClientName.Left = 3.65!
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Style = "color: #C6D1DE; font-size: 16pt; font-style: italic; font-weight: bold; text-alig" & _
    "n: right; vertical-align: middle"
        Me.lblClientName.Text = "Company Name"
        Me.lblClientName.Top = 0.05!
        Me.lblClientName.Width = 4.3!
        '
        'lblFireCleaningElectricalSummary
        '
        Me.lblFireCleaningElectricalSummary.Height = 0.25!
        Me.lblFireCleaningElectricalSummary.HyperLink = Nothing
        Me.lblFireCleaningElectricalSummary.Left = 3.65!
        Me.lblFireCleaningElectricalSummary.Name = "lblFireCleaningElectricalSummary"
        Me.lblFireCleaningElectricalSummary.Style = "font-size: 12pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblFireCleaningElectricalSummary.Text = "Fire - Cleaning & Electrical Summary"
        Me.lblFireCleaningElectricalSummary.Top = 0.35!
        Me.lblFireCleaningElectricalSummary.Width = 4.3!
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
        'lblExhaustHoodsDuct
        '
        Me.lblExhaustHoodsDuct.Height = 0.45!
        Me.lblExhaustHoodsDuct.HyperLink = Nothing
        Me.lblExhaustHoodsDuct.Left = 4.42!
        Me.lblExhaustHoodsDuct.Name = "lblExhaustHoodsDuct"
        Me.lblExhaustHoodsDuct.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblExhaustHoodsDuct.Text = "Hoods/Ducts Cleaned - 6 Months"
        Me.lblExhaustHoodsDuct.Top = 1.2!
        Me.lblExhaustHoodsDuct.Width = 0.6!
        '
        'lblElectExtCords
        '
        Me.lblElectExtCords.Height = 0.45!
        Me.lblElectExtCords.HyperLink = Nothing
        Me.lblElectExtCords.Left = 5.72!
        Me.lblElectExtCords.Name = "lblElectExtCords"
        Me.lblElectExtCords.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblElectExtCords.Text = "Elect. Heavy- Duty Ext. Cords Only Temp."
        Me.lblElectExtCords.Top = 1.2!
        Me.lblElectExtCords.Width = 0.8!
        '
        'lblFiltersForCooking
        '
        Me.lblFiltersForCooking.Height = 0.45!
        Me.lblFiltersForCooking.HyperLink = Nothing
        Me.lblFiltersForCooking.Left = 5.02!
        Me.lblFiltersForCooking.Name = "lblFiltersForCooking"
        Me.lblFiltersForCooking.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblFiltersForCooking.Text = "Filters Clean/Grease Cup"
        Me.lblFiltersForCooking.Top = 1.2!
        Me.lblFiltersForCooking.Width = 0.65!
        '
        'lblCleaning
        '
        Me.lblCleaning.Height = 0.15!
        Me.lblCleaning.HyperLink = Nothing
        Me.lblCleaning.Left = 4.42!
        Me.lblCleaning.Name = "lblCleaning"
        Me.lblCleaning.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblCleaning.Text = "Cleaning"
        Me.lblCleaning.Top = 1.05!
        Me.lblCleaning.Width = 1.25!
        '
        'lblElectrical
        '
        Me.lblElectrical.Height = 0.15!
        Me.lblElectrical.HyperLink = Nothing
        Me.lblElectrical.Left = 5.72!
        Me.lblElectrical.Name = "lblElectrical"
        Me.lblElectrical.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblElectrical.Text = "Electrical"
        Me.lblElectrical.Top = 1.05!
        Me.lblElectrical.Width = 2.25!
        '
        'lblElectEquipFreeDam
        '
        Me.lblElectEquipFreeDam.Height = 0.45!
        Me.lblElectEquipFreeDam.HyperLink = Nothing
        Me.lblElectEquipFreeDam.Left = 6.52!
        Me.lblElectEquipFreeDam.Name = "lblElectEquipFreeDam"
        Me.lblElectEquipFreeDam.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblElectEquipFreeDam.Text = "Undam. Elect. Equip.& Properly Covered"
        Me.lblElectEquipFreeDam.Top = 1.2!
        Me.lblElectEquipFreeDam.Width = 0.7!
        '
        'lbl36Clearance
        '
        Me.lbl36Clearance.Height = 0.45!
        Me.lbl36Clearance.HyperLink = Nothing
        Me.lbl36Clearance.Left = 7.22!
        Me.lbl36Clearance.Name = "lbl36Clearance"
        Me.lbl36Clearance.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lbl36Clearance.Text = "36in Clearance in Front of Elec. Panels"
        Me.lbl36Clearance.Top = 1.2!
        Me.lbl36Clearance.Width = 0.75!
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
        Me.txtFilters.Width = 7.53!
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
        Me.line7.Left = 5.67!
        Me.line7.LineWeight = 1.0!
        Me.line7.Name = "line7"
        Me.line7.Top = 1.05!
        Me.line7.Width = 0.0!
        Me.line7.X1 = 5.67!
        Me.line7.X2 = 5.67!
        Me.line7.Y1 = 1.05!
        Me.line7.Y2 = 1.65!
        '
        'line8
        '
        Me.line8.Height = 0.6!
        Me.line8.Left = 5.72!
        Me.line8.LineWeight = 1.0!
        Me.line8.Name = "line8"
        Me.line8.Top = 1.05!
        Me.line8.Width = 0.0!
        Me.line8.X1 = 5.72!
        Me.line8.X2 = 5.72!
        Me.line8.Y1 = 1.05!
        Me.line8.Y2 = 1.65!
        '
        'line9
        '
        Me.line9.Height = 0.6!
        Me.line9.Left = 7.97!
        Me.line9.LineWeight = 1.0!
        Me.line9.Name = "line9"
        Me.line9.Top = 1.05!
        Me.line9.Width = 0.0!
        Me.line9.X1 = 7.97!
        Me.line9.X2 = 7.97!
        Me.line9.Y1 = 1.05!
        Me.line9.Y2 = 1.65!
        '
        'line15
        '
        Me.line15.Height = 0.45!
        Me.line15.Left = 13.0!
        Me.line15.LineWeight = 1.0!
        Me.line15.Name = "line15"
        Me.line15.Top = 1.05!
        Me.line15.Width = 0.0!
        Me.line15.X1 = 13.0!
        Me.line15.X2 = 13.0!
        Me.line15.Y1 = 1.05!
        Me.line15.Y2 = 1.5!
        '
        'line16
        '
        Me.line16.Height = 0.0!
        Me.line16.Left = 4.42!
        Me.line16.LineWeight = 1.0!
        Me.line16.Name = "line16"
        Me.line16.Top = 1.65!
        Me.line16.Width = 1.25!
        Me.line16.X1 = 4.42!
        Me.line16.X2 = 5.67!
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
        Me.line17.Width = 1.25!
        Me.line17.X1 = 4.42!
        Me.line17.X2 = 5.67!
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
        Me.line18.Width = 1.25!
        Me.line18.X1 = 4.42!
        Me.line18.X2 = 5.67!
        Me.line18.Y1 = 1.05!
        Me.line18.Y2 = 1.05!
        '
        'line19
        '
        Me.line19.Height = 0.0!
        Me.line19.Left = 5.72!
        Me.line19.LineWeight = 1.0!
        Me.line19.Name = "line19"
        Me.line19.Top = 1.65!
        Me.line19.Width = 2.25!
        Me.line19.X1 = 5.72!
        Me.line19.X2 = 7.97!
        Me.line19.Y1 = 1.65!
        Me.line19.Y2 = 1.65!
        '
        'line20
        '
        Me.line20.Height = 0.0!
        Me.line20.Left = 5.72!
        Me.line20.LineWeight = 1.0!
        Me.line20.Name = "line20"
        Me.line20.Top = 1.2!
        Me.line20.Width = 2.25!
        Me.line20.X1 = 5.72!
        Me.line20.X2 = 7.97!
        Me.line20.Y1 = 1.2!
        Me.line20.Y2 = 1.2!
        '
        'line21
        '
        Me.line21.Height = 0.0!
        Me.line21.Left = 5.72!
        Me.line21.LineWeight = 1.0!
        Me.line21.Name = "line21"
        Me.line21.Top = 1.05!
        Me.line21.Width = 2.25!
        Me.line21.X1 = 5.72!
        Me.line21.X2 = 7.97!
        Me.line21.Y1 = 1.05!
        Me.line21.Y2 = 1.05!
        '
        'line6
        '
        Me.line6.Height = 0.4499999!
        Me.line6.Left = 5.02!
        Me.line6.LineWeight = 1.0!
        Me.line6.Name = "line6"
        Me.line6.Top = 1.2!
        Me.line6.Width = 0.0!
        Me.line6.X1 = 5.02!
        Me.line6.X2 = 5.02!
        Me.line6.Y1 = 1.2!
        Me.line6.Y2 = 1.65!
        '
        'line10
        '
        Me.line10.Height = 0.4499999!
        Me.line10.Left = 6.52!
        Me.line10.LineWeight = 1.0!
        Me.line10.Name = "line10"
        Me.line10.Top = 1.2!
        Me.line10.Width = 0.0!
        Me.line10.X1 = 6.52!
        Me.line10.X2 = 6.52!
        Me.line10.Y1 = 1.2!
        Me.line10.Y2 = 1.65!
        '
        'line11
        '
        Me.line11.Height = 0.4499999!
        Me.line11.Left = 7.22!
        Me.line11.LineWeight = 1.0!
        Me.line11.Name = "line11"
        Me.line11.Top = 1.2!
        Me.line11.Width = 0.0!
        Me.line11.X1 = 7.22!
        Me.line11.X2 = 7.22!
        Me.line11.Y1 = 1.2!
        Me.line11.Y2 = 1.65!
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txt36ClearanceC, Me.txtElectEquipFreeDamC, Me.txtElectExtCordsC, Me.txtFiltersForCookingC, Me.txtExhaustHoodsDuctC, Me.txtElectEquipFreeDam, Me.txtExhaustHoodsDuct, Me.txtFiltersForCooking, Me.txtAddress, Me.txtDivision2, Me.txtFileNo, Me.txtSurveyDate, Me.txtCity, Me.txtSTProv, Me.txtCountry, Me.txtTIV, Me.txtElectExtCords, Me.txt36Clearance, Me.txtFacility, Me.txtClientLocNo, Me.line54, Me.line55, Me.line56, Me.line58, Me.line59, Me.line60, Me.line61, Me.line62, Me.line63, Me.line64, Me.line65, Me.line67, Me.line68, Me.line70, Me.line77})
        Me.Detail1.Height = 0.363!
        Me.Detail1.KeepTogether = True
        Me.Detail1.Name = "Detail1"
        '
        'txt36ClearanceC
        '
        Me.txt36ClearanceC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt36ClearanceC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt36ClearanceC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt36ClearanceC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt36ClearanceC.DataField = "ThirtySixClearanceC"
        Me.txt36ClearanceC.Height = 0.07395833!
        Me.txt36ClearanceC.Left = 7.562!
        Me.txt36ClearanceC.Name = "txt36ClearanceC"
        Me.txt36ClearanceC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txt36ClearanceC.Text = "ThirtySixClearanceC"
        Me.txt36ClearanceC.Top = 0.126!
        Me.txt36ClearanceC.Visible = False
        Me.txt36ClearanceC.Width = 0.1750002!
        '
        'txtElectEquipFreeDamC
        '
        Me.txtElectEquipFreeDamC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtElectEquipFreeDamC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtElectEquipFreeDamC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtElectEquipFreeDamC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtElectEquipFreeDamC.DataField = "ElectEquipFreeDamC"
        Me.txtElectEquipFreeDamC.Height = 0.07395833!
        Me.txtElectEquipFreeDamC.Left = 6.812!
        Me.txtElectEquipFreeDamC.Name = "txtElectEquipFreeDamC"
        Me.txtElectEquipFreeDamC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtElectEquipFreeDamC.Text = "ElectEquipFreeDamC"
        Me.txtElectEquipFreeDamC.Top = 0.126!
        Me.txtElectEquipFreeDamC.Visible = False
        Me.txtElectEquipFreeDamC.Width = 0.1750002!
        '
        'txtElectExtCordsC
        '
        Me.txtElectExtCordsC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtElectExtCordsC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtElectExtCordsC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtElectExtCordsC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtElectExtCordsC.DataField = "ElectExtCordsC"
        Me.txtElectExtCordsC.Height = 0.07395833!
        Me.txtElectExtCordsC.Left = 6.0!
        Me.txtElectExtCordsC.Name = "txtElectExtCordsC"
        Me.txtElectExtCordsC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtElectExtCordsC.Text = "ElectExtCordsC"
        Me.txtElectExtCordsC.Top = 0.126!
        Me.txtElectExtCordsC.Visible = False
        Me.txtElectExtCordsC.Width = 0.1750002!
        '
        'txtFiltersForCookingC
        '
        Me.txtFiltersForCookingC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtFiltersForCookingC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtFiltersForCookingC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtFiltersForCookingC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtFiltersForCookingC.DataField = "FiltersForCookingC"
        Me.txtFiltersForCookingC.Height = 0.07395833!
        Me.txtFiltersForCookingC.Left = 5.25!
        Me.txtFiltersForCookingC.Name = "txtFiltersForCookingC"
        Me.txtFiltersForCookingC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtFiltersForCookingC.Text = "FiltersForCookingC"
        Me.txtFiltersForCookingC.Top = 0.126!
        Me.txtFiltersForCookingC.Visible = False
        Me.txtFiltersForCookingC.Width = 0.1750002!
        '
        'txtExhaustHoodsDuctC
        '
        Me.txtExhaustHoodsDuctC.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtExhaustHoodsDuctC.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtExhaustHoodsDuctC.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtExhaustHoodsDuctC.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtExhaustHoodsDuctC.DataField = "ExhaustHoodsDuctC"
        Me.txtExhaustHoodsDuctC.Height = 0.07395837!
        Me.txtExhaustHoodsDuctC.Left = 4.687!
        Me.txtExhaustHoodsDuctC.Name = "txtExhaustHoodsDuctC"
        Me.txtExhaustHoodsDuctC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtExhaustHoodsDuctC.Text = "ExhaustHoodsDuctC"
        Me.txtExhaustHoodsDuctC.Top = 0.126!
        Me.txtExhaustHoodsDuctC.Visible = False
        Me.txtExhaustHoodsDuctC.Width = 0.1750002!
        '
        'txtElectEquipFreeDam
        '
        Me.txtElectEquipFreeDam.DataField = "ElectEquipFreeDam"
        Me.txtElectEquipFreeDam.Height = 0.3!
        Me.txtElectEquipFreeDam.Left = 6.52!
        Me.txtElectEquipFreeDam.Name = "txtElectEquipFreeDam"
        Me.txtElectEquipFreeDam.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtElectEquipFreeDam.Text = "ElectEquipFreeDam"
        Me.txtElectEquipFreeDam.Top = 0.05!
        Me.txtElectEquipFreeDam.Width = 0.7!
        '
        'txtExhaustHoodsDuct
        '
        Me.txtExhaustHoodsDuct.DataField = "ExhaustHoodsDuct"
        Me.txtExhaustHoodsDuct.Height = 0.3!
        Me.txtExhaustHoodsDuct.Left = 4.42!
        Me.txtExhaustHoodsDuct.Name = "txtExhaustHoodsDuct"
        Me.txtExhaustHoodsDuct.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtExhaustHoodsDuct.Text = "ExhaustHoodsDuct"
        Me.txtExhaustHoodsDuct.Top = 0.05!
        Me.txtExhaustHoodsDuct.Width = 0.6!
        '
        'txtFiltersForCooking
        '
        Me.txtFiltersForCooking.DataField = "FiltersForCooking"
        Me.txtFiltersForCooking.Height = 0.3!
        Me.txtFiltersForCooking.Left = 5.02!
        Me.txtFiltersForCooking.Name = "txtFiltersForCooking"
        Me.txtFiltersForCooking.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtFiltersForCooking.Text = "FiltersForCooking"
        Me.txtFiltersForCooking.Top = 0.05!
        Me.txtFiltersForCooking.Width = 0.65!
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
        'txtElectExtCords
        '
        Me.txtElectExtCords.DataField = "ElectExtCords"
        Me.txtElectExtCords.Height = 0.3!
        Me.txtElectExtCords.Left = 5.72!
        Me.txtElectExtCords.Name = "txtElectExtCords"
        Me.txtElectExtCords.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtElectExtCords.Text = "ElectExtCords"
        Me.txtElectExtCords.Top = 0.05!
        Me.txtElectExtCords.Width = 0.8!
        '
        'txt36Clearance
        '
        Me.txt36Clearance.DataField = "ThirtySixClearance"
        Me.txt36Clearance.Height = 0.3!
        Me.txt36Clearance.Left = 7.22!
        Me.txt36Clearance.Name = "txt36Clearance"
        Me.txt36Clearance.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txt36Clearance.Text = "ThirtySixClearance"
        Me.txt36Clearance.Top = 0.05!
        Me.txt36Clearance.Width = 0.75!
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
        'line54
        '
        Me.line54.Height = 0.3!
        Me.line54.Left = 7.97!
        Me.line54.LineWeight = 1.0!
        Me.line54.Name = "line54"
        Me.line54.Top = 0.05!
        Me.line54.Width = 0.0!
        Me.line54.X1 = 7.97!
        Me.line54.X2 = 7.97!
        Me.line54.Y1 = 0.05!
        Me.line54.Y2 = 0.35!
        '
        'line55
        '
        Me.line55.Height = 0.3!
        Me.line55.Left = 7.22!
        Me.line55.LineWeight = 1.0!
        Me.line55.Name = "line55"
        Me.line55.Top = 0.05!
        Me.line55.Width = 0.0!
        Me.line55.X1 = 7.22!
        Me.line55.X2 = 7.22!
        Me.line55.Y1 = 0.05!
        Me.line55.Y2 = 0.35!
        '
        'line56
        '
        Me.line56.Height = 0.3!
        Me.line56.Left = 6.52!
        Me.line56.LineWeight = 1.0!
        Me.line56.Name = "line56"
        Me.line56.Top = 0.05!
        Me.line56.Width = 0.0!
        Me.line56.X1 = 6.52!
        Me.line56.X2 = 6.52!
        Me.line56.Y1 = 0.05!
        Me.line56.Y2 = 0.35!
        '
        'line58
        '
        Me.line58.Height = 0.3!
        Me.line58.Left = 5.72!
        Me.line58.LineWeight = 1.0!
        Me.line58.Name = "line58"
        Me.line58.Top = 0.05!
        Me.line58.Width = 0.0!
        Me.line58.X1 = 5.72!
        Me.line58.X2 = 5.72!
        Me.line58.Y1 = 0.05!
        Me.line58.Y2 = 0.35!
        '
        'line59
        '
        Me.line59.Height = 0.3!
        Me.line59.Left = 5.67!
        Me.line59.LineWeight = 1.0!
        Me.line59.Name = "line59"
        Me.line59.Top = 0.05!
        Me.line59.Width = 0.0!
        Me.line59.X1 = 5.67!
        Me.line59.X2 = 5.67!
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
        Me.line65.Width = 1.25!
        Me.line65.X1 = 4.42!
        Me.line65.X2 = 5.67!
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
        Me.line67.Width = 1.25!
        Me.line67.X1 = 4.42!
        Me.line67.X2 = 5.67!
        Me.line67.Y1 = 0.35!
        Me.line67.Y2 = 0.35!
        '
        'line68
        '
        Me.line68.Height = 0.0!
        Me.line68.Left = 5.72!
        Me.line68.LineWeight = 1.0!
        Me.line68.Name = "line68"
        Me.line68.Top = 0.05!
        Me.line68.Width = 2.25!
        Me.line68.X1 = 5.72!
        Me.line68.X2 = 7.97!
        Me.line68.Y1 = 0.05!
        Me.line68.Y2 = 0.05!
        '
        'line70
        '
        Me.line70.Height = 0.0!
        Me.line70.Left = 5.72!
        Me.line70.LineWeight = 1.0!
        Me.line70.Name = "line70"
        Me.line70.Top = 0.35!
        Me.line70.Width = 2.25!
        Me.line70.X1 = 5.72!
        Me.line70.X2 = 7.97!
        Me.line70.Y1 = 0.35!
        Me.line70.Y2 = 0.35!
        '
        'line77
        '
        Me.line77.Height = 0.3!
        Me.line77.Left = 5.02!
        Me.line77.LineWeight = 1.0!
        Me.line77.Name = "line77"
        Me.line77.Top = 0.05!
        Me.line77.Width = 0.0!
        Me.line77.X1 = 5.02!
        Me.line77.X2 = 5.02!
        Me.line77.Y1 = 0.05!
        Me.line77.Y2 = 0.35!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtSort, Me.lblReportDate, Me.reportInfo1, Me.txtDisclaimer})
        Me.PageFooter1.Height = 0.4541667!
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
        Me.txtSort.Width = 8.0!
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
        Me.reportInfo1.Left = 6.0!
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
        Me.txtDisclaimer.Width = 8.0!
        '
        'rptFireCleaningElectricalSummary
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.25!
        Me.PageSettings.Margins.Left = 1.5!
        Me.PageSettings.Margins.Right = 1.5!
        Me.PageSettings.Margins.Top = 0.25!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 8.0!
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
        CType(Me.lblFireCleaningElectricalSummary, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.lblExhaustHoodsDuct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblElectExtCords, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFiltersForCooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCleaning, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblElectrical, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblElectEquipFreeDam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl36Clearance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblClientLocNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFacility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt36ClearanceC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtElectEquipFreeDamC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtElectExtCordsC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFiltersForCookingC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExhaustHoodsDuctC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtElectEquipFreeDam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExhaustHoodsDuct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFiltersForCooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDivision2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFileNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSurveyDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSTProv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTIV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtElectExtCords, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt36Clearance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFacility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientLocNo, System.ComponentModel.ISupportInitialize).EndInit()
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

    Private Sub rptFireCleaningElectricalSummary_FetchData(ByVal sender As Object, ByVal eArgs As FetchEventArgs) Handles Me.FetchData
        Dim zControls() As ARControl = {txtExhaustHoodsDuct, txtFiltersForCooking, txtElectExtCords, txtElectEquipFreeDam, txt36Clearance}
        Dim zCommentControls() As ARControl = {txtExhaustHoodsDuctC, txtFiltersForCookingC, txtElectExtCordsC, txtElectEquipFreeDamC, txt36ClearanceC}
        UtilReport.ActiveReport.SetItemBackColorByTextAndComment(Me, zControls, zCommentControls, rptProperties)
    End Sub

    Private Sub rptFireCleaningElectricalSummary_ReportStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportStart
        lblClientName.Text = rptProperties.ClientName
        lblReportDate.Text = Now
        lblTIVGrid.Text = "TIV " & rptProperties.Currency.colFldCode & vbLf & "(millions)"
    End Sub

    Private Sub rptFireCleaningElectricalSummary_PageStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.PageStart
        UtilReport.ActiveReport.SetFilter(Me, rptProperties)
        UtilReport.ActiveReport.SetSort(Me, rptProperties)
        UtilReport.ActiveReport.SetDisclaimer(Me, rptProperties)
    End Sub

    Private Sub rptFireCleaningElectricalSummary_ReportEnd(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportEnd
        DisposeParameters()
    End Sub

    Private Sub DisposeParameters()
        DataSource = Nothing
    End Sub

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties

End Class
