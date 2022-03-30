
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 5/1/2018 10:49:31 AM
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
	' Encapsulates the 'viewCCPSRecommendationCounts' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCPSRecommendationCounts))> _
	<XmlType("ViewCCPSRecommendationCounts")> _	
	Partial Public Class ViewCCPSRecommendationCounts 
		Inherits esViewCCPSRecommendationCounts
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCPSRecommendationCounts()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCPSRecommendationCountsCollection")> _
	Partial Public Class ViewCCPSRecommendationCountsCollection
		Inherits esViewCCPSRecommendationCountsCollection
		Implements IEnumerable(Of ViewCCPSRecommendationCounts)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCPSRecommendationCounts))> _
		Public Class ViewCCPSRecommendationCountsCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCPSRecommendationCountsCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCPSRecommendationCountsCollectionWCFPacket) As ViewCCPSRecommendationCountsCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCPSRecommendationCountsCollection) As ViewCCPSRecommendationCountsCollectionWCFPacket
				Return New ViewCCPSRecommendationCountsCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCPSRecommendationCountsQuery 
		Inherits esViewCCPSRecommendationCountsQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCPSRecommendationCountsQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCPSRecommendationCountsQuery) As String
			Return ViewCCPSRecommendationCountsQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCPSRecommendationCountsQuery
			Return DirectCast(ViewCCPSRecommendationCountsQuery.SerializeHelper.FromXml(query, GetType(ViewCCPSRecommendationCountsQuery)), ViewCCPSRecommendationCountsQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCPSRecommendationCounts
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCPSRecommendationCounts.ResponsesCompleted
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponsesCompleted As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCPSRecommendationCountsMetadata.ColumnNames.ResponsesCompleted)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCPSRecommendationCountsMetadata.ColumnNames.ResponsesCompleted, value) Then
					OnPropertyChanged(ViewCCPSRecommendationCountsMetadata.PropertyNames.ResponsesCompleted)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCPSRecommendationCounts.ResponsesTotal
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponsesTotal As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCPSRecommendationCountsMetadata.ColumnNames.ResponsesTotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCPSRecommendationCountsMetadata.ColumnNames.ResponsesTotal, value) Then
					OnPropertyChanged(ViewCCPSRecommendationCountsMetadata.PropertyNames.ResponsesTotal)
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
								OnPropertyChanged(ViewCCPSRecommendationCountsMetadata.PropertyNames.ResponsesCompleted)
							End If
						
						Case "ResponsesTotal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ResponsesTotal = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCPSRecommendationCountsMetadata.PropertyNames.ResponsesTotal)
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
		
			Public Sub New(ByVal entity As esViewCCPSRecommendationCounts)
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
		  

			Private entity As esViewCCPSRecommendationCounts
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCPSRecommendationCountsMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCPSRecommendationCountsQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCPSRecommendationCountsQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCPSRecommendationCountsQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCPSRecommendationCountsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCPSRecommendationCountsQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCPSRecommendationCountsCollection
		Inherits esEntityCollection(Of ViewCCPSRecommendationCounts)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCPSRecommendationCountsMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCPSRecommendationCountsCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCPSRecommendationCountsQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCPSRecommendationCountsQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCPSRecommendationCountsQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCPSRecommendationCountsQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCPSRecommendationCountsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCPSRecommendationCountsQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCPSRecommendationCountsQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCPSRecommendationCountsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCPSRecommendationCountsMetadata.Meta()
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
				Return New esQueryItem(Me, ViewCCPSRecommendationCountsMetadata.ColumnNames.ResponsesCompleted, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ResponsesTotal As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCPSRecommendationCountsMetadata.ColumnNames.ResponsesTotal, esSystemType.Int32)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCPSRecommendationCountsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCPSRecommendationCountsMetadata.ColumnNames.ResponsesCompleted, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCPSRecommendationCountsMetadata.PropertyNames.ResponsesCompleted
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCPSRecommendationCountsMetadata.ColumnNames.ResponsesTotal, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCPSRecommendationCountsMetadata.PropertyNames.ResponsesTotal
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCPSRecommendationCountsMetadata
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
			SyncLock GetType(ViewCCPSRecommendationCountsMetadata)
			
				If ViewCCPSRecommendationCountsMetadata.mapDelegates Is Nothing Then
					ViewCCPSRecommendationCountsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCPSRecommendationCountsMetadata._meta Is Nothing Then
					ViewCCPSRecommendationCountsMetadata._meta = New ViewCCPSRecommendationCountsMetadata()
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
				
				
				 
				meta.Source = "viewCCPSRecommendationCounts"
				meta.Destination = "viewCCPSRecommendationCounts"
				
				meta.spInsert = "proc_viewCCPSRecommendationCountsInsert"
				meta.spUpdate = "proc_viewCCPSRecommendationCountsUpdate"
				meta.spDelete = "proc_viewCCPSRecommendationCountsDelete"
				meta.spLoadAll = "proc_viewCCPSRecommendationCountsLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCPSRecommendationCountsLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCPSRecommendationCountsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
