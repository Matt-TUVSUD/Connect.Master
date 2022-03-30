
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
	' Encapsulates the 'GSafeFilePrefix' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(GSafeFilePrefix))> _
	<XmlType("GSafeFilePrefix")> _	
	Partial Public Class GSafeFilePrefix 
		Inherits esGSafeFilePrefix
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New GSafeFilePrefix()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal gSafeId As System.Int32, ByVal filePrefix As System.String)
			Dim obj As New GSafeFilePrefix()
			obj.GSafeId = gSafeId
			obj.FilePrefix = filePrefix
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal gSafeId As System.Int32, ByVal filePrefix As System.String, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New GSafeFilePrefix()
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
	<XmlType("GSafeFilePrefixCollection")> _
	Partial Public Class GSafeFilePrefixCollection
		Inherits esGSafeFilePrefixCollection
		Implements IEnumerable(Of GSafeFilePrefix)
	
		Public Function FindByPrimaryKey(ByVal gSafeId As System.Int32, ByVal filePrefix As System.String) As GSafeFilePrefix
			Return MyBase.SingleOrDefault(Function(e) e.GSafeId.HasValue AndAlso e.GSafeId.Value = gSafeId And e.FilePrefix = filePrefix)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(GSafeFilePrefix))> _
		Public Class GSafeFilePrefixCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of GSafeFilePrefixCollection)
			
			Public Shared Widening Operator CType(packet As GSafeFilePrefixCollectionWCFPacket) As GSafeFilePrefixCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As GSafeFilePrefixCollection) As GSafeFilePrefixCollectionWCFPacket
				Return New GSafeFilePrefixCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class GSafeFilePrefixQuery 
		Inherits esGSafeFilePrefixQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "GSafeFilePrefixQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As GSafeFilePrefixQuery) As String
			Return GSafeFilePrefixQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As GSafeFilePrefixQuery
			Return DirectCast(GSafeFilePrefixQuery.SerializeHelper.FromXml(query, GetType(GSafeFilePrefixQuery)), GSafeFilePrefixQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esGSafeFilePrefix
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
		
			Dim query As New GSafeFilePrefixQuery()
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
		' Maps to GSafeFilePrefix.GSafeId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GSafeId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(GSafeFilePrefixMetadata.ColumnNames.GSafeId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(GSafeFilePrefixMetadata.ColumnNames.GSafeId, value) Then
					OnPropertyChanged(GSafeFilePrefixMetadata.PropertyNames.GSafeId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeFilePrefix.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As System.String
			Get
				Return MyBase.GetSystemString(GSafeFilePrefixMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GSafeFilePrefixMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(GSafeFilePrefixMetadata.PropertyNames.FilePrefix)
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
					
					End Select
					
				Else
				
					Select Case name
						
						Case "GSafeId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.GSafeId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(GSafeFilePrefixMetadata.PropertyNames.GSafeId)
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
		
			Public Sub New(ByVal entity As esGSafeFilePrefix)
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
		  

			Private entity As esGSafeFilePrefix
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return GSafeFilePrefixMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As GSafeFilePrefixQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New GSafeFilePrefixQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As GSafeFilePrefixQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As GSafeFilePrefixQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As GSafeFilePrefixQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esGSafeFilePrefixCollection
		Inherits esEntityCollection(Of GSafeFilePrefix)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return GSafeFilePrefixMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "GSafeFilePrefixCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As GSafeFilePrefixQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New GSafeFilePrefixQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As GSafeFilePrefixQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New GSafeFilePrefixQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As GSafeFilePrefixQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, GSafeFilePrefixQuery))
		End Sub
		
		#End Region
						
		Private m_query As GSafeFilePrefixQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esGSafeFilePrefixQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return GSafeFilePrefixMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "GSafeId" 
					Return Me.GSafeId
				Case "FilePrefix" 
					Return Me.FilePrefix
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property GSafeId As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeFilePrefixMetadata.ColumnNames.GSafeId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FilePrefix As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeFilePrefixMetadata.ColumnNames.FilePrefix, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class GSafeFilePrefixMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(GSafeFilePrefixMetadata.ColumnNames.GSafeId, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = GSafeFilePrefixMetadata.PropertyNames.GSafeId
			c.IsInPrimaryKey = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeFilePrefixMetadata.ColumnNames.FilePrefix, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = GSafeFilePrefixMetadata.PropertyNames.FilePrefix
			c.IsInPrimaryKey = True
			c.CharacterMaxLength = 10
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As GSafeFilePrefixMetadata
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
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const GSafeId As String = "GSafeId"
			 Public Const FilePrefix As String = "FilePrefix"
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
			SyncLock GetType(GSafeFilePrefixMetadata)
			
				If GSafeFilePrefixMetadata.mapDelegates Is Nothing Then
					GSafeFilePrefixMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If GSafeFilePrefixMetadata._meta Is Nothing Then
					GSafeFilePrefixMetadata._meta = New GSafeFilePrefixMetadata()
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
				
				
				 
				meta.Source = "GSafeFilePrefix"
				meta.Destination = "GSafeFilePrefix"
				
				meta.spInsert = "proc_GSafeFilePrefixInsert"
				meta.spUpdate = "proc_GSafeFilePrefixUpdate"
				meta.spDelete = "proc_GSafeFilePrefixDelete"
				meta.spLoadAll = "proc_GSafeFilePrefixLoadAll"
				meta.spLoadByPrimaryKey = "proc_GSafeFilePrefixLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As GSafeFilePrefixMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
