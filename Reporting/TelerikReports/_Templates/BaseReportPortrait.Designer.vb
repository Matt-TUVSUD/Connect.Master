Partial Class BaseReportPortrait

	'NOTE: The following procedure is required by the Telerik Reporting Designer
	'It can be modified using the Telerik Reporting Designer.  
	'Do not modify it using the code editor.
	Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BaseReportPortrait))
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group2 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group3 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Me.BaseGroupFooterSection3 = New Telerik.Reporting.GroupFooterSection()
        Me.BaseGroupHeaderLogoSection = New Telerik.Reporting.GroupHeaderSection()
        Me.txtStandardHeader = New Telerik.Reporting.HtmlTextBox()
        Me.GrcLogo = New Telerik.Reporting.PictureBox()
        Me.txtReportDate = New Telerik.Reporting.TextBox()
        Me.BaseGroupFooterReportTitleSection = New Telerik.Reporting.GroupFooterSection()
        Me.BaseGroupReportTitleSection1 = New Telerik.Reporting.GroupHeaderSection()
        Me.txtAlternateHeader = New Telerik.Reporting.HtmlTextBox()
        Me.BaseGroupFooterFilterSection = New Telerik.Reporting.GroupFooterSection()
        Me.GroupHeaderFilterSection = New Telerik.Reporting.GroupHeaderSection()
        Me.txtFilter = New Telerik.Reporting.HtmlTextBox()
        Me.PageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        Me.txtDisclaimer = New Telerik.Reporting.HtmlTextBox()
        Me.Shape1 = New Telerik.Reporting.Shape()
        Me.FooterDatePagerPanel = New Telerik.Reporting.Panel()
        Me.txtSort = New Telerik.Reporting.HtmlTextBox()
        Me.txtPageCounter = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'BaseGroupFooterSection3
        '
        Me.BaseGroupFooterSection3.Height = Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699R)
        Me.BaseGroupFooterSection3.Name = "BaseGroupFooterSection3"
        Me.BaseGroupFooterSection3.Style.Visible = False
        '
        'BaseGroupHeaderLogoSection
        '
        Me.BaseGroupHeaderLogoSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.56967192888259888R)
        Me.BaseGroupHeaderLogoSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.txtStandardHeader, Me.GrcLogo, Me.txtReportDate})
        Me.BaseGroupHeaderLogoSection.Name = "BaseGroupHeaderLogoSection"
        Me.BaseGroupHeaderLogoSection.PrintOnEveryPage = True
        '
        'txtStandardHeader
        '
        Me.txtStandardHeader.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.9375789165496826R), Telerik.Reporting.Drawing.Unit.Inch(0.083372749388217926R))
        Me.txtStandardHeader.Name = "txtStandardHeader"
        Me.txtStandardHeader.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.0029678344726562R), Telerik.Reporting.Drawing.Unit.Inch(0.25R))
        Me.txtStandardHeader.Style.BackgroundColor = System.Drawing.Color.White
        Me.txtStandardHeader.Style.Color = System.Drawing.Color.Black
        Me.txtStandardHeader.Style.Font.Bold = False
        Me.txtStandardHeader.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.txtStandardHeader.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.txtStandardHeader.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtStandardHeader.Value = ""
        '
        'GrcLogo
        '
        Me.GrcLogo.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.010416666977107525R), Telerik.Reporting.Drawing.Unit.Inch(0.029127439484000206R))
        Me.GrcLogo.MimeType = "image/jpeg"
        Me.GrcLogo.Name = "GrcLogo"
        Me.GrcLogo.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(290.0R), Telerik.Reporting.Drawing.Unit.Pixel(50.0R))
        Me.GrcLogo.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional
        Me.GrcLogo.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.GrcLogo.Value = CType(resources.GetObject("GrcLogo.Value"), Object)
        '
        'txtReportDate
        '
        Me.txtReportDate.Format = "{0:D}"
        Me.txtReportDate.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.3636107444763184R), Telerik.Reporting.Drawing.Unit.Inch(0.33345142006874084R))
        Me.txtReportDate.Name = "txtReportDate"
        Me.txtReportDate.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.5769357681274414R), Telerik.Reporting.Drawing.Unit.Inch(0.23622047901153564R))
        Me.txtReportDate.Style.BackgroundColor = System.Drawing.Color.White
        Me.txtReportDate.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtReportDate.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.txtReportDate.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtReportDate.Value = "= Now()"
        '
        'BaseGroupFooterReportTitleSection
        '
        Me.BaseGroupFooterReportTitleSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699R)
        Me.BaseGroupFooterReportTitleSection.Name = "BaseGroupFooterReportTitleSection"
        Me.BaseGroupFooterReportTitleSection.Style.Visible = False
        '
        'BaseGroupReportTitleSection1
        '
        Me.BaseGroupReportTitleSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.19988203048706055R)
        Me.BaseGroupReportTitleSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.txtAlternateHeader})
        Me.BaseGroupReportTitleSection1.Name = "BaseGroupReportTitleSection1"
        Me.BaseGroupReportTitleSection1.PrintOnEveryPage = True
        Me.BaseGroupReportTitleSection1.Style.BackgroundColor = System.Drawing.Color.Empty
        '
        'txtAlternateHeader
        '
        Me.txtAlternateHeader.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.010416666977107525R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.txtAlternateHeader.Name = "txtAlternateHeader"
        Me.txtAlternateHeader.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.9677085876464844R), Telerik.Reporting.Drawing.Unit.Inch(0.19988203048706055R))
        Me.txtAlternateHeader.Style.BackgroundColor = System.Drawing.Color.White
        Me.txtAlternateHeader.Style.Font.Bold = False
        Me.txtAlternateHeader.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.txtAlternateHeader.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtAlternateHeader.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtAlternateHeader.Value = "=FileNo"
        '
        'BaseGroupFooterFilterSection
        '
        Me.BaseGroupFooterFilterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699R)
        Me.BaseGroupFooterFilterSection.Name = "BaseGroupFooterFilterSection"
        Me.BaseGroupFooterFilterSection.Style.Visible = False
        '
        'GroupHeaderFilterSection
        '
        Me.GroupHeaderFilterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.20011790096759796R)
        Me.GroupHeaderFilterSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.txtFilter})
        Me.GroupHeaderFilterSection.Name = "GroupHeaderFilterSection"
        Me.GroupHeaderFilterSection.PrintOnEveryPage = True
        Me.GroupHeaderFilterSection.Style.BackgroundColor = System.Drawing.Color.Empty
        '
        'txtFilter
        '
        Me.txtFilter.CanShrink = True
        Me.txtFilter.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.032291729003190994R), Telerik.Reporting.Drawing.Unit.Inch(0.00011793772137025371R))
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.9635415077209473R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.txtFilter.Style.BackgroundColor = System.Drawing.Color.White
        Me.txtFilter.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtFilter.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(5.0R)
        Me.txtFilter.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(5.0R)
        Me.txtFilter.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtFilter.Value = "txtFilter"
        '
        'PageFooterSection1
        '
        Me.PageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.61458331346511841R)
        Me.PageFooterSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.txtDisclaimer, Me.Shape1, Me.FooterDatePagerPanel, Me.txtPageCounter})
        Me.PageFooterSection1.Name = "PageFooterSection1"
        Me.PageFooterSection1.Style.Visible = True
        '
        'txtDisclaimer
        '
        Me.txtDisclaimer.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.010416666977107525R), Telerik.Reporting.Drawing.Unit.Inch(0.25R))
        Me.txtDisclaimer.Name = "txtDisclaimer"
        Me.txtDisclaimer.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.9894652366638184R), Telerik.Reporting.Drawing.Unit.Inch(0.21454381942749023R))
        Me.txtDisclaimer.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.txtDisclaimer.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtDisclaimer.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtDisclaimer.Value = resources.GetString("txtDisclaimer.Value")
        '
        'Shape1
        '
        Me.Shape1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.028124967589974403R))
        Me.Shape1.Name = "Shape1"
        Me.Shape1.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.9999213218688965R), Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699R))
        Me.Shape1.Style.Color = System.Drawing.SystemColors.Desktop
        '
        'FooterDatePagerPanel
        '
        Me.FooterDatePagerPanel.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.txtSort})
        Me.FooterDatePagerPanel.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.087460517883300781R))
        Me.FooterDatePagerPanel.Name = "FooterDatePagerPanel"
        Me.FooterDatePagerPanel.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.9998817443847656R), Telerik.Reporting.Drawing.Unit.Inch(0.14996068179607391R))
        '
        'txtSort
        '
        Me.txtSort.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6083335876464844R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.txtSort.Name = "txtSort"
        Me.txtSort.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.9905457496643066R), Telerik.Reporting.Drawing.Unit.Inch(0.149921253323555R))
        Me.txtSort.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.txtSort.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtSort.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtSort.Value = ""
        '
        'txtPageCounter
        '
        Me.txtPageCounter.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.59490966796875R), Telerik.Reporting.Drawing.Unit.Inch(0.46462264657020569R))
        Me.txtPageCounter.Name = "txtPageCounter"
        Me.txtPageCounter.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4009231328964233R), Telerik.Reporting.Drawing.Unit.Inch(0.149921253323555R))
        Me.txtPageCounter.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.txtPageCounter.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.txtPageCounter.Value = "Page {PageNumber} of {PageCount}"
        '
        'BaseReportPortrait
        '
        Group1.GroupFooter = Me.BaseGroupFooterSection3
        Group1.GroupHeader = Me.BaseGroupHeaderLogoSection
        Group1.Name = "BaseGroupLogo"
        Group2.GroupFooter = Me.BaseGroupFooterReportTitleSection
        Group2.GroupHeader = Me.BaseGroupReportTitleSection1
        Group2.Name = "BaseGroupAltReportTitle"
        Group3.GroupFooter = Me.BaseGroupFooterFilterSection
        Group3.GroupHeader = Me.GroupHeaderFilterSection
        Group3.Name = "BaseGroupFilter"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1, Group2, Group3})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.BaseGroupHeaderLogoSection, Me.BaseGroupFooterSection3, Me.BaseGroupReportTitleSection1, Me.BaseGroupFooterReportTitleSection, Me.GroupHeaderFilterSection, Me.BaseGroupFooterFilterSection, Me.PageFooterSection1})
        Me.Name = "BaseReportPortrait"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.25R), Telerik.Reporting.Drawing.Unit.Inch(0.25R), Telerik.Reporting.Drawing.Unit.Inch(0.25R), Telerik.Reporting.Drawing.Unit.Inch(0.25R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        Me.Style.BackgroundColor = System.Drawing.Color.White
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(7.9999213218688965R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents PageFooterSection1 As Telerik.Reporting.PageFooterSection
    Friend WithEvents txtPageCounter As Telerik.Reporting.TextBox
    Friend WithEvents txtFilter As Telerik.Reporting.HtmlTextBox
    Friend WithEvents BaseGroupFilter As Telerik.Reporting.Group
    Friend WithEvents BaseGroupFooterFilterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents GroupHeaderFilterSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents BaseGroupLogo As Telerik.Reporting.Group
    Friend WithEvents BaseGroupFooterSection3 As Telerik.Reporting.GroupFooterSection
    Friend WithEvents BaseGroupHeaderLogoSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents BaseGroupAltReportTitle As Telerik.Reporting.Group
    Friend WithEvents BaseGroupFooterReportTitleSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents BaseGroupReportTitleSection1 As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents txtStandardHeader As Telerik.Reporting.HtmlTextBox
    Friend WithEvents txtDisclaimer As Telerik.Reporting.HtmlTextBox
    Friend WithEvents txtSort As Telerik.Reporting.HtmlTextBox
    Friend WithEvents Shape1 As Telerik.Reporting.Shape
    Friend WithEvents txtAlternateHeader As Telerik.Reporting.HtmlTextBox
    Friend WithEvents GrcLogo As Telerik.Reporting.PictureBox
    Friend WithEvents FooterDatePagerPanel As Telerik.Reporting.Panel
    Friend WithEvents txtReportDate As Telerik.Reporting.TextBox
End Class