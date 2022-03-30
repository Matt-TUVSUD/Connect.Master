Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports

Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Imports GRC.Connect.Libraries.DataLib.razor

Public Class rptBMFacilityRatingSummarySubOverallRatingKey
    Inherits GrapeCity.ActiveReports.SectionReport
    Implements IUtilReport

#Region " ActiveReports Designer generated code "
    'Required by the ActiveReports Designer
    Private Shadows components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the ActiveReports Designer
    'It can be modified using the ActiveReports Designer.
    'Do not modify it using the code editor.
    Private WithEvents lblRating1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblTIVRating1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblLOCRating1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblRating As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents ReportHeader1 As GrapeCity.ActiveReports.SectionReportModel.ReportHeader
    Private WithEvents Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents ReportFooter1 As GrapeCity.ActiveReports.SectionReportModel.ReportFooter
    Private WithEvents Detail1 As GrapeCity.ActiveReports.SectionReportModel.Detail
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptBMFacilityRatingSummarySubOverallRatingKey))
        Me.Detail1 = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.lblRating1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblTIVRating1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblRating = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblLOCRating1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.ReportHeader1 = New GrapeCity.ActiveReports.SectionReportModel.ReportHeader()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.ReportFooter1 = New GrapeCity.ActiveReports.SectionReportModel.ReportFooter()
        CType(Me.lblRating1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTIVRating1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblLOCRating1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail1
        '
        Me.Detail1.ColumnDirection = GrapeCity.ActiveReports.SectionReportModel.ColumnDirection.AcrossDown
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblRating1, Me.lblTIVRating1, Me.lblRating, Me.lblLOCRating1})
        Me.Detail1.Height = 0.15!
        Me.Detail1.KeepTogether = True
        Me.Detail1.Name = "Detail1"
        Me.Detail1.RepeatToFill = True
        '
        'lblRating1
        '
        Me.lblRating1.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblRating1.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblRating1.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblRating1.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblRating1.DataField = "RangeDescription"
        Me.lblRating1.Height = 0.15!
        Me.lblRating1.HyperLink = Nothing
        Me.lblRating1.Left = 0.05!
        Me.lblRating1.Name = "lblRating1"
        Me.lblRating1.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblRating1.Text = "Rating1"
        Me.lblRating1.Top = 0.0!
        Me.lblRating1.Width = 1.55!
        '
        'lblTIVRating1
        '
        Me.lblTIVRating1.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblTIVRating1.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblTIVRating1.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblTIVRating1.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblTIVRating1.DataField = "PercentByTIV"
        Me.lblTIVRating1.Height = 0.15!
        Me.lblTIVRating1.HyperLink = Nothing
        Me.lblTIVRating1.Left = 1.6!
        Me.lblTIVRating1.Name = "lblTIVRating1"
        Me.lblTIVRating1.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; t" & _
    "ext-justify: auto; vertical-align: middle"
        Me.lblTIVRating1.Text = ""
        Me.lblTIVRating1.Top = 0.0!
        Me.lblTIVRating1.Width = 0.7500002!
        '
        'lblRating
        '
        Me.lblRating.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblRating.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblRating.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblRating.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblRating.DataField = "Rating"
        Me.lblRating.Height = 0.15!
        Me.lblRating.HyperLink = Nothing
        Me.lblRating.Left = 3.027!
        Me.lblRating.Name = "lblRating"
        Me.lblRating.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblRating.Text = ""
        Me.lblRating.Top = 0.0!
        Me.lblRating.Visible = False
        Me.lblRating.Width = 0.323!
        '
        'lblLOCRating1
        '
        Me.lblLOCRating1.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblLOCRating1.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblLOCRating1.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblLOCRating1.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblLOCRating1.DataField = "PercentByLoc"
        Me.lblLOCRating1.Height = 0.15!
        Me.lblLOCRating1.HyperLink = Nothing
        Me.lblLOCRating1.Left = 2.35!
        Me.lblLOCRating1.Name = "lblLOCRating1"
        Me.lblLOCRating1.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblLOCRating1.Text = ""
        Me.lblLOCRating1.Top = 0.0!
        Me.lblLOCRating1.Width = 1.0!
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label1, Me.Label2, Me.Label3})
        Me.ReportHeader1.Height = 0.2!
        Me.ReportHeader1.Name = "ReportHeader1"
        '
        'Label1
        '
        Me.Label1.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Height = 0.15!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.05000007!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.Label1.Text = "Overall Rating Key"
        Me.Label1.Top = 0.05!
        Me.Label1.Width = 1.55!
        '
        'Label2
        '
        Me.Label2.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label2.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label2.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label2.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label2.Height = 0.15!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 1.6!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; t" & _
    "ext-justify: auto; vertical-align: middle"
        Me.Label2.Text = "% by TIV"
        Me.Label2.Top = 0.05!
        Me.Label2.Width = 0.7499999!
        '
        'Label3
        '
        Me.Label3.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Height = 0.15!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 2.35!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.Label3.Text = "% by No. of Locs."
        Me.Label3.Top = 0.05!
        Me.Label3.Width = 1.0!
        '
        'ReportFooter1
        '
        Me.ReportFooter1.Height = 0.0!
        Me.ReportFooter1.Name = "ReportFooter1"
        Me.ReportFooter1.Visible = False
        '
        'rptBMFacilityRatingSummarySubOverallRatingKey
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 3.379167!
        Me.Sections.Add(Me.ReportHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.ReportFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Calibri; font-style: normal; text-decoration: none; font-weight: nor" & _
            "mal; font-size: 10pt; color: Black", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
            "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.lblRating1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTIVRating1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblLOCRating1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
#End Region


    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private Sub rptBMFacilityRatingSummarySubOverallRatingKey_FetchData(sender As Object, eArgs As SectionReport.FetchEventArgs) Handles Me.FetchData
        Dim zControls() As ARControl = {lblRating1}
        Dim zValueControls() As ARControl = {lblRating}

        Dim zrpt As SectionReport = sender
        Dim zColorID As Integer = rptProperties.BMRatingRange.Find(Function(x) x.colFldRating = zrpt.AllFields("Rating").Value).colFldMetaColorId
        lblRating1.BackColor = System.Drawing.ColorTranslator.FromHtml(rptProperties.Colors.Find(Function(x) x.colFldId = zColorID).colFldHex)
        'txtCurrentFactor.BackColor =
        'txtRecsCompletedFactor.BackColor = System.Drawing.ColorTranslator.FromHtml(zrpt.AllFields("totalwrcompleteratingColor").Value)

        'UtilReport.ActiveReport.SetItemBackColorByRiskRating(Me, zControls, zValueControls, rptProperties)
    End Sub

    Private Sub rptBMFacilityRatingSummarySubOverallRatingKey_ReportStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportStart
        SetOverallRatingKey()
    End Sub

    Private Sub SetOverallRatingKey()

        Dim zDT As DataTable = Me.ParentReport.DataSource
        Dim zTotalLocations As Integer = zDT.Rows.Count
        Dim zTotalTIV As Object = zDT.Compute("Sum(TIV)", "")
        Dim zKeyData As New DataTable
        zKeyData.Columns.Add("RangeDescription")
        zKeyData.Columns.Add("Rating")
        zKeyData.Columns.Add("PercentByTIV")
        zKeyData.Columns.Add("PercentByLoc")

        For Each zRating As rowVwMetaRatingKeyRange In rptProperties.BMRatingRange
            Dim zRow As DataRow = zKeyData.NewRow

            zRow("RangeDescription") = zRating.colFldDescription
            zRow("Rating") = zRating.colFldRating

            Dim zFilteredTIV As Object = zDT.Compute("Sum(TIV)", "TotalRating='" & zRating.colFldRating & "'")
            Dim zFilteredLocations As Object = zDT.Compute("Count(FileNo)", "TotalRating='" & zRating.colFldRating & "'")

            If IsDBNull(zFilteredTIV) Then
                zRow("PercentByTIV") = "0%"
            Else
                zRow("PercentByTIV") = Math.Round((zFilteredTIV / zTotalTIV) * 100, 0) & "%"
            End If

            If zFilteredLocations = 0 Then
                zRow("PercentByLOC") = "0%"
            Else
                zRow("PercentByLOC") = Math.Round((zFilteredLocations / zTotalLocations) * 100, 0) & "%"
            End If

            zKeyData.Rows.Add(zRow)
        Next

        Me.DataSource = zKeyData

    End Sub

    Private Sub rptBMFacilityRatingSummarySubOverallRatingKey_ReportEnd(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportEnd
        DisposeParameters()
    End Sub

    Private Sub DisposeParameters()

    End Sub

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties

    Private Class OverallRatingKey
        Public RangeDescription As String
        Public Color As System.Drawing.Color
        Public PercentByTIV As String
        Public PercentByLoc As String
    End Class

    Private Function IzFilteredLocations() As Integer
        Throw New NotImplementedException
    End Function

End Class



