Imports System.ComponentModel
Imports System.Drawing

Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class FireFacilityRatingReport
    Inherits Telerik.Reporting.Report
    Implements ITelerikBaseReport
    Implements ITelerikReport
    Implements IUtilReport

    Private zFileNo As String = ""
    Private zAveragesData As Object = Nothing

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Sub ApplyColor(rpt As Processing.Report)

        Dim zRatingItems() As GrcTelerikRatingCategoryTexBox = {txtBcpRating, txtBcpRatingRecs, txtConstructionRating, txtEarthquakeRating, txtFloodRating, _
         txtHeRating, txtHeRatingRecs, txtNatHazRating, txtNatHazRatingRecs, txtOccupancyRating, txtOtherFloodRating, _
         txtProtectionRating, txtProtectionRatingRecs, txtWindstormRating}
        UtilReport.TelerikReport.SetItemBackColorByRating(rpt, zRatingItems, rptProperties)

        Dim zRiskRatingItems() As TextBox = {txtOverallRating, txtMaxPossibleRating}
        UtilReport.TelerikReport.SetItemBackColorByRiskRating(rpt, zRiskRatingItems, rptProperties)

    End Sub

#Region "Special Feature Customizations"

    Private Sub AplPanel_ItemDataBound(sender As Object, e As System.EventArgs) Handles AplPanel.ItemDataBound
        Dim zPanel As Telerik.Reporting.Processing.Panel = DirectCast(sender, Telerik.Reporting.Processing.Panel)
        If UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.A) Then
            zPanel.Visible = False
        End If
    End Sub

    Private Sub txtOverallScoreMessage_ItemDataBound(sender As Object, e As System.EventArgs) Handles txtOverallScoreMessage.ItemDataBound
        Dim zTextBox As Telerik.Reporting.Processing.TextBox = DirectCast(sender, Telerik.Reporting.Processing.TextBox)
        If UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.A) Then
            zTextBox.Value = "(The Total Facility Score is the sum of the Passive and Active Scores)"
            zTextBox.Style.Color = Color.Red
        End If
    End Sub


    Private Sub HidePML(sender As Object, e As System.EventArgs) Handles PMLpanel.ItemDataBound
        Dim wPanel As Telerik.Reporting.Processing.Panel = DirectCast(sender, Telerik.Reporting.Processing.Panel)
        If UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.F) Then
            wPanel.Visible = False
        End If
    End Sub

