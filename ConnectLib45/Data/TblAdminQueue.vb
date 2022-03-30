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
    Partial Public Class TblAdminQueue

        Public Shared Sub Delete(ByRef pRowData As IrowTblAdminQueue)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblAdminQueue, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblAdminQueue, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblAdminQueue, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldID) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [adm].[tblAdminQueue] " & _
                        "WHERE [fldID] = @colFldID"

                Dim zCmd As New SQLCommand
                zCmd.CommandText = zSQL
                zCmd.Parameters.Add(New SQLParameter("@colFldID", pRowData.colFldID))

                zCmd.Transaction=pTransaction
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)

                pRowData.RaiseDeletedEvent(pDeleteEventUserState)

            End If

        End Sub

        Public Shared Sub Delete(pcolFldID As Integer)
            Delete(pcolFldID, Nothing, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolFldID As Integer, pDeleteEventUserState As Object)
            Delete(pcolFldID, Nothing, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Delete(pcolFldID As Integer, ByRef pTransaction As SqlClient.SqlTransaction)
        Delete(pcolFldID, pTransaction, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolFldID As Integer, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
        Dim zObj As rowTblAdminQueue = LoadByPrimaryKey(pcolFldID, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblAdminQueue)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblAdminQueue, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblAdminQueue, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldID) Then

                zSQL = "SELECT COUNT(*) from [adm].[tblAdminQueue] WHERE [fldID] = @colFldID"

                Dim zCmdDoesExist As New SQLCommand

                zCmdDoesExist.CommandText = zSQL

                zCmdDoesExist.Parameters.Add(new SQLParameter("@colFldID", pRowData.colFldID))

                'if zExistInDB > 0  then  PK exists in the DB
                zCmdDoesExist.Transaction = pTransaction
                zExistInDB = razor.UtilSQLServer.ExecuteScalar(zCmdDoesExist)
            End If

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldID) And zExistInDB > 0 Then
                zMode = "UPDATE"
            End If
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldID) And zExistInDB = 0 Then
                zMode = "INSERTwithKey"
            End If
            If Not razor.UtilSQLServer.IsKeySet(pRowData.colFldID) Then
                zMode = "INSERTnoKey"
            End If

            Select Case zMode
                Case "UPDATE"
                    If pRowData.IsDirty Then
                        Dim zUpdate As String = ""
                        Dim zSet As String = ""
                        Dim zWhere As String = ""
                        zUpdate = "UPDATE [adm].[tblAdminQueue] SET " 
                        If pRowData.IsDirty(rowTblAdminQueue.FieldIndex.colFldTo) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldTo] = @colFldTo "
                        End If
                        If pRowData.IsDirty(rowTblAdminQueue.FieldIndex.colFldViewIDs) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldViewIDs] = @colFldViewIDs "
                        End If
                        If pRowData.IsDirty(rowTblAdminQueue.FieldIndex.colFldDBAFilter) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldDBAFilter] = @colFldDBAFilter "
                        End If
                        If pRowData.IsDirty(rowTblAdminQueue.FieldIndex.colFldCreateBy) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldCreateBy] = @colFldCreateBy "
                        End If
                        If pRowData.IsDirty(rowTblAdminQueue.FieldIndex.colFldCreateDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldCreateDate] = @colFldCreateDate "
                        End If
                        If pRowData.IsDirty(rowTblAdminQueue.FieldIndex.colFldIsProcessed) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldIsProcessed] = @colFldIsProcessed "
                        End If
                        If pRowData.IsDirty(rowTblAdminQueue.FieldIndex.colFldStatus) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldStatus] = @colFldStatus "
                        End If
                        If pRowData.IsDirty(rowTblAdminQueue.FieldIndex.colFldProcessedDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldProcessedDate] = @colFldProcessedDate "
                        End If
                        If pRowData.IsDirty(rowTblAdminQueue.FieldIndex.colFldException) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldException] = @colFldException "
                        End If
                        zWhere = " WHERE [fldID] = @colFldID"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [adm].[tblAdminQueue] ([fldTo], [fldViewIDs], [fldDBAFilter], [fldCreateBy], [fldCreateDate], [fldIsProcessed], [fldStatus], [fldProcessedDate], [fldException])" & _
                            " VALUES (@colFldTo, @colFldViewIDs, @colFldDBAFilter, @colFldCreateBy, @colFldCreateDate, @colFldIsProcessed, @colFldStatus, @colFldProcessedDate, @colFldException); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [adm].[tblAdminQueue] ([fldTo], [fldViewIDs], [fldDBAFilter], [fldCreateBy], [fldCreateDate], [fldIsProcessed], [fldStatus], [fldProcessedDate], [fldException])" & _
                            " VALUES (@colFldTo, @colFldViewIDs, @colFldDBAFilter, @colFldCreateBy, @colFldCreateDate, @colFldIsProcessed, @colFldStatus, @colFldProcessedDate, @colFldException); SELECT SCOPE_IDENTITY()"
                Case Else
            End Select

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

			'IF UPDATE, SET PK PARAMETER
            If zMode = "UPDATE" Then
                zCmd.Parameters.Add(New SQLParameter("@colFldID", pRowData.colFldID))
            End If

			'IF INSERTING, KEY HAS VALUE AND KEY IS NOT IDENTITY, SET PK PARAMETER
			If zMode = "INSERTwithKey" Then
            End If

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblAdminQueue.FieldIndex.colFldTo) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldTo", IIf(pRowData.colFldTo Is Nothing, DBNull.Value, pRowData.colFldTo)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblAdminQueue.FieldIndex.colFldViewIDs) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldViewIDs", IIf(pRowData.colFldViewIDs Is Nothing, DBNull.Value, pRowData.colFldViewIDs)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblAdminQueue.FieldIndex.colFldDBAFilter) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldDBAFilter", IIf(pRowData.colFldDBAFilter Is Nothing, DBNull.Value, pRowData.colFldDBAFilter)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblAdminQueue.FieldIndex.colFldCreateBy) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldCreateBy", IIf(pRowData.colFldCreateBy Is Nothing, DBNull.Value, pRowData.colFldCreateBy)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblAdminQueue.FieldIndex.colFldCreateDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldCreateDate", IIf(pRowData.colFldCreateDate Is Nothing, DBNull.Value, pRowData.colFldCreateDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblAdminQueue.FieldIndex.colFldIsProcessed) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldIsProcessed", IIf(pRowData.colFldIsProcessed Is Nothing, DBNull.Value, pRowData.colFldIsProcessed)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblAdminQueue.FieldIndex.colFldStatus) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldStatus", IIf(pRowData.colFldStatus Is Nothing, DBNull.Value, pRowData.colFldStatus)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblAdminQueue.FieldIndex.colFldProcessedDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldProcessedDate", IIf(pRowData.colFldProcessedDate Is Nothing, DBNull.Value, pRowData.colFldProcessedDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblAdminQueue.FieldIndex.colFldException) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldException", IIf(pRowData.colFldException Is Nothing, DBNull.Value, pRowData.colFldException)))
                End If

            zCmd.Transaction=pTransaction
            If zMode = "INSERTnoKey" Then
                Dim zLastId As Long = 0
                zLastId = razor.UtilSQLServer.ExecuteNonQueryRowId(zCmd)

                pRowData.colFldID = zLastId
            Else
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)
            End If

            pRowData.SetIsDirty(False)
            pRowData.RaiseSavedEvent(pSavedEventUserState)

		End If

        End Sub

        Public Shared Function LoadByPrimaryKey(pcolFldID As Integer) As rowTblAdminQueue
            Return LoadByPrimaryKey(pcolFldID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldID As Integer, pLoadEventUserState As Object) As rowTblAdminQueue
            Return LoadByPrimaryKey(pcolFldID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblAdminQueue
            Return LoadByPrimaryKey(pcolFldID, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblAdminQueue
            Dim zReturn As New rowTblAdminQueue
            Dim zSQL As String = "SELECT * FROM [adm].[tblAdminQueue] WHERE [fldID] = @colFldID"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldID", pcolFldID))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblAdminQueue) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK__AdminQue__36326BC366236B9F(pcolFldID As Integer) As List(Of rowTblAdminQueue)
            Return LoadByIDX_PK__AdminQue__36326BC366236B9F(pcolFldID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__AdminQue__36326BC366236B9F(pcolFldID As Integer, pLoadEventUserState As Object) As List(Of rowTblAdminQueue)
            Return LoadByIDX_PK__AdminQue__36326BC366236B9F(pcolFldID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__AdminQue__36326BC366236B9F(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblAdminQueue)
            Return LoadByIDX_PK__AdminQue__36326BC366236B9F(pcolFldID, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__AdminQue__36326BC366236B9F(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblAdminQueue)
            Dim zReturn As New List(Of rowTblAdminQueue)
            Dim zSQL As String = "SELECT * FROM [adm].[tblAdminQueue] WHERE [fldID] = @colFldID"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldID", pcolFldID))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblAdminQueue)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblAdminQueue)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblAdminQueue)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblAdminQueue)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblAdminQueue)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblAdminQueue)
            Dim zReturn As New List(Of rowTblAdminQueue)
            Dim zSQL As String = "SELECT * FROM [adm].[tblAdminQueue]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblAdminQueue)

			Try
	            Dim zReturn As New List(Of rowTblAdminQueue)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblAdminQueue

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblAdminQueue		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblAdminQueue)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldID")) Then pObject.colFldID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldTo")) Then pObject.colFldTo = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldTo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldViewIDs")) Then pObject.colFldViewIDs = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldViewIDs")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldDBAFilter")) Then pObject.colFldDBAFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldDBAFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldCreateBy")) Then pObject.colFldCreateBy = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldCreateBy")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldCreateDate")) Then pObject.colFldCreateDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "fldCreateDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldIsProcessed")) Then pObject.colFldIsProcessed = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldIsProcessed")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldStatus")) Then pObject.colFldStatus = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldStatus")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldProcessedDate")) Then pObject.colFldProcessedDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "fldProcessedDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldException")) Then pObject.colFldException = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldException")
			pObject.SetIsDirty(False)
			Return pObject
		End	 Function

    #Region "Reflection Based Load Functions"

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldID As Integer) As T
            Return LoadByPrimaryKey(Of T)(pcolFldID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldID As Integer, pLoadEventUserState As Object) As T
            Return LoadByPrimaryKey(Of T)(pcolFldID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction) As T
            Return LoadByPrimaryKey(Of T)(pcolFldID, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As T

            Dim zReturn As Object = Activator.CreateInstance(Of T)()
            If Not TypeOf zReturn Is rowTblAdminQueue Then Throw New ArgumentException("Generic type is not type of rowTblAdminQueue.","T")

            Dim zSQL As String = "SELECT * FROM [adm].[tblAdminQueue] WHERE [fldID] = @colFldID"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldID", pcolFldID))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of T) = ReadData(Of T)(zCmd, pLoadEventUserState)
            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

        End Function

        Public Shared Function LoadByIDX_PK__AdminQue__36326BC366236B9F(Of T)(pcolFldID As Integer) As List(Of T)
            Return LoadByIDX_PK__AdminQue__36326BC366236B9F(Of T)(pcolFldID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__AdminQue__36326BC366236B9F(Of T)(pcolFldID As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK__AdminQue__36326BC366236B9F(Of T)(pcolFldID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__AdminQue__36326BC366236B9F(Of T)(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK__AdminQue__36326BC366236B9F(Of T)(pcolFldID, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK__AdminQue__36326BC366236B9F(Of T)(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [adm].[tblAdminQueue] WHERE [fldID] = @colFldID"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldID", pcolFldID))

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
            Dim zSQL As String = "SELECT * FROM [adm].[tblAdminQueue]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class

    Partial Public Class rowTblAdminQueue
        Implements IrowTblAdminQueue

        Public Event Loaded(pUserState As Object) Implements IrowTblAdminQueue.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblAdminQueue.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblAdminQueue.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblAdminQueue.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblAdminQueue.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblAdminQueue.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldID() As Nullable(Of Integer) Implements IrowTblAdminQueue.colFldID
            Get
                Return m_colFldID
            End Get
            Set
                If Not Same(m_colFldID, Value) Then
                    m_colFldID = Value
                    m_IsDirty(FieldIndex.colFldID) = True
                End If
            End Set
        End Property
        Private m_colFldID As Nullable(Of Integer)

        Public Property colFldTo() As String Implements IrowTblAdminQueue.colFldTo
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

        Public Property colFldViewIDs() As String Implements IrowTblAdminQueue.colFldViewIDs
            Get
                Return m_colFldViewIDs
            End Get
            Set
                If Not Same(m_colFldViewIDs, Value) Then
                    m_colFldViewIDs = Value
                    m_IsDirty(FieldIndex.colFldViewIDs) = True
                End If
            End Set
        End Property
        Private m_colFldViewIDs As String

        Public Property colFldDBAFilter() As String Implements IrowTblAdminQueue.colFldDBAFilter
            Get
                Return m_colFldDBAFilter
            End Get
            Set
                If Not Same(m_colFldDBAFilter, Value) Then
                    m_colFldDBAFilter = Value
                    m_IsDirty(FieldIndex.colFldDBAFilter) = True
                End If
            End Set
        End Property
        Private m_colFldDBAFilter As String

        Public Property colFldCreateBy() As String Implements IrowTblAdminQueue.colFldCreateBy
            Get
                Return m_colFldCreateBy
            End Get
            Set
                If Not Same(m_colFldCreateBy, Value) Then
                    m_colFldCreateBy = Value
                    m_IsDirty(FieldIndex.colFldCreateBy) = True
                End If
            End Set
        End Property
        Private m_colFldCreateBy As String

        Public Property colFldCreateDate() As Nullable(Of DateTime) Implements IrowTblAdminQueue.colFldCreateDate
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

        Public Property colFldIsProcessed() As Nullable(Of Boolean) Implements IrowTblAdminQueue.colFldIsProcessed
            Get
                Return m_colFldIsProcessed
            End Get
            Set
                If Not Same(m_colFldIsProcessed, Value) Then
                    m_colFldIsProcessed = Value
                    m_IsDirty(FieldIndex.colFldIsProcessed) = True
                End If
            End Set
        End Property
        Private m_colFldIsProcessed As Nullable(Of Boolean)

        Public Property colFldStatus() As String Implements IrowTblAdminQueue.colFldStatus
            Get
                Return m_colFldStatus
            End Get
            Set
                If Not Same(m_colFldStatus, Value) Then
                    m_colFldStatus = Value
                    m_IsDirty(FieldIndex.colFldStatus) = True
                End If
            End Set
        End Property
        Private m_colFldStatus As String

        Public Property colFldProcessedDate() As Nullable(Of DateTime) Implements IrowTblAdminQueue.colFldProcessedDate
            Get
                Return m_colFldProcessedDate
            End Get
            Set
                If Not Same(m_colFldProcessedDate, Value) Then
                    m_colFldProcessedDate = Value
                    m_IsDirty(FieldIndex.colFldProcessedDate) = True
                End If
            End Set
        End Property
        Private m_colFldProcessedDate As Nullable(Of DateTime)

        Public Property colFldException() As String Implements IrowTblAdminQueue.colFldException
            Get
                Return m_colFldException
            End Get
            Set
                If Not Same(m_colFldException, Value) Then
                    m_colFldException = Value
                    m_IsDirty(FieldIndex.colFldException) = True
                End If
            End Set
        End Property
        Private m_colFldException As String


        Public Function IsDirty(pIndex As rowTblAdminQueue.FieldIndex) As Boolean Implements IrowTblAdminQueue.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblAdminQueue.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblAdminQueue.SetIsDirty
            m_IsDirty(FieldIndex.colFldID) = pDirty
            m_IsDirty(FieldIndex.colFldTo) = pDirty
            m_IsDirty(FieldIndex.colFldViewIDs) = pDirty
            m_IsDirty(FieldIndex.colFldDBAFilter) = pDirty
            m_IsDirty(FieldIndex.colFldCreateBy) = pDirty
            m_IsDirty(FieldIndex.colFldCreateDate) = pDirty
            m_IsDirty(FieldIndex.colFldIsProcessed) = pDirty
            m_IsDirty(FieldIndex.colFldStatus) = pDirty
            m_IsDirty(FieldIndex.colFldProcessedDate) = pDirty
            m_IsDirty(FieldIndex.colFldException) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblAdminQueue) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblAdminQueue
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldID  = 1
            colFldTo 
            colFldViewIDs 
            colFldDBAFilter 
            colFldCreateBy 
            colFldCreateDate 
            colFldIsProcessed 
            colFldStatus 
            colFldProcessedDate 
            colFldException 
        End Enum

        Private m_IsDirty(10) As Boolean

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

    Public Interface IrowTblAdminQueue
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldID() As Nullable(Of Integer)
        Property colFldTo() As String
        Property colFldViewIDs() As String
        Property colFldDBAFilter() As String
        Property colFldCreateBy() As String
        Property colFldCreateDate() As Nullable(Of DateTime)
        Property colFldIsProcessed() As Nullable(Of Boolean)
        Property colFldStatus() As String
        Property colFldProcessedDate() As Nullable(Of DateTime)
        Property colFldException() As String
        Function IsDirty(pIndex As rowTblAdminQueue.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

