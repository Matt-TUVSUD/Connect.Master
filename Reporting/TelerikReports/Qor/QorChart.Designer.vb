Partial Class QorChart
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group2 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group3 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group4 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.GroupFooterSection1 = New Telerik.Reporting.GroupFooterSection()
        Me.GroupHeaderSection1 = New Telerik.Reporting.GroupHeaderSection()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.txtChartAvg = New Telerik.Reporting.TextBox()
        Me.txtEnterpriseAvg = New Telerik.Reporting.TextBox()
        Me.Chart1 = New Telerik.Reporting.Chart()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699R)
        Me.detail.Name = "detail"
        Me.detail.Style.Visible = False
        '
        'GroupFooterSection1
        '
        Me.GroupFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699R)
        Me.GroupFooterSection1.Name = "GroupFooterSection1"
        Me.GroupFooterSection1.Style.Visible = False
        '
        'GroupHeaderSection1
        '
        Me.GroupHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(5.96250057220459R)
        Me.GroupHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox8, Me.TextBox7, Me.txtChartAvg, Me.txtEnterpriseAvg, Me.Chart1})
        Me.GroupHeaderSection1.Name = "GroupHeaderSection1"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.4968752861022949R), Telerik.Reporting.Drawing.Unit.Inch(0.0000000014901161415892261R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0999996662139893R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.TextBox8.Style.Font.Bold = True
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox8.Value = "Enterprise Weighted Average:"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.4968752861022949R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0999996662139893R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.TextBox7.Style.Font.Bold = True
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox7.Value = "Chart Average:"
        '
        'txtChartAvg
        '
        Me.txtChartAvg.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.6125001907348633R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.txtChartAvg.Name = "txtChartAvg"
        Me.txtChartAvg.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.599999725818634R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.txtChartAvg.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.txtChartAvg.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtChartAvg.Style.Font.Bold = True
        Me.txtChartAvg.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtChartAvg.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtChartAvg.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtChartAvg.Value = "TextBox1"
        '
        'txtEnterpriseAvg
        '
        Me.txtEnterpriseAvg.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.6125001907348633R), Telerik.Reporting.Drawing.Unit.Inch(0.0000000014901161415892261R))
        Me.txtEnterpriseAvg.Name = "txtEnterpriseAvg"
        Me.txtEnterpriseAvg.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.599999725818634R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.txtEnterpriseAvg.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.txtEnterpriseAvg.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtEnterpriseAvg.Style.Font.Bold = True
        Me.txtEnterpriseAvg.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtEnterpriseAvg.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtEnterpriseAvg.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtEnterpriseAvg.Value = "TextBox1"
        '
        'Chart1
        '
        Me.Chart1.BitmapResolution = 96.0!
        Me.Chart1.ImageFormat = System.Drawing.Imaging.ImageFormat.Emf
        Me.Chart1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.47916662693023682R))
        Me.Chart1.Name = "Chart1"
        Me.Chart1.PlotArea.EmptySeriesMessage.Appearance.Visible = True
        Me.Chart1.PlotArea.EmptySeriesMessage.Visible = True
        Me.Chart1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(10.337459564208984R), Telerik.Reporting.Drawing.Unit.Inch(5.4364190101623535R))
        '
        'QorChart
        '
        Group1.Name = "BaseGroupLogo"
        Group2.Name = "BaseGroupAltReportTitle"
        Group3.Name = "BaseGroupFilter"
        Group4.GroupFooter = Me.GroupFooterSection1
        Group4.GroupHeader = Me.GroupHeaderSection1
        Group4.Name = "Group1"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1, Group2, Group3, Group4})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.GroupHeaderSection1, Me.GroupFooterSection1, Me.detail})
        Me.Name = "QorChart"
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.25R), Telerik.Reporting.Drawing.Unit.Inch(0.25R), Telerik.Reporting.Drawing.Unit.Inch(0.25R), Telerik.Reporting.Drawing.Unit.Inch(0.25R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        Me.Style.BackgroundColor = System.Drawing.Color.White
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(10.400001525878906R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
     Friend WithEvents detail As Telerik.Reporting.DetailSection
     Friend WithEvents Group1 As Telerik.Reporting.Group
     Friend WithEvents GroupFooterSection1 As Telerik.Reporting.GroupFooterSection
     Friend WithEvents GroupHeaderSection1 As Telerik.Reporting.GroupHeaderSection
     Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
     Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
     Friend WithEvents txtChartAvg As Telerik.Reporting.TextBox
     Friend WithEvents txtEnterpriseAvg As Telerik.Reporting.TextBox
     Friend WithEvents Chart1 As Telerik.Reporting.Chart
End Class