Imports System.ComponentModel
Imports System.Drawing

Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class BoilerLossEstimatesReport
    Inherits BaseReportPortrait
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

    Public Function ReportSubSubTitle() As String Implements ITelerikReport.ReportSubSubTitle
        Return ""
    End Function

    Public Function ReportSubTitle() As String Implements ITelerikReport.ReportSubTitle
        Return ""
    End Function

    Public Function ReportTitle() As String Implements ITelerikReport.ReportTitle
        Return "Loss Estimates by Location"
    End Function

    Private Sub BoilerLossEstimatesReport_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding

        If UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.F) Then
            uxPMLDetailPanel.Visible = Not UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.F)
            uxPMLHeaderPanel.Visible = Not UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.F)
            uxLocationHeaderPanel.Location = New Drawing.PointU(New Drawing.Unit(1, UnitType.Inch), uxLocationHeaderPanel.Location.Y)
            uxLocationDetailPanel.Location = New Drawing.PointU(New Drawing.Unit(1, UnitType.Inch), uxLocationDetailPanel.Location.Y)
        End If

        If UtilCustomFeature.Contains(rptProperties, CChar("&")) Then
            txtIBI.Visible = True
            txtIBILabel.Visible = True
        End If

        lblTIV.Value = "TIV " & rptProperties.Currency.colFldCode
        lblCurrency.Value = "Values in " & rptProperties.Currency.colFldCode & " (" & rptProperties.Currency.colFldSymbol & ")"
        'Dim LossEstimates() As TextBox = {Me.txtMFL, Me.txtMFLBI, Me.txtMFLPD, Me.txtPML, Me.txtPMLBI, Me.txtPMLPD, Me.txtTIV}
        'UtilReport.TelerikReport.SetCurrencyFormat(LossEstimates, rptProperties)

    End Sub

    Private Sub Me_ItemDataBound(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        UtilReport.TelerikReport.SetFilterText(sender, rptProperties)
        UtilReport.TelerikReport.SetDisclaimerText(sender, rptProperties)
        UtilReport.TelerikReport.SetSortText(sender, rptProperties)
    End Sub


    Public Function AppendPracticeToTitle() As Boolean Implements ITelerikReport.AppendPracticeToTitle
        Return True
    End Function

End Class

