
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/6/2013 5:51:19 PM
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
	' Encapsulates the 'clientfeatures' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(Clientfeatures))> _
	<XmlType("Clientfeatures")> _	
	Partial Public Class Clientfeatures 
		Inherits esClientfeatures
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New Clientfeatures()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal featurescode As System.Char)
			Dim obj As New Clientfeatures()
			obj.Featurescode = featurescode
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal featurescode As System.Char, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New Clientfeatures()
			obj.Featurescode = featurescode
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ClientfeaturesCollection")> _
	Partial Public Class ClientfeaturesCollection
		Inherits esClientfeaturesCollection
		Implements IEnumerable(Of Clientfeatures)
	
		Public Function FindByPrimaryKey(ByVal featurescode As System.Char) As Clientfeatures
			Return MyBase.SingleOrDefault(Function(e) e.Featurescode = featurescode)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(Clientfeatures))> _
		Public Class ClientfeaturesCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ClientfeaturesCollection)
			
			Public Shared Widening Operator CType(packet As ClientfeaturesCollectionWCFPacket) As ClientfeaturesCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ClientfeaturesCollection) As ClientfeaturesCollectionWCFPacket
				Return New ClientfeaturesCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ClientfeaturesQuery 
		Inherits esClientfeaturesQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ClientfeaturesQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ClientfeaturesQuery) As String
			Return ClientfeaturesQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ClientfeaturesQuery
			Return DirectCast(ClientfeaturesQuery.SerializeHelper.FromXml(query, GetType(ClientfeaturesQuery)), ClientfeaturesQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esClientfeatures
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal featurescode As System.Char) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(featurescode)
			Else
				Return LoadByPrimaryKeyStoredProcedure(featurescode)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal featurescode As System.Char) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(featurescode)
			Else
				Return LoadByPrimaryKeyStoredProcedure(featurescode)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal featurescode As System.Char) As Boolean
		
			Dim query As New ClientfeaturesQuery()
			query.Where(query.Featurescode = featurescode)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal featurescode As System.Char) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("Featurescode", featurescode)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to clientfeatures.featurescode
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Featurescode As Nullable(Of System.Char)
			Get
				Return MyBase.GetSystemChar(ClientfeaturesMetadata.ColumnNames.Featurescode)
			End Get
			
			Set(ByVal value As Nullable(Of System.Char))
				If MyBase.SetSystemChar(ClientfeaturesMetadata.ColumnNames.Featurescode, value) Then
					OnPropertyChanged(ClientfeaturesMetadata.PropertyNames.Featurescode)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clientfeatures.description
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Description As System.String
			Get
				Return MyBase.GetSystemString(ClientfeaturesMetadata.ColumnNames.Description)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientfeaturesMetadata.ColumnNames.Description, value) Then
					OnPropertyChanged(ClientfeaturesMetadata.PropertyNames.Description)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clientfeatures.FullDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FullDescription As System.String
			Get
				Return MyBase.GetSystemString(ClientfeaturesMetadata.ColumnNames.FullDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientfeaturesMetadata.ColumnNames.FullDescription, value) Then
					OnPropertyChanged(ClientfeaturesMetadata.PropertyNames.FullDescription)
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
												
						Case "Featurescode"
							Me.str().Featurescode = CType(value, string)
												
						Case "Description"
							Me.str().Description = CType(value, string)
												
						Case "FullDescription"
							Me.str().FullDescription = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Featurescode"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Char" Then
								Me.Featurescode = CType(value, Nullable(Of System.Char))
								OnPropertyChanged(ClientfeaturesMetadata.PropertyNames.Featurescode)
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
		
			Public Sub New(ByVal entity As esClientfeatures)
				Me.entity = entity
			End Sub				
		
	
			Public Property Featurescode As System.String 
				Get
					Dim data_ As Nullable(Of System.Char) = entity.Featurescode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Featurescode = Nothing
					Else
						entity.Featurescode = Convert.ToChar(Value)
					End If
				End Set
			End Property
		  	
			Public Property Description As System.String 
				Get
					Dim data_ As System.String = entity.Description
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Description = Nothing
					Else
						entity.Description = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FullDescription As System.String 
				Get
					Dim data_ As System.String = entity.FullDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FullDescription = Nothing
					Else
						entity.FullDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esClientfeatures
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ClientfeaturesMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ClientfeaturesQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ClientfeaturesQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ClientfeaturesQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ClientfeaturesQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ClientfeaturesQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esClientfeaturesCollection
		Inherits esEntityCollection(Of Clientfeatures)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ClientfeaturesMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ClientfeaturesCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ClientfeaturesQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ClientfeaturesQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ClientfeaturesQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ClientfeaturesQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ClientfeaturesQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ClientfeaturesQuery))
		End Sub
		
		#End Region
						
		Private m_query As ClientfeaturesQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esClientfeaturesQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ClientfeaturesMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "Featurescode" 
					Return Me.Featurescode
				Case "Description" 
					Return Me.Description
				Case "FullDescription" 
					Return Me.FullDescription
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property Featurescode As esQueryItem
			Get
				Return New esQueryItem(Me, ClientfeaturesMetadata.ColumnNames.Featurescode, esSystemType.Char)
			End Get
		End Property 
		
		Public ReadOnly Property Description As esQueryItem
			Get
				Return New esQueryItem(Me, ClientfeaturesMetadata.ColumnNames.Description, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FullDescription As esQueryItem
			Get
				Return New esQueryItem(Me, ClientfeaturesMetadata.ColumnNames.FullDescription, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ClientfeaturesMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ClientfeaturesMetadata.ColumnNames.Featurescode, 0, GetType(System.Char), esSystemType.Char)	
			c.PropertyName = ClientfeaturesMetadata.PropertyNames.Featurescode
			c.IsInPrimaryKey = True
			c.CharacterMaxLength = 1
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientfeaturesMetadata.ColumnNames.Description, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientfeaturesMetadata.PropertyNames.Description
			c.CharacterMaxLength = 255
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientfeaturesMetadata.ColumnNames.FullDescription, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientfeaturesMetadata.PropertyNames.FullDescription
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ClientfeaturesMetadata
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
			 Public Const Featurescode As String = "featurescode"
			 Public Const Description As String = "description"
			 Public Const FullDescription As String = "FullDescription"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Featurescode As String = "Featurescode"
			 Public Const Description As String = "Description"
			 Public Const FullDescription As String = "FullDescription"
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
			SyncLock GetType(ClientfeaturesMetadata)
			
				If ClientfeaturesMetadata.mapDelegates Is Nothing Then
					ClientfeaturesMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ClientfeaturesMetadata._meta Is Nothing Then
					ClientfeaturesMetadata._meta = New ClientfeaturesMetadata()
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
				


				meta.AddTypeMap("Featurescode", new esTypeMap("char", "System.Char"))
				meta.AddTypeMap("Description", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FullDescription", new esTypeMap("text", "System.String"))			
				
				
				 
				meta.Source = "clientfeatures"
				meta.Destination = "clientfeatures"
				
				meta.spInsert = "proc_clientfeaturesInsert"
				meta.spUpdate = "proc_clientfeaturesUpdate"
				meta.spDelete = "proc_clientfeaturesDelete"
				meta.spLoadAll = "proc_clientfeaturesLoadAll"
				meta.spLoadByPrimaryKey = "proc_clientfeaturesLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ClientfeaturesMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
