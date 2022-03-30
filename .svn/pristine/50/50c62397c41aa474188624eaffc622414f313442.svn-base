Imports System.ComponentModel
Imports System.Drawing

Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing


Partial Class PlanReviewReport
    Inherits BaseReportPortrait
    Implements ITelerikReport
    Implements IUtilReport

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        UtilReport.TelerikReport.FixBaseGroups(Me)
    End Sub

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
        Return "Plan/Project Review"
    End Function

    Public Function AppendPracticeToTitle() As Boolean Implements ITelerikReport.AppendPracticeToTitle
        Return True
    End Function

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties

    Private Sub PlanReviewReport_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        txtSchedulingTitle.Value = rptProperties.Practice.colFldReportDisplayTitle & " Scheduling Summary:"
        Me.ReviewActivitySubReport1.rptProperties = rptProperties
        Me.ScheduleSummarySubReport.rptProperties = rptProperties
    End Sub

    Private Sub Me_ItemDataBound(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        UtilReport.TelerikReport.SetFilterText(sender, rptProperties)
        UtilReport.TelerikReport.SetDisclaimerText(sender, rptProperties)
        UtilReport.TelerikReport.SetSortText(sender, rptProperties)

        Dim zDT As DataTable = Me.DataSource
        Dim zDV As DataView = zDT.DefaultView
        Me.DataSource = zDV.ToTable(True, "FileNo", "Client", "ClientLocNo", "Division", "Address1", "Address2", "Facility", "City", "StProv", "Country", "Zip")

    End Sub

End Class
