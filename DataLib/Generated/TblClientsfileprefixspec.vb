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
    Partial Public Class TblClientsfileprefixspec

        Public Shared Sub Delete(ByRef pRowData As IrowTblClientsfileprefixspec)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblClientsfileprefixspec, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblClientsfileprefixspec, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblClientsfileprefixspec, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colCldbname) And razor.UtilSQLServer.IsKeySet(pRowData.colFilePrefixSpec) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[clientsfileprefixspec] " & _
                        "WHERE [cldbname] = @colCldbname AND [FilePrefixSpec] = @colFilePrefixSpec"

                Dim zCmd As New SQLCommand
                zCmd.CommandText = zSQL
                zCmd.Parameters.Add(New SQLParameter("@colCldbname", pRowData.colCldbname))
                zCmd.Parameters.Add(New SQLParameter("@colFilePrefixSpec", pRowData.colFilePrefixSpec))

                zCmd.Transaction=pTransaction
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)

                pRowData.RaiseDeletedEvent(pDeleteEventUserState)

            End If

        End Sub

        Public Shared Sub Delete(pcolCldbname As String, pcolFilePrefixSpec As String)
            Delete(pcolCldbname, pcolFilePrefixSpec, Nothing, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolCldbname As String, pcolFilePrefixSpec As String, pDeleteEventUserState As Object)
            Delete(pcolCldbname, pcolFilePrefixSpec, Nothing, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Delete(pcolCldbname As String, pcolFilePrefixSpec As String, ByRef pTransaction As SqlClient.SqlTransaction)
        Delete(pcolCldbname, pcolFilePrefixSpec, pTransaction, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolCldbname As String, pcolFilePrefixSpec As String, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
        Dim zObj As rowTblClientsfileprefixspec = LoadByPrimaryKey(pcolCldbname, pcolFilePrefixSpec, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblClientsfileprefixspec)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblClientsfileprefixspec, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblClientsfileprefixspec, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colCldbname) And razor.UtilSQLServer.IsKeySet(pRowData.colFilePrefixSpec) Then

                zSQL = "SELECT COUNT(*) from [dbo].[clientsfileprefixspec] WHERE [cldbname] = @colCldbname AND [FilePrefixSpec] = @colFilePrefixSpec"

                Dim zCmdDoesExist As New SQLCommand

                zCmdDoesExist.CommandText = zSQL

                zCmdDoesExist.Parameters.Add(new SQLParameter("@colCldbname", pRowData.colCldbname))
                zCmdDoesExist.Parameters.Add(new SQLParameter("@colFilePrefixSpec", pRowData.colFilePrefixSpec))

                'if zExistInDB > 0  then  PK exists in the DB
                zCmdDoesExist.Transaction = pTransaction
                zExistInDB = razor.UtilSQLServer.ExecuteScalar(zCmdDoesExist)
            End If

            If razor.UtilSQLServer.IsKeySet(pRowData.colCldbname) And razor.UtilSQLServer.IsKeySet(pRowData.colFilePrefixSpec) And zExistInDB > 0 Then
                zMode = "UPDATE"
            End If
            If razor.UtilSQLServer.IsKeySet(pRowData.colCldbname) And razor.UtilSQLServer.IsKeySet(pRowData.colFilePrefixSpec) And zExistInDB = 0 Then
                zMode = "INSERTwithKey"
            End If
            If Not razor.UtilSQLServer.IsKeySet(pRowData.colCldbname) Or Not razor.UtilSQLServer.IsKeySet(pRowData.colFilePrefixSpec) Then
                zMode = "INSERTnoKey"
            End If

            Select Case zMode
                Case "UPDATE"
                    If pRowData.IsDirty Then
                        Dim zUpdate As String = ""
                        Dim zSet As String = ""
                        Dim zWhere As String = ""
                        zUpdate = "UPDATE [dbo].[clientsfileprefixspec] SET " 
                        If pRowData.IsDirty(rowTblClientsfileprefixspec.FieldIndex.colComments) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [Comments] = @colComments "
                        End If
                        zWhere = " WHERE [cldbname] = @colCldbname AND [FilePrefixSpec] = @colFilePrefixSpec"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[clientsfileprefixspec] ([cldbname], [FilePrefixSpec], [Comments])" & _
                            " VALUES (@colCldbname, @colFilePrefixSpec, @colComments); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[clientsfileprefixspec] ([Comments])" & _
                            " VALUES (@colComments); SELECT SCOPE_IDENTITY()"
                Case Else
            End Select

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

			'IF UPDATE, SET PK PARAMETER
            If zMode = "UPDATE" Then
                zCmd.Parameters.Add(New SQLParameter("@colCldbname", pRowData.colCldbname))
                zCmd.Parameters.Add(New SQLParameter("@colFilePrefixSpec", pRowData.colFilePrefixSpec))
            End If

			'IF INSERTING, KEY HAS VALUE AND KEY IS NOT IDENTITY, SET PK PARAMETER
			If zMode = "INSERTwithKey" Then
                zCmd.Parameters.Add(New SQLParameter("@colCldbname", pRowData.colCldbname))
                zCmd.Parameters.Add(New SQLParameter("@colFilePrefixSpec", pRowData.colFilePrefixSpec))
            End If

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblClientsfileprefixspec.FieldIndex.colComments) Then
                    zCmd.Parameters.Add(New SqlParameter("@colComments", IIf(pRowData.colComments Is Nothing, DBNull.Value, pRowData.colComments)))
                End If

            zCmd.Transaction=pTransaction
            If zMode = "INSERTnoKey" Then
                Dim zLastId As Long = 0
                zLastId = razor.UtilSQLServer.ExecuteNonQueryRowId(zCmd)

                pRowData.colCldbname = zLastId
                pRowData.colFilePrefixSpec = zLastId
            Else
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)
            End If

            pRowData.SetIsDirty(False)
            pRowData.RaiseSavedEvent(pSavedEventUserState)

		End If

        End Sub

        Public Shared Function LoadByPrimaryKey(pcolCldbname As String, pcolFilePrefixSpec As String) As rowTblClientsfileprefixspec
            Return LoadByPrimaryKey(pcolCldbname, pcolFilePrefixSpec, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolCldbname As String, pcolFilePrefixSpec As String, pLoadEventUserState As Object) As rowTblClientsfileprefixspec
            Return LoadByPrimaryKey(pcolCldbname, pcolFilePrefixSpec, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolCldbname As String, pcolFilePrefixSpec As String, pTransaction As SqlClient.SqlTransaction) As rowTblClientsfileprefixspec
            Return LoadByPrimaryKey(pcolCldbname, pcolFilePrefixSpec, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolCldbname As String, pcolFilePrefixSpec As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblClientsfileprefixspec
            Dim zReturn As New rowTblClientsfileprefixspec
            Dim zSQL As String = "SELECT * FROM [dbo].[clientsfileprefixspec] WHERE [cldbname] = @colCldbname AND [FilePrefixSpec] = @colFilePrefixSpec"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colCldbname", pcolCldbname))
            zCmd.Parameters.Add(New SQLParameter("@colFilePrefixSpec", pcolFilePrefixSpec))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblClientsfileprefixspec) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK_clientsfileprefixspec(pcolCldbname As String, pcolFilePrefixSpec As String) As List(Of rowTblClientsfileprefixspec)
            Return LoadByIDX_PK_clientsfileprefixspec(pcolCldbname, pcolFilePrefixSpec, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_clientsfileprefixspec(pcolCldbname As String, pcolFilePrefixSpec As String, pLoadEventUserState As Object) As List(Of rowTblClientsfileprefixspec)
            Return LoadByIDX_PK_clientsfileprefixspec(pcolCldbname, pcolFilePrefixSpec, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_clientsfileprefixspec(pcolCldbname As String, pcolFilePrefixSpec As String, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblClientsfileprefixspec)
            Return LoadByIDX_PK_clientsfileprefixspec(pcolCldbname, pcolFilePrefixSpec, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_clientsfileprefixspec(pcolCldbname As String, pcolFilePrefixSpec As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblClientsfileprefixspec)
            Dim zReturn As New List(Of rowTblClientsfileprefixspec)
            Dim zSQL As String = "SELECT * FROM [dbo].[clientsfileprefixspec] WHERE [cldbname] = @colCldbname AND [FilePrefixSpec] = @colFilePrefixSpec"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colCldbname", pcolCldbname))
            zCmd.Parameters.Add(New SQLParameter("@colFilePrefixSpec", pcolFilePrefixSpec))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblClientsfileprefixspec)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblClientsfileprefixspec)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblClientsfileprefixspec)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblClientsfileprefixspec)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblClientsfileprefixspec)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblClientsfileprefixspec)
            Dim zReturn As New List(Of rowTblClientsfileprefixspec)
            Dim zSQL As String = "SELECT * FROM [dbo].[clientsfileprefixspec]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblClientsfileprefixspec)

			Try
	            Dim zReturn As New List(Of rowTblClientsfileprefixspec)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblClientsfileprefixspec

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblClientsfileprefixspec		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblClientsfileprefixspec)
			If Not pReader.IsDBNull(pReader.GetOrdinal("cldbname")) Then pObject.colCldbname = UtilSQLServer.SafeReader.SafeReadString(pReader, "cldbname")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FilePrefixSpec")) Then pObject.colFilePrefixSpec = UtilSQLServer.SafeReader.SafeReadString(pReader, "FilePrefixSpec")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Comments")) Then pObject.colComments = UtilSQLServer.SafeReader.SafeReadString(pReader, "Comments")
			pObject.SetIsDirty(False)
			Return pObject
		End	 Function

    #Region "Reflection Based Load Functions"

        Public Shared Function LoadByPrimaryKey(Of T)(pcolCldbname As String, pcolFilePrefixSpec As String) As T
            Return LoadByPrimaryKey(Of T)(pcolCldbname, pcolFilePrefixSpec, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolCldbname As String, pcolFilePrefixSpec As String, pLoadEventUserState As Object) As T
            Return LoadByPrimaryKey(Of T)(pcolCldbname, pcolFilePrefixSpec, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolCldbname As String, pcolFilePrefixSpec As String, pTransaction As SqlClient.SqlTransaction) As T
            Return LoadByPrimaryKey(Of T)(pcolCldbname, pcolFilePrefixSpec, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolCldbname As String, pcolFilePrefixSpec As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As T

            Dim zReturn As Object = Activator.CreateInstance(Of T)()
            If Not TypeOf zReturn Is rowTblClientsfileprefixspec Then Throw New ArgumentException("Generic type is not type of rowTblClientsfileprefixspec.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[clientsfileprefixspec] WHERE [cldbname] = @colCldbname AND [FilePrefixSpec] = @colFilePrefixSpec"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colCldbname", pcolCldbname))
            zCmd.Parameters.Add(New SQLParameter("@colFilePrefixSpec", pcolFilePrefixSpec))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of T) = ReadData(Of T)(zCmd, pLoadEventUserState)
            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

        End Function

        Public Shared Function LoadByIDX_PK_clientsfileprefixspec(Of T)(pcolCldbname As String, pcolFilePrefixSpec As String) As List(Of T)
            Return LoadByIDX_PK_clientsfileprefixspec(Of T)(pcolCldbname, pcolFilePrefixSpec, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_clientsfileprefixspec(Of T)(pcolCldbname As String, pcolFilePrefixSpec As String, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK_clientsfileprefixspec(Of T)(pcolCldbname, pcolFilePrefixSpec, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_clientsfileprefixspec(Of T)(pcolCldbname As String, pcolFilePrefixSpec As String, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK_clientsfileprefixspec(Of T)(pcolCldbname, pcolFilePrefixSpec, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK_clientsfileprefixspec(Of T)(pcolCldbname As String, pcolFilePrefixSpec As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[clientsfileprefixspec] WHERE [cldbname] = @colCldbname AND [FilePrefixSpec] = @colFilePrefixSpec"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colCldbname", pcolCldbname))
            zCmd.Parameters.Add(New SQLParameter("@colFilePrefixSpec", pcolFilePrefixSpec))

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
            Dim zSQL As String = "SELECT * FROM [dbo].[clientsfileprefixspec]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblClientsfileprefixspec
        Implements IrowTblClientsfileprefixspec

        Public Event Loaded(pUserState As Object) Implements IrowTblClientsfileprefixspec.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblClientsfileprefixspec.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblClientsfileprefixspec.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblClientsfileprefixspec.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblClientsfileprefixspec.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblClientsfileprefixspec.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colCldbname() As String Implements IrowTblClientsfileprefixspec.colCldbname
            Get
                Return m_colCldbname
            End Get
            Set
                If Not Same(m_colCldbname, Value) Then
                    m_colCldbname = Value
                    m_IsDirty(FieldIndex.colCldbname) = True
                End If
            End Set
        End Property
        Private m_colCldbname As String

        Public Property colFilePrefixSpec() As String Implements IrowTblClientsfileprefixspec.colFilePrefixSpec
            Get
                Return m_colFilePrefixSpec
            End Get
            Set
                If Not Same(m_colFilePrefixSpec, Value) Then
                    m_colFilePrefixSpec = Value
                    m_IsDirty(FieldIndex.colFilePrefixSpec) = True
                End If
            End Set
        End Property
        Private m_colFilePrefixSpec As String

        Public Property colComments() As String Implements IrowTblClientsfileprefixspec.colComments
            Get
                Return m_colComments
            End Get
            Set
                If Not Same(m_colComments, Value) Then
                    m_colComments = Value
                    m_IsDirty(FieldIndex.colComments) = True
                End If
            End Set
        End Property
        Private m_colComments As String


        Public Function IsDirty(pIndex As rowTblClientsfileprefixspec.FieldIndex) As Boolean Implements IrowTblClientsfileprefixspec.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblClientsfileprefixspec.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblClientsfileprefixspec.SetIsDirty
            m_IsDirty(FieldIndex.colCldbname) = pDirty
            m_IsDirty(FieldIndex.colFilePrefixSpec) = pDirty
            m_IsDirty(FieldIndex.colComments) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblClientsfileprefixspec) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblClientsfileprefixspec
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colCldbname  = 1
            colFilePrefixSpec 
            colComments 
        End Enum

        Private m_IsDirty(3) As Boolean

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

    Public Interface IrowTblClientsfileprefixspec
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colCldbname() As String
        Property colFilePrefixSpec() As String
        Property colComments() As String
        Function IsDirty(pIndex As rowTblClientsfileprefixspec.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

