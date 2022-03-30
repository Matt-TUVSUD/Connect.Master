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
    Partial Public Class VwMetaRatingKeyRange

        Public Shared Function LoadData() As List(Of rowVwMetaRatingKeyRange)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwMetaRatingKeyRange)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwMetaRatingKeyRange)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwMetaRatingKeyRange)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwMetaRatingKeyRange)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwMetaRatingKeyRange)
            Dim zReturn As New List(Of rowVwMetaRatingKeyRange)
            Dim zSQL As String = "SELECT * FROM [dbo].[vwMetaRatingKeyRange]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwMetaRatingKeyRange)

			Try
	            Dim zReturn As New List(Of rowVwMetaRatingKeyRange)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwMetaRatingKeyRange

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwMetaRatingKeyRange		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwMetaRatingKeyRange)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldKeyId")) Then pObject.colFldKeyId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldKeyId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldRating")) Then pObject.colFldRating = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldRating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldDescription")) Then pObject.colFldDescription = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldDescription")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldScoreLow")) Then pObject.colFldScoreLow = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "fldScoreLow")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldScoreHigh")) Then pObject.colFldScoreHigh = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "fldScoreHigh")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldMetaColorId")) Then pObject.colFldMetaColorId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldMetaColorId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldPSRatingKey")) Then pObject.colFldPSRatingKey = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldPSRatingKey")
			If Not pReader.IsDBNull(pReader.GetOrdinal("HexBackColor")) Then pObject.colHexBackColor = UtilSQLServer.SafeReader.SafeReadString(pReader, "HexBackColor")
			If Not pReader.IsDBNull(pReader.GetOrdinal("HexForeColor")) Then pObject.colHexForeColor = UtilSQLServer.SafeReader.SafeReadString(pReader, "HexForeColor")
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
            Dim zSQL As String = "SELECT * FROM [dbo].[vwMetaRatingKeyRange]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowVwMetaRatingKeyRange
        Implements IrowVwMetaRatingKeyRange

        Public Event Loaded(pUserState As Object) Implements IrowVwMetaRatingKeyRange.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwMetaRatingKeyRange.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwMetaRatingKeyRange.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwMetaRatingKeyRange.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwMetaRatingKeyRange.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwMetaRatingKeyRange.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldKeyId() As Nullable(Of Integer) Implements IrowVwMetaRatingKeyRange.colFldKeyId
            Get
                Return m_colFldKeyId
            End Get
            Set
                If Not Same(m_colFldKeyId, Value) Then
                    m_colFldKeyId = Value
                    m_IsDirty(FieldIndex.colFldKeyId) = True
                End If
            End Set
        End Property
        Private m_colFldKeyId As Nullable(Of Integer)

        Public Property colFldRating() As String Implements IrowVwMetaRatingKeyRange.colFldRating
            Get
                Return m_colFldRating
            End Get
            Set
                If Not Same(m_colFldRating, Value) Then
                    m_colFldRating = Value
                    m_IsDirty(FieldIndex.colFldRating) = True
                End If
            End Set
        End Property
        Private m_colFldRating As String

        Public Property colFldDescription() As String Implements IrowVwMetaRatingKeyRange.colFldDescription
            Get
                Return m_colFldDescription
            End Get
            Set
                If Not Same(m_colFldDescription, Value) Then
                    m_colFldDescription = Value
                    m_IsDirty(FieldIndex.colFldDescription) = True
                End If
            End Set
        End Property
        Private m_colFldDescription As String

        Public Property colFldScoreLow() As Nullable(Of Double) Implements IrowVwMetaRatingKeyRange.colFldScoreLow
            Get
                Return m_colFldScoreLow
            End Get
            Set
                If Not Same(m_colFldScoreLow, Value) Then
                    m_colFldScoreLow = Value
                    m_IsDirty(FieldIndex.colFldScoreLow) = True
                End If
            End Set
        End Property
        Private m_colFldScoreLow As Nullable(Of Double)

        Public Property colFldScoreHigh() As Nullable(Of Double) Implements IrowVwMetaRatingKeyRange.colFldScoreHigh
            Get
                Return m_colFldScoreHigh
            End Get
            Set
                If Not Same(m_colFldScoreHigh, Value) Then
                    m_colFldScoreHigh = Value
                    m_IsDirty(FieldIndex.colFldScoreHigh) = True
                End If
            End Set
        End Property
        Private m_colFldScoreHigh As Nullable(Of Double)

        Public Property colFldMetaColorId() As Nullable(Of Integer) Implements IrowVwMetaRatingKeyRange.colFldMetaColorId
            Get
                Return m_colFldMetaColorId
            End Get
            Set
                If Not Same(m_colFldMetaColorId, Value) Then
                    m_colFldMetaColorId = Value
                    m_IsDirty(FieldIndex.colFldMetaColorId) = True
                End If
            End Set
        End Property
        Private m_colFldMetaColorId As Nullable(Of Integer)

        Public Property colFldPSRatingKey() As String Implements IrowVwMetaRatingKeyRange.colFldPSRatingKey
            Get
                Return m_colFldPSRatingKey
            End Get
            Set
                If Not Same(m_colFldPSRatingKey, Value) Then
                    m_colFldPSRatingKey = Value
                    m_IsDirty(FieldIndex.colFldPSRatingKey) = True
                End If
            End Set
        End Property
        Private m_colFldPSRatingKey As String

        Public Property colHexBackColor() As String Implements IrowVwMetaRatingKeyRange.colHexBackColor
            Get
                Return m_colHexBackColor
            End Get
            Set
                If Not Same(m_colHexBackColor, Value) Then
                    m_colHexBackColor = Value
                    m_IsDirty(FieldIndex.colHexBackColor) = True
                End If
            End Set
        End Property
        Private m_colHexBackColor As String

        Public Property colHexForeColor() As String Implements IrowVwMetaRatingKeyRange.colHexForeColor
            Get
                Return m_colHexForeColor
            End Get
            Set
                If Not Same(m_colHexForeColor, Value) Then
                    m_colHexForeColor = Value
                    m_IsDirty(FieldIndex.colHexForeColor) = True
                End If
            End Set
        End Property
        Private m_colHexForeColor As String


        Public Function IsDirty(pIndex As rowVwMetaRatingKeyRange.FieldIndex) As Boolean Implements IrowVwMetaRatingKeyRange.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwMetaRatingKeyRange.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwMetaRatingKeyRange.SetIsDirty
            m_IsDirty(FieldIndex.colFldKeyId) = pDirty
            m_IsDirty(FieldIndex.colFldRating) = pDirty
            m_IsDirty(FieldIndex.colFldDescription) = pDirty
            m_IsDirty(FieldIndex.colFldScoreLow) = pDirty
            m_IsDirty(FieldIndex.colFldScoreHigh) = pDirty
            m_IsDirty(FieldIndex.colFldMetaColorId) = pDirty
            m_IsDirty(FieldIndex.colFldPSRatingKey) = pDirty
            m_IsDirty(FieldIndex.colHexBackColor) = pDirty
            m_IsDirty(FieldIndex.colHexForeColor) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwMetaRatingKeyRange) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwMetaRatingKeyRange
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldKeyId  = 1
            colFldRating 
            colFldDescription 
            colFldScoreLow 
            colFldScoreHigh 
            colFldMetaColorId 
            colFldPSRatingKey 
            colHexBackColor 
            colHexForeColor 
        End Enum

        Private m_IsDirty(9) As Boolean

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

    Public Interface IrowVwMetaRatingKeyRange
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldKeyId() As Nullable(Of Integer)
        Property colFldRating() As String
        Property colFldDescription() As String
        Property colFldScoreLow() As Nullable(Of Double)
        Property colFldScoreHigh() As Nullable(Of Double)
        Property colFldMetaColorId() As Nullable(Of Integer)
        Property colFldPSRatingKey() As String
        Property colHexBackColor() As String
        Property colHexForeColor() As String
        Function IsDirty(pIndex As rowVwMetaRatingKeyRange.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

