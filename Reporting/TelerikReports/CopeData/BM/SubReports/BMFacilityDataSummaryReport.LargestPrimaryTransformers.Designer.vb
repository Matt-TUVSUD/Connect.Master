Partial Class BoilerFacilityDataSummary_LargestPrimaryTransformers

     'NOTE: The following procedure is required by the Telerik Reporting Designer
     'It can be modified using the Telerik Reporting Designer.  
     'Do not modify it using the code editor.
     Private Sub InitializeComponent()
          Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
          Me.detail = New Telerik.Reporting.DetailSection()
          Me.TextBox1 = New Telerik.Reporting.TextBox()
          Me.TextBox2 = New Telerik.Reporting.TextBox()
          Me.TextBox3 = New Telerik.Reporting.TextBox()
          Me.TextBox4 = New Telerik.Reporting.TextBox()
          Me.TextBox17 = New Telerik.Reporting.TextBox()
          Me.TextBox8 = New Telerik.Reporting.TextBox()
          Me.TextBox9 = New Telerik.Reporting.TextBox()
          Me.TextBox10 = New Telerik.Reporting.TextBox()
          Me.TextBox11 = New Telerik.Reporting.TextBox()
          Me.Group1 = New Telerik.Reporting.Group()
          Me.GroupFooterSection1 = New Telerik.Reporting.GroupFooterSection()
          Me.TextBox16 = New Telerik.Reporting.TextBox()
          Me.GroupHeaderSection1 = New Telerik.Reporting.GroupHeaderSection()
          Me.TextBox15 = New Telerik.Reporting.TextBox()
          CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
          '
          'detail
          '
        Me.PageSettings.ColumnCount = 1
          Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.15000008046627045R)
          Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.TextBox17})
          Me.detail.Name = "detail"
          '
          'TextBox1
          '
          Me.TextBox1.CanGrow = False
          Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.000000079472862068996619R))
          Me.TextBox1.Name = "TextBox1"
          Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0998817682266235R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
          Me.TextBox1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
          Me.TextBox1.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
          Me.TextBox1.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
          Me.TextBox1.Style.Font.Bold = False
          Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
          Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
          Me.TextBox1.Value = "=Manufacturer"
          '
          'TextBox2
          '
          Me.TextBox2.CanGrow = False
          Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.0999606847763062R), Telerik.Reporting.Drawing.Unit.Inch(0.000000079472862068996619R))
          Me.TextBox2.Name = "TextBox2"
          Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.79992121458053589R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
          Me.TextBox2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
          Me.TextBox2.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
          Me.TextBox2.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
          Me.TextBox2.Style.Font.Bold = False
          Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
          Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
          Me.TextBox2.Value = "=Year"
          '
          'TextBox3
          '
          Me.TextBox3.CanGrow = True
          Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.1000001430511475R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
          Me.TextBox3.Name = "TextBox3"
          Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.900000274181366R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
          Me.TextBox3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
          Me.TextBox3.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
          Me.TextBox3.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
          Me.TextBox3.Style.Font.Bold = False
          Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
          Me.TextBox3.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(3.0R)
          Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
          Me.TextBox3.Value = "=KVA"
          '
          'TextBox4
          '
          Me.TextBox4.CanGrow = False
          Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.0000791549682617R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
          Me.TextBox4.Name = "TextBox4"
          Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0000003576278687R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
          Me.TextBox4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
          Me.TextBox4.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
          Me.TextBox4.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
          Me.TextBox4.Style.Font.Bold = False
          Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
          Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
          Me.TextBox4.Value = "=Type"
          '
          'TextBox17
          '
          Me.TextBox17.CanGrow = False
          Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.8999606370925903R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
          Me.TextBox17.Name = "TextBox17"
          Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1999608278274536R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
          Me.TextBox17.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
          Me.TextBox17.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
          Me.TextBox17.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
          Me.TextBox17.Style.Font.Bold = False
          Me.TextBox17.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
          Me.TextBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
          Me.TextBox17.Value = "=PrimSecVoltage"
          '
          'TextBox8
          '
          Me.TextBox8.CanGrow = False
          Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
          Me.TextBox8.Name = "TextBox8"
          Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0999211072921753R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
          Me.TextBox8.Style.BackgroundColor = System.Drawing.Color.Silver
          Me.TextBox8.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
          Me.TextBox8.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
          Me.TextBox8.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
          Me.TextBox8.Style.Font.Bold = False
          Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
          Me.TextBox8.Style.Font.Underline = False
          Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
          Me.TextBox8.Value = "Manufacturer"
          '
          'TextBox9
          '
          Me.TextBox9.CanGrow = False
          Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.100078821182251R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
          Me.TextBox9.Name = "TextBox9"
          Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.79980295896530151R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
          Me.TextBox9.Style.BackgroundColor = System.Drawing.Color.Silver
          Me.TextBox9.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
          Me.TextBox9.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
          Me.TextBox9.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
          Me.TextBox9.Style.Font.Bold = False
          Me.TextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
          Me.TextBox9.Style.Font.Underline = False
          Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
          Me.TextBox9.Value = "Year"
          '
          'TextBox10
          '
          Me.TextBox10.CanGrow = False
          Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.1000001430511475R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
          Me.TextBox10.Name = "TextBox10"
          Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.900000274181366R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
          Me.TextBox10.Style.BackgroundColor = System.Drawing.Color.Silver
          Me.TextBox10.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
          Me.TextBox10.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
          Me.TextBox10.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
          Me.TextBox10.Style.Font.Bold = False
          Me.TextBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
          Me.TextBox10.Style.Font.Underline = False
          Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
          Me.TextBox10.Value = "KVA"
          '
          'TextBox11
          '
          Me.TextBox11.CanGrow = False
          Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.0000791549682617R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
          Me.TextBox11.Name = "TextBox11"
          Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0000003576278687R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
          Me.TextBox11.Style.BackgroundColor = System.Drawing.Color.Silver
          Me.TextBox11.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
          Me.TextBox11.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
          Me.TextBox11.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
          Me.TextBox11.Style.Font.Bold = False
          Me.TextBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
          Me.TextBox11.Style.Font.Underline = False
          Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
          Me.TextBox11.Value = "Type"
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
          Me.GroupFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R)
          Me.GroupFooterSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox16})
          Me.GroupFooterSection1.Name = "GroupFooterSection1"
          Me.GroupFooterSection1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
          Me.GroupFooterSection1.Style.Visible = True
          '
          'TextBox16
          '
          Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000039378803194267675R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
          Me.TextBox16.Name = "TextBox16"
          Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.0000400543212891R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
          Me.TextBox16.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
          Me.TextBox16.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
          Me.TextBox16.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
          Me.TextBox16.Style.Font.Bold = False
          Me.TextBox16.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
          Me.TextBox16.Value = "= IIF(Count(1)=0,""No Primary Transformers"","""")"
          '
          'GroupHeaderSection1
          '
          Me.GroupHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R)
          Me.GroupHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox8, Me.TextBox11, Me.TextBox10, Me.TextBox9, Me.TextBox15})
          Me.GroupHeaderSection1.Name = "GroupHeaderSection1"
          '
          'TextBox15
          '
          Me.TextBox15.CanGrow = False
          Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.8999606370925903R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
          Me.TextBox15.Name = "TextBox15"
          Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1998428106307983R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
          Me.TextBox15.Style.BackgroundColor = System.Drawing.Color.Silver
          Me.TextBox15.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
          Me.TextBox15.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
          Me.TextBox15.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
          Me.TextBox15.Style.Font.Bold = False
          Me.TextBox15.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
          Me.TextBox15.Style.Font.Underline = False
          Me.TextBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
          Me.TextBox15.Value = "Prim/Sec Voltage"
          '
          'BoilerFacilityDataSummary_LargestPrimaryTransformers
          '
          Me.Filters.AddRange(New Telerik.Reporting.Filter() {New Telerik.Reporting.Filter(Nothing, Telerik.Reporting.FilterOperator.TopN, "=1"), New Telerik.Reporting.Filter("=FileNo", Telerik.Reporting.FilterOperator.Equal, "=Parameters.FileNo.Value")})
          Me.Groups.AddRange(New Telerik.Reporting.Group() {Me.Group1})
          Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.GroupHeaderSection1, Me.GroupFooterSection1, Me.detail})
          Me.Name = "BmCopeDataReport_PrimaryTransformers"
          Me.PageSettings.Landscape = True
          Me.PageSettings.Margins.Bottom = Telerik.Reporting.Drawing.Unit.Inch(0.25R)
          Me.PageSettings.Margins.Left = Telerik.Reporting.Drawing.Unit.Inch(0.25R)
          Me.PageSettings.Margins.Right = Telerik.Reporting.Drawing.Unit.Inch(0.25R)
          Me.PageSettings.Margins.Top = Telerik.Reporting.Drawing.Unit.Inch(0.25R)
          Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
          ReportParameter1.Name = "FileNo"
          Me.ReportParameters.Add(ReportParameter1)
          Me.Style.BackgroundColor = System.Drawing.Color.White
          Me.UnitOfMeasure = Telerik.Reporting.Drawing.UnitType.Pixel
          Me.Width = Telerik.Reporting.Drawing.Unit.Inch(5.00007963180542R)
          CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

     End Sub
     Friend WithEvents detail As Telerik.Reporting.DetailSection
     Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
     Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
     Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
     Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
     Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
     Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
     Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
     Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
     Friend WithEvents Group1 As Telerik.Reporting.Group
     Friend WithEvents GroupFooterSection1 As Telerik.Reporting.GroupFooterSection
     Friend WithEvents GroupHeaderSection1 As Telerik.Reporting.GroupHeaderSection
     Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
     Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
     Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
End Class