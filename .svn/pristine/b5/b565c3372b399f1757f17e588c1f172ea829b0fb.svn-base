Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports

Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Imports GRC.Connect.Libraries.DataLib.razor

Public Class rptFireCOPESummary
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
    Private WithEvents label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblLocationInformation As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFileNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblDivision2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblInspectionDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCity As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblAddress As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblSTProv As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCountry As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblTIVGrid As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblYear As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblPercFR As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblPercNC As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblArea As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblRoofConstructionCombustible As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblClassII As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblStories As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblConstruction As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblOccupancy As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblMajorGroup As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblSpecificGroup As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblProtection As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblWaterSupply As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblSurv As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label6 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label7 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label8 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label9 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label10 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label11 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblWindstorm As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblAPL As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblPML As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblMFL As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label16 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtFileNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSurveyDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCity As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSTProv As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCountry As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtTIV As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtDivision2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtAddress As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtYear As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtPercFR As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtPercNC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtRoofConstructionCombustible As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtArea As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtStories As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtClassII As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSpecificGroup As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtMajorGroup As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtPercAS As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtPercASN As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtWaterSupply As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSurv As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSpecHaz As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtHERating As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtExternalFire As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtEarthquake As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFloodRating As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtWindstormRating As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtAPL As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtPML As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtMFL As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFloodZone As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtWindstormZone As GrapeCity.ActiveReports.SectionReportModel.TextBox
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
    Private WithEvents line32 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line33 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line34 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line35 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line36 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line37 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line38 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line39 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line40 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtClientLocNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFacility As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents line41 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line42 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line43 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line44 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line45 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line46 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line47 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line48 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line49 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line50 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line51 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line52 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line53 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lblReportDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents line54 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line55 As GrapeCity.ActiveReports.SectionReportModel.Line
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
    Private WithEvents line66 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line67 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line68 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line69 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line70 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line71 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line72 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line73 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line74 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line75 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line76 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line77 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line78 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line79 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line80 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line81 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents reportInfo1 As GrapeCity.ActiveReports.SectionReportModel.ReportInfo
    Private WithEvents txtEarthquakeRating As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtDisclaimer As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents PageFooter1 As GrapeCity.ActiveReports.SectionReportModel.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptFireCOPESummary))
        Me.PageHeader1 = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.lblProtection = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPML = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label8 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblClientName = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
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
        Me.lblYear = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPercFR = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPercNC = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblArea = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblRoofConstructionCombustible = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblClassII = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblStories = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblConstruction = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblOccupancy = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblMajorGroup = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSpecificGroup = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblWaterSupply = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSurv = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label7 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label9 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label10 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label11 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblAPL = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblMFL = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label16 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFilters = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtFilters = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblClientLocNo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFacility = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label6 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblWindstorm = New GrapeCity.ActiveReports.SectionReportModel.Label()
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
        Me.line12 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line13 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line14 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line15 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line16 = New GrapeCity.ActiveReports.SectionReportModel.Line()
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
        Me.line30 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line31 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line32 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line33 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line34 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line35 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line36 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line37 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line38 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line39 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line40 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Detail1 = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.txtEarthquakeRating = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPercAS = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtYear = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtStories = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtArea = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtAddress = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtDivision2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFileNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSurveyDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCity = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSTProv = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCountry = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtTIV = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPercFR = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPercNC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtRoofConstructionCombustible = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtClassII = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSpecificGroup = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMajorGroup = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPercASN = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtWaterSupply = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSurv = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSpecHaz = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtHERating = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtExternalFire = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFloodRating = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtWindstormRating = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtAPL = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPML = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMFL = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFloodZone = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtWindstormZone = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFacility = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtClientLocNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtEarthquake = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.line41 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line42 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line43 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line44 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line45 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line46 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line47 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line48 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line49 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line50 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line51 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line52 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line53 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line54 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line55 = New GrapeCity.ActiveReports.SectionReportModel.Line()
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
        Me.line66 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line67 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line68 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line69 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line70 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line71 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line72 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line73 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line74 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line75 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line76 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line77 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line78 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line79 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line80 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line81 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.PageFooter1 = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.txtSort = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblReportDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.reportInfo1 = New GrapeCity.ActiveReports.SectionReportModel.ReportInfo()
        Me.txtDisclaimer = New GrapeCity.ActiveReports.SectionReportModel.Label()
        CType(Me.lblProtection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPML, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblClientName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.lblYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPercFR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPercNC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRoofConstructionCombustible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblClassII, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblStories, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblConstruction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblOccupancy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMajorGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSpecificGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblWaterSupply, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSurv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAPL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMFL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblClientLocNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFacility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblWindstorm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEarthquakeRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPercAS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStories, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDivision2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFileNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSurveyDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSTProv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTIV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPercFR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPercNC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRoofConstructionCombustible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClassII, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSpecificGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMajorGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPercASN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWaterSupply, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSurv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSpecHaz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHERating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExternalFire, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFloodRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWindstormRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAPL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPML, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMFL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFloodZone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWindstormZone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFacility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientLocNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEarthquake, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblReportDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisclaimer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.CanShrink = True
        Me.PageHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblProtection, Me.lblPML, Me.label8, Me.lblClientName, Me.label3, Me.lblLocationInformation, Me.picGRCLogo, Me.lblFileNo, Me.lblDivision2, Me.lblInspectionDate, Me.lblCity, Me.lblAddress, Me.lblSTProv, Me.lblCountry, Me.lblTIVGrid, Me.lblYear, Me.lblPercFR, Me.lblPercNC, Me.lblArea, Me.lblRoofConstructionCombustible, Me.lblClassII, Me.lblStories, Me.lblConstruction, Me.lblOccupancy, Me.lblMajorGroup, Me.lblSpecificGroup, Me.label1, Me.label2, Me.lblWaterSupply, Me.lblSurv, Me.label7, Me.label9, Me.label10, Me.label11, Me.lblAPL, Me.lblMFL, Me.label16, Me.lblFilters, Me.txtFilters, Me.lblClientLocNo, Me.lblFacility, Me.label6, Me.lblWindstorm, Me.line1, Me.line2, Me.line3, Me.line4, Me.line5, Me.line7, Me.line8, Me.line9, Me.line10, Me.line11, Me.line12, Me.line13, Me.line14, Me.line15, Me.line16, Me.line17, Me.line18, Me.line19, Me.line20, Me.line21, Me.line22, Me.line23, Me.line24, Me.line25, Me.line26, Me.line27, Me.line28, Me.line29, Me.line30, Me.line31, Me.line32, Me.line33, Me.line34, Me.line35, Me.line36, Me.line37, Me.line38, Me.line39, Me.line40})
        Me.PageHeader1.Height = 1.5!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'lblProtection
        '
        Me.lblProtection.Height = 0.15!
        Me.lblProtection.HyperLink = Nothing
        Me.lblProtection.Left = 7.5!
        Me.lblProtection.Name = "lblProtection"
        Me.lblProtection.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblProtection.Text = "Protection"
        Me.lblProtection.Top = 1.05!
        Me.lblProtection.Width = 2.1!
        '
        'lblPML
        '
        Me.lblPML.Height = 0.3!
        Me.lblPML.HyperLink = Nothing
        Me.lblPML.Left = 12.37!
        Me.lblPML.Name = "lblPML"
        Me.lblPML.Style = "background-color: White; font-size: 7pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblPML.Text = "PML"
        Me.lblPML.Top = 1.2!
        Me.lblPML.Width = 0.32!
        '
        'label8
        '
        Me.label8.Height = 0.15!
        Me.label8.HyperLink = Nothing
        Me.label8.Left = 9.65!
        Me.label8.Name = "label8"
        Me.label8.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.label8.Text = "Exposure"
        Me.label8.Top = 1.05!
        Me.label8.Width = 2.35!
        '
        'lblClientName
        '
        Me.lblClientName.Height = 0.25!
        Me.lblClientName.HyperLink = Nothing
        Me.lblClientName.Left = 8.63!
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Style = "color: #C6D1DE; font-size: 16pt; font-style: italic; font-weight: bold; text-alig" & _
    "n: right; vertical-align: middle"
        Me.lblClientName.Text = "Company Name"
        Me.lblClientName.Top = 0.05!
        Me.lblClientName.Width = 4.3!
        '
        'label3
        '
        Me.label3.Height = 0.25!
        Me.label3.HyperLink = Nothing
        Me.label3.Left = 8.63!
        Me.label3.Name = "label3"
        Me.label3.Style = "font-size: 12pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.label3.Text = "Fire C.O.P.E. Summary"
        Me.label3.Top = 0.35!
        Me.label3.Width = 4.3!
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
        Me.lblInspectionDate.Left = 0.52!
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
        Me.lblAddress.Style = "font-size: 7pt; vertical-align: middle"
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
        'lblYear
        '
        Me.lblYear.Height = 0.15!
        Me.lblYear.HyperLink = Nothing
        Me.lblYear.Left = 4.42!
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblYear.Text = "Year"
        Me.lblYear.Top = 1.2!
        Me.lblYear.Width = 0.26!
        '
        'lblPercFR
        '
        Me.lblPercFR.Height = 0.15!
        Me.lblPercFR.HyperLink = Nothing
        Me.lblPercFR.Left = 4.42!
        Me.lblPercFR.Name = "lblPercFR"
        Me.lblPercFR.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblPercFR.Text = "%FR"
        Me.lblPercFR.Top = 1.35!
        Me.lblPercFR.Width = 0.36!
        '
        'lblPercNC
        '
        Me.lblPercNC.Height = 0.15!
        Me.lblPercNC.HyperLink = Nothing
        Me.lblPercNC.Left = 4.78!
        Me.lblPercNC.Name = "lblPercNC"
        Me.lblPercNC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblPercNC.Text = "%NC"
        Me.lblPercNC.Top = 1.35!
        Me.lblPercNC.Width = 0.36!
        '
        'lblArea
        '
        Me.lblArea.Height = 0.15!
        Me.lblArea.HyperLink = Nothing
        Me.lblArea.Left = 4.84!
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblArea.Text = "Area"
        Me.lblArea.Top = 1.2!
        Me.lblArea.Width = 0.41!
        '
        'lblRoofConstructionCombustible
        '
        Me.lblRoofConstructionCombustible.Height = 0.15!
        Me.lblRoofConstructionCombustible.HyperLink = Nothing
        Me.lblRoofConstructionCombustible.Left = 5.14!
        Me.lblRoofConstructionCombustible.Name = "lblRoofConstructionCombustible"
        Me.lblRoofConstructionCombustible.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblRoofConstructionCombustible.Text = "%Comb"
        Me.lblRoofConstructionCombustible.Top = 1.35!
        Me.lblRoofConstructionCombustible.Width = 0.38!
        '
        'lblClassII
        '
        Me.lblClassII.Height = 0.15!
        Me.lblClassII.HyperLink = Nothing
        Me.lblClassII.Left = 5.52!
        Me.lblClassII.Name = "lblClassII"
        Me.lblClassII.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblClassII.Text = "Class II"
        Me.lblClassII.Top = 1.35!
        Me.lblClassII.Width = 0.37!
        '
        'lblStories
        '
        Me.lblStories.Height = 0.15!
        Me.lblStories.HyperLink = Nothing
        Me.lblStories.Left = 5.25!
        Me.lblStories.Name = "lblStories"
        Me.lblStories.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblStories.Text = "No. of Stories"
        Me.lblStories.Top = 1.2!
        Me.lblStories.Width = 0.64!
        '
        'lblConstruction
        '
        Me.lblConstruction.Height = 0.15!
        Me.lblConstruction.HyperLink = Nothing
        Me.lblConstruction.Left = 4.42!
        Me.lblConstruction.Name = "lblConstruction"
        Me.lblConstruction.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblConstruction.Text = "Construction"
        Me.lblConstruction.Top = 1.05!
        Me.lblConstruction.Width = 1.47!
        '
        'lblOccupancy
        '
        Me.lblOccupancy.Height = 0.15!
        Me.lblOccupancy.HyperLink = Nothing
        Me.lblOccupancy.Left = 5.94!
        Me.lblOccupancy.Name = "lblOccupancy"
        Me.lblOccupancy.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblOccupancy.Text = "Occupancy"
        Me.lblOccupancy.Top = 1.05!
        Me.lblOccupancy.Width = 1.51!
        '
        'lblMajorGroup
        '
        Me.lblMajorGroup.Height = 0.15!
        Me.lblMajorGroup.HyperLink = Nothing
        Me.lblMajorGroup.Left = 5.94!
        Me.lblMajorGroup.Name = "lblMajorGroup"
        Me.lblMajorGroup.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblMajorGroup.Text = "Major Group/"
        Me.lblMajorGroup.Top = 1.2!
        Me.lblMajorGroup.Width = 1.51!
        '
        'lblSpecificGroup
        '
        Me.lblSpecificGroup.Height = 0.15!
        Me.lblSpecificGroup.HyperLink = Nothing
        Me.lblSpecificGroup.Left = 5.94!
        Me.lblSpecificGroup.Name = "lblSpecificGroup"
        Me.lblSpecificGroup.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblSpecificGroup.Text = "Specific Group"
        Me.lblSpecificGroup.Top = 1.35!
        Me.lblSpecificGroup.Width = 1.51!
        '
        'label1
        '
        Me.label1.Height = 0.3!
        Me.label1.HyperLink = Nothing
        Me.label1.Left = 7.5!
        Me.label1.Name = "label1"
        Me.label1.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.label1.Text = "%AS"
        Me.label1.Top = 1.2!
        Me.label1.Width = 0.25!
        '
        'label2
        '
        Me.label2.Height = 0.3!
        Me.label2.HyperLink = Nothing
        Me.label2.Left = 7.75!
        Me.label2.Name = "label2"
        Me.label2.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.label2.Text = "%ASN"
        Me.label2.Top = 1.2!
        Me.label2.Width = 0.25!
        '
        'lblWaterSupply
        '
        Me.lblWaterSupply.Height = 0.3!
        Me.lblWaterSupply.HyperLink = Nothing
        Me.lblWaterSupply.Left = 8.0!
        Me.lblWaterSupply.Name = "lblWaterSupply"
        Me.lblWaterSupply.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblWaterSupply.Text = "Water Supply"
        Me.lblWaterSupply.Top = 1.2!
        Me.lblWaterSupply.Width = 0.45!
        '
        'lblSurv
        '
        Me.lblSurv.Height = 0.3!
        Me.lblSurv.HyperLink = Nothing
        Me.lblSurv.Left = 8.45!
        Me.lblSurv.Name = "lblSurv"
        Me.lblSurv.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblSurv.Text = "Surv."
        Me.lblSurv.Top = 1.2!
        Me.lblSurv.Width = 0.45!
        '
        'label7
        '
        Me.label7.Height = 0.3!
        Me.label7.HyperLink = Nothing
        Me.label7.Left = 9.35!
        Me.label7.Name = "label7"
        Me.label7.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.label7.Text = "HE"
        Me.label7.Top = 1.2!
        Me.label7.Width = 0.25!
        '
        'label9
        '
        Me.label9.Height = 0.3!
        Me.label9.HyperLink = Nothing
        Me.label9.Left = 9.65!
        Me.label9.Name = "label9"
        Me.label9.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.label9.Text = "External Fire"
        Me.label9.Top = 1.2!
        Me.label9.Width = 0.45!
        '
        'label10
        '
        Me.label10.Height = 0.3!
        Me.label10.HyperLink = Nothing
        Me.label10.Left = 10.1!
        Me.label10.Name = "label10"
        Me.label10.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.label10.Text = "Earth-quake"
        Me.label10.Top = 1.2!
        Me.label10.Width = 0.45!
        '
        'label11
        '
        Me.label11.Height = 0.3!
        Me.label11.HyperLink = Nothing
        Me.label11.Left = 10.55!
        Me.label11.Name = "label11"
        Me.label11.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.label11.Text = "Flood"
        Me.label11.Top = 1.2!
        Me.label11.Width = 0.8999996!
        '
        'lblAPL
        '
        Me.lblAPL.Height = 0.3!
        Me.lblAPL.HyperLink = Nothing
        Me.lblAPL.Left = 12.05!
        Me.lblAPL.Name = "lblAPL"
        Me.lblAPL.Style = "background-color: White; font-size: 7pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblAPL.Text = "APL"
        Me.lblAPL.Top = 1.2!
        Me.lblAPL.Width = 0.32!
        '
        'lblMFL
        '
        Me.lblMFL.Height = 0.3!
        Me.lblMFL.HyperLink = Nothing
        Me.lblMFL.Left = 12.69!
        Me.lblMFL.Name = "lblMFL"
        Me.lblMFL.Style = "background-color: White; font-size: 7pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblMFL.Text = "MFL"
        Me.lblMFL.Top = 1.2!
        Me.lblMFL.Width = 0.31!
        '
        'label16
        '
        Me.label16.Height = 0.15!
        Me.label16.HyperLink = Nothing
        Me.label16.Left = 12.05!
        Me.label16.Name = "label16"
        Me.label16.Style = "background-color: White; font-size: 7pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.label16.Text = "LE's (millions)"
        Me.label16.Top = 1.05!
        Me.label16.Width = 0.95!
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
        Me.txtFilters.Width = 12.56!
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
        'label6
        '
        Me.label6.Height = 0.3!
        Me.label6.HyperLink = Nothing
        Me.label6.Left = 8.9!
        Me.label6.Name = "label6"
        Me.label6.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.label6.Text = "Spec. Haz."
        Me.label6.Top = 1.2!
        Me.label6.Width = 0.45!
        '
        'lblWindstorm
        '
        Me.lblWindstorm.Height = 0.3!
        Me.lblWindstorm.HyperLink = Nothing
        Me.lblWindstorm.Left = 11.45!
        Me.lblWindstorm.Name = "lblWindstorm"
        Me.lblWindstorm.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblWindstorm.Text = "Windstorm"
        Me.lblWindstorm.Top = 1.2!
        Me.lblWindstorm.Width = 0.55!
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
        Me.line7.Left = 5.89!
        Me.line7.LineWeight = 1.0!
        Me.line7.Name = "line7"
        Me.line7.Top = 1.05!
        Me.line7.Width = 0.0!
        Me.line7.X1 = 5.89!
        Me.line7.X2 = 5.89!
        Me.line7.Y1 = 1.05!
        Me.line7.Y2 = 1.5!
        '
        'line8
        '
        Me.line8.Height = 0.45!
        Me.line8.Left = 5.94!
        Me.line8.LineWeight = 1.0!
        Me.line8.Name = "line8"
        Me.line8.Top = 1.05!
        Me.line8.Width = 0.0!
        Me.line8.X1 = 5.94!
        Me.line8.X2 = 5.94!
        Me.line8.Y1 = 1.05!
        Me.line8.Y2 = 1.5!
        '
        'line9
        '
        Me.line9.Height = 0.45!
        Me.line9.Left = 7.45!
        Me.line9.LineWeight = 1.0!
        Me.line9.Name = "line9"
        Me.line9.Top = 1.05!
        Me.line9.Width = 0.0!
        Me.line9.X1 = 7.45!
        Me.line9.X2 = 7.45!
        Me.line9.Y1 = 1.05!
        Me.line9.Y2 = 1.5!
        '
        'line10
        '
        Me.line10.Height = 0.45!
        Me.line10.Left = 7.5!
        Me.line10.LineWeight = 1.0!
        Me.line10.Name = "line10"
        Me.line10.Top = 1.05!
        Me.line10.Width = 0.0!
        Me.line10.X1 = 7.5!
        Me.line10.X2 = 7.5!
        Me.line10.Y1 = 1.05!
        Me.line10.Y2 = 1.5!
        '
        'line11
        '
        Me.line11.Height = 0.45!
        Me.line11.Left = 9.6!
        Me.line11.LineWeight = 1.0!
        Me.line11.Name = "line11"
        Me.line11.Top = 1.05!
        Me.line11.Width = 0.0!
        Me.line11.X1 = 9.6!
        Me.line11.X2 = 9.6!
        Me.line11.Y1 = 1.05!
        Me.line11.Y2 = 1.5!
        '
        'line12
        '
        Me.line12.Height = 0.45!
        Me.line12.Left = 9.65!
        Me.line12.LineWeight = 1.0!
        Me.line12.Name = "line12"
        Me.line12.Top = 1.05!
        Me.line12.Width = 0.0!
        Me.line12.X1 = 9.65!
        Me.line12.X2 = 9.65!
        Me.line12.Y1 = 1.05!
        Me.line12.Y2 = 1.5!
        '
        'line13
        '
        Me.line13.Height = 0.45!
        Me.line13.Left = 12.0!
        Me.line13.LineWeight = 1.0!
        Me.line13.Name = "line13"
        Me.line13.Top = 1.05!
        Me.line13.Width = 0.0!
        Me.line13.X1 = 12.0!
        Me.line13.X2 = 12.0!
        Me.line13.Y1 = 1.05!
        Me.line13.Y2 = 1.5!
        '
        'line14
        '
        Me.line14.Height = 0.45!
        Me.line14.Left = 12.05!
        Me.line14.LineWeight = 1.0!
        Me.line14.Name = "line14"
        Me.line14.Top = 1.05!
        Me.line14.Width = 0.0!
        Me.line14.X1 = 12.05!
        Me.line14.X2 = 12.05!
        Me.line14.Y1 = 1.05!
        Me.line14.Y2 = 1.5!
        '
        'line15
        '
        Me.line15.Height = 0.45!
        Me.line15.Left = 13.0!
        Me.line15.LineWeight = 1.0!
        Me.line15.Name = "line15"
        Me.line15.Top = 1.05!
        Me.line15.Width = 0.0!
        Me.line15.X1 = 13.0!
        Me.line15.X2 = 13.0!
        Me.line15.Y1 = 1.05!
        Me.line15.Y2 = 1.5!
        '
        'line16
        '
        Me.line16.Height = 0.0!
        Me.line16.Left = 4.42!
        Me.line16.LineWeight = 1.0!
        Me.line16.Name = "line16"
        Me.line16.Top = 1.5!
        Me.line16.Width = 1.68!
        Me.line16.X1 = 4.42!
        Me.line16.X2 = 6.1!
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
        Me.line17.Width = 1.47!
        Me.line17.X1 = 4.42!
        Me.line17.X2 = 5.89!
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
        Me.line18.Width = 1.47!
        Me.line18.X1 = 4.42!
        Me.line18.X2 = 5.89!
        Me.line18.Y1 = 1.05!
        Me.line18.Y2 = 1.05!
        '
        'line19
        '
        Me.line19.Height = 0.0!
        Me.line19.Left = 5.94!
        Me.line19.LineWeight = 1.0!
        Me.line19.Name = "line19"
        Me.line19.Top = 1.5!
        Me.line19.Width = 1.51!
        Me.line19.X1 = 5.94!
        Me.line19.X2 = 7.45!
        Me.line19.Y1 = 1.5!
        Me.line19.Y2 = 1.5!
        '
        'line20
        '
        Me.line20.Height = 0.0!
        Me.line20.Left = 5.94!
        Me.line20.LineWeight = 1.0!
        Me.line20.Name = "line20"
        Me.line20.Top = 1.2!
        Me.line20.Width = 1.51!
        Me.line20.X1 = 5.94!
        Me.line20.X2 = 7.45!
        Me.line20.Y1 = 1.2!
        Me.line20.Y2 = 1.2!
        '
        'line21
        '
        Me.line21.Height = 0.0!
        Me.line21.Left = 5.94!
        Me.line21.LineWeight = 1.0!
        Me.line21.Name = "line21"
        Me.line21.Top = 1.05!
        Me.line21.Width = 1.51!
        Me.line21.X1 = 5.94!
        Me.line21.X2 = 7.45!
        Me.line21.Y1 = 1.05!
        Me.line21.Y2 = 1.05!
        '
        'line22
        '
        Me.line22.Height = 0.0!
        Me.line22.Left = 7.5!
        Me.line22.LineWeight = 1.0!
        Me.line22.Name = "line22"
        Me.line22.Top = 1.5!
        Me.line22.Width = 2.1!
        Me.line22.X1 = 7.5!
        Me.line22.X2 = 9.6!
        Me.line22.Y1 = 1.5!
        Me.line22.Y2 = 1.5!
        '
        'line23
        '
        Me.line23.Height = 0.0!
        Me.line23.Left = 7.5!
        Me.line23.LineWeight = 1.0!
        Me.line23.Name = "line23"
        Me.line23.Top = 1.2!
        Me.line23.Width = 2.1!
        Me.line23.X1 = 7.5!
        Me.line23.X2 = 9.6!
        Me.line23.Y1 = 1.2!
        Me.line23.Y2 = 1.2!
        '
        'line24
        '
        Me.line24.Height = 0.0!
        Me.line24.Left = 7.5!
        Me.line24.LineWeight = 1.0!
        Me.line24.Name = "line24"
        Me.line24.Top = 1.05!
        Me.line24.Width = 2.1!
        Me.line24.X1 = 7.5!
        Me.line24.X2 = 9.6!
        Me.line24.Y1 = 1.05!
        Me.line24.Y2 = 1.05!
        '
        'line25
        '
        Me.line25.Height = 0.0!
        Me.line25.Left = 9.65!
        Me.line25.LineWeight = 1.0!
        Me.line25.Name = "line25"
        Me.line25.Top = 1.5!
        Me.line25.Width = 2.35!
        Me.line25.X1 = 9.65!
        Me.line25.X2 = 12.0!
        Me.line25.Y1 = 1.5!
        Me.line25.Y2 = 1.5!
        '
        'line26
        '
        Me.line26.Height = 0.0!
        Me.line26.Left = 9.65!
        Me.line26.LineWeight = 1.0!
        Me.line26.Name = "line26"
        Me.line26.Top = 1.2!
        Me.line26.Width = 2.35!
        Me.line26.X1 = 9.65!
        Me.line26.X2 = 12.0!
        Me.line26.Y1 = 1.2!
        Me.line26.Y2 = 1.2!
        '
        'line27
        '
        Me.line27.Height = 0.0!
        Me.line27.Left = 9.65!
        Me.line27.LineWeight = 1.0!
        Me.line27.Name = "line27"
        Me.line27.Top = 1.05!
        Me.line27.Width = 2.35!
        Me.line27.X1 = 9.65!
        Me.line27.X2 = 12.0!
        Me.line27.Y1 = 1.05!
        Me.line27.Y2 = 1.05!
        '
        'line28
        '
        Me.line28.Height = 0.0!
        Me.line28.Left = 12.05!
        Me.line28.LineWeight = 1.0!
        Me.line28.Name = "line28"
        Me.line28.Top = 1.5!
        Me.line28.Width = 0.9499998!
        Me.line28.X1 = 12.05!
        Me.line28.X2 = 13.0!
        Me.line28.Y1 = 1.5!
        Me.line28.Y2 = 1.5!
        '
        'line29
        '
        Me.line29.Height = 0.0!
        Me.line29.Left = 12.05!
        Me.line29.LineWeight = 1.0!
        Me.line29.Name = "line29"
        Me.line29.Top = 1.2!
        Me.line29.Width = 0.9499998!
        Me.line29.X1 = 12.05!
        Me.line29.X2 = 13.0!
        Me.line29.Y1 = 1.2!
        Me.line29.Y2 = 1.2!
        '
        'line30
        '
        Me.line30.Height = 0.0!
        Me.line30.Left = 12.05!
        Me.line30.LineWeight = 1.0!
        Me.line30.Name = "line30"
        Me.line30.Top = 1.05!
        Me.line30.Width = 0.9499998!
        Me.line30.X1 = 12.05!
        Me.line30.X2 = 13.0!
        Me.line30.Y1 = 1.05!
        Me.line30.Y2 = 1.05!
        '
        'line31
        '
        Me.line31.Height = 0.3!
        Me.line31.Left = 12.69!
        Me.line31.LineWeight = 1.0!
        Me.line31.Name = "line31"
        Me.line31.Top = 1.2!
        Me.line31.Width = 0.0!
        Me.line31.X1 = 12.69!
        Me.line31.X2 = 12.69!
        Me.line31.Y1 = 1.2!
        Me.line31.Y2 = 1.5!
        '
        'line32
        '
        Me.line32.Height = 0.3!
        Me.line32.Left = 12.37!
        Me.line32.LineWeight = 1.0!
        Me.line32.Name = "line32"
        Me.line32.Top = 1.2!
        Me.line32.Width = 0.0!
        Me.line32.X1 = 12.37!
        Me.line32.X2 = 12.37!
        Me.line32.Y1 = 1.2!
        Me.line32.Y2 = 1.5!
        '
        'line33
        '
        Me.line33.Height = 0.3!
        Me.line33.Left = 11.45!
        Me.line33.LineWeight = 1.0!
        Me.line33.Name = "line33"
        Me.line33.Top = 1.2!
        Me.line33.Width = 0.0!
        Me.line33.X1 = 11.45!
        Me.line33.X2 = 11.45!
        Me.line33.Y1 = 1.2!
        Me.line33.Y2 = 1.5!
        '
        'line34
        '
        Me.line34.Height = 0.3!
        Me.line34.Left = 10.55!
        Me.line34.LineWeight = 1.0!
        Me.line34.Name = "line34"
        Me.line34.Top = 1.2!
        Me.line34.Width = 0.0!
        Me.line34.X1 = 10.55!
        Me.line34.X2 = 10.55!
        Me.line34.Y1 = 1.2!
        Me.line34.Y2 = 1.5!
        '
        'line35
        '
        Me.line35.Height = 0.3!
        Me.line35.Left = 10.1!
        Me.line35.LineWeight = 1.0!
        Me.line35.Name = "line35"
        Me.line35.Top = 1.2!
        Me.line35.Width = 0.0!
        Me.line35.X1 = 10.1!
        Me.line35.X2 = 10.1!
        Me.line35.Y1 = 1.2!
        Me.line35.Y2 = 1.5!
        '
        'line36
        '
        Me.line36.Height = 0.3!
        Me.line36.Left = 9.35!
        Me.line36.LineWeight = 1.0!
        Me.line36.Name = "line36"
        Me.line36.Top = 1.2!
        Me.line36.Width = 0.0!
        Me.line36.X1 = 9.35!
        Me.line36.X2 = 9.35!
        Me.line36.Y1 = 1.2!
        Me.line36.Y2 = 1.5!
        '
        'line37
        '
        Me.line37.Height = 0.3!
        Me.line37.Left = 8.9!
        Me.line37.LineWeight = 1.0!
        Me.line37.Name = "line37"
        Me.line37.Top = 1.2!
        Me.line37.Width = 0.0!
        Me.line37.X1 = 8.9!
        Me.line37.X2 = 8.9!
        Me.line37.Y1 = 1.2!
        Me.line37.Y2 = 1.5!
        '
        'line38
        '
        Me.line38.Height = 0.3!
        Me.line38.Left = 8.45!
        Me.line38.LineWeight = 1.0!
        Me.line38.Name = "line38"
        Me.line38.Top = 1.2!
        Me.line38.Width = 0.0!
        Me.line38.X1 = 8.45!
        Me.line38.X2 = 8.45!
        Me.line38.Y1 = 1.2!
        Me.line38.Y2 = 1.5!
        '
        'line39
        '
        Me.line39.Height = 0.3!
        Me.line39.Left = 8.0!
        Me.line39.LineWeight = 1.0!
        Me.line39.Name = "line39"
        Me.line39.Top = 1.2!
        Me.line39.Width = 0.0!
        Me.line39.X1 = 8.0!
        Me.line39.X2 = 8.0!
        Me.line39.Y1 = 1.2!
        Me.line39.Y2 = 1.5!
        '
        'line40
        '
        Me.line40.Height = 0.3!
        Me.line40.Left = 7.75!
        Me.line40.LineWeight = 1.0!
        Me.line40.Name = "line40"
        Me.line40.Top = 1.2!
        Me.line40.Width = 0.0!
        Me.line40.X1 = 7.75!
        Me.line40.X2 = 7.75!
        Me.line40.Y1 = 1.2!
        Me.line40.Y2 = 1.5!
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtEarthquakeRating, Me.txtPercAS, Me.txtYear, Me.txtStories, Me.txtArea, Me.txtAddress, Me.txtDivision2, Me.txtFileNo, Me.txtSurveyDate, Me.txtCity, Me.txtSTProv, Me.txtCountry, Me.txtTIV, Me.txtPercFR, Me.txtPercNC, Me.txtRoofConstructionCombustible, Me.txtClassII, Me.txtSpecificGroup, Me.txtMajorGroup, Me.txtPercASN, Me.txtWaterSupply, Me.txtSurv, Me.txtSpecHaz, Me.txtHERating, Me.txtExternalFire, Me.txtFloodRating, Me.txtWindstormRating, Me.txtAPL, Me.txtPML, Me.txtMFL, Me.txtFloodZone, Me.txtWindstormZone, Me.txtFacility, Me.txtClientLocNo, Me.txtEarthquake, Me.line41, Me.line42, Me.line43, Me.line44, Me.line45, Me.line46, Me.line47, Me.line48, Me.line49, Me.line50, Me.line51, Me.line52, Me.line53, Me.line54, Me.line55, Me.line56, Me.line57, Me.line58, Me.line59, Me.line60, Me.line61, Me.line62, Me.line63, Me.line64, Me.line65, Me.line66, Me.line67, Me.line68, Me.line69, Me.line70, Me.line71, Me.line72, Me.line73, Me.line74, Me.line75, Me.line76, Me.line77, Me.line78, Me.line79, Me.line80, Me.line81})
        Me.Detail1.Height = 0.4125!
        Me.Detail1.KeepTogether = True
        Me.Detail1.Name = "Detail1"
        '
        'txtEarthquakeRating
        '
        Me.txtEarthquakeRating.DataField = "Seismic"
        Me.txtEarthquakeRating.Height = 0.15!
        Me.txtEarthquakeRating.Left = 10.1!
        Me.txtEarthquakeRating.Name = "txtEarthquakeRating"
        Me.txtEarthquakeRating.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtEarthquakeRating.Text = "Rating"
        Me.txtEarthquakeRating.Top = 0.05!
        Me.txtEarthquakeRating.Width = 0.4499998!
        '
        'txtPercAS
        '
        Me.txtPercAS.DataField = "AreaWithSprinklers"
        Me.txtPercAS.Height = 0.3!
        Me.txtPercAS.Left = 7.5!
        Me.txtPercAS.Name = "txtPercAS"
        Me.txtPercAS.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtPercAS.Text = "%AS"
        Me.txtPercAS.Top = 0.05!
        Me.txtPercAS.Width = 0.25!
        '
        'txtYear
        '
        Me.txtYear.DataField = "InititalMajorConstructionYear"
        Me.txtYear.Height = 0.15!
        Me.txtYear.Left = 4.42!
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtYear.Text = "Year"
        Me.txtYear.Top = 0.05!
        Me.txtYear.Width = 0.26!
        '
        'txtStories
        '
        Me.txtStories.DataField = "NoofStories"
        Me.txtStories.Height = 0.15!
        Me.txtStories.Left = 5.44!
        Me.txtStories.Name = "txtStories"
        Me.txtStories.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtStories.Text = "Stories"
        Me.txtStories.Top = 0.05!
        Me.txtStories.Width = 0.45!
        '
        'txtArea
        '
        Me.txtArea.DataField = "TotalFloorArea"
        Me.txtArea.Height = 0.15!
        Me.txtArea.Left = 4.68!
        Me.txtArea.Name = "txtArea"
        Me.txtArea.OutputFormat = resources.GetString("txtArea.OutputFormat")
        Me.txtArea.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtArea.Text = "Total Floor Area"
        Me.txtArea.Top = 0.05!
        Me.txtArea.Width = 0.76!
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
        Me.txtSurveyDate.DataField = "SurveyDateString"
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
        'txtPercFR
        '
        Me.txtPercFR.DataField = "RoofConstructionFireResistive"
        Me.txtPercFR.Height = 0.15!
        Me.txtPercFR.Left = 4.42!
        Me.txtPercFR.Name = "txtPercFR"
        Me.txtPercFR.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtPercFR.Text = "%FR"
        Me.txtPercFR.Top = 0.2!
        Me.txtPercFR.Width = 0.36!
        '
        'txtPercNC
        '
        Me.txtPercNC.DataField = "RoofConstructionNoncombustible"
        Me.txtPercNC.Height = 0.15!
        Me.txtPercNC.Left = 4.78!
        Me.txtPercNC.Name = "txtPercNC"
        Me.txtPercNC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtPercNC.Text = "%NC"
        Me.txtPercNC.Top = 0.2!
        Me.txtPercNC.Width = 0.36!
        '
        'txtRoofConstructionCombustible
        '
        Me.txtRoofConstructionCombustible.DataField = "RoofConstructionCombustible"
        Me.txtRoofConstructionCombustible.Height = 0.15!
        Me.txtRoofConstructionCombustible.Left = 5.14!
        Me.txtRoofConstructionCombustible.Name = "txtRoofConstructionCombustible"
        Me.txtRoofConstructionCombustible.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtRoofConstructionCombustible.Text = "%Comb"
        Me.txtRoofConstructionCombustible.Top = 0.2!
        Me.txtRoofConstructionCombustible.Width = 0.38!
        '
        'txtClassII
        '
        Me.txtClassII.DataField = "RoofConstructionClass"
        Me.txtClassII.Height = 0.15!
        Me.txtClassII.Left = 5.52!
        Me.txtClassII.Name = "txtClassII"
        Me.txtClassII.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtClassII.Text = "Class II"
        Me.txtClassII.Top = 0.188!
        Me.txtClassII.Width = 0.37!
        '
        'txtSpecificGroup
        '
        Me.txtSpecificGroup.DataField = "SpecificGroup"
        Me.txtSpecificGroup.Height = 0.15!
        Me.txtSpecificGroup.Left = 5.94!
        Me.txtSpecificGroup.Name = "txtSpecificGroup"
        Me.txtSpecificGroup.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtSpecificGroup.Text = "Specific Group"
        Me.txtSpecificGroup.Top = 0.2!
        Me.txtSpecificGroup.Width = 1.51!
        '
        'txtMajorGroup
        '
        Me.txtMajorGroup.DataField = "MajorGroup"
        Me.txtMajorGroup.Height = 0.15!
        Me.txtMajorGroup.Left = 5.94!
        Me.txtMajorGroup.Name = "txtMajorGroup"
        Me.txtMajorGroup.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtMajorGroup.Text = "Major Group"
        Me.txtMajorGroup.Top = 0.05!
        Me.txtMajorGroup.Width = 1.51!
        '
        'txtPercASN
        '
        Me.txtPercASN.DataField = "AreaWithoutSprinklersNeedingSprinklers"
        Me.txtPercASN.Height = 0.3!
        Me.txtPercASN.Left = 7.75!
        Me.txtPercASN.Name = "txtPercASN"
        Me.txtPercASN.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtPercASN.Text = "%ASN"
        Me.txtPercASN.Top = 0.05!
        Me.txtPercASN.Width = 0.25!
        '
        'txtWaterSupply
        '
        Me.txtWaterSupply.DataField = "WaterSupplyRating"
        Me.txtWaterSupply.Height = 0.3!
        Me.txtWaterSupply.Left = 8.0!
        Me.txtWaterSupply.Name = "txtWaterSupply"
        Me.txtWaterSupply.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtWaterSupply.Text = "Water Supply"
        Me.txtWaterSupply.Top = 0.05!
        Me.txtWaterSupply.Width = 0.45!
        '
        'txtSurv
        '
        Me.txtSurv.DataField = "PropertySurveillance"
        Me.txtSurv.Height = 0.3!
        Me.txtSurv.Left = 8.45!
        Me.txtSurv.Name = "txtSurv"
        Me.txtSurv.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtSurv.Text = "Surv"
        Me.txtSurv.Top = 0.05!
        Me.txtSurv.Width = 0.45!
        '
        'txtSpecHaz
        '
        Me.txtSpecHaz.DataField = "SpecialHazardsRating"
        Me.txtSpecHaz.Height = 0.3!
        Me.txtSpecHaz.Left = 8.9!
        Me.txtSpecHaz.Name = "txtSpecHaz"
        Me.txtSpecHaz.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtSpecHaz.Text = "Spec. Haz"
        Me.txtSpecHaz.Top = 0.05!
        Me.txtSpecHaz.Width = 0.45!
        '
        'txtHERating
        '
        Me.txtHERating.DataField = "HumanElementRating"
        Me.txtHERating.Height = 0.3!
        Me.txtHERating.Left = 9.35!
        Me.txtHERating.Name = "txtHERating"
        Me.txtHERating.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtHERating.Text = "HE"
        Me.txtHERating.Top = 0.05!
        Me.txtHERating.Width = 0.25!
        '
        'txtExternalFire
        '
        Me.txtExternalFire.DataField = "ExternalFire"
        Me.txtExternalFire.Height = 0.3!
        Me.txtExternalFire.Left = 9.65!
        Me.txtExternalFire.Name = "txtExternalFire"
        Me.txtExternalFire.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtExternalFire.Text = "External Fire"
        Me.txtExternalFire.Top = 0.05!
        Me.txtExternalFire.Width = 0.45!
        '
        'txtFloodRating
        '
        Me.txtFloodRating.DataField = "Flood"
        Me.txtFloodRating.Height = 0.15!
        Me.txtFloodRating.Left = 10.55!
        Me.txtFloodRating.Name = "txtFloodRating"
        Me.txtFloodRating.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtFloodRating.Text = "Rating"
        Me.txtFloodRating.Top = 0.05!
        Me.txtFloodRating.Width = 0.9!
        '
        'txtWindstormRating
        '
        Me.txtWindstormRating.DataField = "Windstorm"
        Me.txtWindstormRating.Height = 0.15!
        Me.txtWindstormRating.Left = 11.45!
        Me.txtWindstormRating.Name = "txtWindstormRating"
        Me.txtWindstormRating.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtWindstormRating.Text = "Rating"
        Me.txtWindstormRating.Top = 0.05!
        Me.txtWindstormRating.Width = 0.55!
        '
        'txtAPL
        '
        Me.txtAPL.DataField = "APL"
        Me.txtAPL.Height = 0.3!
        Me.txtAPL.Left = 12.05!
        Me.txtAPL.Name = "txtAPL"
        Me.txtAPL.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtAPL.Text = "APL"
        Me.txtAPL.Top = 0.05!
        Me.txtAPL.Width = 0.32!
        '
        'txtPML
        '
        Me.txtPML.DataField = "PML"
        Me.txtPML.Height = 0.3!
        Me.txtPML.Left = 12.37!
        Me.txtPML.Name = "txtPML"
        Me.txtPML.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtPML.Text = "PML"
        Me.txtPML.Top = 0.05!
        Me.txtPML.Width = 0.32!
        '
        'txtMFL
        '
        Me.txtMFL.DataField = "MFL"
        Me.txtMFL.Height = 0.3!
        Me.txtMFL.Left = 12.69!
        Me.txtMFL.Name = "txtMFL"
        Me.txtMFL.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtMFL.Text = "MFL"
        Me.txtMFL.Top = 0.05!
        Me.txtMFL.Width = 0.31!
        '
        'txtFloodZone
        '
        Me.txtFloodZone.DataField = "Zone"
        Me.txtFloodZone.Height = 0.15!
        Me.txtFloodZone.Left = 10.55!
        Me.txtFloodZone.Name = "txtFloodZone"
        Me.txtFloodZone.Style = "background-color: White; font-size: 6pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtFloodZone.Text = "Zone"
        Me.txtFloodZone.Top = 0.2!
        Me.txtFloodZone.Width = 0.9!
        '
        'txtWindstormZone
        '
        Me.txtWindstormZone.DataField = "MaxSustainedWindSpeed"
        Me.txtWindstormZone.Height = 0.15!
        Me.txtWindstormZone.Left = 11.45!
        Me.txtWindstormZone.Name = "txtWindstormZone"
        Me.txtWindstormZone.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtWindstormZone.Text = "Zone"
        Me.txtWindstormZone.Top = 0.2!
        Me.txtWindstormZone.Width = 0.55!
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
        'txtEarthquake
        '
        Me.txtEarthquake.DataField = "FMSeismicZone"
        Me.txtEarthquake.Height = 0.162!
        Me.txtEarthquake.Left = 10.1!
        Me.txtEarthquake.Name = "txtEarthquake"
        Me.txtEarthquake.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtEarthquake.Text = "Zone"
        Me.txtEarthquake.Top = 0.188!
        Me.txtEarthquake.Width = 0.4499998!
        '
        'line41
        '
        Me.line41.Height = 0.3!
        Me.line41.Left = 13.0!
        Me.line41.LineWeight = 1.0!
        Me.line41.Name = "line41"
        Me.line41.Top = 0.05!
        Me.line41.Width = 0.0!
        Me.line41.X1 = 13.0!
        Me.line41.X2 = 13.0!
        Me.line41.Y1 = 0.05!
        Me.line41.Y2 = 0.35!
        '
        'line42
        '
        Me.line42.Height = 0.3!
        Me.line42.Left = 12.69!
        Me.line42.LineWeight = 1.0!
        Me.line42.Name = "line42"
        Me.line42.Top = 0.05!
        Me.line42.Width = 0.0!
        Me.line42.X1 = 12.69!
        Me.line42.X2 = 12.69!
        Me.line42.Y1 = 0.05!
        Me.line42.Y2 = 0.35!
        '
        'line43
        '
        Me.line43.Height = 0.3!
        Me.line43.Left = 12.37!
        Me.line43.LineWeight = 1.0!
        Me.line43.Name = "line43"
        Me.line43.Top = 0.05!
        Me.line43.Width = 0.0!
        Me.line43.X1 = 12.37!
        Me.line43.X2 = 12.37!
        Me.line43.Y1 = 0.05!
        Me.line43.Y2 = 0.35!
        '
        'line44
        '
        Me.line44.Height = 0.3!
        Me.line44.Left = 12.05!
        Me.line44.LineWeight = 1.0!
        Me.line44.Name = "line44"
        Me.line44.Top = 0.05!
        Me.line44.Width = 0.0!
        Me.line44.X1 = 12.05!
        Me.line44.X2 = 12.05!
        Me.line44.Y1 = 0.05!
        Me.line44.Y2 = 0.35!
        '
        'line45
        '
        Me.line45.Height = 0.3!
        Me.line45.Left = 12.0!
        Me.line45.LineWeight = 1.0!
        Me.line45.Name = "line45"
        Me.line45.Top = 0.05!
        Me.line45.Width = 0.0!
        Me.line45.X1 = 12.0!
        Me.line45.X2 = 12.0!
        Me.line45.Y1 = 0.05!
        Me.line45.Y2 = 0.35!
        '
        'line46
        '
        Me.line46.Height = 0.3!
        Me.line46.Left = 11.45!
        Me.line46.LineWeight = 1.0!
        Me.line46.Name = "line46"
        Me.line46.Top = 0.05!
        Me.line46.Width = 0.0!
        Me.line46.X1 = 11.45!
        Me.line46.X2 = 11.45!
        Me.line46.Y1 = 0.05!
        Me.line46.Y2 = 0.35!
        '
        'line47
        '
        Me.line47.Height = 0.3!
        Me.line47.Left = 10.55!
        Me.line47.LineWeight = 1.0!
        Me.line47.Name = "line47"
        Me.line47.Top = 0.05!
        Me.line47.Width = 0.0!
        Me.line47.X1 = 10.55!
        Me.line47.X2 = 10.55!
        Me.line47.Y1 = 0.05!
        Me.line47.Y2 = 0.35!
        '
        'line48
        '
        Me.line48.Height = 0.3!
        Me.line48.Left = 10.1!
        Me.line48.LineWeight = 1.0!
        Me.line48.Name = "line48"
        Me.line48.Top = 0.05!
        Me.line48.Width = 0.0!
        Me.line48.X1 = 10.1!
        Me.line48.X2 = 10.1!
        Me.line48.Y1 = 0.05!
        Me.line48.Y2 = 0.35!
        '
        'line49
        '
        Me.line49.Height = 0.3!
        Me.line49.Left = 9.65!
        Me.line49.LineWeight = 1.0!
        Me.line49.Name = "line49"
        Me.line49.Top = 0.05!
        Me.line49.Width = 0.0!
        Me.line49.X1 = 9.65!
        Me.line49.X2 = 9.65!
        Me.line49.Y1 = 0.05!
        Me.line49.Y2 = 0.35!
        '
        'line50
        '
        Me.line50.Height = 0.3!
        Me.line50.Left = 8.45!
        Me.line50.LineWeight = 1.0!
        Me.line50.Name = "line50"
        Me.line50.Top = 0.05!
        Me.line50.Width = 0.0!
        Me.line50.X1 = 8.45!
        Me.line50.X2 = 8.45!
        Me.line50.Y1 = 0.05!
        Me.line50.Y2 = 0.35!
        '
        'line51
        '
        Me.line51.Height = 0.3!
        Me.line51.Left = 8.9!
        Me.line51.LineWeight = 1.0!
        Me.line51.Name = "line51"
        Me.line51.Top = 0.05!
        Me.line51.Width = 0.0!
        Me.line51.X1 = 8.9!
        Me.line51.X2 = 8.9!
        Me.line51.Y1 = 0.05!
        Me.line51.Y2 = 0.35!
        '
        'line52
        '
        Me.line52.Height = 0.3!
        Me.line52.Left = 9.35!
        Me.line52.LineWeight = 1.0!
        Me.line52.Name = "line52"
        Me.line52.Top = 0.05!
        Me.line52.Width = 0.0!
        Me.line52.X1 = 9.35!
        Me.line52.X2 = 9.35!
        Me.line52.Y1 = 0.05!
        Me.line52.Y2 = 0.35!
        '
        'line53
        '
        Me.line53.Height = 0.3!
        Me.line53.Left = 9.6!
        Me.line53.LineWeight = 1.0!
        Me.line53.Name = "line53"
        Me.line53.Top = 0.05!
        Me.line53.Width = 0.0!
        Me.line53.X1 = 9.6!
        Me.line53.X2 = 9.6!
        Me.line53.Y1 = 0.05!
        Me.line53.Y2 = 0.35!
        '
        'line54
        '
        Me.line54.Height = 0.3!
        Me.line54.Left = 8.0!
        Me.line54.LineWeight = 1.0!
        Me.line54.Name = "line54"
        Me.line54.Top = 0.05!
        Me.line54.Width = 0.0!
        Me.line54.X1 = 8.0!
        Me.line54.X2 = 8.0!
        Me.line54.Y1 = 0.05!
        Me.line54.Y2 = 0.35!
        '
        'line55
        '
        Me.line55.Height = 0.3!
        Me.line55.Left = 7.75!
        Me.line55.LineWeight = 1.0!
        Me.line55.Name = "line55"
        Me.line55.Top = 0.05!
        Me.line55.Width = 0.0!
        Me.line55.X1 = 7.75!
        Me.line55.X2 = 7.75!
        Me.line55.Y1 = 0.05!
        Me.line55.Y2 = 0.35!
        '
        'line56
        '
        Me.line56.Height = 0.3!
        Me.line56.Left = 7.5!
        Me.line56.LineWeight = 1.0!
        Me.line56.Name = "line56"
        Me.line56.Top = 0.05!
        Me.line56.Width = 0.0!
        Me.line56.X1 = 7.5!
        Me.line56.X2 = 7.5!
        Me.line56.Y1 = 0.05!
        Me.line56.Y2 = 0.35!
        '
        'line57
        '
        Me.line57.Height = 0.3!
        Me.line57.Left = 7.45!
        Me.line57.LineWeight = 1.0!
        Me.line57.Name = "line57"
        Me.line57.Top = 0.05!
        Me.line57.Width = 0.0!
        Me.line57.X1 = 7.45!
        Me.line57.X2 = 7.45!
        Me.line57.Y1 = 0.05!
        Me.line57.Y2 = 0.35!
        '
        'line58
        '
        Me.line58.Height = 0.3!
        Me.line58.Left = 5.94!
        Me.line58.LineWeight = 1.0!
        Me.line58.Name = "line58"
        Me.line58.Top = 0.05!
        Me.line58.Width = 0.0!
        Me.line58.X1 = 5.94!
        Me.line58.X2 = 5.94!
        Me.line58.Y1 = 0.05!
        Me.line58.Y2 = 0.35!
        '
        'line59
        '
        Me.line59.Height = 0.3!
        Me.line59.Left = 5.89!
        Me.line59.LineWeight = 1.0!
        Me.line59.Name = "line59"
        Me.line59.Top = 0.05!
        Me.line59.Width = 0.0!
        Me.line59.X1 = 5.89!
        Me.line59.X2 = 5.89!
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
        Me.line65.Width = 1.47!
        Me.line65.X1 = 4.42!
        Me.line65.X2 = 5.89!
        Me.line65.Y1 = 0.05!
        Me.line65.Y2 = 0.05!
        '
        'line66
        '
        Me.line66.Height = 0.0!
        Me.line66.Left = 4.42!
        Me.line66.LineWeight = 1.0!
        Me.line66.Name = "line66"
        Me.line66.Top = 0.2!
        Me.line66.Width = 1.47!
        Me.line66.X1 = 4.42!
        Me.line66.X2 = 5.89!
        Me.line66.Y1 = 0.2!
        Me.line66.Y2 = 0.2!
        '
        'line67
        '
        Me.line67.Height = 0.0!
        Me.line67.Left = 4.42!
        Me.line67.LineWeight = 1.0!
        Me.line67.Name = "line67"
        Me.line67.Top = 0.35!
        Me.line67.Width = 1.47!
        Me.line67.X1 = 4.42!
        Me.line67.X2 = 5.89!
        Me.line67.Y1 = 0.35!
        Me.line67.Y2 = 0.35!
        '
        'line68
        '
        Me.line68.Height = 0.0!
        Me.line68.Left = 5.94!
        Me.line68.LineWeight = 1.0!
        Me.line68.Name = "line68"
        Me.line68.Top = 0.05!
        Me.line68.Width = 1.51!
        Me.line68.X1 = 5.94!
        Me.line68.X2 = 7.45!
        Me.line68.Y1 = 0.05!
        Me.line68.Y2 = 0.05!
        '
        'line69
        '
        Me.line69.Height = 0.0!
        Me.line69.Left = 5.94!
        Me.line69.LineWeight = 1.0!
        Me.line69.Name = "line69"
        Me.line69.Top = 0.2!
        Me.line69.Width = 1.51!
        Me.line69.X1 = 5.94!
        Me.line69.X2 = 7.45!
        Me.line69.Y1 = 0.2!
        Me.line69.Y2 = 0.2!
        '
        'line70
        '
        Me.line70.Height = 0.0!
        Me.line70.Left = 5.94!
        Me.line70.LineWeight = 1.0!
        Me.line70.Name = "line70"
        Me.line70.Top = 0.35!
        Me.line70.Width = 1.51!
        Me.line70.X1 = 5.94!
        Me.line70.X2 = 7.45!
        Me.line70.Y1 = 0.35!
        Me.line70.Y2 = 0.35!
        '
        'line71
        '
        Me.line71.Height = 0.0!
        Me.line71.Left = 7.5!
        Me.line71.LineWeight = 1.0!
        Me.line71.Name = "line71"
        Me.line71.Top = 0.05!
        Me.line71.Width = 2.1!
        Me.line71.X1 = 7.5!
        Me.line71.X2 = 9.6!
        Me.line71.Y1 = 0.05!
        Me.line71.Y2 = 0.05!
        '
        'line72
        '
        Me.line72.Height = 0.0!
        Me.line72.Left = 7.5!
        Me.line72.LineWeight = 1.0!
        Me.line72.Name = "line72"
        Me.line72.Top = 0.35!
        Me.line72.Width = 2.1!
        Me.line72.X1 = 7.5!
        Me.line72.X2 = 9.6!
        Me.line72.Y1 = 0.35!
        Me.line72.Y2 = 0.35!
        '
        'line73
        '
        Me.line73.Height = 0.0!
        Me.line73.Left = 9.65!
        Me.line73.LineWeight = 1.0!
        Me.line73.Name = "line73"
        Me.line73.Top = 0.05!
        Me.line73.Width = 2.35!
        Me.line73.X1 = 9.65!
        Me.line73.X2 = 12.0!
        Me.line73.Y1 = 0.05!
        Me.line73.Y2 = 0.05!
        '
        'line74
        '
        Me.line74.Height = 0.0!
        Me.line74.Left = 9.65!
        Me.line74.LineWeight = 1.0!
        Me.line74.Name = "line74"
        Me.line74.Top = 0.35!
        Me.line74.Width = 2.35!
        Me.line74.X1 = 9.65!
        Me.line74.X2 = 12.0!
        Me.line74.Y1 = 0.35!
        Me.line74.Y2 = 0.35!
        '
        'line75
        '
        Me.line75.Height = 0.0!
        Me.line75.Left = 12.05!
        Me.line75.LineWeight = 1.0!
        Me.line75.Name = "line75"
        Me.line75.Top = 0.05!
        Me.line75.Width = 0.9499998!
        Me.line75.X1 = 12.05!
        Me.line75.X2 = 13.0!
        Me.line75.Y1 = 0.05!
        Me.line75.Y2 = 0.05!
        '
        'line76
        '
        Me.line76.Height = 0.0!
        Me.line76.Left = 12.05!
        Me.line76.LineWeight = 1.0!
        Me.line76.Name = "line76"
        Me.line76.Top = 0.35!
        Me.line76.Width = 0.9499998!
        Me.line76.X1 = 12.05!
        Me.line76.X2 = 13.0!
        Me.line76.Y1 = 0.35!
        Me.line76.Y2 = 0.35!
        '
        'line77
        '
        Me.line77.Height = 0.15!
        Me.line77.Left = 4.68!
        Me.line77.LineWeight = 1.0!
        Me.line77.Name = "line77"
        Me.line77.Top = 0.05!
        Me.line77.Width = 0.0!
        Me.line77.X1 = 4.68!
        Me.line77.X2 = 4.68!
        Me.line77.Y1 = 0.05!
        Me.line77.Y2 = 0.2!
        '
        'line78
        '
        Me.line78.Height = 0.15!
        Me.line78.Left = 5.44!
        Me.line78.LineWeight = 1.0!
        Me.line78.Name = "line78"
        Me.line78.Top = 0.05!
        Me.line78.Width = 0.0!
        Me.line78.X1 = 5.44!
        Me.line78.X2 = 5.44!
        Me.line78.Y1 = 0.05!
        Me.line78.Y2 = 0.2!
        '
        'line79
        '
        Me.line79.Height = 0.15!
        Me.line79.Left = 4.78!
        Me.line79.LineWeight = 1.0!
        Me.line79.Name = "line79"
        Me.line79.Top = 0.2!
        Me.line79.Width = 0.0!
        Me.line79.X1 = 4.78!
        Me.line79.X2 = 4.78!
        Me.line79.Y1 = 0.2!
        Me.line79.Y2 = 0.35!
        '
        'line80
        '
        Me.line80.Height = 0.15!
        Me.line80.Left = 5.14!
        Me.line80.LineWeight = 1.0!
        Me.line80.Name = "line80"
        Me.line80.Top = 0.2!
        Me.line80.Width = 0.0!
        Me.line80.X1 = 5.14!
        Me.line80.X2 = 5.14!
        Me.line80.Y1 = 0.2!
        Me.line80.Y2 = 0.35!
        '
        'line81
        '
        Me.line81.Height = 0.15!
        Me.line81.Left = 5.52!
        Me.line81.LineWeight = 1.0!
        Me.line81.Name = "line81"
        Me.line81.Top = 0.2!
        Me.line81.Width = 0.0!
        Me.line81.X1 = 5.52!
        Me.line81.X2 = 5.52!
        Me.line81.Y1 = 0.2!
        Me.line81.Y2 = 0.35!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtSort, Me.lblReportDate, Me.reportInfo1, Me.txtDisclaimer})
        Me.PageFooter1.Height = 0.50625!
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
        Me.txtSort.Width = 13.0!
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
        Me.reportInfo1.Left = 11.0!
        Me.reportInfo1.Name = "reportInfo1"
        Me.reportInfo1.Style = "font-size: 7pt; font-style: italic; text-align: right; vertical-align: middle"
        Me.reportInfo1.Top = 0.3!
        Me.reportInfo1.Width = 2.0!
        '
        'txtDisclaimer
        '
        Me.txtDisclaimer.Height = 0.15!
        Me.txtDisclaimer.HyperLink = Nothing
        Me.txtDisclaimer.Left = 0.0!
        Me.txtDisclaimer.Name = "txtDisclaimer"
        Me.txtDisclaimer.Style = "font-size: 7pt; font-style: italic; text-align: center; vertical-align: middle"
        Me.txtDisclaimer.Text = "Disclaimer"
        Me.txtDisclaimer.Top = 0.15!
        Me.txtDisclaimer.Width = 13.0!
        '
        'rptFireCOPESummary
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.25!
        Me.PageSettings.Margins.Left = 0.5!
        Me.PageSettings.Margins.Right = 0.5!
        Me.PageSettings.Margins.Top = 0.25!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 14.0!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Legal
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 13.0!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Calibri; font-style: normal; text-decoration: none; font-weight: nor" & _
            "mal; font-size: 10pt; color: Black", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
            "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.lblProtection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPML, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblClientName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label3, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.lblYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPercFR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPercNC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRoofConstructionCombustible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblClassII, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblStories, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblConstruction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblOccupancy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMajorGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSpecificGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblWaterSupply, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSurv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAPL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMFL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblClientLocNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFacility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblWindstorm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEarthquakeRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPercAS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStories, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDivision2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFileNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSurveyDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSTProv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTIV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPercFR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPercNC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRoofConstructionCombustible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClassII, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSpecificGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMajorGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPercASN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWaterSupply, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSurv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSpecHaz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHERating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExternalFire, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFloodRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWindstormRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAPL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPML, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMFL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFloodZone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWindstormZone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFacility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientLocNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEarthquake, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSort, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblReportDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reportInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisclaimer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
