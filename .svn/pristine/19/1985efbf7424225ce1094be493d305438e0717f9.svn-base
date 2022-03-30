Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports

Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing

Public Class rptBMRecommendations
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
    Private WithEvents lblRecommendationsReport As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lnPageHeaderTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnPageHeaderBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtFilters As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblTIV As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFacility As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lnPageHeaderRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents rptPageNo As GrapeCity.ActiveReports.SectionReportModel.ReportInfo
    Private WithEvents txtSort As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblReportDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtRecKeyWords As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSecondaryTypes As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtRecYear As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtRecNumber As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtResponseDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtAddress As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCity As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtStProv As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCountry As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtStatusDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtStatus As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtImpact As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFileNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtPrimary As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtResponseFrom As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtIntendedAction As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtExpectedCompletionDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtRecMonth As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtRecSubletter As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtDivision As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblPrimary As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblSecondary As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblKeywords As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCost As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblAfter As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblBefore As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblRatio As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtLEBefore As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtLEAfter As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtLECost As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSavingsRatio As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblRecNumber As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblDateOfResponse As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblIntendedAction As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFrom As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblExpectedCompletionDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblImpact As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblStatus As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtClientLocNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtTIV As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFacility As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lnPageHeaderLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lblFileNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblClientName As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblActiveRecommendationsOnly As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblPlantComment As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtPlantComment As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblStatusDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblActualCostToComplete As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtActualLEBefore As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtActualLEAfter As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtActualLECost As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtActualCosttoComplete As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblRangeLEBefore As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblRangeLEAfter As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblRangeLECost As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblActualLEAfterCurrency As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblActualLECostCurrency As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblActualLEBeforeCurrency As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblActualCostToCompleteCurrency As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents BorderShape As GrapeCity.ActiveReports.SectionReportModel.Shape
    Private WithEvents lblMgmtRespComment As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtMgmtRespComment As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtMgmtRespDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtMgmtRespFrom As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtMgmtRespAction As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblMgmtRespDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblMgmtRespAction As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblMgmtRespFrom As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtDisclaimer As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lbl3rdLvlRespDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lbl3rdLvlRespFrom As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lbl3rdLvlRespAction As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lbl3rdLvlRespComment As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txt3rdLvlRespDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txt3rdLvlRespFrom As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txt3rdLvlRespAction As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txt3rdLvlRespComment As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents PageFooter1 As GrapeCity.ActiveReports.SectionReportModel.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptBMRecommendations))
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
        Me.lblRecommendationsReport = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lnPageHeaderTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnPageHeaderBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtFilters = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblActiveRecommendationsOnly = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblClientName = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lnPageHeaderRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnPageHeaderLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Detail1 = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.txtPlantComment = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblPlantComment = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtLEBefore = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtRecKeyWords = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSecondaryTypes = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtRecYear = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtRecNumber = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtResponseDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtAddress = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCity = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCountry = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtStatusDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtStatus = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtImpact = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFileNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPrimary = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtResponseFrom = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtIntendedAction = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtExpectedCompletionDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtRecMonth = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtRecSubletter = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtDivision = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblPrimary = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSecondary = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblKeywords = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblCost = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblAfter = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblBefore = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblRatio = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtLEAfter = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtLECost = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSavingsRatio = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblRecNumber = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblDateOfResponse = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblIntendedAction = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFrom = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblExpectedCompletionDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblImpact = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblStatus = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtClientLocNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtTIV = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFacility = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblStatusDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtStProv = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblActualCostToComplete = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtActualLEBefore = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtActualLEAfter = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtActualLECost = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtActualCosttoComplete = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblRangeLEBefore = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblRangeLEAfter = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblRangeLECost = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblActualLEAfterCurrency = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblActualLECostCurrency = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblActualLEBeforeCurrency = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblActualCostToCompleteCurrency = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.BorderShape = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.lblMgmtRespComment = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtMgmtRespComment = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMgmtRespDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMgmtRespFrom = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMgmtRespAction = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblMgmtRespDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblMgmtRespAction = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblMgmtRespFrom = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.PageFooter1 = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.rptPageNo = New GrapeCity.ActiveReports.SectionReportModel.ReportInfo()
        Me.txtSort = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblReportDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtDisclaimer = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lbl3rdLvlRespDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lbl3rdLvlRespFrom = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lbl3rdLvlRespAction = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lbl3rdLvlRespComment = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txt3rdLvlRespDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt3rdLvlRespFrom = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt3rdLvlRespAction = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt3rdLvlRespComment = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
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
        CType(Me.lblRecommendationsReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblActiveRecommendationsOnly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblClientName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPlantComment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPlantComment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLEBefore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRecKeyWords, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSecondaryTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRecYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRecNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtResponseDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStatusDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImpact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFileNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrimary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtResponseFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIntendedAction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExpectedCompletionDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRecMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRecSubletter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDivision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPrimary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSecondary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblKeywords, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAfter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBefore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRatio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLEAfter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLECost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSavingsRatio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRecNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDateOfResponse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblIntendedAction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblExpectedCompletionDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblImpact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientLocNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTIV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFacility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblStatusDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStProv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblActualCostToComplete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActualLEBefore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActualLEAfter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActualLECost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActualCosttoComplete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRangeLEBefore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRangeLEAfter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRangeLECost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblActualLEAfterCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblActualLECostCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblActualLEBeforeCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblActualCostToCompleteCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMgmtRespComment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMgmtRespComment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMgmtRespDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMgmtRespFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMgmtRespAction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMgmtRespDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMgmtRespAction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMgmtRespFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptPageNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblReportDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisclaimer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl3rdLvlRespDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl3rdLvlRespFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl3rdLvlRespAction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl3rdLvlRespComment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt3rdLvlRespDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt3rdLvlRespFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt3rdLvlRespAction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt3rdLvlRespComment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.CanShrink = True
        Me.PageHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblFacility, Me.lblFileNo, Me.lblTIV, Me.picGRCLogo, Me.lblAddress, Me.lblCity, Me.lblStProv, Me.lblCountry, Me.lblClientLocNo, Me.lblDivision, Me.lblFilters, Me.lblRecommendationsReport, Me.lnPageHeaderTop, Me.lnPageHeaderBottom, Me.txtFilters, Me.lblActiveRecommendationsOnly, Me.lblClientName, Me.lnPageHeaderRight, Me.lnPageHeaderLeft})
        Me.PageHeader1.Height = 1.35!
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
        Me.lblClientLocNo.Text = "Client Loc. No."
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
        'lblRecommendationsReport
        '
        Me.lblRecommendationsReport.Height = 0.2!
        Me.lblRecommendationsReport.HyperLink = Nothing
        Me.lblRecommendationsReport.Left = 5.69!
        Me.lblRecommendationsReport.Name = "lblRecommendationsReport"
        Me.lblRecommendationsReport.Style = "font-size: 12pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblRecommendationsReport.Text = "All BM Recommendation Report"
        Me.lblRecommendationsReport.Top = 0.35!
        Me.lblRecommendationsReport.Width = 4.3!
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
        'lblActiveRecommendationsOnly
        '
        Me.lblActiveRecommendationsOnly.CanShrink = True
        Me.lblActiveRecommendationsOnly.Height = 0.15!
        Me.lblActiveRecommendationsOnly.Left = 0.0!
        Me.lblActiveRecommendationsOnly.Name = "lblActiveRecommendationsOnly"
        Me.lblActiveRecommendationsOnly.Style = "font-size: 8pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblActiveRecommendationsOnly.Text = Nothing
        Me.lblActiveRecommendationsOnly.Top = 0.625!
        Me.lblActiveRecommendationsOnly.Width = 10.0!
        '
        'lblClientName
        '
        Me.lblClientName.Height = 0.25!
        Me.lblClientName.HyperLink = Nothing
        Me.lblClientName.Left = 5.69!
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
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtPlantComment, Me.lblPlantComment, Me.txtLEBefore, Me.txtRecKeyWords, Me.txtSecondaryTypes, Me.txtRecYear, Me.txtRecNumber, Me.txtResponseDate, Me.txtAddress, Me.txtCity, Me.txtCountry, Me.txtStatusDate, Me.txtStatus, Me.txtImpact, Me.txtFileNo, Me.txtPrimary, Me.txtResponseFrom, Me.txtIntendedAction, Me.txtExpectedCompletionDate, Me.txtRecMonth, Me.txtRecSubletter, Me.txtDivision, Me.lblPrimary, Me.lblSecondary, Me.lblKeywords, Me.lblCost, Me.lblAfter, Me.lblBefore, Me.lblRatio, Me.txtLEAfter, Me.txtLECost, Me.txtSavingsRatio, Me.lblRecNumber, Me.lblDateOfResponse, Me.lblIntendedAction, Me.lblFrom, Me.lblExpectedCompletionDate, Me.lblImpact, Me.lblStatus, Me.txtClientLocNo, Me.txtTIV, Me.txtFacility, Me.lblStatusDate, Me.txtStProv, Me.lblActualCostToComplete, Me.txtActualLEBefore, Me.txtActualLEAfter, Me.txtActualLECost, Me.txtActualCosttoComplete, Me.lblRangeLEBefore, Me.lblRangeLEAfter, Me.lblRangeLECost, Me.lblActualLEAfterCurrency, Me.lblActualLECostCurrency, Me.lblActualLEBeforeCurrency, Me.lblActualCostToCompleteCurrency, Me.BorderShape, Me.lblMgmtRespComment, Me.txtMgmtRespComment, Me.txtMgmtRespDate, Me.txtMgmtRespFrom, Me.txtMgmtRespAction, Me.lblMgmtRespDate, Me.lblMgmtRespAction, Me.lblMgmtRespFrom, Me.lbl3rdLvlRespDate, Me.lbl3rdLvlRespFrom, Me.lbl3rdLvlRespAction, Me.lbl3rdLvlRespComment, Me.txt3rdLvlRespDate, Me.txt3rdLvlRespFrom, Me.txt3rdLvlRespAction, Me.txt3rdLvlRespComment})
        Me.Detail1.Height = 2.614583!
        Me.Detail1.KeepTogether = True
        Me.Detail1.Name = "Detail1"
        '
        'txtPlantComment
        '
        Me.txtPlantComment.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPlantComment.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPlantComment.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPlantComment.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPlantComment.DataField = "PlantCommentLineBreak"
        Me.txtPlantComment.Height = 0.15!
        Me.txtPlantComment.Left = 0.875!
        Me.txtPlantComment.Name = "txtPlantComment"
        Me.txtPlantComment.Style = "font-size: 7pt; text-align: left; vertical-align: top; ddo-char-set: 0"
        Me.txtPlantComment.Text = "PlantComment"
        Me.txtPlantComment.Top = 1.55!
        Me.txtPlantComment.Width = 9.08!
        '
        'lblPlantComment
        '
        Me.lblPlantComment.Height = 0.15!
        Me.lblPlantComment.HyperLink = Nothing
        Me.lblPlantComment.Left = 0.0!
        Me.lblPlantComment.Name = "lblPlantComment"
        Me.lblPlantComment.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblPlantComment.Text = "Facility Comment"
        Me.lblPlantComment.Top = 1.55!
        Me.lblPlantComment.Width = 0.85!
        '
        'txtLEBefore
        '
        Me.txtLEBefore.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtLEBefore.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtLEBefore.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtLEBefore.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtLEBefore.CanGrow = False
        Me.txtLEBefore.DataField = "LossExpectancyBefore"
        Me.txtLEBefore.Height = 0.15!
        Me.txtLEBefore.HyperLink = Nothing
        Me.txtLEBefore.Left = 0.875!
        Me.txtLEBefore.Name = "txtLEBefore"
        Me.txtLEBefore.Style = "font-size: 6.5pt; vertical-align: middle"
        Me.txtLEBefore.Text = "LEBefore"
        Me.txtLEBefore.Top = 1.15!
        Me.txtLEBefore.Width = 1.0!
        '
        'txtRecKeyWords
        '
        Me.txtRecKeyWords.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtRecKeyWords.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtRecKeyWords.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtRecKeyWords.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtRecKeyWords.CanGrow = False
        Me.txtRecKeyWords.DataField = "RecKeyWords"
        Me.txtRecKeyWords.Height = 0.15!
        Me.txtRecKeyWords.HyperLink = Nothing
        Me.txtRecKeyWords.Left = 0.875!
        Me.txtRecKeyWords.Name = "txtRecKeyWords"
        Me.txtRecKeyWords.Style = "font-size: 7pt; vertical-align: middle; ddo-char-set: 0"
        Me.txtRecKeyWords.Text = "RecKeyWords"
        Me.txtRecKeyWords.Top = 0.6!
        Me.txtRecKeyWords.Width = 9.075!
        '
        'txtSecondaryTypes
        '
        Me.txtSecondaryTypes.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtSecondaryTypes.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtSecondaryTypes.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtSecondaryTypes.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtSecondaryTypes.CanGrow = False
        Me.txtSecondaryTypes.DataField = "SecondaryRecType"
        Me.txtSecondaryTypes.Height = 0.15!
        Me.txtSecondaryTypes.HyperLink = Nothing
        Me.txtSecondaryTypes.Left = 4.84!
        Me.txtSecondaryTypes.Name = "txtSecondaryTypes"
        Me.txtSecondaryTypes.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtSecondaryTypes.Text = "Secondary Types"
        Me.txtSecondaryTypes.Top = 0.4!
        Me.txtSecondaryTypes.Width = 1.45!
        '
        'txtRecYear
        '
        Me.txtRecYear.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtRecYear.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtRecYear.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtRecYear.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtRecYear.CanGrow = False
        Me.txtRecYear.DataField = "RecYear"
        Me.txtRecYear.Height = 0.15!
        Me.txtRecYear.HyperLink = Nothing
        Me.txtRecYear.Left = 0.875!
        Me.txtRecYear.Name = "txtRecYear"
        Me.txtRecYear.Style = "font-size: 7pt; text-align: center; vertical-align: middle"
        Me.txtRecYear.Text = "2007"
        Me.txtRecYear.Top = 0.4!
        Me.txtRecYear.Width = 0.35!
        '
        'txtRecNumber
        '
        Me.txtRecNumber.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtRecNumber.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtRecNumber.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtRecNumber.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtRecNumber.CanGrow = False
        Me.txtRecNumber.DataField = "RecNumber"
        Me.txtRecNumber.Height = 0.15!
        Me.txtRecNumber.HyperLink = Nothing
        Me.txtRecNumber.Left = 1.425!
        Me.txtRecNumber.Name = "txtRecNumber"
        Me.txtRecNumber.Style = "font-size: 7pt; text-align: center; vertical-align: middle"
        Me.txtRecNumber.Text = "1"
        Me.txtRecNumber.Top = 0.4!
        Me.txtRecNumber.Width = 0.15!
        '
        'txtResponseDate
        '
        Me.txtResponseDate.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtResponseDate.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtResponseDate.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtResponseDate.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtResponseDate.CanGrow = False
        Me.txtResponseDate.DataField = "ResponseDateString"
        Me.txtResponseDate.Height = 0.15!
        Me.txtResponseDate.HyperLink = Nothing
        Me.txtResponseDate.Left = 0.875!
        Me.txtResponseDate.Name = "txtResponseDate"
        Me.txtResponseDate.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtResponseDate.Text = "Resp Date"
        Me.txtResponseDate.Top = 1.35!
        Me.txtResponseDate.Width = 1.0!
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
        Me.txtAddress.Top = 0.05!
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
        Me.txtCity.Top = 0.05!
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
        Me.txtCountry.Top = 0.05!
        Me.txtCountry.Width = 0.75!
        '
        'txtStatusDate
        '
        Me.txtStatusDate.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtStatusDate.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtStatusDate.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtStatusDate.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtStatusDate.CanGrow = False
        Me.txtStatusDate.DataField = "StatusDateString"
        Me.txtStatusDate.Height = 0.15!
        Me.txtStatusDate.HyperLink = Nothing
        Me.txtStatusDate.Left = 9.45!
        Me.txtStatusDate.Name = "txtStatusDate"
        Me.txtStatusDate.Style = "font-size: 6.5pt; text-align: center; vertical-align: middle"
        Me.txtStatusDate.Text = "0"
        Me.txtStatusDate.Top = 0.4!
        Me.txtStatusDate.Width = 0.5!
        '
        'txtStatus
        '
        Me.txtStatus.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtStatus.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtStatus.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtStatus.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtStatus.CanGrow = False
        Me.txtStatus.DataField = "RecStatus"
        Me.txtStatus.Height = 0.15!
        Me.txtStatus.HyperLink = Nothing
        Me.txtStatus.Left = 7.9!
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Style = "font-size: 7pt; vertical-align: middle; ddo-char-set: 0"
        Me.txtStatus.Text = "Rptd Completed"
        Me.txtStatus.Top = 0.4!
        Me.txtStatus.Width = 0.75!
        '
        'txtImpact
        '
        Me.txtImpact.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtImpact.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtImpact.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtImpact.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtImpact.CanGrow = False
        Me.txtImpact.DataField = "RecCategory"
        Me.txtImpact.Height = 0.15!
        Me.txtImpact.HyperLink = Nothing
        Me.txtImpact.Left = 6.84!
        Me.txtImpact.Name = "txtImpact"
        Me.txtImpact.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtImpact.Text = "Impact"
        Me.txtImpact.Top = 0.4!
        Me.txtImpact.Width = 0.5!
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
        Me.txtFileNo.Top = 0.05!
        Me.txtFileNo.Width = 0.85!
        '
        'txtPrimary
        '
        Me.txtPrimary.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPrimary.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPrimary.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPrimary.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPrimary.CanGrow = False
        Me.txtPrimary.DataField = "PrimaryRecType"
        Me.txtPrimary.Height = 0.15!
        Me.txtPrimary.HyperLink = Nothing
        Me.txtPrimary.Left = 2.75!
        Me.txtPrimary.Name = "txtPrimary"
        Me.txtPrimary.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtPrimary.Text = "Primary"
        Me.txtPrimary.Top = 0.4!
        Me.txtPrimary.Width = 1.45!
        '
        'txtResponseFrom
        '
        Me.txtResponseFrom.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtResponseFrom.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtResponseFrom.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtResponseFrom.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtResponseFrom.CanGrow = False
        Me.txtResponseFrom.DataField = "ResponseFrom"
        Me.txtResponseFrom.Height = 0.15!
        Me.txtResponseFrom.HyperLink = Nothing
        Me.txtResponseFrom.Left = 2.75!
        Me.txtResponseFrom.Name = "txtResponseFrom"
        Me.txtResponseFrom.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtResponseFrom.Text = "Resp From"
        Me.txtResponseFrom.Top = 1.35!
        Me.txtResponseFrom.Width = 1.2!
        '
        'txtIntendedAction
        '
        Me.txtIntendedAction.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtIntendedAction.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtIntendedAction.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtIntendedAction.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtIntendedAction.CanGrow = False
        Me.txtIntendedAction.DataField = "IntendedAction"
        Me.txtIntendedAction.Height = 0.15!
        Me.txtIntendedAction.HyperLink = Nothing
        Me.txtIntendedAction.Left = 6.84!
        Me.txtIntendedAction.Name = "txtIntendedAction"
        Me.txtIntendedAction.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtIntendedAction.Text = "Intended Action"
        Me.txtIntendedAction.Top = 1.35!
        Me.txtIntendedAction.Width = 1.81!
        '
        'txtExpectedCompletionDate
        '
        Me.txtExpectedCompletionDate.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtExpectedCompletionDate.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtExpectedCompletionDate.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtExpectedCompletionDate.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtExpectedCompletionDate.CanGrow = False
        Me.txtExpectedCompletionDate.DataField = "ExpectedCompletionDateString"
        Me.txtExpectedCompletionDate.Height = 0.15!
        Me.txtExpectedCompletionDate.HyperLink = Nothing
        Me.txtExpectedCompletionDate.Left = 4.84!
        Me.txtExpectedCompletionDate.Name = "txtExpectedCompletionDate"
        Me.txtExpectedCompletionDate.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtExpectedCompletionDate.Text = "Exp. Comp. Date"
        Me.txtExpectedCompletionDate.Top = 1.35!
        Me.txtExpectedCompletionDate.Width = 1.0!
        '
        'txtRecMonth
        '
        Me.txtRecMonth.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtRecMonth.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtRecMonth.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtRecMonth.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtRecMonth.CanGrow = False
        Me.txtRecMonth.DataField = "RecMonth"
        Me.txtRecMonth.Height = 0.15!
        Me.txtRecMonth.HyperLink = Nothing
        Me.txtRecMonth.Left = 1.225!
        Me.txtRecMonth.Name = "txtRecMonth"
        Me.txtRecMonth.Style = "font-size: 7pt; text-align: center; vertical-align: middle"
        Me.txtRecMonth.Text = "11"
        Me.txtRecMonth.Top = 0.4!
        Me.txtRecMonth.Width = 0.2!
        '
        'txtRecSubletter
        '
        Me.txtRecSubletter.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtRecSubletter.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtRecSubletter.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtRecSubletter.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtRecSubletter.CanGrow = False
        Me.txtRecSubletter.DataField = "RecSubletter"
        Me.txtRecSubletter.Height = 0.15!
        Me.txtRecSubletter.HyperLink = Nothing
        Me.txtRecSubletter.Left = 1.575!
        Me.txtRecSubletter.Name = "txtRecSubletter"
        Me.txtRecSubletter.Style = "font-size: 7pt; text-align: center; vertical-align: middle"
        Me.txtRecSubletter.Text = "1"
        Me.txtRecSubletter.Top = 0.4!
        Me.txtRecSubletter.Width = 0.15!
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
        Me.txtDivision.Top = 0.05!
        Me.txtDivision.Width = 1.2!
        '
        'lblPrimary
        '
        Me.lblPrimary.Height = 0.15!
        Me.lblPrimary.HyperLink = Nothing
        Me.lblPrimary.Left = 2.05!
        Me.lblPrimary.Name = "lblPrimary"
        Me.lblPrimary.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblPrimary.Text = "Primary"
        Me.lblPrimary.Top = 0.4!
        Me.lblPrimary.Width = 0.67!
        '
        'lblSecondary
        '
        Me.lblSecondary.Height = 0.15!
        Me.lblSecondary.HyperLink = Nothing
        Me.lblSecondary.Left = 4.22!
        Me.lblSecondary.Name = "lblSecondary"
        Me.lblSecondary.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblSecondary.Text = "Secondary"
        Me.lblSecondary.Top = 0.4!
        Me.lblSecondary.Width = 0.6!
        '
        'lblKeywords
        '
        Me.lblKeywords.Height = 0.15!
        Me.lblKeywords.HyperLink = Nothing
        Me.lblKeywords.Left = 0.0!
        Me.lblKeywords.Name = "lblKeywords"
        Me.lblKeywords.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblKeywords.Text = "Keywords"
        Me.lblKeywords.Top = 0.6!
        Me.lblKeywords.Width = 0.85!
        '
        'lblCost
        '
        Me.lblCost.Height = 0.15!
        Me.lblCost.HyperLink = Nothing
        Me.lblCost.Left = 4.84!
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Style = "font-size: 7pt; font-weight: bold; vertical-align: middle"
        Me.lblCost.Text = "Est. Cost to Complete"
        Me.lblCost.Top = 0.8!
        Me.lblCost.Width = 1.1!
        '
        'lblAfter
        '
        Me.lblAfter.Height = 0.15!
        Me.lblAfter.HyperLink = Nothing
        Me.lblAfter.Left = 2.75!
        Me.lblAfter.Name = "lblAfter"
        Me.lblAfter.Style = "font-size: 7pt; font-weight: bold; vertical-align: middle"
        Me.lblAfter.Text = "Completed Loss Est."
        Me.lblAfter.Top = 0.8!
        Me.lblAfter.Width = 1.0!
        '
        'lblBefore
        '
        Me.lblBefore.Height = 0.15!
        Me.lblBefore.HyperLink = Nothing
        Me.lblBefore.Left = 0.875!
        Me.lblBefore.Name = "lblBefore"
        Me.lblBefore.Style = "font-size: 7pt; font-weight: bold; vertical-align: middle"
        Me.lblBefore.Text = "Current Loss Est."
        Me.lblBefore.Top = 0.8!
        Me.lblBefore.Width = 1.0!
        '
        'lblRatio
        '
        Me.lblRatio.Height = 0.15!
        Me.lblRatio.HyperLink = Nothing
        Me.lblRatio.Left = 9.13!
        Me.lblRatio.Name = "lblRatio"
        Me.lblRatio.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblRatio.Text = "Savings Ratio"
        Me.lblRatio.Top = 0.8!
        Me.lblRatio.Width = 0.81!
        '
        'txtLEAfter
        '
        Me.txtLEAfter.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtLEAfter.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtLEAfter.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtLEAfter.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtLEAfter.CanGrow = False
        Me.txtLEAfter.DataField = "LossExpectancyAfter"
        Me.txtLEAfter.Height = 0.15!
        Me.txtLEAfter.HyperLink = Nothing
        Me.txtLEAfter.Left = 2.75!
        Me.txtLEAfter.Name = "txtLEAfter"
        Me.txtLEAfter.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtLEAfter.Text = "LEAfter"
        Me.txtLEAfter.Top = 1.15!
        Me.txtLEAfter.Width = 1.0!
        '
        'txtLECost
        '
        Me.txtLECost.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtLECost.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtLECost.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtLECost.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtLECost.CanGrow = False
        Me.txtLECost.DataField = "CostToComplete"
        Me.txtLECost.Height = 0.15!
        Me.txtLECost.HyperLink = Nothing
        Me.txtLECost.Left = 4.84!
        Me.txtLECost.Name = "txtLECost"
        Me.txtLECost.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtLECost.Text = "LECost"
        Me.txtLECost.Top = 1.15!
        Me.txtLECost.Width = 1.0!
        '
        'txtSavingsRatio
        '
        Me.txtSavingsRatio.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtSavingsRatio.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtSavingsRatio.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtSavingsRatio.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtSavingsRatio.CanGrow = False
        Me.txtSavingsRatio.DataField = "SavingsRatio"
        Me.txtSavingsRatio.Height = 0.15!
        Me.txtSavingsRatio.HyperLink = Nothing
        Me.txtSavingsRatio.Left = 9.45!
        Me.txtSavingsRatio.Name = "txtSavingsRatio"
        Me.txtSavingsRatio.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtSavingsRatio.Text = "Savings Ratio"
        Me.txtSavingsRatio.Top = 0.95!
        Me.txtSavingsRatio.Width = 0.5!
        '
        'lblRecNumber
        '
        Me.lblRecNumber.Height = 0.15!
        Me.lblRecNumber.HyperLink = Nothing
        Me.lblRecNumber.Left = 0.0!
        Me.lblRecNumber.Name = "lblRecNumber"
        Me.lblRecNumber.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblRecNumber.Text = "Rec. No."
        Me.lblRecNumber.Top = 0.4!
        Me.lblRecNumber.Width = 0.85!
        '
        'lblDateOfResponse
        '
        Me.lblDateOfResponse.Height = 0.15!
        Me.lblDateOfResponse.HyperLink = Nothing
        Me.lblDateOfResponse.Left = 0.0!
        Me.lblDateOfResponse.Name = "lblDateOfResponse"
        Me.lblDateOfResponse.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblDateOfResponse.Text = "Date of Response"
        Me.lblDateOfResponse.Top = 1.35!
        Me.lblDateOfResponse.Width = 0.85!
        '
        'lblIntendedAction
        '
        Me.lblIntendedAction.Height = 0.15!
        Me.lblIntendedAction.HyperLink = Nothing
        Me.lblIntendedAction.Left = 6.0!
        Me.lblIntendedAction.Name = "lblIntendedAction"
        Me.lblIntendedAction.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblIntendedAction.Text = "Intended Action"
        Me.lblIntendedAction.Top = 1.35!
        Me.lblIntendedAction.Width = 0.8125!
        '
        'lblFrom
        '
        Me.lblFrom.Height = 0.15!
        Me.lblFrom.HyperLink = Nothing
        Me.lblFrom.Left = 2.0!
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblFrom.Text = "Response From"
        Me.lblFrom.Top = 1.35!
        Me.lblFrom.Width = 0.7249999!
        '
        'lblExpectedCompletionDate
        '
        Me.lblExpectedCompletionDate.Height = 0.15!
        Me.lblExpectedCompletionDate.HyperLink = Nothing
        Me.lblExpectedCompletionDate.Left = 4.0!
        Me.lblExpectedCompletionDate.Name = "lblExpectedCompletionDate"
        Me.lblExpectedCompletionDate.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblExpectedCompletionDate.Text = "Exp. Comp. Date"
        Me.lblExpectedCompletionDate.Top = 1.35!
        Me.lblExpectedCompletionDate.Width = 0.81!
        '
        'lblImpact
        '
        Me.lblImpact.Height = 0.15!
        Me.lblImpact.HyperLink = Nothing
        Me.lblImpact.Left = 6.42!
        Me.lblImpact.Name = "lblImpact"
        Me.lblImpact.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblImpact.Text = "Impact"
        Me.lblImpact.Top = 0.4!
        Me.lblImpact.Width = 0.4!
        '
        'lblStatus
        '
        Me.lblStatus.Height = 0.15!
        Me.lblStatus.HyperLink = Nothing
        Me.lblStatus.Left = 7.35!
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblStatus.Text = "Status"
        Me.lblStatus.Top = 0.4!
        Me.lblStatus.Width = 0.5!
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
        Me.txtClientLocNo.Top = 0.05!
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
        Me.txtTIV.Top = 0.05!
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
        Me.txtFacility.Top = 0.05!
        Me.txtFacility.Width = 1.2!
        '
        'lblStatusDate
        '
        Me.lblStatusDate.Height = 0.15!
        Me.lblStatusDate.HyperLink = Nothing
        Me.lblStatusDate.Left = 8.85!
        Me.lblStatusDate.Name = "lblStatusDate"
        Me.lblStatusDate.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblStatusDate.Text = "Status Date"
        Me.lblStatusDate.Top = 0.4!
        Me.lblStatusDate.Width = 0.57!
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
        Me.txtStProv.Top = 0.05!
        Me.txtStProv.Width = 0.45!
        '
        'lblActualCostToComplete
        '
        Me.lblActualCostToComplete.Height = 0.15!
        Me.lblActualCostToComplete.HyperLink = Nothing
        Me.lblActualCostToComplete.Left = 6.84!
        Me.lblActualCostToComplete.Name = "lblActualCostToComplete"
        Me.lblActualCostToComplete.Style = "font-size: 7pt; font-weight: bold; vertical-align: middle"
        Me.lblActualCostToComplete.Text = "Actual Cost to Complete"
        Me.lblActualCostToComplete.Top = 0.8!
        Me.lblActualCostToComplete.Width = 1.2!
        '
        'txtActualLEBefore
        '
        Me.txtActualLEBefore.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtActualLEBefore.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtActualLEBefore.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtActualLEBefore.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtActualLEBefore.CanGrow = False
        Me.txtActualLEBefore.CurrencyCulture = New System.Globalization.CultureInfo("en-US")
        Me.txtActualLEBefore.DataField = "LossExpectancyBeforeActual"
        Me.txtActualLEBefore.Height = 0.15!
        Me.txtActualLEBefore.HyperLink = Nothing
        Me.txtActualLEBefore.Left = 0.875!
        Me.txtActualLEBefore.Name = "txtActualLEBefore"
        Me.txtActualLEBefore.OutputFormat = resources.GetString("txtActualLEBefore.OutputFormat")
        Me.txtActualLEBefore.Style = "font-size: 6.5pt; vertical-align: middle"
        Me.txtActualLEBefore.Text = "ActualLEBefore"
        Me.txtActualLEBefore.Top = 0.95!
        Me.txtActualLEBefore.Width = 1.0!
        '
        'txtActualLEAfter
        '
        Me.txtActualLEAfter.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtActualLEAfter.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtActualLEAfter.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtActualLEAfter.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtActualLEAfter.CanGrow = False
        Me.txtActualLEAfter.CurrencyCulture = New System.Globalization.CultureInfo("en-US")
        Me.txtActualLEAfter.DataField = "LossExpectancyAfterActual"
        Me.txtActualLEAfter.Height = 0.15!
        Me.txtActualLEAfter.HyperLink = Nothing
        Me.txtActualLEAfter.Left = 2.75!
        Me.txtActualLEAfter.Name = "txtActualLEAfter"
        Me.txtActualLEAfter.OutputFormat = resources.GetString("txtActualLEAfter.OutputFormat")
        Me.txtActualLEAfter.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtActualLEAfter.Text = "ActualLEAfter"
        Me.txtActualLEAfter.Top = 0.95!
        Me.txtActualLEAfter.Width = 1.0!
        '
        'txtActualLECost
        '
        Me.txtActualLECost.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtActualLECost.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtActualLECost.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtActualLECost.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtActualLECost.CanGrow = False
        Me.txtActualLECost.CurrencyCulture = New System.Globalization.CultureInfo("en-US")
        Me.txtActualLECost.DataField = "CostToCompleteActual"
        Me.txtActualLECost.Height = 0.15!
        Me.txtActualLECost.HyperLink = Nothing
        Me.txtActualLECost.Left = 4.84!
        Me.txtActualLECost.Name = "txtActualLECost"
        Me.txtActualLECost.OutputFormat = resources.GetString("txtActualLECost.OutputFormat")
        Me.txtActualLECost.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtActualLECost.Text = "ActualLECost"
        Me.txtActualLECost.Top = 0.95!
        Me.txtActualLECost.Width = 1.0!
        '
        'txtActualCosttoComplete
        '
        Me.txtActualCosttoComplete.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtActualCosttoComplete.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtActualCosttoComplete.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtActualCosttoComplete.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtActualCosttoComplete.CanGrow = False
        Me.txtActualCosttoComplete.CurrencyCulture = New System.Globalization.CultureInfo("en-US")
        Me.txtActualCosttoComplete.DataField = "ActualCostToComplete"
        Me.txtActualCosttoComplete.Height = 0.15!
        Me.txtActualCosttoComplete.HyperLink = Nothing
        Me.txtActualCosttoComplete.Left = 6.84!
        Me.txtActualCosttoComplete.Name = "txtActualCosttoComplete"
        Me.txtActualCosttoComplete.OutputFormat = resources.GetString("txtActualCosttoComplete.OutputFormat")
        Me.txtActualCosttoComplete.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtActualCosttoComplete.Text = "ActualCosttoComplete"
        Me.txtActualCosttoComplete.Top = 0.95!
        Me.txtActualCosttoComplete.Width = 1.0!
        '
        'lblRangeLEBefore
        '
        Me.lblRangeLEBefore.Height = 0.15!
        Me.lblRangeLEBefore.HyperLink = Nothing
        Me.lblRangeLEBefore.Left = 0.05000001!
        Me.lblRangeLEBefore.Name = "lblRangeLEBefore"
        Me.lblRangeLEBefore.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblRangeLEBefore.Text = "(Range)"
        Me.lblRangeLEBefore.Top = 1.15!
        Me.lblRangeLEBefore.Width = 0.8!
        '
        'lblRangeLEAfter
        '
        Me.lblRangeLEAfter.Height = 0.15!
        Me.lblRangeLEAfter.HyperLink = Nothing
        Me.lblRangeLEAfter.Left = 1.925!
        Me.lblRangeLEAfter.Name = "lblRangeLEAfter"
        Me.lblRangeLEAfter.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblRangeLEAfter.Text = "(Range)"
        Me.lblRangeLEAfter.Top = 1.15!
        Me.lblRangeLEAfter.Width = 0.8!
        '
        'lblRangeLECost
        '
        Me.lblRangeLECost.Height = 0.15!
        Me.lblRangeLECost.HyperLink = Nothing
        Me.lblRangeLECost.Left = 4.01!
        Me.lblRangeLECost.Name = "lblRangeLECost"
        Me.lblRangeLECost.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblRangeLECost.Text = "(Range)"
        Me.lblRangeLECost.Top = 1.15!
        Me.lblRangeLECost.Width = 0.8!
        '
        'lblActualLEAfterCurrency
        '
        Me.lblActualLEAfterCurrency.Height = 0.15!
        Me.lblActualLEAfterCurrency.HyperLink = Nothing
        Me.lblActualLEAfterCurrency.Left = 1.925!
        Me.lblActualLEAfterCurrency.Name = "lblActualLEAfterCurrency"
        Me.lblActualLEAfterCurrency.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblActualLEAfterCurrency.Text = "USD"
        Me.lblActualLEAfterCurrency.Top = 0.95!
        Me.lblActualLEAfterCurrency.Width = 0.8!
        '
        'lblActualLECostCurrency
        '
        Me.lblActualLECostCurrency.Height = 0.15!
        Me.lblActualLECostCurrency.HyperLink = Nothing
        Me.lblActualLECostCurrency.Left = 4.01!
        Me.lblActualLECostCurrency.Name = "lblActualLECostCurrency"
        Me.lblActualLECostCurrency.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblActualLECostCurrency.Text = "USD"
        Me.lblActualLECostCurrency.Top = 0.95!
        Me.lblActualLECostCurrency.Width = 0.8!
        '
        'lblActualLEBeforeCurrency
        '
        Me.lblActualLEBeforeCurrency.Height = 0.15!
        Me.lblActualLEBeforeCurrency.HyperLink = Nothing
        Me.lblActualLEBeforeCurrency.Left = 0.05000001!
        Me.lblActualLEBeforeCurrency.Name = "lblActualLEBeforeCurrency"
        Me.lblActualLEBeforeCurrency.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblActualLEBeforeCurrency.Text = "USD"
        Me.lblActualLEBeforeCurrency.Top = 0.95!
        Me.lblActualLEBeforeCurrency.Width = 0.8!
        '
        'lblActualCostToCompleteCurrency
        '
        Me.lblActualCostToCompleteCurrency.Height = 0.15!
        Me.lblActualCostToCompleteCurrency.HyperLink = Nothing
        Me.lblActualCostToCompleteCurrency.Left = 6.0125!
        Me.lblActualCostToCompleteCurrency.Name = "lblActualCostToCompleteCurrency"
        Me.lblActualCostToCompleteCurrency.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblActualCostToCompleteCurrency.Text = "USD"
        Me.lblActualCostToCompleteCurrency.Top = 0.95!
        Me.lblActualCostToCompleteCurrency.Width = 0.8!
        '
        'BorderShape
        '
        Me.BorderShape.Height = 0.01!
        Me.BorderShape.Left = 0.0!
        Me.BorderShape.Name = "BorderShape"
        Me.BorderShape.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(9.999999!, Nothing, Nothing, Nothing, Nothing)
        Me.BorderShape.Top = 0.05!
        Me.BorderShape.Width = 10.0!
        '
        'lblMgmtRespComment
        '
        Me.lblMgmtRespComment.Height = 0.15!
        Me.lblMgmtRespComment.HyperLink = Nothing
        Me.lblMgmtRespComment.Left = 0.0!
        Me.lblMgmtRespComment.Name = "lblMgmtRespComment"
        Me.lblMgmtRespComment.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblMgmtRespComment.Text = "Mgmt. Comment"
        Me.lblMgmtRespComment.Top = 1.951!
        Me.lblMgmtRespComment.Width = 0.85!
        '
        'txtMgmtRespComment
        '
        Me.txtMgmtRespComment.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMgmtRespComment.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMgmtRespComment.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMgmtRespComment.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMgmtRespComment.DataField = "MgmtRespCommentLineBreak"
        Me.txtMgmtRespComment.Height = 0.15!
        Me.txtMgmtRespComment.Left = 0.875!
        Me.txtMgmtRespComment.Name = "txtMgmtRespComment"
        Me.txtMgmtRespComment.Style = "font-size: 7pt; vertical-align: top; ddo-char-set: 0"
        Me.txtMgmtRespComment.Text = "MgmtRespCommentLineBreak"
        Me.txtMgmtRespComment.Top = 1.951!
        Me.txtMgmtRespComment.Width = 9.075!
        '
        'txtMgmtRespDate
        '
        Me.txtMgmtRespDate.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMgmtRespDate.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMgmtRespDate.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMgmtRespDate.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMgmtRespDate.CanGrow = False
        Me.txtMgmtRespDate.DataField = "MgmtRespDateString"
        Me.txtMgmtRespDate.Height = 0.15!
        Me.txtMgmtRespDate.Left = 0.875!
        Me.txtMgmtRespDate.Name = "txtMgmtRespDate"
        Me.txtMgmtRespDate.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtMgmtRespDate.Text = "MgmtRespDate"
        Me.txtMgmtRespDate.Top = 1.751!
        Me.txtMgmtRespDate.Width = 1.0!
        '
        'txtMgmtRespFrom
        '
        Me.txtMgmtRespFrom.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMgmtRespFrom.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMgmtRespFrom.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMgmtRespFrom.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMgmtRespFrom.CanGrow = False
        Me.txtMgmtRespFrom.DataField = "MgmtRespFrom"
        Me.txtMgmtRespFrom.Height = 0.15!
        Me.txtMgmtRespFrom.Left = 2.75!
        Me.txtMgmtRespFrom.Name = "txtMgmtRespFrom"
        Me.txtMgmtRespFrom.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtMgmtRespFrom.Text = "MgmtRespFrom"
        Me.txtMgmtRespFrom.Top = 1.751!
        Me.txtMgmtRespFrom.Width = 1.2!
        '
        'txtMgmtRespAction
        '
        Me.txtMgmtRespAction.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMgmtRespAction.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMgmtRespAction.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMgmtRespAction.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMgmtRespAction.CanGrow = False
        Me.txtMgmtRespAction.DataField = "MgmtRespAction"
        Me.txtMgmtRespAction.Height = 0.15!
        Me.txtMgmtRespAction.Left = 4.865!
        Me.txtMgmtRespAction.Name = "txtMgmtRespAction"
        Me.txtMgmtRespAction.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtMgmtRespAction.Text = "MgmtRespAction"
        Me.txtMgmtRespAction.Top = 1.7505!
        Me.txtMgmtRespAction.Width = 1.81!
        '
        'lblMgmtRespDate
        '
        Me.lblMgmtRespDate.Height = 0.15!
        Me.lblMgmtRespDate.HyperLink = Nothing
        Me.lblMgmtRespDate.Left = 0.0!
        Me.lblMgmtRespDate.Name = "lblMgmtRespDate"
        Me.lblMgmtRespDate.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblMgmtRespDate.Text = "Mgmt. Resp. Date"
        Me.lblMgmtRespDate.Top = 1.751!
        Me.lblMgmtRespDate.Width = 0.85!
        '
        'lblMgmtRespAction
        '
        Me.lblMgmtRespAction.Height = 0.15!
        Me.lblMgmtRespAction.HyperLink = Nothing
        Me.lblMgmtRespAction.Left = 4.0275!
        Me.lblMgmtRespAction.Name = "lblMgmtRespAction"
        Me.lblMgmtRespAction.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblMgmtRespAction.Text = "Mgmt. Action"
        Me.lblMgmtRespAction.Top = 1.7505!
        Me.lblMgmtRespAction.Width = 0.8125!
        '
        'lblMgmtRespFrom
        '
        Me.lblMgmtRespFrom.Height = 0.15!
        Me.lblMgmtRespFrom.HyperLink = Nothing
        Me.lblMgmtRespFrom.Left = 1.93!
        Me.lblMgmtRespFrom.Name = "lblMgmtRespFrom"
        Me.lblMgmtRespFrom.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblMgmtRespFrom.Text = "Response From"
        Me.lblMgmtRespFrom.Top = 1.7505!
        Me.lblMgmtRespFrom.Width = 0.8!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.rptPageNo, Me.txtSort, Me.lblReportDate, Me.txtDisclaimer})
        Me.PageFooter1.Height = 0.50625!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'rptPageNo
        '
        Me.rptPageNo.FormatString = "Page {PageNumber} of {PageCount}"
        Me.rptPageNo.Height = 0.15!
        Me.rptPageNo.Left = 8.0!
        Me.rptPageNo.Name = "rptPageNo"
        Me.rptPageNo.Style = "font-size: 7pt; font-style: italic; text-align: right; vertical-align: middle"
        Me.rptPageNo.Top = 0.3!
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
        Me.lblReportDate.Top = 0.3!
        Me.lblReportDate.Width = 2.0!
        '
        'txtDisclaimer
        '
        Me.txtDisclaimer.CanShrink = True
        Me.txtDisclaimer.Height = 0.15!
        Me.txtDisclaimer.Left = 0.042!
        Me.txtDisclaimer.Name = "txtDisclaimer"
        Me.txtDisclaimer.Style = "font-size: 7pt; font-style: italic; text-align: center; vertical-align: middle"
        Me.txtDisclaimer.Text = "Disclaimer"
        Me.txtDisclaimer.Top = 0.15!
        Me.txtDisclaimer.Width = 10.0!
        '
        'lbl3rdLvlRespDate
        '
        Me.lbl3rdLvlRespDate.Height = 0.15!
        Me.lbl3rdLvlRespDate.HyperLink = Nothing
        Me.lbl3rdLvlRespDate.Left = 0.05078757!
        Me.lbl3rdLvlRespDate.Name = "lbl3rdLvlRespDate"
        Me.lbl3rdLvlRespDate.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lbl3rdLvlRespDate.Tag = "7"
        Me.lbl3rdLvlRespDate.Text = "3rd Lvl Resp. Date"
        Me.lbl3rdLvlRespDate.Top = 2.161!
        Me.lbl3rdLvlRespDate.Width = 0.7992125!
        '
        'lbl3rdLvlRespFrom
        '
        Me.lbl3rdLvlRespFrom.Height = 0.15!
        Me.lbl3rdLvlRespFrom.HyperLink = Nothing
        Me.lbl3rdLvlRespFrom.Left = 2.000189!
        Me.lbl3rdLvlRespFrom.Name = "lbl3rdLvlRespFrom"
        Me.lbl3rdLvlRespFrom.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lbl3rdLvlRespFrom.Tag = "7"
        Me.lbl3rdLvlRespFrom.Text = "Response From"
        Me.lbl3rdLvlRespFrom.Top = 2.161!
        Me.lbl3rdLvlRespFrom.Width = 0.7298111!
        '
        'lbl3rdLvlRespAction
        '
        Me.lbl3rdLvlRespAction.Height = 0.15!
        Me.lbl3rdLvlRespAction.HyperLink = Nothing
        Me.lbl3rdLvlRespAction.Left = 4.22!
        Me.lbl3rdLvlRespAction.Name = "lbl3rdLvlRespAction"
        Me.lbl3rdLvlRespAction.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lbl3rdLvlRespAction.Tag = "7"
        Me.lbl3rdLvlRespAction.Text = "3rd Lvl Action"
        Me.lbl3rdLvlRespAction.Top = 2.161!
        Me.lbl3rdLvlRespAction.Width = 0.6392121!
        '
        'lbl3rdLvlRespComment
        '
        Me.lbl3rdLvlRespComment.Height = 0.15!
        Me.lbl3rdLvlRespComment.HyperLink = Nothing
        Me.lbl3rdLvlRespComment.Left = 0.05078757!
        Me.lbl3rdLvlRespComment.Name = "lbl3rdLvlRespComment"
        Me.lbl3rdLvlRespComment.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lbl3rdLvlRespComment.Tag = "7"
        Me.lbl3rdLvlRespComment.Text = "3rd Lvl Comment"
        Me.lbl3rdLvlRespComment.Top = 2.398!
        Me.lbl3rdLvlRespComment.Width = 0.7992125!
        '
        'txt3rdLvlRespDate
        '
        Me.txt3rdLvlRespDate.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt3rdLvlRespDate.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt3rdLvlRespDate.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt3rdLvlRespDate.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt3rdLvlRespDate.CanGrow = False
        Me.txt3rdLvlRespDate.DataField = "ThirdLevelRespDateString"
        Me.txt3rdLvlRespDate.Height = 0.15!
        Me.txt3rdLvlRespDate.Left = 0.875!
        Me.txt3rdLvlRespDate.Name = "txt3rdLvlRespDate"
        Me.txt3rdLvlRespDate.Style = "font-size: 7pt; vertical-align: middle"
        Me.txt3rdLvlRespDate.Tag = "7"
        Me.txt3rdLvlRespDate.Text = "ThirdLevelRespDateString"
        Me.txt3rdLvlRespDate.Top = 2.161!
        Me.txt3rdLvlRespDate.Width = 1.0!
        '
        'txt3rdLvlRespFrom
        '
        Me.txt3rdLvlRespFrom.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt3rdLvlRespFrom.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt3rdLvlRespFrom.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt3rdLvlRespFrom.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt3rdLvlRespFrom.CanGrow = False
        Me.txt3rdLvlRespFrom.DataField = "ThirdLevelRespFrom"
        Me.txt3rdLvlRespFrom.Height = 0.15!
        Me.txt3rdLvlRespFrom.Left = 2.75!
        Me.txt3rdLvlRespFrom.Name = "txt3rdLvlRespFrom"
        Me.txt3rdLvlRespFrom.Style = "font-size: 7pt; vertical-align: middle"
        Me.txt3rdLvlRespFrom.Tag = "5"
        Me.txt3rdLvlRespFrom.Text = "ThirdLevelRespFrom"
        Me.txt3rdLvlRespFrom.Top = 2.161!
        Me.txt3rdLvlRespFrom.Width = 1.2!
        '
        'txt3rdLvlRespAction
        '
        Me.txt3rdLvlRespAction.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt3rdLvlRespAction.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt3rdLvlRespAction.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt3rdLvlRespAction.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt3rdLvlRespAction.CanGrow = False
        Me.txt3rdLvlRespAction.DataField = "ThirdLevelRespAction"
        Me.txt3rdLvlRespAction.Height = 0.15!
        Me.txt3rdLvlRespAction.Left = 4.865!
        Me.txt3rdLvlRespAction.Name = "txt3rdLvlRespAction"
        Me.txt3rdLvlRespAction.Style = "font-size: 7pt; vertical-align: middle"
        Me.txt3rdLvlRespAction.Tag = "7"
        Me.txt3rdLvlRespAction.Text = "ThirdLevelRespAction"
        Me.txt3rdLvlRespAction.Top = 2.161!
        Me.txt3rdLvlRespAction.Width = 1.81!
        '
        'txt3rdLvlRespComment
        '
        Me.txt3rdLvlRespComment.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt3rdLvlRespComment.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt3rdLvlRespComment.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt3rdLvlRespComment.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txt3rdLvlRespComment.DataField = "ThirdLevelRespCommentLineBreak"
        Me.txt3rdLvlRespComment.Height = 0.15!
        Me.txt3rdLvlRespComment.Left = 0.875!
        Me.txt3rdLvlRespComment.Name = "txt3rdLvlRespComment"
        Me.txt3rdLvlRespComment.Style = "font-size: 7pt; vertical-align: top; ddo-char-set: 0"
        Me.txt3rdLvlRespComment.Tag = "8"
        Me.txt3rdLvlRespComment.Text = "ThirdLevelRespCommentLineBreak"
        Me.txt3rdLvlRespComment.Top = 2.398!
        Me.txt3rdLvlRespComment.Width = 9.075!
        '
        'rptBMRecommendations
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.25!
        Me.PageSettings.Margins.Left = 0.5!
        Me.PageSettings.Margins.Right = 0.5!
        Me.PageSettings.Margins.Top = 0.25!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 10.042!
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
        CType(Me.lblRecommendationsReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblActiveRecommendationsOnly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblClientName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPlantComment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPlantComment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLEBefore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRecKeyWords, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSecondaryTypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRecYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRecNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtResponseDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStatusDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImpact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFileNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrimary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtResponseFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIntendedAction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExpectedCompletionDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRecMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRecSubletter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDivision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPrimary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSecondary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblKeywords, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAfter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBefore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRatio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLEAfter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLECost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSavingsRatio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRecNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDateOfResponse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblIntendedAction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblExpectedCompletionDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblImpact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientLocNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTIV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFacility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblStatusDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStProv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblActualCostToComplete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActualLEBefore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActualLEAfter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActualLECost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActualCosttoComplete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRangeLEBefore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRangeLEAfter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRangeLECost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblActualLEAfterCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblActualLECostCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblActualLEBeforeCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblActualCostToCompleteCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMgmtRespComment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMgmtRespComment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMgmtRespDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMgmtRespFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMgmtRespAction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMgmtRespDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMgmtRespAction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMgmtRespFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptPageNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSort, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblReportDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisclaimer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl3rdLvlRespDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl3rdLvlRespFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl3rdLvlRespAction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl3rdLvlRespComment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt3rdLvlRespDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt3rdLvlRespFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt3rdLvlRespAction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt3rdLvlRespComment, System.ComponentModel.ISupportInitialize).EndInit()
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

    Private Sub rptBMRecommendations_FetchData(ByVal sender As Object, ByVal eArgs As FetchEventArgs) Handles Me.FetchData
        Dim zTextControls() As ARControl = {txtImpact}
        UtilReport.ActiveReport.SetItemBackColorByText(Me, zTextControls, rptProperties)

        If Me.AllFields("ExpectedCompletionDateColor").Value.ToString.ToLower <> "transparent" Then
            txtExpectedCompletionDate.BackColor = System.Drawing.ColorTranslator.FromHtml(Me.AllFields("ExpectedCompletionDateColor").Value)
        Else
            txtExpectedCompletionDate.BackColor = Color.Transparent
        End If

    End Sub

    Private Sub rptBMRecommendations_ReportStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportStart

        lblClientName.Text = rptProperties.ClientName
        lblReportDate.Text = Now
        lblRecommendationsReport.Text = UtilReport.ActiveReport.Header.RecommendationsReport(rptProperties.MetaReport.colFldName.ToString)
        lblActiveRecommendationsOnly.Text = UtilReport.ActiveReport.Header.ActiveRecommendationsOnly(rptProperties.MetaReport.colFldName.ToString)
        lblTIV.Text = "TIV " & rptProperties.Currency.colFldCode & vbLf & "(millions)"

        lblActualLECostCurrency.Text = rptProperties.Currency.colFldCode
        lblActualLEAfterCurrency.Text = rptProperties.Currency.colFldCode
        lblActualLEBeforeCurrency.Text = rptProperties.Currency.colFldCode
        lblActualCostToCompleteCurrency.Text = rptProperties.Currency.colFldCode

        'If Not rptProperties.ClientSpecialFeatures.ToUpper.Contains("L") Then
        '    RemoveActualLE()
        '    lblRangeLEBefore.Text = "(Range " & rptProperties.Currency.colFldCode & ")"
        '    lblRangeLEAfter.Text = "(Range " & rptProperties.Currency.colFldCode & ")"
        '    lblRangeLECost.Text = "(Range " & rptProperties.Currency.colFldCode & ")"
        'End If

        If Not UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.Q) Then
            RemoveMgmtFields()
        End If

        If Not UtilCustomFeature.Contains(rptProperties, CChar("@")) Then
            Remove3rdLvlFields()
        End If

    End Sub

    Private Sub rptBMRecommendations_PageStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.PageStart
        UtilReport.ActiveReport.SetFilter(Me, rptProperties)
        UtilReport.ActiveReport.SetSort(Me, rptProperties)
        UtilReport.ActiveReport.SetDisclaimer(Me, rptProperties)
    End Sub

    Private Sub RemoveActualLE()
        txtActualLEBefore.Visible = False
        txtActualLEAfter.Visible = False
        txtActualLECost.Visible = False
        lblActualLECostCurrency.Visible = False
        lblActualLEAfterCurrency.Visible = False
        lblActualLEBeforeCurrency.Visible = False
        lblRangeLEBefore.Top -= 0.2
        txtLEBefore.Top -= 0.2
        lblRangeLEAfter.Top -= 0.2
        txtLEAfter.Top -= 0.2
        lblRangeLECost.Top -= 0.2
        txtLECost.Top -= 0.2
        lblDateOfResponse.Top -= 0.2
        txtResponseDate.Top -= 0.2
        lblFrom.Top -= 0.2
        txtResponseFrom.Top -= 0.2
        lblExpectedCompletionDate.Top -= 0.2
        txtExpectedCompletionDate.Top -= 0.2
        lblIntendedAction.Top -= 0.2
        txtIntendedAction.Top -= 0.2
        lblPlantComment.Top -= 0.2
        txtPlantComment.Top -= 0.2
        txtMgmtRespAction.Top -= 0.2
        lblMgmtRespAction.Top -= 0.2
        txtMgmtRespComment.Top -= 0.2
        lblMgmtRespComment.Top -= 0.2
        txtMgmtRespFrom.Top -= 0.2
        lblMgmtRespFrom.Top -= 0.2
        txtMgmtRespDate.Top -= 0.2
        lblMgmtRespDate.Top -= 0.2
        Detail1.Height -= 0.2
    End Sub

    Private Sub RemoveMgmtFields()

        Dim zDistanceToMoveUp As Single = 0.0
        zDistanceToMoveUp = Detail1.Height - txtMgmtRespFrom.Location.Y

        txtMgmtRespAction.Visible = False
        lblMgmtRespAction.Visible = False

        txtMgmtRespComment.Visible = False
        lblMgmtRespComment.Visible = False

        txtMgmtRespDate.Visible = False
        lblMgmtRespDate.Visible = False

        txtMgmtRespFrom.Visible = False
        lblMgmtRespFrom.Visible = False

        Detail1.Height -= zDistanceToMoveUp

    End Sub

    Private Sub Remove3rdLvlFields()

        Dim zDistanceToMoveUp As Single = 0.0
        zDistanceToMoveUp = Detail1.Height - txt3rdLvlRespDate.Location.Y

        txt3rdLvlRespAction.Visible = False
        lbl3rdLvlRespAction.Visible = False

        txt3rdLvlRespComment.Visible = False
        lbl3rdLvlRespComment.Visible = False

        txt3rdLvlRespDate.Visible = False
        lbl3rdLvlRespDate.Visible = False

        txt3rdLvlRespFrom.Visible = False
        lbl3rdLvlRespFrom.Visible = False

        Detail1.Height -= zDistanceToMoveUp

    End Sub

    Private Sub Detail1_BeforePrint(ByVal sender As Object, ByVal e As EventArgs) Handles Detail1.BeforePrint
        BorderShape.Height = Detail1.Height - 0.05
    End Sub

    Private Sub rptBMRecommendations_ReportEnd(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportEnd
        DisposeParameters()
    End Sub

    Private Sub DisposeParameters()
        DataSource = Nothing
    End Sub

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties
End Class
