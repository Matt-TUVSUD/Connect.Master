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
    Partial Public Class TblWhatIfFireRecSelected

        Public Shared Sub Delete(ByRef pRowData As IrowTblWhatIfFireRecSelected)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblWhatIfFireRecSelected, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblWhatIfFireRecSelected, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblWhatIfFireRecSelected, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldGSafeID) And razor.UtilSQLServer.IsKeySet(pRowData.colFldRecID) And razor.UtilSQLServer.IsKeySet(pRowData.colFldFilePrefix) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[TblWhatIfFireRecSelected] " & _
                        "WHERE [fldGSafeID] = @colFldGSafeID AND [fldRecID] = @colFldRecID AND [fldFilePrefix] = @colFldFilePrefix"

                Dim zCmd As New SQLCommand
                zCmd.CommandText = zSQL
                zCmd.Parameters.Add(New SQLParameter("@colFldGSafeID", pRowData.colFldGSafeID))
                zCmd.Parameters.Add(New SQLParameter("@colFldRecID", pRowData.colFldRecID))
                zCmd.Parameters.Add(New SQLParameter("@colFldFilePrefix", pRowData.colFldFilePrefix))

                zCmd.Transaction=pTransaction
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)

                pRowData.RaiseDeletedEvent(pDeleteEventUserState)

            End If

        End Sub

        Public Shared Sub Delete(pcolFldGSafeID As Integer, pcolFldRecID As Integer, pcolFldFilePrefix As String)
            Delete(pcolFldGSafeID, pcolFldRecID, pcolFldFilePrefix, Nothing, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolFldGSafeID As Integer, pcolFldRecID As Integer, pcolFldFilePrefix As String, pDeleteEventUserState As Object)
            Delete(pcolFldGSafeID, pcolFldRecID, pcolFldFilePrefix, Nothing, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Delete(pcolFldGSafeID As Integer, pcolFldRecID As Integer, pcolFldFilePrefix As String, ByRef pTransaction As SqlClient.SqlTransaction)
        Delete(pcolFldGSafeID, pcolFldRecID, pcolFldFilePrefix, pTransaction, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolFldGSafeID As Integer, pcolFldRecID As Integer, pcolFldFilePrefix As String, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
        Dim zObj As rowTblWhatIfFireRecSelected = LoadByPrimaryKey(pcolFldGSafeID, pcolFldRecID, pcolFldFilePrefix, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblWhatIfFireRecSelected)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblWhatIfFireRecSelected, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblWhatIfFireRecSelected, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldGSafeID) And razor.UtilSQLServer.IsKeySet(pRowData.colFldRecID) And razor.UtilSQLServer.IsKeySet(pRowData.colFldFilePrefix) Then

                zSQL = "SELECT COUNT(*) from [dbo].[TblWhatIfFireRecSelected] WHERE [fldGSafeID] = @colFldGSafeID AND [fldRecID] = @colFldRecID AND [fldFilePrefix] = @colFldFilePrefix"

                Dim zCmdDoesExist As New SQLCommand

                zCmdDoesExist.CommandText = zSQL

                zCmdDoesExist.Parameters.Add(new SQLParameter("@colFldGSafeID", pRowData.colFldGSafeID))
                zCmdDoesExist.Parameters.Add(new SQLParameter("@colFldRecID", pRowData.colFldRecID))
                zCmdDoesExist.Parameters.Add(new SQLParameter("@colFldFilePrefix", pRowData.colFldFilePrefix))

                'if zExistInDB > 0  then  PK exists in the DB
                zCmdDoesExist.Transaction = pTransaction
                zExistInDB = razor.UtilSQLServer.ExecuteScalar(zCmdDoesExist)
            End If

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldGSafeID) And razor.UtilSQLServer.IsKeySet(pRowData.colFldRecID) And razor.UtilSQLServer.IsKeySet(pRowData.colFldFilePrefix) And zExistInDB > 0 Then
                zMode = "UPDATE"
            End If
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldGSafeID) And razor.UtilSQLServer.IsKeySet(pRowData.colFldRecID) And razor.UtilSQLServer.IsKeySet(pRowData.colFldFilePrefix) And zExistInDB = 0 Then
                zMode = "INSERTwithKey"
            End If
            If Not razor.UtilSQLServer.IsKeySet(pRowData.colFldGSafeID) Or Not razor.UtilSQLServer.IsKeySet(pRowData.colFldRecID) Or Not razor.UtilSQLServer.IsKeySet(pRowData.colFldFilePrefix) Then
                zMode = "INSERTnoKey"
            End If

            Select Case zMode
                Case "UPDATE"
                    If pRowData.IsDirty Then
                        Dim zUpdate As String = ""
                        Dim zSet As String = ""
                        Dim zWhere As String = ""
                        zUpdate = "UPDATE [dbo].[TblWhatIfFireRecSelected] SET " 
                        If pRowData.IsDirty(rowTblWhatIfFireRecSelected.FieldIndex.colFldCreateDateTime) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldCreateDateTime] = @colFldCreateDateTime "
                        End If
                        zWhere = " WHERE [fldGSafeID] = @colFldGSafeID AND [fldRecID] = @colFldRecID AND [fldFilePrefix] = @colFldFilePrefix"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[TblWhatIfFireRecSelected] ([fldGSafeID], [fldRecID], [fldFilePrefix], [fldCreateDateTime])" & _
                            " VALUES (@colFldGSafeID, @colFldRecID, @colFldFilePrefix, @colFldCreateDateTime); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[TblWhatIfFireRecSelected] ([fldCreateDateTime])" & _
                            " VALUES (@colFldCreateDateTime); SELECT SCOPE_IDENTITY()"
                Case Else
            End Select

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

			'IF UPDATE, SET PK PARAMETER
            If zMode = "UPDATE" Then
                zCmd.Parameters.Add(New SQLParameter("@colFldGSafeID", pRowData.colFldGSafeID))
                zCmd.Parameters.Add(New SQLParameter("@colFldRecID", pRowData.colFldRecID))
                zCmd.Parameters.Add(New SQLParameter("@colFldFilePrefix", pRowData.colFldFilePrefix))
            End If

			'IF INSERTING, KEY HAS VALUE AND KEY IS NOT IDENTITY, SET PK PARAMETER
			If zMode = "INSERTwithKey" Then
                zCmd.Parameters.Add(New SQLParameter("@colFldGSafeID", pRowData.colFldGSafeID))
                zCmd.Parameters.Add(New SQLParameter("@colFldRecID", pRowData.colFldRecID))
                zCmd.Parameters.Add(New SQLParameter("@colFldFilePrefix", pRowData.colFldFilePrefix))
            End If

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatIfFireRecSelected.FieldIndex.colFldCreateDateTime) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldCreateDateTime", IIf(pRowData.colFldCreateDateTime Is Nothing, DBNull.Value, pRowData.colFldCreateDateTime)))
                End If

            zCmd.Transaction=pTransaction
            If zMode = "INSERTnoKey" Then
                Dim zLastId As Long = 0
                zLastId = razor.UtilSQLServer.ExecuteNonQueryRowId(zCmd)

                pRowData.colFldGSafeID = zLastId
                pRowData.colFldRecID = zLastId
                pRowData.colFldFilePrefix = zLastId
            Else
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)
            End If

            pRowData.SetIsDirty(False)
            pRowData.RaiseSavedEvent(pSavedEventUserState)

		End If

        End Sub

        Public Shared Function LoadByPrimaryKey(pcolFldGSafeID As Integer, pcolFldRecID As Integer, pcolFldFilePrefix As String) As rowTblWhatIfFireRecSelected
            Return LoadByPrimaryKey(pcolFldGSafeID, pcolFldRecID, pcolFldFilePrefix, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldGSafeID As Integer, pcolFldRecID As Integer, pcolFldFilePrefix As String, pLoadEventUserState As Object) As rowTblWhatIfFireRecSelected
            Return LoadByPrimaryKey(pcolFldGSafeID, pcolFldRecID, pcolFldFilePrefix, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldGSafeID As Integer, pcolFldRecID As Integer, pcolFldFilePrefix As String, pTransaction As SqlClient.SqlTransaction) As rowTblWhatIfFireRecSelected
            Return LoadByPrimaryKey(pcolFldGSafeID, pcolFldRecID, pcolFldFilePrefix, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldGSafeID As Integer, pcolFldRecID As Integer, pcolFldFilePrefix As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblWhatIfFireRecSelected
            Dim zReturn As New rowTblWhatIfFireRecSelected
            Dim zSQL As String = "SELECT * FROM [dbo].[TblWhatIfFireRecSelected] WHERE [fldGSafeID] = @colFldGSafeID AND [fldRecID] = @colFldRecID AND [fldFilePrefix] = @colFldFilePrefix"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldGSafeID", pcolFldGSafeID))
            zCmd.Parameters.Add(New SQLParameter("@colFldRecID", pcolFldRecID))
            zCmd.Parameters.Add(New SQLParameter("@colFldFilePrefix", pcolFldFilePrefix))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblWhatIfFireRecSelected) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK_TblWhatIfSelectedRec_1(pcolFldGSafeID As Integer, pcolFldRecID As Integer, pcolFldFilePrefix As String) As List(Of rowTblWhatIfFireRecSelected)
            Return LoadByIDX_PK_TblWhatIfSelectedRec_1(pcolFldGSafeID, pcolFldRecID, pcolFldFilePrefix, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_TblWhatIfSelectedRec_1(pcolFldGSafeID As Integer, pcolFldRecID As Integer, pcolFldFilePrefix As String, pLoadEventUserState As Object) As List(Of rowTblWhatIfFireRecSelected)
            Return LoadByIDX_PK_TblWhatIfSelectedRec_1(pcolFldGSafeID, pcolFldRecID, pcolFldFilePrefix, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_TblWhatIfSelectedRec_1(pcolFldGSafeID As Integer, pcolFldRecID As Integer, pcolFldFilePrefix As String, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblWhatIfFireRecSelected)
            Return LoadByIDX_PK_TblWhatIfSelectedRec_1(pcolFldGSafeID, pcolFldRecID, pcolFldFilePrefix, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_TblWhatIfSelectedRec_1(pcolFldGSafeID As Integer, pcolFldRecID As Integer, pcolFldFilePrefix As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblWhatIfFireRecSelected)
            Dim zReturn As New List(Of rowTblWhatIfFireRecSelected)
            Dim zSQL As String = "SELECT * FROM [dbo].[TblWhatIfFireRecSelected] WHERE [fldGSafeID] = @colFldGSafeID AND [fldRecID] = @colFldRecID AND [fldFilePrefix] = @colFldFilePrefix"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldGSafeID", pcolFldGSafeID))
            zCmd.Parameters.Add(New SQLParameter("@colFldRecID", pcolFldRecID))
            zCmd.Parameters.Add(New SQLParameter("@colFldFilePrefix", pcolFldFilePrefix))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblWhatIfFireRecSelected)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblWhatIfFireRecSelected)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblWhatIfFireRecSelected)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblWhatIfFireRecSelected)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblWhatIfFireRecSelected)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblWhatIfFireRecSelected)
            Dim zReturn As New List(Of rowTblWhatIfFireRecSelected)
            Dim zSQL As String = "SELECT * FROM [dbo].[TblWhatIfFireRecSelected]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblWhatIfFireRecSelected)

			Try
	            Dim zReturn As New List(Of rowTblWhatIfFireRecSelected)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblWhatIfFireRecSelected

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblWhatIfFireRecSelected		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblWhatIfFireRecSelected)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldGSafeID")) Then pObject.colFldGSafeID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldGSafeID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldRecID")) Then pObject.colFldRecID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldRecID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFilePrefix")) Then pObject.colFldFilePrefix = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldFilePrefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldCreateDateTime")) Then pObject.colFldCreateDateTime = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "fldCreateDateTime")
			pObject.SetIsDirty(False)
			Return pObject
		End	 Function

    #Region "Reflection Based Load Functions"

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldGSafeID As Integer, pcolFldRecID As Integer, pcolFldFilePrefix As String) As T
            Return LoadByPrimaryKey(Of T)(pcolFldGSafeID, pcolFldRecID, pcolFldFilePrefix, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldGSafeID As Integer, pcolFldRecID As Integer, pcolFldFilePrefix As String, pLoadEventUserState As Object) As T
            Return LoadByPrimaryKey(Of T)(pcolFldGSafeID, pcolFldRecID, pcolFldFilePrefix, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldGSafeID As Integer, pcolFldRecID As Integer, pcolFldFilePrefix As String, pTransaction As SqlClient.SqlTransaction) As T
            Return LoadByPrimaryKey(Of T)(pcolFldGSafeID, pcolFldRecID, pcolFldFilePrefix, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldGSafeID As Integer, pcolFldRecID As Integer, pcolFldFilePrefix As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As T

            Dim zReturn As Object = Activator.CreateInstance(Of T)()
            If Not TypeOf zReturn Is rowTblWhatIfFireRecSelected Then Throw New ArgumentException("Generic type is not type of rowTblWhatIfFireRecSelected.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[TblWhatIfFireRecSelected] WHERE [fldGSafeID] = @colFldGSafeID AND [fldRecID] = @colFldRecID AND [fldFilePrefix] = @colFldFilePrefix"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldGSafeID", pcolFldGSafeID))
            zCmd.Parameters.Add(New SQLParameter("@colFldRecID", pcolFldRecID))
            zCmd.Parameters.Add(New SQLParameter("@colFldFilePrefix", pcolFldFilePrefix))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of T) = ReadData(Of T)(zCmd, pLoadEventUserState)
            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

        End Function

        Public Shared Function LoadByIDX_PK_TblWhatIfSelectedRec_1(Of T)(pcolFldGSafeID As Integer, pcolFldRecID As Integer, pcolFldFilePrefix As String) As List(Of T)
            Return LoadByIDX_PK_TblWhatIfSelectedRec_1(Of T)(pcolFldGSafeID, pcolFldRecID, pcolFldFilePrefix, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_TblWhatIfSelectedRec_1(Of T)(pcolFldGSafeID As Integer, pcolFldRecID As Integer, pcolFldFilePrefix As String, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK_TblWhatIfSelectedRec_1(Of T)(pcolFldGSafeID, pcolFldRecID, pcolFldFilePrefix, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_TblWhatIfSelectedRec_1(Of T)(pcolFldGSafeID As Integer, pcolFldRecID As Integer, pcolFldFilePrefix As String, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK_TblWhatIfSelectedRec_1(Of T)(pcolFldGSafeID, pcolFldRecID, pcolFldFilePrefix, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK_TblWhatIfSelectedRec_1(Of T)(pcolFldGSafeID As Integer, pcolFldRecID As Integer, pcolFldFilePrefix As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[TblWhatIfFireRecSelected] WHERE [fldGSafeID] = @colFldGSafeID AND [fldRecID] = @colFldRecID AND [fldFilePrefix] = @colFldFilePrefix"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldGSafeID", pcolFldGSafeID))
            zCmd.Parameters.Add(New SQLParameter("@colFldRecID", pcolFldRecID))
            zCmd.Parameters.Add(New SQLParameter("@colFldFilePrefix", pcolFldFilePrefix))

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
            Dim zSQL As String = "SELECT * FROM [dbo].[TblWhatIfFireRecSelected]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblWhatIfFireRecSelected
        Implements IrowTblWhatIfFireRecSelected

        Public Event Loaded(pUserState As Object) Implements IrowTblWhatIfFireRecSelected.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblWhatIfFireRecSelected.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblWhatIfFireRecSelected.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblWhatIfFireRecSelected.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblWhatIfFireRecSelected.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblWhatIfFireRecSelected.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldGSafeID() As Nullable(Of Integer) Implements IrowTblWhatIfFireRecSelected.colFldGSafeID
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

        Public Property colFldRecID() As Nullable(Of Integer) Implements IrowTblWhatIfFireRecSelected.colFldRecID
            Get
                Return m_colFldRecID
            End Get
            Set
                If Not Same(m_colFldRecID, Value) Then
                    m_colFldRecID = Value
                    m_IsDirty(FieldIndex.colFldRecID) = True
                End If
            End Set
        End Property
        Private m_colFldRecID As Nullable(Of Integer)

        Public Property colFldFilePrefix() As String Implements IrowTblWhatIfFireRecSelected.colFldFilePrefix
            Get
                Return m_colFldFilePrefix
            End Get
            Set
                If Not Same(m_colFldFilePrefix, Value) Then
                    m_colFldFilePrefix = Value
                    m_IsDirty(FieldIndex.colFldFilePrefix) = True
                End If
            End Set
        End Property
        Private m_colFldFilePrefix As String

        Public Property colFldCreateDateTime() As Nullable(Of DateTime) Implements IrowTblWhatIfFireRecSelected.colFldCreateDateTime
            Get
                Return m_colFldCreateDateTime
            End Get
            Set
                If Not Same(m_colFldCreateDateTime, Value) Then
                    m_colFldCreateDateTime = Value
                    m_IsDirty(FieldIndex.colFldCreateDateTime) = True
                End If
            End Set
        End Property
        Private m_colFldCreateDateTime As Nullable(Of DateTime)


        Public Function IsDirty(pIndex As rowTblWhatIfFireRecSelected.FieldIndex) As Boolean Implements IrowTblWhatIfFireRecSelected.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblWhatIfFireRecSelected.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblWhatIfFireRecSelected.SetIsDirty
            m_IsDirty(FieldIndex.colFldGSafeID) = pDirty
            m_IsDirty(FieldIndex.colFldRecID) = pDirty
            m_IsDirty(FieldIndex.colFldFilePrefix) = pDirty
            m_IsDirty(FieldIndex.colFldCreateDateTime) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblWhatIfFireRecSelected) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblWhatIfFireRecSelected
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldGSafeID  = 1
            colFldRecID 
            colFldFilePrefix 
            colFldCreateDateTime 
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

    Public Interface IrowTblWhatIfFireRecSelected
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldGSafeID() As Nullable(Of Integer)
        Property colFldRecID() As Nullable(Of Integer)
        Property colFldFilePrefix() As String
        Property colFldCreateDateTime() As Nullable(Of DateTime)
        Function IsDirty(pIndex As rowTblWhatIfFireRecSelected.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

