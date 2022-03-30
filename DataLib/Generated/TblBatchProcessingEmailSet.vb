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
    Partial Public Class TblBatchProcessingEmailSet

        Public Shared Sub Delete(ByRef pRowData As IrowTblBatchProcessingEmailSet)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblBatchProcessingEmailSet, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblBatchProcessingEmailSet, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblBatchProcessingEmailSet, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldEmailId) And razor.UtilSQLServer.IsKeySet(pRowData.colFldSetId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[tblBatchProcessingEmailSet] " & _
                        "WHERE [fldEmailId] = @colFldEmailId AND [fldSetId] = @colFldSetId"

                Dim zCmd As New SQLCommand
                zCmd.CommandText = zSQL
                zCmd.Parameters.Add(New SQLParameter("@colFldEmailId", pRowData.colFldEmailId))
                zCmd.Parameters.Add(New SQLParameter("@colFldSetId", pRowData.colFldSetId))

                zCmd.Transaction=pTransaction
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)

                pRowData.RaiseDeletedEvent(pDeleteEventUserState)

            End If

        End Sub

        Public Shared Sub Delete(pcolFldEmailId As Integer, pcolFldSetId As Integer)
            Delete(pcolFldEmailId, pcolFldSetId, Nothing, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolFldEmailId As Integer, pcolFldSetId As Integer, pDeleteEventUserState As Object)
            Delete(pcolFldEmailId, pcolFldSetId, Nothing, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Delete(pcolFldEmailId As Integer, pcolFldSetId As Integer, ByRef pTransaction As SqlClient.SqlTransaction)
        Delete(pcolFldEmailId, pcolFldSetId, pTransaction, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolFldEmailId As Integer, pcolFldSetId As Integer, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
        Dim zObj As rowTblBatchProcessingEmailSet = LoadByPrimaryKey(pcolFldEmailId, pcolFldSetId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblBatchProcessingEmailSet)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblBatchProcessingEmailSet, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblBatchProcessingEmailSet, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldEmailId) And razor.UtilSQLServer.IsKeySet(pRowData.colFldSetId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[tblBatchProcessingEmailSet] WHERE [fldEmailId] = @colFldEmailId AND [fldSetId] = @colFldSetId"

                Dim zCmdDoesExist As New SQLCommand

                zCmdDoesExist.CommandText = zSQL

                zCmdDoesExist.Parameters.Add(new SQLParameter("@colFldEmailId", pRowData.colFldEmailId))
                zCmdDoesExist.Parameters.Add(new SQLParameter("@colFldSetId", pRowData.colFldSetId))

                'if zExistInDB > 0  then  PK exists in the DB
                zCmdDoesExist.Transaction = pTransaction
                zExistInDB = razor.UtilSQLServer.ExecuteScalar(zCmdDoesExist)
            End If

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldEmailId) And razor.UtilSQLServer.IsKeySet(pRowData.colFldSetId) And zExistInDB > 0 Then
                zMode = "UPDATE"
            End If
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldEmailId) And razor.UtilSQLServer.IsKeySet(pRowData.colFldSetId) And zExistInDB = 0 Then
                zMode = "INSERTwithKey"
            End If
            If Not razor.UtilSQLServer.IsKeySet(pRowData.colFldEmailId) Or Not razor.UtilSQLServer.IsKeySet(pRowData.colFldSetId) Then
                zMode = "INSERTnoKey"
            End If

            Select Case zMode
                Case "UPDATE"
                    If pRowData.IsDirty Then
                        Dim zUpdate As String = ""
                        Dim zSet As String = ""
                        Dim zWhere As String = ""
                        zUpdate = "UPDATE [dbo].[tblBatchProcessingEmailSet] SET " 
                        zWhere = " WHERE [fldEmailId] = @colFldEmailId AND [fldSetId] = @colFldSetId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[tblBatchProcessingEmailSet] ([fldEmailId], [fldSetId])" & _
                            " VALUES (@colFldEmailId, @colFldSetId); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[tblBatchProcessingEmailSet] ()" & _
                            " VALUES (); SELECT SCOPE_IDENTITY()"
                Case Else
            End Select

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

			'IF UPDATE, SET PK PARAMETER
            If zMode = "UPDATE" Then
                zCmd.Parameters.Add(New SQLParameter("@colFldEmailId", pRowData.colFldEmailId))
                zCmd.Parameters.Add(New SQLParameter("@colFldSetId", pRowData.colFldSetId))
            End If

			'IF INSERTING, KEY HAS VALUE AND KEY IS NOT IDENTITY, SET PK PARAMETER
			If zMode = "INSERTwithKey" Then
                zCmd.Parameters.Add(New SQLParameter("@colFldEmailId", pRowData.colFldEmailId))
                zCmd.Parameters.Add(New SQLParameter("@colFldSetId", pRowData.colFldSetId))
            End If


            zCmd.Transaction=pTransaction
            If zMode = "INSERTnoKey" Then
                Dim zLastId As Long = 0
                zLastId = razor.UtilSQLServer.ExecuteNonQueryRowId(zCmd)

                pRowData.colFldEmailId = zLastId
                pRowData.colFldSetId = zLastId
            Else
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)
            End If

            pRowData.SetIsDirty(False)
            pRowData.RaiseSavedEvent(pSavedEventUserState)

		End If

        End Sub

        Public Shared Function LoadByPrimaryKey(pcolFldEmailId As Integer, pcolFldSetId As Integer) As rowTblBatchProcessingEmailSet
            Return LoadByPrimaryKey(pcolFldEmailId, pcolFldSetId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldEmailId As Integer, pcolFldSetId As Integer, pLoadEventUserState As Object) As rowTblBatchProcessingEmailSet
            Return LoadByPrimaryKey(pcolFldEmailId, pcolFldSetId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldEmailId As Integer, pcolFldSetId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblBatchProcessingEmailSet
            Return LoadByPrimaryKey(pcolFldEmailId, pcolFldSetId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldEmailId As Integer, pcolFldSetId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblBatchProcessingEmailSet
            Dim zReturn As New rowTblBatchProcessingEmailSet
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingEmailSet] WHERE [fldEmailId] = @colFldEmailId AND [fldSetId] = @colFldSetId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldEmailId", pcolFldEmailId))
            zCmd.Parameters.Add(New SQLParameter("@colFldSetId", pcolFldSetId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblBatchProcessingEmailSet) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_IX_fldEmailId(pcolFldEmailId As Integer) As List(Of rowTblBatchProcessingEmailSet)
            Return LoadByIDX_IX_fldEmailId(pcolFldEmailId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_fldEmailId(pcolFldEmailId As Integer, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingEmailSet)
            Return LoadByIDX_IX_fldEmailId(pcolFldEmailId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_fldEmailId(pcolFldEmailId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblBatchProcessingEmailSet)
            Return LoadByIDX_IX_fldEmailId(pcolFldEmailId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_fldEmailId(pcolFldEmailId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingEmailSet)
            Dim zReturn As New List(Of rowTblBatchProcessingEmailSet)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingEmailSet] WHERE [fldEmailId] = @colFldEmailId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldEmailId", pcolFldEmailId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function
        Public Shared Function LoadByIDX_IX_fldSetId(pcolFldSetId As Integer) As List(Of rowTblBatchProcessingEmailSet)
            Return LoadByIDX_IX_fldSetId(pcolFldSetId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_fldSetId(pcolFldSetId As Integer, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingEmailSet)
            Return LoadByIDX_IX_fldSetId(pcolFldSetId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_fldSetId(pcolFldSetId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblBatchProcessingEmailSet)
            Return LoadByIDX_IX_fldSetId(pcolFldSetId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_fldSetId(pcolFldSetId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingEmailSet)
            Dim zReturn As New List(Of rowTblBatchProcessingEmailSet)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingEmailSet] WHERE [fldSetId] = @colFldSetId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldSetId", pcolFldSetId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function
        Public Shared Function LoadByIDX_PK_tblBatchProcessingEmailSet(pcolFldEmailId As Integer, pcolFldSetId As Integer) As List(Of rowTblBatchProcessingEmailSet)
            Return LoadByIDX_PK_tblBatchProcessingEmailSet(pcolFldEmailId, pcolFldSetId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblBatchProcessingEmailSet(pcolFldEmailId As Integer, pcolFldSetId As Integer, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingEmailSet)
            Return LoadByIDX_PK_tblBatchProcessingEmailSet(pcolFldEmailId, pcolFldSetId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_tblBatchProcessingEmailSet(pcolFldEmailId As Integer, pcolFldSetId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblBatchProcessingEmailSet)
            Return LoadByIDX_PK_tblBatchProcessingEmailSet(pcolFldEmailId, pcolFldSetId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblBatchProcessingEmailSet(pcolFldEmailId As Integer, pcolFldSetId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingEmailSet)
            Dim zReturn As New List(Of rowTblBatchProcessingEmailSet)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingEmailSet] WHERE [fldEmailId] = @colFldEmailId AND [fldSetId] = @colFldSetId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldEmailId", pcolFldEmailId))
            zCmd.Parameters.Add(New SQLParameter("@colFldSetId", pcolFldSetId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblBatchProcessingEmailSet)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblBatchProcessingEmailSet)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblBatchProcessingEmailSet)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblBatchProcessingEmailSet)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingEmailSet)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingEmailSet)
            Dim zReturn As New List(Of rowTblBatchProcessingEmailSet)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingEmailSet]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingEmailSet)

			Try
	            Dim zReturn As New List(Of rowTblBatchProcessingEmailSet)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblBatchProcessingEmailSet

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblBatchProcessingEmailSet		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblBatchProcessingEmailSet)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldEmailId")) Then pObject.colFldEmailId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldEmailId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSetId")) Then pObject.colFldSetId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldSetId")
			pObject.SetIsDirty(False)
			Return pObject
		End	 Function

    #Region "Reflection Based Load Functions"

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldEmailId As Integer, pcolFldSetId As Integer) As T
            Return LoadByPrimaryKey(Of T)(pcolFldEmailId, pcolFldSetId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldEmailId As Integer, pcolFldSetId As Integer, pLoadEventUserState As Object) As T
            Return LoadByPrimaryKey(Of T)(pcolFldEmailId, pcolFldSetId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldEmailId As Integer, pcolFldSetId As Integer, pTransaction As SqlClient.SqlTransaction) As T
            Return LoadByPrimaryKey(Of T)(pcolFldEmailId, pcolFldSetId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldEmailId As Integer, pcolFldSetId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As T

            Dim zReturn As Object = Activator.CreateInstance(Of T)()
            If Not TypeOf zReturn Is rowTblBatchProcessingEmailSet Then Throw New ArgumentException("Generic type is not type of rowTblBatchProcessingEmailSet.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingEmailSet] WHERE [fldEmailId] = @colFldEmailId AND [fldSetId] = @colFldSetId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldEmailId", pcolFldEmailId))
            zCmd.Parameters.Add(New SQLParameter("@colFldSetId", pcolFldSetId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of T) = ReadData(Of T)(zCmd, pLoadEventUserState)
            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

        End Function

        Public Shared Function LoadByIDX_IX_fldEmailId(Of T)(pcolFldEmailId As Integer) As List(Of T)
            Return LoadByIDX_IX_fldEmailId(Of T)(pcolFldEmailId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_fldEmailId(Of T)(pcolFldEmailId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_IX_fldEmailId(Of T)(pcolFldEmailId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_fldEmailId(Of T)(pcolFldEmailId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_IX_fldEmailId(Of T)(pcolFldEmailId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_IX_fldEmailId(Of T)(pcolFldEmailId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingEmailSet] WHERE [fldEmailId] = @colFldEmailId"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldEmailId", pcolFldEmailId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_IX_fldSetId(Of T)(pcolFldSetId As Integer) As List(Of T)
            Return LoadByIDX_IX_fldSetId(Of T)(pcolFldSetId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_fldSetId(Of T)(pcolFldSetId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_IX_fldSetId(Of T)(pcolFldSetId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_fldSetId(Of T)(pcolFldSetId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_IX_fldSetId(Of T)(pcolFldSetId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_IX_fldSetId(Of T)(pcolFldSetId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingEmailSet] WHERE [fldSetId] = @colFldSetId"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldSetId", pcolFldSetId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_PK_tblBatchProcessingEmailSet(Of T)(pcolFldEmailId As Integer, pcolFldSetId As Integer) As List(Of T)
            Return LoadByIDX_PK_tblBatchProcessingEmailSet(Of T)(pcolFldEmailId, pcolFldSetId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblBatchProcessingEmailSet(Of T)(pcolFldEmailId As Integer, pcolFldSetId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK_tblBatchProcessingEmailSet(Of T)(pcolFldEmailId, pcolFldSetId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_tblBatchProcessingEmailSet(Of T)(pcolFldEmailId As Integer, pcolFldSetId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK_tblBatchProcessingEmailSet(Of T)(pcolFldEmailId, pcolFldSetId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK_tblBatchProcessingEmailSet(Of T)(pcolFldEmailId As Integer, pcolFldSetId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingEmailSet] WHERE [fldEmailId] = @colFldEmailId AND [fldSetId] = @colFldSetId"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldEmailId", pcolFldEmailId))
            zCmd.Parameters.Add(New SQLParameter("@colFldSetId", pcolFldSetId))

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
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingEmailSet]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblBatchProcessingEmailSet
        Implements IrowTblBatchProcessingEmailSet

        Public Event Loaded(pUserState As Object) Implements IrowTblBatchProcessingEmailSet.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblBatchProcessingEmailSet.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblBatchProcessingEmailSet.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblBatchProcessingEmailSet.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblBatchProcessingEmailSet.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblBatchProcessingEmailSet.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldEmailId() As Nullable(Of Integer) Implements IrowTblBatchProcessingEmailSet.colFldEmailId
            Get
                Return m_colFldEmailId
            End Get
            Set
                If Not Same(m_colFldEmailId, Value) Then
                    m_colFldEmailId = Value
                    m_IsDirty(FieldIndex.colFldEmailId) = True
                End If
            End Set
        End Property
        Private m_colFldEmailId As Nullable(Of Integer)

        Public Property colFldSetId() As Nullable(Of Integer) Implements IrowTblBatchProcessingEmailSet.colFldSetId
            Get
                Return m_colFldSetId
            End Get
            Set
                If Not Same(m_colFldSetId, Value) Then
                    m_colFldSetId = Value
                    m_IsDirty(FieldIndex.colFldSetId) = True
                End If
            End Set
        End Property
        Private m_colFldSetId As Nullable(Of Integer)


        Public Function IsDirty(pIndex As rowTblBatchProcessingEmailSet.FieldIndex) As Boolean Implements IrowTblBatchProcessingEmailSet.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblBatchProcessingEmailSet.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblBatchProcessingEmailSet.SetIsDirty
            m_IsDirty(FieldIndex.colFldEmailId) = pDirty
            m_IsDirty(FieldIndex.colFldSetId) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblBatchProcessingEmailSet) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblBatchProcessingEmailSet
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldEmailId  = 1
            colFldSetId 
        End Enum

        Private m_IsDirty(2) As Boolean

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

    Public Interface IrowTblBatchProcessingEmailSet
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldEmailId() As Nullable(Of Integer)
        Property colFldSetId() As Nullable(Of Integer)
        Function IsDirty(pIndex As rowTblBatchProcessingEmailSet.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

