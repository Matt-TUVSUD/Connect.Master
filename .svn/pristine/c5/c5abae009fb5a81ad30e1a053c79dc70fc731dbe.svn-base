
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/6/2013 5:51:25 PM
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
	' Encapsulates the 'NavControl' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(NavControl))> _
	<XmlType("NavControl")> _	
	Partial Public Class NavControl 
		Inherits esNavControl
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New NavControl()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal navControlId As System.Int32)
			Dim obj As New NavControl()
			obj.NavControlId = navControlId
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal navControlId As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New NavControl()
			obj.NavControlId = navControlId
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("NavControlCollection")> _
	Partial Public Class NavControlCollection
		Inherits esNavControlCollection
		Implements IEnumerable(Of NavControl)
	
		Public Function FindByPrimaryKey(ByVal navControlId As System.Int32) As NavControl
			Return MyBase.SingleOrDefault(Function(e) e.NavControlId.HasValue AndAlso e.NavControlId.Value = navControlId)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(NavControl))> _
		Public Class NavControlCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of NavControlCollection)
			
			Public Shared Widening Operator CType(packet As NavControlCollectionWCFPacket) As NavControlCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As NavControlCollection) As NavControlCollectionWCFPacket
				Return New NavControlCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class NavControlQuery 
		Inherits esNavControlQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "NavControlQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As NavControlQuery) As String
			Return NavControlQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As NavControlQuery
			Return DirectCast(NavControlQuery.SerializeHelper.FromXml(query, GetType(NavControlQuery)), NavControlQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esNavControl
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal navControlId As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(navControlId)
			Else
				Return LoadByPrimaryKeyStoredProcedure(navControlId)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal navControlId As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(navControlId)
			Else
				Return LoadByPrimaryKeyStoredProcedure(navControlId)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal navControlId As System.Int32) As Boolean
		
			Dim query As New NavControlQuery()
			query.Where(query.NavControlId = navControlId)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal navControlId As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("NavControlId", navControlId)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to NavControl.NavControlId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavControlId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(NavControlMetadata.ColumnNames.NavControlId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(NavControlMetadata.ColumnNames.NavControlId, value) Then
					OnPropertyChanged(NavControlMetadata.PropertyNames.NavControlId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NavControl.ControlName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ControlName As System.String
			Get
				Return MyBase.GetSystemString(NavControlMetadata.ColumnNames.ControlName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NavControlMetadata.ColumnNames.ControlName, value) Then
					OnPropertyChanged(NavControlMetadata.PropertyNames.ControlName)
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
												
						Case "NavControlId"
							Me.str().NavControlId = CType(value, string)
												
						Case "ControlName"
							Me.str().ControlName = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "NavControlId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.NavControlId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(NavControlMetadata.PropertyNames.NavControlId)
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
		
			Public Sub New(ByVal entity As esNavControl)
				Me.entity = entity
			End Sub				
		
	
			Public Property NavControlId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.NavControlId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NavControlId = Nothing
					Else
						entity.NavControlId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ControlName As System.String 
				Get
					Dim data_ As System.String = entity.ControlName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ControlName = Nothing
					Else
						entity.ControlName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esNavControl
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return NavControlMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As NavControlQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New NavControlQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As NavControlQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As NavControlQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As NavControlQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esNavControlCollection
		Inherits esEntityCollection(Of NavControl)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return NavControlMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "NavControlCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As NavControlQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New NavControlQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As NavControlQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New NavControlQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As NavControlQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, NavControlQuery))
		End Sub
		
		#End Region
						
		Private m_query As NavControlQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esNavControlQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return NavControlMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "NavControlId" 
					Return Me.NavControlId
				Case "ControlName" 
					Return Me.ControlName
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property NavControlId As esQueryItem
			Get
				Return New esQueryItem(Me, NavControlMetadata.ColumnNames.NavControlId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ControlName As esQueryItem
			Get
				Return New esQueryItem(Me, NavControlMetadata.ColumnNames.ControlName, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class NavControlMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(NavControlMetadata.ColumnNames.NavControlId, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = NavControlMetadata.PropertyNames.NavControlId
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(NavControlMetadata.ColumnNames.ControlName, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = NavControlMetadata.PropertyNames.ControlName
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As NavControlMetadata
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
			 Public Const NavControlId As String = "NavControlId"
			 Public Const ControlName As String = "ControlName"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const NavControlId As String = "NavControlId"
			 Public Const ControlName As String = "ControlName"
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
			SyncLock GetType(NavControlMetadata)
			
				If NavControlMetadata.mapDelegates Is Nothing Then
					NavControlMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If NavControlMetadata._meta Is Nothing Then
					NavControlMetadata._meta = New NavControlMetadata()
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
				


				meta.AddTypeMap("NavControlId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ControlName", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "NavControl"
				meta.Destination = "NavControl"
				
				meta.spInsert = "proc_NavControlInsert"
				meta.spUpdate = "proc_NavControlUpdate"
				meta.spDelete = "proc_NavControlDelete"
				meta.spLoadAll = "proc_NavControlLoadAll"
				meta.spLoadByPrimaryKey = "proc_NavControlLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As NavControlMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
