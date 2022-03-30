Imports System.Data.SqlClient
Imports GRC.Connect.Libraries.DataLib.razor

Partial Public Class TblGSafeFileNo

    Public Shared Sub Delete(ByRef pRowData As rowGSafeFileNo)
        Dim zSQL As String = ""
        Dim zMode As String = ""

        If UtilSQLServer.IsKeySet(pRowData.colGSafeId) And UtilSQLServer.IsKeySet(pRowData.colFileNo) Then
            'Delete
            zMode = "DELETE"
            zSQL = "DELETE FROM [GSafeFileNo] " & _
                    "WHERE [GSafeId] = @colGSafeId AND [FileNo] = @colFileNo"

            Dim zCmd As New SqlCommand
            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SqlParameter("@colGSafeId", pRowData.colGSafeId))
            zCmd.Parameters.Add(New SqlParameter("@colFileNo", pRowData.colFileNo))

            UtilSQLServer.ExecuteNonQuery(zCmd)
        End If

    End Sub

    Public Shared Sub Save(ByRef pRowData As rowGSafeFileNo)
        Dim zSQL As String = ""
        Dim zMode As String = ""
        Dim zExistInDB As Long = -1
        If UtilSQLServer.IsKeySet(pRowData.colGSafeId) And UtilSQLServer.IsKeySet(pRowData.colFileNo) Then

            zSQL = "SELECT COUNT(*) from [GSafeFileNo] WHERE [GSafeId] = @colGSafeId AND [FileNo] = @colFileNo"

            Dim zCmdDoesExist As New SqlCommand

            zCmdDoesExist.CommandText = zSQL

            zCmdDoesExist.Parameters.Add(New SqlParameter("@colGSafeId", pRowData.colGSafeId))
            zCmdDoesExist.Parameters.Add(New SqlParameter("@colFileNo", pRowData.colFileNo))

            'if zExistInDB > 0  then  PK exists in the DB
            zExistInDB = UtilSQLServer.ExecuteScalar(zCmdDoesExist)
        End If

        If UtilSQLServer.IsKeySet(pRowData.colGSafeId) And UtilSQLServer.IsKeySet(pRowData.colFileNo) And zExistInDB > 0 Then
            zMode = "UPDATE"
        End If
        If UtilSQLServer.IsKeySet(pRowData.colGSafeId) And UtilSQLServer.IsKeySet(pRowData.colFileNo) And zExistInDB = 0 Then
            zMode = "INSERTwithKey"
        End If
        If Not UtilSQLServer.IsKeySet(pRowData.colGSafeId) Or Not UtilSQLServer.IsKeySet(pRowData.colFileNo) Then
            zMode = "INSERTnoKey"
        End If

        Select Case zMode
            Case "UPDATE"
                zSQL = "UPDATE [GSafeFileNo] SET " & _
                        " WHERE [GSafeId] = @colGSafeId AND [FileNo] = @colFileNo"
            Case "INSERTwithKey"
                zSQL = "INSERT INTO [GSafeFileNo] ([GSafeId], [FileNo])" & _
                        " VALUES (@colGSafeId, @colFileNo)"
            Case "INSERTnoKey"
                zSQL = "INSERT INTO [GSafeFileNo] ()" & _
                        " VALUES ()"
            Case Else
        End Select


        Dim zCmd As New SqlCommand
        zCmd.CommandText = zSQL
        If zMode <> "INSERTnoKey" Then

            zCmd.Parameters.Add(New SqlParameter("@colGSafeId", pRowData.colGSafeId))
            zCmd.Parameters.Add(New SqlParameter("@colFileNo", pRowData.colFileNo))
        End If


        If zMode = "INSERTnoKey" Then
            Dim zLastId As Long = 0
            zLastId = UtilSQLServer.ExecuteNonQueryRowId(zCmd)

            pRowData.colGSafeId = zLastId
            pRowData.colFileNo = zLastId
        Else
            UtilSQLServer.ExecuteNonQuery(zCmd)
        End If
    End Sub

    Public Shared Function LoadByPrimaryKey(pcolGSafeId As Integer, pcolFileNo As String) As rowGSafeFileNo
        Dim zReturn As New rowGSafeFileNo
        Dim zSQL As String = "SELECT * FROM [GSafeFileNo] WHERE [GSafeId] = @colGSafeId AND [FileNo] = @colFileNo"
        Dim zCmd As New SqlCommand
        Dim zReader As SqlDataReader

        zCmd.CommandText = zSQL
        zCmd.Parameters.Add(New SqlParameter("@colGSafeId", pcolGSafeId))
        zCmd.Parameters.Add(New SqlParameter("@colFileNo", pcolFileNo))
        zReader = UtilSQLServer.ExecuteReader(zCmd)

        While zReader.Read
            If Not zReader.IsDBNull(zReader.GetOrdinal("GSafeId")) Then zReturn.colGSafeId = zReader.GetSqlInt32(zReader.GetOrdinal("GSafeId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("FileNo")) Then zReturn.colFileNo = zReader.GetSqlString(zReader.GetOrdinal("FileNo"))
        End While

        zReader.Close()
        zReader = Nothing

        Return zReturn
    End Function

    Public Shared Function LoadByIDX_IX_GsafeID(pcolGSafeId As Integer) As List(Of rowGSafeFileNo)
        Dim zReturn As New List(Of rowGSafeFileNo)
        Dim zSQL As String = "SELECT * FROM [GSafeFileNo] WHERE [GSafeId] = @colGSafeId"
        Dim zCmd As New SqlCommand
        Dim zReader As SqlDataReader

        zCmd.CommandText = zSQL
        zCmd.Parameters.Add(New SqlParameter("@colGSafeId", pcolGSafeId))
        zReader = UtilSQLServer.ExecuteReader(zCmd)

        While zReader.Read
            Dim zObj As New rowGSafeFileNo
            If Not zReader.IsDBNull(zReader.GetOrdinal("GSafeId")) Then zObj.colGSafeId = zReader.GetSqlInt32(zReader.GetOrdinal("GSafeId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("FileNo")) Then zObj.colFileNo = zReader.GetSqlString(zReader.GetOrdinal("FileNo"))
            zReturn.Add(zObj)
        End While

        zReader.Close()
        zReader = Nothing

        Return zReturn
    End Function

    Public Shared Function LoadByIDX_PK_GSafeFileNo(pcolGSafeId As Integer, pcolFileNo As String) As List(Of rowGSafeFileNo)
        Dim zReturn As New List(Of rowGSafeFileNo)
        Dim zSQL As String = "SELECT * FROM [GSafeFileNo] WHERE [GSafeId] = @colGSafeId AND [FileNo] = @colFileNo"
        Dim zCmd As New SqlCommand
        Dim zReader As SqlDataReader

        zCmd.CommandText = zSQL
        zCmd.Parameters.Add(New SqlParameter("@colGSafeId", pcolGSafeId))
        zCmd.Parameters.Add(New SqlParameter("@colFileNo", pcolFileNo))
        zReader = UtilSQLServer.ExecuteReader(zCmd)

        While zReader.Read
            Dim zObj As New rowGSafeFileNo
            If Not zReader.IsDBNull(zReader.GetOrdinal("GSafeId")) Then zObj.colGSafeId = zReader.GetSqlInt32(zReader.GetOrdinal("GSafeId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("FileNo")) Then zObj.colFileNo = zReader.GetSqlString(zReader.GetOrdinal("FileNo"))
            zReturn.Add(zObj)
        End While

        zReader.Close()
        zReader = Nothing

        Return zReturn
    End Function

    Public Shared Function LoadData(pSQL As String) As List(Of rowGSafeFileNo)
        Dim zReturn As New List(Of rowGSafeFileNo)
        Dim zSQL As String = "SELECT * FROM [GSafeFileNo]"
        Dim zCmd As New SqlCommand
        Dim zReader As SqlDataReader

        If pSQL <> "" Then zSQL = pSQL

        zCmd.CommandText = zSQL
        zReader = UtilSQLServer.ExecuteReader(zCmd)

        While zReader.Read
            Dim zObj As New rowGSafeFileNo
            If Not zReader.IsDBNull(zReader.GetOrdinal("GSafeId")) Then zObj.colGSafeId = zReader.GetSqlInt32(zReader.GetOrdinal("GSafeId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("FileNo")) Then zObj.colFileNo = zReader.GetSqlString(zReader.GetOrdinal("FileNo"))
            zReturn.Add(zObj)
        End While

        zReader.Close()
        zReader = Nothing

        Return zReturn
    End Function

    Public Shared Function LoadData(Optional pCommand As SqlCommand = Nothing) As List(Of rowGSafeFileNo)
        Dim zReturn As New List(Of rowGSafeFileNo)
        Dim zSQL As String = "SELECT * FROM [GSafeFileNo]"
        Dim zCmd As New SqlCommand
        Dim zReader As SqlDataReader

        If pCommand Is Nothing Then
            zCmd.CommandText = zSQL
        Else
            zCmd = pCommand
        End If

        zReader = UtilSQLServer.ExecuteReader(zCmd)

        While zReader.Read
            Dim zObj As New rowGSafeFileNo
            If Not zReader.IsDBNull(zReader.GetOrdinal("GSafeId")) Then
                zObj.colGSafeId = zReader.GetValue(zReader.GetOrdinal("GSafeId"))
            End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("FileNo")) Then
                zObj.colFileNo = zReader.GetValue(zReader.GetOrdinal("FileNo"))
            End If
            zReturn.Add(zObj)
        End While

        zReader.Close()
        zReader = Nothing

        Return zReturn
    End Function

End Class

Partial Public Class rowGSafeFileNo
    Public colGSafeId As Nullable(Of Integer)
    Public colFileNo As String
End Class

