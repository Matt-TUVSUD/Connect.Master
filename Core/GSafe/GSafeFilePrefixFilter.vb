Imports System.Data.SqlClient
Imports GRC.Connect.Libraries.DataLib.razor

Partial Public Class tblGSafeFilePrefixFilter

    Public Shared Sub Delete(ByRef pRowData As rowGSafeFilePrefixFilter)
        Dim zSQL As String = ""
        Dim zMode As String = ""

		If UtilSQLServer.IsKeySet(pRowData.colGSafeId) And UtilSQLServer.IsKeySet(pRowData.colFilePrefix) Then
            'Delete
            zMode = "DELETE"
            zSQL = "DELETE FROM [GSafeFilePrefixFilter] " & _
                    "WHERE [GSafeId] = @colGSafeId AND [FilePrefix] = @colFilePrefix"

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colGSafeId", pRowData.colGSafeId))
            zCmd.Parameters.Add(New SQLParameter("@colFilePrefix", pRowData.colFilePrefix))

            UtilSQLServer.ExecuteNonQuery(zCmd)
        End If

    End Sub

    Public Shared Sub Save(ByRef pRowData As rowGSafeFilePrefixFilter)
        Dim zSQL As String = ""
        Dim zMode As String = ""
		DIm zExistInDB as Long = -1
		If UtilSQLServer.IsKeySet(pRowData.colGSafeId) And UtilSQLServer.IsKeySet(pRowData.colFilePrefix) Then

			zSQL = "SELECT COUNT(*) from [GSafeFilePrefixFilter] WHERE [GSafeId] = @colGSafeId AND [FilePrefix] = @colFilePrefix"

			Dim zCmdDoesExist as New SQLCommand

			zCmdDoesExist.CommandText = zSQL

			zCmdDoesExist.Parameters.Add(new SQLParameter("@colGSafeId", pRowData.colGSafeId))
			zCmdDoesExist.Parameters.Add(new SQLParameter("@colFilePrefix", pRowData.colFilePrefix))

			'if zExistInDB > 0  then  PK exists in the DB
			zExistInDB = UtilSQLServer.ExecuteScalar(zCmdDoesExist)
		End If

		If UtilSQLServer.IsKeySet(pRowData.colGSafeId) And UtilSQLServer.IsKeySet(pRowData.colFilePrefix) And zExistInDB > 0 Then
			zMode = "UPDATE"
		End If
		If UtilSQLServer.IsKeySet(pRowData.colGSafeId) And UtilSQLServer.IsKeySet(pRowData.colFilePrefix) And zExistInDB = 0 Then
			zMode = "INSERTwithKey"
		End If
		If Not UtilSQLServer.IsKeySet(pRowData.colGSafeId) Or Not UtilSQLServer.IsKeySet(pRowData.colFilePrefix) Then
			zMode = "INSERTnoKey"
		End If

		Select Case zMode
			Case "UPDATE"
				zSQL = "UPDATE [GSafeFilePrefixFilter] SET " & _
                                " [FilterSQL] = @colFilterSQL " & _
						" WHERE [GSafeId] = @colGSafeId AND [FilePrefix] = @colFilePrefix"
			Case "INSERTwithKey"
				zSQL = "INSERT INTO [GSafeFilePrefixFilter] ([GSafeId], [FilePrefix], [FilterSQL])" & _
						" VALUES (@colGSafeId, @colFilePrefix, @colFilterSQL)"
			Case "INSERTnoKey"
				zSQL = "INSERT INTO [GSafeFilePrefixFilter] ([FilterSQL])" & _
                        " VALUES (@colFilterSQL)"
			Case Else
		End Select


        Dim zCmd As New SQLCommand
        zCmd.CommandText = zSQL
		If zMode <> "INSERTnoKey" Then

	    	zCmd.Parameters.Add(New SQLParameter("@colGSafeId", pRowData.colGSafeId))
	    	zCmd.Parameters.Add(New SQLParameter("@colFilePrefix", pRowData.colFilePrefix))
		End If

        	zCmd.Parameters.Add(New SqlParameter("@colFilterSQL", IIf(pRowData.colFilterSQL Is Nothing, DBNull.Value, pRowData.colFilterSQL)))

        If zMode = "INSERTnoKey" Then
	        Dim zLastId As Long = 0
	        zLastId = UtilSQLServer.ExecuteNonQueryRowId(zCmd)

            pRowData.colGSafeId = zLastId
            pRowData.colFilePrefix = zLastId
		Else
			UtilSQLServer.ExecuteNonQuery(zCmd)
        End If
    End Sub

    Public Shared Function LoadByPrimaryKey(pcolGSafeId As Integer, pcolFilePrefix As String) As rowGSafeFilePrefixFilter
        Dim zReturn As New rowGSafeFilePrefixFilter
        Dim zSQL As String = "SELECT * FROM [GSafeFilePrefixFilter] WHERE [GSafeId] = @colGSafeId AND [FilePrefix] = @colFilePrefix"
        Dim zCmd As New SQLCommand
        Dim zReader As SQLDataReader

        zCmd.CommandText = zSQL
    	zCmd.Parameters.Add(New SQLParameter("@colGSafeId", pcolGSafeId))
    	zCmd.Parameters.Add(New SQLParameter("@colFilePrefix", pcolFilePrefix))
        zReader = UtilSQLServer.ExecuteReader(zCmd)

        While zReader.Read
            If Not zReader.IsDBNull(zReader.GetOrdinal("GSafeId")) Then zReturn.colGSafeId = zReader.GetSqlInt32(zReader.GetOrdinal("GSafeId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("FilePrefix")) Then zReturn.colFilePrefix = zReader.GetSqlString(zReader.GetOrdinal("FilePrefix"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("FilterSQL")) Then zReturn.colFilterSQL = zReader.GetSqlString(zReader.GetOrdinal("FilterSQL"))
        End While

        zReader.Close()
        zReader = Nothing

        Return zReturn
    End Function

	Public Shared Function LoadByIDX_PK_GSafeFilePrefixFilter(pcolGSafeId As Integer, pcolFilePrefix As String) As List(Of rowGSafeFilePrefixFilter)
        Dim zReturn As New List(Of rowGSafeFilePrefixFilter)
        Dim zSQL As String = "SELECT * FROM [GSafeFilePrefixFilter] WHERE [GSafeId] = @colGSafeId AND [FilePrefix] = @colFilePrefix"
        Dim zCmd As New SQLCommand
        Dim zReader As SQLDataReader

        zCmd.CommandText = zSQL
    	zCmd.Parameters.Add(New SQLParameter("@colGSafeId", pcolGSafeId))
    	zCmd.Parameters.Add(New SQLParameter("@colFilePrefix", pcolFilePrefix))
        zReader = UtilSQLServer.ExecuteReader(zCmd)

        While zReader.Read
            Dim zObj As New rowGSafeFilePrefixFilter
            If Not zReader.IsDBNull(zReader.GetOrdinal("GSafeId")) Then zObj.colGSafeId = zReader.GetSqlInt32(zReader.GetOrdinal("GSafeId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("FilePrefix")) Then zObj.colFilePrefix = zReader.GetSqlString(zReader.GetOrdinal("FilePrefix"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("FilterSQL")) Then zObj.colFilterSQL = zReader.GetSqlString(zReader.GetOrdinal("FilterSQL"))
            zReturn.Add(zObj)
        End While

        zReader.Close()
        zReader = Nothing

        Return zReturn
	End Function

    Public Shared Function LoadData(pSQL As String) As List(Of rowGSafeFilePrefixFilter)
        Dim zReturn As New List(Of rowGSafeFilePrefixFilter)
        Dim zSQL As String = "SELECT * FROM [GSafeFilePrefixFilter]"
        Dim zCmd As New SQLCommand
        Dim zReader As SQLDataReader

        If pSQL <> "" Then zSQL = pSQL

        zCmd.CommandText = zSQL
        zReader = UtilSQLServer.ExecuteReader(zCmd)

        While zReader.Read
            Dim zObj As New rowGSafeFilePrefixFilter
            If Not zReader.IsDBNull(zReader.GetOrdinal("GSafeId")) Then zObj.colGSafeId = zReader.GetSqlInt32(zReader.GetOrdinal("GSafeId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("FilePrefix")) Then zObj.colFilePrefix = zReader.GetSqlString(zReader.GetOrdinal("FilePrefix"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("FilterSQL")) Then zObj.colFilterSQL = zReader.GetSqlString(zReader.GetOrdinal("FilterSQL"))
            zReturn.Add(zObj)
        End While

        zReader.Close()
        zReader = Nothing

        Return zReturn
    End Function

    Public Shared Function LoadData(Optional pCommand As SqlCommand = Nothing) As List(Of rowGSafeFilePrefixFilter)
        Dim zReturn As New List(Of rowGSafeFilePrefixFilter)
        Dim zSQL As String = "SELECT * FROM [GSafeFilePrefixFilter]"
        Dim zCmd As New SQLCommand
        Dim zReader As SQLDataReader

        If pCommand Is Nothing Then
            zCmd.CommandText = zSQL
        Else
            zCmd = pCommand
        End If

        zReader = UtilSQLServer.ExecuteReader(zCmd)

        While zReader.Read
            Dim zObj As New rowGSafeFilePrefixFilter		
            If Not zReader.IsDBNull(zReader.GetOrdinal("GSafeId")) Then 
				zObj.colGSafeId = zReader.GetValue(zReader.GetOrdinal("GSafeId"))
			End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("FilePrefix")) Then 
				zObj.colFilePrefix = zReader.GetValue(zReader.GetOrdinal("FilePrefix"))
			End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("FilterSQL")) Then 
				zObj.colFilterSQL = zReader.GetValue(zReader.GetOrdinal("FilterSQL"))
			End If
            zReturn.Add(zObj)
        End While

        zReader.Close()
        zReader = Nothing

        Return zReturn
    End Function

End Class

Partial Public Class rowGSafeFilePrefixFilter
    Public colGSafeId As Nullable(Of Integer)
    Public colFilePrefix As String
    Public colFilterSQL As String
End Class

