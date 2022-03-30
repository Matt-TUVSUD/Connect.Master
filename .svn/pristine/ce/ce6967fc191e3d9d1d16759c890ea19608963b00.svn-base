Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports

Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Imports GRC.Connect.Libraries.DataLib.razor

Public Class rptBMFacilityRatingDetail
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
    Private WithEvents label6 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents picGRCLogo As GrapeCity.ActiveReports.SectionReportModel.Picture
    Private WithEvents lblClientName As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtFilters As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblFilters As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblLocationInformation As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFileNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblDivision2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblInspectionDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCity As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblAddress As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblSTProv As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCountry As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblTIVGrid As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblClientLocNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFacility As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents line48 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line49 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line50 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line51 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents label47 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label48 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label49 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label50 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label51 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label52 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label53 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label54 As GrapeCity.ActiveReports.SectionReportModel.Label
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
    Private WithEvents label55 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label56 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label57 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label58 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label59 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label62 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents line71 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line72 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line73 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line74 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line75 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line78 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line79 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line80 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line81 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line59 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents label60 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label61 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label63 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label64 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label65 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label66 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents label67 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents line70 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line76 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line77 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line82 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line83 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line84 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line85 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line87 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line88 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtAddress As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtDivision2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFileNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSurveyDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCity As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSTProv As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCountry As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtTIV As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFacility As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtClientLocNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents line91 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line92 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line93 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line94 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtMechEquipC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtProcEquipC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtOccupancyC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCompSysC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtBoilersC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtElecEquipC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtPassiveC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtMechMaintC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtElecMaintC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSparesC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtBCPC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtActiveC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtTotalScoreCurrent As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtTotalRating As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtTotalWRCompleteScore As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtTotalWRCompleteRating As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents line96 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line97 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line99 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line100 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line101 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line103 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line104 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line110 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line111 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line112 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line113 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line114 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line115 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line116 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line117 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line118 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line119 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line120 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line121 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line122 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line123 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line124 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line125 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line126 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lblReportDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtSort As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents reportInfo1 As GrapeCity.ActiveReports.SectionReportModel.ReportInfo
    Private WithEvents txtHumanElementC As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblHE As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line98 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents SubReport1 As GrapeCity.ActiveReports.SectionReportModel.SubReport
    Private WithEvents txtDisclaimer As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents PageFooter1 As GrapeCity.ActiveReports.SectionReportModel.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptBMFacilityRatingDetail))
        Me.PageHeader1 = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.lblHE = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.picGRCLogo = New GrapeCity.ActiveReports.SectionReportModel.Picture()
        Me.lblClientName = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtFilters = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblFilters = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblLocationInformation = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFileNo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblDivision2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblInspectionDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblCity = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblAddress = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSTProv = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblCountry = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblTIVGrid = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblClientLocNo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFacility = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.line48 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line49 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line50 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line51 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.label47 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label48 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label49 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label50 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label51 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label52 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label53 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label54 = New GrapeCity.ActiveReports.SectionReportModel.Label()
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
        Me.label55 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label56 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label57 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label58 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label59 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label62 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.line71 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line72 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line73 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line74 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line75 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line78 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line79 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line80 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line81 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.label60 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label61 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label63 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label64 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label65 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label66 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label67 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.line70 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line76 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line77 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line82 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line83 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line84 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line85 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line87 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line88 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.SubReport1 = New GrapeCity.ActiveReports.SectionReportModel.SubReport()
        Me.Detail1 = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.txtHumanElementC = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtAddress = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtDivision2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFileNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSurveyDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCity = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSTProv = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCountry = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtTIV = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFacility = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtClientLocNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.line91 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line92 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line93 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line94 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtMechEquipC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtProcEquipC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtOccupancyC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCompSysC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtBoilersC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtElecEquipC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPassiveC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMechMaintC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtElecMaintC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSparesC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtBCPC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtActiveC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtTotalScoreCurrent = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtTotalRating = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtTotalWRCompleteScore = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtTotalWRCompleteRating = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.line96 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line97 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line98 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line99 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line100 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line101 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line103 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line104 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line110 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line111 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line112 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line113 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line114 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line115 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line116 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line117 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line118 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line119 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line120 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line121 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line122 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line123 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line124 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line125 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line126 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.PageFooter1 = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.lblReportDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtSort = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.reportInfo1 = New GrapeCity.ActiveReports.SectionReportModel.ReportInfo()
        Me.txtDisclaimer = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        CType(Me.lblHE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGRCLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblClientName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblLocationInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFileNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDivision2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblInspectionDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSTProv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTIVGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblClientLocNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFacility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label49, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label53, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label55, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label57, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label58, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label59, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label62, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label60, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label61, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label63, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label64, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label65, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label66, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label67, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHumanElementC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDivision2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFileNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSurveyDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSTProv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTIV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFacility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientLocNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMechEquipC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProcEquipC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOccupancyC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCompSysC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBoilersC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtElecEquipC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassiveC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMechMaintC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtElecMaintC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSparesC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBCPC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActiveC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalScoreCurrent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalWRCompleteScore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalWRCompleteRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblReportDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisclaimer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.CanShrink = True
        Me.PageHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblHE, Me.picGRCLogo, Me.lblClientName, Me.label3, Me.txtFilters, Me.lblFilters, Me.lblLocationInformation, Me.lblFileNo, Me.lblDivision2, Me.lblInspectionDate, Me.lblCity, Me.lblAddress, Me.lblSTProv, Me.lblCountry, Me.lblTIVGrid, Me.lblClientLocNo, Me.lblFacility, Me.line48, Me.line49, Me.line50, Me.line51, Me.label47, Me.label48, Me.label49, Me.label50, Me.label51, Me.label52, Me.label53, Me.label54, Me.line59, Me.line60, Me.line61, Me.line62, Me.line63, Me.line64, Me.line65, Me.line66, Me.line67, Me.line68, Me.line69, Me.label55, Me.label56, Me.label57, Me.label58, Me.label59, Me.label62, Me.line71, Me.line72, Me.line73, Me.line74, Me.line75, Me.line78, Me.line79, Me.line80, Me.line81, Me.label60, Me.label61, Me.label63, Me.label64, Me.label65, Me.label66, Me.label67, Me.line70, Me.line76, Me.line77, Me.line82, Me.line83, Me.line84, Me.line85, Me.line87, Me.line88, Me.line1, Me.SubReport1})
        Me.PageHeader1.Height = 2.0!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'lblHE
        '
        Me.lblHE.Height = 0.3!
        Me.lblHE.Left = 7.12!
        Me.lblHE.Name = "lblHE"
        Me.lblHE.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.lblHE.Text = "HE"
        Me.lblHE.Top = 1.7!
        Me.lblHE.Width = 0.25!
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
        'lblClientName
        '
        Me.lblClientName.Height = 0.25!
        Me.lblClientName.HyperLink = Nothing
        Me.lblClientName.Left = 5.84!
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
        Me.label3.Left = 5.84!
        Me.label3.Name = "label3"
        Me.label3.Style = "font-size: 12pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.label3.Text = "B&M Facility Rating Detail"
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
        Me.txtFilters.Width = 3.51!
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
        'lblLocationInformation
        '
        Me.lblLocationInformation.Height = 0.15!
        Me.lblLocationInformation.HyperLink = Nothing
        Me.lblLocationInformation.Left = 0.0!
        Me.lblLocationInformation.Name = "lblLocationInformation"
        Me.lblLocationInformation.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblLocationInformation.Text = "Location Detail"
        Me.lblLocationInformation.Top = 1.55!
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
        Me.lblFileNo.Top = 1.7!
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
        Me.lblDivision2.Top = 1.85!
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
        Me.lblInspectionDate.Top = 1.7!
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
        Me.lblCity.Top = 1.7!
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
        Me.lblAddress.Top = 1.85!
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
        Me.lblSTProv.Top = 1.7!
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
        Me.lblCountry.Top = 1.7!
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
        Me.lblTIVGrid.Top = 1.7!
        Me.lblTIVGrid.Width = 0.42!
        '
        'lblClientLocNo
        '
        Me.lblClientLocNo.Height = 0.1458!
        Me.lblClientLocNo.HyperLink = Nothing
        Me.lblClientLocNo.Left = 1.1!
        Me.lblClientLocNo.Name = "lblClientLocNo"
        Me.lblClientLocNo.Style = "background-color: White; font-size: 7pt"
        Me.lblClientLocNo.Text = "Client Loc. No"
        Me.lblClientLocNo.Top = 1.7!
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
        Me.lblFacility.Top = 1.85!
        Me.lblFacility.Width = 0.8!
        '
        'line48
        '
        Me.line48.Height = 0.0!
        Me.line48.Left = 0.0!
        Me.line48.LineWeight = 1.0!
        Me.line48.Name = "line48"
        Me.line48.Top = 2.0!
        Me.line48.Width = 4.37!
        Me.line48.X1 = 0.0!
        Me.line48.X2 = 4.37!
        Me.line48.Y1 = 2.0!
        Me.line48.Y2 = 2.0!
        '
        'line49
        '
        Me.line49.Height = 0.0!
        Me.line49.Left = 0.0!
        Me.line49.LineWeight = 1.0!
        Me.line49.Name = "line49"
        Me.line49.Top = 1.55!
        Me.line49.Width = 4.37!
        Me.line49.X1 = 0.0!
        Me.line49.X2 = 4.37!
        Me.line49.Y1 = 1.55!
        Me.line49.Y2 = 1.55!
        '
        'line50
        '
        Me.line50.Height = 0.45!
        Me.line50.Left = 0.0!
        Me.line50.LineWeight = 1.0!
        Me.line50.Name = "line50"
        Me.line50.Top = 1.55!
        Me.line50.Width = 0.0!
        Me.line50.X1 = 0.0!
        Me.line50.X2 = 0.0!
        Me.line50.Y1 = 1.55!
        Me.line50.Y2 = 2.0!
        '
        'line51
        '
        Me.line51.Height = 0.45!
        Me.line51.Left = 4.37!
        Me.line51.LineWeight = 1.0!
        Me.line51.Name = "line51"
        Me.line51.Top = 1.55!
        Me.line51.Width = 0.0!
        Me.line51.X1 = 4.37!
        Me.line51.X2 = 4.37!
        Me.line51.Y1 = 1.55!
        Me.line51.Y2 = 2.0!
        '
        'label47
        '
        Me.label47.Height = 0.15!
        Me.label47.HyperLink = Nothing
        Me.label47.Left = 4.42!
        Me.label47.Name = "label47"
        Me.label47.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.label47.Text = "Physical Assets"
        Me.label47.Top = 1.55!
        Me.label47.Width = 1.9!
        '
        'label48
        '
        Me.label48.Height = 0.3!
        Me.label48.HyperLink = Nothing
        Me.label48.Left = 4.42!
        Me.label48.Name = "label48"
        Me.label48.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.label48.Text = "ME"
        Me.label48.Top = 1.7!
        Me.label48.Width = 0.25!
        '
        'label49
        '
        Me.label49.Height = 0.3!
        Me.label49.HyperLink = Nothing
        Me.label49.Left = 4.67!
        Me.label49.Name = "label49"
        Me.label49.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.label49.Text = "EE"
        Me.label49.Top = 1.7!
        Me.label49.Width = 0.25!
        '
        'label50
        '
        Me.label50.Height = 0.3!
        Me.label50.HyperLink = Nothing
        Me.label50.Left = 4.92!
        Me.label50.Name = "label50"
        Me.label50.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.label50.Text = "Boi."
        Me.label50.Top = 1.7!
        Me.label50.Width = 0.25!
        '
        'label51
        '
        Me.label51.Height = 0.3!
        Me.label51.HyperLink = Nothing
        Me.label51.Left = 5.17!
        Me.label51.Name = "label51"
        Me.label51.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.label51.Text = "PE"
        Me.label51.Top = 1.7!
        Me.label51.Width = 0.25!
        '
        'label52
        '
        Me.label52.Height = 0.3!
        Me.label52.HyperLink = Nothing
        Me.label52.Left = 5.42!
        Me.label52.Name = "label52"
        Me.label52.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.label52.Text = "Occ."
        Me.label52.Top = 1.7!
        Me.label52.Width = 0.25!
        '
        'label53
        '
        Me.label53.Height = 0.3!
        Me.label53.HyperLink = Nothing
        Me.label53.Left = 5.67!
        Me.label53.Name = "label53"
        Me.label53.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.label53.Text = "CS"
        Me.label53.Top = 1.7!
        Me.label53.Width = 0.25!
        '
        'label54
        '
        Me.label54.Height = 0.3!
        Me.label54.HyperLink = Nothing
        Me.label54.Left = 5.92!
        Me.label54.Name = "label54"
        Me.label54.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.label54.Text = "Total Passive"
        Me.label54.Top = 1.7!
        Me.label54.Width = 0.4!
        '
        'line59
        '
        Me.line59.Height = 0.45!
        Me.line59.Left = 4.42!
        Me.line59.LineWeight = 1.0!
        Me.line59.Name = "line59"
        Me.line59.Top = 1.55!
        Me.line59.Width = 0.0!
        Me.line59.X1 = 4.42!
        Me.line59.X2 = 4.42!
        Me.line59.Y1 = 1.55!
        Me.line59.Y2 = 2.0!
        '
        'line60
        '
        Me.line60.Height = 0.3!
        Me.line60.Left = 4.67!
        Me.line60.LineWeight = 1.0!
        Me.line60.Name = "line60"
        Me.line60.Top = 1.7!
        Me.line60.Width = 0.0!
        Me.line60.X1 = 4.67!
        Me.line60.X2 = 4.67!
        Me.line60.Y1 = 1.7!
        Me.line60.Y2 = 2.0!
        '
        'line61
        '
        Me.line61.Height = 0.3!
        Me.line61.Left = 4.92!
        Me.line61.LineWeight = 1.0!
        Me.line61.Name = "line61"
        Me.line61.Top = 1.7!
        Me.line61.Width = 0.0!
        Me.line61.X1 = 4.92!
        Me.line61.X2 = 4.92!
        Me.line61.Y1 = 1.7!
        Me.line61.Y2 = 2.0!
        '
        'line62
        '
        Me.line62.Height = 0.3!
        Me.line62.Left = 5.17!
        Me.line62.LineWeight = 1.0!
        Me.line62.Name = "line62"
        Me.line62.Top = 1.7!
        Me.line62.Width = 0.0!
        Me.line62.X1 = 5.17!
        Me.line62.X2 = 5.17!
        Me.line62.Y1 = 1.7!
        Me.line62.Y2 = 2.0!
        '
        'line63
        '
        Me.line63.Height = 0.3!
        Me.line63.Left = 5.42!
        Me.line63.LineWeight = 1.0!
        Me.line63.Name = "line63"
        Me.line63.Top = 1.7!
        Me.line63.Width = 0.0!
        Me.line63.X1 = 5.42!
        Me.line63.X2 = 5.42!
        Me.line63.Y1 = 1.7!
        Me.line63.Y2 = 2.0!
        '
        'line64
        '
        Me.line64.Height = 0.3!
        Me.line64.Left = 5.67!
        Me.line64.LineWeight = 1.0!
        Me.line64.Name = "line64"
        Me.line64.Top = 1.7!
        Me.line64.Width = 0.0!
        Me.line64.X1 = 5.67!
        Me.line64.X2 = 5.67!
        Me.line64.Y1 = 1.7!
        Me.line64.Y2 = 2.0!
        '
        'line65
        '
        Me.line65.Height = 0.3!
        Me.line65.Left = 5.92!
        Me.line65.LineWeight = 1.0!
        Me.line65.Name = "line65"
        Me.line65.Top = 1.7!
        Me.line65.Width = 0.0!
        Me.line65.X1 = 5.92!
        Me.line65.X2 = 5.92!
        Me.line65.Y1 = 1.7!
        Me.line65.Y2 = 2.0!
        '
        'line66
        '
        Me.line66.Height = 0.45!
        Me.line66.Left = 6.32!
        Me.line66.LineWeight = 1.0!
        Me.line66.Name = "line66"
        Me.line66.Top = 1.55!
        Me.line66.Width = 0.0!
        Me.line66.X1 = 6.32!
        Me.line66.X2 = 6.32!
        Me.line66.Y1 = 1.55!
        Me.line66.Y2 = 2.0!
        '
        'line67
        '
        Me.line67.Height = 0.0!
        Me.line67.Left = 4.42!
        Me.line67.LineWeight = 1.0!
        Me.line67.Name = "line67"
        Me.line67.Top = 1.55!
        Me.line67.Width = 1.9!
        Me.line67.X1 = 4.42!
        Me.line67.X2 = 6.32!
        Me.line67.Y1 = 1.55!
        Me.line67.Y2 = 1.55!
        '
        'line68
        '
        Me.line68.Height = 0.0!
        Me.line68.Left = 4.42!
        Me.line68.LineWeight = 1.0!
        Me.line68.Name = "line68"
        Me.line68.Top = 1.7!
        Me.line68.Width = 1.9!
        Me.line68.X1 = 4.42!
        Me.line68.X2 = 6.32!
        Me.line68.Y1 = 1.7!
        Me.line68.Y2 = 1.7!
        '
        'line69
        '
        Me.line69.Height = 0.0!
        Me.line69.Left = 4.42!
        Me.line69.LineWeight = 1.0!
        Me.line69.Name = "line69"
        Me.line69.Top = 2.0!
        Me.line69.Width = 1.9!
        Me.line69.X1 = 4.42!
        Me.line69.X2 = 6.32!
        Me.line69.Y1 = 2.0!
        Me.line69.Y2 = 2.0!
        '
        'label55
        '
        Me.label55.Height = 0.15!
        Me.label55.HyperLink = Nothing
        Me.label55.Left = 6.37!
        Me.label55.Name = "label55"
        Me.label55.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.label55.Text = "Management Programs"
        Me.label55.Top = 1.55!
        Me.label55.Width = 1.65!
        '
        'label56
        '
        Me.label56.Height = 0.3!
        Me.label56.HyperLink = Nothing
        Me.label56.Left = 6.37!
        Me.label56.Name = "label56"
        Me.label56.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.label56.Text = "MM"
        Me.label56.Top = 1.7!
        Me.label56.Width = 0.25!
        '
        'label57
        '
        Me.label57.Height = 0.3!
        Me.label57.HyperLink = Nothing
        Me.label57.Left = 6.62!
        Me.label57.Name = "label57"
        Me.label57.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.label57.Text = "EM"
        Me.label57.Top = 1.7!
        Me.label57.Width = 0.25!
        '
        'label58
        '
        Me.label58.Height = 0.3!
        Me.label58.HyperLink = Nothing
        Me.label58.Left = 6.87!
        Me.label58.Name = "label58"
        Me.label58.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.label58.Text = "Spa."
        Me.label58.Top = 1.7!
        Me.label58.Width = 0.25!
        '
        'label59
        '
        Me.label59.Height = 0.3!
        Me.label59.HyperLink = Nothing
        Me.label59.Left = 7.37!
        Me.label59.Name = "label59"
        Me.label59.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.label59.Text = "BCP"
        Me.label59.Top = 1.7!
        Me.label59.Width = 0.25!
        '
        'label62
        '
        Me.label62.Height = 0.3!
        Me.label62.HyperLink = Nothing
        Me.label62.Left = 7.62!
        Me.label62.Name = "label62"
        Me.label62.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.label62.Text = "Total Active"
        Me.label62.Top = 1.7!
        Me.label62.Width = 0.4!
        '
        'line71
        '
        Me.line71.Height = 0.45!
        Me.line71.Left = 6.37!
        Me.line71.LineWeight = 1.0!
        Me.line71.Name = "line71"
        Me.line71.Top = 1.55!
        Me.line71.Width = 0.0!
        Me.line71.X1 = 6.37!
        Me.line71.X2 = 6.37!
        Me.line71.Y1 = 1.55!
        Me.line71.Y2 = 2.0!
        '
        'line72
        '
        Me.line72.Height = 0.3!
        Me.line72.Left = 6.62!
        Me.line72.LineWeight = 1.0!
        Me.line72.Name = "line72"
        Me.line72.Top = 1.7!
        Me.line72.Width = 0.0!
        Me.line72.X1 = 6.62!
        Me.line72.X2 = 6.62!
        Me.line72.Y1 = 1.7!
        Me.line72.Y2 = 2.0!
        '
        'line73
        '
        Me.line73.Height = 0.3!
        Me.line73.Left = 6.87!
        Me.line73.LineWeight = 1.0!
        Me.line73.Name = "line73"
        Me.line73.Top = 1.7!
        Me.line73.Width = 0.0!
        Me.line73.X1 = 6.87!
        Me.line73.X2 = 6.87!
        Me.line73.Y1 = 1.7!
        Me.line73.Y2 = 2.0!
        '
        'line74
        '
        Me.line74.Height = 0.3!
        Me.line74.Left = 7.12!
        Me.line74.LineWeight = 1.0!
        Me.line74.Name = "line74"
        Me.line74.Top = 1.7!
        Me.line74.Width = 0.0!
        Me.line74.X1 = 7.12!
        Me.line74.X2 = 7.12!
        Me.line74.Y1 = 1.7!
        Me.line74.Y2 = 2.0!
        '
        'line75
        '
        Me.line75.Height = 0.3!
        Me.line75.Left = 7.37!
        Me.line75.LineWeight = 1.0!
        Me.line75.Name = "line75"
        Me.line75.Top = 1.7!
        Me.line75.Width = 0.0!
        Me.line75.X1 = 7.37!
        Me.line75.X2 = 7.37!
        Me.line75.Y1 = 1.7!
        Me.line75.Y2 = 2.0!
        '
        'line78
        '
        Me.line78.Height = 0.45!
        Me.line78.Left = 8.02!
        Me.line78.LineWeight = 1.0!
        Me.line78.Name = "line78"
        Me.line78.Top = 1.55!
        Me.line78.Width = 0.0!
        Me.line78.X1 = 8.02!
        Me.line78.X2 = 8.02!
        Me.line78.Y1 = 1.55!
        Me.line78.Y2 = 2.0!
        '
        'line79
        '
        Me.line79.Height = 0.0!
        Me.line79.Left = 6.37!
        Me.line79.LineWeight = 1.0!
        Me.line79.Name = "line79"
        Me.line79.Top = 1.55!
        Me.line79.Width = 1.650001!
        Me.line79.X1 = 6.37!
        Me.line79.X2 = 8.02!
        Me.line79.Y1 = 1.55!
        Me.line79.Y2 = 1.55!
        '
        'line80
        '
        Me.line80.Height = 0.0!
        Me.line80.Left = 6.37!
        Me.line80.LineWeight = 1.0!
        Me.line80.Name = "line80"
        Me.line80.Top = 1.7!
        Me.line80.Width = 1.650001!
        Me.line80.X1 = 6.37!
        Me.line80.X2 = 8.02!
        Me.line80.Y1 = 1.7!
        Me.line80.Y2 = 1.7!
        '
        'line81
        '
        Me.line81.Height = 0.0!
        Me.line81.Left = 6.37!
        Me.line81.LineWeight = 1.0!
        Me.line81.Name = "line81"
        Me.line81.Top = 2.0!
        Me.line81.Width = 1.650001!
        Me.line81.X1 = 6.37!
        Me.line81.X2 = 8.02!
        Me.line81.Y1 = 2.0!
        Me.line81.Y2 = 2.0!
        '
        'label60
        '
        Me.label60.Height = 0.15!
        Me.label60.HyperLink = Nothing
        Me.label60.Left = 8.06!
        Me.label60.Name = "label60"
        Me.label60.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.label60.Text = "Overall Score"
        Me.label60.Top = 1.55!
        Me.label60.Width = 2.14!
        '
        'label61
        '
        Me.label61.Height = 0.15!
        Me.label61.HyperLink = Nothing
        Me.label61.Left = 8.06!
        Me.label61.Name = "label61"
        Me.label61.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.label61.Text = "Score"
        Me.label61.Top = 1.85!
        Me.label61.Width = 0.4!
        '
        'label63
        '
        Me.label63.Height = 0.15!
        Me.label63.HyperLink = Nothing
        Me.label63.Left = 8.47!
        Me.label63.Name = "label63"
        Me.label63.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.label63.Text = "Rating"
        Me.label63.Top = 1.85!
        Me.label63.Width = 0.66!
        '
        'label64
        '
        Me.label64.Height = 0.15!
        Me.label64.HyperLink = Nothing
        Me.label64.Left = 8.06!
        Me.label64.Name = "label64"
        Me.label64.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.label64.Text = "Current"
        Me.label64.Top = 1.7!
        Me.label64.Width = 1.06!
        '
        'label65
        '
        Me.label65.Height = 0.15!
        Me.label65.HyperLink = Nothing
        Me.label65.Left = 9.13!
        Me.label65.Name = "label65"
        Me.label65.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.label65.Text = "w/Recs Completed"
        Me.label65.Top = 1.7!
        Me.label65.Width = 1.07!
        '
        'label66
        '
        Me.label66.Height = 0.15!
        Me.label66.HyperLink = Nothing
        Me.label66.Left = 9.13!
        Me.label66.Name = "label66"
        Me.label66.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.label66.Text = "Score"
        Me.label66.Top = 1.85!
        Me.label66.Width = 0.4!
        '
        'label67
        '
        Me.label67.Height = 0.15!
        Me.label67.HyperLink = Nothing
        Me.label67.Left = 9.53!
        Me.label67.Name = "label67"
        Me.label67.Style = "background-color: White; font-size: 7pt; text-align: center"
        Me.label67.Text = "Rating"
        Me.label67.Top = 1.85!
        Me.label67.Width = 0.67!
        '
        'line70
        '
        Me.line70.Height = 0.0!
        Me.line70.Left = 8.06!
        Me.line70.LineWeight = 1.0!
        Me.line70.Name = "line70"
        Me.line70.Top = 2.0!
        Me.line70.Width = 2.139999!
        Me.line70.X1 = 8.06!
        Me.line70.X2 = 10.2!
        Me.line70.Y1 = 2.0!
        Me.line70.Y2 = 2.0!
        '
        'line76
        '
        Me.line76.Height = 0.0!
        Me.line76.Left = 8.06!
        Me.line76.LineWeight = 1.0!
        Me.line76.Name = "line76"
        Me.line76.Top = 1.55!
        Me.line76.Width = 2.139999!
        Me.line76.X1 = 8.06!
        Me.line76.X2 = 10.2!
        Me.line76.Y1 = 1.55!
        Me.line76.Y2 = 1.55!
        '
        'line77
        '
        Me.line77.Height = 0.0!
        Me.line77.Left = 8.06!
        Me.line77.LineWeight = 1.0!
        Me.line77.Name = "line77"
        Me.line77.Top = 1.7!
        Me.line77.Width = 2.139999!
        Me.line77.X1 = 8.06!
        Me.line77.X2 = 10.2!
        Me.line77.Y1 = 1.7!
        Me.line77.Y2 = 1.7!
        '
        'line82
        '
        Me.line82.Height = 0.0!
        Me.line82.Left = 8.07!
        Me.line82.LineWeight = 1.0!
        Me.line82.Name = "line82"
        Me.line82.Top = 1.85!
        Me.line82.Width = 2.13!
        Me.line82.X1 = 8.07!
        Me.line82.X2 = 10.2!
        Me.line82.Y1 = 1.85!
        Me.line82.Y2 = 1.85!
        '
        'line83
        '
        Me.line83.Height = 0.45!
        Me.line83.Left = 8.06!
        Me.line83.LineWeight = 1.0!
        Me.line83.Name = "line83"
        Me.line83.Top = 1.55!
        Me.line83.Width = 0.0!
        Me.line83.X1 = 8.06!
        Me.line83.X2 = 8.06!
        Me.line83.Y1 = 1.55!
        Me.line83.Y2 = 2.0!
        '
        'line84
        '
        Me.line84.Height = 0.45!
        Me.line84.Left = 10.2!
        Me.line84.LineWeight = 1.0!
        Me.line84.Name = "line84"
        Me.line84.Top = 1.55!
        Me.line84.Width = 0.0!
        Me.line84.X1 = 10.2!
        Me.line84.X2 = 10.2!
        Me.line84.Y1 = 1.55!
        Me.line84.Y2 = 2.0!
        '
        'line85
        '
        Me.line85.Height = 0.15!
        Me.line85.Left = 8.47!
        Me.line85.LineWeight = 1.0!
        Me.line85.Name = "line85"
        Me.line85.Top = 1.85!
        Me.line85.Width = 0.0!
        Me.line85.X1 = 8.47!
        Me.line85.X2 = 8.47!
        Me.line85.Y1 = 1.85!
        Me.line85.Y2 = 2.0!
        '
        'line87
        '
        Me.line87.Height = 0.3!
        Me.line87.Left = 9.13!
        Me.line87.LineWeight = 1.0!
        Me.line87.Name = "line87"
        Me.line87.Top = 1.7!
        Me.line87.Width = 0.0!
        Me.line87.X1 = 9.13!
        Me.line87.X2 = 9.13!
        Me.line87.Y1 = 1.7!
        Me.line87.Y2 = 2.0!
        '
        'line88
        '
        Me.line88.Height = 0.15!
        Me.line88.Left = 9.53!
        Me.line88.LineWeight = 1.0!
        Me.line88.Name = "line88"
        Me.line88.Top = 1.85!
        Me.line88.Width = 0.0!
        Me.line88.X1 = 9.53!
        Me.line88.X2 = 9.53!
        Me.line88.Y1 = 1.85!
        Me.line88.Y2 = 2.0!
        '
        'line1
        '
        Me.line1.Height = 0.3!
        Me.line1.Left = 7.62!
        Me.line1.LineWeight = 1.0!
        Me.line1.Name = "line1"
        Me.line1.Top = 1.7!
        Me.line1.Width = 0.0!
        Me.line1.X1 = 7.62!
        Me.line1.X2 = 7.62!
        Me.line1.Y1 = 1.7!
        Me.line1.Y2 = 2.0!
        '
        'SubReport1
        '
        Me.SubReport1.CloseBorder = False
        Me.SubReport1.Height = 0.8980001!
        Me.SubReport1.Left = 4.015!
        Me.SubReport1.Name = "SubReport1"
        Me.SubReport1.Report = Nothing
        Me.SubReport1.ReportName = "SubReport1"
        Me.SubReport1.Top = 0.652!
        Me.SubReport1.Width = 6.125!
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtHumanElementC, Me.txtAddress, Me.txtDivision2, Me.txtFileNo, Me.txtSurveyDate, Me.txtCity, Me.txtSTProv, Me.txtCountry, Me.txtTIV, Me.txtFacility, Me.txtClientLocNo, Me.line91, Me.line92, Me.line93, Me.line94, Me.txtMechEquipC, Me.txtProcEquipC, Me.txtOccupancyC, Me.txtCompSysC, Me.txtBoilersC, Me.txtElecEquipC, Me.txtPassiveC, Me.txtMechMaintC, Me.txtElecMaintC, Me.txtSparesC, Me.txtBCPC, Me.txtActiveC, Me.txtTotalScoreCurrent, Me.txtTotalRating, Me.txtTotalWRCompleteScore, Me.txtTotalWRCompleteRating, Me.line96, Me.line97, Me.line98, Me.line99, Me.line100, Me.line101, Me.line103, Me.line104, Me.line110, Me.line111, Me.line112, Me.line113, Me.line114, Me.line115, Me.line116, Me.line117, Me.line118, Me.line119, Me.line120, Me.line121, Me.line122, Me.line123, Me.line124, Me.line125, Me.line126, Me.line2})
        Me.Detail1.Height = 0.35!
        Me.Detail1.KeepTogether = True
        Me.Detail1.Name = "Detail1"
        '
        'txtHumanElementC
        '
        Me.txtHumanElementC.DataField = "HumanElementC"
        Me.txtHumanElementC.Height = 0.3!
        Me.txtHumanElementC.HyperLink = Nothing
        Me.txtHumanElementC.Left = 7.12!
        Me.txtHumanElementC.Name = "txtHumanElementC"
        Me.txtHumanElementC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtHumanElementC.Text = "HE"
        Me.txtHumanElementC.Top = 0.05!
        Me.txtHumanElementC.Width = 0.25!
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
        'line91
        '
        Me.line91.Height = 0.0!
        Me.line91.Left = 0.0!
        Me.line91.LineWeight = 1.0!
        Me.line91.Name = "line91"
        Me.line91.Top = 0.05!
        Me.line91.Width = 4.37!
        Me.line91.X1 = 0.0!
        Me.line91.X2 = 4.37!
        Me.line91.Y1 = 0.05!
        Me.line91.Y2 = 0.05!
        '
        'line92
        '
        Me.line92.Height = 0.0!
        Me.line92.Left = 0.0!
        Me.line92.LineWeight = 1.0!
        Me.line92.Name = "line92"
        Me.line92.Top = 0.35!
        Me.line92.Width = 4.37!
        Me.line92.X1 = 0.0!
        Me.line92.X2 = 4.37!
        Me.line92.Y1 = 0.35!
        Me.line92.Y2 = 0.35!
        '
        'line93
        '
        Me.line93.Height = 0.3!
        Me.line93.Left = 0.0!
        Me.line93.LineWeight = 1.0!
        Me.line93.Name = "line93"
        Me.line93.Top = 0.05!
        Me.line93.Width = 0.0!
        Me.line93.X1 = 0.0!
        Me.line93.X2 = 0.0!
        Me.line93.Y1 = 0.05!
        Me.line93.Y2 = 0.35!
        '
        'line94
        '
        Me.line94.Height = 0.3!
        Me.line94.Left = 4.37!
        Me.line94.LineWeight = 1.0!
        Me.line94.Name = "line94"
        Me.line94.Top = 0.05!
        Me.line94.Width = 0.0!
        Me.line94.X1 = 4.37!
        Me.line94.X2 = 4.37!
        Me.line94.Y1 = 0.05!
        Me.line94.Y2 = 0.35!
        '
        'txtMechEquipC
        '
        Me.txtMechEquipC.DataField = "MechEquipC"
        Me.txtMechEquipC.Height = 0.3!
        Me.txtMechEquipC.Left = 4.42!
        Me.txtMechEquipC.Name = "txtMechEquipC"
        Me.txtMechEquipC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtMechEquipC.Text = "ME"
        Me.txtMechEquipC.Top = 0.05!
        Me.txtMechEquipC.Width = 0.25!
        '
        'txtProcEquipC
        '
        Me.txtProcEquipC.DataField = "ProcEquipC"
        Me.txtProcEquipC.Height = 0.3!
        Me.txtProcEquipC.Left = 5.17!
        Me.txtProcEquipC.Name = "txtProcEquipC"
        Me.txtProcEquipC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtProcEquipC.Text = "PE"
        Me.txtProcEquipC.Top = 0.05!
        Me.txtProcEquipC.Width = 0.25!
        '
        'txtOccupancyC
        '
        Me.txtOccupancyC.DataField = "OccupancyC"
        Me.txtOccupancyC.Height = 0.3!
        Me.txtOccupancyC.Left = 5.42!
        Me.txtOccupancyC.Name = "txtOccupancyC"
        Me.txtOccupancyC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtOccupancyC.Text = "Occ."
        Me.txtOccupancyC.Top = 0.05!
        Me.txtOccupancyC.Width = 0.25!
        '
        'txtCompSysC
        '
        Me.txtCompSysC.DataField = "CompSysC"
        Me.txtCompSysC.Height = 0.3!
        Me.txtCompSysC.Left = 5.67!
        Me.txtCompSysC.Name = "txtCompSysC"
        Me.txtCompSysC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtCompSysC.Text = "CS"
        Me.txtCompSysC.Top = 0.05!
        Me.txtCompSysC.Width = 0.25!
        '
        'txtBoilersC
        '
        Me.txtBoilersC.DataField = "BoilersC"
        Me.txtBoilersC.Height = 0.3!
        Me.txtBoilersC.Left = 4.92!
        Me.txtBoilersC.Name = "txtBoilersC"
        Me.txtBoilersC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtBoilersC.Text = "Boi."
        Me.txtBoilersC.Top = 0.05!
        Me.txtBoilersC.Width = 0.25!
        '
        'txtElecEquipC
        '
        Me.txtElecEquipC.DataField = "ElecEquipC"
        Me.txtElecEquipC.Height = 0.3!
        Me.txtElecEquipC.Left = 4.67!
        Me.txtElecEquipC.Name = "txtElecEquipC"
        Me.txtElecEquipC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtElecEquipC.Text = "EE"
        Me.txtElecEquipC.Top = 0.05!
        Me.txtElecEquipC.Width = 0.25!
        '
        'txtPassiveC
        '
        Me.txtPassiveC.DataField = "PassiveC"
        Me.txtPassiveC.Height = 0.3!
        Me.txtPassiveC.Left = 5.92!
        Me.txtPassiveC.Name = "txtPassiveC"
        Me.txtPassiveC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtPassiveC.Text = "Total Passive"
        Me.txtPassiveC.Top = 0.05!
        Me.txtPassiveC.Width = 0.4!
        '
        'txtMechMaintC
        '
        Me.txtMechMaintC.DataField = "MechMaintC"
        Me.txtMechMaintC.Height = 0.3!
        Me.txtMechMaintC.Left = 6.37!
        Me.txtMechMaintC.Name = "txtMechMaintC"
        Me.txtMechMaintC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtMechMaintC.Text = "MM"
        Me.txtMechMaintC.Top = 0.05!
        Me.txtMechMaintC.Width = 0.25!
        '
        'txtElecMaintC
        '
        Me.txtElecMaintC.DataField = "ElecMaintC"
        Me.txtElecMaintC.Height = 0.3!
        Me.txtElecMaintC.Left = 6.62!
        Me.txtElecMaintC.Name = "txtElecMaintC"
        Me.txtElecMaintC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtElecMaintC.Text = "EM"
        Me.txtElecMaintC.Top = 0.05!
        Me.txtElecMaintC.Width = 0.25!
        '
        'txtSparesC
        '
        Me.txtSparesC.DataField = "SparesC"
        Me.txtSparesC.Height = 0.3!
        Me.txtSparesC.Left = 6.87!
        Me.txtSparesC.Name = "txtSparesC"
        Me.txtSparesC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtSparesC.Text = "Spa."
        Me.txtSparesC.Top = 0.05!
        Me.txtSparesC.Width = 0.25!
        '
        'txtBCPC
        '
        Me.txtBCPC.DataField = "BCPC"
        Me.txtBCPC.Height = 0.3!
        Me.txtBCPC.Left = 7.37!
        Me.txtBCPC.Name = "txtBCPC"
        Me.txtBCPC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtBCPC.Text = "BCP"
        Me.txtBCPC.Top = 0.05!
        Me.txtBCPC.Width = 0.25!
        '
        'txtActiveC
        '
        Me.txtActiveC.DataField = "ActiveC"
        Me.txtActiveC.Height = 0.3!
        Me.txtActiveC.Left = 7.62!
        Me.txtActiveC.Name = "txtActiveC"
        Me.txtActiveC.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtActiveC.Text = "Total Active"
        Me.txtActiveC.Top = 0.05!
        Me.txtActiveC.Width = 0.4!
        '
        'txtTotalScoreCurrent
        '
        Me.txtTotalScoreCurrent.DataField = "TotalScoreCurrent"
        Me.txtTotalScoreCurrent.Height = 0.3!
        Me.txtTotalScoreCurrent.Left = 8.06!
        Me.txtTotalScoreCurrent.Name = "txtTotalScoreCurrent"
        Me.txtTotalScoreCurrent.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtTotalScoreCurrent.Text = "Score"
        Me.txtTotalScoreCurrent.Top = 0.05!
        Me.txtTotalScoreCurrent.Width = 0.4!
        '
        'txtTotalRating
        '
        Me.txtTotalRating.DataField = "TotalRating"
        Me.txtTotalRating.Height = 0.3!
        Me.txtTotalRating.Left = 8.47!
        Me.txtTotalRating.Name = "txtTotalRating"
        Me.txtTotalRating.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtTotalRating.Text = "Rating"
        Me.txtTotalRating.Top = 0.05!
        Me.txtTotalRating.Width = 0.66!
        '
        'txtTotalWRCompleteScore
        '
        Me.txtTotalWRCompleteScore.DataField = "TotalWRComplete"
        Me.txtTotalWRCompleteScore.Height = 0.3!
        Me.txtTotalWRCompleteScore.Left = 9.13!
        Me.txtTotalWRCompleteScore.Name = "txtTotalWRCompleteScore"
        Me.txtTotalWRCompleteScore.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtTotalWRCompleteScore.Text = "Score"
        Me.txtTotalWRCompleteScore.Top = 0.05!
        Me.txtTotalWRCompleteScore.Width = 0.4!
        '
        'txtTotalWRCompleteRating
        '
        Me.txtTotalWRCompleteRating.DataField = "TotalWRCompleteRating"
        Me.txtTotalWRCompleteRating.Height = 0.3!
        Me.txtTotalWRCompleteRating.Left = 9.53!
        Me.txtTotalWRCompleteRating.Name = "txtTotalWRCompleteRating"
        Me.txtTotalWRCompleteRating.Style = "background-color: White; font-size: 7pt; text-align: center; vertical-align: midd" & _
    "le"
        Me.txtTotalWRCompleteRating.Text = "Rating"
        Me.txtTotalWRCompleteRating.Top = 0.05!
        Me.txtTotalWRCompleteRating.Width = 0.67!
        '
        'line96
        '
        Me.line96.Height = 0.0!
        Me.line96.Left = 4.42!
        Me.line96.LineWeight = 1.0!
        Me.line96.Name = "line96"
        Me.line96.Top = 0.35!
        Me.line96.Width = 1.9!
        Me.line96.X1 = 4.42!
        Me.line96.X2 = 6.32!
        Me.line96.Y1 = 0.35!
        Me.line96.Y2 = 0.35!
        '
        'line97
        '
        Me.line97.Height = 0.0!
        Me.line97.Left = 6.37!
        Me.line97.LineWeight = 1.0!
        Me.line97.Name = "line97"
        Me.line97.Top = 0.35!
        Me.line97.Width = 1.650001!
        Me.line97.X1 = 6.37!
        Me.line97.X2 = 8.02!
        Me.line97.Y1 = 0.35!
        Me.line97.Y2 = 0.35!
        '
        'line98
        '
        Me.line98.Height = 0.0!
        Me.line98.Left = 8.07!
        Me.line98.LineWeight = 1.0!
        Me.line98.Name = "line98"
        Me.line98.Top = 0.35!
        Me.line98.Width = 2.13!
        Me.line98.X1 = 8.07!
        Me.line98.X2 = 10.2!
        Me.line98.Y1 = 0.35!
        Me.line98.Y2 = 0.35!
        '
        'line99
        '
        Me.line99.Height = 0.0!
        Me.line99.Left = 8.07!
        Me.line99.LineWeight = 1.0!
        Me.line99.Name = "line99"
        Me.line99.Top = 0.05!
        Me.line99.Width = 2.13!
        Me.line99.X1 = 8.07!
        Me.line99.X2 = 10.2!
        Me.line99.Y1 = 0.05!
        Me.line99.Y2 = 0.05!
        '
        'line100
        '
        Me.line100.Height = 0.0!
        Me.line100.Left = 6.37!
        Me.line100.LineWeight = 1.0!
        Me.line100.Name = "line100"
        Me.line100.Top = 0.05!
        Me.line100.Width = 1.650001!
        Me.line100.X1 = 6.37!
        Me.line100.X2 = 8.02!
        Me.line100.Y1 = 0.05!
        Me.line100.Y2 = 0.05!
        '
        'line101
        '
        Me.line101.Height = 0.0!
        Me.line101.Left = 4.42!
        Me.line101.LineWeight = 1.0!
        Me.line101.Name = "line101"
        Me.line101.Top = 0.05!
        Me.line101.Width = 1.9!
        Me.line101.X1 = 4.42!
        Me.line101.X2 = 6.32!
        Me.line101.Y1 = 0.05!
        Me.line101.Y2 = 0.05!
        '
        'line103
        '
        Me.line103.Height = 0.3!
        Me.line103.Left = 4.42!
        Me.line103.LineWeight = 1.0!
        Me.line103.Name = "line103"
        Me.line103.Top = 0.05!
        Me.line103.Width = 0.0!
        Me.line103.X1 = 4.42!
        Me.line103.X2 = 4.42!
        Me.line103.Y1 = 0.05!
        Me.line103.Y2 = 0.35!
        '
        'line104
        '
        Me.line104.Height = 0.3!
        Me.line104.Left = 6.32!
        Me.line104.LineWeight = 1.0!
        Me.line104.Name = "line104"
        Me.line104.Top = 0.05!
        Me.line104.Width = 0.0!
        Me.line104.X1 = 6.32!
        Me.line104.X2 = 6.32!
        Me.line104.Y1 = 0.05!
        Me.line104.Y2 = 0.35!
        '
        'line110
        '
        Me.line110.Height = 0.3!
        Me.line110.Left = 5.17!
        Me.line110.LineWeight = 1.0!
        Me.line110.Name = "line110"
        Me.line110.Top = 0.05!
        Me.line110.Width = 0.0!
        Me.line110.X1 = 5.17!
        Me.line110.X2 = 5.17!
        Me.line110.Y1 = 0.05!
        Me.line110.Y2 = 0.35!
        '
        'line111
        '
        Me.line111.Height = 0.3!
        Me.line111.Left = 5.92!
        Me.line111.LineWeight = 1.0!
        Me.line111.Name = "line111"
        Me.line111.Top = 0.05!
        Me.line111.Width = 0.0!
        Me.line111.X1 = 5.92!
        Me.line111.X2 = 5.92!
        Me.line111.Y1 = 0.05!
        Me.line111.Y2 = 0.35!
        '
        'line112
        '
        Me.line112.Height = 0.3!
        Me.line112.Left = 4.92!
        Me.line112.LineWeight = 1.0!
        Me.line112.Name = "line112"
        Me.line112.Top = 0.05!
        Me.line112.Width = 0.0!
        Me.line112.X1 = 4.92!
        Me.line112.X2 = 4.92!
        Me.line112.Y1 = 0.05!
        Me.line112.Y2 = 0.35!
        '
        'line113
        '
        Me.line113.Height = 0.3!
        Me.line113.Left = 4.67!
        Me.line113.LineWeight = 1.0!
        Me.line113.Name = "line113"
        Me.line113.Top = 0.05!
        Me.line113.Width = 0.0!
        Me.line113.X1 = 4.67!
        Me.line113.X2 = 4.67!
        Me.line113.Y1 = 0.05!
        Me.line113.Y2 = 0.35!
        '
        'line114
        '
        Me.line114.Height = 0.3!
        Me.line114.Left = 5.67!
        Me.line114.LineWeight = 1.0!
        Me.line114.Name = "line114"
        Me.line114.Top = 0.05!
        Me.line114.Width = 0.0!
        Me.line114.X1 = 5.67!
        Me.line114.X2 = 5.67!
        Me.line114.Y1 = 0.05!
        Me.line114.Y2 = 0.35!
        '
        'line115
        '
        Me.line115.Height = 0.3!
        Me.line115.Left = 5.42!
        Me.line115.LineWeight = 1.0!
        Me.line115.Name = "line115"
        Me.line115.Top = 0.05!
        Me.line115.Width = 0.0!
        Me.line115.X1 = 5.42!
        Me.line115.X2 = 5.42!
        Me.line115.Y1 = 0.05!
        Me.line115.Y2 = 0.35!
        '
        'line116
        '
        Me.line116.Height = 0.3!
        Me.line116.Left = 8.02!
        Me.line116.LineWeight = 1.0!
        Me.line116.Name = "line116"
        Me.line116.Top = 0.05!
        Me.line116.Width = 0.0!
        Me.line116.X1 = 8.02!
        Me.line116.X2 = 8.02!
        Me.line116.Y1 = 0.05!
        Me.line116.Y2 = 0.35!
        '
        'line117
        '
        Me.line117.Height = 0.3!
        Me.line117.Left = 6.37!
        Me.line117.LineWeight = 1.0!
        Me.line117.Name = "line117"
        Me.line117.Top = 0.05!
        Me.line117.Width = 0.0!
        Me.line117.X1 = 6.37!
        Me.line117.X2 = 6.37!
        Me.line117.Y1 = 0.05!
        Me.line117.Y2 = 0.35!
        '
        'line118
        '
        Me.line118.Height = 0.3!
        Me.line118.Left = 6.87!
        Me.line118.LineWeight = 1.0!
        Me.line118.Name = "line118"
        Me.line118.Top = 0.05!
        Me.line118.Width = 0.0!
        Me.line118.X1 = 6.87!
        Me.line118.X2 = 6.87!
        Me.line118.Y1 = 0.05!
        Me.line118.Y2 = 0.35!
        '
        'line119
        '
        Me.line119.Height = 0.3!
        Me.line119.Left = 6.62!
        Me.line119.LineWeight = 1.0!
        Me.line119.Name = "line119"
        Me.line119.Top = 0.05!
        Me.line119.Width = 0.0!
        Me.line119.X1 = 6.62!
        Me.line119.X2 = 6.62!
        Me.line119.Y1 = 0.05!
        Me.line119.Y2 = 0.35!
        '
        'line120
        '
        Me.line120.Height = 0.3!
        Me.line120.Left = 7.12!
        Me.line120.LineWeight = 1.0!
        Me.line120.Name = "line120"
        Me.line120.Top = 0.05!
        Me.line120.Width = 0.0!
        Me.line120.X1 = 7.12!
        Me.line120.X2 = 7.12!
        Me.line120.Y1 = 0.05!
        Me.line120.Y2 = 0.35!
        '
        'line121
        '
        Me.line121.Height = 0.3!
        Me.line121.Left = 7.37!
        Me.line121.LineWeight = 1.0!
        Me.line121.Name = "line121"
        Me.line121.Top = 0.05!
        Me.line121.Width = 0.0!
        Me.line121.X1 = 7.37!
        Me.line121.X2 = 7.37!
        Me.line121.Y1 = 0.05!
        Me.line121.Y2 = 0.35!
        '
        'line122
        '
        Me.line122.Height = 0.3!
        Me.line122.Left = 9.53!
        Me.line122.LineWeight = 1.0!
        Me.line122.Name = "line122"
        Me.line122.Top = 0.05!
        Me.line122.Width = 0.0!
        Me.line122.X1 = 9.53!
        Me.line122.X2 = 9.53!
        Me.line122.Y1 = 0.05!
        Me.line122.Y2 = 0.35!
        '
        'line123
        '
        Me.line123.Height = 0.3!
        Me.line123.Left = 10.2!
        Me.line123.LineWeight = 1.0!
        Me.line123.Name = "line123"
        Me.line123.Top = 0.05!
        Me.line123.Width = 0.0!
        Me.line123.X1 = 10.2!
        Me.line123.X2 = 10.2!
        Me.line123.Y1 = 0.05!
        Me.line123.Y2 = 0.35!
        '
        'line124
        '
        Me.line124.Height = 0.3!
        Me.line124.Left = 8.47!
        Me.line124.LineWeight = 1.0!
        Me.line124.Name = "line124"
        Me.line124.Top = 0.05!
        Me.line124.Width = 0.0!
        Me.line124.X1 = 8.47!
        Me.line124.X2 = 8.47!
        Me.line124.Y1 = 0.05!
        Me.line124.Y2 = 0.35!
        '
        'line125
        '
        Me.line125.Height = 0.3!
        Me.line125.Left = 9.13!
        Me.line125.LineWeight = 1.0!
        Me.line125.Name = "line125"
        Me.line125.Top = 0.05!
        Me.line125.Width = 0.0!
        Me.line125.X1 = 9.13!
        Me.line125.X2 = 9.13!
        Me.line125.Y1 = 0.05!
        Me.line125.Y2 = 0.35!
        '
        'line126
        '
        Me.line126.Height = 0.3!
        Me.line126.Left = 8.06!
        Me.line126.LineWeight = 1.0!
        Me.line126.Name = "line126"
        Me.line126.Top = 0.05!
        Me.line126.Width = 0.0!
        Me.line126.X1 = 8.06!
        Me.line126.X2 = 8.06!
        Me.line126.Y1 = 0.05!
        Me.line126.Y2 = 0.35!
        '
        'line2
        '
        Me.line2.Height = 0.3!
        Me.line2.Left = 7.62!
        Me.line2.LineWeight = 1.0!
        Me.line2.Name = "line2"
        Me.line2.Top = 0.05!
        Me.line2.Width = 0.0!
        Me.line2.X1 = 7.62!
        Me.line2.X2 = 7.62!
        Me.line2.Y1 = 0.05!
        Me.line2.Y2 = 0.35!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblReportDate, Me.txtSort, Me.reportInfo1, Me.txtDisclaimer})
        Me.PageFooter1.Height = 0.56875!
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
        Me.txtSort.Height = 0.15!
        Me.txtSort.HyperLink = Nothing
        Me.txtSort.Left = 0.0!
        Me.txtSort.Name = "txtSort"
        Me.txtSort.Style = "font-size: 7pt; font-style: italic; text-align: center; vertical-align: middle"
        Me.txtSort.Text = "(Sorted in descending order of largest TIV. TIV values in millions.)"
        Me.txtSort.Top = 0.0!
        Me.txtSort.Width = 10.2!
        '
        'reportInfo1
        '
        Me.reportInfo1.FormatString = "Page {PageNumber} of {PageCount}"
        Me.reportInfo1.Height = 0.15!
        Me.reportInfo1.Left = 8.2!
        Me.reportInfo1.Name = "reportInfo1"
        Me.reportInfo1.Style = "font-size: 7pt; font-style: italic; text-align: right; vertical-align: middle"
        Me.reportInfo1.Top = 0.375!
        Me.reportInfo1.Width = 2.0!
        '
        'txtDisclaimer
        '
        Me.txtDisclaimer.CanShrink = True
        Me.txtDisclaimer.Height = 0.15!
        Me.txtDisclaimer.Left = 0.062!
        Me.txtDisclaimer.Name = "txtDisclaimer"
        Me.txtDisclaimer.Style = "font-size: 7pt; font-style: italic; text-align: center; vertical-align: middle"
        Me.txtDisclaimer.Text = "Disclaimer"
        Me.txtDisclaimer.Top = 0.187!
        Me.txtDisclaimer.Width = 10.125!
        '
        'rptBMFacilityRatingDetail
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.25!
        Me.PageSettings.Margins.Left = 0.4!
        Me.PageSettings.Margins.Right = 0.4!
        Me.PageSettings.Margins.Top = 0.25!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 10.2!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Calibri; font-style: normal; text-decoration: none; font-weight: nor" & _
            "mal; font-size: 10pt; color: Black", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
            "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.lblHE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGRCLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblClientName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblLocationInformation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFileNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDivision2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblInspectionDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSTProv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCountry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTIVGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblClientLocNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFacility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label49, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label53, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label55, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label57, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label58, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label59, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label62, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label60, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label61, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label63, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label64, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label65, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label66, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label67, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHumanElementC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDivision2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFileNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSurveyDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSTProv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTIV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFacility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientLocNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMechEquipC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProcEquipC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOccupancyC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCompSysC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBoilersC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtElecEquipC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassiveC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMechMaintC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtElecMaintC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSparesC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBCPC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActiveC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalScoreCurrent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalWRCompleteScore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalWRCompleteRating, System.ComponentModel.ISupportInitialize).EndInit()
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

        txtMechEquipC.Tag = TblMetaRatingCategory.Categories.BMMechanicalSys
        txtElecEquipC.Tag = TblMetaRatingCategory.Categories.BMElectricalSys
        txtBoilersC.Tag = TblMetaRatingCategory.Categories.BMBPVT
        txtProcEquipC.Tag = TblMetaRatingCategory.Categories.BMPPE
        txtOccupancyC.Tag = TblMetaRatingCategory.Categories.BMOccupancy
        txtCompSysC.Tag = TblMetaRatingCategory.Categories.BMComputerSys
        txtMechMaintC.Tag = TblMetaRatingCategory.Categories.BMMPPM
        txtElecMaintC.Tag = TblMetaRatingCategory.Categories.BMEPPM
        txtSparesC.Tag = TblMetaRatingCategory.Categories.BMCriticalSpaces
        txtHumanElementC.Tag = TblMetaRatingCategory.Categories.BMHumanElement
        txtBCPC.Tag = TblMetaRatingCategory.Categories.BMBCP

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

    Private Sub rptBMFacilityRatingDetail_FetchData(ByVal sender As Object, ByVal eArgs As FetchEventArgs) Handles Me.FetchData
        lblTIVGrid.Text = "TIV " & rptProperties.Currency.colFldCode & vbLf & "(millions)"
        Dim zRatingControls() As ARControl = {txtMechEquipC, txtElecEquipC, txtBoilersC, txtProcEquipC, txtOccupancyC, txtCompSysC, txtMechMaintC, txtElecMaintC, txtSparesC, txtHumanElementC, txtBCPC}
        UtilReport.ActiveReport.SetItemBackColorByRating(Me, zRatingControls, rptProperties)

        Dim zrpt As SectionReport = sender
        txtTotalScoreCurrent.BackColor = System.Drawing.ColorTranslator.FromHtml(zrpt.AllFields("totalscorecurrentColor").Value)
        txtTotalRating.BackColor = System.Drawing.ColorTranslator.FromHtml(zrpt.AllFields("totalratingColor").Value)
        txtTotalWRCompleteScore.BackColor = System.Drawing.ColorTranslator.FromHtml(zrpt.AllFields("totalwrcompleteColor").Value)
        txtTotalWRCompleteRating.BackColor = System.Drawing.ColorTranslator.FromHtml(zrpt.AllFields("totalwrcompleteratingColor").Value)

        'Dim zRiskRatingControls() As ARControl = {txtTotalRating, txtTotalWRCompleteRating}
        'UtilReport.ActiveReport.SetItemBackColorByRiskRating(Me, zRiskRatingControls, rptProperties)

        Dim zRiskScoreControls() As ARControl = {txtTotalScoreCurrent, txtTotalWRCompleteScore}
        UtilReport.ActiveReport.SetItemBackColorByRiskRatingScore(Me, zRiskScoreControls, rptProperties)
    End Sub

    Private Sub rptBMFacilityRatingDetail_ReportStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportStart
        lblClientName.Text = rptProperties.ClientName 'AppSession.ClientName
        lblReportDate.Text = Now.ToString 'modActiveReport.ReportDate

        Dim zSubReport As New rptBMFacilityRatingKey
        zSubReport.rptProperties = rptProperties
        SubReport1.Report = zSubReport

    End Sub

    Private Sub rptBMFacilityRatingDetail_PageStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.PageStart
        UtilReport.ActiveReport.SetFilter(Me, rptProperties)
        UtilReport.ActiveReport.SetSort(Me, rptProperties)
        UtilReport.ActiveReport.SetDisclaimer(Me, rptProperties)
    End Sub

    Private Sub rptBMFacilityRatingDetail_ReportEnd(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportEnd
        DisposeParameters()
    End Sub

    Private Sub DisposeParameters()
        DataSource = Nothing
        Me.SubReport1.Report.Dispose()
    End Sub

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties
End Class
