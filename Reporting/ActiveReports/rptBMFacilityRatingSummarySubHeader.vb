Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports

Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing

Public Class rptBMFacilityRatingSummarySubHeader
    Inherits GrapeCity.ActiveReports.SectionReport
    Implements IUtilReport

#Region " ActiveReports Designer generated code "
    'Required by the ActiveReports Designer
    Private Shadows components As System.ComponentModel.IContainer
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
    Private WithEvents line57 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line59 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line95 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line94 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents label8 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblPassiveScore As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblPassiveWRecs As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblActiveScore As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblActiveWRecs As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label18 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label19 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label20 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label21 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label22 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label23 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents line60 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line61 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line62 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line63 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line85 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line86 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line88 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line89 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line90 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line58 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line91 As GrapeCity.ActiveReports.SectionReportModel.Line

    'NOTE: The following procedure is required by the ActiveReports Designer
    'It can be modified using the ActiveReports Designer.
    'Do not modify it using the code editor.
    Private WithEvents Detail1 As GrapeCity.ActiveReports.SectionReportModel.Detail
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptBMFacilityRatingSummarySubHeader))
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
        Me.label8 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPassiveScore = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPassiveWRecs = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblActiveScore = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblActiveWRecs = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label18 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label19 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label20 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label21 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label22 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label23 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.line60 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line61 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line62 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line63 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line85 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line86 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line88 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line89 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line90 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line91 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line94 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line95 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line58 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
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
        CType(Me.lblPassiveScore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPassiveWRecs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblActiveScore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblActiveWRecs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblLocationInformation, Me.lblFileNo, Me.lblDivision2, Me.lblInspectionDate, Me.lblClientLocNo, Me.lblFacility, Me.lblCity, Me.txtSTProv, Me.txtCountry, Me.lblTIVGrid, Me.lblAddress, Me.line56, Me.line57, Me.line59, Me.label8, Me.lblPassiveScore, Me.lblPassiveWRecs, Me.lblActiveScore, Me.lblActiveWRecs, Me.label18, Me.label19, Me.label20, Me.label21, Me.label22, Me.label23, Me.line60, Me.line61, Me.line62, Me.line63, Me.line85, Me.line86, Me.line88, Me.line89, Me.line90, Me.line91, Me.line94, Me.line95, Me.line58, Me.line1})
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
        'label8
        '
        Me.label8.Height = 0.15!
        Me.label8.HyperLink = Nothing
        Me.label8.Left = 4.42!
        Me.label8.Name = "label8"
        Me.label8.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.label8.Text = "Rating Summary"
        Me.label8.Top = 0.0!
        Me.label8.Width = 5.58!
        '
        'lblPassiveScore
        '
        Me.lblPassiveScore.Height = 0.3!
        Me.lblPassiveScore.HyperLink = Nothing
        Me.lblPassiveScore.Left = 4.42!
        Me.lblPassiveScore.Name = "lblPassiveScore"
        Me.lblPassiveScore.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblPassiveScore.Text = "Physical Assets" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Score"
        Me.lblPassiveScore.Top = 0.15!
        Me.lblPassiveScore.Width = 0.85!
        '
        'lblPassiveWRecs
        '
        Me.lblPassiveWRecs.Height = 0.3!
        Me.lblPassiveWRecs.HyperLink = Nothing
        Me.lblPassiveWRecs.Left = 5.27!
        Me.lblPassiveWRecs.Name = "lblPassiveWRecs"
        Me.lblPassiveWRecs.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblPassiveWRecs.Text = "Physical Assets" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " w/Recs"
        Me.lblPassiveWRecs.Top = 0.15!
        Me.lblPassiveWRecs.Width = 0.85!
        '
        'lblActiveScore
        '
        Me.lblActiveScore.Height = 0.3!
        Me.lblActiveScore.HyperLink = Nothing
        Me.lblActiveScore.Left = 6.12!
        Me.lblActiveScore.Name = "lblActiveScore"
        Me.lblActiveScore.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblActiveScore.Text = "Management Programs " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Score"
        Me.lblActiveScore.Top = 0.15!
        Me.lblActiveScore.Width = 0.85!
        '
        'lblActiveWRecs
        '
        Me.lblActiveWRecs.Height = 0.3!
        Me.lblActiveWRecs.HyperLink = Nothing
        Me.lblActiveWRecs.Left = 6.97!
        Me.lblActiveWRecs.Name = "lblActiveWRecs"
        Me.lblActiveWRecs.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblActiveWRecs.Text = "Management Programs " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " w/Recs"
        Me.lblActiveWRecs.Top = 0.15!
        Me.lblActiveWRecs.Width = 0.85!
        '
        'label18
        '
        Me.label18.Height = 0.15!
        Me.label18.HyperLink = Nothing
        Me.label18.Left = 7.8!
        Me.label18.Name = "label18"
        Me.label18.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.label18.Text = "Score"
        Me.label18.Top = 0.3!
        Me.label18.Width = 0.4!
        '
        'label19
        '
        Me.label19.Height = 0.15!
        Me.label19.HyperLink = Nothing
        Me.label19.Left = 8.2!
        Me.label19.Name = "label19"
        Me.label19.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.label19.Text = "Factor"
        Me.label19.Top = 0.3!
        Me.label19.Width = 0.7!
        '
        'label20
        '
        Me.label20.Height = 0.15!
        Me.label20.HyperLink = Nothing
        Me.label20.Left = 7.8!
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
        Me.label21.Left = 8.9!
        Me.label21.Name = "label21"
        Me.label21.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.label21.Text = "w/Recs Completed"
        Me.label21.Top = 0.15!
        Me.label21.Width = 1.1!
        '
        'label22
        '
        Me.label22.Height = 0.15!
        Me.label22.HyperLink = Nothing
        Me.label22.Left = 8.9!
        Me.label22.Name = "label22"
        Me.label22.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.label22.Text = "Score"
        Me.label22.Top = 0.3!
        Me.label22.Width = 0.4!
        '
        'label23
        '
        Me.label23.Height = 0.15!
        Me.label23.HyperLink = Nothing
        Me.label23.Left = 9.3!
        Me.label23.Name = "label23"
        Me.label23.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.label23.Text = "Factor"
        Me.label23.Top = 0.3!
        Me.label23.Width = 0.7!
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
        Me.line61.Width = 5.58!
        Me.line61.X1 = 4.42!
        Me.line61.X2 = 10.0!
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
        Me.line62.Width = 5.58!
        Me.line62.X1 = 4.42!
        Me.line62.X2 = 10.0!
        Me.line62.Y1 = 0.0!
        Me.line62.Y2 = 0.0!
        '
        'line63
        '
        Me.line63.Height = 0.0!
        Me.line63.Left = 4.42!
        Me.line63.LineWeight = 1.0!
        Me.line63.Name = "line63"
        Me.line63.Top = 0.15!
        Me.line63.Width = 5.58!
        Me.line63.X1 = 4.42!
        Me.line63.X2 = 10.0!
        Me.line63.Y1 = 0.15!
        Me.line63.Y2 = 0.15!
        '
        'line85
        '
        Me.line85.Height = 0.3!
        Me.line85.Left = 5.27!
        Me.line85.LineWeight = 1.0!
        Me.line85.Name = "line85"
        Me.line85.Top = 0.15!
        Me.line85.Width = 0.0!
        Me.line85.X1 = 5.27!
        Me.line85.X2 = 5.27!
        Me.line85.Y1 = 0.15!
        Me.line85.Y2 = 0.45!
        '
        'line86
        '
        Me.line86.Height = 0.3!
        Me.line86.Left = 6.12!
        Me.line86.LineWeight = 1.0!
        Me.line86.Name = "line86"
        Me.line86.Top = 0.15!
        Me.line86.Width = 0.0!
        Me.line86.X1 = 6.12!
        Me.line86.X2 = 6.12!
        Me.line86.Y1 = 0.15!
        Me.line86.Y2 = 0.45!
        '
        'line88
        '
        Me.line88.Height = 0.3!
        Me.line88.Left = 6.97!
        Me.line88.LineWeight = 1.0!
        Me.line88.Name = "line88"
        Me.line88.Top = 0.15!
        Me.line88.Width = 0.0!
        Me.line88.X1 = 6.97!
        Me.line88.X2 = 6.97!
        Me.line88.Y1 = 0.15!
        Me.line88.Y2 = 0.45!
        '
        'line89
        '
        Me.line89.Height = 0.3!
        Me.line89.Left = 7.8!
        Me.line89.LineWeight = 1.0!
        Me.line89.Name = "line89"
        Me.line89.Top = 0.15!
        Me.line89.Width = 0.0!
        Me.line89.X1 = 7.8!
        Me.line89.X2 = 7.8!
        Me.line89.Y1 = 0.15!
        Me.line89.Y2 = 0.45!
        '
        'line90
        '
        Me.line90.Height = 0.3!
        Me.line90.Left = 8.9!
        Me.line90.LineWeight = 1.0!
        Me.line90.Name = "line90"
        Me.line90.Top = 0.15!
        Me.line90.Width = 0.0!
        Me.line90.X1 = 8.9!
        Me.line90.X2 = 8.9!
        Me.line90.Y1 = 0.15!
        Me.line90.Y2 = 0.45!
        '
        'line91
        '
        Me.line91.Height = 0.0!
        Me.line91.Left = 7.8!
        Me.line91.LineWeight = 1.0!
        Me.line91.Name = "line91"
        Me.line91.Top = 0.3!
        Me.line91.Width = 2.2!
        Me.line91.X1 = 7.8!
        Me.line91.X2 = 10.0!
        Me.line91.Y1 = 0.3!
        Me.line91.Y2 = 0.3!
        '
        'line94
        '
        Me.line94.Height = 0.15!
        Me.line94.Left = 9.3!
        Me.line94.LineWeight = 1.0!
        Me.line94.Name = "line94"
        Me.line94.Top = 0.3!
        Me.line94.Width = 0.0!
        Me.line94.X1 = 9.3!
        Me.line94.X2 = 9.3!
        Me.line94.Y1 = 0.3!
        Me.line94.Y2 = 0.45!
        '
        'line95
        '
        Me.line95.Height = 0.15!
        Me.line95.Left = 8.2!
        Me.line95.LineWeight = 1.0!
        Me.line95.Name = "line95"
        Me.line95.Top = 0.3!
        Me.line95.Width = 0.0!
        Me.line95.X1 = 8.2!
        Me.line95.X2 = 8.2!
        Me.line95.Y1 = 0.3!
        Me.line95.Y2 = 0.45!
        '
        'line58
        '
        Me.line58.Height = 0.45!
        Me.line58.Left = 0.0!
        Me.line58.LineWeight = 1.0!
        Me.line58.Name = "line58"
        Me.line58.Top = 0.0!
        Me.line58.Width = 0.0!
        Me.line58.X1 = 0.0!
        Me.line58.X2 = 0.0!
        Me.line58.Y1 = 0.0!
        Me.line58.Y2 = 0.45!
        '
        'line1
        '
        Me.line1.Height = 0.45!
        Me.line1.Left = 10.0!
        Me.line1.LineWeight = 1.0!
        Me.line1.Name = "line1"
        Me.line1.Top = 0.0!
        Me.line1.Width = 0.0!
        Me.line1.X1 = 10.0!
        Me.line1.X2 = 10.0!
        Me.line1.Y1 = 0.0!
        Me.line1.Y2 = 0.45!
        '
        'rptBMFacilityRatingSummarySubHeader
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 10.0!
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
        CType(Me.label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPassiveScore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPassiveWRecs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblActiveScore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblActiveWRecs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
#End Region

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
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
        lblTIVGrid.Text = "TIV " & rptProperties.Currency.colFldCode
    End Sub

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties
End Class
