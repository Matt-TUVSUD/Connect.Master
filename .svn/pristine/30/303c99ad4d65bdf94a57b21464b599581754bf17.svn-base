
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/26/2013 3:03:26 PM
'===============================================================================

Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text
Imports System.Linq
Imports System.Data
Imports System.ComponentModel
Imports System.Xml.Serialization
Imports System.Runtime.Serialization

Imports EntitySpaces.Core
Imports EntitySpaces.Interfaces
Imports EntitySpaces.DynamicQuery



Namespace BusinessObjects

	' <summary>
	' Encapsulates the 'ErrorLog' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ErrorLog))> _
	<XmlType("ErrorLog")> _	
	Partial Public Class ErrorLog 
		Inherits esErrorLog
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ErrorLog()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal logId As System.Int32)
			Dim obj As New ErrorLog()
			obj.LogId = logId
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal logId As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New ErrorLog()
			obj.LogId = logId
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ErrorLogCollection")> _
	Partial Public Class ErrorLogCollection
		Inherits esErrorLogCollection
		Implements IEnumerable(Of ErrorLog)
	
		Public Function FindByPrimaryKey(ByVal logId As System.Int32) As ErrorLog
			Return MyBase.SingleOrDefault(Function(e) e.LogId.HasValue AndAlso e.LogId.Value = logId)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ErrorLog))> _
		Public Class ErrorLogCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ErrorLogCollection)
			
			Public Shared Widening Operator CType(packet As ErrorLogCollectionWCFPacket) As ErrorLogCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ErrorLogCollection) As ErrorLogCollectionWCFPacket
				Return New ErrorLogCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ErrorLogQuery 
		Inherits esErrorLogQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ErrorLogQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ErrorLogQuery) As String
			Return ErrorLogQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ErrorLogQuery
			Return DirectCast(ErrorLogQuery.SerializeHelper.FromXml(query, GetType(ErrorLogQuery)), ErrorLogQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esErrorLog
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal logId As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(logId)
			Else
				Return LoadByPrimaryKeyStoredProcedure(logId)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal logId As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(logId)
			Else
				Return LoadByPrimaryKeyStoredProcedure(logId)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal logId As System.Int32) As Boolean
		
			Dim query As New ErrorLogQuery()
			query.Where(query.LogId = logId)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal logId As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("LogId", logId)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to ErrorLog.LogId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LogId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ErrorLogMetadata.ColumnNames.LogId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ErrorLogMetadata.ColumnNames.LogId, value) Then
					OnPropertyChanged(ErrorLogMetadata.PropertyNames.LogId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ErrorLog.DateOccured
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DateOccured As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ErrorLogMetadata.ColumnNames.DateOccured)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ErrorLogMetadata.ColumnNames.DateOccured, value) Then
					OnPropertyChanged(ErrorLogMetadata.PropertyNames.DateOccured)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ErrorLog.UserEmail
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property UserEmail As System.String
			Get
				Return MyBase.GetSystemString(ErrorLogMetadata.ColumnNames.UserEmail)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ErrorLogMetadata.ColumnNames.UserEmail, value) Then
					OnPropertyChanged(ErrorLogMetadata.PropertyNames.UserEmail)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ErrorLog.SourceNamespace
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SourceNamespace As System.String
			Get
				Return MyBase.GetSystemString(ErrorLogMetadata.ColumnNames.SourceNamespace)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ErrorLogMetadata.ColumnNames.SourceNamespace, value) Then
					OnPropertyChanged(ErrorLogMetadata.PropertyNames.SourceNamespace)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ErrorLog.ReferringURL
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ReferringURL As System.String
			Get
				Return MyBase.GetSystemString(ErrorLogMetadata.ColumnNames.ReferringURL)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ErrorLogMetadata.ColumnNames.ReferringURL, value) Then
					OnPropertyChanged(ErrorLogMetadata.PropertyNames.ReferringURL)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ErrorLog.MessageOuter
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MessageOuter As System.String
			Get
				Return MyBase.GetSystemString(ErrorLogMetadata.ColumnNames.MessageOuter)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ErrorLogMetadata.ColumnNames.MessageOuter, value) Then
					OnPropertyChanged(ErrorLogMetadata.PropertyNames.MessageOuter)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ErrorLog.MessageInner
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MessageInner As System.String
			Get
				Return MyBase.GetSystemString(ErrorLogMetadata.ColumnNames.MessageInner)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ErrorLogMetadata.ColumnNames.MessageInner, value) Then
					OnPropertyChanged(ErrorLogMetadata.PropertyNames.MessageInner)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ErrorLog.StackTraceInner
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StackTraceInner As System.String
			Get
				Return MyBase.GetSystemString(ErrorLogMetadata.ColumnNames.StackTraceInner)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ErrorLogMetadata.ColumnNames.StackTraceInner, value) Then
					OnPropertyChanged(ErrorLogMetadata.PropertyNames.StackTraceInner)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ErrorLog.SourceIP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SourceIP As System.String
			Get
				Return MyBase.GetSystemString(ErrorLogMetadata.ColumnNames.SourceIP)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ErrorLogMetadata.ColumnNames.SourceIP, value) Then
					OnPropertyChanged(ErrorLogMetadata.PropertyNames.SourceIP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ErrorLog.ApplicationPage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ApplicationPage As System.String
			Get
				Return MyBase.GetSystemString(ErrorLogMetadata.ColumnNames.ApplicationPage)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ErrorLogMetadata.ColumnNames.ApplicationPage, value) Then
					OnPropertyChanged(ErrorLogMetadata.PropertyNames.ApplicationPage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ErrorLog.ErrorType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ErrorType As System.String
			Get
				Return MyBase.GetSystemString(ErrorLogMetadata.ColumnNames.ErrorType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ErrorLogMetadata.ColumnNames.ErrorType, value) Then
					OnPropertyChanged(ErrorLogMetadata.PropertyNames.ErrorType)
				End If
			End Set
		End Property	
		
#End Region	

#Region ".str() Properties"

		Public Overrides Sub SetProperties(values as IDictionary)

		Dim propertyName As String
			For Each propertyName In values.Keys
				Me.SetProperty(propertyName, values(propertyName))
			Next

		End Sub

		Public Overrides Sub SetProperty(name as string, value as object)

			Dim col As esColumnMetadata = Me.Meta.Columns.FindByPropertyName(name)
			If Not col Is Nothing Then

				If value Is Nothing OrElse value.GetType().ToString() = "System.String" Then

					' Use the strongly typed property
					Select Case name
												
						Case "LogId"
							Me.str().LogId = CType(value, string)
												
						Case "DateOccured"
							Me.str().DateOccured = CType(value, string)
												
						Case "UserEmail"
							Me.str().UserEmail = CType(value, string)
												
						Case "SourceNamespace"
							Me.str().SourceNamespace = CType(value, string)
												
						Case "ReferringURL"
							Me.str().ReferringURL = CType(value, string)
												
						Case "MessageOuter"
							Me.str().MessageOuter = CType(value, string)
												
						Case "MessageInner"
							Me.str().MessageInner = CType(value, string)
												
						Case "StackTraceInner"
							Me.str().StackTraceInner = CType(value, string)
												
						Case "SourceIP"
							Me.str().SourceIP = CType(value, string)
												
						Case "ApplicationPage"
							Me.str().ApplicationPage = CType(value, string)
												
						Case "ErrorType"
							Me.str().ErrorType = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "LogId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LogId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ErrorLogMetadata.PropertyNames.LogId)
							End If
						
						Case "DateOccured"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.DateOccured = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ErrorLogMetadata.PropertyNames.DateOccured)
							End If
						
					
						Case Else
						
					End Select
				End If

			Else If Me.ContainsColumn(name) Then
				Me.SetColumn(name, value)
			Else
				throw New Exception("SetProperty Error: '" + name + "' not found")
			End If	

		End Sub

		Public Function str() As esStrings
		
			If _esstrings Is Nothing Then
				_esstrings = New esStrings(Me)
			End If
			Return _esstrings
			
		End Function

		NotInheritable Public Class esStrings
		
			Public Sub New(ByVal entity As esErrorLog)
				Me.entity = entity
			End Sub				
		
	
			Public Property LogId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.LogId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LogId = Nothing
					Else
						entity.LogId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property DateOccured As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.DateOccured
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DateOccured = Nothing
					Else
						entity.DateOccured = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property UserEmail As System.String 
				Get
					Dim data_ As System.String = entity.UserEmail
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.UserEmail = Nothing
					Else
						entity.UserEmail = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SourceNamespace As System.String 
				Get
					Dim data_ As System.String = entity.SourceNamespace
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SourceNamespace = Nothing
					Else
						entity.SourceNamespace = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ReferringURL As System.String 
				Get
					Dim data_ As System.String = entity.ReferringURL
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReferringURL = Nothing
					Else
						entity.ReferringURL = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MessageOuter As System.String 
				Get
					Dim data_ As System.String = entity.MessageOuter
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MessageOuter = Nothing
					Else
						entity.MessageOuter = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MessageInner As System.String 
				Get
					Dim data_ As System.String = entity.MessageInner
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MessageInner = Nothing
					Else
						entity.MessageInner = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property StackTraceInner As System.String 
				Get
					Dim data_ As System.String = entity.StackTraceInner
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.StackTraceInner = Nothing
					Else
						entity.StackTraceInner = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SourceIP As System.String 
				Get
					Dim data_ As System.String = entity.SourceIP
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SourceIP = Nothing
					Else
						entity.SourceIP = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ApplicationPage As System.String 
				Get
					Dim data_ As System.String = entity.ApplicationPage
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ApplicationPage = Nothing
					Else
						entity.ApplicationPage = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ErrorType As System.String 
				Get
					Dim data_ As System.String = entity.ErrorType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ErrorType = Nothing
					Else
						entity.ErrorType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esErrorLog
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ErrorLogMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ErrorLogQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ErrorLogQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ErrorLogQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ErrorLogQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ErrorLogQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esErrorLogCollection
		Inherits esEntityCollection(Of ErrorLog)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ErrorLogMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ErrorLogCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ErrorLogQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ErrorLogQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ErrorLogQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ErrorLogQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ErrorLogQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ErrorLogQuery))
		End Sub
		
		#End Region
						
		Private m_query As ErrorLogQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esErrorLogQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ErrorLogMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "LogId" 
					Return Me.LogId
				Case "DateOccured" 
					Return Me.DateOccured
				Case "UserEmail" 
					Return Me.UserEmail
				Case "SourceNamespace" 
					Return Me.SourceNamespace
				Case "ReferringURL" 
					Return Me.ReferringURL
				Case "MessageOuter" 
					Return Me.MessageOuter
				Case "MessageInner" 
					Return Me.MessageInner
				Case "StackTraceInner" 
					Return Me.StackTraceInner
				Case "SourceIP" 
					Return Me.SourceIP
				Case "ApplicationPage" 
					Return Me.ApplicationPage
				Case "ErrorType" 
					Return Me.ErrorType
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property LogId As esQueryItem
			Get
				Return New esQueryItem(Me, ErrorLogMetadata.ColumnNames.LogId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property DateOccured As esQueryItem
			Get
				Return New esQueryItem(Me, ErrorLogMetadata.ColumnNames.DateOccured, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property UserEmail As esQueryItem
			Get
				Return New esQueryItem(Me, ErrorLogMetadata.ColumnNames.UserEmail, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SourceNamespace As esQueryItem
			Get
				Return New esQueryItem(Me, ErrorLogMetadata.ColumnNames.SourceNamespace, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ReferringURL As esQueryItem
			Get
				Return New esQueryItem(Me, ErrorLogMetadata.ColumnNames.ReferringURL, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MessageOuter As esQueryItem
			Get
				Return New esQueryItem(Me, ErrorLogMetadata.ColumnNames.MessageOuter, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MessageInner As esQueryItem
			Get
				Return New esQueryItem(Me, ErrorLogMetadata.ColumnNames.MessageInner, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StackTraceInner As esQueryItem
			Get
				Return New esQueryItem(Me, ErrorLogMetadata.ColumnNames.StackTraceInner, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SourceIP As esQueryItem
			Get
				Return New esQueryItem(Me, ErrorLogMetadata.ColumnNames.SourceIP, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ApplicationPage As esQueryItem
			Get
				Return New esQueryItem(Me, ErrorLogMetadata.ColumnNames.ApplicationPage, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ErrorType As esQueryItem
			Get
				Return New esQueryItem(Me, ErrorLogMetadata.ColumnNames.ErrorType, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ErrorLogMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ErrorLogMetadata.ColumnNames.LogId, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ErrorLogMetadata.PropertyNames.LogId
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(ErrorLogMetadata.ColumnNames.DateOccured, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ErrorLogMetadata.PropertyNames.DateOccured
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ErrorLogMetadata.ColumnNames.UserEmail, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ErrorLogMetadata.PropertyNames.UserEmail
			c.CharacterMaxLength = 500
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ErrorLogMetadata.ColumnNames.SourceNamespace, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ErrorLogMetadata.PropertyNames.SourceNamespace
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ErrorLogMetadata.ColumnNames.ReferringURL, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ErrorLogMetadata.PropertyNames.ReferringURL
			c.CharacterMaxLength = 1000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ErrorLogMetadata.ColumnNames.MessageOuter, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ErrorLogMetadata.PropertyNames.MessageOuter
			c.CharacterMaxLength = 1000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ErrorLogMetadata.ColumnNames.MessageInner, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ErrorLogMetadata.PropertyNames.MessageInner
			c.CharacterMaxLength = 1000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ErrorLogMetadata.ColumnNames.StackTraceInner, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ErrorLogMetadata.PropertyNames.StackTraceInner
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ErrorLogMetadata.ColumnNames.SourceIP, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ErrorLogMetadata.PropertyNames.SourceIP
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ErrorLogMetadata.ColumnNames.ApplicationPage, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ErrorLogMetadata.PropertyNames.ApplicationPage
			c.CharacterMaxLength = 1000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ErrorLogMetadata.ColumnNames.ErrorType, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ErrorLogMetadata.PropertyNames.ErrorType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ErrorLogMetadata
			Return _meta
		End Function
		
		Public ReadOnly Property DataID() As System.Guid Implements IMetadata.DataID
			Get
				Return MyBase.m_dataID
			End Get
		End Property

		Public ReadOnly Property MultiProviderMode() As Boolean Implements IMetadata.MultiProviderMode
			Get
				Return false
			End Get
		End Property

		Public ReadOnly Property Columns() As esColumnMetadataCollection Implements IMetadata.Columns
			Get
				Return MyBase.m_columns
			End Get
		End Property

#Region "ColumnNames"
		Public Class ColumnNames
			 Public Const LogId As String = "LogId"
			 Public Const DateOccured As String = "DateOccured"
			 Public Const UserEmail As String = "UserEmail"
			 Public Const SourceNamespace As String = "SourceNamespace"
			 Public Const ReferringURL As String = "ReferringURL"
			 Public Const MessageOuter As String = "MessageOuter"
			 Public Const MessageInner As String = "MessageInner"
			 Public Const StackTraceInner As String = "StackTraceInner"
			 Public Const SourceIP As String = "SourceIP"
			 Public Const ApplicationPage As String = "ApplicationPage"
			 Public Const ErrorType As String = "ErrorType"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const LogId As String = "LogId"
			 Public Const DateOccured As String = "DateOccured"
			 Public Const UserEmail As String = "UserEmail"
			 Public Const SourceNamespace As String = "SourceNamespace"
			 Public Const ReferringURL As String = "ReferringURL"
			 Public Const MessageOuter As String = "MessageOuter"
			 Public Const MessageInner As String = "MessageInner"
			 Public Const StackTraceInner As String = "StackTraceInner"
			 Public Const SourceIP As String = "SourceIP"
			 Public Const ApplicationPage As String = "ApplicationPage"
			 Public Const ErrorType As String = "ErrorType"
		End Class
#End Region	

		Public Function GetProviderMetadata(ByVal mapName As String) As esProviderSpecificMetadata _
			Implements IMetadata.GetProviderMetadata

			Dim mapMethod As MapToMeta = mapDelegates(mapName)

			If (Not mapMethod = Nothing) Then
				Return mapMethod(mapName)
			Else
				Return Nothing
			End If

		End Function
		
#Region "MAP esDefault"

		Private Shared Function RegisterDelegateesDefault() As Integer
		
			' This is only executed once per the life of the application
			SyncLock GetType(ErrorLogMetadata)
			
				If ErrorLogMetadata.mapDelegates Is Nothing Then
					ErrorLogMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ErrorLogMetadata._meta Is Nothing Then
					ErrorLogMetadata._meta = New ErrorLogMetadata()
				End If

				Dim mapMethod As New MapToMeta(AddressOf _meta.esDefault)
				mapDelegates.Add("esDefault", mapMethod)
				mapMethod("esDefault")
				Return 0

			End SyncLock
			
		End Function

		Private Function esDefault(ByVal mapName As String) As esProviderSpecificMetadata

			If (Not m_providerMetadataMaps.ContainsKey(mapName)) Then
			
				Dim meta As esProviderSpecificMetadata = New esProviderSpecificMetadata()
				


				meta.AddTypeMap("LogId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("DateOccured", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("UserEmail", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SourceNamespace", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ReferringURL", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("MessageOuter", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("MessageInner", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("StackTraceInner", new esTypeMap("text", "System.String"))
				meta.AddTypeMap("SourceIP", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ApplicationPage", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ErrorType", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "ErrorLog"
				meta.Destination = "ErrorLog"
				
				meta.spInsert = "proc_ErrorLogInsert"
				meta.spUpdate = "proc_ErrorLogUpdate"
				meta.spDelete = "proc_ErrorLogDelete"
				meta.spLoadAll = "proc_ErrorLogLoadAll"
				meta.spLoadByPrimaryKey = "proc_ErrorLogLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ErrorLogMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
