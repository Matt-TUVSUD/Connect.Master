
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/6/2013 5:51:25 PM
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
	' Encapsulates the 'NavLevel' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(NavLevel))> _
	<XmlType("NavLevel")> _	
	Partial Public Class NavLevel 
		Inherits esNavLevel
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New NavLevel()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal navLevelId As System.Int32)
			Dim obj As New NavLevel()
			obj.NavLevelId = navLevelId
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal navLevelId As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New NavLevel()
			obj.NavLevelId = navLevelId
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("NavLevelCollection")> _
	Partial Public Class NavLevelCollection
		Inherits esNavLevelCollection
		Implements IEnumerable(Of NavLevel)
	
		Public Function FindByPrimaryKey(ByVal navLevelId As System.Int32) As NavLevel
			Return MyBase.SingleOrDefault(Function(e) e.NavLevelId.HasValue AndAlso e.NavLevelId.Value = navLevelId)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(NavLevel))> _
		Public Class NavLevelCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of NavLevelCollection)
			
			Public Shared Widening Operator CType(packet As NavLevelCollectionWCFPacket) As NavLevelCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As NavLevelCollection) As NavLevelCollectionWCFPacket
				Return New NavLevelCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class NavLevelQuery 
		Inherits esNavLevelQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "NavLevelQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As NavLevelQuery) As String
			Return NavLevelQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As NavLevelQuery
			Return DirectCast(NavLevelQuery.SerializeHelper.FromXml(query, GetType(NavLevelQuery)), NavLevelQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esNavLevel
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal navLevelId As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(navLevelId)
			Else
				Return LoadByPrimaryKeyStoredProcedure(navLevelId)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal navLevelId As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(navLevelId)
			Else
				Return LoadByPrimaryKeyStoredProcedure(navLevelId)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal navLevelId As System.Int32) As Boolean
		
			Dim query As New NavLevelQuery()
			query.Where(query.NavLevelId = navLevelId)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal navLevelId As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("NavLevelId", navLevelId)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to NavLevel.NavLevelId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavLevelId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(NavLevelMetadata.ColumnNames.NavLevelId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(NavLevelMetadata.ColumnNames.NavLevelId, value) Then
					OnPropertyChanged(NavLevelMetadata.PropertyNames.NavLevelId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NavLevel.LevelName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LevelName As System.String
			Get
				Return MyBase.GetSystemString(NavLevelMetadata.ColumnNames.LevelName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NavLevelMetadata.ColumnNames.LevelName, value) Then
					OnPropertyChanged(NavLevelMetadata.PropertyNames.LevelName)
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
												
						Case "NavLevelId"
							Me.str().NavLevelId = CType(value, string)
												
						Case "LevelName"
							Me.str().LevelName = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "NavLevelId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.NavLevelId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(NavLevelMetadata.PropertyNames.NavLevelId)
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
		
			Public Sub New(ByVal entity As esNavLevel)
				Me.entity = entity
			End Sub				
		
	
			Public Property NavLevelId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.NavLevelId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NavLevelId = Nothing
					Else
						entity.NavLevelId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property LevelName As System.String 
				Get
					Dim data_ As System.String = entity.LevelName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LevelName = Nothing
					Else
						entity.LevelName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esNavLevel
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return NavLevelMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As NavLevelQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New NavLevelQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As NavLevelQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As NavLevelQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As NavLevelQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esNavLevelCollection
		Inherits esEntityCollection(Of NavLevel)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return NavLevelMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "NavLevelCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As NavLevelQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New NavLevelQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As NavLevelQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New NavLevelQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As NavLevelQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, NavLevelQuery))
		End Sub
		
		#End Region
						
		Private m_query As NavLevelQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esNavLevelQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return NavLevelMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "NavLevelId" 
					Return Me.NavLevelId
				Case "LevelName" 
					Return Me.LevelName
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property NavLevelId As esQueryItem
			Get
				Return New esQueryItem(Me, NavLevelMetadata.ColumnNames.NavLevelId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LevelName As esQueryItem
			Get
				Return New esQueryItem(Me, NavLevelMetadata.ColumnNames.LevelName, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class NavLevelMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(NavLevelMetadata.ColumnNames.NavLevelId, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = NavLevelMetadata.PropertyNames.NavLevelId
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(NavLevelMetadata.ColumnNames.LevelName, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = NavLevelMetadata.PropertyNames.LevelName
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As NavLevelMetadata
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
			 Public Const NavLevelId As String = "NavLevelId"
			 Public Const LevelName As String = "LevelName"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const NavLevelId As String = "NavLevelId"
			 Public Const LevelName As String = "LevelName"
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
			SyncLock GetType(NavLevelMetadata)
			
				If NavLevelMetadata.mapDelegates Is Nothing Then
					NavLevelMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If NavLevelMetadata._meta Is Nothing Then
					NavLevelMetadata._meta = New NavLevelMetadata()
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
				


				meta.AddTypeMap("NavLevelId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LevelName", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "NavLevel"
				meta.Destination = "NavLevel"
				
				meta.spInsert = "proc_NavLevelInsert"
				meta.spUpdate = "proc_NavLevelUpdate"
				meta.spDelete = "proc_NavLevelDelete"
				meta.spLoadAll = "proc_NavLevelLoadAll"
				meta.spLoadByPrimaryKey = "proc_NavLevelLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As NavLevelMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
