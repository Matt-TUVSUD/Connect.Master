
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/6/2013 5:51:22 PM
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
	' Encapsulates the 'EventLog' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(EventLog))> _
	<XmlType("EventLog")> _	
	Partial Public Class EventLog 
		Inherits esEventLog
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New EventLog()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal logId As System.Int32)
			Dim obj As New EventLog()
			obj.LogId = logId
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal logId As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New EventLog()
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
	<XmlType("EventLogCollection")> _
	Partial Public Class EventLogCollection
		Inherits esEventLogCollection
		Implements IEnumerable(Of EventLog)
	
		Public Function FindByPrimaryKey(ByVal logId As System.Int32) As EventLog
			Return MyBase.SingleOrDefault(Function(e) e.LogId.HasValue AndAlso e.LogId.Value = logId)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(EventLog))> _
		Public Class EventLogCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of EventLogCollection)
			
			Public Shared Widening Operator CType(packet As EventLogCollectionWCFPacket) As EventLogCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As EventLogCollection) As EventLogCollectionWCFPacket
				Return New EventLogCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class EventLogQuery 
		Inherits esEventLogQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "EventLogQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As EventLogQuery) As String
			Return EventLogQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As EventLogQuery
			Return DirectCast(EventLogQuery.SerializeHelper.FromXml(query, GetType(EventLogQuery)), EventLogQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esEventLog
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
		
			Dim query As New EventLogQuery()
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
		' Maps to EventLog.LogId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LogId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(EventLogMetadata.ColumnNames.LogId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(EventLogMetadata.ColumnNames.LogId, value) Then
					OnPropertyChanged(EventLogMetadata.PropertyNames.LogId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to EventLog.Message
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Message As System.String
			Get
				Return MyBase.GetSystemString(EventLogMetadata.ColumnNames.Message)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(EventLogMetadata.ColumnNames.Message, value) Then
					OnPropertyChanged(EventLogMetadata.PropertyNames.Message)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to EventLog.EventTypeId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EventTypeId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(EventLogMetadata.ColumnNames.EventTypeId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(EventLogMetadata.ColumnNames.EventTypeId, value) Then
					OnPropertyChanged(EventLogMetadata.PropertyNames.EventTypeId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to EventLog.EventLevelId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EventLevelId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(EventLogMetadata.ColumnNames.EventLevelId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(EventLogMetadata.ColumnNames.EventLevelId, value) Then
					OnPropertyChanged(EventLogMetadata.PropertyNames.EventLevelId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to EventLog.EventDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EventDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(EventLogMetadata.ColumnNames.EventDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(EventLogMetadata.ColumnNames.EventDate, value) Then
					OnPropertyChanged(EventLogMetadata.PropertyNames.EventDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to EventLog.RptSetId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RptSetId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(EventLogMetadata.ColumnNames.RptSetId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(EventLogMetadata.ColumnNames.RptSetId, value) Then
					OnPropertyChanged(EventLogMetadata.PropertyNames.RptSetId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to EventLog.JobDefId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property JobDefId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(EventLogMetadata.ColumnNames.JobDefId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(EventLogMetadata.ColumnNames.JobDefId, value) Then
					OnPropertyChanged(EventLogMetadata.PropertyNames.JobDefId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to EventLog.REDocId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property REDocId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(EventLogMetadata.ColumnNames.REDocId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(EventLogMetadata.ColumnNames.REDocId, value) Then
					OnPropertyChanged(EventLogMetadata.PropertyNames.REDocId)
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
												
						Case "Message"
							Me.str().Message = CType(value, string)
												
						Case "EventTypeId"
							Me.str().EventTypeId = CType(value, string)
												
						Case "EventLevelId"
							Me.str().EventLevelId = CType(value, string)
												
						Case "EventDate"
							Me.str().EventDate = CType(value, string)
												
						Case "RptSetId"
							Me.str().RptSetId = CType(value, string)
												
						Case "JobDefId"
							Me.str().JobDefId = CType(value, string)
												
						Case "REDocId"
							Me.str().REDocId = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "LogId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LogId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(EventLogMetadata.PropertyNames.LogId)
							End If
						
						Case "EventTypeId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.EventTypeId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(EventLogMetadata.PropertyNames.EventTypeId)
							End If
						
						Case "EventLevelId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.EventLevelId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(EventLogMetadata.PropertyNames.EventLevelId)
							End If
						
						Case "EventDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.EventDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(EventLogMetadata.PropertyNames.EventDate)
							End If
						
						Case "RptSetId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RptSetId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(EventLogMetadata.PropertyNames.RptSetId)
							End If
						
						Case "JobDefId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.JobDefId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(EventLogMetadata.PropertyNames.JobDefId)
							End If
						
						Case "REDocId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.REDocId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(EventLogMetadata.PropertyNames.REDocId)
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
		
			Public Sub New(ByVal entity As esEventLog)
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
		  	
			Public Property Message As System.String 
				Get
					Dim data_ As System.String = entity.Message
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Message = Nothing
					Else
						entity.Message = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property EventTypeId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.EventTypeId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EventTypeId = Nothing
					Else
						entity.EventTypeId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property EventLevelId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.EventLevelId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EventLevelId = Nothing
					Else
						entity.EventLevelId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property EventDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.EventDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EventDate = Nothing
					Else
						entity.EventDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property RptSetId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RptSetId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RptSetId = Nothing
					Else
						entity.RptSetId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property JobDefId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.JobDefId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.JobDefId = Nothing
					Else
						entity.JobDefId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property REDocId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.REDocId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.REDocId = Nothing
					Else
						entity.REDocId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esEventLog
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return EventLogMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As EventLogQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New EventLogQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As EventLogQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As EventLogQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As EventLogQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esEventLogCollection
		Inherits esEntityCollection(Of EventLog)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return EventLogMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "EventLogCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As EventLogQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New EventLogQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As EventLogQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New EventLogQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As EventLogQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, EventLogQuery))
		End Sub
		
		#End Region
						
		Private m_query As EventLogQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esEventLogQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return EventLogMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "LogId" 
					Return Me.LogId
				Case "Message" 
					Return Me.Message
				Case "EventTypeId" 
					Return Me.EventTypeId
				Case "EventLevelId" 
					Return Me.EventLevelId
				Case "EventDate" 
					Return Me.EventDate
				Case "RptSetId" 
					Return Me.RptSetId
				Case "JobDefId" 
					Return Me.JobDefId
				Case "REDocId" 
					Return Me.REDocId
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property LogId As esQueryItem
			Get
				Return New esQueryItem(Me, EventLogMetadata.ColumnNames.LogId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Message As esQueryItem
			Get
				Return New esQueryItem(Me, EventLogMetadata.ColumnNames.Message, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property EventTypeId As esQueryItem
			Get
				Return New esQueryItem(Me, EventLogMetadata.ColumnNames.EventTypeId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property EventLevelId As esQueryItem
			Get
				Return New esQueryItem(Me, EventLogMetadata.ColumnNames.EventLevelId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property EventDate As esQueryItem
			Get
				Return New esQueryItem(Me, EventLogMetadata.ColumnNames.EventDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property RptSetId As esQueryItem
			Get
				Return New esQueryItem(Me, EventLogMetadata.ColumnNames.RptSetId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property JobDefId As esQueryItem
			Get
				Return New esQueryItem(Me, EventLogMetadata.ColumnNames.JobDefId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property REDocId As esQueryItem
			Get
				Return New esQueryItem(Me, EventLogMetadata.ColumnNames.REDocId, esSystemType.Int32)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class EventLogMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(EventLogMetadata.ColumnNames.LogId, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = EventLogMetadata.PropertyNames.LogId
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(EventLogMetadata.ColumnNames.Message, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = EventLogMetadata.PropertyNames.Message
			c.CharacterMaxLength = 500
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(EventLogMetadata.ColumnNames.EventTypeId, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = EventLogMetadata.PropertyNames.EventTypeId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(EventLogMetadata.ColumnNames.EventLevelId, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = EventLogMetadata.PropertyNames.EventLevelId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(EventLogMetadata.ColumnNames.EventDate, 4, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = EventLogMetadata.PropertyNames.EventDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(EventLogMetadata.ColumnNames.RptSetId, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = EventLogMetadata.PropertyNames.RptSetId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(EventLogMetadata.ColumnNames.JobDefId, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = EventLogMetadata.PropertyNames.JobDefId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(EventLogMetadata.ColumnNames.REDocId, 7, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = EventLogMetadata.PropertyNames.REDocId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As EventLogMetadata
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
			 Public Const Message As String = "Message"
			 Public Const EventTypeId As String = "EventTypeId"
			 Public Const EventLevelId As String = "EventLevelId"
			 Public Const EventDate As String = "EventDate"
			 Public Const RptSetId As String = "RptSetId"
			 Public Const JobDefId As String = "JobDefId"
			 Public Const REDocId As String = "REDocId"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const LogId As String = "LogId"
			 Public Const Message As String = "Message"
			 Public Const EventTypeId As String = "EventTypeId"
			 Public Const EventLevelId As String = "EventLevelId"
			 Public Const EventDate As String = "EventDate"
			 Public Const RptSetId As String = "RptSetId"
			 Public Const JobDefId As String = "JobDefId"
			 Public Const REDocId As String = "REDocId"
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
			SyncLock GetType(EventLogMetadata)
			
				If EventLogMetadata.mapDelegates Is Nothing Then
					EventLogMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If EventLogMetadata._meta Is Nothing Then
					EventLogMetadata._meta = New EventLogMetadata()
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
				meta.AddTypeMap("Message", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("EventTypeId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("EventLevelId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("EventDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("RptSetId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("JobDefId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("REDocId", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "EventLog"
				meta.Destination = "EventLog"
				
				meta.spInsert = "proc_EventLogInsert"
				meta.spUpdate = "proc_EventLogUpdate"
				meta.spDelete = "proc_EventLogDelete"
				meta.spLoadAll = "proc_EventLogLoadAll"
				meta.spLoadByPrimaryKey = "proc_EventLogLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As EventLogMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
