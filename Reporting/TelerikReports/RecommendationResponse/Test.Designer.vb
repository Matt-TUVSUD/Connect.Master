Partial Class Test
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
          Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
          Me.detail = New Telerik.Reporting.DetailSection()
          Me.pageFooterSection1 = New Telerik.Reporting.PageFooterSection()
          CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
          '
          'pageHeaderSection1
          '
          Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(2.0R)
          Me.pageHeaderSection1.Name = "pageHeaderSection1"
          '
          'detail
          '
          Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(2.0R)
          Me.detail.Name = "detail"
          '
          'pageFooterSection1
          '
          Me.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(2.0R)
          Me.pageFooterSection1.Name = "pageFooterSection1"
          '
          'Test
          '
          Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pageHeaderSection1, Me.detail, Me.pageFooterSection1})
          Me.Name = "Test"
          Me.PageSettings.Margins.Bottom = Telerik.Reporting.Drawing.Unit.Inch(1.0R)
          Me.PageSettings.Margins.Left = Telerik.Reporting.Drawing.Unit.Inch(1.0R)
          Me.PageSettings.Margins.Right = Telerik.Reporting.Drawing.Unit.Inch(1.0R)
          Me.PageSettings.Margins.Top = Telerik.Reporting.Drawing.Unit.Inch(1.0R)
          Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
          Me.Width = Telerik.Reporting.Drawing.Unit.Inch(6.0R)
          CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

     End Sub
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
End Class