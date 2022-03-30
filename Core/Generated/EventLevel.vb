
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
	' Encapsulates the 'EventLevel' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(EventLevel))> _
	<XmlType("EventLevel")> _	
	Partial Public Class EventLevel 
		Inherits esEventLevel
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New EventLevel()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal eventLevelId As System.Int32)
			Dim obj As New EventLevel()
			obj.EventLevelId = eventLevelId
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal eventLevelId As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New EventLevel()
			obj.EventLevelId = eventLevelId
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("EventLevelCollection")> _
	Partial Public Class EventLevelCollection
		Inherits esEventLevelCollection
		Implements IEnumerable(Of EventLevel)
	
		Public Function FindByPrimaryKey(ByVal eventLevelId As System.Int32) As EventLevel
			Return MyBase.SingleOrDefault(Function(e) e.EventLevelId.HasValue AndAlso e.EventLevelId.Value = eventLevelId)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(EventLevel))> _
		Public Class EventLevelCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of EventLevelCollection)
			
			Public Shared Widening Operator CType(packet As EventLevelCollectionWCFPacket) As EventLevelCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As EventLevelCollection) As EventLevelCollectionWCFPacket
				Return New EventLevelCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class EventLevelQuery 
		Inherits esEventLevelQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "EventLevelQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As EventLevelQuery) As String
			Return EventLevelQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As EventLevelQuery
			Return DirectCast(EventLevelQuery.SerializeHelper.FromXml(query, GetType(EventLevelQuery)), EventLevelQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esEventLevel
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal eventLevelId As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(eventLevelId)
			Else
				Return LoadByPrimaryKeyStoredProcedure(eventLevelId)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal eventLevelId As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(eventLevelId)
			Else
				Return LoadByPrimaryKeyStoredProcedure(eventLevelId)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal eventLevelId As System.Int32) As Boolean
		
			Dim query As New EventLevelQuery()
			query.Where(query.EventLevelId = eventLevelId)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal eventLevelId As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("EventLevelId", eventLevelId)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to EventLevel.EventLevelId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EventLevelId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(EventLevelMetadata.ColumnNames.EventLevelId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(EventLevelMetadata.ColumnNames.EventLevelId, value) Then
					OnPropertyChanged(EventLevelMetadata.PropertyNames.EventLevelId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to EventLevel.Description
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Description As System.String
			Get
				Return MyBase.GetSystemString(EventLevelMetadata.ColumnNames.Description)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(EventLevelMetadata.ColumnNames.Description, value) Then
					OnPropertyChanged(EventLevelMetadata.PropertyNames.Description)
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
												
						Case "EventLevelId"
							Me.str().EventLevelId = CType(value, string)
												
						Case "Description"
							Me.str().Description = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "EventLevelId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.EventLevelId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(EventLevelMetadata.PropertyNames.EventLevelId)
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
		
			Public Sub New(ByVal entity As esEventLevel)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property Description As System.String 
				Get
					Dim data_ As System.String = entity.Description
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Description = Nothing
					Else
						entity.Description = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esEventLevel
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return EventLevelMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As EventLevelQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New EventLevelQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As EventLevelQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As EventLevelQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As EventLevelQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esEventLevelCollection
		Inherits esEntityCollection(Of EventLevel)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return EventLevelMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "EventLevelCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As EventLevelQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New EventLevelQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As EventLevelQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New EventLevelQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As EventLevelQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, EventLevelQuery))
		End Sub
		
		#End Region
						
		Private m_query As EventLevelQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esEventLevelQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return EventLevelMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "EventLevelId" 
					Return Me.EventLevelId
				Case "Description" 
					Return Me.Description
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property EventLevelId As esQueryItem
			Get
				Return New esQueryItem(Me, EventLevelMetadata.ColumnNames.EventLevelId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Description As esQueryItem
			Get
				Return New esQueryItem(Me, EventLevelMetadata.ColumnNames.Description, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class EventLevelMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(EventLevelMetadata.ColumnNames.EventLevelId, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = EventLevelMetadata.PropertyNames.EventLevelId
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(EventLevelMetadata.ColumnNames.Description, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = EventLevelMetadata.PropertyNames.Description
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As EventLevelMetadata
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
			 Public Const EventLevelId As String = "EventLevelId"
			 Public Const Description As String = "Description"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const EventLevelId As String = "EventLevelId"
			 Public Const Description As String = "Description"
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
			SyncLock GetType(EventLevelMetadata)
			
				If EventLevelMetadata.mapDelegates Is Nothing Then
					EventLevelMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If EventLevelMetadata._meta Is Nothing Then
					EventLevelMetadata._meta = New EventLevelMetadata()
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
				


				meta.AddTypeMap("EventLevelId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Description", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "EventLevel"
				meta.Destination = "EventLevel"
				
				meta.spInsert = "proc_EventLevelInsert"
				meta.spUpdate = "proc_EventLevelUpdate"
				meta.spDelete = "proc_EventLevelDelete"
				meta.spLoadAll = "proc_EventLevelLoadAll"
				meta.spLoadByPrimaryKey = "proc_EventLevelLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As EventLevelMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
