
Public Class MapCollection

    Inherits Collections.Generic.List(Of Map)

    Overloads Sub Add(ByVal pEntityColumnName As String, ByVal pExcelColumnName As String)

        Dim zMap As New Map
        zMap.EntityColumnName = pEntityColumnName
        zMap.ExcelColumnName = pExcelColumnName
        Me.Add(zMap)

    End Sub

    Public Function GetExcelColumnNames() As List(Of String)
        Return Me.Select(Function(x) x.ExcelColumnName).ToList
    End Function

    Public Function GetEntityColumnNames() As List(Of String)
        Return Me.Select(Function(x) x.EntityColumnName).ToList
    End Function

End Class

