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
    Partial Public Class TblAdminSetting

        Public Shared Sub Delete(ByRef pRowData As IrowTblAdminSetting)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblAdminSetting, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblAdminSetting, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblAdminSetting, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldKey) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [adm].[tblAdminSetting] " & _
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
        Dim zObj As rowTblAdminSetting = LoadByPrimaryKey(pcolFldKey, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblAdminSetting)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblAdminSetting, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblAdminSetting, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldKey) Then

                zSQL = "SELECT COUNT(*) from [adm].[tblAdminSetting] WHERE [fldKey] = @colFldKey"

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
                        zUpdate = "UPDATE [adm].[tblAdminSetting] SET " 
                        If pRowData.IsDirty(rowTblAdminSetting.FieldIndex.colFldValue) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldValue] = @colFldValue "
                        End If
                        zWhere = " WHERE [fldKey] = @colFldKey"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [adm].[tblAdminSetting] ([fldKey], [fldValue])" & _
                            " VALUES (@colFldKey, @colFldValue); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [adm].[tblAdminSetting] ([fldValue])" & _
                            " VALUES (@colFldValue); SELECT SCOPE_IDENTITY()"
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

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblAdminSetting.FieldIndex.colFldValue) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldValue", IIf(pRowData.colFldValue Is Nothing, DBNull.Value, pRowData.colFldValue)))
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

        Public Shared Function LoadByPrimaryKey(pcolFldKey As String) As rowTblAdminSetting
            Return LoadByPrimaryKey(pcolFldKey, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldKey As String, pLoadEventUserState As Object) As rowTblAdminSetting
            Return LoadByPrimaryKey(pcolFldKey, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldKey As String, pTransaction As SqlClient.SqlTransaction) As rowTblAdminSetting
            Return LoadByPrimaryKey(pcolFldKey, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldKey As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblAdminSetting
            Dim zReturn As New rowTblAdminSetting
            Dim zSQL As String = "SELECT * FROM [adm].[tblAdminSetting] WHERE [fldKey] = @colFldKey"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldKey", pcolFldKey))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblAdminSetting) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK__tblAdmin__518B6021012C6796(pcolFldKey As String) As List(Of rowTblAdminSetting)
            Return LoadByIDX_PK__tblAdmin__518B6021012C6796(pcolFldKey, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblAdmin__518B6021012C6796(pcolFldKey As String, pLoadEventUserState As Object) As List(Of rowTblAdminSetting)
            Return LoadByIDX_PK__tblAdmin__518B6021012C6796(pcolFldKey, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblAdmin__518B6021012C6796(pcolFldKey As String, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblAdminSetting)
            Return LoadByIDX_PK__tblAdmin__518B6021012C6796(pcolFldKey, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblAdmin__518B6021012C6796(pcolFldKey As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblAdminSetting)
            Dim zReturn As New List(Of rowTblAdminSetting)
            Dim zSQL As String = "SELECT * FROM [adm].[tblAdminSetting] WHERE [fldKey] = @colFldKey"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldKey", pcolFldKey))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblAdminSetting)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblAdminSetting)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblAdminSetting)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblAdminSetting)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblAdminSetting)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblAdminSetting)
            Dim zReturn As New List(Of rowTblAdminSetting)
            Dim zSQL As String = "SELECT * FROM [adm].[tblAdminSetting]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblAdminSetting)

			Try
	            Dim zReturn As New List(Of rowTblAdminSetting)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblAdminSetting

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblAdminSetting		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblAdminSetting)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldKey")) Then pObject.colFldKey = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldKey")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldValue")) Then pObject.colFldValue = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldValue")
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
            If Not TypeOf zReturn Is rowTblAdminSetting Then Throw New ArgumentException("Generic type is not type of rowTblAdminSetting.","T")

            Dim zSQL As String = "SELECT * FROM [adm].[tblAdminSetting] WHERE [fldKey] = @colFldKey"
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

        Public Shared Function LoadByIDX_PK__tblAdmin__518B6021012C6796(Of T)(pcolFldKey As String) As List(Of T)
            Return LoadByIDX_PK__tblAdmin__518B6021012C6796(Of T)(pcolFldKey, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblAdmin__518B6021012C6796(Of T)(pcolFldKey As String, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK__tblAdmin__518B6021012C6796(Of T)(pcolFldKey, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblAdmin__518B6021012C6796(Of T)(pcolFldKey As String, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK__tblAdmin__518B6021012C6796(Of T)(pcolFldKey, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK__tblAdmin__518B6021012C6796(Of T)(pcolFldKey As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [adm].[tblAdminSetting] WHERE [fldKey] = @colFldKey"
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
            Dim zSQL As String = "SELECT * FROM [adm].[tblAdminSetting]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class

    Partial Public Class rowTblAdminSetting
        Implements IrowTblAdminSetting

        Public Event Loaded(pUserState As Object) Implements IrowTblAdminSetting.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblAdminSetting.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblAdminSetting.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblAdminSetting.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblAdminSetting.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblAdminSetting.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldKey() As String Implements IrowTblAdminSetting.colFldKey
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

        Public Property colFldValue() As String Implements IrowTblAdminSetting.colFldValue
            Get
                Return m_colFldValue
            End Get
            Set
                If Not Same(m_colFldValue, Value) Then
                    m_colFldValue = Value
                    m_IsDirty(FieldIndex.colFldValue) = True
                End If
            End Set
        End Property
        Private m_colFldValue As String


        Public Function IsDirty(pIndex As rowTblAdminSetting.FieldIndex) As Boolean Implements IrowTblAdminSetting.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblAdminSetting.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblAdminSetting.SetIsDirty
            m_IsDirty(FieldIndex.colFldKey) = pDirty
            m_IsDirty(FieldIndex.colFldValue) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblAdminSetting) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblAdminSetting
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldKey  = 1
            colFldValue 
        End Enum

        Private m_IsDirty(2) As Boolean

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

    Public Interface IrowTblAdminSetting
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldKey() As String
        Property colFldValue() As String
        Function IsDirty(pIndex As rowTblAdminSetting.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

