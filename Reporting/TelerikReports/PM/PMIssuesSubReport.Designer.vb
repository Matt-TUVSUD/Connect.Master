Partial Class PMIssuesSubReport

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.groupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.groupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.Panel4 = New Telerik.Reporting.Panel()
        Me.Panel2 = New Telerik.Reporting.Panel()
        Me.Panel6 = New Telerik.Reporting.Panel()
        Me.TextBox51 = New Telerik.Reporting.TextBox()
        Me.TextBox58 = New Telerik.Reporting.TextBox()
        Me.TextBox62 = New Telerik.Reporting.TextBox()
        Me.TextBox59 = New Telerik.Reporting.TextBox()
        Me.Panel9 = New Telerik.Reporting.Panel()
        Me.TextBox67 = New Telerik.Reporting.TextBox()
        Me.TextBox68 = New Telerik.Reporting.TextBox()
        Me.Panel10 = New Telerik.Reporting.Panel()
        Me.TextBox69 = New Telerik.Reporting.TextBox()
        Me.TextBox70 = New Telerik.Reporting.TextBox()
        Me.Panel14 = New Telerik.Reporting.Panel()
        Me.TextBox77 = New Telerik.Reporting.TextBox()
        Me.TextBox78 = New Telerik.Reporting.TextBox()
        Me.Panel3 = New Telerik.Reporting.Panel()
        Me.Panel16 = New Telerik.Reporting.Panel()
        Me.TextBox84 = New Telerik.Reporting.TextBox()
        Me.TextBox83 = New Telerik.Reporting.TextBox()
        Me.TextBox102 = New Telerik.Reporting.TextBox()
        Me.TextBox101 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'groupFooterSection
        '
        Me.groupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699R)
        Me.groupFooterSection.Name = "groupFooterSection"
        Me.groupFooterSection.Style.Visible = False
        '
        'groupHeaderSection
        '
        Me.groupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.26045608520507813R)
        Me.groupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox1})
        Me.groupHeaderSection.Name = "groupHeaderSection"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(0.0R), Telerik.Reporting.Drawing.Unit.Pixel(0.0037841796875R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(234.79998779296875R), Telerik.Reporting.Drawing.Unit.Pixel(25.0R))
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11.0R)
        Me.TextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom
        Me.TextBox1.Value = "Issues"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.98954391479492188R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel4})
        Me.detail.KeepTogether = True
        Me.detail.Name = "detail"
        '
        'Panel4
        '
        Me.Panel4.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel2, Me.Panel3})
        Me.Panel4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(0.0R), Telerik.Reporting.Drawing.Unit.Pixel(0.0R))
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(768.0R), Telerik.Reporting.Drawing.Unit.Pixel(81.2303466796875R))
        Me.Panel4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel4.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.Panel4.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(5.0R)
        '
        'Panel2
        '
        Me.Panel2.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel6, Me.Panel9, Me.Panel10, Me.Panel14})
        Me.Panel2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000039339065551757813R), Telerik.Reporting.Drawing.Unit.Inch(0.1041666641831398R))
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.89996075630188R), Telerik.Reporting.Drawing.Unit.Inch(0.70250004529953R))
        '
        'Panel6
        '
        Me.Panel6.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox51, Me.TextBox58, Me.TextBox62, Me.TextBox59})
        Me.Panel6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.8749215602874756R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.Panel6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        '
        'TextBox51
        '
        Me.TextBox51.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.09992130845785141R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.TextBox51.Name = "TextBox51"
        Me.TextBox51.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1000000238418579R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox51.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox51.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox51.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox51.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.TextBox51.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox51.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox51.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.TextBox51.Value = "Issue ID:"
        '
        'TextBox58
        '
        Me.TextBox58.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.2999213933944702R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox58.Name = "TextBox58"
        Me.TextBox58.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.62507867813110352R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox58.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox58.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox58.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox58.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.TextBox58.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox58.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox58.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.TextBox58.Value = "=IssueID"
        '
        'TextBox62
        '
        Me.TextBox62.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.9999213218688965R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox62.Name = "TextBox62"
        Me.TextBox62.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.874999463558197R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox62.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox62.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox62.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox62.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.TextBox62.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox62.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox62.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.TextBox62.Value = "Date Created:"
        '
        'TextBox59
        '
        Me.TextBox59.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.875R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox59.Name = "TextBox59"
        Me.TextBox59.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.92492169141769409R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox59.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox59.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox59.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox59.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.TextBox59.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox59.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox59.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.TextBox59.Value = "=CreateDateString"
        '
        'Panel9
        '
        Me.Panel9.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox67, Me.TextBox68})
        Me.Panel9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.36166667938232422R))
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.8749215602874756R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.Panel9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.Panel9.Style.Visible = True
        '
        'TextBox67
        '
        Me.TextBox67.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.09992130845785141R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.TextBox67.Name = "TextBox67"
        Me.TextBox67.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0999606847763062R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox67.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox67.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox67.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox67.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.TextBox67.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox67.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox67.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.TextBox67.Value = "Priority:"
        '
        'TextBox68
        '
        Me.TextBox68.Bindings.Add(New Telerik.Reporting.Binding("Style.BackgroundColor", "=PriorityColorHex"))
        Me.TextBox68.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.2999213933944702R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox68.Name = "TextBox68"
        Me.TextBox68.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.499881386756897R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox68.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox68.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox68.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox68.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.TextBox68.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox68.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox68.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.TextBox68.Value = "=Priority"
        '
        'Panel10
        '
        Me.Panel10.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox69, Me.TextBox70})
        Me.Panel10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.18083333969116211R))
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.8749215602874756R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.Panel10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        '
        'TextBox69
        '
        Me.TextBox69.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.09992130845785141R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.TextBox69.Name = "TextBox69"
        Me.TextBox69.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0999606847763062R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox69.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox69.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox69.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox69.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.TextBox69.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox69.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox69.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.TextBox69.Value = "Title:"
        '
        'TextBox70
        '
        Me.TextBox70.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.2999213933944702R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox70.Name = "TextBox70"
        Me.TextBox70.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.499881386756897R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox70.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox70.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox70.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox70.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.TextBox70.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox70.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox70.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.TextBox70.Value = "=Title"
        '
        'Panel14
        '
        Me.Panel14.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox77, Me.TextBox78})
        Me.Panel14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.54250001907348633R))
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.8749215602874756R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.Panel14.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        '
        'TextBox77
        '
        Me.TextBox77.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.09992130845785141R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.TextBox77.Name = "TextBox77"
        Me.TextBox77.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0999606847763062R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox77.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox77.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox77.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox77.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.TextBox77.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox77.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox77.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.TextBox77.Value = "Date Resolved:"
        '
        'TextBox78
        '
        Me.TextBox78.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.2999213933944702R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox78.Name = "TextBox78"
        Me.TextBox78.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.499881386756897R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox78.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox78.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox78.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox78.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.TextBox78.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox78.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox78.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.TextBox78.Value = "=DateIssueResolvedString"
        '
        'Panel3
        '
        Me.Panel3.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel16, Me.TextBox102, Me.TextBox101})
        Me.Panel3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.0999999046325684R), Telerik.Reporting.Drawing.Unit.Inch(0.000078837074397597462R))
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.89996075630188R), Telerik.Reporting.Drawing.Unit.Inch(0.84607058763504028R))
        '
        'Panel16
        '
        Me.Panel16.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox84, Me.TextBox83})
        Me.Panel16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(1.80194091796875R), Telerik.Reporting.Drawing.Unit.Pixel(9.5848846435546875R))
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(370.7923583984375R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        '
        'TextBox84
        '
        Me.TextBox84.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox84.Name = "TextBox84"
        Me.TextBox84.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1197910308837891R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox84.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox84.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox84.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox84.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.TextBox84.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox84.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox84.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.TextBox84.Value = "Created By:"
        '
        'TextBox83
        '
        Me.TextBox83.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.1198698282241821R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox83.Name = "TextBox83"
        Me.TextBox83.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7551695108413696R), Telerik.Reporting.Drawing.Unit.Inch(0.15999999642372131R))
        Me.TextBox83.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox83.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox83.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox83.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.TextBox83.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox83.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox83.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.TextBox83.Value = "=CreateBy"
        '
        'TextBox102
        '
        Me.TextBox102.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.00000031789144827598648R), Telerik.Reporting.Drawing.Unit.Inch(0.31238174438476563R))
        Me.TextBox102.Name = "TextBox102"
        Me.TextBox102.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6291666030883789R), Telerik.Reporting.Drawing.Unit.Inch(0.2083333283662796R))
        Me.TextBox102.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox102.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox102.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox102.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.TextBox102.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox102.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox102.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(0.0R)
        Me.TextBox102.Value = "Issue Comment:"
        '
        'TextBox101
        '
        Me.TextBox101.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.00000031789144827598648R), Telerik.Reporting.Drawing.Unit.Inch(0.520715057849884R))
        Me.TextBox101.Name = "TextBox101"
        Me.TextBox101.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.8166663646698R), Telerik.Reporting.Drawing.Unit.Inch(0.32535552978515625R))
        Me.TextBox101.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox101.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox101.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox101.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(5.0R)
        Me.TextBox101.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(5.0R)
        Me.TextBox101.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(5.0R)
        Me.TextBox101.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(5.0R)
        Me.TextBox101.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox101.Value = "=IssueDesc"
        '
        'PMIssuesSubReport
        '
        Me.Filters.Add(New Telerik.Reporting.Filter("ProjectRowID", Telerik.Reporting.FilterOperator.Equal, "= Parameters.ProjectRowID.Value"))
        Group1.GroupFooter = Me.groupFooterSection
        Group1.GroupHeader = Me.groupHeaderSection
        Group1.Groupings.Add(New Telerik.Reporting.Grouping("=ProjectRowID"))
        Group1.Name = "group"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.groupHeaderSection, Me.groupFooterSection, Me.detail})
        Me.Name = "PMPolicyValueReport"
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.25R), Telerik.Reporting.Drawing.Unit.Inch(0.25R), Telerik.Reporting.Drawing.Unit.Inch(0.25R), Telerik.Reporting.Drawing.Unit.Inch(0.25R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        ReportParameter1.Name = "ProjectRowID"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.[Integer]
        Me.ReportParameters.Add(ReportParameter1)
        Me.Sortings.Add(New Telerik.Reporting.Sorting("=IssueID", Telerik.Reporting.SortDirection.Asc))
        Me.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.UnitOfMeasure = Telerik.Reporting.Drawing.UnitType.Pixel
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(8.0R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents Panel2 As Telerik.Reporting.Panel
    Friend WithEvents Panel3 As Telerik.Reporting.Panel
    Friend WithEvents Panel6 As Telerik.Reporting.Panel
    Friend WithEvents TextBox51 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox58 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox62 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox59 As Telerik.Reporting.TextBox
    Friend WithEvents Panel9 As Telerik.Reporting.Panel
    Friend WithEvents TextBox67 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox68 As Telerik.Reporting.TextBox
    Friend WithEvents Panel10 As Telerik.Reporting.Panel
    Friend WithEvents TextBox69 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox70 As Telerik.Reporting.TextBox
    Friend WithEvents Panel14 As Telerik.Reporting.Panel
    Friend WithEvents TextBox77 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox78 As Telerik.Reporting.TextBox
    Friend WithEvents Panel16 As Telerik.Reporting.Panel
    Friend WithEvents TextBox84 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox83 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox102 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox101 As Telerik.Reporting.TextBox
    Friend WithEvents Panel4 As Telerik.Reporting.Panel
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents groupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents groupFooterSection As Telerik.Reporting.GroupFooterSection
End Class