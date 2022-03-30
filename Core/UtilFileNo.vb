Imports GRC.Connect.Libraries.DataLib.razor

Public Class UtilFileNo

    Public Shared Function BuildList(pFilePrefix As String) As List(Of String)
        Dim zBaseLocations As List(Of rowVwAllLocations) = VwAllLocations.LoadData(GetCommand(pFilePrefix))
        Return zBaseLocations.ToDictionary(Function(x) x.colFileNo).Keys.ToList
    End Function

    Public Shared Function BuildList(pFilePrefix As String, pJSONFilter As JSONFilter) As List(Of String)
        If IsNothing(pJSONFilter) Then
            Return BuildList(pFilePrefix)
        Else
            Return BuildList(pFilePrefix, pJSONFilter.ToJSON)
        End If
    End Function

    Public Shared Function BuildList(pFilePrefix As String, pField As LocationField, pValue As String) As List(Of String)
        Dim zJsonFilter As New JSONFilter
        zJsonFilter.Filters.Add(New JSONFilterItem(pField.ToString, JSONFilterOperator.Operators.Equal, pValue))
        zJsonFilter.Logic = JSONFilterLogic.Operators.And
        Return BuildList(pFilePrefix, zJsonFilter)
    End Function

    Public Shared Function BuildList(pFilePrefix As String, pJSON As String) As List(Of String)
        If pJSON = "" Or pJSON = "null" Then
            Return BuildList(pFilePrefix)
        Else
            'Dim zMaker As New UtilSQLMaker
            'Dim zFilter As New UtilFilter
            'zFilter.SetFilter(pJSON, zMaker)

            Dim zQ As New queryVwAllLocations
            zQ.SelectAll()
            zQ.Where.Add(zQ.colFilePrefix.Equals(pFilePrefix))

            Dim zFS As New UtilFilterSort
            zFS.SetFilter(pJSON, zQ)

            Dim zBaseLocations As List(Of rowVwAllLocations) = VwAllLocations.LoadData(zQ.QueryText)

            'Dim zBaseLocations As List(Of rowVwAllLocations) = VwAllLocations.LoadData(GetCommand(pFilePrefix, zMaker.Where.ToSQL(False)))
            Return zBaseLocations.ToDictionary(Function(x) x.colFileNo).Keys.ToList
        End If
    End Function

    Public Shared Function BuildListFromGsafe(pGsafeId As Integer) As List(Of String)
        Dim zReturn As New List(Of String)
        Dim zList As List(Of rowGSafeFileNo) = TblGSafeFileNo.LoadByIDX_IX_GsafeID(pGsafeId)
        zList.ForEach(Sub(x) zReturn.Add(x.colFileNo))
        Return zReturn
    End Function

    Public Shared Function GetCommand(pFilePrefix As String) As SqlClient.SqlCommand
        Dim zCmd As New SqlClient.SqlCommand("SELECT * FROM jv.VwAllLocations WHERE FilePrefix=@FilePrefix")
        zCmd.Parameters.AddWithValue("@FilePrefix", pFilePrefix)
        Return zCmd
    End Function

    Public Shared Function GetCommand(pFilePrefix As String, pWhereSQL As String) As SqlClient.SqlCommand
        Dim zCmd As SqlClient.SqlCommand = GetCommand(pFilePrefix)
        zCmd.CommandText = zCmd.CommandText & " AND " & Replace(pWhereSQL, "WHERE", "")
        Return zCmd
    End Function

    Public Enum LocationField
        ClientLocNo = 1
        Division
        Facility
        City
        StProv
        Country
        CustomAccess
    End Enum

End Class
