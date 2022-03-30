Partial Class PMPolicyValueSubReport

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.groupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.groupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.Panel1 = New Telerik.Reporting.Panel()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.uxFileNo = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.uxClientLocNo = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.uxClient = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.uxDivision = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.uxFacility = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.uxCustomAccess = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.uxAddress1 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.uxAddress2 = New Telerik.Reporting.TextBox()
        Me.TextBox27 = New Telerik.Reporting.TextBox()
        Me.uxAddress3 = New Telerik.Reporting.TextBox()
        Me.TextBox25 = New Telerik.Reporting.TextBox()
        Me.uxCity = New Telerik.Reporting.TextBox()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.uxStProv = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.uxZip = New Telerik.Reporting.TextBox()
        Me.TextBox28 = New Telerik.Reporting.TextBox()
        Me.uxCountry = New Telerik.Reporting.TextBox()
        Me.Panel2 = New Telerik.Reporting.Panel()
        Me.TextBox31 = New Telerik.Reporting.TextBox()
        Me.uxEffectiveDate = New Telerik.Reporting.TextBox()
        Me.TextBox33 = New Telerik.Reporting.TextBox()
        Me.uxCurrencyCode = New Telerik.Reporting.TextBox()
        Me.TextBox37 = New Telerik.Reporting.TextBox()
        Me.uxPDBldg = New Telerik.Reporting.TextBox()
        Me.TextBox35 = New Telerik.Reporting.TextBox()
        Me.uxBIProfit = New Telerik.Reporting.TextBox()
        Me.TextBox41 = New Telerik.Reporting.TextBox()
        Me.uxPDEquip = New Telerik.Reporting.TextBox()
        Me.TextBox39 = New Telerik.Reporting.TextBox()
        Me.uxBIWage = New Telerik.Reporting.TextBox()
        Me.TextBox49 = New Telerik.Reporting.TextBox()
        Me.uxPDStock = New Telerik.Reporting.TextBox()
        Me.TextBox47 = New Telerik.Reporting.TextBox()
        Me.uxBIMisc = New Telerik.Reporting.TextBox()
        Me.TextBox45 = New Telerik.Reporting.TextBox()
        Me.uxPDRawStock = New Telerik.Reporting.TextBox()
        Me.TextBox43 = New Telerik.Reporting.TextBox()
        Me.uxBIOther = New Telerik.Reporting.TextBox()
        Me.TextBox61 = New Telerik.Reporting.TextBox()
        Me.uxPDBldgRisk = New Telerik.Reporting.TextBox()
        Me.TextBox57 = New Telerik.Reporting.TextBox()
        Me.uxPDMisc = New Telerik.Reporting.TextBox()
        Me.TextBox55 = New Telerik.Reporting.TextBox()
        Me.uxBITotalLocalValue = New Telerik.Reporting.TextBox()
        Me.TextBox53 = New Telerik.Reporting.TextBox()
        Me.uxPDTotalLocalValue = New Telerik.Reporting.TextBox()
        Me.uxLocationPolicyHeadingPanel = New Telerik.Reporting.Panel()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'groupFooterSection
        '
        Me.groupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.1041666641831398R)
        Me.groupFooterSection.Name = "groupFooterSection"
        Me.groupFooterSection.Style.Visible = False
        '
        'groupHeaderSection
        '
        Me.groupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.25999999046325684R)
        Me.groupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox2, Me.TextBox3})
        Me.groupHeaderSection.Name = "groupHeaderSection"
        Me.groupHeaderSection.PageBreak = Telerik.Reporting.PageBreak.Before
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3687500953674316R), Telerik.Reporting.Drawing.Unit.Inch(0.25999999046325684R))
        Me.TextBox2.Style.Font.Bold = True
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11.0R)
        Me.TextBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom
        Me.TextBox2.Value = "Location Details"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.0999999046325684R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2000001668930054R), Telerik.Reporting.Drawing.Unit.Inch(0.25999999046325684R))
        Me.TextBox3.Style.Font.Bold = True
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11.0R)
        Me.TextBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom
        Me.TextBox3.Value = "Policy Values"
        '
        'detail
        '
        Me.detail.CanShrink = True
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(2.6049997806549072R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel1, Me.Panel2, Me.uxLocationPolicyHeadingPanel})
        Me.detail.Name = "detail"
        '
        'Panel1
        '
        Me.Panel1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox4, Me.uxFileNo, Me.TextBox7, Me.uxClientLocNo, Me.TextBox11, Me.uxClient, Me.TextBox9, Me.uxDivision, Me.TextBox19, Me.uxFacility, Me.TextBox17, Me.uxCustomAccess, Me.TextBox15, Me.uxAddress1, Me.TextBox13, Me.uxAddress2, Me.TextBox27, Me.uxAddress3, Me.TextBox25, Me.uxCity, Me.TextBox23, Me.uxStProv, Me.TextBox21, Me.uxZip, Me.TextBox28, Me.uxCountry})
        Me.Panel1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.26083335280418396R))
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.9000000953674316R), Telerik.Reporting.Drawing.Unit.Inch(2.2920832633972168R))
        Me.Panel1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel1.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.Panel1.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.Panel1.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        '
        'TextBox4
        '
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926R), Telerik.Reporting.Drawing.Unit.Inch(0.052500009536743164R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0299999713897705R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox4.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox4.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox4.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox4.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox4.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox4.Value = "File No.:"
        '
        'uxFileNo
        '
        Me.uxFileNo.Format = "{0}"
        Me.uxFileNo.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.2000001668930054R), Telerik.Reporting.Drawing.Unit.Inch(0.052500009536743164R))
        Me.uxFileNo.Name = "uxFileNo"
        Me.uxFileNo.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.uxFileNo.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.uxFileNo.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.uxFileNo.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.uxFileNo.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.uxFileNo.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.uxFileNo.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.uxFileNo.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.uxFileNo.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.uxFileNo.Value = "=FileNo"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926R), Telerik.Reporting.Drawing.Unit.Inch(0.23333334922790527R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0299999713897705R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox7.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox7.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox7.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox7.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox7.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox7.Value = "Client Loc. No.:"
        '
        'uxClientLocNo
        '
        Me.uxClientLocNo.Format = "{0}"
        Me.uxClientLocNo.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.2000001668930054R), Telerik.Reporting.Drawing.Unit.Inch(0.23333334922790527R))
        Me.uxClientLocNo.Name = "uxClientLocNo"
        Me.uxClientLocNo.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.uxClientLocNo.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.uxClientLocNo.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.uxClientLocNo.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.uxClientLocNo.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.uxClientLocNo.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.uxClientLocNo.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.uxClientLocNo.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.uxClientLocNo.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.uxClientLocNo.Value = "=ClientLocNo"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926R), Telerik.Reporting.Drawing.Unit.Inch(0.41416668891906738R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0299999713897705R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox11.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox11.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox11.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox11.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox11.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox11.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox11.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox11.Value = "Client:"
        '
        'uxClient
        '
        Me.uxClient.Format = "{0}"
        Me.uxClient.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.1999998092651367R), Telerik.Reporting.Drawing.Unit.Inch(0.41416668891906738R))
        Me.uxClient.Name = "uxClient"
        Me.uxClient.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6000006198883057R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.uxClient.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.uxClient.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.uxClient.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.uxClient.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.uxClient.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.uxClient.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.uxClient.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.uxClient.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.uxClient.Value = "=ClientName"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926R), Telerik.Reporting.Drawing.Unit.Inch(0.59500002861022949R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0299999713897705R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox9.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox9.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox9.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox9.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox9.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox9.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox9.Value = "Division:"
        '
        'uxDivision
        '
        Me.uxDivision.Format = "{0}"
        Me.uxDivision.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.1999998092651367R), Telerik.Reporting.Drawing.Unit.Inch(0.59500002861022949R))
        Me.uxDivision.Name = "uxDivision"
        Me.uxDivision.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6000006198883057R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.uxDivision.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.uxDivision.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.uxDivision.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.uxDivision.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.uxDivision.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.uxDivision.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.uxDivision.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.uxDivision.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.uxDivision.Value = "=Division"
        '
        'TextBox19
        '
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926R), Telerik.Reporting.Drawing.Unit.Inch(0.7758333683013916R))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0299999713897705R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox19.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox19.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox19.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox19.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox19.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox19.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox19.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox19.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox19.Value = "Facility:"
        '
        'uxFacility
        '
        Me.uxFacility.Format = "{0}"
        Me.uxFacility.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.2000001668930054R), Telerik.Reporting.Drawing.Unit.Inch(0.7758333683013916R))
        Me.uxFacility.Name = "uxFacility"
        Me.uxFacility.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6000006198883057R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.uxFacility.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.uxFacility.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.uxFacility.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.uxFacility.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.uxFacility.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.uxFacility.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.uxFacility.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.uxFacility.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.uxFacility.Value = "=Facility"
        '
        'TextBox17
        '
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926R), Telerik.Reporting.Drawing.Unit.Inch(0.95666670799255371R))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0299999713897705R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox17.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox17.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox17.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox17.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox17.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox17.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox17.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox17.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox17.Value = "Custom Access:"
        '
        'uxCustomAccess
        '
        Me.uxCustomAccess.Format = "{0}"
        Me.uxCustomAccess.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.2000001668930054R), Telerik.Reporting.Drawing.Unit.Inch(0.95666670799255371R))
        Me.uxCustomAccess.Name = "uxCustomAccess"
        Me.uxCustomAccess.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6000006198883057R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.uxCustomAccess.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.uxCustomAccess.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.uxCustomAccess.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.uxCustomAccess.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.uxCustomAccess.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.uxCustomAccess.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.uxCustomAccess.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.uxCustomAccess.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.uxCustomAccess.Value = "=CustomAccess"
        '
        'TextBox15
        '
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926R), Telerik.Reporting.Drawing.Unit.Inch(1.1375000476837158R))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0299999713897705R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox15.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox15.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox15.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox15.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox15.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox15.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox15.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox15.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox15.Value = "Address 1:"
        '
        'uxAddress1
        '
        Me.uxAddress1.Format = "{0}"
        Me.uxAddress1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.2000001668930054R), Telerik.Reporting.Drawing.Unit.Inch(1.1375000476837158R))
        Me.uxAddress1.Name = "uxAddress1"
        Me.uxAddress1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6000006198883057R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.uxAddress1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.uxAddress1.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.uxAddress1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.uxAddress1.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.uxAddress1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.uxAddress1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.uxAddress1.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.uxAddress1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.uxAddress1.Value = "=Address1"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926R), Telerik.Reporting.Drawing.Unit.Inch(1.3183332681655884R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0299999713897705R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox13.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox13.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox13.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox13.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox13.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox13.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox13.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox13.Value = "Address 2:"
        '
        'uxAddress2
        '
        Me.uxAddress2.Format = "{0}"
        Me.uxAddress2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.2000001668930054R), Telerik.Reporting.Drawing.Unit.Inch(1.3183332681655884R))
        Me.uxAddress2.Name = "uxAddress2"
        Me.uxAddress2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6000006198883057R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.uxAddress2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.uxAddress2.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.uxAddress2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.uxAddress2.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.uxAddress2.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.uxAddress2.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.uxAddress2.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.uxAddress2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.uxAddress2.Value = "=Address2"
        '
        'TextBox27
        '
        Me.TextBox27.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926R), Telerik.Reporting.Drawing.Unit.Inch(1.49916672706604R))
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0299999713897705R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox27.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox27.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox27.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox27.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox27.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox27.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox27.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox27.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox27.Value = "Address 3:"
        '
        'uxAddress3
        '
        Me.uxAddress3.Format = "{0}"
        Me.uxAddress3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.2000001668930054R), Telerik.Reporting.Drawing.Unit.Inch(1.49916672706604R))
        Me.uxAddress3.Name = "uxAddress3"
        Me.uxAddress3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6000006198883057R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.uxAddress3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.uxAddress3.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.uxAddress3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.uxAddress3.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.uxAddress3.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.uxAddress3.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.uxAddress3.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.uxAddress3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.uxAddress3.Value = "=Address3"
        '
        'TextBox25
        '
        Me.TextBox25.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926R), Telerik.Reporting.Drawing.Unit.Inch(1.6800000667572021R))
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0299999713897705R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox25.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox25.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox25.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox25.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox25.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox25.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox25.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox25.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox25.Value = "City:"
        '
        'uxCity
        '
        Me.uxCity.Format = "{0}"
        Me.uxCity.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.2000001668930054R), Telerik.Reporting.Drawing.Unit.Inch(1.6800000667572021R))
        Me.uxCity.Name = "uxCity"
        Me.uxCity.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.5999999046325684R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.uxCity.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.uxCity.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.uxCity.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.uxCity.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.uxCity.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.uxCity.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.uxCity.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.uxCity.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.uxCity.Value = "=City"
        '
        'TextBox23
        '
        Me.TextBox23.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926R), Telerik.Reporting.Drawing.Unit.Inch(1.8608334064483643R))
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0299999713897705R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox23.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox23.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox23.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox23.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox23.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox23.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox23.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox23.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox23.Value = "St/Prov.:"
        '
        'uxStProv
        '
        Me.uxStProv.Format = "{0}"
        Me.uxStProv.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.2000001668930054R), Telerik.Reporting.Drawing.Unit.Inch(1.8608332872390747R))
        Me.uxStProv.Name = "uxStProv"
        Me.uxStProv.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.99992150068283081R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.uxStProv.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.uxStProv.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.uxStProv.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.uxStProv.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.uxStProv.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.uxStProv.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.uxStProv.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.uxStProv.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.uxStProv.Value = "=StProv"
        '
        'TextBox21
        '
        Me.TextBox21.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926R), Telerik.Reporting.Drawing.Unit.Inch(2.0416667461395264R))
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0299999713897705R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox21.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox21.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox21.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox21.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox21.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox21.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox21.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox21.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox21.Value = "Country:"
        '
        'uxZip
        '
        Me.uxZip.Format = "{0}"
        Me.uxZip.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.8750789165496826R), Telerik.Reporting.Drawing.Unit.Inch(1.8608332872390747R))
        Me.uxZip.Name = "uxZip"
        Me.uxZip.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.92492139339447021R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.uxZip.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.uxZip.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.uxZip.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.uxZip.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.uxZip.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.uxZip.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.uxZip.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.uxZip.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.uxZip.Value = "=Zip"
        '
        'TextBox28
        '
        Me.TextBox28.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.2999999523162842R), Telerik.Reporting.Drawing.Unit.Inch(1.8608332872390747R))
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.49992117285728455R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox28.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox28.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox28.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox28.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox28.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox28.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox28.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox28.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox28.Value = "Zip:"
        '
        'uxCountry
        '
        Me.uxCountry.Format = "{0}"
        Me.uxCountry.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.1999996900558472R), Telerik.Reporting.Drawing.Unit.Inch(2.0416667461395264R))
        Me.uxCountry.Name = "uxCountry"
        Me.uxCountry.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6000001430511475R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.uxCountry.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.uxCountry.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.uxCountry.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.uxCountry.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.uxCountry.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.uxCountry.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.uxCountry.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.uxCountry.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.uxCountry.Value = "=Country"
        '
        'Panel2
        '
        Me.Panel2.CanShrink = False
        Me.Panel2.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox31, Me.uxEffectiveDate, Me.TextBox33, Me.uxCurrencyCode, Me.TextBox37, Me.uxPDBldg, Me.TextBox35, Me.uxBIProfit, Me.TextBox41, Me.uxPDEquip, Me.TextBox39, Me.uxBIWage, Me.TextBox49, Me.uxPDStock, Me.TextBox47, Me.uxBIMisc, Me.TextBox45, Me.uxPDRawStock, Me.TextBox43, Me.uxBIOther, Me.TextBox61, Me.uxPDBldgRisk, Me.TextBox57, Me.uxPDMisc, Me.TextBox55, Me.uxBITotalLocalValue, Me.TextBox53, Me.uxPDTotalLocalValue})
        Me.Panel2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.0999999046325684R), Telerik.Reporting.Drawing.Unit.Inch(0.26083335280418396R))
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.8999605178833008R), Telerik.Reporting.Drawing.Unit.Inch(2.2920832633972168R))
        Me.Panel2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel2.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.Panel2.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.Panel2.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        '
        'TextBox31
        '
        Me.TextBox31.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.093789421021938324R), Telerik.Reporting.Drawing.Unit.Inch(0.3000788688659668R))
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.82999998331069946R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox31.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox31.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox31.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox31.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox31.Value = "Eff. Date:"
        '
        'uxEffectiveDate
        '
        Me.uxEffectiveDate.Format = "{0:dd-MMM-yy}"
        Me.uxEffectiveDate.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.97504013776779175R), Telerik.Reporting.Drawing.Unit.Inch(0.3000788688659668R))
        Me.uxEffectiveDate.Name = "uxEffectiveDate"
        Me.uxEffectiveDate.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.uxEffectiveDate.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.uxEffectiveDate.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.uxEffectiveDate.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.uxEffectiveDate.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.uxEffectiveDate.Value = "=ValuesEffectiveDateString"
        '
        'TextBox33
        '
        Me.TextBox33.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.0791661739349365R), Telerik.Reporting.Drawing.Unit.Inch(0.3000788688659668R))
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.70837372541427612R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox33.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox33.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox33.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox33.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox33.Value = "Currency:"
        '
        'uxCurrencyCode
        '
        Me.uxCurrencyCode.Format = "{0}"
        Me.uxCurrencyCode.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.8667852878570557R), Telerik.Reporting.Drawing.Unit.Inch(0.3000788688659668R))
        Me.uxCurrencyCode.Name = "uxCurrencyCode"
        Me.uxCurrencyCode.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.92083358764648438R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.uxCurrencyCode.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.uxCurrencyCode.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.uxCurrencyCode.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.uxCurrencyCode.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.uxCurrencyCode.Value = "=CurrencyCode"
        '
        'TextBox37
        '
        Me.TextBox37.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.093789421021938324R), Telerik.Reporting.Drawing.Unit.Inch(0.72333335876464844R))
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.83333331346511841R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox37.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox37.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox37.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox37.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox37.Value = "PD Bldg.:"
        '
        'uxPDBldg
        '
        Me.uxPDBldg.Format = "{0}"
        Me.uxPDBldg.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.97504013776779175R), Telerik.Reporting.Drawing.Unit.Inch(0.72333335876464844R))
        Me.uxPDBldg.Name = "uxPDBldg"
        Me.uxPDBldg.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.uxPDBldg.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.uxPDBldg.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.uxPDBldg.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.uxPDBldg.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.uxPDBldg.Value = "=PDBreakdownBuilding"
        '
        'TextBox35
        '
        Me.TextBox35.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.0667064189910889R), Telerik.Reporting.Drawing.Unit.Inch(0.72333335876464844R))
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.70837372541427612R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox35.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox35.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox35.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox35.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox35.Value = "BI Profit:"
        '
        'uxBIProfit
        '
        Me.uxBIProfit.Format = "{0}"
        Me.uxBIProfit.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.8542060852050781R), Telerik.Reporting.Drawing.Unit.Inch(0.72333335876464844R))
        Me.uxBIProfit.Name = "uxBIProfit"
        Me.uxBIProfit.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.92083358764648438R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.uxBIProfit.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.uxBIProfit.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.uxBIProfit.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.uxBIProfit.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.uxBIProfit.Value = "=BIGrossProfit"
        '
        'TextBox41
        '
        Me.TextBox41.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.093789421021938324R), Telerik.Reporting.Drawing.Unit.Inch(0.90416663885116577R))
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.83333331346511841R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox41.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox41.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox41.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox41.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox41.Value = "PD Mach/Eq.:"
        '
        'uxPDEquip
        '
        Me.uxPDEquip.Format = "{0}"
        Me.uxPDEquip.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.97504013776779175R), Telerik.Reporting.Drawing.Unit.Inch(0.90416663885116577R))
        Me.uxPDEquip.Name = "uxPDEquip"
        Me.uxPDEquip.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.uxPDEquip.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.uxPDEquip.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.uxPDEquip.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.uxPDEquip.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.uxPDEquip.Value = "=PDBreakdownEquipment"
        '
        'TextBox39
        '
        Me.TextBox39.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.0667064189910889R), Telerik.Reporting.Drawing.Unit.Inch(0.90416663885116577R))
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.70837372541427612R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox39.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox39.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox39.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox39.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox39.Value = "BI Wage:"
        '
        'uxBIWage
        '
        Me.uxBIWage.Format = "{0}"
        Me.uxBIWage.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.8542060852050781R), Telerik.Reporting.Drawing.Unit.Inch(0.90416663885116577R))
        Me.uxBIWage.Name = "uxBIWage"
        Me.uxBIWage.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.92083358764648438R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.uxBIWage.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.uxBIWage.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.uxBIWage.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.uxBIWage.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.uxBIWage.Value = "=BIWageExtraExp"
        '
        'TextBox49
        '
        Me.TextBox49.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.093789421021938324R), Telerik.Reporting.Drawing.Unit.Inch(1.0850000381469727R))
        Me.TextBox49.Name = "TextBox49"
        Me.TextBox49.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.83333331346511841R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox49.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox49.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox49.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox49.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox49.Value = "PD Stock:"
        '
        'uxPDStock
        '
        Me.uxPDStock.Format = "{0}"
        Me.uxPDStock.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.97504013776779175R), Telerik.Reporting.Drawing.Unit.Inch(1.0850000381469727R))
        Me.uxPDStock.Name = "uxPDStock"
        Me.uxPDStock.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.uxPDStock.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.uxPDStock.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.uxPDStock.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.uxPDStock.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.uxPDStock.Value = "=PDBreakdownBuildingR"
        '
        'TextBox47
        '
        Me.TextBox47.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.066706657409668R), Telerik.Reporting.Drawing.Unit.Inch(1.0850000381469727R))
        Me.TextBox47.Name = "TextBox47"
        Me.TextBox47.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.70837372541427612R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox47.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox47.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox47.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox47.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox47.Value = "BI MIsc.:"
        '
        'uxBIMisc
        '
        Me.uxBIMisc.Format = "{0}"
        Me.uxBIMisc.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.8542063236236572R), Telerik.Reporting.Drawing.Unit.Inch(1.0850000381469727R))
        Me.uxBIMisc.Name = "uxBIMisc"
        Me.uxBIMisc.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.92083358764648438R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.uxBIMisc.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.uxBIMisc.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.uxBIMisc.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.uxBIMisc.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.uxBIMisc.Value = "=BIBreakdownMisc"
        '
        'TextBox45
        '
        Me.TextBox45.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.093789421021938324R), Telerik.Reporting.Drawing.Unit.Inch(1.2658333778381348R))
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.83333331346511841R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox45.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox45.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox45.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox45.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox45.Value = "PD Raw Stk.:"
        '
        'uxPDRawStock
        '
        Me.uxPDRawStock.Format = "{0}"
        Me.uxPDRawStock.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.97504013776779175R), Telerik.Reporting.Drawing.Unit.Inch(1.2658333778381348R))
        Me.uxPDRawStock.Name = "uxPDRawStock"
        Me.uxPDRawStock.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.uxPDRawStock.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.uxPDRawStock.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.uxPDRawStock.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.uxPDRawStock.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.uxPDRawStock.Value = "=PDBreakdownRawStock"
        '
        'TextBox43
        '
        Me.TextBox43.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.0667064189910889R), Telerik.Reporting.Drawing.Unit.Inch(1.2658333778381348R))
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.70837372541427612R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox43.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox43.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox43.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox43.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox43.Value = "BI Other:"
        '
        'uxBIOther
        '
        Me.uxBIOther.Format = "{0}"
        Me.uxBIOther.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.8542060852050781R), Telerik.Reporting.Drawing.Unit.Inch(1.2658333778381348R))
        Me.uxBIOther.Name = "uxBIOther"
        Me.uxBIOther.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.92083358764648438R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.uxBIOther.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.uxBIOther.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.uxBIOther.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.uxBIOther.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.uxBIOther.Value = "=BIBreakdownOther"
        '
        'TextBox61
        '
        Me.TextBox61.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.093789421021938324R), Telerik.Reporting.Drawing.Unit.Inch(1.4466667175292969R))
        Me.TextBox61.Name = "TextBox61"
        Me.TextBox61.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.83333331346511841R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox61.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox61.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox61.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox61.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox61.Value = "PD Bldr Risk:"
        '
        'uxPDBldgRisk
        '
        Me.uxPDBldgRisk.Format = "{0}"
        Me.uxPDBldgRisk.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.97504013776779175R), Telerik.Reporting.Drawing.Unit.Inch(1.4466667175292969R))
        Me.uxPDBldgRisk.Name = "uxPDBldgRisk"
        Me.uxPDBldgRisk.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.uxPDBldgRisk.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.uxPDBldgRisk.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.uxPDBldgRisk.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.uxPDBldgRisk.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.uxPDBldgRisk.Value = "=PDBreakdownBuildingR"
        '
        'TextBox57
        '
        Me.TextBox57.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.093789421021938324R), Telerik.Reporting.Drawing.Unit.Inch(1.627500057220459R))
        Me.TextBox57.Name = "TextBox57"
        Me.TextBox57.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.83333331346511841R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox57.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox57.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox57.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox57.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox57.Value = "PD Misc.:"
        '
        'uxPDMisc
        '
        Me.uxPDMisc.Format = "{0}"
        Me.uxPDMisc.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.97504013776779175R), Telerik.Reporting.Drawing.Unit.Inch(1.627500057220459R))
        Me.uxPDMisc.Name = "uxPDMisc"
        Me.uxPDMisc.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.uxPDMisc.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.uxPDMisc.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.uxPDMisc.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.uxPDMisc.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.uxPDMisc.Value = "=PDBreakdownMisc"
        '
        'TextBox55
        '
        Me.TextBox55.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.066706657409668R), Telerik.Reporting.Drawing.Unit.Inch(1.8083332777023315R))
        Me.TextBox55.Name = "TextBox55"
        Me.TextBox55.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.70837372541427612R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox55.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox55.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox55.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox55.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox55.Value = "BI Total:"
        '
        'uxBITotalLocalValue
        '
        Me.uxBITotalLocalValue.Format = "{0}"
        Me.uxBITotalLocalValue.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.8542063236236572R), Telerik.Reporting.Drawing.Unit.Inch(1.8083332777023315R))
        Me.uxBITotalLocalValue.Name = "uxBITotalLocalValue"
        Me.uxBITotalLocalValue.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.92083358764648438R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.uxBITotalLocalValue.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.uxBITotalLocalValue.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.uxBITotalLocalValue.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.uxBITotalLocalValue.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.uxBITotalLocalValue.Value = "=BITotalLocalValue"
        '
        'TextBox53
        '
        Me.TextBox53.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.093789421021938324R), Telerik.Reporting.Drawing.Unit.Inch(1.8083332777023315R))
        Me.TextBox53.Name = "TextBox53"
        Me.TextBox53.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.83333331346511841R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox53.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox53.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox53.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox53.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox53.Value = "PD Total:"
        '
        'uxPDTotalLocalValue
        '
        Me.uxPDTotalLocalValue.Format = "{0}"
        Me.uxPDTotalLocalValue.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.97504013776779175R), Telerik.Reporting.Drawing.Unit.Inch(1.8083332777023315R))
        Me.uxPDTotalLocalValue.Name = "uxPDTotalLocalValue"
        Me.uxPDTotalLocalValue.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.uxPDTotalLocalValue.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.uxPDTotalLocalValue.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.uxPDTotalLocalValue.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.uxPDTotalLocalValue.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.uxPDTotalLocalValue.Value = "=PDTotalLocalValue"
        '
        'uxLocationPolicyHeadingPanel
        '
        Me.uxLocationPolicyHeadingPanel.CanShrink = True
        Me.uxLocationPolicyHeadingPanel.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox5, Me.TextBox1})
        Me.uxLocationPolicyHeadingPanel.KeepTogether = True
        Me.uxLocationPolicyHeadingPanel.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.uxLocationPolicyHeadingPanel.Name = "uxLocationPolicyHeadingPanel"
        Me.uxLocationPolicyHeadingPanel.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.9998817443847656R), Telerik.Reporting.Drawing.Unit.Inch(0.25999999046325684R))
        Me.uxLocationPolicyHeadingPanel.Style.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.0999603271484375R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1853771209716797R), Telerik.Reporting.Drawing.Unit.Inch(0.25999999046325684R))
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11.0R)
        Me.TextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom
        Me.TextBox1.Value = "Policy Values"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3687500953674316R), Telerik.Reporting.Drawing.Unit.Inch(0.25999999046325684R))
        Me.TextBox5.Style.Font.Bold = True
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11.0R)
        Me.TextBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom
        Me.TextBox5.Value = "Location Details"
        '
        'PMPolicyValueSubReport
        '
        Me.Filters.Add(New Telerik.Reporting.Filter("RowID", Telerik.Reporting.FilterOperator.Equal, "= Parameters.ProjectRowID.Value"))
        Group1.GroupFooter = Me.groupFooterSection
        Group1.GroupHeader = Me.groupHeaderSection
        Group1.Groupings.Add(New Telerik.Reporting.Grouping("=RowID"))
        Group1.Name = "group"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.groupHeaderSection, Me.groupFooterSection, Me.detail})
        Me.Name = "PMPolicyValueReport"
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.25R), Telerik.Reporting.Drawing.Unit.Inch(0.25R), Telerik.Reporting.Drawing.Unit.Inch(0.25R), Telerik.Reporting.Drawing.Unit.Inch(0.25R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        ReportParameter1.Name = "ProjectRowID"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.[Integer]
        Me.ReportParameters.Add(ReportParameter1)
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(8.0R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents Panel1 As Telerik.Reporting.Panel
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents uxFileNo As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents uxClientLocNo As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents uxClient As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents uxDivision As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents uxFacility As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents uxCustomAccess As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents uxAddress1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents uxAddress2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox27 As Telerik.Reporting.TextBox
    Friend WithEvents uxAddress3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox25 As Telerik.Reporting.TextBox
    Friend WithEvents uxCity As Telerik.Reporting.TextBox
    Friend WithEvents TextBox23 As Telerik.Reporting.TextBox
    Friend WithEvents uxStProv As Telerik.Reporting.TextBox
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
    Friend WithEvents uxZip As Telerik.Reporting.TextBox
    Friend WithEvents TextBox28 As Telerik.Reporting.TextBox
    Friend WithEvents uxCountry As Telerik.Reporting.TextBox
    Friend WithEvents Panel2 As Telerik.Reporting.Panel
    Friend WithEvents TextBox31 As Telerik.Reporting.TextBox
    Friend WithEvents uxEffectiveDate As Telerik.Reporting.TextBox
    Friend WithEvents TextBox33 As Telerik.Reporting.TextBox
    Friend WithEvents uxCurrencyCode As Telerik.Reporting.TextBox
    Friend WithEvents TextBox37 As Telerik.Reporting.TextBox
    Friend WithEvents uxPDBldg As Telerik.Reporting.TextBox
    Friend WithEvents TextBox35 As Telerik.Reporting.TextBox
    Friend WithEvents uxBIProfit As Telerik.Reporting.TextBox
    Friend WithEvents TextBox41 As Telerik.Reporting.TextBox
    Friend WithEvents uxPDEquip As Telerik.Reporting.TextBox
    Friend WithEvents TextBox39 As Telerik.Reporting.TextBox
    Friend WithEvents uxBIWage As Telerik.Reporting.TextBox
    Friend WithEvents TextBox49 As Telerik.Reporting.TextBox
    Friend WithEvents uxPDStock As Telerik.Reporting.TextBox
    Friend WithEvents TextBox47 As Telerik.Reporting.TextBox
    Friend WithEvents uxBIMisc As Telerik.Reporting.TextBox
    Friend WithEvents TextBox45 As Telerik.Reporting.TextBox
    Friend WithEvents uxPDRawStock As Telerik.Reporting.TextBox
    Friend WithEvents TextBox43 As Telerik.Reporting.TextBox
    Friend WithEvents uxBIOther As Telerik.Reporting.TextBox
    Friend WithEvents TextBox61 As Telerik.Reporting.TextBox
    Friend WithEvents uxPDBldgRisk As Telerik.Reporting.TextBox
    Friend WithEvents TextBox57 As Telerik.Reporting.TextBox
    Friend WithEvents uxPDMisc As Telerik.Reporting.TextBox
    Friend WithEvents TextBox55 As Telerik.Reporting.TextBox
    Friend WithEvents uxBITotalLocalValue As Telerik.Reporting.TextBox
    Friend WithEvents TextBox53 As Telerik.Reporting.TextBox
    Friend WithEvents uxPDTotalLocalValue As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents groupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents groupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents uxLocationPolicyHeadingPanel As Telerik.Reporting.Panel
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
End Class