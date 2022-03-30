
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
	' Encapsulates the 'viewCCRecStatusList' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCRecStatusList))> _
	<XmlType("ViewCCRecStatusList")> _	
	Partial Public Class ViewCCRecStatusList 
		Inherits esViewCCRecStatusList
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCRecStatusList()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCRecStatusListCollection")> _
	Partial Public Class ViewCCRecStatusListCollection
		Inherits esViewCCRecStatusListCollection
		Implements IEnumerable(Of ViewCCRecStatusList)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCRecStatusList))> _
		Public Class ViewCCRecStatusListCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCRecStatusListCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCRecStatusListCollectionWCFPacket) As ViewCCRecStatusListCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCRecStatusListCollection) As ViewCCRecStatusListCollectionWCFPacket
				Return New ViewCCRecStatusListCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCRecStatusListQuery 
		Inherits esViewCCRecStatusListQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCRecStatusListQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCRecStatusListQuery) As String
			Return ViewCCRecStatusListQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCRecStatusListQuery
			Return DirectCast(ViewCCRecStatusListQuery.SerializeHelper.FromXml(query, GetType(ViewCCRecStatusListQuery)), ViewCCRecStatusListQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCRecStatusList
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCRecStatusList.StatusText
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StatusText As System.String
			Get
				Return MyBase.GetSystemString(ViewCCRecStatusListMetadata.ColumnNames.StatusText)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCRecStatusListMetadata.ColumnNames.StatusText, value) Then
					OnPropertyChanged(ViewCCRecStatusListMetadata.PropertyNames.StatusText)
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
												
						Case "StatusText"
							Me.str().StatusText = CType(value, string)
					
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
		
			Public Sub New(ByVal entity As esViewCCRecStatusList)
				Me.entity = entity
			End Sub				
		
	
			Public Property StatusText As System.String 
				Get
					Dim data_ As System.String = entity.StatusText
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.StatusText = Nothing
					Else
						entity.StatusText = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCCRecStatusList
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCRecStatusListMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCRecStatusListQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCRecStatusListQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCRecStatusListQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCRecStatusListQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCRecStatusListQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCRecStatusListCollection
		Inherits esEntityCollection(Of ViewCCRecStatusList)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCRecStatusListMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCRecStatusListCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCRecStatusListQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCRecStatusListQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCRecStatusListQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCRecStatusListQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCRecStatusListQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCRecStatusListQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCRecStatusListQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCRecStatusListQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCRecStatusListMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "StatusText" 
					Return Me.StatusText
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property StatusText As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCRecStatusListMetadata.ColumnNames.StatusText, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCRecStatusListMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCRecStatusListMetadata.ColumnNames.StatusText, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCRecStatusListMetadata.PropertyNames.StatusText
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCRecStatusListMetadata
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
			 Public Const StatusText As String = "StatusText"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const StatusText As String = "StatusText"
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
			SyncLock GetType(ViewCCRecStatusListMetadata)
			
				If ViewCCRecStatusListMetadata.mapDelegates Is Nothing Then
					ViewCCRecStatusListMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCRecStatusListMetadata._meta Is Nothing Then
					ViewCCRecStatusListMetadata._meta = New ViewCCRecStatusListMetadata()
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
				


				meta.AddTypeMap("StatusText", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewCCRecStatusList"
				meta.Destination = "viewCCRecStatusList"
				
				meta.spInsert = "proc_viewCCRecStatusListInsert"
				meta.spUpdate = "proc_viewCCRecStatusListUpdate"
				meta.spDelete = "proc_viewCCRecStatusListDelete"
				meta.spLoadAll = "proc_viewCCRecStatusListLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCRecStatusListLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCRecStatusListMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
