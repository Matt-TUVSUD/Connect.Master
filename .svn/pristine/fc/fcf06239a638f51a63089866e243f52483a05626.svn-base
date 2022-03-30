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
    Partial Public Class TblAdminViewXLColumn

        Public Shared Sub Delete(ByRef pRowData As IrowTblAdminViewXLColumn)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblAdminViewXLColumn, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblAdminViewXLColumn, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblAdminViewXLColumn, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldID) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [adm].[tblAdminViewXLColumn] " & _
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
        Dim zObj As rowTblAdminViewXLColumn = LoadByPrimaryKey(pcolFldID, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblAdminViewXLColumn)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblAdminViewXLColumn, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblAdminViewXLColumn, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldID) Then

                zSQL = "SELECT COUNT(*) from [adm].[tblAdminViewXLColumn] WHERE [fldID] = @colFldID"

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
                        zUpdate = "UPDATE [adm].[tblAdminViewXLColumn] SET " 
                        If pRowData.IsDirty(rowTblAdminViewXLColumn.FieldIndex.colFldAdminXLSheetID) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldAdminXLSheetID] = @colFldAdminXLSheetID "
                        End If
                        If pRowData.IsDirty(rowTblAdminViewXLColumn.FieldIndex.colFldDataMember) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldDataMember] = @colFldDataMember "
                        End If
                        If pRowData.IsDirty(rowTblAdminViewXLColumn.FieldIndex.colFdlHyperLinkMember) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fdlHyperLinkMember] = @colFdlHyperLinkMember "
                        End If
                        If pRowData.IsDirty(rowTblAdminViewXLColumn.FieldIndex.colFldHeaderText) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldHeaderText] = @colFldHeaderText "
                        End If
                        If pRowData.IsDirty(rowTblAdminViewXLColumn.FieldIndex.colFldColumnPosition) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldColumnPosition] = @colFldColumnPosition "
                        End If
                        If pRowData.IsDirty(rowTblAdminViewXLColumn.FieldIndex.colFldInclude) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldInclude] = @colFldInclude "
                        End If
                        zWhere = " WHERE [fldID] = @colFldID"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [adm].[tblAdminViewXLColumn] ([fldAdminXLSheetID], [fldDataMember], [fdlHyperLinkMember], [fldHeaderText], [fldColumnPosition], [fldInclude])" & _
                            " VALUES (@colFldAdminXLSheetID, @colFldDataMember, @colFdlHyperLinkMember, @colFldHeaderText, @colFldColumnPosition, @colFldInclude); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [adm].[tblAdminViewXLColumn] ([fldAdminXLSheetID], [fldDataMember], [fdlHyperLinkMember], [fldHeaderText], [fldColumnPosition], [fldInclude])" & _
                            " VALUES (@colFldAdminXLSheetID, @colFldDataMember, @colFdlHyperLinkMember, @colFldHeaderText, @colFldColumnPosition, @colFldInclude); SELECT SCOPE_IDENTITY()"
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

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblAdminViewXLColumn.FieldIndex.colFldAdminXLSheetID) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldAdminXLSheetID", IIf(pRowData.colFldAdminXLSheetID Is Nothing, DBNull.Value, pRowData.colFldAdminXLSheetID)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblAdminViewXLColumn.FieldIndex.colFldDataMember) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldDataMember", IIf(pRowData.colFldDataMember Is Nothing, DBNull.Value, pRowData.colFldDataMember)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblAdminViewXLColumn.FieldIndex.colFdlHyperLinkMember) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFdlHyperLinkMember", IIf(pRowData.colFdlHyperLinkMember Is Nothing, DBNull.Value, pRowData.colFdlHyperLinkMember)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblAdminViewXLColumn.FieldIndex.colFldHeaderText) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldHeaderText", IIf(pRowData.colFldHeaderText Is Nothing, DBNull.Value, pRowData.colFldHeaderText)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblAdminViewXLColumn.FieldIndex.colFldColumnPosition) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldColumnPosition", IIf(pRowData.colFldColumnPosition Is Nothing, DBNull.Value, pRowData.colFldColumnPosition)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblAdminViewXLColumn.FieldIndex.colFldInclude) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldInclude", IIf(pRowData.colFldInclude Is Nothing, DBNull.Value, pRowData.colFldInclude)))
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

        Public Shared Function LoadByPrimaryKey(pcolFldID As Integer) As rowTblAdminViewXLColumn
            Return LoadByPrimaryKey(pcolFldID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldID As Integer, pLoadEventUserState As Object) As rowTblAdminViewXLColumn
            Return LoadByPrimaryKey(pcolFldID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblAdminViewXLColumn
            Return LoadByPrimaryKey(pcolFldID, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblAdminViewXLColumn
            Dim zReturn As New rowTblAdminViewXLColumn
            Dim zSQL As String = "SELECT * FROM [adm].[tblAdminViewXLColumn] WHERE [fldID] = @colFldID"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldID", pcolFldID))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblAdminViewXLColumn) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK__AdminVie__36326BC369F3FC83(pcolFldID As Integer) As List(Of rowTblAdminViewXLColumn)
            Return LoadByIDX_PK__AdminVie__36326BC369F3FC83(pcolFldID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__AdminVie__36326BC369F3FC83(pcolFldID As Integer, pLoadEventUserState As Object) As List(Of rowTblAdminViewXLColumn)
            Return LoadByIDX_PK__AdminVie__36326BC369F3FC83(pcolFldID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__AdminVie__36326BC369F3FC83(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblAdminViewXLColumn)
            Return LoadByIDX_PK__AdminVie__36326BC369F3FC83(pcolFldID, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__AdminVie__36326BC369F3FC83(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblAdminViewXLColumn)
            Dim zReturn As New List(Of rowTblAdminViewXLColumn)
            Dim zSQL As String = "SELECT * FROM [adm].[tblAdminViewXLColumn] WHERE [fldID] = @colFldID"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldID", pcolFldID))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblAdminViewXLColumn)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblAdminViewXLColumn)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblAdminViewXLColumn)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblAdminViewXLColumn)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblAdminViewXLColumn)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblAdminViewXLColumn)
            Dim zReturn As New List(Of rowTblAdminViewXLColumn)
            Dim zSQL As String = "SELECT * FROM [adm].[tblAdminViewXLColumn]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblAdminViewXLColumn)

			Try
	            Dim zReturn As New List(Of rowTblAdminViewXLColumn)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblAdminViewXLColumn

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblAdminViewXLColumn		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblAdminViewXLColumn)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldID")) Then pObject.colFldID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldAdminXLSheetID")) Then pObject.colFldAdminXLSheetID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldAdminXLSheetID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldDataMember")) Then pObject.colFldDataMember = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldDataMember")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fdlHyperLinkMember")) Then pObject.colFdlHyperLinkMember = UtilSQLServer.SafeReader.SafeReadString(pReader, "fdlHyperLinkMember")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldHeaderText")) Then pObject.colFldHeaderText = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldHeaderText")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldColumnPosition")) Then pObject.colFldColumnPosition = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldColumnPosition")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldInclude")) Then pObject.colFldInclude = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldInclude")
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
            If Not TypeOf zReturn Is rowTblAdminViewXLColumn Then Throw New ArgumentException("Generic type is not type of rowTblAdminViewXLColumn.","T")

            Dim zSQL As String = "SELECT * FROM [adm].[tblAdminViewXLColumn] WHERE [fldID] = @colFldID"
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

        Public Shared Function LoadByIDX_PK__AdminVie__36326BC369F3FC83(Of T)(pcolFldID As Integer) As List(Of T)
            Return LoadByIDX_PK__AdminVie__36326BC369F3FC83(Of T)(pcolFldID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__AdminVie__36326BC369F3FC83(Of T)(pcolFldID As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK__AdminVie__36326BC369F3FC83(Of T)(pcolFldID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__AdminVie__36326BC369F3FC83(Of T)(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK__AdminVie__36326BC369F3FC83(Of T)(pcolFldID, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK__AdminVie__36326BC369F3FC83(Of T)(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [adm].[tblAdminViewXLColumn] WHERE [fldID] = @colFldID"
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
            Dim zSQL As String = "SELECT * FROM [adm].[tblAdminViewXLColumn]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class

    Partial Public Class rowTblAdminViewXLColumn
        Implements IrowTblAdminViewXLColumn

        Public Event Loaded(pUserState As Object) Implements IrowTblAdminViewXLColumn.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblAdminViewXLColumn.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblAdminViewXLColumn.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblAdminViewXLColumn.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblAdminViewXLColumn.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblAdminViewXLColumn.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldID() As Nullable(Of Integer) Implements IrowTblAdminViewXLColumn.colFldID
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

        Public Property colFldAdminXLSheetID() As Nullable(Of Integer) Implements IrowTblAdminViewXLColumn.colFldAdminXLSheetID
            Get
                Return m_colFldAdminXLSheetID
            End Get
            Set
                If Not Same(m_colFldAdminXLSheetID, Value) Then
                    m_colFldAdminXLSheetID = Value
                    m_IsDirty(FieldIndex.colFldAdminXLSheetID) = True
                End If
            End Set
        End Property
        Private m_colFldAdminXLSheetID As Nullable(Of Integer)

        Public Property colFldDataMember() As String Implements IrowTblAdminViewXLColumn.colFldDataMember
            Get
                Return m_colFldDataMember
            End Get
            Set
                If Not Same(m_colFldDataMember, Value) Then
                    m_colFldDataMember = Value
                    m_IsDirty(FieldIndex.colFldDataMember) = True
                End If
            End Set
        End Property
        Private m_colFldDataMember As String

        Public Property colFdlHyperLinkMember() As String Implements IrowTblAdminViewXLColumn.colFdlHyperLinkMember
            Get
                Return m_colFdlHyperLinkMember
            End Get
            Set
                If Not Same(m_colFdlHyperLinkMember, Value) Then
                    m_colFdlHyperLinkMember = Value
                    m_IsDirty(FieldIndex.colFdlHyperLinkMember) = True
                End If
            End Set
        End Property
        Private m_colFdlHyperLinkMember As String

        Public Property colFldHeaderText() As String Implements IrowTblAdminViewXLColumn.colFldHeaderText
            Get
                Return m_colFldHeaderText
            End Get
            Set
                If Not Same(m_colFldHeaderText, Value) Then
                    m_colFldHeaderText = Value
                    m_IsDirty(FieldIndex.colFldHeaderText) = True
                End If
            End Set
        End Property
        Private m_colFldHeaderText As String

        Public Property colFldColumnPosition() As Nullable(Of Integer) Implements IrowTblAdminViewXLColumn.colFldColumnPosition
            Get
                Return m_colFldColumnPosition
            End Get
            Set
                If Not Same(m_colFldColumnPosition, Value) Then
                    m_colFldColumnPosition = Value
                    m_IsDirty(FieldIndex.colFldColumnPosition) = True
                End If
            End Set
        End Property
        Private m_colFldColumnPosition As Nullable(Of Integer)

        Public Property colFldInclude() As Nullable(Of Boolean) Implements IrowTblAdminViewXLColumn.colFldInclude
            Get
                Return m_colFldInclude
            End Get
            Set
                If Not Same(m_colFldInclude, Value) Then
                    m_colFldInclude = Value
                    m_IsDirty(FieldIndex.colFldInclude) = True
                End If
            End Set
        End Property
        Private m_colFldInclude As Nullable(Of Boolean)


        Public Function IsDirty(pIndex As rowTblAdminViewXLColumn.FieldIndex) As Boolean Implements IrowTblAdminViewXLColumn.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblAdminViewXLColumn.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblAdminViewXLColumn.SetIsDirty
            m_IsDirty(FieldIndex.colFldID) = pDirty
            m_IsDirty(FieldIndex.colFldAdminXLSheetID) = pDirty
            m_IsDirty(FieldIndex.colFldDataMember) = pDirty
            m_IsDirty(FieldIndex.colFdlHyperLinkMember) = pDirty
            m_IsDirty(FieldIndex.colFldHeaderText) = pDirty
            m_IsDirty(FieldIndex.colFldColumnPosition) = pDirty
            m_IsDirty(FieldIndex.colFldInclude) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblAdminViewXLColumn) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblAdminViewXLColumn
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldID  = 1
            colFldAdminXLSheetID 
            colFldDataMember 
            colFdlHyperLinkMember 
            colFldHeaderText 
            colFldColumnPosition 
            colFldInclude 
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

    Public Interface IrowTblAdminViewXLColumn
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldID() As Nullable(Of Integer)
        Property colFldAdminXLSheetID() As Nullable(Of Integer)
        Property colFldDataMember() As String
        Property colFdlHyperLinkMember() As String
        Property colFldHeaderText() As String
        Property colFldColumnPosition() As Nullable(Of Integer)
        Property colFldInclude() As Nullable(Of Boolean)
        Function IsDirty(pIndex As rowTblAdminViewXLColumn.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

