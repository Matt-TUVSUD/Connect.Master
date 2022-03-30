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
    Partial Public Class TblNotification

        Public Shared Sub Delete(ByRef pRowData As IrowTblNotification)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblNotification, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblNotification, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblNotification, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colNotificationID) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[tblNotification] " & _
                        "WHERE [NotificationID] = @colNotificationID"

                Dim zCmd As New SQLCommand
                zCmd.CommandText = zSQL
                zCmd.Parameters.Add(New SQLParameter("@colNotificationID", pRowData.colNotificationID))

                zCmd.Transaction=pTransaction
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)

                pRowData.RaiseDeletedEvent(pDeleteEventUserState)

            End If

        End Sub

        Public Shared Sub Delete(pcolNotificationID As Integer)
            Delete(pcolNotificationID, Nothing, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolNotificationID As Integer, pDeleteEventUserState As Object)
            Delete(pcolNotificationID, Nothing, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Delete(pcolNotificationID As Integer, ByRef pTransaction As SqlClient.SqlTransaction)
        Delete(pcolNotificationID, pTransaction, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolNotificationID As Integer, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
        Dim zObj As rowTblNotification = LoadByPrimaryKey(pcolNotificationID, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblNotification)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblNotification, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblNotification, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colNotificationID) Then

                zSQL = "SELECT COUNT(*) from [dbo].[tblNotification] WHERE [NotificationID] = @colNotificationID"

                Dim zCmdDoesExist As New SQLCommand

                zCmdDoesExist.CommandText = zSQL

                zCmdDoesExist.Parameters.Add(new SQLParameter("@colNotificationID", pRowData.colNotificationID))

                'if zExistInDB > 0  then  PK exists in the DB
                zCmdDoesExist.Transaction = pTransaction
                zExistInDB = razor.UtilSQLServer.ExecuteScalar(zCmdDoesExist)
            End If

            If razor.UtilSQLServer.IsKeySet(pRowData.colNotificationID) And zExistInDB > 0 Then
                zMode = "UPDATE"
            End If
            If razor.UtilSQLServer.IsKeySet(pRowData.colNotificationID) And zExistInDB = 0 Then
                zMode = "INSERTwithKey"
            End If
            If Not razor.UtilSQLServer.IsKeySet(pRowData.colNotificationID) Then
                zMode = "INSERTnoKey"
            End If

            Select Case zMode
                Case "UPDATE"
                    If pRowData.IsDirty Then
                        Dim zUpdate As String = ""
                        Dim zSet As String = ""
                        Dim zWhere As String = ""
                        zUpdate = "UPDATE [dbo].[tblNotification] SET " 
                        If pRowData.IsDirty(rowTblNotification.FieldIndex.colTo) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [To] = @colTo "
                        End If
                        If pRowData.IsDirty(rowTblNotification.FieldIndex.colCc) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [Cc] = @colCc "
                        End If
                        If pRowData.IsDirty(rowTblNotification.FieldIndex.colBcc) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [Bcc] = @colBcc "
                        End If
                        If pRowData.IsDirty(rowTblNotification.FieldIndex.colSubject) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [Subject] = @colSubject "
                        End If
                        If pRowData.IsDirty(rowTblNotification.FieldIndex.colBody) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [Body] = @colBody "
                        End If
                        If pRowData.IsDirty(rowTblNotification.FieldIndex.colCreateDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [CreateDate] = @colCreateDate "
                        End If
                        If pRowData.IsDirty(rowTblNotification.FieldIndex.colSentDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [SentDate] = @colSentDate "
                        End If
                        If pRowData.IsDirty(rowTblNotification.FieldIndex.colProcessedDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ProcessedDate] = @colProcessedDate "
                        End If
                        If pRowData.IsDirty(rowTblNotification.FieldIndex.colIsException) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [IsException] = @colIsException "
                        End If
                        If pRowData.IsDirty(rowTblNotification.FieldIndex.colAttachmentData) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [AttachmentData] = @colAttachmentData "
                        End If
                        If pRowData.IsDirty(rowTblNotification.FieldIndex.colNotificationType) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [NotificationType] = @colNotificationType "
                        End If
                        zWhere = " WHERE [NotificationID] = @colNotificationID"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[tblNotification] ([To], [Cc], [Bcc], [Subject], [Body], [CreateDate], [SentDate], [ProcessedDate], [IsException], [AttachmentData], [NotificationType])" & _
                            " VALUES (@colTo, @colCc, @colBcc, @colSubject, @colBody, @colCreateDate, @colSentDate, @colProcessedDate, @colIsException, @colAttachmentData, @colNotificationType); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[tblNotification] ([To], [Cc], [Bcc], [Subject], [Body], [CreateDate], [SentDate], [ProcessedDate], [IsException], [AttachmentData], [NotificationType])" & _
                            " VALUES (@colTo, @colCc, @colBcc, @colSubject, @colBody, @colCreateDate, @colSentDate, @colProcessedDate, @colIsException, @colAttachmentData, @colNotificationType); SELECT SCOPE_IDENTITY()"
                Case Else
            End Select

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

			'IF UPDATE, SET PK PARAMETER
            If zMode = "UPDATE" Then
                zCmd.Parameters.Add(New SQLParameter("@colNotificationID", pRowData.colNotificationID))
            End If

			'IF INSERTING, KEY HAS VALUE AND KEY IS NOT IDENTITY, SET PK PARAMETER
			If zMode = "INSERTwithKey" Then
            End If

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNotification.FieldIndex.colTo) Then
                    zCmd.Parameters.Add(New SqlParameter("@colTo", IIf(pRowData.colTo Is Nothing, DBNull.Value, pRowData.colTo)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNotification.FieldIndex.colCc) Then
                    zCmd.Parameters.Add(New SqlParameter("@colCc", IIf(pRowData.colCc Is Nothing, DBNull.Value, pRowData.colCc)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNotification.FieldIndex.colBcc) Then
                    zCmd.Parameters.Add(New SqlParameter("@colBcc", IIf(pRowData.colBcc Is Nothing, DBNull.Value, pRowData.colBcc)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNotification.FieldIndex.colSubject) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSubject", IIf(pRowData.colSubject Is Nothing, DBNull.Value, pRowData.colSubject)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNotification.FieldIndex.colBody) Then
                    zCmd.Parameters.Add(New SqlParameter("@colBody", IIf(pRowData.colBody Is Nothing, DBNull.Value, pRowData.colBody)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNotification.FieldIndex.colCreateDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colCreateDate", IIf(pRowData.colCreateDate Is Nothing, DBNull.Value, pRowData.colCreateDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNotification.FieldIndex.colSentDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSentDate", IIf(pRowData.colSentDate Is Nothing, DBNull.Value, pRowData.colSentDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNotification.FieldIndex.colProcessedDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colProcessedDate", IIf(pRowData.colProcessedDate Is Nothing, DBNull.Value, pRowData.colProcessedDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNotification.FieldIndex.colIsException) Then
                    zCmd.Parameters.Add(New SqlParameter("@colIsException", IIf(pRowData.colIsException Is Nothing, DBNull.Value, pRowData.colIsException)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNotification.FieldIndex.colAttachmentData) Then
                    zCmd.Parameters.Add(New SqlParameter("@colAttachmentData", IIf(pRowData.colAttachmentData Is Nothing, DBNull.Value, pRowData.colAttachmentData)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblNotification.FieldIndex.colNotificationType) Then
                    zCmd.Parameters.Add(New SqlParameter("@colNotificationType", IIf(pRowData.colNotificationType Is Nothing, DBNull.Value, pRowData.colNotificationType)))
                End If

            zCmd.Transaction=pTransaction
            If zMode = "INSERTnoKey" Then
                Dim zLastId As Long = 0
                zLastId = razor.UtilSQLServer.ExecuteNonQueryRowId(zCmd)

                pRowData.colNotificationID = zLastId
            Else
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)
            End If

            pRowData.SetIsDirty(False)
            pRowData.RaiseSavedEvent(pSavedEventUserState)

		End If

        End Sub

        Public Shared Function LoadByPrimaryKey(pcolNotificationID As Integer) As rowTblNotification
            Return LoadByPrimaryKey(pcolNotificationID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolNotificationID As Integer, pLoadEventUserState As Object) As rowTblNotification
            Return LoadByPrimaryKey(pcolNotificationID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolNotificationID As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblNotification
            Return LoadByPrimaryKey(pcolNotificationID, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolNotificationID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblNotification
            Dim zReturn As New rowTblNotification
            Dim zSQL As String = "SELECT * FROM [dbo].[tblNotification] WHERE [NotificationID] = @colNotificationID"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colNotificationID", pcolNotificationID))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblNotification) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK__tmp_ms_x__20CF2E32076463D9(pcolNotificationID As Integer) As List(Of rowTblNotification)
            Return LoadByIDX_PK__tmp_ms_x__20CF2E32076463D9(pcolNotificationID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tmp_ms_x__20CF2E32076463D9(pcolNotificationID As Integer, pLoadEventUserState As Object) As List(Of rowTblNotification)
            Return LoadByIDX_PK__tmp_ms_x__20CF2E32076463D9(pcolNotificationID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tmp_ms_x__20CF2E32076463D9(pcolNotificationID As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblNotification)
            Return LoadByIDX_PK__tmp_ms_x__20CF2E32076463D9(pcolNotificationID, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tmp_ms_x__20CF2E32076463D9(pcolNotificationID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblNotification)
            Dim zReturn As New List(Of rowTblNotification)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblNotification] WHERE [NotificationID] = @colNotificationID"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colNotificationID", pcolNotificationID))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblNotification)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblNotification)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblNotification)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblNotification)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblNotification)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblNotification)
            Dim zReturn As New List(Of rowTblNotification)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblNotification]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblNotification)

			Try
	            Dim zReturn As New List(Of rowTblNotification)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblNotification

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblNotification		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblNotification)
			If Not pReader.IsDBNull(pReader.GetOrdinal("NotificationID")) Then pObject.colNotificationID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "NotificationID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("To")) Then pObject.colTo = UtilSQLServer.SafeReader.SafeReadString(pReader, "To")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Cc")) Then pObject.colCc = UtilSQLServer.SafeReader.SafeReadString(pReader, "Cc")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Bcc")) Then pObject.colBcc = UtilSQLServer.SafeReader.SafeReadString(pReader, "Bcc")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Subject")) Then pObject.colSubject = UtilSQLServer.SafeReader.SafeReadString(pReader, "Subject")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Body")) Then pObject.colBody = UtilSQLServer.SafeReader.SafeReadString(pReader, "Body")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CreateDate")) Then pObject.colCreateDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "CreateDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SentDate")) Then pObject.colSentDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "SentDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ProcessedDate")) Then pObject.colProcessedDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "ProcessedDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("IsException")) Then pObject.colIsException = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "IsException")
			If Not pReader.IsDBNull(pReader.GetOrdinal("AttachmentData")) Then pObject.colAttachmentData = UtilSQLServer.SafeReader.SafeReadString(pReader, "AttachmentData")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NotificationType")) Then pObject.colNotificationType = UtilSQLServer.SafeReader.SafeReadString(pReader, "NotificationType")
			pObject.SetIsDirty(False)
			Return pObject
		End	 Function

    #Region "Reflection Based Load Functions"

        Public Shared Function LoadByPrimaryKey(Of T)(pcolNotificationID As Integer) As T
            Return LoadByPrimaryKey(Of T)(pcolNotificationID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolNotificationID As Integer, pLoadEventUserState As Object) As T
            Return LoadByPrimaryKey(Of T)(pcolNotificationID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolNotificationID As Integer, pTransaction As SqlClient.SqlTransaction) As T
            Return LoadByPrimaryKey(Of T)(pcolNotificationID, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolNotificationID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As T

            Dim zReturn As Object = Activator.CreateInstance(Of T)()
            If Not TypeOf zReturn Is rowTblNotification Then Throw New ArgumentException("Generic type is not type of rowTblNotification.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[tblNotification] WHERE [NotificationID] = @colNotificationID"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colNotificationID", pcolNotificationID))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of T) = ReadData(Of T)(zCmd, pLoadEventUserState)
            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

        End Function

        Public Shared Function LoadByIDX_PK__tmp_ms_x__20CF2E32076463D9(Of T)(pcolNotificationID As Integer) As List(Of T)
            Return LoadByIDX_PK__tmp_ms_x__20CF2E32076463D9(Of T)(pcolNotificationID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tmp_ms_x__20CF2E32076463D9(Of T)(pcolNotificationID As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK__tmp_ms_x__20CF2E32076463D9(Of T)(pcolNotificationID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tmp_ms_x__20CF2E32076463D9(Of T)(pcolNotificationID As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK__tmp_ms_x__20CF2E32076463D9(Of T)(pcolNotificationID, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK__tmp_ms_x__20CF2E32076463D9(Of T)(pcolNotificationID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblNotification] WHERE [NotificationID] = @colNotificationID"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colNotificationID", pcolNotificationID))

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
            Dim zSQL As String = "SELECT * FROM [dbo].[tblNotification]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblNotification
        Implements IrowTblNotification

        Public Event Loaded(pUserState As Object) Implements IrowTblNotification.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblNotification.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblNotification.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblNotification.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblNotification.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblNotification.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colNotificationID() As Nullable(Of Integer) Implements IrowTblNotification.colNotificationID
            Get
                Return m_colNotificationID
            End Get
            Set
                If Not Same(m_colNotificationID, Value) Then
                    m_colNotificationID = Value
                    m_IsDirty(FieldIndex.colNotificationID) = True
                End If
            End Set
        End Property
        Private m_colNotificationID As Nullable(Of Integer)

        Public Property colTo() As String Implements IrowTblNotification.colTo
            Get
                Return m_colTo
            End Get
            Set
                If Not Same(m_colTo, Value) Then
                    m_colTo = Value
                    m_IsDirty(FieldIndex.colTo) = True
                End If
            End Set
        End Property
        Private m_colTo As String

        Public Property colCc() As String Implements IrowTblNotification.colCc
            Get
                Return m_colCc
            End Get
            Set
                If Not Same(m_colCc, Value) Then
                    m_colCc = Value
                    m_IsDirty(FieldIndex.colCc) = True
                End If
            End Set
        End Property
        Private m_colCc As String

        Public Property colBcc() As String Implements IrowTblNotification.colBcc
            Get
                Return m_colBcc
            End Get
            Set
                If Not Same(m_colBcc, Value) Then
                    m_colBcc = Value
                    m_IsDirty(FieldIndex.colBcc) = True
                End If
            End Set
        End Property
        Private m_colBcc As String

        Public Property colSubject() As String Implements IrowTblNotification.colSubject
            Get
                Return m_colSubject
            End Get
            Set
                If Not Same(m_colSubject, Value) Then
                    m_colSubject = Value
                    m_IsDirty(FieldIndex.colSubject) = True
                End If
            End Set
        End Property
        Private m_colSubject As String

        Public Property colBody() As String Implements IrowTblNotification.colBody
            Get
                Return m_colBody
            End Get
            Set
                If Not Same(m_colBody, Value) Then
                    m_colBody = Value
                    m_IsDirty(FieldIndex.colBody) = True
                End If
            End Set
        End Property
        Private m_colBody As String

        Public Property colCreateDate() As Nullable(Of DateTime) Implements IrowTblNotification.colCreateDate
            Get
                Return m_colCreateDate
            End Get
            Set
                If Not Same(m_colCreateDate, Value) Then
                    m_colCreateDate = Value
                    m_IsDirty(FieldIndex.colCreateDate) = True
                End If
            End Set
        End Property
        Private m_colCreateDate As Nullable(Of DateTime)

        Public Property colSentDate() As Nullable(Of DateTime) Implements IrowTblNotification.colSentDate
            Get
                Return m_colSentDate
            End Get
            Set
                If Not Same(m_colSentDate, Value) Then
                    m_colSentDate = Value
                    m_IsDirty(FieldIndex.colSentDate) = True
                End If
            End Set
        End Property
        Private m_colSentDate As Nullable(Of DateTime)

        Public Property colProcessedDate() As Nullable(Of DateTime) Implements IrowTblNotification.colProcessedDate
            Get
                Return m_colProcessedDate
            End Get
            Set
                If Not Same(m_colProcessedDate, Value) Then
                    m_colProcessedDate = Value
                    m_IsDirty(FieldIndex.colProcessedDate) = True
                End If
            End Set
        End Property
        Private m_colProcessedDate As Nullable(Of DateTime)

        Public Property colIsException() As Nullable(Of Boolean) Implements IrowTblNotification.colIsException
            Get
                Return m_colIsException
            End Get
            Set
                If Not Same(m_colIsException, Value) Then
                    m_colIsException = Value
                    m_IsDirty(FieldIndex.colIsException) = True
                End If
            End Set
        End Property
        Private m_colIsException As Nullable(Of Boolean)

        Public Property colAttachmentData() As String Implements IrowTblNotification.colAttachmentData
            Get
                Return m_colAttachmentData
            End Get
            Set
                If Not Same(m_colAttachmentData, Value) Then
                    m_colAttachmentData = Value
                    m_IsDirty(FieldIndex.colAttachmentData) = True
                End If
            End Set
        End Property
        Private m_colAttachmentData As String

        Public Property colNotificationType() As String Implements IrowTblNotification.colNotificationType
            Get
                Return m_colNotificationType
            End Get
            Set
                If Not Same(m_colNotificationType, Value) Then
                    m_colNotificationType = Value
                    m_IsDirty(FieldIndex.colNotificationType) = True
                End If
            End Set
        End Property
        Private m_colNotificationType As String


        Public Function IsDirty(pIndex As rowTblNotification.FieldIndex) As Boolean Implements IrowTblNotification.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblNotification.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblNotification.SetIsDirty
            m_IsDirty(FieldIndex.colNotificationID) = pDirty
            m_IsDirty(FieldIndex.colTo) = pDirty
            m_IsDirty(FieldIndex.colCc) = pDirty
            m_IsDirty(FieldIndex.colBcc) = pDirty
            m_IsDirty(FieldIndex.colSubject) = pDirty
            m_IsDirty(FieldIndex.colBody) = pDirty
            m_IsDirty(FieldIndex.colCreateDate) = pDirty
            m_IsDirty(FieldIndex.colSentDate) = pDirty
            m_IsDirty(FieldIndex.colProcessedDate) = pDirty
            m_IsDirty(FieldIndex.colIsException) = pDirty
            m_IsDirty(FieldIndex.colAttachmentData) = pDirty
            m_IsDirty(FieldIndex.colNotificationType) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblNotification) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblNotification
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colNotificationID  = 1
            colTo 
            colCc 
            colBcc 
            colSubject 
            colBody 
            colCreateDate 
            colSentDate 
            colProcessedDate 
            colIsException 
            colAttachmentData 
            colNotificationType 
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

    Public Interface IrowTblNotification
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colNotificationID() As Nullable(Of Integer)
        Property colTo() As String
        Property colCc() As String
        Property colBcc() As String
        Property colSubject() As String
        Property colBody() As String
        Property colCreateDate() As Nullable(Of DateTime)
        Property colSentDate() As Nullable(Of DateTime)
        Property colProcessedDate() As Nullable(Of DateTime)
        Property colIsException() As Nullable(Of Boolean)
        Property colAttachmentData() As String
        Property colNotificationType() As String
        Function IsDirty(pIndex As rowTblNotification.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

