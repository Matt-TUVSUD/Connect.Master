
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/4/2013 1:05:41 PM
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
	' Encapsulates the 'viewCCLocationOpenViolationCountJuris' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCLocationOpenViolationCountJuris))> _
	<XmlType("ViewCCLocationOpenViolationCountJuris")> _	
	Partial Public Class ViewCCLocationOpenViolationCountJuris 
		Inherits esViewCCLocationOpenViolationCountJuris
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCLocationOpenViolationCountJuris()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCLocationOpenViolationCountJurisCollection")> _
	Partial Public Class ViewCCLocationOpenViolationCountJurisCollection
		Inherits esViewCCLocationOpenViolationCountJurisCollection
		Implements IEnumerable(Of ViewCCLocationOpenViolationCountJuris)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCLocationOpenViolationCountJuris))> _
		Public Class ViewCCLocationOpenViolationCountJurisCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCLocationOpenViolationCountJurisCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCLocationOpenViolationCountJurisCollectionWCFPacket) As ViewCCLocationOpenViolationCountJurisCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCLocationOpenViolationCountJurisCollection) As ViewCCLocationOpenViolationCountJurisCollectionWCFPacket
				Return New ViewCCLocationOpenViolationCountJurisCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCLocationOpenViolationCountJurisQuery 
		Inherits esViewCCLocationOpenViolationCountJurisQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCLocationOpenViolationCountJurisQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCLocationOpenViolationCountJurisQuery) As String
			Return ViewCCLocationOpenViolationCountJurisQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCLocationOpenViolationCountJurisQuery
			Return DirectCast(ViewCCLocationOpenViolationCountJurisQuery.SerializeHelper.FromXml(query, GetType(ViewCCLocationOpenViolationCountJurisQuery)), ViewCCLocationOpenViolationCountJurisQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCLocationOpenViolationCountJuris
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCLocationOpenViolationCountJuris.fileno
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Fileno As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationOpenViolationCountJurisMetadata.ColumnNames.Fileno)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationOpenViolationCountJurisMetadata.ColumnNames.Fileno, value) Then
					OnPropertyChanged(ViewCCLocationOpenViolationCountJurisMetadata.PropertyNames.Fileno)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationOpenViolationCountJuris.CountOpen
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CountOpen As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCLocationOpenViolationCountJurisMetadata.ColumnNames.CountOpen)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCLocationOpenViolationCountJurisMetadata.ColumnNames.CountOpen, value) Then
					OnPropertyChanged(ViewCCLocationOpenViolationCountJurisMetadata.PropertyNames.CountOpen)
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
												
						Case "Fileno"
							Me.str().Fileno = CType(value, string)
												
						Case "CountOpen"
							Me.str().CountOpen = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "CountOpen"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CountOpen = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCLocationOpenViolationCountJurisMetadata.PropertyNames.CountOpen)
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
		
			Public Sub New(ByVal entity As esViewCCLocationOpenViolationCountJuris)
				Me.entity = entity
			End Sub				
		
	
			Public Property Fileno As System.String 
				Get
					Dim data_ As System.String = entity.Fileno
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Fileno = Nothing
					Else
						entity.Fileno = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CountOpen As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.CountOpen
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CountOpen = Nothing
					Else
						entity.CountOpen = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCCLocationOpenViolationCountJuris
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCLocationOpenViolationCountJurisMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCLocationOpenViolationCountJurisQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCLocationOpenViolationCountJurisQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCLocationOpenViolationCountJurisQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCLocationOpenViolationCountJurisQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCLocationOpenViolationCountJurisQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCLocationOpenViolationCountJurisCollection
		Inherits esEntityCollection(Of ViewCCLocationOpenViolationCountJuris)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCLocationOpenViolationCountJurisMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCLocationOpenViolationCountJurisCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCLocationOpenViolationCountJurisQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCLocationOpenViolationCountJurisQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCLocationOpenViolationCountJurisQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCLocationOpenViolationCountJurisQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCLocationOpenViolationCountJurisQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCLocationOpenViolationCountJurisQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCLocationOpenViolationCountJurisQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCLocationOpenViolationCountJurisQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCLocationOpenViolationCountJurisMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "Fileno" 
					Return Me.Fileno
				Case "CountOpen" 
					Return Me.CountOpen
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property Fileno As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationOpenViolationCountJurisMetadata.ColumnNames.Fileno, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CountOpen As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationOpenViolationCountJurisMetadata.ColumnNames.CountOpen, esSystemType.Int32)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCLocationOpenViolationCountJurisMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCLocationOpenViolationCountJurisMetadata.ColumnNames.Fileno, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationOpenViolationCountJurisMetadata.PropertyNames.Fileno
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationOpenViolationCountJurisMetadata.ColumnNames.CountOpen, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCLocationOpenViolationCountJurisMetadata.PropertyNames.CountOpen
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCLocationOpenViolationCountJurisMetadata
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
			 Public Const Fileno As String = "fileno"
			 Public Const CountOpen As String = "CountOpen"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Fileno As String = "Fileno"
			 Public Const CountOpen As String = "CountOpen"
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
			SyncLock GetType(ViewCCLocationOpenViolationCountJurisMetadata)
			
				If ViewCCLocationOpenViolationCountJurisMetadata.mapDelegates Is Nothing Then
					ViewCCLocationOpenViolationCountJurisMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCLocationOpenViolationCountJurisMetadata._meta Is Nothing Then
					ViewCCLocationOpenViolationCountJurisMetadata._meta = New ViewCCLocationOpenViolationCountJurisMetadata()
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
				


				meta.AddTypeMap("Fileno", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CountOpen", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewCCLocationOpenViolationCountJuris"
				meta.Destination = "viewCCLocationOpenViolationCountJuris"
				
				meta.spInsert = "proc_viewCCLocationOpenViolationCountJurisInsert"
				meta.spUpdate = "proc_viewCCLocationOpenViolationCountJurisUpdate"
				meta.spDelete = "proc_viewCCLocationOpenViolationCountJurisDelete"
				meta.spLoadAll = "proc_viewCCLocationOpenViolationCountJurisLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCLocationOpenViolationCountJurisLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCLocationOpenViolationCountJurisMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
