
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/6/2013 5:51:24 PM
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
	' Encapsulates the 'GSafeFilePrefixFilter' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(GSafeFilePrefixFilter))> _
	<XmlType("GSafeFilePrefixFilter")> _	
	Partial Public Class GSafeFilePrefixFilter 
		Inherits esGSafeFilePrefixFilter
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New GSafeFilePrefixFilter()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal gSafeId As System.Int32, ByVal filePrefix As System.String)
			Dim obj As New GSafeFilePrefixFilter()
			obj.GSafeId = gSafeId
			obj.FilePrefix = filePrefix
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal gSafeId As System.Int32, ByVal filePrefix As System.String, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New GSafeFilePrefixFilter()
			obj.GSafeId = gSafeId
			obj.FilePrefix = filePrefix
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("GSafeFilePrefixFilterCollection")> _
	Partial Public Class GSafeFilePrefixFilterCollection
		Inherits esGSafeFilePrefixFilterCollection
		Implements IEnumerable(Of GSafeFilePrefixFilter)
	
		Public Function FindByPrimaryKey(ByVal gSafeId As System.Int32, ByVal filePrefix As System.String) As GSafeFilePrefixFilter
			Return MyBase.SingleOrDefault(Function(e) e.GSafeId.HasValue AndAlso e.GSafeId.Value = gSafeId And e.FilePrefix = filePrefix)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(GSafeFilePrefixFilter))> _
		Public Class GSafeFilePrefixFilterCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of GSafeFilePrefixFilterCollection)
			
			Public Shared Widening Operator CType(packet As GSafeFilePrefixFilterCollectionWCFPacket) As GSafeFilePrefixFilterCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As GSafeFilePrefixFilterCollection) As GSafeFilePrefixFilterCollectionWCFPacket
				Return New GSafeFilePrefixFilterCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class GSafeFilePrefixFilterQuery 
		Inherits esGSafeFilePrefixFilterQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "GSafeFilePrefixFilterQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As GSafeFilePrefixFilterQuery) As String
			Return GSafeFilePrefixFilterQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As GSafeFilePrefixFilterQuery
			Return DirectCast(GSafeFilePrefixFilterQuery.SerializeHelper.FromXml(query, GetType(GSafeFilePrefixFilterQuery)), GSafeFilePrefixFilterQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esGSafeFilePrefixFilter
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal gSafeId As System.Int32, ByVal filePrefix As System.String) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(gSafeId, filePrefix)
			Else
				Return LoadByPrimaryKeyStoredProcedure(gSafeId, filePrefix)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal gSafeId As System.Int32, ByVal filePrefix As System.String) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(gSafeId, filePrefix)
			Else
				Return LoadByPrimaryKeyStoredProcedure(gSafeId, filePrefix)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal gSafeId As System.Int32, ByVal filePrefix As System.String) As Boolean
		
			Dim query As New GSafeFilePrefixFilterQuery()
			query.Where(query.GSafeId = gSafeId And query.FilePrefix = filePrefix)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal gSafeId As System.Int32, ByVal filePrefix As System.String) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("GSafeId", gSafeId)
						parms.Add("FilePrefix", filePrefix)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to GSafeFilePrefixFilter.GSafeId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GSafeId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(GSafeFilePrefixFilterMetadata.ColumnNames.GSafeId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(GSafeFilePrefixFilterMetadata.ColumnNames.GSafeId, value) Then
					OnPropertyChanged(GSafeFilePrefixFilterMetadata.PropertyNames.GSafeId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeFilePrefixFilter.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As System.String
			Get
				Return MyBase.GetSystemString(GSafeFilePrefixFilterMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GSafeFilePrefixFilterMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(GSafeFilePrefixFilterMetadata.PropertyNames.FilePrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeFilePrefixFilter.FilterSQL
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilterSQL As System.String
			Get
				Return MyBase.GetSystemString(GSafeFilePrefixFilterMetadata.ColumnNames.FilterSQL)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GSafeFilePrefixFilterMetadata.ColumnNames.FilterSQL, value) Then
					OnPropertyChanged(GSafeFilePrefixFilterMetadata.PropertyNames.FilterSQL)
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
												
						Case "FilePrefix"
							Me.str().FilePrefix = CType(value, string)
												
						Case "FilterSQL"
							Me.str().FilterSQL = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "GSafeId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.GSafeId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(GSafeFilePrefixFilterMetadata.PropertyNames.GSafeId)
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
		
			Public Sub New(ByVal entity As esGSafeFilePrefixFilter)
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
		  	
			Public Property FilePrefix As System.String 
				Get
					Dim data_ As System.String = entity.FilePrefix
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FilePrefix = Nothing
					Else
						entity.FilePrefix = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FilterSQL As System.String 
				Get
					Dim data_ As System.String = entity.FilterSQL
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FilterSQL = Nothing
					Else
						entity.FilterSQL = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esGSafeFilePrefixFilter
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return GSafeFilePrefixFilterMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As GSafeFilePrefixFilterQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New GSafeFilePrefixFilterQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As GSafeFilePrefixFilterQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As GSafeFilePrefixFilterQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As GSafeFilePrefixFilterQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esGSafeFilePrefixFilterCollection
		Inherits esEntityCollection(Of GSafeFilePrefixFilter)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return GSafeFilePrefixFilterMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "GSafeFilePrefixFilterCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As GSafeFilePrefixFilterQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New GSafeFilePrefixFilterQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As GSafeFilePrefixFilterQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New GSafeFilePrefixFilterQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As GSafeFilePrefixFilterQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, GSafeFilePrefixFilterQuery))
		End Sub
		
		#End Region
						
		Private m_query As GSafeFilePrefixFilterQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esGSafeFilePrefixFilterQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return GSafeFilePrefixFilterMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "GSafeId" 
					Return Me.GSafeId
				Case "FilePrefix" 
					Return Me.FilePrefix
				Case "FilterSQL" 
					Return Me.FilterSQL
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property GSafeId As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeFilePrefixFilterMetadata.ColumnNames.GSafeId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FilePrefix As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeFilePrefixFilterMetadata.ColumnNames.FilePrefix, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FilterSQL As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeFilePrefixFilterMetadata.ColumnNames.FilterSQL, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class GSafeFilePrefixFilterMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(GSafeFilePrefixFilterMetadata.ColumnNames.GSafeId, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = GSafeFilePrefixFilterMetadata.PropertyNames.GSafeId
			c.IsInPrimaryKey = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeFilePrefixFilterMetadata.ColumnNames.FilePrefix, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = GSafeFilePrefixFilterMetadata.PropertyNames.FilePrefix
			c.IsInPrimaryKey = True
			c.CharacterMaxLength = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeFilePrefixFilterMetadata.ColumnNames.FilterSQL, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = GSafeFilePrefixFilterMetadata.PropertyNames.FilterSQL
			c.CharacterMaxLength = 8000
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As GSafeFilePrefixFilterMetadata
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
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const FilterSQL As String = "FilterSQL"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const GSafeId As String = "GSafeId"
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const FilterSQL As String = "FilterSQL"
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
			SyncLock GetType(GSafeFilePrefixFilterMetadata)
			
				If GSafeFilePrefixFilterMetadata.mapDelegates Is Nothing Then
					GSafeFilePrefixFilterMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If GSafeFilePrefixFilterMetadata._meta Is Nothing Then
					GSafeFilePrefixFilterMetadata._meta = New GSafeFilePrefixFilterMetadata()
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
				meta.AddTypeMap("FilePrefix", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FilterSQL", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "GSafeFilePrefixFilter"
				meta.Destination = "GSafeFilePrefixFilter"
				
				meta.spInsert = "proc_GSafeFilePrefixFilterInsert"
				meta.spUpdate = "proc_GSafeFilePrefixFilterUpdate"
				meta.spDelete = "proc_GSafeFilePrefixFilterDelete"
				meta.spLoadAll = "proc_GSafeFilePrefixFilterLoadAll"
				meta.spLoadByPrimaryKey = "proc_GSafeFilePrefixFilterLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As GSafeFilePrefixFilterMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
