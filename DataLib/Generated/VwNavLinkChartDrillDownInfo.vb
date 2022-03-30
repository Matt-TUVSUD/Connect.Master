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
    Partial Public Class VwNavLinkChartDrillDownInfo

        Public Shared Function LoadData() As List(Of rowVwNavLinkChartDrillDownInfo)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwNavLinkChartDrillDownInfo)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwNavLinkChartDrillDownInfo)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwNavLinkChartDrillDownInfo)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwNavLinkChartDrillDownInfo)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwNavLinkChartDrillDownInfo)
            Dim zReturn As New List(Of rowVwNavLinkChartDrillDownInfo)
            Dim zSQL As String = "SELECT * FROM [cv].[vwNavLinkChartDrillDownInfo]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwNavLinkChartDrillDownInfo)

			Try
	            Dim zReturn As New List(Of rowVwNavLinkChartDrillDownInfo)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwNavLinkChartDrillDownInfo

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwNavLinkChartDrillDownInfo		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwNavLinkChartDrillDownInfo)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldParentNavLinkId")) Then pObject.colFldParentNavLinkId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldParentNavLinkId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldParentChartId")) Then pObject.colFldParentChartId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldParentChartId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldChartDrillDownId")) Then pObject.colFldChartDrillDownId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldChartDrillDownId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldReportId")) Then pObject.colFldReportId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldReportId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldUrlBase")) Then pObject.colFldUrlBase = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldUrlBase")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldUrlParms")) Then pObject.colFldUrlParms = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldUrlParms")
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
            Dim zSQL As String = "SELECT * FROM [cv].[vwNavLinkChartDrillDownInfo]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowVwNavLinkChartDrillDownInfo
        Implements IrowVwNavLinkChartDrillDownInfo

        Public Event Loaded(pUserState As Object) Implements IrowVwNavLinkChartDrillDownInfo.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwNavLinkChartDrillDownInfo.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwNavLinkChartDrillDownInfo.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwNavLinkChartDrillDownInfo.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwNavLinkChartDrillDownInfo.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwNavLinkChartDrillDownInfo.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldParentNavLinkId() As Nullable(Of Integer) Implements IrowVwNavLinkChartDrillDownInfo.colFldParentNavLinkId
            Get
                Return m_colFldParentNavLinkId
            End Get
            Set
                If Not Same(m_colFldParentNavLinkId, Value) Then
                    m_colFldParentNavLinkId = Value
                    m_IsDirty(FieldIndex.colFldParentNavLinkId) = True
                End If
            End Set
        End Property
        Private m_colFldParentNavLinkId As Nullable(Of Integer)

        Public Property colFldParentChartId() As Nullable(Of Integer) Implements IrowVwNavLinkChartDrillDownInfo.colFldParentChartId
            Get
                Return m_colFldParentChartId
            End Get
            Set
                If Not Same(m_colFldParentChartId, Value) Then
                    m_colFldParentChartId = Value
                    m_IsDirty(FieldIndex.colFldParentChartId) = True
                End If
            End Set
        End Property
        Private m_colFldParentChartId As Nullable(Of Integer)

        Public Property colFldChartDrillDownId() As Nullable(Of Integer) Implements IrowVwNavLinkChartDrillDownInfo.colFldChartDrillDownId
            Get
                Return m_colFldChartDrillDownId
            End Get
            Set
                If Not Same(m_colFldChartDrillDownId, Value) Then
                    m_colFldChartDrillDownId = Value
                    m_IsDirty(FieldIndex.colFldChartDrillDownId) = True
                End If
            End Set
        End Property
        Private m_colFldChartDrillDownId As Nullable(Of Integer)

        Public Property colFldReportId() As Nullable(Of Integer) Implements IrowVwNavLinkChartDrillDownInfo.colFldReportId
            Get
                Return m_colFldReportId
            End Get
            Set
                If Not Same(m_colFldReportId, Value) Then
                    m_colFldReportId = Value
                    m_IsDirty(FieldIndex.colFldReportId) = True
                End If
            End Set
        End Property
        Private m_colFldReportId As Nullable(Of Integer)

        Public Property colFldUrlBase() As String Implements IrowVwNavLinkChartDrillDownInfo.colFldUrlBase
            Get
                Return m_colFldUrlBase
            End Get
            Set
                If Not Same(m_colFldUrlBase, Value) Then
                    m_colFldUrlBase = Value
                    m_IsDirty(FieldIndex.colFldUrlBase) = True
                End If
            End Set
        End Property
        Private m_colFldUrlBase As String

        Public Property colFldUrlParms() As String Implements IrowVwNavLinkChartDrillDownInfo.colFldUrlParms
            Get
                Return m_colFldUrlParms
            End Get
            Set
                If Not Same(m_colFldUrlParms, Value) Then
                    m_colFldUrlParms = Value
                    m_IsDirty(FieldIndex.colFldUrlParms) = True
                End If
            End Set
        End Property
        Private m_colFldUrlParms As String


        Public Function IsDirty(pIndex As rowVwNavLinkChartDrillDownInfo.FieldIndex) As Boolean Implements IrowVwNavLinkChartDrillDownInfo.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwNavLinkChartDrillDownInfo.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwNavLinkChartDrillDownInfo.SetIsDirty
            m_IsDirty(FieldIndex.colFldParentNavLinkId) = pDirty
            m_IsDirty(FieldIndex.colFldParentChartId) = pDirty
            m_IsDirty(FieldIndex.colFldChartDrillDownId) = pDirty
            m_IsDirty(FieldIndex.colFldReportId) = pDirty
            m_IsDirty(FieldIndex.colFldUrlBase) = pDirty
            m_IsDirty(FieldIndex.colFldUrlParms) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwNavLinkChartDrillDownInfo) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwNavLinkChartDrillDownInfo
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldParentNavLinkId  = 1
            colFldParentChartId 
            colFldChartDrillDownId 
            colFldReportId 
            colFldUrlBase 
            colFldUrlParms 
        End Enum

        Private m_IsDirty(6) As Boolean

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

    Public Interface IrowVwNavLinkChartDrillDownInfo
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldParentNavLinkId() As Nullable(Of Integer)
        Property colFldParentChartId() As Nullable(Of Integer)
        Property colFldChartDrillDownId() As Nullable(Of Integer)
        Property colFldReportId() As Nullable(Of Integer)
        Property colFldUrlBase() As String
        Property colFldUrlParms() As String
        Function IsDirty(pIndex As rowVwNavLinkChartDrillDownInfo.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

