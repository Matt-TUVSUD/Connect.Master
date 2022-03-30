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
    Partial Public Class VwMetaColor

        Public Shared Function LoadData() As List(Of rowVwMetaColor)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwMetaColor)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwMetaColor)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwMetaColor)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwMetaColor)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwMetaColor)
            Dim zReturn As New List(Of rowVwMetaColor)
            Dim zSQL As String = "SELECT * FROM [dbo].[vwMetaColor]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwMetaColor)

			Try
	            Dim zReturn As New List(Of rowVwMetaColor)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwMetaColor

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwMetaColor		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwMetaColor)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldId")) Then pObject.colFldId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldColor")) Then pObject.colFldColor = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldColor")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldHex")) Then pObject.colFldHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldR")) Then pObject.colFldR = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldR")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldG")) Then pObject.colFldG = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldG")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldB")) Then pObject.colFldB = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldB")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldA")) Then pObject.colFldA = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "fldA")
			If Not pReader.IsDBNull(pReader.GetOrdinal("UseForeColorHex")) Then pObject.colUseForeColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "UseForeColorHex")
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
            Dim zSQL As String = "SELECT * FROM [dbo].[vwMetaColor]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowVwMetaColor
        Implements IrowVwMetaColor

        Public Event Loaded(pUserState As Object) Implements IrowVwMetaColor.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwMetaColor.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwMetaColor.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwMetaColor.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwMetaColor.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwMetaColor.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldId() As Nullable(Of Integer) Implements IrowVwMetaColor.colFldId
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

        Public Property colFldColor() As String Implements IrowVwMetaColor.colFldColor
            Get
                Return m_colFldColor
            End Get
            Set
                If Not Same(m_colFldColor, Value) Then
                    m_colFldColor = Value
                    m_IsDirty(FieldIndex.colFldColor) = True
                End If
            End Set
        End Property
        Private m_colFldColor As String

        Public Property colFldHex() As String Implements IrowVwMetaColor.colFldHex
            Get
                Return m_colFldHex
            End Get
            Set
                If Not Same(m_colFldHex, Value) Then
                    m_colFldHex = Value
                    m_IsDirty(FieldIndex.colFldHex) = True
                End If
            End Set
        End Property
        Private m_colFldHex As String

        Public Property colFldR() As Nullable(Of Integer) Implements IrowVwMetaColor.colFldR
            Get
                Return m_colFldR
            End Get
            Set
                If Not Same(m_colFldR, Value) Then
                    m_colFldR = Value
                    m_IsDirty(FieldIndex.colFldR) = True
                End If
            End Set
        End Property
        Private m_colFldR As Nullable(Of Integer)

        Public Property colFldG() As Nullable(Of Integer) Implements IrowVwMetaColor.colFldG
            Get
                Return m_colFldG
            End Get
            Set
                If Not Same(m_colFldG, Value) Then
                    m_colFldG = Value
                    m_IsDirty(FieldIndex.colFldG) = True
                End If
            End Set
        End Property
        Private m_colFldG As Nullable(Of Integer)

        Public Property colFldB() As Nullable(Of Integer) Implements IrowVwMetaColor.colFldB
            Get
                Return m_colFldB
            End Get
            Set
                If Not Same(m_colFldB, Value) Then
                    m_colFldB = Value
                    m_IsDirty(FieldIndex.colFldB) = True
                End If
            End Set
        End Property
        Private m_colFldB As Nullable(Of Integer)

        Public Property colFldA() As Nullable(Of Decimal) Implements IrowVwMetaColor.colFldA
            Get
                Return m_colFldA
            End Get
            Set
                If Not Same(m_colFldA, Value) Then
                    m_colFldA = Value
                    m_IsDirty(FieldIndex.colFldA) = True
                End If
            End Set
        End Property
        Private m_colFldA As Nullable(Of Decimal)

        Public Property colUseForeColorHex() As String Implements IrowVwMetaColor.colUseForeColorHex
            Get
                Return m_colUseForeColorHex
            End Get
            Set
                If Not Same(m_colUseForeColorHex, Value) Then
                    m_colUseForeColorHex = Value
                    m_IsDirty(FieldIndex.colUseForeColorHex) = True
                End If
            End Set
        End Property
        Private m_colUseForeColorHex As String


        Public Function IsDirty(pIndex As rowVwMetaColor.FieldIndex) As Boolean Implements IrowVwMetaColor.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwMetaColor.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwMetaColor.SetIsDirty
            m_IsDirty(FieldIndex.colFldId) = pDirty
            m_IsDirty(FieldIndex.colFldColor) = pDirty
            m_IsDirty(FieldIndex.colFldHex) = pDirty
            m_IsDirty(FieldIndex.colFldR) = pDirty
            m_IsDirty(FieldIndex.colFldG) = pDirty
            m_IsDirty(FieldIndex.colFldB) = pDirty
            m_IsDirty(FieldIndex.colFldA) = pDirty
            m_IsDirty(FieldIndex.colUseForeColorHex) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwMetaColor) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwMetaColor
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldId  = 1
            colFldColor 
            colFldHex 
            colFldR 
            colFldG 
            colFldB 
            colFldA 
            colUseForeColorHex 
        End Enum

        Private m_IsDirty(8) As Boolean

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

    Public Interface IrowVwMetaColor
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldId() As Nullable(Of Integer)
        Property colFldColor() As String
        Property colFldHex() As String
        Property colFldR() As Nullable(Of Integer)
        Property colFldG() As Nullable(Of Integer)
        Property colFldB() As Nullable(Of Integer)
        Property colFldA() As Nullable(Of Decimal)
        Property colUseForeColorHex() As String
        Function IsDirty(pIndex As rowVwMetaColor.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

