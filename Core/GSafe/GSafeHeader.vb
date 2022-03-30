Imports System.Data.SqlClient
Imports GRC.Connect.Libraries.DataLib.razor

Partial Public Class tblGSafeHeader

    Public Shared Sub Delete(ByRef pRowData As rowGSafeHeader)
        Dim zSQL As String = ""
        Dim zMode As String = ""

		If UtilSQLServer.IsKeySet(pRowData.colGSafeId) Then
            'Delete
            zMode = "DELETE"
            zSQL = "DELETE FROM [GSafeHeader] " & _
                    "WHERE [GSafeId] = @colGSafeId"

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colGSafeId", pRowData.colGSafeId))

            UtilSQLServer.ExecuteNonQuery(zCmd)
        End If

    End Sub

    Public Shared Sub Save(ByRef pRowData As rowGSafeHeader)
        Dim zSQL As String = ""
        Dim zMode As String = ""
		DIm zExistInDB as Long = -1
		If UtilSQLServer.IsKeySet(pRowData.colGSafeId) Then

			zSQL = "SELECT COUNT(*) from [GSafeHeader] WHERE [GSafeId] = @colGSafeId"

			Dim zCmdDoesExist as New SQLCommand

			zCmdDoesExist.CommandText = zSQL

			zCmdDoesExist.Parameters.Add(new SQLParameter("@colGSafeId", pRowData.colGSafeId))

			'if zExistInDB > 0  then  PK exists in the DB
			zExistInDB = UtilSQLServer.ExecuteScalar(zCmdDoesExist)
		End If

		If UtilSQLServer.IsKeySet(pRowData.colGSafeId) And zExistInDB > 0 Then
			zMode = "UPDATE"
		End If
		If UtilSQLServer.IsKeySet(pRowData.colGSafeId) And zExistInDB = 0 Then
			zMode = "INSERTwithKey"
		End If
		If Not UtilSQLServer.IsKeySet(pRowData.colGSafeId) Then
			zMode = "INSERTnoKey"
		End If

		Select Case zMode
			Case "UPDATE"
				zSQL = "UPDATE [GSafeHeader] SET " & _
                                " [GSafeGUID] = @colGSafeGUID,  " & _
                                " [Created] = @colCreated,  " & _
                                " [LastAccessed] = @colLastAccessed,  " & _
                                " [LastUpdated] = @colLastUpdated,  " & _
                                " [LoginName] = @colLoginName " & _
						" WHERE [GSafeId] = @colGSafeId"
			Case "INSERTwithKey"
				zSQL = "INSERT INTO [GSafeHeader] ([GSafeGUID], [Created], [LastAccessed], [LastUpdated], [LoginName])" & _
						" VALUES (@colGSafeGUID, @colCreated, @colLastAccessed, @colLastUpdated, @colLoginName)"
			Case "INSERTnoKey"
				zSQL = "INSERT INTO [GSafeHeader] ([GSafeGUID], [Created], [LastAccessed], [LastUpdated], [LoginName])" & _
                        " VALUES (@colGSafeGUID, @colCreated, @colLastAccessed, @colLastUpdated, @colLoginName)"
			Case Else
		End Select


        Dim zCmd As New SQLCommand
        zCmd.CommandText = zSQL
		If zMode <> "INSERTnoKey" Then

	    	zCmd.Parameters.Add(New SQLParameter("@colGSafeId", pRowData.colGSafeId))
		End If

        	zCmd.Parameters.Add(New SqlParameter("@colGSafeGUID", IIf(pRowData.colGSafeGUID Is Nothing, DBNull.Value, pRowData.colGSafeGUID)))
        	zCmd.Parameters.Add(New SqlParameter("@colCreated", IIf(pRowData.colCreated Is Nothing, DBNull.Value, pRowData.colCreated)))
        	zCmd.Parameters.Add(New SqlParameter("@colLastAccessed", IIf(pRowData.colLastAccessed Is Nothing, DBNull.Value, pRowData.colLastAccessed)))
        	zCmd.Parameters.Add(New SqlParameter("@colLastUpdated", IIf(pRowData.colLastUpdated Is Nothing, DBNull.Value, pRowData.colLastUpdated)))
        	zCmd.Parameters.Add(New SqlParameter("@colLoginName", IIf(pRowData.colLoginName Is Nothing, DBNull.Value, pRowData.colLoginName)))

        If zMode = "INSERTnoKey" Then
	        Dim zLastId As Long = 0
	        zLastId = UtilSQLServer.ExecuteNonQueryRowId(zCmd)

            pRowData.colGSafeId = zLastId
		Else
			UtilSQLServer.ExecuteNonQuery(zCmd)
        End If
    End Sub

    Public Shared Function LoadByPrimaryKey(pcolGSafeId As Integer) As rowGSafeHeader
        Dim zReturn As New rowGSafeHeader
        Dim zSQL As String = "SELECT * FROM [GSafeHeader] WHERE [GSafeId] = @colGSafeId"
        Dim zCmd As New SQLCommand
        Dim zReader As SQLDataReader

        zCmd.CommandText = zSQL
    	zCmd.Parameters.Add(New SQLParameter("@colGSafeId", pcolGSafeId))
        zReader = UtilSQLServer.ExecuteReader(zCmd)

        While zReader.Read
            If Not zReader.IsDBNull(zReader.GetOrdinal("GSafeId")) Then zReturn.colGSafeId = zReader.GetSqlInt32(zReader.GetOrdinal("GSafeId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("GSafeGUID")) Then zReturn.colGSafeGUID = zReader.GetSqlString(zReader.GetOrdinal("GSafeGUID"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("Created")) Then zReturn.colCreated = zReader.GetSqlDateTime(zReader.GetOrdinal("Created"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("LastAccessed")) Then zReturn.colLastAccessed = zReader.GetSqlDateTime(zReader.GetOrdinal("LastAccessed"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("LastUpdated")) Then zReturn.colLastUpdated = zReader.GetSqlDateTime(zReader.GetOrdinal("LastUpdated"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("LoginName")) Then zReturn.colLoginName = zReader.GetSqlString(zReader.GetOrdinal("LoginName"))
        End While

        zReader.Close()
        zReader = Nothing

        Return zReturn
    End Function

	Public Shared Function LoadByIDX_IX_GSafeHeaderGUID(pcolGSafeId As Integer) As List(Of rowGSafeHeader)
        Dim zReturn As New List(Of rowGSafeHeader)
        Dim zSQL As String = "SELECT * FROM [GSafeHeader] WHERE [GSafeId] = @colGSafeId"
        Dim zCmd As New SQLCommand
        Dim zReader As SQLDataReader

        zCmd.CommandText = zSQL
    	zCmd.Parameters.Add(New SQLParameter("@colGSafeId", pcolGSafeId))
        zReader = UtilSQLServer.ExecuteReader(zCmd)

        While zReader.Read
            Dim zObj As New rowGSafeHeader
            If Not zReader.IsDBNull(zReader.GetOrdinal("GSafeId")) Then zObj.colGSafeId = zReader.GetSqlInt32(zReader.GetOrdinal("GSafeId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("GSafeGUID")) Then zObj.colGSafeGUID = zReader.GetSqlString(zReader.GetOrdinal("GSafeGUID"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("Created")) Then zObj.colCreated = zReader.GetSqlDateTime(zReader.GetOrdinal("Created"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("LastAccessed")) Then zObj.colLastAccessed = zReader.GetSqlDateTime(zReader.GetOrdinal("LastAccessed"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("LastUpdated")) Then zObj.colLastUpdated = zReader.GetSqlDateTime(zReader.GetOrdinal("LastUpdated"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("LoginName")) Then zObj.colLoginName = zReader.GetSqlString(zReader.GetOrdinal("LoginName"))
            zReturn.Add(zObj)
        End While

        zReader.Close()
        zReader = Nothing

        Return zReturn
	End Function

	Public Shared Function LoadByIDX_PK_GSafeHeader(pcolGSafeId As Integer) As List(Of rowGSafeHeader)
        Dim zReturn As New List(Of rowGSafeHeader)
        Dim zSQL As String = "SELECT * FROM [GSafeHeader] WHERE [GSafeId] = @colGSafeId"
        Dim zCmd As New SQLCommand
        Dim zReader As SQLDataReader

        zCmd.CommandText = zSQL
    	zCmd.Parameters.Add(New SQLParameter("@colGSafeId", pcolGSafeId))
        zReader = UtilSQLServer.ExecuteReader(zCmd)

        While zReader.Read
            Dim zObj As New rowGSafeHeader
            If Not zReader.IsDBNull(zReader.GetOrdinal("GSafeId")) Then zObj.colGSafeId = zReader.GetSqlInt32(zReader.GetOrdinal("GSafeId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("GSafeGUID")) Then zObj.colGSafeGUID = zReader.GetSqlString(zReader.GetOrdinal("GSafeGUID"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("Created")) Then zObj.colCreated = zReader.GetSqlDateTime(zReader.GetOrdinal("Created"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("LastAccessed")) Then zObj.colLastAccessed = zReader.GetSqlDateTime(zReader.GetOrdinal("LastAccessed"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("LastUpdated")) Then zObj.colLastUpdated = zReader.GetSqlDateTime(zReader.GetOrdinal("LastUpdated"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("LoginName")) Then zObj.colLoginName = zReader.GetSqlString(zReader.GetOrdinal("LoginName"))
            zReturn.Add(zObj)
        End While

        zReader.Close()
        zReader = Nothing

        Return zReturn
	End Function

    Public Shared Function LoadData(pSQL As String) As List(Of rowGSafeHeader)
        Dim zReturn As New List(Of rowGSafeHeader)
        Dim zSQL As String = "SELECT * FROM [GSafeHeader]"
        Dim zCmd As New SQLCommand
        Dim zReader As SQLDataReader

        If pSQL <> "" Then zSQL = pSQL

        zCmd.CommandText = zSQL
        zReader = UtilSQLServer.ExecuteReader(zCmd)

        While zReader.Read
            Dim zObj As New rowGSafeHeader
            If Not zReader.IsDBNull(zReader.GetOrdinal("GSafeId")) Then zObj.colGSafeId = zReader.GetSqlInt32(zReader.GetOrdinal("GSafeId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("GSafeGUID")) Then zObj.colGSafeGUID = zReader.GetSqlString(zReader.GetOrdinal("GSafeGUID"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("Created")) Then zObj.colCreated = zReader.GetSqlDateTime(zReader.GetOrdinal("Created"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("LastAccessed")) Then zObj.colLastAccessed = zReader.GetSqlDateTime(zReader.GetOrdinal("LastAccessed"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("LastUpdated")) Then zObj.colLastUpdated = zReader.GetSqlDateTime(zReader.GetOrdinal("LastUpdated"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("LoginName")) Then zObj.colLoginName = zReader.GetSqlString(zReader.GetOrdinal("LoginName"))
            zReturn.Add(zObj)
        End While

        zReader.Close()
        zReader = Nothing

        Return zReturn
    End Function

    Public Shared Function LoadData(Optional pCommand As SqlCommand = Nothing) As List(Of rowGSafeHeader)
        Dim zReturn As New List(Of rowGSafeHeader)
        Dim zSQL As String = "SELECT * FROM [GSafeHeader]"
        Dim zCmd As New SQLCommand
        Dim zReader As SQLDataReader

        If pCommand Is Nothing Then
            zCmd.CommandText = zSQL
        Else
            zCmd = pCommand
        End If

        zReader = UtilSQLServer.ExecuteReader(zCmd)

        While zReader.Read
            Dim zObj As New rowGSafeHeader		
            If Not zReader.IsDBNull(zReader.GetOrdinal("GSafeId")) Then 
				zObj.colGSafeId = zReader.GetValue(zReader.GetOrdinal("GSafeId"))
			End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("GSafeGUID")) Then 
				zObj.colGSafeGUID = zReader.GetValue(zReader.GetOrdinal("GSafeGUID"))
			End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("Created")) Then 
				zObj.colCreated = zReader.GetValue(zReader.GetOrdinal("Created"))
			End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("LastAccessed")) Then 
				zObj.colLastAccessed = zReader.GetValue(zReader.GetOrdinal("LastAccessed"))
			End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("LastUpdated")) Then 
				zObj.colLastUpdated = zReader.GetValue(zReader.GetOrdinal("LastUpdated"))
			End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("LoginName")) Then 
				zObj.colLoginName = zReader.GetValue(zReader.GetOrdinal("LoginName"))
			End If
            zReturn.Add(zObj)
        End While

        zReader.Close()
        zReader = Nothing

        Return zReturn
    End Function

End Class

Partial Public Class rowGSafeHeader
    Public colGSafeId As Nullable(Of Integer)
    Public colGSafeGUID As String
    Public colCreated As Nullable(Of DateTime)
    Public colLastAccessed As Nullable(Of DateTime)
    Public colLastUpdated As Nullable(Of DateTime)
    Public colLoginName As String
End Class

