
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
	' Encapsulates the 'viewCCPrefCustomAccess' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCPrefCustomAccess))> _
	<XmlType("ViewCCPrefCustomAccess")> _	
	Partial Public Class ViewCCPrefCustomAccess 
		Inherits esViewCCPrefCustomAccess
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCPrefCustomAccess()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCPrefCustomAccessCollection")> _
	Partial Public Class ViewCCPrefCustomAccessCollection
		Inherits esViewCCPrefCustomAccessCollection
		Implements IEnumerable(Of ViewCCPrefCustomAccess)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCPrefCustomAccess))> _
		Public Class ViewCCPrefCustomAccessCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCPrefCustomAccessCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCPrefCustomAccessCollectionWCFPacket) As ViewCCPrefCustomAccessCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCPrefCustomAccessCollection) As ViewCCPrefCustomAccessCollectionWCFPacket
				Return New ViewCCPrefCustomAccessCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCPrefCustomAccessQuery 
		Inherits esViewCCPrefCustomAccessQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCPrefCustomAccessQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCPrefCustomAccessQuery) As String
			Return ViewCCPrefCustomAccessQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCPrefCustomAccessQuery
			Return DirectCast(ViewCCPrefCustomAccessQuery.SerializeHelper.FromXml(query, GetType(ViewCCPrefCustomAccessQuery)), ViewCCPrefCustomAccessQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCPrefCustomAccess
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCPrefCustomAccess.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As System.String
			Get
				Return MyBase.GetSystemString(ViewCCPrefCustomAccessMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCPrefCustomAccessMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(ViewCCPrefCustomAccessMetadata.PropertyNames.FilePrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCPrefCustomAccess.Location
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Location As System.String
			Get
				Return MyBase.GetSystemString(ViewCCPrefCustomAccessMetadata.ColumnNames.Location)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCPrefCustomAccessMetadata.ColumnNames.Location, value) Then
					OnPropertyChanged(ViewCCPrefCustomAccessMetadata.PropertyNames.Location)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCPrefCustomAccess.CustomAccess
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CustomAccess As System.String
			Get
				Return MyBase.GetSystemString(ViewCCPrefCustomAccessMetadata.ColumnNames.CustomAccess)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCPrefCustomAccessMetadata.ColumnNames.CustomAccess, value) Then
					OnPropertyChanged(ViewCCPrefCustomAccessMetadata.PropertyNames.CustomAccess)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCPrefCustomAccess.Division
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Division As System.String
			Get
				Return MyBase.GetSystemString(ViewCCPrefCustomAccessMetadata.ColumnNames.Division)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCPrefCustomAccessMetadata.ColumnNames.Division, value) Then
					OnPropertyChanged(ViewCCPrefCustomAccessMetadata.PropertyNames.Division)
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
												
						Case "FilePrefix"
							Me.str().FilePrefix = CType(value, string)
												
						Case "Location"
							Me.str().Location = CType(value, string)
												
						Case "CustomAccess"
							Me.str().CustomAccess = CType(value, string)
												
						Case "Division"
							Me.str().Division = CType(value, string)
					
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
		
			Public Sub New(ByVal entity As esViewCCPrefCustomAccess)
				Me.entity = entity
			End Sub				
		
	
			Public Property FilePrefix As System.String 
				Get
					Dim data_ As System.String = entity.FilePrefix
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FilePrefix = Nothing
					Else
						entity.FilePrefix = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Location As System.String 
				Get
					Dim data_ As System.String = entity.Location
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Location = Nothing
					Else
						entity.Location = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CustomAccess As System.String 
				Get
					Dim data_ As System.String = entity.CustomAccess
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CustomAccess = Nothing
					Else
						entity.CustomAccess = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Division As System.String 
				Get
					Dim data_ As System.String = entity.Division
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Division = Nothing
					Else
						entity.Division = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCCPrefCustomAccess
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCPrefCustomAccessMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCPrefCustomAccessQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCPrefCustomAccessQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCPrefCustomAccessQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCPrefCustomAccessQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCPrefCustomAccessQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCPrefCustomAccessCollection
		Inherits esEntityCollection(Of ViewCCPrefCustomAccess)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCPrefCustomAccessMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCPrefCustomAccessCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCPrefCustomAccessQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCPrefCustomAccessQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCPrefCustomAccessQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCPrefCustomAccessQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCPrefCustomAccessQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCPrefCustomAccessQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCPrefCustomAccessQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCPrefCustomAccessQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCPrefCustomAccessMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "FilePrefix" 
					Return Me.FilePrefix
				Case "Location" 
					Return Me.Location
				Case "CustomAccess" 
					Return Me.CustomAccess
				Case "Division" 
					Return Me.Division
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FilePrefix As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCPrefCustomAccessMetadata.ColumnNames.FilePrefix, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Location As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCPrefCustomAccessMetadata.ColumnNames.Location, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CustomAccess As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCPrefCustomAccessMetadata.ColumnNames.CustomAccess, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Division As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCPrefCustomAccessMetadata.ColumnNames.Division, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCPrefCustomAccessMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCPrefCustomAccessMetadata.ColumnNames.FilePrefix, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCPrefCustomAccessMetadata.PropertyNames.FilePrefix
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCPrefCustomAccessMetadata.ColumnNames.Location, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCPrefCustomAccessMetadata.PropertyNames.Location
			c.CharacterMaxLength = 40
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCPrefCustomAccessMetadata.ColumnNames.CustomAccess, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCPrefCustomAccessMetadata.PropertyNames.CustomAccess
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCPrefCustomAccessMetadata.ColumnNames.Division, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCPrefCustomAccessMetadata.PropertyNames.Division
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCPrefCustomAccessMetadata
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
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const Location As String = "Location"
			 Public Const CustomAccess As String = "CustomAccess"
			 Public Const Division As String = "Division"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const Location As String = "Location"
			 Public Const CustomAccess As String = "CustomAccess"
			 Public Const Division As String = "Division"
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
			SyncLock GetType(ViewCCPrefCustomAccessMetadata)
			
				If ViewCCPrefCustomAccessMetadata.mapDelegates Is Nothing Then
					ViewCCPrefCustomAccessMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCPrefCustomAccessMetadata._meta Is Nothing Then
					ViewCCPrefCustomAccessMetadata._meta = New ViewCCPrefCustomAccessMetadata()
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
				


				meta.AddTypeMap("FilePrefix", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Location", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("CustomAccess", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Division", new esTypeMap("nvarchar", "System.String"))			
				
				
				 
				meta.Source = "viewCCPrefCustomAccess"
				meta.Destination = "viewCCPrefCustomAccess"
				
				meta.spInsert = "proc_viewCCPrefCustomAccessInsert"
				meta.spUpdate = "proc_viewCCPrefCustomAccessUpdate"
				meta.spDelete = "proc_viewCCPrefCustomAccessDelete"
				meta.spLoadAll = "proc_viewCCPrefCustomAccessLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCPrefCustomAccessLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCPrefCustomAccessMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
