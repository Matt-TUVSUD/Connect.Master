Public Class ColumnChart

    Public Property Series As New List(Of ColumnChartSeries)

    Public Property Title As String

    Public Property X As New List(Of Object)

    Public Property ShowLegend As Boolean = True

    Public Sub New(pTitle As String, ParamArray pX As Object())
        Me.Title = pTitle
        Me.X = pX.ToList()
    End Sub

    Public Function GetDataPoints() As List(Of ColumnChartSeriesItem)
        Dim zList As New List(Of ColumnChartSeriesItem)

        For Each zS As ColumnChartSeries In Series
            For i = 0 To zS.Y.Count - 1 Step 1
                Dim zItem As New ColumnChartSeriesItem
                zItem.Series = zS.Name
                zItem.X = X(i)
                zItem.Y0 = 0
                zItem.Y = zS.Y(i)
                zItem.Color = System.Drawing.ColorTranslator.ToHtml(zS.Color)
                zItem.Text = zS.YText(i)
                zList.Add(zItem)
            Next
        Next
        Return zList
    End Function


End Class
