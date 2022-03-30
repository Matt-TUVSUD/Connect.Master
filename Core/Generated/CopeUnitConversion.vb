
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 12/10/2012 9:53:00 AM
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
	' Encapsulates the 'CopeUnitConversion' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(CopeUnitConversion))> _
	<XmlType("CopeUnitConversion")> _	
	Partial Public Class CopeUnitConversion 
		Inherits esCopeUnitConversion
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New CopeUnitConversion()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal english As System.String)
			Dim obj As New CopeUnitConversion()
			obj.English = english
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal english As System.String, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New CopeUnitConversion()
			obj.English = english
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("CopeUnitConversionCollection")> _
	Partial Public Class CopeUnitConversionCollection
		Inherits esCopeUnitConversionCollection
		Implements IEnumerable(Of CopeUnitConversion)
	
		Public Function FindByPrimaryKey(ByVal english As System.String) As CopeUnitConversion
			Return MyBase.SingleOrDefault(Function(e) e.English = english)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(CopeUnitConversion))> _
		Public Class CopeUnitConversionCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of CopeUnitConversionCollection)
			
			Public Shared Widening Operator CType(packet As CopeUnitConversionCollectionWCFPacket) As CopeUnitConversionCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As CopeUnitConversionCollection) As CopeUnitConversionCollectionWCFPacket
				Return New CopeUnitConversionCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class CopeUnitConversionQuery 
		Inherits esCopeUnitConversionQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "CopeUnitConversionQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As CopeUnitConversionQuery) As String
			Return CopeUnitConversionQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As CopeUnitConversionQuery
			Return DirectCast(CopeUnitConversionQuery.SerializeHelper.FromXml(query, GetType(CopeUnitConversionQuery)), CopeUnitConversionQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esCopeUnitConversion
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal english As System.String) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(english)
			Else
				Return LoadByPrimaryKeyStoredProcedure(english)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal english As System.String) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(english)
			Else
				Return LoadByPrimaryKeyStoredProcedure(english)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal english As System.String) As Boolean
		
			Dim query As New CopeUnitConversionQuery()
			query.Where(query.English = english)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal english As System.String) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("English", english)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to CopeUnitConversion.English
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property English As System.String
			Get
				Return MyBase.GetSystemString(CopeUnitConversionMetadata.ColumnNames.English)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeUnitConversionMetadata.ColumnNames.English, value) Then
					OnPropertyChanged(CopeUnitConversionMetadata.PropertyNames.English)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to CopeUnitConversion.Metric
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Metric As System.String
			Get
				Return MyBase.GetSystemString(CopeUnitConversionMetadata.ColumnNames.Metric)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeUnitConversionMetadata.ColumnNames.Metric, value) Then
					OnPropertyChanged(CopeUnitConversionMetadata.PropertyNames.Metric)
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
												
						Case "English"
							Me.str().English = CType(value, string)
												
						Case "Metric"
							Me.str().Metric = CType(value, string)
					
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
		
			Public Sub New(ByVal entity As esCopeUnitConversion)
				Me.entity = entity
			End Sub				
		
	
			Public Property English As System.String 
				Get
					Dim data_ As System.String = entity.English
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.English = Nothing
					Else
						entity.English = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Metric As System.String 
				Get
					Dim data_ As System.String = entity.Metric
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Metric = Nothing
					Else
						entity.Metric = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esCopeUnitConversion
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return CopeUnitConversionMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As CopeUnitConversionQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New CopeUnitConversionQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As CopeUnitConversionQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As CopeUnitConversionQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As CopeUnitConversionQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esCopeUnitConversionCollection
		Inherits esEntityCollection(Of CopeUnitConversion)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return CopeUnitConversionMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "CopeUnitConversionCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As CopeUnitConversionQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New CopeUnitConversionQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As CopeUnitConversionQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New CopeUnitConversionQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As CopeUnitConversionQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, CopeUnitConversionQuery))
		End Sub
		
		#End Region
						
		Private m_query As CopeUnitConversionQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esCopeUnitConversionQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return CopeUnitConversionMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "English" 
					Return Me.English
				Case "Metric" 
					Return Me.Metric
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property English As esQueryItem
			Get
				Return New esQueryItem(Me, CopeUnitConversionMetadata.ColumnNames.English, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Metric As esQueryItem
			Get
				Return New esQueryItem(Me, CopeUnitConversionMetadata.ColumnNames.Metric, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class CopeUnitConversion 
		Inherits esCopeUnitConversion
		
	
		
		
	End Class
		



	<Serializable> _
	Partial Public Class CopeUnitConversionMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(CopeUnitConversionMetadata.ColumnNames.English, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeUnitConversionMetadata.PropertyNames.English
			c.IsInPrimaryKey = True
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeUnitConversionMetadata.ColumnNames.Metric, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeUnitConversionMetadata.PropertyNames.Metric
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As CopeUnitConversionMetadata
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
			 Public Const English As String = "English"
			 Public Const Metric As String = "Metric"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const English As String = "English"
			 Public Const Metric As String = "Metric"
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
			SyncLock GetType(CopeUnitConversionMetadata)
			
				If CopeUnitConversionMetadata.mapDelegates Is Nothing Then
					CopeUnitConversionMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If CopeUnitConversionMetadata._meta Is Nothing Then
					CopeUnitConversionMetadata._meta = New CopeUnitConversionMetadata()
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
				


				meta.AddTypeMap("English", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Metric", new esTypeMap("nvarchar", "System.String"))			
				
				
				 
				meta.Source = "CopeUnitConversion"
				meta.Destination = "CopeUnitConversion"
				
				meta.spInsert = "proc_CopeUnitConversionInsert"
				meta.spUpdate = "proc_CopeUnitConversionUpdate"
				meta.spDelete = "proc_CopeUnitConversionDelete"
				meta.spLoadAll = "proc_CopeUnitConversionLoadAll"
				meta.spLoadByPrimaryKey = "proc_CopeUnitConversionLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As CopeUnitConversionMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
