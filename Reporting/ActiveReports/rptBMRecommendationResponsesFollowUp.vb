Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports

Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing

Public Class rptBMRecommendationResponsesFollowUp
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
    Private WithEvents lblAddress As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCity As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblStProv As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCountry As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblClientLocNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblDivision As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFilters As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblRecommendationFollowUpReport As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lnPageHeaderTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnPageHeaderBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtFilters As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblTIV As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFacility As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lnPageHeaderRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents rptPageNo As GrapeCity.ActiveReports.SectionReportModel.ReportInfo
    Private WithEvents txtSort As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblReportDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtRespRequestDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtAddress As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtCity As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtStProv As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtCountry As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtRecipientEmail As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtRecipientName As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtRFU1Date As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtFileNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtNoActiveRecs As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtDaysOverdue As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtRFU3Date As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtDivision As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblNoActiveRecs As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblRespRequestDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblRecipientEmail As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblRespDueDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblNoRecsNeedingResp As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblRFU2Date As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtNoRecsNeedingResp As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtRespDueDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtRFU2Date As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lnRecipientEmailLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRecipientEmailTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lblDaysOverdue As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblRFU3Date As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblRFU1Date As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblRecipientName As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtClientLocNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtTIV As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFacility As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lnRespRequestDateLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRespRequestDateRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRespRequestDateTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRespRequestDateBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnDaysOverdueTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRespDueDateTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRespDueDateBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnDaysOverdueBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRespDueDateLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRespDueDateRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnDaysOverdueLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnDaysOverdueRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRFU3DateBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRFU1DateTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRFU1DateBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRFU2DateTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRecipientNameRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRFU2DateLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRFU3DateLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRFU2DateBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRecipientNameLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRFU1DateLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnNoActiveRecsTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnNoActiveRecsBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnNoRecsNeedingRespTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnNoRecsNeedingRespRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnNoRecsNeedingRespLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnNoRecsNeedingRespBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnNoActiveRecsLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRFU3DateTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnNoActiveRecsRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRFU1DateRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRFU2DateRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRFU3DateRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRecipientNameTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRecipientNameBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRecipientEmailBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnPageHeaderLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnDetailRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnDetailBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnDetailTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnDetailLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRecipientEmailRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents line3 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lblFileNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblClientName As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblRecommendationFollowUpReportMessage As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtResponseStatus As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblResponseStatus As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lnResponseStatusLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnResponseStatusBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnResponseStatusTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnResponseStatusRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents TotalNoRecsRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnTotalNoRecsTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtTotalNoRecs As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblTotalNoRecs As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lnAutoRequestRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnAutoRequestBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtAutoRequest As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblAutoRequest As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lnAutoRequestTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnAutoRequestLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnTotalNoRecsBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnTotalNoRecsLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtDisclaimer As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents PageFooter1 As GrapeCity.ActiveReports.SectionReportModel.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptBMRecommendationResponsesFollowUp))
        Me.PageHeader1 = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.lblFacility = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFileNo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblTIV = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.picGRCLogo = New GrapeCity.ActiveReports.SectionReportModel.Picture()
        Me.lblAddress = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblCity = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblStProv = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblCountry = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblClientLocNo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblDivision = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFilters = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblRecommendationFollowUpReport = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lnPageHeaderTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnPageHeaderBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtFilters = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblRecommendationFollowUpReportMessage = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblClientName = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lnPageHeaderRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnPageHeaderLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Detail1 = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.txtTotalNoRecs = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblAutoRequest = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtAutoRequest = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblResponseStatus = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtRespDueDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtRespRequestDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtAddress = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtCity = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtCountry = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtRecipientEmail = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtRecipientName = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtRFU1Date = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtFileNo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtNoActiveRecs = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtDaysOverdue = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtRFU3Date = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtDivision = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblNoActiveRecs = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblRespRequestDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblRecipientEmail = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblRespDueDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblNoRecsNeedingResp = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblRFU2Date = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtNoRecsNeedingResp = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtRFU2Date = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lnRecipientEmailLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRecipientEmailTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lblDaysOverdue = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblRFU3Date = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblRFU1Date = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblRecipientName = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtClientLocNo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtTIV = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFacility = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lnRespRequestDateLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRespRequestDateRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRespRequestDateTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRespRequestDateBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnDaysOverdueTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRespDueDateTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRespDueDateBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnDaysOverdueBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRespDueDateLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRespDueDateRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnDaysOverdueLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnDaysOverdueRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRFU3DateBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRFU1DateTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRFU1DateBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRFU2DateTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRecipientNameRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRFU2DateLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRFU3DateLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRFU2DateBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRecipientNameLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRFU1DateLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnNoActiveRecsTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnNoActiveRecsBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnNoRecsNeedingRespTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnNoRecsNeedingRespRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnNoRecsNeedingRespLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnNoRecsNeedingRespBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRFU3DateTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnNoActiveRecsRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRFU1DateRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRFU2DateRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRFU3DateRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRecipientNameTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRecipientNameBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRecipientEmailBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtStProv = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lnDetailBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnDetailTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnDetailLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRecipientEmailRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnNoActiveRecsLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.line3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnDetailRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtResponseStatus = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lnResponseStatusLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnResponseStatusBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnResponseStatusTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnResponseStatusRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.TotalNoRecsRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnTotalNoRecsTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lblTotalNoRecs = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lnAutoRequestRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnAutoRequestBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnAutoRequestTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnAutoRequestLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnTotalNoRecsBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnTotalNoRecsLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.PageFooter1 = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.rptPageNo = New GrapeCity.ActiveReports.SectionReportModel.ReportInfo()
        Me.txtSort = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblReportDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtDisclaimer = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        CType(Me.lblFacility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFileNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTIV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGRCLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblStProv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblClientLocNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDivision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRecommendationFollowUpReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRecommendationFollowUpReportMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblClientName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalNoRecs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAutoRequest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAutoRequest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblResponseStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRespDueDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRespRequestDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRecipientEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRecipientName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRFU1Date, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFileNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoActiveRecs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDaysOverdue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRFU3Date, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDivision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNoActiveRecs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRespRequestDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRecipientEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRespDueDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNoRecsNeedingResp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRFU2Date, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoRecsNeedingResp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRFU2Date, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDaysOverdue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRFU3Date, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRFU1Date, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRecipientName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientLocNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTIV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFacility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStProv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtResponseStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTotalNoRecs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptPageNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblReportDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisclaimer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.CanShrink = True
        Me.PageHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblFacility, Me.lblFileNo, Me.lblTIV, Me.picGRCLogo, Me.lblAddress, Me.lblCity, Me.lblStProv, Me.lblCountry, Me.lblClientLocNo, Me.lblDivision, Me.lblFilters, Me.lblRecommendationFollowUpReport, Me.lnPageHeaderTop, Me.lnPageHeaderBottom, Me.txtFilters, Me.lblRecommendationFollowUpReportMessage, Me.lblClientName, Me.lnPageHeaderRight, Me.lnPageHeaderLeft})
        Me.PageHeader1.Height = 1.4!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'lblFacility
        '
        Me.lblFacility.Height = 0.3!
        Me.lblFacility.HyperLink = Nothing
        Me.lblFacility.Left = 3.05!
        Me.lblFacility.Name = "lblFacility"
        Me.lblFacility.Style = "font-size: 8pt; font-weight: bold; vertical-align: middle"
        Me.lblFacility.Text = "Facility"
        Me.lblFacility.Top = 1.05!
        Me.lblFacility.Width = 1.2!
        '
        'lblFileNo
        '
        Me.lblFileNo.Height = 0.3!
        Me.lblFileNo.HyperLink = Nothing
        Me.lblFileNo.Left = 0.0!
        Me.lblFileNo.Name = "lblFileNo"
        Me.lblFileNo.Style = "font-size: 8pt; font-weight: bold; vertical-align: middle"
        Me.lblFileNo.Text = "File No."
        Me.lblFileNo.Top = 1.05!
        Me.lblFileNo.Width = 0.85!
        '
        'lblTIV
        '
        Me.lblTIV.Height = 0.3!
        Me.lblTIV.HyperLink = Nothing
        Me.lblTIV.Left = 9.4!
        Me.lblTIV.Name = "lblTIV"
        Me.lblTIV.Style = "font-size: 8pt; font-weight: bold; text-align: center; vertical-align: middle"
        Me.lblTIV.Text = "TIV"
        Me.lblTIV.Top = 1.05!
        Me.lblTIV.Width = 0.6!
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
        'lblAddress
        '
        Me.lblAddress.Height = 0.3!
        Me.lblAddress.HyperLink = Nothing
        Me.lblAddress.Left = 4.3!
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Style = "font-size: 8pt; font-weight: bold; vertical-align: middle"
        Me.lblAddress.Text = "Address"
        Me.lblAddress.Top = 1.05!
        Me.lblAddress.Width = 2.15!
        '
        'lblCity
        '
        Me.lblCity.Height = 0.3!
        Me.lblCity.HyperLink = Nothing
        Me.lblCity.Left = 6.5!
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Style = "font-size: 8pt; font-weight: bold; vertical-align: middle"
        Me.lblCity.Text = "City"
        Me.lblCity.Top = 1.05!
        Me.lblCity.Width = 1.55!
        '
        'lblStProv
        '
        Me.lblStProv.Height = 0.3!
        Me.lblStProv.HyperLink = Nothing
        Me.lblStProv.Left = 8.1!
        Me.lblStProv.Name = "lblStProv"
        Me.lblStProv.Style = "font-size: 8pt; font-weight: bold; vertical-align: middle"
        Me.lblStProv.Text = "St/Prov"
        Me.lblStProv.Top = 1.05!
        Me.lblStProv.Width = 0.45!
        '
        'lblCountry
        '
        Me.lblCountry.Height = 0.3!
        Me.lblCountry.HyperLink = Nothing
        Me.lblCountry.Left = 8.6!
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Style = "font-size: 8pt; font-weight: bold; vertical-align: middle"
        Me.lblCountry.Text = "Country"
        Me.lblCountry.Top = 1.05!
        Me.lblCountry.Width = 0.75!
        '
        'lblClientLocNo
        '
        Me.lblClientLocNo.Height = 0.3!
        Me.lblClientLocNo.HyperLink = Nothing
        Me.lblClientLocNo.Left = 0.9!
        Me.lblClientLocNo.Name = "lblClientLocNo"
        Me.lblClientLocNo.Style = "font-size: 8pt; font-weight: bold; vertical-align: middle"
        Me.lblClientLocNo.Text = "Client Loc. ID"
        Me.lblClientLocNo.Top = 1.05!
        Me.lblClientLocNo.Width = 0.85!
        '
        'lblDivision
        '
        Me.lblDivision.Height = 0.3!
        Me.lblDivision.HyperLink = Nothing
        Me.lblDivision.Left = 1.8!
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.Style = "font-size: 8pt; font-weight: bold; vertical-align: middle"
        Me.lblDivision.Text = "Division"
        Me.lblDivision.Top = 1.05!
        Me.lblDivision.Width = 1.2!
        '
        'lblFilters
        '
        Me.lblFilters.Height = 0.15!
        Me.lblFilters.HyperLink = Nothing
        Me.lblFilters.Left = 0.05!
        Me.lblFilters.Name = "lblFilters"
        Me.lblFilters.Style = "font-size: 8pt; font-weight: bold; text-align: left; vertical-align: middle"
        Me.lblFilters.Text = "Filters:"
        Me.lblFilters.Top = 0.85!
        Me.lblFilters.Width = 0.4!
        '
        'lblRecommendationFollowUpReport
        '
        Me.lblRecommendationFollowUpReport.Height = 0.2!
        Me.lblRecommendationFollowUpReport.HyperLink = Nothing
        Me.lblRecommendationFollowUpReport.Left = 5.64!
        Me.lblRecommendationFollowUpReport.Name = "lblRecommendationFollowUpReport"
        Me.lblRecommendationFollowUpReport.Style = "font-size: 12pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblRecommendationFollowUpReport.Text = "B&M Recommendation Follow-Up Report"
        Me.lblRecommendationFollowUpReport.Top = 0.35!
        Me.lblRecommendationFollowUpReport.Width = 4.3!
        '
        'lnPageHeaderTop
        '
        Me.lnPageHeaderTop.Height = 0.0!
        Me.lnPageHeaderTop.Left = 0.0!
        Me.lnPageHeaderTop.LineWeight = 1.0!
        Me.lnPageHeaderTop.Name = "lnPageHeaderTop"
        Me.lnPageHeaderTop.Top = 1.05!
        Me.lnPageHeaderTop.Width = 10.0!
        Me.lnPageHeaderTop.X1 = 0.0!
        Me.lnPageHeaderTop.X2 = 10.0!
        Me.lnPageHeaderTop.Y1 = 1.05!
        Me.lnPageHeaderTop.Y2 = 1.05!
        '
        'lnPageHeaderBottom
        '
        Me.lnPageHeaderBottom.Height = 0.0!
        Me.lnPageHeaderBottom.Left = 0.0!
        Me.lnPageHeaderBottom.LineWeight = 1.0!
        Me.lnPageHeaderBottom.Name = "lnPageHeaderBottom"
        Me.lnPageHeaderBottom.Top = 1.35!
        Me.lnPageHeaderBottom.Width = 10.0!
        Me.lnPageHeaderBottom.X1 = 0.0!
        Me.lnPageHeaderBottom.X2 = 10.0!
        Me.lnPageHeaderBottom.Y1 = 1.35!
        Me.lnPageHeaderBottom.Y2 = 1.35!
        '
        'txtFilters
        '
        Me.txtFilters.CanShrink = True
        Me.txtFilters.Height = 0.15!
        Me.txtFilters.Left = 0.45!
        Me.txtFilters.Name = "txtFilters"
        Me.txtFilters.Style = "font-size: 8pt; vertical-align: middle"
        Me.txtFilters.Text = "Filters"
        Me.txtFilters.Top = 0.85!
        Me.txtFilters.Width = 9.55!
        '
        'lblRecommendationFollowUpReportMessage
        '
        Me.lblRecommendationFollowUpReportMessage.CanShrink = True
        Me.lblRecommendationFollowUpReportMessage.Height = 0.15!
        Me.lblRecommendationFollowUpReportMessage.Left = 0.0!
        Me.lblRecommendationFollowUpReportMessage.Name = "lblRecommendationFollowUpReportMessage"
        Me.lblRecommendationFollowUpReportMessage.Style = "font-size: 8pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblRecommendationFollowUpReportMessage.Text = Nothing
        Me.lblRecommendationFollowUpReportMessage.Top = 0.625!
        Me.lblRecommendationFollowUpReportMessage.Width = 10.0!
        '
        'lblClientName
        '
        Me.lblClientName.Height = 0.25!
        Me.lblClientName.HyperLink = Nothing
        Me.lblClientName.Left = 5.64!
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Style = "color: #C6D1DE; font-size: 16pt; font-style: italic; font-weight: bold; text-alig" & _
    "n: right; vertical-align: middle"
        Me.lblClientName.Text = "Company Name"
        Me.lblClientName.Top = 0.05000003!
        Me.lblClientName.Width = 4.3!
        '
        'lnPageHeaderRight
        '
        Me.lnPageHeaderRight.Height = 0.3000001!
        Me.lnPageHeaderRight.Left = 10.0!
        Me.lnPageHeaderRight.LineWeight = 1.0!
        Me.lnPageHeaderRight.Name = "lnPageHeaderRight"
        Me.lnPageHeaderRight.Top = 1.05!
        Me.lnPageHeaderRight.Width = 0.0!
        Me.lnPageHeaderRight.X1 = 10.0!
        Me.lnPageHeaderRight.X2 = 10.0!
        Me.lnPageHeaderRight.Y1 = 1.05!
        Me.lnPageHeaderRight.Y2 = 1.35!
        '
        'lnPageHeaderLeft
        '
        Me.lnPageHeaderLeft.Height = 0.3000001!
        Me.lnPageHeaderLeft.Left = 0.0!
        Me.lnPageHeaderLeft.LineWeight = 1.0!
        Me.lnPageHeaderLeft.Name = "lnPageHeaderLeft"
        Me.lnPageHeaderLeft.Top = 1.05!
        Me.lnPageHeaderLeft.Width = 0.0!
        Me.lnPageHeaderLeft.X1 = 0.0!
        Me.lnPageHeaderLeft.X2 = 0.0!
        Me.lnPageHeaderLeft.Y1 = 1.05!
        Me.lnPageHeaderLeft.Y2 = 1.35!
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtTotalNoRecs, Me.lblAutoRequest, Me.txtAutoRequest, Me.lblResponseStatus, Me.txtRespDueDate, Me.txtRespRequestDate, Me.txtAddress, Me.txtCity, Me.txtCountry, Me.txtRecipientEmail, Me.txtRecipientName, Me.txtRFU1Date, Me.txtFileNo, Me.txtNoActiveRecs, Me.txtDaysOverdue, Me.txtRFU3Date, Me.txtDivision, Me.lblNoActiveRecs, Me.lblRespRequestDate, Me.lblRecipientEmail, Me.lblRespDueDate, Me.lblNoRecsNeedingResp, Me.lblRFU2Date, Me.txtNoRecsNeedingResp, Me.txtRFU2Date, Me.lnRecipientEmailLeft, Me.lnRecipientEmailTop, Me.lblDaysOverdue, Me.lblRFU3Date, Me.lblRFU1Date, Me.lblRecipientName, Me.txtClientLocNo, Me.txtTIV, Me.txtFacility, Me.lnRespRequestDateLeft, Me.lnRespRequestDateRight, Me.lnRespRequestDateTop, Me.lnRespRequestDateBottom, Me.lnDaysOverdueTop, Me.lnRespDueDateTop, Me.lnRespDueDateBottom, Me.lnDaysOverdueBottom, Me.lnRespDueDateLeft, Me.lnRespDueDateRight, Me.lnDaysOverdueLeft, Me.lnDaysOverdueRight, Me.lnRFU3DateBottom, Me.lnRFU1DateTop, Me.lnRFU1DateBottom, Me.lnRFU2DateTop, Me.lnRecipientNameRight, Me.lnRFU2DateLeft, Me.lnRFU3DateLeft, Me.lnRFU2DateBottom, Me.lnRecipientNameLeft, Me.lnRFU1DateLeft, Me.lnNoActiveRecsTop, Me.lnNoActiveRecsBottom, Me.lnNoRecsNeedingRespTop, Me.lnNoRecsNeedingRespRight, Me.lnNoRecsNeedingRespLeft, Me.lnNoRecsNeedingRespBottom, Me.lnRFU3DateTop, Me.lnNoActiveRecsRight, Me.lnRFU1DateRight, Me.lnRFU2DateRight, Me.lnRFU3DateRight, Me.lnRecipientNameTop, Me.lnRecipientNameBottom, Me.lnRecipientEmailBottom, Me.txtStProv, Me.lnDetailBottom, Me.lnDetailTop, Me.lnDetailLeft, Me.lnRecipientEmailRight, Me.lnNoActiveRecsLeft, Me.line3, Me.lnDetailRight, Me.txtResponseStatus, Me.lnResponseStatusLeft, Me.lnResponseStatusBottom, Me.lnResponseStatusTop, Me.lnResponseStatusRight, Me.TotalNoRecsRight, Me.lnTotalNoRecsTop, Me.lblTotalNoRecs, Me.lnAutoRequestRight, Me.lnAutoRequestBottom, Me.lnAutoRequestTop, Me.lnAutoRequestLeft, Me.lnTotalNoRecsBottom, Me.lnTotalNoRecsLeft})
        Me.Detail1.Height = 1.0!
        Me.Detail1.KeepTogether = True
        Me.Detail1.Name = "Detail1"
        '
        'txtTotalNoRecs
        '
        Me.txtTotalNoRecs.DataField = "TotalNoRecs"
        Me.txtTotalNoRecs.Height = 0.15!
        Me.txtTotalNoRecs.HyperLink = Nothing
        Me.txtTotalNoRecs.Left = 3.2!
        Me.txtTotalNoRecs.Name = "txtTotalNoRecs"
        Me.txtTotalNoRecs.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtTotalNoRecs.Text = "TotalNoRecs"
        Me.txtTotalNoRecs.Top = 0.35!
        Me.txtTotalNoRecs.Width = 0.3!
        '
        'lblAutoRequest
        '
        Me.lblAutoRequest.Height = 0.15!
        Me.lblAutoRequest.HyperLink = Nothing
        Me.lblAutoRequest.Left = 0.0!
        Me.lblAutoRequest.Name = "lblAutoRequest"
        Me.lblAutoRequest.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblAutoRequest.Text = "Auto-Request"
        Me.lblAutoRequest.Top = 0.75!
        Me.lblAutoRequest.Width = 0.85!
        '
        'txtAutoRequest
        '
        Me.txtAutoRequest.DataField = "AutoRequest"
        Me.txtAutoRequest.Height = 0.15!
        Me.txtAutoRequest.HyperLink = Nothing
        Me.txtAutoRequest.Left = 0.9!
        Me.txtAutoRequest.Name = "txtAutoRequest"
        Me.txtAutoRequest.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtAutoRequest.Text = "AutoRequest"
        Me.txtAutoRequest.Top = 0.75!
        Me.txtAutoRequest.Width = 0.9!
        '
        'lblResponseStatus
        '
        Me.lblResponseStatus.Height = 0.15!
        Me.lblResponseStatus.HyperLink = Nothing
        Me.lblResponseStatus.Left = 0.0!
        Me.lblResponseStatus.Name = "lblResponseStatus"
        Me.lblResponseStatus.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblResponseStatus.Text = "Response Status"
        Me.lblResponseStatus.Top = 0.55!
        Me.lblResponseStatus.Width = 0.85!
        '
        'txtRespDueDate
        '
        Me.txtRespDueDate.DataField = "RespDueDateString"
        Me.txtRespDueDate.Height = 0.15!
        Me.txtRespDueDate.HyperLink = Nothing
        Me.txtRespDueDate.Left = 4.75!
        Me.txtRespDueDate.Name = "txtRespDueDate"
        Me.txtRespDueDate.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtRespDueDate.Text = "RespDueDate"
        Me.txtRespDueDate.Top = 0.55!
        Me.txtRespDueDate.Width = 0.75!
        '
        'txtRespRequestDate
        '
        Me.txtRespRequestDate.DataField = "RespRequestDateString"
        Me.txtRespRequestDate.Height = 0.15!
        Me.txtRespRequestDate.HyperLink = Nothing
        Me.txtRespRequestDate.Left = 4.75!
        Me.txtRespRequestDate.Name = "txtRespRequestDate"
        Me.txtRespRequestDate.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtRespRequestDate.Text = "RespRequestDate"
        Me.txtRespRequestDate.Top = 0.35!
        Me.txtRespRequestDate.Width = 0.75!
        '
        'txtAddress
        '
        Me.txtAddress.DataField = "Address"
        Me.txtAddress.Height = 0.3!
        Me.txtAddress.HyperLink = Nothing
        Me.txtAddress.Left = 4.3!
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Style = "font-size: 8pt; font-weight: bold; vertical-align: middle"
        Me.txtAddress.Text = "Address"
        Me.txtAddress.Top = 0.0!
        Me.txtAddress.Width = 2.15!
        '
        'txtCity
        '
        Me.txtCity.DataField = "City"
        Me.txtCity.Height = 0.3!
        Me.txtCity.HyperLink = Nothing
        Me.txtCity.Left = 6.5!
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Style = "font-size: 8pt; font-weight: bold; vertical-align: middle"
        Me.txtCity.Text = "City"
        Me.txtCity.Top = 0.0!
        Me.txtCity.Width = 1.55!
        '
        'txtCountry
        '
        Me.txtCountry.DataField = "Country"
        Me.txtCountry.Height = 0.3!
        Me.txtCountry.HyperLink = Nothing
        Me.txtCountry.Left = 8.6!
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Style = "font-size: 8pt; font-weight: bold; vertical-align: middle"
        Me.txtCountry.Text = "Country"
        Me.txtCountry.Top = 0.0!
        Me.txtCountry.Width = 0.75!
        '
        'txtRecipientEmail
        '
        Me.txtRecipientEmail.DataField = "RecipientEmail"
        Me.txtRecipientEmail.Height = 0.15!
        Me.txtRecipientEmail.HyperLink = Nothing
        Me.txtRecipientEmail.Left = 8.2!
        Me.txtRecipientEmail.Name = "txtRecipientEmail"
        Me.txtRecipientEmail.Style = "font-size: 6.5pt; text-align: left; vertical-align: middle"
        Me.txtRecipientEmail.Text = "RecipientEmail"
        Me.txtRecipientEmail.Top = 0.55!
        Me.txtRecipientEmail.Width = 1.75!
        '
        'txtRecipientName
        '
        Me.txtRecipientName.DataField = "RecipientName"
        Me.txtRecipientName.Height = 0.15!
        Me.txtRecipientName.HyperLink = Nothing
        Me.txtRecipientName.Left = 8.2!
        Me.txtRecipientName.Name = "txtRecipientName"
        Me.txtRecipientName.Style = "font-size: 7pt; vertical-align: middle; ddo-char-set: 0"
        Me.txtRecipientName.Text = "RecipientName"
        Me.txtRecipientName.Top = 0.35!
        Me.txtRecipientName.Width = 1.75!
        '
        'txtRFU1Date
        '
        Me.txtRFU1Date.DataField = "RFU1DateString"
        Me.txtRFU1Date.Height = 0.15!
        Me.txtRFU1Date.HyperLink = Nothing
        Me.txtRFU1Date.Left = 6.5!
        Me.txtRFU1Date.Name = "txtRFU1Date"
        Me.txtRFU1Date.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtRFU1Date.Text = "RFU1Date"
        Me.txtRFU1Date.Top = 0.35!
        Me.txtRFU1Date.Width = 0.75!
        '
        'txtFileNo
        '
        Me.txtFileNo.DataField = "FileNo"
        Me.txtFileNo.Height = 0.3!
        Me.txtFileNo.HyperLink = Nothing
        Me.txtFileNo.Left = 0.0!
        Me.txtFileNo.Name = "txtFileNo"
        Me.txtFileNo.Style = "font-size: 8pt; font-weight: bold; vertical-align: middle"
        Me.txtFileNo.Text = "File No"
        Me.txtFileNo.Top = 0.0!
        Me.txtFileNo.Width = 0.85!
        '
        'txtNoActiveRecs
        '
        Me.txtNoActiveRecs.DataField = "NoActiveRecs"
        Me.txtNoActiveRecs.Height = 0.15!
        Me.txtNoActiveRecs.HyperLink = Nothing
        Me.txtNoActiveRecs.Left = 3.2!
        Me.txtNoActiveRecs.Name = "txtNoActiveRecs"
        Me.txtNoActiveRecs.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtNoActiveRecs.Text = "NoActiveRecs"
        Me.txtNoActiveRecs.Top = 0.55!
        Me.txtNoActiveRecs.Width = 0.3!
        '
        'txtDaysOverdue
        '
        Me.txtDaysOverdue.DataField = "DaysOverdue"
        Me.txtDaysOverdue.Height = 0.15!
        Me.txtDaysOverdue.HyperLink = Nothing
        Me.txtDaysOverdue.Left = 4.75!
        Me.txtDaysOverdue.Name = "txtDaysOverdue"
        Me.txtDaysOverdue.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtDaysOverdue.Text = "DaysOverdue"
        Me.txtDaysOverdue.Top = 0.75!
        Me.txtDaysOverdue.Width = 0.75!
        '
        'txtRFU3Date
        '
        Me.txtRFU3Date.DataField = "RFU3DateString"
        Me.txtRFU3Date.Height = 0.15!
        Me.txtRFU3Date.HyperLink = Nothing
        Me.txtRFU3Date.Left = 6.5!
        Me.txtRFU3Date.Name = "txtRFU3Date"
        Me.txtRFU3Date.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtRFU3Date.Text = "RFU3Date"
        Me.txtRFU3Date.Top = 0.75!
        Me.txtRFU3Date.Width = 0.75!
        '
        'txtDivision
        '
        Me.txtDivision.DataField = "Division"
        Me.txtDivision.Height = 0.3!
        Me.txtDivision.HyperLink = Nothing
        Me.txtDivision.Left = 1.8!
        Me.txtDivision.Name = "txtDivision"
        Me.txtDivision.Style = "font-size: 8pt; font-weight: bold; vertical-align: middle"
        Me.txtDivision.Text = "Division"
        Me.txtDivision.Top = 0.0!
        Me.txtDivision.Width = 1.2!
        '
        'lblNoActiveRecs
        '
        Me.lblNoActiveRecs.Height = 0.15!
        Me.lblNoActiveRecs.HyperLink = Nothing
        Me.lblNoActiveRecs.Left = 1.85!
        Me.lblNoActiveRecs.Name = "lblNoActiveRecs"
        Me.lblNoActiveRecs.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblNoActiveRecs.Text = "No. of Active Recs."
        Me.lblNoActiveRecs.Top = 0.55!
        Me.lblNoActiveRecs.Width = 1.3!
        '
        'lblRespRequestDate
        '
        Me.lblRespRequestDate.Height = 0.15!
        Me.lblRespRequestDate.HyperLink = Nothing
        Me.lblRespRequestDate.Left = 3.55!
        Me.lblRespRequestDate.Name = "lblRespRequestDate"
        Me.lblRespRequestDate.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblRespRequestDate.Text = "Response Request Date"
        Me.lblRespRequestDate.Top = 0.35!
        Me.lblRespRequestDate.Width = 1.15!
        '
        'lblRecipientEmail
        '
        Me.lblRecipientEmail.Height = 0.15!
        Me.lblRecipientEmail.HyperLink = Nothing
        Me.lblRecipientEmail.Left = 7.3!
        Me.lblRecipientEmail.Name = "lblRecipientEmail"
        Me.lblRecipientEmail.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblRecipientEmail.Text = "Recipient Email"
        Me.lblRecipientEmail.Top = 0.55!
        Me.lblRecipientEmail.Width = 0.85!
        '
        'lblRespDueDate
        '
        Me.lblRespDueDate.Height = 0.15!
        Me.lblRespDueDate.HyperLink = Nothing
        Me.lblRespDueDate.Left = 3.55!
        Me.lblRespDueDate.Name = "lblRespDueDate"
        Me.lblRespDueDate.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblRespDueDate.Text = "Response Due Date"
        Me.lblRespDueDate.Top = 0.55!
        Me.lblRespDueDate.Width = 1.15!
        '
        'lblNoRecsNeedingResp
        '
        Me.lblNoRecsNeedingResp.Height = 0.15!
        Me.lblNoRecsNeedingResp.HyperLink = Nothing
        Me.lblNoRecsNeedingResp.Left = 1.85!
        Me.lblNoRecsNeedingResp.Name = "lblNoRecsNeedingResp"
        Me.lblNoRecsNeedingResp.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblNoRecsNeedingResp.Text = "No. of Recs. Needing Resp."
        Me.lblNoRecsNeedingResp.Top = 0.75!
        Me.lblNoRecsNeedingResp.Width = 1.3!
        '
        'lblRFU2Date
        '
        Me.lblRFU2Date.Height = 0.15!
        Me.lblRFU2Date.HyperLink = Nothing
        Me.lblRFU2Date.Left = 5.55!
        Me.lblRFU2Date.Name = "lblRFU2Date"
        Me.lblRFU2Date.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblRFU2Date.Text = "2nd Follow-Up"
        Me.lblRFU2Date.Top = 0.55!
        Me.lblRFU2Date.Width = 0.9!
        '
        'txtNoRecsNeedingResp
        '
        Me.txtNoRecsNeedingResp.DataField = "NoRecsNeedingResp"
        Me.txtNoRecsNeedingResp.Height = 0.15!
        Me.txtNoRecsNeedingResp.HyperLink = Nothing
        Me.txtNoRecsNeedingResp.Left = 3.2!
        Me.txtNoRecsNeedingResp.Name = "txtNoRecsNeedingResp"
        Me.txtNoRecsNeedingResp.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtNoRecsNeedingResp.Text = "NoRecsNeedingResp"
        Me.txtNoRecsNeedingResp.Top = 0.75!
        Me.txtNoRecsNeedingResp.Width = 0.3!
        '
        'txtRFU2Date
        '
        Me.txtRFU2Date.DataField = "RFU2DateString"
        Me.txtRFU2Date.Height = 0.15!
        Me.txtRFU2Date.HyperLink = Nothing
        Me.txtRFU2Date.Left = 6.5!
        Me.txtRFU2Date.Name = "txtRFU2Date"
        Me.txtRFU2Date.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtRFU2Date.Text = "RFU2Date"
        Me.txtRFU2Date.Top = 0.55!
        Me.txtRFU2Date.Width = 0.75!
        '
        'lnRecipientEmailLeft
        '
        Me.lnRecipientEmailLeft.Height = 0.15!
        Me.lnRecipientEmailLeft.Left = 8.2!
        Me.lnRecipientEmailLeft.LineWeight = 1.0!
        Me.lnRecipientEmailLeft.Name = "lnRecipientEmailLeft"
        Me.lnRecipientEmailLeft.Top = 0.55!
        Me.lnRecipientEmailLeft.Width = 0.0!
        Me.lnRecipientEmailLeft.X1 = 8.2!
        Me.lnRecipientEmailLeft.X2 = 8.2!
        Me.lnRecipientEmailLeft.Y1 = 0.55!
        Me.lnRecipientEmailLeft.Y2 = 0.7!
        '
        'lnRecipientEmailTop
        '
        Me.lnRecipientEmailTop.Height = 0.0!
        Me.lnRecipientEmailTop.Left = 8.2!
        Me.lnRecipientEmailTop.LineWeight = 1.0!
        Me.lnRecipientEmailTop.Name = "lnRecipientEmailTop"
        Me.lnRecipientEmailTop.Top = 0.55!
        Me.lnRecipientEmailTop.Width = 1.75!
        Me.lnRecipientEmailTop.X1 = 8.2!
        Me.lnRecipientEmailTop.X2 = 9.95!
        Me.lnRecipientEmailTop.Y1 = 0.55!
        Me.lnRecipientEmailTop.Y2 = 0.55!
        '
        'lblDaysOverdue
        '
        Me.lblDaysOverdue.Height = 0.15!
        Me.lblDaysOverdue.HyperLink = Nothing
        Me.lblDaysOverdue.Left = 3.55!
        Me.lblDaysOverdue.Name = "lblDaysOverdue"
        Me.lblDaysOverdue.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblDaysOverdue.Text = "Days Overdue"
        Me.lblDaysOverdue.Top = 0.75!
        Me.lblDaysOverdue.Width = 1.15!
        '
        'lblRFU3Date
        '
        Me.lblRFU3Date.Height = 0.15!
        Me.lblRFU3Date.HyperLink = Nothing
        Me.lblRFU3Date.Left = 5.55!
        Me.lblRFU3Date.Name = "lblRFU3Date"
        Me.lblRFU3Date.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblRFU3Date.Text = "3rd Follow-Up"
        Me.lblRFU3Date.Top = 0.75!
        Me.lblRFU3Date.Width = 0.9!
        '
        'lblRFU1Date
        '
        Me.lblRFU1Date.Height = 0.15!
        Me.lblRFU1Date.HyperLink = Nothing
        Me.lblRFU1Date.Left = 5.55!
        Me.lblRFU1Date.Name = "lblRFU1Date"
        Me.lblRFU1Date.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblRFU1Date.Text = "1st Follow-Up"
        Me.lblRFU1Date.Top = 0.35!
        Me.lblRFU1Date.Width = 0.9!
        '
        'lblRecipientName
        '
        Me.lblRecipientName.Height = 0.15!
        Me.lblRecipientName.HyperLink = Nothing
        Me.lblRecipientName.Left = 7.3!
        Me.lblRecipientName.Name = "lblRecipientName"
        Me.lblRecipientName.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblRecipientName.Text = "Recipient's Name"
        Me.lblRecipientName.Top = 0.35!
        Me.lblRecipientName.Width = 0.85!
        '
        'txtClientLocNo
        '
        Me.txtClientLocNo.DataField = "ClientLocNo"
        Me.txtClientLocNo.Height = 0.3!
        Me.txtClientLocNo.HyperLink = Nothing
        Me.txtClientLocNo.Left = 0.9!
        Me.txtClientLocNo.Name = "txtClientLocNo"
        Me.txtClientLocNo.Style = "font-size: 8pt; font-weight: bold; vertical-align: middle"
        Me.txtClientLocNo.Text = "Client Loc No"
        Me.txtClientLocNo.Top = 0.0!
        Me.txtClientLocNo.Width = 0.85!
        '
        'txtTIV
        '
        Me.txtTIV.DataField = "TIV"
        Me.txtTIV.Height = 0.3!
        Me.txtTIV.HyperLink = Nothing
        Me.txtTIV.Left = 9.4!
        Me.txtTIV.Name = "txtTIV"
        Me.txtTIV.Style = "font-size: 8pt; font-weight: bold; text-align: center; vertical-align: middle"
        Me.txtTIV.Text = "0"
        Me.txtTIV.Top = 0.0!
        Me.txtTIV.Width = 0.6!
        '
        'txtFacility
        '
        Me.txtFacility.DataField = "Facility"
        Me.txtFacility.Height = 0.3!
        Me.txtFacility.HyperLink = Nothing
        Me.txtFacility.Left = 3.05!
        Me.txtFacility.Name = "txtFacility"
        Me.txtFacility.Style = "font-size: 8pt; font-weight: bold; vertical-align: middle"
        Me.txtFacility.Text = "Facility"
        Me.txtFacility.Top = 0.0!
        Me.txtFacility.Width = 1.2!
        '
        'lnRespRequestDateLeft
        '
        Me.lnRespRequestDateLeft.Height = 0.15!
        Me.lnRespRequestDateLeft.Left = 4.75!
        Me.lnRespRequestDateLeft.LineWeight = 1.0!
        Me.lnRespRequestDateLeft.Name = "lnRespRequestDateLeft"
        Me.lnRespRequestDateLeft.Top = 0.35!
        Me.lnRespRequestDateLeft.Width = 0.0!
        Me.lnRespRequestDateLeft.X1 = 4.75!
        Me.lnRespRequestDateLeft.X2 = 4.75!
        Me.lnRespRequestDateLeft.Y1 = 0.35!
        Me.lnRespRequestDateLeft.Y2 = 0.5!
        '
        'lnRespRequestDateRight
        '
        Me.lnRespRequestDateRight.Height = 0.15!
        Me.lnRespRequestDateRight.Left = 5.5!
        Me.lnRespRequestDateRight.LineWeight = 1.0!
        Me.lnRespRequestDateRight.Name = "lnRespRequestDateRight"
        Me.lnRespRequestDateRight.Top = 0.35!
        Me.lnRespRequestDateRight.Width = 0.0!
        Me.lnRespRequestDateRight.X1 = 5.5!
        Me.lnRespRequestDateRight.X2 = 5.5!
        Me.lnRespRequestDateRight.Y1 = 0.35!
        Me.lnRespRequestDateRight.Y2 = 0.5!
        '
        'lnRespRequestDateTop
        '
        Me.lnRespRequestDateTop.Height = 0.0!
        Me.lnRespRequestDateTop.Left = 4.75!
        Me.lnRespRequestDateTop.LineWeight = 1.0!
        Me.lnRespRequestDateTop.Name = "lnRespRequestDateTop"
        Me.lnRespRequestDateTop.Top = 0.35!
        Me.lnRespRequestDateTop.Width = 0.75!
        Me.lnRespRequestDateTop.X1 = 4.75!
        Me.lnRespRequestDateTop.X2 = 5.5!
        Me.lnRespRequestDateTop.Y1 = 0.35!
        Me.lnRespRequestDateTop.Y2 = 0.35!
        '
        'lnRespRequestDateBottom
        '
        Me.lnRespRequestDateBottom.Height = 0.0!
        Me.lnRespRequestDateBottom.Left = 4.75!
        Me.lnRespRequestDateBottom.LineWeight = 1.0!
        Me.lnRespRequestDateBottom.Name = "lnRespRequestDateBottom"
        Me.lnRespRequestDateBottom.Top = 0.5!
        Me.lnRespRequestDateBottom.Width = 0.75!
        Me.lnRespRequestDateBottom.X1 = 4.75!
        Me.lnRespRequestDateBottom.X2 = 5.5!
        Me.lnRespRequestDateBottom.Y1 = 0.5!
        Me.lnRespRequestDateBottom.Y2 = 0.5!
        '
        'lnDaysOverdueTop
        '
        Me.lnDaysOverdueTop.Height = 0.0!
        Me.lnDaysOverdueTop.Left = 4.75!
        Me.lnDaysOverdueTop.LineWeight = 1.0!
        Me.lnDaysOverdueTop.Name = "lnDaysOverdueTop"
        Me.lnDaysOverdueTop.Top = 0.75!
        Me.lnDaysOverdueTop.Width = 0.75!
        Me.lnDaysOverdueTop.X1 = 4.75!
        Me.lnDaysOverdueTop.X2 = 5.5!
        Me.lnDaysOverdueTop.Y1 = 0.75!
        Me.lnDaysOverdueTop.Y2 = 0.75!
        '
        'lnRespDueDateTop
        '
        Me.lnRespDueDateTop.Height = 0.0!
        Me.lnRespDueDateTop.Left = 4.75!
        Me.lnRespDueDateTop.LineWeight = 1.0!
        Me.lnRespDueDateTop.Name = "lnRespDueDateTop"
        Me.lnRespDueDateTop.Top = 0.55!
        Me.lnRespDueDateTop.Width = 0.75!
        Me.lnRespDueDateTop.X1 = 4.75!
        Me.lnRespDueDateTop.X2 = 5.5!
        Me.lnRespDueDateTop.Y1 = 0.55!
        Me.lnRespDueDateTop.Y2 = 0.55!
        '
        'lnRespDueDateBottom
        '
        Me.lnRespDueDateBottom.Height = 0.0!
        Me.lnRespDueDateBottom.Left = 4.75!
        Me.lnRespDueDateBottom.LineWeight = 1.0!
        Me.lnRespDueDateBottom.Name = "lnRespDueDateBottom"
        Me.lnRespDueDateBottom.Top = 0.7!
        Me.lnRespDueDateBottom.Width = 0.75!
        Me.lnRespDueDateBottom.X1 = 4.75!
        Me.lnRespDueDateBottom.X2 = 5.5!
        Me.lnRespDueDateBottom.Y1 = 0.7!
        Me.lnRespDueDateBottom.Y2 = 0.7!
        '
        'lnDaysOverdueBottom
        '
        Me.lnDaysOverdueBottom.Height = 0.0!
        Me.lnDaysOverdueBottom.Left = 4.75!
        Me.lnDaysOverdueBottom.LineWeight = 1.0!
        Me.lnDaysOverdueBottom.Name = "lnDaysOverdueBottom"
        Me.lnDaysOverdueBottom.Top = 0.9!
        Me.lnDaysOverdueBottom.Width = 0.75!
        Me.lnDaysOverdueBottom.X1 = 4.75!
        Me.lnDaysOverdueBottom.X2 = 5.5!
        Me.lnDaysOverdueBottom.Y1 = 0.9!
        Me.lnDaysOverdueBottom.Y2 = 0.9!
        '
        'lnRespDueDateLeft
        '
        Me.lnRespDueDateLeft.Height = 0.15!
        Me.lnRespDueDateLeft.Left = 4.75!
        Me.lnRespDueDateLeft.LineWeight = 1.0!
        Me.lnRespDueDateLeft.Name = "lnRespDueDateLeft"
        Me.lnRespDueDateLeft.Top = 0.55!
        Me.lnRespDueDateLeft.Width = 0.0!
        Me.lnRespDueDateLeft.X1 = 4.75!
        Me.lnRespDueDateLeft.X2 = 4.75!
        Me.lnRespDueDateLeft.Y1 = 0.55!
        Me.lnRespDueDateLeft.Y2 = 0.7!
        '
        'lnRespDueDateRight
        '
        Me.lnRespDueDateRight.Height = 0.15!
        Me.lnRespDueDateRight.Left = 5.5!
        Me.lnRespDueDateRight.LineWeight = 1.0!
        Me.lnRespDueDateRight.Name = "lnRespDueDateRight"
        Me.lnRespDueDateRight.Top = 0.55!
        Me.lnRespDueDateRight.Width = 0.0!
        Me.lnRespDueDateRight.X1 = 5.5!
        Me.lnRespDueDateRight.X2 = 5.5!
        Me.lnRespDueDateRight.Y1 = 0.55!
        Me.lnRespDueDateRight.Y2 = 0.7!
        '
        'lnDaysOverdueLeft
        '
        Me.lnDaysOverdueLeft.Height = 0.15!
        Me.lnDaysOverdueLeft.Left = 4.75!
        Me.lnDaysOverdueLeft.LineWeight = 1.0!
        Me.lnDaysOverdueLeft.Name = "lnDaysOverdueLeft"
        Me.lnDaysOverdueLeft.Top = 0.75!
        Me.lnDaysOverdueLeft.Width = 0.0!
        Me.lnDaysOverdueLeft.X1 = 4.75!
        Me.lnDaysOverdueLeft.X2 = 4.75!
        Me.lnDaysOverdueLeft.Y1 = 0.75!
        Me.lnDaysOverdueLeft.Y2 = 0.9!
        '
        'lnDaysOverdueRight
        '
        Me.lnDaysOverdueRight.Height = 0.15!
        Me.lnDaysOverdueRight.Left = 5.5!
        Me.lnDaysOverdueRight.LineWeight = 1.0!
        Me.lnDaysOverdueRight.Name = "lnDaysOverdueRight"
        Me.lnDaysOverdueRight.Top = 0.75!
        Me.lnDaysOverdueRight.Width = 0.0!
        Me.lnDaysOverdueRight.X1 = 5.5!
        Me.lnDaysOverdueRight.X2 = 5.5!
        Me.lnDaysOverdueRight.Y1 = 0.75!
        Me.lnDaysOverdueRight.Y2 = 0.9!
        '
        'lnRFU3DateBottom
        '
        Me.lnRFU3DateBottom.Height = 0.0!
        Me.lnRFU3DateBottom.Left = 6.5!
        Me.lnRFU3DateBottom.LineWeight = 1.0!
        Me.lnRFU3DateBottom.Name = "lnRFU3DateBottom"
        Me.lnRFU3DateBottom.Top = 0.9!
        Me.lnRFU3DateBottom.Width = 0.75!
        Me.lnRFU3DateBottom.X1 = 6.5!
        Me.lnRFU3DateBottom.X2 = 7.25!
        Me.lnRFU3DateBottom.Y1 = 0.9!
        Me.lnRFU3DateBottom.Y2 = 0.9!
        '
        'lnRFU1DateTop
        '
        Me.lnRFU1DateTop.Height = 0.0!
        Me.lnRFU1DateTop.Left = 6.5!
        Me.lnRFU1DateTop.LineWeight = 1.0!
        Me.lnRFU1DateTop.Name = "lnRFU1DateTop"
        Me.lnRFU1DateTop.Top = 0.35!
        Me.lnRFU1DateTop.Width = 0.75!
        Me.lnRFU1DateTop.X1 = 6.5!
        Me.lnRFU1DateTop.X2 = 7.25!
        Me.lnRFU1DateTop.Y1 = 0.35!
        Me.lnRFU1DateTop.Y2 = 0.35!
        '
        'lnRFU1DateBottom
        '
        Me.lnRFU1DateBottom.Height = 0.0!
        Me.lnRFU1DateBottom.Left = 6.5!
        Me.lnRFU1DateBottom.LineWeight = 1.0!
        Me.lnRFU1DateBottom.Name = "lnRFU1DateBottom"
        Me.lnRFU1DateBottom.Top = 0.5!
        Me.lnRFU1DateBottom.Width = 0.75!
        Me.lnRFU1DateBottom.X1 = 6.5!
        Me.lnRFU1DateBottom.X2 = 7.25!
        Me.lnRFU1DateBottom.Y1 = 0.5!
        Me.lnRFU1DateBottom.Y2 = 0.5!
        '
        'lnRFU2DateTop
        '
        Me.lnRFU2DateTop.Height = 0.0!
        Me.lnRFU2DateTop.Left = 6.5!
        Me.lnRFU2DateTop.LineWeight = 1.0!
        Me.lnRFU2DateTop.Name = "lnRFU2DateTop"
        Me.lnRFU2DateTop.Top = 0.55!
        Me.lnRFU2DateTop.Width = 0.75!
        Me.lnRFU2DateTop.X1 = 6.5!
        Me.lnRFU2DateTop.X2 = 7.25!
        Me.lnRFU2DateTop.Y1 = 0.55!
        Me.lnRFU2DateTop.Y2 = 0.55!
        '
        'lnRecipientNameRight
        '
        Me.lnRecipientNameRight.Height = 0.15!
        Me.lnRecipientNameRight.Left = 9.95!
        Me.lnRecipientNameRight.LineWeight = 1.0!
        Me.lnRecipientNameRight.Name = "lnRecipientNameRight"
        Me.lnRecipientNameRight.Top = 0.35!
        Me.lnRecipientNameRight.Width = 0.0!
        Me.lnRecipientNameRight.X1 = 9.95!
        Me.lnRecipientNameRight.X2 = 9.95!
        Me.lnRecipientNameRight.Y1 = 0.35!
        Me.lnRecipientNameRight.Y2 = 0.5!
        '
        'lnRFU2DateLeft
        '
        Me.lnRFU2DateLeft.Height = 0.15!
        Me.lnRFU2DateLeft.Left = 6.5!
        Me.lnRFU2DateLeft.LineWeight = 1.0!
        Me.lnRFU2DateLeft.Name = "lnRFU2DateLeft"
        Me.lnRFU2DateLeft.Top = 0.55!
        Me.lnRFU2DateLeft.Width = 0.0!
        Me.lnRFU2DateLeft.X1 = 6.5!
        Me.lnRFU2DateLeft.X2 = 6.5!
        Me.lnRFU2DateLeft.Y1 = 0.55!
        Me.lnRFU2DateLeft.Y2 = 0.7!
        '
        'lnRFU3DateLeft
        '
        Me.lnRFU3DateLeft.Height = 0.15!
        Me.lnRFU3DateLeft.Left = 6.5!
        Me.lnRFU3DateLeft.LineWeight = 1.0!
        Me.lnRFU3DateLeft.Name = "lnRFU3DateLeft"
        Me.lnRFU3DateLeft.Top = 0.75!
        Me.lnRFU3DateLeft.Width = 0.0!
        Me.lnRFU3DateLeft.X1 = 6.5!
        Me.lnRFU3DateLeft.X2 = 6.5!
        Me.lnRFU3DateLeft.Y1 = 0.75!
        Me.lnRFU3DateLeft.Y2 = 0.9!
        '
        'lnRFU2DateBottom
        '
        Me.lnRFU2DateBottom.Height = 0.0!
        Me.lnRFU2DateBottom.Left = 6.5!
        Me.lnRFU2DateBottom.LineWeight = 1.0!
        Me.lnRFU2DateBottom.Name = "lnRFU2DateBottom"
        Me.lnRFU2DateBottom.Top = 0.7!
        Me.lnRFU2DateBottom.Width = 0.75!
        Me.lnRFU2DateBottom.X1 = 6.5!
        Me.lnRFU2DateBottom.X2 = 7.25!
        Me.lnRFU2DateBottom.Y1 = 0.7!
        Me.lnRFU2DateBottom.Y2 = 0.7!
        '
        'lnRecipientNameLeft
        '
        Me.lnRecipientNameLeft.Height = 0.15!
        Me.lnRecipientNameLeft.Left = 8.2!
        Me.lnRecipientNameLeft.LineWeight = 1.0!
        Me.lnRecipientNameLeft.Name = "lnRecipientNameLeft"
        Me.lnRecipientNameLeft.Top = 0.35!
        Me.lnRecipientNameLeft.Width = 0.0!
        Me.lnRecipientNameLeft.X1 = 8.2!
        Me.lnRecipientNameLeft.X2 = 8.2!
        Me.lnRecipientNameLeft.Y1 = 0.35!
        Me.lnRecipientNameLeft.Y2 = 0.5!
        '
        'lnRFU1DateLeft
        '
        Me.lnRFU1DateLeft.Height = 0.15!
        Me.lnRFU1DateLeft.Left = 6.5!
        Me.lnRFU1DateLeft.LineWeight = 1.0!
        Me.lnRFU1DateLeft.Name = "lnRFU1DateLeft"
        Me.lnRFU1DateLeft.Top = 0.35!
        Me.lnRFU1DateLeft.Width = 0.0!
        Me.lnRFU1DateLeft.X1 = 6.5!
        Me.lnRFU1DateLeft.X2 = 6.5!
        Me.lnRFU1DateLeft.Y1 = 0.35!
        Me.lnRFU1DateLeft.Y2 = 0.5!
        '
        'lnNoActiveRecsTop
        '
        Me.lnNoActiveRecsTop.Height = 0.0!
        Me.lnNoActiveRecsTop.Left = 3.2!
        Me.lnNoActiveRecsTop.LineWeight = 1.0!
        Me.lnNoActiveRecsTop.Name = "lnNoActiveRecsTop"
        Me.lnNoActiveRecsTop.Top = 0.55!
        Me.lnNoActiveRecsTop.Width = 0.3!
        Me.lnNoActiveRecsTop.X1 = 3.2!
        Me.lnNoActiveRecsTop.X2 = 3.5!
        Me.lnNoActiveRecsTop.Y1 = 0.55!
        Me.lnNoActiveRecsTop.Y2 = 0.55!
        '
        'lnNoActiveRecsBottom
        '
        Me.lnNoActiveRecsBottom.Height = 0.0!
        Me.lnNoActiveRecsBottom.Left = 3.2!
        Me.lnNoActiveRecsBottom.LineWeight = 1.0!
        Me.lnNoActiveRecsBottom.Name = "lnNoActiveRecsBottom"
        Me.lnNoActiveRecsBottom.Top = 0.7!
        Me.lnNoActiveRecsBottom.Width = 0.3!
        Me.lnNoActiveRecsBottom.X1 = 3.2!
        Me.lnNoActiveRecsBottom.X2 = 3.5!
        Me.lnNoActiveRecsBottom.Y1 = 0.7!
        Me.lnNoActiveRecsBottom.Y2 = 0.7!
        '
        'lnNoRecsNeedingRespTop
        '
        Me.lnNoRecsNeedingRespTop.Height = 0.0!
        Me.lnNoRecsNeedingRespTop.Left = 3.2!
        Me.lnNoRecsNeedingRespTop.LineWeight = 1.0!
        Me.lnNoRecsNeedingRespTop.Name = "lnNoRecsNeedingRespTop"
        Me.lnNoRecsNeedingRespTop.Top = 0.75!
        Me.lnNoRecsNeedingRespTop.Width = 0.3!
        Me.lnNoRecsNeedingRespTop.X1 = 3.2!
        Me.lnNoRecsNeedingRespTop.X2 = 3.5!
        Me.lnNoRecsNeedingRespTop.Y1 = 0.75!
        Me.lnNoRecsNeedingRespTop.Y2 = 0.75!
        '
        'lnNoRecsNeedingRespRight
        '
        Me.lnNoRecsNeedingRespRight.Height = 0.15!
        Me.lnNoRecsNeedingRespRight.Left = 3.5!
        Me.lnNoRecsNeedingRespRight.LineWeight = 1.0!
        Me.lnNoRecsNeedingRespRight.Name = "lnNoRecsNeedingRespRight"
        Me.lnNoRecsNeedingRespRight.Top = 0.75!
        Me.lnNoRecsNeedingRespRight.Width = 0.0!
        Me.lnNoRecsNeedingRespRight.X1 = 3.5!
        Me.lnNoRecsNeedingRespRight.X2 = 3.5!
        Me.lnNoRecsNeedingRespRight.Y1 = 0.75!
        Me.lnNoRecsNeedingRespRight.Y2 = 0.9!
        '
        'lnNoRecsNeedingRespLeft
        '
        Me.lnNoRecsNeedingRespLeft.Height = 0.15!
        Me.lnNoRecsNeedingRespLeft.Left = 3.2!
        Me.lnNoRecsNeedingRespLeft.LineWeight = 1.0!
        Me.lnNoRecsNeedingRespLeft.Name = "lnNoRecsNeedingRespLeft"
        Me.lnNoRecsNeedingRespLeft.Top = 0.75!
        Me.lnNoRecsNeedingRespLeft.Width = 0.0!
        Me.lnNoRecsNeedingRespLeft.X1 = 3.2!
        Me.lnNoRecsNeedingRespLeft.X2 = 3.2!
        Me.lnNoRecsNeedingRespLeft.Y1 = 0.75!
        Me.lnNoRecsNeedingRespLeft.Y2 = 0.9!
        '
        'lnNoRecsNeedingRespBottom
        '
        Me.lnNoRecsNeedingRespBottom.Height = 0.0!
        Me.lnNoRecsNeedingRespBottom.Left = 3.2!
        Me.lnNoRecsNeedingRespBottom.LineWeight = 1.0!
        Me.lnNoRecsNeedingRespBottom.Name = "lnNoRecsNeedingRespBottom"
        Me.lnNoRecsNeedingRespBottom.Top = 0.9!
        Me.lnNoRecsNeedingRespBottom.Width = 0.3!
        Me.lnNoRecsNeedingRespBottom.X1 = 3.2!
        Me.lnNoRecsNeedingRespBottom.X2 = 3.5!
        Me.lnNoRecsNeedingRespBottom.Y1 = 0.9!
        Me.lnNoRecsNeedingRespBottom.Y2 = 0.9!
        '
        'lnRFU3DateTop
        '
        Me.lnRFU3DateTop.Height = 0.0!
        Me.lnRFU3DateTop.Left = 6.5!
        Me.lnRFU3DateTop.LineWeight = 1.0!
        Me.lnRFU3DateTop.Name = "lnRFU3DateTop"
        Me.lnRFU3DateTop.Top = 0.75!
        Me.lnRFU3DateTop.Width = 0.75!
        Me.lnRFU3DateTop.X1 = 6.5!
        Me.lnRFU3DateTop.X2 = 7.25!
        Me.lnRFU3DateTop.Y1 = 0.75!
        Me.lnRFU3DateTop.Y2 = 0.75!
        '
        'lnNoActiveRecsRight
        '
        Me.lnNoActiveRecsRight.Height = 0.15!
        Me.lnNoActiveRecsRight.Left = 3.5!
        Me.lnNoActiveRecsRight.LineWeight = 1.0!
        Me.lnNoActiveRecsRight.Name = "lnNoActiveRecsRight"
        Me.lnNoActiveRecsRight.Top = 0.55!
        Me.lnNoActiveRecsRight.Width = 0.0!
        Me.lnNoActiveRecsRight.X1 = 3.5!
        Me.lnNoActiveRecsRight.X2 = 3.5!
        Me.lnNoActiveRecsRight.Y1 = 0.55!
        Me.lnNoActiveRecsRight.Y2 = 0.7!
        '
        'lnRFU1DateRight
        '
        Me.lnRFU1DateRight.Height = 0.15!
        Me.lnRFU1DateRight.Left = 7.25!
        Me.lnRFU1DateRight.LineWeight = 1.0!
        Me.lnRFU1DateRight.Name = "lnRFU1DateRight"
        Me.lnRFU1DateRight.Top = 0.35!
        Me.lnRFU1DateRight.Width = 0.0!
        Me.lnRFU1DateRight.X1 = 7.25!
        Me.lnRFU1DateRight.X2 = 7.25!
        Me.lnRFU1DateRight.Y1 = 0.35!
        Me.lnRFU1DateRight.Y2 = 0.5!
        '
        'lnRFU2DateRight
        '
        Me.lnRFU2DateRight.Height = 0.15!
        Me.lnRFU2DateRight.Left = 7.25!
        Me.lnRFU2DateRight.LineWeight = 1.0!
        Me.lnRFU2DateRight.Name = "lnRFU2DateRight"
        Me.lnRFU2DateRight.Top = 0.55!
        Me.lnRFU2DateRight.Width = 0.0!
        Me.lnRFU2DateRight.X1 = 7.25!
        Me.lnRFU2DateRight.X2 = 7.25!
        Me.lnRFU2DateRight.Y1 = 0.55!
        Me.lnRFU2DateRight.Y2 = 0.7!
        '
        'lnRFU3DateRight
        '
        Me.lnRFU3DateRight.Height = 0.125!
        Me.lnRFU3DateRight.Left = 7.25!
        Me.lnRFU3DateRight.LineWeight = 1.0!
        Me.lnRFU3DateRight.Name = "lnRFU3DateRight"
        Me.lnRFU3DateRight.Top = 0.75!
        Me.lnRFU3DateRight.Width = 0.0!
        Me.lnRFU3DateRight.X1 = 7.25!
        Me.lnRFU3DateRight.X2 = 7.25!
        Me.lnRFU3DateRight.Y1 = 0.75!
        Me.lnRFU3DateRight.Y2 = 0.875!
        '
        'lnRecipientNameTop
        '
        Me.lnRecipientNameTop.Height = 0.0!
        Me.lnRecipientNameTop.Left = 8.2!
        Me.lnRecipientNameTop.LineWeight = 1.0!
        Me.lnRecipientNameTop.Name = "lnRecipientNameTop"
        Me.lnRecipientNameTop.Top = 0.35!
        Me.lnRecipientNameTop.Width = 1.75!
        Me.lnRecipientNameTop.X1 = 8.2!
        Me.lnRecipientNameTop.X2 = 9.95!
        Me.lnRecipientNameTop.Y1 = 0.35!
        Me.lnRecipientNameTop.Y2 = 0.35!
        '
        'lnRecipientNameBottom
        '
        Me.lnRecipientNameBottom.Height = 0.0!
        Me.lnRecipientNameBottom.Left = 8.2!
        Me.lnRecipientNameBottom.LineWeight = 1.0!
        Me.lnRecipientNameBottom.Name = "lnRecipientNameBottom"
        Me.lnRecipientNameBottom.Top = 0.5!
        Me.lnRecipientNameBottom.Width = 1.75!
        Me.lnRecipientNameBottom.X1 = 8.2!
        Me.lnRecipientNameBottom.X2 = 9.95!
        Me.lnRecipientNameBottom.Y1 = 0.5!
        Me.lnRecipientNameBottom.Y2 = 0.5!
        '
        'lnRecipientEmailBottom
        '
        Me.lnRecipientEmailBottom.Height = 0.0!
        Me.lnRecipientEmailBottom.Left = 8.2!
        Me.lnRecipientEmailBottom.LineWeight = 1.0!
        Me.lnRecipientEmailBottom.Name = "lnRecipientEmailBottom"
        Me.lnRecipientEmailBottom.Top = 0.7!
        Me.lnRecipientEmailBottom.Width = 1.75!
        Me.lnRecipientEmailBottom.X1 = 8.2!
        Me.lnRecipientEmailBottom.X2 = 9.95!
        Me.lnRecipientEmailBottom.Y1 = 0.7!
        Me.lnRecipientEmailBottom.Y2 = 0.7!
        '
        'txtStProv
        '
        Me.txtStProv.DataField = "StProv"
        Me.txtStProv.Height = 0.3!
        Me.txtStProv.HyperLink = Nothing
        Me.txtStProv.Left = 8.1!
        Me.txtStProv.Name = "txtStProv"
        Me.txtStProv.Style = "font-size: 8pt; font-weight: bold; vertical-align: middle"
        Me.txtStProv.Text = "St/Prov"
        Me.txtStProv.Top = 0.0!
        Me.txtStProv.Width = 0.45!
        '
        'lnDetailBottom
        '
        Me.lnDetailBottom.Height = 0.0!
        Me.lnDetailBottom.Left = 0.0!
        Me.lnDetailBottom.LineWeight = 1.0!
        Me.lnDetailBottom.Name = "lnDetailBottom"
        Me.lnDetailBottom.Top = 0.95!
        Me.lnDetailBottom.Width = 10.0!
        Me.lnDetailBottom.X1 = 0.0!
        Me.lnDetailBottom.X2 = 10.0!
        Me.lnDetailBottom.Y1 = 0.95!
        Me.lnDetailBottom.Y2 = 0.95!
        '
        'lnDetailTop
        '
        Me.lnDetailTop.Height = 0.0!
        Me.lnDetailTop.Left = 0.0!
        Me.lnDetailTop.LineWeight = 1.0!
        Me.lnDetailTop.Name = "lnDetailTop"
        Me.lnDetailTop.Top = 0.0!
        Me.lnDetailTop.Width = 10.0!
        Me.lnDetailTop.X1 = 0.0!
        Me.lnDetailTop.X2 = 10.0!
        Me.lnDetailTop.Y1 = 0.0!
        Me.lnDetailTop.Y2 = 0.0!
        '
        'lnDetailLeft
        '
        Me.lnDetailLeft.Height = 0.95!
        Me.lnDetailLeft.Left = 0.0!
        Me.lnDetailLeft.LineWeight = 1.0!
        Me.lnDetailLeft.Name = "lnDetailLeft"
        Me.lnDetailLeft.Top = 0.0!
        Me.lnDetailLeft.Width = 0.0!
        Me.lnDetailLeft.X1 = 0.0!
        Me.lnDetailLeft.X2 = 0.0!
        Me.lnDetailLeft.Y1 = 0.0!
        Me.lnDetailLeft.Y2 = 0.95!
        '
        'lnRecipientEmailRight
        '
        Me.lnRecipientEmailRight.Height = 0.15!
        Me.lnRecipientEmailRight.Left = 9.95!
        Me.lnRecipientEmailRight.LineWeight = 1.0!
        Me.lnRecipientEmailRight.Name = "lnRecipientEmailRight"
        Me.lnRecipientEmailRight.Top = 0.55!
        Me.lnRecipientEmailRight.Width = 0.0!
        Me.lnRecipientEmailRight.X1 = 9.95!
        Me.lnRecipientEmailRight.X2 = 9.95!
        Me.lnRecipientEmailRight.Y1 = 0.55!
        Me.lnRecipientEmailRight.Y2 = 0.7!
        '
        'lnNoActiveRecsLeft
        '
        Me.lnNoActiveRecsLeft.Height = 0.15!
        Me.lnNoActiveRecsLeft.Left = 3.2!
        Me.lnNoActiveRecsLeft.LineWeight = 1.0!
        Me.lnNoActiveRecsLeft.Name = "lnNoActiveRecsLeft"
        Me.lnNoActiveRecsLeft.Top = 0.55!
        Me.lnNoActiveRecsLeft.Width = 0.0!
        Me.lnNoActiveRecsLeft.X1 = 3.2!
        Me.lnNoActiveRecsLeft.X2 = 3.2!
        Me.lnNoActiveRecsLeft.Y1 = 0.55!
        Me.lnNoActiveRecsLeft.Y2 = 0.7!
        '
        'line3
        '
        Me.line3.Height = 0.0!
        Me.line3.Left = 0.0!
        Me.line3.LineWeight = 1.0!
        Me.line3.Name = "line3"
        Me.line3.Top = 0.0!
        Me.line3.Width = 10.0!
        Me.line3.X1 = 0.0!
        Me.line3.X2 = 10.0!
        Me.line3.Y1 = 0.0!
        Me.line3.Y2 = 0.0!
        '
        'lnDetailRight
        '
        Me.lnDetailRight.Height = 0.95!
        Me.lnDetailRight.Left = 10.0!
        Me.lnDetailRight.LineWeight = 1.0!
        Me.lnDetailRight.Name = "lnDetailRight"
        Me.lnDetailRight.Top = 0.0!
        Me.lnDetailRight.Width = 0.0!
        Me.lnDetailRight.X1 = 10.0!
        Me.lnDetailRight.X2 = 10.0!
        Me.lnDetailRight.Y1 = 0.0!
        Me.lnDetailRight.Y2 = 0.95!
        '
        'txtResponseStatus
        '
        Me.txtResponseStatus.DataField = "ResponseStatus"
        Me.txtResponseStatus.Height = 0.15!
        Me.txtResponseStatus.HyperLink = Nothing
        Me.txtResponseStatus.Left = 0.9!
        Me.txtResponseStatus.Name = "txtResponseStatus"
        Me.txtResponseStatus.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtResponseStatus.Text = "ResponseStatus"
        Me.txtResponseStatus.Top = 0.55!
        Me.txtResponseStatus.Width = 0.9!
        '
        'lnResponseStatusLeft
        '
        Me.lnResponseStatusLeft.Height = 0.15!
        Me.lnResponseStatusLeft.Left = 0.9!
        Me.lnResponseStatusLeft.LineWeight = 1.0!
        Me.lnResponseStatusLeft.Name = "lnResponseStatusLeft"
        Me.lnResponseStatusLeft.Top = 0.55!
        Me.lnResponseStatusLeft.Width = 0.0!
        Me.lnResponseStatusLeft.X1 = 0.9!
        Me.lnResponseStatusLeft.X2 = 0.9!
        Me.lnResponseStatusLeft.Y1 = 0.55!
        Me.lnResponseStatusLeft.Y2 = 0.7!
        '
        'lnResponseStatusBottom
        '
        Me.lnResponseStatusBottom.Height = 0.0!
        Me.lnResponseStatusBottom.Left = 0.9!
        Me.lnResponseStatusBottom.LineWeight = 1.0!
        Me.lnResponseStatusBottom.Name = "lnResponseStatusBottom"
        Me.lnResponseStatusBottom.Top = 0.7!
        Me.lnResponseStatusBottom.Width = 0.9!
        Me.lnResponseStatusBottom.X1 = 0.9!
        Me.lnResponseStatusBottom.X2 = 1.8!
        Me.lnResponseStatusBottom.Y1 = 0.7!
        Me.lnResponseStatusBottom.Y2 = 0.7!
        '
        'lnResponseStatusTop
        '
        Me.lnResponseStatusTop.Height = 0.0!
        Me.lnResponseStatusTop.Left = 0.9!
        Me.lnResponseStatusTop.LineWeight = 1.0!
        Me.lnResponseStatusTop.Name = "lnResponseStatusTop"
        Me.lnResponseStatusTop.Top = 0.55!
        Me.lnResponseStatusTop.Width = 0.9!
        Me.lnResponseStatusTop.X1 = 0.9!
        Me.lnResponseStatusTop.X2 = 1.8!
        Me.lnResponseStatusTop.Y1 = 0.55!
        Me.lnResponseStatusTop.Y2 = 0.55!
        '
        'lnResponseStatusRight
        '
        Me.lnResponseStatusRight.Height = 0.15!
        Me.lnResponseStatusRight.Left = 1.8!
        Me.lnResponseStatusRight.LineWeight = 1.0!
        Me.lnResponseStatusRight.Name = "lnResponseStatusRight"
        Me.lnResponseStatusRight.Top = 0.55!
        Me.lnResponseStatusRight.Width = 0.0!
        Me.lnResponseStatusRight.X1 = 1.8!
        Me.lnResponseStatusRight.X2 = 1.8!
        Me.lnResponseStatusRight.Y1 = 0.55!
        Me.lnResponseStatusRight.Y2 = 0.7!
        '
        'TotalNoRecsRight
        '
        Me.TotalNoRecsRight.Height = 0.15!
        Me.TotalNoRecsRight.Left = 3.5!
        Me.TotalNoRecsRight.LineWeight = 1.0!
        Me.TotalNoRecsRight.Name = "TotalNoRecsRight"
        Me.TotalNoRecsRight.Top = 0.35!
        Me.TotalNoRecsRight.Width = 0.0!
        Me.TotalNoRecsRight.X1 = 3.5!
        Me.TotalNoRecsRight.X2 = 3.5!
        Me.TotalNoRecsRight.Y1 = 0.35!
        Me.TotalNoRecsRight.Y2 = 0.5!
        '
        'lnTotalNoRecsTop
        '
        Me.lnTotalNoRecsTop.Height = 0.0!
        Me.lnTotalNoRecsTop.Left = 3.2!
        Me.lnTotalNoRecsTop.LineWeight = 1.0!
        Me.lnTotalNoRecsTop.Name = "lnTotalNoRecsTop"
        Me.lnTotalNoRecsTop.Top = 0.35!
        Me.lnTotalNoRecsTop.Width = 0.3!
        Me.lnTotalNoRecsTop.X1 = 3.2!
        Me.lnTotalNoRecsTop.X2 = 3.5!
        Me.lnTotalNoRecsTop.Y1 = 0.35!
        Me.lnTotalNoRecsTop.Y2 = 0.35!
        '
        'lblTotalNoRecs
        '
        Me.lblTotalNoRecs.Height = 0.15!
        Me.lblTotalNoRecs.HyperLink = Nothing
        Me.lblTotalNoRecs.Left = 1.85!
        Me.lblTotalNoRecs.Name = "lblTotalNoRecs"
        Me.lblTotalNoRecs.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblTotalNoRecs.Text = "Total No. of Recs."
        Me.lblTotalNoRecs.Top = 0.35!
        Me.lblTotalNoRecs.Width = 1.3!
        '
        'lnAutoRequestRight
        '
        Me.lnAutoRequestRight.Height = 0.15!
        Me.lnAutoRequestRight.Left = 1.8!
        Me.lnAutoRequestRight.LineWeight = 1.0!
        Me.lnAutoRequestRight.Name = "lnAutoRequestRight"
        Me.lnAutoRequestRight.Top = 0.75!
        Me.lnAutoRequestRight.Width = 0.0!
        Me.lnAutoRequestRight.X1 = 1.8!
        Me.lnAutoRequestRight.X2 = 1.8!
        Me.lnAutoRequestRight.Y1 = 0.75!
        Me.lnAutoRequestRight.Y2 = 0.9!
        '
        'lnAutoRequestBottom
        '
        Me.lnAutoRequestBottom.Height = 0.0!
        Me.lnAutoRequestBottom.Left = 0.9!
        Me.lnAutoRequestBottom.LineWeight = 1.0!
        Me.lnAutoRequestBottom.Name = "lnAutoRequestBottom"
        Me.lnAutoRequestBottom.Top = 0.9!
        Me.lnAutoRequestBottom.Width = 0.9!
        Me.lnAutoRequestBottom.X1 = 0.9!
        Me.lnAutoRequestBottom.X2 = 1.8!
        Me.lnAutoRequestBottom.Y1 = 0.9!
        Me.lnAutoRequestBottom.Y2 = 0.9!
        '
        'lnAutoRequestTop
        '
        Me.lnAutoRequestTop.Height = 0.0!
        Me.lnAutoRequestTop.Left = 0.9!
        Me.lnAutoRequestTop.LineWeight = 1.0!
        Me.lnAutoRequestTop.Name = "lnAutoRequestTop"
        Me.lnAutoRequestTop.Top = 0.75!
        Me.lnAutoRequestTop.Width = 0.9!
        Me.lnAutoRequestTop.X1 = 0.9!
        Me.lnAutoRequestTop.X2 = 1.8!
        Me.lnAutoRequestTop.Y1 = 0.75!
        Me.lnAutoRequestTop.Y2 = 0.75!
        '
        'lnAutoRequestLeft
        '
        Me.lnAutoRequestLeft.Height = 0.15!
        Me.lnAutoRequestLeft.Left = 0.9!
        Me.lnAutoRequestLeft.LineWeight = 1.0!
        Me.lnAutoRequestLeft.Name = "lnAutoRequestLeft"
        Me.lnAutoRequestLeft.Top = 0.75!
        Me.lnAutoRequestLeft.Width = 0.0!
        Me.lnAutoRequestLeft.X1 = 0.9!
        Me.lnAutoRequestLeft.X2 = 0.9!
        Me.lnAutoRequestLeft.Y1 = 0.75!
        Me.lnAutoRequestLeft.Y2 = 0.9!
        '
        'lnTotalNoRecsBottom
        '
        Me.lnTotalNoRecsBottom.Height = 0.0!
        Me.lnTotalNoRecsBottom.Left = 3.2!
        Me.lnTotalNoRecsBottom.LineWeight = 1.0!
        Me.lnTotalNoRecsBottom.Name = "lnTotalNoRecsBottom"
        Me.lnTotalNoRecsBottom.Top = 0.5!
        Me.lnTotalNoRecsBottom.Width = 0.3!
        Me.lnTotalNoRecsBottom.X1 = 3.2!
        Me.lnTotalNoRecsBottom.X2 = 3.5!
        Me.lnTotalNoRecsBottom.Y1 = 0.5!
        Me.lnTotalNoRecsBottom.Y2 = 0.5!
        '
        'lnTotalNoRecsLeft
        '
        Me.lnTotalNoRecsLeft.Height = 0.15!
        Me.lnTotalNoRecsLeft.Left = 3.2!
        Me.lnTotalNoRecsLeft.LineWeight = 1.0!
        Me.lnTotalNoRecsLeft.Name = "lnTotalNoRecsLeft"
        Me.lnTotalNoRecsLeft.Top = 0.35!
        Me.lnTotalNoRecsLeft.Width = 0.0!
        Me.lnTotalNoRecsLeft.X1 = 3.2!
        Me.lnTotalNoRecsLeft.X2 = 3.2!
        Me.lnTotalNoRecsLeft.Y1 = 0.35!
        Me.lnTotalNoRecsLeft.Y2 = 0.5!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.rptPageNo, Me.txtSort, Me.lblReportDate, Me.txtDisclaimer})
        Me.PageFooter1.Height = 0.5376667!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'rptPageNo
        '
        Me.rptPageNo.FormatString = "Page {PageNumber} of {PageCount}"
        Me.rptPageNo.Height = 0.15!
        Me.rptPageNo.Left = 8.0!
        Me.rptPageNo.Name = "rptPageNo"
        Me.rptPageNo.Style = "font-size: 7pt; font-style: italic; text-align: right; vertical-align: middle"
        Me.rptPageNo.Top = 0.375!
        Me.rptPageNo.Width = 2.0!
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
        'txtDisclaimer
        '
        Me.txtDisclaimer.CanShrink = True
        Me.txtDisclaimer.Height = 0.15!
        Me.txtDisclaimer.Left = 0.0!
        Me.txtDisclaimer.Name = "txtDisclaimer"
        Me.txtDisclaimer.Style = "font-size: 7pt; font-style: italic; text-align: center; vertical-align: middle"
        Me.txtDisclaimer.Text = "Disclaimer"
        Me.txtDisclaimer.Top = 0.225!
        Me.txtDisclaimer.Width = 10.0!
        '
        'rptBMRecommendationResponsesFollowUp
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.25!
        Me.PageSettings.Margins.Left = 0.5!
        Me.PageSettings.Margins.Right = 0.5!
        Me.PageSettings.Margins.Top = 0.25!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 10.0!
        Me.ScriptLanguage = "VB.NET"
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Calibri; font-style: normal; text-decoration: none; font-weight: nor" & _
            "mal; font-size: 10pt; color: Black", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
            "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.lblFacility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFileNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTIV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGRCLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblStProv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCountry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblClientLocNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDivision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRecommendationFollowUpReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRecommendationFollowUpReportMessage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblClientName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalNoRecs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAutoRequest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAutoRequest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblResponseStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRespDueDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRespRequestDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRecipientEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRecipientName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRFU1Date, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFileNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoActiveRecs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDaysOverdue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRFU3Date, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDivision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNoActiveRecs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRespRequestDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRecipientEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRespDueDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNoRecsNeedingResp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRFU2Date, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoRecsNeedingResp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRFU2Date, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDaysOverdue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRFU3Date, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRFU1Date, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRecipientName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientLocNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTIV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFacility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStProv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtResponseStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTotalNoRecs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptPageNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSort, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblReportDate, System.ComponentModel.ISupportInitialize).EndInit()
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

    Private Sub rptBMRecommendationResponsesFollowUp_FetchData(ByVal sender As Object, ByVal eArgs As FetchEventArgs) Handles Me.FetchData
        Dim zTextControls() As ARControl = {txtResponseStatus}
        UtilReport.ActiveReport.SetItemBackColorByText(Me, zTextControls, rptProperties)
    End Sub

    Private Sub rptBMRecommendationResponsesFollowUp_ReportStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportStart
        lblClientName.Text = rptProperties.ClientName
        lblReportDate.Text = Now
        lblRecommendationFollowUpReport.Text = UtilReport.ActiveReport.Header.RecommendationResponseFollowUpReport(rptProperties.MetaReport.colFldName.ToString)
        lblRecommendationFollowUpReportMessage.Text = UtilReport.ActiveReport.Header.RecommendationResponseFollowUpReportMessage(rptProperties.MetaReport.colFldName.ToString)
        lblTIV.Text = "TIV " & rptProperties.Currency.colFldCode & vbLf & "(millions)"
      

    End Sub

    Private Sub rptBMRecommendationResponsesFollowUp_PageStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.PageStart
        UtilReport.ActiveReport.SetFilter(Me, rptProperties)
        UtilReport.ActiveReport.SetSort(Me, rptProperties)
        UtilReport.ActiveReport.SetDisclaimer(Me, rptProperties)
    End Sub

    Private Sub rptBMRecommendationResponsesFollowUp_ReportEnd(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportEnd
        DisposeParameters()
    End Sub

    Private Sub DisposeParameters()
        DataSource = Nothing
    End Sub

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties
End Class
