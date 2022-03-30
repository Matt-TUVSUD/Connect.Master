Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class PMActivitySubReport
    Inherits Telerik.Reporting.Report
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub PMActivitySubReport_NeedDataSource(sender As Object, e As EventArgs) Handles Me.NeedDataSource
        Dim zParentReport As PMReport = DirectCast(DirectCast(sender, Telerik.Reporting.Processing.Report).ParentElement, Telerik.Reporting.Processing.SubReport).Report.ItemDefinition
        Me.DataSource = zParentReport.ReportDataSource.Activities
        Me.uxActivityHoursPanel.Visible = Not zParentReport.IsClientReport
    End Sub
End Class