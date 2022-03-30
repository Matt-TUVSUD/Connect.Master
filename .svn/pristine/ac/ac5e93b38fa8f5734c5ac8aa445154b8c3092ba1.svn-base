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
    Partial Public Class TblWhatIfOutputParm

        Public Shared Sub Delete(ByRef pRowData As IrowTblWhatIfOutputParm)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblWhatIfOutputParm, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblWhatIfOutputParm, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblWhatIfOutputParm, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldGUID) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[TblWhatIfOutputParm] " & _
                        "WHERE [fldGUID] = @colFldGUID"

                Dim zCmd As New SQLCommand
                zCmd.CommandText = zSQL
                zCmd.Parameters.Add(New SQLParameter("@colFldGUID", pRowData.colFldGUID))

                zCmd.Transaction=pTransaction
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)

                pRowData.RaiseDeletedEvent(pDeleteEventUserState)

            End If

        End Sub

        Public Shared Sub Delete(pcolFldGUID As String)
            Delete(pcolFldGUID, Nothing, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolFldGUID As String, pDeleteEventUserState As Object)
            Delete(pcolFldGUID, Nothing, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Delete(pcolFldGUID As String, ByRef pTransaction As SqlClient.SqlTransaction)
        Delete(pcolFldGUID, pTransaction, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolFldGUID As String, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
        Dim zObj As rowTblWhatIfOutputParm = LoadByPrimaryKey(pcolFldGUID, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblWhatIfOutputParm)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblWhatIfOutputParm, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblWhatIfOutputParm, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldGUID) Then

                zSQL = "SELECT COUNT(*) from [dbo].[TblWhatIfOutputParm] WHERE [fldGUID] = @colFldGUID"

                Dim zCmdDoesExist As New SQLCommand

                zCmdDoesExist.CommandText = zSQL

                zCmdDoesExist.Parameters.Add(new SQLParameter("@colFldGUID", pRowData.colFldGUID))

                'if zExistInDB > 0  then  PK exists in the DB
                zCmdDoesExist.Transaction = pTransaction
                zExistInDB = razor.UtilSQLServer.ExecuteScalar(zCmdDoesExist)
            End If

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldGUID) And zExistInDB > 0 Then
                zMode = "UPDATE"
            End If
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldGUID) And zExistInDB = 0 Then
                zMode = "INSERTwithKey"
            End If
            If Not razor.UtilSQLServer.IsKeySet(pRowData.colFldGUID) Then
                zMode = "INSERTnoKey"
            End If

            Select Case zMode
                Case "UPDATE"
                    If pRowData.IsDirty Then
                        Dim zUpdate As String = ""
                        Dim zSet As String = ""
                        Dim zWhere As String = ""
                        zUpdate = "UPDATE [dbo].[TblWhatIfOutputParm] SET " 
                        If pRowData.IsDirty(rowTblWhatIfOutputParm.FieldIndex.colFldSID) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldSID] = @colFldSID "
                        End If
                        If pRowData.IsDirty(rowTblWhatIfOutputParm.FieldIndex.colFldGSafeID) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldGSafeID] = @colFldGSafeID "
                        End If
                        If pRowData.IsDirty(rowTblWhatIfOutputParm.FieldIndex.colFldOutputID) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldOutputID] = @colFldOutputID "
                        End If
                        If pRowData.IsDirty(rowTblWhatIfOutputParm.FieldIndex.colFldFileNo) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldFileNo] = @colFldFileNo "
                        End If
                        If pRowData.IsDirty(rowTblWhatIfOutputParm.FieldIndex.colFldSortJSON) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldSortJSON] = @colFldSortJSON "
                        End If
                        If pRowData.IsDirty(rowTblWhatIfOutputParm.FieldIndex.colFldFilterJSON) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldFilterJSON] = @colFldFilterJSON "
                        End If
                        If pRowData.IsDirty(rowTblWhatIfOutputParm.FieldIndex.colFldEstBudget) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldEstBudget] = @colFldEstBudget "
                        End If
                        If pRowData.IsDirty(rowTblWhatIfOutputParm.FieldIndex.colFldEstCostToComplete) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldEstCostToComplete] = @colFldEstCostToComplete "
                        End If
                        If pRowData.IsDirty(rowTblWhatIfOutputParm.FieldIndex.colFldRemainBudget) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldRemainBudget] = @colFldRemainBudget "
                        End If
                        zWhere = " WHERE [fldGUID] = @colFldGUID"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[TblWhatIfOutputParm] ([fldGUID], [fldSID], [fldGSafeID], [fldOutputID], [fldFileNo], [fldSortJSON], [fldFilterJSON], [fldEstBudget], [fldEstCostToComplete], [fldRemainBudget])" & _
                            " VALUES (@colFldGUID, @colFldSID, @colFldGSafeID, @colFldOutputID, @colFldFileNo, @colFldSortJSON, @colFldFilterJSON, @colFldEstBudget, @colFldEstCostToComplete, @colFldRemainBudget); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[TblWhatIfOutputParm] ([fldSID], [fldGSafeID], [fldOutputID], [fldFileNo], [fldSortJSON], [fldFilterJSON], [fldEstBudget], [fldEstCostToComplete], [fldRemainBudget])" & _
                            " VALUES (@colFldSID, @colFldGSafeID, @colFldOutputID, @colFldFileNo, @colFldSortJSON, @colFldFilterJSON, @colFldEstBudget, @colFldEstCostToComplete, @colFldRemainBudget); SELECT SCOPE_IDENTITY()"
                Case Else
            End Select

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

			'IF UPDATE, SET PK PARAMETER
            If zMode = "UPDATE" Then
                zCmd.Parameters.Add(New SQLParameter("@colFldGUID", pRowData.colFldGUID))
            End If

			'IF INSERTING, KEY HAS VALUE AND KEY IS NOT IDENTITY, SET PK PARAMETER
			If zMode = "INSERTwithKey" Then
                zCmd.Parameters.Add(New SQLParameter("@colFldGUID", pRowData.colFldGUID))
            End If

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatIfOutputParm.FieldIndex.colFldSID) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldSID", IIf(pRowData.colFldSID Is Nothing, DBNull.Value, pRowData.colFldSID)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatIfOutputParm.FieldIndex.colFldGSafeID) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldGSafeID", IIf(pRowData.colFldGSafeID Is Nothing, DBNull.Value, pRowData.colFldGSafeID)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatIfOutputParm.FieldIndex.colFldOutputID) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldOutputID", IIf(pRowData.colFldOutputID Is Nothing, DBNull.Value, pRowData.colFldOutputID)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatIfOutputParm.FieldIndex.colFldFileNo) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldFileNo", IIf(pRowData.colFldFileNo Is Nothing, DBNull.Value, pRowData.colFldFileNo)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatIfOutputParm.FieldIndex.colFldSortJSON) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldSortJSON", IIf(pRowData.colFldSortJSON Is Nothing, DBNull.Value, pRowData.colFldSortJSON)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatIfOutputParm.FieldIndex.colFldFilterJSON) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldFilterJSON", IIf(pRowData.colFldFilterJSON Is Nothing, DBNull.Value, pRowData.colFldFilterJSON)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatIfOutputParm.FieldIndex.colFldEstBudget) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldEstBudget", IIf(pRowData.colFldEstBudget Is Nothing, DBNull.Value, pRowData.colFldEstBudget)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatIfOutputParm.FieldIndex.colFldEstCostToComplete) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldEstCostToComplete", IIf(pRowData.colFldEstCostToComplete Is Nothing, DBNull.Value, pRowData.colFldEstCostToComplete)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatIfOutputParm.FieldIndex.colFldRemainBudget) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldRemainBudget", IIf(pRowData.colFldRemainBudget Is Nothing, DBNull.Value, pRowData.colFldRemainBudget)))
                End If

            zCmd.Transaction=pTransaction
            If zMode = "INSERTnoKey" Then
                Dim zLastId As Long = 0
                zLastId = razor.UtilSQLServer.ExecuteNonQueryRowId(zCmd)

                pRowData.colFldGUID = zLastId
            Else
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)
            End If

            pRowData.SetIsDirty(False)
            pRowData.RaiseSavedEvent(pSavedEventUserState)

		End If

        End Sub

        Public Shared Function LoadByPrimaryKey(pcolFldGUID As String) As rowTblWhatIfOutputParm
            Return LoadByPrimaryKey(pcolFldGUID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldGUID As String, pLoadEventUserState As Object) As rowTblWhatIfOutputParm
            Return LoadByPrimaryKey(pcolFldGUID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldGUID As String, pTransaction As SqlClient.SqlTransaction) As rowTblWhatIfOutputParm
            Return LoadByPrimaryKey(pcolFldGUID, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldGUID As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblWhatIfOutputParm
            Dim zReturn As New rowTblWhatIfOutputParm
            Dim zSQL As String = "SELECT * FROM [dbo].[TblWhatIfOutputParm] WHERE [fldGUID] = @colFldGUID"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldGUID", pcolFldGUID))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblWhatIfOutputParm) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK_TblWhatIfOutputParm(pcolFldGUID As String) As List(Of rowTblWhatIfOutputParm)
            Return LoadByIDX_PK_TblWhatIfOutputParm(pcolFldGUID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_TblWhatIfOutputParm(pcolFldGUID As String, pLoadEventUserState As Object) As List(Of rowTblWhatIfOutputParm)
            Return LoadByIDX_PK_TblWhatIfOutputParm(pcolFldGUID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_TblWhatIfOutputParm(pcolFldGUID As String, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblWhatIfOutputParm)
            Return LoadByIDX_PK_TblWhatIfOutputParm(pcolFldGUID, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_TblWhatIfOutputParm(pcolFldGUID As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblWhatIfOutputParm)
            Dim zReturn As New List(Of rowTblWhatIfOutputParm)
            Dim zSQL As String = "SELECT * FROM [dbo].[TblWhatIfOutputParm] WHERE [fldGUID] = @colFldGUID"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldGUID", pcolFldGUID))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblWhatIfOutputParm)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblWhatIfOutputParm)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblWhatIfOutputParm)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblWhatIfOutputParm)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblWhatIfOutputParm)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblWhatIfOutputParm)
            Dim zReturn As New List(Of rowTblWhatIfOutputParm)
            Dim zSQL As String = "SELECT * FROM [dbo].[TblWhatIfOutputParm]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblWhatIfOutputParm)

			Try
	            Dim zReturn As New List(Of rowTblWhatIfOutputParm)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblWhatIfOutputParm

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblWhatIfOutputParm		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblWhatIfOutputParm)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldGUID")) Then pObject.colFldGUID = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldGUID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSID")) Then pObject.colFldSID = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldSID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldGSafeID")) Then pObject.colFldGSafeID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldGSafeID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldOutputID")) Then pObject.colFldOutputID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldOutputID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFileNo")) Then pObject.colFldFileNo = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldFileNo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSortJSON")) Then pObject.colFldSortJSON = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldSortJSON")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFilterJSON")) Then pObject.colFldFilterJSON = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldFilterJSON")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldEstBudget")) Then pObject.colFldEstBudget = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldEstBudget")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldEstCostToComplete")) Then pObject.colFldEstCostToComplete = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldEstCostToComplete")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldRemainBudget")) Then pObject.colFldRemainBudget = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldRemainBudget")
			pObject.SetIsDirty(False)
			Return pObject
		End	 Function

    #Region "Reflection Based Load Functions"

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldGUID As String) As T
            Return LoadByPrimaryKey(Of T)(pcolFldGUID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldGUID As String, pLoadEventUserState As Object) As T
            Return LoadByPrimaryKey(Of T)(pcolFldGUID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldGUID As String, pTransaction As SqlClient.SqlTransaction) As T
            Return LoadByPrimaryKey(Of T)(pcolFldGUID, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldGUID As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As T

            Dim zReturn As Object = Activator.CreateInstance(Of T)()
            If Not TypeOf zReturn Is rowTblWhatIfOutputParm Then Throw New ArgumentException("Generic type is not type of rowTblWhatIfOutputParm.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[TblWhatIfOutputParm] WHERE [fldGUID] = @colFldGUID"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldGUID", pcolFldGUID))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of T) = ReadData(Of T)(zCmd, pLoadEventUserState)
            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

        End Function

        Public Shared Function LoadByIDX_PK_TblWhatIfOutputParm(Of T)(pcolFldGUID As String) As List(Of T)
            Return LoadByIDX_PK_TblWhatIfOutputParm(Of T)(pcolFldGUID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_TblWhatIfOutputParm(Of T)(pcolFldGUID As String, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK_TblWhatIfOutputParm(Of T)(pcolFldGUID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_TblWhatIfOutputParm(Of T)(pcolFldGUID As String, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK_TblWhatIfOutputParm(Of T)(pcolFldGUID, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK_TblWhatIfOutputParm(Of T)(pcolFldGUID As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[TblWhatIfOutputParm] WHERE [fldGUID] = @colFldGUID"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldGUID", pcolFldGUID))

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
            Dim zSQL As String = "SELECT * FROM [dbo].[TblWhatIfOutputParm]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblWhatIfOutputParm
        Implements IrowTblWhatIfOutputParm

        Public Event Loaded(pUserState As Object) Implements IrowTblWhatIfOutputParm.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblWhatIfOutputParm.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblWhatIfOutputParm.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblWhatIfOutputParm.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblWhatIfOutputParm.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblWhatIfOutputParm.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldGUID() As String Implements IrowTblWhatIfOutputParm.colFldGUID
            Get
                Return m_colFldGUID
            End Get
            Set
                If Not Same(m_colFldGUID, Value) Then
                    m_colFldGUID = Value
                    m_IsDirty(FieldIndex.colFldGUID) = True
                End If
            End Set
        End Property
        Private m_colFldGUID As String

        Public Property colFldSID() As String Implements IrowTblWhatIfOutputParm.colFldSID
            Get
                Return m_colFldSID
            End Get
            Set
                If Not Same(m_colFldSID, Value) Then
                    m_colFldSID = Value
                    m_IsDirty(FieldIndex.colFldSID) = True
                End If
            End Set
        End Property
        Private m_colFldSID As String

        Public Property colFldGSafeID() As Nullable(Of Integer) Implements IrowTblWhatIfOutputParm.colFldGSafeID
            Get
                Return m_colFldGSafeID
            End Get
            Set
                If Not Same(m_colFldGSafeID, Value) Then
                    m_colFldGSafeID = Value
                    m_IsDirty(FieldIndex.colFldGSafeID) = True
                End If
            End Set
        End Property
        Private m_colFldGSafeID As Nullable(Of Integer)

        Public Property colFldOutputID() As Nullable(Of Integer) Implements IrowTblWhatIfOutputParm.colFldOutputID
            Get
                Return m_colFldOutputID
            End Get
            Set
                If Not Same(m_colFldOutputID, Value) Then
                    m_colFldOutputID = Value
                    m_IsDirty(FieldIndex.colFldOutputID) = True
                End If
            End Set
        End Property
        Private m_colFldOutputID As Nullable(Of Integer)

        Public Property colFldFileNo() As String Implements IrowTblWhatIfOutputParm.colFldFileNo
            Get
                Return m_colFldFileNo
            End Get
            Set
                If Not Same(m_colFldFileNo, Value) Then
                    m_colFldFileNo = Value
                    m_IsDirty(FieldIndex.colFldFileNo) = True
                End If
            End Set
        End Property
        Private m_colFldFileNo As String

        Public Property colFldSortJSON() As String Implements IrowTblWhatIfOutputParm.colFldSortJSON
            Get
                Return m_colFldSortJSON
            End Get
            Set
                If Not Same(m_colFldSortJSON, Value) Then
                    m_colFldSortJSON = Value
                    m_IsDirty(FieldIndex.colFldSortJSON) = True
                End If
            End Set
        End Property
        Private m_colFldSortJSON As String

        Public Property colFldFilterJSON() As String Implements IrowTblWhatIfOutputParm.colFldFilterJSON
            Get
                Return m_colFldFilterJSON
            End Get
            Set
                If Not Same(m_colFldFilterJSON, Value) Then
                    m_colFldFilterJSON = Value
                    m_IsDirty(FieldIndex.colFldFilterJSON) = True
                End If
            End Set
        End Property
        Private m_colFldFilterJSON As String

        Public Property colFldEstBudget() As String Implements IrowTblWhatIfOutputParm.colFldEstBudget
            Get
                Return m_colFldEstBudget
            End Get
            Set
                If Not Same(m_colFldEstBudget, Value) Then
                    m_colFldEstBudget = Value
                    m_IsDirty(FieldIndex.colFldEstBudget) = True
                End If
            End Set
        End Property
        Private m_colFldEstBudget As String

        Public Property colFldEstCostToComplete() As String Implements IrowTblWhatIfOutputParm.colFldEstCostToComplete
            Get
                Return m_colFldEstCostToComplete
            End Get
            Set
                If Not Same(m_colFldEstCostToComplete, Value) Then
                    m_colFldEstCostToComplete = Value
                    m_IsDirty(FieldIndex.colFldEstCostToComplete) = True
                End If
            End Set
        End Property
        Private m_colFldEstCostToComplete As String

        Public Property colFldRemainBudget() As String Implements IrowTblWhatIfOutputParm.colFldRemainBudget
            Get
                Return m_colFldRemainBudget
            End Get
            Set
                If Not Same(m_colFldRemainBudget, Value) Then
                    m_colFldRemainBudget = Value
                    m_IsDirty(FieldIndex.colFldRemainBudget) = True
                End If
            End Set
        End Property
        Private m_colFldRemainBudget As String


        Public Function IsDirty(pIndex As rowTblWhatIfOutputParm.FieldIndex) As Boolean Implements IrowTblWhatIfOutputParm.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblWhatIfOutputParm.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblWhatIfOutputParm.SetIsDirty
            m_IsDirty(FieldIndex.colFldGUID) = pDirty
            m_IsDirty(FieldIndex.colFldSID) = pDirty
            m_IsDirty(FieldIndex.colFldGSafeID) = pDirty
            m_IsDirty(FieldIndex.colFldOutputID) = pDirty
            m_IsDirty(FieldIndex.colFldFileNo) = pDirty
            m_IsDirty(FieldIndex.colFldSortJSON) = pDirty
            m_IsDirty(FieldIndex.colFldFilterJSON) = pDirty
            m_IsDirty(FieldIndex.colFldEstBudget) = pDirty
            m_IsDirty(FieldIndex.colFldEstCostToComplete) = pDirty
            m_IsDirty(FieldIndex.colFldRemainBudget) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblWhatIfOutputParm) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblWhatIfOutputParm
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldGUID  = 1
            colFldSID 
            colFldGSafeID 
            colFldOutputID 
            colFldFileNo 
            colFldSortJSON 
            colFldFilterJSON 
            colFldEstBudget 
            colFldEstCostToComplete 
            colFldRemainBudget 
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

    Public Interface IrowTblWhatIfOutputParm
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldGUID() As String
        Property colFldSID() As String
        Property colFldGSafeID() As Nullable(Of Integer)
        Property colFldOutputID() As Nullable(Of Integer)
        Property colFldFileNo() As String
        Property colFldSortJSON() As String
        Property colFldFilterJSON() As String
        Property colFldEstBudget() As String
        Property colFldEstCostToComplete() As String
        Property colFldRemainBudget() As String
        Function IsDirty(pIndex As rowTblWhatIfOutputParm.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

