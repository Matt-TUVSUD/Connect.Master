Public Class ColumnChartList
    Inherits List(Of ColumnChart)

    Public Function GetDataPoints() As List(Of ColumnChartSeriesItem)
        Dim zList As New List(Of ColumnChartSeriesItem)
        For Each pChart As ColumnChart In Me
            zList.AddRange(pChart.GetDataPoints.ToArray)
        Next
        Return zList
    End Function

End Class
