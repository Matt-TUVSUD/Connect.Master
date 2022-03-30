Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports

Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing

Public Class rptNatHazSeismicAssessmentNonstructural
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
    Private WithEvents PageFooter1 As GrapeCity.ActiveReports.SectionReportModel.PageFooter
    Private WithEvents txtFilters As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblLocationDetail As GrapeCity.ActiveReports.SectionReportModel.Label
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
    Private WithEvents lblNonstructural As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblPriorLossHistory As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFPGen As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblSSOV As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblSSBrace As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblHazMat As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblUGUtil As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblXform As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblSwitchgear As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblITTele As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblPipeCable As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblHVACCT As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblEmerRespRecoveryRating As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFilters As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblClientLocNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFacility As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents line2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line4 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line5 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line6 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line7 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line8 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line9 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line10 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line11 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line13 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line15 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line16 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line53 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line55 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line58 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line64 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtSort As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblReportDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents reportInfo1 As GrapeCity.ActiveReports.SectionReportModel.ReportInfo
    Private WithEvents txtSurveyDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtClientLocNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents textBox5 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtTIV As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents textBox4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFileNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtDivision As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFPGen As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSSOV As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSSBrace As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtHazMat As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtUGUtil As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtXform As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSwitchgear As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtITTele As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtPipeCable As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtHVACCT As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtEmerRespRecoveryRating As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFacility As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents line21 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line22 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line24 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line25 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line26 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line28 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line29 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line32 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line33 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line38 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line39 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line40 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line41 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line42 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line52 As GrapeCity.ActiveReports.SectionReportModel.Line
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
    Private WithEvents lblStorage As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents line18 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lblProcess As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents line20 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lblSlosses As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents line27 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtStorage As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSlosses As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents line36 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtProcess As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents line44 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line46 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line17 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line47 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtSNSOther As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblSNSOther As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents line12 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line19 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtDisclaimer As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents line56 As GrapeCity.ActiveReports.SectionReportModel.Line
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptNatHazSeismicAssessmentNonstructural))
        Me.PageHeader1 = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.lblSNSOther = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblStorage = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblProcess = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSlosses = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.picGRCLogo = New GrapeCity.ActiveReports.SectionReportModel.Picture()
        Me.txtFilters = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblLocationDetail = New GrapeCity.ActiveReports.SectionReportModel.Label()
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
        Me.lblNonstructural = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPriorLossHistory = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFPGen = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSSOV = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSSBrace = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblHazMat = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblUGUtil = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblXform = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSwitchgear = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblITTele = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPipeCable = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblHVACCT = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblEmerRespRecoveryRating = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFilters = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblClientLocNo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFacility = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line5 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line6 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line7 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line8 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line9 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line10 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line11 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line13 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line15 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line16 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line53 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line55 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line58 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line64 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line59 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line14 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line54 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line63 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line56 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line18 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line20 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line27 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line17 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line47 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line12 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Detail1 = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.txtSNSOther = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSlosses = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtStorage = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtProcess = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSurveyDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtClientLocNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.textBox5 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtTIV = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.textBox4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFileNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtDivision = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFPGen = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSSOV = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSSBrace = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtHazMat = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtUGUtil = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtXform = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSwitchgear = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtITTele = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPipeCable = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtHVACCT = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtEmerRespRecoveryRating = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFacility = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.line21 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line22 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line24 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line25 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line26 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line28 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line29 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line32 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line33 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line38 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line39 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line40 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line41 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line42 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line52 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line35 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line34 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.textBox2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line31 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtCountry = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.line30 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line36 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line44 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line46 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line19 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.PageFooter1 = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.txtSort = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblReportDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.reportInfo1 = New GrapeCity.ActiveReports.SectionReportModel.ReportInfo()
        Me.txtDisclaimer = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        CType(Me.lblSNSOther, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblProcess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSlosses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGRCLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblLocationDetail, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.lblNonstructural, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPriorLossHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFPGen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSSOV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSSBrace, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHazMat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblUGUtil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblXform, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSwitchgear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblITTele, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPipeCable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHVACCT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblEmerRespRecoveryRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblClientLocNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFacility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSNSOther, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSlosses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProcess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSurveyDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientLocNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTIV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFileNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDivision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFPGen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSSOV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSSBrace, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHazMat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUGUtil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtXform, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSwitchgear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtITTele, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPipeCable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHVACCT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmerRespRecoveryRating, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PageHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblSNSOther, Me.lblStorage, Me.lblProcess, Me.lblSlosses, Me.picGRCLogo, Me.txtFilters, Me.lblLocationDetail, Me.lblClientName, Me.lblReport, Me.lblFileNo, Me.lblTIVmillions, Me.lblCountry, Me.label7, Me.lblCity, Me.lblSurveyDate, Me.lblDivision, Me.lblAddress, Me.lblNonstructural, Me.lblPriorLossHistory, Me.lblFPGen, Me.lblSSOV, Me.lblSSBrace, Me.lblHazMat, Me.lblUGUtil, Me.lblXform, Me.lblSwitchgear, Me.lblITTele, Me.lblPipeCable, Me.lblHVACCT, Me.lblEmerRespRecoveryRating, Me.lblFilters, Me.lblClientLocNo, Me.lblFacility, Me.line2, Me.line4, Me.line5, Me.line6, Me.line7, Me.line8, Me.line9, Me.line10, Me.line11, Me.line13, Me.line15, Me.line16, Me.line53, Me.line55, Me.line58, Me.line64, Me.line59, Me.line14, Me.line54, Me.line63, Me.line56, Me.line18, Me.line20, Me.line27, Me.line17, Me.line47, Me.line12})
        Me.PageHeader1.Height = 1.55!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'lblSNSOther
        '
        Me.lblSNSOther.Height = 0.35!
        Me.lblSNSOther.HyperLink = Nothing
        Me.lblSNSOther.Left = 12.07!
        Me.lblSNSOther.Name = "lblSNSOther"
        Me.lblSNSOther.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblSNSOther.Text = "Other Exposures"
        Me.lblSNSOther.Top = 1.2!
        Me.lblSNSOther.Width = 0.55!
        '
        'lblStorage
        '
        Me.lblStorage.Height = 0.35!
        Me.lblStorage.HyperLink = Nothing
        Me.lblStorage.Left = 10.22!
        Me.lblStorage.Name = "lblStorage"
        Me.lblStorage.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblStorage.Text = "Storage"
        Me.lblStorage.Top = 1.2!
        Me.lblStorage.Width = 0.55!
        '
        'lblProcess
        '
        Me.lblProcess.Height = 0.35!
        Me.lblProcess.HyperLink = Nothing
        Me.lblProcess.Left = 10.77!
        Me.lblProcess.Name = "lblProcess"
        Me.lblProcess.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblProcess.Text = "Process Equip."
        Me.lblProcess.Top = 1.2!
        Me.lblProcess.Width = 0.55!
        '
        'lblSlosses
        '
        Me.lblSlosses.Height = 0.35!
        Me.lblSlosses.HyperLink = Nothing
        Me.lblSlosses.Left = 12.67!
        Me.lblSlosses.Name = "lblSlosses"
        Me.lblSlosses.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblSlosses.Text = "Prior Loss History"
        Me.lblSlosses.Top = 1.2!
        Me.lblSlosses.Width = 0.55!
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
        Me.txtFilters.Width = 12.78!
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
        Me.lblLocationDetail.Width = 4.37!
        '
        'lblClientName
        '
        Me.lblClientName.Height = 0.25!
        Me.lblClientName.HyperLink = Nothing
        Me.lblClientName.Left = 6.058!
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Style = "color: #C6D1DE; font-size: 16pt; font-style: italic; font-weight: bold; text-alig" & _
    "n: right; vertical-align: middle"
        Me.lblClientName.Text = "Company Name"
        Me.lblClientName.Top = 0.05!
        Me.lblClientName.Width = 7.162!
        '
        'lblReport
        '
        Me.lblReport.Height = 0.25!
        Me.lblReport.HyperLink = Nothing
        Me.lblReport.Left = 6.058!
        Me.lblReport.Name = "lblReport"
        Me.lblReport.Style = "font-size: 12pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblReport.Text = "Natural Hazards Seismic Assessment - Nonstructural"
        Me.lblReport.Top = 0.375!
        Me.lblReport.Width = 7.162!
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
        'lblNonstructural
        '
        Me.lblNonstructural.Height = 0.146!
        Me.lblNonstructural.HyperLink = Nothing
        Me.lblNonstructural.Left = 4.42!
        Me.lblNonstructural.Name = "lblNonstructural"
        Me.lblNonstructural.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblNonstructural.Text = "Nonstructural"
        Me.lblNonstructural.Top = 1.05!
        Me.lblNonstructural.Width = 8.2!
        '
        'lblPriorLossHistory
        '
        Me.lblPriorLossHistory.Height = 0.146!
        Me.lblPriorLossHistory.HyperLink = Nothing
        Me.lblPriorLossHistory.Left = 12.67!
        Me.lblPriorLossHistory.Name = "lblPriorLossHistory"
        Me.lblPriorLossHistory.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblPriorLossHistory.Text = ""
        Me.lblPriorLossHistory.Top = 1.05!
        Me.lblPriorLossHistory.Width = 0.55!
        '
        'lblFPGen
        '
        Me.lblFPGen.Height = 0.35!
        Me.lblFPGen.HyperLink = Nothing
        Me.lblFPGen.Left = 4.97!
        Me.lblFPGen.Name = "lblFPGen"
        Me.lblFPGen.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblFPGen.Text = "Fire Pump/ Generator Anchoring"
        Me.lblFPGen.Top = 1.2!
        Me.lblFPGen.Width = 0.6!
        '
        'lblSSOV
        '
        Me.lblSSOV.Height = 0.35!
        Me.lblSSOV.HyperLink = Nothing
        Me.lblSSOV.Left = 4.42!
        Me.lblSSOV.Name = "lblSSOV"
        Me.lblSSOV.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblSSOV.Text = "Seismic Shut-off Valves"
        Me.lblSSOV.Top = 1.2!
        Me.lblSSOV.Width = 0.55!
        '
        'lblSSBrace
        '
        Me.lblSSBrace.Height = 0.35!
        Me.lblSSBrace.HyperLink = Nothing
        Me.lblSSBrace.Left = 5.57!
        Me.lblSSBrace.Name = "lblSSBrace"
        Me.lblSSBrace.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblSSBrace.Text = "Sprinkler Sys. Bracing"
        Me.lblSSBrace.Top = 1.188!
        Me.lblSSBrace.Width = 0.55!
        '
        'lblHazMat
        '
        Me.lblHazMat.Height = 0.35!
        Me.lblHazMat.HyperLink = Nothing
        Me.lblHazMat.Left = 6.12!
        Me.lblHazMat.Name = "lblHazMat"
        Me.lblHazMat.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblHazMat.Text = "HazMat Monitoring Sys."
        Me.lblHazMat.Top = 1.2!
        Me.lblHazMat.Width = 0.55!
        '
        'lblUGUtil
        '
        Me.lblUGUtil.Height = 0.35!
        Me.lblUGUtil.HyperLink = Nothing
        Me.lblUGUtil.Left = 6.67!
        Me.lblUGUtil.Name = "lblUGUtil"
        Me.lblUGUtil.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblUGUtil.Text = "Underground Utilities"
        Me.lblUGUtil.Top = 1.2!
        Me.lblUGUtil.Width = 0.6!
        '
        'lblXform
        '
        Me.lblXform.Height = 0.35!
        Me.lblXform.HyperLink = Nothing
        Me.lblXform.Left = 7.27!
        Me.lblXform.Name = "lblXform"
        Me.lblXform.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblXform.Text = "Transformers/Electric Power Supply"
        Me.lblXform.Top = 1.2!
        Me.lblXform.Width = 0.65!
        '
        'lblSwitchgear
        '
        Me.lblSwitchgear.Height = 0.35!
        Me.lblSwitchgear.HyperLink = Nothing
        Me.lblSwitchgear.Left = 7.92!
        Me.lblSwitchgear.Name = "lblSwitchgear"
        Me.lblSwitchgear.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblSwitchgear.Text = "Switchgear"
        Me.lblSwitchgear.Top = 1.2!
        Me.lblSwitchgear.Width = 0.6!
        '
        'lblITTele
        '
        Me.lblITTele.Height = 0.35!
        Me.lblITTele.HyperLink = Nothing
        Me.lblITTele.Left = 8.52!
        Me.lblITTele.Name = "lblITTele"
        Me.lblITTele.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblITTele.Text = "IT/ Telecom Equip."
        Me.lblITTele.Top = 1.2!
        Me.lblITTele.Width = 0.55!
        '
        'lblPipeCable
        '
        Me.lblPipeCable.Height = 0.375!
        Me.lblPipeCable.HyperLink = Nothing
        Me.lblPipeCable.Left = 9.07!
        Me.lblPipeCable.Name = "lblPipeCable"
        Me.lblPipeCable.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblPipeCable.Text = "Piping and Cable Trays"
        Me.lblPipeCable.Top = 1.188!
        Me.lblPipeCable.Width = 0.6!
        '
        'lblHVACCT
        '
        Me.lblHVACCT.Height = 0.35!
        Me.lblHVACCT.HyperLink = Nothing
        Me.lblHVACCT.Left = 9.67!
        Me.lblHVACCT.Name = "lblHVACCT"
        Me.lblHVACCT.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblHVACCT.Text = "HVAC/ Cooling Towers"
        Me.lblHVACCT.Top = 1.2!
        Me.lblHVACCT.Width = 0.55!
        '
        'lblEmerRespRecoveryRating
        '
        Me.lblEmerRespRecoveryRating.Height = 0.35!
        Me.lblEmerRespRecoveryRating.HyperLink = Nothing
        Me.lblEmerRespRecoveryRating.Left = 11.32!
        Me.lblEmerRespRecoveryRating.Name = "lblEmerRespRecoveryRating"
        Me.lblEmerRespRecoveryRating.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblEmerRespRecoveryRating.Text = "Emerg. Resp./Recovery Plans"
        Me.lblEmerRespRecoveryRating.Top = 1.2!
        Me.lblEmerRespRecoveryRating.Width = 0.75!
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
        Me.line2.Left = 4.42!
        Me.line2.LineWeight = 1.0!
        Me.line2.Name = "line2"
        Me.line2.Top = 1.2!
        Me.line2.Width = 8.2!
        Me.line2.X1 = 4.42!
        Me.line2.X2 = 12.62!
        Me.line2.Y1 = 1.2!
        Me.line2.Y2 = 1.2!
        '
        'line4
        '
        Me.line4.Height = 0.5!
        Me.line4.Left = 4.42!
        Me.line4.LineWeight = 1.0!
        Me.line4.Name = "line4"
        Me.line4.Top = 1.05!
        Me.line4.Width = 0.0!
        Me.line4.X1 = 4.42!
        Me.line4.X2 = 4.42!
        Me.line4.Y1 = 1.05!
        Me.line4.Y2 = 1.55!
        '
        'line5
        '
        Me.line5.Height = 0.3499999!
        Me.line5.Left = 4.97!
        Me.line5.LineWeight = 1.0!
        Me.line5.Name = "line5"
        Me.line5.Top = 1.2!
        Me.line5.Width = 0.0!
        Me.line5.X1 = 4.97!
        Me.line5.X2 = 4.97!
        Me.line5.Y1 = 1.2!
        Me.line5.Y2 = 1.55!
        '
        'line6
        '
        Me.line6.Height = 0.3499999!
        Me.line6.Left = 5.57!
        Me.line6.LineWeight = 1.0!
        Me.line6.Name = "line6"
        Me.line6.Top = 1.2!
        Me.line6.Width = 0.0!
        Me.line6.X1 = 5.57!
        Me.line6.X2 = 5.57!
        Me.line6.Y1 = 1.2!
        Me.line6.Y2 = 1.55!
        '
        'line7
        '
        Me.line7.Height = 0.3499999!
        Me.line7.Left = 6.12!
        Me.line7.LineWeight = 1.0!
        Me.line7.Name = "line7"
        Me.line7.Top = 1.2!
        Me.line7.Width = 0.0!
        Me.line7.X1 = 6.12!
        Me.line7.X2 = 6.12!
        Me.line7.Y1 = 1.2!
        Me.line7.Y2 = 1.55!
        '
        'line8
        '
        Me.line8.Height = 0.3499999!
        Me.line8.Left = 6.67!
        Me.line8.LineWeight = 1.0!
        Me.line8.Name = "line8"
        Me.line8.Top = 1.2!
        Me.line8.Width = 0.0!
        Me.line8.X1 = 6.67!
        Me.line8.X2 = 6.67!
        Me.line8.Y1 = 1.2!
        Me.line8.Y2 = 1.55!
        '
        'line9
        '
        Me.line9.Height = 0.3499999!
        Me.line9.Left = 7.27!
        Me.line9.LineWeight = 1.0!
        Me.line9.Name = "line9"
        Me.line9.Top = 1.2!
        Me.line9.Width = 0.0!
        Me.line9.X1 = 7.27!
        Me.line9.X2 = 7.27!
        Me.line9.Y1 = 1.2!
        Me.line9.Y2 = 1.55!
        '
        'line10
        '
        Me.line10.Height = 0.5!
        Me.line10.Left = 12.62!
        Me.line10.LineWeight = 1.0!
        Me.line10.Name = "line10"
        Me.line10.Top = 1.05!
        Me.line10.Width = 0.0!
        Me.line10.X1 = 12.62!
        Me.line10.X2 = 12.62!
        Me.line10.Y1 = 1.05!
        Me.line10.Y2 = 1.55!
        '
        'line11
        '
        Me.line11.Height = 0.3499999!
        Me.line11.Left = 9.07!
        Me.line11.LineWeight = 1.0!
        Me.line11.Name = "line11"
        Me.line11.Top = 1.2!
        Me.line11.Width = 0.0!
        Me.line11.X1 = 9.07!
        Me.line11.X2 = 9.07!
        Me.line11.Y1 = 1.2!
        Me.line11.Y2 = 1.55!
        '
        'line13
        '
        Me.line13.Height = 0.3499999!
        Me.line13.Left = 9.67!
        Me.line13.LineWeight = 1.0!
        Me.line13.Name = "line13"
        Me.line13.Top = 1.2!
        Me.line13.Width = 0.0!
        Me.line13.X1 = 9.67!
        Me.line13.X2 = 9.67!
        Me.line13.Y1 = 1.2!
        Me.line13.Y2 = 1.55!
        '
        'line15
        '
        Me.line15.Height = 0.3499999!
        Me.line15.Left = 7.92!
        Me.line15.LineWeight = 1.0!
        Me.line15.Name = "line15"
        Me.line15.Top = 1.2!
        Me.line15.Width = 0.0!
        Me.line15.X1 = 7.92!
        Me.line15.X2 = 7.92!
        Me.line15.Y1 = 1.2!
        Me.line15.Y2 = 1.55!
        '
        'line16
        '
        Me.line16.Height = 0.0!
        Me.line16.Left = 12.67!
        Me.line16.LineWeight = 1.0!
        Me.line16.Name = "line16"
        Me.line16.Top = 1.2!
        Me.line16.Width = 0.5500002!
        Me.line16.X1 = 12.67!
        Me.line16.X2 = 13.22!
        Me.line16.Y1 = 1.2!
        Me.line16.Y2 = 1.2!
        '
        'line53
        '
        Me.line53.Height = 0.0!
        Me.line53.Left = 4.42!
        Me.line53.LineWeight = 1.0!
        Me.line53.Name = "line53"
        Me.line53.Top = 1.05!
        Me.line53.Width = 8.2!
        Me.line53.X1 = 4.42!
        Me.line53.X2 = 12.62!
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
        Me.line55.Width = 4.37!
        Me.line55.X1 = 0.0!
        Me.line55.X2 = 4.37!
        Me.line55.Y1 = 1.05!
        Me.line55.Y2 = 1.05!
        '
        'line58
        '
        Me.line58.Height = 0.5!
        Me.line58.Left = 4.37!
        Me.line58.LineWeight = 1.0!
        Me.line58.Name = "line58"
        Me.line58.Top = 1.05!
        Me.line58.Width = 0.0!
        Me.line58.X1 = 4.37!
        Me.line58.X2 = 4.37!
        Me.line58.Y1 = 1.05!
        Me.line58.Y2 = 1.55!
        '
        'line64
        '
        Me.line64.Height = 0.0!
        Me.line64.Left = 12.67!
        Me.line64.LineWeight = 1.0!
        Me.line64.Name = "line64"
        Me.line64.Top = 1.05!
        Me.line64.Width = 0.5500002!
        Me.line64.X1 = 12.67!
        Me.line64.X2 = 13.22!
        Me.line64.Y1 = 1.05!
        Me.line64.Y2 = 1.05!
        '
        'line59
        '
        Me.line59.Height = 0.5!
        Me.line59.Left = 0.0!
        Me.line59.LineWeight = 1.0!
        Me.line59.Name = "line59"
        Me.line59.Top = 1.05!
        Me.line59.Width = 0.0!
        Me.line59.X1 = 0.0!
        Me.line59.X2 = 0.0!
        Me.line59.Y1 = 1.05!
        Me.line59.Y2 = 1.55!
        '
        'line14
        '
        Me.line14.Height = 0.3499999!
        Me.line14.Left = 8.52!
        Me.line14.LineWeight = 1.0!
        Me.line14.Name = "line14"
        Me.line14.Top = 1.2!
        Me.line14.Width = 0.0!
        Me.line14.X1 = 8.52!
        Me.line14.X2 = 8.52!
        Me.line14.Y1 = 1.2!
        Me.line14.Y2 = 1.55!
        '
        'line54
        '
        Me.line54.Height = 0.0!
        Me.line54.Left = 4.42!
        Me.line54.LineWeight = 1.0!
        Me.line54.Name = "line54"
        Me.line54.Top = 1.55!
        Me.line54.Width = 8.2!
        Me.line54.X1 = 4.42!
        Me.line54.X2 = 12.62!
        Me.line54.Y1 = 1.55!
        Me.line54.Y2 = 1.55!
        '
        'line63
        '
        Me.line63.Height = 0.0!
        Me.line63.Left = 12.67!
        Me.line63.LineWeight = 1.0!
        Me.line63.Name = "line63"
        Me.line63.Top = 1.55!
        Me.line63.Width = 0.5500002!
        Me.line63.X1 = 12.67!
        Me.line63.X2 = 13.22!
        Me.line63.Y1 = 1.55!
        Me.line63.Y2 = 1.55!
        '
        'line56
        '
        Me.line56.Height = 0.0!
        Me.line56.Left = 0.0!
        Me.line56.LineWeight = 1.0!
        Me.line56.Name = "line56"
        Me.line56.Top = 1.55!
        Me.line56.Width = 4.37!
        Me.line56.X1 = 0.0!
        Me.line56.X2 = 4.37!
        Me.line56.Y1 = 1.55!
        Me.line56.Y2 = 1.55!
        '
        'line18
        '
        Me.line18.Height = 0.3499999!
        Me.line18.Left = 11.32!
        Me.line18.LineWeight = 1.0!
        Me.line18.Name = "line18"
        Me.line18.Top = 1.2!
        Me.line18.Width = 0.0!
        Me.line18.X1 = 11.32!
        Me.line18.X2 = 11.32!
        Me.line18.Y1 = 1.2!
        Me.line18.Y2 = 1.55!
        '
        'line20
        '
        Me.line20.Height = 0.3499999!
        Me.line20.Left = 10.77!
        Me.line20.LineWeight = 1.0!
        Me.line20.Name = "line20"
        Me.line20.Top = 1.2!
        Me.line20.Width = 0.0!
        Me.line20.X1 = 10.77!
        Me.line20.X2 = 10.77!
        Me.line20.Y1 = 1.2!
        Me.line20.Y2 = 1.55!
        '
        'line27
        '
        Me.line27.Height = 0.3499999!
        Me.line27.Left = 10.22!
        Me.line27.LineWeight = 1.0!
        Me.line27.Name = "line27"
        Me.line27.Top = 1.2!
        Me.line27.Width = 0.0!
        Me.line27.X1 = 10.22!
        Me.line27.X2 = 10.22!
        Me.line27.Y1 = 1.2!
        Me.line27.Y2 = 1.55!
        '
        'line17
        '
        Me.line17.Height = 0.5!
        Me.line17.Left = 13.22!
        Me.line17.LineWeight = 1.0!
        Me.line17.Name = "line17"
        Me.line17.Top = 1.05!
        Me.line17.Width = 0.0!
        Me.line17.X1 = 13.22!
        Me.line17.X2 = 13.22!
        Me.line17.Y1 = 1.05!
        Me.line17.Y2 = 1.55!
        '
        'line47
        '
        Me.line47.Height = 0.3499999!
        Me.line47.Left = 12.07!
        Me.line47.LineWeight = 1.0!
        Me.line47.Name = "line47"
        Me.line47.Top = 1.2!
        Me.line47.Width = 0.0!
        Me.line47.X1 = 12.07!
        Me.line47.X2 = 12.07!
        Me.line47.Y1 = 1.2!
        Me.line47.Y2 = 1.55!
        '
        'line12
        '
        Me.line12.Height = 0.5!
        Me.line12.Left = 12.67!
        Me.line12.LineWeight = 1.0!
        Me.line12.Name = "line12"
        Me.line12.Top = 1.05!
        Me.line12.Width = 0.0!
        Me.line12.X1 = 12.67!
        Me.line12.X2 = 12.67!
        Me.line12.Y1 = 1.05!
        Me.line12.Y2 = 1.55!
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtSNSOther, Me.txtSlosses, Me.txtStorage, Me.txtProcess, Me.txtSurveyDate, Me.txtClientLocNo, Me.textBox5, Me.txtTIV, Me.textBox4, Me.txtFileNo, Me.txtDivision, Me.txtFPGen, Me.txtSSOV, Me.txtSSBrace, Me.txtHazMat, Me.txtUGUtil, Me.txtXform, Me.txtSwitchgear, Me.txtITTele, Me.txtPipeCable, Me.txtHVACCT, Me.txtEmerRespRecoveryRating, Me.txtFacility, Me.line21, Me.line22, Me.line24, Me.line25, Me.line26, Me.line28, Me.line29, Me.line32, Me.line33, Me.line38, Me.line39, Me.line40, Me.line41, Me.line42, Me.line52, Me.line35, Me.line34, Me.textBox2, Me.line1, Me.line31, Me.txtCountry, Me.line30, Me.line3, Me.line36, Me.line44, Me.line46, Me.line19})
        Me.Detail1.Height = 0.3625!
        Me.Detail1.Name = "Detail1"
        '
        'txtSNSOther
        '
        Me.txtSNSOther.DataField = "SNSOther"
        Me.txtSNSOther.Height = 0.3!
        Me.txtSNSOther.Left = 12.07!
        Me.txtSNSOther.Name = "txtSNSOther"
        Me.txtSNSOther.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtSNSOther.Text = "SNSOther"
        Me.txtSNSOther.Top = 0.05!
        Me.txtSNSOther.Width = 0.55!
        '
        'txtSlosses
        '
        Me.txtSlosses.DataField = "Slosses"
        Me.txtSlosses.Height = 0.3!
        Me.txtSlosses.Left = 12.67!
        Me.txtSlosses.Name = "txtSlosses"
        Me.txtSlosses.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtSlosses.Text = "Slosses"
        Me.txtSlosses.Top = 0.05!
        Me.txtSlosses.Width = 0.55!
        '
        'txtStorage
        '
        Me.txtStorage.DataField = "Storage"
        Me.txtStorage.Height = 0.3!
        Me.txtStorage.Left = 10.22!
        Me.txtStorage.Name = "txtStorage"
        Me.txtStorage.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtStorage.Text = "Storage"
        Me.txtStorage.Top = 0.05!
        Me.txtStorage.Width = 0.55!
        '
        'txtProcess
        '
        Me.txtProcess.DataField = "Process"
        Me.txtProcess.Height = 0.3!
        Me.txtProcess.Left = 10.77!
        Me.txtProcess.Name = "txtProcess"
        Me.txtProcess.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtProcess.Text = "Process"
        Me.txtProcess.Top = 0.05!
        Me.txtProcess.Width = 0.55!
        '
        'txtSurveyDate
        '
        Me.txtSurveyDate.CanGrow = False
        Me.txtSurveyDate.DataField = "SurveyDate"
        Me.txtSurveyDate.Height = 0.15!
        Me.txtSurveyDate.Left = 0.52!
        Me.txtSurveyDate.MultiLine = False
        Me.txtSurveyDate.Name = "txtSurveyDate"
        Me.txtSurveyDate.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
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
        'txtFPGen
        '
        Me.txtFPGen.DataField = "FPGen"
        Me.txtFPGen.Height = 0.3!
        Me.txtFPGen.Left = 4.97!
        Me.txtFPGen.Name = "txtFPGen"
        Me.txtFPGen.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtFPGen.Text = "FPGen"
        Me.txtFPGen.Top = 0.05!
        Me.txtFPGen.Width = 0.6!
        '
        'txtSSOV
        '
        Me.txtSSOV.DataField = "SSOV"
        Me.txtSSOV.Height = 0.3!
        Me.txtSSOV.Left = 4.42!
        Me.txtSSOV.Name = "txtSSOV"
        Me.txtSSOV.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtSSOV.Text = "SSOV"
        Me.txtSSOV.Top = 0.05!
        Me.txtSSOV.Width = 0.55!
        '
        'txtSSBrace
        '
        Me.txtSSBrace.DataField = "SSBrace"
        Me.txtSSBrace.Height = 0.3!
        Me.txtSSBrace.Left = 5.57!
        Me.txtSSBrace.Name = "txtSSBrace"
        Me.txtSSBrace.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtSSBrace.Text = "SSBrace"
        Me.txtSSBrace.Top = 0.05!
        Me.txtSSBrace.Width = 0.55!
        '
        'txtHazMat
        '
        Me.txtHazMat.DataField = "HazMat"
        Me.txtHazMat.Height = 0.3!
        Me.txtHazMat.Left = 6.12!
        Me.txtHazMat.Name = "txtHazMat"
        Me.txtHazMat.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtHazMat.Text = "HazMat"
        Me.txtHazMat.Top = 0.05!
        Me.txtHazMat.Width = 0.55!
        '
        'txtUGUtil
        '
        Me.txtUGUtil.DataField = "UGUtil"
        Me.txtUGUtil.Height = 0.3!
        Me.txtUGUtil.Left = 6.67!
        Me.txtUGUtil.Name = "txtUGUtil"
        Me.txtUGUtil.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtUGUtil.Text = "UGUtil"
        Me.txtUGUtil.Top = 0.05!
        Me.txtUGUtil.Width = 0.6!
        '
        'txtXform
        '
        Me.txtXform.DataField = "Xform"
        Me.txtXform.Height = 0.3!
        Me.txtXform.Left = 7.27!
        Me.txtXform.Name = "txtXform"
        Me.txtXform.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtXform.Text = "Xform"
        Me.txtXform.Top = 0.05!
        Me.txtXform.Width = 0.65!
        '
        'txtSwitchgear
        '
        Me.txtSwitchgear.DataField = "Switchgear"
        Me.txtSwitchgear.Height = 0.3!
        Me.txtSwitchgear.Left = 7.92!
        Me.txtSwitchgear.Name = "txtSwitchgear"
        Me.txtSwitchgear.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtSwitchgear.Text = "Switchgear"
        Me.txtSwitchgear.Top = 0.05!
        Me.txtSwitchgear.Width = 0.6!
        '
        'txtITTele
        '
        Me.txtITTele.DataField = "ITTele"
        Me.txtITTele.Height = 0.3!
        Me.txtITTele.Left = 8.52!
        Me.txtITTele.Name = "txtITTele"
        Me.txtITTele.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtITTele.Text = "ITTele"
        Me.txtITTele.Top = 0.05!
        Me.txtITTele.Width = 0.55!
        '
        'txtPipeCable
        '
        Me.txtPipeCable.DataField = "PipeCable"
        Me.txtPipeCable.Height = 0.3!
        Me.txtPipeCable.Left = 9.07!
        Me.txtPipeCable.Name = "txtPipeCable"
        Me.txtPipeCable.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtPipeCable.Text = "PipeCable"
        Me.txtPipeCable.Top = 0.05!
        Me.txtPipeCable.Width = 0.6!
        '
        'txtHVACCT
        '
        Me.txtHVACCT.DataField = "HVACCT"
        Me.txtHVACCT.Height = 0.3!
        Me.txtHVACCT.Left = 9.67!
        Me.txtHVACCT.Name = "txtHVACCT"
        Me.txtHVACCT.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtHVACCT.Text = "HVACCT"
        Me.txtHVACCT.Top = 0.05!
        Me.txtHVACCT.Width = 0.55!
        '
        'txtEmerRespRecoveryRating
        '
        Me.txtEmerRespRecoveryRating.DataField = "EmerRespRecoveryRating"
        Me.txtEmerRespRecoveryRating.Height = 0.3!
        Me.txtEmerRespRecoveryRating.Left = 11.32!
        Me.txtEmerRespRecoveryRating.Name = "txtEmerRespRecoveryRating"
        Me.txtEmerRespRecoveryRating.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtEmerRespRecoveryRating.Text = "EmerRespRecoveryRating"
        Me.txtEmerRespRecoveryRating.Top = 0.05!
        Me.txtEmerRespRecoveryRating.Width = 0.75!
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
        Me.line21.Left = 4.97!
        Me.line21.LineWeight = 1.0!
        Me.line21.Name = "line21"
        Me.line21.Top = 0.05!
        Me.line21.Width = 0.0!
        Me.line21.X1 = 4.97!
        Me.line21.X2 = 4.97!
        Me.line21.Y1 = 0.05!
        Me.line21.Y2 = 0.35!
        '
        'line22
        '
        Me.line22.Height = 0.3!
        Me.line22.Left = 5.57!
        Me.line22.LineWeight = 1.0!
        Me.line22.Name = "line22"
        Me.line22.Top = 0.05!
        Me.line22.Width = 0.0!
        Me.line22.X1 = 5.57!
        Me.line22.X2 = 5.57!
        Me.line22.Y1 = 0.05!
        Me.line22.Y2 = 0.35!
        '
        'line24
        '
        Me.line24.Height = 0.3!
        Me.line24.Left = 6.12!
        Me.line24.LineWeight = 1.0!
        Me.line24.Name = "line24"
        Me.line24.Top = 0.05!
        Me.line24.Width = 0.0!
        Me.line24.X1 = 6.12!
        Me.line24.X2 = 6.12!
        Me.line24.Y1 = 0.05!
        Me.line24.Y2 = 0.35!
        '
        'line25
        '
        Me.line25.Height = 0.3!
        Me.line25.Left = 6.67!
        Me.line25.LineWeight = 1.0!
        Me.line25.Name = "line25"
        Me.line25.Top = 0.05!
        Me.line25.Width = 0.0!
        Me.line25.X1 = 6.67!
        Me.line25.X2 = 6.67!
        Me.line25.Y1 = 0.05!
        Me.line25.Y2 = 0.35!
        '
        'line26
        '
        Me.line26.Height = 0.3!
        Me.line26.Left = 7.27!
        Me.line26.LineWeight = 1.0!
        Me.line26.Name = "line26"
        Me.line26.Top = 0.05!
        Me.line26.Width = 0.0!
        Me.line26.X1 = 7.27!
        Me.line26.X2 = 7.27!
        Me.line26.Y1 = 0.05!
        Me.line26.Y2 = 0.35!
        '
        'line28
        '
        Me.line28.Height = 0.3!
        Me.line28.Left = 4.42!
        Me.line28.LineWeight = 1.0!
        Me.line28.Name = "line28"
        Me.line28.Top = 0.05!
        Me.line28.Width = 0.0!
        Me.line28.X1 = 4.42!
        Me.line28.X2 = 4.42!
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
        Me.line32.Left = 4.42!
        Me.line32.LineWeight = 1.0!
        Me.line32.Name = "line32"
        Me.line32.Top = 0.35!
        Me.line32.Width = 8.2!
        Me.line32.X1 = 4.42!
        Me.line32.X2 = 12.62!
        Me.line32.Y1 = 0.35!
        Me.line32.Y2 = 0.35!
        '
        'line33
        '
        Me.line33.Height = 0.0!
        Me.line33.Left = 12.67!
        Me.line33.LineWeight = 1.0!
        Me.line33.Name = "line33"
        Me.line33.Top = 0.35!
        Me.line33.Width = 0.5500002!
        Me.line33.X1 = 12.67!
        Me.line33.X2 = 13.22!
        Me.line33.Y1 = 0.35!
        Me.line33.Y2 = 0.35!
        '
        'line38
        '
        Me.line38.Height = 0.3!
        Me.line38.Left = 12.62!
        Me.line38.LineWeight = 1.0!
        Me.line38.Name = "line38"
        Me.line38.Top = 0.05!
        Me.line38.Width = 0.0!
        Me.line38.X1 = 12.62!
        Me.line38.X2 = 12.62!
        Me.line38.Y1 = 0.05!
        Me.line38.Y2 = 0.35!
        '
        'line39
        '
        Me.line39.Height = 0.3!
        Me.line39.Left = 9.07!
        Me.line39.LineWeight = 1.0!
        Me.line39.Name = "line39"
        Me.line39.Top = 0.05!
        Me.line39.Width = 0.0!
        Me.line39.X1 = 9.07!
        Me.line39.X2 = 9.07!
        Me.line39.Y1 = 0.05!
        Me.line39.Y2 = 0.35!
        '
        'line40
        '
        Me.line40.Height = 0.3!
        Me.line40.Left = 9.67!
        Me.line40.LineWeight = 1.0!
        Me.line40.Name = "line40"
        Me.line40.Top = 0.05!
        Me.line40.Width = 0.0!
        Me.line40.X1 = 9.67!
        Me.line40.X2 = 9.67!
        Me.line40.Y1 = 0.05!
        Me.line40.Y2 = 0.35!
        '
        'line41
        '
        Me.line41.Height = 0.3!
        Me.line41.Left = 10.22!
        Me.line41.LineWeight = 1.0!
        Me.line41.Name = "line41"
        Me.line41.Top = 0.05!
        Me.line41.Width = 0.0!
        Me.line41.X1 = 10.22!
        Me.line41.X2 = 10.22!
        Me.line41.Y1 = 0.05!
        Me.line41.Y2 = 0.35!
        '
        'line42
        '
        Me.line42.Height = 0.3!
        Me.line42.Left = 10.77!
        Me.line42.LineWeight = 1.0!
        Me.line42.Name = "line42"
        Me.line42.Top = 0.05!
        Me.line42.Width = 0.0!
        Me.line42.X1 = 10.77!
        Me.line42.X2 = 10.77!
        Me.line42.Y1 = 0.05!
        Me.line42.Y2 = 0.35!
        '
        'line52
        '
        Me.line52.Height = 0.3!
        Me.line52.Left = 13.22!
        Me.line52.LineWeight = 1.0!
        Me.line52.Name = "line52"
        Me.line52.Top = 0.05!
        Me.line52.Width = 0.0!
        Me.line52.X1 = 13.22!
        Me.line52.X2 = 13.22!
        Me.line52.Y1 = 0.05!
        Me.line52.Y2 = 0.35!
        '
        'line35
        '
        Me.line35.Height = 0.0!
        Me.line35.Left = 4.42!
        Me.line35.LineWeight = 1.0!
        Me.line35.Name = "line35"
        Me.line35.Top = 0.05!
        Me.line35.Width = 8.2!
        Me.line35.X1 = 4.42!
        Me.line35.X2 = 12.62!
        Me.line35.Y1 = 0.05!
        Me.line35.Y2 = 0.05!
        '
        'line34
        '
        Me.line34.Height = 0.0!
        Me.line34.Left = 12.67!
        Me.line34.LineWeight = 1.0!
        Me.line34.Name = "line34"
        Me.line34.Top = 0.05!
        Me.line34.Width = 0.5500002!
        Me.line34.X1 = 12.67!
        Me.line34.X2 = 13.22!
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
        Me.line31.Width = 4.37!
        Me.line31.X1 = 0.0!
        Me.line31.X2 = 4.37!
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
        Me.line30.Width = 4.37!
        Me.line30.X1 = 0.0!
        Me.line30.X2 = 4.37!
        Me.line30.Y1 = 0.05!
        Me.line30.Y2 = 0.05!
        '
        'line3
        '
        Me.line3.Height = 0.3!
        Me.line3.Left = 7.92!
        Me.line3.LineWeight = 1.0!
        Me.line3.Name = "line3"
        Me.line3.Top = 0.05!
        Me.line3.Width = 0.0!
        Me.line3.X1 = 7.92!
        Me.line3.X2 = 7.92!
        Me.line3.Y1 = 0.05!
        Me.line3.Y2 = 0.35!
        '
        'line36
        '
        Me.line36.Height = 0.3!
        Me.line36.Left = 12.07!
        Me.line36.LineWeight = 1.0!
        Me.line36.Name = "line36"
        Me.line36.Top = 0.05!
        Me.line36.Width = 0.0!
        Me.line36.X1 = 12.07!
        Me.line36.X2 = 12.07!
        Me.line36.Y1 = 0.05!
        Me.line36.Y2 = 0.35!
        '
        'line44
        '
        Me.line44.Height = 0.3!
        Me.line44.Left = 11.32!
        Me.line44.LineWeight = 1.0!
        Me.line44.Name = "line44"
        Me.line44.Top = 0.05!
        Me.line44.Width = 0.0!
        Me.line44.X1 = 11.32!
        Me.line44.X2 = 11.32!
        Me.line44.Y1 = 0.05!
        Me.line44.Y2 = 0.35!
        '
        'line46
        '
        Me.line46.Height = 0.3!
        Me.line46.Left = 8.52!
        Me.line46.LineWeight = 1.0!
        Me.line46.Name = "line46"
        Me.line46.Top = 0.05!
        Me.line46.Width = 0.0!
        Me.line46.X1 = 8.52!
        Me.line46.X2 = 8.52!
        Me.line46.Y1 = 0.05!
        Me.line46.Y2 = 0.35!
        '
        'line19
        '
        Me.line19.Height = 0.3!
        Me.line19.Left = 12.67!
        Me.line19.LineWeight = 1.0!
        Me.line19.Name = "line19"
        Me.line19.Top = 0.05!
        Me.line19.Width = 0.0!
        Me.line19.X1 = 12.67!
        Me.line19.X2 = 12.67!
        Me.line19.Y1 = 0.05!
        Me.line19.Y2 = 0.35!
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
        Me.txtSort.Style = "font-size: 7pt; font-style: italic; text-align: center; vertical-align: middle"
        Me.txtSort.Text = "Sort"
        Me.txtSort.Top = 0.0!
        Me.txtSort.Width = 13.22!
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
        Me.reportInfo1.Left = 11.22!
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
        Me.txtDisclaimer.Width = 13.22!
        '
        'rptNatHazSeismicAssessmentNonstructural
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.25!
        Me.PageSettings.Margins.Left = 0.39!
        Me.PageSettings.Margins.Right = 0.39!
        Me.PageSettings.Margins.Top = 0.25!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 14.0!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Legal
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 13.22!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Calibri; font-style: normal; text-decoration: none; font-weight: nor" & _
            "mal; font-size: 10pt; color: Black", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
            "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.lblSNSOther, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblProcess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSlosses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGRCLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblLocationDetail, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.lblNonstructural, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPriorLossHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFPGen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSSOV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSSBrace, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHazMat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblUGUtil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblXform, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSwitchgear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblITTele, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPipeCable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHVACCT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblEmerRespRecoveryRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblClientLocNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFacility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSNSOther, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSlosses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProcess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSurveyDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientLocNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTIV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFileNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDivision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFPGen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSSOV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSSBrace, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHazMat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUGUtil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtXform, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSwitchgear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtITTele, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPipeCable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHVACCT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmerRespRecoveryRating, System.ComponentModel.ISupportInitialize).EndInit()
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

    Private Sub rptNatHazSeismicAssessmentNonstructural_FetchData(ByVal sender As Object, ByVal eArgs As FetchEventArgs) Handles Me.FetchData
        Dim zRiskControls() As ARControl = {txtSlosses}
        Dim zTextControls() As ARControl = {
                                            txtSSOV,
                                            txtFPGen,
                                            txtSSBrace,
                                            txtHazMat,
                                            txtUGUtil,
                                            txtXform,
                                            txtSwitchgear,
                                            txtITTele,
                                            txtPipeCable,
                                            txtHVACCT,
                                            txtStorage,
                                            txtProcess,
                                            txtEmerRespRecoveryRating,
                                            txtSNSOther
                                            }

        UtilReport.ActiveReport.SetItemBackColorByExposure(Me, zRiskControls, rptProperties)
        UtilReport.ActiveReport.SetItemBackColorByText(Me, zTextControls, rptProperties)
    End Sub

    Private Sub rptNatHazSeismicAssessmentNonstructural_ReportStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportStart
        lblClientName.Text = rptProperties.ClientName
        lblReportDate.Text = Now
        lblTIVmillions.Text = "TIV " & rptProperties.Currency.colFldCode & vbLf & "(millions)"
    End Sub

    Private Sub rptNatHazSeismicAssessmentNonstructural_PageStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.PageStart
        UtilReport.ActiveReport.SetFilter(Me, rptProperties)
        UtilReport.ActiveReport.SetSort(Me, rptProperties)
        UtilReport.ActiveReport.SetDisclaimer(Me, rptProperties)
    End Sub

    Private Sub rptNatHazSeismicAssessmentNonstructural_ReportEnd(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportEnd
        DisposeParameters()
    End Sub

    Private Sub DisposeParameters()
        DataSource = Nothing
    End Sub

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties

End Class
