Partial Class TelerikSample01
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TelerikSample01))
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.GrcLogo = New Telerik.Reporting.PictureBox()
        Me.txtStandardHeader = New Telerik.Reporting.HtmlTextBox()
        Me.HtmlTextBox1 = New Telerik.Reporting.HtmlTextBox()
        Me.Panel1 = New Telerik.Reporting.Panel()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.Panel2 = New Telerik.Reporting.Panel()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.Panel3 = New Telerik.Reporting.Panel()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.Panel4 = New Telerik.Reporting.Panel()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.Panel5 = New Telerik.Reporting.Panel()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.Graph1 = New Telerik.Reporting.Graph()
        Me.Graph2 = New Telerik.Reporting.Graph()
        Me.Graph3 = New Telerik.Reporting.Graph()
        Me.pageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(1.3020439147949219R)
        Me.pageHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.GrcLogo, Me.txtStandardHeader, Me.HtmlTextBox1, Me.Panel1, Me.Panel2, Me.Panel3, Me.Panel4})
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        '
        'GrcLogo
        '
        Me.GrcLogo.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926R), Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926R))
        Me.GrcLogo.MimeType = "image/gif"
        Me.GrcLogo.Name = "GrcLogo"
        Me.GrcLogo.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.7708332538604736R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.GrcLogo.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional
        Me.GrcLogo.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.GrcLogo.Value = CType(resources.GetObject("GrcLogo.Value"), Object)
        '
        'txtStandardHeader
        '
        Me.txtStandardHeader.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.7008864879608154R), Telerik.Reporting.Drawing.Unit.Inch(0.049921352416276932R))
        Me.txtStandardHeader.Name = "txtStandardHeader"
        Me.txtStandardHeader.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.6805243492126465R), Telerik.Reporting.Drawing.Unit.Inch(0.25R))
        Me.txtStandardHeader.Style.BackgroundColor = System.Drawing.Color.White
        Me.txtStandardHeader.Style.Color = System.Drawing.Color.Black
        Me.txtStandardHeader.Style.Font.Bold = False
        Me.txtStandardHeader.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.txtStandardHeader.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.txtStandardHeader.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtStandardHeader.Value = "Cargill Incorporated"
        '
        'HtmlTextBox1
        '
        Me.HtmlTextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.7008864879608154R), Telerik.Reporting.Drawing.Unit.Inch(0.30000004172325134R))
        Me.HtmlTextBox1.Name = "HtmlTextBox1"
        Me.HtmlTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.6805243492126465R), Telerik.Reporting.Drawing.Unit.Inch(0.25R))
        Me.HtmlTextBox1.Style.BackgroundColor = System.Drawing.Color.White
        Me.HtmlTextBox1.Style.Color = System.Drawing.Color.Black
        Me.HtmlTextBox1.Style.Font.Bold = False
        Me.HtmlTextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.HtmlTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.HtmlTextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.HtmlTextBox1.Value = "Fire Facility Rating Trending Report"
        '
        'Panel1
        '
        Me.Panel1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox1, Me.TextBox5, Me.TextBox6, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.TextBox13, Me.TextBox14, Me.TextBox15, Me.TextBox10})
        Me.Panel1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929R))
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.3000006675720215R), Telerik.Reporting.Drawing.Unit.Inch(0.50204390287399292R))
        Me.Panel1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel1.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = False
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.039583366364240646R), Telerik.Reporting.Drawing.Unit.Inch(0.018750032410025597R))
        Me.TextBox1.Multiline = False
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.1628556251525879R), Telerik.Reporting.Drawing.Unit.Inch(0.13341283798217773R))
        Me.TextBox1.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.TextWrap = False
        Me.TextBox1.Value = "Location Details"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.039583366364240646R), Telerik.Reporting.Drawing.Unit.Inch(0.17299620807170868R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.49996057152748108R), Telerik.Reporting.Drawing.Unit.Inch(0.099960483610630035R))
        Me.TextBox5.Style.Font.Bold = True
        Me.TextBox5.Style.Font.Name = "Arial"
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.5R)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox5.Value = "File No."
        '
        'TextBox6
        '
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.70000004768371582R), Telerik.Reporting.Drawing.Unit.Inch(0.17299620807170868R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69996064901351929R), Telerik.Reporting.Drawing.Unit.Inch(0.099960483610630035R))
        Me.TextBox6.Style.Font.Bold = True
        Me.TextBox6.Style.Font.Name = "Arial"
        Me.TextBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.5R)
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox6.Value = "Client Loc. No."
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6000789403915405R), Telerik.Reporting.Drawing.Unit.Inch(0.27295669913291931R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.970833420753479R), Telerik.Reporting.Drawing.Unit.Inch(0.099960483610630035R))
        Me.TextBox7.Style.Font.Bold = True
        Me.TextBox7.Style.Font.Name = "Arial"
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.5R)
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox7.Style.Visible = False
        Me.TextBox7.Value = "City"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.5709912776947021R), Telerik.Reporting.Drawing.Unit.Inch(0.27295669913291931R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.53950464725494385R), Telerik.Reporting.Drawing.Unit.Inch(0.099960483610630035R))
        Me.TextBox8.Style.Font.Bold = True
        Me.TextBox8.Style.Font.Name = "Arial"
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.5R)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox8.Style.Visible = False
        Me.TextBox8.Value = "St/Pr"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.1105747222900391R), Telerik.Reporting.Drawing.Unit.Inch(0.27295669913291931R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0918642282485962R), Telerik.Reporting.Drawing.Unit.Inch(0.099960483610630035R))
        Me.TextBox9.Style.Font.Bold = True
        Me.TextBox9.Style.Font.Name = "Arial"
        Me.TextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.5R)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox9.Style.Visible = False
        Me.TextBox9.Value = "Country"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.039583366364240646R), Telerik.Reporting.Drawing.Unit.Inch(0.27295669913291931R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5604166984558105R), Telerik.Reporting.Drawing.Unit.Inch(0.099960483610630035R))
        Me.TextBox13.Style.Font.Bold = True
        Me.TextBox13.Style.Font.Name = "Arial"
        Me.TextBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.5R)
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox13.Value = "Address"
        '
        'TextBox14
        '
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.2105743885040283R), Telerik.Reporting.Drawing.Unit.Inch(0.37291717529296875R))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.8999212384223938R), Telerik.Reporting.Drawing.Unit.Inch(0.099960483610630035R))
        Me.TextBox14.Style.Font.Bold = True
        Me.TextBox14.Style.Font.Name = "Arial"
        Me.TextBox14.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.5R)
        Me.TextBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox14.Value = "Facility"
        '
        'TextBox15
        '
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.039583366364240646R), Telerik.Reporting.Drawing.Unit.Inch(0.37291717529296875R))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.66041666269302368R), Telerik.Reporting.Drawing.Unit.Inch(0.099960483610630035R))
        Me.TextBox15.Style.Font.Bold = True
        Me.TextBox15.Style.Font.Name = "Arial"
        Me.TextBox15.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.5R)
        Me.TextBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox15.Value = "Division"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.852280855178833R), Telerik.Reporting.Drawing.Unit.Inch(0.17299620807170868R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.35015803575515747R), Telerik.Reporting.Drawing.Unit.Inch(0.099960483610630035R))
        Me.TextBox10.Style.Font.Bold = True
        Me.TextBox10.Style.Font.Name = "Arial"
        Me.TextBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.5R)
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox10.Value = "TIV"
        '
        'Panel2
        '
        Me.Panel2.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox2})
        Me.Panel2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.3000001907348633R), Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929R))
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0552878379821777R), Telerik.Reporting.Drawing.Unit.Inch(0.5R))
        Me.Panel2.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Panel2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel2.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099960647523403168R), Telerik.Reporting.Drawing.Unit.Inch(0.1434367448091507R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8407454490661621R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox2.Style.Color = System.Drawing.Color.White
        Me.TextBox2.Style.Font.Bold = True
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox2.Value = "Active Score Chart"
        '
        'Panel3
        '
        Me.Panel3.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox3})
        Me.Panel3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.355288028717041R), Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929R))
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0552878379821777R), Telerik.Reporting.Drawing.Unit.Inch(0.5R))
        Me.Panel3.Style.BackgroundColor = System.Drawing.Color.Red
        Me.Panel3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel3.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        '
        'TextBox3
        '
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R), Telerik.Reporting.Drawing.Unit.Inch(0.1434367448091507R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9406651258468628R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox3.Style.Font.Bold = True
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox3.Value = "Passive Score Chart"
        '
        'Panel4
        '
        Me.Panel4.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox4})
        Me.Panel4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.4105758666992187R), Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929R))
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0552878379821777R), Telerik.Reporting.Drawing.Unit.Inch(0.5R))
        Me.Panel4.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel4.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        '
        'TextBox4
        '
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.1434367448091507R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.881407618522644R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox4.Style.Color = System.Drawing.Color.White
        Me.TextBox4.Style.Font.Bold = True
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox4.Value = "Total Facility Score Chart"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.5791667103767395R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel5, Me.Graph1, Me.Graph2, Me.Graph3})
        Me.detail.Name = "detail"
        '
        'Panel5
        '
        Me.Panel5.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox22, Me.TextBox12, Me.TextBox16, Me.TextBox17, Me.TextBox18, Me.TextBox19, Me.TextBox20, Me.TextBox21, Me.TextBox11})
        Me.Panel5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.039583366364240646R))
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.3000001907348633R), Telerik.Reporting.Drawing.Unit.Inch(0.50621050596237183R))
        Me.Panel5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel5.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        '
        'TextBox22
        '
        Me.TextBox22.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.039583366364240646R), Telerik.Reporting.Drawing.Unit.Inch(0.10208336263895035R))
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.49996057152748108R), Telerik.Reporting.Drawing.Unit.Inch(0.099960483610630035R))
        Me.TextBox22.Style.Font.Bold = True
        Me.TextBox22.Style.Font.Name = "Arial"
        Me.TextBox22.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.5R)
        Me.TextBox22.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox22.Value = "=FileNo"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.039583366364240646R), Telerik.Reporting.Drawing.Unit.Inch(0.30216202139854431R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0875000953674316R), Telerik.Reporting.Drawing.Unit.Inch(0.099960483610630035R))
        Me.TextBox12.Style.Font.Bold = True
        Me.TextBox12.Style.Font.Name = "Arial"
        Me.TextBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.5R)
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox12.TextWrap = False
        Me.TextBox12.Value = "=Division"
        '
        'TextBox16
        '
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.2105743885040283R), Telerik.Reporting.Drawing.Unit.Inch(0.30216202139854431R))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9521621465682983R), Telerik.Reporting.Drawing.Unit.Inch(0.099960483610630035R))
        Me.TextBox16.Style.Font.Bold = True
        Me.TextBox16.Style.Font.Name = "Arial"
        Me.TextBox16.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.5R)
        Me.TextBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox16.Value = ""
        '
        'TextBox17
        '
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.039583366364240646R), Telerik.Reporting.Drawing.Unit.Inch(0.20212268829345703R))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.0709125995635986R), Telerik.Reporting.Drawing.Unit.Inch(0.099960483610630035R))
        Me.TextBox17.Style.Font.Bold = True
        Me.TextBox17.Style.Font.Name = "Arial"
        Me.TextBox17.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.5R)
        Me.TextBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox17.Value = "{Address}, {City}, {State}  {Country}"
        '
        'TextBox18
        '
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.1105747222900391R), Telerik.Reporting.Drawing.Unit.Inch(0.20212268829345703R))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0918643474578857R), Telerik.Reporting.Drawing.Unit.Inch(0.099960483610630035R))
        Me.TextBox18.Style.Font.Bold = True
        Me.TextBox18.Style.Font.Name = "Arial"
        Me.TextBox18.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.5R)
        Me.TextBox18.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox18.Style.Visible = False
        Me.TextBox18.Value = "=Country"
        '
        'TextBox19
        '
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.5709912776947021R), Telerik.Reporting.Drawing.Unit.Inch(0.20212268829345703R))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.53950458765029907R), Telerik.Reporting.Drawing.Unit.Inch(0.099960483610630035R))
        Me.TextBox19.Style.Font.Bold = True
        Me.TextBox19.Style.Font.Name = "Arial"
        Me.TextBox19.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.5R)
        Me.TextBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox19.Style.Visible = False
        Me.TextBox19.Value = "=State"
        '
        'TextBox20
        '
        Me.TextBox20.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.2771623134613037R), Telerik.Reporting.Drawing.Unit.Inch(0.20212268829345703R))
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.29375007748603821R), Telerik.Reporting.Drawing.Unit.Inch(0.099960483610630035R))
        Me.TextBox20.Style.Font.Bold = True
        Me.TextBox20.Style.Font.Name = "Arial"
        Me.TextBox20.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.5R)
        Me.TextBox20.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox20.Style.Visible = False
        Me.TextBox20.Value = "=City"
        '
        'TextBox21
        '
        Me.TextBox21.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.53962260484695435R), Telerik.Reporting.Drawing.Unit.Inch(0.10208336263895035R))
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69996064901351929R), Telerik.Reporting.Drawing.Unit.Inch(0.099960483610630035R))
        Me.TextBox21.Style.Font.Bold = True
        Me.TextBox21.Style.Font.Name = "Arial"
        Me.TextBox21.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.5R)
        Me.TextBox21.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox21.Value = "=ClientLocNo"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.8106143474578857R), Telerik.Reporting.Drawing.Unit.Inch(0.10208336263895035R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.40004026889801025R), Telerik.Reporting.Drawing.Unit.Inch(0.099960483610630035R))
        Me.TextBox11.Style.Font.Bold = True
        Me.TextBox11.Style.Font.Name = "Arial"
        Me.TextBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.5R)
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox11.Value = "=tiv"
        '
        'Graph1
        '
        Me.Graph1.Legend.Style.LineColor = System.Drawing.Color.LightGray
        Me.Graph1.Legend.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0.0R)
        Me.Graph1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.300079345703125R), Telerik.Reporting.Drawing.Unit.Inch(0.039583522826433182R))
        Me.Graph1.Name = "Graph1"
        Me.Graph1.PlotAreaStyle.LineColor = System.Drawing.Color.LightSeaGreen
        Me.Graph1.PlotAreaStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0.0R)
        Me.Graph1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0552878379821777R), Telerik.Reporting.Drawing.Unit.Inch(0.5062103271484375R))
        '
        'Graph2
        '
        Me.Graph2.Legend.Style.LineColor = System.Drawing.Color.LightGray
        Me.Graph2.Legend.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0.0R)
        Me.Graph2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.3553671836853027R), Telerik.Reporting.Drawing.Unit.Inch(0.039583522826433182R))
        Me.Graph2.Name = "Graph2"
        Me.Graph2.PlotAreaStyle.LineColor = System.Drawing.Color.LightBlue
        Me.Graph2.PlotAreaStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0.0R)
        Me.Graph2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0552878379821777R), Telerik.Reporting.Drawing.Unit.Inch(0.5062103271484375R))
        '
        'Graph3
        '
        Me.Graph3.Legend.Style.LineColor = System.Drawing.Color.LightGray
        Me.Graph3.Legend.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0.0R)
        Me.Graph3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.41065502166748R), Telerik.Reporting.Drawing.Unit.Inch(0.039583522826433182R))
        Me.Graph3.Name = "Graph3"
        Me.Graph3.PlotAreaStyle.LineColor = System.Drawing.Color.Lavender
        Me.Graph3.PlotAreaStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0.0R)
        Me.Graph3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0552878379821777R), Telerik.Reporting.Drawing.Unit.Inch(0.5062103271484375R))
        '
        'pageFooterSection1
        '
        Me.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.49999967217445374R)
        Me.pageFooterSection1.Name = "pageFooterSection1"
        '
        'TelerikSample01
        '
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pageHeaderSection1, Me.detail, Me.pageFooterSection1})
        Me.Name = "TelerikSample01"
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.25R), Telerik.Reporting.Drawing.Unit.Inch(0.25R), Telerik.Reporting.Drawing.Unit.Inch(0.25R), Telerik.Reporting.Drawing.Unit.Inch(0.25R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(10.5R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
    Friend WithEvents GrcLogo As Telerik.Reporting.PictureBox
    Friend WithEvents txtStandardHeader As Telerik.Reporting.HtmlTextBox
    Friend WithEvents HtmlTextBox1 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents Panel1 As Telerik.Reporting.Panel
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents Panel2 As Telerik.Reporting.Panel
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents Panel3 As Telerik.Reporting.Panel
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents Panel4 As Telerik.Reporting.Panel
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox22 As Telerik.Reporting.TextBox
    Friend WithEvents Panel5 As Telerik.Reporting.Panel
    Friend WithEvents Graph1 As Telerik.Reporting.Graph
    Friend WithEvents Graph2 As Telerik.Reporting.Graph
    Friend WithEvents Graph3 As Telerik.Reporting.Graph
End Class