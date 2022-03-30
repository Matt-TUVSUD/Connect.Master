Partial Class CopeRecommendationsSubReport_Portrait

     'NOTE: The following procedure is required by the Telerik Reporting Designer
     'It can be modified using the Telerik Reporting Designer.  
     'Do not modify it using the code editor.
     Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CopeRecommendationsSubReport_Portrait))
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter3 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter4 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Me.GroupFooterSection1 = New Telerik.Reporting.GroupFooterSection()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.GroupHeaderSection1 = New Telerik.Reporting.GroupHeaderSection()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.uxKeywordsLabel = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.RatingHeaderPanel = New Telerik.Reporting.Panel()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.uxKeywords = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.RatingDetailPanel = New Telerik.Reporting.Panel()
        Me.TextBox25 = New Telerik.Reporting.TextBox()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.1519651412963867R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
        Me.TextBox16.Style.Font.Bold = False
        Me.TextBox16.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox16.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox16.Value = "= IIF(Count(1)=0,""The are no "" + Parameters.PrimaryRecType.Value + "" recommendati" & _
    "ons"","""")"
        '
        'GroupHeaderSection1
        '
        Me.GroupHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.25R)
        Me.GroupHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox8, Me.uxKeywordsLabel, Me.TextBox9, Me.TextBox14, Me.TextBox15, Me.TextBox12, Me.TextBox13, Me.TextBox11, Me.RatingHeaderPanel})
        Me.GroupHeaderSection1.Name = "GroupHeaderSection1"
        '
        'TextBox8
        '
        Me.TextBox8.CanGrow = False
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.45416674017906189R), Telerik.Reporting.Drawing.Unit.Inch(0.24023839831352234R))
        Me.TextBox8.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.TextBox8.Style.Font.Bold = True
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox8.Style.Font.Underline = False
        Me.TextBox8.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(3.0R)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox8.Value = "Rec " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "No."
        '
        'uxKeywordsLabel
        '
        Me.uxKeywordsLabel.CanGrow = True
        Me.uxKeywordsLabel.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2308177947998047R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.uxKeywordsLabel.Name = "uxKeywordsLabel"
        Me.uxKeywordsLabel.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8520832061767578R), Telerik.Reporting.Drawing.Unit.Inch(0.24023839831352234R))
        Me.uxKeywordsLabel.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.uxKeywordsLabel.Style.Font.Bold = True
        Me.uxKeywordsLabel.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.uxKeywordsLabel.Style.Font.Underline = False
        Me.uxKeywordsLabel.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.uxKeywordsLabel.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.uxKeywordsLabel.Value = "Recommendation " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Key Words"
        '
        'TextBox9
        '
        Me.TextBox9.CanGrow = False
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.45436394214630127R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.81932616233825684R), Telerik.Reporting.Drawing.Unit.Inch(0.24023839831352234R))
        Me.TextBox9.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.TextBox9.Style.Font.Bold = True
        Me.TextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox9.Style.Font.Underline = False
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox9.Value = "Rec " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Type"
        '
        'TextBox14
        '
        Me.TextBox14.CanGrow = False
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.2281317710876465R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.77082699537277222R), Telerik.Reporting.Drawing.Unit.Inch(0.24023839831352234R))
        Me.TextBox14.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.TextBox14.Style.Font.Bold = True
        Me.TextBox14.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox14.Style.Font.Underline = False
        Me.TextBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox14.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox14.Value = "Rec Status"
        '
        'TextBox15
        '
        Me.TextBox15.CanGrow = False
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.2738871574401855R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.43842363357543945R), Telerik.Reporting.Drawing.Unit.Inch(0.24023839831352234R))
        Me.TextBox15.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.TextBox15.Style.Font.Bold = True
        Me.TextBox15.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox15.Style.Font.Underline = False
        Me.TextBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox15.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox15.Value = "Impact"
        '
        'TextBox12
        '
        Me.TextBox12.CanGrow = False
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.7972016334533691R), Telerik.Reporting.Drawing.Unit.Inch(0.000039339065551757813R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.71414309740066528R), Telerik.Reporting.Drawing.Unit.Inch(0.24023839831352234R))
        Me.TextBox12.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.TextBox12.Style.Font.Bold = True
        Me.TextBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox12.Style.Font.Underline = False
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox12.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox12.Value = "Completed LE"
        '
        'TextBox13
        '
        Me.TextBox13.CanGrow = False
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.5114235877990723R), Telerik.Reporting.Drawing.Unit.Inch(0.000039339065551757813R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.71414309740066528R), Telerik.Reporting.Drawing.Unit.Inch(0.24023839831352234R))
        Me.TextBox13.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.TextBox13.Style.Font.Bold = True
        Me.TextBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox13.Style.Font.Underline = False
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox13.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox13.Value = "Est. Cost To Complete"
        '
        'TextBox11
        '
        Me.TextBox11.CanGrow = False
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.082979679107666R), Telerik.Reporting.Drawing.Unit.Inch(0.000039339065551757813R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.71414309740066528R), Telerik.Reporting.Drawing.Unit.Inch(0.24023839831352234R))
        Me.TextBox11.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.TextBox11.Style.Font.Bold = True
        Me.TextBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox11.Style.Font.Underline = False
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox11.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox11.Value = "Current LE"
        '
        'RatingHeaderPanel
        '
        Me.RatingHeaderPanel.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox18, Me.TextBox19, Me.TextBox20, Me.TextBox21})
        Me.RatingHeaderPanel.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.7123895883560181R), Telerik.Reporting.Drawing.Unit.Inch(0.000039365557313431054R))
        Me.RatingHeaderPanel.Name = "RatingHeaderPanel"
        Me.RatingHeaderPanel.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5183495283126831R), Telerik.Reporting.Drawing.Unit.Inch(0.24023839831352234R))
        '
        'TextBox18
        '
        Me.TextBox18.CanGrow = False
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.37592363357543945R), Telerik.Reporting.Drawing.Unit.Inch(0.24019904434680939R))
        Me.TextBox18.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.TextBox18.Style.Font.Bold = True
        Me.TextBox18.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox18.Style.Font.Underline = False
        Me.TextBox18.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox18.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox18.Value = "Rec" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Priority"
        '
        'TextBox19
        '
        Me.TextBox19.CanGrow = False
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.37604182958602905R), Telerik.Reporting.Drawing.Unit.Inch(0.00001967946627701167R))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.37592363357543945R), Telerik.Reporting.Drawing.Unit.Inch(0.24019904434680939R))
        Me.TextBox19.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.TextBox19.Style.Font.Bold = True
        Me.TextBox19.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox19.Style.Font.Underline = False
        Me.TextBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox19.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox19.Value = "Category" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Points"
        '
        'TextBox20
        '
        Me.TextBox20.CanGrow = False
        Me.TextBox20.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.75204426050186157R), Telerik.Reporting.Drawing.Unit.Inch(0.00001967946627701167R))
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.37592363357543945R), Telerik.Reporting.Drawing.Unit.Inch(0.24019904434680939R))
        Me.TextBox20.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.TextBox20.Style.Font.Bold = True
        Me.TextBox20.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox20.Style.Font.Underline = False
        Me.TextBox20.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox20.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox20.Value = "Category" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Weight"
        '
        'TextBox21
        '
        Me.TextBox21.CanGrow = False
        Me.TextBox21.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.1280466318130493R), Telerik.Reporting.Drawing.Unit.Inch(0.00001967946627701167R))
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.39030292630195618R), Telerik.Reporting.Drawing.Unit.Inch(0.24019904434680939R))
        Me.TextBox21.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.TextBox21.Style.Font.Bold = True
        Me.TextBox21.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox21.Style.Font.Underline = False
        Me.TextBox21.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox21.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox21.Value = "Score" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Change"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.15000008046627045R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox1, Me.TextBox2, Me.uxKeywords, Me.TextBox4, Me.TextBox5, Me.TextBox6, Me.TextBox7, Me.TextBox17, Me.RatingDetailPanel})
        Me.detail.Name = "detail"
        Me.detail.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.detail.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.detail.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.detail.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(5.0R)
        Me.detail.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(5.0R)
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = False
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000039378803194267675R), Telerik.Reporting.Drawing.Unit.Inch(0.000000079472862068996619R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.45412728190422058R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
        Me.TextBox1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox1.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox1.Style.Font.Bold = False
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(3.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox1.Value = "=RecNo"
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = False
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.45424556732177734R), Telerik.Reporting.Drawing.Unit.Inch(0.000000079472862068996619R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.81944441795349121R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
        Me.TextBox2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox2.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox2.Style.Font.Bold = False
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox2.Value = "=SecondaryRecType"
        '
        'uxKeywords
        '
        Me.uxKeywords.CanGrow = True
        Me.uxKeywords.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2308177947998047R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.uxKeywords.Name = "uxKeywords"
        Me.uxKeywords.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8520832061767578R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
        Me.uxKeywords.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.uxKeywords.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.uxKeywords.Style.Font.Bold = False
        Me.uxKeywords.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.uxKeywords.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.uxKeywords.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.uxKeywords.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.uxKeywords.Value = "=RecKeyWords"
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = False
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.082979679107666R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.71414309740066528R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
        Me.TextBox4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox4.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox4.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox4.Style.Font.Bold = False
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
 
        Me.TextBox4.Value = "= GRC.Connect.Libraries.ReportLib.UtilReport.TelerikReport.ItemFunction.GetLossEs" & _
    "timateBeforeRangeValue(Cstr(LossExpectancyBefore),CInt(ExchangeRateGroupID),CInt(Pa" & _
    "rameters.Currency.Value), ReportItem)"
        '
        'TextBox5
        '
        Me.TextBox5.CanGrow = False
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.7972016334533691R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.71414309740066528R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
        Me.TextBox5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox5.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox5.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox5.Style.Font.Bold = False
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox5.Value = "= GRC.Connect.Libraries.ReportLib.UtilReport.TelerikReport.ItemFunction.GetLossEstimateAfterRangeValue(Cstr(LossExpectancyAfter),CInt(ExchangeRateGroupID),CInt(Parameters.Currency.Value), ReportItem)"
        '
        'TextBox6
        '
        Me.TextBox6.CanGrow = False
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.5114235877990723R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.71414309740066528R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
        Me.TextBox6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox6.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox6.Style.Font.Bold = False
        Me.TextBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox6.Value = "= GRC.Connect.Libraries.ReportLib.UtilReport.TelerikReport.ItemFunction.GetLossEstimateCostRangeValue(Cstr(CostToComplete),CInt(ExchangeRateGroupID),CInt(Parameters.Currency.Value), ReportItem)"
        '
        'TextBox7
        '
        Me.TextBox7.CanGrow = False
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.2282500267028809R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.77070873975753784R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
        Me.TextBox7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox7.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox7.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox7.Style.Font.Bold = False
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox7.Value = "=RecStatus"
        '
        'TextBox17
        '
        Me.TextBox17.CanGrow = False
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.2737689018249512R), Telerik.Reporting.Drawing.Unit.Inch(0.000000079472862068996619R))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.43854174017906189R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
        Me.TextBox17.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox17.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox17.Style.Font.Bold = False
        Me.TextBox17.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox17.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox17.Value = "=RecCategory"
        '
        'RatingDetailPanel
        '
        Me.RatingDetailPanel.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox25, Me.TextBox24, Me.TextBox23, Me.TextBox22})
        Me.RatingDetailPanel.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.7123895883560181R), Telerik.Reporting.Drawing.Unit.Inch(0.000000079472862068996619R))
        Me.RatingDetailPanel.Name = "RatingDetailPanel"
        Me.RatingDetailPanel.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5183495283126831R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
        Me.RatingDetailPanel.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        '
        'TextBox25
        '
        Me.TextBox25.CanGrow = False
        Me.TextBox25.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000019629796952358447R), Telerik.Reporting.Drawing.Unit.Inch(0.000000014901161193847656R))
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.37592363357543945R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
        Me.TextBox25.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.TextBox25.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox25.Style.Font.Bold = False
        Me.TextBox25.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox25.Style.Font.Underline = False
        Me.TextBox25.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox25.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox25.Value = "=RecPriority"
        '
        'TextBox24
        '
        Me.TextBox24.CanGrow = False
        Me.TextBox24.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.37602201104164124R), Telerik.Reporting.Drawing.Unit.Inch(-0.000000014901161193847656R))
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.37592363357543945R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
        Me.TextBox24.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.TextBox24.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox24.Style.Font.Bold = False
        Me.TextBox24.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox24.Style.Font.Underline = False
        Me.TextBox24.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox24.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox24.Value = "=RatingCatPts"
        '
        'TextBox23
        '
        Me.TextBox23.CanGrow = False
        Me.TextBox23.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.75202447175979614R), Telerik.Reporting.Drawing.Unit.Inch(-0.000000014901161193847656R))
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.37592363357543945R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
        Me.TextBox23.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.TextBox23.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox23.Style.Font.Bold = False
        Me.TextBox23.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox23.Style.Font.Underline = False
        Me.TextBox23.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox23.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox23.Value = "=RatingCatWeight"
        '
        'TextBox22
        '
        Me.TextBox22.CanGrow = False
        Me.TextBox22.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.1280268430709839R), Telerik.Reporting.Drawing.Unit.Inch(-0.000000014901161193847656R))
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.39030292630195618R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
        Me.TextBox22.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.TextBox22.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox22.Style.Font.Bold = False
        Me.TextBox22.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox22.Style.Font.Underline = False
        Me.TextBox22.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox22.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox22.Value = "=RatingScoreChange"
        '
        'CopeRecommendationsSubReport_Portrait
        '
        Me.Filters.Add(New Telerik.Reporting.Filter("=[PrimaryRecType]", Telerik.Reporting.FilterOperator.Equal, "=Parameters.PrimaryRecType.Value"))
        Me.Filters.Add(New Telerik.Reporting.Filter("=[FileNo]", Telerik.Reporting.FilterOperator.Equal, "=Parameters.FileNo.Value"))
        Group1.GroupFooter = Me.GroupFooterSection1
        Group1.GroupHeader = Me.GroupHeaderSection1
        Group1.Name = "Group1"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.GroupHeaderSection1, Me.GroupFooterSection1, Me.detail})
        Me.Name = "FireCopeSummaryRecommendations"
        Me.PageSettings.ColumnCount = 1
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.25R), Telerik.Reporting.Drawing.Unit.Inch(0.25R), Telerik.Reporting.Drawing.Unit.Inch(0.25R), Telerik.Reporting.Drawing.Unit.Inch(0.25R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        ReportParameter1.Name = "FileNo"
        ReportParameter1.Visible = True
        ReportParameter2.Name = "PrimaryRecType"
        ReportParameter3.AllowNull = True
        ReportParameter3.Name = "Currency"
        ReportParameter3.Type = Telerik.Reporting.ReportParameterType.[Integer]
        ReportParameter3.Value = ""
        ReportParameter3.Visible = True
        ReportParameter4.AllowNull = True
        ReportParameter4.Name = "Practice"
        Me.ReportParameters.Add(ReportParameter1)
        Me.ReportParameters.Add(ReportParameter2)
        Me.ReportParameters.Add(ReportParameter3)
        Me.ReportParameters.Add(ReportParameter4)
        Me.Style.BackgroundColor = System.Drawing.Color.White
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(7.9989585876464844R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents uxKeywords As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents uxKeywordsLabel As Telerik.Reporting.TextBox
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
    Friend WithEvents RatingHeaderPanel As Telerik.Reporting.Panel
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
    Friend WithEvents RatingDetailPanel As Telerik.Reporting.Panel
    Friend WithEvents TextBox25 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox24 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox23 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox22 As Telerik.Reporting.TextBox
End Class