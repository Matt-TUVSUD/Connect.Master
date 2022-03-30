Partial Class RiskImprovementChart

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RiskImprovementChart))
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group2 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group3 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.Report1 = New Telerik.Reporting.DetailSection()
        Me.HtmlTextBox1 = New Telerik.Reporting.HtmlTextBox()
        Me.HtmlTextBox2 = New Telerik.Reporting.HtmlTextBox()
        Me.RecStatusTitle = New Telerik.Reporting.HtmlTextBox()
        Me.RecStatusSubTitle = New Telerik.Reporting.HtmlTextBox()
        Me.ExposureChart = New Telerik.Reporting.Chart()
        Me.ChartMessage = New Telerik.Reporting.TextBox()
        Me.RecStatusChart = New Telerik.Reporting.Chart()
        Me.Panel1 = New Telerik.Reporting.Panel()
        Me.HtmlTextBox3 = New Telerik.Reporting.HtmlTextBox()
        Me.HtmlTextBox4 = New Telerik.Reporting.HtmlTextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Report1
        '
        Me.Report1.Height = Telerik.Reporting.Drawing.Unit.Inch(6.1000003814697266R)
        Me.Report1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.HtmlTextBox1, Me.HtmlTextBox2, Me.RecStatusTitle, Me.RecStatusSubTitle, Me.ExposureChart, Me.ChartMessage, Me.RecStatusChart, Me.Panel1, Me.HtmlTextBox3, Me.HtmlTextBox4})
        Me.Report1.Name = "Report1"
        '
        'HtmlTextBox1
        '
        Me.HtmlTextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926R), Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926R))
        Me.HtmlTextBox1.Name = "HtmlTextBox1"
        Me.HtmlTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.9000000953674316R), Telerik.Reporting.Drawing.Unit.Inch(0.39992132782936096R))
        Me.HtmlTextBox1.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.HtmlTextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.HtmlTextBox1.Value = "<p style=""text-align: center""><span style=""color: #ffffff; font-size: medium""><st" & _
    "rong>Recommendations</strong></span></p>"
        '
        'HtmlTextBox2
        '
        Me.HtmlTextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.3000006675720215R), Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926R))
        Me.HtmlTextBox2.Name = "HtmlTextBox2"
        Me.HtmlTextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.0000004768371582R), Telerik.Reporting.Drawing.Unit.Inch(0.39992132782936096R))
        Me.HtmlTextBox2.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.HtmlTextBox2.Value = "<p style=""text-align: center""><strong><span style=""color: #ffffff"">Risk Mitigated" & _
    "<br />(All Locations/Life of Program)</span></strong></p>"
        '
        'RecStatusTitle
        '
        Me.RecStatusTitle.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926R), Telerik.Reporting.Drawing.Unit.Inch(0.60000008344650269R))
        Me.RecStatusTitle.Name = "RecStatusTitle"
        Me.RecStatusTitle.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.9000000953674316R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.RecStatusTitle.Value = "<p style=""text-align: center""><strong><span style=""font-size: 11pt"">Total B&amp;M" & _
    " Recommendations</span></strong></p>"
        '
        'RecStatusSubTitle
        '
        Me.RecStatusSubTitle.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926R), Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929R))
        Me.RecStatusSubTitle.Name = "RecStatusSubTitle"
        Me.RecStatusSubTitle.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.9000000953674316R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.RecStatusSubTitle.Value = "<p style=""text-align: center"">2,405 Total Rec's</p>"
        '
        'ExposureChart
        '
        Me.ExposureChart.AutoLayout = True
        Me.ExposureChart.BitmapResolution = 96.0!
        Me.ExposureChart.ChartTitle.Appearance.Visible = False
        Me.ExposureChart.ChartTitle.Visible = False
        Me.ExposureChart.ImageFormat = System.Drawing.Imaging.ImageFormat.Emf
        Me.ExposureChart.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.3000006675720215R), Telerik.Reporting.Drawing.Unit.Inch(0.60000014305114746R))
        Me.ExposureChart.Name = "ExposureChart"
        Me.ExposureChart.PlotArea.EmptySeriesMessage.Appearance.Visible = True
        Me.ExposureChart.PlotArea.EmptySeriesMessage.Visible = True
        Me.ExposureChart.PlotArea.YAxis.VisibleValues = Telerik.Reporting.Charting.Styles.ChartAxisVisibleValues.Positive
        Me.ExposureChart.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.0R), Telerik.Reporting.Drawing.Unit.Inch(4.6000003814697266R))
        '
        'ChartMessage
        '
        Me.ChartMessage.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9000003337860107R), Telerik.Reporting.Drawing.Unit.Inch(5.2000007629394531R))
        Me.ChartMessage.Name = "ChartMessage"
        Me.ChartMessage.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.4000003337860107R), Telerik.Reporting.Drawing.Unit.Inch(0.7999998927116394R))
        Me.ChartMessage.Style.BackgroundImage.ImageData = CType(resources.GetObject("ChartMessage.Style.BackgroundImage.ImageData"), System.Drawing.Image)
        Me.ChartMessage.Style.BackgroundImage.MimeType = "image/png"
        Me.ChartMessage.Style.BackgroundImage.Repeat = Telerik.Reporting.Drawing.BackgroundRepeat.NoRepeat
        Me.ChartMessage.Style.Font.Bold = True
        Me.ChartMessage.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.ChartMessage.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.ChartMessage.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.ChartMessage.Value = "Risk Improvement"
        '
        'RecStatusChart
        '
        Me.RecStatusChart.AutoLayout = True
        Me.RecStatusChart.BitmapResolution = 96.0!
        Me.RecStatusChart.ChartTitle.Appearance.Visible = False
        Me.RecStatusChart.ChartTitle.Visible = False
        Me.RecStatusChart.ImageFormat = System.Drawing.Imaging.ImageFormat.Emf
        Me.RecStatusChart.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.10000006109476089R), Telerik.Reporting.Drawing.Unit.Inch(1.0000787973403931R))
        Me.RecStatusChart.Name = "RecStatusChart"
        Me.RecStatusChart.PlotArea.EmptySeriesMessage.Appearance.Visible = True
        Me.RecStatusChart.PlotArea.EmptySeriesMessage.Visible = True
        Me.RecStatusChart.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.9000000953674316R), Telerik.Reporting.Drawing.Unit.Inch(4.19992208480835R))
        '
        'Panel1
        '
        Me.Panel1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.30000004172325134R), Telerik.Reporting.Drawing.Unit.Inch(5.3312506675720215R))
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.5999214649200439R), Telerik.Reporting.Drawing.Unit.Inch(0.599999725818634R))
        Me.Panel1.Style.BackgroundImage.ImageData = CType(resources.GetObject("Panel1.Style.BackgroundImage.ImageData"), System.Drawing.Image)
        Me.Panel1.Style.BackgroundImage.MimeType = "image/png"
        Me.Panel1.Style.BackgroundImage.Repeat = Telerik.Reporting.Drawing.BackgroundRepeat.NoRepeat
        '
        'HtmlTextBox3
        '
        Me.HtmlTextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.5R), Telerik.Reporting.Drawing.Unit.Inch(5.2687506675720215R))
        Me.HtmlTextBox3.Name = "HtmlTextBox3"
        Me.HtmlTextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.7000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.299999862909317R))
        Me.HtmlTextBox3.Value = "<span style=""font-size: 8pt""><span style=""font-size: 8pt""><strong>Identified </st" & _
    "rong>= Sum of Average Current Loss Estimates for all Recommendations</span></spa" & _
    "n>"
        '
        'HtmlTextBox4
        '
        Me.HtmlTextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.5R), Telerik.Reporting.Drawing.Unit.Inch(5.6000003814697266R))
        Me.HtmlTextBox4.Name = "HtmlTextBox4"
        Me.HtmlTextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.7000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.40000024437904358R))
        Me.HtmlTextBox4.Value = resources.GetString("HtmlTextBox4.Value")
        '
        'RiskImprovementChart
        '
        Group1.Name = "BaseGroupLogo"
        Group2.Name = "BaseGroupAltReportTitle"
        Group3.Name = "BaseGroupFilter"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1, Group2, Group3})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Report1})
        Me.Name = "RecommendationExposure"
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.25R), Telerik.Reporting.Drawing.Unit.Inch(0.25R), Telerik.Reporting.Drawing.Unit.Inch(0.25R), Telerik.Reporting.Drawing.Unit.Inch(0.25R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        Me.Style.BackgroundColor = System.Drawing.Color.White
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(10.5R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Report1 As Telerik.Reporting.DetailSection
    Friend WithEvents HtmlTextBox1 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents HtmlTextBox2 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents RecStatusTitle As Telerik.Reporting.HtmlTextBox
    Friend WithEvents RecStatusSubTitle As Telerik.Reporting.HtmlTextBox
    Friend WithEvents ExposureChart As Telerik.Reporting.Chart
    Friend WithEvents ChartMessage As Telerik.Reporting.TextBox
    Friend WithEvents RecStatusChart As Telerik.Reporting.Chart
    Friend WithEvents Panel1 As Telerik.Reporting.Panel
    Friend WithEvents HtmlTextBox3 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents HtmlTextBox4 As Telerik.Reporting.HtmlTextBox
End Class