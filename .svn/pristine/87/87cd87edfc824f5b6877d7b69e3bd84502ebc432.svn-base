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
    Partial Public Class TblMetaRatingKeyRange

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaRatingKeyRange)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaRatingKeyRange, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaRatingKeyRange, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaRatingKeyRange, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[tblMetaRatingKeyRange] " & _
                        "WHERE [fldId] = @colFldId"

                Dim zCmd As New SQLCommand
                zCmd.CommandText = zSQL
                zCmd.Parameters.Add(New SQLParameter("@colFldId", pRowData.colFldId))

                zCmd.Transaction=pTransaction
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)

                pRowData.RaiseDeletedEvent(pDeleteEventUserState)

            End If

        End Sub

        Public Shared Sub Delete(pcolFldId As Integer)
            Delete(pcolFldId, Nothing, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolFldId As Integer, pDeleteEventUserState As Object)
            Delete(pcolFldId, Nothing, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Delete(pcolFldId As Integer, ByRef pTransaction As SqlClient.SqlTransaction)
        Delete(pcolFldId, pTransaction, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolFldId As Integer, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
        Dim zObj As rowTblMetaRatingKeyRange = LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblMetaRatingKeyRange)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaRatingKeyRange, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaRatingKeyRange, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[tblMetaRatingKeyRange] WHERE [fldId] = @colFldId"

                Dim zCmdDoesExist As New SQLCommand

                zCmdDoesExist.CommandText = zSQL

                zCmdDoesExist.Parameters.Add(new SQLParameter("@colFldId", pRowData.colFldId))

                'if zExistInDB > 0  then  PK exists in the DB
                zCmdDoesExist.Transaction = pTransaction
                zExistInDB = razor.UtilSQLServer.ExecuteScalar(zCmdDoesExist)
            End If

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) And zExistInDB > 0 Then
                zMode = "UPDATE"
            End If
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) And zExistInDB = 0 Then
                zMode = "INSERTwithKey"
            End If
            If Not razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then
                zMode = "INSERTnoKey"
            End If

            Select Case zMode
                Case "UPDATE"
                    If pRowData.IsDirty Then
                        Dim zUpdate As String = ""
                        Dim zSet As String = ""
                        Dim zWhere As String = ""
                        zUpdate = "UPDATE [dbo].[tblMetaRatingKeyRange] SET " 
                        If pRowData.IsDirty(rowTblMetaRatingKeyRange.FieldIndex.colFldKeyId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldKeyId] = @colFldKeyId "
                        End If
                        If pRowData.IsDirty(rowTblMetaRatingKeyRange.FieldIndex.colFldRating) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldRating] = @colFldRating "
                        End If
                        If pRowData.IsDirty(rowTblMetaRatingKeyRange.FieldIndex.colFldDescription) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldDescription] = @colFldDescription "
                        End If
                        If pRowData.IsDirty(rowTblMetaRatingKeyRange.FieldIndex.colFldScoreLow) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldScoreLow] = @colFldScoreLow "
                        End If
                        If pRowData.IsDirty(rowTblMetaRatingKeyRange.FieldIndex.colFldScoreHigh) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldScoreHigh] = @colFldScoreHigh "
                        End If
                        If pRowData.IsDirty(rowTblMetaRatingKeyRange.FieldIndex.colFldMetaColorId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldMetaColorId] = @colFldMetaColorId "
                        End If
                        If pRowData.IsDirty(rowTblMetaRatingKeyRange.FieldIndex.colFldPSRatingKey) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldPSRatingKey] = @colFldPSRatingKey "
                        End If
                        zWhere = " WHERE [fldId] = @colFldId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaRatingKeyRange] ([fldKeyId], [fldRating], [fldDescription], [fldScoreLow], [fldScoreHigh], [fldMetaColorId], [fldPSRatingKey])" & _
                            " VALUES (@colFldKeyId, @colFldRating, @colFldDescription, @colFldScoreLow, @colFldScoreHigh, @colFldMetaColorId, @colFldPSRatingKey); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaRatingKeyRange] ([fldKeyId], [fldRating], [fldDescription], [fldScoreLow], [fldScoreHigh], [fldMetaColorId], [fldPSRatingKey])" & _
                            " VALUES (@colFldKeyId, @colFldRating, @colFldDescription, @colFldScoreLow, @colFldScoreHigh, @colFldMetaColorId, @colFldPSRatingKey); SELECT SCOPE_IDENTITY()"
                Case Else
            End Select

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

			'IF UPDATE, SET PK PARAMETER
            If zMode = "UPDATE" Then
                zCmd.Parameters.Add(New SQLParameter("@colFldId", pRowData.colFldId))
            End If

			'IF INSERTING, KEY HAS VALUE AND KEY IS NOT IDENTITY, SET PK PARAMETER
			If zMode = "INSERTwithKey" Then
            End If

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaRatingKeyRange.FieldIndex.colFldKeyId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldKeyId", IIf(pRowData.colFldKeyId Is Nothing, DBNull.Value, pRowData.colFldKeyId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaRatingKeyRange.FieldIndex.colFldRating) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldRating", IIf(pRowData.colFldRating Is Nothing, DBNull.Value, pRowData.colFldRating)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaRatingKeyRange.FieldIndex.colFldDescription) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldDescription", IIf(pRowData.colFldDescription Is Nothing, DBNull.Value, pRowData.colFldDescription)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaRatingKeyRange.FieldIndex.colFldScoreLow) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldScoreLow", IIf(pRowData.colFldScoreLow Is Nothing, DBNull.Value, pRowData.colFldScoreLow)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaRatingKeyRange.FieldIndex.colFldScoreHigh) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldScoreHigh", IIf(pRowData.colFldScoreHigh Is Nothing, DBNull.Value, pRowData.colFldScoreHigh)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaRatingKeyRange.FieldIndex.colFldMetaColorId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldMetaColorId", IIf(pRowData.colFldMetaColorId Is Nothing, DBNull.Value, pRowData.colFldMetaColorId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaRatingKeyRange.FieldIndex.colFldPSRatingKey) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldPSRatingKey", IIf(pRowData.colFldPSRatingKey Is Nothing, DBNull.Value, pRowData.colFldPSRatingKey)))
                End If

            zCmd.Transaction=pTransaction
            If zMode = "INSERTnoKey" Then
                Dim zLastId As Long = 0
                zLastId = razor.UtilSQLServer.ExecuteNonQueryRowId(zCmd)

                pRowData.colFldId = zLastId
            Else
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)
            End If

            pRowData.SetIsDirty(False)
            pRowData.RaiseSavedEvent(pSavedEventUserState)

		End If

        End Sub

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer) As rowTblMetaRatingKeyRange
            Return LoadByPrimaryKey(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pLoadEventUserState As Object) As rowTblMetaRatingKeyRange
            Return LoadByPrimaryKey(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblMetaRatingKeyRange
            Return LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblMetaRatingKeyRange
            Dim zReturn As New rowTblMetaRatingKeyRange
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaRatingKeyRange] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblMetaRatingKeyRange) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_IX_Range(pcolFldKeyId As Integer, pcolFldScoreLow As Double, pcolFldScoreHigh As Double) As List(Of rowTblMetaRatingKeyRange)
            Return LoadByIDX_IX_Range(pcolFldKeyId, pcolFldScoreLow, pcolFldScoreHigh, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_Range(pcolFldKeyId As Integer, pcolFldScoreLow As Double, pcolFldScoreHigh As Double, pLoadEventUserState As Object) As List(Of rowTblMetaRatingKeyRange)
            Return LoadByIDX_IX_Range(pcolFldKeyId, pcolFldScoreLow, pcolFldScoreHigh, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_Range(pcolFldKeyId As Integer, pcolFldScoreLow As Double, pcolFldScoreHigh As Double, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaRatingKeyRange)
            Return LoadByIDX_IX_Range(pcolFldKeyId, pcolFldScoreLow, pcolFldScoreHigh, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_Range(pcolFldKeyId As Integer, pcolFldScoreLow As Double, pcolFldScoreHigh As Double, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaRatingKeyRange)
            Dim zReturn As New List(Of rowTblMetaRatingKeyRange)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaRatingKeyRange] WHERE [fldKeyId] = @colFldKeyId AND [fldScoreLow] = @colFldScoreLow AND [fldScoreHigh] = @colFldScoreHigh"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldKeyId", pcolFldKeyId))
            zCmd.Parameters.Add(New SQLParameter("@colFldScoreLow", pcolFldScoreLow))
            zCmd.Parameters.Add(New SQLParameter("@colFldScoreHigh", pcolFldScoreHigh))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function
        Public Shared Function LoadByIDX_IX_Range_without_KeyId(pcolFldScoreLow As Double, pcolFldScoreHigh As Double) As List(Of rowTblMetaRatingKeyRange)
            Return LoadByIDX_IX_Range_without_KeyId(pcolFldScoreLow, pcolFldScoreHigh, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_Range_without_KeyId(pcolFldScoreLow As Double, pcolFldScoreHigh As Double, pLoadEventUserState As Object) As List(Of rowTblMetaRatingKeyRange)
            Return LoadByIDX_IX_Range_without_KeyId(pcolFldScoreLow, pcolFldScoreHigh, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_Range_without_KeyId(pcolFldScoreLow As Double, pcolFldScoreHigh As Double, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaRatingKeyRange)
            Return LoadByIDX_IX_Range_without_KeyId(pcolFldScoreLow, pcolFldScoreHigh, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_Range_without_KeyId(pcolFldScoreLow As Double, pcolFldScoreHigh As Double, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaRatingKeyRange)
            Dim zReturn As New List(Of rowTblMetaRatingKeyRange)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaRatingKeyRange] WHERE [fldScoreLow] = @colFldScoreLow AND [fldScoreHigh] = @colFldScoreHigh"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldScoreLow", pcolFldScoreLow))
            zCmd.Parameters.Add(New SQLParameter("@colFldScoreHigh", pcolFldScoreHigh))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function
        Public Shared Function LoadByIDX_IX_fldKeyID_fldScoreLow_fldScoreHigh(pcolFldKeyId As Integer, pcolFldScoreLow As Double, pcolFldScoreHigh As Double) As List(Of rowTblMetaRatingKeyRange)
            Return LoadByIDX_IX_fldKeyID_fldScoreLow_fldScoreHigh(pcolFldKeyId, pcolFldScoreLow, pcolFldScoreHigh, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_fldKeyID_fldScoreLow_fldScoreHigh(pcolFldKeyId As Integer, pcolFldScoreLow As Double, pcolFldScoreHigh As Double, pLoadEventUserState As Object) As List(Of rowTblMetaRatingKeyRange)
            Return LoadByIDX_IX_fldKeyID_fldScoreLow_fldScoreHigh(pcolFldKeyId, pcolFldScoreLow, pcolFldScoreHigh, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_fldKeyID_fldScoreLow_fldScoreHigh(pcolFldKeyId As Integer, pcolFldScoreLow As Double, pcolFldScoreHigh As Double, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaRatingKeyRange)
            Return LoadByIDX_IX_fldKeyID_fldScoreLow_fldScoreHigh(pcolFldKeyId, pcolFldScoreLow, pcolFldScoreHigh, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_fldKeyID_fldScoreLow_fldScoreHigh(pcolFldKeyId As Integer, pcolFldScoreLow As Double, pcolFldScoreHigh As Double, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaRatingKeyRange)
            Dim zReturn As New List(Of rowTblMetaRatingKeyRange)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaRatingKeyRange] WHERE [fldKeyId] = @colFldKeyId AND [fldScoreLow] = @colFldScoreLow AND [fldScoreHigh] = @colFldScoreHigh"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldKeyId", pcolFldKeyId))
            zCmd.Parameters.Add(New SQLParameter("@colFldScoreLow", pcolFldScoreLow))
            zCmd.Parameters.Add(New SQLParameter("@colFldScoreHigh", pcolFldScoreHigh))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function
        Public Shared Function LoadByIDX_IX_fldKeyId(pcolFldKeyId As Integer) As List(Of rowTblMetaRatingKeyRange)
            Return LoadByIDX_IX_fldKeyId(pcolFldKeyId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_fldKeyId(pcolFldKeyId As Integer, pLoadEventUserState As Object) As List(Of rowTblMetaRatingKeyRange)
            Return LoadByIDX_IX_fldKeyId(pcolFldKeyId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_fldKeyId(pcolFldKeyId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaRatingKeyRange)
            Return LoadByIDX_IX_fldKeyId(pcolFldKeyId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_fldKeyId(pcolFldKeyId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaRatingKeyRange)
            Dim zReturn As New List(Of rowTblMetaRatingKeyRange)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaRatingKeyRange] WHERE [fldKeyId] = @colFldKeyId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldKeyId", pcolFldKeyId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function
        Public Shared Function LoadByIDX_IX_fldRating(pcolFldKeyId As Integer, pcolFldRating As String) As List(Of rowTblMetaRatingKeyRange)
            Return LoadByIDX_IX_fldRating(pcolFldKeyId, pcolFldRating, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_fldRating(pcolFldKeyId As Integer, pcolFldRating As String, pLoadEventUserState As Object) As List(Of rowTblMetaRatingKeyRange)
            Return LoadByIDX_IX_fldRating(pcolFldKeyId, pcolFldRating, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_fldRating(pcolFldKeyId As Integer, pcolFldRating As String, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaRatingKeyRange)
            Return LoadByIDX_IX_fldRating(pcolFldKeyId, pcolFldRating, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_fldRating(pcolFldKeyId As Integer, pcolFldRating As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaRatingKeyRange)
            Dim zReturn As New List(Of rowTblMetaRatingKeyRange)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaRatingKeyRange] WHERE [fldKeyId] = @colFldKeyId AND [fldRating] = @colFldRating"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldKeyId", pcolFldKeyId))
            zCmd.Parameters.Add(New SQLParameter("@colFldRating", pcolFldRating))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function
        Public Shared Function LoadByIDX_PK__tblMetaR__36326BE337DCB2AB(pcolFldId As Integer) As List(Of rowTblMetaRatingKeyRange)
            Return LoadByIDX_PK__tblMetaR__36326BE337DCB2AB(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaR__36326BE337DCB2AB(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of rowTblMetaRatingKeyRange)
            Return LoadByIDX_PK__tblMetaR__36326BE337DCB2AB(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaR__36326BE337DCB2AB(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaRatingKeyRange)
            Return LoadByIDX_PK__tblMetaR__36326BE337DCB2AB(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaR__36326BE337DCB2AB(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaRatingKeyRange)
            Dim zReturn As New List(Of rowTblMetaRatingKeyRange)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaRatingKeyRange] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblMetaRatingKeyRange)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblMetaRatingKeyRange)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblMetaRatingKeyRange)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaRatingKeyRange)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaRatingKeyRange)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaRatingKeyRange)
            Dim zReturn As New List(Of rowTblMetaRatingKeyRange)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaRatingKeyRange]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblMetaRatingKeyRange)

			Try
	            Dim zReturn As New List(Of rowTblMetaRatingKeyRange)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblMetaRatingKeyRange

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblMetaRatingKeyRange		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblMetaRatingKeyRange)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldId")) Then pObject.colFldId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldKeyId")) Then pObject.colFldKeyId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldKeyId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldRating")) Then pObject.colFldRating = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldRating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldDescription")) Then pObject.colFldDescription = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldDescription")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldScoreLow")) Then pObject.colFldScoreLow = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "fldScoreLow")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldScoreHigh")) Then pObject.colFldScoreHigh = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "fldScoreHigh")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldMetaColorId")) Then pObject.colFldMetaColorId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldMetaColorId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldPSRatingKey")) Then pObject.colFldPSRatingKey = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldPSRatingKey")
			pObject.SetIsDirty(False)
			Return pObject
		End	 Function

    #Region "Reflection Based Load Functions"

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldId As Integer) As T
            Return LoadByPrimaryKey(Of T)(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldId As Integer, pLoadEventUserState As Object) As T
            Return LoadByPrimaryKey(Of T)(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As T
            Return LoadByPrimaryKey(Of T)(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As T

            Dim zReturn As Object = Activator.CreateInstance(Of T)()
            If Not TypeOf zReturn Is rowTblMetaRatingKeyRange Then Throw New ArgumentException("Generic type is not type of rowTblMetaRatingKeyRange.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaRatingKeyRange] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of T) = ReadData(Of T)(zCmd, pLoadEventUserState)
            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

        End Function

        Public Shared Function LoadByIDX_IX_Range(Of T)(pcolFldKeyId As Integer, pcolFldScoreLow As Double, pcolFldScoreHigh As Double) As List(Of T)
            Return LoadByIDX_IX_Range(Of T)(pcolFldKeyId, pcolFldScoreLow, pcolFldScoreHigh, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_Range(Of T)(pcolFldKeyId As Integer, pcolFldScoreLow As Double, pcolFldScoreHigh As Double, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_IX_Range(Of T)(pcolFldKeyId, pcolFldScoreLow, pcolFldScoreHigh, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_Range(Of T)(pcolFldKeyId As Integer, pcolFldScoreLow As Double, pcolFldScoreHigh As Double, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_IX_Range(Of T)(pcolFldKeyId, pcolFldScoreLow, pcolFldScoreHigh, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_IX_Range(Of T)(pcolFldKeyId As Integer, pcolFldScoreLow As Double, pcolFldScoreHigh As Double, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaRatingKeyRange] WHERE [fldKeyId] = @colFldKeyId AND [fldScoreLow] = @colFldScoreLow AND [fldScoreHigh] = @colFldScoreHigh"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldKeyId", pcolFldKeyId))
            zCmd.Parameters.Add(New SQLParameter("@colFldScoreLow", pcolFldScoreLow))
            zCmd.Parameters.Add(New SQLParameter("@colFldScoreHigh", pcolFldScoreHigh))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_IX_Range_without_KeyId(Of T)(pcolFldScoreLow As Double, pcolFldScoreHigh As Double) As List(Of T)
            Return LoadByIDX_IX_Range_without_KeyId(Of T)(pcolFldScoreLow, pcolFldScoreHigh, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_Range_without_KeyId(Of T)(pcolFldScoreLow As Double, pcolFldScoreHigh As Double, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_IX_Range_without_KeyId(Of T)(pcolFldScoreLow, pcolFldScoreHigh, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_Range_without_KeyId(Of T)(pcolFldScoreLow As Double, pcolFldScoreHigh As Double, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_IX_Range_without_KeyId(Of T)(pcolFldScoreLow, pcolFldScoreHigh, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_IX_Range_without_KeyId(Of T)(pcolFldScoreLow As Double, pcolFldScoreHigh As Double, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaRatingKeyRange] WHERE [fldScoreLow] = @colFldScoreLow AND [fldScoreHigh] = @colFldScoreHigh"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldScoreLow", pcolFldScoreLow))
            zCmd.Parameters.Add(New SQLParameter("@colFldScoreHigh", pcolFldScoreHigh))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_IX_fldKeyID_fldScoreLow_fldScoreHigh(Of T)(pcolFldKeyId As Integer, pcolFldScoreLow As Double, pcolFldScoreHigh As Double) As List(Of T)
            Return LoadByIDX_IX_fldKeyID_fldScoreLow_fldScoreHigh(Of T)(pcolFldKeyId, pcolFldScoreLow, pcolFldScoreHigh, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_fldKeyID_fldScoreLow_fldScoreHigh(Of T)(pcolFldKeyId As Integer, pcolFldScoreLow As Double, pcolFldScoreHigh As Double, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_IX_fldKeyID_fldScoreLow_fldScoreHigh(Of T)(pcolFldKeyId, pcolFldScoreLow, pcolFldScoreHigh, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_fldKeyID_fldScoreLow_fldScoreHigh(Of T)(pcolFldKeyId As Integer, pcolFldScoreLow As Double, pcolFldScoreHigh As Double, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_IX_fldKeyID_fldScoreLow_fldScoreHigh(Of T)(pcolFldKeyId, pcolFldScoreLow, pcolFldScoreHigh, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_IX_fldKeyID_fldScoreLow_fldScoreHigh(Of T)(pcolFldKeyId As Integer, pcolFldScoreLow As Double, pcolFldScoreHigh As Double, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaRatingKeyRange] WHERE [fldKeyId] = @colFldKeyId AND [fldScoreLow] = @colFldScoreLow AND [fldScoreHigh] = @colFldScoreHigh"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldKeyId", pcolFldKeyId))
            zCmd.Parameters.Add(New SQLParameter("@colFldScoreLow", pcolFldScoreLow))
            zCmd.Parameters.Add(New SQLParameter("@colFldScoreHigh", pcolFldScoreHigh))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_IX_fldKeyId(Of T)(pcolFldKeyId As Integer) As List(Of T)
            Return LoadByIDX_IX_fldKeyId(Of T)(pcolFldKeyId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_fldKeyId(Of T)(pcolFldKeyId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_IX_fldKeyId(Of T)(pcolFldKeyId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_fldKeyId(Of T)(pcolFldKeyId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_IX_fldKeyId(Of T)(pcolFldKeyId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_IX_fldKeyId(Of T)(pcolFldKeyId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaRatingKeyRange] WHERE [fldKeyId] = @colFldKeyId"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldKeyId", pcolFldKeyId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_IX_fldRating(Of T)(pcolFldKeyId As Integer, pcolFldRating As String) As List(Of T)
            Return LoadByIDX_IX_fldRating(Of T)(pcolFldKeyId, pcolFldRating, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_fldRating(Of T)(pcolFldKeyId As Integer, pcolFldRating As String, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_IX_fldRating(Of T)(pcolFldKeyId, pcolFldRating, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_fldRating(Of T)(pcolFldKeyId As Integer, pcolFldRating As String, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_IX_fldRating(Of T)(pcolFldKeyId, pcolFldRating, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_IX_fldRating(Of T)(pcolFldKeyId As Integer, pcolFldRating As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaRatingKeyRange] WHERE [fldKeyId] = @colFldKeyId AND [fldRating] = @colFldRating"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldKeyId", pcolFldKeyId))
            zCmd.Parameters.Add(New SQLParameter("@colFldRating", pcolFldRating))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaR__36326BE337DCB2AB(Of T)(pcolFldId As Integer) As List(Of T)
            Return LoadByIDX_PK__tblMetaR__36326BE337DCB2AB(Of T)(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaR__36326BE337DCB2AB(Of T)(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK__tblMetaR__36326BE337DCB2AB(Of T)(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaR__36326BE337DCB2AB(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK__tblMetaR__36326BE337DCB2AB(Of T)(pcolFldId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK__tblMetaR__36326BE337DCB2AB(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaRatingKeyRange] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

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
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaRatingKeyRange]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblMetaRatingKeyRange
        Implements IrowTblMetaRatingKeyRange

        Public Event Loaded(pUserState As Object) Implements IrowTblMetaRatingKeyRange.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblMetaRatingKeyRange.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblMetaRatingKeyRange.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblMetaRatingKeyRange.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblMetaRatingKeyRange.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblMetaRatingKeyRange.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldId() As Nullable(Of Integer) Implements IrowTblMetaRatingKeyRange.colFldId
            Get
                Return m_colFldId
            End Get
            Set
                If Not Same(m_colFldId, Value) Then
                    m_colFldId = Value
                    m_IsDirty(FieldIndex.colFldId) = True
                End If
            End Set
        End Property
        Private m_colFldId As Nullable(Of Integer)

        Public Property colFldKeyId() As Nullable(Of Integer) Implements IrowTblMetaRatingKeyRange.colFldKeyId
            Get
                Return m_colFldKeyId
            End Get
            Set
                If Not Same(m_colFldKeyId, Value) Then
                    m_colFldKeyId = Value
                    m_IsDirty(FieldIndex.colFldKeyId) = True
                End If
            End Set
        End Property
        Private m_colFldKeyId As Nullable(Of Integer)

        Public Property colFldRating() As String Implements IrowTblMetaRatingKeyRange.colFldRating
            Get
                Return m_colFldRating
            End Get
            Set
                If Not Same(m_colFldRating, Value) Then
                    m_colFldRating = Value
                    m_IsDirty(FieldIndex.colFldRating) = True
                End If
            End Set
        End Property
        Private m_colFldRating As String

        Public Property colFldDescription() As String Implements IrowTblMetaRatingKeyRange.colFldDescription
            Get
                Return m_colFldDescription
            End Get
            Set
                If Not Same(m_colFldDescription, Value) Then
                    m_colFldDescription = Value
                    m_IsDirty(FieldIndex.colFldDescription) = True
                End If
            End Set
        End Property
        Private m_colFldDescription As String

        Public Property colFldScoreLow() As Nullable(Of Double) Implements IrowTblMetaRatingKeyRange.colFldScoreLow
            Get
                Return m_colFldScoreLow
            End Get
            Set
                If Not Same(m_colFldScoreLow, Value) Then
                    m_colFldScoreLow = Value
                    m_IsDirty(FieldIndex.colFldScoreLow) = True
                End If
            End Set
        End Property
        Private m_colFldScoreLow As Nullable(Of Double)

        Public Property colFldScoreHigh() As Nullable(Of Double) Implements IrowTblMetaRatingKeyRange.colFldScoreHigh
            Get
                Return m_colFldScoreHigh
            End Get
            Set
                If Not Same(m_colFldScoreHigh, Value) Then
                    m_colFldScoreHigh = Value
                    m_IsDirty(FieldIndex.colFldScoreHigh) = True
                End If
            End Set
        End Property
        Private m_colFldScoreHigh As Nullable(Of Double)

        Public Property colFldMetaColorId() As Nullable(Of Integer) Implements IrowTblMetaRatingKeyRange.colFldMetaColorId
            Get
                Return m_colFldMetaColorId
            End Get
            Set
                If Not Same(m_colFldMetaColorId, Value) Then
                    m_colFldMetaColorId = Value
                    m_IsDirty(FieldIndex.colFldMetaColorId) = True
                End If
            End Set
        End Property
        Private m_colFldMetaColorId As Nullable(Of Integer)

        Public Property colFldPSRatingKey() As String Implements IrowTblMetaRatingKeyRange.colFldPSRatingKey
            Get
                Return m_colFldPSRatingKey
            End Get
            Set
                If Not Same(m_colFldPSRatingKey, Value) Then
                    m_colFldPSRatingKey = Value
                    m_IsDirty(FieldIndex.colFldPSRatingKey) = True
                End If
            End Set
        End Property
        Private m_colFldPSRatingKey As String


        Public Function IsDirty(pIndex As rowTblMetaRatingKeyRange.FieldIndex) As Boolean Implements IrowTblMetaRatingKeyRange.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblMetaRatingKeyRange.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblMetaRatingKeyRange.SetIsDirty
            m_IsDirty(FieldIndex.colFldId) = pDirty
            m_IsDirty(FieldIndex.colFldKeyId) = pDirty
            m_IsDirty(FieldIndex.colFldRating) = pDirty
            m_IsDirty(FieldIndex.colFldDescription) = pDirty
            m_IsDirty(FieldIndex.colFldScoreLow) = pDirty
            m_IsDirty(FieldIndex.colFldScoreHigh) = pDirty
            m_IsDirty(FieldIndex.colFldMetaColorId) = pDirty
            m_IsDirty(FieldIndex.colFldPSRatingKey) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblMetaRatingKeyRange) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblMetaRatingKeyRange
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldId  = 1
            colFldKeyId 
            colFldRating 
            colFldDescription 
            colFldScoreLow 
            colFldScoreHigh 
            colFldMetaColorId 
            colFldPSRatingKey 
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

    Public Interface IrowTblMetaRatingKeyRange
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldId() As Nullable(Of Integer)
        Property colFldKeyId() As Nullable(Of Integer)
        Property colFldRating() As String
        Property colFldDescription() As String
        Property colFldScoreLow() As Nullable(Of Double)
        Property colFldScoreHigh() As Nullable(Of Double)
        Property colFldMetaColorId() As Nullable(Of Integer)
        Property colFldPSRatingKey() As String
        Function IsDirty(pIndex As rowTblMetaRatingKeyRange.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

