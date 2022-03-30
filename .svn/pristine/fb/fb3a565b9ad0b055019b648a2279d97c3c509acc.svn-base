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
    Partial Public Class VwPasswordSecurity

        Public Shared Function LoadData() As List(Of rowVwPasswordSecurity)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwPasswordSecurity)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwPasswordSecurity)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwPasswordSecurity)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwPasswordSecurity)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwPasswordSecurity)
            Dim zReturn As New List(Of rowVwPasswordSecurity)
            Dim zSQL As String = "SELECT * FROM [jv].[vwPasswordSecurity]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwPasswordSecurity)

			Try
	            Dim zReturn As New List(Of rowVwPasswordSecurity)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwPasswordSecurity

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwPasswordSecurity		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwPasswordSecurity)
			If Not pReader.IsDBNull(pReader.GetOrdinal("LoginID")) Then pObject.colLoginID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "LoginID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PasswordReminderSentFlag")) Then pObject.colPasswordReminderSentFlag = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "PasswordReminderSentFlag")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ExpireEveryNthDay")) Then pObject.colExpireEveryNthDay = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "ExpireEveryNthDay")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LastPasswordChangeDate")) Then pObject.colLastPasswordChangeDate = UtilSQLServer.SafeReader.SafeReadDate(pReader, "LastPasswordChangeDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("IsLockedOut")) Then pObject.colIsLockedOut = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "IsLockedOut")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PasswordIsExpired")) Then pObject.colPasswordIsExpired = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "PasswordIsExpired")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PasswordExpirationDate")) Then pObject.colPasswordExpirationDate = UtilSQLServer.SafeReader.SafeReadDate(pReader, "PasswordExpirationDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NeedToExpirePasswordAndLockout")) Then pObject.colNeedToExpirePasswordAndLockout = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "NeedToExpirePasswordAndLockout")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DaysUntilPasswordExpiration")) Then pObject.colDaysUntilPasswordExpiration = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "DaysUntilPasswordExpiration")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Need14DayPasswordReminder")) Then pObject.colNeed14DayPasswordReminder = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "Need14DayPasswordReminder")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Need7DayPasswordReminder")) Then pObject.colNeed7DayPasswordReminder = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "Need7DayPasswordReminder")
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
            Dim zSQL As String = "SELECT * FROM [jv].[vwPasswordSecurity]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowVwPasswordSecurity
        Implements IrowVwPasswordSecurity

        Public Event Loaded(pUserState As Object) Implements IrowVwPasswordSecurity.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwPasswordSecurity.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwPasswordSecurity.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwPasswordSecurity.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwPasswordSecurity.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwPasswordSecurity.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colLoginID() As Nullable(Of Integer) Implements IrowVwPasswordSecurity.colLoginID
            Get
                Return m_colLoginID
            End Get
            Set
                If Not Same(m_colLoginID, Value) Then
                    m_colLoginID = Value
                    m_IsDirty(FieldIndex.colLoginID) = True
                End If
            End Set
        End Property
        Private m_colLoginID As Nullable(Of Integer)

        Public Property colPasswordReminderSentFlag() As Nullable(Of Integer) Implements IrowVwPasswordSecurity.colPasswordReminderSentFlag
            Get
                Return m_colPasswordReminderSentFlag
            End Get
            Set
                If Not Same(m_colPasswordReminderSentFlag, Value) Then
                    m_colPasswordReminderSentFlag = Value
                    m_IsDirty(FieldIndex.colPasswordReminderSentFlag) = True
                End If
            End Set
        End Property
        Private m_colPasswordReminderSentFlag As Nullable(Of Integer)

        Public Property colExpireEveryNthDay() As Nullable(Of Integer) Implements IrowVwPasswordSecurity.colExpireEveryNthDay
            Get
                Return m_colExpireEveryNthDay
            End Get
            Set
                If Not Same(m_colExpireEveryNthDay, Value) Then
                    m_colExpireEveryNthDay = Value
                    m_IsDirty(FieldIndex.colExpireEveryNthDay) = True
                End If
            End Set
        End Property
        Private m_colExpireEveryNthDay As Nullable(Of Integer)

        Public Property colLastPasswordChangeDate() As Nullable(Of Date) Implements IrowVwPasswordSecurity.colLastPasswordChangeDate
            Get
                Return m_colLastPasswordChangeDate
            End Get
            Set
                If Not Same(m_colLastPasswordChangeDate, Value) Then
                    m_colLastPasswordChangeDate = Value
                    m_IsDirty(FieldIndex.colLastPasswordChangeDate) = True
                End If
            End Set
        End Property
        Private m_colLastPasswordChangeDate As Nullable(Of Date)

        Public Property colIsLockedOut() As Nullable(Of Boolean) Implements IrowVwPasswordSecurity.colIsLockedOut
            Get
                Return m_colIsLockedOut
            End Get
            Set
                If Not Same(m_colIsLockedOut, Value) Then
                    m_colIsLockedOut = Value
                    m_IsDirty(FieldIndex.colIsLockedOut) = True
                End If
            End Set
        End Property
        Private m_colIsLockedOut As Nullable(Of Boolean)

        Public Property colPasswordIsExpired() As Nullable(Of Boolean) Implements IrowVwPasswordSecurity.colPasswordIsExpired
            Get
                Return m_colPasswordIsExpired
            End Get
            Set
                If Not Same(m_colPasswordIsExpired, Value) Then
                    m_colPasswordIsExpired = Value
                    m_IsDirty(FieldIndex.colPasswordIsExpired) = True
                End If
            End Set
        End Property
        Private m_colPasswordIsExpired As Nullable(Of Boolean)

        Public Property colPasswordExpirationDate() As Nullable(Of Date) Implements IrowVwPasswordSecurity.colPasswordExpirationDate
            Get
                Return m_colPasswordExpirationDate
            End Get
            Set
                If Not Same(m_colPasswordExpirationDate, Value) Then
                    m_colPasswordExpirationDate = Value
                    m_IsDirty(FieldIndex.colPasswordExpirationDate) = True
                End If
            End Set
        End Property
        Private m_colPasswordExpirationDate As Nullable(Of Date)

        Public Property colNeedToExpirePasswordAndLockout() As Nullable(Of Boolean) Implements IrowVwPasswordSecurity.colNeedToExpirePasswordAndLockout
            Get
                Return m_colNeedToExpirePasswordAndLockout
            End Get
            Set
                If Not Same(m_colNeedToExpirePasswordAndLockout, Value) Then
                    m_colNeedToExpirePasswordAndLockout = Value
                    m_IsDirty(FieldIndex.colNeedToExpirePasswordAndLockout) = True
                End If
            End Set
        End Property
        Private m_colNeedToExpirePasswordAndLockout As Nullable(Of Boolean)

        Public Property colDaysUntilPasswordExpiration() As Nullable(Of Integer) Implements IrowVwPasswordSecurity.colDaysUntilPasswordExpiration
            Get
                Return m_colDaysUntilPasswordExpiration
            End Get
            Set
                If Not Same(m_colDaysUntilPasswordExpiration, Value) Then
                    m_colDaysUntilPasswordExpiration = Value
                    m_IsDirty(FieldIndex.colDaysUntilPasswordExpiration) = True
                End If
            End Set
        End Property
        Private m_colDaysUntilPasswordExpiration As Nullable(Of Integer)

        Public Property colNeed14DayPasswordReminder() As Nullable(Of Boolean) Implements IrowVwPasswordSecurity.colNeed14DayPasswordReminder
            Get
                Return m_colNeed14DayPasswordReminder
            End Get
            Set
                If Not Same(m_colNeed14DayPasswordReminder, Value) Then
                    m_colNeed14DayPasswordReminder = Value
                    m_IsDirty(FieldIndex.colNeed14DayPasswordReminder) = True
                End If
            End Set
        End Property
        Private m_colNeed14DayPasswordReminder As Nullable(Of Boolean)

        Public Property colNeed7DayPasswordReminder() As Nullable(Of Boolean) Implements IrowVwPasswordSecurity.colNeed7DayPasswordReminder
            Get
                Return m_colNeed7DayPasswordReminder
            End Get
            Set
                If Not Same(m_colNeed7DayPasswordReminder, Value) Then
                    m_colNeed7DayPasswordReminder = Value
                    m_IsDirty(FieldIndex.colNeed7DayPasswordReminder) = True
                End If
            End Set
        End Property
        Private m_colNeed7DayPasswordReminder As Nullable(Of Boolean)


        Public Function IsDirty(pIndex As rowVwPasswordSecurity.FieldIndex) As Boolean Implements IrowVwPasswordSecurity.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwPasswordSecurity.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwPasswordSecurity.SetIsDirty
            m_IsDirty(FieldIndex.colLoginID) = pDirty
            m_IsDirty(FieldIndex.colPasswordReminderSentFlag) = pDirty
            m_IsDirty(FieldIndex.colExpireEveryNthDay) = pDirty
            m_IsDirty(FieldIndex.colLastPasswordChangeDate) = pDirty
            m_IsDirty(FieldIndex.colIsLockedOut) = pDirty
            m_IsDirty(FieldIndex.colPasswordIsExpired) = pDirty
            m_IsDirty(FieldIndex.colPasswordExpirationDate) = pDirty
            m_IsDirty(FieldIndex.colNeedToExpirePasswordAndLockout) = pDirty
            m_IsDirty(FieldIndex.colDaysUntilPasswordExpiration) = pDirty
            m_IsDirty(FieldIndex.colNeed14DayPasswordReminder) = pDirty
            m_IsDirty(FieldIndex.colNeed7DayPasswordReminder) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwPasswordSecurity) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwPasswordSecurity
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colLoginID  = 1
            colPasswordReminderSentFlag 
            colExpireEveryNthDay 
            colLastPasswordChangeDate 
            colIsLockedOut 
            colPasswordIsExpired 
            colPasswordExpirationDate 
            colNeedToExpirePasswordAndLockout 
            colDaysUntilPasswordExpiration 
            colNeed14DayPasswordReminder 
            colNeed7DayPasswordReminder 
        End Enum

        Private m_IsDirty(11) As Boolean

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

    Public Interface IrowVwPasswordSecurity
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colLoginID() As Nullable(Of Integer)
        Property colPasswordReminderSentFlag() As Nullable(Of Integer)
        Property colExpireEveryNthDay() As Nullable(Of Integer)
        Property colLastPasswordChangeDate() As Nullable(Of Date)
        Property colIsLockedOut() As Nullable(Of Boolean)
        Property colPasswordIsExpired() As Nullable(Of Boolean)
        Property colPasswordExpirationDate() As Nullable(Of Date)
        Property colNeedToExpirePasswordAndLockout() As Nullable(Of Boolean)
        Property colDaysUntilPasswordExpiration() As Nullable(Of Integer)
        Property colNeed14DayPasswordReminder() As Nullable(Of Boolean)
        Property colNeed7DayPasswordReminder() As Nullable(Of Boolean)
        Function IsDirty(pIndex As rowVwPasswordSecurity.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

