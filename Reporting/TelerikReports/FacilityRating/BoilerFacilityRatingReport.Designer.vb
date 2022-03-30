Partial Class BoilerFacilityRatingReport

     'NOTE: The following procedure is required by the telerik Reporting Designer
     'It can be modified using the telerik Reporting Designer.  
     'Do not modify it using the code editor.
     Private Sub InitializeComponent()
        Dim TableGroup1 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup2 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group2 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group3 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group4 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group5 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group6 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group7 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group8 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group9 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group10 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group11 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group12 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group13 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group14 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group15 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group16 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group17 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group18 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group19 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group20 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group21 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group22 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group23 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group24 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group25 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group26 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group27 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Me.uxRatingKeyHeader = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.Panel1 = New Telerik.Reporting.Panel()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox49 = New Telerik.Reporting.TextBox()
        Me.txtOverallScore = New Telerik.Reporting.TextBox()
        Me.txtOverallRating = New Telerik.Reporting.TextBox()
        Me.TextBox52 = New Telerik.Reporting.TextBox()
        Me.TextBox55 = New Telerik.Reporting.TextBox()
        Me.TextBox56 = New Telerik.Reporting.TextBox()
        Me.txtOverallScoreMessage = New Telerik.Reporting.TextBox()
        Me.Panel2 = New Telerik.Reporting.Panel()
        Me.TextBox47 = New Telerik.Reporting.TextBox()
        Me.TextBox48 = New Telerik.Reporting.TextBox()
        Me.TextBox69 = New Telerik.Reporting.TextBox()
        Me.TextBox70 = New Telerik.Reporting.TextBox()
        Me.TextBox71 = New Telerik.Reporting.TextBox()
        Me.TextBox72 = New Telerik.Reporting.TextBox()
        Me.TextBox73 = New Telerik.Reporting.TextBox()
        Me.TextBox74 = New Telerik.Reporting.TextBox()
        Me.TextBox75 = New Telerik.Reporting.TextBox()
        Me.TextBox76 = New Telerik.Reporting.TextBox()
        Me.TextBox79 = New Telerik.Reporting.TextBox()
        Me.TextBox80 = New Telerik.Reporting.TextBox()
        Me.txtMechSysRating = New GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox()
        Me.txtElecSysRating = New GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox()
        Me.txtProdRating = New GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox()
        Me.txtBoilerRating = New GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox()
        Me.TextBox85 = New Telerik.Reporting.TextBox()
        Me.TextBox92 = New Telerik.Reporting.TextBox()
        Me.TextBox93 = New Telerik.Reporting.TextBox()
        Me.TextBox94 = New Telerik.Reporting.TextBox()
        Me.TextBox95 = New Telerik.Reporting.TextBox()
        Me.TextBox96 = New Telerik.Reporting.TextBox()
        Me.TextBox97 = New Telerik.Reporting.TextBox()
        Me.TextBox98 = New Telerik.Reporting.TextBox()
        Me.TextBox99 = New Telerik.Reporting.TextBox()
        Me.txtBoilerRatingRecs = New GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox()
        Me.txtProdRatingRecs = New GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox()
        Me.txtElecSysRatingRecs = New GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox()
        Me.txtMechSysRatingRecs = New GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox()
        Me.TextBox112 = New Telerik.Reporting.TextBox()
        Me.TextBox113 = New Telerik.Reporting.TextBox()
        Me.TextBox114 = New Telerik.Reporting.TextBox()
        Me.TextBox115 = New Telerik.Reporting.TextBox()
        Me.TextBox30 = New Telerik.Reporting.TextBox()
        Me.TextBox31 = New Telerik.Reporting.TextBox()
        Me.txtCompSysRatingRecs = New GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox()
        Me.txtOccupancyRatingRecs = New GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox()
        Me.TextBox35 = New Telerik.Reporting.TextBox()
        Me.TextBox36 = New Telerik.Reporting.TextBox()
        Me.txtOccupancyRating = New GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox()
        Me.txtCompSysRating = New GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox()
        Me.TextBox50 = New Telerik.Reporting.TextBox()
        Me.TextBox51 = New Telerik.Reporting.TextBox()
        Me.TextBox53 = New Telerik.Reporting.TextBox()
        Me.TextBox54 = New Telerik.Reporting.TextBox()
        Me.Panel3 = New Telerik.Reporting.Panel()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.TextBox25 = New Telerik.Reporting.TextBox()
        Me.TextBox26 = New Telerik.Reporting.TextBox()
        Me.TextBox27 = New Telerik.Reporting.TextBox()
        Me.TextBox28 = New Telerik.Reporting.TextBox()
        Me.TextBox29 = New Telerik.Reporting.TextBox()
        Me.TextBox34 = New Telerik.Reporting.TextBox()
        Me.txtMechMaintRating = New GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox()
        Me.txtElecMaintRating = New GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox()
        Me.txtHeRating = New GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox()
        Me.txtCriticalSparesRating = New GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox()
        Me.TextBox43 = New Telerik.Reporting.TextBox()
        Me.TextBox44 = New Telerik.Reporting.TextBox()
        Me.TextBox45 = New Telerik.Reporting.TextBox()
        Me.TextBox57 = New Telerik.Reporting.TextBox()
        Me.TextBox58 = New Telerik.Reporting.TextBox()
        Me.TextBox59 = New Telerik.Reporting.TextBox()
        Me.TextBox60 = New Telerik.Reporting.TextBox()
        Me.TextBox61 = New Telerik.Reporting.TextBox()
        Me.TextBox62 = New Telerik.Reporting.TextBox()
        Me.txtCriticalSparesRatingRecs = New GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox()
        Me.txtHeRatingRecs = New GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox()
        Me.txtElecMaintRatingRecs = New GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox()
        Me.txtMechMaintRatingRecs = New GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox()
        Me.TextBox67 = New Telerik.Reporting.TextBox()
        Me.TextBox68 = New Telerik.Reporting.TextBox()
        Me.TextBox77 = New Telerik.Reporting.TextBox()
        Me.TextBox78 = New Telerik.Reporting.TextBox()
        Me.TextBox86 = New Telerik.Reporting.TextBox()
        Me.txtBcpRatingRecs = New GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox()
        Me.TextBox91 = New Telerik.Reporting.TextBox()
        Me.txtBcpRating = New GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox()
        Me.TextBox106 = New Telerik.Reporting.TextBox()
        Me.TextBox107 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox46 = New Telerik.Reporting.TextBox()
        Me.Panel6 = New Telerik.Reporting.Panel()
        Me.uxRatingKeyTable = New Telerik.Reporting.Table()
        Me.TextBox32 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'uxRatingKeyHeader
        '
        Me.uxRatingKeyHeader.Name = "uxRatingKeyHeader"
        Me.uxRatingKeyHeader.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6770833730697632R), Telerik.Reporting.Drawing.Unit.Inch(0.18750001490116119R))
        Me.uxRatingKeyHeader.Style.Font.Bold = True
        Me.uxRatingKeyHeader.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.uxRatingKeyHeader.Value = "Rating Key"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(6.344541072845459R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel1, Me.TextBox1, Me.TextBox49, Me.txtOverallScore, Me.txtOverallRating, Me.TextBox52, Me.TextBox55, Me.TextBox56, Me.txtOverallScoreMessage, Me.Panel2, Me.Panel3, Me.TextBox18, Me.TextBox46, Me.Panel6})
        Me.detail.Name = "detail"
        Me.detail.PageBreak = Telerik.Reporting.PageBreak.After
        Me.detail.Style.Visible = True
        '
        'Panel1
        '
        Me.Panel1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox14, Me.TextBox13, Me.TextBox12, Me.TextBox11, Me.TextBox8, Me.TextBox7, Me.TextBox6, Me.TextBox5, Me.TextBox4, Me.TextBox3, Me.TextBox10, Me.TextBox15, Me.TextBox2, Me.TextBox9, Me.TextBox16, Me.TextBox17})
        Me.Panel1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.006249984260648489R), Telerik.Reporting.Drawing.Unit.Inch(0.13265272974967957R))
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(10.421069145202637R), Telerik.Reporting.Drawing.Unit.Inch(0.84582287073135376R))
        Me.Panel1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel1.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        '
        'TextBox14
        '
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.2520833015441895R), Telerik.Reporting.Drawing.Unit.Inch(0.32916665077209473R))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89999961853027344R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox14.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox14.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox14.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox14.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(3.0R)
        Me.TextBox14.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox14.Value = "=Country"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.8145835399627686R), Telerik.Reporting.Drawing.Unit.Inch(0.32916665077209473R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.43742099404335022R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox13.Style.Font.Bold = True
        Me.TextBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox13.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox13.Value = "Ctry:"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.847916841506958R), Telerik.Reporting.Drawing.Unit.Inch(0.33958330750465393R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.38125023245811462R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox12.Style.Font.Bold = True
        Me.TextBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox12.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox12.Value = "State:"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2333335876464844R), Telerik.Reporting.Drawing.Unit.Inch(0.33958330750465393R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.5063292384147644R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox11.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox11.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox11.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(3.0R)
        Me.TextBox11.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox11.Value = "=Stprov"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.19166667759418488R), Telerik.Reporting.Drawing.Unit.Inch(0.59791678190231323R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.64992111921310425R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox8.Style.Font.Bold = True
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox8.Value = "Division:"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.84166669845581055R), Telerik.Reporting.Drawing.Unit.Inch(0.59791678190231323R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.6250786781311035R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox7.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox7.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(3.0R)
        Me.TextBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox7.Value = "=Division"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.84166669845581055R), Telerik.Reporting.Drawing.Unit.Inch(0.33958330750465393R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9228382110595703R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox6.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox6.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(3.0R)
        Me.TextBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox6.Value = "=City"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.19166667759418488R), Telerik.Reporting.Drawing.Unit.Inch(0.33958330750465393R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.64992111921310425R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox5.Style.Font.Bold = True
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox5.Value = "City:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.19166667759418488R), Telerik.Reporting.Drawing.Unit.Inch(0.089583314955234528R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.64992111921310425R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox4.Style.Font.Bold = True
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox4.Value = "Address:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.84166669845581055R), Telerik.Reporting.Drawing.Unit.Inch(0.089583314955234528R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.6250786781311035R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox3.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox3.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(3.0R)
        Me.TextBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox3.Value = "=Address1"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.7520833015441895R), Telerik.Reporting.Drawing.Unit.Inch(0.34575462341308594R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.71466255187988281R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox10.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox10.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox10.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(3.0R)
        Me.TextBox10.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox10.Value = "=zip"
        '
        'TextBox15
        '
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.2520828247070313R), Telerik.Reporting.Drawing.Unit.Inch(0.34575462341308594R))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.49583354592323303R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox15.Style.Font.Bold = True
        Me.TextBox15.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox15.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox15.Value = "Postal:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.3841848373413086R), Telerik.Reporting.Drawing.Unit.Inch(0.089583277702331543R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.80285263061523438R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox2.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox2.Value = "=FileNo"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.2082939147949219R), Telerik.Reporting.Drawing.Unit.Inch(0.089583277702331543R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1625003814697266R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox9.Style.Font.Bold = True
        Me.TextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox9.Value = "File No.:"
        '
        'TextBox16
        '
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.2082939147949219R), Telerik.Reporting.Drawing.Unit.Inch(0.3395831286907196R))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1625003814697266R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox16.Style.Font.Bold = True
        Me.TextBox16.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox16.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox16.Value = "Date of Inspection:"
        '
        'TextBox17
        '
        Me.TextBox17.Format = "{0:d-MMM-yy}"
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.3841848373413086R), Telerik.Reporting.Drawing.Unit.Inch(0.3395831286907196R))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.80285263061523438R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox17.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox17.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox17.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox17.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox17.Value = "=InspectionDate"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0896228551864624R), Telerik.Reporting.Drawing.Unit.Inch(0.020833350718021393R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.88333344459533691R), Telerik.Reporting.Drawing.Unit.Inch(0.17395837604999542R))
        Me.TextBox1.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(3.0R)
        Me.TextBox1.Value = "Location:"
        '
        'TextBox49
        '
        Me.TextBox49.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.7791275978088379R), Telerik.Reporting.Drawing.Unit.Inch(5.5361289978027344R))
        Me.TextBox49.Name = "TextBox49"
        Me.TextBox49.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8166662454605103R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox49.Style.Font.Bold = True
        Me.TextBox49.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox49.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(3.0R)
        Me.TextBox49.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox49.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox49.Value = "Total Facility Score:"
        '
        'txtOverallScore
        '
        Me.txtOverallScore.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.6451797485351562R), Telerik.Reporting.Drawing.Unit.Inch(5.5361289978027344R))
        Me.txtOverallScore.Name = "txtOverallScore"
        Me.txtOverallScore.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.933333694934845R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.txtOverallScore.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.txtOverallScore.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtOverallScore.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtOverallScore.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtOverallScore.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtOverallScore.Value = "=TotalScoreCurrent"
        '
        'txtOverallRating
        '
        Me.txtOverallRating.Bindings.Add(New Telerik.Reporting.Binding("Style.BackgroundColor", "=TotalScoreCurrentBackColor"))
        Me.txtOverallRating.Bindings.Add(New Telerik.Reporting.Binding("Style.Color", "=TotalScoreCurrentForeColor"))
        Me.txtOverallRating.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.6451797485351562R), Telerik.Reporting.Drawing.Unit.Inch(5.7361283302307129R))
        Me.txtOverallRating.Name = "txtOverallRating"
        Me.txtOverallRating.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.933333694934845R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.txtOverallRating.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.txtOverallRating.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtOverallRating.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtOverallRating.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtOverallRating.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtOverallRating.Value = "= GRC.Connect.Libraries.ReportLib.UtilReport.TelerikReport.ItemFunction.GetRiskRa" & _
    "ting([ActiveC]+[Passivec], ReportItem,1)"
        '
        'TextBox52
        '
        Me.TextBox52.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.7791275978088379R), Telerik.Reporting.Drawing.Unit.Inch(5.7361283302307129R))
        Me.TextBox52.Name = "TextBox52"
        Me.TextBox52.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8166662454605103R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox52.Style.Font.Bold = True
        Me.TextBox52.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox52.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(3.0R)
        Me.TextBox52.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox52.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox52.Value = "Overall Rating:"
        '
        'TextBox55
        '
        Me.TextBox55.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.6451797485351562R), Telerik.Reporting.Drawing.Unit.Inch(5.9362072944641113R))
        Me.TextBox55.Name = "TextBox55"
        Me.TextBox55.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.933333694934845R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox55.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox55.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox55.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox55.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox55.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox55.Value = "=TotalWrComplete"
        '
        'TextBox56
        '
        Me.TextBox56.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.7791275978088379R), Telerik.Reporting.Drawing.Unit.Inch(5.9362072944641113R))
        Me.TextBox56.Name = "TextBox56"
        Me.TextBox56.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8166662454605103R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox56.Style.Font.Bold = True
        Me.TextBox56.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox56.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(3.0R)
        Me.TextBox56.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox56.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox56.Value = "Overall Score w/Recs Complete:"
        '
        'txtOverallScoreMessage
        '
        Me.txtOverallScoreMessage.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0062896590679883957R), Telerik.Reporting.Drawing.Unit.Inch(5.5257115364074707R))
        Me.txtOverallScoreMessage.Name = "txtOverallScoreMessage"
        Me.txtOverallScoreMessage.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.1376504898071289R), Telerik.Reporting.Drawing.Unit.Inch(0.60000085830688477R))
        Me.txtOverallScoreMessage.Style.Font.Bold = False
        Me.txtOverallScoreMessage.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtOverallScoreMessage.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtOverallScoreMessage.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtOverallScoreMessage.Value = "(Physical assets for B&M considers the equipment is already installed at the faci" & _
    "lity.  However, recommendations may be submitted to improve/maintain, add or rep" & _
    "lace equipment to reduce the exposure.)"
        '
        'Panel2
        '
        Me.Panel2.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox47, Me.TextBox48, Me.TextBox69, Me.TextBox70, Me.TextBox71, Me.TextBox72, Me.TextBox73, Me.TextBox74, Me.TextBox75, Me.TextBox76, Me.TextBox79, Me.TextBox80, Me.txtMechSysRating, Me.txtElecSysRating, Me.txtProdRating, Me.txtBoilerRating, Me.TextBox85, Me.TextBox92, Me.TextBox93, Me.TextBox94, Me.TextBox95, Me.TextBox96, Me.TextBox97, Me.TextBox98, Me.TextBox99, Me.txtBoilerRatingRecs, Me.txtProdRatingRecs, Me.txtElecSysRatingRecs, Me.txtMechSysRatingRecs, Me.TextBox112, Me.TextBox113, Me.TextBox114, Me.TextBox115, Me.TextBox30, Me.TextBox31, Me.txtCompSysRatingRecs, Me.txtOccupancyRatingRecs, Me.TextBox35, Me.TextBox36, Me.txtOccupancyRating, Me.txtCompSysRating, Me.TextBox50, Me.TextBox51, Me.TextBox53, Me.TextBox54})
        Me.Panel2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0566626787185669R))
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(10.427318572998047R), Telerik.Reporting.Drawing.Unit.Inch(2.1185729503631592R))
        Me.Panel2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel2.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        '
        'TextBox47
        '
        Me.TextBox47.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.3841848373413086R), Telerik.Reporting.Drawing.Unit.Inch(0.82539016008377075R))
        Me.TextBox47.Name = "TextBox47"
        Me.TextBox47.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.80285263061523438R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox47.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox47.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox47.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox47.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox47.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox47.Value = "=PassiveC"
        '
        'TextBox48
        '
        Me.TextBox48.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.3841848373413086R), Telerik.Reporting.Drawing.Unit.Inch(0.3857269287109375R))
        Me.TextBox48.Name = "TextBox48"
        Me.TextBox48.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.8028524518013R), Telerik.Reporting.Drawing.Unit.Inch(0.43958339095115662R))
        Me.TextBox48.Style.Font.Bold = True
        Me.TextBox48.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox48.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox48.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox48.Value = "Total " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Score:"
        '
        'TextBox69
        '
        Me.TextBox69.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.367518424987793R), Telerik.Reporting.Drawing.Unit.Inch(1.3706811666488647R))
        Me.TextBox69.Name = "TextBox69"
        Me.TextBox69.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.81951886415481567R), Telerik.Reporting.Drawing.Unit.Inch(0.43958339095115662R))
        Me.TextBox69.Style.Font.Bold = True
        Me.TextBox69.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox69.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox69.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox69.Value = "Total " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Score w/Recs "
        '
        'TextBox70
        '
        Me.TextBox70.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.367518424987793R), Telerik.Reporting.Drawing.Unit.Inch(1.8185981512069702R))
        Me.TextBox70.Name = "TextBox70"
        Me.TextBox70.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.81951904296875R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox70.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox70.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox70.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox70.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox70.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox70.Value = "=PassiveWc"
        '
        'TextBox71
        '
        Me.TextBox71.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.0333342552185059R), Telerik.Reporting.Drawing.Unit.Inch(0.02473173476755619R))
        Me.TextBox71.Name = "TextBox71"
        Me.TextBox71.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3008947372436523R), Telerik.Reporting.Drawing.Unit.Inch(0.30520915985107422R))
        Me.TextBox71.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox71.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox71.Style.Font.Bold = True
        Me.TextBox71.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox71.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox71.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox71.Value = "Mechanical" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Systems"
        '
        'TextBox72
        '
        Me.TextBox72.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.3342287540435791R), Telerik.Reporting.Drawing.Unit.Inch(0.02473173476755619R))
        Me.TextBox72.Name = "TextBox72"
        Me.TextBox72.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3008947372436523R), Telerik.Reporting.Drawing.Unit.Inch(0.30520915985107422R))
        Me.TextBox72.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox72.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox72.Style.Font.Bold = True
        Me.TextBox72.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox72.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox72.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox72.Value = "Electrical" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Systems"
        '
        'TextBox73
        '
        Me.TextBox73.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.9360179901123047R), Telerik.Reporting.Drawing.Unit.Inch(0.02473173476755619R))
        Me.TextBox73.Name = "TextBox73"
        Me.TextBox73.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3008947372436523R), Telerik.Reporting.Drawing.Unit.Inch(0.30520915985107422R))
        Me.TextBox73.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox73.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox73.Style.Font.Bold = True
        Me.TextBox73.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox73.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox73.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox73.Value = "Prod./Process" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Equipment"
        '
        'TextBox74
        '
        Me.TextBox74.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.6351234912872314R), Telerik.Reporting.Drawing.Unit.Inch(0.02473173476755619R))
        Me.TextBox74.Name = "TextBox74"
        Me.TextBox74.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3008947372436523R), Telerik.Reporting.Drawing.Unit.Inch(0.30520915985107422R))
        Me.TextBox74.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox74.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox74.Style.Font.Bold = True
        Me.TextBox74.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox74.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox74.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox74.Value = "Boilers/Pressure" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Vessels/Tanks"
        '
        'TextBox75
        '
        Me.TextBox75.CanGrow = False
        Me.TextBox75.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.6351234912872314R), Telerik.Reporting.Drawing.Unit.Inch(0.73522782325744629R))
        Me.TextBox75.Name = "TextBox75"
        Me.TextBox75.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3008947372436523R), Telerik.Reporting.Drawing.Unit.Inch(0.54012888669967651R))
        Me.TextBox75.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox75.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox75.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox75.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox75.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox75.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox75.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox75.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox75.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox75.Value = "=BoilersDesc"
        '
        'TextBox76
        '
        Me.TextBox76.CanGrow = False
        Me.TextBox76.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.9360179901123047R), Telerik.Reporting.Drawing.Unit.Inch(0.73522782325744629R))
        Me.TextBox76.Name = "TextBox76"
        Me.TextBox76.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3008947372436523R), Telerik.Reporting.Drawing.Unit.Inch(0.54012888669967651R))
        Me.TextBox76.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox76.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox76.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox76.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox76.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox76.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox76.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox76.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox76.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox76.Value = "=ProcEquipDesc"
        '
        'TextBox79
        '
        Me.TextBox79.CanGrow = False
        Me.TextBox79.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.3342287540435791R), Telerik.Reporting.Drawing.Unit.Inch(0.73514866828918457R))
        Me.TextBox79.Name = "TextBox79"
        Me.TextBox79.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3008947372436523R), Telerik.Reporting.Drawing.Unit.Inch(0.54012888669967651R))
        Me.TextBox79.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox79.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox79.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox79.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox79.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox79.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox79.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox79.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox79.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox79.Value = "=ElecEquipDesc"
        '
        'TextBox80
        '
        Me.TextBox80.CanGrow = False
        Me.TextBox80.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.0333342552185059R), Telerik.Reporting.Drawing.Unit.Inch(0.73514866828918457R))
        Me.TextBox80.Name = "TextBox80"
        Me.TextBox80.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3008947372436523R), Telerik.Reporting.Drawing.Unit.Inch(0.54012888669967651R))
        Me.TextBox80.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox80.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox80.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox80.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox80.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox80.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox80.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox80.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox80.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox80.Value = "=MechEquipDesc"
        '
        'txtMechSysRating
        '
        Me.txtMechSysRating.Format = "{0:#.}"
        Me.txtMechSysRating.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.0333342552185059R), Telerik.Reporting.Drawing.Unit.Inch(0.53001946210861206R))
        Me.txtMechSysRating.Name = "txtMechSysRating"
        Me.txtMechSysRating.RatingCategory = GRC.Connect.Libraries.DataLib.razor.TblMetaRatingCategory.Categories.BMMechanicalSys
        Me.txtMechSysRating.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3008947372436523R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.txtMechSysRating.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.txtMechSysRating.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtMechSysRating.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtMechSysRating.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtMechSysRating.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtMechSysRating.Value = "=MechEquipC"
        '
        'txtElecSysRating
        '
        Me.txtElecSysRating.Format = "{0:#.}"
        Me.txtElecSysRating.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.3342287540435791R), Telerik.Reporting.Drawing.Unit.Inch(0.53001946210861206R))
        Me.txtElecSysRating.Name = "txtElecSysRating"
        Me.txtElecSysRating.RatingCategory = GRC.Connect.Libraries.DataLib.razor.TblMetaRatingCategory.Categories.BMElectricalSys
        Me.txtElecSysRating.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3008947372436523R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.txtElecSysRating.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.txtElecSysRating.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtElecSysRating.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtElecSysRating.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtElecSysRating.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtElecSysRating.Value = "=elecequipc"
        '
        'txtProdRating
        '
        Me.txtProdRating.Format = "{0:#.}"
        Me.txtProdRating.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.9360179901123047R), Telerik.Reporting.Drawing.Unit.Inch(0.53522777557373047R))
        Me.txtProdRating.Name = "txtProdRating"
        Me.txtProdRating.RatingCategory = GRC.Connect.Libraries.DataLib.razor.TblMetaRatingCategory.Categories.BMPPE
        Me.txtProdRating.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3008947372436523R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.txtProdRating.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.txtProdRating.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtProdRating.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtProdRating.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtProdRating.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtProdRating.Value = "=ProcEquipC"
        '
        'txtBoilerRating
        '
        Me.txtBoilerRating.Format = "{0:#.}"
        Me.txtBoilerRating.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.6351234912872314R), Telerik.Reporting.Drawing.Unit.Inch(0.53522777557373047R))
        Me.txtBoilerRating.Name = "txtBoilerRating"
        Me.txtBoilerRating.RatingCategory = GRC.Connect.Libraries.DataLib.razor.TblMetaRatingCategory.Categories.BMBPVT
        Me.txtBoilerRating.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3008947372436523R), Telerik.Reporting.Drawing.Unit.Inch(0.19999988377094269R))
        Me.txtBoilerRating.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.txtBoilerRating.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtBoilerRating.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtBoilerRating.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtBoilerRating.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtBoilerRating.Value = "=Boilersc"
        '
        'TextBox85
        '
        Me.TextBox85.Format = "{0:P0}"
        Me.TextBox85.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.6351234912872314R), Telerik.Reporting.Drawing.Unit.Inch(0.33522769808769226R))
        Me.TextBox85.Name = "TextBox85"
        Me.TextBox85.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3008947372436523R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox85.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox85.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox85.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox85.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox85.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox85.Value = "= CDbl([boilersweight]/10)"
        '
        'TextBox92
        '
        Me.TextBox92.Format = "{0:P0}"
        Me.TextBox92.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.9360179901123047R), Telerik.Reporting.Drawing.Unit.Inch(0.33522769808769226R))
        Me.TextBox92.Name = "TextBox92"
        Me.TextBox92.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3008947372436523R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox92.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox92.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox92.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox92.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox92.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox92.Value = "= CDbl([ProcEquipweight]/10)"
        '
        'TextBox93
        '
        Me.TextBox93.Format = "{0:P0}"
        Me.TextBox93.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.3342287540435791R), Telerik.Reporting.Drawing.Unit.Inch(0.33001935482025146R))
        Me.TextBox93.Name = "TextBox93"
        Me.TextBox93.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3008947372436523R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox93.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox93.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox93.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox93.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox93.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox93.Value = "= CDbl([elecequipweight]/10)"
        '
        'TextBox94
        '
        Me.TextBox94.Format = "{0:P0}"
        Me.TextBox94.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.0333342552185059R), Telerik.Reporting.Drawing.Unit.Inch(0.33001935482025146R))
        Me.TextBox94.Name = "TextBox94"
        Me.TextBox94.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3008947372436523R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox94.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox94.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox94.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox94.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox94.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox94.Value = "= CDbl([MechEquipWeight]/10)"
        '
        'TextBox95
        '
        Me.TextBox95.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.17916758358478546R), Telerik.Reporting.Drawing.Unit.Inch(0.73190855979919434R))
        Me.TextBox95.Name = "TextBox95"
        Me.TextBox95.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.83524131774902344R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox95.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox95.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox95.Style.Font.Bold = True
        Me.TextBox95.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox95.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox95.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox95.Value = "Description"
        '
        'TextBox96
        '
        Me.TextBox96.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.17916758358478546R), Telerik.Reporting.Drawing.Unit.Inch(0.53190779685974121R))
        Me.TextBox96.Name = "TextBox96"
        Me.TextBox96.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.83524131774902344R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox96.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox96.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox96.Style.Font.Bold = True
        Me.TextBox96.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox96.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox96.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox96.Value = "Rating"
        '
        'TextBox97
        '
        Me.TextBox97.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.17916758358478546R), Telerik.Reporting.Drawing.Unit.Inch(0.33190765976905823R))
        Me.TextBox97.Name = "TextBox97"
        Me.TextBox97.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.83524131774902344R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox97.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox97.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox97.Style.Font.Bold = True
        Me.TextBox97.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox97.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox97.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox97.Value = "Weight"
        '
        'TextBox98
        '
        Me.TextBox98.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.16875092685222626R), Telerik.Reporting.Drawing.Unit.Inch(1.3321765661239624R))
        Me.TextBox98.Name = "TextBox98"
        Me.TextBox98.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.83524131774902344R), Telerik.Reporting.Drawing.Unit.Inch(0.31458339095115662R))
        Me.TextBox98.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox98.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox98.Style.Font.Bold = True
        Me.TextBox98.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox98.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox98.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox98.Value = "Rating w/All Recs Compl'd"
        '
        'TextBox99
        '
        Me.TextBox99.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.16875092685222626R), Telerik.Reporting.Drawing.Unit.Inch(1.6467599868774414R))
        Me.TextBox99.Name = "TextBox99"
        Me.TextBox99.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.83524131774902344R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox99.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox99.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox99.Style.Font.Bold = True
        Me.TextBox99.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox99.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox99.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox99.Value = "Description"
        '
        'txtBoilerRatingRecs
        '
        Me.txtBoilerRatingRecs.Format = "{0:#.}"
        Me.txtBoilerRatingRecs.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.6351234912872314R), Telerik.Reporting.Drawing.Unit.Inch(1.3205751180648804R))
        Me.txtBoilerRatingRecs.Name = "txtBoilerRatingRecs"
        Me.txtBoilerRatingRecs.RatingCategory = GRC.Connect.Libraries.DataLib.razor.TblMetaRatingCategory.Categories.BMBPVTRecs
        Me.txtBoilerRatingRecs.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3008947372436523R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.txtBoilerRatingRecs.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.txtBoilerRatingRecs.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtBoilerRatingRecs.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtBoilerRatingRecs.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtBoilerRatingRecs.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtBoilerRatingRecs.Value = "=BoilersWr"
        '
        'txtProdRatingRecs
        '
        Me.txtProdRatingRecs.Format = "{0:#.}"
        Me.txtProdRatingRecs.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.9360179901123047R), Telerik.Reporting.Drawing.Unit.Inch(1.3205751180648804R))
        Me.txtProdRatingRecs.Name = "txtProdRatingRecs"
        Me.txtProdRatingRecs.RatingCategory = GRC.Connect.Libraries.DataLib.razor.TblMetaRatingCategory.Categories.BMPPERecs
        Me.txtProdRatingRecs.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3008947372436523R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.txtProdRatingRecs.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.txtProdRatingRecs.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtProdRatingRecs.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtProdRatingRecs.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtProdRatingRecs.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtProdRatingRecs.Value = "=ProcEquipWr"
        '
        'txtElecSysRatingRecs
        '
        Me.txtElecSysRatingRecs.Format = "{0:#.}"
        Me.txtElecSysRatingRecs.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.3342287540435791R), Telerik.Reporting.Drawing.Unit.Inch(1.3205751180648804R))
        Me.txtElecSysRatingRecs.Name = "txtElecSysRatingRecs"
        Me.txtElecSysRatingRecs.RatingCategory = GRC.Connect.Libraries.DataLib.razor.TblMetaRatingCategory.Categories.BMElectricalSysRecs
        Me.txtElecSysRatingRecs.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3008947372436523R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.txtElecSysRatingRecs.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.txtElecSysRatingRecs.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtElecSysRatingRecs.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtElecSysRatingRecs.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtElecSysRatingRecs.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtElecSysRatingRecs.Value = "=ElecEquipWr"
        '
        'txtMechSysRatingRecs
        '
        Me.txtMechSysRatingRecs.Format = "{0:#.}"
        Me.txtMechSysRatingRecs.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.0333342552185059R), Telerik.Reporting.Drawing.Unit.Inch(1.3205751180648804R))
        Me.txtMechSysRatingRecs.Name = "txtMechSysRatingRecs"
        Me.txtMechSysRatingRecs.RatingCategory = GRC.Connect.Libraries.DataLib.razor.TblMetaRatingCategory.Categories.BMMechanicalSysRecs
        Me.txtMechSysRatingRecs.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3008947372436523R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.txtMechSysRatingRecs.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.txtMechSysRatingRecs.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtMechSysRatingRecs.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtMechSysRatingRecs.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtMechSysRatingRecs.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtMechSysRatingRecs.Value = "=MechEquipWR"
        '
        'TextBox112
        '
        Me.TextBox112.CanGrow = False
        Me.TextBox112.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.0333342552185059R), Telerik.Reporting.Drawing.Unit.Inch(1.5205751657485962R))
        Me.TextBox112.Name = "TextBox112"
        Me.TextBox112.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3008947372436523R), Telerik.Reporting.Drawing.Unit.Inch(0.54012888669967651R))
        Me.TextBox112.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox112.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox112.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox112.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox112.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox112.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox112.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox112.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox112.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox112.Value = "=MechEquipWRDesc"
        '
        'TextBox113
        '
        Me.TextBox113.CanGrow = False
        Me.TextBox113.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.3342287540435791R), Telerik.Reporting.Drawing.Unit.Inch(1.5205751657485962R))
        Me.TextBox113.Name = "TextBox113"
        Me.TextBox113.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3008947372436523R), Telerik.Reporting.Drawing.Unit.Inch(0.54012888669967651R))
        Me.TextBox113.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox113.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox113.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox113.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox113.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox113.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox113.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox113.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox113.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox113.Value = "=ElecEquipWrdesc"
        '
        'TextBox114
        '
        Me.TextBox114.CanGrow = False
        Me.TextBox114.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.9360179901123047R), Telerik.Reporting.Drawing.Unit.Inch(1.5205751657485962R))
        Me.TextBox114.Name = "TextBox114"
        Me.TextBox114.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3008947372436523R), Telerik.Reporting.Drawing.Unit.Inch(0.54012888669967651R))
        Me.TextBox114.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox114.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox114.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox114.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox114.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox114.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox114.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox114.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox114.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox114.Value = "=ProcEquipWrDesc"
        '
        'TextBox115
        '
        Me.TextBox115.CanGrow = False
        Me.TextBox115.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.6351234912872314R), Telerik.Reporting.Drawing.Unit.Inch(1.5205749273300171R))
        Me.TextBox115.Name = "TextBox115"
        Me.TextBox115.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3008947372436523R), Telerik.Reporting.Drawing.Unit.Inch(0.54012888669967651R))
        Me.TextBox115.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox115.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox115.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox115.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox115.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox115.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox115.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox115.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox115.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox115.Value = "=BoilersWrDesc"
        '
        'TextBox30
        '
        Me.TextBox30.CanGrow = False
        Me.TextBox30.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.2369132041931152R), Telerik.Reporting.Drawing.Unit.Inch(1.5205751657485962R))
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3008947372436523R), Telerik.Reporting.Drawing.Unit.Inch(0.54012888669967651R))
        Me.TextBox30.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox30.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox30.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox30.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox30.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox30.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox30.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox30.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox30.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox30.Value = "=OccupancyWrDesc"
        '
        'TextBox31
        '
        Me.TextBox31.CanGrow = False
        Me.TextBox31.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.5378074645996094R), Telerik.Reporting.Drawing.Unit.Inch(1.5205750465393066R))
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.631252646446228R), Telerik.Reporting.Drawing.Unit.Inch(0.54012888669967651R))
        Me.TextBox31.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox31.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox31.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox31.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox31.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox31.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox31.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox31.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox31.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox31.Value = "=Compsyswrdesc"
        '
        'txtCompSysRatingRecs
        '
        Me.txtCompSysRatingRecs.Format = "{0:#.}"
        Me.txtCompSysRatingRecs.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.5378074645996094R), Telerik.Reporting.Drawing.Unit.Inch(1.3205751180648804R))
        Me.txtCompSysRatingRecs.Name = "txtCompSysRatingRecs"
        Me.txtCompSysRatingRecs.RatingCategory = GRC.Connect.Libraries.DataLib.razor.TblMetaRatingCategory.Categories.BMComputerSysRecs
        Me.txtCompSysRatingRecs.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.631252646446228R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.txtCompSysRatingRecs.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.txtCompSysRatingRecs.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtCompSysRatingRecs.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtCompSysRatingRecs.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtCompSysRatingRecs.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtCompSysRatingRecs.Value = "=CompsysWR"
        '
        'txtOccupancyRatingRecs
        '
        Me.txtOccupancyRatingRecs.Format = "{0:#.}"
        Me.txtOccupancyRatingRecs.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.2369132041931152R), Telerik.Reporting.Drawing.Unit.Inch(1.3205751180648804R))
        Me.txtOccupancyRatingRecs.Name = "txtOccupancyRatingRecs"
        Me.txtOccupancyRatingRecs.RatingCategory = GRC.Connect.Libraries.DataLib.razor.TblMetaRatingCategory.Categories.BMOccupancyRecs
        Me.txtOccupancyRatingRecs.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3008947372436523R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.txtOccupancyRatingRecs.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.txtOccupancyRatingRecs.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtOccupancyRatingRecs.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtOccupancyRatingRecs.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtOccupancyRatingRecs.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtOccupancyRatingRecs.Value = "=OccupancyWr"
        '
        'TextBox35
        '
        Me.TextBox35.Format = "{0:P0}"
        Me.TextBox35.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.5378074645996094R), Telerik.Reporting.Drawing.Unit.Inch(0.33514854311943054R))
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.631252646446228R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox35.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox35.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox35.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox35.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox35.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox35.Value = "= CDbl([CompSysweight]/10)"
        '
        'TextBox36
        '
        Me.TextBox36.Format = "{0:P0}"
        Me.TextBox36.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.2369132041931152R), Telerik.Reporting.Drawing.Unit.Inch(0.33514854311943054R))
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3008947372436523R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox36.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox36.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox36.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox36.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox36.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox36.Value = "=CDbl([occupancyweight]/10)"
        '
        'txtOccupancyRating
        '
        Me.txtOccupancyRating.Format = "{0:#.}"
        Me.txtOccupancyRating.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.2369132041931152R), Telerik.Reporting.Drawing.Unit.Inch(0.53514862060546875R))
        Me.txtOccupancyRating.Name = "txtOccupancyRating"
        Me.txtOccupancyRating.RatingCategory = GRC.Connect.Libraries.DataLib.razor.TblMetaRatingCategory.Categories.BMOccupancy
        Me.txtOccupancyRating.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3008947372436523R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.txtOccupancyRating.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.txtOccupancyRating.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtOccupancyRating.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtOccupancyRating.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtOccupancyRating.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtOccupancyRating.Value = "=OccupancyC"
        '
        'txtCompSysRating
        '
        Me.txtCompSysRating.Format = "{0:#.}"
        Me.txtCompSysRating.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.5378074645996094R), Telerik.Reporting.Drawing.Unit.Inch(0.53514862060546875R))
        Me.txtCompSysRating.Name = "txtCompSysRating"
        Me.txtCompSysRating.RatingCategory = GRC.Connect.Libraries.DataLib.razor.TblMetaRatingCategory.Categories.BMComputerSys
        Me.txtCompSysRating.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.631252646446228R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.txtCompSysRating.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.txtCompSysRating.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtCompSysRating.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtCompSysRating.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtCompSysRating.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtCompSysRating.Value = "=CompsysC"
        '
        'TextBox50
        '
        Me.TextBox50.CanGrow = False
        Me.TextBox50.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.5378074645996094R), Telerik.Reporting.Drawing.Unit.Inch(0.73514866828918457R))
        Me.TextBox50.Name = "TextBox50"
        Me.TextBox50.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.631252646446228R), Telerik.Reporting.Drawing.Unit.Inch(0.54012888669967651R))
        Me.TextBox50.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox50.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox50.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox50.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox50.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox50.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox50.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox50.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox50.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox50.Value = "=Compsysdesc"
        '
        'TextBox51
        '
        Me.TextBox51.CanGrow = False
        Me.TextBox51.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.2369132041931152R), Telerik.Reporting.Drawing.Unit.Inch(0.73514866828918457R))
        Me.TextBox51.Name = "TextBox51"
        Me.TextBox51.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3008947372436523R), Telerik.Reporting.Drawing.Unit.Inch(0.54012888669967651R))
        Me.TextBox51.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox51.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox51.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox51.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox51.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox51.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox51.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox51.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox51.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox51.Value = "=OccupancyDesc"
        '
        'TextBox53
        '
        Me.TextBox53.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.2369132041931152R), Telerik.Reporting.Drawing.Unit.Inch(0.02473173476755619R))
        Me.TextBox53.Name = "TextBox53"
        Me.TextBox53.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3008947372436523R), Telerik.Reporting.Drawing.Unit.Inch(0.30520915985107422R))
        Me.TextBox53.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox53.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox53.Style.Font.Bold = True
        Me.TextBox53.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox53.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox53.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox53.Value = "Occupancy"
        '
        'TextBox54
        '
        Me.TextBox54.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.5378074645996094R), Telerik.Reporting.Drawing.Unit.Inch(0.02473173476755619R))
        Me.TextBox54.Name = "TextBox54"
        Me.TextBox54.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.631252646446228R), Telerik.Reporting.Drawing.Unit.Inch(0.30520915985107422R))
        Me.TextBox54.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox54.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox54.Style.Font.Bold = True
        Me.TextBox54.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox54.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox54.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox54.Value = "Computer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Systems"
        '
        'Panel3
        '
        Me.Panel3.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox19, Me.TextBox20, Me.TextBox21, Me.TextBox22, Me.TextBox23, Me.TextBox24, Me.TextBox25, Me.TextBox26, Me.TextBox27, Me.TextBox28, Me.TextBox29, Me.TextBox34, Me.txtMechMaintRating, Me.txtElecMaintRating, Me.txtHeRating, Me.txtCriticalSparesRating, Me.TextBox43, Me.TextBox44, Me.TextBox45, Me.TextBox57, Me.TextBox58, Me.TextBox59, Me.TextBox60, Me.TextBox61, Me.TextBox62, Me.txtCriticalSparesRatingRecs, Me.txtHeRatingRecs, Me.txtElecMaintRatingRecs, Me.txtMechMaintRatingRecs, Me.TextBox67, Me.TextBox68, Me.TextBox77, Me.TextBox78, Me.TextBox86, Me.txtBcpRatingRecs, Me.TextBox91, Me.txtBcpRating, Me.TextBox106, Me.TextBox107})
        Me.Panel3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(3.3003149032592773R))
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(10.427318572998047R), Telerik.Reporting.Drawing.Unit.Inch(2.1289899349212646R))
        Me.Panel3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel3.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        '
        'TextBox19
        '
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.3841848373413086R), Telerik.Reporting.Drawing.Unit.Inch(0.83580684661865234R))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.80285263061523438R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox19.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox19.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox19.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox19.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox19.Value = "=ActiveC"
        '
        'TextBox20
        '
        Me.TextBox20.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.3841848373413086R), Telerik.Reporting.Drawing.Unit.Inch(0.3961435854434967R))
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.8028524518013R), Telerik.Reporting.Drawing.Unit.Inch(0.43958339095115662R))
        Me.TextBox20.Style.Font.Bold = True
        Me.TextBox20.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox20.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox20.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox20.Value = "Total " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Score:"
        '
        'TextBox21
        '
        Me.TextBox21.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.367518424987793R), Telerik.Reporting.Drawing.Unit.Inch(1.4019311666488647R))
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.81951886415481567R), Telerik.Reporting.Drawing.Unit.Inch(0.43958339095115662R))
        Me.TextBox21.Style.Font.Bold = True
        Me.TextBox21.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox21.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox21.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox21.Value = "Total " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Score w/Recs "
        '
        'TextBox22
        '
        Me.TextBox22.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.367518424987793R), Telerik.Reporting.Drawing.Unit.Inch(1.8498481512069702R))
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.81951904296875R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox22.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox22.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox22.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox22.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox22.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox22.Value = "=ActiveWc"
        '
        'TextBox23
        '
        Me.TextBox23.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.0437508821487427R), Telerik.Reporting.Drawing.Unit.Inch(0.035148400813341141R))
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3818345069885254R), Telerik.Reporting.Drawing.Unit.Inch(0.30520915985107422R))
        Me.TextBox23.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox23.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox23.Style.Font.Bold = True
        Me.TextBox23.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox23.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox23.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox23.Value = "Mech. Prev./Pred" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Maintenance"
        '
        'TextBox24
        '
        Me.TextBox24.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.4256641864776611R), Telerik.Reporting.Drawing.Unit.Inch(0.035148400813341141R))
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7802956104278564R), Telerik.Reporting.Drawing.Unit.Inch(0.30520915985107422R))
        Me.TextBox24.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox24.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox24.Style.Font.Bold = True
        Me.TextBox24.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox24.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox24.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox24.Value = "Elect. Prev./ Pred." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Maintenance"
        '
        'TextBox25
        '
        Me.TextBox25.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.8674111366271973R), Telerik.Reporting.Drawing.Unit.Inch(0.035148400813341141R))
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.641406774520874R), Telerik.Reporting.Drawing.Unit.Inch(0.30520915985107422R))
        Me.TextBox25.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox25.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox25.Style.Font.Bold = True
        Me.TextBox25.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox25.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox25.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox25.Value = "Human Element"
        '
        'TextBox26
        '
        Me.TextBox26.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.2126717567443848R), Telerik.Reporting.Drawing.Unit.Inch(0.035148400813341141R))
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6529809236526489R), Telerik.Reporting.Drawing.Unit.Inch(0.30520915985107422R))
        Me.TextBox26.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox26.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox26.Style.Font.Bold = True
        Me.TextBox26.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox26.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox26.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox26.Value = "Critical Spares"
        '
        'TextBox27
        '
        Me.TextBox27.CanGrow = False
        Me.TextBox27.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.2126717567443848R), Telerik.Reporting.Drawing.Unit.Inch(0.7404361367225647R))
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6529809236526489R), Telerik.Reporting.Drawing.Unit.Inch(0.54012888669967651R))
        Me.TextBox27.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox27.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox27.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox27.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox27.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox27.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox27.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox27.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox27.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox27.Value = "=SparesDesc"
        '
        'TextBox28
        '
        Me.TextBox28.CanGrow = False
        Me.TextBox28.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.8674111366271973R), Telerik.Reporting.Drawing.Unit.Inch(0.7404361367225647R))
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.641406774520874R), Telerik.Reporting.Drawing.Unit.Inch(0.54012888669967651R))
        Me.TextBox28.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox28.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox28.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox28.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox28.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox28.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox28.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox28.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox28.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox28.Value = "=HumanElementDesc"
        '
        'TextBox29
        '
        Me.TextBox29.CanGrow = False
        Me.TextBox29.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.4256641864776611R), Telerik.Reporting.Drawing.Unit.Inch(0.7404361367225647R))
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7802956104278564R), Telerik.Reporting.Drawing.Unit.Inch(0.54012888669967651R))
        Me.TextBox29.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox29.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox29.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox29.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox29.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox29.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox29.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox29.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox29.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox29.Value = "=ElecMaintDesc"
        '
        'TextBox34
        '
        Me.TextBox34.CanGrow = False
        Me.TextBox34.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.0437508821487427R), Telerik.Reporting.Drawing.Unit.Inch(0.7404361367225647R))
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3818345069885254R), Telerik.Reporting.Drawing.Unit.Inch(0.54012888669967651R))
        Me.TextBox34.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox34.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox34.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox34.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox34.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox34.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox34.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox34.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox34.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox34.Value = "=MechMaintDesc"
        '
        'txtMechMaintRating
        '
        Me.txtMechMaintRating.Format = "{0:#.}"
        Me.txtMechMaintRating.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.0437508821487427R), Telerik.Reporting.Drawing.Unit.Inch(0.54043608903884888R))
        Me.txtMechMaintRating.Name = "txtMechMaintRating"
        Me.txtMechMaintRating.RatingCategory = GRC.Connect.Libraries.DataLib.razor.TblMetaRatingCategory.Categories.BMMPPM
        Me.txtMechMaintRating.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3818345069885254R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.txtMechMaintRating.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.txtMechMaintRating.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtMechMaintRating.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtMechMaintRating.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtMechMaintRating.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtMechMaintRating.Value = "=MechMaintC"
        '
        'txtElecMaintRating
        '
        Me.txtElecMaintRating.Format = "{0:#.}"
        Me.txtElecMaintRating.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.4256641864776611R), Telerik.Reporting.Drawing.Unit.Inch(0.54043608903884888R))
        Me.txtElecMaintRating.Name = "txtElecMaintRating"
        Me.txtElecMaintRating.RatingCategory = GRC.Connect.Libraries.DataLib.razor.TblMetaRatingCategory.Categories.BMEPPM
        Me.txtElecMaintRating.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7802956104278564R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.txtElecMaintRating.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.txtElecMaintRating.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtElecMaintRating.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtElecMaintRating.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtElecMaintRating.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtElecMaintRating.Value = "=ElecMaintC"
        '
        'txtHeRating
        '
        Me.txtHeRating.Format = "{0:#.}"
        Me.txtHeRating.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.8674111366271973R), Telerik.Reporting.Drawing.Unit.Inch(0.54043608903884888R))
        Me.txtHeRating.Name = "txtHeRating"
        Me.txtHeRating.RatingCategory = GRC.Connect.Libraries.DataLib.razor.TblMetaRatingCategory.Categories.BMHumanElement
        Me.txtHeRating.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.641406774520874R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.txtHeRating.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.txtHeRating.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtHeRating.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtHeRating.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtHeRating.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtHeRating.Value = "=HumanElementC"
        '
        'txtCriticalSparesRating
        '
        Me.txtCriticalSparesRating.Format = "{0:#.}"
        Me.txtCriticalSparesRating.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.2126717567443848R), Telerik.Reporting.Drawing.Unit.Inch(0.54043608903884888R))
        Me.txtCriticalSparesRating.Name = "txtCriticalSparesRating"
        Me.txtCriticalSparesRating.RatingCategory = GRC.Connect.Libraries.DataLib.razor.TblMetaRatingCategory.Categories.BMCriticalSpaces
        Me.txtCriticalSparesRating.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6529809236526489R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.txtCriticalSparesRating.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.txtCriticalSparesRating.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtCriticalSparesRating.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtCriticalSparesRating.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtCriticalSparesRating.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtCriticalSparesRating.Value = "=SparesC"
        '
        'TextBox43
        '
        Me.TextBox43.Format = "{0:P0}"
        Me.TextBox43.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.2126717567443848R), Telerik.Reporting.Drawing.Unit.Inch(0.34043601155281067R))
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6529809236526489R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox43.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox43.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox43.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox43.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox43.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox43.Value = "= CDbl([Sparesweight]/10)"
        '
        'TextBox44
        '
        Me.TextBox44.Format = "{0:P0}"
        Me.TextBox44.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.8674111366271973R), Telerik.Reporting.Drawing.Unit.Inch(0.34043601155281067R))
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.641406774520874R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox44.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox44.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox44.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox44.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox44.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox44.Value = "= CDbl([HumanElementweight]/10)"
        '
        'TextBox45
        '
        Me.TextBox45.Format = "{0:P0}"
        Me.TextBox45.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.4256641864776611R), Telerik.Reporting.Drawing.Unit.Inch(0.34043601155281067R))
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7802956104278564R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox45.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox45.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox45.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox45.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox45.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox45.Value = "= CDbl([ElecMaintweight]/10)"
        '
        'TextBox57
        '
        Me.TextBox57.Format = "{0:P0}"
        Me.TextBox57.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.0437508821487427R), Telerik.Reporting.Drawing.Unit.Inch(0.34043601155281067R))
        Me.TextBox57.Name = "TextBox57"
        Me.TextBox57.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3818345069885254R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox57.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox57.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox57.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox57.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox57.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox57.Value = "= CDbl([MechMaintweight]/10)"
        '
        'TextBox58
        '
        Me.TextBox58.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.18958425521850586R), Telerik.Reporting.Drawing.Unit.Inch(0.74232524633407593R))
        Me.TextBox58.Name = "TextBox58"
        Me.TextBox58.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.83524131774902344R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox58.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox58.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox58.Style.Font.Bold = True
        Me.TextBox58.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox58.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox58.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox58.Value = "Description"
        '
        'TextBox59
        '
        Me.TextBox59.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.18958425521850586R), Telerik.Reporting.Drawing.Unit.Inch(0.5423244833946228R))
        Me.TextBox59.Name = "TextBox59"
        Me.TextBox59.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.83524131774902344R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox59.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox59.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox59.Style.Font.Bold = True
        Me.TextBox59.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox59.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox59.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox59.Value = "Rating"
        '
        'TextBox60
        '
        Me.TextBox60.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.18958425521850586R), Telerik.Reporting.Drawing.Unit.Inch(0.34232434630393982R))
        Me.TextBox60.Name = "TextBox60"
        Me.TextBox60.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.83524131774902344R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox60.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox60.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox60.Style.Font.Bold = True
        Me.TextBox60.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox60.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox60.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox60.Value = "Weight"
        '
        'TextBox61
        '
        Me.TextBox61.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.17916758358478546R), Telerik.Reporting.Drawing.Unit.Inch(1.3321765661239624R))
        Me.TextBox61.Name = "TextBox61"
        Me.TextBox61.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.83524131774902344R), Telerik.Reporting.Drawing.Unit.Inch(0.31458339095115662R))
        Me.TextBox61.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox61.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox61.Style.Font.Bold = True
        Me.TextBox61.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox61.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox61.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox61.Value = "Rating w/All Recs Compl'd"
        '
        'TextBox62
        '
        Me.TextBox62.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.17916758358478546R), Telerik.Reporting.Drawing.Unit.Inch(1.6467599868774414R))
        Me.TextBox62.Name = "TextBox62"
        Me.TextBox62.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.83524131774902344R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox62.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox62.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox62.Style.Font.Bold = True
        Me.TextBox62.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox62.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox62.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox62.Value = "Description"
        '
        'txtCriticalSparesRatingRecs
        '
        Me.txtCriticalSparesRatingRecs.Format = "{0:#.}"
        Me.txtCriticalSparesRatingRecs.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.2126717567443848R), Telerik.Reporting.Drawing.Unit.Inch(1.3205751180648804R))
        Me.txtCriticalSparesRatingRecs.Name = "txtCriticalSparesRatingRecs"
        Me.txtCriticalSparesRatingRecs.RatingCategory = GRC.Connect.Libraries.DataLib.razor.TblMetaRatingCategory.Categories.BMCriticalSpacesRecs
        Me.txtCriticalSparesRatingRecs.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6529809236526489R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.txtCriticalSparesRatingRecs.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.txtCriticalSparesRatingRecs.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtCriticalSparesRatingRecs.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtCriticalSparesRatingRecs.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtCriticalSparesRatingRecs.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtCriticalSparesRatingRecs.Value = "=SparesWR"
        '
        'txtHeRatingRecs
        '
        Me.txtHeRatingRecs.Format = "{0:#.}"
        Me.txtHeRatingRecs.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.8674111366271973R), Telerik.Reporting.Drawing.Unit.Inch(1.3205751180648804R))
        Me.txtHeRatingRecs.Name = "txtHeRatingRecs"
        Me.txtHeRatingRecs.RatingCategory = GRC.Connect.Libraries.DataLib.razor.TblMetaRatingCategory.Categories.BMHumanElementRecs
        Me.txtHeRatingRecs.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6518259048461914R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.txtHeRatingRecs.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.txtHeRatingRecs.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtHeRatingRecs.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtHeRatingRecs.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtHeRatingRecs.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtHeRatingRecs.Value = "=HumanElementWR"
        '
        'txtElecMaintRatingRecs
        '
        Me.txtElecMaintRatingRecs.Format = "{0:#.}"
        Me.txtElecMaintRatingRecs.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.4256641864776611R), Telerik.Reporting.Drawing.Unit.Inch(1.3205751180648804R))
        Me.txtElecMaintRatingRecs.Name = "txtElecMaintRatingRecs"
        Me.txtElecMaintRatingRecs.RatingCategory = GRC.Connect.Libraries.DataLib.razor.TblMetaRatingCategory.Categories.BMEPPMRecs
        Me.txtElecMaintRatingRecs.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7802956104278564R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.txtElecMaintRatingRecs.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.txtElecMaintRatingRecs.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtElecMaintRatingRecs.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtElecMaintRatingRecs.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtElecMaintRatingRecs.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtElecMaintRatingRecs.Value = "=ElecMaintwr"
        '
        'txtMechMaintRatingRecs
        '
        Me.txtMechMaintRatingRecs.Format = "{0:#.}"
        Me.txtMechMaintRatingRecs.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.0437508821487427R), Telerik.Reporting.Drawing.Unit.Inch(1.3205751180648804R))
        Me.txtMechMaintRatingRecs.Name = "txtMechMaintRatingRecs"
        Me.txtMechMaintRatingRecs.RatingCategory = GRC.Connect.Libraries.DataLib.razor.TblMetaRatingCategory.Categories.BMMPPMRecs
        Me.txtMechMaintRatingRecs.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3818345069885254R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.txtMechMaintRatingRecs.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.txtMechMaintRatingRecs.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtMechMaintRatingRecs.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtMechMaintRatingRecs.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtMechMaintRatingRecs.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtMechMaintRatingRecs.Value = "=MechMaintWR"
        '
        'TextBox67
        '
        Me.TextBox67.CanGrow = False
        Me.TextBox67.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.0437508821487427R), Telerik.Reporting.Drawing.Unit.Inch(1.5205751657485962R))
        Me.TextBox67.Name = "TextBox67"
        Me.TextBox67.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3818345069885254R), Telerik.Reporting.Drawing.Unit.Inch(0.54012888669967651R))
        Me.TextBox67.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox67.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox67.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox67.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox67.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox67.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox67.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox67.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox67.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox67.Value = "=MechMaintWRDesc"
        '
        'TextBox68
        '
        Me.TextBox68.CanGrow = False
        Me.TextBox68.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.4256641864776611R), Telerik.Reporting.Drawing.Unit.Inch(1.5205751657485962R))
        Me.TextBox68.Name = "TextBox68"
        Me.TextBox68.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7802956104278564R), Telerik.Reporting.Drawing.Unit.Inch(0.54012888669967651R))
        Me.TextBox68.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox68.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox68.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox68.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox68.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox68.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox68.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox68.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox68.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox68.Value = "=ElecMaintWRDesc"
        '
        'TextBox77
        '
        Me.TextBox77.CanGrow = False
        Me.TextBox77.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.8674111366271973R), Telerik.Reporting.Drawing.Unit.Inch(1.5205751657485962R))
        Me.TextBox77.Name = "TextBox77"
        Me.TextBox77.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6518259048461914R), Telerik.Reporting.Drawing.Unit.Inch(0.54012888669967651R))
        Me.TextBox77.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox77.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox77.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox77.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox77.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox77.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox77.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox77.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox77.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox77.Value = "=HumanElementWRDesc"
        '
        'TextBox78
        '
        Me.TextBox78.CanGrow = False
        Me.TextBox78.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.2126717567443848R), Telerik.Reporting.Drawing.Unit.Inch(1.5205751657485962R))
        Me.TextBox78.Name = "TextBox78"
        Me.TextBox78.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6529809236526489R), Telerik.Reporting.Drawing.Unit.Inch(0.54012888669967651R))
        Me.TextBox78.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox78.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox78.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox78.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox78.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox78.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox78.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox78.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox78.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox78.Value = "=SparesWRDesc"
        '
        'TextBox86
        '
        Me.TextBox86.CanGrow = False
        Me.TextBox86.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.51931619644165R), Telerik.Reporting.Drawing.Unit.Inch(1.5205755233764648R))
        Me.TextBox86.Name = "TextBox86"
        Me.TextBox86.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6705765724182129R), Telerik.Reporting.Drawing.Unit.Inch(0.54012888669967651R))
        Me.TextBox86.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox86.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox86.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox86.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox86.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox86.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox86.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox86.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox86.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox86.Value = "=bcpwrdesc"
        '
        'txtBcpRatingRecs
        '
        Me.txtBcpRatingRecs.Format = "{0:#.}"
        Me.txtBcpRatingRecs.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.51931619644165R), Telerik.Reporting.Drawing.Unit.Inch(1.32057523727417R))
        Me.txtBcpRatingRecs.Name = "txtBcpRatingRecs"
        Me.txtBcpRatingRecs.RatingCategory = GRC.Connect.Libraries.DataLib.razor.TblMetaRatingCategory.Categories.BMBCPRecs
        Me.txtBcpRatingRecs.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6705765724182129R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.txtBcpRatingRecs.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.txtBcpRatingRecs.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtBcpRatingRecs.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtBcpRatingRecs.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtBcpRatingRecs.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtBcpRatingRecs.Value = "=bcpwr"
        '
        'TextBox91
        '
        Me.TextBox91.Format = "{0:P0}"
        Me.TextBox91.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.5088996887207031R), Telerik.Reporting.Drawing.Unit.Inch(0.34043610095977783R))
        Me.TextBox91.Name = "TextBox91"
        Me.TextBox91.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6705765724182129R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox91.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox91.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox91.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox91.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox91.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox91.Value = "= CDbl([BCPweight]/10)"
        '
        'txtBcpRating
        '
        Me.txtBcpRating.Format = "{0:#.}"
        Me.txtBcpRating.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.5088996887207031R), Telerik.Reporting.Drawing.Unit.Inch(0.54043608903884888R))
        Me.txtBcpRating.Name = "txtBcpRating"
        Me.txtBcpRating.RatingCategory = GRC.Connect.Libraries.DataLib.razor.TblMetaRatingCategory.Categories.BMBCP
        Me.txtBcpRating.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6705765724182129R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.txtBcpRating.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.txtBcpRating.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtBcpRating.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtBcpRating.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtBcpRating.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtBcpRating.Value = "=bcpC"
        '
        'TextBox106
        '
        Me.TextBox106.CanGrow = False
        Me.TextBox106.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.5088996887207031R), Telerik.Reporting.Drawing.Unit.Inch(0.74043649435043335R))
        Me.TextBox106.Name = "TextBox106"
        Me.TextBox106.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6705765724182129R), Telerik.Reporting.Drawing.Unit.Inch(0.54012888669967651R))
        Me.TextBox106.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox106.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox106.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.TextBox106.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox106.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox106.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox106.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox106.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox106.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox106.Value = "=BCpdesc"
        '
        'TextBox107
        '
        Me.TextBox107.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.5088996887207031R), Telerik.Reporting.Drawing.Unit.Inch(0.035148549824953079R))
        Me.TextBox107.Name = "TextBox107"
        Me.TextBox107.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6705765724182129R), Telerik.Reporting.Drawing.Unit.Inch(0.30520915985107422R))
        Me.TextBox107.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox107.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox107.Style.Font.Bold = True
        Me.TextBox107.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox107.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox107.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox107.Value = "Business Continuity" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Planning"
        '
        'TextBox18
        '
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.052585829049348831R), Telerik.Reporting.Drawing.Unit.Inch(3.2343423366546631R))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.92037045955657959R), Telerik.Reporting.Drawing.Unit.Inch(0.4063296914100647R))
        Me.TextBox18.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox18.Style.Font.Bold = True
        Me.TextBox18.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox18.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(3.0R)
        Me.TextBox18.Value = "Management" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Programs:"
        '
        'TextBox46
        '
        Me.TextBox46.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.058372814208269119R), Telerik.Reporting.Drawing.Unit.Inch(1.009804368019104R))
        Me.TextBox46.Name = "TextBox46"
        Me.TextBox46.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.63333350419998169R), Telerik.Reporting.Drawing.Unit.Inch(0.37679916620254517R))
        Me.TextBox46.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox46.Style.Font.Bold = True
        Me.TextBox46.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox46.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(3.0R)
        Me.TextBox46.Value = "Physical " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Assets:"
        '
        'Panel6
        '
        Me.Panel6.CanShrink = True
        Me.Panel6.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.uxRatingKeyTable})
        Me.Panel6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.7502355575561523R), Telerik.Reporting.Drawing.Unit.Inch(5.518951416015625R))
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6770833730697632R), Telerik.Reporting.Drawing.Unit.Inch(0.82555007934570313R))
        '
        'uxRatingKeyTable
        '
        Me.uxRatingKeyTable.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.6770833730697632R)))
        Me.uxRatingKeyTable.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(0.17708331346511841R)))
        Me.uxRatingKeyTable.Body.SetCellContent(0, 0, Me.TextBox32)
        TableGroup1.Name = "tableGroup2"
        TableGroup1.ReportItem = Me.uxRatingKeyHeader
        Me.uxRatingKeyTable.ColumnGroups.Add(TableGroup1)
        Me.uxRatingKeyTable.Docking = Telerik.Reporting.DockingStyle.Top
        Me.uxRatingKeyTable.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox32, Me.uxRatingKeyHeader})
        Me.uxRatingKeyTable.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.uxRatingKeyTable.Name = "uxRatingKeyTable"
        TableGroup2.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup2.Name = "detailTableGroup1"
        Me.uxRatingKeyTable.RowGroups.Add(TableGroup2)
        Me.uxRatingKeyTable.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6770833730697632R), Telerik.Reporting.Drawing.Unit.Inch(0.3645833432674408R))
        Me.uxRatingKeyTable.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.uxRatingKeyTable.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.uxRatingKeyTable.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.uxRatingKeyTable.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.uxRatingKeyTable.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        '
        'TextBox32
        '
        Me.TextBox32.Bindings.Add(New Telerik.Reporting.Binding("Style.BackgroundColor", "=colHexBackColor"))
        Me.TextBox32.Bindings.Add(New Telerik.Reporting.Binding("Style.Color", "=colHexForeColor"))
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6770833730697632R), Telerik.Reporting.Drawing.Unit.Inch(0.1770833432674408R))
        Me.TextBox32.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox32.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox32.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox32.Value = "=colFldDescription"
        '
        'BoilerFacilityRatingReport
        '
        Group1.Name = "BaseGroupLogo"
        Group2.Name = "BaseGroupAltReportTitle"
        Group3.Name = "BaseGroupFilter"
        Group4.Name = "BaseGroupLogo"
        Group5.Name = "BaseGroupAltReportTitle"
        Group6.Name = "BaseGroupFilter"
        Group7.Name = "BaseGroupLogo"
        Group8.Name = "BaseGroupAltReportTitle"
        Group9.Name = "BaseGroupFilter"
        Group10.Name = "BaseGroupLogo"
        Group11.Name = "BaseGroupAltReportTitle"
        Group12.Name = "BaseGroupFilter"
        Group13.Name = "BaseGroupLogo"
        Group14.Name = "BaseGroupAltReportTitle"
        Group15.Name = "BaseGroupFilter"
        Group16.Name = "BaseGroupLogo"
        Group17.Name = "BaseGroupAltReportTitle"
        Group18.Name = "BaseGroupFilter"
        Group19.Name = "BaseGroupLogo"
        Group20.Name = "BaseGroupAltReportTitle"
        Group21.Name = "BaseGroupFilter"
        Group22.Name = "BaseGroupLogo"
        Group23.Name = "BaseGroupAltReportTitle"
        Group24.Name = "BaseGroupFilter"
        Group25.Name = "BaseGroupLogo"
        Group26.Name = "BaseGroupAltReportTitle"
        Group27.Name = "BaseGroupFilter"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1, Group2, Group3, Group4, Group5, Group6, Group7, Group8, Group9, Group10, Group11, Group12, Group13, Group14, Group15, Group16, Group17, Group18, Group19, Group20, Group21, Group22, Group23, Group24, Group25, Group26, Group27})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.detail})
        Me.Name = "FireFacilityRatingReport"
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.25R), Telerik.Reporting.Drawing.Unit.Inch(0.25R), Telerik.Reporting.Drawing.Unit.Inch(0.25R), Telerik.Reporting.Drawing.Unit.Inch(0.25R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        Me.Style.BackgroundColor = System.Drawing.Color.White
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(10.5R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents Panel1 As Telerik.Reporting.Panel
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents txtOverallScoreMessage As Telerik.Reporting.TextBox
    Friend WithEvents TextBox49 As Telerik.Reporting.TextBox
    Friend WithEvents txtOverallScore As Telerik.Reporting.TextBox
    Friend WithEvents txtOverallRating As Telerik.Reporting.TextBox
    Friend WithEvents TextBox52 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox55 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox56 As Telerik.Reporting.TextBox
    Friend WithEvents Panel2 As Telerik.Reporting.Panel
    Friend WithEvents TextBox47 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox48 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox69 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox70 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox71 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox72 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox73 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox74 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox75 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox76 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox79 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox80 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox85 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox92 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox93 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox94 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox95 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox96 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox97 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox98 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox99 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox112 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox113 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox114 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox115 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox46 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox30 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox31 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox35 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox36 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox50 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox51 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox53 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox54 As Telerik.Reporting.TextBox
    Friend WithEvents Panel3 As Telerik.Reporting.Panel
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox22 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox23 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox24 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox25 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox26 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox27 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox28 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox29 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox34 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox43 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox44 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox45 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox57 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox58 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox59 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox60 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox61 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox62 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox67 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox68 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox77 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox78 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox86 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox91 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox106 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox107 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents txtMechSysRating As GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox
    Friend WithEvents txtElecSysRating As GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox
    Friend WithEvents txtProdRating As GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox
    Friend WithEvents txtBoilerRating As GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox
    Friend WithEvents txtBoilerRatingRecs As GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox
    Friend WithEvents txtProdRatingRecs As GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox
    Friend WithEvents txtElecSysRatingRecs As GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox
    Friend WithEvents txtMechSysRatingRecs As GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox
    Friend WithEvents txtCompSysRatingRecs As GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox
    Friend WithEvents txtOccupancyRatingRecs As GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox
    Friend WithEvents txtOccupancyRating As GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox
    Friend WithEvents txtCompSysRating As GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox
    Friend WithEvents txtMechMaintRating As GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox
    Friend WithEvents txtElecMaintRating As GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox
    Friend WithEvents txtHeRating As GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox
    Friend WithEvents txtCriticalSparesRating As GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox
    Friend WithEvents txtCriticalSparesRatingRecs As GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox
    Friend WithEvents txtHeRatingRecs As GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox
    Friend WithEvents txtElecMaintRatingRecs As GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox
    Friend WithEvents txtMechMaintRatingRecs As GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox
    Friend WithEvents txtBcpRatingRecs As GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox
    Friend WithEvents txtBcpRating As GRC.Connect.Libraries.ReportLib.GrcTelerikRatingCategoryTexBox
    Friend WithEvents Panel6 As Telerik.Reporting.Panel
    Friend WithEvents uxRatingKeyTable As Telerik.Reporting.Table
    Friend WithEvents TextBox32 As Telerik.Reporting.TextBox
    Friend WithEvents uxRatingKeyHeader As Telerik.Reporting.TextBox
End Class