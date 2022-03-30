Imports System.Data.SqlClient

Namespace razor
    Partial Public Class TblMetaRatingKeyRange

        Public Shared Function FindRangeByScore(keyId As Integer, score As Long) As List(Of rowTblMetaRatingKeyRange)
            Dim zReturn As New List(Of rowTblMetaRatingKeyRange)
            Dim zSQL As String = "SELECT * FROM [tblMetaRatingKeyRange] WHERE [fldKeyId] = @colFldKeyId AND [fldScoreLow] => @colFldScore AND[fldScoreHigh] <= @colFldScore"
            Dim zCmd As New SqlCommand
            Dim zReader As SqlDataReader

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SqlParameter("@colFldKeyId", keyId))
            zCmd.Parameters.Add(New SqlParameter("@colFldScore", score))
            zReader = razor.UtilSQLServer.ExecuteReader(zCmd)

            While zReader.Read
                Dim zObj As New rowTblMetaRatingKeyRange
                If Not zReader.IsDBNull(zReader.GetOrdinal("fldId")) Then zObj.colFldId = zReader.GetSqlInt32(zReader.GetOrdinal("fldId"))
                If Not zReader.IsDBNull(zReader.GetOrdinal("fldKeyId")) Then zObj.colFldKeyId = zReader.GetSqlInt32(zReader.GetOrdinal("fldKeyId"))
                If Not zReader.IsDBNull(zReader.GetOrdinal("fldRating")) Then zObj.colFldRating = zReader.GetSqlString(zReader.GetOrdinal("fldRating"))
                If Not zReader.IsDBNull(zReader.GetOrdinal("fldDescription")) Then zObj.colFldDescription = zReader.GetSqlString(zReader.GetOrdinal("fldDescription"))
                If Not zReader.IsDBNull(zReader.GetOrdinal("fldScoreLow")) Then zObj.colFldScoreLow = zReader.GetSqlDouble(zReader.GetOrdinal("fldScoreLow"))
                If Not zReader.IsDBNull(zReader.GetOrdinal("fldScoreHigh")) Then zObj.colFldScoreHigh = zReader.GetSqlDouble(zReader.GetOrdinal("fldScoreHigh"))
                If Not zReader.IsDBNull(zReader.GetOrdinal("fldMetaColorId")) Then zObj.colFldMetaColorId = zReader.GetSqlInt32(zReader.GetOrdinal("fldMetaColorId"))
                zReturn.Add(zObj)
            End While

            zReader.Close()
            zReader = Nothing

            Return zReturn
        End Function

        Public Shared Function FindRangeByRating(keyId As Integer, rating As String) As List(Of rowTblMetaRatingKeyRange)
            Dim zReturn As New List(Of rowTblMetaRatingKeyRange)
            Dim zSQL As String = "SELECT * FROM [tblMetaRatingKeyRange] WHERE [fldKeyId] = @colFldKeyId AND [fldRating] = @colFldRating"
            Dim zCmd As New SqlCommand
            Dim zReader As SqlDataReader

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SqlParameter("@colFldKeyId", keyId))
            zCmd.Parameters.Add(New SqlParameter("@colFldRating", rating))
            zReader = razor.UtilSQLServer.ExecuteReader(zCmd)

            While zReader.Read
                Dim zObj As New rowTblMetaRatingKeyRange
                If Not zReader.IsDBNull(zReader.GetOrdinal("fldId")) Then zObj.colFldId = zReader.GetSqlInt32(zReader.GetOrdinal("fldId"))
                If Not zReader.IsDBNull(zReader.GetOrdinal("fldKeyId")) Then zObj.colFldKeyId = zReader.GetSqlInt32(zReader.GetOrdinal("fldKeyId"))
                If Not zReader.IsDBNull(zReader.GetOrdinal("fldRating")) Then zObj.colFldRating = zReader.GetSqlString(zReader.GetOrdinal("fldRating"))
                If Not zReader.IsDBNull(zReader.GetOrdinal("fldDescription")) Then zObj.colFldDescription = zReader.GetSqlString(zReader.GetOrdinal("fldDescription"))
                If Not zReader.IsDBNull(zReader.GetOrdinal("fldScoreLow")) Then zObj.colFldScoreLow = zReader.GetSqlDouble(zReader.GetOrdinal("fldScoreLow"))
                If Not zReader.IsDBNull(zReader.GetOrdinal("fldScoreHigh")) Then zObj.colFldScoreHigh = zReader.GetSqlDouble(zReader.GetOrdinal("fldScoreHigh"))
                If Not zReader.IsDBNull(zReader.GetOrdinal("fldMetaColorId")) Then zObj.colFldMetaColorId = zReader.GetSqlInt32(zReader.GetOrdinal("fldMetaColorId"))
                zReturn.Add(zObj)
            End While

            zReader.Close()
            zReader = Nothing

            Return zReturn
        End Function
    End Class

    Partial Public Class rowTblMetaRatingKeyRange

        Public Function ToColor() As System.Drawing.Color
            Dim zList As List(Of rowTblMetaColor) = TblMetaColor.LoadByIDX_PK_tblMetaColor(colFldMetaColorId)
            If zList.Count > 0 Then
                Return System.Drawing.ColorTranslator.FromHtml(zList(0).colFldHex)
            Else
                Return System.Drawing.Color.Transparent
            End If
        End Function



    End Class
End Namespace