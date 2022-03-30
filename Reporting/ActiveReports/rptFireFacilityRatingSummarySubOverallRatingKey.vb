Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports

Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Imports GRC.Connect.Libraries.DataLib.razor

Public Class rptFireFacilityRatingSummarySubOverallRatingKey
    Inherits GrapeCity.ActiveReports.SectionReport
    Implements IUtilReport

#Region " ActiveReports Designer generated code "
    'Required by the ActiveReports Designer
    Private Shadows components As System.ComponentModel.IContainer
    Private WithEvents lblRating1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblTIVRating1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblRating As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblLOCRating1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents ReportHeader1 As GrapeCity.ActiveReports.SectionReportModel.ReportHeader
    Private WithEvents Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label6 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents ReportFooter1 As GrapeCity.ActiveReports.SectionReportModel.ReportFooter

    'NOTE: The following procedure is required by the ActiveReports Designer
    'It can be modified using the ActiveReports Designer.
    'Do not modify it using the code editor.
    Private WithEvents Detail1 As GrapeCity.ActiveReports.SectionReportModel.Detail
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptFireFacilityRatingSummarySubOverallRatingKey))
        Me.Detail1 = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.lblTIVRating1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblLOCRating1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblRating = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblRating1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.ReportHeader1 = New GrapeCity.ActiveReports.SectionReportModel.ReportHeader()
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label6 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.ReportFooter1 = New GrapeCity.ActiveReports.SectionReportModel.ReportFooter()
        CType(Me.lblTIVRating1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblLOCRating1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRating1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail1
        '
        Me.Detail1.CanGrow = False
        Me.Detail1.ColumnDirection = GrapeCity.ActiveReports.SectionReportModel.ColumnDirection.AcrossDown
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblTIVRating1, Me.lblLOCRating1, Me.lblRating, Me.lblRating1})
        Me.Detail1.Height = 0.15!
        Me.Detail1.KeepTogether = True
        Me.Detail1.Name = "Detail1"
        Me.Detail1.RepeatToFill = True
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
        Me.lblTIVRating1.Left = 1.45!
        Me.lblTIVRating1.Name = "lblTIVRating1"
        Me.lblTIVRating1.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; t" & _
    "ext-justify: auto; vertical-align: middle"
        Me.lblTIVRating1.Text = ""
        Me.lblTIVRating1.Top = 0.0!
        Me.lblTIVRating1.Width = 0.752!
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
        Me.lblLOCRating1.Left = 2.202!
        Me.lblLOCRating1.Name = "lblLOCRating1"
        Me.lblLOCRating1.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblLOCRating1.Text = ""
        Me.lblLOCRating1.Top = 0.0!
        Me.lblLOCRating1.Width = 0.9620005!
        '
        'lblRating
        '
        Me.lblRating.DataField = "Rating"
        Me.lblRating.Height = 0.15!
        Me.lblRating.HyperLink = Nothing
        Me.lblRating.Left = 0.0!
        Me.lblRating.Name = "lblRating"
        Me.lblRating.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblRating.Text = ""
        Me.lblRating.Top = 0.0!
        Me.lblRating.Visible = False
        Me.lblRating.Width = 0.125!
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
        Me.lblRating1.Left = 0.125!
        Me.lblRating1.Name = "lblRating1"
        Me.lblRating1.Style = "background-color: White; font-size: 8pt; font-weight: bold; text-align: center; v" & _
    "ertical-align: middle"
        Me.lblRating1.Text = "Rating1"
        Me.lblRating1.Top = 0.0!
        Me.lblRating1.Width = 1.325!
        '
        'ReportHeader1
        '
        Me.ReportHeader1.CanGrow = False
        Me.ReportHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label5, Me.Label6, Me.Label4})
        Me.ReportHeader1.Height = 0.2!
        Me.ReportHeader1.Name = "ReportHeader1"
        '
        'Label5
        '
        Me.Label5.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label5.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label5.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label5.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label5.Height = 0.2!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 1.45!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-size: 8.25pt; font-weight: bold; text-align: center; text-justify: auto; ddo" & _
    "-char-set: 0"
        Me.Label5.Text = "% by TIV"
        Me.Label5.Top = 0.0!
        Me.Label5.Width = 0.7519997!
        '
        'Label6
        '
        Me.Label6.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label6.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label6.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label6.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label6.Height = 0.2!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 2.202!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-size: 8.25pt; font-weight: bold; text-align: center; text-justify: auto; ddo" & _
    "-char-set: 0"
        Me.Label6.Text = "% by No. of Loc."
        Me.Label6.Top = 0.0!
        Me.Label6.Width = 0.9620004!
        '
        'Label4
        '
        Me.Label4.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label4.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label4.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label4.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label4.Height = 0.2!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 0.125!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-size: 8.25pt; font-weight: bold; text-align: center; text-justify: auto; ddo" & _
    "-char-set: 0"
        Me.Label4.Text = "Overall Key Rating"
        Me.Label4.Top = 0.0!
        Me.Label4.Width = 1.325!
        '
        'ReportFooter1
        '
        Me.ReportFooter1.CanGrow = False
        Me.ReportFooter1.Height = 0.0!
        Me.ReportFooter1.Name = "ReportFooter1"
        Me.ReportFooter1.Visible = False
        '
        'rptFireFacilityRatingSummarySubOverallRatingKey
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 3.170835!
        Me.Sections.Add(Me.ReportHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.ReportFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Calibri; font-style: normal; text-decoration: none; font-weight: nor" & _
            "mal; font-size: 10pt; color: Black", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
            "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.lblTIVRating1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblLOCRating1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRating1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
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

    Private Sub rptFireFacilityRatingSummarySubOverallRatingKey_FetchData(sender As Object, eArgs As SectionReport.FetchEventArgs) Handles Me.FetchData
        'Dim zControls() As ARControl = {lblRating1}
        'Dim zValueControls() As ARControl = {lblRating}
        'UtilReport.ActiveReport.SetItemBackColorByRiskRating(Me, zControls, zValueControls, rptProperties)

        Dim zrpt As SectionReport = sender
        Dim zColorID As Integer = rptProperties.FireRatingRange.Find(Function(x) x.colFldRating = zrpt.AllFields("Rating").Value).colFldMetaColorId
        lblRating1.BackColor = System.Drawing.ColorTranslator.FromHtml(rptProperties.Colors.Find(Function(x) x.colFldId = zColorID).colFldHex)

    End Sub

    Private Sub rptFireFacilityRatingSummarySubOverallRatingKey_ReportStart(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportStart
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

        For Each zRating As rowVwMetaRatingKeyRange In rptProperties.FireRatingRange
            Dim zRow As DataRow = zKeyData.NewRow

            zRow("RangeDescription") = zRating.colFldDescription
            zRow("Rating") = zRating.colFldRating

            Dim zFilteredTIV As Object = zDT.Compute("Sum(TIV)", "OverallPlantRating='" & zRating.colFldRating & "'")
            Dim zFilteredLocations As Object = zDT.Compute("Count(FileNo)", "OverallPlantRating='" & zRating.colFldRating & "'")

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

    Private Sub rptFireFacilityRatingSummarySubOverallRatingKey_ReportEnd(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ReportEnd
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
