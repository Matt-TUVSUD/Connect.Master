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
    Partial Public Class TblWhatsNew

        Public Shared Sub Delete(ByRef pRowData As IrowTblWhatsNew)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblWhatsNew, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblWhatsNew, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblWhatsNew, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[tblWhatsNew] " & _
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
        Dim zObj As rowTblWhatsNew = LoadByPrimaryKey(pcolId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblWhatsNew)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblWhatsNew, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblWhatsNew, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[tblWhatsNew] WHERE [ID] = @colId"

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
                        zUpdate = "UPDATE [dbo].[tblWhatsNew] SET " 
                        If pRowData.IsDirty(rowTblWhatsNew.FieldIndex.colTitle) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [Title] = @colTitle "
                        End If
                        If pRowData.IsDirty(rowTblWhatsNew.FieldIndex.colPostDate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [PostDate] = @colPostDate "
                        End If
                        If pRowData.IsDirty(rowTblWhatsNew.FieldIndex.colComments) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [Comments] = @colComments "
                        End If
                        zWhere = " WHERE [ID] = @colId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[tblWhatsNew] ([Title], [PostDate], [Comments])" & _
                            " VALUES (@colTitle, @colPostDate, @colComments); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[tblWhatsNew] ([Title], [PostDate], [Comments])" & _
                            " VALUES (@colTitle, @colPostDate, @colComments); SELECT SCOPE_IDENTITY()"
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

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatsNew.FieldIndex.colTitle) Then
                    zCmd.Parameters.Add(New SqlParameter("@colTitle", IIf(pRowData.colTitle Is Nothing, DBNull.Value, pRowData.colTitle)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatsNew.FieldIndex.colPostDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colPostDate", IIf(pRowData.colPostDate Is Nothing, DBNull.Value, pRowData.colPostDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblWhatsNew.FieldIndex.colComments) Then
                    zCmd.Parameters.Add(New SqlParameter("@colComments", IIf(pRowData.colComments Is Nothing, DBNull.Value, pRowData.colComments)))
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

        Public Shared Function LoadByPrimaryKey(pcolId As Integer) As rowTblWhatsNew
            Return LoadByPrimaryKey(pcolId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolId As Integer, pLoadEventUserState As Object) As rowTblWhatsNew
            Return LoadByPrimaryKey(pcolId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblWhatsNew
            Return LoadByPrimaryKey(pcolId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblWhatsNew
            Dim zReturn As New rowTblWhatsNew
            Dim zSQL As String = "SELECT * FROM [dbo].[tblWhatsNew] WHERE [ID] = @colId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colId", pcolId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblWhatsNew) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK__tblWhats__3214EC273F73B2D2(pcolId As Integer) As List(Of rowTblWhatsNew)
            Return LoadByIDX_PK__tblWhats__3214EC273F73B2D2(pcolId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblWhats__3214EC273F73B2D2(pcolId As Integer, pLoadEventUserState As Object) As List(Of rowTblWhatsNew)
            Return LoadByIDX_PK__tblWhats__3214EC273F73B2D2(pcolId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblWhats__3214EC273F73B2D2(pcolId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblWhatsNew)
            Return LoadByIDX_PK__tblWhats__3214EC273F73B2D2(pcolId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblWhats__3214EC273F73B2D2(pcolId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblWhatsNew)
            Dim zReturn As New List(Of rowTblWhatsNew)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblWhatsNew] WHERE [ID] = @colId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colId", pcolId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblWhatsNew)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblWhatsNew)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblWhatsNew)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblWhatsNew)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblWhatsNew)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblWhatsNew)
            Dim zReturn As New List(Of rowTblWhatsNew)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblWhatsNew]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblWhatsNew)

			Try
	            Dim zReturn As New List(Of rowTblWhatsNew)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblWhatsNew

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblWhatsNew		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblWhatsNew)
			If Not pReader.IsDBNull(pReader.GetOrdinal("ID")) Then pObject.colId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "ID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Title")) Then pObject.colTitle = UtilSQLServer.SafeReader.SafeReadString(pReader, "Title")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PostDate")) Then pObject.colPostDate = UtilSQLServer.SafeReader.SafeReadDate(pReader, "PostDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Comments")) Then pObject.colComments = UtilSQLServer.SafeReader.SafeReadString(pReader, "Comments")
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
            If Not TypeOf zReturn Is rowTblWhatsNew Then Throw New ArgumentException("Generic type is not type of rowTblWhatsNew.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[tblWhatsNew] WHERE [ID] = @colId"
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

        Public Shared Function LoadByIDX_PK__tblWhats__3214EC273F73B2D2(Of T)(pcolId As Integer) As List(Of T)
            Return LoadByIDX_PK__tblWhats__3214EC273F73B2D2(Of T)(pcolId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblWhats__3214EC273F73B2D2(Of T)(pcolId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK__tblWhats__3214EC273F73B2D2(Of T)(pcolId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblWhats__3214EC273F73B2D2(Of T)(pcolId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK__tblWhats__3214EC273F73B2D2(Of T)(pcolId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK__tblWhats__3214EC273F73B2D2(Of T)(pcolId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblWhatsNew] WHERE [ID] = @colId"
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
            Dim zSQL As String = "SELECT * FROM [dbo].[tblWhatsNew]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblWhatsNew
        Implements IrowTblWhatsNew

        Public Event Loaded(pUserState As Object) Implements IrowTblWhatsNew.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblWhatsNew.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblWhatsNew.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblWhatsNew.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblWhatsNew.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblWhatsNew.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colId() As Nullable(Of Integer) Implements IrowTblWhatsNew.colId
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

        Public Property colTitle() As String Implements IrowTblWhatsNew.colTitle
            Get
                Return m_colTitle
            End Get
            Set
                If Not Same(m_colTitle, Value) Then
                    m_colTitle = Value
                    m_IsDirty(FieldIndex.colTitle) = True
                End If
            End Set
        End Property
        Private m_colTitle As String

        Public Property colPostDate() As Nullable(Of Date) Implements IrowTblWhatsNew.colPostDate
            Get
                Return m_colPostDate
            End Get
            Set
                If Not Same(m_colPostDate, Value) Then
                    m_colPostDate = Value
                    m_IsDirty(FieldIndex.colPostDate) = True
                End If
            End Set
        End Property
        Private m_colPostDate As Nullable(Of Date)

        Public Property colComments() As String Implements IrowTblWhatsNew.colComments
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


        Public Function IsDirty(pIndex As rowTblWhatsNew.FieldIndex) As Boolean Implements IrowTblWhatsNew.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblWhatsNew.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblWhatsNew.SetIsDirty
            m_IsDirty(FieldIndex.colId) = pDirty
            m_IsDirty(FieldIndex.colTitle) = pDirty
            m_IsDirty(FieldIndex.colPostDate) = pDirty
            m_IsDirty(FieldIndex.colComments) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblWhatsNew) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblWhatsNew
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colId  = 1
            colTitle 
            colPostDate 
            colComments 
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

    Public Interface IrowTblWhatsNew
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colId() As Nullable(Of Integer)
        Property colTitle() As String
        Property colPostDate() As Nullable(Of Date)
        Property colComments() As String
        Function IsDirty(pIndex As rowTblWhatsNew.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

