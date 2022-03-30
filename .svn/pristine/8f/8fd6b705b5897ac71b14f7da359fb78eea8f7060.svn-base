Imports GRC.Connect.Libraries.CoreLib
Imports Telerik.Reporting.Charting
Imports System.Drawing

Public Class QorChartPalette
     Inherits Telerik.Reporting.Charting.Palette

     Public Sub New()
          Me.Name = "QorPalette"
          Me.Items.Add(BluePaletteItem)
          Me.Items.Add(GreenPaletteItem)
          Me.Items.Add(RedPaletteItem)
          Me.Items.Add(YellowPaletteItem)
          Me.Items.Add(PurplePaletteItem)

     End Sub

     Public ReadOnly Property BluePaletteItem As PaletteItem
          Get
               Dim zItem As New PaletteItem()
               zItem.Name = "Blue"
            zItem.MainColor = UtilReporting.Chart.GetSolidColor(UtilReporting.Chart.ChartColor.Blue)
            zItem.SecondColor = UtilReporting.Chart.GetSolidColor(UtilReporting.Chart.ChartColor.Blue)
            Return zItem
        End Get
    End Property

    Public ReadOnly Property RedPaletteItem As PaletteItem
        Get
            Dim zItem As New PaletteItem()
            zItem.Name = "Red"
            zItem.MainColor = UtilReporting.Chart.GetSolidColor(UtilReporting.Chart.ChartColor.Red)
            zItem.SecondColor = UtilReporting.Chart.GetSolidColor(UtilReporting.Chart.ChartColor.Red)
            Return zItem
        End Get
    End Property

    Public ReadOnly Property YellowPaletteItem As PaletteItem
        Get
            Dim zItem As New PaletteItem()
            zItem.Name = "Yellow"
            zItem.MainColor = UtilReporting.Chart.GetSolidColor(UtilReporting.Chart.ChartColor.Yellow)
            zItem.SecondColor = UtilReporting.Chart.GetSolidColor(UtilReporting.Chart.ChartColor.Yellow)
            Return zItem
        End Get
    End Property

    Public ReadOnly Property GreenPaletteItem As PaletteItem
        Get
            Dim zItem As New PaletteItem()
            zItem.Name = "Green"
            zItem.MainColor = UtilReporting.Chart.GetSolidColor(UtilReporting.Chart.ChartColor.Green)
            zItem.SecondColor = UtilReporting.Chart.GetSolidColor(UtilReporting.Chart.ChartColor.Green)
            Return zItem
        End Get
    End Property

    Public ReadOnly Property PurplePaletteItem As PaletteItem
        Get
            Dim zItem As New PaletteItem()
            zItem.Name = "Brown"
            zItem.MainColor = UtilReporting.Chart.GetSolidColor(UtilReporting.Chart.ChartColor.Purple)
            zItem.SecondColor = UtilReporting.Chart.GetSolidColor(UtilReporting.Chart.ChartColor.Purple)
            Return zItem
        End Get
    End Property

End Class
