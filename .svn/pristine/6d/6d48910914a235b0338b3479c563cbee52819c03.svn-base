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
    Partial Public Class VwAdminNoteTextBox

        Public Shared Function LoadData() As List(Of rowVwAdminNoteTextBox)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwAdminNoteTextBox)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwAdminNoteTextBox)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwAdminNoteTextBox)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwAdminNoteTextBox)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwAdminNoteTextBox)
            Dim zReturn As New List(Of rowVwAdminNoteTextBox)
            Dim zSQL As String = "SELECT * FROM [adm].[vwAdminNoteTextBox]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwAdminNoteTextBox)

			Try
	            Dim zReturn As New List(Of rowVwAdminNoteTextBox)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwAdminNoteTextBox

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwAdminNoteTextBox		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwAdminNoteTextBox)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldNoteID")) Then pObject.colFldNoteID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldNoteID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldNote")) Then pObject.colFldNote = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldNote")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldCreateBy")) Then pObject.colFldCreateBy = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldCreateBy")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldCreateDateTime")) Then pObject.colFldCreateDateTime = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "fldCreateDateTime")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldUpdateBy")) Then pObject.colFldUpdateBy = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldUpdateBy")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldUpdateDateTime")) Then pObject.colFldUpdateDateTime = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "fldUpdateDateTime")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldPracticeGroupCd")) Then pObject.colFldPracticeGroupCd = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldPracticeGroupCd")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldTextBoxLabel")) Then pObject.colFldTextBoxLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldTextBoxLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldEmptyMessage")) Then pObject.colFldEmptyMessage = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldEmptyMessage")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldMaxCharacters")) Then pObject.colFldMaxCharacters = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldMaxCharacters")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSort")) Then pObject.colFldSort = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldSort")
			If Not pReader.IsDBNull(pReader.GetOrdinal("InspectionID")) Then pObject.colInspectionID = UtilSQLServer.SafeReader.SafeReadString(pReader, "InspectionID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PracticeCode")) Then pObject.colPracticeCode = UtilSQLServer.SafeReader.SafeReadInt16(pReader, "PracticeCode")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldExcludeInXL")) Then pObject.colFldExcludeInXL = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldExcludeInXL")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FileNo")) Then pObject.colFileNo = UtilSQLServer.SafeReader.SafeReadString(pReader, "FileNo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DisplayText")) Then pObject.colDisplayText = UtilSQLServer.SafeReader.SafeReadString(pReader, "DisplayText")
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
            Dim zSQL As String = "SELECT * FROM [adm].[vwAdminNoteTextBox]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class

    Partial Public Class rowVwAdminNoteTextBox
        Implements IrowVwAdminNoteTextBox

        Public Event Loaded(pUserState As Object) Implements IrowVwAdminNoteTextBox.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwAdminNoteTextBox.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwAdminNoteTextBox.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwAdminNoteTextBox.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwAdminNoteTextBox.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwAdminNoteTextBox.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldNoteID() As Nullable(Of Integer) Implements IrowVwAdminNoteTextBox.colFldNoteID
            Get
                Return m_colFldNoteID
            End Get
            Set
                If Not Same(m_colFldNoteID, Value) Then
                    m_colFldNoteID = Value
                    m_IsDirty(FieldIndex.colFldNoteID) = True
                End If
            End Set
        End Property
        Private m_colFldNoteID As Nullable(Of Integer)

        Public Property colFldNote() As String Implements IrowVwAdminNoteTextBox.colFldNote
            Get
                Return m_colFldNote
            End Get
            Set
                If Not Same(m_colFldNote, Value) Then
                    m_colFldNote = Value
                    m_IsDirty(FieldIndex.colFldNote) = True
                End If
            End Set
        End Property
        Private m_colFldNote As String

        Public Property colFldCreateBy() As String Implements IrowVwAdminNoteTextBox.colFldCreateBy
            Get
                Return m_colFldCreateBy
            End Get
            Set
                If Not Same(m_colFldCreateBy, Value) Then
                    m_colFldCreateBy = Value
                    m_IsDirty(FieldIndex.colFldCreateBy) = True
                End If
            End Set
        End Property
        Private m_colFldCreateBy As String

        Public Property colFldCreateDateTime() As Nullable(Of DateTime) Implements IrowVwAdminNoteTextBox.colFldCreateDateTime
            Get
                Return m_colFldCreateDateTime
            End Get
            Set
                If Not Same(m_colFldCreateDateTime, Value) Then
                    m_colFldCreateDateTime = Value
                    m_IsDirty(FieldIndex.colFldCreateDateTime) = True
                End If
            End Set
        End Property
        Private m_colFldCreateDateTime As Nullable(Of DateTime)

        Public Property colFldUpdateBy() As String Implements IrowVwAdminNoteTextBox.colFldUpdateBy
            Get
                Return m_colFldUpdateBy
            End Get
            Set
                If Not Same(m_colFldUpdateBy, Value) Then
                    m_colFldUpdateBy = Value
                    m_IsDirty(FieldIndex.colFldUpdateBy) = True
                End If
            End Set
        End Property
        Private m_colFldUpdateBy As String

        Public Property colFldUpdateDateTime() As Nullable(Of DateTime) Implements IrowVwAdminNoteTextBox.colFldUpdateDateTime
            Get
                Return m_colFldUpdateDateTime
            End Get
            Set
                If Not Same(m_colFldUpdateDateTime, Value) Then
                    m_colFldUpdateDateTime = Value
                    m_IsDirty(FieldIndex.colFldUpdateDateTime) = True
                End If
            End Set
        End Property
        Private m_colFldUpdateDateTime As Nullable(Of DateTime)

        Public Property colFldPracticeGroupCd() As String Implements IrowVwAdminNoteTextBox.colFldPracticeGroupCd
            Get
                Return m_colFldPracticeGroupCd
            End Get
            Set
                If Not Same(m_colFldPracticeGroupCd, Value) Then
                    m_colFldPracticeGroupCd = Value
                    m_IsDirty(FieldIndex.colFldPracticeGroupCd) = True
                End If
            End Set
        End Property
        Private m_colFldPracticeGroupCd As String

        Public Property colFldTextBoxLabel() As String Implements IrowVwAdminNoteTextBox.colFldTextBoxLabel
            Get
                Return m_colFldTextBoxLabel
            End Get
            Set
                If Not Same(m_colFldTextBoxLabel, Value) Then
                    m_colFldTextBoxLabel = Value
                    m_IsDirty(FieldIndex.colFldTextBoxLabel) = True
                End If
            End Set
        End Property
        Private m_colFldTextBoxLabel As String

        Public Property colFldEmptyMessage() As String Implements IrowVwAdminNoteTextBox.colFldEmptyMessage
            Get
                Return m_colFldEmptyMessage
            End Get
            Set
                If Not Same(m_colFldEmptyMessage, Value) Then
                    m_colFldEmptyMessage = Value
                    m_IsDirty(FieldIndex.colFldEmptyMessage) = True
                End If
            End Set
        End Property
        Private m_colFldEmptyMessage As String

        Public Property colFldMaxCharacters() As Nullable(Of Integer) Implements IrowVwAdminNoteTextBox.colFldMaxCharacters
            Get
                Return m_colFldMaxCharacters
            End Get
            Set
                If Not Same(m_colFldMaxCharacters, Value) Then
                    m_colFldMaxCharacters = Value
                    m_IsDirty(FieldIndex.colFldMaxCharacters) = True
                End If
            End Set
        End Property
        Private m_colFldMaxCharacters As Nullable(Of Integer)

        Public Property colFldSort() As Nullable(Of Integer) Implements IrowVwAdminNoteTextBox.colFldSort
            Get
                Return m_colFldSort
            End Get
            Set
                If Not Same(m_colFldSort, Value) Then
                    m_colFldSort = Value
                    m_IsDirty(FieldIndex.colFldSort) = True
                End If
            End Set
        End Property
        Private m_colFldSort As Nullable(Of Integer)

        Public Property colInspectionID() As String Implements IrowVwAdminNoteTextBox.colInspectionID
            Get
                Return m_colInspectionID
            End Get
            Set
                If Not Same(m_colInspectionID, Value) Then
                    m_colInspectionID = Value
                    m_IsDirty(FieldIndex.colInspectionID) = True
                End If
            End Set
        End Property
        Private m_colInspectionID As String

        Public Property colPracticeCode() As Nullable(Of Short) Implements IrowVwAdminNoteTextBox.colPracticeCode
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

        Public Property colFldExcludeInXL() As Nullable(Of Boolean) Implements IrowVwAdminNoteTextBox.colFldExcludeInXL
            Get
                Return m_colFldExcludeInXL
            End Get
            Set
                If Not Same(m_colFldExcludeInXL, Value) Then
                    m_colFldExcludeInXL = Value
                    m_IsDirty(FieldIndex.colFldExcludeInXL) = True
                End If
            End Set
        End Property
        Private m_colFldExcludeInXL As Nullable(Of Boolean)

        Public Property colFileNo() As String Implements IrowVwAdminNoteTextBox.colFileNo
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

        Public Property colDisplayText() As String Implements IrowVwAdminNoteTextBox.colDisplayText
            Get
                Return m_colDisplayText
            End Get
            Set
                If Not Same(m_colDisplayText, Value) Then
                    m_colDisplayText = Value
                    m_IsDirty(FieldIndex.colDisplayText) = True
                End If
            End Set
        End Property
        Private m_colDisplayText As String


        Public Function IsDirty(pIndex As rowVwAdminNoteTextBox.FieldIndex) As Boolean Implements IrowVwAdminNoteTextBox.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwAdminNoteTextBox.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwAdminNoteTextBox.SetIsDirty
            m_IsDirty(FieldIndex.colFldNoteID) = pDirty
            m_IsDirty(FieldIndex.colFldNote) = pDirty
            m_IsDirty(FieldIndex.colFldCreateBy) = pDirty
            m_IsDirty(FieldIndex.colFldCreateDateTime) = pDirty
            m_IsDirty(FieldIndex.colFldUpdateBy) = pDirty
            m_IsDirty(FieldIndex.colFldUpdateDateTime) = pDirty
            m_IsDirty(FieldIndex.colFldPracticeGroupCd) = pDirty
            m_IsDirty(FieldIndex.colFldTextBoxLabel) = pDirty
            m_IsDirty(FieldIndex.colFldEmptyMessage) = pDirty
            m_IsDirty(FieldIndex.colFldMaxCharacters) = pDirty
            m_IsDirty(FieldIndex.colFldSort) = pDirty
            m_IsDirty(FieldIndex.colInspectionID) = pDirty
            m_IsDirty(FieldIndex.colPracticeCode) = pDirty
            m_IsDirty(FieldIndex.colFldExcludeInXL) = pDirty
            m_IsDirty(FieldIndex.colFileNo) = pDirty
            m_IsDirty(FieldIndex.colDisplayText) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwAdminNoteTextBox) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwAdminNoteTextBox
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldNoteID  = 1
            colFldNote 
            colFldCreateBy 
            colFldCreateDateTime 
            colFldUpdateBy 
            colFldUpdateDateTime 
            colFldPracticeGroupCd 
            colFldTextBoxLabel 
            colFldEmptyMessage 
            colFldMaxCharacters 
            colFldSort 
            colInspectionID 
            colPracticeCode 
            colFldExcludeInXL 
            colFileNo 
            colDisplayText 
        End Enum

        Private m_IsDirty(16) As Boolean

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

    Public Interface IrowVwAdminNoteTextBox
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldNoteID() As Nullable(Of Integer)
        Property colFldNote() As String
        Property colFldCreateBy() As String
        Property colFldCreateDateTime() As Nullable(Of DateTime)
        Property colFldUpdateBy() As String
        Property colFldUpdateDateTime() As Nullable(Of DateTime)
        Property colFldPracticeGroupCd() As String
        Property colFldTextBoxLabel() As String
        Property colFldEmptyMessage() As String
        Property colFldMaxCharacters() As Nullable(Of Integer)
        Property colFldSort() As Nullable(Of Integer)
        Property colInspectionID() As String
        Property colPracticeCode() As Nullable(Of Short)
        Property colFldExcludeInXL() As Nullable(Of Boolean)
        Property colFileNo() As String
        Property colDisplayText() As String
        Function IsDirty(pIndex As rowVwAdminNoteTextBox.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

