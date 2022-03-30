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
    Partial Public Class VwActiveAccountServiceContact

        Public Shared Function LoadData() As List(Of rowVwActiveAccountServiceContact)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwActiveAccountServiceContact)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwActiveAccountServiceContact)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwActiveAccountServiceContact)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwActiveAccountServiceContact)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwActiveAccountServiceContact)
            Dim zReturn As New List(Of rowVwActiveAccountServiceContact)
            Dim zSQL As String = "SELECT * FROM [dbo].[vwActiveAccountServiceContact]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwActiveAccountServiceContact)

			Try
	            Dim zReturn As New List(Of rowVwActiveAccountServiceContact)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwActiveAccountServiceContact

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwActiveAccountServiceContact		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwActiveAccountServiceContact)
			If Not pReader.IsDBNull(pReader.GetOrdinal("FilePrefix")) Then pObject.colFilePrefix = UtilSQLServer.SafeReader.SafeReadString(pReader, "FilePrefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RoleSort")) Then pObject.colRoleSort = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "RoleSort")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RoleCd")) Then pObject.colRoleCd = UtilSQLServer.SafeReader.SafeReadString(pReader, "RoleCd")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RoleDescription")) Then pObject.colRoleDescription = UtilSQLServer.SafeReader.SafeReadString(pReader, "RoleDescription")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RoleDescriptionPractice")) Then pObject.colRoleDescriptionPractice = UtilSQLServer.SafeReader.SafeReadString(pReader, "RoleDescriptionPractice")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FullName")) Then pObject.colFullName = UtilSQLServer.SafeReader.SafeReadString(pReader, "FullName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Email")) Then pObject.colEmail = UtilSQLServer.SafeReader.SafeReadString(pReader, "Email")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Cell")) Then pObject.colCell = UtilSQLServer.SafeReader.SafeReadString(pReader, "Cell")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Voice")) Then pObject.colVoice = UtilSQLServer.SafeReader.SafeReadString(pReader, "Voice")
			If Not pReader.IsDBNull(pReader.GetOrdinal("OfficeAddress1")) Then pObject.colOfficeAddress1 = UtilSQLServer.SafeReader.SafeReadString(pReader, "OfficeAddress1")
			If Not pReader.IsDBNull(pReader.GetOrdinal("OfficeAddress2")) Then pObject.colOfficeAddress2 = UtilSQLServer.SafeReader.SafeReadString(pReader, "OfficeAddress2")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Title")) Then pObject.colTitle = UtilSQLServer.SafeReader.SafeReadString(pReader, "Title")
			pObject.SetIsDirty(False)
			Return pObject
		End	 Function

    #Region "Reflection Based Load Functions"


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
            Dim zSQL As String = "SELECT * FROM [dbo].[vwActiveAccountServiceContact]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowVwActiveAccountServiceContact
        Implements IrowVwActiveAccountServiceContact

        Public Event Loaded(pUserState As Object) Implements IrowVwActiveAccountServiceContact.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwActiveAccountServiceContact.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwActiveAccountServiceContact.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwActiveAccountServiceContact.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwActiveAccountServiceContact.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwActiveAccountServiceContact.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFilePrefix() As String Implements IrowVwActiveAccountServiceContact.colFilePrefix
            Get
                Return m_colFilePrefix
            End Get
            Set
                If Not Same(m_colFilePrefix, Value) Then
                    m_colFilePrefix = Value
                    m_IsDirty(FieldIndex.colFilePrefix) = True
                End If
            End Set
        End Property
        Private m_colFilePrefix As String

        Public Property colRoleSort() As Nullable(Of Integer) Implements IrowVwActiveAccountServiceContact.colRoleSort
            Get
                Return m_colRoleSort
            End Get
            Set
                If Not Same(m_colRoleSort, Value) Then
                    m_colRoleSort = Value
                    m_IsDirty(FieldIndex.colRoleSort) = True
                End If
            End Set
        End Property
        Private m_colRoleSort As Nullable(Of Integer)

        Public Property colRoleCd() As String Implements IrowVwActiveAccountServiceContact.colRoleCd
            Get
                Return m_colRoleCd
            End Get
            Set
                If Not Same(m_colRoleCd, Value) Then
                    m_colRoleCd = Value
                    m_IsDirty(FieldIndex.colRoleCd) = True
                End If
            End Set
        End Property
        Private m_colRoleCd As String

        Public Property colRoleDescription() As String Implements IrowVwActiveAccountServiceContact.colRoleDescription
            Get
                Return m_colRoleDescription
            End Get
            Set
                If Not Same(m_colRoleDescription, Value) Then
                    m_colRoleDescription = Value
                    m_IsDirty(FieldIndex.colRoleDescription) = True
                End If
            End Set
        End Property
        Private m_colRoleDescription As String

        Public Property colRoleDescriptionPractice() As String Implements IrowVwActiveAccountServiceContact.colRoleDescriptionPractice
            Get
                Return m_colRoleDescriptionPractice
            End Get
            Set
                If Not Same(m_colRoleDescriptionPractice, Value) Then
                    m_colRoleDescriptionPractice = Value
                    m_IsDirty(FieldIndex.colRoleDescriptionPractice) = True
                End If
            End Set
        End Property
        Private m_colRoleDescriptionPractice As String

        Public Property colFullName() As String Implements IrowVwActiveAccountServiceContact.colFullName
            Get
                Return m_colFullName
            End Get
            Set
                If Not Same(m_colFullName, Value) Then
                    m_colFullName = Value
                    m_IsDirty(FieldIndex.colFullName) = True
                End If
            End Set
        End Property
        Private m_colFullName As String

        Public Property colEmail() As String Implements IrowVwActiveAccountServiceContact.colEmail
            Get
                Return m_colEmail
            End Get
            Set
                If Not Same(m_colEmail, Value) Then
                    m_colEmail = Value
                    m_IsDirty(FieldIndex.colEmail) = True
                End If
            End Set
        End Property
        Private m_colEmail As String

        Public Property colCell() As String Implements IrowVwActiveAccountServiceContact.colCell
            Get
                Return m_colCell
            End Get
            Set
                If Not Same(m_colCell, Value) Then
                    m_colCell = Value
                    m_IsDirty(FieldIndex.colCell) = True
                End If
            End Set
        End Property
        Private m_colCell As String

        Public Property colVoice() As String Implements IrowVwActiveAccountServiceContact.colVoice
            Get
                Return m_colVoice
            End Get
            Set
                If Not Same(m_colVoice, Value) Then
                    m_colVoice = Value
                    m_IsDirty(FieldIndex.colVoice) = True
                End If
            End Set
        End Property
        Private m_colVoice As String

        Public Property colOfficeAddress1() As String Implements IrowVwActiveAccountServiceContact.colOfficeAddress1
            Get
                Return m_colOfficeAddress1
            End Get
            Set
                If Not Same(m_colOfficeAddress1, Value) Then
                    m_colOfficeAddress1 = Value
                    m_IsDirty(FieldIndex.colOfficeAddress1) = True
                End If
            End Set
        End Property
        Private m_colOfficeAddress1 As String

        Public Property colOfficeAddress2() As String Implements IrowVwActiveAccountServiceContact.colOfficeAddress2
            Get
                Return m_colOfficeAddress2
            End Get
            Set
                If Not Same(m_colOfficeAddress2, Value) Then
                    m_colOfficeAddress2 = Value
                    m_IsDirty(FieldIndex.colOfficeAddress2) = True
                End If
            End Set
        End Property
        Private m_colOfficeAddress2 As String

        Public Property colTitle() As String Implements IrowVwActiveAccountServiceContact.colTitle
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


        Public Function IsDirty(pIndex As rowVwActiveAccountServiceContact.FieldIndex) As Boolean Implements IrowVwActiveAccountServiceContact.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwActiveAccountServiceContact.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwActiveAccountServiceContact.SetIsDirty
            m_IsDirty(FieldIndex.colFilePrefix) = pDirty
            m_IsDirty(FieldIndex.colRoleSort) = pDirty
            m_IsDirty(FieldIndex.colRoleCd) = pDirty
            m_IsDirty(FieldIndex.colRoleDescription) = pDirty
            m_IsDirty(FieldIndex.colRoleDescriptionPractice) = pDirty
            m_IsDirty(FieldIndex.colFullName) = pDirty
            m_IsDirty(FieldIndex.colEmail) = pDirty
            m_IsDirty(FieldIndex.colCell) = pDirty
            m_IsDirty(FieldIndex.colVoice) = pDirty
            m_IsDirty(FieldIndex.colOfficeAddress1) = pDirty
            m_IsDirty(FieldIndex.colOfficeAddress2) = pDirty
            m_IsDirty(FieldIndex.colTitle) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwActiveAccountServiceContact) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwActiveAccountServiceContact
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFilePrefix  = 1
            colRoleSort 
            colRoleCd 
            colRoleDescription 
            colRoleDescriptionPractice 
            colFullName 
            colEmail 
            colCell 
            colVoice 
            colOfficeAddress1 
            colOfficeAddress2 
            colTitle 
        End Enum

        Private m_IsDirty(12) As Boolean

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

    Public Interface IrowVwActiveAccountServiceContact
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFilePrefix() As String
        Property colRoleSort() As Nullable(Of Integer)
        Property colRoleCd() As String
        Property colRoleDescription() As String
        Property colRoleDescriptionPractice() As String
        Property colFullName() As String
        Property colEmail() As String
        Property colCell() As String
        Property colVoice() As String
        Property colOfficeAddress1() As String
        Property colOfficeAddress2() As String
        Property colTitle() As String
        Function IsDirty(pIndex As rowVwActiveAccountServiceContact.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

