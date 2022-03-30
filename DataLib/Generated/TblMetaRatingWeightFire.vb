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
    Partial Public Class TblMetaRatingWeightFire

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaRatingWeightFire)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaRatingWeightFire, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaRatingWeightFire, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaRatingWeightFire, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[tblMetaRatingWeightFire] " & _
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
        Dim zObj As rowTblMetaRatingWeightFire = LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblMetaRatingWeightFire)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaRatingWeightFire, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaRatingWeightFire, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[tblMetaRatingWeightFire] WHERE [fldId] = @colFldId"

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
                        zUpdate = "UPDATE [dbo].[tblMetaRatingWeightFire] SET " 
                        If pRowData.IsDirty(rowTblMetaRatingWeightFire.FieldIndex.colFldPhysicalProtectionWeightGRC) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldPhysicalProtectionWeightGRC] = @colFldPhysicalProtectionWeightGRC "
                        End If
                        If pRowData.IsDirty(rowTblMetaRatingWeightFire.FieldIndex.colFldHumanElementWeightGRC) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldHumanElementWeightGRC] = @colFldHumanElementWeightGRC "
                        End If
                        If pRowData.IsDirty(rowTblMetaRatingWeightFire.FieldIndex.colFldNaturalHazardsProtectionWeightGRC) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldNaturalHazardsProtectionWeightGRC] = @colFldNaturalHazardsProtectionWeightGRC "
                        End If
                        If pRowData.IsDirty(rowTblMetaRatingWeightFire.FieldIndex.colFldBusinessContinuityWeightGRC) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldBusinessContinuityWeightGRC] = @colFldBusinessContinuityWeightGRC "
                        End If
                        If pRowData.IsDirty(rowTblMetaRatingWeightFire.FieldIndex.colFldFloodWeightGRC) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldFloodWeightGRC] = @colFldFloodWeightGRC "
                        End If
                        If pRowData.IsDirty(rowTblMetaRatingWeightFire.FieldIndex.colFldEarthquakeWeightGRC) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldEarthquakeWeightGRC] = @colFldEarthquakeWeightGRC "
                        End If
                        If pRowData.IsDirty(rowTblMetaRatingWeightFire.FieldIndex.colFldWindstormWeightGRC) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldWindstormWeightGRC] = @colFldWindstormWeightGRC "
                        End If
                        If pRowData.IsDirty(rowTblMetaRatingWeightFire.FieldIndex.colFldConstructionWeightGRC) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldConstructionWeightGRC] = @colFldConstructionWeightGRC "
                        End If
                        If pRowData.IsDirty(rowTblMetaRatingWeightFire.FieldIndex.colFldOccupancyWeightGRC) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldOccupancyWeightGRC] = @colFldOccupancyWeightGRC "
                        End If
                        If pRowData.IsDirty(rowTblMetaRatingWeightFire.FieldIndex.colFldOtherWeightGRC) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldOtherWeightGRC] = @colFldOtherWeightGRC "
                        End If
                        zWhere = " WHERE [fldId] = @colFldId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaRatingWeightFire] ([fldPhysicalProtectionWeightGRC], [fldHumanElementWeightGRC], [fldNaturalHazardsProtectionWeightGRC], [fldBusinessContinuityWeightGRC], [fldFloodWeightGRC], [fldEarthquakeWeightGRC], [fldWindstormWeightGRC], [fldConstructionWeightGRC], [fldOccupancyWeightGRC], [fldOtherWeightGRC])" & _
                            " VALUES (@colFldPhysicalProtectionWeightGRC, @colFldHumanElementWeightGRC, @colFldNaturalHazardsProtectionWeightGRC, @colFldBusinessContinuityWeightGRC, @colFldFloodWeightGRC, @colFldEarthquakeWeightGRC, @colFldWindstormWeightGRC, @colFldConstructionWeightGRC, @colFldOccupancyWeightGRC, @colFldOtherWeightGRC); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaRatingWeightFire] ([fldPhysicalProtectionWeightGRC], [fldHumanElementWeightGRC], [fldNaturalHazardsProtectionWeightGRC], [fldBusinessContinuityWeightGRC], [fldFloodWeightGRC], [fldEarthquakeWeightGRC], [fldWindstormWeightGRC], [fldConstructionWeightGRC], [fldOccupancyWeightGRC], [fldOtherWeightGRC])" & _
                            " VALUES (@colFldPhysicalProtectionWeightGRC, @colFldHumanElementWeightGRC, @colFldNaturalHazardsProtectionWeightGRC, @colFldBusinessContinuityWeightGRC, @colFldFloodWeightGRC, @colFldEarthquakeWeightGRC, @colFldWindstormWeightGRC, @colFldConstructionWeightGRC, @colFldOccupancyWeightGRC, @colFldOtherWeightGRC); SELECT SCOPE_IDENTITY()"
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

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaRatingWeightFire.FieldIndex.colFldPhysicalProtectionWeightGRC) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldPhysicalProtectionWeightGRC", IIf(pRowData.colFldPhysicalProtectionWeightGRC Is Nothing, DBNull.Value, pRowData.colFldPhysicalProtectionWeightGRC)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaRatingWeightFire.FieldIndex.colFldHumanElementWeightGRC) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldHumanElementWeightGRC", IIf(pRowData.colFldHumanElementWeightGRC Is Nothing, DBNull.Value, pRowData.colFldHumanElementWeightGRC)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaRatingWeightFire.FieldIndex.colFldNaturalHazardsProtectionWeightGRC) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldNaturalHazardsProtectionWeightGRC", IIf(pRowData.colFldNaturalHazardsProtectionWeightGRC Is Nothing, DBNull.Value, pRowData.colFldNaturalHazardsProtectionWeightGRC)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaRatingWeightFire.FieldIndex.colFldBusinessContinuityWeightGRC) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldBusinessContinuityWeightGRC", IIf(pRowData.colFldBusinessContinuityWeightGRC Is Nothing, DBNull.Value, pRowData.colFldBusinessContinuityWeightGRC)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaRatingWeightFire.FieldIndex.colFldFloodWeightGRC) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldFloodWeightGRC", IIf(pRowData.colFldFloodWeightGRC Is Nothing, DBNull.Value, pRowData.colFldFloodWeightGRC)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaRatingWeightFire.FieldIndex.colFldEarthquakeWeightGRC) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldEarthquakeWeightGRC", IIf(pRowData.colFldEarthquakeWeightGRC Is Nothing, DBNull.Value, pRowData.colFldEarthquakeWeightGRC)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaRatingWeightFire.FieldIndex.colFldWindstormWeightGRC) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldWindstormWeightGRC", IIf(pRowData.colFldWindstormWeightGRC Is Nothing, DBNull.Value, pRowData.colFldWindstormWeightGRC)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaRatingWeightFire.FieldIndex.colFldConstructionWeightGRC) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldConstructionWeightGRC", IIf(pRowData.colFldConstructionWeightGRC Is Nothing, DBNull.Value, pRowData.colFldConstructionWeightGRC)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaRatingWeightFire.FieldIndex.colFldOccupancyWeightGRC) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldOccupancyWeightGRC", IIf(pRowData.colFldOccupancyWeightGRC Is Nothing, DBNull.Value, pRowData.colFldOccupancyWeightGRC)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaRatingWeightFire.FieldIndex.colFldOtherWeightGRC) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldOtherWeightGRC", IIf(pRowData.colFldOtherWeightGRC Is Nothing, DBNull.Value, pRowData.colFldOtherWeightGRC)))
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

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer) As rowTblMetaRatingWeightFire
            Return LoadByPrimaryKey(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pLoadEventUserState As Object) As rowTblMetaRatingWeightFire
            Return LoadByPrimaryKey(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblMetaRatingWeightFire
            Return LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblMetaRatingWeightFire
            Dim zReturn As New rowTblMetaRatingWeightFire
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaRatingWeightFire] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblMetaRatingWeightFire) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK_tblMetaRatingWeightFire(pcolFldId As Integer) As List(Of rowTblMetaRatingWeightFire)
            Return LoadByIDX_PK_tblMetaRatingWeightFire(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaRatingWeightFire(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of rowTblMetaRatingWeightFire)
            Return LoadByIDX_PK_tblMetaRatingWeightFire(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaRatingWeightFire(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaRatingWeightFire)
            Return LoadByIDX_PK_tblMetaRatingWeightFire(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaRatingWeightFire(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaRatingWeightFire)
            Dim zReturn As New List(Of rowTblMetaRatingWeightFire)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaRatingWeightFire] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblMetaRatingWeightFire)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblMetaRatingWeightFire)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblMetaRatingWeightFire)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaRatingWeightFire)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaRatingWeightFire)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaRatingWeightFire)
            Dim zReturn As New List(Of rowTblMetaRatingWeightFire)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaRatingWeightFire]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblMetaRatingWeightFire)

			Try
	            Dim zReturn As New List(Of rowTblMetaRatingWeightFire)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblMetaRatingWeightFire

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblMetaRatingWeightFire		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblMetaRatingWeightFire)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldId")) Then pObject.colFldId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldPhysicalProtectionWeightGRC")) Then pObject.colFldPhysicalProtectionWeightGRC = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "fldPhysicalProtectionWeightGRC")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldHumanElementWeightGRC")) Then pObject.colFldHumanElementWeightGRC = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "fldHumanElementWeightGRC")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldNaturalHazardsProtectionWeightGRC")) Then pObject.colFldNaturalHazardsProtectionWeightGRC = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "fldNaturalHazardsProtectionWeightGRC")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldBusinessContinuityWeightGRC")) Then pObject.colFldBusinessContinuityWeightGRC = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "fldBusinessContinuityWeightGRC")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFloodWeightGRC")) Then pObject.colFldFloodWeightGRC = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "fldFloodWeightGRC")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldEarthquakeWeightGRC")) Then pObject.colFldEarthquakeWeightGRC = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "fldEarthquakeWeightGRC")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldWindstormWeightGRC")) Then pObject.colFldWindstormWeightGRC = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "fldWindstormWeightGRC")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldConstructionWeightGRC")) Then pObject.colFldConstructionWeightGRC = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "fldConstructionWeightGRC")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldOccupancyWeightGRC")) Then pObject.colFldOccupancyWeightGRC = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "fldOccupancyWeightGRC")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldOtherWeightGRC")) Then pObject.colFldOtherWeightGRC = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "fldOtherWeightGRC")
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
            If Not TypeOf zReturn Is rowTblMetaRatingWeightFire Then Throw New ArgumentException("Generic type is not type of rowTblMetaRatingWeightFire.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaRatingWeightFire] WHERE [fldId] = @colFldId"
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

        Public Shared Function LoadByIDX_PK_tblMetaRatingWeightFire(Of T)(pcolFldId As Integer) As List(Of T)
            Return LoadByIDX_PK_tblMetaRatingWeightFire(Of T)(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaRatingWeightFire(Of T)(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK_tblMetaRatingWeightFire(Of T)(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaRatingWeightFire(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK_tblMetaRatingWeightFire(Of T)(pcolFldId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK_tblMetaRatingWeightFire(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaRatingWeightFire] WHERE [fldId] = @colFldId"
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
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaRatingWeightFire]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblMetaRatingWeightFire
        Implements IrowTblMetaRatingWeightFire

        Public Event Loaded(pUserState As Object) Implements IrowTblMetaRatingWeightFire.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblMetaRatingWeightFire.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblMetaRatingWeightFire.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblMetaRatingWeightFire.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblMetaRatingWeightFire.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblMetaRatingWeightFire.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldId() As Nullable(Of Integer) Implements IrowTblMetaRatingWeightFire.colFldId
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

        Public Property colFldPhysicalProtectionWeightGRC() As Nullable(Of Double) Implements IrowTblMetaRatingWeightFire.colFldPhysicalProtectionWeightGRC
            Get
                Return m_colFldPhysicalProtectionWeightGRC
            End Get
            Set
                If Not Same(m_colFldPhysicalProtectionWeightGRC, Value) Then
                    m_colFldPhysicalProtectionWeightGRC = Value
                    m_IsDirty(FieldIndex.colFldPhysicalProtectionWeightGRC) = True
                End If
            End Set
        End Property
        Private m_colFldPhysicalProtectionWeightGRC As Nullable(Of Double)

        Public Property colFldHumanElementWeightGRC() As Nullable(Of Double) Implements IrowTblMetaRatingWeightFire.colFldHumanElementWeightGRC
            Get
                Return m_colFldHumanElementWeightGRC
            End Get
            Set
                If Not Same(m_colFldHumanElementWeightGRC, Value) Then
                    m_colFldHumanElementWeightGRC = Value
                    m_IsDirty(FieldIndex.colFldHumanElementWeightGRC) = True
                End If
            End Set
        End Property
        Private m_colFldHumanElementWeightGRC As Nullable(Of Double)

        Public Property colFldNaturalHazardsProtectionWeightGRC() As Nullable(Of Double) Implements IrowTblMetaRatingWeightFire.colFldNaturalHazardsProtectionWeightGRC
            Get
                Return m_colFldNaturalHazardsProtectionWeightGRC
            End Get
            Set
                If Not Same(m_colFldNaturalHazardsProtectionWeightGRC, Value) Then
                    m_colFldNaturalHazardsProtectionWeightGRC = Value
                    m_IsDirty(FieldIndex.colFldNaturalHazardsProtectionWeightGRC) = True
                End If
            End Set
        End Property
        Private m_colFldNaturalHazardsProtectionWeightGRC As Nullable(Of Double)

        Public Property colFldBusinessContinuityWeightGRC() As Nullable(Of Double) Implements IrowTblMetaRatingWeightFire.colFldBusinessContinuityWeightGRC
            Get
                Return m_colFldBusinessContinuityWeightGRC
            End Get
            Set
                If Not Same(m_colFldBusinessContinuityWeightGRC, Value) Then
                    m_colFldBusinessContinuityWeightGRC = Value
                    m_IsDirty(FieldIndex.colFldBusinessContinuityWeightGRC) = True
                End If
            End Set
        End Property
        Private m_colFldBusinessContinuityWeightGRC As Nullable(Of Double)

        Public Property colFldFloodWeightGRC() As Nullable(Of Double) Implements IrowTblMetaRatingWeightFire.colFldFloodWeightGRC
            Get
                Return m_colFldFloodWeightGRC
            End Get
            Set
                If Not Same(m_colFldFloodWeightGRC, Value) Then
                    m_colFldFloodWeightGRC = Value
                    m_IsDirty(FieldIndex.colFldFloodWeightGRC) = True
                End If
            End Set
        End Property
        Private m_colFldFloodWeightGRC As Nullable(Of Double)

        Public Property colFldEarthquakeWeightGRC() As Nullable(Of Double) Implements IrowTblMetaRatingWeightFire.colFldEarthquakeWeightGRC
            Get
                Return m_colFldEarthquakeWeightGRC
            End Get
            Set
                If Not Same(m_colFldEarthquakeWeightGRC, Value) Then
                    m_colFldEarthquakeWeightGRC = Value
                    m_IsDirty(FieldIndex.colFldEarthquakeWeightGRC) = True
                End If
            End Set
        End Property
        Private m_colFldEarthquakeWeightGRC As Nullable(Of Double)

        Public Property colFldWindstormWeightGRC() As Nullable(Of Double) Implements IrowTblMetaRatingWeightFire.colFldWindstormWeightGRC
            Get
                Return m_colFldWindstormWeightGRC
            End Get
            Set
                If Not Same(m_colFldWindstormWeightGRC, Value) Then
                    m_colFldWindstormWeightGRC = Value
                    m_IsDirty(FieldIndex.colFldWindstormWeightGRC) = True
                End If
            End Set
        End Property
        Private m_colFldWindstormWeightGRC As Nullable(Of Double)

        Public Property colFldConstructionWeightGRC() As Nullable(Of Double) Implements IrowTblMetaRatingWeightFire.colFldConstructionWeightGRC
            Get
                Return m_colFldConstructionWeightGRC
            End Get
            Set
                If Not Same(m_colFldConstructionWeightGRC, Value) Then
                    m_colFldConstructionWeightGRC = Value
                    m_IsDirty(FieldIndex.colFldConstructionWeightGRC) = True
                End If
            End Set
        End Property
        Private m_colFldConstructionWeightGRC As Nullable(Of Double)

        Public Property colFldOccupancyWeightGRC() As Nullable(Of Double) Implements IrowTblMetaRatingWeightFire.colFldOccupancyWeightGRC
            Get
                Return m_colFldOccupancyWeightGRC
            End Get
            Set
                If Not Same(m_colFldOccupancyWeightGRC, Value) Then
                    m_colFldOccupancyWeightGRC = Value
                    m_IsDirty(FieldIndex.colFldOccupancyWeightGRC) = True
                End If
            End Set
        End Property
        Private m_colFldOccupancyWeightGRC As Nullable(Of Double)

        Public Property colFldOtherWeightGRC() As Nullable(Of Double) Implements IrowTblMetaRatingWeightFire.colFldOtherWeightGRC
            Get
                Return m_colFldOtherWeightGRC
            End Get
            Set
                If Not Same(m_colFldOtherWeightGRC, Value) Then
                    m_colFldOtherWeightGRC = Value
                    m_IsDirty(FieldIndex.colFldOtherWeightGRC) = True
                End If
            End Set
        End Property
        Private m_colFldOtherWeightGRC As Nullable(Of Double)


        Public Function IsDirty(pIndex As rowTblMetaRatingWeightFire.FieldIndex) As Boolean Implements IrowTblMetaRatingWeightFire.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblMetaRatingWeightFire.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblMetaRatingWeightFire.SetIsDirty
            m_IsDirty(FieldIndex.colFldId) = pDirty
            m_IsDirty(FieldIndex.colFldPhysicalProtectionWeightGRC) = pDirty
            m_IsDirty(FieldIndex.colFldHumanElementWeightGRC) = pDirty
            m_IsDirty(FieldIndex.colFldNaturalHazardsProtectionWeightGRC) = pDirty
            m_IsDirty(FieldIndex.colFldBusinessContinuityWeightGRC) = pDirty
            m_IsDirty(FieldIndex.colFldFloodWeightGRC) = pDirty
            m_IsDirty(FieldIndex.colFldEarthquakeWeightGRC) = pDirty
            m_IsDirty(FieldIndex.colFldWindstormWeightGRC) = pDirty
            m_IsDirty(FieldIndex.colFldConstructionWeightGRC) = pDirty
            m_IsDirty(FieldIndex.colFldOccupancyWeightGRC) = pDirty
            m_IsDirty(FieldIndex.colFldOtherWeightGRC) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblMetaRatingWeightFire) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblMetaRatingWeightFire
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldId  = 1
            colFldPhysicalProtectionWeightGRC 
            colFldHumanElementWeightGRC 
            colFldNaturalHazardsProtectionWeightGRC 
            colFldBusinessContinuityWeightGRC 
            colFldFloodWeightGRC 
            colFldEarthquakeWeightGRC 
            colFldWindstormWeightGRC 
            colFldConstructionWeightGRC 
            colFldOccupancyWeightGRC 
            colFldOtherWeightGRC 
        End Enum

        Private m_IsDirty(11) As Boolean

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

    Public Interface IrowTblMetaRatingWeightFire
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldId() As Nullable(Of Integer)
        Property colFldPhysicalProtectionWeightGRC() As Nullable(Of Double)
        Property colFldHumanElementWeightGRC() As Nullable(Of Double)
        Property colFldNaturalHazardsProtectionWeightGRC() As Nullable(Of Double)
        Property colFldBusinessContinuityWeightGRC() As Nullable(Of Double)
        Property colFldFloodWeightGRC() As Nullable(Of Double)
        Property colFldEarthquakeWeightGRC() As Nullable(Of Double)
        Property colFldWindstormWeightGRC() As Nullable(Of Double)
        Property colFldConstructionWeightGRC() As Nullable(Of Double)
        Property colFldOccupancyWeightGRC() As Nullable(Of Double)
        Property colFldOtherWeightGRC() As Nullable(Of Double)
        Function IsDirty(pIndex As rowTblMetaRatingWeightFire.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

