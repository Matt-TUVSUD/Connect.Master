Imports GRC.Connect.Libraries.DataLib.razor

Public Class UtilProgramStatusProc
    Public PropSafeGUID As String
    Public PropDivision As String
    Public PropCustomAccess As String

    Public Function GetProgramStatusData() As DataTable
        Dim zReturn As DataTable
        Dim zCmd As New SqlClient.SqlCommand

        zCmd.CommandText = "sproc_CalcProgramStatus"
        zCmd.CommandType = CommandType.StoredProcedure

        zCmd.Parameters.AddWithValue("SID", PropSafeGUID)
        zCmd.Parameters.AddWithValue("CustomAccess", PropCustomAccess)
        zCmd.Parameters.AddWithValue("Division", PropDivision)

        Dim zReader As SqlClient.SqlDataReader
        zReader = UtilSQLServer.ExecuteReader(zCmd)
        zReturn = New DataTable
        zReturn.Load(zReader)
        zReader.Close()

        'serialize to json
        Dim zJSON As String = Newtonsoft.Json.JsonConvert.SerializeObject(zReturn)
        'My.Computer.FileSystem.WriteAllText("c:\temp\ProgramStatus.json", zJSON, False)

        Return zReturn

    End Function
End Class
