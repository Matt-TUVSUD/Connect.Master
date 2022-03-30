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
    Partial Public Class TblMetaAppSetting

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaAppSetting)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaAppSetting, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaAppSetting, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaAppSetting, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldKey) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[tblMetaAppSetting] " & _
                        "WHERE [fldKey] = @colFldKey"

                Dim zCmd As New SQLCommand
                zCmd.CommandText = zSQL
                zCmd.Parameters.Add(New SQLParameter("@colFldKey", pRowData.colFldKey))

                zCmd.Transaction=pTransaction
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)

                pRowData.RaiseDeletedEvent(pDeleteEventUserState)

            End If

        End Sub

        Public Shared Sub Delete(pcolFldKey As String)
            Delete(pcolFldKey, Nothing, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolFldKey As String, pDeleteEventUserState As Object)
            Delete(pcolFldKey, Nothing, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Delete(pcolFldKey As String, ByRef pTransaction As SqlClient.SqlTransaction)
        Delete(pcolFldKey, pTransaction, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolFldKey As String, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
        Dim zObj As rowTblMetaAppSetting = LoadByPrimaryKey(pcolFldKey, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblMetaAppSetting)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaAppSetting, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaAppSetting, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldKey) Then

                zSQL = "SELECT COUNT(*) from [dbo].[tblMetaAppSetting] WHERE [fldKey] = @colFldKey"

                Dim zCmdDoesExist As New SQLCommand

                zCmdDoesExist.CommandText = zSQL

                zCmdDoesExist.Parameters.Add(new SQLParameter("@colFldKey", pRowData.colFldKey))

                'if zExistInDB > 0  then  PK exists in the DB
                zCmdDoesExist.Transaction = pTransaction
                zExistInDB = razor.UtilSQLServer.ExecuteScalar(zCmdDoesExist)
            End If

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldKey) And zExistInDB > 0 Then
                zMode = "UPDATE"
            End If
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldKey) And zExistInDB = 0 Then
                zMode = "INSERTwithKey"
            End If
            If Not razor.UtilSQLServer.IsKeySet(pRowData.colFldKey) Then
                zMode = "INSERTnoKey"
            End If

            Select Case zMode
                Case "UPDATE"
                    If pRowData.IsDirty Then
                        Dim zUpdate As String = ""
                        Dim zSet As String = ""
                        Dim zWhere As String = ""
                        zUpdate = "UPDATE [dbo].[tblMetaAppSetting] SET " 
                        If pRowData.IsDirty(rowTblMetaAppSetting.FieldIndex.colFldDevValue) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldDevValue] = @colFldDevValue "
                        End If
                        If pRowData.IsDirty(rowTblMetaAppSetting.FieldIndex.colFldTestValue) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldTestValue] = @colFldTestValue "
                        End If
                        If pRowData.IsDirty(rowTblMetaAppSetting.FieldIndex.colFldLiveValue) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldLiveValue] = @colFldLiveValue "
                        End If
                        If pRowData.IsDirty(rowTblMetaAppSetting.FieldIndex.colFldDefaultValue) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldDefaultValue] = @colFldDefaultValue "
                        End If
                        If pRowData.IsDirty(rowTblMetaAppSetting.FieldIndex.colFldDevVSValue) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldDevVSValue] = @colFldDevVSValue "
                        End If
                        zWhere = " WHERE [fldKey] = @colFldKey"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaAppSetting] ([fldKey], [fldDevValue], [fldTestValue], [fldLiveValue], [fldDefaultValue], [fldDevVSValue])" & _
                            " VALUES (@colFldKey, @colFldDevValue, @colFldTestValue, @colFldLiveValue, @colFldDefaultValue, @colFldDevVSValue); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaAppSetting] ([fldDevValue], [fldTestValue], [fldLiveValue], [fldDefaultValue], [fldDevVSValue])" & _
                            " VALUES (@colFldDevValue, @colFldTestValue, @colFldLiveValue, @colFldDefaultValue, @colFldDevVSValue); SELECT SCOPE_IDENTITY()"
                Case Else
            End Select

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

			'IF UPDATE, SET PK PARAMETER
            If zMode = "UPDATE" Then
                zCmd.Parameters.Add(New SQLParameter("@colFldKey", pRowData.colFldKey))
            End If

			'IF INSERTING, KEY HAS VALUE AND KEY IS NOT IDENTITY, SET PK PARAMETER
			If zMode = "INSERTwithKey" Then
                zCmd.Parameters.Add(New SQLParameter("@colFldKey", pRowData.colFldKey))
            End If

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaAppSetting.FieldIndex.colFldDevValue) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldDevValue", IIf(pRowData.colFldDevValue Is Nothing, DBNull.Value, pRowData.colFldDevValue)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaAppSetting.FieldIndex.colFldTestValue) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldTestValue", IIf(pRowData.colFldTestValue Is Nothing, DBNull.Value, pRowData.colFldTestValue)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaAppSetting.FieldIndex.colFldLiveValue) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldLiveValue", IIf(pRowData.colFldLiveValue Is Nothing, DBNull.Value, pRowData.colFldLiveValue)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaAppSetting.FieldIndex.colFldDefaultValue) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldDefaultValue", IIf(pRowData.colFldDefaultValue Is Nothing, DBNull.Value, pRowData.colFldDefaultValue)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaAppSetting.FieldIndex.colFldDevVSValue) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldDevVSValue", IIf(pRowData.colFldDevVSValue Is Nothing, DBNull.Value, pRowData.colFldDevVSValue)))
                End If

            zCmd.Transaction=pTransaction
            If zMode = "INSERTnoKey" Then
                Dim zLastId As Long = 0
                zLastId = razor.UtilSQLServer.ExecuteNonQueryRowId(zCmd)

                pRowData.colFldKey = zLastId
            Else
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)
            End If

            pRowData.SetIsDirty(False)
            pRowData.RaiseSavedEvent(pSavedEventUserState)

		End If

        End Sub

        Public Shared Function LoadByPrimaryKey(pcolFldKey As String) As rowTblMetaAppSetting
            Return LoadByPrimaryKey(pcolFldKey, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldKey As String, pLoadEventUserState As Object) As rowTblMetaAppSetting
            Return LoadByPrimaryKey(pcolFldKey, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldKey As String, pTransaction As SqlClient.SqlTransaction) As rowTblMetaAppSetting
            Return LoadByPrimaryKey(pcolFldKey, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldKey As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblMetaAppSetting
            Dim zReturn As New rowTblMetaAppSetting
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaAppSetting] WHERE [fldKey] = @colFldKey"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldKey", pcolFldKey))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblMetaAppSetting) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK__tblMetaA__518B60213357F4B0(pcolFldKey As String) As List(Of rowTblMetaAppSetting)
            Return LoadByIDX_PK__tblMetaA__518B60213357F4B0(pcolFldKey, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaA__518B60213357F4B0(pcolFldKey As String, pLoadEventUserState As Object) As List(Of rowTblMetaAppSetting)
            Return LoadByIDX_PK__tblMetaA__518B60213357F4B0(pcolFldKey, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaA__518B60213357F4B0(pcolFldKey As String, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaAppSetting)
            Return LoadByIDX_PK__tblMetaA__518B60213357F4B0(pcolFldKey, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaA__518B60213357F4B0(pcolFldKey As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaAppSetting)
            Dim zReturn As New List(Of rowTblMetaAppSetting)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaAppSetting] WHERE [fldKey] = @colFldKey"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldKey", pcolFldKey))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblMetaAppSetting)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblMetaAppSetting)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblMetaAppSetting)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaAppSetting)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaAppSetting)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaAppSetting)
            Dim zReturn As New List(Of rowTblMetaAppSetting)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaAppSetting]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblMetaAppSetting)

			Try
	            Dim zReturn As New List(Of rowTblMetaAppSetting)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblMetaAppSetting

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblMetaAppSetting		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblMetaAppSetting)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldKey")) Then pObject.colFldKey = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldKey")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldDevValue")) Then pObject.colFldDevValue = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldDevValue")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldTestValue")) Then pObject.colFldTestValue = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldTestValue")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldLiveValue")) Then pObject.colFldLiveValue = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldLiveValue")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldDefaultValue")) Then pObject.colFldDefaultValue = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldDefaultValue")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldDevVSValue")) Then pObject.colFldDevVSValue = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldDevVSValue")
			pObject.SetIsDirty(False)
			Return pObject
		End	 Function

    #Region "Reflection Based Load Functions"

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldKey As String) As T
            Return LoadByPrimaryKey(Of T)(pcolFldKey, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldKey As String, pLoadEventUserState As Object) As T
            Return LoadByPrimaryKey(Of T)(pcolFldKey, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldKey As String, pTransaction As SqlClient.SqlTransaction) As T
            Return LoadByPrimaryKey(Of T)(pcolFldKey, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldKey As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As T

            Dim zReturn As Object = Activator.CreateInstance(Of T)()
            If Not TypeOf zReturn Is rowTblMetaAppSetting Then Throw New ArgumentException("Generic type is not type of rowTblMetaAppSetting.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaAppSetting] WHERE [fldKey] = @colFldKey"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldKey", pcolFldKey))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of T) = ReadData(Of T)(zCmd, pLoadEventUserState)
            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

        End Function

        Public Shared Function LoadByIDX_PK__tblMetaA__518B60213357F4B0(Of T)(pcolFldKey As String) As List(Of T)
            Return LoadByIDX_PK__tblMetaA__518B60213357F4B0(Of T)(pcolFldKey, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaA__518B60213357F4B0(Of T)(pcolFldKey As String, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK__tblMetaA__518B60213357F4B0(Of T)(pcolFldKey, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaA__518B60213357F4B0(Of T)(pcolFldKey As String, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK__tblMetaA__518B60213357F4B0(Of T)(pcolFldKey, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK__tblMetaA__518B60213357F4B0(Of T)(pcolFldKey As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaAppSetting] WHERE [fldKey] = @colFldKey"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldKey", pcolFldKey))

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
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaAppSetting]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblMetaAppSetting
        Implements IrowTblMetaAppSetting

        Public Event Loaded(pUserState As Object) Implements IrowTblMetaAppSetting.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblMetaAppSetting.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblMetaAppSetting.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblMetaAppSetting.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblMetaAppSetting.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblMetaAppSetting.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldKey() As String Implements IrowTblMetaAppSetting.colFldKey
            Get
                Return m_colFldKey
            End Get
            Set
                If Not Same(m_colFldKey, Value) Then
                    m_colFldKey = Value
                    m_IsDirty(FieldIndex.colFldKey) = True
                End If
            End Set
        End Property
        Private m_colFldKey As String

        Public Property colFldDevValue() As String Implements IrowTblMetaAppSetting.colFldDevValue
            Get
                Return m_colFldDevValue
            End Get
            Set
                If Not Same(m_colFldDevValue, Value) Then
                    m_colFldDevValue = Value
                    m_IsDirty(FieldIndex.colFldDevValue) = True
                End If
            End Set
        End Property
        Private m_colFldDevValue As String

        Public Property colFldTestValue() As String Implements IrowTblMetaAppSetting.colFldTestValue
            Get
                Return m_colFldTestValue
            End Get
            Set
                If Not Same(m_colFldTestValue, Value) Then
                    m_colFldTestValue = Value
                    m_IsDirty(FieldIndex.colFldTestValue) = True
                End If
            End Set
        End Property
        Private m_colFldTestValue As String

        Public Property colFldLiveValue() As String Implements IrowTblMetaAppSetting.colFldLiveValue
            Get
                Return m_colFldLiveValue
            End Get
            Set
                If Not Same(m_colFldLiveValue, Value) Then
                    m_colFldLiveValue = Value
                    m_IsDirty(FieldIndex.colFldLiveValue) = True
                End If
            End Set
        End Property
        Private m_colFldLiveValue As String

        Public Property colFldDefaultValue() As String Implements IrowTblMetaAppSetting.colFldDefaultValue
            Get
                Return m_colFldDefaultValue
            End Get
            Set
                If Not Same(m_colFldDefaultValue, Value) Then
                    m_colFldDefaultValue = Value
                    m_IsDirty(FieldIndex.colFldDefaultValue) = True
                End If
            End Set
        End Property
        Private m_colFldDefaultValue As String

        Public Property colFldDevVSValue() As String Implements IrowTblMetaAppSetting.colFldDevVSValue
            Get
                Return m_colFldDevVSValue
            End Get
            Set
                If Not Same(m_colFldDevVSValue, Value) Then
                    m_colFldDevVSValue = Value
                    m_IsDirty(FieldIndex.colFldDevVSValue) = True
                End If
            End Set
        End Property
        Private m_colFldDevVSValue As String


        Public Function IsDirty(pIndex As rowTblMetaAppSetting.FieldIndex) As Boolean Implements IrowTblMetaAppSetting.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblMetaAppSetting.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblMetaAppSetting.SetIsDirty
            m_IsDirty(FieldIndex.colFldKey) = pDirty
            m_IsDirty(FieldIndex.colFldDevValue) = pDirty
            m_IsDirty(FieldIndex.colFldTestValue) = pDirty
            m_IsDirty(FieldIndex.colFldLiveValue) = pDirty
            m_IsDirty(FieldIndex.colFldDefaultValue) = pDirty
            m_IsDirty(FieldIndex.colFldDevVSValue) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblMetaAppSetting) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblMetaAppSetting
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldKey  = 1
            colFldDevValue 
            colFldTestValue 
            colFldLiveValue 
            colFldDefaultValue 
            colFldDevVSValue 
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

    Public Interface IrowTblMetaAppSetting
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldKey() As String
        Property colFldDevValue() As String
        Property colFldTestValue() As String
        Property colFldLiveValue() As String
        Property colFldDefaultValue() As String
        Property colFldDevVSValue() As String
        Function IsDirty(pIndex As rowTblMetaAppSetting.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

