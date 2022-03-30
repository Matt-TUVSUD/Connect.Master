
Imports Telerik.Reporting.Charting
Imports System.Drawing

Public Class FireImpairmentChartPalette
    Inherits Telerik.Reporting.Charting.Palette

     Public Sub New()
          Me.Name = "ImpairmentPalette"
          Me.Items.Add(GreenPaletteItem)
          Me.Items.Add(YellowPaletteItem)
          Me.Items.Add(RedPaletteItem)
          Me.Items.Add(BluePaletteItem)
          Me.Items.Add(PurplePaletteItem)
     End Sub

     Public ReadOnly Property BluePaletteItem As PaletteItem
          Get
               Dim zItem As New PaletteItem()
               zItem.Name = "Blue"
               zItem.AdditionalColors.AddRange(CreateColorBlend(ChartColor.Blue))
               Return zItem
          End Get
     End Property

     Public ReadOnly Property RedPaletteItem As PaletteItem
          Get
               Dim zItem As New PaletteItem()
               zItem.Name = "Red"
               zItem.AdditionalColors.AddRange(CreateColorBlend(ChartColor.Red))
               Return zItem
          End Get
     End Property

     Public ReadOnly Property YellowPaletteItem As PaletteItem
          Get
               Dim zItem As New PaletteItem()
               zItem.Name = "Yellow"
               zItem.AdditionalColors.AddRange(CreateColorBlend(ChartColor.Yellow))
               Return zItem
          End Get
     End Property

     Public ReadOnly Property GreenPaletteItem As PaletteItem
          Get
               Dim zItem As New PaletteItem()
               zItem.Name = "Green"
               zItem.AdditionalColors.AddRange(CreateColorBlend(ChartColor.Green))
               Return zItem
          End Get
     End Property

     Public ReadOnly Property PurplePaletteItem As PaletteItem
          Get
               Dim zItem As New PaletteItem()
               zItem.Name = "Purple"
               zItem.AdditionalColors.AddRange(CreateColorBlend(ChartColor.Purple))
               Return zItem
          End Get
     End Property

     Public Function CreateColorBlend(ByVal pColor As ChartColor) As Telerik.Reporting.Charting.ColorBlend
          Dim zColors As System.Drawing.Color() = Nothing

          Select Case pColor

               Case ChartColor.Blue
                zColors = UtilReporting.Chart.BlueGradient
               Case ChartColor.Yellow
                zColors = UtilReporting.Chart.YellowGradient
               Case ChartColor.Red
                zColors = UtilReporting.Chart.RedGradient
               Case ChartColor.Green
                zColors = UtilReporting.Chart.GreenGradient
               Case ChartColor.Purple
                zColors = UtilReporting.Chart.PurpleGradient
          End Select

          Dim zBlend As New Telerik.Reporting.Charting.ColorBlend()
          Dim zIdx As Single = 0.0
          Dim zIncrement As Single = 1.0 / zColors.Count

          For Each zColor In zColors
               If Array.IndexOf(zColors, zColor) = zColors.GetLowerBound(0) Then
                    zBlend.Add(New Telerik.Reporting.Charting.GradientElement(zColor, 0.0))
               ElseIf Array.IndexOf(zColors, zColor) <> zColors.GetUpperBound(0) Then
                    zIdx += zIncrement
                    zBlend.Add(New Telerik.Reporting.Charting.GradientElement(zColor, zIdx))
               Else
                    zBlend.Add(New Telerik.Reporting.Charting.GradientElement(zColor, 1.0))
               End If
          Next
          Return zBlend
     End Function



     Public Enum ChartColor
          Green
          Yellow
          Red
          Blue
          Purple
     End Enum



End Class
