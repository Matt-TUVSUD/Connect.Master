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
    Partial Public Class TblMetaChartSeriesDetail

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaChartSeriesDetail)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaChartSeriesDetail, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaChartSeriesDetail, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaChartSeriesDetail, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[tblMetaChartSeriesDetail] " & _
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
        Dim zObj As rowTblMetaChartSeriesDetail = LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblMetaChartSeriesDetail)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaChartSeriesDetail, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaChartSeriesDetail, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[tblMetaChartSeriesDetail] WHERE [fldId] = @colFldId"

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
                        zUpdate = "UPDATE [dbo].[tblMetaChartSeriesDetail] SET " 
                        If pRowData.IsDirty(rowTblMetaChartSeriesDetail.FieldIndex.colFldMetaChartSeriesId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldMetaChartSeriesId] = @colFldMetaChartSeriesId "
                        End If
                        If pRowData.IsDirty(rowTblMetaChartSeriesDetail.FieldIndex.colFldMetaChartDrillDownId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldMetaChartDrillDownId] = @colFldMetaChartDrillDownId "
                        End If
                        If pRowData.IsDirty(rowTblMetaChartSeriesDetail.FieldIndex.colFldIndexOrder) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldIndexOrder] = @colFldIndexOrder "
                        End If
                        If pRowData.IsDirty(rowTblMetaChartSeriesDetail.FieldIndex.colFldField) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldField] = @colFldField "
                        End If
                        If pRowData.IsDirty(rowTblMetaChartSeriesDetail.FieldIndex.colFldTitle) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldTitle] = @colFldTitle "
                        End If
                        If pRowData.IsDirty(rowTblMetaChartSeriesDetail.FieldIndex.colFldColor) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldColor] = @colFldColor "
                        End If
                        If pRowData.IsDirty(rowTblMetaChartSeriesDetail.FieldIndex.colFldNotes) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldNotes] = @colFldNotes "
                        End If
                        If pRowData.IsDirty(rowTblMetaChartSeriesDetail.FieldIndex.colFldMetaChartDrillDownTypeId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldMetaChartDrillDownTypeId] = @colFldMetaChartDrillDownTypeId "
                        End If
                        If pRowData.IsDirty(rowTblMetaChartSeriesDetail.FieldIndex.colFldInclude) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldInclude] = @colFldInclude "
                        End If
                        If pRowData.IsDirty(rowTblMetaChartSeriesDetail.FieldIndex.colFldCustomFeature) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldCustomFeature] = @colFldCustomFeature "
                        End If
                        zWhere = " WHERE [fldId] = @colFldId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaChartSeriesDetail] ([fldMetaChartSeriesId], [fldMetaChartDrillDownId], [fldIndexOrder], [fldField], [fldTitle], [fldColor], [fldNotes], [fldMetaChartDrillDownTypeId], [fldInclude], [fldCustomFeature])" & _
                            " VALUES (@colFldMetaChartSeriesId, @colFldMetaChartDrillDownId, @colFldIndexOrder, @colFldField, @colFldTitle, @colFldColor, @colFldNotes, @colFldMetaChartDrillDownTypeId, @colFldInclude, @colFldCustomFeature); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaChartSeriesDetail] ([fldMetaChartSeriesId], [fldMetaChartDrillDownId], [fldIndexOrder], [fldField], [fldTitle], [fldColor], [fldNotes], [fldMetaChartDrillDownTypeId], [fldInclude], [fldCustomFeature])" & _
                            " VALUES (@colFldMetaChartSeriesId, @colFldMetaChartDrillDownId, @colFldIndexOrder, @colFldField, @colFldTitle, @colFldColor, @colFldNotes, @colFldMetaChartDrillDownTypeId, @colFldInclude, @colFldCustomFeature); SELECT SCOPE_IDENTITY()"
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

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaChartSeriesDetail.FieldIndex.colFldMetaChartSeriesId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldMetaChartSeriesId", IIf(pRowData.colFldMetaChartSeriesId Is Nothing, DBNull.Value, pRowData.colFldMetaChartSeriesId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaChartSeriesDetail.FieldIndex.colFldMetaChartDrillDownId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldMetaChartDrillDownId", IIf(pRowData.colFldMetaChartDrillDownId Is Nothing, DBNull.Value, pRowData.colFldMetaChartDrillDownId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaChartSeriesDetail.FieldIndex.colFldIndexOrder) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldIndexOrder", IIf(pRowData.colFldIndexOrder Is Nothing, DBNull.Value, pRowData.colFldIndexOrder)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaChartSeriesDetail.FieldIndex.colFldField) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldField", IIf(pRowData.colFldField Is Nothing, DBNull.Value, pRowData.colFldField)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaChartSeriesDetail.FieldIndex.colFldTitle) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldTitle", IIf(pRowData.colFldTitle Is Nothing, DBNull.Value, pRowData.colFldTitle)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaChartSeriesDetail.FieldIndex.colFldColor) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldColor", IIf(pRowData.colFldColor Is Nothing, DBNull.Value, pRowData.colFldColor)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaChartSeriesDetail.FieldIndex.colFldNotes) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldNotes", IIf(pRowData.colFldNotes Is Nothing, DBNull.Value, pRowData.colFldNotes)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaChartSeriesDetail.FieldIndex.colFldMetaChartDrillDownTypeId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldMetaChartDrillDownTypeId", IIf(pRowData.colFldMetaChartDrillDownTypeId Is Nothing, DBNull.Value, pRowData.colFldMetaChartDrillDownTypeId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaChartSeriesDetail.FieldIndex.colFldInclude) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldInclude", IIf(pRowData.colFldInclude Is Nothing, DBNull.Value, pRowData.colFldInclude)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaChartSeriesDetail.FieldIndex.colFldCustomFeature) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldCustomFeature", IIf(pRowData.colFldCustomFeature Is Nothing, DBNull.Value, pRowData.colFldCustomFeature)))
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

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer) As rowTblMetaChartSeriesDetail
            Return LoadByPrimaryKey(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pLoadEventUserState As Object) As rowTblMetaChartSeriesDetail
            Return LoadByPrimaryKey(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblMetaChartSeriesDetail
            Return LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblMetaChartSeriesDetail
            Dim zReturn As New rowTblMetaChartSeriesDetail
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaChartSeriesDetail] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblMetaChartSeriesDetail) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK_tblMetaChartSeriesDetail(pcolFldId As Integer) As List(Of rowTblMetaChartSeriesDetail)
            Return LoadByIDX_PK_tblMetaChartSeriesDetail(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaChartSeriesDetail(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of rowTblMetaChartSeriesDetail)
            Return LoadByIDX_PK_tblMetaChartSeriesDetail(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaChartSeriesDetail(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaChartSeriesDetail)
            Return LoadByIDX_PK_tblMetaChartSeriesDetail(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaChartSeriesDetail(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaChartSeriesDetail)
            Dim zReturn As New List(Of rowTblMetaChartSeriesDetail)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaChartSeriesDetail] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblMetaChartSeriesDetail)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblMetaChartSeriesDetail)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblMetaChartSeriesDetail)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaChartSeriesDetail)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaChartSeriesDetail)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaChartSeriesDetail)
            Dim zReturn As New List(Of rowTblMetaChartSeriesDetail)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaChartSeriesDetail]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblMetaChartSeriesDetail)

			Try
	            Dim zReturn As New List(Of rowTblMetaChartSeriesDetail)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblMetaChartSeriesDetail

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblMetaChartSeriesDetail		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblMetaChartSeriesDetail)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldId")) Then pObject.colFldId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldMetaChartSeriesId")) Then pObject.colFldMetaChartSeriesId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldMetaChartSeriesId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldMetaChartDrillDownId")) Then pObject.colFldMetaChartDrillDownId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldMetaChartDrillDownId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldIndexOrder")) Then pObject.colFldIndexOrder = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldIndexOrder")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldField")) Then pObject.colFldField = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldField")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldTitle")) Then pObject.colFldTitle = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldTitle")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldColor")) Then pObject.colFldColor = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldColor")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldNotes")) Then pObject.colFldNotes = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldNotes")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldMetaChartDrillDownTypeId")) Then pObject.colFldMetaChartDrillDownTypeId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldMetaChartDrillDownTypeId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldInclude")) Then pObject.colFldInclude = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldInclude")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldCustomFeature")) Then pObject.colFldCustomFeature = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldCustomFeature")
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
            If Not TypeOf zReturn Is rowTblMetaChartSeriesDetail Then Throw New ArgumentException("Generic type is not type of rowTblMetaChartSeriesDetail.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaChartSeriesDetail] WHERE [fldId] = @colFldId"
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

        Public Shared Function LoadByIDX_PK_tblMetaChartSeriesDetail(Of T)(pcolFldId As Integer) As List(Of T)
            Return LoadByIDX_PK_tblMetaChartSeriesDetail(Of T)(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaChartSeriesDetail(Of T)(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK_tblMetaChartSeriesDetail(Of T)(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaChartSeriesDetail(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK_tblMetaChartSeriesDetail(Of T)(pcolFldId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK_tblMetaChartSeriesDetail(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaChartSeriesDetail] WHERE [fldId] = @colFldId"
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
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaChartSeriesDetail]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblMetaChartSeriesDetail
        Implements IrowTblMetaChartSeriesDetail

        Public Event Loaded(pUserState As Object) Implements IrowTblMetaChartSeriesDetail.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblMetaChartSeriesDetail.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblMetaChartSeriesDetail.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblMetaChartSeriesDetail.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblMetaChartSeriesDetail.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblMetaChartSeriesDetail.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldId() As Nullable(Of Integer) Implements IrowTblMetaChartSeriesDetail.colFldId
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

        Public Property colFldMetaChartSeriesId() As Nullable(Of Integer) Implements IrowTblMetaChartSeriesDetail.colFldMetaChartSeriesId
            Get
                Return m_colFldMetaChartSeriesId
            End Get
            Set
                If Not Same(m_colFldMetaChartSeriesId, Value) Then
                    m_colFldMetaChartSeriesId = Value
                    m_IsDirty(FieldIndex.colFldMetaChartSeriesId) = True
                End If
            End Set
        End Property
        Private m_colFldMetaChartSeriesId As Nullable(Of Integer)

        Public Property colFldMetaChartDrillDownId() As Nullable(Of Integer) Implements IrowTblMetaChartSeriesDetail.colFldMetaChartDrillDownId
            Get
                Return m_colFldMetaChartDrillDownId
            End Get
            Set
                If Not Same(m_colFldMetaChartDrillDownId, Value) Then
                    m_colFldMetaChartDrillDownId = Value
                    m_IsDirty(FieldIndex.colFldMetaChartDrillDownId) = True
                End If
            End Set
        End Property
        Private m_colFldMetaChartDrillDownId As Nullable(Of Integer)

        Public Property colFldIndexOrder() As Nullable(Of Integer) Implements IrowTblMetaChartSeriesDetail.colFldIndexOrder
            Get
                Return m_colFldIndexOrder
            End Get
            Set
                If Not Same(m_colFldIndexOrder, Value) Then
                    m_colFldIndexOrder = Value
                    m_IsDirty(FieldIndex.colFldIndexOrder) = True
                End If
            End Set
        End Property
        Private m_colFldIndexOrder As Nullable(Of Integer)

        Public Property colFldField() As String Implements IrowTblMetaChartSeriesDetail.colFldField
            Get
                Return m_colFldField
            End Get
            Set
                If Not Same(m_colFldField, Value) Then
                    m_colFldField = Value
                    m_IsDirty(FieldIndex.colFldField) = True
                End If
            End Set
        End Property
        Private m_colFldField As String

        Public Property colFldTitle() As String Implements IrowTblMetaChartSeriesDetail.colFldTitle
            Get
                Return m_colFldTitle
            End Get
            Set
                If Not Same(m_colFldTitle, Value) Then
                    m_colFldTitle = Value
                    m_IsDirty(FieldIndex.colFldTitle) = True
                End If
            End Set
        End Property
        Private m_colFldTitle As String

        Public Property colFldColor() As String Implements IrowTblMetaChartSeriesDetail.colFldColor
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

        Public Property colFldNotes() As String Implements IrowTblMetaChartSeriesDetail.colFldNotes
            Get
                Return m_colFldNotes
            End Get
            Set
                If Not Same(m_colFldNotes, Value) Then
                    m_colFldNotes = Value
                    m_IsDirty(FieldIndex.colFldNotes) = True
                End If
            End Set
        End Property
        Private m_colFldNotes As String

        Public Property colFldMetaChartDrillDownTypeId() As Nullable(Of Integer) Implements IrowTblMetaChartSeriesDetail.colFldMetaChartDrillDownTypeId
            Get
                Return m_colFldMetaChartDrillDownTypeId
            End Get
            Set
                If Not Same(m_colFldMetaChartDrillDownTypeId, Value) Then
                    m_colFldMetaChartDrillDownTypeId = Value
                    m_IsDirty(FieldIndex.colFldMetaChartDrillDownTypeId) = True
                End If
            End Set
        End Property
        Private m_colFldMetaChartDrillDownTypeId As Nullable(Of Integer)

        Public Property colFldInclude() As Nullable(Of Boolean) Implements IrowTblMetaChartSeriesDetail.colFldInclude
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

        Public Property colFldCustomFeature() As String Implements IrowTblMetaChartSeriesDetail.colFldCustomFeature
            Get
                Return m_colFldCustomFeature
            End Get
            Set
                If Not Same(m_colFldCustomFeature, Value) Then
                    m_colFldCustomFeature = Value
                    m_IsDirty(FieldIndex.colFldCustomFeature) = True
                End If
            End Set
        End Property
        Private m_colFldCustomFeature As String


        Public Function IsDirty(pIndex As rowTblMetaChartSeriesDetail.FieldIndex) As Boolean Implements IrowTblMetaChartSeriesDetail.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblMetaChartSeriesDetail.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblMetaChartSeriesDetail.SetIsDirty
            m_IsDirty(FieldIndex.colFldId) = pDirty
            m_IsDirty(FieldIndex.colFldMetaChartSeriesId) = pDirty
            m_IsDirty(FieldIndex.colFldMetaChartDrillDownId) = pDirty
            m_IsDirty(FieldIndex.colFldIndexOrder) = pDirty
            m_IsDirty(FieldIndex.colFldField) = pDirty
            m_IsDirty(FieldIndex.colFldTitle) = pDirty
            m_IsDirty(FieldIndex.colFldColor) = pDirty
            m_IsDirty(FieldIndex.colFldNotes) = pDirty
            m_IsDirty(FieldIndex.colFldMetaChartDrillDownTypeId) = pDirty
            m_IsDirty(FieldIndex.colFldInclude) = pDirty
            m_IsDirty(FieldIndex.colFldCustomFeature) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblMetaChartSeriesDetail) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblMetaChartSeriesDetail
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldId  = 1
            colFldMetaChartSeriesId 
            colFldMetaChartDrillDownId 
            colFldIndexOrder 
            colFldField 
            colFldTitle 
            colFldColor 
            colFldNotes 
            colFldMetaChartDrillDownTypeId 
            colFldInclude 
            colFldCustomFeature 
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

    Public Interface IrowTblMetaChartSeriesDetail
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldId() As Nullable(Of Integer)
        Property colFldMetaChartSeriesId() As Nullable(Of Integer)
        Property colFldMetaChartDrillDownId() As Nullable(Of Integer)
        Property colFldIndexOrder() As Nullable(Of Integer)
        Property colFldField() As String
        Property colFldTitle() As String
        Property colFldColor() As String
        Property colFldNotes() As String
        Property colFldMetaChartDrillDownTypeId() As Nullable(Of Integer)
        Property colFldInclude() As Nullable(Of Boolean)
        Property colFldCustomFeature() As String
        Function IsDirty(pIndex As rowTblMetaChartSeriesDetail.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

