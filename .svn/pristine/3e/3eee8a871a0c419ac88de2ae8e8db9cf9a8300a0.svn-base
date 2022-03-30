
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/6/2013 5:51:22 PM
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
	' Encapsulates the 'EmployeeClientList' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(EmployeeClientList))> _
	<XmlType("EmployeeClientList")> _	
	Partial Public Class EmployeeClientList 
		Inherits esEmployeeClientList
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New EmployeeClientList()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal employeeClientId As System.Int32)
			Dim obj As New EmployeeClientList()
			obj.EmployeeClientId = employeeClientId
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal employeeClientId As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New EmployeeClientList()
			obj.EmployeeClientId = employeeClientId
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("EmployeeClientListCollection")> _
	Partial Public Class EmployeeClientListCollection
		Inherits esEmployeeClientListCollection
		Implements IEnumerable(Of EmployeeClientList)
	
		Public Function FindByPrimaryKey(ByVal employeeClientId As System.Int32) As EmployeeClientList
			Return MyBase.SingleOrDefault(Function(e) e.EmployeeClientId.HasValue AndAlso e.EmployeeClientId.Value = employeeClientId)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(EmployeeClientList))> _
		Public Class EmployeeClientListCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of EmployeeClientListCollection)
			
			Public Shared Widening Operator CType(packet As EmployeeClientListCollectionWCFPacket) As EmployeeClientListCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As EmployeeClientListCollection) As EmployeeClientListCollectionWCFPacket
				Return New EmployeeClientListCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class EmployeeClientListQuery 
		Inherits esEmployeeClientListQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "EmployeeClientListQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As EmployeeClientListQuery) As String
			Return EmployeeClientListQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As EmployeeClientListQuery
			Return DirectCast(EmployeeClientListQuery.SerializeHelper.FromXml(query, GetType(EmployeeClientListQuery)), EmployeeClientListQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esEmployeeClientList
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal employeeClientId As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(employeeClientId)
			Else
				Return LoadByPrimaryKeyStoredProcedure(employeeClientId)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal employeeClientId As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(employeeClientId)
			Else
				Return LoadByPrimaryKeyStoredProcedure(employeeClientId)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal employeeClientId As System.Int32) As Boolean
		
			Dim query As New EmployeeClientListQuery()
			query.Where(query.EmployeeClientId = employeeClientId)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal employeeClientId As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("EmployeeClientId", employeeClientId)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to EmployeeClientList.EmployeeClientId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EmployeeClientId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(EmployeeClientListMetadata.ColumnNames.EmployeeClientId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(EmployeeClientListMetadata.ColumnNames.EmployeeClientId, value) Then
					OnPropertyChanged(EmployeeClientListMetadata.PropertyNames.EmployeeClientId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to EmployeeClientList.EmployeeFullName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EmployeeFullName As System.String
			Get
				Return MyBase.GetSystemString(EmployeeClientListMetadata.ColumnNames.EmployeeFullName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(EmployeeClientListMetadata.ColumnNames.EmployeeFullName, value) Then
					OnPropertyChanged(EmployeeClientListMetadata.PropertyNames.EmployeeFullName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to EmployeeClientList.FileNbrPrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNbrPrefix As System.String
			Get
				Return MyBase.GetSystemString(EmployeeClientListMetadata.ColumnNames.FileNbrPrefix)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(EmployeeClientListMetadata.ColumnNames.FileNbrPrefix, value) Then
					OnPropertyChanged(EmployeeClientListMetadata.PropertyNames.FileNbrPrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to EmployeeClientList.FileNbrPrefixDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNbrPrefixDescription As System.String
			Get
				Return MyBase.GetSystemString(EmployeeClientListMetadata.ColumnNames.FileNbrPrefixDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(EmployeeClientListMetadata.ColumnNames.FileNbrPrefixDescription, value) Then
					OnPropertyChanged(EmployeeClientListMetadata.PropertyNames.FileNbrPrefixDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to EmployeeClientList.ADLogin
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ADLogin As System.String
			Get
				Return MyBase.GetSystemString(EmployeeClientListMetadata.ColumnNames.ADLogin)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(EmployeeClientListMetadata.ColumnNames.ADLogin, value) Then
					OnPropertyChanged(EmployeeClientListMetadata.PropertyNames.ADLogin)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to EmployeeClientList.EmpType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EmpType As System.String
			Get
				Return MyBase.GetSystemString(EmployeeClientListMetadata.ColumnNames.EmpType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(EmployeeClientListMetadata.ColumnNames.EmpType, value) Then
					OnPropertyChanged(EmployeeClientListMetadata.PropertyNames.EmpType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to EmployeeClientList.Email
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Email As System.String
			Get
				Return MyBase.GetSystemString(EmployeeClientListMetadata.ColumnNames.Email)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(EmployeeClientListMetadata.ColumnNames.Email, value) Then
					OnPropertyChanged(EmployeeClientListMetadata.PropertyNames.Email)
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
												
						Case "EmployeeClientId"
							Me.str().EmployeeClientId = CType(value, string)
												
						Case "EmployeeFullName"
							Me.str().EmployeeFullName = CType(value, string)
												
						Case "FileNbrPrefix"
							Me.str().FileNbrPrefix = CType(value, string)
												
						Case "FileNbrPrefixDescription"
							Me.str().FileNbrPrefixDescription = CType(value, string)
												
						Case "ADLogin"
							Me.str().ADLogin = CType(value, string)
												
						Case "EmpType"
							Me.str().EmpType = CType(value, string)
												
						Case "Email"
							Me.str().Email = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "EmployeeClientId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.EmployeeClientId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(EmployeeClientListMetadata.PropertyNames.EmployeeClientId)
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
		
			Public Sub New(ByVal entity As esEmployeeClientList)
				Me.entity = entity
			End Sub				
		
	
			Public Property EmployeeClientId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.EmployeeClientId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EmployeeClientId = Nothing
					Else
						entity.EmployeeClientId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property EmployeeFullName As System.String 
				Get
					Dim data_ As System.String = entity.EmployeeFullName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EmployeeFullName = Nothing
					Else
						entity.EmployeeFullName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FileNbrPrefix As System.String 
				Get
					Dim data_ As System.String = entity.FileNbrPrefix
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FileNbrPrefix = Nothing
					Else
						entity.FileNbrPrefix = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FileNbrPrefixDescription As System.String 
				Get
					Dim data_ As System.String = entity.FileNbrPrefixDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FileNbrPrefixDescription = Nothing
					Else
						entity.FileNbrPrefixDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ADLogin As System.String 
				Get
					Dim data_ As System.String = entity.ADLogin
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ADLogin = Nothing
					Else
						entity.ADLogin = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property EmpType As System.String 
				Get
					Dim data_ As System.String = entity.EmpType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EmpType = Nothing
					Else
						entity.EmpType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Email As System.String 
				Get
					Dim data_ As System.String = entity.Email
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Email = Nothing
					Else
						entity.Email = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esEmployeeClientList
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return EmployeeClientListMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As EmployeeClientListQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New EmployeeClientListQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As EmployeeClientListQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As EmployeeClientListQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As EmployeeClientListQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esEmployeeClientListCollection
		Inherits esEntityCollection(Of EmployeeClientList)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return EmployeeClientListMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "EmployeeClientListCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As EmployeeClientListQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New EmployeeClientListQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As EmployeeClientListQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New EmployeeClientListQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As EmployeeClientListQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, EmployeeClientListQuery))
		End Sub
		
		#End Region
						
		Private m_query As EmployeeClientListQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esEmployeeClientListQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return EmployeeClientListMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "EmployeeClientId" 
					Return Me.EmployeeClientId
				Case "EmployeeFullName" 
					Return Me.EmployeeFullName
				Case "FileNbrPrefix" 
					Return Me.FileNbrPrefix
				Case "FileNbrPrefixDescription" 
					Return Me.FileNbrPrefixDescription
				Case "ADLogin" 
					Return Me.ADLogin
				Case "EmpType" 
					Return Me.EmpType
				Case "Email" 
					Return Me.Email
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property EmployeeClientId As esQueryItem
			Get
				Return New esQueryItem(Me, EmployeeClientListMetadata.ColumnNames.EmployeeClientId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property EmployeeFullName As esQueryItem
			Get
				Return New esQueryItem(Me, EmployeeClientListMetadata.ColumnNames.EmployeeFullName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FileNbrPrefix As esQueryItem
			Get
				Return New esQueryItem(Me, EmployeeClientListMetadata.ColumnNames.FileNbrPrefix, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FileNbrPrefixDescription As esQueryItem
			Get
				Return New esQueryItem(Me, EmployeeClientListMetadata.ColumnNames.FileNbrPrefixDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ADLogin As esQueryItem
			Get
				Return New esQueryItem(Me, EmployeeClientListMetadata.ColumnNames.ADLogin, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property EmpType As esQueryItem
			Get
				Return New esQueryItem(Me, EmployeeClientListMetadata.ColumnNames.EmpType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Email As esQueryItem
			Get
				Return New esQueryItem(Me, EmployeeClientListMetadata.ColumnNames.Email, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class EmployeeClientListMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(EmployeeClientListMetadata.ColumnNames.EmployeeClientId, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = EmployeeClientListMetadata.PropertyNames.EmployeeClientId
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(EmployeeClientListMetadata.ColumnNames.EmployeeFullName, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = EmployeeClientListMetadata.PropertyNames.EmployeeFullName
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(EmployeeClientListMetadata.ColumnNames.FileNbrPrefix, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = EmployeeClientListMetadata.PropertyNames.FileNbrPrefix
			c.CharacterMaxLength = 4
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(EmployeeClientListMetadata.ColumnNames.FileNbrPrefixDescription, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = EmployeeClientListMetadata.PropertyNames.FileNbrPrefixDescription
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(EmployeeClientListMetadata.ColumnNames.ADLogin, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = EmployeeClientListMetadata.PropertyNames.ADLogin
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(EmployeeClientListMetadata.ColumnNames.EmpType, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = EmployeeClientListMetadata.PropertyNames.EmpType
			c.CharacterMaxLength = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(EmployeeClientListMetadata.ColumnNames.Email, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = EmployeeClientListMetadata.PropertyNames.Email
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As EmployeeClientListMetadata
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
			 Public Const EmployeeClientId As String = "EmployeeClientId"
			 Public Const EmployeeFullName As String = "EmployeeFullName"
			 Public Const FileNbrPrefix As String = "FileNbrPrefix"
			 Public Const FileNbrPrefixDescription As String = "FileNbrPrefixDescription"
			 Public Const ADLogin As String = "ADLogin"
			 Public Const EmpType As String = "EmpType"
			 Public Const Email As String = "Email"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const EmployeeClientId As String = "EmployeeClientId"
			 Public Const EmployeeFullName As String = "EmployeeFullName"
			 Public Const FileNbrPrefix As String = "FileNbrPrefix"
			 Public Const FileNbrPrefixDescription As String = "FileNbrPrefixDescription"
			 Public Const ADLogin As String = "ADLogin"
			 Public Const EmpType As String = "EmpType"
			 Public Const Email As String = "Email"
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
			SyncLock GetType(EmployeeClientListMetadata)
			
				If EmployeeClientListMetadata.mapDelegates Is Nothing Then
					EmployeeClientListMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If EmployeeClientListMetadata._meta Is Nothing Then
					EmployeeClientListMetadata._meta = New EmployeeClientListMetadata()
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
				


				meta.AddTypeMap("EmployeeClientId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("EmployeeFullName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FileNbrPrefix", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FileNbrPrefixDescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ADLogin", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("EmpType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Email", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "EmployeeClientList"
				meta.Destination = "EmployeeClientList"
				
				meta.spInsert = "proc_EmployeeClientListInsert"
				meta.spUpdate = "proc_EmployeeClientListUpdate"
				meta.spDelete = "proc_EmployeeClientListDelete"
				meta.spLoadAll = "proc_EmployeeClientListLoadAll"
				meta.spLoadByPrimaryKey = "proc_EmployeeClientListLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As EmployeeClientListMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
