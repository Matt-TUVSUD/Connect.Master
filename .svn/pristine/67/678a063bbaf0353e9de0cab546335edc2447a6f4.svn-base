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
    Partial Public Class TblAdminViewXLSheet

        Public Shared Sub Delete(ByRef pRowData As IrowTblAdminViewXLSheet)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblAdminViewXLSheet, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblAdminViewXLSheet, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblAdminViewXLSheet, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldID) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [adm].[tblAdminViewXLSheet] " & _
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
        Dim zObj As rowTblAdminViewXLSheet = LoadByPrimaryKey(pcolFldID, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblAdminViewXLSheet)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblAdminViewXLSheet, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblAdminViewXLSheet, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldID) Then

                zSQL = "SELECT COUNT(*) from [adm].[tblAdminViewXLSheet] WHERE [fldID] = @colFldID"

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
                        zUpdate = "UPDATE [adm].[tblAdminViewXLSheet] SET " 
                        If pRowData.IsDirty(rowTblAdminViewXLSheet.FieldIndex.colFldTabName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldTabName] = @colFldTabName "
                        End If
                        If pRowData.IsDirty(rowTblAdminViewXLSheet.FieldIndex.colFldViewName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldViewName] = @colFldViewName "
                        End If
                        If pRowData.IsDirty(rowTblAdminViewXLSheet.FieldIndex.colFldSheetPosition) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldSheetPosition] = @colFldSheetPosition "
                        End If
                        If pRowData.IsDirty(rowTblAdminViewXLSheet.FieldIndex.colFldInclude) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldInclude] = @colFldInclude "
                        End If
                        zWhere = " WHERE [fldID] = @colFldID"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [adm].[tblAdminViewXLSheet] ([fldTabName], [fldViewName], [fldSheetPosition], [fldInclude])" & _
                            " VALUES (@colFldTabName, @colFldViewName, @colFldSheetPosition, @colFldInclude); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [adm].[tblAdminViewXLSheet] ([fldTabName], [fldViewName], [fldSheetPosition], [fldInclude])" & _
                            " VALUES (@colFldTabName, @colFldViewName, @colFldSheetPosition, @colFldInclude); SELECT SCOPE_IDENTITY()"
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

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblAdminViewXLSheet.FieldIndex.colFldTabName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldTabName", IIf(pRowData.colFldTabName Is Nothing, DBNull.Value, pRowData.colFldTabName)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblAdminViewXLSheet.FieldIndex.colFldViewName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldViewName", IIf(pRowData.colFldViewName Is Nothing, DBNull.Value, pRowData.colFldViewName)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblAdminViewXLSheet.FieldIndex.colFldSheetPosition) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldSheetPosition", IIf(pRowData.colFldSheetPosition Is Nothing, DBNull.Value, pRowData.colFldSheetPosition)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblAdminViewXLSheet.FieldIndex.colFldInclude) Then
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

        Public Shared Function LoadByPrimaryKey(pcolFldID As Integer) As rowTblAdminViewXLSheet
            Return LoadByPrimaryKey(pcolFldID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldID As Integer, pLoadEventUserState As Object) As rowTblAdminViewXLSheet
            Return LoadByPrimaryKey(pcolFldID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblAdminViewXLSheet
            Return LoadByPrimaryKey(pcolFldID, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblAdminViewXLSheet
            Dim zReturn As New rowTblAdminViewXLSheet
            Dim zSQL As String = "SELECT * FROM [adm].[tblAdminViewXLSheet] WHERE [fldID] = @colFldID"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldID", pcolFldID))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblAdminViewXLSheet) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK__tblAdmin__36326BC36954DE05(pcolFldID As Integer) As List(Of rowTblAdminViewXLSheet)
            Return LoadByIDX_PK__tblAdmin__36326BC36954DE05(pcolFldID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblAdmin__36326BC36954DE05(pcolFldID As Integer, pLoadEventUserState As Object) As List(Of rowTblAdminViewXLSheet)
            Return LoadByIDX_PK__tblAdmin__36326BC36954DE05(pcolFldID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblAdmin__36326BC36954DE05(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblAdminViewXLSheet)
            Return LoadByIDX_PK__tblAdmin__36326BC36954DE05(pcolFldID, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblAdmin__36326BC36954DE05(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblAdminViewXLSheet)
            Dim zReturn As New List(Of rowTblAdminViewXLSheet)
            Dim zSQL As String = "SELECT * FROM [adm].[tblAdminViewXLSheet] WHERE [fldID] = @colFldID"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldID", pcolFldID))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblAdminViewXLSheet)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblAdminViewXLSheet)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblAdminViewXLSheet)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblAdminViewXLSheet)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblAdminViewXLSheet)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblAdminViewXLSheet)
            Dim zReturn As New List(Of rowTblAdminViewXLSheet)
            Dim zSQL As String = "SELECT * FROM [adm].[tblAdminViewXLSheet]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblAdminViewXLSheet)

			Try
	            Dim zReturn As New List(Of rowTblAdminViewXLSheet)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblAdminViewXLSheet

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblAdminViewXLSheet		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblAdminViewXLSheet)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldID")) Then pObject.colFldID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldTabName")) Then pObject.colFldTabName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldTabName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldViewName")) Then pObject.colFldViewName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldViewName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSheetPosition")) Then pObject.colFldSheetPosition = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldSheetPosition")
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
            If Not TypeOf zReturn Is rowTblAdminViewXLSheet Then Throw New ArgumentException("Generic type is not type of rowTblAdminViewXLSheet.","T")

            Dim zSQL As String = "SELECT * FROM [adm].[tblAdminViewXLSheet] WHERE [fldID] = @colFldID"
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

        Public Shared Function LoadByIDX_PK__tblAdmin__36326BC36954DE05(Of T)(pcolFldID As Integer) As List(Of T)
            Return LoadByIDX_PK__tblAdmin__36326BC36954DE05(Of T)(pcolFldID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblAdmin__36326BC36954DE05(Of T)(pcolFldID As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK__tblAdmin__36326BC36954DE05(Of T)(pcolFldID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblAdmin__36326BC36954DE05(Of T)(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK__tblAdmin__36326BC36954DE05(Of T)(pcolFldID, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK__tblAdmin__36326BC36954DE05(Of T)(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [adm].[tblAdminViewXLSheet] WHERE [fldID] = @colFldID"
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
            Dim zSQL As String = "SELECT * FROM [adm].[tblAdminViewXLSheet]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class

    Partial Public Class rowTblAdminViewXLSheet
        Implements IrowTblAdminViewXLSheet

        Public Event Loaded(pUserState As Object) Implements IrowTblAdminViewXLSheet.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblAdminViewXLSheet.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblAdminViewXLSheet.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblAdminViewXLSheet.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblAdminViewXLSheet.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblAdminViewXLSheet.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldID() As Nullable(Of Integer) Implements IrowTblAdminViewXLSheet.colFldID
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

        Public Property colFldTabName() As String Implements IrowTblAdminViewXLSheet.colFldTabName
            Get
                Return m_colFldTabName
            End Get
            Set
                If Not Same(m_colFldTabName, Value) Then
                    m_colFldTabName = Value
                    m_IsDirty(FieldIndex.colFldTabName) = True
                End If
            End Set
        End Property
        Private m_colFldTabName As String

        Public Property colFldViewName() As String Implements IrowTblAdminViewXLSheet.colFldViewName
            Get
                Return m_colFldViewName
            End Get
            Set
                If Not Same(m_colFldViewName, Value) Then
                    m_colFldViewName = Value
                    m_IsDirty(FieldIndex.colFldViewName) = True
                End If
            End Set
        End Property
        Private m_colFldViewName As String

        Public Property colFldSheetPosition() As Nullable(Of Integer) Implements IrowTblAdminViewXLSheet.colFldSheetPosition
            Get
                Return m_colFldSheetPosition
            End Get
            Set
                If Not Same(m_colFldSheetPosition, Value) Then
                    m_colFldSheetPosition = Value
                    m_IsDirty(FieldIndex.colFldSheetPosition) = True
                End If
            End Set
        End Property
        Private m_colFldSheetPosition As Nullable(Of Integer)

        Public Property colFldInclude() As Nullable(Of Boolean) Implements IrowTblAdminViewXLSheet.colFldInclude
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


        Public Function IsDirty(pIndex As rowTblAdminViewXLSheet.FieldIndex) As Boolean Implements IrowTblAdminViewXLSheet.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblAdminViewXLSheet.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblAdminViewXLSheet.SetIsDirty
            m_IsDirty(FieldIndex.colFldID) = pDirty
            m_IsDirty(FieldIndex.colFldTabName) = pDirty
            m_IsDirty(FieldIndex.colFldViewName) = pDirty
            m_IsDirty(FieldIndex.colFldSheetPosition) = pDirty
            m_IsDirty(FieldIndex.colFldInclude) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblAdminViewXLSheet) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblAdminViewXLSheet
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldID  = 1
            colFldTabName 
            colFldViewName 
            colFldSheetPosition 
            colFldInclude 
        End Enum

        Private m_IsDirty(5) As Boolean

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

    Public Interface IrowTblAdminViewXLSheet
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldID() As Nullable(Of Integer)
        Property colFldTabName() As String
        Property colFldViewName() As String
        Property colFldSheetPosition() As Nullable(Of Integer)
        Property colFldInclude() As Nullable(Of Boolean)
        Function IsDirty(pIndex As rowTblAdminViewXLSheet.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

