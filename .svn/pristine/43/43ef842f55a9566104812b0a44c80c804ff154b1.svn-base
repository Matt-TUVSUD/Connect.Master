
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
	' Encapsulates the 'viewCCRecIntendedActionList' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCRecIntendedActionList))> _
	<XmlType("ViewCCRecIntendedActionList")> _	
	Partial Public Class ViewCCRecIntendedActionList 
		Inherits esViewCCRecIntendedActionList
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCRecIntendedActionList()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCRecIntendedActionListCollection")> _
	Partial Public Class ViewCCRecIntendedActionListCollection
		Inherits esViewCCRecIntendedActionListCollection
		Implements IEnumerable(Of ViewCCRecIntendedActionList)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCRecIntendedActionList))> _
		Public Class ViewCCRecIntendedActionListCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCRecIntendedActionListCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCRecIntendedActionListCollectionWCFPacket) As ViewCCRecIntendedActionListCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCRecIntendedActionListCollection) As ViewCCRecIntendedActionListCollectionWCFPacket
				Return New ViewCCRecIntendedActionListCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCRecIntendedActionListQuery 
		Inherits esViewCCRecIntendedActionListQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCRecIntendedActionListQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCRecIntendedActionListQuery) As String
			Return ViewCCRecIntendedActionListQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCRecIntendedActionListQuery
			Return DirectCast(ViewCCRecIntendedActionListQuery.SerializeHelper.FromXml(query, GetType(ViewCCRecIntendedActionListQuery)), ViewCCRecIntendedActionListQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCRecIntendedActionList
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCRecIntendedActionList.IntendedActionText
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property IntendedActionText As System.String
			Get
				Return MyBase.GetSystemString(ViewCCRecIntendedActionListMetadata.ColumnNames.IntendedActionText)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCRecIntendedActionListMetadata.ColumnNames.IntendedActionText, value) Then
					OnPropertyChanged(ViewCCRecIntendedActionListMetadata.PropertyNames.IntendedActionText)
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
												
						Case "IntendedActionText"
							Me.str().IntendedActionText = CType(value, string)
					
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
		
			Public Sub New(ByVal entity As esViewCCRecIntendedActionList)
				Me.entity = entity
			End Sub				
		
	
			Public Property IntendedActionText As System.String 
				Get
					Dim data_ As System.String = entity.IntendedActionText
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.IntendedActionText = Nothing
					Else
						entity.IntendedActionText = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCCRecIntendedActionList
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCRecIntendedActionListMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCRecIntendedActionListQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCRecIntendedActionListQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCRecIntendedActionListQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCRecIntendedActionListQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCRecIntendedActionListQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCRecIntendedActionListCollection
		Inherits esEntityCollection(Of ViewCCRecIntendedActionList)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCRecIntendedActionListMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCRecIntendedActionListCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCRecIntendedActionListQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCRecIntendedActionListQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCRecIntendedActionListQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCRecIntendedActionListQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCRecIntendedActionListQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCRecIntendedActionListQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCRecIntendedActionListQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCRecIntendedActionListQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCRecIntendedActionListMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "IntendedActionText" 
					Return Me.IntendedActionText
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property IntendedActionText As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCRecIntendedActionListMetadata.ColumnNames.IntendedActionText, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCRecIntendedActionListMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCRecIntendedActionListMetadata.ColumnNames.IntendedActionText, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCRecIntendedActionListMetadata.PropertyNames.IntendedActionText
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCRecIntendedActionListMetadata
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
			 Public Const IntendedActionText As String = "IntendedActionText"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const IntendedActionText As String = "IntendedActionText"
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
			SyncLock GetType(ViewCCRecIntendedActionListMetadata)
			
				If ViewCCRecIntendedActionListMetadata.mapDelegates Is Nothing Then
					ViewCCRecIntendedActionListMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCRecIntendedActionListMetadata._meta Is Nothing Then
					ViewCCRecIntendedActionListMetadata._meta = New ViewCCRecIntendedActionListMetadata()
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
				


				meta.AddTypeMap("IntendedActionText", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewCCRecIntendedActionList"
				meta.Destination = "viewCCRecIntendedActionList"
				
				meta.spInsert = "proc_viewCCRecIntendedActionListInsert"
				meta.spUpdate = "proc_viewCCRecIntendedActionListUpdate"
				meta.spDelete = "proc_viewCCRecIntendedActionListDelete"
				meta.spLoadAll = "proc_viewCCRecIntendedActionListLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCRecIntendedActionListLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCRecIntendedActionListMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
