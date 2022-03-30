Imports System.Data.SqlClient
Imports GRC.Connect.Libraries.DataLib.razor

Partial Public Class tblGSafeLO

    Public Shared Sub Delete(ByRef pRowData As rowGSafeLO)
        Dim zSQL As String = ""
        Dim zMode As String = ""

        If UtilSQLServer.IsKeySet(pRowData.colGSafeId) And UtilSQLServer.IsKeySet(pRowData.colDataName) And UtilSQLServer.IsKeySet(pRowData.colDataGroup) Then
            'Delete
            zMode = "DELETE"
            zSQL = "DELETE FROM [dbo].[GSafeLO] " & _
                    "WHERE [GSafeId] = @colGSafeId AND [DataName] = @colDataName AND [DataGroup] = @colDataGroup"

            Dim zCmd As New SqlCommand
            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SqlParameter("@colGSafeId", pRowData.colGSafeId))
            zCmd.Parameters.Add(New SqlParameter("@colDataName", pRowData.colDataName))
            zCmd.Parameters.Add(New SqlParameter("@colDataGroup", pRowData.colDataGroup))

            UtilSQLServer.ExecuteNonQuery(zCmd)
        End If

    End Sub

    Public Shared Sub Save(ByRef pRowData As rowGSafeLO)
        Dim zSQL As String = ""
        Dim zMode As String = ""
        Dim zExistInDB As Long = -1
        If UtilSQLServer.IsKeySet(pRowData.colGSafeId) And UtilSQLServer.IsKeySet(pRowData.colDataName) And UtilSQLServer.IsKeySet(pRowData.colDataGroup) Then

            zSQL = "SELECT COUNT(*) from [dbo].[GSafeLO] WHERE [GSafeId] = @colGSafeId AND [DataName] = @colDataName AND [DataGroup] = @colDataGroup"

            Dim zCmdDoesExist As New SqlCommand

            zCmdDoesExist.CommandText = zSQL

            zCmdDoesExist.Parameters.Add(New SqlParameter("@colGSafeId", pRowData.colGSafeId))
            zCmdDoesExist.Parameters.Add(New SqlParameter("@colDataName", pRowData.colDataName))
            zCmdDoesExist.Parameters.Add(New SqlParameter("@colDataGroup", pRowData.colDataGroup))

            'if zExistInDB > 0  then  PK exists in the DB
            zExistInDB = UtilSQLServer.ExecuteScalar(zCmdDoesExist)
        End If

        If UtilSQLServer.IsKeySet(pRowData.colGSafeId) And UtilSQLServer.IsKeySet(pRowData.colDataName) And UtilSQLServer.IsKeySet(pRowData.colDataGroup) And zExistInDB > 0 Then
            zMode = "UPDATE"
        End If
        If UtilSQLServer.IsKeySet(pRowData.colGSafeId) And UtilSQLServer.IsKeySet(pRowData.colDataName) And UtilSQLServer.IsKeySet(pRowData.colDataGroup) And zExistInDB = 0 Then
            zMode = "INSERTwithKey"
        End If
        If Not UtilSQLServer.IsKeySet(pRowData.colGSafeId) Or Not UtilSQLServer.IsKeySet(pRowData.colDataName) Or Not UtilSQLServer.IsKeySet(pRowData.colDataGroup) Then
            zMode = "INSERTnoKey"
        End If

        Select Case zMode
            Case "UPDATE"
                zSQL = "UPDATE [dbo].[GSafeLO] SET " & _
                                " [DataValue] = @colDataValue  " & _
                        " WHERE [GSafeId] = @colGSafeId AND [DataName] = @colDataName AND [DataGroup] = @colDataGroup"
            Case "INSERTwithKey"
                zSQL = "INSERT INTO [dbo].[GSafeLO] ([GSafeId], [DataName], [DataValue], [DataGroup])" & _
                        " VALUES (@colGSafeId, @colDataName, @colDataValue, @colDataGroup)"
            Case "INSERTnoKey"
                zSQL = "INSERT INTO [dbo].[GSafeLO] ([DataValue])" & _
                        " VALUES (@colDataValue)"
            Case Else
        End Select


        Dim zCmd As New SqlCommand
        zCmd.CommandText = zSQL
        If zMode <> "INSERTnoKey" Then

            zCmd.Parameters.Add(New SqlParameter("@colGSafeId", pRowData.colGSafeId))
            zCmd.Parameters.Add(New SqlParameter("@colDataName", pRowData.colDataName))
            zCmd.Parameters.Add(New SqlParameter("@colDataGroup", pRowData.colDataGroup))
        End If

        zCmd.Parameters.Add(New SqlParameter("@colDataValue", IIf(pRowData.colDataValue Is Nothing, DBNull.Value, pRowData.colDataValue)))

        If zMode = "INSERTnoKey" Then
            Dim zLastId As Long = 0
            zLastId = UtilSQLServer.ExecuteNonQueryRowId(zCmd)

            pRowData.colGSafeId = zLastId
            pRowData.colDataName = zLastId
            pRowData.colDataGroup = zLastId
        Else
            UtilSQLServer.ExecuteNonQuery(zCmd)
        End If
    End Sub

    Public Shared Function LoadByPrimaryKey(pcolGSafeId As Integer, pcolDataName As String, pcolDataGroup As String) As rowGSafeLO
        Dim zReturn As New rowGSafeLO
        Dim zSQL As String = "SELECT * FROM [dbo].[GSafeLO] WHERE [GSafeId] = @colGSafeId AND [DataName] = @colDataName AND [DataGroup] = @colDataGroup"
        Dim zCmd As New SqlCommand
        Dim zReader As SqlDataReader

        zCmd.CommandText = zSQL
        zCmd.Parameters.Add(New SqlParameter("@colGSafeId", pcolGSafeId))
        zCmd.Parameters.Add(New SqlParameter("@colDataName", pcolDataName))
        zCmd.Parameters.Add(New SqlParameter("@colDataGroup", pcolDataGroup))
        zReader = UtilSQLServer.ExecuteReader(zCmd)

        While zReader.Read
            If Not zReader.IsDBNull(zReader.GetOrdinal("GSafeId")) Then zReturn.colGSafeId = zReader.GetSqlInt32(zReader.GetOrdinal("GSafeId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("DataName")) Then zReturn.colDataName = zReader.GetSqlString(zReader.GetOrdinal("DataName"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("DataValue")) Then zReturn.colDataValue = zReader.GetSqlString(zReader.GetOrdinal("DataValue"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("DataGroup")) Then zReturn.colDataGroup = zReader.GetSqlString(zReader.GetOrdinal("DataGroup"))
        End While

        zReader.Close()
        zReader = Nothing

        Return zReturn
    End Function

    Public Shared Function LoadByIDX_IDX_DataGroup(pcolDataGroup As String) As List(Of rowGSafeLO)
        Dim zReturn As New List(Of rowGSafeLO)
        Dim zSQL As String = "SELECT * FROM [dbo].[GSafeLO] WHERE [DataGroup] = @colDataGroup"
        Dim zCmd As New SqlCommand
        Dim zReader As SqlDataReader

        zCmd.CommandText = zSQL
        zCmd.Parameters.Add(New SqlParameter("@colDataGroup", pcolDataGroup))
        zReader = UtilSQLServer.ExecuteReader(zCmd)

        While zReader.Read
            Dim zObj As New rowGSafeLO
            If Not zReader.IsDBNull(zReader.GetOrdinal("GSafeId")) Then zObj.colGSafeId = zReader.GetSqlInt32(zReader.GetOrdinal("GSafeId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("DataName")) Then zObj.colDataName = zReader.GetSqlString(zReader.GetOrdinal("DataName"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("DataValue")) Then zObj.colDataValue = zReader.GetSqlString(zReader.GetOrdinal("DataValue"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("DataGroup")) Then zObj.colDataGroup = zReader.GetSqlString(zReader.GetOrdinal("DataGroup"))
            zReturn.Add(zObj)
        End While

        zReader.Close()
        zReader = Nothing

        Return zReturn
    End Function

    Public Shared Function LoadByIDX_PK_GSafeLO(pcolGSafeId As Integer, pcolDataName As String, pcolDataGroup As String) As List(Of rowGSafeLO)
        Dim zReturn As New List(Of rowGSafeLO)
        Dim zSQL As String = "SELECT * FROM [dbo].[GSafeLO] WHERE [GSafeId] = @colGSafeId AND [DataName] = @colDataName AND [DataGroup] = @colDataGroup"
        Dim zCmd As New SqlCommand
        Dim zReader As SqlDataReader

        zCmd.CommandText = zSQL
        zCmd.Parameters.Add(New SqlParameter("@colGSafeId", pcolGSafeId))
        zCmd.Parameters.Add(New SqlParameter("@colDataName", pcolDataName))
        zCmd.Parameters.Add(New SqlParameter("@colDataGroup", pcolDataGroup))
        zReader = UtilSQLServer.ExecuteReader(zCmd)

        While zReader.Read
            Dim zObj As New rowGSafeLO
            If Not zReader.IsDBNull(zReader.GetOrdinal("GSafeId")) Then zObj.colGSafeId = zReader.GetSqlInt32(zReader.GetOrdinal("GSafeId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("DataName")) Then zObj.colDataName = zReader.GetSqlString(zReader.GetOrdinal("DataName"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("DataValue")) Then zObj.colDataValue = zReader.GetSqlString(zReader.GetOrdinal("DataValue"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("DataGroup")) Then zObj.colDataGroup = zReader.GetSqlString(zReader.GetOrdinal("DataGroup"))
            zReturn.Add(zObj)
        End While

        zReader.Close()
        zReader = Nothing

        Return zReturn
    End Function

    Public Shared Function LoadData(pSQL As String) As List(Of rowGSafeLO)
        Dim zReturn As New List(Of rowGSafeLO)
        Dim zSQL As String = "SELECT * FROM [dbo].[GSafeLO]"
        Dim zCmd As New SqlCommand
        Dim zReader As SqlDataReader

        If pSQL <> "" Then zSQL = pSQL

        zCmd.CommandText = zSQL
        zReader = UtilSQLServer.ExecuteReader(zCmd)

        While zReader.Read
            Dim zObj As New rowGSafeLO
            If Not zReader.IsDBNull(zReader.GetOrdinal("GSafeId")) Then zObj.colGSafeId = zReader.GetSqlInt32(zReader.GetOrdinal("GSafeId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("DataName")) Then zObj.colDataName = zReader.GetSqlString(zReader.GetOrdinal("DataName"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("DataValue")) Then zObj.colDataValue = zReader.GetSqlString(zReader.GetOrdinal("DataValue"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("DataGroup")) Then zObj.colDataGroup = zReader.GetSqlString(zReader.GetOrdinal("DataGroup"))
            zReturn.Add(zObj)
        End While

        zReader.Close()
        zReader = Nothing

        Return zReturn
    End Function

    Public Shared Function LoadData(Optional pCommand As SqlCommand = Nothing) As List(Of rowGSafeLO)
        Dim zReturn As New List(Of rowGSafeLO)
        Dim zSQL As String = "SELECT * FROM [dbo].[GSafeLO]"
        Dim zCmd As New SqlCommand
        Dim zReader As SqlDataReader

        If pCommand Is Nothing Then
            zCmd.CommandText = zSQL
        Else
            zCmd = pCommand
        End If

        zReader = UtilSQLServer.ExecuteReader(zCmd)

        While zReader.Read
            Dim zObj As New rowGSafeLO
            If Not zReader.IsDBNull(zReader.GetOrdinal("GSafeId")) Then
                zObj.colGSafeId = zReader.GetValue(zReader.GetOrdinal("GSafeId"))
            End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("DataName")) Then
                zObj.colDataName = zReader.GetValue(zReader.GetOrdinal("DataName"))
            End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("DataValue")) Then
                zObj.colDataValue = zReader.GetValue(zReader.GetOrdinal("DataValue"))
            End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("DataGroup")) Then
                zObj.colDataGroup = zReader.GetValue(zReader.GetOrdinal("DataGroup"))
            End If
            zReturn.Add(zObj)
        End While

        zReader.Close()
        zReader = Nothing

        Return zReturn
    End Function

End Class

Partial Public Class rowGSafeLO
    Public colGSafeId As Nullable(Of Integer)
    Public colDataName As String
    Public colDataValue As String
    Public colDataGroup As String
End Class

