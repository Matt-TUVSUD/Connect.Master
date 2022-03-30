
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 6/23/2016 2:18:24 PM
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
	' Encapsulates the 'GSafeHeader' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(GSafeHeader))> _
	<XmlType("GSafeHeader")> _	
	Partial Public Class GSafeHeader 
		Inherits esGSafeHeader
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New GSafeHeader()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal gSafeId As System.Int32)
			Dim obj As New GSafeHeader()
			obj.GSafeId = gSafeId
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal gSafeId As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New GSafeHeader()
			obj.GSafeId = gSafeId
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("GSafeHeaderCollection")> _
	Partial Public Class GSafeHeaderCollection
		Inherits esGSafeHeaderCollection
		Implements IEnumerable(Of GSafeHeader)
	
		Public Function FindByPrimaryKey(ByVal gSafeId As System.Int32) As GSafeHeader
			Return MyBase.SingleOrDefault(Function(e) e.GSafeId.HasValue AndAlso e.GSafeId.Value = gSafeId)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(GSafeHeader))> _
		Public Class GSafeHeaderCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of GSafeHeaderCollection)
			
			Public Shared Widening Operator CType(packet As GSafeHeaderCollectionWCFPacket) As GSafeHeaderCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As GSafeHeaderCollection) As GSafeHeaderCollectionWCFPacket
				Return New GSafeHeaderCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class GSafeHeaderQuery 
		Inherits esGSafeHeaderQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "GSafeHeaderQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As GSafeHeaderQuery) As String
			Return GSafeHeaderQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As GSafeHeaderQuery
			Return DirectCast(GSafeHeaderQuery.SerializeHelper.FromXml(query, GetType(GSafeHeaderQuery)), GSafeHeaderQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esGSafeHeader
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal gSafeId As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(gSafeId)
			Else
				Return LoadByPrimaryKeyStoredProcedure(gSafeId)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal gSafeId As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(gSafeId)
			Else
				Return LoadByPrimaryKeyStoredProcedure(gSafeId)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal gSafeId As System.Int32) As Boolean
		
			Dim query As New GSafeHeaderQuery()
			query.Where(query.GSafeId = gSafeId)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal gSafeId As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("GSafeId", gSafeId)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to GSafeHeader.GSafeId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GSafeId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(GSafeHeaderMetadata.ColumnNames.GSafeId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(GSafeHeaderMetadata.ColumnNames.GSafeId, value) Then
					OnPropertyChanged(GSafeHeaderMetadata.PropertyNames.GSafeId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeHeader.GSafeGUID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GSafeGUID As System.String
			Get
				Return MyBase.GetSystemString(GSafeHeaderMetadata.ColumnNames.GSafeGUID)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GSafeHeaderMetadata.ColumnNames.GSafeGUID, value) Then
					OnPropertyChanged(GSafeHeaderMetadata.PropertyNames.GSafeGUID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeHeader.Created
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Created As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(GSafeHeaderMetadata.ColumnNames.Created)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(GSafeHeaderMetadata.ColumnNames.Created, value) Then
					OnPropertyChanged(GSafeHeaderMetadata.PropertyNames.Created)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeHeader.LastAccessed
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LastAccessed As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(GSafeHeaderMetadata.ColumnNames.LastAccessed)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(GSafeHeaderMetadata.ColumnNames.LastAccessed, value) Then
					OnPropertyChanged(GSafeHeaderMetadata.PropertyNames.LastAccessed)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeHeader.LastUpdated
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LastUpdated As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(GSafeHeaderMetadata.ColumnNames.LastUpdated)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(GSafeHeaderMetadata.ColumnNames.LastUpdated, value) Then
					OnPropertyChanged(GSafeHeaderMetadata.PropertyNames.LastUpdated)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeHeader.LoginName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LoginName As System.String
			Get
				Return MyBase.GetSystemString(GSafeHeaderMetadata.ColumnNames.LoginName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GSafeHeaderMetadata.ColumnNames.LoginName, value) Then
					OnPropertyChanged(GSafeHeaderMetadata.PropertyNames.LoginName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeHeader.LoginID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LoginID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(GSafeHeaderMetadata.ColumnNames.LoginID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(GSafeHeaderMetadata.ColumnNames.LoginID, value) Then
					OnPropertyChanged(GSafeHeaderMetadata.PropertyNames.LoginID)
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
												
						Case "GSafeGUID"
							Me.str().GSafeGUID = CType(value, string)
												
						Case "Created"
							Me.str().Created = CType(value, string)
												
						Case "LastAccessed"
							Me.str().LastAccessed = CType(value, string)
												
						Case "LastUpdated"
							Me.str().LastUpdated = CType(value, string)
												
						Case "LoginName"
							Me.str().LoginName = CType(value, string)
												
						Case "LoginID"
							Me.str().LoginID = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "GSafeId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.GSafeId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(GSafeHeaderMetadata.PropertyNames.GSafeId)
							End If
						
						Case "Created"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Created = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(GSafeHeaderMetadata.PropertyNames.Created)
							End If
						
						Case "LastAccessed"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.LastAccessed = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(GSafeHeaderMetadata.PropertyNames.LastAccessed)
							End If
						
						Case "LastUpdated"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.LastUpdated = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(GSafeHeaderMetadata.PropertyNames.LastUpdated)
							End If
						
						Case "LoginID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LoginID = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(GSafeHeaderMetadata.PropertyNames.LoginID)
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
		
			Public Sub New(ByVal entity As esGSafeHeader)
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
		  	
			Public Property GSafeGUID As System.String 
				Get
					Dim data_ As System.String = entity.GSafeGUID
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.GSafeGUID = Nothing
					Else
						entity.GSafeGUID = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Created As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Created
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Created = Nothing
					Else
						entity.Created = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property LastAccessed As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.LastAccessed
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LastAccessed = Nothing
					Else
						entity.LastAccessed = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property LastUpdated As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.LastUpdated
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LastUpdated = Nothing
					Else
						entity.LastUpdated = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property LoginName As System.String 
				Get
					Dim data_ As System.String = entity.LoginName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LoginName = Nothing
					Else
						entity.LoginName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LoginID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.LoginID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LoginID = Nothing
					Else
						entity.LoginID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esGSafeHeader
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return GSafeHeaderMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As GSafeHeaderQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New GSafeHeaderQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As GSafeHeaderQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As GSafeHeaderQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As GSafeHeaderQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esGSafeHeaderCollection
		Inherits esEntityCollection(Of GSafeHeader)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return GSafeHeaderMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "GSafeHeaderCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As GSafeHeaderQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New GSafeHeaderQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As GSafeHeaderQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New GSafeHeaderQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As GSafeHeaderQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, GSafeHeaderQuery))
		End Sub
		
		#End Region
						
		Private m_query As GSafeHeaderQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esGSafeHeaderQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return GSafeHeaderMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "GSafeId" 
					Return Me.GSafeId
				Case "GSafeGUID" 
					Return Me.GSafeGUID
				Case "Created" 
					Return Me.Created
				Case "LastAccessed" 
					Return Me.LastAccessed
				Case "LastUpdated" 
					Return Me.LastUpdated
				Case "LoginName" 
					Return Me.LoginName
				Case "LoginID" 
					Return Me.LoginID
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property GSafeId As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeHeaderMetadata.ColumnNames.GSafeId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property GSafeGUID As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeHeaderMetadata.ColumnNames.GSafeGUID, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Created As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeHeaderMetadata.ColumnNames.Created, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property LastAccessed As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeHeaderMetadata.ColumnNames.LastAccessed, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property LastUpdated As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeHeaderMetadata.ColumnNames.LastUpdated, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property LoginName As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeHeaderMetadata.ColumnNames.LoginName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LoginID As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeHeaderMetadata.ColumnNames.LoginID, esSystemType.Int32)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class GSafeHeader 
		Inherits esGSafeHeader
		
	
		
		
	End Class
		



	<Serializable> _
	Partial Public Class GSafeHeaderMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(GSafeHeaderMetadata.ColumnNames.GSafeId, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = GSafeHeaderMetadata.PropertyNames.GSafeId
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeHeaderMetadata.ColumnNames.GSafeGUID, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = GSafeHeaderMetadata.PropertyNames.GSafeGUID
			c.CharacterMaxLength = 40
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeHeaderMetadata.ColumnNames.Created, 2, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = GSafeHeaderMetadata.PropertyNames.Created
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeHeaderMetadata.ColumnNames.LastAccessed, 3, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = GSafeHeaderMetadata.PropertyNames.LastAccessed
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeHeaderMetadata.ColumnNames.LastUpdated, 4, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = GSafeHeaderMetadata.PropertyNames.LastUpdated
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeHeaderMetadata.ColumnNames.LoginName, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = GSafeHeaderMetadata.PropertyNames.LoginName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeHeaderMetadata.ColumnNames.LoginID, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = GSafeHeaderMetadata.PropertyNames.LoginID
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As GSafeHeaderMetadata
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
			 Public Const GSafeGUID As String = "GSafeGUID"
			 Public Const Created As String = "Created"
			 Public Const LastAccessed As String = "LastAccessed"
			 Public Const LastUpdated As String = "LastUpdated"
			 Public Const LoginName As String = "LoginName"
			 Public Const LoginID As String = "LoginID"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const GSafeId As String = "GSafeId"
			 Public Const GSafeGUID As String = "GSafeGUID"
			 Public Const Created As String = "Created"
			 Public Const LastAccessed As String = "LastAccessed"
			 Public Const LastUpdated As String = "LastUpdated"
			 Public Const LoginName As String = "LoginName"
			 Public Const LoginID As String = "LoginID"
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
			SyncLock GetType(GSafeHeaderMetadata)
			
				If GSafeHeaderMetadata.mapDelegates Is Nothing Then
					GSafeHeaderMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If GSafeHeaderMetadata._meta Is Nothing Then
					GSafeHeaderMetadata._meta = New GSafeHeaderMetadata()
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
				meta.AddTypeMap("GSafeGUID", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Created", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("LastAccessed", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("LastUpdated", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("LoginName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("LoginID", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "GSafeHeader"
				meta.Destination = "GSafeHeader"
				
				meta.spInsert = "proc_GSafeHeaderInsert"
				meta.spUpdate = "proc_GSafeHeaderUpdate"
				meta.spDelete = "proc_GSafeHeaderDelete"
				meta.spLoadAll = "proc_GSafeHeaderLoadAll"
				meta.spLoadByPrimaryKey = "proc_GSafeHeaderLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As GSafeHeaderMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
