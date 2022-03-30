
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
	' Encapsulates the 'GSafeDetail' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(GSafeDetail))> _
	<XmlType("GSafeDetail")> _	
	Partial Public Class GSafeDetail 
		Inherits esGSafeDetail
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New GSafeDetail()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal gSafeId As System.Int32, ByVal dataName As System.String)
			Dim obj As New GSafeDetail()
			obj.GSafeId = gSafeId
			obj.DataName = dataName
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal gSafeId As System.Int32, ByVal dataName As System.String, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New GSafeDetail()
			obj.GSafeId = gSafeId
			obj.DataName = dataName
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("GSafeDetailCollection")> _
	Partial Public Class GSafeDetailCollection
		Inherits esGSafeDetailCollection
		Implements IEnumerable(Of GSafeDetail)
	
		Public Function FindByPrimaryKey(ByVal gSafeId As System.Int32, ByVal dataName As System.String) As GSafeDetail
			Return MyBase.SingleOrDefault(Function(e) e.GSafeId.HasValue AndAlso e.GSafeId.Value = gSafeId And e.DataName = dataName)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(GSafeDetail))> _
		Public Class GSafeDetailCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of GSafeDetailCollection)
			
			Public Shared Widening Operator CType(packet As GSafeDetailCollectionWCFPacket) As GSafeDetailCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As GSafeDetailCollection) As GSafeDetailCollectionWCFPacket
				Return New GSafeDetailCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class GSafeDetailQuery 
		Inherits esGSafeDetailQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "GSafeDetailQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As GSafeDetailQuery) As String
			Return GSafeDetailQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As GSafeDetailQuery
			Return DirectCast(GSafeDetailQuery.SerializeHelper.FromXml(query, GetType(GSafeDetailQuery)), GSafeDetailQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esGSafeDetail
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal gSafeId As System.Int32, ByVal dataName As System.String) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(gSafeId, dataName)
			Else
				Return LoadByPrimaryKeyStoredProcedure(gSafeId, dataName)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal gSafeId As System.Int32, ByVal dataName As System.String) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(gSafeId, dataName)
			Else
				Return LoadByPrimaryKeyStoredProcedure(gSafeId, dataName)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal gSafeId As System.Int32, ByVal dataName As System.String) As Boolean
		
			Dim query As New GSafeDetailQuery()
			query.Where(query.GSafeId = gSafeId And query.DataName = dataName)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal gSafeId As System.Int32, ByVal dataName As System.String) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("GSafeId", gSafeId)
						parms.Add("DataName", dataName)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to GSafeDetail.GSafeId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GSafeId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(GSafeDetailMetadata.ColumnNames.GSafeId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(GSafeDetailMetadata.ColumnNames.GSafeId, value) Then
					OnPropertyChanged(GSafeDetailMetadata.PropertyNames.GSafeId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeDetail.DataName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DataName As System.String
			Get
				Return MyBase.GetSystemString(GSafeDetailMetadata.ColumnNames.DataName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GSafeDetailMetadata.ColumnNames.DataName, value) Then
					OnPropertyChanged(GSafeDetailMetadata.PropertyNames.DataName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeDetail.DataValue
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DataValue As System.String
			Get
				Return MyBase.GetSystemString(GSafeDetailMetadata.ColumnNames.DataValue)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GSafeDetailMetadata.ColumnNames.DataValue, value) Then
					OnPropertyChanged(GSafeDetailMetadata.PropertyNames.DataValue)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeDetail.DataGroup
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DataGroup As System.String
			Get
				Return MyBase.GetSystemString(GSafeDetailMetadata.ColumnNames.DataGroup)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GSafeDetailMetadata.ColumnNames.DataGroup, value) Then
					OnPropertyChanged(GSafeDetailMetadata.PropertyNames.DataGroup)
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
												
						Case "DataName"
							Me.str().DataName = CType(value, string)
												
						Case "DataValue"
							Me.str().DataValue = CType(value, string)
												
						Case "DataGroup"
							Me.str().DataGroup = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "GSafeId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.GSafeId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(GSafeDetailMetadata.PropertyNames.GSafeId)
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
		
			Public Sub New(ByVal entity As esGSafeDetail)
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
		  	
			Public Property DataName As System.String 
				Get
					Dim data_ As System.String = entity.DataName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DataName = Nothing
					Else
						entity.DataName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DataValue As System.String 
				Get
					Dim data_ As System.String = entity.DataValue
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DataValue = Nothing
					Else
						entity.DataValue = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DataGroup As System.String 
				Get
					Dim data_ As System.String = entity.DataGroup
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DataGroup = Nothing
					Else
						entity.DataGroup = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esGSafeDetail
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return GSafeDetailMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As GSafeDetailQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New GSafeDetailQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As GSafeDetailQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As GSafeDetailQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As GSafeDetailQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esGSafeDetailCollection
		Inherits esEntityCollection(Of GSafeDetail)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return GSafeDetailMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "GSafeDetailCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As GSafeDetailQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New GSafeDetailQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As GSafeDetailQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New GSafeDetailQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As GSafeDetailQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, GSafeDetailQuery))
		End Sub
		
		#End Region
						
		Private m_query As GSafeDetailQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esGSafeDetailQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return GSafeDetailMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "GSafeId" 
					Return Me.GSafeId
				Case "DataName" 
					Return Me.DataName
				Case "DataValue" 
					Return Me.DataValue
				Case "DataGroup" 
					Return Me.DataGroup
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property GSafeId As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeDetailMetadata.ColumnNames.GSafeId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property DataName As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeDetailMetadata.ColumnNames.DataName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DataValue As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeDetailMetadata.ColumnNames.DataValue, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DataGroup As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeDetailMetadata.ColumnNames.DataGroup, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class GSafeDetailMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(GSafeDetailMetadata.ColumnNames.GSafeId, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = GSafeDetailMetadata.PropertyNames.GSafeId
			c.IsInPrimaryKey = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeDetailMetadata.ColumnNames.DataName, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = GSafeDetailMetadata.PropertyNames.DataName
			c.IsInPrimaryKey = True
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeDetailMetadata.ColumnNames.DataValue, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = GSafeDetailMetadata.PropertyNames.DataValue
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeDetailMetadata.ColumnNames.DataGroup, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = GSafeDetailMetadata.PropertyNames.DataGroup
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As GSafeDetailMetadata
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
			 Public Const DataName As String = "DataName"
			 Public Const DataValue As String = "DataValue"
			 Public Const DataGroup As String = "DataGroup"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const GSafeId As String = "GSafeId"
			 Public Const DataName As String = "DataName"
			 Public Const DataValue As String = "DataValue"
			 Public Const DataGroup As String = "DataGroup"
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
			SyncLock GetType(GSafeDetailMetadata)
			
				If GSafeDetailMetadata.mapDelegates Is Nothing Then
					GSafeDetailMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If GSafeDetailMetadata._meta Is Nothing Then
					GSafeDetailMetadata._meta = New GSafeDetailMetadata()
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
				meta.AddTypeMap("DataName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DataValue", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DataGroup", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "GSafeDetail"
				meta.Destination = "GSafeDetail"
				
				meta.spInsert = "proc_GSafeDetailInsert"
				meta.spUpdate = "proc_GSafeDetailUpdate"
				meta.spDelete = "proc_GSafeDetailDelete"
				meta.spLoadAll = "proc_GSafeDetailLoadAll"
				meta.spLoadByPrimaryKey = "proc_GSafeDetailLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As GSafeDetailMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