#End Region

#Region "New Report"
    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub
#End Region

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private Sub rptFireCOPESummary_FetchData(ByVal sender As Object, ByVal eArgs As FetchEventArgs) Handles Me.FetchData
        Dim zRatingControls() As ARControl = {txtHERating}
        Dim zTextControls() As ARControl = {txtWaterSupply, txtSurv, txtSpecHaz, txtExternalFire}
        Dim zTextRatingControls() As ARControl = {txtEarthquakeRating, txtFloodRating, txtWindstormRating}
        Dim zQualifierControls() As ARControl = {txtEarthquake, txtFloodZone, txtWindstormZone}
        UtilReport.ActiveReport.SetItemBackColorByRatingHE(Me, zRatingControls, rptProperties)
        UtilReport.ActiveReport.SetItemBackColorByText(Me, zTextControls, rptProperties)
        UtilReport.ActiveReport.SetItemBackColorByText(Me, zTextRatingControls, rptProperties)
        UtilReport.ActiveReport.SetItemBackColorByText(Me, zQualifierControls, zTextRatingControls, rptProperties)

        lblTIVGrid.Text = "TIV " & rptProperties.Currency.colFldCode & vbLf & "(millions)"
        lblAPL.Text = "APL" & vbLf & rptProperties.Currency.colFldCode
        lblPML.Text = "PML" & vbLf & rptProperties.Currency.colFldCode
        lblMFL.Text = "MFL" & vbLf & rptProperties.Currency.colFldCode

        'NEED TO FIX TO SET MEASUREMENT UNIT
        lblArea.Text = "Area (" & UtilReport.GetMeasurementAbbreviation(TblMetaUnitMeasurement.Measurements.Feet, rptProperties) & ")"
        lblWindstorm.Text = "Windstorm" & vbLf & UtilReport.GetMeasurementAbbreviation(TblMetaUnitMeasurement.Measurements.MilesPerHour, rptProperties)
    End Sub

    Private Sub rptFireCOPESummary_ReportStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportStart
        lblClientName.Text = rptProperties.ClientName
        lblReportDate.Text = Now

        'Hide PML when PML() = true
        If UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.F) Then
            'If AppSession.PML = False Then
            Me.lblAPL.Width = 0.48!
            Me.txtAPL.Width = 0.48!
            Me.line32.Visible = False
            Me.line43.Visible = False
            Me.lblPML.Visible = False
            Me.txtPML.Visible = False
            Me.line31.Left = 12.53!
            Me.line42.Left = 12.53!
            Me.lblMFL.Left = 12.53!
            Me.txtMFL.Left = 12.53!
            Me.lblMFL.Width = 0.48!
            Me.txtMFL.Width = 0.48!
        End If
    End Sub

    Private Sub rptFireCOPESummary_PageStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.PageStart
        UtilReport.ActiveReport.SetFilter(Me, rptProperties)
        UtilReport.ActiveReport.SetSort(Me, rptProperties)
        UtilReport.ActiveReport.SetDisclaimer(Me, rptProperties)
    End Sub

    Private Sub rptFireCOPESummary_ReportEnd(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportEnd
        DisposeParameters()
    End Sub

    Private Sub DisposeParameters()
        DataSource = Nothing
    End Sub

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties

    Private Sub Detail1_Format(sender As Object, e As EventArgs) Handles Detail1.Format
        If Not IsNothing(txtAPL.Value) AndAlso Not IsDBNull(txtAPL.Value) Then txtAPL.Text = FormatNumber(txtAPL.Value / 1000000, 2)
        If Not IsNothing(txtPML.Value) AndAlso Not IsDBNull(txtPML.Value) Then txtPML.Text = FormatNumber(txtPML.Value / 1000000, 2)
        If Not IsNothing(txtMFL.Value) AndAlso Not IsDBNull(txtMFL.Value) Then txtMFL.Text = FormatNumber(txtMFL.Value / 1000000, 2)
    End Sub
End Class
