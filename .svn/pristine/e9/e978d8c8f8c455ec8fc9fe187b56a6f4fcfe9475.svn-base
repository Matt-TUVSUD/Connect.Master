Imports System.ComponentModel
Imports System.Drawing

Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class InspectionStatusReport
    Inherits BaseReportLandscape
    Implements IUtilReport
    Implements ITelerikReport

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        UtilReport.TelerikReport.FixBaseGroups(Me)
    End Sub

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties

    Public Function IsStandardHeader() As Boolean Implements ITelerikReport.IsStandardHeader
        Return True
    End Function

    Public Function ReportTitle() As String Implements ITelerikReport.ReportTitle
        Return "Inspection Status Report"
    End Function

    Public Function ReportSubSubTitle() As String Implements ITelerikReport.ReportSubSubTitle
        Return "for Current Inspection Period"
    End Function

    Public Function ReportSubTitle() As String Implements ITelerikReport.ReportSubTitle
        Return ""
    End Function

    Public Function AppendPracticeToTitle() As Boolean Implements ITelerikReport.AppendPracticeToTitle
        Return True
    End Function

    Private Sub InspectionStatusReport_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding

        Me.txtTIV.Value = "TIV " & rptProperties.Currency.colFldCode
        UtilReport.TelerikReport.SetFilterText(sender, rptProperties)
        UtilReport.TelerikReport.SetSortText(sender, rptProperties)
        UtilReport.TelerikReport.SetDisclaimerText(sender, rptProperties)
    End Sub

    Private Sub InspectionStatusReport_ItemDataBound(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        'UtilReport.TelerikReport.SetDisclaimerText(sender, rptProperties)
        'UtilReport.TelerikReport.SetSortText(sender, rptProperties)
        'UtilReport.TelerikReport.SetFilterText(sender, rptProperties)
    End Sub
End Class