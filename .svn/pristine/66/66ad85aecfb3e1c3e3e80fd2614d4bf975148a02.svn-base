Imports System.ComponentModel
Imports System.Drawing

Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing


Partial Public Class FireCopeDataReport
    Inherits BaseReportPortrait
    Implements ITelerikReport
    Implements IUtilReport

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        ' HideTimeStampAndPager()
        UtilReport.TelerikReport.FixBaseGroups(Me)
    End Sub

    Public Sub HideTimeStampAndPager()
        Me.PageFooterSection1.Visible = False
    End Sub

#Region "Special Feature Customizations"

    Private Sub ApplySpecialFeature(sender As Object, e As System.EventArgs) Handles txtSpecialProtDescLabel.ItemDataBound, txtSpecialProtLabel.ItemDataBound
        Dim zTextBox As Telerik.Reporting.Processing.TextBox = DirectCast(sender, Telerik.Reporting.Processing.TextBox)

        If UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.F) Then
            If zTextBox.Name.ToLower = "txtspecialprotdesclabel" Then
                zTextBox.Value = "Process Safety Systems Description:"
            Else
                zTextBox.Value = "Process Safety Systems:"
            End If
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
        Return "C.O.P.E Submission Form"
    End Function

    Public Function AppendPracticeToTitle() As Boolean Implements ITelerikReport.AppendPracticeToTitle
        Return True
    End Function

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties

    Private Sub FireCopeDataReport_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        Me.txtCurrency.Value = rptProperties.Currency.colFldName
        Me.txtUnit.Value = rptProperties.Unit.System.colFldName

        Dim LossEstimates() As TextBox = {Me.txtAPL, Me.txtAPLBI, Me.txtAPLPD, Me.txtTIV, Me.txtTIVBI, txtTIVPD, Me.txtMFL, Me.txtMFLBI, Me.txtMFLPD, Me.txtPML, Me.txtPMLBI, Me.txtPMLPD}
        UtilReport.TelerikReport.SetCurrencyFormat(LossEstimates, rptProperties)

        If UtilCustomFeature.Contains(rptProperties, CChar("&")) Then
            txtIBI.Visible = True
            txtIBILabel.Visible = True
        End If

    End Sub

    Private Sub Me_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        UtilReport.TelerikReport.SetFilterText(sender, rptProperties)
        UtilReport.TelerikReport.SetDisclaimerText(sender, rptProperties)
        UtilReport.TelerikReport.SetSortText(sender, rptProperties)
    End Sub

End Class