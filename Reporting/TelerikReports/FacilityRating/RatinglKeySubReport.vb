Imports System.ComponentModel
Imports System.Drawing
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports GRC.Connect.Libraries.CoreLib.CustomExtensions.ListExtensions
Imports GRC.Connect.Libraries.DataLib.razor

Partial Public Class RatingKeySubReport
    Inherits BaseSubReport
    Implements IUtilReport

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub RatinglKeySubReport_NeedDataSource(sender As Object, e As EventArgs) Handles Me.NeedDataSource
        If rptProperties.Practice.Practice = TblMetaPractice.Practices.Fire Then
            Me.DataSource = rptProperties.FireRatingRange

        ElseIf rptProperties.Practice.Practice = TblMetaPractice.Practices.BM Then
            Me.DataSource = rptProperties.BMRatingRange

        End If
    End Sub

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties
End Class