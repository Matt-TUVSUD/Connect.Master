
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
	' Encapsulates the 'viewCCPrefCurrency' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCPrefCurrency))> _
	<XmlType("ViewCCPrefCurrency")> _	
	Partial Public Class ViewCCPrefCurrency 
		Inherits esViewCCPrefCurrency
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCPrefCurrency()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCPrefCurrencyCollection")> _
	Partial Public Class ViewCCPrefCurrencyCollection
		Inherits esViewCCPrefCurrencyCollection
		Implements IEnumerable(Of ViewCCPrefCurrency)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCPrefCurrency))> _
		Public Class ViewCCPrefCurrencyCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCPrefCurrencyCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCPrefCurrencyCollectionWCFPacket) As ViewCCPrefCurrencyCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCPrefCurrencyCollection) As ViewCCPrefCurrencyCollectionWCFPacket
				Return New ViewCCPrefCurrencyCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCPrefCurrencyQuery 
		Inherits esViewCCPrefCurrencyQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCPrefCurrencyQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCPrefCurrencyQuery) As String
			Return ViewCCPrefCurrencyQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCPrefCurrencyQuery
			Return DirectCast(ViewCCPrefCurrencyQuery.SerializeHelper.FromXml(query, GetType(ViewCCPrefCurrencyQuery)), ViewCCPrefCurrencyQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCPrefCurrency
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCPrefCurrency.Code
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Code As System.String
			Get
				Return MyBase.GetSystemString(ViewCCPrefCurrencyMetadata.ColumnNames.Code)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCPrefCurrencyMetadata.ColumnNames.Code, value) Then
					OnPropertyChanged(ViewCCPrefCurrencyMetadata.PropertyNames.Code)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCPrefCurrency.Currency
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Currency As System.String
			Get
				Return MyBase.GetSystemString(ViewCCPrefCurrencyMetadata.ColumnNames.Currency)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCPrefCurrencyMetadata.ColumnNames.Currency, value) Then
					OnPropertyChanged(ViewCCPrefCurrencyMetadata.PropertyNames.Currency)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCPrefCurrency.Symbol
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Symbol As System.String
			Get
				Return MyBase.GetSystemString(ViewCCPrefCurrencyMetadata.ColumnNames.Symbol)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCPrefCurrencyMetadata.ColumnNames.Symbol, value) Then
					OnPropertyChanged(ViewCCPrefCurrencyMetadata.PropertyNames.Symbol)
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
												
						Case "Code"
							Me.str().Code = CType(value, string)
												
						Case "Currency"
							Me.str().Currency = CType(value, string)
												
						Case "Symbol"
							Me.str().Symbol = CType(value, string)
					
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
		
			Public Sub New(ByVal entity As esViewCCPrefCurrency)
				Me.entity = entity
			End Sub				
		
	
			Public Property Code As System.String 
				Get
					Dim data_ As System.String = entity.Code
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Code = Nothing
					Else
						entity.Code = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Currency As System.String 
				Get
					Dim data_ As System.String = entity.Currency
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Currency = Nothing
					Else
						entity.Currency = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Symbol As System.String 
				Get
					Dim data_ As System.String = entity.Symbol
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Symbol = Nothing
					Else
						entity.Symbol = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCCPrefCurrency
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCPrefCurrencyMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCPrefCurrencyQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCPrefCurrencyQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCPrefCurrencyQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCPrefCurrencyQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCPrefCurrencyQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCPrefCurrencyCollection
		Inherits esEntityCollection(Of ViewCCPrefCurrency)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCPrefCurrencyMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCPrefCurrencyCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCPrefCurrencyQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCPrefCurrencyQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCPrefCurrencyQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCPrefCurrencyQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCPrefCurrencyQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCPrefCurrencyQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCPrefCurrencyQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCPrefCurrencyQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCPrefCurrencyMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "Code" 
					Return Me.Code
				Case "Currency" 
					Return Me.Currency
				Case "Symbol" 
					Return Me.Symbol
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property Code As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCPrefCurrencyMetadata.ColumnNames.Code, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Currency As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCPrefCurrencyMetadata.ColumnNames.Currency, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Symbol As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCPrefCurrencyMetadata.ColumnNames.Symbol, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCPrefCurrencyMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCPrefCurrencyMetadata.ColumnNames.Code, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCPrefCurrencyMetadata.PropertyNames.Code
			c.CharacterMaxLength = 3
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCPrefCurrencyMetadata.ColumnNames.Currency, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCPrefCurrencyMetadata.PropertyNames.Currency
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCPrefCurrencyMetadata.ColumnNames.Symbol, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCPrefCurrencyMetadata.PropertyNames.Symbol
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCPrefCurrencyMetadata
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
			 Public Const Code As String = "Code"
			 Public Const Currency As String = "Currency"
			 Public Const Symbol As String = "Symbol"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Code As String = "Code"
			 Public Const Currency As String = "Currency"
			 Public Const Symbol As String = "Symbol"
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
			SyncLock GetType(ViewCCPrefCurrencyMetadata)
			
				If ViewCCPrefCurrencyMetadata.mapDelegates Is Nothing Then
					ViewCCPrefCurrencyMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCPrefCurrencyMetadata._meta Is Nothing Then
					ViewCCPrefCurrencyMetadata._meta = New ViewCCPrefCurrencyMetadata()
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
				


				meta.AddTypeMap("Code", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Currency", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Symbol", new esTypeMap("nvarchar", "System.String"))			
				
				
				 
				meta.Source = "viewCCPrefCurrency"
				meta.Destination = "viewCCPrefCurrency"
				
				meta.spInsert = "proc_viewCCPrefCurrencyInsert"
				meta.spUpdate = "proc_viewCCPrefCurrencyUpdate"
				meta.spDelete = "proc_viewCCPrefCurrencyDelete"
				meta.spLoadAll = "proc_viewCCPrefCurrencyLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCPrefCurrencyLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCPrefCurrencyMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
