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
    Partial Public Class TblWhatIfLocation

        Public Shared Sub Delete(ByRef pRowData As IrowTblWhatIfLocation)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblWhatIfLocation, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblWhatIfLocation, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblWhatIfLocation, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldGSafeId) And razor.UtilSQLServer.IsKeySet(pRowData.colFldFileNo) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[TblWhatIfLocation] " & _
                        "WHERE [fldGSafeId] = @colFldGSafeId AND [fldFileNo] = @colFldFileNo"

                Dim zCmd As New SQLCommand
                zCmd.CommandText = zSQL
                zCmd.Parameters.Add(New SQLParameter("@colFldGSafeId", pRowData.colFldGSafeId))
                zCmd.Parameters.Add(New SQLParameter("@colFldFileNo", pRowData.colFldFileNo))

                zCmd.Transaction=pTransaction
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)

                pRowData.RaiseDeletedEvent(pDeleteEventUserState)

            End If

        End Sub

        Public Shared Sub Delete(pcolFldGSafeId As Integer, pcolFldFileNo As String)
            Delete(pcolFldGSafeId, pcolFldFileNo, Nothing, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolFldGSafeId As Integer, pcolFldFileNo As String, pDeleteEventUserState As Object)
            Delete(pcolFldGSafeId, pcolFldFileNo, Nothing, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Delete(pcolFldGSafeId As Integer, pcolFldFileNo As String, ByRef pTransaction As SqlClient.SqlTransaction)
        Delete(pcolFldGSafeId, pcolFldFileNo, pTransaction, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolFldGSafeId As Integer, pcolFldFileNo As String, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
        Dim zObj As rowTblWhatIfLocation = LoadByPrimaryKey(pcolFldGSafeId, pcolFldFileNo, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblWhatIfLocation)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblWhatIfLocation, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblWhatIfLocation, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldGSafeId) And razor.UtilSQLServer.IsKeySet(pRowData.colFldFileNo) Then

                zSQL = "SELECT COUNT(*) from [dbo].[TblWhatIfLocation] WHERE [fldGSafeId] = @colFldGSafeId AND [fldFileNo] = @colFldFileNo"

                Dim zCmdDoesExist As New SQLCommand

                zCmdDoesExist.CommandText = zSQL

                zCmdDoesExist.Parameters.Add(new SQLParameter("@colFldGSafeId", pRowData.colFldGSafeId))
                zCmdDoesExist.Parameters.Add(new SQLParameter("@colFldFileNo", pRowData.colFldFileNo))

                'if zExistInDB > 0  then  PK exists in the DB
                zCmdDoesExist.Transaction = pTransaction
                zExistInDB = razor.UtilSQLServer.ExecuteScalar(zCmdDoesExist)
            End If

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldGSafeId) And razor.UtilSQLServer.IsKeySet(pRowData.colFldFileNo) And zExistInDB > 0 Then
                zMode = "UPDATE"
            End If
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldGSafeId) And razor.UtilSQLServer.IsKeySet(pRowData.colFldFileNo) And zExistInDB = 0 Then
                zMode = "INSERTwithKey"
            End If
            If Not razor.UtilSQLServer.IsKeySet(pRowData.colFldGSafeId) Or Not razor.UtilSQLServer.IsKeySet(pRowData.colFldFileNo) Then
                zMode = "INSERTnoKey"
            End If

            Select Case zMode
                Case "UPDATE"
                    If pRowData.IsDirty Then
                        Dim zUpdate As String = ""
                        Dim zSet As String = ""
                        Dim zWhere As String = ""
                        zUpdate = "UPDATE [dbo].[TblWhatIfLocation] SET " 
                        If pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldDivision) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldDivision] = @colFldDivision "
                        End If
                        If pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldCustomAccess) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldCustomAccess] = @colFldCustomAccess "
                        End If
                        If pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldClientLocID) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldClientLocID] = @colFldClientLocID "
                        End If
                        If pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldAddressStamp) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldAddressStamp] = @colFldAddressStamp "
                        End If
                        If pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldFilePrefix) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldFilePrefix] = @colFldFilePrefix "
                        End If
                        If pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldTivUSD) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldTivUSD] = @colFldTivUSD "
                        End If
                        If pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldTotalScore) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldTotalScore] = @colFldTotalScore "
                        End If
                        If pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldTotalScoreRecsComplete) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldTotalScoreRecsComplete] = @colFldTotalScoreRecsComplete "
                        End If
                        If pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldTotalScoreAchievedPercent) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldTotalScoreAchievedPercent] = @colFldTotalScoreAchievedPercent "
                        End If
                        If pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldPhysicalProtRating) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldPhysicalProtRating] = @colFldPhysicalProtRating "
                        End If
                        If pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldPhysicalProtWeight) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldPhysicalProtWeight] = @colFldPhysicalProtWeight "
                        End If
                        If pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldHeRating) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldHeRating] = @colFldHeRating "
                        End If
                        If pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldHeWeight) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldHeWeight] = @colFldHeWeight "
                        End If
                        If pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldNatHazRating) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldNatHazRating] = @colFldNatHazRating "
                        End If
                        If pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldNatHazWeight) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldNatHazWeight] = @colFldNatHazWeight "
                        End If
                        If pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldBcpRating) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldBcpRating] = @colFldBcpRating "
                        End If
                        If pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldBcpWeight) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldBcpWeight] = @colFldBcpWeight "
                        End If
                        If pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldHasRatingData) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldHasRatingData] = @colFldHasRatingData "
                        End If
                        If pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldCreateDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldCreateDate] = @colFldCreateDate "
                        End If
                        If pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldFacility) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldFacility] = @colFldFacility "
                        End If
                        zWhere = " WHERE [fldGSafeId] = @colFldGSafeId AND [fldFileNo] = @colFldFileNo"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[TblWhatIfLocation] ([fldGSafeId], [fldFileNo], [fldDivision], [fldCustomAccess], [fldClientLocID], [fldAddressStamp], [fldFilePrefix], [fldTivUSD], [fldTotalScore], [fldTotalScoreRecsComplete], [fldTotalScoreAchievedPercent], [fldPhysicalProtRating], [fldPhysicalProtWeight], [fldHeRating], [fldHeWeight], [fldNatHazRating], [fldNatHazWeight], [fldBcpRating], [fldBcpWeight], [fldHasRatingData], [fldCreateDate], [fldFacility])" & _
                            " VALUES (@colFldGSafeId, @colFldFileNo, @colFldDivision, @colFldCustomAccess, @colFldClientLocID, @colFldAddressStamp, @colFldFilePrefix, @colFldTivUSD, @colFldTotalScore, @colFldTotalScoreRecsComplete, @colFldTotalScoreAchievedPercent, @colFldPhysicalProtRating, @colFldPhysicalProtWeight, @colFldHeRating, @colFldHeWeight, @colFldNatHazRating, @colFldNatHazWeight, @colFldBcpRating, @colFldBcpWeight, @colFldHasRatingData, @colFldCreateDate, @colFldFacility); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[TblWhatIfLocation] ([fldDivision], [fldCustomAccess], [fldClientLocID], [fldAddressStamp], [fldFilePrefix], [fldTivUSD], [fldTotalScore], [fldTotalScoreRecsComplete], [fldTotalScoreAchievedPercent], [fldPhysicalProtRating], [fldPhysicalProtWeight], [fldHeRating], [fldHeWeight], [fldNatHazRating], [fldNatHazWeight], [fldBcpRating], [fldBcpWeight], [fldHasRatingData], [fldCreateDate], [fldFacility])" & _
                            " VALUES (@colFldDivision, @colFldCustomAccess, @colFldClientLocID, @colFldAddressStamp, @colFldFilePrefix, @colFldTivUSD, @colFldTotalScore, @colFldTotalScoreRecsComplete, @colFldTotalScoreAchievedPercent, @colFldPhysicalProtRating, @colFldPhysicalProtWeight, @colFldHeRating, @colFldHeWeight, @colFldNatHazRating, @colFldNatHazWeight, @colFldBcpRating, @colFldBcpWeight, @colFldHasRatingData, @colFldCreateDate, @colFldFacility); SELECT SCOPE_IDENTITY()"
                Case Else
            End Select

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

			'IF UPDATE, SET PK PARAMETER
            If zMode = "UPDATE" Then
                zCmd.Parameters.Add(New SQLParameter("@colFldGSafeId", pRowData.colFldGSafeId))
                zCmd.Parameters.Add(New SQLParameter("@colFldFileNo", pRowData.colFldFileNo))
            End If

			'IF INSERTING, KEY HAS VALUE AND KEY IS NOT IDENTITY, SET PK PARAMETER
			If zMode = "INSERTwithKey" Then
                zCmd.Parameters.Add(New SQLParameter("@colFldGSafeId", pRowData.colFldGSafeId))
                zCmd.Parameters.Add(New SQLParameter("@colFldFileNo", pRowData.colFldFileNo))
            End If

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldDivision) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldDivision", IIf(pRowData.colFldDivision Is Nothing, DBNull.Value, pRowData.colFldDivision)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldCustomAccess) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldCustomAccess", IIf(pRowData.colFldCustomAccess Is Nothing, DBNull.Value, pRowData.colFldCustomAccess)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldClientLocID) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldClientLocID", IIf(pRowData.colFldClientLocID Is Nothing, DBNull.Value, pRowData.colFldClientLocID)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldAddressStamp) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldAddressStamp", IIf(pRowData.colFldAddressStamp Is Nothing, DBNull.Value, pRowData.colFldAddressStamp)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldFilePrefix) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldFilePrefix", IIf(pRowData.colFldFilePrefix Is Nothing, DBNull.Value, pRowData.colFldFilePrefix)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldTivUSD) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldTivUSD", IIf(pRowData.colFldTivUSD Is Nothing, DBNull.Value, pRowData.colFldTivUSD)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldTotalScore) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldTotalScore", IIf(pRowData.colFldTotalScore Is Nothing, DBNull.Value, pRowData.colFldTotalScore)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldTotalScoreRecsComplete) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldTotalScoreRecsComplete", IIf(pRowData.colFldTotalScoreRecsComplete Is Nothing, DBNull.Value, pRowData.colFldTotalScoreRecsComplete)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldTotalScoreAchievedPercent) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldTotalScoreAchievedPercent", IIf(pRowData.colFldTotalScoreAchievedPercent Is Nothing, DBNull.Value, pRowData.colFldTotalScoreAchievedPercent)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldPhysicalProtRating) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldPhysicalProtRating", IIf(pRowData.colFldPhysicalProtRating Is Nothing, DBNull.Value, pRowData.colFldPhysicalProtRating)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldPhysicalProtWeight) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldPhysicalProtWeight", IIf(pRowData.colFldPhysicalProtWeight Is Nothing, DBNull.Value, pRowData.colFldPhysicalProtWeight)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldHeRating) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldHeRating", IIf(pRowData.colFldHeRating Is Nothing, DBNull.Value, pRowData.colFldHeRating)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldHeWeight) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldHeWeight", IIf(pRowData.colFldHeWeight Is Nothing, DBNull.Value, pRowData.colFldHeWeight)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldNatHazRating) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldNatHazRating", IIf(pRowData.colFldNatHazRating Is Nothing, DBNull.Value, pRowData.colFldNatHazRating)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldNatHazWeight) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldNatHazWeight", IIf(pRowData.colFldNatHazWeight Is Nothing, DBNull.Value, pRowData.colFldNatHazWeight)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldBcpRating) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldBcpRating", IIf(pRowData.colFldBcpRating Is Nothing, DBNull.Value, pRowData.colFldBcpRating)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldBcpWeight) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldBcpWeight", IIf(pRowData.colFldBcpWeight Is Nothing, DBNull.Value, pRowData.colFldBcpWeight)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldHasRatingData) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldHasRatingData", IIf(pRowData.colFldHasRatingData Is Nothing, DBNull.Value, pRowData.colFldHasRatingData)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldCreateDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldCreateDate", IIf(pRowData.colFldCreateDate Is Nothing, DBNull.Value, pRowData.colFldCreateDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatIfLocation.FieldIndex.colFldFacility) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldFacility", IIf(pRowData.colFldFacility Is Nothing, DBNull.Value, pRowData.colFldFacility)))
                End If

            zCmd.Transaction=pTransaction
            If zMode = "INSERTnoKey" Then
                Dim zLastId As Long = 0
                zLastId = razor.UtilSQLServer.ExecuteNonQueryRowId(zCmd)

                pRowData.colFldGSafeId = zLastId
                pRowData.colFldFileNo = zLastId
            Else
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)
            End If

            pRowData.SetIsDirty(False)
            pRowData.RaiseSavedEvent(pSavedEventUserState)

		End If

        End Sub

        Public Shared Function LoadByPrimaryKey(pcolFldGSafeId As Integer, pcolFldFileNo As String) As rowTblWhatIfLocation
            Return LoadByPrimaryKey(pcolFldGSafeId, pcolFldFileNo, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldGSafeId As Integer, pcolFldFileNo As String, pLoadEventUserState As Object) As rowTblWhatIfLocation
            Return LoadByPrimaryKey(pcolFldGSafeId, pcolFldFileNo, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldGSafeId As Integer, pcolFldFileNo As String, pTransaction As SqlClient.SqlTransaction) As rowTblWhatIfLocation
            Return LoadByPrimaryKey(pcolFldGSafeId, pcolFldFileNo, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldGSafeId As Integer, pcolFldFileNo As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblWhatIfLocation
            Dim zReturn As New rowTblWhatIfLocation
            Dim zSQL As String = "SELECT * FROM [dbo].[TblWhatIfLocation] WHERE [fldGSafeId] = @colFldGSafeId AND [fldFileNo] = @colFldFileNo"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldGSafeId", pcolFldGSafeId))
            zCmd.Parameters.Add(New SQLParameter("@colFldFileNo", pcolFldFileNo))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblWhatIfLocation) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK_tblWhatIfLocation(pcolFldGSafeId As Integer, pcolFldFileNo As String) As List(Of rowTblWhatIfLocation)
            Return LoadByIDX_PK_tblWhatIfLocation(pcolFldGSafeId, pcolFldFileNo, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblWhatIfLocation(pcolFldGSafeId As Integer, pcolFldFileNo As String, pLoadEventUserState As Object) As List(Of rowTblWhatIfLocation)
            Return LoadByIDX_PK_tblWhatIfLocation(pcolFldGSafeId, pcolFldFileNo, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_tblWhatIfLocation(pcolFldGSafeId As Integer, pcolFldFileNo As String, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblWhatIfLocation)
            Return LoadByIDX_PK_tblWhatIfLocation(pcolFldGSafeId, pcolFldFileNo, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblWhatIfLocation(pcolFldGSafeId As Integer, pcolFldFileNo As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblWhatIfLocation)
            Dim zReturn As New List(Of rowTblWhatIfLocation)
            Dim zSQL As String = "SELECT * FROM [dbo].[TblWhatIfLocation] WHERE [fldGSafeId] = @colFldGSafeId AND [fldFileNo] = @colFldFileNo"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldGSafeId", pcolFldGSafeId))
            zCmd.Parameters.Add(New SQLParameter("@colFldFileNo", pcolFldFileNo))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblWhatIfLocation)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblWhatIfLocation)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblWhatIfLocation)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblWhatIfLocation)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblWhatIfLocation)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblWhatIfLocation)
            Dim zReturn As New List(Of rowTblWhatIfLocation)
            Dim zSQL As String = "SELECT * FROM [dbo].[TblWhatIfLocation]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblWhatIfLocation)

			Try
	            Dim zReturn As New List(Of rowTblWhatIfLocation)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblWhatIfLocation

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblWhatIfLocation		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblWhatIfLocation)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldGSafeId")) Then pObject.colFldGSafeId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldGSafeId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFileNo")) Then pObject.colFldFileNo = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldFileNo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldDivision")) Then pObject.colFldDivision = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldDivision")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldCustomAccess")) Then pObject.colFldCustomAccess = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldCustomAccess")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldClientLocID")) Then pObject.colFldClientLocID = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldClientLocID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldAddressStamp")) Then pObject.colFldAddressStamp = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldAddressStamp")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFilePrefix")) Then pObject.colFldFilePrefix = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldFilePrefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldTivUSD")) Then pObject.colFldTivUSD = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "fldTivUSD")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldTotalScore")) Then pObject.colFldTotalScore = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "fldTotalScore")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldTotalScoreRecsComplete")) Then pObject.colFldTotalScoreRecsComplete = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "fldTotalScoreRecsComplete")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldTotalScoreAchievedPercent")) Then pObject.colFldTotalScoreAchievedPercent = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "fldTotalScoreAchievedPercent")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldPhysicalProtRating")) Then pObject.colFldPhysicalProtRating = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "fldPhysicalProtRating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldPhysicalProtWeight")) Then pObject.colFldPhysicalProtWeight = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "fldPhysicalProtWeight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldHeRating")) Then pObject.colFldHeRating = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "fldHeRating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldHeWeight")) Then pObject.colFldHeWeight = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "fldHeWeight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldNatHazRating")) Then pObject.colFldNatHazRating = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "fldNatHazRating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldNatHazWeight")) Then pObject.colFldNatHazWeight = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "fldNatHazWeight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldBcpRating")) Then pObject.colFldBcpRating = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "fldBcpRating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldBcpWeight")) Then pObject.colFldBcpWeight = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "fldBcpWeight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldHasRatingData")) Then pObject.colFldHasRatingData = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldHasRatingData")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldCreateDate")) Then pObject.colFldCreateDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "fldCreateDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFacility")) Then pObject.colFldFacility = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldFacility")
			pObject.SetIsDirty(False)
			Return pObject
		End	 Function

    #Region "Reflection Based Load Functions"

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldGSafeId As Integer, pcolFldFileNo As String) As T
            Return LoadByPrimaryKey(Of T)(pcolFldGSafeId, pcolFldFileNo, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldGSafeId As Integer, pcolFldFileNo As String, pLoadEventUserState As Object) As T
            Return LoadByPrimaryKey(Of T)(pcolFldGSafeId, pcolFldFileNo, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldGSafeId As Integer, pcolFldFileNo As String, pTransaction As SqlClient.SqlTransaction) As T
            Return LoadByPrimaryKey(Of T)(pcolFldGSafeId, pcolFldFileNo, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldGSafeId As Integer, pcolFldFileNo As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As T

            Dim zReturn As Object = Activator.CreateInstance(Of T)()
            If Not TypeOf zReturn Is rowTblWhatIfLocation Then Throw New ArgumentException("Generic type is not type of rowTblWhatIfLocation.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[TblWhatIfLocation] WHERE [fldGSafeId] = @colFldGSafeId AND [fldFileNo] = @colFldFileNo"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldGSafeId", pcolFldGSafeId))
            zCmd.Parameters.Add(New SQLParameter("@colFldFileNo", pcolFldFileNo))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of T) = ReadData(Of T)(zCmd, pLoadEventUserState)
            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

        End Function

        Public Shared Function LoadByIDX_PK_tblWhatIfLocation(Of T)(pcolFldGSafeId As Integer, pcolFldFileNo As String) As List(Of T)
            Return LoadByIDX_PK_tblWhatIfLocation(Of T)(pcolFldGSafeId, pcolFldFileNo, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblWhatIfLocation(Of T)(pcolFldGSafeId As Integer, pcolFldFileNo As String, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK_tblWhatIfLocation(Of T)(pcolFldGSafeId, pcolFldFileNo, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_tblWhatIfLocation(Of T)(pcolFldGSafeId As Integer, pcolFldFileNo As String, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK_tblWhatIfLocation(Of T)(pcolFldGSafeId, pcolFldFileNo, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK_tblWhatIfLocation(Of T)(pcolFldGSafeId As Integer, pcolFldFileNo As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[TblWhatIfLocation] WHERE [fldGSafeId] = @colFldGSafeId AND [fldFileNo] = @colFldFileNo"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldGSafeId", pcolFldGSafeId))
            zCmd.Parameters.Add(New SQLParameter("@colFldFileNo", pcolFldFileNo))

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
            Dim zSQL As String = "SELECT * FROM [dbo].[TblWhatIfLocation]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblWhatIfLocation
        Implements IrowTblWhatIfLocation

        Public Event Loaded(pUserState As Object) Implements IrowTblWhatIfLocation.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblWhatIfLocation.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblWhatIfLocation.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblWhatIfLocation.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblWhatIfLocation.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblWhatIfLocation.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldGSafeId() As Nullable(Of Integer) Implements IrowTblWhatIfLocation.colFldGSafeId
            Get
                Return m_colFldGSafeId
            End Get
            Set
                If Not Same(m_colFldGSafeId, Value) Then
                    m_colFldGSafeId = Value
                    m_IsDirty(FieldIndex.colFldGSafeId) = True
                End If
            End Set
        End Property
        Private m_colFldGSafeId As Nullable(Of Integer)

        Public Property colFldFileNo() As String Implements IrowTblWhatIfLocation.colFldFileNo
            Get
                Return m_colFldFileNo
            End Get
            Set
                If Not Same(m_colFldFileNo, Value) Then
                    m_colFldFileNo = Value
                    m_IsDirty(FieldIndex.colFldFileNo) = True
                End If
            End Set
        End Property
        Private m_colFldFileNo As String

        Public Property colFldDivision() As String Implements IrowTblWhatIfLocation.colFldDivision
            Get
                Return m_colFldDivision
            End Get
            Set
                If Not Same(m_colFldDivision, Value) Then
                    m_colFldDivision = Value
                    m_IsDirty(FieldIndex.colFldDivision) = True
                End If
            End Set
        End Property
        Private m_colFldDivision As String

        Public Property colFldCustomAccess() As String Implements IrowTblWhatIfLocation.colFldCustomAccess
            Get
                Return m_colFldCustomAccess
            End Get
            Set
                If Not Same(m_colFldCustomAccess, Value) Then
                    m_colFldCustomAccess = Value
                    m_IsDirty(FieldIndex.colFldCustomAccess) = True
                End If
            End Set
        End Property
        Private m_colFldCustomAccess As String

        Public Property colFldClientLocID() As String Implements IrowTblWhatIfLocation.colFldClientLocID
            Get
                Return m_colFldClientLocID
            End Get
            Set
                If Not Same(m_colFldClientLocID, Value) Then
                    m_colFldClientLocID = Value
                    m_IsDirty(FieldIndex.colFldClientLocID) = True
                End If
            End Set
        End Property
        Private m_colFldClientLocID As String

        Public Property colFldAddressStamp() As String Implements IrowTblWhatIfLocation.colFldAddressStamp
            Get
                Return m_colFldAddressStamp
            End Get
            Set
                If Not Same(m_colFldAddressStamp, Value) Then
                    m_colFldAddressStamp = Value
                    m_IsDirty(FieldIndex.colFldAddressStamp) = True
                End If
            End Set
        End Property
        Private m_colFldAddressStamp As String

        Public Property colFldFilePrefix() As String Implements IrowTblWhatIfLocation.colFldFilePrefix
            Get
                Return m_colFldFilePrefix
            End Get
            Set
                If Not Same(m_colFldFilePrefix, Value) Then
                    m_colFldFilePrefix = Value
                    m_IsDirty(FieldIndex.colFldFilePrefix) = True
                End If
            End Set
        End Property
        Private m_colFldFilePrefix As String

        Public Property colFldTivUSD() As Nullable(Of Decimal) Implements IrowTblWhatIfLocation.colFldTivUSD
            Get
                Return m_colFldTivUSD
            End Get
            Set
                If Not Same(m_colFldTivUSD, Value) Then
                    m_colFldTivUSD = Value
                    m_IsDirty(FieldIndex.colFldTivUSD) = True
                End If
            End Set
        End Property
        Private m_colFldTivUSD As Nullable(Of Decimal)

        Public Property colFldTotalScore() As Nullable(Of Decimal) Implements IrowTblWhatIfLocation.colFldTotalScore
            Get
                Return m_colFldTotalScore
            End Get
            Set
                If Not Same(m_colFldTotalScore, Value) Then
                    m_colFldTotalScore = Value
                    m_IsDirty(FieldIndex.colFldTotalScore) = True
                End If
            End Set
        End Property
        Private m_colFldTotalScore As Nullable(Of Decimal)

        Public Property colFldTotalScoreRecsComplete() As Nullable(Of Decimal) Implements IrowTblWhatIfLocation.colFldTotalScoreRecsComplete
            Get
                Return m_colFldTotalScoreRecsComplete
            End Get
            Set
                If Not Same(m_colFldTotalScoreRecsComplete, Value) Then
                    m_colFldTotalScoreRecsComplete = Value
                    m_IsDirty(FieldIndex.colFldTotalScoreRecsComplete) = True
                End If
            End Set
        End Property
        Private m_colFldTotalScoreRecsComplete As Nullable(Of Decimal)

        Public Property colFldTotalScoreAchievedPercent() As Nullable(Of Decimal) Implements IrowTblWhatIfLocation.colFldTotalScoreAchievedPercent
            Get
                Return m_colFldTotalScoreAchievedPercent
            End Get
            Set
                If Not Same(m_colFldTotalScoreAchievedPercent, Value) Then
                    m_colFldTotalScoreAchievedPercent = Value
                    m_IsDirty(FieldIndex.colFldTotalScoreAchievedPercent) = True
                End If
            End Set
        End Property
        Private m_colFldTotalScoreAchievedPercent As Nullable(Of Decimal)

        Public Property colFldPhysicalProtRating() As Nullable(Of Decimal) Implements IrowTblWhatIfLocation.colFldPhysicalProtRating
            Get
                Return m_colFldPhysicalProtRating
            End Get
            Set
                If Not Same(m_colFldPhysicalProtRating, Value) Then
                    m_colFldPhysicalProtRating = Value
                    m_IsDirty(FieldIndex.colFldPhysicalProtRating) = True
                End If
            End Set
        End Property
        Private m_colFldPhysicalProtRating As Nullable(Of Decimal)

        Public Property colFldPhysicalProtWeight() As Nullable(Of Decimal) Implements IrowTblWhatIfLocation.colFldPhysicalProtWeight
            Get
                Return m_colFldPhysicalProtWeight
            End Get
            Set
                If Not Same(m_colFldPhysicalProtWeight, Value) Then
                    m_colFldPhysicalProtWeight = Value
                    m_IsDirty(FieldIndex.colFldPhysicalProtWeight) = True
                End If
            End Set
        End Property
        Private m_colFldPhysicalProtWeight As Nullable(Of Decimal)

        Public Property colFldHeRating() As Nullable(Of Decimal) Implements IrowTblWhatIfLocation.colFldHeRating
            Get
                Return m_colFldHeRating
            End Get
            Set
                If Not Same(m_colFldHeRating, Value) Then
                    m_colFldHeRating = Value
                    m_IsDirty(FieldIndex.colFldHeRating) = True
                End If
            End Set
        End Property
        Private m_colFldHeRating As Nullable(Of Decimal)

        Public Property colFldHeWeight() As Nullable(Of Decimal) Implements IrowTblWhatIfLocation.colFldHeWeight
            Get
                Return m_colFldHeWeight
            End Get
            Set
                If Not Same(m_colFldHeWeight, Value) Then
                    m_colFldHeWeight = Value
                    m_IsDirty(FieldIndex.colFldHeWeight) = True
                End If
            End Set
        End Property
        Private m_colFldHeWeight As Nullable(Of Decimal)

        Public Property colFldNatHazRating() As Nullable(Of Decimal) Implements IrowTblWhatIfLocation.colFldNatHazRating
            Get
                Return m_colFldNatHazRating
            End Get
            Set
                If Not Same(m_colFldNatHazRating, Value) Then
                    m_colFldNatHazRating = Value
                    m_IsDirty(FieldIndex.colFldNatHazRating) = True
                End If
            End Set
        End Property
        Private m_colFldNatHazRating As Nullable(Of Decimal)

        Public Property colFldNatHazWeight() As Nullable(Of Decimal) Implements IrowTblWhatIfLocation.colFldNatHazWeight
            Get
                Return m_colFldNatHazWeight
            End Get
            Set
                If Not Same(m_colFldNatHazWeight, Value) Then
                    m_colFldNatHazWeight = Value
                    m_IsDirty(FieldIndex.colFldNatHazWeight) = True
                End If
            End Set
        End Property
        Private m_colFldNatHazWeight As Nullable(Of Decimal)

        Public Property colFldBcpRating() As Nullable(Of Decimal) Implements IrowTblWhatIfLocation.colFldBcpRating
            Get
                Return m_colFldBcpRating
            End Get
            Set
                If Not Same(m_colFldBcpRating, Value) Then
                    m_colFldBcpRating = Value
                    m_IsDirty(FieldIndex.colFldBcpRating) = True
                End If
            End Set
        End Property
        Private m_colFldBcpRating As Nullable(Of Decimal)

        Public Property colFldBcpWeight() As Nullable(Of Decimal) Implements IrowTblWhatIfLocation.colFldBcpWeight
            Get
                Return m_colFldBcpWeight
            End Get
            Set
                If Not Same(m_colFldBcpWeight, Value) Then
                    m_colFldBcpWeight = Value
                    m_IsDirty(FieldIndex.colFldBcpWeight) = True
                End If
            End Set
        End Property
        Private m_colFldBcpWeight As Nullable(Of Decimal)

        Public Property colFldHasRatingData() As Nullable(Of Boolean) Implements IrowTblWhatIfLocation.colFldHasRatingData
            Get
                Return m_colFldHasRatingData
            End Get
            Set
                If Not Same(m_colFldHasRatingData, Value) Then
                    m_colFldHasRatingData = Value
                    m_IsDirty(FieldIndex.colFldHasRatingData) = True
                End If
            End Set
        End Property
        Private m_colFldHasRatingData As Nullable(Of Boolean)

        Public Property colFldCreateDate() As Nullable(Of DateTime) Implements IrowTblWhatIfLocation.colFldCreateDate
            Get
                Return m_colFldCreateDate
            End Get
            Set
                If Not Same(m_colFldCreateDate, Value) Then
                    m_colFldCreateDate = Value
                    m_IsDirty(FieldIndex.colFldCreateDate) = True
                End If
            End Set
        End Property
        Private m_colFldCreateDate As Nullable(Of DateTime)

        Public Property colFldFacility() As String Implements IrowTblWhatIfLocation.colFldFacility
            Get
                Return m_colFldFacility
            End Get
            Set
                If Not Same(m_colFldFacility, Value) Then
                    m_colFldFacility = Value
                    m_IsDirty(FieldIndex.colFldFacility) = True
                End If
            End Set
        End Property
        Private m_colFldFacility As String


        Public Function IsDirty(pIndex As rowTblWhatIfLocation.FieldIndex) As Boolean Implements IrowTblWhatIfLocation.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblWhatIfLocation.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblWhatIfLocation.SetIsDirty
            m_IsDirty(FieldIndex.colFldGSafeId) = pDirty
            m_IsDirty(FieldIndex.colFldFileNo) = pDirty
            m_IsDirty(FieldIndex.colFldDivision) = pDirty
            m_IsDirty(FieldIndex.colFldCustomAccess) = pDirty
            m_IsDirty(FieldIndex.colFldClientLocID) = pDirty
            m_IsDirty(FieldIndex.colFldAddressStamp) = pDirty
            m_IsDirty(FieldIndex.colFldFilePrefix) = pDirty
            m_IsDirty(FieldIndex.colFldTivUSD) = pDirty
            m_IsDirty(FieldIndex.colFldTotalScore) = pDirty
            m_IsDirty(FieldIndex.colFldTotalScoreRecsComplete) = pDirty
            m_IsDirty(FieldIndex.colFldTotalScoreAchievedPercent) = pDirty
            m_IsDirty(FieldIndex.colFldPhysicalProtRating) = pDirty
            m_IsDirty(FieldIndex.colFldPhysicalProtWeight) = pDirty
            m_IsDirty(FieldIndex.colFldHeRating) = pDirty
            m_IsDirty(FieldIndex.colFldHeWeight) = pDirty
            m_IsDirty(FieldIndex.colFldNatHazRating) = pDirty
            m_IsDirty(FieldIndex.colFldNatHazWeight) = pDirty
            m_IsDirty(FieldIndex.colFldBcpRating) = pDirty
            m_IsDirty(FieldIndex.colFldBcpWeight) = pDirty
            m_IsDirty(FieldIndex.colFldHasRatingData) = pDirty
            m_IsDirty(FieldIndex.colFldCreateDate) = pDirty
            m_IsDirty(FieldIndex.colFldFacility) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblWhatIfLocation) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblWhatIfLocation
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldGSafeId  = 1
            colFldFileNo 
            colFldDivision 
            colFldCustomAccess 
            colFldClientLocID 
            colFldAddressStamp 
            colFldFilePrefix 
            colFldTivUSD 
            colFldTotalScore 
            colFldTotalScoreRecsComplete 
            colFldTotalScoreAchievedPercent 
            colFldPhysicalProtRating 
            colFldPhysicalProtWeight 
            colFldHeRating 
            colFldHeWeight 
            colFldNatHazRating 
            colFldNatHazWeight 
            colFldBcpRating 
            colFldBcpWeight 
            colFldHasRatingData 
            colFldCreateDate 
            colFldFacility 
        End Enum

        Private m_IsDirty(22) As Boolean

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

    Public Interface IrowTblWhatIfLocation
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldGSafeId() As Nullable(Of Integer)
        Property colFldFileNo() As String
        Property colFldDivision() As String
        Property colFldCustomAccess() As String
        Property colFldClientLocID() As String
        Property colFldAddressStamp() As String
        Property colFldFilePrefix() As String
        Property colFldTivUSD() As Nullable(Of Decimal)
        Property colFldTotalScore() As Nullable(Of Decimal)
        Property colFldTotalScoreRecsComplete() As Nullable(Of Decimal)
        Property colFldTotalScoreAchievedPercent() As Nullable(Of Decimal)
        Property colFldPhysicalProtRating() As Nullable(Of Decimal)
        Property colFldPhysicalProtWeight() As Nullable(Of Decimal)
        Property colFldHeRating() As Nullable(Of Decimal)
        Property colFldHeWeight() As Nullable(Of Decimal)
        Property colFldNatHazRating() As Nullable(Of Decimal)
        Property colFldNatHazWeight() As Nullable(Of Decimal)
        Property colFldBcpRating() As Nullable(Of Decimal)
        Property colFldBcpWeight() As Nullable(Of Decimal)
        Property colFldHasRatingData() As Nullable(Of Boolean)
        Property colFldCreateDate() As Nullable(Of DateTime)
        Property colFldFacility() As String
        Function IsDirty(pIndex As rowTblWhatIfLocation.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

