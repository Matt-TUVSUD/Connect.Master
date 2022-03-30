Imports System.Data.SqlClient
Imports GRC.Connect.Libraries.DataLib.razor

Partial Public Class TblFile

    Public Shared Sub Delete(ByRef pRowData As rowTblFile)
        Dim zSQL As String = ""
        Dim zMode As String = ""

		If UtilSQLServer.IsKeySet(pRowData.colFldId) Then
            'Delete
            zMode = "DELETE"
            zSQL = "DELETE FROM [tblFile] " & _
                    "WHERE [fldId] = @colFldId"

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldId", pRowData.colFldId))

            UtilSQLServer.ExecuteNonQuery(zCmd)
        End If

    End Sub

    Public Shared Sub Save(ByRef pRowData As rowTblFile)
        Dim zSQL As String = ""
        Dim zMode As String = ""
		DIm zExistInDB as Long = -1
		If UtilSQLServer.IsKeySet(pRowData.colFldId) Then

			zSQL = "SELECT COUNT(*) from [tblFile] WHERE [fldId] = @colFldId"

			Dim zCmdDoesExist as New SQLCommand

			zCmdDoesExist.CommandText = zSQL

			zCmdDoesExist.Parameters.Add(new SQLParameter("@colFldId", pRowData.colFldId))

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
				zSQL = "UPDATE [tblFile] SET " & _
                                " [fldRefId] = @colFldRefId,  " & _
                                " [fldFileTypeId] = @colFldFileTypeId,  " & _
                                " [fldGuid] = @colFldGuid,  " & _
                                " [fldCreateDate] = @colFldCreateDate,  " & _
                                " [fldAccessDate] = @colFldAccessDate,  " & _
                                " [fldData] = @colFldData,  " & _
                                " [fldFileSize] = @colFldFileSize,  " & _
                                " [fldMime] = @colFldMime,  " & _
                                " [fldExtension] = @colFldExtension " & _
						" WHERE [fldId] = @colFldId"
			Case "INSERTwithKey"
				zSQL = "INSERT INTO [tblFile] ([fldRefId], [fldFileTypeId], [fldGuid], [fldCreateDate], [fldAccessDate], [fldData], [fldFileSize], [fldMime], [fldExtension])" & _
						" VALUES (@colFldRefId, @colFldFileTypeId, @colFldGuid, @colFldCreateDate, @colFldAccessDate, @colFldData, @colFldFileSize, @colFldMime, @colFldExtension)"
			Case "INSERTnoKey"
				zSQL = "INSERT INTO [tblFile] ([fldRefId], [fldFileTypeId], [fldGuid], [fldCreateDate], [fldAccessDate], [fldData], [fldFileSize], [fldMime], [fldExtension])" & _
                        " VALUES (@colFldRefId, @colFldFileTypeId, @colFldGuid, @colFldCreateDate, @colFldAccessDate, @colFldData, @colFldFileSize, @colFldMime, @colFldExtension)"
			Case Else
		End Select


        Dim zCmd As New SQLCommand
        zCmd.CommandText = zSQL
		If zMode <> "INSERTnoKey" Then

	    	zCmd.Parameters.Add(New SQLParameter("@colFldId", pRowData.colFldId))
		End If

        	zCmd.Parameters.Add(New SqlParameter("@colFldRefId", IIf(pRowData.colFldRefId Is Nothing, DBNull.Value, pRowData.colFldRefId)))
        	zCmd.Parameters.Add(New SqlParameter("@colFldFileTypeId", IIf(pRowData.colFldFileTypeId Is Nothing, DBNull.Value, pRowData.colFldFileTypeId)))
        	zCmd.Parameters.Add(New SqlParameter("@colFldGuid", IIf(pRowData.colFldGuid Is Nothing, DBNull.Value, pRowData.colFldGuid)))
        	zCmd.Parameters.Add(New SqlParameter("@colFldCreateDate", IIf(pRowData.colFldCreateDate Is Nothing, DBNull.Value, pRowData.colFldCreateDate)))
        	zCmd.Parameters.Add(New SqlParameter("@colFldAccessDate", IIf(pRowData.colFldAccessDate Is Nothing, DBNull.Value, pRowData.colFldAccessDate)))
        	zCmd.Parameters.Add(New SqlParameter("@colFldData", IIf(pRowData.colFldData Is Nothing, DBNull.Value, pRowData.colFldData)))
        	zCmd.Parameters.Add(New SqlParameter("@colFldFileSize", IIf(pRowData.colFldFileSize Is Nothing, DBNull.Value, pRowData.colFldFileSize)))
        	zCmd.Parameters.Add(New SqlParameter("@colFldMime", IIf(pRowData.colFldMime Is Nothing, DBNull.Value, pRowData.colFldMime)))
        	zCmd.Parameters.Add(New SqlParameter("@colFldExtension", IIf(pRowData.colFldExtension Is Nothing, DBNull.Value, pRowData.colFldExtension)))

        If zMode = "INSERTnoKey" Then
	        Dim zLastId As Long = 0
	        zLastId = UtilSQLServer.ExecuteNonQueryRowId(zCmd)

            pRowData.colFldId = zLastId
		Else
			UtilSQLServer.ExecuteNonQuery(zCmd)
        End If
    End Sub

    Public Shared Function LoadByPrimaryKey(pcolFldId As Integer) As rowTblFile
        Dim zReturn As New rowTblFile
        Dim zSQL As String = "SELECT * FROM [tblFile] WHERE [fldId] = @colFldId"
        Dim zCmd As New SQLCommand
        Dim zReader As SQLDataReader

        zCmd.CommandText = zSQL
    	zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))
        zReader = UtilSQLServer.ExecuteReader(zCmd)

        While zReader.Read
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldId")) Then zReturn.colFldId = zReader.GetSqlInt32(zReader.GetOrdinal("fldId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldRefId")) Then zReturn.colFldRefId = zReader.GetSqlInt32(zReader.GetOrdinal("fldRefId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldFileTypeId")) Then zReturn.colFldFileTypeId = zReader.GetSqlInt32(zReader.GetOrdinal("fldFileTypeId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldGuid")) Then zReturn.colFldGuid = zReader.GetSqlString(zReader.GetOrdinal("fldGuid"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldCreateDate")) Then zReturn.colFldCreateDate = zReader.GetSqlDateTime(zReader.GetOrdinal("fldCreateDate"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldAccessDate")) Then zReturn.colFldAccessDate = zReader.GetSqlDateTime(zReader.GetOrdinal("fldAccessDate"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldData")) Then zReturn.colFldData = zReader("fldData")
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldFileSize")) Then zReturn.colFldFileSize = zReader.GetSqlInt32(zReader.GetOrdinal("fldFileSize"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldMime")) Then zReturn.colFldMime = zReader.GetSqlString(zReader.GetOrdinal("fldMime"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldExtension")) Then zReturn.colFldExtension = zReader.GetSqlString(zReader.GetOrdinal("fldExtension"))
        End While

        zReader.Close()
        zReader = Nothing

        Return zReturn
    End Function

	Public Shared Function LoadByIDX_IX_fldGuid(pcolFldGuid As String) As List(Of rowTblFile)
        Dim zReturn As New List(Of rowTblFile)
        Dim zSQL As String = "SELECT * FROM [tblFile] WHERE [fldGuid] = @colFldGuid"
        Dim zCmd As New SQLCommand
        Dim zReader As SQLDataReader

        zCmd.CommandText = zSQL
    	zCmd.Parameters.Add(New SQLParameter("@colFldGuid", pcolFldGuid))
        zReader = UtilSQLServer.ExecuteReader(zCmd)

        While zReader.Read
            Dim zObj As New rowTblFile
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldId")) Then zObj.colFldId = zReader.GetSqlInt32(zReader.GetOrdinal("fldId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldRefId")) Then zObj.colFldRefId = zReader.GetSqlInt32(zReader.GetOrdinal("fldRefId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldFileTypeId")) Then zObj.colFldFileTypeId = zReader.GetSqlInt32(zReader.GetOrdinal("fldFileTypeId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldGuid")) Then zObj.colFldGuid = zReader.GetSqlString(zReader.GetOrdinal("fldGuid"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldCreateDate")) Then zObj.colFldCreateDate = zReader.GetSqlDateTime(zReader.GetOrdinal("fldCreateDate"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldAccessDate")) Then zObj.colFldAccessDate = zReader.GetSqlDateTime(zReader.GetOrdinal("fldAccessDate"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldData")) Then zObj.colFldData = zReader("fldData")
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldFileSize")) Then zObj.colFldFileSize = zReader.GetSqlInt32(zReader.GetOrdinal("fldFileSize"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldMime")) Then zObj.colFldMime = zReader.GetSqlString(zReader.GetOrdinal("fldMime"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldExtension")) Then zObj.colFldExtension = zReader.GetSqlString(zReader.GetOrdinal("fldExtension"))
            zReturn.Add(zObj)
        End While

        zReader.Close()
        zReader = Nothing

        Return zReturn
	End Function

	Public Shared Function LoadByIDX_PK__tblFile__36326BE31D7DC22A(pcolFldId As Integer) As List(Of rowTblFile)
        Dim zReturn As New List(Of rowTblFile)
        Dim zSQL As String = "SELECT * FROM [tblFile] WHERE [fldId] = @colFldId"
        Dim zCmd As New SQLCommand
        Dim zReader As SQLDataReader

        zCmd.CommandText = zSQL
    	zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))
        zReader = UtilSQLServer.ExecuteReader(zCmd)

        While zReader.Read
            Dim zObj As New rowTblFile
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldId")) Then zObj.colFldId = zReader.GetSqlInt32(zReader.GetOrdinal("fldId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldRefId")) Then zObj.colFldRefId = zReader.GetSqlInt32(zReader.GetOrdinal("fldRefId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldFileTypeId")) Then zObj.colFldFileTypeId = zReader.GetSqlInt32(zReader.GetOrdinal("fldFileTypeId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldGuid")) Then zObj.colFldGuid = zReader.GetSqlString(zReader.GetOrdinal("fldGuid"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldCreateDate")) Then zObj.colFldCreateDate = zReader.GetSqlDateTime(zReader.GetOrdinal("fldCreateDate"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldAccessDate")) Then zObj.colFldAccessDate = zReader.GetSqlDateTime(zReader.GetOrdinal("fldAccessDate"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldData")) Then zObj.colFldData = zReader("fldData")
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldFileSize")) Then zObj.colFldFileSize = zReader.GetSqlInt32(zReader.GetOrdinal("fldFileSize"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldMime")) Then zObj.colFldMime = zReader.GetSqlString(zReader.GetOrdinal("fldMime"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldExtension")) Then zObj.colFldExtension = zReader.GetSqlString(zReader.GetOrdinal("fldExtension"))
            zReturn.Add(zObj)
        End While

        zReader.Close()
        zReader = Nothing

        Return zReturn
	End Function

    Public Shared Function LoadData(pSQL As String) As List(Of rowTblFile)
        Dim zReturn As New List(Of rowTblFile)
        Dim zSQL As String = "SELECT * FROM [tblFile]"
        Dim zCmd As New SQLCommand
        Dim zReader As SQLDataReader

        If pSQL <> "" Then zSQL = pSQL

        zCmd.CommandText = zSQL
        zReader = UtilSQLServer.ExecuteReader(zCmd)

        While zReader.Read
            Dim zObj As New rowTblFile
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldId")) Then zObj.colFldId = zReader.GetSqlInt32(zReader.GetOrdinal("fldId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldRefId")) Then zObj.colFldRefId = zReader.GetSqlInt32(zReader.GetOrdinal("fldRefId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldFileTypeId")) Then zObj.colFldFileTypeId = zReader.GetSqlInt32(zReader.GetOrdinal("fldFileTypeId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldGuid")) Then zObj.colFldGuid = zReader.GetSqlString(zReader.GetOrdinal("fldGuid"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldCreateDate")) Then zObj.colFldCreateDate = zReader.GetSqlDateTime(zReader.GetOrdinal("fldCreateDate"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldAccessDate")) Then zObj.colFldAccessDate = zReader.GetSqlDateTime(zReader.GetOrdinal("fldAccessDate"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldData")) Then zObj.colFldData = zReader("fldData")
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldFileSize")) Then zObj.colFldFileSize = zReader.GetSqlInt32(zReader.GetOrdinal("fldFileSize"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldMime")) Then zObj.colFldMime = zReader.GetSqlString(zReader.GetOrdinal("fldMime"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldExtension")) Then zObj.colFldExtension = zReader.GetSqlString(zReader.GetOrdinal("fldExtension"))
            zReturn.Add(zObj)
        End While

        zReader.Close()
        zReader = Nothing

        Return zReturn
    End Function

    Public Shared Function LoadData(Optional pCommand As SqlCommand = Nothing) As List(Of rowTblFile)
        Dim zReturn As New List(Of rowTblFile)
        Dim zSQL As String = "SELECT * FROM [tblFile]"
        Dim zCmd As New SQLCommand
        Dim zReader As SQLDataReader

        If pCommand Is Nothing Then
            zCmd.CommandText = zSQL
        Else
            zCmd = pCommand
        End If

        zReader = UtilSQLServer.ExecuteReader(zCmd)

        While zReader.Read
            Dim zObj As New rowTblFile		
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldId")) Then 
				zObj.colFldId = zReader.GetValue(zReader.GetOrdinal("fldId"))
			End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldRefId")) Then 
				zObj.colFldRefId = zReader.GetValue(zReader.GetOrdinal("fldRefId"))
			End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldFileTypeId")) Then 
				zObj.colFldFileTypeId = zReader.GetValue(zReader.GetOrdinal("fldFileTypeId"))
			End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldGuid")) Then 
				zObj.colFldGuid = zReader.GetValue(zReader.GetOrdinal("fldGuid"))
			End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldCreateDate")) Then 
				zObj.colFldCreateDate = zReader.GetValue(zReader.GetOrdinal("fldCreateDate"))
			End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldAccessDate")) Then 
				zObj.colFldAccessDate = zReader.GetValue(zReader.GetOrdinal("fldAccessDate"))
			End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldData")) Then 
				zObj.colFldData = zReader.GetValue(zReader.GetOrdinal("fldData"))
			End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldFileSize")) Then 
				zObj.colFldFileSize = zReader.GetValue(zReader.GetOrdinal("fldFileSize"))
			End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldMime")) Then 
				zObj.colFldMime = zReader.GetValue(zReader.GetOrdinal("fldMime"))
			End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("fldExtension")) Then 
				zObj.colFldExtension = zReader.GetValue(zReader.GetOrdinal("fldExtension"))
			End If
            zReturn.Add(zObj)
        End While

        zReader.Close()
        zReader = Nothing

        Return zReturn
    End Function

End Class

Partial Public Class rowTblFile
    Public colFldId As Nullable(Of Integer)
    Public colFldRefId As Nullable(Of Integer)
    Public colFldFileTypeId As Nullable(Of Integer)
    Public colFldGuid As String
    Public colFldCreateDate As Nullable(Of DateTime)
    Public colFldAccessDate As Nullable(Of DateTime)
    Public colFldData As Byte()
    Public colFldFileSize As Nullable(Of Integer)
    Public colFldMime As String
    Public colFldExtension As String
End Class
