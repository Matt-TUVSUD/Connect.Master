Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports

Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing

Public Class rptFireFacilityRatingSummarySubHeaderNoAPL
    Inherits GrapeCity.ActiveReports.SectionReport
    Implements IUtilReport

#Region " ActiveReports Designer generated code "
    'Required by the ActiveReports Designer
    Private Shadows components As System.ComponentModel.IContainer
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
    Private WithEvents line57 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line59 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lblRatingSummary As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblPassiveScore As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblActiveScore As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblActivewRecs As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCurrentScore As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCurrentFactor As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label20 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label21 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblwRecsCompletedScore As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblwRecsCompletedFactor As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents line60 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line61 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line62 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lblLocationInformation As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents line87 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line88 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line89 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line90 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line91 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line3 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line4 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line95 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line94 As GrapeCity.ActiveReports.SectionReportModel.Line
    'NOTE: The following procedure is required by the ActiveReports Designer
    'It can be modified using the ActiveReports Designer.
    'Do not modify it using the code editor.
    Private WithEvents Detail1 As GrapeCity.ActiveReports.SectionReportModel.Detail
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptFireFacilityRatingSummarySubHeaderNoAPL))
        Me.Detail1 = New GrapeCity.ActiveReports.SectionReportModel.Detail()
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
        Me.line57 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line59 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lblRatingSummary = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPassiveScore = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblActiveScore = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblActivewRecs = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblCurrentScore = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblCurrentFactor = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label20 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label21 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblwRecsCompletedScore = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblwRecsCompletedFactor = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.line60 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line61 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line62 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line87 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line88 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line89 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line90 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line91 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line94 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line95 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
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
        CType(Me.lblRatingSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPassiveScore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblActiveScore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblActivewRecs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCurrentScore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCurrentFactor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblwRecsCompletedScore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblwRecsCompletedFactor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblLocationInformation, Me.lblFileNo, Me.lblDivision2, Me.lblInspectionDate, Me.lblClientLocNo, Me.lblFacility, Me.lblCity, Me.txtSTProv, Me.txtCountry, Me.lblTIVGrid, Me.lblAddress, Me.line56, Me.line57, Me.line59, Me.lblRatingSummary, Me.lblPassiveScore, Me.lblActiveScore, Me.lblActivewRecs, Me.lblCurrentScore, Me.lblCurrentFactor, Me.label20, Me.label21, Me.lblwRecsCompletedScore, Me.lblwRecsCompletedFactor, Me.line60, Me.line61, Me.line62, Me.line87, Me.line88, Me.line89, Me.line90, Me.line91, Me.line94, Me.line95, Me.line1, Me.line2, Me.line3, Me.line4})
        Me.Detail1.Height = 0.45!
        Me.Detail1.Name = "Detail1"
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
        Me.lblLocationInformation.Top = 0.0!
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
        Me.lblFileNo.Top = 0.15!
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
        Me.lblDivision2.Top = 0.3!
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
        Me.lblInspectionDate.Top = 0.15!
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
        Me.lblClientLocNo.Top = 0.15!
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
        Me.lblFacility.Top = 0.3!
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
        Me.lblCity.Top = 0.15!
        Me.lblCity.Width = 0.95!
        '
        'txtSTProv
        '
        Me.txtSTProv.Height = 0.15!
        Me.txtSTProv.Left = 2.85!
        Me.txtSTProv.Name = "txtSTProv"
        Me.txtSTProv.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.txtSTProv.Text = "St/Pr"
        Me.txtSTProv.Top = 0.15!
        Me.txtSTProv.Width = 0.35!
        '
        'txtCountry
        '
        Me.txtCountry.Height = 0.15!
        Me.txtCountry.Left = 3.2!
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.txtCountry.Text = "Country"
        Me.txtCountry.Top = 0.15!
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
        Me.lblTIVGrid.Top = 0.0999999!
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
        Me.lblAddress.Top = 0.3!
        Me.lblAddress.Width = 2.05!
        '
        'line56
        '
        Me.line56.Height = 0.0!
        Me.line56.Left = 0.0!
        Me.line56.LineWeight = 1.0!
        Me.line56.Name = "line56"
        Me.line56.Top = 0.0!
        Me.line56.Width = 4.37!
        Me.line56.X1 = 0.0!
        Me.line56.X2 = 4.37!
        Me.line56.Y1 = 0.0!
        Me.line56.Y2 = 0.0!
        '
        'line57
        '
        Me.line57.Height = 0.0!
        Me.line57.Left = 0.0!
        Me.line57.LineWeight = 1.0!
        Me.line57.Name = "line57"
        Me.line57.Top = 0.45!
        Me.line57.Width = 4.37!
        Me.line57.X1 = 0.0!
        Me.line57.X2 = 4.37!
        Me.line57.Y1 = 0.45!
        Me.line57.Y2 = 0.45!
        '
        'line59
        '
        Me.line59.Height = 0.45!
        Me.line59.Left = 4.37!
        Me.line59.LineWeight = 1.0!
        Me.line59.Name = "line59"
        Me.line59.Top = 0.0!
        Me.line59.Width = 0.0!
        Me.line59.X1 = 4.37!
        Me.line59.X2 = 4.37!
        Me.line59.Y1 = 0.0!
        Me.line59.Y2 = 0.45!
        '
        'lblRatingSummary
        '
        Me.lblRatingSummary.Height = 0.15!
        Me.lblRatingSummary.HyperLink = Nothing
        Me.lblRatingSummary.Left = 4.42!
        Me.lblRatingSummary.Name = "lblRatingSummary"
        Me.lblRatingSummary.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblRatingSummary.Text = "Rating Summary"
        Me.lblRatingSummary.Top = 0.0!
        Me.lblRatingSummary.Width = 3.58!
        '
        'lblPassiveScore
        '
        Me.lblPassiveScore.Height = 0.3!
        Me.lblPassiveScore.HyperLink = Nothing
        Me.lblPassiveScore.Left = 4.42!
        Me.lblPassiveScore.Name = "lblPassiveScore"
        Me.lblPassiveScore.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblPassiveScore.Text = "Passive Score"
        Me.lblPassiveScore.Top = 0.15!
        Me.lblPassiveScore.Width = 0.46!
        '
        'lblActiveScore
        '
        Me.lblActiveScore.Height = 0.3!
        Me.lblActiveScore.HyperLink = Nothing
        Me.lblActiveScore.Left = 4.88!
        Me.lblActiveScore.Name = "lblActiveScore"
        Me.lblActiveScore.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblActiveScore.Text = "Active Score"
        Me.lblActiveScore.Top = 0.15!
        Me.lblActiveScore.Width = 0.46!
        '
        'lblActivewRecs
        '
        Me.lblActivewRecs.Height = 0.3!
        Me.lblActivewRecs.HyperLink = Nothing
        Me.lblActivewRecs.Left = 5.34!
        Me.lblActivewRecs.Name = "lblActivewRecs"
        Me.lblActivewRecs.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblActivewRecs.Text = "Active w/Recs"
        Me.lblActivewRecs.Top = 0.15!
        Me.lblActivewRecs.Width = 0.46!
        '
        'lblCurrentScore
        '
        Me.lblCurrentScore.Height = 0.15!
        Me.lblCurrentScore.HyperLink = Nothing
        Me.lblCurrentScore.Left = 5.8!
        Me.lblCurrentScore.Name = "lblCurrentScore"
        Me.lblCurrentScore.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblCurrentScore.Text = "Score"
        Me.lblCurrentScore.Top = 0.3!
        Me.lblCurrentScore.Width = 0.4!
        '
        'lblCurrentFactor
        '
        Me.lblCurrentFactor.Height = 0.15!
        Me.lblCurrentFactor.HyperLink = Nothing
        Me.lblCurrentFactor.Left = 6.2!
        Me.lblCurrentFactor.Name = "lblCurrentFactor"
        Me.lblCurrentFactor.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblCurrentFactor.Text = "Rating"
        Me.lblCurrentFactor.Top = 0.3!
        Me.lblCurrentFactor.Width = 0.7!
        '
        'label20
        '
        Me.label20.Height = 0.15!
        Me.label20.HyperLink = Nothing
        Me.label20.Left = 5.8!
        Me.label20.Name = "label20"
        Me.label20.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.label20.Text = "Current"
        Me.label20.Top = 0.15!
        Me.label20.Width = 1.1!
        '
        'label21
        '
        Me.label21.Height = 0.15!
        Me.label21.HyperLink = Nothing
        Me.label21.Left = 6.9!
        Me.label21.Name = "label21"
        Me.label21.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.label21.Text = "w/Recs Completed"
        Me.label21.Top = 0.15!
        Me.label21.Width = 1.1!
        '
        'lblwRecsCompletedScore
        '
        Me.lblwRecsCompletedScore.Height = 0.15!
        Me.lblwRecsCompletedScore.HyperLink = Nothing
        Me.lblwRecsCompletedScore.Left = 6.9!
        Me.lblwRecsCompletedScore.Name = "lblwRecsCompletedScore"
        Me.lblwRecsCompletedScore.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblwRecsCompletedScore.Text = "Score"
        Me.lblwRecsCompletedScore.Top = 0.3!
        Me.lblwRecsCompletedScore.Width = 0.4!
        '
        'lblwRecsCompletedFactor
        '
        Me.lblwRecsCompletedFactor.Height = 0.15!
        Me.lblwRecsCompletedFactor.HyperLink = Nothing
        Me.lblwRecsCompletedFactor.Left = 7.3!
        Me.lblwRecsCompletedFactor.Name = "lblwRecsCompletedFactor"
        Me.lblwRecsCompletedFactor.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblwRecsCompletedFactor.Text = "Rating"
        Me.lblwRecsCompletedFactor.Top = 0.3!
        Me.lblwRecsCompletedFactor.Width = 0.7!
        '
        'line60
        '
        Me.line60.Height = 0.45!
        Me.line60.Left = 4.42!
        Me.line60.LineWeight = 1.0!
        Me.line60.Name = "line60"
        Me.line60.Top = 0.0!
        Me.line60.Width = 0.0!
        Me.line60.X1 = 4.42!
        Me.line60.X2 = 4.42!
        Me.line60.Y1 = 0.0!
        Me.line60.Y2 = 0.45!
        '
        'line61
        '
        Me.line61.Height = 0.0!
        Me.line61.Left = 4.42!
        Me.line61.LineWeight = 1.0!
        Me.line61.Name = "line61"
        Me.line61.Top = 0.45!
        Me.line61.Width = 3.72!
        Me.line61.X1 = 4.42!
        Me.line61.X2 = 8.14!
        Me.line61.Y1 = 0.45!
        Me.line61.Y2 = 0.45!
        '
        'line62
        '
        Me.line62.Height = 0.0!
        Me.line62.Left = 4.42!
        Me.line62.LineWeight = 1.0!
        Me.line62.Name = "line62"
        Me.line62.Top = 0.0!
        Me.line62.Width = 3.58!
        Me.line62.X1 = 4.42!
        Me.line62.X2 = 8.0!
        Me.line62.Y1 = 0.0!
        Me.line62.Y2 = 0.0!
        '
        'line87
        '
        Me.line87.Height = 0.3!
        Me.line87.Left = 5.34!
        Me.line87.LineWeight = 1.0!
        Me.line87.Name = "line87"
        Me.line87.Top = 0.15!
        Me.line87.Width = 0.0!
        Me.line87.X1 = 5.34!
        Me.line87.X2 = 5.34!
        Me.line87.Y1 = 0.15!
        Me.line87.Y2 = 0.45!
        '
        'line88
        '
        Me.line88.Height = 0.3!
        Me.line88.Left = 4.88!
        Me.line88.LineWeight = 1.0!
        Me.line88.Name = "line88"
        Me.line88.Top = 0.15!
        Me.line88.Width = 0.0!
        Me.line88.X1 = 4.88!
        Me.line88.X2 = 4.88!
        Me.line88.Y1 = 0.15!
        Me.line88.Y2 = 0.45!
        '
        'line89
        '
        Me.line89.Height = 0.3!
        Me.line89.Left = 5.8!
        Me.line89.LineWeight = 1.0!
        Me.line89.Name = "line89"
        Me.line89.Top = 0.15!
        Me.line89.Width = 0.0!
        Me.line89.X1 = 5.8!
        Me.line89.X2 = 5.8!
        Me.line89.Y1 = 0.15!
        Me.line89.Y2 = 0.45!
        '
        'line90
        '
        Me.line90.Height = 0.3!
        Me.line90.Left = 6.9!
        Me.line90.LineWeight = 1.0!
        Me.line90.Name = "line90"
        Me.line90.Top = 0.15!
        Me.line90.Width = 0.0!
        Me.line90.X1 = 6.9!
        Me.line90.X2 = 6.9!
        Me.line90.Y1 = 0.15!
        Me.line90.Y2 = 0.45!
        '
        'line91
        '
        Me.line91.Height = 0.0!
        Me.line91.Left = 5.8!
        Me.line91.LineWeight = 1.0!
        Me.line91.Name = "line91"
        Me.line91.Top = 0.3!
        Me.line91.Width = 2.2!
        Me.line91.X1 = 5.8!
        Me.line91.X2 = 8.0!
        Me.line91.Y1 = 0.3!
        Me.line91.Y2 = 0.3!
        '
        'line94
        '
        Me.line94.Height = 0.15!
        Me.line94.Left = 7.3!
        Me.line94.LineWeight = 1.0!
        Me.line94.Name = "line94"
        Me.line94.Top = 0.3!
        Me.line94.Width = 0.0!
        Me.line94.X1 = 7.3!
        Me.line94.X2 = 7.3!
        Me.line94.Y1 = 0.3!
        Me.line94.Y2 = 0.45!
        '
        'line95
        '
        Me.line95.Height = 0.15!
        Me.line95.Left = 6.2!
        Me.line95.LineWeight = 1.0!
        Me.line95.Name = "line95"
        Me.line95.Top = 0.3!
        Me.line95.Width = 0.0!
        Me.line95.X1 = 6.2!
        Me.line95.X2 = 6.2!
        Me.line95.Y1 = 0.3!
        Me.line95.Y2 = 0.45!
        '
        'line1
        '
        Me.line1.Height = 0.45!
        Me.line1.Left = 0.0!
        Me.line1.LineWeight = 1.0!
        Me.line1.Name = "line1"
        Me.line1.Top = 0.0!
        Me.line1.Width = 0.0!
        Me.line1.X1 = 0.0!
        Me.line1.X2 = 0.0!
        Me.line1.Y1 = 0.0!
        Me.line1.Y2 = 0.45!
        '
        'line2
        '
        Me.line2.Height = 0.45!
        Me.line2.Left = 8.0!
        Me.line2.LineWeight = 1.0!
        Me.line2.Name = "line2"
        Me.line2.Top = 0.0!
        Me.line2.Width = 0.0!
        Me.line2.X1 = 8.0!
        Me.line2.X2 = 8.0!
        Me.line2.Y1 = 0.0!
        Me.line2.Y2 = 0.45!
        '
        'line3
        '
        Me.line3.Height = 0.0!
        Me.line3.Left = 4.42!
        Me.line3.LineWeight = 1.0!
        Me.line3.Name = "line3"
        Me.line3.Top = 0.15!
        Me.line3.Width = 3.58!
        Me.line3.X1 = 4.42!
        Me.line3.X2 = 8.0!
        Me.line3.Y1 = 0.15!
        Me.line3.Y2 = 0.15!
        '
        'line4
        '
        Me.line4.Height = 0.0!
        Me.line4.Left = 0.0!
        Me.line4.LineWeight = 1.0!
        Me.line4.Name = "line4"
        Me.line4.Top = 0.0!
        Me.line4.Width = 4.37!
        Me.line4.X1 = 0.0!
        Me.line4.X2 = 4.37!
        Me.line4.Y1 = 0.0!
        Me.line4.Y2 = 0.0!
        '
        'rptFireFacilityRatingSummarySubHeaderNoAPL
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 8.0!
        Me.Sections.Add(Me.Detail1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Calibri; font-style: normal; text-decoration: none; font-weight: nor" & _
            "mal; font-size: 10pt; color: Black", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
            "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
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
        CType(Me.lblRatingSummary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPassiveScore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblActiveScore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblActivewRecs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCurrentScore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCurrentFactor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblwRecsCompletedScore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblwRecsCompletedFactor, System.ComponentModel.ISupportInitialize).EndInit()
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

    Private Sub Detail1_Format(ByVal sender As Object, ByVal e As EventArgs) Handles Detail1.Format
        lblTIVGrid.Text = "TIV " & rptProperties.Currency.colFldCode & vbLf & "(milions)"
    End Sub

    Public Property rptProperties As IBatchSetReportProperties Implements  IUtilReport.rptProperties

End Class
