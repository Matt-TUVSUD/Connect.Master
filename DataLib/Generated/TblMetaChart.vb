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
    Partial Public Class TblMetaChart

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaChart)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaChart, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaChart, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaChart, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[tblMetaChart] " & _
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
        Dim zObj As rowTblMetaChart = LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblMetaChart)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaChart, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaChart, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[tblMetaChart] WHERE [fldId] = @colFldId"

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
                        zUpdate = "UPDATE [dbo].[tblMetaChart] SET " 
                        If pRowData.IsDirty(rowTblMetaChart.FieldIndex.colFldSourceId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldSourceId] = @colFldSourceId "
                        End If
                        If pRowData.IsDirty(rowTblMetaChart.FieldIndex.colFldChartName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldChartName] = @colFldChartName "
                        End If
                        If pRowData.IsDirty(rowTblMetaChart.FieldIndex.colFldTitlePage) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldTitlePage] = @colFldTitlePage "
                        End If
                        If pRowData.IsDirty(rowTblMetaChart.FieldIndex.colFldTitlePageSub) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldTitlePageSub] = @colFldTitlePageSub "
                        End If
                        If pRowData.IsDirty(rowTblMetaChart.FieldIndex.colFldTitleChart) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldTitleChart] = @colFldTitleChart "
                        End If
                        If pRowData.IsDirty(rowTblMetaChart.FieldIndex.colFldTitleValueAxis) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldTitleValueAxis] = @colFldTitleValueAxis "
                        End If
                        If pRowData.IsDirty(rowTblMetaChart.FieldIndex.colFldLegendTemplate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldLegendTemplate] = @colFldLegendTemplate "
                        End If
                        If pRowData.IsDirty(rowTblMetaChart.FieldIndex.colFldNotes) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldNotes] = @colFldNotes "
                        End If
                        If pRowData.IsDirty(rowTblMetaChart.FieldIndex.colFldSummaryMode) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldSummaryMode] = @colFldSummaryMode "
                        End If
                        If pRowData.IsDirty(rowTblMetaChart.FieldIndex.colFldReportId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldReportId] = @colFldReportId "
                        End If
                        zWhere = " WHERE [fldId] = @colFldId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaChart] ([fldSourceId], [fldChartName], [fldTitlePage], [fldTitlePageSub], [fldTitleChart], [fldTitleValueAxis], [fldLegendTemplate], [fldNotes], [fldSummaryMode], [fldReportId])" & _
                            " VALUES (@colFldSourceId, @colFldChartName, @colFldTitlePage, @colFldTitlePageSub, @colFldTitleChart, @colFldTitleValueAxis, @colFldLegendTemplate, @colFldNotes, @colFldSummaryMode, @colFldReportId); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaChart] ([fldSourceId], [fldChartName], [fldTitlePage], [fldTitlePageSub], [fldTitleChart], [fldTitleValueAxis], [fldLegendTemplate], [fldNotes], [fldSummaryMode], [fldReportId])" & _
                            " VALUES (@colFldSourceId, @colFldChartName, @colFldTitlePage, @colFldTitlePageSub, @colFldTitleChart, @colFldTitleValueAxis, @colFldLegendTemplate, @colFldNotes, @colFldSummaryMode, @colFldReportId); SELECT SCOPE_IDENTITY()"
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

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaChart.FieldIndex.colFldSourceId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldSourceId", IIf(pRowData.colFldSourceId Is Nothing, DBNull.Value, pRowData.colFldSourceId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaChart.FieldIndex.colFldChartName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldChartName", IIf(pRowData.colFldChartName Is Nothing, DBNull.Value, pRowData.colFldChartName)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaChart.FieldIndex.colFldTitlePage) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldTitlePage", IIf(pRowData.colFldTitlePage Is Nothing, DBNull.Value, pRowData.colFldTitlePage)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaChart.FieldIndex.colFldTitlePageSub) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldTitlePageSub", IIf(pRowData.colFldTitlePageSub Is Nothing, DBNull.Value, pRowData.colFldTitlePageSub)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaChart.FieldIndex.colFldTitleChart) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldTitleChart", IIf(pRowData.colFldTitleChart Is Nothing, DBNull.Value, pRowData.colFldTitleChart)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaChart.FieldIndex.colFldTitleValueAxis) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldTitleValueAxis", IIf(pRowData.colFldTitleValueAxis Is Nothing, DBNull.Value, pRowData.colFldTitleValueAxis)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaChart.FieldIndex.colFldLegendTemplate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldLegendTemplate", IIf(pRowData.colFldLegendTemplate Is Nothing, DBNull.Value, pRowData.colFldLegendTemplate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaChart.FieldIndex.colFldNotes) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldNotes", IIf(pRowData.colFldNotes Is Nothing, DBNull.Value, pRowData.colFldNotes)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaChart.FieldIndex.colFldSummaryMode) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldSummaryMode", IIf(pRowData.colFldSummaryMode Is Nothing, DBNull.Value, pRowData.colFldSummaryMode)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaChart.FieldIndex.colFldReportId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldReportId", IIf(pRowData.colFldReportId Is Nothing, DBNull.Value, pRowData.colFldReportId)))
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

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer) As rowTblMetaChart
            Return LoadByPrimaryKey(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pLoadEventUserState As Object) As rowTblMetaChart
            Return LoadByPrimaryKey(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblMetaChart
            Return LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblMetaChart
            Dim zReturn As New rowTblMetaChart
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaChart] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblMetaChart) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK_tblMetaChart(pcolFldId As Integer) As List(Of rowTblMetaChart)
            Return LoadByIDX_PK_tblMetaChart(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaChart(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of rowTblMetaChart)
            Return LoadByIDX_PK_tblMetaChart(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaChart(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaChart)
            Return LoadByIDX_PK_tblMetaChart(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaChart(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaChart)
            Dim zReturn As New List(Of rowTblMetaChart)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaChart] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblMetaChart)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblMetaChart)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblMetaChart)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaChart)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaChart)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaChart)
            Dim zReturn As New List(Of rowTblMetaChart)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaChart]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblMetaChart)

			Try
	            Dim zReturn As New List(Of rowTblMetaChart)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblMetaChart

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblMetaChart		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblMetaChart)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldId")) Then pObject.colFldId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSourceId")) Then pObject.colFldSourceId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldSourceId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldChartName")) Then pObject.colFldChartName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldChartName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldTitlePage")) Then pObject.colFldTitlePage = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldTitlePage")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldTitlePageSub")) Then pObject.colFldTitlePageSub = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldTitlePageSub")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldTitleChart")) Then pObject.colFldTitleChart = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldTitleChart")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldTitleValueAxis")) Then pObject.colFldTitleValueAxis = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldTitleValueAxis")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldLegendTemplate")) Then pObject.colFldLegendTemplate = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldLegendTemplate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldNotes")) Then pObject.colFldNotes = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldNotes")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSummaryMode")) Then pObject.colFldSummaryMode = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldSummaryMode")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldReportId")) Then pObject.colFldReportId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldReportId")
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
            If Not TypeOf zReturn Is rowTblMetaChart Then Throw New ArgumentException("Generic type is not type of rowTblMetaChart.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaChart] WHERE [fldId] = @colFldId"
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

        Public Shared Function LoadByIDX_PK_tblMetaChart(Of T)(pcolFldId As Integer) As List(Of T)
            Return LoadByIDX_PK_tblMetaChart(Of T)(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaChart(Of T)(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK_tblMetaChart(Of T)(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaChart(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK_tblMetaChart(Of T)(pcolFldId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK_tblMetaChart(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaChart] WHERE [fldId] = @colFldId"
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
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaChart]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblMetaChart
        Implements IrowTblMetaChart

        Public Event Loaded(pUserState As Object) Implements IrowTblMetaChart.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblMetaChart.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblMetaChart.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblMetaChart.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblMetaChart.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblMetaChart.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldId() As Nullable(Of Integer) Implements IrowTblMetaChart.colFldId
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

        Public Property colFldSourceId() As Nullable(Of Integer) Implements IrowTblMetaChart.colFldSourceId
            Get
                Return m_colFldSourceId
            End Get
            Set
                If Not Same(m_colFldSourceId, Value) Then
                    m_colFldSourceId = Value
                    m_IsDirty(FieldIndex.colFldSourceId) = True
                End If
            End Set
        End Property
        Private m_colFldSourceId As Nullable(Of Integer)

        Public Property colFldChartName() As String Implements IrowTblMetaChart.colFldChartName
            Get
                Return m_colFldChartName
            End Get
            Set
                If Not Same(m_colFldChartName, Value) Then
                    m_colFldChartName = Value
                    m_IsDirty(FieldIndex.colFldChartName) = True
                End If
            End Set
        End Property
        Private m_colFldChartName As String

        Public Property colFldTitlePage() As String Implements IrowTblMetaChart.colFldTitlePage
            Get
                Return m_colFldTitlePage
            End Get
            Set
                If Not Same(m_colFldTitlePage, Value) Then
                    m_colFldTitlePage = Value
                    m_IsDirty(FieldIndex.colFldTitlePage) = True
                End If
            End Set
        End Property
        Private m_colFldTitlePage As String

        Public Property colFldTitlePageSub() As String Implements IrowTblMetaChart.colFldTitlePageSub
            Get
                Return m_colFldTitlePageSub
            End Get
            Set
                If Not Same(m_colFldTitlePageSub, Value) Then
                    m_colFldTitlePageSub = Value
                    m_IsDirty(FieldIndex.colFldTitlePageSub) = True
                End If
            End Set
        End Property
        Private m_colFldTitlePageSub As String

        Public Property colFldTitleChart() As String Implements IrowTblMetaChart.colFldTitleChart
            Get
                Return m_colFldTitleChart
            End Get
            Set
                If Not Same(m_colFldTitleChart, Value) Then
                    m_colFldTitleChart = Value
                    m_IsDirty(FieldIndex.colFldTitleChart) = True
                End If
            End Set
        End Property
        Private m_colFldTitleChart As String

        Public Property colFldTitleValueAxis() As String Implements IrowTblMetaChart.colFldTitleValueAxis
            Get
                Return m_colFldTitleValueAxis
            End Get
            Set
                If Not Same(m_colFldTitleValueAxis, Value) Then
                    m_colFldTitleValueAxis = Value
                    m_IsDirty(FieldIndex.colFldTitleValueAxis) = True
                End If
            End Set
        End Property
        Private m_colFldTitleValueAxis As String

        Public Property colFldLegendTemplate() As String Implements IrowTblMetaChart.colFldLegendTemplate
            Get
                Return m_colFldLegendTemplate
            End Get
            Set
                If Not Same(m_colFldLegendTemplate, Value) Then
                    m_colFldLegendTemplate = Value
                    m_IsDirty(FieldIndex.colFldLegendTemplate) = True
                End If
            End Set
        End Property
        Private m_colFldLegendTemplate As String

        Public Property colFldNotes() As String Implements IrowTblMetaChart.colFldNotes
            Get
                Return m_colFldNotes
            End Get
            Set
                If Not Same(m_colFldNotes, Value) Then
                    m_colFldNotes = Value
                    m_IsDirty(FieldIndex.colFldNotes) = True
                End If
            End Set
        End Property
        Private m_colFldNotes As String

        Public Property colFldSummaryMode() As String Implements IrowTblMetaChart.colFldSummaryMode
            Get
                Return m_colFldSummaryMode
            End Get
            Set
                If Not Same(m_colFldSummaryMode, Value) Then
                    m_colFldSummaryMode = Value
                    m_IsDirty(FieldIndex.colFldSummaryMode) = True
                End If
            End Set
        End Property
        Private m_colFldSummaryMode As String

        Public Property colFldReportId() As Nullable(Of Integer) Implements IrowTblMetaChart.colFldReportId
            Get
                Return m_colFldReportId
            End Get
            Set
                If Not Same(m_colFldReportId, Value) Then
                    m_colFldReportId = Value
                    m_IsDirty(FieldIndex.colFldReportId) = True
                End If
            End Set
        End Property
        Private m_colFldReportId As Nullable(Of Integer)


        Public Function IsDirty(pIndex As rowTblMetaChart.FieldIndex) As Boolean Implements IrowTblMetaChart.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblMetaChart.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblMetaChart.SetIsDirty
            m_IsDirty(FieldIndex.colFldId) = pDirty
            m_IsDirty(FieldIndex.colFldSourceId) = pDirty
            m_IsDirty(FieldIndex.colFldChartName) = pDirty
            m_IsDirty(FieldIndex.colFldTitlePage) = pDirty
            m_IsDirty(FieldIndex.colFldTitlePageSub) = pDirty
            m_IsDirty(FieldIndex.colFldTitleChart) = pDirty
            m_IsDirty(FieldIndex.colFldTitleValueAxis) = pDirty
            m_IsDirty(FieldIndex.colFldLegendTemplate) = pDirty
            m_IsDirty(FieldIndex.colFldNotes) = pDirty
            m_IsDirty(FieldIndex.colFldSummaryMode) = pDirty
            m_IsDirty(FieldIndex.colFldReportId) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblMetaChart) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblMetaChart
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldId  = 1
            colFldSourceId 
            colFldChartName 
            colFldTitlePage 
            colFldTitlePageSub 
            colFldTitleChart 
            colFldTitleValueAxis 
            colFldLegendTemplate 
            colFldNotes 
            colFldSummaryMode 
            colFldReportId 
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

    Public Interface IrowTblMetaChart
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldId() As Nullable(Of Integer)
        Property colFldSourceId() As Nullable(Of Integer)
        Property colFldChartName() As String
        Property colFldTitlePage() As String
        Property colFldTitlePageSub() As String
        Property colFldTitleChart() As String
        Property colFldTitleValueAxis() As String
        Property colFldLegendTemplate() As String
        Property colFldNotes() As String
        Property colFldSummaryMode() As String
        Property colFldReportId() As Nullable(Of Integer)
        Function IsDirty(pIndex As rowTblMetaChart.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

