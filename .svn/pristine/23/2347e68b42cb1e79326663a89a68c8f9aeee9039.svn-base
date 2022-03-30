Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports

Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing

Public Class rptFireFacilityRatingSummary
    Inherits GrapeCity.ActiveReports.SectionReport
    Implements IUtilReport
    Implements IActiveReport

#Region " ActiveReports Designer generated code "
    'Required by the ActiveReports Designer
    Private Shadows components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the ActiveReports Designer
    'It can be modified using the ActiveReports Designer.
    'Do not modify it using the code editor.
    Private WithEvents Detail1 As GrapeCity.ActiveReports.SectionReportModel.Detail
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
    Private WithEvents line45 As GrapeCity.ActiveReports.SectionReportModel.Line
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
    Private WithEvents lnRatingSummary1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRatingSummary2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRatingSummary3 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRatingSummary4 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRatingSummary6 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRatingSummary7 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRatingSummary8 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRatingSummary11 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRatingSummary10 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRatingSummary9 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRatingSummary12 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRatingSummaryBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRatingSummaryTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents PageHeader1 As GrapeCity.ActiveReports.SectionReportModel.PageHeader
    Private WithEvents lblClientName As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblReportName As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtFilters As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblFilters As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents picGRCLogo As GrapeCity.ActiveReports.SectionReportModel.Picture
    Private WithEvents srptFireFacilityRatingSummarySubOverallRatingKey As GrapeCity.ActiveReports.SectionReportModel.SubReport
    Private WithEvents srptFireFacilityRatingSummarySubHeader As GrapeCity.ActiveReports.SectionReportModel.SubReport
    Private WithEvents PageFooter1 As GrapeCity.ActiveReports.SectionReportModel.PageFooter
    Private WithEvents lblReportDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtSort As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtPageNo As GrapeCity.ActiveReports.SectionReportModel.ReportInfo
    Private WithEvents txtDisclaimer As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lnRatingSummary5 As GrapeCity.ActiveReports.SectionReportModel.Line
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptFireFacilityRatingSummary))
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
        Me.line45 = New GrapeCity.ActiveReports.SectionReportModel.Line()
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
        Me.lnRatingSummary1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRatingSummary2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRatingSummary3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRatingSummary4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRatingSummary5 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRatingSummary6 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRatingSummary7 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRatingSummary8 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRatingSummary11 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRatingSummary10 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRatingSummary9 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRatingSummary12 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRatingSummaryBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRatingSummaryTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.PageHeader1 = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.lblClientName = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblReportName = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtFilters = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblFilters = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.picGRCLogo = New GrapeCity.ActiveReports.SectionReportModel.Picture()
        Me.srptFireFacilityRatingSummarySubOverallRatingKey = New GrapeCity.ActiveReports.SectionReportModel.SubReport()
        Me.srptFireFacilityRatingSummarySubHeader = New GrapeCity.ActiveReports.SectionReportModel.SubReport()
        Me.PageFooter1 = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.lblReportDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtSort = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPageNo = New GrapeCity.ActiveReports.SectionReportModel.ReportInfo()
        Me.txtDisclaimer = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
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
        CType(Me.lblClientName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblReportName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGRCLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblReportDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPageNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisclaimer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtAddress, Me.txtDivision2, Me.txtFileNo, Me.txtSurveyDate, Me.txtCity, Me.textBox1, Me.textBox2, Me.txtTIV, Me.txtFacility, Me.txtClientLocNo, Me.line38, Me.line39, Me.line40, Me.line44, Me.line45, Me.txtAPL, Me.txtAPLFactor, Me.txtAPLWithAllRecsComplete, Me.txtAPLFactorWithAllRecsComplete, Me.txtPassiveScore, Me.txtActiveScore, Me.txtActiveScoreWithRecsComplete, Me.txtTotalScore, Me.txtOverallScoreWithRecsComplete, Me.txtOverallPlantRating, Me.txtOverallPlantRatingWithRecsComplete, Me.lnRatingSummary1, Me.lnRatingSummary2, Me.lnRatingSummary3, Me.lnRatingSummary4, Me.lnRatingSummary5, Me.lnRatingSummary6, Me.lnRatingSummary7, Me.lnRatingSummary8, Me.lnRatingSummary11, Me.lnRatingSummary10, Me.lnRatingSummary9, Me.lnRatingSummary12, Me.lnRatingSummaryBottom, Me.lnRatingSummaryTop})
        Me.Detail1.Height = 0.35!
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
        Me.txtSurveyDate.DataField = "InspectionDateString"
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
        'line45
        '
        Me.line45.Height = 0.3!
        Me.line45.Left = 4.42!
        Me.line45.LineWeight = 1.0!
        Me.line45.Name = "line45"
        Me.line45.Top = 0.05!
        Me.line45.Width = 0.0!
        Me.line45.X1 = 4.42!
        Me.line45.X2 = 4.42!
        Me.line45.Y1 = 0.05!
        Me.line45.Y2 = 0.35!
        '
        'txtAPL
        '
        Me.txtAPL.CurrencyCulture = New System.Globalization.CultureInfo("en-US")
        Me.txtAPL.DataField = "APL"
        Me.txtAPL.Height = 0.3!
        Me.txtAPL.Left = 4.42!
        Me.txtAPL.Name = "txtAPL"
        Me.txtAPL.OutputFormat = resources.GetString("txtAPL.OutputFormat")
        Me.txtAPL.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtAPL.Text = "APL"
        Me.txtAPL.Top = 0.05!
        Me.txtAPL.Width = 0.65!
        '
        'txtAPLFactor
        '
        Me.txtAPLFactor.DataField = "APLFactor"
        Me.txtAPLFactor.Height = 0.3!
        Me.txtAPLFactor.Left = 5.07!
        Me.txtAPLFactor.Name = "txtAPLFactor"
        Me.txtAPLFactor.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtAPLFactor.Text = "APLFactor"
        Me.txtAPLFactor.Top = 0.05!
        Me.txtAPLFactor.Width = 0.35!
        '
        'txtAPLWithAllRecsComplete
        '
        Me.txtAPLWithAllRecsComplete.DataField = "APLWithAllRecsComplete"
        Me.txtAPLWithAllRecsComplete.Height = 0.3!
        Me.txtAPLWithAllRecsComplete.Left = 5.42!
        Me.txtAPLWithAllRecsComplete.Name = "txtAPLWithAllRecsComplete"
        Me.txtAPLWithAllRecsComplete.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtAPLWithAllRecsComplete.Text = "APLWithAllRecsComplete"
        Me.txtAPLWithAllRecsComplete.Top = 0.05!
        Me.txtAPLWithAllRecsComplete.Width = 0.65!
        '
        'txtAPLFactorWithAllRecsComplete
        '
        Me.txtAPLFactorWithAllRecsComplete.DataField = "APLFactorWithAllRecsComplete"
        Me.txtAPLFactorWithAllRecsComplete.Height = 0.3!
        Me.txtAPLFactorWithAllRecsComplete.Left = 6.07!
        Me.txtAPLFactorWithAllRecsComplete.Name = "txtAPLFactorWithAllRecsComplete"
        Me.txtAPLFactorWithAllRecsComplete.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtAPLFactorWithAllRecsComplete.Text = "APLFactorWithAllRecsComplete"
        Me.txtAPLFactorWithAllRecsComplete.Top = 0.05!
        Me.txtAPLFactorWithAllRecsComplete.Width = 0.35!
        '
        'txtPassiveScore
        '
        Me.txtPassiveScore.DataField = "PassiveScore"
        Me.txtPassiveScore.Height = 0.3!
        Me.txtPassiveScore.Left = 6.42!
        Me.txtPassiveScore.Name = "txtPassiveScore"
        Me.txtPassiveScore.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtPassiveScore.Text = "Passive Score"
        Me.txtPassiveScore.Top = 0.05!
        Me.txtPassiveScore.Width = 0.46!
        '
        'txtActiveScore
        '
        Me.txtActiveScore.DataField = "ActiveScore"
        Me.txtActiveScore.Height = 0.3!
        Me.txtActiveScore.Left = 6.88!
        Me.txtActiveScore.Name = "txtActiveScore"
        Me.txtActiveScore.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtActiveScore.Text = "Active Score"
        Me.txtActiveScore.Top = 0.05!
        Me.txtActiveScore.Width = 0.46!
        '
        'txtActiveScoreWithRecsComplete
        '
        Me.txtActiveScoreWithRecsComplete.DataField = "ActiveScoreWithRecsComplete"
        Me.txtActiveScoreWithRecsComplete.Height = 0.3!
        Me.txtActiveScoreWithRecsComplete.Left = 7.34!
        Me.txtActiveScoreWithRecsComplete.Name = "txtActiveScoreWithRecsComplete"
        Me.txtActiveScoreWithRecsComplete.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtActiveScoreWithRecsComplete.Text = "ActiveScoreWithRecsComplete"
        Me.txtActiveScoreWithRecsComplete.Top = 0.05!
        Me.txtActiveScoreWithRecsComplete.Width = 0.46!
        '
        'txtTotalScore
        '
        Me.txtTotalScore.DataField = "TotalScore"
        Me.txtTotalScore.Height = 0.3!
        Me.txtTotalScore.Left = 7.8!
        Me.txtTotalScore.Name = "txtTotalScore"
        Me.txtTotalScore.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtTotalScore.Text = "TotalScore"
        Me.txtTotalScore.Top = 0.05!
        Me.txtTotalScore.Width = 0.4!
        '
        'txtOverallScoreWithRecsComplete
        '
        Me.txtOverallScoreWithRecsComplete.DataField = "OverallScoreWithRecsComplete"
        Me.txtOverallScoreWithRecsComplete.Height = 0.3!
        Me.txtOverallScoreWithRecsComplete.Left = 8.9!
        Me.txtOverallScoreWithRecsComplete.Name = "txtOverallScoreWithRecsComplete"
        Me.txtOverallScoreWithRecsComplete.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtOverallScoreWithRecsComplete.Text = "OverallScoreWithRecsComplete"
        Me.txtOverallScoreWithRecsComplete.Top = 0.05!
        Me.txtOverallScoreWithRecsComplete.Width = 0.4!
        '
        'txtOverallPlantRating
        '
        Me.txtOverallPlantRating.DataField = "OverallPlantRating"
        Me.txtOverallPlantRating.Height = 0.3!
        Me.txtOverallPlantRating.Left = 8.2!
        Me.txtOverallPlantRating.Name = "txtOverallPlantRating"
        Me.txtOverallPlantRating.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtOverallPlantRating.Text = "OverallPlantRating"
        Me.txtOverallPlantRating.Top = 0.05!
        Me.txtOverallPlantRating.Width = 0.7!
        '
        'txtOverallPlantRatingWithRecsComplete
        '
        Me.txtOverallPlantRatingWithRecsComplete.DataField = "OverallPlantRatingWithRecsComplete"
        Me.txtOverallPlantRatingWithRecsComplete.Height = 0.3!
        Me.txtOverallPlantRatingWithRecsComplete.Left = 9.3!
        Me.txtOverallPlantRatingWithRecsComplete.Name = "txtOverallPlantRatingWithRecsComplete"
        Me.txtOverallPlantRatingWithRecsComplete.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtOverallPlantRatingWithRecsComplete.Text = "OverallPlantRatingWithRecsComplete"
        Me.txtOverallPlantRatingWithRecsComplete.Top = 0.05!
        Me.txtOverallPlantRatingWithRecsComplete.Width = 0.7!
        '
        'lnRatingSummary1
        '
        Me.lnRatingSummary1.Height = 0.3!
        Me.lnRatingSummary1.Left = 4.42!
        Me.lnRatingSummary1.LineWeight = 1.0!
        Me.lnRatingSummary1.Name = "lnRatingSummary1"
        Me.lnRatingSummary1.Top = 0.05!
        Me.lnRatingSummary1.Width = 0.0!
        Me.lnRatingSummary1.X1 = 4.42!
        Me.lnRatingSummary1.X2 = 4.42!
        Me.lnRatingSummary1.Y1 = 0.05!
        Me.lnRatingSummary1.Y2 = 0.35!
        '
        'lnRatingSummary2
        '
        Me.lnRatingSummary2.Height = 0.3!
        Me.lnRatingSummary2.Left = 5.07!
        Me.lnRatingSummary2.LineWeight = 1.0!
        Me.lnRatingSummary2.Name = "lnRatingSummary2"
        Me.lnRatingSummary2.Top = 0.05!
        Me.lnRatingSummary2.Width = 0.0!
        Me.lnRatingSummary2.X1 = 5.07!
        Me.lnRatingSummary2.X2 = 5.07!
        Me.lnRatingSummary2.Y1 = 0.05!
        Me.lnRatingSummary2.Y2 = 0.35!
        '
        'lnRatingSummary3
        '
        Me.lnRatingSummary3.Height = 0.3!
        Me.lnRatingSummary3.Left = 5.42!
        Me.lnRatingSummary3.LineWeight = 1.0!
        Me.lnRatingSummary3.Name = "lnRatingSummary3"
        Me.lnRatingSummary3.Top = 0.05!
        Me.lnRatingSummary3.Width = 0.0!
        Me.lnRatingSummary3.X1 = 5.42!
        Me.lnRatingSummary3.X2 = 5.42!
        Me.lnRatingSummary3.Y1 = 0.05!
        Me.lnRatingSummary3.Y2 = 0.35!
        '
        'lnRatingSummary4
        '
        Me.lnRatingSummary4.Height = 0.3!
        Me.lnRatingSummary4.Left = 6.07!
        Me.lnRatingSummary4.LineWeight = 1.0!
        Me.lnRatingSummary4.Name = "lnRatingSummary4"
        Me.lnRatingSummary4.Top = 0.05!
        Me.lnRatingSummary4.Width = 0.0!
        Me.lnRatingSummary4.X1 = 6.07!
        Me.lnRatingSummary4.X2 = 6.07!
        Me.lnRatingSummary4.Y1 = 0.05!
        Me.lnRatingSummary4.Y2 = 0.35!
        '
        'lnRatingSummary5
        '
        Me.lnRatingSummary5.Height = 0.3!
        Me.lnRatingSummary5.Left = 6.42!
        Me.lnRatingSummary5.LineWeight = 1.0!
        Me.lnRatingSummary5.Name = "lnRatingSummary5"
        Me.lnRatingSummary5.Top = 0.05!
        Me.lnRatingSummary5.Width = 0.0!
        Me.lnRatingSummary5.X1 = 6.42!
        Me.lnRatingSummary5.X2 = 6.42!
        Me.lnRatingSummary5.Y1 = 0.05!
        Me.lnRatingSummary5.Y2 = 0.35!
        '
        'lnRatingSummary6
        '
        Me.lnRatingSummary6.Height = 0.3!
        Me.lnRatingSummary6.Left = 6.88!
        Me.lnRatingSummary6.LineWeight = 1.0!
        Me.lnRatingSummary6.Name = "lnRatingSummary6"
        Me.lnRatingSummary6.Top = 0.05!
        Me.lnRatingSummary6.Width = 0.0!
        Me.lnRatingSummary6.X1 = 6.88!
        Me.lnRatingSummary6.X2 = 6.88!
        Me.lnRatingSummary6.Y1 = 0.05!
        Me.lnRatingSummary6.Y2 = 0.35!
        '
        'lnRatingSummary7
        '
        Me.lnRatingSummary7.Height = 0.3!
        Me.lnRatingSummary7.Left = 7.34!
        Me.lnRatingSummary7.LineWeight = 1.0!
        Me.lnRatingSummary7.Name = "lnRatingSummary7"
        Me.lnRatingSummary7.Top = 0.05!
        Me.lnRatingSummary7.Width = 0.0!
        Me.lnRatingSummary7.X1 = 7.34!
        Me.lnRatingSummary7.X2 = 7.34!
        Me.lnRatingSummary7.Y1 = 0.05!
        Me.lnRatingSummary7.Y2 = 0.35!
        '
        'lnRatingSummary8
        '
        Me.lnRatingSummary8.Height = 0.3!
        Me.lnRatingSummary8.Left = 7.8!
        Me.lnRatingSummary8.LineWeight = 1.0!
        Me.lnRatingSummary8.Name = "lnRatingSummary8"
        Me.lnRatingSummary8.Top = 0.05!
        Me.lnRatingSummary8.Width = 0.0!
        Me.lnRatingSummary8.X1 = 7.8!
        Me.lnRatingSummary8.X2 = 7.8!
        Me.lnRatingSummary8.Y1 = 0.05!
        Me.lnRatingSummary8.Y2 = 0.35!
        '
        'lnRatingSummary11
        '
        Me.lnRatingSummary11.Height = 0.3!
        Me.lnRatingSummary11.Left = 9.3!
        Me.lnRatingSummary11.LineWeight = 1.0!
        Me.lnRatingSummary11.Name = "lnRatingSummary11"
        Me.lnRatingSummary11.Top = 0.05!
        Me.lnRatingSummary11.Width = 0.0!
        Me.lnRatingSummary11.X1 = 9.3!
        Me.lnRatingSummary11.X2 = 9.3!
        Me.lnRatingSummary11.Y1 = 0.05!
        Me.lnRatingSummary11.Y2 = 0.35!
        '
        'lnRatingSummary10
        '
        Me.lnRatingSummary10.Height = 0.3!
        Me.lnRatingSummary10.Left = 8.9!
        Me.lnRatingSummary10.LineWeight = 1.0!
        Me.lnRatingSummary10.Name = "lnRatingSummary10"
        Me.lnRatingSummary10.Top = 0.05!
        Me.lnRatingSummary10.Width = 0.0!
        Me.lnRatingSummary10.X1 = 8.9!
        Me.lnRatingSummary10.X2 = 8.9!
        Me.lnRatingSummary10.Y1 = 0.05!
        Me.lnRatingSummary10.Y2 = 0.35!
        '
        'lnRatingSummary9
        '
        Me.lnRatingSummary9.Height = 0.3!
        Me.lnRatingSummary9.Left = 8.2!
        Me.lnRatingSummary9.LineWeight = 1.0!
        Me.lnRatingSummary9.Name = "lnRatingSummary9"
        Me.lnRatingSummary9.Top = 0.05!
        Me.lnRatingSummary9.Width = 0.0!
        Me.lnRatingSummary9.X1 = 8.2!
        Me.lnRatingSummary9.X2 = 8.2!
        Me.lnRatingSummary9.Y1 = 0.05!
        Me.lnRatingSummary9.Y2 = 0.35!
        '
        'lnRatingSummary12
        '
        Me.lnRatingSummary12.Height = 0.3!
        Me.lnRatingSummary12.Left = 10.0!
        Me.lnRatingSummary12.LineWeight = 1.0!
        Me.lnRatingSummary12.Name = "lnRatingSummary12"
        Me.lnRatingSummary12.Top = 0.05!
        Me.lnRatingSummary12.Width = 0.0!
        Me.lnRatingSummary12.X1 = 10.0!
        Me.lnRatingSummary12.X2 = 10.0!
        Me.lnRatingSummary12.Y1 = 0.05!
        Me.lnRatingSummary12.Y2 = 0.35!
        '
        'lnRatingSummaryBottom
        '
        Me.lnRatingSummaryBottom.Height = 0.0!
        Me.lnRatingSummaryBottom.Left = 4.42!
        Me.lnRatingSummaryBottom.LineWeight = 1.0!
        Me.lnRatingSummaryBottom.Name = "lnRatingSummaryBottom"
        Me.lnRatingSummaryBottom.Top = 0.35!
        Me.lnRatingSummaryBottom.Width = 5.58!
        Me.lnRatingSummaryBottom.X1 = 4.42!
        Me.lnRatingSummaryBottom.X2 = 10.0!
        Me.lnRatingSummaryBottom.Y1 = 0.35!
        Me.lnRatingSummaryBottom.Y2 = 0.35!
        '
        'lnRatingSummaryTop
        '
        Me.lnRatingSummaryTop.Height = 0.0!
        Me.lnRatingSummaryTop.Left = 4.42!
        Me.lnRatingSummaryTop.LineWeight = 1.0!
        Me.lnRatingSummaryTop.Name = "lnRatingSummaryTop"
        Me.lnRatingSummaryTop.Top = 0.05!
        Me.lnRatingSummaryTop.Width = 5.58!
        Me.lnRatingSummaryTop.X1 = 4.42!
        Me.lnRatingSummaryTop.X2 = 10.0!
        Me.lnRatingSummaryTop.Y1 = 0.05!
        Me.lnRatingSummaryTop.Y2 = 0.05!
        '
        'PageHeader1
        '
        Me.PageHeader1.CanShrink = True
        Me.PageHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblClientName, Me.lblReportName, Me.txtFilters, Me.lblFilters, Me.picGRCLogo, Me.srptFireFacilityRatingSummarySubOverallRatingKey, Me.srptFireFacilityRatingSummarySubHeader})
        Me.PageHeader1.Height = 2.55!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'lblClientName
        '
        Me.lblClientName.Height = 0.25!
        Me.lblClientName.HyperLink = Nothing
        Me.lblClientName.Left = 5.63!
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Style = "color: #C6D1DE; font-size: 16pt; font-style: italic; font-weight: bold; text-alig" & _
    "n: right; vertical-align: middle"
        Me.lblClientName.Text = "Company Name"
        Me.lblClientName.Top = 0.05!
        Me.lblClientName.Width = 4.3!
        '
        'lblReportName
        '
        Me.lblReportName.Height = 0.25!
        Me.lblReportName.HyperLink = Nothing
        Me.lblReportName.Left = 5.63!
        Me.lblReportName.Name = "lblReportName"
        Me.lblReportName.Style = "font-size: 12pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblReportName.Text = "Fire Facility Rating Summary"
        Me.lblReportName.Top = 0.35!
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
        Me.picGRCLogo.PictureAlignment = GrapeCity.ActiveReports.SectionReportModel.PictureAlignment.TopLeft
        Me.picGRCLogo.SizeMode = GrapeCity.ActiveReports.SectionReportModel.SizeModes.Stretch
        Me.picGRCLogo.Top = 0.0!
        Me.picGRCLogo.Width = 3.0!
        '
        'srptFireFacilityRatingSummarySubOverallRatingKey
        '
        Me.srptFireFacilityRatingSummarySubOverallRatingKey.CanGrow = False
        Me.srptFireFacilityRatingSummarySubOverallRatingKey.CloseBorder = False
        Me.srptFireFacilityRatingSummarySubOverallRatingKey.Height = 0.95!
        Me.srptFireFacilityRatingSummarySubOverallRatingKey.Left = 6.6!
        Me.srptFireFacilityRatingSummarySubOverallRatingKey.Name = "srptFireFacilityRatingSummarySubOverallRatingKey"
        Me.srptFireFacilityRatingSummarySubOverallRatingKey.Report = Nothing
        Me.srptFireFacilityRatingSummarySubOverallRatingKey.ReportName = ""
        Me.srptFireFacilityRatingSummarySubOverallRatingKey.Top = 0.8750001!
        Me.srptFireFacilityRatingSummarySubOverallRatingKey.Width = 3.369!
        '
        'srptFireFacilityRatingSummarySubHeader
        '
        Me.srptFireFacilityRatingSummarySubHeader.CloseBorder = False
        Me.srptFireFacilityRatingSummarySubHeader.Height = 0.45!
        Me.srptFireFacilityRatingSummarySubHeader.Left = 0.0!
        Me.srptFireFacilityRatingSummarySubHeader.Name = "srptFireFacilityRatingSummarySubHeader"
        Me.srptFireFacilityRatingSummarySubHeader.Report = Nothing
        Me.srptFireFacilityRatingSummarySubHeader.ReportName = "rptFireFacilityRatingSummarySubHeader"
        Me.srptFireFacilityRatingSummarySubHeader.Top = 2.1!
        Me.srptFireFacilityRatingSummarySubHeader.Width = 10.0!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblReportDate, Me.txtSort, Me.txtPageNo, Me.txtDisclaimer})
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
        Me.lblReportDate.Top = 0.325!
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
        'txtPageNo
        '
        Me.txtPageNo.FormatString = "Page {PageNumber} of {PageCount}"
        Me.txtPageNo.Height = 0.15!
        Me.txtPageNo.Left = 8.0!
        Me.txtPageNo.Name = "txtPageNo"
        Me.txtPageNo.Style = "font-size: 7pt; font-style: italic; text-align: right; vertical-align: middle"
        Me.txtPageNo.Top = 0.325!
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
        Me.txtDisclaimer.Width = 10.0!
        '
        'rptFireFacilityRatingSummary
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
        Me.PrintWidth = 10.05208!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Calibri; font-style: normal; text-decoration: none; font-weight: nor" & _
            "mal; font-size: 10pt; color: Black", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
            "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
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
        CType(Me.lblClientName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblReportName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGRCLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblReportDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSort, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPageNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisclaimer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
#End Region

    Private _SizeDiff As Single = 2.0

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
        'Dim zRiskScoreControls() As ARControl = {txtTotalScore, txtOverallScoreWithRecsComplete}
        'Dim zRiskRatingControls() As ARControl = {txtOverallPlantRating, txtOverallPlantRatingWithRecsComplete}
        'UtilReport.ActiveReport.SetItemBackColorByRiskRatingScore(Me, zRiskScoreControls, rptProperties)
        'UtilReport.ActiveReport.SetItemBackColorByRiskRating(Me, zRiskRatingControls, rptProperties)

        Dim zrpt As SectionReport = sender
        txtTotalScore.BackColor = System.Drawing.ColorTranslator.FromHtml(zrpt.AllFields("totalscorecolor").Value)
        txtOverallPlantRating.BackColor = System.Drawing.ColorTranslator.FromHtml(zrpt.AllFields("overallplantratingcolor").Value)
        txtOverallScoreWithRecsComplete.BackColor = System.Drawing.ColorTranslator.FromHtml(zrpt.AllFields("overallscorewithrecscompletecolor").Value)
        txtOverallPlantRatingWithRecsComplete.BackColor = System.Drawing.ColorTranslator.FromHtml(zrpt.AllFields("overallplantratingwithrecscompletecolor").Value)

    End Sub

    Private Sub rptFireFacilityRatingSummary_ReportStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportStart
        If UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.A) Then
            'If AppSession.APL = False Then 'Hide the APL fields when APL is false
            Me.PageSettings.Margins.Left = 1.43!
            Me.PageSettings.Margins.Right = 1.43!
            Me.PageSettings.PaperHeight = 11.0!
            Me.PageSettings.PaperWidth = 8.5!
            Me.PrintWidth = 8.14!
        End If

        lblClientName.Text = rptProperties.ClientName
        lblReportDate.Text = Now
    End Sub

    Private Sub rptFireFacilityRatingSummary_PageStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.PageStart
        UtilReport.ActiveReport.SetFilter(Me, rptProperties)
        UtilReport.ActiveReport.SetSort(Me, rptProperties)
        UtilReport.ActiveReport.SetDisclaimer(Me, rptProperties)
    End Sub

    Private Sub PageHeader1_Format(ByVal sender As Object, ByVal e As EventArgs) Handles PageHeader1.Format
        Dim zrptFireFacilityRatingSummarySubOverallRatingKey As New rptFireFacilityRatingSummarySubOverallRatingKey
        Dim zrptFireFacilityRatingSummarySubHeader As New rptFireFacilityRatingSummarySubHeader
        Dim zrptFireFacilityRatingSummarySubHeaderNoAPL As New rptFireFacilityRatingSummarySubHeaderNoAPL
        zrptFireFacilityRatingSummarySubOverallRatingKey.rptProperties = rptProperties
        srptFireFacilityRatingSummarySubOverallRatingKey.Report = zrptFireFacilityRatingSummarySubOverallRatingKey
        zrptFireFacilityRatingSummarySubHeader.rptProperties = rptProperties
        zrptFireFacilityRatingSummarySubHeaderNoAPL.rptProperties = rptProperties
        srptFireFacilityRatingSummarySubOverallRatingKey.Height = ((rptProperties.FireRatingRange.Count * 0.15) + 0.2)

        If UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.A) Then
            'If AppSession.APL = False Then 'Hide the APL fields when APL is false
            ResizeNoAPL()
            srptFireFacilityRatingSummarySubHeader.Report = zrptFireFacilityRatingSummarySubHeaderNoAPL
        Else
            srptFireFacilityRatingSummarySubHeader.Report = zrptFireFacilityRatingSummarySubHeader
        End If
    End Sub

    Private Sub ResizeNoAPL()
        lblClientName.Location = New PointF(lblClientName.Location.X - 2.05, 0.05!)
        lblReportName.Location = New PointF(lblReportName.Location.X - 2.05, 0.35!)

        txtFilters.Size = New SizeF(txtFilters.Size.Width - 2.05, 0.15!)

        srptFireFacilityRatingSummarySubOverallRatingKey.Location = New PointF(srptFireFacilityRatingSummarySubOverallRatingKey.Location.X - _SizeDiff, srptFireFacilityRatingSummarySubOverallRatingKey.Location.Y)
        txtDisclaimer.Size = New SizeF(txtDisclaimer.Width - _SizeDiff, txtDisclaimer.Height)

        srptFireFacilityRatingSummarySubHeader.Size = New SizeF(8.0!, 0.45!)
        txtSort.Size = New SizeF(8.0!, 0.15!)
        txtPageNo.Location = New PointF(6.0!, 0.2!)
    End Sub

    Private Sub Detail1_Format(ByVal sender As Object, ByVal e As EventArgs) Handles Detail1.Format
        If UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.A) Then
            'If AppSession.APL = False Then 'Hide the APL fields when APL is false
            lnRatingSummary1.Visible = False
            txtAPL.Visible = False
            lnRatingSummary2.Visible = False
            txtAPLFactor.Visible = False
            lnRatingSummary3.Visible = False
            txtAPLWithAllRecsComplete.Visible = False
            lnRatingSummary4.Visible = False
            txtAPLFactorWithAllRecsComplete.Visible = False

            lnRatingSummary5.X1 = 4.42!
            lnRatingSummary5.X2 = 4.42!
            txtPassiveScore.Location = New PointF(4.42!, 0.05!)
            lnRatingSummary6.X1 = 4.88!
            lnRatingSummary6.X2 = 4.88!
            txtActiveScore.Location = New PointF(4.88!, 0.05!)
            lnRatingSummary7.X1 = 5.34!
            lnRatingSummary7.X2 = 5.34!
            txtActiveScoreWithRecsComplete.Location = New PointF(5.34!, 0.05!)
            lnRatingSummary8.X1 = 5.8!
            lnRatingSummary8.X2 = 5.8!
            txtTotalScore.Location = New PointF(5.8!, 0.05!)
            lnRatingSummary9.X1 = 6.2!
            lnRatingSummary9.X2 = 6.2!
            txtOverallPlantRating.Location = New PointF(6.2!, 0.05!)
            lnRatingSummary10.X1 = 6.9!
            lnRatingSummary10.X2 = 6.9!
            txtOverallScoreWithRecsComplete.Location = New PointF(6.9!, 0.05!)
            lnRatingSummary11.X1 = 7.3!
            lnRatingSummary11.X2 = 7.3!
            txtOverallPlantRatingWithRecsComplete.Location = New PointF(7.3!, 0.05!)
            lnRatingSummary12.X1 = 8.0!
            lnRatingSummary12.X2 = 8.0!

            lnRatingSummaryTop.X2 = 8.0!
            lnRatingSummaryBottom.X2 = 8.0!
        End If
    End Sub

    Private Sub rptFireFacilityRatingSummary_ReportEnd(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportEnd
        DisposeParameters()
    End Sub

    Private Sub DisposeParameters()
        DataSource = Nothing
    End Sub

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties

End Class
