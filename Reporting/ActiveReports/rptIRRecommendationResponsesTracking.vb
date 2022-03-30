Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports

Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing

Public Class rptIRRecommendationResponsesTracking
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
    Private WithEvents lblRecommendationTrackingReport As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lnPageHeaderTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnPageHeaderBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtFilters As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblTIV As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFacility As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lnPageHeaderRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents rptPageNo As GrapeCity.ActiveReports.SectionReportModel.ReportInfo
    Private WithEvents txtSort As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblReportDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtRecommendation As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtSecondaryTypes As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtRecYear As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtRecNumber As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtResponseDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtAddress As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtCity As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtStProv As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtCountry As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtStatusDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtStatus As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtImpact As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtFileNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtPrimary As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtResponseFrom As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtIntendedAction As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtExpectedCompletionDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtRecMonth As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtDivision As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblPrimary As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblSecondary As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblKeywords As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblDetectedWith As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFaultType As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblPlantArea As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblSeverity As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtPlantAreaAffected As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtFaultType As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtDetectedWith As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtSeverityRating As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lnKeywordsLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnKeywordsTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnKeywordsBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lblRecNumber As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblResponseDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblIntendedAction As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblResponseFrom As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblExpectedCompletionDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblImpact As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblStatus As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtClientLocNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtTIV As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtFacility As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblStatusDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lnSecondaryLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnSecondaryRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnSecondaryTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnSecondaryBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnIntendedActionTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnDetectedWithTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnDetectedWithBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnIntendedActionBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnDetectedWithLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnDetectedWithRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnIntendedActionLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnIntendedActionRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnHistoryTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnHistoryBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnImpactTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnStatusRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnImpactLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnImpactBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnStatusLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnHistoryLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnReponseFromBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnPrimaryTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnPrimaryBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnFaultTypeTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnFaultTypeRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnFaultTypeLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnReponseFromLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnFaultTypeBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnReponseFromRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnPrimaryLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRecNoTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnLEBeforeTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnLEBeforeRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnLEBeforeLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRecYearLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnLEBeforeBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnReponseFromTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRecSubletterRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRecMonthLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRecNumber As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnPrimaryRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnHistoryRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnImpactRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnStatusDateLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnStatusTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnStatusBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnStatusDateTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnStatusDateBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnPageHeaderLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRecNoBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lblFileNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblClientName As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblRecommendationTrackingReportMessage As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblPlantComment As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblResponseRequestDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblRequestDueDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtRequestDueDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtResponseRequestDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents shpResponseRequestDate As GrapeCity.ActiveReports.SectionReportModel.Shape
    Private WithEvents lblFirstFollowUp As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtFirstFollowUp As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblSecondFollowUp As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtSecondFollowUp As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblThirdFollowUp As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtThirdFollowUp As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblDaysOverdue As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtDaysOverdue As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblRecipientName As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtRecipientName As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblRecipientEmail As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtRecipientEmail As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents shpRequestDueDate As GrapeCity.ActiveReports.SectionReportModel.Shape
    Private WithEvents shpFirstFollowUp As GrapeCity.ActiveReports.SectionReportModel.Shape
    Private WithEvents shpSecondFollowUp As GrapeCity.ActiveReports.SectionReportModel.Shape
    Private WithEvents shpThirdFollowUp As GrapeCity.ActiveReports.SectionReportModel.Shape
    Private WithEvents shpDaysOverdue As GrapeCity.ActiveReports.SectionReportModel.Shape
    Private WithEvents shpRecipientEmail As GrapeCity.ActiveReports.SectionReportModel.Shape
    Private WithEvents shpRecipientName As GrapeCity.ActiveReports.SectionReportModel.Shape
    Private WithEvents lnLEAfterLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lblRecComment As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lnRecCommentBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRecCommentTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRecCommentLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtRecComment As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtSpecItemDetail As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblLengthOfBI As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtEquipmentLocation As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblSpecificItemDetail As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtProbableCause As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtLengthofBusinessInterruption As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtProbableEquipmentDamageCost As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtRedundancySpare As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtHistory As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblRedundancySpare As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblFrom As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblHistory As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lnRedundancySpareTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRedundancySpareBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRedundancySpareLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnRedundancySpareRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnSeverityBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnSeverityLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnCostOfBIBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnCostOfBILeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnCostOfBIRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnLengthOfBIBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnLengthOfBILeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnLengthOfBITop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnLengthOfBIRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnCostOfBITop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnSeverityTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnSeverityRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnProbableCauseRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnProbableCauseTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnProbableCauseLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lblProbableCause As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lnLocationLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnLocationTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lblEquipmentLocation As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lnSpecificItemDetailRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnSpecificItemDetailTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnSpecificItemDetailLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnLocationRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnProbableCauseBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnLocationBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnSpecificItemDetailBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lblFindingNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lnFindingNoRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnFindingNoBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnFindingNoLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnFindingNoTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtFindingNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtResponseStatus As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents shpResponseStatus As GrapeCity.ActiveReports.SectionReportModel.Shape
    Private WithEvents lblResponseStatus As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblCriticality As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtCriticality As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lnCriticalityBottom As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnCriticalityLeft As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnCriticalityTop As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lnCriticalityRight As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lblMgmtRespComment As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtMgmtRespComment As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtMgmtRespDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtMgmtRespFrom As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtMgmtRespAction As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblMgmtRespDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblMgmtRespAction As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblMgmtRespFrom As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents BorderShape As GrapeCity.ActiveReports.SectionReportModel.Shape
    Private WithEvents txtDisclaimer As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lbl3rdLvlRespDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lbl3rdLvlRespFrom As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lbl3rdLvlRespAction As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lbl3rdLvlRespComment As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txt3rdLvlRespDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txt3rdLvlRespFrom As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txt3rdLvlRespAction As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txt3rdLvlRespComment As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtPlantComment As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents PageFooter1 As GrapeCity.ActiveReports.SectionReportModel.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptIRRecommendationResponsesTracking))
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
        Me.lblRecommendationTrackingReport = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lnPageHeaderTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnPageHeaderBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtFilters = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblRecommendationTrackingReportMessage = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblClientName = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lnPageHeaderRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnPageHeaderLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Detail1 = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.txtStatusDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblProbableCause = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtCriticality = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtHistory = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblResponseStatus = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtFindingNo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSpecificItemDetail = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblLengthOfBI = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblEquipmentLocation = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtEquipmentLocation = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtRecComment = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtDetectedWith = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPlantComment = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtPlantAreaAffected = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lnLEBeforeTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtRecommendation = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtSecondaryTypes = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtRecYear = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtRecNumber = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtResponseDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtAddress = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtCity = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtCountry = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtStatus = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtImpact = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtFileNo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtPrimary = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtResponseFrom = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtIntendedAction = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtExpectedCompletionDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtRecMonth = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtDivision = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPrimary = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSecondary = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblKeywords = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblDetectedWith = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFaultType = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPlantArea = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSeverity = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtFaultType = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtSeverityRating = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lnKeywordsLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnKeywordsTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnKeywordsBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lblRecNumber = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblResponseDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblIntendedAction = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblResponseFrom = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblExpectedCompletionDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblImpact = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblStatus = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtClientLocNo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtTIV = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFacility = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblStatusDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lnSecondaryLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnSecondaryRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnSecondaryTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnSecondaryBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnIntendedActionTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnDetectedWithTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnDetectedWithBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnIntendedActionBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnDetectedWithLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnDetectedWithRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnIntendedActionLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnIntendedActionRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnHistoryTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnHistoryBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnImpactTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnStatusRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnImpactLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnImpactBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnStatusLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnHistoryLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnReponseFromBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnPrimaryTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnPrimaryBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnFaultTypeTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnFaultTypeRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnFaultTypeLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnReponseFromLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnFaultTypeBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnReponseFromRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRecNoTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnLEBeforeRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnLEBeforeLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRecYearLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnLEBeforeBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnReponseFromTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRecSubletterRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRecMonthLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRecNumber = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnPrimaryRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnHistoryRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnImpactRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnStatusDateLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnStatusTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnStatusBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnStatusDateTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnStatusDateBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtStProv = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lnPrimaryLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRecNoBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtPlantComment = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblResponseRequestDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblRequestDueDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtRequestDueDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtResponseRequestDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.shpResponseRequestDate = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.lblFirstFollowUp = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtFirstFollowUp = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSecondFollowUp = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtSecondFollowUp = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblThirdFollowUp = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtThirdFollowUp = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblDaysOverdue = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtDaysOverdue = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblRecipientName = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtRecipientName = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblRecipientEmail = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtRecipientEmail = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.shpRequestDueDate = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.shpFirstFollowUp = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.shpSecondFollowUp = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.shpThirdFollowUp = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.shpDaysOverdue = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.shpRecipientEmail = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.shpRecipientName = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.lblRecComment = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lnRecCommentBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRecCommentTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRecCommentLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtSpecItemDetail = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtProbableCause = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtLengthofBusinessInterruption = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtProbableEquipmentDamageCost = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtRedundancySpare = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblRedundancySpare = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFrom = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblHistory = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lnRedundancySpareTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRedundancySpareBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRedundancySpareLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnRedundancySpareRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnSeverityBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnSeverityLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnCostOfBIBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnCostOfBILeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnCostOfBIRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnLengthOfBIBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnLengthOfBILeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnLengthOfBITop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnLengthOfBIRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnCostOfBITop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnSeverityTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnSeverityRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnProbableCauseRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnProbableCauseTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnProbableCauseLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnLocationLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnLocationTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnSpecificItemDetailRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnSpecificItemDetailTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnSpecificItemDetailLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnLocationRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnProbableCauseBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnLocationBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnSpecificItemDetailBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lblFindingNo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lnFindingNoRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnFindingNoBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnFindingNoLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnFindingNoTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtResponseStatus = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.shpResponseStatus = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.lblCriticality = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lnCriticalityBottom = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnCriticalityLeft = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnCriticalityTop = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lnCriticalityRight = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lblMgmtRespComment = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtMgmtRespComment = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMgmtRespDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMgmtRespFrom = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMgmtRespAction = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblMgmtRespDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblMgmtRespAction = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblMgmtRespFrom = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.BorderShape = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.lbl3rdLvlRespDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lbl3rdLvlRespFrom = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lbl3rdLvlRespAction = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lbl3rdLvlRespComment = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txt3rdLvlRespDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt3rdLvlRespFrom = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt3rdLvlRespAction = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt3rdLvlRespComment = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
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
        CType(Me.lblRecommendationTrackingReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRecommendationTrackingReportMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblClientName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStatusDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblProbableCause, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCriticality, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblResponseStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFindingNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSpecificItemDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblLengthOfBI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblEquipmentLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEquipmentLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRecComment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDetectedWith, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPlantComment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPlantAreaAffected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRecommendation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSecondaryTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRecYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRecNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtResponseDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImpact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFileNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrimary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtResponseFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIntendedAction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExpectedCompletionDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRecMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDivision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPrimary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSecondary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblKeywords, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDetectedWith, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFaultType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPlantArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSeverity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFaultType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSeverityRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRecNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblResponseDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblIntendedAction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblResponseFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblExpectedCompletionDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblImpact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientLocNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTIV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFacility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblStatusDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStProv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPlantComment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblResponseRequestDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRequestDueDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRequestDueDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtResponseRequestDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFirstFollowUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFirstFollowUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSecondFollowUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSecondFollowUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblThirdFollowUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtThirdFollowUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDaysOverdue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDaysOverdue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRecipientName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRecipientName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRecipientEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRecipientEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRecComment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSpecItemDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProbableCause, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLengthofBusinessInterruption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProbableEquipmentDamageCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRedundancySpare, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRedundancySpare, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFindingNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtResponseStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCriticality, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMgmtRespComment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMgmtRespComment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMgmtRespDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMgmtRespFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMgmtRespAction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMgmtRespDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMgmtRespAction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMgmtRespFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl3rdLvlRespDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl3rdLvlRespFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl3rdLvlRespAction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl3rdLvlRespComment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt3rdLvlRespDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt3rdLvlRespFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt3rdLvlRespAction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt3rdLvlRespComment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptPageNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblReportDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisclaimer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.CanShrink = True
        Me.PageHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblFacility, Me.lblFileNo, Me.lblTIV, Me.picGRCLogo, Me.lblAddress, Me.lblCity, Me.lblStProv, Me.lblCountry, Me.lblClientLocNo, Me.lblDivision, Me.lblFilters, Me.lblRecommendationTrackingReport, Me.lnPageHeaderTop, Me.lnPageHeaderBottom, Me.txtFilters, Me.lblRecommendationTrackingReportMessage, Me.lblClientName, Me.lnPageHeaderRight, Me.lnPageHeaderLeft})
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
        'lblRecommendationTrackingReport
        '
        Me.lblRecommendationTrackingReport.Height = 0.2!
        Me.lblRecommendationTrackingReport.HyperLink = Nothing
        Me.lblRecommendationTrackingReport.Left = 5.65!
        Me.lblRecommendationTrackingReport.Name = "lblRecommendationTrackingReport"
        Me.lblRecommendationTrackingReport.Style = "font-size: 12pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblRecommendationTrackingReport.Text = "Infrared Recommendation Tracking Report"
        Me.lblRecommendationTrackingReport.Top = 0.35!
        Me.lblRecommendationTrackingReport.Width = 4.320001!
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
        'lblRecommendationTrackingReportMessage
        '
        Me.lblRecommendationTrackingReportMessage.CanShrink = True
        Me.lblRecommendationTrackingReportMessage.Height = 0.15!
        Me.lblRecommendationTrackingReportMessage.Left = 0.0!
        Me.lblRecommendationTrackingReportMessage.Name = "lblRecommendationTrackingReportMessage"
        Me.lblRecommendationTrackingReportMessage.Style = "font-size: 8pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblRecommendationTrackingReportMessage.Text = Nothing
        Me.lblRecommendationTrackingReportMessage.Top = 0.625!
        Me.lblRecommendationTrackingReportMessage.Width = 10.0!
        '
        'lblClientName
        '
        Me.lblClientName.Height = 0.25!
        Me.lblClientName.HyperLink = Nothing
        Me.lblClientName.Left = 5.65!
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Style = "color: #C6D1DE; font-size: 16pt; font-style: italic; font-weight: bold; text-alig" & _
    "n: right; vertical-align: middle"
        Me.lblClientName.Text = "Company Name"
        Me.lblClientName.Top = 0.05000006!
        Me.lblClientName.Width = 4.320001!
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
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtStatusDate, Me.lblProbableCause, Me.txtCriticality, Me.txtHistory, Me.lblResponseStatus, Me.txtFindingNo, Me.lblSpecificItemDetail, Me.lblLengthOfBI, Me.lblEquipmentLocation, Me.txtEquipmentLocation, Me.txtRecComment, Me.txtDetectedWith, Me.lblPlantComment, Me.txtPlantAreaAffected, Me.lnLEBeforeTop, Me.txtRecommendation, Me.txtSecondaryTypes, Me.txtRecYear, Me.txtRecNumber, Me.txtResponseDate, Me.txtAddress, Me.txtCity, Me.txtCountry, Me.txtStatus, Me.txtImpact, Me.txtFileNo, Me.txtPrimary, Me.txtResponseFrom, Me.txtIntendedAction, Me.txtExpectedCompletionDate, Me.txtRecMonth, Me.txtDivision, Me.lblPrimary, Me.lblSecondary, Me.lblKeywords, Me.lblDetectedWith, Me.lblFaultType, Me.lblPlantArea, Me.lblSeverity, Me.txtFaultType, Me.txtSeverityRating, Me.lnKeywordsLeft, Me.lnKeywordsTop, Me.lnKeywordsBottom, Me.lblRecNumber, Me.lblResponseDate, Me.lblIntendedAction, Me.lblResponseFrom, Me.lblExpectedCompletionDate, Me.lblImpact, Me.lblStatus, Me.txtClientLocNo, Me.txtTIV, Me.txtFacility, Me.lblStatusDate, Me.lnSecondaryLeft, Me.lnSecondaryRight, Me.lnSecondaryTop, Me.lnSecondaryBottom, Me.lnIntendedActionTop, Me.lnDetectedWithTop, Me.lnDetectedWithBottom, Me.lnIntendedActionBottom, Me.lnDetectedWithLeft, Me.lnDetectedWithRight, Me.lnIntendedActionLeft, Me.lnIntendedActionRight, Me.lnHistoryTop, Me.lnHistoryBottom, Me.lnImpactTop, Me.lnStatusRight, Me.lnImpactLeft, Me.lnImpactBottom, Me.lnStatusLeft, Me.lnHistoryLeft, Me.lnReponseFromBottom, Me.lnPrimaryTop, Me.lnPrimaryBottom, Me.lnFaultTypeTop, Me.lnFaultTypeRight, Me.lnFaultTypeLeft, Me.lnReponseFromLeft, Me.lnFaultTypeBottom, Me.lnReponseFromRight, Me.lnRecNoTop, Me.lnLEBeforeRight, Me.lnLEBeforeLeft, Me.lnRecYearLeft, Me.lnLEBeforeBottom, Me.lnReponseFromTop, Me.lnRecSubletterRight, Me.lnRecMonthLeft, Me.lnRecNumber, Me.lnPrimaryRight, Me.lnHistoryRight, Me.lnImpactRight, Me.lnStatusDateLeft, Me.lnStatusTop, Me.lnStatusBottom, Me.lnStatusDateTop, Me.lnStatusDateBottom, Me.txtStProv, Me.lnPrimaryLeft, Me.lnRecNoBottom, Me.txtPlantComment, Me.lblResponseRequestDate, Me.lblRequestDueDate, Me.txtRequestDueDate, Me.txtResponseRequestDate, Me.shpResponseRequestDate, Me.lblFirstFollowUp, Me.txtFirstFollowUp, Me.lblSecondFollowUp, Me.txtSecondFollowUp, Me.lblThirdFollowUp, Me.txtThirdFollowUp, Me.lblDaysOverdue, Me.txtDaysOverdue, Me.lblRecipientName, Me.txtRecipientName, Me.lblRecipientEmail, Me.txtRecipientEmail, Me.shpRequestDueDate, Me.shpFirstFollowUp, Me.shpSecondFollowUp, Me.shpThirdFollowUp, Me.shpDaysOverdue, Me.shpRecipientEmail, Me.shpRecipientName, Me.lblRecComment, Me.lnRecCommentBottom, Me.lnRecCommentTop, Me.lnRecCommentLeft, Me.txtSpecItemDetail, Me.txtProbableCause, Me.txtLengthofBusinessInterruption, Me.txtProbableEquipmentDamageCost, Me.txtRedundancySpare, Me.lblRedundancySpare, Me.lblFrom, Me.lblHistory, Me.lnRedundancySpareTop, Me.lnRedundancySpareBottom, Me.lnRedundancySpareLeft, Me.lnRedundancySpareRight, Me.lnSeverityBottom, Me.lnSeverityLeft, Me.lnCostOfBIBottom, Me.lnCostOfBILeft, Me.lnCostOfBIRight, Me.lnLengthOfBIBottom, Me.lnLengthOfBILeft, Me.lnLengthOfBITop, Me.lnLengthOfBIRight, Me.lnCostOfBITop, Me.lnSeverityTop, Me.lnSeverityRight, Me.lnProbableCauseRight, Me.lnProbableCauseTop, Me.lnProbableCauseLeft, Me.lnLocationLeft, Me.lnLocationTop, Me.lnSpecificItemDetailRight, Me.lnSpecificItemDetailTop, Me.lnSpecificItemDetailLeft, Me.lnLocationRight, Me.lnProbableCauseBottom, Me.lnLocationBottom, Me.lnSpecificItemDetailBottom, Me.lblFindingNo, Me.lnFindingNoRight, Me.lnFindingNoBottom, Me.lnFindingNoLeft, Me.lnFindingNoTop, Me.txtResponseStatus, Me.shpResponseStatus, Me.lblCriticality, Me.lnCriticalityBottom, Me.lnCriticalityLeft, Me.lnCriticalityTop, Me.lnCriticalityRight, Me.lblMgmtRespComment, Me.txtMgmtRespComment, Me.txtMgmtRespDate, Me.txtMgmtRespFrom, Me.txtMgmtRespAction, Me.lblMgmtRespDate, Me.lblMgmtRespAction, Me.lblMgmtRespFrom, Me.BorderShape, Me.lbl3rdLvlRespDate, Me.lbl3rdLvlRespFrom, Me.lbl3rdLvlRespAction, Me.lbl3rdLvlRespComment, Me.txt3rdLvlRespDate, Me.txt3rdLvlRespFrom, Me.txt3rdLvlRespAction, Me.txt3rdLvlRespComment})
        Me.Detail1.Height = 3.42725!
        Me.Detail1.KeepTogether = True
        Me.Detail1.Name = "Detail1"
        '
        'txtStatusDate
        '
        Me.txtStatusDate.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtStatusDate.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtStatusDate.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtStatusDate.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtStatusDate.DataField = "StatusDateString"
        Me.txtStatusDate.Height = 0.15!
        Me.txtStatusDate.HyperLink = Nothing
        Me.txtStatusDate.Left = 9.49!
        Me.txtStatusDate.Name = "txtStatusDate"
        Me.txtStatusDate.Style = "font-size: 6.5pt; text-align: center; vertical-align: middle"
        Me.txtStatusDate.Text = "0"
        Me.txtStatusDate.Top = 0.3900001!
        Me.txtStatusDate.Width = 0.46!
        '
        'lblProbableCause
        '
        Me.lblProbableCause.Height = 0.15!
        Me.lblProbableCause.HyperLink = Nothing
        Me.lblProbableCause.Left = 4.16!
        Me.lblProbableCause.Name = "lblProbableCause"
        Me.lblProbableCause.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblProbableCause.Text = "Probable Cause"
        Me.lblProbableCause.Top = 0.9900001!
        Me.lblProbableCause.Width = 0.938!
        '
        'txtCriticality
        '
        Me.txtCriticality.DataField = "criticalit"
        Me.txtCriticality.Height = 0.15!
        Me.txtCriticality.HyperLink = Nothing
        Me.txtCriticality.Left = 7.0!
        Me.txtCriticality.Name = "txtCriticality"
        Me.txtCriticality.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtCriticality.Text = "Criticality"
        Me.txtCriticality.Top = 0.9775001!
        Me.txtCriticality.Width = 0.5!
        '
        'txtHistory
        '
        Me.txtHistory.DataField = "History"
        Me.txtHistory.Height = 0.15!
        Me.txtHistory.HyperLink = Nothing
        Me.txtHistory.Left = 7.0!
        Me.txtHistory.Name = "txtHistory"
        Me.txtHistory.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtHistory.Text = "History"
        Me.txtHistory.Top = 0.3900001!
        Me.txtHistory.Width = 0.5!
        '
        'lblResponseStatus
        '
        Me.lblResponseStatus.Height = 0.15!
        Me.lblResponseStatus.HyperLink = Nothing
        Me.lblResponseStatus.Left = 0.25!
        Me.lblResponseStatus.Name = "lblResponseStatus"
        Me.lblResponseStatus.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblResponseStatus.Text = "Response Status"
        Me.lblResponseStatus.Top = 2.828!
        Me.lblResponseStatus.Width = 0.82!
        '
        'txtFindingNo
        '
        Me.txtFindingNo.DataField = "findingno"
        Me.txtFindingNo.Height = 0.15!
        Me.txtFindingNo.HyperLink = Nothing
        Me.txtFindingNo.Left = 2.1!
        Me.txtFindingNo.Name = "txtFindingNo"
        Me.txtFindingNo.Style = "font-size: 7pt; text-align: center; vertical-align: middle"
        Me.txtFindingNo.Text = "10"
        Me.txtFindingNo.Top = 0.3900001!
        Me.txtFindingNo.Width = 0.15!
        '
        'lblSpecificItemDetail
        '
        Me.lblSpecificItemDetail.Height = 0.25!
        Me.lblSpecificItemDetail.HyperLink = Nothing
        Me.lblSpecificItemDetail.Left = 0.0000004768372!
        Me.lblSpecificItemDetail.Name = "lblSpecificItemDetail"
        Me.lblSpecificItemDetail.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblSpecificItemDetail.Text = "Specific Item Detail"
        Me.lblSpecificItemDetail.Top = 0.9900001!
        Me.lblSpecificItemDetail.Width = 0.65!
        '
        'lblLengthOfBI
        '
        Me.lblLengthOfBI.Height = 0.15!
        Me.lblLengthOfBI.HyperLink = Nothing
        Me.lblLengthOfBI.Left = 0.0000004768372!
        Me.lblLengthOfBI.Name = "lblLengthOfBI"
        Me.lblLengthOfBI.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblLengthOfBI.Text = "Length of BI"
        Me.lblLengthOfBI.Top = 0.7900001!
        Me.lblLengthOfBI.Width = 0.65!
        '
        'lblEquipmentLocation
        '
        Me.lblEquipmentLocation.Height = 0.25!
        Me.lblEquipmentLocation.HyperLink = Nothing
        Me.lblEquipmentLocation.Left = 2.3!
        Me.lblEquipmentLocation.Name = "lblEquipmentLocation"
        Me.lblEquipmentLocation.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblEquipmentLocation.Text = "Equipment/ Location"
        Me.lblEquipmentLocation.Top = 0.9900001!
        Me.lblEquipmentLocation.Width = 0.6!
        '
        'txtEquipmentLocation
        '
        Me.txtEquipmentLocation.DataField = "EquipmentLocation"
        Me.txtEquipmentLocation.Height = 0.35!
        Me.txtEquipmentLocation.HyperLink = Nothing
        Me.txtEquipmentLocation.Left = 2.950001!
        Me.txtEquipmentLocation.Name = "txtEquipmentLocation"
        Me.txtEquipmentLocation.Style = "font-size: 7pt; vertical-align: middle; ddo-char-set: 0"
        Me.txtEquipmentLocation.Text = "EquipmentLocation"
        Me.txtEquipmentLocation.Top = 0.9900001!
        Me.txtEquipmentLocation.Width = 1.15!
        '
        'txtRecComment
        '
        Me.txtRecComment.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtRecComment.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtRecComment.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtRecComment.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtRecComment.DataField = "Comments"
        Me.txtRecComment.Height = 0.35!
        Me.txtRecComment.HyperLink = Nothing
        Me.txtRecComment.Left = 8.1!
        Me.txtRecComment.Name = "txtRecComment"
        Me.txtRecComment.Style = "font-size: 7pt; vertical-align: middle; ddo-char-set: 0"
        Me.txtRecComment.Text = "Comments"
        Me.txtRecComment.Top = 0.9900001!
        Me.txtRecComment.Width = 1.85!
        '
        'txtDetectedWith
        '
        Me.txtDetectedWith.DataField = "DetectedWith"
        Me.txtDetectedWith.Height = 0.15!
        Me.txtDetectedWith.HyperLink = Nothing
        Me.txtDetectedWith.Left = 5.125!
        Me.txtDetectedWith.Name = "txtDetectedWith"
        Me.txtDetectedWith.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtDetectedWith.Text = "DetectedWith"
        Me.txtDetectedWith.Top = 0.6025001!
        Me.txtDetectedWith.Width = 1.25!
        '
        'lblPlantComment
        '
        Me.lblPlantComment.Height = 0.25!
        Me.lblPlantComment.HyperLink = Nothing
        Me.lblPlantComment.Left = 0.05000043!
        Me.lblPlantComment.Name = "lblPlantComment"
        Me.lblPlantComment.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblPlantComment.Text = "Facility Comment"
        Me.lblPlantComment.Top = 1.59!
        Me.lblPlantComment.Width = 0.8499995!
        '
        'txtPlantAreaAffected
        '
        Me.txtPlantAreaAffected.DataField = "PlantAreaAffected"
        Me.txtPlantAreaAffected.Height = 0.15!
        Me.txtPlantAreaAffected.HyperLink = Nothing
        Me.txtPlantAreaAffected.Left = 0.7000005!
        Me.txtPlantAreaAffected.Name = "txtPlantAreaAffected"
        Me.txtPlantAreaAffected.Style = "font-size: 6.5pt; vertical-align: middle"
        Me.txtPlantAreaAffected.Text = "Plant Area"
        Me.txtPlantAreaAffected.Top = 0.5900001!
        Me.txtPlantAreaAffected.Width = 1.55!
        '
        'lnLEBeforeTop
        '
        Me.lnLEBeforeTop.Height = 0.0!
        Me.lnLEBeforeTop.Left = 0.7000005!
        Me.lnLEBeforeTop.LineWeight = 1.0!
        Me.lnLEBeforeTop.Name = "lnLEBeforeTop"
        Me.lnLEBeforeTop.Top = 0.5900001!
        Me.lnLEBeforeTop.Width = 1.549999!
        Me.lnLEBeforeTop.X1 = 0.7000005!
        Me.lnLEBeforeTop.X2 = 2.25!
        Me.lnLEBeforeTop.Y1 = 0.5900001!
        Me.lnLEBeforeTop.Y2 = 0.5900001!
        '
        'txtRecommendation
        '
        Me.txtRecommendation.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtRecommendation.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtRecommendation.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtRecommendation.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtRecommendation.DataField = "Recommendation"
        Me.txtRecommendation.Height = 0.35!
        Me.txtRecommendation.HyperLink = Nothing
        Me.txtRecommendation.Left = 8.1!
        Me.txtRecommendation.Name = "txtRecommendation"
        Me.txtRecommendation.Style = "font-size: 7pt; vertical-align: middle; ddo-char-set: 0"
        Me.txtRecommendation.Text = "Recommendation"
        Me.txtRecommendation.Top = 0.5900001!
        Me.txtRecommendation.Width = 1.85!
        '
        'txtSecondaryTypes
        '
        Me.txtSecondaryTypes.DataField = "SecondaryRecType"
        Me.txtSecondaryTypes.Height = 0.15!
        Me.txtSecondaryTypes.HyperLink = Nothing
        Me.txtSecondaryTypes.Left = 5.125!
        Me.txtSecondaryTypes.Name = "txtSecondaryTypes"
        Me.txtSecondaryTypes.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtSecondaryTypes.Text = "Secondary Types"
        Me.txtSecondaryTypes.Top = 0.4150001!
        Me.txtSecondaryTypes.Width = 1.25!
        '
        'txtRecYear
        '
        Me.txtRecYear.DataField = "RecYear"
        Me.txtRecYear.Height = 0.15!
        Me.txtRecYear.HyperLink = Nothing
        Me.txtRecYear.Left = 0.7000005!
        Me.txtRecYear.Name = "txtRecYear"
        Me.txtRecYear.Style = "font-size: 7pt; text-align: center; vertical-align: middle"
        Me.txtRecYear.Text = "2007"
        Me.txtRecYear.Top = 0.3900001!
        Me.txtRecYear.Width = 0.35!
        '
        'txtRecNumber
        '
        Me.txtRecNumber.DataField = "RecNumber"
        Me.txtRecNumber.Height = 0.15!
        Me.txtRecNumber.HyperLink = Nothing
        Me.txtRecNumber.Left = 1.25!
        Me.txtRecNumber.Name = "txtRecNumber"
        Me.txtRecNumber.Style = "font-size: 7pt; text-align: center; vertical-align: middle"
        Me.txtRecNumber.Text = "1"
        Me.txtRecNumber.Top = 0.3900001!
        Me.txtRecNumber.Width = 0.15!
        '
        'txtResponseDate
        '
        Me.txtResponseDate.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtResponseDate.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtResponseDate.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtResponseDate.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtResponseDate.DataField = "ResponseDateString"
        Me.txtResponseDate.Height = 0.15!
        Me.txtResponseDate.HyperLink = Nothing
        Me.txtResponseDate.Left = 0.9540226!
        Me.txtResponseDate.Name = "txtResponseDate"
        Me.txtResponseDate.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtResponseDate.Text = "ResponseDate"
        Me.txtResponseDate.Top = 1.39!
        Me.txtResponseDate.Width = 0.85!
        '
        'txtAddress
        '
        Me.txtAddress.DataField = "Address"
        Me.txtAddress.Height = 0.3!
        Me.txtAddress.HyperLink = Nothing
        Me.txtAddress.Left = 4.300001!
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Style = "font-size: 8pt; font-weight: bold; vertical-align: middle"
        Me.txtAddress.Text = "Address"
        Me.txtAddress.Top = 0.04000008!
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
        Me.txtCity.Top = 0.04000008!
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
        Me.txtCountry.Top = 0.04000008!
        Me.txtCountry.Width = 0.75!
        '
        'txtStatus
        '
        Me.txtStatus.DataField = "RecStatus"
        Me.txtStatus.Height = 0.15!
        Me.txtStatus.HyperLink = Nothing
        Me.txtStatus.Left = 8.1!
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Style = "font-size: 7pt; vertical-align: middle; ddo-char-set: 0"
        Me.txtStatus.Text = "Rptd Completed"
        Me.txtStatus.Top = 0.3900001!
        Me.txtStatus.Width = 0.75!
        '
        'txtImpact
        '
        Me.txtImpact.DataField = "RecCategory"
        Me.txtImpact.Height = 0.15!
        Me.txtImpact.HyperLink = Nothing
        Me.txtImpact.Left = 7.0!
        Me.txtImpact.Name = "txtImpact"
        Me.txtImpact.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtImpact.Text = "Impact"
        Me.txtImpact.Top = 0.5900001!
        Me.txtImpact.Width = 0.5!
        '
        'txtFileNo
        '
        Me.txtFileNo.DataField = "FileNo"
        Me.txtFileNo.Height = 0.3!
        Me.txtFileNo.HyperLink = Nothing
        Me.txtFileNo.Left = 0.0000004768372!
        Me.txtFileNo.Name = "txtFileNo"
        Me.txtFileNo.Style = "font-size: 8pt; font-weight: bold; vertical-align: middle"
        Me.txtFileNo.Text = "File No"
        Me.txtFileNo.Top = 0.04000008!
        Me.txtFileNo.Width = 0.85!
        '
        'txtPrimary
        '
        Me.txtPrimary.DataField = "PrimaryRecType"
        Me.txtPrimary.Height = 0.15!
        Me.txtPrimary.HyperLink = Nothing
        Me.txtPrimary.Left = 2.950001!
        Me.txtPrimary.Name = "txtPrimary"
        Me.txtPrimary.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtPrimary.Text = "Primary"
        Me.txtPrimary.Top = 0.3900001!
        Me.txtPrimary.Width = 1.15!
        '
        'txtResponseFrom
        '
        Me.txtResponseFrom.DataField = "ResponseFrom"
        Me.txtResponseFrom.Height = 0.15!
        Me.txtResponseFrom.HyperLink = Nothing
        Me.txtResponseFrom.Left = 2.950001!
        Me.txtResponseFrom.Name = "txtResponseFrom"
        Me.txtResponseFrom.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtResponseFrom.Text = "Resp From"
        Me.txtResponseFrom.Top = 1.39!
        Me.txtResponseFrom.Width = 1.15!
        '
        'txtIntendedAction
        '
        Me.txtIntendedAction.DataField = "IntendedAction"
        Me.txtIntendedAction.Height = 0.15!
        Me.txtIntendedAction.HyperLink = Nothing
        Me.txtIntendedAction.Left = 5.125!
        Me.txtIntendedAction.Name = "txtIntendedAction"
        Me.txtIntendedAction.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtIntendedAction.Text = "Intended Action"
        Me.txtIntendedAction.Top = 1.415!
        Me.txtIntendedAction.Width = 2.0!
        '
        'txtExpectedCompletionDate
        '
        Me.txtExpectedCompletionDate.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtExpectedCompletionDate.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtExpectedCompletionDate.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtExpectedCompletionDate.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtExpectedCompletionDate.DataField = "ExpectedCompletionDateString"
        Me.txtExpectedCompletionDate.Height = 0.15!
        Me.txtExpectedCompletionDate.HyperLink = Nothing
        Me.txtExpectedCompletionDate.Left = 8.1!
        Me.txtExpectedCompletionDate.Name = "txtExpectedCompletionDate"
        Me.txtExpectedCompletionDate.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtExpectedCompletionDate.Text = "Exp. Comp. Date"
        Me.txtExpectedCompletionDate.Top = 1.39!
        Me.txtExpectedCompletionDate.Width = 1.85!
        '
        'txtRecMonth
        '
        Me.txtRecMonth.DataField = "RecMonth"
        Me.txtRecMonth.Height = 0.15!
        Me.txtRecMonth.HyperLink = Nothing
        Me.txtRecMonth.Left = 1.05!
        Me.txtRecMonth.Name = "txtRecMonth"
        Me.txtRecMonth.Style = "font-size: 7pt; text-align: center; vertical-align: middle"
        Me.txtRecMonth.Text = "11"
        Me.txtRecMonth.Top = 0.3900001!
        Me.txtRecMonth.Width = 0.2!
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
        Me.txtDivision.Top = 0.04000008!
        Me.txtDivision.Width = 1.2!
        '
        'lblPrimary
        '
        Me.lblPrimary.Height = 0.15!
        Me.lblPrimary.HyperLink = Nothing
        Me.lblPrimary.Left = 2.3!
        Me.lblPrimary.Name = "lblPrimary"
        Me.lblPrimary.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblPrimary.Text = "Primary"
        Me.lblPrimary.Top = 0.3900001!
        Me.lblPrimary.Width = 0.6!
        '
        'lblSecondary
        '
        Me.lblSecondary.Height = 0.125!
        Me.lblSecondary.HyperLink = Nothing
        Me.lblSecondary.Left = 4.16!
        Me.lblSecondary.Name = "lblSecondary"
        Me.lblSecondary.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblSecondary.Text = "Secondary"
        Me.lblSecondary.Top = 0.4150001!
        Me.lblSecondary.Width = 0.9375!
        '
        'lblKeywords
        '
        Me.lblKeywords.Height = 0.25!
        Me.lblKeywords.HyperLink = Nothing
        Me.lblKeywords.Left = 7.550001!
        Me.lblKeywords.Name = "lblKeywords"
        Me.lblKeywords.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblKeywords.Text = "Rec. Keywords"
        Me.lblKeywords.Top = 0.5900001!
        Me.lblKeywords.Width = 0.5!
        '
        'lblDetectedWith
        '
        Me.lblDetectedWith.Height = 0.15!
        Me.lblDetectedWith.HyperLink = Nothing
        Me.lblDetectedWith.Left = 4.16!
        Me.lblDetectedWith.Name = "lblDetectedWith"
        Me.lblDetectedWith.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblDetectedWith.Text = "Detected With"
        Me.lblDetectedWith.Top = 0.5900001!
        Me.lblDetectedWith.Width = 0.938!
        '
        'lblFaultType
        '
        Me.lblFaultType.Height = 0.15!
        Me.lblFaultType.HyperLink = Nothing
        Me.lblFaultType.Left = 2.3!
        Me.lblFaultType.Name = "lblFaultType"
        Me.lblFaultType.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblFaultType.Text = "Fault Type"
        Me.lblFaultType.Top = 0.5900001!
        Me.lblFaultType.Width = 0.6!
        '
        'lblPlantArea
        '
        Me.lblPlantArea.Height = 0.15!
        Me.lblPlantArea.HyperLink = Nothing
        Me.lblPlantArea.Left = 0.0000004768372!
        Me.lblPlantArea.Name = "lblPlantArea"
        Me.lblPlantArea.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblPlantArea.Text = "Plant Area"
        Me.lblPlantArea.Top = 0.5900001!
        Me.lblPlantArea.Width = 0.65!
        '
        'lblSeverity
        '
        Me.lblSeverity.Height = 0.125!
        Me.lblSeverity.HyperLink = Nothing
        Me.lblSeverity.Left = 6.4375!
        Me.lblSeverity.Name = "lblSeverity"
        Me.lblSeverity.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblSeverity.Text = "Severity"
        Me.lblSeverity.Top = 0.7900001!
        Me.lblSeverity.Width = 0.5!
        '
        'txtFaultType
        '
        Me.txtFaultType.DataField = "FaultType"
        Me.txtFaultType.Height = 0.15!
        Me.txtFaultType.HyperLink = Nothing
        Me.txtFaultType.Left = 2.950001!
        Me.txtFaultType.Name = "txtFaultType"
        Me.txtFaultType.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtFaultType.Text = "FaultType"
        Me.txtFaultType.Top = 0.5900001!
        Me.txtFaultType.Width = 1.15!
        '
        'txtSeverityRating
        '
        Me.txtSeverityRating.DataField = "severityrating"
        Me.txtSeverityRating.Height = 0.15!
        Me.txtSeverityRating.HyperLink = Nothing
        Me.txtSeverityRating.Left = 7.0!
        Me.txtSeverityRating.Name = "txtSeverityRating"
        Me.txtSeverityRating.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtSeverityRating.Text = "Severity Rating"
        Me.txtSeverityRating.Top = 0.7900001!
        Me.txtSeverityRating.Width = 0.5!
        '
        'lnKeywordsLeft
        '
        Me.lnKeywordsLeft.Height = 0.35!
        Me.lnKeywordsLeft.Left = 8.1!
        Me.lnKeywordsLeft.LineWeight = 1.0!
        Me.lnKeywordsLeft.Name = "lnKeywordsLeft"
        Me.lnKeywordsLeft.Top = 0.5900001!
        Me.lnKeywordsLeft.Width = 0.0!
        Me.lnKeywordsLeft.X1 = 8.1!
        Me.lnKeywordsLeft.X2 = 8.1!
        Me.lnKeywordsLeft.Y1 = 0.5900001!
        Me.lnKeywordsLeft.Y2 = 0.9400001!
        '
        'lnKeywordsTop
        '
        Me.lnKeywordsTop.Height = 0.0!
        Me.lnKeywordsTop.Left = 8.1!
        Me.lnKeywordsTop.LineWeight = 1.0!
        Me.lnKeywordsTop.Name = "lnKeywordsTop"
        Me.lnKeywordsTop.Top = 0.5900001!
        Me.lnKeywordsTop.Width = 1.85!
        Me.lnKeywordsTop.X1 = 8.1!
        Me.lnKeywordsTop.X2 = 9.950001!
        Me.lnKeywordsTop.Y1 = 0.5900001!
        Me.lnKeywordsTop.Y2 = 0.5900001!
        '
        'lnKeywordsBottom
        '
        Me.lnKeywordsBottom.Height = 0.0!
        Me.lnKeywordsBottom.Left = 8.1!
        Me.lnKeywordsBottom.LineWeight = 1.0!
        Me.lnKeywordsBottom.Name = "lnKeywordsBottom"
        Me.lnKeywordsBottom.Top = 0.9400001!
        Me.lnKeywordsBottom.Width = 1.85!
        Me.lnKeywordsBottom.X1 = 8.1!
        Me.lnKeywordsBottom.X2 = 9.950001!
        Me.lnKeywordsBottom.Y1 = 0.9400001!
        Me.lnKeywordsBottom.Y2 = 0.9400001!
        '
        'lblRecNumber
        '
        Me.lblRecNumber.Height = 0.15!
        Me.lblRecNumber.HyperLink = Nothing
        Me.lblRecNumber.Left = 0.0000004768372!
        Me.lblRecNumber.Name = "lblRecNumber"
        Me.lblRecNumber.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblRecNumber.Text = "Rec. No."
        Me.lblRecNumber.Top = 0.3900001!
        Me.lblRecNumber.Width = 0.65!
        '
        'lblResponseDate
        '
        Me.lblResponseDate.Height = 0.15!
        Me.lblResponseDate.HyperLink = Nothing
        Me.lblResponseDate.Left = 0.102!
        Me.lblResponseDate.Name = "lblResponseDate"
        Me.lblResponseDate.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblResponseDate.Text = "Date of Response"
        Me.lblResponseDate.Top = 1.39!
        Me.lblResponseDate.Width = 0.798!
        '
        'lblIntendedAction
        '
        Me.lblIntendedAction.Height = 0.15!
        Me.lblIntendedAction.HyperLink = Nothing
        Me.lblIntendedAction.Left = 4.16!
        Me.lblIntendedAction.Name = "lblIntendedAction"
        Me.lblIntendedAction.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblIntendedAction.Text = "Intended Action"
        Me.lblIntendedAction.Top = 1.39!
        Me.lblIntendedAction.Width = 0.938!
        '
        'lblResponseFrom
        '
        Me.lblResponseFrom.Height = 0.15!
        Me.lblResponseFrom.HyperLink = Nothing
        Me.lblResponseFrom.Left = 2.196!
        Me.lblResponseFrom.Name = "lblResponseFrom"
        Me.lblResponseFrom.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblResponseFrom.Text = "Response From"
        Me.lblResponseFrom.Top = 1.39!
        Me.lblResponseFrom.Width = 0.704!
        '
        'lblExpectedCompletionDate
        '
        Me.lblExpectedCompletionDate.Height = 0.15!
        Me.lblExpectedCompletionDate.HyperLink = Nothing
        Me.lblExpectedCompletionDate.Left = 7.25!
        Me.lblExpectedCompletionDate.Name = "lblExpectedCompletionDate"
        Me.lblExpectedCompletionDate.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblExpectedCompletionDate.Text = "Exp. Comp. Date"
        Me.lblExpectedCompletionDate.Top = 1.39!
        Me.lblExpectedCompletionDate.Width = 0.81!
        '
        'lblImpact
        '
        Me.lblImpact.Height = 0.125!
        Me.lblImpact.HyperLink = Nothing
        Me.lblImpact.Left = 6.4375!
        Me.lblImpact.Name = "lblImpact"
        Me.lblImpact.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblImpact.Text = "Impact"
        Me.lblImpact.Top = 0.6025001!
        Me.lblImpact.Width = 0.5!
        '
        'lblStatus
        '
        Me.lblStatus.Height = 0.15!
        Me.lblStatus.HyperLink = Nothing
        Me.lblStatus.Left = 7.550001!
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblStatus.Text = "Status"
        Me.lblStatus.Top = 0.3900001!
        Me.lblStatus.Width = 0.5!
        '
        'txtClientLocNo
        '
        Me.txtClientLocNo.DataField = "ClientLocNo"
        Me.txtClientLocNo.Height = 0.3!
        Me.txtClientLocNo.HyperLink = Nothing
        Me.txtClientLocNo.Left = 0.9000005!
        Me.txtClientLocNo.Name = "txtClientLocNo"
        Me.txtClientLocNo.Style = "font-size: 8pt; font-weight: bold; vertical-align: middle"
        Me.txtClientLocNo.Text = "Client Loc No"
        Me.txtClientLocNo.Top = 0.04000008!
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
        Me.txtTIV.Top = 0.04000008!
        Me.txtTIV.Width = 0.5500008!
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
        Me.txtFacility.Top = 0.04000008!
        Me.txtFacility.Width = 1.2!
        '
        'lblStatusDate
        '
        Me.lblStatusDate.Height = 0.15!
        Me.lblStatusDate.HyperLink = Nothing
        Me.lblStatusDate.Left = 8.870001!
        Me.lblStatusDate.Name = "lblStatusDate"
        Me.lblStatusDate.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblStatusDate.Text = "Status Date"
        Me.lblStatusDate.Top = 0.3900001!
        Me.lblStatusDate.Width = 0.57!
        '
        'lnSecondaryLeft
        '
        Me.lnSecondaryLeft.Height = 0.125!
        Me.lnSecondaryLeft.Left = 5.125!
        Me.lnSecondaryLeft.LineWeight = 1.0!
        Me.lnSecondaryLeft.Name = "lnSecondaryLeft"
        Me.lnSecondaryLeft.Top = 0.4150001!
        Me.lnSecondaryLeft.Width = 0.0!
        Me.lnSecondaryLeft.X1 = 5.125!
        Me.lnSecondaryLeft.X2 = 5.125!
        Me.lnSecondaryLeft.Y1 = 0.4150001!
        Me.lnSecondaryLeft.Y2 = 0.5400001!
        '
        'lnSecondaryRight
        '
        Me.lnSecondaryRight.Height = 0.125!
        Me.lnSecondaryRight.Left = 6.375!
        Me.lnSecondaryRight.LineWeight = 1.0!
        Me.lnSecondaryRight.Name = "lnSecondaryRight"
        Me.lnSecondaryRight.Top = 0.4150001!
        Me.lnSecondaryRight.Width = 0.0!
        Me.lnSecondaryRight.X1 = 6.375!
        Me.lnSecondaryRight.X2 = 6.375!
        Me.lnSecondaryRight.Y1 = 0.4150001!
        Me.lnSecondaryRight.Y2 = 0.5400001!
        '
        'lnSecondaryTop
        '
        Me.lnSecondaryTop.Height = 0.0!
        Me.lnSecondaryTop.Left = 5.125!
        Me.lnSecondaryTop.LineWeight = 1.0!
        Me.lnSecondaryTop.Name = "lnSecondaryTop"
        Me.lnSecondaryTop.Top = 0.4150001!
        Me.lnSecondaryTop.Width = 1.25!
        Me.lnSecondaryTop.X1 = 5.125!
        Me.lnSecondaryTop.X2 = 6.375!
        Me.lnSecondaryTop.Y1 = 0.4150001!
        Me.lnSecondaryTop.Y2 = 0.4150001!
        '
        'lnSecondaryBottom
        '
        Me.lnSecondaryBottom.Height = 0.0!
        Me.lnSecondaryBottom.Left = 5.125!
        Me.lnSecondaryBottom.LineWeight = 1.0!
        Me.lnSecondaryBottom.Name = "lnSecondaryBottom"
        Me.lnSecondaryBottom.Top = 0.5400001!
        Me.lnSecondaryBottom.Width = 1.25!
        Me.lnSecondaryBottom.X1 = 5.125!
        Me.lnSecondaryBottom.X2 = 6.375!
        Me.lnSecondaryBottom.Y1 = 0.5400001!
        Me.lnSecondaryBottom.Y2 = 0.5400001!
        '
        'lnIntendedActionTop
        '
        Me.lnIntendedActionTop.Height = 0.0!
        Me.lnIntendedActionTop.Left = 5.125!
        Me.lnIntendedActionTop.LineWeight = 1.0!
        Me.lnIntendedActionTop.Name = "lnIntendedActionTop"
        Me.lnIntendedActionTop.Top = 1.415!
        Me.lnIntendedActionTop.Width = 2.0!
        Me.lnIntendedActionTop.X1 = 5.125!
        Me.lnIntendedActionTop.X2 = 7.125!
        Me.lnIntendedActionTop.Y1 = 1.415!
        Me.lnIntendedActionTop.Y2 = 1.415!
        '
        'lnDetectedWithTop
        '
        Me.lnDetectedWithTop.Height = 0.0!
        Me.lnDetectedWithTop.Left = 5.125!
        Me.lnDetectedWithTop.LineWeight = 1.0!
        Me.lnDetectedWithTop.Name = "lnDetectedWithTop"
        Me.lnDetectedWithTop.Top = 0.6025001!
        Me.lnDetectedWithTop.Width = 1.25!
        Me.lnDetectedWithTop.X1 = 5.125!
        Me.lnDetectedWithTop.X2 = 6.375!
        Me.lnDetectedWithTop.Y1 = 0.6025001!
        Me.lnDetectedWithTop.Y2 = 0.6025001!
        '
        'lnDetectedWithBottom
        '
        Me.lnDetectedWithBottom.Height = 0.0!
        Me.lnDetectedWithBottom.Left = 5.125!
        Me.lnDetectedWithBottom.LineWeight = 1.0!
        Me.lnDetectedWithBottom.Name = "lnDetectedWithBottom"
        Me.lnDetectedWithBottom.Top = 0.7275001!
        Me.lnDetectedWithBottom.Width = 1.25!
        Me.lnDetectedWithBottom.X1 = 5.125!
        Me.lnDetectedWithBottom.X2 = 6.375!
        Me.lnDetectedWithBottom.Y1 = 0.7275001!
        Me.lnDetectedWithBottom.Y2 = 0.7275001!
        '
        'lnIntendedActionBottom
        '
        Me.lnIntendedActionBottom.Height = 0.0!
        Me.lnIntendedActionBottom.Left = 5.125!
        Me.lnIntendedActionBottom.LineWeight = 1.0!
        Me.lnIntendedActionBottom.Name = "lnIntendedActionBottom"
        Me.lnIntendedActionBottom.Top = 1.54!
        Me.lnIntendedActionBottom.Width = 2.0!
        Me.lnIntendedActionBottom.X1 = 5.125!
        Me.lnIntendedActionBottom.X2 = 7.125!
        Me.lnIntendedActionBottom.Y1 = 1.54!
        Me.lnIntendedActionBottom.Y2 = 1.54!
        '
        'lnDetectedWithLeft
        '
        Me.lnDetectedWithLeft.Height = 0.125!
        Me.lnDetectedWithLeft.Left = 5.125!
        Me.lnDetectedWithLeft.LineWeight = 1.0!
        Me.lnDetectedWithLeft.Name = "lnDetectedWithLeft"
        Me.lnDetectedWithLeft.Top = 0.6025001!
        Me.lnDetectedWithLeft.Width = 0.0!
        Me.lnDetectedWithLeft.X1 = 5.125!
        Me.lnDetectedWithLeft.X2 = 5.125!
        Me.lnDetectedWithLeft.Y1 = 0.6025001!
        Me.lnDetectedWithLeft.Y2 = 0.7275001!
        '
        'lnDetectedWithRight
        '
        Me.lnDetectedWithRight.Height = 0.125!
        Me.lnDetectedWithRight.Left = 6.375!
        Me.lnDetectedWithRight.LineWeight = 1.0!
        Me.lnDetectedWithRight.Name = "lnDetectedWithRight"
        Me.lnDetectedWithRight.Top = 0.6025001!
        Me.lnDetectedWithRight.Width = 0.0!
        Me.lnDetectedWithRight.X1 = 6.375!
        Me.lnDetectedWithRight.X2 = 6.375!
        Me.lnDetectedWithRight.Y1 = 0.6025001!
        Me.lnDetectedWithRight.Y2 = 0.7275001!
        '
        'lnIntendedActionLeft
        '
        Me.lnIntendedActionLeft.Height = 0.125!
        Me.lnIntendedActionLeft.Left = 5.125!
        Me.lnIntendedActionLeft.LineWeight = 1.0!
        Me.lnIntendedActionLeft.Name = "lnIntendedActionLeft"
        Me.lnIntendedActionLeft.Top = 1.415!
        Me.lnIntendedActionLeft.Width = 0.0!
        Me.lnIntendedActionLeft.X1 = 5.125!
        Me.lnIntendedActionLeft.X2 = 5.125!
        Me.lnIntendedActionLeft.Y1 = 1.415!
        Me.lnIntendedActionLeft.Y2 = 1.54!
        '
        'lnIntendedActionRight
        '
        Me.lnIntendedActionRight.Height = 0.125!
        Me.lnIntendedActionRight.Left = 7.125!
        Me.lnIntendedActionRight.LineWeight = 1.0!
        Me.lnIntendedActionRight.Name = "lnIntendedActionRight"
        Me.lnIntendedActionRight.Top = 1.415!
        Me.lnIntendedActionRight.Width = 0.0!
        Me.lnIntendedActionRight.X1 = 7.125!
        Me.lnIntendedActionRight.X2 = 7.125!
        Me.lnIntendedActionRight.Y1 = 1.415!
        Me.lnIntendedActionRight.Y2 = 1.54!
        '
        'lnHistoryTop
        '
        Me.lnHistoryTop.Height = 0.0!
        Me.lnHistoryTop.Left = 7.0!
        Me.lnHistoryTop.LineWeight = 1.0!
        Me.lnHistoryTop.Name = "lnHistoryTop"
        Me.lnHistoryTop.Top = 0.3900001!
        Me.lnHistoryTop.Width = 0.5!
        Me.lnHistoryTop.X1 = 7.0!
        Me.lnHistoryTop.X2 = 7.5!
        Me.lnHistoryTop.Y1 = 0.3900001!
        Me.lnHistoryTop.Y2 = 0.3900001!
        '
        'lnHistoryBottom
        '
        Me.lnHistoryBottom.Height = 0.0!
        Me.lnHistoryBottom.Left = 7.0!
        Me.lnHistoryBottom.LineWeight = 1.0!
        Me.lnHistoryBottom.Name = "lnHistoryBottom"
        Me.lnHistoryBottom.Top = 0.5400001!
        Me.lnHistoryBottom.Width = 0.5!
        Me.lnHistoryBottom.X1 = 7.0!
        Me.lnHistoryBottom.X2 = 7.5!
        Me.lnHistoryBottom.Y1 = 0.5400001!
        Me.lnHistoryBottom.Y2 = 0.5400001!
        '
        'lnImpactTop
        '
        Me.lnImpactTop.Height = 0.0!
        Me.lnImpactTop.Left = 7.0!
        Me.lnImpactTop.LineWeight = 1.0!
        Me.lnImpactTop.Name = "lnImpactTop"
        Me.lnImpactTop.Top = 0.5900001!
        Me.lnImpactTop.Width = 0.5!
        Me.lnImpactTop.X1 = 7.0!
        Me.lnImpactTop.X2 = 7.5!
        Me.lnImpactTop.Y1 = 0.5900001!
        Me.lnImpactTop.Y2 = 0.5900001!
        '
        'lnStatusRight
        '
        Me.lnStatusRight.Height = 0.15!
        Me.lnStatusRight.Left = 8.85!
        Me.lnStatusRight.LineWeight = 1.0!
        Me.lnStatusRight.Name = "lnStatusRight"
        Me.lnStatusRight.Top = 0.3900001!
        Me.lnStatusRight.Width = 0.0!
        Me.lnStatusRight.X1 = 8.85!
        Me.lnStatusRight.X2 = 8.85!
        Me.lnStatusRight.Y1 = 0.3900001!
        Me.lnStatusRight.Y2 = 0.5400001!
        '
        'lnImpactLeft
        '
        Me.lnImpactLeft.Height = 0.15!
        Me.lnImpactLeft.Left = 7.0!
        Me.lnImpactLeft.LineWeight = 1.0!
        Me.lnImpactLeft.Name = "lnImpactLeft"
        Me.lnImpactLeft.Top = 0.5900001!
        Me.lnImpactLeft.Width = 0.0!
        Me.lnImpactLeft.X1 = 7.0!
        Me.lnImpactLeft.X2 = 7.0!
        Me.lnImpactLeft.Y1 = 0.5900001!
        Me.lnImpactLeft.Y2 = 0.7400001!
        '
        'lnImpactBottom
        '
        Me.lnImpactBottom.Height = 0.0!
        Me.lnImpactBottom.Left = 7.0!
        Me.lnImpactBottom.LineWeight = 1.0!
        Me.lnImpactBottom.Name = "lnImpactBottom"
        Me.lnImpactBottom.Top = 0.7400001!
        Me.lnImpactBottom.Width = 0.5!
        Me.lnImpactBottom.X1 = 7.0!
        Me.lnImpactBottom.X2 = 7.5!
        Me.lnImpactBottom.Y1 = 0.7400001!
        Me.lnImpactBottom.Y2 = 0.7400001!
        '
        'lnStatusLeft
        '
        Me.lnStatusLeft.Height = 0.15!
        Me.lnStatusLeft.Left = 8.1!
        Me.lnStatusLeft.LineWeight = 1.0!
        Me.lnStatusLeft.Name = "lnStatusLeft"
        Me.lnStatusLeft.Top = 0.3900001!
        Me.lnStatusLeft.Width = 0.0!
        Me.lnStatusLeft.X1 = 8.1!
        Me.lnStatusLeft.X2 = 8.1!
        Me.lnStatusLeft.Y1 = 0.3900001!
        Me.lnStatusLeft.Y2 = 0.5400001!
        '
        'lnHistoryLeft
        '
        Me.lnHistoryLeft.Height = 0.15!
        Me.lnHistoryLeft.Left = 7.0!
        Me.lnHistoryLeft.LineWeight = 1.0!
        Me.lnHistoryLeft.Name = "lnHistoryLeft"
        Me.lnHistoryLeft.Top = 0.3900001!
        Me.lnHistoryLeft.Width = 0.0!
        Me.lnHistoryLeft.X1 = 7.0!
        Me.lnHistoryLeft.X2 = 7.0!
        Me.lnHistoryLeft.Y1 = 0.3900001!
        Me.lnHistoryLeft.Y2 = 0.5400001!
        '
        'lnReponseFromBottom
        '
        Me.lnReponseFromBottom.Height = 0.0!
        Me.lnReponseFromBottom.Left = 2.950001!
        Me.lnReponseFromBottom.LineWeight = 1.0!
        Me.lnReponseFromBottom.Name = "lnReponseFromBottom"
        Me.lnReponseFromBottom.Top = 1.54!
        Me.lnReponseFromBottom.Width = 1.149999!
        Me.lnReponseFromBottom.X1 = 2.950001!
        Me.lnReponseFromBottom.X2 = 4.1!
        Me.lnReponseFromBottom.Y1 = 1.54!
        Me.lnReponseFromBottom.Y2 = 1.54!
        '
        'lnPrimaryTop
        '
        Me.lnPrimaryTop.Height = 0.0!
        Me.lnPrimaryTop.Left = 2.950001!
        Me.lnPrimaryTop.LineWeight = 1.0!
        Me.lnPrimaryTop.Name = "lnPrimaryTop"
        Me.lnPrimaryTop.Top = 0.3900001!
        Me.lnPrimaryTop.Width = 1.149999!
        Me.lnPrimaryTop.X1 = 2.950001!
        Me.lnPrimaryTop.X2 = 4.1!
        Me.lnPrimaryTop.Y1 = 0.3900001!
        Me.lnPrimaryTop.Y2 = 0.3900001!
        '
        'lnPrimaryBottom
        '
        Me.lnPrimaryBottom.Height = 0.0!
        Me.lnPrimaryBottom.Left = 2.950001!
        Me.lnPrimaryBottom.LineWeight = 1.0!
        Me.lnPrimaryBottom.Name = "lnPrimaryBottom"
        Me.lnPrimaryBottom.Top = 0.5400001!
        Me.lnPrimaryBottom.Width = 1.149999!
        Me.lnPrimaryBottom.X1 = 2.950001!
        Me.lnPrimaryBottom.X2 = 4.1!
        Me.lnPrimaryBottom.Y1 = 0.5400001!
        Me.lnPrimaryBottom.Y2 = 0.5400001!
        '
        'lnFaultTypeTop
        '
        Me.lnFaultTypeTop.Height = 0.0!
        Me.lnFaultTypeTop.Left = 2.950001!
        Me.lnFaultTypeTop.LineWeight = 1.0!
        Me.lnFaultTypeTop.Name = "lnFaultTypeTop"
        Me.lnFaultTypeTop.Top = 0.5900001!
        Me.lnFaultTypeTop.Width = 1.149999!
        Me.lnFaultTypeTop.X1 = 2.950001!
        Me.lnFaultTypeTop.X2 = 4.1!
        Me.lnFaultTypeTop.Y1 = 0.5900001!
        Me.lnFaultTypeTop.Y2 = 0.5900001!
        '
        'lnFaultTypeRight
        '
        Me.lnFaultTypeRight.Height = 0.15!
        Me.lnFaultTypeRight.Left = 4.1!
        Me.lnFaultTypeRight.LineWeight = 1.0!
        Me.lnFaultTypeRight.Name = "lnFaultTypeRight"
        Me.lnFaultTypeRight.Top = 0.5900001!
        Me.lnFaultTypeRight.Width = 0.0!
        Me.lnFaultTypeRight.X1 = 4.1!
        Me.lnFaultTypeRight.X2 = 4.1!
        Me.lnFaultTypeRight.Y1 = 0.5900001!
        Me.lnFaultTypeRight.Y2 = 0.7400001!
        '
        'lnFaultTypeLeft
        '
        Me.lnFaultTypeLeft.Height = 0.15!
        Me.lnFaultTypeLeft.Left = 2.950001!
        Me.lnFaultTypeLeft.LineWeight = 1.0!
        Me.lnFaultTypeLeft.Name = "lnFaultTypeLeft"
        Me.lnFaultTypeLeft.Top = 0.5900001!
        Me.lnFaultTypeLeft.Width = 0.0!
        Me.lnFaultTypeLeft.X1 = 2.950001!
        Me.lnFaultTypeLeft.X2 = 2.950001!
        Me.lnFaultTypeLeft.Y1 = 0.5900001!
        Me.lnFaultTypeLeft.Y2 = 0.7400001!
        '
        'lnReponseFromLeft
        '
        Me.lnReponseFromLeft.Height = 0.15!
        Me.lnReponseFromLeft.Left = 2.950001!
        Me.lnReponseFromLeft.LineWeight = 1.0!
        Me.lnReponseFromLeft.Name = "lnReponseFromLeft"
        Me.lnReponseFromLeft.Top = 1.39!
        Me.lnReponseFromLeft.Width = 0.0!
        Me.lnReponseFromLeft.X1 = 2.950001!
        Me.lnReponseFromLeft.X2 = 2.950001!
        Me.lnReponseFromLeft.Y1 = 1.39!
        Me.lnReponseFromLeft.Y2 = 1.54!
        '
        'lnFaultTypeBottom
        '
        Me.lnFaultTypeBottom.Height = 0.0!
        Me.lnFaultTypeBottom.Left = 2.950001!
        Me.lnFaultTypeBottom.LineWeight = 1.0!
        Me.lnFaultTypeBottom.Name = "lnFaultTypeBottom"
        Me.lnFaultTypeBottom.Top = 0.7400001!
        Me.lnFaultTypeBottom.Width = 1.149999!
        Me.lnFaultTypeBottom.X1 = 2.950001!
        Me.lnFaultTypeBottom.X2 = 4.1!
        Me.lnFaultTypeBottom.Y1 = 0.7400001!
        Me.lnFaultTypeBottom.Y2 = 0.7400001!
        '
        'lnReponseFromRight
        '
        Me.lnReponseFromRight.Height = 0.15!
        Me.lnReponseFromRight.Left = 4.1!
        Me.lnReponseFromRight.LineWeight = 1.0!
        Me.lnReponseFromRight.Name = "lnReponseFromRight"
        Me.lnReponseFromRight.Top = 1.39!
        Me.lnReponseFromRight.Width = 0.0!
        Me.lnReponseFromRight.X1 = 4.1!
        Me.lnReponseFromRight.X2 = 4.1!
        Me.lnReponseFromRight.Y1 = 1.39!
        Me.lnReponseFromRight.Y2 = 1.54!
        '
        'lnRecNoTop
        '
        Me.lnRecNoTop.Height = 0.0!
        Me.lnRecNoTop.Left = 0.7000005!
        Me.lnRecNoTop.LineWeight = 1.0!
        Me.lnRecNoTop.Name = "lnRecNoTop"
        Me.lnRecNoTop.Top = 0.3900001!
        Me.lnRecNoTop.Width = 0.6999995!
        Me.lnRecNoTop.X1 = 0.7000005!
        Me.lnRecNoTop.X2 = 1.4!
        Me.lnRecNoTop.Y1 = 0.3900001!
        Me.lnRecNoTop.Y2 = 0.3900001!
        '
        'lnLEBeforeRight
        '
        Me.lnLEBeforeRight.Height = 0.15!
        Me.lnLEBeforeRight.Left = 2.25!
        Me.lnLEBeforeRight.LineWeight = 1.0!
        Me.lnLEBeforeRight.Name = "lnLEBeforeRight"
        Me.lnLEBeforeRight.Top = 0.5900001!
        Me.lnLEBeforeRight.Width = 0.0!
        Me.lnLEBeforeRight.X1 = 2.25!
        Me.lnLEBeforeRight.X2 = 2.25!
        Me.lnLEBeforeRight.Y1 = 0.5900001!
        Me.lnLEBeforeRight.Y2 = 0.7400001!
        '
        'lnLEBeforeLeft
        '
        Me.lnLEBeforeLeft.Height = 0.15!
        Me.lnLEBeforeLeft.Left = 0.7000005!
        Me.lnLEBeforeLeft.LineWeight = 1.0!
        Me.lnLEBeforeLeft.Name = "lnLEBeforeLeft"
        Me.lnLEBeforeLeft.Top = 0.5900001!
        Me.lnLEBeforeLeft.Width = 0.0!
        Me.lnLEBeforeLeft.X1 = 0.7000005!
        Me.lnLEBeforeLeft.X2 = 0.7000005!
        Me.lnLEBeforeLeft.Y1 = 0.5900001!
        Me.lnLEBeforeLeft.Y2 = 0.7400001!
        '
        'lnRecYearLeft
        '
        Me.lnRecYearLeft.Height = 0.15!
        Me.lnRecYearLeft.Left = 0.7000005!
        Me.lnRecYearLeft.LineWeight = 1.0!
        Me.lnRecYearLeft.Name = "lnRecYearLeft"
        Me.lnRecYearLeft.Top = 0.3900001!
        Me.lnRecYearLeft.Width = 0.0!
        Me.lnRecYearLeft.X1 = 0.7000005!
        Me.lnRecYearLeft.X2 = 0.7000005!
        Me.lnRecYearLeft.Y1 = 0.3900001!
        Me.lnRecYearLeft.Y2 = 0.5400001!
        '
        'lnLEBeforeBottom
        '
        Me.lnLEBeforeBottom.Height = 0.0!
        Me.lnLEBeforeBottom.Left = 0.7000005!
        Me.lnLEBeforeBottom.LineWeight = 1.0!
        Me.lnLEBeforeBottom.Name = "lnLEBeforeBottom"
        Me.lnLEBeforeBottom.Top = 0.7400001!
        Me.lnLEBeforeBottom.Width = 1.549999!
        Me.lnLEBeforeBottom.X1 = 0.7000005!
        Me.lnLEBeforeBottom.X2 = 2.25!
        Me.lnLEBeforeBottom.Y1 = 0.7400001!
        Me.lnLEBeforeBottom.Y2 = 0.7400001!
        '
        'lnReponseFromTop
        '
        Me.lnReponseFromTop.Height = 0.0!
        Me.lnReponseFromTop.Left = 2.950001!
        Me.lnReponseFromTop.LineWeight = 1.0!
        Me.lnReponseFromTop.Name = "lnReponseFromTop"
        Me.lnReponseFromTop.Top = 1.39!
        Me.lnReponseFromTop.Width = 1.149999!
        Me.lnReponseFromTop.X1 = 2.950001!
        Me.lnReponseFromTop.X2 = 4.1!
        Me.lnReponseFromTop.Y1 = 1.39!
        Me.lnReponseFromTop.Y2 = 1.39!
        '
        'lnRecSubletterRight
        '
        Me.lnRecSubletterRight.Height = 0.15!
        Me.lnRecSubletterRight.Left = 1.4!
        Me.lnRecSubletterRight.LineWeight = 1.0!
        Me.lnRecSubletterRight.Name = "lnRecSubletterRight"
        Me.lnRecSubletterRight.Top = 0.3900001!
        Me.lnRecSubletterRight.Width = 0.0!
        Me.lnRecSubletterRight.X1 = 1.4!
        Me.lnRecSubletterRight.X2 = 1.4!
        Me.lnRecSubletterRight.Y1 = 0.3900001!
        Me.lnRecSubletterRight.Y2 = 0.5400001!
        '
        'lnRecMonthLeft
        '
        Me.lnRecMonthLeft.Height = 0.15!
        Me.lnRecMonthLeft.Left = 1.05!
        Me.lnRecMonthLeft.LineWeight = 1.0!
        Me.lnRecMonthLeft.Name = "lnRecMonthLeft"
        Me.lnRecMonthLeft.Top = 0.3900001!
        Me.lnRecMonthLeft.Width = 0.0!
        Me.lnRecMonthLeft.X1 = 1.05!
        Me.lnRecMonthLeft.X2 = 1.05!
        Me.lnRecMonthLeft.Y1 = 0.3900001!
        Me.lnRecMonthLeft.Y2 = 0.5400001!
        '
        'lnRecNumber
        '
        Me.lnRecNumber.Height = 0.15!
        Me.lnRecNumber.Left = 1.25!
        Me.lnRecNumber.LineWeight = 1.0!
        Me.lnRecNumber.Name = "lnRecNumber"
        Me.lnRecNumber.Top = 0.3900001!
        Me.lnRecNumber.Width = 0.0!
        Me.lnRecNumber.X1 = 1.25!
        Me.lnRecNumber.X2 = 1.25!
        Me.lnRecNumber.Y1 = 0.3900001!
        Me.lnRecNumber.Y2 = 0.5400001!
        '
        'lnPrimaryRight
        '
        Me.lnPrimaryRight.Height = 0.15!
        Me.lnPrimaryRight.Left = 4.1!
        Me.lnPrimaryRight.LineWeight = 1.0!
        Me.lnPrimaryRight.Name = "lnPrimaryRight"
        Me.lnPrimaryRight.Top = 0.3900001!
        Me.lnPrimaryRight.Width = 0.0!
        Me.lnPrimaryRight.X1 = 4.1!
        Me.lnPrimaryRight.X2 = 4.1!
        Me.lnPrimaryRight.Y1 = 0.3900001!
        Me.lnPrimaryRight.Y2 = 0.5400001!
        '
        'lnHistoryRight
        '
        Me.lnHistoryRight.Height = 0.15!
        Me.lnHistoryRight.Left = 7.5!
        Me.lnHistoryRight.LineWeight = 1.0!
        Me.lnHistoryRight.Name = "lnHistoryRight"
        Me.lnHistoryRight.Top = 0.3900001!
        Me.lnHistoryRight.Width = 0.0!
        Me.lnHistoryRight.X1 = 7.5!
        Me.lnHistoryRight.X2 = 7.5!
        Me.lnHistoryRight.Y1 = 0.3900001!
        Me.lnHistoryRight.Y2 = 0.5400001!
        '
        'lnImpactRight
        '
        Me.lnImpactRight.Height = 0.15!
        Me.lnImpactRight.Left = 7.5!
        Me.lnImpactRight.LineWeight = 1.0!
        Me.lnImpactRight.Name = "lnImpactRight"
        Me.lnImpactRight.Top = 0.5900001!
        Me.lnImpactRight.Width = 0.0!
        Me.lnImpactRight.X1 = 7.5!
        Me.lnImpactRight.X2 = 7.5!
        Me.lnImpactRight.Y1 = 0.5900001!
        Me.lnImpactRight.Y2 = 0.7400001!
        '
        'lnStatusDateLeft
        '
        Me.lnStatusDateLeft.Height = 0.15!
        Me.lnStatusDateLeft.Left = 9.49!
        Me.lnStatusDateLeft.LineWeight = 1.0!
        Me.lnStatusDateLeft.Name = "lnStatusDateLeft"
        Me.lnStatusDateLeft.Top = 0.3900001!
        Me.lnStatusDateLeft.Width = 0.0!
        Me.lnStatusDateLeft.X1 = 9.49!
        Me.lnStatusDateLeft.X2 = 9.49!
        Me.lnStatusDateLeft.Y1 = 0.3900001!
        Me.lnStatusDateLeft.Y2 = 0.5400001!
        '
        'lnStatusTop
        '
        Me.lnStatusTop.Height = 0.0!
        Me.lnStatusTop.Left = 8.1!
        Me.lnStatusTop.LineWeight = 1.0!
        Me.lnStatusTop.Name = "lnStatusTop"
        Me.lnStatusTop.Top = 0.3900001!
        Me.lnStatusTop.Width = 0.75!
        Me.lnStatusTop.X1 = 8.1!
        Me.lnStatusTop.X2 = 8.85!
        Me.lnStatusTop.Y1 = 0.3900001!
        Me.lnStatusTop.Y2 = 0.3900001!
        '
        'lnStatusBottom
        '
        Me.lnStatusBottom.Height = 0.0!
        Me.lnStatusBottom.Left = 8.1!
        Me.lnStatusBottom.LineWeight = 1.0!
        Me.lnStatusBottom.Name = "lnStatusBottom"
        Me.lnStatusBottom.Top = 0.5400001!
        Me.lnStatusBottom.Width = 0.75!
        Me.lnStatusBottom.X1 = 8.1!
        Me.lnStatusBottom.X2 = 8.85!
        Me.lnStatusBottom.Y1 = 0.5400001!
        Me.lnStatusBottom.Y2 = 0.5400001!
        '
        'lnStatusDateTop
        '
        Me.lnStatusDateTop.Height = 0.0!
        Me.lnStatusDateTop.Left = 9.49!
        Me.lnStatusDateTop.LineWeight = 1.0!
        Me.lnStatusDateTop.Name = "lnStatusDateTop"
        Me.lnStatusDateTop.Top = 0.3900001!
        Me.lnStatusDateTop.Width = 0.460001!
        Me.lnStatusDateTop.X1 = 9.49!
        Me.lnStatusDateTop.X2 = 9.950001!
        Me.lnStatusDateTop.Y1 = 0.3900001!
        Me.lnStatusDateTop.Y2 = 0.3900001!
        '
        'lnStatusDateBottom
        '
        Me.lnStatusDateBottom.Height = 0.0!
        Me.lnStatusDateBottom.Left = 9.49!
        Me.lnStatusDateBottom.LineWeight = 1.0!
        Me.lnStatusDateBottom.Name = "lnStatusDateBottom"
        Me.lnStatusDateBottom.Top = 0.5400001!
        Me.lnStatusDateBottom.Width = 0.460001!
        Me.lnStatusDateBottom.X1 = 9.49!
        Me.lnStatusDateBottom.X2 = 9.950001!
        Me.lnStatusDateBottom.Y1 = 0.5400001!
        Me.lnStatusDateBottom.Y2 = 0.5400001!
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
        Me.txtStProv.Top = 0.04000008!
        Me.txtStProv.Width = 0.45!
        '
        'lnPrimaryLeft
        '
        Me.lnPrimaryLeft.Height = 0.15!
        Me.lnPrimaryLeft.Left = 2.950001!
        Me.lnPrimaryLeft.LineWeight = 1.0!
        Me.lnPrimaryLeft.Name = "lnPrimaryLeft"
        Me.lnPrimaryLeft.Top = 0.3900001!
        Me.lnPrimaryLeft.Width = 0.0!
        Me.lnPrimaryLeft.X1 = 2.950001!
        Me.lnPrimaryLeft.X2 = 2.950001!
        Me.lnPrimaryLeft.Y1 = 0.3900001!
        Me.lnPrimaryLeft.Y2 = 0.5400001!
        '
        'lnRecNoBottom
        '
        Me.lnRecNoBottom.Height = 0.0!
        Me.lnRecNoBottom.Left = 0.7000005!
        Me.lnRecNoBottom.LineWeight = 1.0!
        Me.lnRecNoBottom.Name = "lnRecNoBottom"
        Me.lnRecNoBottom.Top = 0.5400001!
        Me.lnRecNoBottom.Width = 0.6999995!
        Me.lnRecNoBottom.X1 = 0.7000005!
        Me.lnRecNoBottom.X2 = 1.4!
        Me.lnRecNoBottom.Y1 = 0.5400001!
        Me.lnRecNoBottom.Y2 = 0.5400001!
        '
        'txtPlantComment
        '
        Me.txtPlantComment.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPlantComment.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPlantComment.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPlantComment.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtPlantComment.DataField = "PlantCommentLineBreak"
        Me.txtPlantComment.Height = 0.35!
        Me.txtPlantComment.HyperLink = Nothing
        Me.txtPlantComment.Left = 0.9540001!
        Me.txtPlantComment.Name = "txtPlantComment"
        Me.txtPlantComment.Style = "font-size: 7pt; vertical-align: middle; ddo-char-set: 0"
        Me.txtPlantComment.Text = "PlantComment"
        Me.txtPlantComment.Top = 1.59!
        Me.txtPlantComment.Width = 8.996!
        '
        'lblResponseRequestDate
        '
        Me.lblResponseRequestDate.Height = 0.15!
        Me.lblResponseRequestDate.HyperLink = Nothing
        Me.lblResponseRequestDate.Left = 1.320001!
        Me.lblResponseRequestDate.Name = "lblResponseRequestDate"
        Me.lblResponseRequestDate.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblResponseRequestDate.Text = "Response Request Date"
        Me.lblResponseRequestDate.Top = 2.828!
        Me.lblResponseRequestDate.Width = 1.15!
        '
        'lblRequestDueDate
        '
        Me.lblRequestDueDate.Height = 0.15!
        Me.lblRequestDueDate.HyperLink = Nothing
        Me.lblRequestDueDate.Left = 1.320001!
        Me.lblRequestDueDate.Name = "lblRequestDueDate"
        Me.lblRequestDueDate.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblRequestDueDate.Text = "Request Due Date"
        Me.lblRequestDueDate.Top = 3.028!
        Me.lblRequestDueDate.Width = 1.15!
        '
        'txtRequestDueDate
        '
        Me.txtRequestDueDate.DataField = "RespDueDateString"
        Me.txtRequestDueDate.Height = 0.15!
        Me.txtRequestDueDate.HyperLink = Nothing
        Me.txtRequestDueDate.Left = 2.52!
        Me.txtRequestDueDate.Name = "txtRequestDueDate"
        Me.txtRequestDueDate.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtRequestDueDate.Text = "RespDueDate"
        Me.txtRequestDueDate.Top = 3.028!
        Me.txtRequestDueDate.Width = 1.15!
        '
        'txtResponseRequestDate
        '
        Me.txtResponseRequestDate.DataField = "RespRequestDateString"
        Me.txtResponseRequestDate.Height = 0.15!
        Me.txtResponseRequestDate.HyperLink = Nothing
        Me.txtResponseRequestDate.Left = 2.52!
        Me.txtResponseRequestDate.Name = "txtResponseRequestDate"
        Me.txtResponseRequestDate.Style = "font-size: 6.5pt; vertical-align: middle"
        Me.txtResponseRequestDate.Text = "RespRequestDate"
        Me.txtResponseRequestDate.Top = 2.828!
        Me.txtResponseRequestDate.Width = 1.15!
        '
        'shpResponseRequestDate
        '
        Me.shpResponseRequestDate.Height = 0.15!
        Me.shpResponseRequestDate.Left = 2.52!
        Me.shpResponseRequestDate.Name = "shpResponseRequestDate"
        Me.shpResponseRequestDate.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(0.0!, Nothing, Nothing, Nothing, Nothing)
        Me.shpResponseRequestDate.Top = 2.828!
        Me.shpResponseRequestDate.Width = 1.15!
        '
        'lblFirstFollowUp
        '
        Me.lblFirstFollowUp.Height = 0.15!
        Me.lblFirstFollowUp.HyperLink = Nothing
        Me.lblFirstFollowUp.Left = 3.720001!
        Me.lblFirstFollowUp.Name = "lblFirstFollowUp"
        Me.lblFirstFollowUp.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblFirstFollowUp.Text = "1st Follow-Up"
        Me.lblFirstFollowUp.Top = 2.828!
        Me.lblFirstFollowUp.Width = 1.07!
        '
        'txtFirstFollowUp
        '
        Me.txtFirstFollowUp.DataField = "RFU1DateString"
        Me.txtFirstFollowUp.Height = 0.15!
        Me.txtFirstFollowUp.HyperLink = Nothing
        Me.txtFirstFollowUp.Left = 4.840001!
        Me.txtFirstFollowUp.Name = "txtFirstFollowUp"
        Me.txtFirstFollowUp.Style = "font-size: 6.5pt; vertical-align: middle"
        Me.txtFirstFollowUp.Text = "1st Follow-Up"
        Me.txtFirstFollowUp.Top = 2.828!
        Me.txtFirstFollowUp.Width = 0.85!
        '
        'lblSecondFollowUp
        '
        Me.lblSecondFollowUp.Height = 0.15!
        Me.lblSecondFollowUp.HyperLink = Nothing
        Me.lblSecondFollowUp.Left = 3.720001!
        Me.lblSecondFollowUp.Name = "lblSecondFollowUp"
        Me.lblSecondFollowUp.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblSecondFollowUp.Text = "2nd Follow-Up"
        Me.lblSecondFollowUp.Top = 3.028!
        Me.lblSecondFollowUp.Width = 1.07!
        '
        'txtSecondFollowUp
        '
        Me.txtSecondFollowUp.DataField = "RFU2DateString"
        Me.txtSecondFollowUp.Height = 0.15!
        Me.txtSecondFollowUp.HyperLink = Nothing
        Me.txtSecondFollowUp.Left = 4.840001!
        Me.txtSecondFollowUp.Name = "txtSecondFollowUp"
        Me.txtSecondFollowUp.Style = "font-size: 6.5pt; vertical-align: middle"
        Me.txtSecondFollowUp.Text = "2nd Follow-Up"
        Me.txtSecondFollowUp.Top = 3.028!
        Me.txtSecondFollowUp.Width = 0.85!
        '
        'lblThirdFollowUp
        '
        Me.lblThirdFollowUp.Height = 0.15!
        Me.lblThirdFollowUp.HyperLink = Nothing
        Me.lblThirdFollowUp.Left = 3.720001!
        Me.lblThirdFollowUp.Name = "lblThirdFollowUp"
        Me.lblThirdFollowUp.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblThirdFollowUp.Text = "3rd Follow-Up"
        Me.lblThirdFollowUp.Top = 3.228!
        Me.lblThirdFollowUp.Width = 1.07!
        '
        'txtThirdFollowUp
        '
        Me.txtThirdFollowUp.DataField = "RFU3DateString"
        Me.txtThirdFollowUp.Height = 0.15!
        Me.txtThirdFollowUp.HyperLink = Nothing
        Me.txtThirdFollowUp.Left = 4.840001!
        Me.txtThirdFollowUp.Name = "txtThirdFollowUp"
        Me.txtThirdFollowUp.Style = "font-size: 6.5pt; vertical-align: middle"
        Me.txtThirdFollowUp.Text = "3rd Follow-Up"
        Me.txtThirdFollowUp.Top = 3.228!
        Me.txtThirdFollowUp.Width = 0.85!
        '
        'lblDaysOverdue
        '
        Me.lblDaysOverdue.Height = 0.15!
        Me.lblDaysOverdue.HyperLink = Nothing
        Me.lblDaysOverdue.Left = 1.320001!
        Me.lblDaysOverdue.Name = "lblDaysOverdue"
        Me.lblDaysOverdue.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblDaysOverdue.Text = "Days Overdue"
        Me.lblDaysOverdue.Top = 3.228!
        Me.lblDaysOverdue.Width = 1.15!
        '
        'txtDaysOverdue
        '
        Me.txtDaysOverdue.DataField = "DaysOverdue"
        Me.txtDaysOverdue.Height = 0.15!
        Me.txtDaysOverdue.HyperLink = Nothing
        Me.txtDaysOverdue.Left = 2.52!
        Me.txtDaysOverdue.Name = "txtDaysOverdue"
        Me.txtDaysOverdue.Style = "font-size: 6.5pt; vertical-align: middle"
        Me.txtDaysOverdue.Text = "DaysOverdue"
        Me.txtDaysOverdue.Top = 3.228!
        Me.txtDaysOverdue.Width = 1.15!
        '
        'lblRecipientName
        '
        Me.lblRecipientName.Height = 0.15!
        Me.lblRecipientName.HyperLink = Nothing
        Me.lblRecipientName.Left = 6.099999!
        Me.lblRecipientName.Name = "lblRecipientName"
        Me.lblRecipientName.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblRecipientName.Text = "Recipient's Name"
        Me.lblRecipientName.Top = 2.828!
        Me.lblRecipientName.Width = 0.85!
        '
        'txtRecipientName
        '
        Me.txtRecipientName.DataField = "RecipientName"
        Me.txtRecipientName.Height = 0.15!
        Me.txtRecipientName.HyperLink = Nothing
        Me.txtRecipientName.Left = 7.0!
        Me.txtRecipientName.Name = "txtRecipientName"
        Me.txtRecipientName.Style = "font-size: 6.5pt; vertical-align: middle"
        Me.txtRecipientName.Text = "RecipientName"
        Me.txtRecipientName.Top = 2.828!
        Me.txtRecipientName.Width = 1.85!
        '
        'lblRecipientEmail
        '
        Me.lblRecipientEmail.Height = 0.15!
        Me.lblRecipientEmail.HyperLink = Nothing
        Me.lblRecipientEmail.Left = 6.099999!
        Me.lblRecipientEmail.Name = "lblRecipientEmail"
        Me.lblRecipientEmail.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblRecipientEmail.Text = "Recipient Email"
        Me.lblRecipientEmail.Top = 3.028!
        Me.lblRecipientEmail.Width = 0.85!
        '
        'txtRecipientEmail
        '
        Me.txtRecipientEmail.DataField = "RecipientEmail"
        Me.txtRecipientEmail.Height = 0.15!
        Me.txtRecipientEmail.HyperLink = Nothing
        Me.txtRecipientEmail.Left = 7.0!
        Me.txtRecipientEmail.Name = "txtRecipientEmail"
        Me.txtRecipientEmail.Style = "font-size: 6.5pt; vertical-align: middle"
        Me.txtRecipientEmail.Text = "RecipientEmail"
        Me.txtRecipientEmail.Top = 3.028!
        Me.txtRecipientEmail.Width = 1.85!
        '
        'shpRequestDueDate
        '
        Me.shpRequestDueDate.Height = 0.15!
        Me.shpRequestDueDate.Left = 2.52!
        Me.shpRequestDueDate.Name = "shpRequestDueDate"
        Me.shpRequestDueDate.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(0.0!, Nothing, Nothing, Nothing, Nothing)
        Me.shpRequestDueDate.Top = 3.028!
        Me.shpRequestDueDate.Width = 1.15!
        '
        'shpFirstFollowUp
        '
        Me.shpFirstFollowUp.Height = 0.15!
        Me.shpFirstFollowUp.Left = 4.840001!
        Me.shpFirstFollowUp.Name = "shpFirstFollowUp"
        Me.shpFirstFollowUp.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(0.0!, Nothing, Nothing, Nothing, Nothing)
        Me.shpFirstFollowUp.Top = 2.828!
        Me.shpFirstFollowUp.Width = 0.85!
        '
        'shpSecondFollowUp
        '
        Me.shpSecondFollowUp.Height = 0.15!
        Me.shpSecondFollowUp.Left = 4.840001!
        Me.shpSecondFollowUp.Name = "shpSecondFollowUp"
        Me.shpSecondFollowUp.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(0.0!, Nothing, Nothing, Nothing, Nothing)
        Me.shpSecondFollowUp.Top = 3.028!
        Me.shpSecondFollowUp.Width = 0.85!
        '
        'shpThirdFollowUp
        '
        Me.shpThirdFollowUp.Height = 0.15!
        Me.shpThirdFollowUp.Left = 4.840001!
        Me.shpThirdFollowUp.Name = "shpThirdFollowUp"
        Me.shpThirdFollowUp.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(0.0!, Nothing, Nothing, Nothing, Nothing)
        Me.shpThirdFollowUp.Top = 3.228!
        Me.shpThirdFollowUp.Width = 0.85!
        '
        'shpDaysOverdue
        '
        Me.shpDaysOverdue.Height = 0.15!
        Me.shpDaysOverdue.Left = 2.52!
        Me.shpDaysOverdue.Name = "shpDaysOverdue"
        Me.shpDaysOverdue.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(0.0!, Nothing, Nothing, Nothing, Nothing)
        Me.shpDaysOverdue.Top = 3.228!
        Me.shpDaysOverdue.Width = 1.15!
        '
        'shpRecipientEmail
        '
        Me.shpRecipientEmail.Height = 0.15!
        Me.shpRecipientEmail.Left = 7.0!
        Me.shpRecipientEmail.Name = "shpRecipientEmail"
        Me.shpRecipientEmail.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(0.0!, Nothing, Nothing, Nothing, Nothing)
        Me.shpRecipientEmail.Top = 3.028!
        Me.shpRecipientEmail.Width = 1.85!
        '
        'shpRecipientName
        '
        Me.shpRecipientName.Height = 0.15!
        Me.shpRecipientName.Left = 7.0!
        Me.shpRecipientName.Name = "shpRecipientName"
        Me.shpRecipientName.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(0.0!, Nothing, Nothing, Nothing, Nothing)
        Me.shpRecipientName.Top = 2.828!
        Me.shpRecipientName.Width = 1.85!
        '
        'lblRecComment
        '
        Me.lblRecComment.Height = 0.25!
        Me.lblRecComment.HyperLink = Nothing
        Me.lblRecComment.Left = 7.550001!
        Me.lblRecComment.Name = "lblRecComment"
        Me.lblRecComment.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblRecComment.Text = "Rec. Comment"
        Me.lblRecComment.Top = 0.9900001!
        Me.lblRecComment.Width = 0.5!
        '
        'lnRecCommentBottom
        '
        Me.lnRecCommentBottom.Height = 0.0!
        Me.lnRecCommentBottom.Left = 8.1!
        Me.lnRecCommentBottom.LineWeight = 1.0!
        Me.lnRecCommentBottom.Name = "lnRecCommentBottom"
        Me.lnRecCommentBottom.Top = 1.34!
        Me.lnRecCommentBottom.Width = 1.85!
        Me.lnRecCommentBottom.X1 = 8.1!
        Me.lnRecCommentBottom.X2 = 9.950001!
        Me.lnRecCommentBottom.Y1 = 1.34!
        Me.lnRecCommentBottom.Y2 = 1.34!
        '
        'lnRecCommentTop
        '
        Me.lnRecCommentTop.Height = 0.0!
        Me.lnRecCommentTop.Left = 8.1!
        Me.lnRecCommentTop.LineWeight = 1.0!
        Me.lnRecCommentTop.Name = "lnRecCommentTop"
        Me.lnRecCommentTop.Top = 0.9900001!
        Me.lnRecCommentTop.Width = 1.85!
        Me.lnRecCommentTop.X1 = 8.1!
        Me.lnRecCommentTop.X2 = 9.950001!
        Me.lnRecCommentTop.Y1 = 0.9900001!
        Me.lnRecCommentTop.Y2 = 0.9900001!
        '
        'lnRecCommentLeft
        '
        Me.lnRecCommentLeft.Height = 0.3499999!
        Me.lnRecCommentLeft.Left = 8.1!
        Me.lnRecCommentLeft.LineWeight = 1.0!
        Me.lnRecCommentLeft.Name = "lnRecCommentLeft"
        Me.lnRecCommentLeft.Top = 0.9900001!
        Me.lnRecCommentLeft.Width = 0.0!
        Me.lnRecCommentLeft.X1 = 8.1!
        Me.lnRecCommentLeft.X2 = 8.1!
        Me.lnRecCommentLeft.Y1 = 0.9900001!
        Me.lnRecCommentLeft.Y2 = 1.34!
        '
        'txtSpecItemDetail
        '
        Me.txtSpecItemDetail.DataField = "SpecItemDetail"
        Me.txtSpecItemDetail.Height = 0.35!
        Me.txtSpecItemDetail.HyperLink = Nothing
        Me.txtSpecItemDetail.Left = 0.7000005!
        Me.txtSpecItemDetail.Name = "txtSpecItemDetail"
        Me.txtSpecItemDetail.Style = "font-size: 7pt; vertical-align: middle; ddo-char-set: 0"
        Me.txtSpecItemDetail.Text = "SpecItemDetail"
        Me.txtSpecItemDetail.Top = 0.9900001!
        Me.txtSpecItemDetail.Width = 1.55!
        '
        'txtProbableCause
        '
        Me.txtProbableCause.DataField = "ProbableCause"
        Me.txtProbableCause.Height = 0.375!
        Me.txtProbableCause.HyperLink = Nothing
        Me.txtProbableCause.Left = 5.125!
        Me.txtProbableCause.Name = "txtProbableCause"
        Me.txtProbableCause.Style = "font-size: 7pt; vertical-align: middle; ddo-char-set: 0"
        Me.txtProbableCause.Text = "ProbableCause"
        Me.txtProbableCause.Top = 0.9775001!
        Me.txtProbableCause.Width = 1.25!
        '
        'txtLengthofBusinessInterruption
        '
        Me.txtLengthofBusinessInterruption.DataField = "LengthofBusinessInterruption"
        Me.txtLengthofBusinessInterruption.Height = 0.15!
        Me.txtLengthofBusinessInterruption.HyperLink = Nothing
        Me.txtLengthofBusinessInterruption.Left = 0.7000005!
        Me.txtLengthofBusinessInterruption.Name = "txtLengthofBusinessInterruption"
        Me.txtLengthofBusinessInterruption.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtLengthofBusinessInterruption.Text = "Lenght Of BI"
        Me.txtLengthofBusinessInterruption.Top = 0.7900001!
        Me.txtLengthofBusinessInterruption.Width = 0.85!
        '
        'txtProbableEquipmentDamageCost
        '
        Me.txtProbableEquipmentDamageCost.DataField = "ProbableEquipmentDamageCost"
        Me.txtProbableEquipmentDamageCost.Height = 0.15!
        Me.txtProbableEquipmentDamageCost.HyperLink = Nothing
        Me.txtProbableEquipmentDamageCost.Left = 2.950001!
        Me.txtProbableEquipmentDamageCost.Name = "txtProbableEquipmentDamageCost"
        Me.txtProbableEquipmentDamageCost.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtProbableEquipmentDamageCost.Text = "Cost of BI"
        Me.txtProbableEquipmentDamageCost.Top = 0.7900001!
        Me.txtProbableEquipmentDamageCost.Width = 1.15!
        '
        'txtRedundancySpare
        '
        Me.txtRedundancySpare.DataField = "RedundancySpare"
        Me.txtRedundancySpare.Height = 0.15!
        Me.txtRedundancySpare.HyperLink = Nothing
        Me.txtRedundancySpare.Left = 5.125!
        Me.txtRedundancySpare.Name = "txtRedundancySpare"
        Me.txtRedundancySpare.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtRedundancySpare.Text = "Redundancy Spare"
        Me.txtRedundancySpare.Top = 0.7900001!
        Me.txtRedundancySpare.Width = 1.25!
        '
        'lblRedundancySpare
        '
        Me.lblRedundancySpare.Height = 0.15!
        Me.lblRedundancySpare.HyperLink = Nothing
        Me.lblRedundancySpare.Left = 4.16!
        Me.lblRedundancySpare.Name = "lblRedundancySpare"
        Me.lblRedundancySpare.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblRedundancySpare.Text = "Redundancy Spare"
        Me.lblRedundancySpare.Top = 0.7900001!
        Me.lblRedundancySpare.Width = 0.938!
        '
        'lblFrom
        '
        Me.lblFrom.Height = 0.125!
        Me.lblFrom.HyperLink = Nothing
        Me.lblFrom.Left = 1.55!
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblFrom.Text = "Prob. Equip. Dam. Cost"
        Me.lblFrom.Top = 0.7900001!
        Me.lblFrom.Width = 1.35!
        '
        'lblHistory
        '
        Me.lblHistory.Height = 0.125!
        Me.lblHistory.HyperLink = Nothing
        Me.lblHistory.Left = 6.4375!
        Me.lblHistory.Name = "lblHistory"
        Me.lblHistory.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblHistory.Text = "History"
        Me.lblHistory.Top = 0.4150001!
        Me.lblHistory.Width = 0.5!
        '
        'lnRedundancySpareTop
        '
        Me.lnRedundancySpareTop.Height = 0.0!
        Me.lnRedundancySpareTop.Left = 5.125!
        Me.lnRedundancySpareTop.LineWeight = 1.0!
        Me.lnRedundancySpareTop.Name = "lnRedundancySpareTop"
        Me.lnRedundancySpareTop.Top = 0.7900001!
        Me.lnRedundancySpareTop.Width = 1.25!
        Me.lnRedundancySpareTop.X1 = 5.125!
        Me.lnRedundancySpareTop.X2 = 6.375!
        Me.lnRedundancySpareTop.Y1 = 0.7900001!
        Me.lnRedundancySpareTop.Y2 = 0.7900001!
        '
        'lnRedundancySpareBottom
        '
        Me.lnRedundancySpareBottom.Height = 0.0!
        Me.lnRedundancySpareBottom.Left = 5.125!
        Me.lnRedundancySpareBottom.LineWeight = 1.0!
        Me.lnRedundancySpareBottom.Name = "lnRedundancySpareBottom"
        Me.lnRedundancySpareBottom.Top = 0.9150001!
        Me.lnRedundancySpareBottom.Width = 1.25!
        Me.lnRedundancySpareBottom.X1 = 5.125!
        Me.lnRedundancySpareBottom.X2 = 6.375!
        Me.lnRedundancySpareBottom.Y1 = 0.9150001!
        Me.lnRedundancySpareBottom.Y2 = 0.9150001!
        '
        'lnRedundancySpareLeft
        '
        Me.lnRedundancySpareLeft.Height = 0.125!
        Me.lnRedundancySpareLeft.Left = 5.125!
        Me.lnRedundancySpareLeft.LineWeight = 1.0!
        Me.lnRedundancySpareLeft.Name = "lnRedundancySpareLeft"
        Me.lnRedundancySpareLeft.Top = 0.7900001!
        Me.lnRedundancySpareLeft.Width = 0.0!
        Me.lnRedundancySpareLeft.X1 = 5.125!
        Me.lnRedundancySpareLeft.X2 = 5.125!
        Me.lnRedundancySpareLeft.Y1 = 0.7900001!
        Me.lnRedundancySpareLeft.Y2 = 0.9150001!
        '
        'lnRedundancySpareRight
        '
        Me.lnRedundancySpareRight.Height = 0.125!
        Me.lnRedundancySpareRight.Left = 6.375!
        Me.lnRedundancySpareRight.LineWeight = 1.0!
        Me.lnRedundancySpareRight.Name = "lnRedundancySpareRight"
        Me.lnRedundancySpareRight.Top = 0.7900001!
        Me.lnRedundancySpareRight.Width = 0.0!
        Me.lnRedundancySpareRight.X1 = 6.375!
        Me.lnRedundancySpareRight.X2 = 6.375!
        Me.lnRedundancySpareRight.Y1 = 0.7900001!
        Me.lnRedundancySpareRight.Y2 = 0.9150001!
        '
        'lnSeverityBottom
        '
        Me.lnSeverityBottom.Height = 0.0!
        Me.lnSeverityBottom.Left = 7.0!
        Me.lnSeverityBottom.LineWeight = 1.0!
        Me.lnSeverityBottom.Name = "lnSeverityBottom"
        Me.lnSeverityBottom.Top = 0.9400001!
        Me.lnSeverityBottom.Width = 0.5!
        Me.lnSeverityBottom.X1 = 7.0!
        Me.lnSeverityBottom.X2 = 7.5!
        Me.lnSeverityBottom.Y1 = 0.9400001!
        Me.lnSeverityBottom.Y2 = 0.9400001!
        '
        'lnSeverityLeft
        '
        Me.lnSeverityLeft.Height = 0.15!
        Me.lnSeverityLeft.Left = 7.0!
        Me.lnSeverityLeft.LineWeight = 1.0!
        Me.lnSeverityLeft.Name = "lnSeverityLeft"
        Me.lnSeverityLeft.Top = 0.7900001!
        Me.lnSeverityLeft.Width = 0.0!
        Me.lnSeverityLeft.X1 = 7.0!
        Me.lnSeverityLeft.X2 = 7.0!
        Me.lnSeverityLeft.Y1 = 0.7900001!
        Me.lnSeverityLeft.Y2 = 0.9400001!
        '
        'lnCostOfBIBottom
        '
        Me.lnCostOfBIBottom.Height = 0.0!
        Me.lnCostOfBIBottom.Left = 2.950001!
        Me.lnCostOfBIBottom.LineWeight = 1.0!
        Me.lnCostOfBIBottom.Name = "lnCostOfBIBottom"
        Me.lnCostOfBIBottom.Top = 0.9400001!
        Me.lnCostOfBIBottom.Width = 1.149999!
        Me.lnCostOfBIBottom.X1 = 2.950001!
        Me.lnCostOfBIBottom.X2 = 4.1!
        Me.lnCostOfBIBottom.Y1 = 0.9400001!
        Me.lnCostOfBIBottom.Y2 = 0.9400001!
        '
        'lnCostOfBILeft
        '
        Me.lnCostOfBILeft.Height = 0.15!
        Me.lnCostOfBILeft.Left = 2.950001!
        Me.lnCostOfBILeft.LineWeight = 1.0!
        Me.lnCostOfBILeft.Name = "lnCostOfBILeft"
        Me.lnCostOfBILeft.Top = 0.7900001!
        Me.lnCostOfBILeft.Width = 0.0!
        Me.lnCostOfBILeft.X1 = 2.950001!
        Me.lnCostOfBILeft.X2 = 2.950001!
        Me.lnCostOfBILeft.Y1 = 0.7900001!
        Me.lnCostOfBILeft.Y2 = 0.9400001!
        '
        'lnCostOfBIRight
        '
        Me.lnCostOfBIRight.Height = 0.15!
        Me.lnCostOfBIRight.Left = 4.1!
        Me.lnCostOfBIRight.LineWeight = 1.0!
        Me.lnCostOfBIRight.Name = "lnCostOfBIRight"
        Me.lnCostOfBIRight.Top = 0.7900001!
        Me.lnCostOfBIRight.Width = 0.0!
        Me.lnCostOfBIRight.X1 = 4.1!
        Me.lnCostOfBIRight.X2 = 4.1!
        Me.lnCostOfBIRight.Y1 = 0.7900001!
        Me.lnCostOfBIRight.Y2 = 0.9400001!
        '
        'lnLengthOfBIBottom
        '
        Me.lnLengthOfBIBottom.Height = 0.0!
        Me.lnLengthOfBIBottom.Left = 0.7000005!
        Me.lnLengthOfBIBottom.LineWeight = 1.0!
        Me.lnLengthOfBIBottom.Name = "lnLengthOfBIBottom"
        Me.lnLengthOfBIBottom.Top = 0.9400001!
        Me.lnLengthOfBIBottom.Width = 0.8499994!
        Me.lnLengthOfBIBottom.X1 = 0.7000005!
        Me.lnLengthOfBIBottom.X2 = 1.55!
        Me.lnLengthOfBIBottom.Y1 = 0.9400001!
        Me.lnLengthOfBIBottom.Y2 = 0.9400001!
        '
        'lnLengthOfBILeft
        '
        Me.lnLengthOfBILeft.Height = 0.125!
        Me.lnLengthOfBILeft.Left = 0.7000005!
        Me.lnLengthOfBILeft.LineWeight = 1.0!
        Me.lnLengthOfBILeft.Name = "lnLengthOfBILeft"
        Me.lnLengthOfBILeft.Top = 0.7900001!
        Me.lnLengthOfBILeft.Width = 0.0!
        Me.lnLengthOfBILeft.X1 = 0.7000005!
        Me.lnLengthOfBILeft.X2 = 0.7000005!
        Me.lnLengthOfBILeft.Y1 = 0.7900001!
        Me.lnLengthOfBILeft.Y2 = 0.9150001!
        '
        'lnLengthOfBITop
        '
        Me.lnLengthOfBITop.Height = 0.0!
        Me.lnLengthOfBITop.Left = 0.7000005!
        Me.lnLengthOfBITop.LineWeight = 1.0!
        Me.lnLengthOfBITop.Name = "lnLengthOfBITop"
        Me.lnLengthOfBITop.Top = 0.7900001!
        Me.lnLengthOfBITop.Width = 0.8499994!
        Me.lnLengthOfBITop.X1 = 0.7000005!
        Me.lnLengthOfBITop.X2 = 1.55!
        Me.lnLengthOfBITop.Y1 = 0.7900001!
        Me.lnLengthOfBITop.Y2 = 0.7900001!
        '
        'lnLengthOfBIRight
        '
        Me.lnLengthOfBIRight.Height = 0.15!
        Me.lnLengthOfBIRight.Left = 1.55!
        Me.lnLengthOfBIRight.LineWeight = 1.0!
        Me.lnLengthOfBIRight.Name = "lnLengthOfBIRight"
        Me.lnLengthOfBIRight.Top = 0.7900001!
        Me.lnLengthOfBIRight.Width = 0.0!
        Me.lnLengthOfBIRight.X1 = 1.55!
        Me.lnLengthOfBIRight.X2 = 1.55!
        Me.lnLengthOfBIRight.Y1 = 0.7900001!
        Me.lnLengthOfBIRight.Y2 = 0.9400001!
        '
        'lnCostOfBITop
        '
        Me.lnCostOfBITop.Height = 0.0!
        Me.lnCostOfBITop.Left = 2.950001!
        Me.lnCostOfBITop.LineWeight = 1.0!
        Me.lnCostOfBITop.Name = "lnCostOfBITop"
        Me.lnCostOfBITop.Top = 0.7900001!
        Me.lnCostOfBITop.Width = 1.149999!
        Me.lnCostOfBITop.X1 = 2.950001!
        Me.lnCostOfBITop.X2 = 4.1!
        Me.lnCostOfBITop.Y1 = 0.7900001!
        Me.lnCostOfBITop.Y2 = 0.7900001!
        '
        'lnSeverityTop
        '
        Me.lnSeverityTop.Height = 0.0!
        Me.lnSeverityTop.Left = 7.0!
        Me.lnSeverityTop.LineWeight = 1.0!
        Me.lnSeverityTop.Name = "lnSeverityTop"
        Me.lnSeverityTop.Top = 0.7900001!
        Me.lnSeverityTop.Width = 0.5!
        Me.lnSeverityTop.X1 = 7.0!
        Me.lnSeverityTop.X2 = 7.5!
        Me.lnSeverityTop.Y1 = 0.7900001!
        Me.lnSeverityTop.Y2 = 0.7900001!
        '
        'lnSeverityRight
        '
        Me.lnSeverityRight.Height = 0.15!
        Me.lnSeverityRight.Left = 7.5!
        Me.lnSeverityRight.LineWeight = 1.0!
        Me.lnSeverityRight.Name = "lnSeverityRight"
        Me.lnSeverityRight.Top = 0.7900001!
        Me.lnSeverityRight.Width = 0.0!
        Me.lnSeverityRight.X1 = 7.5!
        Me.lnSeverityRight.X2 = 7.5!
        Me.lnSeverityRight.Y1 = 0.7900001!
        Me.lnSeverityRight.Y2 = 0.9400001!
        '
        'lnProbableCauseRight
        '
        Me.lnProbableCauseRight.Height = 0.3749999!
        Me.lnProbableCauseRight.Left = 6.375!
        Me.lnProbableCauseRight.LineWeight = 1.0!
        Me.lnProbableCauseRight.Name = "lnProbableCauseRight"
        Me.lnProbableCauseRight.Top = 0.9775001!
        Me.lnProbableCauseRight.Width = 0.0!
        Me.lnProbableCauseRight.X1 = 6.375!
        Me.lnProbableCauseRight.X2 = 6.375!
        Me.lnProbableCauseRight.Y1 = 0.9775001!
        Me.lnProbableCauseRight.Y2 = 1.3525!
        '
        'lnProbableCauseTop
        '
        Me.lnProbableCauseTop.Height = 0.0!
        Me.lnProbableCauseTop.Left = 5.125!
        Me.lnProbableCauseTop.LineWeight = 1.0!
        Me.lnProbableCauseTop.Name = "lnProbableCauseTop"
        Me.lnProbableCauseTop.Top = 0.9775001!
        Me.lnProbableCauseTop.Width = 1.25!
        Me.lnProbableCauseTop.X1 = 5.125!
        Me.lnProbableCauseTop.X2 = 6.375!
        Me.lnProbableCauseTop.Y1 = 0.9775001!
        Me.lnProbableCauseTop.Y2 = 0.9775001!
        '
        'lnProbableCauseLeft
        '
        Me.lnProbableCauseLeft.Height = 0.3749999!
        Me.lnProbableCauseLeft.Left = 5.125!
        Me.lnProbableCauseLeft.LineWeight = 1.0!
        Me.lnProbableCauseLeft.Name = "lnProbableCauseLeft"
        Me.lnProbableCauseLeft.Top = 0.9775001!
        Me.lnProbableCauseLeft.Width = 0.0!
        Me.lnProbableCauseLeft.X1 = 5.125!
        Me.lnProbableCauseLeft.X2 = 5.125!
        Me.lnProbableCauseLeft.Y1 = 0.9775001!
        Me.lnProbableCauseLeft.Y2 = 1.3525!
        '
        'lnLocationLeft
        '
        Me.lnLocationLeft.Height = 0.3499999!
        Me.lnLocationLeft.Left = 2.950001!
        Me.lnLocationLeft.LineWeight = 1.0!
        Me.lnLocationLeft.Name = "lnLocationLeft"
        Me.lnLocationLeft.Top = 0.9900001!
        Me.lnLocationLeft.Width = 0.0!
        Me.lnLocationLeft.X1 = 2.950001!
        Me.lnLocationLeft.X2 = 2.950001!
        Me.lnLocationLeft.Y1 = 0.9900001!
        Me.lnLocationLeft.Y2 = 1.34!
        '
        'lnLocationTop
        '
        Me.lnLocationTop.Height = 0.0!
        Me.lnLocationTop.Left = 2.950001!
        Me.lnLocationTop.LineWeight = 1.0!
        Me.lnLocationTop.Name = "lnLocationTop"
        Me.lnLocationTop.Top = 0.9900001!
        Me.lnLocationTop.Width = 1.149999!
        Me.lnLocationTop.X1 = 2.950001!
        Me.lnLocationTop.X2 = 4.1!
        Me.lnLocationTop.Y1 = 0.9900001!
        Me.lnLocationTop.Y2 = 0.9900001!
        '
        'lnSpecificItemDetailRight
        '
        Me.lnSpecificItemDetailRight.Height = 0.3499999!
        Me.lnSpecificItemDetailRight.Left = 2.25!
        Me.lnSpecificItemDetailRight.LineWeight = 1.0!
        Me.lnSpecificItemDetailRight.Name = "lnSpecificItemDetailRight"
        Me.lnSpecificItemDetailRight.Top = 0.9900001!
        Me.lnSpecificItemDetailRight.Width = 0.0!
        Me.lnSpecificItemDetailRight.X1 = 2.25!
        Me.lnSpecificItemDetailRight.X2 = 2.25!
        Me.lnSpecificItemDetailRight.Y1 = 0.9900001!
        Me.lnSpecificItemDetailRight.Y2 = 1.34!
        '
        'lnSpecificItemDetailTop
        '
        Me.lnSpecificItemDetailTop.Height = 0.0!
        Me.lnSpecificItemDetailTop.Left = 0.7000005!
        Me.lnSpecificItemDetailTop.LineWeight = 1.0!
        Me.lnSpecificItemDetailTop.Name = "lnSpecificItemDetailTop"
        Me.lnSpecificItemDetailTop.Top = 0.9900001!
        Me.lnSpecificItemDetailTop.Width = 1.549999!
        Me.lnSpecificItemDetailTop.X1 = 0.7000005!
        Me.lnSpecificItemDetailTop.X2 = 2.25!
        Me.lnSpecificItemDetailTop.Y1 = 0.9900001!
        Me.lnSpecificItemDetailTop.Y2 = 0.9900001!
        '
        'lnSpecificItemDetailLeft
        '
        Me.lnSpecificItemDetailLeft.Height = 0.3499999!
        Me.lnSpecificItemDetailLeft.Left = 0.7000005!
        Me.lnSpecificItemDetailLeft.LineWeight = 1.0!
        Me.lnSpecificItemDetailLeft.Name = "lnSpecificItemDetailLeft"
        Me.lnSpecificItemDetailLeft.Top = 0.9900001!
        Me.lnSpecificItemDetailLeft.Width = 0.0!
        Me.lnSpecificItemDetailLeft.X1 = 0.7000005!
        Me.lnSpecificItemDetailLeft.X2 = 0.7000005!
        Me.lnSpecificItemDetailLeft.Y1 = 0.9900001!
        Me.lnSpecificItemDetailLeft.Y2 = 1.34!
        '
        'lnLocationRight
        '
        Me.lnLocationRight.Height = 0.3499999!
        Me.lnLocationRight.Left = 4.1!
        Me.lnLocationRight.LineWeight = 1.0!
        Me.lnLocationRight.Name = "lnLocationRight"
        Me.lnLocationRight.Top = 0.9900001!
        Me.lnLocationRight.Width = 0.0!
        Me.lnLocationRight.X1 = 4.1!
        Me.lnLocationRight.X2 = 4.1!
        Me.lnLocationRight.Y1 = 0.9900001!
        Me.lnLocationRight.Y2 = 1.34!
        '
        'lnProbableCauseBottom
        '
        Me.lnProbableCauseBottom.Height = 0.0!
        Me.lnProbableCauseBottom.Left = 5.125!
        Me.lnProbableCauseBottom.LineWeight = 1.0!
        Me.lnProbableCauseBottom.Name = "lnProbableCauseBottom"
        Me.lnProbableCauseBottom.Top = 1.3525!
        Me.lnProbableCauseBottom.Width = 1.25!
        Me.lnProbableCauseBottom.X1 = 5.125!
        Me.lnProbableCauseBottom.X2 = 6.375!
        Me.lnProbableCauseBottom.Y1 = 1.3525!
        Me.lnProbableCauseBottom.Y2 = 1.3525!
        '
        'lnLocationBottom
        '
        Me.lnLocationBottom.Height = 0.0!
        Me.lnLocationBottom.Left = 2.950001!
        Me.lnLocationBottom.LineWeight = 1.0!
        Me.lnLocationBottom.Name = "lnLocationBottom"
        Me.lnLocationBottom.Top = 1.34!
        Me.lnLocationBottom.Width = 1.149999!
        Me.lnLocationBottom.X1 = 2.950001!
        Me.lnLocationBottom.X2 = 4.1!
        Me.lnLocationBottom.Y1 = 1.34!
        Me.lnLocationBottom.Y2 = 1.34!
        '
        'lnSpecificItemDetailBottom
        '
        Me.lnSpecificItemDetailBottom.Height = 0.0!
        Me.lnSpecificItemDetailBottom.Left = 0.7000005!
        Me.lnSpecificItemDetailBottom.LineWeight = 1.0!
        Me.lnSpecificItemDetailBottom.Name = "lnSpecificItemDetailBottom"
        Me.lnSpecificItemDetailBottom.Top = 1.34!
        Me.lnSpecificItemDetailBottom.Width = 1.549999!
        Me.lnSpecificItemDetailBottom.X1 = 0.7000005!
        Me.lnSpecificItemDetailBottom.X2 = 2.25!
        Me.lnSpecificItemDetailBottom.Y1 = 1.34!
        Me.lnSpecificItemDetailBottom.Y2 = 1.34!
        '
        'lblFindingNo
        '
        Me.lblFindingNo.Height = 0.15!
        Me.lblFindingNo.HyperLink = Nothing
        Me.lblFindingNo.Left = 1.450001!
        Me.lblFindingNo.Name = "lblFindingNo"
        Me.lblFindingNo.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblFindingNo.Text = "Finding No."
        Me.lblFindingNo.Top = 0.3900001!
        Me.lblFindingNo.Width = 0.6!
        '
        'lnFindingNoRight
        '
        Me.lnFindingNoRight.Height = 0.15!
        Me.lnFindingNoRight.Left = 2.25!
        Me.lnFindingNoRight.LineWeight = 1.0!
        Me.lnFindingNoRight.Name = "lnFindingNoRight"
        Me.lnFindingNoRight.Top = 0.3900001!
        Me.lnFindingNoRight.Width = 0.0!
        Me.lnFindingNoRight.X1 = 2.25!
        Me.lnFindingNoRight.X2 = 2.25!
        Me.lnFindingNoRight.Y1 = 0.3900001!
        Me.lnFindingNoRight.Y2 = 0.5400001!
        '
        'lnFindingNoBottom
        '
        Me.lnFindingNoBottom.Height = 0.0!
        Me.lnFindingNoBottom.Left = 2.1!
        Me.lnFindingNoBottom.LineWeight = 1.0!
        Me.lnFindingNoBottom.Name = "lnFindingNoBottom"
        Me.lnFindingNoBottom.Top = 0.5400001!
        Me.lnFindingNoBottom.Width = 0.1500001!
        Me.lnFindingNoBottom.X1 = 2.1!
        Me.lnFindingNoBottom.X2 = 2.25!
        Me.lnFindingNoBottom.Y1 = 0.5400001!
        Me.lnFindingNoBottom.Y2 = 0.5400001!
        '
        'lnFindingNoLeft
        '
        Me.lnFindingNoLeft.Height = 0.15!
        Me.lnFindingNoLeft.Left = 2.1!
        Me.lnFindingNoLeft.LineWeight = 1.0!
        Me.lnFindingNoLeft.Name = "lnFindingNoLeft"
        Me.lnFindingNoLeft.Top = 0.3900001!
        Me.lnFindingNoLeft.Width = 0.0!
        Me.lnFindingNoLeft.X1 = 2.1!
        Me.lnFindingNoLeft.X2 = 2.1!
        Me.lnFindingNoLeft.Y1 = 0.3900001!
        Me.lnFindingNoLeft.Y2 = 0.5400001!
        '
        'lnFindingNoTop
        '
        Me.lnFindingNoTop.Height = 0.0!
        Me.lnFindingNoTop.Left = 2.1!
        Me.lnFindingNoTop.LineWeight = 1.0!
        Me.lnFindingNoTop.Name = "lnFindingNoTop"
        Me.lnFindingNoTop.Top = 0.3900001!
        Me.lnFindingNoTop.Width = 0.1500001!
        Me.lnFindingNoTop.X1 = 2.1!
        Me.lnFindingNoTop.X2 = 2.25!
        Me.lnFindingNoTop.Y1 = 0.3900001!
        Me.lnFindingNoTop.Y2 = 0.3900001!
        '
        'txtResponseStatus
        '
        Me.txtResponseStatus.DataField = "ResponseStatus"
        Me.txtResponseStatus.Height = 0.14!
        Me.txtResponseStatus.HyperLink = Nothing
        Me.txtResponseStatus.Left = 0.255!
        Me.txtResponseStatus.Name = "txtResponseStatus"
        Me.txtResponseStatus.Style = "font-size: 6.5pt; vertical-align: middle"
        Me.txtResponseStatus.Text = "Response Status"
        Me.txtResponseStatus.Top = 3.033!
        Me.txtResponseStatus.Width = 0.81!
        '
        'shpResponseStatus
        '
        Me.shpResponseStatus.Height = 0.15!
        Me.shpResponseStatus.Left = 0.25!
        Me.shpResponseStatus.Name = "shpResponseStatus"
        Me.shpResponseStatus.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(0.0!, Nothing, Nothing, Nothing, Nothing)
        Me.shpResponseStatus.Top = 3.028!
        Me.shpResponseStatus.Width = 0.82!
        '
        'lblCriticality
        '
        Me.lblCriticality.Height = 0.125!
        Me.lblCriticality.HyperLink = Nothing
        Me.lblCriticality.Left = 6.4375!
        Me.lblCriticality.Name = "lblCriticality"
        Me.lblCriticality.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblCriticality.Text = "Criticality"
        Me.lblCriticality.Top = 0.9775001!
        Me.lblCriticality.Width = 0.5!
        '
        'lnCriticalityBottom
        '
        Me.lnCriticalityBottom.Height = 0.0!
        Me.lnCriticalityBottom.Left = 7.0!
        Me.lnCriticalityBottom.LineWeight = 1.0!
        Me.lnCriticalityBottom.Name = "lnCriticalityBottom"
        Me.lnCriticalityBottom.Top = 1.13!
        Me.lnCriticalityBottom.Width = 0.5!
        Me.lnCriticalityBottom.X1 = 7.0!
        Me.lnCriticalityBottom.X2 = 7.5!
        Me.lnCriticalityBottom.Y1 = 1.13!
        Me.lnCriticalityBottom.Y2 = 1.13!
        '
        'lnCriticalityLeft
        '
        Me.lnCriticalityLeft.Height = 0.1524999!
        Me.lnCriticalityLeft.Left = 7.0!
        Me.lnCriticalityLeft.LineWeight = 1.0!
        Me.lnCriticalityLeft.Name = "lnCriticalityLeft"
        Me.lnCriticalityLeft.Top = 0.9775001!
        Me.lnCriticalityLeft.Width = 0.0!
        Me.lnCriticalityLeft.X1 = 7.0!
        Me.lnCriticalityLeft.X2 = 7.0!
        Me.lnCriticalityLeft.Y1 = 0.9775001!
        Me.lnCriticalityLeft.Y2 = 1.13!
        '
        'lnCriticalityTop
        '
        Me.lnCriticalityTop.Height = 0.0!
        Me.lnCriticalityTop.Left = 7.0!
        Me.lnCriticalityTop.LineWeight = 1.0!
        Me.lnCriticalityTop.Name = "lnCriticalityTop"
        Me.lnCriticalityTop.Top = 0.9775001!
        Me.lnCriticalityTop.Width = 0.5!
        Me.lnCriticalityTop.X1 = 7.0!
        Me.lnCriticalityTop.X2 = 7.5!
        Me.lnCriticalityTop.Y1 = 0.9775001!
        Me.lnCriticalityTop.Y2 = 0.9775001!
        '
        'lnCriticalityRight
        '
        Me.lnCriticalityRight.Height = 0.1524999!
        Me.lnCriticalityRight.Left = 7.5!
        Me.lnCriticalityRight.LineWeight = 1.0!
        Me.lnCriticalityRight.Name = "lnCriticalityRight"
        Me.lnCriticalityRight.Top = 0.9775001!
        Me.lnCriticalityRight.Width = 0.0!
        Me.lnCriticalityRight.X1 = 7.5!
        Me.lnCriticalityRight.X2 = 7.5!
        Me.lnCriticalityRight.Y1 = 0.9775001!
        Me.lnCriticalityRight.Y2 = 1.13!
        '
        'lblMgmtRespComment
        '
        Me.lblMgmtRespComment.Height = 0.15!
        Me.lblMgmtRespComment.HyperLink = Nothing
        Me.lblMgmtRespComment.Left = 0.102!
        Me.lblMgmtRespComment.Name = "lblMgmtRespComment"
        Me.lblMgmtRespComment.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblMgmtRespComment.Text = "Mgmt. Comment"
        Me.lblMgmtRespComment.Top = 2.181!
        Me.lblMgmtRespComment.Width = 0.798!
        '
        'txtMgmtRespComment
        '
        Me.txtMgmtRespComment.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMgmtRespComment.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMgmtRespComment.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMgmtRespComment.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtMgmtRespComment.DataField = "MgmtRespCommentLineBreak"
        Me.txtMgmtRespComment.Height = 0.15!
        Me.txtMgmtRespComment.Left = 0.9540001!
        Me.txtMgmtRespComment.Name = "txtMgmtRespComment"
        Me.txtMgmtRespComment.Style = "font-size: 7pt; vertical-align: top; ddo-char-set: 0"
        Me.txtMgmtRespComment.Text = "MgmtRespCommentLineBreak"
        Me.txtMgmtRespComment.Top = 2.181!
        Me.txtMgmtRespComment.Width = 8.996!
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
        Me.txtMgmtRespDate.Left = 0.9540226!
        Me.txtMgmtRespDate.Name = "txtMgmtRespDate"
        Me.txtMgmtRespDate.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtMgmtRespDate.Text = "MgmtRespDate"
        Me.txtMgmtRespDate.Top = 1.981!
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
        Me.txtMgmtRespFrom.Left = 2.950001!
        Me.txtMgmtRespFrom.Name = "txtMgmtRespFrom"
        Me.txtMgmtRespFrom.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtMgmtRespFrom.Text = "MgmtRespFrom"
        Me.txtMgmtRespFrom.Top = 1.981!
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
        Me.txtMgmtRespAction.Left = 5.125!
        Me.txtMgmtRespAction.Name = "txtMgmtRespAction"
        Me.txtMgmtRespAction.Style = "font-size: 7pt; vertical-align: middle"
        Me.txtMgmtRespAction.Text = "MgmtRespAction"
        Me.txtMgmtRespAction.Top = 1.9805!
        Me.txtMgmtRespAction.Width = 1.81!
        '
        'lblMgmtRespDate
        '
        Me.lblMgmtRespDate.Height = 0.15!
        Me.lblMgmtRespDate.HyperLink = Nothing
        Me.lblMgmtRespDate.Left = 0.102!
        Me.lblMgmtRespDate.Name = "lblMgmtRespDate"
        Me.lblMgmtRespDate.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblMgmtRespDate.Text = "Mgmt. Resp. Date"
        Me.lblMgmtRespDate.Top = 1.981!
        Me.lblMgmtRespDate.Width = 0.798!
        '
        'lblMgmtRespAction
        '
        Me.lblMgmtRespAction.Height = 0.15!
        Me.lblMgmtRespAction.HyperLink = Nothing
        Me.lblMgmtRespAction.Left = 4.2855!
        Me.lblMgmtRespAction.Name = "lblMgmtRespAction"
        Me.lblMgmtRespAction.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblMgmtRespAction.Text = "Mgmt. Action"
        Me.lblMgmtRespAction.Top = 1.9805!
        Me.lblMgmtRespAction.Width = 0.8125!
        '
        'lblMgmtRespFrom
        '
        Me.lblMgmtRespFrom.Height = 0.15!
        Me.lblMgmtRespFrom.HyperLink = Nothing
        Me.lblMgmtRespFrom.Left = 2.1!
        Me.lblMgmtRespFrom.Name = "lblMgmtRespFrom"
        Me.lblMgmtRespFrom.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lblMgmtRespFrom.Text = "Response From"
        Me.lblMgmtRespFrom.Top = 1.9805!
        Me.lblMgmtRespFrom.Width = 0.8!
        '
        'BorderShape
        '
        Me.BorderShape.Height = 0.01!
        Me.BorderShape.Left = 0.0!
        Me.BorderShape.Name = "BorderShape"
        Me.BorderShape.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(9.999999!, Nothing, Nothing, Nothing, Nothing)
        Me.BorderShape.Top = 0.04!
        Me.BorderShape.Width = 10.0!
        '
        'lbl3rdLvlRespDate
        '
        Me.lbl3rdLvlRespDate.Height = 0.15!
        Me.lbl3rdLvlRespDate.HyperLink = Nothing
        Me.lbl3rdLvlRespDate.Left = 0.1007875!
        Me.lbl3rdLvlRespDate.Name = "lbl3rdLvlRespDate"
        Me.lbl3rdLvlRespDate.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lbl3rdLvlRespDate.Tag = "7"
        Me.lbl3rdLvlRespDate.Text = "3rd Lvl Resp. Date"
        Me.lbl3rdLvlRespDate.Top = 2.401!
        Me.lbl3rdLvlRespDate.Width = 0.7992125!
        '
        'lbl3rdLvlRespFrom
        '
        Me.lbl3rdLvlRespFrom.Height = 0.15!
        Me.lbl3rdLvlRespFrom.HyperLink = Nothing
        Me.lbl3rdLvlRespFrom.Left = 2.170189!
        Me.lbl3rdLvlRespFrom.Name = "lbl3rdLvlRespFrom"
        Me.lbl3rdLvlRespFrom.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lbl3rdLvlRespFrom.Tag = "7"
        Me.lbl3rdLvlRespFrom.Text = "Response From"
        Me.lbl3rdLvlRespFrom.Top = 2.401!
        Me.lbl3rdLvlRespFrom.Width = 0.7298111!
        '
        'lbl3rdLvlRespAction
        '
        Me.lbl3rdLvlRespAction.Height = 0.15!
        Me.lbl3rdLvlRespAction.HyperLink = Nothing
        Me.lbl3rdLvlRespAction.Left = 4.458788!
        Me.lbl3rdLvlRespAction.Name = "lbl3rdLvlRespAction"
        Me.lbl3rdLvlRespAction.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lbl3rdLvlRespAction.Tag = "7"
        Me.lbl3rdLvlRespAction.Text = "3rd Lvl Action"
        Me.lbl3rdLvlRespAction.Top = 2.401!
        Me.lbl3rdLvlRespAction.Width = 0.6392121!
        '
        'lbl3rdLvlRespComment
        '
        Me.lbl3rdLvlRespComment.Height = 0.15!
        Me.lbl3rdLvlRespComment.HyperLink = Nothing
        Me.lbl3rdLvlRespComment.Left = 0.1007875!
        Me.lbl3rdLvlRespComment.Name = "lbl3rdLvlRespComment"
        Me.lbl3rdLvlRespComment.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: middle"
        Me.lbl3rdLvlRespComment.Tag = "7"
        Me.lbl3rdLvlRespComment.Text = "3rd Lvl Comment"
        Me.lbl3rdLvlRespComment.Top = 2.588!
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
        Me.txt3rdLvlRespDate.Left = 0.9540226!
        Me.txt3rdLvlRespDate.Name = "txt3rdLvlRespDate"
        Me.txt3rdLvlRespDate.Style = "font-size: 7pt; vertical-align: middle"
        Me.txt3rdLvlRespDate.Tag = "7"
        Me.txt3rdLvlRespDate.Text = "ThirdLevelRespDateString"
        Me.txt3rdLvlRespDate.Top = 2.401!
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
        Me.txt3rdLvlRespFrom.Left = 2.950001!
        Me.txt3rdLvlRespFrom.Name = "txt3rdLvlRespFrom"
        Me.txt3rdLvlRespFrom.Style = "font-size: 7pt; vertical-align: middle"
        Me.txt3rdLvlRespFrom.Tag = "5"
        Me.txt3rdLvlRespFrom.Text = "ThirdLevelRespFrom"
        Me.txt3rdLvlRespFrom.Top = 2.401!
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
        Me.txt3rdLvlRespAction.Left = 5.125!
        Me.txt3rdLvlRespAction.Name = "txt3rdLvlRespAction"
        Me.txt3rdLvlRespAction.Style = "font-size: 7pt; vertical-align: middle"
        Me.txt3rdLvlRespAction.Tag = "7"
        Me.txt3rdLvlRespAction.Text = "ThirdLevelRespAction"
        Me.txt3rdLvlRespAction.Top = 2.401!
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
        Me.txt3rdLvlRespComment.Left = 0.9540226!
        Me.txt3rdLvlRespComment.Name = "txt3rdLvlRespComment"
        Me.txt3rdLvlRespComment.Style = "font-size: 7pt; vertical-align: top; ddo-char-set: 0"
        Me.txt3rdLvlRespComment.Tag = "8"
        Me.txt3rdLvlRespComment.Text = "ThirdLevelRespCommentLineBreak"
        Me.txt3rdLvlRespComment.Top = 2.588!
        Me.txt3rdLvlRespComment.Width = 8.995978!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.rptPageNo, Me.txtSort, Me.lblReportDate, Me.txtDisclaimer})
        Me.PageFooter1.Height = 0.4959167!
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
        Me.txtDisclaimer.Left = 0.0!
        Me.txtDisclaimer.Name = "txtDisclaimer"
        Me.txtDisclaimer.Style = "font-size: 7pt; font-style: italic; text-align: center; vertical-align: middle"
        Me.txtDisclaimer.Text = "Disclaimer"
        Me.txtDisclaimer.Top = 0.15!
        Me.txtDisclaimer.Width = 10.0!
        '
        'rptIRRecommendationResponsesTracking
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.25!
        Me.PageSettings.Margins.Left = 0.5!
        Me.PageSettings.Margins.Right = 0.5!
        Me.PageSettings.Margins.Top = 0.25!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 10.14583!
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
        CType(Me.lblRecommendationTrackingReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRecommendationTrackingReportMessage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblClientName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStatusDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblProbableCause, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCriticality, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblResponseStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFindingNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSpecificItemDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblLengthOfBI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblEquipmentLocation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEquipmentLocation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRecComment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDetectedWith, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPlantComment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPlantAreaAffected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRecommendation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSecondaryTypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRecYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRecNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtResponseDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImpact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFileNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrimary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtResponseFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIntendedAction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExpectedCompletionDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRecMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDivision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPrimary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSecondary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblKeywords, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDetectedWith, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFaultType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPlantArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSeverity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFaultType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSeverityRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRecNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblResponseDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblIntendedAction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblResponseFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblExpectedCompletionDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblImpact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientLocNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTIV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFacility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblStatusDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStProv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPlantComment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblResponseRequestDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRequestDueDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRequestDueDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtResponseRequestDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFirstFollowUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFirstFollowUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSecondFollowUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSecondFollowUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblThirdFollowUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtThirdFollowUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDaysOverdue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDaysOverdue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRecipientName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRecipientName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRecipientEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRecipientEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRecComment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSpecItemDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProbableCause, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLengthofBusinessInterruption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProbableEquipmentDamageCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRedundancySpare, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRedundancySpare, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFindingNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtResponseStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCriticality, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMgmtRespComment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMgmtRespComment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMgmtRespDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMgmtRespFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMgmtRespAction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMgmtRespDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMgmtRespAction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMgmtRespFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl3rdLvlRespDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl3rdLvlRespFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl3rdLvlRespAction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl3rdLvlRespComment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt3rdLvlRespDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt3rdLvlRespFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt3rdLvlRespAction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt3rdLvlRespComment, System.ComponentModel.ISupportInitialize).EndInit()
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

    Private Sub rptIRRecommendationResponsesTracking_FetchData(ByVal sender As Object, ByVal eArgs As FetchEventArgs) Handles Me.FetchData
        Dim zTextControls() As ARControl = {txtResponseStatus, txtImpact, txtLengthofBusinessInterruption, txtSeverityRating, txtCriticality}
        Dim zCurrencyControls() As ARControl = {txtProbableEquipmentDamageCost}
        UtilReport.ActiveReport.SetItemBackColorByText(Me, zTextControls, rptProperties)
        UtilReport.ActiveReport.SetItemBackColorByCurrency(Me, zCurrencyControls, rptProperties)

        If Me.AllFields("ExpectedCompletionDateColor").Value.ToString.ToLower <> "transparent" Then
            txtExpectedCompletionDate.BackColor = System.Drawing.ColorTranslator.FromHtml(Me.AllFields("ExpectedCompletionDateColor").Value)
        Else
            txtExpectedCompletionDate.BackColor = Color.Transparent
        End If

    End Sub

    Private Sub rptIRRecommendationResponsesTracking_ReportStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportStart
        lblClientName.Text = rptProperties.ClientName
        lblReportDate.Text = Now
        lblRecommendationTrackingReport.Text = UtilReport.ActiveReport.Header.RecommendationResponseTrackingReport(rptProperties.MetaReport.colFldName.ToString)
        lblRecommendationTrackingReportMessage.Text = UtilReport.ActiveReport.Header.RecommendationResponseTrackingReportMessage(rptProperties.MetaReport.colFldName.ToString)
        lblTIV.Text = "TIV " & rptProperties.Currency.colFldCode & vbLf & "(millions)"
        lblFrom.Text = lblFrom.Text & " " & rptProperties.Currency.colFldCode  'modActiveReport.ProbEDCCurrency(AppSession.Currency)

        If Not UtilCustomFeature.Contains(rptProperties, CChar("@")) Then
            Remove3rdLvlFields()
        End If

        If Not UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.Q) Then
            RemoveMgmtFields()
        End If

    End Sub

    Private Sub RemoveMgmtFields()

        Dim zDistanceToMoveUp As Single = 0.0
        zDistanceToMoveUp = txtResponseRequestDate.Location.Y - txtMgmtRespFrom.Location.Y

        txtMgmtRespAction.Visible = False
        lblMgmtRespAction.Visible = False

        txtMgmtRespComment.Visible = False
        lblMgmtRespComment.Visible = False

        txtMgmtRespDate.Visible = False
        lblMgmtRespDate.Visible = False

        txtMgmtRespFrom.Visible = False
        lblMgmtRespFrom.Visible = False

        MoveFieldsUp(zDistanceToMoveUp)

    End Sub

    Private Sub Remove3rdLvlFields()

        Dim zDistanceToMoveUp As Single = 0.0
        zDistanceToMoveUp = txtResponseRequestDate.Location.Y - txt3rdLvlRespFrom.Location.Y

        txt3rdLvlRespAction.Visible = False
        lbl3rdLvlRespAction.Visible = False

        txt3rdLvlRespComment.Visible = False
        lbl3rdLvlRespComment.Visible = False

        txt3rdLvlRespDate.Visible = False
        lbl3rdLvlRespDate.Visible = False

        txt3rdLvlRespFrom.Visible = False
        lbl3rdLvlRespFrom.Visible = False

        MoveFieldsUp(zDistanceToMoveUp)

    End Sub

    Private Sub MoveFieldsUp(ByVal zDistanceToMoveUp As Single)

        lblResponseStatus.Top -= zDistanceToMoveUp
        txtResponseStatus.Top -= zDistanceToMoveUp
        lblResponseRequestDate.Top -= zDistanceToMoveUp
        lblRequestDueDate.Top -= zDistanceToMoveUp
        lblDaysOverdue.Top -= zDistanceToMoveUp
        txtResponseRequestDate.Top -= zDistanceToMoveUp
        txtRequestDueDate.Top -= zDistanceToMoveUp
        txtDaysOverdue.Top -= zDistanceToMoveUp
        lblFirstFollowUp.Top -= zDistanceToMoveUp
        lblSecondFollowUp.Top -= zDistanceToMoveUp
        lblThirdFollowUp.Top -= zDistanceToMoveUp
        txtFirstFollowUp.Top -= zDistanceToMoveUp
        txtSecondFollowUp.Top -= zDistanceToMoveUp
        txtThirdFollowUp.Top -= zDistanceToMoveUp
        lblRecipientName.Top -= zDistanceToMoveUp
        lblRecipientEmail.Top -= zDistanceToMoveUp
        txtRecipientName.Top -= zDistanceToMoveUp
        txtRecipientEmail.Top -= zDistanceToMoveUp
        shpDaysOverdue.Top -= zDistanceToMoveUp
        shpFirstFollowUp.Top -= zDistanceToMoveUp
        shpRecipientEmail.Top -= zDistanceToMoveUp
        shpRecipientName.Top -= zDistanceToMoveUp
        shpRequestDueDate.Top -= zDistanceToMoveUp
        shpResponseRequestDate.Top -= zDistanceToMoveUp
        shpResponseStatus.Top -= zDistanceToMoveUp
        shpSecondFollowUp.Top -= zDistanceToMoveUp
        shpThirdFollowUp.Top -= zDistanceToMoveUp

        Detail1.Height -= zDistanceToMoveUp

    End Sub

    Private Sub rptIRRecommendationResponsesTracking_PageStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.PageStart
        UtilReport.ActiveReport.SetFilter(Me, rptProperties)
        UtilReport.ActiveReport.SetSort(Me, rptProperties)
        UtilReport.ActiveReport.SetDisclaimer(Me, rptProperties)
    End Sub

    Private Sub rptIRRecommendationResponsesTracking_ReportEnd(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportEnd
        DisposeParameters()
    End Sub

    Private Sub DisposeParameters()
        DataSource = Nothing
    End Sub

    Private Sub Detail1_BeforePrint(sender As Object, e As System.EventArgs) Handles Detail1.BeforePrint
        BorderShape.Height = Detail1.Height - 0.05
    End Sub

    Private Sub SetExpectedOverdueProperties(ByVal sender As Object, ByVal eArgs As FetchEventArgs) Handles Me.FetchData
        If rptProperties.MetaReport.colFldId = 56 Then
            txtExpectedCompletionDate.BackColor = Color.Red
            lblRecommendationTrackingReport.Value = UtilReport.ActiveReport.Header.RecommendationExpiredCompDateReport(rptProperties.MetaReport.colFldName.ToString)
            lblRecommendationTrackingReportMessage.Value = UtilReport.ActiveReport.Header.RecommendationExpiredCompDateReportMessage()
        End If
    End Sub

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties

End Class
