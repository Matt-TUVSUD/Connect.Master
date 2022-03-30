Public Interface IGridData
    Property Data As List(Of Dictionary(Of String, Object))
    Property Total As Integer
    Property Filter As String
    Property Sort As String
    Property Currency As String
    Property StartRow As Integer
    Property EndRow As Integer
End Interface
