Partial Class BmCopeDataReport_BoilersSubReport

     'NOTE: The following procedure is required by the Telerik Reporting Designer
     'It can be modified using the Telerik Reporting Designer.  
     'Do not modify it using the code editor.
     Private Sub InitializeComponent()
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Me.GroupFooterSection1 = New Telerik.Reporting.GroupFooterSection()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.GroupHeaderSection1 = New Telerik.Reporting.GroupHeaderSection()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'GroupFooterSection1
        '
        Me.GroupFooterSection1.Bindings.Add(New Telerik.Reporting.Binding("Visible", "=IIF(Count(1)=0,true,false)"))
        Me.GroupFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R)
        Me.GroupFooterSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox16})
        Me.GroupFooterSection1.Name = "GroupFooterSection1"
        Me.GroupFooterSection1.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.GroupFooterSection1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.GroupFooterSection1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.GroupFooterSection1.Style.Visible = True
        '
        'TextBox16
        '
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.000078678232966922224R))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.9499998092651367R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
        Me.TextBox16.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox16.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox16.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox16.Style.Font.Bold = False
        Me.TextBox16.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox16.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox16.Value = "= IIF(Count(1)=0,""No Boilers"","""")"
        '
        'GroupHeaderSection1
        '
        Me.GroupHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.23999999463558197R)
        Me.GroupHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox8, Me.TextBox13, Me.TextBox12, Me.TextBox11, Me.TextBox10, Me.TextBox9, Me.TextBox14, Me.TextBox15})
        Me.GroupHeaderSection1.Name = "GroupHeaderSection1"
        '
        'TextBox8
        '
        Me.TextBox8.CanGrow = False
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0999211072921753R), Telerik.Reporting.Drawing.Unit.Inch(0.25821542739868164R))
        Me.TextBox8.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.TextBox8.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox8.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox8.Style.Font.Bold = True
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox8.Style.Font.Underline = False
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox8.Value = "Manufacturer"
        '
        'TextBox13
        '
        Me.TextBox13.CanGrow = False
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.3999605178833008R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.70000046491622925R), Telerik.Reporting.Drawing.Unit.Inch(0.25821542739868164R))
        Me.TextBox13.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.TextBox13.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox13.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox13.Style.Font.Bold = True
        Me.TextBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox13.Style.Font.Underline = False
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox13.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox13.Value = "Rental " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Available"
        '
        'TextBox12
        '
        Me.TextBox12.CanGrow = False
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.5999617576599121R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.80000019073486328R), Telerik.Reporting.Drawing.Unit.Inch(0.25821542739868164R))
        Me.TextBox12.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.TextBox12.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox12.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox12.Style.Font.Bold = True
        Me.TextBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox12.Style.Font.Underline = False
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox12.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox12.Value = "Fuel"
        '
        'TextBox11
        '
        Me.TextBox11.CanGrow = False
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.7999608516693115R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.80000019073486328R), Telerik.Reporting.Drawing.Unit.Inch(0.25821542739868164R))
        Me.TextBox11.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.TextBox11.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox11.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox11.Style.Font.Bold = True
        Me.TextBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox11.Style.Font.Underline = False
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox11.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox11.Value = "Pressure"
        '
        'TextBox10
        '
        Me.TextBox10.CanGrow = False
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.899960994720459R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89999991655349731R), Telerik.Reporting.Drawing.Unit.Inch(0.25821542739868164R))
        Me.TextBox10.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.TextBox10.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox10.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox10.Style.Font.Bold = True
        Me.TextBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox10.Style.Font.Underline = False
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox10.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox10.Value = "Capacity " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(lbs/hr or TPH)"
        '
        'TextBox9
        '
        Me.TextBox9.CanGrow = False
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.0999606847763062R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.79992085695266724R), Telerik.Reporting.Drawing.Unit.Inch(0.25821542739868164R))
        Me.TextBox9.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.TextBox9.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox9.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox9.Style.Font.Bold = True
        Me.TextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox9.Style.Font.Underline = False
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox9.Value = "Type"
        '
        'TextBox14
        '
        Me.TextBox14.CanGrow = False
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.0999608039855957R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8499996662139893R), Telerik.Reporting.Drawing.Unit.Inch(0.25821542739868164R))
        Me.TextBox14.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.TextBox14.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox14.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox14.Style.Font.Bold = True
        Me.TextBox14.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox14.Style.Font.Underline = False
        Me.TextBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox14.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox14.Value = "Comments"
        '
        'TextBox15
        '
        Me.TextBox15.CanGrow = False
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.8999606370925903R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.99992150068283081R), Telerik.Reporting.Drawing.Unit.Inch(0.25821542739868164R))
        Me.TextBox15.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.TextBox15.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox15.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox15.Style.Font.Bold = True
        Me.TextBox15.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox15.Style.Font.Underline = False
        Me.TextBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox15.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox15.Value = "Service"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.15003927052021027R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.TextBox5, Me.TextBox6, Me.TextBox7, Me.TextBox17, Me.TextBox4})
        Me.detail.Name = "detail"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = False
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.000000079472862068996619R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0998817682266235R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
        Me.TextBox1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox1.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox1.Style.Font.Bold = False
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox1.Value = "=Manufacturer"
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = False
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.0999606847763062R), Telerik.Reporting.Drawing.Unit.Inch(0.000000079472862068996619R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.79992121458053589R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
        Me.TextBox2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox2.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox2.Style.Font.Bold = False
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox2.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox2.Value = "=Type"
        '
        'TextBox3
        '
        Me.TextBox3.CanGrow = True
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.899960994720459R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89999991655349731R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
        Me.TextBox3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox3.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox3.Style.Font.Bold = False
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox3.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox3.Value = "=Capacity"
        '
        'TextBox5
        '
        Me.TextBox5.CanGrow = False
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.5999617576599121R), Telerik.Reporting.Drawing.Unit.Inch(0.000039259593904716894R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.80000019073486328R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
        Me.TextBox5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox5.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox5.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox5.Style.Font.Bold = False
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox5.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox5.Value = "=Fuel"
        '
        'TextBox6
        '
        Me.TextBox6.CanGrow = False
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.4000406265258789R), Telerik.Reporting.Drawing.Unit.Inch(0.000039259593904716894R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69992095232009888R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
        Me.TextBox6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox6.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox6.Style.Font.Bold = False
        Me.TextBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox6.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox6.Value = "=RentalAvailable"
        '
        'TextBox7
        '
        Me.TextBox7.CanGrow = False
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.1000404357910156R), Telerik.Reporting.Drawing.Unit.Inch(0.000039259593904716894R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8499202728271484R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
        Me.TextBox7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox7.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox7.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox7.Style.Font.Bold = False
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox7.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox7.Value = "=Comments"
        '
        'TextBox17
        '
        Me.TextBox17.CanGrow = False
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.8999606370925903R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
        Me.TextBox17.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox17.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox17.Style.Font.Bold = False
        Me.TextBox17.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox17.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.TextBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox17.Value = "=Service"
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = False
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.7999608516693115R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.80000019073486328R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
        Me.TextBox4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox4.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox4.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox4.Style.Font.Bold = False
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox4.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox4.Value = "=Pressure"
        '
        'BmCopeDataReport_BoilersSubReport
        '
        Me.Filters.Add(New Telerik.Reporting.Filter("=[FileNo]", Telerik.Reporting.FilterOperator.Equal, "=Parameters.FileNo.Value"))
        Group1.GroupFooter = Me.GroupFooterSection1
        Group1.GroupHeader = Me.GroupHeaderSection1
        Group1.Name = "Group1"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.GroupHeaderSection1, Me.GroupFooterSection1, Me.detail})
        Me.Name = "BmCopeDataReport_Boiler"
        Me.PageSettings.ColumnCount = 1
        Me.PageSettings.ContinuousPaper = False
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.25R), Telerik.Reporting.Drawing.Unit.Inch(0.25R), Telerik.Reporting.Drawing.Unit.Inch(0.25R), Telerik.Reporting.Drawing.Unit.Inch(0.25R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        ReportParameter1.Name = "FileNo"
        ReportParameter1.Visible = True
        Me.ReportParameters.Add(ReportParameter1)
        Me.Style.BackgroundColor = System.Drawing.Color.White
        Me.UnitOfMeasure = Telerik.Reporting.Drawing.UnitType.Pixel
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(7.9499998092651367R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
     Friend WithEvents detail As Telerik.Reporting.DetailSection
     Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
     Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
     Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
     Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
     Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
     Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
     Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
     Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
     Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
     Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
     Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
     Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
     Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
     Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
     Friend WithEvents Group1 As Telerik.Reporting.Group
     Friend WithEvents GroupFooterSection1 As Telerik.Reporting.GroupFooterSection
     Friend WithEvents GroupHeaderSection1 As Telerik.Reporting.GroupHeaderSection
     Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
     Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
     Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
End Class