#End Region

    Public Function IsStandardHeader() As Boolean Implements ITelerikReport.IsStandardHeader
        Return True
    End Function

    Public Function ReportSubSubTitle() As String Implements ITelerikReport.ReportSubSubTitle
        Return ""
    End Function

    Public Function ReportSubTitle() As String Implements ITelerikReport.ReportSubTitle
        Return ""
    End Function

    Public Function ReportTitle() As String Implements ITelerikReport.ReportTitle
        Return "Facility Rating"
    End Function

    Public Function AppendPracticeToTitle() As Boolean Implements ITelerikReport.AppendPracticeToTitle
        Return True
    End Function

    Public ReadOnly Property AlternateHeaderHTMLTextBox As HtmlTextBox Implements ITelerikBaseReport.AlternateHeaderHTMLTextBox
        Get
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property DisclaimerHTMLTextBox As HtmlTextBox Implements ITelerikBaseReport.DisclaimerHTMLTextBox
        Get
            Return txtDisclaimer
        End Get
    End Property

    Public ReadOnly Property FilterHTMLTextBox As HtmlTextBox Implements ITelerikBaseReport.FilterHTMLTextBox
        Get
            Return txtFilter
        End Get
    End Property

    Public ReadOnly Property PageCounterTextBox As TextBox Implements ITelerikBaseReport.PageCounterTextBox
        Get
            Return txtPageCounter
        End Get
    End Property

    Public ReadOnly Property ReportDateTextBox As TextBox Implements ITelerikBaseReport.ReportDateTextBox
        Get
            Return txtReportDate
        End Get
    End Property

    Public ReadOnly Property SortHTMLTextBox As HtmlTextBox Implements ITelerikBaseReport.SortHTMLTextBox
        Get
            Return txtSort
        End Get
    End Property

    Public ReadOnly Property StandardHeaderHTMLTextBox As HtmlTextBox Implements ITelerikBaseReport.StandardHeaderHTMLTextBox
        Get
            Return txtStandardHeader
        End Get
    End Property

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties

    Private Sub FireFacilityRatingReport_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding

        ''SET FILTER TEXT
        If rptProperties.FilterString <> "" Then
            txtFilter.Value = "<strong>Filter:</strong>&nbsp;" & System.Web.HttpUtility.HtmlEncode(rptProperties.FilterString)
            txtFilter.Visible = True
        End If

        ''SET DISCLAIMER TEXT
        txtDisclaimer.Value = rptProperties.Disclaimer

        ''SET SORT TEXT
        txtSort.Value = rptProperties.SortString

    End Sub

    Private Sub SetTitle(sender As Object, e As EventArgs) Handles txtStandardHeader.ItemDataBinding, HtmlTextBox1.ItemDataBinding
        txtStandardHeader.Value = rptProperties.ClientName
        HtmlTextBox1.Value = ReportTitle()
    End Sub

    Private Sub FireFacilityRatingReport_ItemDataBound(sender As Object, e As EventArgs) Handles Me.ItemDataBound
        ApplyColor(sender)
        ApplyCurrency()
    End Sub

    Private Sub ApplyCurrency()
        txtCurrency.Value = rptProperties.Currency.colFldName
        txtCurrency1.Value = txtCurrency.Value

        Dim zCurrencyControls As TextBox() = {txtAPL1, txtAPLWithRecs, txtAPLBI, txtAPLPD, txtAPL, txtPMLPD, txtPMLBI, txtPML, txtMFL, txtMFLBI, txtActiveScoreLabel, txtMFLPD, txtTIV, txtTIVBI, txtTIVPD, uxAplRecsComplete}
        UtilReport.TelerikReport.SetCurrencyFormat(zCurrencyControls, rptProperties)

    End Sub

    Private Sub uxAchievableAverages_NeedDataSource(sender As Object, e As EventArgs) Handles uxAchievableAverages.NeedDataSource
        If IsNothing(zAveragesData) Then
            zAveragesData = UtilRating.GetFireFacilityRatingAverages(zFileNo)
        End If
        Me.uxAchievableAverages.DataSource = zAveragesData
    End Sub

    Private Sub detail_ItemDataBinding(sender As Object, e As EventArgs) Handles detail.ItemDataBinding
        Dim zD As Processing.DetailSection = sender
        zFileNo = DirectCast(zD.DataObject.RawData, DataRowView).Item("FileNo")

        Dim zContainsUFeature As Boolean = UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.U)
        Me.uxOverallAlternatePanel.Visible = zContainsUFeature
        Me.uxOverallStandardPanel.Visible = Not zContainsUFeature
        Me.uxOverallAlternatePanelLabel.Visible = Me.uxOverallAlternatePanel.Visible
        Me.uxOverallStandardPanelLabel.Visible = Me.uxOverallStandardPanel.Visible

        Me.uxAplRecsComplete.Visible = zContainsUFeature
        Me.uxAplRecsCompleteLabel.Visible = zContainsUFeature
        Me.txtCurrency1.Visible = zContainsUFeature
        Me.txtCurrency1Label.Visible = zContainsUFeature


    End Sub

    Private Sub uxRatingKeyTable_NeedDataSource(sender As Object, e As EventArgs) Handles uxRatingKeyTable.NeedDataSource, uxRatingKeyTable2.NeedDataSource
        uxRatingKeyTable.DataSource = rptProperties.FireRatingRange
        uxRatingKeyTable2.DataSource = rptProperties.FireRatingRange
    End Sub


End Class