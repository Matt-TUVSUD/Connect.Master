Public Class ColumnChartSeries
    Public Property Name As String
    Public Property Color As System.Drawing.Color
    Public Property Y As New List(Of Object)
    Public Property YText As New List(Of String)

    Public Sub New(pName As String, pColor As System.Drawing.Color, ParamArray zY As Object())
        Me.Name = pName
        Me.Color = pColor
        Me.Y = zY.ToList()
        zY.ToList.ForEach(Sub(x) YText.Add(x.ToString))
    End Sub

    Public Sub New(pName As String, pColorHex As String, ParamArray zY As Object())
        Me.Name = pName
        Me.Color = System.Drawing.ColorTranslator.FromHtml(pColorHex)
        Me.Y = zY.ToList()
        zY.ToList.ForEach(Sub(x) YText.Add(x.ToString))
    End Sub

    Public Sub AddY(pYText As String, pY As Object)
        Y.Add(pY)
        YText.Add(pYText)
    End Sub

    Public Sub AddY(pY As Object)
        Y.Add(pY)
        YText.Add(pY.ToString())
    End Sub

End Class
