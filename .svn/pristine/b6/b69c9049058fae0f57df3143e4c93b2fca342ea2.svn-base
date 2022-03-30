Imports GRC.Connect.Libraries.DataLib.razor
Imports GRC.Connect.Libraries.FilterSortLib

Public Class Queries
    Inherits queryVwWhatIfFireFacilityRating
    Implements IFilterable
    Implements ISortable

    Public Sub ApplyFilter(pFilterJSON As String) Implements IFilterable.ApplyFilter
        If pFilterJSON <> "" AndAlso Not fsFilter.IsEmpty(pFilterJSON) Then
            Me.Where.Add(fsFilter.ToSQL(pFilterJSON))
        End If
    End Sub

    Public Sub ApplySort(pSortJSON As String) Implements ISortable.ApplySort
        If pSortJSON <> "" Then
            Me.OrderBy(fsSort.ToSQL(pSortJSON))
        End If
    End Sub

    Public Function RecordCount() As Integer
        Me.CountAll = True
        Return CInt(UtilSQLServer.ExecuteScalar(New SqlClient.SqlCommand(Me.QueryText)))
    End Function
End Class

Public Class LocationQuery
    Inherits queryTblWhatIfLocation
    Implements IFilterable
    Implements ISortable

    Public Sub ApplyFilter(pFilterJSON As String) Implements IFilterable.ApplyFilter
        If pFilterJSON <> "" AndAlso Not fsFilter.IsEmpty(pFilterJSON) Then
            Me.Where.Add(fsFilter.ToSQL(pFilterJSON))
        End If
    End Sub

    Public Sub ApplySort(pSortJSON As String) Implements ISortable.ApplySort
        If pSortJSON <> "" Then
            Me.OrderBy(fsSort.ToSQL(pSortJSON))
        End If
    End Sub

End Class

Public Class RecGridQuery
    Inherits queryVwWhatIfFireRecGrid
    Implements IFilterable
    Implements ISortable

    Public Sub ApplyFilter(pFilterJSON As String) Implements IFilterable.ApplyFilter
        If pFilterJSON <> "" AndAlso Not fsFilter.IsEmpty(pFilterJSON) Then
            Me.Where.Add(fsFilter.ToSQL(pFilterJSON))
        End If
    End Sub

    Public Sub ApplySort(pSortJSON As String) Implements ISortable.ApplySort
        If pSortJSON <> "" Then
            Me.OrderBy(fsSort.ToSQL(pSortJSON))
        End If
    End Sub

    Public Function RecordCount() As Integer
        Me.CountAll = True
        Return CInt(UtilSQLServer.ExecuteScalar(New SqlClient.SqlCommand(Me.QueryText)))
    End Function

End Class


