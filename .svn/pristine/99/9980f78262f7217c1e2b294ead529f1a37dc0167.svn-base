Imports System.Data.SqlClient
Imports GRC.Connect.Libraries.DataLib.razor

Partial Public Class tblGSafeDetail

    Public Shared Sub Delete(ByRef pRowData As rowGSafeDetail)
        Dim zSQL As String = ""
        Dim zMode As String = ""

		If UtilSQLServer.IsKeySet(pRowData.colGSafeId) And UtilSQLServer.IsKeySet(pRowData.colDataName) Then
            'Delete
            zMode = "DELETE"
            zSQL = "DELETE FROM [GSafeDetail] " & _
                    "WHERE [GSafeId] = @colGSafeId AND [DataName] = @colDataName"

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colGSafeId", pRowData.colGSafeId))
            zCmd.Parameters.Add(New SQLParameter("@colDataName", pRowData.colDataName))

            UtilSQLServer.ExecuteNonQuery(zCmd)
        End If

    End Sub

    Public Shared Sub Save(ByRef pRowData As rowGSafeDetail)
        Dim zSQL As String = ""
        Dim zMode As String = ""
		DIm zExistInDB as Long = -1
		If UtilSQLServer.IsKeySet(pRowData.colGSafeId) And UtilSQLServer.IsKeySet(pRowData.colDataName) Then

			zSQL = "SELECT COUNT(*) from [GSafeDetail] WHERE [GSafeId] = @colGSafeId AND [DataName] = @colDataName"

			Dim zCmdDoesExist as New SQLCommand

			zCmdDoesExist.CommandText = zSQL

			zCmdDoesExist.Parameters.Add(new SQLParameter("@colGSafeId", pRowData.colGSafeId))
			zCmdDoesExist.Parameters.Add(new SQLParameter("@colDataName", pRowData.colDataName))

			'if zExistInDB > 0  then  PK exists in the DB
			zExistInDB = UtilSQLServer.ExecuteScalar(zCmdDoesExist)
		End If

		If UtilSQLServer.IsKeySet(pRowData.colGSafeId) And UtilSQLServer.IsKeySet(pRowData.colDataName) And zExistInDB > 0 Then
			zMode = "UPDATE"
		End If
		If UtilSQLServer.IsKeySet(pRowData.colGSafeId) And UtilSQLServer.IsKeySet(pRowData.colDataName) And zExistInDB = 0 Then
			zMode = "INSERTwithKey"
		End If
		If Not UtilSQLServer.IsKeySet(pRowData.colGSafeId) Or Not UtilSQLServer.IsKeySet(pRowData.colDataName) Then
			zMode = "INSERTnoKey"
		End If

		Select Case zMode
			Case "UPDATE"
				zSQL = "UPDATE [GSafeDetail] SET " & _
                                " [DataValue] = @colDataValue,  " & _
                                " [DataGroup] = @colDataGroup " & _
						" WHERE [GSafeId] = @colGSafeId AND [DataName] = @colDataName"
			Case "INSERTwithKey"
				zSQL = "INSERT INTO [GSafeDetail] ([GSafeId], [DataName], [DataValue], [DataGroup])" & _
						" VALUES (@colGSafeId, @colDataName, @colDataValue, @colDataGroup)"
			Case "INSERTnoKey"
				zSQL = "INSERT INTO [GSafeDetail] ([DataValue], [DataGroup])" & _
                        " VALUES (@colDataValue, @colDataGroup)"
			Case Else
		End Select


        Dim zCmd As New SQLCommand
        zCmd.CommandText = zSQL
		If zMode <> "INSERTnoKey" Then

	    	zCmd.Parameters.Add(New SQLParameter("@colGSafeId", pRowData.colGSafeId))
	    	zCmd.Parameters.Add(New SQLParameter("@colDataName", pRowData.colDataName))
		End If

        	zCmd.Parameters.Add(New SqlParameter("@colDataValue", IIf(pRowData.colDataValue Is Nothing, DBNull.Value, pRowData.colDataValue)))
        	zCmd.Parameters.Add(New SqlParameter("@colDataGroup", IIf(pRowData.colDataGroup Is Nothing, DBNull.Value, pRowData.colDataGroup)))

        If zMode = "INSERTnoKey" Then
	        Dim zLastId As Long = 0
	        zLastId = UtilSQLServer.ExecuteNonQueryRowId(zCmd)

            pRowData.colGSafeId = zLastId
            pRowData.colDataName = zLastId
		Else
			UtilSQLServer.ExecuteNonQuery(zCmd)
        End If
    End Sub

    Public Shared Function LoadByPrimaryKey(pcolGSafeId As Integer, pcolDataName As String) As rowGSafeDetail
        Dim zReturn As New rowGSafeDetail
        Dim zSQL As String = "SELECT * FROM [GSafeDetail] WHERE [GSafeId] = @colGSafeId AND [DataName] = @colDataName"
        Dim zCmd As New SQLCommand
        Dim zReader As SQLDataReader

        zCmd.CommandText = zSQL
    	zCmd.Parameters.Add(New SQLParameter("@colGSafeId", pcolGSafeId))
    	zCmd.Parameters.Add(New SQLParameter("@colDataName", pcolDataName))
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

	Public Shared Function LoadByIDX_PK_GSafeDetail(pcolGSafeId As Integer, pcolDataName As String) As List(Of rowGSafeDetail)
        Dim zReturn As New List(Of rowGSafeDetail)
        Dim zSQL As String = "SELECT * FROM [GSafeDetail] WHERE [GSafeId] = @colGSafeId AND [DataName] = @colDataName"
        Dim zCmd As New SQLCommand
        Dim zReader As SQLDataReader

        zCmd.CommandText = zSQL
    	zCmd.Parameters.Add(New SQLParameter("@colGSafeId", pcolGSafeId))
    	zCmd.Parameters.Add(New SQLParameter("@colDataName", pcolDataName))
        zReader = UtilSQLServer.ExecuteReader(zCmd)

        While zReader.Read
            Dim zObj As New rowGSafeDetail
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

    Public Shared Function LoadData(pSQL As String) As List(Of rowGSafeDetail)
        Dim zReturn As New List(Of rowGSafeDetail)
        Dim zSQL As String = "SELECT * FROM [GSafeDetail]"
        Dim zCmd As New SQLCommand
        Dim zReader As SQLDataReader

        If pSQL <> "" Then zSQL = pSQL

        zCmd.CommandText = zSQL
        zReader = UtilSQLServer.ExecuteReader(zCmd)

        While zReader.Read
            Dim zObj As New rowGSafeDetail
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

    Public Shared Function LoadData(Optional pCommand As SqlCommand = Nothing) As List(Of rowGSafeDetail)
        Dim zReturn As New List(Of rowGSafeDetail)
        Dim zSQL As String = "SELECT * FROM [GSafeDetail]"
        Dim zCmd As New SQLCommand
        Dim zReader As SQLDataReader

        If pCommand Is Nothing Then
            zCmd.CommandText = zSQL
        Else
            zCmd = pCommand
        End If

        zReader = UtilSQLServer.ExecuteReader(zCmd)

        While zReader.Read
            Dim zObj As New rowGSafeDetail		
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

Partial Public Class rowGSafeDetail
    Public colGSafeId As Nullable(Of Integer)
    Public colDataName As String
    Public colDataValue As String
    Public colDataGroup As String
End Class

