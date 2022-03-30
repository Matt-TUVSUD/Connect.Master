Imports GRC.Connect.Libraries.DataLib.razor

Public Class UtilRecFollowUpStatus
    Public PropSafeGUID As String
    Public PropDivision As String
    Public PropCustomAccess As String
    Public PropStartDate As String
    Public PropEndDate As String

    Public Function GetRecFollowUpStatusData() As DataTable
        Dim zReturn As DataTable
        Dim zCmd As New SqlClient.SqlCommand

        zCmd.CommandText = "sproc_CalcRecFollowUpStatus"
        zCmd.CommandType = CommandType.StoredProcedure

        Dim zStartDate As New Date(1980, 1, 1)
        If Not PropStartDate Is Nothing Then
            If PropStartDate.Length > 0 Then
                zStartDate = Date.Parse(PropStartDate)
            End If
        End If

        Dim zEndDate As New Date(2999, 1, 1)
        If Not PropEndDate Is Nothing Then
            If PropEndDate.Length > 0 Then
                zEndDate = Date.Parse(PropEndDate)
            End If
        End If

        zCmd.Parameters.AddWithValue("SID", PropSafeGUID)
        zCmd.Parameters.AddWithValue("CustomAccess", PropCustomAccess)
        zCmd.Parameters.AddWithValue("Division", PropDivision)
        zCmd.Parameters.AddWithValue("StartDate", zStartDate)
        zCmd.Parameters.AddWithValue("EndDate", zEndDate)

        Dim zReader As SqlClient.SqlDataReader
        zReader = UtilSQLServer.ExecuteReader(zCmd)
        zReturn = New DataTable
        zReturn.Load(zReader)
        zReader.Close()

        'serialize to json
        Dim zJSON As String = Newtonsoft.Json.JsonConvert.SerializeObject(zReturn)
        'My.Computer.FileSystem.WriteAllText("c:\temp\RecFollowUpStatus.json", zJSON, False)

        Return zReturn

    End Function
End Class
