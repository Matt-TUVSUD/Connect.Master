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
    Partial Public Class TblAdminNote

        Public Shared Sub Delete(ByRef pRowData As IrowTblAdminNote)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblAdminNote, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblAdminNote, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblAdminNote, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldID) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [adm].[tblAdminNote] " & _
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
        Dim zObj As rowTblAdminNote = LoadByPrimaryKey(pcolFldID, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblAdminNote)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblAdminNote, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblAdminNote, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldID) Then

                zSQL = "SELECT COUNT(*) from [adm].[tblAdminNote] WHERE [fldID] = @colFldID"

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
                        zUpdate = "UPDATE [adm].[tblAdminNote] SET " 
                        If pRowData.IsDirty(rowTblAdminNote.FieldIndex.colFldFileNo) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldFileNo] = @colFldFileNo "
                        End If
                        If pRowData.IsDirty(rowTblAdminNote.FieldIndex.colFldInspectionID) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldInspectionID] = @colFldInspectionID "
                        End If
                        If pRowData.IsDirty(rowTblAdminNote.FieldIndex.colFldPracticeGroupCd) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldPracticeGroupCd] = @colFldPracticeGroupCd "
                        End If
                        If pRowData.IsDirty(rowTblAdminNote.FieldIndex.colFldNoteTextBoxId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldNoteTextBoxId] = @colFldNoteTextBoxId "
                        End If
                        If pRowData.IsDirty(rowTblAdminNote.FieldIndex.colFldNote) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldNote] = @colFldNote "
                        End If
                        If pRowData.IsDirty(rowTblAdminNote.FieldIndex.colFldCreateBy) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldCreateBy] = @colFldCreateBy "
                        End If
                        If pRowData.IsDirty(rowTblAdminNote.FieldIndex.colFldCreateDateTime) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldCreateDateTime] = @colFldCreateDateTime "
                        End If
                        If pRowData.IsDirty(rowTblAdminNote.FieldIndex.colFldUpdateBy) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldUpdateBy] = @colFldUpdateBy "
                        End If
                        If pRowData.IsDirty(rowTblAdminNote.FieldIndex.colFldUpdateDateTime) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldUpdateDateTime] = @colFldUpdateDateTime "
                        End If
                        If pRowData.IsDirty(rowTblAdminNote.FieldIndex.colFldExcludeInXL) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldExcludeInXL] = @colFldExcludeInXL "
                        End If
                        zWhere = " WHERE [fldID] = @colFldID"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [adm].[tblAdminNote] ([fldFileNo], [fldInspectionID], [fldPracticeGroupCd], [fldNoteTextBoxId], [fldNote], [fldCreateBy], [fldCreateDateTime], [fldUpdateBy], [fldUpdateDateTime], [fldExcludeInXL])" & _
                            " VALUES (@colFldFileNo, @colFldInspectionID, @colFldPracticeGroupCd, @colFldNoteTextBoxId, @colFldNote, @colFldCreateBy, @colFldCreateDateTime, @colFldUpdateBy, @colFldUpdateDateTime, @colFldExcludeInXL); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [adm].[tblAdminNote] ([fldFileNo], [fldInspectionID], [fldPracticeGroupCd], [fldNoteTextBoxId], [fldNote], [fldCreateBy], [fldCreateDateTime], [fldUpdateBy], [fldUpdateDateTime], [fldExcludeInXL])" & _
                            " VALUES (@colFldFileNo, @colFldInspectionID, @colFldPracticeGroupCd, @colFldNoteTextBoxId, @colFldNote, @colFldCreateBy, @colFldCreateDateTime, @colFldUpdateBy, @colFldUpdateDateTime, @colFldExcludeInXL); SELECT SCOPE_IDENTITY()"
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

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblAdminNote.FieldIndex.colFldFileNo) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldFileNo", IIf(pRowData.colFldFileNo Is Nothing, DBNull.Value, pRowData.colFldFileNo)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblAdminNote.FieldIndex.colFldInspectionID) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldInspectionID", IIf(pRowData.colFldInspectionID Is Nothing, DBNull.Value, pRowData.colFldInspectionID)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblAdminNote.FieldIndex.colFldPracticeGroupCd) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldPracticeGroupCd", IIf(pRowData.colFldPracticeGroupCd Is Nothing, DBNull.Value, pRowData.colFldPracticeGroupCd)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblAdminNote.FieldIndex.colFldNoteTextBoxId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldNoteTextBoxId", IIf(pRowData.colFldNoteTextBoxId Is Nothing, DBNull.Value, pRowData.colFldNoteTextBoxId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblAdminNote.FieldIndex.colFldNote) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldNote", IIf(pRowData.colFldNote Is Nothing, DBNull.Value, pRowData.colFldNote)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblAdminNote.FieldIndex.colFldCreateBy) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldCreateBy", IIf(pRowData.colFldCreateBy Is Nothing, DBNull.Value, pRowData.colFldCreateBy)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblAdminNote.FieldIndex.colFldCreateDateTime) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldCreateDateTime", IIf(pRowData.colFldCreateDateTime Is Nothing, DBNull.Value, pRowData.colFldCreateDateTime)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblAdminNote.FieldIndex.colFldUpdateBy) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldUpdateBy", IIf(pRowData.colFldUpdateBy Is Nothing, DBNull.Value, pRowData.colFldUpdateBy)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblAdminNote.FieldIndex.colFldUpdateDateTime) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldUpdateDateTime", IIf(pRowData.colFldUpdateDateTime Is Nothing, DBNull.Value, pRowData.colFldUpdateDateTime)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblAdminNote.FieldIndex.colFldExcludeInXL) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldExcludeInXL", IIf(pRowData.colFldExcludeInXL Is Nothing, DBNull.Value, pRowData.colFldExcludeInXL)))
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

        Public Shared Function LoadByPrimaryKey(pcolFldID As Integer) As rowTblAdminNote
            Return LoadByPrimaryKey(pcolFldID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldID As Integer, pLoadEventUserState As Object) As rowTblAdminNote
            Return LoadByPrimaryKey(pcolFldID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblAdminNote
            Return LoadByPrimaryKey(pcolFldID, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblAdminNote
            Dim zReturn As New rowTblAdminNote
            Dim zSQL As String = "SELECT * FROM [adm].[tblAdminNote] WHERE [fldID] = @colFldID"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldID", pcolFldID))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblAdminNote) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK__AdminNot__36326BC36252DABB(pcolFldID As Integer) As List(Of rowTblAdminNote)
            Return LoadByIDX_PK__AdminNot__36326BC36252DABB(pcolFldID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__AdminNot__36326BC36252DABB(pcolFldID As Integer, pLoadEventUserState As Object) As List(Of rowTblAdminNote)
            Return LoadByIDX_PK__AdminNot__36326BC36252DABB(pcolFldID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__AdminNot__36326BC36252DABB(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblAdminNote)
            Return LoadByIDX_PK__AdminNot__36326BC36252DABB(pcolFldID, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__AdminNot__36326BC36252DABB(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblAdminNote)
            Dim zReturn As New List(Of rowTblAdminNote)
            Dim zSQL As String = "SELECT * FROM [adm].[tblAdminNote] WHERE [fldID] = @colFldID"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldID", pcolFldID))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblAdminNote)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblAdminNote)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblAdminNote)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblAdminNote)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblAdminNote)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblAdminNote)
            Dim zReturn As New List(Of rowTblAdminNote)
            Dim zSQL As String = "SELECT * FROM [adm].[tblAdminNote]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblAdminNote)

			Try
	            Dim zReturn As New List(Of rowTblAdminNote)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblAdminNote

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblAdminNote		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblAdminNote)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldID")) Then pObject.colFldID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFileNo")) Then pObject.colFldFileNo = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldFileNo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldInspectionID")) Then pObject.colFldInspectionID = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldInspectionID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldPracticeGroupCd")) Then pObject.colFldPracticeGroupCd = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldPracticeGroupCd")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldNoteTextBoxId")) Then pObject.colFldNoteTextBoxId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldNoteTextBoxId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldNote")) Then pObject.colFldNote = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldNote")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldCreateBy")) Then pObject.colFldCreateBy = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldCreateBy")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldCreateDateTime")) Then pObject.colFldCreateDateTime = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "fldCreateDateTime")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldUpdateBy")) Then pObject.colFldUpdateBy = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldUpdateBy")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldUpdateDateTime")) Then pObject.colFldUpdateDateTime = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "fldUpdateDateTime")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldExcludeInXL")) Then pObject.colFldExcludeInXL = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldExcludeInXL")
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
            If Not TypeOf zReturn Is rowTblAdminNote Then Throw New ArgumentException("Generic type is not type of rowTblAdminNote.","T")

            Dim zSQL As String = "SELECT * FROM [adm].[tblAdminNote] WHERE [fldID] = @colFldID"
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

        Public Shared Function LoadByIDX_PK__AdminNot__36326BC36252DABB(Of T)(pcolFldID As Integer) As List(Of T)
            Return LoadByIDX_PK__AdminNot__36326BC36252DABB(Of T)(pcolFldID, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__AdminNot__36326BC36252DABB(Of T)(pcolFldID As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK__AdminNot__36326BC36252DABB(Of T)(pcolFldID, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__AdminNot__36326BC36252DABB(Of T)(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK__AdminNot__36326BC36252DABB(Of T)(pcolFldID, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK__AdminNot__36326BC36252DABB(Of T)(pcolFldID As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [adm].[tblAdminNote] WHERE [fldID] = @colFldID"
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
            Dim zSQL As String = "SELECT * FROM [adm].[tblAdminNote]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class

    Partial Public Class rowTblAdminNote
        Implements IrowTblAdminNote

        Public Event Loaded(pUserState As Object) Implements IrowTblAdminNote.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblAdminNote.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblAdminNote.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblAdminNote.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblAdminNote.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblAdminNote.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldID() As Nullable(Of Integer) Implements IrowTblAdminNote.colFldID
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

        Public Property colFldFileNo() As String Implements IrowTblAdminNote.colFldFileNo
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

        Public Property colFldInspectionID() As String Implements IrowTblAdminNote.colFldInspectionID
            Get
                Return m_colFldInspectionID
            End Get
            Set
                If Not Same(m_colFldInspectionID, Value) Then
                    m_colFldInspectionID = Value
                    m_IsDirty(FieldIndex.colFldInspectionID) = True
                End If
            End Set
        End Property
        Private m_colFldInspectionID As String

        Public Property colFldPracticeGroupCd() As String Implements IrowTblAdminNote.colFldPracticeGroupCd
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

        Public Property colFldNoteTextBoxId() As Nullable(Of Integer) Implements IrowTblAdminNote.colFldNoteTextBoxId
            Get
                Return m_colFldNoteTextBoxId
            End Get
            Set
                If Not Same(m_colFldNoteTextBoxId, Value) Then
                    m_colFldNoteTextBoxId = Value
                    m_IsDirty(FieldIndex.colFldNoteTextBoxId) = True
                End If
            End Set
        End Property
        Private m_colFldNoteTextBoxId As Nullable(Of Integer)

        Public Property colFldNote() As String Implements IrowTblAdminNote.colFldNote
            Get
                Return m_colFldNote
            End Get
            Set
                If Not Same(m_colFldNote, Value) Then
                    m_colFldNote = Value
                    m_IsDirty(FieldIndex.colFldNote) = True
                End If
            End Set
        End Property
        Private m_colFldNote As String

        Public Property colFldCreateBy() As String Implements IrowTblAdminNote.colFldCreateBy
            Get
                Return m_colFldCreateBy
            End Get
            Set
                If Not Same(m_colFldCreateBy, Value) Then
                    m_colFldCreateBy = Value
                    m_IsDirty(FieldIndex.colFldCreateBy) = True
                End If
            End Set
        End Property
        Private m_colFldCreateBy As String

        Public Property colFldCreateDateTime() As Nullable(Of DateTime) Implements IrowTblAdminNote.colFldCreateDateTime
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

        Public Property colFldUpdateBy() As String Implements IrowTblAdminNote.colFldUpdateBy
            Get
                Return m_colFldUpdateBy
            End Get
            Set
                If Not Same(m_colFldUpdateBy, Value) Then
                    m_colFldUpdateBy = Value
                    m_IsDirty(FieldIndex.colFldUpdateBy) = True
                End If
            End Set
        End Property
        Private m_colFldUpdateBy As String

        Public Property colFldUpdateDateTime() As Nullable(Of DateTime) Implements IrowTblAdminNote.colFldUpdateDateTime
            Get
                Return m_colFldUpdateDateTime
            End Get
            Set
                If Not Same(m_colFldUpdateDateTime, Value) Then
                    m_colFldUpdateDateTime = Value
                    m_IsDirty(FieldIndex.colFldUpdateDateTime) = True
                End If
            End Set
        End Property
        Private m_colFldUpdateDateTime As Nullable(Of DateTime)

        Public Property colFldExcludeInXL() As Nullable(Of Boolean) Implements IrowTblAdminNote.colFldExcludeInXL
            Get
                Return m_colFldExcludeInXL
            End Get
            Set
                If Not Same(m_colFldExcludeInXL, Value) Then
                    m_colFldExcludeInXL = Value
                    m_IsDirty(FieldIndex.colFldExcludeInXL) = True
                End If
            End Set
        End Property
        Private m_colFldExcludeInXL As Nullable(Of Boolean)


        Public Function IsDirty(pIndex As rowTblAdminNote.FieldIndex) As Boolean Implements IrowTblAdminNote.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblAdminNote.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblAdminNote.SetIsDirty
            m_IsDirty(FieldIndex.colFldID) = pDirty
            m_IsDirty(FieldIndex.colFldFileNo) = pDirty
            m_IsDirty(FieldIndex.colFldInspectionID) = pDirty
            m_IsDirty(FieldIndex.colFldPracticeGroupCd) = pDirty
            m_IsDirty(FieldIndex.colFldNoteTextBoxId) = pDirty
            m_IsDirty(FieldIndex.colFldNote) = pDirty
            m_IsDirty(FieldIndex.colFldCreateBy) = pDirty
            m_IsDirty(FieldIndex.colFldCreateDateTime) = pDirty
            m_IsDirty(FieldIndex.colFldUpdateBy) = pDirty
            m_IsDirty(FieldIndex.colFldUpdateDateTime) = pDirty
            m_IsDirty(FieldIndex.colFldExcludeInXL) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblAdminNote) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblAdminNote
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldID  = 1
            colFldFileNo 
            colFldInspectionID 
            colFldPracticeGroupCd 
            colFldNoteTextBoxId 
            colFldNote 
            colFldCreateBy 
            colFldCreateDateTime 
            colFldUpdateBy 
            colFldUpdateDateTime 
            colFldExcludeInXL 
        End Enum

        Private m_IsDirty(11) As Boolean

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

    Public Interface IrowTblAdminNote
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldID() As Nullable(Of Integer)
        Property colFldFileNo() As String
        Property colFldInspectionID() As String
        Property colFldPracticeGroupCd() As String
        Property colFldNoteTextBoxId() As Nullable(Of Integer)
        Property colFldNote() As String
        Property colFldCreateBy() As String
        Property colFldCreateDateTime() As Nullable(Of DateTime)
        Property colFldUpdateBy() As String
        Property colFldUpdateDateTime() As Nullable(Of DateTime)
        Property colFldExcludeInXL() As Nullable(Of Boolean)
        Function IsDirty(pIndex As rowTblAdminNote.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

