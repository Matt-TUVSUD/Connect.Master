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
    Partial Public Class TblMetaGrid

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaGrid)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaGrid, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaGrid, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaGrid, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[tblMetaGrid] " & _
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
        Dim zObj As rowTblMetaGrid = LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblMetaGrid)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaGrid, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaGrid, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[tblMetaGrid] WHERE [fldId] = @colFldId"

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
                        zUpdate = "UPDATE [dbo].[tblMetaGrid] SET " 
                        If pRowData.IsDirty(rowTblMetaGrid.FieldIndex.colFldGridName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldGridName] = @colFldGridName "
                        End If
                        If pRowData.IsDirty(rowTblMetaGrid.FieldIndex.colFldKeyField) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldKeyField] = @colFldKeyField "
                        End If
                        If pRowData.IsDirty(rowTblMetaGrid.FieldIndex.colFldGridPageTitle) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldGridPageTitle] = @colFldGridPageTitle "
                        End If
                        If pRowData.IsDirty(rowTblMetaGrid.FieldIndex.colFldGridPageSubTitle) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldGridPageSubTitle] = @colFldGridPageSubTitle "
                        End If
                        If pRowData.IsDirty(rowTblMetaGrid.FieldIndex.colFldGridPractice) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldGridPractice] = @colFldGridPractice "
                        End If
                        If pRowData.IsDirty(rowTblMetaGrid.FieldIndex.colFldFileName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldFileName] = @colFldFileName "
                        End If
                        If pRowData.IsDirty(rowTblMetaGrid.FieldIndex.colFldSourceId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldSourceId] = @colFldSourceId "
                        End If
                        If pRowData.IsDirty(rowTblMetaGrid.FieldIndex.colFldReportId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldReportId] = @colFldReportId "
                        End If
                        If pRowData.IsDirty(rowTblMetaGrid.FieldIndex.colFldFormViewTemplateName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldFormViewTemplateName] = @colFldFormViewTemplateName "
                        End If
                        If pRowData.IsDirty(rowTblMetaGrid.FieldIndex.colFldInstructions) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldInstructions] = @colFldInstructions "
                        End If
                        If pRowData.IsDirty(rowTblMetaGrid.FieldIndex.colFldLegacyFavoritesGridID) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldLegacyFavoritesGridID] = @colFldLegacyFavoritesGridID "
                        End If
                        If pRowData.IsDirty(rowTblMetaGrid.FieldIndex.colFldReport2Id) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldReport2Id] = @colFldReport2Id "
                        End If
                        If pRowData.IsDirty(rowTblMetaGrid.FieldIndex.colFldComment) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldComment] = @colFldComment "
                        End If
                        If pRowData.IsDirty(rowTblMetaGrid.FieldIndex.colFldFormViewReportId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldFormViewReportId] = @colFldFormViewReportId "
                        End If
                        If pRowData.IsDirty(rowTblMetaGrid.FieldIndex.colFldMapShowPinText) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldMapShowPinText] = @colFldMapShowPinText "
                        End If
                        If pRowData.IsDirty(rowTblMetaGrid.FieldIndex.colFldMetaPracticeId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldMetaPracticeId] = @colFldMetaPracticeId "
                        End If
                        If pRowData.IsDirty(rowTblMetaGrid.FieldIndex.colFldExtractHeaderRowHeight) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldExtractHeaderRowHeight] = @colFldExtractHeaderRowHeight "
                        End If
                        zWhere = " WHERE [fldId] = @colFldId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaGrid] ([fldGridName], [fldKeyField], [fldGridPageTitle], [fldGridPageSubTitle], [fldGridPractice], [fldFileName], [fldSourceId], [fldReportId], [fldFormViewTemplateName], [fldInstructions], [fldLegacyFavoritesGridID], [fldReport2Id], [fldComment], [fldFormViewReportId], [fldMapShowPinText], [fldMetaPracticeId], [fldExtractHeaderRowHeight])" & _
                            " VALUES (@colFldGridName, @colFldKeyField, @colFldGridPageTitle, @colFldGridPageSubTitle, @colFldGridPractice, @colFldFileName, @colFldSourceId, @colFldReportId, @colFldFormViewTemplateName, @colFldInstructions, @colFldLegacyFavoritesGridID, @colFldReport2Id, @colFldComment, @colFldFormViewReportId, @colFldMapShowPinText, @colFldMetaPracticeId, @colFldExtractHeaderRowHeight); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaGrid] ([fldGridName], [fldKeyField], [fldGridPageTitle], [fldGridPageSubTitle], [fldGridPractice], [fldFileName], [fldSourceId], [fldReportId], [fldFormViewTemplateName], [fldInstructions], [fldLegacyFavoritesGridID], [fldReport2Id], [fldComment], [fldFormViewReportId], [fldMapShowPinText], [fldMetaPracticeId], [fldExtractHeaderRowHeight])" & _
                            " VALUES (@colFldGridName, @colFldKeyField, @colFldGridPageTitle, @colFldGridPageSubTitle, @colFldGridPractice, @colFldFileName, @colFldSourceId, @colFldReportId, @colFldFormViewTemplateName, @colFldInstructions, @colFldLegacyFavoritesGridID, @colFldReport2Id, @colFldComment, @colFldFormViewReportId, @colFldMapShowPinText, @colFldMetaPracticeId, @colFldExtractHeaderRowHeight); SELECT SCOPE_IDENTITY()"
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

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGrid.FieldIndex.colFldGridName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldGridName", IIf(pRowData.colFldGridName Is Nothing, DBNull.Value, pRowData.colFldGridName)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGrid.FieldIndex.colFldKeyField) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldKeyField", IIf(pRowData.colFldKeyField Is Nothing, DBNull.Value, pRowData.colFldKeyField)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGrid.FieldIndex.colFldGridPageTitle) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldGridPageTitle", IIf(pRowData.colFldGridPageTitle Is Nothing, DBNull.Value, pRowData.colFldGridPageTitle)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGrid.FieldIndex.colFldGridPageSubTitle) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldGridPageSubTitle", IIf(pRowData.colFldGridPageSubTitle Is Nothing, DBNull.Value, pRowData.colFldGridPageSubTitle)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGrid.FieldIndex.colFldGridPractice) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldGridPractice", IIf(pRowData.colFldGridPractice Is Nothing, DBNull.Value, pRowData.colFldGridPractice)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGrid.FieldIndex.colFldFileName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldFileName", IIf(pRowData.colFldFileName Is Nothing, DBNull.Value, pRowData.colFldFileName)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGrid.FieldIndex.colFldSourceId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldSourceId", IIf(pRowData.colFldSourceId Is Nothing, DBNull.Value, pRowData.colFldSourceId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGrid.FieldIndex.colFldReportId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldReportId", IIf(pRowData.colFldReportId Is Nothing, DBNull.Value, pRowData.colFldReportId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGrid.FieldIndex.colFldFormViewTemplateName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldFormViewTemplateName", IIf(pRowData.colFldFormViewTemplateName Is Nothing, DBNull.Value, pRowData.colFldFormViewTemplateName)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGrid.FieldIndex.colFldInstructions) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldInstructions", IIf(pRowData.colFldInstructions Is Nothing, DBNull.Value, pRowData.colFldInstructions)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGrid.FieldIndex.colFldLegacyFavoritesGridID) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldLegacyFavoritesGridID", IIf(pRowData.colFldLegacyFavoritesGridID Is Nothing, DBNull.Value, pRowData.colFldLegacyFavoritesGridID)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGrid.FieldIndex.colFldReport2Id) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldReport2Id", IIf(pRowData.colFldReport2Id Is Nothing, DBNull.Value, pRowData.colFldReport2Id)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGrid.FieldIndex.colFldComment) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldComment", IIf(pRowData.colFldComment Is Nothing, DBNull.Value, pRowData.colFldComment)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGrid.FieldIndex.colFldFormViewReportId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldFormViewReportId", IIf(pRowData.colFldFormViewReportId Is Nothing, DBNull.Value, pRowData.colFldFormViewReportId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGrid.FieldIndex.colFldMapShowPinText) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldMapShowPinText", IIf(pRowData.colFldMapShowPinText Is Nothing, DBNull.Value, pRowData.colFldMapShowPinText)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGrid.FieldIndex.colFldMetaPracticeId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldMetaPracticeId", IIf(pRowData.colFldMetaPracticeId Is Nothing, DBNull.Value, pRowData.colFldMetaPracticeId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGrid.FieldIndex.colFldExtractHeaderRowHeight) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldExtractHeaderRowHeight", IIf(pRowData.colFldExtractHeaderRowHeight Is Nothing, DBNull.Value, pRowData.colFldExtractHeaderRowHeight)))
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

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer) As rowTblMetaGrid
            Return LoadByPrimaryKey(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pLoadEventUserState As Object) As rowTblMetaGrid
            Return LoadByPrimaryKey(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblMetaGrid
            Return LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblMetaGrid
            Dim zReturn As New rowTblMetaGrid
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaGrid] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblMetaGrid) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK_tblMetaGrid(pcolFldId As Integer) As List(Of rowTblMetaGrid)
            Return LoadByIDX_PK_tblMetaGrid(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaGrid(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of rowTblMetaGrid)
            Return LoadByIDX_PK_tblMetaGrid(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaGrid(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaGrid)
            Return LoadByIDX_PK_tblMetaGrid(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaGrid(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaGrid)
            Dim zReturn As New List(Of rowTblMetaGrid)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaGrid] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblMetaGrid)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblMetaGrid)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblMetaGrid)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaGrid)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaGrid)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaGrid)
            Dim zReturn As New List(Of rowTblMetaGrid)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaGrid]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblMetaGrid)

			Try
	            Dim zReturn As New List(Of rowTblMetaGrid)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblMetaGrid

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblMetaGrid		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblMetaGrid)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldId")) Then pObject.colFldId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldGridName")) Then pObject.colFldGridName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldGridName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldKeyField")) Then pObject.colFldKeyField = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldKeyField")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldGridPageTitle")) Then pObject.colFldGridPageTitle = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldGridPageTitle")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldGridPageSubTitle")) Then pObject.colFldGridPageSubTitle = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldGridPageSubTitle")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldGridPractice")) Then pObject.colFldGridPractice = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldGridPractice")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFileName")) Then pObject.colFldFileName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldFileName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSourceId")) Then pObject.colFldSourceId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldSourceId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldReportId")) Then pObject.colFldReportId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldReportId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFormViewTemplateName")) Then pObject.colFldFormViewTemplateName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldFormViewTemplateName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldInstructions")) Then pObject.colFldInstructions = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldInstructions")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldLegacyFavoritesGridID")) Then pObject.colFldLegacyFavoritesGridID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldLegacyFavoritesGridID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldReport2Id")) Then pObject.colFldReport2Id = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldReport2Id")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldComment")) Then pObject.colFldComment = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldComment")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFormViewReportId")) Then pObject.colFldFormViewReportId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldFormViewReportId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldMapShowPinText")) Then pObject.colFldMapShowPinText = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldMapShowPinText")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldMetaPracticeId")) Then pObject.colFldMetaPracticeId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldMetaPracticeId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldExtractHeaderRowHeight")) Then pObject.colFldExtractHeaderRowHeight = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "fldExtractHeaderRowHeight")
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
            If Not TypeOf zReturn Is rowTblMetaGrid Then Throw New ArgumentException("Generic type is not type of rowTblMetaGrid.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaGrid] WHERE [fldId] = @colFldId"
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

        Public Shared Function LoadByIDX_PK_tblMetaGrid(Of T)(pcolFldId As Integer) As List(Of T)
            Return LoadByIDX_PK_tblMetaGrid(Of T)(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaGrid(Of T)(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK_tblMetaGrid(Of T)(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaGrid(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK_tblMetaGrid(Of T)(pcolFldId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK_tblMetaGrid(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaGrid] WHERE [fldId] = @colFldId"
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
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaGrid]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblMetaGrid
        Implements IrowTblMetaGrid

        Public Event Loaded(pUserState As Object) Implements IrowTblMetaGrid.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblMetaGrid.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblMetaGrid.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblMetaGrid.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblMetaGrid.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblMetaGrid.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldId() As Nullable(Of Integer) Implements IrowTblMetaGrid.colFldId
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

        Public Property colFldGridName() As String Implements IrowTblMetaGrid.colFldGridName
            Get
                Return m_colFldGridName
            End Get
            Set
                If Not Same(m_colFldGridName, Value) Then
                    m_colFldGridName = Value
                    m_IsDirty(FieldIndex.colFldGridName) = True
                End If
            End Set
        End Property
        Private m_colFldGridName As String

        Public Property colFldKeyField() As String Implements IrowTblMetaGrid.colFldKeyField
            Get
                Return m_colFldKeyField
            End Get
            Set
                If Not Same(m_colFldKeyField, Value) Then
                    m_colFldKeyField = Value
                    m_IsDirty(FieldIndex.colFldKeyField) = True
                End If
            End Set
        End Property
        Private m_colFldKeyField As String

        Public Property colFldGridPageTitle() As String Implements IrowTblMetaGrid.colFldGridPageTitle
            Get
                Return m_colFldGridPageTitle
            End Get
            Set
                If Not Same(m_colFldGridPageTitle, Value) Then
                    m_colFldGridPageTitle = Value
                    m_IsDirty(FieldIndex.colFldGridPageTitle) = True
                End If
            End Set
        End Property
        Private m_colFldGridPageTitle As String

        Public Property colFldGridPageSubTitle() As String Implements IrowTblMetaGrid.colFldGridPageSubTitle
            Get
                Return m_colFldGridPageSubTitle
            End Get
            Set
                If Not Same(m_colFldGridPageSubTitle, Value) Then
                    m_colFldGridPageSubTitle = Value
                    m_IsDirty(FieldIndex.colFldGridPageSubTitle) = True
                End If
            End Set
        End Property
        Private m_colFldGridPageSubTitle As String

        Public Property colFldGridPractice() As String Implements IrowTblMetaGrid.colFldGridPractice
            Get
                Return m_colFldGridPractice
            End Get
            Set
                If Not Same(m_colFldGridPractice, Value) Then
                    m_colFldGridPractice = Value
                    m_IsDirty(FieldIndex.colFldGridPractice) = True
                End If
            End Set
        End Property
        Private m_colFldGridPractice As String

        Public Property colFldFileName() As String Implements IrowTblMetaGrid.colFldFileName
            Get
                Return m_colFldFileName
            End Get
            Set
                If Not Same(m_colFldFileName, Value) Then
                    m_colFldFileName = Value
                    m_IsDirty(FieldIndex.colFldFileName) = True
                End If
            End Set
        End Property
        Private m_colFldFileName As String

        Public Property colFldSourceId() As Nullable(Of Integer) Implements IrowTblMetaGrid.colFldSourceId
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

        Public Property colFldReportId() As Nullable(Of Integer) Implements IrowTblMetaGrid.colFldReportId
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

        Public Property colFldFormViewTemplateName() As String Implements IrowTblMetaGrid.colFldFormViewTemplateName
            Get
                Return m_colFldFormViewTemplateName
            End Get
            Set
                If Not Same(m_colFldFormViewTemplateName, Value) Then
                    m_colFldFormViewTemplateName = Value
                    m_IsDirty(FieldIndex.colFldFormViewTemplateName) = True
                End If
            End Set
        End Property
        Private m_colFldFormViewTemplateName As String

        Public Property colFldInstructions() As String Implements IrowTblMetaGrid.colFldInstructions
            Get
                Return m_colFldInstructions
            End Get
            Set
                If Not Same(m_colFldInstructions, Value) Then
                    m_colFldInstructions = Value
                    m_IsDirty(FieldIndex.colFldInstructions) = True
                End If
            End Set
        End Property
        Private m_colFldInstructions As String

        Public Property colFldLegacyFavoritesGridID() As Nullable(Of Integer) Implements IrowTblMetaGrid.colFldLegacyFavoritesGridID
            Get
                Return m_colFldLegacyFavoritesGridID
            End Get
            Set
                If Not Same(m_colFldLegacyFavoritesGridID, Value) Then
                    m_colFldLegacyFavoritesGridID = Value
                    m_IsDirty(FieldIndex.colFldLegacyFavoritesGridID) = True
                End If
            End Set
        End Property
        Private m_colFldLegacyFavoritesGridID As Nullable(Of Integer)

        Public Property colFldReport2Id() As Nullable(Of Integer) Implements IrowTblMetaGrid.colFldReport2Id
            Get
                Return m_colFldReport2Id
            End Get
            Set
                If Not Same(m_colFldReport2Id, Value) Then
                    m_colFldReport2Id = Value
                    m_IsDirty(FieldIndex.colFldReport2Id) = True
                End If
            End Set
        End Property
        Private m_colFldReport2Id As Nullable(Of Integer)

        Public Property colFldComment() As String Implements IrowTblMetaGrid.colFldComment
            Get
                Return m_colFldComment
            End Get
            Set
                If Not Same(m_colFldComment, Value) Then
                    m_colFldComment = Value
                    m_IsDirty(FieldIndex.colFldComment) = True
                End If
            End Set
        End Property
        Private m_colFldComment As String

        Public Property colFldFormViewReportId() As Nullable(Of Integer) Implements IrowTblMetaGrid.colFldFormViewReportId
            Get
                Return m_colFldFormViewReportId
            End Get
            Set
                If Not Same(m_colFldFormViewReportId, Value) Then
                    m_colFldFormViewReportId = Value
                    m_IsDirty(FieldIndex.colFldFormViewReportId) = True
                End If
            End Set
        End Property
        Private m_colFldFormViewReportId As Nullable(Of Integer)

        Public Property colFldMapShowPinText() As Nullable(Of Boolean) Implements IrowTblMetaGrid.colFldMapShowPinText
            Get
                Return m_colFldMapShowPinText
            End Get
            Set
                If Not Same(m_colFldMapShowPinText, Value) Then
                    m_colFldMapShowPinText = Value
                    m_IsDirty(FieldIndex.colFldMapShowPinText) = True
                End If
            End Set
        End Property
        Private m_colFldMapShowPinText As Nullable(Of Boolean)

        Public Property colFldMetaPracticeId() As Nullable(Of Integer) Implements IrowTblMetaGrid.colFldMetaPracticeId
            Get
                Return m_colFldMetaPracticeId
            End Get
            Set
                If Not Same(m_colFldMetaPracticeId, Value) Then
                    m_colFldMetaPracticeId = Value
                    m_IsDirty(FieldIndex.colFldMetaPracticeId) = True
                End If
            End Set
        End Property
        Private m_colFldMetaPracticeId As Nullable(Of Integer)

        Public Property colFldExtractHeaderRowHeight() As Nullable(Of Decimal) Implements IrowTblMetaGrid.colFldExtractHeaderRowHeight
            Get
                Return m_colFldExtractHeaderRowHeight
            End Get
            Set
                If Not Same(m_colFldExtractHeaderRowHeight, Value) Then
                    m_colFldExtractHeaderRowHeight = Value
                    m_IsDirty(FieldIndex.colFldExtractHeaderRowHeight) = True
                End If
            End Set
        End Property
        Private m_colFldExtractHeaderRowHeight As Nullable(Of Decimal)


        Public Function IsDirty(pIndex As rowTblMetaGrid.FieldIndex) As Boolean Implements IrowTblMetaGrid.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblMetaGrid.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblMetaGrid.SetIsDirty
            m_IsDirty(FieldIndex.colFldId) = pDirty
            m_IsDirty(FieldIndex.colFldGridName) = pDirty
            m_IsDirty(FieldIndex.colFldKeyField) = pDirty
            m_IsDirty(FieldIndex.colFldGridPageTitle) = pDirty
            m_IsDirty(FieldIndex.colFldGridPageSubTitle) = pDirty
            m_IsDirty(FieldIndex.colFldGridPractice) = pDirty
            m_IsDirty(FieldIndex.colFldFileName) = pDirty
            m_IsDirty(FieldIndex.colFldSourceId) = pDirty
            m_IsDirty(FieldIndex.colFldReportId) = pDirty
            m_IsDirty(FieldIndex.colFldFormViewTemplateName) = pDirty
            m_IsDirty(FieldIndex.colFldInstructions) = pDirty
            m_IsDirty(FieldIndex.colFldLegacyFavoritesGridID) = pDirty
            m_IsDirty(FieldIndex.colFldReport2Id) = pDirty
            m_IsDirty(FieldIndex.colFldComment) = pDirty
            m_IsDirty(FieldIndex.colFldFormViewReportId) = pDirty
            m_IsDirty(FieldIndex.colFldMapShowPinText) = pDirty
            m_IsDirty(FieldIndex.colFldMetaPracticeId) = pDirty
            m_IsDirty(FieldIndex.colFldExtractHeaderRowHeight) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblMetaGrid) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblMetaGrid
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldId  = 1
            colFldGridName 
            colFldKeyField 
            colFldGridPageTitle 
            colFldGridPageSubTitle 
            colFldGridPractice 
            colFldFileName 
            colFldSourceId 
            colFldReportId 
            colFldFormViewTemplateName 
            colFldInstructions 
            colFldLegacyFavoritesGridID 
            colFldReport2Id 
            colFldComment 
            colFldFormViewReportId 
            colFldMapShowPinText 
            colFldMetaPracticeId 
            colFldExtractHeaderRowHeight 
        End Enum

        Private m_IsDirty(18) As Boolean

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

    Public Interface IrowTblMetaGrid
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldId() As Nullable(Of Integer)
        Property colFldGridName() As String
        Property colFldKeyField() As String
        Property colFldGridPageTitle() As String
        Property colFldGridPageSubTitle() As String
        Property colFldGridPractice() As String
        Property colFldFileName() As String
        Property colFldSourceId() As Nullable(Of Integer)
        Property colFldReportId() As Nullable(Of Integer)
        Property colFldFormViewTemplateName() As String
        Property colFldInstructions() As String
        Property colFldLegacyFavoritesGridID() As Nullable(Of Integer)
        Property colFldReport2Id() As Nullable(Of Integer)
        Property colFldComment() As String
        Property colFldFormViewReportId() As Nullable(Of Integer)
        Property colFldMapShowPinText() As Nullable(Of Boolean)
        Property colFldMetaPracticeId() As Nullable(Of Integer)
        Property colFldExtractHeaderRowHeight() As Nullable(Of Decimal)
        Function IsDirty(pIndex As rowTblMetaGrid.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

