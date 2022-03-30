Partial Class BmCopeDataReport_CriticalSparesSubReportLandscape

     'NOTE: The following procedure is required by the Telerik Reporting Designer
     'It can be modified using the Telerik Reporting Designer.  
     'Do not modify it using the code editor.
     Private Sub InitializeComponent()
          Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
          Me.detail = New Telerik.Reporting.DetailSection()
          Me.TextBox1 = New Telerik.Reporting.TextBox()
          Me.TextBox6 = New Telerik.Reporting.TextBox()
          Me.TextBox8 = New Telerik.Reporting.TextBox()
          Me.TextBox13 = New Telerik.Reporting.TextBox()
          Me.Group1 = New Telerik.Reporting.Group()
          Me.GroupFooterSection1 = New Telerik.Reporting.GroupFooterSection()
          Me.TextBox16 = New Telerik.Reporting.TextBox()
          Me.GroupHeaderSection1 = New Telerik.Reporting.GroupHeaderSection()
          CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
          '
          'detail
          '
        Me.PageSettings.ColumnCount = 1
          Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.15000008046627045R)
          Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox1, Me.TextBox6})
          Me.detail.Name = "detail"
          '
          'TextBox1
          '
          Me.TextBox1.CanGrow = False
          Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.000000079472862068996619R))
          Me.TextBox1.Name = "TextBox1"
          Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.80000019073486328R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
          Me.TextBox1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
          Me.TextBox1.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
          Me.TextBox1.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
          Me.TextBox1.Style.Font.Bold = False
          Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
          Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
          Me.TextBox1.Value = "= RowNumber()"
          '
          'TextBox6
          '
          Me.TextBox6.CanGrow = False
          Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.8000791072845459R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
          Me.TextBox6.Name = "TextBox6"
          Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(9.6499204635620117R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
          Me.TextBox6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
          Me.TextBox6.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
          Me.TextBox6.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
          Me.TextBox6.Style.Font.Bold = False
          Me.TextBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
          Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
          Me.TextBox6.Value = "=EPPMSDescription"
          '
          'TextBox8
          '
          Me.TextBox8.CanGrow = False
          Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
          Me.TextBox8.Name = "TextBox8"
          Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.800039529800415R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
          Me.TextBox8.Style.BackgroundColor = System.Drawing.Color.Silver
          Me.TextBox8.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
          Me.TextBox8.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
          Me.TextBox8.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
          Me.TextBox8.Style.Font.Bold = False
          Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
          Me.TextBox8.Style.Font.Underline = False
          Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
          Me.TextBox8.Value = "Item No."
          '
          'TextBox13
          '
          Me.TextBox13.CanGrow = False
          Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.80007785558700562R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
          Me.TextBox13.Name = "TextBox13"
          Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(9.6499214172363281R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
          Me.TextBox13.Style.BackgroundColor = System.Drawing.Color.Silver
          Me.TextBox13.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
          Me.TextBox13.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
          Me.TextBox13.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
          Me.TextBox13.Style.Font.Bold = False
          Me.TextBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
          Me.TextBox13.Style.Font.Underline = False
          Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
          Me.TextBox13.Value = "Description"
          '
          'Group1
          '
          Me.Group1.GroupFooter = Me.GroupFooterSection1
          Me.Group1.GroupHeader = Me.GroupHeaderSection1
          Me.Group1.Name = "Group1"
          '
          'GroupFooterSection1
          '
          Me.GroupFooterSection1.Bindings.Add(New Telerik.Reporting.Binding("Visible", "=IIF(Count(1)=0,true,false)"))
          Me.GroupFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R)
          Me.GroupFooterSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox16})
          Me.GroupFooterSection1.Name = "GroupFooterSection1"
          Me.GroupFooterSection1.Style.Visible = True
          '
          'TextBox16
          '
          Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
          Me.TextBox16.Name = "TextBox16"
          Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(10.44999885559082R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
          Me.TextBox16.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
          Me.TextBox16.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
          Me.TextBox16.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
          Me.TextBox16.Style.Font.Bold = False
          Me.TextBox16.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
          Me.TextBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
          Me.TextBox16.Value = "= IIF(Count(1)=0,""No Critical Spares"","""")"
          '
          'GroupHeaderSection1
          '
          Me.GroupHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R)
          Me.GroupHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox8, Me.TextBox13})
          Me.GroupHeaderSection1.Name = "GroupHeaderSection1"
          '
          'BmCopeDataReport_CriticalSparesSubReportLandscape
          '
          Me.Filters.AddRange(New Telerik.Reporting.Filter() {New Telerik.Reporting.Filter("=[FileNo]", Telerik.Reporting.FilterOperator.Equal, "=Parameters.FileNo.Value")})
          Me.Groups.AddRange(New Telerik.Reporting.Group() {Me.Group1})
          Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.GroupHeaderSection1, Me.GroupFooterSection1, Me.detail})
          Me.Name = "BmCopeDataReport_CriticalSpare"
          Me.PageSettings.Landscape = True
          Me.PageSettings.Margins.Bottom = Telerik.Reporting.Drawing.Unit.Inch(0.25R)
          Me.PageSettings.Margins.Left = Telerik.Reporting.Drawing.Unit.Inch(0.25R)
          Me.PageSettings.Margins.Right = Telerik.Reporting.Drawing.Unit.Inch(0.25R)
          Me.PageSettings.Margins.Top = Telerik.Reporting.Drawing.Unit.Inch(0.25R)
          Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
          ReportParameter1.Name = "FileNo"
          ReportParameter1.Visible = True
          Me.ReportParameters.Add(ReportParameter1)
          Me.Style.BackgroundColor = System.Drawing.Color.White
          Me.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
          Me.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
          Me.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
          Me.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
          Me.UnitOfMeasure = Telerik.Reporting.Drawing.UnitType.Pixel
          Me.Width = Telerik.Reporting.Drawing.Unit.Inch(10.449999809265137R)
          CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

     End Sub
     Friend WithEvents detail As Telerik.Reporting.DetailSection
     Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
     Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
     Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
     Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
     Friend WithEvents Group1 As Telerik.Reporting.Group
     Friend WithEvents GroupFooterSection1 As Telerik.Reporting.GroupFooterSection
     Friend WithEvents GroupHeaderSection1 As Telerik.Reporting.GroupHeaderSection
     Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
End Class