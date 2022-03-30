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
    Partial Public Class TblMetaReport

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaReport)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaReport, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaReport, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaReport, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[tblMetaReport] " & _
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
        Dim zObj As rowTblMetaReport = LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblMetaReport)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaReport, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaReport, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[tblMetaReport] WHERE [fldId] = @colFldId"

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
                        zUpdate = "UPDATE [dbo].[tblMetaReport] SET " 
                        If pRowData.IsDirty(rowTblMetaReport.FieldIndex.colFldName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldName] = @colFldName "
                        End If
                        If pRowData.IsDirty(rowTblMetaReport.FieldIndex.colFldFileName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldFileName] = @colFldFileName "
                        End If
                        If pRowData.IsDirty(rowTblMetaReport.FieldIndex.colFldVendorId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldVendorId] = @colFldVendorId "
                        End If
                        If pRowData.IsDirty(rowTblMetaReport.FieldIndex.colFldSourceId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldSourceId] = @colFldSourceId "
                        End If
                        If pRowData.IsDirty(rowTblMetaReport.FieldIndex.colFldTypeName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldTypeName] = @colFldTypeName "
                        End If
                        If pRowData.IsDirty(rowTblMetaReport.FieldIndex.colFldMetaPracticeId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldMetaPracticeId] = @colFldMetaPracticeId "
                        End If
                        If pRowData.IsDirty(rowTblMetaReport.FieldIndex.colFldOldRptCode) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldOldRptCode] = @colFldOldRptCode "
                        End If
                        If pRowData.IsDirty(rowTblMetaReport.FieldIndex.colFldComment) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldComment] = @colFldComment "
                        End If
                        zWhere = " WHERE [fldId] = @colFldId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaReport] ([fldName], [fldFileName], [fldVendorId], [fldSourceId], [fldTypeName], [fldMetaPracticeId], [fldOldRptCode], [fldComment])" & _
                            " VALUES (@colFldName, @colFldFileName, @colFldVendorId, @colFldSourceId, @colFldTypeName, @colFldMetaPracticeId, @colFldOldRptCode, @colFldComment); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaReport] ([fldName], [fldFileName], [fldVendorId], [fldSourceId], [fldTypeName], [fldMetaPracticeId], [fldOldRptCode], [fldComment])" & _
                            " VALUES (@colFldName, @colFldFileName, @colFldVendorId, @colFldSourceId, @colFldTypeName, @colFldMetaPracticeId, @colFldOldRptCode, @colFldComment); SELECT SCOPE_IDENTITY()"
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

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaReport.FieldIndex.colFldName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldName", IIf(pRowData.colFldName Is Nothing, DBNull.Value, pRowData.colFldName)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaReport.FieldIndex.colFldFileName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldFileName", IIf(pRowData.colFldFileName Is Nothing, DBNull.Value, pRowData.colFldFileName)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaReport.FieldIndex.colFldVendorId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldVendorId", IIf(pRowData.colFldVendorId Is Nothing, DBNull.Value, pRowData.colFldVendorId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaReport.FieldIndex.colFldSourceId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldSourceId", IIf(pRowData.colFldSourceId Is Nothing, DBNull.Value, pRowData.colFldSourceId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaReport.FieldIndex.colFldTypeName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldTypeName", IIf(pRowData.colFldTypeName Is Nothing, DBNull.Value, pRowData.colFldTypeName)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaReport.FieldIndex.colFldMetaPracticeId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldMetaPracticeId", IIf(pRowData.colFldMetaPracticeId Is Nothing, DBNull.Value, pRowData.colFldMetaPracticeId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaReport.FieldIndex.colFldOldRptCode) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldOldRptCode", IIf(pRowData.colFldOldRptCode Is Nothing, DBNull.Value, pRowData.colFldOldRptCode)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaReport.FieldIndex.colFldComment) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldComment", IIf(pRowData.colFldComment Is Nothing, DBNull.Value, pRowData.colFldComment)))
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

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer) As rowTblMetaReport
            Return LoadByPrimaryKey(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pLoadEventUserState As Object) As rowTblMetaReport
            Return LoadByPrimaryKey(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblMetaReport
            Return LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblMetaReport
            Dim zReturn As New rowTblMetaReport
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaReport] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblMetaReport) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK__tblMetaR__36326BE32D942E62(pcolFldId As Integer) As List(Of rowTblMetaReport)
            Return LoadByIDX_PK__tblMetaR__36326BE32D942E62(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaR__36326BE32D942E62(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of rowTblMetaReport)
            Return LoadByIDX_PK__tblMetaR__36326BE32D942E62(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaR__36326BE32D942E62(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaReport)
            Return LoadByIDX_PK__tblMetaR__36326BE32D942E62(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaR__36326BE32D942E62(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaReport)
            Dim zReturn As New List(Of rowTblMetaReport)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaReport] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblMetaReport)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblMetaReport)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblMetaReport)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaReport)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaReport)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaReport)
            Dim zReturn As New List(Of rowTblMetaReport)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaReport]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblMetaReport)

			Try
	            Dim zReturn As New List(Of rowTblMetaReport)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblMetaReport

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblMetaReport		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblMetaReport)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldId")) Then pObject.colFldId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldName")) Then pObject.colFldName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFileName")) Then pObject.colFldFileName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldFileName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldVendorId")) Then pObject.colFldVendorId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldVendorId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSourceId")) Then pObject.colFldSourceId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldSourceId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldTypeName")) Then pObject.colFldTypeName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldTypeName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldMetaPracticeId")) Then pObject.colFldMetaPracticeId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldMetaPracticeId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldOldRptCode")) Then pObject.colFldOldRptCode = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldOldRptCode")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldComment")) Then pObject.colFldComment = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldComment")
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
            If Not TypeOf zReturn Is rowTblMetaReport Then Throw New ArgumentException("Generic type is not type of rowTblMetaReport.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaReport] WHERE [fldId] = @colFldId"
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

        Public Shared Function LoadByIDX_PK__tblMetaR__36326BE32D942E62(Of T)(pcolFldId As Integer) As List(Of T)
            Return LoadByIDX_PK__tblMetaR__36326BE32D942E62(Of T)(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaR__36326BE32D942E62(Of T)(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK__tblMetaR__36326BE32D942E62(Of T)(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaR__36326BE32D942E62(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK__tblMetaR__36326BE32D942E62(Of T)(pcolFldId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK__tblMetaR__36326BE32D942E62(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaReport] WHERE [fldId] = @colFldId"
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
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaReport]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblMetaReport
        Implements IrowTblMetaReport

        Public Event Loaded(pUserState As Object) Implements IrowTblMetaReport.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblMetaReport.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblMetaReport.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblMetaReport.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblMetaReport.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblMetaReport.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldId() As Nullable(Of Integer) Implements IrowTblMetaReport.colFldId
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

        Public Property colFldName() As String Implements IrowTblMetaReport.colFldName
            Get
                Return m_colFldName
            End Get
            Set
                If Not Same(m_colFldName, Value) Then
                    m_colFldName = Value
                    m_IsDirty(FieldIndex.colFldName) = True
                End If
            End Set
        End Property
        Private m_colFldName As String

        Public Property colFldFileName() As String Implements IrowTblMetaReport.colFldFileName
            Get
                Return m_colFldFileName
            End Get
            Set
                If Not Same(m_colFldFileName, Value) Then
                    m_colFldFileName = Value
                    m_IsDirty(FieldIndex.colFldFileName) = True
                End If
            End Set
        End Property
        Private m_colFldFileName As String

        Public Property colFldVendorId() As Nullable(Of Integer) Implements IrowTblMetaReport.colFldVendorId
            Get
                Return m_colFldVendorId
            End Get
            Set
                If Not Same(m_colFldVendorId, Value) Then
                    m_colFldVendorId = Value
                    m_IsDirty(FieldIndex.colFldVendorId) = True
                End If
            End Set
        End Property
        Private m_colFldVendorId As Nullable(Of Integer)

        Public Property colFldSourceId() As Nullable(Of Integer) Implements IrowTblMetaReport.colFldSourceId
            Get
                Return m_colFldSourceId
            End Get
            Set
                If Not Same(m_colFldSourceId, Value) Then
                    m_colFldSourceId = Value
                    m_IsDirty(FieldIndex.colFldSourceId) = True
                End If
            End Set
        End Property
        Private m_colFldSourceId As Nullable(Of Integer)

        Public Property colFldTypeName() As String Implements IrowTblMetaReport.colFldTypeName
            Get
                Return m_colFldTypeName
            End Get
            Set
                If Not Same(m_colFldTypeName, Value) Then
                    m_colFldTypeName = Value
                    m_IsDirty(FieldIndex.colFldTypeName) = True
                End If
            End Set
        End Property
        Private m_colFldTypeName As String

        Public Property colFldMetaPracticeId() As Nullable(Of Integer) Implements IrowTblMetaReport.colFldMetaPracticeId
            Get
                Return m_colFldMetaPracticeId
            End Get
            Set
                If Not Same(m_colFldMetaPracticeId, Value) Then
                    m_colFldMetaPracticeId = Value
                    m_IsDirty(FieldIndex.colFldMetaPracticeId) = True
                End If
            End Set
        End Property
        Private m_colFldMetaPracticeId As Nullable(Of Integer)

        Public Property colFldOldRptCode() As String Implements IrowTblMetaReport.colFldOldRptCode
            Get
                Return m_colFldOldRptCode
            End Get
            Set
                If Not Same(m_colFldOldRptCode, Value) Then
                    m_colFldOldRptCode = Value
                    m_IsDirty(FieldIndex.colFldOldRptCode) = True
                End If
            End Set
        End Property
        Private m_colFldOldRptCode As String

        Public Property colFldComment() As String Implements IrowTblMetaReport.colFldComment
            Get
                Return m_colFldComment
            End Get
            Set
                If Not Same(m_colFldComment, Value) Then
                    m_colFldComment = Value
                    m_IsDirty(FieldIndex.colFldComment) = True
                End If
            End Set
        End Property
        Private m_colFldComment As String


        Public Function IsDirty(pIndex As rowTblMetaReport.FieldIndex) As Boolean Implements IrowTblMetaReport.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblMetaReport.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblMetaReport.SetIsDirty
            m_IsDirty(FieldIndex.colFldId) = pDirty
            m_IsDirty(FieldIndex.colFldName) = pDirty
            m_IsDirty(FieldIndex.colFldFileName) = pDirty
            m_IsDirty(FieldIndex.colFldVendorId) = pDirty
            m_IsDirty(FieldIndex.colFldSourceId) = pDirty
            m_IsDirty(FieldIndex.colFldTypeName) = pDirty
            m_IsDirty(FieldIndex.colFldMetaPracticeId) = pDirty
            m_IsDirty(FieldIndex.colFldOldRptCode) = pDirty
            m_IsDirty(FieldIndex.colFldComment) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblMetaReport) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblMetaReport
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldId  = 1
            colFldName 
            colFldFileName 
            colFldVendorId 
            colFldSourceId 
            colFldTypeName 
            colFldMetaPracticeId 
            colFldOldRptCode 
            colFldComment 
        End Enum

        Private m_IsDirty(9) As Boolean

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

    Public Interface IrowTblMetaReport
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldId() As Nullable(Of Integer)
        Property colFldName() As String
        Property colFldFileName() As String
        Property colFldVendorId() As Nullable(Of Integer)
        Property colFldSourceId() As Nullable(Of Integer)
        Property colFldTypeName() As String
        Property colFldMetaPracticeId() As Nullable(Of Integer)
        Property colFldOldRptCode() As String
        Property colFldComment() As String
        Function IsDirty(pIndex As rowTblMetaReport.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

