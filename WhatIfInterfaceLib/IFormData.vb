Public Interface IFormData
    Property Filter As String
    Property TotalSelected As Integer
    Property TotalSelectedScoreChange As Single
    Property HumanElementSelected As Integer
    Property HumanElementSelectedScoreChange As Single
    Property EstCost As Integer
    Property Charts As ChartingLib.ColumnChartList
End Interface
