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
    Partial Public Class TblMetaInspectionProgramYear

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaInspectionProgramYear)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaInspectionProgramYear, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaInspectionProgramYear, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaInspectionProgramYear, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[tblMetaInspectionProgramYear] " & _
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
        Dim zObj As rowTblMetaInspectionProgramYear = LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblMetaInspectionProgramYear)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaInspectionProgramYear, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaInspectionProgramYear, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[tblMetaInspectionProgramYear] WHERE [fldId] = @colFldId"

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
                        zUpdate = "UPDATE [dbo].[tblMetaInspectionProgramYear] SET " 
                        If pRowData.IsDirty(rowTblMetaInspectionProgramYear.FieldIndex.colFldFilterText) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldFilterText] = @colFldFilterText "
                        End If
                        zWhere = " WHERE [fldId] = @colFldId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaInspectionProgramYear] ([fldFilterText])" & _
                            " VALUES (@colFldFilterText); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaInspectionProgramYear] ([fldFilterText])" & _
                            " VALUES (@colFldFilterText); SELECT SCOPE_IDENTITY()"
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

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaInspectionProgramYear.FieldIndex.colFldFilterText) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldFilterText", IIf(pRowData.colFldFilterText Is Nothing, DBNull.Value, pRowData.colFldFilterText)))
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

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer) As rowTblMetaInspectionProgramYear
            Return LoadByPrimaryKey(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pLoadEventUserState As Object) As rowTblMetaInspectionProgramYear
            Return LoadByPrimaryKey(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblMetaInspectionProgramYear
            Return LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblMetaInspectionProgramYear
            Dim zReturn As New rowTblMetaInspectionProgramYear
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaInspectionProgramYear] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblMetaInspectionProgramYear) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK__tblMetaI__36326BE348331605(pcolFldId As Integer) As List(Of rowTblMetaInspectionProgramYear)
            Return LoadByIDX_PK__tblMetaI__36326BE348331605(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaI__36326BE348331605(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of rowTblMetaInspectionProgramYear)
            Return LoadByIDX_PK__tblMetaI__36326BE348331605(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaI__36326BE348331605(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaInspectionProgramYear)
            Return LoadByIDX_PK__tblMetaI__36326BE348331605(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaI__36326BE348331605(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaInspectionProgramYear)
            Dim zReturn As New List(Of rowTblMetaInspectionProgramYear)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaInspectionProgramYear] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblMetaInspectionProgramYear)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblMetaInspectionProgramYear)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblMetaInspectionProgramYear)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaInspectionProgramYear)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaInspectionProgramYear)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaInspectionProgramYear)
            Dim zReturn As New List(Of rowTblMetaInspectionProgramYear)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaInspectionProgramYear]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblMetaInspectionProgramYear)

			Try
	            Dim zReturn As New List(Of rowTblMetaInspectionProgramYear)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblMetaInspectionProgramYear

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblMetaInspectionProgramYear		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblMetaInspectionProgramYear)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldId")) Then pObject.colFldId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFilterText")) Then pObject.colFldFilterText = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldFilterText")
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
            If Not TypeOf zReturn Is rowTblMetaInspectionProgramYear Then Throw New ArgumentException("Generic type is not type of rowTblMetaInspectionProgramYear.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaInspectionProgramYear] WHERE [fldId] = @colFldId"
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

        Public Shared Function LoadByIDX_PK__tblMetaI__36326BE348331605(Of T)(pcolFldId As Integer) As List(Of T)
            Return LoadByIDX_PK__tblMetaI__36326BE348331605(Of T)(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaI__36326BE348331605(Of T)(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK__tblMetaI__36326BE348331605(Of T)(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaI__36326BE348331605(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK__tblMetaI__36326BE348331605(Of T)(pcolFldId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK__tblMetaI__36326BE348331605(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaInspectionProgramYear] WHERE [fldId] = @colFldId"
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
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaInspectionProgramYear]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblMetaInspectionProgramYear
        Implements IrowTblMetaInspectionProgramYear

        Public Event Loaded(pUserState As Object) Implements IrowTblMetaInspectionProgramYear.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblMetaInspectionProgramYear.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblMetaInspectionProgramYear.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblMetaInspectionProgramYear.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblMetaInspectionProgramYear.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblMetaInspectionProgramYear.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldId() As Nullable(Of Integer) Implements IrowTblMetaInspectionProgramYear.colFldId
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

        Public Property colFldFilterText() As String Implements IrowTblMetaInspectionProgramYear.colFldFilterText
            Get
                Return m_colFldFilterText
            End Get
            Set
                If Not Same(m_colFldFilterText, Value) Then
                    m_colFldFilterText = Value
                    m_IsDirty(FieldIndex.colFldFilterText) = True
                End If
            End Set
        End Property
        Private m_colFldFilterText As String


        Public Function IsDirty(pIndex As rowTblMetaInspectionProgramYear.FieldIndex) As Boolean Implements IrowTblMetaInspectionProgramYear.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblMetaInspectionProgramYear.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblMetaInspectionProgramYear.SetIsDirty
            m_IsDirty(FieldIndex.colFldId) = pDirty
            m_IsDirty(FieldIndex.colFldFilterText) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblMetaInspectionProgramYear) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblMetaInspectionProgramYear
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldId  = 1
            colFldFilterText 
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

    Public Interface IrowTblMetaInspectionProgramYear
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldId() As Nullable(Of Integer)
        Property colFldFilterText() As String
        Function IsDirty(pIndex As rowTblMetaInspectionProgramYear.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

