Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports

Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing

Public Class rptFireLossEstimatesByLocation
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
    Private WithEvents picture1 As GrapeCity.ActiveReports.SectionReportModel.Picture
    Private WithEvents lblClientName As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents line3 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line4 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lblPMLpd As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblPMLbi As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblPMLTotal As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblMFLpd As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblMFLbi As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblMFLTotal As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents line8 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtAPLpd As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtPMLpd As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtAPLTotal As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtPMLbi As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtMFLpd As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtAPLbi As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtMFLbi As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtMFLTotal As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtPMLTotal As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblReportDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtSort As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents reportInfo1 As GrapeCity.ActiveReports.SectionReportModel.ReportInfo
    Private WithEvents txtFilters As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents textBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSurveyDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtClientLocNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents textBox2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents textBox3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents textBox4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtTIV As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents textBox6 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFacility As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtDivision2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblLocationInformation As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFileNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblDivision2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblInspectionDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblClientLocNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFacility As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCity As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents textBox7 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents textBox8 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblTIVGrid As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblAddress As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents line56 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line57 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line1 As GrapeCity.ActiveReports.SectionReportModel.Line
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
    Private WithEvents lblFilters As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblAPLpd As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblAPLbi As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblAPLTotal As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents line2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line5 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line6 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line9 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtDisclaimer As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtBIReporting As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtIBI As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblIBI As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCurrency As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblIBIPlaceholder As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtIBIPlaceholder As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents PageFooter1 As GrapeCity.ActiveReports.SectionReportModel.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptFireLossEstimatesByLocation))
        Me.PageHeader1 = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.lblIBI = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblMFLpd = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.picture1 = New GrapeCity.ActiveReports.SectionReportModel.Picture()
        Me.lblClientName = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblAPLpd = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblAPLbi = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblAPLTotal = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPMLpd = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPMLbi = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPMLTotal = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblMFLbi = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblMFLTotal = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtFilters = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblFilters = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblLocationInformation = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFileNo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblDivision2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblInspectionDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblClientLocNo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFacility = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblCity = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.textBox7 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.textBox8 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblTIVGrid = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblAddress = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.line56 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line57 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line5 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line6 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line9 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line10 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line11 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line12 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line13 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line14 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line15 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line16 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lblCurrency = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Detail1 = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.txtMFLpd = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtAPLpd = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPMLpd = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtAPLTotal = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPMLbi = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtAPLbi = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMFLbi = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMFLTotal = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPMLTotal = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.textBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSurveyDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtClientLocNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.textBox2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.textBox3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.textBox4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtTIV = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.textBox6 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFacility = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtDivision2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.line8 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line17 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line18 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line19 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line20 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line21 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line22 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line23 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line24 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line25 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line26 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line27 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line28 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line29 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtBIReporting = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtIBI = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.line31 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line30 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.PageFooter1 = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.lblReportDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtSort = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.reportInfo1 = New GrapeCity.ActiveReports.SectionReportModel.ReportInfo()
        Me.txtDisclaimer = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblIBIPlaceholder = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtIBIPlaceholder = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        CType(Me.lblIBI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMFLpd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblClientName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAPLpd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAPLbi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAPLTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPMLpd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPMLbi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPMLTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMFLbi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMFLTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblLocationInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFileNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDivision2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblInspectionDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblClientLocNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFacility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTIVGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMFLpd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAPLpd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPMLpd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAPLTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPMLbi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAPLbi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMFLbi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMFLTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPMLTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSurveyDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientLocNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTIV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFacility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDivision2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBIReporting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIBI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblReportDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisclaimer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblIBIPlaceholder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIBIPlaceholder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.CanShrink = True
        Me.PageHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblIBI, Me.lblMFLpd, Me.picture1, Me.lblClientName, Me.label3, Me.lblAPLpd, Me.lblAPLbi, Me.lblAPLTotal, Me.lblPMLpd, Me.lblPMLbi, Me.lblPMLTotal, Me.lblMFLbi, Me.lblMFLTotal, Me.txtFilters, Me.lblFilters, Me.lblLocationInformation, Me.lblFileNo, Me.lblDivision2, Me.lblInspectionDate, Me.lblClientLocNo, Me.lblFacility, Me.lblCity, Me.textBox7, Me.textBox8, Me.lblTIVGrid, Me.lblAddress, Me.line56, Me.line57, Me.line3, Me.line1, Me.line2, Me.line5, Me.line6, Me.line9, Me.line10, Me.line11, Me.line12, Me.line14, Me.line15, Me.line16, Me.line4, Me.lblCurrency, Me.lblIBIPlaceholder, Me.line13})
        Me.PageHeader1.Height = 1.808944!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'lblIBI
        '
        Me.lblIBI.Height = 0.1500001!
        Me.lblIBI.HyperLink = Nothing
        Me.lblIBI.Left = 8.201!
        Me.lblIBI.Name = "lblIBI"
        Me.lblIBI.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: right; ve" & _
    "rtical-align: middle"
        Me.lblIBI.Text = "IBI"
        Me.lblIBI.Top = 1.65!
        Me.lblIBI.Visible = False
        Me.lblIBI.Width = 1.789!
        '
        'lblMFLpd
        '
        Me.lblMFLpd.Height = 0.15!
        Me.lblMFLpd.HyperLink = Nothing
        Me.lblMFLpd.Left = 8.201!
        Me.lblMFLpd.Name = "lblMFLpd"
        Me.lblMFLpd.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: right; ve" & _
    "rtical-align: middle"
        Me.lblMFLpd.Text = "MFL (PD)"
        Me.lblMFLpd.Top = 1.2!
        Me.lblMFLpd.Width = 1.789!
        '
        'picture1
        '
        Me.picture1.Height = 0.5!
        Me.picture1.ImageData = CType(resources.GetObject("picture1.ImageData"), System.IO.Stream)
        Me.picture1.Left = 0.0!
        Me.picture1.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.picture1.Name = "picture1"
        Me.picture1.PictureAlignment = GrapeCity.ActiveReports.SectionReportModel.PictureAlignment.TopLeft
        Me.picture1.SizeMode = GrapeCity.ActiveReports.SectionReportModel.SizeModes.Stretch
        Me.picture1.Top = 0.0!
        Me.picture1.Width = 3.0!
        '
        'lblClientName
        '
        Me.lblClientName.Height = 0.25!
        Me.lblClientName.HyperLink = Nothing
        Me.lblClientName.Left = 3.062!
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Style = "color: #C6D1DE; font-size: 16pt; font-style: italic; font-weight: bold; text-alig" & _
    "n: right; vertical-align: middle"
        Me.lblClientName.Text = "Company Name"
        Me.lblClientName.Top = 0.05!
        Me.lblClientName.Width = 6.878!
        '
        'label3
        '
        Me.label3.Height = 0.25!
        Me.label3.HyperLink = Nothing
        Me.label3.Left = 5.64!
        Me.label3.Name = "label3"
        Me.label3.Style = "font-size: 12pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.label3.Text = "Fire Loss Estimates By Location"
        Me.label3.Top = 0.35!
        Me.label3.Width = 4.3!
        '
        'lblAPLpd
        '
        Me.lblAPLpd.Height = 0.15!
        Me.lblAPLpd.HyperLink = Nothing
        Me.lblAPLpd.Left = 4.42!
        Me.lblAPLpd.Name = "lblAPLpd"
        Me.lblAPLpd.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: right; ve" & _
    "rtical-align: middle"
        Me.lblAPLpd.Text = "APL (PD)"
        Me.lblAPLpd.Top = 1.2!
        Me.lblAPLpd.Width = 1.83!
        '
        'lblAPLbi
        '
        Me.lblAPLbi.Height = 0.15!
        Me.lblAPLbi.HyperLink = Nothing
        Me.lblAPLbi.Left = 4.42!
        Me.lblAPLbi.Name = "lblAPLbi"
        Me.lblAPLbi.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: right; ve" & _
    "rtical-align: middle"
        Me.lblAPLbi.Text = "APL (BI)"
        Me.lblAPLbi.Top = 1.35!
        Me.lblAPLbi.Width = 1.83!
        '
        'lblAPLTotal
        '
        Me.lblAPLTotal.Height = 0.15!
        Me.lblAPLTotal.HyperLink = Nothing
        Me.lblAPLTotal.Left = 4.42!
        Me.lblAPLTotal.Name = "lblAPLTotal"
        Me.lblAPLTotal.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: right; ve" & _
    "rtical-align: middle"
        Me.lblAPLTotal.Text = "APL (Total)"
        Me.lblAPLTotal.Top = 1.5!
        Me.lblAPLTotal.Width = 1.83!
        '
        'lblPMLpd
        '
        Me.lblPMLpd.Height = 0.15!
        Me.lblPMLpd.HyperLink = Nothing
        Me.lblPMLpd.Left = 6.3!
        Me.lblPMLpd.Name = "lblPMLpd"
        Me.lblPMLpd.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: right; ve" & _
    "rtical-align: middle"
        Me.lblPMLpd.Text = "PML (PD)"
        Me.lblPMLpd.Top = 1.2!
        Me.lblPMLpd.Width = 1.808999!
        '
        'lblPMLbi
        '
        Me.lblPMLbi.Height = 0.15!
        Me.lblPMLbi.HyperLink = Nothing
        Me.lblPMLbi.Left = 6.3!
        Me.lblPMLbi.Name = "lblPMLbi"
        Me.lblPMLbi.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: right; ve" & _
    "rtical-align: middle"
        Me.lblPMLbi.Text = "PML (BI)"
        Me.lblPMLbi.Top = 1.35!
        Me.lblPMLbi.Width = 1.808999!
        '
        'lblPMLTotal
        '
        Me.lblPMLTotal.Height = 0.15!
        Me.lblPMLTotal.HyperLink = Nothing
        Me.lblPMLTotal.Left = 6.3!
        Me.lblPMLTotal.Name = "lblPMLTotal"
        Me.lblPMLTotal.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: right; ve" & _
    "rtical-align: middle"
        Me.lblPMLTotal.Text = "PML (Total)"
        Me.lblPMLTotal.Top = 1.5!
        Me.lblPMLTotal.Width = 1.808999!
        '
        'lblMFLbi
        '
        Me.lblMFLbi.Height = 0.15!
        Me.lblMFLbi.HyperLink = Nothing
        Me.lblMFLbi.Left = 8.201!
        Me.lblMFLbi.Name = "lblMFLbi"
        Me.lblMFLbi.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: right; ve" & _
    "rtical-align: middle"
        Me.lblMFLbi.Text = "MFL (BI)"
        Me.lblMFLbi.Top = 1.35!
        Me.lblMFLbi.Width = 1.789!
        '
        'lblMFLTotal
        '
        Me.lblMFLTotal.Height = 0.1500001!
        Me.lblMFLTotal.HyperLink = Nothing
        Me.lblMFLTotal.Left = 8.201!
        Me.lblMFLTotal.Name = "lblMFLTotal"
        Me.lblMFLTotal.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: right; ve" & _
    "rtical-align: middle"
        Me.lblMFLTotal.Text = "MFL (Total)"
        Me.lblMFLTotal.Top = 1.5!
        Me.lblMFLTotal.Width = 1.789!
        '
        'txtFilters
        '
        Me.txtFilters.CanShrink = True
        Me.txtFilters.Height = 0.15!
        Me.txtFilters.Left = 0.45!
        Me.txtFilters.Name = "txtFilters"
        Me.txtFilters.Style = "background-color: White; font-size: 8pt; vertical-align: middle"
        Me.txtFilters.Text = Nothing
        Me.txtFilters.Top = 0.85!
        Me.txtFilters.Width = 9.5!
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
        'lblLocationInformation
        '
        Me.lblLocationInformation.Height = 0.15!
        Me.lblLocationInformation.HyperLink = Nothing
        Me.lblLocationInformation.Left = 0.0!
        Me.lblLocationInformation.Name = "lblLocationInformation"
        Me.lblLocationInformation.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblLocationInformation.Text = "Location Detail"
        Me.lblLocationInformation.Top = 1.2!
        Me.lblLocationInformation.Width = 4.37!
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
        Me.lblDivision2.Top = 1.5!
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
        Me.lblInspectionDate.Top = 1.35!
        Me.lblInspectionDate.Width = 0.58!
        '
        'lblClientLocNo
        '
        Me.lblClientLocNo.Height = 0.1458!
        Me.lblClientLocNo.HyperLink = Nothing
        Me.lblClientLocNo.Left = 1.1!
        Me.lblClientLocNo.Name = "lblClientLocNo"
        Me.lblClientLocNo.Style = "background-color: White; font-size: 7pt"
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
        'textBox7
        '
        Me.textBox7.Height = 0.15!
        Me.textBox7.Left = 2.85!
        Me.textBox7.Name = "textBox7"
        Me.textBox7.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.textBox7.Text = "St/Pr"
        Me.textBox7.Top = 1.35!
        Me.textBox7.Width = 0.35!
        '
        'textBox8
        '
        Me.textBox8.Height = 0.15!
        Me.textBox8.Left = 3.2!
        Me.textBox8.Name = "textBox8"
        Me.textBox8.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.textBox8.Text = "Country"
        Me.textBox8.Top = 1.35!
        Me.textBox8.Width = 0.75!
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
        'line56
        '
        Me.line56.Height = 0.0!
        Me.line56.Left = 0.0!
        Me.line56.LineWeight = 1.0!
        Me.line56.Name = "line56"
        Me.line56.Top = 1.2!
        Me.line56.Width = 4.37!
        Me.line56.X1 = 0.0!
        Me.line56.X2 = 4.37!
        Me.line56.Y1 = 1.2!
        Me.line56.Y2 = 1.2!
        '
        'line57
        '
        Me.line57.Height = 0.0!
        Me.line57.Left = 0.0!
        Me.line57.LineWeight = 1.0!
        Me.line57.Name = "line57"
        Me.line57.Top = 1.8!
        Me.line57.Width = 4.37!
        Me.line57.X1 = 0.0!
        Me.line57.X2 = 4.37!
        Me.line57.Y1 = 1.8!
        Me.line57.Y2 = 1.8!
        '
        'line3
        '
        Me.line3.Height = 0.602!
        Me.line3.Left = 0.0!
        Me.line3.LineWeight = 1.0!
        Me.line3.Name = "line3"
        Me.line3.Top = 1.2!
        Me.line3.Width = 0.0!
        Me.line3.X1 = 0.0!
        Me.line3.X2 = 0.0!
        Me.line3.Y1 = 1.2!
        Me.line3.Y2 = 1.802!
        '
        'line1
        '
        Me.line1.Height = 0.5999999!
        Me.line1.Left = 4.37!
        Me.line1.LineWeight = 1.0!
        Me.line1.Name = "line1"
        Me.line1.Top = 1.2!
        Me.line1.Width = 0.0!
        Me.line1.X1 = 4.37!
        Me.line1.X2 = 4.37!
        Me.line1.Y1 = 1.2!
        Me.line1.Y2 = 1.8!
        '
        'line2
        '
        Me.line2.Height = 0.5999999!
        Me.line2.Left = 4.42!
        Me.line2.LineWeight = 1.0!
        Me.line2.Name = "line2"
        Me.line2.Top = 1.2!
        Me.line2.Width = 0.0!
        Me.line2.X1 = 4.42!
        Me.line2.X2 = 4.42!
        Me.line2.Y1 = 1.2!
        Me.line2.Y2 = 1.8!
        '
        'line5
        '
        Me.line5.Height = 0.0!
        Me.line5.Left = 4.42!
        Me.line5.LineWeight = 1.0!
        Me.line5.Name = "line5"
        Me.line5.Top = 1.2!
        Me.line5.Width = 1.83!
        Me.line5.X1 = 4.42!
        Me.line5.X2 = 6.25!
        Me.line5.Y1 = 1.2!
        Me.line5.Y2 = 1.2!
        '
        'line6
        '
        Me.line6.Height = 0.0!
        Me.line6.Left = 4.42!
        Me.line6.LineWeight = 1.0!
        Me.line6.Name = "line6"
        Me.line6.Top = 1.8!
        Me.line6.Width = 1.83!
        Me.line6.X1 = 4.42!
        Me.line6.X2 = 6.25!
        Me.line6.Y1 = 1.8!
        Me.line6.Y2 = 1.8!
        '
        'line9
        '
        Me.line9.Height = 0.5999999!
        Me.line9.Left = 6.25!
        Me.line9.LineWeight = 1.0!
        Me.line9.Name = "line9"
        Me.line9.Top = 1.2!
        Me.line9.Width = 0.0!
        Me.line9.X1 = 6.25!
        Me.line9.X2 = 6.25!
        Me.line9.Y1 = 1.2!
        Me.line9.Y2 = 1.8!
        '
        'line10
        '
        Me.line10.Height = 0.5999999!
        Me.line10.Left = 6.3!
        Me.line10.LineWeight = 1.0!
        Me.line10.Name = "line10"
        Me.line10.Top = 1.2!
        Me.line10.Width = 0.0!
        Me.line10.X1 = 6.3!
        Me.line10.X2 = 6.3!
        Me.line10.Y1 = 1.2!
        Me.line10.Y2 = 1.8!
        '
        'line11
        '
        Me.line11.Height = 0.0!
        Me.line11.Left = 6.3!
        Me.line11.LineWeight = 1.0!
        Me.line11.Name = "line11"
        Me.line11.Top = 1.2!
        Me.line11.Width = 1.83!
        Me.line11.X1 = 6.3!
        Me.line11.X2 = 8.13!
        Me.line11.Y1 = 1.2!
        Me.line11.Y2 = 1.2!
        '
        'line12
        '
        Me.line12.Height = 0.0!
        Me.line12.Left = 6.3!
        Me.line12.LineWeight = 1.0!
        Me.line12.Name = "line12"
        Me.line12.Top = 1.8!
        Me.line12.Width = 1.83!
        Me.line12.X1 = 6.3!
        Me.line12.X2 = 8.13!
        Me.line12.Y1 = 1.8!
        Me.line12.Y2 = 1.8!
        '
        'line13
        '
        Me.line13.Height = 0.5999999!
        Me.line13.Left = 8.13!
        Me.line13.LineWeight = 1.0!
        Me.line13.Name = "line13"
        Me.line13.Top = 1.2!
        Me.line13.Width = 0.0!
        Me.line13.X1 = 8.13!
        Me.line13.X2 = 8.13!
        Me.line13.Y1 = 1.2!
        Me.line13.Y2 = 1.8!
        '
        'line14
        '
        Me.line14.Height = 0.5999999!
        Me.line14.Left = 8.18!
        Me.line14.LineWeight = 1.0!
        Me.line14.Name = "line14"
        Me.line14.Top = 1.2!
        Me.line14.Width = 0.0!
        Me.line14.X1 = 8.18!
        Me.line14.X2 = 8.18!
        Me.line14.Y1 = 1.2!
        Me.line14.Y2 = 1.8!
        '
        'line15
        '
        Me.line15.Height = 0.0!
        Me.line15.Left = 8.18!
        Me.line15.LineWeight = 1.0!
        Me.line15.Name = "line15"
        Me.line15.Top = 1.2!
        Me.line15.Width = 1.82!
        Me.line15.X1 = 8.18!
        Me.line15.X2 = 10.0!
        Me.line15.Y1 = 1.2!
        Me.line15.Y2 = 1.2!
        '
        'line16
        '
        Me.line16.Height = 0.0!
        Me.line16.Left = 8.18!
        Me.line16.LineWeight = 1.0!
        Me.line16.Name = "line16"
        Me.line16.Top = 1.8!
        Me.line16.Width = 1.82!
        Me.line16.X1 = 8.18!
        Me.line16.X2 = 10.0!
        Me.line16.Y1 = 1.8!
        Me.line16.Y2 = 1.8!
        '
        'line4
        '
        Me.line4.Height = 0.61!
        Me.line4.Left = 10.0!
        Me.line4.LineWeight = 1.0!
        Me.line4.Name = "line4"
        Me.line4.Top = 1.196!
        Me.line4.Width = 0.0!
        Me.line4.X1 = 10.0!
        Me.line4.X2 = 10.0!
        Me.line4.Y1 = 1.196!
        Me.line4.Y2 = 1.806!
        '
        'lblCurrency
        '
        Me.lblCurrency.Height = 0.15!
        Me.lblCurrency.Left = 4.42!
        Me.lblCurrency.Name = "lblCurrency"
        Me.lblCurrency.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblCurrency.Text = "Values in USD"
        Me.lblCurrency.Top = 1.02!
        Me.lblCurrency.Width = 5.58!
        '
        'Detail1
        '
        Me.Detail1.CanShrink = True
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtMFLpd, Me.txtAPLpd, Me.txtPMLpd, Me.txtAPLTotal, Me.txtPMLbi, Me.txtAPLbi, Me.txtMFLbi, Me.txtMFLTotal, Me.txtPMLTotal, Me.textBox1, Me.txtSurveyDate, Me.txtClientLocNo, Me.textBox2, Me.textBox3, Me.textBox4, Me.txtTIV, Me.textBox6, Me.txtFacility, Me.txtDivision2, Me.line8, Me.line17, Me.line18, Me.line19, Me.line20, Me.line21, Me.line22, Me.line23, Me.line24, Me.line25, Me.line26, Me.line27, Me.line28, Me.line29, Me.txtBIReporting, Me.txtIBI, Me.line31, Me.line30, Me.txtIBIPlaceholder})
        Me.Detail1.Height = 0.7047778!
        Me.Detail1.KeepTogether = True
        Me.Detail1.Name = "Detail1"
        '
        'txtMFLpd
        '
        Me.txtMFLpd.DataField = "MFLPD"
        Me.txtMFLpd.Height = 0.15!
        Me.txtMFLpd.Left = 8.201!
        Me.txtMFLpd.Name = "txtMFLpd"
        Me.txtMFLpd.OutputFormat = resources.GetString("txtMFLpd.OutputFormat")
        Me.txtMFLpd.Style = "background-color: White; font-size: 7pt; text-align: right; vertical-align: middl" & _
    "e"
        Me.txtMFLpd.Text = "MFL (PD)"
        Me.txtMFLpd.Top = 0.05!
        Me.txtMFLpd.Width = 1.789001!
        '
        'txtAPLpd
        '
        Me.txtAPLpd.DataField = "APLPD"
        Me.txtAPLpd.Height = 0.15!
        Me.txtAPLpd.Left = 4.42!
        Me.txtAPLpd.Name = "txtAPLpd"
        Me.txtAPLpd.OutputFormat = resources.GetString("txtAPLpd.OutputFormat")
        Me.txtAPLpd.Style = "background-color: White; font-size: 7pt; text-align: right; vertical-align: middl" & _
    "e"
        Me.txtAPLpd.Text = "APL (PD)"
        Me.txtAPLpd.Top = 0.05!
        Me.txtAPLpd.Width = 1.83!
        '
        'txtPMLpd
        '
        Me.txtPMLpd.DataField = "PMLPD"
        Me.txtPMLpd.Height = 0.15!
        Me.txtPMLpd.Left = 6.3!
        Me.txtPMLpd.Name = "txtPMLpd"
        Me.txtPMLpd.OutputFormat = resources.GetString("txtPMLpd.OutputFormat")
        Me.txtPMLpd.Style = "background-color: White; font-size: 7pt; text-align: right; vertical-align: middl" & _
    "e"
        Me.txtPMLpd.Text = "PML (PD)"
        Me.txtPMLpd.Top = 0.05!
        Me.txtPMLpd.Width = 1.809!
        '
        'txtAPLTotal
        '
        Me.txtAPLTotal.DataField = "APL"
        Me.txtAPLTotal.Height = 0.15!
        Me.txtAPLTotal.Left = 4.42!
        Me.txtAPLTotal.Name = "txtAPLTotal"
        Me.txtAPLTotal.OutputFormat = resources.GetString("txtAPLTotal.OutputFormat")
        Me.txtAPLTotal.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: right; ve" & _
    "rtical-align: middle"
        Me.txtAPLTotal.Text = "APL Total"
        Me.txtAPLTotal.Top = 0.35!
        Me.txtAPLTotal.Width = 1.83!
        '
        'txtPMLbi
        '
        Me.txtPMLbi.DataField = "PMLBI"
        Me.txtPMLbi.Height = 0.15!
        Me.txtPMLbi.Left = 6.3!
        Me.txtPMLbi.Name = "txtPMLbi"
        Me.txtPMLbi.OutputFormat = resources.GetString("txtPMLbi.OutputFormat")
        Me.txtPMLbi.Style = "background-color: White; font-size: 7pt; text-align: right; vertical-align: middl" & _
    "e"
        Me.txtPMLbi.Text = "PML (BI)"
        Me.txtPMLbi.Top = 0.2!
        Me.txtPMLbi.Width = 1.809!
        '
        'txtAPLbi
        '
        Me.txtAPLbi.DataField = "APLBI"
        Me.txtAPLbi.Height = 0.15!
        Me.txtAPLbi.Left = 4.42!
        Me.txtAPLbi.Name = "txtAPLbi"
        Me.txtAPLbi.OutputFormat = resources.GetString("txtAPLbi.OutputFormat")
        Me.txtAPLbi.Style = "background-color: White; font-size: 7pt; text-align: right; vertical-align: middl" & _
    "e"
        Me.txtAPLbi.Text = "APL (BI)"
        Me.txtAPLbi.Top = 0.2!
        Me.txtAPLbi.Width = 1.83!
        '
        'txtMFLbi
        '
        Me.txtMFLbi.DataField = "MFLBI"
        Me.txtMFLbi.Height = 0.15!
        Me.txtMFLbi.Left = 8.191001!
        Me.txtMFLbi.Name = "txtMFLbi"
        Me.txtMFLbi.OutputFormat = resources.GetString("txtMFLbi.OutputFormat")
        Me.txtMFLbi.Style = "background-color: White; font-size: 7pt; text-align: right; vertical-align: middl" & _
    "e"
        Me.txtMFLbi.Text = "MFL (BI)"
        Me.txtMFLbi.Top = 0.2!
        Me.txtMFLbi.Width = 1.799!
        '
        'txtMFLTotal
        '
        Me.txtMFLTotal.DataField = "MFL"
        Me.txtMFLTotal.Height = 0.15!
        Me.txtMFLTotal.Left = 8.191001!
        Me.txtMFLTotal.Name = "txtMFLTotal"
        Me.txtMFLTotal.OutputFormat = resources.GetString("txtMFLTotal.OutputFormat")
        Me.txtMFLTotal.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: right; ve" & _
    "rtical-align: middle"
        Me.txtMFLTotal.Text = "MFL Total"
        Me.txtMFLTotal.Top = 0.35!
        Me.txtMFLTotal.Width = 1.799!
        '
        'txtPMLTotal
        '
        Me.txtPMLTotal.DataField = "PML"
        Me.txtPMLTotal.Height = 0.15!
        Me.txtPMLTotal.Left = 6.31!
        Me.txtPMLTotal.Name = "txtPMLTotal"
        Me.txtPMLTotal.OutputFormat = resources.GetString("txtPMLTotal.OutputFormat")
        Me.txtPMLTotal.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: right; ve" & _
    "rtical-align: middle"
        Me.txtPMLTotal.Text = "PML Total"
        Me.txtPMLTotal.Top = 0.35!
        Me.txtPMLTotal.Width = 1.799!
        '
        'textBox1
        '
        Me.textBox1.CanGrow = False
        Me.textBox1.DataField = "FileNo"
        Me.textBox1.Height = 0.15!
        Me.textBox1.Left = 0.0!
        Me.textBox1.MultiLine = False
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.textBox1.Text = "File No."
        Me.textBox1.Top = 0.05!
        Me.textBox1.Width = 0.52!
        '
        'txtSurveyDate
        '
        Me.txtSurveyDate.CanGrow = False
        Me.txtSurveyDate.DataField = "InspectionDate"
        Me.txtSurveyDate.Height = 0.15!
        Me.txtSurveyDate.Left = 0.52!
        Me.txtSurveyDate.MultiLine = False
        Me.txtSurveyDate.Name = "txtSurveyDate"
        Me.txtSurveyDate.OutputFormat = resources.GetString("txtSurveyDate.OutputFormat")
        Me.txtSurveyDate.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.txtSurveyDate.Text = "Survey Date"
        Me.txtSurveyDate.Top = 0.05!
        Me.txtSurveyDate.Width = 0.58!
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
        'textBox2
        '
        Me.textBox2.CanGrow = False
        Me.textBox2.DataField = "City"
        Me.textBox2.Height = 0.15!
        Me.textBox2.Left = 1.9!
        Me.textBox2.MultiLine = False
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.textBox2.Text = "City"
        Me.textBox2.Top = 0.05!
        Me.textBox2.Width = 0.95!
        '
        'textBox3
        '
        Me.textBox3.CanGrow = False
        Me.textBox3.DataField = "StProv"
        Me.textBox3.Height = 0.15!
        Me.textBox3.Left = 2.85!
        Me.textBox3.MultiLine = False
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.textBox3.Text = "St/Pr"
        Me.textBox3.Top = 0.05!
        Me.textBox3.Width = 0.35!
        '
        'textBox4
        '
        Me.textBox4.CanGrow = False
        Me.textBox4.DataField = "Country"
        Me.textBox4.Height = 0.15!
        Me.textBox4.Left = 3.2!
        Me.textBox4.MultiLine = False
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.textBox4.Text = "Country"
        Me.textBox4.Top = 0.05!
        Me.textBox4.Width = 0.75!
        '
        'txtTIV
        '
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
        'textBox6
        '
        Me.textBox6.CanGrow = False
        Me.textBox6.DataField = "Address"
        Me.textBox6.Height = 0.15!
        Me.textBox6.Left = 1.9!
        Me.textBox6.MultiLine = False
        Me.textBox6.Name = "textBox6"
        Me.textBox6.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.textBox6.Text = "Address"
        Me.textBox6.Top = 0.2!
        Me.textBox6.Width = 2.47!
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
        'line8
        '
        Me.line8.Height = 0.627!
        Me.line8.Left = 0.0!
        Me.line8.LineWeight = 1.0!
        Me.line8.Name = "line8"
        Me.line8.Top = 0.05!
        Me.line8.Width = 0.0!
        Me.line8.X1 = 0.0!
        Me.line8.X2 = 0.0!
        Me.line8.Y1 = 0.05!
        Me.line8.Y2 = 0.677!
        '
        'line17
        '
        Me.line17.Height = 0.0!
        Me.line17.Left = 0.0!
        Me.line17.LineWeight = 1.0!
        Me.line17.Name = "line17"
        Me.line17.Top = 0.05!
        Me.line17.Width = 4.37!
        Me.line17.X1 = 0.0!
        Me.line17.X2 = 4.37!
        Me.line17.Y1 = 0.05!
        Me.line17.Y2 = 0.05!
        '
        'line18
        '
        Me.line18.Height = 0.0!
        Me.line18.Left = 0.0!
        Me.line18.LineWeight = 1.0!
        Me.line18.Name = "line18"
        Me.line18.Top = 0.677!
        Me.line18.Width = 4.37!
        Me.line18.X1 = 0.0!
        Me.line18.X2 = 4.37!
        Me.line18.Y1 = 0.677!
        Me.line18.Y2 = 0.677!
        '
        'line19
        '
        Me.line19.Height = 0.627!
        Me.line19.Left = 4.37!
        Me.line19.LineWeight = 1.0!
        Me.line19.Name = "line19"
        Me.line19.Top = 0.05!
        Me.line19.Width = 0.0!
        Me.line19.X1 = 4.37!
        Me.line19.X2 = 4.37!
        Me.line19.Y1 = 0.05!
        Me.line19.Y2 = 0.677!
        '
        'line20
        '
        Me.line20.Height = 0.627!
        Me.line20.Left = 4.42!
        Me.line20.LineWeight = 1.0!
        Me.line20.Name = "line20"
        Me.line20.Top = 0.05!
        Me.line20.Width = 0.0!
        Me.line20.X1 = 4.42!
        Me.line20.X2 = 4.42!
        Me.line20.Y1 = 0.05!
        Me.line20.Y2 = 0.677!
        '
        'line21
        '
        Me.line21.Height = 0.627!
        Me.line21.Left = 6.25!
        Me.line21.LineWeight = 1.0!
        Me.line21.Name = "line21"
        Me.line21.Top = 0.05!
        Me.line21.Width = 0.0!
        Me.line21.X1 = 6.25!
        Me.line21.X2 = 6.25!
        Me.line21.Y1 = 0.05!
        Me.line21.Y2 = 0.677!
        '
        'line22
        '
        Me.line22.Height = 0.0!
        Me.line22.Left = 4.42!
        Me.line22.LineWeight = 1.0!
        Me.line22.Name = "line22"
        Me.line22.Top = 0.05!
        Me.line22.Width = 1.83!
        Me.line22.X1 = 4.42!
        Me.line22.X2 = 6.25!
        Me.line22.Y1 = 0.05!
        Me.line22.Y2 = 0.05!
        '
        'line23
        '
        Me.line23.Height = 0.0!
        Me.line23.Left = 4.42!
        Me.line23.LineWeight = 1.0!
        Me.line23.Name = "line23"
        Me.line23.Top = 0.677!
        Me.line23.Width = 1.83!
        Me.line23.X1 = 4.42!
        Me.line23.X2 = 6.25!
        Me.line23.Y1 = 0.677!
        Me.line23.Y2 = 0.677!
        '
        'line24
        '
        Me.line24.Height = 0.627!
        Me.line24.Left = 6.3!
        Me.line24.LineWeight = 1.0!
        Me.line24.Name = "line24"
        Me.line24.Top = 0.05!
        Me.line24.Width = 0.0!
        Me.line24.X1 = 6.3!
        Me.line24.X2 = 6.3!
        Me.line24.Y1 = 0.05!
        Me.line24.Y2 = 0.677!
        '
        'line25
        '
        Me.line25.Height = 0.627!
        Me.line25.Left = 8.13!
        Me.line25.LineWeight = 1.0!
        Me.line25.Name = "line25"
        Me.line25.Top = 0.05!
        Me.line25.Width = 0.0!
        Me.line25.X1 = 8.13!
        Me.line25.X2 = 8.13!
        Me.line25.Y1 = 0.05!
        Me.line25.Y2 = 0.677!
        '
        'line26
        '
        Me.line26.Height = 0.0!
        Me.line26.Left = 6.3!
        Me.line26.LineWeight = 1.0!
        Me.line26.Name = "line26"
        Me.line26.Top = 0.05!
        Me.line26.Width = 1.83!
        Me.line26.X1 = 6.3!
        Me.line26.X2 = 8.13!
        Me.line26.Y1 = 0.05!
        Me.line26.Y2 = 0.05!
        '
        'line27
        '
        Me.line27.Height = 0.0!
        Me.line27.Left = 6.3!
        Me.line27.LineWeight = 1.0!
        Me.line27.Name = "line27"
        Me.line27.Top = 0.677!
        Me.line27.Width = 1.83!
        Me.line27.X1 = 6.3!
        Me.line27.X2 = 8.13!
        Me.line27.Y1 = 0.677!
        Me.line27.Y2 = 0.677!
        '
        'line28
        '
        Me.line28.Height = 0.0!
        Me.line28.Left = 8.18!
        Me.line28.LineWeight = 1.0!
        Me.line28.Name = "line28"
        Me.line28.Top = 0.05!
        Me.line28.Width = 1.82!
        Me.line28.X1 = 8.18!
        Me.line28.X2 = 10.0!
        Me.line28.Y1 = 0.05!
        Me.line28.Y2 = 0.05!
        '
        'line29
        '
        Me.line29.Height = 0.0!
        Me.line29.Left = 8.18!
        Me.line29.LineWeight = 1.0!
        Me.line29.Name = "line29"
        Me.line29.Top = 0.677!
        Me.line29.Width = 1.82!
        Me.line29.X1 = 8.18!
        Me.line29.X2 = 10.0!
        Me.line29.Y1 = 0.677!
        Me.line29.Y2 = 0.677!
        '
        'txtBIReporting
        '
        Me.txtBIReporting.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtBIReporting.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtBIReporting.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtBIReporting.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtBIReporting.DataField = "BIReporting"
        Me.txtBIReporting.Height = 0.137!
        Me.txtBIReporting.Left = 0.562!
        Me.txtBIReporting.MultiLine = False
        Me.txtBIReporting.Name = "txtBIReporting"
        Me.txtBIReporting.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtBIReporting.Text = "BIReporting"
        Me.txtBIReporting.Top = 0.312!
        Me.txtBIReporting.Visible = False
        Me.txtBIReporting.Width = 0.71!
        '
        'txtIBI
        '
        Me.txtIBI.DataField = "IBI"
        Me.txtIBI.Height = 0.15!
        Me.txtIBI.Left = 8.191001!
        Me.txtIBI.Name = "txtIBI"
        Me.txtIBI.OutputFormat = resources.GetString("txtIBI.OutputFormat")
        Me.txtIBI.Style = "background-color: White; font-size: 8pt; font-weight: normal; text-align: right; " & _
    "vertical-align: middle"
        Me.txtIBI.Text = "IBI"
        Me.txtIBI.Top = 0.5!
        Me.txtIBI.Visible = False
        Me.txtIBI.Width = 1.799!
        '
        'line31
        '
        Me.line31.Height = 0.627!
        Me.line31.Left = 10.0!
        Me.line31.LineWeight = 1.0!
        Me.line31.Name = "line31"
        Me.line31.Top = 0.05!
        Me.line31.Width = 0.0!
        Me.line31.X1 = 10.0!
        Me.line31.X2 = 10.0!
        Me.line31.Y1 = 0.05!
        Me.line31.Y2 = 0.677!
        '
        'line30
        '
        Me.line30.Height = 0.627!
        Me.line30.Left = 8.18!
        Me.line30.LineWeight = 1.0!
        Me.line30.Name = "line30"
        Me.line30.Top = 0.05!
        Me.line30.Width = 0.0!
        Me.line30.X1 = 8.18!
        Me.line30.X2 = 8.18!
        Me.line30.Y1 = 0.05!
        Me.line30.Y2 = 0.677!
        '
        'PageFooter1
        '
        Me.PageFooter1.CanShrink = True
        Me.PageFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblReportDate, Me.txtSort, Me.reportInfo1, Me.txtDisclaimer})
        Me.PageFooter1.Height = 0.475!
        Me.PageFooter1.Name = "PageFooter1"
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
        'txtSort
        '
        Me.txtSort.CanShrink = True
        Me.txtSort.Height = 0.15!
        Me.txtSort.Left = 0.0!
        Me.txtSort.Name = "txtSort"
        Me.txtSort.Style = "font-size: 7pt; font-style: italic; text-align: center; vertical-align: middle"
        Me.txtSort.Text = "Sort"
        Me.txtSort.Top = 0.0!
        Me.txtSort.Width = 10.0!
        '
        'reportInfo1
        '
        Me.reportInfo1.FormatString = "Page {PageNumber} of {PageCount}"
        Me.reportInfo1.Height = 0.15!
        Me.reportInfo1.Left = 8.0!
        Me.reportInfo1.Name = "reportInfo1"
        Me.reportInfo1.Style = "font-size: 7pt; font-style: italic; text-align: right; vertical-align: middle"
        Me.reportInfo1.Top = 0.3!
        Me.reportInfo1.Width = 2.0!
        '
        'txtDisclaimer
        '
        Me.txtDisclaimer.CanShrink = True
        Me.txtDisclaimer.Height = 0.15!
        Me.txtDisclaimer.Left = 0.0!
        Me.txtDisclaimer.Name = "txtDisclaimer"
        Me.txtDisclaimer.Style = "font-size: 7pt; font-style: italic; text-align: center; vertical-align: middle"
        Me.txtDisclaimer.Text = "Disclaimer"
        Me.txtDisclaimer.Top = 0.15!
        Me.txtDisclaimer.Width = 10.0!
        '
        'lblIBIPlaceholder
        '
        Me.lblIBIPlaceholder.Height = 0.1500001!
        Me.lblIBIPlaceholder.HyperLink = Nothing
        Me.lblIBIPlaceholder.Left = 6.31!
        Me.lblIBIPlaceholder.Name = "lblIBIPlaceholder"
        Me.lblIBIPlaceholder.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: right; ve" & _
    "rtical-align: middle"
        Me.lblIBIPlaceholder.Text = ""
        Me.lblIBIPlaceholder.Top = 1.649!
        Me.lblIBIPlaceholder.Visible = False
        Me.lblIBIPlaceholder.Width = 1.799!
        '
        'txtIBIPlaceholder
        '
        Me.txtIBIPlaceholder.Height = 0.15!
        Me.txtIBIPlaceholder.Left = 6.31!
        Me.txtIBIPlaceholder.Name = "txtIBIPlaceholder"
        Me.txtIBIPlaceholder.OutputFormat = resources.GetString("txtIBIPlaceholder.OutputFormat")
        Me.txtIBIPlaceholder.Style = "background-color: White; font-size: 8pt; font-weight: normal; text-align: right; " & _
    "vertical-align: middle"
        Me.txtIBIPlaceholder.Top = 0.496!
        Me.txtIBIPlaceholder.Visible = False
        Me.txtIBIPlaceholder.Width = 1.799!
        '
        'rptFireLossEstimatesByLocation
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.25!
        Me.PageSettings.Margins.Left = 0.5!
        Me.PageSettings.Margins.Right = 0.5!
        Me.PageSettings.Margins.Top = 0.25!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 10.007!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Calibri; font-style: normal; text-decoration: none; font-weight: nor" & _
            "mal; font-size: 10pt; color: Black", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
            "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.lblIBI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMFLpd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblClientName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAPLpd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAPLbi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAPLTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPMLpd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPMLbi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPMLTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMFLbi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMFLTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblLocationInformation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFileNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDivision2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblInspectionDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblClientLocNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFacility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTIVGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMFLpd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAPLpd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPMLpd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAPLTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPMLbi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAPLbi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMFLbi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMFLTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPMLTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSurveyDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientLocNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTIV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFacility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDivision2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBIReporting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIBI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblReportDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSort, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reportInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisclaimer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblIBIPlaceholder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIBIPlaceholder, System.ComponentModel.ISupportInitialize).EndInit()
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

    Private Sub rptFireLossEstimatesByLocation_DataInitialize(sender As Object, e As System.EventArgs) Handles Me.DataInitialize

    End Sub

    Private Sub rptFireLossEstimatesByLocation_FetchData(ByVal sender As Object, ByVal eArgs As FetchEventArgs) Handles Me.FetchData

    End Sub

    Private Sub rptFireLossEstimatesByLocation_ReportStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportStart
        lblClientName.Text = rptProperties.ClientName
        lblReportDate.Text = Now
        SetLabelText()

        'Hides PML Fields
        If UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.F) Then
            'If AppSession.PML = False Then
            Me.PageSettings.PaperWidth = 8.3!
            Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Portrait
            Me.PageSettings.Margins.Left = 0.68!
            Me.PrintWidth = 8.5!
            Me.lblClientName.Location = New PointF(3.77, 0.05)
            Me.lblCurrency.Width = 3.715
            Me.label3.Location = New PointF(3.77, 0.35)

            Me.line4.Visible = False
            Me.line14.Visible = False
            Me.line15.Visible = False
            Me.line16.Visible = False
            Me.line28.Visible = False
            Me.line29.Visible = False
            Me.line30.Visible = False
            Me.line31.Visible = False
            Me.txtPMLbi.Visible = False
            Me.txtPMLpd.Visible = False
            Me.txtPMLTotal.Visible = False
            Me.lblPMLbi.Visible = False
            Me.lblPMLpd.Visible = False
            Me.lblPMLTotal.Visible = False


            Me.lblMFLpd.Location = lblPMLpd.Location
            Me.lblMFLbi.Location = lblPMLbi.Location
            Me.lblMFLTotal.Location = lblPMLTotal.Location
            Me.lblIBI.Location = Me.lblIBIPlaceholder.Location

            Me.txtMFLpd.Location = txtPMLpd.Location
            Me.txtMFLbi.Location = txtPMLbi.Location
            Me.txtMFLTotal.Location = txtPMLTotal.Location
            Me.txtIBI.Location = txtIBIPlaceholder.Location

            ''lblMFLpd
            'Me.lblMFLpd.Height = 0.15!
            'Me.lblMFLpd.HyperLink = Nothing
            'Me.lblMFLpd.Left = 6.3!
            'Me.lblMFLpd.Name = "lblMFLpd"
            'Me.lblMFLpd.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: right; vertical-align: middle"
            'Me.lblMFLpd.Text = "MFL (PD) " & rptProperties.Currency.colFldCode
            'Me.lblMFLpd.Top = 1.05!
            'Me.lblMFLpd.Width = 1.83!

            ''lblMFLbi
            'Me.lblMFLbi.Height = 0.15!
            'Me.lblMFLbi.HyperLink = Nothing
            'Me.lblMFLbi.Left = 6.3!
            'Me.lblMFLbi.Name = "lblMFLbi"
            'Me.lblMFLbi.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: right; vertical-align: middle"
            'Me.lblMFLbi.Text = "MFL (BI) " & rptProperties.Currency.colFldCode
            'Me.lblMFLbi.Top = 1.2!
            'Me.lblMFLbi.Width = 1.83!

            ''lblMFLTotal
            'Me.lblMFLTotal.Height = 0.15!
            'Me.lblMFLTotal.HyperLink = Nothing
            'Me.lblMFLTotal.Left = 6.3!
            'Me.lblMFLTotal.Name = "lblMFLTotal"
            'Me.lblMFLTotal.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: right; vertical-align: middle"
            'Me.lblMFLTotal.Text = "MFL (Total) " & rptProperties.Currency.colFldCode
            'Me.lblMFLTotal.Top = 1.35!
            'Me.lblMFLTotal.Width = 1.83!

            ''txtMFLpd
            'Me.txtMFLpd.DataField = "MFLPD"
            'Me.txtMFLpd.Height = 0.15!
            'Me.txtMFLpd.Left = 6.3!
            'Me.txtMFLpd.Name = "txtMFLpd"
            'Me.txtMFLpd.Style = "background-color: White; font-size: 7pt; text-align: right; vertical-align: middle"
            'Me.txtMFLpd.Text = "MFL (PD)"
            'Me.txtMFLpd.Top = 1.05!
            'Me.txtMFLpd.Width = 1.83!

            ''txtMFLbi
            'Me.txtMFLbi.DataField = "MFLBI"
            'Me.txtMFLbi.Height = 0.15!
            'Me.txtMFLbi.Left = 6.3!
            'Me.txtMFLbi.Name = "txtMFLbi"
            'Me.txtMFLbi.Style = "background-color: White; font-size: 7pt; text-align: right; vertical-align: middle"
            'Me.txtMFLbi.Text = "MFL (BI)"
            'Me.txtMFLbi.Top = 1.2!
            'Me.txtMFLbi.Width = 1.83!

            ''txtMFLTotal
            'Me.txtMFLTotal.DataField = "MFL"
            'Me.txtMFLTotal.Height = 0.15!
            'Me.txtMFLTotal.Left = 6.3!
            'Me.txtMFLTotal.Name = "txtMFLTotal"
            'Me.txtMFLTotal.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: right; vertical-align: middle"
            'Me.txtMFLTotal.Text = "MFL Total"
            'Me.txtMFLTotal.Top = 1.35!
            'Me.txtMFLTotal.Width = 1.83!

            'Me.lblIBI.DataField = Nothing
            'Me.lblIBI.Height = 0.15!
            'Me.lblIBI.Left = 6.3!
            'Me.lblIBI.Name = "lblIBITotal"
            'Me.lblIBI.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: right; vertical-align: middle"
            'Me.lblIBI.Text = "IBI"
            'Me.lblIBI.Top = 1.5!
            'Me.lblIBI.Width = 1.83!


            'Me.txtIBI.DataField = "IBI"
            'Me.txtIBI.Height = 0.15!
            'Me.txtIBI.Left = 6.3!
            'Me.txtIBI.Name = "txtIBITotal"
            'Me.txtIBI.Style = "background-color: White; font-size: 8pt; text-align: right; vertical-align: middle"
            'Me.txtIBI.Text = "IBI"
            'Me.txtIBI.Top = 0.35!
            'Me.txtIBI.Width = 1.83!
        End If

        If UtilCustomFeature.Contains(rptProperties, CChar("&")) Then
            txtIBI.Visible = True
            lblIBI.Visible = True
        End If

        lblCurrency.Value = "Values in " & rptProperties.Currency.colFldCode & " (" & rptProperties.Currency.colFldSymbol & ")"

    End Sub

    Private Sub SetLabelText()
        lblTIVGrid.Text = "TIV " & rptProperties.Currency.colFldCode & vbLf & "(millions)"
        'lblAPLpd.Text = lblAPLpd.Text & " " & rptProperties.Currency.colFldCode
        'lblAPLbi.Text = lblAPLbi.Text & " " & rptProperties.Currency.colFldCode
        'lblAPLTotal.Text = lblAPLTotal.Text & rptProperties.Currency.colFldCode
        'lblPMLpd.Text = lblPMLpd.Text & " " & rptProperties.Currency.colFldCode
        'lblPMLbi.Text = lblPMLbi.Text & " " & rptProperties.Currency.colFldCode
        'lblPMLTotal.Text = lblPMLTotal.Text & rptProperties.Currency.colFldCode
        'lblMFLpd.Text = lblMFLpd.Text & " " & rptProperties.Currency.colFldCode
        'lblMFLbi.Text = lblMFLbi.Text & " " & rptProperties.Currency.colFldCode
        'lblMFLTotal.Text = lblMFLTotal.Text & rptProperties.Currency.colFldCode
        'lblIBI.Text = lblIBI.Text & " " & rptProperties.Currency.colFldCode
    End Sub

    Private Sub rptBMRecommendations_PageStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.PageStart
        UtilReport.ActiveReport.SetFilter(Me, rptProperties)
        UtilReport.ActiveReport.SetSort(Me, rptProperties)
        UtilReport.ActiveReport.SetDisclaimer(Me, rptProperties)
    End Sub

    Private Sub rptFireLossEstimatesByLocation_ReportEnd(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportEnd
        DisposeParameters()
    End Sub

    Private Sub DisposeParameters()
        DataSource = Nothing
    End Sub

    Private Sub Detail1_Format(sender As Object, e As System.EventArgs) Handles Detail1.Format
        If Not IsNothing(txtBIReporting.Value) Then
            If LCase(txtBIReporting.Value.ToString) = "percentage" Then
                txtPMLTotal.Text = "N/A"
                txtPMLbi.Text = "N/A"
                txtMFLTotal.Text = "N/A"
                txtMFLbi.Text = "N/A"
            End If
        End If
    End Sub

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties

End Class
