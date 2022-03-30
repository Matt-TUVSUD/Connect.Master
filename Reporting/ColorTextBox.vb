Public Class ColorTextBox
    Inherits Telerik.Reporting.TextBox

    Public Property BackColorDataField As String

    Private Sub ColorTextBox_ItemDataBound(sender As Object, e As EventArgs) Handles Me.ItemDataBound
        Dim zReport As Telerik.Reporting.Processing.Report = sender.report
        Me.Style.BackgroundColor = System.Drawing.ColorTranslator.FromHtml(zReport.DataObject("BackColorDataField"))
    End Sub
End Class
