
Imports System.Data.SqlClient
Imports GRC.Connect.Libraries.DataLib.razor

Partial Public Class TblFileType

    Public Shared Sub Delete(ByRef pRowData As rowTblFileType)
        Dim zSQL As String = ""
        Dim zMode As String = ""

        If UtilSQLServer.IsKeySet(pRowData.colFldId) Then
            'Delete
            zMode = "DELETE"
            zSQL = "DELETE FROM [tblFileType] " & _
                    "WHERE [fldId] = @colFldId"

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldId", pRowData.colFldId))

            UtilSQLServer.ExecuteNonQuery(zCmd)
        End If

    End Sub

    Public Shared Sub Save(ByRef pRowData As rowTblFileType)
        Dim zSQL As String = ""
        Dim zMode As String = ""
        Dim zExistInDB As Long = -1
        If UtilSQLServer.IsKeySet(pRowData.colFldId) Then

            zSQL = "SELECT COUNT(*) from [tblFileType] WHERE [fldId] = @colFldId"

            Dim zCmdDoesExist As New SQLCommand

            zCmdDoesExist.CommandText = zSQL

            zCmdDoesExist.Parameters.Add(New SQLParameter("@colFldId", pRowData.colFldId))

            'if zExistInDB > 0  then  PK exists in the DB
            zExistInDB = UtilSQLServer.ExecuteScalar(zCmdDoesExist)
        End If

        If UtilSQLServer.IsKeySet(pRowData.colFldId) And zExistInDB > 0 Then
            zMode = "UPDATE"
        End If
        If UtilSQLServer.IsKeySet(pRowData.colFldId) And zExistInDB = 0 Then
            zMode = "INSERTwithKey"
        End If
        If Not UtilSQLServer.IsKeySet(pRowData.colFldId) Then
            zMode = "INSERTnoKey"
        End If

        Select Case zMode
            Case "UPDATE"
                zSQL = "UPDATE [tblFileType] SET " & _
                                " [fldType] = @colFldType " & _
                        " WHERE [fldId] = @colFldId"
            Case "INSERTwithKey"
                zSQL = "INSERT INTO [tblFileType] ([fldType])" & _
                        " VALUES (@colFldType)"
            Case "INSERTnoKey"
                zSQL = "INSERT INTO [tblFileType] ([fldType])" & _
                        " VALUES (@colFldType)"
            Case Else
        End Select


        Dim zCmd As New SQLCommand
        zCmd.CommandText = zSQL
        If zMode <> "INSERTnoKey" Then

            zCmd.Parameters.Add(New SQLParameter("@colFldId", pRowData.colFldId))
        End If

        zCmd.Parameters.Add(New SqlParameter("@colFldType", IIf(pRowData.colFldType Is Nothing, DBNull.Value, pRowData.colFldType)))

        If zMode = "INSERTnoKey" Then
            Dim zLastId As Long = 0
            zLastId = UtilSQLServer.ExecuteNonQueryRowId(zCmd)

            pRowData.colFldId = zLastId
        Else
            UtilSQLServer.ExecuteNonQuery(zCmd)
        End If
    End Sub

    Public Shared Function LoadByPrimaryKey(pcolFldId As Integer) As rowTblFileType
        Dim zReturn As New rowTblFileType
        Dim zSQL As String = "SELECT * FROM [tblFileType] WHERE [fldId] = @colFldId"
        Dim zCmd As New SQLCommand
        Dim zReader As SQLDataReader

        zCmd.CommandText = zSQL
        zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))
        zReader = UtilSQLServer.ExecuteReader(zCmd)

        While zReader.Read
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldId")) Then zReturn.colFldId = zReader.GetSqlInt32(zReader.GetOrdinal("fldId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldType")) Then zReturn.colFldType = zReader.GetSqlString(zReader.GetOrdinal("fldType"))
        End While

        zReader.Close()
        zReader = Nothing

        Return zReturn
    End Function

    Public Shared Function LoadByIDX_PK__tblFileT__36326BE3214E530E(pcolFldId As Integer) As List(Of rowTblFileType)
        Dim zReturn As New List(Of rowTblFileType)
        Dim zSQL As String = "SELECT * FROM [tblFileType] WHERE [fldId] = @colFldId"
        Dim zCmd As New SQLCommand
        Dim zReader As SQLDataReader

        zCmd.CommandText = zSQL
        zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))
        zReader = UtilSQLServer.ExecuteReader(zCmd)

        While zReader.Read
            Dim zObj As New rowTblFileType
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldId")) Then zObj.colFldId = zReader.GetSqlInt32(zReader.GetOrdinal("fldId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldType")) Then zObj.colFldType = zReader.GetSqlString(zReader.GetOrdinal("fldType"))
            zReturn.Add(zObj)
        End While

        zReader.Close()
        zReader = Nothing

        Return zReturn
    End Function

    Public Shared Function LoadData(pSQL As String) As List(Of rowTblFileType)
        Dim zReturn As New List(Of rowTblFileType)
        Dim zSQL As String = "SELECT * FROM [tblFileType]"
        Dim zCmd As New SQLCommand
        Dim zReader As SQLDataReader

        If pSQL <> "" Then zSQL = pSQL

        zCmd.CommandText = zSQL
        zReader = UtilSQLServer.ExecuteReader(zCmd)

        While zReader.Read
            Dim zObj As New rowTblFileType
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldId")) Then zObj.colFldId = zReader.GetSqlInt32(zReader.GetOrdinal("fldId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldType")) Then zObj.colFldType = zReader.GetSqlString(zReader.GetOrdinal("fldType"))
            zReturn.Add(zObj)
        End While

        zReader.Close()
        zReader = Nothing

        Return zReturn
    End Function

    Public Shared Function LoadData(Optional pCommand As SqlCommand = Nothing) As List(Of rowTblFileType)
        Dim zReturn As New List(Of rowTblFileType)
        Dim zSQL As String = "SELECT * FROM [tblFileType]"
        Dim zCmd As New SQLCommand
        Dim zReader As SQLDataReader

        If pCommand Is Nothing Then
            zCmd.CommandText = zSQL
        Else
            zCmd = pCommand
        End If

        zReader = UtilSQLServer.ExecuteReader(zCmd)

        While zReader.Read
            Dim zObj As New rowTblFileType
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldId")) Then
                zObj.colFldId = zReader.GetValue(zReader.GetOrdinal("fldId"))
            End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldType")) Then
                zObj.colFldType = zReader.GetValue(zReader.GetOrdinal("fldType"))
            End If
            zReturn.Add(zObj)
        End While

        zReader.Close()
        zReader = Nothing

        Return zReturn
    End Function

End Class

Partial Public Class rowTblFileType
    Public colFldId As Nullable(Of Integer)
    Public colFldType As String
End Class

