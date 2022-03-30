
Imports System.Data.SqlClient

Namespace razor
    Partial Public Class TblMetaTIV

        Public Shared Function GetTenthHighest(pFilePrefix As String) As Double
            Dim zSQL As String = "SELECT MIN(Tivus) from [sv].[vwTopTenTIV] where FilePrefix=@FilePrefix"

            Dim zCmd As New SqlCommand
            zCmd.CommandText = zSQL
            zCmd.CommandType = CommandType.Text
            zCmd.Parameters.Add(New SqlClient.SqlParameter("@FilePrefix", pFilePrefix))

            Dim zReturn As Double = 0.0

            zReturn = razor.UtilSQLServer.ExecuteScalar(zCmd)

            Return zReturn

        End Function

        Public Enum TIVRanges
            All = 1
            Top10Highest = 2
            Greater50Million = 3
            Greater100Million = 4
            Greater250Million = 5
        End Enum

    End Class

End Namespace


