Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports

Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing

Public Class rptBMMechMaintenanceSummary
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
    Private WithEvents lblReport As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblLocationInformation As GrapeCity.ActiveReports.SectionReportModel.Label
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
    Private WithEvents lblRating As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblMechEquipC As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblMechPreMaintAdequacy As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblMechPreMaintVibe As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblMechPreMaintLubeOil As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblMechPreMaintNDE As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblActive As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblMechPreMaintOverspeed As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblMechPreMaintVisual As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblMechPreMaintAlign As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblMechPreMaintOther As GrapeCity.ActiveReports.SectionReportModel.Label
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
    Private WithEvents txtMechEquipC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtMechPreMaintAdequacy As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtMechPreMaintVibe As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtMechPreMaintLubeOil As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtMechPreMaintNDE As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtMechPreMaintOverspeed As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtMechPreMaintVisual As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtMechPreMaintAlign As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtMechPreMaintOther As GrapeCity.ActiveReports.SectionReportModel.TextBox
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
    Private WithEvents txtClientLocNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFacility As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents line42 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lblReportDate As GrapeCity.ActiveReports.SectionReportModel.Label
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
    Private WithEvents line69 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line70 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line71 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line72 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line6 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents reportInfo1 As GrapeCity.ActiveReports.SectionReportModel.ReportInfo
    Private WithEvents txtDisclaimer As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents PageFooter1 As GrapeCity.ActiveReports.SectionReportModel.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptBMMechMaintenanceSummary))
        Me.PageHeader1 = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.lblRating = New GrapeCity.ActiveReports.SectionReportModel.Label()
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
        Me.lblMechEquipC = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblMechPreMaintAdequacy = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblMechPreMaintVibe = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblMechPreMaintNDE = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblMechPreMaintOverspeed = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblMechPreMaintVisual = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblMechPreMaintAlign = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFilters = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtFilters = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblClientLocNo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFacility = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblMechPreMaintLubeOil = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblMechPreMaintOther = New GrapeCity.ActiveReports.SectionReportModel.Label()
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
        Me.line6 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Detail1 = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.txtMechEquipC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
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
        Me.txtMechPreMaintAdequacy = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMechPreMaintVibe = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMechPreMaintLubeOil = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMechPreMaintNDE = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMechPreMaintOverspeed = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMechPreMaintAlign = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMechPreMaintOther = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFacility = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtClientLocNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMechPreMaintVisual = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.line42 = New GrapeCity.ActiveReports.SectionReportModel.Line()
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
        Me.line69 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line70 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line71 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line72 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.PageFooter1 = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.txtSort = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblReportDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.reportInfo1 = New GrapeCity.ActiveReports.SectionReportModel.ReportInfo()
        Me.txtDisclaimer = New GrapeCity.ActiveReports.SectionReportModel.Label()
        CType(Me.lblRating, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.lblMechEquipC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMechPreMaintAdequacy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMechPreMaintVibe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMechPreMaintNDE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMechPreMaintOverspeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMechPreMaintVisual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMechPreMaintAlign, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblClientLocNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFacility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMechPreMaintLubeOil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMechPreMaintOther, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMechEquipC, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.txtMechPreMaintAdequacy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMechPreMaintVibe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMechPreMaintLubeOil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMechPreMaintNDE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMechPreMaintOverspeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMechPreMaintAlign, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMechPreMaintOther, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFacility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientLocNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMechPreMaintVisual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblReportDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisclaimer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.CanShrink = True
        Me.PageHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblRating, Me.lblActive, Me.lblClientName, Me.lblReport, Me.lblLocationInformation, Me.picGRCLogo, Me.lblFileNo, Me.lblDivision2, Me.lblInspectionDate, Me.lblCity, Me.lblAddress, Me.lblSTProv, Me.lblCountry, Me.lblTIVGrid, Me.lblOccupancy, Me.lblMajorGroup, Me.lblSpecificGroup, Me.lblMechEquipC, Me.lblMechPreMaintAdequacy, Me.lblMechPreMaintVibe, Me.lblMechPreMaintNDE, Me.lblMechPreMaintOverspeed, Me.lblMechPreMaintVisual, Me.lblMechPreMaintAlign, Me.lblFilters, Me.txtFilters, Me.lblClientLocNo, Me.lblFacility, Me.lblMechPreMaintLubeOil, Me.lblMechPreMaintOther, Me.line1, Me.line2, Me.line3, Me.line4, Me.line5, Me.line7, Me.line8, Me.line9, Me.line10, Me.line11, Me.line16, Me.line17, Me.line18, Me.line19, Me.line20, Me.line21, Me.line23, Me.line24, Me.line6})
        Me.PageHeader1.Height = 1.5!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'lblRating
        '
        Me.lblRating.Height = 0.15!
        Me.lblRating.HyperLink = Nothing
        Me.lblRating.Left = 5.77!
        Me.lblRating.Name = "lblRating"
        Me.lblRating.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblRating.Text = "Rating"
        Me.lblRating.Top = 1.05!
        Me.lblRating.Width = 0.38!
        '
        'lblActive
        '
        Me.lblActive.Height = 0.15!
        Me.lblActive.HyperLink = Nothing
        Me.lblActive.Left = 6.2!
        Me.lblActive.Name = "lblActive"
        Me.lblActive.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblActive.Text = "Active"
        Me.lblActive.Top = 1.05!
        Me.lblActive.Width = 5.4!
        '
        'lblClientName
        '
        Me.lblClientName.Height = 0.25!
        Me.lblClientName.HyperLink = Nothing
        Me.lblClientName.Left = 7.25!
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
        Me.lblReport.Left = 7.25!
        Me.lblReport.Name = "lblReport"
        Me.lblReport.Style = "font-size: 12pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblReport.Text = "B&M Mechanical Maintenance Summary"
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
        Me.lblInspectionDate.Left = 0.5!
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
        Me.lblAddress.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
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
        Me.lblMajorGroup.Top = 1.2!
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
        Me.lblSpecificGroup.Top = 1.35!
        Me.lblSpecificGroup.Width = 1.3!
        '
        'lblMechEquipC
        '
        Me.lblMechEquipC.Height = 0.3!
        Me.lblMechEquipC.HyperLink = Nothing
        Me.lblMechEquipC.Left = 5.77!
        Me.lblMechEquipC.Name = "lblMechEquipC"
        Me.lblMechEquipC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblMechEquipC.Text = "Mech. Equip."
        Me.lblMechEquipC.Top = 1.2!
        Me.lblMechEquipC.Width = 0.38!
        '
        'lblMechPreMaintAdequacy
        '
        Me.lblMechPreMaintAdequacy.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblMechPreMaintAdequacy.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblMechPreMaintAdequacy.Height = 0.3!
        Me.lblMechPreMaintAdequacy.HyperLink = Nothing
        Me.lblMechPreMaintAdequacy.Left = 6.2!
        Me.lblMechPreMaintAdequacy.Name = "lblMechPreMaintAdequacy"
        Me.lblMechPreMaintAdequacy.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblMechPreMaintAdequacy.Text = "Overall Program"
        Me.lblMechPreMaintAdequacy.Top = 1.2!
        Me.lblMechPreMaintAdequacy.Width = 0.6800003!
        '
        'lblMechPreMaintVibe
        '
        Me.lblMechPreMaintVibe.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblMechPreMaintVibe.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblMechPreMaintVibe.Height = 0.3!
        Me.lblMechPreMaintVibe.HyperLink = Nothing
        Me.lblMechPreMaintVibe.Left = 6.880001!
        Me.lblMechPreMaintVibe.Name = "lblMechPreMaintVibe"
        Me.lblMechPreMaintVibe.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblMechPreMaintVibe.Text = "Vibration Analysis"
        Me.lblMechPreMaintVibe.Top = 1.2!
        Me.lblMechPreMaintVibe.Width = 0.65!
        '
        'lblMechPreMaintNDE
        '
        Me.lblMechPreMaintNDE.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblMechPreMaintNDE.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblMechPreMaintNDE.Height = 0.3!
        Me.lblMechPreMaintNDE.HyperLink = Nothing
        Me.lblMechPreMaintNDE.Left = 8.179996!
        Me.lblMechPreMaintNDE.Name = "lblMechPreMaintNDE"
        Me.lblMechPreMaintNDE.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblMechPreMaintNDE.Text = "NDE"
        Me.lblMechPreMaintNDE.Top = 1.2!
        Me.lblMechPreMaintNDE.Width = 0.65!
        '
        'lblMechPreMaintOverspeed
        '
        Me.lblMechPreMaintOverspeed.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblMechPreMaintOverspeed.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblMechPreMaintOverspeed.Height = 0.3!
        Me.lblMechPreMaintOverspeed.HyperLink = Nothing
        Me.lblMechPreMaintOverspeed.Left = 8.829996!
        Me.lblMechPreMaintOverspeed.Name = "lblMechPreMaintOverspeed"
        Me.lblMechPreMaintOverspeed.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblMechPreMaintOverspeed.Text = "Overspeed Trip Testing"
        Me.lblMechPreMaintOverspeed.Top = 1.2!
        Me.lblMechPreMaintOverspeed.Width = 0.65!
        '
        'lblMechPreMaintVisual
        '
        Me.lblMechPreMaintVisual.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblMechPreMaintVisual.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblMechPreMaintVisual.Height = 0.3!
        Me.lblMechPreMaintVisual.HyperLink = Nothing
        Me.lblMechPreMaintVisual.Left = 9.479996!
        Me.lblMechPreMaintVisual.Name = "lblMechPreMaintVisual"
        Me.lblMechPreMaintVisual.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblMechPreMaintVisual.Text = "Visual Inspection(s)"
        Me.lblMechPreMaintVisual.Top = 1.2!
        Me.lblMechPreMaintVisual.Width = 0.65!
        '
        'lblMechPreMaintAlign
        '
        Me.lblMechPreMaintAlign.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblMechPreMaintAlign.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblMechPreMaintAlign.Height = 0.3!
        Me.lblMechPreMaintAlign.HyperLink = Nothing
        Me.lblMechPreMaintAlign.Left = 10.13!
        Me.lblMechPreMaintAlign.Name = "lblMechPreMaintAlign"
        Me.lblMechPreMaintAlign.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblMechPreMaintAlign.Text = "Alignment"
        Me.lblMechPreMaintAlign.Top = 1.2!
        Me.lblMechPreMaintAlign.Width = 0.7200054!
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
        Me.txtFilters.Width = 11.16!
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
        'lblMechPreMaintLubeOil
        '
        Me.lblMechPreMaintLubeOil.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblMechPreMaintLubeOil.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblMechPreMaintLubeOil.Height = 0.3!
        Me.lblMechPreMaintLubeOil.HyperLink = Nothing
        Me.lblMechPreMaintLubeOil.Left = 7.530001!
        Me.lblMechPreMaintLubeOil.Name = "lblMechPreMaintLubeOil"
        Me.lblMechPreMaintLubeOil.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblMechPreMaintLubeOil.Text = "Lube Oil Testing"
        Me.lblMechPreMaintLubeOil.Top = 1.2!
        Me.lblMechPreMaintLubeOil.Width = 0.65!
        '
        'lblMechPreMaintOther
        '
        Me.lblMechPreMaintOther.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblMechPreMaintOther.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblMechPreMaintOther.Height = 0.3!
        Me.lblMechPreMaintOther.HyperLink = Nothing
        Me.lblMechPreMaintOther.Left = 10.85!
        Me.lblMechPreMaintOther.Name = "lblMechPreMaintOther"
        Me.lblMechPreMaintOther.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblMechPreMaintOther.Text = "Other"
        Me.lblMechPreMaintOther.Top = 1.2!
        Me.lblMechPreMaintOther.Width = 0.7500004!
        '
        'line1
        '
        Me.line1.Height = 0.0!
        Me.line1.Left = 0.0!
        Me.line1.LineWeight = 1.0!
        Me.line1.Name = "line1"
        Me.line1.Top = 1.5!
        Me.line1.Width = 4.37!
        Me.line1.X1 = 0.0!
        Me.line1.X2 = 4.37!
        Me.line1.Y1 = 1.5!
        Me.line1.Y2 = 1.5!
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
        Me.line3.Height = 0.45!
        Me.line3.Left = 0.0!
        Me.line3.LineWeight = 1.0!
        Me.line3.Name = "line3"
        Me.line3.Top = 1.05!
        Me.line3.Width = 0.0!
        Me.line3.X1 = 0.0!
        Me.line3.X2 = 0.0!
        Me.line3.Y1 = 1.05!
        Me.line3.Y2 = 1.5!
        '
        'line4
        '
        Me.line4.Height = 0.45!
        Me.line4.Left = 4.37!
        Me.line4.LineWeight = 1.0!
        Me.line4.Name = "line4"
        Me.line4.Top = 1.05!
        Me.line4.Width = 0.0!
        Me.line4.X1 = 4.37!
        Me.line4.X2 = 4.37!
        Me.line4.Y1 = 1.05!
        Me.line4.Y2 = 1.5!
        '
        'line5
        '
        Me.line5.Height = 0.45!
        Me.line5.Left = 4.42!
        Me.line5.LineWeight = 1.0!
        Me.line5.Name = "line5"
        Me.line5.Top = 1.05!
        Me.line5.Width = 0.0!
        Me.line5.X1 = 4.42!
        Me.line5.X2 = 4.42!
        Me.line5.Y1 = 1.05!
        Me.line5.Y2 = 1.5!
        '
        'line7
        '
        Me.line7.Height = 0.45!
        Me.line7.Left = 5.72!
        Me.line7.LineWeight = 1.0!
        Me.line7.Name = "line7"
        Me.line7.Top = 1.05!
        Me.line7.Width = 0.0!
        Me.line7.X1 = 5.72!
        Me.line7.X2 = 5.72!
        Me.line7.Y1 = 1.05!
        Me.line7.Y2 = 1.5!
        '
        'line8
        '
        Me.line8.Height = 0.45!
        Me.line8.Left = 5.77!
        Me.line8.LineWeight = 1.0!
        Me.line8.Name = "line8"
        Me.line8.Top = 1.05!
        Me.line8.Width = 0.0!
        Me.line8.X1 = 5.77!
        Me.line8.X2 = 5.77!
        Me.line8.Y1 = 1.05!
        Me.line8.Y2 = 1.5!
        '
        'line9
        '
        Me.line9.Height = 0.45!
        Me.line9.Left = 6.2!
        Me.line9.LineWeight = 1.0!
        Me.line9.Name = "line9"
        Me.line9.Top = 1.05!
        Me.line9.Width = 0.0!
        Me.line9.X1 = 6.2!
        Me.line9.X2 = 6.2!
        Me.line9.Y1 = 1.05!
        Me.line9.Y2 = 1.5!
        '
        'line10
        '
        Me.line10.Height = 0.45!
        Me.line10.Left = 6.15!
        Me.line10.LineWeight = 1.0!
        Me.line10.Name = "line10"
        Me.line10.Top = 1.05!
        Me.line10.Width = 0.0!
        Me.line10.X1 = 6.15!
        Me.line10.X2 = 6.15!
        Me.line10.Y1 = 1.05!
        Me.line10.Y2 = 1.5!
        '
        'line11
        '
        Me.line11.Height = 0.45!
        Me.line11.Left = 11.6!
        Me.line11.LineWeight = 1.0!
        Me.line11.Name = "line11"
        Me.line11.Top = 1.05!
        Me.line11.Width = 0.0!
        Me.line11.X1 = 11.6!
        Me.line11.X2 = 11.6!
        Me.line11.Y1 = 1.05!
        Me.line11.Y2 = 1.5!
        '
        'line16
        '
        Me.line16.Height = 0.0!
        Me.line16.Left = 4.42!
        Me.line16.LineWeight = 1.0!
        Me.line16.Name = "line16"
        Me.line16.Top = 1.5!
        Me.line16.Width = 1.3!
        Me.line16.X1 = 4.42!
        Me.line16.X2 = 5.72!
        Me.line16.Y1 = 1.5!
        Me.line16.Y2 = 1.5!
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
        Me.line19.Top = 1.5!
        Me.line19.Width = 0.3800001!
        Me.line19.X1 = 5.77!
        Me.line19.X2 = 6.15!
        Me.line19.Y1 = 1.5!
        Me.line19.Y2 = 1.5!
        '
        'line20
        '
        Me.line20.Height = 0.0!
        Me.line20.Left = 5.77!
        Me.line20.LineWeight = 1.0!
        Me.line20.Name = "line20"
        Me.line20.Top = 1.2!
        Me.line20.Width = 0.3800001!
        Me.line20.X1 = 5.77!
        Me.line20.X2 = 6.15!
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
        Me.line21.Width = 0.3800001!
        Me.line21.X1 = 5.77!
        Me.line21.X2 = 6.15!
        Me.line21.Y1 = 1.05!
        Me.line21.Y2 = 1.05!
        '
        'line23
        '
        Me.line23.Height = 0.0!
        Me.line23.Left = 6.2!
        Me.line23.LineWeight = 1.0!
        Me.line23.Name = "line23"
        Me.line23.Top = 1.2!
        Me.line23.Width = 5.400001!
        Me.line23.X1 = 6.2!
        Me.line23.X2 = 11.6!
        Me.line23.Y1 = 1.2!
        Me.line23.Y2 = 1.2!
        '
        'line24
        '
        Me.line24.Height = 0.0!
        Me.line24.Left = 6.2!
        Me.line24.LineWeight = 1.0!
        Me.line24.Name = "line24"
        Me.line24.Top = 1.05!
        Me.line24.Width = 5.400001!
        Me.line24.X1 = 6.2!
        Me.line24.X2 = 11.6!
        Me.line24.Y1 = 1.05!
        Me.line24.Y2 = 1.05!
        '
        'line6
        '
        Me.line6.Height = 0.0!
        Me.line6.Left = 6.2!
        Me.line6.LineWeight = 1.0!
        Me.line6.Name = "line6"
        Me.line6.Top = 1.5!
        Me.line6.Width = 5.400001!
        Me.line6.X1 = 6.2!
        Me.line6.X2 = 11.6!
        Me.line6.Y1 = 1.5!
        Me.line6.Y2 = 1.5!
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtMechEquipC, Me.txtAddress, Me.txtDivision2, Me.txtFileNo, Me.txtInspectionDate, Me.txtCity, Me.txtSTProv, Me.txtCountry, Me.txtTIV, Me.txtSpecificGroup, Me.txtMajorGroup, Me.txtMechPreMaintAdequacy, Me.txtMechPreMaintVibe, Me.txtMechPreMaintLubeOil, Me.txtMechPreMaintNDE, Me.txtMechPreMaintOverspeed, Me.txtMechPreMaintAlign, Me.txtMechPreMaintOther, Me.txtFacility, Me.txtClientLocNo, Me.txtMechPreMaintVisual, Me.line42, Me.line56, Me.line57, Me.line58, Me.line59, Me.line60, Me.line61, Me.line62, Me.line63, Me.line64, Me.line65, Me.line67, Me.line68, Me.line69, Me.line70, Me.line71, Me.line72})
        Me.Detail1.Height = 0.35!
        Me.Detail1.KeepTogether = True
        Me.Detail1.Name = "Detail1"
        '
        'txtMechEquipC
        '
        Me.txtMechEquipC.DataField = "MechEquipC"
        Me.txtMechEquipC.Height = 0.3!
        Me.txtMechEquipC.Left = 5.77!
        Me.txtMechEquipC.Name = "txtMechEquipC"
        Me.txtMechEquipC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtMechEquipC.Text = "MechEquipC"
        Me.txtMechEquipC.Top = 0.05!
        Me.txtMechEquipC.Width = 0.38!
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
        'txtMechPreMaintAdequacy
        '
        Me.txtMechPreMaintAdequacy.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMechPreMaintAdequacy.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMechPreMaintAdequacy.DataField = "MechPreMaintAdequacy"
        Me.txtMechPreMaintAdequacy.Height = 0.3!
        Me.txtMechPreMaintAdequacy.Left = 6.2!
        Me.txtMechPreMaintAdequacy.Name = "txtMechPreMaintAdequacy"
        Me.txtMechPreMaintAdequacy.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtMechPreMaintAdequacy.Text = "MechPreMaintAdequacy"
        Me.txtMechPreMaintAdequacy.Top = 0.05!
        Me.txtMechPreMaintAdequacy.Width = 0.6800003!
        '
        'txtMechPreMaintVibe
        '
        Me.txtMechPreMaintVibe.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMechPreMaintVibe.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMechPreMaintVibe.DataField = "MechPreMaintVibe"
        Me.txtMechPreMaintVibe.Height = 0.3!
        Me.txtMechPreMaintVibe.Left = 6.880001!
        Me.txtMechPreMaintVibe.Name = "txtMechPreMaintVibe"
        Me.txtMechPreMaintVibe.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtMechPreMaintVibe.Text = "MechPreMaintVibe"
        Me.txtMechPreMaintVibe.Top = 0.05!
        Me.txtMechPreMaintVibe.Width = 0.65!
        '
        'txtMechPreMaintLubeOil
        '
        Me.txtMechPreMaintLubeOil.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMechPreMaintLubeOil.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMechPreMaintLubeOil.DataField = "MechPreMaintLubeOil"
        Me.txtMechPreMaintLubeOil.Height = 0.3!
        Me.txtMechPreMaintLubeOil.Left = 7.530001!
        Me.txtMechPreMaintLubeOil.Name = "txtMechPreMaintLubeOil"
        Me.txtMechPreMaintLubeOil.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtMechPreMaintLubeOil.Text = "MechPreMaintLubeOil"
        Me.txtMechPreMaintLubeOil.Top = 0.05!
        Me.txtMechPreMaintLubeOil.Width = 0.65!
        '
        'txtMechPreMaintNDE
        '
        Me.txtMechPreMaintNDE.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMechPreMaintNDE.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMechPreMaintNDE.DataField = "MechPreMaintNDE"
        Me.txtMechPreMaintNDE.Height = 0.3!
        Me.txtMechPreMaintNDE.Left = 8.179996!
        Me.txtMechPreMaintNDE.Name = "txtMechPreMaintNDE"
        Me.txtMechPreMaintNDE.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtMechPreMaintNDE.Text = "MechPreMaintNDE"
        Me.txtMechPreMaintNDE.Top = 0.05!
        Me.txtMechPreMaintNDE.Width = 0.65!
        '
        'txtMechPreMaintOverspeed
        '
        Me.txtMechPreMaintOverspeed.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMechPreMaintOverspeed.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMechPreMaintOverspeed.DataField = "MechPreMaintOverspeed"
        Me.txtMechPreMaintOverspeed.Height = 0.3!
        Me.txtMechPreMaintOverspeed.Left = 8.829996!
        Me.txtMechPreMaintOverspeed.Name = "txtMechPreMaintOverspeed"
        Me.txtMechPreMaintOverspeed.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtMechPreMaintOverspeed.Text = "MechPreMaintOverspeed"
        Me.txtMechPreMaintOverspeed.Top = 0.05!
        Me.txtMechPreMaintOverspeed.Width = 0.65!
        '
        'txtMechPreMaintAlign
        '
        Me.txtMechPreMaintAlign.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMechPreMaintAlign.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMechPreMaintAlign.DataField = "MechPreMaintAlign"
        Me.txtMechPreMaintAlign.Height = 0.3!
        Me.txtMechPreMaintAlign.Left = 10.13!
        Me.txtMechPreMaintAlign.Name = "txtMechPreMaintAlign"
        Me.txtMechPreMaintAlign.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtMechPreMaintAlign.Text = "MechPreMaintAlign"
        Me.txtMechPreMaintAlign.Top = 0.05!
        Me.txtMechPreMaintAlign.Width = 0.7200054!
        '
        'txtMechPreMaintOther
        '
        Me.txtMechPreMaintOther.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMechPreMaintOther.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMechPreMaintOther.DataField = "MechPreMaintOther"
        Me.txtMechPreMaintOther.Height = 0.3!
        Me.txtMechPreMaintOther.Left = 10.85!
        Me.txtMechPreMaintOther.Name = "txtMechPreMaintOther"
        Me.txtMechPreMaintOther.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtMechPreMaintOther.Text = "MechPreMaintOther"
        Me.txtMechPreMaintOther.Top = 0.05!
        Me.txtMechPreMaintOther.Width = 0.7500004!
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
        'txtMechPreMaintVisual
        '
        Me.txtMechPreMaintVisual.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMechPreMaintVisual.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMechPreMaintVisual.DataField = "MechPreMaintVisual"
        Me.txtMechPreMaintVisual.Height = 0.3!
        Me.txtMechPreMaintVisual.Left = 9.479996!
        Me.txtMechPreMaintVisual.Name = "txtMechPreMaintVisual"
        Me.txtMechPreMaintVisual.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtMechPreMaintVisual.Text = "MechPreMaintVisual"
        Me.txtMechPreMaintVisual.Top = 0.05!
        Me.txtMechPreMaintVisual.Width = 0.65!
        '
        'line42
        '
        Me.line42.Height = 0.3!
        Me.line42.Left = 11.6!
        Me.line42.LineWeight = 1.0!
        Me.line42.Name = "line42"
        Me.line42.Top = 0.05!
        Me.line42.Width = 0.0!
        Me.line42.X1 = 11.6!
        Me.line42.X2 = 11.6!
        Me.line42.Y1 = 0.05!
        Me.line42.Y2 = 0.35!
        '
        'line56
        '
        Me.line56.Height = 0.3!
        Me.line56.Left = 6.2!
        Me.line56.LineWeight = 1.0!
        Me.line56.Name = "line56"
        Me.line56.Top = 0.05!
        Me.line56.Width = 0.0!
        Me.line56.X1 = 6.2!
        Me.line56.X2 = 6.2!
        Me.line56.Y1 = 0.05!
        Me.line56.Y2 = 0.35!
        '
        'line57
        '
        Me.line57.Height = 0.3!
        Me.line57.Left = 6.15!
        Me.line57.LineWeight = 1.0!
        Me.line57.Name = "line57"
        Me.line57.Top = 0.05!
        Me.line57.Width = 0.0!
        Me.line57.X1 = 6.15!
        Me.line57.X2 = 6.15!
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
        Me.line68.Width = 0.3800001!
        Me.line68.X1 = 5.77!
        Me.line68.X2 = 6.15!
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
        Me.line70.Width = 0.3800001!
        Me.line70.X1 = 5.77!
        Me.line70.X2 = 6.15!
        Me.line70.Y1 = 0.35!
        Me.line70.Y2 = 0.35!
        '
        'line71
        '
        Me.line71.Height = 0.0!
        Me.line71.Left = 6.2!
        Me.line71.LineWeight = 1.0!
        Me.line71.Name = "line71"
        Me.line71.Top = 0.05!
        Me.line71.Width = 5.400001!
        Me.line71.X1 = 6.2!
        Me.line71.X2 = 11.6!
        Me.line71.Y1 = 0.05!
        Me.line71.Y2 = 0.05!
        '
        'line72
        '
        Me.line72.Height = 0.0!
        Me.line72.Left = 6.2!
        Me.line72.LineWeight = 1.0!
        Me.line72.Name = "line72"
        Me.line72.Top = 0.35!
        Me.line72.Width = 5.400001!
        Me.line72.X1 = 6.2!
        Me.line72.X2 = 11.6!
        Me.line72.Y1 = 0.35!
        Me.line72.Y2 = 0.35!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtSort, Me.lblReportDate, Me.reportInfo1, Me.txtDisclaimer})
        Me.PageFooter1.Height = 0.4958334!
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
        Me.txtSort.Width = 11.6!
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
        Me.reportInfo1.Left = 9.625!
        Me.reportInfo1.Name = "reportInfo1"
        Me.reportInfo1.Style = "font-size: 7pt; font-style: italic; text-align: right; vertical-align: middle"
        Me.reportInfo1.Top = 0.312!
        Me.reportInfo1.Width = 2.0!
        '
        'txtDisclaimer
        '
        Me.txtDisclaimer.Height = 0.15!
        Me.txtDisclaimer.HyperLink = Nothing
        Me.txtDisclaimer.Left = 0.0!
        Me.txtDisclaimer.Name = "txtDisclaimer"
        Me.txtDisclaimer.Style = "font-size: 7pt; font-style: italic; text-align: center; vertical-align: middle"
        Me.txtDisclaimer.Text = ""
        Me.txtDisclaimer.Top = 0.125!
        Me.txtDisclaimer.Width = 11.6!
        '
        'rptBMMechMaintenanceSummary
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.25!
        Me.PageSettings.Margins.Left = 1.2!
        Me.PageSettings.Margins.Right = 1.2!
        Me.PageSettings.Margins.Top = 0.25!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 14.0!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Legal
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 11.63125!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Calibri; font-style: normal; text-decoration: none; font-weight: nor" & _
            "mal; font-size: 10pt; color: Black", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
            "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.lblRating, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.lblMechEquipC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMechPreMaintAdequacy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMechPreMaintVibe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMechPreMaintNDE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMechPreMaintOverspeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMechPreMaintVisual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMechPreMaintAlign, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblClientLocNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFacility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMechPreMaintLubeOil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMechPreMaintOther, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMechEquipC, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.txtMechPreMaintAdequacy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMechPreMaintVibe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMechPreMaintLubeOil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMechPreMaintNDE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMechPreMaintOverspeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMechPreMaintAlign, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMechPreMaintOther, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFacility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientLocNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMechPreMaintVisual, System.ComponentModel.ISupportInitialize).EndInit()
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

    Private Sub rptBMMechMaintenanceSummary_FetchData(ByVal sender As Object, ByVal eArgs As FetchEventArgs) Handles Me.FetchData
        lblTIVGrid.Text = "TIV " & rptProperties.Currency.colFldCode & vbLf & "(millions)" '.TIVCurrency(AppSession.Currency)"

        Dim zTextControls() As ARControl = {txtMechEquipC, txtMechPreMaintAdequacy, txtMechPreMaintVisual, txtMechPreMaintVibe, txtMechPreMaintLubeOil, txtMechPreMaintNDE, txtMechPreMaintOverspeed, txtMechPreMaintAlign, txtMechPreMaintOther}
        UtilReport.ActiveReport.SetItemBackColorByText(Me, zTextControls, rptProperties)

        Dim zRatingControls() As ARControl = {txtMechEquipC}
        UtilReport.ActiveReport.SetItemBackColorByRating(Me, zRatingControls, rptProperties)

    End Sub

    Private Sub rptBMMechMaintenanceSummary_ReportStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportStart
        lblClientName.Text = rptProperties.ClientName ' AppSession.ClientName
        lblReportDate.Text = Now 'modActiveReport.ReportDate
    End Sub

    Private Sub rptBMMechMaintenanceSummary_PageStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.PageStart

        UtilReport.ActiveReport.SetFilter(Me, rptProperties)
        UtilReport.ActiveReport.SetSort(Me, rptProperties)
        UtilReport.ActiveReport.SetDisclaimer(Me, rptProperties)

    End Sub

    Private Sub rptBMMechMaintenanceSummary_ReportEnd(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportEnd
        DisposeParameters()
    End Sub

    Private Sub DisposeParameters()
        DataSource = Nothing
    End Sub

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties
End Class
