
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/16/2017 9:35:12 AM
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
	' Encapsulates the 'GSafeSlideMenu' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(GSafeSlideMenu))> _
	<XmlType("GSafeSlideMenu")> _	
	Partial Public Class GSafeSlideMenu 
		Inherits esGSafeSlideMenu
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New GSafeSlideMenu()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("GSafeSlideMenuCollection")> _
	Partial Public Class GSafeSlideMenuCollection
		Inherits esGSafeSlideMenuCollection
		Implements IEnumerable(Of GSafeSlideMenu)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(GSafeSlideMenu))> _
		Public Class GSafeSlideMenuCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of GSafeSlideMenuCollection)
			
			Public Shared Widening Operator CType(packet As GSafeSlideMenuCollectionWCFPacket) As GSafeSlideMenuCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As GSafeSlideMenuCollection) As GSafeSlideMenuCollectionWCFPacket
				Return New GSafeSlideMenuCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class GSafeSlideMenuQuery 
		Inherits esGSafeSlideMenuQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "GSafeSlideMenuQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As GSafeSlideMenuQuery) As String
			Return GSafeSlideMenuQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As GSafeSlideMenuQuery
			Return DirectCast(GSafeSlideMenuQuery.SerializeHelper.FromXml(query, GetType(GSafeSlideMenuQuery)), GSafeSlideMenuQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esGSafeSlideMenu
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey() As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic()
			Else
				Return LoadByPrimaryKeyStoredProcedure()
			End If
			
		End Function
	
        Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType) As Boolean

            If sqlAccessType = esSqlAccessType.DynamicSQL Then
                Return LoadByPrimaryKeyDynamic()
            Else
                Return LoadByPrimaryKeyStoredProcedure()
            End If

        End Function
	
		Private Function LoadByPrimaryKeyDynamic() As Boolean
		
			Dim query As New GSafeSlideMenuQuery()
			query.Where()
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure() As Boolean
		
			Dim parms As esParameters = New esParameters()

			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to GSafeSlideMenu.GSafeId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GSafeId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(GSafeSlideMenuMetadata.ColumnNames.GSafeId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(GSafeSlideMenuMetadata.ColumnNames.GSafeId, value) Then
					OnPropertyChanged(GSafeSlideMenuMetadata.PropertyNames.GSafeId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeSlideMenu.SlideMenuJSON
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SlideMenuJSON As System.String
			Get
				Return MyBase.GetSystemString(GSafeSlideMenuMetadata.ColumnNames.SlideMenuJSON)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GSafeSlideMenuMetadata.ColumnNames.SlideMenuJSON, value) Then
					OnPropertyChanged(GSafeSlideMenuMetadata.PropertyNames.SlideMenuJSON)
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
												
						Case "GSafeId"
							Me.str().GSafeId = CType(value, string)
												
						Case "SlideMenuJSON"
							Me.str().SlideMenuJSON = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "GSafeId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.GSafeId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(GSafeSlideMenuMetadata.PropertyNames.GSafeId)
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
		
			Public Sub New(ByVal entity As esGSafeSlideMenu)
				Me.entity = entity
			End Sub				
		
	
			Public Property GSafeId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.GSafeId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.GSafeId = Nothing
					Else
						entity.GSafeId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property SlideMenuJSON As System.String 
				Get
					Dim data_ As System.String = entity.SlideMenuJSON
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SlideMenuJSON = Nothing
					Else
						entity.SlideMenuJSON = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esGSafeSlideMenu
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return GSafeSlideMenuMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As GSafeSlideMenuQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New GSafeSlideMenuQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As GSafeSlideMenuQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As GSafeSlideMenuQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As GSafeSlideMenuQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esGSafeSlideMenuCollection
		Inherits esEntityCollection(Of GSafeSlideMenu)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return GSafeSlideMenuMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "GSafeSlideMenuCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As GSafeSlideMenuQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New GSafeSlideMenuQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As GSafeSlideMenuQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New GSafeSlideMenuQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As GSafeSlideMenuQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, GSafeSlideMenuQuery))
		End Sub
		
		#End Region
						
		Private m_query As GSafeSlideMenuQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esGSafeSlideMenuQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return GSafeSlideMenuMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "GSafeId" 
					Return Me.GSafeId
				Case "SlideMenuJSON" 
					Return Me.SlideMenuJSON
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property GSafeId As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeSlideMenuMetadata.ColumnNames.GSafeId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SlideMenuJSON As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeSlideMenuMetadata.ColumnNames.SlideMenuJSON, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class GSafeSlideMenuMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(GSafeSlideMenuMetadata.ColumnNames.GSafeId, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = GSafeSlideMenuMetadata.PropertyNames.GSafeId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeSlideMenuMetadata.ColumnNames.SlideMenuJSON, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = GSafeSlideMenuMetadata.PropertyNames.SlideMenuJSON
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As GSafeSlideMenuMetadata
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
			 Public Const GSafeId As String = "GSafeId"
			 Public Const SlideMenuJSON As String = "SlideMenuJSON"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const GSafeId As String = "GSafeId"
			 Public Const SlideMenuJSON As String = "SlideMenuJSON"
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
			SyncLock GetType(GSafeSlideMenuMetadata)
			
				If GSafeSlideMenuMetadata.mapDelegates Is Nothing Then
					GSafeSlideMenuMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If GSafeSlideMenuMetadata._meta Is Nothing Then
					GSafeSlideMenuMetadata._meta = New GSafeSlideMenuMetadata()
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
				


				meta.AddTypeMap("GSafeId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SlideMenuJSON", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "GSafeSlideMenu"
				meta.Destination = "GSafeSlideMenu"
				
				meta.spInsert = "proc_GSafeSlideMenuInsert"
				meta.spUpdate = "proc_GSafeSlideMenuUpdate"
				meta.spDelete = "proc_GSafeSlideMenuDelete"
				meta.spLoadAll = "proc_GSafeSlideMenuLoadAll"
				meta.spLoadByPrimaryKey = "proc_GSafeSlideMenuLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As GSafeSlideMenuMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
