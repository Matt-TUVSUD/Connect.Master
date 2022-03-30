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
    Partial Public Class TblMetaChartSeries

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaChartSeries)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaChartSeries, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaChartSeries, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaChartSeries, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[tblMetaChartSeries] " & _
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
        Dim zObj As rowTblMetaChartSeries = LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblMetaChartSeries)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaChartSeries, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaChartSeries, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[tblMetaChartSeries] WHERE [fldId] = @colFldId"

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
                        zUpdate = "UPDATE [dbo].[tblMetaChartSeries] SET " 
                        If pRowData.IsDirty(rowTblMetaChartSeries.FieldIndex.colFldMetaChartId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldMetaChartId] = @colFldMetaChartId "
                        End If
                        If pRowData.IsDirty(rowTblMetaChartSeries.FieldIndex.colName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [name] = @colName "
                        End If
                        If pRowData.IsDirty(rowTblMetaChartSeries.FieldIndex.colType) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [type] = @colType "
                        End If
                        If pRowData.IsDirty(rowTblMetaChartSeries.FieldIndex.colField) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [field] = @colField "
                        End If
                        If pRowData.IsDirty(rowTblMetaChartSeries.FieldIndex.colCategoryField) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [categoryField] = @colCategoryField "
                        End If
                        If pRowData.IsDirty(rowTblMetaChartSeries.FieldIndex.colColorField) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [colorField] = @colColorField "
                        End If
                        If pRowData.IsDirty(rowTblMetaChartSeries.FieldIndex.colColor) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [color] = @colColor "
                        End If
                        If pRowData.IsDirty(rowTblMetaChartSeries.FieldIndex.colFldNotes) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldNotes] = @colFldNotes "
                        End If
                        zWhere = " WHERE [fldId] = @colFldId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaChartSeries] ([fldMetaChartId], [name], [type], [field], [categoryField], [colorField], [color], [fldNotes])" & _
                            " VALUES (@colFldMetaChartId, @colName, @colType, @colField, @colCategoryField, @colColorField, @colColor, @colFldNotes); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaChartSeries] ([fldMetaChartId], [name], [type], [field], [categoryField], [colorField], [color], [fldNotes])" & _
                            " VALUES (@colFldMetaChartId, @colName, @colType, @colField, @colCategoryField, @colColorField, @colColor, @colFldNotes); SELECT SCOPE_IDENTITY()"
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

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaChartSeries.FieldIndex.colFldMetaChartId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldMetaChartId", IIf(pRowData.colFldMetaChartId Is Nothing, DBNull.Value, pRowData.colFldMetaChartId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaChartSeries.FieldIndex.colName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colName", IIf(pRowData.colName Is Nothing, DBNull.Value, pRowData.colName)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaChartSeries.FieldIndex.colType) Then
                    zCmd.Parameters.Add(New SqlParameter("@colType", IIf(pRowData.colType Is Nothing, DBNull.Value, pRowData.colType)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaChartSeries.FieldIndex.colField) Then
                    zCmd.Parameters.Add(New SqlParameter("@colField", IIf(pRowData.colField Is Nothing, DBNull.Value, pRowData.colField)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaChartSeries.FieldIndex.colCategoryField) Then
                    zCmd.Parameters.Add(New SqlParameter("@colCategoryField", IIf(pRowData.colCategoryField Is Nothing, DBNull.Value, pRowData.colCategoryField)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaChartSeries.FieldIndex.colColorField) Then
                    zCmd.Parameters.Add(New SqlParameter("@colColorField", IIf(pRowData.colColorField Is Nothing, DBNull.Value, pRowData.colColorField)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaChartSeries.FieldIndex.colColor) Then
                    zCmd.Parameters.Add(New SqlParameter("@colColor", IIf(pRowData.colColor Is Nothing, DBNull.Value, pRowData.colColor)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaChartSeries.FieldIndex.colFldNotes) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldNotes", IIf(pRowData.colFldNotes Is Nothing, DBNull.Value, pRowData.colFldNotes)))
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

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer) As rowTblMetaChartSeries
            Return LoadByPrimaryKey(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pLoadEventUserState As Object) As rowTblMetaChartSeries
            Return LoadByPrimaryKey(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblMetaChartSeries
            Return LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblMetaChartSeries
            Dim zReturn As New rowTblMetaChartSeries
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaChartSeries] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblMetaChartSeries) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK_tblMetaChartSeries(pcolFldId As Integer) As List(Of rowTblMetaChartSeries)
            Return LoadByIDX_PK_tblMetaChartSeries(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaChartSeries(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of rowTblMetaChartSeries)
            Return LoadByIDX_PK_tblMetaChartSeries(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaChartSeries(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaChartSeries)
            Return LoadByIDX_PK_tblMetaChartSeries(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaChartSeries(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaChartSeries)
            Dim zReturn As New List(Of rowTblMetaChartSeries)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaChartSeries] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblMetaChartSeries)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblMetaChartSeries)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblMetaChartSeries)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaChartSeries)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaChartSeries)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaChartSeries)
            Dim zReturn As New List(Of rowTblMetaChartSeries)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaChartSeries]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblMetaChartSeries)

			Try
	            Dim zReturn As New List(Of rowTblMetaChartSeries)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblMetaChartSeries

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblMetaChartSeries		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblMetaChartSeries)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldId")) Then pObject.colFldId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldMetaChartId")) Then pObject.colFldMetaChartId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldMetaChartId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("name")) Then pObject.colName = UtilSQLServer.SafeReader.SafeReadString(pReader, "name")
			If Not pReader.IsDBNull(pReader.GetOrdinal("type")) Then pObject.colType = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "type")
			If Not pReader.IsDBNull(pReader.GetOrdinal("field")) Then pObject.colField = UtilSQLServer.SafeReader.SafeReadString(pReader, "field")
			If Not pReader.IsDBNull(pReader.GetOrdinal("categoryField")) Then pObject.colCategoryField = UtilSQLServer.SafeReader.SafeReadString(pReader, "categoryField")
			If Not pReader.IsDBNull(pReader.GetOrdinal("colorField")) Then pObject.colColorField = UtilSQLServer.SafeReader.SafeReadString(pReader, "colorField")
			If Not pReader.IsDBNull(pReader.GetOrdinal("color")) Then pObject.colColor = UtilSQLServer.SafeReader.SafeReadString(pReader, "color")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldNotes")) Then pObject.colFldNotes = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldNotes")
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
            If Not TypeOf zReturn Is rowTblMetaChartSeries Then Throw New ArgumentException("Generic type is not type of rowTblMetaChartSeries.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaChartSeries] WHERE [fldId] = @colFldId"
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

        Public Shared Function LoadByIDX_PK_tblMetaChartSeries(Of T)(pcolFldId As Integer) As List(Of T)
            Return LoadByIDX_PK_tblMetaChartSeries(Of T)(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaChartSeries(Of T)(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK_tblMetaChartSeries(Of T)(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaChartSeries(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK_tblMetaChartSeries(Of T)(pcolFldId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK_tblMetaChartSeries(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaChartSeries] WHERE [fldId] = @colFldId"
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
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaChartSeries]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblMetaChartSeries
        Implements IrowTblMetaChartSeries

        Public Event Loaded(pUserState As Object) Implements IrowTblMetaChartSeries.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblMetaChartSeries.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblMetaChartSeries.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblMetaChartSeries.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblMetaChartSeries.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblMetaChartSeries.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldId() As Nullable(Of Integer) Implements IrowTblMetaChartSeries.colFldId
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

        Public Property colFldMetaChartId() As Nullable(Of Integer) Implements IrowTblMetaChartSeries.colFldMetaChartId
            Get
                Return m_colFldMetaChartId
            End Get
            Set
                If Not Same(m_colFldMetaChartId, Value) Then
                    m_colFldMetaChartId = Value
                    m_IsDirty(FieldIndex.colFldMetaChartId) = True
                End If
            End Set
        End Property
        Private m_colFldMetaChartId As Nullable(Of Integer)

        Public Property colName() As String Implements IrowTblMetaChartSeries.colName
            Get
                Return m_colName
            End Get
            Set
                If Not Same(m_colName, Value) Then
                    m_colName = Value
                    m_IsDirty(FieldIndex.colName) = True
                End If
            End Set
        End Property
        Private m_colName As String

        Public Property colType() As Nullable(Of Integer) Implements IrowTblMetaChartSeries.colType
            Get
                Return m_colType
            End Get
            Set
                If Not Same(m_colType, Value) Then
                    m_colType = Value
                    m_IsDirty(FieldIndex.colType) = True
                End If
            End Set
        End Property
        Private m_colType As Nullable(Of Integer)

        Public Property colField() As String Implements IrowTblMetaChartSeries.colField
            Get
                Return m_colField
            End Get
            Set
                If Not Same(m_colField, Value) Then
                    m_colField = Value
                    m_IsDirty(FieldIndex.colField) = True
                End If
            End Set
        End Property
        Private m_colField As String

        Public Property colCategoryField() As String Implements IrowTblMetaChartSeries.colCategoryField
            Get
                Return m_colCategoryField
            End Get
            Set
                If Not Same(m_colCategoryField, Value) Then
                    m_colCategoryField = Value
                    m_IsDirty(FieldIndex.colCategoryField) = True
                End If
            End Set
        End Property
        Private m_colCategoryField As String

        Public Property colColorField() As String Implements IrowTblMetaChartSeries.colColorField
            Get
                Return m_colColorField
            End Get
            Set
                If Not Same(m_colColorField, Value) Then
                    m_colColorField = Value
                    m_IsDirty(FieldIndex.colColorField) = True
                End If
            End Set
        End Property
        Private m_colColorField As String

        Public Property colColor() As String Implements IrowTblMetaChartSeries.colColor
            Get
                Return m_colColor
            End Get
            Set
                If Not Same(m_colColor, Value) Then
                    m_colColor = Value
                    m_IsDirty(FieldIndex.colColor) = True
                End If
            End Set
        End Property
        Private m_colColor As String

        Public Property colFldNotes() As String Implements IrowTblMetaChartSeries.colFldNotes
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


        Public Function IsDirty(pIndex As rowTblMetaChartSeries.FieldIndex) As Boolean Implements IrowTblMetaChartSeries.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblMetaChartSeries.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblMetaChartSeries.SetIsDirty
            m_IsDirty(FieldIndex.colFldId) = pDirty
            m_IsDirty(FieldIndex.colFldMetaChartId) = pDirty
            m_IsDirty(FieldIndex.colName) = pDirty
            m_IsDirty(FieldIndex.colType) = pDirty
            m_IsDirty(FieldIndex.colField) = pDirty
            m_IsDirty(FieldIndex.colCategoryField) = pDirty
            m_IsDirty(FieldIndex.colColorField) = pDirty
            m_IsDirty(FieldIndex.colColor) = pDirty
            m_IsDirty(FieldIndex.colFldNotes) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblMetaChartSeries) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblMetaChartSeries
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldId  = 1
            colFldMetaChartId 
            colName 
            colType 
            colField 
            colCategoryField 
            colColorField 
            colColor 
            colFldNotes 
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

    Public Interface IrowTblMetaChartSeries
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldId() As Nullable(Of Integer)
        Property colFldMetaChartId() As Nullable(Of Integer)
        Property colName() As String
        Property colType() As Nullable(Of Integer)
        Property colField() As String
        Property colCategoryField() As String
        Property colColorField() As String
        Property colColor() As String
        Property colFldNotes() As String
        Function IsDirty(pIndex As rowTblMetaChartSeries.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

