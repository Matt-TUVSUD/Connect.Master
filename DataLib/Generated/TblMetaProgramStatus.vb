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
    Partial Public Class TblMetaProgramStatus

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaProgramStatus)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaProgramStatus, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaProgramStatus, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaProgramStatus, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[tblMetaProgramStatus] " & _
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
        Dim zObj As rowTblMetaProgramStatus = LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblMetaProgramStatus)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaProgramStatus, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaProgramStatus, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[tblMetaProgramStatus] WHERE [fldId] = @colFldId"

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
                        zUpdate = "UPDATE [dbo].[tblMetaProgramStatus] SET " 
                        If pRowData.IsDirty(rowTblMetaProgramStatus.FieldIndex.colFldSectionName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldSectionName] = @colFldSectionName "
                        End If
                        If pRowData.IsDirty(rowTblMetaProgramStatus.FieldIndex.colFldTopName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldTopName] = @colFldTopName "
                        End If
                        If pRowData.IsDirty(rowTblMetaProgramStatus.FieldIndex.colFldMetricName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldMetricName] = @colFldMetricName "
                        End If
                        If pRowData.IsDirty(rowTblMetaProgramStatus.FieldIndex.colFldSubMetricName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldSubMetricName] = @colFldSubMetricName "
                        End If
                        If pRowData.IsDirty(rowTblMetaProgramStatus.FieldIndex.colFldMetricValue) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldMetricValue] = @colFldMetricValue "
                        End If
                        If pRowData.IsDirty(rowTblMetaProgramStatus.FieldIndex.colFldMetricLabel) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldMetricLabel] = @colFldMetricLabel "
                        End If
                        If pRowData.IsDirty(rowTblMetaProgramStatus.FieldIndex.colFldMetricVisible) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldMetricVisible] = @colFldMetricVisible "
                        End If
                        If pRowData.IsDirty(rowTblMetaProgramStatus.FieldIndex.colFldMetricColor) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldMetricColor] = @colFldMetricColor "
                        End If
                        If pRowData.IsDirty(rowTblMetaProgramStatus.FieldIndex.colFldDirectId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldDirectId] = @colFldDirectId "
                        End If
                        If pRowData.IsDirty(rowTblMetaProgramStatus.FieldIndex.colFldCriteria) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldCriteria] = @colFldCriteria "
                        End If
                        If pRowData.IsDirty(rowTblMetaProgramStatus.FieldIndex.colFldFilter) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldFilter] = @colFldFilter "
                        End If
                        If pRowData.IsDirty(rowTblMetaProgramStatus.FieldIndex.colFldGridId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldGridId] = @colFldGridId "
                        End If
                        If pRowData.IsDirty(rowTblMetaProgramStatus.FieldIndex.colFldSort) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldSort] = @colFldSort "
                        End If
                        zWhere = " WHERE [fldId] = @colFldId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaProgramStatus] ([fldSectionName], [fldTopName], [fldMetricName], [fldSubMetricName], [fldMetricValue], [fldMetricLabel], [fldMetricVisible], [fldMetricColor], [fldDirectId], [fldCriteria], [fldFilter], [fldGridId], [fldSort])" & _
                            " VALUES (@colFldSectionName, @colFldTopName, @colFldMetricName, @colFldSubMetricName, @colFldMetricValue, @colFldMetricLabel, @colFldMetricVisible, @colFldMetricColor, @colFldDirectId, @colFldCriteria, @colFldFilter, @colFldGridId, @colFldSort); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaProgramStatus] ([fldSectionName], [fldTopName], [fldMetricName], [fldSubMetricName], [fldMetricValue], [fldMetricLabel], [fldMetricVisible], [fldMetricColor], [fldDirectId], [fldCriteria], [fldFilter], [fldGridId], [fldSort])" & _
                            " VALUES (@colFldSectionName, @colFldTopName, @colFldMetricName, @colFldSubMetricName, @colFldMetricValue, @colFldMetricLabel, @colFldMetricVisible, @colFldMetricColor, @colFldDirectId, @colFldCriteria, @colFldFilter, @colFldGridId, @colFldSort); SELECT SCOPE_IDENTITY()"
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

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaProgramStatus.FieldIndex.colFldSectionName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldSectionName", IIf(pRowData.colFldSectionName Is Nothing, DBNull.Value, pRowData.colFldSectionName)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaProgramStatus.FieldIndex.colFldTopName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldTopName", IIf(pRowData.colFldTopName Is Nothing, DBNull.Value, pRowData.colFldTopName)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaProgramStatus.FieldIndex.colFldMetricName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldMetricName", IIf(pRowData.colFldMetricName Is Nothing, DBNull.Value, pRowData.colFldMetricName)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaProgramStatus.FieldIndex.colFldSubMetricName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldSubMetricName", IIf(pRowData.colFldSubMetricName Is Nothing, DBNull.Value, pRowData.colFldSubMetricName)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaProgramStatus.FieldIndex.colFldMetricValue) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldMetricValue", IIf(pRowData.colFldMetricValue Is Nothing, DBNull.Value, pRowData.colFldMetricValue)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaProgramStatus.FieldIndex.colFldMetricLabel) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldMetricLabel", IIf(pRowData.colFldMetricLabel Is Nothing, DBNull.Value, pRowData.colFldMetricLabel)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaProgramStatus.FieldIndex.colFldMetricVisible) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldMetricVisible", IIf(pRowData.colFldMetricVisible Is Nothing, DBNull.Value, pRowData.colFldMetricVisible)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaProgramStatus.FieldIndex.colFldMetricColor) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldMetricColor", IIf(pRowData.colFldMetricColor Is Nothing, DBNull.Value, pRowData.colFldMetricColor)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaProgramStatus.FieldIndex.colFldDirectId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldDirectId", IIf(pRowData.colFldDirectId Is Nothing, DBNull.Value, pRowData.colFldDirectId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaProgramStatus.FieldIndex.colFldCriteria) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldCriteria", IIf(pRowData.colFldCriteria Is Nothing, DBNull.Value, pRowData.colFldCriteria)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaProgramStatus.FieldIndex.colFldFilter) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldFilter", IIf(pRowData.colFldFilter Is Nothing, DBNull.Value, pRowData.colFldFilter)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaProgramStatus.FieldIndex.colFldGridId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldGridId", IIf(pRowData.colFldGridId Is Nothing, DBNull.Value, pRowData.colFldGridId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaProgramStatus.FieldIndex.colFldSort) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldSort", IIf(pRowData.colFldSort Is Nothing, DBNull.Value, pRowData.colFldSort)))
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

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer) As rowTblMetaProgramStatus
            Return LoadByPrimaryKey(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pLoadEventUserState As Object) As rowTblMetaProgramStatus
            Return LoadByPrimaryKey(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblMetaProgramStatus
            Return LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblMetaProgramStatus
            Dim zReturn As New rowTblMetaProgramStatus
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaProgramStatus] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblMetaProgramStatus) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_DirectId(pcolFldDirectId As Integer) As List(Of rowTblMetaProgramStatus)
            Return LoadByIDX_DirectId(pcolFldDirectId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_DirectId(pcolFldDirectId As Integer, pLoadEventUserState As Object) As List(Of rowTblMetaProgramStatus)
            Return LoadByIDX_DirectId(pcolFldDirectId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_DirectId(pcolFldDirectId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaProgramStatus)
            Return LoadByIDX_DirectId(pcolFldDirectId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_DirectId(pcolFldDirectId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaProgramStatus)
            Dim zReturn As New List(Of rowTblMetaProgramStatus)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaProgramStatus] WHERE [fldDirectId] = @colFldDirectId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldDirectId", pcolFldDirectId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function
        Public Shared Function LoadByIDX_MetricKey(pcolFldSectionName As String, pcolFldTopName As String, pcolFldMetricName As String, pcolFldSubMetricName As String, pcolFldMetricLabel As String) As List(Of rowTblMetaProgramStatus)
            Return LoadByIDX_MetricKey(pcolFldSectionName, pcolFldTopName, pcolFldMetricName, pcolFldSubMetricName, pcolFldMetricLabel, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_MetricKey(pcolFldSectionName As String, pcolFldTopName As String, pcolFldMetricName As String, pcolFldSubMetricName As String, pcolFldMetricLabel As String, pLoadEventUserState As Object) As List(Of rowTblMetaProgramStatus)
            Return LoadByIDX_MetricKey(pcolFldSectionName, pcolFldTopName, pcolFldMetricName, pcolFldSubMetricName, pcolFldMetricLabel, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_MetricKey(pcolFldSectionName As String, pcolFldTopName As String, pcolFldMetricName As String, pcolFldSubMetricName As String, pcolFldMetricLabel As String, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaProgramStatus)
            Return LoadByIDX_MetricKey(pcolFldSectionName, pcolFldTopName, pcolFldMetricName, pcolFldSubMetricName, pcolFldMetricLabel, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_MetricKey(pcolFldSectionName As String, pcolFldTopName As String, pcolFldMetricName As String, pcolFldSubMetricName As String, pcolFldMetricLabel As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaProgramStatus)
            Dim zReturn As New List(Of rowTblMetaProgramStatus)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaProgramStatus] WHERE [fldSectionName] = @colFldSectionName AND [fldTopName] = @colFldTopName AND [fldMetricName] = @colFldMetricName AND [fldSubMetricName] = @colFldSubMetricName AND [fldMetricLabel] = @colFldMetricLabel"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldSectionName", pcolFldSectionName))
            zCmd.Parameters.Add(New SQLParameter("@colFldTopName", pcolFldTopName))
            zCmd.Parameters.Add(New SQLParameter("@colFldMetricName", pcolFldMetricName))
            zCmd.Parameters.Add(New SQLParameter("@colFldSubMetricName", pcolFldSubMetricName))
            zCmd.Parameters.Add(New SQLParameter("@colFldMetricLabel", pcolFldMetricLabel))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function
        Public Shared Function LoadByIDX_PK_tblMetaProgramStatus(pcolFldId As Integer) As List(Of rowTblMetaProgramStatus)
            Return LoadByIDX_PK_tblMetaProgramStatus(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaProgramStatus(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of rowTblMetaProgramStatus)
            Return LoadByIDX_PK_tblMetaProgramStatus(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaProgramStatus(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaProgramStatus)
            Return LoadByIDX_PK_tblMetaProgramStatus(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaProgramStatus(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaProgramStatus)
            Dim zReturn As New List(Of rowTblMetaProgramStatus)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaProgramStatus] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblMetaProgramStatus)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblMetaProgramStatus)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblMetaProgramStatus)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaProgramStatus)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaProgramStatus)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaProgramStatus)
            Dim zReturn As New List(Of rowTblMetaProgramStatus)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaProgramStatus]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblMetaProgramStatus)

			Try
	            Dim zReturn As New List(Of rowTblMetaProgramStatus)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblMetaProgramStatus

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblMetaProgramStatus		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblMetaProgramStatus)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldId")) Then pObject.colFldId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSectionName")) Then pObject.colFldSectionName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldSectionName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldTopName")) Then pObject.colFldTopName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldTopName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldMetricName")) Then pObject.colFldMetricName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldMetricName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSubMetricName")) Then pObject.colFldSubMetricName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldSubMetricName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldMetricValue")) Then pObject.colFldMetricValue = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldMetricValue")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldMetricLabel")) Then pObject.colFldMetricLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldMetricLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldMetricVisible")) Then pObject.colFldMetricVisible = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldMetricVisible")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldMetricColor")) Then pObject.colFldMetricColor = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldMetricColor")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldDirectId")) Then pObject.colFldDirectId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldDirectId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldCriteria")) Then pObject.colFldCriteria = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldCriteria")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFilter")) Then pObject.colFldFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldGridId")) Then pObject.colFldGridId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldGridId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSort")) Then pObject.colFldSort = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldSort")
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
            If Not TypeOf zReturn Is rowTblMetaProgramStatus Then Throw New ArgumentException("Generic type is not type of rowTblMetaProgramStatus.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaProgramStatus] WHERE [fldId] = @colFldId"
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

        Public Shared Function LoadByIDX_DirectId(Of T)(pcolFldDirectId As Integer) As List(Of T)
            Return LoadByIDX_DirectId(Of T)(pcolFldDirectId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_DirectId(Of T)(pcolFldDirectId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_DirectId(Of T)(pcolFldDirectId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_DirectId(Of T)(pcolFldDirectId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_DirectId(Of T)(pcolFldDirectId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_DirectId(Of T)(pcolFldDirectId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaProgramStatus] WHERE [fldDirectId] = @colFldDirectId"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldDirectId", pcolFldDirectId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_MetricKey(Of T)(pcolFldSectionName As String, pcolFldTopName As String, pcolFldMetricName As String, pcolFldSubMetricName As String, pcolFldMetricLabel As String) As List(Of T)
            Return LoadByIDX_MetricKey(Of T)(pcolFldSectionName, pcolFldTopName, pcolFldMetricName, pcolFldSubMetricName, pcolFldMetricLabel, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_MetricKey(Of T)(pcolFldSectionName As String, pcolFldTopName As String, pcolFldMetricName As String, pcolFldSubMetricName As String, pcolFldMetricLabel As String, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_MetricKey(Of T)(pcolFldSectionName, pcolFldTopName, pcolFldMetricName, pcolFldSubMetricName, pcolFldMetricLabel, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_MetricKey(Of T)(pcolFldSectionName As String, pcolFldTopName As String, pcolFldMetricName As String, pcolFldSubMetricName As String, pcolFldMetricLabel As String, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_MetricKey(Of T)(pcolFldSectionName, pcolFldTopName, pcolFldMetricName, pcolFldSubMetricName, pcolFldMetricLabel, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_MetricKey(Of T)(pcolFldSectionName As String, pcolFldTopName As String, pcolFldMetricName As String, pcolFldSubMetricName As String, pcolFldMetricLabel As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaProgramStatus] WHERE [fldSectionName] = @colFldSectionName AND [fldTopName] = @colFldTopName AND [fldMetricName] = @colFldMetricName AND [fldSubMetricName] = @colFldSubMetricName AND [fldMetricLabel] = @colFldMetricLabel"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldSectionName", pcolFldSectionName))
            zCmd.Parameters.Add(New SQLParameter("@colFldTopName", pcolFldTopName))
            zCmd.Parameters.Add(New SQLParameter("@colFldMetricName", pcolFldMetricName))
            zCmd.Parameters.Add(New SQLParameter("@colFldSubMetricName", pcolFldSubMetricName))
            zCmd.Parameters.Add(New SQLParameter("@colFldMetricLabel", pcolFldMetricLabel))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaProgramStatus(Of T)(pcolFldId As Integer) As List(Of T)
            Return LoadByIDX_PK_tblMetaProgramStatus(Of T)(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaProgramStatus(Of T)(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK_tblMetaProgramStatus(Of T)(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaProgramStatus(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK_tblMetaProgramStatus(Of T)(pcolFldId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK_tblMetaProgramStatus(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaProgramStatus] WHERE [fldId] = @colFldId"
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
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaProgramStatus]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblMetaProgramStatus
        Implements IrowTblMetaProgramStatus

        Public Event Loaded(pUserState As Object) Implements IrowTblMetaProgramStatus.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblMetaProgramStatus.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblMetaProgramStatus.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblMetaProgramStatus.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblMetaProgramStatus.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblMetaProgramStatus.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldId() As Nullable(Of Integer) Implements IrowTblMetaProgramStatus.colFldId
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

        Public Property colFldSectionName() As String Implements IrowTblMetaProgramStatus.colFldSectionName
            Get
                Return m_colFldSectionName
            End Get
            Set
                If Not Same(m_colFldSectionName, Value) Then
                    m_colFldSectionName = Value
                    m_IsDirty(FieldIndex.colFldSectionName) = True
                End If
            End Set
        End Property
        Private m_colFldSectionName As String

        Public Property colFldTopName() As String Implements IrowTblMetaProgramStatus.colFldTopName
            Get
                Return m_colFldTopName
            End Get
            Set
                If Not Same(m_colFldTopName, Value) Then
                    m_colFldTopName = Value
                    m_IsDirty(FieldIndex.colFldTopName) = True
                End If
            End Set
        End Property
        Private m_colFldTopName As String

        Public Property colFldMetricName() As String Implements IrowTblMetaProgramStatus.colFldMetricName
            Get
                Return m_colFldMetricName
            End Get
            Set
                If Not Same(m_colFldMetricName, Value) Then
                    m_colFldMetricName = Value
                    m_IsDirty(FieldIndex.colFldMetricName) = True
                End If
            End Set
        End Property
        Private m_colFldMetricName As String

        Public Property colFldSubMetricName() As String Implements IrowTblMetaProgramStatus.colFldSubMetricName
            Get
                Return m_colFldSubMetricName
            End Get
            Set
                If Not Same(m_colFldSubMetricName, Value) Then
                    m_colFldSubMetricName = Value
                    m_IsDirty(FieldIndex.colFldSubMetricName) = True
                End If
            End Set
        End Property
        Private m_colFldSubMetricName As String

        Public Property colFldMetricValue() As Nullable(Of Integer) Implements IrowTblMetaProgramStatus.colFldMetricValue
            Get
                Return m_colFldMetricValue
            End Get
            Set
                If Not Same(m_colFldMetricValue, Value) Then
                    m_colFldMetricValue = Value
                    m_IsDirty(FieldIndex.colFldMetricValue) = True
                End If
            End Set
        End Property
        Private m_colFldMetricValue As Nullable(Of Integer)

        Public Property colFldMetricLabel() As String Implements IrowTblMetaProgramStatus.colFldMetricLabel
            Get
                Return m_colFldMetricLabel
            End Get
            Set
                If Not Same(m_colFldMetricLabel, Value) Then
                    m_colFldMetricLabel = Value
                    m_IsDirty(FieldIndex.colFldMetricLabel) = True
                End If
            End Set
        End Property
        Private m_colFldMetricLabel As String

        Public Property colFldMetricVisible() As Nullable(Of Boolean) Implements IrowTblMetaProgramStatus.colFldMetricVisible
            Get
                Return m_colFldMetricVisible
            End Get
            Set
                If Not Same(m_colFldMetricVisible, Value) Then
                    m_colFldMetricVisible = Value
                    m_IsDirty(FieldIndex.colFldMetricVisible) = True
                End If
            End Set
        End Property
        Private m_colFldMetricVisible As Nullable(Of Boolean)

        Public Property colFldMetricColor() As String Implements IrowTblMetaProgramStatus.colFldMetricColor
            Get
                Return m_colFldMetricColor
            End Get
            Set
                If Not Same(m_colFldMetricColor, Value) Then
                    m_colFldMetricColor = Value
                    m_IsDirty(FieldIndex.colFldMetricColor) = True
                End If
            End Set
        End Property
        Private m_colFldMetricColor As String

        Public Property colFldDirectId() As Nullable(Of Integer) Implements IrowTblMetaProgramStatus.colFldDirectId
            Get
                Return m_colFldDirectId
            End Get
            Set
                If Not Same(m_colFldDirectId, Value) Then
                    m_colFldDirectId = Value
                    m_IsDirty(FieldIndex.colFldDirectId) = True
                End If
            End Set
        End Property
        Private m_colFldDirectId As Nullable(Of Integer)

        Public Property colFldCriteria() As String Implements IrowTblMetaProgramStatus.colFldCriteria
            Get
                Return m_colFldCriteria
            End Get
            Set
                If Not Same(m_colFldCriteria, Value) Then
                    m_colFldCriteria = Value
                    m_IsDirty(FieldIndex.colFldCriteria) = True
                End If
            End Set
        End Property
        Private m_colFldCriteria As String

        Public Property colFldFilter() As String Implements IrowTblMetaProgramStatus.colFldFilter
            Get
                Return m_colFldFilter
            End Get
            Set
                If Not Same(m_colFldFilter, Value) Then
                    m_colFldFilter = Value
                    m_IsDirty(FieldIndex.colFldFilter) = True
                End If
            End Set
        End Property
        Private m_colFldFilter As String

        Public Property colFldGridId() As Nullable(Of Integer) Implements IrowTblMetaProgramStatus.colFldGridId
            Get
                Return m_colFldGridId
            End Get
            Set
                If Not Same(m_colFldGridId, Value) Then
                    m_colFldGridId = Value
                    m_IsDirty(FieldIndex.colFldGridId) = True
                End If
            End Set
        End Property
        Private m_colFldGridId As Nullable(Of Integer)

        Public Property colFldSort() As String Implements IrowTblMetaProgramStatus.colFldSort
            Get
                Return m_colFldSort
            End Get
            Set
                If Not Same(m_colFldSort, Value) Then
                    m_colFldSort = Value
                    m_IsDirty(FieldIndex.colFldSort) = True
                End If
            End Set
        End Property
        Private m_colFldSort As String


        Public Function IsDirty(pIndex As rowTblMetaProgramStatus.FieldIndex) As Boolean Implements IrowTblMetaProgramStatus.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblMetaProgramStatus.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblMetaProgramStatus.SetIsDirty
            m_IsDirty(FieldIndex.colFldId) = pDirty
            m_IsDirty(FieldIndex.colFldSectionName) = pDirty
            m_IsDirty(FieldIndex.colFldTopName) = pDirty
            m_IsDirty(FieldIndex.colFldMetricName) = pDirty
            m_IsDirty(FieldIndex.colFldSubMetricName) = pDirty
            m_IsDirty(FieldIndex.colFldMetricValue) = pDirty
            m_IsDirty(FieldIndex.colFldMetricLabel) = pDirty
            m_IsDirty(FieldIndex.colFldMetricVisible) = pDirty
            m_IsDirty(FieldIndex.colFldMetricColor) = pDirty
            m_IsDirty(FieldIndex.colFldDirectId) = pDirty
            m_IsDirty(FieldIndex.colFldCriteria) = pDirty
            m_IsDirty(FieldIndex.colFldFilter) = pDirty
            m_IsDirty(FieldIndex.colFldGridId) = pDirty
            m_IsDirty(FieldIndex.colFldSort) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblMetaProgramStatus) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblMetaProgramStatus
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldId  = 1
            colFldSectionName 
            colFldTopName 
            colFldMetricName 
            colFldSubMetricName 
            colFldMetricValue 
            colFldMetricLabel 
            colFldMetricVisible 
            colFldMetricColor 
            colFldDirectId 
            colFldCriteria 
            colFldFilter 
            colFldGridId 
            colFldSort 
        End Enum

        Private m_IsDirty(14) As Boolean

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

    Public Interface IrowTblMetaProgramStatus
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldId() As Nullable(Of Integer)
        Property colFldSectionName() As String
        Property colFldTopName() As String
        Property colFldMetricName() As String
        Property colFldSubMetricName() As String
        Property colFldMetricValue() As Nullable(Of Integer)
        Property colFldMetricLabel() As String
        Property colFldMetricVisible() As Nullable(Of Boolean)
        Property colFldMetricColor() As String
        Property colFldDirectId() As Nullable(Of Integer)
        Property colFldCriteria() As String
        Property colFldFilter() As String
        Property colFldGridId() As Nullable(Of Integer)
        Property colFldSort() As String
        Function IsDirty(pIndex As rowTblMetaProgramStatus.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

