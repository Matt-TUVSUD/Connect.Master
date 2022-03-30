Imports System.Data.SqlClient

Namespace razor
    Partial Public Class VwLastInspectionDate

        Public Shared Function GetLastInspectionDate(pFileNo As String, pMetaPractice As TblMetaPractice.Practices) As Date
            Dim zReturn As New List(Of rowVwLastInspectionDate)
            Dim zSQL As String = "SELECT * FROM [sv].[vwLastInspectionDate] WHERE FileNo=@FileNo AND MetaPracticeId=@MetaPracticeId"
            Dim zCmd As New SqlCommand
            Dim zFnParm As New SqlClient.SqlParameter("@FileNo", pFileNo)
            Dim zPracticeParm As New SqlClient.SqlParameter("@MetaPracticeId", pMetaPractice)
            zCmd.Parameters.Add(zFnParm)
            zCmd.Parameters.Add(zPracticeParm)

            Dim zReader As SqlDataReader

            zCmd.CommandText = zSQL
            zReader = razor.UtilSQLServer.ExecuteReader(zCmd)

            While zReader.Read
                Dim zObj As New rowVwLastInspectionDate
                If Not zReader.IsDBNull(zReader.GetOrdinal("MetaPracticeId")) Then zObj.colMetaPracticeId = zReader.GetSqlInt32(zReader.GetOrdinal("MetaPracticeId"))
                If Not zReader.IsDBNull(zReader.GetOrdinal("FileNo")) Then zObj.colFileNo = zReader.GetSqlString(zReader.GetOrdinal("FileNo"))
                If Not zReader.IsDBNull(zReader.GetOrdinal("LastInspectionDate")) Then zObj.colLastInspectionDate = zReader.GetSqlDateTime(zReader.GetOrdinal("LastInspectionDate"))
                zReturn.Add(zObj)
            End While

            zReader.Close()
            zReader = Nothing

            Return zReturn(0).colLastInspectionDate

        End Function
    End Class
End Namespace