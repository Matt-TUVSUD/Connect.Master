Partial Class QorReport
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim TableGroup1 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup2 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup3 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup4 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim InstanceReportSource1 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Dim InstanceReportSource2 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Dim InstanceReportSource3 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Dim InstanceReportSource4 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Dim InstanceReportSource5 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Dim InstanceReportSource6 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Dim InstanceReportSource7 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Dim InstanceReportSource8 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Dim InstanceReportSource9 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Dim InstanceReportSource10 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Dim InstanceReportSource11 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Dim InstanceReportSource12 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Dim InstanceReportSource13 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Dim InstanceReportSource14 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Dim InstanceReportSource15 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Dim InstanceReportSource16 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Dim InstanceReportSource17 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
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
        Me.RSBPFacilitySubReport = New GRC.Connect.Libraries.ReportLib.QorRecommendations()
        Me.RSBPFireRecommendations = New GRC.Connect.Libraries.ReportLib.QorRecommendations()
        Me.CIMSubReport = New GRC.Connect.Libraries.ReportLib.QorRecommendations()
        Me.OOASubReport = New GRC.Connect.Libraries.ReportLib.QorRecommendations()
        Me.EcroSubReport = New GRC.Connect.Libraries.ReportLib.QorRecommendations()
        Me.ISCSubReport = New GRC.Connect.Libraries.ReportLib.QorRecommendations()
        Me.ITPSubReport = New GRC.Connect.Libraries.ReportLib.QorRecommendations()
        Me.NPR10SubReport = New GRC.Connect.Libraries.ReportLib.QorRecommendations()
        Me.NPR5SubReport = New GRC.Connect.Libraries.ReportLib.QorRecommendations()
        Me.NPR0SubReport = New GRC.Connect.Libraries.ReportLib.QorRecommendations()
        Me.NSR0SubReport = New GRC.Connect.Libraries.ReportLib.QorRecommendations()
        Me.NSR5SubReport = New GRC.Connect.Libraries.ReportLib.QorRecommendations()
        Me.NSR10SubReport = New GRC.Connect.Libraries.ReportLib.QorRecommendations()
        Me.OTOSubReport = New GRC.Connect.Libraries.ReportLib.QorRecommendations()
        Me.MEMSubReport = New GRC.Connect.Libraries.ReportLib.QorRecommendations()
        Me.EEMSubReport = New GRC.Connect.Libraries.ReportLib.QorRecommendations()
        Me.BPVMSubReport = New GRC.Connect.Libraries.ReportLib.QorRecommendations()
        Me.GroupFooterSection1 = New Telerik.Reporting.GroupFooterSection()
        Me.Table1 = New Telerik.Reporting.Table()
        Me.TextBox99 = New Telerik.Reporting.TextBox()
        Me.TextBox96 = New Telerik.Reporting.TextBox()
        Me.TextBox97 = New Telerik.Reporting.TextBox()
        Me.GroupHeaderSection1 = New Telerik.Reporting.GroupHeaderSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox33 = New Telerik.Reporting.TextBox()
        Me.TextBox34 = New Telerik.Reporting.TextBox()
        Me.TextBox25 = New Telerik.Reporting.TextBox()
        Me.TextBox26 = New Telerik.Reporting.TextBox()
        Me.TextBox27 = New Telerik.Reporting.TextBox()
        Me.TextBox28 = New Telerik.Reporting.TextBox()
        Me.TextBox29 = New Telerik.Reporting.TextBox()
        Me.TextBox30 = New Telerik.Reporting.TextBox()
        Me.TextBox31 = New Telerik.Reporting.TextBox()
        Me.TextBox32 = New Telerik.Reporting.TextBox()
        Me.TextBox35 = New Telerik.Reporting.TextBox()
        Me.TextBox36 = New Telerik.Reporting.TextBox()
        Me.txtFileNo = New Telerik.Reporting.TextBox()
        Me.Panel2 = New Telerik.Reporting.Panel()
        Me.TextBox56 = New Telerik.Reporting.TextBox()
        Me.TextBox57 = New Telerik.Reporting.TextBox()
        Me.TextBox58 = New Telerik.Reporting.TextBox()
        Me.TextBox59 = New Telerik.Reporting.TextBox()
        Me.TextBox60 = New Telerik.Reporting.TextBox()
        Me.TextBox61 = New Telerik.Reporting.TextBox()
        Me.TextBox64 = New Telerik.Reporting.TextBox()
        Me.TextBox65 = New Telerik.Reporting.TextBox()
        Me.TextBox66 = New Telerik.Reporting.TextBox()
        Me.TextBox67 = New Telerik.Reporting.TextBox()
        Me.TextBox68 = New Telerik.Reporting.TextBox()
        Me.TextBox69 = New Telerik.Reporting.TextBox()
        Me.TextBox70 = New Telerik.Reporting.TextBox()
        Me.TextBox71 = New Telerik.Reporting.TextBox()
        Me.TextBox72 = New Telerik.Reporting.TextBox()
        Me.TextBox73 = New Telerik.Reporting.TextBox()
        Me.TextBox74 = New Telerik.Reporting.TextBox()
        Me.TextBox75 = New Telerik.Reporting.TextBox()
        Me.TextBox76 = New Telerik.Reporting.TextBox()
        Me.TextBox77 = New Telerik.Reporting.TextBox()
        Me.TextBox78 = New Telerik.Reporting.TextBox()
        Me.TextBox100 = New Telerik.Reporting.TextBox()
        Me.TextBox98 = New Telerik.Reporting.TextBox()
        Me.TextBox62 = New Telerik.Reporting.TextBox()
        Me.TextBox63 = New Telerik.Reporting.TextBox()
        Me.TextBox102 = New Telerik.Reporting.TextBox()
        Me.TextBox104 = New Telerik.Reporting.TextBox()
        Me.Panel3 = New Telerik.Reporting.Panel()
        Me.TextBox79 = New Telerik.Reporting.TextBox()
        Me.TextBox80 = New Telerik.Reporting.TextBox()
        Me.TextBox81 = New Telerik.Reporting.TextBox()
        Me.TextBox82 = New Telerik.Reporting.TextBox()
        Me.TextBox83 = New Telerik.Reporting.TextBox()
        Me.TextBox84 = New Telerik.Reporting.TextBox()
        Me.TextBox85 = New Telerik.Reporting.TextBox()
        Me.TextBox86 = New Telerik.Reporting.TextBox()
        Me.TextBox87 = New Telerik.Reporting.TextBox()
        Me.TextBox88 = New Telerik.Reporting.TextBox()
        Me.TextBox89 = New Telerik.Reporting.TextBox()
        Me.TextBox90 = New Telerik.Reporting.TextBox()
        Me.TextBox91 = New Telerik.Reporting.TextBox()
        Me.TextBox92 = New Telerik.Reporting.TextBox()
        Me.TextBox93 = New Telerik.Reporting.TextBox()
        Me.TextBox55 = New Telerik.Reporting.TextBox()
        Me.TextBox54 = New Telerik.Reporting.TextBox()
        Me.TextBox101 = New Telerik.Reporting.TextBox()
        Me.Panel4 = New Telerik.Reporting.Panel()
        Me.TextBox95 = New Telerik.Reporting.TextBox()
        Me.subrpt_BM_RSBP = New Telerik.Reporting.SubReport()
        Me.subrpt_FIRE_RSBP = New Telerik.Reporting.SubReport()
        Me.TextBox94 = New Telerik.Reporting.TextBox()
        Me.Panel5 = New Telerik.Reporting.Panel()
        Me.HtmlTextBox12 = New Telerik.Reporting.HtmlTextBox()
        Me.TextBox47 = New Telerik.Reporting.TextBox()
        Me.Panel6 = New Telerik.Reporting.Panel()
        Me.TextBox48 = New Telerik.Reporting.TextBox()
        Me.HtmlTextBox13 = New Telerik.Reporting.HtmlTextBox()
        Me.Panel7 = New Telerik.Reporting.Panel()
        Me.TextBox49 = New Telerik.Reporting.TextBox()
        Me.HtmlTextBox14 = New Telerik.Reporting.HtmlTextBox()
        Me.Panel8 = New Telerik.Reporting.Panel()
        Me.HtmlTextBox16 = New Telerik.Reporting.HtmlTextBox()
        Me.TextBox53 = New Telerik.Reporting.TextBox()
        Me.Panel13 = New Telerik.Reporting.Panel()
        Me.HtmlTextBox3 = New Telerik.Reporting.HtmlTextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.Panel14 = New Telerik.Reporting.Panel()
        Me.HtmlTextBox4 = New Telerik.Reporting.HtmlTextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.Panel15 = New Telerik.Reporting.Panel()
        Me.TextBox37 = New Telerik.Reporting.TextBox()
        Me.HtmlTextBox5 = New Telerik.Reporting.HtmlTextBox()
        Me.Panel16 = New Telerik.Reporting.Panel()
        Me.HtmlTextBox6 = New Telerik.Reporting.HtmlTextBox()
        Me.TextBox38 = New Telerik.Reporting.TextBox()
        Me.Panel18 = New Telerik.Reporting.Panel()
        Me.TextBox42 = New Telerik.Reporting.TextBox()
        Me.HtmlTextBox8 = New Telerik.Reporting.HtmlTextBox()
        Me.Panel19 = New Telerik.Reporting.Panel()
        Me.TextBox43 = New Telerik.Reporting.TextBox()
        Me.HtmlTextBox9 = New Telerik.Reporting.HtmlTextBox()
        Me.Panel20 = New Telerik.Reporting.Panel()
        Me.HtmlTextBox17 = New Telerik.Reporting.HtmlTextBox()
        Me.TextBox44 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.HtmlTextBox2 = New Telerik.Reporting.HtmlTextBox()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.TextBox51 = New Telerik.Reporting.TextBox()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.TextBox45 = New Telerik.Reporting.TextBox()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.TextBox52 = New Telerik.Reporting.TextBox()
        Me.TextBox39 = New Telerik.Reporting.TextBox()
        Me.subrpt_FIRE_CIM = New Telerik.Reporting.SubReport()
        Me.subrpt_FIRE_OOA = New Telerik.Reporting.SubReport()
        Me.Panel1 = New Telerik.Reporting.Panel()
        Me.HtmlTextBox15 = New Telerik.Reporting.HtmlTextBox()
        Me.TextBox50 = New Telerik.Reporting.TextBox()
        Me.Panel9 = New Telerik.Reporting.Panel()
        Me.HtmlTextBox11 = New Telerik.Reporting.HtmlTextBox()
        Me.TextBox46 = New Telerik.Reporting.TextBox()
        Me.Panel10 = New Telerik.Reporting.Panel()
        Me.TextBox41 = New Telerik.Reporting.TextBox()
        Me.HtmlTextBox1 = New Telerik.Reporting.HtmlTextBox()
        Me.Panel11 = New Telerik.Reporting.Panel()
        Me.HtmlTextBox10 = New Telerik.Reporting.HtmlTextBox()
        Me.TextBox40 = New Telerik.Reporting.TextBox()
        Me.subrpt_FIRE_ECRO = New Telerik.Reporting.SubReport()
        Me.subrpt_FIRE_ISC = New Telerik.Reporting.SubReport()
        Me.subrpt_FIRE_ITP = New Telerik.Reporting.SubReport()
        Me.subrpt_FIRE_NPR10 = New Telerik.Reporting.SubReport()
        Me.subrpt_FIRE_NPR5 = New Telerik.Reporting.SubReport()
        Me.subrpt_FIRE_NPR0 = New Telerik.Reporting.SubReport()
        Me.subrpt_BM_NSR0 = New Telerik.Reporting.SubReport()
        Me.subrpt_BM_NSR5 = New Telerik.Reporting.SubReport()
        Me.subrpt_BM_NSR10 = New Telerik.Reporting.SubReport()
        Me.subrpt_BM_OTO = New Telerik.Reporting.SubReport()
        Me.subrpt_BM_MEM = New Telerik.Reporting.SubReport()
        Me.subrpt_BM_EEM = New Telerik.Reporting.SubReport()
        Me.subrpt_BM_BPVM = New Telerik.Reporting.SubReport()
        CType(Me.RSBPFacilitySubReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RSBPFireRecommendations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CIMSubReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OOASubReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EcroSubReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ISCSubReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ITPSubReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NPR10SubReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NPR5SubReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NPR0SubReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NSR0SubReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NSR5SubReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NSR10SubReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OTOSubReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEMSubReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EEMSubReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BPVMSubReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'RSBPFacilitySubReport
        '
        Me.RSBPFacilitySubReport.Name = "RSBPFacilitySubReport"
        '
        'RSBPFireRecommendations
        '
        Me.RSBPFireRecommendations.Name = "RSBPFireRecommendations"
        '
        'CIMSubReport
        '
        Me.CIMSubReport.Name = "CIMSubReport"
        '
        'OOASubReport
        '
        Me.OOASubReport.Name = "OOASubReport"
        '
        'EcroSubReport
        '
        Me.EcroSubReport.Name = "EcroSubReport"
        '
        'ISCSubReport
        '
        Me.ISCSubReport.Name = "ISCSubReport"
        '
        'ITPSubReport
        '
        Me.ITPSubReport.Name = "ITPSubReport"
        '
        'NPR10SubReport
        '
        Me.NPR10SubReport.Name = "NPR10SubReport"
        '
        'NPR5SubReport
        '
        Me.NPR5SubReport.Name = "NPR5SubReport"
        '
        'NPR0SubReport
        '
        Me.NPR0SubReport.Name = "NPR0SubReport"
        '
        'NSR0SubReport
        '
        Me.NSR0SubReport.Name = "NSR0SubReport"
        '
        'NSR5SubReport
        '
        Me.NSR5SubReport.Name = "NSR5SubReport"
        '
        'NSR10SubReport
        '
        Me.NSR10SubReport.Name = "NSR10SubReport"
        '
        'OTOSubReport
        '
        Me.OTOSubReport.Name = "OTOSubReport"
        '
        'MEMSubReport
        '
        Me.MEMSubReport.Name = "MEMSubReport"
        '
        'EEMSubReport
        '
        Me.EEMSubReport.Name = "EEMSubReport"
        '
        'BPVMSubReport
        '
        Me.BPVMSubReport.Name = "BPVMSubReport"
        '
        'GroupFooterSection1
        '
        Me.GroupFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.78550624847412109R)
        Me.GroupFooterSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Table1})
        Me.GroupFooterSection1.Name = "GroupFooterSection1"
        Me.GroupFooterSection1.PrintOnEveryPage = True
        '
        'Table1
        '
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(7.9486126899719238R)))
        Me.Table1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(0.16666653752326965R)))
        Me.Table1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(0.17968735098838806R)))
        Me.Table1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(0.17187497019767761R)))
        Me.Table1.Body.SetCellContent(0, 0, Me.TextBox99)
        Me.Table1.Body.SetCellContent(1, 0, Me.TextBox96)
        Me.Table1.Body.SetCellContent(2, 0, Me.TextBox97)
        Me.Table1.ColumnGroups.Add(TableGroup1)
        Me.Table1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox99, Me.TextBox96, Me.TextBox97})
        Me.Table1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.00000000024528659658962226R), Telerik.Reporting.Drawing.Unit.Inch(0.16311080753803253R))
        Me.Table1.Name = "Table1"
        TableGroup2.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup2.Name = "DetailGroup"
        TableGroup3.Name = "Group1"
        TableGroup4.Name = "Group2"
        Me.Table1.RowGroups.Add(TableGroup2)
        Me.Table1.RowGroups.Add(TableGroup3)
        Me.Table1.RowGroups.Add(TableGroup4)
        Me.Table1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.9486126899719238R), Telerik.Reporting.Drawing.Unit.Inch(0.51822882890701294R))
        Me.Table1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Table1.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        '
        'TextBox99
        '
        Me.TextBox99.Name = "TextBox99"
        Me.TextBox99.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.9486126899719238R), Telerik.Reporting.Drawing.Unit.Inch(0.16666652262210846R))
        Me.TextBox99.Style.BackgroundColor = System.Drawing.Color.Yellow
        Me.TextBox99.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox99.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox99.Style.Font.Bold = True
        Me.TextBox99.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox99.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox99.Value = "Human element recommendations - yellow cells"
        '
        'TextBox96
        '
        Me.TextBox96.Name = "TextBox96"
        Me.TextBox96.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.9486126899719238R), Telerik.Reporting.Drawing.Unit.Inch(0.17968733608722687R))
        Me.TextBox96.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.TextBox96.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox96.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox96.Style.Font.Bold = True
        Me.TextBox96.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox96.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox96.Value = "Physical improvement recommendations - white cells"
        '
        'TextBox97
        '
        Me.TextBox97.Name = "TextBox97"
        Me.TextBox97.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.9486126899719238R), Telerik.Reporting.Drawing.Unit.Inch(0.17187495529651642R))
        Me.TextBox97.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.TextBox97.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox97.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox97.Style.Font.Bold = True
        Me.TextBox97.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox97.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox97.Value = "RSBP (Recommended Standards and Best Practice) recommendations - blue cells"
        '
        'GroupHeaderSection1
        '
        Me.GroupHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.1458333283662796R)
        Me.GroupHeaderSection1.Name = "GroupHeaderSection1"
        Me.GroupHeaderSection1.PrintOnEveryPage = True
        Me.GroupHeaderSection1.Style.Visible = True
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(11.529534339904785R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.TextBox5, Me.TextBox6, Me.TextBox7, Me.TextBox8, Me.TextBox10, Me.TextBox11, Me.TextBox12, Me.TextBox13, Me.TextBox14, Me.TextBox15, Me.TextBox16, Me.TextBox33, Me.TextBox34, Me.TextBox25, Me.TextBox26, Me.TextBox27, Me.TextBox28, Me.TextBox29, Me.TextBox30, Me.TextBox31, Me.TextBox32, Me.TextBox35, Me.TextBox36, Me.txtFileNo, Me.Panel2, Me.Panel3, Me.Panel4, Me.Panel5, Me.Panel6, Me.Panel7, Me.Panel8, Me.Panel13, Me.Panel14, Me.Panel15, Me.Panel16, Me.Panel18, Me.Panel19, Me.Panel20, Me.TextBox18, Me.TextBox17, Me.HtmlTextBox2, Me.TextBox20, Me.TextBox22, Me.TextBox21, Me.TextBox51, Me.TextBox23, Me.TextBox45, Me.TextBox24, Me.TextBox52, Me.TextBox39, Me.subrpt_FIRE_CIM, Me.subrpt_FIRE_OOA, Me.Panel1, Me.Panel9, Me.Panel10, Me.Panel11, Me.subrpt_FIRE_ECRO, Me.subrpt_FIRE_ISC, Me.subrpt_FIRE_ITP, Me.subrpt_FIRE_NPR10, Me.subrpt_FIRE_NPR5, Me.subrpt_FIRE_NPR0, Me.subrpt_BM_NSR0, Me.subrpt_BM_NSR5, Me.subrpt_BM_NSR10, Me.subrpt_BM_OTO, Me.subrpt_BM_MEM, Me.subrpt_BM_EEM, Me.subrpt_BM_BPVM})
        Me.detail.Name = "detail"
        Me.detail.PageBreak = Telerik.Reporting.PageBreak.After
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.049999993294477463R), Telerik.Reporting.Drawing.Unit.Inch(0.013888888992369175R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.75000017881393433R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox1.Value = "Facility:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929R), Telerik.Reporting.Drawing.Unit.Inch(0.013888888992369175R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.2103378772735596R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox2.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox2.Value = "=Facility"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929R), Telerik.Reporting.Drawing.Unit.Inch(0.21736116707324982R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.1604957580566406R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox3.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox3.Value = "=Address1"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.049999993294477463R), Telerik.Reporting.Drawing.Unit.Inch(0.21736116707324982R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.75000017881393433R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox4.Style.Font.Bold = True
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox4.Value = "Address:"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.049960613250732422R), Telerik.Reporting.Drawing.Unit.Inch(0.42083343863487244R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.75003951787948608R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox5.Style.Font.Bold = True
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox5.Value = "City:"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929R), Telerik.Reporting.Drawing.Unit.Inch(0.42083343863487244R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8499208688735962R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox6.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox6.Value = "=City"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.8000791072845459R), Telerik.Reporting.Drawing.Unit.Inch(0.013888888992369175R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1604161262512207R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox7.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox7.Value = "=Division"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2145833969116211R), Telerik.Reporting.Drawing.Unit.Inch(0.013888888992369175R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.58541679382324219R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox8.Style.Font.Bold = True
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox8.Value = "Division:"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.7125096321105957R), Telerik.Reporting.Drawing.Unit.Inch(0.013888888992369175R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.49583292007446289R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox10.Style.Font.Bold = True
        Me.TextBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox10.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox10.Value = "File No.:"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.42083343863487244R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.110495924949646R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox11.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox11.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox11.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox11.Value = "=Stprov"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.7041666507720947R), Telerik.Reporting.Drawing.Unit.Inch(0.42083343863487244R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.49583354592323303R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox12.Style.Font.Bold = True
        Me.TextBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox12.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox12.Value = "State:"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.3499999046325684R), Telerik.Reporting.Drawing.Unit.Inch(0.42083343863487244R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.49583354592323303R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox13.Style.Font.Bold = True
        Me.TextBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox13.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox13.Value = "Ctry:"
        '
        'TextBox14
        '
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.8499999046325684R), Telerik.Reporting.Drawing.Unit.Inch(0.42083343863487244R))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.110495924949646R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox14.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox14.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox14.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox14.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox14.Value = "=Country"
        '
        'TextBox15
        '
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.1750040054321289R), Telerik.Reporting.Drawing.Unit.Inch(0.42083343863487244R))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.049920916557312R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox15.Style.Font.Bold = True
        Me.TextBox15.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox15.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox15.Value = "TIV (US$ milions):"
        '
        'TextBox16
        '
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.2478785514831543R), Telerik.Reporting.Drawing.Unit.Inch(0.42083343863487244R))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox16.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox16.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox16.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox16.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox16.Value = "=tiv"
        '
        'TextBox33
        '
        Me.TextBox33.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.50104284286499R), Telerik.Reporting.Drawing.Unit.Inch(1.4067707061767578R))
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.82083272933959961R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox33.Style.Font.Bold = True
        Me.TextBox33.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox33.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox33.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox33.Value = "=Year5Label"
        '
        'TextBox34
        '
        Me.TextBox34.Format = "{0:C2}"
        Me.TextBox34.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.50104284286499R), Telerik.Reporting.Drawing.Unit.Inch(1.5637158155441284R))
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.82083272933959961R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox34.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox34.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox34.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox34.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox34.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox34.Value = "=Year5Claim"
        '
        'TextBox25
        '
        Me.TextBox25.Format = "{0:C2}"
        Me.TextBox25.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.4562499523162842R), Telerik.Reporting.Drawing.Unit.Inch(1.5407991409301758R))
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.82083272933959961R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox25.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox25.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox25.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox25.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox25.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox25.Value = "=Year4Claim"
        '
        'TextBox26
        '
        Me.TextBox26.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.4562499523162842R), Telerik.Reporting.Drawing.Unit.Inch(1.3838539123535156R))
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.82083272933959961R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox26.Style.Font.Bold = True
        Me.TextBox26.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox26.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox26.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox26.Value = "=Year4Label"
        '
        'TextBox27
        '
        Me.TextBox27.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.44270920753479R), Telerik.Reporting.Drawing.Unit.Inch(1.3859373331069946R))
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.82083272933959961R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox27.Style.Font.Bold = True
        Me.TextBox27.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox27.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox27.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox27.Value = "=Year3Label"
        '
        'TextBox28
        '
        Me.TextBox28.Format = "{0:C2}"
        Me.TextBox28.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.44270920753479R), Telerik.Reporting.Drawing.Unit.Inch(1.5428825616836548R))
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.82083272933959961R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox28.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox28.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox28.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox28.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox28.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox28.Value = "=Year3Claim"
        '
        'TextBox29
        '
        Me.TextBox29.Format = "{0:C2}"
        Me.TextBox29.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.4541667699813843R), Telerik.Reporting.Drawing.Unit.Inch(1.5532993078231812R))
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.82083272933959961R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox29.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox29.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox29.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox29.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox29.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox29.Value = "=Year2Claim"
        '
        'TextBox30
        '
        Me.TextBox30.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.4541667699813843R), Telerik.Reporting.Drawing.Unit.Inch(1.3963538408279419R))
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.82083272933959961R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox30.Style.Font.Bold = True
        Me.TextBox30.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox30.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox30.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox30.Value = "=Year2Label"
        '
        'TextBox31
        '
        Me.TextBox31.Format = "{0:C2}"
        Me.TextBox31.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.43753942847251892R), Telerik.Reporting.Drawing.Unit.Inch(1.5532993078231812R))
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.82083272933959961R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox31.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox31.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox31.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox31.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox31.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox31.Value = "=Year1Claim"
        '
        'TextBox32
        '
        Me.TextBox32.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.43753942847251892R), Telerik.Reporting.Drawing.Unit.Inch(1.3963538408279419R))
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.82083272933959961R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox32.Style.Font.Bold = True
        Me.TextBox32.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox32.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox32.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox32.Value = "=Year1Label"
        '
        'TextBox35
        '
        Me.TextBox35.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.8812503814697266R), Telerik.Reporting.Drawing.Unit.Inch(1.5637160539627075R))
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.82083272933959961R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox35.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox35.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox35.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox35.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox35.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox35.Value = "{Total_Claims_TIV}%"
        '
        'TextBox36
        '
        Me.TextBox36.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.616706371307373R), Telerik.Reporting.Drawing.Unit.Inch(1.4067708253860474R))
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3499213457107544R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox36.Style.Font.Bold = True
        Me.TextBox36.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox36.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox36.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox36.Value = "Total Claims x 100/TIV"
        '
        'txtFileNo
        '
        Me.txtFileNo.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.247917652130127R), Telerik.Reporting.Drawing.Unit.Inch(0.013888888992369175R))
        Me.txtFileNo.Name = "txtFileNo"
        Me.txtFileNo.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.txtFileNo.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.txtFileNo.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtFileNo.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.txtFileNo.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtFileNo.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtFileNo.Value = "=Fields.Fileno"
        '
        'Panel2
        '
        Me.Panel2.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox56, Me.TextBox57, Me.TextBox58, Me.TextBox59, Me.TextBox60, Me.TextBox61, Me.TextBox64, Me.TextBox65, Me.TextBox66, Me.TextBox67, Me.TextBox68, Me.TextBox69, Me.TextBox70, Me.TextBox71, Me.TextBox72, Me.TextBox73, Me.TextBox74, Me.TextBox75, Me.TextBox76, Me.TextBox77, Me.TextBox78, Me.TextBox100, Me.TextBox98, Me.TextBox62, Me.TextBox63, Me.TextBox102, Me.TextBox104})
        Me.Panel2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(7.4267048835754395R))
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.9979157447814941R), Telerik.Reporting.Drawing.Unit.Inch(1.4366921186447144R))
        '
        'TextBox56
        '
        Me.TextBox56.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.4000000953674316R), Telerik.Reporting.Drawing.Unit.Inch(0.44207271933555603R))
        Me.TextBox56.Name = "TextBox56"
        Me.TextBox56.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.84999990463256836R), Telerik.Reporting.Drawing.Unit.Inch(0.20173603296279907R))
        Me.TextBox56.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox56.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox56.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox56.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox56.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox56.Value = "=FloodRating"
        '
        'TextBox57
        '
        Me.TextBox57.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.21045494079589844R), Telerik.Reporting.Drawing.Unit.Inch(0.44207271933555603R))
        Me.TextBox57.Name = "TextBox57"
        Me.TextBox57.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.139545202255249R), Telerik.Reporting.Drawing.Unit.Inch(0.20173603296279907R))
        Me.TextBox57.Style.Font.Bold = True
        Me.TextBox57.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox57.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox57.Value = "Flood (7 pts):"
        '
        'TextBox58
        '
        Me.TextBox58.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.21045494079589844R), Telerik.Reporting.Drawing.Unit.Inch(0.69207227230072021R))
        Me.TextBox58.Name = "TextBox58"
        Me.TextBox58.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.139545202255249R), Telerik.Reporting.Drawing.Unit.Inch(0.20173603296279907R))
        Me.TextBox58.Style.Font.Bold = True
        Me.TextBox58.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox58.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox58.Value = "Earthquake (7 pts):"
        '
        'TextBox59
        '
        Me.TextBox59.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.4000000953674316R), Telerik.Reporting.Drawing.Unit.Inch(0.69207227230072021R))
        Me.TextBox59.Name = "TextBox59"
        Me.TextBox59.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.84999990463256836R), Telerik.Reporting.Drawing.Unit.Inch(0.20173603296279907R))
        Me.TextBox59.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox59.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox59.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox59.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox59.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox59.Value = "=EarthquakeRating"
        '
        'TextBox60
        '
        Me.TextBox60.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.21045494079589844R), Telerik.Reporting.Drawing.Unit.Inch(0.92332381010055542R))
        Me.TextBox60.Name = "TextBox60"
        Me.TextBox60.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1395450830459595R), Telerik.Reporting.Drawing.Unit.Inch(0.20173603296279907R))
        Me.TextBox60.Style.Font.Bold = True
        Me.TextBox60.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox60.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox60.Value = "Windstorm (7 pts):"
        '
        'TextBox61
        '
        Me.TextBox61.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.4000000953674316R), Telerik.Reporting.Drawing.Unit.Inch(0.92332381010055542R))
        Me.TextBox61.Name = "TextBox61"
        Me.TextBox61.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.84999990463256836R), Telerik.Reporting.Drawing.Unit.Inch(0.20173603296279907R))
        Me.TextBox61.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox61.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox61.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox61.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox61.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox61.Value = "=WindstormRating"
        '
        'TextBox64
        '
        Me.TextBox64.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.3458340167999268R), Telerik.Reporting.Drawing.Unit.Inch(0.44207271933555603R))
        Me.TextBox64.Name = "TextBox64"
        Me.TextBox64.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.664503812789917R), Telerik.Reporting.Drawing.Unit.Inch(0.20173603296279907R))
        Me.TextBox64.Style.Font.Bold = True
        Me.TextBox64.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox64.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox64.Value = "Frequency:"
        '
        'TextBox65
        '
        Me.TextBox65.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.0104167461395264R), Telerik.Reporting.Drawing.Unit.Inch(0.44207271933555603R))
        Me.TextBox65.Name = "TextBox65"
        Me.TextBox65.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3895837068557739R), Telerik.Reporting.Drawing.Unit.Inch(0.20173603296279907R))
        Me.TextBox65.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox65.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox65.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox65.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox65.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox65.Value = "=frequency"
        '
        'TextBox66
        '
        Me.TextBox66.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.4500002861022949R), Telerik.Reporting.Drawing.Unit.Inch(0.44207271933555603R))
        Me.TextBox66.Name = "TextBox66"
        Me.TextBox66.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0603377819061279R), Telerik.Reporting.Drawing.Unit.Inch(0.20173603296279907R))
        Me.TextBox66.Style.Font.Bold = True
        Me.TextBox66.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox66.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox66.Value = "Inundation Depth:"
        '
        'TextBox67
        '
        Me.TextBox67.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.5500006675720215R), Telerik.Reporting.Drawing.Unit.Inch(0.43998801708221436R))
        Me.TextBox67.Name = "TextBox67"
        Me.TextBox67.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6562089920043945R), Telerik.Reporting.Drawing.Unit.Inch(0.20173603296279907R))
        Me.TextBox67.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox67.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox67.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox67.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox67.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox67.Value = "=inundationdepth"
        '
        'TextBox68
        '
        Me.TextBox68.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.0R), Telerik.Reporting.Drawing.Unit.Inch(0.694156289100647R))
        Me.TextBox68.Name = "TextBox68"
        Me.TextBox68.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.90000039339065552R), Telerik.Reporting.Drawing.Unit.Inch(0.20173603296279907R))
        Me.TextBox68.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox68.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox68.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox68.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox68.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox68.Value = "=fmseismiczone"
        '
        'TextBox69
        '
        Me.TextBox69.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.3333332538604736R), Telerik.Reporting.Drawing.Unit.Inch(0.694156289100647R))
        Me.TextBox69.Name = "TextBox69"
        Me.TextBox69.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.664503812789917R), Telerik.Reporting.Drawing.Unit.Inch(0.20173603296279907R))
        Me.TextBox69.Style.Font.Bold = True
        Me.TextBox69.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox69.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox69.Value = "Frequency:"
        '
        'TextBox70
        '
        Me.TextBox70.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9896621704101562R), Telerik.Reporting.Drawing.Unit.Inch(0.694156289100647R))
        Me.TextBox70.Name = "TextBox70"
        Me.TextBox70.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.51242256164550781R), Telerik.Reporting.Drawing.Unit.Inch(0.20173603296279907R))
        Me.TextBox70.Style.Font.Bold = True
        Me.TextBox70.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox70.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox70.Value = "Accel:"
        '
        'TextBox71
        '
        Me.TextBox71.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.5500006675720215R), Telerik.Reporting.Drawing.Unit.Inch(0.694156289100647R))
        Me.TextBox71.Name = "TextBox71"
        Me.TextBox71.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.70837289094924927R), Telerik.Reporting.Drawing.Unit.Inch(0.20173603296279907R))
        Me.TextBox71.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox71.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox71.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox71.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox71.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox71.Value = "=peak_gnd_accel"
        '
        'TextBox72
        '
        Me.TextBox72.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.5019640922546387R), Telerik.Reporting.Drawing.Unit.Inch(0.694156289100647R))
        Me.TextBox72.Name = "TextBox72"
        Me.TextBox72.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.70837289094924927R), Telerik.Reporting.Drawing.Unit.Inch(0.20173603296279907R))
        Me.TextBox72.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox72.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox72.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox72.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox72.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox72.Value = "=modifiedmercalliindex"
        '
        'TextBox73
        '
        Me.TextBox73.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.4000000953674316R), Telerik.Reporting.Drawing.Unit.Inch(0.694156289100647R))
        Me.TextBox73.Name = "TextBox73"
        Me.TextBox73.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.031131386756897R), Telerik.Reporting.Drawing.Unit.Inch(0.12569448351860046R))
        Me.TextBox73.Style.Font.Bold = True
        Me.TextBox73.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox73.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox73.Value = "Mod Mercalli Idx:"
        '
        'TextBox74
        '
        Me.TextBox74.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9896621704101562R), Telerik.Reporting.Drawing.Unit.Inch(0.92540782690048218R))
        Me.TextBox74.Name = "TextBox74"
        Me.TextBox74.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5603383779525757R), Telerik.Reporting.Drawing.Unit.Inch(0.20173603296279907R))
        Me.TextBox74.Style.Font.Bold = True
        Me.TextBox74.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox74.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox74.Value = "3 Sec Gust Wind Speed:"
        '
        'TextBox75
        '
        Me.TextBox75.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.5709128379821777R), Telerik.Reporting.Drawing.Unit.Inch(0.92540782690048218R))
        Me.TextBox75.Name = "TextBox75"
        Me.TextBox75.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6352967023849487R), Telerik.Reporting.Drawing.Unit.Inch(0.20173603296279907R))
        Me.TextBox75.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox75.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox75.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox75.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox75.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox75.Value = "=max_sust_windspeed"
        '
        'TextBox76
        '
        Me.TextBox76.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.25R), Telerik.Reporting.Drawing.Unit.Inch(0.43998825550079346R))
        Me.TextBox76.Name = "TextBox76"
        Me.TextBox76.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.20173603296279907R))
        Me.TextBox76.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox76.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox76.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox76.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox76.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox76.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox76.Value = "=FloodScore"
        '
        'TextBox77
        '
        Me.TextBox77.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.25R), Telerik.Reporting.Drawing.Unit.Inch(0.68998849391937256R))
        Me.TextBox77.Name = "TextBox77"
        Me.TextBox77.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.20173603296279907R))
        Me.TextBox77.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox77.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox77.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox77.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox77.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox77.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox77.Value = "=EarthquakeScore"
        '
        'TextBox78
        '
        Me.TextBox78.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.25R), Telerik.Reporting.Drawing.Unit.Inch(0.91683977842330933R))
        Me.TextBox78.Name = "TextBox78"
        Me.TextBox78.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.20173603296279907R))
        Me.TextBox78.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox78.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox78.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox78.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox78.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox78.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox78.Value = "=WindstormScore"
        '
        'TextBox100
        '
        Me.TextBox100.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(-0.00000013768051587703667R))
        Me.TextBox100.Name = "TextBox100"
        Me.TextBox100.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.25R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox100.Style.BackgroundColor = System.Drawing.Color.LightGray
        Me.TextBox100.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox100.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox100.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox100.Style.Font.Bold = True
        Me.TextBox100.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox100.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox100.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox100.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox100.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox100.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox100.Value = "Exposures (25 pts max):"
        '
        'TextBox98
        '
        Me.TextBox98.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.25R), Telerik.Reporting.Drawing.Unit.Inch(-0.00000013768051587703667R))
        Me.TextBox98.Name = "TextBox98"
        Me.TextBox98.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox98.Style.BackgroundColor = System.Drawing.Color.LightGray
        Me.TextBox98.Style.BorderColor.Left = System.Drawing.Color.Black
        Me.TextBox98.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox98.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox98.Style.Color = System.Drawing.Color.Blue
        Me.TextBox98.Style.Font.Bold = True
        Me.TextBox98.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox98.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox98.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox98.Value = "=nat_risk_score"
        '
        'TextBox62
        '
        Me.TextBox62.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.21875R), Telerik.Reporting.Drawing.Unit.Inch(0.19878482818603516R))
        Me.TextBox62.Name = "TextBox62"
        Me.TextBox62.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.014545202255249R), Telerik.Reporting.Drawing.Unit.Inch(0.20173603296279907R))
        Me.TextBox62.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox62.Style.Font.Bold = True
        Me.TextBox62.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox62.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox62.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox62.Value = "COPE Form Exposures"
        '
        'TextBox63
        '
        Me.TextBox63.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.3458340167999268R), Telerik.Reporting.Drawing.Unit.Inch(0.19878482818603516R))
        Me.TextBox63.Name = "TextBox63"
        Me.TextBox63.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.854823112487793R), Telerik.Reporting.Drawing.Unit.Inch(0.20173603296279907R))
        Me.TextBox63.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox63.Style.Font.Bold = True
        Me.TextBox63.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox63.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox63.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox63.Value = "Description"
        '
        'TextBox102
        '
        Me.TextBox102.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.21045494079589844R), Telerik.Reporting.Drawing.Unit.Inch(1.1539367437362671R))
        Me.TextBox102.Name = "TextBox102"
        Me.TextBox102.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3363044261932373R), Telerik.Reporting.Drawing.Unit.Inch(0.20173603296279907R))
        Me.TextBox102.Style.Font.Bold = True
        Me.TextBox102.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox102.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox102.Value = "External Exposure: (4  pts):"
        '
        'TextBox104
        '
        Me.TextBox104.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.25R), Telerik.Reporting.Drawing.Unit.Inch(1.1539367437362671R))
        Me.TextBox104.Name = "TextBox104"
        Me.TextBox104.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.20173603296279907R))
        Me.TextBox104.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox104.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox104.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox104.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox104.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox104.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox104.Value = "=ExternalExposureScore"
        '
        'Panel3
        '
        Me.Panel3.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox79, Me.TextBox80, Me.TextBox81, Me.TextBox82, Me.TextBox83, Me.TextBox84, Me.TextBox85, Me.TextBox86, Me.TextBox87, Me.TextBox88, Me.TextBox89, Me.TextBox90, Me.TextBox91, Me.TextBox92, Me.TextBox93, Me.TextBox55, Me.TextBox54, Me.TextBox101})
        Me.Panel3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.010416666977107525R), Telerik.Reporting.Drawing.Unit.Inch(8.9127206802368164R))
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.95412540435791R), Telerik.Reporting.Drawing.Unit.Inch(1.3686681985855103R))
        '
        'TextBox79
        '
        Me.TextBox79.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.19374977052211761R), Telerik.Reporting.Drawing.Unit.Inch(0.42908486723899841R))
        Me.TextBox79.Name = "TextBox79"
        Me.TextBox79.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6354551315307617R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox79.Style.Font.Bold = True
        Me.TextBox79.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox79.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox79.Value = "Office Facilities (10 pts):"
        '
        'TextBox80
        '
        Me.TextBox80.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.8812506198883057R), Telerik.Reporting.Drawing.Unit.Inch(0.42908486723899841R))
        Me.TextBox80.Name = "TextBox80"
        Me.TextBox80.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.2978348731994629R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox80.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox80.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox80.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox80.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox80.Value = "=OfficeComment"
        '
        'TextBox81
        '
        Me.TextBox81.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.25R), Telerik.Reporting.Drawing.Unit.Inch(0.42908486723899841R))
        Me.TextBox81.Name = "TextBox81"
        Me.TextBox81.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox81.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox81.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox81.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox81.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox81.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox81.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox81.Value = "=OfficeScore"
        '
        'TextBox82
        '
        Me.TextBox82.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.25R), Telerik.Reporting.Drawing.Unit.Inch(0.60477930307388306R))
        Me.TextBox82.Name = "TextBox82"
        Me.TextBox82.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox82.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox82.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox82.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox82.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox82.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox82.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox82.Value = "=HotelScore"
        '
        'TextBox83
        '
        Me.TextBox83.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.8895835876464844R), Telerik.Reporting.Drawing.Unit.Inch(0.60477930307388306R))
        Me.TextBox83.Name = "TextBox83"
        Me.TextBox83.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.2978348731994629R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox83.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox83.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox83.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox83.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox83.Value = "=HotelComment"
        '
        'TextBox84
        '
        Me.TextBox84.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.19999995827674866R), Telerik.Reporting.Drawing.Unit.Inch(0.60477936267852783R))
        Me.TextBox84.Name = "TextBox84"
        Me.TextBox84.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6395833492279053R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox84.Style.Font.Bold = True
        Me.TextBox84.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox84.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox84.Value = "Machine Shop/Specialty (8 pts):"
        '
        'TextBox85
        '
        Me.TextBox85.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.25R), Telerik.Reporting.Drawing.Unit.Inch(0.78047388792037964R))
        Me.TextBox85.Name = "TextBox85"
        Me.TextBox85.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox85.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox85.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox85.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox85.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox85.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox85.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox85.Value = "=NonwovenScore"
        '
        'TextBox86
        '
        Me.TextBox86.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.8895835876464844R), Telerik.Reporting.Drawing.Unit.Inch(0.78047388792037964R))
        Me.TextBox86.Name = "TextBox86"
        Me.TextBox86.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.2978348731994629R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox86.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox86.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox86.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox86.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox86.Value = "=NonwovenComment"
        '
        'TextBox87
        '
        Me.TextBox87.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.19374977052211761R), Telerik.Reporting.Drawing.Unit.Inch(0.78047388792037964R))
        Me.TextBox87.Name = "TextBox87"
        Me.TextBox87.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6458337306976318R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox87.Style.Font.Bold = True
        Me.TextBox87.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox87.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox87.Value = "Nonwoven Mfg. or Converting/Warehouse (6 pts):"
        '
        'TextBox88
        '
        Me.TextBox88.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.25R), Telerik.Reporting.Drawing.Unit.Inch(0.95616841316223145R))
        Me.TextBox88.Name = "TextBox88"
        Me.TextBox88.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox88.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox88.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox88.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox88.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox88.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox88.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox88.Value = "=PulpScore"
        '
        'TextBox89
        '
        Me.TextBox89.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.8895835876464844R), Telerik.Reporting.Drawing.Unit.Inch(0.95616841316223145R))
        Me.TextBox89.Name = "TextBox89"
        Me.TextBox89.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.2978348731994629R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox89.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox89.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox89.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox89.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox89.Value = "=PulpComment"
        '
        'TextBox90
        '
        Me.TextBox90.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.19374977052211761R), Telerik.Reporting.Drawing.Unit.Inch(0.95616841316223145R))
        Me.TextBox90.Name = "TextBox90"
        Me.TextBox90.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6458337306976318R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox90.Style.Font.Bold = True
        Me.TextBox90.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox90.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox90.Value = "Tissue Mfg. (4 pts):"
        '
        'TextBox91
        '
        Me.TextBox91.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.25R), Telerik.Reporting.Drawing.Unit.Inch(1.131862998008728R))
        Me.TextBox91.Name = "TextBox91"
        Me.TextBox91.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox91.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox91.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox91.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox91.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox91.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox91.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox91.Value = "=KraftScore"
        '
        'TextBox92
        '
        Me.TextBox92.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.8895835876464844R), Telerik.Reporting.Drawing.Unit.Inch(1.131862998008728R))
        Me.TextBox92.Name = "TextBox92"
        Me.TextBox92.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.2978348731994629R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox92.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox92.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox92.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox92.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox92.Value = "=KraftComment"
        '
        'TextBox93
        '
        Me.TextBox93.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.19374977052211761R), Telerik.Reporting.Drawing.Unit.Inch(1.131862998008728R))
        Me.TextBox93.Name = "TextBox93"
        Me.TextBox93.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6458337306976318R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox93.Style.Font.Bold = True
        Me.TextBox93.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox93.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox93.Value = "Other Special Hazard (2 pts):"
        '
        'TextBox55
        '
        Me.TextBox55.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox55.Name = "TextBox55"
        Me.TextBox55.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.25R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox55.Style.BackgroundColor = System.Drawing.Color.LightGray
        Me.TextBox55.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox55.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox55.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox55.Style.Font.Bold = True
        Me.TextBox55.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox55.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox55.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox55.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox55.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox55.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox55.Value = "Occupancy (10 pts max):"
        '
        'TextBox54
        '
        Me.TextBox54.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.25R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox54.Name = "TextBox54"
        Me.TextBox54.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox54.Style.BackgroundColor = System.Drawing.Color.LightGray
        Me.TextBox54.Style.BorderColor.Left = System.Drawing.Color.Black
        Me.TextBox54.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox54.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox54.Style.Color = System.Drawing.Color.Blue
        Me.TextBox54.Style.Font.Bold = True
        Me.TextBox54.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox54.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox54.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox54.Value = "=prim_bus_score"
        '
        'TextBox101
        '
        Me.TextBox101.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.8812506198883057R), Telerik.Reporting.Drawing.Unit.Inch(0.18819236755371094R))
        Me.TextBox101.Name = "TextBox101"
        Me.TextBox101.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.2978348731994629R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox101.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox101.Style.Font.Bold = True
        Me.TextBox101.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox101.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox101.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox101.Value = "Highest Business Risk in MFL Area"
        '
        'Panel4
        '
        Me.Panel4.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox95, Me.subrpt_BM_RSBP, Me.subrpt_FIRE_RSBP, Me.TextBox94})
        Me.Panel4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.00000000024528659658962226R), Telerik.Reporting.Drawing.Unit.Inch(10.381387710571289R))
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.9979157447814941R), Telerik.Reporting.Drawing.Unit.Inch(1.0208345651626587R))
        '
        'TextBox95
        '
        Me.TextBox95.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.53888893127441406R))
        Me.TextBox95.Name = "TextBox95"
        Me.TextBox95.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.9470829963684082R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox95.Style.BackgroundColor = System.Drawing.Color.LightGray
        Me.TextBox95.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox95.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox95.Style.Font.Bold = True
        Me.TextBox95.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox95.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox95.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox95.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox95.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox95.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox95.Value = "Recommended Standards and Best Practices (RSBP) Fire: No Point Reduction"
        '
        'subrpt_BM_RSBP
        '
        Me.subrpt_BM_RSBP.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.26805558800697327R))
        Me.subrpt_BM_RSBP.Name = "subrpt_BM_RSBP"
        InstanceReportSource1.Parameters.Add(New Telerik.Reporting.Parameter("FileNo", "=Fields.FileNo"))
        InstanceReportSource1.ReportDocument = Me.RSBPFacilitySubReport
        Me.subrpt_BM_RSBP.ReportSource = InstanceReportSource1
        Me.subrpt_BM_RSBP.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.9470829963684082R), Telerik.Reporting.Drawing.Unit.Inch(0.25R))
        Me.subrpt_BM_RSBP.Style.BackgroundColor = System.Drawing.Color.White
        '
        'subrpt_FIRE_RSBP
        '
        Me.subrpt_FIRE_RSBP.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.71319454908370972R))
        Me.subrpt_FIRE_RSBP.Name = "subrpt_FIRE_RSBP"
        InstanceReportSource2.Parameters.Add(New Telerik.Reporting.Parameter("FileNo", "=Fields.Fileno"))
        InstanceReportSource2.ReportDocument = Me.RSBPFireRecommendations
        Me.subrpt_FIRE_RSBP.ReportSource = InstanceReportSource2
        Me.subrpt_FIRE_RSBP.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.9470829963684082R), Telerik.Reporting.Drawing.Unit.Inch(0.25R))
        Me.subrpt_FIRE_RSBP.Style.BackgroundColor = System.Drawing.Color.White
        '
        'TextBox94
        '
        Me.TextBox94.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.09375R))
        Me.TextBox94.Name = "TextBox94"
        Me.TextBox94.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.9470829963684082R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox94.Style.BackgroundColor = System.Drawing.Color.LightGray
        Me.TextBox94.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox94.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox94.Style.Font.Bold = True
        Me.TextBox94.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox94.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox94.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox94.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox94.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox94.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox94.Value = "Recommended Standards and Best Practices (RSBP) Equipment: No Point Reduction"
        '
        'Panel5
        '
        Me.Panel5.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.HtmlTextBox12, Me.TextBox47})
        Me.Panel5.KeepTogether = True
        Me.Panel5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(30.0R), Telerik.Reporting.Drawing.Unit.Inch(7.03125R))
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6626491546630859R), Telerik.Reporting.Drawing.Unit.Inch(0.15347255766391754R))
        '
        'HtmlTextBox12
        '
        Me.HtmlTextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000000019868215517249155R), Telerik.Reporting.Drawing.Unit.Inch(-0.00000029717352845182177R))
        Me.HtmlTextBox12.Name = "HtmlTextBox12"
        Me.HtmlTextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.962648868560791R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.HtmlTextBox12.Style.BackgroundColor = System.Drawing.Color.White
        Me.HtmlTextBox12.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.HtmlTextBox12.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.HtmlTextBox12.Style.Font.Bold = True
        Me.HtmlTextBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.HtmlTextBox12.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.HtmlTextBox12.Value = "No&nbsp;Protection Risks&nbsp;Identified (NPR0, 1 pt)- <span style=""color: #ff000" & _
    "0"">Correct within&nbsp;36 months</span>"
        '
        'TextBox47
        '
        Me.TextBox47.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.962648868560791R), Telerik.Reporting.Drawing.Unit.Inch(0.00000030098797765276686R))
        Me.TextBox47.Name = "TextBox47"
        Me.TextBox47.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox47.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox47.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox47.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox47.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox47.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox47.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox47.Value = "=npr0"
        '
        'Panel6
        '
        Me.Panel6.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox48, Me.HtmlTextBox13})
        Me.Panel6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(30.0R), Telerik.Reporting.Drawing.Unit.Inch(6.6930556297302246R))
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6626491546630859R), Telerik.Reporting.Drawing.Unit.Inch(0.15347225964069366R))
        '
        'TextBox48
        '
        Me.TextBox48.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.962648868560791R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox48.Name = "TextBox48"
        Me.TextBox48.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox48.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox48.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox48.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox48.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox48.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox48.Value = "=npr5"
        '
        'HtmlTextBox13
        '
        Me.HtmlTextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.HtmlTextBox13.Name = "HtmlTextBox13"
        Me.HtmlTextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.962648868560791R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.HtmlTextBox13.Style.BackgroundColor = System.Drawing.Color.White
        Me.HtmlTextBox13.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.HtmlTextBox13.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.HtmlTextBox13.Style.Font.Bold = True
        Me.HtmlTextBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.HtmlTextBox13.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.HtmlTextBox13.Value = "No Protection Risks &gt; $5,000,000 LE (NPR5, 2 pts) - <span style=""color: #ff000" & _
    "0"">Correct within&nbsp;24 months</span>"
        '
        'Panel7
        '
        Me.Panel7.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox49, Me.HtmlTextBox14})
        Me.Panel7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(30.0R), Telerik.Reporting.Drawing.Unit.Pixel(610.066650390625R))
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6626491546630859R), Telerik.Reporting.Drawing.Unit.Inch(0.15347249805927277R))
        '
        'TextBox49
        '
        Me.TextBox49.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.962648868560791R), Telerik.Reporting.Drawing.Unit.Inch(-0.00000018687806857542455R))
        Me.TextBox49.Name = "TextBox49"
        Me.TextBox49.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox49.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox49.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox49.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox49.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox49.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox49.Value = "=npr10"
        '
        'HtmlTextBox14
        '
        Me.HtmlTextBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000000019868215517249155R), Telerik.Reporting.Drawing.Unit.Inch(0.00000022452695702668279R))
        Me.HtmlTextBox14.Name = "HtmlTextBox14"
        Me.HtmlTextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.962648868560791R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.HtmlTextBox14.Style.BackgroundColor = System.Drawing.Color.White
        Me.HtmlTextBox14.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.HtmlTextBox14.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.HtmlTextBox14.Style.Font.Bold = True
        Me.HtmlTextBox14.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.HtmlTextBox14.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.HtmlTextBox14.Value = "No&nbsp;Protection Risks &gt; $10,000,000 LE (NPR10, 4 pts) - <span style=""color:" & _
    " #ff0000"">Correct within 12 months</span>"
        '
        'Panel8
        '
        Me.Panel8.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.HtmlTextBox16, Me.TextBox53})
        Me.Panel8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(30.0R), Telerik.Reporting.Drawing.Unit.Pixel(577.5999755859375R))
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6626491546630859R), Telerik.Reporting.Drawing.Unit.Inch(0.15347225964069366R))
        '
        'HtmlTextBox16
        '
        Me.HtmlTextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.HtmlTextBox16.Name = "HtmlTextBox16"
        Me.HtmlTextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.962648868560791R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.HtmlTextBox16.Style.BackgroundColor = System.Drawing.Color.Yellow
        Me.HtmlTextBox16.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.HtmlTextBox16.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.HtmlTextBox16.Style.Font.Bold = True
        Me.HtmlTextBox16.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.HtmlTextBox16.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.HtmlTextBox16.Value = "Occupancy Orderly &amp; Appropriate&nbsp;(OOA, 3 pts) - <span style=""color: #ff00" & _
    "00"">Correct within&nbsp;60 days</span>"
        '
        'TextBox53
        '
        Me.TextBox53.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.962648868560791R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox53.Name = "TextBox53"
        Me.TextBox53.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox53.Style.BackgroundColor = System.Drawing.Color.Yellow
        Me.TextBox53.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox53.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox53.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox53.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox53.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox53.Value = "=ooa"
        '
        'Panel13
        '
        Me.Panel13.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.HtmlTextBox3, Me.TextBox9})
        Me.Panel13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(29.0R), Telerik.Reporting.Drawing.Unit.Pixel(190.0R))
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6730656623840332R), Telerik.Reporting.Drawing.Unit.Inch(0.15347225964069366R))
        Me.Panel13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        '
        'HtmlTextBox3
        '
        Me.HtmlTextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.HtmlTextBox3.Name = "HtmlTextBox3"
        Me.HtmlTextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.962648868560791R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.HtmlTextBox3.Style.BackgroundColor = System.Drawing.Color.Yellow
        Me.HtmlTextBox3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.HtmlTextBox3.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.HtmlTextBox3.Style.Font.Bold = True
        Me.HtmlTextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.HtmlTextBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.HtmlTextBox3.Value = "Boilers &amp; Pressure Vessels Maintained&nbsp;(BPVM, 5 pts) - <span style=""color" & _
    ": #ff0000"">Correct within 30 days</span>"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.962648868560791R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.70520848035812378R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox9.Style.BackgroundColor = System.Drawing.Color.Yellow
        Me.TextBox9.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox9.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox9.Value = "=BPVM"
        '
        'Panel14
        '
        Me.Panel14.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.HtmlTextBox4, Me.TextBox19})
        Me.Panel14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(29.0R), Telerik.Reporting.Drawing.Unit.Pixel(222.4666748046875R))
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6730656623840332R), Telerik.Reporting.Drawing.Unit.Inch(0.15347225964069366R))
        Me.Panel14.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        '
        'HtmlTextBox4
        '
        Me.HtmlTextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000000019868215517249155R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.HtmlTextBox4.Name = "HtmlTextBox4"
        Me.HtmlTextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.962648868560791R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.HtmlTextBox4.Style.BackgroundColor = System.Drawing.Color.Yellow
        Me.HtmlTextBox4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.HtmlTextBox4.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.HtmlTextBox4.Style.Font.Bold = True
        Me.HtmlTextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.HtmlTextBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.HtmlTextBox4.Style.Visible = True
        Me.HtmlTextBox4.Value = "Electrical Equipment Maintained&nbsp;&nbsp;(EEM, 3 pts) - <span style=""color: #ff" & _
    "0000"">Correct within 60 days</span>"
        '
        'TextBox19
        '
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.962648868560791R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox19.Style.BackgroundColor = System.Drawing.Color.Yellow
        Me.TextBox19.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox19.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox19.Style.Font.Bold = False
        Me.TextBox19.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox19.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox19.Value = "=EEM"
        '
        'Panel15
        '
        Me.Panel15.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox37, Me.HtmlTextBox5})
        Me.Panel15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(29.0R), Telerik.Reporting.Drawing.Unit.Pixel(254.933349609375R))
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6730656623840332R), Telerik.Reporting.Drawing.Unit.Inch(0.15347225964069366R))
        Me.Panel15.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        '
        'TextBox37
        '
        Me.TextBox37.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.962648868560791R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox37.Style.BackgroundColor = System.Drawing.Color.Yellow
        Me.TextBox37.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox37.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox37.Style.Font.Bold = False
        Me.TextBox37.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox37.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox37.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox37.Style.Visible = True
        Me.TextBox37.Value = "=MEM"
        '
        'HtmlTextBox5
        '
        Me.HtmlTextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.HtmlTextBox5.Name = "HtmlTextBox5"
        Me.HtmlTextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.962648868560791R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.HtmlTextBox5.Style.BackgroundColor = System.Drawing.Color.Yellow
        Me.HtmlTextBox5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.HtmlTextBox5.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.HtmlTextBox5.Style.Font.Bold = True
        Me.HtmlTextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.HtmlTextBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.HtmlTextBox5.Style.Visible = True
        Me.HtmlTextBox5.Value = "Mechanical Equipment Maintained&nbsp;(MEM, 3 pts) - <span style=""color: #ff0000"">" & _
    "Correct within 60 days</span>"
        '
        'Panel16
        '
        Me.Panel16.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.HtmlTextBox6, Me.TextBox38})
        Me.Panel16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(29.0R), Telerik.Reporting.Drawing.Unit.Pixel(287.4000244140625R))
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6730656623840332R), Telerik.Reporting.Drawing.Unit.Inch(0.153472900390625R))
        Me.Panel16.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        '
        'HtmlTextBox6
        '
        Me.HtmlTextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.013888888992369175R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.HtmlTextBox6.Name = "HtmlTextBox6"
        Me.HtmlTextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.962648868560791R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.HtmlTextBox6.Style.BackgroundColor = System.Drawing.Color.Yellow
        Me.HtmlTextBox6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.HtmlTextBox6.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.HtmlTextBox6.Style.Font.Bold = True
        Me.HtmlTextBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.HtmlTextBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.HtmlTextBox6.Value = "Operator Training Okay(OTO, 2 pts) - <span style=""color: #ff0000"">Correct within " & _
    "60 days</span>"
        '
        'TextBox38
        '
        Me.TextBox38.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.962648868560791R), Telerik.Reporting.Drawing.Unit.Inch(0.000000635782896551973R))
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox38.Style.BackgroundColor = System.Drawing.Color.Yellow
        Me.TextBox38.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox38.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox38.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox38.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox38.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox38.Value = "=oto"
        '
        'Panel18
        '
        Me.Panel18.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox42, Me.HtmlTextBox8})
        Me.Panel18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(29.000001907348633R), Telerik.Reporting.Drawing.Unit.Pixel(319.86676025390625R))
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6730656623840332R), Telerik.Reporting.Drawing.Unit.Inch(0.15347249805927277R))
        Me.Panel18.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        '
        'TextBox42
        '
        Me.TextBox42.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.962648868560791R), Telerik.Reporting.Drawing.Unit.Inch(-0.00000018687806857542455R))
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox42.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox42.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox42.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox42.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox42.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox42.Value = "=nSr10"
        '
        'HtmlTextBox8
        '
        Me.HtmlTextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000000019868215517249155R), Telerik.Reporting.Drawing.Unit.Inch(0.00000022452695702668279R))
        Me.HtmlTextBox8.Name = "HtmlTextBox8"
        Me.HtmlTextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.962648868560791R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.HtmlTextBox8.Style.BackgroundColor = System.Drawing.Color.White
        Me.HtmlTextBox8.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.HtmlTextBox8.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.HtmlTextBox8.Style.Font.Bold = True
        Me.HtmlTextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.HtmlTextBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.HtmlTextBox8.Value = "No&nbsp;Safeguard Risks &gt; $10,000,000 LE (NSR10, 4 pts) - <span style=""color: " & _
    "#ff0000"">Correct within 30 days</span>"
        '
        'Panel19
        '
        Me.Panel19.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox43, Me.HtmlTextBox9})
        Me.Panel19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.3020833432674408R), Telerik.Reporting.Drawing.Unit.Inch(3.670140266418457R))
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6730656623840332R), Telerik.Reporting.Drawing.Unit.Inch(0.15347225964069366R))
        Me.Panel19.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        '
        'TextBox43
        '
        Me.TextBox43.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.962648868560791R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox43.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox43.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox43.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox43.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox43.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox43.Value = "=nsr5"
        '
        'HtmlTextBox9
        '
        Me.HtmlTextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000000019868215517249155R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.HtmlTextBox9.Name = "HtmlTextBox9"
        Me.HtmlTextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.962648868560791R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.HtmlTextBox9.Style.BackgroundColor = System.Drawing.Color.White
        Me.HtmlTextBox9.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.HtmlTextBox9.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.HtmlTextBox9.Style.Font.Bold = True
        Me.HtmlTextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.HtmlTextBox9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.HtmlTextBox9.Value = "No&nbsp;Safeguard Risks &gt; $5,000,000 LE (NSR5, 2 pts) - <span style=""color: #f" & _
    "f0000"">Correct within&nbsp;90 days</span>"
        '
        'Panel20
        '
        Me.Panel20.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.HtmlTextBox17, Me.TextBox44})
        Me.Panel20.KeepTogether = True
        Me.Panel20.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.3020833432674408R), Telerik.Reporting.Drawing.Unit.Inch(4.0083346366882324R))
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6730656623840332R), Telerik.Reporting.Drawing.Unit.Inch(0.15347255766391754R))
        Me.Panel20.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        '
        'HtmlTextBox17
        '
        Me.HtmlTextBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000000019868215517249155R), Telerik.Reporting.Drawing.Unit.Inch(0.000000020489096641540527R))
        Me.HtmlTextBox17.Name = "HtmlTextBox17"
        Me.HtmlTextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.962648868560791R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.HtmlTextBox17.Style.BackgroundColor = System.Drawing.Color.White
        Me.HtmlTextBox17.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.HtmlTextBox17.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.HtmlTextBox17.Style.Font.Bold = True
        Me.HtmlTextBox17.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.HtmlTextBox17.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.HtmlTextBox17.Value = "No&nbsp;Safeguard Risks&nbsp;Identified (NSR0, 1 pt)- <span style=""color: #ff0000" & _
    """>Correct within&nbsp;12 months</span>"
        '
        'TextBox44
        '
        Me.TextBox44.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.962648868560791R), Telerik.Reporting.Drawing.Unit.Inch(0.00000030098797765276686R))
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox44.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox44.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox44.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox44.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox44.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox44.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox44.Value = "=nsr0"
        '
        'TextBox18
        '
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.64427143335342407R))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.2673606872558594R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox18.Style.BackgroundColor = System.Drawing.Color.LightGray
        Me.TextBox18.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox18.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox18.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox18.Style.Font.Bold = True
        Me.TextBox18.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox18.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox18.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox18.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox18.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox18.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox18.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox18.Value = " Enterprise Weighted Average Quality of Risk Score:"
        '
        'TextBox17
        '
        Me.TextBox17.Format = "{0:#.}"
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.26993989944458R), Telerik.Reporting.Drawing.Unit.Inch(0.64427143335342407R))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox17.Style.BackgroundColor = System.Drawing.Color.LightGray
        Me.TextBox17.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox17.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox17.Style.Font.Bold = True
        Me.TextBox17.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox17.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox17.StyleName = "Red"
        Me.TextBox17.Value = "=Ent_Wght_avg"
        '
        'HtmlTextBox2
        '
        Me.HtmlTextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.79774361848831177R))
        Me.HtmlTextBox2.Name = "HtmlTextBox2"
        Me.HtmlTextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.2673606872558594R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.HtmlTextBox2.Style.BackgroundColor = System.Drawing.Color.LightGray
        Me.HtmlTextBox2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.HtmlTextBox2.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.HtmlTextBox2.Style.Font.Bold = True
        Me.HtmlTextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.HtmlTextBox2.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.HtmlTextBox2.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.HtmlTextBox2.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.HtmlTextBox2.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.HtmlTextBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.HtmlTextBox2.Value = "<p style=""text-align: left"">&nbsp;Sector:&nbsp; <span style=""color: #0000ff"">{sec" & _
    "tor}</span>&nbsp;&nbsp; Weighted Average Quality of Risk Score:</p>"
        '
        'TextBox20
        '
        Me.TextBox20.Format = "{0:#.}"
        Me.TextBox20.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.26993989944458R), Telerik.Reporting.Drawing.Unit.Inch(0.79774361848831177R))
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox20.Style.BackgroundColor = System.Drawing.Color.LightGray
        Me.TextBox20.Style.BorderColor.Left = System.Drawing.Color.Black
        Me.TextBox20.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox20.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox20.Style.Color = System.Drawing.Color.Blue
        Me.TextBox20.Style.Font.Bold = True
        Me.TextBox20.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox20.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox20.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox20.Value = "=Sector_wght_avg"
        '
        'TextBox22
        '
        Me.TextBox22.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.95121568441390991R))
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.2673606872558594R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox22.Style.BackgroundColor = System.Drawing.Color.LightGray
        Me.TextBox22.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox22.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox22.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox22.Style.Font.Bold = True
        Me.TextBox22.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox22.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox22.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox22.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox22.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox22.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox22.Value = " Location Quality of Risk Score (100 pts max):"
        '
        'TextBox21
        '
        Me.TextBox21.Format = "{0:#.}"
        Me.TextBox21.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.26993989944458R), Telerik.Reporting.Drawing.Unit.Inch(0.95121568441390991R))
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox21.Style.BackgroundColor = System.Drawing.Color.LightGray
        Me.TextBox21.Style.BorderColor.Left = System.Drawing.Color.Black
        Me.TextBox21.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox21.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox21.Style.Color = System.Drawing.Color.Blue
        Me.TextBox21.Style.Font.Bold = True
        Me.TextBox21.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox21.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox21.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox21.Value = "=Location_Score"
        '
        'TextBox51
        '
        Me.TextBox51.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(1.7541666030883789R))
        Me.TextBox51.Name = "TextBox51"
        Me.TextBox51.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.2673606872558594R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox51.Style.BackgroundColor = System.Drawing.Color.LightGray
        Me.TextBox51.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox51.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox51.Style.Font.Bold = True
        Me.TextBox51.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox51.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox51.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox51.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox51.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox51.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox51.Value = "Equipment Recommendations (20 pts max):"
        '
        'TextBox23
        '
        Me.TextBox23.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.26993989944458R), Telerik.Reporting.Drawing.Unit.Inch(1.7541666030883789R))
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox23.Style.BackgroundColor = System.Drawing.Color.LightGray
        Me.TextBox23.Style.BorderColor.Left = System.Drawing.Color.Black
        Me.TextBox23.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox23.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox23.Style.Color = System.Drawing.Color.Blue
        Me.TextBox23.Style.Font.Bold = True
        Me.TextBox23.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox23.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox23.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox23.Value = "=equipment"
        '
        'TextBox45
        '
        Me.TextBox45.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(1.1949646472930908R))
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.2673606872558594R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox45.Style.BackgroundColor = System.Drawing.Color.LightGray
        Me.TextBox45.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox45.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox45.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox45.Style.Font.Bold = True
        Me.TextBox45.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox45.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox45.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox45.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox45.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox45.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox45.Value = "Claims (25 pts max):                                                          (Fi" & _
    "rst $5,000,000 of all claims reported)"
        '
        'TextBox24
        '
        Me.TextBox24.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.26993989944458R), Telerik.Reporting.Drawing.Unit.Inch(1.1949646472930908R))
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox24.Style.BackgroundColor = System.Drawing.Color.LightGray
        Me.TextBox24.Style.BorderColor.Left = System.Drawing.Color.Black
        Me.TextBox24.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox24.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox24.Style.Color = System.Drawing.Color.Blue
        Me.TextBox24.Style.Font.Bold = True
        Me.TextBox24.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox24.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox24.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox24.Value = "=total_claims_score"
        '
        'TextBox52
        '
        Me.TextBox52.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(4.44928503036499R))
        Me.TextBox52.Name = "TextBox52"
        Me.TextBox52.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.2673606872558594R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox52.Style.BackgroundColor = System.Drawing.Color.LightGray
        Me.TextBox52.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox52.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox52.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox52.Style.Font.Bold = True
        Me.TextBox52.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox52.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox52.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox52.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox52.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.TextBox52.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox52.Value = "Facility Recommendations (20 pts max):"
        '
        'TextBox39
        '
        Me.TextBox39.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.2673606872558594R), Telerik.Reporting.Drawing.Unit.Inch(4.44928503036499R))
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox39.Style.BackgroundColor = System.Drawing.Color.LightGray
        Me.TextBox39.Style.BorderColor.Left = System.Drawing.Color.Black
        Me.TextBox39.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox39.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox39.Style.Color = System.Drawing.Color.Blue
        Me.TextBox39.Style.Font.Bold = True
        Me.TextBox39.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox39.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox39.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox39.Value = "=facility_score"
        '
        'subrpt_FIRE_CIM
        '
        Me.subrpt_FIRE_CIM.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.3125R), Telerik.Reporting.Drawing.Unit.Inch(5.8527774810791016R))
        Me.subrpt_FIRE_CIM.Name = "subrpt_FIRE_CIM"
        InstanceReportSource3.Parameters.Add(New Telerik.Reporting.Parameter("FileNo", "=Fields.FileNo"))
        InstanceReportSource3.ReportDocument = Me.CIMSubReport
        Me.subrpt_FIRE_CIM.ReportSource = InstanceReportSource3
        Me.subrpt_FIRE_CIM.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6730656623840332R), Telerik.Reporting.Drawing.Unit.Inch(0.14305560290813446R))
        Me.subrpt_FIRE_CIM.Style.Visible = True
        '
        'subrpt_FIRE_OOA
        '
        Me.subrpt_FIRE_OOA.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.3125R), Telerik.Reporting.Drawing.Unit.Inch(6.190971851348877R))
        Me.subrpt_FIRE_OOA.Name = "subrpt_FIRE_OOA"
        InstanceReportSource4.Parameters.Add(New Telerik.Reporting.Parameter("FileNo", "=Fields.FileNo"))
        InstanceReportSource4.ReportDocument = Me.OOASubReport
        Me.subrpt_FIRE_OOA.ReportSource = InstanceReportSource4
        Me.subrpt_FIRE_OOA.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6730656623840332R), Telerik.Reporting.Drawing.Unit.Inch(0.14305560290813446R))
        '
        'Panel1
        '
        Me.Panel1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.HtmlTextBox15, Me.TextBox50})
        Me.Panel1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(30.0R), Telerik.Reporting.Drawing.Unit.Pixel(545.13330078125R))
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6626491546630859R), Telerik.Reporting.Drawing.Unit.Pixel(14.73333740234375R))
        '
        'HtmlTextBox15
        '
        Me.HtmlTextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.HtmlTextBox15.Name = "HtmlTextBox15"
        Me.HtmlTextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.962648868560791R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.HtmlTextBox15.Style.BackgroundColor = System.Drawing.Color.Yellow
        Me.HtmlTextBox15.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.HtmlTextBox15.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.HtmlTextBox15.Style.Font.Bold = True
        Me.HtmlTextBox15.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.HtmlTextBox15.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.HtmlTextBox15.Value = "Change &amp; Impairments Managed&nbsp;(CIM, 2 pts) - <span style=""color: #ff0000""" & _
    ">Correct within&nbsp;60 days</span>"
        '
        'TextBox50
        '
        Me.TextBox50.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.962648868560791R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox50.Name = "TextBox50"
        Me.TextBox50.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox50.Style.BackgroundColor = System.Drawing.Color.Yellow
        Me.TextBox50.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox50.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox50.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox50.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox50.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox50.Value = "=cim"
        '
        'Panel9
        '
        Me.Panel9.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.HtmlTextBox11, Me.TextBox46})
        Me.Panel9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(30.0R), Telerik.Reporting.Drawing.Unit.Pixel(512.6666259765625R))
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6626491546630859R), Telerik.Reporting.Drawing.Unit.Pixel(14.73333740234375R))
        '
        'HtmlTextBox11
        '
        Me.HtmlTextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.HtmlTextBox11.Name = "HtmlTextBox11"
        Me.HtmlTextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.962648868560791R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.HtmlTextBox11.Style.BackgroundColor = System.Drawing.Color.Yellow
        Me.HtmlTextBox11.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.HtmlTextBox11.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.HtmlTextBox11.Style.Font.Bold = True
        Me.HtmlTextBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.HtmlTextBox11.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.HtmlTextBox11.Style.Visible = True
        Me.HtmlTextBox11.Value = "Inspected or Tested per PMS (ITP, 3 pts) - <span style=""color: #ff0000"">Correct w" & _
    "ithin&nbsp;60 days</span>"
        '
        'TextBox46
        '
        Me.TextBox46.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.962648868560791R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox46.Name = "TextBox46"
        Me.TextBox46.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox46.Style.BackgroundColor = System.Drawing.Color.Yellow
        Me.TextBox46.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox46.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox46.Style.Font.Bold = False
        Me.TextBox46.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox46.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox46.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox46.Style.Visible = True
        Me.TextBox46.Value = "=itp"
        '
        'Panel10
        '
        Me.Panel10.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox41, Me.HtmlTextBox1})
        Me.Panel10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(30.0R), Telerik.Reporting.Drawing.Unit.Pixel(480.19976806640625R))
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6626491546630859R), Telerik.Reporting.Drawing.Unit.Pixel(14.7335205078125R))
        '
        'TextBox41
        '
        Me.TextBox41.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.962648868560791R), Telerik.Reporting.Drawing.Unit.Inch(0.0000019073486328125R))
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox41.Style.BackgroundColor = System.Drawing.Color.Yellow
        Me.TextBox41.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox41.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox41.Style.Font.Bold = False
        Me.TextBox41.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox41.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox41.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox41.Value = "=isc"
        '
        'HtmlTextBox1
        '
        Me.HtmlTextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0000019073486328125R))
        Me.HtmlTextBox1.Name = "HtmlTextBox1"
        Me.HtmlTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.962648868560791R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.HtmlTextBox1.Style.BackgroundColor = System.Drawing.Color.Yellow
        Me.HtmlTextBox1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.HtmlTextBox1.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.HtmlTextBox1.Style.Font.Bold = True
        Me.HtmlTextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.HtmlTextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.HtmlTextBox1.Style.Visible = True
        Me.HtmlTextBox1.Value = "Ignition Sources Controlled&nbsp;&nbsp;(ISC, 3 pts) - <span style=""color: #ff0000" & _
    """>Correct within&nbsp;60 days</span>"
        '
        'Panel11
        '
        Me.Panel11.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.HtmlTextBox10, Me.TextBox40})
        Me.Panel11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(30.000001907348633R), Telerik.Reporting.Drawing.Unit.Pixel(447.73309326171875R))
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(735.61431884765625R), Telerik.Reporting.Drawing.Unit.Pixel(14.73333740234375R))
        '
        'HtmlTextBox10
        '
        Me.HtmlTextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.HtmlTextBox10.Name = "HtmlTextBox10"
        Me.HtmlTextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.962648868560791R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.HtmlTextBox10.Style.BackgroundColor = System.Drawing.Color.Yellow
        Me.HtmlTextBox10.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.HtmlTextBox10.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.HtmlTextBox10.Style.Font.Bold = True
        Me.HtmlTextBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.HtmlTextBox10.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.HtmlTextBox10.Value = "Emergency or Crisis Response Okay&nbsp;(ECRO, 2 pts) - <span style=""color: #ff000" & _
    "0"">Correct within&nbsp;60 days</span>"
        '
        'TextBox40
        '
        Me.TextBox40.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.962648868560791R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.15347227454185486R))
        Me.TextBox40.Style.BackgroundColor = System.Drawing.Color.Yellow
        Me.TextBox40.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox40.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox40.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox40.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox40.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox40.Value = "=ecro"
        '
        'subrpt_FIRE_ECRO
        '
        Me.subrpt_FIRE_ECRO.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.3125R), Telerik.Reporting.Drawing.Unit.Inch(4.8381919860839844R))
        Me.subrpt_FIRE_ECRO.Name = "subrpt_FIRE_ECRO"
        InstanceReportSource5.Parameters.Add(New Telerik.Reporting.Parameter("FileNo", "=Fields.FileNo"))
        InstanceReportSource5.ReportDocument = Me.EcroSubReport
        Me.subrpt_FIRE_ECRO.ReportSource = InstanceReportSource5
        Me.subrpt_FIRE_ECRO.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6730656623840332R), Telerik.Reporting.Drawing.Unit.Inch(0.14305560290813446R))
        Me.subrpt_FIRE_ECRO.Style.BackgroundColor = System.Drawing.Color.White
        Me.subrpt_FIRE_ECRO.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.subrpt_FIRE_ECRO.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.subrpt_FIRE_ECRO.Style.Font.Bold = True
        Me.subrpt_FIRE_ECRO.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.subrpt_FIRE_ECRO.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        '
        'subrpt_FIRE_ISC
        '
        Me.subrpt_FIRE_ISC.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.3125R), Telerik.Reporting.Drawing.Unit.Inch(5.1763882637023926R))
        Me.subrpt_FIRE_ISC.Name = "subrpt_FIRE_ISC"
        InstanceReportSource6.Parameters.Add(New Telerik.Reporting.Parameter("FileNo", "=Fields.FileNo"))
        InstanceReportSource6.ReportDocument = Me.ISCSubReport
        Me.subrpt_FIRE_ISC.ReportSource = InstanceReportSource6
        Me.subrpt_FIRE_ISC.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6730656623840332R), Telerik.Reporting.Drawing.Unit.Inch(0.14305560290813446R))
        Me.subrpt_FIRE_ISC.Style.BackgroundColor = System.Drawing.Color.White
        Me.subrpt_FIRE_ISC.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.subrpt_FIRE_ISC.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.subrpt_FIRE_ISC.Style.Font.Bold = True
        Me.subrpt_FIRE_ISC.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.subrpt_FIRE_ISC.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.subrpt_FIRE_ISC.Style.Visible = True
        '
        'subrpt_FIRE_ITP
        '
        Me.subrpt_FIRE_ITP.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.3125R), Telerik.Reporting.Drawing.Unit.Inch(5.5145831108093262R))
        Me.subrpt_FIRE_ITP.Name = "subrpt_FIRE_ITP"
        InstanceReportSource7.Parameters.Add(New Telerik.Reporting.Parameter("FileNo", "=Fields.FileNo"))
        InstanceReportSource7.ReportDocument = Me.ITPSubReport
        Me.subrpt_FIRE_ITP.ReportSource = InstanceReportSource7
        Me.subrpt_FIRE_ITP.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6730656623840332R), Telerik.Reporting.Drawing.Unit.Inch(0.14305560290813446R))
        Me.subrpt_FIRE_ITP.Style.BackgroundColor = System.Drawing.Color.White
        Me.subrpt_FIRE_ITP.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.subrpt_FIRE_ITP.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.subrpt_FIRE_ITP.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.subrpt_FIRE_ITP.Style.Font.Bold = True
        Me.subrpt_FIRE_ITP.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.subrpt_FIRE_ITP.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.subrpt_FIRE_ITP.Style.Visible = True
        '
        'subrpt_FIRE_NPR10
        '
        Me.subrpt_FIRE_NPR10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.3125R), Telerik.Reporting.Drawing.Unit.Inch(6.5291666984558105R))
        Me.subrpt_FIRE_NPR10.Name = "subrpt_FIRE_NPR10"
        InstanceReportSource8.Parameters.Add(New Telerik.Reporting.Parameter("FileNo", "=Fields.FileNo"))
        InstanceReportSource8.ReportDocument = Me.NPR10SubReport
        Me.subrpt_FIRE_NPR10.ReportSource = InstanceReportSource8
        Me.subrpt_FIRE_NPR10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6730656623840332R), Telerik.Reporting.Drawing.Unit.Inch(0.14305560290813446R))
        Me.subrpt_FIRE_NPR10.Style.Visible = True
        '
        'subrpt_FIRE_NPR5
        '
        Me.subrpt_FIRE_NPR5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.3125R), Telerik.Reporting.Drawing.Unit.Inch(6.8673610687255859R))
        Me.subrpt_FIRE_NPR5.Name = "subrpt_FIRE_NPR5"
        InstanceReportSource9.Parameters.Add(New Telerik.Reporting.Parameter("FileNo", "=Fields.FileNo"))
        InstanceReportSource9.ReportDocument = Me.NPR5SubReport
        Me.subrpt_FIRE_NPR5.ReportSource = InstanceReportSource9
        Me.subrpt_FIRE_NPR5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6730656623840332R), Telerik.Reporting.Drawing.Unit.Inch(0.14305560290813446R))
        Me.subrpt_FIRE_NPR5.Style.Visible = True
        '
        'subrpt_FIRE_NPR0
        '
        Me.subrpt_FIRE_NPR0.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.3125R), Telerik.Reporting.Drawing.Unit.Inch(7.2055554389953613R))
        Me.subrpt_FIRE_NPR0.Name = "subrpt_FIRE_NPR0"
        InstanceReportSource10.Parameters.Add(New Telerik.Reporting.Parameter("FileNo", "=Fields.FileNo"))
        InstanceReportSource10.ReportDocument = Me.NPR0SubReport
        Me.subrpt_FIRE_NPR0.ReportSource = InstanceReportSource10
        Me.subrpt_FIRE_NPR0.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6626491546630859R), Telerik.Reporting.Drawing.Unit.Inch(0.14305560290813446R))
        '
        'subrpt_BM_NSR0
        '
        Me.subrpt_BM_NSR0.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.3020833432674408R), Telerik.Reporting.Drawing.Unit.Inch(4.182640552520752R))
        Me.subrpt_BM_NSR0.Name = "subrpt_BM_NSR0"
        InstanceReportSource11.Parameters.Add(New Telerik.Reporting.Parameter("FileNo", "=Fields.FileNo"))
        InstanceReportSource11.ReportDocument = Me.NSR0SubReport
        Me.subrpt_BM_NSR0.ReportSource = InstanceReportSource11
        Me.subrpt_BM_NSR0.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6730656623840332R), Telerik.Reporting.Drawing.Unit.Inch(0.14305560290813446R))
        '
        'subrpt_BM_NSR5
        '
        Me.subrpt_BM_NSR5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.3020833432674408R), Telerik.Reporting.Drawing.Unit.Inch(3.8444459438323975R))
        Me.subrpt_BM_NSR5.Name = "subrpt_BM_NSR5"
        InstanceReportSource12.Parameters.Add(New Telerik.Reporting.Parameter("FileNo", "=Fields.FileNo"))
        InstanceReportSource12.ReportDocument = Me.NSR5SubReport
        Me.subrpt_BM_NSR5.ReportSource = InstanceReportSource12
        Me.subrpt_BM_NSR5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6730656623840332R), Telerik.Reporting.Drawing.Unit.Inch(0.14305560290813446R))
        Me.subrpt_BM_NSR5.Style.Visible = True
        '
        'subrpt_BM_NSR10
        '
        Me.subrpt_BM_NSR10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.3020833432674408R), Telerik.Reporting.Drawing.Unit.Inch(3.506251335144043R))
        Me.subrpt_BM_NSR10.Name = "subrpt_BM_NSR10"
        InstanceReportSource13.Parameters.Add(New Telerik.Reporting.Parameter("FileNo", "=Fields.FileNo"))
        InstanceReportSource13.ReportDocument = Me.NSR10SubReport
        Me.subrpt_BM_NSR10.ReportSource = InstanceReportSource13
        Me.subrpt_BM_NSR10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6730656623840332R), Telerik.Reporting.Drawing.Unit.Inch(0.14305560290813446R))
        Me.subrpt_BM_NSR10.Style.Visible = True
        '
        'subrpt_BM_OTO
        '
        Me.subrpt_BM_OTO.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.3020833432674408R), Telerik.Reporting.Drawing.Unit.Inch(3.1680564880371094R))
        Me.subrpt_BM_OTO.Name = "subrpt_BM_OTO"
        InstanceReportSource14.Parameters.Add(New Telerik.Reporting.Parameter("FileNo", "=Fields.FileNo"))
        InstanceReportSource14.ReportDocument = Me.OTOSubReport
        Me.subrpt_BM_OTO.ReportSource = InstanceReportSource14
        Me.subrpt_BM_OTO.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6730656623840332R), Telerik.Reporting.Drawing.Unit.Inch(0.14305560290813446R))
        Me.subrpt_BM_OTO.Style.Visible = True
        '
        'subrpt_BM_MEM
        '
        Me.subrpt_BM_MEM.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.3020833432674408R), Telerik.Reporting.Drawing.Unit.Inch(2.8298614025115967R))
        Me.subrpt_BM_MEM.Name = "subrpt_BM_MEM"
        InstanceReportSource15.Parameters.Add(New Telerik.Reporting.Parameter("FileNo", "=Fields.FileNo"))
        InstanceReportSource15.ReportDocument = Me.MEMSubReport
        Me.subrpt_BM_MEM.ReportSource = InstanceReportSource15
        Me.subrpt_BM_MEM.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6730656623840332R), Telerik.Reporting.Drawing.Unit.Inch(0.14305560290813446R))
        Me.subrpt_BM_MEM.Style.BackgroundColor = System.Drawing.Color.White
        Me.subrpt_BM_MEM.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.subrpt_BM_MEM.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.subrpt_BM_MEM.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.subrpt_BM_MEM.Style.Font.Bold = True
        Me.subrpt_BM_MEM.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.subrpt_BM_MEM.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.subrpt_BM_MEM.Style.Visible = True
        '
        'subrpt_BM_EEM
        '
        Me.subrpt_BM_EEM.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.3020833432674408R), Telerik.Reporting.Drawing.Unit.Inch(2.4916667938232422R))
        Me.subrpt_BM_EEM.Name = "subrpt_BM_EEM"
        InstanceReportSource16.Parameters.Add(New Telerik.Reporting.Parameter("FileNo", "=Fields.FileNo"))
        InstanceReportSource16.ReportDocument = Me.EEMSubReport
        Me.subrpt_BM_EEM.ReportSource = InstanceReportSource16
        Me.subrpt_BM_EEM.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6730656623840332R), Telerik.Reporting.Drawing.Unit.Inch(0.14305560290813446R))
        Me.subrpt_BM_EEM.Style.BackgroundColor = System.Drawing.Color.White
        Me.subrpt_BM_EEM.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.subrpt_BM_EEM.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.subrpt_BM_EEM.Style.Font.Bold = True
        Me.subrpt_BM_EEM.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.subrpt_BM_EEM.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.subrpt_BM_EEM.Style.Visible = True
        '
        'subrpt_BM_BPVM
        '
        Me.subrpt_BM_BPVM.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(29.0R), Telerik.Reporting.Drawing.Unit.Inch(2.1500000953674316R))
        Me.subrpt_BM_BPVM.Name = "subrpt_BM_BPVM"
        InstanceReportSource17.Parameters.Add(New Telerik.Reporting.Parameter("FileNo", "=Fields.FileNo"))
        InstanceReportSource17.ReportDocument = Me.BPVMSubReport
        Me.subrpt_BM_BPVM.ReportSource = InstanceReportSource17
        Me.subrpt_BM_BPVM.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6730656623840332R), Telerik.Reporting.Drawing.Unit.Inch(0.14305560290813446R))
        Me.subrpt_BM_BPVM.Style.BackgroundColor = System.Drawing.Color.White
        Me.subrpt_BM_BPVM.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.subrpt_BM_BPVM.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.subrpt_BM_BPVM.Style.Font.Bold = True
        Me.subrpt_BM_BPVM.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.subrpt_BM_BPVM.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        '
        'QorReport
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
        Group10.GroupFooter = Me.GroupFooterSection1
        Group10.GroupHeader = Me.GroupHeaderSection1
        Group10.Name = "Group1"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1, Group2, Group3, Group4, Group5, Group6, Group7, Group8, Group9, Group10})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.GroupHeaderSection1, Me.GroupFooterSection1, Me.detail})
        Me.Name = "QorReport"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.25R), Telerik.Reporting.Drawing.Unit.Inch(0.25R), Telerik.Reporting.Drawing.Unit.Inch(0.25R), Telerik.Reporting.Drawing.Unit.Inch(0.25R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        Me.Style.BackgroundColor = System.Drawing.Color.White
        Me.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.UnitOfMeasure = Telerik.Reporting.Drawing.UnitType.Inch
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(7.9886565208435059R)
        CType(Me.RSBPFacilitySubReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RSBPFireRecommendations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CIMSubReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OOASubReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EcroSubReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ISCSubReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ITPSubReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NPR10SubReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NPR5SubReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NPR0SubReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NSR0SubReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NSR5SubReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NSR10SubReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OTOSubReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEMSubReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EEMSubReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BPVMSubReport, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox22 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox24 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox33 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox34 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox25 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox26 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox27 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox28 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox29 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox30 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox31 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox32 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox35 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox36 As Telerik.Reporting.TextBox
    Friend WithEvents HtmlTextBox2 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents txtFileNo As Telerik.Reporting.TextBox
    Friend WithEvents HtmlTextBox1 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents TextBox40 As Telerik.Reporting.TextBox
    Friend WithEvents HtmlTextBox10 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents subrpt_FIRE_ECRO As Telerik.Reporting.SubReport
    Friend WithEvents EcroSubReport As GRC.Connect.Libraries.ReportLib.QorRecommendations
    Friend WithEvents TextBox41 As Telerik.Reporting.TextBox
    Friend WithEvents subrpt_FIRE_ISC As Telerik.Reporting.SubReport
    Friend WithEvents ISCSubReport As GRC.Connect.Libraries.ReportLib.QorRecommendations
    Friend WithEvents TextBox46 As Telerik.Reporting.TextBox
    Friend WithEvents HtmlTextBox11 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents subrpt_FIRE_ITP As Telerik.Reporting.SubReport
    Friend WithEvents ITPSubReport As GRC.Connect.Libraries.ReportLib.QorRecommendations
    Friend WithEvents subrpt_FIRE_NPR5 As Telerik.Reporting.SubReport
    Friend WithEvents NPR5SubReport As GRC.Connect.Libraries.ReportLib.QorRecommendations
    Friend WithEvents subrpt_FIRE_NPR10 As Telerik.Reporting.SubReport
    Friend WithEvents subrpt_FIRE_CIM As Telerik.Reporting.SubReport
    Friend WithEvents CIMSubReport As GRC.Connect.Libraries.ReportLib.QorRecommendations
    Friend WithEvents TextBox48 As Telerik.Reporting.TextBox
    Friend WithEvents HtmlTextBox13 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents TextBox49 As Telerik.Reporting.TextBox
    Friend WithEvents HtmlTextBox14 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents HtmlTextBox15 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents TextBox50 As Telerik.Reporting.TextBox
    Friend WithEvents NPR10SubReport As GRC.Connect.Libraries.ReportLib.QorRecommendations
    Friend WithEvents TextBox53 As Telerik.Reporting.TextBox
    Friend WithEvents HtmlTextBox16 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents subrpt_FIRE_OOA As Telerik.Reporting.SubReport
    Friend WithEvents Panel2 As Telerik.Reporting.Panel
    Friend WithEvents TextBox56 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox57 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox58 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox59 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox60 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox61 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox64 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox65 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox66 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox67 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox68 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox69 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox70 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox71 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox72 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox73 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox74 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox75 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox76 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox77 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox78 As Telerik.Reporting.TextBox
    Friend WithEvents Panel3 As Telerik.Reporting.Panel
    Friend WithEvents TextBox79 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox80 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox81 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox82 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox83 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox84 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox85 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox86 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox87 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox88 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox89 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox90 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox91 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox92 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox93 As Telerik.Reporting.TextBox
    Friend WithEvents Panel4 As Telerik.Reporting.Panel
    Friend WithEvents TextBox94 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox95 As Telerik.Reporting.TextBox
    Friend WithEvents subrpt_BM_RSBP As Telerik.Reporting.SubReport
    Friend WithEvents RSBPFacilitySubReport As GRC.Connect.Libraries.ReportLib.QorRecommendations
    Friend WithEvents subrpt_FIRE_RSBP As Telerik.Reporting.SubReport
    Friend WithEvents RSBPFireRecommendations As GRC.Connect.Libraries.ReportLib.QorRecommendations
    Friend WithEvents Group1 As Telerik.Reporting.Group
    Friend WithEvents GroupFooterSection1 As Telerik.Reporting.GroupFooterSection
    Friend WithEvents GroupHeaderSection1 As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents Table1 As Telerik.Reporting.Table
    Friend WithEvents TextBox99 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox96 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox97 As Telerik.Reporting.TextBox
    Friend WithEvents Panel5 As Telerik.Reporting.Panel
    Friend WithEvents HtmlTextBox12 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents TextBox47 As Telerik.Reporting.TextBox
    Friend WithEvents subrpt_FIRE_NPR0 As Telerik.Reporting.SubReport
    Friend WithEvents Panel6 As Telerik.Reporting.Panel
    Friend WithEvents Panel7 As Telerik.Reporting.Panel
    Friend WithEvents Panel8 As Telerik.Reporting.Panel
    Friend WithEvents NPR0SubReport As GRC.Connect.Libraries.ReportLib.QorRecommendations
    Friend WithEvents TextBox98 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox100 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox54 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox55 As Telerik.Reporting.TextBox
    Friend WithEvents Panel13 As Telerik.Reporting.Panel
    Friend WithEvents HtmlTextBox3 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents subrpt_BM_BPVM As Telerik.Reporting.SubReport
    Friend WithEvents Panel14 As Telerik.Reporting.Panel
    Friend WithEvents HtmlTextBox4 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents subrpt_BM_EEM As Telerik.Reporting.SubReport
    Friend WithEvents Panel15 As Telerik.Reporting.Panel
    Friend WithEvents subrpt_BM_MEM As Telerik.Reporting.SubReport
    Friend WithEvents TextBox37 As Telerik.Reporting.TextBox
    Friend WithEvents HtmlTextBox5 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents Panel16 As Telerik.Reporting.Panel
    Friend WithEvents HtmlTextBox6 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents subrpt_BM_OTO As Telerik.Reporting.SubReport
    Friend WithEvents TextBox38 As Telerik.Reporting.TextBox
    Friend WithEvents Panel18 As Telerik.Reporting.Panel
    Friend WithEvents subrpt_BM_NSR10 As Telerik.Reporting.SubReport
    Friend WithEvents TextBox42 As Telerik.Reporting.TextBox
    Friend WithEvents HtmlTextBox8 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents Panel19 As Telerik.Reporting.Panel
    Friend WithEvents subrpt_BM_NSR5 As Telerik.Reporting.SubReport
    Friend WithEvents TextBox43 As Telerik.Reporting.TextBox
    Friend WithEvents HtmlTextBox9 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents Panel20 As Telerik.Reporting.Panel
    Friend WithEvents HtmlTextBox17 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents TextBox44 As Telerik.Reporting.TextBox
    Friend WithEvents subrpt_BM_NSR0 As Telerik.Reporting.SubReport
     Friend WithEvents TextBox45 As Telerik.Reporting.TextBox
     Friend WithEvents TextBox23 As Telerik.Reporting.TextBox
     Friend WithEvents TextBox51 As Telerik.Reporting.TextBox
     Friend WithEvents TextBox39 As Telerik.Reporting.TextBox
     Friend WithEvents TextBox52 As Telerik.Reporting.TextBox
     Friend WithEvents BPVMSubReport As GRC.Connect.Libraries.ReportLib.QorRecommendations
     Friend WithEvents EEMSubReport As GRC.Connect.Libraries.ReportLib.QorRecommendations
     Friend WithEvents MEMSubReport As GRC.Connect.Libraries.ReportLib.QorRecommendations
     Friend WithEvents OTOSubReport As GRC.Connect.Libraries.ReportLib.QorRecommendations
     Friend WithEvents NSR10SubReport As GRC.Connect.Libraries.ReportLib.QorRecommendations
     Friend WithEvents NSR5SubReport As GRC.Connect.Libraries.ReportLib.QorRecommendations
     Friend WithEvents NSR0SubReport As GRC.Connect.Libraries.ReportLib.QorRecommendations
     Friend WithEvents OOASubReport As GRC.Connect.Libraries.ReportLib.QorRecommendations
     Friend WithEvents TextBox62 As Telerik.Reporting.TextBox
     Friend WithEvents TextBox63 As Telerik.Reporting.TextBox
     Friend WithEvents TextBox101 As Telerik.Reporting.TextBox
     Friend WithEvents Panel1 As Telerik.Reporting.Panel
     Friend WithEvents Panel9 As Telerik.Reporting.Panel
     Friend WithEvents Panel10 As Telerik.Reporting.Panel
    Friend WithEvents Panel11 As Telerik.Reporting.Panel
    Friend WithEvents TextBox102 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox104 As Telerik.Reporting.TextBox
End Class