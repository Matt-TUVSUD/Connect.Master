
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
	' Encapsulates the 'viewCCRecCompletedLossEstList' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCRecCompletedLossEstList))> _
	<XmlType("ViewCCRecCompletedLossEstList")> _	
	Partial Public Class ViewCCRecCompletedLossEstList 
		Inherits esViewCCRecCompletedLossEstList
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCRecCompletedLossEstList()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCRecCompletedLossEstListCollection")> _
	Partial Public Class ViewCCRecCompletedLossEstListCollection
		Inherits esViewCCRecCompletedLossEstListCollection
		Implements IEnumerable(Of ViewCCRecCompletedLossEstList)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCRecCompletedLossEstList))> _
		Public Class ViewCCRecCompletedLossEstListCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCRecCompletedLossEstListCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCRecCompletedLossEstListCollectionWCFPacket) As ViewCCRecCompletedLossEstListCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCRecCompletedLossEstListCollection) As ViewCCRecCompletedLossEstListCollectionWCFPacket
				Return New ViewCCRecCompletedLossEstListCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCRecCompletedLossEstListQuery 
		Inherits esViewCCRecCompletedLossEstListQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCRecCompletedLossEstListQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCRecCompletedLossEstListQuery) As String
			Return ViewCCRecCompletedLossEstListQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCRecCompletedLossEstListQuery
			Return DirectCast(ViewCCRecCompletedLossEstListQuery.SerializeHelper.FromXml(query, GetType(ViewCCRecCompletedLossEstListQuery)), ViewCCRecCompletedLossEstListQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCRecCompletedLossEstList
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCRecCompletedLossEstList.LEText
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEText As System.String
			Get
				Return MyBase.GetSystemString(ViewCCRecCompletedLossEstListMetadata.ColumnNames.LEText)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCRecCompletedLossEstListMetadata.ColumnNames.LEText, value) Then
					OnPropertyChanged(ViewCCRecCompletedLossEstListMetadata.PropertyNames.LEText)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCRecCompletedLossEstList.Order
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Order As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCRecCompletedLossEstListMetadata.ColumnNames.Order)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCRecCompletedLossEstListMetadata.ColumnNames.Order, value) Then
					OnPropertyChanged(ViewCCRecCompletedLossEstListMetadata.PropertyNames.Order)
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
												
						Case "LEText"
							Me.str().LEText = CType(value, string)
												
						Case "Order"
							Me.str().Order = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Order"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Order = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCRecCompletedLossEstListMetadata.PropertyNames.Order)
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
		
			Public Sub New(ByVal entity As esViewCCRecCompletedLossEstList)
				Me.entity = entity
			End Sub				
		
	
			Public Property LEText As System.String 
				Get
					Dim data_ As System.String = entity.LEText
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LEText = Nothing
					Else
						entity.LEText = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Order As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Order
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Order = Nothing
					Else
						entity.Order = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCCRecCompletedLossEstList
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCRecCompletedLossEstListMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCRecCompletedLossEstListQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCRecCompletedLossEstListQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCRecCompletedLossEstListQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCRecCompletedLossEstListQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCRecCompletedLossEstListQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCRecCompletedLossEstListCollection
		Inherits esEntityCollection(Of ViewCCRecCompletedLossEstList)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCRecCompletedLossEstListMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCRecCompletedLossEstListCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCRecCompletedLossEstListQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCRecCompletedLossEstListQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCRecCompletedLossEstListQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCRecCompletedLossEstListQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCRecCompletedLossEstListQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCRecCompletedLossEstListQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCRecCompletedLossEstListQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCRecCompletedLossEstListQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCRecCompletedLossEstListMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "LEText" 
					Return Me.LEText
				Case "Order" 
					Return Me.Order
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property LEText As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCRecCompletedLossEstListMetadata.ColumnNames.LEText, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Order As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCRecCompletedLossEstListMetadata.ColumnNames.Order, esSystemType.Decimal)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCRecCompletedLossEstListMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCRecCompletedLossEstListMetadata.ColumnNames.LEText, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCRecCompletedLossEstListMetadata.PropertyNames.LEText
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCRecCompletedLossEstListMetadata.ColumnNames.Order, 1, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCRecCompletedLossEstListMetadata.PropertyNames.Order
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCRecCompletedLossEstListMetadata
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
			 Public Const LEText As String = "LEText"
			 Public Const Order As String = "Order"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const LEText As String = "LEText"
			 Public Const Order As String = "Order"
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
			SyncLock GetType(ViewCCRecCompletedLossEstListMetadata)
			
				If ViewCCRecCompletedLossEstListMetadata.mapDelegates Is Nothing Then
					ViewCCRecCompletedLossEstListMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCRecCompletedLossEstListMetadata._meta Is Nothing Then
					ViewCCRecCompletedLossEstListMetadata._meta = New ViewCCRecCompletedLossEstListMetadata()
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
				


				meta.AddTypeMap("LEText", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Order", new esTypeMap("numeric", "System.Decimal"))			
				
				
				 
				meta.Source = "viewCCRecCompletedLossEstList"
				meta.Destination = "viewCCRecCompletedLossEstList"
				
				meta.spInsert = "proc_viewCCRecCompletedLossEstListInsert"
				meta.spUpdate = "proc_viewCCRecCompletedLossEstListUpdate"
				meta.spDelete = "proc_viewCCRecCompletedLossEstListDelete"
				meta.spLoadAll = "proc_viewCCRecCompletedLossEstListLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCRecCompletedLossEstListLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCRecCompletedLossEstListMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
