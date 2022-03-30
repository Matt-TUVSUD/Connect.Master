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
    Partial Public Class TblWhatIfLocationSelected

        Public Shared Sub Delete(ByRef pRowData As IrowTblWhatIfLocationSelected)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblWhatIfLocationSelected, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblWhatIfLocationSelected, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblWhatIfLocationSelected, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldGSafeId) And razor.UtilSQLServer.IsKeySet(pRowData.colFldFileNo) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[TblWhatIfLocationSelected] " & _
                        "WHERE [fldGSafeId] = @colFldGSafeId AND [fldFileNo] = @colFldFileNo"

                Dim zCmd As New SQLCommand
                zCmd.CommandText = zSQL
                zCmd.Parameters.Add(New SQLParameter("@colFldGSafeId", pRowData.colFldGSafeId))
                zCmd.Parameters.Add(New SQLParameter("@colFldFileNo", pRowData.colFldFileNo))

                zCmd.Transaction=pTransaction
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)

                pRowData.RaiseDeletedEvent(pDeleteEventUserState)

            End If

        End Sub

        Public Shared Sub Delete(pcolFldGSafeId As Integer, pcolFldFileNo As String)
            Delete(pcolFldGSafeId, pcolFldFileNo, Nothing, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolFldGSafeId As Integer, pcolFldFileNo As String, pDeleteEventUserState As Object)
            Delete(pcolFldGSafeId, pcolFldFileNo, Nothing, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Delete(pcolFldGSafeId As Integer, pcolFldFileNo As String, ByRef pTransaction As SqlClient.SqlTransaction)
        Delete(pcolFldGSafeId, pcolFldFileNo, pTransaction, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolFldGSafeId As Integer, pcolFldFileNo As String, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
        Dim zObj As rowTblWhatIfLocationSelected = LoadByPrimaryKey(pcolFldGSafeId, pcolFldFileNo, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblWhatIfLocationSelected)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblWhatIfLocationSelected, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblWhatIfLocationSelected, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldGSafeId) And razor.UtilSQLServer.IsKeySet(pRowData.colFldFileNo) Then

                zSQL = "SELECT COUNT(*) from [dbo].[TblWhatIfLocationSelected] WHERE [fldGSafeId] = @colFldGSafeId AND [fldFileNo] = @colFldFileNo"

                Dim zCmdDoesExist As New SQLCommand

                zCmdDoesExist.CommandText = zSQL

                zCmdDoesExist.Parameters.Add(new SQLParameter("@colFldGSafeId", pRowData.colFldGSafeId))
                zCmdDoesExist.Parameters.Add(new SQLParameter("@colFldFileNo", pRowData.colFldFileNo))

                'if zExistInDB > 0  then  PK exists in the DB
                zCmdDoesExist.Transaction = pTransaction
                zExistInDB = razor.UtilSQLServer.ExecuteScalar(zCmdDoesExist)
            End If

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldGSafeId) And razor.UtilSQLServer.IsKeySet(pRowData.colFldFileNo) And zExistInDB > 0 Then
                zMode = "UPDATE"
            End If
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldGSafeId) And razor.UtilSQLServer.IsKeySet(pRowData.colFldFileNo) And zExistInDB = 0 Then
                zMode = "INSERTwithKey"
            End If
            If Not razor.UtilSQLServer.IsKeySet(pRowData.colFldGSafeId) Or Not razor.UtilSQLServer.IsKeySet(pRowData.colFldFileNo) Then
                zMode = "INSERTnoKey"
            End If

            Select Case zMode
                Case "UPDATE"
                    If pRowData.IsDirty Then
                        Dim zUpdate As String = ""
                        Dim zSet As String = ""
                        Dim zWhere As String = ""
                        zUpdate = "UPDATE [dbo].[TblWhatIfLocationSelected] SET " 
                        zWhere = " WHERE [fldGSafeId] = @colFldGSafeId AND [fldFileNo] = @colFldFileNo"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[TblWhatIfLocationSelected] ([fldGSafeId], [fldFileNo])" & _
                            " VALUES (@colFldGSafeId, @colFldFileNo); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[TblWhatIfLocationSelected] ()" & _
                            " VALUES (); SELECT SCOPE_IDENTITY()"
                Case Else
            End Select

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

			'IF UPDATE, SET PK PARAMETER
            If zMode = "UPDATE" Then
                zCmd.Parameters.Add(New SQLParameter("@colFldGSafeId", pRowData.colFldGSafeId))
                zCmd.Parameters.Add(New SQLParameter("@colFldFileNo", pRowData.colFldFileNo))
            End If

			'IF INSERTING, KEY HAS VALUE AND KEY IS NOT IDENTITY, SET PK PARAMETER
			If zMode = "INSERTwithKey" Then
                zCmd.Parameters.Add(New SQLParameter("@colFldGSafeId", pRowData.colFldGSafeId))
                zCmd.Parameters.Add(New SQLParameter("@colFldFileNo", pRowData.colFldFileNo))
            End If


            zCmd.Transaction=pTransaction
            If zMode = "INSERTnoKey" Then
                Dim zLastId As Long = 0
                zLastId = razor.UtilSQLServer.ExecuteNonQueryRowId(zCmd)

                pRowData.colFldGSafeId = zLastId
                pRowData.colFldFileNo = zLastId
            Else
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)
            End If

            pRowData.SetIsDirty(False)
            pRowData.RaiseSavedEvent(pSavedEventUserState)

		End If

        End Sub

        Public Shared Function LoadByPrimaryKey(pcolFldGSafeId As Integer, pcolFldFileNo As String) As rowTblWhatIfLocationSelected
            Return LoadByPrimaryKey(pcolFldGSafeId, pcolFldFileNo, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldGSafeId As Integer, pcolFldFileNo As String, pLoadEventUserState As Object) As rowTblWhatIfLocationSelected
            Return LoadByPrimaryKey(pcolFldGSafeId, pcolFldFileNo, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldGSafeId As Integer, pcolFldFileNo As String, pTransaction As SqlClient.SqlTransaction) As rowTblWhatIfLocationSelected
            Return LoadByPrimaryKey(pcolFldGSafeId, pcolFldFileNo, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldGSafeId As Integer, pcolFldFileNo As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblWhatIfLocationSelected
            Dim zReturn As New rowTblWhatIfLocationSelected
            Dim zSQL As String = "SELECT * FROM [dbo].[TblWhatIfLocationSelected] WHERE [fldGSafeId] = @colFldGSafeId AND [fldFileNo] = @colFldFileNo"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldGSafeId", pcolFldGSafeId))
            zCmd.Parameters.Add(New SQLParameter("@colFldFileNo", pcolFldFileNo))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblWhatIfLocationSelected) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK_tblWhatIfLocationFilter(pcolFldGSafeId As Integer, pcolFldFileNo As String) As List(Of rowTblWhatIfLocationSelected)
            Return LoadByIDX_PK_tblWhatIfLocationFilter(pcolFldGSafeId, pcolFldFileNo, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblWhatIfLocationFilter(pcolFldGSafeId As Integer, pcolFldFileNo As String, pLoadEventUserState As Object) As List(Of rowTblWhatIfLocationSelected)
            Return LoadByIDX_PK_tblWhatIfLocationFilter(pcolFldGSafeId, pcolFldFileNo, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_tblWhatIfLocationFilter(pcolFldGSafeId As Integer, pcolFldFileNo As String, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblWhatIfLocationSelected)
            Return LoadByIDX_PK_tblWhatIfLocationFilter(pcolFldGSafeId, pcolFldFileNo, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblWhatIfLocationFilter(pcolFldGSafeId As Integer, pcolFldFileNo As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblWhatIfLocationSelected)
            Dim zReturn As New List(Of rowTblWhatIfLocationSelected)
            Dim zSQL As String = "SELECT * FROM [dbo].[TblWhatIfLocationSelected] WHERE [fldGSafeId] = @colFldGSafeId AND [fldFileNo] = @colFldFileNo"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldGSafeId", pcolFldGSafeId))
            zCmd.Parameters.Add(New SQLParameter("@colFldFileNo", pcolFldFileNo))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblWhatIfLocationSelected)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblWhatIfLocationSelected)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblWhatIfLocationSelected)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblWhatIfLocationSelected)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblWhatIfLocationSelected)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblWhatIfLocationSelected)
            Dim zReturn As New List(Of rowTblWhatIfLocationSelected)
            Dim zSQL As String = "SELECT * FROM [dbo].[TblWhatIfLocationSelected]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblWhatIfLocationSelected)

			Try
	            Dim zReturn As New List(Of rowTblWhatIfLocationSelected)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblWhatIfLocationSelected

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblWhatIfLocationSelected		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblWhatIfLocationSelected)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldGSafeId")) Then pObject.colFldGSafeId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldGSafeId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFileNo")) Then pObject.colFldFileNo = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldFileNo")
			pObject.SetIsDirty(False)
			Return pObject
		End	 Function

    #Region "Reflection Based Load Functions"

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldGSafeId As Integer, pcolFldFileNo As String) As T
            Return LoadByPrimaryKey(Of T)(pcolFldGSafeId, pcolFldFileNo, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldGSafeId As Integer, pcolFldFileNo As String, pLoadEventUserState As Object) As T
            Return LoadByPrimaryKey(Of T)(pcolFldGSafeId, pcolFldFileNo, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldGSafeId As Integer, pcolFldFileNo As String, pTransaction As SqlClient.SqlTransaction) As T
            Return LoadByPrimaryKey(Of T)(pcolFldGSafeId, pcolFldFileNo, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldGSafeId As Integer, pcolFldFileNo As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As T

            Dim zReturn As Object = Activator.CreateInstance(Of T)()
            If Not TypeOf zReturn Is rowTblWhatIfLocationSelected Then Throw New ArgumentException("Generic type is not type of rowTblWhatIfLocationSelected.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[TblWhatIfLocationSelected] WHERE [fldGSafeId] = @colFldGSafeId AND [fldFileNo] = @colFldFileNo"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldGSafeId", pcolFldGSafeId))
            zCmd.Parameters.Add(New SQLParameter("@colFldFileNo", pcolFldFileNo))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of T) = ReadData(Of T)(zCmd, pLoadEventUserState)
            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

        End Function

        Public Shared Function LoadByIDX_PK_tblWhatIfLocationFilter(Of T)(pcolFldGSafeId As Integer, pcolFldFileNo As String) As List(Of T)
            Return LoadByIDX_PK_tblWhatIfLocationFilter(Of T)(pcolFldGSafeId, pcolFldFileNo, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblWhatIfLocationFilter(Of T)(pcolFldGSafeId As Integer, pcolFldFileNo As String, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK_tblWhatIfLocationFilter(Of T)(pcolFldGSafeId, pcolFldFileNo, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_tblWhatIfLocationFilter(Of T)(pcolFldGSafeId As Integer, pcolFldFileNo As String, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK_tblWhatIfLocationFilter(Of T)(pcolFldGSafeId, pcolFldFileNo, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK_tblWhatIfLocationFilter(Of T)(pcolFldGSafeId As Integer, pcolFldFileNo As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[TblWhatIfLocationSelected] WHERE [fldGSafeId] = @colFldGSafeId AND [fldFileNo] = @colFldFileNo"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldGSafeId", pcolFldGSafeId))
            zCmd.Parameters.Add(New SQLParameter("@colFldFileNo", pcolFldFileNo))

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
            Dim zSQL As String = "SELECT * FROM [dbo].[TblWhatIfLocationSelected]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblWhatIfLocationSelected
        Implements IrowTblWhatIfLocationSelected

        Public Event Loaded(pUserState As Object) Implements IrowTblWhatIfLocationSelected.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblWhatIfLocationSelected.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblWhatIfLocationSelected.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblWhatIfLocationSelected.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblWhatIfLocationSelected.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblWhatIfLocationSelected.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldGSafeId() As Nullable(Of Integer) Implements IrowTblWhatIfLocationSelected.colFldGSafeId
            Get
                Return m_colFldGSafeId
            End Get
            Set
                If Not Same(m_colFldGSafeId, Value) Then
                    m_colFldGSafeId = Value
                    m_IsDirty(FieldIndex.colFldGSafeId) = True
                End If
            End Set
        End Property
        Private m_colFldGSafeId As Nullable(Of Integer)

        Public Property colFldFileNo() As String Implements IrowTblWhatIfLocationSelected.colFldFileNo
            Get
                Return m_colFldFileNo
            End Get
            Set
                If Not Same(m_colFldFileNo, Value) Then
                    m_colFldFileNo = Value
                    m_IsDirty(FieldIndex.colFldFileNo) = True
                End If
            End Set
        End Property
        Private m_colFldFileNo As String


        Public Function IsDirty(pIndex As rowTblWhatIfLocationSelected.FieldIndex) As Boolean Implements IrowTblWhatIfLocationSelected.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblWhatIfLocationSelected.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblWhatIfLocationSelected.SetIsDirty
            m_IsDirty(FieldIndex.colFldGSafeId) = pDirty
            m_IsDirty(FieldIndex.colFldFileNo) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblWhatIfLocationSelected) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblWhatIfLocationSelected
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldGSafeId  = 1
            colFldFileNo 
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

    Public Interface IrowTblWhatIfLocationSelected
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldGSafeId() As Nullable(Of Integer)
        Property colFldFileNo() As String
        Function IsDirty(pIndex As rowTblWhatIfLocationSelected.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

