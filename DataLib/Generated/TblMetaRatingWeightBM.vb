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
    Partial Public Class TblMetaRatingWeightBM

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaRatingWeightBM)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaRatingWeightBM, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaRatingWeightBM, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaRatingWeightBM, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[tblMetaRatingWeightBM] " & _
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
        Dim zObj As rowTblMetaRatingWeightBM = LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblMetaRatingWeightBM)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaRatingWeightBM, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaRatingWeightBM, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[tblMetaRatingWeightBM] WHERE [fldId] = @colFldId"

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
                        zUpdate = "UPDATE [dbo].[tblMetaRatingWeightBM] SET " 
                        If pRowData.IsDirty(rowTblMetaRatingWeightBM.FieldIndex.colFldMechMaintWgt) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldMechMaintWgt] = @colFldMechMaintWgt "
                        End If
                        If pRowData.IsDirty(rowTblMetaRatingWeightBM.FieldIndex.colFldElecMaintWgt) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldElecMaintWgt] = @colFldElecMaintWgt "
                        End If
                        If pRowData.IsDirty(rowTblMetaRatingWeightBM.FieldIndex.colFldSparesWgt) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldSparesWgt] = @colFldSparesWgt "
                        End If
                        If pRowData.IsDirty(rowTblMetaRatingWeightBM.FieldIndex.colFldHEWgt) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldHEWgt] = @colFldHEWgt "
                        End If
                        If pRowData.IsDirty(rowTblMetaRatingWeightBM.FieldIndex.colFldBCPWgt) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldBCPWgt] = @colFldBCPWgt "
                        End If
                        If pRowData.IsDirty(rowTblMetaRatingWeightBM.FieldIndex.colFldMechEquipWgt) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldMechEquipWgt] = @colFldMechEquipWgt "
                        End If
                        If pRowData.IsDirty(rowTblMetaRatingWeightBM.FieldIndex.colFldElecEquipWgt) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldElecEquipWgt] = @colFldElecEquipWgt "
                        End If
                        If pRowData.IsDirty(rowTblMetaRatingWeightBM.FieldIndex.colFldBoilersWgt) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldBoilersWgt] = @colFldBoilersWgt "
                        End If
                        If pRowData.IsDirty(rowTblMetaRatingWeightBM.FieldIndex.colFldProcEquipWgt) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldProcEquipWgt] = @colFldProcEquipWgt "
                        End If
                        If pRowData.IsDirty(rowTblMetaRatingWeightBM.FieldIndex.colFldOccupancyWgt) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldOccupancyWgt] = @colFldOccupancyWgt "
                        End If
                        If pRowData.IsDirty(rowTblMetaRatingWeightBM.FieldIndex.colFldCompSystemWgt) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldCompSystemWgt] = @colFldCompSystemWgt "
                        End If
                        zWhere = " WHERE [fldId] = @colFldId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaRatingWeightBM] ([fldMechMaintWgt], [fldElecMaintWgt], [fldSparesWgt], [fldHEWgt], [fldBCPWgt], [fldMechEquipWgt], [fldElecEquipWgt], [fldBoilersWgt], [fldProcEquipWgt], [fldOccupancyWgt], [fldCompSystemWgt])" & _
                            " VALUES (@colFldMechMaintWgt, @colFldElecMaintWgt, @colFldSparesWgt, @colFldHEWgt, @colFldBCPWgt, @colFldMechEquipWgt, @colFldElecEquipWgt, @colFldBoilersWgt, @colFldProcEquipWgt, @colFldOccupancyWgt, @colFldCompSystemWgt); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaRatingWeightBM] ([fldMechMaintWgt], [fldElecMaintWgt], [fldSparesWgt], [fldHEWgt], [fldBCPWgt], [fldMechEquipWgt], [fldElecEquipWgt], [fldBoilersWgt], [fldProcEquipWgt], [fldOccupancyWgt], [fldCompSystemWgt])" & _
                            " VALUES (@colFldMechMaintWgt, @colFldElecMaintWgt, @colFldSparesWgt, @colFldHEWgt, @colFldBCPWgt, @colFldMechEquipWgt, @colFldElecEquipWgt, @colFldBoilersWgt, @colFldProcEquipWgt, @colFldOccupancyWgt, @colFldCompSystemWgt); SELECT SCOPE_IDENTITY()"
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

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaRatingWeightBM.FieldIndex.colFldMechMaintWgt) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldMechMaintWgt", IIf(pRowData.colFldMechMaintWgt Is Nothing, DBNull.Value, pRowData.colFldMechMaintWgt)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaRatingWeightBM.FieldIndex.colFldElecMaintWgt) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldElecMaintWgt", IIf(pRowData.colFldElecMaintWgt Is Nothing, DBNull.Value, pRowData.colFldElecMaintWgt)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaRatingWeightBM.FieldIndex.colFldSparesWgt) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldSparesWgt", IIf(pRowData.colFldSparesWgt Is Nothing, DBNull.Value, pRowData.colFldSparesWgt)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaRatingWeightBM.FieldIndex.colFldHEWgt) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldHEWgt", IIf(pRowData.colFldHEWgt Is Nothing, DBNull.Value, pRowData.colFldHEWgt)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaRatingWeightBM.FieldIndex.colFldBCPWgt) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldBCPWgt", IIf(pRowData.colFldBCPWgt Is Nothing, DBNull.Value, pRowData.colFldBCPWgt)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaRatingWeightBM.FieldIndex.colFldMechEquipWgt) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldMechEquipWgt", IIf(pRowData.colFldMechEquipWgt Is Nothing, DBNull.Value, pRowData.colFldMechEquipWgt)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaRatingWeightBM.FieldIndex.colFldElecEquipWgt) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldElecEquipWgt", IIf(pRowData.colFldElecEquipWgt Is Nothing, DBNull.Value, pRowData.colFldElecEquipWgt)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaRatingWeightBM.FieldIndex.colFldBoilersWgt) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldBoilersWgt", IIf(pRowData.colFldBoilersWgt Is Nothing, DBNull.Value, pRowData.colFldBoilersWgt)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaRatingWeightBM.FieldIndex.colFldProcEquipWgt) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldProcEquipWgt", IIf(pRowData.colFldProcEquipWgt Is Nothing, DBNull.Value, pRowData.colFldProcEquipWgt)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaRatingWeightBM.FieldIndex.colFldOccupancyWgt) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldOccupancyWgt", IIf(pRowData.colFldOccupancyWgt Is Nothing, DBNull.Value, pRowData.colFldOccupancyWgt)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaRatingWeightBM.FieldIndex.colFldCompSystemWgt) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldCompSystemWgt", IIf(pRowData.colFldCompSystemWgt Is Nothing, DBNull.Value, pRowData.colFldCompSystemWgt)))
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

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer) As rowTblMetaRatingWeightBM
            Return LoadByPrimaryKey(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pLoadEventUserState As Object) As rowTblMetaRatingWeightBM
            Return LoadByPrimaryKey(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblMetaRatingWeightBM
            Return LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblMetaRatingWeightBM
            Dim zReturn As New rowTblMetaRatingWeightBM
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaRatingWeightBM] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblMetaRatingWeightBM) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK__tblMetaR__36326BE33BAD438F(pcolFldId As Integer) As List(Of rowTblMetaRatingWeightBM)
            Return LoadByIDX_PK__tblMetaR__36326BE33BAD438F(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaR__36326BE33BAD438F(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of rowTblMetaRatingWeightBM)
            Return LoadByIDX_PK__tblMetaR__36326BE33BAD438F(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaR__36326BE33BAD438F(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaRatingWeightBM)
            Return LoadByIDX_PK__tblMetaR__36326BE33BAD438F(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaR__36326BE33BAD438F(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaRatingWeightBM)
            Dim zReturn As New List(Of rowTblMetaRatingWeightBM)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaRatingWeightBM] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblMetaRatingWeightBM)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblMetaRatingWeightBM)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblMetaRatingWeightBM)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaRatingWeightBM)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaRatingWeightBM)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaRatingWeightBM)
            Dim zReturn As New List(Of rowTblMetaRatingWeightBM)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaRatingWeightBM]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblMetaRatingWeightBM)

			Try
	            Dim zReturn As New List(Of rowTblMetaRatingWeightBM)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblMetaRatingWeightBM

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblMetaRatingWeightBM		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblMetaRatingWeightBM)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldId")) Then pObject.colFldId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldMechMaintWgt")) Then pObject.colFldMechMaintWgt = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "fldMechMaintWgt")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldElecMaintWgt")) Then pObject.colFldElecMaintWgt = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "fldElecMaintWgt")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSparesWgt")) Then pObject.colFldSparesWgt = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "fldSparesWgt")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldHEWgt")) Then pObject.colFldHEWgt = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "fldHEWgt")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldBCPWgt")) Then pObject.colFldBCPWgt = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "fldBCPWgt")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldMechEquipWgt")) Then pObject.colFldMechEquipWgt = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "fldMechEquipWgt")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldElecEquipWgt")) Then pObject.colFldElecEquipWgt = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "fldElecEquipWgt")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldBoilersWgt")) Then pObject.colFldBoilersWgt = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "fldBoilersWgt")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldProcEquipWgt")) Then pObject.colFldProcEquipWgt = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "fldProcEquipWgt")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldOccupancyWgt")) Then pObject.colFldOccupancyWgt = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "fldOccupancyWgt")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldCompSystemWgt")) Then pObject.colFldCompSystemWgt = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "fldCompSystemWgt")
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
            If Not TypeOf zReturn Is rowTblMetaRatingWeightBM Then Throw New ArgumentException("Generic type is not type of rowTblMetaRatingWeightBM.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaRatingWeightBM] WHERE [fldId] = @colFldId"
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

        Public Shared Function LoadByIDX_PK__tblMetaR__36326BE33BAD438F(Of T)(pcolFldId As Integer) As List(Of T)
            Return LoadByIDX_PK__tblMetaR__36326BE33BAD438F(Of T)(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaR__36326BE33BAD438F(Of T)(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK__tblMetaR__36326BE33BAD438F(Of T)(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaR__36326BE33BAD438F(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK__tblMetaR__36326BE33BAD438F(Of T)(pcolFldId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK__tblMetaR__36326BE33BAD438F(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaRatingWeightBM] WHERE [fldId] = @colFldId"
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
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaRatingWeightBM]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblMetaRatingWeightBM
        Implements IrowTblMetaRatingWeightBM

        Public Event Loaded(pUserState As Object) Implements IrowTblMetaRatingWeightBM.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblMetaRatingWeightBM.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblMetaRatingWeightBM.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblMetaRatingWeightBM.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblMetaRatingWeightBM.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblMetaRatingWeightBM.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldId() As Nullable(Of Integer) Implements IrowTblMetaRatingWeightBM.colFldId
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

        Public Property colFldMechMaintWgt() As Nullable(Of Double) Implements IrowTblMetaRatingWeightBM.colFldMechMaintWgt
            Get
                Return m_colFldMechMaintWgt
            End Get
            Set
                If Not Same(m_colFldMechMaintWgt, Value) Then
                    m_colFldMechMaintWgt = Value
                    m_IsDirty(FieldIndex.colFldMechMaintWgt) = True
                End If
            End Set
        End Property
        Private m_colFldMechMaintWgt As Nullable(Of Double)

        Public Property colFldElecMaintWgt() As Nullable(Of Double) Implements IrowTblMetaRatingWeightBM.colFldElecMaintWgt
            Get
                Return m_colFldElecMaintWgt
            End Get
            Set
                If Not Same(m_colFldElecMaintWgt, Value) Then
                    m_colFldElecMaintWgt = Value
                    m_IsDirty(FieldIndex.colFldElecMaintWgt) = True
                End If
            End Set
        End Property
        Private m_colFldElecMaintWgt As Nullable(Of Double)

        Public Property colFldSparesWgt() As Nullable(Of Double) Implements IrowTblMetaRatingWeightBM.colFldSparesWgt
            Get
                Return m_colFldSparesWgt
            End Get
            Set
                If Not Same(m_colFldSparesWgt, Value) Then
                    m_colFldSparesWgt = Value
                    m_IsDirty(FieldIndex.colFldSparesWgt) = True
                End If
            End Set
        End Property
        Private m_colFldSparesWgt As Nullable(Of Double)

        Public Property colFldHEWgt() As Nullable(Of Double) Implements IrowTblMetaRatingWeightBM.colFldHEWgt
            Get
                Return m_colFldHEWgt
            End Get
            Set
                If Not Same(m_colFldHEWgt, Value) Then
                    m_colFldHEWgt = Value
                    m_IsDirty(FieldIndex.colFldHEWgt) = True
                End If
            End Set
        End Property
        Private m_colFldHEWgt As Nullable(Of Double)

        Public Property colFldBCPWgt() As Nullable(Of Double) Implements IrowTblMetaRatingWeightBM.colFldBCPWgt
            Get
                Return m_colFldBCPWgt
            End Get
            Set
                If Not Same(m_colFldBCPWgt, Value) Then
                    m_colFldBCPWgt = Value
                    m_IsDirty(FieldIndex.colFldBCPWgt) = True
                End If
            End Set
        End Property
        Private m_colFldBCPWgt As Nullable(Of Double)

        Public Property colFldMechEquipWgt() As Nullable(Of Double) Implements IrowTblMetaRatingWeightBM.colFldMechEquipWgt
            Get
                Return m_colFldMechEquipWgt
            End Get
            Set
                If Not Same(m_colFldMechEquipWgt, Value) Then
                    m_colFldMechEquipWgt = Value
                    m_IsDirty(FieldIndex.colFldMechEquipWgt) = True
                End If
            End Set
        End Property
        Private m_colFldMechEquipWgt As Nullable(Of Double)

        Public Property colFldElecEquipWgt() As Nullable(Of Double) Implements IrowTblMetaRatingWeightBM.colFldElecEquipWgt
            Get
                Return m_colFldElecEquipWgt
            End Get
            Set
                If Not Same(m_colFldElecEquipWgt, Value) Then
                    m_colFldElecEquipWgt = Value
                    m_IsDirty(FieldIndex.colFldElecEquipWgt) = True
                End If
            End Set
        End Property
        Private m_colFldElecEquipWgt As Nullable(Of Double)

        Public Property colFldBoilersWgt() As Nullable(Of Double) Implements IrowTblMetaRatingWeightBM.colFldBoilersWgt
            Get
                Return m_colFldBoilersWgt
            End Get
            Set
                If Not Same(m_colFldBoilersWgt, Value) Then
                    m_colFldBoilersWgt = Value
                    m_IsDirty(FieldIndex.colFldBoilersWgt) = True
                End If
            End Set
        End Property
        Private m_colFldBoilersWgt As Nullable(Of Double)

        Public Property colFldProcEquipWgt() As Nullable(Of Double) Implements IrowTblMetaRatingWeightBM.colFldProcEquipWgt
            Get
                Return m_colFldProcEquipWgt
            End Get
            Set
                If Not Same(m_colFldProcEquipWgt, Value) Then
                    m_colFldProcEquipWgt = Value
                    m_IsDirty(FieldIndex.colFldProcEquipWgt) = True
                End If
            End Set
        End Property
        Private m_colFldProcEquipWgt As Nullable(Of Double)

        Public Property colFldOccupancyWgt() As Nullable(Of Double) Implements IrowTblMetaRatingWeightBM.colFldOccupancyWgt
            Get
                Return m_colFldOccupancyWgt
            End Get
            Set
                If Not Same(m_colFldOccupancyWgt, Value) Then
                    m_colFldOccupancyWgt = Value
                    m_IsDirty(FieldIndex.colFldOccupancyWgt) = True
                End If
            End Set
        End Property
        Private m_colFldOccupancyWgt As Nullable(Of Double)

        Public Property colFldCompSystemWgt() As Nullable(Of Double) Implements IrowTblMetaRatingWeightBM.colFldCompSystemWgt
            Get
                Return m_colFldCompSystemWgt
            End Get
            Set
                If Not Same(m_colFldCompSystemWgt, Value) Then
                    m_colFldCompSystemWgt = Value
                    m_IsDirty(FieldIndex.colFldCompSystemWgt) = True
                End If
            End Set
        End Property
        Private m_colFldCompSystemWgt As Nullable(Of Double)


        Public Function IsDirty(pIndex As rowTblMetaRatingWeightBM.FieldIndex) As Boolean Implements IrowTblMetaRatingWeightBM.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblMetaRatingWeightBM.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblMetaRatingWeightBM.SetIsDirty
            m_IsDirty(FieldIndex.colFldId) = pDirty
            m_IsDirty(FieldIndex.colFldMechMaintWgt) = pDirty
            m_IsDirty(FieldIndex.colFldElecMaintWgt) = pDirty
            m_IsDirty(FieldIndex.colFldSparesWgt) = pDirty
            m_IsDirty(FieldIndex.colFldHEWgt) = pDirty
            m_IsDirty(FieldIndex.colFldBCPWgt) = pDirty
            m_IsDirty(FieldIndex.colFldMechEquipWgt) = pDirty
            m_IsDirty(FieldIndex.colFldElecEquipWgt) = pDirty
            m_IsDirty(FieldIndex.colFldBoilersWgt) = pDirty
            m_IsDirty(FieldIndex.colFldProcEquipWgt) = pDirty
            m_IsDirty(FieldIndex.colFldOccupancyWgt) = pDirty
            m_IsDirty(FieldIndex.colFldCompSystemWgt) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblMetaRatingWeightBM) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblMetaRatingWeightBM
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldId  = 1
            colFldMechMaintWgt 
            colFldElecMaintWgt 
            colFldSparesWgt 
            colFldHEWgt 
            colFldBCPWgt 
            colFldMechEquipWgt 
            colFldElecEquipWgt 
            colFldBoilersWgt 
            colFldProcEquipWgt 
            colFldOccupancyWgt 
            colFldCompSystemWgt 
        End Enum

        Private m_IsDirty(12) As Boolean

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

    Public Interface IrowTblMetaRatingWeightBM
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldId() As Nullable(Of Integer)
        Property colFldMechMaintWgt() As Nullable(Of Double)
        Property colFldElecMaintWgt() As Nullable(Of Double)
        Property colFldSparesWgt() As Nullable(Of Double)
        Property colFldHEWgt() As Nullable(Of Double)
        Property colFldBCPWgt() As Nullable(Of Double)
        Property colFldMechEquipWgt() As Nullable(Of Double)
        Property colFldElecEquipWgt() As Nullable(Of Double)
        Property colFldBoilersWgt() As Nullable(Of Double)
        Property colFldProcEquipWgt() As Nullable(Of Double)
        Property colFldOccupancyWgt() As Nullable(Of Double)
        Property colFldCompSystemWgt() As Nullable(Of Double)
        Function IsDirty(pIndex As rowTblMetaRatingWeightBM.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

