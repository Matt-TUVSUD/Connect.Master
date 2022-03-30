
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/7/2013 5:09:57 PM
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
	' Encapsulates the 'viewCCFireRecommendationCounts' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCFireRecommendationCounts))> _
	<XmlType("ViewCCFireRecommendationCounts")> _	
	Partial Public Class ViewCCFireRecommendationCounts 
		Inherits esViewCCFireRecommendationCounts
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCFireRecommendationCounts()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCFireRecommendationCountsCollection")> _
	Partial Public Class ViewCCFireRecommendationCountsCollection
		Inherits esViewCCFireRecommendationCountsCollection
		Implements IEnumerable(Of ViewCCFireRecommendationCounts)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCFireRecommendationCounts))> _
		Public Class ViewCCFireRecommendationCountsCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCFireRecommendationCountsCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCFireRecommendationCountsCollectionWCFPacket) As ViewCCFireRecommendationCountsCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCFireRecommendationCountsCollection) As ViewCCFireRecommendationCountsCollectionWCFPacket
				Return New ViewCCFireRecommendationCountsCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCFireRecommendationCountsQuery 
		Inherits esViewCCFireRecommendationCountsQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCFireRecommendationCountsQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCFireRecommendationCountsQuery) As String
			Return ViewCCFireRecommendationCountsQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCFireRecommendationCountsQuery
			Return DirectCast(ViewCCFireRecommendationCountsQuery.SerializeHelper.FromXml(query, GetType(ViewCCFireRecommendationCountsQuery)), ViewCCFireRecommendationCountsQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCFireRecommendationCounts
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCFireRecommendationCounts.ResponsesCompleted
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponsesCompleted As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCFireRecommendationCountsMetadata.ColumnNames.ResponsesCompleted)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCFireRecommendationCountsMetadata.ColumnNames.ResponsesCompleted, value) Then
					OnPropertyChanged(ViewCCFireRecommendationCountsMetadata.PropertyNames.ResponsesCompleted)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireRecommendationCounts.ResponsesTotal
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponsesTotal As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCFireRecommendationCountsMetadata.ColumnNames.ResponsesTotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCFireRecommendationCountsMetadata.ColumnNames.ResponsesTotal, value) Then
					OnPropertyChanged(ViewCCFireRecommendationCountsMetadata.PropertyNames.ResponsesTotal)
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
												
						Case "ResponsesCompleted"
							Me.str().ResponsesCompleted = CType(value, string)
												
						Case "ResponsesTotal"
							Me.str().ResponsesTotal = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "ResponsesCompleted"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ResponsesCompleted = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCFireRecommendationCountsMetadata.PropertyNames.ResponsesCompleted)
							End If
						
						Case "ResponsesTotal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ResponsesTotal = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCFireRecommendationCountsMetadata.PropertyNames.ResponsesTotal)
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
		
			Public Sub New(ByVal entity As esViewCCFireRecommendationCounts)
				Me.entity = entity
			End Sub				
		
	
			Public Property ResponsesCompleted As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ResponsesCompleted
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ResponsesCompleted = Nothing
					Else
						entity.ResponsesCompleted = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ResponsesTotal As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ResponsesTotal
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ResponsesTotal = Nothing
					Else
						entity.ResponsesTotal = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCCFireRecommendationCounts
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCFireRecommendationCountsMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCFireRecommendationCountsQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCFireRecommendationCountsQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCFireRecommendationCountsQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCFireRecommendationCountsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCFireRecommendationCountsQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCFireRecommendationCountsCollection
		Inherits esEntityCollection(Of ViewCCFireRecommendationCounts)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCFireRecommendationCountsMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCFireRecommendationCountsCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCFireRecommendationCountsQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCFireRecommendationCountsQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCFireRecommendationCountsQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCFireRecommendationCountsQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCFireRecommendationCountsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCFireRecommendationCountsQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCFireRecommendationCountsQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCFireRecommendationCountsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCFireRecommendationCountsMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "ResponsesCompleted" 
					Return Me.ResponsesCompleted
				Case "ResponsesTotal" 
					Return Me.ResponsesTotal
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property ResponsesCompleted As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireRecommendationCountsMetadata.ColumnNames.ResponsesCompleted, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ResponsesTotal As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireRecommendationCountsMetadata.ColumnNames.ResponsesTotal, esSystemType.Int32)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCFireRecommendationCountsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCFireRecommendationCountsMetadata.ColumnNames.ResponsesCompleted, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCFireRecommendationCountsMetadata.PropertyNames.ResponsesCompleted
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireRecommendationCountsMetadata.ColumnNames.ResponsesTotal, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCFireRecommendationCountsMetadata.PropertyNames.ResponsesTotal
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCFireRecommendationCountsMetadata
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
			 Public Const ResponsesCompleted As String = "ResponsesCompleted"
			 Public Const ResponsesTotal As String = "ResponsesTotal"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const ResponsesCompleted As String = "ResponsesCompleted"
			 Public Const ResponsesTotal As String = "ResponsesTotal"
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
			SyncLock GetType(ViewCCFireRecommendationCountsMetadata)
			
				If ViewCCFireRecommendationCountsMetadata.mapDelegates Is Nothing Then
					ViewCCFireRecommendationCountsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCFireRecommendationCountsMetadata._meta Is Nothing Then
					ViewCCFireRecommendationCountsMetadata._meta = New ViewCCFireRecommendationCountsMetadata()
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
				


				meta.AddTypeMap("ResponsesCompleted", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ResponsesTotal", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewCCFireRecommendationCounts"
				meta.Destination = "viewCCFireRecommendationCounts"
				
				meta.spInsert = "proc_viewCCFireRecommendationCountsInsert"
				meta.spUpdate = "proc_viewCCFireRecommendationCountsUpdate"
				meta.spDelete = "proc_viewCCFireRecommendationCountsDelete"
				meta.spLoadAll = "proc_viewCCFireRecommendationCountsLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCFireRecommendationCountsLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCFireRecommendationCountsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
