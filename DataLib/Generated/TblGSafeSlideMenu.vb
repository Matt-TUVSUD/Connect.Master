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
    Partial Public Class TblGSafeSlideMenu

        Public Shared Sub Delete(ByRef pRowData As IrowTblGSafeSlideMenu)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblGSafeSlideMenu, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblGSafeSlideMenu, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblGSafeSlideMenu, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colGSafeSlideMenuId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[GSafeSlideMenu] " & _
                        "WHERE [GSafeSlideMenuId] = @colGSafeSlideMenuId"

                Dim zCmd As New SQLCommand
                zCmd.CommandText = zSQL
                zCmd.Parameters.Add(New SQLParameter("@colGSafeSlideMenuId", pRowData.colGSafeSlideMenuId))

                zCmd.Transaction=pTransaction
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)

                pRowData.RaiseDeletedEvent(pDeleteEventUserState)

            End If

        End Sub

        Public Shared Sub Delete(pcolGSafeSlideMenuId As Integer)
            Delete(pcolGSafeSlideMenuId, Nothing, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolGSafeSlideMenuId As Integer, pDeleteEventUserState As Object)
            Delete(pcolGSafeSlideMenuId, Nothing, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Delete(pcolGSafeSlideMenuId As Integer, ByRef pTransaction As SqlClient.SqlTransaction)
        Delete(pcolGSafeSlideMenuId, pTransaction, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolGSafeSlideMenuId As Integer, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
        Dim zObj As rowTblGSafeSlideMenu = LoadByPrimaryKey(pcolGSafeSlideMenuId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblGSafeSlideMenu)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblGSafeSlideMenu, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblGSafeSlideMenu, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colGSafeSlideMenuId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[GSafeSlideMenu] WHERE [GSafeSlideMenuId] = @colGSafeSlideMenuId"

                Dim zCmdDoesExist As New SQLCommand

                zCmdDoesExist.CommandText = zSQL

                zCmdDoesExist.Parameters.Add(new SQLParameter("@colGSafeSlideMenuId", pRowData.colGSafeSlideMenuId))

                'if zExistInDB > 0  then  PK exists in the DB
                zCmdDoesExist.Transaction = pTransaction
                zExistInDB = razor.UtilSQLServer.ExecuteScalar(zCmdDoesExist)
            End If

            If razor.UtilSQLServer.IsKeySet(pRowData.colGSafeSlideMenuId) And zExistInDB > 0 Then
                zMode = "UPDATE"
            End If
            If razor.UtilSQLServer.IsKeySet(pRowData.colGSafeSlideMenuId) And zExistInDB = 0 Then
                zMode = "INSERTwithKey"
            End If
            If Not razor.UtilSQLServer.IsKeySet(pRowData.colGSafeSlideMenuId) Then
                zMode = "INSERTnoKey"
            End If

            Select Case zMode
                Case "UPDATE"
                    If pRowData.IsDirty Then
                        Dim zUpdate As String = ""
                        Dim zSet As String = ""
                        Dim zWhere As String = ""
                        zUpdate = "UPDATE [dbo].[GSafeSlideMenu] SET " 
                        If pRowData.IsDirty(rowTblGSafeSlideMenu.FieldIndex.colGSafeId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [GSafeId] = @colGSafeId "
                        End If
                        If pRowData.IsDirty(rowTblGSafeSlideMenu.FieldIndex.colSlideMenuJSON) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [SlideMenuJSON] = @colSlideMenuJSON "
                        End If
                        If pRowData.IsDirty(rowTblGSafeSlideMenu.FieldIndex.colSlideType) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [SlideType] = @colSlideType "
                        End If
                        zWhere = " WHERE [GSafeSlideMenuId] = @colGSafeSlideMenuId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[GSafeSlideMenu] ([GSafeId], [SlideMenuJSON], [SlideType])" & _
                            " VALUES (@colGSafeId, @colSlideMenuJSON, @colSlideType); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[GSafeSlideMenu] ([GSafeId], [SlideMenuJSON], [SlideType])" & _
                            " VALUES (@colGSafeId, @colSlideMenuJSON, @colSlideType); SELECT SCOPE_IDENTITY()"
                Case Else
            End Select

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

			'IF UPDATE, SET PK PARAMETER
            If zMode = "UPDATE" Then
                zCmd.Parameters.Add(New SQLParameter("@colGSafeSlideMenuId", pRowData.colGSafeSlideMenuId))
            End If

			'IF INSERTING, KEY HAS VALUE AND KEY IS NOT IDENTITY, SET PK PARAMETER
			If zMode = "INSERTwithKey" Then
            End If

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblGSafeSlideMenu.FieldIndex.colGSafeId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colGSafeId", IIf(pRowData.colGSafeId Is Nothing, DBNull.Value, pRowData.colGSafeId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblGSafeSlideMenu.FieldIndex.colSlideMenuJSON) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSlideMenuJSON", IIf(pRowData.colSlideMenuJSON Is Nothing, DBNull.Value, pRowData.colSlideMenuJSON)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblGSafeSlideMenu.FieldIndex.colSlideType) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSlideType", IIf(pRowData.colSlideType Is Nothing, DBNull.Value, pRowData.colSlideType)))
                End If

            zCmd.Transaction=pTransaction
            If zMode = "INSERTnoKey" Then
                Dim zLastId As Long = 0
                zLastId = razor.UtilSQLServer.ExecuteNonQueryRowId(zCmd)

                pRowData.colGSafeSlideMenuId = zLastId
            Else
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)
            End If

            pRowData.SetIsDirty(False)
            pRowData.RaiseSavedEvent(pSavedEventUserState)

		End If

        End Sub

        Public Shared Function LoadByPrimaryKey(pcolGSafeSlideMenuId As Integer) As rowTblGSafeSlideMenu
            Return LoadByPrimaryKey(pcolGSafeSlideMenuId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolGSafeSlideMenuId As Integer, pLoadEventUserState As Object) As rowTblGSafeSlideMenu
            Return LoadByPrimaryKey(pcolGSafeSlideMenuId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolGSafeSlideMenuId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblGSafeSlideMenu
            Return LoadByPrimaryKey(pcolGSafeSlideMenuId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolGSafeSlideMenuId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblGSafeSlideMenu
            Dim zReturn As New rowTblGSafeSlideMenu
            Dim zSQL As String = "SELECT * FROM [dbo].[GSafeSlideMenu] WHERE [GSafeSlideMenuId] = @colGSafeSlideMenuId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colGSafeSlideMenuId", pcolGSafeSlideMenuId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblGSafeSlideMenu) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK_GSafeSlideMenu(pcolGSafeSlideMenuId As Integer) As List(Of rowTblGSafeSlideMenu)
            Return LoadByIDX_PK_GSafeSlideMenu(pcolGSafeSlideMenuId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_GSafeSlideMenu(pcolGSafeSlideMenuId As Integer, pLoadEventUserState As Object) As List(Of rowTblGSafeSlideMenu)
            Return LoadByIDX_PK_GSafeSlideMenu(pcolGSafeSlideMenuId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_GSafeSlideMenu(pcolGSafeSlideMenuId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblGSafeSlideMenu)
            Return LoadByIDX_PK_GSafeSlideMenu(pcolGSafeSlideMenuId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_GSafeSlideMenu(pcolGSafeSlideMenuId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblGSafeSlideMenu)
            Dim zReturn As New List(Of rowTblGSafeSlideMenu)
            Dim zSQL As String = "SELECT * FROM [dbo].[GSafeSlideMenu] WHERE [GSafeSlideMenuId] = @colGSafeSlideMenuId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colGSafeSlideMenuId", pcolGSafeSlideMenuId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblGSafeSlideMenu)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblGSafeSlideMenu)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblGSafeSlideMenu)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblGSafeSlideMenu)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblGSafeSlideMenu)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblGSafeSlideMenu)
            Dim zReturn As New List(Of rowTblGSafeSlideMenu)
            Dim zSQL As String = "SELECT * FROM [dbo].[GSafeSlideMenu]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblGSafeSlideMenu)

			Try
	            Dim zReturn As New List(Of rowTblGSafeSlideMenu)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblGSafeSlideMenu

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblGSafeSlideMenu		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblGSafeSlideMenu)
			If Not pReader.IsDBNull(pReader.GetOrdinal("GSafeId")) Then pObject.colGSafeId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "GSafeId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SlideMenuJSON")) Then pObject.colSlideMenuJSON = UtilSQLServer.SafeReader.SafeReadString(pReader, "SlideMenuJSON")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SlideType")) Then pObject.colSlideType = UtilSQLServer.SafeReader.SafeReadString(pReader, "SlideType")
			If Not pReader.IsDBNull(pReader.GetOrdinal("GSafeSlideMenuId")) Then pObject.colGSafeSlideMenuId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "GSafeSlideMenuId")
			pObject.SetIsDirty(False)
			Return pObject
		End	 Function

    #Region "Reflection Based Load Functions"

        Public Shared Function LoadByPrimaryKey(Of T)(pcolGSafeSlideMenuId As Integer) As T
            Return LoadByPrimaryKey(Of T)(pcolGSafeSlideMenuId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolGSafeSlideMenuId As Integer, pLoadEventUserState As Object) As T
            Return LoadByPrimaryKey(Of T)(pcolGSafeSlideMenuId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolGSafeSlideMenuId As Integer, pTransaction As SqlClient.SqlTransaction) As T
            Return LoadByPrimaryKey(Of T)(pcolGSafeSlideMenuId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolGSafeSlideMenuId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As T

            Dim zReturn As Object = Activator.CreateInstance(Of T)()
            If Not TypeOf zReturn Is rowTblGSafeSlideMenu Then Throw New ArgumentException("Generic type is not type of rowTblGSafeSlideMenu.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[GSafeSlideMenu] WHERE [GSafeSlideMenuId] = @colGSafeSlideMenuId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colGSafeSlideMenuId", pcolGSafeSlideMenuId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of T) = ReadData(Of T)(zCmd, pLoadEventUserState)
            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

        End Function

        Public Shared Function LoadByIDX_PK_GSafeSlideMenu(Of T)(pcolGSafeSlideMenuId As Integer) As List(Of T)
            Return LoadByIDX_PK_GSafeSlideMenu(Of T)(pcolGSafeSlideMenuId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_GSafeSlideMenu(Of T)(pcolGSafeSlideMenuId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK_GSafeSlideMenu(Of T)(pcolGSafeSlideMenuId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_GSafeSlideMenu(Of T)(pcolGSafeSlideMenuId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK_GSafeSlideMenu(Of T)(pcolGSafeSlideMenuId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK_GSafeSlideMenu(Of T)(pcolGSafeSlideMenuId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[GSafeSlideMenu] WHERE [GSafeSlideMenuId] = @colGSafeSlideMenuId"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colGSafeSlideMenuId", pcolGSafeSlideMenuId))

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
            Dim zSQL As String = "SELECT * FROM [dbo].[GSafeSlideMenu]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblGSafeSlideMenu
        Implements IrowTblGSafeSlideMenu

        Public Event Loaded(pUserState As Object) Implements IrowTblGSafeSlideMenu.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblGSafeSlideMenu.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblGSafeSlideMenu.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblGSafeSlideMenu.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblGSafeSlideMenu.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblGSafeSlideMenu.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colGSafeId() As Nullable(Of Integer) Implements IrowTblGSafeSlideMenu.colGSafeId
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

        Public Property colSlideMenuJSON() As String Implements IrowTblGSafeSlideMenu.colSlideMenuJSON
            Get
                Return m_colSlideMenuJSON
            End Get
            Set
                If Not Same(m_colSlideMenuJSON, Value) Then
                    m_colSlideMenuJSON = Value
                    m_IsDirty(FieldIndex.colSlideMenuJSON) = True
                End If
            End Set
        End Property
        Private m_colSlideMenuJSON As String

        Public Property colSlideType() As String Implements IrowTblGSafeSlideMenu.colSlideType
            Get
                Return m_colSlideType
            End Get
            Set
                If Not Same(m_colSlideType, Value) Then
                    m_colSlideType = Value
                    m_IsDirty(FieldIndex.colSlideType) = True
                End If
            End Set
        End Property
        Private m_colSlideType As String

        Public Property colGSafeSlideMenuId() As Nullable(Of Integer) Implements IrowTblGSafeSlideMenu.colGSafeSlideMenuId
            Get
                Return m_colGSafeSlideMenuId
            End Get
            Set
                If Not Same(m_colGSafeSlideMenuId, Value) Then
                    m_colGSafeSlideMenuId = Value
                    m_IsDirty(FieldIndex.colGSafeSlideMenuId) = True
                End If
            End Set
        End Property
        Private m_colGSafeSlideMenuId As Nullable(Of Integer)


        Public Function IsDirty(pIndex As rowTblGSafeSlideMenu.FieldIndex) As Boolean Implements IrowTblGSafeSlideMenu.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblGSafeSlideMenu.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblGSafeSlideMenu.SetIsDirty
            m_IsDirty(FieldIndex.colGSafeId) = pDirty
            m_IsDirty(FieldIndex.colSlideMenuJSON) = pDirty
            m_IsDirty(FieldIndex.colSlideType) = pDirty
            m_IsDirty(FieldIndex.colGSafeSlideMenuId) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblGSafeSlideMenu) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblGSafeSlideMenu
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colGSafeId  = 1
            colSlideMenuJSON 
            colSlideType 
            colGSafeSlideMenuId 
        End Enum

        Private m_IsDirty(4) As Boolean

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

    Public Interface IrowTblGSafeSlideMenu
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colGSafeId() As Nullable(Of Integer)
        Property colSlideMenuJSON() As String
        Property colSlideType() As String
        Property colGSafeSlideMenuId() As Nullable(Of Integer)
        Function IsDirty(pIndex As rowTblGSafeSlideMenu.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

