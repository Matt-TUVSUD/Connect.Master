Imports GRC.Connect.Libraries.DataLib.razor
Imports System.Data.SqlClient


Public Class UtilMapRadius
    Public Shared Sub AddParms(pLatitude As String, pLongitude As String, pUnit As String, pRadius As String, pNameYourSearch As String, gSafeGuid As String)
        'Clear out old parm for this user
        Dim zQ As New queryGSafeFileNoRadiusParms
        zQ.SelectAll()
        zQ.Where.Add(zQ.colGSafeId.Equals(CoreLib.UtilGSafe.GetId(gSafeGuid)))
        Dim zList As New List(Of rowGSafeFileNoRadiusParms)
        zList = GSafeFileNoRadiusParms.LoadData(zQ.QueryText)

        For Each zItem As rowGSafeFileNoRadiusParms In zList
            GSafeFileNoRadiusParms.Delete(zItem)
        Next

        'Save new parms
        Dim zRow As New rowGSafeFileNoRadiusParms
        zRow.colGSafeId = CoreLib.UtilGSafe.GetId(gSafeGuid)
        zRow.colLatitude = Convert.ToDecimal(pLatitude)
        zRow.colLongitude = Convert.ToDecimal(pLongitude)
        zRow.colUnits = pUnit
        zRow.colInputRange = Convert.ToDouble(pRadius)
        zRow.colSearchName = pNameYourSearch

        GSafeFileNoRadiusParms.Save(zRow)
    End Sub

    Public Shared Sub Execute_spGeoLocateRadius(gSafeGuid As String)
        Dim zSQL As String = ""
        Dim zCmd As New SqlCommand
        zCmd.CommandType = CommandType.StoredProcedure
        zSQL = "spGeoLocateRadius"
        zCmd.CommandText = zSQL
        zCmd.Parameters.Add(New SqlParameter("@GSafeGUID", gSafeGuid))

        UtilSQLServer.ExecuteNonQuery(zCmd)
    End Sub

End Class
