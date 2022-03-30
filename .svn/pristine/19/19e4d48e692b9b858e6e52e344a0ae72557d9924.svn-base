Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports

Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Public Class rptBMHumanElementSummary
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
    Private WithEvents txtFilters As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblLocationDetail As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblHERating As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblHEAdequate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblClientName As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblReport As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFileNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblTIVmillions As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCountry As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label7 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCity As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblSurveyDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblDivision As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblAddress As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblTraining As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblManagement As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblHEElecMaintTrain As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblHEBoilerOpTrain As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblHERecordKeeping As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblHEHousekeeping As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblHEGenMaint As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblHEMgmtofChng As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFilters As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblClientLocNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFacility As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents line2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line4 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line9 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line10 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line11 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line15 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line16 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line53 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line55 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line58 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line61 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line64 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtSort As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblReportDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents reportInfo1 As GrapeCity.ActiveReports.SectionReportModel.ReportInfo
    Private WithEvents txtInspectionDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtClientLocNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents textBox5 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtTIV As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents textBox4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFileNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtDivision As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtHERating As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtHEAdequate As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtHEElecMaintTrain As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtHEBoilerOpTrain As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtHERecordKeeping As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtHEHousekeeping As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtHEGenMaint As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtHEMgmtofChng As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFacility As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents line21 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line26 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line28 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line29 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line32 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line33 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line37 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line38 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line39 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line42 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line35 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line34 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents textBox2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line31 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtCountry As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents line30 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line3 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line59 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line14 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line54 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line63 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line56 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line17 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtDisclaimer As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents PageFooter1 As GrapeCity.ActiveReports.SectionReportModel.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptBMHumanElementSummary))
        Me.PageHeader1 = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.picGRCLogo = New GrapeCity.ActiveReports.SectionReportModel.Picture()
        Me.txtFilters = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblLocationDetail = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblHERating = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblHEAdequate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblClientName = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblReport = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFileNo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblTIVmillions = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblCountry = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label7 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblCity = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSurveyDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblDivision = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblAddress = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblTraining = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblManagement = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblHEElecMaintTrain = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblHEBoilerOpTrain = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblHERecordKeeping = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblHEHousekeeping = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblHEGenMaint = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblHEMgmtofChng = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFilters = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblClientLocNo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFacility = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line9 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line10 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line11 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line15 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line16 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line53 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line55 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line58 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line61 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line64 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line59 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line14 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line54 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line63 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line56 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Detail1 = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.txtInspectionDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtClientLocNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.textBox5 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtTIV = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.textBox4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFileNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtDivision = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtHERating = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtHEAdequate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtHEElecMaintTrain = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtHEBoilerOpTrain = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtHERecordKeeping = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtHEHousekeeping = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtHEGenMaint = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtHEMgmtofChng = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFacility = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.line21 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line26 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line28 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line29 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line32 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line33 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line37 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line38 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line39 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line42 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line35 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line34 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.textBox2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line31 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtCountry = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.line30 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line17 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.PageFooter1 = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.txtSort = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblReportDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.reportInfo1 = New GrapeCity.ActiveReports.SectionReportModel.ReportInfo()
        Me.txtDisclaimer = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        CType(Me.picGRCLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblLocationDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHERating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHEAdequate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblClientName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFileNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTIVmillions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSurveyDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDivision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTraining, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblManagement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHEElecMaintTrain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHEBoilerOpTrain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHERecordKeeping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHEHousekeeping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHEGenMaint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHEMgmtofChng, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblClientLocNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFacility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInspectionDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientLocNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTIV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFileNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDivision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHERating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHEAdequate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHEElecMaintTrain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHEBoilerOpTrain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHERecordKeeping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHEHousekeeping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHEGenMaint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHEMgmtofChng, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PageHeader1.CanShrink = True
        Me.PageHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.picGRCLogo, Me.txtFilters, Me.lblLocationDetail, Me.lblHERating, Me.lblHEAdequate, Me.lblClientName, Me.lblReport, Me.lblFileNo, Me.lblTIVmillions, Me.lblCountry, Me.label7, Me.lblCity, Me.lblSurveyDate, Me.lblDivision, Me.lblAddress, Me.lblTraining, Me.lblManagement, Me.lblHEElecMaintTrain, Me.lblHEBoilerOpTrain, Me.lblHERecordKeeping, Me.lblHEHousekeeping, Me.lblHEGenMaint, Me.lblHEMgmtofChng, Me.lblFilters, Me.lblClientLocNo, Me.lblFacility, Me.line2, Me.line4, Me.line9, Me.line10, Me.line11, Me.line15, Me.line16, Me.line53, Me.line55, Me.line58, Me.line61, Me.line64, Me.line59, Me.line14, Me.line54, Me.line63, Me.line56})
        Me.PageHeader1.Height = 1.5!
        Me.PageHeader1.Name = "PageHeader1"
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
        'txtFilters
        '
        Me.txtFilters.CanShrink = True
        Me.txtFilters.Height = 0.15!
        Me.txtFilters.Left = 0.44!
        Me.txtFilters.Name = "txtFilters"
        Me.txtFilters.Style = "background-color: White; font-size: 8pt; vertical-align: middle"
        Me.txtFilters.Text = Nothing
        Me.txtFilters.Top = 0.85!
        Me.txtFilters.Width = 9.1!
        '
        'lblLocationDetail
        '
        Me.lblLocationDetail.Height = 0.15!
        Me.lblLocationDetail.HyperLink = Nothing
        Me.lblLocationDetail.Left = 0.0!
        Me.lblLocationDetail.Name = "lblLocationDetail"
        Me.lblLocationDetail.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblLocationDetail.Text = "Location Detail"
        Me.lblLocationDetail.Top = 1.05!
        Me.lblLocationDetail.Width = 4.9!
        '
        'lblHERating
        '
        Me.lblHERating.Height = 0.15!
        Me.lblHERating.HyperLink = Nothing
        Me.lblHERating.Left = 4.37!
        Me.lblHERating.Name = "lblHERating"
        Me.lblHERating.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblHERating.Text = "HE Rating/"
        Me.lblHERating.Top = 1.2!
        Me.lblHERating.Width = 0.53!
        '
        'lblHEAdequate
        '
        Me.lblHEAdequate.Height = 0.15!
        Me.lblHEAdequate.HyperLink = Nothing
        Me.lblHEAdequate.Left = 4.37!
        Me.lblHEAdequate.Name = "lblHEAdequate"
        Me.lblHEAdequate.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblHEAdequate.Text = "Adequate"
        Me.lblHEAdequate.Top = 1.35!
        Me.lblHEAdequate.Width = 0.53!
        '
        'lblClientName
        '
        Me.lblClientName.Height = 0.25!
        Me.lblClientName.HyperLink = Nothing
        Me.lblClientName.Left = 5.2!
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
        Me.lblReport.Left = 5.2!
        Me.lblReport.Name = "lblReport"
        Me.lblReport.Style = "font-size: 12pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblReport.Text = "B&M Human Element Summary"
        Me.lblReport.Top = 0.35!
        Me.lblReport.Width = 4.3!
        '
        'lblFileNo
        '
        Me.lblFileNo.Height = 0.15!
        Me.lblFileNo.HyperLink = Nothing
        Me.lblFileNo.Left = 0.0!
        Me.lblFileNo.Name = "lblFileNo"
        Me.lblFileNo.Style = "background-color: White; font-size: 7pt"
        Me.lblFileNo.Text = "File No."
        Me.lblFileNo.Top = 1.2!
        Me.lblFileNo.Width = 0.52!
        '
        'lblTIVmillions
        '
        Me.lblTIVmillions.Height = 0.3!
        Me.lblTIVmillions.HyperLink = Nothing
        Me.lblTIVmillions.Left = 3.95!
        Me.lblTIVmillions.Name = "lblTIVmillions"
        Me.lblTIVmillions.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblTIVmillions.Text = "TIV USD (millions)"
        Me.lblTIVmillions.Top = 1.2!
        Me.lblTIVmillions.Width = 0.42!
        '
        'lblCountry
        '
        Me.lblCountry.Height = 0.1458!
        Me.lblCountry.HyperLink = Nothing
        Me.lblCountry.Left = 3.2!
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Style = "background-color: White; font-size: 7pt"
        Me.lblCountry.Text = "Country"
        Me.lblCountry.Top = 1.2!
        Me.lblCountry.Width = 0.75!
        '
        'label7
        '
        Me.label7.Height = 0.15!
        Me.label7.HyperLink = Nothing
        Me.label7.Left = 2.85!
        Me.label7.Name = "label7"
        Me.label7.Style = "background-color: White; font-size: 7pt"
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
        Me.lblCity.Style = "background-color: White; font-size: 7pt"
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
        Me.lblSurveyDate.Style = "background-color: White; font-size: 7pt"
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
        Me.lblDivision.Style = "background-color: White; font-size: 7pt"
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
        Me.lblAddress.Style = "background-color: White; font-size: 7pt"
        Me.lblAddress.Text = "Address"
        Me.lblAddress.Top = 1.35!
        Me.lblAddress.Width = 2.05!
        '
        'lblTraining
        '
        Me.lblTraining.Height = 0.146!
        Me.lblTraining.HyperLink = Nothing
        Me.lblTraining.Left = 4.95!
        Me.lblTraining.Name = "lblTraining"
        Me.lblTraining.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblTraining.Text = "Training"
        Me.lblTraining.Top = 1.05!
        Me.lblTraining.Width = 2.75!
        '
        'lblManagement
        '
        Me.lblManagement.Height = 0.146!
        Me.lblManagement.HyperLink = Nothing
        Me.lblManagement.Left = 7.75!
        Me.lblManagement.Name = "lblManagement"
        Me.lblManagement.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblManagement.Text = "Management"
        Me.lblManagement.Top = 1.05!
        Me.lblManagement.Width = 1.8!
        '
        'lblHEElecMaintTrain
        '
        Me.lblHEElecMaintTrain.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblHEElecMaintTrain.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblHEElecMaintTrain.Height = 0.3!
        Me.lblHEElecMaintTrain.HyperLink = Nothing
        Me.lblHEElecMaintTrain.Left = 4.95!
        Me.lblHEElecMaintTrain.Name = "lblHEElecMaintTrain"
        Me.lblHEElecMaintTrain.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblHEElecMaintTrain.Text = "Elec./Maint. Training"
        Me.lblHEElecMaintTrain.Top = 1.2!
        Me.lblHEElecMaintTrain.Width = 1.435!
        '
        'lblHEBoilerOpTrain
        '
        Me.lblHEBoilerOpTrain.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblHEBoilerOpTrain.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblHEBoilerOpTrain.Height = 0.3!
        Me.lblHEBoilerOpTrain.HyperLink = Nothing
        Me.lblHEBoilerOpTrain.Left = 6.385!
        Me.lblHEBoilerOpTrain.Name = "lblHEBoilerOpTrain"
        Me.lblHEBoilerOpTrain.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblHEBoilerOpTrain.Text = "Boiler Ops. Training"
        Me.lblHEBoilerOpTrain.Top = 1.2!
        Me.lblHEBoilerOpTrain.Width = 1.315!
        '
        'lblHERecordKeeping
        '
        Me.lblHERecordKeeping.Height = 0.3!
        Me.lblHERecordKeeping.HyperLink = Nothing
        Me.lblHERecordKeeping.Left = 7.75!
        Me.lblHERecordKeeping.Name = "lblHERecordKeeping"
        Me.lblHERecordKeeping.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblHERecordKeeping.Text = "Record Keeping"
        Me.lblHERecordKeeping.Top = 1.2!
        Me.lblHERecordKeeping.Width = 0.45!
        '
        'lblHEHousekeeping
        '
        Me.lblHEHousekeeping.Height = 0.3!
        Me.lblHEHousekeeping.HyperLink = Nothing
        Me.lblHEHousekeeping.Left = 8.2!
        Me.lblHEHousekeeping.Name = "lblHEHousekeeping"
        Me.lblHEHousekeeping.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblHEHousekeeping.Text = "House-keeping"
        Me.lblHEHousekeeping.Top = 1.2!
        Me.lblHEHousekeeping.Width = 0.45!
        '
        'lblHEGenMaint
        '
        Me.lblHEGenMaint.Height = 0.3!
        Me.lblHEGenMaint.HyperLink = Nothing
        Me.lblHEGenMaint.Left = 8.65!
        Me.lblHEGenMaint.Name = "lblHEGenMaint"
        Me.lblHEGenMaint.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblHEGenMaint.Text = "General Maint."
        Me.lblHEGenMaint.Top = 1.2!
        Me.lblHEGenMaint.Width = 0.45!
        '
        'lblHEMgmtofChng
        '
        Me.lblHEMgmtofChng.Height = 0.3!
        Me.lblHEMgmtofChng.HyperLink = Nothing
        Me.lblHEMgmtofChng.Left = 9.1!
        Me.lblHEMgmtofChng.Name = "lblHEMgmtofChng"
        Me.lblHEMgmtofChng.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblHEMgmtofChng.Text = "Mgmt. of Change"
        Me.lblHEMgmtofChng.Top = 1.2!
        Me.lblHEMgmtofChng.Width = 0.45!
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
        'lblClientLocNo
        '
        Me.lblClientLocNo.Height = 0.1458!
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
        'line2
        '
        Me.line2.Height = 0.0!
        Me.line2.Left = 4.95!
        Me.line2.LineWeight = 1.0!
        Me.line2.Name = "line2"
        Me.line2.Top = 1.2!
        Me.line2.Width = 2.75!
        Me.line2.X1 = 4.95!
        Me.line2.X2 = 7.7!
        Me.line2.Y1 = 1.2!
        Me.line2.Y2 = 1.2!
        '
        'line4
        '
        Me.line4.Height = 0.45!
        Me.line4.Left = 4.95!
        Me.line4.LineWeight = 1.0!
        Me.line4.Name = "line4"
        Me.line4.Top = 1.05!
        Me.line4.Width = 0.0!
        Me.line4.X1 = 4.95!
        Me.line4.X2 = 4.95!
        Me.line4.Y1 = 1.05!
        Me.line4.Y2 = 1.5!
        '
        'line9
        '
        Me.line9.Height = 0.45!
        Me.line9.Left = 7.7!
        Me.line9.LineWeight = 1.0!
        Me.line9.Name = "line9"
        Me.line9.Top = 1.05!
        Me.line9.Width = 0.0!
        Me.line9.X1 = 7.7!
        Me.line9.X2 = 7.7!
        Me.line9.Y1 = 1.05!
        Me.line9.Y2 = 1.5!
        '
        'line10
        '
        Me.line10.Height = 0.3!
        Me.line10.Left = 8.65!
        Me.line10.LineWeight = 1.0!
        Me.line10.Name = "line10"
        Me.line10.Top = 1.2!
        Me.line10.Width = 0.0!
        Me.line10.X1 = 8.65!
        Me.line10.X2 = 8.65!
        Me.line10.Y1 = 1.2!
        Me.line10.Y2 = 1.5!
        '
        'line11
        '
        Me.line11.Height = 0.3!
        Me.line11.Left = 9.1!
        Me.line11.LineWeight = 1.0!
        Me.line11.Name = "line11"
        Me.line11.Top = 1.2!
        Me.line11.Width = 0.0!
        Me.line11.X1 = 9.1!
        Me.line11.X2 = 9.1!
        Me.line11.Y1 = 1.2!
        Me.line11.Y2 = 1.5!
        '
        'line15
        '
        Me.line15.Height = 0.3!
        Me.line15.Left = 8.2!
        Me.line15.LineWeight = 1.0!
        Me.line15.Name = "line15"
        Me.line15.Top = 1.2!
        Me.line15.Width = 0.0!
        Me.line15.X1 = 8.2!
        Me.line15.X2 = 8.2!
        Me.line15.Y1 = 1.2!
        Me.line15.Y2 = 1.5!
        '
        'line16
        '
        Me.line16.Height = 0.0!
        Me.line16.Left = 7.75!
        Me.line16.LineWeight = 1.0!
        Me.line16.Name = "line16"
        Me.line16.Top = 1.2!
        Me.line16.Width = 1.8!
        Me.line16.X1 = 7.75!
        Me.line16.X2 = 9.55!
        Me.line16.Y1 = 1.2!
        Me.line16.Y2 = 1.2!
        '
        'line53
        '
        Me.line53.Height = 0.0!
        Me.line53.Left = 4.95!
        Me.line53.LineWeight = 1.0!
        Me.line53.Name = "line53"
        Me.line53.Top = 1.05!
        Me.line53.Width = 2.75!
        Me.line53.X1 = 4.95!
        Me.line53.X2 = 7.7!
        Me.line53.Y1 = 1.05!
        Me.line53.Y2 = 1.05!
        '
        'line55
        '
        Me.line55.Height = 0.0!
        Me.line55.Left = 0.0!
        Me.line55.LineWeight = 1.0!
        Me.line55.Name = "line55"
        Me.line55.Top = 1.05!
        Me.line55.Width = 4.9!
        Me.line55.X1 = 0.0!
        Me.line55.X2 = 4.9!
        Me.line55.Y1 = 1.05!
        Me.line55.Y2 = 1.05!
        '
        'line58
        '
        Me.line58.Height = 0.45!
        Me.line58.Left = 4.9!
        Me.line58.LineWeight = 1.0!
        Me.line58.Name = "line58"
        Me.line58.Top = 1.05!
        Me.line58.Width = 0.0!
        Me.line58.X1 = 4.9!
        Me.line58.X2 = 4.9!
        Me.line58.Y1 = 1.05!
        Me.line58.Y2 = 1.5!
        '
        'line61
        '
        Me.line61.Height = 0.45!
        Me.line61.Left = 7.75!
        Me.line61.LineWeight = 1.0!
        Me.line61.Name = "line61"
        Me.line61.Top = 1.05!
        Me.line61.Width = 0.0!
        Me.line61.X1 = 7.75!
        Me.line61.X2 = 7.75!
        Me.line61.Y1 = 1.05!
        Me.line61.Y2 = 1.5!
        '
        'line64
        '
        Me.line64.Height = 0.0!
        Me.line64.Left = 7.75!
        Me.line64.LineWeight = 1.0!
        Me.line64.Name = "line64"
        Me.line64.Top = 1.05!
        Me.line64.Width = 1.8!
        Me.line64.X1 = 7.75!
        Me.line64.X2 = 9.55!
        Me.line64.Y1 = 1.05!
        Me.line64.Y2 = 1.05!
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
        'line14
        '
        Me.line14.Height = 0.45!
        Me.line14.Left = 9.55!
        Me.line14.LineWeight = 1.0!
        Me.line14.Name = "line14"
        Me.line14.Top = 1.05!
        Me.line14.Width = 0.0!
        Me.line14.X1 = 9.55!
        Me.line14.X2 = 9.55!
        Me.line14.Y1 = 1.05!
        Me.line14.Y2 = 1.5!
        '
        'line54
        '
        Me.line54.Height = 0.0!
        Me.line54.Left = 4.95!
        Me.line54.LineWeight = 1.0!
        Me.line54.Name = "line54"
        Me.line54.Top = 1.5!
        Me.line54.Width = 2.75!
        Me.line54.X1 = 4.95!
        Me.line54.X2 = 7.7!
        Me.line54.Y1 = 1.5!
        Me.line54.Y2 = 1.5!
        '
        'line63
        '
        Me.line63.Height = 0.0!
        Me.line63.Left = 7.75!
        Me.line63.LineWeight = 1.0!
        Me.line63.Name = "line63"
        Me.line63.Top = 1.5!
        Me.line63.Width = 1.8!
        Me.line63.X1 = 7.75!
        Me.line63.X2 = 9.55!
        Me.line63.Y1 = 1.5!
        Me.line63.Y2 = 1.5!
        '
        'line56
        '
        Me.line56.Height = 0.0!
        Me.line56.Left = 0.0!
        Me.line56.LineWeight = 1.0!
        Me.line56.Name = "line56"
        Me.line56.Top = 1.5!
        Me.line56.Width = 4.9!
        Me.line56.X1 = 0.0!
        Me.line56.X2 = 4.9!
        Me.line56.Y1 = 1.5!
        Me.line56.Y2 = 1.5!
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtInspectionDate, Me.txtClientLocNo, Me.textBox5, Me.txtTIV, Me.textBox4, Me.txtFileNo, Me.txtDivision, Me.txtHERating, Me.txtHEAdequate, Me.txtHEElecMaintTrain, Me.txtHEBoilerOpTrain, Me.txtHERecordKeeping, Me.txtHEHousekeeping, Me.txtHEGenMaint, Me.txtHEMgmtofChng, Me.txtFacility, Me.line21, Me.line26, Me.line28, Me.line29, Me.line32, Me.line33, Me.line37, Me.line38, Me.line39, Me.line42, Me.line35, Me.line34, Me.textBox2, Me.line1, Me.line31, Me.txtCountry, Me.line30, Me.line3, Me.line17})
        Me.Detail1.Height = 0.35!
        Me.Detail1.KeepTogether = True
        Me.Detail1.Name = "Detail1"
        '
        'txtInspectionDate
        '
        Me.txtInspectionDate.CanGrow = False
        Me.txtInspectionDate.DataField = "InspectionDate"
        Me.txtInspectionDate.Height = 0.15!
        Me.txtInspectionDate.Left = 0.52!
        Me.txtInspectionDate.MultiLine = False
        Me.txtInspectionDate.Name = "txtInspectionDate"
        Me.txtInspectionDate.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.txtInspectionDate.Text = "22 Mar 05"
        Me.txtInspectionDate.Top = 0.05!
        Me.txtInspectionDate.Width = 0.58!
        '
        'txtClientLocNo
        '
        Me.txtClientLocNo.CanGrow = False
        Me.txtClientLocNo.DataField = "ClientLocNo"
        Me.txtClientLocNo.Height = 0.15!
        Me.txtClientLocNo.Left = 1.1!
        Me.txtClientLocNo.Name = "txtClientLocNo"
        Me.txtClientLocNo.Style = "background-color: White; font-size: 7pt"
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
        Me.textBox5.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
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
        Me.txtTIV.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
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
        Me.textBox4.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
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
        Me.txtFileNo.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
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
        Me.txtDivision.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.txtDivision.Text = "Division"
        Me.txtDivision.Top = 0.2!
        Me.txtDivision.Width = 1.1!
        '
        'txtHERating
        '
        Me.txtHERating.DataField = "HumanElementC"
        Me.txtHERating.Height = 0.15!
        Me.txtHERating.Left = 4.37!
        Me.txtHERating.Name = "txtHERating"
        Me.txtHERating.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtHERating.Text = "HE Rating"
        Me.txtHERating.Top = 0.05!
        Me.txtHERating.Width = 0.53!
        '
        'txtHEAdequate
        '
        Me.txtHEAdequate.DataField = "HEAdequate"
        Me.txtHEAdequate.Height = 0.15!
        Me.txtHEAdequate.Left = 4.37!
        Me.txtHEAdequate.Name = "txtHEAdequate"
        Me.txtHEAdequate.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtHEAdequate.Text = "Inadequate"
        Me.txtHEAdequate.Top = 0.2!
        Me.txtHEAdequate.Width = 0.53!
        '
        'txtHEElecMaintTrain
        '
        Me.txtHEElecMaintTrain.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtHEElecMaintTrain.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtHEElecMaintTrain.DataField = "HEElecMaintTrain"
        Me.txtHEElecMaintTrain.Height = 0.3!
        Me.txtHEElecMaintTrain.Left = 4.95!
        Me.txtHEElecMaintTrain.Name = "txtHEElecMaintTrain"
        Me.txtHEElecMaintTrain.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtHEElecMaintTrain.Text = "Inadequate"
        Me.txtHEElecMaintTrain.Top = 0.05!
        Me.txtHEElecMaintTrain.Width = 1.435!
        '
        'txtHEBoilerOpTrain
        '
        Me.txtHEBoilerOpTrain.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtHEBoilerOpTrain.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtHEBoilerOpTrain.DataField = "HEBoilerOpTrain"
        Me.txtHEBoilerOpTrain.Height = 0.3!
        Me.txtHEBoilerOpTrain.Left = 6.385!
        Me.txtHEBoilerOpTrain.Name = "txtHEBoilerOpTrain"
        Me.txtHEBoilerOpTrain.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtHEBoilerOpTrain.Text = "Not Applicable"
        Me.txtHEBoilerOpTrain.Top = 0.05!
        Me.txtHEBoilerOpTrain.Width = 1.315!
        '
        'txtHERecordKeeping
        '
        Me.txtHERecordKeeping.DataField = "HERecordKeeping"
        Me.txtHERecordKeeping.Height = 0.3!
        Me.txtHERecordKeeping.Left = 7.75!
        Me.txtHERecordKeeping.Name = "txtHERecordKeeping"
        Me.txtHERecordKeeping.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtHERecordKeeping.Text = "Inadequate"
        Me.txtHERecordKeeping.Top = 0.05!
        Me.txtHERecordKeeping.Width = 0.45!
        '
        'txtHEHousekeeping
        '
        Me.txtHEHousekeeping.DataField = "HEHousekeeping"
        Me.txtHEHousekeeping.Height = 0.3!
        Me.txtHEHousekeeping.Left = 8.2!
        Me.txtHEHousekeeping.Name = "txtHEHousekeeping"
        Me.txtHEHousekeeping.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtHEHousekeeping.Text = "Inadequate"
        Me.txtHEHousekeeping.Top = 0.05!
        Me.txtHEHousekeeping.Width = 0.45!
        '
        'txtHEGenMaint
        '
        Me.txtHEGenMaint.DataField = "HEGenMaint"
        Me.txtHEGenMaint.Height = 0.3!
        Me.txtHEGenMaint.Left = 8.65!
        Me.txtHEGenMaint.Name = "txtHEGenMaint"
        Me.txtHEGenMaint.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtHEGenMaint.Text = "Inadequate"
        Me.txtHEGenMaint.Top = 0.05!
        Me.txtHEGenMaint.Width = 0.45!
        '
        'txtHEMgmtofChng
        '
        Me.txtHEMgmtofChng.DataField = "HEMgmtofChng"
        Me.txtHEMgmtofChng.Height = 0.3!
        Me.txtHEMgmtofChng.Left = 9.1!
        Me.txtHEMgmtofChng.Name = "txtHEMgmtofChng"
        Me.txtHEMgmtofChng.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtHEMgmtofChng.Text = "Inadequate"
        Me.txtHEMgmtofChng.Top = 0.05!
        Me.txtHEMgmtofChng.Width = 0.45!
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
        'line21
        '
        Me.line21.Height = 0.3!
        Me.line21.Left = 4.95!
        Me.line21.LineWeight = 1.0!
        Me.line21.Name = "line21"
        Me.line21.Top = 0.05!
        Me.line21.Width = 0.0!
        Me.line21.X1 = 4.95!
        Me.line21.X2 = 4.95!
        Me.line21.Y1 = 0.05!
        Me.line21.Y2 = 0.35!
        '
        'line26
        '
        Me.line26.Height = 0.3!
        Me.line26.Left = 7.7!
        Me.line26.LineWeight = 1.0!
        Me.line26.Name = "line26"
        Me.line26.Top = 0.05!
        Me.line26.Width = 0.0!
        Me.line26.X1 = 7.7!
        Me.line26.X2 = 7.7!
        Me.line26.Y1 = 0.05!
        Me.line26.Y2 = 0.35!
        '
        'line28
        '
        Me.line28.Height = 0.3!
        Me.line28.Left = 4.9!
        Me.line28.LineWeight = 1.0!
        Me.line28.Name = "line28"
        Me.line28.Top = 0.05!
        Me.line28.Width = 0.0!
        Me.line28.X1 = 4.9!
        Me.line28.X2 = 4.9!
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
        Me.line32.Left = 4.95!
        Me.line32.LineWeight = 1.0!
        Me.line32.Name = "line32"
        Me.line32.Top = 0.35!
        Me.line32.Width = 2.75!
        Me.line32.X1 = 4.95!
        Me.line32.X2 = 7.7!
        Me.line32.Y1 = 0.35!
        Me.line32.Y2 = 0.35!
        '
        'line33
        '
        Me.line33.Height = 0.0!
        Me.line33.Left = 7.75!
        Me.line33.LineWeight = 1.0!
        Me.line33.Name = "line33"
        Me.line33.Top = 0.35!
        Me.line33.Width = 1.8!
        Me.line33.X1 = 7.75!
        Me.line33.X2 = 9.55!
        Me.line33.Y1 = 0.35!
        Me.line33.Y2 = 0.35!
        '
        'line37
        '
        Me.line37.Height = 0.3!
        Me.line37.Left = 7.75!
        Me.line37.LineWeight = 1.0!
        Me.line37.Name = "line37"
        Me.line37.Top = 0.05!
        Me.line37.Width = 0.0!
        Me.line37.X1 = 7.75!
        Me.line37.X2 = 7.75!
        Me.line37.Y1 = 0.05!
        Me.line37.Y2 = 0.35!
        '
        'line38
        '
        Me.line38.Height = 0.3!
        Me.line38.Left = 8.65!
        Me.line38.LineWeight = 1.0!
        Me.line38.Name = "line38"
        Me.line38.Top = 0.05!
        Me.line38.Width = 0.0!
        Me.line38.X1 = 8.65!
        Me.line38.X2 = 8.65!
        Me.line38.Y1 = 0.05!
        Me.line38.Y2 = 0.35!
        '
        'line39
        '
        Me.line39.Height = 0.3!
        Me.line39.Left = 9.1!
        Me.line39.LineWeight = 1.0!
        Me.line39.Name = "line39"
        Me.line39.Top = 0.05!
        Me.line39.Width = 0.0!
        Me.line39.X1 = 9.1!
        Me.line39.X2 = 9.1!
        Me.line39.Y1 = 0.05!
        Me.line39.Y2 = 0.35!
        '
        'line42
        '
        Me.line42.Height = 0.3!
        Me.line42.Left = 9.55!
        Me.line42.LineWeight = 1.0!
        Me.line42.Name = "line42"
        Me.line42.Top = 0.05!
        Me.line42.Width = 0.0!
        Me.line42.X1 = 9.55!
        Me.line42.X2 = 9.55!
        Me.line42.Y1 = 0.05!
        Me.line42.Y2 = 0.35!
        '
        'line35
        '
        Me.line35.Height = 0.0!
        Me.line35.Left = 4.95!
        Me.line35.LineWeight = 1.0!
        Me.line35.Name = "line35"
        Me.line35.Top = 0.05!
        Me.line35.Width = 2.75!
        Me.line35.X1 = 4.95!
        Me.line35.X2 = 7.7!
        Me.line35.Y1 = 0.05!
        Me.line35.Y2 = 0.05!
        '
        'line34
        '
        Me.line34.Height = 0.0!
        Me.line34.Left = 7.75!
        Me.line34.LineWeight = 1.0!
        Me.line34.Name = "line34"
        Me.line34.Top = 0.05!
        Me.line34.Width = 1.8!
        Me.line34.X1 = 7.75!
        Me.line34.X2 = 9.55!
        Me.line34.Y1 = 0.05!
        Me.line34.Y2 = 0.05!
        '
        'textBox2
        '
        Me.textBox2.CanGrow = False
        Me.textBox2.DataField = "Address"
        Me.textBox2.Height = 0.15!
        Me.textBox2.Left = 1.9!
        Me.textBox2.MultiLine = False
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
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
        Me.line31.Width = 4.9!
        Me.line31.X1 = 0.0!
        Me.line31.X2 = 4.9!
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
        Me.txtCountry.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
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
        Me.line30.Width = 4.9!
        Me.line30.X1 = 0.0!
        Me.line30.X2 = 4.9!
        Me.line30.Y1 = 0.05!
        Me.line30.Y2 = 0.05!
        '
        'line3
        '
        Me.line3.Height = 0.3!
        Me.line3.Left = 8.2!
        Me.line3.LineWeight = 1.0!
        Me.line3.Name = "line3"
        Me.line3.Top = 0.05!
        Me.line3.Width = 0.0!
        Me.line3.X1 = 8.2!
        Me.line3.X2 = 8.2!
        Me.line3.Y1 = 0.05!
        Me.line3.Y2 = 0.35!
        '
        'line17
        '
        Me.line17.Height = 0.0!
        Me.line17.Left = 4.37!
        Me.line17.LineWeight = 1.0!
        Me.line17.Name = "line17"
        Me.line17.Top = 0.2!
        Me.line17.Width = 0.5300002!
        Me.line17.X1 = 4.37!
        Me.line17.X2 = 4.9!
        Me.line17.Y1 = 0.2!
        Me.line17.Y2 = 0.2!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtSort, Me.lblReportDate, Me.reportInfo1, Me.txtDisclaimer})
        Me.PageFooter1.Height = 0.3916667!
        Me.PageFooter1.Name = "PageFooter1"
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
        Me.txtSort.Width = 9.35!
        '
        'lblReportDate
        '
        Me.lblReportDate.Height = 0.15!
        Me.lblReportDate.HyperLink = Nothing
        Me.lblReportDate.Left = 0.0!
        Me.lblReportDate.Name = "lblReportDate"
        Me.lblReportDate.Style = "font-size: 7pt; vertical-align: middle"
        Me.lblReportDate.Text = "Report Date"
        Me.lblReportDate.Top = 0.25!
        Me.lblReportDate.Width = 2.0!
        '
        'reportInfo1
        '
        Me.reportInfo1.FormatString = "Page {PageNumber} of {PageCount}"
        Me.reportInfo1.Height = 0.15!
        Me.reportInfo1.Left = 7.375!
        Me.reportInfo1.Name = "reportInfo1"
        Me.reportInfo1.Style = "font-size: 7pt; font-style: italic; text-align: right; vertical-align: middle"
        Me.reportInfo1.Top = 0.25!
        Me.reportInfo1.Width = 2.0!
        '
        'txtDisclaimer
        '
        Me.txtDisclaimer.CanShrink = True
        Me.txtDisclaimer.Height = 0.15!
        Me.txtDisclaimer.Left = 0.0!
        Me.txtDisclaimer.Name = "txtDisclaimer"
        Me.txtDisclaimer.Style = "font-size: 7pt; font-style: italic; text-align: center; vertical-align: middle"
        Me.txtDisclaimer.Text = Nothing
        Me.txtDisclaimer.Top = 0.125!
        Me.txtDisclaimer.Width = 9.35!
        '
        'rptBMHumanElementSummary
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.25!
        Me.PageSettings.Margins.Left = 0.725!
        Me.PageSettings.Margins.Right = 0.725!
        Me.PageSettings.Margins.Top = 0.25!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 9.55!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Calibri; font-style: normal; text-decoration: none; font-weight: nor" & _
            "mal; font-size: 10pt; color: Black", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
            "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.picGRCLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblLocationDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHERating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHEAdequate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblClientName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFileNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTIVmillions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCountry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSurveyDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDivision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTraining, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblManagement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHEElecMaintTrain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHEBoilerOpTrain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHERecordKeeping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHEHousekeeping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHEGenMaint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHEMgmtofChng, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblClientLocNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFacility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInspectionDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientLocNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTIV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFileNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDivision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHERating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHEAdequate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHEElecMaintTrain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHEBoilerOpTrain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHERecordKeeping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHEHousekeeping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHEGenMaint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHEMgmtofChng, System.ComponentModel.ISupportInitialize).EndInit()
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

    Private Sub rptBMHumanElementSummary_FetchData(ByVal sender As Object, ByVal eArgs As FetchEventArgs) Handles Me.FetchData
        lblTIVmillions.Text = "TIV " & rptProperties.Currency.colFldCode & vbLf & "(millions)" '.TIVCurrency(AppSession.Currency)"

        Dim zTextControls() As ARControl = {txtHEAdequate, txtHEElecMaintTrain, txtHEBoilerOpTrain, txtHERecordKeeping, txtHEHousekeeping, txtHEGenMaint, txtHEMgmtofChng}
        UtilReport.ActiveReport.SetItemBackColorByText(Me, zTextControls, rptProperties)

        Dim zRatingControls() As ARControl = {txtHERating}
        UtilReport.ActiveReport.SetItemBackColorByRating(Me, zRatingControls, rptProperties)

    End Sub

    Private Sub rptBMHumanElementSummary_ReportStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportStart
        lblClientName.Text = rptProperties.ClientName ' AppSession.ClientName
        lblReportDate.Text = Now() ' modActiveReport.ReportDate
    End Sub

    Private Sub rptBMHumanElementSummary_PageStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.PageStart

        UtilReport.ActiveReport.SetFilter(Me, rptProperties)
        UtilReport.ActiveReport.SetSort(Me, rptProperties)
        UtilReport.ActiveReport.SetDisclaimer(Me, rptProperties)

    End Sub

    Private Sub rptBMHumanElementSummary_ReportEnd(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportEnd
        DisposeParameters()
    End Sub

    Private Sub DisposeParameters()
        DataSource = Nothing
    End Sub

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties

End Class