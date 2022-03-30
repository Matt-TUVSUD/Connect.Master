
Partial Class TblGSafeFileNo

    Public Shared Function GetFileNos(gSafeId As Integer) As String()
        Dim zFileNoList As List(Of rowGSafeFileNo) = TblGSafeFileNo.LoadByIDX_IX_GsafeID(gSafeId)
        Dim zFileNos As New List(Of String)
        For Each zSafeFileNo As rowGSafeFileNo In zFileNoList
            zFileNos.Add(zSafeFileNo.colFileNo)
        Next
        Return zFileNos.ToArray
    End Function
End Class
