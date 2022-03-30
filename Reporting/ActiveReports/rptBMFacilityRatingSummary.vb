Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports

Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing

Public Class rptBMFacilityRatingSummary
    Inherits GrapeCity.ActiveReports.SectionReport
    Implements IUtilReport

#Region " ActiveReports Designer generated code "
    'Required by the ActiveReports Designer
    Private Shadows components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the ActiveReports Designer
    'It can be modified using the ActiveReports Designer.
    'Do not modify it using the code editor.
    Private WithEvents PageHeader1 As GrapeCity.ActiveReports.SectionReportModel.PageHeader
    Private WithEvents Detail1 As GrapeCity.ActiveReports.SectionReportModel.Detail
    Private WithEvents label3 As GrapeCity.ActiveReports.SectionReportModel.Label
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
    Private WithEvents line45 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtPassiveScore As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtPassiveWRecs As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtActiveScore As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtActiveWRecs As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCurrentScore As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtRecsCompletedScore As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCurrentFactor As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtRecsCompletedFactor As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents line46 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line47 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line51 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line52 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line53 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line54 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line55 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line80 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line81 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line82 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line83 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lblReportDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtSort As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents reportInfo1 As GrapeCity.ActiveReports.SectionReportModel.ReportInfo
    Private WithEvents picture1 As GrapeCity.ActiveReports.SectionReportModel.Picture
    Private WithEvents srptBMFacilityRatingSummarySubOverallRatingKey As GrapeCity.ActiveReports.SectionReportModel.SubReport
    Private WithEvents srptBMFacilityRatingSummarySubHeader As GrapeCity.ActiveReports.SectionReportModel.SubReport
    Private WithEvents lblClientName As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents GroupHeader1 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
    Private WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
    Private WithEvents txtDisclaimer As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents PageFooter1 As GrapeCity.ActiveReports.SectionReportModel.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptBMFacilityRatingSummary))
        Me.PageHeader1 = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtFilters = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblFilters = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.picture1 = New GrapeCity.ActiveReports.SectionReportModel.Picture()
        Me.lblClientName = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.srptBMFacilityRatingSummarySubOverallRatingKey = New GrapeCity.ActiveReports.SectionReportModel.SubReport()
        Me.srptBMFacilityRatingSummarySubHeader = New GrapeCity.ActiveReports.SectionReportModel.SubReport()
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
        Me.txtPassiveScore = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPassiveWRecs = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtActiveScore = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtActiveWRecs = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCurrentScore = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtRecsCompletedScore = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCurrentFactor = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtRecsCompletedFactor = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.line46 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line47 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line51 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line52 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line53 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line54 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line55 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line80 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line81 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line82 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line83 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.PageFooter1 = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.lblReportDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtSort = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.reportInfo1 = New GrapeCity.ActiveReports.SectionReportModel.ReportInfo()
        Me.txtDisclaimer = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        CType(Me.label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblClientName, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.txtPassiveScore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassiveWRecs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActiveScore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActiveWRecs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCurrentScore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRecsCompletedScore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCurrentFactor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRecsCompletedFactor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblReportDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisclaimer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.label3, Me.txtFilters, Me.lblFilters, Me.picture1, Me.lblClientName, Me.srptBMFacilityRatingSummarySubOverallRatingKey})
        Me.PageHeader1.Height = 1.872917!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'label3
        '
        Me.label3.Height = 0.25!
        Me.label3.HyperLink = Nothing
        Me.label3.Left = 5.66!
        Me.label3.Name = "label3"
        Me.label3.Style = "font-size: 12pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.label3.Text = "B&M Facility Rating Summary"
        Me.label3.Top = 0.35!
        Me.label3.Width = 4.3!
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
        Me.lblClientName.Left = 5.66!
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Style = "color: #C6D1DE; font-size: 16pt; font-style: italic; font-weight: bold; text-alig" & _
    "n: right; vertical-align: middle"
        Me.lblClientName.Text = "Company Name"
        Me.lblClientName.Top = 0.05000003!
        Me.lblClientName.Width = 4.3!
        '
        'srptBMFacilityRatingSummarySubOverallRatingKey
        '
        Me.srptBMFacilityRatingSummarySubOverallRatingKey.CloseBorder = False
        Me.srptBMFacilityRatingSummarySubOverallRatingKey.Height = 0.95!
        Me.srptBMFacilityRatingSummarySubOverallRatingKey.Left = 6.562!
        Me.srptBMFacilityRatingSummarySubOverallRatingKey.Name = "srptBMFacilityRatingSummarySubOverallRatingKey"
        Me.srptBMFacilityRatingSummarySubOverallRatingKey.Report = Nothing
        Me.srptBMFacilityRatingSummarySubOverallRatingKey.ReportName = ""
        Me.srptBMFacilityRatingSummarySubOverallRatingKey.Top = 0.812!
        Me.srptBMFacilityRatingSummarySubOverallRatingKey.Width = 3.438!
        '
        'srptBMFacilityRatingSummarySubHeader
        '
        Me.srptBMFacilityRatingSummarySubHeader.CloseBorder = False
        Me.srptBMFacilityRatingSummarySubHeader.Height = 0.45!
        Me.srptBMFacilityRatingSummarySubHeader.Left = 0.0!
        Me.srptBMFacilityRatingSummarySubHeader.Name = "srptBMFacilityRatingSummarySubHeader"
        Me.srptBMFacilityRatingSummarySubHeader.Report = Nothing
        Me.srptBMFacilityRatingSummarySubHeader.ReportName = "rptBMFacilityRatingSummarySubHeader"
        Me.srptBMFacilityRatingSummarySubHeader.Top = 0.0!
        Me.srptBMFacilityRatingSummarySubHeader.Width = 10.0!
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtAddress, Me.txtDivision2, Me.txtFileNo, Me.txtSurveyDate, Me.txtCity, Me.textBox1, Me.textBox2, Me.txtTIV, Me.txtFacility, Me.txtClientLocNo, Me.line38, Me.line39, Me.line40, Me.line44, Me.line45, Me.txtPassiveScore, Me.txtPassiveWRecs, Me.txtActiveScore, Me.txtActiveWRecs, Me.txtCurrentScore, Me.txtRecsCompletedScore, Me.txtCurrentFactor, Me.txtRecsCompletedFactor, Me.line46, Me.line47, Me.line51, Me.line52, Me.line53, Me.line54, Me.line55, Me.line80, Me.line81, Me.line82, Me.line83})
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
        'txtPassiveScore
        '
        Me.txtPassiveScore.DataField = "PassiveC"
        Me.txtPassiveScore.Height = 0.3!
        Me.txtPassiveScore.Left = 4.42!
        Me.txtPassiveScore.Name = "txtPassiveScore"
        Me.txtPassiveScore.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtPassiveScore.Text = "Physical Assets" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Score"
        Me.txtPassiveScore.Top = 0.05!
        Me.txtPassiveScore.Width = 0.85!
        '
        'txtPassiveWRecs
        '
        Me.txtPassiveWRecs.DataField = "PassiveWC"
        Me.txtPassiveWRecs.Height = 0.3!
        Me.txtPassiveWRecs.Left = 5.27!
        Me.txtPassiveWRecs.Name = "txtPassiveWRecs"
        Me.txtPassiveWRecs.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtPassiveWRecs.Text = "Physical Assets" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "w/Recs"
        Me.txtPassiveWRecs.Top = 0.05!
        Me.txtPassiveWRecs.Width = 0.85!
        '
        'txtActiveScore
        '
        Me.txtActiveScore.DataField = "ActiveC"
        Me.txtActiveScore.Height = 0.3!
        Me.txtActiveScore.Left = 6.12!
        Me.txtActiveScore.Name = "txtActiveScore"
        Me.txtActiveScore.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtActiveScore.Text = "Management Programs" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Score"
        Me.txtActiveScore.Top = 0.05!
        Me.txtActiveScore.Width = 0.85!
        '
        'txtActiveWRecs
        '
        Me.txtActiveWRecs.DataField = "ActiveWC"
        Me.txtActiveWRecs.Height = 0.3!
        Me.txtActiveWRecs.Left = 6.97!
        Me.txtActiveWRecs.Name = "txtActiveWRecs"
        Me.txtActiveWRecs.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtActiveWRecs.Text = "Management Programs" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " w/Recs"
        Me.txtActiveWRecs.Top = 0.05!
        Me.txtActiveWRecs.Width = 0.85!
        '
        'txtCurrentScore
        '
        Me.txtCurrentScore.DataField = "TotalScoreCurrent"
        Me.txtCurrentScore.Height = 0.3!
        Me.txtCurrentScore.Left = 7.8!
        Me.txtCurrentScore.Name = "txtCurrentScore"
        Me.txtCurrentScore.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtCurrentScore.Text = "Score"
        Me.txtCurrentScore.Top = 0.05!
        Me.txtCurrentScore.Width = 0.4!
        '
        'txtRecsCompletedScore
        '
        Me.txtRecsCompletedScore.DataField = "TotalWRComplete"
        Me.txtRecsCompletedScore.Height = 0.3!
        Me.txtRecsCompletedScore.Left = 8.9!
        Me.txtRecsCompletedScore.Name = "txtRecsCompletedScore"
        Me.txtRecsCompletedScore.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtRecsCompletedScore.Text = "Score"
        Me.txtRecsCompletedScore.Top = 0.05!
        Me.txtRecsCompletedScore.Width = 0.4!
        '
        'txtCurrentFactor
        '
        Me.txtCurrentFactor.DataField = "TotalRating"
        Me.txtCurrentFactor.Height = 0.3!
        Me.txtCurrentFactor.Left = 8.2!
        Me.txtCurrentFactor.Name = "txtCurrentFactor"
        Me.txtCurrentFactor.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtCurrentFactor.Text = "Factor"
        Me.txtCurrentFactor.Top = 0.05!
        Me.txtCurrentFactor.Width = 0.7!
        '
        'txtRecsCompletedFactor
        '
        Me.txtRecsCompletedFactor.DataField = "TotalWRCompleteRating"
        Me.txtRecsCompletedFactor.Height = 0.3!
        Me.txtRecsCompletedFactor.Left = 9.3!
        Me.txtRecsCompletedFactor.Name = "txtRecsCompletedFactor"
        Me.txtRecsCompletedFactor.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtRecsCompletedFactor.Text = "Factor"
        Me.txtRecsCompletedFactor.Top = 0.05!
        Me.txtRecsCompletedFactor.Width = 0.7!
        '
        'line46
        '
        Me.line46.Height = 0.3!
        Me.line46.Left = 4.42!
        Me.line46.LineWeight = 1.0!
        Me.line46.Name = "line46"
        Me.line46.Top = 0.05!
        Me.line46.Width = 0.0!
        Me.line46.X1 = 4.42!
        Me.line46.X2 = 4.42!
        Me.line46.Y1 = 0.05!
        Me.line46.Y2 = 0.35!
        '
        'line47
        '
        Me.line47.Height = 0.3!
        Me.line47.Left = 5.27!
        Me.line47.LineWeight = 1.0!
        Me.line47.Name = "line47"
        Me.line47.Top = 0.05!
        Me.line47.Width = 0.0!
        Me.line47.X1 = 5.27!
        Me.line47.X2 = 5.27!
        Me.line47.Y1 = 0.05!
        Me.line47.Y2 = 0.35!
        '
        'line51
        '
        Me.line51.Height = 0.3!
        Me.line51.Left = 6.12!
        Me.line51.LineWeight = 1.0!
        Me.line51.Name = "line51"
        Me.line51.Top = 0.05!
        Me.line51.Width = 0.0!
        Me.line51.X1 = 6.12!
        Me.line51.X2 = 6.12!
        Me.line51.Y1 = 0.05!
        Me.line51.Y2 = 0.35!
        '
        'line52
        '
        Me.line52.Height = 0.3!
        Me.line52.Left = 6.97!
        Me.line52.LineWeight = 1.0!
        Me.line52.Name = "line52"
        Me.line52.Top = 0.05!
        Me.line52.Width = 0.0!
        Me.line52.X1 = 6.97!
        Me.line52.X2 = 6.97!
        Me.line52.Y1 = 0.05!
        Me.line52.Y2 = 0.35!
        '
        'line53
        '
        Me.line53.Height = 0.3!
        Me.line53.Left = 7.8!
        Me.line53.LineWeight = 1.0!
        Me.line53.Name = "line53"
        Me.line53.Top = 0.05!
        Me.line53.Width = 0.0!
        Me.line53.X1 = 7.8!
        Me.line53.X2 = 7.8!
        Me.line53.Y1 = 0.05!
        Me.line53.Y2 = 0.35!
        '
        'line54
        '
        Me.line54.Height = 0.3!
        Me.line54.Left = 9.3!
        Me.line54.LineWeight = 1.0!
        Me.line54.Name = "line54"
        Me.line54.Top = 0.05!
        Me.line54.Width = 0.0!
        Me.line54.X1 = 9.3!
        Me.line54.X2 = 9.3!
        Me.line54.Y1 = 0.05!
        Me.line54.Y2 = 0.35!
        '
        'line55
        '
        Me.line55.Height = 0.3!
        Me.line55.Left = 8.9!
        Me.line55.LineWeight = 1.0!
        Me.line55.Name = "line55"
        Me.line55.Top = 0.05!
        Me.line55.Width = 0.0!
        Me.line55.X1 = 8.9!
        Me.line55.X2 = 8.9!
        Me.line55.Y1 = 0.05!
        Me.line55.Y2 = 0.35!
        '
        'line80
        '
        Me.line80.Height = 0.3!
        Me.line80.Left = 8.2!
        Me.line80.LineWeight = 1.0!
        Me.line80.Name = "line80"
        Me.line80.Top = 0.05!
        Me.line80.Width = 0.0!
        Me.line80.X1 = 8.2!
        Me.line80.X2 = 8.2!
        Me.line80.Y1 = 0.05!
        Me.line80.Y2 = 0.35!
        '
        'line81
        '
        Me.line81.Height = 0.3!
        Me.line81.Left = 10.0!
        Me.line81.LineWeight = 1.0!
        Me.line81.Name = "line81"
        Me.line81.Top = 0.05!
        Me.line81.Width = 0.0!
        Me.line81.X1 = 10.0!
        Me.line81.X2 = 10.0!
        Me.line81.Y1 = 0.05!
        Me.line81.Y2 = 0.35!
        '
        'line82
        '
        Me.line82.Height = 0.0!
        Me.line82.Left = 4.42!
        Me.line82.LineWeight = 1.0!
        Me.line82.Name = "line82"
        Me.line82.Top = 0.35!
        Me.line82.Width = 5.58!
        Me.line82.X1 = 4.42!
        Me.line82.X2 = 10.0!
        Me.line82.Y1 = 0.35!
        Me.line82.Y2 = 0.35!
        '
        'line83
        '
        Me.line83.Height = 0.0!
        Me.line83.Left = 4.42!
        Me.line83.LineWeight = 1.0!
        Me.line83.Name = "line83"
        Me.line83.Top = 0.05!
        Me.line83.Width = 5.58!
        Me.line83.X1 = 4.42!
        Me.line83.X2 = 10.0!
        Me.line83.Y1 = 0.05!
        Me.line83.Y2 = 0.05!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblReportDate, Me.txtSort, Me.reportInfo1, Me.txtDisclaimer})
        Me.PageFooter1.Height = 0.5895833!
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
        Me.lblReportDate.Top = 0.375!
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
        Me.reportInfo1.Top = 0.375!
        Me.reportInfo1.Width = 2.0!
        '
        'txtDisclaimer
        '
        Me.txtDisclaimer.CanShrink = True
        Me.txtDisclaimer.Height = 0.15!
        Me.txtDisclaimer.Left = 0.012!
        Me.txtDisclaimer.Name = "txtDisclaimer"
        Me.txtDisclaimer.Style = "font-size: 7pt; font-style: italic; text-align: center; vertical-align: middle"
        Me.txtDisclaimer.Text = "Disclaimer"
        Me.txtDisclaimer.Top = 0.187!
        Me.txtDisclaimer.Width = 10.0!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.srptBMFacilityRatingSummarySubHeader})
        Me.GroupHeader1.Height = 0.45!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'rptBMFacilityRatingSummary
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
        Me.PrintWidth = 10.00417!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Calibri; font-style: normal; text-decoration: none; font-weight: nor" & _
            "mal; font-size: 10pt; color: Black", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
            "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblClientName, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.txtPassiveScore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassiveWRecs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActiveScore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActiveWRecs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCurrentScore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRecsCompletedScore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCurrentFactor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRecsCompletedFactor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblReportDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSort, System.ComponentModel.ISupportInitialize).EndInit()
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

    Private Sub rptBMFacilityRatingSummary_FetchData(ByVal sender As Object, ByVal eArgs As FetchEventArgs) Handles Me.FetchData
        txtTIV.Text = "TIV " & rptProperties.Currency.colFldCode & vbLf & "(millions)"

        Dim zrpt As SectionReport = sender
        txtCurrentFactor.BackColor = System.Drawing.ColorTranslator.FromHtml(zrpt.AllFields("totalratingColor").Value)
        txtRecsCompletedFactor.BackColor = System.Drawing.ColorTranslator.FromHtml(zrpt.AllFields("totalwrcompleteratingColor").Value)
   
        Dim zControls As ARControl() = {txtCurrentScore, txtRecsCompletedScore}
        UtilReport.ActiveReport.SetItemBackColorByRiskRatingScore(Me, zControls, rptProperties)

    End Sub

    Private Sub rptBMFacilityRatingSummary_ReportStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportStart

        lblClientName.Text = rptProperties.ClientName 'AppSession.ClientName
        lblReportDate.Text = Now.ToString 'modActiveReport.ReportDate

        Dim rpt As New rptBMFacilityRatingSummarySubOverallRatingKey()
        rpt.rptProperties = rptProperties
        Me.srptBMFacilityRatingSummarySubOverallRatingKey.Report = rpt
        Me.srptBMFacilityRatingSummarySubOverallRatingKey.Height = ((rptProperties.BMRatingRange.Count * 0.15) + 0.2)


        Dim rpt2 As New rptBMFacilityRatingSummarySubHeader()
        rpt2.rptProperties = rptProperties
        Me.srptBMFacilityRatingSummarySubHeader.Report = rpt2

    End Sub

    Private Sub PageHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageHeader1.Format

    End Sub

    Private Sub rptBMFacilityRatingSummary_PageStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.PageStart
        UtilReport.ActiveReport.SetFilter(Me, rptProperties)
        UtilReport.ActiveReport.SetSort(Me, rptProperties)
        UtilReport.ActiveReport.SetDisclaimer(Me, rptProperties)
    End Sub

    Private Sub rptBMFacilityRatingSummary_ReportEnd(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportEnd
        DisposeParameters()
    End Sub

    Private Sub DisposeParameters()
        DataSource = Nothing
    End Sub

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties
End Class
