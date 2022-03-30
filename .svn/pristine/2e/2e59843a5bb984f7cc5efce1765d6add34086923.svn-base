Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports

Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing

Public Class rptNatHazFloodAssessmentExpBldgStructOther
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
    Private WithEvents lblReport As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblLocationInformation As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFileNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblDivision2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblInspectionDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCity As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblAddress As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblSTProv As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCountry As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblTIVGrid As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblExposures As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lbl100YrFlood As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblBuildingStructure As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lbl500YrFlood As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblStormSurge As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblSurfWater As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFixedProtection As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblAEBG As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblContConst As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblOther As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblOtherBldgStruc As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblPrepRespPlan As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblSiteAccess As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblUtilities As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblYardStge As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblOtherFloodExp As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtFileNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtInspectionDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCity As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSTProv As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCountry As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtTIV As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtDivision2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtAddress As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txt100YrFlood As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txt500YrFlood As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtStormSurge As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSurfWater As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFixedProtection As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtAEBG As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtContConst As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtOtherBldgStruc As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtPrepRespPlan As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSiteAccess As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtUtilities As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtYardStge As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtOtherFloodExp As GrapeCity.ActiveReports.SectionReportModel.TextBox
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
    Private WithEvents line16 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line17 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line18 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line19 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line20 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line21 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line23 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line24 As GrapeCity.ActiveReports.SectionReportModel.Line
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
    Private WithEvents line42 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line43 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line45 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line46 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line47 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line49 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line50 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line51 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line52 As GrapeCity.ActiveReports.SectionReportModel.Line
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
    Private WithEvents line67 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line68 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line70 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line71 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line72 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line6 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents reportInfo1 As GrapeCity.ActiveReports.SectionReportModel.ReportInfo
    Private WithEvents txtDisclaimer As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents PageFooter1 As GrapeCity.ActiveReports.SectionReportModel.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptNatHazFloodAssessmentExpBldgStructOther))
        Me.PageHeader1 = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.lblBuildingStructure = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblOtherFloodExp = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblOther = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblClientName = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblReport = New GrapeCity.ActiveReports.SectionReportModel.Label()
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
        Me.lblExposures = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lbl100YrFlood = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lbl500YrFlood = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblStormSurge = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSurfWater = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFixedProtection = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblContConst = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblOtherBldgStruc = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPrepRespPlan = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSiteAccess = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblYardStge = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFilters = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtFilters = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblClientLocNo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFacility = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblAEBG = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblUtilities = New GrapeCity.ActiveReports.SectionReportModel.Label()
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
        Me.line16 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line17 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line18 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line19 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line20 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line21 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line23 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line24 = New GrapeCity.ActiveReports.SectionReportModel.Line()
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
        Me.line6 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Detail1 = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.txt500YrFlood = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtAddress = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtDivision2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFileNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtInspectionDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCity = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSTProv = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCountry = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtTIV = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt100YrFlood = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtStormSurge = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSurfWater = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFixedProtection = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtAEBG = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtContConst = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtOtherBldgStruc = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSiteAccess = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtUtilities = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtYardStge = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtOtherFloodExp = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFacility = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtClientLocNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPrepRespPlan = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.line42 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line43 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line45 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line46 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line47 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line49 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line50 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line51 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line52 = New GrapeCity.ActiveReports.SectionReportModel.Line()
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
        Me.line67 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line71 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line72 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line68 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line70 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.PageFooter1 = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.txtSort = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblReportDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.reportInfo1 = New GrapeCity.ActiveReports.SectionReportModel.ReportInfo()
        Me.txtDisclaimer = New GrapeCity.ActiveReports.SectionReportModel.Label()
        CType(Me.lblBuildingStructure, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblOtherFloodExp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblOther, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblClientName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblReport, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.lblExposures, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl100YrFlood, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl500YrFlood, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblStormSurge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSurfWater, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFixedProtection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblContConst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblOtherBldgStruc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPrepRespPlan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSiteAccess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblYardStge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblClientLocNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFacility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAEBG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblUtilities, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt500YrFlood, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDivision2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFileNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInspectionDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSTProv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTIV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt100YrFlood, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStormSurge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSurfWater, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFixedProtection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAEBG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContConst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOtherBldgStruc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSiteAccess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUtilities, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtYardStge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOtherFloodExp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFacility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientLocNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrepRespPlan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblReportDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisclaimer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.CanShrink = True
        Me.PageHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblBuildingStructure, Me.lblOtherFloodExp, Me.lblOther, Me.lblClientName, Me.lblReport, Me.lblLocationInformation, Me.picGRCLogo, Me.lblFileNo, Me.lblDivision2, Me.lblInspectionDate, Me.lblCity, Me.lblAddress, Me.lblSTProv, Me.lblCountry, Me.lblTIVGrid, Me.lblExposures, Me.lbl100YrFlood, Me.lbl500YrFlood, Me.lblStormSurge, Me.lblSurfWater, Me.lblFixedProtection, Me.lblContConst, Me.lblOtherBldgStruc, Me.lblPrepRespPlan, Me.lblSiteAccess, Me.lblYardStge, Me.lblFilters, Me.txtFilters, Me.lblClientLocNo, Me.lblFacility, Me.lblAEBG, Me.lblUtilities, Me.line1, Me.line2, Me.line3, Me.line4, Me.line5, Me.line7, Me.line8, Me.line9, Me.line10, Me.line11, Me.line16, Me.line17, Me.line18, Me.line19, Me.line20, Me.line21, Me.line23, Me.line24, Me.line31, Me.line32, Me.line33, Me.line34, Me.line35, Me.line36, Me.line37, Me.line38, Me.line39, Me.line40, Me.line6})
        Me.PageHeader1.Height = 1.5!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'lblBuildingStructure
        '
        Me.lblBuildingStructure.Height = 0.15!
        Me.lblBuildingStructure.HyperLink = Nothing
        Me.lblBuildingStructure.Left = 7.51!
        Me.lblBuildingStructure.Name = "lblBuildingStructure"
        Me.lblBuildingStructure.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblBuildingStructure.Text = "Building Structure"
        Me.lblBuildingStructure.Top = 1.05!
        Me.lblBuildingStructure.Width = 2.52!
        '
        'lblOtherFloodExp
        '
        Me.lblOtherFloodExp.Height = 0.3!
        Me.lblOtherFloodExp.HyperLink = Nothing
        Me.lblOtherFloodExp.Left = 12.5!
        Me.lblOtherFloodExp.Name = "lblOtherFloodExp"
        Me.lblOtherFloodExp.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblOtherFloodExp.Text = "Other Exposures"
        Me.lblOtherFloodExp.Top = 1.188!
        Me.lblOtherFloodExp.Width = 0.5!
        '
        'lblOther
        '
        Me.lblOther.Height = 0.15!
        Me.lblOther.HyperLink = Nothing
        Me.lblOther.Left = 10.11!
        Me.lblOther.Name = "lblOther"
        Me.lblOther.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblOther.Text = "Other"
        Me.lblOther.Top = 1.063!
        Me.lblOther.Width = 2.89!
        '
        'lblClientName
        '
        Me.lblClientName.Height = 0.25!
        Me.lblClientName.HyperLink = Nothing
        Me.lblClientName.Left = 5.95!
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Style = "color: #C6D1DE; font-size: 16pt; font-style: italic; font-weight: bold; text-alig" & _
    "n: right; vertical-align: middle"
        Me.lblClientName.Text = "Company Name"
        Me.lblClientName.Top = 0.05!
        Me.lblClientName.Width = 7.050001!
        '
        'lblReport
        '
        Me.lblReport.Height = 0.25!
        Me.lblReport.HyperLink = Nothing
        Me.lblReport.Left = 5.95!
        Me.lblReport.Name = "lblReport"
        Me.lblReport.Style = "font-size: 12pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblReport.Text = "Natural Hazards - Flood Assessment - Exposures/Bldg. Structure/Other"
        Me.lblReport.Top = 0.35!
        Me.lblReport.Width = 7.050001!
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
        Me.lblInspectionDate.Left = 0.5!
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
        Me.lblAddress.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
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
        'lblExposures
        '
        Me.lblExposures.Height = 0.15!
        Me.lblExposures.HyperLink = Nothing
        Me.lblExposures.Left = 4.42!
        Me.lblExposures.Name = "lblExposures"
        Me.lblExposures.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblExposures.Text = "Exposures"
        Me.lblExposures.Top = 1.05!
        Me.lblExposures.Width = 3.04!
        '
        'lbl100YrFlood
        '
        Me.lbl100YrFlood.Height = 0.3!
        Me.lbl100YrFlood.HyperLink = Nothing
        Me.lbl100YrFlood.Left = 4.42!
        Me.lbl100YrFlood.Name = "lbl100YrFlood"
        Me.lbl100YrFlood.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lbl100YrFlood.Text = "100 Yr. Flood Exposure"
        Me.lbl100YrFlood.Top = 1.2!
        Me.lbl100YrFlood.Width = 0.63!
        '
        'lbl500YrFlood
        '
        Me.lbl500YrFlood.Height = 0.3!
        Me.lbl500YrFlood.HyperLink = Nothing
        Me.lbl500YrFlood.Left = 5.05!
        Me.lbl500YrFlood.Name = "lbl500YrFlood"
        Me.lbl500YrFlood.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lbl500YrFlood.Text = "500 Yr. Flood Exposure"
        Me.lbl500YrFlood.Top = 1.2!
        Me.lbl500YrFlood.Width = 0.63!
        '
        'lblStormSurge
        '
        Me.lblStormSurge.Height = 0.3!
        Me.lblStormSurge.HyperLink = Nothing
        Me.lblStormSurge.Left = 5.68!
        Me.lblStormSurge.Name = "lblStormSurge"
        Me.lblStormSurge.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblStormSurge.Text = "Storm Surge Exposure"
        Me.lblStormSurge.Top = 1.2!
        Me.lblStormSurge.Width = 0.63!
        '
        'lblSurfWater
        '
        Me.lblSurfWater.Height = 0.3!
        Me.lblSurfWater.HyperLink = Nothing
        Me.lblSurfWater.Left = 6.31!
        Me.lblSurfWater.Name = "lblSurfWater"
        Me.lblSurfWater.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblSurfWater.Text = "Surface Water Exposure"
        Me.lblSurfWater.Top = 1.2!
        Me.lblSurfWater.Width = 0.65!
        '
        'lblFixedProtection
        '
        Me.lblFixedProtection.Height = 0.3!
        Me.lblFixedProtection.HyperLink = Nothing
        Me.lblFixedProtection.Left = 6.96!
        Me.lblFixedProtection.Name = "lblFixedProtection"
        Me.lblFixedProtection.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblFixedProtection.Text = "Fixed Protection"
        Me.lblFixedProtection.Top = 1.2!
        Me.lblFixedProtection.Width = 0.5!
        '
        'lblContConst
        '
        Me.lblContConst.Height = 0.3!
        Me.lblContConst.HyperLink = Nothing
        Me.lblContConst.Left = 8.14!
        Me.lblContConst.Name = "lblContConst"
        Me.lblContConst.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblContConst.Text = "Susceptible Contents/Construction"
        Me.lblContConst.Top = 1.2!
        Me.lblContConst.Width = 1.0!
        '
        'lblOtherBldgStruc
        '
        Me.lblOtherBldgStruc.Height = 0.3!
        Me.lblOtherBldgStruc.HyperLink = Nothing
        Me.lblOtherBldgStruc.Left = 9.14!
        Me.lblOtherBldgStruc.Name = "lblOtherBldgStruc"
        Me.lblOtherBldgStruc.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblOtherBldgStruc.Text = "Other Bldg/Structure Exposures"
        Me.lblOtherBldgStruc.Top = 1.2!
        Me.lblOtherBldgStruc.Width = 0.92!
        '
        'lblPrepRespPlan
        '
        Me.lblPrepRespPlan.Height = 0.3!
        Me.lblPrepRespPlan.HyperLink = Nothing
        Me.lblPrepRespPlan.Left = 10.11!
        Me.lblPrepRespPlan.Name = "lblPrepRespPlan"
        Me.lblPrepRespPlan.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblPrepRespPlan.Text = "Preparation/ Response Planning"
        Me.lblPrepRespPlan.Top = 1.2!
        Me.lblPrepRespPlan.Width = 0.89!
        '
        'lblSiteAccess
        '
        Me.lblSiteAccess.Height = 0.3!
        Me.lblSiteAccess.HyperLink = Nothing
        Me.lblSiteAccess.Left = 11.0!
        Me.lblSiteAccess.Name = "lblSiteAccess"
        Me.lblSiteAccess.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblSiteAccess.Text = "Site Access"
        Me.lblSiteAccess.Top = 1.2!
        Me.lblSiteAccess.Width = 0.5!
        '
        'lblYardStge
        '
        Me.lblYardStge.Height = 0.3!
        Me.lblYardStge.HyperLink = Nothing
        Me.lblYardStge.Left = 12.0!
        Me.lblYardStge.Name = "lblYardStge"
        Me.lblYardStge.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblYardStge.Text = "Yard Storage"
        Me.lblYardStge.Top = 1.2!
        Me.lblYardStge.Width = 0.5!
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
        'lblAEBG
        '
        Me.lblAEBG.Height = 0.3!
        Me.lblAEBG.HyperLink = Nothing
        Me.lblAEBG.Left = 7.51!
        Me.lblAEBG.Name = "lblAEBG"
        Me.lblAEBG.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblAEBG.Text = "Areas/Equip. Below Grade"
        Me.lblAEBG.Top = 1.2!
        Me.lblAEBG.Width = 0.63!
        '
        'lblUtilities
        '
        Me.lblUtilities.Height = 0.3!
        Me.lblUtilities.HyperLink = Nothing
        Me.lblUtilities.Left = 11.5!
        Me.lblUtilities.Name = "lblUtilities"
        Me.lblUtilities.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblUtilities.Text = "Utilities"
        Me.lblUtilities.Top = 1.2!
        Me.lblUtilities.Width = 0.5!
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
        Me.line7.Height = 0.3!
        Me.line7.Left = 5.05!
        Me.line7.LineWeight = 1.0!
        Me.line7.Name = "line7"
        Me.line7.Top = 1.2!
        Me.line7.Width = 0.0!
        Me.line7.X1 = 5.05!
        Me.line7.X2 = 5.05!
        Me.line7.Y1 = 1.2!
        Me.line7.Y2 = 1.5!
        '
        'line8
        '
        Me.line8.Height = 0.3!
        Me.line8.Left = 5.68!
        Me.line8.LineWeight = 1.0!
        Me.line8.Name = "line8"
        Me.line8.Top = 1.2!
        Me.line8.Width = 0.0!
        Me.line8.X1 = 5.68!
        Me.line8.X2 = 5.68!
        Me.line8.Y1 = 1.2!
        Me.line8.Y2 = 1.5!
        '
        'line9
        '
        Me.line9.Height = 0.3!
        Me.line9.Left = 6.96!
        Me.line9.LineWeight = 1.0!
        Me.line9.Name = "line9"
        Me.line9.Top = 1.2!
        Me.line9.Width = 0.0!
        Me.line9.X1 = 6.96!
        Me.line9.X2 = 6.96!
        Me.line9.Y1 = 1.2!
        Me.line9.Y2 = 1.5!
        '
        'line10
        '
        Me.line10.Height = 0.3!
        Me.line10.Left = 6.31!
        Me.line10.LineWeight = 1.0!
        Me.line10.Name = "line10"
        Me.line10.Top = 1.2!
        Me.line10.Width = 0.0!
        Me.line10.X1 = 6.31!
        Me.line10.X2 = 6.31!
        Me.line10.Y1 = 1.2!
        Me.line10.Y2 = 1.5!
        '
        'line11
        '
        Me.line11.Height = 0.45!
        Me.line11.Left = 13.0!
        Me.line11.LineWeight = 1.0!
        Me.line11.Name = "line11"
        Me.line11.Top = 1.05!
        Me.line11.Width = 0.0!
        Me.line11.X1 = 13.0!
        Me.line11.X2 = 13.0!
        Me.line11.Y1 = 1.05!
        Me.line11.Y2 = 1.5!
        '
        'line16
        '
        Me.line16.Height = 0.0!
        Me.line16.Left = 4.42!
        Me.line16.LineWeight = 1.0!
        Me.line16.Name = "line16"
        Me.line16.Top = 1.5!
        Me.line16.Width = 3.04!
        Me.line16.X1 = 4.42!
        Me.line16.X2 = 7.46!
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
        Me.line17.Width = 3.04!
        Me.line17.X1 = 4.42!
        Me.line17.X2 = 7.46!
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
        Me.line18.Width = 3.04!
        Me.line18.X1 = 4.42!
        Me.line18.X2 = 7.46!
        Me.line18.Y1 = 1.05!
        Me.line18.Y2 = 1.05!
        '
        'line19
        '
        Me.line19.Height = 0.0!
        Me.line19.Left = 7.51!
        Me.line19.LineWeight = 1.0!
        Me.line19.Name = "line19"
        Me.line19.Top = 1.5!
        Me.line19.Width = 2.55!
        Me.line19.X1 = 7.51!
        Me.line19.X2 = 10.06!
        Me.line19.Y1 = 1.5!
        Me.line19.Y2 = 1.5!
        '
        'line20
        '
        Me.line20.Height = 0.0!
        Me.line20.Left = 7.51!
        Me.line20.LineWeight = 1.0!
        Me.line20.Name = "line20"
        Me.line20.Top = 1.2!
        Me.line20.Width = 2.55!
        Me.line20.X1 = 7.51!
        Me.line20.X2 = 10.06!
        Me.line20.Y1 = 1.2!
        Me.line20.Y2 = 1.2!
        '
        'line21
        '
        Me.line21.Height = 0.0!
        Me.line21.Left = 7.51!
        Me.line21.LineWeight = 1.0!
        Me.line21.Name = "line21"
        Me.line21.Top = 1.05!
        Me.line21.Width = 2.55!
        Me.line21.X1 = 7.51!
        Me.line21.X2 = 10.06!
        Me.line21.Y1 = 1.05!
        Me.line21.Y2 = 1.05!
        '
        'line23
        '
        Me.line23.Height = 0.0!
        Me.line23.Left = 10.11!
        Me.line23.LineWeight = 1.0!
        Me.line23.Name = "line23"
        Me.line23.Top = 1.2!
        Me.line23.Width = 2.89!
        Me.line23.X1 = 10.11!
        Me.line23.X2 = 13.0!
        Me.line23.Y1 = 1.2!
        Me.line23.Y2 = 1.2!
        '
        'line24
        '
        Me.line24.Height = 0.0!
        Me.line24.Left = 10.11!
        Me.line24.LineWeight = 1.0!
        Me.line24.Name = "line24"
        Me.line24.Top = 1.05!
        Me.line24.Width = 2.89!
        Me.line24.X1 = 10.11!
        Me.line24.X2 = 13.0!
        Me.line24.Y1 = 1.05!
        Me.line24.Y2 = 1.05!
        '
        'line31
        '
        Me.line31.Height = 0.3!
        Me.line31.Left = 12.0!
        Me.line31.LineWeight = 1.0!
        Me.line31.Name = "line31"
        Me.line31.Top = 1.2!
        Me.line31.Width = 0.0!
        Me.line31.X1 = 12.0!
        Me.line31.X2 = 12.0!
        Me.line31.Y1 = 1.2!
        Me.line31.Y2 = 1.5!
        '
        'line32
        '
        Me.line32.Height = 0.3!
        Me.line32.Left = 12.5!
        Me.line32.LineWeight = 1.0!
        Me.line32.Name = "line32"
        Me.line32.Top = 1.2!
        Me.line32.Width = 0.0!
        Me.line32.X1 = 12.5!
        Me.line32.X2 = 12.5!
        Me.line32.Y1 = 1.2!
        Me.line32.Y2 = 1.5!
        '
        'line33
        '
        Me.line33.Height = 0.3!
        Me.line33.Left = 11.5!
        Me.line33.LineWeight = 1.0!
        Me.line33.Name = "line33"
        Me.line33.Top = 1.2!
        Me.line33.Width = 0.0!
        Me.line33.X1 = 11.5!
        Me.line33.X2 = 11.5!
        Me.line33.Y1 = 1.2!
        Me.line33.Y2 = 1.5!
        '
        'line34
        '
        Me.line34.Height = 0.3!
        Me.line34.Left = 11.0!
        Me.line34.LineWeight = 1.0!
        Me.line34.Name = "line34"
        Me.line34.Top = 1.2!
        Me.line34.Width = 0.0!
        Me.line34.X1 = 11.0!
        Me.line34.X2 = 11.0!
        Me.line34.Y1 = 1.2!
        Me.line34.Y2 = 1.5!
        '
        'line35
        '
        Me.line35.Height = 0.45!
        Me.line35.Left = 10.11!
        Me.line35.LineWeight = 1.0!
        Me.line35.Name = "line35"
        Me.line35.Top = 1.05!
        Me.line35.Width = 0.0!
        Me.line35.X1 = 10.11!
        Me.line35.X2 = 10.11!
        Me.line35.Y1 = 1.05!
        Me.line35.Y2 = 1.5!
        '
        'line36
        '
        Me.line36.Height = 0.45!
        Me.line36.Left = 10.06!
        Me.line36.LineWeight = 1.0!
        Me.line36.Name = "line36"
        Me.line36.Top = 1.05!
        Me.line36.Width = 0.0!
        Me.line36.X1 = 10.06!
        Me.line36.X2 = 10.06!
        Me.line36.Y1 = 1.05!
        Me.line36.Y2 = 1.5!
        '
        'line37
        '
        Me.line37.Height = 0.3!
        Me.line37.Left = 9.14!
        Me.line37.LineWeight = 1.0!
        Me.line37.Name = "line37"
        Me.line37.Top = 1.2!
        Me.line37.Width = 0.0!
        Me.line37.X1 = 9.14!
        Me.line37.X2 = 9.14!
        Me.line37.Y1 = 1.2!
        Me.line37.Y2 = 1.5!
        '
        'line38
        '
        Me.line38.Height = 0.3!
        Me.line38.Left = 8.14!
        Me.line38.LineWeight = 1.0!
        Me.line38.Name = "line38"
        Me.line38.Top = 1.2!
        Me.line38.Width = 0.0!
        Me.line38.X1 = 8.14!
        Me.line38.X2 = 8.14!
        Me.line38.Y1 = 1.2!
        Me.line38.Y2 = 1.5!
        '
        'line39
        '
        Me.line39.Height = 0.45!
        Me.line39.Left = 7.51!
        Me.line39.LineWeight = 1.0!
        Me.line39.Name = "line39"
        Me.line39.Top = 1.05!
        Me.line39.Width = 0.0!
        Me.line39.X1 = 7.51!
        Me.line39.X2 = 7.51!
        Me.line39.Y1 = 1.05!
        Me.line39.Y2 = 1.5!
        '
        'line40
        '
        Me.line40.Height = 0.45!
        Me.line40.Left = 7.46!
        Me.line40.LineWeight = 1.0!
        Me.line40.Name = "line40"
        Me.line40.Top = 1.05!
        Me.line40.Width = 0.0!
        Me.line40.X1 = 7.46!
        Me.line40.X2 = 7.46!
        Me.line40.Y1 = 1.05!
        Me.line40.Y2 = 1.5!
        '
        'line6
        '
        Me.line6.Height = 0.0!
        Me.line6.Left = 10.11!
        Me.line6.LineWeight = 1.0!
        Me.line6.Name = "line6"
        Me.line6.Top = 1.5!
        Me.line6.Width = 2.89!
        Me.line6.X1 = 10.11!
        Me.line6.X2 = 13.0!
        Me.line6.Y1 = 1.5!
        Me.line6.Y2 = 1.5!
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txt500YrFlood, Me.txtAddress, Me.txtDivision2, Me.txtFileNo, Me.txtInspectionDate, Me.txtCity, Me.txtSTProv, Me.txtCountry, Me.txtTIV, Me.txt100YrFlood, Me.txtStormSurge, Me.txtSurfWater, Me.txtFixedProtection, Me.txtAEBG, Me.txtContConst, Me.txtOtherBldgStruc, Me.txtSiteAccess, Me.txtUtilities, Me.txtYardStge, Me.txtOtherFloodExp, Me.txtFacility, Me.txtClientLocNo, Me.txtPrepRespPlan, Me.line42, Me.line43, Me.line45, Me.line46, Me.line47, Me.line49, Me.line50, Me.line51, Me.line52, Me.line54, Me.line55, Me.line56, Me.line57, Me.line58, Me.line59, Me.line60, Me.line61, Me.line62, Me.line63, Me.line64, Me.line65, Me.line67, Me.line71, Me.line72, Me.line68, Me.line70})
        Me.Detail1.Height = 0.35!
        Me.Detail1.KeepTogether = True
        Me.Detail1.Name = "Detail1"
        '
        'txt500YrFlood
        '
        Me.txt500YrFlood.DataField = "FiveHundredYrFlood"
        Me.txt500YrFlood.Height = 0.3!
        Me.txt500YrFlood.Left = 5.05!
        Me.txt500YrFlood.Name = "txt500YrFlood"
        Me.txt500YrFlood.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txt500YrFlood.Text = "500 Yr. Flood Exposure"
        Me.txt500YrFlood.Top = 0.05!
        Me.txt500YrFlood.Width = 0.63!
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
        'txtInspectionDate
        '
        Me.txtInspectionDate.CanGrow = False
        Me.txtInspectionDate.DataField = "SurveyDateString"
        Me.txtInspectionDate.Height = 0.15!
        Me.txtInspectionDate.Left = 0.5!
        Me.txtInspectionDate.MultiLine = False
        Me.txtInspectionDate.Name = "txtInspectionDate"
        Me.txtInspectionDate.Style = "background-color: White; font-size: 7pt; vertical-align: middle"
        Me.txtInspectionDate.Text = "Insp. Date"
        Me.txtInspectionDate.Top = 0.05!
        Me.txtInspectionDate.Width = 0.58!
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
        'txt100YrFlood
        '
        Me.txt100YrFlood.DataField = "OneHundredYrFlood"
        Me.txt100YrFlood.Height = 0.3!
        Me.txt100YrFlood.Left = 4.42!
        Me.txt100YrFlood.Name = "txt100YrFlood"
        Me.txt100YrFlood.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txt100YrFlood.Text = "100 Yr. Flood Exposure"
        Me.txt100YrFlood.Top = 0.05!
        Me.txt100YrFlood.Width = 0.63!
        '
        'txtStormSurge
        '
        Me.txtStormSurge.DataField = "StormSurge"
        Me.txtStormSurge.Height = 0.3!
        Me.txtStormSurge.Left = 5.68!
        Me.txtStormSurge.Name = "txtStormSurge"
        Me.txtStormSurge.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtStormSurge.Text = "Storm Surge Exposure"
        Me.txtStormSurge.Top = 0.05!
        Me.txtStormSurge.Width = 0.63!
        '
        'txtSurfWater
        '
        Me.txtSurfWater.DataField = "SurfWater"
        Me.txtSurfWater.Height = 0.3!
        Me.txtSurfWater.Left = 6.31!
        Me.txtSurfWater.Name = "txtSurfWater"
        Me.txtSurfWater.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtSurfWater.Text = "Surface Water Exposure"
        Me.txtSurfWater.Top = 0.05!
        Me.txtSurfWater.Width = 0.65!
        '
        'txtFixedProtection
        '
        Me.txtFixedProtection.DataField = "FixedProtection"
        Me.txtFixedProtection.Height = 0.3!
        Me.txtFixedProtection.Left = 6.96!
        Me.txtFixedProtection.Name = "txtFixedProtection"
        Me.txtFixedProtection.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtFixedProtection.Text = "Fixed Protection"
        Me.txtFixedProtection.Top = 0.05!
        Me.txtFixedProtection.Width = 0.5!
        '
        'txtAEBG
        '
        Me.txtAEBG.DataField = "AEBG"
        Me.txtAEBG.Height = 0.3!
        Me.txtAEBG.Left = 7.51!
        Me.txtAEBG.Name = "txtAEBG"
        Me.txtAEBG.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtAEBG.Text = "Areas/Equip. Below Grade"
        Me.txtAEBG.Top = 0.05!
        Me.txtAEBG.Width = 0.63!
        '
        'txtContConst
        '
        Me.txtContConst.DataField = "ContConst"
        Me.txtContConst.Height = 0.3!
        Me.txtContConst.Left = 8.14!
        Me.txtContConst.Name = "txtContConst"
        Me.txtContConst.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtContConst.Text = "Susceptible Contents/Construction"
        Me.txtContConst.Top = 0.05!
        Me.txtContConst.Width = 1.0!
        '
        'txtOtherBldgStruc
        '
        Me.txtOtherBldgStruc.DataField = "OtherBldgStruc"
        Me.txtOtherBldgStruc.Height = 0.3!
        Me.txtOtherBldgStruc.Left = 9.14!
        Me.txtOtherBldgStruc.Name = "txtOtherBldgStruc"
        Me.txtOtherBldgStruc.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtOtherBldgStruc.Text = "Other Bldg/Structure Exposures"
        Me.txtOtherBldgStruc.Top = 0.05!
        Me.txtOtherBldgStruc.Width = 0.92!
        '
        'txtSiteAccess
        '
        Me.txtSiteAccess.DataField = "SiteAccess"
        Me.txtSiteAccess.Height = 0.3!
        Me.txtSiteAccess.Left = 11.0!
        Me.txtSiteAccess.Name = "txtSiteAccess"
        Me.txtSiteAccess.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtSiteAccess.Text = "Site Access"
        Me.txtSiteAccess.Top = 0.05!
        Me.txtSiteAccess.Width = 0.5!
        '
        'txtUtilities
        '
        Me.txtUtilities.DataField = "Utilities"
        Me.txtUtilities.Height = 0.3!
        Me.txtUtilities.Left = 11.5!
        Me.txtUtilities.Name = "txtUtilities"
        Me.txtUtilities.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtUtilities.Text = "Utilities"
        Me.txtUtilities.Top = 0.05!
        Me.txtUtilities.Width = 0.5!
        '
        'txtYardStge
        '
        Me.txtYardStge.DataField = "YardStge"
        Me.txtYardStge.Height = 0.3!
        Me.txtYardStge.Left = 12.0!
        Me.txtYardStge.Name = "txtYardStge"
        Me.txtYardStge.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtYardStge.Text = "Inadquate"
        Me.txtYardStge.Top = 0.05!
        Me.txtYardStge.Width = 0.5!
        '
        'txtOtherFloodExp
        '
        Me.txtOtherFloodExp.DataField = "OtherFloodExp"
        Me.txtOtherFloodExp.Height = 0.3!
        Me.txtOtherFloodExp.Left = 12.5!
        Me.txtOtherFloodExp.Name = "txtOtherFloodExp"
        Me.txtOtherFloodExp.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtOtherFloodExp.Text = "Inadquate"
        Me.txtOtherFloodExp.Top = 0.05!
        Me.txtOtherFloodExp.Width = 0.5!
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
        'txtPrepRespPlan
        '
        Me.txtPrepRespPlan.DataField = "PrepRespPlan"
        Me.txtPrepRespPlan.Height = 0.3!
        Me.txtPrepRespPlan.Left = 10.11!
        Me.txtPrepRespPlan.Name = "txtPrepRespPlan"
        Me.txtPrepRespPlan.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtPrepRespPlan.Text = "Preparation/ Response Planning"
        Me.txtPrepRespPlan.Top = 0.05!
        Me.txtPrepRespPlan.Width = 0.89!
        '
        'line42
        '
        Me.line42.Height = 0.3!
        Me.line42.Left = 13.0!
        Me.line42.LineWeight = 1.0!
        Me.line42.Name = "line42"
        Me.line42.Top = 0.05!
        Me.line42.Width = 0.0!
        Me.line42.X1 = 13.0!
        Me.line42.X2 = 13.0!
        Me.line42.Y1 = 0.05!
        Me.line42.Y2 = 0.35!
        '
        'line43
        '
        Me.line43.Height = 0.3!
        Me.line43.Left = 12.5!
        Me.line43.LineWeight = 1.0!
        Me.line43.Name = "line43"
        Me.line43.Top = 0.05!
        Me.line43.Width = 0.0!
        Me.line43.X1 = 12.5!
        Me.line43.X2 = 12.5!
        Me.line43.Y1 = 0.05!
        Me.line43.Y2 = 0.35!
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
        Me.line46.Left = 11.5!
        Me.line46.LineWeight = 1.0!
        Me.line46.Name = "line46"
        Me.line46.Top = 0.05!
        Me.line46.Width = 0.0!
        Me.line46.X1 = 11.5!
        Me.line46.X2 = 11.5!
        Me.line46.Y1 = 0.05!
        Me.line46.Y2 = 0.35!
        '
        'line47
        '
        Me.line47.Height = 0.3!
        Me.line47.Left = 11.0!
        Me.line47.LineWeight = 1.0!
        Me.line47.Name = "line47"
        Me.line47.Top = 0.05!
        Me.line47.Width = 0.0!
        Me.line47.X1 = 11.0!
        Me.line47.X2 = 11.0!
        Me.line47.Y1 = 0.05!
        Me.line47.Y2 = 0.35!
        '
        'line49
        '
        Me.line49.Height = 0.3!
        Me.line49.Left = 10.11!
        Me.line49.LineWeight = 1.0!
        Me.line49.Name = "line49"
        Me.line49.Top = 0.05!
        Me.line49.Width = 0.0!
        Me.line49.X1 = 10.11!
        Me.line49.X2 = 10.11!
        Me.line49.Y1 = 0.05!
        Me.line49.Y2 = 0.35!
        '
        'line50
        '
        Me.line50.Height = 0.3!
        Me.line50.Left = 8.14!
        Me.line50.LineWeight = 1.0!
        Me.line50.Name = "line50"
        Me.line50.Top = 0.05!
        Me.line50.Width = 0.0!
        Me.line50.X1 = 8.14!
        Me.line50.X2 = 8.14!
        Me.line50.Y1 = 0.05!
        Me.line50.Y2 = 0.35!
        '
        'line51
        '
        Me.line51.Height = 0.3!
        Me.line51.Left = 9.14!
        Me.line51.LineWeight = 1.0!
        Me.line51.Name = "line51"
        Me.line51.Top = 0.05!
        Me.line51.Width = 0.0!
        Me.line51.X1 = 9.14!
        Me.line51.X2 = 9.14!
        Me.line51.Y1 = 0.05!
        Me.line51.Y2 = 0.35!
        '
        'line52
        '
        Me.line52.Height = 0.3125!
        Me.line52.Left = 10.06!
        Me.line52.LineWeight = 1.0!
        Me.line52.Name = "line52"
        Me.line52.Top = 0.0625!
        Me.line52.Width = 0.0!
        Me.line52.X1 = 10.06!
        Me.line52.X2 = 10.06!
        Me.line52.Y1 = 0.0625!
        Me.line52.Y2 = 0.375!
        '
        'line54
        '
        Me.line54.Height = 0.3!
        Me.line54.Left = 7.51!
        Me.line54.LineWeight = 1.0!
        Me.line54.Name = "line54"
        Me.line54.Top = 0.05!
        Me.line54.Width = 0.0!
        Me.line54.X1 = 7.51!
        Me.line54.X2 = 7.51!
        Me.line54.Y1 = 0.05!
        Me.line54.Y2 = 0.35!
        '
        'line55
        '
        Me.line55.Height = 0.3!
        Me.line55.Left = 7.46!
        Me.line55.LineWeight = 1.0!
        Me.line55.Name = "line55"
        Me.line55.Top = 0.05!
        Me.line55.Width = 0.0!
        Me.line55.X1 = 7.46!
        Me.line55.X2 = 7.46!
        Me.line55.Y1 = 0.05!
        Me.line55.Y2 = 0.35!
        '
        'line56
        '
        Me.line56.Height = 0.3!
        Me.line56.Left = 6.96!
        Me.line56.LineWeight = 1.0!
        Me.line56.Name = "line56"
        Me.line56.Top = 0.05!
        Me.line56.Width = 0.0!
        Me.line56.X1 = 6.96!
        Me.line56.X2 = 6.96!
        Me.line56.Y1 = 0.05!
        Me.line56.Y2 = 0.35!
        '
        'line57
        '
        Me.line57.Height = 0.3!
        Me.line57.Left = 6.31!
        Me.line57.LineWeight = 1.0!
        Me.line57.Name = "line57"
        Me.line57.Top = 0.05!
        Me.line57.Width = 0.0!
        Me.line57.X1 = 6.31!
        Me.line57.X2 = 6.31!
        Me.line57.Y1 = 0.05!
        Me.line57.Y2 = 0.35!
        '
        'line58
        '
        Me.line58.Height = 0.3!
        Me.line58.Left = 5.68!
        Me.line58.LineWeight = 1.0!
        Me.line58.Name = "line58"
        Me.line58.Top = 0.05!
        Me.line58.Width = 0.0!
        Me.line58.X1 = 5.68!
        Me.line58.X2 = 5.68!
        Me.line58.Y1 = 0.05!
        Me.line58.Y2 = 0.35!
        '
        'line59
        '
        Me.line59.Height = 0.3!
        Me.line59.Left = 5.05!
        Me.line59.LineWeight = 1.0!
        Me.line59.Name = "line59"
        Me.line59.Top = 0.05!
        Me.line59.Width = 0.0!
        Me.line59.X1 = 5.05!
        Me.line59.X2 = 5.05!
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
        Me.line65.Width = 3.04!
        Me.line65.X1 = 4.42!
        Me.line65.X2 = 7.46!
        Me.line65.Y1 = 0.05!
        Me.line65.Y2 = 0.05!
        '
        'line67
        '
        Me.line67.Height = 0.0!
        Me.line67.Left = 4.42!
        Me.line67.LineWeight = 1.0!
        Me.line67.Name = "line67"
        Me.line67.Top = 0.35!
        Me.line67.Width = 3.04!
        Me.line67.X1 = 4.42!
        Me.line67.X2 = 7.46!
        Me.line67.Y1 = 0.35!
        Me.line67.Y2 = 0.35!
        '
        'line71
        '
        Me.line71.Height = 0.0!
        Me.line71.Left = 10.11!
        Me.line71.LineWeight = 1.0!
        Me.line71.Name = "line71"
        Me.line71.Top = 0.05!
        Me.line71.Width = 2.89!
        Me.line71.X1 = 10.11!
        Me.line71.X2 = 13.0!
        Me.line71.Y1 = 0.05!
        Me.line71.Y2 = 0.05!
        '
        'line72
        '
        Me.line72.Height = 0.0!
        Me.line72.Left = 10.11!
        Me.line72.LineWeight = 1.0!
        Me.line72.Name = "line72"
        Me.line72.Top = 0.35!
        Me.line72.Width = 2.89!
        Me.line72.X1 = 10.11!
        Me.line72.X2 = 13.0!
        Me.line72.Y1 = 0.35!
        Me.line72.Y2 = 0.35!
        '
        'line68
        '
        Me.line68.Height = 0.0!
        Me.line68.Left = 7.51!
        Me.line68.LineWeight = 1.0!
        Me.line68.Name = "line68"
        Me.line68.Top = 0.05!
        Me.line68.Width = 2.55!
        Me.line68.X1 = 7.51!
        Me.line68.X2 = 10.06!
        Me.line68.Y1 = 0.05!
        Me.line68.Y2 = 0.05!
        '
        'line70
        '
        Me.line70.Height = 0.0!
        Me.line70.Left = 7.51!
        Me.line70.LineWeight = 1.0!
        Me.line70.Name = "line70"
        Me.line70.Top = 0.35!
        Me.line70.Width = 2.55!
        Me.line70.X1 = 7.51!
        Me.line70.X2 = 10.06!
        Me.line70.Y1 = 0.35!
        Me.line70.Y2 = 0.35!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtSort, Me.lblReportDate, Me.reportInfo1, Me.txtDisclaimer})
        Me.PageFooter1.Height = 0.4541667!
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
        Me.lblReportDate.Left = 0.0000009536743!
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
        'rptNatHazFloodAssessmentExpBldgStructOther
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
        CType(Me.lblBuildingStructure, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblOtherFloodExp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblOther, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblClientName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblReport, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.lblExposures, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl100YrFlood, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl500YrFlood, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblStormSurge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSurfWater, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFixedProtection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblContConst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblOtherBldgStruc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPrepRespPlan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSiteAccess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblYardStge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblClientLocNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFacility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAEBG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblUtilities, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt500YrFlood, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDivision2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFileNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInspectionDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSTProv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTIV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt100YrFlood, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStormSurge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSurfWater, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFixedProtection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAEBG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContConst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOtherBldgStruc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSiteAccess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUtilities, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtYardStge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOtherFloodExp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFacility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientLocNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrepRespPlan, System.ComponentModel.ISupportInitialize).EndInit()
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

    Private Sub rptNatHazFloodAssessmentExpBldgStructOther_FetchData(ByVal sender As Object, ByVal eArgs As FetchEventArgs) Handles Me.FetchData

        Dim zTextControls() As ARControl = {
                                            txt100YrFlood,
                                            txt500YrFlood,
                                            txtStormSurge,
                                            txtSurfWater,
                                            txtFixedProtection,
                                            txtAEBG,
                                            txtContConst,
                                            txtOtherBldgStruc,
                                            txtPrepRespPlan,
                                            txtSiteAccess,
                                            txtUtilities,
                                            txtYardStge,
                                            txtOtherFloodExp
                                            }

        UtilReport.ActiveReport.SetItemBackColorByText(Me, zTextControls, rptProperties)
    End Sub

    Private Sub rptNatHazFloodAssessmentExpBldgStructOther_ReportStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportStart
        lblClientName.Text = rptProperties.ClientName
        lblTIVGrid.Text = "TIV " & rptProperties.Currency.colFldCode & vbLf & "(millions)"
        lblReportDate.Text = Now
    End Sub

    Private Sub rptNatHazFloodAssessmentExpBldgStructOther_PageStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.PageStart
        UtilReport.ActiveReport.SetFilter(Me, rptProperties)
        UtilReport.ActiveReport.SetSort(Me, rptProperties)
        UtilReport.ActiveReport.SetDisclaimer(Me, rptProperties)
    End Sub

    Private Sub rptNatHazFloodAssessmentExpBldgStructOther_ReportEnd(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportEnd
        DisposeParameters()
    End Sub

    Private Sub DisposeParameters()
        DataSource = Nothing
    End Sub

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties

End Class
