'/===============================================================\
'| razor data (experimental) - rev 4.2.881   EXPERIMENTAL        |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'|  Data Types not supported due to type mapping issues: money,  |
'| date, varchar(1), nvarchar(1)                                 |
'\===============================================================/
Imports System.Data.SqlClient

Namespace razor
    Partial Public Class TblNavLink

        Public Shared Sub Delete(ByRef pRowData As IrowTblNavLink)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblNavLink, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblNavLink, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblNavLink, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colNavLinkId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[NavLink] " & _
                        "WHERE [NavLinkId] = @colNavLinkId"

                Dim zCmd As New SQLCommand
                zCmd.CommandText = zSQL
                zCmd.Parameters.Add(New SQLParameter("@colNavLinkId", pRowData.colNavLinkId))

                zCmd.Transaction=pTransaction
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)

                pRowData.RaiseDeletedEvent(pDeleteEventUserState)

            End If

        End Sub

        Public Shared Sub Delete(pcolNavLinkId As Integer)
            Delete(pcolNavLinkId, Nothing, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolNavLinkId As Integer, pDeleteEventUserState As Object)
            Delete(pcolNavLinkId, Nothing, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Delete(pcolNavLinkId As Integer, ByRef pTransaction As SqlClient.SqlTransaction)
        Delete(pcolNavLinkId, pTransaction, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolNavLinkId As Integer, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
        Dim zObj As rowTblNavLink = LoadByPrimaryKey(pcolNavLinkId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblNavLink)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblNavLink, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblNavLink, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colNavLinkId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[NavLink] WHERE [NavLinkId] = @colNavLinkId"

                Dim zCmdDoesExist As New SQLCommand

                zCmdDoesExist.CommandText = zSQL

                zCmdDoesExist.Parameters.Add(new SQLParameter("@colNavLinkId", pRowData.colNavLinkId))

                'if zExistInDB > 0  then  PK exists in the DB
                zCmdDoesExist.Transaction = pTransaction
                zExistInDB = razor.UtilSQLServer.ExecuteScalar(zCmdDoesExist)
            End If

            If razor.UtilSQLServer.IsKeySet(pRowData.colNavLinkId) And zExistInDB > 0 Then
                zMode = "UPDATE"
            End If
            If razor.UtilSQLServer.IsKeySet(pRowData.colNavLinkId) And zExistInDB = 0 Then
                zMode = "INSERTwithKey"
            End If
            If Not razor.UtilSQLServer.IsKeySet(pRowData.colNavLinkId) Then
                zMode = "INSERTnoKey"
            End If

            Select Case zMode
                Case "UPDATE"
                    If pRowData.IsDirty Then
                        Dim zUpdate As String = ""
                        Dim zSet As String = ""
                        Dim zWhere As String = ""
                        zUpdate = "UPDATE [dbo].[NavLink] SET " 
                        If pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavControlId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [NavControlId] = @colNavControlId "
                        End If
                        If pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavPracticeID) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [NavPracticeID] = @colNavPracticeID "
                        End If
                        If pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavLevelId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [NavLevelId] = @colNavLevelId "
                        End If
                        If pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavParentLinkId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [NavParentLinkId] = @colNavParentLinkId "
                        End If
                        If pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavText) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [NavText] = @colNavText "
                        End If
                        If pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavUrl) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [NavUrl] = @colNavUrl "
                        End If
                        If pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavOrder) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [NavOrder] = @colNavOrder "
                        End If
                        If pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavToolTip) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [NavToolTip] = @colNavToolTip "
                        End If
                        If pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavVisible) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [NavVisible] = @colNavVisible "
                        End If
                        If pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavEnabled) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [NavEnabled] = @colNavEnabled "
                        End If
                        If pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavSpcFeature) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [NavSpcFeature] = @colNavSpcFeature "
                        End If
                        If pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavIsPracticeTopLink) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [NavIsPracticeTopLink] = @colNavIsPracticeTopLink "
                        End If
                        If pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavDefaultExpanded) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [NavDefaultExpanded] = @colNavDefaultExpanded "
                        End If
                        If pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavSiteMapKeyWord) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [NavSiteMapKeyWord] = @colNavSiteMapKeyWord "
                        End If
                        If pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavAllReportsKeyword) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [NavAllReportsKeyword] = @colNavAllReportsKeyword "
                        End If
                        If pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavAllDataKeyword) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [NavAllDataKeyword] = @colNavAllDataKeyword "
                        End If
                        If pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavTarget) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [NavTarget] = @colNavTarget "
                        End If
                        If pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavType) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [NavType] = @colNavType "
                        End If
                        If pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavComment) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [NavComment] = @colNavComment "
                        End If
                        If pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavConstant) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [NavConstant] = @colNavConstant "
                        End If
                        If pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavReportId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [NavReportId] = @colNavReportId "
                        End If
                        If pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavGridId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [NavGridId] = @colNavGridId "
                        End If
                        If pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavChartId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [NavChartId] = @colNavChartId "
                        End If
                        If pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavExtractId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [NavExtractId] = @colNavExtractId "
                        End If
                        If pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavBypassFilter) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [NavBypassFilter] = @colNavBypassFilter "
                        End If
                        If pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavStatusToolTip) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [NavStatusToolTip] = @colNavStatusToolTip "
                        End If
                        If pRowData.IsDirty(rowTblNavLink.FieldIndex.colSlideMenuId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [slideMenuId] = @colSlideMenuId "
                        End If
                        If pRowData.IsDirty(rowTblNavLink.FieldIndex.colSlideGroupId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [slideGroupId] = @colSlideGroupId "
                        End If
                        If pRowData.IsDirty(rowTblNavLink.FieldIndex.colSlideLevelId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [slideLevelId] = @colSlideLevelId "
                        End If
                        If pRowData.IsDirty(rowTblNavLink.FieldIndex.colSlideType) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [slideType] = @colSlideType "
                        End If
                        If pRowData.IsDirty(rowTblNavLink.FieldIndex.colSlideParentId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [slideParentId] = @colSlideParentId "
                        End If
                        If pRowData.IsDirty(rowTblNavLink.FieldIndex.colSlideOrder) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [slideOrder] = @colSlideOrder "
                        End If
                        If pRowData.IsDirty(rowTblNavLink.FieldIndex.colSlideImageClassName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [slideImageClassName] = @colSlideImageClassName "
                        End If
                        If pRowData.IsDirty(rowTblNavLink.FieldIndex.colIsClientAdmin) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [IsClientAdmin] = @colIsClientAdmin "
                        End If
                        zWhere = " WHERE [NavLinkId] = @colNavLinkId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[NavLink] ([NavControlId], [NavPracticeID], [NavLevelId], [NavParentLinkId], [NavText], [NavUrl], [NavOrder], [NavToolTip], [NavVisible], [NavEnabled], [NavSpcFeature], [NavIsPracticeTopLink], [NavDefaultExpanded], [NavSiteMapKeyWord], [NavAllReportsKeyword], [NavAllDataKeyword], [NavTarget], [NavType], [NavComment], [NavConstant], [NavReportId], [NavGridId], [NavChartId], [NavExtractId], [NavBypassFilter], [NavStatusToolTip], [slideMenuId], [slideGroupId], [slideLevelId], [slideType], [slideParentId], [slideOrder], [slideImageClassName], [IsClientAdmin])" & _
                            " VALUES (@colNavControlId, @colNavPracticeID, @colNavLevelId, @colNavParentLinkId, @colNavText, @colNavUrl, @colNavOrder, @colNavToolTip, @colNavVisible, @colNavEnabled, @colNavSpcFeature, @colNavIsPracticeTopLink, @colNavDefaultExpanded, @colNavSiteMapKeyWord, @colNavAllReportsKeyword, @colNavAllDataKeyword, @colNavTarget, @colNavType, @colNavComment, @colNavConstant, @colNavReportId, @colNavGridId, @colNavChartId, @colNavExtractId, @colNavBypassFilter, @colNavStatusToolTip, @colSlideMenuId, @colSlideGroupId, @colSlideLevelId, @colSlideType, @colSlideParentId, @colSlideOrder, @colSlideImageClassName, @colIsClientAdmin); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[NavLink] ([NavControlId], [NavPracticeID], [NavLevelId], [NavParentLinkId], [NavText], [NavUrl], [NavOrder], [NavToolTip], [NavVisible], [NavEnabled], [NavSpcFeature], [NavIsPracticeTopLink], [NavDefaultExpanded], [NavSiteMapKeyWord], [NavAllReportsKeyword], [NavAllDataKeyword], [NavTarget], [NavType], [NavComment], [NavConstant], [NavReportId], [NavGridId], [NavChartId], [NavExtractId], [NavBypassFilter], [NavStatusToolTip], [slideMenuId], [slideGroupId], [slideLevelId], [slideType], [slideParentId], [slideOrder], [slideImageClassName], [IsClientAdmin])" & _
                            " VALUES (@colNavControlId, @colNavPracticeID, @colNavLevelId, @colNavParentLinkId, @colNavText, @colNavUrl, @colNavOrder, @colNavToolTip, @colNavVisible, @colNavEnabled, @colNavSpcFeature, @colNavIsPracticeTopLink, @colNavDefaultExpanded, @colNavSiteMapKeyWord, @colNavAllReportsKeyword, @colNavAllDataKeyword, @colNavTarget, @colNavType, @colNavComment, @colNavConstant, @colNavReportId, @colNavGridId, @colNavChartId, @colNavExtractId, @colNavBypassFilter, @colNavStatusToolTip, @colSlideMenuId, @colSlideGroupId, @colSlideLevelId, @colSlideType, @colSlideParentId, @colSlideOrder, @colSlideImageClassName, @colIsClientAdmin); SELECT SCOPE_IDENTITY()"
                Case Else
            End Select

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

			'IF UPDATE, SET PK PARAMETER
            If zMode = "UPDATE" Then
                zCmd.Parameters.Add(New SQLParameter("@colNavLinkId", pRowData.colNavLinkId))
            End If

			'IF INSERTING, KEY HAS VALUE AND KEY IS NOT IDENTITY, SET PK PARAMETER
			If zMode = "INSERTwithKey" Then
            End If

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavControlId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colNavControlId", IIf(pRowData.colNavControlId Is Nothing, DBNull.Value, pRowData.colNavControlId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavPracticeID) Then
                    zCmd.Parameters.Add(New SqlParameter("@colNavPracticeID", IIf(pRowData.colNavPracticeID Is Nothing, DBNull.Value, pRowData.colNavPracticeID)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavLevelId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colNavLevelId", IIf(pRowData.colNavLevelId Is Nothing, DBNull.Value, pRowData.colNavLevelId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavParentLinkId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colNavParentLinkId", IIf(pRowData.colNavParentLinkId Is Nothing, DBNull.Value, pRowData.colNavParentLinkId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavText) Then
                    zCmd.Parameters.Add(New SqlParameter("@colNavText", IIf(pRowData.colNavText Is Nothing, DBNull.Value, pRowData.colNavText)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavUrl) Then
                    zCmd.Parameters.Add(New SqlParameter("@colNavUrl", IIf(pRowData.colNavUrl Is Nothing, DBNull.Value, pRowData.colNavUrl)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavOrder) Then
                    zCmd.Parameters.Add(New SqlParameter("@colNavOrder", IIf(pRowData.colNavOrder Is Nothing, DBNull.Value, pRowData.colNavOrder)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavToolTip) Then
                    zCmd.Parameters.Add(New SqlParameter("@colNavToolTip", IIf(pRowData.colNavToolTip Is Nothing, DBNull.Value, pRowData.colNavToolTip)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavVisible) Then
                    zCmd.Parameters.Add(New SqlParameter("@colNavVisible", IIf(pRowData.colNavVisible Is Nothing, DBNull.Value, pRowData.colNavVisible)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavEnabled) Then
                    zCmd.Parameters.Add(New SqlParameter("@colNavEnabled", IIf(pRowData.colNavEnabled Is Nothing, DBNull.Value, pRowData.colNavEnabled)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavSpcFeature) Then
                    zCmd.Parameters.Add(New SqlParameter("@colNavSpcFeature", IIf(pRowData.colNavSpcFeature Is Nothing, DBNull.Value, pRowData.colNavSpcFeature)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavIsPracticeTopLink) Then
                    zCmd.Parameters.Add(New SqlParameter("@colNavIsPracticeTopLink", IIf(pRowData.colNavIsPracticeTopLink Is Nothing, DBNull.Value, pRowData.colNavIsPracticeTopLink)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavDefaultExpanded) Then
                    zCmd.Parameters.Add(New SqlParameter("@colNavDefaultExpanded", IIf(pRowData.colNavDefaultExpanded Is Nothing, DBNull.Value, pRowData.colNavDefaultExpanded)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavSiteMapKeyWord) Then
                    zCmd.Parameters.Add(New SqlParameter("@colNavSiteMapKeyWord", IIf(pRowData.colNavSiteMapKeyWord Is Nothing, DBNull.Value, pRowData.colNavSiteMapKeyWord)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavAllReportsKeyword) Then
                    zCmd.Parameters.Add(New SqlParameter("@colNavAllReportsKeyword", IIf(pRowData.colNavAllReportsKeyword Is Nothing, DBNull.Value, pRowData.colNavAllReportsKeyword)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavAllDataKeyword) Then
                    zCmd.Parameters.Add(New SqlParameter("@colNavAllDataKeyword", IIf(pRowData.colNavAllDataKeyword Is Nothing, DBNull.Value, pRowData.colNavAllDataKeyword)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavTarget) Then
                    zCmd.Parameters.Add(New SqlParameter("@colNavTarget", IIf(pRowData.colNavTarget Is Nothing, DBNull.Value, pRowData.colNavTarget)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavType) Then
                    zCmd.Parameters.Add(New SqlParameter("@colNavType", IIf(pRowData.colNavType Is Nothing, DBNull.Value, pRowData.colNavType)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavComment) Then
                    zCmd.Parameters.Add(New SqlParameter("@colNavComment", IIf(pRowData.colNavComment Is Nothing, DBNull.Value, pRowData.colNavComment)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavConstant) Then
                    zCmd.Parameters.Add(New SqlParameter("@colNavConstant", IIf(pRowData.colNavConstant Is Nothing, DBNull.Value, pRowData.colNavConstant)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavReportId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colNavReportId", IIf(pRowData.colNavReportId Is Nothing, DBNull.Value, pRowData.colNavReportId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavGridId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colNavGridId", IIf(pRowData.colNavGridId Is Nothing, DBNull.Value, pRowData.colNavGridId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavChartId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colNavChartId", IIf(pRowData.colNavChartId Is Nothing, DBNull.Value, pRowData.colNavChartId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavExtractId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colNavExtractId", IIf(pRowData.colNavExtractId Is Nothing, DBNull.Value, pRowData.colNavExtractId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavBypassFilter) Then
                    zCmd.Parameters.Add(New SqlParameter("@colNavBypassFilter", IIf(pRowData.colNavBypassFilter Is Nothing, DBNull.Value, pRowData.colNavBypassFilter)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNavLink.FieldIndex.colNavStatusToolTip) Then
                    zCmd.Parameters.Add(New SqlParameter("@colNavStatusToolTip", IIf(pRowData.colNavStatusToolTip Is Nothing, DBNull.Value, pRowData.colNavStatusToolTip)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNavLink.FieldIndex.colSlideMenuId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSlideMenuId", IIf(pRowData.colSlideMenuId Is Nothing, DBNull.Value, pRowData.colSlideMenuId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNavLink.FieldIndex.colSlideGroupId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSlideGroupId", IIf(pRowData.colSlideGroupId Is Nothing, DBNull.Value, pRowData.colSlideGroupId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNavLink.FieldIndex.colSlideLevelId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSlideLevelId", IIf(pRowData.colSlideLevelId Is Nothing, DBNull.Value, pRowData.colSlideLevelId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNavLink.FieldIndex.colSlideType) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSlideType", IIf(pRowData.colSlideType Is Nothing, DBNull.Value, pRowData.colSlideType)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNavLink.FieldIndex.colSlideParentId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSlideParentId", IIf(pRowData.colSlideParentId Is Nothing, DBNull.Value, pRowData.colSlideParentId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNavLink.FieldIndex.colSlideOrder) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSlideOrder", IIf(pRowData.colSlideOrder Is Nothing, DBNull.Value, pRowData.colSlideOrder)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNavLink.FieldIndex.colSlideImageClassName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSlideImageClassName", IIf(pRowData.colSlideImageClassName Is Nothing, DBNull.Value, pRowData.colSlideImageClassName)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNavLink.FieldIndex.colIsClientAdmin) Then
                    zCmd.Parameters.Add(New SqlParameter("@colIsClientAdmin", IIf(pRowData.colIsClientAdmin Is Nothing, DBNull.Value, pRowData.colIsClientAdmin)))
                End If

            zCmd.Transaction=pTransaction
            If zMode = "INSERTnoKey" Then
                Dim zLastId As Long = 0
                zLastId = razor.UtilSQLServer.ExecuteNonQueryRowId(zCmd)

                pRowData.colNavLinkId = zLastId
            Else
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)
            End If

            pRowData.SetIsDirty(False)
            pRowData.RaiseSavedEvent(pSavedEventUserState)

		End If

        End Sub

        Public Shared Function LoadByPrimaryKey(pcolNavLinkId As Integer) As rowTblNavLink
            Return LoadByPrimaryKey(pcolNavLinkId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolNavLinkId As Integer, pLoadEventUserState As Object) As rowTblNavLink
            Return LoadByPrimaryKey(pcolNavLinkId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolNavLinkId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblNavLink
            Return LoadByPrimaryKey(pcolNavLinkId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolNavLinkId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblNavLink
            Dim zReturn As New rowTblNavLink
            Dim zSQL As String = "SELECT * FROM [dbo].[NavLink] WHERE [NavLinkId] = @colNavLinkId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colNavLinkId", pcolNavLinkId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblNavLink) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK__NavLink__609318CD(pcolNavLinkId As Integer) As List(Of rowTblNavLink)
            Return LoadByIDX_PK__NavLink__609318CD(pcolNavLinkId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__NavLink__609318CD(pcolNavLinkId As Integer, pLoadEventUserState As Object) As List(Of rowTblNavLink)
            Return LoadByIDX_PK__NavLink__609318CD(pcolNavLinkId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__NavLink__609318CD(pcolNavLinkId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblNavLink)
            Return LoadByIDX_PK__NavLink__609318CD(pcolNavLinkId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__NavLink__609318CD(pcolNavLinkId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblNavLink)
            Dim zReturn As New List(Of rowTblNavLink)
            Dim zSQL As String = "SELECT * FROM [dbo].[NavLink] WHERE [NavLinkId] = @colNavLinkId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colNavLinkId", pcolNavLinkId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblNavLink)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblNavLink)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblNavLink)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblNavLink)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblNavLink)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand)
            Return LoadData(pCommand, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object)
            Return LoadData(pCommand, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction)
            Return LoadData(pCommand,pTransaction,Nothing)
        End Function

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblNavLink)
            Dim zReturn As New List(Of rowTblNavLink)
            Dim zSQL As String = "SELECT * FROM [dbo].[NavLink]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblNavLink)

			Try
	            Dim zReturn As New List(Of rowTblNavLink)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblNavLink

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblNavLink		
	                            ReadDataRow(zReader,zObj)											
	                            zObj.RaiseLoadedEvent(pLoadEventUserState)
	                            zReturn.Add(zObj)
	                        End While
	                    End If
	                End Using
	            End Using

	            zReader.Close()
	            zReader = Nothing

	            Return zReturn

			Catch ex As Exception
				ex.Data.Add("SQL", pCommand.CommandText)				
	            For Each pParameter As SqlClient.SqlParameter In pCommand.Parameters
					ex.Data.Add(pParameter.ParameterName, pParameter.Value)
		        Next
				Throw
			End Try

        End function

        Public Shared Function ReadData(Of T)(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of T)

			Try
	            Dim zReturn As New List(Of T)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As Object = Activator.CreateInstance(Of T)()

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj  = Activator.CreateInstance(Of T)()	
	                            ReadDataRow(zReader,zObj)					
	                            zObj.RaiseLoadedEvent(pLoadEventUserState)
	                            zReturn.Add(zObj)
	                        End While			
	                    End If
	                End Using
	            End Using

	            zReader.Close()
	            zReader = Nothing

	            Return zReturn
			Catch ex As Exception
				ex.Data.Add("SQL", pCommand.CommandText)				
	            For Each pParameter As SqlClient.SqlParameter In pCommand.Parameters
					ex.Data.Add(pParameter.ParameterName, pParameter.Value)
		        Next				
				Throw
			End Try

        End function

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblNavLink)
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavControlId")) Then pObject.colNavControlId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "NavControlId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavPracticeID")) Then pObject.colNavPracticeID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "NavPracticeID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavLevelId")) Then pObject.colNavLevelId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "NavLevelId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavParentLinkId")) Then pObject.colNavParentLinkId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "NavParentLinkId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavLinkId")) Then pObject.colNavLinkId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "NavLinkId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavText")) Then pObject.colNavText = UtilSQLServer.SafeReader.SafeReadString(pReader, "NavText")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavUrl")) Then pObject.colNavUrl = UtilSQLServer.SafeReader.SafeReadString(pReader, "NavUrl")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavOrder")) Then pObject.colNavOrder = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "NavOrder")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavToolTip")) Then pObject.colNavToolTip = UtilSQLServer.SafeReader.SafeReadString(pReader, "NavToolTip")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavVisible")) Then pObject.colNavVisible = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "NavVisible")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavEnabled")) Then pObject.colNavEnabled = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "NavEnabled")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavSpcFeature")) Then pObject.colNavSpcFeature = UtilSQLServer.SafeReader.SafeReadString(pReader, "NavSpcFeature")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavIsPracticeTopLink")) Then pObject.colNavIsPracticeTopLink = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "NavIsPracticeTopLink")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavDefaultExpanded")) Then pObject.colNavDefaultExpanded = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "NavDefaultExpanded")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavSiteMapKeyWord")) Then pObject.colNavSiteMapKeyWord = UtilSQLServer.SafeReader.SafeReadString(pReader, "NavSiteMapKeyWord")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavAllReportsKeyword")) Then pObject.colNavAllReportsKeyword = UtilSQLServer.SafeReader.SafeReadString(pReader, "NavAllReportsKeyword")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavAllDataKeyword")) Then pObject.colNavAllDataKeyword = UtilSQLServer.SafeReader.SafeReadString(pReader, "NavAllDataKeyword")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavTarget")) Then pObject.colNavTarget = UtilSQLServer.SafeReader.SafeReadString(pReader, "NavTarget")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavType")) Then pObject.colNavType = UtilSQLServer.SafeReader.SafeReadString(pReader, "NavType")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavComment")) Then pObject.colNavComment = UtilSQLServer.SafeReader.SafeReadString(pReader, "NavComment")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavConstant")) Then pObject.colNavConstant = UtilSQLServer.SafeReader.SafeReadString(pReader, "NavConstant")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavReportId")) Then pObject.colNavReportId = UtilSQLServer.SafeReader.SafeReadString(pReader, "NavReportId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavGridId")) Then pObject.colNavGridId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "NavGridId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavChartId")) Then pObject.colNavChartId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "NavChartId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavExtractId")) Then pObject.colNavExtractId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "NavExtractId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavBypassFilter")) Then pObject.colNavBypassFilter = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "NavBypassFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavStatusToolTip")) Then pObject.colNavStatusToolTip = UtilSQLServer.SafeReader.SafeReadString(pReader, "NavStatusToolTip")
			If Not pReader.IsDBNull(pReader.GetOrdinal("slideMenuId")) Then pObject.colSlideMenuId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "slideMenuId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("slideGroupId")) Then pObject.colSlideGroupId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "slideGroupId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("slideLevelId")) Then pObject.colSlideLevelId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "slideLevelId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("slideType")) Then pObject.colSlideType = UtilSQLServer.SafeReader.SafeReadString(pReader, "slideType")
			If Not pReader.IsDBNull(pReader.GetOrdinal("slideParentId")) Then pObject.colSlideParentId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "slideParentId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("slideOrder")) Then pObject.colSlideOrder = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "slideOrder")
			If Not pReader.IsDBNull(pReader.GetOrdinal("slideImageClassName")) Then pObject.colSlideImageClassName = UtilSQLServer.SafeReader.SafeReadString(pReader, "slideImageClassName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("IsClientAdmin")) Then pObject.colIsClientAdmin = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "IsClientAdmin")
			pObject.SetIsDirty(False)
			Return pObject
		End	 Function

    #Region "Reflection Based Load Functions"

        Public Shared Function LoadByPrimaryKey(Of T)(pcolNavLinkId As Integer) As T
            Return LoadByPrimaryKey(Of T)(pcolNavLinkId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolNavLinkId As Integer, pLoadEventUserState As Object) As T
            Return LoadByPrimaryKey(Of T)(pcolNavLinkId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolNavLinkId As Integer, pTransaction As SqlClient.SqlTransaction) As T
            Return LoadByPrimaryKey(Of T)(pcolNavLinkId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolNavLinkId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As T

            Dim zReturn As Object = Activator.CreateInstance(Of T)()
            If Not TypeOf zReturn Is rowTblNavLink Then Throw New ArgumentException("Generic type is not type of rowTblNavLink.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[NavLink] WHERE [NavLinkId] = @colNavLinkId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colNavLinkId", pcolNavLinkId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of T) = ReadData(Of T)(zCmd, pLoadEventUserState)
            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

        End Function

        Public Shared Function LoadByIDX_PK__NavLink__609318CD(Of T)(pcolNavLinkId As Integer) As List(Of T)
            Return LoadByIDX_PK__NavLink__609318CD(Of T)(pcolNavLinkId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__NavLink__609318CD(Of T)(pcolNavLinkId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK__NavLink__609318CD(Of T)(pcolNavLinkId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__NavLink__609318CD(Of T)(pcolNavLinkId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK__NavLink__609318CD(Of T)(pcolNavLinkId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK__NavLink__609318CD(Of T)(pcolNavLinkId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[NavLink] WHERE [NavLinkId] = @colNavLinkId"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colNavLinkId", pcolNavLinkId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadData(Of T)(pSQL As String) As List(Of T)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(Of T)(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(Of T)(pSQL As String, pLoadEventUserState As Object) As List(Of T)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(Of T)(zCmd, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(Of T)(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(Of T)(zCmd, pTransaction, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(Of T)() As List(Of T)
            Return LoadData(Of T)(New SqlClient.SqlCommand, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(Of T)(pLoadEventUserState As Object) As List(Of T)
            Return LoadData(Of T)(New SqlClient.SqlCommand, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(Of T)(pCommand As SqlCommand) As List(Of T)
            Return LoadData(Of T)(pCommand, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(Of T)(pCommand As SqlCommand, pLoadEventUserState As Object) As List(Of T)
            Return LoadData(Of T)(pCommand, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(Of T)(pCommand As SqlCommand, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadData(Of T)(pCommand, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(Of T)(pCommand As SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[NavLink]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblNavLink
        Implements IrowTblNavLink

        Public Event Loaded(pUserState As Object) Implements IrowTblNavLink.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblNavLink.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblNavLink.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblNavLink.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblNavLink.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblNavLink.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colNavControlId() As Nullable(Of Integer) Implements IrowTblNavLink.colNavControlId
            Get
                Return m_colNavControlId
            End Get
            Set
                If Not Same(m_colNavControlId, Value) Then
                    m_colNavControlId = Value
                    m_IsDirty(FieldIndex.colNavControlId) = True
                End If
            End Set
        End Property
        Private m_colNavControlId As Nullable(Of Integer)

        Public Property colNavPracticeID() As Nullable(Of Integer) Implements IrowTblNavLink.colNavPracticeID
            Get
                Return m_colNavPracticeID
            End Get
            Set
                If Not Same(m_colNavPracticeID, Value) Then
                    m_colNavPracticeID = Value
                    m_IsDirty(FieldIndex.colNavPracticeID) = True
                End If
            End Set
        End Property
        Private m_colNavPracticeID As Nullable(Of Integer)

        Public Property colNavLevelId() As Nullable(Of Integer) Implements IrowTblNavLink.colNavLevelId
            Get
                Return m_colNavLevelId
            End Get
            Set
                If Not Same(m_colNavLevelId, Value) Then
                    m_colNavLevelId = Value
                    m_IsDirty(FieldIndex.colNavLevelId) = True
                End If
            End Set
        End Property
        Private m_colNavLevelId As Nullable(Of Integer)

        Public Property colNavParentLinkId() As Nullable(Of Integer) Implements IrowTblNavLink.colNavParentLinkId
            Get
                Return m_colNavParentLinkId
            End Get
            Set
                If Not Same(m_colNavParentLinkId, Value) Then
                    m_colNavParentLinkId = Value
                    m_IsDirty(FieldIndex.colNavParentLinkId) = True
                End If
            End Set
        End Property
        Private m_colNavParentLinkId As Nullable(Of Integer)

        Public Property colNavLinkId() As Nullable(Of Integer) Implements IrowTblNavLink.colNavLinkId
            Get
                Return m_colNavLinkId
            End Get
            Set
                If Not Same(m_colNavLinkId, Value) Then
                    m_colNavLinkId = Value
                    m_IsDirty(FieldIndex.colNavLinkId) = True
                End If
            End Set
        End Property
        Private m_colNavLinkId As Nullable(Of Integer)

        Public Property colNavText() As String Implements IrowTblNavLink.colNavText
            Get
                Return m_colNavText
            End Get
            Set
                If Not Same(m_colNavText, Value) Then
                    m_colNavText = Value
                    m_IsDirty(FieldIndex.colNavText) = True
                End If
            End Set
        End Property
        Private m_colNavText As String

        Public Property colNavUrl() As String Implements IrowTblNavLink.colNavUrl
            Get
                Return m_colNavUrl
            End Get
            Set
                If Not Same(m_colNavUrl, Value) Then
                    m_colNavUrl = Value
                    m_IsDirty(FieldIndex.colNavUrl) = True
                End If
            End Set
        End Property
        Private m_colNavUrl As String

        Public Property colNavOrder() As Nullable(Of Integer) Implements IrowTblNavLink.colNavOrder
            Get
                Return m_colNavOrder
            End Get
            Set
                If Not Same(m_colNavOrder, Value) Then
                    m_colNavOrder = Value
                    m_IsDirty(FieldIndex.colNavOrder) = True
                End If
            End Set
        End Property
        Private m_colNavOrder As Nullable(Of Integer)

        Public Property colNavToolTip() As String Implements IrowTblNavLink.colNavToolTip
            Get
                Return m_colNavToolTip
            End Get
            Set
                If Not Same(m_colNavToolTip, Value) Then
                    m_colNavToolTip = Value
                    m_IsDirty(FieldIndex.colNavToolTip) = True
                End If
            End Set
        End Property
        Private m_colNavToolTip As String

        Public Property colNavVisible() As Nullable(Of Boolean) Implements IrowTblNavLink.colNavVisible
            Get
                Return m_colNavVisible
            End Get
            Set
                If Not Same(m_colNavVisible, Value) Then
                    m_colNavVisible = Value
                    m_IsDirty(FieldIndex.colNavVisible) = True
                End If
            End Set
        End Property
        Private m_colNavVisible As Nullable(Of Boolean)

        Public Property colNavEnabled() As Nullable(Of Boolean) Implements IrowTblNavLink.colNavEnabled
            Get
                Return m_colNavEnabled
            End Get
            Set
                If Not Same(m_colNavEnabled, Value) Then
                    m_colNavEnabled = Value
                    m_IsDirty(FieldIndex.colNavEnabled) = True
                End If
            End Set
        End Property
        Private m_colNavEnabled As Nullable(Of Boolean)

        Public Property colNavSpcFeature() As String Implements IrowTblNavLink.colNavSpcFeature
            Get
                Return m_colNavSpcFeature
            End Get
            Set
                If Not Same(m_colNavSpcFeature, Value) Then
                    m_colNavSpcFeature = Value
                    m_IsDirty(FieldIndex.colNavSpcFeature) = True
                End If
            End Set
        End Property
        Private m_colNavSpcFeature As String

        Public Property colNavIsPracticeTopLink() As Nullable(Of Boolean) Implements IrowTblNavLink.colNavIsPracticeTopLink
            Get
                Return m_colNavIsPracticeTopLink
            End Get
            Set
                If Not Same(m_colNavIsPracticeTopLink, Value) Then
                    m_colNavIsPracticeTopLink = Value
                    m_IsDirty(FieldIndex.colNavIsPracticeTopLink) = True
                End If
            End Set
        End Property
        Private m_colNavIsPracticeTopLink As Nullable(Of Boolean)

        Public Property colNavDefaultExpanded() As Nullable(Of Boolean) Implements IrowTblNavLink.colNavDefaultExpanded
            Get
                Return m_colNavDefaultExpanded
            End Get
            Set
                If Not Same(m_colNavDefaultExpanded, Value) Then
                    m_colNavDefaultExpanded = Value
                    m_IsDirty(FieldIndex.colNavDefaultExpanded) = True
                End If
            End Set
        End Property
        Private m_colNavDefaultExpanded As Nullable(Of Boolean)

        Public Property colNavSiteMapKeyWord() As String Implements IrowTblNavLink.colNavSiteMapKeyWord
            Get
                Return m_colNavSiteMapKeyWord
            End Get
            Set
                If Not Same(m_colNavSiteMapKeyWord, Value) Then
                    m_colNavSiteMapKeyWord = Value
                    m_IsDirty(FieldIndex.colNavSiteMapKeyWord) = True
                End If
            End Set
        End Property
        Private m_colNavSiteMapKeyWord As String

        Public Property colNavAllReportsKeyword() As String Implements IrowTblNavLink.colNavAllReportsKeyword
            Get
                Return m_colNavAllReportsKeyword
            End Get
            Set
                If Not Same(m_colNavAllReportsKeyword, Value) Then
                    m_colNavAllReportsKeyword = Value
                    m_IsDirty(FieldIndex.colNavAllReportsKeyword) = True
                End If
            End Set
        End Property
        Private m_colNavAllReportsKeyword As String

        Public Property colNavAllDataKeyword() As String Implements IrowTblNavLink.colNavAllDataKeyword
            Get
                Return m_colNavAllDataKeyword
            End Get
            Set
                If Not Same(m_colNavAllDataKeyword, Value) Then
                    m_colNavAllDataKeyword = Value
                    m_IsDirty(FieldIndex.colNavAllDataKeyword) = True
                End If
            End Set
        End Property
        Private m_colNavAllDataKeyword As String

        Public Property colNavTarget() As String Implements IrowTblNavLink.colNavTarget
            Get
                Return m_colNavTarget
            End Get
            Set
                If Not Same(m_colNavTarget, Value) Then
                    m_colNavTarget = Value
                    m_IsDirty(FieldIndex.colNavTarget) = True
                End If
            End Set
        End Property
        Private m_colNavTarget As String

        Public Property colNavType() As String Implements IrowTblNavLink.colNavType
            Get
                Return m_colNavType
            End Get
            Set
                If Not Same(m_colNavType, Value) Then
                    m_colNavType = Value
                    m_IsDirty(FieldIndex.colNavType) = True
                End If
            End Set
        End Property
        Private m_colNavType As String

        Public Property colNavComment() As String Implements IrowTblNavLink.colNavComment
            Get
                Return m_colNavComment
            End Get
            Set
                If Not Same(m_colNavComment, Value) Then
                    m_colNavComment = Value
                    m_IsDirty(FieldIndex.colNavComment) = True
                End If
            End Set
        End Property
        Private m_colNavComment As String

        Public Property colNavConstant() As String Implements IrowTblNavLink.colNavConstant
            Get
                Return m_colNavConstant
            End Get
            Set
                If Not Same(m_colNavConstant, Value) Then
                    m_colNavConstant = Value
                    m_IsDirty(FieldIndex.colNavConstant) = True
                End If
            End Set
        End Property
        Private m_colNavConstant As String

        Public Property colNavReportId() As String Implements IrowTblNavLink.colNavReportId
            Get
                Return m_colNavReportId
            End Get
            Set
                If Not Same(m_colNavReportId, Value) Then
                    m_colNavReportId = Value
                    m_IsDirty(FieldIndex.colNavReportId) = True
                End If
            End Set
        End Property
        Private m_colNavReportId As String

        Public Property colNavGridId() As Nullable(Of Integer) Implements IrowTblNavLink.colNavGridId
            Get
                Return m_colNavGridId
            End Get
            Set
                If Not Same(m_colNavGridId, Value) Then
                    m_colNavGridId = Value
                    m_IsDirty(FieldIndex.colNavGridId) = True
                End If
            End Set
        End Property
        Private m_colNavGridId As Nullable(Of Integer)

        Public Property colNavChartId() As Nullable(Of Integer) Implements IrowTblNavLink.colNavChartId
            Get
                Return m_colNavChartId
            End Get
            Set
                If Not Same(m_colNavChartId, Value) Then
                    m_colNavChartId = Value
                    m_IsDirty(FieldIndex.colNavChartId) = True
                End If
            End Set
        End Property
        Private m_colNavChartId As Nullable(Of Integer)

        Public Property colNavExtractId() As Nullable(Of Integer) Implements IrowTblNavLink.colNavExtractId
            Get
                Return m_colNavExtractId
            End Get
            Set
                If Not Same(m_colNavExtractId, Value) Then
                    m_colNavExtractId = Value
                    m_IsDirty(FieldIndex.colNavExtractId) = True
                End If
            End Set
        End Property
        Private m_colNavExtractId As Nullable(Of Integer)

        Public Property colNavBypassFilter() As Nullable(Of Boolean) Implements IrowTblNavLink.colNavBypassFilter
            Get
                Return m_colNavBypassFilter
            End Get
            Set
                If Not Same(m_colNavBypassFilter, Value) Then
                    m_colNavBypassFilter = Value
                    m_IsDirty(FieldIndex.colNavBypassFilter) = True
                End If
            End Set
        End Property
        Private m_colNavBypassFilter As Nullable(Of Boolean)

        Public Property colNavStatusToolTip() As String Implements IrowTblNavLink.colNavStatusToolTip
            Get
                Return m_colNavStatusToolTip
            End Get
            Set
                If Not Same(m_colNavStatusToolTip, Value) Then
                    m_colNavStatusToolTip = Value
                    m_IsDirty(FieldIndex.colNavStatusToolTip) = True
                End If
            End Set
        End Property
        Private m_colNavStatusToolTip As String

        Public Property colSlideMenuId() As Nullable(Of Integer) Implements IrowTblNavLink.colSlideMenuId
            Get
                Return m_colSlideMenuId
            End Get
            Set
                If Not Same(m_colSlideMenuId, Value) Then
                    m_colSlideMenuId = Value
                    m_IsDirty(FieldIndex.colSlideMenuId) = True
                End If
            End Set
        End Property
        Private m_colSlideMenuId As Nullable(Of Integer)

        Public Property colSlideGroupId() As Nullable(Of Integer) Implements IrowTblNavLink.colSlideGroupId
            Get
                Return m_colSlideGroupId
            End Get
            Set
                If Not Same(m_colSlideGroupId, Value) Then
                    m_colSlideGroupId = Value
                    m_IsDirty(FieldIndex.colSlideGroupId) = True
                End If
            End Set
        End Property
        Private m_colSlideGroupId As Nullable(Of Integer)

        Public Property colSlideLevelId() As Nullable(Of Integer) Implements IrowTblNavLink.colSlideLevelId
            Get
                Return m_colSlideLevelId
            End Get
            Set
                If Not Same(m_colSlideLevelId, Value) Then
                    m_colSlideLevelId = Value
                    m_IsDirty(FieldIndex.colSlideLevelId) = True
                End If
            End Set
        End Property
        Private m_colSlideLevelId As Nullable(Of Integer)

        Public Property colSlideType() As String Implements IrowTblNavLink.colSlideType
            Get
                Return m_colSlideType
            End Get
            Set
                If Not Same(m_colSlideType, Value) Then
                    m_colSlideType = Value
                    m_IsDirty(FieldIndex.colSlideType) = True
                End If
            End Set
        End Property
        Private m_colSlideType As String

        Public Property colSlideParentId() As Nullable(Of Integer) Implements IrowTblNavLink.colSlideParentId
            Get
                Return m_colSlideParentId
            End Get
            Set
                If Not Same(m_colSlideParentId, Value) Then
                    m_colSlideParentId = Value
                    m_IsDirty(FieldIndex.colSlideParentId) = True
                End If
            End Set
        End Property
        Private m_colSlideParentId As Nullable(Of Integer)

        Public Property colSlideOrder() As Nullable(Of Integer) Implements IrowTblNavLink.colSlideOrder
            Get
                Return m_colSlideOrder
            End Get
            Set
                If Not Same(m_colSlideOrder, Value) Then
                    m_colSlideOrder = Value
                    m_IsDirty(FieldIndex.colSlideOrder) = True
                End If
            End Set
        End Property
        Private m_colSlideOrder As Nullable(Of Integer)

        Public Property colSlideImageClassName() As String Implements IrowTblNavLink.colSlideImageClassName
            Get
                Return m_colSlideImageClassName
            End Get
            Set
                If Not Same(m_colSlideImageClassName, Value) Then
                    m_colSlideImageClassName = Value
                    m_IsDirty(FieldIndex.colSlideImageClassName) = True
                End If
            End Set
        End Property
        Private m_colSlideImageClassName As String

        Public Property colIsClientAdmin() As Nullable(Of Boolean) Implements IrowTblNavLink.colIsClientAdmin
            Get
                Return m_colIsClientAdmin
            End Get
            Set
                If Not Same(m_colIsClientAdmin, Value) Then
                    m_colIsClientAdmin = Value
                    m_IsDirty(FieldIndex.colIsClientAdmin) = True
                End If
            End Set
        End Property
        Private m_colIsClientAdmin As Nullable(Of Boolean)


        Public Function IsDirty(pIndex As rowTblNavLink.FieldIndex) As Boolean Implements IrowTblNavLink.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblNavLink.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblNavLink.SetIsDirty
            m_IsDirty(FieldIndex.colNavControlId) = pDirty
            m_IsDirty(FieldIndex.colNavPracticeID) = pDirty
            m_IsDirty(FieldIndex.colNavLevelId) = pDirty
            m_IsDirty(FieldIndex.colNavParentLinkId) = pDirty
            m_IsDirty(FieldIndex.colNavLinkId) = pDirty
            m_IsDirty(FieldIndex.colNavText) = pDirty
            m_IsDirty(FieldIndex.colNavUrl) = pDirty
            m_IsDirty(FieldIndex.colNavOrder) = pDirty
            m_IsDirty(FieldIndex.colNavToolTip) = pDirty
            m_IsDirty(FieldIndex.colNavVisible) = pDirty
            m_IsDirty(FieldIndex.colNavEnabled) = pDirty
            m_IsDirty(FieldIndex.colNavSpcFeature) = pDirty
            m_IsDirty(FieldIndex.colNavIsPracticeTopLink) = pDirty
            m_IsDirty(FieldIndex.colNavDefaultExpanded) = pDirty
            m_IsDirty(FieldIndex.colNavSiteMapKeyWord) = pDirty
            m_IsDirty(FieldIndex.colNavAllReportsKeyword) = pDirty
            m_IsDirty(FieldIndex.colNavAllDataKeyword) = pDirty
            m_IsDirty(FieldIndex.colNavTarget) = pDirty
            m_IsDirty(FieldIndex.colNavType) = pDirty
            m_IsDirty(FieldIndex.colNavComment) = pDirty
            m_IsDirty(FieldIndex.colNavConstant) = pDirty
            m_IsDirty(FieldIndex.colNavReportId) = pDirty
            m_IsDirty(FieldIndex.colNavGridId) = pDirty
            m_IsDirty(FieldIndex.colNavChartId) = pDirty
            m_IsDirty(FieldIndex.colNavExtractId) = pDirty
            m_IsDirty(FieldIndex.colNavBypassFilter) = pDirty
            m_IsDirty(FieldIndex.colNavStatusToolTip) = pDirty
            m_IsDirty(FieldIndex.colSlideMenuId) = pDirty
            m_IsDirty(FieldIndex.colSlideGroupId) = pDirty
            m_IsDirty(FieldIndex.colSlideLevelId) = pDirty
            m_IsDirty(FieldIndex.colSlideType) = pDirty
            m_IsDirty(FieldIndex.colSlideParentId) = pDirty
            m_IsDirty(FieldIndex.colSlideOrder) = pDirty
            m_IsDirty(FieldIndex.colSlideImageClassName) = pDirty
            m_IsDirty(FieldIndex.colIsClientAdmin) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblNavLink) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblNavLink
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colNavControlId  = 1
            colNavPracticeID 
            colNavLevelId 
            colNavParentLinkId 
            colNavLinkId 
            colNavText 
            colNavUrl 
            colNavOrder 
            colNavToolTip 
            colNavVisible 
            colNavEnabled 
            colNavSpcFeature 
            colNavIsPracticeTopLink 
            colNavDefaultExpanded 
            colNavSiteMapKeyWord 
            colNavAllReportsKeyword 
            colNavAllDataKeyword 
            colNavTarget 
            colNavType 
            colNavComment 
            colNavConstant 
            colNavReportId 
            colNavGridId 
            colNavChartId 
            colNavExtractId 
            colNavBypassFilter 
            colNavStatusToolTip 
            colSlideMenuId 
            colSlideGroupId 
            colSlideLevelId 
            colSlideType 
            colSlideParentId 
            colSlideOrder 
            colSlideImageClassName 
            colIsClientAdmin 
        End Enum

        Private m_IsDirty(36) As Boolean

        Private Function [Same](pValue1 As Object, pValue2 As Object) As Boolean
            If pValue1 Is Nothing And (Not pValue2 Is Nothing) Then
                Return False
            End If

            If (Not pValue1 Is Nothing) And pValue2 Is Nothing Then
                Return False
            End If

            If pValue1 <> pValue2 Then
                Return False
            End If

            Return True
        End Function

    End Class

    Public Interface IrowTblNavLink
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colNavControlId() As Nullable(Of Integer)
        Property colNavPracticeID() As Nullable(Of Integer)
        Property colNavLevelId() As Nullable(Of Integer)
        Property colNavParentLinkId() As Nullable(Of Integer)
        Property colNavLinkId() As Nullable(Of Integer)
        Property colNavText() As String
        Property colNavUrl() As String
        Property colNavOrder() As Nullable(Of Integer)
        Property colNavToolTip() As String
        Property colNavVisible() As Nullable(Of Boolean)
        Property colNavEnabled() As Nullable(Of Boolean)
        Property colNavSpcFeature() As String
        Property colNavIsPracticeTopLink() As Nullable(Of Boolean)
        Property colNavDefaultExpanded() As Nullable(Of Boolean)
        Property colNavSiteMapKeyWord() As String
        Property colNavAllReportsKeyword() As String
        Property colNavAllDataKeyword() As String
        Property colNavTarget() As String
        Property colNavType() As String
        Property colNavComment() As String
        Property colNavConstant() As String
        Property colNavReportId() As String
        Property colNavGridId() As Nullable(Of Integer)
        Property colNavChartId() As Nullable(Of Integer)
        Property colNavExtractId() As Nullable(Of Integer)
        Property colNavBypassFilter() As Nullable(Of Boolean)
        Property colNavStatusToolTip() As String
        Property colSlideMenuId() As Nullable(Of Integer)
        Property colSlideGroupId() As Nullable(Of Integer)
        Property colSlideLevelId() As Nullable(Of Integer)
        Property colSlideType() As String
        Property colSlideParentId() As Nullable(Of Integer)
        Property colSlideOrder() As Nullable(Of Integer)
        Property colSlideImageClassName() As String
        Property colIsClientAdmin() As Nullable(Of Boolean)
        Function IsDirty(pIndex As rowTblNavLink.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

