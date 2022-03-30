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
    Partial Public Class ViewCCGSafeSitemapItems

        Public Shared Function LoadData() As List(Of rowViewCCGSafeSitemapItems)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowViewCCGSafeSitemapItems)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowViewCCGSafeSitemapItems)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowViewCCGSafeSitemapItems)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowViewCCGSafeSitemapItems)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowViewCCGSafeSitemapItems)
            Dim zReturn As New List(Of rowViewCCGSafeSitemapItems)
            Dim zSQL As String = "SELECT * FROM [dbo].[viewCCGSafeSitemapItems]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowViewCCGSafeSitemapItems)

			Try
	            Dim zReturn As New List(Of rowViewCCGSafeSitemapItems)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowViewCCGSafeSitemapItems

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowViewCCGSafeSitemapItems		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowViewCCGSafeSitemapItems)
			If Not pReader.IsDBNull(pReader.GetOrdinal("GSafeId")) Then pObject.colGSafeId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "GSafeId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavSiteMapKeyWord")) Then pObject.colNavSiteMapKeyWord = UtilSQLServer.SafeReader.SafeReadString(pReader, "NavSiteMapKeyWord")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavAllReportsKeyword")) Then pObject.colNavAllReportsKeyword = UtilSQLServer.SafeReader.SafeReadString(pReader, "NavAllReportsKeyword")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavAllDataKeyword")) Then pObject.colNavAllDataKeyword = UtilSQLServer.SafeReader.SafeReadString(pReader, "NavAllDataKeyword")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavLinkId")) Then pObject.colNavLinkId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "NavLinkId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavParentLinkId")) Then pObject.colNavParentLinkId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "NavParentLinkId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavText")) Then pObject.colNavText = UtilSQLServer.SafeReader.SafeReadString(pReader, "NavText")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavUrl")) Then pObject.colNavUrl = UtilSQLServer.SafeReader.SafeReadString(pReader, "NavUrl")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavOrder")) Then pObject.colNavOrder = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "NavOrder")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavToolTip")) Then pObject.colNavToolTip = UtilSQLServer.SafeReader.SafeReadString(pReader, "NavToolTip")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavVisible")) Then pObject.colNavVisible = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "NavVisible")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavEnabled")) Then pObject.colNavEnabled = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "NavEnabled")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavTarget")) Then pObject.colNavTarget = UtilSQLServer.SafeReader.SafeReadString(pReader, "NavTarget")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavType")) Then pObject.colNavType = UtilSQLServer.SafeReader.SafeReadString(pReader, "NavType")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavConstant")) Then pObject.colNavConstant = UtilSQLServer.SafeReader.SafeReadString(pReader, "NavConstant")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavRptCode")) Then pObject.colNavRptCode = UtilSQLServer.SafeReader.SafeReadString(pReader, "NavRptCode")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavGridId")) Then pObject.colNavGridId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "NavGridId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavChartId")) Then pObject.colNavChartId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "NavChartId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavExtractId")) Then pObject.colNavExtractId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "NavExtractId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavBypassFilter")) Then pObject.colNavBypassFilter = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "NavBypassFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NavStatusToolTip")) Then pObject.colNavStatusToolTip = UtilSQLServer.SafeReader.SafeReadString(pReader, "NavStatusToolTip")
			If Not pReader.IsDBNull(pReader.GetOrdinal("slideMenuId")) Then pObject.colSlideMenuId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "slideMenuId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("slideGroupId")) Then pObject.colSlideGroupId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "slideGroupId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("slideLevelId")) Then pObject.colSlideLevelId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "slideLevelId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("slideType")) Then pObject.colSlideType = UtilSQLServer.SafeReader.SafeReadString(pReader, "slideType")
			If Not pReader.IsDBNull(pReader.GetOrdinal("slideParentId")) Then pObject.colSlideParentId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "slideParentId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("slideOrder")) Then pObject.colSlideOrder = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "slideOrder")
			If Not pReader.IsDBNull(pReader.GetOrdinal("slideImageClassName")) Then pObject.colSlideImageClassName = UtilSQLServer.SafeReader.SafeReadString(pReader, "slideImageClassName")
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
            Dim zSQL As String = "SELECT * FROM [dbo].[viewCCGSafeSitemapItems]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowViewCCGSafeSitemapItems
        Implements IrowViewCCGSafeSitemapItems

        Public Event Loaded(pUserState As Object) Implements IrowViewCCGSafeSitemapItems.Loaded
        Public Event Saved(pUserState As Object) Implements IrowViewCCGSafeSitemapItems.Saved
        Public Event Deleted(pUserState As Object) Implements IrowViewCCGSafeSitemapItems.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowViewCCGSafeSitemapItems.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowViewCCGSafeSitemapItems.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowViewCCGSafeSitemapItems.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colGSafeId() As Nullable(Of Integer) Implements IrowViewCCGSafeSitemapItems.colGSafeId
            Get
                Return m_colGSafeId
            End Get
            Set
                If Not Same(m_colGSafeId, Value) Then
                    m_colGSafeId = Value
                    m_IsDirty(FieldIndex.colGSafeId) = True
                End If
            End Set
        End Property
        Private m_colGSafeId As Nullable(Of Integer)

        Public Property colNavSiteMapKeyWord() As String Implements IrowViewCCGSafeSitemapItems.colNavSiteMapKeyWord
            Get
                Return m_colNavSiteMapKeyWord
            End Get
            Set
                If Not Same(m_colNavSiteMapKeyWord, Value) Then
                    m_colNavSiteMapKeyWord = Value
                    m_IsDirty(FieldIndex.colNavSiteMapKeyWord) = True
                End If
            End Set
        End Property
        Private m_colNavSiteMapKeyWord As String

        Public Property colNavAllReportsKeyword() As String Implements IrowViewCCGSafeSitemapItems.colNavAllReportsKeyword
            Get
                Return m_colNavAllReportsKeyword
            End Get
            Set
                If Not Same(m_colNavAllReportsKeyword, Value) Then
                    m_colNavAllReportsKeyword = Value
                    m_IsDirty(FieldIndex.colNavAllReportsKeyword) = True
                End If
            End Set
        End Property
        Private m_colNavAllReportsKeyword As String

        Public Property colNavAllDataKeyword() As String Implements IrowViewCCGSafeSitemapItems.colNavAllDataKeyword
            Get
                Return m_colNavAllDataKeyword
            End Get
            Set
                If Not Same(m_colNavAllDataKeyword, Value) Then
                    m_colNavAllDataKeyword = Value
                    m_IsDirty(FieldIndex.colNavAllDataKeyword) = True
                End If
            End Set
        End Property
        Private m_colNavAllDataKeyword As String

        Public Property colNavLinkId() As Nullable(Of Integer) Implements IrowViewCCGSafeSitemapItems.colNavLinkId
            Get
                Return m_colNavLinkId
            End Get
            Set
                If Not Same(m_colNavLinkId, Value) Then
                    m_colNavLinkId = Value
                    m_IsDirty(FieldIndex.colNavLinkId) = True
                End If
            End Set
        End Property
        Private m_colNavLinkId As Nullable(Of Integer)

        Public Property colNavParentLinkId() As Nullable(Of Integer) Implements IrowViewCCGSafeSitemapItems.colNavParentLinkId
            Get
                Return m_colNavParentLinkId
            End Get
            Set
                If Not Same(m_colNavParentLinkId, Value) Then
                    m_colNavParentLinkId = Value
                    m_IsDirty(FieldIndex.colNavParentLinkId) = True
                End If
            End Set
        End Property
        Private m_colNavParentLinkId As Nullable(Of Integer)

        Public Property colNavText() As String Implements IrowViewCCGSafeSitemapItems.colNavText
            Get
                Return m_colNavText
            End Get
            Set
                If Not Same(m_colNavText, Value) Then
                    m_colNavText = Value
                    m_IsDirty(FieldIndex.colNavText) = True
                End If
            End Set
        End Property
        Private m_colNavText As String

        Public Property colNavUrl() As String Implements IrowViewCCGSafeSitemapItems.colNavUrl
            Get
                Return m_colNavUrl
            End Get
            Set
                If Not Same(m_colNavUrl, Value) Then
                    m_colNavUrl = Value
                    m_IsDirty(FieldIndex.colNavUrl) = True
                End If
            End Set
        End Property
        Private m_colNavUrl As String

        Public Property colNavOrder() As Nullable(Of Integer) Implements IrowViewCCGSafeSitemapItems.colNavOrder
            Get
                Return m_colNavOrder
            End Get
            Set
                If Not Same(m_colNavOrder, Value) Then
                    m_colNavOrder = Value
                    m_IsDirty(FieldIndex.colNavOrder) = True
                End If
            End Set
        End Property
        Private m_colNavOrder As Nullable(Of Integer)

        Public Property colNavToolTip() As String Implements IrowViewCCGSafeSitemapItems.colNavToolTip
            Get
                Return m_colNavToolTip
            End Get
            Set
                If Not Same(m_colNavToolTip, Value) Then
                    m_colNavToolTip = Value
                    m_IsDirty(FieldIndex.colNavToolTip) = True
                End If
            End Set
        End Property
        Private m_colNavToolTip As String

        Public Property colNavVisible() As Nullable(Of Integer) Implements IrowViewCCGSafeSitemapItems.colNavVisible
            Get
                Return m_colNavVisible
            End Get
            Set
                If Not Same(m_colNavVisible, Value) Then
                    m_colNavVisible = Value
                    m_IsDirty(FieldIndex.colNavVisible) = True
                End If
            End Set
        End Property
        Private m_colNavVisible As Nullable(Of Integer)

        Public Property colNavEnabled() As Nullable(Of Integer) Implements IrowViewCCGSafeSitemapItems.colNavEnabled
            Get
                Return m_colNavEnabled
            End Get
            Set
                If Not Same(m_colNavEnabled, Value) Then
                    m_colNavEnabled = Value
                    m_IsDirty(FieldIndex.colNavEnabled) = True
                End If
            End Set
        End Property
        Private m_colNavEnabled As Nullable(Of Integer)

        Public Property colNavTarget() As String Implements IrowViewCCGSafeSitemapItems.colNavTarget
            Get
                Return m_colNavTarget
            End Get
            Set
                If Not Same(m_colNavTarget, Value) Then
                    m_colNavTarget = Value
                    m_IsDirty(FieldIndex.colNavTarget) = True
                End If
            End Set
        End Property
        Private m_colNavTarget As String

        Public Property colNavType() As String Implements IrowViewCCGSafeSitemapItems.colNavType
            Get
                Return m_colNavType
            End Get
            Set
                If Not Same(m_colNavType, Value) Then
                    m_colNavType = Value
                    m_IsDirty(FieldIndex.colNavType) = True
                End If
            End Set
        End Property
        Private m_colNavType As String

        Public Property colNavConstant() As String Implements IrowViewCCGSafeSitemapItems.colNavConstant
            Get
                Return m_colNavConstant
            End Get
            Set
                If Not Same(m_colNavConstant, Value) Then
                    m_colNavConstant = Value
                    m_IsDirty(FieldIndex.colNavConstant) = True
                End If
            End Set
        End Property
        Private m_colNavConstant As String

        Public Property colNavRptCode() As String Implements IrowViewCCGSafeSitemapItems.colNavRptCode
            Get
                Return m_colNavRptCode
            End Get
            Set
                If Not Same(m_colNavRptCode, Value) Then
                    m_colNavRptCode = Value
                    m_IsDirty(FieldIndex.colNavRptCode) = True
                End If
            End Set
        End Property
        Private m_colNavRptCode As String

        Public Property colNavGridId() As Nullable(Of Integer) Implements IrowViewCCGSafeSitemapItems.colNavGridId
            Get
                Return m_colNavGridId
            End Get
            Set
                If Not Same(m_colNavGridId, Value) Then
                    m_colNavGridId = Value
                    m_IsDirty(FieldIndex.colNavGridId) = True
                End If
            End Set
        End Property
        Private m_colNavGridId As Nullable(Of Integer)

        Public Property colNavChartId() As Nullable(Of Integer) Implements IrowViewCCGSafeSitemapItems.colNavChartId
            Get
                Return m_colNavChartId
            End Get
            Set
                If Not Same(m_colNavChartId, Value) Then
                    m_colNavChartId = Value
                    m_IsDirty(FieldIndex.colNavChartId) = True
                End If
            End Set
        End Property
        Private m_colNavChartId As Nullable(Of Integer)

        Public Property colNavExtractId() As Nullable(Of Integer) Implements IrowViewCCGSafeSitemapItems.colNavExtractId
            Get
                Return m_colNavExtractId
            End Get
            Set
                If Not Same(m_colNavExtractId, Value) Then
                    m_colNavExtractId = Value
                    m_IsDirty(FieldIndex.colNavExtractId) = True
                End If
            End Set
        End Property
        Private m_colNavExtractId As Nullable(Of Integer)

        Public Property colNavBypassFilter() As Nullable(Of Boolean) Implements IrowViewCCGSafeSitemapItems.colNavBypassFilter
            Get
                Return m_colNavBypassFilter
            End Get
            Set
                If Not Same(m_colNavBypassFilter, Value) Then
                    m_colNavBypassFilter = Value
                    m_IsDirty(FieldIndex.colNavBypassFilter) = True
                End If
            End Set
        End Property
        Private m_colNavBypassFilter As Nullable(Of Boolean)

        Public Property colNavStatusToolTip() As String Implements IrowViewCCGSafeSitemapItems.colNavStatusToolTip
            Get
                Return m_colNavStatusToolTip
            End Get
            Set
                If Not Same(m_colNavStatusToolTip, Value) Then
                    m_colNavStatusToolTip = Value
                    m_IsDirty(FieldIndex.colNavStatusToolTip) = True
                End If
            End Set
        End Property
        Private m_colNavStatusToolTip As String

        Public Property colSlideMenuId() As Nullable(Of Integer) Implements IrowViewCCGSafeSitemapItems.colSlideMenuId
            Get
                Return m_colSlideMenuId
            End Get
            Set
                If Not Same(m_colSlideMenuId, Value) Then
                    m_colSlideMenuId = Value
                    m_IsDirty(FieldIndex.colSlideMenuId) = True
                End If
            End Set
        End Property
        Private m_colSlideMenuId As Nullable(Of Integer)

        Public Property colSlideGroupId() As Nullable(Of Integer) Implements IrowViewCCGSafeSitemapItems.colSlideGroupId
            Get
                Return m_colSlideGroupId
            End Get
            Set
                If Not Same(m_colSlideGroupId, Value) Then
                    m_colSlideGroupId = Value
                    m_IsDirty(FieldIndex.colSlideGroupId) = True
                End If
            End Set
        End Property
        Private m_colSlideGroupId As Nullable(Of Integer)

        Public Property colSlideLevelId() As Nullable(Of Integer) Implements IrowViewCCGSafeSitemapItems.colSlideLevelId
            Get
                Return m_colSlideLevelId
            End Get
            Set
                If Not Same(m_colSlideLevelId, Value) Then
                    m_colSlideLevelId = Value
                    m_IsDirty(FieldIndex.colSlideLevelId) = True
                End If
            End Set
        End Property
        Private m_colSlideLevelId As Nullable(Of Integer)

        Public Property colSlideType() As String Implements IrowViewCCGSafeSitemapItems.colSlideType
            Get
                Return m_colSlideType
            End Get
            Set
                If Not Same(m_colSlideType, Value) Then
                    m_colSlideType = Value
                    m_IsDirty(FieldIndex.colSlideType) = True
                End If
            End Set
        End Property
        Private m_colSlideType As String

        Public Property colSlideParentId() As Nullable(Of Integer) Implements IrowViewCCGSafeSitemapItems.colSlideParentId
            Get
                Return m_colSlideParentId
            End Get
            Set
                If Not Same(m_colSlideParentId, Value) Then
                    m_colSlideParentId = Value
                    m_IsDirty(FieldIndex.colSlideParentId) = True
                End If
            End Set
        End Property
        Private m_colSlideParentId As Nullable(Of Integer)

        Public Property colSlideOrder() As Nullable(Of Integer) Implements IrowViewCCGSafeSitemapItems.colSlideOrder
            Get
                Return m_colSlideOrder
            End Get
            Set
                If Not Same(m_colSlideOrder, Value) Then
                    m_colSlideOrder = Value
                    m_IsDirty(FieldIndex.colSlideOrder) = True
                End If
            End Set
        End Property
        Private m_colSlideOrder As Nullable(Of Integer)

        Public Property colSlideImageClassName() As String Implements IrowViewCCGSafeSitemapItems.colSlideImageClassName
            Get
                Return m_colSlideImageClassName
            End Get
            Set
                If Not Same(m_colSlideImageClassName, Value) Then
                    m_colSlideImageClassName = Value
                    m_IsDirty(FieldIndex.colSlideImageClassName) = True
                End If
            End Set
        End Property
        Private m_colSlideImageClassName As String


        Public Function IsDirty(pIndex As rowViewCCGSafeSitemapItems.FieldIndex) As Boolean Implements IrowViewCCGSafeSitemapItems.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowViewCCGSafeSitemapItems.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowViewCCGSafeSitemapItems.SetIsDirty
            m_IsDirty(FieldIndex.colGSafeId) = pDirty
            m_IsDirty(FieldIndex.colNavSiteMapKeyWord) = pDirty
            m_IsDirty(FieldIndex.colNavAllReportsKeyword) = pDirty
            m_IsDirty(FieldIndex.colNavAllDataKeyword) = pDirty
            m_IsDirty(FieldIndex.colNavLinkId) = pDirty
            m_IsDirty(FieldIndex.colNavParentLinkId) = pDirty
            m_IsDirty(FieldIndex.colNavText) = pDirty
            m_IsDirty(FieldIndex.colNavUrl) = pDirty
            m_IsDirty(FieldIndex.colNavOrder) = pDirty
            m_IsDirty(FieldIndex.colNavToolTip) = pDirty
            m_IsDirty(FieldIndex.colNavVisible) = pDirty
            m_IsDirty(FieldIndex.colNavEnabled) = pDirty
            m_IsDirty(FieldIndex.colNavTarget) = pDirty
            m_IsDirty(FieldIndex.colNavType) = pDirty
            m_IsDirty(FieldIndex.colNavConstant) = pDirty
            m_IsDirty(FieldIndex.colNavRptCode) = pDirty
            m_IsDirty(FieldIndex.colNavGridId) = pDirty
            m_IsDirty(FieldIndex.colNavChartId) = pDirty
            m_IsDirty(FieldIndex.colNavExtractId) = pDirty
            m_IsDirty(FieldIndex.colNavBypassFilter) = pDirty
            m_IsDirty(FieldIndex.colNavStatusToolTip) = pDirty
            m_IsDirty(FieldIndex.colSlideMenuId) = pDirty
            m_IsDirty(FieldIndex.colSlideGroupId) = pDirty
            m_IsDirty(FieldIndex.colSlideLevelId) = pDirty
            m_IsDirty(FieldIndex.colSlideType) = pDirty
            m_IsDirty(FieldIndex.colSlideParentId) = pDirty
            m_IsDirty(FieldIndex.colSlideOrder) = pDirty
            m_IsDirty(FieldIndex.colSlideImageClassName) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (ViewCCGSafeSitemapItems) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New ViewCCGSafeSitemapItems
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colGSafeId  = 1
            colNavSiteMapKeyWord 
            colNavAllReportsKeyword 
            colNavAllDataKeyword 
            colNavLinkId 
            colNavParentLinkId 
            colNavText 
            colNavUrl 
            colNavOrder 
            colNavToolTip 
            colNavVisible 
            colNavEnabled 
            colNavTarget 
            colNavType 
            colNavConstant 
            colNavRptCode 
            colNavGridId 
            colNavChartId 
            colNavExtractId 
            colNavBypassFilter 
            colNavStatusToolTip 
            colSlideMenuId 
            colSlideGroupId 
            colSlideLevelId 
            colSlideType 
            colSlideParentId 
            colSlideOrder 
            colSlideImageClassName 
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

    Public Interface IrowViewCCGSafeSitemapItems
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colGSafeId() As Nullable(Of Integer)
        Property colNavSiteMapKeyWord() As String
        Property colNavAllReportsKeyword() As String
        Property colNavAllDataKeyword() As String
        Property colNavLinkId() As Nullable(Of Integer)
        Property colNavParentLinkId() As Nullable(Of Integer)
        Property colNavText() As String
        Property colNavUrl() As String
        Property colNavOrder() As Nullable(Of Integer)
        Property colNavToolTip() As String
        Property colNavVisible() As Nullable(Of Integer)
        Property colNavEnabled() As Nullable(Of Integer)
        Property colNavTarget() As String
        Property colNavType() As String
        Property colNavConstant() As String
        Property colNavRptCode() As String
        Property colNavGridId() As Nullable(Of Integer)
        Property colNavChartId() As Nullable(Of Integer)
        Property colNavExtractId() As Nullable(Of Integer)
        Property colNavBypassFilter() As Nullable(Of Boolean)
        Property colNavStatusToolTip() As String
        Property colSlideMenuId() As Nullable(Of Integer)
        Property colSlideGroupId() As Nullable(Of Integer)
        Property colSlideLevelId() As Nullable(Of Integer)
        Property colSlideType() As String
        Property colSlideParentId() As Nullable(Of Integer)
        Property colSlideOrder() As Nullable(Of Integer)
        Property colSlideImageClassName() As String
        Function IsDirty(pIndex As rowViewCCGSafeSitemapItems.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

