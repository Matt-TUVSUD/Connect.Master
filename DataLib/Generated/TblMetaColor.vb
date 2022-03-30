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
    Partial Public Class TblMetaColor

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaColor)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaColor, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaColor, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaColor, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[tblMetaColor] " & _
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
        Dim zObj As rowTblMetaColor = LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblMetaColor)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaColor, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaColor, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[tblMetaColor] WHERE [fldId] = @colFldId"

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
                        zUpdate = "UPDATE [dbo].[tblMetaColor] SET " 
                        If pRowData.IsDirty(rowTblMetaColor.FieldIndex.colFldColor) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldColor] = @colFldColor "
                        End If
                        If pRowData.IsDirty(rowTblMetaColor.FieldIndex.colFldHex) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldHex] = @colFldHex "
                        End If
                        If pRowData.IsDirty(rowTblMetaColor.FieldIndex.colFldR) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldR] = @colFldR "
                        End If
                        If pRowData.IsDirty(rowTblMetaColor.FieldIndex.colFldG) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldG] = @colFldG "
                        End If
                        If pRowData.IsDirty(rowTblMetaColor.FieldIndex.colFldB) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldB] = @colFldB "
                        End If
                        If pRowData.IsDirty(rowTblMetaColor.FieldIndex.colFldA) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldA] = @colFldA "
                        End If
                        zWhere = " WHERE [fldId] = @colFldId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaColor] ([fldColor], [fldHex], [fldR], [fldG], [fldB], [fldA])" & _
                            " VALUES (@colFldColor, @colFldHex, @colFldR, @colFldG, @colFldB, @colFldA); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaColor] ([fldColor], [fldHex], [fldR], [fldG], [fldB], [fldA])" & _
                            " VALUES (@colFldColor, @colFldHex, @colFldR, @colFldG, @colFldB, @colFldA); SELECT SCOPE_IDENTITY()"
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

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaColor.FieldIndex.colFldColor) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldColor", IIf(pRowData.colFldColor Is Nothing, DBNull.Value, pRowData.colFldColor)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaColor.FieldIndex.colFldHex) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldHex", IIf(pRowData.colFldHex Is Nothing, DBNull.Value, pRowData.colFldHex)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaColor.FieldIndex.colFldR) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldR", IIf(pRowData.colFldR Is Nothing, DBNull.Value, pRowData.colFldR)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaColor.FieldIndex.colFldG) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldG", IIf(pRowData.colFldG Is Nothing, DBNull.Value, pRowData.colFldG)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaColor.FieldIndex.colFldB) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldB", IIf(pRowData.colFldB Is Nothing, DBNull.Value, pRowData.colFldB)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaColor.FieldIndex.colFldA) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldA", IIf(pRowData.colFldA Is Nothing, DBNull.Value, pRowData.colFldA)))
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

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer) As rowTblMetaColor
            Return LoadByPrimaryKey(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pLoadEventUserState As Object) As rowTblMetaColor
            Return LoadByPrimaryKey(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblMetaColor
            Return LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblMetaColor
            Dim zReturn As New rowTblMetaColor
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaColor] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblMetaColor) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_IDX_Color(pcolFldColor As String) As List(Of rowTblMetaColor)
            Return LoadByIDX_IDX_Color(pcolFldColor, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IDX_Color(pcolFldColor As String, pLoadEventUserState As Object) As List(Of rowTblMetaColor)
            Return LoadByIDX_IDX_Color(pcolFldColor, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IDX_Color(pcolFldColor As String, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaColor)
            Return LoadByIDX_IDX_Color(pcolFldColor, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_IDX_Color(pcolFldColor As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaColor)
            Dim zReturn As New List(Of rowTblMetaColor)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaColor] WHERE [fldColor] = @colFldColor"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldColor", pcolFldColor))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function
        Public Shared Function LoadByIDX_PK_tblMetaColor(pcolFldId As Integer) As List(Of rowTblMetaColor)
            Return LoadByIDX_PK_tblMetaColor(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaColor(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of rowTblMetaColor)
            Return LoadByIDX_PK_tblMetaColor(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaColor(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaColor)
            Return LoadByIDX_PK_tblMetaColor(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaColor(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaColor)
            Dim zReturn As New List(Of rowTblMetaColor)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaColor] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblMetaColor)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblMetaColor)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblMetaColor)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaColor)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaColor)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaColor)
            Dim zReturn As New List(Of rowTblMetaColor)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaColor]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblMetaColor)

			Try
	            Dim zReturn As New List(Of rowTblMetaColor)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblMetaColor

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblMetaColor		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblMetaColor)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldId")) Then pObject.colFldId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldColor")) Then pObject.colFldColor = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldColor")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldHex")) Then pObject.colFldHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldR")) Then pObject.colFldR = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldR")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldG")) Then pObject.colFldG = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldG")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldB")) Then pObject.colFldB = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldB")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldA")) Then pObject.colFldA = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "fldA")
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
            If Not TypeOf zReturn Is rowTblMetaColor Then Throw New ArgumentException("Generic type is not type of rowTblMetaColor.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaColor] WHERE [fldId] = @colFldId"
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

        Public Shared Function LoadByIDX_IDX_Color(Of T)(pcolFldColor As String) As List(Of T)
            Return LoadByIDX_IDX_Color(Of T)(pcolFldColor, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IDX_Color(Of T)(pcolFldColor As String, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_IDX_Color(Of T)(pcolFldColor, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IDX_Color(Of T)(pcolFldColor As String, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_IDX_Color(Of T)(pcolFldColor, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_IDX_Color(Of T)(pcolFldColor As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaColor] WHERE [fldColor] = @colFldColor"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldColor", pcolFldColor))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaColor(Of T)(pcolFldId As Integer) As List(Of T)
            Return LoadByIDX_PK_tblMetaColor(Of T)(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaColor(Of T)(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK_tblMetaColor(Of T)(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaColor(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK_tblMetaColor(Of T)(pcolFldId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK_tblMetaColor(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaColor] WHERE [fldId] = @colFldId"
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
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaColor]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblMetaColor
        Implements IrowTblMetaColor

        Public Event Loaded(pUserState As Object) Implements IrowTblMetaColor.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblMetaColor.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblMetaColor.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblMetaColor.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblMetaColor.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblMetaColor.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldId() As Nullable(Of Integer) Implements IrowTblMetaColor.colFldId
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

        Public Property colFldColor() As String Implements IrowTblMetaColor.colFldColor
            Get
                Return m_colFldColor
            End Get
            Set
                If Not Same(m_colFldColor, Value) Then
                    m_colFldColor = Value
                    m_IsDirty(FieldIndex.colFldColor) = True
                End If
            End Set
        End Property
        Private m_colFldColor As String

        Public Property colFldHex() As String Implements IrowTblMetaColor.colFldHex
            Get
                Return m_colFldHex
            End Get
            Set
                If Not Same(m_colFldHex, Value) Then
                    m_colFldHex = Value
                    m_IsDirty(FieldIndex.colFldHex) = True
                End If
            End Set
        End Property
        Private m_colFldHex As String

        Public Property colFldR() As Nullable(Of Integer) Implements IrowTblMetaColor.colFldR
            Get
                Return m_colFldR
            End Get
            Set
                If Not Same(m_colFldR, Value) Then
                    m_colFldR = Value
                    m_IsDirty(FieldIndex.colFldR) = True
                End If
            End Set
        End Property
        Private m_colFldR As Nullable(Of Integer)

        Public Property colFldG() As Nullable(Of Integer) Implements IrowTblMetaColor.colFldG
            Get
                Return m_colFldG
            End Get
            Set
                If Not Same(m_colFldG, Value) Then
                    m_colFldG = Value
                    m_IsDirty(FieldIndex.colFldG) = True
                End If
            End Set
        End Property
        Private m_colFldG As Nullable(Of Integer)

        Public Property colFldB() As Nullable(Of Integer) Implements IrowTblMetaColor.colFldB
            Get
                Return m_colFldB
            End Get
            Set
                If Not Same(m_colFldB, Value) Then
                    m_colFldB = Value
                    m_IsDirty(FieldIndex.colFldB) = True
                End If
            End Set
        End Property
        Private m_colFldB As Nullable(Of Integer)

        Public Property colFldA() As Nullable(Of Decimal) Implements IrowTblMetaColor.colFldA
            Get
                Return m_colFldA
            End Get
            Set
                If Not Same(m_colFldA, Value) Then
                    m_colFldA = Value
                    m_IsDirty(FieldIndex.colFldA) = True
                End If
            End Set
        End Property
        Private m_colFldA As Nullable(Of Decimal)


        Public Function IsDirty(pIndex As rowTblMetaColor.FieldIndex) As Boolean Implements IrowTblMetaColor.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblMetaColor.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblMetaColor.SetIsDirty
            m_IsDirty(FieldIndex.colFldId) = pDirty
            m_IsDirty(FieldIndex.colFldColor) = pDirty
            m_IsDirty(FieldIndex.colFldHex) = pDirty
            m_IsDirty(FieldIndex.colFldR) = pDirty
            m_IsDirty(FieldIndex.colFldG) = pDirty
            m_IsDirty(FieldIndex.colFldB) = pDirty
            m_IsDirty(FieldIndex.colFldA) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblMetaColor) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblMetaColor
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldId  = 1
            colFldColor 
            colFldHex 
            colFldR 
            colFldG 
            colFldB 
            colFldA 
        End Enum

        Private m_IsDirty(7) As Boolean

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

    Public Interface IrowTblMetaColor
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldId() As Nullable(Of Integer)
        Property colFldColor() As String
        Property colFldHex() As String
        Property colFldR() As Nullable(Of Integer)
        Property colFldG() As Nullable(Of Integer)
        Property colFldB() As Nullable(Of Integer)
        Property colFldA() As Nullable(Of Decimal)
        Function IsDirty(pIndex As rowTblMetaColor.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

