Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class PMReport
    Inherits Telerik.Reporting.Report

    Private _ds As Object
    Private _IsNewProjectReport As Boolean = False
    Private _IsClientReport As Boolean = False

    Public Sub New()
        InitializeComponent()

        Dim zRS2 As New InstanceReportSource
        zRS2.ReportDocument = New PMPolicyValueSubReport
        zRS2.Parameters.Add("ProjectRowID", "=RowID")
        uxPolicyValuesSubReport.ReportSource = zRS2

        Dim zRS3 As New InstanceReportSource
        zRS3.ReportDocument = New PMActivitySubReport
        zRS3.Parameters.Add("ProjectRowID", "=RowID")
        uxActivitiesSubReport.ReportSource = zRS3

        Dim zRS4 As New InstanceReportSource
        zRS4.ReportDocument = New PMIssuesSubReport
        zRS4.Parameters.Add("ProjectRowID", "=RowID")
        uxIssuesSubReport.ReportSource = zRS4

        Dim zRS5 As New InstanceReportSource
        zRS5.ReportDocument = New PMMilestonesSubReport
        zRS5.Parameters.Add("ProjectRowID", "=RowID")
        uxMilestonesSubReport.ReportSource = zRS5

        Dim zRS6 As New InstanceReportSource
        zRS6.ReportDocument = New PMContactsSubReport
        zRS6.Parameters.Add("ProjectRowID", "=RowID")
        uxContactsSubReport.ReportSource = zRS6

    End Sub

    Public Property ReportDataSource As Object
        Get
            Return _ds
        End Get
        Set(value As Object)
            _ds = value
        End Set
    End Property

    Private Sub PMReport_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        If IsNewProjectReport Then
            SetAlternatePolicyValuesSubReport()
        End If

        If ReportDataSource.Activities.count = 0 Then Me.uxActivitiesSubReport.Visible = False
        If ReportDataSource.Issues.count = 0 Then Me.uxIssuesSubReport.Visible = False
        If ReportDataSource.Contacts.count = 0 Then Me.uxContactsSubReport.Visible = False
        If ReportDataSource.Milestones.count = 0 Then Me.uxMilestonesSubReport.Visible = False

    End Sub

    Private Sub PMReport_NeedDataSource(sender As Object, e As EventArgs) Handles Me.NeedDataSource
        Me.DataSource = _ds.Projects
    End Sub

    Public Property IsNewProjectReport As Boolean
        Get
            Return _IsNewProjectReport
        End Get
        Set(value As Boolean)
            _IsNewProjectReport = value
        End Set
    End Property

    ''' <summary>
    ''' Property for specifying if report is being printed from Client Connect for clients.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property IsClientReport As Boolean
        Get
            Return _IsClientReport
        End Get
        Set(value As Boolean)
            _IsClientReport = value
            uxActualHoursPanel.Visible = Not IsClientReport
            uxBillingTypePanel.Visible = Not IsClientReport
            uxBudgetedHoursPanel.Visible = Not IsClientReport
            uxAvailableHoursPanel.Visible = Not IsClientReport
        End Set
    End Property

    ''' <summary>
    ''' Switches the subreport to use the inspection request object at time of project creation
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetAlternatePolicyValuesSubReport()
        Dim zSubRpt As New PMPolicyValueSubReport_NewProject
        Dim zRS As New Telerik.Reporting.InstanceReportSource
        zRS.ReportDocument = zSubRpt
        Me.uxPolicyValuesSubReport.ReportSource = zRS

    End Sub

End Class