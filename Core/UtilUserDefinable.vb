Public Class UtilUserDefinable

    Public Shared Function ColumnName(pName As String, ByVal pLabels As Dictionary(Of String, String)) As String
        Dim zValue As String = ""
        If pLabels.TryGetValue(pName, zValue) Then
            Return zValue
        Else
            Return String.Empty
        End If
    End Function

End Class
