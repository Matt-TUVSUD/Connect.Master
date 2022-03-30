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
    Partial Public Class VwRRLogFollowUp

        Public Shared Function LoadData() As List(Of rowVwRRLogFollowUp)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwRRLogFollowUp)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwRRLogFollowUp)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwRRLogFollowUp)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwRRLogFollowUp)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwRRLogFollowUp)
            Dim zReturn As New List(Of rowVwRRLogFollowUp)
            Dim zSQL As String = "SELECT * FROM [jv].[vwRRLogFollowUp]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwRRLogFollowUp)

			Try
	            Dim zReturn As New List(Of rowVwRRLogFollowUp)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwRRLogFollowUp

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwRRLogFollowUp		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwRRLogFollowUp)
			If Not pReader.IsDBNull(pReader.GetOrdinal("RowNO")) Then pObject.colRowNO = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "RowNO")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Id")) Then pObject.colId = UtilSQLServer.SafeReader.SafeReadString(pReader, "Id")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FollowUpStatus")) Then pObject.colFollowUpStatus = UtilSQLServer.SafeReader.SafeReadString(pReader, "FollowUpStatus")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RRLogId")) Then pObject.colRRLogId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "RRLogId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FollowUp")) Then pObject.colFollowUp = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "FollowUp")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PracticeCode")) Then pObject.colPracticeCode = UtilSQLServer.SafeReader.SafeReadInt16(pReader, "PracticeCode")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FileNo")) Then pObject.colFileNo = UtilSQLServer.SafeReader.SafeReadString(pReader, "FileNo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DateStamp")) Then pObject.colDateStamp = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "DateStamp")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RecsNeedingResponses")) Then pObject.colRecsNeedingResponses = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "RecsNeedingResponses")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PracticeGroup")) Then pObject.colPracticeGroup = UtilSQLServer.SafeReader.SafeReadString(pReader, "PracticeGroup")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FilePrefix")) Then pObject.colFilePrefix = UtilSQLServer.SafeReader.SafeReadString(pReader, "FilePrefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PracticeId")) Then pObject.colPracticeId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "PracticeId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RFU1Date")) Then pObject.colRFU1Date = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "RFU1Date")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RFU2Date")) Then pObject.colRFU2Date = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "RFU2Date")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RFU3Date")) Then pObject.colRFU3Date = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "RFU3Date")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LastInspectionDate")) Then pObject.colLastInspectionDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "LastInspectionDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DaysSinceDateStamp")) Then pObject.colDaysSinceDateStamp = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "DaysSinceDateStamp")
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
            Dim zSQL As String = "SELECT * FROM [jv].[vwRRLogFollowUp]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowVwRRLogFollowUp
        Implements IrowVwRRLogFollowUp

        Public Event Loaded(pUserState As Object) Implements IrowVwRRLogFollowUp.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwRRLogFollowUp.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwRRLogFollowUp.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwRRLogFollowUp.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwRRLogFollowUp.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwRRLogFollowUp.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colRowNO() As Nullable(Of Long) Implements IrowVwRRLogFollowUp.colRowNO
            Get
                Return m_colRowNO
            End Get
            Set
                If Not Same(m_colRowNO, Value) Then
                    m_colRowNO = Value
                    m_IsDirty(FieldIndex.colRowNO) = True
                End If
            End Set
        End Property
        Private m_colRowNO As Nullable(Of Long)

        Public Property colId() As String Implements IrowVwRRLogFollowUp.colId
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
        Private m_colId As String

        Public Property colFollowUpStatus() As String Implements IrowVwRRLogFollowUp.colFollowUpStatus
            Get
                Return m_colFollowUpStatus
            End Get
            Set
                If Not Same(m_colFollowUpStatus, Value) Then
                    m_colFollowUpStatus = Value
                    m_IsDirty(FieldIndex.colFollowUpStatus) = True
                End If
            End Set
        End Property
        Private m_colFollowUpStatus As String

        Public Property colRRLogId() As Nullable(Of Integer) Implements IrowVwRRLogFollowUp.colRRLogId
            Get
                Return m_colRRLogId
            End Get
            Set
                If Not Same(m_colRRLogId, Value) Then
                    m_colRRLogId = Value
                    m_IsDirty(FieldIndex.colRRLogId) = True
                End If
            End Set
        End Property
        Private m_colRRLogId As Nullable(Of Integer)

        Public Property colFollowUp() As Nullable(Of Integer) Implements IrowVwRRLogFollowUp.colFollowUp
            Get
                Return m_colFollowUp
            End Get
            Set
                If Not Same(m_colFollowUp, Value) Then
                    m_colFollowUp = Value
                    m_IsDirty(FieldIndex.colFollowUp) = True
                End If
            End Set
        End Property
        Private m_colFollowUp As Nullable(Of Integer)

        Public Property colPracticeCode() As Nullable(Of Short) Implements IrowVwRRLogFollowUp.colPracticeCode
            Get
                Return m_colPracticeCode
            End Get
            Set
                If Not Same(m_colPracticeCode, Value) Then
                    m_colPracticeCode = Value
                    m_IsDirty(FieldIndex.colPracticeCode) = True
                End If
            End Set
        End Property
        Private m_colPracticeCode As Nullable(Of Short)

        Public Property colFileNo() As String Implements IrowVwRRLogFollowUp.colFileNo
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

        Public Property colDateStamp() As Nullable(Of DateTime) Implements IrowVwRRLogFollowUp.colDateStamp
            Get
                Return m_colDateStamp
            End Get
            Set
                If Not Same(m_colDateStamp, Value) Then
                    m_colDateStamp = Value
                    m_IsDirty(FieldIndex.colDateStamp) = True
                End If
            End Set
        End Property
        Private m_colDateStamp As Nullable(Of DateTime)

        Public Property colRecsNeedingResponses() As Nullable(Of Integer) Implements IrowVwRRLogFollowUp.colRecsNeedingResponses
            Get
                Return m_colRecsNeedingResponses
            End Get
            Set
                If Not Same(m_colRecsNeedingResponses, Value) Then
                    m_colRecsNeedingResponses = Value
                    m_IsDirty(FieldIndex.colRecsNeedingResponses) = True
                End If
            End Set
        End Property
        Private m_colRecsNeedingResponses As Nullable(Of Integer)

        Public Property colPracticeGroup() As String Implements IrowVwRRLogFollowUp.colPracticeGroup
            Get
                Return m_colPracticeGroup
            End Get
            Set
                If Not Same(m_colPracticeGroup, Value) Then
                    m_colPracticeGroup = Value
                    m_IsDirty(FieldIndex.colPracticeGroup) = True
                End If
            End Set
        End Property
        Private m_colPracticeGroup As String

        Public Property colFilePrefix() As String Implements IrowVwRRLogFollowUp.colFilePrefix
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

        Public Property colPracticeId() As Nullable(Of Integer) Implements IrowVwRRLogFollowUp.colPracticeId
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

        Public Property colRFU1Date() As Nullable(Of DateTime) Implements IrowVwRRLogFollowUp.colRFU1Date
            Get
                Return m_colRFU1Date
            End Get
            Set
                If Not Same(m_colRFU1Date, Value) Then
                    m_colRFU1Date = Value
                    m_IsDirty(FieldIndex.colRFU1Date) = True
                End If
            End Set
        End Property
        Private m_colRFU1Date As Nullable(Of DateTime)

        Public Property colRFU2Date() As Nullable(Of DateTime) Implements IrowVwRRLogFollowUp.colRFU2Date
            Get
                Return m_colRFU2Date
            End Get
            Set
                If Not Same(m_colRFU2Date, Value) Then
                    m_colRFU2Date = Value
                    m_IsDirty(FieldIndex.colRFU2Date) = True
                End If
            End Set
        End Property
        Private m_colRFU2Date As Nullable(Of DateTime)

        Public Property colRFU3Date() As Nullable(Of DateTime) Implements IrowVwRRLogFollowUp.colRFU3Date
            Get
                Return m_colRFU3Date
            End Get
            Set
                If Not Same(m_colRFU3Date, Value) Then
                    m_colRFU3Date = Value
                    m_IsDirty(FieldIndex.colRFU3Date) = True
                End If
            End Set
        End Property
        Private m_colRFU3Date As Nullable(Of DateTime)

        Public Property colLastInspectionDate() As Nullable(Of DateTime) Implements IrowVwRRLogFollowUp.colLastInspectionDate
            Get
                Return m_colLastInspectionDate
            End Get
            Set
                If Not Same(m_colLastInspectionDate, Value) Then
                    m_colLastInspectionDate = Value
                    m_IsDirty(FieldIndex.colLastInspectionDate) = True
                End If
            End Set
        End Property
        Private m_colLastInspectionDate As Nullable(Of DateTime)

        Public Property colDaysSinceDateStamp() As Nullable(Of Integer) Implements IrowVwRRLogFollowUp.colDaysSinceDateStamp
            Get
                Return m_colDaysSinceDateStamp
            End Get
            Set
                If Not Same(m_colDaysSinceDateStamp, Value) Then
                    m_colDaysSinceDateStamp = Value
                    m_IsDirty(FieldIndex.colDaysSinceDateStamp) = True
                End If
            End Set
        End Property
        Private m_colDaysSinceDateStamp As Nullable(Of Integer)


        Public Function IsDirty(pIndex As rowVwRRLogFollowUp.FieldIndex) As Boolean Implements IrowVwRRLogFollowUp.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwRRLogFollowUp.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwRRLogFollowUp.SetIsDirty
            m_IsDirty(FieldIndex.colRowNO) = pDirty
            m_IsDirty(FieldIndex.colId) = pDirty
            m_IsDirty(FieldIndex.colFollowUpStatus) = pDirty
            m_IsDirty(FieldIndex.colRRLogId) = pDirty
            m_IsDirty(FieldIndex.colFollowUp) = pDirty
            m_IsDirty(FieldIndex.colPracticeCode) = pDirty
            m_IsDirty(FieldIndex.colFileNo) = pDirty
            m_IsDirty(FieldIndex.colDateStamp) = pDirty
            m_IsDirty(FieldIndex.colRecsNeedingResponses) = pDirty
            m_IsDirty(FieldIndex.colPracticeGroup) = pDirty
            m_IsDirty(FieldIndex.colFilePrefix) = pDirty
            m_IsDirty(FieldIndex.colPracticeId) = pDirty
            m_IsDirty(FieldIndex.colRFU1Date) = pDirty
            m_IsDirty(FieldIndex.colRFU2Date) = pDirty
            m_IsDirty(FieldIndex.colRFU3Date) = pDirty
            m_IsDirty(FieldIndex.colLastInspectionDate) = pDirty
            m_IsDirty(FieldIndex.colDaysSinceDateStamp) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwRRLogFollowUp) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwRRLogFollowUp
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colRowNO  = 1
            colId 
            colFollowUpStatus 
            colRRLogId 
            colFollowUp 
            colPracticeCode 
            colFileNo 
            colDateStamp 
            colRecsNeedingResponses 
            colPracticeGroup 
            colFilePrefix 
            colPracticeId 
            colRFU1Date 
            colRFU2Date 
            colRFU3Date 
            colLastInspectionDate 
            colDaysSinceDateStamp 
        End Enum

        Private m_IsDirty(17) As Boolean

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

    Public Interface IrowVwRRLogFollowUp
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colRowNO() As Nullable(Of Long)
        Property colId() As String
        Property colFollowUpStatus() As String
        Property colRRLogId() As Nullable(Of Integer)
        Property colFollowUp() As Nullable(Of Integer)
        Property colPracticeCode() As Nullable(Of Short)
        Property colFileNo() As String
        Property colDateStamp() As Nullable(Of DateTime)
        Property colRecsNeedingResponses() As Nullable(Of Integer)
        Property colPracticeGroup() As String
        Property colFilePrefix() As String
        Property colPracticeId() As Nullable(Of Integer)
        Property colRFU1Date() As Nullable(Of DateTime)
        Property colRFU2Date() As Nullable(Of DateTime)
        Property colRFU3Date() As Nullable(Of DateTime)
        Property colLastInspectionDate() As Nullable(Of DateTime)
        Property colDaysSinceDateStamp() As Nullable(Of Integer)
        Function IsDirty(pIndex As rowVwRRLogFollowUp.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

