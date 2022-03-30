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
    Partial Public Class TblMetaLossEstimate

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaLossEstimate)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaLossEstimate, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaLossEstimate, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaLossEstimate, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldExchangeRateGroupID) And razor.UtilSQLServer.IsKeySet(pRowData.colFldCurrencyId) And razor.UtilSQLServer.IsKeySet(pRowData.colFldLossEstimateTypeId) And razor.UtilSQLServer.IsKeySet(pRowData.colFldIndexNo) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[tblMetaLossEstimate] " & _
                        "WHERE [fldExchangeRateGroupID] = @colFldExchangeRateGroupID AND [fldCurrencyId] = @colFldCurrencyId AND [fldLossEstimateTypeId] = @colFldLossEstimateTypeId AND [fldIndexNo] = @colFldIndexNo"

                Dim zCmd As New SQLCommand
                zCmd.CommandText = zSQL
                zCmd.Parameters.Add(New SQLParameter("@colFldExchangeRateGroupID", pRowData.colFldExchangeRateGroupID))
                zCmd.Parameters.Add(New SQLParameter("@colFldCurrencyId", pRowData.colFldCurrencyId))
                zCmd.Parameters.Add(New SQLParameter("@colFldLossEstimateTypeId", pRowData.colFldLossEstimateTypeId))
                zCmd.Parameters.Add(New SQLParameter("@colFldIndexNo", pRowData.colFldIndexNo))

                zCmd.Transaction=pTransaction
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)

                pRowData.RaiseDeletedEvent(pDeleteEventUserState)

            End If

        End Sub

        Public Shared Sub Delete(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyId As Integer, pcolFldLossEstimateTypeId As Integer, pcolFldIndexNo As Integer)
            Delete(pcolFldExchangeRateGroupID, pcolFldCurrencyId, pcolFldLossEstimateTypeId, pcolFldIndexNo, Nothing, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyId As Integer, pcolFldLossEstimateTypeId As Integer, pcolFldIndexNo As Integer, pDeleteEventUserState As Object)
            Delete(pcolFldExchangeRateGroupID, pcolFldCurrencyId, pcolFldLossEstimateTypeId, pcolFldIndexNo, Nothing, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Delete(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyId As Integer, pcolFldLossEstimateTypeId As Integer, pcolFldIndexNo As Integer, ByRef pTransaction As SqlClient.SqlTransaction)
        Delete(pcolFldExchangeRateGroupID, pcolFldCurrencyId, pcolFldLossEstimateTypeId, pcolFldIndexNo, pTransaction, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyId As Integer, pcolFldLossEstimateTypeId As Integer, pcolFldIndexNo As Integer, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
        Dim zObj As rowTblMetaLossEstimate = LoadByPrimaryKey(pcolFldExchangeRateGroupID, pcolFldCurrencyId, pcolFldLossEstimateTypeId, pcolFldIndexNo, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblMetaLossEstimate)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaLossEstimate, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaLossEstimate, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldExchangeRateGroupID) And razor.UtilSQLServer.IsKeySet(pRowData.colFldCurrencyId) And razor.UtilSQLServer.IsKeySet(pRowData.colFldLossEstimateTypeId) And razor.UtilSQLServer.IsKeySet(pRowData.colFldIndexNo) Then

                zSQL = "SELECT COUNT(*) from [dbo].[tblMetaLossEstimate] WHERE [fldExchangeRateGroupID] = @colFldExchangeRateGroupID AND [fldCurrencyId] = @colFldCurrencyId AND [fldLossEstimateTypeId] = @colFldLossEstimateTypeId AND [fldIndexNo] = @colFldIndexNo"

                Dim zCmdDoesExist As New SQLCommand

                zCmdDoesExist.CommandText = zSQL

                zCmdDoesExist.Parameters.Add(new SQLParameter("@colFldExchangeRateGroupID", pRowData.colFldExchangeRateGroupID))
                zCmdDoesExist.Parameters.Add(new SQLParameter("@colFldCurrencyId", pRowData.colFldCurrencyId))
                zCmdDoesExist.Parameters.Add(new SQLParameter("@colFldLossEstimateTypeId", pRowData.colFldLossEstimateTypeId))
                zCmdDoesExist.Parameters.Add(new SQLParameter("@colFldIndexNo", pRowData.colFldIndexNo))

                'if zExistInDB > 0  then  PK exists in the DB
                zCmdDoesExist.Transaction = pTransaction
                zExistInDB = razor.UtilSQLServer.ExecuteScalar(zCmdDoesExist)
            End If

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldExchangeRateGroupID) And razor.UtilSQLServer.IsKeySet(pRowData.colFldCurrencyId) And razor.UtilSQLServer.IsKeySet(pRowData.colFldLossEstimateTypeId) And razor.UtilSQLServer.IsKeySet(pRowData.colFldIndexNo) And zExistInDB > 0 Then
                zMode = "UPDATE"
            End If
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldExchangeRateGroupID) And razor.UtilSQLServer.IsKeySet(pRowData.colFldCurrencyId) And razor.UtilSQLServer.IsKeySet(pRowData.colFldLossEstimateTypeId) And razor.UtilSQLServer.IsKeySet(pRowData.colFldIndexNo) And zExistInDB = 0 Then
                zMode = "INSERTwithKey"
            End If
            If Not razor.UtilSQLServer.IsKeySet(pRowData.colFldExchangeRateGroupID) Or Not razor.UtilSQLServer.IsKeySet(pRowData.colFldCurrencyId) Or Not razor.UtilSQLServer.IsKeySet(pRowData.colFldLossEstimateTypeId) Or Not razor.UtilSQLServer.IsKeySet(pRowData.colFldIndexNo) Then
                zMode = "INSERTnoKey"
            End If

            Select Case zMode
                Case "UPDATE"
                    If pRowData.IsDirty Then
                        Dim zUpdate As String = ""
                        Dim zSet As String = ""
                        Dim zWhere As String = ""
                        zUpdate = "UPDATE [dbo].[tblMetaLossEstimate] SET " 
                        If pRowData.IsDirty(rowTblMetaLossEstimate.FieldIndex.colFldRangeText) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldRangeText] = @colFldRangeText "
                        End If
                        If pRowData.IsDirty(rowTblMetaLossEstimate.FieldIndex.colFldRangeDisplay) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldRangeDisplay] = @colFldRangeDisplay "
                        End If
                        If pRowData.IsDirty(rowTblMetaLossEstimate.FieldIndex.colFldRangeValueLow) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldRangeValueLow] = @colFldRangeValueLow "
                        End If
                        If pRowData.IsDirty(rowTblMetaLossEstimate.FieldIndex.colFldRangeValueHigh) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldRangeValueHigh] = @colFldRangeValueHigh "
                        End If
                        zWhere = " WHERE [fldExchangeRateGroupID] = @colFldExchangeRateGroupID AND [fldCurrencyId] = @colFldCurrencyId AND [fldLossEstimateTypeId] = @colFldLossEstimateTypeId AND [fldIndexNo] = @colFldIndexNo"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaLossEstimate] ([fldExchangeRateGroupID], [fldCurrencyId], [fldLossEstimateTypeId], [fldIndexNo], [fldRangeText], [fldRangeDisplay], [fldRangeValueLow], [fldRangeValueHigh])" & _
                            " VALUES (@colFldExchangeRateGroupID, @colFldCurrencyId, @colFldLossEstimateTypeId, @colFldIndexNo, @colFldRangeText, @colFldRangeDisplay, @colFldRangeValueLow, @colFldRangeValueHigh); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaLossEstimate] ([fldRangeText], [fldRangeDisplay], [fldRangeValueLow], [fldRangeValueHigh])" & _
                            " VALUES (@colFldRangeText, @colFldRangeDisplay, @colFldRangeValueLow, @colFldRangeValueHigh); SELECT SCOPE_IDENTITY()"
                Case Else
            End Select

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

			'IF UPDATE, SET PK PARAMETER
            If zMode = "UPDATE" Then
                zCmd.Parameters.Add(New SQLParameter("@colFldExchangeRateGroupID", pRowData.colFldExchangeRateGroupID))
                zCmd.Parameters.Add(New SQLParameter("@colFldCurrencyId", pRowData.colFldCurrencyId))
                zCmd.Parameters.Add(New SQLParameter("@colFldLossEstimateTypeId", pRowData.colFldLossEstimateTypeId))
                zCmd.Parameters.Add(New SQLParameter("@colFldIndexNo", pRowData.colFldIndexNo))
            End If

			'IF INSERTING, KEY HAS VALUE AND KEY IS NOT IDENTITY, SET PK PARAMETER
			If zMode = "INSERTwithKey" Then
                zCmd.Parameters.Add(New SQLParameter("@colFldExchangeRateGroupID", pRowData.colFldExchangeRateGroupID))
                zCmd.Parameters.Add(New SQLParameter("@colFldCurrencyId", pRowData.colFldCurrencyId))
                zCmd.Parameters.Add(New SQLParameter("@colFldLossEstimateTypeId", pRowData.colFldLossEstimateTypeId))
                zCmd.Parameters.Add(New SQLParameter("@colFldIndexNo", pRowData.colFldIndexNo))
            End If

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaLossEstimate.FieldIndex.colFldRangeText) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldRangeText", IIf(pRowData.colFldRangeText Is Nothing, DBNull.Value, pRowData.colFldRangeText)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaLossEstimate.FieldIndex.colFldRangeDisplay) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldRangeDisplay", IIf(pRowData.colFldRangeDisplay Is Nothing, DBNull.Value, pRowData.colFldRangeDisplay)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaLossEstimate.FieldIndex.colFldRangeValueLow) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldRangeValueLow", IIf(pRowData.colFldRangeValueLow Is Nothing, DBNull.Value, pRowData.colFldRangeValueLow)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaLossEstimate.FieldIndex.colFldRangeValueHigh) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldRangeValueHigh", IIf(pRowData.colFldRangeValueHigh Is Nothing, DBNull.Value, pRowData.colFldRangeValueHigh)))
                End If

            zCmd.Transaction=pTransaction
            If zMode = "INSERTnoKey" Then
                Dim zLastId As Long = 0
                zLastId = razor.UtilSQLServer.ExecuteNonQueryRowId(zCmd)

                pRowData.colFldExchangeRateGroupID = zLastId
                pRowData.colFldCurrencyId = zLastId
                pRowData.colFldLossEstimateTypeId = zLastId
                pRowData.colFldIndexNo = zLastId
            Else
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)
            End If

            pRowData.SetIsDirty(False)
            pRowData.RaiseSavedEvent(pSavedEventUserState)

		End If

        End Sub

        Public Shared Function LoadByPrimaryKey(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyId As Integer, pcolFldLossEstimateTypeId As Integer, pcolFldIndexNo As Integer) As rowTblMetaLossEstimate
            Return LoadByPrimaryKey(pcolFldExchangeRateGroupID, pcolFldCurrencyId, pcolFldLossEstimateTypeId, pcolFldIndexNo, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyId As Integer, pcolFldLossEstimateTypeId As Integer, pcolFldIndexNo As Integer, pLoadEventUserState As Object) As rowTblMetaLossEstimate
            Return LoadByPrimaryKey(pcolFldExchangeRateGroupID, pcolFldCurrencyId, pcolFldLossEstimateTypeId, pcolFldIndexNo, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyId As Integer, pcolFldLossEstimateTypeId As Integer, pcolFldIndexNo As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblMetaLossEstimate
            Return LoadByPrimaryKey(pcolFldExchangeRateGroupID, pcolFldCurrencyId, pcolFldLossEstimateTypeId, pcolFldIndexNo, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyId As Integer, pcolFldLossEstimateTypeId As Integer, pcolFldIndexNo As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblMetaLossEstimate
            Dim zReturn As New rowTblMetaLossEstimate
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaLossEstimate] WHERE [fldExchangeRateGroupID] = @colFldExchangeRateGroupID AND [fldCurrencyId] = @colFldCurrencyId AND [fldLossEstimateTypeId] = @colFldLossEstimateTypeId AND [fldIndexNo] = @colFldIndexNo"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldExchangeRateGroupID", pcolFldExchangeRateGroupID))
            zCmd.Parameters.Add(New SQLParameter("@colFldCurrencyId", pcolFldCurrencyId))
            zCmd.Parameters.Add(New SQLParameter("@colFldLossEstimateTypeId", pcolFldLossEstimateTypeId))
            zCmd.Parameters.Add(New SQLParameter("@colFldIndexNo", pcolFldIndexNo))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblMetaLossEstimate) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_IX_ClientCurrencyId_LossEstTypeId_fldRangeText_CurrencyId(pcolFldExchangeRateGroupID As Integer, pcolFldLossEstimateTypeId As Integer, pcolFldRangeText As String, pcolFldCurrencyId As Integer) As List(Of rowTblMetaLossEstimate)
            Return LoadByIDX_IX_ClientCurrencyId_LossEstTypeId_fldRangeText_CurrencyId(pcolFldExchangeRateGroupID, pcolFldLossEstimateTypeId, pcolFldRangeText, pcolFldCurrencyId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_ClientCurrencyId_LossEstTypeId_fldRangeText_CurrencyId(pcolFldExchangeRateGroupID As Integer, pcolFldLossEstimateTypeId As Integer, pcolFldRangeText As String, pcolFldCurrencyId As Integer, pLoadEventUserState As Object) As List(Of rowTblMetaLossEstimate)
            Return LoadByIDX_IX_ClientCurrencyId_LossEstTypeId_fldRangeText_CurrencyId(pcolFldExchangeRateGroupID, pcolFldLossEstimateTypeId, pcolFldRangeText, pcolFldCurrencyId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_ClientCurrencyId_LossEstTypeId_fldRangeText_CurrencyId(pcolFldExchangeRateGroupID As Integer, pcolFldLossEstimateTypeId As Integer, pcolFldRangeText As String, pcolFldCurrencyId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaLossEstimate)
            Return LoadByIDX_IX_ClientCurrencyId_LossEstTypeId_fldRangeText_CurrencyId(pcolFldExchangeRateGroupID, pcolFldLossEstimateTypeId, pcolFldRangeText, pcolFldCurrencyId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_ClientCurrencyId_LossEstTypeId_fldRangeText_CurrencyId(pcolFldExchangeRateGroupID As Integer, pcolFldLossEstimateTypeId As Integer, pcolFldRangeText As String, pcolFldCurrencyId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaLossEstimate)
            Dim zReturn As New List(Of rowTblMetaLossEstimate)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaLossEstimate] WHERE [fldExchangeRateGroupID] = @colFldExchangeRateGroupID AND [fldLossEstimateTypeId] = @colFldLossEstimateTypeId AND [fldRangeText] = @colFldRangeText AND [fldCurrencyId] = @colFldCurrencyId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldExchangeRateGroupID", pcolFldExchangeRateGroupID))
            zCmd.Parameters.Add(New SQLParameter("@colFldLossEstimateTypeId", pcolFldLossEstimateTypeId))
            zCmd.Parameters.Add(New SQLParameter("@colFldRangeText", pcolFldRangeText))
            zCmd.Parameters.Add(New SQLParameter("@colFldCurrencyId", pcolFldCurrencyId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function
        Public Shared Function LoadByIDX_PK_tblMetaLossEstimate(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyId As Integer, pcolFldLossEstimateTypeId As Integer, pcolFldIndexNo As Integer) As List(Of rowTblMetaLossEstimate)
            Return LoadByIDX_PK_tblMetaLossEstimate(pcolFldExchangeRateGroupID, pcolFldCurrencyId, pcolFldLossEstimateTypeId, pcolFldIndexNo, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaLossEstimate(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyId As Integer, pcolFldLossEstimateTypeId As Integer, pcolFldIndexNo As Integer, pLoadEventUserState As Object) As List(Of rowTblMetaLossEstimate)
            Return LoadByIDX_PK_tblMetaLossEstimate(pcolFldExchangeRateGroupID, pcolFldCurrencyId, pcolFldLossEstimateTypeId, pcolFldIndexNo, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaLossEstimate(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyId As Integer, pcolFldLossEstimateTypeId As Integer, pcolFldIndexNo As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaLossEstimate)
            Return LoadByIDX_PK_tblMetaLossEstimate(pcolFldExchangeRateGroupID, pcolFldCurrencyId, pcolFldLossEstimateTypeId, pcolFldIndexNo, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaLossEstimate(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyId As Integer, pcolFldLossEstimateTypeId As Integer, pcolFldIndexNo As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaLossEstimate)
            Dim zReturn As New List(Of rowTblMetaLossEstimate)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaLossEstimate] WHERE [fldExchangeRateGroupID] = @colFldExchangeRateGroupID AND [fldCurrencyId] = @colFldCurrencyId AND [fldLossEstimateTypeId] = @colFldLossEstimateTypeId AND [fldIndexNo] = @colFldIndexNo"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldExchangeRateGroupID", pcolFldExchangeRateGroupID))
            zCmd.Parameters.Add(New SQLParameter("@colFldCurrencyId", pcolFldCurrencyId))
            zCmd.Parameters.Add(New SQLParameter("@colFldLossEstimateTypeId", pcolFldLossEstimateTypeId))
            zCmd.Parameters.Add(New SQLParameter("@colFldIndexNo", pcolFldIndexNo))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblMetaLossEstimate)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblMetaLossEstimate)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblMetaLossEstimate)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaLossEstimate)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaLossEstimate)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaLossEstimate)
            Dim zReturn As New List(Of rowTblMetaLossEstimate)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaLossEstimate]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblMetaLossEstimate)

			Try
	            Dim zReturn As New List(Of rowTblMetaLossEstimate)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblMetaLossEstimate

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblMetaLossEstimate		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblMetaLossEstimate)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldExchangeRateGroupID")) Then pObject.colFldExchangeRateGroupID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldExchangeRateGroupID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldCurrencyId")) Then pObject.colFldCurrencyId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldCurrencyId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldLossEstimateTypeId")) Then pObject.colFldLossEstimateTypeId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldLossEstimateTypeId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldIndexNo")) Then pObject.colFldIndexNo = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldIndexNo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldRangeText")) Then pObject.colFldRangeText = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldRangeText")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldRangeDisplay")) Then pObject.colFldRangeDisplay = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldRangeDisplay")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldRangeValueLow")) Then pObject.colFldRangeValueLow = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "fldRangeValueLow")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldRangeValueHigh")) Then pObject.colFldRangeValueHigh = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "fldRangeValueHigh")
			pObject.SetIsDirty(False)
			Return pObject
		End	 Function

    #Region "Reflection Based Load Functions"

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyId As Integer, pcolFldLossEstimateTypeId As Integer, pcolFldIndexNo As Integer) As T
            Return LoadByPrimaryKey(Of T)(pcolFldExchangeRateGroupID, pcolFldCurrencyId, pcolFldLossEstimateTypeId, pcolFldIndexNo, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyId As Integer, pcolFldLossEstimateTypeId As Integer, pcolFldIndexNo As Integer, pLoadEventUserState As Object) As T
            Return LoadByPrimaryKey(Of T)(pcolFldExchangeRateGroupID, pcolFldCurrencyId, pcolFldLossEstimateTypeId, pcolFldIndexNo, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyId As Integer, pcolFldLossEstimateTypeId As Integer, pcolFldIndexNo As Integer, pTransaction As SqlClient.SqlTransaction) As T
            Return LoadByPrimaryKey(Of T)(pcolFldExchangeRateGroupID, pcolFldCurrencyId, pcolFldLossEstimateTypeId, pcolFldIndexNo, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyId As Integer, pcolFldLossEstimateTypeId As Integer, pcolFldIndexNo As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As T

            Dim zReturn As Object = Activator.CreateInstance(Of T)()
            If Not TypeOf zReturn Is rowTblMetaLossEstimate Then Throw New ArgumentException("Generic type is not type of rowTblMetaLossEstimate.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaLossEstimate] WHERE [fldExchangeRateGroupID] = @colFldExchangeRateGroupID AND [fldCurrencyId] = @colFldCurrencyId AND [fldLossEstimateTypeId] = @colFldLossEstimateTypeId AND [fldIndexNo] = @colFldIndexNo"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldExchangeRateGroupID", pcolFldExchangeRateGroupID))
            zCmd.Parameters.Add(New SQLParameter("@colFldCurrencyId", pcolFldCurrencyId))
            zCmd.Parameters.Add(New SQLParameter("@colFldLossEstimateTypeId", pcolFldLossEstimateTypeId))
            zCmd.Parameters.Add(New SQLParameter("@colFldIndexNo", pcolFldIndexNo))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of T) = ReadData(Of T)(zCmd, pLoadEventUserState)
            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

        End Function

        Public Shared Function LoadByIDX_IX_ClientCurrencyId_LossEstTypeId_fldRangeText_CurrencyId(Of T)(pcolFldExchangeRateGroupID As Integer, pcolFldLossEstimateTypeId As Integer, pcolFldRangeText As String, pcolFldCurrencyId As Integer) As List(Of T)
            Return LoadByIDX_IX_ClientCurrencyId_LossEstTypeId_fldRangeText_CurrencyId(Of T)(pcolFldExchangeRateGroupID, pcolFldLossEstimateTypeId, pcolFldRangeText, pcolFldCurrencyId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_ClientCurrencyId_LossEstTypeId_fldRangeText_CurrencyId(Of T)(pcolFldExchangeRateGroupID As Integer, pcolFldLossEstimateTypeId As Integer, pcolFldRangeText As String, pcolFldCurrencyId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_IX_ClientCurrencyId_LossEstTypeId_fldRangeText_CurrencyId(Of T)(pcolFldExchangeRateGroupID, pcolFldLossEstimateTypeId, pcolFldRangeText, pcolFldCurrencyId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_ClientCurrencyId_LossEstTypeId_fldRangeText_CurrencyId(Of T)(pcolFldExchangeRateGroupID As Integer, pcolFldLossEstimateTypeId As Integer, pcolFldRangeText As String, pcolFldCurrencyId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_IX_ClientCurrencyId_LossEstTypeId_fldRangeText_CurrencyId(Of T)(pcolFldExchangeRateGroupID, pcolFldLossEstimateTypeId, pcolFldRangeText, pcolFldCurrencyId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_IX_ClientCurrencyId_LossEstTypeId_fldRangeText_CurrencyId(Of T)(pcolFldExchangeRateGroupID As Integer, pcolFldLossEstimateTypeId As Integer, pcolFldRangeText As String, pcolFldCurrencyId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaLossEstimate] WHERE [fldExchangeRateGroupID] = @colFldExchangeRateGroupID AND [fldLossEstimateTypeId] = @colFldLossEstimateTypeId AND [fldRangeText] = @colFldRangeText AND [fldCurrencyId] = @colFldCurrencyId"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldExchangeRateGroupID", pcolFldExchangeRateGroupID))
            zCmd.Parameters.Add(New SQLParameter("@colFldLossEstimateTypeId", pcolFldLossEstimateTypeId))
            zCmd.Parameters.Add(New SQLParameter("@colFldRangeText", pcolFldRangeText))
            zCmd.Parameters.Add(New SQLParameter("@colFldCurrencyId", pcolFldCurrencyId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaLossEstimate(Of T)(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyId As Integer, pcolFldLossEstimateTypeId As Integer, pcolFldIndexNo As Integer) As List(Of T)
            Return LoadByIDX_PK_tblMetaLossEstimate(Of T)(pcolFldExchangeRateGroupID, pcolFldCurrencyId, pcolFldLossEstimateTypeId, pcolFldIndexNo, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaLossEstimate(Of T)(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyId As Integer, pcolFldLossEstimateTypeId As Integer, pcolFldIndexNo As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK_tblMetaLossEstimate(Of T)(pcolFldExchangeRateGroupID, pcolFldCurrencyId, pcolFldLossEstimateTypeId, pcolFldIndexNo, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaLossEstimate(Of T)(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyId As Integer, pcolFldLossEstimateTypeId As Integer, pcolFldIndexNo As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK_tblMetaLossEstimate(Of T)(pcolFldExchangeRateGroupID, pcolFldCurrencyId, pcolFldLossEstimateTypeId, pcolFldIndexNo, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK_tblMetaLossEstimate(Of T)(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyId As Integer, pcolFldLossEstimateTypeId As Integer, pcolFldIndexNo As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaLossEstimate] WHERE [fldExchangeRateGroupID] = @colFldExchangeRateGroupID AND [fldCurrencyId] = @colFldCurrencyId AND [fldLossEstimateTypeId] = @colFldLossEstimateTypeId AND [fldIndexNo] = @colFldIndexNo"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldExchangeRateGroupID", pcolFldExchangeRateGroupID))
            zCmd.Parameters.Add(New SQLParameter("@colFldCurrencyId", pcolFldCurrencyId))
            zCmd.Parameters.Add(New SQLParameter("@colFldLossEstimateTypeId", pcolFldLossEstimateTypeId))
            zCmd.Parameters.Add(New SQLParameter("@colFldIndexNo", pcolFldIndexNo))

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
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaLossEstimate]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblMetaLossEstimate
        Implements IrowTblMetaLossEstimate

        Public Event Loaded(pUserState As Object) Implements IrowTblMetaLossEstimate.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblMetaLossEstimate.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblMetaLossEstimate.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblMetaLossEstimate.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblMetaLossEstimate.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblMetaLossEstimate.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldExchangeRateGroupID() As Nullable(Of Integer) Implements IrowTblMetaLossEstimate.colFldExchangeRateGroupID
            Get
                Return m_colFldExchangeRateGroupID
            End Get
            Set
                If Not Same(m_colFldExchangeRateGroupID, Value) Then
                    m_colFldExchangeRateGroupID = Value
                    m_IsDirty(FieldIndex.colFldExchangeRateGroupID) = True
                End If
            End Set
        End Property
        Private m_colFldExchangeRateGroupID As Nullable(Of Integer)

        Public Property colFldCurrencyId() As Nullable(Of Integer) Implements IrowTblMetaLossEstimate.colFldCurrencyId
            Get
                Return m_colFldCurrencyId
            End Get
            Set
                If Not Same(m_colFldCurrencyId, Value) Then
                    m_colFldCurrencyId = Value
                    m_IsDirty(FieldIndex.colFldCurrencyId) = True
                End If
            End Set
        End Property
        Private m_colFldCurrencyId As Nullable(Of Integer)

        Public Property colFldLossEstimateTypeId() As Nullable(Of Integer) Implements IrowTblMetaLossEstimate.colFldLossEstimateTypeId
            Get
                Return m_colFldLossEstimateTypeId
            End Get
            Set
                If Not Same(m_colFldLossEstimateTypeId, Value) Then
                    m_colFldLossEstimateTypeId = Value
                    m_IsDirty(FieldIndex.colFldLossEstimateTypeId) = True
                End If
            End Set
        End Property
        Private m_colFldLossEstimateTypeId As Nullable(Of Integer)

        Public Property colFldIndexNo() As Nullable(Of Integer) Implements IrowTblMetaLossEstimate.colFldIndexNo
            Get
                Return m_colFldIndexNo
            End Get
            Set
                If Not Same(m_colFldIndexNo, Value) Then
                    m_colFldIndexNo = Value
                    m_IsDirty(FieldIndex.colFldIndexNo) = True
                End If
            End Set
        End Property
        Private m_colFldIndexNo As Nullable(Of Integer)

        Public Property colFldRangeText() As String Implements IrowTblMetaLossEstimate.colFldRangeText
            Get
                Return m_colFldRangeText
            End Get
            Set
                If Not Same(m_colFldRangeText, Value) Then
                    m_colFldRangeText = Value
                    m_IsDirty(FieldIndex.colFldRangeText) = True
                End If
            End Set
        End Property
        Private m_colFldRangeText As String

        Public Property colFldRangeDisplay() As String Implements IrowTblMetaLossEstimate.colFldRangeDisplay
            Get
                Return m_colFldRangeDisplay
            End Get
            Set
                If Not Same(m_colFldRangeDisplay, Value) Then
                    m_colFldRangeDisplay = Value
                    m_IsDirty(FieldIndex.colFldRangeDisplay) = True
                End If
            End Set
        End Property
        Private m_colFldRangeDisplay As String

        Public Property colFldRangeValueLow() As Nullable(Of Long) Implements IrowTblMetaLossEstimate.colFldRangeValueLow
            Get
                Return m_colFldRangeValueLow
            End Get
            Set
                If Not Same(m_colFldRangeValueLow, Value) Then
                    m_colFldRangeValueLow = Value
                    m_IsDirty(FieldIndex.colFldRangeValueLow) = True
                End If
            End Set
        End Property
        Private m_colFldRangeValueLow As Nullable(Of Long)

        Public Property colFldRangeValueHigh() As Nullable(Of Long) Implements IrowTblMetaLossEstimate.colFldRangeValueHigh
            Get
                Return m_colFldRangeValueHigh
            End Get
            Set
                If Not Same(m_colFldRangeValueHigh, Value) Then
                    m_colFldRangeValueHigh = Value
                    m_IsDirty(FieldIndex.colFldRangeValueHigh) = True
                End If
            End Set
        End Property
        Private m_colFldRangeValueHigh As Nullable(Of Long)


        Public Function IsDirty(pIndex As rowTblMetaLossEstimate.FieldIndex) As Boolean Implements IrowTblMetaLossEstimate.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblMetaLossEstimate.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblMetaLossEstimate.SetIsDirty
            m_IsDirty(FieldIndex.colFldExchangeRateGroupID) = pDirty
            m_IsDirty(FieldIndex.colFldCurrencyId) = pDirty
            m_IsDirty(FieldIndex.colFldLossEstimateTypeId) = pDirty
            m_IsDirty(FieldIndex.colFldIndexNo) = pDirty
            m_IsDirty(FieldIndex.colFldRangeText) = pDirty
            m_IsDirty(FieldIndex.colFldRangeDisplay) = pDirty
            m_IsDirty(FieldIndex.colFldRangeValueLow) = pDirty
            m_IsDirty(FieldIndex.colFldRangeValueHigh) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblMetaLossEstimate) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblMetaLossEstimate
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldExchangeRateGroupID  = 1
            colFldCurrencyId 
            colFldLossEstimateTypeId 
            colFldIndexNo 
            colFldRangeText 
            colFldRangeDisplay 
            colFldRangeValueLow 
            colFldRangeValueHigh 
        End Enum

        Private m_IsDirty(8) As Boolean

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

    Public Interface IrowTblMetaLossEstimate
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldExchangeRateGroupID() As Nullable(Of Integer)
        Property colFldCurrencyId() As Nullable(Of Integer)
        Property colFldLossEstimateTypeId() As Nullable(Of Integer)
        Property colFldIndexNo() As Nullable(Of Integer)
        Property colFldRangeText() As String
        Property colFldRangeDisplay() As String
        Property colFldRangeValueLow() As Nullable(Of Long)
        Property colFldRangeValueHigh() As Nullable(Of Long)
        Function IsDirty(pIndex As rowTblMetaLossEstimate.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

