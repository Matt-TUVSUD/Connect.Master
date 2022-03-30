Partial Class BaseReport

	'NOTE: The following procedure is required by the telerik Reporting Designer
	'It can be modified using the telerik Reporting Designer.  
	'Do not modify it using the code editor.
	Private Sub InitializeComponent()
		Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
		Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
		Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
		Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
		Dim StyleRule5 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
		Dim StyleRule6 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
		Dim StyleRule7 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
		Dim StyleRule8 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		'
		'BaseReport
		'
		Me.Name = "BaseReport"
		Me.PageSettings.Margins.Bottom = Telerik.Reporting.Drawing.Unit.Inch(1.0R)
		Me.PageSettings.Margins.Left = Telerik.Reporting.Drawing.Unit.Inch(1.0R)
		Me.PageSettings.Margins.Right = Telerik.Reporting.Drawing.Unit.Inch(1.0R)
		Me.PageSettings.Margins.Top = Telerik.Reporting.Drawing.Unit.Inch(1.0R)
		Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
		StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Shadow")})
		StyleRule1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
		StyleRule1.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(3.0R)
		StyleRule1.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(0.5R)
		StyleRule1.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(3.0R)
		StyleRule1.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(0.5R)
		StyleRule2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Bold")})
		StyleRule2.Style.Font.Bold = True
		StyleRule3.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Red")})
		StyleRule3.Style.Color = System.Drawing.Color.Red
		StyleRule4.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Blue")})
		StyleRule4.Style.Color = System.Drawing.Color.Blue
		StyleRule5.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Center")})
		StyleRule5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
		StyleRule6.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Hide")})
		StyleRule6.Style.Visible = False
		StyleRule7.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Middle")})
		StyleRule7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
		StyleRule8.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("AllSolidBorder")})
		StyleRule8.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
		Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2, StyleRule3, StyleRule4, StyleRule5, StyleRule6, StyleRule7, StyleRule8})
		Me.Width = Telerik.Reporting.Drawing.Unit.Inch(6.0R)
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub

End Class