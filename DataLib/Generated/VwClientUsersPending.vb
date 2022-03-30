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
    Partial Public Class VwClientUsersPending

        Public Shared Function LoadData() As List(Of rowVwClientUsersPending)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwClientUsersPending)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwClientUsersPending)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwClientUsersPending)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwClientUsersPending)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwClientUsersPending)
            Dim zReturn As New List(Of rowVwClientUsersPending)
            Dim zSQL As String = "SELECT * FROM [gv].[vwClientUsersPending]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwClientUsersPending)

			Try
	            Dim zReturn As New List(Of rowVwClientUsersPending)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwClientUsersPending

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwClientUsersPending		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwClientUsersPending)
			If Not pReader.IsDBNull(pReader.GetOrdinal("FilePrefix")) Then pObject.colFilePrefix = UtilSQLServer.SafeReader.SafeReadInt16(pReader, "FilePrefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ReclassificationLinkGUID")) Then pObject.colReclassificationLinkGUID = UtilSQLServer.SafeReader.SafeReadString(pReader, "ReclassificationLinkGUID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("UserIndex")) Then pObject.colUserIndex = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "UserIndex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("UserTotalCount")) Then pObject.colUserTotalCount = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "UserTotalCount")
			If Not pReader.IsDBNull(pReader.GetOrdinal("UserCertifiedCount")) Then pObject.colUserCertifiedCount = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "UserCertifiedCount")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FullName")) Then pObject.colFullName = UtilSQLServer.SafeReader.SafeReadString(pReader, "FullName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("EzyUserId")) Then pObject.colEzyUserId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "EzyUserId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("EzyGuid")) Then pObject.colEzyGuid = UtilSQLServer.SafeReader.SafeReadString(pReader, "EzyGuid")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ActiveUser")) Then pObject.colActiveUser = UtilSQLServer.SafeReader.SafeReadString(pReader, "ActiveUser")
			If Not pReader.IsDBNull(pReader.GetOrdinal("AccessLevel")) Then pObject.colAccessLevel = UtilSQLServer.SafeReader.SafeReadString(pReader, "AccessLevel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("AccessLevelDetails")) Then pObject.colAccessLevelDetails = UtilSQLServer.SafeReader.SafeReadString(pReader, "AccessLevelDetails")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Email")) Then pObject.colEmail = UtilSQLServer.SafeReader.SafeReadString(pReader, "Email")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CCOnly")) Then pObject.colCCOnly = UtilSQLServer.SafeReader.SafeReadString(pReader, "CCOnly")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DateTimeStamp")) Then pObject.colDateTimeStamp = UtilSQLServer.SafeReader.SafeReadString(pReader, "DateTimeStamp")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LastLogin")) Then pObject.colLastLogin = UtilSQLServer.SafeReader.SafeReadString(pReader, "LastLogin")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Comment")) Then pObject.colComment = UtilSQLServer.SafeReader.SafeReadString(pReader, "Comment")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ClientComment")) Then pObject.colClientComment = UtilSQLServer.SafeReader.SafeReadString(pReader, "ClientComment")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RInit")) Then pObject.colRInit = UtilSQLServer.SafeReader.SafeReadString(pReader, "RInit")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RReport")) Then pObject.colRReport = UtilSQLServer.SafeReader.SafeReadString(pReader, "RReport")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Rfu1")) Then pObject.colRfu1 = UtilSQLServer.SafeReader.SafeReadString(pReader, "Rfu1")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Rfu2")) Then pObject.colRfu2 = UtilSQLServer.SafeReader.SafeReadString(pReader, "Rfu2")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Rfu3")) Then pObject.colRfu3 = UtilSQLServer.SafeReader.SafeReadString(pReader, "Rfu3")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ROverdue1")) Then pObject.colROverdue1 = UtilSQLServer.SafeReader.SafeReadString(pReader, "ROverdue1")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ROverdue2")) Then pObject.colROverdue2 = UtilSQLServer.SafeReader.SafeReadString(pReader, "ROverdue2")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ROverdue3")) Then pObject.colROverdue3 = UtilSQLServer.SafeReader.SafeReadString(pReader, "ROverdue3")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ExpOverdue")) Then pObject.colExpOverdue = UtilSQLServer.SafeReader.SafeReadString(pReader, "ExpOverdue")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RExpd")) Then pObject.colRExpd = UtilSQLServer.SafeReader.SafeReadString(pReader, "RExpd")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ActionId")) Then pObject.colActionId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "ActionId")
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
            Dim zSQL As String = "SELECT * FROM [gv].[vwClientUsersPending]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowVwClientUsersPending
        Implements IrowVwClientUsersPending

        Public Event Loaded(pUserState As Object) Implements IrowVwClientUsersPending.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwClientUsersPending.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwClientUsersPending.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwClientUsersPending.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwClientUsersPending.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwClientUsersPending.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFilePrefix() As Nullable(Of Short) Implements IrowVwClientUsersPending.colFilePrefix
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
        Private m_colFilePrefix As Nullable(Of Short)

        Public Property colReclassificationLinkGUID() As String Implements IrowVwClientUsersPending.colReclassificationLinkGUID
            Get
                Return m_colReclassificationLinkGUID
            End Get
            Set
                If Not Same(m_colReclassificationLinkGUID, Value) Then
                    m_colReclassificationLinkGUID = Value
                    m_IsDirty(FieldIndex.colReclassificationLinkGUID) = True
                End If
            End Set
        End Property
        Private m_colReclassificationLinkGUID As String

        Public Property colUserIndex() As Nullable(Of Long) Implements IrowVwClientUsersPending.colUserIndex
            Get
                Return m_colUserIndex
            End Get
            Set
                If Not Same(m_colUserIndex, Value) Then
                    m_colUserIndex = Value
                    m_IsDirty(FieldIndex.colUserIndex) = True
                End If
            End Set
        End Property
        Private m_colUserIndex As Nullable(Of Long)

        Public Property colUserTotalCount() As Nullable(Of Integer) Implements IrowVwClientUsersPending.colUserTotalCount
            Get
                Return m_colUserTotalCount
            End Get
            Set
                If Not Same(m_colUserTotalCount, Value) Then
                    m_colUserTotalCount = Value
                    m_IsDirty(FieldIndex.colUserTotalCount) = True
                End If
            End Set
        End Property
        Private m_colUserTotalCount As Nullable(Of Integer)

        Public Property colUserCertifiedCount() As Nullable(Of Integer) Implements IrowVwClientUsersPending.colUserCertifiedCount
            Get
                Return m_colUserCertifiedCount
            End Get
            Set
                If Not Same(m_colUserCertifiedCount, Value) Then
                    m_colUserCertifiedCount = Value
                    m_IsDirty(FieldIndex.colUserCertifiedCount) = True
                End If
            End Set
        End Property
        Private m_colUserCertifiedCount As Nullable(Of Integer)

        Public Property colFullName() As String Implements IrowVwClientUsersPending.colFullName
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

        Public Property colEzyUserId() As Nullable(Of Integer) Implements IrowVwClientUsersPending.colEzyUserId
            Get
                Return m_colEzyUserId
            End Get
            Set
                If Not Same(m_colEzyUserId, Value) Then
                    m_colEzyUserId = Value
                    m_IsDirty(FieldIndex.colEzyUserId) = True
                End If
            End Set
        End Property
        Private m_colEzyUserId As Nullable(Of Integer)

        Public Property colEzyGuid() As String Implements IrowVwClientUsersPending.colEzyGuid
            Get
                Return m_colEzyGuid
            End Get
            Set
                If Not Same(m_colEzyGuid, Value) Then
                    m_colEzyGuid = Value
                    m_IsDirty(FieldIndex.colEzyGuid) = True
                End If
            End Set
        End Property
        Private m_colEzyGuid As String

        Public Property colActiveUser() As String Implements IrowVwClientUsersPending.colActiveUser
            Get
                Return m_colActiveUser
            End Get
            Set
                If Not Same(m_colActiveUser, Value) Then
                    m_colActiveUser = Value
                    m_IsDirty(FieldIndex.colActiveUser) = True
                End If
            End Set
        End Property
        Private m_colActiveUser As String

        Public Property colAccessLevel() As String Implements IrowVwClientUsersPending.colAccessLevel
            Get
                Return m_colAccessLevel
            End Get
            Set
                If Not Same(m_colAccessLevel, Value) Then
                    m_colAccessLevel = Value
                    m_IsDirty(FieldIndex.colAccessLevel) = True
                End If
            End Set
        End Property
        Private m_colAccessLevel As String

        Public Property colAccessLevelDetails() As String Implements IrowVwClientUsersPending.colAccessLevelDetails
            Get
                Return m_colAccessLevelDetails
            End Get
            Set
                If Not Same(m_colAccessLevelDetails, Value) Then
                    m_colAccessLevelDetails = Value
                    m_IsDirty(FieldIndex.colAccessLevelDetails) = True
                End If
            End Set
        End Property
        Private m_colAccessLevelDetails As String

        Public Property colEmail() As String Implements IrowVwClientUsersPending.colEmail
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

        Public Property colCCOnly() As String Implements IrowVwClientUsersPending.colCCOnly
            Get
                Return m_colCCOnly
            End Get
            Set
                If Not Same(m_colCCOnly, Value) Then
                    m_colCCOnly = Value
                    m_IsDirty(FieldIndex.colCCOnly) = True
                End If
            End Set
        End Property
        Private m_colCCOnly As String

        Public Property colDateTimeStamp() As String Implements IrowVwClientUsersPending.colDateTimeStamp
            Get
                Return m_colDateTimeStamp
            End Get
            Set
                If Not Same(m_colDateTimeStamp, Value) Then
                    m_colDateTimeStamp = Value
                    m_IsDirty(FieldIndex.colDateTimeStamp) = True
                End If
            End Set
        End Property
        Private m_colDateTimeStamp As String

        Public Property colLastLogin() As String Implements IrowVwClientUsersPending.colLastLogin
            Get
                Return m_colLastLogin
            End Get
            Set
                If Not Same(m_colLastLogin, Value) Then
                    m_colLastLogin = Value
                    m_IsDirty(FieldIndex.colLastLogin) = True
                End If
            End Set
        End Property
        Private m_colLastLogin As String

        Public Property colComment() As String Implements IrowVwClientUsersPending.colComment
            Get
                Return m_colComment
            End Get
            Set
                If Not Same(m_colComment, Value) Then
                    m_colComment = Value
                    m_IsDirty(FieldIndex.colComment) = True
                End If
            End Set
        End Property
        Private m_colComment As String

        Public Property colClientComment() As String Implements IrowVwClientUsersPending.colClientComment
            Get
                Return m_colClientComment
            End Get
            Set
                If Not Same(m_colClientComment, Value) Then
                    m_colClientComment = Value
                    m_IsDirty(FieldIndex.colClientComment) = True
                End If
            End Set
        End Property
        Private m_colClientComment As String

        Public Property colRInit() As String Implements IrowVwClientUsersPending.colRInit
            Get
                Return m_colRInit
            End Get
            Set
                If Not Same(m_colRInit, Value) Then
                    m_colRInit = Value
                    m_IsDirty(FieldIndex.colRInit) = True
                End If
            End Set
        End Property
        Private m_colRInit As String

        Public Property colRReport() As String Implements IrowVwClientUsersPending.colRReport
            Get
                Return m_colRReport
            End Get
            Set
                If Not Same(m_colRReport, Value) Then
                    m_colRReport = Value
                    m_IsDirty(FieldIndex.colRReport) = True
                End If
            End Set
        End Property
        Private m_colRReport As String

        Public Property colRfu1() As String Implements IrowVwClientUsersPending.colRfu1
            Get
                Return m_colRfu1
            End Get
            Set
                If Not Same(m_colRfu1, Value) Then
                    m_colRfu1 = Value
                    m_IsDirty(FieldIndex.colRfu1) = True
                End If
            End Set
        End Property
        Private m_colRfu1 As String

        Public Property colRfu2() As String Implements IrowVwClientUsersPending.colRfu2
            Get
                Return m_colRfu2
            End Get
            Set
                If Not Same(m_colRfu2, Value) Then
                    m_colRfu2 = Value
                    m_IsDirty(FieldIndex.colRfu2) = True
                End If
            End Set
        End Property
        Private m_colRfu2 As String

        Public Property colRfu3() As String Implements IrowVwClientUsersPending.colRfu3
            Get
                Return m_colRfu3
            End Get
            Set
                If Not Same(m_colRfu3, Value) Then
                    m_colRfu3 = Value
                    m_IsDirty(FieldIndex.colRfu3) = True
                End If
            End Set
        End Property
        Private m_colRfu3 As String

        Public Property colROverdue1() As String Implements IrowVwClientUsersPending.colROverdue1
            Get
                Return m_colROverdue1
            End Get
            Set
                If Not Same(m_colROverdue1, Value) Then
                    m_colROverdue1 = Value
                    m_IsDirty(FieldIndex.colROverdue1) = True
                End If
            End Set
        End Property
        Private m_colROverdue1 As String

        Public Property colROverdue2() As String Implements IrowVwClientUsersPending.colROverdue2
            Get
                Return m_colROverdue2
            End Get
            Set
                If Not Same(m_colROverdue2, Value) Then
                    m_colROverdue2 = Value
                    m_IsDirty(FieldIndex.colROverdue2) = True
                End If
            End Set
        End Property
        Private m_colROverdue2 As String

        Public Property colROverdue3() As String Implements IrowVwClientUsersPending.colROverdue3
            Get
                Return m_colROverdue3
            End Get
            Set
                If Not Same(m_colROverdue3, Value) Then
                    m_colROverdue3 = Value
                    m_IsDirty(FieldIndex.colROverdue3) = True
                End If
            End Set
        End Property
        Private m_colROverdue3 As String

        Public Property colExpOverdue() As String Implements IrowVwClientUsersPending.colExpOverdue
            Get
                Return m_colExpOverdue
            End Get
            Set
                If Not Same(m_colExpOverdue, Value) Then
                    m_colExpOverdue = Value
                    m_IsDirty(FieldIndex.colExpOverdue) = True
                End If
            End Set
        End Property
        Private m_colExpOverdue As String

        Public Property colRExpd() As String Implements IrowVwClientUsersPending.colRExpd
            Get
                Return m_colRExpd
            End Get
            Set
                If Not Same(m_colRExpd, Value) Then
                    m_colRExpd = Value
                    m_IsDirty(FieldIndex.colRExpd) = True
                End If
            End Set
        End Property
        Private m_colRExpd As String

        Public Property colActionId() As Nullable(Of Integer) Implements IrowVwClientUsersPending.colActionId
            Get
                Return m_colActionId
            End Get
            Set
                If Not Same(m_colActionId, Value) Then
                    m_colActionId = Value
                    m_IsDirty(FieldIndex.colActionId) = True
                End If
            End Set
        End Property
        Private m_colActionId As Nullable(Of Integer)


        Public Function IsDirty(pIndex As rowVwClientUsersPending.FieldIndex) As Boolean Implements IrowVwClientUsersPending.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwClientUsersPending.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwClientUsersPending.SetIsDirty
            m_IsDirty(FieldIndex.colFilePrefix) = pDirty
            m_IsDirty(FieldIndex.colReclassificationLinkGUID) = pDirty
            m_IsDirty(FieldIndex.colUserIndex) = pDirty
            m_IsDirty(FieldIndex.colUserTotalCount) = pDirty
            m_IsDirty(FieldIndex.colUserCertifiedCount) = pDirty
            m_IsDirty(FieldIndex.colFullName) = pDirty
            m_IsDirty(FieldIndex.colEzyUserId) = pDirty
            m_IsDirty(FieldIndex.colEzyGuid) = pDirty
            m_IsDirty(FieldIndex.colActiveUser) = pDirty
            m_IsDirty(FieldIndex.colAccessLevel) = pDirty
            m_IsDirty(FieldIndex.colAccessLevelDetails) = pDirty
            m_IsDirty(FieldIndex.colEmail) = pDirty
            m_IsDirty(FieldIndex.colCCOnly) = pDirty
            m_IsDirty(FieldIndex.colDateTimeStamp) = pDirty
            m_IsDirty(FieldIndex.colLastLogin) = pDirty
            m_IsDirty(FieldIndex.colComment) = pDirty
            m_IsDirty(FieldIndex.colClientComment) = pDirty
            m_IsDirty(FieldIndex.colRInit) = pDirty
            m_IsDirty(FieldIndex.colRReport) = pDirty
            m_IsDirty(FieldIndex.colRfu1) = pDirty
            m_IsDirty(FieldIndex.colRfu2) = pDirty
            m_IsDirty(FieldIndex.colRfu3) = pDirty
            m_IsDirty(FieldIndex.colROverdue1) = pDirty
            m_IsDirty(FieldIndex.colROverdue2) = pDirty
            m_IsDirty(FieldIndex.colROverdue3) = pDirty
            m_IsDirty(FieldIndex.colExpOverdue) = pDirty
            m_IsDirty(FieldIndex.colRExpd) = pDirty
            m_IsDirty(FieldIndex.colActionId) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwClientUsersPending) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwClientUsersPending
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFilePrefix  = 1
            colReclassificationLinkGUID 
            colUserIndex 
            colUserTotalCount 
            colUserCertifiedCount 
            colFullName 
            colEzyUserId 
            colEzyGuid 
            colActiveUser 
            colAccessLevel 
            colAccessLevelDetails 
            colEmail 
            colCCOnly 
            colDateTimeStamp 
            colLastLogin 
            colComment 
            colClientComment 
            colRInit 
            colRReport 
            colRfu1 
            colRfu2 
            colRfu3 
            colROverdue1 
            colROverdue2 
            colROverdue3 
            colExpOverdue 
            colRExpd 
            colActionId 
        End Enum

        Private m_IsDirty(28) As Boolean

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

    Public Interface IrowVwClientUsersPending
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFilePrefix() As Nullable(Of Short)
        Property colReclassificationLinkGUID() As String
        Property colUserIndex() As Nullable(Of Long)
        Property colUserTotalCount() As Nullable(Of Integer)
        Property colUserCertifiedCount() As Nullable(Of Integer)
        Property colFullName() As String
        Property colEzyUserId() As Nullable(Of Integer)
        Property colEzyGuid() As String
        Property colActiveUser() As String
        Property colAccessLevel() As String
        Property colAccessLevelDetails() As String
        Property colEmail() As String
        Property colCCOnly() As String
        Property colDateTimeStamp() As String
        Property colLastLogin() As String
        Property colComment() As String
        Property colClientComment() As String
        Property colRInit() As String
        Property colRReport() As String
        Property colRfu1() As String
        Property colRfu2() As String
        Property colRfu3() As String
        Property colROverdue1() As String
        Property colROverdue2() As String
        Property colROverdue3() As String
        Property colExpOverdue() As String
        Property colRExpd() As String
        Property colActionId() As Nullable(Of Integer)
        Function IsDirty(pIndex As rowVwClientUsersPending.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

