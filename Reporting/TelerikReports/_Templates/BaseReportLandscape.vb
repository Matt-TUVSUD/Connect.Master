Imports System.ComponentModel
Imports System.Drawing

Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class BaseReportLandscape
    Inherits Telerik.Reporting.Report
    Implements ITelerikBaseReport

    Public Sub New()
        InitializeComponent()
    End Sub

    'Private Sub txtPageCounter_ItemDataBound(sender As Object, e As System.EventArgs) Handles txtPageCounter.ItemDataBound

    '    Dim zPageText As String = ""
    '    Dim zOfText As String = ""
    '    Select Case _RptLanguage
    '        Case Libraries.CoreLib.UtilTranslation.Language.French
    '            zPageText = "Page"
    '            zOfText = "sur"
    '        Case Libraries.CoreLib.UtilTranslation.Language.German
    '            zPageText = "Seite"
    '            zOfText = "von"
    '        Case Libraries.CoreLib.UtilTranslation.Language.Italian
    '            zPageText = "Pagina"
    '            zOfText = "di"
    '        Case Libraries.CoreLib.UtilTranslation.Language.Portugese, Libraries.CoreLib.UtilTranslation.Language.Spanish
    '            zPageText = "Página"
    '            zOfText = "de"
    '        Case Else
    '            zPageText = "Page"
    '            zOfText = "of"
    '    End Select

    '    Dim zTextBox As Processing.TextBox = DirectCast(sender, Processing.TextBox)
    '    Dim zOldText As String = zTextBox.Text
    '    Dim zNewText As String = zOldText.Replace("Page", zPageText).Replace("of", zOfText)
    '    zTextBox.Value = zNewText

    'End Sub

    'Private Sub txtReportDate_ItemDataBound(sender As Object, e As System.EventArgs) Handles txtReportDate.ItemDataBound
    '    Dim zTextBox As Processing.TextBox = DirectCast(sender, Processing.TextBox)
    '    Dim zOldText As String = zTextBox.Text
    '    Dim zNewText As String = Libraries.CoreLib.UtilTranslation.TranslateDate(MyBase._RptLanguage, zOldText)
    '    zTextBox.Value = zNewText
    '    zTextBox.Style.TextAlign = HorizontalAlign.Left
    'End Sub


    Public ReadOnly Property AlternateHeaderHTMLTextBox As HtmlTextBox Implements ITelerikBaseReport.AlternateHeaderHTMLTextBox
        Get
            Return txtAlternateHeader
        End Get
    End Property

    Public ReadOnly Property StandardHeaderHTMLTextBox As HtmlTextBox Implements ITelerikBaseReport.StandardHeaderHTMLTextBox
        Get
            Return txtStandardHeader
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

    Private Sub SetTitle(sender As Object, e As EventArgs) Handles txtAlternateHeader.ItemDataBinding, txtStandardHeader.ItemDataBinding
        UtilReport.TelerikReport.SetTitle(sender)
    End Sub

    Private Sub BaseReportLandscape_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        'If Not TypeOf Me Is RiskImprovementChart2 Then  'THE RISK IMPROVEMENT CHART USES A STORED PROCEDURE WITH MULTIPLE TABLES
        '    Me.DataSource = Me.DataSource.Tables(0)
        'Else
        '    DirectCast()
        'End If

    End Sub
End Class