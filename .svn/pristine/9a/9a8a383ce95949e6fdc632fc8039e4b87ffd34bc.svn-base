
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 10/23/2013 4:33:04 PM
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
	' Encapsulates the 'ddPasswordType' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(DdPasswordType))> _
	<XmlType("DdPasswordType")> _	
	Partial Public Class DdPasswordType 
		Inherits esDdPasswordType
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New DdPasswordType()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal passwordTypeID As System.Int32)
			Dim obj As New DdPasswordType()
			obj.PasswordTypeID = passwordTypeID
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal passwordTypeID As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New DdPasswordType()
			obj.PasswordTypeID = passwordTypeID
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("DdPasswordTypeCollection")> _
	Partial Public Class DdPasswordTypeCollection
		Inherits esDdPasswordTypeCollection
		Implements IEnumerable(Of DdPasswordType)
	
		Public Function FindByPrimaryKey(ByVal passwordTypeID As System.Int32) As DdPasswordType
			Return MyBase.SingleOrDefault(Function(e) e.PasswordTypeID.HasValue AndAlso e.PasswordTypeID.Value = passwordTypeID)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(DdPasswordType))> _
		Public Class DdPasswordTypeCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of DdPasswordTypeCollection)
			
			Public Shared Widening Operator CType(packet As DdPasswordTypeCollectionWCFPacket) As DdPasswordTypeCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As DdPasswordTypeCollection) As DdPasswordTypeCollectionWCFPacket
				Return New DdPasswordTypeCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class DdPasswordTypeQuery 
		Inherits esDdPasswordTypeQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "DdPasswordTypeQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As DdPasswordTypeQuery) As String
			Return DdPasswordTypeQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As DdPasswordTypeQuery
			Return DirectCast(DdPasswordTypeQuery.SerializeHelper.FromXml(query, GetType(DdPasswordTypeQuery)), DdPasswordTypeQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esDdPasswordType
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal passwordTypeID As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(passwordTypeID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(passwordTypeID)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal passwordTypeID As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(passwordTypeID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(passwordTypeID)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal passwordTypeID As System.Int32) As Boolean
		
			Dim query As New DdPasswordTypeQuery()
			query.Where(query.PasswordTypeID = passwordTypeID)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal passwordTypeID As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("PasswordTypeID", passwordTypeID)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to ddPasswordType.PasswordTypeID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PasswordTypeID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(DdPasswordTypeMetadata.ColumnNames.PasswordTypeID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(DdPasswordTypeMetadata.ColumnNames.PasswordTypeID, value) Then
					OnPropertyChanged(DdPasswordTypeMetadata.PropertyNames.PasswordTypeID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ddPasswordType.PasswordType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PasswordType As System.String
			Get
				Return MyBase.GetSystemString(DdPasswordTypeMetadata.ColumnNames.PasswordType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(DdPasswordTypeMetadata.ColumnNames.PasswordType, value) Then
					OnPropertyChanged(DdPasswordTypeMetadata.PropertyNames.PasswordType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ddPasswordType.Example
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Example As System.String
			Get
				Return MyBase.GetSystemString(DdPasswordTypeMetadata.ColumnNames.Example)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(DdPasswordTypeMetadata.ColumnNames.Example, value) Then
					OnPropertyChanged(DdPasswordTypeMetadata.PropertyNames.Example)
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
												
						Case "PasswordTypeID"
							Me.str().PasswordTypeID = CType(value, string)
												
						Case "PasswordType"
							Me.str().PasswordType = CType(value, string)
												
						Case "Example"
							Me.str().Example = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "PasswordTypeID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.PasswordTypeID = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(DdPasswordTypeMetadata.PropertyNames.PasswordTypeID)
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
		
			Public Sub New(ByVal entity As esDdPasswordType)
				Me.entity = entity
			End Sub				
		
	
			Public Property PasswordTypeID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.PasswordTypeID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PasswordTypeID = Nothing
					Else
						entity.PasswordTypeID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property PasswordType As System.String 
				Get
					Dim data_ As System.String = entity.PasswordType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PasswordType = Nothing
					Else
						entity.PasswordType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Example As System.String 
				Get
					Dim data_ As System.String = entity.Example
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Example = Nothing
					Else
						entity.Example = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esDdPasswordType
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return DdPasswordTypeMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As DdPasswordTypeQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New DdPasswordTypeQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As DdPasswordTypeQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As DdPasswordTypeQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As DdPasswordTypeQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esDdPasswordTypeCollection
		Inherits esEntityCollection(Of DdPasswordType)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return DdPasswordTypeMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "DdPasswordTypeCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As DdPasswordTypeQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New DdPasswordTypeQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As DdPasswordTypeQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New DdPasswordTypeQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As DdPasswordTypeQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, DdPasswordTypeQuery))
		End Sub
		
		#End Region
						
		Private m_query As DdPasswordTypeQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esDdPasswordTypeQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return DdPasswordTypeMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "PasswordTypeID" 
					Return Me.PasswordTypeID
				Case "PasswordType" 
					Return Me.PasswordType
				Case "Example" 
					Return Me.Example
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property PasswordTypeID As esQueryItem
			Get
				Return New esQueryItem(Me, DdPasswordTypeMetadata.ColumnNames.PasswordTypeID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property PasswordType As esQueryItem
			Get
				Return New esQueryItem(Me, DdPasswordTypeMetadata.ColumnNames.PasswordType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Example As esQueryItem
			Get
				Return New esQueryItem(Me, DdPasswordTypeMetadata.ColumnNames.Example, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class DdPasswordTypeMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(DdPasswordTypeMetadata.ColumnNames.PasswordTypeID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = DdPasswordTypeMetadata.PropertyNames.PasswordTypeID
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(DdPasswordTypeMetadata.ColumnNames.PasswordType, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = DdPasswordTypeMetadata.PropertyNames.PasswordType
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
			c = New esColumnMetadata(DdPasswordTypeMetadata.ColumnNames.Example, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = DdPasswordTypeMetadata.PropertyNames.Example
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As DdPasswordTypeMetadata
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
			 Public Const PasswordTypeID As String = "PasswordTypeID"
			 Public Const PasswordType As String = "PasswordType"
			 Public Const Example As String = "Example"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const PasswordTypeID As String = "PasswordTypeID"
			 Public Const PasswordType As String = "PasswordType"
			 Public Const Example As String = "Example"
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
			SyncLock GetType(DdPasswordTypeMetadata)
			
				If DdPasswordTypeMetadata.mapDelegates Is Nothing Then
					DdPasswordTypeMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If DdPasswordTypeMetadata._meta Is Nothing Then
					DdPasswordTypeMetadata._meta = New DdPasswordTypeMetadata()
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
				


				meta.AddTypeMap("PasswordTypeID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("PasswordType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Example", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "ddPasswordType"
				meta.Destination = "ddPasswordType"
				
				meta.spInsert = "proc_ddPasswordTypeInsert"
				meta.spUpdate = "proc_ddPasswordTypeUpdate"
				meta.spDelete = "proc_ddPasswordTypeDelete"
				meta.spLoadAll = "proc_ddPasswordTypeLoadAll"
				meta.spLoadByPrimaryKey = "proc_ddPasswordTypeLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As DdPasswordTypeMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
