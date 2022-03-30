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
    Partial Public Class TblMetaExchangeRate

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaExchangeRate)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaExchangeRate, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaExchangeRate, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaExchangeRate, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldExchangeRateGroupID) And razor.UtilSQLServer.IsKeySet(pRowData.colFldCurrencyIdFrom) And razor.UtilSQLServer.IsKeySet(pRowData.colFldCurrencyIdTo) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[tblMetaExchangeRate] " & _
                        "WHERE [fldExchangeRateGroupID] = @colFldExchangeRateGroupID AND [fldCurrencyIdFrom] = @colFldCurrencyIdFrom AND [fldCurrencyIdTo] = @colFldCurrencyIdTo"

                Dim zCmd As New SQLCommand
                zCmd.CommandText = zSQL
                zCmd.Parameters.Add(New SQLParameter("@colFldExchangeRateGroupID", pRowData.colFldExchangeRateGroupID))
                zCmd.Parameters.Add(New SQLParameter("@colFldCurrencyIdFrom", pRowData.colFldCurrencyIdFrom))
                zCmd.Parameters.Add(New SQLParameter("@colFldCurrencyIdTo", pRowData.colFldCurrencyIdTo))

                zCmd.Transaction=pTransaction
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)

                pRowData.RaiseDeletedEvent(pDeleteEventUserState)

            End If

        End Sub

        Public Shared Sub Delete(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyIdFrom As Integer, pcolFldCurrencyIdTo As Integer)
            Delete(pcolFldExchangeRateGroupID, pcolFldCurrencyIdFrom, pcolFldCurrencyIdTo, Nothing, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyIdFrom As Integer, pcolFldCurrencyIdTo As Integer, pDeleteEventUserState As Object)
            Delete(pcolFldExchangeRateGroupID, pcolFldCurrencyIdFrom, pcolFldCurrencyIdTo, Nothing, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Delete(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyIdFrom As Integer, pcolFldCurrencyIdTo As Integer, ByRef pTransaction As SqlClient.SqlTransaction)
        Delete(pcolFldExchangeRateGroupID, pcolFldCurrencyIdFrom, pcolFldCurrencyIdTo, pTransaction, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyIdFrom As Integer, pcolFldCurrencyIdTo As Integer, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
        Dim zObj As rowTblMetaExchangeRate = LoadByPrimaryKey(pcolFldExchangeRateGroupID, pcolFldCurrencyIdFrom, pcolFldCurrencyIdTo, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblMetaExchangeRate)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaExchangeRate, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaExchangeRate, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldExchangeRateGroupID) And razor.UtilSQLServer.IsKeySet(pRowData.colFldCurrencyIdFrom) And razor.UtilSQLServer.IsKeySet(pRowData.colFldCurrencyIdTo) Then

                zSQL = "SELECT COUNT(*) from [dbo].[tblMetaExchangeRate] WHERE [fldExchangeRateGroupID] = @colFldExchangeRateGroupID AND [fldCurrencyIdFrom] = @colFldCurrencyIdFrom AND [fldCurrencyIdTo] = @colFldCurrencyIdTo"

                Dim zCmdDoesExist As New SQLCommand

                zCmdDoesExist.CommandText = zSQL

                zCmdDoesExist.Parameters.Add(new SQLParameter("@colFldExchangeRateGroupID", pRowData.colFldExchangeRateGroupID))
                zCmdDoesExist.Parameters.Add(new SQLParameter("@colFldCurrencyIdFrom", pRowData.colFldCurrencyIdFrom))
                zCmdDoesExist.Parameters.Add(new SQLParameter("@colFldCurrencyIdTo", pRowData.colFldCurrencyIdTo))

                'if zExistInDB > 0  then  PK exists in the DB
                zCmdDoesExist.Transaction = pTransaction
                zExistInDB = razor.UtilSQLServer.ExecuteScalar(zCmdDoesExist)
            End If

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldExchangeRateGroupID) And razor.UtilSQLServer.IsKeySet(pRowData.colFldCurrencyIdFrom) And razor.UtilSQLServer.IsKeySet(pRowData.colFldCurrencyIdTo) And zExistInDB > 0 Then
                zMode = "UPDATE"
            End If
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldExchangeRateGroupID) And razor.UtilSQLServer.IsKeySet(pRowData.colFldCurrencyIdFrom) And razor.UtilSQLServer.IsKeySet(pRowData.colFldCurrencyIdTo) And zExistInDB = 0 Then
                zMode = "INSERTwithKey"
            End If
            If Not razor.UtilSQLServer.IsKeySet(pRowData.colFldExchangeRateGroupID) Or Not razor.UtilSQLServer.IsKeySet(pRowData.colFldCurrencyIdFrom) Or Not razor.UtilSQLServer.IsKeySet(pRowData.colFldCurrencyIdTo) Then
                zMode = "INSERTnoKey"
            End If

            Select Case zMode
                Case "UPDATE"
                    If pRowData.IsDirty Then
                        Dim zUpdate As String = ""
                        Dim zSet As String = ""
                        Dim zWhere As String = ""
                        zUpdate = "UPDATE [dbo].[tblMetaExchangeRate] SET " 
                        If pRowData.IsDirty(rowTblMetaExchangeRate.FieldIndex.colFldExchangeRate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldExchangeRate] = @colFldExchangeRate "
                        End If
                        zWhere = " WHERE [fldExchangeRateGroupID] = @colFldExchangeRateGroupID AND [fldCurrencyIdFrom] = @colFldCurrencyIdFrom AND [fldCurrencyIdTo] = @colFldCurrencyIdTo"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaExchangeRate] ([fldExchangeRateGroupID], [fldCurrencyIdFrom], [fldCurrencyIdTo], [fldExchangeRate])" & _
                            " VALUES (@colFldExchangeRateGroupID, @colFldCurrencyIdFrom, @colFldCurrencyIdTo, @colFldExchangeRate); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaExchangeRate] ([fldExchangeRate])" & _
                            " VALUES (@colFldExchangeRate); SELECT SCOPE_IDENTITY()"
                Case Else
            End Select

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

			'IF UPDATE, SET PK PARAMETER
            If zMode = "UPDATE" Then
                zCmd.Parameters.Add(New SQLParameter("@colFldExchangeRateGroupID", pRowData.colFldExchangeRateGroupID))
                zCmd.Parameters.Add(New SQLParameter("@colFldCurrencyIdFrom", pRowData.colFldCurrencyIdFrom))
                zCmd.Parameters.Add(New SQLParameter("@colFldCurrencyIdTo", pRowData.colFldCurrencyIdTo))
            End If

			'IF INSERTING, KEY HAS VALUE AND KEY IS NOT IDENTITY, SET PK PARAMETER
			If zMode = "INSERTwithKey" Then
                zCmd.Parameters.Add(New SQLParameter("@colFldExchangeRateGroupID", pRowData.colFldExchangeRateGroupID))
                zCmd.Parameters.Add(New SQLParameter("@colFldCurrencyIdFrom", pRowData.colFldCurrencyIdFrom))
                zCmd.Parameters.Add(New SQLParameter("@colFldCurrencyIdTo", pRowData.colFldCurrencyIdTo))
            End If

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaExchangeRate.FieldIndex.colFldExchangeRate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldExchangeRate", IIf(pRowData.colFldExchangeRate Is Nothing, DBNull.Value, pRowData.colFldExchangeRate)))
                End If

            zCmd.Transaction=pTransaction
            If zMode = "INSERTnoKey" Then
                Dim zLastId As Long = 0
                zLastId = razor.UtilSQLServer.ExecuteNonQueryRowId(zCmd)

                pRowData.colFldExchangeRateGroupID = zLastId
                pRowData.colFldCurrencyIdFrom = zLastId
                pRowData.colFldCurrencyIdTo = zLastId
            Else
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)
            End If

            pRowData.SetIsDirty(False)
            pRowData.RaiseSavedEvent(pSavedEventUserState)

		End If

        End Sub

        Public Shared Function LoadByPrimaryKey(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyIdFrom As Integer, pcolFldCurrencyIdTo As Integer) As rowTblMetaExchangeRate
            Return LoadByPrimaryKey(pcolFldExchangeRateGroupID, pcolFldCurrencyIdFrom, pcolFldCurrencyIdTo, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyIdFrom As Integer, pcolFldCurrencyIdTo As Integer, pLoadEventUserState As Object) As rowTblMetaExchangeRate
            Return LoadByPrimaryKey(pcolFldExchangeRateGroupID, pcolFldCurrencyIdFrom, pcolFldCurrencyIdTo, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyIdFrom As Integer, pcolFldCurrencyIdTo As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblMetaExchangeRate
            Return LoadByPrimaryKey(pcolFldExchangeRateGroupID, pcolFldCurrencyIdFrom, pcolFldCurrencyIdTo, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyIdFrom As Integer, pcolFldCurrencyIdTo As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblMetaExchangeRate
            Dim zReturn As New rowTblMetaExchangeRate
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaExchangeRate] WHERE [fldExchangeRateGroupID] = @colFldExchangeRateGroupID AND [fldCurrencyIdFrom] = @colFldCurrencyIdFrom AND [fldCurrencyIdTo] = @colFldCurrencyIdTo"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldExchangeRateGroupID", pcolFldExchangeRateGroupID))
            zCmd.Parameters.Add(New SQLParameter("@colFldCurrencyIdFrom", pcolFldCurrencyIdFrom))
            zCmd.Parameters.Add(New SQLParameter("@colFldCurrencyIdTo", pcolFldCurrencyIdTo))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblMetaExchangeRate) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK_tblMetaExchangeRate(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyIdFrom As Integer, pcolFldCurrencyIdTo As Integer) As List(Of rowTblMetaExchangeRate)
            Return LoadByIDX_PK_tblMetaExchangeRate(pcolFldExchangeRateGroupID, pcolFldCurrencyIdFrom, pcolFldCurrencyIdTo, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaExchangeRate(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyIdFrom As Integer, pcolFldCurrencyIdTo As Integer, pLoadEventUserState As Object) As List(Of rowTblMetaExchangeRate)
            Return LoadByIDX_PK_tblMetaExchangeRate(pcolFldExchangeRateGroupID, pcolFldCurrencyIdFrom, pcolFldCurrencyIdTo, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaExchangeRate(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyIdFrom As Integer, pcolFldCurrencyIdTo As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaExchangeRate)
            Return LoadByIDX_PK_tblMetaExchangeRate(pcolFldExchangeRateGroupID, pcolFldCurrencyIdFrom, pcolFldCurrencyIdTo, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaExchangeRate(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyIdFrom As Integer, pcolFldCurrencyIdTo As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaExchangeRate)
            Dim zReturn As New List(Of rowTblMetaExchangeRate)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaExchangeRate] WHERE [fldExchangeRateGroupID] = @colFldExchangeRateGroupID AND [fldCurrencyIdFrom] = @colFldCurrencyIdFrom AND [fldCurrencyIdTo] = @colFldCurrencyIdTo"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldExchangeRateGroupID", pcolFldExchangeRateGroupID))
            zCmd.Parameters.Add(New SQLParameter("@colFldCurrencyIdFrom", pcolFldCurrencyIdFrom))
            zCmd.Parameters.Add(New SQLParameter("@colFldCurrencyIdTo", pcolFldCurrencyIdTo))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblMetaExchangeRate)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblMetaExchangeRate)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblMetaExchangeRate)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaExchangeRate)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaExchangeRate)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaExchangeRate)
            Dim zReturn As New List(Of rowTblMetaExchangeRate)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaExchangeRate]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblMetaExchangeRate)

			Try
	            Dim zReturn As New List(Of rowTblMetaExchangeRate)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblMetaExchangeRate

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblMetaExchangeRate		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblMetaExchangeRate)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldExchangeRateGroupID")) Then pObject.colFldExchangeRateGroupID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldExchangeRateGroupID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldCurrencyIdFrom")) Then pObject.colFldCurrencyIdFrom = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldCurrencyIdFrom")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldCurrencyIdTo")) Then pObject.colFldCurrencyIdTo = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldCurrencyIdTo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldExchangeRate")) Then pObject.colFldExchangeRate = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "fldExchangeRate")
			pObject.SetIsDirty(False)
			Return pObject
		End	 Function

    #Region "Reflection Based Load Functions"

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyIdFrom As Integer, pcolFldCurrencyIdTo As Integer) As T
            Return LoadByPrimaryKey(Of T)(pcolFldExchangeRateGroupID, pcolFldCurrencyIdFrom, pcolFldCurrencyIdTo, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyIdFrom As Integer, pcolFldCurrencyIdTo As Integer, pLoadEventUserState As Object) As T
            Return LoadByPrimaryKey(Of T)(pcolFldExchangeRateGroupID, pcolFldCurrencyIdFrom, pcolFldCurrencyIdTo, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyIdFrom As Integer, pcolFldCurrencyIdTo As Integer, pTransaction As SqlClient.SqlTransaction) As T
            Return LoadByPrimaryKey(Of T)(pcolFldExchangeRateGroupID, pcolFldCurrencyIdFrom, pcolFldCurrencyIdTo, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyIdFrom As Integer, pcolFldCurrencyIdTo As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As T

            Dim zReturn As Object = Activator.CreateInstance(Of T)()
            If Not TypeOf zReturn Is rowTblMetaExchangeRate Then Throw New ArgumentException("Generic type is not type of rowTblMetaExchangeRate.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaExchangeRate] WHERE [fldExchangeRateGroupID] = @colFldExchangeRateGroupID AND [fldCurrencyIdFrom] = @colFldCurrencyIdFrom AND [fldCurrencyIdTo] = @colFldCurrencyIdTo"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldExchangeRateGroupID", pcolFldExchangeRateGroupID))
            zCmd.Parameters.Add(New SQLParameter("@colFldCurrencyIdFrom", pcolFldCurrencyIdFrom))
            zCmd.Parameters.Add(New SQLParameter("@colFldCurrencyIdTo", pcolFldCurrencyIdTo))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of T) = ReadData(Of T)(zCmd, pLoadEventUserState)
            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

        End Function

        Public Shared Function LoadByIDX_PK_tblMetaExchangeRate(Of T)(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyIdFrom As Integer, pcolFldCurrencyIdTo As Integer) As List(Of T)
            Return LoadByIDX_PK_tblMetaExchangeRate(Of T)(pcolFldExchangeRateGroupID, pcolFldCurrencyIdFrom, pcolFldCurrencyIdTo, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaExchangeRate(Of T)(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyIdFrom As Integer, pcolFldCurrencyIdTo As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK_tblMetaExchangeRate(Of T)(pcolFldExchangeRateGroupID, pcolFldCurrencyIdFrom, pcolFldCurrencyIdTo, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaExchangeRate(Of T)(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyIdFrom As Integer, pcolFldCurrencyIdTo As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK_tblMetaExchangeRate(Of T)(pcolFldExchangeRateGroupID, pcolFldCurrencyIdFrom, pcolFldCurrencyIdTo, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK_tblMetaExchangeRate(Of T)(pcolFldExchangeRateGroupID As Integer, pcolFldCurrencyIdFrom As Integer, pcolFldCurrencyIdTo As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaExchangeRate] WHERE [fldExchangeRateGroupID] = @colFldExchangeRateGroupID AND [fldCurrencyIdFrom] = @colFldCurrencyIdFrom AND [fldCurrencyIdTo] = @colFldCurrencyIdTo"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldExchangeRateGroupID", pcolFldExchangeRateGroupID))
            zCmd.Parameters.Add(New SQLParameter("@colFldCurrencyIdFrom", pcolFldCurrencyIdFrom))
            zCmd.Parameters.Add(New SQLParameter("@colFldCurrencyIdTo", pcolFldCurrencyIdTo))

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
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaExchangeRate]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblMetaExchangeRate
        Implements IrowTblMetaExchangeRate

        Public Event Loaded(pUserState As Object) Implements IrowTblMetaExchangeRate.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblMetaExchangeRate.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblMetaExchangeRate.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblMetaExchangeRate.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblMetaExchangeRate.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblMetaExchangeRate.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldExchangeRateGroupID() As Nullable(Of Integer) Implements IrowTblMetaExchangeRate.colFldExchangeRateGroupID
            Get
                Return m_colFldExchangeRateGroupID
            End Get
            Set
                If Not Same(m_colFldExchangeRateGroupID, Value) Then
                    m_colFldExchangeRateGroupID = Value
                    m_IsDirty(FieldIndex.colFldExchangeRateGroupID) = True
                End If
            End Set
        End Property
        Private m_colFldExchangeRateGroupID As Nullable(Of Integer)

        Public Property colFldCurrencyIdFrom() As Nullable(Of Integer) Implements IrowTblMetaExchangeRate.colFldCurrencyIdFrom
            Get
                Return m_colFldCurrencyIdFrom
            End Get
            Set
                If Not Same(m_colFldCurrencyIdFrom, Value) Then
                    m_colFldCurrencyIdFrom = Value
                    m_IsDirty(FieldIndex.colFldCurrencyIdFrom) = True
                End If
            End Set
        End Property
        Private m_colFldCurrencyIdFrom As Nullable(Of Integer)

        Public Property colFldCurrencyIdTo() As Nullable(Of Integer) Implements IrowTblMetaExchangeRate.colFldCurrencyIdTo
            Get
                Return m_colFldCurrencyIdTo
            End Get
            Set
                If Not Same(m_colFldCurrencyIdTo, Value) Then
                    m_colFldCurrencyIdTo = Value
                    m_IsDirty(FieldIndex.colFldCurrencyIdTo) = True
                End If
            End Set
        End Property
        Private m_colFldCurrencyIdTo As Nullable(Of Integer)

        Public Property colFldExchangeRate() As Nullable(Of Double) Implements IrowTblMetaExchangeRate.colFldExchangeRate
            Get
                Return m_colFldExchangeRate
            End Get
            Set
                If Not Same(m_colFldExchangeRate, Value) Then
                    m_colFldExchangeRate = Value
                    m_IsDirty(FieldIndex.colFldExchangeRate) = True
                End If
            End Set
        End Property
        Private m_colFldExchangeRate As Nullable(Of Double)


        Public Function IsDirty(pIndex As rowTblMetaExchangeRate.FieldIndex) As Boolean Implements IrowTblMetaExchangeRate.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblMetaExchangeRate.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblMetaExchangeRate.SetIsDirty
            m_IsDirty(FieldIndex.colFldExchangeRateGroupID) = pDirty
            m_IsDirty(FieldIndex.colFldCurrencyIdFrom) = pDirty
            m_IsDirty(FieldIndex.colFldCurrencyIdTo) = pDirty
            m_IsDirty(FieldIndex.colFldExchangeRate) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblMetaExchangeRate) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblMetaExchangeRate
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldExchangeRateGroupID  = 1
            colFldCurrencyIdFrom 
            colFldCurrencyIdTo 
            colFldExchangeRate 
        End Enum

        Private m_IsDirty(4) As Boolean

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

    Public Interface IrowTblMetaExchangeRate
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldExchangeRateGroupID() As Nullable(Of Integer)
        Property colFldCurrencyIdFrom() As Nullable(Of Integer)
        Property colFldCurrencyIdTo() As Nullable(Of Integer)
        Property colFldExchangeRate() As Nullable(Of Double)
        Function IsDirty(pIndex As rowTblMetaExchangeRate.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

