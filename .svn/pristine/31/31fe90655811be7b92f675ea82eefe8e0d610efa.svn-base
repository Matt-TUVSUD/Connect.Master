Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports

Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing

Public Class rptNatHazWindAssessmentBuildingEnvelope
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
    Private WithEvents lblBuildingEnvelopeRoof As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblBuildingEnvelopeWalls As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCoveringRating As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFasteningRating As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFlashingRating As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblDrainageRating As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblWallSurfaceRating As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblGlassRating As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblDoorResistanceRating As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblOtherOpeningsLouversRating As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblPriorLossHistory As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCVBEGRating As GrapeCity.ActiveReports.SectionReportModel.Label
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
    Private WithEvents line12 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line13 As GrapeCity.ActiveReports.SectionReportModel.Line
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
    Private WithEvents txtSurveyDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtClientLocNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents textBox5 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtTIV As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents textBox4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFileNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtDivision As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCoveringRating As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFasteningRating As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFlashingRating As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtDrainageRating As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtWallSurfaceRating As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtGlassRating As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtDoorResistanceRating As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtOtherOpeningsLouversRating As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtPriorLossHistory As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCVBEGRating As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFacility As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents line21 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line22 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line23 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line24 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line25 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line26 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line29 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line32 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line33 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line37 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line38 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line39 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line40 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line41 As GrapeCity.ActiveReports.SectionReportModel.Line
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
    Private WithEvents line54 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line63 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line17 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line18 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line19 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line20 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line27 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line28 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line36 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line14 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line42 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lblParapetOtherRoofRating As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblSkylightAtriaRating As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents line43 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line44 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtSkylightAtriaRating As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtParapetOtherRoofRating As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtDisclaimer As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents line56 As GrapeCity.ActiveReports.SectionReportModel.Line
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptNatHazWindAssessmentBuildingEnvelope))
        Me.PageHeader1 = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.lblSkylightAtriaRating = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblParapetOtherRoofRating = New GrapeCity.ActiveReports.SectionReportModel.Label()
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
        Me.lblBuildingEnvelopeRoof = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblBuildingEnvelopeWalls = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblCoveringRating = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFasteningRating = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFlashingRating = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblDrainageRating = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblWallSurfaceRating = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblGlassRating = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblDoorResistanceRating = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblOtherOpeningsLouversRating = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPriorLossHistory = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblCVBEGRating = New GrapeCity.ActiveReports.SectionReportModel.Label()
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
        Me.line12 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line13 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line15 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line16 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line53 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line55 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line58 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line61 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line64 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line59 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line54 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line63 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line56 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line20 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line27 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line28 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line36 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line14 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line42 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Detail1 = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.txtSkylightAtriaRating = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtParapetOtherRoofRating = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSurveyDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtClientLocNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.textBox5 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtTIV = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.textBox4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFileNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtDivision = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCoveringRating = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFasteningRating = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFlashingRating = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtDrainageRating = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtWallSurfaceRating = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtGlassRating = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtDoorResistanceRating = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtOtherOpeningsLouversRating = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPriorLossHistory = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCVBEGRating = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFacility = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.line21 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line22 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line23 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line24 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line25 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line26 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line29 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line32 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line33 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line37 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line38 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line39 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line40 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line41 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line52 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line35 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line34 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.textBox2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line31 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtCountry = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.line30 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line17 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line18 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line19 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line43 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line44 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.PageFooter1 = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.txtSort = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblReportDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.reportInfo1 = New GrapeCity.ActiveReports.SectionReportModel.ReportInfo()
        Me.txtDisclaimer = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        CType(Me.lblSkylightAtriaRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblParapetOtherRoofRating, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.lblBuildingEnvelopeRoof, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBuildingEnvelopeWalls, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCoveringRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFasteningRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFlashingRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDrainageRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblWallSurfaceRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblGlassRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDoorResistanceRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblOtherOpeningsLouversRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPriorLossHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCVBEGRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblClientLocNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFacility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSkylightAtriaRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtParapetOtherRoofRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSurveyDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientLocNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTIV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFileNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDivision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCoveringRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFasteningRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFlashingRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDrainageRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWallSurfaceRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlassRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDoorResistanceRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOtherOpeningsLouversRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPriorLossHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCVBEGRating, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PageHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblSkylightAtriaRating, Me.lblParapetOtherRoofRating, Me.picGRCLogo, Me.txtFilters, Me.lblLocationDetail, Me.lblClientName, Me.lblReport, Me.lblFileNo, Me.lblTIVmillions, Me.lblCountry, Me.label7, Me.lblCity, Me.lblSurveyDate, Me.lblDivision, Me.lblAddress, Me.lblBuildingEnvelopeRoof, Me.lblBuildingEnvelopeWalls, Me.lblCoveringRating, Me.lblFasteningRating, Me.lblFlashingRating, Me.lblDrainageRating, Me.lblWallSurfaceRating, Me.lblGlassRating, Me.lblDoorResistanceRating, Me.lblOtherOpeningsLouversRating, Me.lblPriorLossHistory, Me.lblCVBEGRating, Me.lblFilters, Me.lblClientLocNo, Me.lblFacility, Me.line2, Me.line4, Me.line5, Me.line6, Me.line7, Me.line8, Me.line9, Me.line10, Me.line11, Me.line12, Me.line13, Me.line15, Me.line16, Me.line53, Me.line55, Me.line58, Me.line61, Me.line64, Me.line59, Me.line54, Me.line63, Me.line56, Me.line20, Me.line27, Me.line28, Me.line36, Me.line14, Me.line42})
        Me.PageHeader1.Height = 1.507!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'lblSkylightAtriaRating
        '
        Me.lblSkylightAtriaRating.Height = 0.3!
        Me.lblSkylightAtriaRating.HyperLink = Nothing
        Me.lblSkylightAtriaRating.Left = 6.22!
        Me.lblSkylightAtriaRating.Name = "lblSkylightAtriaRating"
        Me.lblSkylightAtriaRating.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblSkylightAtriaRating.Text = "Skylight/ Atria"
        Me.lblSkylightAtriaRating.Top = 1.2!
        Me.lblSkylightAtriaRating.Width = 0.6!
        '
        'lblParapetOtherRoofRating
        '
        Me.lblParapetOtherRoofRating.Height = 0.3!
        Me.lblParapetOtherRoofRating.HyperLink = Nothing
        Me.lblParapetOtherRoofRating.Left = 7.42!
        Me.lblParapetOtherRoofRating.Name = "lblParapetOtherRoofRating"
        Me.lblParapetOtherRoofRating.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblParapetOtherRoofRating.Text = "Parapet/ Other - Roof"
        Me.lblParapetOtherRoofRating.Top = 1.2!
        Me.lblParapetOtherRoofRating.Width = 0.6!
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
        Me.txtFilters.Width = 11.58!
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
        Me.lblClientName.Left = 6.22!
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Style = "color: #C6D1DE; font-size: 16pt; font-style: italic; font-weight: bold; text-alig" & _
    "n: right; vertical-align: middle"
        Me.lblClientName.Text = "Company Name"
        Me.lblClientName.Top = 0.063!
        Me.lblClientName.Width = 5.800001!
        '
        'lblReport
        '
        Me.lblReport.Height = 0.25!
        Me.lblReport.HyperLink = Nothing
        Me.lblReport.Left = 6.22!
        Me.lblReport.Name = "lblReport"
        Me.lblReport.Style = "font-size: 12pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblReport.Text = "Natural Hazards - Wind Assessment - Building Envelope"
        Me.lblReport.Top = 0.375!
        Me.lblReport.Width = 5.800001!
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
        'lblBuildingEnvelopeRoof
        '
        Me.lblBuildingEnvelopeRoof.Height = 0.146!
        Me.lblBuildingEnvelopeRoof.HyperLink = Nothing
        Me.lblBuildingEnvelopeRoof.Left = 4.42!
        Me.lblBuildingEnvelopeRoof.Name = "lblBuildingEnvelopeRoof"
        Me.lblBuildingEnvelopeRoof.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblBuildingEnvelopeRoof.Text = "Building Envelope - Roof"
        Me.lblBuildingEnvelopeRoof.Top = 1.05!
        Me.lblBuildingEnvelopeRoof.Width = 3.6!
        '
        'lblBuildingEnvelopeWalls
        '
        Me.lblBuildingEnvelopeWalls.Height = 0.146!
        Me.lblBuildingEnvelopeWalls.HyperLink = Nothing
        Me.lblBuildingEnvelopeWalls.Left = 8.07!
        Me.lblBuildingEnvelopeWalls.Name = "lblBuildingEnvelopeWalls"
        Me.lblBuildingEnvelopeWalls.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblBuildingEnvelopeWalls.Text = "Building Envelope - Walls"
        Me.lblBuildingEnvelopeWalls.Top = 1.05!
        Me.lblBuildingEnvelopeWalls.Width = 2.4!
        '
        'lblCoveringRating
        '
        Me.lblCoveringRating.Height = 0.3!
        Me.lblCoveringRating.HyperLink = Nothing
        Me.lblCoveringRating.Left = 5.62!
        Me.lblCoveringRating.Name = "lblCoveringRating"
        Me.lblCoveringRating.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblCoveringRating.Text = "Covering"
        Me.lblCoveringRating.Top = 1.2!
        Me.lblCoveringRating.Width = 0.6!
        '
        'lblFasteningRating
        '
        Me.lblFasteningRating.Height = 0.3!
        Me.lblFasteningRating.HyperLink = Nothing
        Me.lblFasteningRating.Left = 4.42!
        Me.lblFasteningRating.Name = "lblFasteningRating"
        Me.lblFasteningRating.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblFasteningRating.Text = "Fastening"
        Me.lblFasteningRating.Top = 1.2!
        Me.lblFasteningRating.Width = 0.6!
        '
        'lblFlashingRating
        '
        Me.lblFlashingRating.Height = 0.3!
        Me.lblFlashingRating.HyperLink = Nothing
        Me.lblFlashingRating.Left = 5.02!
        Me.lblFlashingRating.Name = "lblFlashingRating"
        Me.lblFlashingRating.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblFlashingRating.Text = "Flashing"
        Me.lblFlashingRating.Top = 1.2!
        Me.lblFlashingRating.Width = 0.6!
        '
        'lblDrainageRating
        '
        Me.lblDrainageRating.Height = 0.3!
        Me.lblDrainageRating.HyperLink = Nothing
        Me.lblDrainageRating.Left = 6.82!
        Me.lblDrainageRating.Name = "lblDrainageRating"
        Me.lblDrainageRating.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblDrainageRating.Text = "Drainage"
        Me.lblDrainageRating.Top = 1.2!
        Me.lblDrainageRating.Width = 0.6!
        '
        'lblWallSurfaceRating
        '
        Me.lblWallSurfaceRating.Height = 0.3!
        Me.lblWallSurfaceRating.HyperLink = Nothing
        Me.lblWallSurfaceRating.Left = 8.07!
        Me.lblWallSurfaceRating.Name = "lblWallSurfaceRating"
        Me.lblWallSurfaceRating.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblWallSurfaceRating.Text = "Wall Surface"
        Me.lblWallSurfaceRating.Top = 1.2!
        Me.lblWallSurfaceRating.Width = 0.55!
        '
        'lblGlassRating
        '
        Me.lblGlassRating.Height = 0.3!
        Me.lblGlassRating.HyperLink = Nothing
        Me.lblGlassRating.Left = 8.62!
        Me.lblGlassRating.Name = "lblGlassRating"
        Me.lblGlassRating.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblGlassRating.Text = "Glass"
        Me.lblGlassRating.Top = 1.2!
        Me.lblGlassRating.Width = 0.55!
        '
        'lblDoorResistanceRating
        '
        Me.lblDoorResistanceRating.Height = 0.3!
        Me.lblDoorResistanceRating.HyperLink = Nothing
        Me.lblDoorResistanceRating.Left = 9.17!
        Me.lblDoorResistanceRating.Name = "lblDoorResistanceRating"
        Me.lblDoorResistanceRating.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblDoorResistanceRating.Text = "Door Resistance"
        Me.lblDoorResistanceRating.Top = 1.2!
        Me.lblDoorResistanceRating.Width = 0.55!
        '
        'lblOtherOpeningsLouversRating
        '
        Me.lblOtherOpeningsLouversRating.Height = 0.3!
        Me.lblOtherOpeningsLouversRating.HyperLink = Nothing
        Me.lblOtherOpeningsLouversRating.Left = 9.72!
        Me.lblOtherOpeningsLouversRating.Name = "lblOtherOpeningsLouversRating"
        Me.lblOtherOpeningsLouversRating.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblOtherOpeningsLouversRating.Text = "Other Openings Louvers"
        Me.lblOtherOpeningsLouversRating.Top = 1.2!
        Me.lblOtherOpeningsLouversRating.Width = 0.75!
        '
        'lblPriorLossHistory
        '
        Me.lblPriorLossHistory.Height = 0.3!
        Me.lblPriorLossHistory.HyperLink = Nothing
        Me.lblPriorLossHistory.Left = 10.52!
        Me.lblPriorLossHistory.Name = "lblPriorLossHistory"
        Me.lblPriorLossHistory.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblPriorLossHistory.Text = "Prior Loss History"
        Me.lblPriorLossHistory.Top = 1.2!
        Me.lblPriorLossHistory.Width = 0.5!
        '
        'lblCVBEGRating
        '
        Me.lblCVBEGRating.Height = 0.3!
        Me.lblCVBEGRating.HyperLink = Nothing
        Me.lblCVBEGRating.Left = 11.02!
        Me.lblCVBEGRating.Name = "lblCVBEGRating"
        Me.lblCVBEGRating.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.lblCVBEGRating.Text = "Critical Equip./ Values Below Grade"
        Me.lblCVBEGRating.Top = 1.2!
        Me.lblCVBEGRating.Width = 1.0!
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
        Me.line2.Width = 3.6!
        Me.line2.X1 = 4.42!
        Me.line2.X2 = 8.02!
        Me.line2.Y1 = 1.2!
        Me.line2.Y2 = 1.2!
        '
        'line4
        '
        Me.line4.Height = 0.45!
        Me.line4.Left = 4.42!
        Me.line4.LineWeight = 1.0!
        Me.line4.Name = "line4"
        Me.line4.Top = 1.05!
        Me.line4.Width = 0.0!
        Me.line4.X1 = 4.42!
        Me.line4.X2 = 4.42!
        Me.line4.Y1 = 1.05!
        Me.line4.Y2 = 1.5!
        '
        'line5
        '
        Me.line5.Height = 0.3!
        Me.line5.Left = 5.02!
        Me.line5.LineWeight = 1.0!
        Me.line5.Name = "line5"
        Me.line5.Top = 1.2!
        Me.line5.Width = 0.0!
        Me.line5.X1 = 5.02!
        Me.line5.X2 = 5.02!
        Me.line5.Y1 = 1.2!
        Me.line5.Y2 = 1.5!
        '
        'line6
        '
        Me.line6.Height = 0.3!
        Me.line6.Left = 5.62!
        Me.line6.LineWeight = 1.0!
        Me.line6.Name = "line6"
        Me.line6.Top = 1.2!
        Me.line6.Width = 0.0!
        Me.line6.X1 = 5.62!
        Me.line6.X2 = 5.62!
        Me.line6.Y1 = 1.2!
        Me.line6.Y2 = 1.5!
        '
        'line7
        '
        Me.line7.Height = 0.3!
        Me.line7.Left = 6.22!
        Me.line7.LineWeight = 1.0!
        Me.line7.Name = "line7"
        Me.line7.Top = 1.2!
        Me.line7.Width = 0.0!
        Me.line7.X1 = 6.22!
        Me.line7.X2 = 6.22!
        Me.line7.Y1 = 1.2!
        Me.line7.Y2 = 1.5!
        '
        'line8
        '
        Me.line8.Height = 0.3!
        Me.line8.Left = 6.82!
        Me.line8.LineWeight = 1.0!
        Me.line8.Name = "line8"
        Me.line8.Top = 1.2!
        Me.line8.Width = 0.0!
        Me.line8.X1 = 6.82!
        Me.line8.X2 = 6.82!
        Me.line8.Y1 = 1.2!
        Me.line8.Y2 = 1.5!
        '
        'line9
        '
        Me.line9.Height = 0.45!
        Me.line9.Left = 8.02!
        Me.line9.LineWeight = 1.0!
        Me.line9.Name = "line9"
        Me.line9.Top = 1.05!
        Me.line9.Width = 0.0!
        Me.line9.X1 = 8.02!
        Me.line9.X2 = 8.02!
        Me.line9.Y1 = 1.05!
        Me.line9.Y2 = 1.5!
        '
        'line10
        '
        Me.line10.Height = 0.3!
        Me.line10.Left = 9.72!
        Me.line10.LineWeight = 1.0!
        Me.line10.Name = "line10"
        Me.line10.Top = 1.2!
        Me.line10.Width = 0.0!
        Me.line10.X1 = 9.72!
        Me.line10.X2 = 9.72!
        Me.line10.Y1 = 1.2!
        Me.line10.Y2 = 1.5!
        '
        'line11
        '
        Me.line11.Height = 0.45!
        Me.line11.Left = 10.47!
        Me.line11.LineWeight = 1.0!
        Me.line11.Name = "line11"
        Me.line11.Top = 1.05!
        Me.line11.Width = 0.0!
        Me.line11.X1 = 10.47!
        Me.line11.X2 = 10.47!
        Me.line11.Y1 = 1.05!
        Me.line11.Y2 = 1.5!
        '
        'line12
        '
        Me.line12.Height = 0.45!
        Me.line12.Left = 10.52!
        Me.line12.LineWeight = 1.0!
        Me.line12.Name = "line12"
        Me.line12.Top = 1.05!
        Me.line12.Width = 0.0!
        Me.line12.X1 = 10.52!
        Me.line12.X2 = 10.52!
        Me.line12.Y1 = 1.05!
        Me.line12.Y2 = 1.5!
        '
        'line13
        '
        Me.line13.Height = 0.3!
        Me.line13.Left = 8.62!
        Me.line13.LineWeight = 1.0!
        Me.line13.Name = "line13"
        Me.line13.Top = 1.2!
        Me.line13.Width = 0.0!
        Me.line13.X1 = 8.62!
        Me.line13.X2 = 8.62!
        Me.line13.Y1 = 1.2!
        Me.line13.Y2 = 1.5!
        '
        'line15
        '
        Me.line15.Height = 0.3!
        Me.line15.Left = 9.17!
        Me.line15.LineWeight = 1.0!
        Me.line15.Name = "line15"
        Me.line15.Top = 1.2!
        Me.line15.Width = 0.0!
        Me.line15.X1 = 9.17!
        Me.line15.X2 = 9.17!
        Me.line15.Y1 = 1.2!
        Me.line15.Y2 = 1.5!
        '
        'line16
        '
        Me.line16.Height = 0.0!
        Me.line16.Left = 8.07!
        Me.line16.LineWeight = 1.0!
        Me.line16.Name = "line16"
        Me.line16.Top = 1.2!
        Me.line16.Width = 2.400001!
        Me.line16.X1 = 8.07!
        Me.line16.X2 = 10.47!
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
        Me.line53.Width = 3.6!
        Me.line53.X1 = 4.42!
        Me.line53.X2 = 8.02!
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
        Me.line58.Height = 0.45!
        Me.line58.Left = 4.37!
        Me.line58.LineWeight = 1.0!
        Me.line58.Name = "line58"
        Me.line58.Top = 1.05!
        Me.line58.Width = 0.0!
        Me.line58.X1 = 4.37!
        Me.line58.X2 = 4.37!
        Me.line58.Y1 = 1.05!
        Me.line58.Y2 = 1.5!
        '
        'line61
        '
        Me.line61.Height = 0.45!
        Me.line61.Left = 8.07!
        Me.line61.LineWeight = 1.0!
        Me.line61.Name = "line61"
        Me.line61.Top = 1.05!
        Me.line61.Width = 0.0!
        Me.line61.X1 = 8.07!
        Me.line61.X2 = 8.07!
        Me.line61.Y1 = 1.05!
        Me.line61.Y2 = 1.5!
        '
        'line64
        '
        Me.line64.Height = 0.0!
        Me.line64.Left = 8.07!
        Me.line64.LineWeight = 1.0!
        Me.line64.Name = "line64"
        Me.line64.Top = 1.05!
        Me.line64.Width = 2.400001!
        Me.line64.X1 = 8.07!
        Me.line64.X2 = 10.47!
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
        'line54
        '
        Me.line54.Height = 0.0!
        Me.line54.Left = 4.42!
        Me.line54.LineWeight = 1.0!
        Me.line54.Name = "line54"
        Me.line54.Top = 1.5!
        Me.line54.Width = 3.6!
        Me.line54.X1 = 4.42!
        Me.line54.X2 = 8.02!
        Me.line54.Y1 = 1.5!
        Me.line54.Y2 = 1.5!
        '
        'line63
        '
        Me.line63.Height = 0.0!
        Me.line63.Left = 8.07!
        Me.line63.LineWeight = 1.0!
        Me.line63.Name = "line63"
        Me.line63.Top = 1.5!
        Me.line63.Width = 2.400001!
        Me.line63.X1 = 8.07!
        Me.line63.X2 = 10.47!
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
        Me.line56.Width = 4.37!
        Me.line56.X1 = 0.0!
        Me.line56.X2 = 4.37!
        Me.line56.Y1 = 1.5!
        Me.line56.Y2 = 1.5!
        '
        'line20
        '
        Me.line20.Height = 0.45!
        Me.line20.Left = 12.02!
        Me.line20.LineWeight = 1.0!
        Me.line20.Name = "line20"
        Me.line20.Top = 1.05!
        Me.line20.Width = 0.0!
        Me.line20.X1 = 12.02!
        Me.line20.X2 = 12.02!
        Me.line20.Y1 = 1.05!
        Me.line20.Y2 = 1.5!
        '
        'line27
        '
        Me.line27.Height = 0.0!
        Me.line27.Left = 10.52!
        Me.line27.LineWeight = 1.0!
        Me.line27.Name = "line27"
        Me.line27.Top = 1.5!
        Me.line27.Width = 1.5!
        Me.line27.X1 = 10.52!
        Me.line27.X2 = 12.02!
        Me.line27.Y1 = 1.5!
        Me.line27.Y2 = 1.5!
        '
        'line28
        '
        Me.line28.Height = 0.0!
        Me.line28.Left = 10.52!
        Me.line28.LineWeight = 1.0!
        Me.line28.Name = "line28"
        Me.line28.Top = 1.2!
        Me.line28.Width = 1.5!
        Me.line28.X1 = 10.52!
        Me.line28.X2 = 12.02!
        Me.line28.Y1 = 1.2!
        Me.line28.Y2 = 1.2!
        '
        'line36
        '
        Me.line36.Height = 0.0!
        Me.line36.Left = 10.52!
        Me.line36.LineWeight = 1.0!
        Me.line36.Name = "line36"
        Me.line36.Top = 1.05!
        Me.line36.Width = 1.5!
        Me.line36.X1 = 10.52!
        Me.line36.X2 = 12.02!
        Me.line36.Y1 = 1.05!
        Me.line36.Y2 = 1.05!
        '
        'line14
        '
        Me.line14.Height = 0.3!
        Me.line14.Left = 11.02!
        Me.line14.LineWeight = 1.0!
        Me.line14.Name = "line14"
        Me.line14.Top = 1.2!
        Me.line14.Width = 0.0!
        Me.line14.X1 = 11.02!
        Me.line14.X2 = 11.02!
        Me.line14.Y1 = 1.2!
        Me.line14.Y2 = 1.5!
        '
        'line42
        '
        Me.line42.Height = 0.3!
        Me.line42.Left = 7.42!
        Me.line42.LineWeight = 1.0!
        Me.line42.Name = "line42"
        Me.line42.Top = 1.2!
        Me.line42.Width = 0.0!
        Me.line42.X1 = 7.42!
        Me.line42.X2 = 7.42!
        Me.line42.Y1 = 1.2!
        Me.line42.Y2 = 1.5!
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtSkylightAtriaRating, Me.txtParapetOtherRoofRating, Me.txtSurveyDate, Me.txtClientLocNo, Me.textBox5, Me.txtTIV, Me.textBox4, Me.txtFileNo, Me.txtDivision, Me.txtCoveringRating, Me.txtFasteningRating, Me.txtFlashingRating, Me.txtDrainageRating, Me.txtWallSurfaceRating, Me.txtGlassRating, Me.txtDoorResistanceRating, Me.txtOtherOpeningsLouversRating, Me.txtPriorLossHistory, Me.txtCVBEGRating, Me.txtFacility, Me.line21, Me.line22, Me.line23, Me.line24, Me.line25, Me.line26, Me.line29, Me.line32, Me.line33, Me.line37, Me.line38, Me.line39, Me.line40, Me.line41, Me.line52, Me.line35, Me.line34, Me.textBox2, Me.line1, Me.line31, Me.txtCountry, Me.line30, Me.line3, Me.line17, Me.line18, Me.line19, Me.line43, Me.line44})
        Me.Detail1.Height = 0.35!
        Me.Detail1.Name = "Detail1"
        '
        'txtSkylightAtriaRating
        '
        Me.txtSkylightAtriaRating.DataField = "SkylightAtriaRating"
        Me.txtSkylightAtriaRating.Height = 0.3!
        Me.txtSkylightAtriaRating.Left = 6.22!
        Me.txtSkylightAtriaRating.Name = "txtSkylightAtriaRating"
        Me.txtSkylightAtriaRating.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtSkylightAtriaRating.Text = "SkylightAtriaRating"
        Me.txtSkylightAtriaRating.Top = 0.05!
        Me.txtSkylightAtriaRating.Width = 0.6!
        '
        'txtParapetOtherRoofRating
        '
        Me.txtParapetOtherRoofRating.DataField = "ParapetOtherRoofRating"
        Me.txtParapetOtherRoofRating.Height = 0.3!
        Me.txtParapetOtherRoofRating.Left = 7.42!
        Me.txtParapetOtherRoofRating.Name = "txtParapetOtherRoofRating"
        Me.txtParapetOtherRoofRating.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtParapetOtherRoofRating.Text = "ParapetOtherRoofRating"
        Me.txtParapetOtherRoofRating.Top = 0.05!
        Me.txtParapetOtherRoofRating.Width = 0.6!
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
        'txtCoveringRating
        '
        Me.txtCoveringRating.DataField = "CoveringRating"
        Me.txtCoveringRating.Height = 0.3!
        Me.txtCoveringRating.Left = 5.62!
        Me.txtCoveringRating.Name = "txtCoveringRating"
        Me.txtCoveringRating.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtCoveringRating.Text = "CoveringRating"
        Me.txtCoveringRating.Top = 0.05!
        Me.txtCoveringRating.Width = 0.6!
        '
        'txtFasteningRating
        '
        Me.txtFasteningRating.DataField = "FasteningRating"
        Me.txtFasteningRating.Height = 0.3!
        Me.txtFasteningRating.Left = 4.42!
        Me.txtFasteningRating.Name = "txtFasteningRating"
        Me.txtFasteningRating.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtFasteningRating.Text = "FasteningRating"
        Me.txtFasteningRating.Top = 0.05!
        Me.txtFasteningRating.Width = 0.6!
        '
        'txtFlashingRating
        '
        Me.txtFlashingRating.DataField = "FlashingRating"
        Me.txtFlashingRating.Height = 0.3!
        Me.txtFlashingRating.Left = 5.02!
        Me.txtFlashingRating.Name = "txtFlashingRating"
        Me.txtFlashingRating.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtFlashingRating.Text = "FlashingRating"
        Me.txtFlashingRating.Top = 0.05!
        Me.txtFlashingRating.Width = 0.6!
        '
        'txtDrainageRating
        '
        Me.txtDrainageRating.DataField = "DrainageRating"
        Me.txtDrainageRating.Height = 0.3!
        Me.txtDrainageRating.Left = 6.82!
        Me.txtDrainageRating.Name = "txtDrainageRating"
        Me.txtDrainageRating.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtDrainageRating.Text = "DrainageRating"
        Me.txtDrainageRating.Top = 0.05!
        Me.txtDrainageRating.Width = 0.6!
        '
        'txtWallSurfaceRating
        '
        Me.txtWallSurfaceRating.DataField = "WallSurfaceRating"
        Me.txtWallSurfaceRating.Height = 0.3!
        Me.txtWallSurfaceRating.Left = 8.07!
        Me.txtWallSurfaceRating.Name = "txtWallSurfaceRating"
        Me.txtWallSurfaceRating.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtWallSurfaceRating.Text = "WallSurfaceRating"
        Me.txtWallSurfaceRating.Top = 0.05!
        Me.txtWallSurfaceRating.Width = 0.55!
        '
        'txtGlassRating
        '
        Me.txtGlassRating.DataField = "GlassRating"
        Me.txtGlassRating.Height = 0.3!
        Me.txtGlassRating.Left = 8.62!
        Me.txtGlassRating.Name = "txtGlassRating"
        Me.txtGlassRating.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtGlassRating.Text = "GlassRating"
        Me.txtGlassRating.Top = 0.05!
        Me.txtGlassRating.Width = 0.55!
        '
        'txtDoorResistanceRating
        '
        Me.txtDoorResistanceRating.DataField = "DoorResistanceRating"
        Me.txtDoorResistanceRating.Height = 0.3!
        Me.txtDoorResistanceRating.Left = 9.17!
        Me.txtDoorResistanceRating.Name = "txtDoorResistanceRating"
        Me.txtDoorResistanceRating.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtDoorResistanceRating.Text = "DoorResistanceRating"
        Me.txtDoorResistanceRating.Top = 0.05!
        Me.txtDoorResistanceRating.Width = 0.55!
        '
        'txtOtherOpeningsLouversRating
        '
        Me.txtOtherOpeningsLouversRating.DataField = "OtherOpeningsLouversRating"
        Me.txtOtherOpeningsLouversRating.Height = 0.3!
        Me.txtOtherOpeningsLouversRating.Left = 9.72!
        Me.txtOtherOpeningsLouversRating.Name = "txtOtherOpeningsLouversRating"
        Me.txtOtherOpeningsLouversRating.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtOtherOpeningsLouversRating.Text = "OtherOpeningsLouversRating"
        Me.txtOtherOpeningsLouversRating.Top = 0.05!
        Me.txtOtherOpeningsLouversRating.Width = 0.75!
        '
        'txtPriorLossHistory
        '
        Me.txtPriorLossHistory.DataField = "PriorLossHistory"
        Me.txtPriorLossHistory.Height = 0.3!
        Me.txtPriorLossHistory.Left = 10.52!
        Me.txtPriorLossHistory.Name = "txtPriorLossHistory"
        Me.txtPriorLossHistory.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtPriorLossHistory.Text = "PriorLossHistory"
        Me.txtPriorLossHistory.Top = 0.05!
        Me.txtPriorLossHistory.Width = 0.5!
        '
        'txtCVBEGRating
        '
        Me.txtCVBEGRating.DataField = "CVBEGRating"
        Me.txtCVBEGRating.Height = 0.3!
        Me.txtCVBEGRating.Left = 11.02!
        Me.txtCVBEGRating.Name = "txtCVBEGRating"
        Me.txtCVBEGRating.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtCVBEGRating.Text = "CVBEGRating"
        Me.txtCVBEGRating.Top = 0.05!
        Me.txtCVBEGRating.Width = 1.0!
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
        Me.line21.Left = 4.42!
        Me.line21.LineWeight = 1.0!
        Me.line21.Name = "line21"
        Me.line21.Top = 0.05!
        Me.line21.Width = 0.0!
        Me.line21.X1 = 4.42!
        Me.line21.X2 = 4.42!
        Me.line21.Y1 = 0.05!
        Me.line21.Y2 = 0.35!
        '
        'line22
        '
        Me.line22.Height = 0.3!
        Me.line22.Left = 5.02!
        Me.line22.LineWeight = 1.0!
        Me.line22.Name = "line22"
        Me.line22.Top = 0.05!
        Me.line22.Width = 0.0!
        Me.line22.X1 = 5.02!
        Me.line22.X2 = 5.02!
        Me.line22.Y1 = 0.05!
        Me.line22.Y2 = 0.35!
        '
        'line23
        '
        Me.line23.Height = 0.3!
        Me.line23.Left = 5.62!
        Me.line23.LineWeight = 1.0!
        Me.line23.Name = "line23"
        Me.line23.Top = 0.05!
        Me.line23.Width = 0.0!
        Me.line23.X1 = 5.62!
        Me.line23.X2 = 5.62!
        Me.line23.Y1 = 0.05!
        Me.line23.Y2 = 0.35!
        '
        'line24
        '
        Me.line24.Height = 0.3!
        Me.line24.Left = 6.22!
        Me.line24.LineWeight = 1.0!
        Me.line24.Name = "line24"
        Me.line24.Top = 0.05!
        Me.line24.Width = 0.0!
        Me.line24.X1 = 6.22!
        Me.line24.X2 = 6.22!
        Me.line24.Y1 = 0.05!
        Me.line24.Y2 = 0.35!
        '
        'line25
        '
        Me.line25.Height = 0.3!
        Me.line25.Left = 8.02!
        Me.line25.LineWeight = 1.0!
        Me.line25.Name = "line25"
        Me.line25.Top = 0.05!
        Me.line25.Width = 0.0!
        Me.line25.X1 = 8.02!
        Me.line25.X2 = 8.02!
        Me.line25.Y1 = 0.05!
        Me.line25.Y2 = 0.35!
        '
        'line26
        '
        Me.line26.Height = 0.3!
        Me.line26.Left = 8.07!
        Me.line26.LineWeight = 1.0!
        Me.line26.Name = "line26"
        Me.line26.Top = 0.05!
        Me.line26.Width = 0.0!
        Me.line26.X1 = 8.07!
        Me.line26.X2 = 8.07!
        Me.line26.Y1 = 0.05!
        Me.line26.Y2 = 0.35!
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
        Me.line32.Width = 3.6!
        Me.line32.X1 = 4.42!
        Me.line32.X2 = 8.02!
        Me.line32.Y1 = 0.35!
        Me.line32.Y2 = 0.35!
        '
        'line33
        '
        Me.line33.Height = 0.0!
        Me.line33.Left = 8.07!
        Me.line33.LineWeight = 1.0!
        Me.line33.Name = "line33"
        Me.line33.Top = 0.35!
        Me.line33.Width = 2.400001!
        Me.line33.X1 = 8.07!
        Me.line33.X2 = 10.47!
        Me.line33.Y1 = 0.35!
        Me.line33.Y2 = 0.35!
        '
        'line37
        '
        Me.line37.Height = 0.3!
        Me.line37.Left = 8.62!
        Me.line37.LineWeight = 1.0!
        Me.line37.Name = "line37"
        Me.line37.Top = 0.05!
        Me.line37.Width = 0.0!
        Me.line37.X1 = 8.62!
        Me.line37.X2 = 8.62!
        Me.line37.Y1 = 0.05!
        Me.line37.Y2 = 0.35!
        '
        'line38
        '
        Me.line38.Height = 0.3!
        Me.line38.Left = 9.72!
        Me.line38.LineWeight = 1.0!
        Me.line38.Name = "line38"
        Me.line38.Top = 0.05!
        Me.line38.Width = 0.0!
        Me.line38.X1 = 9.72!
        Me.line38.X2 = 9.72!
        Me.line38.Y1 = 0.05!
        Me.line38.Y2 = 0.35!
        '
        'line39
        '
        Me.line39.Height = 0.3!
        Me.line39.Left = 10.47!
        Me.line39.LineWeight = 1.0!
        Me.line39.Name = "line39"
        Me.line39.Top = 0.05!
        Me.line39.Width = 0.0!
        Me.line39.X1 = 10.47!
        Me.line39.X2 = 10.47!
        Me.line39.Y1 = 0.05!
        Me.line39.Y2 = 0.35!
        '
        'line40
        '
        Me.line40.Height = 0.3!
        Me.line40.Left = 11.02!
        Me.line40.LineWeight = 1.0!
        Me.line40.Name = "line40"
        Me.line40.Top = 0.05!
        Me.line40.Width = 0.0!
        Me.line40.X1 = 11.02!
        Me.line40.X2 = 11.02!
        Me.line40.Y1 = 0.05!
        Me.line40.Y2 = 0.35!
        '
        'line41
        '
        Me.line41.Height = 0.3!
        Me.line41.Left = 10.52!
        Me.line41.LineWeight = 1.0!
        Me.line41.Name = "line41"
        Me.line41.Top = 0.05!
        Me.line41.Width = 0.0!
        Me.line41.X1 = 10.52!
        Me.line41.X2 = 10.52!
        Me.line41.Y1 = 0.05!
        Me.line41.Y2 = 0.35!
        '
        'line52
        '
        Me.line52.Height = 0.3!
        Me.line52.Left = 13.4!
        Me.line52.LineWeight = 1.0!
        Me.line52.Name = "line52"
        Me.line52.Top = 3.72529E-9!
        Me.line52.Width = 0.0!
        Me.line52.X1 = 13.4!
        Me.line52.X2 = 13.4!
        Me.line52.Y1 = 3.72529E-9!
        Me.line52.Y2 = 0.3!
        '
        'line35
        '
        Me.line35.Height = 0.0!
        Me.line35.Left = 4.42!
        Me.line35.LineWeight = 1.0!
        Me.line35.Name = "line35"
        Me.line35.Top = 0.05!
        Me.line35.Width = 3.6!
        Me.line35.X1 = 4.42!
        Me.line35.X2 = 8.02!
        Me.line35.Y1 = 0.05!
        Me.line35.Y2 = 0.05!
        '
        'line34
        '
        Me.line34.Height = 0.0!
        Me.line34.Left = 8.07!
        Me.line34.LineWeight = 1.0!
        Me.line34.Name = "line34"
        Me.line34.Top = 0.05!
        Me.line34.Width = 2.400001!
        Me.line34.X1 = 8.07!
        Me.line34.X2 = 10.47!
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
        Me.line3.Left = 9.17!
        Me.line3.LineWeight = 1.0!
        Me.line3.Name = "line3"
        Me.line3.Top = 0.05!
        Me.line3.Width = 0.0!
        Me.line3.X1 = 9.17!
        Me.line3.X2 = 9.17!
        Me.line3.Y1 = 0.05!
        Me.line3.Y2 = 0.35!
        '
        'line17
        '
        Me.line17.Height = 0.3!
        Me.line17.Left = 12.02!
        Me.line17.LineWeight = 1.0!
        Me.line17.Name = "line17"
        Me.line17.Top = 0.05!
        Me.line17.Width = 0.0!
        Me.line17.X1 = 12.02!
        Me.line17.X2 = 12.02!
        Me.line17.Y1 = 0.05!
        Me.line17.Y2 = 0.35!
        '
        'line18
        '
        Me.line18.Height = 0.0!
        Me.line18.Left = 10.52!
        Me.line18.LineWeight = 1.0!
        Me.line18.Name = "line18"
        Me.line18.Top = 0.05!
        Me.line18.Width = 1.5!
        Me.line18.X1 = 10.52!
        Me.line18.X2 = 12.02!
        Me.line18.Y1 = 0.05!
        Me.line18.Y2 = 0.05!
        '
        'line19
        '
        Me.line19.Height = 0.0!
        Me.line19.Left = 10.52!
        Me.line19.LineWeight = 1.0!
        Me.line19.Name = "line19"
        Me.line19.Top = 0.35!
        Me.line19.Width = 1.5!
        Me.line19.X1 = 10.52!
        Me.line19.X2 = 12.02!
        Me.line19.Y1 = 0.35!
        Me.line19.Y2 = 0.35!
        '
        'line43
        '
        Me.line43.Height = 0.3!
        Me.line43.Left = 6.82!
        Me.line43.LineWeight = 1.0!
        Me.line43.Name = "line43"
        Me.line43.Top = 0.05!
        Me.line43.Width = 0.0!
        Me.line43.X1 = 6.82!
        Me.line43.X2 = 6.82!
        Me.line43.Y1 = 0.05!
        Me.line43.Y2 = 0.35!
        '
        'line44
        '
        Me.line44.Height = 0.3!
        Me.line44.Left = 7.42!
        Me.line44.LineWeight = 1.0!
        Me.line44.Name = "line44"
        Me.line44.Top = 0.05!
        Me.line44.Width = 0.0!
        Me.line44.X1 = 7.42!
        Me.line44.X2 = 7.42!
        Me.line44.Y1 = 0.05!
        Me.line44.Y2 = 0.35!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtSort, Me.lblReportDate, Me.reportInfo1, Me.txtDisclaimer})
        Me.PageFooter1.Height = 0.50625!
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
        Me.txtSort.Width = 12.02!
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
        Me.reportInfo1.Left = 10.02!
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
        Me.txtDisclaimer.Width = 12.02!
        '
        'rptNatHazWindAssessmentBuildingEnvelope
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.25!
        Me.PageSettings.Margins.Left = 0.99!
        Me.PageSettings.Margins.Right = 0.99!
        Me.PageSettings.Margins.Top = 0.25!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 12.02!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Calibri; font-style: normal; text-decoration: none; font-weight: nor" & _
            "mal; font-size: 10pt; color: Black", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
            "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.lblSkylightAtriaRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblParapetOtherRoofRating, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.lblBuildingEnvelopeRoof, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBuildingEnvelopeWalls, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCoveringRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFasteningRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFlashingRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDrainageRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblWallSurfaceRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblGlassRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDoorResistanceRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblOtherOpeningsLouversRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPriorLossHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCVBEGRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblClientLocNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFacility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSkylightAtriaRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtParapetOtherRoofRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSurveyDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientLocNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTIV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFileNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDivision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCoveringRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFasteningRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFlashingRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDrainageRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWallSurfaceRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlassRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDoorResistanceRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOtherOpeningsLouversRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPriorLossHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCVBEGRating, System.ComponentModel.ISupportInitialize).EndInit()
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

    Private Sub rptNatHazWindAssessmentBuildingEnvelope_FetchData(ByVal sender As Object, ByVal eArgs As FetchEventArgs) Handles Me.FetchData
        Dim zRatingControls() As ARControl = {txtPriorLossHistory, txtCVBEGRating}
        Dim zTextControls() As ARControl = {
                                            txtFasteningRating,
                                            txtFlashingRating,
                                            txtCoveringRating,
                                            txtSkylightAtriaRating,
                                            txtDrainageRating,
                                            txtParapetOtherRoofRating,
                                            txtWallSurfaceRating,
                                            txtGlassRating,
                                            txtDoorResistanceRating,
                                            txtOtherOpeningsLouversRating
                                            }

        UtilReport.ActiveReport.SetItemBackColorByExposure(Me, zRatingControls, rptProperties)
        UtilReport.ActiveReport.SetItemBackColorByText(Me, zTextControls, rptProperties)
    End Sub

    Private Sub rptNatHazWindAssessmentBuildingEnvelope_ReportStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportStart
        lblClientName.Text = rptProperties.ClientName
        lblReportDate.Text = Now
        lblTIVmillions.Text = "TIV " & rptProperties.Currency.colFldCode & vbLf & "(millions)"
    End Sub

    Private Sub rptNatHazWindAssessmentBuildingEnvelope_PageStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.PageStart
        UtilReport.ActiveReport.SetFilter(Me, rptProperties)
        UtilReport.ActiveReport.SetSort(Me, rptProperties)
        UtilReport.ActiveReport.SetDisclaimer(Me, rptProperties)
    End Sub

    Private Sub rptNatHazWindAssessmentBuildingEnvelope_ReportEnd(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportEnd
        DisposeParameters()
    End Sub

    Private Sub DisposeParameters()
        DataSource = Nothing
    End Sub

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties

End Class
