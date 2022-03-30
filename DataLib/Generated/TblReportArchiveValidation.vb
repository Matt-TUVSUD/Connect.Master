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
    Partial Public Class TblReportArchiveValidation

        Public Shared Sub Delete(ByRef pRowData As IrowTblReportArchiveValidation)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblReportArchiveValidation, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblReportArchiveValidation, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblReportArchiveValidation, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[ReportArchiveValidation] " & _
                        "WHERE [ID] = @colId"

                Dim zCmd As New SQLCommand
                zCmd.CommandText = zSQL
                zCmd.Parameters.Add(New SQLParameter("@colId", pRowData.colId))

                zCmd.Transaction=pTransaction
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)

                pRowData.RaiseDeletedEvent(pDeleteEventUserState)

            End If

        End Sub

        Public Shared Sub Delete(pcolId As Integer)
            Delete(pcolId, Nothing, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolId As Integer, pDeleteEventUserState As Object)
            Delete(pcolId, Nothing, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Delete(pcolId As Integer, ByRef pTransaction As SqlClient.SqlTransaction)
        Delete(pcolId, pTransaction, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolId As Integer, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
        Dim zObj As rowTblReportArchiveValidation = LoadByPrimaryKey(pcolId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblReportArchiveValidation)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblReportArchiveValidation, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblReportArchiveValidation, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[ReportArchiveValidation] WHERE [ID] = @colId"

                Dim zCmdDoesExist As New SQLCommand

                zCmdDoesExist.CommandText = zSQL

                zCmdDoesExist.Parameters.Add(new SQLParameter("@colId", pRowData.colId))

                'if zExistInDB > 0  then  PK exists in the DB
                zCmdDoesExist.Transaction = pTransaction
                zExistInDB = razor.UtilSQLServer.ExecuteScalar(zCmdDoesExist)
            End If

            If razor.UtilSQLServer.IsKeySet(pRowData.colId) And zExistInDB > 0 Then
                zMode = "UPDATE"
            End If
            If razor.UtilSQLServer.IsKeySet(pRowData.colId) And zExistInDB = 0 Then
                zMode = "INSERTwithKey"
            End If
            If Not razor.UtilSQLServer.IsKeySet(pRowData.colId) Then
                zMode = "INSERTnoKey"
            End If

            Select Case zMode
                Case "UPDATE"
                    If pRowData.IsDirty Then
                        Dim zUpdate As String = ""
                        Dim zSet As String = ""
                        Dim zWhere As String = ""
                        zUpdate = "UPDATE [dbo].[ReportArchiveValidation] SET " 
                        If pRowData.IsDirty(rowTblReportArchiveValidation.FieldIndex.colReportArchiveID) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ReportArchiveID] = @colReportArchiveID "
                        End If
                        If pRowData.IsDirty(rowTblReportArchiveValidation.FieldIndex.colFilePath) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [FilePath] = @colFilePath "
                        End If
                        If pRowData.IsDirty(rowTblReportArchiveValidation.FieldIndex.colReportType) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ReportType] = @colReportType "
                        End If
                        If pRowData.IsDirty(rowTblReportArchiveValidation.FieldIndex.colIsValid) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [IsValid] = @colIsValid "
                        End If
                        If pRowData.IsDirty(rowTblReportArchiveValidation.FieldIndex.colValidationDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [ValidationDate] = @colValidationDate "
                        End If
                        If pRowData.IsDirty(rowTblReportArchiveValidation.FieldIndex.colSuggestedFilePath) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [SuggestedFilePath] = @colSuggestedFilePath "
                        End If
                        If pRowData.IsDirty(rowTblReportArchiveValidation.FieldIndex.colSuggestedFilePathCount) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [SuggestedFilePathCount] = @colSuggestedFilePathCount "
                        End If
                        zWhere = " WHERE [ID] = @colId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[ReportArchiveValidation] ([ReportArchiveID], [FilePath], [ReportType], [IsValid], [ValidationDate], [SuggestedFilePath], [SuggestedFilePathCount])" & _
                            " VALUES (@colReportArchiveID, @colFilePath, @colReportType, @colIsValid, @colValidationDate, @colSuggestedFilePath, @colSuggestedFilePathCount); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[ReportArchiveValidation] ([ReportArchiveID], [FilePath], [ReportType], [IsValid], [ValidationDate], [SuggestedFilePath], [SuggestedFilePathCount])" & _
                            " VALUES (@colReportArchiveID, @colFilePath, @colReportType, @colIsValid, @colValidationDate, @colSuggestedFilePath, @colSuggestedFilePathCount); SELECT SCOPE_IDENTITY()"
                Case Else
            End Select

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

			'IF UPDATE, SET PK PARAMETER
            If zMode = "UPDATE" Then
                zCmd.Parameters.Add(New SQLParameter("@colId", pRowData.colId))
            End If

			'IF INSERTING, KEY HAS VALUE AND KEY IS NOT IDENTITY, SET PK PARAMETER
			If zMode = "INSERTwithKey" Then
            End If

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblReportArchiveValidation.FieldIndex.colReportArchiveID) Then
                    zCmd.Parameters.Add(New SqlParameter("@colReportArchiveID", IIf(pRowData.colReportArchiveID Is Nothing, DBNull.Value, pRowData.colReportArchiveID)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblReportArchiveValidation.FieldIndex.colFilePath) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFilePath", IIf(pRowData.colFilePath Is Nothing, DBNull.Value, pRowData.colFilePath)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblReportArchiveValidation.FieldIndex.colReportType) Then
                    zCmd.Parameters.Add(New SqlParameter("@colReportType", IIf(pRowData.colReportType Is Nothing, DBNull.Value, pRowData.colReportType)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblReportArchiveValidation.FieldIndex.colIsValid) Then
                    zCmd.Parameters.Add(New SqlParameter("@colIsValid", IIf(pRowData.colIsValid Is Nothing, DBNull.Value, pRowData.colIsValid)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblReportArchiveValidation.FieldIndex.colValidationDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colValidationDate", IIf(pRowData.colValidationDate Is Nothing, DBNull.Value, pRowData.colValidationDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblReportArchiveValidation.FieldIndex.colSuggestedFilePath) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSuggestedFilePath", IIf(pRowData.colSuggestedFilePath Is Nothing, DBNull.Value, pRowData.colSuggestedFilePath)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblReportArchiveValidation.FieldIndex.colSuggestedFilePathCount) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSuggestedFilePathCount", IIf(pRowData.colSuggestedFilePathCount Is Nothing, DBNull.Value, pRowData.colSuggestedFilePathCount)))
                End If

            zCmd.Transaction=pTransaction
            If zMode = "INSERTnoKey" Then
                Dim zLastId As Long = 0
                zLastId = razor.UtilSQLServer.ExecuteNonQueryRowId(zCmd)

                pRowData.colId = zLastId
            Else
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)
            End If

            pRowData.SetIsDirty(False)
            pRowData.RaiseSavedEvent(pSavedEventUserState)

		End If

        End Sub

        Public Shared Function LoadByPrimaryKey(pcolId As Integer) As rowTblReportArchiveValidation
            Return LoadByPrimaryKey(pcolId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolId As Integer, pLoadEventUserState As Object) As rowTblReportArchiveValidation
            Return LoadByPrimaryKey(pcolId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblReportArchiveValidation
            Return LoadByPrimaryKey(pcolId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblReportArchiveValidation
            Dim zReturn As New rowTblReportArchiveValidation
            Dim zSQL As String = "SELECT * FROM [dbo].[ReportArchiveValidation] WHERE [ID] = @colId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colId", pcolId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblReportArchiveValidation) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK__ReportAr__3214EC273BA321EE(pcolId As Integer) As List(Of rowTblReportArchiveValidation)
            Return LoadByIDX_PK__ReportAr__3214EC273BA321EE(pcolId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__ReportAr__3214EC273BA321EE(pcolId As Integer, pLoadEventUserState As Object) As List(Of rowTblReportArchiveValidation)
            Return LoadByIDX_PK__ReportAr__3214EC273BA321EE(pcolId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__ReportAr__3214EC273BA321EE(pcolId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblReportArchiveValidation)
            Return LoadByIDX_PK__ReportAr__3214EC273BA321EE(pcolId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__ReportAr__3214EC273BA321EE(pcolId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblReportArchiveValidation)
            Dim zReturn As New List(Of rowTblReportArchiveValidation)
            Dim zSQL As String = "SELECT * FROM [dbo].[ReportArchiveValidation] WHERE [ID] = @colId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colId", pcolId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblReportArchiveValidation)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblReportArchiveValidation)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblReportArchiveValidation)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblReportArchiveValidation)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblReportArchiveValidation)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblReportArchiveValidation)
            Dim zReturn As New List(Of rowTblReportArchiveValidation)
            Dim zSQL As String = "SELECT * FROM [dbo].[ReportArchiveValidation]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblReportArchiveValidation)

			Try
	            Dim zReturn As New List(Of rowTblReportArchiveValidation)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblReportArchiveValidation

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblReportArchiveValidation		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblReportArchiveValidation)
			If Not pReader.IsDBNull(pReader.GetOrdinal("ID")) Then pObject.colId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "ID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ReportArchiveID")) Then pObject.colReportArchiveID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "ReportArchiveID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FilePath")) Then pObject.colFilePath = UtilSQLServer.SafeReader.SafeReadString(pReader, "FilePath")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ReportType")) Then pObject.colReportType = UtilSQLServer.SafeReader.SafeReadString(pReader, "ReportType")
			If Not pReader.IsDBNull(pReader.GetOrdinal("IsValid")) Then pObject.colIsValid = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "IsValid")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ValidationDate")) Then pObject.colValidationDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "ValidationDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SuggestedFilePath")) Then pObject.colSuggestedFilePath = UtilSQLServer.SafeReader.SafeReadString(pReader, "SuggestedFilePath")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SuggestedFilePathCount")) Then pObject.colSuggestedFilePathCount = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "SuggestedFilePathCount")
			pObject.SetIsDirty(False)
			Return pObject
		End	 Function

    #Region "Reflection Based Load Functions"

        Public Shared Function LoadByPrimaryKey(Of T)(pcolId As Integer) As T
            Return LoadByPrimaryKey(Of T)(pcolId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolId As Integer, pLoadEventUserState As Object) As T
            Return LoadByPrimaryKey(Of T)(pcolId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolId As Integer, pTransaction As SqlClient.SqlTransaction) As T
            Return LoadByPrimaryKey(Of T)(pcolId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As T

            Dim zReturn As Object = Activator.CreateInstance(Of T)()
            If Not TypeOf zReturn Is rowTblReportArchiveValidation Then Throw New ArgumentException("Generic type is not type of rowTblReportArchiveValidation.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[ReportArchiveValidation] WHERE [ID] = @colId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colId", pcolId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of T) = ReadData(Of T)(zCmd, pLoadEventUserState)
            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

        End Function

        Public Shared Function LoadByIDX_PK__ReportAr__3214EC273BA321EE(Of T)(pcolId As Integer) As List(Of T)
            Return LoadByIDX_PK__ReportAr__3214EC273BA321EE(Of T)(pcolId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__ReportAr__3214EC273BA321EE(Of T)(pcolId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK__ReportAr__3214EC273BA321EE(Of T)(pcolId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__ReportAr__3214EC273BA321EE(Of T)(pcolId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK__ReportAr__3214EC273BA321EE(Of T)(pcolId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK__ReportAr__3214EC273BA321EE(Of T)(pcolId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[ReportArchiveValidation] WHERE [ID] = @colId"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colId", pcolId))

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
            Dim zSQL As String = "SELECT * FROM [dbo].[ReportArchiveValidation]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblReportArchiveValidation
        Implements IrowTblReportArchiveValidation

        Public Event Loaded(pUserState As Object) Implements IrowTblReportArchiveValidation.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblReportArchiveValidation.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblReportArchiveValidation.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblReportArchiveValidation.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblReportArchiveValidation.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblReportArchiveValidation.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colId() As Nullable(Of Integer) Implements IrowTblReportArchiveValidation.colId
            Get
                Return m_colId
            End Get
            Set
                If Not Same(m_colId, Value) Then
                    m_colId = Value
                    m_IsDirty(FieldIndex.colId) = True
                End If
            End Set
        End Property
        Private m_colId As Nullable(Of Integer)

        Public Property colReportArchiveID() As Nullable(Of Integer) Implements IrowTblReportArchiveValidation.colReportArchiveID
            Get
                Return m_colReportArchiveID
            End Get
            Set
                If Not Same(m_colReportArchiveID, Value) Then
                    m_colReportArchiveID = Value
                    m_IsDirty(FieldIndex.colReportArchiveID) = True
                End If
            End Set
        End Property
        Private m_colReportArchiveID As Nullable(Of Integer)

        Public Property colFilePath() As String Implements IrowTblReportArchiveValidation.colFilePath
            Get
                Return m_colFilePath
            End Get
            Set
                If Not Same(m_colFilePath, Value) Then
                    m_colFilePath = Value
                    m_IsDirty(FieldIndex.colFilePath) = True
                End If
            End Set
        End Property
        Private m_colFilePath As String

        Public Property colReportType() As String Implements IrowTblReportArchiveValidation.colReportType
            Get
                Return m_colReportType
            End Get
            Set
                If Not Same(m_colReportType, Value) Then
                    m_colReportType = Value
                    m_IsDirty(FieldIndex.colReportType) = True
                End If
            End Set
        End Property
        Private m_colReportType As String

        Public Property colIsValid() As Nullable(Of Boolean) Implements IrowTblReportArchiveValidation.colIsValid
            Get
                Return m_colIsValid
            End Get
            Set
                If Not Same(m_colIsValid, Value) Then
                    m_colIsValid = Value
                    m_IsDirty(FieldIndex.colIsValid) = True
                End If
            End Set
        End Property
        Private m_colIsValid As Nullable(Of Boolean)

        Public Property colValidationDate() As Nullable(Of DateTime) Implements IrowTblReportArchiveValidation.colValidationDate
            Get
                Return m_colValidationDate
            End Get
            Set
                If Not Same(m_colValidationDate, Value) Then
                    m_colValidationDate = Value
                    m_IsDirty(FieldIndex.colValidationDate) = True
                End If
            End Set
        End Property
        Private m_colValidationDate As Nullable(Of DateTime)

        Public Property colSuggestedFilePath() As String Implements IrowTblReportArchiveValidation.colSuggestedFilePath
            Get
                Return m_colSuggestedFilePath
            End Get
            Set
                If Not Same(m_colSuggestedFilePath, Value) Then
                    m_colSuggestedFilePath = Value
                    m_IsDirty(FieldIndex.colSuggestedFilePath) = True
                End If
            End Set
        End Property
        Private m_colSuggestedFilePath As String

        Public Property colSuggestedFilePathCount() As Nullable(Of Integer) Implements IrowTblReportArchiveValidation.colSuggestedFilePathCount
            Get
                Return m_colSuggestedFilePathCount
            End Get
            Set
                If Not Same(m_colSuggestedFilePathCount, Value) Then
                    m_colSuggestedFilePathCount = Value
                    m_IsDirty(FieldIndex.colSuggestedFilePathCount) = True
                End If
            End Set
        End Property
        Private m_colSuggestedFilePathCount As Nullable(Of Integer)


        Public Function IsDirty(pIndex As rowTblReportArchiveValidation.FieldIndex) As Boolean Implements IrowTblReportArchiveValidation.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblReportArchiveValidation.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblReportArchiveValidation.SetIsDirty
            m_IsDirty(FieldIndex.colId) = pDirty
            m_IsDirty(FieldIndex.colReportArchiveID) = pDirty
            m_IsDirty(FieldIndex.colFilePath) = pDirty
            m_IsDirty(FieldIndex.colReportType) = pDirty
            m_IsDirty(FieldIndex.colIsValid) = pDirty
            m_IsDirty(FieldIndex.colValidationDate) = pDirty
            m_IsDirty(FieldIndex.colSuggestedFilePath) = pDirty
            m_IsDirty(FieldIndex.colSuggestedFilePathCount) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblReportArchiveValidation) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblReportArchiveValidation
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colId  = 1
            colReportArchiveID 
            colFilePath 
            colReportType 
            colIsValid 
            colValidationDate 
            colSuggestedFilePath 
            colSuggestedFilePathCount 
        End Enum

        Private m_IsDirty(8) As Boolean

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

    Public Interface IrowTblReportArchiveValidation
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colId() As Nullable(Of Integer)
        Property colReportArchiveID() As Nullable(Of Integer)
        Property colFilePath() As String
        Property colReportType() As String
        Property colIsValid() As Nullable(Of Boolean)
        Property colValidationDate() As Nullable(Of DateTime)
        Property colSuggestedFilePath() As String
        Property colSuggestedFilePathCount() As Nullable(Of Integer)
        Function IsDirty(pIndex As rowTblReportArchiveValidation.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

