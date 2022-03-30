Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class FireFacilityDetailReport
    Inherits Telerik.Reporting.Report
    Implements ITelerikBaseReport
    Implements ITelerikReport
    Implements IUtilReport

    Public Sub New()
        InitializeComponent()
    End Sub

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

    Public ReadOnly Property PageCounterTextBox As Telerik.Reporting.TextBox Implements ITelerikBaseReport.PageCounterTextBox
        Get
            Return txtPageCounter
        End Get
    End Property

    Public ReadOnly Property ReportDateTextBox As Telerik.Reporting.TextBox Implements ITelerikBaseReport.ReportDateTextBox
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

    Public Function AppendPracticeToTitle() As Boolean Implements ITelerikReport.AppendPracticeToTitle
        Return False
    End Function

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
        Return "Fire Facility Rating Detail"
    End Function

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties

    Private Sub SetTitle(sender As Object, e As EventArgs) Handles txtStandardHeader.ItemDataBinding, HtmlTextBox1.ItemDataBinding
        txtStandardHeader.Value = rptProperties.ClientName
        HtmlTextBox1.Value = ReportTitle()
    End Sub

    Public ReadOnly Property AlternateHeaderHTMLTextBox As HtmlTextBox Implements ITelerikBaseReport.AlternateHeaderHTMLTextBox
        Get
            Return Nothing
        End Get
    End Property

    Private Sub FireFacilityDetailReport_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding


        ''SET TIV CURRENCY
        uxTivHeader.Value = "TIV" & vbNewLine & rptProperties.Currency.colFldCode & vbNewLine & "(mil)"

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

    Private Sub uxWeightsTable_NeedDataSource(sender As Object, e As EventArgs) Handles uxWeightsTable.NeedDataSource      
        uxWeightsTable.DataSource = UtilRating.GetFireDetailRatingWeights(rptProperties.FilePrefix)
    End Sub

    Private Sub Table1_ItemDataBinding(sender As Processing.Table, e As EventArgs) Handles uxRatingTable.ItemDataBinding
        Dim zMove As New Telerik.Reporting.Drawing.Unit(0)

        uxAPL.Visible = Not UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.A)
        uxAPLGroupHeader.Visible = Not UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.A)
        uxAPLHeader.Visible = Not UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.A)
        If Not uxAPL.Visible Then zMove = zMove.Add(uxAPL.Width)

        uxWithRecsAPL.Visible = Not UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.A)
        uxWithRecsAPLGroupHeader.Visible = Not UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.A)
        uxWithRecsAPLHeader.Visible = Not UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.A)
        If Not uxWithRecsAPL.Visible Then zMove = zMove.Add(uxWithRecsAPL.Width)

        uxAPLFactor.Visible = Not UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.A, UtilCustomFeature.Letter.U)
        uxAPLFactorGroupHeader.Visible = Not UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.A, UtilCustomFeature.Letter.U)
        uxAPLFactorHeader.Visible = Not UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.A, UtilCustomFeature.Letter.U)
        If Not uxAPLFactor.Visible Then zMove = zMove.Add(uxAPLFactor.Width)

        uxWithRecsAPLFactor.Visible = Not UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.A, UtilCustomFeature.Letter.U)
        uxWithRecsAPLFactorGroupHeader.Visible = Not UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.A, UtilCustomFeature.Letter.U)
        uxWithRecsAPLFactorHeader.Visible = Not UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.A, UtilCustomFeature.Letter.U)
        If Not uxWithRecsAPLFactor.Visible Then zMove = zMove.Add(uxWithRecsAPLFactor.Width)

        uxAchRating.Visible = UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.U)
        uxAchRatingHeader.Visible = UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.U)

        If Not uxAchRating.Visible Then
            uxOverallScoreGroupHeader.Width = New Telerik.Reporting.Drawing.Unit(0.5, UnitType.Inch)
            zMove = zMove.Add(uxAchRating.Width)
        End If

        uxRatingTable.Left = uxRatingTable.Left.Add(zMove / 2)
        uxWeightsTable.Left = uxWeightsTable.Left.Subtract(zMove / 2)

    End Sub

    Private Sub Table1_NeedDataSource(sender As Object, e As EventArgs) Handles uxRatingTable.NeedDataSource
        uxRatingTable.DataSource = MyBase.DataSource
        MyBase.DataSource = Nothing
    End Sub
End Class