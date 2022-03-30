Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports

Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing

Public Class rptFireBMFacilityRatingSummary
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
    Private WithEvents lblReportName As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtFilters As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblFilters As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtAddress As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtDivision2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFileNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSurveyDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCity As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents textBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents textBox2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtTIV As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFacility As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtClientLocNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents line38 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line39 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line40 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line44 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtAPL As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtAPLFactor As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtAPLWithAllRecsComplete As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtAPLFactorWithAllRecsComplete As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtPassiveScore As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtActiveScore As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtActiveScoreWithRecsComplete As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtTotalScore As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtOverallScoreWithRecsComplete As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtOverallPlantRating As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtOverallPlantRatingWithRecsComplete As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblReportDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtSort As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtPageNo As GrapeCity.ActiveReports.SectionReportModel.ReportInfo
    Private WithEvents picGRCLogo As GrapeCity.ActiveReports.SectionReportModel.Picture
    Private WithEvents txtRecsCompletedFactor As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtPassiveWRecs As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TextBox4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtActiveWRecs As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCurrentScore As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCurrentFactor As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtRecsCompletedScore As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TextBox3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblLocationInformation As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFileNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblDivision2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblInspectionDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblClientLocNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFacility As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCity As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtSTProv As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCountry As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblTIVGrid As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblAddress As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents line56 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line59 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents label8 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblAPL As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label10 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label11 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label12 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblAPLRecsComplete As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label14 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label15 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label16 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label17 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label18 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label19 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label20 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label21 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label22 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label23 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents line4 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblPassiveScore As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblPassiveWRecs As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblActiveScore As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblActiveWRecs As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label6 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label7 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents Line2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtDisclaimer As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Label9 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label13 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents PageFooter1 As GrapeCity.ActiveReports.SectionReportModel.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptFireBMFacilityRatingSummary))
        Me.PageHeader1 = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.lblClientName = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblReportName = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtFilters = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblFilters = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.picGRCLogo = New GrapeCity.ActiveReports.SectionReportModel.Picture()
        Me.lblLocationInformation = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFileNo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblDivision2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblInspectionDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblClientLocNo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFacility = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblCity = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtSTProv = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCountry = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblTIVGrid = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblAddress = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.line56 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line59 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.label8 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblAPL = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label10 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label11 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label12 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblAPLRecsComplete = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label14 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label15 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label16 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label17 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label18 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label19 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label20 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label21 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label22 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label23 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.line4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPassiveScore = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPassiveWRecs = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblActiveScore = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblActiveWRecs = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label6 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label7 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Detail1 = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.txtAddress = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtDivision2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFileNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSurveyDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCity = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.textBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.textBox2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtTIV = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFacility = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtClientLocNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.line38 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line39 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line40 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line44 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtAPL = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtAPLFactor = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtAPLWithAllRecsComplete = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtAPLFactorWithAllRecsComplete = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPassiveScore = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtActiveScore = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtActiveScoreWithRecsComplete = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtTotalScore = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtOverallScoreWithRecsComplete = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtOverallPlantRating = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtOverallPlantRatingWithRecsComplete = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtRecsCompletedFactor = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPassiveWRecs = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtActiveWRecs = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCurrentScore = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCurrentFactor = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtRecsCompletedScore = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.PageFooter1 = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.lblReportDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtSort = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPageNo = New GrapeCity.ActiveReports.SectionReportModel.ReportInfo()
        Me.txtDisclaimer = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label9 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label13 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        CType(Me.lblClientName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblReportName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGRCLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblLocationInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFileNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDivision2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblInspectionDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblClientLocNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFacility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSTProv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTIVGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAPL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAPLRecsComplete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPassiveScore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPassiveWRecs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblActiveScore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblActiveWRecs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDivision2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFileNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSurveyDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTIV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFacility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientLocNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAPL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAPLFactor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAPLWithAllRecsComplete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAPLFactorWithAllRecsComplete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassiveScore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActiveScore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActiveScoreWithRecsComplete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalScore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOverallScoreWithRecsComplete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOverallPlantRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOverallPlantRatingWithRecsComplete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRecsCompletedFactor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassiveWRecs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActiveWRecs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCurrentScore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCurrentFactor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRecsCompletedScore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblReportDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPageNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisclaimer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.CanShrink = True
        Me.PageHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblClientName, Me.lblReportName, Me.txtFilters, Me.lblFilters, Me.picGRCLogo, Me.lblLocationInformation, Me.lblFileNo, Me.lblDivision2, Me.lblInspectionDate, Me.lblClientLocNo, Me.lblFacility, Me.lblCity, Me.txtSTProv, Me.txtCountry, Me.lblTIVGrid, Me.lblAddress, Me.line56, Me.line59, Me.label8, Me.lblAPL, Me.label10, Me.label11, Me.label12, Me.lblAPLRecsComplete, Me.label14, Me.label15, Me.label16, Me.label17, Me.label18, Me.label19, Me.label20, Me.label21, Me.label22, Me.label23, Me.line4, Me.Label1, Me.lblPassiveScore, Me.lblPassiveWRecs, Me.lblActiveScore, Me.lblActiveWRecs, Me.Label2, Me.Label3, Me.Label4, Me.Label5, Me.Label6, Me.Label7, Me.Line1, Me.Line2, Me.Label9, Me.Label13})
        Me.PageHeader1.Height = 1.648!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'lblClientName
        '
        Me.lblClientName.Height = 0.25!
        Me.lblClientName.HyperLink = Nothing
        Me.lblClientName.Left = 8.567!
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Style = "color: #C6D1DE; font-size: 16pt; font-style: italic; font-weight: bold; text-alig" & _
    "n: right; vertical-align: middle"
        Me.lblClientName.Text = "Company Name"
        Me.lblClientName.Top = 0.0!
        Me.lblClientName.Width = 4.3!
        '
        'lblReportName
        '
        Me.lblReportName.Height = 0.25!
        Me.lblReportName.HyperLink = Nothing
        Me.lblReportName.Left = 8.567!
        Me.lblReportName.Name = "lblReportName"
        Me.lblReportName.Style = "font-size: 12pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblReportName.Text = "Fire and B&M Facility Rating Summary"
        Me.lblReportName.Top = 0.3!
        Me.lblReportName.Width = 4.3!
        '
        'txtFilters
        '
        Me.txtFilters.CanShrink = True
        Me.txtFilters.Height = 0.15!
        Me.txtFilters.Left = 0.44!
        Me.txtFilters.Name = "txtFilters"
        Me.txtFilters.Style = "background-color: White; font-size: 8pt; vertical-align: middle"
        Me.txtFilters.Text = Nothing
        Me.txtFilters.Top = 0.8500001!
        Me.txtFilters.Width = 6.05!
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
        'picGRCLogo
        '
        Me.picGRCLogo.Height = 0.5!
        Me.picGRCLogo.ImageData = CType(resources.GetObject("picGRCLogo.ImageData"), System.IO.Stream)
        Me.picGRCLogo.Left = 0.0!
        Me.picGRCLogo.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.picGRCLogo.Name = "picGRCLogo"
        Me.picGRCLogo.SizeMode = GrapeCity.ActiveReports.SectionReportModel.SizeModes.Stretch
        Me.picGRCLogo.Top = 0.0!
        Me.picGRCLogo.Width = 3.0!
        '
        'lblLocationInformation
        '
        Me.lblLocationInformation.Height = 0.15!
        Me.lblLocationInformation.HyperLink = Nothing
        Me.lblLocationInformation.Left = 1.421085E-14!
        Me.lblLocationInformation.Name = "lblLocationInformation"
        Me.lblLocationInformation.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblLocationInformation.Text = "Location Detail"
        Me.lblLocationInformation.Top = 1.194!
        Me.lblLocationInformation.Width = 4.37!
        '
        'lblFileNo
        '
        Me.lblFileNo.Height = 0.15!
        Me.lblFileNo.HyperLink = Nothing
        Me.lblFileNo.Left = 1.421085E-14!
        Me.lblFileNo.Name = "lblFileNo"
        Me.lblFileNo.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.lblFileNo.Text = "File No."
        Me.lblFileNo.Top = 1.344!
        Me.lblFileNo.Width = 0.52!
        '
        'lblDivision2
        '
        Me.lblDivision2.Height = 0.15!
        Me.lblDivision2.HyperLink = Nothing
        Me.lblDivision2.Left = 1.421085E-14!
        Me.lblDivision2.Name = "lblDivision2"
        Me.lblDivision2.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.lblDivision2.Text = "Division"
        Me.lblDivision2.Top = 1.494!
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
        Me.lblInspectionDate.Top = 1.344!
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
        Me.lblClientLocNo.Top = 1.344!
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
        Me.lblFacility.Top = 1.494!
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
        Me.lblCity.Top = 1.344!
        Me.lblCity.Width = 0.95!
        '
        'txtSTProv
        '
        Me.txtSTProv.Height = 0.15!
        Me.txtSTProv.Left = 2.85!
        Me.txtSTProv.Name = "txtSTProv"
        Me.txtSTProv.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.txtSTProv.Text = "St/Pr"
        Me.txtSTProv.Top = 1.344!
        Me.txtSTProv.Width = 0.35!
        '
        'txtCountry
        '
        Me.txtCountry.Height = 0.15!
        Me.txtCountry.Left = 3.2!
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.txtCountry.Text = "Country"
        Me.txtCountry.Top = 1.344!
        Me.txtCountry.Width = 0.75!
        '
        'lblTIVGrid
        '
        Me.lblTIVGrid.Height = 0.35!
        Me.lblTIVGrid.HyperLink = Nothing
        Me.lblTIVGrid.Left = 3.95!
        Me.lblTIVGrid.Name = "lblTIVGrid"
        Me.lblTIVGrid.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblTIVGrid.Text = "TIV (millions)"
        Me.lblTIVGrid.Top = 1.294!
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
        Me.lblAddress.Top = 1.494!
        Me.lblAddress.Width = 2.05!
        '
        'line56
        '
        Me.line56.Height = 0.0!
        Me.line56.Left = 1.421085E-14!
        Me.line56.LineWeight = 1.0!
        Me.line56.Name = "line56"
        Me.line56.Top = 1.194!
        Me.line56.Width = 4.37!
        Me.line56.X1 = 1.421085E-14!
        Me.line56.X2 = 4.37!
        Me.line56.Y1 = 1.194!
        Me.line56.Y2 = 1.194!
        '
        'line59
        '
        Me.line59.Height = 0.45!
        Me.line59.Left = 4.37!
        Me.line59.LineWeight = 1.0!
        Me.line59.Name = "line59"
        Me.line59.Top = 1.194!
        Me.line59.Width = 0.0!
        Me.line59.X1 = 4.37!
        Me.line59.X2 = 4.37!
        Me.line59.Y1 = 1.194!
        Me.line59.Y2 = 1.644!
        '
        'label8
        '
        Me.label8.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label8.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label8.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label8.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label8.Height = 0.15!
        Me.label8.HyperLink = Nothing
        Me.label8.Left = 4.42!
        Me.label8.Name = "label8"
        Me.label8.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.label8.Text = "Fire Rating Summary"
        Me.label8.Top = 1.194!
        Me.label8.Width = 5.13!
        '
        'lblAPL
        '
        Me.lblAPL.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblAPL.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblAPL.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblAPL.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblAPL.Height = 0.15!
        Me.lblAPL.HyperLink = Nothing
        Me.lblAPL.Left = 4.42!
        Me.lblAPL.Name = "lblAPL"
        Me.lblAPL.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblAPL.Text = "APL"
        Me.lblAPL.Top = 1.494!
        Me.lblAPL.Width = 0.6499999!
        '
        'label10
        '
        Me.label10.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label10.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label10.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label10.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label10.Height = 0.15!
        Me.label10.HyperLink = Nothing
        Me.label10.Left = 4.42!
        Me.label10.Name = "label10"
        Me.label10.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.label10.Text = "Current"
        Me.label10.Top = 1.344!
        Me.label10.Width = 1.0!
        '
        'label11
        '
        Me.label11.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label11.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label11.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label11.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label11.Height = 0.15!
        Me.label11.HyperLink = Nothing
        Me.label11.Left = 5.07!
        Me.label11.Name = "label11"
        Me.label11.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.label11.Text = "Factor"
        Me.label11.Top = 1.494!
        Me.label11.Width = 0.35!
        '
        'label12
        '
        Me.label12.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label12.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label12.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label12.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label12.Height = 0.15!
        Me.label12.HyperLink = Nothing
        Me.label12.Left = 5.42!
        Me.label12.Name = "label12"
        Me.label12.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.label12.Text = "w/Recs Completed"
        Me.label12.Top = 1.344!
        Me.label12.Width = 1.0!
        '
        'lblAPLRecsComplete
        '
        Me.lblAPLRecsComplete.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblAPLRecsComplete.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblAPLRecsComplete.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblAPLRecsComplete.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblAPLRecsComplete.Height = 0.15!
        Me.lblAPLRecsComplete.HyperLink = Nothing
        Me.lblAPLRecsComplete.Left = 5.42!
        Me.lblAPLRecsComplete.Name = "lblAPLRecsComplete"
        Me.lblAPLRecsComplete.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblAPLRecsComplete.Text = "APL"
        Me.lblAPLRecsComplete.Top = 1.494!
        Me.lblAPLRecsComplete.Width = 0.6499999!
        '
        'label14
        '
        Me.label14.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label14.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label14.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label14.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label14.Height = 0.15!
        Me.label14.HyperLink = Nothing
        Me.label14.Left = 6.07!
        Me.label14.Name = "label14"
        Me.label14.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.label14.Text = "Factor"
        Me.label14.Top = 1.494!
        Me.label14.Width = 0.35!
        '
        'label15
        '
        Me.label15.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label15.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label15.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label15.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label15.Height = 0.3!
        Me.label15.HyperLink = Nothing
        Me.label15.Left = 6.42!
        Me.label15.Name = "label15"
        Me.label15.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.label15.Text = "Passive Score"
        Me.label15.Top = 1.344!
        Me.label15.Width = 0.3820004!
        '
        'label16
        '
        Me.label16.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label16.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label16.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label16.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label16.Height = 0.3!
        Me.label16.HyperLink = Nothing
        Me.label16.Left = 6.802001!
        Me.label16.Name = "label16"
        Me.label16.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.label16.Text = "Active Score"
        Me.label16.Top = 1.344!
        Me.label16.Width = 0.3600006!
        '
        'label17
        '
        Me.label17.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label17.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label17.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label17.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label17.Height = 0.3!
        Me.label17.HyperLink = Nothing
        Me.label17.Left = 7.162002!
        Me.label17.Name = "label17"
        Me.label17.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.label17.Text = "Active w/Recs"
        Me.label17.Top = 1.344!
        Me.label17.Width = 0.3600006!
        '
        'label18
        '
        Me.label18.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label18.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label18.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label18.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label18.Height = 0.15!
        Me.label18.HyperLink = Nothing
        Me.label18.Left = 7.522002!
        Me.label18.Name = "label18"
        Me.label18.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.label18.Text = "Score"
        Me.label18.Top = 1.494!
        Me.label18.Width = 0.4!
        '
        'label19
        '
        Me.label19.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label19.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label19.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label19.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label19.Height = 0.15!
        Me.label19.HyperLink = Nothing
        Me.label19.Left = 7.921999!
        Me.label19.Name = "label19"
        Me.label19.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.label19.Text = "Rating"
        Me.label19.Top = 1.494!
        Me.label19.Width = 0.7!
        '
        'label20
        '
        Me.label20.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label20.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label20.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label20.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label20.Height = 0.15!
        Me.label20.HyperLink = Nothing
        Me.label20.Left = 7.522002!
        Me.label20.Name = "label20"
        Me.label20.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.label20.Text = "Current"
        Me.label20.Top = 1.344!
        Me.label20.Width = 1.1!
        '
        'label21
        '
        Me.label21.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label21.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label21.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label21.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label21.Height = 0.15!
        Me.label21.HyperLink = Nothing
        Me.label21.Left = 8.621996!
        Me.label21.Name = "label21"
        Me.label21.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.label21.Text = "w/Recs Completed"
        Me.label21.Top = 1.344!
        Me.label21.Width = 0.9280039!
        '
        'label22
        '
        Me.label22.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label22.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label22.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label22.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label22.Height = 0.15!
        Me.label22.HyperLink = Nothing
        Me.label22.Left = 8.621996!
        Me.label22.Name = "label22"
        Me.label22.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.label22.Text = "Score"
        Me.label22.Top = 1.494!
        Me.label22.Width = 0.4!
        '
        'label23
        '
        Me.label23.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label23.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label23.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label23.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.label23.Height = 0.15!
        Me.label23.HyperLink = Nothing
        Me.label23.Left = 9.022!
        Me.label23.Name = "label23"
        Me.label23.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.label23.Text = "Rating"
        Me.label23.Top = 1.494!
        Me.label23.Width = 0.5279995!
        '
        'line4
        '
        Me.line4.Height = 0.0!
        Me.line4.Left = 1.421085E-14!
        Me.line4.LineWeight = 1.0!
        Me.line4.Name = "line4"
        Me.line4.Top = 1.194!
        Me.line4.Width = 4.37!
        Me.line4.X1 = 1.421085E-14!
        Me.line4.X2 = 4.37!
        Me.line4.Y1 = 1.194!
        Me.line4.Y2 = 1.194!
        '
        'Label1
        '
        Me.Label1.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Height = 0.1460001!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 9.64!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.Label1.Text = "B&M Rating Summary"
        Me.Label1.Top = 1.202!
        Me.Label1.Width = 3.296!
        '
        'lblPassiveScore
        '
        Me.lblPassiveScore.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblPassiveScore.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblPassiveScore.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblPassiveScore.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblPassiveScore.Height = 0.154!
        Me.lblPassiveScore.HyperLink = Nothing
        Me.lblPassiveScore.Left = 9.64!
        Me.lblPassiveScore.Name = "lblPassiveScore"
        Me.lblPassiveScore.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblPassiveScore.Text = "Score"
        Me.lblPassiveScore.Top = 1.494!
        Me.lblPassiveScore.Width = 0.3600006!
        '
        'lblPassiveWRecs
        '
        Me.lblPassiveWRecs.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblPassiveWRecs.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblPassiveWRecs.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblPassiveWRecs.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblPassiveWRecs.Height = 0.154!
        Me.lblPassiveWRecs.HyperLink = Nothing
        Me.lblPassiveWRecs.Left = 9.999998!
        Me.lblPassiveWRecs.Name = "lblPassiveWRecs"
        Me.lblPassiveWRecs.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblPassiveWRecs.Text = "w/Recs"
        Me.lblPassiveWRecs.Top = 1.494!
        Me.lblPassiveWRecs.Width = 0.3600006!
        '
        'lblActiveScore
        '
        Me.lblActiveScore.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblActiveScore.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblActiveScore.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblActiveScore.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblActiveScore.Height = 0.154!
        Me.lblActiveScore.HyperLink = Nothing
        Me.lblActiveScore.Left = 10.36!
        Me.lblActiveScore.Name = "lblActiveScore"
        Me.lblActiveScore.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblActiveScore.Text = "Score"
        Me.lblActiveScore.Top = 1.494!
        Me.lblActiveScore.Width = 0.3600006!
        '
        'lblActiveWRecs
        '
        Me.lblActiveWRecs.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblActiveWRecs.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblActiveWRecs.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblActiveWRecs.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblActiveWRecs.Height = 0.154!
        Me.lblActiveWRecs.HyperLink = Nothing
        Me.lblActiveWRecs.Left = 10.72!
        Me.lblActiveWRecs.Name = "lblActiveWRecs"
        Me.lblActiveWRecs.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblActiveWRecs.Text = "w/Recs"
        Me.lblActiveWRecs.Top = 1.494!
        Me.lblActiveWRecs.Width = 0.3600006!
        '
        'Label2
        '
        Me.Label2.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label2.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label2.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label2.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label2.Height = 0.1500001!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 11.08!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.Label2.Text = "Score"
        Me.Label2.Top = 1.494!
        Me.Label2.Width = 0.3600006!
        '
        'Label3
        '
        Me.Label3.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Height = 0.1500001!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 11.44!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.Label3.Text = "Rating"
        Me.Label3.Top = 1.494!
        Me.Label3.Width = 0.5679994!
        '
        'Label4
        '
        Me.Label4.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label4.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label4.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label4.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label4.Height = 0.15!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 11.08!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.Label4.Text = "Current"
        Me.Label4.Top = 1.344!
        Me.Label4.Width = 0.9280001!
        '
        'Label5
        '
        Me.Label5.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label5.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label5.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label5.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label5.Height = 0.15!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 12.008!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.Label5.Text = "w/Recs Completed"
        Me.Label5.Top = 1.344!
        Me.Label5.Width = 0.9279985!
        '
        'Label6
        '
        Me.Label6.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label6.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label6.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label6.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label6.Height = 0.1500001!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 12.008!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.Label6.Text = "Score"
        Me.Label6.Top = 1.494!
        Me.Label6.Width = 0.3600006!
        '
        'Label7
        '
        Me.Label7.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label7.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label7.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label7.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label7.Height = 0.1500001!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 12.368!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.Label7.Text = "Rating"
        Me.Label7.Top = 1.494!
        Me.Label7.Width = 0.5679994!
        '
        'Line1
        '
        Me.Line1.Height = 0.4460001!
        Me.Line1.Left = 0.0!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 1.198!
        Me.Line1.Width = 0.0!
        Me.Line1.X1 = 0.0!
        Me.Line1.X2 = 0.0!
        Me.Line1.Y1 = 1.198!
        Me.Line1.Y2 = 1.644!
        '
        'Line2
        '
        Me.Line2.Height = 0.0!
        Me.Line2.Left = 0.0!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 1.644!
        Me.Line2.Width = 4.37!
        Me.Line2.X1 = 0.0!
        Me.Line2.X2 = 4.37!
        Me.Line2.Y1 = 1.644!
        Me.Line2.Y2 = 1.644!
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtAddress, Me.txtDivision2, Me.txtFileNo, Me.txtSurveyDate, Me.txtCity, Me.textBox1, Me.textBox2, Me.txtTIV, Me.txtFacility, Me.txtClientLocNo, Me.line38, Me.line39, Me.line40, Me.line44, Me.txtAPL, Me.txtAPLFactor, Me.txtAPLWithAllRecsComplete, Me.txtAPLFactorWithAllRecsComplete, Me.txtPassiveScore, Me.txtActiveScore, Me.txtActiveScoreWithRecsComplete, Me.txtTotalScore, Me.txtOverallScoreWithRecsComplete, Me.txtOverallPlantRating, Me.txtOverallPlantRatingWithRecsComplete, Me.txtRecsCompletedFactor, Me.txtPassiveWRecs, Me.TextBox4, Me.txtActiveWRecs, Me.txtCurrentScore, Me.txtCurrentFactor, Me.txtRecsCompletedScore, Me.TextBox3})
        Me.Detail1.Height = 0.3604167!
        Me.Detail1.KeepTogether = True
        Me.Detail1.Name = "Detail1"
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
        Me.txtSurveyDate.DataField = "FireInspectionDateString"
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
        'textBox1
        '
        Me.textBox1.CanGrow = False
        Me.textBox1.DataField = "StProv"
        Me.textBox1.Height = 0.15!
        Me.textBox1.Left = 2.85!
        Me.textBox1.MultiLine = False
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.textBox1.Text = "St/Pr"
        Me.textBox1.Top = 0.05!
        Me.textBox1.Width = 0.35!
        '
        'textBox2
        '
        Me.textBox2.CanGrow = False
        Me.textBox2.DataField = "Country"
        Me.textBox2.Height = 0.15!
        Me.textBox2.Left = 3.2!
        Me.textBox2.MultiLine = False
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.textBox2.Text = "Country"
        Me.textBox2.Top = 0.05!
        Me.textBox2.Width = 0.75!
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
        'line38
        '
        Me.line38.Height = 0.0!
        Me.line38.Left = 0.0!
        Me.line38.LineWeight = 1.0!
        Me.line38.Name = "line38"
        Me.line38.Top = 0.05!
        Me.line38.Width = 4.37!
        Me.line38.X1 = 0.0!
        Me.line38.X2 = 4.37!
        Me.line38.Y1 = 0.05!
        Me.line38.Y2 = 0.05!
        '
        'line39
        '
        Me.line39.Height = 0.0!
        Me.line39.Left = 0.0!
        Me.line39.LineWeight = 1.0!
        Me.line39.Name = "line39"
        Me.line39.Top = 0.35!
        Me.line39.Width = 4.37!
        Me.line39.X1 = 0.0!
        Me.line39.X2 = 4.37!
        Me.line39.Y1 = 0.35!
        Me.line39.Y2 = 0.35!
        '
        'line40
        '
        Me.line40.Height = 0.3!
        Me.line40.Left = 4.37!
        Me.line40.LineWeight = 1.0!
        Me.line40.Name = "line40"
        Me.line40.Top = 0.05!
        Me.line40.Width = 0.0!
        Me.line40.X1 = 4.37!
        Me.line40.X2 = 4.37!
        Me.line40.Y1 = 0.05!
        Me.line40.Y2 = 0.35!
        '
        'line44
        '
        Me.line44.Height = 0.3!
        Me.line44.Left = 0.0!
        Me.line44.LineWeight = 1.0!
        Me.line44.Name = "line44"
        Me.line44.Top = 0.05!
        Me.line44.Width = 0.0!
        Me.line44.X1 = 0.0!
        Me.line44.X2 = 0.0!
        Me.line44.Y1 = 0.05!
        Me.line44.Y2 = 0.35!
        '
        'txtAPL
        '
        Me.txtAPL.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtAPL.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtAPL.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtAPL.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtAPL.DataField = "FireAPL"
        Me.txtAPL.Height = 0.3!
        Me.txtAPL.Left = 4.442!
        Me.txtAPL.Name = "txtAPL"
        Me.txtAPL.OutputFormat = resources.GetString("txtAPL.OutputFormat")
        Me.txtAPL.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtAPL.Text = "FireAPL"
        Me.txtAPL.Top = 0.05!
        Me.txtAPL.Width = 0.65!
        '
        'txtAPLFactor
        '
        Me.txtAPLFactor.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtAPLFactor.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtAPLFactor.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtAPLFactor.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtAPLFactor.DataField = "FireAPLFactor"
        Me.txtAPLFactor.Height = 0.3!
        Me.txtAPLFactor.Left = 5.092!
        Me.txtAPLFactor.Name = "txtAPLFactor"
        Me.txtAPLFactor.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtAPLFactor.Text = "FireAPLFactor"
        Me.txtAPLFactor.Top = 0.05!
        Me.txtAPLFactor.Width = 0.35!
        '
        'txtAPLWithAllRecsComplete
        '
        Me.txtAPLWithAllRecsComplete.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtAPLWithAllRecsComplete.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtAPLWithAllRecsComplete.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtAPLWithAllRecsComplete.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtAPLWithAllRecsComplete.DataField = "FireAPLWithAllRecsComplete"
        Me.txtAPLWithAllRecsComplete.Height = 0.3!
        Me.txtAPLWithAllRecsComplete.Left = 5.442!
        Me.txtAPLWithAllRecsComplete.Name = "txtAPLWithAllRecsComplete"
        Me.txtAPLWithAllRecsComplete.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtAPLWithAllRecsComplete.Text = "FireAPLWithAllRecsComplete"
        Me.txtAPLWithAllRecsComplete.Top = 0.05!
        Me.txtAPLWithAllRecsComplete.Width = 0.6279997!
        '
        'txtAPLFactorWithAllRecsComplete
        '
        Me.txtAPLFactorWithAllRecsComplete.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtAPLFactorWithAllRecsComplete.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtAPLFactorWithAllRecsComplete.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtAPLFactorWithAllRecsComplete.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtAPLFactorWithAllRecsComplete.DataField = "FireAPLFactorWithAllRecsComplete"
        Me.txtAPLFactorWithAllRecsComplete.Height = 0.3!
        Me.txtAPLFactorWithAllRecsComplete.Left = 6.07!
        Me.txtAPLFactorWithAllRecsComplete.Name = "txtAPLFactorWithAllRecsComplete"
        Me.txtAPLFactorWithAllRecsComplete.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtAPLFactorWithAllRecsComplete.Text = "FireAPLFactorWithAllRecsComplete"
        Me.txtAPLFactorWithAllRecsComplete.Top = 0.05!
        Me.txtAPLFactorWithAllRecsComplete.Width = 0.35!
        '
        'txtPassiveScore
        '
        Me.txtPassiveScore.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPassiveScore.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPassiveScore.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPassiveScore.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPassiveScore.DataField = "FirePassiveScore"
        Me.txtPassiveScore.Height = 0.3!
        Me.txtPassiveScore.Left = 6.42!
        Me.txtPassiveScore.Name = "txtPassiveScore"
        Me.txtPassiveScore.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtPassiveScore.Text = "FirePassive Score"
        Me.txtPassiveScore.Top = 0.05!
        Me.txtPassiveScore.Width = 0.3820004!
        '
        'txtActiveScore
        '
        Me.txtActiveScore.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtActiveScore.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtActiveScore.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtActiveScore.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtActiveScore.DataField = "FireActiveScore"
        Me.txtActiveScore.Height = 0.3!
        Me.txtActiveScore.Left = 6.802001!
        Me.txtActiveScore.Name = "txtActiveScore"
        Me.txtActiveScore.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtActiveScore.Text = "FireActive Score"
        Me.txtActiveScore.Top = 0.05!
        Me.txtActiveScore.Width = 0.3600006!
        '
        'txtActiveScoreWithRecsComplete
        '
        Me.txtActiveScoreWithRecsComplete.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtActiveScoreWithRecsComplete.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtActiveScoreWithRecsComplete.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtActiveScoreWithRecsComplete.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtActiveScoreWithRecsComplete.DataField = "FireActiveScoreWithRecsComplete"
        Me.txtActiveScoreWithRecsComplete.Height = 0.3!
        Me.txtActiveScoreWithRecsComplete.Left = 7.162002!
        Me.txtActiveScoreWithRecsComplete.Name = "txtActiveScoreWithRecsComplete"
        Me.txtActiveScoreWithRecsComplete.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtActiveScoreWithRecsComplete.Text = "FireActiveScoreWithRecsComplete"
        Me.txtActiveScoreWithRecsComplete.Top = 0.05!
        Me.txtActiveScoreWithRecsComplete.Width = 0.3600006!
        '
        'txtTotalScore
        '
        Me.txtTotalScore.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtTotalScore.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtTotalScore.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtTotalScore.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtTotalScore.DataField = "FireTotalScore"
        Me.txtTotalScore.Height = 0.3!
        Me.txtTotalScore.Left = 7.522002!
        Me.txtTotalScore.Name = "txtTotalScore"
        Me.txtTotalScore.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtTotalScore.Text = "FireTotalScore"
        Me.txtTotalScore.Top = 0.05!
        Me.txtTotalScore.Width = 0.4!
        '
        'txtOverallScoreWithRecsComplete
        '
        Me.txtOverallScoreWithRecsComplete.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtOverallScoreWithRecsComplete.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtOverallScoreWithRecsComplete.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtOverallScoreWithRecsComplete.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtOverallScoreWithRecsComplete.DataField = "FireOverallScoreWithRecsComplete"
        Me.txtOverallScoreWithRecsComplete.Height = 0.3!
        Me.txtOverallScoreWithRecsComplete.Left = 8.621996!
        Me.txtOverallScoreWithRecsComplete.Name = "txtOverallScoreWithRecsComplete"
        Me.txtOverallScoreWithRecsComplete.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtOverallScoreWithRecsComplete.Text = "FireOverallScoreWithRecsComplete"
        Me.txtOverallScoreWithRecsComplete.Top = 0.05!
        Me.txtOverallScoreWithRecsComplete.Width = 0.4000044!
        '
        'txtOverallPlantRating
        '
        Me.txtOverallPlantRating.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtOverallPlantRating.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtOverallPlantRating.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtOverallPlantRating.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtOverallPlantRating.DataField = "FireOverallPlantRating"
        Me.txtOverallPlantRating.Height = 0.3!
        Me.txtOverallPlantRating.Left = 7.921999!
        Me.txtOverallPlantRating.Name = "txtOverallPlantRating"
        Me.txtOverallPlantRating.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtOverallPlantRating.Text = "FireOverallPlantRating"
        Me.txtOverallPlantRating.Top = 0.05!
        Me.txtOverallPlantRating.Width = 0.7!
        '
        'txtOverallPlantRatingWithRecsComplete
        '
        Me.txtOverallPlantRatingWithRecsComplete.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtOverallPlantRatingWithRecsComplete.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtOverallPlantRatingWithRecsComplete.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtOverallPlantRatingWithRecsComplete.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtOverallPlantRatingWithRecsComplete.DataField = "FireOverallPlantRatingWithRecsComplete"
        Me.txtOverallPlantRatingWithRecsComplete.Height = 0.3!
        Me.txtOverallPlantRatingWithRecsComplete.Left = 9.022!
        Me.txtOverallPlantRatingWithRecsComplete.Name = "txtOverallPlantRatingWithRecsComplete"
        Me.txtOverallPlantRatingWithRecsComplete.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtOverallPlantRatingWithRecsComplete.Text = "Typical Risk"
        Me.txtOverallPlantRatingWithRecsComplete.Top = 0.05!
        Me.txtOverallPlantRatingWithRecsComplete.Width = 0.5279961!
        '
        'txtRecsCompletedFactor
        '
        Me.txtRecsCompletedFactor.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtRecsCompletedFactor.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtRecsCompletedFactor.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtRecsCompletedFactor.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtRecsCompletedFactor.DataField = "BMTotalWRCompleteRating"
        Me.txtRecsCompletedFactor.Height = 0.3!
        Me.txtRecsCompletedFactor.Left = 12.368!
        Me.txtRecsCompletedFactor.Name = "txtRecsCompletedFactor"
        Me.txtRecsCompletedFactor.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtRecsCompletedFactor.Text = "Typical Risk"
        Me.txtRecsCompletedFactor.Top = 0.05!
        Me.txtRecsCompletedFactor.Width = 0.5679998!
        '
        'txtPassiveWRecs
        '
        Me.txtPassiveWRecs.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPassiveWRecs.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPassiveWRecs.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPassiveWRecs.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPassiveWRecs.DataField = "BMPassiveWC"
        Me.txtPassiveWRecs.Height = 0.3!
        Me.txtPassiveWRecs.Left = 10.0!
        Me.txtPassiveWRecs.Name = "txtPassiveWRecs"
        Me.txtPassiveWRecs.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtPassiveWRecs.Text = "Passive w/Recs"
        Me.txtPassiveWRecs.Top = 0.05!
        Me.txtPassiveWRecs.Width = 0.3600006!
        '
        'TextBox4
        '
        Me.TextBox4.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.DataField = "BMActiveC"
        Me.TextBox4.Height = 0.3!
        Me.TextBox4.Left = 10.36!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.TextBox4.Text = "Active " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Score"
        Me.TextBox4.Top = 0.05!
        Me.TextBox4.Width = 0.3600006!
        '
        'txtActiveWRecs
        '
        Me.txtActiveWRecs.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtActiveWRecs.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtActiveWRecs.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtActiveWRecs.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtActiveWRecs.DataField = "BMActiveWC"
        Me.txtActiveWRecs.Height = 0.3!
        Me.txtActiveWRecs.Left = 10.72!
        Me.txtActiveWRecs.Name = "txtActiveWRecs"
        Me.txtActiveWRecs.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtActiveWRecs.Text = "Active w/Recs"
        Me.txtActiveWRecs.Top = 0.05!
        Me.txtActiveWRecs.Width = 0.3600006!
        '
        'txtCurrentScore
        '
        Me.txtCurrentScore.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtCurrentScore.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtCurrentScore.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtCurrentScore.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtCurrentScore.DataField = "BMTotalScoreCurrent"
        Me.txtCurrentScore.Height = 0.3!
        Me.txtCurrentScore.Left = 11.08!
        Me.txtCurrentScore.Name = "txtCurrentScore"
        Me.txtCurrentScore.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtCurrentScore.Text = "150.00"
        Me.txtCurrentScore.Top = 0.05!
        Me.txtCurrentScore.Width = 0.3599997!
        '
        'txtCurrentFactor
        '
        Me.txtCurrentFactor.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtCurrentFactor.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtCurrentFactor.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtCurrentFactor.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtCurrentFactor.DataField = "BMTotalRating"
        Me.txtCurrentFactor.Height = 0.3!
        Me.txtCurrentFactor.Left = 11.44!
        Me.txtCurrentFactor.Name = "txtCurrentFactor"
        Me.txtCurrentFactor.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtCurrentFactor.Text = "Typical Risk"
        Me.txtCurrentFactor.Top = 0.05!
        Me.txtCurrentFactor.Width = 0.5679998!
        '
        'txtRecsCompletedScore
        '
        Me.txtRecsCompletedScore.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtRecsCompletedScore.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtRecsCompletedScore.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtRecsCompletedScore.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtRecsCompletedScore.DataField = "BMTotalWRComplete"
        Me.txtRecsCompletedScore.Height = 0.3!
        Me.txtRecsCompletedScore.Left = 12.008!
        Me.txtRecsCompletedScore.Name = "txtRecsCompletedScore"
        Me.txtRecsCompletedScore.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtRecsCompletedScore.Text = "50"
        Me.txtRecsCompletedScore.Top = 0.05!
        Me.txtRecsCompletedScore.Width = 0.3600006!
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.DataField = "BMPassiveC"
        Me.TextBox3.Height = 0.3!
        Me.TextBox3.Left = 9.64!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.TextBox3.Text = "Passive " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Score"
        Me.TextBox3.Top = 0.05!
        Me.TextBox3.Width = 0.3600006!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblReportDate, Me.txtSort, Me.txtPageNo, Me.txtDisclaimer})
        Me.PageFooter1.Height = 0.50625!
        Me.PageFooter1.Name = "PageFooter1"
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
        'txtSort
        '
        Me.txtSort.CanShrink = True
        Me.txtSort.Height = 0.15!
        Me.txtSort.Left = 0.0!
        Me.txtSort.Name = "txtSort"
        Me.txtSort.Style = "font-size: 7pt; font-style: italic; text-align: center; vertical-align: middle"
        Me.txtSort.Text = "Sort"
        Me.txtSort.Top = 0.0!
        Me.txtSort.Width = 12.936!
        '
        'txtPageNo
        '
        Me.txtPageNo.FormatString = "Page {PageNumber} of {PageCount}"
        Me.txtPageNo.Height = 0.15!
        Me.txtPageNo.Left = 10.936!
        Me.txtPageNo.Name = "txtPageNo"
        Me.txtPageNo.Style = "font-size: 7pt; font-style: italic; text-align: right; vertical-align: middle"
        Me.txtPageNo.Top = 0.3!
        Me.txtPageNo.Width = 2.0!
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
        Me.txtDisclaimer.Width = 12.936!
        '
        'Label9
        '
        Me.Label9.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label9.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label9.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label9.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label9.Height = 0.15!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 10.355!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.Label9.Text = "Mgmt. Programs"
        Me.Label9.Top = 1.344!
        Me.Label9.Width = 0.7209997!
        '
        'Label13
        '
        Me.Label13.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label13.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label13.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label13.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label13.Height = 0.15!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 9.635!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.Label13.Text = "Physical Assets"
        Me.Label13.Top = 1.344!
        Me.Label13.Width = 0.7209997!
        '
        'rptFireBMFacilityRatingSummary
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
        Me.PrintWidth = 12.99167!
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
        CType(Me.lblReportName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGRCLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblLocationInformation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFileNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDivision2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblInspectionDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblClientLocNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFacility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSTProv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTIVGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAPL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAPLRecsComplete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPassiveScore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPassiveWRecs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblActiveScore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblActiveWRecs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDivision2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFileNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSurveyDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTIV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFacility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientLocNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAPL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAPLFactor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAPLWithAllRecsComplete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAPLFactorWithAllRecsComplete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassiveScore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActiveScore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActiveScoreWithRecsComplete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalScore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOverallScoreWithRecsComplete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOverallPlantRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOverallPlantRatingWithRecsComplete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRecsCompletedFactor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassiveWRecs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActiveWRecs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCurrentScore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCurrentFactor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRecsCompletedScore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblReportDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSort, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPageNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisclaimer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
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

    Private Sub rptFireFacilityRatingSummary_FetchData(ByVal sender As Object, ByVal eArgs As FetchEventArgs) Handles Me.FetchData
        'Dim zRiskScoreControls() As ARControl = {txtTotalScore, txtOverallScoreWithRecsComplete, txtCurrentScore, txtRecsCompletedScore}
        'Dim zRiskRatingControls() As ARControl = {txtOverallPlantRating, txtOverallPlantRatingWithRecsComplete, txtCurrentFactor, txtRecsCompletedFactor}
        'UtilReport.ActiveReport.SetItemBackColorByRiskRatingScore(Me, zRiskScoreControls, rptProperties)
        'UtilReport.ActiveReport.SetItemBackColorByRiskRating(Me, zRiskRatingControls, rptProperties)

        'fire
        Dim zrpt As SectionReport = sender
        txtTotalScore.BackColor = System.Drawing.ColorTranslator.FromHtml(zrpt.AllFields("FireTotalScoreColor").Value)
        txtOverallPlantRating.BackColor = System.Drawing.ColorTranslator.FromHtml(zrpt.AllFields("FireOverallPlantRatingColor").Value)
        txtOverallPlantRatingWithRecsComplete.BackColor = System.Drawing.ColorTranslator.FromHtml(zrpt.AllFields("FireOverallPlantRatingWithRecsCompleteColor").Value)
        txtOverallScoreWithRecsComplete.BackColor = System.Drawing.ColorTranslator.FromHtml(zrpt.AllFields("FireOverallScoreWithRecsCompleteColor").Value)

        'bm
        txtCurrentScore.BackColor = System.Drawing.ColorTranslator.FromHtml(zrpt.AllFields("BMTotalScoreCurrentColor").Value)
        txtCurrentFactor.BackColor = System.Drawing.ColorTranslator.FromHtml(zrpt.AllFields("BMTotalRatingColor").Value)
        txtRecsCompletedScore.BackColor = System.Drawing.ColorTranslator.FromHtml(zrpt.AllFields("BMTotalWRCompleteColor").Value)
        txtRecsCompletedFactor.BackColor = System.Drawing.ColorTranslator.FromHtml(zrpt.AllFields("BMTotalWRCompleteRatingColor").Value)

    End Sub

    Private Sub rptFireFacilityRatingSummary_ReportStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportStart
        lblClientName.Text = rptProperties.ClientName
        lblReportDate.Text = Now
    End Sub

    Private Sub rptFireFacilityRatingSummary_PageStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.PageStart
        UtilReport.ActiveReport.SetFilter(Me, rptProperties)
        UtilReport.ActiveReport.SetSort(Me, rptProperties)
        UtilReport.ActiveReport.SetDisclaimer(Me, rptProperties)
    End Sub

    Private Sub rptFireFacilityRatingSummary_ReportEnd(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportEnd
        DisposeParameters()
    End Sub

    Private Sub DisposeParameters()
        DataSource = Nothing
    End Sub

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties


End Class
