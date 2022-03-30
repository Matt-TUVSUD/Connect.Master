
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/18/2013 10:26:42 AM
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
	' Encapsulates the 'sysAppSetting' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(SysAppSetting))> _
	<XmlType("SysAppSetting")> _	
	Partial Public Class SysAppSetting 
		Inherits esSysAppSetting
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New SysAppSetting()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal appKey As System.String)
			Dim obj As New SysAppSetting()
			obj.AppKey = appKey
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal appKey As System.String, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New SysAppSetting()
			obj.AppKey = appKey
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("SysAppSettingCollection")> _
	Partial Public Class SysAppSettingCollection
		Inherits esSysAppSettingCollection
		Implements IEnumerable(Of SysAppSetting)
	
		Public Function FindByPrimaryKey(ByVal appKey As System.String) As SysAppSetting
			Return MyBase.SingleOrDefault(Function(e) e.AppKey = appKey)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(SysAppSetting))> _
		Public Class SysAppSettingCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of SysAppSettingCollection)
			
			Public Shared Widening Operator CType(packet As SysAppSettingCollectionWCFPacket) As SysAppSettingCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As SysAppSettingCollection) As SysAppSettingCollectionWCFPacket
				Return New SysAppSettingCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class SysAppSettingQuery 
		Inherits esSysAppSettingQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "SysAppSettingQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As SysAppSettingQuery) As String
			Return SysAppSettingQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As SysAppSettingQuery
			Return DirectCast(SysAppSettingQuery.SerializeHelper.FromXml(query, GetType(SysAppSettingQuery)), SysAppSettingQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esSysAppSetting
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal appKey As System.String) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(appKey)
			Else
				Return LoadByPrimaryKeyStoredProcedure(appKey)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal appKey As System.String) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(appKey)
			Else
				Return LoadByPrimaryKeyStoredProcedure(appKey)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal appKey As System.String) As Boolean
		
			Dim query As New SysAppSettingQuery()
			query.Where(query.AppKey = appKey)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal appKey As System.String) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("AppKey", appKey)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to sysAppSetting.AppKey
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AppKey As System.String
			Get
				Return MyBase.GetSystemString(SysAppSettingMetadata.ColumnNames.AppKey)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(SysAppSettingMetadata.ColumnNames.AppKey, value) Then
					OnPropertyChanged(SysAppSettingMetadata.PropertyNames.AppKey)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to sysAppSetting.AppValue
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AppValue As System.String
			Get
				Return MyBase.GetSystemString(SysAppSettingMetadata.ColumnNames.AppValue)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(SysAppSettingMetadata.ColumnNames.AppValue, value) Then
					OnPropertyChanged(SysAppSettingMetadata.PropertyNames.AppValue)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to sysAppSetting.Description
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Description As System.String
			Get
				Return MyBase.GetSystemString(SysAppSettingMetadata.ColumnNames.Description)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(SysAppSettingMetadata.ColumnNames.Description, value) Then
					OnPropertyChanged(SysAppSettingMetadata.PropertyNames.Description)
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
												
						Case "AppKey"
							Me.str().AppKey = CType(value, string)
												
						Case "AppValue"
							Me.str().AppValue = CType(value, string)
												
						Case "Description"
							Me.str().Description = CType(value, string)
					
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
		
			Public Sub New(ByVal entity As esSysAppSetting)
				Me.entity = entity
			End Sub				
		
	
			Public Property AppKey As System.String 
				Get
					Dim data_ As System.String = entity.AppKey
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AppKey = Nothing
					Else
						entity.AppKey = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property AppValue As System.String 
				Get
					Dim data_ As System.String = entity.AppValue
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AppValue = Nothing
					Else
						entity.AppValue = Convert.ToString(Value)
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
		  

			Private entity As esSysAppSetting
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return SysAppSettingMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As SysAppSettingQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New SysAppSettingQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As SysAppSettingQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As SysAppSettingQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As SysAppSettingQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esSysAppSettingCollection
		Inherits esEntityCollection(Of SysAppSetting)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return SysAppSettingMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "SysAppSettingCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As SysAppSettingQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New SysAppSettingQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As SysAppSettingQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New SysAppSettingQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As SysAppSettingQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, SysAppSettingQuery))
		End Sub
		
		#End Region
						
		Private m_query As SysAppSettingQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esSysAppSettingQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return SysAppSettingMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "AppKey" 
					Return Me.AppKey
				Case "AppValue" 
					Return Me.AppValue
				Case "Description" 
					Return Me.Description
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property AppKey As esQueryItem
			Get
				Return New esQueryItem(Me, SysAppSettingMetadata.ColumnNames.AppKey, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property AppValue As esQueryItem
			Get
				Return New esQueryItem(Me, SysAppSettingMetadata.ColumnNames.AppValue, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Description As esQueryItem
			Get
				Return New esQueryItem(Me, SysAppSettingMetadata.ColumnNames.Description, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class SysAppSetting 
		Inherits esSysAppSetting
		
	
		
		
	End Class
		



	<Serializable> _
	Partial Public Class SysAppSettingMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(SysAppSettingMetadata.ColumnNames.AppKey, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = SysAppSettingMetadata.PropertyNames.AppKey
			c.IsInPrimaryKey = True
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
			c = New esColumnMetadata(SysAppSettingMetadata.ColumnNames.AppValue, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = SysAppSettingMetadata.PropertyNames.AppValue
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(SysAppSettingMetadata.ColumnNames.Description, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = SysAppSettingMetadata.PropertyNames.Description
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As SysAppSettingMetadata
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
			 Public Const AppKey As String = "AppKey"
			 Public Const AppValue As String = "AppValue"
			 Public Const Description As String = "Description"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const AppKey As String = "AppKey"
			 Public Const AppValue As String = "AppValue"
			 Public Const Description As String = "Description"
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
			SyncLock GetType(SysAppSettingMetadata)
			
				If SysAppSettingMetadata.mapDelegates Is Nothing Then
					SysAppSettingMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If SysAppSettingMetadata._meta Is Nothing Then
					SysAppSettingMetadata._meta = New SysAppSettingMetadata()
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
				


				meta.AddTypeMap("AppKey", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("AppValue", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Description", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "sysAppSetting"
				meta.Destination = "sysAppSetting"
				
				meta.spInsert = "proc_sysAppSettingInsert"
				meta.spUpdate = "proc_sysAppSettingUpdate"
				meta.spDelete = "proc_sysAppSettingDelete"
				meta.spLoadAll = "proc_sysAppSettingLoadAll"
				meta.spLoadByPrimaryKey = "proc_sysAppSettingLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As SysAppSettingMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
