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
    Partial Public Class TblBatchProcessingEmail

        Public Shared Sub Delete(ByRef pRowData As IrowTblBatchProcessingEmail)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblBatchProcessingEmail, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblBatchProcessingEmail, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblBatchProcessingEmail, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[tblBatchProcessingEmail] " & _
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
        Dim zObj As rowTblBatchProcessingEmail = LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblBatchProcessingEmail)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblBatchProcessingEmail, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblBatchProcessingEmail, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[tblBatchProcessingEmail] WHERE [fldId] = @colFldId"

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
                        zUpdate = "UPDATE [dbo].[tblBatchProcessingEmail] SET " 
                        If pRowData.IsDirty(rowTblBatchProcessingEmail.FieldIndex.colFldTo) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldTo] = @colFldTo "
                        End If
                        If pRowData.IsDirty(rowTblBatchProcessingEmail.FieldIndex.colFldCc) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldCc] = @colFldCc "
                        End If
                        If pRowData.IsDirty(rowTblBatchProcessingEmail.FieldIndex.colFldBcc) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldBcc] = @colFldBcc "
                        End If
                        If pRowData.IsDirty(rowTblBatchProcessingEmail.FieldIndex.colFldSubject) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldSubject] = @colFldSubject "
                        End If
                        If pRowData.IsDirty(rowTblBatchProcessingEmail.FieldIndex.colFldBody) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldBody] = @colFldBody "
                        End If
                        If pRowData.IsDirty(rowTblBatchProcessingEmail.FieldIndex.colFldSentDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldSentDate] = @colFldSentDate "
                        End If
                        If pRowData.IsDirty(rowTblBatchProcessingEmail.FieldIndex.colFldHasException) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldHasException] = @colFldHasException "
                        End If
                        zWhere = " WHERE [fldId] = @colFldId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[tblBatchProcessingEmail] ([fldTo], [fldCc], [fldBcc], [fldSubject], [fldBody], [fldSentDate], [fldHasException])" & _
                            " VALUES (@colFldTo, @colFldCc, @colFldBcc, @colFldSubject, @colFldBody, @colFldSentDate, @colFldHasException); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[tblBatchProcessingEmail] ([fldTo], [fldCc], [fldBcc], [fldSubject], [fldBody], [fldSentDate], [fldHasException])" & _
                            " VALUES (@colFldTo, @colFldCc, @colFldBcc, @colFldSubject, @colFldBody, @colFldSentDate, @colFldHasException); SELECT SCOPE_IDENTITY()"
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

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblBatchProcessingEmail.FieldIndex.colFldTo) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldTo", IIf(pRowData.colFldTo Is Nothing, DBNull.Value, pRowData.colFldTo)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblBatchProcessingEmail.FieldIndex.colFldCc) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldCc", IIf(pRowData.colFldCc Is Nothing, DBNull.Value, pRowData.colFldCc)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblBatchProcessingEmail.FieldIndex.colFldBcc) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldBcc", IIf(pRowData.colFldBcc Is Nothing, DBNull.Value, pRowData.colFldBcc)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblBatchProcessingEmail.FieldIndex.colFldSubject) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldSubject", IIf(pRowData.colFldSubject Is Nothing, DBNull.Value, pRowData.colFldSubject)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblBatchProcessingEmail.FieldIndex.colFldBody) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldBody", IIf(pRowData.colFldBody Is Nothing, DBNull.Value, pRowData.colFldBody)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblBatchProcessingEmail.FieldIndex.colFldSentDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldSentDate", IIf(pRowData.colFldSentDate Is Nothing, DBNull.Value, pRowData.colFldSentDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblBatchProcessingEmail.FieldIndex.colFldHasException) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldHasException", IIf(pRowData.colFldHasException Is Nothing, DBNull.Value, pRowData.colFldHasException)))
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

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer) As rowTblBatchProcessingEmail
            Return LoadByPrimaryKey(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pLoadEventUserState As Object) As rowTblBatchProcessingEmail
            Return LoadByPrimaryKey(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblBatchProcessingEmail
            Return LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblBatchProcessingEmail
            Dim zReturn As New rowTblBatchProcessingEmail
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingEmail] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblBatchProcessingEmail) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_IX_tblBatchProcessingEmail_fldSentDate_fldHadException(pcolFldSentDate As DateTime, pcolFldHasException As Boolean) As List(Of rowTblBatchProcessingEmail)
            Return LoadByIDX_IX_tblBatchProcessingEmail_fldSentDate_fldHadException(pcolFldSentDate, pcolFldHasException, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_tblBatchProcessingEmail_fldSentDate_fldHadException(pcolFldSentDate As DateTime, pcolFldHasException As Boolean, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingEmail)
            Return LoadByIDX_IX_tblBatchProcessingEmail_fldSentDate_fldHadException(pcolFldSentDate, pcolFldHasException, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_tblBatchProcessingEmail_fldSentDate_fldHadException(pcolFldSentDate As DateTime, pcolFldHasException As Boolean, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblBatchProcessingEmail)
            Return LoadByIDX_IX_tblBatchProcessingEmail_fldSentDate_fldHadException(pcolFldSentDate, pcolFldHasException, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_tblBatchProcessingEmail_fldSentDate_fldHadException(pcolFldSentDate As DateTime, pcolFldHasException As Boolean, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingEmail)
            Dim zReturn As New List(Of rowTblBatchProcessingEmail)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingEmail] WHERE [fldSentDate] = @colFldSentDate AND [fldHasException] = @colFldHasException"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldSentDate", pcolFldSentDate))
            zCmd.Parameters.Add(New SQLParameter("@colFldHasException", pcolFldHasException))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function
        Public Shared Function LoadByIDX_PK__tblBatch__36326BE3297984BB(pcolFldId As Integer) As List(Of rowTblBatchProcessingEmail)
            Return LoadByIDX_PK__tblBatch__36326BE3297984BB(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblBatch__36326BE3297984BB(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingEmail)
            Return LoadByIDX_PK__tblBatch__36326BE3297984BB(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblBatch__36326BE3297984BB(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblBatchProcessingEmail)
            Return LoadByIDX_PK__tblBatch__36326BE3297984BB(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblBatch__36326BE3297984BB(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingEmail)
            Dim zReturn As New List(Of rowTblBatchProcessingEmail)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingEmail] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblBatchProcessingEmail)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblBatchProcessingEmail)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblBatchProcessingEmail)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblBatchProcessingEmail)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingEmail)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingEmail)
            Dim zReturn As New List(Of rowTblBatchProcessingEmail)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingEmail]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingEmail)

			Try
	            Dim zReturn As New List(Of rowTblBatchProcessingEmail)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblBatchProcessingEmail

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblBatchProcessingEmail		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblBatchProcessingEmail)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldId")) Then pObject.colFldId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldTo")) Then pObject.colFldTo = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldTo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldCc")) Then pObject.colFldCc = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldCc")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldBcc")) Then pObject.colFldBcc = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldBcc")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSubject")) Then pObject.colFldSubject = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldSubject")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldBody")) Then pObject.colFldBody = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldBody")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSentDate")) Then pObject.colFldSentDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "fldSentDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldHasException")) Then pObject.colFldHasException = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldHasException")
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
            If Not TypeOf zReturn Is rowTblBatchProcessingEmail Then Throw New ArgumentException("Generic type is not type of rowTblBatchProcessingEmail.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingEmail] WHERE [fldId] = @colFldId"
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

        Public Shared Function LoadByIDX_IX_tblBatchProcessingEmail_fldSentDate_fldHadException(Of T)(pcolFldSentDate As DateTime, pcolFldHasException As Boolean) As List(Of T)
            Return LoadByIDX_IX_tblBatchProcessingEmail_fldSentDate_fldHadException(Of T)(pcolFldSentDate, pcolFldHasException, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_tblBatchProcessingEmail_fldSentDate_fldHadException(Of T)(pcolFldSentDate As DateTime, pcolFldHasException As Boolean, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_IX_tblBatchProcessingEmail_fldSentDate_fldHadException(Of T)(pcolFldSentDate, pcolFldHasException, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_tblBatchProcessingEmail_fldSentDate_fldHadException(Of T)(pcolFldSentDate As DateTime, pcolFldHasException As Boolean, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_IX_tblBatchProcessingEmail_fldSentDate_fldHadException(Of T)(pcolFldSentDate, pcolFldHasException, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_IX_tblBatchProcessingEmail_fldSentDate_fldHadException(Of T)(pcolFldSentDate As DateTime, pcolFldHasException As Boolean, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingEmail] WHERE [fldSentDate] = @colFldSentDate AND [fldHasException] = @colFldHasException"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldSentDate", pcolFldSentDate))
            zCmd.Parameters.Add(New SQLParameter("@colFldHasException", pcolFldHasException))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_PK__tblBatch__36326BE3297984BB(Of T)(pcolFldId As Integer) As List(Of T)
            Return LoadByIDX_PK__tblBatch__36326BE3297984BB(Of T)(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblBatch__36326BE3297984BB(Of T)(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK__tblBatch__36326BE3297984BB(Of T)(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblBatch__36326BE3297984BB(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK__tblBatch__36326BE3297984BB(Of T)(pcolFldId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK__tblBatch__36326BE3297984BB(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingEmail] WHERE [fldId] = @colFldId"
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
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingEmail]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblBatchProcessingEmail
        Implements IrowTblBatchProcessingEmail

        Public Event Loaded(pUserState As Object) Implements IrowTblBatchProcessingEmail.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblBatchProcessingEmail.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblBatchProcessingEmail.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblBatchProcessingEmail.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblBatchProcessingEmail.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblBatchProcessingEmail.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldId() As Nullable(Of Integer) Implements IrowTblBatchProcessingEmail.colFldId
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

        Public Property colFldTo() As String Implements IrowTblBatchProcessingEmail.colFldTo
            Get
                Return m_colFldTo
            End Get
            Set
                If Not Same(m_colFldTo, Value) Then
                    m_colFldTo = Value
                    m_IsDirty(FieldIndex.colFldTo) = True
                End If
            End Set
        End Property
        Private m_colFldTo As String

        Public Property colFldCc() As String Implements IrowTblBatchProcessingEmail.colFldCc
            Get
                Return m_colFldCc
            End Get
            Set
                If Not Same(m_colFldCc, Value) Then
                    m_colFldCc = Value
                    m_IsDirty(FieldIndex.colFldCc) = True
                End If
            End Set
        End Property
        Private m_colFldCc As String

        Public Property colFldBcc() As String Implements IrowTblBatchProcessingEmail.colFldBcc
            Get
                Return m_colFldBcc
            End Get
            Set
                If Not Same(m_colFldBcc, Value) Then
                    m_colFldBcc = Value
                    m_IsDirty(FieldIndex.colFldBcc) = True
                End If
            End Set
        End Property
        Private m_colFldBcc As String

        Public Property colFldSubject() As String Implements IrowTblBatchProcessingEmail.colFldSubject
            Get
                Return m_colFldSubject
            End Get
            Set
                If Not Same(m_colFldSubject, Value) Then
                    m_colFldSubject = Value
                    m_IsDirty(FieldIndex.colFldSubject) = True
                End If
            End Set
        End Property
        Private m_colFldSubject As String

        Public Property colFldBody() As String Implements IrowTblBatchProcessingEmail.colFldBody
            Get
                Return m_colFldBody
            End Get
            Set
                If Not Same(m_colFldBody, Value) Then
                    m_colFldBody = Value
                    m_IsDirty(FieldIndex.colFldBody) = True
                End If
            End Set
        End Property
        Private m_colFldBody As String

        Public Property colFldSentDate() As Nullable(Of DateTime) Implements IrowTblBatchProcessingEmail.colFldSentDate
            Get
                Return m_colFldSentDate
            End Get
            Set
                If Not Same(m_colFldSentDate, Value) Then
                    m_colFldSentDate = Value
                    m_IsDirty(FieldIndex.colFldSentDate) = True
                End If
            End Set
        End Property
        Private m_colFldSentDate As Nullable(Of DateTime)

        Public Property colFldHasException() As Nullable(Of Boolean) Implements IrowTblBatchProcessingEmail.colFldHasException
            Get
                Return m_colFldHasException
            End Get
            Set
                If Not Same(m_colFldHasException, Value) Then
                    m_colFldHasException = Value
                    m_IsDirty(FieldIndex.colFldHasException) = True
                End If
            End Set
        End Property
        Private m_colFldHasException As Nullable(Of Boolean)


        Public Function IsDirty(pIndex As rowTblBatchProcessingEmail.FieldIndex) As Boolean Implements IrowTblBatchProcessingEmail.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblBatchProcessingEmail.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblBatchProcessingEmail.SetIsDirty
            m_IsDirty(FieldIndex.colFldId) = pDirty
            m_IsDirty(FieldIndex.colFldTo) = pDirty
            m_IsDirty(FieldIndex.colFldCc) = pDirty
            m_IsDirty(FieldIndex.colFldBcc) = pDirty
            m_IsDirty(FieldIndex.colFldSubject) = pDirty
            m_IsDirty(FieldIndex.colFldBody) = pDirty
            m_IsDirty(FieldIndex.colFldSentDate) = pDirty
            m_IsDirty(FieldIndex.colFldHasException) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblBatchProcessingEmail) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblBatchProcessingEmail
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldId  = 1
            colFldTo 
            colFldCc 
            colFldBcc 
            colFldSubject 
            colFldBody 
            colFldSentDate 
            colFldHasException 
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

    Public Interface IrowTblBatchProcessingEmail
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldId() As Nullable(Of Integer)
        Property colFldTo() As String
        Property colFldCc() As String
        Property colFldBcc() As String
        Property colFldSubject() As String
        Property colFldBody() As String
        Property colFldSentDate() As Nullable(Of DateTime)
        Property colFldHasException() As Nullable(Of Boolean)
        Function IsDirty(pIndex As rowTblBatchProcessingEmail.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

