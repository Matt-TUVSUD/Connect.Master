
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/6/2013 5:51:26 PM
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
	' Encapsulates the 'REDocAttrib' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(REDocAttrib))> _
	<XmlType("REDocAttrib")> _	
	Partial Public Class REDocAttrib 
		Inherits esREDocAttrib
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New REDocAttrib()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal rEDocId As System.Int32, ByVal dataName As System.String)
			Dim obj As New REDocAttrib()
			obj.REDocId = rEDocId
			obj.DataName = dataName
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal rEDocId As System.Int32, ByVal dataName As System.String, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New REDocAttrib()
			obj.REDocId = rEDocId
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
	<XmlType("REDocAttribCollection")> _
	Partial Public Class REDocAttribCollection
		Inherits esREDocAttribCollection
		Implements IEnumerable(Of REDocAttrib)
	
		Public Function FindByPrimaryKey(ByVal rEDocId As System.Int32, ByVal dataName As System.String) As REDocAttrib
			Return MyBase.SingleOrDefault(Function(e) e.REDocId.HasValue AndAlso e.REDocId.Value = rEDocId And e.DataName = dataName)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(REDocAttrib))> _
		Public Class REDocAttribCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of REDocAttribCollection)
			
			Public Shared Widening Operator CType(packet As REDocAttribCollectionWCFPacket) As REDocAttribCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As REDocAttribCollection) As REDocAttribCollectionWCFPacket
				Return New REDocAttribCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class REDocAttribQuery 
		Inherits esREDocAttribQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "REDocAttribQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As REDocAttribQuery) As String
			Return REDocAttribQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As REDocAttribQuery
			Return DirectCast(REDocAttribQuery.SerializeHelper.FromXml(query, GetType(REDocAttribQuery)), REDocAttribQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esREDocAttrib
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal rEDocId As System.Int32, ByVal dataName As System.String) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(rEDocId, dataName)
			Else
				Return LoadByPrimaryKeyStoredProcedure(rEDocId, dataName)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal rEDocId As System.Int32, ByVal dataName As System.String) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(rEDocId, dataName)
			Else
				Return LoadByPrimaryKeyStoredProcedure(rEDocId, dataName)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal rEDocId As System.Int32, ByVal dataName As System.String) As Boolean
		
			Dim query As New REDocAttribQuery()
			query.Where(query.REDocId = rEDocId And query.DataName = dataName)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal rEDocId As System.Int32, ByVal dataName As System.String) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("REDocId", rEDocId)
						parms.Add("DataName", dataName)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to REDocAttrib.REDocId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property REDocId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(REDocAttribMetadata.ColumnNames.REDocId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(REDocAttribMetadata.ColumnNames.REDocId, value) Then
					OnPropertyChanged(REDocAttribMetadata.PropertyNames.REDocId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to REDocAttrib.DataName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DataName As System.String
			Get
				Return MyBase.GetSystemString(REDocAttribMetadata.ColumnNames.DataName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(REDocAttribMetadata.ColumnNames.DataName, value) Then
					OnPropertyChanged(REDocAttribMetadata.PropertyNames.DataName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to REDocAttrib.DataValue
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DataValue As System.String
			Get
				Return MyBase.GetSystemString(REDocAttribMetadata.ColumnNames.DataValue)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(REDocAttribMetadata.ColumnNames.DataValue, value) Then
					OnPropertyChanged(REDocAttribMetadata.PropertyNames.DataValue)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to REDocAttrib.DataGroup
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DataGroup As System.String
			Get
				Return MyBase.GetSystemString(REDocAttribMetadata.ColumnNames.DataGroup)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(REDocAttribMetadata.ColumnNames.DataGroup, value) Then
					OnPropertyChanged(REDocAttribMetadata.PropertyNames.DataGroup)
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
												
						Case "REDocId"
							Me.str().REDocId = CType(value, string)
												
						Case "DataName"
							Me.str().DataName = CType(value, string)
												
						Case "DataValue"
							Me.str().DataValue = CType(value, string)
												
						Case "DataGroup"
							Me.str().DataGroup = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "REDocId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.REDocId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(REDocAttribMetadata.PropertyNames.REDocId)
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
		
			Public Sub New(ByVal entity As esREDocAttrib)
				Me.entity = entity
			End Sub				
		
	
			Public Property REDocId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.REDocId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.REDocId = Nothing
					Else
						entity.REDocId = Convert.ToInt32(Value)
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
		  

			Private entity As esREDocAttrib
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return REDocAttribMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As REDocAttribQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New REDocAttribQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As REDocAttribQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As REDocAttribQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As REDocAttribQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esREDocAttribCollection
		Inherits esEntityCollection(Of REDocAttrib)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return REDocAttribMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "REDocAttribCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As REDocAttribQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New REDocAttribQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As REDocAttribQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New REDocAttribQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As REDocAttribQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, REDocAttribQuery))
		End Sub
		
		#End Region
						
		Private m_query As REDocAttribQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esREDocAttribQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return REDocAttribMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "REDocId" 
					Return Me.REDocId
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


		Public ReadOnly Property REDocId As esQueryItem
			Get
				Return New esQueryItem(Me, REDocAttribMetadata.ColumnNames.REDocId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property DataName As esQueryItem
			Get
				Return New esQueryItem(Me, REDocAttribMetadata.ColumnNames.DataName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DataValue As esQueryItem
			Get
				Return New esQueryItem(Me, REDocAttribMetadata.ColumnNames.DataValue, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DataGroup As esQueryItem
			Get
				Return New esQueryItem(Me, REDocAttribMetadata.ColumnNames.DataGroup, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class REDocAttribMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(REDocAttribMetadata.ColumnNames.REDocId, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = REDocAttribMetadata.PropertyNames.REDocId
			c.IsInPrimaryKey = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(REDocAttribMetadata.ColumnNames.DataName, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = REDocAttribMetadata.PropertyNames.DataName
			c.IsInPrimaryKey = True
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
			c = New esColumnMetadata(REDocAttribMetadata.ColumnNames.DataValue, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = REDocAttribMetadata.PropertyNames.DataValue
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(REDocAttribMetadata.ColumnNames.DataGroup, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = REDocAttribMetadata.PropertyNames.DataGroup
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As REDocAttribMetadata
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
			 Public Const REDocId As String = "REDocId"
			 Public Const DataName As String = "DataName"
			 Public Const DataValue As String = "DataValue"
			 Public Const DataGroup As String = "DataGroup"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const REDocId As String = "REDocId"
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
			SyncLock GetType(REDocAttribMetadata)
			
				If REDocAttribMetadata.mapDelegates Is Nothing Then
					REDocAttribMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If REDocAttribMetadata._meta Is Nothing Then
					REDocAttribMetadata._meta = New REDocAttribMetadata()
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
				


				meta.AddTypeMap("REDocId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("DataName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DataValue", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DataGroup", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "REDocAttrib"
				meta.Destination = "REDocAttrib"
				
				meta.spInsert = "proc_REDocAttribInsert"
				meta.spUpdate = "proc_REDocAttribUpdate"
				meta.spDelete = "proc_REDocAttribDelete"
				meta.spLoadAll = "proc_REDocAttribLoadAll"
				meta.spLoadByPrimaryKey = "proc_REDocAttribLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As REDocAttribMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
