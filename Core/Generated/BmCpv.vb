
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/17/2013 1:57:00 PM
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
	' Encapsulates the 'Cope-Boiler05b-CPV' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(BmCpv))> _
	<XmlType("BmCpv")> _	
	Partial Public Class BmCpv 
		Inherits esBmCpv
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New BmCpv()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Int32)
			Dim obj As New BmCpv()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New BmCpv()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("BmCpvCollection")> _
	Partial Public Class BmCpvCollection
		Inherits esBmCpvCollection
		Implements IEnumerable(Of BmCpv)
	
		Public Function FindByPrimaryKey(ByVal id As System.Int32) As BmCpv
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(BmCpv))> _
		Public Class BmCpvCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of BmCpvCollection)
			
			Public Shared Widening Operator CType(packet As BmCpvCollectionWCFPacket) As BmCpvCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As BmCpvCollection) As BmCpvCollectionWCFPacket
				Return New BmCpvCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class BmCpvQuery 
		Inherits esBmCpvQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "BmCpvQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As BmCpvQuery) As String
			Return BmCpvQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As BmCpvQuery
			Return DirectCast(BmCpvQuery.SerializeHelper.FromXml(query, GetType(BmCpvQuery)), BmCpvQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esBmCpv
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal id As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(id)
			Else
				Return LoadByPrimaryKeyStoredProcedure(id)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal id As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(id)
			Else
				Return LoadByPrimaryKeyStoredProcedure(id)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal id As System.Int32) As Boolean
		
			Dim query As New BmCpvQuery()
			query.Where(query.Id = id)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal id As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("Id", id)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to Cope-Boiler05b-CPV.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BmCpvMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BmCpvMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(BmCpvMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler05b-CPV.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(BmCpvMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmCpvMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(BmCpvMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler05b-CPV.ItemNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ItemNo As Nullable(Of System.Byte)
			Get
				Return MyBase.GetSystemByte(BmCpvMetadata.ColumnNames.ItemNo)
			End Get
			
			Set(ByVal value As Nullable(Of System.Byte))
				If MyBase.SetSystemByte(BmCpvMetadata.ColumnNames.ItemNo, value) Then
					OnPropertyChanged(BmCpvMetadata.PropertyNames.ItemNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler05b-CPV.PVDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PVDescription As System.String
			Get
				Return MyBase.GetSystemString(BmCpvMetadata.ColumnNames.PVDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmCpvMetadata.ColumnNames.PVDescription, value) Then
					OnPropertyChanged(BmCpvMetadata.PropertyNames.PVDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler05b-CPV.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(BmCpvMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(BmCpvMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(BmCpvMetadata.PropertyNames.FilePrefix)
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
												
						Case "Id"
							Me.str().Id = CType(value, string)
												
						Case "FileNo"
							Me.str().FileNo = CType(value, string)
												
						Case "ItemNo"
							Me.str().ItemNo = CType(value, string)
												
						Case "PVDescription"
							Me.str().PVDescription = CType(value, string)
												
						Case "FilePrefix"
							Me.str().FilePrefix = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Id"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Id = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BmCpvMetadata.PropertyNames.Id)
							End If
						
						Case "ItemNo"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Byte" Then
								Me.ItemNo = CType(value, Nullable(Of System.Byte))
								OnPropertyChanged(BmCpvMetadata.PropertyNames.ItemNo)
							End If
						
						Case "FilePrefix"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.FilePrefix = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(BmCpvMetadata.PropertyNames.FilePrefix)
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
		
			Public Sub New(ByVal entity As esBmCpv)
				Me.entity = entity
			End Sub				
		
	
			Public Property Id As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Id
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Id = Nothing
					Else
						entity.Id = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property FileNo As System.String 
				Get
					Dim data_ As System.String = entity.FileNo
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FileNo = Nothing
					Else
						entity.FileNo = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ItemNo As System.String 
				Get
					Dim data_ As Nullable(Of System.Byte) = entity.ItemNo
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ItemNo = Nothing
					Else
						entity.ItemNo = Convert.ToByte(Value)
					End If
				End Set
			End Property
		  	
			Public Property PVDescription As System.String 
				Get
					Dim data_ As System.String = entity.PVDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PVDescription = Nothing
					Else
						entity.PVDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FilePrefix As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.FilePrefix
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FilePrefix = Nothing
					Else
						entity.FilePrefix = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  

			Private entity As esBmCpv
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BmCpvMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As BmCpvQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BmCpvQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As BmCpvQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As BmCpvQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As BmCpvQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esBmCpvCollection
		Inherits esEntityCollection(Of BmCpv)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BmCpvMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "BmCpvCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As BmCpvQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BmCpvQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As BmCpvQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New BmCpvQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As BmCpvQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, BmCpvQuery))
		End Sub
		
		#End Region
						
		Private m_query As BmCpvQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esBmCpvQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return BmCpvMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "Id" 
					Return Me.Id
				Case "FileNo" 
					Return Me.FileNo
				Case "ItemNo" 
					Return Me.ItemNo
				Case "PVDescription" 
					Return Me.PVDescription
				Case "FilePrefix" 
					Return Me.FilePrefix
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, BmCpvMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, BmCpvMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ItemNo As esQueryItem
			Get
				Return New esQueryItem(Me, BmCpvMetadata.ColumnNames.ItemNo, esSystemType.Byte)
			End Get
		End Property 
		
		Public ReadOnly Property PVDescription As esQueryItem
			Get
				Return New esQueryItem(Me, BmCpvMetadata.ColumnNames.PVDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FilePrefix As esQueryItem
			Get
				Return New esQueryItem(Me, BmCpvMetadata.ColumnNames.FilePrefix, esSystemType.Int16)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class BmCpv 
		Inherits esBmCpv
		
	
		
		
	End Class
		



	<Serializable> _
	Partial Public Class BmCpvMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(BmCpvMetadata.ColumnNames.Id, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BmCpvMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmCpvMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmCpvMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 9
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmCpvMetadata.ColumnNames.ItemNo, 2, GetType(System.Byte), esSystemType.Byte)	
			c.PropertyName = BmCpvMetadata.PropertyNames.ItemNo
			c.NumericPrecision = 3
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmCpvMetadata.ColumnNames.PVDescription, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmCpvMetadata.PropertyNames.PVDescription
			c.CharacterMaxLength = 300
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmCpvMetadata.ColumnNames.FilePrefix, 4, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = BmCpvMetadata.PropertyNames.FilePrefix
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As BmCpvMetadata
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
			 Public Const Id As String = "ID"
			 Public Const FileNo As String = "FileNo"
			 Public Const ItemNo As String = "ItemNo"
			 Public Const PVDescription As String = "PVDescription"
			 Public Const FilePrefix As String = "FilePrefix"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const FileNo As String = "FileNo"
			 Public Const ItemNo As String = "ItemNo"
			 Public Const PVDescription As String = "PVDescription"
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
			SyncLock GetType(BmCpvMetadata)
			
				If BmCpvMetadata.mapDelegates Is Nothing Then
					BmCpvMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If BmCpvMetadata._meta Is Nothing Then
					BmCpvMetadata._meta = New BmCpvMetadata()
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
				


				meta.AddTypeMap("Id", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FileNo", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ItemNo", new esTypeMap("tinyint", "System.Byte"))
				meta.AddTypeMap("PVDescription", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FilePrefix", new esTypeMap("smallint", "System.Int16"))			
				
				
				 
                meta.Source = "Cope-BMCPV"
                meta.Destination = "Cope-BMCPV"
				
				meta.spInsert = "proc_Cope-Boiler05b-CPVInsert"
				meta.spUpdate = "proc_Cope-Boiler05b-CPVUpdate"
				meta.spDelete = "proc_Cope-Boiler05b-CPVDelete"
				meta.spLoadAll = "proc_Cope-Boiler05b-CPVLoadAll"
				meta.spLoadByPrimaryKey = "proc_Cope-Boiler05b-CPVLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As BmCpvMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
