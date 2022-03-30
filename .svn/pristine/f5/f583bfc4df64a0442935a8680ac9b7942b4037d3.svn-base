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
    Partial Public Class TblAdminNoteTextBox

        Public Shared Sub Delete(ByRef pRowData As IrowTblAdminNoteTextBox)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblAdminNoteTextBox, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblAdminNoteTextBox, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblAdminNoteTextBox, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldPracticeGroupCd) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [adm].[tblAdminNoteTextBox] " & _
                        "WHERE [fldPracticeGroupCd] = @colFldPracticeGroupCd"

                Dim zCmd As New SQLCommand
                zCmd.CommandText = zSQL
                zCmd.Parameters.Add(New SQLParameter("@colFldPracticeGroupCd", pRowData.colFldPracticeGroupCd))

                zCmd.Transaction=pTransaction
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)

                pRowData.RaiseDeletedEvent(pDeleteEventUserState)

            End If

        End Sub

        Public Shared Sub Delete(pcolFldPracticeGroupCd As String)
            Delete(pcolFldPracticeGroupCd, Nothing, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolFldPracticeGroupCd As String, pDeleteEventUserState As Object)
            Delete(pcolFldPracticeGroupCd, Nothing, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Delete(pcolFldPracticeGroupCd As String, ByRef pTransaction As SqlClient.SqlTransaction)
        Delete(pcolFldPracticeGroupCd, pTransaction, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolFldPracticeGroupCd As String, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
        Dim zObj As rowTblAdminNoteTextBox = LoadByPrimaryKey(pcolFldPracticeGroupCd, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblAdminNoteTextBox)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblAdminNoteTextBox, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblAdminNoteTextBox, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldPracticeGroupCd) Then

                zSQL = "SELECT COUNT(*) from [adm].[tblAdminNoteTextBox] WHERE [fldPracticeGroupCd] = @colFldPracticeGroupCd"

                Dim zCmdDoesExist As New SQLCommand

                zCmdDoesExist.CommandText = zSQL

                zCmdDoesExist.Parameters.Add(new SQLParameter("@colFldPracticeGroupCd", pRowData.colFldPracticeGroupCd))

                'if zExistInDB > 0  then  PK exists in the DB
                zCmdDoesExist.Transaction = pTransaction
                zExistInDB = razor.UtilSQLServer.ExecuteScalar(zCmdDoesExist)
            End If

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldPracticeGroupCd) And zExistInDB > 0 Then
                zMode = "UPDATE"
            End If
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldPracticeGroupCd) And zExistInDB = 0 Then
                zMode = "INSERTwithKey"
            End If
            If Not razor.UtilSQLServer.IsKeySet(pRowData.colFldPracticeGroupCd) Then
                zMode = "INSERTnoKey"
            End If

            Select Case zMode
                Case "UPDATE"
                    If pRowData.IsDirty Then
                        Dim zUpdate As String = ""
                        Dim zSet As String = ""
                        Dim zWhere As String = ""
                        zUpdate = "UPDATE [adm].[tblAdminNoteTextBox] SET " 
                        If pRowData.IsDirty(rowTblAdminNoteTextBox.FieldIndex.colFldID) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldID] = @colFldID "
                        End If
                        If pRowData.IsDirty(rowTblAdminNoteTextBox.FieldIndex.colFldTextBoxLabel) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldTextBoxLabel] = @colFldTextBoxLabel "
                        End If
                        If pRowData.IsDirty(rowTblAdminNoteTextBox.FieldIndex.colFldEmptyMessage) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldEmptyMessage] = @colFldEmptyMessage "
                        End If
                        If pRowData.IsDirty(rowTblAdminNoteTextBox.FieldIndex.colFldMaxCharacters) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldMaxCharacters] = @colFldMaxCharacters "
                        End If
                        If pRowData.IsDirty(rowTblAdminNoteTextBox.FieldIndex.colFldSort) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldSort] = @colFldSort "
                        End If
                        zWhere = " WHERE [fldPracticeGroupCd] = @colFldPracticeGroupCd"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [adm].[tblAdminNoteTextBox] ([fldID], [fldPracticeGroupCd], [fldTextBoxLabel], [fldEmptyMessage], [fldMaxCharacters], [fldSort])" & _
                            " VALUES (@colFldID, @colFldPracticeGroupCd, @colFldTextBoxLabel, @colFldEmptyMessage, @colFldMaxCharacters, @colFldSort); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [adm].[tblAdminNoteTextBox] ([fldID], [fldTextBoxLabel], [fldEmptyMessage], [fldMaxCharacters], [fldSort])" & _
                            " VALUES (@colFldID, @colFldTextBoxLabel, @colFldEmptyMessage, @colFldMaxCharacters, @colFldSort); SELECT SCOPE_IDENTITY()"
                Case Else
            End Select

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

			'IF UPDATE, SET PK PARAMETER
            If zMode = "UPDATE" Then
                zCmd.Parameters.Add(New SQLParameter("@colFldPracticeGroupCd", pRowData.colFldPracticeGroupCd))
            End If

			'IF INSERTING, KEY HAS VALUE AND KEY IS NOT IDENTITY, SET PK PARAMETER
			If zMode = "INSERTwithKey" Then
                zCmd.Parameters.Add(New SQLParameter("@colFldPracticeGroupCd", pRowData.colFldPracticeGroupCd))
            End If

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblAdminNoteTextBox.FieldIndex.colFldID) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldID", IIf(pRowData.colFldID Is Nothing, DBNull.Value, pRowData.colFldID)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblAdminNoteTextBox.FieldIndex.colFldTextBoxLabel) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldTextBoxLabel", IIf(pRowData.colFldTextBoxLabel Is Nothing, DBNull.Value, pRowData.colFldTextBoxLabel)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblAdminNoteTextBox.FieldIndex.colFldEmptyMessage) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldEmptyMessage", IIf(pRowData.colFldEmptyMessage Is Nothing, DBNull.Value, pRowData.colFldEmptyMessage)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblAdminNoteTextBox.FieldIndex.colFldMaxCharacters) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldMaxCharacters", IIf(pRowData.colFldMaxCharacters Is Nothing, DBNull.Value, pRowData.colFldMaxCharacters)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblAdminNoteTextBox.FieldIndex.colFldSort) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldSort", IIf(pRowData.colFldSort Is Nothing, DBNull.Value, pRowData.colFldSort)))
                End If

            zCmd.Transaction=pTransaction
            If zMode = "INSERTnoKey" Then
                Dim zLastId As Long = 0
                zLastId = razor.UtilSQLServer.ExecuteNonQueryRowId(zCmd)

                pRowData.colFldPracticeGroupCd = zLastId
            Else
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)
            End If

            pRowData.SetIsDirty(False)
            pRowData.RaiseSavedEvent(pSavedEventUserState)

		End If

        End Sub

        Public Shared Function LoadByPrimaryKey(pcolFldPracticeGroupCd As String) As rowTblAdminNoteTextBox
            Return LoadByPrimaryKey(pcolFldPracticeGroupCd, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldPracticeGroupCd As String, pLoadEventUserState As Object) As rowTblAdminNoteTextBox
            Return LoadByPrimaryKey(pcolFldPracticeGroupCd, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldPracticeGroupCd As String, pTransaction As SqlClient.SqlTransaction) As rowTblAdminNoteTextBox
            Return LoadByPrimaryKey(pcolFldPracticeGroupCd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldPracticeGroupCd As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblAdminNoteTextBox
            Dim zReturn As New rowTblAdminNoteTextBox
            Dim zSQL As String = "SELECT * FROM [adm].[tblAdminNoteTextBox] WHERE [fldPracticeGroupCd] = @colFldPracticeGroupCd"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldPracticeGroupCd", pcolFldPracticeGroupCd))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblAdminNoteTextBox) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK__tblAdmin__36326BC346FFC601(pcolFldPracticeGroupCd As String) As List(Of rowTblAdminNoteTextBox)
            Return LoadByIDX_PK__tblAdmin__36326BC346FFC601(pcolFldPracticeGroupCd, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblAdmin__36326BC346FFC601(pcolFldPracticeGroupCd As String, pLoadEventUserState As Object) As List(Of rowTblAdminNoteTextBox)
            Return LoadByIDX_PK__tblAdmin__36326BC346FFC601(pcolFldPracticeGroupCd, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblAdmin__36326BC346FFC601(pcolFldPracticeGroupCd As String, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblAdminNoteTextBox)
            Return LoadByIDX_PK__tblAdmin__36326BC346FFC601(pcolFldPracticeGroupCd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblAdmin__36326BC346FFC601(pcolFldPracticeGroupCd As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblAdminNoteTextBox)
            Dim zReturn As New List(Of rowTblAdminNoteTextBox)
            Dim zSQL As String = "SELECT * FROM [adm].[tblAdminNoteTextBox] WHERE [fldPracticeGroupCd] = @colFldPracticeGroupCd"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldPracticeGroupCd", pcolFldPracticeGroupCd))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblAdminNoteTextBox)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblAdminNoteTextBox)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblAdminNoteTextBox)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblAdminNoteTextBox)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblAdminNoteTextBox)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblAdminNoteTextBox)
            Dim zReturn As New List(Of rowTblAdminNoteTextBox)
            Dim zSQL As String = "SELECT * FROM [adm].[tblAdminNoteTextBox]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblAdminNoteTextBox)

			Try
	            Dim zReturn As New List(Of rowTblAdminNoteTextBox)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblAdminNoteTextBox

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblAdminNoteTextBox		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblAdminNoteTextBox)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldID")) Then pObject.colFldID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldPracticeGroupCd")) Then pObject.colFldPracticeGroupCd = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldPracticeGroupCd")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldTextBoxLabel")) Then pObject.colFldTextBoxLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldTextBoxLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldEmptyMessage")) Then pObject.colFldEmptyMessage = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldEmptyMessage")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldMaxCharacters")) Then pObject.colFldMaxCharacters = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldMaxCharacters")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSort")) Then pObject.colFldSort = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldSort")
			pObject.SetIsDirty(False)
			Return pObject
		End	 Function

    #Region "Reflection Based Load Functions"

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldPracticeGroupCd As String) As T
            Return LoadByPrimaryKey(Of T)(pcolFldPracticeGroupCd, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldPracticeGroupCd As String, pLoadEventUserState As Object) As T
            Return LoadByPrimaryKey(Of T)(pcolFldPracticeGroupCd, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldPracticeGroupCd As String, pTransaction As SqlClient.SqlTransaction) As T
            Return LoadByPrimaryKey(Of T)(pcolFldPracticeGroupCd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldPracticeGroupCd As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As T

            Dim zReturn As Object = Activator.CreateInstance(Of T)()
            If Not TypeOf zReturn Is rowTblAdminNoteTextBox Then Throw New ArgumentException("Generic type is not type of rowTblAdminNoteTextBox.","T")

            Dim zSQL As String = "SELECT * FROM [adm].[tblAdminNoteTextBox] WHERE [fldPracticeGroupCd] = @colFldPracticeGroupCd"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldPracticeGroupCd", pcolFldPracticeGroupCd))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of T) = ReadData(Of T)(zCmd, pLoadEventUserState)
            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

        End Function

        Public Shared Function LoadByIDX_PK__tblAdmin__36326BC346FFC601(Of T)(pcolFldPracticeGroupCd As String) As List(Of T)
            Return LoadByIDX_PK__tblAdmin__36326BC346FFC601(Of T)(pcolFldPracticeGroupCd, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblAdmin__36326BC346FFC601(Of T)(pcolFldPracticeGroupCd As String, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK__tblAdmin__36326BC346FFC601(Of T)(pcolFldPracticeGroupCd, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblAdmin__36326BC346FFC601(Of T)(pcolFldPracticeGroupCd As String, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK__tblAdmin__36326BC346FFC601(Of T)(pcolFldPracticeGroupCd, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK__tblAdmin__36326BC346FFC601(Of T)(pcolFldPracticeGroupCd As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [adm].[tblAdminNoteTextBox] WHERE [fldPracticeGroupCd] = @colFldPracticeGroupCd"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldPracticeGroupCd", pcolFldPracticeGroupCd))

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
            Dim zSQL As String = "SELECT * FROM [adm].[tblAdminNoteTextBox]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class

    Partial Public Class rowTblAdminNoteTextBox
        Implements IrowTblAdminNoteTextBox

        Public Event Loaded(pUserState As Object) Implements IrowTblAdminNoteTextBox.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblAdminNoteTextBox.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblAdminNoteTextBox.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblAdminNoteTextBox.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblAdminNoteTextBox.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblAdminNoteTextBox.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldID() As Nullable(Of Integer) Implements IrowTblAdminNoteTextBox.colFldID
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

        Public Property colFldPracticeGroupCd() As String Implements IrowTblAdminNoteTextBox.colFldPracticeGroupCd
            Get
                Return m_colFldPracticeGroupCd
            End Get
            Set
                If Not Same(m_colFldPracticeGroupCd, Value) Then
                    m_colFldPracticeGroupCd = Value
                    m_IsDirty(FieldIndex.colFldPracticeGroupCd) = True
                End If
            End Set
        End Property
        Private m_colFldPracticeGroupCd As String

        Public Property colFldTextBoxLabel() As String Implements IrowTblAdminNoteTextBox.colFldTextBoxLabel
            Get
                Return m_colFldTextBoxLabel
            End Get
            Set
                If Not Same(m_colFldTextBoxLabel, Value) Then
                    m_colFldTextBoxLabel = Value
                    m_IsDirty(FieldIndex.colFldTextBoxLabel) = True
                End If
            End Set
        End Property
        Private m_colFldTextBoxLabel As String

        Public Property colFldEmptyMessage() As String Implements IrowTblAdminNoteTextBox.colFldEmptyMessage
            Get
                Return m_colFldEmptyMessage
            End Get
            Set
                If Not Same(m_colFldEmptyMessage, Value) Then
                    m_colFldEmptyMessage = Value
                    m_IsDirty(FieldIndex.colFldEmptyMessage) = True
                End If
            End Set
        End Property
        Private m_colFldEmptyMessage As String

        Public Property colFldMaxCharacters() As Nullable(Of Integer) Implements IrowTblAdminNoteTextBox.colFldMaxCharacters
            Get
                Return m_colFldMaxCharacters
            End Get
            Set
                If Not Same(m_colFldMaxCharacters, Value) Then
                    m_colFldMaxCharacters = Value
                    m_IsDirty(FieldIndex.colFldMaxCharacters) = True
                End If
            End Set
        End Property
        Private m_colFldMaxCharacters As Nullable(Of Integer)

        Public Property colFldSort() As Nullable(Of Integer) Implements IrowTblAdminNoteTextBox.colFldSort
            Get
                Return m_colFldSort
            End Get
            Set
                If Not Same(m_colFldSort, Value) Then
                    m_colFldSort = Value
                    m_IsDirty(FieldIndex.colFldSort) = True
                End If
            End Set
        End Property
        Private m_colFldSort As Nullable(Of Integer)


        Public Function IsDirty(pIndex As rowTblAdminNoteTextBox.FieldIndex) As Boolean Implements IrowTblAdminNoteTextBox.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblAdminNoteTextBox.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblAdminNoteTextBox.SetIsDirty
            m_IsDirty(FieldIndex.colFldID) = pDirty
            m_IsDirty(FieldIndex.colFldPracticeGroupCd) = pDirty
            m_IsDirty(FieldIndex.colFldTextBoxLabel) = pDirty
            m_IsDirty(FieldIndex.colFldEmptyMessage) = pDirty
            m_IsDirty(FieldIndex.colFldMaxCharacters) = pDirty
            m_IsDirty(FieldIndex.colFldSort) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblAdminNoteTextBox) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblAdminNoteTextBox
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldID  = 1
            colFldPracticeGroupCd 
            colFldTextBoxLabel 
            colFldEmptyMessage 
            colFldMaxCharacters 
            colFldSort 
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

    Public Interface IrowTblAdminNoteTextBox
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldID() As Nullable(Of Integer)
        Property colFldPracticeGroupCd() As String
        Property colFldTextBoxLabel() As String
        Property colFldEmptyMessage() As String
        Property colFldMaxCharacters() As Nullable(Of Integer)
        Property colFldSort() As Nullable(Of Integer)
        Function IsDirty(pIndex As rowTblAdminNoteTextBox.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

