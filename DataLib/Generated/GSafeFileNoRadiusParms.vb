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
    Partial Public Class GSafeFileNoRadiusParms

        Public Shared Sub Delete(ByRef pRowData As IrowGSafeFileNoRadiusParms)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowGSafeFileNoRadiusParms, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowGSafeFileNoRadiusParms, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowGSafeFileNoRadiusParms, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colRadiusParmId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[GSafeFileNoRadiusParms] " & _
                        "WHERE [RadiusParmId] = @colRadiusParmId"

                Dim zCmd As New SQLCommand
                zCmd.CommandText = zSQL
                zCmd.Parameters.Add(New SQLParameter("@colRadiusParmId", pRowData.colRadiusParmId))

                zCmd.Transaction=pTransaction
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)

                pRowData.RaiseDeletedEvent(pDeleteEventUserState)

            End If

        End Sub

        Public Shared Sub Delete(pcolRadiusParmId As Integer)
            Delete(pcolRadiusParmId, Nothing, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolRadiusParmId As Integer, pDeleteEventUserState As Object)
            Delete(pcolRadiusParmId, Nothing, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Delete(pcolRadiusParmId As Integer, ByRef pTransaction As SqlClient.SqlTransaction)
        Delete(pcolRadiusParmId, pTransaction, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolRadiusParmId As Integer, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
        Dim zObj As rowGSafeFileNoRadiusParms = LoadByPrimaryKey(pcolRadiusParmId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowGSafeFileNoRadiusParms)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowGSafeFileNoRadiusParms, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowGSafeFileNoRadiusParms, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colRadiusParmId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[GSafeFileNoRadiusParms] WHERE [RadiusParmId] = @colRadiusParmId"

                Dim zCmdDoesExist As New SQLCommand

                zCmdDoesExist.CommandText = zSQL

                zCmdDoesExist.Parameters.Add(new SQLParameter("@colRadiusParmId", pRowData.colRadiusParmId))

                'if zExistInDB > 0  then  PK exists in the DB
                zCmdDoesExist.Transaction = pTransaction
                zExistInDB = razor.UtilSQLServer.ExecuteScalar(zCmdDoesExist)
            End If

            If razor.UtilSQLServer.IsKeySet(pRowData.colRadiusParmId) And zExistInDB > 0 Then
                zMode = "UPDATE"
            End If
            If razor.UtilSQLServer.IsKeySet(pRowData.colRadiusParmId) And zExistInDB = 0 Then
                zMode = "INSERTwithKey"
            End If
            If Not razor.UtilSQLServer.IsKeySet(pRowData.colRadiusParmId) Then
                zMode = "INSERTnoKey"
            End If

            Select Case zMode
                Case "UPDATE"
                    If pRowData.IsDirty Then
                        Dim zUpdate As String = ""
                        Dim zSet As String = ""
                        Dim zWhere As String = ""
                        zUpdate = "UPDATE [dbo].[GSafeFileNoRadiusParms] SET " 
                        If pRowData.IsDirty(rowGSafeFileNoRadiusParms.FieldIndex.colGSafeId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [GSafeId] = @colGSafeId "
                        End If
                        If pRowData.IsDirty(rowGSafeFileNoRadiusParms.FieldIndex.colLatitude) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [Latitude] = @colLatitude "
                        End If
                        If pRowData.IsDirty(rowGSafeFileNoRadiusParms.FieldIndex.colLongitude) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [Longitude] = @colLongitude "
                        End If
                        If pRowData.IsDirty(rowGSafeFileNoRadiusParms.FieldIndex.colInputRange) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [InputRange] = @colInputRange "
                        End If
                        If pRowData.IsDirty(rowGSafeFileNoRadiusParms.FieldIndex.colUnits) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [Units] = @colUnits "
                        End If
                        If pRowData.IsDirty(rowGSafeFileNoRadiusParms.FieldIndex.colSearchName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [SearchName] = @colSearchName "
                        End If
                        zWhere = " WHERE [RadiusParmId] = @colRadiusParmId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[GSafeFileNoRadiusParms] ([GSafeId], [Latitude], [Longitude], [InputRange], [Units], [SearchName])" & _
                            " VALUES (@colGSafeId, @colLatitude, @colLongitude, @colInputRange, @colUnits, @colSearchName); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[GSafeFileNoRadiusParms] ([GSafeId], [Latitude], [Longitude], [InputRange], [Units], [SearchName])" & _
                            " VALUES (@colGSafeId, @colLatitude, @colLongitude, @colInputRange, @colUnits, @colSearchName); SELECT SCOPE_IDENTITY()"
                Case Else
            End Select

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

			'IF UPDATE, SET PK PARAMETER
            If zMode = "UPDATE" Then
                zCmd.Parameters.Add(New SQLParameter("@colRadiusParmId", pRowData.colRadiusParmId))
            End If

			'IF INSERTING, KEY HAS VALUE AND KEY IS NOT IDENTITY, SET PK PARAMETER
			If zMode = "INSERTwithKey" Then
            End If

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowGSafeFileNoRadiusParms.FieldIndex.colGSafeId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colGSafeId", IIf(pRowData.colGSafeId Is Nothing, DBNull.Value, pRowData.colGSafeId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowGSafeFileNoRadiusParms.FieldIndex.colLatitude) Then
                    zCmd.Parameters.Add(New SqlParameter("@colLatitude", IIf(pRowData.colLatitude Is Nothing, DBNull.Value, pRowData.colLatitude)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowGSafeFileNoRadiusParms.FieldIndex.colLongitude) Then
                    zCmd.Parameters.Add(New SqlParameter("@colLongitude", IIf(pRowData.colLongitude Is Nothing, DBNull.Value, pRowData.colLongitude)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowGSafeFileNoRadiusParms.FieldIndex.colInputRange) Then
                    zCmd.Parameters.Add(New SqlParameter("@colInputRange", IIf(pRowData.colInputRange Is Nothing, DBNull.Value, pRowData.colInputRange)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowGSafeFileNoRadiusParms.FieldIndex.colUnits) Then
                    zCmd.Parameters.Add(New SqlParameter("@colUnits", IIf(pRowData.colUnits Is Nothing, DBNull.Value, pRowData.colUnits)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowGSafeFileNoRadiusParms.FieldIndex.colSearchName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSearchName", IIf(pRowData.colSearchName Is Nothing, DBNull.Value, pRowData.colSearchName)))
                End If

            zCmd.Transaction=pTransaction
            If zMode = "INSERTnoKey" Then
                Dim zLastId As Long = 0
                zLastId = razor.UtilSQLServer.ExecuteNonQueryRowId(zCmd)

                pRowData.colRadiusParmId = zLastId
            Else
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)
            End If

            pRowData.SetIsDirty(False)
            pRowData.RaiseSavedEvent(pSavedEventUserState)

		End If

        End Sub

        Public Shared Function LoadByPrimaryKey(pcolRadiusParmId As Integer) As rowGSafeFileNoRadiusParms
            Return LoadByPrimaryKey(pcolRadiusParmId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolRadiusParmId As Integer, pLoadEventUserState As Object) As rowGSafeFileNoRadiusParms
            Return LoadByPrimaryKey(pcolRadiusParmId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolRadiusParmId As Integer, pTransaction As SqlClient.SqlTransaction) As rowGSafeFileNoRadiusParms
            Return LoadByPrimaryKey(pcolRadiusParmId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolRadiusParmId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowGSafeFileNoRadiusParms
            Dim zReturn As New rowGSafeFileNoRadiusParms
            Dim zSQL As String = "SELECT * FROM [dbo].[GSafeFileNoRadiusParms] WHERE [RadiusParmId] = @colRadiusParmId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colRadiusParmId", pcolRadiusParmId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowGSafeFileNoRadiusParms) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK_GSafeFileNoRadiusParms(pcolRadiusParmId As Integer) As List(Of rowGSafeFileNoRadiusParms)
            Return LoadByIDX_PK_GSafeFileNoRadiusParms(pcolRadiusParmId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_GSafeFileNoRadiusParms(pcolRadiusParmId As Integer, pLoadEventUserState As Object) As List(Of rowGSafeFileNoRadiusParms)
            Return LoadByIDX_PK_GSafeFileNoRadiusParms(pcolRadiusParmId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_GSafeFileNoRadiusParms(pcolRadiusParmId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowGSafeFileNoRadiusParms)
            Return LoadByIDX_PK_GSafeFileNoRadiusParms(pcolRadiusParmId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_GSafeFileNoRadiusParms(pcolRadiusParmId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowGSafeFileNoRadiusParms)
            Dim zReturn As New List(Of rowGSafeFileNoRadiusParms)
            Dim zSQL As String = "SELECT * FROM [dbo].[GSafeFileNoRadiusParms] WHERE [RadiusParmId] = @colRadiusParmId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colRadiusParmId", pcolRadiusParmId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowGSafeFileNoRadiusParms)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowGSafeFileNoRadiusParms)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowGSafeFileNoRadiusParms)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowGSafeFileNoRadiusParms)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowGSafeFileNoRadiusParms)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowGSafeFileNoRadiusParms)
            Dim zReturn As New List(Of rowGSafeFileNoRadiusParms)
            Dim zSQL As String = "SELECT * FROM [dbo].[GSafeFileNoRadiusParms]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowGSafeFileNoRadiusParms)

			Try
	            Dim zReturn As New List(Of rowGSafeFileNoRadiusParms)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowGSafeFileNoRadiusParms

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowGSafeFileNoRadiusParms		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowGSafeFileNoRadiusParms)
			If Not pReader.IsDBNull(pReader.GetOrdinal("RadiusParmId")) Then pObject.colRadiusParmId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "RadiusParmId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("GSafeId")) Then pObject.colGSafeId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "GSafeId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Latitude")) Then pObject.colLatitude = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "Latitude")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Longitude")) Then pObject.colLongitude = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "Longitude")
			If Not pReader.IsDBNull(pReader.GetOrdinal("InputRange")) Then pObject.colInputRange = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "InputRange")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Units")) Then pObject.colUnits = UtilSQLServer.SafeReader.SafeReadString(pReader, "Units")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SearchName")) Then pObject.colSearchName = UtilSQLServer.SafeReader.SafeReadString(pReader, "SearchName")
			pObject.SetIsDirty(False)
			Return pObject
		End	 Function

    #Region "Reflection Based Load Functions"

        Public Shared Function LoadByPrimaryKey(Of T)(pcolRadiusParmId As Integer) As T
            Return LoadByPrimaryKey(Of T)(pcolRadiusParmId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolRadiusParmId As Integer, pLoadEventUserState As Object) As T
            Return LoadByPrimaryKey(Of T)(pcolRadiusParmId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolRadiusParmId As Integer, pTransaction As SqlClient.SqlTransaction) As T
            Return LoadByPrimaryKey(Of T)(pcolRadiusParmId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolRadiusParmId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As T

            Dim zReturn As Object = Activator.CreateInstance(Of T)()
            If Not TypeOf zReturn Is rowGSafeFileNoRadiusParms Then Throw New ArgumentException("Generic type is not type of rowGSafeFileNoRadiusParms.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[GSafeFileNoRadiusParms] WHERE [RadiusParmId] = @colRadiusParmId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colRadiusParmId", pcolRadiusParmId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of T) = ReadData(Of T)(zCmd, pLoadEventUserState)
            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

        End Function

        Public Shared Function LoadByIDX_PK_GSafeFileNoRadiusParms(Of T)(pcolRadiusParmId As Integer) As List(Of T)
            Return LoadByIDX_PK_GSafeFileNoRadiusParms(Of T)(pcolRadiusParmId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_GSafeFileNoRadiusParms(Of T)(pcolRadiusParmId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK_GSafeFileNoRadiusParms(Of T)(pcolRadiusParmId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_GSafeFileNoRadiusParms(Of T)(pcolRadiusParmId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK_GSafeFileNoRadiusParms(Of T)(pcolRadiusParmId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK_GSafeFileNoRadiusParms(Of T)(pcolRadiusParmId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[GSafeFileNoRadiusParms] WHERE [RadiusParmId] = @colRadiusParmId"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colRadiusParmId", pcolRadiusParmId))

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
            Dim zSQL As String = "SELECT * FROM [dbo].[GSafeFileNoRadiusParms]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowGSafeFileNoRadiusParms
        Implements IrowGSafeFileNoRadiusParms

        Public Event Loaded(pUserState As Object) Implements IrowGSafeFileNoRadiusParms.Loaded
        Public Event Saved(pUserState As Object) Implements IrowGSafeFileNoRadiusParms.Saved
        Public Event Deleted(pUserState As Object) Implements IrowGSafeFileNoRadiusParms.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowGSafeFileNoRadiusParms.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowGSafeFileNoRadiusParms.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowGSafeFileNoRadiusParms.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colRadiusParmId() As Nullable(Of Integer) Implements IrowGSafeFileNoRadiusParms.colRadiusParmId
            Get
                Return m_colRadiusParmId
            End Get
            Set
                If Not Same(m_colRadiusParmId, Value) Then
                    m_colRadiusParmId = Value
                    m_IsDirty(FieldIndex.colRadiusParmId) = True
                End If
            End Set
        End Property
        Private m_colRadiusParmId As Nullable(Of Integer)

        Public Property colGSafeId() As Nullable(Of Integer) Implements IrowGSafeFileNoRadiusParms.colGSafeId
            Get
                Return m_colGSafeId
            End Get
            Set
                If Not Same(m_colGSafeId, Value) Then
                    m_colGSafeId = Value
                    m_IsDirty(FieldIndex.colGSafeId) = True
                End If
            End Set
        End Property
        Private m_colGSafeId As Nullable(Of Integer)

        Public Property colLatitude() As Nullable(Of Decimal) Implements IrowGSafeFileNoRadiusParms.colLatitude
            Get
                Return m_colLatitude
            End Get
            Set
                If Not Same(m_colLatitude, Value) Then
                    m_colLatitude = Value
                    m_IsDirty(FieldIndex.colLatitude) = True
                End If
            End Set
        End Property
        Private m_colLatitude As Nullable(Of Decimal)

        Public Property colLongitude() As Nullable(Of Decimal) Implements IrowGSafeFileNoRadiusParms.colLongitude
            Get
                Return m_colLongitude
            End Get
            Set
                If Not Same(m_colLongitude, Value) Then
                    m_colLongitude = Value
                    m_IsDirty(FieldIndex.colLongitude) = True
                End If
            End Set
        End Property
        Private m_colLongitude As Nullable(Of Decimal)

        Public Property colInputRange() As Nullable(Of Double) Implements IrowGSafeFileNoRadiusParms.colInputRange
            Get
                Return m_colInputRange
            End Get
            Set
                If Not Same(m_colInputRange, Value) Then
                    m_colInputRange = Value
                    m_IsDirty(FieldIndex.colInputRange) = True
                End If
            End Set
        End Property
        Private m_colInputRange As Nullable(Of Double)

        Public Property colUnits() As String Implements IrowGSafeFileNoRadiusParms.colUnits
            Get
                Return m_colUnits
            End Get
            Set
                If Not Same(m_colUnits, Value) Then
                    m_colUnits = Value
                    m_IsDirty(FieldIndex.colUnits) = True
                End If
            End Set
        End Property
        Private m_colUnits As String

        Public Property colSearchName() As String Implements IrowGSafeFileNoRadiusParms.colSearchName
            Get
                Return m_colSearchName
            End Get
            Set
                If Not Same(m_colSearchName, Value) Then
                    m_colSearchName = Value
                    m_IsDirty(FieldIndex.colSearchName) = True
                End If
            End Set
        End Property
        Private m_colSearchName As String


        Public Function IsDirty(pIndex As rowGSafeFileNoRadiusParms.FieldIndex) As Boolean Implements IrowGSafeFileNoRadiusParms.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowGSafeFileNoRadiusParms.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowGSafeFileNoRadiusParms.SetIsDirty
            m_IsDirty(FieldIndex.colRadiusParmId) = pDirty
            m_IsDirty(FieldIndex.colGSafeId) = pDirty
            m_IsDirty(FieldIndex.colLatitude) = pDirty
            m_IsDirty(FieldIndex.colLongitude) = pDirty
            m_IsDirty(FieldIndex.colInputRange) = pDirty
            m_IsDirty(FieldIndex.colUnits) = pDirty
            m_IsDirty(FieldIndex.colSearchName) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (GSafeFileNoRadiusParms) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New GSafeFileNoRadiusParms
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colRadiusParmId  = 1
            colGSafeId 
            colLatitude 
            colLongitude 
            colInputRange 
            colUnits 
            colSearchName 
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

    Public Interface IrowGSafeFileNoRadiusParms
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colRadiusParmId() As Nullable(Of Integer)
        Property colGSafeId() As Nullable(Of Integer)
        Property colLatitude() As Nullable(Of Decimal)
        Property colLongitude() As Nullable(Of Decimal)
        Property colInputRange() As Nullable(Of Double)
        Property colUnits() As String
        Property colSearchName() As String
        Function IsDirty(pIndex As rowGSafeFileNoRadiusParms.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

