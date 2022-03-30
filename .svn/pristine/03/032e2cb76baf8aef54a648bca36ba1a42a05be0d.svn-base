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
    Partial Public Class TblWhatIfRecSort

        Public Shared Sub Delete(ByRef pRowData As IrowTblWhatIfRecSort)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblWhatIfRecSort, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblWhatIfRecSort, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblWhatIfRecSort, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldID) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[TblWhatIfRecSort] " & _
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
        Dim zObj As rowTblWhatIfRecSort = LoadByPrimaryKey(pcolFldID, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblWhatIfRecSort)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblWhatIfRecSort, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblWhatIfRecSort, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldID) Then

                zSQL = "SELECT COUNT(*) from [dbo].[TblWhatIfRecSort] WHERE [fldID] = @colFldID"

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
                        zUpdate = "UPDATE [dbo].[TblWhatIfRecSort] SET " 
                        If pRowData.IsDirty(rowTblWhatIfRecSort.FieldIndex.colFldText) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldText] = @colFldText "
                        End If
                        If pRowData.IsDirty(rowTblWhatIfRecSort.FieldIndex.colFldToolTip) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldToolTip] = @colFldToolTip "
                        End If
                        If pRowData.IsDirty(rowTblWhatIfRecSort.FieldIndex.colFldSortJson) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldSortJson] = @colFldSortJson "
                        End If
                        If pRowData.IsDirty(rowTblWhatIfRecSort.FieldIndex.colFldSortOrder) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldSortOrder] = @colFldSortOrder "
                        End If
                        If pRowData.IsDirty(rowTblWhatIfRecSort.FieldIndex.colFldVisible) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldVisible] = @colFldVisible "
                        End If
                        zWhere = " WHERE [fldID] = @colFldID"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[TblWhatIfRecSort] ([fldText], [fldToolTip], [fldSortJson], [fldSortOrder], [fldVisible])" & _
                            " VALUES (@colFldText, @colFldToolTip, @colFldSortJson, @colFldSortOrder, @colFldVisible); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[TblWhatIfRecSort] ([fldText], [fldToolTip], [fldSortJson], [fldSortOrder], [fldVisible])" & _
                            " VALUES (@colFldText, @colFldToolTip, @colFldSortJson, @colFldSortOrder, @colFldVisible); SELECT SCOPE_IDENTITY()"
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

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatIfRecSort.FieldIndex.colFldText) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldText", IIf(pRowData.colFldText Is Nothing, DBNull.Value, pRowData.colFldText)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatIfRecSort.FieldIndex.colFldToolTip) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldToolTip", IIf(pRowData.colFldToolTip Is Nothing, DBNull.Value, pRowData.colFldToolTip)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatIfRecSort.FieldIndex.colFldSortJson) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldSortJson", IIf(pRowData.colFldSortJson Is Nothing, DBNull.Value, pRowData.colFldSortJson)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatIfRecSort.FieldIndex.colFldSortOrder) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldSortOrder", IIf(pRowData.colFldSortOrder Is Nothing, DBNull.Value, pRowData.colFldSortOrder)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatIfRecSort.FieldIndex.colFldVisible) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldVisible", IIf(pRowData.colFldVisible Is Nothing, DBNull.Value, pRowData.colFldVisible)))
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

        Public Shared Function LoadByPrimaryKey(pcolFldID As Integer) As rowTblWhatIfRecSort
            Return LoadByPrimaryKey(pcolFldID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldID As Integer, pLoadEventUserState As Object) As rowTblWhatIfRecSort
            Return LoadByPrimaryKey(pcolFldID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblWhatIfRecSort
            Return LoadByPrimaryKey(pcolFldID, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblWhatIfRecSort
            Dim zReturn As New rowTblWhatIfRecSort
            Dim zSQL As String = "SELECT * FROM [dbo].[TblWhatIfRecSort] WHERE [fldID] = @colFldID"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldID", pcolFldID))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblWhatIfRecSort) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK_tblWhatIfRecSort_fldID(pcolFldID As Integer) As List(Of rowTblWhatIfRecSort)
            Return LoadByIDX_PK_tblWhatIfRecSort_fldID(pcolFldID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblWhatIfRecSort_fldID(pcolFldID As Integer, pLoadEventUserState As Object) As List(Of rowTblWhatIfRecSort)
            Return LoadByIDX_PK_tblWhatIfRecSort_fldID(pcolFldID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_tblWhatIfRecSort_fldID(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblWhatIfRecSort)
            Return LoadByIDX_PK_tblWhatIfRecSort_fldID(pcolFldID, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblWhatIfRecSort_fldID(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblWhatIfRecSort)
            Dim zReturn As New List(Of rowTblWhatIfRecSort)
            Dim zSQL As String = "SELECT * FROM [dbo].[TblWhatIfRecSort] WHERE [fldID] = @colFldID"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldID", pcolFldID))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblWhatIfRecSort)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblWhatIfRecSort)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblWhatIfRecSort)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblWhatIfRecSort)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblWhatIfRecSort)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblWhatIfRecSort)
            Dim zReturn As New List(Of rowTblWhatIfRecSort)
            Dim zSQL As String = "SELECT * FROM [dbo].[TblWhatIfRecSort]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblWhatIfRecSort)

			Try
	            Dim zReturn As New List(Of rowTblWhatIfRecSort)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblWhatIfRecSort

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblWhatIfRecSort		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblWhatIfRecSort)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldID")) Then pObject.colFldID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldText")) Then pObject.colFldText = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldText")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldToolTip")) Then pObject.colFldToolTip = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldToolTip")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSortJson")) Then pObject.colFldSortJson = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldSortJson")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSortOrder")) Then pObject.colFldSortOrder = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldSortOrder")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldVisible")) Then pObject.colFldVisible = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldVisible")
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
            If Not TypeOf zReturn Is rowTblWhatIfRecSort Then Throw New ArgumentException("Generic type is not type of rowTblWhatIfRecSort.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[TblWhatIfRecSort] WHERE [fldID] = @colFldID"
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

        Public Shared Function LoadByIDX_PK_tblWhatIfRecSort_fldID(Of T)(pcolFldID As Integer) As List(Of T)
            Return LoadByIDX_PK_tblWhatIfRecSort_fldID(Of T)(pcolFldID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblWhatIfRecSort_fldID(Of T)(pcolFldID As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK_tblWhatIfRecSort_fldID(Of T)(pcolFldID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_tblWhatIfRecSort_fldID(Of T)(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK_tblWhatIfRecSort_fldID(Of T)(pcolFldID, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK_tblWhatIfRecSort_fldID(Of T)(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[TblWhatIfRecSort] WHERE [fldID] = @colFldID"
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
            Dim zSQL As String = "SELECT * FROM [dbo].[TblWhatIfRecSort]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblWhatIfRecSort
        Implements IrowTblWhatIfRecSort

        Public Event Loaded(pUserState As Object) Implements IrowTblWhatIfRecSort.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblWhatIfRecSort.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblWhatIfRecSort.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblWhatIfRecSort.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblWhatIfRecSort.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblWhatIfRecSort.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldID() As Nullable(Of Integer) Implements IrowTblWhatIfRecSort.colFldID
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

        Public Property colFldText() As String Implements IrowTblWhatIfRecSort.colFldText
            Get
                Return m_colFldText
            End Get
            Set
                If Not Same(m_colFldText, Value) Then
                    m_colFldText = Value
                    m_IsDirty(FieldIndex.colFldText) = True
                End If
            End Set
        End Property
        Private m_colFldText As String

        Public Property colFldToolTip() As String Implements IrowTblWhatIfRecSort.colFldToolTip
            Get
                Return m_colFldToolTip
            End Get
            Set
                If Not Same(m_colFldToolTip, Value) Then
                    m_colFldToolTip = Value
                    m_IsDirty(FieldIndex.colFldToolTip) = True
                End If
            End Set
        End Property
        Private m_colFldToolTip As String

        Public Property colFldSortJson() As String Implements IrowTblWhatIfRecSort.colFldSortJson
            Get
                Return m_colFldSortJson
            End Get
            Set
                If Not Same(m_colFldSortJson, Value) Then
                    m_colFldSortJson = Value
                    m_IsDirty(FieldIndex.colFldSortJson) = True
                End If
            End Set
        End Property
        Private m_colFldSortJson As String

        Public Property colFldSortOrder() As Nullable(Of Integer) Implements IrowTblWhatIfRecSort.colFldSortOrder
            Get
                Return m_colFldSortOrder
            End Get
            Set
                If Not Same(m_colFldSortOrder, Value) Then
                    m_colFldSortOrder = Value
                    m_IsDirty(FieldIndex.colFldSortOrder) = True
                End If
            End Set
        End Property
        Private m_colFldSortOrder As Nullable(Of Integer)

        Public Property colFldVisible() As Nullable(Of Boolean) Implements IrowTblWhatIfRecSort.colFldVisible
            Get
                Return m_colFldVisible
            End Get
            Set
                If Not Same(m_colFldVisible, Value) Then
                    m_colFldVisible = Value
                    m_IsDirty(FieldIndex.colFldVisible) = True
                End If
            End Set
        End Property
        Private m_colFldVisible As Nullable(Of Boolean)


        Public Function IsDirty(pIndex As rowTblWhatIfRecSort.FieldIndex) As Boolean Implements IrowTblWhatIfRecSort.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblWhatIfRecSort.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblWhatIfRecSort.SetIsDirty
            m_IsDirty(FieldIndex.colFldID) = pDirty
            m_IsDirty(FieldIndex.colFldText) = pDirty
            m_IsDirty(FieldIndex.colFldToolTip) = pDirty
            m_IsDirty(FieldIndex.colFldSortJson) = pDirty
            m_IsDirty(FieldIndex.colFldSortOrder) = pDirty
            m_IsDirty(FieldIndex.colFldVisible) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblWhatIfRecSort) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblWhatIfRecSort
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldID  = 1
            colFldText 
            colFldToolTip 
            colFldSortJson 
            colFldSortOrder 
            colFldVisible 
        End Enum

        Private m_IsDirty(6) As Boolean

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

    Public Interface IrowTblWhatIfRecSort
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldID() As Nullable(Of Integer)
        Property colFldText() As String
        Property colFldToolTip() As String
        Property colFldSortJson() As String
        Property colFldSortOrder() As Nullable(Of Integer)
        Property colFldVisible() As Nullable(Of Boolean)
        Function IsDirty(pIndex As rowTblWhatIfRecSort.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

