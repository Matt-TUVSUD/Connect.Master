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
    Partial Public Class TblMetaSourceParameter

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaSourceParameter)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaSourceParameter, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaSourceParameter, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaSourceParameter, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldSourceid) And razor.UtilSQLServer.IsKeySet(pRowData.colFldParameterId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[tblMetaSourceParameter] " & _
                        "WHERE [fldSourceid] = @colFldSourceid AND [fldParameterId] = @colFldParameterId"

                Dim zCmd As New SQLCommand
                zCmd.CommandText = zSQL
                zCmd.Parameters.Add(New SQLParameter("@colFldSourceid", pRowData.colFldSourceid))
                zCmd.Parameters.Add(New SQLParameter("@colFldParameterId", pRowData.colFldParameterId))

                zCmd.Transaction=pTransaction
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)

                pRowData.RaiseDeletedEvent(pDeleteEventUserState)

            End If

        End Sub

        Public Shared Sub Delete(pcolFldSourceid As Integer, pcolFldParameterId As Integer)
            Delete(pcolFldSourceid, pcolFldParameterId, Nothing, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolFldSourceid As Integer, pcolFldParameterId As Integer, pDeleteEventUserState As Object)
            Delete(pcolFldSourceid, pcolFldParameterId, Nothing, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Delete(pcolFldSourceid As Integer, pcolFldParameterId As Integer, ByRef pTransaction As SqlClient.SqlTransaction)
        Delete(pcolFldSourceid, pcolFldParameterId, pTransaction, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolFldSourceid As Integer, pcolFldParameterId As Integer, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
        Dim zObj As rowTblMetaSourceParameter = LoadByPrimaryKey(pcolFldSourceid, pcolFldParameterId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblMetaSourceParameter)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaSourceParameter, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaSourceParameter, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldSourceid) And razor.UtilSQLServer.IsKeySet(pRowData.colFldParameterId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[tblMetaSourceParameter] WHERE [fldSourceid] = @colFldSourceid AND [fldParameterId] = @colFldParameterId"

                Dim zCmdDoesExist As New SQLCommand

                zCmdDoesExist.CommandText = zSQL

                zCmdDoesExist.Parameters.Add(new SQLParameter("@colFldSourceid", pRowData.colFldSourceid))
                zCmdDoesExist.Parameters.Add(new SQLParameter("@colFldParameterId", pRowData.colFldParameterId))

                'if zExistInDB > 0  then  PK exists in the DB
                zCmdDoesExist.Transaction = pTransaction
                zExistInDB = razor.UtilSQLServer.ExecuteScalar(zCmdDoesExist)
            End If

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldSourceid) And razor.UtilSQLServer.IsKeySet(pRowData.colFldParameterId) And zExistInDB > 0 Then
                zMode = "UPDATE"
            End If
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldSourceid) And razor.UtilSQLServer.IsKeySet(pRowData.colFldParameterId) And zExistInDB = 0 Then
                zMode = "INSERTwithKey"
            End If
            If Not razor.UtilSQLServer.IsKeySet(pRowData.colFldSourceid) Or Not razor.UtilSQLServer.IsKeySet(pRowData.colFldParameterId) Then
                zMode = "INSERTnoKey"
            End If

            Select Case zMode
                Case "UPDATE"
                    If pRowData.IsDirty Then
                        Dim zUpdate As String = ""
                        Dim zSet As String = ""
                        Dim zWhere As String = ""
                        zUpdate = "UPDATE [dbo].[tblMetaSourceParameter] SET " 
                        zWhere = " WHERE [fldSourceid] = @colFldSourceid AND [fldParameterId] = @colFldParameterId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaSourceParameter] ([fldSourceid], [fldParameterId])" & _
                            " VALUES (@colFldSourceid, @colFldParameterId); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaSourceParameter] ()" & _
                            " VALUES (); SELECT SCOPE_IDENTITY()"
                Case Else
            End Select

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

			'IF UPDATE, SET PK PARAMETER
            If zMode = "UPDATE" Then
                zCmd.Parameters.Add(New SQLParameter("@colFldSourceid", pRowData.colFldSourceid))
                zCmd.Parameters.Add(New SQLParameter("@colFldParameterId", pRowData.colFldParameterId))
            End If

			'IF INSERTING, KEY HAS VALUE AND KEY IS NOT IDENTITY, SET PK PARAMETER
			If zMode = "INSERTwithKey" Then
                zCmd.Parameters.Add(New SQLParameter("@colFldSourceid", pRowData.colFldSourceid))
                zCmd.Parameters.Add(New SQLParameter("@colFldParameterId", pRowData.colFldParameterId))
            End If


            zCmd.Transaction=pTransaction
            If zMode = "INSERTnoKey" Then
                Dim zLastId As Long = 0
                zLastId = razor.UtilSQLServer.ExecuteNonQueryRowId(zCmd)

                pRowData.colFldSourceid = zLastId
                pRowData.colFldParameterId = zLastId
            Else
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)
            End If

            pRowData.SetIsDirty(False)
            pRowData.RaiseSavedEvent(pSavedEventUserState)

		End If

        End Sub

        Public Shared Function LoadByPrimaryKey(pcolFldSourceid As Integer, pcolFldParameterId As Integer) As rowTblMetaSourceParameter
            Return LoadByPrimaryKey(pcolFldSourceid, pcolFldParameterId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldSourceid As Integer, pcolFldParameterId As Integer, pLoadEventUserState As Object) As rowTblMetaSourceParameter
            Return LoadByPrimaryKey(pcolFldSourceid, pcolFldParameterId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldSourceid As Integer, pcolFldParameterId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblMetaSourceParameter
            Return LoadByPrimaryKey(pcolFldSourceid, pcolFldParameterId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldSourceid As Integer, pcolFldParameterId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblMetaSourceParameter
            Dim zReturn As New rowTblMetaSourceParameter
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaSourceParameter] WHERE [fldSourceid] = @colFldSourceid AND [fldParameterId] = @colFldParameterId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldSourceid", pcolFldSourceid))
            zCmd.Parameters.Add(New SQLParameter("@colFldParameterId", pcolFldParameterId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblMetaSourceParameter) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_IX_fldSourceId(pcolFldSourceid As Integer) As List(Of rowTblMetaSourceParameter)
            Return LoadByIDX_IX_fldSourceId(pcolFldSourceid, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_fldSourceId(pcolFldSourceid As Integer, pLoadEventUserState As Object) As List(Of rowTblMetaSourceParameter)
            Return LoadByIDX_IX_fldSourceId(pcolFldSourceid, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_fldSourceId(pcolFldSourceid As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaSourceParameter)
            Return LoadByIDX_IX_fldSourceId(pcolFldSourceid, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_fldSourceId(pcolFldSourceid As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaSourceParameter)
            Dim zReturn As New List(Of rowTblMetaSourceParameter)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaSourceParameter] WHERE [fldSourceid] = @colFldSourceid"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldSourceid", pcolFldSourceid))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function
        Public Shared Function LoadByIDX_IX_tblMetaSourceParameter(pcolFldParameterId As Integer, pcolFldSourceid As Integer) As List(Of rowTblMetaSourceParameter)
            Return LoadByIDX_IX_tblMetaSourceParameter(pcolFldParameterId, pcolFldSourceid, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_tblMetaSourceParameter(pcolFldParameterId As Integer, pcolFldSourceid As Integer, pLoadEventUserState As Object) As List(Of rowTblMetaSourceParameter)
            Return LoadByIDX_IX_tblMetaSourceParameter(pcolFldParameterId, pcolFldSourceid, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_tblMetaSourceParameter(pcolFldParameterId As Integer, pcolFldSourceid As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaSourceParameter)
            Return LoadByIDX_IX_tblMetaSourceParameter(pcolFldParameterId, pcolFldSourceid, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_tblMetaSourceParameter(pcolFldParameterId As Integer, pcolFldSourceid As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaSourceParameter)
            Dim zReturn As New List(Of rowTblMetaSourceParameter)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaSourceParameter] WHERE [fldParameterId] = @colFldParameterId AND [fldSourceid] = @colFldSourceid"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldParameterId", pcolFldParameterId))
            zCmd.Parameters.Add(New SQLParameter("@colFldSourceid", pcolFldSourceid))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function
        Public Shared Function LoadByIDX_PK_tblMetaSourceParameter(pcolFldSourceid As Integer, pcolFldParameterId As Integer) As List(Of rowTblMetaSourceParameter)
            Return LoadByIDX_PK_tblMetaSourceParameter(pcolFldSourceid, pcolFldParameterId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaSourceParameter(pcolFldSourceid As Integer, pcolFldParameterId As Integer, pLoadEventUserState As Object) As List(Of rowTblMetaSourceParameter)
            Return LoadByIDX_PK_tblMetaSourceParameter(pcolFldSourceid, pcolFldParameterId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaSourceParameter(pcolFldSourceid As Integer, pcolFldParameterId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaSourceParameter)
            Return LoadByIDX_PK_tblMetaSourceParameter(pcolFldSourceid, pcolFldParameterId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaSourceParameter(pcolFldSourceid As Integer, pcolFldParameterId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaSourceParameter)
            Dim zReturn As New List(Of rowTblMetaSourceParameter)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaSourceParameter] WHERE [fldSourceid] = @colFldSourceid AND [fldParameterId] = @colFldParameterId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldSourceid", pcolFldSourceid))
            zCmd.Parameters.Add(New SQLParameter("@colFldParameterId", pcolFldParameterId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblMetaSourceParameter)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblMetaSourceParameter)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblMetaSourceParameter)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaSourceParameter)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaSourceParameter)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaSourceParameter)
            Dim zReturn As New List(Of rowTblMetaSourceParameter)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaSourceParameter]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblMetaSourceParameter)

			Try
	            Dim zReturn As New List(Of rowTblMetaSourceParameter)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblMetaSourceParameter

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblMetaSourceParameter		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblMetaSourceParameter)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSourceid")) Then pObject.colFldSourceid = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldSourceid")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldParameterId")) Then pObject.colFldParameterId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldParameterId")
			pObject.SetIsDirty(False)
			Return pObject
		End	 Function

    #Region "Reflection Based Load Functions"

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldSourceid As Integer, pcolFldParameterId As Integer) As T
            Return LoadByPrimaryKey(Of T)(pcolFldSourceid, pcolFldParameterId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldSourceid As Integer, pcolFldParameterId As Integer, pLoadEventUserState As Object) As T
            Return LoadByPrimaryKey(Of T)(pcolFldSourceid, pcolFldParameterId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldSourceid As Integer, pcolFldParameterId As Integer, pTransaction As SqlClient.SqlTransaction) As T
            Return LoadByPrimaryKey(Of T)(pcolFldSourceid, pcolFldParameterId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldSourceid As Integer, pcolFldParameterId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As T

            Dim zReturn As Object = Activator.CreateInstance(Of T)()
            If Not TypeOf zReturn Is rowTblMetaSourceParameter Then Throw New ArgumentException("Generic type is not type of rowTblMetaSourceParameter.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaSourceParameter] WHERE [fldSourceid] = @colFldSourceid AND [fldParameterId] = @colFldParameterId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldSourceid", pcolFldSourceid))
            zCmd.Parameters.Add(New SQLParameter("@colFldParameterId", pcolFldParameterId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of T) = ReadData(Of T)(zCmd, pLoadEventUserState)
            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

        End Function

        Public Shared Function LoadByIDX_IX_fldSourceId(Of T)(pcolFldSourceid As Integer) As List(Of T)
            Return LoadByIDX_IX_fldSourceId(Of T)(pcolFldSourceid, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_fldSourceId(Of T)(pcolFldSourceid As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_IX_fldSourceId(Of T)(pcolFldSourceid, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_fldSourceId(Of T)(pcolFldSourceid As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_IX_fldSourceId(Of T)(pcolFldSourceid, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_IX_fldSourceId(Of T)(pcolFldSourceid As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaSourceParameter] WHERE [fldSourceid] = @colFldSourceid"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldSourceid", pcolFldSourceid))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_IX_tblMetaSourceParameter(Of T)(pcolFldParameterId As Integer, pcolFldSourceid As Integer) As List(Of T)
            Return LoadByIDX_IX_tblMetaSourceParameter(Of T)(pcolFldParameterId, pcolFldSourceid, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_tblMetaSourceParameter(Of T)(pcolFldParameterId As Integer, pcolFldSourceid As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_IX_tblMetaSourceParameter(Of T)(pcolFldParameterId, pcolFldSourceid, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_tblMetaSourceParameter(Of T)(pcolFldParameterId As Integer, pcolFldSourceid As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_IX_tblMetaSourceParameter(Of T)(pcolFldParameterId, pcolFldSourceid, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_IX_tblMetaSourceParameter(Of T)(pcolFldParameterId As Integer, pcolFldSourceid As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaSourceParameter] WHERE [fldParameterId] = @colFldParameterId AND [fldSourceid] = @colFldSourceid"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldParameterId", pcolFldParameterId))
            zCmd.Parameters.Add(New SQLParameter("@colFldSourceid", pcolFldSourceid))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaSourceParameter(Of T)(pcolFldSourceid As Integer, pcolFldParameterId As Integer) As List(Of T)
            Return LoadByIDX_PK_tblMetaSourceParameter(Of T)(pcolFldSourceid, pcolFldParameterId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaSourceParameter(Of T)(pcolFldSourceid As Integer, pcolFldParameterId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK_tblMetaSourceParameter(Of T)(pcolFldSourceid, pcolFldParameterId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaSourceParameter(Of T)(pcolFldSourceid As Integer, pcolFldParameterId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK_tblMetaSourceParameter(Of T)(pcolFldSourceid, pcolFldParameterId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK_tblMetaSourceParameter(Of T)(pcolFldSourceid As Integer, pcolFldParameterId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaSourceParameter] WHERE [fldSourceid] = @colFldSourceid AND [fldParameterId] = @colFldParameterId"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldSourceid", pcolFldSourceid))
            zCmd.Parameters.Add(New SQLParameter("@colFldParameterId", pcolFldParameterId))

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
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaSourceParameter]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblMetaSourceParameter
        Implements IrowTblMetaSourceParameter

        Public Event Loaded(pUserState As Object) Implements IrowTblMetaSourceParameter.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblMetaSourceParameter.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblMetaSourceParameter.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblMetaSourceParameter.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblMetaSourceParameter.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblMetaSourceParameter.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldSourceid() As Nullable(Of Integer) Implements IrowTblMetaSourceParameter.colFldSourceid
            Get
                Return m_colFldSourceid
            End Get
            Set
                If Not Same(m_colFldSourceid, Value) Then
                    m_colFldSourceid = Value
                    m_IsDirty(FieldIndex.colFldSourceid) = True
                End If
            End Set
        End Property
        Private m_colFldSourceid As Nullable(Of Integer)

        Public Property colFldParameterId() As Nullable(Of Integer) Implements IrowTblMetaSourceParameter.colFldParameterId
            Get
                Return m_colFldParameterId
            End Get
            Set
                If Not Same(m_colFldParameterId, Value) Then
                    m_colFldParameterId = Value
                    m_IsDirty(FieldIndex.colFldParameterId) = True
                End If
            End Set
        End Property
        Private m_colFldParameterId As Nullable(Of Integer)


        Public Function IsDirty(pIndex As rowTblMetaSourceParameter.FieldIndex) As Boolean Implements IrowTblMetaSourceParameter.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblMetaSourceParameter.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblMetaSourceParameter.SetIsDirty
            m_IsDirty(FieldIndex.colFldSourceid) = pDirty
            m_IsDirty(FieldIndex.colFldParameterId) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblMetaSourceParameter) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblMetaSourceParameter
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldSourceid  = 1
            colFldParameterId 
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

    Public Interface IrowTblMetaSourceParameter
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldSourceid() As Nullable(Of Integer)
        Property colFldParameterId() As Nullable(Of Integer)
        Function IsDirty(pIndex As rowTblMetaSourceParameter.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

