Imports System.ComponentModel
Imports System.Drawing
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing


Public Class QorRecommendations
    Inherits BaseSubReport
    Implements IUtilReport

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub QorRecommendations_ItemDataBound(sender As Object, e As System.EventArgs) Handles Me.ItemDataBound
        Dim zMe As Telerik.Reporting.Processing.Report = DirectCast(sender, Processing.Report)
        Dim zSubRpt As Telerik.Reporting.Processing.SubReport = Nothing
        If Processing.ElementTreeHelper.GetChildElements(zMe).Count = 0 Then
            zSubRpt = DirectCast(sender.parent, Telerik.Reporting.Processing.SubReport)
            zSubRpt.Visible = False
        Else
            If Left(zMe.Name.ToLower, 4).ToLower = "bpvm" Then Me.detail.Style.BackgroundColor = Color.Yellow
            If Left(zMe.Name.ToLower, 3).ToLower = "eem" Then Me.detail.Style.BackgroundColor = Color.Yellow
            If Left(zMe.Name.ToLower, 3).ToLower = "mem" Then Me.detail.Style.BackgroundColor = Color.Yellow
            If Left(zMe.Name.ToLower, 3).ToLower = "oto" Then Me.detail.Style.BackgroundColor = Color.Yellow
            If Left(zMe.Name.ToLower, 4).ToLower = "ecro" Then Me.detail.Style.BackgroundColor = Color.Yellow
            If Left(zMe.Name.ToLower, 3).ToLower = "isc" Then Me.detail.Style.BackgroundColor = Color.Yellow
            If Left(zMe.Name.ToLower, 3).ToLower = "itp" Then Me.detail.Style.BackgroundColor = Color.Yellow
            If Left(zMe.Name.ToLower, 3).ToLower = "cim" Then Me.detail.Style.BackgroundColor = Color.Yellow
            If Left(zMe.Name.ToLower, 3).ToLower = "ooa" Then Me.detail.Style.BackgroundColor = Color.Yellow
            If Left(zMe.Name.ToLower, 12) = "rsbpfacility" Then
                Me.detail.Style.BackgroundColor = Color.LightBlue
                Me.Width = New Drawing.Unit(7.95, UnitType.Inch)
                Me.TextBox1.Width = New Drawing.Unit(7.95, UnitType.Inch)
            End If

            If Left(zMe.Name.ToLower, 8) = "rsbpfire" Then
                Me.detail.Style.BackgroundColor = Color.LightBlue
                Me.Width = New Drawing.Unit(7.95, UnitType.Inch)
                Me.TextBox1.Width = New Drawing.Unit(7.95, UnitType.Inch)
            End If

        End If
    End Sub

    Private Sub HideSubReport(sender As Object, e As System.EventArgs) Handles Me.ItemDataBound
        Dim zRpt As Processing.Report = DirectCast(sender, Processing.Report)
        Dim zSubRpt As Processing.SubReport = zRpt.ParentElement
        Dim zDetailSections() As Processing.LayoutElement = Processing.ElementTreeHelper.FindChildByName(zRpt, "Detail", True)
        If zDetailSections.Count = 0 Then
            zSubRpt.Visible = False
        End If
    End Sub

    Private Sub QorRecommendations_NeedDataSource(sender As Object, e As System.EventArgs) Handles Me.NeedDataSource
        Dim zDT As DataTable = rptDS.Tables(Me.rptQorFilter.ToString)
        Me.DataSource = zDT
    End Sub

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties
    Public Property rptQorFilter As QorReport.QorFilter
    Public Property rptDS As DataSet
End Class