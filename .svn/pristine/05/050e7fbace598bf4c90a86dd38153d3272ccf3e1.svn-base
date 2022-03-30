Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports GRC.Connect.Libraries.DataLib.razor

Partial Public Class FireFacilitySummaryReport
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
        Return "Fire Facility Rating Summary"
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

    Private Sub Table1_ItemDataBinding(sender As Object, e As EventArgs) Handles uxRatingTable.ItemDataBinding

        Dim zMove As New Telerik.Reporting.Drawing.Unit(0)

        If UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.A) Then
            Dim zTB As List(Of Telerik.Reporting.ReportItemBase) = uxRatingTable.Items.Where(Function(x) x.TocText.Contains("APL")).ToList
            zTB.ToList.ForEach(Sub(x) zMove = zMove.Add(DirectCast(x, Telerik.Reporting.TextBox).Width / zTB.Count))
            zTB.ToList.ForEach(Sub(x) x.Visible = False)

            zTB = uxRatingTable.Items.Where(Function(x) x.TocText.Contains("WithRecsAPL")).ToList
            zTB.ToList.ForEach(Sub(x) zMove = zMove.Add(DirectCast(x, Telerik.Reporting.TextBox).Width / zTB.Count))
            zTB.ToList.ForEach(Sub(x) x.Visible = False)
        End If

        If UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.A) Or UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.U) Then
            Dim zTB As List(Of Telerik.Reporting.ReportItemBase) = uxRatingTable.Items.Where(Function(x) x.TocText.Contains("CurrentFactor")).ToList
            zTB.ToList.ForEach(Sub(x) zMove = zMove.Add(DirectCast(x, Telerik.Reporting.TextBox).Width / zTB.Count))
            zTB.ToList.ForEach(Sub(x) x.Visible = False)

            zTB = uxRatingTable.Items.Where(Function(x) x.TocText.Contains("WithRecsFactor")).ToList
            zTB.ToList.ForEach(Sub(x) zMove = zMove.Add(DirectCast(x, Telerik.Reporting.TextBox).Width / zTB.Count))
            zTB.ToList.ForEach(Sub(x) x.Visible = False)
        End If

        If Not UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.U) Then
            Dim zTB As List(Of Telerik.Reporting.ReportItemBase) = uxRatingTable.Items.Where(Function(x) x.TocText.Contains("Ach")).ToList
            zTB.ToList.ForEach(Sub(x) zMove = zMove.Add(DirectCast(x, Telerik.Reporting.TextBox).Width / zTB.Count))
            zTB.ToList.ForEach(Sub(x) x.Visible = False)
        End If

        uxRatingTable.Left = uxRatingTable.Left.Add(zMove / 2)
        uxOverallRatingKeyTable.Left = uxOverallRatingKeyTable.Left.Subtract(zMove / 2)
   
    End Sub

    Private Sub uxRatingTable_ItemDataBound(sender As Processing.Table, e As EventArgs) Handles uxRatingTable.ItemDataBound

    End Sub

    Private Sub Table1_NeedDataSource(sender As Object, e As EventArgs) Handles uxRatingTable.NeedDataSource
        uxRatingTable.DataSource = MyBase.DataSource
        MyBase.DataSource = Nothing
    End Sub

    Private Sub uxOverallRatingKeyTable_NeedDataSource(sender As Object, e As EventArgs) Handles uxOverallRatingKeyTable.NeedDataSource
        uxOverallRatingKeyTable.DataSource = UtilRating.GetFireSummaryRatingAveragesByTivAndLoc("", rptProperties.GDC.PropReportSetId, rptProperties.FilePrefix)
    End Sub
End Class