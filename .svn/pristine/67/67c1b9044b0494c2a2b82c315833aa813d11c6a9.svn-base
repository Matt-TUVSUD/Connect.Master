
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
	' Encapsulates the 'viewCCRecSecondaryTypeList' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCRecSecondaryTypeList))> _
	<XmlType("ViewCCRecSecondaryTypeList")> _	
	Partial Public Class ViewCCRecSecondaryTypeList 
		Inherits esViewCCRecSecondaryTypeList
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCRecSecondaryTypeList()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCRecSecondaryTypeListCollection")> _
	Partial Public Class ViewCCRecSecondaryTypeListCollection
		Inherits esViewCCRecSecondaryTypeListCollection
		Implements IEnumerable(Of ViewCCRecSecondaryTypeList)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCRecSecondaryTypeList))> _
		Public Class ViewCCRecSecondaryTypeListCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCRecSecondaryTypeListCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCRecSecondaryTypeListCollectionWCFPacket) As ViewCCRecSecondaryTypeListCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCRecSecondaryTypeListCollection) As ViewCCRecSecondaryTypeListCollectionWCFPacket
				Return New ViewCCRecSecondaryTypeListCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCRecSecondaryTypeListQuery 
		Inherits esViewCCRecSecondaryTypeListQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCRecSecondaryTypeListQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCRecSecondaryTypeListQuery) As String
			Return ViewCCRecSecondaryTypeListQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCRecSecondaryTypeListQuery
			Return DirectCast(ViewCCRecSecondaryTypeListQuery.SerializeHelper.FromXml(query, GetType(ViewCCRecSecondaryTypeListQuery)), ViewCCRecSecondaryTypeListQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCRecSecondaryTypeList
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCRecSecondaryTypeList.PrimaryType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PrimaryType As System.String
			Get
				Return MyBase.GetSystemString(ViewCCRecSecondaryTypeListMetadata.ColumnNames.PrimaryType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCRecSecondaryTypeListMetadata.ColumnNames.PrimaryType, value) Then
					OnPropertyChanged(ViewCCRecSecondaryTypeListMetadata.PropertyNames.PrimaryType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCRecSecondaryTypeList.SecondarType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SecondarType As System.String
			Get
				Return MyBase.GetSystemString(ViewCCRecSecondaryTypeListMetadata.ColumnNames.SecondarType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCRecSecondaryTypeListMetadata.ColumnNames.SecondarType, value) Then
					OnPropertyChanged(ViewCCRecSecondaryTypeListMetadata.PropertyNames.SecondarType)
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
												
						Case "PrimaryType"
							Me.str().PrimaryType = CType(value, string)
												
						Case "SecondarType"
							Me.str().SecondarType = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
					
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
		
			Public Sub New(ByVal entity As esViewCCRecSecondaryTypeList)
				Me.entity = entity
			End Sub				
		
	
			Public Property PrimaryType As System.String 
				Get
					Dim data_ As System.String = entity.PrimaryType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PrimaryType = Nothing
					Else
						entity.PrimaryType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SecondarType As System.String 
				Get
					Dim data_ As System.String = entity.SecondarType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SecondarType = Nothing
					Else
						entity.SecondarType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCCRecSecondaryTypeList
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCRecSecondaryTypeListMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCRecSecondaryTypeListQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCRecSecondaryTypeListQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCRecSecondaryTypeListQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCRecSecondaryTypeListQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCRecSecondaryTypeListQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCRecSecondaryTypeListCollection
		Inherits esEntityCollection(Of ViewCCRecSecondaryTypeList)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCRecSecondaryTypeListMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCRecSecondaryTypeListCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCRecSecondaryTypeListQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCRecSecondaryTypeListQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCRecSecondaryTypeListQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCRecSecondaryTypeListQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCRecSecondaryTypeListQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCRecSecondaryTypeListQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCRecSecondaryTypeListQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCRecSecondaryTypeListQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCRecSecondaryTypeListMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "PrimaryType" 
					Return Me.PrimaryType
				Case "SecondarType" 
					Return Me.SecondarType
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property PrimaryType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCRecSecondaryTypeListMetadata.ColumnNames.PrimaryType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SecondarType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCRecSecondaryTypeListMetadata.ColumnNames.SecondarType, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCRecSecondaryTypeListMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCRecSecondaryTypeListMetadata.ColumnNames.PrimaryType, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCRecSecondaryTypeListMetadata.PropertyNames.PrimaryType
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCRecSecondaryTypeListMetadata.ColumnNames.SecondarType, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCRecSecondaryTypeListMetadata.PropertyNames.SecondarType
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCRecSecondaryTypeListMetadata
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
			 Public Const PrimaryType As String = "PrimaryType"
			 Public Const SecondarType As String = "SecondarType"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const PrimaryType As String = "PrimaryType"
			 Public Const SecondarType As String = "SecondarType"
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
			SyncLock GetType(ViewCCRecSecondaryTypeListMetadata)
			
				If ViewCCRecSecondaryTypeListMetadata.mapDelegates Is Nothing Then
					ViewCCRecSecondaryTypeListMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCRecSecondaryTypeListMetadata._meta Is Nothing Then
					ViewCCRecSecondaryTypeListMetadata._meta = New ViewCCRecSecondaryTypeListMetadata()
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
				


				meta.AddTypeMap("PrimaryType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SecondarType", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewCCRecSecondaryTypeList"
				meta.Destination = "viewCCRecSecondaryTypeList"
				
				meta.spInsert = "proc_viewCCRecSecondaryTypeListInsert"
				meta.spUpdate = "proc_viewCCRecSecondaryTypeListUpdate"
				meta.spDelete = "proc_viewCCRecSecondaryTypeListDelete"
				meta.spLoadAll = "proc_viewCCRecSecondaryTypeListLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCRecSecondaryTypeListLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCRecSecondaryTypeListMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
