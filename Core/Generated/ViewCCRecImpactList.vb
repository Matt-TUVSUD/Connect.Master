
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/4/2013 1:05:41 PM
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
	' Encapsulates the 'viewCCRecImpactList' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCRecImpactList))> _
	<XmlType("ViewCCRecImpactList")> _	
	Partial Public Class ViewCCRecImpactList 
		Inherits esViewCCRecImpactList
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCRecImpactList()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCRecImpactListCollection")> _
	Partial Public Class ViewCCRecImpactListCollection
		Inherits esViewCCRecImpactListCollection
		Implements IEnumerable(Of ViewCCRecImpactList)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCRecImpactList))> _
		Public Class ViewCCRecImpactListCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCRecImpactListCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCRecImpactListCollectionWCFPacket) As ViewCCRecImpactListCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCRecImpactListCollection) As ViewCCRecImpactListCollectionWCFPacket
				Return New ViewCCRecImpactListCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCRecImpactListQuery 
		Inherits esViewCCRecImpactListQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCRecImpactListQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCRecImpactListQuery) As String
			Return ViewCCRecImpactListQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCRecImpactListQuery
			Return DirectCast(ViewCCRecImpactListQuery.SerializeHelper.FromXml(query, GetType(ViewCCRecImpactListQuery)), ViewCCRecImpactListQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCRecImpactList
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCRecImpactList.CategoryText
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CategoryText As System.String
			Get
				Return MyBase.GetSystemString(ViewCCRecImpactListMetadata.ColumnNames.CategoryText)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCRecImpactListMetadata.ColumnNames.CategoryText, value) Then
					OnPropertyChanged(ViewCCRecImpactListMetadata.PropertyNames.CategoryText)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCRecImpactList.SortOrder
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SortOrder As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCRecImpactListMetadata.ColumnNames.SortOrder)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCRecImpactListMetadata.ColumnNames.SortOrder, value) Then
					OnPropertyChanged(ViewCCRecImpactListMetadata.PropertyNames.SortOrder)
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
												
						Case "CategoryText"
							Me.str().CategoryText = CType(value, string)
												
						Case "SortOrder"
							Me.str().SortOrder = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "SortOrder"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SortOrder = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCRecImpactListMetadata.PropertyNames.SortOrder)
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
		
			Public Sub New(ByVal entity As esViewCCRecImpactList)
				Me.entity = entity
			End Sub				
		
	
			Public Property CategoryText As System.String 
				Get
					Dim data_ As System.String = entity.CategoryText
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CategoryText = Nothing
					Else
						entity.CategoryText = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SortOrder As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SortOrder
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SortOrder = Nothing
					Else
						entity.SortOrder = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCCRecImpactList
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCRecImpactListMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCRecImpactListQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCRecImpactListQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCRecImpactListQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCRecImpactListQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCRecImpactListQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCRecImpactListCollection
		Inherits esEntityCollection(Of ViewCCRecImpactList)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCRecImpactListMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCRecImpactListCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCRecImpactListQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCRecImpactListQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCRecImpactListQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCRecImpactListQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCRecImpactListQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCRecImpactListQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCRecImpactListQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCRecImpactListQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCRecImpactListMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "CategoryText" 
					Return Me.CategoryText
				Case "SortOrder" 
					Return Me.SortOrder
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property CategoryText As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCRecImpactListMetadata.ColumnNames.CategoryText, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SortOrder As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCRecImpactListMetadata.ColumnNames.SortOrder, esSystemType.Int32)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCRecImpactListMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCRecImpactListMetadata.ColumnNames.CategoryText, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCRecImpactListMetadata.PropertyNames.CategoryText
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCRecImpactListMetadata.ColumnNames.SortOrder, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCRecImpactListMetadata.PropertyNames.SortOrder
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCRecImpactListMetadata
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
			 Public Const CategoryText As String = "CategoryText"
			 Public Const SortOrder As String = "SortOrder"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const CategoryText As String = "CategoryText"
			 Public Const SortOrder As String = "SortOrder"
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
			SyncLock GetType(ViewCCRecImpactListMetadata)
			
				If ViewCCRecImpactListMetadata.mapDelegates Is Nothing Then
					ViewCCRecImpactListMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCRecImpactListMetadata._meta Is Nothing Then
					ViewCCRecImpactListMetadata._meta = New ViewCCRecImpactListMetadata()
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
				


				meta.AddTypeMap("CategoryText", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SortOrder", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewCCRecImpactList"
				meta.Destination = "viewCCRecImpactList"
				
				meta.spInsert = "proc_viewCCRecImpactListInsert"
				meta.spUpdate = "proc_viewCCRecImpactListUpdate"
				meta.spDelete = "proc_viewCCRecImpactListDelete"
				meta.spLoadAll = "proc_viewCCRecImpactListLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCRecImpactListLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCRecImpactListMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
