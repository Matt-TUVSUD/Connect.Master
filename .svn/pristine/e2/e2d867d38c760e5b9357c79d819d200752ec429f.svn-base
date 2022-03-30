Imports System.Data.SqlClient
Imports GRC.Connect.Libraries.DataLib.razor

Partial Public Class tblGSafeSitemapItems

    Public Shared Sub Delete(ByRef pRowData As rowGSafeSitemapItems)
        Dim zSQL As String = ""
        Dim zMode As String = ""

		If UtilSQLServer.IsKeySet(pRowData.colGSafeId) And UtilSQLServer.IsKeySet(pRowData.colNavLinkId) Then
            'Delete
            zMode = "DELETE"
            zSQL = "DELETE FROM [GSafeSitemapItems] " & _
                    "WHERE [GSafeId] = @colGSafeId AND [NavLinkId] = @colNavLinkId"

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colGSafeId", pRowData.colGSafeId))
            zCmd.Parameters.Add(New SQLParameter("@colNavLinkId", pRowData.colNavLinkId))

            UtilSQLServer.ExecuteNonQuery(zCmd)
        End If

    End Sub

    Public Shared Sub Save(ByRef pRowData As rowGSafeSitemapItems)
        Dim zSQL As String = ""
        Dim zMode As String = ""
		DIm zExistInDB as Long = -1
		If UtilSQLServer.IsKeySet(pRowData.colGSafeId) And UtilSQLServer.IsKeySet(pRowData.colNavLinkId) Then

			zSQL = "SELECT COUNT(*) from [GSafeSitemapItems] WHERE [GSafeId] = @colGSafeId AND [NavLinkId] = @colNavLinkId"

			Dim zCmdDoesExist as New SQLCommand

			zCmdDoesExist.CommandText = zSQL

			zCmdDoesExist.Parameters.Add(new SQLParameter("@colGSafeId", pRowData.colGSafeId))
			zCmdDoesExist.Parameters.Add(new SQLParameter("@colNavLinkId", pRowData.colNavLinkId))

			'if zExistInDB > 0  then  PK exists in the DB
			zExistInDB = UtilSQLServer.ExecuteScalar(zCmdDoesExist)
		End If

		If UtilSQLServer.IsKeySet(pRowData.colGSafeId) And UtilSQLServer.IsKeySet(pRowData.colNavLinkId) And zExistInDB > 0 Then
			zMode = "UPDATE"
		End If
		If UtilSQLServer.IsKeySet(pRowData.colGSafeId) And UtilSQLServer.IsKeySet(pRowData.colNavLinkId) And zExistInDB = 0 Then
			zMode = "INSERTwithKey"
		End If
		If Not UtilSQLServer.IsKeySet(pRowData.colGSafeId) Or Not UtilSQLServer.IsKeySet(pRowData.colNavLinkId) Then
			zMode = "INSERTnoKey"
		End If

		Select Case zMode
			Case "UPDATE"
				zSQL = "UPDATE [GSafeSitemapItems] SET " & _
                                " [NavSiteMapKeyWord] = @colNavSiteMapKeyWord,  " & _
                                " [NavAllReportsKeyword] = @colNavAllReportsKeyword,  " & _
                                " [NavAllDataKeyword] = @colNavAllDataKeyword,  " & _
                                " [NavParentLinkId] = @colNavParentLinkId,  " & _
                                " [NavText] = @colNavText,  " & _
                                " [NavUrl] = @colNavUrl,  " & _
                                " [NavOrder] = @colNavOrder,  " & _
                                " [NavToolTip] = @colNavToolTip,  " & _
                                " [NavVisible] = @colNavVisible,  " & _
                                " [NavEnabled] = @colNavEnabled,  " & _
                                " [NavTarget] = @colNavTarget,  " & _
                                " [NavType] = @colNavType,  " & _
                                " [NavConstant] = @colNavConstant,  " & _
                                " [NavRptCode] = @colNavRptCode,  " & _
                                " [NavGridId] = @colNavGridId,  " & _
                                " [NavChartId] = @colNavChartId,  " & _
                                " [NavExtractId] = @colNavExtractId,  " & _
                                " [NavBypassFilter] = @colNavBypassFilter,  " & _
                                " [NavStatusToolTip] = @colNavStatusToolTip " & _
						" WHERE [GSafeId] = @colGSafeId AND [NavLinkId] = @colNavLinkId"
			Case "INSERTwithKey"
				zSQL = "INSERT INTO [GSafeSitemapItems] ([GSafeId], [NavLinkId], [NavSiteMapKeyWord], [NavAllReportsKeyword], [NavAllDataKeyword], [NavParentLinkId], [NavText], [NavUrl], [NavOrder], [NavToolTip], [NavVisible], [NavEnabled], [NavTarget], [NavType], [NavConstant], [NavRptCode], [NavGridId], [NavChartId], [NavExtractId], [NavBypassFilter], [NavStatusToolTip])" & _
						" VALUES (@colGSafeId, @colNavLinkId, @colNavSiteMapKeyWord, @colNavAllReportsKeyword, @colNavAllDataKeyword, @colNavParentLinkId, @colNavText, @colNavUrl, @colNavOrder, @colNavToolTip, @colNavVisible, @colNavEnabled, @colNavTarget, @colNavType, @colNavConstant, @colNavRptCode, @colNavGridId, @colNavChartId, @colNavExtractId, @colNavBypassFilter, @colNavStatusToolTip)"
			Case "INSERTnoKey"
				zSQL = "INSERT INTO [GSafeSitemapItems] ([NavSiteMapKeyWord], [NavAllReportsKeyword], [NavAllDataKeyword], [NavParentLinkId], [NavText], [NavUrl], [NavOrder], [NavToolTip], [NavVisible], [NavEnabled], [NavTarget], [NavType], [NavConstant], [NavRptCode], [NavGridId], [NavChartId], [NavExtractId], [NavBypassFilter], [NavStatusToolTip])" & _
                        " VALUES (@colNavSiteMapKeyWord, @colNavAllReportsKeyword, @colNavAllDataKeyword, @colNavParentLinkId, @colNavText, @colNavUrl, @colNavOrder, @colNavToolTip, @colNavVisible, @colNavEnabled, @colNavTarget, @colNavType, @colNavConstant, @colNavRptCode, @colNavGridId, @colNavChartId, @colNavExtractId, @colNavBypassFilter, @colNavStatusToolTip)"
			Case Else
		End Select


        Dim zCmd As New SQLCommand
        zCmd.CommandText = zSQL
		If zMode <> "INSERTnoKey" Then

	    	zCmd.Parameters.Add(New SQLParameter("@colGSafeId", pRowData.colGSafeId))
	    	zCmd.Parameters.Add(New SQLParameter("@colNavLinkId", pRowData.colNavLinkId))
		End If

        	zCmd.Parameters.Add(New SqlParameter("@colNavSiteMapKeyWord", IIf(pRowData.colNavSiteMapKeyWord Is Nothing, DBNull.Value, pRowData.colNavSiteMapKeyWord)))
        	zCmd.Parameters.Add(New SqlParameter("@colNavAllReportsKeyword", IIf(pRowData.colNavAllReportsKeyword Is Nothing, DBNull.Value, pRowData.colNavAllReportsKeyword)))
        	zCmd.Parameters.Add(New SqlParameter("@colNavAllDataKeyword", IIf(pRowData.colNavAllDataKeyword Is Nothing, DBNull.Value, pRowData.colNavAllDataKeyword)))
        	zCmd.Parameters.Add(New SqlParameter("@colNavParentLinkId", IIf(pRowData.colNavParentLinkId Is Nothing, DBNull.Value, pRowData.colNavParentLinkId)))
        	zCmd.Parameters.Add(New SqlParameter("@colNavText", IIf(pRowData.colNavText Is Nothing, DBNull.Value, pRowData.colNavText)))
        	zCmd.Parameters.Add(New SqlParameter("@colNavUrl", IIf(pRowData.colNavUrl Is Nothing, DBNull.Value, pRowData.colNavUrl)))
        	zCmd.Parameters.Add(New SqlParameter("@colNavOrder", IIf(pRowData.colNavOrder Is Nothing, DBNull.Value, pRowData.colNavOrder)))
        	zCmd.Parameters.Add(New SqlParameter("@colNavToolTip", IIf(pRowData.colNavToolTip Is Nothing, DBNull.Value, pRowData.colNavToolTip)))
        	zCmd.Parameters.Add(New SqlParameter("@colNavVisible", IIf(pRowData.colNavVisible Is Nothing, DBNull.Value, pRowData.colNavVisible)))
        	zCmd.Parameters.Add(New SqlParameter("@colNavEnabled", IIf(pRowData.colNavEnabled Is Nothing, DBNull.Value, pRowData.colNavEnabled)))
        	zCmd.Parameters.Add(New SqlParameter("@colNavTarget", IIf(pRowData.colNavTarget Is Nothing, DBNull.Value, pRowData.colNavTarget)))
        	zCmd.Parameters.Add(New SqlParameter("@colNavType", IIf(pRowData.colNavType Is Nothing, DBNull.Value, pRowData.colNavType)))
        	zCmd.Parameters.Add(New SqlParameter("@colNavConstant", IIf(pRowData.colNavConstant Is Nothing, DBNull.Value, pRowData.colNavConstant)))
        	zCmd.Parameters.Add(New SqlParameter("@colNavRptCode", IIf(pRowData.colNavRptCode Is Nothing, DBNull.Value, pRowData.colNavRptCode)))
        	zCmd.Parameters.Add(New SqlParameter("@colNavGridId", IIf(pRowData.colNavGridId Is Nothing, DBNull.Value, pRowData.colNavGridId)))
        	zCmd.Parameters.Add(New SqlParameter("@colNavChartId", IIf(pRowData.colNavChartId Is Nothing, DBNull.Value, pRowData.colNavChartId)))
        	zCmd.Parameters.Add(New SqlParameter("@colNavExtractId", IIf(pRowData.colNavExtractId Is Nothing, DBNull.Value, pRowData.colNavExtractId)))
        	zCmd.Parameters.Add(New SqlParameter("@colNavBypassFilter", IIf(pRowData.colNavBypassFilter Is Nothing, DBNull.Value, pRowData.colNavBypassFilter)))
        	zCmd.Parameters.Add(New SqlParameter("@colNavStatusToolTip", IIf(pRowData.colNavStatusToolTip Is Nothing, DBNull.Value, pRowData.colNavStatusToolTip)))

        If zMode = "INSERTnoKey" Then
	        Dim zLastId As Long = 0
	        zLastId = UtilSQLServer.ExecuteNonQueryRowId(zCmd)

            pRowData.colGSafeId = zLastId
            pRowData.colNavLinkId = zLastId
		Else
			UtilSQLServer.ExecuteNonQuery(zCmd)
        End If
    End Sub

    Public Shared Function LoadByPrimaryKey(pcolGSafeId As Integer, pcolNavLinkId As Integer) As rowGSafeSitemapItems
        Dim zReturn As New rowGSafeSitemapItems
        Dim zSQL As String = "SELECT * FROM [GSafeSitemapItems] WHERE [GSafeId] = @colGSafeId AND [NavLinkId] = @colNavLinkId"
        Dim zCmd As New SQLCommand
        Dim zReader As SQLDataReader

        zCmd.CommandText = zSQL
    	zCmd.Parameters.Add(New SQLParameter("@colGSafeId", pcolGSafeId))
    	zCmd.Parameters.Add(New SQLParameter("@colNavLinkId", pcolNavLinkId))
        zReader = UtilSQLServer.ExecuteReader(zCmd)

        While zReader.Read
            If Not zReader.IsDBNull(zReader.GetOrdinal("GSafeId")) Then zReturn.colGSafeId = zReader.GetSqlInt32(zReader.GetOrdinal("GSafeId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavLinkId")) Then zReturn.colNavLinkId = zReader.GetSqlInt32(zReader.GetOrdinal("NavLinkId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavSiteMapKeyWord")) Then zReturn.colNavSiteMapKeyWord = zReader.GetSqlString(zReader.GetOrdinal("NavSiteMapKeyWord"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavAllReportsKeyword")) Then zReturn.colNavAllReportsKeyword = zReader.GetSqlString(zReader.GetOrdinal("NavAllReportsKeyword"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavAllDataKeyword")) Then zReturn.colNavAllDataKeyword = zReader.GetSqlString(zReader.GetOrdinal("NavAllDataKeyword"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavParentLinkId")) Then zReturn.colNavParentLinkId = zReader.GetSqlInt32(zReader.GetOrdinal("NavParentLinkId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavText")) Then zReturn.colNavText = zReader.GetSqlString(zReader.GetOrdinal("NavText"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavUrl")) Then zReturn.colNavUrl = zReader.GetSqlString(zReader.GetOrdinal("NavUrl"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavOrder")) Then zReturn.colNavOrder = zReader.GetSqlInt32(zReader.GetOrdinal("NavOrder"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavToolTip")) Then zReturn.colNavToolTip = zReader.GetSqlString(zReader.GetOrdinal("NavToolTip"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavVisible")) Then zReturn.colNavVisible = zReader.GetSqlBoolean(zReader.GetOrdinal("NavVisible"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavEnabled")) Then zReturn.colNavEnabled = zReader.GetSqlBoolean(zReader.GetOrdinal("NavEnabled"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavTarget")) Then zReturn.colNavTarget = zReader.GetSqlString(zReader.GetOrdinal("NavTarget"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavType")) Then zReturn.colNavType = zReader.GetSqlString(zReader.GetOrdinal("NavType"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavConstant")) Then zReturn.colNavConstant = zReader.GetSqlString(zReader.GetOrdinal("NavConstant"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavRptCode")) Then zReturn.colNavRptCode = zReader.GetSqlString(zReader.GetOrdinal("NavRptCode"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavGridId")) Then zReturn.colNavGridId = zReader.GetSqlInt32(zReader.GetOrdinal("NavGridId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavChartId")) Then zReturn.colNavChartId = zReader.GetSqlInt32(zReader.GetOrdinal("NavChartId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavExtractId")) Then zReturn.colNavExtractId = zReader.GetSqlInt32(zReader.GetOrdinal("NavExtractId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavBypassFilter")) Then zReturn.colNavBypassFilter = zReader.GetSqlBoolean(zReader.GetOrdinal("NavBypassFilter"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavStatusToolTip")) Then zReturn.colNavStatusToolTip = zReader.GetSqlString(zReader.GetOrdinal("NavStatusToolTip"))
        End While

        zReader.Close()
        zReader = Nothing

        Return zReturn
    End Function

	Public Shared Function LoadByIDX_PK_GSafeId_NavLinkId(pcolGSafeId As Integer, pcolNavLinkId As Integer) As List(Of rowGSafeSitemapItems)
        Dim zReturn As New List(Of rowGSafeSitemapItems)
        Dim zSQL As String = "SELECT * FROM [GSafeSitemapItems] WHERE [GSafeId] = @colGSafeId AND [NavLinkId] = @colNavLinkId"
        Dim zCmd As New SQLCommand
        Dim zReader As SQLDataReader

        zCmd.CommandText = zSQL
    	zCmd.Parameters.Add(New SQLParameter("@colGSafeId", pcolGSafeId))
    	zCmd.Parameters.Add(New SQLParameter("@colNavLinkId", pcolNavLinkId))
        zReader = UtilSQLServer.ExecuteReader(zCmd)

        While zReader.Read
            Dim zObj As New rowGSafeSitemapItems
            If Not zReader.IsDBNull(zReader.GetOrdinal("GSafeId")) Then zObj.colGSafeId = zReader.GetSqlInt32(zReader.GetOrdinal("GSafeId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavLinkId")) Then zObj.colNavLinkId = zReader.GetSqlInt32(zReader.GetOrdinal("NavLinkId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavSiteMapKeyWord")) Then zObj.colNavSiteMapKeyWord = zReader.GetSqlString(zReader.GetOrdinal("NavSiteMapKeyWord"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavAllReportsKeyword")) Then zObj.colNavAllReportsKeyword = zReader.GetSqlString(zReader.GetOrdinal("NavAllReportsKeyword"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavAllDataKeyword")) Then zObj.colNavAllDataKeyword = zReader.GetSqlString(zReader.GetOrdinal("NavAllDataKeyword"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavParentLinkId")) Then zObj.colNavParentLinkId = zReader.GetSqlInt32(zReader.GetOrdinal("NavParentLinkId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavText")) Then zObj.colNavText = zReader.GetSqlString(zReader.GetOrdinal("NavText"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavUrl")) Then zObj.colNavUrl = zReader.GetSqlString(zReader.GetOrdinal("NavUrl"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavOrder")) Then zObj.colNavOrder = zReader.GetSqlInt32(zReader.GetOrdinal("NavOrder"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavToolTip")) Then zObj.colNavToolTip = zReader.GetSqlString(zReader.GetOrdinal("NavToolTip"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavVisible")) Then zObj.colNavVisible = zReader.GetSqlBoolean(zReader.GetOrdinal("NavVisible"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavEnabled")) Then zObj.colNavEnabled = zReader.GetSqlBoolean(zReader.GetOrdinal("NavEnabled"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavTarget")) Then zObj.colNavTarget = zReader.GetSqlString(zReader.GetOrdinal("NavTarget"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavType")) Then zObj.colNavType = zReader.GetSqlString(zReader.GetOrdinal("NavType"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavConstant")) Then zObj.colNavConstant = zReader.GetSqlString(zReader.GetOrdinal("NavConstant"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavRptCode")) Then zObj.colNavRptCode = zReader.GetSqlString(zReader.GetOrdinal("NavRptCode"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavGridId")) Then zObj.colNavGridId = zReader.GetSqlInt32(zReader.GetOrdinal("NavGridId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavChartId")) Then zObj.colNavChartId = zReader.GetSqlInt32(zReader.GetOrdinal("NavChartId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavExtractId")) Then zObj.colNavExtractId = zReader.GetSqlInt32(zReader.GetOrdinal("NavExtractId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavBypassFilter")) Then zObj.colNavBypassFilter = zReader.GetSqlBoolean(zReader.GetOrdinal("NavBypassFilter"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavStatusToolTip")) Then zObj.colNavStatusToolTip = zReader.GetSqlString(zReader.GetOrdinal("NavStatusToolTip"))
            zReturn.Add(zObj)
        End While

        zReader.Close()
        zReader = Nothing

        Return zReturn
	End Function

    Public Shared Function LoadData(pSQL As String) As List(Of rowGSafeSitemapItems)
        Dim zReturn As New List(Of rowGSafeSitemapItems)
        Dim zSQL As String = "SELECT * FROM [GSafeSitemapItems]"
        Dim zCmd As New SQLCommand
        Dim zReader As SQLDataReader

        If pSQL <> "" Then zSQL = pSQL

        zCmd.CommandText = zSQL
        zReader = UtilSQLServer.ExecuteReader(zCmd)

        While zReader.Read
            Dim zObj As New rowGSafeSitemapItems
            If Not zReader.IsDBNull(zReader.GetOrdinal("GSafeId")) Then zObj.colGSafeId = zReader.GetSqlInt32(zReader.GetOrdinal("GSafeId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavLinkId")) Then zObj.colNavLinkId = zReader.GetSqlInt32(zReader.GetOrdinal("NavLinkId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavSiteMapKeyWord")) Then zObj.colNavSiteMapKeyWord = zReader.GetSqlString(zReader.GetOrdinal("NavSiteMapKeyWord"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavAllReportsKeyword")) Then zObj.colNavAllReportsKeyword = zReader.GetSqlString(zReader.GetOrdinal("NavAllReportsKeyword"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavAllDataKeyword")) Then zObj.colNavAllDataKeyword = zReader.GetSqlString(zReader.GetOrdinal("NavAllDataKeyword"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavParentLinkId")) Then zObj.colNavParentLinkId = zReader.GetSqlInt32(zReader.GetOrdinal("NavParentLinkId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavText")) Then zObj.colNavText = zReader.GetSqlString(zReader.GetOrdinal("NavText"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavUrl")) Then zObj.colNavUrl = zReader.GetSqlString(zReader.GetOrdinal("NavUrl"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavOrder")) Then zObj.colNavOrder = zReader.GetSqlInt32(zReader.GetOrdinal("NavOrder"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavToolTip")) Then zObj.colNavToolTip = zReader.GetSqlString(zReader.GetOrdinal("NavToolTip"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavVisible")) Then zObj.colNavVisible = zReader.GetSqlBoolean(zReader.GetOrdinal("NavVisible"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavEnabled")) Then zObj.colNavEnabled = zReader.GetSqlBoolean(zReader.GetOrdinal("NavEnabled"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavTarget")) Then zObj.colNavTarget = zReader.GetSqlString(zReader.GetOrdinal("NavTarget"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavType")) Then zObj.colNavType = zReader.GetSqlString(zReader.GetOrdinal("NavType"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavConstant")) Then zObj.colNavConstant = zReader.GetSqlString(zReader.GetOrdinal("NavConstant"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavRptCode")) Then zObj.colNavRptCode = zReader.GetSqlString(zReader.GetOrdinal("NavRptCode"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavGridId")) Then zObj.colNavGridId = zReader.GetSqlInt32(zReader.GetOrdinal("NavGridId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavChartId")) Then zObj.colNavChartId = zReader.GetSqlInt32(zReader.GetOrdinal("NavChartId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavExtractId")) Then zObj.colNavExtractId = zReader.GetSqlInt32(zReader.GetOrdinal("NavExtractId"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavBypassFilter")) Then zObj.colNavBypassFilter = zReader.GetSqlBoolean(zReader.GetOrdinal("NavBypassFilter"))
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavStatusToolTip")) Then zObj.colNavStatusToolTip = zReader.GetSqlString(zReader.GetOrdinal("NavStatusToolTip"))
            zReturn.Add(zObj)
        End While

        zReader.Close()
        zReader = Nothing

        Return zReturn
    End Function

    Public Shared Function LoadData(Optional pCommand As SqlCommand = Nothing) As List(Of rowGSafeSitemapItems)
        Dim zReturn As New List(Of rowGSafeSitemapItems)
        Dim zSQL As String = "SELECT * FROM [GSafeSitemapItems]"
        Dim zCmd As New SQLCommand
        Dim zReader As SQLDataReader

        If pCommand Is Nothing Then
            zCmd.CommandText = zSQL
        Else
            zCmd = pCommand
        End If

        zReader = UtilSQLServer.ExecuteReader(zCmd)

        While zReader.Read
            Dim zObj As New rowGSafeSitemapItems		
            If Not zReader.IsDBNull(zReader.GetOrdinal("GSafeId")) Then 
				zObj.colGSafeId = zReader.GetValue(zReader.GetOrdinal("GSafeId"))
			End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavLinkId")) Then 
				zObj.colNavLinkId = zReader.GetValue(zReader.GetOrdinal("NavLinkId"))
			End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavSiteMapKeyWord")) Then 
				zObj.colNavSiteMapKeyWord = zReader.GetValue(zReader.GetOrdinal("NavSiteMapKeyWord"))
			End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavAllReportsKeyword")) Then 
				zObj.colNavAllReportsKeyword = zReader.GetValue(zReader.GetOrdinal("NavAllReportsKeyword"))
			End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavAllDataKeyword")) Then 
				zObj.colNavAllDataKeyword = zReader.GetValue(zReader.GetOrdinal("NavAllDataKeyword"))
			End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavParentLinkId")) Then 
				zObj.colNavParentLinkId = zReader.GetValue(zReader.GetOrdinal("NavParentLinkId"))
			End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavText")) Then 
				zObj.colNavText = zReader.GetValue(zReader.GetOrdinal("NavText"))
			End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavUrl")) Then 
				zObj.colNavUrl = zReader.GetValue(zReader.GetOrdinal("NavUrl"))
			End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavOrder")) Then 
				zObj.colNavOrder = zReader.GetValue(zReader.GetOrdinal("NavOrder"))
			End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavToolTip")) Then 
				zObj.colNavToolTip = zReader.GetValue(zReader.GetOrdinal("NavToolTip"))
			End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavVisible")) Then 
				zObj.colNavVisible = zReader.GetValue(zReader.GetOrdinal("NavVisible"))
			End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavEnabled")) Then 
				zObj.colNavEnabled = zReader.GetValue(zReader.GetOrdinal("NavEnabled"))
			End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavTarget")) Then 
				zObj.colNavTarget = zReader.GetValue(zReader.GetOrdinal("NavTarget"))
			End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavType")) Then 
				zObj.colNavType = zReader.GetValue(zReader.GetOrdinal("NavType"))
			End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavConstant")) Then 
				zObj.colNavConstant = zReader.GetValue(zReader.GetOrdinal("NavConstant"))
			End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavRptCode")) Then 
				zObj.colNavRptCode = zReader.GetValue(zReader.GetOrdinal("NavRptCode"))
			End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavGridId")) Then 
				zObj.colNavGridId = zReader.GetValue(zReader.GetOrdinal("NavGridId"))
			End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavChartId")) Then 
				zObj.colNavChartId = zReader.GetValue(zReader.GetOrdinal("NavChartId"))
			End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavExtractId")) Then 
				zObj.colNavExtractId = zReader.GetValue(zReader.GetOrdinal("NavExtractId"))
			End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavBypassFilter")) Then 
				zObj.colNavBypassFilter = zReader.GetValue(zReader.GetOrdinal("NavBypassFilter"))
			End If
            If Not zReader.IsDBNull(zReader.GetOrdinal("NavStatusToolTip")) Then 
				zObj.colNavStatusToolTip = zReader.GetValue(zReader.GetOrdinal("NavStatusToolTip"))
			End If
            zReturn.Add(zObj)
        End While

        zReader.Close()
        zReader = Nothing

        Return zReturn
    End Function

End Class

Partial Public Class rowGSafeSitemapItems
    Public colGSafeId As Nullable(Of Integer)
    Public colNavLinkId As Nullable(Of Integer)
    Public colNavSiteMapKeyWord As String
    Public colNavAllReportsKeyword As String
    Public colNavAllDataKeyword As String
    Public colNavParentLinkId As Nullable(Of Integer)
    Public colNavText As String
    Public colNavUrl As String
    Public colNavOrder As Nullable(Of Integer)
    Public colNavToolTip As String
    Public colNavVisible As Nullable(Of Boolean)
    Public colNavEnabled As Nullable(Of Boolean)
    Public colNavTarget As String
    Public colNavType As String
    Public colNavConstant As String
    Public colNavRptCode As String
    Public colNavGridId As Nullable(Of Integer)
    Public colNavChartId As Nullable(Of Integer)
    Public colNavExtractId As Nullable(Of Integer)
    Public colNavBypassFilter As Nullable(Of Boolean)
    Public colNavStatusToolTip As String
End Class

