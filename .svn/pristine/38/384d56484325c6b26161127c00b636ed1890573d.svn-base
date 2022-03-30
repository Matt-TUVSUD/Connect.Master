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
    Partial Public Class VwRRExpiringExpiredExpectedCompletedDate

        Public Shared Function LoadData() As List(Of rowVwRRExpiringExpiredExpectedCompletedDate)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwRRExpiringExpiredExpectedCompletedDate)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwRRExpiringExpiredExpectedCompletedDate)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwRRExpiringExpiredExpectedCompletedDate)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwRRExpiringExpiredExpectedCompletedDate)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwRRExpiringExpiredExpectedCompletedDate)
            Dim zReturn As New List(Of rowVwRRExpiringExpiredExpectedCompletedDate)
            Dim zSQL As String = "SELECT * FROM [jv].[vwRRExpiringExpiredExpectedCompletedDate]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwRRExpiringExpiredExpectedCompletedDate)

			Try
	            Dim zReturn As New List(Of rowVwRRExpiringExpiredExpectedCompletedDate)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwRRExpiringExpiredExpectedCompletedDate

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwRRExpiringExpiredExpectedCompletedDate		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwRRExpiringExpiredExpectedCompletedDate)
			If Not pReader.IsDBNull(pReader.GetOrdinal("RowNo")) Then pObject.colRowNo = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "RowNo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FilePrefix")) Then pObject.colFilePrefix = UtilSQLServer.SafeReader.SafeReadString(pReader, "FilePrefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FileNo")) Then pObject.colFileNo = UtilSQLServer.SafeReader.SafeReadString(pReader, "FileNo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Division")) Then pObject.colDivision = UtilSQLServer.SafeReader.SafeReadString(pReader, "Division")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CustomAccess")) Then pObject.colCustomAccess = UtilSQLServer.SafeReader.SafeReadString(pReader, "CustomAccess")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ClientLocNo")) Then pObject.colClientLocNo = UtilSQLServer.SafeReader.SafeReadString(pReader, "ClientLocNo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Facility")) Then pObject.colFacility = UtilSQLServer.SafeReader.SafeReadString(pReader, "Facility")
			If Not pReader.IsDBNull(pReader.GetOrdinal("City")) Then pObject.colCity = UtilSQLServer.SafeReader.SafeReadString(pReader, "City")
			If Not pReader.IsDBNull(pReader.GetOrdinal("StProv")) Then pObject.colStProv = UtilSQLServer.SafeReader.SafeReadString(pReader, "StProv")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Country")) Then pObject.colCountry = UtilSQLServer.SafeReader.SafeReadString(pReader, "Country")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PracticeId")) Then pObject.colPracticeId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "PracticeId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RRLogID")) Then pObject.colRRLogID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "RRLogID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RecipientName")) Then pObject.colRecipientName = UtilSQLServer.SafeReader.SafeReadString(pReader, "RecipientName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RecipientEmail")) Then pObject.colRecipientEmail = UtilSQLServer.SafeReader.SafeReadString(pReader, "RecipientEmail")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PracticeName")) Then pObject.colPracticeName = UtilSQLServer.SafeReader.SafeReadString(pReader, "PracticeName")
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
            Dim zSQL As String = "SELECT * FROM [jv].[vwRRExpiringExpiredExpectedCompletedDate]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowVwRRExpiringExpiredExpectedCompletedDate
        Implements IrowVwRRExpiringExpiredExpectedCompletedDate

        Public Event Loaded(pUserState As Object) Implements IrowVwRRExpiringExpiredExpectedCompletedDate.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwRRExpiringExpiredExpectedCompletedDate.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwRRExpiringExpiredExpectedCompletedDate.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwRRExpiringExpiredExpectedCompletedDate.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwRRExpiringExpiredExpectedCompletedDate.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwRRExpiringExpiredExpectedCompletedDate.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colRowNo() As Nullable(Of Long) Implements IrowVwRRExpiringExpiredExpectedCompletedDate.colRowNo
            Get
                Return m_colRowNo
            End Get
            Set
                If Not Same(m_colRowNo, Value) Then
                    m_colRowNo = Value
                    m_IsDirty(FieldIndex.colRowNo) = True
                End If
            End Set
        End Property
        Private m_colRowNo As Nullable(Of Long)

        Public Property colFilePrefix() As String Implements IrowVwRRExpiringExpiredExpectedCompletedDate.colFilePrefix
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

        Public Property colFileNo() As String Implements IrowVwRRExpiringExpiredExpectedCompletedDate.colFileNo
            Get
                Return m_colFileNo
            End Get
            Set
                If Not Same(m_colFileNo, Value) Then
                    m_colFileNo = Value
                    m_IsDirty(FieldIndex.colFileNo) = True
                End If
            End Set
        End Property
        Private m_colFileNo As String

        Public Property colDivision() As String Implements IrowVwRRExpiringExpiredExpectedCompletedDate.colDivision
            Get
                Return m_colDivision
            End Get
            Set
                If Not Same(m_colDivision, Value) Then
                    m_colDivision = Value
                    m_IsDirty(FieldIndex.colDivision) = True
                End If
            End Set
        End Property
        Private m_colDivision As String

        Public Property colCustomAccess() As String Implements IrowVwRRExpiringExpiredExpectedCompletedDate.colCustomAccess
            Get
                Return m_colCustomAccess
            End Get
            Set
                If Not Same(m_colCustomAccess, Value) Then
                    m_colCustomAccess = Value
                    m_IsDirty(FieldIndex.colCustomAccess) = True
                End If
            End Set
        End Property
        Private m_colCustomAccess As String

        Public Property colClientLocNo() As String Implements IrowVwRRExpiringExpiredExpectedCompletedDate.colClientLocNo
            Get
                Return m_colClientLocNo
            End Get
            Set
                If Not Same(m_colClientLocNo, Value) Then
                    m_colClientLocNo = Value
                    m_IsDirty(FieldIndex.colClientLocNo) = True
                End If
            End Set
        End Property
        Private m_colClientLocNo As String

        Public Property colFacility() As String Implements IrowVwRRExpiringExpiredExpectedCompletedDate.colFacility
            Get
                Return m_colFacility
            End Get
            Set
                If Not Same(m_colFacility, Value) Then
                    m_colFacility = Value
                    m_IsDirty(FieldIndex.colFacility) = True
                End If
            End Set
        End Property
        Private m_colFacility As String

        Public Property colCity() As String Implements IrowVwRRExpiringExpiredExpectedCompletedDate.colCity
            Get
                Return m_colCity
            End Get
            Set
                If Not Same(m_colCity, Value) Then
                    m_colCity = Value
                    m_IsDirty(FieldIndex.colCity) = True
                End If
            End Set
        End Property
        Private m_colCity As String

        Public Property colStProv() As String Implements IrowVwRRExpiringExpiredExpectedCompletedDate.colStProv
            Get
                Return m_colStProv
            End Get
            Set
                If Not Same(m_colStProv, Value) Then
                    m_colStProv = Value
                    m_IsDirty(FieldIndex.colStProv) = True
                End If
            End Set
        End Property
        Private m_colStProv As String

        Public Property colCountry() As String Implements IrowVwRRExpiringExpiredExpectedCompletedDate.colCountry
            Get
                Return m_colCountry
            End Get
            Set
                If Not Same(m_colCountry, Value) Then
                    m_colCountry = Value
                    m_IsDirty(FieldIndex.colCountry) = True
                End If
            End Set
        End Property
        Private m_colCountry As String

        Public Property colPracticeId() As Nullable(Of Integer) Implements IrowVwRRExpiringExpiredExpectedCompletedDate.colPracticeId
            Get
                Return m_colPracticeId
            End Get
            Set
                If Not Same(m_colPracticeId, Value) Then
                    m_colPracticeId = Value
                    m_IsDirty(FieldIndex.colPracticeId) = True
                End If
            End Set
        End Property
        Private m_colPracticeId As Nullable(Of Integer)

        Public Property colRRLogID() As Nullable(Of Integer) Implements IrowVwRRExpiringExpiredExpectedCompletedDate.colRRLogID
            Get
                Return m_colRRLogID
            End Get
            Set
                If Not Same(m_colRRLogID, Value) Then
                    m_colRRLogID = Value
                    m_IsDirty(FieldIndex.colRRLogID) = True
                End If
            End Set
        End Property
        Private m_colRRLogID As Nullable(Of Integer)

        Public Property colRecipientName() As String Implements IrowVwRRExpiringExpiredExpectedCompletedDate.colRecipientName
            Get
                Return m_colRecipientName
            End Get
            Set
                If Not Same(m_colRecipientName, Value) Then
                    m_colRecipientName = Value
                    m_IsDirty(FieldIndex.colRecipientName) = True
                End If
            End Set
        End Property
        Private m_colRecipientName As String

        Public Property colRecipientEmail() As String Implements IrowVwRRExpiringExpiredExpectedCompletedDate.colRecipientEmail
            Get
                Return m_colRecipientEmail
            End Get
            Set
                If Not Same(m_colRecipientEmail, Value) Then
                    m_colRecipientEmail = Value
                    m_IsDirty(FieldIndex.colRecipientEmail) = True
                End If
            End Set
        End Property
        Private m_colRecipientEmail As String

        Public Property colPracticeName() As String Implements IrowVwRRExpiringExpiredExpectedCompletedDate.colPracticeName
            Get
                Return m_colPracticeName
            End Get
            Set
                If Not Same(m_colPracticeName, Value) Then
                    m_colPracticeName = Value
                    m_IsDirty(FieldIndex.colPracticeName) = True
                End If
            End Set
        End Property
        Private m_colPracticeName As String


        Public Function IsDirty(pIndex As rowVwRRExpiringExpiredExpectedCompletedDate.FieldIndex) As Boolean Implements IrowVwRRExpiringExpiredExpectedCompletedDate.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwRRExpiringExpiredExpectedCompletedDate.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwRRExpiringExpiredExpectedCompletedDate.SetIsDirty
            m_IsDirty(FieldIndex.colRowNo) = pDirty
            m_IsDirty(FieldIndex.colFilePrefix) = pDirty
            m_IsDirty(FieldIndex.colFileNo) = pDirty
            m_IsDirty(FieldIndex.colDivision) = pDirty
            m_IsDirty(FieldIndex.colCustomAccess) = pDirty
            m_IsDirty(FieldIndex.colClientLocNo) = pDirty
            m_IsDirty(FieldIndex.colFacility) = pDirty
            m_IsDirty(FieldIndex.colCity) = pDirty
            m_IsDirty(FieldIndex.colStProv) = pDirty
            m_IsDirty(FieldIndex.colCountry) = pDirty
            m_IsDirty(FieldIndex.colPracticeId) = pDirty
            m_IsDirty(FieldIndex.colRRLogID) = pDirty
            m_IsDirty(FieldIndex.colRecipientName) = pDirty
            m_IsDirty(FieldIndex.colRecipientEmail) = pDirty
            m_IsDirty(FieldIndex.colPracticeName) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwRRExpiringExpiredExpectedCompletedDate) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwRRExpiringExpiredExpectedCompletedDate
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colRowNo  = 1
            colFilePrefix 
            colFileNo 
            colDivision 
            colCustomAccess 
            colClientLocNo 
            colFacility 
            colCity 
            colStProv 
            colCountry 
            colPracticeId 
            colRRLogID 
            colRecipientName 
            colRecipientEmail 
            colPracticeName 
        End Enum

        Private m_IsDirty(15) As Boolean

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

    Public Interface IrowVwRRExpiringExpiredExpectedCompletedDate
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colRowNo() As Nullable(Of Long)
        Property colFilePrefix() As String
        Property colFileNo() As String
        Property colDivision() As String
        Property colCustomAccess() As String
        Property colClientLocNo() As String
        Property colFacility() As String
        Property colCity() As String
        Property colStProv() As String
        Property colCountry() As String
        Property colPracticeId() As Nullable(Of Integer)
        Property colRRLogID() As Nullable(Of Integer)
        Property colRecipientName() As String
        Property colRecipientEmail() As String
        Property colPracticeName() As String
        Function IsDirty(pIndex As rowVwRRExpiringExpiredExpectedCompletedDate.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

